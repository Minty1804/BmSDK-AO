#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MBMBehaviour_HitReactionBane_OZ<br/>
/// (size = 824)
/// (flags = 8396822)
/// </summary>
public partial class MBMBehaviour_HitReactionBane_OZ : BmSDK.BmGame.RBMBehaviour_HitReaction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MBMBehaviour_HitReactionBane_OZ", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MBMBehaviour_HitReactionBane_OZ.
    /// </summary>
    public static MBMBehaviour_HitReactionBane_OZ DefaultObject => (MBMBehaviour_HitReactionBane_OZ)StaticClass().DefaultObject;

    internal MBMBehaviour_HitReactionBane_OZ() { }

    /// <summary>
    /// Constructs a new MBMBehaviour_HitReactionBane_OZ
    /// </summary>
    public MBMBehaviour_HitReactionBane_OZ(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MBMBehaviour_HitReactionBane_OZ Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MBMBehaviour_HitReactionBane_OZ(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_HitReactionBane_OZ>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_HitReactionBane_OZ>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_HitReactionBane_OZ>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_HitReactionBane_OZ>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_HitReactionBane_OZ>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_HitReactionBane_OZ>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_HitReactionBane_OZ>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_HitReactionBane_OZ>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: OnDeactivate
    /// </summary>
    public unsafe override void OnDeactivate()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_HitReactionBane_OZ.OnDeactivate", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe override void Initialise(BmSDK.BmGame.RPawnCombat.FDamageInfo NewDmgInfo, bool bNewInterruptedHitReaction = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_HitReactionBane_OZ.Initialise", true);
        byte* paramsPtr = stackalloc byte[260];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewInterruptedHitReaction, paramsPtr + 256);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: HitAnimDirection
    /// </summary>
    public enum HitAnimDirection : byte
    {
        HitDirection_Front = 0,
        HitDirection_Left = 1,
        HitDirection_Right = 2,
        HitDirection_Back = 3,
        HitDirection_MAX = 4,
    }

    /// <summary>
    /// ObjectProperty: BanePawn
    /// </summary>
    public unsafe BmSDK.BmGame.MPawnBossBane_OZBase BanePawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MPawnBossBane_OZBase>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// IntProperty: DifficultyLevel
    /// </summary>
    public unsafe int DifficultyLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: BeatdownStunDuration
    /// </summary>
    public InlineArray<float> BeatdownStunDuration => new(3, Ptr + 752, 4, this);

    /// <summary>
    /// FloatProperty: BeatdownStunDuration
    /// </summary>
    public unsafe float BeatdownStunDuration_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }
    /// <summary>
    /// FloatProperty: BeatdownStunDuration
    /// </summary>
    public unsafe float BeatdownStunDuration_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }
    /// <summary>
    /// FloatProperty: BeatdownStunDuration
    /// </summary>
    public unsafe float BeatdownStunDuration_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: BeatdownStunDurationBlackGate
    /// </summary>
    public InlineArray<float> BeatdownStunDurationBlackGate => new(3, Ptr + 764, 4, this);

    /// <summary>
    /// FloatProperty: BeatdownStunDurationBlackGate
    /// </summary>
    public unsafe float BeatdownStunDurationBlackGate_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }
    /// <summary>
    /// FloatProperty: BeatdownStunDurationBlackGate
    /// </summary>
    public unsafe float BeatdownStunDurationBlackGate_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }
    /// <summary>
    /// FloatProperty: BeatdownStunDurationBlackGate
    /// </summary>
    public unsafe float BeatdownStunDurationBlackGate_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: TripleStunDuration
    /// </summary>
    public InlineArray<float> TripleStunDuration => new(3, Ptr + 776, 4, this);

    /// <summary>
    /// FloatProperty: TripleStunDuration
    /// </summary>
    public unsafe float TripleStunDuration_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }
    /// <summary>
    /// FloatProperty: TripleStunDuration
    /// </summary>
    public unsafe float TripleStunDuration_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }
    /// <summary>
    /// FloatProperty: TripleStunDuration
    /// </summary>
    public unsafe float TripleStunDuration_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: TripleStunDurationBlackGate
    /// </summary>
    public InlineArray<float> TripleStunDurationBlackGate => new(3, Ptr + 788, 4, this);

    /// <summary>
    /// FloatProperty: TripleStunDurationBlackGate
    /// </summary>
    public unsafe float TripleStunDurationBlackGate_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }
    /// <summary>
    /// FloatProperty: TripleStunDurationBlackGate
    /// </summary>
    public unsafe float TripleStunDurationBlackGate_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }
    /// <summary>
    /// FloatProperty: TripleStunDurationBlackGate
    /// </summary>
    public unsafe float TripleStunDurationBlackGate_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: SmokePelletStunDuration
    /// </summary>
    public InlineArray<float> SmokePelletStunDuration => new(3, Ptr + 800, 4, this);

    /// <summary>
    /// FloatProperty: SmokePelletStunDuration
    /// </summary>
    public unsafe float SmokePelletStunDuration_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }
    /// <summary>
    /// FloatProperty: SmokePelletStunDuration
    /// </summary>
    public unsafe float SmokePelletStunDuration_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }
    /// <summary>
    /// FloatProperty: SmokePelletStunDuration
    /// </summary>
    public unsafe float SmokePelletStunDuration_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: SmokePelletStunDurationBlackGate
    /// </summary>
    public InlineArray<float> SmokePelletStunDurationBlackGate => new(3, Ptr + 812, 4, this);

    /// <summary>
    /// FloatProperty: SmokePelletStunDurationBlackGate
    /// </summary>
    public unsafe float SmokePelletStunDurationBlackGate_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }
    /// <summary>
    /// FloatProperty: SmokePelletStunDurationBlackGate
    /// </summary>
    public unsafe float SmokePelletStunDurationBlackGate_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }
    /// <summary>
    /// FloatProperty: SmokePelletStunDurationBlackGate
    /// </summary>
    public unsafe float SmokePelletStunDurationBlackGate_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }
}
