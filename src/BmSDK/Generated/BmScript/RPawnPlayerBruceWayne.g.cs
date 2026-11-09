#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPawnPlayerBruceWayne<br/>
/// (size = 6372)
/// (flags = 10485814)
/// </summary>
public partial class RPawnPlayerBruceWayne : BmSDK.BmGame.RPawnPlayer, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnPlayerBruceWayne", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnPlayerBruceWayne.
    /// </summary>
    public static RPawnPlayerBruceWayne DefaultObject => (RPawnPlayerBruceWayne)StaticClass().DefaultObject;

    internal RPawnPlayerBruceWayne() { }

    /// <summary>
    /// Constructs a new RPawnPlayerBruceWayne
    /// </summary>
    public RPawnPlayerBruceWayne(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayerBruceWayne(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBruceWayne>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBruceWayne>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBruceWayne>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBruceWayne>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBruceWayne>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBruceWayne>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBruceWayne>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBruceWayne>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_AddDefaultInventory;
    /// <summary>
    /// Function: AddDefaultInventory
    /// </summary>
    public unsafe override void AddDefaultInventory()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDefaultInventory, "BmScript.RPawnPlayerBruceWayne.AddDefaultInventory");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FakeUnarmedCombatThugRef;
    /// <summary>
    /// Function: FakeUnarmedCombatThugRef
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet FakeUnarmedCombatThugRef()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FakeUnarmedCombatThugRef, "BmScript.RPawnPlayerBruceWayne.FakeUnarmedCombatThugRef");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FakeUnarmedCombatThugRefHolder;
    /// <summary>
    /// Function: FakeUnarmedCombatThugRefHolder
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RCharacterBioCue FakeUnarmedCombatThugRefHolder()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FakeUnarmedCombatThugRefHolder, "BmScript.RPawnPlayerBruceWayne.FakeUnarmedCombatThugRefHolder");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCharacterBioCue>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FindContactName;
    /// <summary>
    /// Function: FindContactName
    /// </summary>
    public unsafe override BmSDK.Engine.AkEvent FindContactName(BmSDK.BmGame.RAnimNotify_Footstep.EFoot Foot, BmSDK.BmGame.RAnimNotify_Footstep.EContactType Contact)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindContactName, "BmScript.RPawnPlayerBruceWayne.FindContactName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Foot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Contact, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ModifyExistingPoses;
    /// <summary>
    /// Function: ModifyExistingPoses
    /// </summary>
    public unsafe virtual void ModifyExistingPoses(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyExistingPoses, "BmScript.RPawnPlayerBruceWayne.ModifyExistingPoses");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupWirePoses;
    /// <summary>
    /// Function: SetupWirePoses
    /// </summary>
    public unsafe virtual void SetupWirePoses(BmSDK.BmGame.RPoseConfig PoseConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupWirePoses, "BmScript.RPawnPlayerBruceWayne.SetupWirePoses");
        byte* paramsPtr = stackalloc byte[716];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PoseConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddResonatorMovesToWeaponConfig;
    /// <summary>
    /// Function: AddResonatorMovesToWeaponConfig
    /// </summary>
    public unsafe virtual void AddResonatorMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddResonatorMovesToWeaponConfig, "BmScript.RPawnPlayerBruceWayne.AddResonatorMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[992];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddBatmanMovesToWeaponConfig;
    /// <summary>
    /// Function: AddBatmanMovesToWeaponConfig
    /// </summary>
    public unsafe virtual void AddBatmanMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddBatmanMovesToWeaponConfig, "BmScript.RPawnPlayerBruceWayne.AddBatmanMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[1068];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddMovementMovesToWeaponConfig;
    /// <summary>
    /// Function: AddMovementMovesToWeaponConfig
    /// </summary>
    public unsafe override void AddMovementMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddMovementMovesToWeaponConfig, "BmScript.RPawnPlayerBruceWayne.AddMovementMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideCuffs;
    /// <summary>
    /// Function: HideCuffs
    /// </summary>
    public unsafe virtual void HideCuffs()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideCuffs, "BmScript.RPawnPlayerBruceWayne.HideCuffs");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BreakLegChains;
    /// <summary>
    /// Function: BreakLegChains
    /// </summary>
    public unsafe virtual void BreakLegChains()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BreakLegChains, "BmScript.RPawnPlayerBruceWayne.BreakLegChains");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupCustomPhysics;
    /// <summary>
    /// Function: SetupCustomPhysics
    /// </summary>
    public unsafe override void SetupCustomPhysics()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupCustomPhysics, "BmScript.RPawnPlayerBruceWayne.SetupCustomPhysics");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindAndPlayOverrideDeathAnim;
    /// <summary>
    /// Function: FindAndPlayOverrideDeathAnim
    /// </summary>
    public unsafe override bool FindAndPlayOverrideDeathAnim(BmSDK.Class DamageType, BmSDK.Engine.Controller Killer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindAndPlayOverrideDeathAnim, "BmScript.RPawnPlayerBruceWayne.FindAndPlayOverrideDeathAnim");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetQuickStrikeType;
    /// <summary>
    /// Function: GetQuickStrikeType
    /// </summary>
    public unsafe override BmSDK.Class GetQuickStrikeType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetQuickStrikeType, "BmScript.RPawnPlayerBruceWayne.GetQuickStrikeType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_EndCounterCam;
    /// <summary>
    /// Function: EndCounterCam
    /// </summary>
    public unsafe virtual void EndCounterCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndCounterCam, "BmScript.RPawnPlayerBruceWayne.EndCounterCam");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SlowStart;
    /// <summary>
    /// Function: SlowStart
    /// </summary>
    public unsafe virtual void SlowStart()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SlowStart, "BmScript.RPawnPlayerBruceWayne.SlowStart");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayHandbuffBreakCamera;
    /// <summary>
    /// Function: PlayHandbuffBreakCamera
    /// </summary>
    public unsafe override void PlayHandbuffBreakCamera(System.Numerics.Vector3 Loc, BmSDK.Rotator Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHandbuffBreakCamera, "BmScript.RPawnPlayerBruceWayne.PlayHandbuffBreakCamera");
        byte* paramsPtr = stackalloc byte[104];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SlowMoStopEvent;
    /// <summary>
    /// Function: SlowMoStopEvent
    /// </summary>
    public unsafe virtual void SlowMoStopEvent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SlowMoStopEvent, "BmScript.RPawnPlayerBruceWayne.SlowMoStopEvent");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SlowMoStartEvent;
    /// <summary>
    /// Function: SlowMoStartEvent
    /// </summary>
    public unsafe virtual void SlowMoStartEvent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SlowMoStartEvent, "BmScript.RPawnPlayerBruceWayne.SlowMoStartEvent");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAfterCombatAnimset;
    /// <summary>
    /// Function: GetAfterCombatAnimset
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetAfterCombatAnimset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAfterCombatAnimset, "BmScript.RPawnPlayerBruceWayne.GetAfterCombatAnimset");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SleavesUp;
    /// <summary>
    /// Function: SleavesUp
    /// </summary>
    public unsafe virtual void SleavesUp(bool bOnOrOff)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SleavesUp, "BmScript.RPawnPlayerBruceWayne.SleavesUp");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnOrOff, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmScript.RPawnPlayerBruceWayne.Tick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmScript.RPawnPlayerBruceWayne.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ComponentProperty: ChainsMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent ChainsMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 6332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6332); }
    }

    /// <summary>
    /// ComponentProperty: BrokenChainsMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent BrokenChainsMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 6336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6336); }
    }

    /// <summary>
    /// ComponentProperty: HandCuffsMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent HandCuffsMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 6340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6340); }
    }

    /// <summary>
    /// ComponentProperty: BrokenHandCuffsMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent BrokenHandCuffsMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 6344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6344); }
    }

    /// <summary>
    /// IntProperty: NumCuffStrikesSinceKO
    /// </summary>
    public unsafe int NumCuffStrikesSinceKO
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6348); }
    }

    /// <summary>
    /// BoolProperty: bCanTakeDamage
    /// </summary>
    public unsafe bool bCanTakeDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6352) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6352); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6352); }
    }

    /// <summary>
    /// StructProperty: OldLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 OldLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6356);

    /// <summary>
    /// IntProperty: TeleportCount
    /// </summary>
    public unsafe int TeleportCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6368); }
    }
}
