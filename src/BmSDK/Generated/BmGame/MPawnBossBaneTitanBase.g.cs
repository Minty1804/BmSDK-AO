#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: MPawnBossBaneTitanBase<br/>
/// (size = 4620)
/// (flags = 144703671)
/// </summary>
public partial class MPawnBossBaneTitanBase : BmSDK.BmGame.RPawnVillainCombat, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MPawnBossBaneTitanBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MPawnBossBaneTitanBase.
    /// </summary>
    public static MPawnBossBaneTitanBase DefaultObject => (MPawnBossBaneTitanBase)StaticClass().DefaultObject;

    internal MPawnBossBaneTitanBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MPawnBossBaneTitanBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnBossBaneTitanBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnBossBaneTitanBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnBossBaneTitanBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnBossBaneTitanBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnBossBaneTitanBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnBossBaneTitanBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnBossBaneTitanBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnBossBaneTitanBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_FindAndPlayOverridePlayerDeathAnim;
    /// <summary>
    /// Function: FindAndPlayOverridePlayerDeathAnim
    /// </summary>
    public unsafe virtual bool FindAndPlayOverridePlayerDeathAnim(BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindAndPlayOverridePlayerDeathAnim, "BmGame.MPawnBossBaneTitanBase.FindAndPlayOverridePlayerDeathAnim");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ShouldDrawHelpPrompt;
    /// <summary>
    /// Function: ShouldDrawHelpPrompt
    /// </summary>
    public unsafe virtual bool ShouldDrawHelpPrompt(out BmSDK.FString Text, out BmSDK.BmGame.RHUDPrompt.EControlIcon Icon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldDrawHelpPrompt, "BmGame.MPawnBossBaneTitanBase.ShouldDrawHelpPrompt");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Icon);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Icon, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Text = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
        Icon = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHUDPrompt.EControlIcon>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_DebugDrawVentRadius;
    /// <summary>
    /// Function: DebugDrawVentRadius
    /// </summary>
    public unsafe virtual void DebugDrawVentRadius()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugDrawVentRadius, "BmGame.MPawnBossBaneTitanBase.DebugDrawVentRadius");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldTakedownPrompt;
    /// <summary>
    /// Function: ShouldTakedownPrompt
    /// </summary>
    public unsafe virtual bool ShouldTakedownPrompt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldTakedownPrompt, "BmGame.MPawnBossBaneTitanBase.ShouldTakedownPrompt");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckForTransitionToShowdown;
    /// <summary>
    /// Function: CheckForTransitionToShowdown
    /// </summary>
    public unsafe virtual bool CheckForTransitionToShowdown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForTransitionToShowdown, "BmGame.MPawnBossBaneTitanBase.CheckForTransitionToShowdown");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMeleeDamage;
    /// <summary>
    /// Function: GetMeleeDamage
    /// </summary>
    public unsafe virtual int GetMeleeDamage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMeleeDamage, "BmGame.MPawnBossBaneTitanBase.GetMeleeDamage");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FollowNavHandle;
    /// <summary>
    /// Function: FollowNavHandle
    /// </summary>
    public unsafe override void FollowNavHandle(BmSDK.BmGame.RNavigationHandle NavHandle, BmSDK.BmGame.RBMAIAction_BaseMove NavAction = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FollowNavHandle, "BmGame.MPawnBossBaneTitanBase.FollowNavHandle");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NavHandle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NavAction, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReturnNavSafePosition;
    /// <summary>
    /// Function: ReturnNavSafePosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 ReturnNavSafePosition(System.Numerics.Vector3 uncheckedPos, float SafeDist = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReturnNavSafePosition, "BmGame.MPawnBossBaneTitanBase.ReturnNavSafePosition");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(uncheckedPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SafeDist, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ClearWallAvoidance;
    /// <summary>
    /// Function: ClearWallAvoidance
    /// </summary>
    public unsafe virtual void ClearWallAvoidance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearWallAvoidance, "BmGame.MPawnBossBaneTitanBase.ClearWallAvoidance");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableWallAvoidance;
    /// <summary>
    /// Function: DisableWallAvoidance
    /// </summary>
    public unsafe virtual void DisableWallAvoidance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableWallAvoidance, "BmGame.MPawnBossBaneTitanBase.DisableWallAvoidance");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyWallForce;
    /// <summary>
    /// Function: ApplyWallForce
    /// </summary>
    public unsafe virtual bool ApplyWallForce()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyWallForce, "BmGame.MPawnBossBaneTitanBase.ApplyWallForce");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateAwareness;
    /// <summary>
    /// Function: UpdateAwareness
    /// </summary>
    public unsafe virtual void UpdateAwareness()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateAwareness, "BmGame.MPawnBossBaneTitanBase.UpdateAwareness");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNextShowdownStep;
    /// <summary>
    /// Function: GetNextShowdownStep
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RSpecialMoveConfig GetNextShowdownStep()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextShowdownStep, "BmGame.MPawnBossBaneTitanBase.GetNextShowdownStep");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TriggerShowdownFinally;
    /// <summary>
    /// Function: TriggerShowdownFinally
    /// </summary>
    public unsafe virtual void TriggerShowdownFinally()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerShowdownFinally, "BmGame.MPawnBossBaneTitanBase.TriggerShowdownFinally");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerShowdownBreakWall;
    /// <summary>
    /// Function: TriggerShowdownBreakWall
    /// </summary>
    public unsafe virtual void TriggerShowdownBreakWall()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerShowdownBreakWall, "BmGame.MPawnBossBaneTitanBase.TriggerShowdownBreakWall");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerShowdownThrow;
    /// <summary>
    /// Function: TriggerShowdownThrow
    /// </summary>
    public unsafe virtual void TriggerShowdownThrow()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerShowdownThrow, "BmGame.MPawnBossBaneTitanBase.TriggerShowdownThrow");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerShowdownVoiceOver;
    /// <summary>
    /// Function: TriggerShowdownVoiceOver
    /// </summary>
    public unsafe virtual void TriggerShowdownVoiceOver()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerShowdownVoiceOver, "BmGame.MPawnBossBaneTitanBase.TriggerShowdownVoiceOver");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerShowdownStart;
    /// <summary>
    /// Function: TriggerShowdownStart
    /// </summary>
    public unsafe virtual void TriggerShowdownStart()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerShowdownStart, "BmGame.MPawnBossBaneTitanBase.TriggerShowdownStart");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AlertToGadgetNoise;
    /// <summary>
    /// Function: AlertToGadgetNoise
    /// </summary>
    public unsafe virtual void AlertToGadgetNoise()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AlertToGadgetNoise, "BmGame.MPawnBossBaneTitanBase.AlertToGadgetNoise");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShortPauseThenAlertToGadgetNoise;
    /// <summary>
    /// Function: ShortPauseThenAlertToGadgetNoise
    /// </summary>
    public unsafe virtual void ShortPauseThenAlertToGadgetNoise()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShortPauseThenAlertToGadgetNoise, "BmGame.MPawnBossBaneTitanBase.ShortPauseThenAlertToGadgetNoise");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsLocationInVerticalRange;
    /// <summary>
    /// Function: IsLocationInVerticalRange
    /// </summary>
    public unsafe virtual bool IsLocationInVerticalRange(System.Numerics.Vector3 the_location, float limit_above, float limit_below)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLocationInVerticalRange, "BmGame.MPawnBossBaneTitanBase.IsLocationInVerticalRange");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_location, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(limit_above, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(limit_below, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_IsLocationInHorizontalWedge;
    /// <summary>
    /// Function: IsLocationInHorizontalWedge
    /// </summary>
    public unsafe virtual bool IsLocationInHorizontalWedge(System.Numerics.Vector3 the_location, float angle_either_side)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLocationInHorizontalWedge, "BmGame.MPawnBossBaneTitanBase.IsLocationInHorizontalWedge");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_location, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(angle_either_side, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_IsLocationInVerticalWedge;
    /// <summary>
    /// Function: IsLocationInVerticalWedge
    /// </summary>
    public unsafe virtual bool IsLocationInVerticalWedge(System.Numerics.Vector3 the_location, float angle_either_side)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLocationInVerticalWedge, "BmGame.MPawnBossBaneTitanBase.IsLocationInVerticalWedge");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_location, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(angle_either_side, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_IsBatmanEnteringTunnel;
    /// <summary>
    /// Function: IsBatmanEnteringTunnel
    /// </summary>
    public unsafe virtual bool IsBatmanEnteringTunnel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBatmanEnteringTunnel, "BmGame.MPawnBossBaneTitanBase.IsBatmanEnteringTunnel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearIsGettingOutOfVentOrGrate;
    /// <summary>
    /// Function: ClearIsGettingOutOfVentOrGrate
    /// </summary>
    public unsafe virtual void ClearIsGettingOutOfVentOrGrate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearIsGettingOutOfVentOrGrate, "BmGame.MPawnBossBaneTitanBase.ClearIsGettingOutOfVentOrGrate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyPlayerExitVent;
    /// <summary>
    /// Function: NotifyPlayerExitVent
    /// </summary>
    public unsafe virtual void NotifyPlayerExitVent(System.Numerics.Vector3 Position)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyPlayerExitVent, "BmGame.MPawnBossBaneTitanBase.NotifyPlayerExitVent");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearIsGettingInOfVentOrGrate;
    /// <summary>
    /// Function: ClearIsGettingInOfVentOrGrate
    /// </summary>
    public unsafe virtual void ClearIsGettingInOfVentOrGrate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearIsGettingInOfVentOrGrate, "BmGame.MPawnBossBaneTitanBase.ClearIsGettingInOfVentOrGrate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyPlayerEnterVent;
    /// <summary>
    /// Function: NotifyPlayerEnterVent
    /// </summary>
    public unsafe virtual void NotifyPlayerEnterVent(System.Numerics.Vector3 Position)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyPlayerEnterVent, "BmGame.MPawnBossBaneTitanBase.NotifyPlayerEnterVent");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOffVisualContact;
    /// <summary>
    /// Function: TurnOffVisualContact
    /// </summary>
    public unsafe virtual void TurnOffVisualContact()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffVisualContact, "BmGame.MPawnBossBaneTitanBase.TurnOffVisualContact");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LostVisualContact;
    /// <summary>
    /// Function: LostVisualContact
    /// </summary>
    public unsafe virtual void LostVisualContact()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LostVisualContact, "BmGame.MPawnBossBaneTitanBase.LostVisualContact");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GainedVisualContact;
    /// <summary>
    /// Function: GainedVisualContact
    /// </summary>
    public unsafe virtual void GainedVisualContact()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GainedVisualContact, "BmGame.MPawnBossBaneTitanBase.GainedVisualContact");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RefreshLastKnownPosition;
    /// <summary>
    /// Function: RefreshLastKnownPosition
    /// </summary>
    public unsafe virtual void RefreshLastKnownPosition()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RefreshLastKnownPosition, "BmGame.MPawnBossBaneTitanBase.RefreshLastKnownPosition");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPlayerInVent;
    /// <summary>
    /// Function: IsPlayerInVent
    /// </summary>
    public unsafe virtual bool IsPlayerInVent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPlayerInVent, "BmGame.MPawnBossBaneTitanBase.IsPlayerInVent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsPlayerInGrate;
    /// <summary>
    /// Function: IsPlayerInGrate
    /// </summary>
    public unsafe virtual bool IsPlayerInGrate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPlayerInGrate, "BmGame.MPawnBossBaneTitanBase.IsPlayerInGrate");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsWithinRange;
    /// <summary>
    /// Function: IsWithinRange
    /// </summary>
    public unsafe virtual bool IsWithinRange(float TargetRange)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsWithinRange, "BmGame.MPawnBossBaneTitanBase.IsWithinRange");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetRange, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CanSeeBatman;
    /// <summary>
    /// Function: CanSeeBatman
    /// </summary>
    public unsafe virtual bool CanSeeBatman(float minimum_proportion, bool ignore_view_wedge = default, bool ignore_slow_spot_timer = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSeeBatman, "BmGame.MPawnBossBaneTitanBase.CanSeeBatman");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(minimum_proportion, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ignore_view_wedge, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ignore_slow_spot_timer, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetGrateTarget;
    /// <summary>
    /// Function: GetGrateTarget
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetGrateTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGrateTarget, "BmGame.MPawnBossBaneTitanBase.GetGrateTarget");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DrawViewCone;
    /// <summary>
    /// Function: DrawViewCone
    /// </summary>
    public unsafe virtual void DrawViewCone(System.Numerics.Vector3 ConeOrigin, System.Numerics.Vector3 ConeDirection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawViewCone, "BmGame.MPawnBossBaneTitanBase.DrawViewCone");
        byte* paramsPtr = stackalloc byte[112];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConeOrigin, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConeDirection, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawDebugGraphics;
    /// <summary>
    /// Function: DrawDebugGraphics
    /// </summary>
    public unsafe override void DrawDebugGraphics()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugGraphics, "BmGame.MPawnBossBaneTitanBase.DrawDebugGraphics");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyFootprintDestroyed;
    /// <summary>
    /// Function: NotifyFootprintDestroyed
    /// </summary>
    public unsafe virtual void NotifyFootprintDestroyed(int footprint_creation_index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyFootprintDestroyed, "BmGame.MPawnBossBaneTitanBase.NotifyFootprintDestroyed");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(footprint_creation_index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckFluorescingFootprints;
    /// <summary>
    /// Function: CheckFluorescingFootprints
    /// </summary>
    public unsafe virtual void CheckFluorescingFootprints()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckFluorescingFootprints, "BmGame.MPawnBossBaneTitanBase.CheckFluorescingFootprints");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnVisibleFootprint;
    /// <summary>
    /// Function: SpawnVisibleFootprint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MBaneTitanPlaceableFootprintBase SpawnVisibleFootprint(System.Numerics.Vector3 PrintLocation, BmSDK.Rotator PrintRotation, int creation_index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnVisibleFootprint, "BmGame.MPawnBossBaneTitanBase.SpawnVisibleFootprint");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PrintLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PrintRotation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(creation_index, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MBaneTitanPlaceableFootprintBase>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_GetCurrentRailDirection;
    /// <summary>
    /// Function: GetCurrentRailDirection
    /// </summary>
    public unsafe virtual BmSDK.Rotator GetCurrentRailDirection(System.Numerics.Vector3 movement_direction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentRailDirection, "BmGame.MPawnBossBaneTitanBase.GetCurrentRailDirection");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(movement_direction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_PlaceFootprint;
    /// <summary>
    /// Function: PlaceFootprint
    /// </summary>
    public unsafe virtual void PlaceFootprint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaceFootprint, "BmGame.MPawnBossBaneTitanBase.PlaceFootprint");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAngleIncrease;
    /// <summary>
    /// Function: GetAngleIncrease
    /// </summary>
    public unsafe virtual float GetAngleIncrease(float current_angle, float next_angle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAngleIncrease, "BmGame.MPawnBossBaneTitanBase.GetAngleIncrease");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(current_angle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(next_angle, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetAngleToFootprint;
    /// <summary>
    /// Function: GetAngleToFootprint
    /// </summary>
    public unsafe virtual float GetAngleToFootprint(System.Numerics.Vector3 centre, System.Numerics.Vector3 footprint_loc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAngleToFootprint, "BmGame.MPawnBossBaneTitanBase.GetAngleToFootprint");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(centre, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(footprint_loc, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetFootprintCircleAngleTraversed;
    /// <summary>
    /// Function: GetFootprintCircleAngleTraversed
    /// </summary>
    public unsafe virtual float GetFootprintCircleAngleTraversed(int starting_print, int ending_print, out System.Numerics.Vector3 CircleCentre, out System.Numerics.Vector3 CircleBounds)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFootprintCircleAngleTraversed, "BmGame.MPawnBossBaneTitanBase.GetFootprintCircleAngleTraversed");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(starting_print, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ending_print, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CircleCentre);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CircleCentre, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CircleBounds);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CircleBounds, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CircleCentre = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
        CircleBounds = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_FindClosestFootprintLocationInRange;
    /// <summary>
    /// Function: FindClosestFootprintLocationInRange
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 FindClosestFootprintLocationInRange(System.Numerics.Vector3 target_position, int starting_print, int ending_print)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindClosestFootprintLocationInRange, "BmGame.MPawnBossBaneTitanBase.FindClosestFootprintLocationInRange");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(target_position, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(starting_print, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ending_print, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_IsSameCircleAsPrevious;
    /// <summary>
    /// Function: IsSameCircleAsPrevious
    /// </summary>
    public unsafe virtual bool IsSameCircleAsPrevious(int current_footprint, System.Numerics.Vector3 CircleCentre, System.Numerics.Vector3 CircleBounds)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSameCircleAsPrevious, "BmGame.MPawnBossBaneTitanBase.IsSameCircleAsPrevious");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(current_footprint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CircleCentre, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CircleBounds, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_AreFootprintsLeadingBaneInCircles;
    /// <summary>
    /// Function: AreFootprintsLeadingBaneInCircles
    /// </summary>
    public unsafe virtual bool AreFootprintsLeadingBaneInCircles(int current_footprint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreFootprintsLeadingBaneInCircles, "BmGame.MPawnBossBaneTitanBase.AreFootprintsLeadingBaneInCircles");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(current_footprint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetNextFootprintDirectionAfterXDist;
    /// <summary>
    /// Function: GetNextFootprintDirectionAfterXDist
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetNextFootprintDirectionAfterXDist(float fPastDistanceSq, out System.Numerics.Vector3 vFirstFootPrint, out System.Numerics.Vector3 vSecondFootprint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextFootprintDirectionAfterXDist, "BmGame.MPawnBossBaneTitanBase.GetNextFootprintDirectionAfterXDist");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fPastDistanceSq, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out vFirstFootPrint);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vFirstFootPrint, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out vSecondFootprint);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vSecondFootprint, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        vFirstFootPrint = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
        vSecondFootprint = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_GetYoungestFootprint;
    /// <summary>
    /// Function: GetYoungestFootprint
    /// </summary>
    public unsafe virtual int GetYoungestFootprint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetYoungestFootprint, "BmGame.MPawnBossBaneTitanBase.GetYoungestFootprint");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetYoungestFootprintInRange;
    /// <summary>
    /// Function: GetYoungestFootprintInRange
    /// </summary>
    public unsafe virtual int GetYoungestFootprintInRange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetYoungestFootprintInRange, "BmGame.MPawnBossBaneTitanBase.GetYoungestFootprintInRange");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsFootprintAboveGroundOrIsBaneAwareOfUnderground;
    /// <summary>
    /// Function: IsFootprintAboveGroundOrIsBaneAwareOfUnderground
    /// </summary>
    public unsafe virtual bool IsFootprintAboveGroundOrIsBaneAwareOfUnderground(int footprint_index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFootprintAboveGroundOrIsBaneAwareOfUnderground, "BmGame.MPawnBossBaneTitanBase.IsFootprintAboveGroundOrIsBaneAwareOfUnderground");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(footprint_index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HasLineOfSightToFootprint;
    /// <summary>
    /// Function: HasLineOfSightToFootprint
    /// </summary>
    public unsafe virtual bool HasLineOfSightToFootprint(int footprint_index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasLineOfSightToFootprint, "BmGame.MPawnBossBaneTitanBase.HasLineOfSightToFootprint");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(footprint_index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsFootprintInRange;
    /// <summary>
    /// Function: IsFootprintInRange
    /// </summary>
    public unsafe virtual bool IsFootprintInRange(int footprint_index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFootprintInRange, "BmGame.MPawnBossBaneTitanBase.IsFootprintInRange");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(footprint_index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetFootprintCreationIndex;
    /// <summary>
    /// Function: GetFootprintCreationIndex
    /// </summary>
    public unsafe virtual int GetFootprintCreationIndex(int footprint_index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFootprintCreationIndex, "BmGame.MPawnBossBaneTitanBase.GetFootprintCreationIndex");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(footprint_index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetFootprintAge;
    /// <summary>
    /// Function: GetFootprintAge
    /// </summary>
    public unsafe virtual float GetFootprintAge(int footprint_index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFootprintAge, "BmGame.MPawnBossBaneTitanBase.GetFootprintAge");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(footprint_index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetFootprintTimestamp;
    /// <summary>
    /// Function: GetFootprintTimestamp
    /// </summary>
    public unsafe virtual float GetFootprintTimestamp(int footprint_index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFootprintTimestamp, "BmGame.MPawnBossBaneTitanBase.GetFootprintTimestamp");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(footprint_index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetFootprintLocation;
    /// <summary>
    /// Function: GetFootprintLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetFootprintLocation(int footprint_index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFootprintLocation, "BmGame.MPawnBossBaneTitanBase.GetFootprintLocation");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(footprint_index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetFootprintColour;
    /// <summary>
    /// Function: GetFootprintColour
    /// </summary>
    public unsafe virtual int GetFootprintColour(int footprint_index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFootprintColour, "BmGame.MPawnBossBaneTitanBase.GetFootprintColour");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(footprint_index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TickFootprints;
    /// <summary>
    /// Function: TickFootprints
    /// </summary>
    public unsafe virtual void TickFootprints(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickFootprints, "BmGame.MPawnBossBaneTitanBase.TickFootprints");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyHarpoonHit;
    /// <summary>
    /// Function: NotifyHarpoonHit
    /// </summary>
    public unsafe virtual void NotifyHarpoonHit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyHarpoonHit, "BmGame.MPawnBossBaneTitanBase.NotifyHarpoonHit");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnBatclawCounter;
    /// <summary>
    /// Function: SpawnBatclawCounter
    /// </summary>
    public unsafe virtual void SpawnBatclawCounter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnBatclawCounter, "BmGame.MPawnBossBaneTitanBase.SpawnBatclawCounter");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldUpdateCombatPP;
    /// <summary>
    /// Function: ShouldUpdateCombatPP
    /// </summary>
    public unsafe virtual bool ShouldUpdateCombatPP()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldUpdateCombatPP, "BmGame.MPawnBossBaneTitanBase.ShouldUpdateCombatPP");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DeactivateChaseCam;
    /// <summary>
    /// Function: DeactivateChaseCam
    /// </summary>
    public unsafe virtual void DeactivateChaseCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeactivateChaseCam, "BmGame.MPawnBossBaneTitanBase.DeactivateChaseCam");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateHealthBar, "BmGame.MPawnBossBaneTitanBase.UpdateHealthBar");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateChaseCam;
    /// <summary>
    /// Function: ActivateChaseCam
    /// </summary>
    public unsafe virtual void ActivateChaseCam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateChaseCam, "BmGame.MPawnBossBaneTitanBase.ActivateChaseCam");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IgnoreDetectiveModeCamChange;
    /// <summary>
    /// Function: IgnoreDetectiveModeCamChange
    /// </summary>
    public unsafe virtual bool IgnoreDetectiveModeCamChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IgnoreDetectiveModeCamChange, "BmGame.MPawnBossBaneTitanBase.IgnoreDetectiveModeCamChange");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_BeginTrapTakedown;
    /// <summary>
    /// Function: BeginTrapTakedown
    /// </summary>
    public unsafe virtual void BeginTrapTakedown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginTrapTakedown, "BmGame.MPawnBossBaneTitanBase.BeginTrapTakedown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsVulnerableToTakedown;
    /// <summary>
    /// Function: IsVulnerableToTakedown
    /// </summary>
    public unsafe override bool IsVulnerableToTakedown(BmSDK.FString takedown)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsVulnerableToTakedown, "BmGame.MPawnBossBaneTitanBase.IsVulnerableToTakedown");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takedown, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetBossTakedown;
    /// <summary>
    /// Function: GetBossTakedown
    /// </summary>
    public unsafe override BmSDK.Class GetBossTakedown(BmSDK.BmGame.MStealthTakeDownStagePlayerConfig.EStealthTakeDownStages takedown_stage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBossTakedown, "BmGame.MPawnBossBaneTitanBase.GetBossTakedown");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takedown_stage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ElectricFloorHit;
    /// <summary>
    /// Function: ElectricFloorHit
    /// </summary>
    public unsafe virtual void ElectricFloorHit(BmSDK.BmGame.RElectrifiedFloorPanel electricFloor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ElectricFloorHit, "BmGame.MPawnBossBaneTitanBase.ElectricFloorHit");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(electricFloor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerHitByObject;
    /// <summary>
    /// Function: PlayerHitByObject
    /// </summary>
    public unsafe virtual void PlayerHitByObject()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerHitByObject, "BmGame.MPawnBossBaneTitanBase.PlayerHitByObject");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AlertToBrokenGlassSound;
    /// <summary>
    /// Function: AlertToBrokenGlassSound
    /// </summary>
    public unsafe virtual void AlertToBrokenGlassSound(System.Numerics.Vector3 BreakageLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AlertToBrokenGlassSound, "BmGame.MPawnBossBaneTitanBase.AlertToBrokenGlassSound");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BreakageLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KickedByBatman;
    /// <summary>
    /// Function: KickedByBatman
    /// </summary>
    public unsafe virtual void KickedByBatman(System.Numerics.Vector3 batman_origin)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KickedByBatman, "BmGame.MPawnBossBaneTitanBase.KickedByBatman");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(batman_origin, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerGlideKick;
    /// <summary>
    /// Function: TriggerGlideKick
    /// </summary>
    public unsafe virtual void TriggerGlideKick(System.Numerics.Vector3 PlayerOrigin)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerGlideKick, "BmGame.MPawnBossBaneTitanBase.TriggerGlideKick");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerOrigin, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldBeInCombatStance;
    /// <summary>
    /// Function: ShouldBeInCombatStance
    /// </summary>
    public unsafe virtual bool ShouldBeInCombatStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldBeInCombatStance, "BmGame.MPawnBossBaneTitanBase.ShouldBeInCombatStance");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PostInitCharacter;
    /// <summary>
    /// Function: PostInitCharacter
    /// </summary>
    public unsafe override void PostInitCharacter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostInitCharacter, "BmGame.MPawnBossBaneTitanBase.PostInitCharacter");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsAwareOfPlayer;
    /// <summary>
    /// Function: IsAwareOfPlayer
    /// </summary>
    public unsafe override bool IsAwareOfPlayer(BmSDK.BmGame.RPawnPlayer aPlayerPawn, BmSDK.Class dmgType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAwareOfPlayer, "BmGame.MPawnBossBaneTitanBase.IsAwareOfPlayer");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aPlayerPawn, paramsPtr + 0);
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

    /// <summary>
    /// Struct: FFootprint
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public partial record struct FFootprint
    {
        /// <summary>
        /// StructProperty: Location
        /// </summary>
        public unsafe System.Numerics.Vector3 Location
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: TimeStamp
        /// </summary>
        public unsafe float TimeStamp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: FootprintCreationIndex
        /// </summary>
        public unsafe int FootprintCreationIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ObjectProperty: PlacedStep
        /// </summary>
        public unsafe BmSDK.BmGame.MBaneTitanPlaceableFootprintBase PlacedStep
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MBaneTitanPlaceableFootprintBase>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// BoolProperty: CanBeDisplayed
        /// </summary>
        public unsafe bool CanBeDisplayed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }

        /// <summary>
        /// BoolProperty: IsUnderGrate
        /// </summary>
        public unsafe bool IsUnderGrate
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: PrintSpawnLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 PrintSpawnLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// StructProperty: PrintSpawnRotation
        /// </summary>
        public unsafe BmSDK.Rotator PrintSpawnRotation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// IntProperty: iHitsLanded
    /// </summary>
    public unsafe int iHitsLanded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4000); }
    }

    /// <summary>
    /// IntProperty: iInitialHealth
    /// </summary>
    public unsafe int iInitialHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4004); }
    }

    /// <summary>
    /// IntProperty: StrikesBeforeFinal
    /// </summary>
    public unsafe int StrikesBeforeFinal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4008); }
    }

    /// <summary>
    /// FloatProperty: MaxPatrolTime
    /// </summary>
    public unsafe float MaxPatrolTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4012); }
    }

    /// <summary>
    /// FloatProperty: MinTimeBeforeReusingSamePOI
    /// </summary>
    public unsafe float MinTimeBeforeReusingSamePOI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4016); }
    }

    /// <summary>
    /// FloatProperty: InvestigationTime
    /// </summary>
    public unsafe float InvestigationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4020); }
    }

    /// <summary>
    /// FloatProperty: POIInvestigationMinDistance
    /// </summary>
    public unsafe float POIInvestigationMinDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4024); }
    }

    /// <summary>
    /// FloatProperty: POIInvestigationMaxDistance
    /// </summary>
    public unsafe float POIInvestigationMaxDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4028); }
    }

    /// <summary>
    /// FloatProperty: InitialHealth
    /// </summary>
    public unsafe float InitialHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4032); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: EscalationStageHealth
    /// </summary>
    public InlineArray<float> EscalationStageHealth => new(3, Ptr + 4036, 4, this);

    /// <summary>
    /// FloatProperty: EscalationStageHealth
    /// </summary>
    public unsafe float EscalationStageHealth_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4036); }
    }
    /// <summary>
    /// FloatProperty: EscalationStageHealth
    /// </summary>
    public unsafe float EscalationStageHealth_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4040); }
    }
    /// <summary>
    /// FloatProperty: EscalationStageHealth
    /// </summary>
    public unsafe float EscalationStageHealth_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4044); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: NumBeatdownHitRequiredPerStage
    /// </summary>
    public InlineArray<int> NumBeatdownHitRequiredPerStage => new(3, Ptr + 4048, 4, this);

    /// <summary>
    /// IntProperty: NumBeatdownHitRequiredPerStage
    /// </summary>
    public unsafe int NumBeatdownHitRequiredPerStage_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4048); }
    }
    /// <summary>
    /// IntProperty: NumBeatdownHitRequiredPerStage
    /// </summary>
    public unsafe int NumBeatdownHitRequiredPerStage_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4052); }
    }
    /// <summary>
    /// IntProperty: NumBeatdownHitRequiredPerStage
    /// </summary>
    public unsafe int NumBeatdownHitRequiredPerStage_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4056); }
    }

    /// <summary>
    /// FloatProperty: ShowdownHPThreshold
    /// </summary>
    public unsafe float ShowdownHPThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4060); }
    }

    /// <summary>
    /// FloatProperty: BeatdownPunchDamage
    /// </summary>
    public unsafe float BeatdownPunchDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4064); }
    }

    /// <summary>
    /// FloatProperty: BeatdownLastPunchDamage
    /// </summary>
    public unsafe float BeatdownLastPunchDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4068); }
    }

    /// <summary>
    /// FloatProperty: TakedownDamage
    /// </summary>
    public unsafe float TakedownDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4072); }
    }

    /// <summary>
    /// FloatProperty: MinTimeBetweenAttacks
    /// </summary>
    public unsafe float MinTimeBetweenAttacks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4076); }
    }

    /// <summary>
    /// FloatProperty: MinDistanceToPlayer
    /// </summary>
    public unsafe float MinDistanceToPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4080); }
    }

    /// <summary>
    /// FloatProperty: MaxDistanceForRangeAttackToTrackPlayer
    /// </summary>
    public unsafe float MaxDistanceForRangeAttackToTrackPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4084); }
    }

    /// <summary>
    /// FloatProperty: TimeBeforeLookingForPlayerAfterLostHim
    /// </summary>
    public unsafe float TimeBeforeLookingForPlayerAfterLostHim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4088); }
    }

    /// <summary>
    /// FloatProperty: DistanceToWalkFromRunning
    /// </summary>
    public unsafe float DistanceToWalkFromRunning
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4092); }
    }

    /// <summary>
    /// FloatProperty: DistanceBehindToTurnAround
    /// </summary>
    public unsafe float DistanceBehindToTurnAround
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4096); }
    }

    /// <summary>
    /// FloatProperty: DistanceToHearGrateDoor
    /// </summary>
    public unsafe float DistanceToHearGrateDoor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4100); }
    }

    /// <summary>
    /// FloatProperty: TimeBeforeTurnAroundWhenPlayerStandBehind
    /// </summary>
    public unsafe float TimeBeforeTurnAroundWhenPlayerStandBehind
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4104); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: NumPoIsNeededToTurnBackPerStage
    /// </summary>
    public InlineArray<int> NumPoIsNeededToTurnBackPerStage => new(3, Ptr + 4108, 4, this);

    /// <summary>
    /// IntProperty: NumPoIsNeededToTurnBackPerStage
    /// </summary>
    public unsafe int NumPoIsNeededToTurnBackPerStage_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4108); }
    }
    /// <summary>
    /// IntProperty: NumPoIsNeededToTurnBackPerStage
    /// </summary>
    public unsafe int NumPoIsNeededToTurnBackPerStage_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4112); }
    }
    /// <summary>
    /// IntProperty: NumPoIsNeededToTurnBackPerStage
    /// </summary>
    public unsafe int NumPoIsNeededToTurnBackPerStage_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4116); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: TimeForBaneToLookBackBetween2PoIsPerStage
    /// </summary>
    public InlineArray<float> TimeForBaneToLookBackBetween2PoIsPerStage => new(3, Ptr + 4120, 4, this);

    /// <summary>
    /// FloatProperty: TimeForBaneToLookBackBetween2PoIsPerStage
    /// </summary>
    public unsafe float TimeForBaneToLookBackBetween2PoIsPerStage_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4120); }
    }
    /// <summary>
    /// FloatProperty: TimeForBaneToLookBackBetween2PoIsPerStage
    /// </summary>
    public unsafe float TimeForBaneToLookBackBetween2PoIsPerStage_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4124); }
    }
    /// <summary>
    /// FloatProperty: TimeForBaneToLookBackBetween2PoIsPerStage
    /// </summary>
    public unsafe float TimeForBaneToLookBackBetween2PoIsPerStage_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4128); }
    }

    /// <summary>
    /// FloatProperty: BodycheckFloorHitDamage
    /// </summary>
    public unsafe float BodycheckFloorHitDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4132); }
    }

    /// <summary>
    /// FloatProperty: BodycheckWallHitDamage
    /// </summary>
    public unsafe float BodycheckWallHitDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4136); }
    }

    /// <summary>
    /// FloatProperty: CloseAttackRange
    /// </summary>
    public unsafe float CloseAttackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4140); }
    }

    /// <summary>
    /// FloatProperty: FarAttackRange
    /// </summary>
    public unsafe float FarAttackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4144); }
    }

    /// <summary>
    /// FloatProperty: MeleeDamage
    /// </summary>
    public unsafe float MeleeDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4148); }
    }

    /// <summary>
    /// FloatProperty: ShockwaveActiveTime
    /// </summary>
    public unsafe float ShockwaveActiveTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4152); }
    }

    /// <summary>
    /// FloatProperty: ShockwaveDamageRange
    /// </summary>
    public unsafe float ShockwaveDamageRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4156); }
    }

    /// <summary>
    /// FloatProperty: RadiusToJumpAttackGargoyle
    /// </summary>
    public unsafe float RadiusToJumpAttackGargoyle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4160); }
    }

    /// <summary>
    /// FloatProperty: ChaseCamDistance
    /// </summary>
    public unsafe float ChaseCamDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4164); }
    }

    /// <summary>
    /// FloatProperty: ChaseCamDefaultPitch
    /// </summary>
    public unsafe float ChaseCamDefaultPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4168); }
    }

    /// <summary>
    /// FloatProperty: ChaseCamMaxYaw
    /// </summary>
    public unsafe float ChaseCamMaxYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4172); }
    }

    /// <summary>
    /// StructProperty: ChaseAttackCamMinOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ChaseAttackCamMinOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4176);

    /// <summary>
    /// StructProperty: ChaseAttackCamMaxOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ChaseAttackCamMaxOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4188);

    /// <summary>
    /// FloatProperty: ChaseAttackCamDefaultPitch
    /// </summary>
    public unsafe float ChaseAttackCamDefaultPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4200); }
    }

    /// <summary>
    /// FloatProperty: ChaseAttackCamTransitionTime
    /// </summary>
    public unsafe float ChaseAttackCamTransitionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4204); }
    }

    /// <summary>
    /// FloatProperty: ChaseAttackCamFOV
    /// </summary>
    public unsafe float ChaseAttackCamFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4208); }
    }

    /// <summary>
    /// FloatProperty: PreviousMaxYaw
    /// </summary>
    public unsafe float PreviousMaxYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4212); }
    }

    /// <summary>
    /// FloatProperty: GlueGrenadeTorsoTime
    /// </summary>
    public unsafe float GlueGrenadeTorsoTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4216); }
    }

    /// <summary>
    /// FloatProperty: GlueGrenadeLegsTime
    /// </summary>
    public unsafe float GlueGrenadeLegsTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4220); }
    }

    /// <summary>
    /// FloatProperty: fHearingRangeForGadgetNoise
    /// </summary>
    public unsafe float fHearingRangeForGadgetNoise
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4224); }
    }

    /// <summary>
    /// FloatProperty: NoiseRangeToTriggerTrapPatrol
    /// </summary>
    public unsafe float NoiseRangeToTriggerTrapPatrol
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4228); }
    }

    /// <summary>
    /// FloatProperty: FootStepMinRumble
    /// </summary>
    public unsafe float FootStepMinRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4232); }
    }

    /// <summary>
    /// FloatProperty: FootStepMaxRumble
    /// </summary>
    public unsafe float FootStepMaxRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4236); }
    }

    /// <summary>
    /// FloatProperty: FootStepMinTime
    /// </summary>
    public unsafe float FootStepMinTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4240); }
    }

    /// <summary>
    /// FloatProperty: FootStepMaxTime
    /// </summary>
    public unsafe float FootStepMaxTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4244); }
    }

    /// <summary>
    /// FloatProperty: FootStepRangeMax
    /// </summary>
    public unsafe float FootStepRangeMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4248); }
    }

    /// <summary>
    /// FloatProperty: TrapTakedownLocMaxDist
    /// </summary>
    public unsafe float TrapTakedownLocMaxDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4252); }
    }

    /// <summary>
    /// FloatProperty: VentAttackMaxDistance
    /// </summary>
    public unsafe float VentAttackMaxDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4256); }
    }

    /// <summary>
    /// FloatProperty: GrateAttackMaxDistance
    /// </summary>
    public unsafe float GrateAttackMaxDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4260); }
    }

    /// <summary>
    /// ArrayProperty: BossShowdownSteps
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSpecialMoveConfig> BossShowdownSteps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSpecialMoveConfig>>(Ptr + 4264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4264); }
    }

    /// <summary>
    /// ObjectProperty: BossShowdownStart
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig BossShowdownStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 4276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4276); }
    }

    /// <summary>
    /// IntProperty: InvestigationAlignmentBonus
    /// </summary>
    public unsafe int InvestigationAlignmentBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4280); }
    }

    /// <summary>
    /// FloatProperty: fWedgeAngleForSeeBatman
    /// </summary>
    public unsafe float fWedgeAngleForSeeBatman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4284); }
    }

    /// <summary>
    /// FloatProperty: fVerticalWedgeAngleForSeeBatman
    /// </summary>
    public unsafe float fVerticalWedgeAngleForSeeBatman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4288); }
    }

    /// <summary>
    /// FloatProperty: fTakedownRadius
    /// </summary>
    public unsafe float fTakedownRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4292); }
    }

    /// <summary>
    /// FloatProperty: fTakedownRadiusCornerCover
    /// </summary>
    public unsafe float fTakedownRadiusCornerCover
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4296); }
    }

    /// <summary>
    /// FloatProperty: SmokeCoverValuePercent
    /// </summary>
    public unsafe float SmokeCoverValuePercent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4300); }
    }

    /// <summary>
    /// FloatProperty: HiddenTimeBeforeTaunt
    /// </summary>
    public unsafe float HiddenTimeBeforeTaunt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4304); }
    }

    /// <summary>
    /// FloatProperty: HiddenTimeBeforeHint
    /// </summary>
    public unsafe float HiddenTimeBeforeHint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4308); }
    }

    /// <summary>
    /// FloatProperty: ChanceToPlayPrisonerBarkUponHiding
    /// </summary>
    public unsafe float ChanceToPlayPrisonerBarkUponHiding
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4312); }
    }

    /// <summary>
    /// FloatProperty: SecondsForPrisonerRandomBark
    /// </summary>
    public unsafe float SecondsForPrisonerRandomBark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4316); }
    }

    /// <summary>
    /// FloatProperty: SearchGrateProbabilityBark
    /// </summary>
    public unsafe float SearchGrateProbabilityBark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4320); }
    }

    /// <summary>
    /// FloatProperty: BMHideHintProbabilityBark
    /// </summary>
    public unsafe float BMHideHintProbabilityBark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4324); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: EyesFXOpacityPerPhase
    /// </summary>
    public InlineArray<float> EyesFXOpacityPerPhase => new(3, Ptr + 4328, 4, this);

    /// <summary>
    /// FloatProperty: EyesFXOpacityPerPhase
    /// </summary>
    public unsafe float EyesFXOpacityPerPhase_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4328); }
    }
    /// <summary>
    /// FloatProperty: EyesFXOpacityPerPhase
    /// </summary>
    public unsafe float EyesFXOpacityPerPhase_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4332); }
    }
    /// <summary>
    /// FloatProperty: EyesFXOpacityPerPhase
    /// </summary>
    public unsafe float EyesFXOpacityPerPhase_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4336); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: ChestFXOpacityPerPhase
    /// </summary>
    public InlineArray<float> ChestFXOpacityPerPhase => new(3, Ptr + 4340, 4, this);

    /// <summary>
    /// FloatProperty: ChestFXOpacityPerPhase
    /// </summary>
    public unsafe float ChestFXOpacityPerPhase_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4340); }
    }
    /// <summary>
    /// FloatProperty: ChestFXOpacityPerPhase
    /// </summary>
    public unsafe float ChestFXOpacityPerPhase_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4344); }
    }
    /// <summary>
    /// FloatProperty: ChestFXOpacityPerPhase
    /// </summary>
    public unsafe float ChestFXOpacityPerPhase_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4348); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: PipesFXOpacityPerPhase
    /// </summary>
    public InlineArray<float> PipesFXOpacityPerPhase => new(3, Ptr + 4352, 4, this);

    /// <summary>
    /// FloatProperty: PipesFXOpacityPerPhase
    /// </summary>
    public unsafe float PipesFXOpacityPerPhase_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4352); }
    }
    /// <summary>
    /// FloatProperty: PipesFXOpacityPerPhase
    /// </summary>
    public unsafe float PipesFXOpacityPerPhase_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4356); }
    }
    /// <summary>
    /// FloatProperty: PipesFXOpacityPerPhase
    /// </summary>
    public unsafe float PipesFXOpacityPerPhase_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4360); }
    }

    /// <summary>
    /// IntProperty: CurrentShowdownStep
    /// </summary>
    public unsafe int CurrentShowdownStep
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4364); }
    }

    /// <summary>
    /// IntProperty: TrapLeft
    /// </summary>
    public unsafe int TrapLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4368); }
    }

    /// <summary>
    /// StructProperty: vLastKnownPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 vLastKnownPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4372);

    /// <summary>
    /// BoolProperty: bHasVisualContact
    /// </summary>
    public unsafe bool bHasVisualContact
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4384) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4384); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4384); }
    }

    /// <summary>
    /// BoolProperty: NearATrap
    /// </summary>
    public unsafe bool NearATrap
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4384) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4384); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4384); }
    }

    /// <summary>
    /// BoolProperty: IsGettingOutOfVentOrGrate
    /// </summary>
    public unsafe bool IsGettingOutOfVentOrGrate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4384) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4384); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4384); }
    }

    /// <summary>
    /// BoolProperty: IsGettingInOfVentOrGrate
    /// </summary>
    public unsafe bool IsGettingInOfVentOrGrate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4384) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4384); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4384); }
    }

    /// <summary>
    /// BoolProperty: NextFootprintCanBeConsideredContinuous
    /// </summary>
    public unsafe bool NextFootprintCanBeConsideredContinuous
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4384) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4384); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4384); }
    }

    /// <summary>
    /// BoolProperty: bFootprintCheatUsed
    /// </summary>
    public unsafe bool bFootprintCheatUsed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4384) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4384); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4384); }
    }

    /// <summary>
    /// BoolProperty: bBaneThinksBatmanIsUnderground
    /// </summary>
    public unsafe bool bBaneThinksBatmanIsUnderground
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4384) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4384); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4384); }
    }

    /// <summary>
    /// BoolProperty: bCanFight
    /// </summary>
    public unsafe bool bCanFight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4384) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4384); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4384); }
    }

    /// <summary>
    /// BoolProperty: BaneIsLookingIntoTrap
    /// </summary>
    public unsafe bool BaneIsLookingIntoTrap
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4384) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4384); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4384); }
    }

    /// <summary>
    /// BoolProperty: BaneSawPlayerEnteringVent
    /// </summary>
    public unsafe bool BaneSawPlayerEnteringVent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4384) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4384); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4384); }
    }

    /// <summary>
    /// BoolProperty: bShowdownEnded
    /// </summary>
    public unsafe bool bShowdownEnded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4384) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4384); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4384); }
    }

    /// <summary>
    /// ArrayProperty: BaneTitanTakeDowns
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> BaneTitanTakeDowns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 4388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4388); }
    }

    /// <summary>
    /// FloatProperty: fTimeSinceFootprintPlaced
    /// </summary>
    public unsafe float fTimeSinceFootprintPlaced
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4400); }
    }

    /// <summary>
    /// FloatProperty: FootPrintUnderGratePlusZ
    /// </summary>
    public unsafe float FootPrintUnderGratePlusZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4404); }
    }

    /// <summary>
    /// ArrayProperty: aFootprints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MPawnBossBaneTitanBase.FFootprint> aFootprints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MPawnBossBaneTitanBase.FFootprint>>(Ptr + 4408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4408); }
    }

    /// <summary>
    /// IntProperty: FootprintCreationIndexCounter
    /// </summary>
    public unsafe int FootprintCreationIndexCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4420); }
    }

    /// <summary>
    /// IntProperty: CurrentFootprintCreationIndex
    /// </summary>
    public unsafe int CurrentFootprintCreationIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4424); }
    }

    /// <summary>
    /// StructProperty: LastVisibleFootprintLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastVisibleFootprintLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4428);

    /// <summary>
    /// FloatProperty: fFootprintPlacementPeriod
    /// </summary>
    public unsafe float fFootprintPlacementPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4440); }
    }

    /// <summary>
    /// FloatProperty: fFootprintLifetime
    /// </summary>
    public unsafe float fFootprintLifetime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4444); }
    }

    /// <summary>
    /// FloatProperty: fFootprintDetectionRadius
    /// </summary>
    public unsafe float fFootprintDetectionRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4448); }
    }

    /// <summary>
    /// FloatProperty: fFootprintDetectionRadiusLongRange
    /// </summary>
    public unsafe float fFootprintDetectionRadiusLongRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4452); }
    }

    /// <summary>
    /// FloatProperty: fFootprintDetectionCheatVerticalRange
    /// </summary>
    public unsafe float fFootprintDetectionCheatVerticalRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4456); }
    }

    /// <summary>
    /// StructProperty: vFootprintCircleCentre
    /// </summary>
    public unsafe ref System.Numerics.Vector3 vFootprintCircleCentre
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4460);

    /// <summary>
    /// FloatProperty: fFootprintCircleRadiusSquared
    /// </summary>
    public unsafe float fFootprintCircleRadiusSquared
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4472); }
    }

    /// <summary>
    /// FloatProperty: fFootprintCirclePreviousTimestamp
    /// </summary>
    public unsafe float fFootprintCirclePreviousTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4476); }
    }

    /// <summary>
    /// FloatProperty: fFootprintCirclePreviousBaneAngle
    /// </summary>
    public unsafe float fFootprintCirclePreviousBaneAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4480); }
    }

    /// <summary>
    /// FloatProperty: fFootprintCircleTotalBaneAngle
    /// </summary>
    public unsafe float fFootprintCircleTotalBaneAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4484); }
    }

    /// <summary>
    /// FloatProperty: fCircularTrailDetectedCountdown
    /// </summary>
    public unsafe float fCircularTrailDetectedCountdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4488); }
    }

    /// <summary>
    /// StructProperty: vCircularTrailPredictedPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 vCircularTrailPredictedPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4492);

    /// <summary>
    /// FloatProperty: fWedgeAngleForFootprints
    /// </summary>
    public unsafe float fWedgeAngleForFootprints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4504); }
    }

    /// <summary>
    /// FloatProperty: fWedgeAngleForFootprintsLongRange
    /// </summary>
    public unsafe float fWedgeAngleForFootprintsLongRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4508); }
    }

    /// <summary>
    /// FloatProperty: fViewRangeFromWhichToLimitAboveAndBelow
    /// </summary>
    public unsafe float fViewRangeFromWhichToLimitAboveAndBelow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4512); }
    }

    /// <summary>
    /// FloatProperty: fViewRangeLimitAbove
    /// </summary>
    public unsafe float fViewRangeLimitAbove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4516); }
    }

    /// <summary>
    /// FloatProperty: fViewRangeLimitBelow
    /// </summary>
    public unsafe float fViewRangeLimitBelow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4520); }
    }

    /// <summary>
    /// FloatProperty: fLastKnownPositionTimeStamp
    /// </summary>
    public unsafe float fLastKnownPositionTimeStamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4524); }
    }

    /// <summary>
    /// FloatProperty: fCurrentTargetTimeStamp
    /// </summary>
    public unsafe float fCurrentTargetTimeStamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4528); }
    }

    /// <summary>
    /// FloatProperty: fVisionRange
    /// </summary>
    public unsafe float fVisionRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4532); }
    }

    /// <summary>
    /// FloatProperty: fVisionRangeForSlowSpot
    /// </summary>
    public unsafe float fVisionRangeForSlowSpot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4536); }
    }

    /// <summary>
    /// FloatProperty: fSlowSpotTimer
    /// </summary>
    public unsafe float fSlowSpotTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4540); }
    }

    /// <summary>
    /// FloatProperty: fSlowSpotPeriod
    /// </summary>
    public unsafe float fSlowSpotPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4544); }
    }

    /// <summary>
    /// FloatProperty: fBatmanEntersVentTimestamp
    /// </summary>
    public unsafe float fBatmanEntersVentTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4548); }
    }

    /// <summary>
    /// ObjectProperty: PlayerPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer PlayerPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 4552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4552); }
    }

    /// <summary>
    /// ObjectProperty: PC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController PC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 4556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4556); }
    }

    /// <summary>
    /// ObjectProperty: ShockLightVolume
    /// </summary>
    public unsafe BmSDK.BmGame.MFogVolume ShockLightVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MFogVolume>(Ptr + 4560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4560); }
    }

    /// <summary>
    /// ClassProperty: ShockLightVolumeClass
    /// </summary>
    public unsafe BmSDK.Class ShockLightVolumeClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4564); }
    }

    /// <summary>
    /// StructProperty: PlayerEnteringVentPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PlayerEnteringVentPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4568);

    /// <summary>
    /// FloatProperty: fTimeSinceLastPoI
    /// </summary>
    public unsafe float fTimeSinceLastPoI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4580); }
    }

    /// <summary>
    /// ObjectProperty: BaneFlashPP
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstance BaneFlashPP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstance>(Ptr + 4584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4584); }
    }

    /// <summary>
    /// ObjectProperty: BaneVeinsMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant BaneVeinsMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4588); }
    }

    /// <summary>
    /// ObjectProperty: BanePipesMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant BanePipesMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4592); }
    }

    /// <summary>
    /// ObjectProperty: BaneEyesMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant BaneEyesMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4596); }
    }

    /// <summary>
    /// ObjectProperty: BaneHeadMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant BaneHeadMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4600); }
    }

    /// <summary>
    /// StructProperty: CurrWallForce
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrWallForce
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4604);

    /// <summary>
    /// IntProperty: WallSideCount
    /// </summary>
    public unsafe int WallSideCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4616); }
    }
}
