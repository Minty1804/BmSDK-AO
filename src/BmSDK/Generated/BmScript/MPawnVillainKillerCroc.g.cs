#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MPawnVillainKillerCroc<br/>
/// (size = 4380)
/// (flags = 10485814)
/// </summary>
public partial class MPawnVillainKillerCroc : BmSDK.BmGame.MPawnVillainKillerCrocBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MPawnVillainKillerCroc", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MPawnVillainKillerCroc.
    /// </summary>
    public static MPawnVillainKillerCroc DefaultObject => (MPawnVillainKillerCroc)StaticClass().DefaultObject;

    internal MPawnVillainKillerCroc() { }

    /// <summary>
    /// Constructs a new MPawnVillainKillerCroc
    /// </summary>
    public MPawnVillainKillerCroc(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MPawnVillainKillerCroc(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillainKillerCroc>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainKillerCroc>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillainKillerCroc>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainKillerCroc>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainKillerCroc>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainKillerCroc>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillainKillerCroc>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainKillerCroc>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ShockWaveDamage;
    /// <summary>
    /// Function: ShockWaveDamage
    /// </summary>
    public unsafe virtual bool ShockWaveDamage(BmSDK.BmGame.RPawnCombat HitPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShockWaveDamage, "BmScript.MPawnVillainKillerCroc.ShockWaveDamage");
        byte* paramsPtr = stackalloc byte[292];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AreaAttack;
    /// <summary>
    /// Function: AreaAttack
    /// </summary>
    public unsafe virtual void AreaAttack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreaAttack, "BmScript.MPawnVillainKillerCroc.AreaAttack");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCloseAttackDamageMultiplier;
    /// <summary>
    /// Function: GetCloseAttackDamageMultiplier
    /// </summary>
    public unsafe override float GetCloseAttackDamageMultiplier()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCloseAttackDamageMultiplier, "BmScript.MPawnVillainKillerCroc.GetCloseAttackDamageMultiplier");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpawnFootstepParticles;
    /// <summary>
    /// Function: SpawnFootstepParticles
    /// </summary>
    public unsafe override void SpawnFootstepParticles(BmSDK.BmGame.RAnimNotify_Footstep.EFoot Foot, BmSDK.BmGame.RAnimNotify_Footstep.EContactType Contact, System.Numerics.Vector3 FootLocation, BmSDK.BmGame.RPhysicalMaterialProperty Property)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnFootstepParticles, "BmScript.MPawnVillainKillerCroc.SpawnFootstepParticles");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Foot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Contact, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FootLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Property, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CrocIsFacingBatman;
    /// <summary>
    /// Function: CrocIsFacingBatman
    /// </summary>
    public unsafe virtual bool CrocIsFacingBatman()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CrocIsFacingBatman, "BmScript.MPawnVillainKillerCroc.CrocIsFacingBatman");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AddNewBetweenAttacksSequence;
    /// <summary>
    /// Function: AddNewBetweenAttacksSequence
    /// </summary>
    public unsafe virtual void AddNewBetweenAttacksSequence()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddNewBetweenAttacksSequence, "BmScript.MPawnVillainKillerCroc.AddNewBetweenAttacksSequence");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KillCroc;
    /// <summary>
    /// Function: KillCroc
    /// </summary>
    public unsafe virtual void KillCroc()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillCroc, "BmScript.MPawnVillainKillerCroc.KillCroc");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinalCinematicAndKillCroc;
    /// <summary>
    /// Function: FinalCinematicAndKillCroc
    /// </summary>
    public unsafe virtual void FinalCinematicAndKillCroc()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinalCinematicAndKillCroc, "BmScript.MPawnVillainKillerCroc.FinalCinematicAndKillCroc");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoDebugWeapon;
    /// <summary>
    /// Function: DoDebugWeapon
    /// </summary>
    public unsafe virtual void DoDebugWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoDebugWeapon, "BmScript.MPawnVillainKillerCroc.DoDebugWeapon");
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmScript.MPawnVillainKillerCroc.Tick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickInCombatTime;
    /// <summary>
    /// Function: TickInCombatTime
    /// </summary>
    public unsafe override void TickInCombatTime(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickInCombatTime, "BmScript.MPawnVillainKillerCroc.TickInCombatTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayDialogueChargePunch;
    /// <summary>
    /// Function: PlayDialogueChargePunch
    /// </summary>
    public unsafe virtual void PlayDialogueChargePunch()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayDialogueChargePunch, "BmScript.MPawnVillainKillerCroc.PlayDialogueChargePunch");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBlockMove;
    /// <summary>
    /// Function: GetBlockMove
    /// </summary>
    public unsafe override BmSDK.Class GetBlockMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBlockMove, "BmScript.MPawnVillainKillerCroc.GetBlockMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldDrawHelpPrompt;
    /// <summary>
    /// Function: ShouldDrawHelpPrompt
    /// </summary>
    public unsafe override bool ShouldDrawHelpPrompt(out BmSDK.FString Text, out BmSDK.BmGame.RHUDPrompt.EControlIcon Icon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldDrawHelpPrompt, "BmScript.MPawnVillainKillerCroc.ShouldDrawHelpPrompt");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Icon);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Icon, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Text = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
        Icon = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHUDPrompt.EControlIcon>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ShouldShowBeatDownPrompt;
    /// <summary>
    /// Function: ShouldShowBeatDownPrompt
    /// </summary>
    public unsafe virtual bool ShouldShowBeatDownPrompt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldShowBeatDownPrompt, "BmScript.MPawnVillainKillerCroc.ShouldShowBeatDownPrompt");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldPlay;
    /// <summary>
    /// Function: ShouldPlay
    /// </summary>
    public unsafe virtual bool ShouldPlay(int probability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldPlay, "BmScript.MPawnVillainKillerCroc.ShouldPlay");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(probability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CheckBossBatarang;
    /// <summary>
    /// Function: CheckBossBatarang
    /// </summary>
    public unsafe override void CheckBossBatarang(BmSDK.BmGame.RBatarangProjectile Proj)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckBossBatarang, "BmScript.MPawnVillainKillerCroc.CheckBossBatarang");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proj, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsInVulnerableStateOfPropaneTankMove;
    /// <summary>
    /// Function: IsInVulnerableStateOfPropaneTankMove
    /// </summary>
    public unsafe virtual bool IsInVulnerableStateOfPropaneTankMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInVulnerableStateOfPropaneTankMove, "BmScript.MPawnVillainKillerCroc.IsInVulnerableStateOfPropaneTankMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldGoForTank;
    /// <summary>
    /// Function: ShouldGoForTank
    /// </summary>
    public unsafe virtual bool ShouldGoForTank()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldGoForTank, "BmScript.MPawnVillainKillerCroc.ShouldGoForTank");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FinishCinematicCamera;
    /// <summary>
    /// Function: FinishCinematicCamera
    /// </summary>
    public unsafe virtual void FinishCinematicCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishCinematicCamera, "BmScript.MPawnVillainKillerCroc.FinishCinematicCamera");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCameraFOV;
    /// <summary>
    /// Function: SetCameraFOV
    /// </summary>
    public unsafe virtual void SetCameraFOV(float NewFOV)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCameraFOV, "BmScript.MPawnVillainKillerCroc.SetCameraFOV");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFOV, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayCameraAnim;
    /// <summary>
    /// Function: PlayCameraAnim
    /// </summary>
    public unsafe virtual bool PlayCameraAnim(BmSDK.FName CameraAnimName, System.Numerics.Vector3 CameraLocation, BmSDK.Rotator CameraRotation, bool bCheckForValidCamera = default, float BlendTime = default, bool bMirror = default, float FOV = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCameraAnim, "BmScript.MPawnVillainKillerCroc.PlayCameraAnim");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraAnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraRotation, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheckForValidCamera, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendTime, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMirror, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FOV, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_DoesCameraMaintainLos;
    /// <summary>
    /// Function: DoesCameraMaintainLos
    /// </summary>
    public unsafe virtual bool DoesCameraMaintainLos(BmSDK.BmGame.RInGameCinematicCam CinematicCamera)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoesCameraMaintainLos, "BmScript.MPawnVillainKillerCroc.DoesCameraMaintainLos");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CinematicCamera, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_NotifyBossBarkLaugh;
    /// <summary>
    /// Function: NotifyBossBarkLaugh
    /// </summary>
    public unsafe virtual void NotifyBossBarkLaugh()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyBossBarkLaugh, "BmScript.MPawnVillainKillerCroc.NotifyBossBarkLaugh");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCameraTarget;
    /// <summary>
    /// Function: GetCameraTarget
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetCameraTarget(BmSDK.BmGame.RPawn Pawn, bool CheckEyes)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCameraTarget, "BmScript.MPawnVillainKillerCroc.GetCameraTarget");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckEyes, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanCameraSeePoint;
    /// <summary>
    /// Function: CanCameraSeePoint
    /// </summary>
    public unsafe virtual bool CanCameraSeePoint(BmSDK.BmGame.RInGameCinematicCam CinematicCamera, float CameraTimeNormalised, System.Numerics.Vector3 CameraCheckTarget, BmSDK.Engine.Actor IgnoreThisActor, BmSDK.Engine.Actor IgnoreThisActorToo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanCameraSeePoint, "BmScript.MPawnVillainKillerCroc.CanCameraSeePoint");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CinematicCamera, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraTimeNormalised, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraCheckTarget, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IgnoreThisActor, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IgnoreThisActorToo, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_ImpactEffect;
    /// <summary>
    /// Function: ImpactEffect
    /// </summary>
    public unsafe virtual void ImpactEffect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ImpactEffect, "BmScript.MPawnVillainKillerCroc.ImpactEffect");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldStartFinalBlowCam;
    /// <summary>
    /// Function: ShouldStartFinalBlowCam
    /// </summary>
    public unsafe override bool ShouldStartFinalBlowCam(float StrikeDamageAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldStartFinalBlowCam, "BmScript.MPawnVillainKillerCroc.ShouldStartFinalBlowCam");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeDamageAmount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ShouldReactToExplosiveGel;
    /// <summary>
    /// Function: ShouldReactToExplosiveGel
    /// </summary>
    public unsafe virtual bool ShouldReactToExplosiveGel(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldReactToExplosiveGel, "BmScript.MPawnVillainKillerCroc.ShouldReactToExplosiveGel");
        byte* paramsPtr = stackalloc byte[276];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 256);
    }

    private static BmSDK.Function __fn_DamagedBy;
    /// <summary>
    /// Function: DamagedBy
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult DamagedBy(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamagedBy, "BmScript.MPawnVillainKillerCroc.DamagedBy");
        byte* paramsPtr = stackalloc byte[273];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 256);
    }

    private static BmSDK.Function __fn_GetSuperStunHitReactionAnimset;
    /// <summary>
    /// Function: GetSuperStunHitReactionAnimset
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetSuperStunHitReactionAnimset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSuperStunHitReactionAnimset, "BmScript.MPawnVillainKillerCroc.GetSuperStunHitReactionAnimset");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetExplosiveGelDamageInfo;
    /// <summary>
    /// Function: SetExplosiveGelDamageInfo
    /// </summary>
    public unsafe virtual void SetExplosiveGelDamageInfo(out BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetExplosiveGelDamageInfo, "BmScript.MPawnVillainKillerCroc.SetExplosiveGelDamageInfo");
        byte* paramsPtr = stackalloc byte[312];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DmgInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.FDamageInfo>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForStrikeDamageType;
    /// <summary>
    /// Function: CheckForStrikeDamageType
    /// </summary>
    public unsafe virtual bool CheckForStrikeDamageType(BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForStrikeDamageType, "BmScript.MPawnVillainKillerCroc.CheckForStrikeDamageType");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CanBlockDamageType;
    /// <summary>
    /// Function: CanBlockDamageType
    /// </summary>
    public unsafe override bool CanBlockDamageType(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBlockDamageType, "BmScript.MPawnVillainKillerCroc.CanBlockDamageType");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanBlock;
    /// <summary>
    /// Function: CanBlock
    /// </summary>
    public unsafe override bool CanBlock()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBlock, "BmScript.MPawnVillainKillerCroc.CanBlock");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IncCurrentDamageLevel;
    /// <summary>
    /// Function: IncCurrentDamageLevel
    /// </summary>
    public unsafe virtual void IncCurrentDamageLevel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncCurrentDamageLevel, "BmScript.MPawnVillainKillerCroc.IncCurrentDamageLevel");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ModifyDamageAmount;
    /// <summary>
    /// Function: ModifyDamageAmount
    /// </summary>
    public unsafe override void ModifyDamageAmount(BmSDK.Class dmgType, out float DmgAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyDamageAmount, "BmScript.MPawnVillainKillerCroc.ModifyDamageAmount");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DmgAmount);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgAmount, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DmgAmount = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_GetBeatdownHits;
    /// <summary>
    /// Function: GetBeatdownHits
    /// </summary>
    public unsafe virtual int GetBeatdownHits()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBeatdownHits, "BmScript.MPawnVillainKillerCroc.GetBeatdownHits");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateRotationTowards;
    /// <summary>
    /// Function: UpdateRotationTowards
    /// </summary>
    public unsafe virtual void UpdateRotationTowards(BmSDK.Rotator NewRotation, float DeltaTime, float InterpRate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateRotationTowards, "BmScript.MPawnVillainKillerCroc.UpdateRotationTowards");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRotation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterpRate, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleBeatdownFinalDamage;
    /// <summary>
    /// Function: HandleBeatdownFinalDamage
    /// </summary>
    public unsafe virtual void HandleBeatdownFinalDamage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleBeatdownFinalDamage, "BmScript.MPawnVillainKillerCroc.HandleBeatdownFinalDamage");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDefaultHitReactionClass;
    /// <summary>
    /// Function: GetDefaultHitReactionClass
    /// </summary>
    public unsafe override BmSDK.Class GetDefaultHitReactionClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultHitReactionClass, "BmScript.MPawnVillainKillerCroc.GetDefaultHitReactionClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayHitReaction;
    /// <summary>
    /// Function: PlayHitReaction
    /// </summary>
    public unsafe override void PlayHitReaction(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHitReaction, "BmScript.MPawnVillainKillerCroc.PlayHitReaction");
        byte* paramsPtr = stackalloc byte[272];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHealthForBeatdown;
    /// <summary>
    /// Function: GetHealthForBeatdown
    /// </summary>
    public unsafe override float GetHealthForBeatdown(bool bBeatdownEndCheck)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHealthForBeatdown, "BmScript.MPawnVillainKillerCroc.GetHealthForBeatdown");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBeatdownEndCheck, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsReadyForBeatdownEnd;
    /// <summary>
    /// Function: IsReadyForBeatdownEnd
    /// </summary>
    public unsafe virtual bool IsReadyForBeatdownEnd()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsReadyForBeatdownEnd, "BmScript.MPawnVillainKillerCroc.IsReadyForBeatdownEnd");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HandleBeatdownChange;
    /// <summary>
    /// Function: HandleBeatdownChange
    /// </summary>
    public unsafe virtual void HandleBeatdownChange(bool bHasEnded)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleBeatdownChange, "BmScript.MPawnVillainKillerCroc.HandleBeatdownChange");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHasEnded, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGoodAsDead;
    /// <summary>
    /// Function: SetGoodAsDead
    /// </summary>
    public unsafe override void SetGoodAsDead()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGoodAsDead, "BmScript.MPawnVillainKillerCroc.SetGoodAsDead");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopSloMo;
    /// <summary>
    /// Function: StopSloMo
    /// </summary>
    public unsafe virtual void StopSloMo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopSloMo, "BmScript.MPawnVillainKillerCroc.StopSloMo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartSloMo;
    /// <summary>
    /// Function: StartSloMo
    /// </summary>
    public unsafe virtual void StartSloMo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSloMo, "BmScript.MPawnVillainKillerCroc.StartSloMo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RagdollKill;
    /// <summary>
    /// Function: RagdollKill
    /// </summary>
    public unsafe override void RagdollKill()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RagdollKill, "BmScript.MPawnVillainKillerCroc.RagdollKill");
        byte* paramsPtr = stackalloc byte[272];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopDodgeHint;
    /// <summary>
    /// Function: StopDodgeHint
    /// </summary>
    public unsafe virtual void StopDodgeHint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopDodgeHint, "BmScript.MPawnVillainKillerCroc.StopDodgeHint");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartDodgeHint;
    /// <summary>
    /// Function: StartDodgeHint
    /// </summary>
    public unsafe virtual void StartDodgeHint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartDodgeHint, "BmScript.MPawnVillainKillerCroc.StartDodgeHint");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TakeDamage;
    /// <summary>
    /// Function: TakeDamage
    /// </summary>
    public unsafe override void TakeDamage(int Damage, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeDamage, "BmScript.MPawnVillainKillerCroc.TakeDamage");
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 72);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Died, "BmScript.MPawnVillainKillerCroc.Died");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetBatClawPriority;
    /// <summary>
    /// Function: GetBatClawPriority
    /// </summary>
    public unsafe override float GetBatClawPriority()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatClawPriority, "BmScript.MPawnVillainKillerCroc.GetBatClawPriority");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSmokeBombReactionClass;
    /// <summary>
    /// Function: GetSmokeBombReactionClass
    /// </summary>
    public unsafe override BmSDK.Class GetSmokeBombReactionClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSmokeBombReactionClass, "BmScript.MPawnVillainKillerCroc.GetSmokeBombReactionClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HitByBatarang;
    /// <summary>
    /// Function: HitByBatarang
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult HitByBatarang(int Damage, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitByBatarang, "BmScript.MPawnVillainKillerCroc.HitByBatarang");
        byte* paramsPtr = stackalloc byte[93];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 72);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 76);
    }

    private static BmSDK.Function __fn_SpawnSpecialAttack;
    /// <summary>
    /// Function: SpawnSpecialAttack
    /// </summary>
    public unsafe override bool SpawnSpecialAttack(BmSDK.BmGame.RPawnCombat PlayerPawn, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnSpecialAttack, "BmScript.MPawnVillainKillerCroc.SpawnSpecialAttack");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ResetBeatdownPrompt;
    /// <summary>
    /// Function: ResetBeatdownPrompt
    /// </summary>
    public unsafe virtual void ResetBeatdownPrompt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetBeatdownPrompt, "BmScript.MPawnVillainKillerCroc.ResetBeatdownPrompt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForWallHit;
    /// <summary>
    /// Function: CheckForWallHit
    /// </summary>
    public unsafe virtual bool CheckForWallHit(float WallColRange, System.Numerics.Vector3 Extent = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForWallHit, "BmScript.MPawnVillainKillerCroc.CheckForWallHit");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallColRange, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CanPickup;
    /// <summary>
    /// Function: CanPickup
    /// </summary>
    public unsafe override bool CanPickup(BmSDK.BmGame.RBMCombatThrownObject Object)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPickup, "BmScript.MPawnVillainKillerCroc.CanPickup");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Object, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ThereAreOtherThugsAround;
    /// <summary>
    /// Function: ThereAreOtherThugsAround
    /// </summary>
    public unsafe virtual bool ThereAreOtherThugsAround()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThereAreOtherThugsAround, "BmScript.MPawnVillainKillerCroc.ThereAreOtherThugsAround");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTargetPriority;
    /// <summary>
    /// Function: GetTargetPriority
    /// </summary>
    public unsafe override float GetTargetPriority(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargetPriority, "BmScript.MPawnVillainKillerCroc.GetTargetPriority");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CreateBatmansBossWeaponConfig;
    /// <summary>
    /// Function: CreateBatmansBossWeaponConfig
    /// </summary>
    public unsafe override void CreateBatmansBossWeaponConfig(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateBatmansBossWeaponConfig, "BmScript.MPawnVillainKillerCroc.CreateBatmansBossWeaponConfig");
        byte* paramsPtr = stackalloc byte[1192];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FakeAnimReference;
    /// <summary>
    /// Function: FakeAnimReference
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet FakeAnimReference()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FakeAnimReference, "BmScript.MPawnVillainKillerCroc.FakeAnimReference");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_KcCreatePickupWeaponConfig;
    /// <summary>
    /// Function: KcCreatePickupWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig KcCreatePickupWeaponConfig(BmSDK.GameObject NewOwner)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KcCreatePickupWeaponConfig, "BmScript.MPawnVillainKillerCroc.KcCreatePickupWeaponConfig");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_KcCreateHitReactionWeaponConfig;
    /// <summary>
    /// Function: KcCreateHitReactionWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig KcCreateHitReactionWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.FName CombatMovementStance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KcCreateHitReactionWeaponConfig, "BmScript.MPawnVillainKillerCroc.KcCreateHitReactionWeaponConfig");
        byte* paramsPtr = stackalloc byte[1128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatMovementStance, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_KcCreateCombatWeaponConfig;
    /// <summary>
    /// Function: KcCreateCombatWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig KcCreateCombatWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.FName CombatMovementStance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KcCreateCombatWeaponConfig, "BmScript.MPawnVillainKillerCroc.KcCreateCombatWeaponConfig");
        byte* paramsPtr = stackalloc byte[448];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatMovementStance, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CreateWeaponConfigUnarmed;
    /// <summary>
    /// Function: CreateWeaponConfigUnarmed
    /// </summary>
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateWeaponConfigUnarmed(BmSDK.GameObject NewOwner)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateWeaponConfigUnarmed, "BmScript.MPawnVillainKillerCroc.CreateWeaponConfigUnarmed");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetTauntStance;
    /// <summary>
    /// Function: GetTauntStance
    /// </summary>
    public unsafe override BmSDK.FName GetTauntStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTauntStance, "BmScript.MPawnVillainKillerCroc.GetTauntStance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NotifyThrowAttackSucceed;
    /// <summary>
    /// Function: NotifyThrowAttackSucceed
    /// </summary>
    public unsafe virtual void NotifyThrowAttackSucceed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyThrowAttackSucceed, "BmScript.MPawnVillainKillerCroc.NotifyThrowAttackSucceed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyThrowAttackFailed;
    /// <summary>
    /// Function: NotifyThrowAttackFailed
    /// </summary>
    public unsafe virtual void NotifyThrowAttackFailed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyThrowAttackFailed, "BmScript.MPawnVillainKillerCroc.NotifyThrowAttackFailed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseHUD;
    /// <summary>
    /// Function: CloseHUD
    /// </summary>
    public unsafe virtual void CloseHUD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseHUD, "BmScript.MPawnVillainKillerCroc.CloseHUD");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitHUD;
    /// <summary>
    /// Function: InitHUD
    /// </summary>
    public unsafe virtual void InitHUD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitHUD, "BmScript.MPawnVillainKillerCroc.InitHUD");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySmallTaunt;
    /// <summary>
    /// Function: PlaySmallTaunt
    /// </summary>
    public unsafe virtual void PlaySmallTaunt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySmallTaunt, "BmScript.MPawnVillainKillerCroc.PlaySmallTaunt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHealth;
    /// <summary>
    /// Function: SetHealth
    /// </summary>
    public unsafe override void SetHealth()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHealth, "BmScript.MPawnVillainKillerCroc.SetHealth");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanPlayBark;
    /// <summary>
    /// Function: CanPlayBark
    /// </summary>
    public unsafe override bool CanPlayBark()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayBark, "BmScript.MPawnVillainKillerCroc.CanPlayBark");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CreateWeapon;
    /// <summary>
    /// Function: CreateWeapon
    /// </summary>
    public unsafe override BmSDK.BmGame.RBMWeapon CreateWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateWeapon, "BmScript.MPawnVillainKillerCroc.CreateWeapon");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMWeapon>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmScript.MPawnVillainKillerCroc.PostBeginPlay");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmScript.MPawnVillainKillerCroc.PreStreamOut");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostInitCharacter;
    /// <summary>
    /// Function: PostInitCharacter
    /// </summary>
    public unsafe override void PostInitCharacter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostInitCharacter, "BmScript.MPawnVillainKillerCroc.PostInitCharacter");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StructProperty: ImpactScreenShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ImpactScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 4004);

    /// <summary>
    /// ObjectProperty: HudPlayerController
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController HudPlayerController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 4148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4148); }
    }

    /// <summary>
    /// ObjectProperty: FootstepVfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem FootstepVfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4152); }
    }

    /// <summary>
    /// IntProperty: NumOfStage
    /// </summary>
    public unsafe int NumOfStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4156); }
    }

    /// <summary>
    /// IntProperty: HealtPerState
    /// </summary>
    public unsafe int HealtPerState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4160); }
    }

    /// <summary>
    /// FloatProperty: StunTimeAfterBeatdown
    /// </summary>
    public unsafe float StunTimeAfterBeatdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4164); }
    }

    /// <summary>
    /// IntProperty: NumberOfBeatdownStrikes
    /// </summary>
    public unsafe int NumberOfBeatdownStrikes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4168); }
    }

    /// <summary>
    /// ArrayProperty: DamageThreshold
    /// </summary>
    public unsafe BmSDK.TArray<int> DamageThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 4172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4172); }
    }

    /// <summary>
    /// IntProperty: StartingHealth
    /// </summary>
    public unsafe int StartingHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4184); }
    }

    /// <summary>
    /// IntProperty: BeatdownEndDamageVal
    /// </summary>
    public unsafe int BeatdownEndDamageVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4188); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: KillerCrocCloseAttackDamageMultiplier
    /// </summary>
    public InlineArray<float> KillerCrocCloseAttackDamageMultiplier => new(3, Ptr + 4192, 4, this);

    /// <summary>
    /// FloatProperty: KillerCrocCloseAttackDamageMultiplier
    /// </summary>
    public unsafe float KillerCrocCloseAttackDamageMultiplier_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4192); }
    }
    /// <summary>
    /// FloatProperty: KillerCrocCloseAttackDamageMultiplier
    /// </summary>
    public unsafe float KillerCrocCloseAttackDamageMultiplier_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4196); }
    }
    /// <summary>
    /// FloatProperty: KillerCrocCloseAttackDamageMultiplier
    /// </summary>
    public unsafe float KillerCrocCloseAttackDamageMultiplier_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4200); }
    }

    /// <summary>
    /// FloatProperty: KCSpecialZoomInBiteSequenceCameraFOV
    /// </summary>
    public unsafe float KCSpecialZoomInBiteSequenceCameraFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4204); }
    }

    /// <summary>
    /// FloatProperty: KCDefaultCameraFOV
    /// </summary>
    public unsafe float KCDefaultCameraFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4208); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: KillerCrocJumpAttackDamage
    /// </summary>
    public InlineArray<float> KillerCrocJumpAttackDamage => new(3, Ptr + 4212, 4, this);

    /// <summary>
    /// FloatProperty: KillerCrocJumpAttackDamage
    /// </summary>
    public unsafe float KillerCrocJumpAttackDamage_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4212); }
    }
    /// <summary>
    /// FloatProperty: KillerCrocJumpAttackDamage
    /// </summary>
    public unsafe float KillerCrocJumpAttackDamage_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4216); }
    }
    /// <summary>
    /// FloatProperty: KillerCrocJumpAttackDamage
    /// </summary>
    public unsafe float KillerCrocJumpAttackDamage_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4220); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: KillerCrocJumpAttackPlayerDamage
    /// </summary>
    public InlineArray<float> KillerCrocJumpAttackPlayerDamage => new(3, Ptr + 4224, 4, this);

    /// <summary>
    /// FloatProperty: KillerCrocJumpAttackPlayerDamage
    /// </summary>
    public unsafe float KillerCrocJumpAttackPlayerDamage_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4224); }
    }
    /// <summary>
    /// FloatProperty: KillerCrocJumpAttackPlayerDamage
    /// </summary>
    public unsafe float KillerCrocJumpAttackPlayerDamage_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4228); }
    }
    /// <summary>
    /// FloatProperty: KillerCrocJumpAttackPlayerDamage
    /// </summary>
    public unsafe float KillerCrocJumpAttackPlayerDamage_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4232); }
    }

    /// <summary>
    /// FloatProperty: JumpEOFRange
    /// </summary>
    public unsafe float JumpEOFRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4236); }
    }

    /// <summary>
    /// FloatProperty: JumpEOFStunTime
    /// </summary>
    public unsafe float JumpEOFStunTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4240); }
    }

    /// <summary>
    /// FloatProperty: JumpEOFImpulse
    /// </summary>
    public unsafe float JumpEOFImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4244); }
    }

    /// <summary>
    /// FloatProperty: KCGroundSlamSloMoSpeed
    /// </summary>
    public unsafe float KCGroundSlamSloMoSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4248); }
    }

    /// <summary>
    /// BoolProperty: bThrowPropaneTank
    /// </summary>
    public unsafe bool bThrowPropaneTank
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4252) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4252); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4252); }
    }

    /// <summary>
    /// BoolProperty: bCanPlayBiteAttack
    /// </summary>
    public unsafe bool bCanPlayBiteAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4252) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4252); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4252); }
    }

    /// <summary>
    /// BoolProperty: bIsThisLastBeatdownStrike
    /// </summary>
    public unsafe bool bIsThisLastBeatdownStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4252) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4252); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4252); }
    }

    /// <summary>
    /// BoolProperty: bFinalMoveTriggered
    /// </summary>
    public unsafe bool bFinalMoveTriggered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4252) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4252); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4252); }
    }

    /// <summary>
    /// BoolProperty: bTurnForBiteAttack
    /// </summary>
    public unsafe bool bTurnForBiteAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4252) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4252); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4252); }
    }

    /// <summary>
    /// BoolProperty: bShowBiteTutorial
    /// </summary>
    public unsafe bool bShowBiteTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4252) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4252); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4252); }
    }

    /// <summary>
    /// BoolProperty: bSlowedDownDuringGroundSlam
    /// </summary>
    public unsafe bool bSlowedDownDuringGroundSlam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4252) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4252); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4252); }
    }

    /// <summary>
    /// BoolProperty: bIsFirstTimeBlockDialogue
    /// </summary>
    public unsafe bool bIsFirstTimeBlockDialogue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4252) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4252); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4252); }
    }

    /// <summary>
    /// BoolProperty: bIsFirstTimeChargeAttackDialogue
    /// </summary>
    public unsafe bool bIsFirstTimeChargeAttackDialogue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4252) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4252); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4252); }
    }

    /// <summary>
    /// BoolProperty: bPlayedCinematic
    /// </summary>
    public unsafe bool bPlayedCinematic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4252) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4252); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4252); }
    }

    /// <summary>
    /// BoolProperty: bHasPlayedTauntThisBetweenAttacksSequence
    /// </summary>
    public unsafe bool bHasPlayedTauntThisBetweenAttacksSequence
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4252) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4252); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4252); }
    }

    /// <summary>
    /// BoolProperty: bShowDodgeTutorial
    /// </summary>
    public unsafe bool bShowDodgeTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4252) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4252); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4252); }
    }

    /// <summary>
    /// IntProperty: CurrentDamageLevel
    /// </summary>
    public unsafe int CurrentDamageLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4256); }
    }

    /// <summary>
    /// ObjectProperty: BatmanRPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController BatmanRPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 4260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4260); }
    }

    /// <summary>
    /// FloatProperty: NoBeatdownTimer
    /// </summary>
    public unsafe float NoBeatdownTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4264); }
    }

    /// <summary>
    /// IntProperty: NrOfBlocksSinceLastBeatdown
    /// </summary>
    public unsafe int NrOfBlocksSinceLastBeatdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4268); }
    }

    /// <summary>
    /// IntProperty: NrOfTimesCrocMadeCloseAttackDmgToBatmanSinceLastBeatdown
    /// </summary>
    public unsafe int NrOfTimesCrocMadeCloseAttackDmgToBatmanSinceLastBeatdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4272); }
    }

    /// <summary>
    /// IntProperty: KCBlockSpeechProbability
    /// </summary>
    public unsafe int KCBlockSpeechProbability
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4276); }
    }

    /// <summary>
    /// FloatProperty: KCBlockSpeechMinimunRepetitionTime
    /// </summary>
    public unsafe float KCBlockSpeechMinimunRepetitionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4280); }
    }

    /// <summary>
    /// FloatProperty: KCBlockSpeechCurrentTime
    /// </summary>
    public unsafe float KCBlockSpeechCurrentTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4284); }
    }

    /// <summary>
    /// FloatProperty: KCChargePunchSpeechMinimunRepetitionTime
    /// </summary>
    public unsafe float KCChargePunchSpeechMinimunRepetitionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4288); }
    }

    /// <summary>
    /// FloatProperty: KCChargePunchSpeechCurrentTime
    /// </summary>
    public unsafe float KCChargePunchSpeechCurrentTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4292); }
    }

    /// <summary>
    /// IntProperty: KCChargePunchBlockSpeechProbability
    /// </summary>
    public unsafe int KCChargePunchBlockSpeechProbability
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4296); }
    }

    /// <summary>
    /// FloatProperty: CameraWallSafeDistance
    /// </summary>
    public unsafe float CameraWallSafeDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4300); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: Turn135DamageOnPlayer
    /// </summary>
    public InlineArray<float> Turn135DamageOnPlayer => new(3, Ptr + 4304, 4, this);

    /// <summary>
    /// FloatProperty: Turn135DamageOnPlayer
    /// </summary>
    public unsafe float Turn135DamageOnPlayer_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4304); }
    }
    /// <summary>
    /// FloatProperty: Turn135DamageOnPlayer
    /// </summary>
    public unsafe float Turn135DamageOnPlayer_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4308); }
    }
    /// <summary>
    /// FloatProperty: Turn135DamageOnPlayer
    /// </summary>
    public unsafe float Turn135DamageOnPlayer_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4312); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: Turn135DamageOnThug
    /// </summary>
    public InlineArray<float> Turn135DamageOnThug => new(3, Ptr + 4316, 4, this);

    /// <summary>
    /// FloatProperty: Turn135DamageOnThug
    /// </summary>
    public unsafe float Turn135DamageOnThug_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4316); }
    }
    /// <summary>
    /// FloatProperty: Turn135DamageOnThug
    /// </summary>
    public unsafe float Turn135DamageOnThug_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4320); }
    }
    /// <summary>
    /// FloatProperty: Turn135DamageOnThug
    /// </summary>
    public unsafe float Turn135DamageOnThug_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4324); }
    }

    /// <summary>
    /// FloatProperty: DamageProxyRadius
    /// </summary>
    public unsafe float DamageProxyRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4328); }
    }

    /// <summary>
    /// ObjectProperty: KillerCroc_KC_ChargePunch
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine KillerCroc_KC_ChargePunch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4332); }
    }

    /// <summary>
    /// ObjectProperty: KillerCroc_KC_GetFuelTank
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine KillerCroc_KC_GetFuelTank
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4336); }
    }

    /// <summary>
    /// ObjectProperty: KillerCroc_KC_Grab
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine KillerCroc_KC_Grab
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4340); }
    }

    /// <summary>
    /// ObjectProperty: KillerCroc_KC_IneffectiveAttack
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine KillerCroc_KC_IneffectiveAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4344); }
    }

    /// <summary>
    /// ObjectProperty: KillerCroc_KC_Laugh
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine KillerCroc_KC_Laugh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4348); }
    }

    /// <summary>
    /// ObjectProperty: KillerCroc_KC_SmashFuelTank
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine KillerCroc_KC_SmashFuelTank
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4352); }
    }

    /// <summary>
    /// ObjectProperty: KillerCroc_KC_SmokePellet
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine KillerCroc_KC_SmokePellet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4356); }
    }

    /// <summary>
    /// ObjectProperty: KillerCroc_KC_ThrowFuelTank
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine KillerCroc_KC_ThrowFuelTank
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4360); }
    }

    /// <summary>
    /// FloatProperty: KCSmokePelletBossBartTime
    /// </summary>
    public unsafe float KCSmokePelletBossBartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4364); }
    }

    /// <summary>
    /// IntProperty: AttackCounter
    /// </summary>
    public unsafe int AttackCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4368); }
    }

    /// <summary>
    /// StructProperty: SmallTauntTransitionID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId SmallTauntTransitionID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 4372);

    /// <summary>
    /// IntProperty: BiteAttackCount
    /// </summary>
    public unsafe int BiteAttackCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4376); }
    }
}
