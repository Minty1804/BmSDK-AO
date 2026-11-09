#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RPawnVillain<br/>
/// (size = 3996)
/// (flags = 144703671)
/// </summary>
public partial class RPawnVillain : BmSDK.BmGame.RBMPawnAI, BmSDK.BmGame.RSpotableInterface, BmSDK.BmGame.RBatarangableInterface, BmSDK.BmGame.RJammerInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnVillain", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnVillain.
    /// </summary>
    public static RPawnVillain DefaultObject => (RPawnVillain)StaticClass().DefaultObject;

    internal RPawnVillain() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillain(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillain>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillain>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillain>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillain>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillain>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillain>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillain>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillain>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetTakedownAnimSetBM;
    /// <summary>
    /// Function: GetTakedownAnimSetBM
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetTakedownAnimSetBM()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTakedownAnimSetBM, "BmGame.RPawnVillain.GetTakedownAnimSetBM");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTakedownAnimSetTG;
    /// <summary>
    /// Function: GetTakedownAnimSetTG
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetTakedownAnimSetTG()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTakedownAnimSetTG, "BmGame.RPawnVillain.GetTakedownAnimSetTG");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_EnterMercyModeGeneric;
    /// <summary>
    /// Function: EnterMercyModeGeneric
    /// </summary>
    public unsafe virtual void EnterMercyModeGeneric()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnterMercyModeGeneric, "BmGame.RPawnVillain.EnterMercyModeGeneric");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GoToMercyMode;
    /// <summary>
    /// Function: GoToMercyMode
    /// </summary>
    public unsafe virtual void GoToMercyMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GoToMercyMode, "BmGame.RPawnVillain.GoToMercyMode");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySurrenderDialogue;
    /// <summary>
    /// Function: PlaySurrenderDialogue
    /// </summary>
    public unsafe virtual void PlaySurrenderDialogue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySurrenderDialogue, "BmGame.RPawnVillain.PlaySurrenderDialogue");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayShivaEvadeBossBark;
    /// <summary>
    /// Function: PlayShivaEvadeBossBark
    /// </summary>
    public unsafe virtual void PlayShivaEvadeBossBark()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayShivaEvadeBossBark, "BmGame.RPawnVillain.PlayShivaEvadeBossBark");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLastAttackStartTime;
    /// <summary>
    /// Function: SetLastAttackStartTime
    /// </summary>
    public unsafe virtual void SetLastAttackStartTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLastAttackStartTime, "BmGame.RPawnVillain.SetLastAttackStartTime");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RagDollTouchGround;
    /// <summary>
    /// Function: RagDollTouchGround
    /// </summary>
    public unsafe virtual void RagDollTouchGround()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RagDollTouchGround, "BmGame.RPawnVillain.RagDollTouchGround");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSnowOnLegsTimeIdle;
    /// <summary>
    /// Function: GetSnowOnLegsTimeIdle
    /// </summary>
    public unsafe override float GetSnowOnLegsTimeIdle()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSnowOnLegsTimeIdle, "BmGame.RPawnVillain.GetSnowOnLegsTimeIdle");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSnowOnLegsTimeIn;
    /// <summary>
    /// Function: GetSnowOnLegsTimeIn
    /// </summary>
    public unsafe override float GetSnowOnLegsTimeIn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSnowOnLegsTimeIn, "BmGame.RPawnVillain.GetSnowOnLegsTimeIn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSnowOnLegsTimeOut;
    /// <summary>
    /// Function: GetSnowOnLegsTimeOut
    /// </summary>
    public unsafe override float GetSnowOnLegsTimeOut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSnowOnLegsTimeOut, "BmGame.RPawnVillain.GetSnowOnLegsTimeOut");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsAllowedToUseStrongCounters;
    /// <summary>
    /// Function: IsAllowedToUseStrongCounters
    /// </summary>
    public unsafe virtual bool IsAllowedToUseStrongCounters()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAllowedToUseStrongCounters, "BmGame.RPawnVillain.IsAllowedToUseStrongCounters");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_LockTargetDuringBeatdown;
    /// <summary>
    /// Function: LockTargetDuringBeatdown
    /// </summary>
    public unsafe virtual bool LockTargetDuringBeatdown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LockTargetDuringBeatdown, "BmGame.RPawnVillain.LockTargetDuringBeatdown");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayCombatBark;
    /// <summary>
    /// Function: PlayCombatBark
    /// </summary>
    public unsafe override void PlayCombatBark(BmSDK.FString EventName, bool bUseWeapon, bool bShouldPlayGroupTaunt = default, BmSDK.BmGame.RBMWeapon OverrideWeapon = default, BmSDK.FString OverrideWeaponName = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCombatBark, "BmGame.RPawnVillain.PlayCombatBark");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseWeapon, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldPlayGroupTaunt, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideWeapon, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideWeaponName, paramsPtr + 24);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_NotifyHitPlayer;
    /// <summary>
    /// Function: NotifyHitPlayer
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat.FDamageInfo NotifyHitPlayer(System.Numerics.Vector3 HitNormal, bool IsFlameBall)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyHitPlayer, "BmGame.RPawnVillain.NotifyHitPlayer");
        byte* paramsPtr = stackalloc byte[288];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsFlameBall, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.FDamageInfo>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetHeavyDamageAmount;
    /// <summary>
    /// Function: GetHeavyDamageAmount
    /// </summary>
    public unsafe virtual float GetHeavyDamageAmount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeavyDamageAmount, "BmGame.RPawnVillain.GetHeavyDamageAmount");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CannotBeTakedownViaCounter;
    /// <summary>
    /// Function: CannotBeTakedownViaCounter
    /// </summary>
    public unsafe virtual bool CannotBeTakedownViaCounter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CannotBeTakedownViaCounter, "BmGame.RPawnVillain.CannotBeTakedownViaCounter");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBlockMove;
    /// <summary>
    /// Function: GetBlockMove
    /// </summary>
    public unsafe virtual BmSDK.Class GetBlockMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBlockMove, "BmGame.RPawnVillain.GetBlockMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsValidBatclawSlamTarget;
    /// <summary>
    /// Function: IsValidBatclawSlamTarget
    /// </summary>
    public unsafe virtual bool IsValidBatclawSlamTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidBatclawSlamTarget, "BmGame.RPawnVillain.IsValidBatclawSlamTarget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGooSprayDamageAmount;
    /// <summary>
    /// Function: GetGooSprayDamageAmount
    /// </summary>
    public unsafe virtual float GetGooSprayDamageAmount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGooSprayDamageAmount, "BmGame.RPawnVillain.GetGooSprayDamageAmount");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldStartFinalBlowCam;
    /// <summary>
    /// Function: ShouldStartFinalBlowCam
    /// </summary>
    public unsafe virtual bool ShouldStartFinalBlowCam(float StrikeDamageAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldStartFinalBlowCam, "BmGame.RPawnVillain.ShouldStartFinalBlowCam");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeDamageAmount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetCloseAttackDamageMultiplier;
    /// <summary>
    /// Function: GetCloseAttackDamageMultiplier
    /// </summary>
    public unsafe virtual float GetCloseAttackDamageMultiplier()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCloseAttackDamageMultiplier, "BmGame.RPawnVillain.GetCloseAttackDamageMultiplier");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStunGrenadePriority;
    /// <summary>
    /// Function: GetStunGrenadePriority
    /// </summary>
    public unsafe virtual float GetStunGrenadePriority()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStunGrenadePriority, "BmGame.RPawnVillain.GetStunGrenadePriority");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGlueGrenadePriority;
    /// <summary>
    /// Function: GetGlueGrenadePriority
    /// </summary>
    public unsafe virtual float GetGlueGrenadePriority()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGlueGrenadePriority, "BmGame.RPawnVillain.GetGlueGrenadePriority");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSpecialFloorInteractionType;
    /// <summary>
    /// Function: GetSpecialFloorInteractionType
    /// </summary>
    public unsafe virtual BmSDK.Class GetSpecialFloorInteractionType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSpecialFloorInteractionType, "BmGame.RPawnVillain.GetSpecialFloorInteractionType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayFinishingBlowSound;
    /// <summary>
    /// Function: PlayFinishingBlowSound
    /// </summary>
    public unsafe virtual void PlayFinishingBlowSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFinishingBlowSound, "BmGame.RPawnVillain.PlayFinishingBlowSound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayFinishingBlowSoundWithDelay;
    /// <summary>
    /// Function: PlayFinishingBlowSoundWithDelay
    /// </summary>
    public unsafe virtual void PlayFinishingBlowSoundWithDelay(float Delay)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFinishingBlowSoundWithDelay, "BmGame.RPawnVillain.PlayFinishingBlowSoundWithDelay");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyFinishedLaughingReactionOut;
    /// <summary>
    /// Function: NotifyFinishedLaughingReactionOut
    /// </summary>
    public unsafe virtual void NotifyFinishedLaughingReactionOut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyFinishedLaughingReactionOut, "BmGame.RPawnVillain.NotifyFinishedLaughingReactionOut");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyStandAimingInENDs;
    /// <summary>
    /// Function: NotifyStandAimingInENDs
    /// </summary>
    public unsafe virtual void NotifyStandAimingInENDs()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyStandAimingInENDs, "BmGame.RPawnVillain.NotifyStandAimingInENDs");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyLastPawnAlive;
    /// <summary>
    /// Function: NotifyLastPawnAlive
    /// </summary>
    public unsafe virtual void NotifyLastPawnAlive()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyLastPawnAlive, "BmGame.RPawnVillain.NotifyLastPawnAlive");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckBossBatarang;
    /// <summary>
    /// Function: CheckBossBatarang
    /// </summary>
    public unsafe virtual void CheckBossBatarang(BmSDK.BmGame.RBatarangProjectile Proj)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckBossBatarang, "BmGame.RPawnVillain.CheckBossBatarang");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proj, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyFireStop;
    /// <summary>
    /// Function: NotifyFireStop
    /// </summary>
    public unsafe virtual void NotifyFireStop()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyFireStop, "BmGame.RPawnVillain.NotifyFireStop");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyLaughCauseDamageToTarget;
    /// <summary>
    /// Function: NotifyLaughCauseDamageToTarget
    /// </summary>
    public unsafe virtual void NotifyLaughCauseDamageToTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyLaughCauseDamageToTarget, "BmGame.RPawnVillain.NotifyLaughCauseDamageToTarget");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyLaughingPunchFinished;
    /// <summary>
    /// Function: NotifyLaughingPunchFinished
    /// </summary>
    public unsafe virtual void NotifyLaughingPunchFinished()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyLaughingPunchFinished, "BmGame.RPawnVillain.NotifyLaughingPunchFinished");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyLaughingPunch;
    /// <summary>
    /// Function: NotifyLaughingPunch
    /// </summary>
    public unsafe virtual void NotifyLaughingPunch()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyLaughingPunch, "BmGame.RPawnVillain.NotifyLaughingPunch");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyLaughChooseTarget;
    /// <summary>
    /// Function: NotifyLaughChooseTarget
    /// </summary>
    public unsafe virtual void NotifyLaughChooseTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyLaughChooseTarget, "BmGame.RPawnVillain.NotifyLaughChooseTarget");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyFire;
    /// <summary>
    /// Function: NotifyFire
    /// </summary>
    public unsafe virtual void NotifyFire()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyFire, "BmGame.RPawnVillain.NotifyFire");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddBasicAnimSets;
    /// <summary>
    /// Function: AddBasicAnimSets
    /// </summary>
    public unsafe override void AddBasicAnimSets(out BmSDK.TArray<BmSDK.Engine.AnimSet> AnimSets)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddBasicAnimSets, "BmGame.RPawnVillain.AddBasicAnimSets");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AnimSets = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.AnimSet>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_ResetCustomFloorCorrection;
    /// <summary>
    /// Function: ResetCustomFloorCorrection
    /// </summary>
    public unsafe virtual void ResetCustomFloorCorrection()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetCustomFloorCorrection, "BmGame.RPawnVillain.ResetCustomFloorCorrection");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanPlaySpeech;
    /// <summary>
    /// Function: CanPlaySpeech
    /// </summary>
    public unsafe override bool CanPlaySpeech()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlaySpeech, "BmGame.RPawnVillain.CanPlaySpeech");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_EnableSelfHarm;
    /// <summary>
    /// Function: EnableSelfHarm
    /// </summary>
    public unsafe virtual void EnableSelfHarm()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableSelfHarm, "BmGame.RPawnVillain.EnableSelfHarm");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WeaponSwitchCallback;
    /// <summary>
    /// Function: WeaponSwitchCallback
    /// </summary>
    public unsafe override void WeaponSwitchCallback(BmSDK.Engine.Inventory NewWeapon, BmSDK.Engine.Inventory PreviousWeapon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponSwitchCallback, "BmGame.RPawnVillain.WeaponSwitchCallback");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousWeapon, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DodgedProjectile;
    /// <summary>
    /// Function: DodgedProjectile
    /// </summary>
    public unsafe virtual void DodgedProjectile()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DodgedProjectile, "BmGame.RPawnVillain.DodgedProjectile");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReceiveCombatEvent;
    /// <summary>
    /// Function: ReceiveCombatEvent
    /// </summary>
    public unsafe virtual void ReceiveCombatEvent(BmSDK.BmGame.RPawnCombat EventInstigator, System.Numerics.Vector3 EventLocation, System.Numerics.Vector3 SightingLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReceiveCombatEvent, "BmGame.RPawnVillain.ReceiveCombatEvent");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventInstigator, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SightingLocation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsWatchingBatarang;
    /// <summary>
    /// Function: IsWatchingBatarang
    /// </summary>
    public unsafe virtual bool IsWatchingBatarang()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsWatchingBatarang, "BmGame.RPawnVillain.IsWatchingBatarang");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsDistractedByGadgetNoise;
    /// <summary>
    /// Function: IsDistractedByGadgetNoise
    /// </summary>
    public unsafe virtual bool IsDistractedByGadgetNoise()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDistractedByGadgetNoise, "BmGame.RPawnVillain.IsDistractedByGadgetNoise");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ReenableCollisionWithPlayer;
    /// <summary>
    /// Function: ReenableCollisionWithPlayer
    /// </summary>
    public unsafe virtual void ReenableCollisionWithPlayer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReenableCollisionWithPlayer, "BmGame.RPawnVillain.ReenableCollisionWithPlayer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateFocusAura;
    /// <summary>
    /// Function: UpdateFocusAura
    /// </summary>
    public unsafe virtual void UpdateFocusAura(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateFocusAura, "BmGame.RPawnVillain.UpdateFocusAura");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOffAura;
    /// <summary>
    /// Function: TurnOffAura
    /// </summary>
    public unsafe virtual void TurnOffAura()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffAura, "BmGame.RPawnVillain.TurnOffAura");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOnAura;
    /// <summary>
    /// Function: TurnOnAura
    /// </summary>
    public unsafe virtual void TurnOnAura()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOnAura, "BmGame.RPawnVillain.TurnOnAura");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCannotBeTargettedByPlayer;
    /// <summary>
    /// Function: SetCannotBeTargettedByPlayer
    /// </summary>
    public unsafe override void SetCannotBeTargettedByPlayer(BmSDK.Engine.PlayerController PC, BmSDK.Engine.MaterialInstanceConstant FocusAuraMat)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCannotBeTargettedByPlayer, "BmGame.RPawnVillain.SetCannotBeTargettedByPlayer");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FocusAuraMat, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PauseAnimTimeScale;
    /// <summary>
    /// Function: PauseAnimTimeScale
    /// </summary>
    public unsafe virtual void PauseAnimTimeScale()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PauseAnimTimeScale, "BmGame.RPawnVillain.PauseAnimTimeScale");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RevertAnimTimeScale;
    /// <summary>
    /// Function: RevertAnimTimeScale
    /// </summary>
    public unsafe virtual void RevertAnimTimeScale()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RevertAnimTimeScale, "BmGame.RPawnVillain.RevertAnimTimeScale");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetForceTaunting;
    /// <summary>
    /// Function: SetForceTaunting
    /// </summary>
    public unsafe virtual void SetForceTaunting(bool bNewValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetForceTaunting, "BmGame.RPawnVillain.SetForceTaunting");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanRecoverFromStunned;
    /// <summary>
    /// Function: CanRecoverFromStunned
    /// </summary>
    public unsafe virtual bool CanRecoverFromStunned()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanRecoverFromStunned, "BmGame.RPawnVillain.CanRecoverFromStunned");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AllowGooInGodMode;
    /// <summary>
    /// Function: AllowGooInGodMode
    /// </summary>
    public unsafe virtual bool AllowGooInGodMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowGooInGodMode, "BmGame.RPawnVillain.AllowGooInGodMode");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlaySound_ImpactEmote;
    /// <summary>
    /// Function: PlaySound_ImpactEmote
    /// </summary>
    public unsafe virtual void PlaySound_ImpactEmote(bool bIsStrike, bool bFinishingBlow, bool bIsHeadImpact, bool bIsPunch, bool bIsStrong, bool bIsBlocked, bool bCanEmote = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySound_ImpactEmote, "BmGame.RPawnVillain.PlaySound_ImpactEmote");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsStrike, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFinishingBlow, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsHeadImpact, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsPunch, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsStrong, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsBlocked, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanEmote, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySound_ImpactAI;
    /// <summary>
    /// Function: PlaySound_ImpactAI
    /// </summary>
    public unsafe override void PlaySound_ImpactAI(bool bIsStrike, bool bFinishingBlow, bool bIsHeadImpact, bool bIsPunch, bool bIsStrong, bool bIsBlocked, bool bCanEmote = default, bool bIsSuperStrike = default, bool bIsBeatDown = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySound_ImpactAI, "BmGame.RPawnVillain.PlaySound_ImpactAI");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsStrike, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFinishingBlow, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsHeadImpact, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsPunch, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsStrong, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsBlocked, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanEmote, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsSuperStrike, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsBeatDown, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanSpawnPredatorFinaleCam;
    /// <summary>
    /// Function: CanSpawnPredatorFinaleCam
    /// </summary>
    public unsafe virtual bool CanSpawnPredatorFinaleCam(int NumTakenDown = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSpawnPredatorFinaleCam, "BmGame.RPawnVillain.CanSpawnPredatorFinaleCam");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumTakenDown, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDodgeMovementStance;
    /// <summary>
    /// Function: GetDodgeMovementStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetDodgeMovementStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDodgeMovementStance, "BmGame.RPawnVillain.GetDodgeMovementStance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRedirectWeaponStance;
    /// <summary>
    /// Function: GetRedirectWeaponStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetRedirectWeaponStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRedirectWeaponStance, "BmGame.RPawnVillain.GetRedirectWeaponStance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHealthForBeatdown;
    /// <summary>
    /// Function: GetHealthForBeatdown
    /// </summary>
    public unsafe virtual float GetHealthForBeatdown(bool bBeatdownEndCheck)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHealthForBeatdown, "BmGame.RPawnVillain.GetHealthForBeatdown");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBeatdownEndCheck, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CanBeatdownFinish;
    /// <summary>
    /// Function: CanBeatdownFinish
    /// </summary>
    public unsafe virtual bool CanBeatdownFinish()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeatdownFinish, "BmGame.RPawnVillain.CanBeatdownFinish");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TryCower;
    /// <summary>
    /// Function: TryCower
    /// </summary>
    public unsafe virtual void TryCower(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo, BmSDK.BmGame.RPawnCombat EventInstigator, System.Numerics.Vector3 EventLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryCower, "BmGame.RPawnVillain.TryCower");
        byte* paramsPtr = stackalloc byte[300];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventInstigator, paramsPtr + 256);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventLocation, paramsPtr + 260);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanCower;
    /// <summary>
    /// Function: CanCower
    /// </summary>
    public unsafe virtual bool CanCower()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanCower, "BmGame.RPawnVillain.CanCower");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsHoldingHostage;
    /// <summary>
    /// Function: IsHoldingHostage
    /// </summary>
    public unsafe virtual bool IsHoldingHostage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsHoldingHostage, "BmGame.RPawnVillain.IsHoldingHostage");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CleanupDialoguePackages;
    /// <summary>
    /// Function: CleanupDialoguePackages
    /// </summary>
    public unsafe virtual void CleanupDialoguePackages()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CleanupDialoguePackages, "BmGame.RPawnVillain.CleanupDialoguePackages");
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

    private static BmSDK.Function __fn_GetRagdollMass;
    /// <summary>
    /// Function: GetRagdollMass
    /// </summary>
    public unsafe virtual float GetRagdollMass(BmSDK.Engine.SkeletalMeshComponent RagdollSkelComponent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRagdollMass, "BmGame.RPawnVillain.GetRagdollMass");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RagdollSkelComponent, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetRagdollMassScale;
    /// <summary>
    /// Function: SetRagdollMassScale
    /// </summary>
    public unsafe virtual bool SetRagdollMassScale(BmSDK.Engine.SkeletalMeshComponent RagdollSkelComponent, float Scale)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRagdollMassScale, "BmGame.RPawnVillain.SetRagdollMassScale");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RagdollSkelComponent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scale, paramsPtr + 4);
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

    private static BmSDK.Function __fn_JammerRestored;
    /// <summary>
    /// Function: JammerRestored
    /// </summary>
    public unsafe virtual void JammerRestored()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_JammerRestored, "BmGame.RPawnVillain.JammerRestored");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_JammerDisabled;
    /// <summary>
    /// Function: JammerDisabled
    /// </summary>
    public unsafe virtual void JammerDisabled()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_JammerDisabled, "BmGame.RPawnVillain.JammerDisabled");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickInCombatTime;
    /// <summary>
    /// Function: TickInCombatTime
    /// </summary>
    public unsafe virtual void TickInCombatTime(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickInCombatTime, "BmGame.RPawnVillain.TickInCombatTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GroupAttackHit;
    /// <summary>
    /// Function: GroupAttackHit
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat.DamageResult GroupAttackHit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GroupAttackHit, "BmGame.RPawnVillain.GroupAttackHit");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsInPredatorAttack;
    /// <summary>
    /// Function: IsInPredatorAttack
    /// </summary>
    public unsafe virtual bool IsInPredatorAttack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInPredatorAttack, "BmGame.RPawnVillain.IsInPredatorAttack");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TriggerCowerEvent;
    /// <summary>
    /// Function: TriggerCowerEvent
    /// </summary>
    public unsafe virtual void TriggerCowerEvent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCowerEvent, "BmGame.RPawnVillain.TriggerCowerEvent");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCameraAnimsets;
    /// <summary>
    /// Function: GetCameraAnimsets
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.Engine.AnimSet> GetCameraAnimsets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCameraAnimsets, "BmGame.RPawnVillain.GetCameraAnimsets");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.AnimSet>>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRECHitReactionAnimName;
    /// <summary>
    /// Function: GetRECHitReactionAnimName
    /// </summary>
    public unsafe virtual BmSDK.FName GetRECHitReactionAnimName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRECHitReactionAnimName, "BmGame.RPawnVillain.GetRECHitReactionAnimName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRECHitReactionAnimset;
    /// <summary>
    /// Function: GetRECHitReactionAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetRECHitReactionAnimset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRECHitReactionAnimset, "BmGame.RPawnVillain.GetRECHitReactionAnimset");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHitReactionAnimset;
    /// <summary>
    /// Function: GetHitReactionAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetHitReactionAnimset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHitReactionAnimset, "BmGame.RPawnVillain.GetHitReactionAnimset");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetThrownObjectClass;
    /// <summary>
    /// Function: GetThrownObjectClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetThrownObjectClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThrownObjectClass, "BmGame.RPawnVillain.GetThrownObjectClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CleanupAfterFlashTeleport;
    /// <summary>
    /// Function: CleanupAfterFlashTeleport
    /// </summary>
    public unsafe virtual void CleanupAfterFlashTeleport()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CleanupAfterFlashTeleport, "BmGame.RPawnVillain.CleanupAfterFlashTeleport");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnFlashTeleportBack;
    /// <summary>
    /// Function: OnFlashTeleportBack
    /// </summary>
    public unsafe virtual void OnFlashTeleportBack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFlashTeleportBack, "BmGame.RPawnVillain.OnFlashTeleportBack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnFlashTeleport;
    /// <summary>
    /// Function: OnFlashTeleport
    /// </summary>
    public unsafe virtual void OnFlashTeleport()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFlashTeleport, "BmGame.RPawnVillain.OnFlashTeleport");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PrepareForFlashTeleport;
    /// <summary>
    /// Function: PrepareForFlashTeleport
    /// </summary>
    public unsafe virtual void PrepareForFlashTeleport()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrepareForFlashTeleport, "BmGame.RPawnVillain.PrepareForFlashTeleport");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAerialAttackCameraAnimSet;
    /// <summary>
    /// Function: GetAerialAttackCameraAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetAerialAttackCameraAnimSet()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAerialAttackCameraAnimSet, "BmGame.RPawnVillain.GetAerialAttackCameraAnimSet");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAerialAttackAnimName;
    /// <summary>
    /// Function: GetAerialAttackAnimName
    /// </summary>
    public unsafe virtual BmSDK.FName GetAerialAttackAnimName(bool bFinisher)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAerialAttackAnimName, "BmGame.RPawnVillain.GetAerialAttackAnimName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFinisher, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TriggerWeaponBomb;
    /// <summary>
    /// Function: TriggerWeaponBomb
    /// </summary>
    public unsafe virtual bool TriggerWeaponBomb()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerWeaponBomb, "BmGame.RPawnVillain.TriggerWeaponBomb");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsDangerousHostageTaker;
    /// <summary>
    /// Function: IsDangerousHostageTaker
    /// </summary>
    public unsafe virtual bool IsDangerousHostageTaker()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDangerousHostageTaker, "BmGame.RPawnVillain.IsDangerousHostageTaker");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsHostageTaker;
    /// <summary>
    /// Function: IsHostageTaker
    /// </summary>
    public unsafe virtual bool IsHostageTaker()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsHostageTaker, "BmGame.RPawnVillain.IsHostageTaker");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldMagBlastLockOn;
    /// <summary>
    /// Function: ShouldMagBlastLockOn
    /// </summary>
    public unsafe virtual bool ShouldMagBlastLockOn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldMagBlastLockOn, "BmGame.RPawnVillain.ShouldMagBlastLockOn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PairedAnimsLoadFailed;
    /// <summary>
    /// Function: PairedAnimsLoadFailed
    /// </summary>
    public unsafe virtual void PairedAnimsLoadFailed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PairedAnimsLoadFailed, "BmGame.RPawnVillain.PairedAnimsLoadFailed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PairedAnimsSuccessfullyLoaded;
    /// <summary>
    /// Function: PairedAnimsSuccessfullyLoaded
    /// </summary>
    public unsafe virtual void PairedAnimsSuccessfullyLoaded()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PairedAnimsSuccessfullyLoaded, "BmGame.RPawnVillain.PairedAnimsSuccessfullyLoaded");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterPairedAnimsets;
    /// <summary>
    /// Function: RegisterPairedAnimsets
    /// </summary>
    public unsafe virtual void RegisterPairedAnimsets(BmSDK.Engine.AnimSet PlayerAnimset, BmSDK.Engine.AnimSet VillainAnimSet)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterPairedAnimsets, "BmGame.RPawnVillain.RegisterPairedAnimsets");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerAnimset, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VillainAnimSet, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCommsJammedMovieString;
    /// <summary>
    /// Function: GetCommsJammedMovieString
    /// </summary>
    public unsafe virtual BmSDK.FString GetCommsJammedMovieString()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCommsJammedMovieString, "BmGame.RPawnVillain.GetCommsJammedMovieString");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanJamComms;
    /// <summary>
    /// Function: CanJamComms
    /// </summary>
    public unsafe virtual bool CanJamComms()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanJamComms, "BmGame.RPawnVillain.CanJamComms");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsActiveJamer;
    /// <summary>
    /// Function: IsActiveJamer
    /// </summary>
    public unsafe virtual bool IsActiveJamer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsActiveJamer, "BmGame.RPawnVillain.IsActiveJamer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnForensicDeviceLevelChange;
    /// <summary>
    /// Function: OnForensicDeviceLevelChange
    /// </summary>
    public unsafe virtual void OnForensicDeviceLevelChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnForensicDeviceLevelChange, "BmGame.RPawnVillain.OnForensicDeviceLevelChange");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanSendJammerToHud;
    /// <summary>
    /// Function: CanSendJammerToHud
    /// </summary>
    public unsafe virtual bool CanSendJammerToHud()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSendJammerToHud, "BmGame.RPawnVillain.CanSendJammerToHud");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetJammerLocation;
    /// <summary>
    /// Function: GetJammerLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetJammerLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetJammerLocation, "BmGame.RPawnVillain.GetJammerLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetParameterInterference;
    /// <summary>
    /// Function: GetParameterInterference
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkParameterName GetParameterInterference()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetParameterInterference, "BmGame.RPawnVillain.GetParameterInterference");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkParameterName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetParameterAngle;
    /// <summary>
    /// Function: GetParameterAngle
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkParameterName GetParameterAngle()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetParameterAngle, "BmGame.RPawnVillain.GetParameterAngle");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkParameterName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetInXrayMode;
    /// <summary>
    /// Function: SetInXrayMode
    /// </summary>
    public unsafe override void SetInXrayMode(bool show, bool bForceOff)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInXrayMode, "BmGame.RPawnVillain.SetInXrayMode");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(show, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveInterrogationInteraction;
    /// <summary>
    /// Function: RemoveInterrogationInteraction
    /// </summary>
    public unsafe virtual void RemoveInterrogationInteraction()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveInterrogationInteraction, "BmGame.RPawnVillain.RemoveInterrogationInteraction");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateInterrogationInteraction;
    /// <summary>
    /// Function: UpdateInterrogationInteraction
    /// </summary>
    public unsafe virtual void UpdateInterrogationInteraction()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateInterrogationInteraction, "BmGame.RPawnVillain.UpdateInterrogationInteraction");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHostile;
    /// <summary>
    /// Function: SetHostile
    /// </summary>
    public unsafe override void SetHostile(bool bNewValue, BmSDK.FName NewNotHostileReason = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHostile, "BmGame.RPawnVillain.SetHostile");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewNotHostileReason, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RandomBarkFudgeFactor;
    /// <summary>
    /// Function: RandomBarkFudgeFactor
    /// </summary>
    public unsafe virtual float RandomBarkFudgeFactor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RandomBarkFudgeFactor, "BmGame.RPawnVillain.RandomBarkFudgeFactor");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetThoughts;
    /// <summary>
    /// Function: GetThoughts
    /// </summary>
    public unsafe override void GetThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThoughts, "BmGame.RPawnVillain.GetThoughts");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetOuterMost;
    /// <summary>
    /// Function: GetOuterMost
    /// </summary>
    public unsafe virtual BmSDK.GameObject GetOuterMost(BmSDK.GameObject A)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOuterMost, "BmGame.RPawnVillain.GetOuterMost");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_RecentlyDecidedToFlee;
    /// <summary>
    /// Function: RecentlyDecidedToFlee
    /// </summary>
    public unsafe virtual void RecentlyDecidedToFlee()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecentlyDecidedToFlee, "BmGame.RPawnVillain.RecentlyDecidedToFlee");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldFlee;
    /// <summary>
    /// Function: ShouldFlee
    /// </summary>
    public unsafe virtual bool ShouldFlee()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldFlee, "BmGame.RPawnVillain.ShouldFlee");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargetPriority, "BmGame.RPawnVillain.GetTargetPriority");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetAerialAttackPriority;
    /// <summary>
    /// Function: GetAerialAttackPriority
    /// </summary>
    public unsafe virtual int GetAerialAttackPriority()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAerialAttackPriority, "BmGame.RPawnVillain.GetAerialAttackPriority");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanBeInSimultaneousAttack;
    /// <summary>
    /// Function: CanBeInSimultaneousAttack
    /// </summary>
    public unsafe virtual bool CanBeInSimultaneousAttack(BmSDK.BmGame.RPawnCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeInSimultaneousAttack, "BmGame.RPawnVillain.CanBeInSimultaneousAttack");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HidePickPocketTarget;
    /// <summary>
    /// Function: HidePickPocketTarget
    /// </summary>
    public unsafe virtual void HidePickPocketTarget(bool bHide)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HidePickPocketTarget, "BmGame.RPawnVillain.HidePickPocketTarget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHide, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCanPickPocket;
    /// <summary>
    /// Function: SetCanPickPocket
    /// </summary>
    public unsafe virtual void SetCanPickPocket(bool bEnable)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCanPickPocket, "BmGame.RPawnVillain.SetCanPickPocket");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnable, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPickPocketTarget;
    /// <summary>
    /// Function: IsPickPocketTarget
    /// </summary>
    public unsafe virtual bool IsPickPocketTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPickPocketTarget, "BmGame.RPawnVillain.IsPickPocketTarget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ChangeXrayColour;
    /// <summary>
    /// Function: ChangeXrayColour
    /// </summary>
    public unsafe override void ChangeXrayColour(bool bBlue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeXrayColour, "BmGame.RPawnVillain.ChangeXrayColour");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBlue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceResetTakedown;
    /// <summary>
    /// Function: ForceResetTakedown
    /// </summary>
    public unsafe virtual void ForceResetTakedown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceResetTakedown, "BmGame.RPawnVillain.ForceResetTakedown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InterrogationTriggered;
    /// <summary>
    /// Function: InterrogationTriggered
    /// </summary>
    public unsafe virtual void InterrogationTriggered()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InterrogationTriggered, "BmGame.RPawnVillain.InterrogationTriggered");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInterrogatable;
    /// <summary>
    /// Function: SetInterrogatable
    /// </summary>
    public unsafe override void SetInterrogatable(bool bNewValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInterrogatable, "BmGame.RPawnVillain.SetInterrogatable");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckInformantPlayerSwitch;
    /// <summary>
    /// Function: CheckInformantPlayerSwitch
    /// </summary>
    public unsafe virtual void CheckInformantPlayerSwitch(BmSDK.FString NewCharacterName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckInformantPlayerSwitch, "BmGame.RPawnVillain.CheckInformantPlayerSwitch");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCharacterName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForAllSecretsFoundOrPlayerChange;
    /// <summary>
    /// Function: CheckForAllSecretsFoundOrPlayerChange
    /// </summary>
    public unsafe override void CheckForAllSecretsFoundOrPlayerChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForAllSecretsFoundOrPlayerChange, "BmGame.RPawnVillain.CheckForAllSecretsFoundOrPlayerChange");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MarkInterrogatable;
    /// <summary>
    /// Function: MarkInterrogatable
    /// </summary>
    public unsafe override void MarkInterrogatable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MarkInterrogatable, "BmGame.RPawnVillain.MarkInterrogatable");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForAutoInformantScan;
    /// <summary>
    /// Function: CheckForAutoInformantScan
    /// </summary>
    public unsafe override void CheckForAutoInformantScan()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForAutoInformantScan, "BmGame.RPawnVillain.CheckForAutoInformantScan");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBeStartled;
    /// <summary>
    /// Function: CanBeStartled
    /// </summary>
    public unsafe virtual bool CanBeStartled(BmSDK.BmGame.RPawnCombat Batman)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeStartled, "BmGame.RPawnVillain.CanBeStartled");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Batman, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsInterrogatable;
    /// <summary>
    /// Function: IsInterrogatable
    /// </summary>
    public unsafe virtual bool IsInterrogatable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInterrogatable, "BmGame.RPawnVillain.IsInterrogatable");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsPotentiallyInterrogatable;
    /// <summary>
    /// Function: IsPotentiallyInterrogatable
    /// </summary>
    public unsafe override bool IsPotentiallyInterrogatable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPotentiallyInterrogatable, "BmGame.RPawnVillain.IsPotentiallyInterrogatable");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InitialiseInterrogation;
    /// <summary>
    /// Function: InitialiseInterrogation
    /// </summary>
    public unsafe override bool InitialiseInterrogation(BmSDK.BmGame.RSeqEvent_StartInterrogation InterrogEvent, BmSDK.BmGame.RSeqAct_PlaySpeechCombined SpeechAction, BmSDK.FString InterrogationName, BmSDK.FString InterrogationNameNoneLeft, bool _bCanInterrogateFromFront)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialiseInterrogation, "BmGame.RPawnVillain.InitialiseInterrogation");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterrogEvent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpeechAction, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterrogationName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterrogationNameNoneLeft, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_bCanInterrogateFromFront, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_SetNextInterrogationTrackIndex;
    /// <summary>
    /// Function: SetNextInterrogationTrackIndex
    /// </summary>
    public unsafe virtual void SetNextInterrogationTrackIndex(bool bGetNoneLeftOne = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNextInterrogationTrackIndex, "BmGame.RPawnVillain.SetNextInterrogationTrackIndex");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGetNoneLeftOne, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetInterrogationTrackPackageName;
    /// <summary>
    /// Function: GetInterrogationTrackPackageName
    /// </summary>
    public unsafe virtual BmSDK.FString GetInterrogationTrackPackageName(bool bGetNoneLeftOne = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInterrogationTrackPackageName, "BmGame.RPawnVillain.GetInterrogationTrackPackageName");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGetNoneLeftOne, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetInterrogationTrackIndex;
    /// <summary>
    /// Function: GetInterrogationTrackIndex
    /// </summary>
    public unsafe virtual int GetInterrogationTrackIndex(bool bGetNoneLeftOne = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInterrogationTrackIndex, "BmGame.RPawnVillain.GetInterrogationTrackIndex");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGetNoneLeftOne, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GrabStart;
    /// <summary>
    /// Function: GrabStart
    /// </summary>
    public unsafe virtual void GrabStart()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GrabStart, "BmGame.RPawnVillain.GrabStart");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReceivedNewEvent;
    /// <summary>
    /// Function: ReceivedNewEvent
    /// </summary>
    public unsafe override void ReceivedNewEvent(BmSDK.Engine.SequenceEvent Evt)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReceivedNewEvent, "BmGame.RPawnVillain.ReceivedNewEvent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Evt, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TargetGoRagdoll;
    /// <summary>
    /// Function: TargetGoRagdoll
    /// </summary>
    public unsafe virtual void TargetGoRagdoll()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TargetGoRagdoll, "BmGame.RPawnVillain.TargetGoRagdoll");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatAnimHit, "BmGame.RPawnVillain.CombatAnimHit");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GenericGoRagdoll;
    /// <summary>
    /// Function: GenericGoRagdoll
    /// </summary>
    public unsafe virtual void GenericGoRagdoll()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GenericGoRagdoll, "BmGame.RPawnVillain.GenericGoRagdoll");
        byte* paramsPtr = stackalloc byte[272];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceNonCombatSilentTakedown;
    /// <summary>
    /// Function: ForceNonCombatSilentTakedown
    /// </summary>
    public unsafe virtual bool ForceNonCombatSilentTakedown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceNonCombatSilentTakedown, "BmGame.RPawnVillain.ForceNonCombatSilentTakedown");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopGlueBlastTorsoEffect;
    /// <summary>
    /// Function: StopGlueBlastTorsoEffect
    /// </summary>
    public unsafe virtual void StopGlueBlastTorsoEffect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopGlueBlastTorsoEffect, "BmGame.RPawnVillain.StopGlueBlastTorsoEffect");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopGlueBlastLegEffectLeft;
    /// <summary>
    /// Function: StopGlueBlastLegEffectLeft
    /// </summary>
    public unsafe virtual void StopGlueBlastLegEffectLeft()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopGlueBlastLegEffectLeft, "BmGame.RPawnVillain.StopGlueBlastLegEffectLeft");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopGlueBlastLegEffectRight;
    /// <summary>
    /// Function: StopGlueBlastLegEffectRight
    /// </summary>
    public unsafe virtual void StopGlueBlastLegEffectRight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopGlueBlastLegEffectRight, "BmGame.RPawnVillain.StopGlueBlastLegEffectRight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSpecialMoveAnimset;
    /// <summary>
    /// Function: GetSpecialMoveAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetSpecialMoveAnimset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSpecialMoveAnimset, "BmGame.RPawnVillain.GetSpecialMoveAnimset");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DamagedByTakeDown;
    /// <summary>
    /// Function: DamagedByTakeDown
    /// </summary>
    public unsafe virtual void DamagedByTakeDown(BmSDK.BmGame.RPawnCombat.FDamageInfo Info, bool bIsNoisy)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamagedByTakeDown, "BmGame.RPawnVillain.DamagedByTakeDown");
        byte* paramsPtr = stackalloc byte[276];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Info, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsNoisy, paramsPtr + 256);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SawThrowFrom;
    /// <summary>
    /// Function: SawThrowFrom
    /// </summary>
    public unsafe virtual bool SawThrowFrom(System.Numerics.Vector3 ThrownFromPos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SawThrowFrom, "BmGame.RPawnVillain.SawThrowFrom");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_AllowAttackerTracking;
    /// <summary>
    /// Function: AllowAttackerTracking
    /// </summary>
    public unsafe virtual bool AllowAttackerTracking()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowAttackerTracking, "BmGame.RPawnVillain.AllowAttackerTracking");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanBeGlideKicked;
    /// <summary>
    /// Function: CanBeGlideKicked
    /// </summary>
    public unsafe override bool CanBeGlideKicked()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeGlideKicked, "BmGame.RPawnVillain.CanBeGlideKicked");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OverrideCanDodgeProjectile;
    /// <summary>
    /// Function: OverrideCanDodgeProjectile
    /// </summary>
    public unsafe virtual bool OverrideCanDodgeProjectile(System.Numerics.Vector3 ThrownFromPos, int CheckBatarangID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideCanDodgeProjectile, "BmGame.RPawnVillain.OverrideCanDodgeProjectile");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckBatarangID, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_SpawnSpecialWeaponDestroy;
    /// <summary>
    /// Function: SpawnSpecialWeaponDestroy
    /// </summary>
    public unsafe virtual bool SpawnSpecialWeaponDestroy(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnSpecialWeaponDestroy, "BmGame.RPawnVillain.SpawnSpecialWeaponDestroy");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SpawnSpecialStun;
    /// <summary>
    /// Function: SpawnSpecialStun
    /// </summary>
    public unsafe virtual bool SpawnSpecialStun(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnSpecialStun, "BmGame.RPawnVillain.SpawnSpecialStun");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SpawnSpecialAttack;
    /// <summary>
    /// Function: SpawnSpecialAttack
    /// </summary>
    public unsafe virtual bool SpawnSpecialAttack(BmSDK.BmGame.RPawnCombat PlayerPawn, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnSpecialAttack, "BmGame.RPawnVillain.SpawnSpecialAttack");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetDodgeClass;
    /// <summary>
    /// Function: GetDodgeClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetDodgeClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDodgeClass, "BmGame.RPawnVillain.GetDodgeClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_BlockAttack;
    /// <summary>
    /// Function: BlockAttack
    /// </summary>
    public unsafe virtual void BlockAttack(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlockAttack, "BmGame.RPawnVillain.BlockAttack");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PrepareToBlockAttack;
    /// <summary>
    /// Function: PrepareToBlockAttack
    /// </summary>
    public unsafe virtual void PrepareToBlockAttack(BmSDK.BmGame.RPawnCombat NewAttacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrepareToBlockAttack, "BmGame.RPawnVillain.PrepareToBlockAttack");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBlockDamageType;
    /// <summary>
    /// Function: CanBlockDamageType
    /// </summary>
    public unsafe override bool CanBlockDamageType(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBlockDamageType, "BmGame.RPawnVillain.CanBlockDamageType");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanBlock;
    /// <summary>
    /// Function: CanBlock
    /// </summary>
    public unsafe override bool CanBlock()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBlock, "BmGame.RPawnVillain.CanBlock");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TargettedBy;
    /// <summary>
    /// Function: TargettedBy
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.TargetStrikeResponse TargettedBy(BmSDK.BmGame.RPawnCombat NewAttacker, BmSDK.Class dmgType, bool bFar = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TargettedBy, "BmGame.RPawnVillain.TargettedBy");
        byte* paramsPtr = stackalloc byte[30];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFar, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.TargetStrikeResponse>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_PlayMultiAttackDialogue;
    /// <summary>
    /// Function: PlayMultiAttackDialogue
    /// </summary>
    public unsafe virtual void PlayMultiAttackDialogue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayMultiAttackDialogue, "BmGame.RPawnVillain.PlayMultiAttackDialogue");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetOverrideGlideKick;
    /// <summary>
    /// Function: GetOverrideGlideKick
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RSpecialMoveConfig GetOverrideGlideKick(BmSDK.BmGame.RPawnPlayer PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOverrideGlideKick, "BmGame.RPawnVillain.GetOverrideGlideKick");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OverrideRECMagnetReaction;
    /// <summary>
    /// Function: OverrideRECMagnetReaction
    /// </summary>
    public unsafe virtual bool OverrideRECMagnetReaction(BmSDK.Engine.Actor MagnetSource)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideRECMagnetReaction, "BmGame.RPawnVillain.OverrideRECMagnetReaction");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MagnetSource, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_RECFiredAtPawn;
    /// <summary>
    /// Function: RECFiredAtPawn
    /// </summary>
    public unsafe virtual bool RECFiredAtPawn(BmSDK.BmGame.RPawnPlayer PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RECFiredAtPawn, "BmGame.RPawnVillain.RECFiredAtPawn");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OverrideHarpoonHit;
    /// <summary>
    /// Function: OverrideHarpoonHit
    /// </summary>
    public unsafe virtual bool OverrideHarpoonHit(BmSDK.BmGame.RPawnPlayer PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideHarpoonHit, "BmGame.RPawnVillain.OverrideHarpoonHit");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SpawnOverrideTakedown;
    /// <summary>
    /// Function: SpawnOverrideTakedown
    /// </summary>
    public unsafe virtual bool SpawnOverrideTakedown(BmSDK.BmGame.RPawnCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnOverrideTakedown, "BmGame.RPawnVillain.SpawnOverrideTakedown");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SpawnMove;
    /// <summary>
    /// Function: SpawnMove
    /// </summary>
    public unsafe virtual void SpawnMove(BmSDK.Class MoveClass)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnMove, "BmGame.RPawnVillain.SpawnMove");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AdjustGunToMissTarget;
    /// <summary>
    /// Function: AdjustGunToMissTarget
    /// </summary>
    public unsafe virtual void AdjustGunToMissTarget(BmSDK.Engine.Actor TargetActor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdjustGunToMissTarget, "BmGame.RPawnVillain.AdjustGunToMissTarget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AdjustGunToHitTarget;
    /// <summary>
    /// Function: AdjustGunToHitTarget
    /// </summary>
    public unsafe virtual void AdjustGunToHitTarget(BmSDK.Engine.Actor TargetActor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdjustGunToHitTarget, "BmGame.RPawnVillain.AdjustGunToHitTarget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTrackTarget;
    /// <summary>
    /// Function: SetTrackTarget
    /// </summary>
    public unsafe virtual void SetTrackTarget(BmSDK.Engine.Actor NewTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTrackTarget, "BmGame.RPawnVillain.SetTrackTarget");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GunTick_TrackTarget;
    /// <summary>
    /// Function: GunTick_TrackTarget
    /// </summary>
    public unsafe virtual bool GunTick_TrackTarget(float DeltaTime, out BmSDK.BmGame.AlertInstance.VisibilityCategory AmountVisible, bool bCanFire)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GunTick_TrackTarget, "BmGame.RPawnVillain.GunTick_TrackTarget");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AmountVisible);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AmountVisible, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanFire, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        AmountVisible = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.AlertInstance.VisibilityCategory>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GunTick_Shooting;
    /// <summary>
    /// Function: GunTick_Shooting
    /// </summary>
    public unsafe virtual void GunTick_Shooting(bool bForceMiss, BmSDK.BmGame.AlertInstance.VisibilityCategory AmountVisible, bool bCanFire)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GunTick_Shooting, "BmGame.RPawnVillain.GunTick_Shooting");
        byte* paramsPtr = stackalloc byte[296];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceMiss, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AmountVisible, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanFire, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickGunFire;
    /// <summary>
    /// Function: TickGunFire
    /// </summary>
    public unsafe override void TickGunFire(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickGunFire, "BmGame.RPawnVillain.TickGunFire");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayRagdoll;
    /// <summary>
    /// Function: PlayRagdoll
    /// </summary>
    public unsafe virtual void PlayRagdoll(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo, BmSDK.BmGame.RGameInfo.RagdollStunType NewStunType = default, bool bKill = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayRagdoll, "BmGame.RPawnVillain.PlayRagdoll");
        byte* paramsPtr = stackalloc byte[280];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewStunType, paramsPtr + 256);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKill, paramsPtr + 260);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayHitReaction;
    /// <summary>
    /// Function: PlayHitReaction
    /// </summary>
    public unsafe virtual void PlayHitReaction(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHitReaction, "BmGame.RPawnVillain.PlayHitReaction");
        byte* paramsPtr = stackalloc byte[284];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetStunType;
    /// <summary>
    /// Function: GetStunType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.RagdollStunType GetStunType(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStunType, "BmGame.RPawnVillain.GetStunType");
        byte* paramsPtr = stackalloc byte[274];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.RagdollStunType>(paramsPtr + 256);
    }

    private static BmSDK.Function __fn_ProcessDamagedBy;
    /// <summary>
    /// Function: ProcessDamagedBy
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat.DamageResult ProcessDamagedBy(out BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessDamagedBy, "BmGame.RPawnVillain.ProcessDamagedBy");
        byte* paramsPtr = stackalloc byte[292];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DmgInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.FDamageInfo>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 256);
    }

    private static BmSDK.Function __fn_DemoteStrikeToQuickStrike;
    /// <summary>
    /// Function: DemoteStrikeToQuickStrike
    /// </summary>
    public unsafe virtual bool DemoteStrikeToQuickStrike(BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DemoteStrikeToQuickStrike, "BmGame.RPawnVillain.DemoteStrikeToQuickStrike");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ShouldGoRagdoll;
    /// <summary>
    /// Function: ShouldGoRagdoll
    /// </summary>
    public unsafe virtual bool ShouldGoRagdoll(BmSDK.Class dmgType, float DamageAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldGoRagdoll, "BmGame.RPawnVillain.ShouldGoRagdoll");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SpawnSmokeBombCombatMove;
    /// <summary>
    /// Function: SpawnSmokeBombCombatMove
    /// </summary>
    public unsafe virtual bool SpawnSmokeBombCombatMove(BmSDK.Class SmokeDamageType, float StunTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnSmokeBombCombatMove, "BmGame.RPawnVillain.SpawnSmokeBombCombatMove");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SmokeDamageType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StunTime, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetSmokeBombReactionClass;
    /// <summary>
    /// Function: GetSmokeBombReactionClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetSmokeBombReactionClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSmokeBombReactionClass, "BmGame.RPawnVillain.GetSmokeBombReactionClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBlockBreakerStunTime;
    /// <summary>
    /// Function: GetBlockBreakerStunTime
    /// </summary>
    public unsafe virtual float GetBlockBreakerStunTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBlockBreakerStunTime, "BmGame.RPawnVillain.GetBlockBreakerStunTime");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamagedBy, "BmGame.RPawnVillain.DamagedBy");
        byte* paramsPtr = stackalloc byte[280];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 256);
    }

    private static BmSDK.Function __fn_ForceOutOfAIvsAICombat;
    /// <summary>
    /// Function: ForceOutOfAIvsAICombat
    /// </summary>
    public unsafe virtual void ForceOutOfAIvsAICombat()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceOutOfAIvsAICombat, "BmGame.RPawnVillain.ForceOutOfAIvsAICombat");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateHitReactionWeaponConfig;
    /// <summary>
    /// Function: CreateHitReactionWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateHitReactionWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.FName CombatMovementStance, BmSDK.Engine.AnimSet AnimSet1, BmSDK.Engine.AnimSet AnimSet2 = default, BmSDK.Engine.AnimSet AnimSet3 = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateHitReactionWeaponConfig, "BmGame.RPawnVillain.CreateHitReactionWeaponConfig");
        byte* paramsPtr = stackalloc byte[4480];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatMovementStance, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet2, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet3, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_CreateRagdollWeaponConfig;
    /// <summary>
    /// Function: CreateRagdollWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateRagdollWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.Engine.AnimSet AnimSet1, BmSDK.Engine.AnimSet AnimSet2, BmSDK.Engine.AnimSet AnimSet3 = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateRagdollWeaponConfig, "BmGame.RPawnVillain.CreateRagdollWeaponConfig");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet2, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet3, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CreateWritheWeaponConfig;
    /// <summary>
    /// Function: CreateWritheWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateWritheWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.Engine.AnimSet AnimSet1)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateWritheWeaponConfig, "BmGame.RPawnVillain.CreateWritheWeaponConfig");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CreateBatmansBossWeaponConfig;
    /// <summary>
    /// Function: CreateBatmansBossWeaponConfig
    /// </summary>
    public unsafe virtual void CreateBatmansBossWeaponConfig(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateBatmansBossWeaponConfig, "BmGame.RPawnVillain.CreateBatmansBossWeaponConfig");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateAttackedWeaponConfig;
    /// <summary>
    /// Function: CreateAttackedWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateAttackedWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.Engine.AnimSet AnimSet1 = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateAttackedWeaponConfig, "BmGame.RPawnVillain.CreateAttackedWeaponConfig");
        byte* paramsPtr = stackalloc byte[384];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_WaitToGetUpFromRagdoll;
    /// <summary>
    /// Function: WaitToGetUpFromRagdoll
    /// </summary>
    public unsafe virtual bool WaitToGetUpFromRagdoll()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WaitToGetUpFromRagdoll, "BmGame.RPawnVillain.WaitToGetUpFromRagdoll");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StartGetUp;
    /// <summary>
    /// Function: StartGetUp
    /// </summary>
    public unsafe override void StartGetUp()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartGetUp, "BmGame.RPawnVillain.StartGetUp");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LadderTimeout;
    /// <summary>
    /// Function: LadderTimeout
    /// </summary>
    public unsafe virtual void LadderTimeout()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LadderTimeout, "BmGame.RPawnVillain.LadderTimeout");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsSkeleton;
    /// <summary>
    /// Function: IsSkeleton
    /// </summary>
    public unsafe virtual bool IsSkeleton()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSkeleton, "BmGame.RPawnVillain.IsSkeleton");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHeartBeatType;
    /// <summary>
    /// Function: GetHeartBeatType
    /// </summary>
    public unsafe virtual int GetHeartBeatType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeartBeatType, "BmGame.RPawnVillain.GetHeartBeatType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RecentGelDamage;
    /// <summary>
    /// Function: RecentGelDamage
    /// </summary>
    public unsafe virtual void RecentGelDamage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecentGelDamage, "BmGame.RPawnVillain.RecentGelDamage");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessKickedNoise;
    /// <summary>
    /// Function: ProcessKickedNoise
    /// </summary>
    public unsafe virtual void ProcessKickedNoise()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessKickedNoise, "BmGame.RPawnVillain.ProcessKickedNoise");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveAttractionIconWithDelay;
    /// <summary>
    /// Function: RemoveAttractionIconWithDelay
    /// </summary>
    public unsafe virtual void RemoveAttractionIconWithDelay(float Delay)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveAttractionIconWithDelay, "BmGame.RPawnVillain.RemoveAttractionIconWithDelay");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopAttractionFX;
    /// <summary>
    /// Function: StopAttractionFX
    /// </summary>
    public unsafe virtual void StopAttractionFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAttractionFX, "BmGame.RPawnVillain.StopAttractionFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartAttractionFX;
    /// <summary>
    /// Function: StartAttractionFX
    /// </summary>
    public unsafe virtual void StartAttractionFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAttractionFX, "BmGame.RPawnVillain.StartAttractionFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopTerrifiedFX;
    /// <summary>
    /// Function: StopTerrifiedFX
    /// </summary>
    public unsafe override void StopTerrifiedFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopTerrifiedFX, "BmGame.RPawnVillain.StopTerrifiedFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartTerrifiedFX;
    /// <summary>
    /// Function: StartTerrifiedFX
    /// </summary>
    public unsafe override void StartTerrifiedFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartTerrifiedFX, "BmGame.RPawnVillain.StartTerrifiedFX");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsTerrifiedFXNeeded;
    /// <summary>
    /// Function: IsTerrifiedFXNeeded
    /// </summary>
    public unsafe override bool IsTerrifiedFXNeeded()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTerrifiedFXNeeded, "BmGame.RPawnVillain.IsTerrifiedFXNeeded");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopGlideKickFX;
    /// <summary>
    /// Function: StopGlideKickFX
    /// </summary>
    public unsafe override void StopGlideKickFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopGlideKickFX, "BmGame.RPawnVillain.StopGlideKickFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartGlideKickFX;
    /// <summary>
    /// Function: StartGlideKickFX
    /// </summary>
    public unsafe override void StartGlideKickFX(BmSDK.Engine.ParticleSystem OverrideFX, BmSDK.BmGame.RPlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartGlideKickFX, "BmGame.RPawnVillain.StartGlideKickFX");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideFX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveCounterIcon;
    /// <summary>
    /// Function: RemoveCounterIcon
    /// </summary>
    public unsafe virtual void RemoveCounterIcon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveCounterIcon, "BmGame.RPawnVillain.RemoveCounterIcon");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopAttackingFX;
    /// <summary>
    /// Function: StopAttackingFX
    /// </summary>
    public unsafe virtual void StopAttackingFX(bool bSuccessfulCounter = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAttackingFX, "BmGame.RPawnVillain.StopAttackingFX");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSuccessfulCounter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartAttackingFX;
    /// <summary>
    /// Function: StartAttackingFX
    /// </summary>
    public unsafe virtual void StartAttackingFX(int CTypeInt, BmSDK.BmGame.RPlayerController PC = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAttackingFX, "BmGame.RPawnVillain.StartAttackingFX");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CTypeInt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetArmBandMineSynced;
    /// <summary>
    /// Function: SetArmBandMineSynced
    /// </summary>
    public unsafe virtual void SetArmBandMineSynced()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetArmBandMineSynced, "BmGame.RPawnVillain.SetArmBandMineSynced");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetArmBandNormal;
    /// <summary>
    /// Function: SetArmBandNormal
    /// </summary>
    public unsafe virtual void SetArmBandNormal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetArmBandNormal, "BmGame.RPawnVillain.SetArmBandNormal");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_YankMe;
    /// <summary>
    /// Function: YankMe
    /// </summary>
    public unsafe virtual void YankMe()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_YankMe, "BmGame.RPawnVillain.YankMe");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetOverlayAnim;
    /// <summary>
    /// Function: GetOverlayAnim
    /// </summary>
    public unsafe virtual BmSDK.FName GetOverlayAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOverlayAnim, "BmGame.RPawnVillain.GetOverlayAnim");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTauntAnim;
    /// <summary>
    /// Function: GetTauntAnim
    /// </summary>
    public unsafe override int GetTauntAnim(out BmSDK.FName AnimName, out BmSDK.Engine.AnimSet AnimSet, int LastTauntID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTauntAnim, "BmGame.RPawnVillain.GetTauntAnim");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AnimName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AnimSet);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LastTauntID, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AnimName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
        AnimSet = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ShouldDoStrungUpBark;
    /// <summary>
    /// Function: ShouldDoStrungUpBark
    /// </summary>
    public unsafe virtual bool ShouldDoStrungUpBark()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldDoStrungUpBark, "BmGame.RPawnVillain.ShouldDoStrungUpBark");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NotifyRopeCut;
    /// <summary>
    /// Function: NotifyRopeCut
    /// </summary>
    public unsafe virtual void NotifyRopeCut(BmSDK.BmGame.RBatarangProjectile Brang)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyRopeCut, "BmGame.RPawnVillain.NotifyRopeCut");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Brang, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopKicking;
    /// <summary>
    /// Function: StopKicking
    /// </summary>
    public unsafe override void StopKicking()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopKicking, "BmGame.RPawnVillain.StopKicking");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsLastCombatant;
    /// <summary>
    /// Function: IsLastCombatant
    /// </summary>
    public unsafe virtual bool IsLastCombatant()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLastCombatant, "BmGame.RPawnVillain.IsLastCombatant");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldCombatantForceCombatCamera;
    /// <summary>
    /// Function: ShouldCombatantForceCombatCamera
    /// </summary>
    public unsafe virtual bool ShouldCombatantForceCombatCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldCombatantForceCombatCamera, "BmGame.RPawnVillain.ShouldCombatantForceCombatCamera");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldCombatantLockDoors;
    /// <summary>
    /// Function: ShouldCombatantLockDoors
    /// </summary>
    public unsafe override bool ShouldCombatantLockDoors()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldCombatantLockDoors, "BmGame.RPawnVillain.ShouldCombatantLockDoors");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetIsCurrentCombatant;
    /// <summary>
    /// Function: SetIsCurrentCombatant
    /// </summary>
    public unsafe virtual bool SetIsCurrentCombatant()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIsCurrentCombatant, "BmGame.RPawnVillain.SetIsCurrentCombatant");
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

    private static BmSDK.Function __fn_AnimationTriggerCallback;
    /// <summary>
    /// Function: AnimationTriggerCallback
    /// </summary>
    public unsafe override void AnimationTriggerCallback(BmSDK.FName TagName, BmSDK.TArray<BmSDK.FString> Params, BmSDK.Engine.AnimSet TagAnimSet, float Time)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnimationTriggerCallback, "BmGame.RPawnVillain.AnimationTriggerCallback");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TagName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Params, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TagAnimSet, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckFalling;
    /// <summary>
    /// Function: CheckFalling
    /// </summary>
    public unsafe virtual void CheckFalling(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckFalling, "BmGame.RPawnVillain.CheckFalling");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanCheckFalling;
    /// <summary>
    /// Function: CanCheckFalling
    /// </summary>
    public unsafe virtual bool CanCheckFalling()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanCheckFalling, "BmGame.RPawnVillain.CanCheckFalling");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFallingPos;
    /// <summary>
    /// Function: GetFallingPos
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetFallingPos()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFallingPos, "BmGame.RPawnVillain.GetFallingPos");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_JustAboveFloor;
    /// <summary>
    /// Function: JustAboveFloor
    /// </summary>
    public unsafe virtual bool JustAboveFloor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_JustAboveFloor, "BmGame.RPawnVillain.JustAboveFloor");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CannotFindExtendedFloor;
    /// <summary>
    /// Function: CannotFindExtendedFloor
    /// </summary>
    public unsafe virtual bool CannotFindExtendedFloor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CannotFindExtendedFloor, "BmGame.RPawnVillain.CannotFindExtendedFloor");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CannotFindFloor;
    /// <summary>
    /// Function: CannotFindFloor
    /// </summary>
    public unsafe virtual bool CannotFindFloor(bool bCheckOnlyNavMesh = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CannotFindFloor, "BmGame.RPawnVillain.CannotFindFloor");
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheckOnlyNavMesh, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetPelvisVelocity;
    /// <summary>
    /// Function: GetPelvisVelocity
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetPelvisVelocity()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPelvisVelocity, "BmGame.RPawnVillain.GetPelvisVelocity");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsRagdollFalling;
    /// <summary>
    /// Function: IsRagdollFalling
    /// </summary>
    public unsafe virtual bool IsRagdollFalling()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRagdollFalling, "BmGame.RPawnVillain.IsRagdollFalling");
        byte* paramsPtr = stackalloc byte[24];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeHitInCombat, "BmGame.RPawnVillain.CanBeHitInCombat");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CanTakeSlideAttack;
    /// <summary>
    /// Function: CanTakeSlideAttack
    /// </summary>
    public unsafe virtual bool CanTakeSlideAttack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanTakeSlideAttack, "BmGame.RPawnVillain.CanTakeSlideAttack");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanReceiveSuperStun;
    /// <summary>
    /// Function: CanReceiveSuperStun
    /// </summary>
    public unsafe virtual bool CanReceiveSuperStun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanReceiveSuperStun, "BmGame.RPawnVillain.CanReceiveSuperStun");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBatClawPriority;
    /// <summary>
    /// Function: GetBatClawPriority
    /// </summary>
    public unsafe virtual float GetBatClawPriority()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatClawPriority, "BmGame.RPawnVillain.GetBatClawPriority");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBatarangSpeedBoost;
    /// <summary>
    /// Function: GetBatarangSpeedBoost
    /// </summary>
    public unsafe virtual float GetBatarangSpeedBoost()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatarangSpeedBoost, "BmGame.RPawnVillain.GetBatarangSpeedBoost");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ForceHitAtEndOfFlight;
    /// <summary>
    /// Function: ForceHitAtEndOfFlight
    /// </summary>
    public unsafe virtual bool ForceHitAtEndOfFlight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceHitAtEndOfFlight, "BmGame.RPawnVillain.ForceHitAtEndOfFlight");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBatarangPriority;
    /// <summary>
    /// Function: GetBatarangPriority
    /// </summary>
    public unsafe virtual float GetBatarangPriority()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatarangPriority, "BmGame.RPawnVillain.GetBatarangPriority");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsBatarangable;
    /// <summary>
    /// Function: IsBatarangable
    /// </summary>
    public unsafe virtual bool IsBatarangable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBatarangable, "BmGame.RPawnVillain.IsBatarangable");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetDamageTarget;
    /// <summary>
    /// Function: SetDamageTarget
    /// </summary>
    public unsafe virtual void SetDamageTarget(BmSDK.Engine.Actor NewTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDamageTarget, "BmGame.RPawnVillain.SetDamageTarget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetEnemyPos;
    /// <summary>
    /// Function: SetEnemyPos
    /// </summary>
    public unsafe virtual void SetEnemyPos(System.Numerics.Vector3 NewELocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEnemyPos, "BmGame.RPawnVillain.SetEnemyPos");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewELocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBatmanGrab;
    /// <summary>
    /// Function: CanBatmanGrab
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMAIController.BatmanGrabType CanBatmanGrab()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBatmanGrab, "BmGame.RPawnVillain.CanBatmanGrab");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMAIController.BatmanGrabType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DoHitDamage;
    /// <summary>
    /// Function: DoHitDamage
    /// </summary>
    public unsafe virtual void DoHitDamage(BmSDK.BmGame.RKActorSpawnable ColidingObject)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoHitDamage, "BmGame.RPawnVillain.DoHitDamage");
        byte* paramsPtr = stackalloc byte[300];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ColidingObject, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Bump;
    /// <summary>
    /// Function: Bump
    /// </summary>
    public unsafe override void Bump(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Bump, "BmGame.RPawnVillain.Bump");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Touch;
    /// <summary>
    /// Function: Touch
    /// </summary>
    public unsafe override void Touch(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Touch, "BmGame.RPawnVillain.Touch");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EncroachedBy;
    /// <summary>
    /// Function: EncroachedBy
    /// </summary>
    public unsafe override void EncroachedBy(BmSDK.Engine.Actor Other)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EncroachedBy, "BmGame.RPawnVillain.EncroachedBy");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBatarangTargetPosition;
    /// <summary>
    /// Function: GetBatarangTargetPosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetBatarangTargetPosition(System.Numerics.Vector3 AimLocation, System.Numerics.Vector3 AimDirection, bool bDuringTargetPhase = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatarangTargetPosition, "BmGame.RPawnVillain.GetBatarangTargetPosition");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimDirection, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDuringTargetPhase, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_GetGlanceScore;
    /// <summary>
    /// Function: GetGlanceScore
    /// </summary>
    public unsafe virtual int GetGlanceScore()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGlanceScore, "BmGame.RPawnVillain.GetGlanceScore");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRagdollClass;
    /// <summary>
    /// Function: GetRagdollClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetRagdollClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRagdollClass, "BmGame.RPawnVillain.GetRagdollClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DoRBFallAlert;
    /// <summary>
    /// Function: DoRBFallAlert
    /// </summary>
    public unsafe override void DoRBFallAlert()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoRBFallAlert, "BmGame.RPawnVillain.DoRBFallAlert");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayDying;
    /// <summary>
    /// Function: PlayDying
    /// </summary>
    public unsafe override void PlayDying(BmSDK.Class DamageType, System.Numerics.Vector3 HitLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayDying, "BmGame.RPawnVillain.PlayDying");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLoc, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideCatJewelBar;
    /// <summary>
    /// Function: HideCatJewelBar
    /// </summary>
    public unsafe virtual void HideCatJewelBar()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideCatJewelBar, "BmGame.RPawnVillain.HideCatJewelBar");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Died, "BmGame.RPawnVillain.Died");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_TriggerCatwomanJewellery;
    /// <summary>
    /// Function: TriggerCatwomanJewellery
    /// </summary>
    public unsafe virtual void TriggerCatwomanJewellery(int OutputIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCatwomanJewellery, "BmGame.RPawnVillain.TriggerCatwomanJewellery");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutputIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DelayedAwardXP;
    /// <summary>
    /// Function: DelayedAwardXP
    /// </summary>
    public unsafe virtual void DelayedAwardXP()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DelayedAwardXP, "BmGame.RPawnVillain.DelayedAwardXP");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AwardXP;
    /// <summary>
    /// Function: AwardXP
    /// </summary>
    public unsafe virtual void AwardXP(BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AwardXP, "BmGame.RPawnVillain.AwardXP");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGoodAsDead;
    /// <summary>
    /// Function: SetGoodAsDead
    /// </summary>
    public unsafe virtual void SetGoodAsDead()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGoodAsDead, "BmGame.RPawnVillain.SetGoodAsDead");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AwardRingOut;
    /// <summary>
    /// Function: AwardRingOut
    /// </summary>
    public unsafe virtual void AwardRingOut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AwardRingOut, "BmGame.RPawnVillain.AwardRingOut");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KillByFall;
    /// <summary>
    /// Function: KillByFall
    /// </summary>
    public unsafe virtual void KillByFall()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillByFall, "BmGame.RPawnVillain.KillByFall");
        byte* paramsPtr = stackalloc byte[284];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReactingToCaltrops;
    /// <summary>
    /// Function: ReactingToCaltrops
    /// </summary>
    public unsafe virtual bool ReactingToCaltrops()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReactingToCaltrops, "BmGame.RPawnVillain.ReactingToCaltrops");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RagdollCaltrops;
    /// <summary>
    /// Function: RagdollCaltrops
    /// </summary>
    public unsafe virtual void RagdollCaltrops()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RagdollCaltrops, "BmGame.RPawnVillain.RagdollCaltrops");
        byte* paramsPtr = stackalloc byte[272];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RagdollKillLow;
    /// <summary>
    /// Function: RagdollKillLow
    /// </summary>
    public unsafe virtual void RagdollKillLow()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RagdollKillLow, "BmGame.RPawnVillain.RagdollKillLow");
        byte* paramsPtr = stackalloc byte[272];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RagdollKill;
    /// <summary>
    /// Function: RagdollKill
    /// </summary>
    public unsafe virtual void RagdollKill()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RagdollKill, "BmGame.RPawnVillain.RagdollKill");
        byte* paramsPtr = stackalloc byte[272];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickRagdollState;
    /// <summary>
    /// Function: TickRagdollState
    /// </summary>
    public unsafe virtual void TickRagdollState(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickRagdollState, "BmGame.RPawnVillain.TickRagdollState");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_RigidBodyCollision;
    /// <summary>
    /// Function: RigidBodyCollision
    /// </summary>
    public unsafe override void RigidBodyCollision(BmSDK.Engine.PrimitiveComponent HitComponent, BmSDK.Engine.PrimitiveComponent OtherComponent, in BmSDK.Engine.Actor.FCollisionImpactData RigidCollisionData, int ContactIndex, float Speed, int Index0, int Index1)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RigidBodyCollision, "BmGame.RPawnVillain.RigidBodyCollision");
        byte* paramsPtr = stackalloc byte[352];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitComponent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComponent, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RigidCollisionData, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContactIndex, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index0, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index1, paramsPtr + 56);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeDamage, "BmGame.RPawnVillain.TakeDamage");
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

    private static BmSDK.Function __fn_MulticastHitByWhip;
    /// <summary>
    /// Function: MulticastHitByWhip
    /// </summary>
    public unsafe virtual void MulticastHitByWhip(int Damage, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.FName BoneName, BmSDK.FName BoneName2, BmSDK.BmGame.RPawnPlayer Player = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MulticastHitByWhip, "BmGame.RPawnVillain.MulticastHitByWhip");
        byte* paramsPtr = stackalloc byte[328];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneName, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneName2, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HitByBatarang;
    /// <summary>
    /// Function: HitByBatarang
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat.DamageResult HitByBatarang(int Damage, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitByBatarang, "BmGame.RPawnVillain.HitByBatarang");
        byte* paramsPtr = stackalloc byte[420];
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

    private static BmSDK.Function __fn_GetDefaultHitReactionClass;
    /// <summary>
    /// Function: GetDefaultHitReactionClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetDefaultHitReactionClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultHitReactionClass, "BmGame.RPawnVillain.GetDefaultHitReactionClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CantCombo;
    /// <summary>
    /// Function: CantCombo
    /// </summary>
    public unsafe virtual bool CantCombo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CantCombo, "BmGame.RPawnVillain.CantCombo");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ImmuneToBatarang;
    /// <summary>
    /// Function: ImmuneToBatarang
    /// </summary>
    public unsafe virtual bool ImmuneToBatarang(BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ImmuneToBatarang, "BmGame.RPawnVillain.ImmuneToBatarang");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IgnoreOffscreenCheckForOverrideGadgetTarget;
    /// <summary>
    /// Function: IgnoreOffscreenCheckForOverrideGadgetTarget
    /// </summary>
    public unsafe virtual bool IgnoreOffscreenCheckForOverrideGadgetTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IgnoreOffscreenCheckForOverrideGadgetTarget, "BmGame.RPawnVillain.IgnoreOffscreenCheckForOverrideGadgetTarget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DestroySelf;
    /// <summary>
    /// Function: DestroySelf
    /// </summary>
    public unsafe virtual void DestroySelf()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroySelf, "BmGame.RPawnVillain.DestroySelf");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyPawnDead;
    /// <summary>
    /// Function: NotifyPawnDead
    /// </summary>
    public unsafe virtual void NotifyPawnDead()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyPawnDead, "BmGame.RPawnVillain.NotifyPawnDead");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RPawnVillain.Destroyed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreStreamOut;
    /// <summary>
    /// Function: PreStreamOut
    /// </summary>
    public unsafe override void PreStreamOut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmGame.RPawnVillain.PreStreamOut");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChooseEmotes;
    /// <summary>
    /// Function: ChooseEmotes
    /// </summary>
    public unsafe virtual void ChooseEmotes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChooseEmotes, "BmGame.RPawnVillain.ChooseEmotes");
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

    private static BmSDK.Function __fn_ChooseBarksets;
    /// <summary>
    /// Function: ChooseBarksets
    /// </summary>
    public unsafe virtual void ChooseBarksets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChooseBarksets, "BmGame.RPawnVillain.ChooseBarksets");
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

    private static BmSDK.Function __fn_ChooseThugId;
    /// <summary>
    /// Function: ChooseThugId
    /// </summary>
    public unsafe virtual void ChooseThugId()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChooseThugId, "BmGame.RPawnVillain.ChooseThugId");
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

    private static BmSDK.Function __fn_PostInitCharacter;
    /// <summary>
    /// Function: PostInitCharacter
    /// </summary>
    public unsafe override void PostInitCharacter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostInitCharacter, "BmGame.RPawnVillain.PostInitCharacter");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetIsValidCombatant;
    /// <summary>
    /// Function: SetIsValidCombatant
    /// </summary>
    public unsafe override void SetIsValidCombatant(bool bNewValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIsValidCombatant, "BmGame.RPawnVillain.SetIsValidCombatant");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RPawnVillain.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HitWater;
    /// <summary>
    /// Function: HitWater
    /// </summary>
    public unsafe virtual void HitWater()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitWater, "BmGame.RPawnVillain.HitWater");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SplashSoundAndDestroy;
    /// <summary>
    /// Function: SplashSoundAndDestroy
    /// </summary>
    public unsafe virtual void SplashSoundAndDestroy()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SplashSoundAndDestroy, "BmGame.RPawnVillain.SplashSoundAndDestroy");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RecentlyOnScreen;
    /// <summary>
    /// Function: RecentlyOnScreen
    /// </summary>
    public unsafe virtual bool RecentlyOnScreen()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecentlyOnScreen, "BmGame.RPawnVillain.RecentlyOnScreen");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlaySound_Falling;
    /// <summary>
    /// Function: PlaySound_Falling
    /// </summary>
    public unsafe virtual void PlaySound_Falling()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySound_Falling, "BmGame.RPawnVillain.PlaySound_Falling");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySound_GlideKicked;
    /// <summary>
    /// Function: PlaySound_GlideKicked
    /// </summary>
    public unsafe virtual void PlaySound_GlideKicked()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySound_GlideKicked, "BmGame.RPawnVillain.PlaySound_GlideKicked");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySound_LineLaunchKicked;
    /// <summary>
    /// Function: PlaySound_LineLaunchKicked
    /// </summary>
    public unsafe virtual void PlaySound_LineLaunchKicked()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySound_LineLaunchKicked, "BmGame.RPawnVillain.PlaySound_LineLaunchKicked");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySound_Exploded;
    /// <summary>
    /// Function: PlaySound_Exploded
    /// </summary>
    public unsafe virtual void PlaySound_Exploded()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySound_Exploded, "BmGame.RPawnVillain.PlaySound_Exploded");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySound_Batclawed;
    /// <summary>
    /// Function: PlaySound_Batclawed
    /// </summary>
    public unsafe virtual void PlaySound_Batclawed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySound_Batclawed, "BmGame.RPawnVillain.PlaySound_Batclawed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySound_Bataranged;
    /// <summary>
    /// Function: PlaySound_Bataranged
    /// </summary>
    public unsafe virtual void PlaySound_Bataranged(bool bHead, bool bKnockOver)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySound_Bataranged, "BmGame.RPawnVillain.PlaySound_Bataranged");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHead, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKnockOver, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySound_HitByThrownThug;
    /// <summary>
    /// Function: PlaySound_HitByThrownThug
    /// </summary>
    public unsafe virtual void PlaySound_HitByThrownThug()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySound_HitByThrownThug, "BmGame.RPawnVillain.PlaySound_HitByThrownThug");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySound_ThrowPickup;
    /// <summary>
    /// Function: PlaySound_ThrowPickup
    /// </summary>
    public unsafe virtual void PlaySound_ThrowPickup()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySound_ThrowPickup, "BmGame.RPawnVillain.PlaySound_ThrowPickup");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySound_Splash;
    /// <summary>
    /// Function: PlaySound_Splash
    /// </summary>
    public unsafe virtual void PlaySound_Splash()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySound_Splash, "BmGame.RPawnVillain.PlaySound_Splash");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartMonitoringRagdollVelocity;
    /// <summary>
    /// Function: StartMonitoringRagdollVelocity
    /// </summary>
    public unsafe virtual void StartMonitoringRagdollVelocity()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartMonitoringRagdollVelocity, "BmGame.RPawnVillain.StartMonitoringRagdollVelocity");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBossTakedown;
    /// <summary>
    /// Function: GetBossTakedown
    /// </summary>
    public unsafe virtual BmSDK.Class GetBossTakedown(BmSDK.BmGame.MStealthTakeDownStagePlayerConfig.EStealthTakeDownStages takedown_stage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBossTakedown, "BmGame.RPawnVillain.GetBossTakedown");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takedown_stage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CanDeadshotRope;
    /// <summary>
    /// Function: CanDeadshotRope
    /// </summary>
    public unsafe virtual bool CanDeadshotRope(BmSDK.BmGame.MDualClawClusterProjectile clusterProj)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDeadshotRope, "BmGame.RPawnVillain.CanDeadshotRope");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(clusterProj, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsVulnerableToTakedown;
    /// <summary>
    /// Function: IsVulnerableToTakedown
    /// </summary>
    public unsafe virtual bool IsVulnerableToTakedown(BmSDK.FString takedown)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsVulnerableToTakedown, "BmGame.RPawnVillain.IsVulnerableToTakedown");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takedown, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_IsVulnerableToStunStrike;
    /// <summary>
    /// Function: IsVulnerableToStunStrike
    /// </summary>
    public unsafe virtual bool IsVulnerableToStunStrike()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsVulnerableToStunStrike, "BmGame.RPawnVillain.IsVulnerableToStunStrike");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_BossCanTakeGooHit;
    /// <summary>
    /// Function: BossCanTakeGooHit
    /// </summary>
    public unsafe virtual bool BossCanTakeGooHit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BossCanTakeGooHit, "BmGame.RPawnVillain.BossCanTakeGooHit");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsBoss;
    /// <summary>
    /// Function: IsBoss
    /// </summary>
    public unsafe virtual bool IsBoss()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBoss, "BmGame.RPawnVillain.IsBoss");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetTargetPawn;
    /// <summary>
    /// Function: SetTargetPawn
    /// </summary>
    public unsafe virtual void SetTargetPawn(BmSDK.BmGame.RPawnCombat NewTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTargetPawn, "BmGame.RPawnVillain.SetTargetPawn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetForcedBeatDownStrikeNo;
    /// <summary>
    /// Function: GetForcedBeatDownStrikeNo
    /// </summary>
    public unsafe virtual int GetForcedBeatDownStrikeNo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetForcedBeatDownStrikeNo, "BmGame.RPawnVillain.GetForcedBeatDownStrikeNo");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldForceBeatDownEnd;
    /// <summary>
    /// Function: ShouldForceBeatDownEnd
    /// </summary>
    public unsafe virtual bool ShouldForceBeatDownEnd()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldForceBeatDownEnd, "BmGame.RPawnVillain.ShouldForceBeatDownEnd");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldForceBeatDown;
    /// <summary>
    /// Function: ShouldForceBeatDown
    /// </summary>
    public unsafe virtual bool ShouldForceBeatDown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldForceBeatDown, "BmGame.RPawnVillain.ShouldForceBeatDown");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetHealth;
    /// <summary>
    /// Function: SetHealth
    /// </summary>
    public unsafe virtual void SetHealth()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHealth, "BmGame.RPawnVillain.SetHealth");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetOverrideStrikeInfo;
    /// <summary>
    /// Function: GetOverrideStrikeInfo
    /// </summary>
    public unsafe virtual void GetOverrideStrikeInfo(BmSDK.BmGame.RPawnVillain PrevTarget, float StrikeDamage, out BmSDK.BmGame.RPawnPlayerCombat.StrikeRange CurrRange, out BmSDK.BmGame.RPawnPlayerCombat.StrikeStrength CurrStrength)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOverrideStrikeInfo, "BmGame.RPawnVillain.GetOverrideStrikeInfo");
        byte* paramsPtr = stackalloc byte[26];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PrevTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeDamage, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CurrRange);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrRange, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CurrStrength);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrStrength, paramsPtr + 9);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CurrRange = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayerCombat.StrikeRange>(paramsPtr + 8);
        CurrStrength = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayerCombat.StrikeStrength>(paramsPtr + 9);
        return;
    }

    private static BmSDK.Function __fn_GetGrenadeSpawnOffset;
    /// <summary>
    /// Function: GetGrenadeSpawnOffset
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetGrenadeSpawnOffset(BmSDK.Rotator PawnLaunchRot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGrenadeSpawnOffset, "BmGame.RPawnVillain.GetGrenadeSpawnOffset");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnLaunchRot, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_IsInCurrentPredatorVolume;
    /// <summary>
    /// Function: IsInCurrentPredatorVolume
    /// </summary>
    public unsafe virtual bool IsInCurrentPredatorVolume()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInCurrentPredatorVolume, "BmGame.RPawnVillain.IsInCurrentPredatorVolume");
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

    private static BmSDK.Function __fn_IsPawnRunningAwayFromMe;
    /// <summary>
    /// Function: IsPawnRunningAwayFromMe
    /// </summary>
    public unsafe virtual bool IsPawnRunningAwayFromMe(BmSDK.Engine.Pawn TestPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPawnRunningAwayFromMe, "BmGame.RPawnVillain.IsPawnRunningAwayFromMe");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
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

    private static BmSDK.Function __fn_TryGetGrenadeThrowVelocity;
    /// <summary>
    /// Function: TryGetGrenadeThrowVelocity
    /// </summary>
    public unsafe virtual bool TryGetGrenadeThrowVelocity(out System.Numerics.Vector3 ThrowVelocity, out float FlightTime, System.Numerics.Vector3 Target, System.Numerics.Vector3 OverrideSpawnPoint = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryGetGrenadeThrowVelocity, "BmGame.RPawnVillain.TryGetGrenadeThrowVelocity");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ThrowVelocity);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowVelocity, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out FlightTime);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlightTime, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideSpawnPoint, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ThrowVelocity = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        FlightTime = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_DeRegisterPairedAnimsets;
    /// <summary>
    /// Function: DeRegisterPairedAnimsets
    /// </summary>
    public unsafe virtual void DeRegisterPairedAnimsets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeRegisterPairedAnimsets, "BmGame.RPawnVillain.DeRegisterPairedAnimsets");
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

    private static BmSDK.Function __fn_MonitorRagdollForHighVelocity;
    /// <summary>
    /// Function: MonitorRagdollForHighVelocity
    /// </summary>
    public unsafe virtual void MonitorRagdollForHighVelocity(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MonitorRagdollForHighVelocity, "BmGame.RPawnVillain.MonitorRagdollForHighVelocity");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_CheckForNeedToMonitorPawnVelocity;
    /// <summary>
    /// Function: CheckForNeedToMonitorPawnVelocity
    /// </summary>
    public unsafe virtual void CheckForNeedToMonitorPawnVelocity()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForNeedToMonitorPawnVelocity, "BmGame.RPawnVillain.CheckForNeedToMonitorPawnVelocity");
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

    private static BmSDK.Function __fn_IsRictusGrinInfected;
    /// <summary>
    /// Function: IsRictusGrinInfected
    /// </summary>
    public unsafe virtual bool IsRictusGrinInfected()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRictusGrinInfected, "BmGame.RPawnVillain.IsRictusGrinInfected");
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

    private static BmSDK.Function __fn_IsIncapacitated;
    /// <summary>
    /// Function: IsIncapacitated
    /// </summary>
    public unsafe override bool IsIncapacitated()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsIncapacitated, "BmGame.RPawnVillain.IsIncapacitated");
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

    private static BmSDK.Function __fn_SwitchingPlayerCharacter;
    /// <summary>
    /// Function: SwitchingPlayerCharacter
    /// </summary>
    public unsafe virtual void SwitchingPlayerCharacter(BmSDK.FString NewCharacterName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchingPlayerCharacter, "BmGame.RPawnVillain.SwitchingPlayerCharacter");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCharacterName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReloadPlayerSpecificAnimsets;
    /// <summary>
    /// Function: ReloadPlayerSpecificAnimsets
    /// </summary>
    public unsafe virtual void ReloadPlayerSpecificAnimsets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReloadPlayerSpecificAnimsets, "BmGame.RPawnVillain.ReloadPlayerSpecificAnimsets");
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

    private static BmSDK.Function __fn_ClearPlayerSpecificAnimsets;
    /// <summary>
    /// Function: ClearPlayerSpecificAnimsets
    /// </summary>
    public unsafe virtual void ClearPlayerSpecificAnimsets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPlayerSpecificAnimsets, "BmGame.RPawnVillain.ClearPlayerSpecificAnimsets");
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

    private static BmSDK.Function __fn_LoadPairedAnimsetForPlayer;
    /// <summary>
    /// Function: LoadPairedAnimsetForPlayer
    /// </summary>
    public unsafe virtual bool LoadPairedAnimsetForPlayer(bool bNonOWAnims)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadPairedAnimsetForPlayer, "BmGame.RPawnVillain.LoadPairedAnimsetForPlayer");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNonOWAnims, paramsPtr + 0);
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

    private static BmSDK.Function __fn_CancelEmoteLoading;
    /// <summary>
    /// Function: CancelEmoteLoading
    /// </summary>
    public unsafe virtual void CancelEmoteLoading()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelEmoteLoading, "BmGame.RPawnVillain.CancelEmoteLoading");
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

    private static BmSDK.Function __fn_InitEmotes;
    /// <summary>
    /// Function: InitEmotes
    /// </summary>
    public unsafe virtual bool InitEmotes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitEmotes, "BmGame.RPawnVillain.InitEmotes");
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

    private static BmSDK.Function __fn_LoadEmotes;
    /// <summary>
    /// Function: LoadEmotes
    /// </summary>
    public unsafe virtual bool LoadEmotes(BmSDK.FString Emotes)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadEmotes, "BmGame.RPawnVillain.LoadEmotes");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Emotes, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CancelBarkSetLoading;
    /// <summary>
    /// Function: CancelBarkSetLoading
    /// </summary>
    public unsafe virtual void CancelBarkSetLoading()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelBarkSetLoading, "BmGame.RPawnVillain.CancelBarkSetLoading");
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

    private static BmSDK.Function __fn_InitBarkSet;
    /// <summary>
    /// Function: InitBarkSet
    /// </summary>
    public unsafe virtual bool InitBarkSet()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitBarkSet, "BmGame.RPawnVillain.InitBarkSet");
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

    private static BmSDK.Function __fn_LoadBarkSet;
    /// <summary>
    /// Function: LoadBarkSet
    /// </summary>
    public unsafe virtual bool LoadBarkSet(BmSDK.FString BarkSetString, bool bPreffered = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadBarkSet, "BmGame.RPawnVillain.LoadBarkSet");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkSetString, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPreffered, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ReplicatedEvent;
    /// <summary>
    /// Function: ReplicatedEvent
    /// </summary>
    public unsafe override void ReplicatedEvent(BmSDK.FName VarName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplicatedEvent, "BmGame.RPawnVillain.ReplicatedEvent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveStuckWeapons;
    /// <summary>
    /// Function: RemoveStuckWeapons
    /// </summary>
    public unsafe virtual void RemoveStuckWeapons()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveStuckWeapons, "BmGame.RPawnVillain.RemoveStuckWeapons");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachSkeletalProps;
    /// <summary>
    /// Function: AttachSkeletalProps
    /// </summary>
    public unsafe override void AttachSkeletalProps()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachSkeletalProps, "BmGame.RPawnVillain.AttachSkeletalProps");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DropProps;
    /// <summary>
    /// Function: DropProps
    /// </summary>
    public unsafe virtual void DropProps()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DropProps, "BmGame.RPawnVillain.DropProps");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoKismetAttachment;
    /// <summary>
    /// Function: DoKismetAttachment
    /// </summary>
    public unsafe override void DoKismetAttachment(BmSDK.Engine.Actor Attachment, BmSDK.Engine.SeqAct_AttachToActor Action)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoKismetAttachment, "BmGame.RPawnVillain.DoKismetAttachment");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attachment, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldRagdollAfterDualClawPull;
    /// <summary>
    /// Function: ShouldRagdollAfterDualClawPull
    /// </summary>
    public unsafe virtual bool ShouldRagdollAfterDualClawPull()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldRagdollAfterDualClawPull, "BmGame.RPawnVillain.ShouldRagdollAfterDualClawPull");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetUpAfterHitFloorDelay;
    /// <summary>
    /// Function: GetUpAfterHitFloorDelay
    /// </summary>
    public unsafe override float GetUpAfterHitFloorDelay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUpAfterHitFloorDelay, "BmGame.RPawnVillain.GetUpAfterHitFloorDelay");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldTargetOnTakedown;
    /// <summary>
    /// Function: ShouldTargetOnTakedown
    /// </summary>
    public unsafe virtual bool ShouldTargetOnTakedown(BmSDK.BmGame.RPawnPlayer PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldTargetOnTakedown, "BmGame.RPawnVillain.ShouldTargetOnTakedown");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ShouldStopControllableBatarang;
    /// <summary>
    /// Function: ShouldStopControllableBatarang
    /// </summary>
    public unsafe virtual bool ShouldStopControllableBatarang()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldStopControllableBatarang, "BmGame.RPawnVillain.ShouldStopControllableBatarang");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldShowGadgetHUD;
    /// <summary>
    /// Function: ShouldShowGadgetHUD
    /// </summary>
    public unsafe virtual bool ShouldShowGadgetHUD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldShowGadgetHUD, "BmGame.RPawnVillain.ShouldShowGadgetHUD");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ResetForceBeatDown;
    /// <summary>
    /// Function: ResetForceBeatDown
    /// </summary>
    public unsafe virtual void ResetForceBeatDown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetForceBeatDown, "BmGame.RPawnVillain.ResetForceBeatDown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateForceBeatDown;
    /// <summary>
    /// Function: ActivateForceBeatDown
    /// </summary>
    public unsafe virtual void ActivateForceBeatDown(float mActivationTimer = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateForceBeatDown, "BmGame.RPawnVillain.ActivateForceBeatDown");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(mActivationTimer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsAwareOfPlayer;
    /// <summary>
    /// Function: IsAwareOfPlayer
    /// </summary>
    public unsafe virtual bool IsAwareOfPlayer(BmSDK.BmGame.RPawnPlayer PlayerPawn, BmSDK.Class dmgType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAwareOfPlayer, "BmGame.RPawnVillain.IsAwareOfPlayer");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
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

    private static BmSDK.Function __fn_CheckGlassBehindActor;
    /// <summary>
    /// Function: CheckGlassBehindActor
    /// </summary>
    public unsafe virtual bool CheckGlassBehindActor(float MaxDistance, out BmSDK.Engine.Actor FractureWall)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckGlassBehindActor, "BmGame.RPawnVillain.CheckGlassBehindActor");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxDistance, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out FractureWall);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FractureWall, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        FractureWall = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ScriptCustomCalcVisibility;
    /// <summary>
    /// Function: ScriptCustomCalcVisibility
    /// </summary>
    public unsafe virtual BmSDK.BmGame.AlertInstance.VisibilityCategory ScriptCustomCalcVisibility(BmSDK.BmGame.RBMAIController CheckController)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScriptCustomCalcVisibility, "BmGame.RPawnVillain.ScriptCustomCalcVisibility");
        byte* paramsPtr = stackalloc byte[21];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckController, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.AlertInstance.VisibilityCategory>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetWeaponAudioSwitch;
    /// <summary>
    /// Function: SetWeaponAudioSwitch
    /// </summary>
    public unsafe virtual void SetWeaponAudioSwitch()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWeaponAudioSwitch, "BmGame.RPawnVillain.SetWeaponAudioSwitch");
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

    private static BmSDK.Function __fn_OnAudioSourceCreate;
    /// <summary>
    /// Function: OnAudioSourceCreate
    /// </summary>
    public unsafe override void OnAudioSourceCreate(BmSDK.Engine.AkComponent akComp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAudioSourceCreate, "BmGame.RPawnVillain.OnAudioSourceCreate");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(akComp, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetCurrentPylon;
    /// <summary>
    /// Function: SetCurrentPylon
    /// </summary>
    public unsafe virtual void SetCurrentPylon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentPylon, "BmGame.RPawnVillain.SetCurrentPylon");
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

    private static BmSDK.Function __fn_CanBeSeenByBatsForXray;
    /// <summary>
    /// Function: CanBeSeenByBatsForXray
    /// </summary>
    public unsafe override bool CanBeSeenByBatsForXray()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeSeenByBatsForXray, "BmGame.RPawnVillain.CanBeSeenByBatsForXray");
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

    /// <summary>
    /// StructProperty: VfTable_IRSpotableInterface
    /// </summary>
    public unsafe System.IntPtr VfTable_IRSpotableInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 3320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3320); }
    }

    /// <summary>
    /// ObjectProperty: V2TakenDownCoordinator
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_CasualtyBase V2TakenDownCoordinator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_CasualtyBase>(Ptr + 3324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3324); }
    }

    /// <summary>
    /// BoolProperty: bPlayedFallingSound
    /// </summary>
    public unsafe bool bPlayedFallingSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bDiedAlready
    /// </summary>
    public unsafe bool bDiedAlready
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bBeingTakenDown
    /// </summary>
    public unsafe bool bBeingTakenDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bCanReactTakedown
    /// </summary>
    public unsafe bool bCanReactTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bDisableSelfHarm
    /// </summary>
    public unsafe bool bDisableSelfHarm
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bAwardXPOnDeath
    /// </summary>
    public unsafe bool bAwardXPOnDeath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bAwardedRingOut
    /// </summary>
    public unsafe bool bAwardedRingOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bAwardedXP
    /// </summary>
    public unsafe bool bAwardedXP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bCanDieByFalling
    /// </summary>
    public unsafe bool bCanDieByFalling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bStopSpeechOnDeath
    /// </summary>
    public unsafe bool bStopSpeechOnDeath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bStopDialogueWhenHit
    /// </summary>
    public unsafe bool bStopDialogueWhenHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bAwardDeathScore
    /// </summary>
    public unsafe bool bAwardDeathScore
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bFlee
    /// </summary>
    public unsafe bool bFlee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bNeverFlee
    /// </summary>
    public unsafe bool bNeverFlee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bDontAlertPawnsInOtherPylons
    /// </summary>
    public unsafe bool bDontAlertPawnsInOtherPylons
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bForceNonCombatSilentTakedown
    /// </summary>
    public unsafe bool bForceNonCombatSilentTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bPreventPredatorTakedownCam
    /// </summary>
    public unsafe bool bPreventPredatorTakedownCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bCanPlayEnterCombatBark
    /// </summary>
    public unsafe bool bCanPlayEnterCombatBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bShouldPreventFinalBlowCam
    /// </summary>
    public unsafe bool bShouldPreventFinalBlowCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bHiddenInXray
    /// </summary>
    public unsafe bool bHiddenInXray
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bAttackingPSActive
    /// </summary>
    public unsafe bool bAttackingPSActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bAttractionPSActive
    /// </summary>
    public unsafe bool bAttractionPSActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bTerrifiedPSActive
    /// </summary>
    public unsafe bool bTerrifiedPSActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bGlideKickPSActive
    /// </summary>
    public unsafe bool bGlideKickPSActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bCanBeThrown
    /// </summary>
    public unsafe bool bCanBeThrown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bSuspendCombatStasisUntilBeenInView
    /// </summary>
    public unsafe bool bSuspendCombatStasisUntilBeenInView
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bReduceGelForce
    /// </summary>
    public unsafe bool bReduceGelForce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bImmuneToBatclawDisarm
    /// </summary>
    public unsafe bool bImmuneToBatclawDisarm
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bInfiniteBeatdown
    /// </summary>
    public unsafe bool bInfiniteBeatdown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bNoBeatdownComboInc
    /// </summary>
    public unsafe bool bNoBeatdownComboInc
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bCannotUseEnvironmentWeapon
    /// </summary>
    public unsafe bool bCannotUseEnvironmentWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bCanDoSpecialFloorInteraction
    /// </summary>
    public unsafe bool bCanDoSpecialFloorInteraction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3328); }
    }

    /// <summary>
    /// BoolProperty: bOnlyAllowLowStrikes
    /// </summary>
    public unsafe bool bOnlyAllowLowStrikes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bOnlyAllowHighStrikes
    /// </summary>
    public unsafe bool bOnlyAllowHighStrikes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bCanShowStunFx
    /// </summary>
    public unsafe bool bCanShowStunFx
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bCanBeInterrogatedOnFloor
    /// </summary>
    public unsafe bool bCanBeInterrogatedOnFloor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bCheckForAutoInformantScan
    /// </summary>
    public unsafe bool bCheckForAutoInformantScan
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bHasPlayedLastPawnAliveBark
    /// </summary>
    public unsafe bool bHasPlayedLastPawnAliveBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bHitDamageTarget
    /// </summary>
    public unsafe bool bHitDamageTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bGoodAsDead
    /// </summary>
    public unsafe bool bGoodAsDead
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bCutDown
    /// </summary>
    public unsafe bool bCutDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bDontUseEmotes
    /// </summary>
    public unsafe bool bDontUseEmotes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bLoadPairedAnims
    /// </summary>
    public unsafe bool bLoadPairedAnims
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bLoadNonOWPairedAnims
    /// </summary>
    public unsafe bool bLoadNonOWPairedAnims
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bLoadedPairedAnimsets
    /// </summary>
    public unsafe bool bLoadedPairedAnimsets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: IsValidGlideAttackTarget
    /// </summary>
    public unsafe bool IsValidGlideAttackTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bHasThermalGoggles
    /// </summary>
    public unsafe bool bHasThermalGoggles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bIsMobileJammer
    /// </summary>
    public unsafe bool bIsMobileJammer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bJammerDisabled
    /// </summary>
    public unsafe bool bJammerDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bHasMines
    /// </summary>
    public unsafe bool bHasMines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bIsTakedownVulnerable
    /// </summary>
    public unsafe bool bIsTakedownVulnerable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: mForceBeatDown
    /// </summary>
    public unsafe bool mForceBeatDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bCanAlwaysBlock
    /// </summary>
    public unsafe bool bCanAlwaysBlock
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bCanCheckFalling
    /// </summary>
    public unsafe bool bCanCheckFalling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bForceAllowGroundTakedown
    /// </summary>
    public unsafe bool bForceAllowGroundTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bLastRECProjectileWasFromGarg
    /// </summary>
    public unsafe bool bLastRECProjectileWasFromGarg
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysDodgesWhip
    /// </summary>
    public unsafe bool bAlwaysDodgesWhip
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bEnteredCombatFromRange
    /// </summary>
    public unsafe bool bEnteredCombatFromRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bFocusAuraFlashing
    /// </summary>
    public unsafe bool bFocusAuraFlashing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bStickyBombAttached
    /// </summary>
    public unsafe bool bStickyBombAttached
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bNoStrikeTargettingCollisionChecks
    /// </summary>
    public unsafe bool bNoStrikeTargettingCollisionChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bCanBeTargettedForCombatTakedown
    /// </summary>
    public unsafe bool bCanBeTargettedForCombatTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bImmuneToLineLaunchTakedown
    /// </summary>
    public unsafe bool bImmuneToLineLaunchTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bReportKOTypeGameAction
    /// </summary>
    public unsafe bool bReportKOTypeGameAction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3332); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3332); }
    }

    /// <summary>
    /// BoolProperty: bCantTakeSuperBatclawSlam
    /// </summary>
    public unsafe bool bCantTakeSuperBatclawSlam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3336) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3336); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3336); }
    }

    /// <summary>
    /// BoolProperty: bDisableBatarangHitReaction
    /// </summary>
    public unsafe bool bDisableBatarangHitReaction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3336) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3336); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3336); }
    }

    /// <summary>
    /// BoolProperty: bDoNotStopDialogueOnActivate
    /// </summary>
    public unsafe bool bDoNotStopDialogueOnActivate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3336) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3336); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3336); }
    }

    /// <summary>
    /// BoolProperty: bQuickTakedownVictim
    /// </summary>
    public unsafe bool bQuickTakedownVictim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3336) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3336); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3336); }
    }

    /// <summary>
    /// BoolProperty: bDoubleTakedownVictim
    /// </summary>
    public unsafe bool bDoubleTakedownVictim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3336) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3336); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3336); }
    }

    /// <summary>
    /// BoolProperty: bCanBlockGlueGrendades
    /// </summary>
    public unsafe bool bCanBlockGlueGrendades
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3336) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3336); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3336); }
    }

    /// <summary>
    /// BoolProperty: bCanBlockStunGrenades
    /// </summary>
    public unsafe bool bCanBlockStunGrenades
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3336) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3336); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3336); }
    }

    /// <summary>
    /// BoolProperty: bFinalizedIncapacitated
    /// </summary>
    public unsafe bool bFinalizedIncapacitated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3336) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3336); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3336); }
    }

    /// <summary>
    /// BoolProperty: bShowInterrogationScanEffects
    /// </summary>
    public unsafe bool bShowInterrogationScanEffects
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3336) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3336); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3336); }
    }

    /// <summary>
    /// FloatProperty: FallingTime
    /// </summary>
    public unsafe float FallingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3340); }
    }

    /// <summary>
    /// StructProperty: FallingPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FallingPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3344);

    /// <summary>
    /// FloatProperty: FallingStartHeight
    /// </summary>
    public unsafe float FallingStartHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3356); }
    }

    /// <summary>
    /// IntProperty: RetrySplashAndDestroyCount
    /// </summary>
    public unsafe int RetrySplashAndDestroyCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3360); }
    }

    /// <summary>
    /// FloatProperty: AntiDodgeFactor
    /// </summary>
    public unsafe float AntiDodgeFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3364); }
    }

    /// <summary>
    /// IntProperty: KillFallSpeed
    /// </summary>
    public unsafe int KillFallSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3368); }
    }

    /// <summary>
    /// IntProperty: DestroyFallSpeed
    /// </summary>
    public unsafe int DestroyFallSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3372); }
    }

    /// <summary>
    /// ObjectProperty: TauntAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet TauntAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3376); }
    }

    /// <summary>
    /// ArrayProperty: TauntAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> TauntAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 3380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3380); }
    }

    /// <summary>
    /// ArrayProperty: OverlayAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> OverlayAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 3392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3392); }
    }

    /// <summary>
    /// ArrayProperty: ArmouredOverlayAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> ArmouredOverlayAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 3404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3404); }
    }

    /// <summary>
    /// IntProperty: LastComboSizeWhenHit
    /// </summary>
    public unsafe int LastComboSizeWhenHit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3416); }
    }

    /// <summary>
    /// FloatProperty: MonitorRagdollForHighVelocityTimer
    /// </summary>
    public unsafe float MonitorRagdollForHighVelocityTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3420); }
    }

    /// <summary>
    /// IntProperty: RingOutCombo
    /// </summary>
    public unsafe int RingOutCombo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3424); }
    }

    /// <summary>
    /// StrProperty: EnteredCombatFlagName
    /// </summary>
    public unsafe BmSDK.FString EnteredCombatFlagName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3428); }
    }

    /// <summary>
    /// FloatProperty: PostHitNoTakedownTimer
    /// </summary>
    public unsafe float PostHitNoTakedownTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3440); }
    }

    /// <summary>
    /// ObjectProperty: DisableAIAlertsVolume
    /// </summary>
    public unsafe BmSDK.Engine.Volume DisableAIAlertsVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 3444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3444); }
    }

    /// <summary>
    /// ObjectProperty: SavedKiller
    /// </summary>
    public unsafe BmSDK.Engine.Controller SavedKiller
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Controller>(Ptr + 3448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3448); }
    }

    /// <summary>
    /// ObjectProperty: PlayerHitReactionAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerHitReactionAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3452); }
    }

    /// <summary>
    /// ObjectProperty: RECHitReactionAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet RECHitReactionAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3456); }
    }

    /// <summary>
    /// ObjectProperty: PlayerRedirectAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerRedirectAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3460); }
    }

    /// <summary>
    /// ComponentProperty: FundamentalGlue
    /// </summary>
    public unsafe BmSDK.BmGame.MPawnVillain_FundamentalGrenadeGadget FundamentalGlue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MPawnVillain_FundamentalGrenadeGadget>(Ptr + 3464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3464); }
    }

    /// <summary>
    /// ComponentProperty: HeadPSC
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent HeadPSC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3468); }
    }

    /// <summary>
    /// ObjectProperty: GlideKickPS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem GlideKickPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3472); }
    }

    /// <summary>
    /// ObjectProperty: GlideKickMat_M
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstance GlideKickMat_M
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstance>(Ptr + 3476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3476); }
    }

    /// <summary>
    /// ObjectProperty: GlideKickMat
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant GlideKickMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 3480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3480); }
    }

    /// <summary>
    /// ObjectProperty: TerrifiedPS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem TerrifiedPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3484); }
    }

    /// <summary>
    /// ClassProperty: DeathDamageType
    /// </summary>
    public unsafe BmSDK.Class DeathDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3488); }
    }

    /// <summary>
    /// ClassProperty: LastDamageType
    /// </summary>
    public unsafe BmSDK.Class LastDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3492); }
    }

    /// <summary>
    /// ClassProperty: WeaponSwitchCallbackToNoneDamageType
    /// </summary>
    public unsafe BmSDK.Class WeaponSwitchCallbackToNoneDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3496); }
    }

    /// <summary>
    /// FloatProperty: SimultaneousAttack_AttackRange
    /// </summary>
    public unsafe float SimultaneousAttack_AttackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3500); }
    }

    /// <summary>
    /// FloatProperty: SimultaneousAttack_HitRange
    /// </summary>
    public unsafe float SimultaneousAttack_HitRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3504); }
    }

    /// <summary>
    /// FloatProperty: SimultaneousAttack_AvoidWallRange
    /// </summary>
    public unsafe float SimultaneousAttack_AvoidWallRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3508); }
    }

    /// <summary>
    /// FloatProperty: RagdollForceMultiplier
    /// </summary>
    public unsafe float RagdollForceMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3512); }
    }

    /// <summary>
    /// ArrayProperty: SavedPositions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FEnemyPosition> SavedPositions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FEnemyPosition>>(Ptr + 3516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3516); }
    }

    /// <summary>
    /// ObjectProperty: TrackTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor TrackTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 3528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3528); }
    }

    /// <summary>
    /// FloatProperty: TrackHistoryTime
    /// </summary>
    public unsafe float TrackHistoryTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3532); }
    }

    /// <summary>
    /// ObjectProperty: DamageTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor DamageTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 3536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3536); }
    }

    /// <summary>
    /// FloatProperty: StoredFearLevel
    /// </summary>
    public unsafe float StoredFearLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3540); }
    }

    /// <summary>
    /// FloatProperty: DodgeCurrent
    /// </summary>
    public unsafe float DodgeCurrent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3544); }
    }

    /// <summary>
    /// FloatProperty: PawnBatarangStunModifier
    /// </summary>
    public unsafe float PawnBatarangStunModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3548); }
    }

    /// <summary>
    /// ArrayProperty: EmotePack
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RDialogueLine> EmotePack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RDialogueLine>>(Ptr + 3552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3552); }
    }

    /// <summary>
    /// ObjectProperty: StopMuffledEmote
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent StopMuffledEmote
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 3564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3564); }
    }

    /// <summary>
    /// ObjectProperty: StopAllEmote
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent StopAllEmote
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 3568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3568); }
    }

    /// <summary>
    /// ObjectProperty: RagdollFallAlert
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RagdollFallAlert
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 3572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3572); }
    }

    /// <summary>
    /// StrProperty: LoadEmoteString
    /// </summary>
    public unsafe BmSDK.FString LoadEmoteString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3576); }
    }

    /// <summary>
    /// StrProperty: LoadingEmotePackage
    /// </summary>
    public unsafe BmSDK.FString LoadingEmotePackage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3588); }
    }

    /// <summary>
    /// StrProperty: DebugEmotePackage
    /// </summary>
    public unsafe BmSDK.FString DebugEmotePackage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3600); }
    }

    /// <summary>
    /// ComponentProperty: DeadParticleFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent DeadParticleFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3612); }
    }

    /// <summary>
    /// ComponentProperty: CatVisionParticleFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent CatVisionParticleFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3616); }
    }

    /// <summary>
    /// FloatProperty: JewelleryValue
    /// </summary>
    public unsafe float JewelleryValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3620); }
    }

    /// <summary>
    /// IntProperty: JewelleryIndex
    /// </summary>
    public unsafe int JewelleryIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3624); }
    }

    /// <summary>
    /// ArrayProperty: PlayerPairedAnimsetPackageDefs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FPairedAnimsetPackageDef> PlayerPairedAnimsetPackageDefs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FPairedAnimsetPackageDef>>(Ptr + 3628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3628); }
    }

    /// <summary>
    /// IntProperty: CurrPairedAnimsetIndex
    /// </summary>
    public unsafe int CurrPairedAnimsetIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3640); }
    }

    /// <summary>
    /// ArrayProperty: RegisteredPairedAnimsets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> RegisteredPairedAnimsets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 3644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3644); }
    }

    /// <summary>
    /// StrProperty: LoadingPairedAnimsetPackage
    /// </summary>
    public unsafe BmSDK.FString LoadingPairedAnimsetPackage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3656); }
    }

    /// <summary>
    /// ArrayProperty: CombatAnimsetRefHolders
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCharacterBioCue> CombatAnimsetRefHolders
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCharacterBioCue>>(Ptr + 3668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3668); }
    }

    /// <summary>
    /// ObjectProperty: BeatdownHitReactionAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BeatdownHitReactionAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3680); }
    }

    /// <summary>
    /// ObjectProperty: VillainAerialAttackAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainAerialAttackAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3684); }
    }

    /// <summary>
    /// ObjectProperty: PlayerAerialAttackAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerAerialAttackAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3688); }
    }

    /// <summary>
    /// ObjectProperty: VillainFloorTakedownAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainFloorTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3692); }
    }

    /// <summary>
    /// ObjectProperty: PlayerFloorTakedownAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerFloorTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3696); }
    }

    /// <summary>
    /// ObjectProperty: SGVillainFloorTakedownAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet SGVillainFloorTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3700); }
    }

    /// <summary>
    /// ObjectProperty: SGPlayerFloorTakedownAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet SGPlayerFloorTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3704); }
    }

    /// <summary>
    /// ObjectProperty: VillainPushStrikeAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainPushStrikeAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3708); }
    }

    /// <summary>
    /// ObjectProperty: PlayerPushStrikeAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerPushStrikeAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3712); }
    }

    /// <summary>
    /// ObjectProperty: ShockGloveBeatdownHitReactionAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet ShockGloveBeatdownHitReactionAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3716); }
    }

    /// <summary>
    /// ArrayProperty: CameraAnimsets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> CameraAnimsets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 3720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3720); }
    }

    /// <summary>
    /// ObjectProperty: VillainBatclawSlamAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainBatclawSlamAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3732); }
    }

    /// <summary>
    /// IntProperty: HitRatioCounter
    /// </summary>
    public unsafe int HitRatioCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3736); }
    }

    /// <summary>
    /// ComponentProperty: PlayerInteractions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent PlayerInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 3740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3740); }
    }

    /// <summary>
    /// ComponentProperty: PlayerInterrogationPredatorInteractions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent PlayerInterrogationPredatorInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 3744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3744); }
    }

    /// <summary>
    /// IntProperty: GetUpAttempts
    /// </summary>
    public unsafe int GetUpAttempts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3748); }
    }

    /// <summary>
    /// ObjectProperty: ForceTargetPlayer
    /// </summary>
    public unsafe BmSDK.Engine.PlayerController ForceTargetPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerController>(Ptr + 3752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3752); }
    }

    /// <summary>
    /// IntProperty: BulletByCount
    /// </summary>
    public unsafe int BulletByCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3756); }
    }

    /// <summary>
    /// StructProperty: ServerLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ServerLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3760);

    /// <summary>
    /// StructProperty: ServerRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator ServerRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 3772);

    /// <summary>
    /// FloatProperty: TimeSinceLastTargetCheck
    /// </summary>
    public unsafe float TimeSinceLastTargetCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3784); }
    }

    /// <summary>
    /// FloatProperty: TargetResponsiveness
    /// </summary>
    public unsafe float TargetResponsiveness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3788); }
    }

    /// <summary>
    /// ObjectProperty: ProcessKickedNoisePlayer
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer ProcessKickedNoisePlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 3792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3792); }
    }

    /// <summary>
    /// NameProperty: SimultaneousAttackAnimName
    /// </summary>
    public unsafe BmSDK.FName SimultaneousAttackAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 3796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3796); }
    }

    /// <summary>
    /// ByteProperty: SimultaneousAttackCounterLimb
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat.CounterLimb SimultaneousAttackCounterLimb
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.CounterLimb>(Ptr + 3804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3804); }
    }

    /// <summary>
    /// ArrayProperty: OverrideStealthTakedown
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> OverrideStealthTakedown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 3808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3808); }
    }

    /// <summary>
    /// ClassProperty: BeatdownCombatMoveClass
    /// </summary>
    public unsafe BmSDK.Class BeatdownCombatMoveClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3820); }
    }

    /// <summary>
    /// FloatProperty: BatclawReleaseTime
    /// </summary>
    public unsafe float BatclawReleaseTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3824); }
    }

    /// <summary>
    /// ArrayProperty: BatclawSocketTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BatclawSocketTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 3828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3828); }
    }

    /// <summary>
    /// ObjectProperty: RagdollPoseConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RPoseConfig RagdollPoseConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig>(Ptr + 3840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3840); }
    }

    /// <summary>
    /// FloatProperty: GooSprayImpulseMultiplier
    /// </summary>
    public unsafe float GooSprayImpulseMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3844); }
    }

    /// <summary>
    /// StructProperty: MagnetisedWeaponHitTransition
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId MagnetisedWeaponHitTransition
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 3848);

    /// <summary>
    /// ArrayProperty: MFAAttractReceivers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RMagneticBlastReceiver> MFAAttractReceivers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RMagneticBlastReceiver>>(Ptr + 3852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3852); }
    }

    /// <summary>
    /// ArrayProperty: MFAStuckWeapons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatThrownObject> MFAStuckWeapons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatThrownObject>>(Ptr + 3864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3864); }
    }

    /// <summary>
    /// ObjectProperty: BlockAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BlockAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3876); }
    }

    /// <summary>
    /// IntProperty: SurprisedByBatarang
    /// </summary>
    public unsafe int SurprisedByBatarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3880); }
    }

    /// <summary>
    /// StructProperty: LastRECProjectileSourcePos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastRECProjectileSourcePos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3884);

    /// <summary>
    /// StructProperty: StartCombatLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StartCombatLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3896);

    /// <summary>
    /// NameProperty: RECTargetBone
    /// </summary>
    public unsafe BmSDK.FName RECTargetBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 3908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3908); }
    }

    /// <summary>
    /// FloatProperty: LastCowerTime
    /// </summary>
    public unsafe float LastCowerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3916); }
    }

    /// <summary>
    /// ArrayProperty: DropPropsArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshActor> DropPropsArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshActor>>(Ptr + 3920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3920); }
    }

    /// <summary>
    /// ObjectProperty: WalkCycleVariationAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet WalkCycleVariationAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3932); }
    }

    /// <summary>
    /// FloatProperty: FocusAuraFlashTimer
    /// </summary>
    public unsafe float FocusAuraFlashTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3936); }
    }

    /// <summary>
    /// ObjectProperty: StoredCannotBeTargettedByPlayer
    /// </summary>
    public unsafe BmSDK.Engine.PlayerController StoredCannotBeTargettedByPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerController>(Ptr + 3940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3940); }
    }

    /// <summary>
    /// IntProperty: CowerProjectileID
    /// </summary>
    public unsafe int CowerProjectileID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3944); }
    }

    /// <summary>
    /// ObjectProperty: LaughShootingTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI LaughShootingTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 3948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3948); }
    }

    /// <summary>
    /// ObjectProperty: SpriteMatIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant SpriteMatIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 3952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3952); }
    }

    /// <summary>
    /// FloatProperty: GettingUpFromRagdollTimer
    /// </summary>
    public unsafe float GettingUpFromRagdollTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3956); }
    }

    /// <summary>
    /// ObjectProperty: DualClawClusterProjectile
    /// </summary>
    public unsafe BmSDK.BmGame.MDualClawClusterProjectile DualClawClusterProjectile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MDualClawClusterProjectile>(Ptr + 3960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3960); }
    }

    /// <summary>
    /// NameProperty: GlideKickAttachToBoneName
    /// </summary>
    public unsafe BmSDK.FName GlideKickAttachToBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 3964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3964); }
    }

    /// <summary>
    /// NameProperty: CutSceneTargetBone
    /// </summary>
    public unsafe BmSDK.FName CutSceneTargetBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 3972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3972); }
    }

    /// <summary>
    /// FloatProperty: FacingDotRequiredForValidVentTakedownTarget
    /// </summary>
    public unsafe float FacingDotRequiredForValidVentTakedownTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3980); }
    }

    /// <summary>
    /// FloatProperty: LastAttackStartTime
    /// </summary>
    public unsafe float LastAttackStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3984); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceIncapacitated
    /// </summary>
    public unsafe float TimeSinceIncapacitated
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3988); }
    }

    /// <summary>
    /// ClassProperty: CustomXpSequence
    /// </summary>
    public unsafe BmSDK.Class CustomXpSequence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3992); }
    }
}
