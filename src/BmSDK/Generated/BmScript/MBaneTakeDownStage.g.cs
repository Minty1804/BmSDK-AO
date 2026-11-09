#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MBaneTakeDownStage<br/>
/// (size = 1152)
/// (flags = 8388626)
/// </summary>
public partial class MBaneTakeDownStage : BmSDK.BmGame.RStealthTakeDownStage, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MBaneTakeDownStage", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MBaneTakeDownStage.
    /// </summary>
    public static MBaneTakeDownStage DefaultObject => (MBaneTakeDownStage)StaticClass().DefaultObject;

    internal MBaneTakeDownStage() { }

    /// <summary>
    /// Constructs a new MBaneTakeDownStage
    /// </summary>
    public MBaneTakeDownStage(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MBaneTakeDownStage(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBaneTakeDownStage>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBaneTakeDownStage>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBaneTakeDownStage>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBaneTakeDownStage>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBaneTakeDownStage>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBaneTakeDownStage>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBaneTakeDownStage>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBaneTakeDownStage>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_EnableCollision;
    /// <summary>
    /// Function: EnableCollision
    /// </summary>
    public unsafe virtual void EnableCollision()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableCollision, "BmScript.MBaneTakeDownStage.EnableCollision");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowMovementExit;
    /// <summary>
    /// Function: AllowMovementExit
    /// </summary>
    public unsafe virtual void AllowMovementExit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowMovementExit, "BmScript.MBaneTakeDownStage.AllowMovementExit");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSpeedNormal;
    /// <summary>
    /// Function: SetSpeedNormal
    /// </summary>
    public unsafe virtual void SetSpeedNormal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSpeedNormal, "BmScript.MBaneTakeDownStage.SetSpeedNormal");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSpeedLow;
    /// <summary>
    /// Function: SetSpeedLow
    /// </summary>
    public unsafe virtual void SetSpeedLow()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSpeedLow, "BmScript.MBaneTakeDownStage.SetSpeedLow");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitImpact, "BmScript.MBaneTakeDownStage.HitImpact");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishAttackAttacker;
    /// <summary>
    /// Function: FinishAttackAttacker
    /// </summary>
    public unsafe override void FinishAttackAttacker()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishAttackAttacker, "BmScript.MBaneTakeDownStage.FinishAttackAttacker");
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayCameraAnim;
    /// <summary>
    /// Function: PlayCameraAnim
    /// </summary>
    public unsafe virtual bool PlayCameraAnim(BmSDK.FName AnimName, BmSDK.Engine.AnimSet TheAnimSet, bool bCamMirrored, float FOV = default, bool bHardCut = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCameraAnim, "BmScript.MBaneTakeDownStage.PlayCameraAnim");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheAnimSet, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCamMirrored, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FOV, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHardCut, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_BackToPlayerCamera;
    /// <summary>
    /// Function: BackToPlayerCamera
    /// </summary>
    public unsafe virtual void BackToPlayerCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BackToPlayerCamera, "BmScript.MBaneTakeDownStage.BackToPlayerCamera");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CameraCut;
    /// <summary>
    /// Function: CameraCut
    /// </summary>
    public unsafe virtual void CameraCut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CameraCut, "BmScript.MBaneTakeDownStage.CameraCut");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartCamera;
    /// <summary>
    /// Function: StartCamera
    /// </summary>
    public unsafe virtual void StartCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartCamera, "BmScript.MBaneTakeDownStage.StartCamera");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayCameraPhase;
    /// <summary>
    /// Function: PlayCameraPhase
    /// </summary>
    public unsafe virtual void PlayCameraPhase(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCameraPhase, "BmScript.MBaneTakeDownStage.PlayCameraPhase");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldUseCustomCamera;
    /// <summary>
    /// Function: ShouldUseCustomCamera
    /// </summary>
    public unsafe virtual bool ShouldUseCustomCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldUseCustomCamera, "BmScript.MBaneTakeDownStage.ShouldUseCustomCamera");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlaySpecialCameraAnim;
    /// <summary>
    /// Function: PlaySpecialCameraAnim
    /// </summary>
    public unsafe override bool PlaySpecialCameraAnim(BmSDK.FName AnimName, bool bCamMirrored, bool CameraCollision = default, float FOV = default, BmSDK.Engine.AnimSet CustomAnimSet = default, float BlendTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySpecialCameraAnim, "BmScript.MBaneTakeDownStage.PlaySpecialCameraAnim");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCamMirrored, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraCollision, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FOV, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomAnimSet, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendTime, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_PlayCameraAuto;
    /// <summary>
    /// Function: PlayCameraAuto
    /// </summary>
    public unsafe virtual void PlayCameraAuto()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCameraAuto, "BmScript.MBaneTakeDownStage.PlayCameraAuto");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldForceSafeCamera;
    /// <summary>
    /// Function: ShouldForceSafeCamera
    /// </summary>
    public unsafe virtual bool ShouldForceSafeCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldForceSafeCamera, "BmScript.MBaneTakeDownStage.ShouldForceSafeCamera");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Begin;
    /// <summary>
    /// Function: Begin
    /// </summary>
    public unsafe override void Begin()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Begin, "BmScript.MBaneTakeDownStage.Begin");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: SlaveToVictim
    /// </summary>
    public unsafe bool SlaveToVictim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: BaneCanBeTranslated
    /// </summary>
    public unsafe bool BaneCanBeTranslated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: RestoredPlayerCamera
    /// </summary>
    public unsafe bool RestoredPlayerCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: bCutToFirstCamera
    /// </summary>
    public unsafe bool bCutToFirstCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: bMirroredTakedown
    /// </summary>
    public unsafe bool bMirroredTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// FloatProperty: GameSpeedWhenSlowedDown
    /// </summary>
    public unsafe float GameSpeedWhenSlowedDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// FloatProperty: TransitionPeriodToSlowMotion
    /// </summary>
    public unsafe float TransitionPeriodToSlowMotion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// FloatProperty: MaxTimeToRemainSlow
    /// </summary>
    public unsafe float MaxTimeToRemainSlow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// FloatProperty: EarlyOutProportion
    /// </summary>
    public unsafe float EarlyOutProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// FloatProperty: EarlyOutTime
    /// </summary>
    public unsafe float EarlyOutTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ObjectProperty: AttackerPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer AttackerPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// ArrayProperty: MultiCameraAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> MultiCameraAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ObjectProperty: MultiCameraAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet MultiCameraAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// IntProperty: CameraPhase
    /// </summary>
    public unsafe int CameraPhase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// NameProperty: BackupCameraAnimation
    /// </summary>
    public unsafe BmSDK.FName BackupCameraAnimation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// ArrayProperty: TrapStageAnim
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage.FTakeDownStageAnimSet> TrapStageAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage.FTakeDownStageAnimSet>>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// ObjectProperty: BanePawn
    /// </summary>
    public unsafe BmSDK.BmScript.MPawnBossBaneTitan BanePawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MPawnBossBaneTitan>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// ObjectProperty: BaneBeatdownMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig BaneBeatdownMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }
}
