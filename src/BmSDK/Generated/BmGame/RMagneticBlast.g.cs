#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RMagneticBlast<br/>
/// (size = 1308)
/// (flags = 142606514)
/// </summary>
public partial class RMagneticBlast : BmSDK.BmGame.RInventoryGadget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RMagneticBlast", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RMagneticBlast.
    /// </summary>
    public static RMagneticBlast DefaultObject => (RMagneticBlast)StaticClass().DefaultObject;

    internal RMagneticBlast() { }

    /// <summary>
    /// Constructs a new RMagneticBlast
    /// </summary>
    public RMagneticBlast(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RMagneticBlast(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMagneticBlast>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticBlast>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMagneticBlast>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticBlast>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticBlast>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticBlast>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMagneticBlast>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticBlast>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ShouldAimAt;
    /// <summary>
    /// Function: ShouldAimAt
    /// </summary>
    public unsafe override bool ShouldAimAt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldAimAt, "BmGame.RMagneticBlast.ShouldAimAt");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RemoveReceiver;
    /// <summary>
    /// Function: RemoveReceiver
    /// </summary>
    public unsafe virtual void RemoveReceiver(BmSDK.BmGame.RMagneticBlastReceiver Receiver)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveReceiver, "BmGame.RMagneticBlast.RemoveReceiver");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Receiver, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPotentialTargetPositions;
    /// <summary>
    /// Function: GetPotentialTargetPositions
    /// </summary>
    public unsafe override bool GetPotentialTargetPositions(BmSDK.Engine.Actor Target, in System.Numerics.Vector3 InTargetPosition, out BmSDK.TArray<System.Numerics.Vector3> PotentialTargetPositions)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPotentialTargetPositions, "BmGame.RMagneticBlast.GetPotentialTargetPositions");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTargetPosition, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PotentialTargetPositions = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<System.Numerics.Vector3>>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_CheckAutoTarget;
    /// <summary>
    /// Function: CheckAutoTarget
    /// </summary>
    public unsafe override bool CheckAutoTarget(BmSDK.Engine.Actor Target, out System.Numerics.Vector3 TargetPosition, out float OverridePriority, out float OverrideMaxRange)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckAutoTarget, "BmGame.RMagneticBlast.CheckAutoTarget");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TargetPosition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPosition, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OverridePriority);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverridePriority, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OverrideMaxRange);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideMaxRange, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TargetPosition = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
        OverridePriority = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
        OverrideMaxRange = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetThrowFinishPose;
    /// <summary>
    /// Function: GetThrowFinishPose
    /// </summary>
    public unsafe virtual BmSDK.FName GetThrowFinishPose(out BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch StanceIsCrouched, out BmSDK.BmGame.RAnimUtil.EMirrorChoice MirroredNess)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThrowFinishPose, "BmGame.RMagneticBlast.GetThrowFinishPose");
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

    private static BmSDK.Function __fn_GetProjectileThrowAnim;
    /// <summary>
    /// Function: GetProjectileThrowAnim
    /// </summary>
    public unsafe virtual BmSDK.FName GetProjectileThrowAnim(BmSDK.Rotator ThrowDirection, out BmSDK.BmGame.RPawnPlayerAnim.AimingConfigDesc AimingConfig, bool Mirrored)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProjectileThrowAnim, "BmGame.RMagneticBlast.GetProjectileThrowAnim");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowDirection, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AimingConfig);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimingConfig, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AimingConfig = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayerAnim.AimingConfigDesc>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_UpdateAutoTarget;
    /// <summary>
    /// Function: UpdateAutoTarget
    /// </summary>
    public unsafe virtual void UpdateAutoTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateAutoTarget, "BmGame.RMagneticBlast.UpdateAutoTarget");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishFiring;
    /// <summary>
    /// Function: FinishFiring
    /// </summary>
    public unsafe virtual void FinishFiring()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishFiring, "BmGame.RMagneticBlast.FinishFiring");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireMagBlast;
    /// <summary>
    /// Function: FireMagBlast
    /// </summary>
    public unsafe virtual void FireMagBlast()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireMagBlast, "BmGame.RMagneticBlast.FireMagBlast");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireGadgetCombat;
    /// <summary>
    /// Function: FireGadgetCombat
    /// </summary>
    public unsafe override bool FireGadgetCombat()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireGadgetCombat, "BmGame.RMagneticBlast.FireGadgetCombat");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetThrowReferencePoint;
    /// <summary>
    /// Function: GetThrowReferencePoint
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetThrowReferencePoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThrowReferencePoint, "BmGame.RMagneticBlast.GetThrowReferencePoint");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShowReceiver;
    /// <summary>
    /// Function: ShowReceiver
    /// </summary>
    public unsafe virtual void ShowReceiver(bool bShow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowReceiver, "BmGame.RMagneticBlast.ShowReceiver");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReloadProjectile;
    /// <summary>
    /// Function: ReloadProjectile
    /// </summary>
    public unsafe virtual void ReloadProjectile()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReloadProjectile, "BmGame.RMagneticBlast.ReloadProjectile");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowHideMagBlastParts;
    /// <summary>
    /// Function: ShowHideMagBlastParts
    /// </summary>
    public unsafe virtual void ShowHideMagBlastParts(bool bPrimary, bool bFront, bool bShow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowHideMagBlastParts, "BmGame.RMagneticBlast.ShowHideMagBlastParts");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPrimary, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFront, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsInRangeOfMagneticSurface;
    /// <summary>
    /// Function: IsInRangeOfMagneticSurface
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 IsInRangeOfMagneticSurface(BmSDK.BmGame.RBMCombatThrownObject TestActor, out System.Numerics.Vector3 SourceLocation, bool bInformReceiver, out float Strength, out float ChargeTimer, out float ChargeDuration)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInRangeOfMagneticSurface, "BmGame.RMagneticBlast.IsInRangeOfMagneticSurface");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestActor, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SourceLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SourceLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInformReceiver, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Strength);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Strength, paramsPtr + 20);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ChargeTimer);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChargeTimer, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ChargeDuration);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChargeDuration, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SourceLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
        Strength = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 20);
        ChargeTimer = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 24);
        ChargeDuration = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_OnRoomChange;
    /// <summary>
    /// Function: OnRoomChange
    /// </summary>
    public unsafe override void OnRoomChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRoomChange, "BmGame.RMagneticBlast.OnRoomChange");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerFailedEvent;
    /// <summary>
    /// Function: TriggerFailedEvent
    /// </summary>
    public unsafe virtual void TriggerFailedEvent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerFailedEvent, "BmGame.RMagneticBlast.TriggerFailedEvent");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateMagnetStr;
    /// <summary>
    /// Function: UpdateMagnetStr
    /// </summary>
    public unsafe virtual void UpdateMagnetStr(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateMagnetStr, "BmGame.RMagneticBlast.UpdateMagnetStr");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHelpPrompt;
    /// <summary>
    /// Function: GetHelpPrompt
    /// </summary>
    public unsafe override void GetHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHelpPrompt, "BmGame.RMagneticBlast.GetHelpPrompt");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateTargets;
    /// <summary>
    /// Function: UpdateTargets
    /// </summary>
    public unsafe virtual void UpdateTargets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateTargets, "BmGame.RMagneticBlast.UpdateTargets");
        byte* paramsPtr = stackalloc byte[124];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TraceTargets;
    /// <summary>
    /// Function: TraceTargets
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor TraceTargets(out System.Numerics.Vector3 HitLocation, out BmSDK.Engine.Actor.FTraceHitInfo HitInfo, System.Numerics.Vector3 TraceEnd, System.Numerics.Vector3 TraceStart)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TraceTargets, "BmGame.RMagneticBlast.TraceTargets");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitInfo);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceEnd, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceStart, paramsPtr + 60);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HitLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        HitInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FTraceHitInfo>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 72);
    }

    private static BmSDK.Function __fn_DrawTargets;
    /// <summary>
    /// Function: DrawTargets
    /// </summary>
    public unsafe virtual void DrawTargets(BmSDK.Engine.HUD H)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawTargets, "BmGame.RMagneticBlast.DrawTargets");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RMagneticBlast.Tick");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetFiringAnimationOverlay;
    /// <summary>
    /// Function: GetFiringAnimationOverlay
    /// </summary>
    public unsafe virtual BmSDK.FName GetFiringAnimationOverlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFiringAnimationOverlay, "BmGame.RMagneticBlast.GetFiringAnimationOverlay");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGadgetCamera;
    /// <summary>
    /// Function: GetGadgetCamera
    /// </summary>
    public unsafe override BmSDK.FName GetGadgetCamera(bool InSoftCover = default, BmSDK.BmGame.RInventoryGadget.CoverCornerType CornerType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetCamera, "BmGame.RMagneticBlast.GetGadgetCamera");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSoftCover, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetPrimedPose;
    /// <summary>
    /// Function: GetPrimedPose
    /// </summary>
    public unsafe override BmSDK.FName GetPrimedPose(out BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch StanceIsCrouched, out BmSDK.BmGame.RAnimUtil.EMirrorChoice MirroredNess, bool InSoftCover, BmSDK.BmGame.RInventoryGadget.CoverCornerType CornerType, out BmSDK.FName OutCapeState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPrimedPose, "BmGame.RMagneticBlast.GetPrimedPose");
        byte* paramsPtr = stackalloc byte[44];
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

    private static BmSDK.Function __fn_PlayFireSound;
    /// <summary>
    /// Function: PlayFireSound
    /// </summary>
    public unsafe virtual void PlayFireSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFireSound, "BmGame.RMagneticBlast.PlayFireSound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireReceiverProjectile;
    /// <summary>
    /// Function: FireReceiverProjectile
    /// </summary>
    public unsafe virtual void FireReceiverProjectile()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireReceiverProjectile, "BmGame.RMagneticBlast.FireReceiverProjectile");
        byte* paramsPtr = stackalloc byte[104];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireReceiver;
    /// <summary>
    /// Function: FireReceiver
    /// </summary>
    public unsafe virtual void FireReceiver()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireReceiver, "BmGame.RMagneticBlast.FireReceiver");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaceReceiver;
    /// <summary>
    /// Function: PlaceReceiver
    /// </summary>
    public unsafe virtual void PlaceReceiver()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaceReceiver, "BmGame.RMagneticBlast.PlaceReceiver");
        byte* paramsPtr = stackalloc byte[53];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPlacingReceiver;
    /// <summary>
    /// Function: IsPlacingReceiver
    /// </summary>
    public unsafe virtual bool IsPlacingReceiver()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPlacingReceiver, "BmGame.RMagneticBlast.IsPlacingReceiver");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_EquipResSwapLHand;
    /// <summary>
    /// Function: EquipResSwapLHand
    /// </summary>
    public unsafe virtual void EquipResSwapLHand()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EquipResSwapLHand, "BmGame.RMagneticBlast.EquipResSwapLHand");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisassembleMagneticBlast;
    /// <summary>
    /// Function: DisassembleMagneticBlast
    /// </summary>
    public unsafe virtual void DisassembleMagneticBlast()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisassembleMagneticBlast, "BmGame.RMagneticBlast.DisassembleMagneticBlast");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AssembleMagneticBlast;
    /// <summary>
    /// Function: AssembleMagneticBlast
    /// </summary>
    public unsafe virtual void AssembleMagneticBlast()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssembleMagneticBlast, "BmGame.RMagneticBlast.AssembleMagneticBlast");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachToBelt;
    /// <summary>
    /// Function: AttachToBelt
    /// </summary>
    public unsafe override void AttachToBelt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachToBelt, "BmGame.RMagneticBlast.AttachToBelt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachToHand;
    /// <summary>
    /// Function: AttachToHand
    /// </summary>
    public unsafe override void AttachToHand(BmSDK.FName CustomBone = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachToHand, "BmGame.RMagneticBlast.AttachToHand");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomBone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryPlaceReceiver;
    /// <summary>
    /// Function: TryPlaceReceiver
    /// </summary>
    public unsafe virtual void TryPlaceReceiver(BmSDK.BmGame.RMagneticBlast.MBImpulseType NewImpulseType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryPlaceReceiver, "BmGame.RMagneticBlast.TryPlaceReceiver");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewImpulseType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReceiversDeployed;
    /// <summary>
    /// Function: ReceiversDeployed
    /// </summary>
    public unsafe virtual bool ReceiversDeployed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReceiversDeployed, "BmGame.RMagneticBlast.ReceiversDeployed");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayRumble;
    /// <summary>
    /// Function: PlayRumble
    /// </summary>
    public unsafe virtual void PlayRumble()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayRumble, "BmGame.RMagneticBlast.PlayRumble");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateForceZeroAmmo;
    /// <summary>
    /// Function: UpdateForceZeroAmmo
    /// </summary>
    public unsafe virtual void UpdateForceZeroAmmo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateForceZeroAmmo, "BmGame.RMagneticBlast.UpdateForceZeroAmmo");
        byte* paramsPtr = stackalloc byte[16];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RMagneticBlast.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: MBImpulseType
    /// </summary>
    public enum MBImpulseType : byte
    {
        MBI_KeepLast = 0,
        MBI_Repel = 1,
        MBI_Attract = 2,
        MBI_MAX = 3,
    }

    /// <summary>
    /// Enum: MBControlType
    /// </summary>
    public enum MBControlType : byte
    {
        MB_NewControls = 0,
        MB_RubbishOldControls = 1,
        MB_InBetween = 2,
        MB_MAX = 3,
    }

    /// <summary>
    /// ObjectProperty: PlaceReceiverMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PlaceReceiverMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// StructProperty: TargetLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TargetLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 988);

    /// <summary>
    /// ObjectProperty: CurrentReceiverTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor CurrentReceiverTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// StructProperty: DetonatorTransition
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId DetonatorTransition
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 1004);

    /// <summary>
    /// ObjectProperty: ExplodeTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor ExplodeTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// FloatProperty: FirstExplodeTime
    /// </summary>
    public unsafe float FirstExplodeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bForceZeroAmmo
    /// </summary>
    public unsafe bool bForceZeroAmmo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: bCanRepel
    /// </summary>
    public unsafe bool bCanRepel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: bMagBlastAttached
    /// </summary>
    public unsafe bool bMagBlastAttached
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: bDebugForceDisarm
    /// </summary>
    public unsafe bool bDebugForceDisarm
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: bDebugForceFail
    /// </summary>
    public unsafe bool bDebugForceFail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: bCombatFire
    /// </summary>
    public unsafe bool bCombatFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: bQuickDraw
    /// </summary>
    public unsafe bool bQuickDraw
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: HasFiredProjectile
    /// </summary>
    public unsafe bool HasFiredProjectile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: bLockedOn
    /// </summary>
    public unsafe bool bLockedOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: bCenterLightOnReceiver
    /// </summary>
    public unsafe bool bCenterLightOnReceiver
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: bDebugIgnoreNewGamePlus
    /// </summary>
    public unsafe bool bDebugIgnoreNewGamePlus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: bDebugSimulateNoMagBlast
    /// </summary>
    public unsafe bool bDebugSimulateNoMagBlast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: bBlowUpGeneratorsOnImpact
    /// </summary>
    public unsafe bool bBlowUpGeneratorsOnImpact
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// StructProperty: DetonatorSoundHandle
    /// </summary>
    public unsafe ref BmSDK.Engine.AkWwise.FAkSoundHandle DetonatorSoundHandle
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 1020);

    /// <summary>
    /// ObjectProperty: PosFireSwitchName
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName PosFireSwitchName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// ObjectProperty: NegFireSwitchName
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName NegFireSwitchName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// ObjectProperty: FireSoundEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FireSoundEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// ArrayProperty: Receivers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RMagneticBlastReceiver> Receivers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RMagneticBlastReceiver>>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// StructProperty: PlaceReceiverOverlay
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId PlaceReceiverOverlay
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(Ptr + 1056);

    /// <summary>
    /// ObjectProperty: ValidMagneticSurfaceTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticSurfaceSMBase ValidMagneticSurfaceTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticSurfaceSMBase>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// ObjectProperty: MagDoorTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticDynamicObjectSkeletalBase MagDoorTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticDynamicObjectSkeletalBase>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// ObjectProperty: LevelMagDoorTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RLevelTransitionDoorBase LevelMagDoorTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLevelTransitionDoorBase>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ObjectProperty: InteractableItem
    /// </summary>
    public unsafe BmSDK.BmGame.RInteractableItem InteractableItem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInteractableItem>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// ObjectProperty: VillainTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain VillainTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ObjectProperty: HeliTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RHelicopterBase HeliTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHelicopterBase>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// ObjectProperty: CurrentTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain CurrentTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// ByteProperty: LastMirrorChoice
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil.EMirrorChoice LastMirrorChoice
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.EMirrorChoice>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// ByteProperty: ImpulseType
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticBlast.MBImpulseType ImpulseType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticBlast.MBImpulseType>(Ptr + 1093); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1093); }
    }

    /// <summary>
    /// ByteProperty: ControlType
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticBlast.MBControlType ControlType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticBlast.MBControlType>(Ptr + 1094); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1094); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: ThrowDirectionTypes
    /// </summary>
    public InlineArray<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer> ThrowDirectionTypes => new(11, Ptr + 1096, 12, this);

    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1096);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1108);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1120);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1132);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1144);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1156);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1168);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1180);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1192);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_9
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1204);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_10
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1216);

    /// <summary>
    /// FloatProperty: MagBlastCloseRange
    /// </summary>
    public unsafe float MagBlastCloseRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }

    /// <summary>
    /// FloatProperty: MagBlastArmouredThugRange
    /// </summary>
    public unsafe float MagBlastArmouredThugRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// FloatProperty: MagBlastMaxRange
    /// </summary>
    public unsafe float MagBlastMaxRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }

    /// <summary>
    /// IntProperty: CurrentReceiver
    /// </summary>
    public unsafe int CurrentReceiver
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// ArrayProperty: MainObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> MainObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }

    /// <summary>
    /// ArrayProperty: FrontObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> FrontObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// ArrayProperty: ReceiverObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> ReceiverObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// ClassProperty: ProjectileClass
    /// </summary>
    public unsafe BmSDK.Class ProjectileClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// FloatProperty: ArmouredThugImpulse
    /// </summary>
    public unsafe float ArmouredThugImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// FloatProperty: ArmouredThugImpulsePitch
    /// </summary>
    public unsafe float ArmouredThugImpulsePitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// FloatProperty: ArmouredThugRagdollMassScale
    /// </summary>
    public unsafe float ArmouredThugRagdollMassScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }

    /// <summary>
    /// FloatProperty: ArmouredThugExtraRagdollRadius
    /// </summary>
    public unsafe float ArmouredThugExtraRagdollRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// ObjectProperty: MuzzleFlash
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem MuzzleFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// ObjectProperty: rumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform rumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }
}
