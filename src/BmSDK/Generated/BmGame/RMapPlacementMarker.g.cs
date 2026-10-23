#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RMapPlacementMarker<br/>
/// (size = 476)
/// (flags = 142606994)
/// </summary>
public partial class RMapPlacementMarker : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RMapPlacementMarker", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RMapPlacementMarker.
    /// </summary>
    public static RMapPlacementMarker DefaultObject => (RMapPlacementMarker)StaticClass().DefaultObject;

    internal RMapPlacementMarker() { }

    /// <summary>
    /// Constructs a new RMapPlacementMarker
    /// </summary>
    public RMapPlacementMarker(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RMapPlacementMarker(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMapPlacementMarker>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMapPlacementMarker>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMapPlacementMarker>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMapPlacementMarker>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMapPlacementMarker>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMapPlacementMarker>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMapPlacementMarker>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMapPlacementMarker>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// ByteProperty: MarkerType
    /// </summary>
    public unsafe BmSDK.BmGame.RMapPlacementMarker.MapMarkerType MarkerType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMapPlacementMarker.MapMarkerType>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// ByteProperty: Zone
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.ERiddlerLocationName Zone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.ERiddlerLocationName>(Ptr + 453); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 453); }
    }

    /// <summary>
    /// IntProperty: Index
    /// </summary>
    public unsafe int Index
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// StrProperty: StringName
    /// </summary>
    public unsafe BmSDK.FString StringName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// BoolProperty: UI_Shown
    /// </summary>
    public unsafe bool UI_Shown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 472) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 472); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 472); }
    }

    /// <summary>
    /// Enum: MapMarkerType
    /// </summary>
    public enum MapMarkerType : byte
    {
        MMT_Objective = 0,
        MMT_CrimeScene = 1,
        MMT_EnigmaTrophy = 2,
        MMT_EnigmaBreakable = 3,
        MMT_SMAnarky = 4,
        MMT_SMPenguin = 5,
        MMT_SMDeadshot = 6,
        MMT_SMMadHatter = 7,
        MMT_SMBird = 8,
        MMT_SMBlackgatePrisoners = 9,
        MMT_SMShivaIcon = 10,
        MMT_SMShivaTrajectory = 11,
        MMT_SMBlackMask = 12,
        MMT_SMGenericRadius = 13,
        MMT_DEInformant = 14,
        MMT_DESpecial = 15,
        MMT_DEEpic = 16,
        MMT_EnigmaTower = 17,
        MMT_PointOfInterest = 18,
        MMT_ChallengeMode = 19,
        MMT_ARChallenge = 20,
        MMT_EnigmaHQ = 21,
        MMT_MAX = 22,
    }
}
