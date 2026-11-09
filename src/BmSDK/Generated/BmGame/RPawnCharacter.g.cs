#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RPawnCharacter<br/>
/// (size = 1904)
/// (flags = 142606519)
/// </summary>
public partial class RPawnCharacter : BmSDK.BmGame.RPawn, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnCharacter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnCharacter.
    /// </summary>
    public static RPawnCharacter DefaultObject => (RPawnCharacter)StaticClass().DefaultObject;

    internal RPawnCharacter() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnCharacter(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnCharacter>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnCharacter>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnCharacter>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnCharacter>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnCharacter>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnCharacter>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnCharacter>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnCharacter>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_IsNavMeshClearOfObstacles;
    /// <summary>
    /// Function: IsNavMeshClearOfObstacles
    /// </summary>
    public unsafe virtual bool IsNavMeshClearOfObstacles(System.Numerics.Vector3 StartPoint, System.Numerics.Vector3 TestPoint, System.Numerics.Vector3 TestExtent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsNavMeshClearOfObstacles, "BmGame.RPawnCharacter.IsNavMeshClearOfObstacles");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPoint, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestExtent, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_NavMeshPointReachable;
    /// <summary>
    /// Function: NavMeshPointReachable
    /// </summary>
    public unsafe virtual bool NavMeshPointReachable(System.Numerics.Vector3 TestPoint, out System.Numerics.Vector3 HitLocation, out System.Numerics.Vector3 HitNormal, bool bCheckForFloor = default, System.Numerics.Vector3 OverrideStartLocation = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NavMeshPointReachable, "BmGame.RPawnCharacter.NavMeshPointReachable");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPoint, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheckForFloor, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideStartLocation, paramsPtr + 40);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HitLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        HitNormal = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 52);
    }

    private static BmSDK.Function __fn_FaceRotation;
    /// <summary>
    /// Function: FaceRotation
    /// </summary>
    public unsafe override void FaceRotation(BmSDK.Rotator NewRotation, float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FaceRotation, "BmGame.RPawnCharacter.FaceRotation");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRotation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnPossessed;
    /// <summary>
    /// Function: UnPossessed
    /// </summary>
    public unsafe override void UnPossessed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnPossessed, "BmGame.RPawnCharacter.UnPossessed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Died;
    /// <summary>
    /// Function: Died
    /// </summary>
    public unsafe override bool Died(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Died, "BmGame.RPawnCharacter.Died");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_MatineeTeleport;
    /// <summary>
    /// Function: MatineeTeleport
    /// </summary>
    public unsafe virtual void MatineeTeleport()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MatineeTeleport, "BmGame.RPawnCharacter.MatineeTeleport");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_UpdateMatineeMovementTarget;
    /// <summary>
    /// Function: UpdateMatineeMovementTarget
    /// </summary>
    public unsafe virtual void UpdateMatineeMovementTarget(System.Numerics.Vector3 TargetLocation, BmSDK.Rotator TargetRotation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateMatineeMovementTarget, "BmGame.RPawnCharacter.UpdateMatineeMovementTarget");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetRotation, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_FinishAnimControl;
    /// <summary>
    /// Function: FinishAnimControl
    /// </summary>
    public unsafe override void FinishAnimControl(BmSDK.Engine.InterpGroup InInterpGroup)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishAnimControl, "BmGame.RPawnCharacter.FinishAnimControl");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BlendOutAnimControl;
    /// <summary>
    /// Function: BlendOutAnimControl
    /// </summary>
    public unsafe override void BlendOutAnimControl(BmSDK.Engine.InterpGroup InInterpGroup)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlendOutAnimControl, "BmGame.RPawnCharacter.BlendOutAnimControl");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAnimPosition;
    /// <summary>
    /// Function: SetAnimPosition
    /// </summary>
    public unsafe override void SetAnimPosition(BmSDK.FName SlotName, int ChannelIndex, BmSDK.FName InAnimSeqName, float InPosition, bool bFireNotifies, bool bLooping, bool bEnableRootMotion)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAnimPosition, "BmGame.RPawnCharacter.SetAnimPosition");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChannelIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InAnimSeqName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPosition, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFireNotifies, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLooping, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableRootMotion, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeginAnimControl;
    /// <summary>
    /// Function: BeginAnimControl
    /// </summary>
    public unsafe override void BeginAnimControl(BmSDK.Engine.InterpGroup InInterpGroup)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginAnimControl, "BmGame.RPawnCharacter.BeginAnimControl");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHasConstrainingComponent;
    /// <summary>
    /// Function: SetHasConstrainingComponent
    /// </summary>
    public unsafe virtual void SetHasConstrainingComponent(bool bHasConstrainingComponent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHasConstrainingComponent, "BmGame.RPawnCharacter.SetHasConstrainingComponent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHasConstrainingComponent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostInitCharacter;
    /// <summary>
    /// Function: PostInitCharacter
    /// </summary>
    public unsafe virtual void PostInitCharacter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostInitCharacter, "BmGame.RPawnCharacter.PostInitCharacter");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupCustomPhysics;
    /// <summary>
    /// Function: SetupCustomPhysics
    /// </summary>
    public unsafe virtual void SetupCustomPhysics()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupCustomPhysics, "BmGame.RPawnCharacter.SetupCustomPhysics");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RPawnCharacter.Destroyed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDry;
    /// <summary>
    /// Function: SetDry
    /// </summary>
    public unsafe override void SetDry()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDry, "BmGame.RPawnCharacter.SetDry");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetWet;
    /// <summary>
    /// Function: SetWet
    /// </summary>
    public unsafe override void SetWet(BmSDK.BmGame.RWaterVolumeBase Water)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWet, "BmGame.RPawnCharacter.SetWet");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Water, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetWetShallow;
    /// <summary>
    /// Function: SetWetShallow
    /// </summary>
    public unsafe override void SetWetShallow(float Amount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWetShallow, "BmGame.RPawnCharacter.SetWetShallow");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Amount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BorrowLightingFrom;
    /// <summary>
    /// Function: BorrowLightingFrom
    /// </summary>
    public unsafe virtual void BorrowLightingFrom(BmSDK.BmGame.RPawnCharacter Other)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BorrowLightingFrom, "BmGame.RPawnCharacter.BorrowLightingFrom");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetYawRadians;
    /// <summary>
    /// Function: SetYawRadians
    /// </summary>
    public unsafe virtual void SetYawRadians(float R)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetYawRadians, "BmGame.RPawnCharacter.SetYawRadians");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_AnimationTriggerCallback;
    /// <summary>
    /// Function: AnimationTriggerCallback
    /// </summary>
    public unsafe override void AnimationTriggerCallback(BmSDK.FName TagName, BmSDK.TArray<BmSDK.FString> Params, BmSDK.Engine.AnimSet TagAnimSet, float Time)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnimationTriggerCallback, "BmGame.RPawnCharacter.AnimationTriggerCallback");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TagName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Params, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TagAnimSet, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayActorFaceFXAnim;
    /// <summary>
    /// Function: PlayActorFaceFXAnim
    /// </summary>
    public unsafe override bool PlayActorFaceFXAnim(BmSDK.Engine.FaceFXAnimSet AnimSet, BmSDK.FString GroupName, BmSDK.FString SeqName, BmSDK.Engine.RDialogueEvent DialogueEvent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayActorFaceFXAnim, "BmGame.RPawnCharacter.PlayActorFaceFXAnim");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GroupName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SeqName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueEvent, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_DoRBFallAlert;
    /// <summary>
    /// Function: DoRBFallAlert
    /// </summary>
    public unsafe virtual void DoRBFallAlert()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoRBFallAlert, "BmGame.RPawnCharacter.DoRBFallAlert");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnBreatheOut;
    /// <summary>
    /// Function: OnBreatheOut
    /// </summary>
    public unsafe virtual void OnBreatheOut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBreatheOut, "BmGame.RPawnCharacter.OnBreatheOut");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnBreatheIn;
    /// <summary>
    /// Function: OnBreatheIn
    /// </summary>
    public unsafe virtual void OnBreatheIn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBreatheIn, "BmGame.RPawnCharacter.OnBreatheIn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RigidBodyCollision;
    /// <summary>
    /// Function: RigidBodyCollision
    /// </summary>
    public unsafe override void RigidBodyCollision(BmSDK.Engine.PrimitiveComponent HitComponent, BmSDK.Engine.PrimitiveComponent OtherComponent, in BmSDK.Engine.Actor.FCollisionImpactData RigidCollisionData, int ContactIndex, float Speed, int Index0, int Index1)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RigidBodyCollision, "BmGame.RPawnCharacter.RigidBodyCollision");
        byte* paramsPtr = stackalloc byte[132];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitComponent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComponent, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RigidCollisionData, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContactIndex, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index0, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index1, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetOverrideGetUpBackward;
    /// <summary>
    /// Function: GetOverrideGetUpBackward
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FTransitionId GetOverrideGetUpBackward(BmSDK.FName MovementStance, BmSDK.FName WeaponStance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOverrideGetUpBackward, "BmGame.RPawnCharacter.GetOverrideGetUpBackward");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetOverrideGetUpFwd;
    /// <summary>
    /// Function: GetOverrideGetUpFwd
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FTransitionId GetOverrideGetUpFwd(BmSDK.FName MovementStance, BmSDK.FName WeaponStance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOverrideGetUpFwd, "BmGame.RPawnCharacter.GetOverrideGetUpFwd");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_FinishedGetUp;
    /// <summary>
    /// Function: FinishedGetUp
    /// </summary>
    public unsafe virtual void FinishedGetUp()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishedGetUp, "BmGame.RPawnCharacter.FinishedGetUp");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateSnowOnLegs;
    /// <summary>
    /// Function: UpdateSnowOnLegs
    /// </summary>
    public unsafe virtual void UpdateSnowOnLegs(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateSnowOnLegs, "BmGame.RPawnCharacter.UpdateSnowOnLegs");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldPutSnowOnLegs;
    /// <summary>
    /// Function: ShouldPutSnowOnLegs
    /// </summary>
    public unsafe virtual bool ShouldPutSnowOnLegs()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldPutSnowOnLegs, "BmGame.RPawnCharacter.ShouldPutSnowOnLegs");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RPawnCharacter.Tick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSnowOnLegsTimeIdle;
    /// <summary>
    /// Function: GetSnowOnLegsTimeIdle
    /// </summary>
    public unsafe virtual float GetSnowOnLegsTimeIdle()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSnowOnLegsTimeIdle, "BmGame.RPawnCharacter.GetSnowOnLegsTimeIdle");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSnowOnLegsTimeIn;
    /// <summary>
    /// Function: GetSnowOnLegsTimeIn
    /// </summary>
    public unsafe virtual float GetSnowOnLegsTimeIn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSnowOnLegsTimeIn, "BmGame.RPawnCharacter.GetSnowOnLegsTimeIn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSnowOnLegsTimeOut;
    /// <summary>
    /// Function: GetSnowOnLegsTimeOut
    /// </summary>
    public unsafe virtual float GetSnowOnLegsTimeOut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSnowOnLegsTimeOut, "BmGame.RPawnCharacter.GetSnowOnLegsTimeOut");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetForceGetUpTime;
    /// <summary>
    /// Function: GetForceGetUpTime
    /// </summary>
    public unsafe virtual float GetForceGetUpTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetForceGetUpTime, "BmGame.RPawnCharacter.GetForceGetUpTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CancelGetUpFromRagdoll;
    /// <summary>
    /// Function: CancelGetUpFromRagdoll
    /// </summary>
    public unsafe virtual void CancelGetUpFromRagdoll()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelGetUpFromRagdoll, "BmGame.RPawnCharacter.CancelGetUpFromRagdoll");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsGettingUpFromRagdoll;
    /// <summary>
    /// Function: IsGettingUpFromRagdoll
    /// </summary>
    public unsafe virtual bool IsGettingUpFromRagdoll()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsGettingUpFromRagdoll, "BmGame.RPawnCharacter.IsGettingUpFromRagdoll");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StartGetUp;
    /// <summary>
    /// Function: StartGetUp
    /// </summary>
    public unsafe virtual void StartGetUp()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartGetUp, "BmGame.RPawnCharacter.StartGetUp");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetUpFromRagdoll;
    /// <summary>
    /// Function: GetUpFromRagdoll
    /// </summary>
    public unsafe virtual void GetUpFromRagdoll(BmSDK.FName TargetMovementStance, BmSDK.FName TargetWeaponStance, BmSDK.FName ForceGetupTransition = default, bool ForceGetup = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUpFromRagdoll, "BmGame.RPawnCharacter.GetUpFromRagdoll");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetMovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetWeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceGetupTransition, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceGetup, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetChangeMirroringNotifier;
    /// <summary>
    /// Function: GetChangeMirroringNotifier
    /// </summary>
    public unsafe virtual bool GetChangeMirroringNotifier()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChangeMirroringNotifier, "BmGame.RPawnCharacter.GetChangeMirroringNotifier");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsStrungUp;
    /// <summary>
    /// Function: IsStrungUp
    /// </summary>
    public unsafe virtual bool IsStrungUp()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsStrungUp, "BmGame.RPawnCharacter.IsStrungUp");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldSpeedUpGetUp;
    /// <summary>
    /// Function: ShouldSpeedUpGetUp
    /// </summary>
    public unsafe virtual bool ShouldSpeedUpGetUp()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldSpeedUpGetUp, "BmGame.RPawnCharacter.ShouldSpeedUpGetUp");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnPlayedQueuedTransition;
    /// <summary>
    /// Function: OnPlayedQueuedTransition
    /// </summary>
    public unsafe virtual void OnPlayedQueuedTransition(BmSDK.BmGame.RAnimUtil.FTransitionId Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPlayedQueuedTransition, "BmGame.RPawnCharacter.OnPlayedQueuedTransition");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WeaponSwitchCallback;
    /// <summary>
    /// Function: WeaponSwitchCallback
    /// </summary>
    public unsafe virtual void WeaponSwitchCallback(BmSDK.Engine.Inventory NewWeapon, BmSDK.Engine.Inventory PreviousWeapon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponSwitchCallback, "BmGame.RPawnCharacter.WeaponSwitchCallback");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousWeapon, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheatFly;
    /// <summary>
    /// Function: CheatFly
    /// </summary>
    public unsafe override bool CheatFly()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheatFly, "BmGame.RPawnCharacter.CheatFly");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheatGhost;
    /// <summary>
    /// Function: CheatGhost
    /// </summary>
    public unsafe override bool CheatGhost()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheatGhost, "BmGame.RPawnCharacter.CheatGhost");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheatWalk;
    /// <summary>
    /// Function: CheatWalk
    /// </summary>
    public unsafe override bool CheatWalk()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheatWalk, "BmGame.RPawnCharacter.CheatWalk");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CombineWeaponConfigs;
    /// <summary>
    /// Function: CombineWeaponConfigs
    /// </summary>
    public unsafe static BmSDK.BmGame.RWeaponConfig CombineWeaponConfigs(BmSDK.GameObject NewOwner, BmSDK.BmGame.RWeaponConfig Config1, BmSDK.BmGame.RWeaponConfig Config2, BmSDK.BmGame.RWeaponConfig Config3 = default, BmSDK.BmGame.RWeaponConfig Config4 = default, BmSDK.BmGame.RWeaponConfig Config5 = default, BmSDK.BmGame.RWeaponConfig Config6 = default, BmSDK.BmGame.RWeaponConfig Config7 = default, BmSDK.BmGame.RWeaponConfig Config8 = default, BmSDK.BmGame.RWeaponConfig Config9 = default, BmSDK.BmGame.RWeaponConfig Config10 = default, BmSDK.BmGame.RWeaponConfig Config11 = default, BmSDK.BmGame.RWeaponConfig Config12 = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombineWeaponConfigs, "BmGame.RPawnCharacter.CombineWeaponConfigs");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config1, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config2, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config3, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config4, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config5, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config6, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config7, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config8, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config9, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config10, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config11, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config12, paramsPtr + 48);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 52);
    }

    private static BmSDK.Function __fn_SetAnimTimeScale;
    /// <summary>
    /// Function: SetAnimTimeScale
    /// </summary>
    public unsafe virtual void SetAnimTimeScale(float Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAnimTimeScale, "BmGame.RPawnCharacter.SetAnimTimeScale");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DisableAnimTick;
    /// <summary>
    /// Function: DisableAnimTick
    /// </summary>
    public unsafe virtual void DisableAnimTick(bool Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableAnimTick, "BmGame.RPawnCharacter.DisableAnimTick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_IsRagdoll;
    /// <summary>
    /// Function: IsRagdoll
    /// </summary>
    public unsafe virtual bool IsRagdoll()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRagdoll, "BmGame.RPawnCharacter.IsRagdoll");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ChangeRagdollMotorWeight;
    /// <summary>
    /// Function: ChangeRagdollMotorWeight
    /// </summary>
    public unsafe virtual void ChangeRagdollMotorWeight(BmSDK.FName Description, float NewWeight, float BlendDuration = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeRagdollMotorWeight, "BmGame.RPawnCharacter.ChangeRagdollMotorWeight");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeight, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendDuration, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_ResetRagdoll;
    /// <summary>
    /// Function: ResetRagdoll
    /// </summary>
    public unsafe virtual void ResetRagdoll()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetRagdoll, "BmGame.RPawnCharacter.ResetRagdoll");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_PopRagdoll;
    /// <summary>
    /// Function: PopRagdoll
    /// </summary>
    public unsafe virtual void PopRagdoll(BmSDK.FName Description)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopRagdoll, "BmGame.RPawnCharacter.PopRagdoll");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_PushRagdollOff;
    /// <summary>
    /// Function: PushRagdollOff
    /// </summary>
    public unsafe virtual void PushRagdollOff(BmSDK.FName Description)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushRagdollOff, "BmGame.RPawnCharacter.PushRagdollOff");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_PushRagdollOn;
    /// <summary>
    /// Function: PushRagdollOn
    /// </summary>
    public unsafe virtual void PushRagdollOn(BmSDK.FName Description, float MotorWeight = default, float BlendInDuration = default, float BlendOutDuration = default, BmSDK.TArray<BmSDK.FName> FixedBodies = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushRagdollOn, "BmGame.RPawnCharacter.PushRagdollOn");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MotorWeight, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendInDuration, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendOutDuration, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FixedBodies, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_SnapFloorCorrection;
    /// <summary>
    /// Function: SnapFloorCorrection
    /// </summary>
    public unsafe virtual void SnapFloorCorrection()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SnapFloorCorrection, "BmGame.RPawnCharacter.SnapFloorCorrection");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_GetMoveToPhaseTime;
    /// <summary>
    /// Function: GetMoveToPhaseTime
    /// </summary>
    public unsafe virtual float GetMoveToPhaseTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMoveToPhaseTime, "BmGame.RPawnCharacter.GetMoveToPhaseTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMoveToPhase;
    /// <summary>
    /// Function: GetMoveToPhase
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.EFootSyncPoint GetMoveToPhase()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMoveToPhase, "BmGame.RPawnCharacter.GetMoveToPhase");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.EFootSyncPoint>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFixedAnimThoughts;
    /// <summary>
    /// Function: GetFixedAnimThoughts
    /// </summary>
    public unsafe virtual void GetFixedAnimThoughts(BmSDK.BmGame.RPersistentDebugData.FPerCharacterTypeAnimDebug Options, out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFixedAnimThoughts, "BmGame.RPawnCharacter.GetFixedAnimThoughts");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Options, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 36);
        return;
    }

    private static BmSDK.Function __fn_GetAnimThoughts;
    /// <summary>
    /// Function: GetAnimThoughts
    /// </summary>
    public unsafe virtual void GetAnimThoughts(BmSDK.BmGame.RPersistentDebugData.FPerCharacterTypeAnimDebug Options, out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnimThoughts, "BmGame.RPawnCharacter.GetAnimThoughts");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Options, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 36);
        return;
    }

    private static BmSDK.Function __fn_SetIdleTimeScale;
    /// <summary>
    /// Function: SetIdleTimeScale
    /// </summary>
    public unsafe virtual void SetIdleTimeScale(float NewValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIdleTimeScale, "BmGame.RPawnCharacter.SetIdleTimeScale");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewValue, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_IsFallingOrLanding;
    /// <summary>
    /// Function: IsFallingOrLanding
    /// </summary>
    public unsafe virtual bool IsFallingOrLanding()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFallingOrLanding, "BmGame.RPawnCharacter.IsFallingOrLanding");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsFalling;
    /// <summary>
    /// Function: IsFalling
    /// </summary>
    public unsafe virtual bool IsFalling()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFalling, "BmGame.RPawnCharacter.IsFalling");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OverrideYawVelocity;
    /// <summary>
    /// Function: OverrideYawVelocity
    /// </summary>
    public unsafe virtual void OverrideYawVelocity(float YawVelocity)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideYawVelocity, "BmGame.RPawnCharacter.OverrideYawVelocity");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(YawVelocity, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_OverrideTranslationVelocity;
    /// <summary>
    /// Function: OverrideTranslationVelocity
    /// </summary>
    public unsafe virtual void OverrideTranslationVelocity(System.Numerics.Vector3 TranslationVelocity)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideTranslationVelocity, "BmGame.RPawnCharacter.OverrideTranslationVelocity");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TranslationVelocity, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_AddYaw;
    /// <summary>
    /// Function: AddYaw
    /// </summary>
    public unsafe virtual void AddYaw(float Yaw)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddYaw, "BmGame.RPawnCharacter.AddYaw");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Yaw, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_AddYawVelocity;
    /// <summary>
    /// Function: AddYawVelocity
    /// </summary>
    public unsafe virtual void AddYawVelocity(float YawVelocity)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddYawVelocity, "BmGame.RPawnCharacter.AddYawVelocity");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(YawVelocity, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_AddTranslation;
    /// <summary>
    /// Function: AddTranslation
    /// </summary>
    public unsafe virtual void AddTranslation(System.Numerics.Vector3 Translation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddTranslation, "BmGame.RPawnCharacter.AddTranslation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Translation, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_AddTranslationVelocity;
    /// <summary>
    /// Function: AddTranslationVelocity
    /// </summary>
    public unsafe virtual void AddTranslationVelocity(System.Numerics.Vector3 TranslationVelocity)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddTranslationVelocity, "BmGame.RPawnCharacter.AddTranslationVelocity");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TranslationVelocity, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_GetLegDirection;
    /// <summary>
    /// Function: GetLegDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetLegDirection()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLegDirection, "BmGame.RPawnCharacter.GetLegDirection");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFaceAtDirection;
    /// <summary>
    /// Function: GetFaceAtDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetFaceAtDirection()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFaceAtDirection, "BmGame.RPawnCharacter.GetFaceAtDirection");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopFaceAt;
    /// <summary>
    /// Function: StopFaceAt
    /// </summary>
    public unsafe virtual void StopFaceAt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopFaceAt, "BmGame.RPawnCharacter.StopFaceAt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_FaceAtActor;
    /// <summary>
    /// Function: FaceAtActor
    /// </summary>
    public unsafe virtual void FaceAtActor(BmSDK.Engine.Actor Actor, BmSDK.FName ActorBoneName = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FaceAtActor, "BmGame.RPawnCharacter.FaceAtActor");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Actor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorBoneName, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_FaceInDirection;
    /// <summary>
    /// Function: FaceInDirection
    /// </summary>
    public unsafe virtual void FaceInDirection(System.Numerics.Vector3 Direction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FaceInDirection, "BmGame.RPawnCharacter.FaceInDirection");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_FaceAt;
    /// <summary>
    /// Function: FaceAt
    /// </summary>
    public unsafe virtual void FaceAt(System.Numerics.Vector3 Position)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FaceAt, "BmGame.RPawnCharacter.FaceAt");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_StopLookAt;
    /// <summary>
    /// Function: StopLookAt
    /// </summary>
    public unsafe virtual void StopLookAt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopLookAt, "BmGame.RPawnCharacter.StopLookAt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_LookAtActor;
    /// <summary>
    /// Function: LookAtActor
    /// </summary>
    public unsafe virtual void LookAtActor(BmSDK.Engine.Actor Actor, BmSDK.FName ActorBoneName = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LookAtActor, "BmGame.RPawnCharacter.LookAtActor");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Actor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorBoneName, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_LookInDirection;
    /// <summary>
    /// Function: LookInDirection
    /// </summary>
    public unsafe virtual void LookInDirection(System.Numerics.Vector3 Direction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LookInDirection, "BmGame.RPawnCharacter.LookInDirection");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_LookAt;
    /// <summary>
    /// Function: LookAt
    /// </summary>
    public unsafe virtual void LookAt(System.Numerics.Vector3 Position)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LookAt, "BmGame.RPawnCharacter.LookAt");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_GetHeadRotationWithoutProceduralAiming;
    /// <summary>
    /// Function: GetHeadRotationWithoutProceduralAiming
    /// </summary>
    public unsafe virtual BmSDK.Rotator GetHeadRotationWithoutProceduralAiming()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeadRotationWithoutProceduralAiming, "BmGame.RPawnCharacter.GetHeadRotationWithoutProceduralAiming");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHeadPositionWithoutProceduralAiming;
    /// <summary>
    /// Function: GetHeadPositionWithoutProceduralAiming
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetHeadPositionWithoutProceduralAiming()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeadPositionWithoutProceduralAiming, "BmGame.RPawnCharacter.GetHeadPositionWithoutProceduralAiming");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetActualAimAtDirection;
    /// <summary>
    /// Function: GetActualAimAtDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetActualAimAtDirection()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActualAimAtDirection, "BmGame.RPawnCharacter.GetActualAimAtDirection");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTargetAimAtDirection;
    /// <summary>
    /// Function: GetTargetAimAtDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetTargetAimAtDirection()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargetAimAtDirection, "BmGame.RPawnCharacter.GetTargetAimAtDirection");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SnapAimAt;
    /// <summary>
    /// Function: SnapAimAt
    /// </summary>
    public unsafe virtual void SnapAimAt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SnapAimAt, "BmGame.RPawnCharacter.SnapAimAt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_StopAimAt;
    /// <summary>
    /// Function: StopAimAt
    /// </summary>
    public unsafe virtual void StopAimAt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAimAt, "BmGame.RPawnCharacter.StopAimAt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_AimAtActor;
    /// <summary>
    /// Function: AimAtActor
    /// </summary>
    public unsafe virtual void AimAtActor(BmSDK.Engine.Actor Actor, BmSDK.FName Description = default, BmSDK.FName ActorBoneName = default, BmSDK.BmGame.RAnimConfig.EYesNoDefault AllowTurningToAim = default, float LimitScale = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AimAtActor, "BmGame.RPawnCharacter.AimAtActor");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Actor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorBoneName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AllowTurningToAim, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LimitScale, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_AimInDirection;
    /// <summary>
    /// Function: AimInDirection
    /// </summary>
    public unsafe virtual void AimInDirection(System.Numerics.Vector3 Direction, BmSDK.FName Description = default, BmSDK.BmGame.RAnimConfig.EYesNoDefault AllowTurningToAim = default, float LimitScale = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AimInDirection, "BmGame.RPawnCharacter.AimInDirection");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AllowTurningToAim, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LimitScale, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_AimAt;
    /// <summary>
    /// Function: AimAt
    /// </summary>
    public unsafe virtual void AimAt(System.Numerics.Vector3 Position, BmSDK.FName Description = default, BmSDK.BmGame.RAnimConfig.EYesNoDefault AllowTurningToAim = default, float LimitScale = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AimAt, "BmGame.RPawnCharacter.AimAt");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AllowTurningToAim, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LimitScale, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_GetMoveToDirection;
    /// <summary>
    /// Function: GetMoveToDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetMoveToDirection()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMoveToDirection, "BmGame.RPawnCharacter.GetMoveToDirection");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InstantStopMoveTo;
    /// <summary>
    /// Function: InstantStopMoveTo
    /// </summary>
    public unsafe virtual void InstantStopMoveTo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InstantStopMoveTo, "BmGame.RPawnCharacter.InstantStopMoveTo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_StopMoveTo;
    /// <summary>
    /// Function: StopMoveTo
    /// </summary>
    public unsafe virtual void StopMoveTo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopMoveTo, "BmGame.RPawnCharacter.StopMoveTo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_MoveInDirection;
    /// <summary>
    /// Function: MoveInDirection
    /// </summary>
    public unsafe virtual bool MoveInDirection(System.Numerics.Vector3 Direction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveInDirection, "BmGame.RPawnCharacter.MoveInDirection");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_MoveTo;
    /// <summary>
    /// Function: MoveTo
    /// </summary>
    public unsafe virtual void MoveTo(System.Numerics.Vector3 Position)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveTo, "BmGame.RPawnCharacter.MoveTo");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_PlayOneShotMovementCycle;
    /// <summary>
    /// Function: PlayOneShotMovementCycle
    /// </summary>
    public unsafe virtual void PlayOneShotMovementCycle(BmSDK.BmGame.RAnimConfig.FCustomAnimConfig AnimConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayOneShotMovementCycle, "BmGame.RPawnCharacter.PlayOneShotMovementCycle");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimConfig, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_SetMovementSpeed;
    /// <summary>
    /// Function: SetMovementSpeed
    /// </summary>
    public unsafe virtual void SetMovementSpeed(BmSDK.BmGame.RPoseConfig.EMovementSpeed NewSpeed, float NewSpeedScale = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMovementSpeed, "BmGame.RPawnCharacter.SetMovementSpeed");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSpeed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSpeedScale, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_StopAllOverlaysInstantly;
    /// <summary>
    /// Function: StopAllOverlaysInstantly
    /// </summary>
    public unsafe virtual void StopAllOverlaysInstantly()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAllOverlaysInstantly, "BmGame.RPawnCharacter.StopAllOverlaysInstantly");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_StopAllOverlays;
    /// <summary>
    /// Function: StopAllOverlays
    /// </summary>
    public unsafe virtual void StopAllOverlays()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAllOverlays, "BmGame.RPawnCharacter.StopAllOverlays");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_StopAdditiveOverlay;
    /// <summary>
    /// Function: StopAdditiveOverlay
    /// </summary>
    public unsafe virtual void StopAdditiveOverlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAdditiveOverlay, "BmGame.RPawnCharacter.StopAdditiveOverlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_StopIdleOverlay;
    /// <summary>
    /// Function: StopIdleOverlay
    /// </summary>
    public unsafe virtual void StopIdleOverlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopIdleOverlay, "BmGame.RPawnCharacter.StopIdleOverlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_StopWeaponOverlay;
    /// <summary>
    /// Function: StopWeaponOverlay
    /// </summary>
    public unsafe virtual void StopWeaponOverlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopWeaponOverlay, "BmGame.RPawnCharacter.StopWeaponOverlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_IsPlayingAnyOverlay;
    /// <summary>
    /// Function: IsPlayingAnyOverlay
    /// </summary>
    public unsafe virtual bool IsPlayingAnyOverlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPlayingAnyOverlay, "BmGame.RPawnCharacter.IsPlayingAnyOverlay");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsPlayingOverlay;
    /// <summary>
    /// Function: IsPlayingOverlay
    /// </summary>
    public unsafe virtual bool IsPlayingOverlay(BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPlayingOverlay, "BmGame.RPawnCharacter.IsPlayingOverlay");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PlayCustomAdditiveOverlay;
    /// <summary>
    /// Function: PlayCustomAdditiveOverlay
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId PlayCustomAdditiveOverlay(BmSDK.BmGame.RAnimConfig.FCustomAdditiveAnimConfig OverrideAnim, float StartTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCustomAdditiveOverlay, "BmGame.RPawnCharacter.PlayCustomAdditiveOverlay");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideAnim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartTime, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_PlayCustomIdleOverlay;
    /// <summary>
    /// Function: PlayCustomIdleOverlay
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId PlayCustomIdleOverlay(BmSDK.BmGame.RAnimConfig.FCustomAnimConfig OverrideAnim, float StartTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCustomIdleOverlay, "BmGame.RPawnCharacter.PlayCustomIdleOverlay");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideAnim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartTime, paramsPtr + 40);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_PlayIdleOverlay;
    /// <summary>
    /// Function: PlayIdleOverlay
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId PlayIdleOverlay(BmSDK.FName OverlayName, float StartTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayIdleOverlay, "BmGame.RPawnCharacter.PlayIdleOverlay");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverlayName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartTime, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_PlayCustomWeaponOverlay;
    /// <summary>
    /// Function: PlayCustomWeaponOverlay
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId PlayCustomWeaponOverlay(BmSDK.BmGame.RAnimConfig.FCustomAnimConfig OverrideAnim, float StartTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCustomWeaponOverlay, "BmGame.RPawnCharacter.PlayCustomWeaponOverlay");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideAnim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartTime, paramsPtr + 40);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_PlayWeaponOverlay;
    /// <summary>
    /// Function: PlayWeaponOverlay
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId PlayWeaponOverlay(BmSDK.FName OverlayName, float StartTime = default, bool Loop = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayWeaponOverlay, "BmGame.RPawnCharacter.PlayWeaponOverlay");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverlayName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartTime, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loop, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetTransitionAnimFromCurrent;
    /// <summary>
    /// Function: GetTransitionAnimFromCurrent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSequence GetTransitionAnimFromCurrent(BmSDK.FName ToMovementStance, BmSDK.FName ToWeaponStance, BmSDK.FName ToIdleStance, bool ToMirrored = default, BmSDK.FName TransitionName = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTransitionAnimFromCurrent, "BmGame.RPawnCharacter.GetTransitionAnimFromCurrent");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToMovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToWeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToIdleStance, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToMirrored, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSequence>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_GetTransitionDominantAnim;
    /// <summary>
    /// Function: GetTransitionDominantAnim
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSequence GetTransitionDominantAnim(BmSDK.BmGame.RAnimUtil.FTransitionId Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTransitionDominantAnim, "BmGame.RPawnCharacter.GetTransitionDominantAnim");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSequence>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetTransitionDuration;
    /// <summary>
    /// Function: SetTransitionDuration
    /// </summary>
    public unsafe virtual void SetTransitionDuration(BmSDK.BmGame.RAnimUtil.FTransitionId Id, float NewDuration)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTransitionDuration, "BmGame.RPawnCharacter.SetTransitionDuration");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDuration, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_GetTransitionDuration;
    /// <summary>
    /// Function: GetTransitionDuration
    /// </summary>
    public unsafe virtual float GetTransitionDuration(BmSDK.BmGame.RAnimUtil.FTransitionId Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTransitionDuration, "BmGame.RPawnCharacter.GetTransitionDuration");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetTransitionTimeInSeconds;
    /// <summary>
    /// Function: GetTransitionTimeInSeconds
    /// </summary>
    public unsafe virtual float GetTransitionTimeInSeconds(BmSDK.BmGame.RAnimUtil.FTransitionId Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTransitionTimeInSeconds, "BmGame.RPawnCharacter.GetTransitionTimeInSeconds");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetTransitionNormalizedTime;
    /// <summary>
    /// Function: GetTransitionNormalizedTime
    /// </summary>
    public unsafe virtual float GetTransitionNormalizedTime(BmSDK.BmGame.RAnimUtil.FTransitionId Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTransitionNormalizedTime, "BmGame.RPawnCharacter.GetTransitionNormalizedTime");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsHeadTransition;
    /// <summary>
    /// Function: IsHeadTransition
    /// </summary>
    public unsafe virtual bool IsHeadTransition(BmSDK.BmGame.RAnimUtil.FTransitionId Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsHeadTransition, "BmGame.RPawnCharacter.IsHeadTransition");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HasTransition;
    /// <summary>
    /// Function: HasTransition
    /// </summary>
    public unsafe virtual bool HasTransition(BmSDK.BmGame.RAnimUtil.FTransitionId Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasTransition, "BmGame.RPawnCharacter.HasTransition");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_WillBeInTransition;
    /// <summary>
    /// Function: WillBeInTransition
    /// </summary>
    public unsafe virtual bool WillBeInTransition(BmSDK.BmGame.RAnimUtil.FTransitionId Id, float DeltaSeconds, BmSDK.BmGame.RAnimUtil.EFuzziness Fuzziness = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WillBeInTransition, "BmGame.RPawnCharacter.WillBeInTransition");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaSeconds, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fuzziness, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_IsInTransition;
    /// <summary>
    /// Function: IsInTransition
    /// </summary>
    public unsafe virtual bool IsInTransition(BmSDK.BmGame.RAnimUtil.FTransitionId Id, BmSDK.BmGame.RAnimUtil.EFuzziness Fuzziness = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInTransition, "BmGame.RPawnCharacter.IsInTransition");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fuzziness, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsInAnyNonAutomaticTransition;
    /// <summary>
    /// Function: IsInAnyNonAutomaticTransition
    /// </summary>
    public unsafe virtual bool IsInAnyNonAutomaticTransition(BmSDK.BmGame.RAnimUtil.EFuzziness Fuzziness = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInAnyNonAutomaticTransition, "BmGame.RPawnCharacter.IsInAnyNonAutomaticTransition");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fuzziness, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsInAnyAutomaticTransition;
    /// <summary>
    /// Function: IsInAnyAutomaticTransition
    /// </summary>
    public unsafe virtual bool IsInAnyAutomaticTransition(BmSDK.BmGame.RAnimUtil.EFuzziness Fuzziness, out BmSDK.BmGame.RAnimUtil.FTransitionId Transition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInAnyAutomaticTransition, "BmGame.RPawnCharacter.IsInAnyAutomaticTransition");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fuzziness, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Transition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Transition, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Transition = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsInAnyTransition;
    /// <summary>
    /// Function: IsInAnyTransition
    /// </summary>
    public unsafe virtual bool IsInAnyTransition(BmSDK.BmGame.RAnimUtil.EFuzziness Fuzziness = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInAnyTransition, "BmGame.RPawnCharacter.IsInAnyTransition");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fuzziness, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsInWeaponTransition;
    /// <summary>
    /// Function: IsInWeaponTransition
    /// </summary>
    public unsafe virtual bool IsInWeaponTransition()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInWeaponTransition, "BmGame.RPawnCharacter.IsInWeaponTransition");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsPoseMirrored;
    /// <summary>
    /// Function: IsPoseMirrored
    /// </summary>
    public unsafe virtual bool IsPoseMirrored()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPoseMirrored, "BmGame.RPawnCharacter.IsPoseMirrored");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FakeTickTransitionTime;
    /// <summary>
    /// Function: FakeTickTransitionTime
    /// </summary>
    public unsafe virtual void FakeTickTransitionTime(float NormalizedTime, int DisableTimeAdvanceForNumFrames = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FakeTickTransitionTime, "BmGame.RPawnCharacter.FakeTickTransitionTime");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NormalizedTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DisableTimeAdvanceForNumFrames, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_OverrideTransitionTime;
    /// <summary>
    /// Function: OverrideTransitionTime
    /// </summary>
    public unsafe virtual void OverrideTransitionTime(float NormalizedTime, int DisableTimeAdvanceForNumFrames = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideTransitionTime, "BmGame.RPawnCharacter.OverrideTransitionTime");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NormalizedTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DisableTimeAdvanceForNumFrames, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_ChangePoseOverTime;
    /// <summary>
    /// Function: ChangePoseOverTime
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FTransitionId ChangePoseOverTime(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, float Time, bool bMirrored = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangePoseOverTime, "BmGame.RPawnCharacter.ChangePoseOverTime");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMirrored, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_ChangeWeapon;
    /// <summary>
    /// Function: ChangeWeapon
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FTransitionId ChangeWeapon(BmSDK.Engine.Inventory NewWeapon, BmSDK.Engine.Inventory NewTransitionWeapon, bool bForce = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeWeapon, "BmGame.RPawnCharacter.ChangeWeapon");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTransitionWeapon, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForce, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ChangePoseNoDataWeightIfNotHead;
    /// <summary>
    /// Function: ChangePoseNoDataWeightIfNotHead
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FTransitionId ChangePoseNoDataWeightIfNotHead(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, BmSDK.FName TransitionName = default, bool bMirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangePoseNoDataWeightIfNotHead, "BmGame.RPawnCharacter.ChangePoseNoDataWeightIfNotHead");
        byte* paramsPtr = stackalloc byte[136];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMirrored, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 68);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 108);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 112);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 116);
    }

    private static BmSDK.Function __fn_ChangePoseWeapon;
    /// <summary>
    /// Function: ChangePoseWeapon
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FTransitionId ChangePoseWeapon(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, BmSDK.Engine.Inventory NewWeapon, BmSDK.Engine.Inventory NewTransitionWeapon, BmSDK.FName TransitionName = default, bool bMirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangePoseWeapon, "BmGame.RPawnCharacter.ChangePoseWeapon");
        byte* paramsPtr = stackalloc byte[140];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTransitionWeapon, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMirrored, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 76);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 116);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 120);
    }

    private static BmSDK.Function __fn_ForceChangePose;
    /// <summary>
    /// Function: ForceChangePose
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FTransitionId ForceChangePose(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, BmSDK.FName TransitionName = default, bool bMirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDuration = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceChangePose, "BmGame.RPawnCharacter.ForceChangePose");
        byte* paramsPtr = stackalloc byte[136];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMirrored, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 68);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 108);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDuration, paramsPtr + 112);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 116);
    }

    private static BmSDK.Function __fn_ChangePose;
    /// <summary>
    /// Function: ChangePose
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FTransitionId ChangePose(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, BmSDK.FName TransitionName = default, bool bMirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangePose, "BmGame.RPawnCharacter.ChangePose");
        byte* paramsPtr = stackalloc byte[136];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMirrored, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 68);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 108);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 112);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 116);
    }

    private static BmSDK.Function __fn_StartSlavedTransition;
    /// <summary>
    /// Function: StartSlavedTransition
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FTransitionId StartSlavedTransition(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, BmSDK.Engine.Actor SlavedToActor, BmSDK.BmGame.RAnimUtil.FTransitionId SlavedToTransition, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSlavedTransition, "BmGame.RPawnCharacter.StartSlavedTransition");
        byte* paramsPtr = stackalloc byte[148];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlavedToActor, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlavedToTransition, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 120);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 124);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 128);
    }

    private static BmSDK.Function __fn_StartWeaponRelativeTransition;
    /// <summary>
    /// Function: StartWeaponRelativeTransition
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FTransitionId StartWeaponRelativeTransition(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, BmSDK.Engine.Inventory NewWeapon, BmSDK.Engine.Inventory NewTransitionWeapon, System.Numerics.Vector3 TransitionTargetPosition, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartWeaponRelativeTransition, "BmGame.RPawnCharacter.StartWeaponRelativeTransition");
        byte* paramsPtr = stackalloc byte[160];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTransitionWeapon, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetPosition, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 96);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 136);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 140);
    }

    private static BmSDK.Function __fn_StartRelativeTransitionRotationOnly;
    /// <summary>
    /// Function: StartRelativeTransitionRotationOnly
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FTransitionId StartRelativeTransitionRotationOnly(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartRelativeTransitionRotationOnly, "BmGame.RPawnCharacter.StartRelativeTransitionRotationOnly");
        byte* paramsPtr = stackalloc byte[148];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 76);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 116);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 120);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionStartTime, paramsPtr + 124);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 128);
    }

    private static BmSDK.Function __fn_StartRelativePairedTransition;
    /// <summary>
    /// Function: StartRelativePairedTransition
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FTransitionId StartRelativePairedTransition(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, System.Numerics.Vector3 TransitionTargetPosition, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default, BmSDK.Engine.Actor PairedIdleActor = default, BmSDK.BmGame.RAnimUtil.FTransitionId PairedIdeActorTransitionId = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartRelativePairedTransition, "BmGame.RPawnCharacter.StartRelativePairedTransition");
        byte* paramsPtr = stackalloc byte[168];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetPosition, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 128);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 132);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionStartTime, paramsPtr + 136);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PairedIdleActor, paramsPtr + 140);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PairedIdeActorTransitionId, paramsPtr + 144);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 148);
    }

    private static BmSDK.Function __fn_StartRelativeTransition;
    /// <summary>
    /// Function: StartRelativeTransition
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FTransitionId StartRelativeTransition(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, System.Numerics.Vector3 TransitionTargetPosition, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartRelativeTransition, "BmGame.RPawnCharacter.StartRelativeTransition");
        byte* paramsPtr = stackalloc byte[160];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetPosition, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 128);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 132);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionStartTime, paramsPtr + 136);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 140);
    }

    private static BmSDK.Function __fn_StartAbsoluteTransitionRotationOnly;
    /// <summary>
    /// Function: StartAbsoluteTransitionRotationOnly
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FTransitionId StartAbsoluteTransitionRotationOnly(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, int TransitionTargetYaw, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAbsoluteTransitionRotationOnly, "BmGame.RPawnCharacter.StartAbsoluteTransitionRotationOnly");
        byte* paramsPtr = stackalloc byte[136];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 112);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 116);
    }

    private static BmSDK.Function __fn_StartAbsoluteTransition;
    /// <summary>
    /// Function: StartAbsoluteTransition
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FTransitionId StartAbsoluteTransition(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, System.Numerics.Vector3 TransitionTargetPosition, int TransitionTargetYaw, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAbsoluteTransition, "BmGame.RPawnCharacter.StartAbsoluteTransition");
        byte* paramsPtr = stackalloc byte[148];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetPosition, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 84);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 124);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 128);
    }

    private static BmSDK.Function __fn_InstantChangePose;
    /// <summary>
    /// Function: InstantChangePose
    /// </summary>
    public unsafe virtual void InstantChangePose()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InstantChangePose, "BmGame.RPawnCharacter.InstantChangePose");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_SetAllowAutomaticTransitionOutOfMatinee;
    /// <summary>
    /// Function: SetAllowAutomaticTransitionOutOfMatinee
    /// </summary>
    public unsafe virtual void SetAllowAutomaticTransitionOutOfMatinee()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAllowAutomaticTransitionOutOfMatinee, "BmGame.RPawnCharacter.SetAllowAutomaticTransitionOutOfMatinee");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_IsControlledByMatinee;
    /// <summary>
    /// Function: IsControlledByMatinee
    /// </summary>
    public unsafe virtual bool IsControlledByMatinee()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsControlledByMatinee, "BmGame.RPawnCharacter.IsControlledByMatinee");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsInPose;
    /// <summary>
    /// Function: IsInPose
    /// </summary>
    public unsafe virtual bool IsInPose(BmSDK.FName MovementStance, BmSDK.FName WeaponStance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInPose, "BmGame.RPawnCharacter.IsInPose");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_IsInIdleStance;
    /// <summary>
    /// Function: IsInIdleStance
    /// </summary>
    public unsafe virtual bool IsInIdleStance(BmSDK.FName Stance, BmSDK.BmGame.RAnimUtil.EFuzziness Fuzziness = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInIdleStance, "BmGame.RPawnCharacter.IsInIdleStance");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fuzziness, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ChangeIdleStanceWithoutTransition;
    /// <summary>
    /// Function: ChangeIdleStanceWithoutTransition
    /// </summary>
    public unsafe virtual void ChangeIdleStanceWithoutTransition(BmSDK.FName Stance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeIdleStanceWithoutTransition, "BmGame.RPawnCharacter.ChangeIdleStanceWithoutTransition");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stance, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_ChangeIdleStance;
    /// <summary>
    /// Function: ChangeIdleStance
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FTransitionId ChangeIdleStance(BmSDK.FName Stance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeIdleStance, "BmGame.RPawnCharacter.ChangeIdleStance");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stance, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsInWeaponStance;
    /// <summary>
    /// Function: IsInWeaponStance
    /// </summary>
    public unsafe virtual bool IsInWeaponStance(BmSDK.FName Stance, BmSDK.BmGame.RAnimUtil.EFuzziness Fuzziness = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInWeaponStance, "BmGame.RPawnCharacter.IsInWeaponStance");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fuzziness, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ChangeWeaponStance;
    /// <summary>
    /// Function: ChangeWeaponStance
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FTransitionId ChangeWeaponStance(BmSDK.FName Stance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeWeaponStance, "BmGame.RPawnCharacter.ChangeWeaponStance");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stance, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsInMovementStance;
    /// <summary>
    /// Function: IsInMovementStance
    /// </summary>
    public unsafe virtual bool IsInMovementStance(BmSDK.FName Stance, BmSDK.BmGame.RAnimUtil.EFuzziness Fuzziness = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInMovementStance, "BmGame.RPawnCharacter.IsInMovementStance");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fuzziness, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ChangeMovementStance;
    /// <summary>
    /// Function: ChangeMovementStance
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FTransitionId ChangeMovementStance(BmSDK.FName Stance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeMovementStance, "BmGame.RPawnCharacter.ChangeMovementStance");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stance, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IssueFailedChangePoseCallback;
    /// <summary>
    /// Function: IssueFailedChangePoseCallback
    /// </summary>
    public unsafe virtual void IssueFailedChangePoseCallback(BmSDK.BmGame.RAnimNode_Pose.FPoseDescription InputPose, BmSDK.BmGame.RAnimNode_Pose.FPreviousPoseDescription LastPose)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IssueFailedChangePoseCallback, "BmGame.RPawnCharacter.IssueFailedChangePoseCallback");
        byte* paramsPtr = stackalloc byte[348];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InputPose, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LastPose, paramsPtr + 256);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IssueChangePoseCallback;
    /// <summary>
    /// Function: IssueChangePoseCallback
    /// </summary>
    public unsafe virtual void IssueChangePoseCallback(BmSDK.BmGame.RAnimNode_Pose.FPoseDescription InputPose, BmSDK.BmGame.RAnimNode_Pose.FPreviousPoseDescription LastPose)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IssueChangePoseCallback, "BmGame.RPawnCharacter.IssueChangePoseCallback");
        byte* paramsPtr = stackalloc byte[348];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InputPose, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LastPose, paramsPtr + 256);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IssueChangePose;
    /// <summary>
    /// Function: IssueChangePose
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FTransitionId IssueChangePose()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IssueChangePose, "BmGame.RPawnCharacter.IssueChangePose");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_EndChangePose;
    /// <summary>
    /// Function: EndChangePose
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FTransitionId EndChangePose()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndChangePose, "BmGame.RPawnCharacter.EndChangePose");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_BeginQueuedChangePose;
    /// <summary>
    /// Function: BeginQueuedChangePose
    /// </summary>
    public unsafe virtual void BeginQueuedChangePose()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginQueuedChangePose, "BmGame.RPawnCharacter.BeginQueuedChangePose");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_BeginCleanChangePose;
    /// <summary>
    /// Function: BeginCleanChangePose
    /// </summary>
    public unsafe virtual void BeginCleanChangePose(BmSDK.FName PreviousMovementStance, BmSDK.FName PreviousWeaponStance, BmSDK.FName PreviousIdleStance, BmSDK.Engine.Inventory PreviousWeapon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginCleanChangePose, "BmGame.RPawnCharacter.BeginCleanChangePose");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousMovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousWeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousIdleStance, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousWeapon, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_BeginChangePose;
    /// <summary>
    /// Function: BeginChangePose
    /// </summary>
    public unsafe virtual void BeginChangePose()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginChangePose, "BmGame.RPawnCharacter.BeginChangePose");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_GetUpperBodyAnim;
    /// <summary>
    /// Function: GetUpperBodyAnim
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimConfig.FCustomAnimConfig GetUpperBodyAnim(BmSDK.FName AnimName, BmSDK.Engine.AnimSet Set = default, BmSDK.TArray<BmSDK.Engine.AnimSet> ExtraSets = default, BmSDK.BmGame.RAimingConfig AimingConfig = default, BmSDK.BmGame.RPresetAimingConfigs.EPresetAimingConfig PresetAimingConfig = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUpperBodyAnim, "BmGame.RPawnCharacter.GetUpperBodyAnim");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Set, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraSets, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimingConfig, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PresetAimingConfig, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimConfig.FCustomAnimConfig>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GetAdditiveAnimScaled;
    /// <summary>
    /// Function: GetAdditiveAnimScaled
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimConfig.FCustomAdditiveAnimConfig GetAdditiveAnimScaled(BmSDK.FName AnimName, BmSDK.FName BaseAnimName = default, BmSDK.Engine.AnimSet Set = default, BmSDK.TArray<BmSDK.Engine.AnimSet> ExtraSets = default, float Weight = default, float HideWeight = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAdditiveAnimScaled, "BmGame.RPawnCharacter.GetAdditiveAnimScaled");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BaseAnimName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Set, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraSets, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Weight, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HideWeight, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimConfig.FCustomAdditiveAnimConfig>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_GetAdditiveAnim;
    /// <summary>
    /// Function: GetAdditiveAnim
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimConfig.FCustomAdditiveAnimConfig GetAdditiveAnim(BmSDK.FName AnimName, BmSDK.FName BaseAnimName = default, BmSDK.Engine.AnimSet Set = default, BmSDK.TArray<BmSDK.Engine.AnimSet> ExtraSets = default, float Weight = default, float HideWeight = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAdditiveAnim, "BmGame.RPawnCharacter.GetAdditiveAnim");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BaseAnimName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Set, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraSets, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Weight, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HideWeight, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimConfig.FCustomAdditiveAnimConfig>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_GetFullBodyIdle;
    /// <summary>
    /// Function: GetFullBodyIdle
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig GetFullBodyIdle(BmSDK.FName AnimName, BmSDK.Engine.AnimSet Set = default, BmSDK.TArray<BmSDK.Engine.AnimSet> ExtraSets = default, BmSDK.BmGame.RAimingConfig AimingConfig = default, BmSDK.BmGame.RPresetAimingConfigs.EPresetAimingConfig PresetAimingConfig = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFullBodyIdle, "BmGame.RPawnCharacter.GetFullBodyIdle");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Set, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraSets, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimingConfig, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PresetAimingConfig, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GetFullBodyTransition;
    /// <summary>
    /// Function: GetFullBodyTransition
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig GetFullBodyTransition(BmSDK.FName AnimName, BmSDK.Engine.AnimSet Set = default, BmSDK.TArray<BmSDK.Engine.AnimSet> ExtraSets = default, BmSDK.BmGame.RAimingConfig AimingConfig = default, BmSDK.BmGame.RPresetAimingConfigs.EPresetAimingConfig PresetAimingConfig = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFullBodyTransition, "BmGame.RPawnCharacter.GetFullBodyTransition");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Set, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraSets, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimingConfig, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PresetAimingConfig, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GetFullBodyAnim;
    /// <summary>
    /// Function: GetFullBodyAnim
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimConfig.FCustomAnimConfig GetFullBodyAnim(BmSDK.FName AnimName, BmSDK.Engine.AnimSet Set = default, BmSDK.TArray<BmSDK.Engine.AnimSet> ExtraSets = default, BmSDK.BmGame.RAimingConfig AimingConfig = default, BmSDK.BmGame.RPresetAimingConfigs.EPresetAimingConfig PresetAimingConfig = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFullBodyAnim, "BmGame.RPawnCharacter.GetFullBodyAnim");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Set, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraSets, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimingConfig, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PresetAimingConfig, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimConfig.FCustomAnimConfig>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RPawnCharacter.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitAnimNode;
    /// <summary>
    /// Function: InitAnimNode
    /// </summary>
    public unsafe virtual void InitAnimNode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitAnimNode, "BmGame.RPawnCharacter.InitAnimNode");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_RemoveWeaponConfigForNonBosses;
    /// <summary>
    /// Function: RemoveWeaponConfigForNonBosses
    /// </summary>
    public unsafe virtual void RemoveWeaponConfigForNonBosses(BmSDK.BmGame.RWeaponConfig NewWeaponConfig, BmSDK.Class RequestingClass = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveWeaponConfigForNonBosses, "BmGame.RPawnCharacter.RemoveWeaponConfigForNonBosses");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeaponConfig, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequestingClass, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddToUnarmedWeaponConfigForNonBosses;
    /// <summary>
    /// Function: AddToUnarmedWeaponConfigForNonBosses
    /// </summary>
    public unsafe virtual void AddToUnarmedWeaponConfigForNonBosses(BmSDK.BmGame.RWeaponConfig NewWeaponConfig, BmSDK.Class RequestingClass = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddToUnarmedWeaponConfigForNonBosses, "BmGame.RPawnCharacter.AddToUnarmedWeaponConfigForNonBosses");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeaponConfig, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequestingClass, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearOverridenWeaponConfig;
    /// <summary>
    /// Function: ClearOverridenWeaponConfig
    /// </summary>
    public unsafe virtual void ClearOverridenWeaponConfig()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearOverridenWeaponConfig, "BmGame.RPawnCharacter.ClearOverridenWeaponConfig");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddToUnarmedWeaponConfig;
    /// <summary>
    /// Function: AddToUnarmedWeaponConfig
    /// </summary>
    public unsafe virtual void AddToUnarmedWeaponConfig(BmSDK.BmGame.RWeaponConfig NewWeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddToUnarmedWeaponConfig, "BmGame.RPawnCharacter.AddToUnarmedWeaponConfig");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PossessedBy;
    /// <summary>
    /// Function: PossessedBy
    /// </summary>
    public unsafe override void PossessedBy(BmSDK.Engine.Controller C, bool bVehicleTransition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PossessedBy, "BmGame.RPawnCharacter.PossessedBy");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVehicleTransition, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OverlayExists;
    /// <summary>
    /// Function: OverlayExists
    /// </summary>
    public unsafe virtual bool OverlayExists(BmSDK.FName OverlayName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverlayExists, "BmGame.RPawnCharacter.OverlayExists");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverlayName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetFOVCheckLocation;
    /// <summary>
    /// Function: GetFOVCheckLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetFOVCheckLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFOVCheckLocation, "BmGame.RPawnCharacter.GetFOVCheckLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTargetLocation;
    /// <summary>
    /// Function: GetTargetLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetTargetLocation(BmSDK.Engine.Actor RequestedBy = default, bool bRequestAlternateLoc = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargetLocation, "BmGame.RPawnCharacter.GetTargetLocation");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequestedBy, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRequestAlternateLoc, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AttemptTeleportToSafeLocation;
    /// <summary>
    /// Function: AttemptTeleportToSafeLocation
    /// </summary>
    public unsafe virtual void AttemptTeleportToSafeLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttemptTeleportToSafeLocation, "BmGame.RPawnCharacter.AttemptTeleportToSafeLocation");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Struct: FConfigAddRequest
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FConfigAddRequest
    {
        /// <summary>
        /// ClassProperty: ClassType
        /// </summary>
        public unsafe BmSDK.Class ClassType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: NewWeaponConfig
        /// </summary>
        public unsafe BmSDK.BmGame.RWeaponConfig NewWeaponConfig
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: Count
        /// </summary>
        public unsafe int Count
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FTweakFaceFXRegister
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FTweakFaceFXRegister
    {
        /// <summary>
        /// StrProperty: Name
        /// </summary>
        public unsafe BmSDK.FString Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Value
        /// </summary>
        public unsafe float Value
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FRagdollNavMeshCollisionTrackingInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FRagdollNavMeshCollisionTrackingInfo
    {
        /// <summary>
        /// NameProperty: BoneName
        /// </summary>
        public unsafe BmSDK.FName BoneName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: PrevPosition
        /// </summary>
        public unsafe System.Numerics.Vector3 PrevPosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: ERagdollVsNavMesh
    /// </summary>
    public enum ERagdollVsNavMesh : byte
    {
        RAGvsNAV_Constrain = 0,
        RAGvsNAV_ConstrainWhenNotDead = 1,
        RAGvsNAV_DoNotConstrain = 2,
        RAGvsNAV_Auto = 3,
        RAGvsNAV_MAX = 4,
    }

    /// <summary>
    /// Struct: FSoundTracking
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FSoundTracking
    {
        /// <summary>
        /// ObjectProperty: NameOfSound
        /// </summary>
        public unsafe BmSDK.Engine.AkEvent NameOfSound
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: TimeOfPlaying
        /// </summary>
        public unsafe float TimeOfPlaying
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: PeakStrength
        /// </summary>
        public unsafe float PeakStrength
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FCustomIdleConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial record struct FCustomIdleConfig
    {
        /// <summary>
        /// StructProperty: Config
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimConfig.FCustomAnimConfig Config
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimConfig.FCustomAnimConfig>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FCustomTransitionConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial record struct FCustomTransitionConfig
    {
        /// <summary>
        /// StructProperty: Config
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimConfig.FCustomAnimConfig Config
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimConfig.FCustomAnimConfig>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: AIController
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIController AIController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIController>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// ObjectProperty: PlayerController
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerControllerCombat PlayerController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerControllerCombat>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// ObjectProperty: Anim
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNode_Pose Anim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNode_Pose>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// BoolProperty: HasFlappyBits
    /// </summary>
    public unsafe bool HasFlappyBits
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1352); }
    }

    /// <summary>
    /// BoolProperty: HasRFlaps
    /// </summary>
    public unsafe bool HasRFlaps
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1352); }
    }

    /// <summary>
    /// BoolProperty: AlwaysUsePhysics
    /// </summary>
    public unsafe bool AlwaysUsePhysics
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1352); }
    }

    /// <summary>
    /// BoolProperty: AllowCustomPhysics
    /// </summary>
    public unsafe bool AllowCustomPhysics
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1352); }
    }

    /// <summary>
    /// BoolProperty: AllowCustomPhysicsUpdate
    /// </summary>
    public unsafe bool AllowCustomPhysicsUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1352); }
    }

    /// <summary>
    /// BoolProperty: EnableFloorCorrection
    /// </summary>
    public unsafe bool EnableFloorCorrection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1352); }
    }

    /// <summary>
    /// BoolProperty: AllowFloorCorrectionRaycast
    /// </summary>
    public unsafe bool AllowFloorCorrectionRaycast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1352); }
    }

    /// <summary>
    /// BoolProperty: ReduceBlinksAndEyeMovements
    /// </summary>
    public unsafe bool ReduceBlinksAndEyeMovements
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1352); }
    }

    /// <summary>
    /// BoolProperty: InsideChangePose
    /// </summary>
    public unsafe bool InsideChangePose
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1352); }
    }

    /// <summary>
    /// BoolProperty: bBounceIntoCombat
    /// </summary>
    public unsafe bool bBounceIntoCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1352); }
    }

    /// <summary>
    /// BoolProperty: bConstrainingComponentNeedsUpdate
    /// </summary>
    public unsafe bool bConstrainingComponentNeedsUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1352); }
    }

    /// <summary>
    /// BoolProperty: SilentRagdoll
    /// </summary>
    public unsafe bool SilentRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1352); }
    }

    /// <summary>
    /// BoolProperty: bSilentlyTakenDown
    /// </summary>
    public unsafe bool bSilentlyTakenDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1352); }
    }

    /// <summary>
    /// BoolProperty: bGlobalDisallowAutomaticMirroring
    /// </summary>
    public unsafe bool bGlobalDisallowAutomaticMirroring
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1352); }
    }

    /// <summary>
    /// BoolProperty: bForceGetupFacing
    /// </summary>
    public unsafe bool bForceGetupFacing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1352); }
    }

    /// <summary>
    /// BoolProperty: bSnowOnLegs
    /// </summary>
    public unsafe bool bSnowOnLegs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1352); }
    }

    /// <summary>
    /// BoolProperty: bDisableRagdollVsNavMeshConstraint
    /// </summary>
    public unsafe bool bDisableRagdollVsNavMeshConstraint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1352); }
    }

    /// <summary>
    /// BoolProperty: bTempDisableRagdollVsNavMeshConstraint
    /// </summary>
    public unsafe bool bTempDisableRagdollVsNavMeshConstraint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1352); }
    }

    /// <summary>
    /// BoolProperty: bLastFrameWasRagdoll
    /// </summary>
    public unsafe bool bLastFrameWasRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1352); }
    }

    /// <summary>
    /// BoolProperty: bAllowBaseRotationOnPawn
    /// </summary>
    public unsafe bool bAllowBaseRotationOnPawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1352); }
    }

    /// <summary>
    /// BoolProperty: Tweak_FaceFXRegisters_Enabled
    /// </summary>
    public unsafe bool Tweak_FaceFXRegisters_Enabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1352); }
    }

    /// <summary>
    /// BoolProperty: Tweak_Anim_Enabled
    /// </summary>
    public unsafe bool Tweak_Anim_Enabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1352); }
    }

    /// <summary>
    /// BoolProperty: bSpedUpGetUpAnim
    /// </summary>
    public unsafe bool bSpedUpGetUpAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1352); }
    }

    /// <summary>
    /// ObjectProperty: ActualWeapon
    /// </summary>
    public unsafe BmSDK.Engine.Inventory ActualWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Inventory>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// ArrayProperty: Bodysounds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCharacter.FSoundTracking> Bodysounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCharacter.FSoundTracking>>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// StructProperty: PreviousPose
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimNode_Pose.FPreviousPoseDescription PreviousPose
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimNode_Pose.FPreviousPoseDescription>(Ptr + 1372);

    /// <summary>
    /// StructProperty: Pose
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimNode_Pose.FPoseDescription Pose
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimNode_Pose.FPoseDescription>(Ptr + 1448);

    /// <summary>
    /// ObjectProperty: UnarmedWeaponConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RWeaponConfig UnarmedWeaponConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(Ptr + 1704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1704); }
    }

    /// <summary>
    /// ObjectProperty: OverrideUnarmedWeaponConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RWeaponConfig OverrideUnarmedWeaponConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(Ptr + 1708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1708); }
    }

    /// <summary>
    /// NameProperty: GetUpTargetMovementStance
    /// </summary>
    public unsafe BmSDK.FName GetUpTargetMovementStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1712); }
    }

    /// <summary>
    /// NameProperty: GetUpTargetWeaponStance
    /// </summary>
    public unsafe BmSDK.FName GetUpTargetWeaponStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }
    }

    /// <summary>
    /// StructProperty: GetUpTransitionID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId GetUpTransitionID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 1728);

    /// <summary>
    /// StructProperty: SoundCharacterFilter
    /// </summary>
    public unsafe ref BmSDK.Engine.AnimNotify_Sound.FSoundCharacterFilter SoundCharacterFilter
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AnimNotify_Sound.FSoundCharacterFilter>(Ptr + 1732);

    /// <summary>
    /// FloatProperty: TimeOfLastBodyFallParticle
    /// </summary>
    public unsafe float TimeOfLastBodyFallParticle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1736); }
    }

    /// <summary>
    /// StructProperty: RagdollTransitionID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId RagdollTransitionID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 1740);

    /// <summary>
    /// ComponentProperty: BodyConstrainingComponent
    /// </summary>
    public unsafe BmSDK.BmGame.RConstrainingComponent BodyConstrainingComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RConstrainingComponent>(Ptr + 1744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1744); }
    }

    /// <summary>
    /// ObjectProperty: IgnoreCollisionWithPawn
    /// </summary>
    public unsafe BmSDK.Engine.Actor IgnoreCollisionWithPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1748); }
    }

    /// <summary>
    /// FloatProperty: SnowOnLegsBlend
    /// </summary>
    public unsafe float SnowOnLegsBlend
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1752); }
    }

    /// <summary>
    /// FloatProperty: SnowOnLegsTimer
    /// </summary>
    public unsafe float SnowOnLegsTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1756); }
    }

    /// <summary>
    /// ByteProperty: RagdollVsNavMeshSolution
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCharacter.ERagdollVsNavMesh RagdollVsNavMeshSolution
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCharacter.ERagdollVsNavMesh>(Ptr + 1760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }
    }

    /// <summary>
    /// StructProperty: PrevSafePelvisLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PrevSafePelvisLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1764);

    /// <summary>
    /// StructProperty: LastSafeLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastSafeLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1776);

    /// <summary>
    /// IntProperty: NavMeshConstrainFrames
    /// </summary>
    public unsafe int NavMeshConstrainFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1788); }
    }

    /// <summary>
    /// IntProperty: NavMeshConstrainBuffer
    /// </summary>
    public unsafe int NavMeshConstrainBuffer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1792); }
    }

    /// <summary>
    /// ArrayProperty: RagdollCollisionBodies
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCharacter.FRagdollNavMeshCollisionTrackingInfo> RagdollCollisionBodies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCharacter.FRagdollNavMeshCollisionTrackingInfo>>(Ptr + 1796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1796); }
    }

    /// <summary>
    /// StructProperty: Tweak_LocationNudge
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Tweak_LocationNudge
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1808);

    /// <summary>
    /// ArrayProperty: Tweak_FaceFXRegisters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCharacter.FTweakFaceFXRegister> Tweak_FaceFXRegisters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCharacter.FTweakFaceFXRegister>>(Ptr + 1820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1820); }
    }

    /// <summary>
    /// StrProperty: Tweak_Anim_AnimSetName
    /// </summary>
    public unsafe BmSDK.FString Tweak_Anim_AnimSetName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1832); }
    }

    /// <summary>
    /// NameProperty: Tweak_Anim_AnimName
    /// </summary>
    public unsafe BmSDK.FName Tweak_Anim_AnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1844); }
    }

    /// <summary>
    /// FloatProperty: Tweak_Anim_Time
    /// </summary>
    public unsafe float Tweak_Anim_Time
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// FloatProperty: NavTestLength
    /// </summary>
    public unsafe float NavTestLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1856); }
    }

    /// <summary>
    /// ObjectProperty: AirShaftVolume
    /// </summary>
    public unsafe BmSDK.BmGame.MAirShaftVolume AirShaftVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MAirShaftVolume>(Ptr + 1860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1860); }
    }

    /// <summary>
    /// FloatProperty: RagdollFacingThreshold
    /// </summary>
    public unsafe float RagdollFacingThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1864); }
    }

    /// <summary>
    /// StrProperty: LastChangePoseFailedReason
    /// </summary>
    public unsafe BmSDK.FString LastChangePoseFailedReason
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1868); }
    }

    /// <summary>
    /// ArrayProperty: AddToUnarmedRequestingClassList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCharacter.FConfigAddRequest> AddToUnarmedRequestingClassList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCharacter.FConfigAddRequest>>(Ptr + 1880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1880); }
    }

    /// <summary>
    /// DelegateProperty: __OnPlayedQueuedTransition__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnPlayedQueuedTransition__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1892); }
    }
}

/// <summary>
/// The static native functions of RPawnCharacter, callable on an instance. A static native may read the object it runs on, and the static form runs it on the class default object, which has no world.
/// </summary>
public static class RPawnCharacterStatics
{
    private static BmSDK.Function __fn_CombineWeaponConfigs;
    /// <summary>
    /// Function: CombineWeaponConfigs, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static BmSDK.BmGame.RWeaponConfig CombineWeaponConfigs(this BmSDK.BmGame.RPawnCharacter self, BmSDK.GameObject NewOwner, BmSDK.BmGame.RWeaponConfig Config1, BmSDK.BmGame.RWeaponConfig Config2, BmSDK.BmGame.RWeaponConfig Config3 = default, BmSDK.BmGame.RWeaponConfig Config4 = default, BmSDK.BmGame.RWeaponConfig Config5 = default, BmSDK.BmGame.RWeaponConfig Config6 = default, BmSDK.BmGame.RWeaponConfig Config7 = default, BmSDK.BmGame.RWeaponConfig Config8 = default, BmSDK.BmGame.RWeaponConfig Config9 = default, BmSDK.BmGame.RWeaponConfig Config10 = default, BmSDK.BmGame.RWeaponConfig Config11 = default, BmSDK.BmGame.RWeaponConfig Config12 = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombineWeaponConfigs, "BmGame.RPawnCharacter.CombineWeaponConfigs");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config1, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config2, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config3, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config4, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config5, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config6, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config7, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config8, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config9, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config10, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config11, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config12, paramsPtr + 48);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 52);
    }
}
