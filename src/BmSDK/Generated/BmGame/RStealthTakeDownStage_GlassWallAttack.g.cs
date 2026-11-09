#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RStealthTakeDownStage_GlassWallAttack<br/>
/// (size = 1268)
/// (flags = 8388626)
/// </summary>
public partial class RStealthTakeDownStage_GlassWallAttack : BmSDK.BmGame.RStealthTakeDownStage, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RStealthTakeDownStage_GlassWallAttack", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RStealthTakeDownStage_GlassWallAttack.
    /// </summary>
    public static RStealthTakeDownStage_GlassWallAttack DefaultObject => (RStealthTakeDownStage_GlassWallAttack)StaticClass().DefaultObject;

    internal RStealthTakeDownStage_GlassWallAttack() { }

    /// <summary>
    /// Constructs a new RStealthTakeDownStage_GlassWallAttack
    /// </summary>
    public RStealthTakeDownStage_GlassWallAttack(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RStealthTakeDownStage_GlassWallAttack(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_GlassWallAttack>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_GlassWallAttack>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_GlassWallAttack>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_GlassWallAttack>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_GlassWallAttack>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_GlassWallAttack>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_GlassWallAttack>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_GlassWallAttack>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_FinaleCamera;
    /// <summary>
    /// Function: FinaleCamera
    /// </summary>
    public unsafe override void FinaleCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinaleCamera, "BmGame.RStealthTakeDownStage_GlassWallAttack.FinaleCamera");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerVictim;
    /// <summary>
    /// Function: TriggerVictim
    /// </summary>
    public unsafe override void TriggerVictim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerVictim, "BmGame.RStealthTakeDownStage_GlassWallAttack.TriggerVictim");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleBreakWall;
    /// <summary>
    /// Function: HandleBreakWall
    /// </summary>
    public unsafe virtual void HandleBreakWall(BmSDK.Engine.FracturedStaticMeshActor FractureWindow, System.Numerics.Vector3 Loc, System.Numerics.Vector3 Direction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleBreakWall, "BmGame.RStealthTakeDownStage_GlassWallAttack.HandleBreakWall");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FractureWindow, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BreakWall;
    /// <summary>
    /// Function: BreakWall
    /// </summary>
    public unsafe virtual void BreakWall()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BreakWall, "BmGame.RStealthTakeDownStage_GlassWallAttack.BreakWall");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayCameraAnim;
    /// <summary>
    /// Function: PlayCameraAnim
    /// </summary>
    public unsafe virtual void PlayCameraAnim(BmSDK.FName AnimName, bool bCamMirrored, BmSDK.Engine.Actor CameraCollisionTarget, float FOV = default, System.Numerics.Vector3 CollisionTargetPos = default, bool bHardCut = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCameraAnim, "BmGame.RStealthTakeDownStage_GlassWallAttack.PlayCameraAnim");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCamMirrored, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraCollisionTarget, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FOV, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionTargetPos, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHardCut, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BackToPlayerCamera;
    /// <summary>
    /// Function: BackToPlayerCamera
    /// </summary>
    public unsafe virtual void BackToPlayerCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BackToPlayerCamera, "BmGame.RStealthTakeDownStage_GlassWallAttack.BackToPlayerCamera");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CameraCut, "BmGame.RStealthTakeDownStage_GlassWallAttack.CameraCut");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartCamera, "BmGame.RStealthTakeDownStage_GlassWallAttack.StartCamera");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetFinishState;
    /// <summary>
    /// Function: GetFinishState
    /// </summary>
    public unsafe override BmSDK.FName GetFinishState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFinishState, "BmGame.RStealthTakeDownStage_GlassWallAttack.GetFinishState");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayCameraPhase;
    /// <summary>
    /// Function: PlayCameraPhase
    /// </summary>
    public unsafe virtual void PlayCameraPhase(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCameraPhase, "BmGame.RStealthTakeDownStage_GlassWallAttack.PlayCameraPhase");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_End;
    /// <summary>
    /// Function: End
    /// </summary>
    public unsafe override void End(bool bLastStage = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_End, "BmGame.RStealthTakeDownStage_GlassWallAttack.End");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLastStage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Begin;
    /// <summary>
    /// Function: Begin
    /// </summary>
    public unsafe override void Begin()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Begin, "BmGame.RStealthTakeDownStage_GlassWallAttack.Begin");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OverrideChosenAnim;
    /// <summary>
    /// Function: OverrideChosenAnim
    /// </summary>
    public unsafe override void OverrideChosenAnim(out int Anim)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideChosenAnim, "BmGame.RStealthTakeDownStage_GlassWallAttack.OverrideChosenAnim");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Anim);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Anim, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Anim = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetStageAnim;
    /// <summary>
    /// Function: GetStageAnim
    /// </summary>
    public unsafe override int GetStageAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStageAnim, "BmGame.RStealthTakeDownStage_GlassWallAttack.GetStageAnim");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopXray;
    /// <summary>
    /// Function: StopXray
    /// </summary>
    public unsafe virtual void StopXray(BmSDK.BmGame.RPlayerController lPC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopXray, "BmGame.RStealthTakeDownStage_GlassWallAttack.StopXray");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(lPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetReferencePosition;
    /// <summary>
    /// Function: GetReferencePosition
    /// </summary>
    public unsafe override void GetReferencePosition(out System.Numerics.Vector3 ReferencePosition, out BmSDK.Rotator ReferenceRotation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetReferencePosition, "BmGame.RStealthTakeDownStage_GlassWallAttack.GetReferencePosition");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ReferencePosition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReferencePosition, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ReferenceRotation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReferenceRotation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ReferencePosition = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        ReferenceRotation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_AlignWithWall;
    /// <summary>
    /// Function: AlignWithWall
    /// </summary>
    public unsafe virtual void AlignWithWall(out System.Numerics.Vector3 BestPoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AlignWithWall, "BmGame.RStealthTakeDownStage_GlassWallAttack.AlignWithWall");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BestPoint);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BestPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BestPoint = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Struct: FWallAttackStageInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FWallAttackStageInfo
    {
        /// <summary>
        /// ArrayProperty: AnimInfos
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage_GlassWallAttack.FWallAttackAnimInfo> AnimInfos
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage_GlassWallAttack.FWallAttackAnimInfo>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FWallAttackAnimInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FWallAttackAnimInfo
    {
        /// <summary>
        /// ArrayProperty: CameraCollisionOptions
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage_GlassWallAttack.CameraCollisionOption> CameraCollisionOptions
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage_GlassWallAttack.CameraCollisionOption>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: CameraAnims
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> CameraAnims
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Enum: CameraCollisionOption
    /// </summary>
    public enum CameraCollisionOption : byte
    {
        CCO_None = 0,
        CCO_Player = 1,
        CCO_Victim = 2,
        CCO_MAX = 3,
    }

    /// <summary>
    /// StructProperty: StartLoc
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator StartLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(Ptr + 1076);

    /// <summary>
    /// ObjectProperty: Player
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer Player
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// ObjectProperty: PlayerController
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController PlayerController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// ObjectProperty: Wall
    /// </summary>
    public unsafe BmSDK.BmGame.RFractureWallBase Wall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RFractureWallBase>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// BoolProperty: bOldWallSuppressFullAIEvent
    /// </summary>
    public unsafe bool bOldWallSuppressFullAIEvent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1200) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1200); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1200); }
    }

    /// <summary>
    /// BoolProperty: bPlayingCamera
    /// </summary>
    public unsafe bool bPlayingCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1200) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1200); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1200); }
    }

    /// <summary>
    /// BoolProperty: bPlayerControllerStateWasCornerCover
    /// </summary>
    public unsafe bool bPlayerControllerStateWasCornerCover
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1200) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1200); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1200); }
    }

    /// <summary>
    /// BoolProperty: bSupportNon128Animation
    /// </summary>
    public unsafe bool bSupportNon128Animation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1200) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1200); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1200); }
    }

    /// <summary>
    /// StructProperty: StartPlayerPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StartPlayerPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1204);

    /// <summary>
    /// StructProperty: StartVictimPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StartVictimPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1216);

    /// <summary>
    /// StructProperty: CameraRootLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CameraRootLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1228);

    /// <summary>
    /// IntProperty: CameraPhase
    /// </summary>
    public unsafe int CameraPhase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// ArrayProperty: WallAttackStageInfos
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage_GlassWallAttack.FWallAttackStageInfo> WallAttackStageInfos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage_GlassWallAttack.FWallAttackStageInfo>>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }

    /// <summary>
    /// StructProperty: WallAttackStage
    /// </summary>
    public unsafe ref BmSDK.BmGame.RStealthTakeDownStage_GlassWallAttack.FWallAttackStageInfo WallAttackStage
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RStealthTakeDownStage_GlassWallAttack.FWallAttackStageInfo>(Ptr + 1256);
}
