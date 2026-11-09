#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MShockGlovesBase<br/>
/// (size = 1212)
/// (flags = 142606514)
/// </summary>
public partial class MShockGlovesBase : BmSDK.BmGame.RInventoryGadget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MShockGlovesBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MShockGlovesBase.
    /// </summary>
    public static MShockGlovesBase DefaultObject => (MShockGlovesBase)StaticClass().DefaultObject;

    internal MShockGlovesBase() { }

    /// <summary>
    /// Constructs a new MShockGlovesBase
    /// </summary>
    public MShockGlovesBase(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MShockGlovesBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MShockGlovesBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MShockGlovesBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MShockGlovesBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MShockGlovesBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MShockGlovesBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MShockGlovesBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MShockGlovesBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MShockGlovesBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetPrimedPose;
    /// <summary>
    /// Function: GetPrimedPose
    /// </summary>
    public unsafe override BmSDK.FName GetPrimedPose(out BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch StanceIsCrouched, out BmSDK.BmGame.RAnimUtil.EMirrorChoice MirroredNess, bool InSoftCover, BmSDK.BmGame.RInventoryGadget.CoverCornerType CornerType, out BmSDK.FName OutCapeState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPrimedPose, "BmGame.MShockGlovesBase.GetPrimedPose");
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

    private static BmSDK.Function __fn_AreaStunSuccess;
    /// <summary>
    /// Function: AreaStunSuccess
    /// </summary>
    public unsafe virtual void AreaStunSuccess()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreaStunSuccess, "BmGame.MShockGlovesBase.AreaStunSuccess");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireKnockBack;
    /// <summary>
    /// Function: FireKnockBack
    /// </summary>
    public unsafe virtual bool FireKnockBack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireKnockBack, "BmGame.MShockGlovesBase.FireKnockBack");
        byte* paramsPtr = stackalloc byte[144];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpawnStrikeLight;
    /// <summary>
    /// Function: SpawnStrikeLight
    /// </summary>
    public unsafe virtual void SpawnStrikeLight(System.Numerics.Vector3 pos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnStrikeLight, "BmGame.MShockGlovesBase.SpawnStrikeLight");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryActivateShockGloves;
    /// <summary>
    /// Function: TryActivateShockGloves
    /// </summary>
    public unsafe virtual void TryActivateShockGloves()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryActivateShockGloves, "BmGame.MShockGlovesBase.TryActivateShockGloves");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnParticleSystemFinished;
    /// <summary>
    /// Function: OnParticleSystemFinished
    /// </summary>
    public unsafe virtual void OnParticleSystemFinished(BmSDK.Engine.ParticleSystemComponent FinishedComponent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnParticleSystemFinished, "BmGame.MShockGlovesBase.OnParticleSystemFinished");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedComponent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetShockGloveFX;
    /// <summary>
    /// Function: SetShockGloveFX
    /// </summary>
    public unsafe virtual void SetShockGloveFX(bool bActive)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetShockGloveFX, "BmGame.MShockGlovesBase.SetShockGloveFX");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActive, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerActivationFx;
    /// <summary>
    /// Function: TriggerActivationFx
    /// </summary>
    public unsafe virtual void TriggerActivationFx()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerActivationFx, "BmGame.MShockGlovesBase.TriggerActivationFx");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AutoDeactiveShockGloveTimer;
    /// <summary>
    /// Function: AutoDeactiveShockGloveTimer
    /// </summary>
    public unsafe virtual void AutoDeactiveShockGloveTimer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AutoDeactiveShockGloveTimer, "BmGame.MShockGlovesBase.AutoDeactiveShockGloveTimer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatFinished;
    /// <summary>
    /// Function: CombatFinished
    /// </summary>
    public unsafe virtual void CombatFinished()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatFinished, "BmGame.MShockGlovesBase.CombatFinished");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyCombatFinished;
    /// <summary>
    /// Function: NotifyCombatFinished
    /// </summary>
    public unsafe virtual void NotifyCombatFinished()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyCombatFinished, "BmGame.MShockGlovesBase.NotifyCombatFinished");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyCombatStarted;
    /// <summary>
    /// Function: NotifyCombatStarted
    /// </summary>
    public unsafe virtual void NotifyCombatStarted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyCombatStarted, "BmGame.MShockGlovesBase.NotifyCombatStarted");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GatherMagnecticProp;
    /// <summary>
    /// Function: GatherMagnecticProp
    /// </summary>
    public unsafe virtual void GatherMagnecticProp()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GatherMagnecticProp, "BmGame.MShockGlovesBase.GatherMagnecticProp");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ConsumeEnergyCustom;
    /// <summary>
    /// Function: ConsumeEnergyCustom
    /// </summary>
    public unsafe virtual void ConsumeEnergyCustom(float ConsumptionValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConsumeEnergyCustom, "BmGame.MShockGlovesBase.ConsumeEnergyCustom");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConsumptionValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RechargeEnergyCustom;
    /// <summary>
    /// Function: RechargeEnergyCustom
    /// </summary>
    public unsafe virtual void RechargeEnergyCustom(float Amount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RechargeEnergyCustom, "BmGame.MShockGlovesBase.RechargeEnergyCustom");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Amount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCounterRecharge;
    /// <summary>
    /// Function: GetCounterRecharge
    /// </summary>
    public unsafe virtual float GetCounterRecharge(BmSDK.BmGame.MInventoryGadgetConfig_ShockGloves ShockGlovesConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCounterRecharge, "BmGame.MShockGlovesBase.GetCounterRecharge");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShockGlovesConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetFocusStrikeRecharge;
    /// <summary>
    /// Function: GetFocusStrikeRecharge
    /// </summary>
    public unsafe virtual float GetFocusStrikeRecharge(BmSDK.BmGame.MInventoryGadgetConfig_ShockGloves ShockGlovesConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFocusStrikeRecharge, "BmGame.MShockGlovesBase.GetFocusStrikeRecharge");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShockGlovesConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetCriticalStrikeRecharge;
    /// <summary>
    /// Function: GetCriticalStrikeRecharge
    /// </summary>
    public unsafe virtual float GetCriticalStrikeRecharge(BmSDK.BmGame.MInventoryGadgetConfig_ShockGloves ShockGlovesConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCriticalStrikeRecharge, "BmGame.MShockGlovesBase.GetCriticalStrikeRecharge");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShockGlovesConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetStrikeRecharge;
    /// <summary>
    /// Function: GetStrikeRecharge
    /// </summary>
    public unsafe virtual float GetStrikeRecharge(BmSDK.BmGame.MInventoryGadgetConfig_ShockGloves ShockGlovesConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeRecharge, "BmGame.MShockGlovesBase.GetStrikeRecharge");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShockGlovesConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetKnockElectrifyConsumption;
    /// <summary>
    /// Function: GetKnockElectrifyConsumption
    /// </summary>
    public unsafe virtual float GetKnockElectrifyConsumption(BmSDK.BmGame.MInventoryGadgetConfig_ShockGloves ShockGlovesConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetKnockElectrifyConsumption, "BmGame.MShockGlovesBase.GetKnockElectrifyConsumption");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShockGlovesConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetKnockBackConsumption;
    /// <summary>
    /// Function: GetKnockBackConsumption
    /// </summary>
    public unsafe virtual float GetKnockBackConsumption(BmSDK.BmGame.MInventoryGadgetConfig_ShockGloves ShockGlovesConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetKnockBackConsumption, "BmGame.MShockGlovesBase.GetKnockBackConsumption");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShockGlovesConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetCounterConsumption;
    /// <summary>
    /// Function: GetCounterConsumption
    /// </summary>
    public unsafe virtual float GetCounterConsumption(BmSDK.BmGame.MInventoryGadgetConfig_ShockGloves ShockGlovesConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCounterConsumption, "BmGame.MShockGlovesBase.GetCounterConsumption");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShockGlovesConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetFocusStrikeConsumption;
    /// <summary>
    /// Function: GetFocusStrikeConsumption
    /// </summary>
    public unsafe virtual float GetFocusStrikeConsumption(BmSDK.BmGame.MInventoryGadgetConfig_ShockGloves ShockGlovesConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFocusStrikeConsumption, "BmGame.MShockGlovesBase.GetFocusStrikeConsumption");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShockGlovesConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetCriticalStrikeConsumption;
    /// <summary>
    /// Function: GetCriticalStrikeConsumption
    /// </summary>
    public unsafe virtual float GetCriticalStrikeConsumption(BmSDK.BmGame.MInventoryGadgetConfig_ShockGloves ShockGlovesConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCriticalStrikeConsumption, "BmGame.MShockGlovesBase.GetCriticalStrikeConsumption");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShockGlovesConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetStrikeConsumption;
    /// <summary>
    /// Function: GetStrikeConsumption
    /// </summary>
    public unsafe virtual float GetStrikeConsumption(BmSDK.BmGame.MInventoryGadgetConfig_ShockGloves ShockGlovesConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeConsumption, "BmGame.MShockGlovesBase.GetStrikeConsumption");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShockGlovesConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetArealAttackRecharge;
    /// <summary>
    /// Function: GetArealAttackRecharge
    /// </summary>
    public unsafe virtual float GetArealAttackRecharge(BmSDK.BmGame.MInventoryGadgetConfig_ShockGloves ShockGlovesConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetArealAttackRecharge, "BmGame.MShockGlovesBase.GetArealAttackRecharge");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShockGlovesConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetPushStrikeRecharge;
    /// <summary>
    /// Function: GetPushStrikeRecharge
    /// </summary>
    public unsafe virtual float GetPushStrikeRecharge(BmSDK.BmGame.MInventoryGadgetConfig_ShockGloves ShockGlovesConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPushStrikeRecharge, "BmGame.MShockGlovesBase.GetPushStrikeRecharge");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShockGlovesConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetBatClawSlamRecharge;
    /// <summary>
    /// Function: GetBatClawSlamRecharge
    /// </summary>
    public unsafe virtual float GetBatClawSlamRecharge(BmSDK.BmGame.MInventoryGadgetConfig_ShockGloves ShockGlovesConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatClawSlamRecharge, "BmGame.MShockGlovesBase.GetBatClawSlamRecharge");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShockGlovesConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetGroundTakedownRecharge;
    /// <summary>
    /// Function: GetGroundTakedownRecharge
    /// </summary>
    public unsafe virtual float GetGroundTakedownRecharge(BmSDK.BmGame.MInventoryGadgetConfig_ShockGloves ShockGlovesConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGroundTakedownRecharge, "BmGame.MShockGlovesBase.GetGroundTakedownRecharge");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShockGlovesConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetComboTakedownRecharge;
    /// <summary>
    /// Function: GetComboTakedownRecharge
    /// </summary>
    public unsafe virtual float GetComboTakedownRecharge(BmSDK.BmGame.MInventoryGadgetConfig_ShockGloves ShockGlovesConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetComboTakedownRecharge, "BmGame.MShockGlovesBase.GetComboTakedownRecharge");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShockGlovesConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetBeatDownRecharge;
    /// <summary>
    /// Function: GetBeatDownRecharge
    /// </summary>
    public unsafe virtual float GetBeatDownRecharge(BmSDK.BmGame.MInventoryGadgetConfig_ShockGloves ShockGlovesConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBeatDownRecharge, "BmGame.MShockGlovesBase.GetBeatDownRecharge");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShockGlovesConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetFinalBeatDownRecharge;
    /// <summary>
    /// Function: GetFinalBeatDownRecharge
    /// </summary>
    public unsafe virtual float GetFinalBeatDownRecharge(BmSDK.BmGame.MInventoryGadgetConfig_ShockGloves ShockGlovesConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFinalBeatDownRecharge, "BmGame.MShockGlovesBase.GetFinalBeatDownRecharge");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShockGlovesConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetArealAttackConsumption;
    /// <summary>
    /// Function: GetArealAttackConsumption
    /// </summary>
    public unsafe virtual float GetArealAttackConsumption(BmSDK.BmGame.MInventoryGadgetConfig_ShockGloves ShockGlovesConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetArealAttackConsumption, "BmGame.MShockGlovesBase.GetArealAttackConsumption");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShockGlovesConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetPushStrikeConsumption;
    /// <summary>
    /// Function: GetPushStrikeConsumption
    /// </summary>
    public unsafe virtual float GetPushStrikeConsumption(BmSDK.BmGame.MInventoryGadgetConfig_ShockGloves ShockGlovesConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPushStrikeConsumption, "BmGame.MShockGlovesBase.GetPushStrikeConsumption");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShockGlovesConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetBatClawSlamConsumption;
    /// <summary>
    /// Function: GetBatClawSlamConsumption
    /// </summary>
    public unsafe virtual float GetBatClawSlamConsumption(BmSDK.BmGame.MInventoryGadgetConfig_ShockGloves ShockGlovesConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatClawSlamConsumption, "BmGame.MShockGlovesBase.GetBatClawSlamConsumption");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShockGlovesConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetGroundTakedownConsumption;
    /// <summary>
    /// Function: GetGroundTakedownConsumption
    /// </summary>
    public unsafe virtual float GetGroundTakedownConsumption(BmSDK.BmGame.MInventoryGadgetConfig_ShockGloves ShockGlovesConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGroundTakedownConsumption, "BmGame.MShockGlovesBase.GetGroundTakedownConsumption");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShockGlovesConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetComboTakedownConsumption;
    /// <summary>
    /// Function: GetComboTakedownConsumption
    /// </summary>
    public unsafe virtual float GetComboTakedownConsumption(BmSDK.BmGame.MInventoryGadgetConfig_ShockGloves ShockGlovesConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetComboTakedownConsumption, "BmGame.MShockGlovesBase.GetComboTakedownConsumption");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShockGlovesConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetBeatDownConsumption;
    /// <summary>
    /// Function: GetBeatDownConsumption
    /// </summary>
    public unsafe virtual float GetBeatDownConsumption(BmSDK.BmGame.MInventoryGadgetConfig_ShockGloves ShockGlovesConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBeatDownConsumption, "BmGame.MShockGlovesBase.GetBeatDownConsumption");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShockGlovesConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetFinalBeatDownConsumption;
    /// <summary>
    /// Function: GetFinalBeatDownConsumption
    /// </summary>
    public unsafe virtual float GetFinalBeatDownConsumption(BmSDK.BmGame.MInventoryGadgetConfig_ShockGloves ShockGlovesConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFinalBeatDownConsumption, "BmGame.MShockGlovesBase.GetFinalBeatDownConsumption");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShockGlovesConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetStrikeStunMultiplier;
    /// <summary>
    /// Function: GetStrikeStunMultiplier
    /// </summary>
    public unsafe virtual float GetStrikeStunMultiplier()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeStunMultiplier, "BmGame.MShockGlovesBase.GetStrikeStunMultiplier");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCounterStunMultiplier;
    /// <summary>
    /// Function: GetCounterStunMultiplier
    /// </summary>
    public unsafe virtual float GetCounterStunMultiplier()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCounterStunMultiplier, "BmGame.MShockGlovesBase.GetCounterStunMultiplier");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetShockGloveStunStopSound;
    /// <summary>
    /// Function: GetShockGloveStunStopSound
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetShockGloveStunStopSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetShockGloveStunStopSound, "BmGame.MShockGlovesBase.GetShockGloveStunStopSound");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetShockGloveStunSound;
    /// <summary>
    /// Function: GetShockGloveStunSound
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetShockGloveStunSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetShockGloveStunSound, "BmGame.MShockGlovesBase.GetShockGloveStunSound");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetShockGloveStunFx;
    /// <summary>
    /// Function: GetShockGloveStunFx
    /// </summary>
    public unsafe virtual BmSDK.Engine.ParticleSystem GetShockGloveStunFx()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetShockGloveStunFx, "BmGame.MShockGlovesBase.GetShockGloveStunFx");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.ParticleSystem>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ConsumeEnergy;
    /// <summary>
    /// Function: ConsumeEnergy
    /// </summary>
    public unsafe virtual void ConsumeEnergy(BmSDK.BmGame.MShockGlovesBase.ShockGloves_ConsumptionType ConsumeType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConsumeEnergy, "BmGame.MShockGlovesBase.ConsumeEnergy");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConsumeType, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHelpPrompt, "BmGame.MShockGlovesBase.GetHelpPrompt");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateShockHud;
    /// <summary>
    /// Function: UpdateShockHud
    /// </summary>
    public unsafe virtual void UpdateShockHud(BmSDK.FString State)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateShockHud, "BmGame.MShockGlovesBase.UpdateShockHud");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(State, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanCharge;
    /// <summary>
    /// Function: CanCharge
    /// </summary>
    public unsafe virtual bool CanCharge()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanCharge, "BmGame.MShockGlovesBase.CanCharge");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ForceDeactivate;
    /// <summary>
    /// Function: ForceDeactivate
    /// </summary>
    public unsafe virtual void ForceDeactivate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceDeactivate, "BmGame.MShockGlovesBase.ForceDeactivate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateGloves;
    /// <summary>
    /// Function: UpdateGloves
    /// </summary>
    public unsafe virtual void UpdateGloves(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateGloves, "BmGame.MShockGlovesBase.UpdateGloves");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateSound;
    /// <summary>
    /// Function: UpdateSound
    /// </summary>
    public unsafe virtual void UpdateSound(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateSound, "BmGame.MShockGlovesBase.UpdateSound");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsFullOfEnergy;
    /// <summary>
    /// Function: IsFullOfEnergy
    /// </summary>
    public unsafe virtual bool IsFullOfEnergy()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFullOfEnergy, "BmGame.MShockGlovesBase.IsFullOfEnergy");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShockGloveImpactHit;
    /// <summary>
    /// Function: ShockGloveImpactHit
    /// </summary>
    public unsafe virtual void ShockGloveImpactHit(BmSDK.FName BoneName, BmSDK.BmGame.MShockGlovesBase.ShockGloves_ConsumptionType ConsumeType = default, bool IgnoreMirorring = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShockGloveImpactHit, "BmGame.MShockGlovesBase.ShockGloveImpactHit");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConsumeType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IgnoreMirorring, paramsPtr + 12);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireGadgetCombat, "BmGame.MShockGlovesBase.FireGadgetCombat");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ForceEmergencyFire;
    /// <summary>
    /// Function: ForceEmergencyFire
    /// </summary>
    public unsafe override bool ForceEmergencyFire()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceEmergencyFire, "BmGame.MShockGlovesBase.ForceEmergencyFire");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanQuickFire;
    /// <summary>
    /// Function: CanQuickFire
    /// </summary>
    public unsafe override bool CanQuickFire()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanQuickFire, "BmGame.MShockGlovesBase.CanQuickFire");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsCharging;
    /// <summary>
    /// Function: IsCharging
    /// </summary>
    public unsafe override bool IsCharging()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCharging, "BmGame.MShockGlovesBase.IsCharging");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanCounterShield;
    /// <summary>
    /// Function: CanCounterShield
    /// </summary>
    public unsafe virtual bool CanCounterShield()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanCounterShield, "BmGame.MShockGlovesBase.CanCounterShield");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanCounterStunStick;
    /// <summary>
    /// Function: CanCounterStunStick
    /// </summary>
    public unsafe virtual bool CanCounterStunStick()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanCounterStunStick, "BmGame.MShockGlovesBase.CanCounterStunStick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AreActive;
    /// <summary>
    /// Function: AreActive
    /// </summary>
    public unsafe virtual bool AreActive()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreActive, "BmGame.MShockGlovesBase.AreActive");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.MShockGlovesBase.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CoolDownShockGloves;
    /// <summary>
    /// Function: CoolDownShockGloves
    /// </summary>
    public unsafe virtual void CoolDownShockGloves()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CoolDownShockGloves, "BmGame.MShockGlovesBase.CoolDownShockGloves");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHeatGlovesEnable;
    /// <summary>
    /// Function: SetHeatGlovesEnable
    /// </summary>
    public unsafe virtual void SetHeatGlovesEnable(bool Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHeatGlovesEnable, "BmGame.MShockGlovesBase.SetHeatGlovesEnable");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsHeatGlovesEnable, "BmGame.MShockGlovesBase.IsHeatGlovesEnable");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Enum: ShockGloves_ConsumptionType
    /// </summary>
    public enum ShockGloves_ConsumptionType : byte
    {
        CONSUME_STRIKE = 0,
        CONSUME_CRITICAL_STRIKE = 1,
        CONSUME_FOCUS_STRIKE = 2,
        CONSUME_COUNTER = 3,
        CONSUME_STUN_COUNTER_BONUS = 4,
        CONSUME_KNOCK_BACK = 5,
        CONSUME_KNOCK_ELECTRIFY = 6,
        CONSUME_FINALBEATDOWN = 7,
        CONSUME_BEATDOWN = 8,
        CONSUME_GROUNDTAKEDOWN = 9,
        CONSUME_BATACLAWSLAM = 10,
        CONSUME_PUSHSTRIKE = 11,
        CONSUME_AERIALATTACK = 12,
        CONSUME_COMBOTAKEDOWN = 13,
        CONSUME_BANETAKEDOWN = 14,
        CONSUME_None = 15,
        CONSUME_MAX = 16,
    }

    /// <summary>
    /// ObjectProperty: ExplosionRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform ExplosionRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// FloatProperty: CurrentCombatEnergyLevel
    /// </summary>
    public unsafe float CurrentCombatEnergyLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// BoolProperty: bActivated
    /// </summary>
    public unsafe bool bActivated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 992) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 992); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 992); }
    }

    /// <summary>
    /// BoolProperty: InfiniteShockGloves
    /// </summary>
    public unsafe bool InfiniteShockGloves
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 992) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 992); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 992); }
    }

    /// <summary>
    /// BoolProperty: HasBaneBossEnhancedShockGlove
    /// </summary>
    public unsafe bool HasBaneBossEnhancedShockGlove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 992) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 992); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 992); }
    }

    /// <summary>
    /// NameProperty: ReadyToThrowNextState
    /// </summary>
    public unsafe BmSDK.FName ReadyToThrowNextState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// ObjectProperty: ReceiverTarget
    /// </summary>
    public unsafe BmSDK.BmGame.MShockGlovesEnergyReceiverBase ReceiverTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MShockGlovesEnergyReceiverBase>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// ComponentProperty: ShockGlovesEmitterLeft
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ShockGlovesEmitterLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// ComponentProperty: ShockGlovesEmitterRight
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ShockGlovesEmitterRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// ComponentProperty: ShockGlovesEmitterLeftKnuckles
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ShockGlovesEmitterLeftKnuckles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// ComponentProperty: ShockGlovesEmitterRightKnuckles
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ShockGlovesEmitterRightKnuckles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// StructProperty: ActivationSfxHandle
    /// </summary>
    public unsafe ref BmSDK.Engine.AkWwise.FAkSoundHandle ActivationSfxHandle
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 1024);

    /// <summary>
    /// ComponentProperty: ShockGlovesActivationLeft
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ShockGlovesActivationLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// ComponentProperty: ShockGlovesActivationRight
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ShockGlovesActivationRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// ObjectProperty: ShockGlovesActivationFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ShockGlovesActivationFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// ObjectProperty: LightVolume
    /// </summary>
    public unsafe BmSDK.BmGame.MFogVolume LightVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MFogVolume>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// ClassProperty: LightVolumeClass
    /// </summary>
    public unsafe BmSDK.Class LightVolumeClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// ComponentProperty: ShockGlovesMeshComponent
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent ShockGlovesMeshComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// ObjectProperty: ShockGloveHandRight_PS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ShockGloveHandRight_PS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// ObjectProperty: ShockGloveHandLeft_PS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ShockGloveHandLeft_PS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// ObjectProperty: ShockGloveHandRightKnuckles
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ShockGloveHandRightKnuckles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// ObjectProperty: ShockGloveHandLeftKnuckles
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ShockGloveHandLeftKnuckles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ObjectProperty: ActivationSfx
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ActivationSfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// ObjectProperty: ActivateIdleSfx
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ActivateIdleSfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ObjectProperty: DeactivateSfx
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent DeactivateSfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// ObjectProperty: MeterFullSfx
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent MeterFullSfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// ObjectProperty: HitChargeSfx
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent HitChargeSfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// ObjectProperty: ImpactHitSoundSwichOn
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName ImpactHitSoundSwichOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ObjectProperty: ImpactHitSoundSwichOff
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName ImpactHitSoundSwichOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// ObjectProperty: ShockGloveSwfHud
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie ShockGloveSwfHud
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ObjectProperty: ShockGlovesGadgetAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet ShockGlovesGadgetAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// ObjectProperty: KnockBackMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig KnockBackMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// ObjectProperty: ElectrifyMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ElectrifyMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// ByteProperty: UpgradeCounterStunStick
    /// </summary>
    public unsafe BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility UpgradeCounterStunStick
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// ByteProperty: UpgradeCounterShield
    /// </summary>
    public unsafe BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility UpgradeCounterShield
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility>(Ptr + 1121); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1121); }
    }

    /// <summary>
    /// ByteProperty: UpgradeRegenerationTime
    /// </summary>
    public unsafe BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility UpgradeRegenerationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility>(Ptr + 1122); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1122); }
    }

    /// <summary>
    /// ObjectProperty: HitImpactFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem HitImpactFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// ObjectProperty: FinalBlowHitImpactFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem FinalBlowHitImpactFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// ObjectProperty: SoundSwitchShockGloveOn
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName SoundSwitchShockGloveOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// ObjectProperty: SoundSwitchShockGloveOff
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName SoundSwitchShockGloveOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// ObjectProperty: SoundParamGloveVelocity
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName SoundParamGloveVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// ObjectProperty: ShockGlovesHitStrike
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ShockGlovesHitStrike
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// ObjectProperty: ShockGlovesCriticalHitStrike
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ShockGlovesCriticalHitStrike
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// ObjectProperty: ShockGlovesHitBeatDown
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ShockGlovesHitBeatDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// FloatProperty: MaxGloveVelocity
    /// </summary>
    public unsafe float MaxGloveVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// StructProperty: LeftGloveLastPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LeftGloveLastPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1160);

    /// <summary>
    /// StructProperty: RightGloveLastPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RightGloveLastPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1172);

    /// <summary>
    /// FloatProperty: LastEnergyLossOrGain
    /// </summary>
    public unsafe float LastEnergyLossOrGain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// FloatProperty: FxUpdateTimer
    /// </summary>
    public unsafe float FxUpdateTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// FloatProperty: EnergyRechargedInBeatdown
    /// </summary>
    public unsafe float EnergyRechargedInBeatdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// FloatProperty: MaxEnergyFromConfig
    /// </summary>
    public unsafe float MaxEnergyFromConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// IntProperty: bIsHeatGlovesEnable
    /// </summary>
    public unsafe int bIsHeatGlovesEnable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// IntProperty: CurrentHeatGlovesStatus
    /// </summary>
    public unsafe int CurrentHeatGlovesStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }

    /// <summary>
    /// IntProperty: CustomHeatGlovesFlags
    /// </summary>
    public unsafe int CustomHeatGlovesFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }
}
