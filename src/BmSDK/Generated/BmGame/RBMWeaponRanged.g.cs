#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RBMWeaponRanged<br/>
/// (size = 1124)
/// (flags = 209715379)
/// </summary>
public partial class RBMWeaponRanged : BmSDK.BmGame.RBMWeapon, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMWeaponRanged", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMWeaponRanged.
    /// </summary>
    public static RBMWeaponRanged DefaultObject => (RBMWeaponRanged)StaticClass().DefaultObject;

    internal RBMWeaponRanged() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMWeaponRanged(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMWeaponRanged>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponRanged>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMWeaponRanged>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponRanged>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponRanged>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponRanged>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMWeaponRanged>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponRanged>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetRECHitReactionAnimName;
    /// <summary>
    /// Function: GetRECHitReactionAnimName
    /// </summary>
    public unsafe override BmSDK.FName GetRECHitReactionAnimName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRECHitReactionAnimName, "BmGame.RBMWeaponRanged.GetRECHitReactionAnimName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TurnOffLaserSight;
    /// <summary>
    /// Function: TurnOffLaserSight
    /// </summary>
    public unsafe virtual void TurnOffLaserSight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffLaserSight, "BmGame.RBMWeaponRanged.TurnOffLaserSight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOnLaserSight;
    /// <summary>
    /// Function: TurnOnLaserSight
    /// </summary>
    public unsafe virtual void TurnOnLaserSight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOnLaserSight, "BmGame.RBMWeaponRanged.TurnOnLaserSight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDamage;
    /// <summary>
    /// Function: GetDamage
    /// </summary>
    public unsafe virtual float GetDamage(BmSDK.Engine.Actor Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamage, "BmGame.RBMWeaponRanged.GetDamage");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_RemoveMuzzleFlashEffect;
    /// <summary>
    /// Function: RemoveMuzzleFlashEffect
    /// </summary>
    public unsafe virtual void RemoveMuzzleFlashEffect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveMuzzleFlashEffect, "BmGame.RBMWeaponRanged.RemoveMuzzleFlashEffect");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateMuzzleFlashPS;
    /// <summary>
    /// Function: ActivateMuzzleFlashPS
    /// </summary>
    public unsafe virtual void ActivateMuzzleFlashPS()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateMuzzleFlashPS, "BmGame.RBMWeaponRanged.ActivateMuzzleFlashPS");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CauseMuzzleFlash;
    /// <summary>
    /// Function: CauseMuzzleFlash
    /// </summary>
    public unsafe virtual void CauseMuzzleFlash()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CauseMuzzleFlash, "BmGame.RBMWeaponRanged.CauseMuzzleFlash");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Rendered3PRecently;
    /// <summary>
    /// Function: Rendered3PRecently
    /// </summary>
    public unsafe virtual bool Rendered3PRecently()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Rendered3PRecently, "BmGame.RBMWeaponRanged.Rendered3PRecently");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTraceOwner;
    /// <summary>
    /// Function: GetTraceOwner
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor GetTraceOwner()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTraceOwner, "BmGame.RBMWeaponRanged.GetTraceOwner");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetImpactMaterial;
    /// <summary>
    /// Function: GetImpactMaterial
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPhysicalMaterialProperty GetImpactMaterial(BmSDK.Engine.Actor.FImpactInfo Impact)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetImpactMaterial, "BmGame.RBMWeaponRanged.GetImpactMaterial");
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Impact, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPhysicalMaterialProperty>(paramsPtr + 88);
    }

    private static BmSDK.Function __fn_SpawnBulletFX;
    /// <summary>
    /// Function: SpawnBulletFX
    /// </summary>
    public unsafe virtual void SpawnBulletFX(System.Numerics.Vector3 StartLoc, BmSDK.Engine.Actor.FImpactInfo Impact)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnBulletFX, "BmGame.RBMWeaponRanged.SpawnBulletFX");
        byte* paramsPtr = stackalloc byte[140];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Impact, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CalcImpact;
    /// <summary>
    /// Function: CalcImpact
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor.FImpactInfo CalcImpact(System.Numerics.Vector3 StartTrace, System.Numerics.Vector3 EndTrace)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalcImpact, "BmGame.RBMWeaponRanged.CalcImpact");
        byte* paramsPtr = stackalloc byte[280];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartTrace, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndTrace, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FImpactInfo>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetRandDeviance;
    /// <summary>
    /// Function: GetRandDeviance
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetRandDeviance(BmSDK.Rotator Heading)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRandDeviance, "BmGame.RBMWeaponRanged.GetRandDeviance");
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Heading, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_DoShotFX;
    /// <summary>
    /// Function: DoShotFX
    /// </summary>
    public unsafe virtual void DoShotFX(BmSDK.Engine.Actor HitTarget = default, bool bShouldHit = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoShotFX, "BmGame.RBMWeaponRanged.DoShotFX");
        byte* paramsPtr = stackalloc byte[192];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldHit, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AdjustAimToMiss;
    /// <summary>
    /// Function: AdjustAimToMiss
    /// </summary>
    public unsafe virtual void AdjustAimToMiss(BmSDK.Engine.Actor TargetActor, float Inaccuracy, bool bKnowHidden = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdjustAimToMiss, "BmGame.RBMWeaponRanged.AdjustAimToMiss");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Inaccuracy, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKnowHidden, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AdjustAimToHit;
    /// <summary>
    /// Function: AdjustAimToHit
    /// </summary>
    public unsafe virtual void AdjustAimToHit(BmSDK.Engine.Actor TargetActor, bool bCanFire)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdjustAimToHit, "BmGame.RBMWeaponRanged.AdjustAimToHit");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanFire, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AdjustAimForward;
    /// <summary>
    /// Function: AdjustAimForward
    /// </summary>
    public unsafe virtual void AdjustAimForward()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdjustAimForward, "BmGame.RBMWeaponRanged.AdjustAimForward");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ItemRemovedFromInvManager;
    /// <summary>
    /// Function: ItemRemovedFromInvManager
    /// </summary>
    public unsafe override void ItemRemovedFromInvManager()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ItemRemovedFromInvManager, "BmGame.RBMWeaponRanged.ItemRemovedFromInvManager");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachWeapon;
    /// <summary>
    /// Function: AttachWeapon
    /// </summary>
    public unsafe override void AttachWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachWeapon, "BmGame.RBMWeaponRanged.AttachWeapon");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetEdgeOfCylinder;
    /// <summary>
    /// Function: GetEdgeOfCylinder
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetEdgeOfCylinder(System.Numerics.Vector3 AimFromPoint, System.Numerics.Vector3 CurrentAimDir, System.Numerics.Vector3 CylinderCentre, float CylinderRadius, float CylinderHeight)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEdgeOfCylinder, "BmGame.RBMWeaponRanged.GetEdgeOfCylinder");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimFromPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentAimDir, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CylinderCentre, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CylinderRadius, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CylinderHeight, paramsPtr + 40);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_GetAudioSpatial;
    /// <summary>
    /// Function: GetAudioSpatial
    /// </summary>
    public unsafe override void GetAudioSpatial(BmSDK.Engine.AkComponent akComp, out System.Numerics.Vector3 SoundPosition, out BmSDK.Rotator SoundOrientation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAudioSpatial, "BmGame.RBMWeaponRanged.GetAudioSpatial");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(akComp, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SoundPosition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundPosition, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SoundOrientation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundOrientation, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        SoundPosition = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
        SoundOrientation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_OverrideAkComponentDefaults;
    /// <summary>
    /// Function: OverrideAkComponentDefaults
    /// </summary>
    public unsafe override void OverrideAkComponentDefaults(BmSDK.Engine.AkComponent akComp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideAkComponentDefaults, "BmGame.RBMWeaponRanged.OverrideAkComponentDefaults");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(akComp, paramsPtr + 0);
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

    private static BmSDK.Function __fn_StopWeaponFireAudio;
    /// <summary>
    /// Function: StopWeaponFireAudio
    /// </summary>
    public unsafe virtual void StopWeaponFireAudio()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopWeaponFireAudio, "BmGame.RBMWeaponRanged.StopWeaponFireAudio");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartWeaponFireAudio;
    /// <summary>
    /// Function: StartWeaponFireAudio
    /// </summary>
    public unsafe virtual void StartWeaponFireAudio(bool Burst)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartWeaponFireAudio, "BmGame.RBMWeaponRanged.StartWeaponFireAudio");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Burst, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupWeaponAudio;
    /// <summary>
    /// Function: SetupWeaponAudio
    /// </summary>
    public unsafe virtual void SetupWeaponAudio()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupWeaponAudio, "BmGame.RBMWeaponRanged.SetupWeaponAudio");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RBMWeaponRanged.Destroyed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreStreamOut;
    /// <summary>
    /// Function: PreStreamOut
    /// </summary>
    public unsafe override void PreStreamOut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmGame.RBMWeaponRanged.PreStreamOut");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTickIsDisabled;
    /// <summary>
    /// Function: SetTickIsDisabled
    /// </summary>
    public unsafe override void SetTickIsDisabled(bool bInDisabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTickIsDisabled, "BmGame.RBMWeaponRanged.SetTickIsDisabled");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInDisabled, paramsPtr + 0);
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
    /// FloatProperty: ShotTime
    /// </summary>
    public unsafe float ShotTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: ShotDamage
    /// </summary>
    public InlineArray<float> ShotDamage => new(3, Ptr + 980, 4, this);

    /// <summary>
    /// FloatProperty: ShotDamage
    /// </summary>
    public unsafe float ShotDamage_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }
    /// <summary>
    /// FloatProperty: ShotDamage
    /// </summary>
    public unsafe float ShotDamage_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }
    /// <summary>
    /// FloatProperty: ShotDamage
    /// </summary>
    public unsafe float ShotDamage_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// FloatProperty: FakeDamageAmount
    /// </summary>
    public unsafe float FakeDamageAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// IntProperty: BurstSize
    /// </summary>
    public unsafe int BurstSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// FloatProperty: BurstPause
    /// </summary>
    public unsafe float BurstPause
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// IntProperty: ClipSize
    /// </summary>
    public unsafe int ClipSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// BoolProperty: bMissAtRange
    /// </summary>
    public unsafe bool bMissAtRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: bRandomiseBurst
    /// </summary>
    public unsafe bool bRandomiseBurst
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: bLaserSightOn
    /// </summary>
    public unsafe bool bLaserSightOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: bExtremeDamage
    /// </summary>
    public unsafe bool bExtremeDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// ComponentProperty: MuzzleFlashLight
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent MuzzleFlashLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// NameProperty: MuzzleFlashLightSocket
    /// </summary>
    public unsafe BmSDK.FName MuzzleFlashLightSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// ComponentProperty: MuzzleFlash
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent MuzzleFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// NameProperty: MuzzleFlashSocket
    /// </summary>
    public unsafe BmSDK.FName MuzzleFlashSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// ObjectProperty: TracerFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem TracerFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// StructProperty: AimLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AimLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1040);

    /// <summary>
    /// FloatProperty: ShotDeviance
    /// </summary>
    public unsafe float ShotDeviance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// NameProperty: TerrifiedCornerOutLeftAnimName
    /// </summary>
    public unsafe BmSDK.FName TerrifiedCornerOutLeftAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// NameProperty: TerrifiedCornerOutRightAnimName
    /// </summary>
    public unsafe BmSDK.FName TerrifiedCornerOutRightAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// NameProperty: RecoilAnimName
    /// </summary>
    public unsafe BmSDK.FName RecoilAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ObjectProperty: RecoilAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet RecoilAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// StructProperty: LaserEndPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LaserEndPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1084);

    /// <summary>
    /// ObjectProperty: WeaponFireEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent WeaponFireEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ObjectProperty: WeaponFireLoopEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent WeaponFireLoopEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// ObjectProperty: WeaponSwitch
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName WeaponSwitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// FloatProperty: WeaponOcclusionMultiplier
    /// </summary>
    public unsafe float WeaponOcclusionMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// StructProperty: WeaponFireSoundHandle
    /// </summary>
    public unsafe ref BmSDK.Engine.AkWwise.FAkSoundHandle WeaponFireSoundHandle
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 1112);
}
