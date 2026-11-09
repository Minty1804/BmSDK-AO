#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: MDualClawClusterProjectile<br/>
/// (size = 984)
/// (flags = 8388627)
/// </summary>
public partial class MDualClawClusterProjectile : BmSDK.BmGame.RProjectile, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MDualClawClusterProjectile", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MDualClawClusterProjectile.
    /// </summary>
    public static MDualClawClusterProjectile DefaultObject => (MDualClawClusterProjectile)StaticClass().DefaultObject;

    internal MDualClawClusterProjectile() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MDualClawClusterProjectile(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MDualClawClusterProjectile>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MDualClawClusterProjectile>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MDualClawClusterProjectile>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MDualClawClusterProjectile>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MDualClawClusterProjectile>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MDualClawClusterProjectile>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MDualClawClusterProjectile>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MDualClawClusterProjectile>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetTimeBeforeFireRopeHook;
    /// <summary>
    /// Function: GetTimeBeforeFireRopeHook
    /// </summary>
    public unsafe virtual float GetTimeBeforeFireRopeHook()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTimeBeforeFireRopeHook, "BmGame.MDualClawClusterProjectile.GetTimeBeforeFireRopeHook");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRopeHookFiringLocation;
    /// <summary>
    /// Function: GetRopeHookFiringLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetRopeHookFiringLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRopeHookFiringLocation, "BmGame.MDualClawClusterProjectile.GetRopeHookFiringLocation");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DestroyThrownObject;
    /// <summary>
    /// Function: DestroyThrownObject
    /// </summary>
    public unsafe virtual void DestroyThrownObject()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyThrownObject, "BmGame.MDualClawClusterProjectile.DestroyThrownObject");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayHangingGuyBark;
    /// <summary>
    /// Function: PlayHangingGuyBark
    /// </summary>
    public unsafe virtual void PlayHangingGuyBark()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHangingGuyBark, "BmGame.MDualClawClusterProjectile.PlayHangingGuyBark");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceAbortRopePull;
    /// <summary>
    /// Function: ForceAbortRopePull
    /// </summary>
    public unsafe virtual void ForceAbortRopePull()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceAbortRopePull, "BmGame.MDualClawClusterProjectile.ForceAbortRopePull");
        byte* paramsPtr = stackalloc byte[272];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndRemoteClawed;
    /// <summary>
    /// Function: EndRemoteClawed
    /// </summary>
    public unsafe virtual void EndRemoteClawed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndRemoteClawed, "BmGame.MDualClawClusterProjectile.EndRemoteClawed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HitWall;
    /// <summary>
    /// Function: HitWall
    /// </summary>
    public unsafe override void HitWall(System.Numerics.Vector3 HitNormal, BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent WallComp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitWall, "BmGame.MDualClawClusterProjectile.HitWall");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallComp, paramsPtr + 16);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Touch, "BmGame.MDualClawClusterProjectile.Touch");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateRopeSpawnable;
    /// <summary>
    /// Function: CreateRopeSpawnable
    /// </summary>
    public unsafe virtual void CreateRopeSpawnable(bool IsRopeBatarangable = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateRopeSpawnable, "BmGame.MDualClawClusterProjectile.CreateRopeSpawnable");
        byte* paramsPtr = stackalloc byte[164];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsRopeBatarangable, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsRopeCompletelyRetracted;
    /// <summary>
    /// Function: IsRopeCompletelyRetracted
    /// </summary>
    public unsafe virtual bool IsRopeCompletelyRetracted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRopeCompletelyRetracted, "BmGame.MDualClawClusterProjectile.IsRopeCompletelyRetracted");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DetachDualClawCluster;
    /// <summary>
    /// Function: DetachDualClawCluster
    /// </summary>
    public unsafe virtual void DetachDualClawCluster()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetachDualClawCluster, "BmGame.MDualClawClusterProjectile.DetachDualClawCluster");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwitchTrackingCameraToRopeHook;
    /// <summary>
    /// Function: SwitchTrackingCameraToRopeHook
    /// </summary>
    public unsafe virtual void SwitchTrackingCameraToRopeHook()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchTrackingCameraToRopeHook, "BmGame.MDualClawClusterProjectile.SwitchTrackingCameraToRopeHook");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnHitParticles;
    /// <summary>
    /// Function: SpawnHitParticles
    /// </summary>
    public unsafe virtual void SpawnHitParticles(System.Numerics.Vector3 Origin, System.Numerics.Vector3 ImpactLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnHitParticles, "BmGame.MDualClawClusterProjectile.SpawnHitParticles");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Origin, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactLoc, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHitVillainHitReaction;
    /// <summary>
    /// Function: GetHitVillainHitReaction
    /// </summary>
    public unsafe virtual void GetHitVillainHitReaction(BmSDK.Engine.AnimSet HitReactionAnimSet, BmSDK.TArray<BmSDK.FName> ReactionAnims, out BmSDK.FName HitReaction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHitVillainHitReaction, "BmGame.MDualClawClusterProjectile.GetHitVillainHitReaction");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitReactionAnimSet, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReactionAnims, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitReaction);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitReaction, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        HitReaction = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_DoRopePullDamageOnPawn;
    /// <summary>
    /// Function: DoRopePullDamageOnPawn
    /// </summary>
    public unsafe virtual void DoRopePullDamageOnPawn(BmSDK.BmGame.RPawnVillain Victim)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoRopePullDamageOnPawn, "BmGame.MDualClawClusterProjectile.DoRopePullDamageOnPawn");
        byte* paramsPtr = stackalloc byte[276];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoDualClawDamageOnDrone;
    /// <summary>
    /// Function: DoDualClawDamageOnDrone
    /// </summary>
    public unsafe virtual void DoDualClawDamageOnDrone(BmSDK.BmGame.MPawnDroneBase Target, System.Numerics.Vector3 Origin)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoDualClawDamageOnDrone, "BmGame.MDualClawClusterProjectile.DoDualClawDamageOnDrone");
        byte* paramsPtr = stackalloc byte[288];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Origin, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayThugToThugBumpSound;
    /// <summary>
    /// Function: PlayThugToThugBumpSound
    /// </summary>
    public unsafe virtual void PlayThugToThugBumpSound(BmSDK.BmGame.RPawnVillain Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayThugToThugBumpSound, "BmGame.MDualClawClusterProjectile.PlayThugToThugBumpSound");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoDualClawPawnToPawn;
    /// <summary>
    /// Function: DoDualClawPawnToPawn
    /// </summary>
    public unsafe virtual void DoDualClawPawnToPawn(BmSDK.BmGame.RPawnVillain Target, BmSDK.BmGame.RPawnVillain OtherPawn, System.Numerics.Vector3 impulseOnPawn = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoDualClawPawnToPawn, "BmGame.MDualClawClusterProjectile.DoDualClawPawnToPawn");
        byte* paramsPtr = stackalloc byte[300];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherPawn, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(impulseOnPawn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoDualClawDamageOnPawn;
    /// <summary>
    /// Function: DoDualClawDamageOnPawn
    /// </summary>
    public unsafe virtual void DoDualClawDamageOnPawn(BmSDK.BmGame.RPawnVillain Target, BmSDK.BmGame.RPawnVillain OtherPawn, System.Numerics.Vector3 impulseOnPawn = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoDualClawDamageOnPawn, "BmGame.MDualClawClusterProjectile.DoDualClawDamageOnPawn");
        byte* paramsPtr = stackalloc byte[292];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherPawn, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(impulseOnPawn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoClusterDamageOnPawn;
    /// <summary>
    /// Function: DoClusterDamageOnPawn
    /// </summary>
    public unsafe virtual void DoClusterDamageOnPawn(BmSDK.BmGame.RPawnCombat Target, BmSDK.Engine.Actor OtherTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoClusterDamageOnPawn, "BmGame.MDualClawClusterProjectile.DoClusterDamageOnPawn");
        byte* paramsPtr = stackalloc byte[280];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherTarget, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyCutRope;
    /// <summary>
    /// Function: NotifyCutRope
    /// </summary>
    public unsafe virtual void NotifyCutRope()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyCutRope, "BmGame.MDualClawClusterProjectile.NotifyCutRope");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PullPawnToHidePoint;
    /// <summary>
    /// Function: PullPawnToHidePoint
    /// </summary>
    public unsafe virtual void PullPawnToHidePoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PullPawnToHidePoint, "BmGame.MDualClawClusterProjectile.PullPawnToHidePoint");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupPawnPullNavigation;
    /// <summary>
    /// Function: SetupPawnPullNavigation
    /// </summary>
    public unsafe virtual void SetupPawnPullNavigation(BmSDK.BmGame.RPawnVillain Victim)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupPawnPullNavigation, "BmGame.MDualClawClusterProjectile.SetupPawnPullNavigation");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CalculateHangingRopeLength;
    /// <summary>
    /// Function: CalculateHangingRopeLength
    /// </summary>
    public unsafe virtual float CalculateHangingRopeLength(BmSDK.BmGame.RHidePoint HidePoint, BmSDK.BmGame.RPawn Victim)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateHangingRopeLength, "BmGame.MDualClawClusterProjectile.CalculateHangingRopeLength");
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HidePoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ThrownObjectDestroyed;
    /// <summary>
    /// Function: ThrownObjectDestroyed
    /// </summary>
    public unsafe virtual void ThrownObjectDestroyed(BmSDK.BmGame.RBMCombatThrownObject ThrownObject)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThrownObjectDestroyed, "BmGame.MDualClawClusterProjectile.ThrownObjectDestroyed");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownObject, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateObjectHidePointRope;
    /// <summary>
    /// Function: CreateObjectHidePointRope
    /// </summary>
    public unsafe virtual void CreateObjectHidePointRope()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateObjectHidePointRope, "BmGame.MDualClawClusterProjectile.CreateObjectHidePointRope");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PullObjectToHarpoon;
    /// <summary>
    /// Function: PullObjectToHarpoon
    /// </summary>
    public unsafe virtual void PullObjectToHarpoon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PullObjectToHarpoon, "BmGame.MDualClawClusterProjectile.PullObjectToHarpoon");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PullObjectToHidePoint;
    /// <summary>
    /// Function: PullObjectToHidePoint
    /// </summary>
    public unsafe virtual void PullObjectToHidePoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PullObjectToHidePoint, "BmGame.MDualClawClusterProjectile.PullObjectToHidePoint");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PullHeavyObjectToPawn;
    /// <summary>
    /// Function: PullHeavyObjectToPawn
    /// </summary>
    public unsafe virtual void PullHeavyObjectToPawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PullHeavyObjectToPawn, "BmGame.MDualClawClusterProjectile.PullHeavyObjectToPawn");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PullObjectToObject;
    /// <summary>
    /// Function: PullObjectToObject
    /// </summary>
    public unsafe virtual void PullObjectToObject()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PullObjectToObject, "BmGame.MDualClawClusterProjectile.PullObjectToObject");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartAutoShrinkRope;
    /// <summary>
    /// Function: StartAutoShrinkRope
    /// </summary>
    public unsafe virtual void StartAutoShrinkRope(BmSDK.BmGame.RRopeComponentBase.ERopeLengthChangeType RopeChangeType, bool isAttachedToEnd1)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAutoShrinkRope, "BmGame.MDualClawClusterProjectile.StartAutoShrinkRope");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RopeChangeType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(isAttachedToEnd1, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartRetractedRope;
    /// <summary>
    /// Function: StartRetractedRope
    /// </summary>
    public unsafe virtual void StartRetractedRope(float RopeLength, float ShrinkSpeed, BmSDK.BmGame.RRopeComponentBase.ERopeLengthChangeType RopeChangeType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartRetractedRope, "BmGame.MDualClawClusterProjectile.StartRetractedRope");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RopeLength, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShrinkSpeed, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RopeChangeType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateDualClawWire;
    /// <summary>
    /// Function: CreateDualClawWire
    /// </summary>
    public unsafe virtual void CreateDualClawWire(System.Numerics.Vector3 FirstAttachPos, System.Numerics.Vector3 SecondAttachPos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateDualClawWire, "BmGame.MDualClawClusterProjectile.CreateDualClawWire");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FirstAttachPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SecondAttachPos, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateRopePawnToHarpoonTrigger;
    /// <summary>
    /// Function: CreateRopePawnToHarpoonTrigger
    /// </summary>
    public unsafe virtual void CreateRopePawnToHarpoonTrigger()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateRopePawnToHarpoonTrigger, "BmGame.MDualClawClusterProjectile.CreateRopePawnToHarpoonTrigger");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableRagdollMeasures;
    /// <summary>
    /// Function: EnableRagdollMeasures
    /// </summary>
    public unsafe virtual void EnableRagdollMeasures(BmSDK.BmGame.RPawnCombat Victim)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableRagdollMeasures, "BmGame.MDualClawClusterProjectile.EnableRagdollMeasures");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DetachRetractRope;
    /// <summary>
    /// Function: DetachRetractRope
    /// </summary>
    public unsafe virtual void DetachRetractRope()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetachRetractRope, "BmGame.MDualClawClusterProjectile.DetachRetractRope");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RopeHookReachedDest;
    /// <summary>
    /// Function: RopeHookReachedDest
    /// </summary>
    public unsafe virtual void RopeHookReachedDest()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RopeHookReachedDest, "BmGame.MDualClawClusterProjectile.RopeHookReachedDest");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachRopeToActor;
    /// <summary>
    /// Function: AttachRopeToActor
    /// </summary>
    public unsafe virtual void AttachRopeToActor(BmSDK.BmGame.RRopeComponentBase Rope, BmSDK.Engine.Actor inActor, bool isAttachedToEnd1, BmSDK.Engine.Actor OtherActor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachRopeToActor, "BmGame.MDualClawClusterProjectile.AttachRopeToActor");
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rope, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inActor, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(isAttachedToEnd1, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherActor, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RopeHookFailedReachedDest;
    /// <summary>
    /// Function: RopeHookFailedReachedDest
    /// </summary>
    public unsafe virtual void RopeHookFailedReachedDest()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RopeHookFailedReachedDest, "BmGame.MDualClawClusterProjectile.RopeHookFailedReachedDest");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitRetractRope;
    /// <summary>
    /// Function: InitRetractRope
    /// </summary>
    public unsafe virtual void InitRetractRope()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitRetractRope, "BmGame.MDualClawClusterProjectile.InitRetractRope");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachRetractRope;
    /// <summary>
    /// Function: AttachRetractRope
    /// </summary>
    public unsafe virtual void AttachRetractRope(BmSDK.Engine.Actor inActor, bool isAttachedToEnd1, BmSDK.Engine.Actor OtherActor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachRetractRope, "BmGame.MDualClawClusterProjectile.AttachRetractRope");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(isAttachedToEnd1, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherActor, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTargetType;
    /// <summary>
    /// Function: GetTargetType
    /// </summary>
    public unsafe virtual void GetTargetType(BmSDK.Engine.Actor inActor, out BmSDK.BmGame.MDualClawClusterProjectile.EDualClawTargetType TargetType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargetType, "BmGame.MDualClawClusterProjectile.GetTargetType");
        byte* paramsPtr = stackalloc byte[21];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inActor, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TargetType);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TargetType = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MDualClawClusterProjectile.EDualClawTargetType>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_FireSingleRopeHook;
    /// <summary>
    /// Function: FireSingleRopeHook
    /// </summary>
    public unsafe virtual void FireSingleRopeHook()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireSingleRopeHook, "BmGame.MDualClawClusterProjectile.FireSingleRopeHook");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerFireFX;
    /// <summary>
    /// Function: TriggerFireFX
    /// </summary>
    public unsafe virtual void TriggerFireFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerFireFX, "BmGame.MDualClawClusterProjectile.TriggerFireFX");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CalculateCameraDuration;
    /// <summary>
    /// Function: CalculateCameraDuration
    /// </summary>
    public unsafe virtual void CalculateCameraDuration()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateCameraDuration, "BmGame.MDualClawClusterProjectile.CalculateCameraDuration");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsHangItemToHidePoint;
    /// <summary>
    /// Function: IsHangItemToHidePoint
    /// </summary>
    public unsafe virtual bool IsHangItemToHidePoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsHangItemToHidePoint, "BmGame.MDualClawClusterProjectile.IsHangItemToHidePoint");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCamTrackingTarget;
    /// <summary>
    /// Function: GetCamTrackingTarget
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor GetCamTrackingTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCamTrackingTarget, "BmGame.MDualClawClusterProjectile.GetCamTrackingTarget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnPostImpactCamEnd;
    /// <summary>
    /// Function: OnPostImpactCamEnd
    /// </summary>
    public unsafe virtual void OnPostImpactCamEnd()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPostImpactCamEnd, "BmGame.MDualClawClusterProjectile.OnPostImpactCamEnd");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPostImpactCamStart;
    /// <summary>
    /// Function: OnPostImpactCamStart
    /// </summary>
    public unsafe virtual void OnPostImpactCamStart()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPostImpactCamStart, "BmGame.MDualClawClusterProjectile.OnPostImpactCamStart");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnLockOnTarget;
    /// <summary>
    /// Function: UnLockOnTarget
    /// </summary>
    public unsafe virtual void UnLockOnTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnLockOnTarget, "BmGame.MDualClawClusterProjectile.UnLockOnTarget");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FlyingToOtherTarget;
    /// <summary>
    /// Function: FlyingToOtherTarget
    /// </summary>
    public unsafe virtual void FlyingToOtherTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlyingToOtherTarget, "BmGame.MDualClawClusterProjectile.FlyingToOtherTarget");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LockOnTarget;
    /// <summary>
    /// Function: LockOnTarget
    /// </summary>
    public unsafe virtual void LockOnTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LockOnTarget, "BmGame.MDualClawClusterProjectile.LockOnTarget");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FlyingToTarget;
    /// <summary>
    /// Function: FlyingToTarget
    /// </summary>
    public unsafe virtual void FlyingToTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlyingToTarget, "BmGame.MDualClawClusterProjectile.FlyingToTarget");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateRopeHook;
    /// <summary>
    /// Function: CreateRopeHook
    /// </summary>
    public unsafe virtual void CreateRopeHook()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateRopeHook, "BmGame.MDualClawClusterProjectile.CreateRopeHook");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTargetRotation;
    /// <summary>
    /// Function: GetTargetRotation
    /// </summary>
    public unsafe virtual BmSDK.Rotator GetTargetRotation(BmSDK.Engine.Actor Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargetRotation, "BmGame.MDualClawClusterProjectile.GetTargetRotation");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SwapMesh;
    /// <summary>
    /// Function: SwapMesh
    /// </summary>
    public unsafe virtual void SwapMesh()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwapMesh, "BmGame.MDualClawClusterProjectile.SwapMesh");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnFirstImpact;
    /// <summary>
    /// Function: OnFirstImpact
    /// </summary>
    public unsafe virtual void OnFirstImpact()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFirstImpact, "BmGame.MDualClawClusterProjectile.OnFirstImpact");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireProjectileShowTime;
    /// <summary>
    /// Function: FireProjectileShowTime
    /// </summary>
    public unsafe virtual void FireProjectileShowTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireProjectileShowTime, "BmGame.MDualClawClusterProjectile.FireProjectileShowTime");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireCluster;
    /// <summary>
    /// Function: FireCluster
    /// </summary>
    public unsafe virtual void FireCluster(System.Numerics.Vector3 Destination)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireCluster, "BmGame.MDualClawClusterProjectile.FireCluster");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Destination, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyCluster;
    /// <summary>
    /// Function: DestroyCluster
    /// </summary>
    public unsafe virtual void DestroyCluster()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyCluster, "BmGame.MDualClawClusterProjectile.DestroyCluster");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Initialize;
    /// <summary>
    /// Function: Initialize
    /// </summary>
    public unsafe virtual void Initialize(BmSDK.Engine.Inventory Launcher, BmSDK.FName SocketName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialize, "BmGame.MDualClawClusterProjectile.Initialize");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Launcher, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SocketName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: EDualClawTargetType
    /// </summary>
    public enum EDualClawTargetType : byte
    {
        DCTT_Pawn = 0,
        DCTT_Drone = 1,
        DCTT_HidePoint = 2,
        DCTT_HarpoonTrigger = 3,
        DCTT_EnvironmentWeapon = 4,
        DCTT_MAX = 5,
    }

    /// <summary>
    /// ComponentProperty: BatarangMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent BatarangMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// ComponentProperty: FirstHookMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent FirstHookMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// ComponentProperty: SecondHookMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent SecondHookMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// ComponentProperty: LightEnvironment
    /// </summary>
    public unsafe BmSDK.Engine.DynamicLightEnvironmentComponent LightEnvironment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DynamicLightEnvironmentComponent>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// StructProperty: mClusterDestination
    /// </summary>
    public unsafe ref System.Numerics.Vector3 mClusterDestination
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 572);

    /// <summary>
    /// ObjectProperty: mLauncher
    /// </summary>
    public unsafe BmSDK.Engine.Inventory mLauncher
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Inventory>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: mHasLaunchedRopes
    /// </summary>
    public unsafe bool mHasLaunchedRopes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 588); }
    }

    /// <summary>
    /// BoolProperty: IsThugToThugBumpSoundOn
    /// </summary>
    public unsafe bool IsThugToThugBumpSoundOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 588); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreRopeHookFx
    /// </summary>
    public unsafe bool bIgnoreRopeHookFx
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 588); }
    }

    /// <summary>
    /// BoolProperty: mRopeHookFailed
    /// </summary>
    public unsafe bool mRopeHookFailed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 588); }
    }

    /// <summary>
    /// BoolProperty: IsLockedOnTarget
    /// </summary>
    public unsafe bool IsLockedOnTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 588); }
    }

    /// <summary>
    /// BoolProperty: HasStartRetracting
    /// </summary>
    public unsafe bool HasStartRetracting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 588); }
    }

    /// <summary>
    /// BoolProperty: IsObjectToHidePoint
    /// </summary>
    public unsafe bool IsObjectToHidePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 588); }
    }

    /// <summary>
    /// BoolProperty: IsObjectToObject
    /// </summary>
    public unsafe bool IsObjectToObject
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 588); }
    }

    /// <summary>
    /// BoolProperty: UseCamPostImpactLocation
    /// </summary>
    public unsafe bool UseCamPostImpactLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 588); }
    }

    /// <summary>
    /// BoolProperty: bRetractRopeStarted
    /// </summary>
    public unsafe bool bRetractRopeStarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 588); }
    }

    /// <summary>
    /// BoolProperty: bCanBeTakenDown1
    /// </summary>
    public unsafe bool bCanBeTakenDown1
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 588); }
    }

    /// <summary>
    /// BoolProperty: bCanBeTakenDown2
    /// </summary>
    public unsafe bool bCanBeTakenDown2
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 588); }
    }

    /// <summary>
    /// ObjectProperty: mRopeHook
    /// </summary>
    public unsafe BmSDK.BmGame.MDualClawProjectile mRopeHook
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MDualClawProjectile>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// ComponentProperty: mRetractRope
    /// </summary>
    public unsafe BmSDK.BmGame.RRopeComponent mRetractRope
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRopeComponent>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// ComponentProperty: mSimpleRope
    /// </summary>
    public unsafe BmSDK.BmGame.RSimpleRopeComponent mSimpleRope
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSimpleRopeComponent>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// ArrayProperty: SpawnableRopeExtraAttachConnections
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RRopeComponent.FRopeExtraAttachConnection> SpawnableRopeExtraAttachConnections
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRopeComponent.FRopeExtraAttachConnection>>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// ObjectProperty: mTightRopeWire
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint_RopeBase mTightRopeWire
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint_RopeBase>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// ComponentProperty: WireDetector1
    /// </summary>
    public unsafe BmSDK.Engine.CylinderComponent WireDetector1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CylinderComponent>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// ComponentProperty: WireDetector2
    /// </summary>
    public unsafe BmSDK.Engine.CylinderComponent WireDetector2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CylinderComponent>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// ObjectProperty: ControlledBehaviour
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBehaviour_BeingTakenDown ControlledBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour_BeingTakenDown>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// StructProperty: VictimTransition
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId VictimTransition
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 632);

    /// <summary>
    /// ArrayProperty: mBatClawReactionAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> mBatClawReactionAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// ArrayProperty: mRemoteClawReactionAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> mRemoteClawReactionAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// ObjectProperty: LockOnSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent LockOnSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// ObjectProperty: LockOffSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent LockOffSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// ObjectProperty: PawnPullSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent PawnPullSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: FlyingSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FlyingSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// ObjectProperty: FlyingStopSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FlyingStopSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ObjectProperty: CamSloMoSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent CamSloMoSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// StructProperty: CamSloMoSoundHandler
    /// </summary>
    public unsafe ref BmSDK.Engine.AkWwise.FAkSoundHandle CamSloMoSoundHandler
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 684);

    /// <summary>
    /// ObjectProperty: HumanImpact
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName HumanImpact
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ObjectProperty: MetalImpact
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName MetalImpact
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ObjectProperty: StoneImpact
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName StoneImpact
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ObjectProperty: ThugToThugBumpSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ThugToThugBumpSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ComponentProperty: RetractionParticleTrail
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent RetractionParticleTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// ObjectProperty: mPrimaryTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor mPrimaryTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// IntProperty: mPrimaryTargetSocketIndex
    /// </summary>
    public unsafe int mPrimaryTargetSocketIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// StructProperty: mPrimaryTargetPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 mPrimaryTargetPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 724);

    /// <summary>
    /// ByteProperty: FirstTargetType
    /// </summary>
    public unsafe BmSDK.BmGame.MDualClawClusterProjectile.EDualClawTargetType FirstTargetType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MDualClawClusterProjectile.EDualClawTargetType>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// ByteProperty: SecondTargetType
    /// </summary>
    public unsafe BmSDK.BmGame.MDualClawClusterProjectile.EDualClawTargetType SecondTargetType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MDualClawClusterProjectile.EDualClawTargetType>(Ptr + 737); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 737); }
    }

    /// <summary>
    /// ObjectProperty: mSecondaryTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor mSecondaryTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// IntProperty: mSecondaryTargetSocketIndex
    /// </summary>
    public unsafe int mSecondaryTargetSocketIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// StructProperty: mSecondaryTargetPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 mSecondaryTargetPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 748);

    /// <summary>
    /// ObjectProperty: mPrimaryThrowObject
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatThrownObject mPrimaryThrowObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatThrownObject>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// ObjectProperty: mSecondaryThrowObject
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatThrownObject mSecondaryThrowObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatThrownObject>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// FloatProperty: mCameraDuration
    /// </summary>
    public unsafe float mCameraDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// StructProperty: mStartCameraLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 mStartCameraLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 772);

    /// <summary>
    /// ObjectProperty: mStrungUpVictim
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain mStrungUpVictim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// StructProperty: mLastPullPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 mLastPullPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 788);

    /// <summary>
    /// FloatProperty: mStuckTime
    /// </summary>
    public unsafe float mStuckTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// FloatProperty: mObstacleTime
    /// </summary>
    public unsafe float mObstacleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ArrayProperty: mPullWayPoints
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> mPullWayPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// IntProperty: mCurrentWayPoint
    /// </summary>
    public unsafe int mCurrentWayPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// StructProperty: mLastRotation
    /// </summary>
    public unsafe ref BmSDK.GameObject.FQuat mLastRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FQuat>(Ptr + 832);

    /// <summary>
    /// FloatProperty: mDirectionBlendTime
    /// </summary>
    public unsafe float mDirectionBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// FloatProperty: mDirectionBlendDuration
    /// </summary>
    public unsafe float mDirectionBlendDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// FloatProperty: mPawnToHidePointRetractSpeedMin
    /// </summary>
    public unsafe float mPawnToHidePointRetractSpeedMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// FloatProperty: mPawnToHidePointRetractSpeedMax
    /// </summary>
    public unsafe float mPawnToHidePointRetractSpeedMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// FloatProperty: mWayPointAreaSize
    /// </summary>
    public unsafe float mWayPointAreaSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// FloatProperty: mInitialDistance
    /// </summary>
    public unsafe float mInitialDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// FloatProperty: mMaxHangingRopeLength
    /// </summary>
    public unsafe float mMaxHangingRopeLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// ClassProperty: MyPullDamageType
    /// </summary>
    public unsafe BmSDK.Class MyPullDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// FloatProperty: TimeShot
    /// </summary>
    public unsafe float TimeShot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// FloatProperty: mPawnToHidePointRopeLength
    /// </summary>
    public unsafe float mPawnToHidePointRopeLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ObjectProperty: RopeBaseSpawnable
    /// </summary>
    public unsafe BmSDK.BmGame.RRopeBaseSpawnable RopeBaseSpawnable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRopeBaseSpawnable>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// StructProperty: FireFrom
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FireFrom
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 892);

    /// <summary>
    /// StructProperty: FireTo
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FireTo
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 904);

    /// <summary>
    /// FloatProperty: FireDuration
    /// </summary>
    public unsafe float FireDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// StructProperty: camRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator camRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 920);

    /// <summary>
    /// FloatProperty: SpinVelocity
    /// </summary>
    public unsafe float SpinVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// StructProperty: MeshOffsetPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MeshOffsetPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 936);

    /// <summary>
    /// FloatProperty: fCustomDamageAmount
    /// </summary>
    public unsafe float fCustomDamageAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// FloatProperty: CurrentFireTime
    /// </summary>
    public unsafe float CurrentFireTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// StructProperty: CamPostImpactLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CamPostImpactLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 956);

    /// <summary>
    /// StructProperty: CameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 968);

    /// <summary>
    /// FloatProperty: ProportionAlongPath
    /// </summary>
    public unsafe float ProportionAlongPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }
}
