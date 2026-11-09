#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MSpecialMoveInstance_BaneTitanShowdown_Start<br/>
/// (size = 792)
/// (flags = 8388626)
/// </summary>
public partial class MSpecialMoveInstance_BaneTitanShowdown_Start : BmSDK.BmGame.RSpecialMoveInstance, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MSpecialMoveInstance_BaneTitanShowdown_Start", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MSpecialMoveInstance_BaneTitanShowdown_Start.
    /// </summary>
    public static MSpecialMoveInstance_BaneTitanShowdown_Start DefaultObject => (MSpecialMoveInstance_BaneTitanShowdown_Start)StaticClass().DefaultObject;

    internal MSpecialMoveInstance_BaneTitanShowdown_Start() { }

    /// <summary>
    /// Constructs a new MSpecialMoveInstance_BaneTitanShowdown_Start
    /// </summary>
    public MSpecialMoveInstance_BaneTitanShowdown_Start(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MSpecialMoveInstance_BaneTitanShowdown_Start(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_BaneTitanShowdown_Start>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_BaneTitanShowdown_Start>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_BaneTitanShowdown_Start>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_BaneTitanShowdown_Start>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_BaneTitanShowdown_Start>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_BaneTitanShowdown_Start>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_BaneTitanShowdown_Start>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_BaneTitanShowdown_Start>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_FinishSpecialMove;
    /// <summary>
    /// Function: FinishSpecialMove
    /// </summary>
    public unsafe override void FinishSpecialMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishSpecialMove, "BmScript.MSpecialMoveInstance_BaneTitanShowdown_Start.FinishSpecialMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsInteruptable;
    /// <summary>
    /// Function: IsInteruptable
    /// </summary>
    public unsafe override bool IsInteruptable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInteruptable, "BmScript.MSpecialMoveInstance_BaneTitanShowdown_Start.IsInteruptable");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DisallowPlayerMove;
    /// <summary>
    /// Function: DisallowPlayerMove
    /// </summary>
    public unsafe override bool DisallowPlayerMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisallowPlayerMove, "BmScript.MSpecialMoveInstance_BaneTitanShowdown_Start.DisallowPlayerMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CancelSpecialMove;
    /// <summary>
    /// Function: CancelSpecialMove
    /// </summary>
    public unsafe override void CancelSpecialMove(BmSDK.BmGame.RSpecialMoveConfig NextSpecialMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelSpecialMove, "BmScript.MSpecialMoveInstance_BaneTitanShowdown_Start.CancelSpecialMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextSpecialMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HitImpact;
    /// <summary>
    /// Function: HitImpact
    /// </summary>
    public unsafe virtual void HitImpact()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitImpact, "BmScript.MSpecialMoveInstance_BaneTitanShowdown_Start.HitImpact");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SlowMoStop;
    /// <summary>
    /// Function: SlowMoStop
    /// </summary>
    public unsafe virtual void SlowMoStop()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SlowMoStop, "BmScript.MSpecialMoveInstance_BaneTitanShowdown_Start.SlowMoStop");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SlowMoStart;
    /// <summary>
    /// Function: SlowMoStart
    /// </summary>
    public unsafe virtual void SlowMoStart()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SlowMoStart, "BmScript.MSpecialMoveInstance_BaneTitanShowdown_Start.SlowMoStart");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerShowdownThrow, "BmScript.MSpecialMoveInstance_BaneTitanShowdown_Start.TriggerShowdownThrow");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSpecialMove, "BmScript.MSpecialMoveInstance_BaneTitanShowdown_Start.TriggerSpecialMove");
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: BanePawn
    /// </summary>
    public unsafe BmSDK.BmScript.MPawnBossBaneTitan BanePawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MPawnBossBaneTitan>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// ObjectProperty: MyConfig
    /// </summary>
    public unsafe BmSDK.BmScript.MSpecialMoveConfig_BaneTitanShowdown_Start MyConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MSpecialMoveConfig_BaneTitanShowdown_Start>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// StructProperty: PlayerTransition
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId PlayerTransition
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 608);

    /// <summary>
    /// StructProperty: BossTransition
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId BossTransition
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 612);

    /// <summary>
    /// StructProperty: TargetPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TargetPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 616);

    /// <summary>
    /// StructProperty: TargetRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator TargetRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 628);

    /// <summary>
    /// BoolProperty: IntroIsOver
    /// </summary>
    public unsafe bool IntroIsOver
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 640) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 640); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 640); }
    }

    /// <summary>
    /// FloatProperty: IntroTimeout
    /// </summary>
    public unsafe float IntroTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// StructProperty: ImpactScreenShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ImpactScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 648);
}
