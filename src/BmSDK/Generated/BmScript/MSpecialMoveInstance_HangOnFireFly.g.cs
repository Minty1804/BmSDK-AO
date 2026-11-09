#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MSpecialMoveInstance_HangOnFireFly<br/>
/// (size = 660)
/// (flags = 8388626)
/// </summary>
public partial class MSpecialMoveInstance_HangOnFireFly : BmSDK.BmGame.RSpecialMoveInstance, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MSpecialMoveInstance_HangOnFireFly", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MSpecialMoveInstance_HangOnFireFly.
    /// </summary>
    public static MSpecialMoveInstance_HangOnFireFly DefaultObject => (MSpecialMoveInstance_HangOnFireFly)StaticClass().DefaultObject;

    internal MSpecialMoveInstance_HangOnFireFly() { }

    /// <summary>
    /// Constructs a new MSpecialMoveInstance_HangOnFireFly
    /// </summary>
    public MSpecialMoveInstance_HangOnFireFly(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MSpecialMoveInstance_HangOnFireFly(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_HangOnFireFly>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_HangOnFireFly>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_HangOnFireFly>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_HangOnFireFly>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_HangOnFireFly>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_HangOnFireFly>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_HangOnFireFly>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_HangOnFireFly>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_LastChanceForGrappling;
    /// <summary>
    /// Function: LastChanceForGrappling
    /// </summary>
    public unsafe virtual void LastChanceForGrappling()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LastChanceForGrappling, "BmScript.MSpecialMoveInstance_HangOnFireFly.LastChanceForGrappling");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndSlowMotion;
    /// <summary>
    /// Function: EndSlowMotion
    /// </summary>
    public unsafe virtual void EndSlowMotion()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndSlowMotion, "BmScript.MSpecialMoveInstance_HangOnFireFly.EndSlowMotion");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeginSlowMotion;
    /// <summary>
    /// Function: BeginSlowMotion
    /// </summary>
    public unsafe virtual void BeginSlowMotion()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginSlowMotion, "BmScript.MSpecialMoveInstance_HangOnFireFly.BeginSlowMotion");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanCounterFFStop;
    /// <summary>
    /// Function: CanCounterFFStop
    /// </summary>
    public unsafe virtual void CanCounterFFStop()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanCounterFFStop, "BmScript.MSpecialMoveInstance_HangOnFireFly.CanCounterFFStop");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanCounterFFStart;
    /// <summary>
    /// Function: CanCounterFFStart
    /// </summary>
    public unsafe virtual void CanCounterFFStart()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanCounterFFStart, "BmScript.MSpecialMoveInstance_HangOnFireFly.CanCounterFFStart");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GrenadeExplode;
    /// <summary>
    /// Function: GrenadeExplode
    /// </summary>
    public unsafe virtual void GrenadeExplode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GrenadeExplode, "BmScript.MSpecialMoveInstance_HangOnFireFly.GrenadeExplode");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachGrenadeToJetpack;
    /// <summary>
    /// Function: AttachGrenadeToJetpack
    /// </summary>
    public unsafe virtual void AttachGrenadeToJetpack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachGrenadeToJetpack, "BmScript.MSpecialMoveInstance_HangOnFireFly.AttachGrenadeToJetpack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachGrenadeToBM;
    /// <summary>
    /// Function: AttachGrenadeToBM
    /// </summary>
    public unsafe virtual void AttachGrenadeToBM()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachGrenadeToBM, "BmScript.MSpecialMoveInstance_HangOnFireFly.AttachGrenadeToBM");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyHangingRope;
    /// <summary>
    /// Function: DestroyHangingRope
    /// </summary>
    public unsafe virtual void DestroyHangingRope()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyHangingRope, "BmScript.MSpecialMoveInstance_HangOnFireFly.DestroyHangingRope");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateHangingRope;
    /// <summary>
    /// Function: CreateHangingRope
    /// </summary>
    public unsafe virtual void CreateHangingRope()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateHangingRope, "BmScript.MSpecialMoveInstance_HangOnFireFly.CreateHangingRope");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CancelSpecialMove;
    /// <summary>
    /// Function: CancelSpecialMove
    /// </summary>
    public unsafe override void CancelSpecialMove(BmSDK.BmGame.RSpecialMoveConfig NextSpecialMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelSpecialMove, "BmScript.MSpecialMoveInstance_HangOnFireFly.CancelSpecialMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextSpecialMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishSpecialMove;
    /// <summary>
    /// Function: FinishSpecialMove
    /// </summary>
    public unsafe override void FinishSpecialMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishSpecialMove, "BmScript.MSpecialMoveInstance_HangOnFireFly.FinishSpecialMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoseRollerCoaster;
    /// <summary>
    /// Function: LoseRollerCoaster
    /// </summary>
    public unsafe virtual void LoseRollerCoaster()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoseRollerCoaster, "BmScript.MSpecialMoveInstance_HangOnFireFly.LoseRollerCoaster");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WinRollerCoaster;
    /// <summary>
    /// Function: WinRollerCoaster
    /// </summary>
    public unsafe virtual void WinRollerCoaster()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WinRollerCoaster, "BmScript.MSpecialMoveInstance_HangOnFireFly.WinRollerCoaster");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GoCameraAnim;
    /// <summary>
    /// Function: GoCameraAnim
    /// </summary>
    public unsafe virtual void GoCameraAnim(System.Numerics.Vector3 CameraLocation, BmSDK.Rotator CameraRotation, BmSDK.FName Anim, bool IsLooping = default, float BlendTime = default, float StartTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GoCameraAnim, "BmScript.MSpecialMoveInstance_HangOnFireFly.GoCameraAnim");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraRotation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Anim, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsLooping, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendTime, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartTime, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerSpecialMove;
    /// <summary>
    /// Function: TriggerSpecialMove
    /// </summary>
    public unsafe override void TriggerSpecialMove(BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator MoveLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSpecialMove, "BmScript.MSpecialMoveInstance_HangOnFireFly.TriggerSpecialMove");
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StructProperty: BatmanTransitionId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId BatmanTransitionId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 600);

    /// <summary>
    /// StructProperty: FireFlyTransitionId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId FireFlyTransitionId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 604);

    /// <summary>
    /// ObjectProperty: Firefly
    /// </summary>
    public unsafe BmSDK.BmScript.MPawnVillainFirefly Firefly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MPawnVillainFirefly>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// StructProperty: RefPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RefPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 612);

    /// <summary>
    /// StructProperty: RefRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator RefRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 624);

    /// <summary>
    /// ObjectProperty: MyConfig
    /// </summary>
    public unsafe BmSDK.BmScript.MSpecialMoveConfig_HangOnFireFly MyConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MSpecialMoveConfig_HangOnFireFly>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// ObjectProperty: GlueGrenade
    /// </summary>
    public unsafe BmSDK.BmScript.MFireFly_GlueGrenade GlueGrenade
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MFireFly_GlueGrenade>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// BoolProperty: InputCounterFireFly
    /// </summary>
    public unsafe bool InputCounterFireFly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 644); }
    }

    /// <summary>
    /// BoolProperty: CanCounterFireFly
    /// </summary>
    public unsafe bool CanCounterFireFly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 644); }
    }

    /// <summary>
    /// BoolProperty: PlayFailCounter
    /// </summary>
    public unsafe bool PlayFailCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 644); }
    }

    /// <summary>
    /// BoolProperty: bIsSecondCounter
    /// </summary>
    public unsafe bool bIsSecondCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 644); }
    }

    /// <summary>
    /// BoolProperty: bIsFirstCounter
    /// </summary>
    public unsafe bool bIsFirstCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 644); }
    }

    /// <summary>
    /// IntProperty: CountFireBall
    /// </summary>
    public unsafe int CountFireBall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// IntProperty: NumberFireBall
    /// </summary>
    public unsafe int NumberFireBall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// FloatProperty: StateTime
    /// </summary>
    public unsafe float StateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }
}
