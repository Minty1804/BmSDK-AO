#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDExperienceValues<br/>
/// (size = 656)
/// (flags = 32786)
/// </summary>
public partial class GDExperienceValues : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDExperienceValues", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDExperienceValues.
    /// </summary>
    public static GDExperienceValues DefaultObject => (GDExperienceValues)StaticClass().DefaultObject;

    internal GDExperienceValues() { }

    /// <summary>
    /// Constructs a new GDExperienceValues
    /// </summary>
    public GDExperienceValues(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDExperienceValues Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDExperienceValues(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDExperienceValues>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDExperienceValues>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDExperienceValues>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDExperienceValues>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDExperienceValues>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDExperienceValues>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDExperienceValues>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDExperienceValues>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ShouldForceCenterScreenXP;
    /// <summary>
    /// Function: ShouldForceCenterScreenXP
    /// </summary>
    public unsafe virtual bool ShouldForceCenterScreenXP(BmSDK.BmGame.RGameInfo.NewExperienceAmounts _XP)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldForceCenterScreenXP, "BmGame.GDExperienceValues.ShouldForceCenterScreenXP");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_XP, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetXP;
    /// <summary>
    /// Function: GetXP
    /// </summary>
    public unsafe virtual int GetXP(BmSDK.BmGame.RGameInfo.NewExperienceAmounts _for)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetXP, "BmGame.GDExperienceValues.GetXP");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_for, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    /// <summary>
    /// InlineArray{IntProperty}: ExperienceRewards
    /// </summary>
    public InlineArray<int> ExperienceRewards => new(76, Ptr + 48, 4, this);

    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_41
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_42
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_43
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_44
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_45
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_46
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_47
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_48
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_49
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_50
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_51
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_52
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_53
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_54
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_55
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_56
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_57
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_58
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_59
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_60
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_61
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_62
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_63
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_64
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_65
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_66
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_67
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_68
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_69
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_70
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_71
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_72
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_73
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_74
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }
    /// <summary>
    /// IntProperty: ExperienceRewards
    /// </summary>
    public unsafe int ExperienceRewards_75
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: ExtraXPEventInfos
    /// </summary>
    public InlineArray<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo> ExtraXPEventInfos => new(76, Ptr + 352, 4, this);

    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 352);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 356);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 360);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 364);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 368);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 372);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 376);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 380);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 384);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_9
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 388);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_10
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 392);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_11
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 396);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_12
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 400);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_13
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 404);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_14
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 408);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_15
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 412);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_16
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 416);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_17
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 420);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_18
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 424);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_19
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 428);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_20
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 432);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_21
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 436);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_22
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 440);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_23
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 444);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_24
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 448);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_25
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 452);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_26
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 456);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_27
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 460);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_28
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 464);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_29
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 468);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_30
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 472);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_31
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 476);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_32
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 480);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_33
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 484);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_34
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 488);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_35
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 492);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_36
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 496);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_37
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 500);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_38
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 504);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_39
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 508);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_40
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 512);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_41
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 516);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_42
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 520);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_43
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 524);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_44
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 528);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_45
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 532);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_46
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 536);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_47
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 540);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_48
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 544);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_49
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 548);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_50
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 552);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_51
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 556);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_52
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 560);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_53
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 564);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_54
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 568);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_55
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 572);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_56
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 576);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_57
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 580);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_58
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 584);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_59
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 588);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_60
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 592);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_61
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 596);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_62
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 600);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_63
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 604);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_64
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 608);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_65
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 612);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_66
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 616);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_67
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 620);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_68
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 624);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_69
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 628);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_70
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 632);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_71
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 636);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_72
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 640);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_73
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 644);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_74
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 648);
    /// <summary>
    /// StructProperty: ExtraXPEventInfos
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo ExtraXPEventInfos_75
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDExperienceValues.FExtraXPEventInfo>(Ptr + 652);

    /// <summary>
    /// Struct: FExtraXPEventInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial record struct FExtraXPEventInfo
    {
        /// <summary>
        /// BoolProperty: ForceCenterScreenXP
        /// </summary>
        public unsafe bool ForceCenterScreenXP
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }
    }
}
