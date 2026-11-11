#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDPlayerControllerCombatThug<br/>
/// (size = 6072)
/// (flags = 144736406)
/// </summary>
public partial class GDPlayerControllerCombatThug : BmSDK.BmGame.RPlayerControllerCombat, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDPlayerControllerCombatThug", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDPlayerControllerCombatThug.
    /// </summary>
    public static GDPlayerControllerCombatThug DefaultObject => (GDPlayerControllerCombatThug)StaticClass().DefaultObject;

    internal GDPlayerControllerCombatThug() { }

    /// <summary>
    /// Constructs a new GDPlayerControllerCombatThug
    /// </summary>
    public GDPlayerControllerCombatThug(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDPlayerControllerCombatThug(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDPlayerControllerCombatThug>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPlayerControllerCombatThug>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDPlayerControllerCombatThug>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPlayerControllerCombatThug>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPlayerControllerCombatThug>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPlayerControllerCombatThug>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDPlayerControllerCombatThug>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPlayerControllerCombatThug>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetDelayedCharacterTransitionSpectate;
    /// <summary>
    /// Function: SetDelayedCharacterTransitionSpectate
    /// </summary>
    public unsafe virtual void SetDelayedCharacterTransitionSpectate(float EndSpectateTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDelayedCharacterTransitionSpectate, "BmGame.GDPlayerControllerCombatThug.SetDelayedCharacterTransitionSpectate");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndSpectateTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDelayedCharacterTransitionFreeze;
    /// <summary>
    /// Function: SetDelayedCharacterTransitionFreeze
    /// </summary>
    public unsafe virtual void SetDelayedCharacterTransitionFreeze(float FrozenTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDelayedCharacterTransitionFreeze, "BmGame.GDPlayerControllerCombatThug.SetDelayedCharacterTransitionFreeze");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FrozenTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSpectatorTimeRemaining;
    /// <summary>
    /// Function: GetSpectatorTimeRemaining
    /// </summary>
    public unsafe override void GetSpectatorTimeRemaining(out float Progress, out float SecsRemaining)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSpectatorTimeRemaining, "BmGame.GDPlayerControllerCombatThug.GetSpectatorTimeRemaining");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Progress);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Progress, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SecsRemaining);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SecsRemaining, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Progress = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        SecsRemaining = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_ShowFailedGadget;
    /// <summary>
    /// Function: ShowFailedGadget
    /// </summary>
    public unsafe override void ShowFailedGadget(BmSDK.BmGame.RInventoryGadget FailedGadet)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowFailedGadget, "BmGame.GDPlayerControllerCombatThug.ShowFailedGadget");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FailedGadet, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GadgetsUpdated;
    /// <summary>
    /// Function: GadgetsUpdated
    /// </summary>
    public unsafe override void GadgetsUpdated()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GadgetsUpdated, "BmGame.GDPlayerControllerCombatThug.GadgetsUpdated");
        byte* paramsPtr = stackalloc byte[116];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetLastGadget;
    /// <summary>
    /// Function: GetLastGadget
    /// </summary>
    public unsafe override BmSDK.BmGame.RInventoryGadget GetLastGadget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLastGadget, "BmGame.GDPlayerControllerCombatThug.GetLastGadget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RInventoryGadget>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InvGadgetSelected;
    /// <summary>
    /// Function: InvGadgetSelected
    /// </summary>
    public unsafe override void InvGadgetSelected(BmSDK.BmGame.RInventoryGadget SelectedGadget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InvGadgetSelected, "BmGame.GDPlayerControllerCombatThug.InvGadgetSelected");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SelectedGadget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleForcedMovement;
    /// <summary>
    /// Function: ToggleForcedMovement
    /// </summary>
    public unsafe virtual void ToggleForcedMovement(float _turn, float _move)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleForcedMovement, "BmGame.GDPlayerControllerCombatThug.ToggleForcedMovement");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_turn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_move, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetCoverVariables;
    /// <summary>
    /// Function: ResetCoverVariables
    /// </summary>
    public unsafe virtual void ResetCoverVariables()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetCoverVariables, "BmGame.GDPlayerControllerCombatThug.ResetCoverVariables");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetControlIconForCover;
    /// <summary>
    /// Function: GetControlIconForCover
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHUDPrompt.EControlIcon GetControlIconForCover(BmSDK.BmGame.RHUDPrompt Prompt)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetControlIconForCover, "BmGame.GDPlayerControllerCombatThug.GetControlIconForCover");
        byte* paramsPtr = stackalloc byte[21];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Prompt, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHUDPrompt.EControlIcon>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_StopDualWield;
    /// <summary>
    /// Function: StopDualWield
    /// </summary>
    public unsafe virtual void StopDualWield()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopDualWield, "BmGame.GDPlayerControllerCombatThug.StopDualWield");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DualWield;
    /// <summary>
    /// Function: DualWield
    /// </summary>
    public unsafe virtual void DualWield()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DualWield, "BmGame.GDPlayerControllerCombatThug.DualWield");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanGiveClip;
    /// <summary>
    /// Function: CanGiveClip
    /// </summary>
    public unsafe virtual bool CanGiveClip()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanGiveClip, "BmGame.GDPlayerControllerCombatThug.CanGiveClip");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanUseAmmoCrate;
    /// <summary>
    /// Function: CanUseAmmoCrate
    /// </summary>
    public unsafe virtual bool CanUseAmmoCrate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUseAmmoCrate, "BmGame.GDPlayerControllerCombatThug.CanUseAmmoCrate");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FadeAmmoCrateHUD;
    /// <summary>
    /// Function: FadeAmmoCrateHUD
    /// </summary>
    public unsafe virtual void FadeAmmoCrateHUD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FadeAmmoCrateHUD, "BmGame.GDPlayerControllerCombatThug.FadeAmmoCrateHUD");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartSupervillainTransitionServer;
    /// <summary>
    /// Function: StartSupervillainTransitionServer
    /// </summary>
    public unsafe virtual void StartSupervillainTransitionServer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSupervillainTransitionServer, "BmGame.GDPlayerControllerCombatThug.StartSupervillainTransitionServer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugInteract;
    /// <summary>
    /// Function: ThugInteract
    /// </summary>
    public unsafe virtual void ThugInteract()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugInteract, "BmGame.GDPlayerControllerCombatThug.ThugInteract");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanUseInteractableItem;
    /// <summary>
    /// Function: CanUseInteractableItem
    /// </summary>
    public unsafe virtual bool CanUseInteractableItem()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUseInteractableItem, "BmGame.GDPlayerControllerCombatThug.CanUseInteractableItem");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ToggleViewAccel;
    /// <summary>
    /// Function: ToggleViewAccel
    /// </summary>
    public unsafe virtual void ToggleViewAccel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleViewAccel, "BmGame.GDPlayerControllerCombatThug.ToggleViewAccel");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ModifyPlayerMovement;
    /// <summary>
    /// Function: ModifyPlayerMovement
    /// </summary>
    public unsafe override void ModifyPlayerMovement(out System.Numerics.Vector3 DesiredAccel, float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyPlayerMovement, "BmGame.GDPlayerControllerCombatThug.ModifyPlayerMovement");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DesiredAccel);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredAccel, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DesiredAccel = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_IsStickOrientationValidForQuick180Turn;
    /// <summary>
    /// Function: IsStickOrientationValidForQuick180Turn
    /// </summary>
    public unsafe virtual bool IsStickOrientationValidForQuick180Turn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsStickOrientationValidForQuick180Turn, "BmGame.GDPlayerControllerCombatThug.IsStickOrientationValidForQuick180Turn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShowDashRecoverTime;
    /// <summary>
    /// Function: ShowDashRecoverTime
    /// </summary>
    public unsafe virtual void ShowDashRecoverTime(bool bNotCalledByTimer = default, bool bCoverStateChanged = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowDashRecoverTime, "BmGame.GDPlayerControllerCombatThug.ShowDashRecoverTime");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNotCalledByTimer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCoverStateChanged, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ComputeDashTime;
    /// <summary>
    /// Function: ComputeDashTime
    /// </summary>
    public unsafe virtual bool ComputeDashTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ComputeDashTime, "BmGame.GDPlayerControllerCombatThug.ComputeDashTime");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ModifyRunningMovement;
    /// <summary>
    /// Function: ModifyRunningMovement
    /// </summary>
    public unsafe virtual void ModifyRunningMovement(out System.Numerics.Vector3 DesiredAccel, System.Numerics.Vector3 vCurrentFacing, float TurnRadius, float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyRunningMovement, "BmGame.GDPlayerControllerCombatThug.ModifyRunningMovement");
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DesiredAccel);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredAccel, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vCurrentFacing, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TurnRadius, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DesiredAccel = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_AimDisabled;
    /// <summary>
    /// Function: AimDisabled
    /// </summary>
    public unsafe void AimDisabled()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AimDisabled, "BmGame.GDPlayerControllerCombatThug.AimDisabled");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableAim;
    /// <summary>
    /// Function: EnableAim
    /// </summary>
    public unsafe virtual void EnableAim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableAim, "BmGame.GDPlayerControllerCombatThug.EnableAim");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableAim;
    /// <summary>
    /// Function: DisableAim
    /// </summary>
    public unsafe virtual void DisableAim(float TimeToDisable, bool DisableAdditiveAim = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableAim, "BmGame.GDPlayerControllerCombatThug.DisableAim");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeToDisable, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DisableAdditiveAim, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PickWalkCamera;
    /// <summary>
    /// Function: PickWalkCamera
    /// </summary>
    public unsafe override BmSDK.FName PickWalkCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PickWalkCamera, "BmGame.GDPlayerControllerCombatThug.PickWalkCamera");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpawnFinishedCombatMove;
    /// <summary>
    /// Function: SpawnFinishedCombatMove
    /// </summary>
    public unsafe override void SpawnFinishedCombatMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnFinishedCombatMove, "BmGame.GDPlayerControllerCombatThug.SpawnFinishedCombatMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Frozen;
    /// <summary>
    /// Function: Frozen
    /// </summary>
    public unsafe override void Frozen()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Frozen, "BmGame.GDPlayerControllerCombatThug.Frozen");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckAndSetDashValues;
    /// <summary>
    /// Function: CheckAndSetDashValues
    /// </summary>
    public unsafe virtual void CheckAndSetDashValues()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckAndSetDashValues, "BmGame.GDPlayerControllerCombatThug.CheckAndSetDashValues");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowControllableGadgetTimer;
    /// <summary>
    /// Function: ShowControllableGadgetTimer
    /// </summary>
    public unsafe virtual void ShowControllableGadgetTimer(bool bShow, BmSDK.BmGame.RInventoryGadget Gadget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowControllableGadgetTimer, "BmGame.GDPlayerControllerCombatThug.ShowControllableGadgetTimer");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Gadget, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForControllableGadgetTimer;
    /// <summary>
    /// Function: CheckForControllableGadgetTimer
    /// </summary>
    public unsafe virtual void CheckForControllableGadgetTimer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForControllableGadgetTimer, "BmGame.GDPlayerControllerCombatThug.CheckForControllableGadgetTimer");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawHUD;
    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe override void DrawHUD(BmSDK.Engine.HUD H)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawHUD, "BmGame.GDPlayerControllerCombatThug.DrawHUD");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableDebugLaunchers;
    /// <summary>
    /// Function: EnableDebugLaunchers
    /// </summary>
    public unsafe virtual void EnableDebugLaunchers(bool bEnable)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableDebugLaunchers, "BmGame.GDPlayerControllerCombatThug.EnableDebugLaunchers");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnable, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MakeBatmanLookAtInteractableItems;
    /// <summary>
    /// Function: MakeBatmanLookAtInteractableItems
    /// </summary>
    public unsafe override void MakeBatmanLookAtInteractableItems(System.Numerics.Vector3 Loc, bool bReset = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakeBatmanLookAtInteractableItems, "BmGame.GDPlayerControllerCombatThug.MakeBatmanLookAtInteractableItems");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bReset, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MakeBatmanLookAtInterestingItems;
    /// <summary>
    /// Function: MakeBatmanLookAtInterestingItems
    /// </summary>
    public unsafe override void MakeBatmanLookAtInterestingItems(bool bReset = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakeBatmanLookAtInterestingItems, "BmGame.GDPlayerControllerCombatThug.MakeBatmanLookAtInterestingItems");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bReset, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MakeBatmanLookAtEnemy;
    /// <summary>
    /// Function: MakeBatmanLookAtEnemy
    /// </summary>
    public unsafe override bool MakeBatmanLookAtEnemy(bool bReset = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakeBatmanLookAtEnemy, "BmGame.GDPlayerControllerCombatThug.MakeBatmanLookAtEnemy");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bReset, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ExitAimMode;
    /// <summary>
    /// Function: ExitAimMode
    /// </summary>
    public unsafe virtual void ExitAimMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitAimMode, "BmGame.GDPlayerControllerCombatThug.ExitAimMode");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAimStance;
    /// <summary>
    /// Function: GetAimStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetAimStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAimStance, "BmGame.GDPlayerControllerCombatThug.GetAimStance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DebugCallback;
    /// <summary>
    /// Function: DebugCallback
    /// </summary>
    public unsafe override bool DebugCallback(BmSDK.FString CmdText)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugCallback, "BmGame.GDPlayerControllerCombatThug.DebugCallback");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CmdText, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetFOVAndSens;
    /// <summary>
    /// Function: GetFOVAndSens
    /// </summary>
    public unsafe virtual void GetFOVAndSens(bool bAiming, out float OutFOV, out float outSens)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFOVAndSens, "BmGame.GDPlayerControllerCombatThug.GetFOVAndSens");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAiming, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutFOV);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutFOV, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out outSens);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(outSens, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutFOV = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        outSens = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_RecalcFOVAndSens;
    /// <summary>
    /// Function: RecalcFOVAndSens
    /// </summary>
    public unsafe virtual void RecalcFOVAndSens(float InterpolationSpeed = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecalcFOVAndSens, "BmGame.GDPlayerControllerCombatThug.RecalcFOVAndSens");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterpolationSpeed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AimUnzoom;
    /// <summary>
    /// Function: AimUnzoom
    /// </summary>
    public unsafe virtual void AimUnzoom(bool TriggerStanceChange = default, float InterpolationSpeed = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AimUnzoom, "BmGame.GDPlayerControllerCombatThug.AimUnzoom");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TriggerStanceChange, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterpolationSpeed, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AimZoom;
    /// <summary>
    /// Function: AimZoom
    /// </summary>
    public unsafe virtual void AimZoom(bool TriggerStanceChange = default, float InterpolationSpeed = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AimZoom, "BmGame.GDPlayerControllerCombatThug.AimZoom");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TriggerStanceChange, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterpolationSpeed, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryToStartStealthThugTakeDown;
    /// <summary>
    /// Function: TryToStartStealthThugTakeDown
    /// </summary>
    public unsafe override bool TryToStartStealthThugTakeDown(BmSDK.BmGame.RPlayerController.FPlayerTakedownInfo Info, BmSDK.BmGame.RPawnCombat Victim, BmSDK.BmGame.RPawnCombat Victim2, bool bCrouchPressed, bool bAmIUnderTunnelGrate, BmSDK.FName StateName = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToStartStealthThugTakeDown, "BmGame.GDPlayerControllerCombatThug.TryToStartStealthThugTakeDown");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Info, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim2, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCrouchPressed, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAmIUnderTunnelGrate, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateName, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_RejectStealthTakeDown;
    /// <summary>
    /// Function: RejectStealthTakeDown
    /// </summary>
    public unsafe override void RejectStealthTakeDown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RejectStealthTakeDown, "BmGame.GDPlayerControllerCombatThug.RejectStealthTakeDown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryStrike;
    /// <summary>
    /// Function: TryStrike
    /// </summary>
    public unsafe override bool TryStrike(float TimeInitiatedByPlayer = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryStrike, "BmGame.GDPlayerControllerCombatThug.TryStrike");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeInitiatedByPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CanExecuteHero;
    /// <summary>
    /// Function: CanExecuteHero
    /// </summary>
    public unsafe virtual bool CanExecuteHero()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanExecuteHero, "BmGame.GDPlayerControllerCombatThug.CanExecuteHero");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ForceExitCover;
    /// <summary>
    /// Function: ForceExitCover
    /// </summary>
    public unsafe virtual void ForceExitCover()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceExitCover, "BmGame.GDPlayerControllerCombatThug.ForceExitCover");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnterAimMode;
    /// <summary>
    /// Function: EnterAimMode
    /// </summary>
    public unsafe virtual void EnterAimMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnterAimMode, "BmGame.GDPlayerControllerCombatThug.EnterAimMode");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetThugCoverType;
    /// <summary>
    /// Function: SetThugCoverType
    /// </summary>
    public unsafe virtual void SetThugCoverType(BmSDK.Engine.CoverLink.ECoverType CoverType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetThugCoverType, "BmGame.GDPlayerControllerCombatThug.SetThugCoverType");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CoverType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateCoverFacing;
    /// <summary>
    /// Function: UpdateCoverFacing
    /// </summary>
    public unsafe virtual void UpdateCoverFacing(BmSDK.BmGame.GDPawnPlayerThugBase.GDThugCoverFacing eDesiredThugCoverFacing, bool forced = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCoverFacing, "BmGame.GDPlayerControllerCombatThug.UpdateCoverFacing");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eDesiredThugCoverFacing, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(forced, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetComboOnHUD;
    /// <summary>
    /// Function: SetComboOnHUD
    /// </summary>
    public unsafe virtual void SetComboOnHUD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetComboOnHUD, "BmGame.GDPlayerControllerCombatThug.SetComboOnHUD");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerRefillAmmo;
    /// <summary>
    /// Function: ServerRefillAmmo
    /// </summary>
    public unsafe virtual void ServerRefillAmmo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerRefillAmmo, "BmGame.GDPlayerControllerCombatThug.ServerRefillAmmo");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerGiveAmmoClip;
    /// <summary>
    /// Function: ServerGiveAmmoClip
    /// </summary>
    public unsafe virtual void ServerGiveAmmoClip(int iAmmoStage = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerGiveAmmoClip, "BmGame.GDPlayerControllerCombatThug.ServerGiveAmmoClip");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iAmmoStage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerPickedUpGrenades;
    /// <summary>
    /// Function: ServerPickedUpGrenades
    /// </summary>
    public unsafe virtual void ServerPickedUpGrenades(int GrenadeCount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerPickedUpGrenades, "BmGame.GDPlayerControllerCombatThug.ServerPickedUpGrenades");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrenadeCount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PickedUpGrenades;
    /// <summary>
    /// Function: PickedUpGrenades
    /// </summary>
    public unsafe virtual void PickedUpGrenades(int GrenadeCount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PickedUpGrenades, "BmGame.GDPlayerControllerCombatThug.PickedUpGrenades");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrenadeCount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GiveAmmoClip;
    /// <summary>
    /// Function: GiveAmmoClip
    /// </summary>
    public unsafe virtual void GiveAmmoClip(int iAmmoStage = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveAmmoClip, "BmGame.GDPlayerControllerCombatThug.GiveAmmoClip");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iAmmoStage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RefillAllAmmo;
    /// <summary>
    /// Function: RefillAllAmmo
    /// </summary>
    public unsafe virtual void RefillAllAmmo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RefillAllAmmo, "BmGame.GDPlayerControllerCombatThug.RefillAllAmmo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestGiveClip;
    /// <summary>
    /// Function: TestGiveClip
    /// </summary>
    public unsafe virtual void TestGiveClip()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestGiveClip, "BmGame.GDPlayerControllerCombatThug.TestGiveClip");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickSmokePostProcess;
    /// <summary>
    /// Function: TickSmokePostProcess
    /// </summary>
    public unsafe virtual void TickSmokePostProcess(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickSmokePostProcess, "BmGame.GDPlayerControllerCombatThug.TickSmokePostProcess");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopSmokePostProcess;
    /// <summary>
    /// Function: StopSmokePostProcess
    /// </summary>
    public unsafe virtual void StopSmokePostProcess()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopSmokePostProcess, "BmGame.GDPlayerControllerCombatThug.StopSmokePostProcess");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartSmokePostProcess;
    /// <summary>
    /// Function: StartSmokePostProcess
    /// </summary>
    public unsafe virtual void StartSmokePostProcess()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSmokePostProcess, "BmGame.GDPlayerControllerCombatThug.StartSmokePostProcess");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InSmoke;
    /// <summary>
    /// Function: InSmoke
    /// </summary>
    public unsafe virtual bool InSmoke()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InSmoke, "BmGame.GDPlayerControllerCombatThug.InSmoke");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CombatTick;
    /// <summary>
    /// Function: CombatTick
    /// </summary>
    public unsafe override void CombatTick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatTick, "BmGame.GDPlayerControllerCombatThug.CombatTick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NeedsAmmoCrateIndicators;
    /// <summary>
    /// Function: NeedsAmmoCrateIndicators
    /// </summary>
    public unsafe virtual bool NeedsAmmoCrateIndicators()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NeedsAmmoCrateIndicators, "BmGame.GDPlayerControllerCombatThug.NeedsAmmoCrateIndicators");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.GDPlayerControllerCombatThug.Tick");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanAutoReload;
    /// <summary>
    /// Function: CanAutoReload
    /// </summary>
    public unsafe virtual bool CanAutoReload()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanAutoReload, "BmGame.GDPlayerControllerCombatThug.CanAutoReload");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OverrideThrowGrenade;
    /// <summary>
    /// Function: OverrideThrowGrenade
    /// </summary>
    public unsafe virtual bool OverrideThrowGrenade(out float ThrowAnimLen)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideThrowGrenade, "BmGame.GDPlayerControllerCombatThug.OverrideThrowGrenade");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ThrowAnimLen);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowAnimLen, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThrowAnimLen = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CanThrowGrenade;
    /// <summary>
    /// Function: CanThrowGrenade
    /// </summary>
    public unsafe virtual bool CanThrowGrenade()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanThrowGrenade, "BmGame.GDPlayerControllerCombatThug.CanThrowGrenade");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_WaitToFire;
    /// <summary>
    /// Function: WaitToFire
    /// </summary>
    public unsafe virtual bool WaitToFire()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WaitToFire, "BmGame.GDPlayerControllerCombatThug.WaitToFire");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanFire;
    /// <summary>
    /// Function: CanFire
    /// </summary>
    public unsafe virtual bool CanFire()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanFire, "BmGame.GDPlayerControllerCombatThug.CanFire");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InvSetGadget;
    /// <summary>
    /// Function: InvSetGadget
    /// </summary>
    public unsafe virtual bool InvSetGadget(BmSDK.BmGame.RInventoryGadget NewGadget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InvSetGadget, "BmGame.GDPlayerControllerCombatThug.InvSetGadget");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGadget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SwitchToSecondaryWeapon;
    /// <summary>
    /// Function: SwitchToSecondaryWeapon
    /// </summary>
    public unsafe virtual void SwitchToSecondaryWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchToSecondaryWeapon, "BmGame.GDPlayerControllerCombatThug.SwitchToSecondaryWeapon");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PrintNetVarWeapon;
    /// <summary>
    /// Function: PrintNetVarWeapon
    /// </summary>
    public unsafe virtual void PrintNetVarWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrintNetVarWeapon, "BmGame.GDPlayerControllerCombatThug.PrintNetVarWeapon");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindValidCoverSlipTarget;
    /// <summary>
    /// Function: FindValidCoverSlipTarget
    /// </summary>
    public unsafe virtual bool FindValidCoverSlipTarget(bool bUseRightDirection, out BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc, out BmSDK.Engine.CoverLink destLink, out int destSlotIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindValidCoverSlipTarget, "BmGame.GDPlayerControllerCombatThug.FindValidCoverSlipTarget");
        byte* paramsPtr = stackalloc byte[156];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseRightDirection, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out destLink);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(destLink, paramsPtr + 116);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out destSlotIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(destSlotIndex, paramsPtr + 120);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(paramsPtr + 4);
        destLink = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.CoverLink>(paramsPtr + 116);
        destSlotIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 120);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 124);
    }

    private static BmSDK.Function __fn_DoCoverAction;
    /// <summary>
    /// Function: DoCoverAction
    /// </summary>
    public unsafe virtual bool DoCoverAction(BmSDK.BmGame.GDPlayerControllerCombatThug.GDThugCoverImageName eRequestedCoverAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoCoverAction, "BmGame.GDPlayerControllerCombatThug.DoCoverAction");
        byte* paramsPtr = stackalloc byte[204];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eRequestedCoverAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetValidCoverAction;
    /// <summary>
    /// Function: GetValidCoverAction
    /// </summary>
    public unsafe virtual void GetValidCoverAction(out BmSDK.BmGame.GDPlayerControllerCombatThug.GDThugCoverImageName eValidCoverAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetValidCoverAction, "BmGame.GDPlayerControllerCombatThug.GetValidCoverAction");
        byte* paramsPtr = stackalloc byte[148];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out eValidCoverAction);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eValidCoverAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        eValidCoverAction = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDPlayerControllerCombatThug.GDThugCoverImageName>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_DoLean;
    /// <summary>
    /// Function: DoLean
    /// </summary>
    public unsafe virtual void DoLean(bool bLeanRight, bool bAiming, bool bFromPopUp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoLean, "BmGame.GDPlayerControllerCombatThug.DoLean");
        byte* paramsPtr = stackalloc byte[168];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLeanRight, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAiming, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFromPopUp, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DropOffExplosionEffect;
    /// <summary>
    /// Function: DropOffExplosionEffect
    /// </summary>
    public unsafe virtual void DropOffExplosionEffect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DropOffExplosionEffect, "BmGame.GDPlayerControllerCombatThug.DropOffExplosionEffect");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddHUDDamageIndication;
    /// <summary>
    /// Function: AddHUDDamageIndication
    /// </summary>
    public unsafe override void AddHUDDamageIndication(int Damage, BmSDK.Engine.Pawn Damager, BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddHUDDamageIndication, "BmGame.GDPlayerControllerCombatThug.AddHUDDamageIndication");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damager, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddHitToDamagePostProcess;
    /// <summary>
    /// Function: AddHitToDamagePostProcess
    /// </summary>
    public unsafe override void AddHitToDamagePostProcess(BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddHitToDamagePostProcess, "BmGame.GDPlayerControllerCombatThug.AddHitToDamagePostProcess");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearDamagePostProcess;
    /// <summary>
    /// Function: ClearDamagePostProcess
    /// </summary>
    public unsafe override void ClearDamagePostProcess(bool bResetPPEMaterial = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearDamagePostProcess, "BmGame.GDPlayerControllerCombatThug.ClearDamagePostProcess");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bResetPPEMaterial, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishDamagePPEWhenDead;
    /// <summary>
    /// Function: FinishDamagePPEWhenDead
    /// </summary>
    public unsafe virtual void FinishDamagePPEWhenDead()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishDamagePPEWhenDead, "BmGame.GDPlayerControllerCombatThug.FinishDamagePPEWhenDead");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishDeathPPE;
    /// <summary>
    /// Function: FinishDeathPPE
    /// </summary>
    public unsafe virtual void FinishDeathPPE()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishDeathPPE, "BmGame.GDPlayerControllerCombatThug.FinishDeathPPE");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdatePostProcessEffects;
    /// <summary>
    /// Function: UpdatePostProcessEffects
    /// </summary>
    public unsafe override void UpdatePostProcessEffects(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePostProcessEffects, "BmGame.GDPlayerControllerCombatThug.UpdatePostProcessEffects");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawPostProcessDebug;
    /// <summary>
    /// Function: DrawPostProcessDebug
    /// </summary>
    public unsafe virtual int DrawPostProcessDebug(BmSDK.SDEngine.SDWorldInfo SDWI, int X, int Y)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawPostProcessDebug, "BmGame.GDPlayerControllerCombatThug.DrawPostProcessDebug");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SDWI, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ShouldAutoAdjustCamera;
    /// <summary>
    /// Function: ShouldAutoAdjustCamera
    /// </summary>
    public unsafe override bool ShouldAutoAdjustCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldAutoAdjustCamera, "BmGame.GDPlayerControllerCombatThug.ShouldAutoAdjustCamera");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AddRecoilKick;
    /// <summary>
    /// Function: AddRecoilKick
    /// </summary>
    public unsafe virtual void AddRecoilKick(float RecoilOffset, float RecoilRate, float RecoilRecovery)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddRecoilKick, "BmGame.GDPlayerControllerCombatThug.AddRecoilKick");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RecoilOffset, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RecoilRate, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RecoilRecovery, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetRecoilOffset;
    /// <summary>
    /// Function: ResetRecoilOffset
    /// </summary>
    public unsafe virtual void ResetRecoilOffset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetRecoilOffset, "BmGame.GDPlayerControllerCombatThug.ResetRecoilOffset");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRecoilMultiplier;
    /// <summary>
    /// Function: SetRecoilMultiplier
    /// </summary>
    public unsafe virtual void SetRecoilMultiplier(BmSDK.BmGame.GDPlayerControllerCombatThug.eRecoilMultipliers RMult, float NewScale)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRecoilMultiplier, "BmGame.GDPlayerControllerCombatThug.SetRecoilMultiplier");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RMult, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewScale, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAimFraction;
    /// <summary>
    /// Function: GetAimFraction
    /// </summary>
    public unsafe virtual float GetAimFraction()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAimFraction, "BmGame.GDPlayerControllerCombatThug.GetAimFraction");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAimExitStance;
    /// <summary>
    /// Function: GetAimExitStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetAimExitStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAimExitStance, "BmGame.GDPlayerControllerCombatThug.GetAimExitStance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClampTurn;
    /// <summary>
    /// Function: ClampTurn
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 ClampTurn(System.Numerics.Vector3 vOld, System.Numerics.Vector3 vNew, float fClampAngle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClampTurn, "BmGame.GDPlayerControllerCombatThug.ClampTurn");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vOld, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vNew, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fClampAngle, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_DoThugEvade;
    /// <summary>
    /// Function: DoThugEvade
    /// </summary>
    public unsafe virtual bool DoThugEvade()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoThugEvade, "BmGame.GDPlayerControllerCombatThug.DoThugEvade");
        byte* paramsPtr = stackalloc byte[172];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_WantsToTarget;
    /// <summary>
    /// Function: WantsToTarget
    /// </summary>
    public unsafe virtual bool WantsToTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WantsToTarget, "BmGame.GDPlayerControllerCombatThug.WantsToTarget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetStunnedAudioState;
    /// <summary>
    /// Function: SetStunnedAudioState
    /// </summary>
    public unsafe virtual void SetStunnedAudioState(bool bOn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetStunnedAudioState, "BmGame.GDPlayerControllerCombatThug.SetStunnedAudioState");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsInCoverState;
    /// <summary>
    /// Function: IsInCoverState
    /// </summary>
    public unsafe virtual bool IsInCoverState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInCoverState, "BmGame.GDPlayerControllerCombatThug.IsInCoverState");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_EndSpecialMove;
    /// <summary>
    /// Function: EndSpecialMove
    /// </summary>
    public unsafe virtual void EndSpecialMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndSpecialMove, "BmGame.GDPlayerControllerCombatThug.EndSpecialMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsDoingSpecialMove;
    /// <summary>
    /// Function: IsDoingSpecialMove
    /// </summary>
    public unsafe virtual bool IsDoingSpecialMove(BmSDK.BmGame.GDPawnPlayerThugBase.ESpecialMove AMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDoingSpecialMove, "BmGame.GDPlayerControllerCombatThug.IsDoingSpecialMove");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsDoingASpecialMove;
    /// <summary>
    /// Function: IsDoingASpecialMove
    /// </summary>
    public unsafe virtual bool IsDoingASpecialMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDoingASpecialMove, "BmGame.GDPlayerControllerCombatThug.IsDoingASpecialMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetPawnCoverType;
    /// <summary>
    /// Function: SetPawnCoverType
    /// </summary>
    public unsafe virtual void SetPawnCoverType(BmSDK.Engine.CoverLink.ECoverType NewCT)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPawnCoverType, "BmGame.GDPlayerControllerCombatThug.SetPawnCoverType");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCT, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPawnCoverAction;
    /// <summary>
    /// Function: SetPawnCoverAction
    /// </summary>
    public unsafe virtual void SetPawnCoverAction(BmSDK.Engine.CoverLink.ECoverAction NewCA)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPawnCoverAction, "BmGame.GDPlayerControllerCombatThug.SetPawnCoverAction");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCA, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindMovementSlotsAB;
    /// <summary>
    /// Function: FindMovementSlotsAB
    /// </summary>
    public unsafe virtual bool FindMovementSlotsAB(BmSDK.Engine.CoverLink CurrentLink, int nearestSlotIdx, System.Numerics.Vector3 RefPos, System.Numerics.Vector3 Orientation, out int SlotAIdx, out int SlotBIdx, out int SlotCIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindMovementSlotsAB, "BmGame.GDPlayerControllerCombatThug.FindMovementSlotsAB");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentLink, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nearestSlotIdx, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RefPos, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Orientation, paramsPtr + 20);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SlotAIdx);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotAIdx, paramsPtr + 32);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SlotBIdx);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotBIdx, paramsPtr + 36);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SlotCIdx);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotCIdx, paramsPtr + 40);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        SlotAIdx = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 32);
        SlotBIdx = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 36);
        SlotCIdx = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 40);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_FindNearestSlot;
    /// <summary>
    /// Function: FindNearestSlot
    /// </summary>
    public unsafe virtual int FindNearestSlot(BmSDK.Engine.CoverLink CurrentLink, System.Numerics.Vector3 CheckLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindNearestSlot, "BmGame.GDPlayerControllerCombatThug.FindNearestSlot");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentLink, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckLocation, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CanPlayerMoveAlongLineInDirection;
    /// <summary>
    /// Function: CanPlayerMoveAlongLineInDirection
    /// </summary>
    public unsafe virtual bool CanPlayerMoveAlongLineInDirection(System.Numerics.Vector3 CurrentPos, System.Numerics.Vector3 MoveDirection, System.Numerics.Vector3 directionAB, System.Numerics.Vector3 PointA, System.Numerics.Vector3 PointB, bool blockAtA, bool blockAtB)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayerMoveAlongLineInDirection, "BmGame.GDPlayerControllerCombatThug.CanPlayerMoveAlongLineInDirection");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveDirection, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(directionAB, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointA, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointB, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(blockAtA, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(blockAtB, paramsPtr + 64);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 68);
    }

    private static BmSDK.Function __fn_PlayerMoveAlongLine;
    /// <summary>
    /// Function: PlayerMoveAlongLine
    /// </summary>
    public unsafe virtual bool PlayerMoveAlongLine(float DeltaTime, System.Numerics.Vector3 MoveDirection, System.Numerics.Vector3 PointA, System.Numerics.Vector3 normalA, System.Numerics.Vector3 PointB, System.Numerics.Vector3 normalB, bool blockAtA, bool blockAtB)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerMoveAlongLine, "BmGame.GDPlayerControllerCombatThug.PlayerMoveAlongLine");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveDirection, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointA, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(normalA, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointB, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(normalB, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(blockAtA, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(blockAtB, paramsPtr + 68);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 72);
    }

    private static BmSDK.Function __fn_ModifyPlayerMovementAlongLine;
    /// <summary>
    /// Function: ModifyPlayerMovementAlongLine
    /// </summary>
    public unsafe virtual float ModifyPlayerMovementAlongLine(out System.Numerics.Vector3 MoveDirection, float DeltaTime, System.Numerics.Vector3 PointA, System.Numerics.Vector3 PointB)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyPlayerMovementAlongLine, "BmGame.GDPlayerControllerCombatThug.ModifyPlayerMovementAlongLine");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MoveDirection);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveDirection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointA, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointB, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        MoveDirection = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_GetCoverDirection;
    /// <summary>
    /// Function: GetCoverDirection
    /// </summary>
    public unsafe virtual BmSDK.Engine.CoverLink.ECoverDirection GetCoverDirection()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCoverDirection, "BmGame.GDPlayerControllerCombatThug.GetCoverDirection");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.CoverLink.ECoverDirection>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NotifyCoverAdjusted;
    /// <summary>
    /// Function: NotifyCoverAdjusted
    /// </summary>
    public unsafe override void NotifyCoverAdjusted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyCoverAdjusted, "BmGame.GDPlayerControllerCombatThug.NotifyCoverAdjusted");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientRequestCoverTransition;
    /// <summary>
    /// Function: ClientRequestCoverTransition
    /// </summary>
    public unsafe virtual void ClientRequestCoverTransition()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientRequestCoverTransition, "BmGame.GDPlayerControllerCombatThug.ClientRequestCoverTransition");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientUpdatePosition;
    /// <summary>
    /// Function: ClientUpdatePosition
    /// </summary>
    public unsafe override void ClientUpdatePosition()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientUpdatePosition, "BmGame.GDPlayerControllerCombatThug.ClientUpdatePosition");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpCoverInfo;
    /// <summary>
    /// Function: DumpCoverInfo
    /// </summary>
    public unsafe virtual void DumpCoverInfo(BmSDK.Engine.CoverLink.FCovPosInfo CovInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpCoverInfo, "BmGame.GDPlayerControllerCombatThug.DumpCoverInfo");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CovInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CoverLog;
    /// <summary>
    /// Function: CoverLog
    /// </summary>
    public unsafe virtual void CoverLog(BmSDK.FString msg, BmSDK.FString Function)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CoverLog, "BmGame.GDPlayerControllerCombatThug.CoverLog");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(msg, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Function, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessViewRotation;
    /// <summary>
    /// Function: ProcessViewRotation
    /// </summary>
    public unsafe override void ProcessViewRotation(float DeltaTime, out BmSDK.Rotator out_ViewRotation, BmSDK.Rotator DeltaRot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessViewRotation, "BmGame.GDPlayerControllerCombatThug.ProcessViewRotation");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_ViewRotation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_ViewRotation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaRot, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_ViewRotation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_CleanupPawn;
    /// <summary>
    /// Function: CleanupPawn
    /// </summary>
    public unsafe override void CleanupPawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CleanupPawn, "BmGame.GDPlayerControllerCombatThug.CleanupPawn");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PawnDied;
    /// <summary>
    /// Function: PawnDied
    /// </summary>
    public unsafe override void PawnDied(BmSDK.Engine.Pawn inPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnDied, "BmGame.GDPlayerControllerCombatThug.PawnDied");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPawnReceived;
    /// <summary>
    /// Function: OnPawnReceived
    /// </summary>
    public unsafe virtual void OnPawnReceived(BmSDK.Engine.Pawn NewPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPawnReceived, "BmGame.GDPlayerControllerCombatThug.OnPawnReceived");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReplicatedEvent;
    /// <summary>
    /// Function: ReplicatedEvent
    /// </summary>
    public unsafe override void ReplicatedEvent(BmSDK.FName VarName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplicatedEvent, "BmGame.GDPlayerControllerCombatThug.ReplicatedEvent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.GDPlayerControllerCombatThug.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreBeginPlay;
    /// <summary>
    /// Function: PreBeginPlay
    /// </summary>
    public unsafe override void PreBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreBeginPlay, "BmGame.GDPlayerControllerCombatThug.PreBeginPlay");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PrepareForControllerSwapClient;
    /// <summary>
    /// Function: PrepareForControllerSwapClient
    /// </summary>
    public unsafe override void PrepareForControllerSwapClient()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrepareForControllerSwapClient, "BmGame.GDPlayerControllerCombatThug.PrepareForControllerSwapClient");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PrepareForControllerSwapServer;
    /// <summary>
    /// Function: PrepareForControllerSwapServer
    /// </summary>
    public unsafe override void PrepareForControllerSwapServer(BmSDK.BmGame.RPlayerController SwappingToController)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrepareForControllerSwapServer, "BmGame.GDPlayerControllerCombatThug.PrepareForControllerSwapServer");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SwappingToController, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Possess;
    /// <summary>
    /// Function: Possess
    /// </summary>
    public unsafe override void Possess(BmSDK.Engine.Pawn aPawn, bool bVehicleTransition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Possess, "BmGame.GDPlayerControllerCombatThug.Possess");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVehicleTransition, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ConfigBelongsToCoverSpecialMove;
    /// <summary>
    /// Function: ConfigBelongsToCoverSpecialMove
    /// </summary>
    public unsafe virtual bool ConfigBelongsToCoverSpecialMove(BmSDK.FName ConfigName, BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove SpecialMoveParam)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConfigBelongsToCoverSpecialMove, "BmGame.GDPlayerControllerCombatThug.ConfigBelongsToCoverSpecialMove");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConfigName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecialMoveParam, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_OnSpecialMoveTransitionFinished;
    /// <summary>
    /// Function: OnSpecialMoveTransitionFinished
    /// </summary>
    public unsafe override void OnSpecialMoveTransitionFinished(BmSDK.FName SpecialMoveConfigName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSpecialMoveTransitionFinished, "BmGame.GDPlayerControllerCombatThug.OnSpecialMoveTransitionFinished");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecialMoveConfigName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsEvadeSpecialMove;
    /// <summary>
    /// Function: IsEvadeSpecialMove
    /// </summary>
    public unsafe virtual bool IsEvadeSpecialMove(BmSDK.FName SpecialMoveConfigName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsEvadeSpecialMove, "BmGame.GDPlayerControllerCombatThug.IsEvadeSpecialMove");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecialMoveConfigName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsExitingCoverSpecialMove;
    /// <summary>
    /// Function: IsExitingCoverSpecialMove
    /// </summary>
    public unsafe virtual bool IsExitingCoverSpecialMove(BmSDK.FName SpecialMoveConfigName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsExitingCoverSpecialMove, "BmGame.GDPlayerControllerCombatThug.IsExitingCoverSpecialMove");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecialMoveConfigName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetCoverDistanceValues;
    /// <summary>
    /// Function: GetCoverDistanceValues
    /// </summary>
    public unsafe virtual void GetCoverDistanceValues(bool bIsSprinting, out float out_fMaxDistance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCoverDistanceValues, "BmGame.GDPlayerControllerCombatThug.GetCoverDistanceValues");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsSprinting, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_fMaxDistance);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_fMaxDistance, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_fMaxDistance = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_CanEnterCover;
    /// <summary>
    /// Function: CanEnterCover
    /// </summary>
    public unsafe virtual bool CanEnterCover()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanEnterCover, "BmGame.GDPlayerControllerCombatThug.CanEnterCover");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanEquipGadget;
    /// <summary>
    /// Function: CanEquipGadget
    /// </summary>
    public unsafe override bool CanEquipGadget(BmSDK.BmGame.RInventoryGadget Gadget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanEquipGadget, "BmGame.GDPlayerControllerCombatThug.CanEquipGadget");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Gadget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ClampControllerLowLimit;
    /// <summary>
    /// Function: ClampControllerLowLimit
    /// </summary>
    public unsafe virtual void ClampControllerLowLimit(float fDeltaTime, float fClampLimit, float fClampSpeed, System.Numerics.Vector3 vCoverDirection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClampControllerLowLimit, "BmGame.GDPlayerControllerCombatThug.ClampControllerLowLimit");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fClampLimit, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fClampSpeed, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vCoverDirection, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InterpolateRotationTo;
    /// <summary>
    /// Function: InterpolateRotationTo
    /// </summary>
    public unsafe virtual void InterpolateRotationTo(float fDeltaTime, bool bTo180Back, bool bClockwise)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InterpolateRotationTo, "BmGame.GDPlayerControllerCombatThug.InterpolateRotationTo");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTo180Back, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bClockwise, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsLookingAtCoverRight;
    /// <summary>
    /// Function: IsLookingAtCoverRight
    /// </summary>
    public unsafe virtual bool IsLookingAtCoverRight(System.Numerics.Vector3 vTargetDirection, System.Numerics.Vector3 vCoverForward)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLookingAtCoverRight, "BmGame.GDPlayerControllerCombatThug.IsLookingAtCoverRight");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vTargetDirection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vCoverForward, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_IsCameraLookingTowardCover;
    /// <summary>
    /// Function: IsCameraLookingTowardCover
    /// </summary>
    public unsafe virtual bool IsCameraLookingTowardCover()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCameraLookingTowardCover, "BmGame.GDPlayerControllerCombatThug.IsCameraLookingTowardCover");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ExitCoverState;
    /// <summary>
    /// Function: ExitCoverState
    /// </summary>
    public unsafe virtual void ExitCoverState(bool bSwitchToNoMirrorState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitCoverState, "BmGame.GDPlayerControllerCombatThug.ExitCoverState");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSwitchToNoMirrorState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugCoverForceRotationToForceBlendDirection;
    /// <summary>
    /// Function: ThugCoverForceRotationToForceBlendDirection
    /// </summary>
    public unsafe virtual void ThugCoverForceRotationToForceBlendDirection(BmSDK.Rotator CoverRotationToUse, System.Numerics.Vector3 vCameraDirection, bool bWas180BackFacing, bool bIs180BackFacing)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugCoverForceRotationToForceBlendDirection, "BmGame.GDPlayerControllerCombatThug.ThugCoverForceRotationToForceBlendDirection");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CoverRotationToUse, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vCameraDirection, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWas180BackFacing, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIs180BackFacing, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugCoverComputeThugDirection;
    /// <summary>
    /// Function: ThugCoverComputeThugDirection
    /// </summary>
    public unsafe virtual bool ThugCoverComputeThugDirection(System.Numerics.Vector3 vCoverDirection, System.Numerics.Vector3 vCameraDirection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugCoverComputeThugDirection, "BmGame.GDPlayerControllerCombatThug.ThugCoverComputeThugDirection");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vCoverDirection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vCameraDirection, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_ThugCoverMoveBetweenNodes;
    /// <summary>
    /// Function: ThugCoverMoveBetweenNodes
    /// </summary>
    public unsafe virtual bool ThugCoverMoveBetweenNodes(float DeltaTime, System.Numerics.Vector3 faceDirection, System.Numerics.Vector3 MoveDirection, float strafeValue, BmSDK.BmGame.GDPlayerControllerCombatThug.FThugCoverMovementNodeData coverNodeData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugCoverMoveBetweenNodes, "BmGame.GDPlayerControllerCombatThug.ThugCoverMoveBetweenNodes");
        byte* paramsPtr = stackalloc byte[172];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(faceDirection, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveDirection, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(strafeValue, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(coverNodeData, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 136);
    }

    private static BmSDK.Function __fn_IsCoverPositionValidToUseEdgeCamera;
    /// <summary>
    /// Function: IsCoverPositionValidToUseEdgeCamera
    /// </summary>
    public unsafe virtual bool IsCoverPositionValidToUseEdgeCamera(BmSDK.BmGame.GDPawnPlayerThugBase.GDThugCoverFacing eCurrentCoverFacing, System.Numerics.Vector3 PawnPosition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCoverPositionValidToUseEdgeCamera, "BmGame.GDPlayerControllerCombatThug.IsCoverPositionValidToUseEdgeCamera");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eCurrentCoverFacing, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnPosition, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ExitCover;
    /// <summary>
    /// Function: ExitCover
    /// </summary>
    public unsafe virtual void ExitCover()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitCover, "BmGame.GDPlayerControllerCombatThug.ExitCover");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ComputeCoverNodeMoveData;
    /// <summary>
    /// Function: ComputeCoverNodeMoveData
    /// </summary>
    public unsafe virtual void ComputeCoverNodeMoveData(System.Numerics.Vector3 RefPos, int SlotAIdx, int SlotBIdx, int SlotCIdx, out BmSDK.BmGame.GDPlayerControllerCombatThug.FThugCoverMovementNodeData out_coverNodeData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ComputeCoverNodeMoveData, "BmGame.GDPlayerControllerCombatThug.ComputeCoverNodeMoveData");
        byte* paramsPtr = stackalloc byte[144];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RefPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotAIdx, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotBIdx, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotCIdx, paramsPtr + 20);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_coverNodeData);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_coverNodeData, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_coverNodeData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDPlayerControllerCombatThug.FThugCoverMovementNodeData>(paramsPtr + 24);
        return;
    }

    private static BmSDK.Function __fn_ComputeFaceDirection;
    /// <summary>
    /// Function: ComputeFaceDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 ComputeFaceDirection(System.Numerics.Vector3 CurrentPos, System.Numerics.Vector3 PointA, System.Numerics.Vector3 PointB, System.Numerics.Vector3 pointC, System.Numerics.Vector3 normalA, System.Numerics.Vector3 normalB, System.Numerics.Vector3 normalC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ComputeFaceDirection, "BmGame.GDPlayerControllerCombatThug.ComputeFaceDirection");
        byte* paramsPtr = stackalloc byte[152];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointA, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointB, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pointC, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(normalA, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(normalB, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(normalC, paramsPtr + 72);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 84);
    }

    private static BmSDK.Function __fn_GetCoverInputDirectionFromStick;
    /// <summary>
    /// Function: GetCoverInputDirectionFromStick
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDPlayerControllerCombatThug.GDThugCoverInputDirection GetCoverInputDirectionFromStick(float StickAngRad, float StickLen)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCoverInputDirectionFromStick, "BmGame.GDPlayerControllerCombatThug.GetCoverInputDirectionFromStick");
        byte* paramsPtr = stackalloc byte[26];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StickAngRad, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StickLen, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDPlayerControllerCombatThug.GDThugCoverInputDirection>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetStickData;
    /// <summary>
    /// Function: GetStickData
    /// </summary>
    public unsafe virtual void GetStickData(System.Numerics.Vector3 RefDir, out System.Numerics.Vector3 out_InputDirection, out float out_StickAng, out float out_StickLen)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStickData, "BmGame.GDPlayerControllerCombatThug.GetStickData");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RefDir, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_InputDirection);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_InputDirection, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_StickAng);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_StickAng, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_StickLen);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_StickLen, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_InputDirection = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        out_StickAng = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 24);
        out_StickLen = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 28);
        return;
    }

    private static BmSDK.Function __fn_IsCoverState;
    /// <summary>
    /// Function: IsCoverState
    /// </summary>
    public unsafe virtual bool IsCoverState(BmSDK.FName NextStateName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCoverState, "BmGame.GDPlayerControllerCombatThug.IsCoverState");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextStateName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsCoverSpecialMoveToCover;
    /// <summary>
    /// Function: IsCoverSpecialMoveToCover
    /// </summary>
    public unsafe virtual bool IsCoverSpecialMoveToCover()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCoverSpecialMoveToCover, "BmGame.GDPlayerControllerCombatThug.IsCoverSpecialMoveToCover");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TriggerCoverSpecialMove;
    /// <summary>
    /// Function: TriggerCoverSpecialMove
    /// </summary>
    public unsafe virtual void TriggerCoverSpecialMove(BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove ThugCoverSpecialMove, BmSDK.Engine.CoverLink.ECoverType thugCoverType, BmSDK.BmGame.RPawnPlayer TargetPawn, BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc, bool ForceReplicateToClient = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCoverSpecialMove, "BmGame.GDPlayerControllerCombatThug.TriggerCoverSpecialMove");
        byte* paramsPtr = stackalloc byte[152];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugCoverSpecialMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(thugCoverType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceReplicateToClient, paramsPtr + 128);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetThugCoverTypeIndex;
    /// <summary>
    /// Function: GetThugCoverTypeIndex
    /// </summary>
    public unsafe virtual int GetThugCoverTypeIndex(BmSDK.Engine.CoverLink.ECoverType thugCoverType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThugCoverTypeIndex, "BmGame.GDPlayerControllerCombatThug.GetThugCoverTypeIndex");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(thugCoverType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetMirrorState;
    /// <summary>
    /// Function: SetMirrorState
    /// </summary>
    public unsafe virtual void SetMirrorState(bool newMirrorState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMirrorState, "BmGame.GDPlayerControllerCombatThug.SetMirrorState");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(newMirrorState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChangeCoverState;
    /// <summary>
    /// Function: ChangeCoverState
    /// </summary>
    public unsafe virtual void ChangeCoverState(BmSDK.BmGame.GDPlayerControllerCombatThug.EThugCoverState NewState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeCoverState, "BmGame.GDPlayerControllerCombatThug.ChangeCoverState");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OpenPauseMovie;
    /// <summary>
    /// Function: OpenPauseMovie
    /// </summary>
    public unsafe override void OpenPauseMovie(BmSDK.FString Screen = default, bool bForcePause = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenPauseMovie, "BmGame.GDPlayerControllerCombatThug.OpenPauseMovie");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Screen, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForcePause, paramsPtr + 12);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_UpdateOpacityScaling;
    /// <summary>
    /// Function: UpdateOpacityScaling
    /// </summary>
    public unsafe override void UpdateOpacityScaling()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateOpacityScaling, "BmGame.GDPlayerControllerCombatThug.UpdateOpacityScaling");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ScrambleForensicsDevice;
    /// <summary>
    /// Function: ScrambleForensicsDevice
    /// </summary>
    public unsafe virtual void ScrambleForensicsDevice()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScrambleForensicsDevice, "BmGame.GDPlayerControllerCombatThug.ScrambleForensicsDevice");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Zapped;
    /// <summary>
    /// Function: Zapped
    /// </summary>
    public unsafe override void Zapped(float NewZappedTime = default, float VisonModeDeactivateTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Zapped, "BmGame.GDPlayerControllerCombatThug.Zapped");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewZappedTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VisonModeDeactivateTime, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FadeInForSpawn;
    /// <summary>
    /// Function: FadeInForSpawn
    /// </summary>
    public unsafe override void FadeInForSpawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FadeInForSpawn, "BmGame.GDPlayerControllerCombatThug.FadeInForSpawn");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InstantTurnOffInvestigate;
    /// <summary>
    /// Function: InstantTurnOffInvestigate
    /// </summary>
    public unsafe override void InstantTurnOffInvestigate(float VisonModeDeactivateTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InstantTurnOffInvestigate, "BmGame.GDPlayerControllerCombatThug.InstantTurnOffInvestigate");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VisonModeDeactivateTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceOffInvestigate;
    /// <summary>
    /// Function: ForceOffInvestigate
    /// </summary>
    public unsafe override void ForceOffInvestigate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceOffInvestigate, "BmGame.GDPlayerControllerCombatThug.ForceOffInvestigate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyOptions;
    /// <summary>
    /// Function: ApplyOptions
    /// </summary>
    public unsafe override void ApplyOptions()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyOptions, "BmGame.GDPlayerControllerCombatThug.ApplyOptions");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetInputDirectionOnButtonRelease;
    /// <summary>
    /// Function: GetInputDirectionOnButtonRelease
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDPlayerControllerCombatThug.GDThugCoverInputDirection GetInputDirectionOnButtonRelease(in System.Numerics.Vector3 RefDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInputDirectionOnButtonRelease, "BmGame.GDPlayerControllerCombatThug.GetInputDirectionOnButtonRelease");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RefDir, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDPlayerControllerCombatThug.GDThugCoverInputDirection>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ClearDashRecoverTimer;
    /// <summary>
    /// Function: ClearDashRecoverTimer
    /// </summary>
    public unsafe virtual void ClearDashRecoverTimer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearDashRecoverTimer, "BmGame.GDPlayerControllerCombatThug.ClearDashRecoverTimer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldEnterThugCover;
    /// <summary>
    /// Function: ShouldEnterThugCover
    /// </summary>
    public unsafe override bool ShouldEnterThugCover()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldEnterThugCover, "BmGame.GDPlayerControllerCombatThug.ShouldEnterThugCover");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_EnableRunCam;
    /// <summary>
    /// Function: EnableRunCam
    /// </summary>
    public unsafe virtual void EnableRunCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableRunCam, "BmGame.GDPlayerControllerCombatThug.EnableRunCam");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldRun;
    /// <summary>
    /// Function: ShouldRun
    /// </summary>
    public unsafe override bool ShouldRun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldRun, "BmGame.GDPlayerControllerCombatThug.ShouldRun");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DashRecover;
    /// <summary>
    /// Function: DashRecover
    /// </summary>
    public unsafe virtual void DashRecover()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DashRecover, "BmGame.GDPlayerControllerCombatThug.DashRecover");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndDash;
    /// <summary>
    /// Function: EndDash
    /// </summary>
    public unsafe virtual void EndDash()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndDash, "BmGame.GDPlayerControllerCombatThug.EndDash");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerAlignCameraDuringAnim;
    /// <summary>
    /// Function: TriggerAlignCameraDuringAnim
    /// </summary>
    public unsafe virtual void TriggerAlignCameraDuringAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerAlignCameraDuringAnim, "BmGame.GDPlayerControllerCombatThug.TriggerAlignCameraDuringAnim");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugEvadeDoubleTapTimer;
    /// <summary>
    /// Function: ThugEvadeDoubleTapTimer
    /// </summary>
    public unsafe virtual void ThugEvadeDoubleTapTimer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugEvadeDoubleTapTimer, "BmGame.GDPlayerControllerCombatThug.ThugEvadeDoubleTapTimer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnterCoverDelayTimer;
    /// <summary>
    /// Function: EnterCoverDelayTimer
    /// </summary>
    public unsafe virtual void EnterCoverDelayTimer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnterCoverDelayTimer, "BmGame.GDPlayerControllerCombatThug.EnterCoverDelayTimer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleEquippedWeapon;
    /// <summary>
    /// Function: ToggleEquippedWeapon
    /// </summary>
    public unsafe virtual void ToggleEquippedWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleEquippedWeapon, "BmGame.GDPlayerControllerCombatThug.ToggleEquippedWeapon");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndFireWeapon;
    /// <summary>
    /// Function: EndFireWeapon
    /// </summary>
    public unsafe virtual void EndFireWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndFireWeapon, "BmGame.GDPlayerControllerCombatThug.EndFireWeapon");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireWeapon;
    /// <summary>
    /// Function: FireWeapon
    /// </summary>
    public unsafe virtual void FireWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireWeapon, "BmGame.GDPlayerControllerCombatThug.FireWeapon");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReloadWeapon;
    /// <summary>
    /// Function: ReloadWeapon
    /// </summary>
    public unsafe virtual void ReloadWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReloadWeapon, "BmGame.GDPlayerControllerCombatThug.ReloadWeapon");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugInteractionReleased;
    /// <summary>
    /// Function: ThugInteractionReleased
    /// </summary>
    public unsafe virtual void ThugInteractionReleased()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugInteractionReleased, "BmGame.GDPlayerControllerCombatThug.ThugInteractionReleased");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugInteractionPressed;
    /// <summary>
    /// Function: ThugInteractionPressed
    /// </summary>
    public unsafe virtual void ThugInteractionPressed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugInteractionPressed, "BmGame.GDPlayerControllerCombatThug.ThugInteractionPressed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleThugVision;
    /// <summary>
    /// Function: ToggleThugVision
    /// </summary>
    public unsafe virtual void ToggleThugVision()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleThugVision, "BmGame.GDPlayerControllerCombatThug.ToggleThugVision");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOnThugVision;
    /// <summary>
    /// Function: TurnOnThugVision
    /// </summary>
    public unsafe virtual void TurnOnThugVision()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOnThugVision, "BmGame.GDPlayerControllerCombatThug.TurnOnThugVision");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOffThugVision;
    /// <summary>
    /// Function: TurnOffThugVision
    /// </summary>
    public unsafe virtual void TurnOffThugVision()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffThugVision, "BmGame.GDPlayerControllerCombatThug.TurnOffThugVision");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugMelee;
    /// <summary>
    /// Function: ThugMelee
    /// </summary>
    public unsafe virtual void ThugMelee()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugMelee, "BmGame.GDPlayerControllerCombatThug.ThugMelee");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugRightGadget;
    /// <summary>
    /// Function: ThugRightGadget
    /// </summary>
    public unsafe virtual void ThugRightGadget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugRightGadget, "BmGame.GDPlayerControllerCombatThug.ThugRightGadget");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugLeftGadget;
    /// <summary>
    /// Function: ThugLeftGadget
    /// </summary>
    public unsafe virtual void ThugLeftGadget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugLeftGadget, "BmGame.GDPlayerControllerCombatThug.ThugLeftGadget");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugEvadeSameButtonDash;
    /// <summary>
    /// Function: ThugEvadeSameButtonDash
    /// </summary>
    public unsafe virtual void ThugEvadeSameButtonDash()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugEvadeSameButtonDash, "BmGame.GDPlayerControllerCombatThug.ThugEvadeSameButtonDash");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugEvade;
    /// <summary>
    /// Function: ThugEvade
    /// </summary>
    public unsafe virtual void ThugEvade()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugEvade, "BmGame.GDPlayerControllerCombatThug.ThugEvade");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReleaseThugCoverAction;
    /// <summary>
    /// Function: ReleaseThugCoverAction
    /// </summary>
    public unsafe virtual void ReleaseThugCoverAction()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseThugCoverAction, "BmGame.GDPlayerControllerCombatThug.ReleaseThugCoverAction");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugCoverAction;
    /// <summary>
    /// Function: ThugCoverAction
    /// </summary>
    public unsafe virtual void ThugCoverAction()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugCoverAction, "BmGame.GDPlayerControllerCombatThug.ThugCoverAction");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReleaseThugEnterCoverSameButtonEvade;
    /// <summary>
    /// Function: ReleaseThugEnterCoverSameButtonEvade
    /// </summary>
    public unsafe virtual void ReleaseThugEnterCoverSameButtonEvade()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseThugEnterCoverSameButtonEvade, "BmGame.GDPlayerControllerCombatThug.ReleaseThugEnterCoverSameButtonEvade");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugEnterCoverSameButtonEvade;
    /// <summary>
    /// Function: ThugEnterCoverSameButtonEvade
    /// </summary>
    public unsafe virtual void ThugEnterCoverSameButtonEvade()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugEnterCoverSameButtonEvade, "BmGame.GDPlayerControllerCombatThug.ThugEnterCoverSameButtonEvade");
        byte* paramsPtr = stackalloc byte[29];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReleaseThugEnterCover;
    /// <summary>
    /// Function: ReleaseThugEnterCover
    /// </summary>
    public unsafe virtual void ReleaseThugEnterCover()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseThugEnterCover, "BmGame.GDPlayerControllerCombatThug.ReleaseThugEnterCover");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugEnterCover;
    /// <summary>
    /// Function: ThugEnterCover
    /// </summary>
    public unsafe virtual void ThugEnterCover()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugEnterCover, "BmGame.GDPlayerControllerCombatThug.ThugEnterCover");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReleaseThugDash;
    /// <summary>
    /// Function: ReleaseThugDash
    /// </summary>
    public unsafe virtual void ReleaseThugDash()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseThugDash, "BmGame.GDPlayerControllerCombatThug.ReleaseThugDash");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugDash;
    /// <summary>
    /// Function: ThugDash
    /// </summary>
    public unsafe virtual void ThugDash()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugDash, "BmGame.GDPlayerControllerCombatThug.ThugDash");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QuickGadgetRB;
    /// <summary>
    /// Function: QuickGadgetRB
    /// </summary>
    public unsafe virtual void QuickGadgetRB()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QuickGadgetRB, "BmGame.GDPlayerControllerCombatThug.QuickGadgetRB");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QuickGadgetLB;
    /// <summary>
    /// Function: QuickGadgetLB
    /// </summary>
    public unsafe virtual void QuickGadgetLB()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QuickGadgetLB, "BmGame.GDPlayerControllerCombatThug.QuickGadgetLB");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndRun;
    /// <summary>
    /// Function: EndRun
    /// </summary>
    public unsafe override void EndRun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndRun, "BmGame.GDPlayerControllerCombatThug.EndRun");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartRun;
    /// <summary>
    /// Function: StartRun
    /// </summary>
    public unsafe override void StartRun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartRun, "BmGame.GDPlayerControllerCombatThug.StartRun");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoAutoMove;
    /// <summary>
    /// Function: DoAutoMove
    /// </summary>
    public unsafe override void DoAutoMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoAutoMove, "BmGame.GDPlayerControllerCombatThug.DoAutoMove");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QuickStrikeReleased;
    /// <summary>
    /// Function: QuickStrikeReleased
    /// </summary>
    public unsafe override void QuickStrikeReleased()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QuickStrikeReleased, "BmGame.GDPlayerControllerCombatThug.QuickStrikeReleased");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerQuickStrike;
    /// <summary>
    /// Function: TriggerQuickStrike
    /// </summary>
    public unsafe override void TriggerQuickStrike()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerQuickStrike, "BmGame.GDPlayerControllerCombatThug.TriggerQuickStrike");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Evade;
    /// <summary>
    /// Function: Evade
    /// </summary>
    public unsafe virtual void Evade()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Evade, "BmGame.GDPlayerControllerCombatThug.Evade");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AimGadget;
    /// <summary>
    /// Function: AimGadget
    /// </summary>
    public unsafe override void AimGadget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AimGadget, "BmGame.GDPlayerControllerCombatThug.AimGadget");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GadgetReleased;
    /// <summary>
    /// Function: GadgetReleased
    /// </summary>
    public unsafe override void GadgetReleased()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GadgetReleased, "BmGame.GDPlayerControllerCombatThug.GadgetReleased");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndStealthMove;
    /// <summary>
    /// Function: EndStealthMove
    /// </summary>
    public unsafe override void EndStealthMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndStealthMove, "BmGame.GDPlayerControllerCombatThug.EndStealthMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StealthOrGadgetPressed;
    /// <summary>
    /// Function: StealthOrGadgetPressed
    /// </summary>
    public unsafe override void StealthOrGadgetPressed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StealthOrGadgetPressed, "BmGame.GDPlayerControllerCombatThug.StealthOrGadgetPressed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Grab;
    /// <summary>
    /// Function: Grab
    /// </summary>
    public unsafe virtual void Grab()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Grab, "BmGame.GDPlayerControllerCombatThug.Grab");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnReadyGadget;
    /// <summary>
    /// Function: UnReadyGadget
    /// </summary>
    public unsafe override void UnReadyGadget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnReadyGadget, "BmGame.GDPlayerControllerCombatThug.UnReadyGadget");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReadyGadget;
    /// <summary>
    /// Function: ReadyGadget
    /// </summary>
    public unsafe override void ReadyGadget(bool CantQuickThrow = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadyGadget, "BmGame.GDPlayerControllerCombatThug.ReadyGadget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CantQuickThrow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoubleTapRun;
    /// <summary>
    /// Function: DoubleTapRun
    /// </summary>
    public unsafe override void DoubleTapRun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoubleTapRun, "BmGame.GDPlayerControllerCombatThug.DoubleTapRun");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugClientAuthoritiveServerMove;
    /// <summary>
    /// Function: ThugClientAuthoritiveServerMove
    /// </summary>
    public unsafe virtual void ThugClientAuthoritiveServerMove(float MoveTimeStamp, float ClientLocX, float ClientLocY, float ClientLocZ, System.Numerics.Vector3 ClientNetworkMoveVector, System.Numerics.Vector3 ClientVectorDataForReplication, System.Numerics.Vector3 AimDirection, BmSDK.Engine.Actor.EPhysics ClientPhysics, BmSDK.FName ClientControllerStateName, int View, System.Numerics.Vector3 ViewLoc, byte MoveFlags, BmSDK.BmGame.RPoseConfig.EMovementSpeed MoveSpeed, byte ClientFPS, bool bAiming, BmSDK.BmGame.GDPawnPlayerThugBase.GDThugCoverFacing eDesiredCoverFacing, BmSDK.Engine.CoverLink.ECoverType eDesiredCoverType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugClientAuthoritiveServerMove, "BmGame.GDPlayerControllerCombatThug.ThugClientAuthoritiveServerMove");
        byte* paramsPtr = stackalloc byte[106];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveTimeStamp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocY, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocZ, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientNetworkMoveVector, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientVectorDataForReplication, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimDirection, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientPhysics, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientControllerStateName, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(View, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLoc, paramsPtr + 68);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveFlags, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveSpeed, paramsPtr + 81);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientFPS, paramsPtr + 82);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAiming, paramsPtr + 84);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eDesiredCoverFacing, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eDesiredCoverType, paramsPtr + 89);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugClientAuthoritiveServerMove_FFFFFFFTFTFFFFFF;
    /// <summary>
    /// Function: ThugClientAuthoritiveServerMove_FFFFFFFTFTFFFFFF
    /// </summary>
    public unsafe virtual void ThugClientAuthoritiveServerMove_FFFFFFFTFTFFFFFF(float MoveTimeStamp, BmSDK.FName ClientControllerStateName, System.Numerics.Vector3 ViewLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugClientAuthoritiveServerMove_FFFFFFFTFTFFFFFF, "BmGame.GDPlayerControllerCombatThug.ThugClientAuthoritiveServerMove_FFFFFFFTFTFFFFFF");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveTimeStamp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientControllerStateName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLoc, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugClientAuthoritiveServerMove_TTFTTTFFTTFFFTFF;
    /// <summary>
    /// Function: ThugClientAuthoritiveServerMove_TTFTTTFFTTFFFTFF
    /// </summary>
    public unsafe virtual void ThugClientAuthoritiveServerMove_TTFTTTFFTTFFFTFF(float MoveTimeStamp, float ClientLocX, float ClientLocY, System.Numerics.Vector3 ClientNetworkMoveVector, System.Numerics.Vector3 ClientVectorDataForReplication, System.Numerics.Vector3 AimDirection, int View, System.Numerics.Vector3 ViewLoc, bool bAiming)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugClientAuthoritiveServerMove_TTFTTTFFTTFFFTFF, "BmGame.GDPlayerControllerCombatThug.ThugClientAuthoritiveServerMove_TTFTTTFFTTFFFTFF");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveTimeStamp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocY, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientNetworkMoveVector, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientVectorDataForReplication, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimDirection, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(View, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLoc, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAiming, paramsPtr + 64);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugClientAuthoritiveServerMove_FTFFTTFFTTFFFFFF;
    /// <summary>
    /// Function: ThugClientAuthoritiveServerMove_FTFFTTFFTTFFFFFF
    /// </summary>
    public unsafe virtual void ThugClientAuthoritiveServerMove_FTFFTTFFTTFFFFFF(float MoveTimeStamp, float ClientLocY, System.Numerics.Vector3 ClientVectorDataForReplication, System.Numerics.Vector3 AimDirection, int View, System.Numerics.Vector3 ViewLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugClientAuthoritiveServerMove_FTFFTTFFTTFFFFFF, "BmGame.GDPlayerControllerCombatThug.ThugClientAuthoritiveServerMove_FTFFTTFFTTFFFFFF");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveTimeStamp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientVectorDataForReplication, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimDirection, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(View, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLoc, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugClientAuthoritiveServerMove_TTFTFTFFTTFFFFFF;
    /// <summary>
    /// Function: ThugClientAuthoritiveServerMove_TTFTFTFFTTFFFFFF
    /// </summary>
    public unsafe virtual void ThugClientAuthoritiveServerMove_TTFTFTFFTTFFFFFF(float MoveTimeStamp, float ClientLocX, float ClientLocY, System.Numerics.Vector3 ClientNetworkMoveVector, System.Numerics.Vector3 AimDirection, int View, System.Numerics.Vector3 ViewLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugClientAuthoritiveServerMove_TTFTFTFFTTFFFFFF, "BmGame.GDPlayerControllerCombatThug.ThugClientAuthoritiveServerMove_TTFTFTFFTTFFFFFF");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveTimeStamp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocY, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientNetworkMoveVector, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimDirection, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(View, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLoc, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugClientAuthoritiveServerMove_FTFFFTFFTTFFFFFF;
    /// <summary>
    /// Function: ThugClientAuthoritiveServerMove_FTFFFTFFTTFFFFFF
    /// </summary>
    public unsafe virtual void ThugClientAuthoritiveServerMove_FTFFFTFFTTFFFFFF(float MoveTimeStamp, float ClientLocY, System.Numerics.Vector3 AimDirection, int View, System.Numerics.Vector3 ViewLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugClientAuthoritiveServerMove_FTFFFTFFTTFFFFFF, "BmGame.GDPlayerControllerCombatThug.ThugClientAuthoritiveServerMove_FTFFFTFFTTFFFFFF");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveTimeStamp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimDirection, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(View, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLoc, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugClientAuthoritiveServerMove_FTFTFFFFFTFFFFFF;
    /// <summary>
    /// Function: ThugClientAuthoritiveServerMove_FTFTFFFFFTFFFFFF
    /// </summary>
    public unsafe virtual void ThugClientAuthoritiveServerMove_FTFTFFFFFTFFFFFF(float MoveTimeStamp, float ClientLocY, System.Numerics.Vector3 ClientNetworkMoveVector, System.Numerics.Vector3 ViewLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugClientAuthoritiveServerMove_FTFTFFFFFTFFFFFF, "BmGame.GDPlayerControllerCombatThug.ThugClientAuthoritiveServerMove_FTFTFFFFFTFFFFFF");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveTimeStamp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientNetworkMoveVector, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLoc, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugClientAuthoritiveServerMove_FTFTTTFFTTFFFFFF;
    /// <summary>
    /// Function: ThugClientAuthoritiveServerMove_FTFTTTFFTTFFFFFF
    /// </summary>
    public unsafe virtual void ThugClientAuthoritiveServerMove_FTFTTTFFTTFFFFFF(float MoveTimeStamp, float ClientLocY, System.Numerics.Vector3 ClientNetworkMoveVector, System.Numerics.Vector3 ClientVectorDataForReplication, System.Numerics.Vector3 AimDirection, int View, System.Numerics.Vector3 ViewLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugClientAuthoritiveServerMove_FTFTTTFFTTFFFFFF, "BmGame.GDPlayerControllerCombatThug.ThugClientAuthoritiveServerMove_FTFTTTFFTTFFFFFF");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveTimeStamp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientNetworkMoveVector, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientVectorDataForReplication, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimDirection, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(View, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLoc, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugClientAuthoritiveServerMove_TFFFFFFFFTFFFFFF;
    /// <summary>
    /// Function: ThugClientAuthoritiveServerMove_TFFFFFFFFTFFFFFF
    /// </summary>
    public unsafe virtual void ThugClientAuthoritiveServerMove_TFFFFFFFFTFFFFFF(float MoveTimeStamp, float ClientLocX, System.Numerics.Vector3 ViewLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugClientAuthoritiveServerMove_TFFFFFFFFTFFFFFF, "BmGame.GDPlayerControllerCombatThug.ThugClientAuthoritiveServerMove_TFFFFFFFFTFFFFFF");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveTimeStamp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLoc, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugClientAuthoritiveServerMove_FFFFFFFFFTFFFFFF;
    /// <summary>
    /// Function: ThugClientAuthoritiveServerMove_FFFFFFFFFTFFFFFF
    /// </summary>
    public unsafe virtual void ThugClientAuthoritiveServerMove_FFFFFFFFFTFFFFFF(float MoveTimeStamp, System.Numerics.Vector3 ViewLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugClientAuthoritiveServerMove_FFFFFFFFFTFFFFFF, "BmGame.GDPlayerControllerCombatThug.ThugClientAuthoritiveServerMove_FFFFFFFFFTFFFFFF");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveTimeStamp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLoc, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugClientAuthoritiveServerMove_TTFFTTFFTTFFFFFF;
    /// <summary>
    /// Function: ThugClientAuthoritiveServerMove_TTFFTTFFTTFFFFFF
    /// </summary>
    public unsafe virtual void ThugClientAuthoritiveServerMove_TTFFTTFFTTFFFFFF(float MoveTimeStamp, float ClientLocX, float ClientLocY, System.Numerics.Vector3 ClientVectorDataForReplication, System.Numerics.Vector3 AimDirection, int View, System.Numerics.Vector3 ViewLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugClientAuthoritiveServerMove_TTFFTTFFTTFFFFFF, "BmGame.GDPlayerControllerCombatThug.ThugClientAuthoritiveServerMove_TTFFTTFFTTFFFFFF");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveTimeStamp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocY, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientVectorDataForReplication, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimDirection, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(View, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLoc, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugClientAuthoritiveServerMove_FTFFFFFFFTFFFFFF;
    /// <summary>
    /// Function: ThugClientAuthoritiveServerMove_FTFFFFFFFTFFFFFF
    /// </summary>
    public unsafe virtual void ThugClientAuthoritiveServerMove_FTFFFFFFFTFFFFFF(float MoveTimeStamp, float ClientLocY, System.Numerics.Vector3 ViewLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugClientAuthoritiveServerMove_FTFFFFFFFTFFFFFF, "BmGame.GDPlayerControllerCombatThug.ThugClientAuthoritiveServerMove_FTFFFFFFFTFFFFFF");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveTimeStamp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLoc, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugClientAuthoritiveServerMove_TTTTTTFFTTFFFFFF;
    /// <summary>
    /// Function: ThugClientAuthoritiveServerMove_TTTTTTFFTTFFFFFF
    /// </summary>
    public unsafe virtual void ThugClientAuthoritiveServerMove_TTTTTTFFTTFFFFFF(float MoveTimeStamp, float ClientLocX, float ClientLocY, float ClientLocZ, System.Numerics.Vector3 ClientNetworkMoveVector, System.Numerics.Vector3 ClientVectorDataForReplication, System.Numerics.Vector3 AimDirection, int View, System.Numerics.Vector3 ViewLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugClientAuthoritiveServerMove_TTTTTTFFTTFFFFFF, "BmGame.GDPlayerControllerCombatThug.ThugClientAuthoritiveServerMove_TTTTTTFFTTFFFFFF");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveTimeStamp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocY, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocZ, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientNetworkMoveVector, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientVectorDataForReplication, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimDirection, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(View, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLoc, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugClientAuthoritiveServerMove_TTTFTTFFTTFFFFFF;
    /// <summary>
    /// Function: ThugClientAuthoritiveServerMove_TTTFTTFFTTFFFFFF
    /// </summary>
    public unsafe virtual void ThugClientAuthoritiveServerMove_TTTFTTFFTTFFFFFF(float MoveTimeStamp, float ClientLocX, float ClientLocY, float ClientLocZ, System.Numerics.Vector3 ClientVectorDataForReplication, System.Numerics.Vector3 AimDirection, int View, System.Numerics.Vector3 ViewLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugClientAuthoritiveServerMove_TTTFTTFFTTFFFFFF, "BmGame.GDPlayerControllerCombatThug.ThugClientAuthoritiveServerMove_TTTFTTFFTTFFFFFF");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveTimeStamp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocY, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocZ, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientVectorDataForReplication, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimDirection, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(View, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLoc, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugClientAuthoritiveServerMove_TTFTFFFFFTFFFFFF;
    /// <summary>
    /// Function: ThugClientAuthoritiveServerMove_TTFTFFFFFTFFFFFF
    /// </summary>
    public unsafe virtual void ThugClientAuthoritiveServerMove_TTFTFFFFFTFFFFFF(float MoveTimeStamp, float ClientLocX, float ClientLocY, System.Numerics.Vector3 ClientNetworkMoveVector, System.Numerics.Vector3 ViewLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugClientAuthoritiveServerMove_TTFTFFFFFTFFFFFF, "BmGame.GDPlayerControllerCombatThug.ThugClientAuthoritiveServerMove_TTFTFFFFFTFFFFFF");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveTimeStamp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocY, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientNetworkMoveVector, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLoc, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugClientAuthoritiveServerMove_TTFFFTFFTTFFFFFF;
    /// <summary>
    /// Function: ThugClientAuthoritiveServerMove_TTFFFTFFTTFFFFFF
    /// </summary>
    public unsafe virtual void ThugClientAuthoritiveServerMove_TTFFFTFFTTFFFFFF(float MoveTimeStamp, float ClientLocX, float ClientLocY, System.Numerics.Vector3 AimDirection, int View, System.Numerics.Vector3 ViewLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugClientAuthoritiveServerMove_TTFFFTFFTTFFFFFF, "BmGame.GDPlayerControllerCombatThug.ThugClientAuthoritiveServerMove_TTFFFTFFTTFFFFFF");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveTimeStamp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocY, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimDirection, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(View, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLoc, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugClientAuthoritiveServerMove_TTFFTFFFFTFFFFFF;
    /// <summary>
    /// Function: ThugClientAuthoritiveServerMove_TTFFTFFFFTFFFFFF
    /// </summary>
    public unsafe virtual void ThugClientAuthoritiveServerMove_TTFFTFFFFTFFFFFF(float MoveTimeStamp, float ClientLocX, float ClientLocY, System.Numerics.Vector3 ClientVectorDataForReplication, System.Numerics.Vector3 ViewLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugClientAuthoritiveServerMove_TTFFTFFFFTFFFFFF, "BmGame.GDPlayerControllerCombatThug.ThugClientAuthoritiveServerMove_TTFFTFFFFTFFFFFF");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveTimeStamp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocY, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientVectorDataForReplication, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLoc, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugClientAuthoritiveServerMove_FFFFFTFFTTFFFFFF;
    /// <summary>
    /// Function: ThugClientAuthoritiveServerMove_FFFFFTFFTTFFFFFF
    /// </summary>
    public unsafe virtual void ThugClientAuthoritiveServerMove_FFFFFTFFTTFFFFFF(float MoveTimeStamp, System.Numerics.Vector3 AimDirection, int View, System.Numerics.Vector3 ViewLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugClientAuthoritiveServerMove_FFFFFTFFTTFFFFFF, "BmGame.GDPlayerControllerCombatThug.ThugClientAuthoritiveServerMove_FFFFFTFFTTFFFFFF");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveTimeStamp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimDirection, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(View, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLoc, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugClientAuthoritiveServerMove_TTFTTFFFFTFFFFFF;
    /// <summary>
    /// Function: ThugClientAuthoritiveServerMove_TTFTTFFFFTFFFFFF
    /// </summary>
    public unsafe virtual void ThugClientAuthoritiveServerMove_TTFTTFFFFTFFFFFF(float MoveTimeStamp, float ClientLocX, float ClientLocY, System.Numerics.Vector3 ClientNetworkMoveVector, System.Numerics.Vector3 ClientVectorDataForReplication, System.Numerics.Vector3 ViewLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugClientAuthoritiveServerMove_TTFTTFFFFTFFFFFF, "BmGame.GDPlayerControllerCombatThug.ThugClientAuthoritiveServerMove_TTFTTFFFFTFFFFFF");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveTimeStamp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocY, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientNetworkMoveVector, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientVectorDataForReplication, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLoc, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugClientAuthoritiveServerMove_TTFFFFFFFTFFFFFF;
    /// <summary>
    /// Function: ThugClientAuthoritiveServerMove_TTFFFFFFFTFFFFFF
    /// </summary>
    public unsafe virtual void ThugClientAuthoritiveServerMove_TTFFFFFFFTFFFFFF(float MoveTimeStamp, float ClientLocX, float ClientLocY, System.Numerics.Vector3 ViewLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugClientAuthoritiveServerMove_TTFFFFFFFTFFFFFF, "BmGame.GDPlayerControllerCombatThug.ThugClientAuthoritiveServerMove_TTFFFFFFFTFFFFFF");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveTimeStamp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocY, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLoc, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugClientAuthoritiveServerMove_TTFTTTFFTTFFFFFF;
    /// <summary>
    /// Function: ThugClientAuthoritiveServerMove_TTFTTTFFTTFFFFFF
    /// </summary>
    public unsafe virtual void ThugClientAuthoritiveServerMove_TTFTTTFFTTFFFFFF(float MoveTimeStamp, float ClientLocX, float ClientLocY, System.Numerics.Vector3 ClientNetworkMoveVector, System.Numerics.Vector3 ClientVectorDataForReplication, System.Numerics.Vector3 AimDirection, int View, System.Numerics.Vector3 ViewLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugClientAuthoritiveServerMove_TTFTTTFFTTFFFFFF, "BmGame.GDPlayerControllerCombatThug.ThugClientAuthoritiveServerMove_TTFTTTFFTTFFFFFF");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveTimeStamp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocY, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientNetworkMoveVector, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientVectorDataForReplication, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimDirection, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(View, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLoc, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugClientAuthoritiveServerMove_TFFTTTFFTTFFFFFF;
    /// <summary>
    /// Function: ThugClientAuthoritiveServerMove_TFFTTTFFTTFFFFFF
    /// </summary>
    public unsafe virtual void ThugClientAuthoritiveServerMove_TFFTTTFFTTFFFFFF(float MoveTimeStamp, float ClientLocX, System.Numerics.Vector3 ClientNetworkMoveVector, System.Numerics.Vector3 ClientVectorDataForReplication, System.Numerics.Vector3 AimDirection, int View, System.Numerics.Vector3 ViewLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugClientAuthoritiveServerMove_TFFTTTFFTTFFFFFF, "BmGame.GDPlayerControllerCombatThug.ThugClientAuthoritiveServerMove_TFFTTTFFTTFFFFFF");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveTimeStamp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientNetworkMoveVector, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientVectorDataForReplication, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimDirection, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(View, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLoc, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugClientAuthoritiveServerMove_FFFFTFFFFTFFFFFF;
    /// <summary>
    /// Function: ThugClientAuthoritiveServerMove_FFFFTFFFFTFFFFFF
    /// </summary>
    public unsafe virtual void ThugClientAuthoritiveServerMove_FFFFTFFFFTFFFFFF(float MoveTimeStamp, System.Numerics.Vector3 ClientVectorDataForReplication, System.Numerics.Vector3 ViewLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugClientAuthoritiveServerMove_FFFFTFFFFTFFFFFF, "BmGame.GDPlayerControllerCombatThug.ThugClientAuthoritiveServerMove_FFFFTFFFFTFFFFFF");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveTimeStamp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientVectorDataForReplication, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLoc, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugClientAuthoritiveServerMove_TTTTTFFFFTFFFFFF;
    /// <summary>
    /// Function: ThugClientAuthoritiveServerMove_TTTTTFFFFTFFFFFF
    /// </summary>
    public unsafe virtual void ThugClientAuthoritiveServerMove_TTTTTFFFFTFFFFFF(float MoveTimeStamp, float ClientLocX, float ClientLocY, float ClientLocZ, System.Numerics.Vector3 ClientNetworkMoveVector, System.Numerics.Vector3 ClientVectorDataForReplication, System.Numerics.Vector3 ViewLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugClientAuthoritiveServerMove_TTTTTFFFFTFFFFFF, "BmGame.GDPlayerControllerCombatThug.ThugClientAuthoritiveServerMove_TTTTTFFFFTFFFFFF");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveTimeStamp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocY, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocZ, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientNetworkMoveVector, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientVectorDataForReplication, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLoc, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugClientAuthoritiveServerMove_TTTFTFFFFTFFFFFF;
    /// <summary>
    /// Function: ThugClientAuthoritiveServerMove_TTTFTFFFFTFFFFFF
    /// </summary>
    public unsafe virtual void ThugClientAuthoritiveServerMove_TTTFTFFFFTFFFFFF(float MoveTimeStamp, float ClientLocX, float ClientLocY, float ClientLocZ, System.Numerics.Vector3 ClientVectorDataForReplication, System.Numerics.Vector3 ViewLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugClientAuthoritiveServerMove_TTTFTFFFFTFFFFFF, "BmGame.GDPlayerControllerCombatThug.ThugClientAuthoritiveServerMove_TTTFTFFFFTFFFFFF");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveTimeStamp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocY, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocZ, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientVectorDataForReplication, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLoc, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugClientAuthoritiveServerMove_TTTFFFFFFTFFFFFF;
    /// <summary>
    /// Function: ThugClientAuthoritiveServerMove_TTTFFFFFFTFFFFFF
    /// </summary>
    public unsafe virtual void ThugClientAuthoritiveServerMove_TTTFFFFFFTFFFFFF(float MoveTimeStamp, float ClientLocX, float ClientLocY, float ClientLocZ, System.Numerics.Vector3 ViewLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugClientAuthoritiveServerMove_TTTFFFFFFTFFFFFF, "BmGame.GDPlayerControllerCombatThug.ThugClientAuthoritiveServerMove_TTTFFFFFFTFFFFFF");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveTimeStamp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocY, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientLocZ, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLoc, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugClientAuthoritiveServerMove_NoParams;
    /// <summary>
    /// Function: ThugClientAuthoritiveServerMove_NoParams
    /// </summary>
    public unsafe virtual void ThugClientAuthoritiveServerMove_NoParams(float MoveTimeStamp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugClientAuthoritiveServerMove_NoParams, "BmGame.GDPlayerControllerCombatThug.ThugClientAuthoritiveServerMove_NoParams");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveTimeStamp, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CallAuthoritiveServerMove;
    /// <summary>
    /// Function: CallAuthoritiveServerMove
    /// </summary>
    public unsafe override void CallAuthoritiveServerMove(byte MoveFlags, int ClientFPS)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CallAuthoritiveServerMove, "BmGame.GDPlayerControllerCombatThug.CallAuthoritiveServerMove");
        byte* paramsPtr = stackalloc byte[188];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveFlags, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientFPS, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FsServerThugMoveData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 92)]
    public partial record struct FsServerThugMoveData
    {
        /// <summary>
        /// FloatProperty: MoveTimeStamp
        /// </summary>
        public unsafe float MoveTimeStamp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: ClientLocX
        /// </summary>
        public unsafe float ClientLocX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: ClientLocY
        /// </summary>
        public unsafe float ClientLocY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: ClientLocZ
        /// </summary>
        public unsafe float ClientLocZ
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: ClientNetworkMoveVector
        /// </summary>
        public unsafe System.Numerics.Vector3 ClientNetworkMoveVector
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: ClientVectorDataForReplication
        /// </summary>
        public unsafe System.Numerics.Vector3 ClientVectorDataForReplication
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// StructProperty: AimDirection
        /// </summary>
        public unsafe System.Numerics.Vector3 AimDirection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// ByteProperty: ClientPhysics
        /// </summary>
        public unsafe BmSDK.Engine.Actor.EPhysics ClientPhysics
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.EPhysics>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// NameProperty: ClientControllerStateName
        /// </summary>
        public unsafe BmSDK.FName ClientControllerStateName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// IntProperty: View
        /// </summary>
        public unsafe int View
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// StructProperty: ViewLoc
        /// </summary>
        public unsafe System.Numerics.Vector3 ViewLoc
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// ByteProperty: MoveFlags
        /// </summary>
        public unsafe byte MoveFlags
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// ByteProperty: MoveSpeed
        /// </summary>
        public unsafe BmSDK.BmGame.RPoseConfig.EMovementSpeed MoveSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig.EMovementSpeed>(Ptr + 81); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 81); }; }
        }

        /// <summary>
        /// ByteProperty: ClientFPS
        /// </summary>
        public unsafe byte ClientFPS
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 82); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 82); }; }
        }

        /// <summary>
        /// BoolProperty: bAiming
        /// </summary>
        public unsafe bool bAiming
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }; }
        }

        /// <summary>
        /// ByteProperty: eDesiredCoverFacing
        /// </summary>
        public unsafe BmSDK.BmGame.GDPawnPlayerThugBase.GDThugCoverFacing eDesiredCoverFacing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDPawnPlayerThugBase.GDThugCoverFacing>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }

        /// <summary>
        /// ByteProperty: eDesiredCoverType
        /// </summary>
        public unsafe BmSDK.Engine.CoverLink.ECoverType eDesiredCoverType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CoverLink.ECoverType>(Ptr + 89); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 89); }; }
        }
    }

    /// <summary>
    /// Struct: FThugCoverMovementNodeData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public partial record struct FThugCoverMovementNodeData
    {
        /// <summary>
        /// StructProperty: PointA
        /// </summary>
        public unsafe System.Numerics.Vector3 PointA
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: PointB
        /// </summary>
        public unsafe System.Numerics.Vector3 PointB
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: pointC
        /// </summary>
        public unsafe System.Numerics.Vector3 pointC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: normalA
        /// </summary>
        public unsafe System.Numerics.Vector3 normalA
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// StructProperty: normalB
        /// </summary>
        public unsafe System.Numerics.Vector3 normalB
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// StructProperty: normalC
        /// </summary>
        public unsafe System.Numerics.Vector3 normalC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// StructProperty: dirAB
        /// </summary>
        public unsafe System.Numerics.Vector3 dirAB
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// FloatProperty: LeftDist
        /// </summary>
        public unsafe float LeftDist
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// FloatProperty: RightDist
        /// </summary>
        public unsafe float RightDist
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }

        /// <summary>
        /// FloatProperty: distC
        /// </summary>
        public unsafe float distC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }; }
        }

        /// <summary>
        /// BoolProperty: blockA
        /// </summary>
        public unsafe bool blockA
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }; }
        }

        /// <summary>
        /// BoolProperty: blockB
        /// </summary>
        public unsafe bool blockB
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }; }
        }

        /// <summary>
        /// IntProperty: OtherSlotIdx
        /// </summary>
        public unsafe int OtherSlotIdx
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }; }
        }
    }

    /// <summary>
    /// Struct: FSThugCoverSpecialMove
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FSThugCoverSpecialMove
    {
        /// <summary>
        /// ObjectProperty: MoveConfig
        /// </summary>
        public unsafe BmSDK.BmGame.RSpecialMoveConfig MoveConfig_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
        /// <summary>
        /// ObjectProperty: MoveConfig
        /// </summary>
        public unsafe BmSDK.BmGame.RSpecialMoveConfig MoveConfig_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Enum: EThugCoverState
    /// </summary>
    public enum EThugCoverState : byte
    {
        TCS_NotInCover = 0,
        TCS_Entering = 1,
        TCS_Idle = 2,
        TCS_Exiting = 3,
        TCS_Leaning = 4,
        TCS_PopingUp = 5,
        TCS_MovingSlot = 6,
        TCS_MAX = 7,
    }

    /// <summary>
    /// Struct: FSMCacheDatum
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FSMCacheDatum
    {
        /// <summary>
        /// BoolProperty: bCachedValue
        /// </summary>
        public unsafe bool bCachedValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bIsMirrored
        /// </summary>
        public unsafe bool bIsMirrored
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: LastUpdateTime
        /// </summary>
        public unsafe float LastUpdateTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: LastRequestedTime
        /// </summary>
        public unsafe float LastRequestedTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: GDThugCoverAction
    /// </summary>
    public enum GDThugCoverAction : byte
    {
        GDThugCoverAction_PopUp = 0,
        GDThugCoverAction_Lean = 1,
        GDThugCoverAction_Invalid = 2,
        GDThugCoverAction_MAX = 3,
    }

    /// <summary>
    /// Enum: GDThugCoverImageName
    /// </summary>
    public enum GDThugCoverImageName : byte
    {
        TCIN_None = 0,
        TCIN_FullRoll = 1,
        TCIN_FullSlip = 2,
        TCIN_FullSwat = 3,
        TCIN_HalfRoll = 4,
        TCIN_HalfSlip = 5,
        TCIN_HalfSwat = 6,
        TCIN_Mantle = 7,
        TCIN_Vault = 8,
        TCIN_MAX = 9,
    }

    /// <summary>
    /// Enum: GDThugCoverInputDirection
    /// </summary>
    public enum GDThugCoverInputDirection : byte
    {
        TCID_None = 0,
        TCID_Left = 1,
        TCID_Right = 2,
        TCID_Forward = 3,
        TCID_Backward = 4,
        TCID_MAX = 5,
    }

    /// <summary>
    /// Enum: eRecoilMultipliers
    /// </summary>
    public enum eRecoilMultipliers : byte
    {
        RMULT_DualWield = 0,
        RMULT_PleaseReplaceMe = 1,
        RMULT_MAX = 2,
    }

    /// <summary>
    /// ObjectProperty: BarkEventOnAmmoGot
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventOnAmmoGot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 5044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5044); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventOnAmmoGetting
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventOnAmmoGetting
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 5048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5048); }
    }

    /// <summary>
    /// StructProperty: ServerDictatedCover
    /// </summary>
    public unsafe ref BmSDK.Engine.CoverLink.FCoverInfo ServerDictatedCover
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.CoverLink.FCoverInfo>(Ptr + 5052);

    /// <summary>
    /// FloatProperty: DeadZoneThreshold
    /// </summary>
    public unsafe float DeadZoneThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5060); }
    }

    /// <summary>
    /// FloatProperty: AimingFOV
    /// </summary>
    public unsafe float AimingFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5064); }
    }

    /// <summary>
    /// ByteProperty: bAimRequested
    /// </summary>
    public unsafe byte bAimRequested
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 5068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5068); }
    }

    /// <summary>
    /// ByteProperty: eThugCoverFacing
    /// </summary>
    public unsafe BmSDK.BmGame.GDPawnPlayerThugBase.GDThugCoverFacing eThugCoverFacing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDPawnPlayerThugBase.GDThugCoverFacing>(Ptr + 5069); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5069); }
    }

    /// <summary>
    /// ByteProperty: eThugCoverType
    /// </summary>
    public unsafe BmSDK.Engine.CoverLink.ECoverType eThugCoverType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CoverLink.ECoverType>(Ptr + 5070); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5070); }
    }

    /// <summary>
    /// ByteProperty: eThugCoverInputDirection
    /// </summary>
    public unsafe BmSDK.BmGame.GDPlayerControllerCombatThug.GDThugCoverInputDirection eThugCoverInputDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDPlayerControllerCombatThug.GDThugCoverInputDirection>(Ptr + 5071); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5071); }
    }

    /// <summary>
    /// ByteProperty: eThugCoverLastEdgeAction
    /// </summary>
    public unsafe BmSDK.BmGame.GDPlayerControllerCombatThug.GDThugCoverAction eThugCoverLastEdgeAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDPlayerControllerCombatThug.GDThugCoverAction>(Ptr + 5072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5072); }
    }

    /// <summary>
    /// ByteProperty: CoverActionAvailable
    /// </summary>
    public unsafe BmSDK.BmGame.GDPlayerControllerCombatThug.GDThugCoverImageName CoverActionAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDPlayerControllerCombatThug.GDThugCoverImageName>(Ptr + 5073); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5073); }
    }

    /// <summary>
    /// ByteProperty: CurrentCoverState
    /// </summary>
    public unsafe BmSDK.BmGame.GDPlayerControllerCombatThug.EThugCoverState CurrentCoverState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDPlayerControllerCombatThug.EThugCoverState>(Ptr + 5074); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5074); }
    }

    /// <summary>
    /// ByteProperty: PreviousCoverState
    /// </summary>
    public unsafe BmSDK.BmGame.GDPlayerControllerCombatThug.EThugCoverState PreviousCoverState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDPlayerControllerCombatThug.EThugCoverState>(Ptr + 5075); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5075); }
    }

    /// <summary>
    /// BoolProperty: bAimMode
    /// </summary>
    public unsafe bool bAimMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bDebugLaunchers
    /// </summary>
    public unsafe bool bDebugLaunchers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bSmokePPActive
    /// </summary>
    public unsafe bool bSmokePPActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bExplosionEffectDroppingOff
    /// </summary>
    public unsafe bool bExplosionEffectDroppingOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: thugCoverAiming
    /// </summary>
    public unsafe bool thugCoverAiming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bInThugCover
    /// </summary>
    public unsafe bool bInThugCover
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bThugCover180
    /// </summary>
    public unsafe bool bThugCover180
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bThugCoverMirror
    /// </summary>
    public unsafe bool bThugCoverMirror
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bThugCoverMoving
    /// </summary>
    public unsafe bool bThugCoverMoving
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bForceOppositeRotationInCover
    /// </summary>
    public unsafe bool bForceOppositeRotationInCover
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bPreviousGlobalDisallowAutomaticMirroring
    /// </summary>
    public unsafe bool bPreviousGlobalDisallowAutomaticMirroring
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bPreviousIgnoreExternalRotationChanges
    /// </summary>
    public unsafe bool bPreviousIgnoreExternalRotationChanges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bDashOverlayCameraRunning
    /// </summary>
    public unsafe bool bDashOverlayCameraRunning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bThugCoverActionButtonHeld
    /// </summary>
    public unsafe bool bThugCoverActionButtonHeld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bThugDashButtonHeld
    /// </summary>
    public unsafe bool bThugDashButtonHeld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bAllowSprint
    /// </summary>
    public unsafe bool bAllowSprint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bIsRunning
    /// </summary>
    public unsafe bool bIsRunning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bAllowDash
    /// </summary>
    public unsafe bool bAllowDash
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bDashing
    /// </summary>
    public unsafe bool bDashing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bAllowQuick180Turn
    /// </summary>
    public unsafe bool bAllowQuick180Turn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bQuick180TurnMoveStarted
    /// </summary>
    public unsafe bool bQuick180TurnMoveStarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bRun2CoverAnyDirection
    /// </summary>
    public unsafe bool bRun2CoverAnyDirection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bBreakFromCover
    /// </summary>
    public unsafe bool bBreakFromCover
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bPressAToBreakFromCover
    /// </summary>
    public unsafe bool bPressAToBreakFromCover
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bSendCoverTransition
    /// </summary>
    public unsafe bool bSendCoverTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bDebugCover
    /// </summary>
    public unsafe bool bDebugCover
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bPreferLeanOverPopup
    /// </summary>
    public unsafe bool bPreferLeanOverPopup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bServerMoveCoverActive
    /// </summary>
    public unsafe bool bServerMoveCoverActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bAllowDisabledMovementFiring
    /// </summary>
    public unsafe bool bAllowDisabledMovementFiring
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: AdditiveAimIsDisabled
    /// </summary>
    public unsafe bool AdditiveAimIsDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: AimModeIsDisabled
    /// </summary>
    public unsafe bool AimModeIsDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bSupervillainCandidate
    /// </summary>
    public unsafe bool bSupervillainCandidate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5076); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5076); }
    }

    /// <summary>
    /// BoolProperty: bInteractionButtonHeld
    /// </summary>
    public unsafe bool bInteractionButtonHeld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5080) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5080); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5080); }
    }

    /// <summary>
    /// BoolProperty: bGetGrenadesFromThisRummage
    /// </summary>
    public unsafe bool bGetGrenadesFromThisRummage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5080) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5080); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5080); }
    }

    /// <summary>
    /// BoolProperty: bPlaySecondPartAnimationToEnterInCover
    /// </summary>
    public unsafe bool bPlaySecondPartAnimationToEnterInCover
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5080) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5080); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5080); }
    }

    /// <summary>
    /// BoolProperty: bDoAnimatedTransitionToSupervillain
    /// </summary>
    public unsafe bool bDoAnimatedTransitionToSupervillain
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5080) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5080); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5080); }
    }

    /// <summary>
    /// BoolProperty: bWeaponAutoSwitch
    /// </summary>
    public unsafe bool bWeaponAutoSwitch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5080) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5080); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5080); }
    }

    /// <summary>
    /// BoolProperty: bShowControllableGadgetTimer
    /// </summary>
    public unsafe bool bShowControllableGadgetTimer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5080) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5080); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5080); }
    }

    /// <summary>
    /// FloatProperty: TargetRecoilOffset
    /// </summary>
    public unsafe float TargetRecoilOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5084); }
    }

    /// <summary>
    /// FloatProperty: NewRecoilKick
    /// </summary>
    public unsafe float NewRecoilKick
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5088); }
    }

    /// <summary>
    /// FloatProperty: CurrentRecoilOffset
    /// </summary>
    public unsafe float CurrentRecoilOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5092); }
    }

    /// <summary>
    /// FloatProperty: CurrentRecoilRate
    /// </summary>
    public unsafe float CurrentRecoilRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5096); }
    }

    /// <summary>
    /// FloatProperty: CurrentRecoilRecovery
    /// </summary>
    public unsafe float CurrentRecoilRecovery
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5100); }
    }

    /// <summary>
    /// ObjectProperty: LastNonWeaponGadget
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget LastNonWeaponGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5104); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: RecoilMultipliers
    /// </summary>
    public InlineArray<float> RecoilMultipliers => new(2, Ptr + 5108, 4, this);

    /// <summary>
    /// FloatProperty: RecoilMultipliers
    /// </summary>
    public unsafe float RecoilMultipliers_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5108); }
    }
    /// <summary>
    /// FloatProperty: RecoilMultipliers
    /// </summary>
    public unsafe float RecoilMultipliers_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5112); }
    }

    /// <summary>
    /// FloatProperty: TotalRecoilMultiplier
    /// </summary>
    public unsafe float TotalRecoilMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5116); }
    }

    /// <summary>
    /// StrProperty: HorizontalFlipImageString
    /// </summary>
    public unsafe BmSDK.FString HorizontalFlipImageString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 5120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5120); }
    }

    /// <summary>
    /// InlineArray{StrProperty}: CoverImageNameStrings
    /// </summary>
    public InlineArray<BmSDK.FString> CoverImageNameStrings => new(9, Ptr + 5132, 12, this);

    /// <summary>
    /// StrProperty: CoverImageNameStrings
    /// </summary>
    public unsafe BmSDK.FString CoverImageNameStrings_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 5132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5132); }
    }
    /// <summary>
    /// StrProperty: CoverImageNameStrings
    /// </summary>
    public unsafe BmSDK.FString CoverImageNameStrings_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 5144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5144); }
    }
    /// <summary>
    /// StrProperty: CoverImageNameStrings
    /// </summary>
    public unsafe BmSDK.FString CoverImageNameStrings_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 5156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5156); }
    }
    /// <summary>
    /// StrProperty: CoverImageNameStrings
    /// </summary>
    public unsafe BmSDK.FString CoverImageNameStrings_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 5168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5168); }
    }
    /// <summary>
    /// StrProperty: CoverImageNameStrings
    /// </summary>
    public unsafe BmSDK.FString CoverImageNameStrings_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 5180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5180); }
    }
    /// <summary>
    /// StrProperty: CoverImageNameStrings
    /// </summary>
    public unsafe BmSDK.FString CoverImageNameStrings_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 5192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5192); }
    }
    /// <summary>
    /// StrProperty: CoverImageNameStrings
    /// </summary>
    public unsafe BmSDK.FString CoverImageNameStrings_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 5204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5204); }
    }
    /// <summary>
    /// StrProperty: CoverImageNameStrings
    /// </summary>
    public unsafe BmSDK.FString CoverImageNameStrings_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 5216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5216); }
    }
    /// <summary>
    /// StrProperty: CoverImageNameStrings
    /// </summary>
    public unsafe BmSDK.FString CoverImageNameStrings_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 5228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5228); }
    }

    /// <summary>
    /// ObjectProperty: InSmokePostProcess
    /// </summary>
    public unsafe BmSDK.BmGame.RViewPostProcess InSmokePostProcess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RViewPostProcess>(Ptr + 5240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5240); }
    }

    /// <summary>
    /// FloatProperty: InSmokeTime
    /// </summary>
    public unsafe float InSmokeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5244); }
    }

    /// <summary>
    /// FloatProperty: SmokeValue
    /// </summary>
    public unsafe float SmokeValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5248); }
    }

    /// <summary>
    /// FloatProperty: ExplosionEffectPPValue
    /// </summary>
    public unsafe float ExplosionEffectPPValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5252); }
    }

    /// <summary>
    /// FloatProperty: ExplosionEffectDropOff
    /// </summary>
    public unsafe float ExplosionEffectDropOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5256); }
    }

    /// <summary>
    /// FloatProperty: MaxExplosionEffectDamage
    /// </summary>
    public unsafe float MaxExplosionEffectDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5260); }
    }

    /// <summary>
    /// FloatProperty: ExplosionEffectDelay
    /// </summary>
    public unsafe float ExplosionEffectDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5264); }
    }

    /// <summary>
    /// FloatProperty: DashCollisionAngleLimit
    /// </summary>
    public unsafe float DashCollisionAngleLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5268); }
    }

    /// <summary>
    /// FloatProperty: DashCollisionTurnSpeed
    /// </summary>
    public unsafe float DashCollisionTurnSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5272); }
    }

    /// <summary>
    /// ObjectProperty: DashFailAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent DashFailAudioEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5276); }
    }

    /// <summary>
    /// FloatProperty: CachedDashCooldown
    /// </summary>
    public unsafe float CachedDashCooldown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5280); }
    }

    /// <summary>
    /// FloatProperty: CachedDashTimeLeft
    /// </summary>
    public unsafe float CachedDashTimeLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5284); }
    }

    /// <summary>
    /// ObjectProperty: ThugPawn
    /// </summary>
    public unsafe BmSDK.BmGame.GDPawnPlayerThugBase ThugPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDPawnPlayerThugBase>(Ptr + 5288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5288); }
    }

    /// <summary>
    /// FloatProperty: fThugCoverDirectionHeldTimer
    /// </summary>
    public unsafe float fThugCoverDirectionHeldTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5292); }
    }

    /// <summary>
    /// FloatProperty: fThugCoverDirectionHeldTime
    /// </summary>
    public unsafe float fThugCoverDirectionHeldTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5296); }
    }

    /// <summary>
    /// FloatProperty: fMaxCoverSlipDot
    /// </summary>
    public unsafe float fMaxCoverSlipDot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5300); }
    }

    /// <summary>
    /// FloatProperty: fDashStartTime
    /// </summary>
    public unsafe float fDashStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5304); }
    }

    /// <summary>
    /// FloatProperty: fDashAudioFailTime
    /// </summary>
    public unsafe float fDashAudioFailTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5308); }
    }

    /// <summary>
    /// FloatProperty: HideDashRecoverTime
    /// </summary>
    public unsafe float HideDashRecoverTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5312); }
    }

    /// <summary>
    /// FloatProperty: fFrom180BackInCoverInterpolationTime
    /// </summary>
    public unsafe float fFrom180BackInCoverInterpolationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5316); }
    }

    /// <summary>
    /// FloatProperty: BreakFromCoverHoldTime
    /// </summary>
    public unsafe float BreakFromCoverHoldTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5320); }
    }

    /// <summary>
    /// FloatProperty: BreakFromCoverHoldTimer
    /// </summary>
    public unsafe float BreakFromCoverHoldTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5324); }
    }

    /// <summary>
    /// FloatProperty: RemappedJoyRight
    /// </summary>
    public unsafe float RemappedJoyRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5328); }
    }

    /// <summary>
    /// FloatProperty: RemappedJoyUp
    /// </summary>
    public unsafe float RemappedJoyUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5332); }
    }

    /// <summary>
    /// StructProperty: ControlsRemapRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator ControlsRemapRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 5336);

    /// <summary>
    /// FloatProperty: EvadeRetriggerDelay
    /// </summary>
    public unsafe float EvadeRetriggerDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5348); }
    }

    /// <summary>
    /// FloatProperty: CoverTransitionTime
    /// </summary>
    public unsafe float CoverTransitionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5352); }
    }

    /// <summary>
    /// FloatProperty: CoverTransitionCountHold
    /// </summary>
    public unsafe float CoverTransitionCountHold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5356); }
    }

    /// <summary>
    /// FloatProperty: CoverTransitionCountDown
    /// </summary>
    public unsafe float CoverTransitionCountDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5360); }
    }

    /// <summary>
    /// ArrayProperty: EnteredCoverEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.SeqEvt_EnteredCover> EnteredCoverEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.SeqEvt_EnteredCover>>(Ptr + 5364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5364); }
    }

    /// <summary>
    /// ArrayProperty: LeftCoverEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.SeqEvt_LeftCover> LeftCoverEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.SeqEvt_LeftCover>>(Ptr + 5376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5376); }
    }

    /// <summary>
    /// FloatProperty: TimeBeforeAButtonPressLeavesCover
    /// </summary>
    public unsafe float TimeBeforeAButtonPressLeavesCover
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5388); }
    }

    /// <summary>
    /// IntProperty: LastCoverActionSpecialMoveUpdateIdx
    /// </summary>
    public unsafe int LastCoverActionSpecialMoveUpdateIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5392); }
    }

    /// <summary>
    /// ArrayProperty: CachedCanDoCoverActionSpecialMoves
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDPlayerControllerCombatThug.FSMCacheDatum> CachedCanDoCoverActionSpecialMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDPlayerControllerCombatThug.FSMCacheDatum>>(Ptr + 5396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5396); }
    }

    /// <summary>
    /// StructProperty: CoverDiveLeft
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverDiveLeft
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5408);

    /// <summary>
    /// StructProperty: CoverDiveRight
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverDiveRight
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5416);

    /// <summary>
    /// StructProperty: CoverSlideEnterLeftEnd
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverSlideEnterLeftEnd
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5424);

    /// <summary>
    /// StructProperty: CoverSlideEnterRightEnd
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverSlideEnterRightEnd
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5432);

    /// <summary>
    /// StructProperty: CoverExitLeft
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverExitLeft
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5440);

    /// <summary>
    /// StructProperty: CoverExitRight
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverExitRight
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5448);

    /// <summary>
    /// StructProperty: Cover180ExitLeft
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove Cover180ExitLeft
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5456);

    /// <summary>
    /// StructProperty: Cover180ExitRight
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove Cover180ExitRight
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5464);

    /// <summary>
    /// ObjectProperty: Cover180PopUpToFullLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig Cover180PopUpToFullLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5472); }
    }

    /// <summary>
    /// ObjectProperty: Cover180PopUpToFullRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig Cover180PopUpToFullRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5476); }
    }

    /// <summary>
    /// ObjectProperty: CoverHalfToHalf180Left
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverHalfToHalf180Left
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5480); }
    }

    /// <summary>
    /// ObjectProperty: CoverHalfToHalf180Right
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverHalfToHalf180Right
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5484); }
    }

    /// <summary>
    /// ObjectProperty: CoverHalf180ToHalfLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverHalf180ToHalfLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5488); }
    }

    /// <summary>
    /// ObjectProperty: CoverHalf180ToHalfRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverHalf180ToHalfRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5492); }
    }

    /// <summary>
    /// ObjectProperty: CoverHalfToHalf180MirrorLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverHalfToHalf180MirrorLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5496); }
    }

    /// <summary>
    /// ObjectProperty: CoverHalfToHalf180MirrorRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverHalfToHalf180MirrorRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5500); }
    }

    /// <summary>
    /// ObjectProperty: CoverFullToHalf180PopUpLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverFullToHalf180PopUpLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5504); }
    }

    /// <summary>
    /// ObjectProperty: CoverFullToHalf180PopUpRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverFullToHalf180PopUpRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5508); }
    }

    /// <summary>
    /// ObjectProperty: CoverFullToHalf180PopUpAimLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverFullToHalf180PopUpAimLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5512); }
    }

    /// <summary>
    /// ObjectProperty: CoverFullToHalf180PopUpAimRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverFullToHalf180PopUpAimRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5516); }
    }

    /// <summary>
    /// ObjectProperty: CoverFullToHalf180PopUpMirrorLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverFullToHalf180PopUpMirrorLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5520); }
    }

    /// <summary>
    /// ObjectProperty: CoverFullToHalf180PopUpMirrorRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverFullToHalf180PopUpMirrorRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5524); }
    }

    /// <summary>
    /// ObjectProperty: CoverFullToHalf180PopUpAimMirrorLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverFullToHalf180PopUpAimMirrorLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5528); }
    }

    /// <summary>
    /// ObjectProperty: CoverFullToHalf180PopUpAimMirrorRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverFullToHalf180PopUpAimMirrorRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5532); }
    }

    /// <summary>
    /// StructProperty: CoverSlipLeft
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverSlipLeft
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5536);

    /// <summary>
    /// StructProperty: CoverSlipRight
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverSlipRight
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5544);

    /// <summary>
    /// StructProperty: CoverLeanLeft
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverLeanLeft
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5552);

    /// <summary>
    /// StructProperty: CoverLeanHighLeft
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverLeanHighLeft
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5560);

    /// <summary>
    /// StructProperty: CoverLeanRight
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverLeanRight
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5568);

    /// <summary>
    /// StructProperty: CoverLeanHighRight
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverLeanHighRight
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5576);

    /// <summary>
    /// StructProperty: CoverLeanReturnLeft
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverLeanReturnLeft
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5584);

    /// <summary>
    /// StructProperty: CoverLeanReturnRight
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverLeanReturnRight
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5592);

    /// <summary>
    /// StructProperty: CoverLeanReturn180Left
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverLeanReturn180Left
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5600);

    /// <summary>
    /// StructProperty: CoverLeanReturn180Right
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverLeanReturn180Right
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5608);

    /// <summary>
    /// StructProperty: CoverLeanReturn180AimLeft
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverLeanReturn180AimLeft
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5616);

    /// <summary>
    /// StructProperty: CoverLeanReturn180AimRight
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverLeanReturn180AimRight
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5624);

    /// <summary>
    /// StructProperty: CoverLeanToPopUpLeft
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverLeanToPopUpLeft
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5632);

    /// <summary>
    /// StructProperty: CoverLeanToPopUpRight
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverLeanToPopUpRight
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5640);

    /// <summary>
    /// StructProperty: CoverLeanToPopUpAimLeft
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverLeanToPopUpAimLeft
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5648);

    /// <summary>
    /// StructProperty: CoverLeanToPopUpAimRight
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverLeanToPopUpAimRight
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5656);

    /// <summary>
    /// StructProperty: CoverPopUpToLeanLeft
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverPopUpToLeanLeft
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5664);

    /// <summary>
    /// StructProperty: CoverPopUpToLeanRight
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverPopUpToLeanRight
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5672);

    /// <summary>
    /// StructProperty: CoverPopUpAimToLeanLeft
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverPopUpAimToLeanLeft
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5680);

    /// <summary>
    /// StructProperty: CoverPopUpAimToLeanRight
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverPopUpAimToLeanRight
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5688);

    /// <summary>
    /// StructProperty: CoverSwatTurnLeft
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverSwatTurnLeft
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5696);

    /// <summary>
    /// StructProperty: CoverSwatTurnRight
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverSwatTurnRight
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5704);

    /// <summary>
    /// StructProperty: CoverMantleLeft
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverMantleLeft
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5712);

    /// <summary>
    /// StructProperty: CoverMantleRight
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverMantleRight
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5720);

    /// <summary>
    /// StructProperty: CoverVaultLeft
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverVaultLeft
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5728);

    /// <summary>
    /// StructProperty: CoverVaultRight
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverVaultRight
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5736);

    /// <summary>
    /// StructProperty: CoverVaultToFallLeft
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverVaultToFallLeft
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5744);

    /// <summary>
    /// StructProperty: CoverVaultToFallRight
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove CoverVaultToFallRight
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FSThugCoverSpecialMove>(Ptr + 5752);

    /// <summary>
    /// ObjectProperty: CoverFullLeanGrenadeThrowLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverFullLeanGrenadeThrowLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5760); }
    }

    /// <summary>
    /// ObjectProperty: CoverFullLeanGrenadeThrowRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverFullLeanGrenadeThrowRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5764); }
    }

    /// <summary>
    /// ObjectProperty: CoverHalfLeanGrenadeThrowLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverHalfLeanGrenadeThrowLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5768); }
    }

    /// <summary>
    /// ObjectProperty: CoverHalfLeanGrenadeThrowRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverHalfLeanGrenadeThrowRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5772); }
    }

    /// <summary>
    /// ObjectProperty: CoverFullLeanGrenadeThrowLeftSide
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverFullLeanGrenadeThrowLeftSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5776); }
    }

    /// <summary>
    /// ObjectProperty: CoverFullLeanGrenadeThrowRightSide
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverFullLeanGrenadeThrowRightSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5780); }
    }

    /// <summary>
    /// ObjectProperty: CoverHalfLeanGrenadeThrowLeftSide
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverHalfLeanGrenadeThrowLeftSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5784); }
    }

    /// <summary>
    /// ObjectProperty: CoverHalfLeanGrenadeThrowRightSide
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverHalfLeanGrenadeThrowRightSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5788); }
    }

    /// <summary>
    /// ObjectProperty: CoverHalfPopUpGrenadeThrowLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverHalfPopUpGrenadeThrowLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5792); }
    }

    /// <summary>
    /// ObjectProperty: CoverHalfPopUpGrenadeThrowRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverHalfPopUpGrenadeThrowRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5796); }
    }

    /// <summary>
    /// ObjectProperty: CoverHalfPopUpGrenadeThrowLeftSide
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverHalfPopUpGrenadeThrowLeftSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5800); }
    }

    /// <summary>
    /// ObjectProperty: CoverHalfPopUpGrenadeThrowRightSide
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverHalfPopUpGrenadeThrowRightSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5804); }
    }

    /// <summary>
    /// ObjectProperty: CoverFullGrenadeThrowBackwardsLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverFullGrenadeThrowBackwardsLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5808); }
    }

    /// <summary>
    /// ObjectProperty: CoverFullGrenadeThrowBackwardsRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverFullGrenadeThrowBackwardsRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5812); }
    }

    /// <summary>
    /// ObjectProperty: CoverHalfPopUpGrenadeThrowBackwardsLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverHalfPopUpGrenadeThrowBackwardsLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5816); }
    }

    /// <summary>
    /// ObjectProperty: CoverHalfPopUpGrenadeThrowBackwardsRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverHalfPopUpGrenadeThrowBackwardsRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5820); }
    }

    /// <summary>
    /// ObjectProperty: CoverFullGrenadeThrowBackwardsLeftSide
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverFullGrenadeThrowBackwardsLeftSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5824); }
    }

    /// <summary>
    /// ObjectProperty: CoverFullGrenadeThrowBackwardsRightSide
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverFullGrenadeThrowBackwardsRightSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5828); }
    }

    /// <summary>
    /// ObjectProperty: CoverHalfPopUpGrenadeThrowBackwardsLeftSide
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverHalfPopUpGrenadeThrowBackwardsLeftSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5832); }
    }

    /// <summary>
    /// ObjectProperty: CoverHalfPopUpGrenadeThrowBackwardsRightSide
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CoverHalfPopUpGrenadeThrowBackwardsRightSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5836); }
    }

    /// <summary>
    /// ObjectProperty: Quick180Turn
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig Quick180Turn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5840); }
    }

    /// <summary>
    /// ObjectProperty: DualWieldQuick180Turn
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DualWieldQuick180Turn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5844); }
    }

    /// <summary>
    /// ArrayProperty: CoverStateNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CoverStateNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 5848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5848); }
    }

    /// <summary>
    /// StructProperty: RunningNextFacing
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RunningNextFacing
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5860);

    /// <summary>
    /// StructProperty: LastFrameFaceDirection
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastFrameFaceDirection
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5872);

    /// <summary>
    /// FloatProperty: CurrentLowHealthPPValue
    /// </summary>
    public unsafe float CurrentLowHealthPPValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5884); }
    }

    /// <summary>
    /// FloatProperty: CurrentDeadPPValue
    /// </summary>
    public unsafe float CurrentDeadPPValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5888); }
    }

    /// <summary>
    /// FloatProperty: DeathPPELerpTime
    /// </summary>
    public unsafe float DeathPPELerpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5892); }
    }

    /// <summary>
    /// FloatProperty: DamagePPEWhenDeadLerpTime
    /// </summary>
    public unsafe float DamagePPEWhenDeadLerpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5896); }
    }

    /// <summary>
    /// ObjectProperty: GadgetToEquipPostCover
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetToEquipPostCover
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5900); }
    }

    /// <summary>
    /// IntProperty: LastSupervillainRespawnTime
    /// </summary>
    public unsafe int LastSupervillainRespawnTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5904); }
    }

    /// <summary>
    /// FloatProperty: StartedInteractionTime
    /// </summary>
    public unsafe float StartedInteractionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5908); }
    }

    /// <summary>
    /// ObjectProperty: DebugInteractionBar
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject DebugInteractionBar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 5912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5912); }
    }

    /// <summary>
    /// FloatProperty: CachedInteractionBarPercentage
    /// </summary>
    public unsafe float CachedInteractionBarPercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5916); }
    }

    /// <summary>
    /// IntProperty: NextAmmoRefillStageIndex
    /// </summary>
    public unsafe int NextAmmoRefillStageIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5920); }
    }

    /// <summary>
    /// ObjectProperty: InUseAmmoCrate
    /// </summary>
    public unsafe BmSDK.BmGame.GDAmmoPickupObjectBase InUseAmmoCrate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDAmmoPickupObjectBase>(Ptr + 5924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5924); }
    }

    /// <summary>
    /// StructProperty: ExitVector
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ExitVector
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5928);

    /// <summary>
    /// FloatProperty: DelayedCharacterTransitionFrozenTime
    /// </summary>
    public unsafe float DelayedCharacterTransitionFrozenTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5940); }
    }

    /// <summary>
    /// FloatProperty: DelayedCharacterTransitionSpectateEndTime
    /// </summary>
    public unsafe float DelayedCharacterTransitionSpectateEndTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5944); }
    }

    /// <summary>
    /// IntProperty: ControllableGadgetCachedTimerFrameNum
    /// </summary>
    public unsafe int ControllableGadgetCachedTimerFrameNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5948); }
    }

    /// <summary>
    /// IntProperty: ControllableGadgetTimerStartFrameNum
    /// </summary>
    public unsafe int ControllableGadgetTimerStartFrameNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5952); }
    }

    /// <summary>
    /// IntProperty: ControllableGadgetTimerEndFrameNum
    /// </summary>
    public unsafe int ControllableGadgetTimerEndFrameNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5956); }
    }

    /// <summary>
    /// FloatProperty: ControllableGadgetTimerIconXPos
    /// </summary>
    public unsafe float ControllableGadgetTimerIconXPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5960); }
    }

    /// <summary>
    /// FloatProperty: ControllableGadgetTimerIconYPos
    /// </summary>
    public unsafe float ControllableGadgetTimerIconYPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5964); }
    }

    /// <summary>
    /// FloatProperty: ControllableGadgetTimerIconScale
    /// </summary>
    public unsafe float ControllableGadgetTimerIconScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5968); }
    }

    /// <summary>
    /// ObjectProperty: CurrentlySpectatedWeapon
    /// </summary>
    public unsafe BmSDK.BmGame.GDBaseGunGadget CurrentlySpectatedWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBaseGunGadget>(Ptr + 5972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5972); }
    }

    /// <summary>
    /// ObjectProperty: CurrentlySpectatedPawn
    /// </summary>
    public unsafe BmSDK.BmGame.GDPawnPlayerThugBase CurrentlySpectatedPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDPawnPlayerThugBase>(Ptr + 5976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5976); }
    }

    /// <summary>
    /// StructProperty: CachedThugServerMoveData
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPlayerControllerCombatThug.FsServerThugMoveData CachedThugServerMoveData
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPlayerControllerCombatThug.FsServerThugMoveData>(Ptr + 5980);
}
