#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RBatarang<br/>
/// (size = 1344)
/// (flags = 142606515)
/// </summary>
public partial class RBatarang : BmSDK.BmGame.RInventoryGadget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBatarang", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBatarang.
    /// </summary>
    public static RBatarang DefaultObject => (RBatarang)StaticClass().DefaultObject;

    internal RBatarang() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBatarang(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatarang>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatarang>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatarang>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatarang>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatarang>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatarang>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatarang>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatarang>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_TraceLevelLimits;
    /// <summary>
    /// Function: TraceLevelLimits
    /// </summary>
    public unsafe virtual bool TraceLevelLimits(out System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 CheckEnd, System.Numerics.Vector3 CheckStart)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TraceLevelLimits, "BmGame.RBatarang.TraceLevelLimits");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckEnd, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckStart, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HitLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_GetGadgetHelpStage;
    /// <summary>
    /// Function: GetGadgetHelpStage
    /// </summary>
    public unsafe virtual int GetGadgetHelpStage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetHelpStage, "BmGame.RBatarang.GetGadgetHelpStage");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetProjectilePrompt;
    /// <summary>
    /// Function: GetProjectilePrompt
    /// </summary>
    public unsafe virtual void GetProjectilePrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProjectilePrompt, "BmGame.RBatarang.GetProjectilePrompt");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CatchBatarang;
    /// <summary>
    /// Function: CatchBatarang
    /// </summary>
    public unsafe virtual void CatchBatarang(BmSDK.BmGame.RBatarangProjectile Projectile)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CatchBatarang, "BmGame.RBatarang.CatchBatarang");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Projectile, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProjectileDestroyed;
    /// <summary>
    /// Function: ProjectileDestroyed
    /// </summary>
    public unsafe virtual void ProjectileDestroyed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProjectileDestroyed, "BmGame.RBatarang.ProjectileDestroyed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBatarangThrowAnim;
    /// <summary>
    /// Function: GetBatarangThrowAnim
    /// </summary>
    public unsafe virtual BmSDK.FName GetBatarangThrowAnim(BmSDK.Rotator ThrowDirection, out BmSDK.BmGame.RPawnPlayerAnim.AimingConfigDesc AimingConfig, out BmSDK.BmGame.RAnimUtil.EMirrorChoice MirroredNess)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatarangThrowAnim, "BmGame.RBatarang.GetBatarangThrowAnim");
        byte* paramsPtr = stackalloc byte[66];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowDirection, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AimingConfig);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimingConfig, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MirroredNess);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MirroredNess, paramsPtr + 13);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AimingConfig = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayerAnim.AimingConfigDesc>(paramsPtr + 12);
        MirroredNess = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.EMirrorChoice>(paramsPtr + 13);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_FireGadgetCombat;
    /// <summary>
    /// Function: FireGadgetCombat
    /// </summary>
    public unsafe override bool FireGadgetCombat()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireGadgetCombat, "BmGame.RBatarang.FireGadgetCombat");
        byte* paramsPtr = stackalloc byte[41];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPotentialTargetPositions;
    /// <summary>
    /// Function: GetPotentialTargetPositions
    /// </summary>
    public unsafe override bool GetPotentialTargetPositions(BmSDK.Engine.Actor Target, in System.Numerics.Vector3 InTargetPosition, out BmSDK.TArray<System.Numerics.Vector3> PotentialTargetPositions)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPotentialTargetPositions, "BmGame.RBatarang.GetPotentialTargetPositions");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTargetPosition, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PotentialTargetPositions = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<System.Numerics.Vector3>>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RBatarang.Tick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGadgetLookSensitivity;
    /// <summary>
    /// Function: GetGadgetLookSensitivity
    /// </summary>
    public unsafe override float GetGadgetLookSensitivity(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetLookSensitivity, "BmGame.RBatarang.GetGadgetLookSensitivity");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UpgradePowerLevel;
    /// <summary>
    /// Function: UpgradePowerLevel
    /// </summary>
    public unsafe virtual void UpgradePowerLevel(int NewUpgradeLevel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpgradePowerLevel, "BmGame.RBatarang.UpgradePowerLevel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewUpgradeLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpgradeGadget;
    /// <summary>
    /// Function: UpgradeGadget
    /// </summary>
    public unsafe override void UpgradeGadget(int NewUpgradeLevel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpgradeGadget, "BmGame.RBatarang.UpgradeGadget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewUpgradeLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetThrowFinishPose;
    /// <summary>
    /// Function: GetThrowFinishPose
    /// </summary>
    public unsafe virtual BmSDK.FName GetThrowFinishPose(out BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch StanceIsCrouched, out BmSDK.BmGame.RAnimUtil.EMirrorChoice MirroredNess)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThrowFinishPose, "BmGame.RBatarang.GetThrowFinishPose");
        byte* paramsPtr = stackalloc byte[33];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StanceIsCrouched);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StanceIsCrouched, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MirroredNess);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MirroredNess, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        StanceIsCrouched = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch>(paramsPtr + 0);
        MirroredNess = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.EMirrorChoice>(paramsPtr + 1);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_FollowCoverRotator;
    /// <summary>
    /// Function: FollowCoverRotator
    /// </summary>
    public unsafe override bool FollowCoverRotator(BmSDK.BmGame.RInventoryGadget.CoverCornerType CornerType, out BmSDK.Rotator CoverOffset)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FollowCoverRotator, "BmGame.RBatarang.FollowCoverRotator");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerType, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CoverOffset);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CoverOffset, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CoverOffset = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetPrimedPose;
    /// <summary>
    /// Function: GetPrimedPose
    /// </summary>
    public unsafe override BmSDK.FName GetPrimedPose(out BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch StanceIsCrouched, out BmSDK.BmGame.RAnimUtil.EMirrorChoice MirroredNess, bool InSoftCover, BmSDK.BmGame.RInventoryGadget.CoverCornerType CornerType, out BmSDK.FName OutCapeState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPrimedPose, "BmGame.RBatarang.GetPrimedPose");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StanceIsCrouched);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StanceIsCrouched, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MirroredNess);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MirroredNess, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSoftCover, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerType, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutCapeState);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutCapeState, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        StanceIsCrouched = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch>(paramsPtr + 0);
        MirroredNess = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.EMirrorChoice>(paramsPtr + 1);
        OutCapeState = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetThrowState;
    /// <summary>
    /// Function: GetThrowState
    /// </summary>
    public unsafe virtual BmSDK.FName GetThrowState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThrowState, "BmGame.RBatarang.GetThrowState");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetThrowReferencePoint;
    /// <summary>
    /// Function: GetThrowReferencePoint
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetThrowReferencePoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThrowReferencePoint, "BmGame.RBatarang.GetThrowReferencePoint");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AimedFireBatarang;
    /// <summary>
    /// Function: AimedFireBatarang
    /// </summary>
    public unsafe virtual bool AimedFireBatarang()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AimedFireBatarang, "BmGame.RBatarang.AimedFireBatarang");
        byte* paramsPtr = stackalloc byte[156];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBatarangThrowTransition;
    /// <summary>
    /// Function: GetBatarangThrowTransition
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig GetBatarangThrowTransition(BmSDK.FName AnimName, BmSDK.Engine.AnimSet Set, BmSDK.BmGame.RAimingConfig AimingConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatarangThrowTransition, "BmGame.RBatarang.GetBatarangThrowTransition");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Set, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimingConfig, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_InformTargetOfThrow;
    /// <summary>
    /// Function: InformTargetOfThrow
    /// </summary>
    public unsafe virtual bool InformTargetOfThrow(int LaunchID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InformTargetOfThrow, "BmGame.RBatarang.InformTargetOfThrow");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaunchID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CheckAutoTarget;
    /// <summary>
    /// Function: CheckAutoTarget
    /// </summary>
    public unsafe override bool CheckAutoTarget(BmSDK.Engine.Actor BatarangTarget, out System.Numerics.Vector3 BatarangTargetPosition, out float OverridePriority, out float OverrideMaxRange)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckAutoTarget, "BmGame.RBatarang.CheckAutoTarget");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatarangTarget, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BatarangTargetPosition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatarangTargetPosition, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OverridePriority);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverridePriority, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OverrideMaxRange);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideMaxRange, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BatarangTargetPosition = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
        OverridePriority = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
        OverrideMaxRange = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_CheckForceTarget;
    /// <summary>
    /// Function: CheckForceTarget
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor CheckForceTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForceTarget, "BmGame.RBatarang.CheckForceTarget");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FindInterceptDirection;
    /// <summary>
    /// Function: FindInterceptDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 FindInterceptDirection(System.Numerics.Vector3 BatarangStartPos, float BatarangSpeed, System.Numerics.Vector3 BatarangTargetPosition, System.Numerics.Vector3 BatarangTargetVelocity)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindInterceptDirection, "BmGame.RBatarang.FindInterceptDirection");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatarangStartPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatarangSpeed, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatarangTargetPosition, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatarangTargetVelocity, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_GetInitialDirection;
    /// <summary>
    /// Function: GetInitialDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetInitialDirection(System.Numerics.Vector3 StartLocation, float BatarangSpeed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInitialDirection, "BmGame.RBatarang.GetInitialDirection");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatarangSpeed, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ThrowFinished;
    /// <summary>
    /// Function: ThrowFinished
    /// </summary>
    public unsafe virtual void ThrowFinished()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThrowFinished, "BmGame.RBatarang.ThrowFinished");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishedComboBatarang;
    /// <summary>
    /// Function: FinishedComboBatarang
    /// </summary>
    public unsafe virtual void FinishedComboBatarang()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishedComboBatarang, "BmGame.RBatarang.FinishedComboBatarang");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QuickBatarangTimeout;
    /// <summary>
    /// Function: QuickBatarangTimeout
    /// </summary>
    public unsafe virtual void QuickBatarangTimeout()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QuickBatarangTimeout, "BmGame.RBatarang.QuickBatarangTimeout");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayThrowSound;
    /// <summary>
    /// Function: PlayThrowSound
    /// </summary>
    public unsafe virtual void PlayThrowSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayThrowSound, "BmGame.RBatarang.PlayThrowSound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThrowBatarangCommon;
    /// <summary>
    /// Function: ThrowBatarangCommon
    /// </summary>
    public unsafe virtual void ThrowBatarangCommon(BmSDK.BmGame.RBatarangProjectile Projectile)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThrowBatarangCommon, "BmGame.RBatarang.ThrowBatarangCommon");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Projectile, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BatarangContinueComboTimer;
    /// <summary>
    /// Function: BatarangContinueComboTimer
    /// </summary>
    public unsafe virtual void BatarangContinueComboTimer(BmSDK.BmGame.RPlayerControllerCombat PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatarangContinueComboTimer, "BmGame.RBatarang.BatarangContinueComboTimer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoAffectCombo;
    /// <summary>
    /// Function: DoAffectCombo
    /// </summary>
    public unsafe virtual void DoAffectCombo(BmSDK.BmGame.RPlayerControllerCombat PC, BmSDK.BmGame.RBatarangProjectile Projectile, BmSDK.Engine.Actor ThisTarget, bool bDodged)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoAffectCombo, "BmGame.RBatarang.DoAffectCombo");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Projectile, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThisTarget, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDodged, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnBatarangProjectile;
    /// <summary>
    /// Function: SpawnBatarangProjectile
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBatarangProjectile SpawnBatarangProjectile(BmSDK.Class SpawnProjectileClass, System.Numerics.Vector3 LaunchLocation, System.Numerics.Vector3 BatarangDirection, System.Numerics.Vector3 ThisTargetPosition, BmSDK.Engine.Actor ThisTarget, BmSDK.FName BoneName, float RopePosition, bool bMirrorFlightPath, bool bCanAffectCombo = default, bool bManaged = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnBatarangProjectile, "BmGame.RBatarang.SpawnBatarangProjectile");
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnProjectileClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaunchLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatarangDirection, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThisTargetPosition, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThisTarget, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneName, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RopePosition, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMirrorFlightPath, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanAffectCombo, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bManaged, paramsPtr + 64);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBatarangProjectile>(paramsPtr + 68);
    }

    private static BmSDK.Function __fn_SetDamageMod;
    /// <summary>
    /// Function: SetDamageMod
    /// </summary>
    public unsafe virtual void SetDamageMod(BmSDK.BmGame.RBatarangProjectile Projectile)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDamageMod, "BmGame.RBatarang.SetDamageMod");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Projectile, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetStunTimeMod;
    /// <summary>
    /// Function: SetStunTimeMod
    /// </summary>
    public unsafe virtual void SetStunTimeMod(BmSDK.BmGame.RBatarangProjectile Projectile)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetStunTimeMod, "BmGame.RBatarang.SetStunTimeMod");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Projectile, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetActualLaunchLocation;
    /// <summary>
    /// Function: GetActualLaunchLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetActualLaunchLocation(System.Numerics.Vector3 DesiredLaunchLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActualLaunchLocation, "BmGame.RBatarang.GetActualLaunchLocation");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredLaunchLocation, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ThrowBatarangHand;
    /// <summary>
    /// Function: ThrowBatarangHand
    /// </summary>
    public unsafe virtual void ThrowBatarangHand(BmSDK.FName LaunchBone)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThrowBatarangHand, "BmGame.RBatarang.ThrowBatarangHand");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaunchBone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnProjectile;
    /// <summary>
    /// Function: SpawnProjectile
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBatarangProjectile SpawnProjectile(BmSDK.Class SpawnProjectileClass, System.Numerics.Vector3 LaunchLoc, bool Managed = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnProjectile, "BmGame.RBatarang.SpawnProjectile");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnProjectileClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaunchLoc, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Managed, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBatarangProjectile>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_UpdateTarget;
    /// <summary>
    /// Function: UpdateTarget
    /// </summary>
    public unsafe virtual void UpdateTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateTarget, "BmGame.RBatarang.UpdateTarget");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawAimingHUD;
    /// <summary>
    /// Function: DrawAimingHUD
    /// </summary>
    public unsafe virtual void DrawAimingHUD(BmSDK.Engine.HUD H)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawAimingHUD, "BmGame.RBatarang.DrawAimingHUD");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BatarangCamera;
    /// <summary>
    /// Function: BatarangCamera
    /// </summary>
    public unsafe virtual void BatarangCamera(bool bAllowCancel = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatarangCamera, "BmGame.RBatarang.BatarangCamera");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowCancel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NewBatarangCam;
    /// <summary>
    /// Function: NewBatarangCam
    /// </summary>
    public unsafe virtual void NewBatarangCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NewBatarangCam, "BmGame.RBatarang.NewBatarangCam");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnequipSelf;
    /// <summary>
    /// Function: UnequipSelf
    /// </summary>
    public unsafe override bool UnequipSelf()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnequipSelf, "BmGame.RBatarang.UnequipSelf");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_KeepBatarangAfterFiring;
    /// <summary>
    /// Function: KeepBatarangAfterFiring
    /// </summary>
    public unsafe virtual bool KeepBatarangAfterFiring()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KeepBatarangAfterFiring, "BmGame.RBatarang.KeepBatarangAfterFiring");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OverridePlayerTick_ReadyToThrow;
    /// <summary>
    /// Function: OverridePlayerTick_ReadyToThrow
    /// </summary>
    public unsafe virtual void OverridePlayerTick_ReadyToThrow(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverridePlayerTick_ReadyToThrow, "BmGame.RBatarang.OverridePlayerTick_ReadyToThrow");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawHUD_ReadyToThrow;
    /// <summary>
    /// Function: DrawHUD_ReadyToThrow
    /// </summary>
    public unsafe virtual void DrawHUD_ReadyToThrow(BmSDK.Engine.HUD H)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawHUD_ReadyToThrow, "BmGame.RBatarang.DrawHUD_ReadyToThrow");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowCrossHair_ReadyToThrow;
    /// <summary>
    /// Function: ShowCrossHair_ReadyToThrow
    /// </summary>
    public unsafe virtual bool ShowCrossHair_ReadyToThrow()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowCrossHair_ReadyToThrow, "BmGame.RBatarang.ShowCrossHair_ReadyToThrow");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanThrowGadget;
    /// <summary>
    /// Function: CanThrowGadget
    /// </summary>
    public unsafe override bool CanThrowGadget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanThrowGadget, "BmGame.RBatarang.CanThrowGadget");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateCapeBlendWeights;
    /// <summary>
    /// Function: UpdateCapeBlendWeights
    /// </summary>
    public unsafe virtual void UpdateCapeBlendWeights(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCapeBlendWeights, "BmGame.RBatarang.UpdateCapeBlendWeights");
        byte* paramsPtr = stackalloc byte[28];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RBatarang.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanPlayerMove;
    /// <summary>
    /// Function: CanPlayerMove
    /// </summary>
    public unsafe override bool CanPlayerMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayerMove, "BmGame.RBatarang.CanPlayerMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNextState;
    /// <summary>
    /// Function: GetNextState
    /// </summary>
    public unsafe override BmSDK.FName GetNextState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextState, "BmGame.RBatarang.GetNextState");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ButtonReleased;
    /// <summary>
    /// Function: ButtonReleased
    /// </summary>
    public unsafe override void ButtonReleased()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ButtonReleased, "BmGame.RBatarang.ButtonReleased");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ButtonPressed;
    /// <summary>
    /// Function: ButtonPressed
    /// </summary>
    public unsafe override void ButtonPressed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ButtonPressed, "BmGame.RBatarang.ButtonPressed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AimGadget;
    /// <summary>
    /// Function: AimGadget
    /// </summary>
    public unsafe override bool AimGadget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AimGadget, "BmGame.RBatarang.AimGadget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGadgetCamera;
    /// <summary>
    /// Function: GetGadgetCamera
    /// </summary>
    public unsafe override BmSDK.FName GetGadgetCamera(bool InSoftCover = default, BmSDK.BmGame.RInventoryGadget.CoverCornerType CornerType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetCamera, "BmGame.RBatarang.GetGadgetCamera");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSoftCover, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetStandingToEquipedTransition;
    /// <summary>
    /// Function: GetStandingToEquipedTransition
    /// </summary>
    public unsafe virtual BmSDK.FName GetStandingToEquipedTransition()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStandingToEquipedTransition, "BmGame.RBatarang.GetStandingToEquipedTransition");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetHeatGlovesEnable;
    /// <summary>
    /// Function: SetHeatGlovesEnable
    /// </summary>
    public unsafe virtual void SetHeatGlovesEnable(bool Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHeatGlovesEnable, "BmGame.RBatarang.SetHeatGlovesEnable");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsHeatGlovesEnable;
    /// <summary>
    /// Function: IsHeatGlovesEnable
    /// </summary>
    public unsafe virtual bool IsHeatGlovesEnable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsHeatGlovesEnable, "BmGame.RBatarang.IsHeatGlovesEnable");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Struct: FBatarangThrowDirectionsContainer
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FBatarangThrowDirectionsContainer
    {
        /// <summary>
        /// ArrayProperty: ThrowDirections
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RBatarang.FBatarangThrowDirection> ThrowDirections
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBatarang.FBatarangThrowDirection>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FBatarangThrowDirection
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FBatarangThrowDirection
    {
        /// <summary>
        /// ArrayProperty: ThrowAnims
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> ThrowAnims
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: LeftHanded
        /// </summary>
        public unsafe BmSDK.TArray<bool> LeftHanded
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<bool>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ByteProperty: AimingConfig
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayerAnim.AimingConfigDesc AimingConfig
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerAnim.AimingConfigDesc>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: MinAngle
        /// </summary>
        public unsafe float MinAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: MaxAngle
        /// </summary>
        public unsafe float MaxAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
    }

    /// <summary>
    /// StructProperty: TargetPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TargetPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 984);

    /// <summary>
    /// ObjectProperty: CurrentBatarangTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor CurrentBatarangTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// StructProperty: BatarangOverlay
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId BatarangOverlay
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(Ptr + 1000);

    /// <summary>
    /// BoolProperty: bBatarangLaunched
    /// </summary>
    public unsafe bool bBatarangLaunched
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: bThrownAtMaxRange
    /// </summary>
    public unsafe bool bThrownAtMaxRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: bCanTargetWindows
    /// </summary>
    public unsafe bool bCanTargetWindows
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: ForceStraightPath
    /// </summary>
    public unsafe bool ForceStraightPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: bBatarangReturns
    /// </summary>
    public unsafe bool bBatarangReturns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: bExplainBatarangRules
    /// </summary>
    public unsafe bool bExplainBatarangRules
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: bLockingTargets
    /// </summary>
    public unsafe bool bLockingTargets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: bDrawDebug
    /// </summary>
    public unsafe bool bDrawDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: bPressedGadgetButton
    /// </summary>
    public unsafe bool bPressedGadgetButton
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: bCombatThrow
    /// </summary>
    public unsafe bool bCombatThrow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: BatarangTargets
    /// </summary>
    public unsafe bool BatarangTargets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: bLastBatarangHit
    /// </summary>
    public unsafe bool bLastBatarangHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: bExittingThrowingState
    /// </summary>
    public unsafe bool bExittingThrowingState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: bTriggerBatarangCamera
    /// </summary>
    public unsafe bool bTriggerBatarangCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: bDebugFlightPath
    /// </summary>
    public unsafe bool bDebugFlightPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: bCanComboThrow
    /// </summary>
    public unsafe bool bCanComboThrow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: bDebugBatarangLimits
    /// </summary>
    public unsafe bool bDebugBatarangLimits
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: bAutoTargetChecksLevelLimits
    /// </summary>
    public unsafe bool bAutoTargetChecksLevelLimits
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: bWaitForBatarangToLeaveHand
    /// </summary>
    public unsafe bool bWaitForBatarangToLeaveHand
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// IntProperty: QueuedBatarangs
    /// </summary>
    public unsafe int QueuedBatarangs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// IntProperty: ThrownBatarangs
    /// </summary>
    public unsafe int ThrownBatarangs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// NameProperty: TargetBoneName
    /// </summary>
    public unsafe BmSDK.FName TargetBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// FloatProperty: TargetRopePosition
    /// </summary>
    public unsafe float TargetRopePosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// ObjectProperty: GadgetAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet GadgetAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// IntProperty: MaxNumTargets
    /// </summary>
    public unsafe int MaxNumTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// FloatProperty: BatarangRange
    /// </summary>
    public unsafe float BatarangRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// FloatProperty: AutoTargetRange
    /// </summary>
    public unsafe float AutoTargetRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// FloatProperty: AutoTargetAngle
    /// </summary>
    public unsafe float AutoTargetAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// FloatProperty: NormalTargetAngle
    /// </summary>
    public unsafe float NormalTargetAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// FloatProperty: StunModifier
    /// </summary>
    public unsafe float StunModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// FloatProperty: ImpactModifier
    /// </summary>
    public unsafe float ImpactModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// FloatProperty: DamageModifier
    /// </summary>
    public unsafe float DamageModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// IntProperty: MaxQueuedBatarangs
    /// </summary>
    public unsafe int MaxQueuedBatarangs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// IntProperty: PowerUpgradeLevel
    /// </summary>
    public unsafe int PowerUpgradeLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ArrayProperty: BodyPartsTargetted
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BodyPartsTargetted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// StructProperty: AimLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AimLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1088);

    /// <summary>
    /// StructProperty: AimDirection
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AimDirection
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1100);

    /// <summary>
    /// FloatProperty: IdealThrowYaw
    /// </summary>
    public unsafe float IdealThrowYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// FloatProperty: IdealImpactYaw
    /// </summary>
    public unsafe float IdealImpactYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// FloatProperty: IdealThrowLength
    /// </summary>
    public unsafe float IdealThrowLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// FloatProperty: IdealThrowPitch
    /// </summary>
    public unsafe float IdealThrowPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// FloatProperty: IdealImpactPitch
    /// </summary>
    public unsafe float IdealImpactPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// FloatProperty: ThrowSpeed
    /// </summary>
    public unsafe float ThrowSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// FloatProperty: IdealFlightTime
    /// </summary>
    public unsafe float IdealFlightTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// FloatProperty: MinimumFlightTime
    /// </summary>
    public unsafe float MinimumFlightTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// ObjectProperty: BatarangRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform BatarangRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// ObjectProperty: LastProjectile
    /// </summary>
    public unsafe BmSDK.BmGame.RBatarangProjectile LastProjectile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatarangProjectile>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// FloatProperty: TargetCapeBlendWeight
    /// </summary>
    public unsafe float TargetCapeBlendWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// ObjectProperty: ThrowSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ThrowSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// IntProperty: MaxNumQuickBatarangs
    /// </summary>
    public unsafe int MaxNumQuickBatarangs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// ArrayProperty: QuickBatarangTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> QuickBatarangTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// ByteProperty: LastFootPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil.EFootSyncPoint LastFootPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.EFootSyncPoint>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// ByteProperty: LastMirrorChoice
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil.EMirrorChoice LastMirrorChoice
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.EMirrorChoice>(Ptr + 1177); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1177); }
    }

    /// <summary>
    /// ByteProperty: OldThrowType
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.BatarangThrowType OldThrowType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.BatarangThrowType>(Ptr + 1178); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1178); }
    }

    /// <summary>
    /// ByteProperty: ComboMoveType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EComboMoveType ComboMoveType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EComboMoveType>(Ptr + 1179); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1179); }
    }

    /// <summary>
    /// IntProperty: MaxNumEnemiesHit
    /// </summary>
    public unsafe int MaxNumEnemiesHit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: ThrowDirectionTypes
    /// </summary>
    public InlineArray<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer> ThrowDirectionTypes => new(11, Ptr + 1184, 12, this);

    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1184);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1196);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1208);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1220);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1232);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1244);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1256);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1268);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1280);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_9
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1292);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_10
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1304);

    /// <summary>
    /// ClassProperty: BatarangCameraClass
    /// </summary>
    public unsafe BmSDK.Class BatarangCameraClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// ClassProperty: BatarangProjectileClass
    /// </summary>
    public unsafe BmSDK.Class BatarangProjectileClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// FloatProperty: BatarangCameraDelay
    /// </summary>
    public unsafe float BatarangCameraDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// FloatProperty: ThrowFinishedTimeout
    /// </summary>
    public unsafe float ThrowFinishedTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// IntProperty: bIsHeatGadgetEnable
    /// </summary>
    public unsafe int bIsHeatGadgetEnable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }

    /// <summary>
    /// IntProperty: CurrentHeatGadgetStatus
    /// </summary>
    public unsafe int CurrentHeatGadgetStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }

    /// <summary>
    /// IntProperty: CustomHeatGadgetFlags
    /// </summary>
    public unsafe int CustomHeatGadgetFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }
}
