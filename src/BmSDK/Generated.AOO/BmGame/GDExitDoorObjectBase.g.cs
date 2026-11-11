#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDExitDoorObjectBase<br/>
/// (size = 784)
/// (flags = 142639762)
/// </summary>
public partial class GDExitDoorObjectBase : BmSDK.BmGame.RInteractableItem, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDExitDoorObjectBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDExitDoorObjectBase.
    /// </summary>
    public static GDExitDoorObjectBase DefaultObject => (GDExitDoorObjectBase)StaticClass().DefaultObject;

    internal GDExitDoorObjectBase() { }

    /// <summary>
    /// Constructs a new GDExitDoorObjectBase
    /// </summary>
    public GDExitDoorObjectBase(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDExitDoorObjectBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDExitDoorObjectBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDExitDoorObjectBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDExitDoorObjectBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDExitDoorObjectBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDExitDoorObjectBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDExitDoorObjectBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDExitDoorObjectBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDExitDoorObjectBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_OverridesRun;
    /// <summary>
    /// Function: OverridesRun
    /// </summary>
    public unsafe override float OverridesRun(BmSDK.BmGame.RPlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverridesRun, "BmGame.GDExitDoorObjectBase.OverridesRun");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_MulticastOpenForFinale;
    /// <summary>
    /// Function: MulticastOpenForFinale
    /// </summary>
    public unsafe virtual void MulticastOpenForFinale()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MulticastOpenForFinale, "BmGame.GDExitDoorObjectBase.MulticastOpenForFinale");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OpenForFinaleServer;
    /// <summary>
    /// Function: OpenForFinaleServer
    /// </summary>
    public unsafe virtual void OpenForFinaleServer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenForFinaleServer, "BmGame.GDExitDoorObjectBase.OpenForFinaleServer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OpenDoor;
    /// <summary>
    /// Function: OpenDoor
    /// </summary>
    public unsafe void OpenDoor(BmSDK.FName AnimName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenDoor, "BmGame.GDExitDoorObjectBase.OpenDoor");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OpenForFinale;
    /// <summary>
    /// Function: OpenForFinale
    /// </summary>
    public unsafe virtual void OpenForFinale()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenForFinale, "BmGame.GDExitDoorObjectBase.OpenForFinale");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayOpenAnimation;
    /// <summary>
    /// Function: PlayOpenAnimation
    /// </summary>
    public unsafe virtual void PlayOpenAnimation(BmSDK.BmGame.GDGIBase.ETeamType OpenForTeam)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayOpenAnimation, "BmGame.GDExitDoorObjectBase.PlayOpenAnimation");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OpenForTeam, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPreShowIconForTeam;
    /// <summary>
    /// Function: SetPreShowIconForTeam
    /// </summary>
    public unsafe virtual void SetPreShowIconForTeam(BmSDK.BmGame.GDGIBase.ETeamType ForTeam, bool bShow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPreShowIconForTeam, "BmGame.GDExitDoorObjectBase.SetPreShowIconForTeam");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForTeam, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSupervillainSpawnActive;
    /// <summary>
    /// Function: SetSupervillainSpawnActive
    /// </summary>
    public unsafe virtual void SetSupervillainSpawnActive(bool bActive)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSupervillainSpawnActive, "BmGame.GDExitDoorObjectBase.SetSupervillainSpawnActive");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActive, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ComponentProperty: DoorMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent DoorMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// ComponentProperty: LightEnvironment
    /// </summary>
    public unsafe BmSDK.Engine.LightEnvironmentComponent LightEnvironment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LightEnvironmentComponent>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// ObjectProperty: SupervillainStart
    /// </summary>
    public unsafe BmSDK.Engine.PlayerStart SupervillainStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerStart>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// NameProperty: JokerOpenAnimName
    /// </summary>
    public unsafe BmSDK.FName JokerOpenAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// NameProperty: BaneOpenAnimName
    /// </summary>
    public unsafe BmSDK.FName BaneOpenAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// NameProperty: FinaleOpenAnimName
    /// </summary>
    public unsafe BmSDK.FName FinaleOpenAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// ComponentProperty: FinaleInfluenceHelper
    /// </summary>
    public unsafe BmSDK.BmGame.GDObjectiveInfluenceHelper FinaleInfluenceHelper
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDObjectiveInfluenceHelper>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// ObjectProperty: FinaleBlockingVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RBlockingVolume FinaleBlockingVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBlockingVolume>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// StructProperty: MarkerLocationOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MarkerLocationOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 652);

    /// <summary>
    /// BoolProperty: bSupervillainSpawnActive
    /// </summary>
    public unsafe bool bSupervillainSpawnActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bOpenForFinale
    /// </summary>
    public unsafe bool bOpenForFinale
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// InlineArray{ByteProperty}: ShowIconForTeam
    /// </summary>
    public InlineArray<byte> ShowIconForTeam => new(5, Ptr + 668, 1, this);

    /// <summary>
    /// ByteProperty: ShowIconForTeam
    /// </summary>
    public unsafe byte ShowIconForTeam_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }
    /// <summary>
    /// ByteProperty: ShowIconForTeam
    /// </summary>
    public unsafe byte ShowIconForTeam_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 669); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 669); }
    }
    /// <summary>
    /// ByteProperty: ShowIconForTeam
    /// </summary>
    public unsafe byte ShowIconForTeam_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 670); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 670); }
    }
    /// <summary>
    /// ByteProperty: ShowIconForTeam
    /// </summary>
    public unsafe byte ShowIconForTeam_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 671); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 671); }
    }
    /// <summary>
    /// ByteProperty: ShowIconForTeam
    /// </summary>
    public unsafe byte ShowIconForTeam_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// StructProperty: NotificationIconData
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDUINotificationIcons.FSNotificationIconData NotificationIconData
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDUINotificationIcons.FSNotificationIconData>(Ptr + 676);
}
