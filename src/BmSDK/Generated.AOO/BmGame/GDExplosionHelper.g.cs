#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDExplosionHelper<br/>
/// (size = 704)
/// (flags = 142643346)
/// </summary>
public partial class GDExplosionHelper : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDExplosionHelper", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDExplosionHelper.
    /// </summary>
    public static GDExplosionHelper DefaultObject => (GDExplosionHelper)StaticClass().DefaultObject;

    internal GDExplosionHelper() { }

    /// <summary>
    /// Constructs a new GDExplosionHelper
    /// </summary>
    public GDExplosionHelper(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDExplosionHelper Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDExplosionHelper(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDExplosionHelper>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDExplosionHelper>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDExplosionHelper>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDExplosionHelper>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDExplosionHelper>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDExplosionHelper>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDExplosionHelper>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDExplosionHelper>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_OwnerDestroyed;
    /// <summary>
    /// Function: OwnerDestroyed
    /// </summary>
    public unsafe virtual void OwnerDestroyed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OwnerDestroyed, "BmGame.GDExplosionHelper.OwnerDestroyed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnDecal;
    /// <summary>
    /// Function: SpawnDecal
    /// </summary>
    public unsafe virtual void SpawnDecal(System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal, in BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo Info)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnDecal, "BmGame.GDExplosionHelper.SpawnDecal");
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Info, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DecalTrace;
    /// <summary>
    /// Function: DecalTrace
    /// </summary>
    public unsafe virtual void DecalTrace(System.Numerics.Vector3 TraceDir, in BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo Info)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DecalTrace, "BmGame.GDExplosionHelper.DecalTrace");
        byte* paramsPtr = stackalloc byte[104];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceDir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Info, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnDecalsForImpactEffectInfo;
    /// <summary>
    /// Function: SpawnDecalsForImpactEffectInfo
    /// </summary>
    public unsafe virtual void SpawnDecalsForImpactEffectInfo(in BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo Info)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnDecalsForImpactEffectInfo, "BmGame.GDExplosionHelper.SpawnDecalsForImpactEffectInfo");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Info, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayDefaultExplosionAudio;
    /// <summary>
    /// Function: PlayDefaultExplosionAudio
    /// </summary>
    public unsafe virtual void PlayDefaultExplosionAudio()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayDefaultExplosionAudio, "BmGame.GDExplosionHelper.PlayDefaultExplosionAudio");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayDefaultExplosionPFX;
    /// <summary>
    /// Function: PlayDefaultExplosionPFX
    /// </summary>
    public unsafe virtual void PlayDefaultExplosionPFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayDefaultExplosionPFX, "BmGame.GDExplosionHelper.PlayDefaultExplosionPFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayAllDefaultExplosionEffects;
    /// <summary>
    /// Function: PlayAllDefaultExplosionEffects
    /// </summary>
    public unsafe virtual void PlayAllDefaultExplosionEffects()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayAllDefaultExplosionEffects, "BmGame.GDExplosionHelper.PlayAllDefaultExplosionEffects");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySurfaceExplosionAudio;
    /// <summary>
    /// Function: PlaySurfaceExplosionAudio
    /// </summary>
    public unsafe virtual void PlaySurfaceExplosionAudio(BmSDK.BmGame.RPhysicalMaterialProperty Surf, System.Numerics.Vector3 TraceLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySurfaceExplosionAudio, "BmGame.GDExplosionHelper.PlaySurfaceExplosionAudio");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Surf, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceLocation, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySurfaceExplosionPFX;
    /// <summary>
    /// Function: PlaySurfaceExplosionPFX
    /// </summary>
    public unsafe virtual void PlaySurfaceExplosionPFX(BmSDK.BmGame.RPhysicalMaterialProperty Surf, System.Numerics.Vector3 vLoc, BmSDK.Rotator rRot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySurfaceExplosionPFX, "BmGame.GDExplosionHelper.PlaySurfaceExplosionPFX");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Surf, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vLoc, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(rRot, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayAllSurfaceExplosionEffects;
    /// <summary>
    /// Function: PlayAllSurfaceExplosionEffects
    /// </summary>
    public unsafe virtual bool PlayAllSurfaceExplosionEffects(BmSDK.BmGame.RPhysicalMaterialProperty Surf, System.Numerics.Vector3 ImpactLocation, System.Numerics.Vector3 TraceLocation, System.Numerics.Vector3 TraceNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayAllSurfaceExplosionEffects, "BmGame.GDExplosionHelper.PlayAllSurfaceExplosionEffects");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Surf, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceNormal, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_TurnOffLight;
    /// <summary>
    /// Function: TurnOffLight
    /// </summary>
    public unsafe virtual void TurnOffLight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffLight, "BmGame.GDExplosionHelper.TurnOffLight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayLightFlash;
    /// <summary>
    /// Function: PlayLightFlash
    /// </summary>
    public unsafe virtual void PlayLightFlash(System.IntPtr LightCallback)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayLightFlash, "BmGame.GDExplosionHelper.PlayLightFlash");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LightCallback, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayAllExplosionEffects;
    /// <summary>
    /// Function: PlayAllExplosionEffects
    /// </summary>
    public unsafe virtual void PlayAllExplosionEffects(System.Numerics.Vector3 ImpactLocation, System.Numerics.Vector3 ImpactNormal, System.IntPtr LightCallback)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayAllExplosionEffects, "BmGame.GDExplosionHelper.PlayAllExplosionEffects");
        byte* paramsPtr = stackalloc byte[120];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LightCallback, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LightDoneCallback;
    /// <summary>
    /// Function: LightDoneCallback
    /// </summary>
    public unsafe virtual void LightDoneCallback()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LightDoneCallback, "BmGame.GDExplosionHelper.LightDoneCallback");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyFlashbang;
    /// <summary>
    /// Function: ApplyFlashbang
    /// </summary>
    public unsafe virtual void ApplyFlashbang(BmSDK.BmGame.RPlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyFlashbang, "BmGame.GDExplosionHelper.ApplyFlashbang");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyScreenShake;
    /// <summary>
    /// Function: ApplyScreenShake
    /// </summary>
    public unsafe virtual void ApplyScreenShake(BmSDK.Engine.Pawn Instigator, BmSDK.Engine.Pawn Receiver, float Multiplier)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyScreenShake, "BmGame.GDExplosionHelper.ApplyScreenShake");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Instigator, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Receiver, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Multiplier, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyToActor;
    /// <summary>
    /// Function: ApplyToActor
    /// </summary>
    public unsafe virtual void ApplyToActor(BmSDK.Engine.Actor ExplodingActor, float DamageFraction, BmSDK.Engine.Pawn Instigator)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyToActor, "BmGame.GDExplosionHelper.ApplyToActor");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExplodingActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageFraction, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Instigator, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyToPlayer;
    /// <summary>
    /// Function: ApplyToPlayer
    /// </summary>
    public unsafe virtual void ApplyToPlayer(BmSDK.BmGame.RPawnPlayer Victim, float DamageFraction, BmSDK.Engine.Pawn Instigator, float OverrideDamage = default, bool bDirectHit = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyToPlayer, "BmGame.GDExplosionHelper.ApplyToPlayer");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageFraction, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Instigator, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideDamage, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDirectHit, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetExplosionFXScale;
    /// <summary>
    /// Function: SetExplosionFXScale
    /// </summary>
    public unsafe virtual void SetExplosionFXScale(float NewExplosionFXScale)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetExplosionFXScale, "BmGame.GDExplosionHelper.SetExplosionFXScale");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewExplosionFXScale, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAudioCameraActor;
    /// <summary>
    /// Function: SetAudioCameraActor
    /// </summary>
    public unsafe virtual void SetAudioCameraActor(BmSDK.Engine.CameraActor AudioCameraActorToUse)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAudioCameraActor, "BmGame.GDExplosionHelper.SetAudioCameraActor");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AudioCameraActorToUse, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetExplosionType;
    /// <summary>
    /// Function: SetExplosionType
    /// </summary>
    public unsafe virtual void SetExplosionType(BmSDK.BmGame.GDExplosionHelper.EExplosionEffect ExplodeType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetExplosionType, "BmGame.GDExplosionHelper.SetExplosionType");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExplodeType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe virtual void Init(BmSDK.Engine.Actor NewOwner, System.Numerics.Vector3 ExplosionLoc = default, bool bShowDebug = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.GDExplosionHelper.Init");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExplosionLoc, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowDebug, paramsPtr + 16);
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

    private static BmSDK.Function __fn_CanSeeTarget;
    /// <summary>
    /// Function: CanSeeTarget
    /// </summary>
    public unsafe virtual bool CanSeeTarget(BmSDK.Engine.Actor Target, in BmSDK.TArray<BmSDK.FName> CheckBoneNames)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSeeTarget, "BmGame.GDExplosionHelper.CanSeeTarget");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckBoneNames, paramsPtr + 4);
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

    private static BmSDK.Function __fn_IsTargetValid;
    /// <summary>
    /// Function: IsTargetValid
    /// </summary>
    public unsafe virtual bool IsTargetValid(BmSDK.Engine.Actor Player, out float DamageFraction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTargetValid, "BmGame.GDExplosionHelper.IsTargetValid");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DamageFraction);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageFraction, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        DamageFraction = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Enum: EExplosionEffect
    /// </summary>
    public enum EExplosionEffect : byte
    {
        Explode_Frag = 0,
        Explode_Flashbang = 1,
        Explode_Confuse = 2,
        Explode_MAX = 3,
    }

    /// <summary>
    /// BoolProperty: CanHitHeroes
    /// </summary>
    public unsafe bool CanHitHeroes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: CanHitThugs
    /// </summary>
    public unsafe bool CanHitThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: CanHitExplodables
    /// </summary>
    public unsafe bool CanHitExplodables
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: CanBeHitByExplodables
    /// </summary>
    public unsafe bool CanBeHitByExplodables
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: CanHitInstigator
    /// </summary>
    public unsafe bool CanHitInstigator
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bStunFalloff
    /// </summary>
    public unsafe bool bStunFalloff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: PassThroughWalls
    /// </summary>
    public unsafe bool PassThroughWalls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bInvertVertical
    /// </summary>
    public unsafe bool bInvertVertical
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bInvertHorizontal
    /// </summary>
    public unsafe bool bInvertHorizontal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bLoopyCam
    /// </summary>
    public unsafe bool bLoopyCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bHitLocalPlayer
    /// </summary>
    public unsafe bool bHitLocalPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bDebug
    /// </summary>
    public unsafe bool bDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// FloatProperty: InstigatorDamageMultiplier
    /// </summary>
    public unsafe float InstigatorDamageMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// NameProperty: HeroTargetsInteractionClass
    /// </summary>
    public unsafe BmSDK.FName HeroTargetsInteractionClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// NameProperty: ThugTargetsInteractionClass
    /// </summary>
    public unsafe BmSDK.FName ThugTargetsInteractionClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// NameProperty: ExplodableTargetsInteractionClass
    /// </summary>
    public unsafe BmSDK.FName ExplodableTargetsInteractionClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }

    /// <summary>
    /// ObjectProperty: ThugTargets
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass ThugTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// ObjectProperty: HeroTargets
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass HeroTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: ExplodableTargets
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass ExplodableTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// StructProperty: ImpactedWallNormal
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ImpactedWallNormal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 92);

    /// <summary>
    /// FloatProperty: ImpactedWallNormalTraceAdjust
    /// </summary>
    public unsafe float ImpactedWallNormalTraceAdjust
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// FloatProperty: OuterBlastRadius
    /// </summary>
    public unsafe float OuterBlastRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// FloatProperty: InnerBlastRadius
    /// </summary>
    public unsafe float InnerBlastRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// FloatProperty: Damage
    /// </summary>
    public unsafe float Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// FloatProperty: HeadshotMultiplier
    /// </summary>
    public unsafe float HeadshotMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// FloatProperty: StunTime
    /// </summary>
    public unsafe float StunTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ArrayProperty: DetonateTargetCheckBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> DetonateTargetCheckBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// StructProperty: ScreenShakeEnemy
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ScreenShakeEnemy
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 140);

    /// <summary>
    /// StructProperty: ScreenShakeAlly
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ScreenShakeAlly
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 284);

    /// <summary>
    /// ObjectProperty: Owner
    /// </summary>
    public unsafe BmSDK.Engine.Actor Owner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// StructProperty: ExplosionLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ExplosionLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 432);

    /// <summary>
    /// ObjectProperty: AudioCameraActor
    /// </summary>
    public unsafe BmSDK.Engine.CameraActor AudioCameraActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CameraActor>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// ClassProperty: ExplosionDamageType
    /// </summary>
    public unsafe BmSDK.Class ExplosionDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// FloatProperty: WhiteTime
    /// </summary>
    public unsafe float WhiteTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// FloatProperty: FadeTime
    /// </summary>
    public unsafe float FadeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: ExplosionTypeEffects
    /// </summary>
    public InlineArray<BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo> ExplosionTypeEffects => new(3, Ptr + 460, 48, this);

    /// <summary>
    /// StructProperty: ExplosionTypeEffects
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo ExplosionTypeEffects_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo>(Ptr + 460);
    /// <summary>
    /// StructProperty: ExplosionTypeEffects
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo ExplosionTypeEffects_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo>(Ptr + 508);
    /// <summary>
    /// StructProperty: ExplosionTypeEffects
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo ExplosionTypeEffects_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo>(Ptr + 556);

    /// <summary>
    /// InlineArray{ObjectProperty}: NonHitSoundEvent
    /// </summary>
    public InlineArray<BmSDK.Engine.AkEvent> NonHitSoundEvent => new(3, Ptr + 604, 4, this);

    /// <summary>
    /// ObjectProperty: NonHitSoundEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent NonHitSoundEvent_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }
    /// <summary>
    /// ObjectProperty: NonHitSoundEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent NonHitSoundEvent_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }
    /// <summary>
    /// ObjectProperty: NonHitSoundEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent NonHitSoundEvent_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// ObjectProperty: PlayedEffectEmitter
    /// </summary>
    public unsafe BmSDK.Engine.Emitter PlayedEffectEmitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Emitter>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// FloatProperty: DecalTraceLength
    /// </summary>
    public unsafe float DecalTraceLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// ComponentProperty: CheapLight
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent CheapLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// InlineArray{ComponentProperty}: ExplosionTypeLights
    /// </summary>
    public InlineArray<BmSDK.Engine.PointLightComponent> ExplosionTypeLights => new(3, Ptr + 628, 4, this);

    /// <summary>
    /// ComponentProperty: ExplosionTypeLights
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent ExplosionTypeLights_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }
    /// <summary>
    /// ComponentProperty: ExplosionTypeLights
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent ExplosionTypeLights_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }
    /// <summary>
    /// ComponentProperty: ExplosionTypeLights
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent ExplosionTypeLights_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// FloatProperty: LightFlashTime
    /// </summary>
    public unsafe float LightFlashTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// FloatProperty: ConfusionTime
    /// </summary>
    public unsafe float ConfusionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: RelativeExplosionProbabilities
    /// </summary>
    public InlineArray<float> RelativeExplosionProbabilities => new(3, Ptr + 648, 4, this);

    /// <summary>
    /// FloatProperty: RelativeExplosionProbabilities
    /// </summary>
    public unsafe float RelativeExplosionProbabilities_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }
    /// <summary>
    /// FloatProperty: RelativeExplosionProbabilities
    /// </summary>
    public unsafe float RelativeExplosionProbabilities_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }
    /// <summary>
    /// FloatProperty: RelativeExplosionProbabilities
    /// </summary>
    public unsafe float RelativeExplosionProbabilities_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// ByteProperty: ExplosionType
    /// </summary>
    public unsafe BmSDK.BmGame.GDExplosionHelper.EExplosionEffect ExplosionType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDExplosionHelper.EExplosionEffect>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// ComponentProperty: CheapLightInstance
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent CheapLightInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// NameProperty: LightFlashCallbackName
    /// </summary>
    public unsafe BmSDK.FName LightFlashCallbackName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// FloatProperty: ExplosionFXScale
    /// </summary>
    public unsafe float ExplosionFXScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// DelegateProperty: LightDone
    /// </summary>
    public unsafe System.IntPtr LightDone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// DelegateProperty: __LightDoneCallback__Delegate
    /// </summary>
    public unsafe System.IntPtr __LightDoneCallback__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }
}
