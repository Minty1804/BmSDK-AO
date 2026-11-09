#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: MGrenadeGadgetProjectileBase<br/>
/// (size = 736)
/// (flags = 8388627)
/// </summary>
public partial class MGrenadeGadgetProjectileBase : BmSDK.BmGame.MSockGadgetProjectileBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MGrenadeGadgetProjectileBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MGrenadeGadgetProjectileBase.
    /// </summary>
    public static MGrenadeGadgetProjectileBase DefaultObject => (MGrenadeGadgetProjectileBase)StaticClass().DefaultObject;

    internal MGrenadeGadgetProjectileBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MGrenadeGadgetProjectileBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGrenadeGadgetProjectileBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGrenadeGadgetProjectileBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGrenadeGadgetProjectileBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGrenadeGadgetProjectileBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGrenadeGadgetProjectileBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGrenadeGadgetProjectileBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGrenadeGadgetProjectileBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGrenadeGadgetProjectileBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SpawnSmallFogSphere;
    /// <summary>
    /// Function: SpawnSmallFogSphere
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor SpawnSmallFogSphere(System.Numerics.Vector3 SpawnLocation, BmSDK.Rotator SpawnRotation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnSmallFogSphere, "BmGame.MGrenadeGadgetProjectileBase.SpawnSmallFogSphere");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRotation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_SpawnFogSphere;
    /// <summary>
    /// Function: SpawnFogSphere
    /// </summary>
    public unsafe virtual void SpawnFogSphere(System.Numerics.Vector3 SpawnLocation, BmSDK.Rotator SpawnRotation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnFogSphere, "BmGame.MGrenadeGadgetProjectileBase.SpawnFogSphere");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRotation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayChestBlastSound;
    /// <summary>
    /// Function: PlayChestBlastSound
    /// </summary>
    public unsafe virtual void PlayChestBlastSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayChestBlastSound, "BmGame.MGrenadeGadgetProjectileBase.PlayChestBlastSound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayFloorBlastSound;
    /// <summary>
    /// Function: PlayFloorBlastSound
    /// </summary>
    public unsafe virtual void PlayFloorBlastSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFloorBlastSound, "BmGame.MGrenadeGadgetProjectileBase.PlayFloorBlastSound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanSockVillain;
    /// <summary>
    /// Function: CanSockVillain
    /// </summary>
    public unsafe virtual bool CanSockVillain(BmSDK.BmGame.RPawnVillain V)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSockVillain, "BmGame.MGrenadeGadgetProjectileBase.CanSockVillain");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(V, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HitWall;
    /// <summary>
    /// Function: HitWall
    /// </summary>
    public unsafe override void HitWall(System.Numerics.Vector3 HitNormal, BmSDK.Engine.Actor Wall, BmSDK.Engine.PrimitiveComponent WallComp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitWall, "BmGame.MGrenadeGadgetProjectileBase.HitWall");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Wall, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallComp, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProximityTriggered;
    /// <summary>
    /// Function: ProximityTriggered
    /// </summary>
    public unsafe override void ProximityTriggered(BmSDK.BmGame.RPawnVillain NearbyVillain)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProximityTriggered, "BmGame.MGrenadeGadgetProjectileBase.ProximityTriggered");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NearbyVillain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SuperComboBlast;
    /// <summary>
    /// Function: SuperComboBlast
    /// </summary>
    public unsafe virtual void SuperComboBlast(BmSDK.BmGame.RPawnVillain Victim)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuperComboBlast, "BmGame.MGrenadeGadgetProjectileBase.SuperComboBlast");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Deploy;
    /// <summary>
    /// Function: Deploy
    /// </summary>
    public unsafe override void Deploy(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Deploy, "BmGame.MGrenadeGadgetProjectileBase.Deploy");
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.MGrenadeGadgetProjectileBase.Destroyed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartBlastFailEffect;
    /// <summary>
    /// Function: StartBlastFailEffect
    /// </summary>
    public unsafe virtual void StartBlastFailEffect(bool bUseOffset = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartBlastFailEffect, "BmGame.MGrenadeGadgetProjectileBase.StartBlastFailEffect");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseOffset, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SockVictimBody;
    /// <summary>
    /// Function: SockVictimBody
    /// </summary>
    public unsafe virtual void SockVictimBody(BmSDK.BmGame.RPawnVillain Victim, bool bInstant = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SockVictimBody, "BmGame.MGrenadeGadgetProjectileBase.SockVictimBody");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInstant, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnDecalActor;
    /// <summary>
    /// Function: SpawnDecalActor
    /// </summary>
    public unsafe virtual void SpawnDecalActor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnDecalActor, "BmGame.MGrenadeGadgetProjectileBase.SpawnDecalActor");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnDecalActorAtPos;
    /// <summary>
    /// Function: SpawnDecalActorAtPos
    /// </summary>
    public unsafe virtual void SpawnDecalActorAtPos(System.Numerics.Vector3 pos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnDecalActorAtPos, "BmGame.MGrenadeGadgetProjectileBase.SpawnDecalActorAtPos");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Detonate;
    /// <summary>
    /// Function: Detonate
    /// </summary>
    public unsafe override void Detonate(bool ProximityDetonate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Detonate, "BmGame.MGrenadeGadgetProjectileBase.Detonate");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProximityDetonate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GadgetNoiseEvent;
    /// <summary>
    /// Function: GadgetNoiseEvent
    /// </summary>
    public unsafe virtual void GadgetNoiseEvent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GadgetNoiseEvent, "BmGame.MGrenadeGadgetProjectileBase.GadgetNoiseEvent");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnDelayedTrigger;
    /// <summary>
    /// Function: SpawnDelayedTrigger
    /// </summary>
    public unsafe virtual void SpawnDelayedTrigger()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnDelayedTrigger, "BmGame.MGrenadeGadgetProjectileBase.SpawnDelayedTrigger");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bSuperComboBlast
    /// </summary>
    public unsafe bool bSuperComboBlast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 688); }
    }

    /// <summary>
    /// BoolProperty: bDontShowFailedDeployEffects
    /// </summary>
    public unsafe bool bDontShowFailedDeployEffects
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 688); }
    }

    /// <summary>
    /// FloatProperty: BlastTime
    /// </summary>
    public unsafe float BlastTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// FloatProperty: BlastRadius
    /// </summary>
    public unsafe float BlastRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ObjectProperty: FloorBlastSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FloorBlastSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ObjectProperty: ChestBlastSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ChestBlastSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ObjectProperty: ImpactWaterSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ImpactWaterSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ObjectProperty: ImpactEnemySound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ImpactEnemySound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// ObjectProperty: ImpactWallSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ImpactWallSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ObjectProperty: ImpactOnSteam
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ImpactOnSteam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ObjectProperty: SuperComboBlastSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SuperComboBlastSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ObjectProperty: Trigger
    /// </summary>
    public unsafe BmSDK.BmGame.RProximityGadgetTrigger Trigger
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProximityGadgetTrigger>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// ObjectProperty: DeployedVillain
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain DeployedVillain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }
}
