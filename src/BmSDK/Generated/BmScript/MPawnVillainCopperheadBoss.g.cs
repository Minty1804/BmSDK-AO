#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MPawnVillainCopperheadBoss<br/>
/// (size = 4488)
/// (flags = 10485814)
/// </summary>
public partial class MPawnVillainCopperheadBoss : BmSDK.BmScript.MPawnVillainCopperhead, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MPawnVillainCopperheadBoss", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MPawnVillainCopperheadBoss.
    /// </summary>
    public static MPawnVillainCopperheadBoss DefaultObject => (MPawnVillainCopperheadBoss)StaticClass().DefaultObject;

    internal MPawnVillainCopperheadBoss() { }

    /// <summary>
    /// Constructs a new MPawnVillainCopperheadBoss
    /// </summary>
    public MPawnVillainCopperheadBoss(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MPawnVillainCopperheadBoss(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillainCopperheadBoss>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainCopperheadBoss>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillainCopperheadBoss>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainCopperheadBoss>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainCopperheadBoss>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainCopperheadBoss>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillainCopperheadBoss>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainCopperheadBoss>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CheckDodgeProjectile;
    /// <summary>
    /// Function: CheckDodgeProjectile
    /// </summary>
    public unsafe override bool CheckDodgeProjectile(BmSDK.BmGame.RPawn Thrower, BmSDK.FName TargetBone, System.Numerics.Vector3 ProjPos, int BatarangID, bool bForceDodge = default, bool bSteerableProj = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckDodgeProjectile, "BmScript.MPawnVillainCopperheadBoss.CheckDodgeProjectile");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thrower, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBone, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProjPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatarangID, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceDodge, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSteerableProj, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmScript.MPawnVillainCopperheadBoss.Tick");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanUseItsOwnStunTime;
    /// <summary>
    /// Function: CanUseItsOwnStunTime
    /// </summary>
    public unsafe override bool CanUseItsOwnStunTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUseItsOwnStunTime, "BmScript.MPawnVillainCopperheadBoss.CanUseItsOwnStunTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPlaySpawnDialogue;
    /// <summary>
    /// Function: CanPlaySpawnDialogue
    /// </summary>
    public unsafe virtual bool CanPlaySpawnDialogue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlaySpawnDialogue, "BmScript.MPawnVillainCopperheadBoss.CanPlaySpawnDialogue");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPlayDeathDialogue;
    /// <summary>
    /// Function: CanPlayDeathDialogue
    /// </summary>
    public unsafe virtual bool CanPlayDeathDialogue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayDeathDialogue, "BmScript.MPawnVillainCopperheadBoss.CanPlayDeathDialogue");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPlayDashDialogue;
    /// <summary>
    /// Function: CanPlayDashDialogue
    /// </summary>
    public unsafe virtual bool CanPlayDashDialogue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayDashDialogue, "BmScript.MPawnVillainCopperheadBoss.CanPlayDashDialogue");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPlayTauntDialogue;
    /// <summary>
    /// Function: CanPlayTauntDialogue
    /// </summary>
    public unsafe virtual bool CanPlayTauntDialogue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayTauntDialogue, "BmScript.MPawnVillainCopperheadBoss.CanPlayTauntDialogue");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldPlay;
    /// <summary>
    /// Function: ShouldPlay
    /// </summary>
    public unsafe virtual bool ShouldPlay(int probability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldPlay, "BmScript.MPawnVillainCopperheadBoss.ShouldPlay");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(probability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetInstantHeavyDamageAnimset_Player;
    /// <summary>
    /// Function: GetInstantHeavyDamageAnimset_Player
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetInstantHeavyDamageAnimset_Player()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInstantHeavyDamageAnimset_Player, "BmScript.MPawnVillainCopperheadBoss.GetInstantHeavyDamageAnimset_Player");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetInstantHeavyDamageAnimset_Target;
    /// <summary>
    /// Function: GetInstantHeavyDamageAnimset_Target
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetInstantHeavyDamageAnimset_Target()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInstantHeavyDamageAnimset_Target, "BmScript.MPawnVillainCopperheadBoss.GetInstantHeavyDamageAnimset_Target");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetInstantHeavyDamageAnimName;
    /// <summary>
    /// Function: GetInstantHeavyDamageAnimName
    /// </summary>
    public unsafe override BmSDK.FName GetInstantHeavyDamageAnimName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInstantHeavyDamageAnimName, "BmScript.MPawnVillainCopperheadBoss.GetInstantHeavyDamageAnimName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_BossCanTakeGooHit;
    /// <summary>
    /// Function: BossCanTakeGooHit
    /// </summary>
    public unsafe override bool BossCanTakeGooHit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BossCanTakeGooHit, "BmScript.MPawnVillainCopperheadBoss.BossCanTakeGooHit");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DamageCollisionWith;
    /// <summary>
    /// Function: DamageCollisionWith
    /// </summary>
    public unsafe override void DamageCollisionWith(BmSDK.BmGame.RPawnCombat OtherPawn, System.Numerics.Vector3 DamageDir = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamageCollisionWith, "BmScript.MPawnVillainCopperheadBoss.DamageCollisionWith");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageDir, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBeTargettedByPlayer;
    /// <summary>
    /// Function: CanBeTargettedByPlayer
    /// </summary>
    public unsafe override bool CanBeTargettedByPlayer(BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeTargettedByPlayer, "BmScript.MPawnVillainCopperheadBoss.CanBeTargettedByPlayer");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CanReceiveAttackFromPawn;
    /// <summary>
    /// Function: CanReceiveAttackFromPawn
    /// </summary>
    public unsafe override bool CanReceiveAttackFromPawn(BmSDK.BmGame.RPawnCombat NewAttacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanReceiveAttackFromPawn, "BmScript.MPawnVillainCopperheadBoss.CanReceiveAttackFromPawn");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OverrideHarpoonHit;
    /// <summary>
    /// Function: OverrideHarpoonHit
    /// </summary>
    public unsafe override bool OverrideHarpoonHit(BmSDK.BmGame.RPawnPlayer PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideHarpoonHit, "BmScript.MPawnVillainCopperheadBoss.OverrideHarpoonHit");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsVulnerableToStunStrike;
    /// <summary>
    /// Function: IsVulnerableToStunStrike
    /// </summary>
    public unsafe override bool IsVulnerableToStunStrike()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsVulnerableToStunStrike, "BmScript.MPawnVillainCopperheadBoss.IsVulnerableToStunStrike");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsBoss;
    /// <summary>
    /// Function: IsBoss
    /// </summary>
    public unsafe override bool IsBoss()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBoss, "BmScript.MPawnVillainCopperheadBoss.IsBoss");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HitByBatarang;
    /// <summary>
    /// Function: HitByBatarang
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult HitByBatarang(int Damage, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitByBatarang, "BmScript.MPawnVillainCopperheadBoss.HitByBatarang");
        byte* paramsPtr = stackalloc byte[93];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 72);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 76);
    }

    private static BmSDK.Function __fn_CannotBeTakedownViaCounter;
    /// <summary>
    /// Function: CannotBeTakedownViaCounter
    /// </summary>
    public unsafe override bool CannotBeTakedownViaCounter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CannotBeTakedownViaCounter, "BmScript.MPawnVillainCopperheadBoss.CannotBeTakedownViaCounter");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanBeHitInCombat;
    /// <summary>
    /// Function: CanBeHitInCombat
    /// </summary>
    public unsafe override bool CanBeHitInCombat(BmSDK.BmGame.RDamageType DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeHitInCombat, "BmScript.MPawnVillainCopperheadBoss.CanBeHitInCombat");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ShouldMagBlastLockOn;
    /// <summary>
    /// Function: ShouldMagBlastLockOn
    /// </summary>
    public unsafe override bool ShouldMagBlastLockOn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldMagBlastLockOn, "BmScript.MPawnVillainCopperheadBoss.ShouldMagBlastLockOn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTargetPriority;
    /// <summary>
    /// Function: GetTargetPriority
    /// </summary>
    public unsafe override float GetTargetPriority(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargetPriority, "BmScript.MPawnVillainCopperheadBoss.GetTargetPriority");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsBatarangable;
    /// <summary>
    /// Function: IsBatarangable
    /// </summary>
    public unsafe override bool IsBatarangable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBatarangable, "BmScript.MPawnVillainCopperheadBoss.IsBatarangable");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ModifyDamageAmount;
    /// <summary>
    /// Function: ModifyDamageAmount
    /// </summary>
    public unsafe override void ModifyDamageAmount(BmSDK.Class dmgType, out float DmgAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyDamageAmount, "BmScript.MPawnVillainCopperheadBoss.ModifyDamageAmount");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DmgAmount);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgAmount, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DmgAmount = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_SpawnOverrideTakedown;
    /// <summary>
    /// Function: SpawnOverrideTakedown
    /// </summary>
    public unsafe override bool SpawnOverrideTakedown(BmSDK.BmGame.RPawnCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnOverrideTakedown, "BmScript.MPawnVillainCopperheadBoss.SpawnOverrideTakedown");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SpawnChargeAttack;
    /// <summary>
    /// Function: SpawnChargeAttack
    /// </summary>
    public unsafe virtual void SpawnChargeAttack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnChargeAttack, "BmScript.MPawnVillainCopperheadBoss.SpawnChargeAttack");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSandMesh;
    /// <summary>
    /// Function: SetSandMesh
    /// </summary>
    public unsafe virtual void SetSandMesh()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSandMesh, "BmScript.MPawnVillainCopperheadBoss.SetSandMesh");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDefaultMesh;
    /// <summary>
    /// Function: SetDefaultMesh
    /// </summary>
    public unsafe virtual void SetDefaultMesh(bool bPlayPfx = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDefaultMesh, "BmScript.MPawnVillainCopperheadBoss.SetDefaultMesh");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayPfx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCombatMoveExit;
    /// <summary>
    /// Function: OnCombatMoveExit
    /// </summary>
    public unsafe virtual void OnCombatMoveExit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCombatMoveExit, "BmScript.MPawnVillainCopperheadBoss.OnCombatMoveExit");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateWeapon;
    /// <summary>
    /// Function: CreateWeapon
    /// </summary>
    public unsafe override BmSDK.BmGame.RBMWeapon CreateWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateWeapon, "BmScript.MPawnVillainCopperheadBoss.CreateWeapon");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMWeapon>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldForceBeatDownEnd;
    /// <summary>
    /// Function: ShouldForceBeatDownEnd
    /// </summary>
    public unsafe override bool ShouldForceBeatDownEnd()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldForceBeatDownEnd, "BmScript.MPawnVillainCopperheadBoss.ShouldForceBeatDownEnd");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateDestination;
    /// <summary>
    /// Function: UpdateDestination
    /// </summary>
    public unsafe virtual void UpdateDestination(BmSDK.Engine.Actor destActor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateDestination, "BmScript.MPawnVillainCopperheadBoss.UpdateDestination");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(destActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnTeleport;
    /// <summary>
    /// Function: OnTeleport
    /// </summary>
    public unsafe override void OnTeleport(BmSDK.Engine.SeqAct_Teleport Action)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnTeleport, "BmScript.MPawnVillainCopperheadBoss.OnTeleport");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGoodAsDead;
    /// <summary>
    /// Function: SetGoodAsDead
    /// </summary>
    public unsafe override void SetGoodAsDead()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGoodAsDead, "BmScript.MPawnVillainCopperheadBoss.SetGoodAsDead");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHeavyDamageAmount;
    /// <summary>
    /// Function: GetHeavyDamageAmount
    /// </summary>
    public unsafe override float GetHeavyDamageAmount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeavyDamageAmount, "BmScript.MPawnVillainCopperheadBoss.GetHeavyDamageAmount");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DamagedBy;
    /// <summary>
    /// Function: DamagedBy
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult DamagedBy(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamagedBy, "BmScript.MPawnVillainCopperheadBoss.DamagedBy");
        byte* paramsPtr = stackalloc byte[273];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 256);
    }

    private static BmSDK.Function __fn_OverrideCanDodgeProjectile;
    /// <summary>
    /// Function: OverrideCanDodgeProjectile
    /// </summary>
    public unsafe override bool OverrideCanDodgeProjectile(System.Numerics.Vector3 ThrownFromPos, int CheckBatarangID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideCanDodgeProjectile, "BmScript.MPawnVillainCopperheadBoss.OverrideCanDodgeProjectile");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckBatarangID, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_SpecialAttackCompleted;
    /// <summary>
    /// Function: SpecialAttackCompleted
    /// </summary>
    public unsafe virtual void SpecialAttackCompleted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpecialAttackCompleted, "BmScript.MPawnVillainCopperheadBoss.SpecialAttackCompleted");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnVillainAttack;
    /// <summary>
    /// Function: SpawnVillainAttack
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RCombatMove_VillainAttack SpawnVillainAttack(BmSDK.Class AttackClass)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnVillainAttack, "BmScript.MPawnVillainCopperheadBoss.SpawnVillainAttack");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCombatMove_VillainAttack>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SpawnSpecialAttack;
    /// <summary>
    /// Function: SpawnSpecialAttack
    /// </summary>
    public unsafe override bool SpawnSpecialAttack(BmSDK.BmGame.RPawnCombat PlayerPawn, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnSpecialAttack, "BmScript.MPawnVillainCopperheadBoss.SpawnSpecialAttack");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_EndDashAttack;
    /// <summary>
    /// Function: EndDashAttack
    /// </summary>
    public unsafe virtual void EndDashAttack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndDashAttack, "BmScript.MPawnVillainCopperheadBoss.EndDashAttack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeginDashAttack;
    /// <summary>
    /// Function: BeginDashAttack
    /// </summary>
    public unsafe virtual void BeginDashAttack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginDashAttack, "BmScript.MPawnVillainCopperheadBoss.BeginDashAttack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Died;
    /// <summary>
    /// Function: Died
    /// </summary>
    public unsafe override bool Died(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Died, "BmScript.MPawnVillainCopperheadBoss.Died");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_CloseHUD;
    /// <summary>
    /// Function: CloseHUD
    /// </summary>
    public unsafe virtual void CloseHUD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseHUD, "BmScript.MPawnVillainCopperheadBoss.CloseHUD");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitHUD;
    /// <summary>
    /// Function: InitHUD
    /// </summary>
    public unsafe virtual void InitHUD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitHUD, "BmScript.MPawnVillainCopperheadBoss.InitHUD");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TakeDamage;
    /// <summary>
    /// Function: TakeDamage
    /// </summary>
    public unsafe override void TakeDamage(int Damage, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeDamage, "BmScript.MPawnVillainCopperheadBoss.TakeDamage");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 72);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateHealthBar;
    /// <summary>
    /// Function: UpdateHealthBar
    /// </summary>
    public unsafe virtual void UpdateHealthBar()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateHealthBar, "BmScript.MPawnVillainCopperheadBoss.UpdateHealthBar");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostInitCharacter;
    /// <summary>
    /// Function: PostInitCharacter
    /// </summary>
    public unsafe override void PostInitCharacter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostInitCharacter, "BmScript.MPawnVillainCopperheadBoss.PostInitCharacter");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayChargeInSpeech;
    /// <summary>
    /// Function: PlayChargeInSpeech
    /// </summary>
    public unsafe virtual void PlayChargeInSpeech()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayChargeInSpeech, "BmScript.MPawnVillainCopperheadBoss.PlayChargeInSpeech");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TripAnyGooMines;
    /// <summary>
    /// Function: TripAnyGooMines
    /// </summary>
    public unsafe virtual void TripAnyGooMines()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TripAnyGooMines, "BmScript.MPawnVillainCopperheadBoss.TripAnyGooMines");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FAttackPhase
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial record struct FAttackPhase
    {
        /// <summary>
        /// FloatProperty: HealthThreshold
        /// </summary>
        public unsafe float HealthThreshold
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: AuraFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem AuraFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4324); }
    }

    /// <summary>
    /// ObjectProperty: ConstantSandTailFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ConstantSandTailFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4328); }
    }

    /// <summary>
    /// ComponentProperty: AuraFXComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent AuraFXComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4332); }
    }

    /// <summary>
    /// ComponentProperty: ConstantSandTailFxComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ConstantSandTailFxComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4336); }
    }

    /// <summary>
    /// ObjectProperty: PrecursorFxEmitter
    /// </summary>
    public unsafe BmSDK.BmGame.REmitter PrecursorFxEmitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REmitter>(Ptr + 4340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4340); }
    }

    /// <summary>
    /// BoolProperty: bForceBeatdown
    /// </summary>
    public unsafe bool bForceBeatdown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4344) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4344); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4344); }
    }

    /// <summary>
    /// BoolProperty: bIsHideDone
    /// </summary>
    public unsafe bool bIsHideDone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4344) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4344); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4344); }
    }

    /// <summary>
    /// BoolProperty: CanDoDashAttack
    /// </summary>
    public unsafe bool CanDoDashAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4344) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4344); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4344); }
    }

    /// <summary>
    /// BoolProperty: bReachedInitialTeleportLocation
    /// </summary>
    public unsafe bool bReachedInitialTeleportLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4344) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4344); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4344); }
    }

    /// <summary>
    /// BoolProperty: StartMoveTo
    /// </summary>
    public unsafe bool StartMoveTo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4344) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4344); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4344); }
    }

    /// <summary>
    /// BoolProperty: bHasPlayedRetreatBark
    /// </summary>
    public unsafe bool bHasPlayedRetreatBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4344) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4344); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4344); }
    }

    /// <summary>
    /// BoolProperty: CanDoSpecialAttack
    /// </summary>
    public unsafe bool CanDoSpecialAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4344) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4344); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4344); }
    }

    /// <summary>
    /// BoolProperty: bCanTriggerOutroCinematic
    /// </summary>
    public unsafe bool bCanTriggerOutroCinematic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4344) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4344); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4344); }
    }

    /// <summary>
    /// BoolProperty: bWaitingForPlayerToComeOutOfPoison
    /// </summary>
    public unsafe bool bWaitingForPlayerToComeOutOfPoison
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4344) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4344); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4344); }
    }

    /// <summary>
    /// BoolProperty: bGetBatmanOutOfPoisionEffect
    /// </summary>
    public unsafe bool bGetBatmanOutOfPoisionEffect
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4344) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4344); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4344); }
    }

    /// <summary>
    /// BoolProperty: DodgeBoundryActivated
    /// </summary>
    public unsafe bool DodgeBoundryActivated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4344) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4344); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4344); }
    }

    /// <summary>
    /// BoolProperty: bPlayedShimmerSound
    /// </summary>
    public unsafe bool bPlayedShimmerSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4344) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4344); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4344); }
    }

    /// <summary>
    /// NameProperty: DoneHideFunc
    /// </summary>
    public unsafe BmSDK.FName DoneHideFunc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4348); }
    }

    /// <summary>
    /// ComponentProperty: ChargeUpFXComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ChargeUpFXComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4356); }
    }

    /// <summary>
    /// ObjectProperty: CombatBehaviour
    /// </summary>
    public unsafe BmSDK.BmScript.MBMBehaviour_CombatCopperheadBoss CombatBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MBMBehaviour_CombatCopperheadBoss>(Ptr + 4360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4360); }
    }

    /// <summary>
    /// ObjectProperty: ChargeBuildUpFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ChargeBuildUpFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4364); }
    }

    /// <summary>
    /// ObjectProperty: AttackSwordFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem AttackSwordFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4368); }
    }

    /// <summary>
    /// ObjectProperty: AttackSwordHitFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem AttackSwordHitFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4372); }
    }

    /// <summary>
    /// ObjectProperty: ChargingFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ChargingFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4376); }
    }

    /// <summary>
    /// ObjectProperty: PrecursorFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem PrecursorFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4380); }
    }

    /// <summary>
    /// FloatProperty: DamageWhileFinalBlowCam
    /// </summary>
    public unsafe float DamageWhileFinalBlowCam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4384); }
    }

    /// <summary>
    /// ObjectProperty: Batman
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController Batman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 4388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4388); }
    }

    /// <summary>
    /// ObjectProperty: DestinationActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor DestinationActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 4392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4392); }
    }

    /// <summary>
    /// ByteProperty: MoveToSpeed
    /// </summary>
    public unsafe BmSDK.BmGame.RPoseConfig.EMovementSpeed MoveToSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig.EMovementSpeed>(Ptr + 4396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4396); }
    }

    /// <summary>
    /// ObjectProperty: SeqAction
    /// </summary>
    public unsafe BmSDK.Engine.SequenceAction SeqAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SequenceAction>(Ptr + 4400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4400); }
    }

    /// <summary>
    /// FloatProperty: InstantDamageAmount
    /// </summary>
    public unsafe float InstantDamageAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4404); }
    }

    /// <summary>
    /// IntProperty: SpawnSpeechProbability
    /// </summary>
    public unsafe int SpawnSpeechProbability
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4408); }
    }

    /// <summary>
    /// IntProperty: DeathSpeechProbability
    /// </summary>
    public unsafe int DeathSpeechProbability
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4412); }
    }

    /// <summary>
    /// IntProperty: DashSpeechProbability
    /// </summary>
    public unsafe int DashSpeechProbability
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4416); }
    }

    /// <summary>
    /// IntProperty: TauntSpeechProbability
    /// </summary>
    public unsafe int TauntSpeechProbability
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4420); }
    }

    /// <summary>
    /// IntProperty: NumberOfDashAttacks
    /// </summary>
    public unsafe int NumberOfDashAttacks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4424); }
    }

    /// <summary>
    /// ArrayProperty: AttackPhases
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.MPawnVillainCopperheadBoss.FAttackPhase> AttackPhases
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.MPawnVillainCopperheadBoss.FAttackPhase>>(Ptr + 4428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4428); }
    }

    /// <summary>
    /// FloatProperty: StunGrenadeStunTime
    /// </summary>
    public unsafe float StunGrenadeStunTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4440); }
    }

    /// <summary>
    /// FloatProperty: PlayerPoisonLoopTotalTime
    /// </summary>
    public unsafe float PlayerPoisonLoopTotalTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4444); }
    }

    /// <summary>
    /// IntProperty: SingleAttackPriority_WhenAlone
    /// </summary>
    public unsafe int SingleAttackPriority_WhenAlone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4448); }
    }

    /// <summary>
    /// IntProperty: MultiStrikePriority_WhenAlone
    /// </summary>
    public unsafe int MultiStrikePriority_WhenAlone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4452); }
    }

    /// <summary>
    /// IntProperty: GrabAttackPriority_WhenAlone
    /// </summary>
    public unsafe int GrabAttackPriority_WhenAlone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4456); }
    }

    /// <summary>
    /// IntProperty: NoOfDashAttacks
    /// </summary>
    public unsafe int NoOfDashAttacks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4460); }
    }

    /// <summary>
    /// IntProperty: CurrentAttackPhase
    /// </summary>
    public unsafe int CurrentAttackPhase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4464); }
    }

    /// <summary>
    /// StructProperty: CentreArenaLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CentreArenaLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4468);

    /// <summary>
    /// FloatProperty: AllowedDistanceFromCentre
    /// </summary>
    public unsafe float AllowedDistanceFromCentre
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4480); }
    }

    /// <summary>
    /// FloatProperty: timerTestNoBehaviour
    /// </summary>
    public unsafe float timerTestNoBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4484); }
    }
}
