#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RHelicopterBase<br/>
/// (size = 4508)
/// (flags = 144704183)
/// </summary>
public partial class RHelicopterBase : BmSDK.BmGame.RBMPawnAI, BmSDK.BmGame.RSpotableInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHelicopterBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RHelicopterBase.
    /// </summary>
    public static RHelicopterBase DefaultObject => (RHelicopterBase)StaticClass().DefaultObject;

    internal RHelicopterBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHelicopterBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHelicopterBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHelicopterBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHelicopterBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHelicopterBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_DoCustomVisCheck;
    /// <summary>
    /// Function: DoCustomVisCheck
    /// </summary>
    public unsafe virtual bool DoCustomVisCheck()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoCustomVisCheck, "BmGame.RHelicopterBase.DoCustomVisCheck");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGlanceScore;
    /// <summary>
    /// Function: GetGlanceScore
    /// </summary>
    public unsafe virtual int GetGlanceScore()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGlanceScore, "BmGame.RHelicopterBase.GetGlanceScore");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ChangeActiveProperty;
    /// <summary>
    /// Function: ChangeActiveProperty
    /// </summary>
    public unsafe virtual void ChangeActiveProperty(BmSDK.BmGame.RHelicopterBase.EChopperBehaviours Prop)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeActiveProperty, "BmGame.RHelicopterBase.ChangeActiveProperty");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Prop, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugGraphics, "BmGame.RHelicopterBase.DrawDebugGraphics");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceLowQualityLight;
    /// <summary>
    /// Function: ForceLowQualityLight
    /// </summary>
    public unsafe virtual void ForceLowQualityLight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceLowQualityLight, "BmGame.RHelicopterBase.ForceLowQualityLight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceHighQualityLight;
    /// <summary>
    /// Function: ForceHighQualityLight
    /// </summary>
    public unsafe virtual void ForceHighQualityLight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceHighQualityLight, "BmGame.RHelicopterBase.ForceHighQualityLight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsTargetatble;
    /// <summary>
    /// Function: IsTargetatble
    /// </summary>
    public unsafe virtual bool IsTargetatble()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTargetatble, "BmGame.RHelicopterBase.IsTargetatble");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FireHelicopterScannedEvent;
    /// <summary>
    /// Function: FireHelicopterScannedEvent
    /// </summary>
    public unsafe virtual void FireHelicopterScannedEvent(BmSDK.BmGame.RPlayerController _RPC, bool IsControlHelicopter)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireHelicopterScannedEvent, "BmGame.RHelicopterBase.FireHelicopterScannedEvent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsControlHelicopter, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGrapplePointEnabled;
    /// <summary>
    /// Function: SetGrapplePointEnabled
    /// </summary>
    public unsafe virtual void SetGrapplePointEnabled(bool make_enabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGrapplePointEnabled, "BmGame.RHelicopterBase.SetGrapplePointEnabled");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(make_enabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetControlChopper;
    /// <summary>
    /// Function: SetControlChopper
    /// </summary>
    public unsafe virtual void SetControlChopper()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetControlChopper, "BmGame.RHelicopterBase.SetControlChopper");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartDownloadHud;
    /// <summary>
    /// Function: StartDownloadHud
    /// </summary>
    public unsafe virtual void StartDownloadHud()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartDownloadHud, "BmGame.RHelicopterBase.StartDownloadHud");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReleaseHelicopterPanel;
    /// <summary>
    /// Function: ReleaseHelicopterPanel
    /// </summary>
    public unsafe virtual void ReleaseHelicopterPanel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseHelicopterPanel, "BmGame.RHelicopterBase.ReleaseHelicopterPanel");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OpenHelicopterPanel;
    /// <summary>
    /// Function: OpenHelicopterPanel
    /// </summary>
    public unsafe virtual void OpenHelicopterPanel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenHelicopterPanel, "BmGame.RHelicopterBase.OpenHelicopterPanel");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetScanned;
    /// <summary>
    /// Function: SetScanned
    /// </summary>
    public unsafe virtual void SetScanned()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetScanned, "BmGame.RHelicopterBase.SetScanned");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetOverrideSpeed;
    /// <summary>
    /// Function: SetOverrideSpeed
    /// </summary>
    public unsafe virtual void SetOverrideSpeed(float _override_speed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOverrideSpeed, "BmGame.RHelicopterBase.SetOverrideSpeed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_override_speed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasBeenScanned;
    /// <summary>
    /// Function: HasBeenScanned
    /// </summary>
    public unsafe virtual bool HasBeenScanned()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasBeenScanned, "BmGame.RHelicopterBase.HasBeenScanned");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_WatchPlayer;
    /// <summary>
    /// Function: WatchPlayer
    /// </summary>
    public unsafe virtual void WatchPlayer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WatchPlayer, "BmGame.RHelicopterBase.WatchPlayer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HitByJammerGadgetCharge;
    /// <summary>
    /// Function: HitByJammerGadgetCharge
    /// </summary>
    public unsafe virtual void HitByJammerGadgetCharge()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitByJammerGadgetCharge, "BmGame.RHelicopterBase.HitByJammerGadgetCharge");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RecoveredFromREC;
    /// <summary>
    /// Function: RecoveredFromREC
    /// </summary>
    public unsafe virtual void RecoveredFromREC()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecoveredFromREC, "BmGame.RHelicopterBase.RecoveredFromREC");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HitByREC;
    /// <summary>
    /// Function: HitByREC
    /// </summary>
    public unsafe virtual void HitByREC(System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 AttackerLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitByREC, "BmGame.RHelicopterBase.HitByREC");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackerLocation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChangePath;
    /// <summary>
    /// Function: ChangePath
    /// </summary>
    public unsafe virtual void ChangePath(BmSDK.BmGame.RPatrolPoint NewStartPoint, bool bTeleport)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangePath, "BmGame.RHelicopterBase.ChangePath");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewStartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTeleport, paramsPtr + 4);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RHelicopterBase.Destroyed");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmGame.RHelicopterBase.PreStreamOut");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RHelicopterBase.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAggressionLevels;
    /// <summary>
    /// Function: SetAggressionLevels
    /// </summary>
    public unsafe virtual void SetAggressionLevels(bool ChaingunEnabled, bool MissilesEnabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAggressionLevels, "BmGame.RHelicopterBase.SetAggressionLevels");
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
    public unsafe virtual void HelicopterDismounted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HelicopterDismounted, "BmGame.RHelicopterBase.HelicopterDismounted");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsAttackEnabled;
    /// <summary>
    /// Function: IsAttackEnabled
    /// </summary>
    public unsafe virtual bool IsAttackEnabled()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAttackEnabled, "BmGame.RHelicopterBase.IsAttackEnabled");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HelicopterBoarded;
    /// <summary>
    /// Function: HelicopterBoarded
    /// </summary>
    public unsafe virtual void HelicopterBoarded()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HelicopterBoarded, "BmGame.RHelicopterBase.HelicopterBoarded");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBeJammed;
    /// <summary>
    /// Function: CanBeJammed
    /// </summary>
    public unsafe virtual bool CanBeJammed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeJammed, "BmGame.RHelicopterBase.CanBeJammed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StartPullMove;
    /// <summary>
    /// Function: StartPullMove
    /// </summary>
    public unsafe virtual void StartPullMove(BmSDK.BmGame.RPlayerController Player)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartPullMove, "BmGame.RHelicopterBase.StartPullMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHarpoonTargetLocation;
    /// <summary>
    /// Function: GetHarpoonTargetLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetHarpoonTargetLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHarpoonTargetLocation, "BmGame.RHelicopterBase.GetHarpoonTargetLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsHarpoonable;
    /// <summary>
    /// Function: IsHarpoonable
    /// </summary>
    public unsafe virtual bool IsHarpoonable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsHarpoonable, "BmGame.RHelicopterBase.IsHarpoonable");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDifficultyParameters;
    /// <summary>
    /// Function: GetDifficultyParameters
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHelicopterBase.FHelicopterDifficultyParameters GetDifficultyParameters(int DifficultyLevel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDifficultyParameters, "BmGame.RHelicopterBase.GetDifficultyParameters");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DifficultyLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHelicopterBase.FHelicopterDifficultyParameters>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UpdateSearchLight;
    /// <summary>
    /// Function: UpdateSearchLight
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHelicopterBase.SearchLightState UpdateSearchLight(float DeltaTime, bool LookSweep = default, System.Numerics.Vector3 LookAtLocation = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateSearchLight, "BmGame.RHelicopterBase.UpdateSearchLight");
        byte* paramsPtr = stackalloc byte[129];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookSweep, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookAtLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHelicopterBase.SearchLightState>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_IsBatmanVisible;
    /// <summary>
    /// Function: IsBatmanVisible
    /// </summary>
    public unsafe virtual bool IsBatmanVisible()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBatmanVisible, "BmGame.RHelicopterBase.IsBatmanVisible");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsBMInLineOfSight;
    /// <summary>
    /// Function: IsBMInLineOfSight
    /// </summary>
    public unsafe virtual bool IsBMInLineOfSight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBMInLineOfSight, "BmGame.RHelicopterBase.IsBMInLineOfSight");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsBMInSearchLight;
    /// <summary>
    /// Function: IsBMInSearchLight
    /// </summary>
    public unsafe virtual bool IsBMInSearchLight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBMInSearchLight, "BmGame.RHelicopterBase.IsBMInSearchLight");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetLightColour;
    /// <summary>
    /// Function: SetLightColour
    /// </summary>
    public unsafe virtual void SetLightColour(BmSDK.BmGame.RHelicopterBase.ELightColour Colour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLightColour, "BmGame.RHelicopterBase.SetLightColour");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Colour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPlayerInvisible;
    /// <summary>
    /// Function: IsPlayerInvisible
    /// </summary>
    public unsafe virtual bool IsPlayerInvisible()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPlayerInvisible, "BmGame.RHelicopterBase.IsPlayerInvisible");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetFlightControlEnabled;
    /// <summary>
    /// Function: SetFlightControlEnabled
    /// </summary>
    public unsafe virtual void SetFlightControlEnabled(bool is_enabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFlightControlEnabled, "BmGame.RHelicopterBase.SetFlightControlEnabled");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_enabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerSighted;
    /// <summary>
    /// Function: PlayerSighted
    /// </summary>
    public unsafe virtual void PlayerSighted(BmSDK.BmGame.RHelicopterBase.FDroneToHelicopterMessage msg)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerSighted, "BmGame.RHelicopterBase.PlayerSighted");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(msg, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindBestNavigationPoint;
    /// <summary>
    /// Function: FindBestNavigationPoint
    /// </summary>
    public unsafe virtual BmSDK.Engine.NavigationPoint FindBestNavigationPoint(out System.Numerics.Vector3 Loc, float SearchRadius, float MinDistance, bool FindPointAbove = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindBestNavigationPoint, "BmGame.RHelicopterBase.FindBestNavigationPoint");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchRadius, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinDistance, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FindPointAbove, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.NavigationPoint>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_TickWindGust;
    /// <summary>
    /// Function: TickWindGust
    /// </summary>
    public unsafe virtual void TickWindGust(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickWindGust, "BmGame.RHelicopterBase.TickWindGust");
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

    private static BmSDK.Function __fn_RandomWindGust;
    /// <summary>
    /// Function: RandomWindGust
    /// </summary>
    public unsafe virtual void RandomWindGust()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RandomWindGust, "BmGame.RHelicopterBase.RandomWindGust");
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

    private static BmSDK.Function __fn_FlightControlAdjustVirtualLocation;
    /// <summary>
    /// Function: FlightControlAdjustVirtualLocation
    /// </summary>
    public unsafe virtual void FlightControlAdjustVirtualLocation(float TargetZ, float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlightControlAdjustVirtualLocation, "BmGame.RHelicopterBase.FlightControlAdjustVirtualLocation");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetZ, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 4);
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

    private static BmSDK.Function __fn_AdvanceTowardsVirtualLocation;
    /// <summary>
    /// Function: AdvanceTowardsVirtualLocation
    /// </summary>
    public unsafe virtual void AdvanceTowardsVirtualLocation(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdvanceTowardsVirtualLocation, "BmGame.RHelicopterBase.AdvanceTowardsVirtualLocation");
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

    private static BmSDK.Function __fn_SetVirtualLocationWithConstraints;
    /// <summary>
    /// Function: SetVirtualLocationWithConstraints
    /// </summary>
    public unsafe virtual bool SetVirtualLocationWithConstraints(System.Numerics.Vector3 NewVirtualLocation, float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVirtualLocationWithConstraints, "BmGame.RHelicopterBase.SetVirtualLocationWithConstraints");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewVirtualLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 12);
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

    private static BmSDK.Function __fn_SetVirtualLocation;
    /// <summary>
    /// Function: SetVirtualLocation
    /// </summary>
    public unsafe virtual void SetVirtualLocation(System.Numerics.Vector3 NewVirtualLocation, float DeltaTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVirtualLocation, "BmGame.RHelicopterBase.SetVirtualLocation");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewVirtualLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 12);
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

    private static BmSDK.Function __fn_UpdateRotation;
    /// <summary>
    /// Function: UpdateRotation
    /// </summary>
    public unsafe virtual void UpdateRotation(System.Numerics.Vector3 TargetLocation, float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateRotation, "BmGame.RHelicopterBase.UpdateRotation");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 12);
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

    private static BmSDK.Function __fn_MoveTowardPath;
    /// <summary>
    /// Function: MoveTowardPath
    /// </summary>
    public unsafe virtual bool MoveTowardPath(System.Numerics.Vector3 TargetLocation, System.Numerics.Vector3 NextTargetLocation, float DeltaTime, float MaxVelocity)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveTowardPath, "BmGame.RHelicopterBase.MoveTowardPath");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextTargetLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxVelocity, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_MoveToward;
    /// <summary>
    /// Function: MoveToward
    /// </summary>
    public unsafe virtual bool MoveToward(System.Numerics.Vector3 TargetLocation, float DeltaTime, float MaxVelocity, bool SlowdownOnApproach = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveToward, "BmGame.RHelicopterBase.MoveToward");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxVelocity, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlowdownOnApproach, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_FindPathToLocation;
    /// <summary>
    /// Function: FindPathToLocation
    /// </summary>
    public unsafe virtual bool FindPathToLocation(System.Numerics.Vector3 StartingLocation, System.Numerics.Vector3 TargetLocation, bool FindPointAbove = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPathToLocation, "BmGame.RHelicopterBase.FindPathToLocation");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartingLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FindPointAbove, paramsPtr + 24);
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

    private static BmSDK.Function __fn_MoveNoCollision;
    /// <summary>
    /// Function: MoveNoCollision
    /// </summary>
    public unsafe virtual bool MoveNoCollision(System.Numerics.Vector3 Delta)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveNoCollision, "BmGame.RHelicopterBase.MoveNoCollision");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delta, paramsPtr + 0);
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

    private static BmSDK.Function __fn_TestLineOfSight;
    /// <summary>
    /// Function: TestLineOfSight
    /// </summary>
    public unsafe virtual bool TestLineOfSight(System.Numerics.Vector3 SourcePosition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestLineOfSight, "BmGame.RHelicopterBase.TestLineOfSight");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SourcePosition, paramsPtr + 0);
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

    private static BmSDK.Function __fn_TestSearchLight;
    /// <summary>
    /// Function: TestSearchLight
    /// </summary>
    public unsafe virtual bool TestSearchLight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestSearchLight, "BmGame.RHelicopterBase.TestSearchLight");
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

    private static BmSDK.Function __fn_UpdateVisibility;
    /// <summary>
    /// Function: UpdateVisibility
    /// </summary>
    public unsafe virtual void UpdateVisibility(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateVisibility, "BmGame.RHelicopterBase.UpdateVisibility");
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

    private static BmSDK.Function __fn_TickNative;
    /// <summary>
    /// Function: TickNative
    /// </summary>
    public unsafe virtual void TickNative(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickNative, "BmGame.RHelicopterBase.TickNative");
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

    /// <summary>
    /// Struct: FDroneToHelicopterMessage
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FDroneToHelicopterMessage
    {
        /// <summary>
        /// ByteProperty: EPlayerState
        /// </summary>
        public unsafe BmSDK.BmGame.RHelicopterBase.EPlayerState EPlayerState
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHelicopterBase.EPlayerState>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: PlayerPosition
        /// </summary>
        public unsafe System.Numerics.Vector3 PlayerPosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Enum: EPlayerState
    /// </summary>
    public enum EPlayerState : byte
    {
        EP_PlayerSeen = 0,
        EP_InSight = 1,
        EP_PlayerMovesOutOfSight = 2,
        EP_PlayerNotInSight = 3,
        EP_MAX = 4,
    }

    /// <summary>
    /// Enum: ELightColour
    /// </summary>
    public enum ELightColour : byte
    {
        ELC_White = 0,
        ELC_Red = 1,
        ELC_Yellow = 2,
        ELC_Green = 3,
        ELC_Invalid = 4,
        ELC_MAX = 5,
    }

    /// <summary>
    /// Struct: FHelicopterDifficultyParameters
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FHelicopterDifficultyParameters
    {
        /// <summary>
        /// FloatProperty: ChaingunDamage
        /// </summary>
        public unsafe float ChaingunDamage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: RocketDamage
        /// </summary>
        public unsafe float RocketDamage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FChopperProperties
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 200)]
    public partial record struct FChopperProperties
    {
        /// <summary>
        /// StructProperty: HelicopterMovementProperties
        /// </summary>
        public unsafe BmSDK.BmGame.RHelicopterBase.FHelicopterMovement HelicopterMovementProperties
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHelicopterBase.FHelicopterMovement>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: HelicopterSearchLightProperties
        /// </summary>
        public unsafe BmSDK.BmGame.RHelicopterBase.FHelicopterSearchLight HelicopterSearchLightProperties
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHelicopterBase.FHelicopterSearchLight>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// StructProperty: HelicopterInteractionProperties
        /// </summary>
        public unsafe BmSDK.BmGame.RHelicopterBase.FHelicopterInteraction HelicopterInteractionProperties
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHelicopterBase.FHelicopterInteraction>(Ptr + 152); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }; }
        }

        /// <summary>
        /// StructProperty: HelicopterPathScoringProperties
        /// </summary>
        public unsafe BmSDK.BmGame.RHelicopterBase.FHelicopterPathScoring HelicopterPathScoringProperties
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHelicopterBase.FHelicopterPathScoring>(Ptr + 176); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }; }
        }

        /// <summary>
        /// BoolProperty: bBlocksRECHits
        /// </summary>
        public unsafe bool bBlocksRECHits
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 196); }; }
        }

        /// <summary>
        /// BoolProperty: bIgnoreGadgets
        /// </summary>
        public unsafe bool bIgnoreGadgets
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 196); }; }
        }
    }

    /// <summary>
    /// Struct: FHelicopterPathScoring
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FHelicopterPathScoring
    {
        /// <summary>
        /// IntProperty: RadiusForPathNodes
        /// </summary>
        public unsafe int RadiusForPathNodes
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: MinimumDistanceFromPlayer
        /// </summary>
        public unsafe int MinimumDistanceFromPlayer
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: FacingForward
        /// </summary>
        public unsafe float FacingForward
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: DistScoreMultiplier
        /// </summary>
        public unsafe float DistScoreMultiplier
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: FacingForwardAngle
        /// </summary>
        public unsafe float FacingForwardAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FHelicopterInteraction
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FHelicopterInteraction
    {
        /// <summary>
        /// BoolProperty: HoldPositionOverBatman
        /// </summary>
        public unsafe bool HoldPositionOverBatman
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: HoldPositionDistance
        /// </summary>
        public unsafe float HoldPositionDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: HoldPositionDistanceBeginElevation
        /// </summary>
        public unsafe float HoldPositionDistanceBeginElevation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: HoldPositionElevation
        /// </summary>
        public unsafe float HoldPositionElevation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: RecImpactImmunityPeriod
        /// </summary>
        public unsafe float RecImpactImmunityPeriod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: RecImpactDisorientPeriod
        /// </summary>
        public unsafe float RecImpactDisorientPeriod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FHelicopterSearchLight
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial record struct FHelicopterSearchLight
    {
        /// <summary>
        /// FloatProperty: searchLightDetectionRadius
        /// </summary>
        public unsafe float searchLightDetectionRadius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: searchLightRadius
        /// </summary>
        public unsafe float searchLightRadius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: trackingLightRadius
        /// </summary>
        public unsafe float trackingLightRadius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: searchLightRangeCM
        /// </summary>
        public unsafe float searchLightRangeCM
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: searchSweepPeriod
        /// </summary>
        public unsafe float searchSweepPeriod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: searchSweepDegrees
        /// </summary>
        public unsafe float searchSweepDegrees
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: VisionRangeExtended
        /// </summary>
        public unsafe float VisionRangeExtended
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: searchLightTrackingRate_Idle
        /// </summary>
        public unsafe float searchLightTrackingRate_Idle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: searchLightTrackingRate_Alert
        /// </summary>
        public unsafe float searchLightTrackingRate_Alert
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: searchLightCanGiveUp
        /// </summary>
        public unsafe bool searchLightCanGiveUp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: canFindBatmanAnywhere
        /// </summary>
        public unsafe bool canFindBatmanAnywhere
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: searchLightGiveUpTime
        /// </summary>
        public unsafe float searchLightGiveUpTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// ComponentProperty: SpotLightComponent
        /// </summary>
        public unsafe BmSDK.Engine.SpotLightComponent SpotLightComponent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SpotLightComponent>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// ComponentProperty: SearchLightMesh
        /// </summary>
        public unsafe BmSDK.Engine.StaticMeshComponent SearchLightMesh
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// ComponentProperty: LensFlareFX
        /// </summary>
        public unsafe BmSDK.Engine.LensFlareComponent LensFlareFX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LensFlareComponent>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// StructProperty: lightTargetOrientation
        /// </summary>
        public unsafe BmSDK.Rotator lightTargetOrientation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// FloatProperty: MaxTolForOrintationEquality
        /// </summary>
        public unsafe float MaxTolForOrintationEquality
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }
    }

    /// <summary>
    /// Struct: FHelicopterMovement
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial record struct FHelicopterMovement
    {
        /// <summary>
        /// BoolProperty: bForcePursuitSpeed
        /// </summary>
        public unsafe bool bForcePursuitSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: RubberBandingPeriod
        /// </summary>
        public unsafe float RubberBandingPeriod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: RubberBandingMaxAcceleration
        /// </summary>
        public unsafe float RubberBandingMaxAcceleration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: RubberBandingJerkPeriod
        /// </summary>
        public unsafe float RubberBandingJerkPeriod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: MaximumPitchForwardDegrees
        /// </summary>
        public unsafe float MaximumPitchForwardDegrees
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: MaximumBankSidewaysDegrees
        /// </summary>
        public unsafe float MaximumBankSidewaysDegrees
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: MaximumBankFromTurnDegrees
        /// </summary>
        public unsafe float MaximumBankFromTurnDegrees
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: RotationalVelocityMaxDegrees
        /// </summary>
        public unsafe float RotationalVelocityMaxDegrees
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: RotationalAccelerationDegrees
        /// </summary>
        public unsafe float RotationalAccelerationDegrees
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: GustStrengthBase
        /// </summary>
        public unsafe float GustStrengthBase
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: GustStrengthRange
        /// </summary>
        public unsafe float GustStrengthRange
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// FloatProperty: GustDurationMin
        /// </summary>
        public unsafe float GustDurationMin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// FloatProperty: GustDurationRange
        /// </summary>
        public unsafe float GustDurationRange
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: GustCalmPeriod
        /// </summary>
        public unsafe float GustCalmPeriod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// FloatProperty: BobUpAndDownVelocity
        /// </summary>
        public unsafe float BobUpAndDownVelocity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// FloatProperty: LinearAcceleration
        /// </summary>
        public unsafe float LinearAcceleration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// FloatProperty: TurningSpeed
        /// </summary>
        public unsafe float TurningSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// FloatProperty: maxPatrolVelocity
        /// </summary>
        public unsafe float maxPatrolVelocity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// FloatProperty: maxChaseVelocity
        /// </summary>
        public unsafe float maxChaseVelocity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// BoolProperty: bWalkBackwards
        /// </summary>
        public unsafe bool bWalkBackwards
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }; }
        }

        /// <summary>
        /// BoolProperty: bPingPong
        /// </summary>
        public unsafe bool bPingPong
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }; }
        }

        /// <summary>
        /// BoolProperty: bHoldPositionUntilBoarded
        /// </summary>
        public unsafe bool bHoldPositionUntilBoarded
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }; }
        }
    }

    /// <summary>
    /// Enum: SearchLightState
    /// </summary>
    public enum SearchLightState : byte
    {
        SLS_SweepingTowardsTarget = 0,
        SLS_TargetReached = 1,
        SLS_MAX = 2,
    }

    /// <summary>
    /// Enum: EChopperBehaviours
    /// </summary>
    public enum EChopperBehaviours : byte
    {
        ECB_Normal = 0,
        ECB_Chase = 1,
        ECB_Ambush = 2,
        ECB_Drone = 3,
        ECB_MAX = 4,
    }

    /// <summary>
    /// StructProperty: VfTable_IRSpotableInterface
    /// </summary>
    public unsafe System.IntPtr VfTable_IRSpotableInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 3320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3320); }
    }

    /// <summary>
    /// ArrayProperty: RouteCache
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.NavigationPoint> RouteCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.NavigationPoint>>(Ptr + 3324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3324); }
    }

    /// <summary>
    /// FloatProperty: RouteLifeTime
    /// </summary>
    public unsafe float RouteLifeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3336); }
    }

    /// <summary>
    /// BoolProperty: bHasBegunTurning
    /// </summary>
    public unsafe bool bHasBegunTurning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3340); }
    }

    /// <summary>
    /// BoolProperty: LimitVisionSightToSpotLight
    /// </summary>
    public unsafe bool LimitVisionSightToSpotLight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3340); }
    }

    /// <summary>
    /// BoolProperty: bSearchLightGivenUp
    /// </summary>
    public unsafe bool bSearchLightGivenUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3340); }
    }

    /// <summary>
    /// BoolProperty: bIsControlHelicopter
    /// </summary>
    public unsafe bool bIsControlHelicopter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3340); }
    }

    /// <summary>
    /// BoolProperty: bInLowDetail
    /// </summary>
    public unsafe bool bInLowDetail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3340); }
    }

    /// <summary>
    /// BoolProperty: bHasVisualContact
    /// </summary>
    public unsafe bool bHasVisualContact
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3340); }
    }

    /// <summary>
    /// BoolProperty: bLineOfSightToBatman
    /// </summary>
    public unsafe bool bLineOfSightToBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3340); }
    }

    /// <summary>
    /// BoolProperty: bBatmanInSearchLight
    /// </summary>
    public unsafe bool bBatmanInSearchLight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3340); }
    }

    /// <summary>
    /// BoolProperty: bActivelyAvoidBatman
    /// </summary>
    public unsafe bool bActivelyAvoidBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3340); }
    }

    /// <summary>
    /// BoolProperty: bBatmanOnBoard
    /// </summary>
    public unsafe bool bBatmanOnBoard
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3340); }
    }

    /// <summary>
    /// BoolProperty: bSubjectToFlightControl
    /// </summary>
    public unsafe bool bSubjectToFlightControl
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3340); }
    }

    /// <summary>
    /// BoolProperty: playerCanBeSeenByHelicopter
    /// </summary>
    public unsafe bool playerCanBeSeenByHelicopter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3340); }
    }

    /// <summary>
    /// BoolProperty: bAlertedToBatmansPosition
    /// </summary>
    public unsafe bool bAlertedToBatmansPosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3340); }
    }

    /// <summary>
    /// BoolProperty: HasLostSightOfBatman
    /// </summary>
    public unsafe bool HasLostSightOfBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3340); }
    }

    /// <summary>
    /// BoolProperty: bIsAggro
    /// </summary>
    public unsafe bool bIsAggro
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3340); }
    }

    /// <summary>
    /// BoolProperty: new_lineofsight
    /// </summary>
    public unsafe bool new_lineofsight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3340); }
    }

    /// <summary>
    /// BoolProperty: bForceAttack
    /// </summary>
    public unsafe bool bForceAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3340); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3340); }
    }

    /// <summary>
    /// FloatProperty: LinearVelocity
    /// </summary>
    public unsafe float LinearVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3344); }
    }

    /// <summary>
    /// FloatProperty: SlowDownDistance
    /// </summary>
    public unsafe float SlowDownDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3348); }
    }

    /// <summary>
    /// FloatProperty: TurningDistance
    /// </summary>
    public unsafe float TurningDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3352); }
    }

    /// <summary>
    /// FloatProperty: TurningDistanceRemaining
    /// </summary>
    public unsafe float TurningDistanceRemaining
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3356); }
    }

    /// <summary>
    /// StructProperty: PrevPointLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PrevPointLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3360);

    /// <summary>
    /// StructProperty: ActualVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ActualVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3372);

    /// <summary>
    /// StructProperty: ActualAcceleration
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ActualAcceleration
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3384);

    /// <summary>
    /// FloatProperty: ActualRotationalVelocity
    /// </summary>
    public unsafe float ActualRotationalVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3396); }
    }

    /// <summary>
    /// StructProperty: VirtualLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 VirtualLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3400);

    /// <summary>
    /// StructProperty: VirtualRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator VirtualRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 3412);

    /// <summary>
    /// ObjectProperty: LookAtTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor LookAtTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 3424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3424); }
    }

    /// <summary>
    /// ObjectProperty: HitByRECFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem HitByRECFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3428); }
    }

    /// <summary>
    /// ObjectProperty: HelicopterHangPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHelicopterHangPointBase HelicopterHangPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHelicopterHangPointBase>(Ptr + 3432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3432); }
    }

    /// <summary>
    /// ByteProperty: ActiveChopperPropertyIndex
    /// </summary>
    public unsafe BmSDK.BmGame.RHelicopterBase.EChopperBehaviours ActiveChopperPropertyIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHelicopterBase.EChopperBehaviours>(Ptr + 3436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3436); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: ChopperProps
    /// </summary>
    public InlineArray<BmSDK.BmGame.RHelicopterBase.FChopperProperties> ChopperProps => new(4, Ptr + 3440, 200, this);

    /// <summary>
    /// StructProperty: ChopperProps
    /// </summary>
    public unsafe ref BmSDK.BmGame.RHelicopterBase.FChopperProperties ChopperProps_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RHelicopterBase.FChopperProperties>(Ptr + 3440);
    /// <summary>
    /// StructProperty: ChopperProps
    /// </summary>
    public unsafe ref BmSDK.BmGame.RHelicopterBase.FChopperProperties ChopperProps_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RHelicopterBase.FChopperProperties>(Ptr + 3640);
    /// <summary>
    /// StructProperty: ChopperProps
    /// </summary>
    public unsafe ref BmSDK.BmGame.RHelicopterBase.FChopperProperties ChopperProps_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RHelicopterBase.FChopperProperties>(Ptr + 3840);
    /// <summary>
    /// StructProperty: ChopperProps
    /// </summary>
    public unsafe ref BmSDK.BmGame.RHelicopterBase.FChopperProperties ChopperProps_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RHelicopterBase.FChopperProperties>(Ptr + 4040);

    /// <summary>
    /// StructProperty: GustNormalStart
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GustNormalStart
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4240);

    /// <summary>
    /// StructProperty: GustNormalFinish
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GustNormalFinish
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4252);

    /// <summary>
    /// FloatProperty: GustMagnitude
    /// </summary>
    public unsafe float GustMagnitude
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4264); }
    }

    /// <summary>
    /// FloatProperty: GustTimer
    /// </summary>
    public unsafe float GustTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4268); }
    }

    /// <summary>
    /// FloatProperty: GustDuration
    /// </summary>
    public unsafe float GustDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4272); }
    }

    /// <summary>
    /// FloatProperty: GustCalmPeriodDuration
    /// </summary>
    public unsafe float GustCalmPeriodDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4276); }
    }

    /// <summary>
    /// StructProperty: CurrentGustVector
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentGustVector
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4280);

    /// <summary>
    /// FloatProperty: RotationBankingMagnitude
    /// </summary>
    public unsafe float RotationBankingMagnitude
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4292); }
    }

    /// <summary>
    /// FloatProperty: WobbleTime
    /// </summary>
    public unsafe float WobbleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4296); }
    }

    /// <summary>
    /// FloatProperty: RecImpactTimestamp
    /// </summary>
    public unsafe float RecImpactTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4300); }
    }

    /// <summary>
    /// StructProperty: WobbleVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WobbleVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4304);

    /// <summary>
    /// FloatProperty: fControlVolumeTimer
    /// </summary>
    public unsafe float fControlVolumeTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4316); }
    }

    /// <summary>
    /// FloatProperty: fControlWindDampingFactor
    /// </summary>
    public unsafe float fControlWindDampingFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4320); }
    }

    /// <summary>
    /// FloatProperty: fControlWindDampingInitial
    /// </summary>
    public unsafe float fControlWindDampingInitial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4324); }
    }

    /// <summary>
    /// FloatProperty: fControlWindDampingFinal
    /// </summary>
    public unsafe float fControlWindDampingFinal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4328); }
    }

    /// <summary>
    /// FloatProperty: fControlRubberBandingFactor
    /// </summary>
    public unsafe float fControlRubberBandingFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4332); }
    }

    /// <summary>
    /// FloatProperty: fControlRubberBandingInitial
    /// </summary>
    public unsafe float fControlRubberBandingInitial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4336); }
    }

    /// <summary>
    /// FloatProperty: fControlRubberBandingFinal
    /// </summary>
    public unsafe float fControlRubberBandingFinal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4340); }
    }

    /// <summary>
    /// FloatProperty: fControlOverrideSpeed
    /// </summary>
    public unsafe float fControlOverrideSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4344); }
    }

    /// <summary>
    /// FloatProperty: CurrentMaxSpeed
    /// </summary>
    public unsafe float CurrentMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4348); }
    }

    /// <summary>
    /// StructProperty: LightFloorPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LightFloorPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4352);

    /// <summary>
    /// StructProperty: lightPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 lightPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4364);

    /// <summary>
    /// ObjectProperty: PlayerPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer PlayerPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 4376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4376); }
    }

    /// <summary>
    /// StructProperty: lightOrientation
    /// </summary>
    public unsafe ref BmSDK.Rotator lightOrientation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 4380);

    /// <summary>
    /// ArrayProperty: HelicopterDifficultyLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHelicopterBase.FHelicopterDifficultyParameters> HelicopterDifficultyLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHelicopterBase.FHelicopterDifficultyParameters>>(Ptr + 4392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4392); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceVisualContactLost
    /// </summary>
    public unsafe float TimeSinceVisualContactLost
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4404); }
    }

    /// <summary>
    /// IntProperty: framesBetweenDustFXUpdates_Active
    /// </summary>
    public unsafe int framesBetweenDustFXUpdates_Active
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4408); }
    }

    /// <summary>
    /// IntProperty: framesBetweenDustFXUpdates_Inactive
    /// </summary>
    public unsafe int framesBetweenDustFXUpdates_Inactive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4412); }
    }

    /// <summary>
    /// IntProperty: framesBetweenSearchLightTraces
    /// </summary>
    public unsafe int framesBetweenSearchLightTraces
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4416); }
    }

    /// <summary>
    /// IntProperty: framesBetweenCrowScares
    /// </summary>
    public unsafe int framesBetweenCrowScares
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4420); }
    }

    /// <summary>
    /// IntProperty: framesBetweenWindGustUpdates
    /// </summary>
    public unsafe int framesBetweenWindGustUpdates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4424); }
    }

    /// <summary>
    /// IntProperty: framesTillDustFXUpdate
    /// </summary>
    public unsafe int framesTillDustFXUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4428); }
    }

    /// <summary>
    /// IntProperty: framesTillSearchLightTrace
    /// </summary>
    public unsafe int framesTillSearchLightTrace
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4432); }
    }

    /// <summary>
    /// IntProperty: framesTillCrowScare
    /// </summary>
    public unsafe int framesTillCrowScare
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4436); }
    }

    /// <summary>
    /// IntProperty: framesTillWindGustUpdate
    /// </summary>
    public unsafe int framesTillWindGustUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4440); }
    }

    /// <summary>
    /// FloatProperty: windGustDeltaTime
    /// </summary>
    public unsafe float windGustDeltaTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4444); }
    }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 4448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4448); }
    }

    /// <summary>
    /// StructProperty: BMLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BMLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4452);

    /// <summary>
    /// FloatProperty: LastSpottedTime
    /// </summary>
    public unsafe float LastSpottedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4464); }
    }

    /// <summary>
    /// ComponentProperty: PlayerBlocker
    /// </summary>
    public unsafe BmSDK.Engine.CylinderComponent PlayerBlocker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CylinderComponent>(Ptr + 4468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4468); }
    }

    /// <summary>
    /// ObjectProperty: SearchLightMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant SearchLightMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4472); }
    }

    /// <summary>
    /// StructProperty: BestAttactLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BestAttactLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4476);

    /// <summary>
    /// StructProperty: SearchLightMeshScale3D
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SearchLightMeshScale3D
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4488);

    /// <summary>
    /// ObjectProperty: LightBoneController
    /// </summary>
    public unsafe BmSDK.Engine.SkelControlSingleBone LightBoneController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkelControlSingleBone>(Ptr + 4500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4500); }
    }

    /// <summary>
    /// ObjectProperty: GunBoneController
    /// </summary>
    public unsafe BmSDK.Engine.SkelControlSingleBone GunBoneController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkelControlSingleBone>(Ptr + 4504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4504); }
    }
}
