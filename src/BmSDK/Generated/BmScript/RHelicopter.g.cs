#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RHelicopter<br/>
/// (size = 4780)
/// (flags = 10486326)
/// </summary>
public partial class RHelicopter : BmSDK.BmGame.RHelicopterBase, BmSDK.BmGame.RBatarangableInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RHelicopter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RHelicopter.
    /// </summary>
    public static RHelicopter DefaultObject => (RHelicopter)StaticClass().DefaultObject;

    internal RHelicopter() { }

    /// <summary>
    /// Constructs a new RHelicopter
    /// </summary>
    public RHelicopter(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHelicopter(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHelicopter>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopter>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHelicopter>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopter>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopter>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopter>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHelicopter>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopter>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_StartleNearbyCrows;
    /// <summary>
    /// Function: StartleNearbyCrows
    /// </summary>
    public unsafe virtual void StartleNearbyCrows()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartleNearbyCrows, "BmScript.RHelicopter.StartleNearbyCrows");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Touch;
    /// <summary>
    /// Function: Touch
    /// </summary>
    public unsafe override void Touch(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Touch, "BmScript.RHelicopter.Touch");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsTargetatble;
    /// <summary>
    /// Function: IsTargetatble
    /// </summary>
    public unsafe override bool IsTargetatble()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTargetatble, "BmScript.RHelicopter.IsTargetatble");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBatarangSpeedBoost;
    /// <summary>
    /// Function: GetBatarangSpeedBoost
    /// </summary>
    public unsafe virtual float GetBatarangSpeedBoost()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatarangSpeedBoost, "BmScript.RHelicopter.GetBatarangSpeedBoost");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ForceHitAtEndOfFlight;
    /// <summary>
    /// Function: ForceHitAtEndOfFlight
    /// </summary>
    public unsafe virtual bool ForceHitAtEndOfFlight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceHitAtEndOfFlight, "BmScript.RHelicopter.ForceHitAtEndOfFlight");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBatarangPriority;
    /// <summary>
    /// Function: GetBatarangPriority
    /// </summary>
    public unsafe virtual float GetBatarangPriority()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatarangPriority, "BmScript.RHelicopter.GetBatarangPriority");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsBatarangable;
    /// <summary>
    /// Function: IsBatarangable
    /// </summary>
    public unsafe virtual bool IsBatarangable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBatarangable, "BmScript.RHelicopter.IsBatarangable");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBatarangTargetPosition;
    /// <summary>
    /// Function: GetBatarangTargetPosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetBatarangTargetPosition(System.Numerics.Vector3 AimLocation, System.Numerics.Vector3 AimDirection, bool bDuringTargetPhase = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatarangTargetPosition, "BmScript.RHelicopter.GetBatarangTargetPosition");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimDirection, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDuringTargetPhase, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_SetHelicopterControlVolume;
    /// <summary>
    /// Function: SetHelicopterControlVolume
    /// </summary>
    public unsafe virtual void SetHelicopterControlVolume(BmSDK.BmScript.RHelicopterControlVolume ControlVolume, bool bEntering)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHelicopterControlVolume, "BmScript.RHelicopter.SetHelicopterControlVolume");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControlVolume, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEntering, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetOverrideSpeed;
    /// <summary>
    /// Function: SetOverrideSpeed
    /// </summary>
    public unsafe override void SetOverrideSpeed(float _override_speed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOverrideSpeed, "BmScript.RHelicopter.SetOverrideSpeed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_override_speed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Bump;
    /// <summary>
    /// Function: Bump
    /// </summary>
    public unsafe override void Bump(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Bump, "BmScript.RHelicopter.Bump");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireHelicopterScannedEvent;
    /// <summary>
    /// Function: FireHelicopterScannedEvent
    /// </summary>
    public unsafe override void FireHelicopterScannedEvent(BmSDK.BmGame.RPlayerController _RPC, bool IsControlHelicopter)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireHelicopterScannedEvent, "BmScript.RHelicopter.FireHelicopterScannedEvent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsControlHelicopter, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetControlChopper;
    /// <summary>
    /// Function: SetControlChopper
    /// </summary>
    public unsafe override void SetControlChopper()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetControlChopper, "BmScript.RHelicopter.SetControlChopper");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGrapplePointEnabledInternal;
    /// <summary>
    /// Function: SetGrapplePointEnabledInternal
    /// </summary>
    public unsafe virtual void SetGrapplePointEnabledInternal(bool make_enabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGrapplePointEnabledInternal, "BmScript.RHelicopter.SetGrapplePointEnabledInternal");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(make_enabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGrapplePointEnabled;
    /// <summary>
    /// Function: SetGrapplePointEnabled
    /// </summary>
    public unsafe override void SetGrapplePointEnabled(bool make_enabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGrapplePointEnabled, "BmScript.RHelicopter.SetGrapplePointEnabled");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(make_enabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartDownloadHud;
    /// <summary>
    /// Function: StartDownloadHud
    /// </summary>
    public unsafe override void StartDownloadHud()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartDownloadHud, "BmScript.RHelicopter.StartDownloadHud");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReleaseHelicopterPanel;
    /// <summary>
    /// Function: ReleaseHelicopterPanel
    /// </summary>
    public unsafe override void ReleaseHelicopterPanel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseHelicopterPanel, "BmScript.RHelicopter.ReleaseHelicopterPanel");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OpenHelicopterPanel;
    /// <summary>
    /// Function: OpenHelicopterPanel
    /// </summary>
    public unsafe override void OpenHelicopterPanel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenHelicopterPanel, "BmScript.RHelicopter.OpenHelicopterPanel");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupPlayerGrapplePoint;
    /// <summary>
    /// Function: SetupPlayerGrapplePoint
    /// </summary>
    public unsafe virtual void SetupPlayerGrapplePoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupPlayerGrapplePoint, "BmScript.RHelicopter.SetupPlayerGrapplePoint");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawDebug;
    /// <summary>
    /// Function: DrawDebug
    /// </summary>
    public unsafe virtual void DrawDebug()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebug, "BmScript.RHelicopter.DrawDebug");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetActorThoughts;
    /// <summary>
    /// Function: GetActorThoughts
    /// </summary>
    public unsafe override void GetActorThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList, out System.Numerics.Vector3 ThoughtLocationOverride, BmSDK.FString IndentString = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActorThoughts, "BmScript.RHelicopter.GetActorThoughts");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ThoughtLocationOverride);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThoughtLocationOverride, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IndentString, paramsPtr + 24);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        ThoughtLocationOverride = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_StopHelicopterDialogue;
    /// <summary>
    /// Function: StopHelicopterDialogue
    /// </summary>
    public unsafe virtual void StopHelicopterDialogue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopHelicopterDialogue, "BmScript.RHelicopter.StopHelicopterDialogue");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayHelicopterDialogue;
    /// <summary>
    /// Function: PlayHelicopterDialogue
    /// </summary>
    public unsafe virtual void PlayHelicopterDialogue(BmSDK.BmScript.RSeqEvent_HelicopterDialogueTrigger.HeliDialogue DialogueEnum, bool PlayEvenIfTooSoon = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHelicopterDialogue, "BmScript.RHelicopter.PlayHelicopterDialogue");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueEnum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayEvenIfTooSoon, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsSameDialogue;
    /// <summary>
    /// Function: IsSameDialogue
    /// </summary>
    public unsafe virtual bool IsSameDialogue(BmSDK.BmScript.RSeqEvent_HelicopterDialogueTrigger.HeliDialogue DialogueEnum1, BmSDK.BmScript.RSeqEvent_HelicopterDialogueTrigger.HeliDialogue DialogueEnum2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSameDialogue, "BmScript.RHelicopter.IsSameDialogue");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueEnum1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueEnum2, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_FindDialogueTriggerEvent;
    /// <summary>
    /// Function: FindDialogueTriggerEvent
    /// </summary>
    public unsafe virtual bool FindDialogueTriggerEvent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindDialogueTriggerEvent, "BmScript.RHelicopter.FindDialogueTriggerEvent");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpawnBulletFX;
    /// <summary>
    /// Function: SpawnBulletFX
    /// </summary>
    public unsafe virtual void SpawnBulletFX(System.Numerics.Vector3 StartLoc, BmSDK.Engine.Actor.FImpactInfo Impact)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnBulletFX, "BmScript.RHelicopter.SpawnBulletFX");
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Impact, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetImpactMaterial;
    /// <summary>
    /// Function: GetImpactMaterial
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPhysicalMaterialProperty GetImpactMaterial(BmSDK.Engine.Actor.FImpactInfo Impact)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetImpactMaterial, "BmScript.RHelicopter.GetImpactMaterial");
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Impact, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPhysicalMaterialProperty>(paramsPtr + 88);
    }

    private static BmSDK.Function __fn_DoShotFX;
    /// <summary>
    /// Function: DoShotFX
    /// </summary>
    public unsafe virtual void DoShotFX(bool bForceMiss)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoShotFX, "BmScript.RHelicopter.DoShotFX");
        byte* paramsPtr = stackalloc byte[420];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceMiss, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsImpactOnPlayer;
    /// <summary>
    /// Function: IsImpactOnPlayer
    /// </summary>
    public unsafe virtual bool IsImpactOnPlayer(System.Numerics.Vector3 StartTrace, System.Numerics.Vector3 EndTrace, out BmSDK.Engine.Actor.FImpactInfo PlayerImpact)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsImpactOnPlayer, "BmScript.RHelicopter.IsImpactOnPlayer");
        byte* paramsPtr = stackalloc byte[200];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartTrace, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndTrace, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PlayerImpact);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerImpact, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PlayerImpact = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FImpactInfo>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 112);
    }

    private static BmSDK.Function __fn_GetRandDeviance;
    /// <summary>
    /// Function: GetRandDeviance
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetRandDeviance(BmSDK.Rotator Heading)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRandDeviance, "BmScript.RHelicopter.GetRandDeviance");
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Heading, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ReportRocketSuccess;
    /// <summary>
    /// Function: ReportRocketSuccess
    /// </summary>
    public unsafe virtual void ReportRocketSuccess(bool was_successful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReportRocketSuccess, "BmScript.RHelicopter.ReportRocketSuccess");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(was_successful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireRocket;
    /// <summary>
    /// Function: FireRocket
    /// </summary>
    public unsafe virtual void FireRocket(bool TargetBatman, System.Numerics.Vector3 StaticTarget = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireRocket, "BmScript.RHelicopter.FireRocket");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBatman, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StaticTarget, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickWeapons;
    /// <summary>
    /// Function: TickWeapons
    /// </summary>
    public unsafe virtual void TickWeapons(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickWeapons, "BmScript.RHelicopter.TickWeapons");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRocketLockon;
    /// <summary>
    /// Function: SetRocketLockon
    /// </summary>
    public unsafe virtual void SetRocketLockon(bool is_active, float Proportion)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRocketLockon, "BmScript.RHelicopter.SetRocketLockon");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_active, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proportion, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetChainGunSpinning;
    /// <summary>
    /// Function: SetChainGunSpinning
    /// </summary>
    public unsafe virtual void SetChainGunSpinning(bool is_active)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetChainGunSpinning, "BmScript.RHelicopter.SetChainGunSpinning");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_active, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetChainGunJammingEffect;
    /// <summary>
    /// Function: SetChainGunJammingEffect
    /// </summary>
    public unsafe virtual void SetChainGunJammingEffect(bool is_active)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetChainGunJammingEffect, "BmScript.RHelicopter.SetChainGunJammingEffect");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_active, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetChainGunActive;
    /// <summary>
    /// Function: SetChainGunActive
    /// </summary>
    public unsafe virtual void SetChainGunActive(bool is_active)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetChainGunActive, "BmScript.RHelicopter.SetChainGunActive");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_active, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AdvanceAttackMode;
    /// <summary>
    /// Function: AdvanceAttackMode
    /// </summary>
    public unsafe virtual void AdvanceAttackMode(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdvanceAttackMode, "BmScript.RHelicopter.AdvanceAttackMode");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCurrentAttackMode;
    /// <summary>
    /// Function: SetCurrentAttackMode
    /// </summary>
    public unsafe virtual void SetCurrentAttackMode(BmSDK.BmScript.RHelicopter.HeliAttackMode attack_mode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentAttackMode, "BmScript.RHelicopter.SetCurrentAttackMode");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(attack_mode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTargetAttackMode;
    /// <summary>
    /// Function: SetTargetAttackMode
    /// </summary>
    public unsafe virtual void SetTargetAttackMode(BmSDK.BmScript.RHelicopter.HeliAttackMode attack_mode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTargetAttackMode, "BmScript.RHelicopter.SetTargetAttackMode");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(attack_mode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRocketSocketOrigin;
    /// <summary>
    /// Function: GetRocketSocketOrigin
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetRocketSocketOrigin(bool left_socket)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRocketSocketOrigin, "BmScript.RHelicopter.GetRocketSocketOrigin");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(left_socket, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetSearchLightOrigin;
    /// <summary>
    /// Function: GetSearchLightOrigin
    /// </summary>
    public unsafe virtual void GetSearchLightOrigin()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSearchLightOrigin, "BmScript.RHelicopter.GetSearchLightOrigin");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNextPoint;
    /// <summary>
    /// Function: GetNextPoint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPatrolPoint GetNextPoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextPoint, "BmScript.RHelicopter.GetNextPoint");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPatrolPoint>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GotoNextPoint;
    /// <summary>
    /// Function: GotoNextPoint
    /// </summary>
    public unsafe virtual void GotoNextPoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoNextPoint, "BmScript.RHelicopter.GotoNextPoint");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTurningDistance;
    /// <summary>
    /// Function: SetTurningDistance
    /// </summary>
    public unsafe virtual void SetTurningDistance(float NewTurningDistance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTurningDistance, "BmScript.RHelicopter.SetTurningDistance");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTurningDistance, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateDustEffect;
    /// <summary>
    /// Function: UpdateDustEffect
    /// </summary>
    public unsafe virtual void UpdateDustEffect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateDustEffect, "BmScript.RHelicopter.UpdateDustEffect");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnToggleHidden;
    /// <summary>
    /// Function: OnToggleHidden
    /// </summary>
    public unsafe override void OnToggleHidden(BmSDK.Engine.SeqAct_ToggleHidden Action)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnToggleHidden, "BmScript.RHelicopter.OnToggleHidden");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WatchPlayer;
    /// <summary>
    /// Function: WatchPlayer
    /// </summary>
    public unsafe override void WatchPlayer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WatchPlayer, "BmScript.RHelicopter.WatchPlayer");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeDamage, "BmScript.RHelicopter.TakeDamage");
        byte* paramsPtr = stackalloc byte[92];
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

    private static BmSDK.Function __fn_CanBeJammed;
    /// <summary>
    /// Function: CanBeJammed
    /// </summary>
    public unsafe override bool CanBeJammed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeJammed, "BmScript.RHelicopter.CanBeJammed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HitByJammerGadgetCharge;
    /// <summary>
    /// Function: HitByJammerGadgetCharge
    /// </summary>
    public unsafe override void HitByJammerGadgetCharge()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitByJammerGadgetCharge, "BmScript.RHelicopter.HitByJammerGadgetCharge");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RecoveredFromREC;
    /// <summary>
    /// Function: RecoveredFromREC
    /// </summary>
    public unsafe override void RecoveredFromREC()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecoveredFromREC, "BmScript.RHelicopter.RecoveredFromREC");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HitByREC;
    /// <summary>
    /// Function: HitByREC
    /// </summary>
    public unsafe override void HitByREC(System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 AttackerLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitByREC, "BmScript.RHelicopter.HitByREC");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackerLocation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AlertToBatmansPosition;
    /// <summary>
    /// Function: AlertToBatmansPosition
    /// </summary>
    public unsafe virtual void AlertToBatmansPosition()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AlertToBatmansPosition, "BmScript.RHelicopter.AlertToBatmansPosition");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AnnoyWithGadget;
    /// <summary>
    /// Function: AnnoyWithGadget
    /// </summary>
    public unsafe virtual void AnnoyWithGadget(float annoyance_value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnnoyWithGadget, "BmScript.RHelicopter.AnnoyWithGadget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(annoyance_value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PointReached;
    /// <summary>
    /// Function: PointReached
    /// </summary>
    public unsafe virtual void PointReached()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PointReached, "BmScript.RHelicopter.PointReached");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChangePath;
    /// <summary>
    /// Function: ChangePath
    /// </summary>
    public unsafe override void ChangePath(BmSDK.BmGame.RPatrolPoint NewStartPoint, bool bTeleport)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangePath, "BmScript.RHelicopter.ChangePath");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewStartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTeleport, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetScanned;
    /// <summary>
    /// Function: SetScanned
    /// </summary>
    public unsafe override void SetScanned()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetScanned, "BmScript.RHelicopter.SetScanned");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasBeenScanned;
    /// <summary>
    /// Function: HasBeenScanned
    /// </summary>
    public unsafe override bool HasBeenScanned()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasBeenScanned, "BmScript.RHelicopter.HasBeenScanned");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetAggressionLevels;
    /// <summary>
    /// Function: SetAggressionLevels
    /// </summary>
    public unsafe override void SetAggressionLevels(bool ChaingunEnabled, bool MissilesEnabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAggressionLevels, "BmScript.RHelicopter.SetAggressionLevels");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChaingunEnabled, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MissilesEnabled, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HelicopterDismounted;
    /// <summary>
    /// Function: HelicopterDismounted
    /// </summary>
    public unsafe override void HelicopterDismounted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HelicopterDismounted, "BmScript.RHelicopter.HelicopterDismounted");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HelicopterBoarded;
    /// <summary>
    /// Function: HelicopterBoarded
    /// </summary>
    public unsafe override void HelicopterBoarded()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HelicopterBoarded, "BmScript.RHelicopter.HelicopterBoarded");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceLowQualityLight;
    /// <summary>
    /// Function: ForceLowQualityLight
    /// </summary>
    public unsafe override void ForceLowQualityLight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceLowQualityLight, "BmScript.RHelicopter.ForceLowQualityLight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceHighQualityLight;
    /// <summary>
    /// Function: ForceHighQualityLight
    /// </summary>
    public unsafe override void ForceHighQualityLight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceHighQualityLight, "BmScript.RHelicopter.ForceHighQualityLight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitLowDetail;
    /// <summary>
    /// Function: ExitLowDetail
    /// </summary>
    public unsafe virtual void ExitLowDetail()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitLowDetail, "BmScript.RHelicopter.ExitLowDetail");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnterLowDetail;
    /// <summary>
    /// Function: EnterLowDetail
    /// </summary>
    public unsafe virtual void EnterLowDetail()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnterLowDetail, "BmScript.RHelicopter.EnterLowDetail");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawDebugGraphics;
    /// <summary>
    /// Function: DrawDebugGraphics
    /// </summary>
    public unsafe override void DrawDebugGraphics()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugGraphics, "BmScript.RHelicopter.DrawDebugGraphics");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAggroHelicopter;
    /// <summary>
    /// Function: SetAggroHelicopter
    /// </summary>
    public unsafe virtual void SetAggroHelicopter(bool is_aggro)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAggroHelicopter, "BmScript.RHelicopter.SetAggroHelicopter");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_aggro, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsFirstTimeBatmanSeen;
    /// <summary>
    /// Function: IsFirstTimeBatmanSeen
    /// </summary>
    public unsafe virtual bool IsFirstTimeBatmanSeen()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFirstTimeBatmanSeen, "BmScript.RHelicopter.IsFirstTimeBatmanSeen");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetViewingBatmanInternal;
    /// <summary>
    /// Function: SetViewingBatmanInternal
    /// </summary>
    public unsafe virtual void SetViewingBatmanInternal(bool IsViewingBatman)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetViewingBatmanInternal, "BmScript.RHelicopter.SetViewingBatmanInternal");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsViewingBatman, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetViewingBatman;
    /// <summary>
    /// Function: SetViewingBatman
    /// </summary>
    public unsafe virtual void SetViewingBatman(bool IsViewingBatman)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetViewingBatman, "BmScript.RHelicopter.SetViewingBatman");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsViewingBatman, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoMoveToward;
    /// <summary>
    /// Function: DoMoveToward
    /// </summary>
    public unsafe virtual bool DoMoveToward(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoMoveToward, "BmScript.RHelicopter.DoMoveToward");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetMoveTowardPathLocations;
    /// <summary>
    /// Function: SetMoveTowardPathLocations
    /// </summary>
    public unsafe virtual bool SetMoveTowardPathLocations(System.Numerics.Vector3 _MoveTowardPathLocation1, System.Numerics.Vector3 _MoveTowardPathLocation2, float DeltaTime, float _MoveTowardSpeed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMoveTowardPathLocations, "BmScript.RHelicopter.SetMoveTowardPathLocations");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_MoveTowardPathLocation1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_MoveTowardPathLocation2, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_MoveTowardSpeed, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_SetMoveTowardLocation;
    /// <summary>
    /// Function: SetMoveTowardLocation
    /// </summary>
    public unsafe virtual bool SetMoveTowardLocation(System.Numerics.Vector3 _MoveTowardLocation, float DeltaTime, float _MoveTowardSpeed, bool _MoveTowardSlowdownOnApproach = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMoveTowardLocation, "BmScript.RHelicopter.SetMoveTowardLocation");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_MoveTowardLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_MoveTowardSpeed, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_MoveTowardSlowdownOnApproach, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmScript.RHelicopter.Tick");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldForceMissedShot;
    /// <summary>
    /// Function: ShouldForceMissedShot
    /// </summary>
    public unsafe virtual bool ShouldForceMissedShot()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldForceMissedShot, "BmScript.RHelicopter.ShouldForceMissedShot");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsAttackEnabled;
    /// <summary>
    /// Function: IsAttackEnabled
    /// </summary>
    public unsafe override bool IsAttackEnabled()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAttackEnabled, "BmScript.RHelicopter.IsAttackEnabled");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsViewablePlayerCharacter;
    /// <summary>
    /// Function: IsViewablePlayerCharacter
    /// </summary>
    public unsafe virtual bool IsViewablePlayerCharacter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsViewablePlayerCharacter, "BmScript.RHelicopter.IsViewablePlayerCharacter");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmScript.RHelicopter.Destroyed");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmScript.RHelicopter.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInvestigationStrings;
    /// <summary>
    /// Function: SetInvestigationStrings
    /// </summary>
    public unsafe virtual void SetInvestigationStrings(BmSDK.FString IS_Info, BmSDK.FString IS_InfoTitle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInvestigationStrings, "BmScript.RHelicopter.SetInvestigationStrings");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IS_Info, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IS_InfoTitle, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHighlightType;
    /// <summary>
    /// Function: SetHighlightType
    /// </summary>
    public unsafe virtual void SetHighlightType(BmSDK.BmScript.RHelicopter.HeliHighlightType new_type)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHighlightType, "BmScript.RHelicopter.SetHighlightType");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(new_type, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyXrayMat;
    /// <summary>
    /// Function: ApplyXrayMat
    /// </summary>
    public unsafe virtual void ApplyXrayMat(BmSDK.Engine.MaterialInstanceConstant NewXrayMat)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyXrayMat, "BmScript.RHelicopter.ApplyXrayMat");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewXrayMat, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetXrayMeshLevel;
    /// <summary>
    /// Function: SetXrayMeshLevel
    /// </summary>
    public unsafe virtual void SetXrayMeshLevel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetXrayMeshLevel, "BmScript.RHelicopter.SetXrayMeshLevel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DifficultySetup;
    /// <summary>
    /// Function: DifficultySetup
    /// </summary>
    public unsafe virtual void DifficultySetup()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DifficultySetup, "BmScript.RHelicopter.DifficultySetup");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: HeliHighlightType
    /// </summary>
    public enum HeliHighlightType : byte
    {
        HHT_STANDARD = 0,
        HHT_SCANNABLE = 1,
        HHT_SECONDARY = 2,
        HHT_CONTROL = 3,
        HHT_MAX = 4,
    }

    /// <summary>
    /// Enum: HeliAttackMode
    /// </summary>
    public enum HeliAttackMode : byte
    {
        HAM_NOT_SHOOTING = 0,
        HAM_SPIN_UP_CHAINGUN = 1,
        HAM_FIRING_CHAINGUN = 2,
        HAM_SPIN_DOWN_CHAINGUN = 3,
        HAM_DEPLOY_ROCKETS = 4,
        HAM_FIRE_ROCKETS = 5,
        HAM_RETRACT_ROCKETS = 6,
        HAM_MAX = 7,
    }

    /// <summary>
    /// ObjectProperty: StartPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RPatrolPoint StartPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPatrolPoint>(Ptr + 4508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4508); }
    }

    /// <summary>
    /// ObjectProperty: NextPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RPatrolPoint NextPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPatrolPoint>(Ptr + 4512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4512); }
    }

    /// <summary>
    /// BoolProperty: bDrawDebug
    /// </summary>
    public unsafe bool bDrawDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: bWatchBatmanFight
    /// </summary>
    public unsafe bool bWatchBatmanFight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: bAttackBatman
    /// </summary>
    public unsafe bool bAttackBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: bHasRockets
    /// </summary>
    public unsafe bool bHasRockets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: bAllowGrapple
    /// </summary>
    public unsafe bool bAllowGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: bCantCancelGrapple
    /// </summary>
    public unsafe bool bCantCancelGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: RocketLeftRightToggle
    /// </summary>
    public unsafe bool RocketLeftRightToggle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: RocketDoubleFireEnabled
    /// </summary>
    public unsafe bool RocketDoubleFireEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: bTemporarilyAllowedToAttack
    /// </summary>
    public unsafe bool bTemporarilyAllowedToAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: PanelDoorOpen
    /// </summary>
    public unsafe bool PanelDoorOpen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: bForceHighDetail
    /// </summary>
    public unsafe bool bForceHighDetail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: bWasWaitingWhenBatmanSpotted
    /// </summary>
    public unsafe bool bWasWaitingWhenBatmanSpotted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: BatmanHasBeenSeenEver
    /// </summary>
    public unsafe bool BatmanHasBeenSeenEver
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: bOverrideSearchlightViewingBatman
    /// </summary>
    public unsafe bool bOverrideSearchlightViewingBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: bOverrideGrapplePointAvailability
    /// </summary>
    public unsafe bool bOverrideGrapplePointAvailability
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: bEnableLightFX
    /// </summary>
    public unsafe bool bEnableLightFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: bEnableDust
    /// </summary>
    public unsafe bool bEnableDust
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: bEnableFlashingLight
    /// </summary>
    public unsafe bool bEnableFlashingLight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: ChaingunJammed
    /// </summary>
    public unsafe bool ChaingunJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: ChainGunEffectsActive
    /// </summary>
    public unsafe bool ChainGunEffectsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: ChainGunJammingEffectsActive
    /// </summary>
    public unsafe bool ChainGunJammingEffectsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: RocketLockonActive
    /// </summary>
    public unsafe bool RocketLockonActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: ChaingunIsSpinning
    /// </summary>
    public unsafe bool ChaingunIsSpinning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: AnnouncedBatmanKilled
    /// </summary>
    public unsafe bool AnnouncedBatmanKilled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: SearchlightViewingBatman
    /// </summary>
    public unsafe bool SearchlightViewingBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: MoveTowardModeIsPath
    /// </summary>
    public unsafe bool MoveTowardModeIsPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: MoveTowardSlowdownOnApproach
    /// </summary>
    public unsafe bool MoveTowardSlowdownOnApproach
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: bHasMovedThisFrame
    /// </summary>
    public unsafe bool bHasMovedThisFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: ForceXrayOveride
    /// </summary>
    public unsafe bool ForceXrayOveride
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// BoolProperty: bSavedAttackEnabled
    /// </summary>
    public unsafe bool bSavedAttackEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4516); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4516); }
    }

    /// <summary>
    /// FloatProperty: GunShotTime
    /// </summary>
    public unsafe float GunShotTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4520); }
    }

    /// <summary>
    /// FloatProperty: RocketShotTime
    /// </summary>
    public unsafe float RocketShotTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4524); }
    }

    /// <summary>
    /// FloatProperty: RocketShotTimeDoubleShot
    /// </summary>
    public unsafe float RocketShotTimeDoubleShot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4528); }
    }

    /// <summary>
    /// FloatProperty: GunDamage
    /// </summary>
    public unsafe float GunDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4532); }
    }

    /// <summary>
    /// FloatProperty: RocketDamage
    /// </summary>
    public unsafe float RocketDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4536); }
    }

    /// <summary>
    /// FloatProperty: fAnnoyedByGadget
    /// </summary>
    public unsafe float fAnnoyedByGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4540); }
    }

    /// <summary>
    /// FloatProperty: WindFrequency
    /// </summary>
    public unsafe float WindFrequency
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4544); }
    }

    /// <summary>
    /// FloatProperty: WindStrength
    /// </summary>
    public unsafe float WindStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4548); }
    }

    /// <summary>
    /// StructProperty: WindDirection
    /// </summary>
    public unsafe ref BmSDK.Rotator WindDirection
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 4552);

    /// <summary>
    /// FloatProperty: PauseTime
    /// </summary>
    public unsafe float PauseTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4564); }
    }

    /// <summary>
    /// FloatProperty: LastSeenTime
    /// </summary>
    public unsafe float LastSeenTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4568); }
    }

    /// <summary>
    /// FloatProperty: TimeWatchingBatman
    /// </summary>
    public unsafe float TimeWatchingBatman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4572); }
    }

    /// <summary>
    /// FloatProperty: LookAtTime
    /// </summary>
    public unsafe float LookAtTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4576); }
    }

    /// <summary>
    /// ArrayProperty: LookAtOrder
    /// </summary>
    public unsafe BmSDK.TArray<int> LookAtOrder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 4580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4580); }
    }

    /// <summary>
    /// IntProperty: LookAtIndex
    /// </summary>
    public unsafe int LookAtIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4592); }
    }

    /// <summary>
    /// FloatProperty: LastTimeWatchingBatman
    /// </summary>
    public unsafe float LastTimeWatchingBatman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4596); }
    }

    /// <summary>
    /// FloatProperty: LostContactTimeStamp
    /// </summary>
    public unsafe float LostContactTimeStamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4600); }
    }

    /// <summary>
    /// FloatProperty: DialogueTimeStamp
    /// </summary>
    public unsafe float DialogueTimeStamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4604); }
    }

    /// <summary>
    /// FloatProperty: MinPeriodBetweenDialogue
    /// </summary>
    public unsafe float MinPeriodBetweenDialogue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4608); }
    }

    /// <summary>
    /// ByteProperty: MostRecentDialogueEnum
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqEvent_HelicopterDialogueTrigger.HeliDialogue MostRecentDialogueEnum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqEvent_HelicopterDialogueTrigger.HeliDialogue>(Ptr + 4612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4612); }
    }

    /// <summary>
    /// ByteProperty: CurrentAttackMode
    /// </summary>
    public unsafe BmSDK.BmScript.RHelicopter.HeliAttackMode CurrentAttackMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RHelicopter.HeliAttackMode>(Ptr + 4613); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4613); }
    }

    /// <summary>
    /// ByteProperty: TargetAttackMode
    /// </summary>
    public unsafe BmSDK.BmScript.RHelicopter.HeliAttackMode TargetAttackMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RHelicopter.HeliAttackMode>(Ptr + 4614); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4614); }
    }

    /// <summary>
    /// ByteProperty: HighlightType
    /// </summary>
    public unsafe BmSDK.BmScript.RHelicopter.HeliHighlightType HighlightType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RHelicopter.HeliHighlightType>(Ptr + 4615); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4615); }
    }

    /// <summary>
    /// FloatProperty: LastSniperEventTime
    /// </summary>
    public unsafe float LastSniperEventTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4616); }
    }

    /// <summary>
    /// ObjectProperty: DialogueTriggerEvent
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqEvent_HelicopterDialogueTrigger DialogueTriggerEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqEvent_HelicopterDialogueTrigger>(Ptr + 4620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4620); }
    }

    /// <summary>
    /// FloatProperty: RocketFireTimer
    /// </summary>
    public unsafe float RocketFireTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4624); }
    }

    /// <summary>
    /// FloatProperty: GunShotDeviance
    /// </summary>
    public unsafe float GunShotDeviance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4628); }
    }

    /// <summary>
    /// ObjectProperty: TracerFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem TracerFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4632); }
    }

    /// <summary>
    /// ObjectProperty: ImpactFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ImpactFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4636); }
    }

    /// <summary>
    /// ComponentProperty: MuzzleFlashComponent
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent MuzzleFlashComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4640); }
    }

    /// <summary>
    /// ComponentProperty: DustComponent
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent DustComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4644); }
    }

    /// <summary>
    /// ComponentProperty: FlashingLightComponent
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FlashingLightComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4648); }
    }

    /// <summary>
    /// FloatProperty: DustTraceDistance
    /// </summary>
    public unsafe float DustTraceDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4652); }
    }

    /// <summary>
    /// FloatProperty: ChaingunRepairTimestamp
    /// </summary>
    public unsafe float ChaingunRepairTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4656); }
    }

    /// <summary>
    /// FloatProperty: ChaingunRepairPeriod
    /// </summary>
    public unsafe float ChaingunRepairPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4660); }
    }

    /// <summary>
    /// FloatProperty: JammingImmunityPeriod
    /// </summary>
    public unsafe float JammingImmunityPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4664); }
    }

    /// <summary>
    /// IntProperty: UniqueIndex
    /// </summary>
    public unsafe int UniqueIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4668); }
    }

    /// <summary>
    /// ArrayProperty: OldMaterials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInterface> OldMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInterface>>(Ptr + 4672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4672); }
    }

    /// <summary>
    /// ComponentProperty: PlayerInteractions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent PlayerInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 4684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4684); }
    }

    /// <summary>
    /// ObjectProperty: CurrentControlVolume
    /// </summary>
    public unsafe BmSDK.BmScript.RHelicopterControlVolume CurrentControlVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RHelicopterControlVolume>(Ptr + 4688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4688); }
    }

    /// <summary>
    /// FloatProperty: CannotChangeAttackModeTimer
    /// </summary>
    public unsafe float CannotChangeAttackModeTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4692); }
    }

    /// <summary>
    /// ObjectProperty: ChaingunFiringEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ChaingunFiringEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4696); }
    }

    /// <summary>
    /// ObjectProperty: ChaingunStopFiringEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ChaingunStopFiringEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4700); }
    }

    /// <summary>
    /// FloatProperty: ChainGunDeployPeriod
    /// </summary>
    public unsafe float ChainGunDeployPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4704); }
    }

    /// <summary>
    /// FloatProperty: RocketDeployPeriod
    /// </summary>
    public unsafe float RocketDeployPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4708); }
    }

    /// <summary>
    /// FloatProperty: RocketLockonTime
    /// </summary>
    public unsafe float RocketLockonTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4712); }
    }

    /// <summary>
    /// ObjectProperty: RocketLockonEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RocketLockonEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4716); }
    }

    /// <summary>
    /// ObjectProperty: RocketLockonEventStop
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RocketLockonEventStop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4720); }
    }

    /// <summary>
    /// ObjectProperty: ChaingunSpinUpEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ChaingunSpinUpEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4724); }
    }

    /// <summary>
    /// ObjectProperty: ChaingunSpinDownEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ChaingunSpinDownEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4728); }
    }

    /// <summary>
    /// StructProperty: MoveTowardLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MoveTowardLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4732);

    /// <summary>
    /// StructProperty: MoveTowardPathLocation1
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MoveTowardPathLocation1
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4744);

    /// <summary>
    /// StructProperty: MoveTowardPathLocation2
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MoveTowardPathLocation2
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4756);

    /// <summary>
    /// FloatProperty: MoveTowardSpeed
    /// </summary>
    public unsafe float MoveTowardSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4768); }
    }

    /// <summary>
    /// FloatProperty: MaterialEndIndex
    /// </summary>
    public unsafe float MaterialEndIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4772); }
    }

    /// <summary>
    /// FloatProperty: MaterialExclude
    /// </summary>
    public unsafe float MaterialExclude
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4776); }
    }
}
