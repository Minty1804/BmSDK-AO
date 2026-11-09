#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCombatMove_BatmanCounter<br/>
/// (size = 928)
/// (flags = 142606486)
/// </summary>
public partial class RCombatMove_BatmanCounter : BmSDK.BmGame.RCombatMove_BatmanWeaponAttack, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCombatMove_BatmanCounter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCombatMove_BatmanCounter.
    /// </summary>
    public static RCombatMove_BatmanCounter DefaultObject => (RCombatMove_BatmanCounter)StaticClass().DefaultObject;

    internal RCombatMove_BatmanCounter() { }

    /// <summary>
    /// Constructs a new RCombatMove_BatmanCounter
    /// </summary>
    public RCombatMove_BatmanCounter(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCombatMove_BatmanCounter(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanCounter>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanCounter>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanCounter>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanCounter>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanCounter>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanCounter>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanCounter>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanCounter>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetOverrideTarget;
    /// <summary>
    /// Function: GetOverrideTarget
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat GetOverrideTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOverrideTarget, "BmGame.RCombatMove_BatmanCounter.GetOverrideTarget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanBeTargettedByPlayer;
    /// <summary>
    /// Function: CanBeTargettedByPlayer
    /// </summary>
    public unsafe override bool CanBeTargettedByPlayer(BmSDK.BmGame.RPawnCombat TestPawn, BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeTargettedByPlayer, "BmGame.RCombatMove_BatmanCounter.CanBeTargettedByPlayer");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanPerformWeaponDestroy;
    /// <summary>
    /// Function: CanPerformWeaponDestroy
    /// </summary>
    public unsafe override bool CanPerformWeaponDestroy()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformWeaponDestroy, "BmGame.RCombatMove_BatmanCounter.CanPerformWeaponDestroy");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformTakedownWithStun, "BmGame.RCombatMove_BatmanCounter.CanPerformTakedownWithStun");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformTakedownWithCounter, "BmGame.RCombatMove_BatmanCounter.CanPerformTakedownWithCounter");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitMove, "BmGame.RCombatMove_BatmanCounter.ExitMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitMoveForPawn;
    /// <summary>
    /// Function: ExitMoveForPawn
    /// </summary>
    public unsafe override void ExitMoveForPawn(BmSDK.BmGame.RPawnCombat ExitPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitMoveForPawn, "BmGame.RCombatMove_BatmanCounter.ExitMoveForPawn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExitPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DamageWhenStrangeHitReaction;
    /// <summary>
    /// Function: DamageWhenStrangeHitReaction
    /// </summary>
    public unsafe virtual void DamageWhenStrangeHitReaction()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamageWhenStrangeHitReaction, "BmGame.RCombatMove_BatmanCounter.DamageWhenStrangeHitReaction");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanReceiveAttackFromPawn;
    /// <summary>
    /// Function: CanReceiveAttackFromPawn
    /// </summary>
    public unsafe override bool CanReceiveAttackFromPawn(BmSDK.BmGame.RPawnCombat TestPawn, BmSDK.BmGame.RPawnCombat NewAttacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanReceiveAttackFromPawn, "BmGame.RCombatMove_BatmanCounter.CanReceiveAttackFromPawn");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttacker, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanBeStruckBy;
    /// <summary>
    /// Function: CanBeStruckBy
    /// </summary>
    public unsafe override bool CanBeStruckBy(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.BmGame.RPawnCombat Defender)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeStruckBy, "BmGame.RCombatMove_BatmanCounter.CanBeStruckBy");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Defender, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetImpactPS;
    /// <summary>
    /// Function: GetImpactPS
    /// </summary>
    public unsafe virtual BmSDK.Engine.ParticleSystem GetImpactPS(BmSDK.BmGame.RPawnPlayerCombat.HitStrength HitStrength)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetImpactPS, "BmGame.RCombatMove_BatmanCounter.GetImpactPS");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitStrength, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.ParticleSystem>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SpawnHitParticles;
    /// <summary>
    /// Function: SpawnHitParticles
    /// </summary>
    public unsafe virtual void SpawnHitParticles(BmSDK.BmGame.RPawnPlayerCombat.HitStrength HitStrength, BmSDK.BmGame.RPawnCombat.BoneNameList CounterDamageBone, BmSDK.BmGame.RPawnCombat.BoneNameList CounterImpactBone)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnHitParticles, "BmGame.RCombatMove_BatmanCounter.SpawnHitParticles");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitStrength, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CounterDamageBone, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CounterImpactBone, paramsPtr + 2);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayHitFX;
    /// <summary>
    /// Function: PlayHitFX
    /// </summary>
    public unsafe virtual void PlayHitFX(BmSDK.BmGame.RPawnPlayerCombat.HitStrength HitStrength, bool bFinishingBlow, bool bIsHeadImpact, bool bIsPunch, BmSDK.BmGame.RPawnCombat.BoneNameList CounterDamageBone, BmSDK.BmGame.RPawnCombat.BoneNameList CounterImpactBone)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHitFX, "BmGame.RCombatMove_BatmanCounter.PlayHitFX");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitStrength, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFinishingBlow, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsHeadImpact, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsPunch, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CounterDamageBone, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CounterImpactBone, paramsPtr + 17);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayCounterAnims;
    /// <summary>
    /// Function: PlayCounterAnims
    /// </summary>
    public unsafe virtual void PlayCounterAnims()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCounterAnims, "BmGame.RCombatMove_BatmanCounter.PlayCounterAnims");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetWindingStartTime;
    /// <summary>
    /// Function: GetWindingStartTime
    /// </summary>
    public unsafe virtual void GetWindingStartTime(BmSDK.FName CounterName, out float BatmanWindingTime, out float ThugWindingTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWindingStartTime, "BmGame.RCombatMove_BatmanCounter.GetWindingStartTime");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CounterName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BatmanWindingTime);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmanWindingTime, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ThugWindingTime);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugWindingTime, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BatmanWindingTime = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        ThugWindingTime = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_PlayBatmanAnimation;
    /// <summary>
    /// Function: PlayBatmanAnimation
    /// </summary>
    public unsafe virtual void PlayBatmanAnimation(BmSDK.BmGame.RAnimUtil.EMirrorChoice MC, float WindingStartTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayBatmanAnimation, "BmGame.RCombatMove_BatmanCounter.PlayBatmanAnimation");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WindingStartTime, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayTargetAnimation;
    /// <summary>
    /// Function: PlayTargetAnimation
    /// </summary>
    public unsafe virtual void PlayTargetAnimation(BmSDK.BmGame.RAnimUtil.EMirrorChoice MC, float WindingStartTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayTargetAnimation, "BmGame.RCombatMove_BatmanCounter.PlayTargetAnimation");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WindingStartTime, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopCapeAnim;
    /// <summary>
    /// Function: StopCapeAnim
    /// </summary>
    public unsafe virtual void StopCapeAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopCapeAnim, "BmGame.RCombatMove_BatmanCounter.StopCapeAnim");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayCapeAnim;
    /// <summary>
    /// Function: PlayCapeAnim
    /// </summary>
    public unsafe virtual void PlayCapeAnim(BmSDK.FName DestCapeState, BmSDK.FName CapeAnimName = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCapeAnim, "BmGame.RCombatMove_BatmanCounter.PlayCapeAnim");
        byte* paramsPtr = stackalloc byte[33];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DestCapeState, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CapeAnimName, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateRedirectCounterPressY;
    /// <summary>
    /// Function: UpdateRedirectCounterPressY
    /// </summary>
    public unsafe virtual void UpdateRedirectCounterPressY(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateRedirectCounterPressY, "BmGame.RCombatMove_BatmanCounter.UpdateRedirectCounterPressY");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateRedirectCounterSlomo;
    /// <summary>
    /// Function: UpdateRedirectCounterSlomo
    /// </summary>
    public unsafe virtual void UpdateRedirectCounterSlomo(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateRedirectCounterSlomo, "BmGame.RCombatMove_BatmanCounter.UpdateRedirectCounterSlomo");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateSlowMo, "BmGame.RCombatMove_BatmanCounter.UpdateSlowMo");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopSlowMo;
    /// <summary>
    /// Function: StopSlowMo
    /// </summary>
    public unsafe virtual void StopSlowMo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopSlowMo, "BmGame.RCombatMove_BatmanCounter.StopSlowMo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartSlowMo;
    /// <summary>
    /// Function: StartSlowMo
    /// </summary>
    public unsafe virtual void StartSlowMo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSlowMo, "BmGame.RCombatMove_BatmanCounter.StartSlowMo");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldSlowMo, "BmGame.RCombatMove_BatmanCounter.ShouldSlowMo");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DamageTarget;
    /// <summary>
    /// Function: DamageTarget
    /// </summary>
    public unsafe virtual void DamageTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamageTarget, "BmGame.RCombatMove_BatmanCounter.DamageTarget");
        byte* paramsPtr = stackalloc byte[272];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDamageAmount;
    /// <summary>
    /// Function: GetDamageAmount
    /// </summary>
    public unsafe virtual int GetDamageAmount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamageAmount, "BmGame.RCombatMove_BatmanCounter.GetDamageAmount");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_MoveOverridenForPawn;
    /// <summary>
    /// Function: MoveOverridenForPawn
    /// </summary>
    public unsafe override void MoveOverridenForPawn(BmSDK.BmGame.RPawnCombat OverridenPawn, BmSDK.BmGame.RCombatMove NewMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveOverridenForPawn, "BmGame.RCombatMove_BatmanCounter.MoveOverridenForPawn");
        byte* paramsPtr = stackalloc byte[292];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverridenPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMove, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCounterAnim;
    /// <summary>
    /// Function: GetCounterAnim
    /// </summary>
    public unsafe virtual BmSDK.FName GetCounterAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCounterAnim, "BmGame.RCombatMove_BatmanCounter.GetCounterAnim");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldStartFinalBlowCam;
    /// <summary>
    /// Function: ShouldStartFinalBlowCam
    /// </summary>
    public unsafe virtual bool ShouldStartFinalBlowCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldStartFinalBlowCam, "BmGame.RCombatMove_BatmanCounter.ShouldStartFinalBlowCam");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StartFinalBlowCam;
    /// <summary>
    /// Function: StartFinalBlowCam
    /// </summary>
    public unsafe virtual void StartFinalBlowCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartFinalBlowCam, "BmGame.RCombatMove_BatmanCounter.StartFinalBlowCam");
        byte* paramsPtr = stackalloc byte[140];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckFinalBlowCam;
    /// <summary>
    /// Function: CheckFinalBlowCam
    /// </summary>
    public unsafe virtual void CheckFinalBlowCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckFinalBlowCam, "BmGame.RCombatMove_BatmanCounter.CheckFinalBlowCam");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanNewAttackBeStarted;
    /// <summary>
    /// Function: CanNewAttackBeStarted
    /// </summary>
    public unsafe override bool CanNewAttackBeStarted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanNewAttackBeStarted, "BmGame.RCombatMove_BatmanCounter.CanNewAttackBeStarted");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetAnimPos;
    /// <summary>
    /// Function: SetAnimPos
    /// </summary>
    public unsafe virtual void SetAnimPos()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAnimPos, "BmGame.RCombatMove_BatmanCounter.SetAnimPos");
        byte* paramsPtr = stackalloc byte[88];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BotTryNextStrike, "BmGame.RCombatMove_BatmanCounter.BotTryNextStrike");
        byte* paramsPtr = stackalloc byte[20];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowNextStrike, "BmGame.RCombatMove_BatmanCounter.AllowNextStrike");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableAllRelativeTransitions;
    /// <summary>
    /// Function: DisableAllRelativeTransitions
    /// </summary>
    public unsafe virtual void DisableAllRelativeTransitions()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableAllRelativeTransitions, "BmGame.RCombatMove_BatmanCounter.DisableAllRelativeTransitions");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTeleportTimers;
    /// <summary>
    /// Function: SetTeleportTimers
    /// </summary>
    public unsafe virtual void SetTeleportTimers(float AnimLength)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTeleportTimers, "BmGame.RCombatMove_BatmanCounter.SetTeleportTimers");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimLength, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTeleportReferenceLocation;
    /// <summary>
    /// Function: GetTeleportReferenceLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetTeleportReferenceLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTeleportReferenceLocation, "BmGame.RCombatMove_BatmanCounter.GetTeleportReferenceLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTeleportPawnList;
    /// <summary>
    /// Function: GetTeleportPawnList
    /// </summary>
    public unsafe override BmSDK.TArray<BmSDK.BmGame.RPawnCombat> GetTeleportPawnList()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTeleportPawnList, "BmGame.RCombatMove_BatmanCounter.GetTeleportPawnList");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RPawnCombat>>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InterruptsBeatdown;
    /// <summary>
    /// Function: InterruptsBeatdown
    /// </summary>
    public unsafe override bool InterruptsBeatdown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InterruptsBeatdown, "BmGame.RCombatMove_BatmanCounter.InterruptsBeatdown");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsFinalBlow;
    /// <summary>
    /// Function: IsFinalBlow
    /// </summary>
    public unsafe override bool IsFinalBlow()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFinalBlow, "BmGame.RCombatMove_BatmanCounter.IsFinalBlow");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanTeleport;
    /// <summary>
    /// Function: CanTeleport
    /// </summary>
    public unsafe override bool CanTeleport()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanTeleport, "BmGame.RCombatMove_BatmanCounter.CanTeleport");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsWithinCounterCriticalTimeWindow;
    /// <summary>
    /// Function: IsWithinCounterCriticalTimeWindow
    /// </summary>
    public unsafe virtual bool IsWithinCounterCriticalTimeWindow()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsWithinCounterCriticalTimeWindow, "BmGame.RCombatMove_BatmanCounter.IsWithinCounterCriticalTimeWindow");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Initialise;
    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe override void Initialise()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialise, "BmGame.RCombatMove_BatmanCounter.Initialise");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindEnvironmentWithDirection;
    /// <summary>
    /// Function: FindEnvironmentWithDirection
    /// </summary>
    public unsafe System.Numerics.Vector3 FindEnvironmentWithDirection(System.Numerics.Vector3 Direction, out float Score)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindEnvironmentWithDirection, "BmGame.RCombatMove_BatmanCounter.FindEnvironmentWithDirection");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Score);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Score = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_FindVillainWithDirection;
    /// <summary>
    /// Function: FindVillainWithDirection
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI FindVillainWithDirection(System.Numerics.Vector3 Direction, out float Score)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindVillainWithDirection, "BmGame.RCombatMove_BatmanCounter.FindVillainWithDirection");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Score);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Score = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMPawnAI>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_FindHenchemWithDirection;
    /// <summary>
    /// Function: FindHenchemWithDirection
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI FindHenchemWithDirection(System.Numerics.Vector3 Direction, out float Score)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindHenchemWithDirection, "BmGame.RCombatMove_BatmanCounter.FindHenchemWithDirection");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Score);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Score = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMPawnAI>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetFirstRedirectCounterHitNotify;
    /// <summary>
    /// Function: GetFirstRedirectCounterHitNotify
    /// </summary>
    public unsafe BmSDK.BmGame.MAnimNotify_RedirectCounterHit GetFirstRedirectCounterHitNotify(BmSDK.Engine.AnimSequence AnimSeq, out float Time)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFirstRedirectCounterHitNotify, "BmGame.RCombatMove_BatmanCounter.GetFirstRedirectCounterHitNotify");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSeq, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Time);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Time = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MAnimNotify_RedirectCounterHit>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetCounterInfoScore;
    /// <summary>
    /// Function: GetCounterInfoScore
    /// </summary>
    public unsafe virtual int GetCounterInfoScore(BmSDK.BmGame.RPawnPlayerCombat.FCounterInfo TestCounter, BmSDK.BmGame.RPawnPlayerCombat.CounterMoveDir MoveDir, BmSDK.BmGame.RPawnCombat.CounterLimb Limb, BmSDK.BmGame.RPawnPlayerCombat.CounterStrength TestStrength, bool bOnSlope, bool bShockGlovesActive)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCounterInfoScore, "BmGame.RCombatMove_BatmanCounter.GetCounterInfoScore");
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestCounter, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveDir, paramsPtr + 68);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Limb, paramsPtr + 69);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestStrength, paramsPtr + 70);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnSlope, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShockGlovesActive, paramsPtr + 76);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 80);
    }

    private static BmSDK.Function __fn_SetCounterInfo;
    /// <summary>
    /// Function: SetCounterInfo
    /// </summary>
    public unsafe virtual int SetCounterInfo(BmSDK.BmGame.RPawnPlayerCombat.CounterStrength CStrength)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCounterInfo, "BmGame.RCombatMove_BatmanCounter.SetCounterInfo");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CStrength, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetEnvironmentInfo;
    /// <summary>
    /// Function: SetEnvironmentInfo
    /// </summary>
    public unsafe virtual void SetEnvironmentInfo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEnvironmentInfo, "BmGame.RCombatMove_BatmanCounter.SetEnvironmentInfo");
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

    /// <summary>
    /// StructProperty: ImpactScreenShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ImpactScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 528);

    /// <summary>
    /// FloatProperty: CounterCriticalStrikeWindowBeginTime
    /// </summary>
    public unsafe float CounterCriticalStrikeWindowBeginTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// FloatProperty: CounterCriticalStrikeWindowEndTime
    /// </summary>
    public unsafe float CounterCriticalStrikeWindowEndTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// StructProperty: CounterAnimID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId CounterAnimID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 680);

    /// <summary>
    /// StructProperty: TargetCounteredAnimID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId TargetCounteredAnimID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 684);

    /// <summary>
    /// ClassProperty: CounterDmgType
    /// </summary>
    public unsafe BmSDK.Class CounterDmgType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// StructProperty: CounterDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CounterDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 692);

    /// <summary>
    /// StructProperty: CounterRot
    /// </summary>
    public unsafe ref BmSDK.Rotator CounterRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 704);

    /// <summary>
    /// NameProperty: AnimName
    /// </summary>
    public unsafe BmSDK.FName AnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// NameProperty: ForceAnimName
    /// </summary>
    public unsafe BmSDK.FName ForceAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ObjectProperty: CounterCameraAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CounterCameraAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// BoolProperty: bPlayedCameraAnim
    /// </summary>
    public unsafe bool bPlayedCameraAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }

    /// <summary>
    /// BoolProperty: bAddedScore
    /// </summary>
    public unsafe bool bAddedScore
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }

    /// <summary>
    /// BoolProperty: bDoCameraAssistOnLastHit
    /// </summary>
    public unsafe bool bDoCameraAssistOnLastHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }

    /// <summary>
    /// BoolProperty: bAppliedDamage
    /// </summary>
    public unsafe bool bAppliedDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }

    /// <summary>
    /// BoolProperty: bSlowMo
    /// </summary>
    public unsafe bool bSlowMo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }

    /// <summary>
    /// BoolProperty: bTargetGoRagdollNextFrame
    /// </summary>
    public unsafe bool bTargetGoRagdollNextFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }

    /// <summary>
    /// BoolProperty: bTargetGoRagdollAfterFinalHit
    /// </summary>
    public unsafe bool bTargetGoRagdollAfterFinalHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }

    /// <summary>
    /// BoolProperty: bFinalBlow
    /// </summary>
    public unsafe bool bFinalBlow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }

    /// <summary>
    /// BoolProperty: bShouldKill
    /// </summary>
    public unsafe bool bShouldKill
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }

    /// <summary>
    /// BoolProperty: bFirstSlowMo
    /// </summary>
    public unsafe bool bFirstSlowMo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }

    /// <summary>
    /// BoolProperty: bCachedMoveBeyondCheck
    /// </summary>
    public unsafe bool bCachedMoveBeyondCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }

    /// <summary>
    /// BoolProperty: bCanMoveBeyondTarget
    /// </summary>
    public unsafe bool bCanMoveBeyondTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }

    /// <summary>
    /// BoolProperty: bApplyDamageOnExit
    /// </summary>
    public unsafe bool bApplyDamageOnExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }

    /// <summary>
    /// BoolProperty: bFinalHitHappened
    /// </summary>
    public unsafe bool bFinalHitHappened
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }

    /// <summary>
    /// BoolProperty: bEnvCounter
    /// </summary>
    public unsafe bool bEnvCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }

    /// <summary>
    /// BoolProperty: bOnStep
    /// </summary>
    public unsafe bool bOnStep
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }

    /// <summary>
    /// BoolProperty: bCanFlashTeleport
    /// </summary>
    public unsafe bool bCanFlashTeleport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }

    /// <summary>
    /// BoolProperty: bWillTeleport
    /// </summary>
    public unsafe bool bWillTeleport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }

    /// <summary>
    /// BoolProperty: bTargetIsInvulnerable
    /// </summary>
    public unsafe bool bTargetIsInvulnerable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }

    /// <summary>
    /// BoolProperty: bInformedDeathCutsceneOfFinalHit
    /// </summary>
    public unsafe bool bInformedDeathCutsceneOfFinalHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }

    /// <summary>
    /// BoolProperty: bInSlowMo
    /// </summary>
    public unsafe bool bInSlowMo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }

    /// <summary>
    /// BoolProperty: bDoingRedirectCounter
    /// </summary>
    public unsafe bool bDoingRedirectCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }

    /// <summary>
    /// BoolProperty: bEnabledRedirectCounter
    /// </summary>
    public unsafe bool bEnabledRedirectCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }

    /// <summary>
    /// BoolProperty: bDoRedirectDamageOnExitMove
    /// </summary>
    public unsafe bool bDoRedirectDamageOnExitMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }

    /// <summary>
    /// BoolProperty: bUpdateRedirectCounterSlomo
    /// </summary>
    public unsafe bool bUpdateRedirectCounterSlomo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }

    /// <summary>
    /// BoolProperty: bDetectedDoubleYTap
    /// </summary>
    public unsafe bool bDetectedDoubleYTap
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }

    /// <summary>
    /// BoolProperty: bUseInputDoubleYTap
    /// </summary>
    public unsafe bool bUseInputDoubleYTap
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }

    /// <summary>
    /// BoolProperty: bCanUpgradeToCounterCriticalStrike
    /// </summary>
    public unsafe bool bCanUpgradeToCounterCriticalStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 736); }
    }

    /// <summary>
    /// StructProperty: CounterInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayerCombat.FCounterInfo CounterInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayerCombat.FCounterInfo>(Ptr + 740);

    /// <summary>
    /// ObjectProperty: BatmanCounterAnimSequence
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence BatmanCounterAnimSequence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// NameProperty: LastHitBone
    /// </summary>
    public unsafe BmSDK.FName LastHitBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// FloatProperty: ChapterNumber
    /// </summary>
    public unsafe float ChapterNumber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// IntProperty: NumCounterHits
    /// </summary>
    public unsafe int NumCounterHits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// IntProperty: CurrCounterHit
    /// </summary>
    public unsafe int CurrCounterHit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ArrayProperty: SlowMoHitTimes
    /// </summary>
    public unsafe BmSDK.TArray<float> SlowMoHitTimes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// FloatProperty: CounterTime
    /// </summary>
    public unsafe float CounterTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ObjectProperty: BatmanAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BatmanAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// ObjectProperty: TargetAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet TargetAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// StructProperty: AnimPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AnimPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 856);

    /// <summary>
    /// ByteProperty: CounterWallDir
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCombat.CounterEnvironmentDir CounterWallDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.CounterEnvironmentDir>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ByteProperty: CounterRailDir
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCombat.CounterEnvironmentDir CounterRailDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.CounterEnvironmentDir>(Ptr + 869); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 869); }
    }

    /// <summary>
    /// ByteProperty: OverrideMoveType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EComboMoveType OverrideMoveType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EComboMoveType>(Ptr + 870); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 870); }
    }

    /// <summary>
    /// StructProperty: EnvCounterLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EnvCounterLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 872);

    /// <summary>
    /// StructProperty: EnvCounterNormal
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EnvCounterNormal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 884);

    /// <summary>
    /// IntProperty: OverrideComboInc
    /// </summary>
    public unsafe int OverrideComboInc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// IntProperty: CapeStateChangeIndex
    /// </summary>
    public unsafe int CapeStateChangeIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// NameProperty: RedirectAnim
    /// </summary>
    public unsafe BmSDK.FName RedirectAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// StructProperty: RedirectDirection
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RedirectDirection
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 912);

    /// <summary>
    /// FloatProperty: RedirectNotifyTime
    /// </summary>
    public unsafe float RedirectNotifyTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }
}
