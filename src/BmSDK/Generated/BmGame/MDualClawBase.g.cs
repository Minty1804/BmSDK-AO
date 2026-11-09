#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: MDualClawBase<br/>
/// (size = 1364)
/// (flags = 142606515)
/// </summary>
public partial class MDualClawBase : BmSDK.BmGame.RInventoryGadget, BmSDK.BmGame.MDualClawInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MDualClawBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MDualClawBase.
    /// </summary>
    public static MDualClawBase DefaultObject => (MDualClawBase)StaticClass().DefaultObject;

    internal MDualClawBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MDualClawBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MDualClawBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MDualClawBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MDualClawBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MDualClawBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MDualClawBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MDualClawBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MDualClawBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MDualClawBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetAttachBoneNameForPawn;
    /// <summary>
    /// Function: GetAttachBoneNameForPawn
    /// </summary>
    public unsafe virtual BmSDK.FName GetAttachBoneNameForPawn(BmSDK.BmGame.RPawnCombat toVictim, BmSDK.Engine.Actor fromActor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAttachBoneNameForPawn, "BmGame.MDualClawBase.GetAttachBoneNameForPawn");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(toVictim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fromActor, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanThrowGadget;
    /// <summary>
    /// Function: CanThrowGadget
    /// </summary>
    public unsafe override bool CanThrowGadget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanThrowGadget, "BmGame.MDualClawBase.CanThrowGadget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnLevelChange;
    /// <summary>
    /// Function: OnLevelChange
    /// </summary>
    public unsafe override void OnLevelChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLevelChange, "BmGame.MDualClawBase.OnLevelChange");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnRoomChange;
    /// <summary>
    /// Function: OnRoomChange
    /// </summary>
    public unsafe override void OnRoomChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRoomChange, "BmGame.MDualClawBase.OnRoomChange");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReplenishAmmo;
    /// <summary>
    /// Function: ReplenishAmmo
    /// </summary>
    public unsafe virtual void ReplenishAmmo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplenishAmmo, "BmGame.MDualClawBase.ReplenishAmmo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DepleteAmmo;
    /// <summary>
    /// Function: DepleteAmmo
    /// </summary>
    public unsafe virtual void DepleteAmmo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DepleteAmmo, "BmGame.MDualClawBase.DepleteAmmo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReduceAmmo;
    /// <summary>
    /// Function: ReduceAmmo
    /// </summary>
    public unsafe virtual void ReduceAmmo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReduceAmmo, "BmGame.MDualClawBase.ReduceAmmo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GadgetUsed;
    /// <summary>
    /// Function: GadgetUsed
    /// </summary>
    public unsafe override void GadgetUsed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GadgetUsed, "BmGame.MDualClawBase.GadgetUsed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOffVisibleSight;
    /// <summary>
    /// Function: TurnOffVisibleSight
    /// </summary>
    public unsafe virtual void TurnOffVisibleSight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffVisibleSight, "BmGame.MDualClawBase.TurnOffVisibleSight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOnVisibleSight;
    /// <summary>
    /// Function: TurnOnVisibleSight
    /// </summary>
    public unsafe virtual void TurnOnVisibleSight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOnVisibleSight, "BmGame.MDualClawBase.TurnOnVisibleSight");
        byte* paramsPtr = stackalloc byte[44];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPlacingReceiver, "BmGame.MDualClawBase.IsPlacingReceiver");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetThrowFinishPose;
    /// <summary>
    /// Function: GetThrowFinishPose
    /// </summary>
    public unsafe virtual BmSDK.FName GetThrowFinishPose(out BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch StanceIsCrouched, out BmSDK.BmGame.RAnimUtil.EMirrorChoice MirroredNess)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThrowFinishPose, "BmGame.MDualClawBase.GetThrowFinishPose");
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

    private static BmSDK.Function __fn_GetFiringAnimationOverlay;
    /// <summary>
    /// Function: GetFiringAnimationOverlay
    /// </summary>
    public unsafe virtual BmSDK.FName GetFiringAnimationOverlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFiringAnimationOverlay, "BmGame.MDualClawBase.GetFiringAnimationOverlay");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayFiring;
    /// <summary>
    /// Function: PlayFiring
    /// </summary>
    public unsafe virtual void PlayFiring()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFiring, "BmGame.MDualClawBase.PlayFiring");
        byte* paramsPtr = stackalloc byte[53];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireReceiver, "BmGame.MDualClawBase.FireReceiver");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetProjectileThrowAnim;
    /// <summary>
    /// Function: GetProjectileThrowAnim
    /// </summary>
    public unsafe virtual BmSDK.FName GetProjectileThrowAnim(BmSDK.Rotator ThrowDirection, out BmSDK.BmGame.RPawnPlayerAnim.AimingConfigDesc AimingConfig, bool Mirrored)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProjectileThrowAnim, "BmGame.MDualClawBase.GetProjectileThrowAnim");
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

    private static BmSDK.Function __fn_GetThrowReferencePoint;
    /// <summary>
    /// Function: GetThrowReferencePoint
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetThrowReferencePoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThrowReferencePoint, "BmGame.MDualClawBase.GetThrowReferencePoint");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HandlePlayerTick;
    /// <summary>
    /// Function: HandlePlayerTick
    /// </summary>
    public unsafe virtual void HandlePlayerTick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandlePlayerTick, "BmGame.MDualClawBase.HandlePlayerTick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryFireDualCluster;
    /// <summary>
    /// Function: TryFireDualCluster
    /// </summary>
    public unsafe virtual bool TryFireDualCluster()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryFireDualCluster, "BmGame.MDualClawBase.TryFireDualCluster");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HandleButtonPressed;
    /// <summary>
    /// Function: HandleButtonPressed
    /// </summary>
    public unsafe virtual void HandleButtonPressed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleButtonPressed, "BmGame.MDualClawBase.HandleButtonPressed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleSecondaryButtonPressed;
    /// <summary>
    /// Function: HandleSecondaryButtonPressed
    /// </summary>
    public unsafe virtual void HandleSecondaryButtonPressed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleSecondaryButtonPressed, "BmGame.MDualClawBase.HandleSecondaryButtonPressed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ButtonReleased;
    /// <summary>
    /// Function: ButtonReleased
    /// </summary>
    public unsafe override void ButtonReleased()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ButtonReleased, "BmGame.MDualClawBase.ButtonReleased");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SecondaryButtonPressed;
    /// <summary>
    /// Function: SecondaryButtonPressed
    /// </summary>
    public unsafe override void SecondaryButtonPressed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SecondaryButtonPressed, "BmGame.MDualClawBase.SecondaryButtonPressed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SecondaryButtonHeld;
    /// <summary>
    /// Function: SecondaryButtonHeld
    /// </summary>
    public unsafe override void SecondaryButtonHeld()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SecondaryButtonHeld, "BmGame.MDualClawBase.SecondaryButtonHeld");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ButtonHeld;
    /// <summary>
    /// Function: ButtonHeld
    /// </summary>
    public unsafe override void ButtonHeld()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ButtonHeld, "BmGame.MDualClawBase.ButtonHeld");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOffSpecialMoveMode;
    /// <summary>
    /// Function: TurnOffSpecialMoveMode
    /// </summary>
    public unsafe virtual void TurnOffSpecialMoveMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffSpecialMoveMode, "BmGame.MDualClawBase.TurnOffSpecialMoveMode");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearShowdownAimingTarget;
    /// <summary>
    /// Function: ClearShowdownAimingTarget
    /// </summary>
    public unsafe virtual void ClearShowdownAimingTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearShowdownAimingTarget, "BmGame.MDualClawBase.ClearShowdownAimingTarget");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceShowdownAimingTarget;
    /// <summary>
    /// Function: ForceShowdownAimingTarget
    /// </summary>
    public unsafe virtual void ForceShowdownAimingTarget(bool AimingLeft)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceShowdownAimingTarget, "BmGame.MDualClawBase.ForceShowdownAimingTarget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimingLeft, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOnSpecialMoveMode;
    /// <summary>
    /// Function: TurnOnSpecialMoveMode
    /// </summary>
    public unsafe virtual void TurnOnSpecialMoveMode(System.Numerics.Vector3 ShowdownLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOnSpecialMoveMode, "BmGame.MDualClawBase.TurnOnSpecialMoveMode");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShowdownLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindShowdownHarpoons;
    /// <summary>
    /// Function: FindShowdownHarpoons
    /// </summary>
    public unsafe virtual void FindShowdownHarpoons(System.Numerics.Vector3 ShowdownLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindShowdownHarpoons, "BmGame.MDualClawBase.FindShowdownHarpoons");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShowdownLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SecondaryFireReleased;
    /// <summary>
    /// Function: SecondaryFireReleased
    /// </summary>
    public unsafe override void SecondaryFireReleased()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SecondaryFireReleased, "BmGame.MDualClawBase.SecondaryFireReleased");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGadgetCamera;
    /// <summary>
    /// Function: GetGadgetCamera
    /// </summary>
    public unsafe override BmSDK.FName GetGadgetCamera(bool InSoftCover = default, BmSDK.BmGame.RInventoryGadget.CoverCornerType CornerType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetCamera, "BmGame.MDualClawBase.GetGadgetCamera");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPrimedPose, "BmGame.MDualClawBase.GetPrimedPose");
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

    private static BmSDK.Function __fn_RemoveDualClawProjectile;
    /// <summary>
    /// Function: RemoveDualClawProjectile
    /// </summary>
    public unsafe virtual bool RemoveDualClawProjectile(BmSDK.BmGame.MDualClawClusterProjectile DualClawClusterProjectile)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveDualClawProjectile, "BmGame.MDualClawBase.RemoveDualClawProjectile");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DualClawClusterProjectile, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_FailedReachedDest;
    /// <summary>
    /// Function: FailedReachedDest
    /// </summary>
    public unsafe virtual void FailedReachedDest(BmSDK.BmGame.MDualClawClusterProjectile DualClawClusterProjectile)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FailedReachedDest, "BmGame.MDualClawBase.FailedReachedDest");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DualClawClusterProjectile, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopFireSoundWithCam;
    /// <summary>
    /// Function: StopFireSoundWithCam
    /// </summary>
    public unsafe virtual void StopFireSoundWithCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopFireSoundWithCam, "BmGame.MDualClawBase.StopFireSoundWithCam");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopDualClawClusterFollowCam;
    /// <summary>
    /// Function: StopDualClawClusterFollowCam
    /// </summary>
    public unsafe virtual void StopDualClawClusterFollowCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopDualClawClusterFollowCam, "BmGame.MDualClawBase.StopDualClawClusterFollowCam");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartDualClawClusterFollowCam;
    /// <summary>
    /// Function: StartDualClawClusterFollowCam
    /// </summary>
    public unsafe virtual void StartDualClawClusterFollowCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartDualClawClusterFollowCam, "BmGame.MDualClawBase.StartDualClawClusterFollowCam");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateLaserSight;
    /// <summary>
    /// Function: UpdateLaserSight
    /// </summary>
    public unsafe virtual void UpdateLaserSight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateLaserSight, "BmGame.MDualClawBase.UpdateLaserSight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateTarget;
    /// <summary>
    /// Function: UpdateTarget
    /// </summary>
    public unsafe virtual void UpdateTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateTarget, "BmGame.MDualClawBase.UpdateTarget");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHelpPrompt, "BmGame.MDualClawBase.GetHelpPrompt");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearAllRopes;
    /// <summary>
    /// Function: ClearAllRopes
    /// </summary>
    public unsafe virtual void ClearAllRopes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearAllRopes, "BmGame.MDualClawBase.ClearAllRopes");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireClusterProjectile;
    /// <summary>
    /// Function: FireClusterProjectile
    /// </summary>
    public unsafe virtual void FireClusterProjectile()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireClusterProjectile, "BmGame.MDualClawBase.FireClusterProjectile");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAimingPositionFromTarget;
    /// <summary>
    /// Function: GetAimingPositionFromTarget
    /// </summary>
    public unsafe virtual void GetAimingPositionFromTarget(BmSDK.Engine.Actor Target, int socketIndex, out System.Numerics.Vector3 AimPos, out BmSDK.FName aimSocket)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAimingPositionFromTarget, "BmGame.MDualClawBase.GetAimingPositionFromTarget");
        byte* paramsPtr = stackalloc byte[140];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(socketIndex, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AimPos);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimPos, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out aimSocket);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aimSocket, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AimPos = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
        aimSocket = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 20);
        return;
    }

    private static BmSDK.Function __fn_CheckAimedTarget;
    /// <summary>
    /// Function: CheckAimedTarget
    /// </summary>
    public unsafe virtual void CheckAimedTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckAimedTarget, "BmGame.MDualClawBase.CheckAimedTarget");
        byte* paramsPtr = stackalloc byte[140];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NewCheckAimedTarget;
    /// <summary>
    /// Function: NewCheckAimedTarget
    /// </summary>
    public unsafe virtual bool NewCheckAimedTarget(BmSDK.Engine.Actor Target, out System.Numerics.Vector3 TargetPosition, out float OverridePriority, out float OverrideMaxRange)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NewCheckAimedTarget, "BmGame.MDualClawBase.NewCheckAimedTarget");
        byte* paramsPtr = stackalloc byte[52];
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

    private static BmSDK.Function __fn_CheckValidThrownObject;
    /// <summary>
    /// Function: CheckValidThrownObject
    /// </summary>
    public unsafe virtual bool CheckValidThrownObject(BmSDK.Engine.Actor Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckValidThrownObject, "BmGame.MDualClawBase.CheckValidThrownObject");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CheckValidHidePoint;
    /// <summary>
    /// Function: CheckValidHidePoint
    /// </summary>
    public unsafe virtual bool CheckValidHidePoint(BmSDK.BmGame.RHidePoint Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckValidHidePoint, "BmGame.MDualClawBase.CheckValidHidePoint");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CheckValidHarpoon;
    /// <summary>
    /// Function: CheckValidHarpoon
    /// </summary>
    public unsafe virtual bool CheckValidHarpoon(BmSDK.Engine.Actor Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckValidHarpoon, "BmGame.MDualClawBase.CheckValidHarpoon");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CheckValidPawn;
    /// <summary>
    /// Function: CheckValidPawn
    /// </summary>
    public unsafe virtual bool CheckValidPawn(BmSDK.BmGame.RPawnVillain Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckValidPawn, "BmGame.MDualClawBase.CheckValidPawn");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CheckActorToActor;
    /// <summary>
    /// Function: CheckActorToActor
    /// </summary>
    public unsafe virtual bool CheckActorToActor(BmSDK.Engine.Actor Target1, BmSDK.Engine.Actor Target2, out float Priority, float DistLimit = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckActorToActor, "BmGame.MDualClawBase.CheckActorToActor");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target2, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Priority);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DistLimit, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Priority = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CheckPawnToVantagePointLimitation;
    /// <summary>
    /// Function: CheckPawnToVantagePointLimitation
    /// </summary>
    public unsafe virtual bool CheckPawnToVantagePointLimitation(BmSDK.BmGame.RHidePoint HidePoint, BmSDK.BmGame.RPawnVillain PawnVillain, out float Priority)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckPawnToVantagePointLimitation, "BmGame.MDualClawBase.CheckPawnToVantagePointLimitation");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HidePoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnVillain, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Priority);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Priority = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CheckFixedTargetLimitations;
    /// <summary>
    /// Function: CheckFixedTargetLimitations
    /// </summary>
    public unsafe virtual bool CheckFixedTargetLimitations(BmSDK.Engine.Actor Target1, BmSDK.Engine.Actor Target2, out float Priority)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckFixedTargetLimitations, "BmGame.MDualClawBase.CheckFixedTargetLimitations");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target2, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Priority);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Priority = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CheckRopeBetweenTarget;
    /// <summary>
    /// Function: CheckRopeBetweenTarget
    /// </summary>
    public unsafe virtual bool CheckRopeBetweenTarget(BmSDK.Engine.Actor Target1, BmSDK.Engine.Actor Target2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckRopeBetweenTarget, "BmGame.MDualClawBase.CheckRopeBetweenTarget");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target2, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetFacingTarget;
    /// <summary>
    /// Function: GetFacingTarget
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetFacingTarget(BmSDK.Engine.Actor Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFacingTarget, "BmGame.MDualClawBase.GetFacingTarget");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UpdateNewTargeting;
    /// <summary>
    /// Function: UpdateNewTargeting
    /// </summary>
    public unsafe virtual void UpdateNewTargeting()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateNewTargeting, "BmGame.MDualClawBase.UpdateNewTargeting");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateDualTarget;
    /// <summary>
    /// Function: UpdateDualTarget
    /// </summary>
    public unsafe virtual void UpdateDualTarget(out BmSDK.Engine.Actor Target, out int targetSocketIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateDualTarget, "BmGame.MDualClawBase.UpdateDualTarget");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Target);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out targetSocketIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(targetSocketIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Target = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 0);
        targetSocketIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_GetPotentialTargetPositions;
    /// <summary>
    /// Function: GetPotentialTargetPositions
    /// </summary>
    public unsafe override bool GetPotentialTargetPositions(BmSDK.Engine.Actor Target, in System.Numerics.Vector3 InTargetPosition, out BmSDK.TArray<System.Numerics.Vector3> PotentialTargetPositions)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPotentialTargetPositions, "BmGame.MDualClawBase.GetPotentialTargetPositions");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTargetPosition, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PotentialTargetPositions = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<System.Numerics.Vector3>>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_CheckTargetToTarget;
    /// <summary>
    /// Function: CheckTargetToTarget
    /// </summary>
    public unsafe virtual bool CheckTargetToTarget(BmSDK.Engine.Actor FirstTarget, System.Numerics.Vector3 FirstPosition, BmSDK.Engine.Actor SecondTarget, System.Numerics.Vector3 SecondPosition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckTargetToTarget, "BmGame.MDualClawBase.CheckTargetToTarget");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FirstTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FirstPosition, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SecondTarget, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SecondPosition, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_CheckIfHostageTaker;
    /// <summary>
    /// Function: CheckIfHostageTaker
    /// </summary>
    public unsafe virtual bool CheckIfHostageTaker(BmSDK.Engine.Actor Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckIfHostageTaker, "BmGame.MDualClawBase.CheckIfHostageTaker");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CheckRangeLimitation;
    /// <summary>
    /// Function: CheckRangeLimitation
    /// </summary>
    public unsafe virtual bool CheckRangeLimitation(BmSDK.Engine.Actor FirstTarget, System.Numerics.Vector3 FirstPosition, BmSDK.Engine.Actor SecondTarget, System.Numerics.Vector3 SecondPosition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckRangeLimitation, "BmGame.MDualClawBase.CheckRangeLimitation");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FirstTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FirstPosition, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SecondTarget, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SecondPosition, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_CheckVantagePointRestriction;
    /// <summary>
    /// Function: CheckVantagePointRestriction
    /// </summary>
    public unsafe virtual bool CheckVantagePointRestriction(BmSDK.Engine.Actor FirstTarget, BmSDK.Engine.Actor SecondTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckVantagePointRestriction, "BmGame.MDualClawBase.CheckVantagePointRestriction");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FirstTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SecondTarget, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CheckFixedTargets;
    /// <summary>
    /// Function: CheckFixedTargets
    /// </summary>
    public unsafe virtual bool CheckFixedTargets(BmSDK.Engine.Actor Target1, BmSDK.Engine.Actor Target2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckFixedTargets, "BmGame.MDualClawBase.CheckFixedTargets");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target2, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CheckAutoTarget;
    /// <summary>
    /// Function: CheckAutoTarget
    /// </summary>
    public unsafe override bool CheckAutoTarget(BmSDK.Engine.Actor Target, out System.Numerics.Vector3 TargetPosition, out float OverridePriority, out float OverrideMaxRange)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckAutoTarget, "BmGame.MDualClawBase.CheckAutoTarget");
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

    private static BmSDK.Function __fn_CheckIsTargetAlreadyUsed;
    /// <summary>
    /// Function: CheckIsTargetAlreadyUsed
    /// </summary>
    public unsafe virtual bool CheckIsTargetAlreadyUsed(BmSDK.Engine.Actor Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckIsTargetAlreadyUsed, "BmGame.MDualClawBase.CheckIsTargetAlreadyUsed");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ResetTargets;
    /// <summary>
    /// Function: ResetTargets
    /// </summary>
    public unsafe virtual void ResetTargets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetTargets, "BmGame.MDualClawBase.ResetTargets");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdatePossibleTargets;
    /// <summary>
    /// Function: UpdatePossibleTargets
    /// </summary>
    public unsafe virtual void UpdatePossibleTargets(BmSDK.Engine.Canvas HudCanvas)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePossibleTargets, "BmGame.MDualClawBase.UpdatePossibleTargets");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HudCanvas, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawAimingHUD, "BmGame.MDualClawBase.DrawAimingHUD");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawPos;
    /// <summary>
    /// Function: DrawPos
    /// </summary>
    public unsafe virtual void DrawPos(BmSDK.Engine.Canvas HudCanvas, System.Numerics.Vector3 PosToDraw, int CursorIndex, BmSDK.FString AnimName, bool ClearCursor = default, bool SnapToPosition = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawPos, "BmGame.MDualClawBase.DrawPos");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HudCanvas, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PosToDraw, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorIndex, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClearCursor, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SnapToPosition, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckRopeIntersection;
    /// <summary>
    /// Function: CheckRopeIntersection
    /// </summary>
    public unsafe virtual bool CheckRopeIntersection(System.Numerics.Vector3 RopeStart1, System.Numerics.Vector3 RopeEnd1, System.Numerics.Vector3 RopeStart2, System.Numerics.Vector3 RopeEnd2, float MinRopeSquareDistRef = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckRopeIntersection, "BmGame.MDualClawBase.CheckRopeIntersection");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RopeStart1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RopeEnd1, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RopeStart2, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RopeEnd2, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinRopeSquareDistRef, paramsPtr + 48);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 52);
    }

    private static BmSDK.Function __fn_FindPossibleTargets;
    /// <summary>
    /// Function: FindPossibleTargets
    /// </summary>
    public unsafe virtual void FindPossibleTargets(System.Numerics.Vector3 LaunchPosition, BmSDK.Rotator LaunchAngle, float Range, out BmSDK.TArray<BmSDK.Engine.Actor> Targets, out BmSDK.TArray<System.Numerics.Vector3> Locs)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPossibleTargets, "BmGame.MDualClawBase.FindPossibleTargets");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaunchPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaunchAngle, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Range, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Targets = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor>>(paramsPtr + 28);
        Locs = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<System.Numerics.Vector3>>(paramsPtr + 40);
        return;
    }

    private static BmSDK.Function __fn_FindProposedTarget;
    /// <summary>
    /// Function: FindProposedTarget
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor FindProposedTarget(System.Numerics.Vector3 LaunchPosition, float Range)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindProposedTarget, "BmGame.MDualClawBase.FindProposedTarget");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaunchPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Range, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CheckLineTargets;
    /// <summary>
    /// Function: CheckLineTargets
    /// </summary>
    public unsafe virtual bool CheckLineTargets(BmSDK.Engine.Actor FirstTarget, BmSDK.Engine.Actor SecondTarget, System.Numerics.Vector3 TraceEnd, System.Numerics.Vector3 TraceStart)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckLineTargets, "BmGame.MDualClawBase.CheckLineTargets");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FirstTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SecondTarget, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceEnd, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceStart, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_TraceTargets;
    /// <summary>
    /// Function: TraceTargets
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor TraceTargets(out System.Numerics.Vector3 HitLocation, out BmSDK.Engine.Actor.FTraceHitInfo HitInfo, System.Numerics.Vector3 TraceEnd, System.Numerics.Vector3 TraceStart)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TraceTargets, "BmGame.MDualClawBase.TraceTargets");
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

    private static BmSDK.Function __fn_FindAimingTargets;
    /// <summary>
    /// Function: FindAimingTargets
    /// </summary>
    public unsafe virtual void FindAimingTargets(System.Numerics.Vector3 LaunchPosition, BmSDK.Rotator LaunchAngle, float Range, float TargetAngle, out BmSDK.TArray<BmSDK.Engine.Actor> Targets, out BmSDK.TArray<int> PositionIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindAimingTargets, "BmGame.MDualClawBase.FindAimingTargets");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaunchPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaunchAngle, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Range, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetAngle, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Targets = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor>>(paramsPtr + 32);
        PositionIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<int>>(paramsPtr + 44);
        return;
    }

    private static BmSDK.Function __fn_GetMaxRope;
    /// <summary>
    /// Function: GetMaxRope
    /// </summary>
    public unsafe virtual int GetMaxRope()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxRope, "BmGame.MDualClawBase.GetMaxRope");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanZipLine;
    /// <summary>
    /// Function: CanZipLine
    /// </summary>
    public unsafe virtual bool CanZipLine()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanZipLine, "BmGame.MDualClawBase.CanZipLine");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanDoTakedown;
    /// <summary>
    /// Function: CanDoTakedown
    /// </summary>
    public unsafe virtual bool CanDoTakedown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoTakedown, "BmGame.MDualClawBase.CanDoTakedown");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayFirstFireSound;
    /// <summary>
    /// Function: PlayFirstFireSound
    /// </summary>
    public unsafe virtual void PlayFirstFireSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFirstFireSound, "BmGame.MDualClawBase.PlayFirstFireSound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerFireFX;
    /// <summary>
    /// Function: TriggerFireFX
    /// </summary>
    public unsafe virtual void TriggerFireFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerFireFX, "BmGame.MDualClawBase.TriggerFireFX");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDualClawMesh;
    /// <summary>
    /// Function: GetDualClawMesh
    /// </summary>
    public unsafe virtual BmSDK.Engine.SkeletalMeshComponent GetDualClawMesh()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDualClawMesh, "BmGame.MDualClawBase.GetDualClawMesh");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.SkeletalMeshComponent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGadgetConfig;
    /// <summary>
    /// Function: GetGadgetConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MInventoryGadgetConfig_DualClawBase GetGadgetConfig()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetConfig, "BmGame.MDualClawBase.GetGadgetConfig");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MInventoryGadgetConfig_DualClawBase>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHidePointWireClass;
    /// <summary>
    /// Function: GetHidePointWireClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetHidePointWireClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHidePointWireClass, "BmGame.MDualClawBase.GetHidePointWireClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDualClawProjectileClass;
    /// <summary>
    /// Function: GetDualClawProjectileClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetDualClawProjectileClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDualClawProjectileClass, "BmGame.MDualClawBase.GetDualClawProjectileClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDualClawConfig;
    /// <summary>
    /// Function: GetDualClawConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MInventoryGadgetConfig_DualClawBase GetDualClawConfig()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDualClawConfig, "BmGame.MDualClawBase.GetDualClawConfig");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MInventoryGadgetConfig_DualClawBase>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpawnClusterProjectileNotify;
    /// <summary>
    /// Function: SpawnClusterProjectileNotify
    /// </summary>
    public unsafe virtual void SpawnClusterProjectileNotify()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnClusterProjectileNotify, "BmGame.MDualClawBase.SpawnClusterProjectileNotify");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldAimAt;
    /// <summary>
    /// Function: ShouldAimAt
    /// </summary>
    public unsafe override bool ShouldAimAt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldAimAt, "BmGame.MDualClawBase.ShouldAimAt");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopZipLineHandle;
    /// <summary>
    /// Function: StopZipLineHandle
    /// </summary>
    public unsafe virtual void StopZipLineHandle()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopZipLineHandle, "BmGame.MDualClawBase.StopZipLineHandle");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartZipLineHandle;
    /// <summary>
    /// Function: StartZipLineHandle
    /// </summary>
    public unsafe virtual void StartZipLineHandle()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartZipLineHandle, "BmGame.MDualClawBase.StartZipLineHandle");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnequipZipLineHandle;
    /// <summary>
    /// Function: UnequipZipLineHandle
    /// </summary>
    public unsafe virtual void UnequipZipLineHandle()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnequipZipLineHandle, "BmGame.MDualClawBase.UnequipZipLineHandle");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EquipZipLineHandle;
    /// <summary>
    /// Function: EquipZipLineHandle
    /// </summary>
    public unsafe virtual void EquipZipLineHandle()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EquipZipLineHandle, "BmGame.MDualClawBase.EquipZipLineHandle");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EquipZipLineHook;
    /// <summary>
    /// Function: EquipZipLineHook
    /// </summary>
    public unsafe virtual void EquipZipLineHook()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EquipZipLineHook, "BmGame.MDualClawBase.EquipZipLineHook");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnequipZipLineHook;
    /// <summary>
    /// Function: UnequipZipLineHook
    /// </summary>
    public unsafe virtual void UnequipZipLineHook()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnequipZipLineHook, "BmGame.MDualClawBase.UnequipZipLineHook");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateZipLineHook;
    /// <summary>
    /// Function: CreateZipLineHook
    /// </summary>
    public unsafe virtual void CreateZipLineHook()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateZipLineHook, "BmGame.MDualClawBase.CreateZipLineHook");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckExtraAmmo;
    /// <summary>
    /// Function: CheckExtraAmmo
    /// </summary>
    public unsafe virtual void CheckExtraAmmo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckExtraAmmo, "BmGame.MDualClawBase.CheckExtraAmmo");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.MDualClawBase.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: mAimingTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor mAimingTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// StructProperty: mAimingTargetPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 mAimingTargetPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 988);

    /// <summary>
    /// NameProperty: mAimingTargetSocket
    /// </summary>
    public unsafe BmSDK.FName mAimingTargetSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// IntProperty: mAimingTargetSocketIndex
    /// </summary>
    public unsafe int mAimingTargetSocketIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// ObjectProperty: mAimedTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor mAimedTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// StructProperty: mAimedTargetPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 mAimedTargetPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1016);

    /// <summary>
    /// NameProperty: mAimedTargetSocket
    /// </summary>
    public unsafe BmSDK.FName mAimedTargetSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// IntProperty: mAimedTargetSocketIndex
    /// </summary>
    public unsafe int mAimedTargetSocketIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// ObjectProperty: mPrimaryTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor mPrimaryTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// StructProperty: mPrimaryTargetPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 mPrimaryTargetPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1044);

    /// <summary>
    /// NameProperty: mPrimaryTargetSocket
    /// </summary>
    public unsafe BmSDK.FName mPrimaryTargetSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// IntProperty: mPrimaryTargetSocketIndex
    /// </summary>
    public unsafe int mPrimaryTargetSocketIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// ObjectProperty: mSecondaryTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor mSecondaryTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// StructProperty: mSecondaryTargetPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 mSecondaryTargetPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1072);

    /// <summary>
    /// NameProperty: mSecondaryTargetSocket
    /// </summary>
    public unsafe BmSDK.FName mSecondaryTargetSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// IntProperty: mSecondaryTargetSocketIndex
    /// </summary>
    public unsafe int mSecondaryTargetSocketIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// ClassProperty: mHidePointWireClass
    /// </summary>
    public unsafe BmSDK.Class mHidePointWireClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ClassProperty: mDualClawProjectileClass
    /// </summary>
    public unsafe BmSDK.Class mDualClawProjectileClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// ClassProperty: mDualClawClusterProjectileClass
    /// </summary>
    public unsafe BmSDK.Class mDualClawClusterProjectileClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ComponentProperty: LaserSight
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent LaserSight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// ObjectProperty: MuzzleFlashFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem MuzzleFlashFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: mClusterProjectile
    /// </summary>
    public InlineArray<BmSDK.BmGame.MDualClawClusterProjectile> mClusterProjectile => new(3, Ptr + 1116, 4, this);

    /// <summary>
    /// ObjectProperty: mClusterProjectile
    /// </summary>
    public unsafe BmSDK.BmGame.MDualClawClusterProjectile mClusterProjectile_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MDualClawClusterProjectile>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }
    /// <summary>
    /// ObjectProperty: mClusterProjectile
    /// </summary>
    public unsafe BmSDK.BmGame.MDualClawClusterProjectile mClusterProjectile_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MDualClawClusterProjectile>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }
    /// <summary>
    /// ObjectProperty: mClusterProjectile
    /// </summary>
    public unsafe BmSDK.BmGame.MDualClawClusterProjectile mClusterProjectile_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MDualClawClusterProjectile>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// IntProperty: mCurrentActiveClusterIndex
    /// </summary>
    public unsafe int mCurrentActiveClusterIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: mIsInDualClawMode
    /// </summary>
    public unsafe bool mIsInDualClawMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1132); }
    }

    /// <summary>
    /// BoolProperty: mIsInSpecialMoveMode
    /// </summary>
    public unsafe bool mIsInSpecialMoveMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1132); }
    }

    /// <summary>
    /// BoolProperty: bSpecialMoveDrawAiming
    /// </summary>
    public unsafe bool bSpecialMoveDrawAiming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1132); }
    }

    /// <summary>
    /// BoolProperty: UsingLockTargeting
    /// </summary>
    public unsafe bool UsingLockTargeting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1132); }
    }

    /// <summary>
    /// BoolProperty: HasFiredProjectile
    /// </summary>
    public unsafe bool HasFiredProjectile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1132); }
    }

    /// <summary>
    /// BoolProperty: ForceFollowingCam
    /// </summary>
    public unsafe bool ForceFollowingCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1132); }
    }

    /// <summary>
    /// ObjectProperty: mRedLaserEffectMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant mRedLaserEffectMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// ObjectProperty: mGreenLaserEffectMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant mGreenLaserEffectMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// ObjectProperty: mOrangeLaserEffectMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant mOrangeLaserEffectMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// ObjectProperty: mDualClawConfig
    /// </summary>
    public unsafe BmSDK.BmGame.MInventoryGadgetConfig_DualClawBase mDualClawConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MInventoryGadgetConfig_DualClawBase>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// ObjectProperty: mCurrentClusterProjectile
    /// </summary>
    public unsafe BmSDK.BmGame.MDualClawClusterProjectile mCurrentClusterProjectile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MDualClawClusterProjectile>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// StructProperty: FirstFireSoundWithCamHandle
    /// </summary>
    public unsafe ref BmSDK.Engine.AkWwise.FAkSoundHandle FirstFireSoundWithCamHandle
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 1156);

    /// <summary>
    /// StructProperty: PlaceReceiverOverlay
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId PlaceReceiverOverlay
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(Ptr + 1168);

    /// <summary>
    /// InlineArray{StructProperty}: ThrowDirectionTypes
    /// </summary>
    public InlineArray<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer> ThrowDirectionTypes => new(11, Ptr + 1176, 12, this);

    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1176);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1188);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1200);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1212);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1224);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1236);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1248);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1260);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1272);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_9
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1284);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_10
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 1296);

    /// <summary>
    /// ByteProperty: GadgetUnlockRCVantagePointThug
    /// </summary>
    public unsafe BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility GadgetUnlockRCVantagePointThug
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// ByteProperty: GadgetUnlockRCTakedown
    /// </summary>
    public unsafe BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility GadgetUnlockRCTakedown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility>(Ptr + 1309); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1309); }
    }

    /// <summary>
    /// ByteProperty: GadgetUnlockRCAdditionalLine
    /// </summary>
    public unsafe BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility GadgetUnlockRCAdditionalLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility>(Ptr + 1310); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1310); }
    }

    /// <summary>
    /// ObjectProperty: ShowdownFirstHarpoon
    /// </summary>
    public unsafe BmSDK.BmGame.RHarpoonTriggerBase ShowdownFirstHarpoon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHarpoonTriggerBase>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }

    /// <summary>
    /// ObjectProperty: ShowdownSecondHarpoon
    /// </summary>
    public unsafe BmSDK.BmGame.RHarpoonTriggerBase ShowdownSecondHarpoon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHarpoonTriggerBase>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// ComponentProperty: ZipHandleSkMeshComponent
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent ZipHandleSkMeshComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// ComponentProperty: ZipHandleSFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ZipHandleSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// StructProperty: HookRelativePosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HookRelativePosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1328);

    /// <summary>
    /// StructProperty: HookRelativeRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator HookRelativeRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1340);

    /// <summary>
    /// ObjectProperty: ZipLoopEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ZipLoopEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// ObjectProperty: ZipLineEndEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ZipLineEndEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// IntProperty: FakeMaxAmmo
    /// </summary>
    public unsafe int FakeMaxAmmo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }
}
