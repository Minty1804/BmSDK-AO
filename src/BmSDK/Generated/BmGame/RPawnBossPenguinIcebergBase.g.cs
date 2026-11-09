#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RPawnBossPenguinIcebergBase<br/>
/// (size = 3520)
/// (flags = 211812535)
/// </summary>
public partial class RPawnBossPenguinIcebergBase : BmSDK.BmGame.RPawnFriendly, BmSDK.BmGame.RBatarangableInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnBossPenguinIcebergBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnBossPenguinIcebergBase.
    /// </summary>
    public static RPawnBossPenguinIcebergBase DefaultObject => (RPawnBossPenguinIcebergBase)StaticClass().DefaultObject;

    internal RPawnBossPenguinIcebergBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnBossPenguinIcebergBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnBossPenguinIcebergBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossPenguinIcebergBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnBossPenguinIcebergBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossPenguinIcebergBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossPenguinIcebergBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossPenguinIcebergBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnBossPenguinIcebergBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossPenguinIcebergBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CheckDodgeProjectile;
    /// <summary>
    /// Function: CheckDodgeProjectile
    /// </summary>
    public unsafe override bool CheckDodgeProjectile(BmSDK.BmGame.RPawn Thrower, BmSDK.FName TargetBone, System.Numerics.Vector3 ProjPos, int BatarangID, bool bForceDodge = default, bool bSteerableProj = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckDodgeProjectile, "BmGame.RPawnBossPenguinIcebergBase.CheckDodgeProjectile");
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

    private static BmSDK.Function __fn_DodgeBatarang;
    /// <summary>
    /// Function: DodgeBatarang
    /// </summary>
    public unsafe virtual void DodgeBatarang()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DodgeBatarang, "BmGame.RPawnBossPenguinIcebergBase.DodgeBatarang");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RotateGun;
    /// <summary>
    /// Function: RotateGun
    /// </summary>
    public unsafe virtual void RotateGun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RotateGun, "BmGame.RPawnBossPenguinIcebergBase.RotateGun");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BatmanWithinRange;
    /// <summary>
    /// Function: BatmanWithinRange
    /// </summary>
    public unsafe virtual void BatmanWithinRange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatmanWithinRange, "BmGame.RPawnBossPenguinIcebergBase.BatmanWithinRange");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GoNormal;
    /// <summary>
    /// Function: GoNormal
    /// </summary>
    public unsafe virtual void GoNormal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GoNormal, "BmGame.RPawnBossPenguinIcebergBase.GoNormal");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GoCocky;
    /// <summary>
    /// Function: GoCocky
    /// </summary>
    public unsafe virtual void GoCocky()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GoCocky, "BmGame.RPawnBossPenguinIcebergBase.GoCocky");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_JamGun;
    /// <summary>
    /// Function: JamGun
    /// </summary>
    public unsafe virtual void JamGun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_JamGun, "BmGame.RPawnBossPenguinIcebergBase.JamGun");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PowerDown;
    /// <summary>
    /// Function: PowerDown
    /// </summary>
    public unsafe virtual void PowerDown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PowerDown, "BmGame.RPawnBossPenguinIcebergBase.PowerDown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPrompt;
    /// <summary>
    /// Function: GetPrompt
    /// </summary>
    public unsafe override BmSDK.FString GetPrompt(BmSDK.Engine.PlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPrompt, "BmGame.RPawnBossPenguinIcebergBase.GetPrompt");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsActive;
    /// <summary>
    /// Function: IsActive
    /// </summary>
    public unsafe override bool IsActive(BmSDK.BmGame.RPlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsActive, "BmGame.RPawnBossPenguinIcebergBase.IsActive");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetOverrideInteractIcon;
    /// <summary>
    /// Function: GetOverrideInteractIcon
    /// </summary>
    public unsafe override BmSDK.BmGame.RHUDPrompt.EControlIcon GetOverrideInteractIcon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOverrideInteractIcon, "BmGame.RPawnBossPenguinIcebergBase.GetOverrideInteractIcon");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHUDPrompt.EControlIcon>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsCounterButton;
    /// <summary>
    /// Function: IsCounterButton
    /// </summary>
    public unsafe override bool IsCounterButton()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCounterButton, "BmGame.RPawnBossPenguinIcebergBase.IsCounterButton");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsButtonPrompt;
    /// <summary>
    /// Function: IsButtonPrompt
    /// </summary>
    public unsafe override bool IsButtonPrompt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsButtonPrompt, "BmGame.RPawnBossPenguinIcebergBase.IsButtonPrompt");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_EitherButtonAllowed;
    /// <summary>
    /// Function: EitherButtonAllowed
    /// </summary>
    public unsafe override bool EitherButtonAllowed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EitherButtonAllowed, "BmGame.RPawnBossPenguinIcebergBase.EitherButtonAllowed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRange;
    /// <summary>
    /// Function: GetRange
    /// </summary>
    public unsafe override float GetRange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRange, "BmGame.RPawnBossPenguinIcebergBase.GetRange");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Interact;
    /// <summary>
    /// Function: Interact
    /// </summary>
    public unsafe override void Interact(BmSDK.BmGame.RPlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Interact, "BmGame.RPawnBossPenguinIcebergBase.Interact");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PenguinHitByGadget;
    /// <summary>
    /// Function: PenguinHitByGadget
    /// </summary>
    public unsafe virtual void PenguinHitByGadget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PenguinHitByGadget, "BmGame.RPawnBossPenguinIcebergBase.PenguinHitByGadget");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetGunXray;
    /// <summary>
    /// Function: ResetGunXray
    /// </summary>
    public unsafe virtual void ResetGunXray()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetGunXray, "BmGame.RPawnBossPenguinIcebergBase.ResetGunXray");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Touch, "BmGame.RPawnBossPenguinIcebergBase.Touch");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHeightRange;
    /// <summary>
    /// Function: GetHeightRange
    /// </summary>
    public unsafe override float GetHeightRange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeightRange, "BmGame.RPawnBossPenguinIcebergBase.GetHeightRange");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UsesAttackButton;
    /// <summary>
    /// Function: UsesAttackButton
    /// </summary>
    public unsafe override bool UsesAttackButton()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UsesAttackButton, "BmGame.RPawnBossPenguinIcebergBase.UsesAttackButton");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopFreezeRay;
    /// <summary>
    /// Function: StopFreezeRay
    /// </summary>
    public unsafe virtual void StopFreezeRay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopFreezeRay, "BmGame.RPawnBossPenguinIcebergBase.StopFreezeRay");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RPawnBossPenguinIcebergBase.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BatmanTooClose;
    /// <summary>
    /// Function: BatmanTooClose
    /// </summary>
    public unsafe virtual bool BatmanTooClose()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatmanTooClose, "BmGame.RPawnBossPenguinIcebergBase.BatmanTooClose");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StartNextState;
    /// <summary>
    /// Function: StartNextState
    /// </summary>
    public unsafe virtual void StartNextState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartNextState, "BmGame.RPawnBossPenguinIcebergBase.StartNextState");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopFiringIce;
    /// <summary>
    /// Function: StopFiringIce
    /// </summary>
    public unsafe virtual void StopFiringIce()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopFiringIce, "BmGame.RPawnBossPenguinIcebergBase.StopFiringIce");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanSeeBatman;
    /// <summary>
    /// Function: CanSeeBatman
    /// </summary>
    public unsafe virtual bool CanSeeBatman()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSeeBatman, "BmGame.RPawnBossPenguinIcebergBase.CanSeeBatman");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PunchedEvent;
    /// <summary>
    /// Function: PunchedEvent
    /// </summary>
    public unsafe virtual void PunchedEvent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PunchedEvent, "BmGame.RPawnBossPenguinIcebergBase.PunchedEvent");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBatarangSpeedBoost;
    /// <summary>
    /// Function: GetBatarangSpeedBoost
    /// </summary>
    public unsafe virtual float GetBatarangSpeedBoost()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatarangSpeedBoost, "BmGame.RPawnBossPenguinIcebergBase.GetBatarangSpeedBoost");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceHitAtEndOfFlight, "BmGame.RPawnBossPenguinIcebergBase.ForceHitAtEndOfFlight");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatarangPriority, "BmGame.RPawnBossPenguinIcebergBase.GetBatarangPriority");
        byte* paramsPtr = stackalloc byte[20];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBatarangable, "BmGame.RPawnBossPenguinIcebergBase.IsBatarangable");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBatarangTargetPosition;
    /// <summary>
    /// Function: GetBatarangTargetPosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetBatarangTargetPosition(System.Numerics.Vector3 AimLocation, System.Numerics.Vector3 AimDirection, bool bDuringTargetPhase = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatarangTargetPosition, "BmGame.RPawnBossPenguinIcebergBase.GetBatarangTargetPosition");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimDirection, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDuringTargetPhase, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_FreezeRayShot;
    /// <summary>
    /// Function: FreezeRayShot
    /// </summary>
    public unsafe virtual void FreezeRayShot()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FreezeRayShot, "BmGame.RPawnBossPenguinIcebergBase.FreezeRayShot");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAimPoint;
    /// <summary>
    /// Function: GetAimPoint
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAimPoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAimPoint, "BmGame.RPawnBossPenguinIcebergBase.GetAimPoint");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRepelSound;
    /// <summary>
    /// Function: GetRepelSound
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetRepelSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRepelSound, "BmGame.RPawnBossPenguinIcebergBase.GetRepelSound");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckBatarang;
    /// <summary>
    /// Function: CheckBatarang
    /// </summary>
    public unsafe virtual void CheckBatarang()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckBatarang, "BmGame.RPawnBossPenguinIcebergBase.CheckBatarang");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float UpdateTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RPawnBossPenguinIcebergBase.Tick");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdateTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: Batman
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController Batman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 3368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3368); }
    }

    /// <summary>
    /// FloatProperty: BatmanImmuneTime
    /// </summary>
    public unsafe float BatmanImmuneTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3372); }
    }

    /// <summary>
    /// IntProperty: DifficultyLevel
    /// </summary>
    public unsafe int DifficultyLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3376); }
    }

    /// <summary>
    /// FloatProperty: IdleStateTime
    /// </summary>
    public unsafe float IdleStateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3380); }
    }

    /// <summary>
    /// BoolProperty: bReadyToJam
    /// </summary>
    public unsafe bool bReadyToJam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3384) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3384); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3384); }
    }

    /// <summary>
    /// BoolProperty: bJammed
    /// </summary>
    public unsafe bool bJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3384) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3384); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3384); }
    }

    /// <summary>
    /// BoolProperty: bHasFiredAfterReadyToJam
    /// </summary>
    public unsafe bool bHasFiredAfterReadyToJam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3384) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3384); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3384); }
    }

    /// <summary>
    /// BoolProperty: bFiringSound
    /// </summary>
    public unsafe bool bFiringSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3384) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3384); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3384); }
    }

    /// <summary>
    /// BoolProperty: bReadyToAttack
    /// </summary>
    public unsafe bool bReadyToAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3384) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3384); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3384); }
    }

    /// <summary>
    /// BoolProperty: bBegunFiring
    /// </summary>
    public unsafe bool bBegunFiring
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3384) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3384); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3384); }
    }

    /// <summary>
    /// BoolProperty: bUppercutStarted
    /// </summary>
    public unsafe bool bUppercutStarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3384) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3384); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3384); }
    }

    /// <summary>
    /// BoolProperty: BatmanHitInLastAttack
    /// </summary>
    public unsafe bool BatmanHitInLastAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3384) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3384); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3384); }
    }

    /// <summary>
    /// BoolProperty: bAllowAiming
    /// </summary>
    public unsafe bool bAllowAiming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3384) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3384); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3384); }
    }

    /// <summary>
    /// StructProperty: BatarangThrowPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BatarangThrowPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3388);

    /// <summary>
    /// ObjectProperty: GunJammedPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem GunJammedPFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3400); }
    }

    /// <summary>
    /// ObjectProperty: BrokenEmitter
    /// </summary>
    public unsafe BmSDK.Engine.Emitter BrokenEmitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Emitter>(Ptr + 3404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3404); }
    }

    /// <summary>
    /// FloatProperty: RepelTimer
    /// </summary>
    public unsafe float RepelTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3408); }
    }

    /// <summary>
    /// StructProperty: StartPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StartPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3412);

    /// <summary>
    /// ObjectProperty: UpdateAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_UpdatePenguin UpdateAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_UpdatePenguin>(Ptr + 3424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3424); }
    }

    /// <summary>
    /// ComponentProperty: PlayerInteractions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent PlayerInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 3428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3428); }
    }

    /// <summary>
    /// ObjectProperty: GunMat
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant GunMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 3432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3432); }
    }

    /// <summary>
    /// ObjectProperty: RepelPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem RepelPFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3436); }
    }

    /// <summary>
    /// ObjectProperty: RepelSFX
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RepelSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 3440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3440); }
    }

    /// <summary>
    /// ObjectProperty: PenguinAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PenguinAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3444); }
    }

    /// <summary>
    /// FloatProperty: ReloadTime
    /// </summary>
    public unsafe float ReloadTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3448); }
    }

    /// <summary>
    /// FloatProperty: MaxReloadTime
    /// </summary>
    public unsafe float MaxReloadTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3452); }
    }

    /// <summary>
    /// FloatProperty: FireTime
    /// </summary>
    public unsafe float FireTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3456); }
    }

    /// <summary>
    /// StructProperty: CurrentAimPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentAimPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3460);

    /// <summary>
    /// FloatProperty: BaseTooCloseDistance
    /// </summary>
    public unsafe float BaseTooCloseDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3472); }
    }

    /// <summary>
    /// FloatProperty: TooCloseDiffFront
    /// </summary>
    public unsafe float TooCloseDiffFront
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3476); }
    }

    /// <summary>
    /// ObjectProperty: FinishPenguinMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig FinishPenguinMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3480); }
    }

    /// <summary>
    /// ObjectProperty: BatmanEvadeMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig BatmanEvadeMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3484); }
    }

    /// <summary>
    /// ObjectProperty: BatmanHitByFinalFire
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig BatmanHitByFinalFire
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3488); }
    }

    /// <summary>
    /// ObjectProperty: BatmanHitByIce
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig BatmanHitByIce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3492); }
    }

    /// <summary>
    /// IntProperty: GunIndex
    /// </summary>
    public unsafe int GunIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3496); }
    }

    /// <summary>
    /// ArrayProperty: FirePoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> FirePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 3500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3500); }
    }

    /// <summary>
    /// IntProperty: CurrentCheckPoint
    /// </summary>
    public unsafe int CurrentCheckPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3512); }
    }

    /// <summary>
    /// ObjectProperty: BridgeDir
    /// </summary>
    public unsafe BmSDK.Engine.Actor BridgeDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 3516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3516); }
    }
}
