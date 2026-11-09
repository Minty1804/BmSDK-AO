#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RCombatMove_BatmanStrike<br/>
/// (size = 1076)
/// (flags = 142606483)
/// </summary>
public partial class RCombatMove_BatmanStrike : BmSDK.BmGame.RCombatMove_BatmanAttack, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCombatMove_BatmanStrike", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCombatMove_BatmanStrike.
    /// </summary>
    public static RCombatMove_BatmanStrike DefaultObject => (RCombatMove_BatmanStrike)StaticClass().DefaultObject;

    internal RCombatMove_BatmanStrike() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCombatMove_BatmanStrike(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStrike>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStrike>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStrike>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStrike>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStrike>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStrike>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStrike>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStrike>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CanForceSlowStrike;
    /// <summary>
    /// Function: CanForceSlowStrike
    /// </summary>
    public unsafe virtual bool CanForceSlowStrike()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanForceSlowStrike, "BmGame.RCombatMove_BatmanStrike.CanForceSlowStrike");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPerformWeaponDestroy;
    /// <summary>
    /// Function: CanPerformWeaponDestroy
    /// </summary>
    public unsafe override bool CanPerformWeaponDestroy()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformWeaponDestroy, "BmGame.RCombatMove_BatmanStrike.CanPerformWeaponDestroy");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPerformPrimaryGroupMove;
    /// <summary>
    /// Function: CanPerformPrimaryGroupMove
    /// </summary>
    public unsafe override bool CanPerformPrimaryGroupMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformPrimaryGroupMove, "BmGame.RCombatMove_BatmanStrike.CanPerformPrimaryGroupMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPerformTakedownWithStun;
    /// <summary>
    /// Function: CanPerformTakedownWithStun
    /// </summary>
    public unsafe override bool CanPerformTakedownWithStun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformTakedownWithStun, "BmGame.RCombatMove_BatmanStrike.CanPerformTakedownWithStun");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPerformTakedownWithCounter;
    /// <summary>
    /// Function: CanPerformTakedownWithCounter
    /// </summary>
    public unsafe override bool CanPerformTakedownWithCounter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformTakedownWithCounter, "BmGame.RCombatMove_BatmanStrike.CanPerformTakedownWithCounter");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ExitMove;
    /// <summary>
    /// Function: ExitMove
    /// </summary>
    public unsafe override void ExitMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitMove, "BmGame.RCombatMove_BatmanStrike.ExitMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHitReactionLocation;
    /// <summary>
    /// Function: GetHitReactionLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetHitReactionLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHitReactionLocation, "BmGame.RCombatMove_BatmanStrike.GetHitReactionLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHitReactionDirection;
    /// <summary>
    /// Function: GetHitReactionDirection
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetHitReactionDirection(BmSDK.BmGame.RPawnVillain HitPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHitReactionDirection, "BmGame.RCombatMove_BatmanStrike.GetHitReactionDirection");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PostPlayStrike;
    /// <summary>
    /// Function: PostPlayStrike
    /// </summary>
    public unsafe virtual void PostPlayStrike()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostPlayStrike, "BmGame.RCombatMove_BatmanStrike.PostPlayStrike");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartStrikeSwooshSound;
    /// <summary>
    /// Function: StartStrikeSwooshSound
    /// </summary>
    public unsafe virtual void StartStrikeSwooshSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartStrikeSwooshSound, "BmGame.RCombatMove_BatmanStrike.StartStrikeSwooshSound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldTrackTargetThisFrame;
    /// <summary>
    /// Function: ShouldTrackTargetThisFrame
    /// </summary>
    public unsafe virtual bool ShouldTrackTargetThisFrame()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldTrackTargetThisFrame, "BmGame.RCombatMove_BatmanStrike.ShouldTrackTargetThisFrame");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayStrike;
    /// <summary>
    /// Function: PlayStrike
    /// </summary>
    public unsafe virtual void PlayStrike(bool bQueue, bool bSimulated)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayStrike, "BmGame.RCombatMove_BatmanStrike.PlayStrike");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bQueue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSimulated, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayedQueuedStrikeAnimSimulated;
    /// <summary>
    /// Function: PlayedQueuedStrikeAnimSimulated
    /// </summary>
    public unsafe virtual void PlayedQueuedStrikeAnimSimulated(BmSDK.BmGame.RAnimUtil.FTransitionId QueuedAnimID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayedQueuedStrikeAnimSimulated, "BmGame.RCombatMove_BatmanStrike.PlayedQueuedStrikeAnimSimulated");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QueuedAnimID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayedQueuedStrikeAnim;
    /// <summary>
    /// Function: PlayedQueuedStrikeAnim
    /// </summary>
    public unsafe virtual void PlayedQueuedStrikeAnim(BmSDK.BmGame.RAnimUtil.FTransitionId QueuedAnimID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayedQueuedStrikeAnim, "BmGame.RCombatMove_BatmanStrike.PlayedQueuedStrikeAnim");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QueuedAnimID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetStrikeAnimSet;
    /// <summary>
    /// Function: GetStrikeAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetStrikeAnimSet()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeAnimSet, "BmGame.RCombatMove_BatmanStrike.GetStrikeAnimSet");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PreventedWalkingOverLedge;
    /// <summary>
    /// Function: PreventedWalkingOverLedge
    /// </summary>
    public unsafe override void PreventedWalkingOverLedge(BmSDK.BmGame.RPawnCombat PawnAtLedge)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreventedWalkingOverLedge, "BmGame.RCombatMove_BatmanStrike.PreventedWalkingOverLedge");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnAtLedge, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetStrikeDurationScale;
    /// <summary>
    /// Function: GetStrikeDurationScale
    /// </summary>
    public unsafe virtual float GetStrikeDurationScale()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeDurationScale, "BmGame.RCombatMove_BatmanStrike.GetStrikeDurationScale");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStrikeTargetLocation;
    /// <summary>
    /// Function: GetStrikeTargetLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetStrikeTargetLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeTargetLocation, "BmGame.RCombatMove_BatmanStrike.GetStrikeTargetLocation");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopCapeAnim;
    /// <summary>
    /// Function: StopCapeAnim
    /// </summary>
    public unsafe virtual void StopCapeAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopCapeAnim, "BmGame.RCombatMove_BatmanStrike.StopCapeAnim");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayCapeAnim;
    /// <summary>
    /// Function: PlayCapeAnim
    /// </summary>
    public unsafe virtual void PlayCapeAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCapeAnim, "BmGame.RCombatMove_BatmanStrike.PlayCapeAnim");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTrailPS;
    /// <summary>
    /// Function: GetTrailPS
    /// </summary>
    public unsafe virtual BmSDK.Engine.ParticleSystem GetTrailPS()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTrailPS, "BmGame.RCombatMove_BatmanStrike.GetTrailPS");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.ParticleSystem>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopTrail;
    /// <summary>
    /// Function: StopTrail
    /// </summary>
    public unsafe virtual void StopTrail()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopTrail, "BmGame.RCombatMove_BatmanStrike.StopTrail");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartTrail;
    /// <summary>
    /// Function: StartTrail
    /// </summary>
    public unsafe virtual void StartTrail()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartTrail, "BmGame.RCombatMove_BatmanStrike.StartTrail");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetImpactPS;
    /// <summary>
    /// Function: GetImpactPS
    /// </summary>
    public unsafe virtual BmSDK.Engine.ParticleSystem GetImpactPS(BmSDK.BmGame.RPawnCombat.DamageResult DmgResult, BmSDK.BmGame.RPawnCombat HitPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetImpactPS, "BmGame.RCombatMove_BatmanStrike.GetImpactPS");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgResult, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPawn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.ParticleSystem>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SpawnHitParticles;
    /// <summary>
    /// Function: SpawnHitParticles
    /// </summary>
    public unsafe virtual void SpawnHitParticles(BmSDK.BmGame.RPawnCombat.DamageResult DmgResult, BmSDK.BmGame.RPawnCombat HitPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnHitParticles, "BmGame.RCombatMove_BatmanStrike.SpawnHitParticles");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgResult, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPawn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayBlockedFX;
    /// <summary>
    /// Function: PlayBlockedFX
    /// </summary>
    public unsafe virtual void PlayBlockedFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayBlockedFX, "BmGame.RCombatMove_BatmanStrike.PlayBlockedFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayHitFX;
    /// <summary>
    /// Function: PlayHitFX
    /// </summary>
    public unsafe virtual void PlayHitFX(float FXScale)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHitFX, "BmGame.RCombatMove_BatmanStrike.PlayHitFX");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FXScale, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessDamageResult;
    /// <summary>
    /// Function: ProcessDamageResult
    /// </summary>
    public unsafe virtual void ProcessDamageResult(BmSDK.BmGame.RPawnCombat.DamageResult DmgResult, BmSDK.BmGame.RPawnCombat DamageReceiver)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessDamageResult, "BmGame.RCombatMove_BatmanStrike.ProcessDamageResult");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgResult, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoHitPawnSimulated;
    /// <summary>
    /// Function: DoHitPawnSimulated
    /// </summary>
    public unsafe virtual void DoHitPawnSimulated(BmSDK.BmGame.RPawnCombat DamageReceiver, float DmgAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoHitPawnSimulated, "BmGame.RCombatMove_BatmanStrike.DoHitPawnSimulated");
        byte* paramsPtr = stackalloc byte[304];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgAmount, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoHitPawn;
    /// <summary>
    /// Function: DoHitPawn
    /// </summary>
    public unsafe virtual void DoHitPawn(BmSDK.BmGame.RPawnCombat DamageReceiver)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoHitPawn, "BmGame.RCombatMove_BatmanStrike.DoHitPawn");
        byte* paramsPtr = stackalloc byte[45];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayImpactSound;
    /// <summary>
    /// Function: PlayImpactSound
    /// </summary>
    public unsafe virtual void PlayImpactSound(BmSDK.BmGame.RPawnCombat DamageReceiver, BmSDK.BmGame.RPawnCombat.DamageResult DmgResult)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayImpactSound, "BmGame.RCombatMove_BatmanStrike.PlayImpactSound");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgResult, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayFirstHitSound;
    /// <summary>
    /// Function: PlayFirstHitSound
    /// </summary>
    public unsafe virtual void PlayFirstHitSound(BmSDK.BmGame.RPawnCombat DamageReceiver)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFirstHitSound, "BmGame.RCombatMove_BatmanStrike.PlayFirstHitSound");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DamagePawn;
    /// <summary>
    /// Function: DamagePawn
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat.DamageResult DamagePawn(BmSDK.BmGame.RPawnCombat DamageReceiver)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamagePawn, "BmGame.RCombatMove_BatmanStrike.DamagePawn");
        byte* paramsPtr = stackalloc byte[292];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetDamageInfo;
    /// <summary>
    /// Function: SetDamageInfo
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat.FDamageInfo SetDamageInfo(BmSDK.BmGame.RPawnCombat DamageReceiver, float DmgAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDamageInfo, "BmGame.RCombatMove_BatmanStrike.SetDamageInfo");
        byte* paramsPtr = stackalloc byte[540];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgAmount, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.FDamageInfo>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ShouldIncCombo;
    /// <summary>
    /// Function: ShouldIncCombo
    /// </summary>
    public unsafe virtual bool ShouldIncCombo(out int ComboIncrease, out int SpecialMoveCountIncrease)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldIncCombo, "BmGame.RCombatMove_BatmanStrike.ShouldIncCombo");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ComboIncrease);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboIncrease, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SpecialMoveCountIncrease);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecialMoveCountIncrease, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ComboIncrease = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        SpecialMoveCountIncrease = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetComboIncrease;
    /// <summary>
    /// Function: GetComboIncrease
    /// </summary>
    public unsafe virtual void GetComboIncrease(out int ComboIncrease, out int SpecialMoveCountIncrease)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetComboIncrease, "BmGame.RCombatMove_BatmanStrike.GetComboIncrease");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ComboIncrease);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboIncrease, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SpecialMoveCountIncrease);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecialMoveCountIncrease, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ComboIncrease = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        SpecialMoveCountIncrease = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_NotifyDeathCutsceneOfStrike;
    /// <summary>
    /// Function: NotifyDeathCutsceneOfStrike
    /// </summary>
    public unsafe virtual void NotifyDeathCutsceneOfStrike()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyDeathCutsceneOfStrike, "BmGame.RCombatMove_BatmanStrike.NotifyDeathCutsceneOfStrike");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDamageAmount;
    /// <summary>
    /// Function: GetDamageAmount
    /// </summary>
    public unsafe virtual float GetDamageAmount(BmSDK.BmGame.RPawnCombat DamageReceiver)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamageAmount, "BmGame.RCombatMove_BatmanStrike.GetDamageAmount");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UpdateTargetAnimForFinalBlow;
    /// <summary>
    /// Function: UpdateTargetAnimForFinalBlow
    /// </summary>
    public unsafe virtual void UpdateTargetAnimForFinalBlow()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateTargetAnimForFinalBlow, "BmGame.RCombatMove_BatmanStrike.UpdateTargetAnimForFinalBlow");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateSlowMo;
    /// <summary>
    /// Function: UpdateSlowMo
    /// </summary>
    public unsafe virtual void UpdateSlowMo(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateSlowMo, "BmGame.RCombatMove_BatmanStrike.UpdateSlowMo");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetStartFinalBlowTime;
    /// <summary>
    /// Function: GetStartFinalBlowTime
    /// </summary>
    public unsafe virtual float GetStartFinalBlowTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStartFinalBlowTime, "BmGame.RCombatMove_BatmanStrike.GetStartFinalBlowTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetEndSlowMoTime;
    /// <summary>
    /// Function: GetEndSlowMoTime
    /// </summary>
    public unsafe virtual float GetEndSlowMoTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEndSlowMoTime, "BmGame.RCombatMove_BatmanStrike.GetEndSlowMoTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStartSlowMoTime;
    /// <summary>
    /// Function: GetStartSlowMoTime
    /// </summary>
    public unsafe virtual float GetStartSlowMoTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStartSlowMoTime, "BmGame.RCombatMove_BatmanStrike.GetStartSlowMoTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopSlowMo;
    /// <summary>
    /// Function: StopSlowMo
    /// </summary>
    public unsafe virtual void StopSlowMo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopSlowMo, "BmGame.RCombatMove_BatmanStrike.StopSlowMo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldSlowMo;
    /// <summary>
    /// Function: ShouldSlowMo
    /// </summary>
    public unsafe virtual bool ShouldSlowMo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldSlowMo, "BmGame.RCombatMove_BatmanStrike.ShouldSlowMo");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsSliding;
    /// <summary>
    /// Function: IsSliding
    /// </summary>
    public unsafe virtual bool IsSliding()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSliding, "BmGame.RCombatMove_BatmanStrike.IsSliding");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHitImpactForce;
    /// <summary>
    /// Function: GetHitImpactForce
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetHitImpactForce(BmSDK.BmGame.RPawnCombat HitPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHitImpactForce, "BmGame.RCombatMove_BatmanStrike.GetHitImpactForce");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDamageDirection;
    /// <summary>
    /// Function: GetDamageDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetDamageDirection(BmSDK.BmGame.RPawnCombat HitPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamageDirection, "BmGame.RCombatMove_BatmanStrike.GetDamageDirection");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDamagePower;
    /// <summary>
    /// Function: GetDamagePower
    /// </summary>
    public unsafe virtual float GetDamagePower()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamagePower, "BmGame.RCombatMove_BatmanStrike.GetDamagePower");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDamageCollisionProjection;
    /// <summary>
    /// Function: GetDamageCollisionProjection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetDamageCollisionProjection()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamageCollisionProjection, "BmGame.RCombatMove_BatmanStrike.GetDamageCollisionProjection");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDamageCollisionRadius;
    /// <summary>
    /// Function: GetDamageCollisionRadius
    /// </summary>
    public unsafe virtual float GetDamageCollisionRadius()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamageCollisionRadius, "BmGame.RCombatMove_BatmanStrike.GetDamageCollisionRadius");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHitBone;
    /// <summary>
    /// Function: GetHitBone
    /// </summary>
    public unsafe virtual BmSDK.FName GetHitBone()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHitBone, "BmGame.RCombatMove_BatmanStrike.GetHitBone");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDamageBone;
    /// <summary>
    /// Function: GetDamageBone
    /// </summary>
    public unsafe virtual BmSDK.FName GetDamageBone()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamageBone, "BmGame.RCombatMove_BatmanStrike.GetDamageBone");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetImpactBoneEnum;
    /// <summary>
    /// Function: GetImpactBoneEnum
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat.BoneNameList GetImpactBoneEnum()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetImpactBoneEnum, "BmGame.RCombatMove_BatmanStrike.GetImpactBoneEnum");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.BoneNameList>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDamageBoneEnum;
    /// <summary>
    /// Function: GetDamageBoneEnum
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat.BoneNameList GetDamageBoneEnum()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamageBoneEnum, "BmGame.RCombatMove_BatmanStrike.GetDamageBoneEnum");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.BoneNameList>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetValidTargetStrikeRange;
    /// <summary>
    /// Function: GetValidTargetStrikeRange
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnPlayerCombat.StrikeRange GetValidTargetStrikeRange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetValidTargetStrikeRange, "BmGame.RCombatMove_BatmanStrike.GetValidTargetStrikeRange");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayerCombat.StrikeRange>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStrikeAnim;
    /// <summary>
    /// Function: GetStrikeAnim
    /// </summary>
    public unsafe virtual BmSDK.FName GetStrikeAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeAnim, "BmGame.RCombatMove_BatmanStrike.GetStrikeAnim");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStrikeTimeUntilImpact;
    /// <summary>
    /// Function: GetStrikeTimeUntilImpact
    /// </summary>
    public unsafe virtual float GetStrikeTimeUntilImpact()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeTimeUntilImpact, "BmGame.RCombatMove_BatmanStrike.GetStrikeTimeUntilImpact");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanBeStruckBy;
    /// <summary>
    /// Function: CanBeStruckBy
    /// </summary>
    public unsafe override bool CanBeStruckBy(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.BmGame.RPawnCombat Defender)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeStruckBy, "BmGame.RCombatMove_BatmanStrike.CanBeStruckBy");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Defender, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanPerformNextComboMove;
    /// <summary>
    /// Function: CanPerformNextComboMove
    /// </summary>
    public unsafe override bool CanPerformNextComboMove(bool bSpecialMove = default, bool bStrike = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformNextComboMove, "BmGame.RCombatMove_BatmanStrike.CanPerformNextComboMove");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpecialMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStrike, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_DisallowEarlyExit;
    /// <summary>
    /// Function: DisallowEarlyExit
    /// </summary>
    public unsafe virtual void DisallowEarlyExit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisallowEarlyExit, "BmGame.RCombatMove_BatmanStrike.DisallowEarlyExit");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowEarlyExit;
    /// <summary>
    /// Function: AllowEarlyExit
    /// </summary>
    public unsafe virtual void AllowEarlyExit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowEarlyExit, "BmGame.RCombatMove_BatmanStrike.AllowEarlyExit");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowMovementExit;
    /// <summary>
    /// Function: AllowMovementExit
    /// </summary>
    public unsafe override void AllowMovementExit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowMovementExit, "BmGame.RCombatMove_BatmanStrike.AllowMovementExit");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BotTryNextStrike;
    /// <summary>
    /// Function: BotTryNextStrike
    /// </summary>
    public unsafe virtual void BotTryNextStrike()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BotTryNextStrike, "BmGame.RCombatMove_BatmanStrike.BotTryNextStrike");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowNextNonStrikeMove;
    /// <summary>
    /// Function: AllowNextNonStrikeMove
    /// </summary>
    public unsafe virtual void AllowNextNonStrikeMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowNextNonStrikeMove, "BmGame.RCombatMove_BatmanStrike.AllowNextNonStrikeMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowNextStrike;
    /// <summary>
    /// Function: AllowNextStrike
    /// </summary>
    public unsafe override void AllowNextStrike()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowNextStrike, "BmGame.RCombatMove_BatmanStrike.AllowNextStrike");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableMotionBlur;
    /// <summary>
    /// Function: DisableMotionBlur
    /// </summary>
    public unsafe virtual void DisableMotionBlur()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableMotionBlur, "BmGame.RCombatMove_BatmanStrike.DisableMotionBlur");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableMotionBlur;
    /// <summary>
    /// Function: EnableMotionBlur
    /// </summary>
    public unsafe virtual void EnableMotionBlur()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableMotionBlur, "BmGame.RCombatMove_BatmanStrike.EnableMotionBlur");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DamageCollisionDeactivated;
    /// <summary>
    /// Function: DamageCollisionDeactivated
    /// </summary>
    public unsafe virtual void DamageCollisionDeactivated()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamageCollisionDeactivated, "BmGame.RCombatMove_BatmanStrike.DamageCollisionDeactivated");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceHitTarget;
    /// <summary>
    /// Function: ForceHitTarget
    /// </summary>
    public unsafe virtual void ForceHitTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceHitTarget, "BmGame.RCombatMove_BatmanStrike.ForceHitTarget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCurrentTarget;
    /// <summary>
    /// Function: GetCurrentTarget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain GetCurrentTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentTarget, "BmGame.RCombatMove_BatmanStrike.GetCurrentTarget");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnVillain>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StartPreImpact;
    /// <summary>
    /// Function: StartPreImpact
    /// </summary>
    public unsafe virtual void StartPreImpact()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartPreImpact, "BmGame.RCombatMove_BatmanStrike.StartPreImpact");
        byte* paramsPtr = stackalloc byte[273];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartImpact;
    /// <summary>
    /// Function: StartImpact
    /// </summary>
    public unsafe virtual void StartImpact()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartImpact, "BmGame.RCombatMove_BatmanStrike.StartImpact");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StrikeContact;
    /// <summary>
    /// Function: StrikeContact
    /// </summary>
    public unsafe override void StrikeContact(bool bPreStrike)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StrikeContact, "BmGame.RCombatMove_BatmanStrike.StrikeContact");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPreStrike, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatAnimHit;
    /// <summary>
    /// Function: CombatAnimHit
    /// </summary>
    public unsafe virtual void CombatAnimHit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatAnimHit, "BmGame.RCombatMove_BatmanStrike.CombatAnimHit");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoToNormalizedTimeIfThereIsNoCombatTarget;
    /// <summary>
    /// Function: GotoToNormalizedTimeIfThereIsNoCombatTarget
    /// </summary>
    public unsafe override void GotoToNormalizedTimeIfThereIsNoCombatTarget(float NomalizedTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoToNormalizedTimeIfThereIsNoCombatTarget, "BmGame.RCombatMove_BatmanStrike.GotoToNormalizedTimeIfThereIsNoCombatTarget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NomalizedTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoToNormalizedTimeIfNotFinalBlow;
    /// <summary>
    /// Function: GotoToNormalizedTimeIfNotFinalBlow
    /// </summary>
    public unsafe override void GotoToNormalizedTimeIfNotFinalBlow(float NomalizedTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoToNormalizedTimeIfNotFinalBlow, "BmGame.RCombatMove_BatmanStrike.GotoToNormalizedTimeIfNotFinalBlow");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NomalizedTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldStartFinalBlowCam;
    /// <summary>
    /// Function: ShouldStartFinalBlowCam
    /// </summary>
    public unsafe virtual bool ShouldStartFinalBlowCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldStartFinalBlowCam, "BmGame.RCombatMove_BatmanStrike.ShouldStartFinalBlowCam");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DoCameraAssistance;
    /// <summary>
    /// Function: DoCameraAssistance
    /// </summary>
    public unsafe override bool DoCameraAssistance(float delayTime = default, bool bCheckTarget = default, System.Numerics.Vector3 TestOffset = default, BmSDK.BmGame.RGameInfo.CameraLookAtSpeed LookAtSpeed = default, BmSDK.Engine.Actor ForceTarget = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoCameraAssistance, "BmGame.RCombatMove_BatmanStrike.DoCameraAssistance");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(delayTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheckTarget, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestOffset, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookAtSpeed, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceTarget, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_HaveClearPathToTarget;
    /// <summary>
    /// Function: HaveClearPathToTarget
    /// </summary>
    public unsafe virtual bool HaveClearPathToTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HaveClearPathToTarget, "BmGame.RCombatMove_BatmanStrike.HaveClearPathToTarget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GotoFirstState;
    /// <summary>
    /// Function: GotoFirstState
    /// </summary>
    public unsafe virtual void GotoFirstState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoFirstState, "BmGame.RCombatMove_BatmanStrike.GotoFirstState");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NoTargetClearCombo;
    /// <summary>
    /// Function: NoTargetClearCombo
    /// </summary>
    public unsafe virtual void NoTargetClearCombo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NoTargetClearCombo, "BmGame.RCombatMove_BatmanStrike.NoTargetClearCombo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterNoTarget;
    /// <summary>
    /// Function: RegisterNoTarget
    /// </summary>
    public unsafe virtual void RegisterNoTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterNoTarget, "BmGame.RCombatMove_BatmanStrike.RegisterNoTarget");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartTargetBuffering;
    /// <summary>
    /// Function: StartTargetBuffering
    /// </summary>
    public unsafe virtual void StartTargetBuffering()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartTargetBuffering, "BmGame.RCombatMove_BatmanStrike.StartTargetBuffering");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitTargetMove;
    /// <summary>
    /// Function: InitTargetMove
    /// </summary>
    public unsafe virtual void InitTargetMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitTargetMove, "BmGame.RCombatMove_BatmanStrike.InitTargetMove");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Initialise;
    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe override void Initialise()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialise, "BmGame.RCombatMove_BatmanStrike.Initialise");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldSetEnvironmentalInfo;
    /// <summary>
    /// Function: ShouldSetEnvironmentalInfo
    /// </summary>
    public unsafe virtual bool ShouldSetEnvironmentalInfo(BmSDK.BmGame.RPawnPlayerCombat.StrikeStrength Strength)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldSetEnvironmentalInfo, "BmGame.RCombatMove_BatmanStrike.ShouldSetEnvironmentalInfo");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Strength, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TryToFindTarget;
    /// <summary>
    /// Function: TryToFindTarget
    /// </summary>
    public unsafe virtual void TryToFindTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToFindTarget, "BmGame.RCombatMove_BatmanStrike.TryToFindTarget");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsFinalBlow;
    /// <summary>
    /// Function: IsFinalBlow
    /// </summary>
    public unsafe override bool IsFinalBlow()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFinalBlow, "BmGame.RCombatMove_BatmanStrike.IsFinalBlow");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetNoTargetDir;
    /// <summary>
    /// Function: SetNoTargetDir
    /// </summary>
    public unsafe virtual void SetNoTargetDir()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNoTargetDir, "BmGame.RCombatMove_BatmanStrike.SetNoTargetDir");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Reset;
    /// <summary>
    /// Function: Reset
    /// </summary>
    public unsafe override void Reset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Reset, "BmGame.RCombatMove_BatmanStrike.Reset");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetEnvironmentInfo;
    /// <summary>
    /// Function: SetEnvironmentInfo
    /// </summary>
    public unsafe virtual void SetEnvironmentInfo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEnvironmentInfo, "BmGame.RCombatMove_BatmanStrike.SetEnvironmentInfo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_CanHitPawn;
    /// <summary>
    /// Function: CanHitPawn
    /// </summary>
    public unsafe virtual bool CanHitPawn(BmSDK.BmGame.RPawnCombat TargetPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanHitPawn, "BmGame.RCombatMove_BatmanStrike.CanHitPawn");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetScoreForStrikeTurnMotion;
    /// <summary>
    /// Function: GetScoreForStrikeTurnMotion
    /// </summary>
    public unsafe virtual int GetScoreForStrikeTurnMotion(BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo TestStrike)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScoreForStrikeTurnMotion, "BmGame.RCombatMove_BatmanStrike.GetScoreForStrikeTurnMotion");
        byte* paramsPtr = stackalloc byte[144];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestStrike, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 124);
    }

    private static BmSDK.Function __fn_GetScoreForStrikeSpeed;
    /// <summary>
    /// Function: GetScoreForStrikeSpeed
    /// </summary>
    public unsafe virtual int GetScoreForStrikeSpeed(BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo TestStrike)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScoreForStrikeSpeed, "BmGame.RCombatMove_BatmanStrike.GetScoreForStrikeSpeed");
        byte* paramsPtr = stackalloc byte[144];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestStrike, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 124);
    }

    private static BmSDK.Function __fn_GetScoreForTimeSinceUse;
    /// <summary>
    /// Function: GetScoreForTimeSinceUse
    /// </summary>
    public unsafe virtual int GetScoreForTimeSinceUse(BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo TestStrike)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScoreForTimeSinceUse, "BmGame.RCombatMove_BatmanStrike.GetScoreForTimeSinceUse");
        byte* paramsPtr = stackalloc byte[144];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestStrike, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 124);
    }

    private static BmSDK.Function __fn_GetScoreForStrikeDir;
    /// <summary>
    /// Function: GetScoreForStrikeDir
    /// </summary>
    public unsafe virtual int GetScoreForStrikeDir(BmSDK.BmGame.RPawnPlayerCombat.StrikeDirection TestDir, BmSDK.BmGame.RPawnPlayerCombat.StrikeDirection DesDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScoreForStrikeDir, "BmGame.RCombatMove_BatmanStrike.GetScoreForStrikeDir");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestDir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesDir, paramsPtr + 1);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetScoreForStrikeRange;
    /// <summary>
    /// Function: GetScoreForStrikeRange
    /// </summary>
    public unsafe virtual int GetScoreForStrikeRange(BmSDK.BmGame.RPawnPlayerCombat.StrikeRange TestRange, BmSDK.BmGame.RPawnPlayerCombat.StrikeRange DesRange)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScoreForStrikeRange, "BmGame.RCombatMove_BatmanStrike.GetScoreForStrikeRange");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestRange, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesRange, paramsPtr + 1);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetScoreForHandedness;
    /// <summary>
    /// Function: GetScoreForHandedness
    /// </summary>
    public unsafe virtual int GetScoreForHandedness(BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo TestStrike)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetScoreForHandedness, "BmGame.RCombatMove_BatmanStrike.GetScoreForHandedness");
        byte* paramsPtr = stackalloc byte[144];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestStrike, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 124);
    }

    private static BmSDK.Function __fn_GetStrikeInfoScore;
    /// <summary>
    /// Function: GetStrikeInfoScore
    /// </summary>
    public unsafe virtual int GetStrikeInfoScore(BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo TestStrike, BmSDK.BmGame.RPawnPlayerCombat.StrikeDirection StrikeDir, BmSDK.BmGame.RPawnPlayerCombat.StrikeStrength StrikeStrength, BmSDK.BmGame.RPawnPlayerCombat.StrikeRange StrikeRange, bool bCanTravelBeyondTarget, bool bIsPoseMirrored)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeInfoScore, "BmGame.RCombatMove_BatmanStrike.GetStrikeInfoScore");
        byte* paramsPtr = stackalloc byte[156];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestStrike, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeDir, paramsPtr + 124);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeStrength, paramsPtr + 125);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeRange, paramsPtr + 126);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanTravelBeyondTarget, paramsPtr + 128);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsPoseMirrored, paramsPtr + 132);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 136);
    }

    private static BmSDK.Function __fn_SetStrikeInfo;
    /// <summary>
    /// Function: SetStrikeInfo
    /// </summary>
    public unsafe virtual int SetStrikeInfo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetStrikeInfo, "BmGame.RCombatMove_BatmanStrike.SetStrikeInfo");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    /// <summary>
    /// ClassProperty: StrikeDmgType
    /// </summary>
    public unsafe BmSDK.Class StrikeDmgType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// StructProperty: TargetDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TargetDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 520);

    /// <summary>
    /// ObjectProperty: PrevTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain PrevTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// BoolProperty: bTargetSet
    /// </summary>
    public unsafe bool bTargetSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 536); }
    }

    /// <summary>
    /// BoolProperty: bQueuedStrike
    /// </summary>
    public unsafe bool bQueuedStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 536); }
    }

    /// <summary>
    /// BoolProperty: bDisallowEarlyExit
    /// </summary>
    public unsafe bool bDisallowEarlyExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 536); }
    }

    /// <summary>
    /// BoolProperty: bIncreasedCombo
    /// </summary>
    public unsafe bool bIncreasedCombo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 536); }
    }

    /// <summary>
    /// BoolProperty: bCanBeStruck
    /// </summary>
    public unsafe bool bCanBeStruck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 536); }
    }

    /// <summary>
    /// BoolProperty: bCanStartNextNonStrikeMove
    /// </summary>
    public unsafe bool bCanStartNextNonStrikeMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 536); }
    }

    /// <summary>
    /// BoolProperty: bSlowMo
    /// </summary>
    public unsafe bool bSlowMo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 536); }
    }

    /// <summary>
    /// BoolProperty: bFinalBlow
    /// </summary>
    public unsafe bool bFinalBlow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 536); }
    }

    /// <summary>
    /// BoolProperty: bSpawnFinalBlowCam
    /// </summary>
    public unsafe bool bSpawnFinalBlowCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 536); }
    }

    /// <summary>
    /// BoolProperty: bFinalBlowSpawned
    /// </summary>
    public unsafe bool bFinalBlowSpawned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 536); }
    }

    /// <summary>
    /// BoolProperty: bSpawnFinalBlowNextFrame
    /// </summary>
    public unsafe bool bSpawnFinalBlowNextFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 536); }
    }

    /// <summary>
    /// BoolProperty: bOverrideTargetStrike
    /// </summary>
    public unsafe bool bOverrideTargetStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 536); }
    }

    /// <summary>
    /// BoolProperty: bForceQuickStrike
    /// </summary>
    public unsafe bool bForceQuickStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 536); }
    }

    /// <summary>
    /// BoolProperty: bForceSlowStrike
    /// </summary>
    public unsafe bool bForceSlowStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 536); }
    }

    /// <summary>
    /// BoolProperty: bPreStrikeHit
    /// </summary>
    public unsafe bool bPreStrikeHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 536); }
    }

    /// <summary>
    /// BoolProperty: bNotifiedDeathCutscene
    /// </summary>
    public unsafe bool bNotifiedDeathCutscene
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 536); }
    }

    /// <summary>
    /// BoolProperty: bDoSlowMo
    /// </summary>
    public unsafe bool bDoSlowMo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 536); }
    }

    /// <summary>
    /// BoolProperty: bDoSlowMoSFX
    /// </summary>
    public unsafe bool bDoSlowMoSFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 536); }
    }

    /// <summary>
    /// BoolProperty: bUseStrikeGadget
    /// </summary>
    public unsafe bool bUseStrikeGadget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 536); }
    }

    /// <summary>
    /// BoolProperty: bBatmanIsInRelativeTransition
    /// </summary>
    public unsafe bool bBatmanIsInRelativeTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 536); }
    }

    /// <summary>
    /// BoolProperty: bEnvMove
    /// </summary>
    public unsafe bool bEnvMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 536); }
    }

    /// <summary>
    /// BoolProperty: bCanShowTutorial
    /// </summary>
    public unsafe bool bCanShowTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 536); }
    }

    /// <summary>
    /// FloatProperty: SlowMoTimer
    /// </summary>
    public unsafe float SlowMoTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// ByteProperty: TargetResponse
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat.TargetStrikeResponse TargetResponse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.TargetStrikeResponse>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// FloatProperty: StrikeDamageAmount
    /// </summary>
    public unsafe float StrikeDamageAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// ArrayProperty: HitTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> HitTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// StructProperty: ImpactScreenShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ImpactScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 564);

    /// <summary>
    /// StructProperty: StrikeInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo StrikeInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo>(Ptr + 708);

    /// <summary>
    /// StructProperty: PrevStrikeInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo PrevStrikeInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo>(Ptr + 832);

    /// <summary>
    /// FloatProperty: StrikeContactTime
    /// </summary>
    public unsafe float StrikeContactTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// ComponentProperty: StrikeTrail
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent StrikeTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// StructProperty: BatmanStrikeID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId BatmanStrikeID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 964);

    /// <summary>
    /// ObjectProperty: StrikeAnimSequence
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence StrikeAnimSequence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// FloatProperty: StunRadius
    /// </summary>
    public unsafe float StunRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// FloatProperty: ChapterNumber
    /// </summary>
    public unsafe float ChapterNumber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// IntProperty: ComboLevel
    /// </summary>
    public unsafe int ComboLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// StructProperty: TargetHitReactionLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TargetHitReactionLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 984);

    /// <summary>
    /// NameProperty: ForceStrikeByName
    /// </summary>
    public unsafe BmSDK.FName ForceStrikeByName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// StructProperty: EnvMoveLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EnvMoveLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1004);

    /// <summary>
    /// StructProperty: EnvMoveNormal
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EnvMoveNormal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1016);

    /// <summary>
    /// IntProperty: CapeStateChangeIndex
    /// </summary>
    public unsafe int CapeStateChangeIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// IntProperty: ThirdTimeSinceUseThresh
    /// </summary>
    public unsafe int ThirdTimeSinceUseThresh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// IntProperty: SecondTimeSinceUseThresh
    /// </summary>
    public unsafe int SecondTimeSinceUseThresh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// IntProperty: FirstTimeSinceUseThresh
    /// </summary>
    public unsafe int FirstTimeSinceUseThresh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// IntProperty: ThirdTimeSinceUseScore
    /// </summary>
    public unsafe int ThirdTimeSinceUseScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// IntProperty: SecondTimeSinceUseScore
    /// </summary>
    public unsafe int SecondTimeSinceUseScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// IntProperty: FirstTimeSinceUseScore
    /// </summary>
    public unsafe int FirstTimeSinceUseScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// IntProperty: CorrectRangeScore
    /// </summary>
    public unsafe int CorrectRangeScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// IntProperty: iTargetBufferingFramesLeft
    /// </summary>
    public unsafe int iTargetBufferingFramesLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// StructProperty: PrevTargetDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PrevTargetDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1064);
}
