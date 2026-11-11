#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDPlayerXPStats<br/>
/// (size = 1428)
/// (flags = 32786)
/// </summary>
public partial class GDPlayerXPStats : BmSDK.SDEngine.SDFireteamObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDPlayerXPStats", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDPlayerXPStats.
    /// </summary>
    public static GDPlayerXPStats DefaultObject => (GDPlayerXPStats)StaticClass().DefaultObject;

    internal GDPlayerXPStats() { }

    /// <summary>
    /// Constructs a new GDPlayerXPStats
    /// </summary>
    public GDPlayerXPStats(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDPlayerXPStats Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDPlayerXPStats(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDPlayerXPStats>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPlayerXPStats>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDPlayerXPStats>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPlayerXPStats>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPlayerXPStats>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPlayerXPStats>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDPlayerXPStats>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPlayerXPStats>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// IntProperty: Thug_NormalKillThug_TimesAwarded
    /// </summary>
    public unsafe int Thug_NormalKillThug_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// IntProperty: Thug_NormalKillThug_XPEarned
    /// </summary>
    public unsafe int Thug_NormalKillThug_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// IntProperty: Thug_NormalKillThug_TimesEarnedAsHero
    /// </summary>
    public unsafe int Thug_NormalKillThug_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// IntProperty: Thug_NormalKillThug_TimesEarnedAsBane
    /// </summary>
    public unsafe int Thug_NormalKillThug_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// IntProperty: Thug_NormalKillThug_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Thug_NormalKillThug_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// IntProperty: Thug_MeleeKillThug_TimesAwarded
    /// </summary>
    public unsafe int Thug_MeleeKillThug_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// IntProperty: Thug_MeleeKillThug_XPEarned
    /// </summary>
    public unsafe int Thug_MeleeKillThug_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }

    /// <summary>
    /// IntProperty: Thug_MeleeKillThug_TimesEarnedAsHero
    /// </summary>
    public unsafe int Thug_MeleeKillThug_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }

    /// <summary>
    /// IntProperty: Thug_MeleeKillThug_TimesEarnedAsBane
    /// </summary>
    public unsafe int Thug_MeleeKillThug_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// IntProperty: Thug_MeleeKillThug_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Thug_MeleeKillThug_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// IntProperty: Thug_GrenadeKillThug_TimesAwarded
    /// </summary>
    public unsafe int Thug_GrenadeKillThug_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// IntProperty: Thug_GrenadeKillThug_XPEarned
    /// </summary>
    public unsafe int Thug_GrenadeKillThug_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// IntProperty: Thug_GrenadeKillThug_TimesEarnedAsHero
    /// </summary>
    public unsafe int Thug_GrenadeKillThug_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// IntProperty: Thug_GrenadeKillThug_TimesEarnedAsBane
    /// </summary>
    public unsafe int Thug_GrenadeKillThug_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// IntProperty: Thug_GrenadeKillThug_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Thug_GrenadeKillThug_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// IntProperty: Thug_SpecialKillThug_TimesAwarded
    /// </summary>
    public unsafe int Thug_SpecialKillThug_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// IntProperty: Thug_SpecialKillThug_XPEarned
    /// </summary>
    public unsafe int Thug_SpecialKillThug_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// IntProperty: Thug_SpecialKillThug_TimesEarnedAsHero
    /// </summary>
    public unsafe int Thug_SpecialKillThug_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// IntProperty: Thug_SpecialKillThug_TimesEarnedAsBane
    /// </summary>
    public unsafe int Thug_SpecialKillThug_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// IntProperty: Thug_SpecialKillThug_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Thug_SpecialKillThug_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// IntProperty: Thug_AssistKillThug_TimesAwarded
    /// </summary>
    public unsafe int Thug_AssistKillThug_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// IntProperty: Thug_AssistKillThug_XPEarned
    /// </summary>
    public unsafe int Thug_AssistKillThug_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// IntProperty: Thug_AssistKillThug_TimesEarnedAsHero
    /// </summary>
    public unsafe int Thug_AssistKillThug_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// IntProperty: Thug_AssistKillThug_TimesEarnedAsBane
    /// </summary>
    public unsafe int Thug_AssistKillThug_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// IntProperty: Thug_AssistKillThug_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Thug_AssistKillThug_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// IntProperty: Thug_NormalKillHero_TimesAwarded
    /// </summary>
    public unsafe int Thug_NormalKillHero_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// IntProperty: Thug_NormalKillHero_XPEarned
    /// </summary>
    public unsafe int Thug_NormalKillHero_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// IntProperty: Thug_NormalKillHero_TimesEarnedAsHero
    /// </summary>
    public unsafe int Thug_NormalKillHero_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// IntProperty: Thug_NormalKillHero_TimesEarnedAsBane
    /// </summary>
    public unsafe int Thug_NormalKillHero_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// IntProperty: Thug_NormalKillHero_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Thug_NormalKillHero_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// IntProperty: Thug_MeleeKillHero_TimesAwarded
    /// </summary>
    public unsafe int Thug_MeleeKillHero_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// IntProperty: Thug_MeleeKillHero_XPEarned
    /// </summary>
    public unsafe int Thug_MeleeKillHero_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// IntProperty: Thug_MeleeKillHero_TimesEarnedAsHero
    /// </summary>
    public unsafe int Thug_MeleeKillHero_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// IntProperty: Thug_MeleeKillHero_TimesEarnedAsBane
    /// </summary>
    public unsafe int Thug_MeleeKillHero_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// IntProperty: Thug_MeleeKillHero_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Thug_MeleeKillHero_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// IntProperty: Thug_GrenadeKillHero_TimesAwarded
    /// </summary>
    public unsafe int Thug_GrenadeKillHero_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// IntProperty: Thug_GrenadeKillHero_XPEarned
    /// </summary>
    public unsafe int Thug_GrenadeKillHero_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// IntProperty: Thug_GrenadeKillHero_TimesEarnedAsHero
    /// </summary>
    public unsafe int Thug_GrenadeKillHero_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// IntProperty: Thug_GrenadeKillHero_TimesEarnedAsBane
    /// </summary>
    public unsafe int Thug_GrenadeKillHero_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// IntProperty: Thug_GrenadeKillHero_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Thug_GrenadeKillHero_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// IntProperty: Thug_SpecialKillHero_TimesAwarded
    /// </summary>
    public unsafe int Thug_SpecialKillHero_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// IntProperty: Thug_SpecialKillHero_XPEarned
    /// </summary>
    public unsafe int Thug_SpecialKillHero_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// IntProperty: Thug_SpecialKillHero_TimesEarnedAsHero
    /// </summary>
    public unsafe int Thug_SpecialKillHero_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// IntProperty: Thug_SpecialKillHero_TimesEarnedAsBane
    /// </summary>
    public unsafe int Thug_SpecialKillHero_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// IntProperty: Thug_SpecialKillHero_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Thug_SpecialKillHero_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// IntProperty: Thug_AssistKillHero_TimesAwarded
    /// </summary>
    public unsafe int Thug_AssistKillHero_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// IntProperty: Thug_AssistKillHero_XPEarned
    /// </summary>
    public unsafe int Thug_AssistKillHero_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// IntProperty: Thug_AssistKillHero_TimesEarnedAsHero
    /// </summary>
    public unsafe int Thug_AssistKillHero_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// IntProperty: Thug_AssistKillHero_TimesEarnedAsBane
    /// </summary>
    public unsafe int Thug_AssistKillHero_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// IntProperty: Thug_AssistKillHero_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Thug_AssistKillHero_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// IntProperty: Thug_MidTakedownKillHero_TimesAwarded
    /// </summary>
    public unsafe int Thug_MidTakedownKillHero_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// IntProperty: Thug_MidTakedownKillHero_XPEarned
    /// </summary>
    public unsafe int Thug_MidTakedownKillHero_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// IntProperty: Thug_MidTakedownKillHero_TimesEarnedAsHero
    /// </summary>
    public unsafe int Thug_MidTakedownKillHero_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// IntProperty: Thug_MidTakedownKillHero_TimesEarnedAsBane
    /// </summary>
    public unsafe int Thug_MidTakedownKillHero_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// IntProperty: Thug_MidTakedownKillHero_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Thug_MidTakedownKillHero_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// IntProperty: Thug_MidHackKillHero_TimesAwarded
    /// </summary>
    public unsafe int Thug_MidHackKillHero_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// IntProperty: Thug_MidHackKillHero_XPEarned
    /// </summary>
    public unsafe int Thug_MidHackKillHero_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// IntProperty: Thug_MidHackKillHero_TimesEarnedAsHero
    /// </summary>
    public unsafe int Thug_MidHackKillHero_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// IntProperty: Thug_MidHackKillHero_TimesEarnedAsBane
    /// </summary>
    public unsafe int Thug_MidHackKillHero_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// IntProperty: Thug_MidHackKillHero_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Thug_MidHackKillHero_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// IntProperty: Thug_GangleaderKill_TimesAwarded
    /// </summary>
    public unsafe int Thug_GangleaderKill_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// IntProperty: Thug_GangleaderKill_XPEarned
    /// </summary>
    public unsafe int Thug_GangleaderKill_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// IntProperty: Thug_GangleaderKill_TimesEarnedAsHero
    /// </summary>
    public unsafe int Thug_GangleaderKill_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// IntProperty: Thug_GangleaderKill_TimesEarnedAsBane
    /// </summary>
    public unsafe int Thug_GangleaderKill_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// IntProperty: Thug_GangleaderKill_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Thug_GangleaderKill_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// IntProperty: Thug_ControlPointCaptured_TimesAwarded
    /// </summary>
    public unsafe int Thug_ControlPointCaptured_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// IntProperty: Thug_ControlPointCaptured_XPEarned
    /// </summary>
    public unsafe int Thug_ControlPointCaptured_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// IntProperty: Thug_ControlPointCaptured_TimesEarnedAsHero
    /// </summary>
    public unsafe int Thug_ControlPointCaptured_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// IntProperty: Thug_ControlPointCaptured_TimesEarnedAsBane
    /// </summary>
    public unsafe int Thug_ControlPointCaptured_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// IntProperty: Thug_ControlPointCaptured_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Thug_ControlPointCaptured_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// IntProperty: Thug_ControlPointSecured_TimesAwarded
    /// </summary>
    public unsafe int Thug_ControlPointSecured_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// IntProperty: Thug_ControlPointSecured_XPEarned
    /// </summary>
    public unsafe int Thug_ControlPointSecured_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// IntProperty: Thug_ControlPointSecured_TimesEarnedAsHero
    /// </summary>
    public unsafe int Thug_ControlPointSecured_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// IntProperty: Thug_ControlPointSecured_TimesEarnedAsBane
    /// </summary>
    public unsafe int Thug_ControlPointSecured_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// IntProperty: Thug_ControlPointSecured_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Thug_ControlPointSecured_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }

    /// <summary>
    /// IntProperty: Thug_ControlPointNeutralized_TimesAwarded
    /// </summary>
    public unsafe int Thug_ControlPointNeutralized_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// IntProperty: Thug_ControlPointNeutralized_XPEarned
    /// </summary>
    public unsafe int Thug_ControlPointNeutralized_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// IntProperty: Thug_ControlPointNeutralized_TimesEarnedAsHero
    /// </summary>
    public unsafe int Thug_ControlPointNeutralized_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// IntProperty: Thug_ControlPointNeutralized_TimesEarnedAsBane
    /// </summary>
    public unsafe int Thug_ControlPointNeutralized_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// IntProperty: Thug_ControlPointNeutralized_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Thug_ControlPointNeutralized_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// IntProperty: Thug_ControlPointCleared_TimesAwarded
    /// </summary>
    public unsafe int Thug_ControlPointCleared_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// IntProperty: Thug_ControlPointCleared_XPEarned
    /// </summary>
    public unsafe int Thug_ControlPointCleared_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// IntProperty: Thug_ControlPointCleared_TimesEarnedAsHero
    /// </summary>
    public unsafe int Thug_ControlPointCleared_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// IntProperty: Thug_ControlPointCleared_TimesEarnedAsBane
    /// </summary>
    public unsafe int Thug_ControlPointCleared_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// IntProperty: Thug_ControlPointCleared_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Thug_ControlPointCleared_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// IntProperty: Thug_FinaleExitReached_TimesAwarded
    /// </summary>
    public unsafe int Thug_FinaleExitReached_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// IntProperty: Thug_FinaleExitReached_XPEarned
    /// </summary>
    public unsafe int Thug_FinaleExitReached_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// IntProperty: Thug_FinaleExitReached_TimesEarnedAsHero
    /// </summary>
    public unsafe int Thug_FinaleExitReached_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// IntProperty: Thug_FinaleExitReached_TimesEarnedAsBane
    /// </summary>
    public unsafe int Thug_FinaleExitReached_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// IntProperty: Thug_FinaleExitReached_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Thug_FinaleExitReached_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// IntProperty: Thug_FinaleThugKilled_TimesAwarded
    /// </summary>
    public unsafe int Thug_FinaleThugKilled_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// IntProperty: Thug_FinaleThugKilled_XPEarned
    /// </summary>
    public unsafe int Thug_FinaleThugKilled_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// IntProperty: Thug_FinaleThugKilled_TimesEarnedAsHero
    /// </summary>
    public unsafe int Thug_FinaleThugKilled_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// IntProperty: Thug_FinaleThugKilled_TimesEarnedAsBane
    /// </summary>
    public unsafe int Thug_FinaleThugKilled_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// IntProperty: Thug_FinaleThugKilled_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Thug_FinaleThugKilled_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// IntProperty: Thug_FinaleExitReachedBonusXP_TimesAwarded
    /// </summary>
    public unsafe int Thug_FinaleExitReachedBonusXP_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// IntProperty: Thug_FinaleExitReachedBonusXP_XPEarned
    /// </summary>
    public unsafe int Thug_FinaleExitReachedBonusXP_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// IntProperty: Thug_FinaleExitReachedBonusXP_TimesEarnedAsHero
    /// </summary>
    public unsafe int Thug_FinaleExitReachedBonusXP_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// IntProperty: Thug_FinaleExitReachedBonusXP_TimesEarnedAsBane
    /// </summary>
    public unsafe int Thug_FinaleExitReachedBonusXP_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// IntProperty: Thug_FinaleExitReachedBonusXP_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Thug_FinaleExitReachedBonusXP_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// IntProperty: Hero_HangingTakedown_TimesAwarded
    /// </summary>
    public unsafe int Hero_HangingTakedown_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// IntProperty: Hero_HangingTakedown_XPEarned
    /// </summary>
    public unsafe int Hero_HangingTakedown_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// IntProperty: Hero_HangingTakedown_TimesEarnedAsHero
    /// </summary>
    public unsafe int Hero_HangingTakedown_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// IntProperty: Hero_HangingTakedown_TimesEarnedAsBane
    /// </summary>
    public unsafe int Hero_HangingTakedown_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// IntProperty: Hero_HangingTakedown_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Hero_HangingTakedown_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// IntProperty: Hero_FloorTakedown_TimesAwarded
    /// </summary>
    public unsafe int Hero_FloorTakedown_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// IntProperty: Hero_FloorTakedown_XPEarned
    /// </summary>
    public unsafe int Hero_FloorTakedown_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// IntProperty: Hero_FloorTakedown_TimesEarnedAsHero
    /// </summary>
    public unsafe int Hero_FloorTakedown_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// IntProperty: Hero_FloorTakedown_TimesEarnedAsBane
    /// </summary>
    public unsafe int Hero_FloorTakedown_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// IntProperty: Hero_FloorTakedown_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Hero_FloorTakedown_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// IntProperty: Hero_TunnelTakedown_TimesAwarded
    /// </summary>
    public unsafe int Hero_TunnelTakedown_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// IntProperty: Hero_TunnelTakedown_XPEarned
    /// </summary>
    public unsafe int Hero_TunnelTakedown_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// IntProperty: Hero_TunnelTakedown_TimesEarnedAsHero
    /// </summary>
    public unsafe int Hero_TunnelTakedown_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// IntProperty: Hero_TunnelTakedown_TimesEarnedAsBane
    /// </summary>
    public unsafe int Hero_TunnelTakedown_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// IntProperty: Hero_TunnelTakedown_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Hero_TunnelTakedown_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// IntProperty: Hero_VentTakedown_TimesAwarded
    /// </summary>
    public unsafe int Hero_VentTakedown_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// IntProperty: Hero_VentTakedown_XPEarned
    /// </summary>
    public unsafe int Hero_VentTakedown_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// IntProperty: Hero_VentTakedown_TimesEarnedAsHero
    /// </summary>
    public unsafe int Hero_VentTakedown_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// IntProperty: Hero_VentTakedown_TimesEarnedAsBane
    /// </summary>
    public unsafe int Hero_VentTakedown_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// IntProperty: Hero_VentTakedown_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Hero_VentTakedown_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// IntProperty: Hero_GlassTakedown_TimesAwarded
    /// </summary>
    public unsafe int Hero_GlassTakedown_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// IntProperty: Hero_GlassTakedown_XPEarned
    /// </summary>
    public unsafe int Hero_GlassTakedown_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// IntProperty: Hero_GlassTakedown_TimesEarnedAsHero
    /// </summary>
    public unsafe int Hero_GlassTakedown_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// IntProperty: Hero_GlassTakedown_TimesEarnedAsBane
    /// </summary>
    public unsafe int Hero_GlassTakedown_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// IntProperty: Hero_GlassTakedown_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Hero_GlassTakedown_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// IntProperty: Hero_WallTakedown_TimesAwarded
    /// </summary>
    public unsafe int Hero_WallTakedown_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// IntProperty: Hero_WallTakedown_XPEarned
    /// </summary>
    public unsafe int Hero_WallTakedown_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// IntProperty: Hero_WallTakedown_TimesEarnedAsHero
    /// </summary>
    public unsafe int Hero_WallTakedown_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// IntProperty: Hero_WallTakedown_TimesEarnedAsBane
    /// </summary>
    public unsafe int Hero_WallTakedown_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// IntProperty: Hero_WallTakedown_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Hero_WallTakedown_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// IntProperty: Hero_DoubleTakedown_TimesAwarded
    /// </summary>
    public unsafe int Hero_DoubleTakedown_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// IntProperty: Hero_DoubleTakedown_XPEarned
    /// </summary>
    public unsafe int Hero_DoubleTakedown_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// IntProperty: Hero_DoubleTakedown_TimesEarnedAsHero
    /// </summary>
    public unsafe int Hero_DoubleTakedown_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// IntProperty: Hero_DoubleTakedown_TimesEarnedAsBane
    /// </summary>
    public unsafe int Hero_DoubleTakedown_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// IntProperty: Hero_DoubleTakedown_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Hero_DoubleTakedown_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// IntProperty: Hero_KnockoutSmashTakedown_TimesAwarded
    /// </summary>
    public unsafe int Hero_KnockoutSmashTakedown_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// IntProperty: Hero_KnockoutSmashTakedown_XPEarned
    /// </summary>
    public unsafe int Hero_KnockoutSmashTakedown_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// IntProperty: Hero_KnockoutSmashTakedown_TimesEarnedAsHero
    /// </summary>
    public unsafe int Hero_KnockoutSmashTakedown_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// IntProperty: Hero_KnockoutSmashTakedown_TimesEarnedAsBane
    /// </summary>
    public unsafe int Hero_KnockoutSmashTakedown_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// IntProperty: Hero_KnockoutSmashTakedown_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Hero_KnockoutSmashTakedown_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// IntProperty: Hero_SneakyTakedown_TimesAwarded
    /// </summary>
    public unsafe int Hero_SneakyTakedown_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// IntProperty: Hero_SneakyTakedown_XPEarned
    /// </summary>
    public unsafe int Hero_SneakyTakedown_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// IntProperty: Hero_SneakyTakedown_TimesEarnedAsHero
    /// </summary>
    public unsafe int Hero_SneakyTakedown_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// IntProperty: Hero_SneakyTakedown_TimesEarnedAsBane
    /// </summary>
    public unsafe int Hero_SneakyTakedown_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// IntProperty: Hero_SneakyTakedown_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Hero_SneakyTakedown_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// IntProperty: Hero_DoubleLedgeTakedown_TimesAwarded
    /// </summary>
    public unsafe int Hero_DoubleLedgeTakedown_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// IntProperty: Hero_DoubleLedgeTakedown_XPEarned
    /// </summary>
    public unsafe int Hero_DoubleLedgeTakedown_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// IntProperty: Hero_DoubleLedgeTakedown_TimesEarnedAsHero
    /// </summary>
    public unsafe int Hero_DoubleLedgeTakedown_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// IntProperty: Hero_DoubleLedgeTakedown_TimesEarnedAsBane
    /// </summary>
    public unsafe int Hero_DoubleLedgeTakedown_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// IntProperty: Hero_DoubleLedgeTakedown_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Hero_DoubleLedgeTakedown_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// IntProperty: Hero_RailingTakedown_TimesAwarded
    /// </summary>
    public unsafe int Hero_RailingTakedown_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// IntProperty: Hero_RailingTakedown_XPEarned
    /// </summary>
    public unsafe int Hero_RailingTakedown_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// IntProperty: Hero_RailingTakedown_TimesEarnedAsHero
    /// </summary>
    public unsafe int Hero_RailingTakedown_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// IntProperty: Hero_RailingTakedown_TimesEarnedAsBane
    /// </summary>
    public unsafe int Hero_RailingTakedown_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// IntProperty: Hero_RailingTakedown_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Hero_RailingTakedown_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// IntProperty: Hero_LedgeTakedown_TimesAwarded
    /// </summary>
    public unsafe int Hero_LedgeTakedown_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// IntProperty: Hero_LedgeTakedown_XPEarned
    /// </summary>
    public unsafe int Hero_LedgeTakedown_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// IntProperty: Hero_LedgeTakedown_TimesEarnedAsHero
    /// </summary>
    public unsafe int Hero_LedgeTakedown_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// IntProperty: Hero_LedgeTakedown_TimesEarnedAsBane
    /// </summary>
    public unsafe int Hero_LedgeTakedown_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// IntProperty: Hero_LedgeTakedown_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Hero_LedgeTakedown_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// IntProperty: Hero_ReverseChokeTakedown_TimesAwarded
    /// </summary>
    public unsafe int Hero_ReverseChokeTakedown_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// IntProperty: Hero_ReverseChokeTakedown_XPEarned
    /// </summary>
    public unsafe int Hero_ReverseChokeTakedown_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// IntProperty: Hero_ReverseChokeTakedown_TimesEarnedAsHero
    /// </summary>
    public unsafe int Hero_ReverseChokeTakedown_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// IntProperty: Hero_ReverseChokeTakedown_TimesEarnedAsBane
    /// </summary>
    public unsafe int Hero_ReverseChokeTakedown_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// IntProperty: Hero_ReverseChokeTakedown_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Hero_ReverseChokeTakedown_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// IntProperty: Hero_CornerTakedown_TimesAwarded
    /// </summary>
    public unsafe int Hero_CornerTakedown_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// IntProperty: Hero_CornerTakedown_XPEarned
    /// </summary>
    public unsafe int Hero_CornerTakedown_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// IntProperty: Hero_CornerTakedown_TimesEarnedAsHero
    /// </summary>
    public unsafe int Hero_CornerTakedown_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// IntProperty: Hero_CornerTakedown_TimesEarnedAsBane
    /// </summary>
    public unsafe int Hero_CornerTakedown_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// IntProperty: Hero_CornerTakedown_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Hero_CornerTakedown_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// IntProperty: Hero_Knockout_TimesAwarded
    /// </summary>
    public unsafe int Hero_Knockout_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// IntProperty: Hero_Knockout_XPEarned
    /// </summary>
    public unsafe int Hero_Knockout_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// IntProperty: Hero_Knockout_TimesEarnedAsHero
    /// </summary>
    public unsafe int Hero_Knockout_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// IntProperty: Hero_Knockout_TimesEarnedAsBane
    /// </summary>
    public unsafe int Hero_Knockout_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// IntProperty: Hero_Knockout_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Hero_Knockout_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// IntProperty: Hero_Assist_TimesAwarded
    /// </summary>
    public unsafe int Hero_Assist_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// IntProperty: Hero_Assist_XPEarned
    /// </summary>
    public unsafe int Hero_Assist_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// IntProperty: Hero_Assist_TimesEarnedAsHero
    /// </summary>
    public unsafe int Hero_Assist_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// IntProperty: Hero_Assist_TimesEarnedAsBane
    /// </summary>
    public unsafe int Hero_Assist_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// IntProperty: Hero_Assist_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Hero_Assist_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// IntProperty: Hero_TechnicalAssist_TimesAwarded
    /// </summary>
    public unsafe int Hero_TechnicalAssist_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// IntProperty: Hero_TechnicalAssist_XPEarned
    /// </summary>
    public unsafe int Hero_TechnicalAssist_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// IntProperty: Hero_TechnicalAssist_TimesEarnedAsHero
    /// </summary>
    public unsafe int Hero_TechnicalAssist_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// IntProperty: Hero_TechnicalAssist_TimesEarnedAsBane
    /// </summary>
    public unsafe int Hero_TechnicalAssist_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// IntProperty: Hero_TechnicalAssist_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Hero_TechnicalAssist_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// IntProperty: Hero_UNUSED_TimesAwarded
    /// </summary>
    public unsafe int Hero_UNUSED_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// IntProperty: Hero_UNUSED_XPEarned
    /// </summary>
    public unsafe int Hero_UNUSED_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// IntProperty: Hero_UNUSED_TimesEarnedAsHero
    /// </summary>
    public unsafe int Hero_UNUSED_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// IntProperty: Hero_UNUSED_TimesEarnedAsBane
    /// </summary>
    public unsafe int Hero_UNUSED_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// IntProperty: Hero_UNUSED_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Hero_UNUSED_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// IntProperty: Hero_CompleteControl_TimesAwarded
    /// </summary>
    public unsafe int Hero_CompleteControl_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// IntProperty: Hero_CompleteControl_XPEarned
    /// </summary>
    public unsafe int Hero_CompleteControl_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// IntProperty: Hero_CompleteControl_TimesEarnedAsHero
    /// </summary>
    public unsafe int Hero_CompleteControl_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// IntProperty: Hero_CompleteControl_TimesEarnedAsBane
    /// </summary>
    public unsafe int Hero_CompleteControl_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// IntProperty: Hero_CompleteControl_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Hero_CompleteControl_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// IntProperty: Hero_StatusQuo_TimesAwarded
    /// </summary>
    public unsafe int Hero_StatusQuo_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// IntProperty: Hero_StatusQuo_XPEarned
    /// </summary>
    public unsafe int Hero_StatusQuo_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// IntProperty: Hero_StatusQuo_TimesEarnedAsHero
    /// </summary>
    public unsafe int Hero_StatusQuo_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// IntProperty: Hero_StatusQuo_TimesEarnedAsBane
    /// </summary>
    public unsafe int Hero_StatusQuo_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// IntProperty: Hero_StatusQuo_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Hero_StatusQuo_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// IntProperty: Hero_TechnicalKnockout_TimesAwarded
    /// </summary>
    public unsafe int Hero_TechnicalKnockout_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// IntProperty: Hero_TechnicalKnockout_XPEarned
    /// </summary>
    public unsafe int Hero_TechnicalKnockout_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// IntProperty: Hero_TechnicalKnockout_TimesEarnedAsHero
    /// </summary>
    public unsafe int Hero_TechnicalKnockout_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// IntProperty: Hero_TechnicalKnockout_TimesEarnedAsBane
    /// </summary>
    public unsafe int Hero_TechnicalKnockout_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// IntProperty: Hero_TechnicalKnockout_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Hero_TechnicalKnockout_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// IntProperty: AwardLevelOne_TimesAwarded
    /// </summary>
    public unsafe int AwardLevelOne_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// IntProperty: AwardLevelOne_XPEarned
    /// </summary>
    public unsafe int AwardLevelOne_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// IntProperty: AwardLevelOne_TimesEarnedAsHero
    /// </summary>
    public unsafe int AwardLevelOne_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// IntProperty: AwardLevelOne_TimesEarnedAsBane
    /// </summary>
    public unsafe int AwardLevelOne_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// IntProperty: AwardLevelOne_TimesEarnedAsJoker
    /// </summary>
    public unsafe int AwardLevelOne_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// IntProperty: AwardLevelTwo_TimesAwarded
    /// </summary>
    public unsafe int AwardLevelTwo_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// IntProperty: AwardLevelTwo_XPEarned
    /// </summary>
    public unsafe int AwardLevelTwo_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// IntProperty: AwardLevelTwo_TimesEarnedAsHero
    /// </summary>
    public unsafe int AwardLevelTwo_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// IntProperty: AwardLevelTwo_TimesEarnedAsBane
    /// </summary>
    public unsafe int AwardLevelTwo_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// IntProperty: AwardLevelTwo_TimesEarnedAsJoker
    /// </summary>
    public unsafe int AwardLevelTwo_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// IntProperty: AwardLevelThree_TimesAwarded
    /// </summary>
    public unsafe int AwardLevelThree_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// IntProperty: AwardLevelThree_XPEarned
    /// </summary>
    public unsafe int AwardLevelThree_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// IntProperty: AwardLevelThree_TimesEarnedAsHero
    /// </summary>
    public unsafe int AwardLevelThree_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// IntProperty: AwardLevelThree_TimesEarnedAsBane
    /// </summary>
    public unsafe int AwardLevelThree_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// IntProperty: AwardLevelThree_TimesEarnedAsJoker
    /// </summary>
    public unsafe int AwardLevelThree_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// IntProperty: Thug_Comeback_TimesAwarded
    /// </summary>
    public unsafe int Thug_Comeback_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// IntProperty: Thug_Comeback_XPEarned
    /// </summary>
    public unsafe int Thug_Comeback_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// IntProperty: Thug_Comeback_TimesEarnedAsHero
    /// </summary>
    public unsafe int Thug_Comeback_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// IntProperty: Thug_Comeback_TimesEarnedAsBane
    /// </summary>
    public unsafe int Thug_Comeback_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// IntProperty: Thug_Comeback_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Thug_Comeback_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// IntProperty: Gangland_Won_TimesAwarded
    /// </summary>
    public unsafe int Gangland_Won_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// IntProperty: Gangland_Won_XPEarned
    /// </summary>
    public unsafe int Gangland_Won_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// IntProperty: Gangland_Won_TimesEarnedAsHero
    /// </summary>
    public unsafe int Gangland_Won_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// IntProperty: Gangland_Won_TimesEarnedAsBane
    /// </summary>
    public unsafe int Gangland_Won_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// IntProperty: Gangland_Won_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Gangland_Won_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// IntProperty: Gangland_Lost_TimesAwarded
    /// </summary>
    public unsafe int Gangland_Lost_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// IntProperty: Gangland_Lost_XPEarned
    /// </summary>
    public unsafe int Gangland_Lost_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// IntProperty: Gangland_Lost_TimesEarnedAsHero
    /// </summary>
    public unsafe int Gangland_Lost_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// IntProperty: Gangland_Lost_TimesEarnedAsBane
    /// </summary>
    public unsafe int Gangland_Lost_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// IntProperty: Gangland_Lost_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Gangland_Lost_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// IntProperty: HunterHunted_Won_TimesAwarded
    /// </summary>
    public unsafe int HunterHunted_Won_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// IntProperty: HunterHunted_Won_XPEarned
    /// </summary>
    public unsafe int HunterHunted_Won_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// IntProperty: HunterHunted_Won_TimesEarnedAsHero
    /// </summary>
    public unsafe int HunterHunted_Won_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// IntProperty: HunterHunted_Won_TimesEarnedAsBane
    /// </summary>
    public unsafe int HunterHunted_Won_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// IntProperty: HunterHunted_Won_TimesEarnedAsJoker
    /// </summary>
    public unsafe int HunterHunted_Won_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// IntProperty: HunterHunted_Lost_TimesAwarded
    /// </summary>
    public unsafe int HunterHunted_Lost_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// IntProperty: HunterHunted_Lost_XPEarned
    /// </summary>
    public unsafe int HunterHunted_Lost_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// IntProperty: HunterHunted_Lost_TimesEarnedAsHero
    /// </summary>
    public unsafe int HunterHunted_Lost_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// IntProperty: HunterHunted_Lost_TimesEarnedAsBane
    /// </summary>
    public unsafe int HunterHunted_Lost_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// IntProperty: HunterHunted_Lost_TimesEarnedAsJoker
    /// </summary>
    public unsafe int HunterHunted_Lost_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// IntProperty: HunterHunted_FinaleKill_TimesAwarded
    /// </summary>
    public unsafe int HunterHunted_FinaleKill_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// IntProperty: HunterHunted_FinaleKill_XPEarned
    /// </summary>
    public unsafe int HunterHunted_FinaleKill_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// IntProperty: HunterHunted_FinaleKill_TimesEarnedAsHero
    /// </summary>
    public unsafe int HunterHunted_FinaleKill_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// IntProperty: HunterHunted_FinaleKill_TimesEarnedAsBane
    /// </summary>
    public unsafe int HunterHunted_FinaleKill_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// IntProperty: HunterHunted_FinaleKill_TimesEarnedAsJoker
    /// </summary>
    public unsafe int HunterHunted_FinaleKill_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// IntProperty: HunterHunted_Survived_TimesAwarded
    /// </summary>
    public unsafe int HunterHunted_Survived_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// IntProperty: HunterHunted_Survived_XPEarned
    /// </summary>
    public unsafe int HunterHunted_Survived_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// IntProperty: HunterHunted_Survived_TimesEarnedAsHero
    /// </summary>
    public unsafe int HunterHunted_Survived_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// IntProperty: HunterHunted_Survived_TimesEarnedAsBane
    /// </summary>
    public unsafe int HunterHunted_Survived_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// IntProperty: HunterHunted_Survived_TimesEarnedAsJoker
    /// </summary>
    public unsafe int HunterHunted_Survived_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// IntProperty: Thug_FirstBlood_TimesAwarded
    /// </summary>
    public unsafe int Thug_FirstBlood_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// IntProperty: Thug_FirstBlood_XPEarned
    /// </summary>
    public unsafe int Thug_FirstBlood_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// IntProperty: Thug_FirstBlood_TimesEarnedAsHero
    /// </summary>
    public unsafe int Thug_FirstBlood_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// IntProperty: Thug_FirstBlood_TimesEarnedAsBane
    /// </summary>
    public unsafe int Thug_FirstBlood_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// IntProperty: Thug_FirstBlood_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Thug_FirstBlood_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// IntProperty: Thug_DestroyScrambler_TimesAwarded
    /// </summary>
    public unsafe int Thug_DestroyScrambler_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// IntProperty: Thug_DestroyScrambler_XPEarned
    /// </summary>
    public unsafe int Thug_DestroyScrambler_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// IntProperty: Thug_DestroyScrambler_TimesEarnedAsHero
    /// </summary>
    public unsafe int Thug_DestroyScrambler_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// IntProperty: Thug_DestroyScrambler_TimesEarnedAsBane
    /// </summary>
    public unsafe int Thug_DestroyScrambler_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// IntProperty: Thug_DestroyScrambler_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Thug_DestroyScrambler_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// IntProperty: Thug_MidGlideHeroKill_TimesAwarded
    /// </summary>
    public unsafe int Thug_MidGlideHeroKill_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// IntProperty: Thug_MidGlideHeroKill_XPEarned
    /// </summary>
    public unsafe int Thug_MidGlideHeroKill_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// IntProperty: Thug_MidGlideHeroKill_TimesEarnedAsHero
    /// </summary>
    public unsafe int Thug_MidGlideHeroKill_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// IntProperty: Thug_MidGlideHeroKill_TimesEarnedAsBane
    /// </summary>
    public unsafe int Thug_MidGlideHeroKill_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// IntProperty: Thug_MidGlideHeroKill_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Thug_MidGlideHeroKill_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// IntProperty: Thug_TacDartHeroTag_TimesAwarded
    /// </summary>
    public unsafe int Thug_TacDartHeroTag_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// IntProperty: Thug_TacDartHeroTag_XPEarned
    /// </summary>
    public unsafe int Thug_TacDartHeroTag_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// IntProperty: Thug_TacDartHeroTag_TimesEarnedAsHero
    /// </summary>
    public unsafe int Thug_TacDartHeroTag_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// IntProperty: Thug_TacDartHeroTag_TimesEarnedAsBane
    /// </summary>
    public unsafe int Thug_TacDartHeroTag_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// IntProperty: Thug_TacDartHeroTag_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Thug_TacDartHeroTag_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// IntProperty: Thug_TacDartThugTag_TimesAwarded
    /// </summary>
    public unsafe int Thug_TacDartThugTag_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// IntProperty: Thug_TacDartThugTag_XPEarned
    /// </summary>
    public unsafe int Thug_TacDartThugTag_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// IntProperty: Thug_TacDartThugTag_TimesEarnedAsHero
    /// </summary>
    public unsafe int Thug_TacDartThugTag_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// IntProperty: Thug_TacDartThugTag_TimesEarnedAsBane
    /// </summary>
    public unsafe int Thug_TacDartThugTag_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// IntProperty: Thug_TacDartThugTag_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Thug_TacDartThugTag_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// IntProperty: Thug_TacDartGangleaderTag_TimesAwarded
    /// </summary>
    public unsafe int Thug_TacDartGangleaderTag_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// IntProperty: Thug_TacDartGangleaderTag_XPEarned
    /// </summary>
    public unsafe int Thug_TacDartGangleaderTag_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }

    /// <summary>
    /// IntProperty: Thug_TacDartGangleaderTag_TimesEarnedAsHero
    /// </summary>
    public unsafe int Thug_TacDartGangleaderTag_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// IntProperty: Thug_TacDartGangleaderTag_TimesEarnedAsBane
    /// </summary>
    public unsafe int Thug_TacDartGangleaderTag_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// IntProperty: Thug_TacDartGangleaderTag_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Thug_TacDartGangleaderTag_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// IntProperty: Thug_SupervillainAssist_TimesAwarded
    /// </summary>
    public unsafe int Thug_SupervillainAssist_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// IntProperty: Thug_SupervillainAssist_XPEarned
    /// </summary>
    public unsafe int Thug_SupervillainAssist_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// IntProperty: Thug_SupervillainAssist_TimesEarnedAsHero
    /// </summary>
    public unsafe int Thug_SupervillainAssist_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// IntProperty: Thug_SupervillainAssist_TimesEarnedAsBane
    /// </summary>
    public unsafe int Thug_SupervillainAssist_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// IntProperty: Thug_SupervillainAssist_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Thug_SupervillainAssist_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }

    /// <summary>
    /// IntProperty: Hero_SupervillainAssist_TimesAwarded
    /// </summary>
    public unsafe int Hero_SupervillainAssist_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// IntProperty: Hero_SupervillainAssist_XPEarned
    /// </summary>
    public unsafe int Hero_SupervillainAssist_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// IntProperty: Hero_SupervillainAssist_TimesEarnedAsHero
    /// </summary>
    public unsafe int Hero_SupervillainAssist_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// IntProperty: Hero_SupervillainAssist_TimesEarnedAsBane
    /// </summary>
    public unsafe int Hero_SupervillainAssist_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1220); }
    }

    /// <summary>
    /// IntProperty: Hero_SupervillainAssist_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Hero_SupervillainAssist_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// IntProperty: Gangleader_JokerPrimaryKill_TimesAwarded
    /// </summary>
    public unsafe int Gangleader_JokerPrimaryKill_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }

    /// <summary>
    /// IntProperty: Gangleader_JokerPrimaryKill_XPEarned
    /// </summary>
    public unsafe int Gangleader_JokerPrimaryKill_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// IntProperty: Gangleader_JokerPrimaryKill_TimesEarnedAsHero
    /// </summary>
    public unsafe int Gangleader_JokerPrimaryKill_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }

    /// <summary>
    /// IntProperty: Gangleader_JokerPrimaryKill_TimesEarnedAsBane
    /// </summary>
    public unsafe int Gangleader_JokerPrimaryKill_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// IntProperty: Gangleader_JokerPrimaryKill_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Gangleader_JokerPrimaryKill_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }

    /// <summary>
    /// IntProperty: Gangleader_JokerSecondaryKill_TimesAwarded
    /// </summary>
    public unsafe int Gangleader_JokerSecondaryKill_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// IntProperty: Gangleader_JokerSecondaryKill_XPEarned
    /// </summary>
    public unsafe int Gangleader_JokerSecondaryKill_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// IntProperty: Gangleader_JokerSecondaryKill_TimesEarnedAsHero
    /// </summary>
    public unsafe int Gangleader_JokerSecondaryKill_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// IntProperty: Gangleader_JokerSecondaryKill_TimesEarnedAsBane
    /// </summary>
    public unsafe int Gangleader_JokerSecondaryKill_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }

    /// <summary>
    /// IntProperty: Gangleader_JokerSecondaryKill_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Gangleader_JokerSecondaryKill_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// IntProperty: Gangleader_JokerThugExecution_TimesAwarded
    /// </summary>
    public unsafe int Gangleader_JokerThugExecution_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// IntProperty: Gangleader_JokerThugExecution_XPEarned
    /// </summary>
    public unsafe int Gangleader_JokerThugExecution_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }

    /// <summary>
    /// IntProperty: Gangleader_JokerThugExecution_TimesEarnedAsHero
    /// </summary>
    public unsafe int Gangleader_JokerThugExecution_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1276); }
    }

    /// <summary>
    /// IntProperty: Gangleader_JokerThugExecution_TimesEarnedAsBane
    /// </summary>
    public unsafe int Gangleader_JokerThugExecution_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// IntProperty: Gangleader_JokerThugExecution_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Gangleader_JokerThugExecution_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// IntProperty: Gangleader_JokerHeroExecution_TimesAwarded
    /// </summary>
    public unsafe int Gangleader_JokerHeroExecution_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// IntProperty: Gangleader_JokerHeroExecution_XPEarned
    /// </summary>
    public unsafe int Gangleader_JokerHeroExecution_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }

    /// <summary>
    /// IntProperty: Gangleader_JokerHeroExecution_TimesEarnedAsHero
    /// </summary>
    public unsafe int Gangleader_JokerHeroExecution_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// IntProperty: Gangleader_JokerHeroExecution_TimesEarnedAsBane
    /// </summary>
    public unsafe int Gangleader_JokerHeroExecution_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// IntProperty: Gangleader_JokerHeroExecution_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Gangleader_JokerHeroExecution_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneGroundPunch_TimesAwarded
    /// </summary>
    public unsafe int Gangleader_BaneGroundPunch_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneGroundPunch_XPEarned
    /// </summary>
    public unsafe int Gangleader_BaneGroundPunch_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneGroundPunch_TimesEarnedAsHero
    /// </summary>
    public unsafe int Gangleader_BaneGroundPunch_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneGroundPunch_TimesEarnedAsBane
    /// </summary>
    public unsafe int Gangleader_BaneGroundPunch_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneGroundPunch_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Gangleader_BaneGroundPunch_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneRocketLauncher_TimesAwarded
    /// </summary>
    public unsafe int Gangleader_BaneRocketLauncher_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneRocketLauncher_XPEarned
    /// </summary>
    public unsafe int Gangleader_BaneRocketLauncher_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneRocketLauncher_TimesEarnedAsHero
    /// </summary>
    public unsafe int Gangleader_BaneRocketLauncher_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneRocketLauncher_TimesEarnedAsBane
    /// </summary>
    public unsafe int Gangleader_BaneRocketLauncher_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneRocketLauncher_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Gangleader_BaneRocketLauncher_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneThugExecutionFloor_TimesAwarded
    /// </summary>
    public unsafe int Gangleader_BaneThugExecutionFloor_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneThugExecutionFloor_XPEarned
    /// </summary>
    public unsafe int Gangleader_BaneThugExecutionFloor_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneThugExecutionFloor_TimesEarnedAsHero
    /// </summary>
    public unsafe int Gangleader_BaneThugExecutionFloor_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneThugExecutionFloor_TimesEarnedAsBane
    /// </summary>
    public unsafe int Gangleader_BaneThugExecutionFloor_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneThugExecutionFloor_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Gangleader_BaneThugExecutionFloor_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneThugExecutionWall_TimesAwarded
    /// </summary>
    public unsafe int Gangleader_BaneThugExecutionWall_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1368); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneThugExecutionWall_XPEarned
    /// </summary>
    public unsafe int Gangleader_BaneThugExecutionWall_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneThugExecutionWall_TimesEarnedAsHero
    /// </summary>
    public unsafe int Gangleader_BaneThugExecutionWall_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneThugExecutionWall_TimesEarnedAsBane
    /// </summary>
    public unsafe int Gangleader_BaneThugExecutionWall_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneThugExecutionWall_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Gangleader_BaneThugExecutionWall_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneThugExecutionThrow_TimesAwarded
    /// </summary>
    public unsafe int Gangleader_BaneThugExecutionThrow_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1388); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneThugExecutionThrow_XPEarned
    /// </summary>
    public unsafe int Gangleader_BaneThugExecutionThrow_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1392); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneThugExecutionThrow_TimesEarnedAsHero
    /// </summary>
    public unsafe int Gangleader_BaneThugExecutionThrow_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1396); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneThugExecutionThrow_TimesEarnedAsBane
    /// </summary>
    public unsafe int Gangleader_BaneThugExecutionThrow_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneThugExecutionThrow_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Gangleader_BaneThugExecutionThrow_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1404); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneHeroExecution_TimesAwarded
    /// </summary>
    public unsafe int Gangleader_BaneHeroExecution_TimesAwarded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneHeroExecution_XPEarned
    /// </summary>
    public unsafe int Gangleader_BaneHeroExecution_XPEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneHeroExecution_TimesEarnedAsHero
    /// </summary>
    public unsafe int Gangleader_BaneHeroExecution_TimesEarnedAsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneHeroExecution_TimesEarnedAsBane
    /// </summary>
    public unsafe int Gangleader_BaneHeroExecution_TimesEarnedAsBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// IntProperty: Gangleader_BaneHeroExecution_TimesEarnedAsJoker
    /// </summary>
    public unsafe int Gangleader_BaneHeroExecution_TimesEarnedAsJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }
}
