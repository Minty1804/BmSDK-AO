#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPawnVillainGunThermal<br/>
/// (size = 4140)
/// (flags = 10485814)
/// </summary>
public partial class RPawnVillainGunThermal : BmSDK.BmScript.RPawnVillainGun, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnVillainGunThermal", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnVillainGunThermal.
    /// </summary>
    public static RPawnVillainGunThermal DefaultObject => (RPawnVillainGunThermal)StaticClass().DefaultObject;

    internal RPawnVillainGunThermal() { }

    /// <summary>
    /// Constructs a new RPawnVillainGunThermal
    /// </summary>
    public RPawnVillainGunThermal(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainGunThermal(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunThermal>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunThermal>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunThermal>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunThermal>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunThermal>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunThermal>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunThermal>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunThermal>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetGoodAsDead;
    /// <summary>
    /// Function: SetGoodAsDead
    /// </summary>
    public unsafe override void SetGoodAsDead()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGoodAsDead, "BmScript.RPawnVillainGunThermal.SetGoodAsDead");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGargoyleScanFX;
    /// <summary>
    /// Function: GetGargoyleScanFX
    /// </summary>
    public unsafe override BmSDK.Engine.ParticleSystem GetGargoyleScanFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGargoyleScanFX, "BmScript.RPawnVillainGunThermal.GetGargoyleScanFX");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.ParticleSystem>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetThermalAnimset;
    /// <summary>
    /// Function: GetThermalAnimset
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetThermalAnimset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThermalAnimset, "BmScript.RPawnVillainGunThermal.GetThermalAnimset");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayGoggleOffSFX;
    /// <summary>
    /// Function: PlayGoggleOffSFX
    /// </summary>
    public unsafe override void PlayGoggleOffSFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayGoggleOffSFX, "BmScript.RPawnVillainGunThermal.PlayGoggleOffSFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FakeThermalSwitchOff;
    /// <summary>
    /// Function: FakeThermalSwitchOff
    /// </summary>
    public unsafe virtual void FakeThermalSwitchOff()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FakeThermalSwitchOff, "BmScript.RPawnVillainGunThermal.FakeThermalSwitchOff");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FakeThermalSwitchOn;
    /// <summary>
    /// Function: FakeThermalSwitchOn
    /// </summary>
    public unsafe virtual void FakeThermalSwitchOn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FakeThermalSwitchOn, "BmScript.RPawnVillainGunThermal.FakeThermalSwitchOn");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayGoggleOnSFX;
    /// <summary>
    /// Function: PlayGoggleOnSFX
    /// </summary>
    public unsafe override void PlayGoggleOnSFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayGoggleOnSFX, "BmScript.RPawnVillainGunThermal.PlayGoggleOnSFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPawnProps;
    /// <summary>
    /// Function: AddPawnProps
    /// </summary>
    public unsafe override void AddPawnProps()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPawnProps, "BmScript.RPawnVillainGunThermal.AddPawnProps");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostInitCharacter;
    /// <summary>
    /// Function: PostInitCharacter
    /// </summary>
    public unsafe override void PostInitCharacter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostInitCharacter, "BmScript.RPawnVillainGunThermal.PostInitCharacter");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// NameProperty: ThermalSocket
    /// </summary>
    public unsafe BmSDK.FName ThermalSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4120); }
    }

    /// <summary>
    /// ObjectProperty: VisionOnSFX
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent VisionOnSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4128); }
    }

    /// <summary>
    /// ObjectProperty: VisionOffSFX
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent VisionOffSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4132); }
    }

    /// <summary>
    /// ObjectProperty: GargoyleScanSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem GargoyleScanSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4136); }
    }
}
