#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_Emote<br/>
/// (size = 92)
/// (flags = 134230162)
/// </summary>
public partial class RAnimNotify_Emote : BmSDK.BmGame.RAnimNotify_Script, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_Emote", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAnimNotify_Emote.
    /// </summary>
    public static RAnimNotify_Emote DefaultObject => (RAnimNotify_Emote)StaticClass().DefaultObject;

    internal RAnimNotify_Emote() { }

    /// <summary>
    /// Constructs a new RAnimNotify_Emote
    /// </summary>
    public RAnimNotify_Emote(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_Emote Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_Emote(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAnimNotify_Emote>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimNotify_Emote>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAnimNotify_Emote>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimNotify_Emote>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimNotify_Emote>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimNotify_Emote>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAnimNotify_Emote>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimNotify_Emote>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// ByteProperty: EmoteType
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNotify_Emote.EEmoteType EmoteType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNotify_Emote.EEmoteType>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// StrProperty: EmotePackage
    /// </summary>
    public unsafe BmSDK.FString EmotePackage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }

    /// <summary>
    /// IntProperty: EmoteProbability
    /// </summary>
    public unsafe int EmoteProbability
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// BoolProperty: CanPlayDuringMatinee
    /// </summary>
    public unsafe bool CanPlayDuringMatinee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 88); }
    }

    /// <summary>
    /// Enum: EEmoteType
    /// </summary>
    public enum EEmoteType : byte
    {
        Emote_AttackLight = 0,
        Emote_AttackMed = 1,
        Emote_AttackStrong = 2,
        Emote_AttackEpic = 3,
        Emote_Chocke = 4,
        Emote_Climb = 5,
        Emote_Collapse = 6,
        Emote_Cough = 7,
        Emote_Dazed = 8,
        Emote_Dodge = 9,
        Emote_ExertLight = 10,
        Emote_ExertMed = 11,
        Emote_ExertPickup = 12,
        Emote_ExertStrong = 13,
        Emote_Fall = 14,
        Emote_Giggle = 15,
        Emote_Growl = 16,
        Emote_HurtCollapse = 17,
        Emote_HurtFunny = 18,
        Emote_HurtHard = 19,
        Emote_HurtLight = 20,
        Emote_HurtMed = 21,
        Emote_HurtPassout = 22,
        Emote_HurtStrong = 23,
        Emote_Kicked = 24,
        Emote_Punched = 25,
        Emote_Laugh = 26,
        Emote_Jump = 27,
        Emote_JumpLong = 28,
        Emote_Muffled = 29,
        Emote_RoarAngry = 30,
        Emote_RoarThrown = 31,
        Emote_Pull = 32,
        Emote_Thrown = 33,
        Emote_BiteThrow1 = 34,
        Emote_BiteThrow2 = 35,
        Emote_BitingGrowl = 36,
        Emote_StopMuffle = 37,
        Emote_StopAll = 38,
        Emote_MAX = 39,
    }
}
