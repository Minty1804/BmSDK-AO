#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDPawnPlayerThugBase<br/>
/// (size = 7604)
/// (flags = 144736438)
/// </summary>
public partial class GDPawnPlayerThugBase : BmSDK.BmGame.RPawnPlayer, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDPawnPlayerThugBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDPawnPlayerThugBase.
    /// </summary>
    public static GDPawnPlayerThugBase DefaultObject => (GDPawnPlayerThugBase)StaticClass().DefaultObject;

    internal GDPawnPlayerThugBase() { }

    /// <summary>
    /// Constructs a new GDPawnPlayerThugBase
    /// </summary>
    public GDPawnPlayerThugBase(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDPawnPlayerThugBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerThugBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerThugBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerThugBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerThugBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerThugBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerThugBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerThugBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerThugBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_IsDoingMove2IdleTransition;
    /// <summary>
    /// Function: IsDoingMove2IdleTransition
    /// </summary>
    public unsafe virtual bool IsDoingMove2IdleTransition()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDoingMove2IdleTransition, "BmGame.GDPawnPlayerThugBase.IsDoingMove2IdleTransition");
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

    private static BmSDK.Function __fn_GetControllableGadgetIconString;
    /// <summary>
    /// Function: GetControllableGadgetIconString
    /// </summary>
    public unsafe virtual BmSDK.FString GetControllableGadgetIconString()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetControllableGadgetIconString, "BmGame.GDPawnPlayerThugBase.GetControllableGadgetIconString");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetControllableGadget;
    /// <summary>
    /// Function: GetControllableGadget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RInventoryGadget GetControllableGadget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetControllableGadget, "BmGame.GDPawnPlayerThugBase.GetControllableGadget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RInventoryGadget>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetControllableGadgetTimeRemaining;
    /// <summary>
    /// Function: GetControllableGadgetTimeRemaining
    /// </summary>
    public unsafe virtual float GetControllableGadgetTimeRemaining(BmSDK.BmGame.RInventoryGadget Gadget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetControllableGadgetTimeRemaining, "BmGame.GDPawnPlayerThugBase.GetControllableGadgetTimeRemaining");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Gadget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetPawnCharacterTransition;
    /// <summary>
    /// Function: SetPawnCharacterTransition
    /// </summary>
    public unsafe virtual void SetPawnCharacterTransition(float InSecs)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPawnCharacterTransition, "BmGame.GDPawnPlayerThugBase.SetPawnCharacterTransition");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSecs, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReattachSkeletalMeshAndChildComponents;
    /// <summary>
    /// Function: ReattachSkeletalMeshAndChildComponents
    /// </summary>
    public unsafe virtual void ReattachSkeletalMeshAndChildComponents(BmSDK.Engine.SkeletalMeshComponent ParentSkeletalMesh)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReattachSkeletalMeshAndChildComponents, "BmGame.GDPawnPlayerThugBase.ReattachSkeletalMeshAndChildComponents");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParentSkeletalMesh, paramsPtr + 0);
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

    private static BmSDK.Function __fn_PlayExplosionDeathPrimer;
    /// <summary>
    /// Function: PlayExplosionDeathPrimer
    /// </summary>
    public unsafe override bool PlayExplosionDeathPrimer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayExplosionDeathPrimer, "BmGame.GDPawnPlayerThugBase.PlayExplosionDeathPrimer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopGlideKickFX;
    /// <summary>
    /// Function: StopGlideKickFX
    /// </summary>
    public unsafe override void StopGlideKickFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopGlideKickFX, "BmGame.GDPawnPlayerThugBase.StopGlideKickFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartGlideKickFX;
    /// <summary>
    /// Function: StartGlideKickFX
    /// </summary>
    public unsafe override void StartGlideKickFX(BmSDK.Engine.ParticleSystem OverrideFX, BmSDK.BmGame.RPlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartGlideKickFX, "BmGame.GDPawnPlayerThugBase.StartGlideKickFX");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideFX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveMultiplayerAura;
    /// <summary>
    /// Function: RemoveMultiplayerAura
    /// </summary>
    public unsafe override void RemoveMultiplayerAura()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveMultiplayerAura, "BmGame.GDPawnPlayerThugBase.RemoveMultiplayerAura");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateMultiplayerAura;
    /// <summary>
    /// Function: ActivateMultiplayerAura
    /// </summary>
    public unsafe override void ActivateMultiplayerAura(BmSDK.Engine.MaterialInterface AuraMat)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateMultiplayerAura, "BmGame.GDPawnPlayerThugBase.ActivateMultiplayerAura");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AuraMat, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOnHandsIk;
    /// <summary>
    /// Function: TurnOnHandsIk
    /// </summary>
    public unsafe override bool TurnOnHandsIk(float fStrengthValue, float fEaseInTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOnHandsIk, "BmGame.GDPawnPlayerThugBase.TurnOnHandsIk");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fStrengthValue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fEaseInTime, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetPropsInXray;
    /// <summary>
    /// Function: SetPropsInXray
    /// </summary>
    public unsafe virtual void SetPropsInXray(bool bActivate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPropsInXray, "BmGame.GDPawnPlayerThugBase.SetPropsInXray");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActivate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPropsInThermal;
    /// <summary>
    /// Function: SetPropsInThermal
    /// </summary>
    public unsafe virtual void SetPropsInThermal(bool bActivate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPropsInThermal, "BmGame.GDPawnPlayerThugBase.SetPropsInThermal");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActivate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMultiplayerAuraForXray;
    /// <summary>
    /// Function: SetMultiplayerAuraForXray
    /// </summary>
    public unsafe virtual void SetMultiplayerAuraForXray(bool xray_active)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMultiplayerAuraForXray, "BmGame.GDPawnPlayerThugBase.SetMultiplayerAuraForXray");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(xray_active, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitXRayMode;
    /// <summary>
    /// Function: ExitXRayMode
    /// </summary>
    public unsafe override void ExitXRayMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitXRayMode, "BmGame.GDPawnPlayerThugBase.ExitXRayMode");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPostLadderPose;
    /// <summary>
    /// Function: GetPostLadderPose
    /// </summary>
    public unsafe override BmSDK.FName GetPostLadderPose()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPostLadderPose, "BmGame.GDPawnPlayerThugBase.GetPostLadderPose");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPostLandPose;
    /// <summary>
    /// Function: GetPostLandPose
    /// </summary>
    public unsafe override BmSDK.FName GetPostLandPose()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPostLandPose, "BmGame.GDPawnPlayerThugBase.GetPostLandPose");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsInAimingMode;
    /// <summary>
    /// Function: IsInAimingMode
    /// </summary>
    public unsafe override bool IsInAimingMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInAimingMode, "BmGame.GDPawnPlayerThugBase.IsInAimingMode");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsDualWielding;
    /// <summary>
    /// Function: IsDualWielding
    /// </summary>
    public unsafe virtual bool IsDualWielding()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDualWielding, "BmGame.GDPawnPlayerThugBase.IsDualWielding");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGlideKickEffectLocation;
    /// <summary>
    /// Function: GetGlideKickEffectLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetGlideKickEffectLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGlideKickEffectLocation, "BmGame.GDPawnPlayerThugBase.GetGlideKickEffectLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateMeshBoneControllers;
    /// <summary>
    /// Function: UpdateMeshBoneControllers
    /// </summary>
    public unsafe virtual void UpdateMeshBoneControllers(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateMeshBoneControllers, "BmGame.GDPawnPlayerThugBase.UpdateMeshBoneControllers");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateMeshBoneControllersNative;
    /// <summary>
    /// Function: UpdateMeshBoneControllersNative
    /// </summary>
    public unsafe virtual void UpdateMeshBoneControllersNative(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateMeshBoneControllersNative, "BmGame.GDPawnPlayerThugBase.UpdateMeshBoneControllersNative");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SpecialMoveEnded;
    /// <summary>
    /// Function: SpecialMoveEnded
    /// </summary>
    public unsafe virtual void SpecialMoveEnded(BmSDK.BmGame.GDPawnPlayerThugBase.ESpecialMove PrevMove, BmSDK.BmGame.GDPawnPlayerThugBase.ESpecialMove NextMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpecialMoveEnded, "BmGame.GDPawnPlayerThugBase.SpecialMoveEnded");
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PrevMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextMove, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FillSMStructFromParams;
    /// <summary>
    /// Function: FillSMStructFromParams
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDPawnPlayerThugBase.FSMStruct FillSMStructFromParams(BmSDK.BmGame.GDPawnPlayerThugBase.ESpecialMove InSpecialMove, BmSDK.BmGame.GDPawnPlayerThugBase InInteractionPawn = default, int InSpecialMoveFlags = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FillSMStructFromParams, "BmGame.GDPawnPlayerThugBase.FillSMStructFromParams");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSpecialMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInteractionPawn, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSpecialMoveFlags, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDPawnPlayerThugBase.FSMStruct>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_DoSpecialMove;
    /// <summary>
    /// Function: DoSpecialMove
    /// </summary>
    public unsafe virtual void DoSpecialMove(BmSDK.BmGame.GDPawnPlayerThugBase.ESpecialMove NewMove, bool bForceMove = default, BmSDK.BmGame.GDPawnPlayerThugBase InInteractionPawn = default, int InSpecialMoveFlags = default, bool bSkipReplication = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoSpecialMove, "BmGame.GDPawnPlayerThugBase.DoSpecialMove");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceMove, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInteractionPawn, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSpecialMoveFlags, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSkipReplication, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsDoingASpecialMove;
    /// <summary>
    /// Function: IsDoingASpecialMove
    /// </summary>
    public unsafe virtual bool IsDoingASpecialMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDoingASpecialMove, "BmGame.GDPawnPlayerThugBase.IsDoingASpecialMove");
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

    private static BmSDK.Function __fn_IsDoingSpecialMove;
    /// <summary>
    /// Function: IsDoingSpecialMove
    /// </summary>
    public unsafe virtual bool IsDoingSpecialMove(BmSDK.BmGame.GDPawnPlayerThugBase.ESpecialMove AMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDoingSpecialMove, "BmGame.GDPawnPlayerThugBase.IsDoingSpecialMove");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AMove, paramsPtr + 0);
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

    private static BmSDK.Function __fn_CanDoSpecialMove;
    /// <summary>
    /// Function: CanDoSpecialMove
    /// </summary>
    public unsafe virtual bool CanDoSpecialMove(BmSDK.BmGame.GDPawnPlayerThugBase.ESpecialMove AMove, bool bForceCheck = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoSpecialMove, "BmGame.GDPawnPlayerThugBase.CanDoSpecialMove");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceCheck, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AddRadioTransitionsToWeaponConfig;
    /// <summary>
    /// Function: AddRadioTransitionsToWeaponConfig
    /// </summary>
    public unsafe virtual void AddRadioTransitionsToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddRadioTransitionsToWeaponConfig, "BmGame.GDPawnPlayerThugBase.AddRadioTransitionsToWeaponConfig");
        byte* paramsPtr = stackalloc byte[160];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupRadioPose;
    /// <summary>
    /// Function: SetupRadioPose
    /// </summary>
    public unsafe virtual void SetupRadioPose(out BmSDK.BmGame.RPoseConfig.FPose RadioPose)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupRadioPose, "BmGame.GDPawnPlayerThugBase.SetupRadioPose");
        byte* paramsPtr = stackalloc byte[356];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        RadioPose = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetupAimingPose;
    /// <summary>
    /// Function: SetupAimingPose
    /// </summary>
    public unsafe virtual void SetupAimingPose(out BmSDK.BmGame.RPoseConfig.FPose AimingPose, BmSDK.Engine.AnimSet IdleOverlayAnimSet = default, BmSDK.Engine.AnimSet MovementAnimSet = default, BmSDK.BmGame.RPawnPlayerAnim.FAllowedMovementTypes MovementTypes = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupAimingPose, "BmGame.GDPawnPlayerThugBase.SetupAimingPose");
        byte* paramsPtr = stackalloc byte[488];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IdleOverlayAnimSet, paramsPtr + 340);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementAnimSet, paramsPtr + 344);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementTypes, paramsPtr + 348);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AimingPose = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_AddBlockingPoseToWeaponConfig;
    /// <summary>
    /// Function: AddBlockingPoseToWeaponConfig
    /// </summary>
    public unsafe virtual void AddBlockingPoseToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddBlockingPoseToWeaponConfig, "BmGame.GDPawnPlayerThugBase.AddBlockingPoseToWeaponConfig");
        byte* paramsPtr = stackalloc byte[364];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupThugCoverHalfLeanRightPose;
    /// <summary>
    /// Function: SetupThugCoverHalfLeanRightPose
    /// </summary>
    public unsafe virtual void SetupThugCoverHalfLeanRightPose(out BmSDK.BmGame.RPoseConfig.FPose CoverPose)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupThugCoverHalfLeanRightPose, "BmGame.GDPawnPlayerThugBase.SetupThugCoverHalfLeanRightPose");
        byte* paramsPtr = stackalloc byte[356];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CoverPose = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetupThugCoverFullLeanHighRightPose;
    /// <summary>
    /// Function: SetupThugCoverFullLeanHighRightPose
    /// </summary>
    public unsafe virtual void SetupThugCoverFullLeanHighRightPose(out BmSDK.BmGame.RPoseConfig.FPose CoverPose)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupThugCoverFullLeanHighRightPose, "BmGame.GDPawnPlayerThugBase.SetupThugCoverFullLeanHighRightPose");
        byte* paramsPtr = stackalloc byte[356];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CoverPose = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetupThugCoverFullLeanRightPose;
    /// <summary>
    /// Function: SetupThugCoverFullLeanRightPose
    /// </summary>
    public unsafe virtual void SetupThugCoverFullLeanRightPose(out BmSDK.BmGame.RPoseConfig.FPose CoverPose)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupThugCoverFullLeanRightPose, "BmGame.GDPawnPlayerThugBase.SetupThugCoverFullLeanRightPose");
        byte* paramsPtr = stackalloc byte[356];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CoverPose = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetupThugCoverPopUpAimPose180;
    /// <summary>
    /// Function: SetupThugCoverPopUpAimPose180
    /// </summary>
    public unsafe virtual void SetupThugCoverPopUpAimPose180(out BmSDK.BmGame.RPoseConfig.FPose CoverPose)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupThugCoverPopUpAimPose180, "BmGame.GDPawnPlayerThugBase.SetupThugCoverPopUpAimPose180");
        byte* paramsPtr = stackalloc byte[356];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CoverPose = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetupThugCoverPopUpPose180;
    /// <summary>
    /// Function: SetupThugCoverPopUpPose180
    /// </summary>
    public unsafe virtual void SetupThugCoverPopUpPose180(out BmSDK.BmGame.RPoseConfig.FPose CoverPose)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupThugCoverPopUpPose180, "BmGame.GDPawnPlayerThugBase.SetupThugCoverPopUpPose180");
        byte* paramsPtr = stackalloc byte[356];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CoverPose = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetupThugCoverPopUpAimPose;
    /// <summary>
    /// Function: SetupThugCoverPopUpAimPose
    /// </summary>
    public unsafe virtual void SetupThugCoverPopUpAimPose(out BmSDK.BmGame.RPoseConfig.FPose CoverPose)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupThugCoverPopUpAimPose, "BmGame.GDPawnPlayerThugBase.SetupThugCoverPopUpAimPose");
        byte* paramsPtr = stackalloc byte[356];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CoverPose = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetupThugCoverPopUpPose;
    /// <summary>
    /// Function: SetupThugCoverPopUpPose
    /// </summary>
    public unsafe virtual void SetupThugCoverPopUpPose(out BmSDK.BmGame.RPoseConfig.FPose CoverPose)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupThugCoverPopUpPose, "BmGame.GDPawnPlayerThugBase.SetupThugCoverPopUpPose");
        byte* paramsPtr = stackalloc byte[356];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CoverPose = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetupThugCoverFullRightPose;
    /// <summary>
    /// Function: SetupThugCoverFullRightPose
    /// </summary>
    public unsafe virtual void SetupThugCoverFullRightPose(out BmSDK.BmGame.RPoseConfig.FPose CoverPose)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupThugCoverFullRightPose, "BmGame.GDPawnPlayerThugBase.SetupThugCoverFullRightPose");
        byte* paramsPtr = stackalloc byte[356];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CoverPose = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetupThugCoverHalfRightPose180;
    /// <summary>
    /// Function: SetupThugCoverHalfRightPose180
    /// </summary>
    public unsafe virtual void SetupThugCoverHalfRightPose180(out BmSDK.BmGame.RPoseConfig.FPose CoverPose)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupThugCoverHalfRightPose180, "BmGame.GDPawnPlayerThugBase.SetupThugCoverHalfRightPose180");
        byte* paramsPtr = stackalloc byte[356];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CoverPose = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetupThugCoverHalfRightPose;
    /// <summary>
    /// Function: SetupThugCoverHalfRightPose
    /// </summary>
    public unsafe virtual void SetupThugCoverHalfRightPose(out BmSDK.BmGame.RPoseConfig.FPose CoverPose)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupThugCoverHalfRightPose, "BmGame.GDPawnPlayerThugBase.SetupThugCoverHalfRightPose");
        byte* paramsPtr = stackalloc byte[356];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CoverPose = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetupThugCoverMovePopUpAimRightPose;
    /// <summary>
    /// Function: SetupThugCoverMovePopUpAimRightPose
    /// </summary>
    public unsafe virtual void SetupThugCoverMovePopUpAimRightPose(out BmSDK.BmGame.RPoseConfig.FPose CoverPose)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupThugCoverMovePopUpAimRightPose, "BmGame.GDPawnPlayerThugBase.SetupThugCoverMovePopUpAimRightPose");
        byte* paramsPtr = stackalloc byte[356];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CoverPose = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetupThugCoverMovePopUpRightPose;
    /// <summary>
    /// Function: SetupThugCoverMovePopUpRightPose
    /// </summary>
    public unsafe virtual void SetupThugCoverMovePopUpRightPose(out BmSDK.BmGame.RPoseConfig.FPose CoverPose)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupThugCoverMovePopUpRightPose, "BmGame.GDPawnPlayerThugBase.SetupThugCoverMovePopUpRightPose");
        byte* paramsPtr = stackalloc byte[356];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CoverPose = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetupThugCoverMoveFullRightPose;
    /// <summary>
    /// Function: SetupThugCoverMoveFullRightPose
    /// </summary>
    public unsafe virtual void SetupThugCoverMoveFullRightPose(out BmSDK.BmGame.RPoseConfig.FPose CoverPose)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupThugCoverMoveFullRightPose, "BmGame.GDPawnPlayerThugBase.SetupThugCoverMoveFullRightPose");
        byte* paramsPtr = stackalloc byte[356];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CoverPose = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetupThugCoverGenericPose;
    /// <summary>
    /// Function: SetupThugCoverGenericPose
    /// </summary>
    public unsafe virtual void SetupThugCoverGenericPose(out BmSDK.BmGame.RPoseConfig.FPose CoverPose)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupThugCoverGenericPose, "BmGame.GDPawnPlayerThugBase.SetupThugCoverGenericPose");
        byte* paramsPtr = stackalloc byte[356];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CoverPose = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetupThugCoverMoveHalfRightPose;
    /// <summary>
    /// Function: SetupThugCoverMoveHalfRightPose
    /// </summary>
    public unsafe virtual void SetupThugCoverMoveHalfRightPose(out BmSDK.BmGame.RPoseConfig.FPose CoverPose)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupThugCoverMoveHalfRightPose, "BmGame.GDPawnPlayerThugBase.SetupThugCoverMoveHalfRightPose");
        byte* paramsPtr = stackalloc byte[356];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CoverPose = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_AddMovementMovesToWeaponConfig;
    /// <summary>
    /// Function: AddMovementMovesToWeaponConfig
    /// </summary>
    public unsafe override void AddMovementMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddMovementMovesToWeaponConfig, "BmGame.GDPawnPlayerThugBase.AddMovementMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[5736];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AimInDirection;
    /// <summary>
    /// Function: AimInDirection
    /// </summary>
    public unsafe override void AimInDirection(System.Numerics.Vector3 Direction, BmSDK.FName Description = default, BmSDK.BmGame.RAnimConfig.EYesNoDefault AllowTurningToAim = default, float LimitScale = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AimInDirection, "BmGame.GDPawnPlayerThugBase.AimInDirection");
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

    private static BmSDK.Function __fn_AimPoseAtPoint;
    /// <summary>
    /// Function: AimPoseAtPoint
    /// </summary>
    public unsafe virtual void AimPoseAtPoint(System.Numerics.Vector3 AimPoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AimPoseAtPoint, "BmGame.GDPawnPlayerThugBase.AimPoseAtPoint");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetAimPose;
    /// <summary>
    /// Function: ResetAimPose
    /// </summary>
    public unsafe virtual void ResetAimPose()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetAimPose, "BmGame.GDPawnPlayerThugBase.ResetAimPose");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoPoseSpecificMovement;
    /// <summary>
    /// Function: DoPoseSpecificMovement
    /// </summary>
    public unsafe override void DoPoseSpecificMovement(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoPoseSpecificMovement, "BmGame.GDPawnPlayerThugBase.DoPoseSpecificMovement");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ExitThugCover;
    /// <summary>
    /// Function: ExitThugCover
    /// </summary>
    public unsafe virtual void ExitThugCover()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitThugCover, "BmGame.GDPawnPlayerThugBase.ExitThugCover");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAimMode;
    /// <summary>
    /// Function: SetAimMode
    /// </summary>
    public unsafe virtual void SetAimMode(bool inAiming)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAimMode, "BmGame.GDPawnPlayerThugBase.SetAimMode");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inAiming, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReplicatedEvent;
    /// <summary>
    /// Function: ReplicatedEvent
    /// </summary>
    public unsafe override void ReplicatedEvent(BmSDK.FName VarName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplicatedEvent, "BmGame.GDPawnPlayerThugBase.ReplicatedEvent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRunAnimTime;
    /// <summary>
    /// Function: GetRunAnimTime
    /// </summary>
    public unsafe virtual float GetRunAnimTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRunAnimTime, "BmGame.GDPawnPlayerThugBase.GetRunAnimTime");
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

    private static BmSDK.Function __fn_IsFaceAtDirectionActive;
    /// <summary>
    /// Function: IsFaceAtDirectionActive
    /// </summary>
    public unsafe virtual bool IsFaceAtDirectionActive()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFaceAtDirectionActive, "BmGame.GDPawnPlayerThugBase.IsFaceAtDirectionActive");
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

    private static BmSDK.Function __fn_RestoreRootMotionMode;
    /// <summary>
    /// Function: RestoreRootMotionMode
    /// </summary>
    public unsafe virtual void RestoreRootMotionMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestoreRootMotionMode, "BmGame.GDPawnPlayerThugBase.RestoreRootMotionMode");
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

    private static BmSDK.Function __fn_SetIgnoreRootMotionMode;
    /// <summary>
    /// Function: SetIgnoreRootMotionMode
    /// </summary>
    public unsafe virtual void SetIgnoreRootMotionMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIgnoreRootMotionMode, "BmGame.GDPawnPlayerThugBase.SetIgnoreRootMotionMode");
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

    private static BmSDK.Function __fn_TriggeredSpecialMoveEndsIn;
    /// <summary>
    /// Function: TriggeredSpecialMoveEndsIn
    /// </summary>
    public unsafe override void TriggeredSpecialMoveEndsIn(BmSDK.FName FinalMovementStance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggeredSpecialMoveEndsIn, "BmGame.GDPawnPlayerThugBase.TriggeredSpecialMoveEndsIn");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinalMovementStance, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PoseChanged;
    /// <summary>
    /// Function: PoseChanged
    /// </summary>
    public unsafe override void PoseChanged(BmSDK.FName OldPose, BmSDK.FName NewPose, BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId TransID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PoseChanged, "BmGame.GDPawnPlayerThugBase.PoseChanged");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldPose, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPose, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransID, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NonLocalNetworkTick;
    /// <summary>
    /// Function: NonLocalNetworkTick
    /// </summary>
    public unsafe override void NonLocalNetworkTick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NonLocalNetworkTick, "BmGame.GDPawnPlayerThugBase.NonLocalNetworkTick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_NetworkTick;
    /// <summary>
    /// Function: NetworkTick
    /// </summary>
    public unsafe override void NetworkTick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NetworkTick, "BmGame.GDPawnPlayerThugBase.NetworkTick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_PlayingMelee;
    /// <summary>
    /// Function: PlayingMelee
    /// </summary>
    public unsafe virtual bool PlayingMelee()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayingMelee, "BmGame.GDPawnPlayerThugBase.PlayingMelee");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayThugMeleeAnim;
    /// <summary>
    /// Function: PlayThugMeleeAnim
    /// </summary>
    public unsafe virtual void PlayThugMeleeAnim(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId MeleeAnim)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayThugMeleeAnim, "BmGame.GDPawnPlayerThugBase.PlayThugMeleeAnim");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeleeAnim, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCoverPosVectors;
    /// <summary>
    /// Function: SetCoverPosVectors
    /// </summary>
    public unsafe virtual void SetCoverPosVectors(out BmSDK.Engine.CoverLink.FCovPosInfo CovInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCoverPosVectors, "BmGame.GDPawnPlayerThugBase.SetCoverPosVectors");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CovInfo);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CovInfo, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        CovInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.CoverLink.FCovPosInfo>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_FillCoverPosInfo;
    /// <summary>
    /// Function: FillCoverPosInfo
    /// </summary>
    public unsafe virtual void FillCoverPosInfo(BmSDK.Engine.CoverLink Link, int LtSlotIdx, int RtSlotIdx, System.Numerics.Vector3 FromLoc, System.Numerics.Vector3 Direction, float MaxDistance, out BmSDK.Engine.CoverLink.FCovPosInfo out_CovPosInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FillCoverPosInfo, "BmGame.GDPawnPlayerThugBase.FillCoverPosInfo");
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Link, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LtSlotIdx, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RtSlotIdx, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FromLoc, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxDistance, paramsPtr + 36);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_CovPosInfo);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_CovPosInfo, paramsPtr + 40);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_CovPosInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.CoverLink.FCovPosInfo>(paramsPtr + 40);
        return;
    }

    private static BmSDK.Function __fn_ValidatePotentialCover;
    /// <summary>
    /// Function: ValidatePotentialCover
    /// </summary>
    public unsafe virtual bool ValidatePotentialCover(System.Numerics.Vector3 FromLoc, System.Numerics.Vector3 Direction, out float OutMinDotFOV, out float OutMaxDistanceSquared, out BmSDK.Engine.CoverLink.FCovPosInfo OutCovPosInfo, out BmSDK.Engine.Pawn out_PawnInTheWay)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ValidatePotentialCover, "BmGame.GDPawnPlayerThugBase.ValidatePotentialCover");
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FromLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutMinDotFOV);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutMinDotFOV, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutMaxDistanceSquared);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutMaxDistanceSquared, paramsPtr + 28);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutCovPosInfo);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutCovPosInfo, paramsPtr + 32);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_PawnInTheWay);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_PawnInTheWay, paramsPtr + 84);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutMinDotFOV = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 24);
        OutMaxDistanceSquared = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 28);
        OutCovPosInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.CoverLink.FCovPosInfo>(paramsPtr + 32);
        out_PawnInTheWay = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Pawn>(paramsPtr + 84);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 88);
    }

    private static BmSDK.Function __fn_FindCoverFromLocAndDir;
    /// <summary>
    /// Function: FindCoverFromLocAndDir
    /// </summary>
    public unsafe virtual bool FindCoverFromLocAndDir(System.Numerics.Vector3 FromLoc, System.Numerics.Vector3 Direction, float FOV, float MaxDistance, out BmSDK.Engine.CoverLink.FCovPosInfo OutCovPosInfo, out BmSDK.Engine.Pawn out_PawnInTheWay)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindCoverFromLocAndDir, "BmGame.GDPawnPlayerThugBase.FindCoverFromLocAndDir");
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FromLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FOV, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxDistance, paramsPtr + 28);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutCovPosInfo);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutCovPosInfo, paramsPtr + 32);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_PawnInTheWay);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_PawnInTheWay, paramsPtr + 84);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutCovPosInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.CoverLink.FCovPosInfo>(paramsPtr + 32);
        out_PawnInTheWay = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Pawn>(paramsPtr + 84);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 88);
    }

    private static BmSDK.Function __fn_UnclaimCover;
    /// <summary>
    /// Function: UnclaimCover
    /// </summary>
    public unsafe virtual bool UnclaimCover(BmSDK.Engine.CoverLink Link, int SlotIdx, bool bUnclaimAll)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnclaimCover, "BmGame.GDPawnPlayerThugBase.UnclaimCover");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Link, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotIdx, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUnclaimAll, paramsPtr + 8);
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

    private static BmSDK.Function __fn_ClaimCover;
    /// <summary>
    /// Function: ClaimCover
    /// </summary>
    public unsafe virtual bool ClaimCover(BmSDK.Engine.CoverLink Link, int SlotIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClaimCover, "BmGame.GDPawnPlayerThugBase.ClaimCover");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Link, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotIdx, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GuessAtCover;
    /// <summary>
    /// Function: GuessAtCover
    /// </summary>
    public unsafe virtual bool GuessAtCover(out BmSDK.Engine.CoverLink.FCoverInfo out_Cover)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GuessAtCover, "BmGame.GDPawnPlayerThugBase.GuessAtCover");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_Cover);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_Cover, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_Cover = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.CoverLink.FCoverInfo>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsInCover;
    /// <summary>
    /// Function: IsInCover
    /// </summary>
    public unsafe virtual bool IsInCover()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInCover, "BmGame.GDPawnPlayerThugBase.IsInCover");
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

    private static BmSDK.Function __fn_PickClosestCoverSlot;
    /// <summary>
    /// Function: PickClosestCoverSlot
    /// </summary>
    public unsafe virtual int PickClosestCoverSlot(bool bRequireOverlap = default, float RadiusScale = default, bool bIgnoreCurrentCoverAction = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PickClosestCoverSlot, "BmGame.GDPawnPlayerThugBase.PickClosestCoverSlot");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRequireOverlap, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RadiusScale, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreCurrentCoverAction, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_IsAtCoverEdge;
    /// <summary>
    /// Function: IsAtCoverEdge
    /// </summary>
    public unsafe virtual bool IsAtCoverEdge(bool bMirrored, bool bAllowLeanAsEdge, float Scale, out int EdgeSlotIdx, int StartSlotIdx, bool bIgnoreCurrentCoverAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAtCoverEdge, "BmGame.GDPawnPlayerThugBase.IsAtCoverEdge");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMirrored, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowLeanAsEdge, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scale, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out EdgeSlotIdx);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EdgeSlotIdx, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartSlotIdx, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreCurrentCoverAction, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        EdgeSlotIdx = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetCoverNormal;
    /// <summary>
    /// Function: GetCoverNormal
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetCoverNormal(bool bSmoothed = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCoverNormal, "BmGame.GDPawnPlayerThugBase.GetCoverNormal");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSmoothed, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsDoingPawnRotationInterpolation;
    /// <summary>
    /// Function: IsDoingPawnRotationInterpolation
    /// </summary>
    public unsafe virtual bool IsDoingPawnRotationInterpolation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDoingPawnRotationInterpolation, "BmGame.GDPawnPlayerThugBase.IsDoingPawnRotationInterpolation");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InterpolatePawnRotation;
    /// <summary>
    /// Function: InterpolatePawnRotation
    /// </summary>
    public unsafe virtual void InterpolatePawnRotation(float RotationInterpTime = default, bool bCoverTransition = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InterpolatePawnRotation, "BmGame.GDPawnPlayerThugBase.InterpolatePawnRotation");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RotationInterpTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCoverTransition, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPoppingUp;
    /// <summary>
    /// Function: IsPoppingUp
    /// </summary>
    public unsafe virtual bool IsPoppingUp()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPoppingUp, "BmGame.GDPawnPlayerThugBase.IsPoppingUp");
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

    private static BmSDK.Function __fn_IsPeeking;
    /// <summary>
    /// Function: IsPeeking
    /// </summary>
    public unsafe virtual bool IsPeeking(BmSDK.Engine.CoverLink.ECoverAction PawnCA)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPeeking, "BmGame.GDPawnPlayerThugBase.IsPeeking");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnCA, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsALeaningAction;
    /// <summary>
    /// Function: IsALeaningAction
    /// </summary>
    public unsafe virtual bool IsALeaningAction(BmSDK.Engine.CoverLink.ECoverAction InCoverAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsALeaningAction, "BmGame.GDPawnPlayerThugBase.IsALeaningAction");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InCoverAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsLeaning;
    /// <summary>
    /// Function: IsLeaning
    /// </summary>
    public unsafe virtual bool IsLeaning()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLeaning, "BmGame.GDPawnPlayerThugBase.IsLeaning");
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

    private static BmSDK.Function __fn_IsBlindFiring;
    /// <summary>
    /// Function: IsBlindFiring
    /// </summary>
    public unsafe virtual bool IsBlindFiring(BmSDK.Engine.CoverLink.ECoverAction PawnCA)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBlindFiring, "BmGame.GDPawnPlayerThugBase.IsBlindFiring");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnCA, paramsPtr + 0);
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

    private static BmSDK.Function __fn_CanDoLeaningTransition;
    /// <summary>
    /// Function: CanDoLeaningTransition
    /// </summary>
    public unsafe virtual bool CanDoLeaningTransition()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoLeaningTransition, "BmGame.GDPawnPlayerThugBase.CanDoLeaningTransition");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CoverActionChanged;
    /// <summary>
    /// Function: CoverActionChanged
    /// </summary>
    public unsafe virtual void CoverActionChanged()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CoverActionChanged, "BmGame.GDPawnPlayerThugBase.CoverActionChanged");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCoverAction;
    /// <summary>
    /// Function: SetCoverAction
    /// </summary>
    public unsafe virtual void SetCoverAction(BmSDK.Engine.CoverLink.ECoverAction NewCoverAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCoverAction, "BmGame.GDPawnPlayerThugBase.SetCoverAction");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCoverAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCoverType;
    /// <summary>
    /// Function: SetCoverType
    /// </summary>
    public unsafe virtual void SetCoverType(BmSDK.Engine.CoverLink.ECoverType NewCoverType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCoverType, "BmGame.GDPawnPlayerThugBase.SetCoverType");
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCoverType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayCoverTypeChanged;
    /// <summary>
    /// Function: PlayCoverTypeChanged
    /// </summary>
    public unsafe virtual void PlayCoverTypeChanged(BmSDK.Engine.CoverLink.ECoverType OldCoverType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCoverTypeChanged, "BmGame.GDPawnPlayerThugBase.PlayCoverTypeChanged");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldCoverType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCoverInfoFromSlotInfo;
    /// <summary>
    /// Function: SetCoverInfoFromSlotInfo
    /// </summary>
    public unsafe virtual bool SetCoverInfoFromSlotInfo(out BmSDK.Engine.CoverLink.FCovPosInfo OutCovInfo, BmSDK.Engine.CoverLink.FCoverInfo SlotInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCoverInfoFromSlotInfo, "BmGame.GDPawnPlayerThugBase.SetCoverInfoFromSlotInfo");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutCovInfo);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutCovInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotInfo, paramsPtr + 52);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutCovInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.CoverLink.FCovPosInfo>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 60);
    }

    private static BmSDK.Function __fn_IsDoingRun2CoverSpecialMove;
    /// <summary>
    /// Function: IsDoingRun2CoverSpecialMove
    /// </summary>
    public unsafe virtual bool IsDoingRun2CoverSpecialMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDoingRun2CoverSpecialMove, "BmGame.GDPawnPlayerThugBase.IsDoingRun2CoverSpecialMove");
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

    private static BmSDK.Function __fn_CoverInfoToCovPosInfo;
    /// <summary>
    /// Function: CoverInfoToCovPosInfo
    /// </summary>
    public unsafe virtual BmSDK.Engine.CoverLink.FCovPosInfo CoverInfoToCovPosInfo(BmSDK.Engine.CoverLink.FCoverInfo CovInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CoverInfoToCovPosInfo, "BmGame.GDPawnPlayerThugBase.CoverInfoToCovPosInfo");
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CovInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.CoverLink.FCovPosInfo>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ReachedCoverSlot;
    /// <summary>
    /// Function: ReachedCoverSlot
    /// </summary>
    public unsafe virtual void ReachedCoverSlot(int SlotIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReachedCoverSlot, "BmGame.GDPawnPlayerThugBase.ReachedCoverSlot");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCoverTypeFor;
    /// <summary>
    /// Function: GetCoverTypeFor
    /// </summary>
    public unsafe virtual BmSDK.Engine.CoverLink.ECoverType GetCoverTypeFor(BmSDK.Engine.CoverLink.FCovPosInfo Cover)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCoverTypeFor, "BmGame.GDPawnPlayerThugBase.GetCoverTypeFor");
        byte* paramsPtr = stackalloc byte[71];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Cover, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.CoverLink.ECoverType>(paramsPtr + 52);
    }

    private static BmSDK.Function __fn_FindCoverType;
    /// <summary>
    /// Function: FindCoverType
    /// </summary>
    public unsafe virtual BmSDK.Engine.CoverLink.ECoverType FindCoverType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindCoverType, "BmGame.GDPawnPlayerThugBase.FindCoverType");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.CoverLink.ECoverType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetCurrentCoverType;
    /// <summary>
    /// Function: SetCurrentCoverType
    /// </summary>
    public unsafe virtual void SetCurrentCoverType(bool bClear = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentCoverType, "BmGame.GDPawnPlayerThugBase.SetCurrentCoverType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bClear, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RecentGelDamage;
    /// <summary>
    /// Function: RecentGelDamage
    /// </summary>
    public unsafe virtual void RecentGelDamage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecentGelDamage, "BmGame.GDPawnPlayerThugBase.RecentGelDamage");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsRunningForCamera;
    /// <summary>
    /// Function: IsRunningForCamera
    /// </summary>
    public unsafe virtual bool IsRunningForCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRunningForCamera, "BmGame.GDPawnPlayerThugBase.IsRunningForCamera");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsJogging;
    /// <summary>
    /// Function: IsJogging
    /// </summary>
    public unsafe virtual bool IsJogging()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsJogging, "BmGame.GDPawnPlayerThugBase.IsJogging");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Simulate360Aiming;
    /// <summary>
    /// Function: Simulate360Aiming
    /// </summary>
    public unsafe virtual bool Simulate360Aiming(bool bCurrentlyDoing360Aiming, System.Numerics.Vector2 TestAimOffsetPct, BmSDK.Engine.CoverLink.ECoverType TestCoverType, out BmSDK.Engine.CoverLink.ECoverDirection out_CoverDirection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Simulate360Aiming, "BmGame.GDPawnPlayerThugBase.Simulate360Aiming");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCurrentlyDoing360Aiming, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestAimOffsetPct, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestCoverType, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_CoverDirection);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_CoverDirection, paramsPtr + 13);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_CoverDirection = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.CoverLink.ECoverDirection>(paramsPtr + 13);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_AreObstaclesBetweenPointsIncludingNormal;
    /// <summary>
    /// Function: AreObstaclesBetweenPointsIncludingNormal
    /// </summary>
    public unsafe virtual bool AreObstaclesBetweenPointsIncludingNormal(System.Numerics.Vector3 vStartPoint, System.Numerics.Vector3 vEndPoint, bool bIncludePawns, out System.Numerics.Vector3 out_Normal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreObstaclesBetweenPointsIncludingNormal, "BmGame.GDPawnPlayerThugBase.AreObstaclesBetweenPointsIncludingNormal");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vStartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vEndPoint, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIncludePawns, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_Normal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_Normal, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_Normal = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_AreObstaclesOnLine;
    /// <summary>
    /// Function: AreObstaclesOnLine
    /// </summary>
    public unsafe virtual bool AreObstaclesOnLine(System.Numerics.Vector3 vStartPoint, System.Numerics.Vector3 vEndPoint, bool bIncludePawns)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreObstaclesOnLine, "BmGame.GDPawnPlayerThugBase.AreObstaclesOnLine");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vStartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vEndPoint, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIncludePawns, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_SetupLocatorForVaultMantleCover;
    /// <summary>
    /// Function: SetupLocatorForVaultMantleCover
    /// </summary>
    public unsafe virtual void SetupLocatorForVaultMantleCover(BmSDK.Engine.CoverLink Cover, in System.Numerics.Vector3 vCoverEntryPoint, out BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupLocatorForVaultMantleCover, "BmGame.GDPawnPlayerThugBase.SetupLocatorForVaultMantleCover");
        byte* paramsPtr = stackalloc byte[144];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Cover, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vCoverEntryPoint, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_SetupLocatorFromCoverPoint;
    /// <summary>
    /// Function: SetupLocatorFromCoverPoint
    /// </summary>
    public unsafe virtual void SetupLocatorFromCoverPoint(BmSDK.Engine.CoverLink Cover, in System.Numerics.Vector3 vCoverEntryPoint, out BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupLocatorFromCoverPoint, "BmGame.GDPawnPlayerThugBase.SetupLocatorFromCoverPoint");
        byte* paramsPtr = stackalloc byte[144];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Cover, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vCoverEntryPoint, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_CheckSurroundingEnvironment;
    /// <summary>
    /// Function: CheckSurroundingEnvironment
    /// </summary>
    public unsafe override void CheckSurroundingEnvironment(float CollisionHeight, float CollisionRadius, float DeltaTime, BmSDK.Engine.PrimitiveComponent HintPrimitive = default, bool forceForNonLocalController = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckSurroundingEnvironment, "BmGame.GDPawnPlayerThugBase.CheckSurroundingEnvironment");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionHeight, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionRadius, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HintPrimitive, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(forceForNonLocalController, paramsPtr + 16);
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

    private static BmSDK.Function __fn_GetHeartBeatType;
    /// <summary>
    /// Function: GetHeartBeatType
    /// </summary>
    public unsafe virtual int GetHeartBeatType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeartBeatType, "BmGame.GDPawnPlayerThugBase.GetHeartBeatType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetHeartbeatOverride;
    /// <summary>
    /// Function: SetHeartbeatOverride
    /// </summary>
    public unsafe override void SetHeartbeatOverride(BmSDK.BmGame.RHudExtensionInvestigate.EHeartBeatType newHeartbeat)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHeartbeatOverride, "BmGame.GDPawnPlayerThugBase.SetHeartbeatOverride");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(newHeartbeat, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetWeaponType;
    /// <summary>
    /// Function: GetWeaponType
    /// </summary>
    public unsafe virtual int GetWeaponType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWeaponType, "BmGame.GDPawnPlayerThugBase.GetWeaponType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateHealthRegenExitCover;
    /// <summary>
    /// Function: UpdateHealthRegenExitCover
    /// </summary>
    public unsafe virtual void UpdateHealthRegenExitCover()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateHealthRegenExitCover, "BmGame.GDPawnPlayerThugBase.UpdateHealthRegenExitCover");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateHealthRegenInCover;
    /// <summary>
    /// Function: UpdateHealthRegenInCover
    /// </summary>
    public unsafe virtual void UpdateHealthRegenInCover()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateHealthRegenInCover, "BmGame.GDPawnPlayerThugBase.UpdateHealthRegenInCover");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHealthRegenDelay;
    /// <summary>
    /// Function: GetHealthRegenDelay
    /// </summary>
    public unsafe override float GetHealthRegenDelay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHealthRegenDelay, "BmGame.GDPawnPlayerThugBase.GetHealthRegenDelay");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHealthRegenDelayInCover;
    /// <summary>
    /// Function: GetHealthRegenDelayInCover
    /// </summary>
    public unsafe virtual float GetHealthRegenDelayInCover()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHealthRegenDelayInCover, "BmGame.GDPawnPlayerThugBase.GetHealthRegenDelayInCover");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IncreaseHealthRegenModifier;
    /// <summary>
    /// Function: IncreaseHealthRegenModifier
    /// </summary>
    public unsafe override void IncreaseHealthRegenModifier(float fModifier)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncreaseHealthRegenModifier, "BmGame.GDPawnPlayerThugBase.IncreaseHealthRegenModifier");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fModifier, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IncreaseDashModifier;
    /// <summary>
    /// Function: IncreaseDashModifier
    /// </summary>
    public unsafe override void IncreaseDashModifier(float fModifier)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncreaseDashModifier, "BmGame.GDPawnPlayerThugBase.IncreaseDashModifier");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fModifier, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NonLocalGadgetIndexChanged;
    /// <summary>
    /// Function: NonLocalGadgetIndexChanged
    /// </summary>
    public unsafe override void NonLocalGadgetIndexChanged()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NonLocalGadgetIndexChanged, "BmGame.GDPawnPlayerThugBase.NonLocalGadgetIndexChanged");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateGadgetVar;
    /// <summary>
    /// Function: UpdateGadgetVar
    /// </summary>
    public unsafe override void UpdateGadgetVar(BmSDK.BmGame.RInventoryGadget NewGadget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateGadgetVar, "BmGame.GDPawnPlayerThugBase.UpdateGadgetVar");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGadget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindAndPlayOverrideDeathAnim;
    /// <summary>
    /// Function: FindAndPlayOverrideDeathAnim
    /// </summary>
    public unsafe override bool FindAndPlayOverrideDeathAnim(BmSDK.Class DamageType, bool IsHeadshot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindAndPlayOverrideDeathAnim, "BmGame.GDPawnPlayerThugBase.FindAndPlayOverrideDeathAnim");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsHeadshot, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.GDPawnPlayerThugBase.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSpotteeComponent;
    /// <summary>
    /// Function: GetSpotteeComponent
    /// </summary>
    public unsafe override BmSDK.BmGame.GDSpotteeComponent GetSpotteeComponent(BmSDK.BmGame.RPawn _Spotter)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSpotteeComponent, "BmGame.GDPawnPlayerThugBase.GetSpotteeComponent");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_Spotter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDSpotteeComponent>(paramsPtr + 4);
    }

    /// <summary>
    /// Struct: FSMStruct
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FSMStruct
    {
        /// <summary>
        /// ByteProperty: SpecialMove
        /// </summary>
        public unsafe BmSDK.BmGame.GDPawnPlayerThugBase.ESpecialMove SpecialMove
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDPawnPlayerThugBase.ESpecialMove>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: InteractionPawn
        /// </summary>
        public unsafe BmSDK.BmGame.GDPawnPlayerThugBase InteractionPawn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDPawnPlayerThugBase>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: Flags
        /// </summary>
        public unsafe int Flags
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: ESpecialMove
    /// </summary>
    public enum ESpecialMove : byte
    {
        SM_None = 0,
        SM_MidLvlJumpOver = 1,
        SM_StdLvlSwatTurn = 2,
        SM_CoverRun = 3,
        SM_RoadieRun = 4,
        SM_CoverSlip = 5,
        SM_MantleUpLowCover = 6,
        SM_MantleDown = 7,
        SM_EvadeFwd = 8,
        SM_EvadeBwd = 9,
        SM_EvadeLt = 10,
        SM_EvadeRt = 11,
        SM_Run2MidCov = 12,
        SM_Run2StdCov = 13,
        SM_Run2Idle = 14,
        SM_Walk2Idle = 15,
        SM_PushOutOfCover = 16,
        GSM_CoverDestroyed = 17,
        SM_FlankedReaction_Left = 18,
        SM_FlankedReaction_Right = 19,
        SM_FlankedReaction_Back = 20,
        SM_FlankedReaction_Front = 21,
        SM_Reaction_InitCombat = 22,
        SM_FullBodyHitReaction = 23,
        SM_StumbleFromMelee = 24,
        SM_StumbleFromMelee2 = 25,
        SM_StumbleGoDown = 26,
        SM_StumbleGoDownFromExplosion = 27,
        SM_StumbleGoDownFromCloseRangeShot = 28,
        SM_StumbleGetUp = 29,
        SM_StumbleForwardFromExplosion = 30,
        SM_CoverHead = 31,
        SM_CoverHeadPushed = 32,
        SM_FaceShield = 33,
        SM_StumbleBackOutOfCover = 34,
        SM_ChainsawInterrupt = 35,
        SM_StumbleFromMantleKick = 36,
        SM_DBNO = 37,
        SM_Gunked = 38,
        SM_RecoverFromDBNO = 39,
        SM_RoadieRunHitReactionStumble = 40,
        SM_PushCover = 41,
        SM_PushObject = 42,
        SM_UsingCommLink = 43,
        SM_PutOnHelmet = 44,
        SM_ScriptedMove = 45,
        GSM_Leap = 46,
        SM_Adam_Typing = 47,
        ESpecialMove_MAX = 48,
    }

    /// <summary>
    /// Enum: GDThugCoverFacing
    /// </summary>
    public enum GDThugCoverFacing : byte
    {
        TCF_None = 0,
        TCF_Left = 1,
        TCF_Right = 2,
        TCF_MAX = 3,
    }

    /// <summary>
    /// Enum: EVerticalAimOffset
    /// </summary>
    public enum EVerticalAimOffset : byte
    {
        VerticalAim_Left = 0,
        VerticalAim_Centre = 1,
        VerticalAim_Right = 2,
        VerticalAim_MAX = 3,
    }

    /// <summary>
    /// Enum: EAdditiveAimOffset
    /// </summary>
    public enum EAdditiveAimOffset : byte
    {
        AdditiveAim_LU = 0,
        AdditiveAim_CU = 1,
        AdditiveAim_RU = 2,
        AdditiveAim_LC = 3,
        AdditiveAim_RD = 4,
        AdditiveAim_RC = 5,
        AdditiveAim_LD = 6,
        AdditiveAim_CD = 7,
        AdditiveAim_CC = 8,
        AdditiveAim_MAX = 9,
    }

    /// <summary>
    /// NameProperty: TargetClass
    /// </summary>
    public unsafe BmSDK.FName TargetClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 7056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7056); }
    }

    /// <summary>
    /// ArrayProperty: CoverMoveNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CoverMoveNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 7064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7064); }
    }

    /// <summary>
    /// ArrayProperty: CoverStillNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CoverStillNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 7076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7076); }
    }

    /// <summary>
    /// ArrayProperty: CoverNoAimNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CoverNoAimNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 7088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7088); }
    }

    /// <summary>
    /// ArrayProperty: MotionNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> MotionNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 7100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7100); }
    }

    /// <summary>
    /// ArrayProperty: CoverLinks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.CoverLink> CoverLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.CoverLink>>(Ptr + 7112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7112); }
    }

    /// <summary>
    /// ObjectProperty: AimNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeAimOffset AimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeAimOffset>(Ptr + 7124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7124); }
    }

    /// <summary>
    /// ObjectProperty: TargetAimNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeAimOffset TargetAimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeAimOffset>(Ptr + 7128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7128); }
    }

    /// <summary>
    /// ObjectProperty: AimBlendNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeBlend AimBlendNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeBlend>(Ptr + 7132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7132); }
    }

    /// <summary>
    /// ObjectProperty: LeftHandSkelControl
    /// </summary>
    public unsafe BmSDK.Engine.SkelControlBase LeftHandSkelControl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkelControlBase>(Ptr + 7136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7136); }
    }

    /// <summary>
    /// ObjectProperty: RightHandSkelControl
    /// </summary>
    public unsafe BmSDK.Engine.SkelControlBase RightHandSkelControl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkelControlBase>(Ptr + 7140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7140); }
    }

    /// <summary>
    /// BoolProperty: bNeedsAmmoCrateIndicators
    /// </summary>
    public unsafe bool bNeedsAmmoCrateIndicators
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7144); }
    }

    /// <summary>
    /// BoolProperty: IgnoreRFlapsWhenUpdatingPermanentFixing
    /// </summary>
    public unsafe bool IgnoreRFlapsWhenUpdatingPermanentFixing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7144); }
    }

    /// <summary>
    /// BoolProperty: bStoppedWrithing
    /// </summary>
    public unsafe bool bStoppedWrithing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7144); }
    }

    /// <summary>
    /// BoolProperty: DebugDigitalSpeed
    /// </summary>
    public unsafe bool DebugDigitalSpeed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7144); }
    }

    /// <summary>
    /// BoolProperty: bXrayMaterialsChanged
    /// </summary>
    public unsafe bool bXrayMaterialsChanged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7144); }
    }

    /// <summary>
    /// BoolProperty: bComputingCoverPoint
    /// </summary>
    public unsafe bool bComputingCoverPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7144); }
    }

    /// <summary>
    /// BoolProperty: bGlideKickPSActive
    /// </summary>
    public unsafe bool bGlideKickPSActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7144); }
    }

    /// <summary>
    /// BoolProperty: bAiming
    /// </summary>
    public unsafe bool bAiming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7144); }
    }

    /// <summary>
    /// BoolProperty: bSwitchingWeapon
    /// </summary>
    public unsafe bool bSwitchingWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7144); }
    }

    /// <summary>
    /// BoolProperty: bIsMirrored
    /// </summary>
    public unsafe bool bIsMirrored
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7144); }
    }

    /// <summary>
    /// BoolProperty: bWantsToBeMirrored
    /// </summary>
    public unsafe bool bWantsToBeMirrored
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7144); }
    }

    /// <summary>
    /// BoolProperty: bDoingMirrorTransition
    /// </summary>
    public unsafe bool bDoingMirrorTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7144); }
    }

    /// <summary>
    /// BoolProperty: bCanDo360AimingInCover
    /// </summary>
    public unsafe bool bCanDo360AimingInCover
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7144); }
    }

    /// <summary>
    /// BoolProperty: bDoing360Aiming
    /// </summary>
    public unsafe bool bDoing360Aiming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7144); }
    }

    /// <summary>
    /// BoolProperty: bWasDoing360Aiming
    /// </summary>
    public unsafe bool bWasDoing360Aiming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7144); }
    }

    /// <summary>
    /// BoolProperty: bRotInterpCoverTransition
    /// </summary>
    public unsafe bool bRotInterpCoverTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7144); }
    }

    /// <summary>
    /// BoolProperty: bCanUseCover
    /// </summary>
    public unsafe bool bCanUseCover
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7144); }
    }

    /// <summary>
    /// BoolProperty: bCanDoRun2Cover
    /// </summary>
    public unsafe bool bCanDoRun2Cover
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7144); }
    }

    /// <summary>
    /// BoolProperty: bEndingSpecialMove
    /// </summary>
    public unsafe bool bEndingSpecialMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7144); }
    }

    /// <summary>
    /// BoolProperty: bIsPendingMove
    /// </summary>
    public unsafe bool bIsPendingMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7144); }
    }

    /// <summary>
    /// BoolProperty: bRootMotionHasToBeRestored
    /// </summary>
    public unsafe bool bRootMotionHasToBeRestored
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7144); }
    }

    /// <summary>
    /// BoolProperty: bUseRealNameForInvestigate
    /// </summary>
    public unsafe bool bUseRealNameForInvestigate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7144); }
    }

    /// <summary>
    /// BoolProperty: bReallyDead
    /// </summary>
    public unsafe bool bReallyDead
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7144); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7144); }
    }

    /// <summary>
    /// ObjectProperty: CharacterTransitionEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem CharacterTransitionEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 7148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7148); }
    }

    /// <summary>
    /// ObjectProperty: CharacterTransitionEffectEmitter
    /// </summary>
    public unsafe BmSDK.BmGame.REmitter CharacterTransitionEffectEmitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REmitter>(Ptr + 7152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7152); }
    }

    /// <summary>
    /// FloatProperty: PawnCharacterTransitionTime
    /// </summary>
    public unsafe float PawnCharacterTransitionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7156); }
    }

    /// <summary>
    /// FloatProperty: DigitalWalkSpeedForward
    /// </summary>
    public unsafe float DigitalWalkSpeedForward
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7160); }
    }

    /// <summary>
    /// FloatProperty: DigitalWalkSpeedBackward
    /// </summary>
    public unsafe float DigitalWalkSpeedBackward
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7164); }
    }

    /// <summary>
    /// FloatProperty: DigitalWalkSpeedLeft
    /// </summary>
    public unsafe float DigitalWalkSpeedLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7168); }
    }

    /// <summary>
    /// FloatProperty: DigitalWalkSpeedRight
    /// </summary>
    public unsafe float DigitalWalkSpeedRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7172); }
    }

    /// <summary>
    /// FloatProperty: DigitalJogSpeed
    /// </summary>
    public unsafe float DigitalJogSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7176); }
    }

    /// <summary>
    /// FloatProperty: DigitalWalkSpeedInCover
    /// </summary>
    public unsafe float DigitalWalkSpeedInCover
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7180); }
    }

    /// <summary>
    /// FloatProperty: DigitalSpeedCrossPoint
    /// </summary>
    public unsafe float DigitalSpeedCrossPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7184); }
    }

    /// <summary>
    /// FloatProperty: OldDigitalSpeed
    /// </summary>
    public unsafe float OldDigitalSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7188); }
    }

    /// <summary>
    /// StructProperty: OldDigitalSpeedDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 OldDigitalSpeedDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7192);

    /// <summary>
    /// FloatProperty: DigitalSpeedBlendTime
    /// </summary>
    public unsafe float DigitalSpeedBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7204); }
    }

    /// <summary>
    /// FloatProperty: DigitalSpeedToIdleBlendTime
    /// </summary>
    public unsafe float DigitalSpeedToIdleBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7208); }
    }

    /// <summary>
    /// FloatProperty: VisionSpooferValueInCover
    /// </summary>
    public unsafe float VisionSpooferValueInCover
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7212); }
    }

    /// <summary>
    /// StructProperty: LastCoverDirectionUsed
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastCoverDirectionUsed
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7216);

    /// <summary>
    /// ComponentProperty: MultiplayerAuraMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent MultiplayerAuraMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7228); }
    }

    /// <summary>
    /// ComponentProperty: MultiplayerAuraSecondaryMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent MultiplayerAuraSecondaryMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7232); }
    }

    /// <summary>
    /// ComponentProperty: MultiplayerAuraTertiaryMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent MultiplayerAuraTertiaryMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7236); }
    }

    /// <summary>
    /// ObjectProperty: MultiplayerAuraMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant MultiplayerAuraMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 7240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7240); }
    }

    /// <summary>
    /// ComponentProperty: HeadPSC
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent HeadPSC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 7244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7244); }
    }

    /// <summary>
    /// ObjectProperty: GlideKickPS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem GlideKickPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 7248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7248); }
    }

    /// <summary>
    /// FloatProperty: VerticalAimExtent
    /// </summary>
    public unsafe float VerticalAimExtent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7252); }
    }

    /// <summary>
    /// FloatProperty: HorizontalAimExtent
    /// </summary>
    public unsafe float HorizontalAimExtent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7256); }
    }

    /// <summary>
    /// FloatProperty: VerticalAimExtentCover
    /// </summary>
    public unsafe float VerticalAimExtentCover
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7260); }
    }

    /// <summary>
    /// FloatProperty: AimLerpSpeed
    /// </summary>
    public unsafe float AimLerpSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7264); }
    }

    /// <summary>
    /// FloatProperty: BlendInStartTime
    /// </summary>
    public unsafe float BlendInStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7268); }
    }

    /// <summary>
    /// ObjectProperty: VisionMode
    /// </summary>
    public unsafe BmSDK.BmGame.GDVisionModeGadgetBase VisionMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDVisionModeGadgetBase>(Ptr + 7272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7272); }
    }

    /// <summary>
    /// StructProperty: CurrentAimDirection
    /// </summary>
    public unsafe ref BmSDK.Rotator CurrentAimDirection
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 7276);

    /// <summary>
    /// InlineArray{FloatProperty}: AdditiveAimOffsets
    /// </summary>
    public InlineArray<float> AdditiveAimOffsets => new(18, Ptr + 7288, 4, this);

    /// <summary>
    /// FloatProperty: AdditiveAimOffsets
    /// </summary>
    public unsafe float AdditiveAimOffsets_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7288); }
    }
    /// <summary>
    /// FloatProperty: AdditiveAimOffsets
    /// </summary>
    public unsafe float AdditiveAimOffsets_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7292); }
    }
    /// <summary>
    /// FloatProperty: AdditiveAimOffsets
    /// </summary>
    public unsafe float AdditiveAimOffsets_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7296); }
    }
    /// <summary>
    /// FloatProperty: AdditiveAimOffsets
    /// </summary>
    public unsafe float AdditiveAimOffsets_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7300); }
    }
    /// <summary>
    /// FloatProperty: AdditiveAimOffsets
    /// </summary>
    public unsafe float AdditiveAimOffsets_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7304); }
    }
    /// <summary>
    /// FloatProperty: AdditiveAimOffsets
    /// </summary>
    public unsafe float AdditiveAimOffsets_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7308); }
    }
    /// <summary>
    /// FloatProperty: AdditiveAimOffsets
    /// </summary>
    public unsafe float AdditiveAimOffsets_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7312); }
    }
    /// <summary>
    /// FloatProperty: AdditiveAimOffsets
    /// </summary>
    public unsafe float AdditiveAimOffsets_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7316); }
    }
    /// <summary>
    /// FloatProperty: AdditiveAimOffsets
    /// </summary>
    public unsafe float AdditiveAimOffsets_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7320); }
    }
    /// <summary>
    /// FloatProperty: AdditiveAimOffsets
    /// </summary>
    public unsafe float AdditiveAimOffsets_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7324); }
    }
    /// <summary>
    /// FloatProperty: AdditiveAimOffsets
    /// </summary>
    public unsafe float AdditiveAimOffsets_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7328); }
    }
    /// <summary>
    /// FloatProperty: AdditiveAimOffsets
    /// </summary>
    public unsafe float AdditiveAimOffsets_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7332); }
    }
    /// <summary>
    /// FloatProperty: AdditiveAimOffsets
    /// </summary>
    public unsafe float AdditiveAimOffsets_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7336); }
    }
    /// <summary>
    /// FloatProperty: AdditiveAimOffsets
    /// </summary>
    public unsafe float AdditiveAimOffsets_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7340); }
    }
    /// <summary>
    /// FloatProperty: AdditiveAimOffsets
    /// </summary>
    public unsafe float AdditiveAimOffsets_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7344); }
    }
    /// <summary>
    /// FloatProperty: AdditiveAimOffsets
    /// </summary>
    public unsafe float AdditiveAimOffsets_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7348); }
    }
    /// <summary>
    /// FloatProperty: AdditiveAimOffsets
    /// </summary>
    public unsafe float AdditiveAimOffsets_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7352); }
    }
    /// <summary>
    /// FloatProperty: AdditiveAimOffsets
    /// </summary>
    public unsafe float AdditiveAimOffsets_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7356); }
    }

    /// <summary>
    /// ObjectProperty: CoverMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController CoverMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 7360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7360); }
    }

    /// <summary>
    /// ObjectProperty: EvadeForward
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EvadeForward
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 7364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7364); }
    }

    /// <summary>
    /// ObjectProperty: EvadeBack
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EvadeBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 7368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7368); }
    }

    /// <summary>
    /// ObjectProperty: EvadeLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EvadeLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 7372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7372); }
    }

    /// <summary>
    /// ObjectProperty: EvadeRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EvadeRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 7376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7376); }
    }

    /// <summary>
    /// ObjectProperty: DualWieldEvadeForward
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DualWieldEvadeForward
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 7380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7380); }
    }

    /// <summary>
    /// ObjectProperty: DualWieldEvadeBack
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DualWieldEvadeBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 7384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7384); }
    }

    /// <summary>
    /// ObjectProperty: DualWieldEvadeLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DualWieldEvadeLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 7388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7388); }
    }

    /// <summary>
    /// ObjectProperty: DualWieldEvadeRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DualWieldEvadeRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 7392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7392); }
    }

    /// <summary>
    /// ObjectProperty: DualWieldLand
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DualWieldLand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 7396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7396); }
    }

    /// <summary>
    /// NameProperty: RunForwardAnimName
    /// </summary>
    public unsafe BmSDK.FName RunForwardAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 7400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7400); }
    }

    /// <summary>
    /// FloatProperty: RunForwardSpeed
    /// </summary>
    public unsafe float RunForwardSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7408); }
    }

    /// <summary>
    /// ObjectProperty: CurrentLink
    /// </summary>
    public unsafe BmSDK.Engine.CoverLink CurrentLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CoverLink>(Ptr + 7412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7412); }
    }

    /// <summary>
    /// IntProperty: CurrentSlotIdx
    /// </summary>
    public unsafe int CurrentSlotIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7416); }
    }

    /// <summary>
    /// IntProperty: OtherSlotIdx
    /// </summary>
    public unsafe int OtherSlotIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7420); }
    }

    /// <summary>
    /// IntProperty: ClosestSlotIdx
    /// </summary>
    public unsafe int ClosestSlotIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7424); }
    }

    /// <summary>
    /// IntProperty: PreviousSlotIdx
    /// </summary>
    public unsafe int PreviousSlotIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7428); }
    }

    /// <summary>
    /// ByteProperty: eDesiredThugCoverFacing
    /// </summary>
    public unsafe BmSDK.BmGame.GDPawnPlayerThugBase.GDThugCoverFacing eDesiredThugCoverFacing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDPawnPlayerThugBase.GDThugCoverFacing>(Ptr + 7432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7432); }
    }

    /// <summary>
    /// ByteProperty: eThugCoverType
    /// </summary>
    public unsafe BmSDK.Engine.CoverLink.ECoverType eThugCoverType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CoverLink.ECoverType>(Ptr + 7433); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7433); }
    }

    /// <summary>
    /// ByteProperty: CoverType
    /// </summary>
    public unsafe BmSDK.Engine.CoverLink.ECoverType CoverType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CoverLink.ECoverType>(Ptr + 7434); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7434); }
    }

    /// <summary>
    /// ByteProperty: CoverAction
    /// </summary>
    public unsafe BmSDK.Engine.CoverLink.ECoverAction CoverAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CoverLink.ECoverAction>(Ptr + 7435); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7435); }
    }

    /// <summary>
    /// ByteProperty: PreviousCoverAction
    /// </summary>
    public unsafe BmSDK.Engine.CoverLink.ECoverAction PreviousCoverAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CoverLink.ECoverAction>(Ptr + 7436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7436); }
    }

    /// <summary>
    /// ByteProperty: SavedCoverAction
    /// </summary>
    public unsafe BmSDK.Engine.CoverLink.ECoverAction SavedCoverAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CoverLink.ECoverAction>(Ptr + 7437); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7437); }
    }

    /// <summary>
    /// ByteProperty: SpecialMove
    /// </summary>
    public unsafe BmSDK.BmGame.GDPawnPlayerThugBase.ESpecialMove SpecialMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDPawnPlayerThugBase.ESpecialMove>(Ptr + 7438); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7438); }
    }

    /// <summary>
    /// ByteProperty: PreviousSpecialMove
    /// </summary>
    public unsafe BmSDK.BmGame.GDPawnPlayerThugBase.ESpecialMove PreviousSpecialMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDPawnPlayerThugBase.ESpecialMove>(Ptr + 7439); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7439); }
    }

    /// <summary>
    /// ByteProperty: PreviousRootMotionMode
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent.ERootMotionMode PreviousRootMotionMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent.ERootMotionMode>(Ptr + 7440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7440); }
    }

    /// <summary>
    /// FloatProperty: LastCoverTime
    /// </summary>
    public unsafe float LastCoverTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7444); }
    }

    /// <summary>
    /// FloatProperty: LastCoverAcquireDistanceSq
    /// </summary>
    public unsafe float LastCoverAcquireDistanceSq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7448); }
    }

    /// <summary>
    /// FloatProperty: LastCoverActionTime
    /// </summary>
    public unsafe float LastCoverActionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7452); }
    }

    /// <summary>
    /// FloatProperty: NextCoverActionTime
    /// </summary>
    public unsafe float NextCoverActionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7456); }
    }

    /// <summary>
    /// FloatProperty: Last360AimingChangeTime
    /// </summary>
    public unsafe float Last360AimingChangeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7460); }
    }

    /// <summary>
    /// FloatProperty: PawnRotationInterpolationTime
    /// </summary>
    public unsafe float PawnRotationInterpolationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7464); }
    }

    /// <summary>
    /// FloatProperty: PawnRotationBlendTimeToGo
    /// </summary>
    public unsafe float PawnRotationBlendTimeToGo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7468); }
    }

    /// <summary>
    /// StructProperty: LastCoverRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator LastCoverRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 7472);

    /// <summary>
    /// FloatProperty: Run2CoverMaxDist
    /// </summary>
    public unsafe float Run2CoverMaxDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7484); }
    }

    /// <summary>
    /// FloatProperty: Run2CoverPerpendicularMaxDist
    /// </summary>
    public unsafe float Run2CoverPerpendicularMaxDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7488); }
    }

    /// <summary>
    /// FloatProperty: EndEvadeRun2CoverMaxDist
    /// </summary>
    public unsafe float EndEvadeRun2CoverMaxDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7492); }
    }

    /// <summary>
    /// FloatProperty: RoadieRun2CoverSlideDist
    /// </summary>
    public unsafe float RoadieRun2CoverSlideDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7496); }
    }

    /// <summary>
    /// StructProperty: PendingSpecialMoveStruct
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDPawnPlayerThugBase.FSMStruct PendingSpecialMoveStruct
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDPawnPlayerThugBase.FSMStruct>(Ptr + 7500);

    /// <summary>
    /// FloatProperty: PreviousSpecialMoveTime
    /// </summary>
    public unsafe float PreviousSpecialMoveTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7512); }
    }

    /// <summary>
    /// ObjectProperty: InteractionPawn
    /// </summary>
    public unsafe BmSDK.BmGame.GDPawnPlayerThugBase InteractionPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDPawnPlayerThugBase>(Ptr + 7516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7516); }
    }

    /// <summary>
    /// IntProperty: SpecialMoveFlags
    /// </summary>
    public unsafe int SpecialMoveFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7520); }
    }

    /// <summary>
    /// StrProperty: RealNameForInvestigate
    /// </summary>
    public unsafe BmSDK.FString RealNameForInvestigate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 7524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7524); }
    }

    /// <summary>
    /// IntProperty: OverrideHeartBeatType
    /// </summary>
    public unsafe int OverrideHeartBeatType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7536); }
    }

    /// <summary>
    /// StructProperty: InvestigateOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 InvestigateOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7540);

    /// <summary>
    /// NameProperty: SpineName
    /// </summary>
    public unsafe BmSDK.FName SpineName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 7552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7552); }
    }

    /// <summary>
    /// StructProperty: ViewRotation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ViewRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7560);

    /// <summary>
    /// StructProperty: ViewLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ViewLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 7572);

    /// <summary>
    /// ObjectProperty: BarkOnBatarang
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkOnBatarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 7584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7584); }
    }

    /// <summary>
    /// ObjectProperty: AkParamIronSights
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName AkParamIronSights
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 7588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7588); }
    }

    /// <summary>
    /// FloatProperty: LastUsedAmmoCrateTime
    /// </summary>
    public unsafe float LastUsedAmmoCrateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7592); }
    }

    /// <summary>
    /// ComponentProperty: SpotteeCaptain
    /// </summary>
    public unsafe BmSDK.BmGame.GDSpotteeComponent SpotteeCaptain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDSpotteeComponent>(Ptr + 7596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7596); }
    }

    /// <summary>
    /// ComponentProperty: SpotteeNailguns
    /// </summary>
    public unsafe BmSDK.BmGame.GDSpotteeComponent SpotteeNailguns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDSpotteeComponent>(Ptr + 7600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7600); }
    }
}
