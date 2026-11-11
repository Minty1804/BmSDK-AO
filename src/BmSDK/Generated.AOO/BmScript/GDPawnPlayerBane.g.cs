#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: GDPawnPlayerBane<br/>
/// (size = 7100)
/// (flags = 10518582)
/// </summary>
public partial class GDPawnPlayerBane : BmSDK.BmGame.GDPawnPlayerBaneBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.GDPawnPlayerBane", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDPawnPlayerBane.
    /// </summary>
    public static GDPawnPlayerBane DefaultObject => (GDPawnPlayerBane)StaticClass().DefaultObject;

    internal GDPawnPlayerBane() { }

    /// <summary>
    /// Constructs a new GDPawnPlayerBane
    /// </summary>
    public GDPawnPlayerBane(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDPawnPlayerBane(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerBane>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerBane>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerBane>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerBane>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerBane>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerBane>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerBane>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerBane>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CreateCombatWeaponConfig;
    /// <summary>
    /// Function: CreateCombatWeaponConfig
    /// </summary>
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateCombatWeaponConfig()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateCombatWeaponConfig, "BmScript.GDPawnPlayerBane.CreateCombatWeaponConfig");
        byte* paramsPtr = stackalloc byte[1796];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CreateWritheWeaponConfig;
    /// <summary>
    /// Function: CreateWritheWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateWritheWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.Engine.AnimSet AnimSet1)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateWritheWeaponConfig, "BmScript.GDPawnPlayerBane.CreateWritheWeaponConfig");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CreateRagdollWeaponConfig;
    /// <summary>
    /// Function: CreateRagdollWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateRagdollWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.Engine.AnimSet AnimSet1, BmSDK.Engine.AnimSet AnimSet2, BmSDK.Engine.AnimSet AnimSet3 = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateRagdollWeaponConfig, "BmScript.GDPawnPlayerBane.CreateRagdollWeaponConfig");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet2, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet3, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CreateUnarmedWeaponConfig;
    /// <summary>
    /// Function: CreateUnarmedWeaponConfig
    /// </summary>
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateUnarmedWeaponConfig()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateUnarmedWeaponConfig, "BmScript.GDPawnPlayerBane.CreateUnarmedWeaponConfig");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayExplosionDeathPrimer;
    /// <summary>
    /// Function: PlayExplosionDeathPrimer
    /// </summary>
    public unsafe override bool PlayExplosionDeathPrimer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayExplosionDeathPrimer, "BmScript.GDPawnPlayerBane.PlayExplosionDeathPrimer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FindContactName;
    /// <summary>
    /// Function: FindContactName
    /// </summary>
    public unsafe override BmSDK.Engine.AkEvent FindContactName(BmSDK.BmGame.RAnimNotify_Footstep.EFoot Foot, BmSDK.BmGame.RAnimNotify_Footstep.EContactType Contact)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindContactName, "BmScript.GDPawnPlayerBane.FindContactName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Foot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Contact, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetContactCharacterName;
    /// <summary>
    /// Function: GetContactCharacterName
    /// </summary>
    public unsafe override BmSDK.FString GetContactCharacterName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetContactCharacterName, "BmScript.GDPawnPlayerBane.GetContactCharacterName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetupRocketLauncherPose;
    /// <summary>
    /// Function: SetupRocketLauncherPose
    /// </summary>
    public unsafe virtual void SetupRocketLauncherPose(out BmSDK.BmGame.RPoseConfig.FPose LauncherPose)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupRocketLauncherPose, "BmScript.GDPawnPlayerBane.SetupRocketLauncherPose");
        byte* paramsPtr = stackalloc byte[360];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        LauncherPose = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_AddMovementMovesToWeaponConfig;
    /// <summary>
    /// Function: AddMovementMovesToWeaponConfig
    /// </summary>
    public unsafe override void AddMovementMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddMovementMovesToWeaponConfig, "BmScript.GDPawnPlayerBane.AddMovementMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[500];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopAimAt;
    /// <summary>
    /// Function: StopAimAt
    /// </summary>
    public unsafe override void StopAimAt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAimAt, "BmScript.GDPawnPlayerBane.StopAimAt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AimInDirection;
    /// <summary>
    /// Function: AimInDirection
    /// </summary>
    public unsafe override void AimInDirection(System.Numerics.Vector3 Direction, BmSDK.FName Description = default, BmSDK.BmGame.RAnimConfig.EYesNoDefault AllowTurningToAim = default, float LimitScale = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AimInDirection, "BmScript.GDPawnPlayerBane.AimInDirection");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AllowTurningToAim, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LimitScale, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindAndPlayOverrideDeathAnim;
    /// <summary>
    /// Function: FindAndPlayOverrideDeathAnim
    /// </summary>
    public unsafe override bool FindAndPlayOverrideDeathAnim(BmSDK.Class DamageType, bool IsHeadshot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindAndPlayOverrideDeathAnim, "BmScript.GDPawnPlayerBane.FindAndPlayOverrideDeathAnim");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsHeadshot, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AllowInteractableItem;
    /// <summary>
    /// Function: AllowInteractableItem
    /// </summary>
    public unsafe override bool AllowInteractableItem(BmSDK.BmGame.RInteractInterface InteractIface)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowInteractableItem, "BmScript.GDPawnPlayerBane.AllowInteractableItem");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InteractIface, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmScript.GDPawnPlayerBane.Tick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Internal_SpawnHit;
    /// <summary>
    /// Function: Internal_SpawnHit
    /// </summary>
    public unsafe override void Internal_SpawnHit(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo, bool IgnoreHitReaction, bool IgnoreStagger)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Internal_SpawnHit, "BmScript.GDPawnPlayerBane.Internal_SpawnHit");
        byte* paramsPtr = stackalloc byte[284];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IgnoreHitReaction, paramsPtr + 244);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IgnoreStagger, paramsPtr + 248);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetUpFromStunnedRagdoll;
    /// <summary>
    /// Function: GetUpFromStunnedRagdoll
    /// </summary>
    public unsafe virtual void GetUpFromStunnedRagdoll(bool bInTakedown)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUpFromStunnedRagdoll, "BmScript.GDPawnPlayerBane.GetUpFromStunnedRagdoll");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInTakedown, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientGetUpFromStunnedRagdoll;
    /// <summary>
    /// Function: ClientGetUpFromStunnedRagdoll
    /// </summary>
    public unsafe virtual void ClientGetUpFromStunnedRagdoll(bool bInTakedown)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientGetUpFromStunnedRagdoll, "BmScript.GDPawnPlayerBane.ClientGetUpFromStunnedRagdoll");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInTakedown, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoRagdoll;
    /// <summary>
    /// Function: GotoRagdoll
    /// </summary>
    public unsafe virtual void GotoRagdoll(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo, bool bKill)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoRagdoll, "BmScript.GDPawnPlayerBane.GotoRagdoll");
        byte* paramsPtr = stackalloc byte[264];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKill, paramsPtr + 244);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Internal_ClientGotoRagdoll;
    /// <summary>
    /// Function: Internal_ClientGotoRagdoll
    /// </summary>
    public unsafe override void Internal_ClientGotoRagdoll(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo, bool bKill)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Internal_ClientGotoRagdoll, "BmScript.GDPawnPlayerBane.Internal_ClientGotoRagdoll");
        byte* paramsPtr = stackalloc byte[264];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKill, paramsPtr + 244);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsGoodAsDead;
    /// <summary>
    /// Function: IsGoodAsDead
    /// </summary>
    public unsafe override bool IsGoodAsDead()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsGoodAsDead, "BmScript.GDPawnPlayerBane.IsGoodAsDead");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetGoodAsDead;
    /// <summary>
    /// Function: SetGoodAsDead
    /// </summary>
    public unsafe override void SetGoodAsDead()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGoodAsDead, "BmScript.GDPawnPlayerBane.SetGoodAsDead");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DamagedBy;
    /// <summary>
    /// Function: DamagedBy
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult DamagedBy(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamagedBy, "BmScript.GDPawnPlayerBane.DamagedBy");
        byte* paramsPtr = stackalloc byte[280];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 244);
    }

    private static BmSDK.Function __fn_FinishedGetUp;
    /// <summary>
    /// Function: FinishedGetUp
    /// </summary>
    public unsafe override void FinishedGetUp()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishedGetUp, "BmScript.GDPawnPlayerBane.FinishedGetUp");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTimeToClearQuickStrikeCount;
    /// <summary>
    /// Function: GetTimeToClearQuickStrikeCount
    /// </summary>
    public unsafe override float GetTimeToClearQuickStrikeCount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTimeToClearQuickStrikeCount, "BmScript.GDPawnPlayerBane.GetTimeToClearQuickStrikeCount");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNumQuickStrikeToRagdoll;
    /// <summary>
    /// Function: GetNumQuickStrikeToRagdoll
    /// </summary>
    public unsafe override int GetNumQuickStrikeToRagdoll()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumQuickStrikeToRagdoll, "BmScript.GDPawnPlayerBane.GetNumQuickStrikeToRagdoll");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldGoRagdoll;
    /// <summary>
    /// Function: ShouldGoRagdoll
    /// </summary>
    public unsafe virtual bool ShouldGoRagdoll(BmSDK.Class dmgType, float DamageAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldGoRagdoll, "BmScript.GDPawnPlayerBane.ShouldGoRagdoll");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsAwareOfPlayer;
    /// <summary>
    /// Function: IsAwareOfPlayer
    /// </summary>
    public unsafe override bool IsAwareOfPlayer(BmSDK.BmGame.RPawnPlayer PlayerPawn, BmSDK.Class dmgType = default, bool PostCheck = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAwareOfPlayer, "BmScript.GDPawnPlayerBane.IsAwareOfPlayer");
        byte* paramsPtr = stackalloc byte[116];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PostCheck, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ImmuneToBatarang;
    /// <summary>
    /// Function: ImmuneToBatarang
    /// </summary>
    public unsafe override bool ImmuneToBatarang(bool ActualHit, BmSDK.BmGame.RPawnPlayer Thrower)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ImmuneToBatarang, "BmScript.GDPawnPlayerBane.ImmuneToBatarang");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActualHit, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thrower, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanBeDoubleTakeDownVictim;
    /// <summary>
    /// Function: CanBeDoubleTakeDownVictim
    /// </summary>
    public unsafe override bool CanBeDoubleTakeDownVictim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeDoubleTakeDownVictim, "BmScript.GDPawnPlayerBane.CanBeDoubleTakeDownVictim");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanBeTakeDownVictim;
    /// <summary>
    /// Function: CanBeTakeDownVictim
    /// </summary>
    public unsafe override bool CanBeTakeDownVictim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeTakeDownVictim, "BmScript.GDPawnPlayerBane.CanBeTakeDownVictim");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HitByBatarang;
    /// <summary>
    /// Function: HitByBatarang
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult HitByBatarang(int Damage, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default, BmSDK.BmGame.RPawnCombat DamagePawn = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitByBatarang, "BmScript.GDPawnPlayerBane.HitByBatarang");
        byte* paramsPtr = stackalloc byte[360];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamagePawn, paramsPtr + 76);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 80);
    }

    private static BmSDK.Function __fn_GetGlideKickEffectLocation;
    /// <summary>
    /// Function: GetGlideKickEffectLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetGlideKickEffectLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGlideKickEffectLocation, "BmScript.GDPawnPlayerBane.GetGlideKickEffectLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSupervillainSpawnStunEffectVars;
    /// <summary>
    /// Function: GetSupervillainSpawnStunEffectVars
    /// </summary>
    public unsafe override void GetSupervillainSpawnStunEffectVars(out BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo Effect, out BmSDK.FName SocketName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSupervillainSpawnStunEffectVars, "BmScript.GDPawnPlayerBane.GetSupervillainSpawnStunEffectVars");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SocketName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SocketName, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Effect = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo>(paramsPtr + 0);
        SocketName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 48);
        return;
    }

    private static BmSDK.Function __fn_GetSupervillainGetUpStunRadius;
    /// <summary>
    /// Function: GetSupervillainGetUpStunRadius
    /// </summary>
    public unsafe override void GetSupervillainGetUpStunRadius(out float StunRadius, out float StunRadiusMaxZ)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSupervillainGetUpStunRadius, "BmScript.GDPawnPlayerBane.GetSupervillainGetUpStunRadius");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StunRadius);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StunRadius, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StunRadiusMaxZ);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StunRadiusMaxZ, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        StunRadius = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        StunRadiusMaxZ = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_GetSupervillainGetUpStunVars;
    /// <summary>
    /// Function: GetSupervillainGetUpStunVars
    /// </summary>
    public unsafe override void GetSupervillainGetUpStunVars(out float StunDuration, out float StunMomentumTransfer, out float StunDmg, out byte StunFriendlies)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSupervillainGetUpStunVars, "BmScript.GDPawnPlayerBane.GetSupervillainGetUpStunVars");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StunDuration);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StunDuration, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StunMomentumTransfer);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StunMomentumTransfer, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StunDmg);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StunDmg, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StunFriendlies);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StunFriendlies, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        StunDuration = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        StunMomentumTransfer = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        StunDmg = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        StunFriendlies = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetSupervillainStunRadius;
    /// <summary>
    /// Function: GetSupervillainStunRadius
    /// </summary>
    public unsafe override void GetSupervillainStunRadius(out float StunRadius, out float StunRadiusMaxZ)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSupervillainStunRadius, "BmScript.GDPawnPlayerBane.GetSupervillainStunRadius");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StunRadius);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StunRadius, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StunRadiusMaxZ);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StunRadiusMaxZ, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        StunRadius = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        StunRadiusMaxZ = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_GetSupervillainStunVars;
    /// <summary>
    /// Function: GetSupervillainStunVars
    /// </summary>
    public unsafe override void GetSupervillainStunVars(out float StunDuration, out float StunMomentumTransfer, out float StunDmg, out byte StunFriendlies)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSupervillainStunVars, "BmScript.GDPawnPlayerBane.GetSupervillainStunVars");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StunDuration);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StunDuration, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StunMomentumTransfer);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StunMomentumTransfer, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StunDmg);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StunDmg, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StunFriendlies);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StunFriendlies, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        StunDuration = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        StunMomentumTransfer = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        StunDmg = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        StunFriendlies = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetIntroAnimationNamesAndSets;
    /// <summary>
    /// Function: GetIntroAnimationNamesAndSets
    /// </summary>
    public unsafe override void GetIntroAnimationNamesAndSets(out BmSDK.Engine.AnimSet SupervillainIntroAnimSet, out BmSDK.Engine.AnimSet ThugIntroAnimSet, out BmSDK.Engine.AnimSet CameraIntroAnimSet, out BmSDK.FName SupervillainIntroAnimName, out BmSDK.FName ThugIntroAnimName, out BmSDK.FName CameraIntroAnimName, out float CameraIntroBlendTime, out float CameraIntroFOV, out int CameraIntroHardCut)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIntroAnimationNamesAndSets, "BmScript.GDPawnPlayerBane.GetIntroAnimationNamesAndSets");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SupervillainIntroAnimSet);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SupervillainIntroAnimSet, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ThugIntroAnimSet);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugIntroAnimSet, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CameraIntroAnimSet);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraIntroAnimSet, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SupervillainIntroAnimName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SupervillainIntroAnimName, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ThugIntroAnimName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugIntroAnimName, paramsPtr + 20);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CameraIntroAnimName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraIntroAnimName, paramsPtr + 28);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CameraIntroBlendTime);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraIntroBlendTime, paramsPtr + 36);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CameraIntroFOV);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraIntroFOV, paramsPtr + 40);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CameraIntroHardCut);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraIntroHardCut, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SupervillainIntroAnimSet = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
        ThugIntroAnimSet = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 4);
        CameraIntroAnimSet = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
        SupervillainIntroAnimName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 12);
        ThugIntroAnimName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 20);
        CameraIntroAnimName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 28);
        CameraIntroBlendTime = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 36);
        CameraIntroFOV = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 40);
        CameraIntroHardCut = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 44);
        return;
    }

    private static BmSDK.Function __fn_ReduceTakedownLives;
    /// <summary>
    /// Function: ReduceTakedownLives
    /// </summary>
    public unsafe override void ReduceTakedownLives()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReduceTakedownLives, "BmScript.GDPawnPlayerBane.ReduceTakedownLives");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AreTakedownsFatal;
    /// <summary>
    /// Function: AreTakedownsFatal
    /// </summary>
    public unsafe override bool AreTakedownsFatal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreTakedownsFatal, "BmScript.GDPawnPlayerBane.AreTakedownsFatal");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNonFatalTakedownDamage;
    /// <summary>
    /// Function: GetNonFatalTakedownDamage
    /// </summary>
    public unsafe override float GetNonFatalTakedownDamage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNonFatalTakedownDamage, "BmScript.GDPawnPlayerBane.GetNonFatalTakedownDamage");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RemoveSpawnProtection;
    /// <summary>
    /// Function: RemoveSpawnProtection
    /// </summary>
    public unsafe override void RemoveSpawnProtection()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveSpawnProtection, "BmScript.GDPawnPlayerBane.RemoveSpawnProtection");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmScript.GDPawnPlayerBane.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetStunStrikeDamageType;
    /// <summary>
    /// Function: GetStunStrikeDamageType
    /// </summary>
    public unsafe override BmSDK.Class GetStunStrikeDamageType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStunStrikeDamageType, "BmScript.GDPawnPlayerBane.GetStunStrikeDamageType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetQuickStrikeDamageType;
    /// <summary>
    /// Function: GetQuickStrikeDamageType
    /// </summary>
    public unsafe override BmSDK.Class GetQuickStrikeDamageType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetQuickStrikeDamageType, "BmScript.GDPawnPlayerBane.GetQuickStrikeDamageType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Bump;
    /// <summary>
    /// Function: Bump
    /// </summary>
    public unsafe override void Bump(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Bump, "BmScript.GDPawnPlayerBane.Bump");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowAttackerTracking;
    /// <summary>
    /// Function: AllowAttackerTracking
    /// </summary>
    public unsafe override bool AllowAttackerTracking()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowAttackerTracking, "BmScript.GDPawnPlayerBane.AllowAttackerTracking");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPlayerAvatarString;
    /// <summary>
    /// Function: GetPlayerAvatarString
    /// </summary>
    public unsafe override BmSDK.FString GetPlayerAvatarString()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerAvatarString, "BmScript.GDPawnPlayerBane.GetPlayerAvatarString");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// ComponentProperty: PlayerInteractions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent PlayerInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 7068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7068); }
    }

    /// <summary>
    /// BoolProperty: bBurstDamageAmountActive
    /// </summary>
    public unsafe bool bBurstDamageAmountActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7072) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7072); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7072); }
    }

    /// <summary>
    /// FloatProperty: BurstDamageAmount
    /// </summary>
    public unsafe float BurstDamageAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7076); }
    }

    /// <summary>
    /// FloatProperty: TimeFromLastDamage
    /// </summary>
    public unsafe float TimeFromLastDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7080); }
    }

    /// <summary>
    /// IntProperty: TakedownLives
    /// </summary>
    public unsafe int TakedownLives
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7084); }
    }

    /// <summary>
    /// ObjectProperty: LastHitMove
    /// </summary>
    public unsafe BmSDK.BmGame.GDCombatMove_ThugHit LastHitMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDCombatMove_ThugHit>(Ptr + 7088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7088); }
    }

    /// <summary>
    /// FloatProperty: TakedownAwarePitchLimit
    /// </summary>
    public unsafe float TakedownAwarePitchLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7092); }
    }

    /// <summary>
    /// ObjectProperty: RagdollPoseConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RPoseConfig RagdollPoseConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig>(Ptr + 7096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7096); }
    }
}
