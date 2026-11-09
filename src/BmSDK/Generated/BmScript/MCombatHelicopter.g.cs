#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MCombatHelicopter<br/>
/// (size = 4812)
/// (flags = 10486326)
/// </summary>
public partial class MCombatHelicopter : BmSDK.BmScript.RHelicopter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MCombatHelicopter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MCombatHelicopter.
    /// </summary>
    public static MCombatHelicopter DefaultObject => (MCombatHelicopter)StaticClass().DefaultObject;

    internal MCombatHelicopter() { }

    /// <summary>
    /// Constructs a new MCombatHelicopter
    /// </summary>
    public MCombatHelicopter(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MCombatHelicopter(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MCombatHelicopter>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatHelicopter>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MCombatHelicopter>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatHelicopter>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatHelicopter>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatHelicopter>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MCombatHelicopter>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatHelicopter>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_PlayerSighted;
    /// <summary>
    /// Function: PlayerSighted
    /// </summary>
    public unsafe override void PlayerSighted(BmSDK.BmGame.RHelicopterBase.FDroneToHelicopterMessage msg)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerSighted, "BmScript.MCombatHelicopter.PlayerSighted");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(msg, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceAttackAtTargetLocation;
    /// <summary>
    /// Function: ForceAttackAtTargetLocation
    /// </summary>
    public unsafe virtual void ForceAttackAtTargetLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceAttackAtTargetLocation, "BmScript.MCombatHelicopter.ForceAttackAtTargetLocation");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSearchLightStartPoint;
    /// <summary>
    /// Function: SetSearchLightStartPoint
    /// </summary>
    public unsafe virtual void SetSearchLightStartPoint(BmSDK.BmGame.RPatrolPoint SearchLightStartPoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSearchLightStartPoint, "BmScript.MCombatHelicopter.SetSearchLightStartPoint");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchLightStartPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAmbushPatrolPoint;
    /// <summary>
    /// Function: SetAmbushPatrolPoint
    /// </summary>
    public unsafe virtual void SetAmbushPatrolPoint(BmSDK.BmGame.RPatrolPoint AmbushPatrolPoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAmbushPatrolPoint, "BmScript.MCombatHelicopter.SetAmbushPatrolPoint");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AmbushPatrolPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChangeActiveProperty;
    /// <summary>
    /// Function: ChangeActiveProperty
    /// </summary>
    public unsafe override void ChangeActiveProperty(BmSDK.BmGame.RHelicopterBase.EChopperBehaviours Prop)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeActiveProperty, "BmScript.MCombatHelicopter.ChangeActiveProperty");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Prop, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmScript.MCombatHelicopter.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: AmbushStartPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RPatrolPoint AmbushStartPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPatrolPoint>(Ptr + 4780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4780); }
    }

    /// <summary>
    /// ObjectProperty: AmbushSearchLightStartPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RPatrolPoint AmbushSearchLightStartPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPatrolPoint>(Ptr + 4784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4784); }
    }

    /// <summary>
    /// ObjectProperty: AmbushSearchLightNextPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RPatrolPoint AmbushSearchLightNextPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPatrolPoint>(Ptr + 4788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4788); }
    }

    /// <summary>
    /// StructProperty: PlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PlayerPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4792);

    /// <summary>
    /// IntProperty: CommunicatingDrones
    /// </summary>
    public unsafe int CommunicatingDrones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4804); }
    }

    /// <summary>
    /// FloatProperty: PrevTime
    /// </summary>
    public unsafe float PrevTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4808); }
    }
}
