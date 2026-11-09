#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnPlayerCombat<br/>
/// (size = 2640)
/// (flags = 142606518)
/// </summary>
public partial class RPawnPlayerCombat : BmSDK.BmGame.RPawnPlayerAnim, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnPlayerCombat", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnPlayerCombat.
    /// </summary>
    public static RPawnPlayerCombat DefaultObject => (RPawnPlayerCombat)StaticClass().DefaultObject;

    internal RPawnPlayerCombat() { }

    /// <summary>
    /// Constructs a new RPawnPlayerCombat
    /// </summary>
    public RPawnPlayerCombat(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayerCombat(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCombat>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCombat>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCombat>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCombat>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCombat>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCombat>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCombat>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCombat>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_PlayHurtEmote;
    /// <summary>
    /// Function: PlayHurtEmote
    /// </summary>
    public unsafe override void PlayHurtEmote(float RandChance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHurtEmote, "BmGame.RPawnPlayerCombat.PlayHurtEmote");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RandChance, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetStrikeTrailPS;
    /// <summary>
    /// Function: GetStrikeTrailPS
    /// </summary>
    public unsafe virtual BmSDK.Engine.ParticleSystem GetStrikeTrailPS(BmSDK.Class StrikeDmgType, bool bIsSuperStrike, int ComboLevel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeTrailPS, "BmGame.RPawnPlayerCombat.GetStrikeTrailPS");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeDmgType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsSuperStrike, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboLevel, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.ParticleSystem>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetSlideEndMovementStance;
    /// <summary>
    /// Function: GetSlideEndMovementStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetSlideEndMovementStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSlideEndMovementStance, "BmGame.RPawnPlayerCombat.GetSlideEndMovementStance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStrikeMovementStance;
    /// <summary>
    /// Function: GetStrikeMovementStance
    /// </summary>
    public unsafe override BmSDK.FName GetStrikeMovementStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeMovementStance, "BmGame.RPawnPlayerCombat.GetStrikeMovementStance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCombatWeaponStance;
    /// <summary>
    /// Function: GetCombatWeaponStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetCombatWeaponStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatWeaponStance, "BmGame.RPawnPlayerCombat.GetCombatWeaponStance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetCurrentPylon;
    /// <summary>
    /// Function: SetCurrentPylon
    /// </summary>
    public unsafe virtual void SetCurrentPylon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentPylon, "BmGame.RPawnPlayerCombat.SetCurrentPylon");
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

    private static BmSDK.Function __fn_IsBotOn;
    /// <summary>
    /// Function: IsBotOn
    /// </summary>
    public unsafe override bool IsBotOn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBotOn, "BmGame.RPawnPlayerCombat.IsBotOn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RemoveHandcuffsNextCounter;
    /// <summary>
    /// Function: RemoveHandcuffsNextCounter
    /// </summary>
    public unsafe virtual void RemoveHandcuffsNextCounter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveHandcuffsNextCounter, "BmGame.RPawnPlayerCombat.RemoveHandcuffsNextCounter");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveHandcuffs;
    /// <summary>
    /// Function: RemoveHandcuffs
    /// </summary>
    public unsafe virtual void RemoveHandcuffs()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveHandcuffs, "BmGame.RPawnPlayerCombat.RemoveHandcuffs");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateKeepInViewTarget;
    /// <summary>
    /// Function: UpdateKeepInViewTarget
    /// </summary>
    public unsafe virtual void UpdateKeepInViewTarget(float MaxYawOffsetRad)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateKeepInViewTarget, "BmGame.RPawnPlayerCombat.UpdateKeepInViewTarget");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxYawOffsetRad, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableKeepInView;
    /// <summary>
    /// Function: EnableKeepInView
    /// </summary>
    public unsafe override void EnableKeepInView()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableKeepInView, "BmGame.RPawnPlayerCombat.EnableKeepInView");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableKeepInView;
    /// <summary>
    /// Function: DisableKeepInView
    /// </summary>
    public unsafe virtual void DisableKeepInView()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableKeepInView, "BmGame.RPawnPlayerCombat.DisableKeepInView");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KeepInView;
    /// <summary>
    /// Function: KeepInView
    /// </summary>
    public unsafe virtual void KeepInView(BmSDK.Engine.Actor Pawn, float MaxYaw, float maxPitch)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KeepInView, "BmGame.RPawnPlayerCombat.KeepInView");
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxYaw, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(maxPitch, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCombatFOV;
    /// <summary>
    /// Function: SetCombatFOV
    /// </summary>
    public unsafe virtual void SetCombatFOV(float MinFOV, int MinCombatants, float MaxFOV, int MaxCombatants, int NumCombatants)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCombatFOV, "BmGame.RPawnPlayerCombat.SetCombatFOV");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinFOV, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinCombatants, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxFOV, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxCombatants, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumCombatants, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckCameraTarget;
    /// <summary>
    /// Function: CheckCameraTarget
    /// </summary>
    public unsafe virtual void CheckCameraTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckCameraTarget, "BmGame.RPawnPlayerCombat.CheckCameraTarget");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCheckCameraTargetTimer;
    /// <summary>
    /// Function: SetCheckCameraTargetTimer
    /// </summary>
    public unsafe virtual void SetCheckCameraTargetTimer(float delayTime, System.Numerics.Vector3 TestOffset = default, BmSDK.BmGame.RGameInfo.CameraLookAtSpeed LookAtSpeed = default, BmSDK.Engine.Actor ForceTarget = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCheckCameraTargetTimer, "BmGame.RPawnPlayerCombat.SetCheckCameraTargetTimer");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(delayTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestOffset, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookAtSpeed, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceTarget, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetContinueComboTime;
    /// <summary>
    /// Function: GetContinueComboTime
    /// </summary>
    public unsafe virtual float GetContinueComboTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetContinueComboTime, "BmGame.RPawnPlayerCombat.GetContinueComboTime");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClientSpawnFailMove;
    /// <summary>
    /// Function: ClientSpawnFailMove
    /// </summary>
    public unsafe virtual void ClientSpawnFailMove(BmSDK.FName FailAnim, bool bCanBecomeThrow, bool bCanBecomeTakedown, bool bCanBecomeFloorTakedown, BmSDK.FName FailCapeState, System.Numerics.Vector3 MoveDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientSpawnFailMove, "BmGame.RPawnPlayerCombat.ClientSpawnFailMove");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FailAnim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanBecomeThrow, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanBecomeTakedown, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanBecomeFloorTakedown, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FailCapeState, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveDir, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnFailMoveSimulated;
    /// <summary>
    /// Function: SpawnFailMoveSimulated
    /// </summary>
    public unsafe virtual void SpawnFailMoveSimulated(BmSDK.FName FailAnim, bool bCanBecomeThrow, bool bCanBecomeTakedown, bool bCanBecomeFloorTakedown, BmSDK.FName FailCapeState, System.Numerics.Vector3 MoveDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnFailMoveSimulated, "BmGame.RPawnPlayerCombat.SpawnFailMoveSimulated");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FailAnim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanBecomeThrow, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanBecomeTakedown, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanBecomeFloorTakedown, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FailCapeState, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveDir, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnFailMove;
    /// <summary>
    /// Function: SpawnFailMove
    /// </summary>
    public unsafe virtual void SpawnFailMove(BmSDK.FName FailAnim, bool bCanBecomeThrow = default, bool bCanBecomeTakedown = default, bool bCanBecomeFloorTakedown = default, bool bCanBecomeWeaponDestroy = default, BmSDK.FName FailCapeState = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnFailMove, "BmGame.RPawnPlayerCombat.SpawnFailMove");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FailAnim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanBecomeThrow, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanBecomeTakedown, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanBecomeFloorTakedown, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanBecomeWeaponDestroy, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FailCapeState, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientDamagePawn;
    /// <summary>
    /// Function: ClientDamagePawn
    /// </summary>
    public unsafe virtual void ClientDamagePawn(BmSDK.BmGame.RPawnVillain Target, BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientDamagePawn, "BmGame.RPawnPlayerCombat.ClientDamagePawn");
        byte* paramsPtr = stackalloc byte[276];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientDoHitPawn;
    /// <summary>
    /// Function: ClientDoHitPawn
    /// </summary>
    public unsafe virtual void ClientDoHitPawn(BmSDK.BmGame.RPawnCombat DamageReceiver, float DmgAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientDoHitPawn, "BmGame.RPawnPlayerCombat.ClientDoHitPawn");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgAmount, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DropWeaponGrabbed;
    /// <summary>
    /// Function: DropWeaponGrabbed
    /// </summary>
    public unsafe virtual void DropWeaponGrabbed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DropWeaponGrabbed, "BmGame.RPawnPlayerCombat.DropWeaponGrabbed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetWeaponGrabbed;
    /// <summary>
    /// Function: SetWeaponGrabbed
    /// </summary>
    public unsafe virtual void SetWeaponGrabbed(BmSDK.BmGame.RBMCombatThrownObject WeaponObject, bool IsLeft)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWeaponGrabbed, "BmGame.RPawnPlayerCombat.SetWeaponGrabbed");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponObject, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsLeft, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MulticastSetWeaponGrabbed;
    /// <summary>
    /// Function: MulticastSetWeaponGrabbed
    /// </summary>
    public unsafe virtual void MulticastSetWeaponGrabbed(BmSDK.BmGame.RBMCombatThrownObject WeaponObject, bool IsLeft)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MulticastSetWeaponGrabbed, "BmGame.RPawnPlayerCombat.MulticastSetWeaponGrabbed");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponObject, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsLeft, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientSetShouldCancelFloorTakedown;
    /// <summary>
    /// Function: ClientSetShouldCancelFloorTakedown
    /// </summary>
    public unsafe virtual void ClientSetShouldCancelFloorTakedown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientSetShouldCancelFloorTakedown, "BmGame.RPawnPlayerCombat.ClientSetShouldCancelFloorTakedown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerSetShouldCancelFloorTakedown;
    /// <summary>
    /// Function: ServerSetShouldCancelFloorTakedown
    /// </summary>
    public unsafe virtual void ServerSetShouldCancelFloorTakedown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerSetShouldCancelFloorTakedown, "BmGame.RPawnPlayerCombat.ServerSetShouldCancelFloorTakedown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetShouldCancelFloorTakedown;
    /// <summary>
    /// Function: SetShouldCancelFloorTakedown
    /// </summary>
    public unsafe virtual void SetShouldCancelFloorTakedown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetShouldCancelFloorTakedown, "BmGame.RPawnPlayerCombat.SetShouldCancelFloorTakedown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientStrikeMiss;
    /// <summary>
    /// Function: ClientStrikeMiss
    /// </summary>
    public unsafe virtual void ClientStrikeMiss()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientStrikeMiss, "BmGame.RPawnPlayerCombat.ClientStrikeMiss");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmGame.RPawnPlayerCombat.PreStreamOut");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RPawnPlayerCombat.Destroyed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnSpecialMoveSimulated;
    /// <summary>
    /// Function: SpawnSpecialMoveSimulated
    /// </summary>
    public unsafe virtual void SpawnSpecialMoveSimulated(BmSDK.Class MoveClass, System.Numerics.Vector3 AnimPos, BmSDK.Rotator AnimRot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnSpecialMoveSimulated, "BmGame.RPawnPlayerCombat.SpawnSpecialMoveSimulated");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimRot, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientSpawnSpecialMoveSimulated;
    /// <summary>
    /// Function: ClientSpawnSpecialMoveSimulated
    /// </summary>
    public unsafe virtual void ClientSpawnSpecialMoveSimulated(BmSDK.Class MoveClass, System.Numerics.Vector3 AnimPos, BmSDK.Rotator AnimRot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientSpawnSpecialMoveSimulated, "BmGame.RPawnPlayerCombat.ClientSpawnSpecialMoveSimulated");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimRot, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnSpecialMove;
    /// <summary>
    /// Function: SpawnSpecialMove
    /// </summary>
    public unsafe virtual void SpawnSpecialMove(BmSDK.Class MoveClass)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnSpecialMove, "BmGame.RPawnPlayerCombat.SpawnSpecialMove");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnFailedFloorTakedown;
    /// <summary>
    /// Function: SpawnFailedFloorTakedown
    /// </summary>
    public unsafe virtual void SpawnFailedFloorTakedown(BmSDK.BmGame.RPawnVillain TargetPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnFailedFloorTakedown, "BmGame.RPawnPlayerCombat.SpawnFailedFloorTakedown");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientSpawnFailedPairedAnimMoveSimulated;
    /// <summary>
    /// Function: ClientSpawnFailedPairedAnimMoveSimulated
    /// </summary>
    public unsafe virtual void ClientSpawnFailedPairedAnimMoveSimulated(BmSDK.BmGame.RPawnVillain TargetPawn, BmSDK.FName AnimName, System.Numerics.Vector3 AnimPos, BmSDK.Rotator ThrowDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientSpawnFailedPairedAnimMoveSimulated, "BmGame.RPawnPlayerCombat.ClientSpawnFailedPairedAnimMoveSimulated");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowDir, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnFailedPairedAnimMoveSimulated;
    /// <summary>
    /// Function: SpawnFailedPairedAnimMoveSimulated
    /// </summary>
    public unsafe virtual void SpawnFailedPairedAnimMoveSimulated(BmSDK.BmGame.RPawnVillain TargetPawn, BmSDK.FName AnimName, System.Numerics.Vector3 AnimPos, System.Numerics.Vector3 ThrowDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnFailedPairedAnimMoveSimulated, "BmGame.RPawnPlayerCombat.SpawnFailedPairedAnimMoveSimulated");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowDir, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnFailedPairedAnimMove;
    /// <summary>
    /// Function: SpawnFailedPairedAnimMove
    /// </summary>
    public unsafe virtual void SpawnFailedPairedAnimMove(BmSDK.BmGame.RPawnVillain TargetPawn, BmSDK.FName AnimName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnFailedPairedAnimMove, "BmGame.RPawnPlayerCombat.SpawnFailedPairedAnimMove");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnWeaponDestroy;
    /// <summary>
    /// Function: SpawnWeaponDestroy
    /// </summary>
    public unsafe virtual void SpawnWeaponDestroy(BmSDK.BmGame.RPawnVillain TargetPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnWeaponDestroy, "BmGame.RPawnPlayerCombat.SpawnWeaponDestroy");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MulticastLockThrowDir;
    /// <summary>
    /// Function: MulticastLockThrowDir
    /// </summary>
    public unsafe virtual void MulticastLockThrowDir(BmSDK.BmGame.RPawnVillain Target, BmSDK.Engine.Actor HitActor, float NewTime, System.Numerics.Vector3 AnimPos, int AnimYaw)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MulticastLockThrowDir, "BmGame.RPawnPlayerCombat.MulticastLockThrowDir");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitActor, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTime, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimYaw, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientSpawnThrowSimulated;
    /// <summary>
    /// Function: ClientSpawnThrowSimulated
    /// </summary>
    public unsafe virtual void ClientSpawnThrowSimulated(BmSDK.BmGame.RPawnVillain TargetPawn, BmSDK.BmGame.RPawnPlayerCombat.FThrowInfo Info, System.Numerics.Vector3 AnimPos, BmSDK.Rotator ThrowDir, bool bSetCapeState, bool bDirectThrow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientSpawnThrowSimulated, "BmGame.RPawnPlayerCombat.ClientSpawnThrowSimulated");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Info, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowDir, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSetCapeState, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDirectThrow, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnThrowSimulated;
    /// <summary>
    /// Function: SpawnThrowSimulated
    /// </summary>
    public unsafe virtual void SpawnThrowSimulated(BmSDK.BmGame.RPawnVillain TargetPawn, BmSDK.BmGame.RPawnPlayerCombat.FThrowInfo Info, System.Numerics.Vector3 AnimPos, System.Numerics.Vector3 ThrowDir, bool bSetCapeState, bool bDirectThrow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnThrowSimulated, "BmGame.RPawnPlayerCombat.SpawnThrowSimulated");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Info, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowDir, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSetCapeState, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDirectThrow, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnThrow;
    /// <summary>
    /// Function: SpawnThrow
    /// </summary>
    public unsafe virtual void SpawnThrow(BmSDK.BmGame.RPawnVillain TargetPawn, BmSDK.Rotator ThrowDir, bool bSetCapeState, bool bDirectThrow = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnThrow, "BmGame.RPawnPlayerCombat.SpawnThrow");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowDir, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSetCapeState, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDirectThrow, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientSpawnIntoThrowSimulated;
    /// <summary>
    /// Function: ClientSpawnIntoThrowSimulated
    /// </summary>
    public unsafe virtual void ClientSpawnIntoThrowSimulated(BmSDK.BmGame.RPawnVillain TargetPawn, BmSDK.BmGame.RPawnCombat.TargetStrikeResponse TargetResponse, BmSDK.Rotator MoveDir, float TargetDist, System.Numerics.Vector3 AnimPos, float AnimRot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientSpawnIntoThrowSimulated, "BmGame.RPawnPlayerCombat.ClientSpawnIntoThrowSimulated");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetResponse, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveDir, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetDist, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimRot, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnIntoThrowSimulated;
    /// <summary>
    /// Function: SpawnIntoThrowSimulated
    /// </summary>
    public unsafe virtual void SpawnIntoThrowSimulated(BmSDK.BmGame.RPawnVillain TargetPawn, BmSDK.BmGame.RPawnCombat.TargetStrikeResponse TargetResponse, System.Numerics.Vector3 MoveDir, float TargetDist, System.Numerics.Vector3 AnimPos, float AnimRot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnIntoThrowSimulated, "BmGame.RPawnPlayerCombat.SpawnIntoThrowSimulated");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetResponse, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveDir, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetDist, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimRot, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnIntoThrow;
    /// <summary>
    /// Function: SpawnIntoThrow
    /// </summary>
    public unsafe virtual void SpawnIntoThrow(BmSDK.BmGame.RPawnVillain TargetPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnIntoThrow, "BmGame.RPawnPlayerCombat.SpawnIntoThrow");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnInitialThrowMove;
    /// <summary>
    /// Function: SpawnInitialThrowMove
    /// </summary>
    public unsafe virtual void SpawnInitialThrowMove(BmSDK.BmGame.RPawnVillain TargetPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnInitialThrowMove, "BmGame.RPawnPlayerCombat.SpawnInitialThrowMove");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientSpawnFloorTakedownSimulated;
    /// <summary>
    /// Function: ClientSpawnFloorTakedownSimulated
    /// </summary>
    public unsafe virtual void ClientSpawnFloorTakedownSimulated(BmSDK.BmGame.RPawnVillain TargetPawn, BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge ChallengeActionToTriggerIfSuccessful, float TargetDist, System.Numerics.Vector3 AnimPos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientSpawnFloorTakedownSimulated, "BmGame.RPawnPlayerCombat.ClientSpawnFloorTakedownSimulated");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeActionToTriggerIfSuccessful, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetDist, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnFloorTakedownSimulated;
    /// <summary>
    /// Function: SpawnFloorTakedownSimulated
    /// </summary>
    public unsafe virtual void SpawnFloorTakedownSimulated(BmSDK.BmGame.RPawnVillain TargetPawn, BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge ChallengeActionToTriggerIfSuccessful, float TargetDist, System.Numerics.Vector3 AnimPos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnFloorTakedownSimulated, "BmGame.RPawnPlayerCombat.SpawnFloorTakedownSimulated");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeActionToTriggerIfSuccessful, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetDist, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnFloorTakeDown;
    /// <summary>
    /// Function: SpawnFloorTakeDown
    /// </summary>
    public unsafe virtual void SpawnFloorTakeDown(BmSDK.BmGame.RPawnVillain TargetPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnFloorTakeDown, "BmGame.RPawnPlayerCombat.SpawnFloorTakeDown");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnSpecialFloorInteraction;
    /// <summary>
    /// Function: SpawnSpecialFloorInteraction
    /// </summary>
    public unsafe virtual void SpawnSpecialFloorInteraction(BmSDK.BmGame.RPawnVillain TargetPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnSpecialFloorInteraction, "BmGame.RPawnPlayerCombat.SpawnSpecialFloorInteraction");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnAerialRedirect;
    /// <summary>
    /// Function: SpawnAerialRedirect
    /// </summary>
    public unsafe virtual void SpawnAerialRedirect(BmSDK.BmGame.RPawnCombat TargetPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnAerialRedirect, "BmGame.RPawnPlayerCombat.SpawnAerialRedirect");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientSpawnEvadeSimulated;
    /// <summary>
    /// Function: ClientSpawnEvadeSimulated
    /// </summary>
    public unsafe virtual void ClientSpawnEvadeSimulated(System.Numerics.Vector3 EvadeDir, BmSDK.FName EvadeName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientSpawnEvadeSimulated, "BmGame.RPawnPlayerCombat.ClientSpawnEvadeSimulated");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvadeDir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvadeName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnEvadeSimulated;
    /// <summary>
    /// Function: SpawnEvadeSimulated
    /// </summary>
    public unsafe virtual void SpawnEvadeSimulated(System.Numerics.Vector3 EvadeDir, BmSDK.FName EvadeName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnEvadeSimulated, "BmGame.RPawnPlayerCombat.SpawnEvadeSimulated");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvadeDir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvadeName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnEvade;
    /// <summary>
    /// Function: SpawnEvade
    /// </summary>
    public unsafe virtual void SpawnEvade()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnEvade, "BmGame.RPawnPlayerCombat.SpawnEvade");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHitReactionMovementPose;
    /// <summary>
    /// Function: GetHitReactionMovementPose
    /// </summary>
    public unsafe virtual BmSDK.FName GetHitReactionMovementPose()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHitReactionMovementPose, "BmGame.RPawnPlayerCombat.GetHitReactionMovementPose");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRedirectMovementPose;
    /// <summary>
    /// Function: GetRedirectMovementPose
    /// </summary>
    public unsafe virtual BmSDK.FName GetRedirectMovementPose()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRedirectMovementPose, "BmGame.RPawnPlayerCombat.GetRedirectMovementPose");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetEvadeMovementStance;
    /// <summary>
    /// Function: GetEvadeMovementStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetEvadeMovementStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEvadeMovementStance, "BmGame.RPawnPlayerCombat.GetEvadeMovementStance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFailMovementStance;
    /// <summary>
    /// Function: GetFailMovementStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetFailMovementStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFailMovementStance, "BmGame.RPawnPlayerCombat.GetFailMovementStance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UseQuickEvade;
    /// <summary>
    /// Function: UseQuickEvade
    /// </summary>
    public unsafe virtual bool UseQuickEvade()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UseQuickEvade, "BmGame.RPawnPlayerCombat.UseQuickEvade");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpawnRedirect;
    /// <summary>
    /// Function: SpawnRedirect
    /// </summary>
    public unsafe virtual void SpawnRedirect(BmSDK.BmGame.RPawnVillain TargetPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnRedirect, "BmGame.RPawnPlayerCombat.SpawnRedirect");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnInterrogation;
    /// <summary>
    /// Function: SpawnInterrogation
    /// </summary>
    public unsafe virtual void SpawnInterrogation(BmSDK.BmGame.RPawnVillain TargetPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnInterrogation, "BmGame.RPawnPlayerCombat.SpawnInterrogation");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnComboTakeDown;
    /// <summary>
    /// Function: SpawnComboTakeDown
    /// </summary>
    public unsafe virtual void SpawnComboTakeDown(BmSDK.BmGame.RPawnVillain TargetPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnComboTakeDown, "BmGame.RPawnPlayerCombat.SpawnComboTakeDown");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientLockProjectileThrowTarget;
    /// <summary>
    /// Function: ClientLockProjectileThrowTarget
    /// </summary>
    public unsafe virtual void ClientLockProjectileThrowTarget(BmSDK.BmGame.RPawnVillain ThrowTarget, BmSDK.Rotator ThrowDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientLockProjectileThrowTarget, "BmGame.RPawnPlayerCombat.ClientLockProjectileThrowTarget");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowDir, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientSpawnProjectileCounterSimulated;
    /// <summary>
    /// Function: ClientSpawnProjectileCounterSimulated
    /// </summary>
    public unsafe virtual void ClientSpawnProjectileCounterSimulated(BmSDK.BmGame.RBMCombatThrownObject ThrownObject)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientSpawnProjectileCounterSimulated, "BmGame.RPawnPlayerCombat.ClientSpawnProjectileCounterSimulated");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownObject, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnProjectileCounterSimulated;
    /// <summary>
    /// Function: SpawnProjectileCounterSimulated
    /// </summary>
    public unsafe virtual void SpawnProjectileCounterSimulated(BmSDK.BmGame.RBMCombatThrownObject ThrownObject)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnProjectileCounterSimulated, "BmGame.RPawnPlayerCombat.SpawnProjectileCounterSimulated");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownObject, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnProjectileCounter;
    /// <summary>
    /// Function: SpawnProjectileCounter
    /// </summary>
    public unsafe virtual void SpawnProjectileCounter(BmSDK.BmGame.RBMCombatThrownObject ThrownObject)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnProjectileCounter, "BmGame.RPawnPlayerCombat.SpawnProjectileCounter");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownObject, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetProjectileCounterClass;
    /// <summary>
    /// Function: GetProjectileCounterClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetProjectileCounterClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProjectileCounterClass, "BmGame.RPawnPlayerCombat.GetProjectileCounterClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpawnCounter;
    /// <summary>
    /// Function: SpawnCounter
    /// </summary>
    public unsafe virtual void SpawnCounter(BmSDK.BmGame.RPawnVillain TargetPawn, BmSDK.Class CounterDmgType, float TimeInitiatedByPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnCounter, "BmGame.RPawnPlayerCombat.SpawnCounter");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CounterDmgType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeInitiatedByPlayer, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRedirectStumbleBehaviour;
    /// <summary>
    /// Function: GetRedirectStumbleBehaviour
    /// </summary>
    public unsafe virtual BmSDK.Class GetRedirectStumbleBehaviour()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRedirectStumbleBehaviour, "BmGame.RPawnPlayerCombat.GetRedirectStumbleBehaviour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CounterClass;
    /// <summary>
    /// Function: CounterClass
    /// </summary>
    public unsafe virtual BmSDK.Class CounterClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CounterClass, "BmGame.RPawnPlayerCombat.CounterClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpawnStrike;
    /// <summary>
    /// Function: SpawnStrike
    /// </summary>
    public unsafe virtual void SpawnStrike(BmSDK.Class StrikeClass, BmSDK.Class dmgType, bool bSetTarget = default, BmSDK.BmGame.RPawnVillain TargetPawn = default, float TimeInitiatedByPlayer = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnStrike, "BmGame.RPawnPlayerCombat.SpawnStrike");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSetTarget, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeInitiatedByPlayer, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnBatclawSlam;
    /// <summary>
    /// Function: SpawnBatclawSlam
    /// </summary>
    public unsafe virtual void SpawnBatclawSlam(BmSDK.BmGame.RPawnCombat TargetPawn, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnBatclawSlam, "BmGame.RPawnPlayerCombat.SpawnBatclawSlam");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnStrikeCore;
    /// <summary>
    /// Function: SpawnStrikeCore
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RCombatMove_BatmanStrike SpawnStrikeCore(BmSDK.Class StrikeClass, BmSDK.Class dmgType, bool bSetTarget, BmSDK.BmGame.RPawnVillain TargetPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnStrikeCore, "BmGame.RPawnPlayerCombat.SpawnStrikeCore");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSetTarget, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCombatMove_BatmanStrike>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_SpawnMove;
    /// <summary>
    /// Function: SpawnMove
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RCombatMove_BatmanStrike SpawnMove(BmSDK.Class StrikeClass)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnMove, "BmGame.RPawnPlayerCombat.SpawnMove");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCombatMove_BatmanStrike>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PreventedWalkingOverLedge;
    /// <summary>
    /// Function: PreventedWalkingOverLedge
    /// </summary>
    public unsafe override void PreventedWalkingOverLedge()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreventedWalkingOverLedge, "BmGame.RPawnPlayerCombat.PreventedWalkingOverLedge");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DamageCollisionWithObject;
    /// <summary>
    /// Function: DamageCollisionWithObject
    /// </summary>
    public unsafe override void DamageCollisionWithObject(BmSDK.Engine.Actor Object)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamageCollisionWithObject, "BmGame.RPawnPlayerCombat.DamageCollisionWithObject");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Object, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanNewAttackBeStarted;
    /// <summary>
    /// Function: CanNewAttackBeStarted
    /// </summary>
    public unsafe override bool CanNewAttackBeStarted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanNewAttackBeStarted, "BmGame.RPawnPlayerCombat.CanNewAttackBeStarted");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAfterCombatAnimset;
    /// <summary>
    /// Function: GetAfterCombatAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetAfterCombatAnimset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAfterCombatAnimset, "BmGame.RPawnPlayerCombat.GetAfterCombatAnimset");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAfterCombatAnim;
    /// <summary>
    /// Function: GetAfterCombatAnim
    /// </summary>
    public unsafe virtual BmSDK.FName GetAfterCombatAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAfterCombatAnim, "BmGame.RPawnPlayerCombat.GetAfterCombatAnim");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StartFinishedCombatMove;
    /// <summary>
    /// Function: StartFinishedCombatMove
    /// </summary>
    public unsafe virtual void StartFinishedCombatMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartFinishedCombatMove, "BmGame.RPawnPlayerCombat.StartFinishedCombatMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPunch;
    /// <summary>
    /// Function: IsPunch
    /// </summary>
    public unsafe virtual bool IsPunch(BmSDK.BmGame.RPawnCombat.BoneNameList TestBoneName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPunch, "BmGame.RPawnPlayerCombat.IsPunch");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestBoneName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_DisableAllCombatTakedowns;
    /// <summary>
    /// Function: DisableAllCombatTakedowns
    /// </summary>
    public unsafe virtual void DisableAllCombatTakedowns()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableAllCombatTakedowns, "BmGame.RPawnPlayerCombat.DisableAllCombatTakedowns");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableAllCombatTakedowns;
    /// <summary>
    /// Function: EnableAllCombatTakedowns
    /// </summary>
    public unsafe virtual void EnableAllCombatTakedowns()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableAllCombatTakedowns, "BmGame.RPawnPlayerCombat.EnableAllCombatTakedowns");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableAllSimultaneousCounters;
    /// <summary>
    /// Function: DisableAllSimultaneousCounters
    /// </summary>
    public unsafe virtual void DisableAllSimultaneousCounters()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableAllSimultaneousCounters, "BmGame.RPawnPlayerCombat.DisableAllSimultaneousCounters");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableAllSimultaneousCounters;
    /// <summary>
    /// Function: EnableAllSimultaneousCounters
    /// </summary>
    public unsafe virtual void EnableAllSimultaneousCounters()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableAllSimultaneousCounters, "BmGame.RPawnPlayerCombat.EnableAllSimultaneousCounters");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableAllCounters;
    /// <summary>
    /// Function: DisableAllCounters
    /// </summary>
    public unsafe virtual void DisableAllCounters()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableAllCounters, "BmGame.RPawnPlayerCombat.DisableAllCounters");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableAllCounters;
    /// <summary>
    /// Function: EnableAllCounters
    /// </summary>
    public unsafe virtual void EnableAllCounters()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableAllCounters, "BmGame.RPawnPlayerCombat.EnableAllCounters");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableAllStrikes;
    /// <summary>
    /// Function: DisableAllStrikes
    /// </summary>
    public unsafe virtual void DisableAllStrikes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableAllStrikes, "BmGame.RPawnPlayerCombat.DisableAllStrikes");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableAllStrikes;
    /// <summary>
    /// Function: EnableAllStrikes
    /// </summary>
    public unsafe virtual void EnableAllStrikes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableAllStrikes, "BmGame.RPawnPlayerCombat.EnableAllStrikes");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetStrikeContactTime;
    /// <summary>
    /// Function: GetStrikeContactTime
    /// </summary>
    public unsafe virtual float GetStrikeContactTime(BmSDK.Engine.AnimSequence StrikeAnimSequence)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeContactTime, "BmGame.RPawnPlayerCombat.GetStrikeContactTime");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeAnimSequence, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetNumberOfCounterHits;
    /// <summary>
    /// Function: GetNumberOfCounterHits
    /// </summary>
    public unsafe override int GetNumberOfCounterHits(BmSDK.Engine.AnimSequence StrikeAnimSequence, out BmSDK.TArray<float> SlowMoHitTimes)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumberOfCounterHits, "BmGame.RPawnPlayerCombat.GetNumberOfCounterHits");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeAnimSequence, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        SlowMoHitTimes = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<float>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetBoneNameFromBoneList;
    /// <summary>
    /// Function: GetBoneNameFromBoneList
    /// </summary>
    public unsafe override BmSDK.FName GetBoneNameFromBoneList(BmSDK.BmGame.RPawnCombat.BoneNameList BoneID, bool bMirrored = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBoneNameFromBoneList, "BmGame.RPawnPlayerCombat.GetBoneNameFromBoneList");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMirrored, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_MirrorBoneNameList;
    /// <summary>
    /// Function: MirrorBoneNameList
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat.BoneNameList MirrorBoneNameList(BmSDK.BmGame.RPawnCombat.BoneNameList OriginalBone)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MirrorBoneNameList, "BmGame.RPawnPlayerCombat.MirrorBoneNameList");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OriginalBone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.BoneNameList>(paramsPtr + 1);
    }

    private static BmSDK.Function __fn_GetPrevStrikeInfo;
    /// <summary>
    /// Function: GetPrevStrikeInfo
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo GetPrevStrikeInfo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPrevStrikeInfo, "BmGame.RPawnPlayerCombat.GetPrevStrikeInfo");
        byte* paramsPtr = stackalloc byte[140];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearStrikeInfo;
    /// <summary>
    /// Function: ClearStrikeInfo
    /// </summary>
    public unsafe virtual void ClearStrikeInfo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearStrikeInfo, "BmGame.RPawnPlayerCombat.ClearStrikeInfo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPrevStrikeInfo;
    /// <summary>
    /// Function: SetPrevStrikeInfo
    /// </summary>
    public unsafe virtual void SetPrevStrikeInfo(BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo OldStrikeInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPrevStrikeInfo, "BmGame.RPawnPlayerCombat.SetPrevStrikeInfo");
        byte* paramsPtr = stackalloc byte[140];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldStrikeInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeactivateChargeFX;
    /// <summary>
    /// Function: DeactivateChargeFX
    /// </summary>
    public unsafe virtual void DeactivateChargeFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeactivateChargeFX, "BmGame.RPawnPlayerCombat.DeactivateChargeFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateChargeFX;
    /// <summary>
    /// Function: ActivateChargeFX
    /// </summary>
    public unsafe virtual void ActivateChargeFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateChargeFX, "BmGame.RPawnPlayerCombat.ActivateChargeFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldBeDodged;
    /// <summary>
    /// Function: ShouldBeDodged
    /// </summary>
    public unsafe override bool ShouldBeDodged()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldBeDodged, "BmGame.RPawnPlayerCombat.ShouldBeDodged");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TargettingDebug;
    /// <summary>
    /// Function: TargettingDebug
    /// </summary>
    public unsafe virtual void TargettingDebug()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TargettingDebug, "BmGame.RPawnPlayerCombat.TargettingDebug");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsValidClosePawnForStrike;
    /// <summary>
    /// Function: IsValidClosePawnForStrike
    /// </summary>
    public unsafe virtual bool IsValidClosePawnForStrike(BmSDK.BmGame.RPawnVillain TestPawn, BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidClosePawnForStrike, "BmGame.RPawnPlayerCombat.IsValidClosePawnForStrike");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FindValidCloseStrikeTargetsHelper;
    /// <summary>
    /// Function: FindValidCloseStrikeTargetsHelper
    /// </summary>
    public unsafe virtual void FindValidCloseStrikeTargetsHelper(out BmSDK.TArray<BmSDK.BmGame.RPawnVillain> PawnList, BmSDK.TArray<BmSDK.BmGame.RPawnVillain> InList, BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindValidCloseStrikeTargetsHelper, "BmGame.RPawnPlayerCombat.FindValidCloseStrikeTargetsHelper");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InList, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PawnList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_FindValidCloseStrikeTargets;
    /// <summary>
    /// Function: FindValidCloseStrikeTargets
    /// </summary>
    public unsafe virtual void FindValidCloseStrikeTargets(out BmSDK.TArray<BmSDK.BmGame.RPawnVillain> PawnList, BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindValidCloseStrikeTargets, "BmGame.RPawnPlayerCombat.FindValidCloseStrikeTargets");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PawnList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_FindHighestPriorityClosePawn;
    /// <summary>
    /// Function: FindHighestPriorityClosePawn
    /// </summary>
    public unsafe virtual bool FindHighestPriorityClosePawn(BmSDK.Class DamageType, out BmSDK.BmGame.RPawnVillain BestPawn, float MaxDist)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindHighestPriorityClosePawn, "BmGame.RPawnPlayerCombat.FindHighestPriorityClosePawn");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BestPawn);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BestPawn, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxDist, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BestPawn = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnVillain>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_FindClosestPawnForStrike;
    /// <summary>
    /// Function: FindClosestPawnForStrike
    /// </summary>
    public unsafe virtual bool FindClosestPawnForStrike(BmSDK.Class DamageType, out float ClosestDist, out BmSDK.BmGame.RPawnVillain ClosestPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindClosestPawnForStrike, "BmGame.RPawnPlayerCombat.FindClosestPawnForStrike");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ClosestDist);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClosestDist, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ClosestPawn);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClosestPawn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ClosestDist = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        ClosestPawn = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnVillain>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_InputHeading;
    /// <summary>
    /// Function: InputHeading
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 InputHeading()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InputHeading, "BmGame.RPawnPlayerCombat.InputHeading");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFloorTakedownType;
    /// <summary>
    /// Function: GetFloorTakedownType
    /// </summary>
    public unsafe virtual BmSDK.Class GetFloorTakedownType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFloorTakedownType, "BmGame.RPawnPlayerCombat.GetFloorTakedownType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetQuickStrikeDamageType;
    /// <summary>
    /// Function: GetQuickStrikeDamageType
    /// </summary>
    public unsafe virtual BmSDK.Class GetQuickStrikeDamageType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetQuickStrikeDamageType, "BmGame.RPawnPlayerCombat.GetQuickStrikeDamageType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetQuickStrikeType;
    /// <summary>
    /// Function: GetQuickStrikeType
    /// </summary>
    public unsafe virtual BmSDK.Class GetQuickStrikeType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetQuickStrikeType, "BmGame.RPawnPlayerCombat.GetQuickStrikeType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHeavyStrikeType;
    /// <summary>
    /// Function: GetHeavyStrikeType
    /// </summary>
    public unsafe virtual BmSDK.Class GetHeavyStrikeType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeavyStrikeType, "BmGame.RPawnPlayerCombat.GetHeavyStrikeType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRunningStrikeClass;
    /// <summary>
    /// Function: GetRunningStrikeClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetRunningStrikeClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRunningStrikeClass, "BmGame.RPawnPlayerCombat.GetRunningStrikeClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHeavyStrikeDamageType;
    /// <summary>
    /// Function: GetHeavyStrikeDamageType
    /// </summary>
    public unsafe virtual BmSDK.Class GetHeavyStrikeDamageType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeavyStrikeDamageType, "BmGame.RPawnPlayerCombat.GetHeavyStrikeDamageType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCriticalStrikeDamageType;
    /// <summary>
    /// Function: GetCriticalStrikeDamageType
    /// </summary>
    public unsafe virtual BmSDK.Class GetCriticalStrikeDamageType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCriticalStrikeDamageType, "BmGame.RPawnPlayerCombat.GetCriticalStrikeDamageType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCounterCriticalStrikeDamageType;
    /// <summary>
    /// Function: GetCounterCriticalStrikeDamageType
    /// </summary>
    public unsafe virtual BmSDK.Class GetCounterCriticalStrikeDamageType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCounterCriticalStrikeDamageType, "BmGame.RPawnPlayerCombat.GetCounterCriticalStrikeDamageType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStunMove;
    /// <summary>
    /// Function: GetStunMove
    /// </summary>
    public unsafe virtual BmSDK.Class GetStunMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStunMove, "BmGame.RPawnPlayerCombat.GetStunMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ForceAttack;
    /// <summary>
    /// Function: ForceAttack
    /// </summary>
    public unsafe override bool ForceAttack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceAttack, "BmGame.RPawnPlayerCombat.ForceAttack");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckDodge;
    /// <summary>
    /// Function: CheckDodge
    /// </summary>
    public unsafe override void CheckDodge(BmSDK.BmGame.RPawnCombat Attacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckDodge, "BmGame.RPawnPlayerCombat.CheckDodge");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayHandbuffBreakCamera;
    /// <summary>
    /// Function: PlayHandbuffBreakCamera
    /// </summary>
    public unsafe virtual void PlayHandbuffBreakCamera(System.Numerics.Vector3 Loc, BmSDK.Rotator Rot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHandbuffBreakCamera, "BmGame.RPawnPlayerCombat.PlayHandbuffBreakCamera");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatMoveFinished;
    /// <summary>
    /// Function: CombatMoveFinished
    /// </summary>
    public unsafe override void CombatMoveFinished(BmSDK.BmGame.RCombatMove FinishedMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatMoveFinished, "BmGame.RPawnPlayerCombat.CombatMoveFinished");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatMoveInitialised;
    /// <summary>
    /// Function: CombatMoveInitialised
    /// </summary>
    public unsafe override void CombatMoveInitialised(BmSDK.BmGame.RCombatMove NewMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatMoveInitialised, "BmGame.RPawnPlayerCombat.CombatMoveInitialised");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddCombatAnimSetOverridesToWeaponConfig;
    /// <summary>
    /// Function: AddCombatAnimSetOverridesToWeaponConfig
    /// </summary>
    public unsafe virtual void AddCombatAnimSetOverridesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCombatAnimSetOverridesToWeaponConfig, "BmGame.RPawnPlayerCombat.AddCombatAnimSetOverridesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateCombatWeaponConfig;
    /// <summary>
    /// Function: CreateCombatWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateCombatWeaponConfig()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateCombatWeaponConfig, "BmGame.RPawnPlayerCombat.CreateCombatWeaponConfig");
        byte* paramsPtr = stackalloc byte[5272];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CreateUnarmedWeaponConfig;
    /// <summary>
    /// Function: CreateUnarmedWeaponConfig
    /// </summary>
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateUnarmedWeaponConfig()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateUnarmedWeaponConfig, "BmGame.RPawnPlayerCombat.CreateUnarmedWeaponConfig");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ApplyDamage;
    /// <summary>
    /// Function: ApplyDamage
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult ApplyDamage(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyDamage, "BmGame.RPawnPlayerCombat.ApplyDamage");
        byte* paramsPtr = stackalloc byte[280];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 256);
    }

    private static BmSDK.Function __fn_AddDamageGivenHistory;
    /// <summary>
    /// Function: AddDamageGivenHistory
    /// </summary>
    public unsafe override void AddDamageGivenHistory(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo, BmSDK.BmGame.RPawnCombat Victim)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDamageGivenHistory, "BmGame.RPawnPlayerCombat.AddDamageGivenHistory");
        byte* paramsPtr = stackalloc byte[276];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 256);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DamagedBy;
    /// <summary>
    /// Function: DamagedBy
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult DamagedBy(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamagedBy, "BmGame.RPawnPlayerCombat.DamagedBy");
        byte* paramsPtr = stackalloc byte[281];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 256);
    }

    private static BmSDK.Function __fn_ServerApplyDamage;
    /// <summary>
    /// Function: ServerApplyDamage
    /// </summary>
    public unsafe virtual void ServerApplyDamage(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerApplyDamage, "BmGame.RPawnPlayerCombat.ServerApplyDamage");
        byte* paramsPtr = stackalloc byte[272];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Zapped;
    /// <summary>
    /// Function: Zapped
    /// </summary>
    public unsafe virtual void Zapped()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Zapped, "BmGame.RPawnPlayerCombat.Zapped");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Stunned;
    /// <summary>
    /// Function: Stunned
    /// </summary>
    public unsafe override void Stunned()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Stunned, "BmGame.RPawnPlayerCombat.Stunned");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisplayTakedownInfo;
    /// <summary>
    /// Function: DisplayTakedownInfo
    /// </summary>
    public unsafe virtual void DisplayTakedownInfo(BmSDK.BmGame.RPawnPlayerCombat.FTakedownInfo DispInf)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayTakedownInfo, "BmGame.RPawnPlayerCombat.DisplayTakedownInfo");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DispInf, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisplayAutoDetectedTakedowns;
    /// <summary>
    /// Function: DisplayAutoDetectedTakedowns
    /// </summary>
    public unsafe virtual void DisplayAutoDetectedTakedowns()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayAutoDetectedTakedowns, "BmGame.RPawnPlayerCombat.DisplayAutoDetectedTakedowns");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisplayCounterInfo;
    /// <summary>
    /// Function: DisplayCounterInfo
    /// </summary>
    public unsafe virtual void DisplayCounterInfo(BmSDK.BmGame.RPawnPlayerCombat.FCounterInfo DispInf)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayCounterInfo, "BmGame.RPawnPlayerCombat.DisplayCounterInfo");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DispInf, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisplayAutoDetectedCounters;
    /// <summary>
    /// Function: DisplayAutoDetectedCounters
    /// </summary>
    public unsafe virtual void DisplayAutoDetectedCounters()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayAutoDetectedCounters, "BmGame.RPawnPlayerCombat.DisplayAutoDetectedCounters");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisplayStrikeInfo;
    /// <summary>
    /// Function: DisplayStrikeInfo
    /// </summary>
    public unsafe virtual void DisplayStrikeInfo(BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo DispInf)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayStrikeInfo, "BmGame.RPawnPlayerCombat.DisplayStrikeInfo");
        byte* paramsPtr = stackalloc byte[140];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DispInf, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisplayAutoDetectedStrikeTimes;
    /// <summary>
    /// Function: DisplayAutoDetectedStrikeTimes
    /// </summary>
    public unsafe virtual void DisplayAutoDetectedStrikeTimes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayAutoDetectedStrikeTimes, "BmGame.RPawnPlayerCombat.DisplayAutoDetectedStrikeTimes");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisplayAutoDetectedStrikes;
    /// <summary>
    /// Function: DisplayAutoDetectedStrikes
    /// </summary>
    public unsafe virtual void DisplayAutoDetectedStrikes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayAutoDetectedStrikes, "BmGame.RPawnPlayerCombat.DisplayAutoDetectedStrikes");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PossessedBy;
    /// <summary>
    /// Function: PossessedBy
    /// </summary>
    public unsafe override void PossessedBy(BmSDK.Engine.Controller C, bool bVehicleTransition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PossessedBy, "BmGame.RPawnPlayerCombat.PossessedBy");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVehicleTransition, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemovePairedAnimset;
    /// <summary>
    /// Function: RemovePairedAnimset
    /// </summary>
    public unsafe virtual void RemovePairedAnimset(BmSDK.Engine.AnimSet RemoveAnimset)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemovePairedAnimset, "BmGame.RPawnPlayerCombat.RemovePairedAnimset");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemoveAnimset, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddPairedAnimset;
    /// <summary>
    /// Function: AddPairedAnimset
    /// </summary>
    public unsafe virtual void AddPairedAnimset(BmSDK.Engine.AnimSet NewAnimSet, BmSDK.Engine.AnimSet NewCounterAnimSet, BmSDK.Engine.AnimSet NewTakedownAnimSet = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPairedAnimset, "BmGame.RPawnPlayerCombat.AddPairedAnimset");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAnimSet, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCounterAnimSet, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTakedownAnimSet, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeInitAttackMoveWeaponsFromFinishSpecialMove;
    /// <summary>
    /// Function: DeInitAttackMoveWeaponsFromFinishSpecialMove
    /// </summary>
    public unsafe virtual void DeInitAttackMoveWeaponsFromFinishSpecialMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeInitAttackMoveWeaponsFromFinishSpecialMove, "BmGame.RPawnPlayerCombat.DeInitAttackMoveWeaponsFromFinishSpecialMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeInitAttackMoveWeaponsFromCancelSpecialMove;
    /// <summary>
    /// Function: DeInitAttackMoveWeaponsFromCancelSpecialMove
    /// </summary>
    public unsafe virtual void DeInitAttackMoveWeaponsFromCancelSpecialMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeInitAttackMoveWeaponsFromCancelSpecialMove, "BmGame.RPawnPlayerCombat.DeInitAttackMoveWeaponsFromCancelSpecialMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeInitAttackMoveWeapons;
    /// <summary>
    /// Function: DeInitAttackMoveWeapons
    /// </summary>
    public unsafe override void DeInitAttackMoveWeapons()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeInitAttackMoveWeapons, "BmGame.RPawnPlayerCombat.DeInitAttackMoveWeapons");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitAttackMoveWeapons;
    /// <summary>
    /// Function: InitAttackMoveWeapons
    /// </summary>
    public unsafe override void InitAttackMoveWeapons(bool bMirrored)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitAttackMoveWeapons, "BmGame.RPawnPlayerCombat.InitAttackMoveWeapons");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMirrored, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Died, "BmGame.RPawnPlayerCombat.Died");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RPawnPlayerCombat.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OverrideHitReaction;
    /// <summary>
    /// Function: OverrideHitReaction
    /// </summary>
    public unsafe virtual bool OverrideHitReaction(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideHitReaction, "BmGame.RPawnPlayerCombat.OverrideHitReaction");
        byte* paramsPtr = stackalloc byte[276];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 256);
    }

    private static BmSDK.Function __fn_GetCameraStopNotify;
    /// <summary>
    /// Function: GetCameraStopNotify
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MAnimNotify_CameraStop GetCameraStopNotify(BmSDK.Engine.AnimSequence AnimSeq, out float Time)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCameraStopNotify, "BmGame.RPawnPlayerCombat.GetCameraStopNotify");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSeq, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Time);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Time = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MAnimNotify_CameraStop>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetCameraStartNotify;
    /// <summary>
    /// Function: GetCameraStartNotify
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MAnimNotify_CameraStart GetCameraStartNotify(BmSDK.Engine.AnimSequence AnimSeq, out float Time)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCameraStartNotify, "BmGame.RPawnPlayerCombat.GetCameraStartNotify");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSeq, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Time);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Time = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MAnimNotify_CameraStart>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanReceiveAttackFromPawn;
    /// <summary>
    /// Function: CanReceiveAttackFromPawn
    /// </summary>
    public unsafe override bool CanReceiveAttackFromPawn(BmSDK.BmGame.RPawnCombat NewAttacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanReceiveAttackFromPawn, "BmGame.RPawnPlayerCombat.CanReceiveAttackFromPawn");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttacker, paramsPtr + 0);
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

    private static BmSDK.Function __fn_OnAudioSourceCreate;
    /// <summary>
    /// Function: OnAudioSourceCreate
    /// </summary>
    public unsafe override void OnAudioSourceCreate(BmSDK.Engine.AkComponent akComp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAudioSourceCreate, "BmGame.RPawnPlayerCombat.OnAudioSourceCreate");
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

    private static BmSDK.Function __fn_SetPairedAnimAudioWeaponSwitch;
    /// <summary>
    /// Function: SetPairedAnimAudioWeaponSwitch
    /// </summary>
    public unsafe virtual void SetPairedAnimAudioWeaponSwitch(BmSDK.Engine.AkSwitchName SwitchName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPairedAnimAudioWeaponSwitch, "BmGame.RPawnPlayerCombat.SetPairedAnimAudioWeaponSwitch");
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

    private static BmSDK.Function __fn_GetForceToGiveToPawn;
    /// <summary>
    /// Function: GetForceToGiveToPawn
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetForceToGiveToPawn(BmSDK.BmGame.RPawnCombat Receiver, float MaxForce, float MinRange = default, float MaxRange = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetForceToGiveToPawn, "BmGame.RPawnPlayerCombat.GetForceToGiveToPawn");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Receiver, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxForce, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinRange, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxRange, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_FindHighestPriorityTarget;
    /// <summary>
    /// Function: FindHighestPriorityTarget
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor FindHighestPriorityTarget(BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FStrikeTargetInfo> TargetList, System.Numerics.Vector3 FacingDir, BmSDK.Class dmgType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindHighestPriorityTarget, "BmGame.RPawnPlayerCombat.FindHighestPriorityTarget");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetList, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FacingDir, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_AssignTargetScores;
    /// <summary>
    /// Function: AssignTargetScores
    /// </summary>
    public unsafe virtual void AssignTargetScores(out BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FStrikeTargetInfo> TargetList, System.Numerics.Vector3 FacingDir, BmSDK.Class dmgType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignTargetScores, "BmGame.RPawnPlayerCombat.AssignTargetScores");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FacingDir, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        TargetList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FStrikeTargetInfo>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveTargetsOutsideTargetCone;
    /// <summary>
    /// Function: RemoveTargetsOutsideTargetCone
    /// </summary>
    public unsafe virtual void RemoveTargetsOutsideTargetCone(out BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FStrikeTargetInfo> TargetList, float MaxDist, float MaxVenomDist, System.Numerics.Vector3 FacingDir, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveTargetsOutsideTargetCone, "BmGame.RPawnPlayerCombat.RemoveTargetsOutsideTargetCone");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxDist, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxVenomDist, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FacingDir, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        TargetList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FStrikeTargetInfo>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_IsValidFacingActorForStrike;
    /// <summary>
    /// Function: IsValidFacingActorForStrike
    /// </summary>
    public unsafe virtual bool IsValidFacingActorForStrike(BmSDK.BmGame.RPawnVillain TestPawn, float MaxDist, float MaxVenomDist, System.Numerics.Vector3 FacingDir, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidFacingActorForStrike, "BmGame.RPawnPlayerCombat.IsValidFacingActorForStrike");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxDist, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxVenomDist, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FacingDir, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 24);
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

    private static BmSDK.Function __fn_FindValidFacingActorsForStrike;
    /// <summary>
    /// Function: FindValidFacingActorsForStrike
    /// </summary>
    public unsafe virtual void FindValidFacingActorsForStrike(out BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FStrikeTargetInfo> ValidTargets, float MaxDist, float MaxVenomDist, System.Numerics.Vector3 FacingDir, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindValidFacingActorsForStrike, "BmGame.RPawnPlayerCombat.FindValidFacingActorsForStrike");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxDist, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxVenomDist, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FacingDir, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ValidTargets = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FStrikeTargetInfo>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_FindFacingActorForStrike;
    /// <summary>
    /// Function: FindFacingActorForStrike
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor FindFacingActorForStrike(float MaxDist = default, float MaxVenomDist = default, System.Numerics.Vector3 FacingDir = default, BmSDK.Class dmgType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindFacingActorForStrike, "BmGame.RPawnPlayerCombat.FindFacingActorForStrike");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxDist, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxVenomDist, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FacingDir, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_IsValidTargetForStrike_Expensive;
    /// <summary>
    /// Function: IsValidTargetForStrike_Expensive
    /// </summary>
    public unsafe virtual bool IsValidTargetForStrike_Expensive(BmSDK.BmGame.RPawnVillain TestPawn, BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidTargetForStrike_Expensive, "BmGame.RPawnPlayerCombat.IsValidTargetForStrike_Expensive");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
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

    private static BmSDK.Function __fn_IsValidTargetForStrike_Cheap;
    /// <summary>
    /// Function: IsValidTargetForStrike_Cheap
    /// </summary>
    public unsafe virtual bool IsValidTargetForStrike_Cheap(BmSDK.BmGame.RPawnVillain TestPawn, BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidTargetForStrike_Cheap, "BmGame.RPawnPlayerCombat.IsValidTargetForStrike_Cheap");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
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

    private static BmSDK.Function __fn_RemoveDetectedWeaponDestroy;
    /// <summary>
    /// Function: RemoveDetectedWeaponDestroy
    /// </summary>
    public unsafe virtual void RemoveDetectedWeaponDestroy(BmSDK.Engine.AnimSet RemoveAnimset)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveDetectedWeaponDestroy, "BmGame.RPawnPlayerCombat.RemoveDetectedWeaponDestroy");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemoveAnimset, paramsPtr + 0);
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

    private static BmSDK.Function __fn_RemoveDetectedThrows;
    /// <summary>
    /// Function: RemoveDetectedThrows
    /// </summary>
    public unsafe virtual void RemoveDetectedThrows(BmSDK.Engine.AnimSet RemoveAnimset)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveDetectedThrows, "BmGame.RPawnPlayerCombat.RemoveDetectedThrows");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemoveAnimset, paramsPtr + 0);
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

    private static BmSDK.Function __fn_RemoveDetectedTakedowns;
    /// <summary>
    /// Function: RemoveDetectedTakedowns
    /// </summary>
    public unsafe virtual void RemoveDetectedTakedowns(BmSDK.Engine.AnimSet RemoveAnimset)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveDetectedTakedowns, "BmGame.RPawnPlayerCombat.RemoveDetectedTakedowns");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemoveAnimset, paramsPtr + 0);
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

    private static BmSDK.Function __fn_RemoveDetectedCounters;
    /// <summary>
    /// Function: RemoveDetectedCounters
    /// </summary>
    public unsafe virtual void RemoveDetectedCounters(BmSDK.Engine.AnimSet RemoveAnimset)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveDetectedCounters, "BmGame.RPawnPlayerCombat.RemoveDetectedCounters");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemoveAnimset, paramsPtr + 0);
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

    private static BmSDK.Function __fn_RemoveDetectedStrikes;
    /// <summary>
    /// Function: RemoveDetectedStrikes
    /// </summary>
    public unsafe virtual void RemoveDetectedStrikes(BmSDK.Engine.AnimSet RemoveAnimset)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveDetectedStrikes, "BmGame.RPawnPlayerCombat.RemoveDetectedStrikes");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemoveAnimset, paramsPtr + 0);
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

    private static BmSDK.Function __fn_DetectWeaponDestroy;
    /// <summary>
    /// Function: DetectWeaponDestroy
    /// </summary>
    public unsafe virtual void DetectWeaponDestroy(BmSDK.Engine.AnimSet NewWeaponDestroyAnimSet, BmSDK.Engine.AnimSet NewWeaponDestroyTargetAnimSet)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetectWeaponDestroy, "BmGame.RPawnPlayerCombat.DetectWeaponDestroy");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeaponDestroyAnimSet, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeaponDestroyTargetAnimSet, paramsPtr + 4);
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

    private static BmSDK.Function __fn_DetectThrows;
    /// <summary>
    /// Function: DetectThrows
    /// </summary>
    public unsafe virtual void DetectThrows(BmSDK.Engine.AnimSet NewThrowAnimSet, BmSDK.Engine.AnimSet NewThrowTargetAnimSet)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetectThrows, "BmGame.RPawnPlayerCombat.DetectThrows");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewThrowAnimSet, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewThrowTargetAnimSet, paramsPtr + 4);
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

    private static BmSDK.Function __fn_DetectTakedowns;
    /// <summary>
    /// Function: DetectTakedowns
    /// </summary>
    public unsafe virtual void DetectTakedowns(BmSDK.Engine.AnimSet NewTakedownAnimSet, BmSDK.Engine.AnimSet NewTakedownTargetAnimSet)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetectTakedowns, "BmGame.RPawnPlayerCombat.DetectTakedowns");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTakedownAnimSet, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTakedownTargetAnimSet, paramsPtr + 4);
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

    private static BmSDK.Function __fn_DetectCounters;
    /// <summary>
    /// Function: DetectCounters
    /// </summary>
    public unsafe virtual void DetectCounters(BmSDK.Engine.AnimSet NewCounterAnimSet, BmSDK.Engine.AnimSet NewCounterTargetAnimSet)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetectCounters, "BmGame.RPawnPlayerCombat.DetectCounters");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCounterAnimSet, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCounterTargetAnimSet, paramsPtr + 4);
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

    private static BmSDK.Function __fn_DetectStrikes;
    /// <summary>
    /// Function: DetectStrikes
    /// </summary>
    public unsafe virtual void DetectStrikes(BmSDK.Engine.AnimSet NewStrikeAnimSet)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetectStrikes, "BmGame.RPawnPlayerCombat.DetectStrikes");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewStrikeAnimSet, paramsPtr + 0);
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
    /// Struct: FWeaponDestroyInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FWeaponDestroyInfo
    {
        /// <summary>
        /// ObjectProperty: WeaponDestroyAnimset
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet WeaponDestroyAnimset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: WeaponDestroyTargetAnimset
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet WeaponDestroyTargetAnimset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// NameProperty: WeaponDestroyAnimName
        /// </summary>
        public unsafe BmSDK.FName WeaponDestroyAnimName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ByteProperty: WeaponDestroyType
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayerCombat.EWeaponDestroyType WeaponDestroyType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.EWeaponDestroyType>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ArrayProperty: DetachBoneList
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> DetachBoneList
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// BoolProperty: bActive
        /// </summary>
        public unsafe bool bActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }
    }

    /// <summary>
    /// Enum: EWeaponDestroyType
    /// </summary>
    public enum EWeaponDestroyType : byte
    {
        WDL_Unarmed = 0,
        WDT_Bat = 1,
        WDT_Pipe = 2,
        WDT_StunStick = 3,
        WDT_Gun = 4,
        WDT_Knife = 5,
        WDT_Shield = 6,
        WDT_HeavyObject = 7,
        WDT_HeavyObjectFireExtinguisher = 8,
        WDT_HeavyObjectExplosive = 9,
        WDT_HeavyObjectCryoCannister = 10,
        EWeaponDestroyType_MAX = 11,
    }

    /// <summary>
    /// Struct: FThrowInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FThrowInfo
    {
        /// <summary>
        /// ObjectProperty: ThrowAnimset
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet ThrowAnimset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: ThrowTargetAnimset
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet ThrowTargetAnimset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// NameProperty: ThrowAnimName
        /// </summary>
        public unsafe BmSDK.FName ThrowAnimName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: TimeSinceUse
        /// </summary>
        public unsafe int TimeSinceUse
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// BoolProperty: bActive
        /// </summary>
        public unsafe bool bActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FTakedownInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial record struct FTakedownInfo
    {
        /// <summary>
        /// ObjectProperty: TakedownAnimset
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet TakedownAnimset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: TakedownTargetAnimset
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet TakedownTargetAnimset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// NameProperty: TakedownAnimName
        /// </summary>
        public unsafe BmSDK.FName TakedownAnimName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ByteProperty: TakedownSpeed
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayerCombat.ETakedownSpeed TakedownSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.ETakedownSpeed>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ByteProperty: TakedownType
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayerCombat.ETakedownType TakedownType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.ETakedownType>(Ptr + 17); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 17); }; }
        }

        /// <summary>
        /// ByteProperty: TakedownDamageBone
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnCombat.BoneNameList TakedownDamageBone
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.BoneNameList>(Ptr + 18); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18); }; }
        }

        /// <summary>
        /// BoolProperty: bIsShockGlove
        /// </summary>
        public unsafe bool bIsShockGlove
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 20); }; }
        }

        /// <summary>
        /// IntProperty: TimeSinceUse
        /// </summary>
        public unsafe int TimeSinceUse
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ByteProperty: GeneralMovement
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayerCombat.ETakedownMovement GeneralMovement
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.ETakedownMovement>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// IntProperty: CombatSetID
        /// </summary>
        public unsafe int CombatSetID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: bActive
        /// </summary>
        public unsafe bool bActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: bCanBeMirrored
        /// </summary>
        public unsafe bool bCanBeMirrored
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }
    }

    /// <summary>
    /// Enum: ETakedownMovement
    /// </summary>
    public enum ETakedownMovement : byte
    {
        TDM_None = 0,
        TDM_Forwards = 1,
        TDM_Backwards = 2,
        TDM_MAX = 3,
    }

    /// <summary>
    /// Enum: ETakedownType
    /// </summary>
    public enum ETakedownType : byte
    {
        TDT_Unarmed = 0,
        TDT_Pipe = 1,
        TDT_StunStick = 2,
        TDT_Gun = 3,
        TDT_Knife = 4,
        TDT_Shield = 5,
        TDT_Ninja = 6,
        TDT_MAX = 7,
    }

    /// <summary>
    /// Enum: ETakedownSpeed
    /// </summary>
    public enum ETakedownSpeed : byte
    {
        TS_Slow = 0,
        TS_Fast = 1,
        TS_MAX = 2,
    }

    /// <summary>
    /// Struct: FCounterInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public partial record struct FCounterInfo
    {
        /// <summary>
        /// ObjectProperty: CounterAnimset
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet CounterAnimset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: CounterTargetAnimset
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet CounterTargetAnimset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// NameProperty: CounterAnimName
        /// </summary>
        public unsafe BmSDK.FName CounterAnimName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ByteProperty: CounterLimb
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnCombat.CounterLimb CounterLimb
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.CounterLimb>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ByteProperty: CounterMoveDir
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayerCombat.CounterMoveDir CounterMoveDir
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.CounterMoveDir>(Ptr + 17); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 17); }; }
        }

        /// <summary>
        /// ByteProperty: CounterWallDir
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayerCombat.CounterEnvironmentDir CounterWallDir
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.CounterEnvironmentDir>(Ptr + 18); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18); }; }
        }

        /// <summary>
        /// ByteProperty: CounterRailDir
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayerCombat.CounterEnvironmentDir CounterRailDir
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.CounterEnvironmentDir>(Ptr + 19); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 19); }; }
        }

        /// <summary>
        /// ByteProperty: CounterStrength
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayerCombat.CounterStrength CounterStrength
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.CounterStrength>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// BoolProperty: bMovesBeyondTarget
        /// </summary>
        public unsafe bool bMovesBeyondTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }

        /// <summary>
        /// BoolProperty: bHandcuffed
        /// </summary>
        public unsafe bool bHandcuffed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }

        /// <summary>
        /// BoolProperty: bBreaksHandcuffs
        /// </summary>
        public unsafe bool bBreaksHandcuffs
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }

        /// <summary>
        /// BoolProperty: bIsShockGlovesCounter
        /// </summary>
        public unsafe bool bIsShockGlovesCounter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }

        /// <summary>
        /// IntProperty: TimeSinceUse
        /// </summary>
        public unsafe int TimeSinceUse
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// ByteProperty: CounterDamageBone
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnCombat.BoneNameList CounterDamageBone
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.BoneNameList>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// ByteProperty: CounterImpactBone
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnCombat.BoneNameList CounterImpactBone
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.BoneNameList>(Ptr + 33); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 33); }; }
        }

        /// <summary>
        /// ByteProperty: HitStrength
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayerCombat.HitStrength HitStrength
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.HitStrength>(Ptr + 34); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 34); }; }
        }

        /// <summary>
        /// IntProperty: UnlockChapter
        /// </summary>
        public unsafe int UnlockChapter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// IntProperty: CombatSetID
        /// </summary>
        public unsafe int CombatSetID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: bActive
        /// </summary>
        public unsafe bool bActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }; }
        }

        /// <summary>
        /// BoolProperty: bCanWindAnimation
        /// </summary>
        public unsafe bool bCanWindAnimation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }; }
        }

        /// <summary>
        /// BoolProperty: bCanKnockOverPawnsWhenRagdoll
        /// </summary>
        public unsafe bool bCanKnockOverPawnsWhenRagdoll
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }; }
        }

        /// <summary>
        /// BoolProperty: bCanBeUsedOnSlope
        /// </summary>
        public unsafe bool bCanBeUsedOnSlope
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }; }
        }

        /// <summary>
        /// NameProperty: DestCapeStateName
        /// </summary>
        public unsafe BmSDK.FName DestCapeStateName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// NameProperty: CapeAnimName
        /// </summary>
        public unsafe BmSDK.FName CapeAnimName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// BoolProperty: bMirrored
        /// </summary>
        public unsafe bool bMirrored
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }
    }

    /// <summary>
    /// Enum: CounterStrength
    /// </summary>
    public enum CounterStrength : byte
    {
        ECS_Weak = 0,
        ECS_Strong = 1,
        ECS_MAX = 2,
    }

    /// <summary>
    /// Enum: CounterEnvironmentDir
    /// </summary>
    public enum CounterEnvironmentDir : byte
    {
        ECED_None = 0,
        ECED_Front = 1,
        ECED_Back = 2,
        ECED_Left = 3,
        ECED_Right = 4,
        ECED_MAX = 5,
    }

    /// <summary>
    /// Enum: CounterMoveDir
    /// </summary>
    public enum CounterMoveDir : byte
    {
        ECD_Front = 0,
        ECD_Back = 1,
        ECD_MAX = 2,
    }

    /// <summary>
    /// Struct: FStrikeTargetInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial record struct FStrikeTargetInfo
    {
        /// <summary>
        /// ObjectProperty: TargetActor
        /// </summary>
        public unsafe BmSDK.Engine.Actor TargetActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: TargetOffset
        /// </summary>
        public unsafe System.Numerics.Vector3 TargetOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: TargetNormal
        /// </summary>
        public unsafe System.Numerics.Vector3 TargetNormal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: TargetDist
        /// </summary>
        public unsafe float TargetDist
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: TargetScore
        /// </summary>
        public unsafe float TargetScore
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: bObscured
        /// </summary>
        public unsafe bool bObscured
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: bVenom
        /// </summary>
        public unsafe bool bVenom
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }
    }

    /// <summary>
    /// Struct: FStrikeInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 124)]
    public partial record struct FStrikeInfo
    {
        /// <summary>
        /// NameProperty: StrikeAnimName
        /// </summary>
        public unsafe BmSDK.FName StrikeAnimName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: StrikeAnimSet
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet StrikeAnimSet
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ByteProperty: StrikeRange
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayerCombat.StrikeRange StrikeRange
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.StrikeRange>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ByteProperty: StrikeStrength
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayerCombat.StrikeStrength StrikeStrength
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.StrikeStrength>(Ptr + 13); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13); }; }
        }

        /// <summary>
        /// ByteProperty: StrikeHand
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayerCombat.StrikeHand StrikeHand
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.StrikeHand>(Ptr + 14); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14); }; }
        }

        /// <summary>
        /// ByteProperty: StrikeDirection
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayerCombat.StrikeDirection StrikeDirection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.StrikeDirection>(Ptr + 15); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 15); }; }
        }

        /// <summary>
        /// ByteProperty: StrikeDamageDirection
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayerCombat.StrikeDamageDirection StrikeDamageDirection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.StrikeDamageDirection>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ByteProperty: StrikeTurnMotion
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayerCombat.StrikeTurnMotion StrikeTurnMotion
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.StrikeTurnMotion>(Ptr + 17); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 17); }; }
        }

        /// <summary>
        /// ByteProperty: StrikeTargetType
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayerCombat.StrikeTargetType StrikeTargetType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.StrikeTargetType>(Ptr + 18); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18); }; }
        }

        /// <summary>
        /// ByteProperty: PrevStrikeHand
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayerCombat.StrikeHand PrevStrikeHand
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.StrikeHand>(Ptr + 19); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 19); }; }
        }

        /// <summary>
        /// ByteProperty: PrevStrikeTurnMotion
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayerCombat.StrikeTurnMotion PrevStrikeTurnMotion
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.StrikeTurnMotion>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// NameProperty: HitReactionAnimName
        /// </summary>
        public unsafe BmSDK.FName HitReactionAnimName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ByteProperty: Strike_PlayerStrikingBone
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnCombat.BoneNameList Strike_PlayerStrikingBone
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.BoneNameList>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// ByteProperty: Strike_TargetImpactBone
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnCombat.BoneNameList Strike_TargetImpactBone
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.BoneNameList>(Ptr + 33); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 33); }; }
        }

        /// <summary>
        /// FloatProperty: DamageCollisionRadius
        /// </summary>
        public unsafe float DamageCollisionRadius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: DamageCollisionDuration
        /// </summary>
        public unsafe float DamageCollisionDuration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// StructProperty: DamageCollisionProjection
        /// </summary>
        public unsafe System.Numerics.Vector3 DamageCollisionProjection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// StructProperty: DamageDirection
        /// </summary>
        public unsafe System.Numerics.Vector3 DamageDirection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// FloatProperty: DamageForceMultiplier
        /// </summary>
        public unsafe float DamageForceMultiplier
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// ByteProperty: DamageARF
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnCombat.AdditionalRagdollForce DamageARF
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.AdditionalRagdollForce>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// BoolProperty: bDisableTargetCollision
        /// </summary>
        public unsafe bool bDisableTargetCollision
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }; }
        }

        /// <summary>
        /// BoolProperty: bCanBeFinalBlow
        /// </summary>
        public unsafe bool bCanBeFinalBlow
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }; }
        }

        /// <summary>
        /// BoolProperty: bTravelsBeyondTarget
        /// </summary>
        public unsafe bool bTravelsBeyondTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }; }
        }

        /// <summary>
        /// BoolProperty: bCanPerformWithNoTarget
        /// </summary>
        public unsafe bool bCanPerformWithNoTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }; }
        }

        /// <summary>
        /// BoolProperty: bCanPerformOnBlocker
        /// </summary>
        public unsafe bool bCanPerformOnBlocker
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }; }
        }

        /// <summary>
        /// BoolProperty: bPrimeHitReaction
        /// </summary>
        public unsafe bool bPrimeHitReaction
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }; }
        }

        /// <summary>
        /// BoolProperty: bHitsLow
        /// </summary>
        public unsafe bool bHitsLow
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 64) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }; }
        }

        /// <summary>
        /// BoolProperty: bRemovesHelmet
        /// </summary>
        public unsafe bool bRemovesHelmet
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 128) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }; }
        }

        /// <summary>
        /// BoolProperty: bCanBeMirrored
        /// </summary>
        public unsafe bool bCanBeMirrored
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 256) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }; }
        }

        /// <summary>
        /// BoolProperty: bOverrideMovementExit
        /// </summary>
        public unsafe bool bOverrideMovementExit
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 512) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }; }
        }

        /// <summary>
        /// BoolProperty: bIsGadgetStrike
        /// </summary>
        public unsafe bool bIsGadgetStrike
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 1024) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }; }
        }

        /// <summary>
        /// BoolProperty: bIsShockGlove
        /// </summary>
        public unsafe bool bIsShockGlove
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 2048) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }; }
        }

        /// <summary>
        /// BoolProperty: bMirrored
        /// </summary>
        public unsafe bool bMirrored
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 4096) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }; }
        }

        /// <summary>
        /// FloatProperty: CapeAnimDelay
        /// </summary>
        public unsafe float CapeAnimDelay
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// FloatProperty: CapeStopAnimDelay
        /// </summary>
        public unsafe float CapeStopAnimDelay
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// NameProperty: DestCapeStateName
        /// </summary>
        public unsafe BmSDK.FName DestCapeStateName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }

        /// <summary>
        /// NameProperty: CapeAnimName
        /// </summary>
        public unsafe BmSDK.FName CapeAnimName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }

        /// <summary>
        /// ByteProperty: PreferredCamDir
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayerCombat.CameraDirection PreferredCamDir
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.CameraDirection>(Ptr + 104); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }; }
        }

        /// <summary>
        /// IntProperty: UnlockChapter
        /// </summary>
        public unsafe int UnlockChapter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }; }
        }

        /// <summary>
        /// IntProperty: CombatSetID
        /// </summary>
        public unsafe int CombatSetID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }; }
        }

        /// <summary>
        /// IntProperty: TimeSinceUse
        /// </summary>
        public unsafe int TimeSinceUse
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }; }
        }

        /// <summary>
        /// BoolProperty: bActive
        /// </summary>
        public unsafe bool bActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }; }
        }

        /// <summary>
        /// BoolProperty: bNoTrail
        /// </summary>
        public unsafe bool bNoTrail
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }; }
        }
    }

    /// <summary>
    /// Enum: StrikeTargetType
    /// </summary>
    public enum StrikeTargetType : byte
    {
        STT_Unarmed = 0,
        STT_Pipe = 1,
        STT_StunStick = 2,
        STT_Gun = 3,
        STT_Knife = 4,
        STT_Shield = 5,
        STT_Ninja = 6,
        STT_Penguin = 7,
        STT_MAX = 8,
    }

    /// <summary>
    /// Enum: StrikeTurnMotion
    /// </summary>
    public enum StrikeTurnMotion : byte
    {
        STM_None = 0,
        STM_Clockwise = 1,
        STM_CounterClockwise = 2,
        STM_MAX = 3,
    }

    /// <summary>
    /// Enum: StrikeDamageDirection
    /// </summary>
    public enum StrikeDamageDirection : byte
    {
        SDD_None = 0,
        SDD_HorizontalAcrossBody = 1,
        SDD_Vertical = 2,
        SDD_TopLeftToBottomRight = 3,
        SDD_TopRightToBottomLeft = 4,
        SDD_MAX = 5,
    }

    /// <summary>
    /// Enum: CameraDirection
    /// </summary>
    public enum CameraDirection : byte
    {
        CAM_None = 0,
        CAM_Left = 1,
        CAM_Right = 2,
        CAM_MAX = 3,
    }

    /// <summary>
    /// Enum: StrikeRange
    /// </summary>
    public enum StrikeRange : byte
    {
        SR_None = 0,
        SR_Close = 1,
        SR_Far = 2,
        SR_VeryClose = 3,
        SR_MAX = 4,
    }

    /// <summary>
    /// Enum: StrikeStrength
    /// </summary>
    public enum StrikeStrength : byte
    {
        SS_None = 0,
        SS_Weak = 1,
        SS_Strong = 2,
        SS_Stun = 3,
        SS_Run = 4,
        SS_Wall = 5,
        SS_BeatdownStart = 6,
        SS_Beatdown = 7,
        SS_BeatdownEnd = 8,
        SS_BeatdownEndEnv = 9,
        SS_GrabBeatdownStart = 10,
        SS_GrabBeatdown = 11,
        SS_GrabBeatdownEnd = 12,
        SS_GrabBeatdownEndEnv = 13,
        SS_Knife = 14,
        SS_SuperStun = 15,
        SS_SuperStunEnd = 16,
        SS_MAX = 17,
    }

    /// <summary>
    /// Enum: StrikeHand
    /// </summary>
    public enum StrikeHand : byte
    {
        SH_None = 0,
        SH_Left = 1,
        SH_Right = 2,
        SH_MAX = 3,
    }

    /// <summary>
    /// Enum: StrikeDirection
    /// </summary>
    public enum StrikeDirection : byte
    {
        SD_None = 0,
        SD_Front = 1,
        SD_Back = 2,
        SD_Left = 3,
        SD_Right = 4,
        SD_MAX = 5,
    }

    /// <summary>
    /// Enum: HitStrength
    /// </summary>
    public enum HitStrength : byte
    {
        HIT_Strong = 0,
        HIT_Weak = 1,
        HIT_Block = 2,
        HIT_Pipe = 3,
        HIT_MAX = 4,
    }

    /// <summary>
    /// StructProperty: CombatAnimRecord
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId CombatAnimRecord
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(Ptr + 2180);

    /// <summary>
    /// ComponentProperty: ChargeFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ChargeFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 2188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2188); }
    }

    /// <summary>
    /// BoolProperty: bChargingFXActive
    /// </summary>
    public unsafe bool bChargingFXActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2192) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2192); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2192); }
    }

    /// <summary>
    /// BoolProperty: bHas2Evades
    /// </summary>
    public unsafe bool bHas2Evades
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2192) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2192); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2192); }
    }

    /// <summary>
    /// BoolProperty: bBreakHandcuffsNextCounter
    /// </summary>
    public unsafe bool bBreakHandcuffsNextCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2192) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2192); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2192); }
    }

    /// <summary>
    /// BoolProperty: bAutoSetAllowMovementExit
    /// </summary>
    public unsafe bool bAutoSetAllowMovementExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2192) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2192); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2192); }
    }

    /// <summary>
    /// BoolProperty: bCausesOutcastsToFlee
    /// </summary>
    public unsafe bool bCausesOutcastsToFlee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2192) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2192); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2192); }
    }

    /// <summary>
    /// BoolProperty: bHoldingComboCombatWeapon
    /// </summary>
    public unsafe bool bHoldingComboCombatWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2192) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2192); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2192); }
    }

    /// <summary>
    /// BoolProperty: bIncreasedCombatPower
    /// </summary>
    public unsafe bool bIncreasedCombatPower
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2192) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2192); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2192); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreNextFinishedCombatMove
    /// </summary>
    public unsafe bool bIgnoreNextFinishedCombatMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2192) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2192); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2192); }
    }

    /// <summary>
    /// BoolProperty: bRegisteredBoss
    /// </summary>
    public unsafe bool bRegisteredBoss
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2192) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2192); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2192); }
    }

    /// <summary>
    /// BoolProperty: bSuspendKeepInView
    /// </summary>
    public unsafe bool bSuspendKeepInView
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2192) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2192); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2192); }
    }

    /// <summary>
    /// BoolProperty: bStrikeShouldMiss
    /// </summary>
    public unsafe bool bStrikeShouldMiss
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2192) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2192); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2192); }
    }

    /// <summary>
    /// BoolProperty: bShouldCancelFloorTakedown
    /// </summary>
    public unsafe bool bShouldCancelFloorTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2192) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2192); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2192); }
    }

    /// <summary>
    /// BoolProperty: bSpecialMovesDisabled
    /// </summary>
    public unsafe bool bSpecialMovesDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2192) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2192); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2192); }
    }

    /// <summary>
    /// ObjectProperty: ChargeRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform ChargeRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 2196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2196); }
    }

    /// <summary>
    /// FloatProperty: StrikePowerMultiplier
    /// </summary>
    public unsafe float StrikePowerMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2200); }
    }

    /// <summary>
    /// FloatProperty: FinalStrikePowerMultiplier
    /// </summary>
    public unsafe float FinalStrikePowerMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2204); }
    }

    /// <summary>
    /// NameProperty: LastAttackMoveClassName
    /// </summary>
    public unsafe BmSDK.FName LastAttackMoveClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2208); }
    }

    /// <summary>
    /// ObjectProperty: StunMoveProp
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh StunMoveProp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 2216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2216); }
    }

    /// <summary>
    /// ComponentProperty: StunFXComponent
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent StunFXComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 2220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2220); }
    }

    /// <summary>
    /// ObjectProperty: PreStrikeHitAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PreStrikeHitAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 2224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2224); }
    }

    /// <summary>
    /// ObjectProperty: VenomHitAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VenomHitAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 2228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2228); }
    }

    /// <summary>
    /// StructProperty: LastPylonCheckLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastPylonCheckLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2232);

    /// <summary>
    /// ObjectProperty: BlockBreakerPS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem BlockBreakerPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2244); }
    }

    /// <summary>
    /// ObjectProperty: SuperStrikePS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem SuperStrikePS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2248); }
    }

    /// <summary>
    /// ObjectProperty: ComboLevel0PS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ComboLevel0PS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2252); }
    }

    /// <summary>
    /// ObjectProperty: ComboLevel1PS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ComboLevel1PS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }
    }

    /// <summary>
    /// ObjectProperty: ComboLevel2PS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ComboLevel2PS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2260); }
    }

    /// <summary>
    /// ObjectProperty: HigherComboLevelPS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem HigherComboLevelPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2264); }
    }

    /// <summary>
    /// ArrayProperty: BoneNameListConversion
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BoneNameListConversion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 2268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2268); }
    }

    /// <summary>
    /// ArrayProperty: AutoStrikeList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo> AutoStrikeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo>>(Ptr + 2280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }
    }

    /// <summary>
    /// StructProperty: PrevStrikeInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo PrevStrikeInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo>(Ptr + 2292);

    /// <summary>
    /// ArrayProperty: PrevStrikeTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> PrevStrikeTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 2416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2416); }
    }

    /// <summary>
    /// ObjectProperty: LastBatclawTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain LastBatclawTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 2428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2428); }
    }

    /// <summary>
    /// ArrayProperty: PairedAnimsets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> PairedAnimsets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 2432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2432); }
    }

    /// <summary>
    /// ArrayProperty: CounterList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FCounterInfo> CounterList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FCounterInfo>>(Ptr + 2444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2444); }
    }

    /// <summary>
    /// ArrayProperty: TakedownList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FTakedownInfo> TakedownList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FTakedownInfo>>(Ptr + 2456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2456); }
    }

    /// <summary>
    /// ArrayProperty: ThrowList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FThrowInfo> ThrowList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FThrowInfo>>(Ptr + 2468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2468); }
    }

    /// <summary>
    /// ArrayProperty: WeaponDestroyList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FWeaponDestroyInfo> WeaponDestroyList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCombat.FWeaponDestroyInfo>>(Ptr + 2480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2480); }
    }

    /// <summary>
    /// ObjectProperty: LastDmgCauser
    /// </summary>
    public unsafe BmSDK.Engine.Actor LastDmgCauser
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2492); }
    }

    /// <summary>
    /// StructProperty: LastDmgImpulse
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastDmgImpulse
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2496);

    /// <summary>
    /// NameProperty: LastDmgBoneName
    /// </summary>
    public unsafe BmSDK.FName LastDmgBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2508); }
    }

    /// <summary>
    /// ArrayProperty: AfterCombatAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> AfterCombatAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 2516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2516); }
    }

    /// <summary>
    /// StructProperty: CheckCameraTargetOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CheckCameraTargetOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2528);

    /// <summary>
    /// ByteProperty: CheckCameraLookAtSpeed
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.CameraLookAtSpeed CheckCameraLookAtSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.CameraLookAtSpeed>(Ptr + 2540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2540); }
    }

    /// <summary>
    /// ByteProperty: KeepInViewSpeed
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.CameraLookAtSpeed KeepInViewSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.CameraLookAtSpeed>(Ptr + 2541); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2541); }
    }

    /// <summary>
    /// ObjectProperty: CheckCameraTargetActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor CheckCameraTargetActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2544); }
    }

    /// <summary>
    /// FloatProperty: CurrFOV
    /// </summary>
    public unsafe float CurrFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2548); }
    }

    /// <summary>
    /// FloatProperty: CurrMaxYawOffset
    /// </summary>
    public unsafe float CurrMaxYawOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2552); }
    }

    /// <summary>
    /// ObjectProperty: QuickStrike1
    /// </summary>
    public unsafe BmSDK.BmGame.RCombatMove_BatmanQuickStrike QuickStrike1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCombatMove_BatmanQuickStrike>(Ptr + 2556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2556); }
    }

    /// <summary>
    /// ObjectProperty: QuickStrike2
    /// </summary>
    public unsafe BmSDK.BmGame.RCombatMove_BatmanQuickStrike QuickStrike2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCombatMove_BatmanQuickStrike>(Ptr + 2560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2560); }
    }

    /// <summary>
    /// ObjectProperty: HeavyStrike1
    /// </summary>
    public unsafe BmSDK.BmGame.RCombatMove_BatmanHeavyStrike HeavyStrike1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCombatMove_BatmanHeavyStrike>(Ptr + 2564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2564); }
    }

    /// <summary>
    /// ObjectProperty: HeavyStrike2
    /// </summary>
    public unsafe BmSDK.BmGame.RCombatMove_BatmanHeavyStrike HeavyStrike2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCombatMove_BatmanHeavyStrike>(Ptr + 2568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2568); }
    }

    /// <summary>
    /// ObjectProperty: WeaponGrabbed
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatThrownObject WeaponGrabbed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatThrownObject>(Ptr + 2572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2572); }
    }

    /// <summary>
    /// ClassProperty: PrimaryGroupCombatMove
    /// </summary>
    public unsafe BmSDK.Class PrimaryGroupCombatMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 2576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2576); }
    }

    /// <summary>
    /// ClassProperty: SecondaryGroupCombatMove
    /// </summary>
    public unsafe BmSDK.Class SecondaryGroupCombatMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 2580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2580); }
    }

    /// <summary>
    /// ObjectProperty: StunSoundEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent StunSoundEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2584); }
    }

    /// <summary>
    /// ObjectProperty: StunAttackSoundEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent StunAttackSoundEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2588); }
    }

    /// <summary>
    /// ObjectProperty: StunAttackSoundSwitchLevel1
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName StunAttackSoundSwitchLevel1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 2592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2592); }
    }

    /// <summary>
    /// ObjectProperty: StunAttackSoundSwitchLevel2
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName StunAttackSoundSwitchLevel2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 2596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2596); }
    }

    /// <summary>
    /// ObjectProperty: StunAttackSoundSwitchLevel3
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName StunAttackSoundSwitchLevel3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 2600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }
    }

    /// <summary>
    /// ObjectProperty: StunAttackSoundSwitchNoHit
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName StunAttackSoundSwitchNoHit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 2604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2604); }
    }

    /// <summary>
    /// ObjectProperty: StrickSwooshSwitchHit
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName StrickSwooshSwitchHit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 2608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }
    }

    /// <summary>
    /// ObjectProperty: StrickSwooshSwitchNoHit
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName StrickSwooshSwitchNoHit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 2612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2612); }
    }

    /// <summary>
    /// ObjectProperty: CurrWeaponSwitchName
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName CurrWeaponSwitchName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 2616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2616); }
    }

    /// <summary>
    /// ObjectProperty: PlayerConfig
    /// </summary>
    public unsafe BmSDK.BmGame.MPlayerGlobalConfig PlayerConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MPlayerGlobalConfig>(Ptr + 2620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2620); }
    }

    /// <summary>
    /// ObjectProperty: SloMoStart
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SloMoStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }

    /// <summary>
    /// ObjectProperty: SloMoStop
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SloMoStop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2628); }
    }

    /// <summary>
    /// ObjectProperty: FinalSloMoStart
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FinalSloMoStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2632); }
    }

    /// <summary>
    /// ObjectProperty: FinalSloMoStop
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FinalSloMoStop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2636); }
    }
}
