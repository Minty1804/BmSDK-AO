#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MPawnVillainMartialArtist<br/>
/// (size = 4216)
/// (flags = 10485814)
/// </summary>
public partial class MPawnVillainMartialArtist : BmSDK.BmGame.RPawnVillainThug, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MPawnVillainMartialArtist", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MPawnVillainMartialArtist.
    /// </summary>
    public static MPawnVillainMartialArtist DefaultObject => (MPawnVillainMartialArtist)StaticClass().DefaultObject;

    internal MPawnVillainMartialArtist() { }

    /// <summary>
    /// Constructs a new MPawnVillainMartialArtist
    /// </summary>
    public MPawnVillainMartialArtist(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MPawnVillainMartialArtist(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillainMartialArtist>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainMartialArtist>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillainMartialArtist>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainMartialArtist>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainMartialArtist>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainMartialArtist>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillainMartialArtist>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainMartialArtist>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_FakeUnarmedCombatRef;
    /// <summary>
    /// Function: FakeUnarmedCombatRef
    /// </summary>
    public unsafe virtual BmSDK.GameObject FakeUnarmedCombatRef()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FakeUnarmedCombatRef, "BmScript.MPawnVillainMartialArtist.FakeUnarmedCombatRef");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTargetPriority;
    /// <summary>
    /// Function: GetTargetPriority
    /// </summary>
    public unsafe override float GetTargetPriority(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargetPriority, "BmScript.MPawnVillainMartialArtist.GetTargetPriority");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsValidBatclawSlamTarget;
    /// <summary>
    /// Function: IsValidBatclawSlamTarget
    /// </summary>
    public unsafe override bool IsValidBatclawSlamTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidBatclawSlamTarget, "BmScript.MPawnVillainMartialArtist.IsValidBatclawSlamTarget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DamagedBy;
    /// <summary>
    /// Function: DamagedBy
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult DamagedBy(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamagedBy, "BmScript.MPawnVillainMartialArtist.DamagedBy");
        byte* paramsPtr = stackalloc byte[273];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 256);
    }

    private static BmSDK.Function __fn_StopAttackingFX;
    /// <summary>
    /// Function: StopAttackingFX
    /// </summary>
    public unsafe override void StopAttackingFX(bool bSuccessfulCounter = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAttackingFX, "BmScript.MPawnVillainMartialArtist.StopAttackingFX");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSuccessfulCounter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveAttackingFX;
    /// <summary>
    /// Function: RemoveAttackingFX
    /// </summary>
    public unsafe virtual void RemoveAttackingFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveAttackingFX, "BmScript.MPawnVillainMartialArtist.RemoveAttackingFX");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartAttackingFX;
    /// <summary>
    /// Function: StartAttackingFX
    /// </summary>
    public unsafe override void StartAttackingFX(int CTypeInt, BmSDK.BmGame.RPlayerController PC = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAttackingFX, "BmScript.MPawnVillainMartialArtist.StartAttackingFX");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CTypeInt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCloseAttackMoveStance;
    /// <summary>
    /// Function: GetCloseAttackMoveStance
    /// </summary>
    public unsafe override BmSDK.FName GetCloseAttackMoveStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCloseAttackMoveStance, "BmScript.MPawnVillainMartialArtist.GetCloseAttackMoveStance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CreateWeaponConfigUnarmed;
    /// <summary>
    /// Function: CreateWeaponConfigUnarmed
    /// </summary>
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateWeaponConfigUnarmed(BmSDK.GameObject NewOwner)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateWeaponConfigUnarmed, "BmScript.MPawnVillainMartialArtist.CreateWeaponConfigUnarmed");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CreateMartialArtistWeaponConfig;
    /// <summary>
    /// Function: CreateMartialArtistWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateMartialArtistWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.Engine.AnimSet AnimSet1 = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateMartialArtistWeaponConfig, "BmScript.MPawnVillainMartialArtist.CreateMartialArtistWeaponConfig");
        byte* paramsPtr = stackalloc byte[384];
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
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateRagdollWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.Engine.AnimSet AnimSet1, BmSDK.Engine.AnimSet AnimSet2, BmSDK.Engine.AnimSet AnimSet3 = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateRagdollWeaponConfig, "BmScript.MPawnVillainMartialArtist.CreateRagdollWeaponConfig");
        byte* paramsPtr = stackalloc byte[2448];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet2, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet3, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_PlayRagdoll;
    /// <summary>
    /// Function: PlayRagdoll
    /// </summary>
    public unsafe override void PlayRagdoll(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo, BmSDK.BmGame.RGameInfo.RagdollStunType NewStunType = default, bool bKill = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayRagdoll, "BmScript.MPawnVillainMartialArtist.PlayRagdoll");
        byte* paramsPtr = stackalloc byte[280];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewStunType, paramsPtr + 256);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKill, paramsPtr + 260);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetOverrideGetUpBackward;
    /// <summary>
    /// Function: GetOverrideGetUpBackward
    /// </summary>
    public unsafe override BmSDK.BmGame.RAnimUtil.FTransitionId GetOverrideGetUpBackward(BmSDK.FName MovementStance, BmSDK.FName WeaponStance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOverrideGetUpBackward, "BmScript.MPawnVillainMartialArtist.GetOverrideGetUpBackward");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetOverrideGetUpFwd;
    /// <summary>
    /// Function: GetOverrideGetUpFwd
    /// </summary>
    public unsafe override BmSDK.BmGame.RAnimUtil.FTransitionId GetOverrideGetUpFwd(BmSDK.FName MovementStance, BmSDK.FName WeaponStance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOverrideGetUpFwd, "BmScript.MPawnVillainMartialArtist.GetOverrideGetUpFwd");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_SpawnSpecialAttack;
    /// <summary>
    /// Function: SpawnSpecialAttack
    /// </summary>
    public unsafe override bool SpawnSpecialAttack(BmSDK.BmGame.RPawnCombat PlayerPawn, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnSpecialAttack, "BmScript.MPawnVillainMartialArtist.SpawnSpecialAttack");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CheckForStrikeDamageType;
    /// <summary>
    /// Function: CheckForStrikeDamageType
    /// </summary>
    public unsafe virtual bool CheckForStrikeDamageType(BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForStrikeDamageType, "BmScript.MPawnVillainMartialArtist.CheckForStrikeDamageType");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SpawnOverrideTakedown;
    /// <summary>
    /// Function: SpawnOverrideTakedown
    /// </summary>
    public unsafe override bool SpawnOverrideTakedown(BmSDK.BmGame.RPawnCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnOverrideTakedown, "BmScript.MPawnVillainMartialArtist.SpawnOverrideTakedown");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsForcedToRemainInStunState;
    /// <summary>
    /// Function: IsForcedToRemainInStunState
    /// </summary>
    public unsafe override bool IsForcedToRemainInStunState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsForcedToRemainInStunState, "BmScript.MPawnVillainMartialArtist.IsForcedToRemainInStunState");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Untargetted;
    /// <summary>
    /// Function: Untargetted
    /// </summary>
    public unsafe override void Untargetted(BmSDK.BmGame.RPawnCombat Attacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Untargetted, "BmScript.MPawnVillainMartialArtist.Untargetted");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TargettedBy;
    /// <summary>
    /// Function: TargettedBy
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.TargetStrikeResponse TargettedBy(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class dmgType, bool bFar = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TargettedBy, "BmScript.MPawnVillainMartialArtist.TargettedBy");
        byte* paramsPtr = stackalloc byte[29];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFar, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.TargetStrikeResponse>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CanBeInSimultaneousAttack;
    /// <summary>
    /// Function: CanBeInSimultaneousAttack
    /// </summary>
    public unsafe override bool CanBeInSimultaneousAttack(BmSDK.BmGame.RPawnCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeInSimultaneousAttack, "BmScript.MPawnVillainMartialArtist.CanBeInSimultaneousAttack");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetCounterSuccessAnim;
    /// <summary>
    /// Function: GetCounterSuccessAnim
    /// </summary>
    public unsafe virtual BmSDK.FName GetCounterSuccessAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCounterSuccessAnim, "BmScript.MPawnVillainMartialArtist.GetCounterSuccessAnim");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCounterFailAnim;
    /// <summary>
    /// Function: GetCounterFailAnim
    /// </summary>
    public unsafe virtual BmSDK.FName GetCounterFailAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCounterFailAnim, "BmScript.MPawnVillainMartialArtist.GetCounterFailAnim");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBehaviour;
    /// <summary>
    /// Function: GetBehaviour
    /// </summary>
    public unsafe virtual BmSDK.BmScript.MBMBehaviour_CombatMartialArtist GetBehaviour()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBehaviour, "BmScript.MPawnVillainMartialArtist.GetBehaviour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmScript.MBMBehaviour_CombatMartialArtist>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanBlockDamageType;
    /// <summary>
    /// Function: CanBlockDamageType
    /// </summary>
    public unsafe override bool CanBlockDamageType(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBlockDamageType, "BmScript.MPawnVillainMartialArtist.CanBlockDamageType");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsBlockableDamage;
    /// <summary>
    /// Function: IsBlockableDamage
    /// </summary>
    public unsafe virtual bool IsBlockableDamage(BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBlockableDamage, "BmScript.MPawnVillainMartialArtist.IsBlockableDamage");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CanBlock;
    /// <summary>
    /// Function: CanBlock
    /// </summary>
    public unsafe override bool CanBlock()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBlock, "BmScript.MPawnVillainMartialArtist.CanBlock");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNonFatalTakedownStunTime;
    /// <summary>
    /// Function: GetNonFatalTakedownStunTime
    /// </summary>
    public unsafe override float GetNonFatalTakedownStunTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNonFatalTakedownStunTime, "BmScript.MPawnVillainMartialArtist.GetNonFatalTakedownStunTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNonFatalTakedownDamage;
    /// <summary>
    /// Function: GetNonFatalTakedownDamage
    /// </summary>
    public unsafe override float GetNonFatalTakedownDamage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNonFatalTakedownDamage, "BmScript.MPawnVillainMartialArtist.GetNonFatalTakedownDamage");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetCounterIcons;
    /// <summary>
    /// Function: SetCounterIcons
    /// </summary>
    public unsafe virtual void SetCounterIcons(BmSDK.TArray<BmSDK.BmScript.MPawnVillainMartialArtist.FCounterIcon> CounterIconFromCombatMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCounterIcons, "BmScript.MPawnVillainMartialArtist.SetCounterIcons");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CounterIconFromCombatMove, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmScript.MPawnVillainMartialArtist.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnBehaviourActivated;
    /// <summary>
    /// Function: OnBehaviourActivated
    /// </summary>
    public unsafe virtual void OnBehaviourActivated(BmSDK.BmScript.MBMBehaviour_CombatMartialArtist Behaviour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBehaviourActivated, "BmScript.MPawnVillainMartialArtist.OnBehaviourActivated");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Behaviour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FCounterIcon
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FCounterIcon
    {
        /// <summary>
        /// StructProperty: CounterOffset
        /// </summary>
        public unsafe System.Numerics.Vector3 CounterOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: BoneName
        /// </summary>
        public unsafe BmSDK.FName BoneName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: ScalingFactor
        /// </summary>
        public unsafe float ScalingFactor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: Batman
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer Batman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 4004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4004); }
    }

    /// <summary>
    /// ObjectProperty: BatmanRPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController BatmanRPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 4008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4008); }
    }

    /// <summary>
    /// IntProperty: NumberOfCounterIcons
    /// </summary>
    public unsafe int NumberOfCounterIcons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4012); }
    }

    /// <summary>
    /// ArrayProperty: HeadCounterPSC
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ParticleSystemComponent> HeadCounterPSC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ParticleSystemComponent>>(Ptr + 4016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4016); }
    }

    /// <summary>
    /// NameProperty: CounterFailAnim
    /// </summary>
    public unsafe BmSDK.FName CounterFailAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4028); }
    }

    /// <summary>
    /// NameProperty: CounterSuccessAnim
    /// </summary>
    public unsafe BmSDK.FName CounterSuccessAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4036); }
    }

    /// <summary>
    /// IntProperty: DifficultyLevel
    /// </summary>
    public unsafe int DifficultyLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4044); }
    }

    /// <summary>
    /// IntProperty: RandChanceToBlockBatarang
    /// </summary>
    public unsafe int RandChanceToBlockBatarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4048); }
    }

    /// <summary>
    /// IntProperty: NoOfTimesAttackedByPlayerBeforeCounter
    /// </summary>
    public unsafe int NoOfTimesAttackedByPlayerBeforeCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4052); }
    }

    /// <summary>
    /// StructProperty: CounterIconOffsetLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CounterIconOffsetLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4056);

    /// <summary>
    /// StructProperty: CounterIconOffsetIncrement
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CounterIconOffsetIncrement
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4068);

    /// <summary>
    /// InlineArray{IntProperty}: ChanceToBlockBatarang
    /// </summary>
    public InlineArray<int> ChanceToBlockBatarang => new(3, Ptr + 4080, 4, this);

    /// <summary>
    /// IntProperty: ChanceToBlockBatarang
    /// </summary>
    public unsafe int ChanceToBlockBatarang_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4080); }
    }
    /// <summary>
    /// IntProperty: ChanceToBlockBatarang
    /// </summary>
    public unsafe int ChanceToBlockBatarang_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4084); }
    }
    /// <summary>
    /// IntProperty: ChanceToBlockBatarang
    /// </summary>
    public unsafe int ChanceToBlockBatarang_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4088); }
    }

    /// <summary>
    /// ArrayProperty: BounceFromBackForward
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BounceFromBackForward
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4092); }
    }

    /// <summary>
    /// ArrayProperty: BounceFromBackBackward
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BounceFromBackBackward
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4104); }
    }

    /// <summary>
    /// ArrayProperty: BounceFromFrontForward
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BounceFromFrontForward
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4116); }
    }

    /// <summary>
    /// ArrayProperty: BounceFromFrontBackward
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BounceFromFrontBackward
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4128); }
    }

    /// <summary>
    /// FloatProperty: DefaultAttackPriority
    /// </summary>
    public unsafe float DefaultAttackPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4140); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: BMCounterDamageAmount
    /// </summary>
    public InlineArray<float> BMCounterDamageAmount => new(3, Ptr + 4144, 4, this);

    /// <summary>
    /// FloatProperty: BMCounterDamageAmount
    /// </summary>
    public unsafe float BMCounterDamageAmount_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4144); }
    }
    /// <summary>
    /// FloatProperty: BMCounterDamageAmount
    /// </summary>
    public unsafe float BMCounterDamageAmount_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4148); }
    }
    /// <summary>
    /// FloatProperty: BMCounterDamageAmount
    /// </summary>
    public unsafe float BMCounterDamageAmount_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4152); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: MACounterBMDamageAmount
    /// </summary>
    public InlineArray<float> MACounterBMDamageAmount => new(3, Ptr + 4156, 4, this);

    /// <summary>
    /// FloatProperty: MACounterBMDamageAmount
    /// </summary>
    public unsafe float MACounterBMDamageAmount_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4156); }
    }
    /// <summary>
    /// FloatProperty: MACounterBMDamageAmount
    /// </summary>
    public unsafe float MACounterBMDamageAmount_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4160); }
    }
    /// <summary>
    /// FloatProperty: MACounterBMDamageAmount
    /// </summary>
    public unsafe float MACounterBMDamageAmount_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4164); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: BMCounterStunTime
    /// </summary>
    public InlineArray<float> BMCounterStunTime => new(3, Ptr + 4168, 4, this);

    /// <summary>
    /// FloatProperty: BMCounterStunTime
    /// </summary>
    public unsafe float BMCounterStunTime_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4168); }
    }
    /// <summary>
    /// FloatProperty: BMCounterStunTime
    /// </summary>
    public unsafe float BMCounterStunTime_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4172); }
    }
    /// <summary>
    /// FloatProperty: BMCounterStunTime
    /// </summary>
    public unsafe float BMCounterStunTime_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4176); }
    }

    /// <summary>
    /// FloatProperty: BMCounterImpulse
    /// </summary>
    public unsafe float BMCounterImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4180); }
    }

    /// <summary>
    /// FloatProperty: OverrideCounterAnimRateScale
    /// </summary>
    public unsafe float OverrideCounterAnimRateScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4184); }
    }

    /// <summary>
    /// BoolProperty: bTargettedForFloorTakedown
    /// </summary>
    public unsafe bool bTargettedForFloorTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4188) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4188); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4188); }
    }

    /// <summary>
    /// ObjectProperty: BMHitReactionAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BMHitReactionAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4192); }
    }

    /// <summary>
    /// ObjectProperty: VillainBlockInstantTakedownAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainBlockInstantTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4196); }
    }

    /// <summary>
    /// ObjectProperty: PlayerBlockInstantTakedownAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerBlockInstantTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4200); }
    }

    /// <summary>
    /// ArrayProperty: CounterIcons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.MPawnVillainMartialArtist.FCounterIcon> CounterIcons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.MPawnVillainMartialArtist.FCounterIcon>>(Ptr + 4204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4204); }
    }
}
