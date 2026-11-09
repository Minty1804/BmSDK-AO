#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkComponent<br/>
/// (size = 360)
/// (flags = 134217874)
/// </summary>
public partial class AkComponent : BmSDK.Engine.ActorComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as AkComponent.
    /// </summary>
    public static AkComponent DefaultObject => (AkComponent)StaticClass().DefaultObject;

    internal AkComponent() { }

    /// <summary>
    /// Constructs a new AkComponent
    /// </summary>
    public AkComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkComponent(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AkComponent>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkComponent>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AkComponent>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkComponent>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkComponent>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkComponent>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AkComponent>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkComponent>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_NotifyLifetimeEventEnd;
    /// <summary>
    /// Function: NotifyLifetimeEventEnd
    /// </summary>
    public unsafe virtual void NotifyLifetimeEventEnd()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyLifetimeEventEnd, "Engine.AkComponent.NotifyLifetimeEventEnd");
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

    private static BmSDK.Function __fn_DebugIsFailedSource;
    /// <summary>
    /// Function: DebugIsFailedSource
    /// </summary>
    public unsafe virtual bool DebugIsFailedSource()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugIsFailedSource, "Engine.AkComponent.DebugIsFailedSource");
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

    private static BmSDK.Function __fn_IsOutsideListenerOcclusionVolumes;
    /// <summary>
    /// Function: IsOutsideListenerOcclusionVolumes
    /// </summary>
    public unsafe virtual bool IsOutsideListenerOcclusionVolumes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsOutsideListenerOcclusionVolumes, "Engine.AkComponent.IsOutsideListenerOcclusionVolumes");
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

    private static BmSDK.Function __fn_IsOwnerSurveillance;
    /// <summary>
    /// Function: IsOwnerSurveillance
    /// </summary>
    public unsafe virtual bool IsOwnerSurveillance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsOwnerSurveillance, "Engine.AkComponent.IsOwnerSurveillance");
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

    private static BmSDK.Function __fn_IsOwnerSpeaking;
    /// <summary>
    /// Function: IsOwnerSpeaking
    /// </summary>
    public unsafe virtual bool IsOwnerSpeaking()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsOwnerSpeaking, "Engine.AkComponent.IsOwnerSpeaking");
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

    private static BmSDK.Function __fn_IsOwnerDead;
    /// <summary>
    /// Function: IsOwnerDead
    /// </summary>
    public unsafe virtual bool IsOwnerDead()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsOwnerDead, "Engine.AkComponent.IsOwnerDead");
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

    private static BmSDK.Function __fn_IsOwnerHidden;
    /// <summary>
    /// Function: IsOwnerHidden
    /// </summary>
    public unsafe virtual bool IsOwnerHidden()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsOwnerHidden, "Engine.AkComponent.IsOwnerHidden");
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

    private static BmSDK.Function __fn_GetSourceLODRadius;
    /// <summary>
    /// Function: GetSourceLODRadius
    /// </summary>
    public unsafe virtual float GetSourceLODRadius()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSourceLODRadius, "Engine.AkComponent.GetSourceLODRadius");
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

    private static BmSDK.Function __fn_ResetPeakAudibilityRadius;
    /// <summary>
    /// Function: ResetPeakAudibilityRadius
    /// </summary>
    public unsafe virtual void ResetPeakAudibilityRadius(float ResetValue = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetPeakAudibilityRadius, "Engine.AkComponent.ResetPeakAudibilityRadius");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResetValue, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetPeakAudibilityRadius;
    /// <summary>
    /// Function: GetPeakAudibilityRadius
    /// </summary>
    public unsafe virtual float GetPeakAudibilityRadius()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPeakAudibilityRadius, "Engine.AkComponent.GetPeakAudibilityRadius");
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

    private static BmSDK.Function __fn_GetFalloffEnhancementMultiplier;
    /// <summary>
    /// Function: GetFalloffEnhancementMultiplier
    /// </summary>
    public unsafe virtual float GetFalloffEnhancementMultiplier()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFalloffEnhancementMultiplier, "Engine.AkComponent.GetFalloffEnhancementMultiplier");
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

    private static BmSDK.Function __fn_IsFalloffEnhancementEnabled;
    /// <summary>
    /// Function: IsFalloffEnhancementEnabled
    /// </summary>
    public unsafe virtual bool IsFalloffEnhancementEnabled()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFalloffEnhancementEnabled, "Engine.AkComponent.IsFalloffEnhancementEnabled");
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

    private static BmSDK.Function __fn_DisableFalloffEnhancement;
    /// <summary>
    /// Function: DisableFalloffEnhancement
    /// </summary>
    public unsafe virtual void DisableFalloffEnhancement()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableFalloffEnhancement, "Engine.AkComponent.DisableFalloffEnhancement");
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

    private static BmSDK.Function __fn_EnableFalloffEnhancement;
    /// <summary>
    /// Function: EnableFalloffEnhancement
    /// </summary>
    public unsafe virtual void EnableFalloffEnhancement(float EnhancementRadius, bool EaseIn = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableFalloffEnhancement, "Engine.AkComponent.EnableFalloffEnhancement");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnhancementRadius, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EaseIn, paramsPtr + 4);
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

    private static BmSDK.Function __fn_ApplyFalloffRadiusMultiplier;
    /// <summary>
    /// Function: ApplyFalloffRadiusMultiplier
    /// </summary>
    public unsafe virtual void ApplyFalloffRadiusMultiplier(float FalloffMultiplier, bool MixInOut)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyFalloffRadiusMultiplier, "Engine.AkComponent.ApplyFalloffRadiusMultiplier");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FalloffMultiplier, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MixInOut, paramsPtr + 4);
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

    private static BmSDK.Function __fn_IsOcclusionEnabled;
    /// <summary>
    /// Function: IsOcclusionEnabled
    /// </summary>
    public unsafe virtual bool IsOcclusionEnabled()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsOcclusionEnabled, "Engine.AkComponent.IsOcclusionEnabled");
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

    private static BmSDK.Function __fn_DisableOcclusion;
    /// <summary>
    /// Function: DisableOcclusion
    /// </summary>
    public unsafe virtual void DisableOcclusion()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableOcclusion, "Engine.AkComponent.DisableOcclusion");
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

    private static BmSDK.Function __fn_EnableOcclusion;
    /// <summary>
    /// Function: EnableOcclusion
    /// </summary>
    public unsafe virtual void EnableOcclusion()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableOcclusion, "Engine.AkComponent.EnableOcclusion");
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

    private static BmSDK.Function __fn_EnableEnvironmentalEffects;
    /// <summary>
    /// Function: EnableEnvironmentalEffects
    /// </summary>
    public unsafe virtual void EnableEnvironmentalEffects(bool EnableEnvs)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableEnvironmentalEffects, "Engine.AkComponent.EnableEnvironmentalEffects");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnableEnvs, paramsPtr + 0);
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

    private static BmSDK.Function __fn_IsAutoUpdateSpatial;
    /// <summary>
    /// Function: IsAutoUpdateSpatial
    /// </summary>
    public unsafe virtual bool IsAutoUpdateSpatial()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAutoUpdateSpatial, "Engine.AkComponent.IsAutoUpdateSpatial");
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

    private static BmSDK.Function __fn_IsSourceActive;
    /// <summary>
    /// Function: IsSourceActive
    /// </summary>
    public unsafe virtual bool IsSourceActive()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSourceActive, "Engine.AkComponent.IsSourceActive");
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

    private static BmSDK.Function __fn_IsPlayingLifetimeEvent;
    /// <summary>
    /// Function: IsPlayingLifetimeEvent
    /// </summary>
    public unsafe virtual bool IsPlayingLifetimeEvent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPlayingLifetimeEvent, "Engine.AkComponent.IsPlayingLifetimeEvent");
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

    private static BmSDK.Function __fn_ShouldAutoPlayLifetimeEvent;
    /// <summary>
    /// Function: ShouldAutoPlayLifetimeEvent
    /// </summary>
    public unsafe virtual bool ShouldAutoPlayLifetimeEvent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldAutoPlayLifetimeEvent, "Engine.AkComponent.ShouldAutoPlayLifetimeEvent");
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

    private static BmSDK.Function __fn_StopLifetimeEvent;
    /// <summary>
    /// Function: StopLifetimeEvent
    /// </summary>
    public unsafe virtual void StopLifetimeEvent(bool SetAutoplayLifetimeTo = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopLifetimeEvent, "Engine.AkComponent.StopLifetimeEvent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SetAutoplayLifetimeTo, paramsPtr + 0);
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

    private static BmSDK.Function __fn_StartLifetimeEvent;
    /// <summary>
    /// Function: StartLifetimeEvent
    /// </summary>
    public unsafe virtual void StartLifetimeEvent(bool SetAutoplayLifetimeTo = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartLifetimeEvent, "Engine.AkComponent.StartLifetimeEvent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SetAutoplayLifetimeTo, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetLifetimeEvent;
    /// <summary>
    /// Function: SetLifetimeEvent
    /// </summary>
    public unsafe virtual void SetLifetimeEvent(BmSDK.Engine.AkEvent NewLifetimeEvent, bool SetAutoplayLifetimeTo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLifetimeEvent, "Engine.AkComponent.SetLifetimeEvent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLifetimeEvent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SetAutoplayLifetimeTo, paramsPtr + 4);
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

    private static BmSDK.Function __fn_UnregisterOcclusionMultipliers;
    /// <summary>
    /// Function: UnregisterOcclusionMultipliers
    /// </summary>
    public unsafe virtual void UnregisterOcclusionMultipliers(float Multiplier, float MultiplierAux)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnregisterOcclusionMultipliers, "Engine.AkComponent.UnregisterOcclusionMultipliers");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Multiplier, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MultiplierAux, paramsPtr + 4);
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

    private static BmSDK.Function __fn_RegisterOcclusionMultipliers;
    /// <summary>
    /// Function: RegisterOcclusionMultipliers
    /// </summary>
    public unsafe virtual void RegisterOcclusionMultipliers(float Multiplier, float MultiplierAux)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterOcclusionMultipliers, "Engine.AkComponent.RegisterOcclusionMultipliers");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Multiplier, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MultiplierAux, paramsPtr + 4);
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

    private static BmSDK.Function __fn_UnregisterEnvironments;
    /// <summary>
    /// Function: UnregisterEnvironments
    /// </summary>
    public unsafe virtual void UnregisterEnvironments(BmSDK.TArray<BmSDK.Engine.AkWwise.FAkEnvironmentSettings> Envs, bool ClearListenerEnvironment = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnregisterEnvironments, "Engine.AkComponent.UnregisterEnvironments");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Envs, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClearListenerEnvironment, paramsPtr + 12);
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

    private static BmSDK.Function __fn_RegisterEnvironments;
    /// <summary>
    /// Function: RegisterEnvironments
    /// </summary>
    public unsafe virtual void RegisterEnvironments(BmSDK.TArray<BmSDK.Engine.AkWwise.FAkEnvironmentSettings> Envs, bool SetListenerEnvironment = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterEnvironments, "Engine.AkComponent.RegisterEnvironments");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Envs, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SetListenerEnvironment, paramsPtr + 12);
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

    private static BmSDK.Function __fn_SetSourceSpatialBeam;
    /// <summary>
    /// Function: SetSourceSpatialBeam
    /// </summary>
    public unsafe virtual void SetSourceSpatialBeam(System.Numerics.Vector3 BeamStartPoint, System.Numerics.Vector3 BeamEndPoint, BmSDK.Rotator Orientation = default, BmSDK.Engine.AkComponent.EAkComponentUpdate NewUpdateType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSourceSpatialBeam, "Engine.AkComponent.SetSourceSpatialBeam");
        byte* paramsPtr = stackalloc byte[53];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BeamStartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BeamEndPoint, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Orientation, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewUpdateType, paramsPtr + 36);
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

    private static BmSDK.Function __fn_SetSourceSpatialRay;
    /// <summary>
    /// Function: SetSourceSpatialRay
    /// </summary>
    public unsafe virtual void SetSourceSpatialRay(System.Numerics.Vector3 RayOrigin, BmSDK.Rotator RayOrientation, BmSDK.Rotator Orientation = default, BmSDK.Engine.AkComponent.EAkComponentUpdate NewUpdateType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSourceSpatialRay, "Engine.AkComponent.SetSourceSpatialRay");
        byte* paramsPtr = stackalloc byte[53];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RayOrigin, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RayOrientation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Orientation, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewUpdateType, paramsPtr + 36);
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

    private static BmSDK.Function __fn_SetSourceSpatialMulti;
    /// <summary>
    /// Function: SetSourceSpatialMulti
    /// </summary>
    public unsafe virtual void SetSourceSpatialMulti(BmSDK.TArray<BmSDK.Engine.AkWwise.FAkSourceSpatial> MultiPositions, bool Additive, System.Numerics.Vector3 PrimaryPosition, BmSDK.Rotator PrimaryOrientation = default, BmSDK.Engine.AkComponent.EAkComponentUpdate NewUpdateType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSourceSpatialMulti, "Engine.AkComponent.SetSourceSpatialMulti");
        byte* paramsPtr = stackalloc byte[57];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MultiPositions, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Additive, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PrimaryPosition, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PrimaryOrientation, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewUpdateType, paramsPtr + 40);
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

    private static BmSDK.Function __fn_SetSourceSpatial;
    /// <summary>
    /// Function: SetSourceSpatial
    /// </summary>
    public unsafe virtual void SetSourceSpatial(System.Numerics.Vector3 Position, BmSDK.Rotator Orientation = default, BmSDK.Engine.AkComponent.EAkComponentUpdate NewUpdateType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSourceSpatial, "Engine.AkComponent.SetSourceSpatial");
        byte* paramsPtr = stackalloc byte[41];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Orientation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewUpdateType, paramsPtr + 24);
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

    private static BmSDK.Function __fn_SetSurfaceSwitch;
    /// <summary>
    /// Function: SetSurfaceSwitch
    /// </summary>
    public unsafe virtual void SetSurfaceSwitch(BmSDK.Engine.AkSwitchName SwitchName, BmSDK.Engine.AkSwitchName FallbackSwitchName, BmSDK.FString CharacterName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSurfaceSwitch, "Engine.AkComponent.SetSurfaceSwitch");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SwitchName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FallbackSwitchName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterName, paramsPtr + 8);
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

    private static BmSDK.Function __fn_SetSourceSwitch;
    /// <summary>
    /// Function: SetSourceSwitch
    /// </summary>
    public unsafe virtual void SetSourceSwitch(BmSDK.Engine.AkSwitchName SwitchName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSourceSwitch, "Engine.AkComponent.SetSourceSwitch");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SwitchName, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetSourceStickyParameterEx;
    /// <summary>
    /// Function: SetSourceStickyParameterEx
    /// </summary>
    public unsafe virtual void SetSourceStickyParameterEx(BmSDK.Engine.AkParameterName ParamName, float ParamValue, float NewReleaseValue, float NewReleaseTime, float NewSustainTime, float NewAttackTime, bool AllowPause)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSourceStickyParameterEx, "Engine.AkComponent.SetSourceStickyParameterEx");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParamName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParamValue, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewReleaseValue, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewReleaseTime, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSustainTime, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttackTime, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AllowPause, paramsPtr + 24);
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

    private static BmSDK.Function __fn_SetSourceStickyParameter;
    /// <summary>
    /// Function: SetSourceStickyParameter
    /// </summary>
    public unsafe virtual void SetSourceStickyParameter(BmSDK.Engine.AkParameterName ParamName, float ParamValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSourceStickyParameter, "Engine.AkComponent.SetSourceStickyParameter");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParamName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParamValue, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SetSourceStickyAudioEventEx;
    /// <summary>
    /// Function: SetSourceStickyAudioEventEx
    /// </summary>
    public unsafe virtual void SetSourceStickyAudioEventEx(BmSDK.Engine.AkEvent AudioEvent, float NewAttackTime, float NewSustainTime, float NewReleaseTime, BmSDK.Engine.AkParameterName ParamName, float newSustainValue = default, float NewReleaseValue = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSourceStickyAudioEventEx, "Engine.AkComponent.SetSourceStickyAudioEventEx");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AudioEvent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttackTime, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSustainTime, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewReleaseTime, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParamName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(newSustainValue, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewReleaseValue, paramsPtr + 24);
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

    private static BmSDK.Function __fn_SetSourceStickyAudioEvent;
    /// <summary>
    /// Function: SetSourceStickyAudioEvent
    /// </summary>
    public unsafe virtual void SetSourceStickyAudioEvent(BmSDK.Engine.AkEvent AudioEvent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSourceStickyAudioEvent, "Engine.AkComponent.SetSourceStickyAudioEvent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AudioEvent, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetSourceParameter;
    /// <summary>
    /// Function: GetSourceParameter
    /// </summary>
    public unsafe virtual float GetSourceParameter(BmSDK.Engine.AkParameterName ParamName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSourceParameter, "Engine.AkComponent.GetSourceParameter");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParamName, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetSourceParameter;
    /// <summary>
    /// Function: SetSourceParameter
    /// </summary>
    public unsafe virtual void SetSourceParameter(BmSDK.Engine.AkParameterName ParamName, float ParamValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSourceParameter, "Engine.AkComponent.SetSourceParameter");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParamName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParamValue, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SetPrimaryListener;
    /// <summary>
    /// Function: SetPrimaryListener
    /// </summary>
    public unsafe virtual void SetPrimaryListener(BmSDK.Engine.AkWwise.EListenerID Listener)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPrimaryListener, "Engine.AkComponent.SetPrimaryListener");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Listener, paramsPtr + 0);
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

    private static BmSDK.Function __fn_KillSounds;
    /// <summary>
    /// Function: KillSounds
    /// </summary>
    public unsafe virtual void KillSounds(bool DestroySources = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillSounds, "Engine.AkComponent.KillSounds");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DestroySources, paramsPtr + 0);
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

    private static BmSDK.Function __fn_IsSoundHandleValid;
    /// <summary>
    /// Function: IsSoundHandleValid
    /// </summary>
    public unsafe virtual bool IsSoundHandleValid(out BmSDK.Engine.AkWwise.FAkSoundHandle SoundHandleToTest)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSoundHandleValid, "Engine.AkComponent.IsSoundHandleValid");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SoundHandleToTest);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundHandleToTest, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        SoundHandleToTest = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkWwise.FAkSoundHandle>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_StopAudioEvent;
    /// <summary>
    /// Function: StopAudioEvent
    /// </summary>
    public unsafe virtual void StopAudioEvent(out BmSDK.Engine.AkWwise.FAkSoundHandle SoundHandle, bool QuickStop = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAudioEvent, "Engine.AkComponent.StopAudioEvent");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SoundHandle);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundHandle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QuickStop, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        SoundHandle = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkWwise.FAkSoundHandle>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_StartAuxAudioEvent;
    /// <summary>
    /// Function: StartAuxAudioEvent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkWwise.FAkSoundHandle StartAuxAudioEvent(BmSDK.Engine.AkEvent AudioEvent, System.Numerics.Vector3 Position, System.IntPtr SoundCallbackDelegate = default, int SoundCallbackFlags = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAuxAudioEvent, "Engine.AkComponent.StartAuxAudioEvent");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AudioEvent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundCallbackDelegate, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundCallbackFlags, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkWwise.FAkSoundHandle>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_StartLifeTimeEventInternal;
    /// <summary>
    /// Function: StartLifeTimeEventInternal
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkWwise.FAkSoundHandle StartLifeTimeEventInternal(BmSDK.Engine.AkEvent AudioEvent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartLifeTimeEventInternal, "Engine.AkComponent.StartLifeTimeEventInternal");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AudioEvent, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkWwise.FAkSoundHandle>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_StartAudioEvent;
    /// <summary>
    /// Function: StartAudioEvent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkWwise.FAkSoundHandle StartAudioEvent(BmSDK.Engine.AkEvent AudioEvent, System.IntPtr SoundCallbackDelegate = default, int SoundCallbackFlags = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAudioEvent, "Engine.AkComponent.StartAudioEvent");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AudioEvent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundCallbackDelegate, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundCallbackFlags, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkWwise.FAkSoundHandle>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetDistanceToListener;
    /// <summary>
    /// Function: GetDistanceToListener
    /// </summary>
    public unsafe virtual float GetDistanceToListener(BmSDK.Engine.AkWwise.EListenerID listenerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDistanceToListener, "Engine.AkComponent.GetDistanceToListener");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(listenerID, paramsPtr + 0);
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

    private static BmSDK.Function __fn_CheckListenerProximity;
    /// <summary>
    /// Function: CheckListenerProximity
    /// </summary>
    public unsafe virtual bool CheckListenerProximity(bool UpdateSpatial = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckListenerProximity, "Engine.AkComponent.CheckListenerProximity");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdateSpatial, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetAuxAudioSourceID;
    /// <summary>
    /// Function: GetAuxAudioSourceID
    /// </summary>
    public unsafe virtual int GetAuxAudioSourceID(bool AllowCreate = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAuxAudioSourceID, "Engine.AkComponent.GetAuxAudioSourceID");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AllowCreate, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetAudioSourceID;
    /// <summary>
    /// Function: GetAudioSourceID
    /// </summary>
    public unsafe virtual int GetAudioSourceID(bool AllowCreate = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAudioSourceID, "Engine.AkComponent.GetAudioSourceID");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AllowCreate, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HasAudioSource;
    /// <summary>
    /// Function: HasAudioSource
    /// </summary>
    public unsafe virtual bool HasAudioSource()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasAudioSource, "Engine.AkComponent.HasAudioSource");
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

    private static BmSDK.Function __fn_DestroyAudioSource;
    /// <summary>
    /// Function: DestroyAudioSource
    /// </summary>
    public unsafe virtual void DestroyAudioSource()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyAudioSource, "Engine.AkComponent.DestroyAudioSource");
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

    private static BmSDK.Function __fn_CreateAudioSource;
    /// <summary>
    /// Function: CreateAudioSource
    /// </summary>
    public unsafe virtual void CreateAudioSource()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateAudioSource, "Engine.AkComponent.CreateAudioSource");
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
    /// ObjectProperty: LifetimeEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent LifetimeEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }

    /// <summary>
    /// BoolProperty: AutoPlayLifetimeEvent
    /// </summary>
    public unsafe bool AutoPlayLifetimeEvent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// BoolProperty: NeverAutoDestroySource
    /// </summary>
    public unsafe bool NeverAutoDestroySource
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// BoolProperty: AlwaysAutoCreateSource
    /// </summary>
    public unsafe bool AlwaysAutoCreateSource
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// BoolProperty: AutoDestroySourceWhenHidden
    /// </summary>
    public unsafe bool AutoDestroySourceWhenHidden
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// BoolProperty: AutoDestroySourceWhenDead
    /// </summary>
    public unsafe bool AutoDestroySourceWhenDead
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// BoolProperty: KillSoundsOnDestroy
    /// </summary>
    public unsafe bool KillSoundsOnDestroy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// BoolProperty: WasInsideLODRadius
    /// </summary>
    public unsafe bool WasInsideLODRadius
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// BoolProperty: EnableCameraDistanceParameters
    /// </summary>
    public unsafe bool EnableCameraDistanceParameters
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// BoolProperty: EnableCameraOffsetParameters
    /// </summary>
    public unsafe bool EnableCameraOffsetParameters
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// BoolProperty: EnableCameraAngleParameters
    /// </summary>
    public unsafe bool EnableCameraAngleParameters
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// BoolProperty: EnablePlayerDistanceParameters
    /// </summary>
    public unsafe bool EnablePlayerDistanceParameters
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// BoolProperty: EnablePlayerOffsetParameters
    /// </summary>
    public unsafe bool EnablePlayerOffsetParameters
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// BoolProperty: EnablePlayerAngleParameters
    /// </summary>
    public unsafe bool EnablePlayerAngleParameters
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// BoolProperty: EnableObjectVelocityParameters
    /// </summary>
    public unsafe bool EnableObjectVelocityParameters
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// BoolProperty: Enable2DMode
    /// </summary>
    public unsafe bool Enable2DMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// BoolProperty: EnableDialogueMeter
    /// </summary>
    public unsafe bool EnableDialogueMeter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// BoolProperty: DialogueMeterEnabled
    /// </summary>
    public unsafe bool DialogueMeterEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// BoolProperty: EnableOcclusionParameters
    /// </summary>
    public unsafe bool EnableOcclusionParameters
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// BoolProperty: ParameterOnlyOcclusion
    /// </summary>
    public unsafe bool ParameterOnlyOcclusion
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// BoolProperty: UseDistanceBasedInterpolation
    /// </summary>
    public unsafe bool UseDistanceBasedInterpolation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// BoolProperty: EnableEnvironments
    /// </summary>
    public unsafe bool EnableEnvironments
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// BoolProperty: EnableNonListenerEnvironments
    /// </summary>
    public unsafe bool EnableNonListenerEnvironments
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// BoolProperty: DebugLastOcclusionPrimaryHit
    /// </summary>
    public unsafe bool DebugLastOcclusionPrimaryHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// BoolProperty: DebugLastOcclusionSecondaryAHit
    /// </summary>
    public unsafe bool DebugLastOcclusionSecondaryAHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// BoolProperty: DebugLastOcclusionSecondaryBHit
    /// </summary>
    public unsafe bool DebugLastOcclusionSecondaryBHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// BoolProperty: SourceActive
    /// </summary>
    public unsafe bool SourceActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// BoolProperty: AuxSourceActive
    /// </summary>
    public unsafe bool AuxSourceActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// BoolProperty: UseAuxSource
    /// </summary>
    public unsafe bool UseAuxSource
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// BoolProperty: DefaultAkComponent
    /// </summary>
    public unsafe bool DefaultAkComponent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }
    }

    /// <summary>
    /// StructProperty: LifetimeEventHandle
    /// </summary>
    public unsafe ref BmSDK.Engine.AkWwise.FAkSoundHandle LifetimeEventHandle
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 80);

    /// <summary>
    /// FloatProperty: PeakAudiblityRadius
    /// </summary>
    public unsafe float PeakAudiblityRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// FloatProperty: LODDestroyTimer
    /// </summary>
    public unsafe float LODDestroyTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// FloatProperty: ObjectVelocityFilterRCI
    /// </summary>
    public unsafe float ObjectVelocityFilterRCI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// FloatProperty: ObjectVelocityFilterRCD
    /// </summary>
    public unsafe float ObjectVelocityFilterRCD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ObjectProperty: DialogueMeterEffect
    /// </summary>
    public unsafe BmSDK.Engine.AkEnvironmentName DialogueMeterEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEnvironmentName>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// FloatProperty: OcclusionInterpolationDistance
    /// </summary>
    public unsafe float OcclusionInterpolationDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// FloatProperty: OcclusionUpdateTimeFast
    /// </summary>
    public unsafe float OcclusionUpdateTimeFast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// FloatProperty: OcclusionUpdateTimeSlow
    /// </summary>
    public unsafe float OcclusionUpdateTimeSlow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// FloatProperty: OcclusionInterpolationTime
    /// </summary>
    public unsafe float OcclusionInterpolationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// FloatProperty: OcclusionScalingDistance
    /// </summary>
    public unsafe float OcclusionScalingDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// FloatProperty: OcclusionMultiplier
    /// </summary>
    public unsafe float OcclusionMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// FloatProperty: OcclusionMultiplierAux
    /// </summary>
    public unsafe float OcclusionMultiplierAux
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// FloatProperty: WetDryMixVolume
    /// </summary>
    public unsafe float WetDryMixVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// FloatProperty: WetDryMixVolumeAux
    /// </summary>
    public unsafe float WetDryMixVolumeAux
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// FloatProperty: FalloffRadiusMultiplier
    /// </summary>
    public unsafe float FalloffRadiusMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// FloatProperty: FalloffEnhancementRadius
    /// </summary>
    public unsafe float FalloffEnhancementRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// StructProperty: FalloffEnhancementTimestamp
    /// </summary>
    public unsafe double FalloffEnhancementTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<double>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ByteProperty: PrimaryListener
    /// </summary>
    public unsafe BmSDK.Engine.AkWwise.EListenerID PrimaryListener
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkWwise.EListenerID>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ByteProperty: SpatialUpdateType
    /// </summary>
    public unsafe BmSDK.Engine.AkComponent.EAkComponentUpdate SpatialUpdateType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkComponent.EAkComponentUpdate>(Ptr + 165); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 165); }
    }

    /// <summary>
    /// ByteProperty: DebugLastFailedSourceCreateReason
    /// </summary>
    public unsafe BmSDK.Engine.AkComponent.EAkComponentSourceCreateFailReason DebugLastFailedSourceCreateReason
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkComponent.EAkComponentSourceCreateFailReason>(Ptr + 166); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 166); }
    }

    /// <summary>
    /// StructProperty: LastOcclusionUpdateTime
    /// </summary>
    public unsafe double LastOcclusionUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<double>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// FloatProperty: CurrentOcclusion
    /// </summary>
    public unsafe float CurrentOcclusion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// FloatProperty: TargetOcclusion
    /// </summary>
    public unsafe float TargetOcclusion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// FloatProperty: OcclusionVelocity
    /// </summary>
    public unsafe float OcclusionVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// StructProperty: LastOcclusionPostion
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastOcclusionPostion
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 188);

    /// <summary>
    /// StructProperty: LastOcclusionSourcePostion
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastOcclusionSourcePostion
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 200);

    /// <summary>
    /// StructProperty: DebugLastOcclusionPrimaryFrom
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DebugLastOcclusionPrimaryFrom
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 212);

    /// <summary>
    /// StructProperty: DebugLastOcclusionPrimaryTo
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DebugLastOcclusionPrimaryTo
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 224);

    /// <summary>
    /// StructProperty: DebugLastOcclusionSecondaryAFrom
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DebugLastOcclusionSecondaryAFrom
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 236);

    /// <summary>
    /// StructProperty: DebugLastOcclusionSecondaryATo
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DebugLastOcclusionSecondaryATo
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 248);

    /// <summary>
    /// StructProperty: DebugLastOcclusionSecondaryBFrom
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DebugLastOcclusionSecondaryBFrom
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 260);

    /// <summary>
    /// StructProperty: DebugLastOcclusionSecondaryBTo
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DebugLastOcclusionSecondaryBTo
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 272);

    /// <summary>
    /// StructProperty: SourcePosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SourcePosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 284);

    /// <summary>
    /// StructProperty: SourceOrientation
    /// </summary>
    public unsafe ref BmSDK.Rotator SourceOrientation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 296);

    /// <summary>
    /// FloatProperty: LastSourceVelocity
    /// </summary>
    public unsafe float LastSourceVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// StructProperty: LastSourceVelocityUpdateTime
    /// </summary>
    public unsafe double LastSourceVelocityUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<double>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// IntProperty: SourceID
    /// </summary>
    public unsafe int SourceID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// IntProperty: AuxSourceID
    /// </summary>
    public unsafe int AuxSourceID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// ArrayProperty: ActiveEnvironments
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkWwise.FAkEnvironmentInfo> ActiveEnvironments
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkWwise.FAkEnvironmentInfo>>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// ObjectProperty: DebugLastEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent DebugLastEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// ObjectProperty: DebugLastAuxEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent DebugLastAuxEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }

    /// <summary>
    /// StructProperty: DebugLastFailedSourceCreateTime
    /// </summary>
    public unsafe double DebugLastFailedSourceCreateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<double>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// FloatProperty: ReEnableLifeTimeDistance
    /// </summary>
    public unsafe float ReEnableLifeTimeDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// Enum: EAkComponentSourceCreateFailReason
    /// </summary>
    public enum EAkComponentSourceCreateFailReason : byte
    {
        AK_COMPONENT_SOURCE_CREATE_FAIL_REASON_NONE = 0,
        AK_COMPONENT_SOURCE_CREATE_FAIL_REASON_DISTANT = 1,
        AK_COMPONENT_SOURCE_CREATE_FAIL_REASON_HIDDEN = 2,
        AK_COMPONENT_SOURCE_CREATE_FAIL_REASON_DEAD = 3,
        AK_COMPONENT_SOURCE_CREATE_FAIL_REASON_ERROR = 4,
        AK_COMPONENT_SOURCE_CREATE_FAIL_REASON_MAX = 5,
    }

    /// <summary>
    /// Enum: EAkComponentUpdate
    /// </summary>
    public enum EAkComponentUpdate : byte
    {
        AK_COMPONENT_UPDATE_SINGLE_AUTO = 0,
        AK_COMPONENT_UPDATE_SINGLE_NO_AUTO = 1,
        AK_COMPONENT_UPDATE_MULTIPOINT_AUTO = 2,
        AK_COMPONENT_UPDATE_MULTIPOINT_NO_AUTO = 3,
        AK_COMPONENT_UPDATE_NEVER = 4,
        AK_COMPONENT_UPDATE_MAX = 5,
    }
}
