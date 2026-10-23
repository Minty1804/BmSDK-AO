#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MFireflyLaneChargeTrail<br/>
/// (size = 636)
/// (flags = 8388626)
/// </summary>
public partial class MFireflyLaneChargeTrail : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MFireflyLaneChargeTrail", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MFireflyLaneChargeTrail.
    /// </summary>
    public static MFireflyLaneChargeTrail DefaultObject => (MFireflyLaneChargeTrail)StaticClass().DefaultObject;

    internal MFireflyLaneChargeTrail() { }

    /// <summary>
    /// Constructs a new MFireflyLaneChargeTrail
    /// </summary>
    public MFireflyLaneChargeTrail(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MFireflyLaneChargeTrail(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MFireflyLaneChargeTrail>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MFireflyLaneChargeTrail>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MFireflyLaneChargeTrail>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MFireflyLaneChargeTrail>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MFireflyLaneChargeTrail>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MFireflyLaneChargeTrail>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MFireflyLaneChargeTrail>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MFireflyLaneChargeTrail>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: DestroyAfterTimer
    /// </summary>
    public unsafe virtual void DestroyAfterTimer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MFireflyLaneChargeTrail.DestroyAfterTimer", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MFireflyLaneChargeTrail.Tick", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DebugDrawHitBox
    /// </summary>
    public unsafe virtual void DebugDrawHitBox()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MFireflyLaneChargeTrail.DebugDrawHitBox", true);
        byte* paramsPtr = stackalloc byte[135];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HitPlayer
    /// </summary>
    public unsafe virtual void HitPlayer(System.Numerics.Vector3 Normal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MFireflyLaneChargeTrail.HitPlayer", true);
        byte* paramsPtr = stackalloc byte[268];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Normal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckHitPlayer
    /// </summary>
    public unsafe virtual void CheckHitPlayer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MFireflyLaneChargeTrail.CheckHitPlayer", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopFireWall
    /// </summary>
    public unsafe virtual void StopFireWall()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MFireflyLaneChargeTrail.StopFireWall", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartFireWall
    /// </summary>
    public unsafe virtual void StartFireWall()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MFireflyLaneChargeTrail.StartFireWall", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopLaneCharge
    /// </summary>
    public unsafe virtual void StopLaneCharge()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MFireflyLaneChargeTrail.StopLaneCharge", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartLaneCharge
    /// </summary>
    public unsafe virtual void StartLaneCharge(System.Numerics.Vector3 pos, BmSDK.Rotator Rot)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MFireflyLaneChargeTrail.StartLaneCharge", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DamageCars
    /// </summary>
    public unsafe virtual void DamageCars(System.Numerics.Vector3 Loc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MFireflyLaneChargeTrail.DamageCars", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: LaneChargeExplosion
    /// </summary>
    public unsafe virtual void LaneChargeExplosion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MFireflyLaneChargeTrail.LaneChargeExplosion", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateLaneCharge
    /// </summary>
    public unsafe virtual void UpdateLaneCharge(System.Numerics.Vector3 pos)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MFireflyLaneChargeTrail.UpdateLaneCharge", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EndFireflyFogVolume
    /// </summary>
    public unsafe virtual void EndFireflyFogVolume()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MFireflyLaneChargeTrail.EndFireflyFogVolume", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnFireflyFogVolume
    /// </summary>
    public unsafe virtual void SpawnFireflyFogVolume(int Number, System.Numerics.Vector3 InitialOffset, System.Numerics.Vector3 Offset)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MFireflyLaneChargeTrail.SpawnFireflyFogVolume", true);
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Number, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InitialOffset, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Offset, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MFireflyLaneChargeTrail.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ComponentProperty: FlameTrail
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FlameTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// BoolProperty: EffectOn
    /// </summary>
    public unsafe bool EffectOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 456) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 456); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 456); }
    }

    /// <summary>
    /// BoolProperty: IsFireWallTrail
    /// </summary>
    public unsafe bool IsFireWallTrail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 456) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 456); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 456); }
    }

    /// <summary>
    /// ObjectProperty: Firefly
    /// </summary>
    public unsafe BmSDK.BmScript.MPawnVillainFirefly Firefly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MPawnVillainFirefly>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// ObjectProperty: Player
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer Player
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// FloatProperty: HitTimer
    /// </summary>
    public unsafe float HitTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// ObjectProperty: LaneChargeFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem LaneChargeFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// ObjectProperty: FlameWallFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem FlameWallFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// ObjectProperty: LaneChargeExplosionFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem LaneChargeExplosionFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// StructProperty: OffSetCollisionPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 OffSetCollisionPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 484);

    /// <summary>
    /// StructProperty: CurrentCollisionExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentCollisionExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 496);

    /// <summary>
    /// StructProperty: LaneChargeColExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LaneChargeColExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 508);

    /// <summary>
    /// StructProperty: FireWallColExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FireWallColExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 520);

    /// <summary>
    /// FloatProperty: AttackTimer
    /// </summary>
    public unsafe float AttackTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// ObjectProperty: FireWallSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FireWallSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// ObjectProperty: StopFireWallSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent StopFireWallSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// ObjectProperty: LaneChargeExplosionSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent LaneChargeExplosionSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// FloatProperty: DestroyAttackTimer
    /// </summary>
    public unsafe float DestroyAttackTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// FloatProperty: BlastRadiusOuter
    /// </summary>
    public unsafe float BlastRadiusOuter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: FogVolumes
    /// </summary>
    public InlineArray<BmSDK.BmScript.MFireflyFogVolume> FogVolumes => new(20, Ptr + 556, 4, this);

    /// <summary>
    /// ObjectProperty: FogVolumes
    /// </summary>
    public unsafe BmSDK.BmScript.MFireflyFogVolume FogVolumes_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MFireflyFogVolume>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }
    /// <summary>
    /// ObjectProperty: FogVolumes
    /// </summary>
    public unsafe BmSDK.BmScript.MFireflyFogVolume FogVolumes_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MFireflyFogVolume>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }
    /// <summary>
    /// ObjectProperty: FogVolumes
    /// </summary>
    public unsafe BmSDK.BmScript.MFireflyFogVolume FogVolumes_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MFireflyFogVolume>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }
    /// <summary>
    /// ObjectProperty: FogVolumes
    /// </summary>
    public unsafe BmSDK.BmScript.MFireflyFogVolume FogVolumes_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MFireflyFogVolume>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }
    /// <summary>
    /// ObjectProperty: FogVolumes
    /// </summary>
    public unsafe BmSDK.BmScript.MFireflyFogVolume FogVolumes_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MFireflyFogVolume>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }
    /// <summary>
    /// ObjectProperty: FogVolumes
    /// </summary>
    public unsafe BmSDK.BmScript.MFireflyFogVolume FogVolumes_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MFireflyFogVolume>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }
    /// <summary>
    /// ObjectProperty: FogVolumes
    /// </summary>
    public unsafe BmSDK.BmScript.MFireflyFogVolume FogVolumes_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MFireflyFogVolume>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }
    /// <summary>
    /// ObjectProperty: FogVolumes
    /// </summary>
    public unsafe BmSDK.BmScript.MFireflyFogVolume FogVolumes_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MFireflyFogVolume>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }
    /// <summary>
    /// ObjectProperty: FogVolumes
    /// </summary>
    public unsafe BmSDK.BmScript.MFireflyFogVolume FogVolumes_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MFireflyFogVolume>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }
    /// <summary>
    /// ObjectProperty: FogVolumes
    /// </summary>
    public unsafe BmSDK.BmScript.MFireflyFogVolume FogVolumes_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MFireflyFogVolume>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }
    /// <summary>
    /// ObjectProperty: FogVolumes
    /// </summary>
    public unsafe BmSDK.BmScript.MFireflyFogVolume FogVolumes_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MFireflyFogVolume>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }
    /// <summary>
    /// ObjectProperty: FogVolumes
    /// </summary>
    public unsafe BmSDK.BmScript.MFireflyFogVolume FogVolumes_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MFireflyFogVolume>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }
    /// <summary>
    /// ObjectProperty: FogVolumes
    /// </summary>
    public unsafe BmSDK.BmScript.MFireflyFogVolume FogVolumes_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MFireflyFogVolume>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }
    /// <summary>
    /// ObjectProperty: FogVolumes
    /// </summary>
    public unsafe BmSDK.BmScript.MFireflyFogVolume FogVolumes_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MFireflyFogVolume>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }
    /// <summary>
    /// ObjectProperty: FogVolumes
    /// </summary>
    public unsafe BmSDK.BmScript.MFireflyFogVolume FogVolumes_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MFireflyFogVolume>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }
    /// <summary>
    /// ObjectProperty: FogVolumes
    /// </summary>
    public unsafe BmSDK.BmScript.MFireflyFogVolume FogVolumes_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MFireflyFogVolume>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }
    /// <summary>
    /// ObjectProperty: FogVolumes
    /// </summary>
    public unsafe BmSDK.BmScript.MFireflyFogVolume FogVolumes_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MFireflyFogVolume>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }
    /// <summary>
    /// ObjectProperty: FogVolumes
    /// </summary>
    public unsafe BmSDK.BmScript.MFireflyFogVolume FogVolumes_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MFireflyFogVolume>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }
    /// <summary>
    /// ObjectProperty: FogVolumes
    /// </summary>
    public unsafe BmSDK.BmScript.MFireflyFogVolume FogVolumes_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MFireflyFogVolume>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }
    /// <summary>
    /// ObjectProperty: FogVolumes
    /// </summary>
    public unsafe BmSDK.BmScript.MFireflyFogVolume FogVolumes_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MFireflyFogVolume>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }
}
