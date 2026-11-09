#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// ABSTRACT Class: RBMCombatPoint_GunDispenser<br/>
/// (size = 608)
/// (flags = 8389139)
/// </summary>
public partial class RBMCombatPoint_GunDispenser : BmSDK.BmGame.RBMCombatPoint_GunDispenserBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMCombatPoint_GunDispenser", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMCombatPoint_GunDispenser.
    /// </summary>
    public static RBMCombatPoint_GunDispenser DefaultObject => (RBMCombatPoint_GunDispenser)StaticClass().DefaultObject;

    internal RBMCombatPoint_GunDispenser() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMCombatPoint_GunDispenser(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_GunDispenser>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_GunDispenser>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_GunDispenser>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_GunDispenser>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_GunDispenser>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_GunDispenser>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_GunDispenser>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatPoint_GunDispenser>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetJamOffsetTarget;
    /// <summary>
    /// Function: GetJamOffsetTarget
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetJamOffsetTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetJamOffsetTarget, "BmScript.RBMCombatPoint_GunDispenser.GetJamOffsetTarget");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HitByJammerGadgetCharge;
    /// <summary>
    /// Function: HitByJammerGadgetCharge
    /// </summary>
    public unsafe override void HitByJammerGadgetCharge()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitByJammerGadgetCharge, "BmScript.RBMCombatPoint_GunDispenser.HitByJammerGadgetCharge");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBeJammed;
    /// <summary>
    /// Function: CanBeJammed
    /// </summary>
    public unsafe override bool CanBeJammed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeJammed, "BmScript.RBMCombatPoint_GunDispenser.CanBeJammed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DisableJammed;
    /// <summary>
    /// Function: DisableJammed
    /// </summary>
    public unsafe override void DisableJammed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableJammed, "BmScript.RBMCombatPoint_GunDispenser.DisableJammed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsLockerJammed;
    /// <summary>
    /// Function: IsLockerJammed
    /// </summary>
    public unsafe override bool IsLockerJammed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLockerJammed, "BmScript.RBMCombatPoint_GunDispenser.IsLockerJammed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AlarmOff;
    /// <summary>
    /// Function: AlarmOff
    /// </summary>
    public unsafe virtual void AlarmOff()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AlarmOff, "BmScript.RBMCombatPoint_GunDispenser.AlarmOff");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AlarmOn;
    /// <summary>
    /// Function: AlarmOn
    /// </summary>
    public unsafe virtual void AlarmOn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AlarmOn, "BmScript.RBMCombatPoint_GunDispenser.AlarmOn");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideGun;
    /// <summary>
    /// Function: HideGun
    /// </summary>
    public unsafe virtual void HideGun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideGun, "BmScript.RBMCombatPoint_GunDispenser.HideGun");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwapGun;
    /// <summary>
    /// Function: SwapGun
    /// </summary>
    public unsafe virtual void SwapGun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwapGun, "BmScript.RBMCombatPoint_GunDispenser.SwapGun");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveDoor;
    /// <summary>
    /// Function: RemoveDoor
    /// </summary>
    public unsafe virtual void RemoveDoor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveDoor, "BmScript.RBMCombatPoint_GunDispenser.RemoveDoor");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UsedByPawn;
    /// <summary>
    /// Function: UsedByPawn
    /// </summary>
    public unsafe override void UsedByPawn(BmSDK.BmGame.RPawnCombat NewUser, BmSDK.BmGame.RPawnCombat NewTarget = default, bool bUsedDuringTaunt = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UsedByPawn, "BmScript.RBMCombatPoint_GunDispenser.UsedByPawn");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewUser, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUsedDuringTaunt, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBeUsedByPawn;
    /// <summary>
    /// Function: CanBeUsedByPawn
    /// </summary>
    public unsafe override bool CanBeUsedByPawn(BmSDK.BmGame.RPawnCombat NewUser, BmSDK.BmGame.RPawnCombat NewTarget, bool bTaunting)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeUsedByPawn, "BmScript.RBMCombatPoint_GunDispenser.CanBeUsedByPawn");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewUser, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTaunting, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetMoveToPoint;
    /// <summary>
    /// Function: GetMoveToPoint
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetMoveToPoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMoveToPoint, "BmScript.RBMCombatPoint_GunDispenser.GetMoveToPoint");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAnimRefYaw;
    /// <summary>
    /// Function: GetAnimRefYaw
    /// </summary>
    public unsafe virtual int GetAnimRefYaw()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimRefYaw, "BmScript.RBMCombatPoint_GunDispenser.GetAnimRefYaw");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAnimRefPoint;
    /// <summary>
    /// Function: GetAnimRefPoint
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAnimRefPoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimRefPoint, "BmScript.RBMCombatPoint_GunDispenser.GetAnimRefPoint");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmScript.RBMCombatPoint_GunDispenser.Destroyed");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmScript.RBMCombatPoint_GunDispenser.PreStreamOut");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmScript.RBMCombatPoint_GunDispenser.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bOpen
    /// </summary>
    public unsafe bool bOpen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 512) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 512); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 512); }
    }

    /// <summary>
    /// BoolProperty: IsJammed
    /// </summary>
    public unsafe bool IsJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 512) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 512); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 512); }
    }

    /// <summary>
    /// BoolProperty: IsDisableJammed
    /// </summary>
    public unsafe bool IsDisableJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 512) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 512); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 512); }
    }

    /// <summary>
    /// FloatProperty: OpenTime
    /// </summary>
    public unsafe float OpenTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// IntProperty: AnimYaw
    /// </summary>
    public unsafe int AnimYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// ObjectProperty: AnimNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence AnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// ComponentProperty: LightEnvironment
    /// </summary>
    public unsafe BmSDK.Engine.LightEnvironmentComponent LightEnvironment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LightEnvironmentComponent>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// ObjectProperty: ThugAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet ThugAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// NameProperty: ThugAnim_In
    /// </summary>
    public unsafe BmSDK.FName ThugAnim_In
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// NameProperty: ThugAnim_Loop
    /// </summary>
    public unsafe BmSDK.FName ThugAnim_Loop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// NameProperty: ThugAnim_Open
    /// </summary>
    public unsafe BmSDK.FName ThugAnim_Open
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// NameProperty: ThugAnim_GetGun
    /// </summary>
    public unsafe BmSDK.FName ThugAnim_GetGun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// NameProperty: ThugAnim_Fail
    /// </summary>
    public unsafe BmSDK.FName ThugAnim_Fail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// StructProperty: JamOffsetTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 JamOffsetTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 576);

    /// <summary>
    /// ComponentProperty: PlayerInteractions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent PlayerInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// ObjectProperty: SoundAlarmJammed
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SoundAlarmJammed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// StructProperty: SoundAlarmJammedHandler
    /// </summary>
    public unsafe ref BmSDK.Engine.AkWwise.FAkSoundHandle SoundAlarmJammedHandler
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 596);
}
