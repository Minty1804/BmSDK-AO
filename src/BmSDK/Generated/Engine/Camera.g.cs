#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Camera<br/>
/// (size = 1276)
/// (flags = 142606490)
/// </summary>
public partial class Camera : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Camera", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as Camera.
    /// </summary>
    public static Camera DefaultObject => (Camera)StaticClass().DefaultObject;

    internal Camera() { }

    /// <summary>
    /// Constructs a new Camera
    /// </summary>
    public Camera(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Camera(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Camera>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Camera>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Camera>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Camera>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Camera>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Camera>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Camera>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Camera>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_StopCameraAnim;
    /// <summary>
    /// Function: StopCameraAnim
    /// </summary>
    public unsafe virtual void StopCameraAnim(BmSDK.Engine.CameraAnimInst AnimInst, bool bImmediate = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopCameraAnim, "Engine.Camera.StopCameraAnim");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimInst, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bImmediate, paramsPtr + 4);
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

    private static BmSDK.Function __fn_StopAllCameraAnimsByType;
    /// <summary>
    /// Function: StopAllCameraAnimsByType
    /// </summary>
    public unsafe virtual void StopAllCameraAnimsByType(BmSDK.Engine.CameraAnim Anim, bool bImmediate = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAllCameraAnimsByType, "Engine.Camera.StopAllCameraAnimsByType");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Anim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bImmediate, paramsPtr + 4);
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

    private static BmSDK.Function __fn_StopAllCameraAnims;
    /// <summary>
    /// Function: StopAllCameraAnims
    /// </summary>
    public unsafe virtual void StopAllCameraAnims(bool bImmediate = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAllCameraAnims, "Engine.Camera.StopAllCameraAnims");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bImmediate, paramsPtr + 0);
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

    private static BmSDK.Function __fn_PlayCameraAnim;
    /// <summary>
    /// Function: PlayCameraAnim
    /// </summary>
    public unsafe virtual BmSDK.Engine.CameraAnimInst PlayCameraAnim(BmSDK.Engine.CameraAnim Anim, float Rate = default, float Scale = default, float BlendInTime = default, float BlendOutTime = default, bool bLoop = default, bool bRandomStartTime = default, float Duration = default, bool bSingleInstance = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCameraAnim, "Engine.Camera.PlayCameraAnim");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Anim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rate, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scale, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendInTime, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendOutTime, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLoop, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRandomStartTime, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSingleInstance, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.CameraAnimInst>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_ClearAllCameraShakes;
    /// <summary>
    /// Function: ClearAllCameraShakes
    /// </summary>
    public unsafe virtual void ClearAllCameraShakes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearAllCameraShakes, "Engine.Camera.ClearAllCameraShakes");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayWorldCameraShake;
    /// <summary>
    /// Function: PlayWorldCameraShake
    /// </summary>
    public unsafe static void PlayWorldCameraShake(BmSDK.Engine.CameraShake Shake, BmSDK.Engine.Actor ShakeInstigator, System.Numerics.Vector3 Epicenter, float InnerRadius, float OuterRadius, float Falloff, bool bTryForceFeedback, bool bOrientShakeTowardsEpicenter = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayWorldCameraShake, "Engine.Camera.PlayWorldCameraShake");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Shake, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShakeInstigator, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Epicenter, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InnerRadius, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OuterRadius, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Falloff, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTryForceFeedback, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOrientShakeTowardsEpicenter, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CalcRadialShakeScale;
    /// <summary>
    /// Function: CalcRadialShakeScale
    /// </summary>
    public unsafe static float CalcRadialShakeScale(BmSDK.Engine.Camera Cam, System.Numerics.Vector3 Epicenter, float InnerRadius, float OuterRadius, float Falloff)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalcRadialShakeScale, "Engine.Camera.CalcRadialShakeScale");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Cam, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Epicenter, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InnerRadius, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OuterRadius, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Falloff, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_StopCameraShake;
    /// <summary>
    /// Function: StopCameraShake
    /// </summary>
    public unsafe virtual void StopCameraShake(BmSDK.Engine.CameraShake Shake)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopCameraShake, "Engine.Camera.StopCameraShake");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Shake, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayCameraShake;
    /// <summary>
    /// Function: PlayCameraShake
    /// </summary>
    public unsafe virtual void PlayCameraShake(BmSDK.Engine.CameraShake Shake, float Scale, BmSDK.Engine.Camera.ECameraAnimPlaySpace PlaySpace = default, BmSDK.Rotator UserPlaySpaceRot = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCameraShake, "Engine.Camera.PlayCameraShake");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Shake, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scale, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlaySpace, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserPlaySpaceRot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearCameraLensEffects;
    /// <summary>
    /// Function: ClearCameraLensEffects
    /// </summary>
    public unsafe virtual void ClearCameraLensEffects()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearCameraLensEffects, "Engine.Camera.ClearCameraLensEffects");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveCameraLensEffect;
    /// <summary>
    /// Function: RemoveCameraLensEffect
    /// </summary>
    public unsafe virtual void RemoveCameraLensEffect(BmSDK.Engine.EmitterCameraLensEffectBase Emitter)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveCameraLensEffect, "Engine.Camera.RemoveCameraLensEffect");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Emitter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddCameraLensEffect;
    /// <summary>
    /// Function: AddCameraLensEffect
    /// </summary>
    public unsafe virtual void AddCameraLensEffect(BmSDK.Class LensEffectEmitterClass)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCameraLensEffect, "Engine.Camera.AddCameraLensEffect");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LensEffectEmitterClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindCameraLensEffect;
    /// <summary>
    /// Function: FindCameraLensEffect
    /// </summary>
    public unsafe virtual BmSDK.Engine.EmitterCameraLensEffectBase FindCameraLensEffect(BmSDK.Class LensEffectEmitterClass)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindCameraLensEffect, "Engine.Camera.FindCameraLensEffect");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LensEffectEmitterClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.EmitterCameraLensEffectBase>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_DisplayDebug;
    /// <summary>
    /// Function: DisplayDebug
    /// </summary>
    public unsafe override void DisplayDebug(BmSDK.Engine.HUD HUD, out float out_YL, out float out_YPos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayDebug, "Engine.Camera.DisplayDebug");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HUD, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_YL);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_YL, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_YPos);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_YPos, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_YL = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        out_YPos = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_ProcessViewRotation;
    /// <summary>
    /// Function: ProcessViewRotation
    /// </summary>
    public unsafe virtual void ProcessViewRotation(float DeltaTime, out BmSDK.Rotator OutViewRotation, out BmSDK.Rotator OutDeltaRot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessViewRotation, "Engine.Camera.ProcessViewRotation");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutViewRotation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutViewRotation, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutDeltaRot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutDeltaRot, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutViewRotation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 4);
        OutDeltaRot = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_SetViewTarget;
    /// <summary>
    /// Function: SetViewTarget
    /// </summary>
    public unsafe virtual void SetViewTarget(BmSDK.Engine.Actor NewViewTarget, BmSDK.Engine.Camera.FViewTargetTransitionParams TransitionParams = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetViewTarget, "Engine.Camera.SetViewTarget");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewViewTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionParams, paramsPtr + 4);
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

    private static BmSDK.Function __fn_UpdateViewTarget;
    /// <summary>
    /// Function: UpdateViewTarget
    /// </summary>
    public unsafe virtual void UpdateViewTarget(out BmSDK.Engine.Camera.FTViewTarget OutVT, float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateViewTarget, "Engine.Camera.UpdateViewTarget");
        byte* paramsPtr = stackalloc byte[168];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutVT);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutVT, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutVT = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Camera.FTViewTarget>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_CheckViewTarget;
    /// <summary>
    /// Function: CheckViewTarget
    /// </summary>
    public unsafe virtual void CheckViewTarget(out BmSDK.Engine.Camera.FTViewTarget VT)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckViewTarget, "Engine.Camera.CheckViewTarget");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out VT);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VT, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        VT = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Camera.FTViewTarget>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_FillCameraCache;
    /// <summary>
    /// Function: FillCameraCache
    /// </summary>
    public unsafe virtual void FillCameraCache(in BmSDK.GameObject.FTPOV NewPOV)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FillCameraCache, "Engine.Camera.FillCameraCache");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPOV, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BlendViewTargets;
    /// <summary>
    /// Function: BlendViewTargets
    /// </summary>
    public unsafe virtual BmSDK.GameObject.FTPOV BlendViewTargets(in BmSDK.Engine.Camera.FTViewTarget A, in BmSDK.Engine.Camera.FTViewTarget B, float Alpha)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlendViewTargets, "Engine.Camera.BlendViewTargets");
        byte* paramsPtr = stackalloc byte[164];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Alpha, paramsPtr + 88);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FTPOV>(paramsPtr + 92);
    }

    private static BmSDK.Function __fn_UpdateCamera;
    /// <summary>
    /// Function: UpdateCamera
    /// </summary>
    public unsafe virtual void UpdateCamera(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCamera, "Engine.Camera.UpdateCamera");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDesiredColorScale;
    /// <summary>
    /// Function: SetDesiredColorScale
    /// </summary>
    public unsafe virtual void SetDesiredColorScale(System.Numerics.Vector3 NewColorScale, float InterpTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDesiredColorScale, "Engine.Camera.SetDesiredColorScale");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewColorScale, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterpTime, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCameraViewPoint;
    /// <summary>
    /// Function: GetCameraViewPoint
    /// </summary>
    public unsafe virtual void GetCameraViewPoint(out System.Numerics.Vector3 OutCamLoc, out BmSDK.Rotator OutCamRot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCameraViewPoint, "Engine.Camera.GetCameraViewPoint");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutCamLoc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutCamLoc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutCamRot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutCamRot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutCamLoc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        OutCamRot = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_SetFOV;
    /// <summary>
    /// Function: SetFOV
    /// </summary>
    public unsafe virtual void SetFOV(float NewFOV)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFOV, "Engine.Camera.SetFOV");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFOV, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetFOVAngle;
    /// <summary>
    /// Function: GetFOVAngle
    /// </summary>
    public unsafe virtual float GetFOVAngle()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFOVAngle, "Engine.Camera.GetFOVAngle");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InitializeFor;
    /// <summary>
    /// Function: InitializeFor
    /// </summary>
    public unsafe virtual void InitializeFor(BmSDK.Engine.PlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitializeFor, "Engine.Camera.InitializeFor");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyCameraModifiers;
    /// <summary>
    /// Function: ApplyCameraModifiers
    /// </summary>
    public unsafe virtual void ApplyCameraModifiers(float DeltaTime, out BmSDK.GameObject.FTPOV OutPOV)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyCameraModifiers, "Engine.Camera.ApplyCameraModifiers");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutPOV);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutPOV, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutPOV = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FTPOV>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "Engine.Camera.Destroyed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "Engine.Camera.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateCameraModifier;
    /// <summary>
    /// Function: CreateCameraModifier
    /// </summary>
    public unsafe virtual BmSDK.Engine.CameraModifier CreateCameraModifier(BmSDK.Class ModifierClass)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateCameraModifier, "Engine.Camera.CreateCameraModifier");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ModifierClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.CameraModifier>(paramsPtr + 4);
    }

    /// <summary>
    /// Enum: ECameraAnimPlaySpace
    /// </summary>
    public enum ECameraAnimPlaySpace : byte
    {
        CAPS_CameraLocal = 0,
        CAPS_World = 1,
        CAPS_UserDefined = 2,
        CAPS_MAX = 3,
    }

    /// <summary>
    /// Struct: FViewTargetTransitionParams
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FViewTargetTransitionParams
    {
        /// <summary>
        /// FloatProperty: BlendTime
        /// </summary>
        public unsafe float BlendTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: BlendFunction
        /// </summary>
        public unsafe BmSDK.Engine.Camera.EViewTargetBlendFunction BlendFunction
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Camera.EViewTargetBlendFunction>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: BlendExp
        /// </summary>
        public unsafe float BlendExp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bLockOutgoing
        /// </summary>
        public unsafe bool bLockOutgoing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bResetCameraBehindPlayer
        /// </summary>
        public unsafe bool bResetCameraBehindPlayer
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bKeepBatmanOnScreen
        /// </summary>
        public unsafe bool bKeepBatmanOnScreen
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bDisableCamerCollisionDuringBlend
        /// </summary>
        public unsafe bool bDisableCamerCollisionDuringBlend
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Enum: EViewTargetBlendFunction
    /// </summary>
    public enum EViewTargetBlendFunction : byte
    {
        VTBlend_Linear = 0,
        VTBlend_Cubic = 1,
        VTBlend_EaseIn = 2,
        VTBlend_EaseOut = 3,
        VTBlend_EaseInOut = 4,
        VTBlend_MAX = 5,
    }

    /// <summary>
    /// Struct: FTViewTarget
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial record struct FTViewTarget
    {
        /// <summary>
        /// ObjectProperty: Target
        /// </summary>
        public unsafe BmSDK.Engine.Actor Target
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: Controller
        /// </summary>
        public unsafe BmSDK.Engine.Controller Controller
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Controller>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: POV
        /// </summary>
        public unsafe BmSDK.GameObject.FTPOV POV
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FTPOV>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: AspectRatio
        /// </summary>
        public unsafe float AspectRatio
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// ObjectProperty: PRI
        /// </summary>
        public unsafe BmSDK.Engine.PlayerReplicationInfo PRI
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerReplicationInfo>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FTCameraCache
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FTCameraCache
    {
        /// <summary>
        /// FloatProperty: TimeStamp
        /// </summary>
        public unsafe float TimeStamp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: POV
        /// </summary>
        public unsafe BmSDK.GameObject.FTPOV POV
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FTPOV>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: PCOwner
    /// </summary>
    public unsafe BmSDK.Engine.PlayerController PCOwner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerController>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// NameProperty: CameraStyle
    /// </summary>
    public unsafe BmSDK.FName CameraStyle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// FloatProperty: DefaultFOV
    /// </summary>
    public unsafe float DefaultFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// BoolProperty: bLockedFOV
    /// </summary>
    public unsafe bool bLockedFOV
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: bConstrainAspectRatio
    /// </summary>
    public unsafe bool bConstrainAspectRatio
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: bEnableFading
    /// </summary>
    public unsafe bool bEnableFading
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: bEnableAudioFading
    /// </summary>
    public unsafe bool bEnableAudioFading
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: bOverrideDOF
    /// </summary>
    public unsafe bool bOverrideDOF
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: bOverrideMotionBlur
    /// </summary>
    public unsafe bool bOverrideMotionBlur
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: bOverrideBloom
    /// </summary>
    public unsafe bool bOverrideBloom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: bOverrideScene
    /// </summary>
    public unsafe bool bOverrideScene
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: bOverrideAtmospherics
    /// </summary>
    public unsafe bool bOverrideAtmospherics
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: bZoomed
    /// </summary>
    public unsafe bool bZoomed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: bEnableColorScaling
    /// </summary>
    public unsafe bool bEnableColorScaling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: bEnableColorScaleInterp
    /// </summary>
    public unsafe bool bEnableColorScaleInterp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// BoolProperty: bDebugCameraPath
    /// </summary>
    public unsafe bool bDebugCameraPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 468); }
    }

    /// <summary>
    /// FloatProperty: LockedFOV
    /// </summary>
    public unsafe float LockedFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// FloatProperty: ConstrainedAspectRatio
    /// </summary>
    public unsafe float ConstrainedAspectRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// FloatProperty: DefaultAspectRatio
    /// </summary>
    public unsafe float DefaultAspectRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// FloatProperty: OffAxisYawAngle
    /// </summary>
    public unsafe float OffAxisYawAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// FloatProperty: OffAxisPitchAngle
    /// </summary>
    public unsafe float OffAxisPitchAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// StructProperty: FadeColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor FadeColor
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 492);

    /// <summary>
    /// FloatProperty: FadeAmount
    /// </summary>
    public unsafe float FadeAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// FloatProperty: CamOverridePostProcessAlpha
    /// </summary>
    public unsafe float CamOverridePostProcessAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// StructProperty: CamPostProcessSettings
    /// </summary>
    public unsafe ref BmSDK.Engine.PostProcessVolume.FPostProcessSettings CamPostProcessSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.PostProcessVolume.FPostProcessSettings>(Ptr + 504);

    /// <summary>
    /// StructProperty: ColorScale
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ColorScale
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 924);

    /// <summary>
    /// StructProperty: DesiredColorScale
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DesiredColorScale
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 936);

    /// <summary>
    /// StructProperty: OriginalColorScale
    /// </summary>
    public unsafe ref System.Numerics.Vector3 OriginalColorScale
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 948);

    /// <summary>
    /// FloatProperty: ColorScaleInterpDuration
    /// </summary>
    public unsafe float ColorScaleInterpDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// FloatProperty: ColorScaleInterpStartTime
    /// </summary>
    public unsafe float ColorScaleInterpStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// FloatProperty: SoundFadeAmount
    /// </summary>
    public unsafe float SoundFadeAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// FloatProperty: StereoConvergenceDepth
    /// </summary>
    public unsafe float StereoConvergenceDepth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// FloatProperty: FarCullDistance
    /// </summary>
    public unsafe float FarCullDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// StructProperty: CameraCache
    /// </summary>
    public unsafe ref BmSDK.Engine.Camera.FTCameraCache CameraCache
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.Camera.FTCameraCache>(Ptr + 980);

    /// <summary>
    /// StructProperty: LastFrameCameraCache
    /// </summary>
    public unsafe ref BmSDK.Engine.Camera.FTCameraCache LastFrameCameraCache
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.Camera.FTCameraCache>(Ptr + 1012);

    /// <summary>
    /// StructProperty: ViewTarget
    /// </summary>
    public unsafe ref BmSDK.Engine.Camera.FTViewTarget ViewTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.Camera.FTViewTarget>(Ptr + 1044);

    /// <summary>
    /// StructProperty: PendingViewTarget
    /// </summary>
    public unsafe ref BmSDK.Engine.Camera.FTViewTarget PendingViewTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.Camera.FTViewTarget>(Ptr + 1088);

    /// <summary>
    /// FloatProperty: BlendTimeToGo
    /// </summary>
    public unsafe float BlendTimeToGo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// StructProperty: BlendParams
    /// </summary>
    public unsafe ref BmSDK.Engine.Camera.FViewTargetTransitionParams BlendParams
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.Camera.FViewTargetTransitionParams>(Ptr + 1136);

    /// <summary>
    /// ArrayProperty: ModifierList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.CameraModifier> ModifierList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.CameraModifier>>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// FloatProperty: FreeCamDistance
    /// </summary>
    public unsafe float FreeCamDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// StructProperty: FreeCamOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FreeCamOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1168);

    /// <summary>
    /// StructProperty: FadeAlpha
    /// </summary>
    public unsafe ref System.Numerics.Vector2 FadeAlpha
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector2>(Ptr + 1180);

    /// <summary>
    /// FloatProperty: FadeTime
    /// </summary>
    public unsafe float FadeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// FloatProperty: FadeTimeRemaining
    /// </summary>
    public unsafe float FadeTimeRemaining
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// ArrayProperty: CameraLensEffects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.EmitterCameraLensEffectBase> CameraLensEffects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.EmitterCameraLensEffectBase>>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// ObjectProperty: CameraShakeCamMod
    /// </summary>
    public unsafe BmSDK.Engine.CameraModifier_CameraShake CameraShakeCamMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CameraModifier_CameraShake>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// ClassProperty: CameraShakeCamModClass
    /// </summary>
    public unsafe BmSDK.Class CameraShakeCamModClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: AnimInstPool
    /// </summary>
    public InlineArray<BmSDK.Engine.CameraAnimInst> AnimInstPool => new(8, Ptr + 1216, 4, this);

    /// <summary>
    /// ObjectProperty: AnimInstPool
    /// </summary>
    public unsafe BmSDK.Engine.CameraAnimInst AnimInstPool_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CameraAnimInst>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }
    /// <summary>
    /// ObjectProperty: AnimInstPool
    /// </summary>
    public unsafe BmSDK.Engine.CameraAnimInst AnimInstPool_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CameraAnimInst>(Ptr + 1220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1220); }
    }
    /// <summary>
    /// ObjectProperty: AnimInstPool
    /// </summary>
    public unsafe BmSDK.Engine.CameraAnimInst AnimInstPool_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CameraAnimInst>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }
    /// <summary>
    /// ObjectProperty: AnimInstPool
    /// </summary>
    public unsafe BmSDK.Engine.CameraAnimInst AnimInstPool_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CameraAnimInst>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }
    /// <summary>
    /// ObjectProperty: AnimInstPool
    /// </summary>
    public unsafe BmSDK.Engine.CameraAnimInst AnimInstPool_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CameraAnimInst>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }
    /// <summary>
    /// ObjectProperty: AnimInstPool
    /// </summary>
    public unsafe BmSDK.Engine.CameraAnimInst AnimInstPool_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CameraAnimInst>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }
    /// <summary>
    /// ObjectProperty: AnimInstPool
    /// </summary>
    public unsafe BmSDK.Engine.CameraAnimInst AnimInstPool_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CameraAnimInst>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }
    /// <summary>
    /// ObjectProperty: AnimInstPool
    /// </summary>
    public unsafe BmSDK.Engine.CameraAnimInst AnimInstPool_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CameraAnimInst>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }

    /// <summary>
    /// ArrayProperty: ActiveAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.CameraAnimInst> ActiveAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.CameraAnimInst>>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// ArrayProperty: FreeAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.CameraAnimInst> FreeAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.CameraAnimInst>>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }

    /// <summary>
    /// ObjectProperty: AnimCameraActor
    /// </summary>
    public unsafe BmSDK.Engine.DynamicCameraActor AnimCameraActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DynamicCameraActor>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }
}
