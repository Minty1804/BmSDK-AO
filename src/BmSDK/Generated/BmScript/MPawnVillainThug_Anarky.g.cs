#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MPawnVillainThug_Anarky<br/>
/// (size = 4168)
/// (flags = 10485814)
/// </summary>
public partial class MPawnVillainThug_Anarky : BmSDK.BmScript.MPawnVillainInterrogatableThug, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MPawnVillainThug_Anarky", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MPawnVillainThug_Anarky.
    /// </summary>
    public static MPawnVillainThug_Anarky DefaultObject => (MPawnVillainThug_Anarky)StaticClass().DefaultObject;

    internal MPawnVillainThug_Anarky() { }

    /// <summary>
    /// Constructs a new MPawnVillainThug_Anarky
    /// </summary>
    public MPawnVillainThug_Anarky(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MPawnVillainThug_Anarky(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillainThug_Anarky>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainThug_Anarky>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillainThug_Anarky>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainThug_Anarky>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainThug_Anarky>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainThug_Anarky>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillainThug_Anarky>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainThug_Anarky>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GoToMercyMode;
    /// <summary>
    /// Function: GoToMercyMode
    /// </summary>
    public unsafe override void GoToMercyMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GoToMercyMode, "BmScript.MPawnVillainThug_Anarky.GoToMercyMode");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayComboTakeDownBark;
    /// <summary>
    /// Function: PlayComboTakeDownBark
    /// </summary>
    public unsafe override void PlayComboTakeDownBark(BmSDK.BmGame.RPawnVillain Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayComboTakeDownBark, "BmScript.MPawnVillainThug_Anarky.PlayComboTakeDownBark");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayGroundTakeDownBark;
    /// <summary>
    /// Function: PlayGroundTakeDownBark
    /// </summary>
    public unsafe override void PlayGroundTakeDownBark(BmSDK.BmGame.RPawnVillain Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayGroundTakeDownBark, "BmScript.MPawnVillainThug_Anarky.PlayGroundTakeDownBark");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnSpecialAttack;
    /// <summary>
    /// Function: SpawnSpecialAttack
    /// </summary>
    public unsafe override bool SpawnSpecialAttack(BmSDK.BmGame.RPawnCombat PlayerPawn, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnSpecialAttack, "BmScript.MPawnVillainThug_Anarky.SpawnSpecialAttack");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ShouldStartFinalBlowCam;
    /// <summary>
    /// Function: ShouldStartFinalBlowCam
    /// </summary>
    public unsafe override bool ShouldStartFinalBlowCam(float StrikeDamageAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldStartFinalBlowCam, "BmScript.MPawnVillainThug_Anarky.ShouldStartFinalBlowCam");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeDamageAmount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ShouldForceBeatDownEnd;
    /// <summary>
    /// Function: ShouldForceBeatDownEnd
    /// </summary>
    public unsafe override bool ShouldForceBeatDownEnd()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldForceBeatDownEnd, "BmScript.MPawnVillainThug_Anarky.ShouldForceBeatDownEnd");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHealthForBeatdown;
    /// <summary>
    /// Function: GetHealthForBeatdown
    /// </summary>
    public unsafe override float GetHealthForBeatdown(bool bBeatdownEndCheck)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHealthForBeatdown, "BmScript.MPawnVillainThug_Anarky.GetHealthForBeatdown");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBeatdownEndCheck, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_EnterMercyMode;
    /// <summary>
    /// Function: EnterMercyMode
    /// </summary>
    public unsafe override BmSDK.BmScript.MBMBehaviour_Mercy EnterMercyMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnterMercyMode, "BmScript.MPawnVillainThug_Anarky.EnterMercyMode");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmScript.MBMBehaviour_Mercy>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DropMask;
    /// <summary>
    /// Function: DropMask
    /// </summary>
    public unsafe virtual void DropMask()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DropMask, "BmScript.MPawnVillainThug_Anarky.DropMask");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInterrogatable;
    /// <summary>
    /// Function: SetInterrogatable
    /// </summary>
    public unsafe override void SetInterrogatable(bool bNewValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInterrogatable, "BmScript.MPawnVillainThug_Anarky.SetInterrogatable");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DettachLigthEmitter;
    /// <summary>
    /// Function: DettachLigthEmitter
    /// </summary>
    public unsafe virtual void DettachLigthEmitter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DettachLigthEmitter, "BmScript.MPawnVillainThug_Anarky.DettachLigthEmitter");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LightMyRightSide;
    /// <summary>
    /// Function: LightMyRightSide
    /// </summary>
    public unsafe virtual void LightMyRightSide()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LightMyRightSide, "BmScript.MPawnVillainThug_Anarky.LightMyRightSide");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LightMyLeftSide;
    /// <summary>
    /// Function: LightMyLeftSide
    /// </summary>
    public unsafe virtual void LightMyLeftSide()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LightMyLeftSide, "BmScript.MPawnVillainThug_Anarky.LightMyLeftSide");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyHitPlayer;
    /// <summary>
    /// Function: NotifyHitPlayer
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.FDamageInfo NotifyHitPlayer(System.Numerics.Vector3 HitNormal, bool IsFlameBall)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyHitPlayer, "BmScript.MPawnVillainThug_Anarky.NotifyHitPlayer");
        byte* paramsPtr = stackalloc byte[560];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsFlameBall, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.FDamageInfo>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmScript.MPawnVillainThug_Anarky.Tick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThrowBrick;
    /// <summary>
    /// Function: ThrowBrick
    /// </summary>
    public unsafe virtual void ThrowBrick()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThrowBrick, "BmScript.MPawnVillainThug_Anarky.ThrowBrick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoLaunchGrenade;
    /// <summary>
    /// Function: DoLaunchGrenade
    /// </summary>
    public unsafe virtual void DoLaunchGrenade(System.Numerics.Vector3 ThrowVelocity, System.Numerics.Vector3 TargetLocation, System.Numerics.Vector3 SpawnLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoLaunchGrenade, "BmScript.MPawnVillainThug_Anarky.DoLaunchGrenade");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowVelocity, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLocation, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EvadeBatman;
    /// <summary>
    /// Function: EvadeBatman
    /// </summary>
    public unsafe virtual void EvadeBatman()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EvadeBatman, "BmScript.MPawnVillainThug_Anarky.EvadeBatman");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnOverrideTakedown;
    /// <summary>
    /// Function: SpawnOverrideTakedown
    /// </summary>
    public unsafe override bool SpawnOverrideTakedown(BmSDK.BmGame.RPawnCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnOverrideTakedown, "BmScript.MPawnVillainThug_Anarky.SpawnOverrideTakedown");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SpawnSpecialWeaponDestroy;
    /// <summary>
    /// Function: SpawnSpecialWeaponDestroy
    /// </summary>
    public unsafe override bool SpawnSpecialWeaponDestroy(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnSpecialWeaponDestroy, "BmScript.MPawnVillainThug_Anarky.SpawnSpecialWeaponDestroy");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsValidBatclawSlamTarget;
    /// <summary>
    /// Function: IsValidBatclawSlamTarget
    /// </summary>
    public unsafe override bool IsValidBatclawSlamTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidBatclawSlamTarget, "BmScript.MPawnVillainThug_Anarky.IsValidBatclawSlamTarget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPickup;
    /// <summary>
    /// Function: CanPickup
    /// </summary>
    public unsafe override bool CanPickup(BmSDK.BmGame.RBMCombatThrownObject Object)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPickup, "BmScript.MPawnVillainThug_Anarky.CanPickup");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Object, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_Died;
    /// <summary>
    /// Function: Died
    /// </summary>
    public unsafe override bool Died(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Died, "BmScript.MPawnVillainThug_Anarky.Died");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_SetGoodAsDead;
    /// <summary>
    /// Function: SetGoodAsDead
    /// </summary>
    public unsafe override void SetGoodAsDead()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGoodAsDead, "BmScript.MPawnVillainThug_Anarky.SetGoodAsDead");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHostile;
    /// <summary>
    /// Function: SetHostile
    /// </summary>
    public unsafe override void SetHostile(bool bNewValue, BmSDK.FName NewNotHostileReason = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHostile, "BmScript.MPawnVillainThug_Anarky.SetHostile");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewNotHostileReason, paramsPtr + 4);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmScript.MPawnVillainThug_Anarky.PostBeginPlay");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RagdollKill, "BmScript.MPawnVillainThug_Anarky.RagdollKill");
        byte* paramsPtr = stackalloc byte[272];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyDamageAmount, "BmScript.MPawnVillainThug_Anarky.ModifyDamageAmount");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DmgAmount);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgAmount, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DmgAmount = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_DamagedBy;
    /// <summary>
    /// Function: DamagedBy
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult DamagedBy(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamagedBy, "BmScript.MPawnVillainThug_Anarky.DamagedBy");
        byte* paramsPtr = stackalloc byte[274];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 256);
    }

    private static BmSDK.Function __fn_UpdateHealthBar;
    /// <summary>
    /// Function: UpdateHealthBar
    /// </summary>
    public unsafe virtual void UpdateHealthBar()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateHealthBar, "BmScript.MPawnVillainThug_Anarky.UpdateHealthBar");
        byte* paramsPtr = stackalloc byte[20];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseHUD, "BmScript.MPawnVillainThug_Anarky.CloseHUD");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitHUD, "BmScript.MPawnVillainThug_Anarky.InitHUD");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHealth, "BmScript.MPawnVillainThug_Anarky.SetHealth");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// FloatProperty: MolotovGrenadeDamage
    /// </summary>
    public unsafe float MolotovGrenadeDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4040); }
    }

    /// <summary>
    /// ObjectProperty: BatmanPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer BatmanPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 4044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4044); }
    }

    /// <summary>
    /// ObjectProperty: BatmanRPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController BatmanRPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 4048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4048); }
    }

    /// <summary>
    /// StructProperty: GrenadeVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GrenadeVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4052);

    /// <summary>
    /// StructProperty: GrenadeSpawnLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GrenadeSpawnLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4064);

    /// <summary>
    /// StructProperty: GrenadeTargetLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GrenadeTargetLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4076);

    /// <summary>
    /// StructProperty: ThrowTransitionID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId ThrowTransitionID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 4088);

    /// <summary>
    /// ComponentProperty: L_UpperArm_Emitter
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent L_UpperArm_Emitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4092); }
    }

    /// <summary>
    /// ComponentProperty: L_ForeArm_Emitter
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent L_ForeArm_Emitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4096); }
    }

    /// <summary>
    /// ComponentProperty: L_LThighTwist_Emitter
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent L_LThighTwist_Emitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4100); }
    }

    /// <summary>
    /// ComponentProperty: L_Calf_Emitter
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent L_Calf_Emitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4104); }
    }

    /// <summary>
    /// ComponentProperty: R_UpperArm_Emitter
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent R_UpperArm_Emitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4108); }
    }

    /// <summary>
    /// ComponentProperty: R_ForeArm_Emitter
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent R_ForeArm_Emitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4112); }
    }

    /// <summary>
    /// ComponentProperty: R_ThighTwist_Emitter
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent R_ThighTwist_Emitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4116); }
    }

    /// <summary>
    /// ComponentProperty: R_Calf_Emitter
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent R_Calf_Emitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4120); }
    }

    /// <summary>
    /// ObjectProperty: UpperBurningFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem UpperBurningFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4124); }
    }

    /// <summary>
    /// ObjectProperty: LowerBurningFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem LowerBurningFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4128); }
    }

    /// <summary>
    /// FloatProperty: HealthLeftToTriggerMercy
    /// </summary>
    public unsafe float HealthLeftToTriggerMercy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4132); }
    }

    /// <summary>
    /// FloatProperty: MaxHealthDamagePerBeatdown
    /// </summary>
    public unsafe float MaxHealthDamagePerBeatdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4136); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: HealthPerDifficulty
    /// </summary>
    public InlineArray<float> HealthPerDifficulty => new(3, Ptr + 4140, 4, this);

    /// <summary>
    /// FloatProperty: HealthPerDifficulty
    /// </summary>
    public unsafe float HealthPerDifficulty_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4140); }
    }
    /// <summary>
    /// FloatProperty: HealthPerDifficulty
    /// </summary>
    public unsafe float HealthPerDifficulty_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4144); }
    }
    /// <summary>
    /// FloatProperty: HealthPerDifficulty
    /// </summary>
    public unsafe float HealthPerDifficulty_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4148); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: MinAttackDelayPerDifficulty
    /// </summary>
    public InlineArray<float> MinAttackDelayPerDifficulty => new(3, Ptr + 4152, 4, this);

    /// <summary>
    /// FloatProperty: MinAttackDelayPerDifficulty
    /// </summary>
    public unsafe float MinAttackDelayPerDifficulty_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4152); }
    }
    /// <summary>
    /// FloatProperty: MinAttackDelayPerDifficulty
    /// </summary>
    public unsafe float MinAttackDelayPerDifficulty_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4156); }
    }
    /// <summary>
    /// FloatProperty: MinAttackDelayPerDifficulty
    /// </summary>
    public unsafe float MinAttackDelayPerDifficulty_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4160); }
    }

    /// <summary>
    /// ObjectProperty: AnarkyBossBark_Molotov
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine AnarkyBossBark_Molotov
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4164); }
    }
}
