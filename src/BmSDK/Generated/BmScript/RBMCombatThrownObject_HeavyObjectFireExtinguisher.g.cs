#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMCombatThrownObject_HeavyObjectFireExtinguisher<br/>
/// (size = 812)
/// (flags = 8389138)
/// </summary>
public partial class RBMCombatThrownObject_HeavyObjectFireExtinguisher : BmSDK.BmScript.RBMCombatThrownObject_HeavyObject, BmSDK.BmGame.RBatarangableInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMCombatThrownObject_HeavyObjectFireExtinguisher", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMCombatThrownObject_HeavyObjectFireExtinguisher.
    /// </summary>
    public static RBMCombatThrownObject_HeavyObjectFireExtinguisher DefaultObject => (RBMCombatThrownObject_HeavyObjectFireExtinguisher)StaticClass().DefaultObject;

    internal RBMCombatThrownObject_HeavyObjectFireExtinguisher() { }

    /// <summary>
    /// Constructs a new RBMCombatThrownObject_HeavyObjectFireExtinguisher
    /// </summary>
    public RBMCombatThrownObject_HeavyObjectFireExtinguisher(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMCombatThrownObject_HeavyObjectFireExtinguisher(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_HeavyObjectFireExtinguisher>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_HeavyObjectFireExtinguisher>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_HeavyObjectFireExtinguisher>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_HeavyObjectFireExtinguisher>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_HeavyObjectFireExtinguisher>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_HeavyObjectFireExtinguisher>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_HeavyObjectFireExtinguisher>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatThrownObject_HeavyObjectFireExtinguisher>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_HitSomething;
    /// <summary>
    /// Function: HitSomething
    /// </summary>
    public unsafe override void HitSomething(BmSDK.BmGame.RPawnCombat HitPawn, float Speed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitSomething, "BmScript.RBMCombatThrownObject_HeavyObjectFireExtinguisher.HitSomething");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DetonateObject;
    /// <summary>
    /// Function: DetonateObject
    /// </summary>
    public unsafe override void DetonateObject()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetonateObject, "BmScript.RBMCombatThrownObject_HeavyObjectFireExtinguisher.DetonateObject");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TakeDamage;
    /// <summary>
    /// Function: TakeDamage
    /// </summary>
    public unsafe override void TakeDamage(int Damage, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class dmgType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeDamage, "BmScript.RBMCombatThrownObject_HeavyObjectFireExtinguisher.TakeDamage");
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 72);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PulledByDualClaw;
    /// <summary>
    /// Function: PulledByDualClaw
    /// </summary>
    public unsafe override void PulledByDualClaw()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PulledByDualClaw, "BmScript.RBMCombatThrownObject_HeavyObjectFireExtinguisher.PulledByDualClaw");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HitByGel;
    /// <summary>
    /// Function: HitByGel
    /// </summary>
    public unsafe override void HitByGel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitByGel, "BmScript.RBMCombatThrownObject_HeavyObjectFireExtinguisher.HitByGel");
        byte* paramsPtr = stackalloc byte[20];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatarangSpeedBoost, "BmScript.RBMCombatThrownObject_HeavyObjectFireExtinguisher.GetBatarangSpeedBoost");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceHitAtEndOfFlight, "BmScript.RBMCombatThrownObject_HeavyObjectFireExtinguisher.ForceHitAtEndOfFlight");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatarangPriority, "BmScript.RBMCombatThrownObject_HeavyObjectFireExtinguisher.GetBatarangPriority");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBatarangable, "BmScript.RBMCombatThrownObject_HeavyObjectFireExtinguisher.IsBatarangable");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatarangTargetPosition, "BmScript.RBMCombatThrownObject_HeavyObjectFireExtinguisher.GetBatarangTargetPosition");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimDirection, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDuringTargetPhase, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 28);
    }

    /// <summary>
    /// ComponentProperty: Interactions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent Interactions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// StructProperty: BatarangOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BatarangOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 796);

    /// <summary>
    /// BoolProperty: bFirstFireExCollision
    /// </summary>
    public unsafe bool bFirstFireExCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bPulledByDualClaw
    /// </summary>
    public unsafe bool bPulledByDualClaw
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }
}
