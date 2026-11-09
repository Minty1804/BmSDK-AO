#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: MPawnVillain_FundamentalGrenadeGadget<br/>
/// (size = 88)
/// (flags = 134217875)
/// </summary>
public partial class MPawnVillain_FundamentalGrenadeGadget : BmSDK.Component, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MPawnVillain_FundamentalGrenadeGadget", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MPawnVillain_FundamentalGrenadeGadget.
    /// </summary>
    public static MPawnVillain_FundamentalGrenadeGadget DefaultObject => (MPawnVillain_FundamentalGrenadeGadget)StaticClass().DefaultObject;

    internal MPawnVillain_FundamentalGrenadeGadget() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MPawnVillain_FundamentalGrenadeGadget(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillain_FundamentalGrenadeGadget>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillain_FundamentalGrenadeGadget>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillain_FundamentalGrenadeGadget>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillain_FundamentalGrenadeGadget>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillain_FundamentalGrenadeGadget>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillain_FundamentalGrenadeGadget>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillain_FundamentalGrenadeGadget>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillain_FundamentalGrenadeGadget>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetSockTimeMultiplier;
    /// <summary>
    /// Function: SetSockTimeMultiplier
    /// </summary>
    public unsafe virtual void SetSockTimeMultiplier(float NewMultiplier)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSockTimeMultiplier, "BmGame.MPawnVillain_FundamentalGrenadeGadget.SetSockTimeMultiplier");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMultiplier, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetLegTime;
    /// <summary>
    /// Function: GetLegTime
    /// </summary>
    public unsafe virtual float GetLegTime(BmSDK.BmGame.RPawnPlayer Instigator)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLegTime, "BmGame.MPawnVillain_FundamentalGrenadeGadget.GetLegTime");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Instigator, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetTorsoTime;
    /// <summary>
    /// Function: GetTorsoTime
    /// </summary>
    public unsafe virtual float GetTorsoTime(BmSDK.BmGame.RPawnPlayer Instigator)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTorsoTime, "BmGame.MPawnVillain_FundamentalGrenadeGadget.GetTorsoTime");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Instigator, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_StopTorsoEffect;
    /// <summary>
    /// Function: StopTorsoEffect
    /// </summary>
    public unsafe virtual void StopTorsoEffect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopTorsoEffect, "BmGame.MPawnVillain_FundamentalGrenadeGadget.StopTorsoEffect");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartTorsoEffect;
    /// <summary>
    /// Function: StartTorsoEffect
    /// </summary>
    public unsafe virtual void StartTorsoEffect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartTorsoEffect, "BmGame.MPawnVillain_FundamentalGrenadeGadget.StartTorsoEffect");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopLegEffect;
    /// <summary>
    /// Function: StopLegEffect
    /// </summary>
    public unsafe virtual void StopLegEffect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopLegEffect, "BmGame.MPawnVillain_FundamentalGrenadeGadget.StopLegEffect");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopLeftLegEffect;
    /// <summary>
    /// Function: StopLeftLegEffect
    /// </summary>
    public unsafe virtual void StopLeftLegEffect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopLeftLegEffect, "BmGame.MPawnVillain_FundamentalGrenadeGadget.StopLeftLegEffect");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopRightLegEffect;
    /// <summary>
    /// Function: StopRightLegEffect
    /// </summary>
    public unsafe virtual void StopRightLegEffect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopRightLegEffect, "BmGame.MPawnVillain_FundamentalGrenadeGadget.StopRightLegEffect");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartLegEffect;
    /// <summary>
    /// Function: StartLegEffect
    /// </summary>
    public unsafe virtual void StartLegEffect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartLegEffect, "BmGame.MPawnVillain_FundamentalGrenadeGadget.StartLegEffect");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeactivateEffects;
    /// <summary>
    /// Function: DeactivateEffects
    /// </summary>
    public unsafe virtual void DeactivateEffects(bool bDeactivateTorsoEffects)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeactivateEffects, "BmGame.MPawnVillain_FundamentalGrenadeGadget.DeactivateEffects");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDeactivateTorsoEffects, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateHitReactionWeaponConfig;
    /// <summary>
    /// Function: CreateHitReactionWeaponConfig
    /// </summary>
    public unsafe virtual void CreateHitReactionWeaponConfig(BmSDK.BmGame.RPoseConfig PoseConfig, BmSDK.GameObject NewOwner, BmSDK.FName CombatMovementStance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateHitReactionWeaponConfig, "BmGame.MPawnVillain_FundamentalGrenadeGadget.CreateHitReactionWeaponConfig");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PoseConfig, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatMovementStance, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTargetLocation;
    /// <summary>
    /// Function: GetTargetLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetTargetLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargetLocation, "BmGame.MPawnVillain_FundamentalGrenadeGadget.GetTargetLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBlastPriority;
    /// <summary>
    /// Function: GetBlastPriority
    /// </summary>
    public unsafe virtual float GetBlastPriority()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBlastPriority, "BmGame.MPawnVillain_FundamentalGrenadeGadget.GetBlastPriority");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsTorsoHit;
    /// <summary>
    /// Function: IsTorsoHit
    /// </summary>
    public unsafe virtual bool IsTorsoHit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTorsoHit, "BmGame.MPawnVillain_FundamentalGrenadeGadget.IsTorsoHit");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AreLegsHit;
    /// <summary>
    /// Function: AreLegsHit
    /// </summary>
    public unsafe virtual bool AreLegsHit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreLegsHit, "BmGame.MPawnVillain_FundamentalGrenadeGadget.AreLegsHit");
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
    /// ObjectProperty: PawnVillain
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain PawnVillain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// ClassProperty: HitBehaviourClass
    /// </summary>
    public unsafe BmSDK.Class HitBehaviourClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// FloatProperty: TorsoTime
    /// </summary>
    public unsafe float TorsoTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// FloatProperty: LegTime
    /// </summary>
    public unsafe float LegTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: bCanTakeGrenadeHit
    /// </summary>
    public unsafe bool bCanTakeGrenadeHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }
    }

    /// <summary>
    /// BoolProperty: bCanTakeGrenadeClusterHit
    /// </summary>
    public unsafe bool bCanTakeGrenadeClusterHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }
    }

    /// <summary>
    /// BoolProperty: bTorso
    /// </summary>
    public unsafe bool bTorso
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }
    }

    /// <summary>
    /// BoolProperty: bLeftLeg
    /// </summary>
    public unsafe bool bLeftLeg
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }
    }

    /// <summary>
    /// BoolProperty: bRightLeg
    /// </summary>
    public unsafe bool bRightLeg
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }
    }

    /// <summary>
    /// BoolProperty: bPlayedTorsoBreakout
    /// </summary>
    public unsafe bool bPlayedTorsoBreakout
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }
    }

    /// <summary>
    /// BoolProperty: bPlayedLeftLegBreakout
    /// </summary>
    public unsafe bool bPlayedLeftLegBreakout
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }
    }

    /// <summary>
    /// BoolProperty: bPlayedRightLegBreakout
    /// </summary>
    public unsafe bool bPlayedRightLegBreakout
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }
    }

    /// <summary>
    /// BoolProperty: bPreviousReceiveSoftPawnCollision
    /// </summary>
    public unsafe bool bPreviousReceiveSoftPawnCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }
    }

    /// <summary>
    /// ObjectProperty: BreakOutEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent BreakOutEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }

    /// <summary>
    /// ObjectProperty: ImpactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ImpactEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// FloatProperty: SockTimeMultiplier
    /// </summary>
    public unsafe float SockTimeMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
