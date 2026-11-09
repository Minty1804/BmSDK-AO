#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMWeaponNinjaSword<br/>
/// (size = 980)
/// (flags = 8388658)
/// </summary>
public partial class RBMWeaponNinjaSword : BmSDK.BmGame.RBMWeaponMelee, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMWeaponNinjaSword", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMWeaponNinjaSword.
    /// </summary>
    public static RBMWeaponNinjaSword DefaultObject => (RBMWeaponNinjaSword)StaticClass().DefaultObject;

    internal RBMWeaponNinjaSword() { }

    /// <summary>
    /// Constructs a new RBMWeaponNinjaSword
    /// </summary>
    public RBMWeaponNinjaSword(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMWeaponNinjaSword(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMWeaponNinjaSword>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponNinjaSword>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMWeaponNinjaSword>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponNinjaSword>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponNinjaSword>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponNinjaSword>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMWeaponNinjaSword>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponNinjaSword>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetMultiAttackAnimNames;
    /// <summary>
    /// Function: GetMultiAttackAnimNames
    /// </summary>
    public unsafe override void GetMultiAttackAnimNames(out BmSDK.FName IntroName, out BmSDK.FName AttackName, out BmSDK.FName FailName, out BmSDK.FName CounterName, BmSDK.BmGame.RPawnCombat Player)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMultiAttackAnimNames, "BmScript.RBMWeaponNinjaSword.GetMultiAttackAnimNames");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out IntroName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IntroName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AttackName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackName, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out FailName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FailName, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CounterName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CounterName, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        IntroName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
        AttackName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
        FailName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 16);
        CounterName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 24);
        return;
    }

    private static BmSDK.Function __fn_GetRECPriority;
    /// <summary>
    /// Function: GetRECPriority
    /// </summary>
    public unsafe override float GetRECPriority()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRECPriority, "BmScript.RBMWeaponNinjaSword.GetRECPriority");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CreateWeaponConfig;
    /// <summary>
    /// Function: CreateWeaponConfig
    /// </summary>
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateWeaponConfig(BmSDK.GameObject NewOwner)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateWeaponConfig, "BmScript.RBMWeaponNinjaSword.CreateWeaponConfig");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CreateCombatWeaponConfig;
    /// <summary>
    /// Function: CreateCombatWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateCombatWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.TArray<BmSDK.Engine.AnimSet> AnimSets)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateCombatWeaponConfig, "BmScript.RBMWeaponNinjaSword.CreateCombatWeaponConfig");
        byte* paramsPtr = stackalloc byte[4720];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSets, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_HideWeapon;
    /// <summary>
    /// Function: HideWeapon
    /// </summary>
    public unsafe override void HideWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideWeapon, "BmScript.RBMWeaponNinjaSword.HideWeapon");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCombatAimingConfig;
    /// <summary>
    /// Function: GetCombatAimingConfig
    /// </summary>
    public unsafe static BmSDK.BmGame.RAimingConfig GetCombatAimingConfig()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatAimingConfig, "BmScript.RBMWeaponNinjaSword.GetCombatAimingConfig");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAimingConfig>(paramsPtr + 0);
    }

    /// <summary>
    /// ObjectProperty: BatclawAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BatclawAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }
}
