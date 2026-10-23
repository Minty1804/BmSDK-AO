#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MBMBehaviour_DeathStroke<br/>
/// (size = 1876)
/// (flags = 8722)
/// </summary>
public partial class MBMBehaviour_DeathStroke : BmSDK.BmGame.MBMBehaviour_CombatBoss, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MBMBehaviour_DeathStroke", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MBMBehaviour_DeathStroke.
    /// </summary>
    public static MBMBehaviour_DeathStroke DefaultObject => (MBMBehaviour_DeathStroke)StaticClass().DefaultObject;

    internal MBMBehaviour_DeathStroke() { }

    /// <summary>
    /// Constructs a new MBMBehaviour_DeathStroke
    /// </summary>
    public MBMBehaviour_DeathStroke(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MBMBehaviour_DeathStroke Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MBMBehaviour_DeathStroke(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_DeathStroke>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_DeathStroke>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_DeathStroke>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_DeathStroke>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_DeathStroke>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_DeathStroke>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_DeathStroke>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_DeathStroke>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: NotifyFuryAttack
    /// </summary>
    public unsafe virtual void NotifyFuryAttack()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.NotifyFuryAttack", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayPenguinSpeech
    /// </summary>
    public unsafe virtual void PlayPenguinSpeech(BmSDK.Engine.RDialogueLine penguinLine, BmSDK.BmGame.RGameInfo.VocalPriority Priority = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.PlayPenguinSpeech", true);
        byte* paramsPtr = stackalloc byte[5];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(penguinLine, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: TransitionToCloserCameraSide
    /// </summary>
    public unsafe virtual void TransitionToCloserCameraSide(bool bInstantSwitchCam = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.TransitionToCloserCameraSide", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInstantSwitchCam, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlaySharedSpeech
    /// </summary>
    public unsafe virtual void PlaySharedSpeech(BmSDK.Engine.RDialogueLine deathstrokeLine, BmSDK.Engine.RDialogueLine penguinLine, BmSDK.BmGame.RGameInfo.VocalPriority Priority = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.PlaySharedSpeech", true);
        byte* paramsPtr = stackalloc byte[9];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(deathstrokeLine, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(penguinLine, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsInFuryAttackState
    /// </summary>
    public unsafe virtual bool IsInFuryAttackState()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.IsInFuryAttackState", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsInFlashbangState
    /// </summary>
    public unsafe virtual bool IsInFlashbangState()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.IsInFlashbangState", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsInBeatdown
    /// </summary>
    public unsafe virtual bool IsInBeatdown()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.IsInBeatdown", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsInBatClawState
    /// </summary>
    public unsafe virtual bool IsInBatClawState()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.IsInBatClawState", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsInRemoteClawState
    /// </summary>
    public unsafe virtual bool IsInRemoteClawState()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.IsInRemoteClawState", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsInFFCState
    /// </summary>
    public unsafe virtual bool IsInFFCState()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.IsInFFCState", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: FloatMin
    /// </summary>
    public unsafe virtual float FloatMin(float max0, float max1)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.FloatMin", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(max0, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(max1, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: DrawDebugGraphics
    /// </summary>
    public unsafe virtual void DrawDebugGraphics()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.DrawDebugGraphics", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DebugAvanceState
    /// </summary>
    public unsafe virtual void DebugAvanceState()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.DebugAvanceState", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GotoNextState
    /// </summary>
    public unsafe virtual void GotoNextState()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GotoNextState", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetTauntMoveStance
    /// </summary>
    public unsafe override BmSDK.FName GetTauntMoveStance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetTauntMoveStance", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GotoCombatState
    /// </summary>
    public unsafe override void GotoCombatState()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GotoCombatState", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnCombatRoll
    /// </summary>
    public unsafe virtual void SpawnCombatRoll()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.SpawnCombatRoll", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanCombatRoll
    /// </summary>
    public unsafe virtual bool CanCombatRoll()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.CanCombatRoll", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: EndFinalBeatdown
    /// </summary>
    public unsafe virtual void EndFinalBeatdown()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.EndFinalBeatdown", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DamageCollisionBetween
    /// </summary>
    public unsafe override void DamageCollisionBetween(BmSDK.BmGame.RPawnCombat Pawn1, BmSDK.BmGame.RPawnCombat Pawn2, System.Numerics.Vector3 DamageDir)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.DamageCollisionBetween", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn2, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageDir, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayerBumped
    /// </summary>
    public unsafe override void PlayerBumped(bool bFriendly)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.PlayerBumped", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFriendly, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShouldUseEnvironment
    /// </summary>
    public unsafe override bool ShouldUseEnvironment(float DeltaTime, bool bForceCheck)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.ShouldUseEnvironment", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceCheck, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: CheckStuckInCorner
    /// </summary>
    public unsafe virtual BmSDK.BmScript.MBMBehaviour_DeathStroke.ObstacleSide CheckStuckInCorner()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.CheckStuckInCorner", true);
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MBMBehaviour_DeathStroke.ObstacleSide>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetPossibleSuccessiveCounters
    /// </summary>
    public unsafe virtual int GetPossibleSuccessiveCounters()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetPossibleSuccessiveCounters", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: LaunchCounterAgainstBatmanAttack
    /// </summary>
    public unsafe virtual void LaunchCounterAgainstBatmanAttack()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.LaunchCounterAgainstBatmanAttack", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckCounterAgainstBatmanAttack
    /// </summary>
    public unsafe virtual bool CheckCounterAgainstBatmanAttack(bool launchNow = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.CheckCounterAgainstBatmanAttack", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(launchNow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: DeathstrokeCloseToWalls
    /// </summary>
    public unsafe virtual bool DeathstrokeCloseToWalls()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.DeathstrokeCloseToWalls", true);
        byte* paramsPtr = stackalloc byte[104];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SpawnOverrideTakedown
    /// </summary>
    public unsafe virtual bool SpawnOverrideTakedown(BmSDK.BmGame.RPawnCombat PlayerPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.SpawnOverrideTakedown", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SpawnSpecialAttack
    /// </summary>
    public unsafe virtual bool SpawnSpecialAttack(BmSDK.BmGame.RPawnCombat PlayerPawn, BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.SpawnSpecialAttack", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: DamagedBy
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat.DamageResult DamagedBy(out BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.DamagedBy", true);
        byte* paramsPtr = stackalloc byte[257];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DmgInfo = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.FDamageInfo>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 256);
    }

    /// <summary>
    /// Function: ModifyDamageAmount
    /// </summary>
    public unsafe virtual void ModifyDamageAmount(BmSDK.Class dmgType, out float DmgAmount)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.ModifyDamageAmount", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DmgAmount = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
        return;
    }

    /// <summary>
    /// Function: GetAttackPriority
    /// </summary>
    public unsafe override int GetAttackPriority(bool bForceAttack)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetAttackPriority", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceAttack, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetPossibleMoves
    /// </summary>
    public unsafe override void GetPossibleMoves(out BmSDK.TArray<BmSDK.Class> PossibleMoves)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetPossibleMoves", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PossibleMoves = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: UseRangeAttack
    /// </summary>
    public unsafe virtual bool UseRangeAttack()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.UseRangeAttack", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ShouldTaunt
    /// </summary>
    public unsafe virtual bool ShouldTaunt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.ShouldTaunt", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: AttackTargetPawn
    /// </summary>
    public unsafe override bool AttackTargetPawn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.AttackTargetPawn", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: EnterFFCMode
    /// </summary>
    public unsafe virtual void EnterFFCMode()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.EnterFFCMode", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ExitFFCMode
    /// </summary>
    public unsafe virtual void ExitFFCMode()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.ExitFFCMode", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckFFCExit
    /// </summary>
    public unsafe virtual bool CheckFFCExit()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.CheckFFCExit", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetWeaponDamage
    /// </summary>
    public unsafe virtual float GetWeaponDamage()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetWeaponDamage", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetDelayAttackTimeAfterSuccessfulAttack
    /// </summary>
    public unsafe virtual float GetDelayAttackTimeAfterSuccessfulAttack()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetDelayAttackTimeAfterSuccessfulAttack", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetDelayAttackTimeAfterSuccessfulCounter
    /// </summary>
    public unsafe virtual float GetDelayAttackTimeAfterSuccessfulCounter()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetDelayAttackTimeAfterSuccessfulCounter", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetIncrementCounterProbability
    /// </summary>
    public unsafe virtual float GetIncrementCounterProbability(int counterIdx = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetIncrementCounterProbability", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(counterIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetInitialCounterProbability
    /// </summary>
    public unsafe virtual float GetInitialCounterProbability(int counterIdx = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetInitialCounterProbability", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(counterIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetCurrentPhase
    /// </summary>
    public unsafe virtual int GetCurrentPhase()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetCurrentPhase", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: PlayerTookDamage
    /// </summary>
    public unsafe virtual void PlayerTookDamage(int Damage, BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.PlayerTookDamage", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetBulletDamage
    /// </summary>
    public unsafe virtual void SetBulletDamage(bool RepelAttack = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.SetBulletDamage", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RepelAttack, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: internalFFloor
    /// </summary>
    public unsafe virtual int internalFFloor(float fNumber)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.internalFFloor", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fNumber, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetDamageWhenRepulsed
    /// </summary>
    public unsafe virtual float GetDamageWhenRepulsed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetDamageWhenRepulsed", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetDamagePerBullet
    /// </summary>
    public unsafe virtual float GetDamagePerBullet()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetDamagePerBullet", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetDistanceToRepulsePlayer
    /// </summary>
    public unsafe virtual float GetDistanceToRepulsePlayer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetDistanceToRepulsePlayer", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetBulletPerRound
    /// </summary>
    public unsafe virtual int GetBulletPerRound()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetBulletPerRound", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetTimeBeforeFirstShot
    /// </summary>
    public unsafe virtual float GetTimeBeforeFirstShot()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetTimeBeforeFirstShot", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetTimeBetweenShotRounds
    /// </summary>
    public unsafe virtual float GetTimeBetweenShotRounds()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetTimeBetweenShotRounds", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetMaxTimeBeforeNextShot
    /// </summary>
    public unsafe virtual float GetMaxTimeBeforeNextShot()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetMaxTimeBeforeNextShot", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetTimeBeforeNextShot
    /// </summary>
    public unsafe virtual float GetTimeBeforeNextShot()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetTimeBeforeNextShot", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetBeatdownThreshold
    /// </summary>
    public unsafe virtual int GetBeatdownThreshold()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetBeatdownThreshold", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ShouldForceBeatDown
    /// </summary>
    public unsafe virtual bool ShouldForceBeatDown()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.ShouldForceBeatDown", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetForceIsInBeatdown
    /// </summary>
    public unsafe virtual void SetForceIsInBeatdown(bool bBeatdown)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.SetForceIsInBeatdown", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBeatdown, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetTauntAfterHitPlayerChance
    /// </summary>
    public unsafe virtual float GetTauntAfterHitPlayerChance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetTauntAfterHitPlayerChance", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetPhaseChangeDamage
    /// </summary>
    public unsafe virtual float GetPhaseChangeDamage()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetPhaseChangeDamage", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetTauntChance
    /// </summary>
    public unsafe virtual float GetTauntChance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetTauntChance", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetCounterMechanicSlowMo
    /// </summary>
    public unsafe virtual float GetCounterMechanicSlowMo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetCounterMechanicSlowMo", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetBeatdownHitDamage
    /// </summary>
    public unsafe virtual int GetBeatdownHitDamage()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetBeatdownHitDamage", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetBeatdownHitRequired
    /// </summary>
    public unsafe virtual int GetBeatdownHitRequired()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetBeatdownHitRequired", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ShouldDodgeRetreat
    /// </summary>
    public unsafe virtual bool ShouldDodgeRetreat()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.ShouldDodgeRetreat", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ReturnToCombat
    /// </summary>
    public unsafe virtual void ReturnToCombat()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.ReturnToCombat", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShouldBeAttackingPlayer
    /// </summary>
    public unsafe virtual bool ShouldBeAttackingPlayer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.ShouldBeAttackingPlayer", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CheckBatclawed
    /// </summary>
    public unsafe virtual void CheckBatclawed(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.CheckBatclawed", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FirePistol
    /// </summary>
    public unsafe virtual void FirePistol()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.FirePistol", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetAimingStartRadius
    /// </summary>
    public unsafe virtual float GetAimingStartRadius()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetAimingStartRadius", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ProjectileIsBehindBatman
    /// </summary>
    public unsafe virtual bool ProjectileIsBehindBatman(System.Numerics.Vector3 TestPos)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.ProjectileIsBehindBatman", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GotoPistolFromRemoteClaw
    /// </summary>
    public unsafe virtual void GotoPistolFromRemoteClaw()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GotoPistolFromRemoteClaw", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MovePlayerAwayFromWall
    /// </summary>
    public unsafe virtual void MovePlayerAwayFromWall()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.MovePlayerAwayFromWall", true);
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetNumWaves
    /// </summary>
    public unsafe virtual void SetNumWaves()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.SetNumWaves", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetFFCDodgeStrikeChanceInc
    /// </summary>
    public unsafe virtual float GetFFCDodgeStrikeChanceInc()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetFFCDodgeStrikeChanceInc", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetFFCDodgeStrikeChance
    /// </summary>
    public unsafe virtual float GetFFCDodgeStrikeChance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetFFCDodgeStrikeChance", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetFFCCounterStrikeOnDodgeInc
    /// </summary>
    public unsafe virtual float GetFFCCounterStrikeOnDodgeInc()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetFFCCounterStrikeOnDodgeInc", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetFFCCounterStrikeOnDodge
    /// </summary>
    public unsafe virtual float GetFFCCounterStrikeOnDodge()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetFFCCounterStrikeOnDodge", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetDamageRemoteClawObjects
    /// </summary>
    public unsafe virtual float GetDamageRemoteClawObjects(int WaveCount)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetDamageRemoteClawObjects", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WaveCount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetNumRemoteClawObjects
    /// </summary>
    public unsafe virtual float GetNumRemoteClawObjects(int WaveCount)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetNumRemoteClawObjects", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WaveCount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetDamagePerObject
    /// </summary>
    public unsafe virtual float GetDamagePerObject(int WaveCount)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetDamagePerObject", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WaveCount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetDelayBetweenObject
    /// </summary>
    public unsafe virtual float GetDelayBetweenObject(int WaveCount)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetDelayBetweenObject", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WaveCount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetOppositeSideObject
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatPoint GetOppositeSideObject(BmSDK.BmGame.RBMCombatPoint PrevObject)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetOppositeSideObject", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PrevObject, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatPoint>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetNextObject
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatPoint GetNextObject(BmSDK.BmGame.RBMCombatPoint OppositeTo = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetNextObject", true);
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OppositeTo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatPoint>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: CanBeUsed
    /// </summary>
    public unsafe virtual bool CanBeUsed(BmSDK.BmGame.RBMCombatPoint CombatObject)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.CanBeUsed", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatObject, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: RemoteClawTick
    /// </summary>
    public unsafe virtual void RemoteClawTick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.RemoteClawTick", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetCameraTargetMaxYaw
    /// </summary>
    public unsafe virtual float GetCameraTargetMaxYaw()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetCameraTargetMaxYaw", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SwitchCamSide
    /// </summary>
    public unsafe virtual void SwitchCamSide(bool bInstantSwitchCam = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.SwitchCamSide", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInstantSwitchCam, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: KeepInView
    /// </summary>
    public unsafe virtual void KeepInView(BmSDK.Engine.Actor Pawn, float MaxYaw = default, BmSDK.BmGame.RGameInfo.CameraLookAtSpeed Speed = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.KeepInView", true);
        byte* paramsPtr = stackalloc byte[225];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxYaw, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InputRightStick
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 InputRightStick()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.InputRightStick", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: UpdateSideCam
    /// </summary>
    public unsafe virtual void UpdateSideCam(BmSDK.BmGame.R3rdPersonCamera Cam, BmSDK.BmGame.RMultiTargetCamera MultiTargetCam)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.UpdateSideCam", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Cam, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MultiTargetCam, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TryEnableSideCam
    /// </summary>
    public unsafe virtual bool TryEnableSideCam()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.TryEnableSideCam", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ComputeLookAtSpeed
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.CameraLookAtSpeed ComputeLookAtSpeed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.ComputeLookAtSpeed", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.CameraLookAtSpeed>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: UpdateCamera
    /// </summary>
    public unsafe virtual void UpdateCamera(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.UpdateCamera", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetCombatStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetCombatStance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.GetCombatStance", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.Tick", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckDodgeProjectile
    /// </summary>
    public unsafe virtual bool CheckDodgeProjectile(BmSDK.BmGame.RPawn Thrower, BmSDK.FName TargetBone, System.Numerics.Vector3 ProjPos, int BatarangID, bool bForceDodge = default, bool bSteerableProj = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.CheckDodgeProjectile", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thrower, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBone, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProjPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatarangID, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceDodge, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSteerableProj, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: BossTickInternal
    /// </summary>
    public unsafe override void BossTickInternal(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.BossTickInternal", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnEndInterrupt
    /// </summary>
    public unsafe override void OnEndInterrupt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.OnEndInterrupt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnBeginInterrupt
    /// </summary>
    public unsafe override void OnBeginInterrupt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.OnBeginInterrupt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnDeactivate
    /// </summary>
    public unsafe override void OnDeactivate()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.OnDeactivate", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetInitialState
    /// </summary>
    public unsafe override void SetInitialState()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.SetInitialState", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe virtual void Initialise()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.Initialise", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnActivate
    /// </summary>
    public unsafe override void OnActivate()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_DeathStroke.OnActivate", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: CircleSideY
    /// </summary>
    public enum CircleSideY : byte
    {
        CS_Top = 0,
        CS_Bottom = 1,
        CS_MAX = 2,
    }

    /// <summary>
    /// Enum: CircleSideX
    /// </summary>
    public enum CircleSideX : byte
    {
        CS_Left = 0,
        CS_Right = 1,
        CS_MAX = 2,
    }

    /// <summary>
    /// Enum: RemoteClawJumpState
    /// </summary>
    public enum RemoteClawJumpState : byte
    {
        RCJ_SwitchingWeapon = 0,
        RCJ_JumpInAir = 1,
        RCJ_FollowRCProjectile = 2,
        RCJ_FollowRCRope = 3,
        RCJ_FollowHeavyObjectBackward = 4,
        RCJ_ReturnToDS = 5,
        RCJ_Num = 6,
        RCJ_MAX = 7,
    }

    /// <summary>
    /// Enum: ObstacleSide
    /// </summary>
    public enum ObstacleSide : byte
    {
        OS_BACK = 0,
        OS_LEFT = 1,
        OS_RIGHT = 2,
        OS_NUM = 3,
        OS_MAX = 4,
    }

    /// <summary>
    /// Enum: DeathStrokeStates
    /// </summary>
    public enum DeathStrokeStates : byte
    {
        DSS_FFC_STAFF_1 = 0,
        DSS_REMOTECLAW_STAFF_1 = 1,
        DSS_FLASHBANG_STAFF_1 = 2,
        DSS_FURYATTACK_1 = 3,
        DSS_BATCLAW_ATTACK_STAFF_1 = 4,
        DSS_BEATDOWN_1 = 5,
        DSS_FFC_STAFF_2 = 6,
        DSS_REMOTECLAW_STAFF_2 = 7,
        DSS_FLASHBANG_STAFF_2 = 8,
        DSS_FURYATTACK_2 = 9,
        DSS_BATCLAW_ATTACK_STAFF_2 = 10,
        DSS_BEATDOWN_2 = 11,
        DSS_FFC_SWORD = 12,
        DSS_REMOTECLAW_SWORD = 13,
        DSS_FLASHBANG_SWORD = 14,
        DSS_FURYATTACK_3 = 15,
        DSS_BATCLAW_ATTACK_SWORD = 16,
        DSS_BEATDOWN_3 = 17,
        DSS_NUM = 18,
        DSS_MAX = 19,
    }

    /// <summary>
    /// IntProperty: InitialHealth
    /// </summary>
    public unsafe int InitialHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// IntProperty: FFC_Staff_Phase1_HealthThreshold
    /// </summary>
    public unsafe int FFC_Staff_Phase1_HealthThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// IntProperty: FFC_Staff_Phase1_Beatdown_HealthThreshold
    /// </summary>
    public unsafe int FFC_Staff_Phase1_Beatdown_HealthThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// IntProperty: FFC_Staff_Phase2_HealthThreshold
    /// </summary>
    public unsafe int FFC_Staff_Phase2_HealthThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// IntProperty: FFC_Staff_Phase2_Beatdown_HealthThreshold
    /// </summary>
    public unsafe int FFC_Staff_Phase2_Beatdown_HealthThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// IntProperty: FFC_Sword_Phase3_HealthThreshold
    /// </summary>
    public unsafe int FFC_Sword_Phase3_HealthThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// IntProperty: FFC_Sword_Phase3_Beatdown_HealthThreshold
    /// </summary>
    public unsafe int FFC_Sword_Phase3_Beatdown_HealthThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// FloatProperty: TimeUntilNextCombatRoll
    /// </summary>
    public unsafe float TimeUntilNextCombatRoll
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// FloatProperty: TimeInIdle
    /// </summary>
    public unsafe float TimeInIdle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: MeleeCombatOver
    /// </summary>
    public unsafe bool MeleeCombatOver
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bForceSideCam
    /// </summary>
    public unsafe bool bForceSideCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bForceNextAttackToBeCountered
    /// </summary>
    public unsafe bool bForceNextAttackToBeCountered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bForceNoNextTaunt
    /// </summary>
    public unsafe bool bForceNoNextTaunt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bLastCinematicPreloaded
    /// </summary>
    public unsafe bool bLastCinematicPreloaded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bCounterMechanicMirrored
    /// </summary>
    public unsafe bool bCounterMechanicMirrored
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: RopeHook1Targeted
    /// </summary>
    public unsafe bool RopeHook1Targeted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: RopeHook2Targeted
    /// </summary>
    public unsafe bool RopeHook2Targeted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: DualClawLaunched
    /// </summary>
    public unsafe bool DualClawLaunched
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bBatclawed
    /// </summary>
    public unsafe bool bBatclawed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bEvadingPlayer
    /// </summary>
    public unsafe bool bEvadingPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bUseEvadingPosition1
    /// </summary>
    public unsafe bool bUseEvadingPosition1
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: WarningGunSoundPlayed
    /// </summary>
    public unsafe bool WarningGunSoundPlayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: BeenBatclawed
    /// </summary>
    public unsafe bool BeenBatclawed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: BeenHit
    /// </summary>
    public unsafe bool BeenHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: AlreadyInHitReaction
    /// </summary>
    public unsafe bool AlreadyInHitReaction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bForceBeatdown
    /// </summary>
    public unsafe bool bForceBeatdown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bNoJump
    /// </summary>
    public unsafe bool bNoJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bFirstTimePistol
    /// </summary>
    public unsafe bool bFirstTimePistol
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bFirstTimeRemoteClaw
    /// </summary>
    public unsafe bool bFirstTimeRemoteClaw
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bFromRemoteClaw
    /// </summary>
    public unsafe bool bFromRemoteClaw
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bReadyToFire
    /// </summary>
    public unsafe bool bReadyToFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: TugOfWarStarted
    /// </summary>
    public unsafe bool TugOfWarStarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: BraceWireStarted
    /// </summary>
    public unsafe bool BraceWireStarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: DoStartTugOfWar
    /// </summary>
    public unsafe bool DoStartTugOfWar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: TugOfWarFinished
    /// </summary>
    public unsafe bool TugOfWarFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: DeathstrokeWinStarted
    /// </summary>
    public unsafe bool DeathstrokeWinStarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bSuspendKeepInView
    /// </summary>
    public unsafe bool bSuspendKeepInView
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bConstantCamLook
    /// </summary>
    public unsafe bool bConstantCamLook
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bLookAtHead
    /// </summary>
    public unsafe bool bLookAtHead
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bLockLook
    /// </summary>
    public unsafe bool bLockLook
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bConstantCamLookYaw
    /// </summary>
    public unsafe bool bConstantCamLookYaw
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bFirstCounterMechanic
    /// </summary>
    public unsafe bool bFirstCounterMechanic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// FloatProperty: NearCamOnlyDistance
    /// </summary>
    public unsafe float NearCamOnlyDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// FloatProperty: FarCamOnlyDistance
    /// </summary>
    public unsafe float FarCamOnlyDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// FloatProperty: NearCamPitch
    /// </summary>
    public unsafe float NearCamPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// FloatProperty: NearCamYawOffset
    /// </summary>
    public unsafe float NearCamYawOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// FloatProperty: SideCameraDSDistance
    /// </summary>
    public unsafe float SideCameraDSDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// FloatProperty: SideCameraActivateDistance
    /// </summary>
    public unsafe float SideCameraActivateDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// FloatProperty: SideCameraDeactivateDistance
    /// </summary>
    public unsafe float SideCameraDeactivateDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// FloatProperty: SideCameraDeactivationTime
    /// </summary>
    public unsafe float SideCameraDeactivationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// FloatProperty: SideCameraPitch
    /// </summary>
    public unsafe float SideCameraPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// FloatProperty: SideCameraBehindPitch
    /// </summary>
    public unsafe float SideCameraBehindPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// FloatProperty: SideCameraMovementSmoothFactor
    /// </summary>
    public unsafe float SideCameraMovementSmoothFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// FloatProperty: SideCameraDistanceFromWall
    /// </summary>
    public unsafe float SideCameraDistanceFromWall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: PhaseChangeDamage
    /// </summary>
    public InlineArray<float> PhaseChangeDamage => new(3, Ptr + 1000, 4, this);

    /// <summary>
    /// FloatProperty: PhaseChangeDamage
    /// </summary>
    public unsafe float PhaseChangeDamage_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }
    /// <summary>
    /// FloatProperty: PhaseChangeDamage
    /// </summary>
    public unsafe float PhaseChangeDamage_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }
    /// <summary>
    /// FloatProperty: PhaseChangeDamage
    /// </summary>
    public unsafe float PhaseChangeDamage_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: TauntChance
    /// </summary>
    public InlineArray<float> TauntChance => new(3, Ptr + 1012, 4, this);

    /// <summary>
    /// FloatProperty: TauntChance
    /// </summary>
    public unsafe float TauntChance_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }
    /// <summary>
    /// FloatProperty: TauntChance
    /// </summary>
    public unsafe float TauntChance_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }
    /// <summary>
    /// FloatProperty: TauntChance
    /// </summary>
    public unsafe float TauntChance_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: TauntChanceAfterHitPlayer
    /// </summary>
    public InlineArray<float> TauntChanceAfterHitPlayer => new(3, Ptr + 1024, 4, this);

    /// <summary>
    /// FloatProperty: TauntChanceAfterHitPlayer
    /// </summary>
    public unsafe float TauntChanceAfterHitPlayer_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }
    /// <summary>
    /// FloatProperty: TauntChanceAfterHitPlayer
    /// </summary>
    public unsafe float TauntChanceAfterHitPlayer_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }
    /// <summary>
    /// FloatProperty: TauntChanceAfterHitPlayer
    /// </summary>
    public unsafe float TauntChanceAfterHitPlayer_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// StructProperty: TauntTransitionID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId TauntTransitionID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 1036);

    /// <summary>
    /// ObjectProperty: MiddleOfFightPit
    /// </summary>
    public unsafe BmSDK.Engine.Actor MiddleOfFightPit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// ByteProperty: BossState
    /// </summary>
    public unsafe BmSDK.BmScript.MBMBehaviour_DeathStroke.DeathStrokeStates BossState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MBMBehaviour_DeathStroke.DeathStrokeStates>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// ByteProperty: RemoteClawJumpCameraState
    /// </summary>
    public unsafe BmSDK.BmScript.MBMBehaviour_DeathStroke.RemoteClawJumpState RemoteClawJumpCameraState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MBMBehaviour_DeathStroke.RemoteClawJumpState>(Ptr + 1045); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1045); }
    }

    /// <summary>
    /// ByteProperty: eCurrentAimingSignX
    /// </summary>
    public unsafe BmSDK.BmScript.MBMBehaviour_DeathStroke.CircleSideX eCurrentAimingSignX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MBMBehaviour_DeathStroke.CircleSideX>(Ptr + 1046); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1046); }
    }

    /// <summary>
    /// ByteProperty: eCurrentAimingSignY
    /// </summary>
    public unsafe BmSDK.BmScript.MBMBehaviour_DeathStroke.CircleSideY eCurrentAimingSignY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MBMBehaviour_DeathStroke.CircleSideY>(Ptr + 1047); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1047); }
    }

    /// <summary>
    /// ByteProperty: CurrentCameraSpeed
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.CameraLookAtSpeed CurrentCameraSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.CameraLookAtSpeed>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// FloatProperty: fFlashbangRadius
    /// </summary>
    public unsafe float fFlashbangRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// ObjectProperty: ReverseCornerSituation
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ReverseCornerSituation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// FloatProperty: fDelayBetweenReverseCorner
    /// </summary>
    public unsafe float fDelayBetweenReverseCorner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// FloatProperty: fLastEvadeCornerTime
    /// </summary>
    public unsafe float fLastEvadeCornerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: FFCWeaponDamagePhase1
    /// </summary>
    public InlineArray<float> FFCWeaponDamagePhase1 => new(3, Ptr + 1068, 4, this);

    /// <summary>
    /// FloatProperty: FFCWeaponDamagePhase1
    /// </summary>
    public unsafe float FFCWeaponDamagePhase1_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }
    /// <summary>
    /// FloatProperty: FFCWeaponDamagePhase1
    /// </summary>
    public unsafe float FFCWeaponDamagePhase1_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }
    /// <summary>
    /// FloatProperty: FFCWeaponDamagePhase1
    /// </summary>
    public unsafe float FFCWeaponDamagePhase1_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: FFCWeaponDamagePhase2
    /// </summary>
    public InlineArray<float> FFCWeaponDamagePhase2 => new(3, Ptr + 1080, 4, this);

    /// <summary>
    /// FloatProperty: FFCWeaponDamagePhase2
    /// </summary>
    public unsafe float FFCWeaponDamagePhase2_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }
    /// <summary>
    /// FloatProperty: FFCWeaponDamagePhase2
    /// </summary>
    public unsafe float FFCWeaponDamagePhase2_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }
    /// <summary>
    /// FloatProperty: FFCWeaponDamagePhase2
    /// </summary>
    public unsafe float FFCWeaponDamagePhase2_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: FFCWeaponDamagePhase3
    /// </summary>
    public InlineArray<float> FFCWeaponDamagePhase3 => new(3, Ptr + 1092, 4, this);

    /// <summary>
    /// FloatProperty: FFCWeaponDamagePhase3
    /// </summary>
    public unsafe float FFCWeaponDamagePhase3_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }
    /// <summary>
    /// FloatProperty: FFCWeaponDamagePhase3
    /// </summary>
    public unsafe float FFCWeaponDamagePhase3_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }
    /// <summary>
    /// FloatProperty: FFCWeaponDamagePhase3
    /// </summary>
    public unsafe float FFCWeaponDamagePhase3_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: fInitial1stCounterProbability
    /// </summary>
    public InlineArray<float> fInitial1stCounterProbability => new(3, Ptr + 1104, 4, this);

    /// <summary>
    /// FloatProperty: fInitial1stCounterProbability
    /// </summary>
    public unsafe float fInitial1stCounterProbability_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }
    /// <summary>
    /// FloatProperty: fInitial1stCounterProbability
    /// </summary>
    public unsafe float fInitial1stCounterProbability_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }
    /// <summary>
    /// FloatProperty: fInitial1stCounterProbability
    /// </summary>
    public unsafe float fInitial1stCounterProbability_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: fIncrement1stCounterProbabilityStep
    /// </summary>
    public InlineArray<float> fIncrement1stCounterProbabilityStep => new(3, Ptr + 1116, 4, this);

    /// <summary>
    /// FloatProperty: fIncrement1stCounterProbabilityStep
    /// </summary>
    public unsafe float fIncrement1stCounterProbabilityStep_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }
    /// <summary>
    /// FloatProperty: fIncrement1stCounterProbabilityStep
    /// </summary>
    public unsafe float fIncrement1stCounterProbabilityStep_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }
    /// <summary>
    /// FloatProperty: fIncrement1stCounterProbabilityStep
    /// </summary>
    public unsafe float fIncrement1stCounterProbabilityStep_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: fInitial2ndCounterProbability
    /// </summary>
    public InlineArray<float> fInitial2ndCounterProbability => new(3, Ptr + 1128, 4, this);

    /// <summary>
    /// FloatProperty: fInitial2ndCounterProbability
    /// </summary>
    public unsafe float fInitial2ndCounterProbability_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }
    /// <summary>
    /// FloatProperty: fInitial2ndCounterProbability
    /// </summary>
    public unsafe float fInitial2ndCounterProbability_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }
    /// <summary>
    /// FloatProperty: fInitial2ndCounterProbability
    /// </summary>
    public unsafe float fInitial2ndCounterProbability_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: fIncrement2ndCounterProbabilityStep
    /// </summary>
    public InlineArray<float> fIncrement2ndCounterProbabilityStep => new(3, Ptr + 1140, 4, this);

    /// <summary>
    /// FloatProperty: fIncrement2ndCounterProbabilityStep
    /// </summary>
    public unsafe float fIncrement2ndCounterProbabilityStep_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }
    /// <summary>
    /// FloatProperty: fIncrement2ndCounterProbabilityStep
    /// </summary>
    public unsafe float fIncrement2ndCounterProbabilityStep_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }
    /// <summary>
    /// FloatProperty: fIncrement2ndCounterProbabilityStep
    /// </summary>
    public unsafe float fIncrement2ndCounterProbabilityStep_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: fInitial3rdCounterProbability
    /// </summary>
    public InlineArray<float> fInitial3rdCounterProbability => new(3, Ptr + 1152, 4, this);

    /// <summary>
    /// FloatProperty: fInitial3rdCounterProbability
    /// </summary>
    public unsafe float fInitial3rdCounterProbability_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }
    /// <summary>
    /// FloatProperty: fInitial3rdCounterProbability
    /// </summary>
    public unsafe float fInitial3rdCounterProbability_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }
    /// <summary>
    /// FloatProperty: fInitial3rdCounterProbability
    /// </summary>
    public unsafe float fInitial3rdCounterProbability_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: fIncrement3rdCounterProbabilityStep
    /// </summary>
    public InlineArray<float> fIncrement3rdCounterProbabilityStep => new(3, Ptr + 1164, 4, this);

    /// <summary>
    /// FloatProperty: fIncrement3rdCounterProbabilityStep
    /// </summary>
    public unsafe float fIncrement3rdCounterProbabilityStep_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }
    /// <summary>
    /// FloatProperty: fIncrement3rdCounterProbabilityStep
    /// </summary>
    public unsafe float fIncrement3rdCounterProbabilityStep_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }
    /// <summary>
    /// FloatProperty: fIncrement3rdCounterProbabilityStep
    /// </summary>
    public unsafe float fIncrement3rdCounterProbabilityStep_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: iPossibleSuccessiveCounters
    /// </summary>
    public InlineArray<int> iPossibleSuccessiveCounters => new(3, Ptr + 1176, 4, this);

    /// <summary>
    /// IntProperty: iPossibleSuccessiveCounters
    /// </summary>
    public unsafe int iPossibleSuccessiveCounters_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }
    /// <summary>
    /// IntProperty: iPossibleSuccessiveCounters
    /// </summary>
    public unsafe int iPossibleSuccessiveCounters_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }
    /// <summary>
    /// IntProperty: iPossibleSuccessiveCounters
    /// </summary>
    public unsafe int iPossibleSuccessiveCounters_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: FFCDelayAttackTimeAfterSuccessfulCounter
    /// </summary>
    public InlineArray<float> FFCDelayAttackTimeAfterSuccessfulCounter => new(3, Ptr + 1188, 4, this);

    /// <summary>
    /// FloatProperty: FFCDelayAttackTimeAfterSuccessfulCounter
    /// </summary>
    public unsafe float FFCDelayAttackTimeAfterSuccessfulCounter_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }
    /// <summary>
    /// FloatProperty: FFCDelayAttackTimeAfterSuccessfulCounter
    /// </summary>
    public unsafe float FFCDelayAttackTimeAfterSuccessfulCounter_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }
    /// <summary>
    /// FloatProperty: FFCDelayAttackTimeAfterSuccessfulCounter
    /// </summary>
    public unsafe float FFCDelayAttackTimeAfterSuccessfulCounter_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: FFCDelayAttackTimeAfterSuccessfulAttack
    /// </summary>
    public InlineArray<float> FFCDelayAttackTimeAfterSuccessfulAttack => new(3, Ptr + 1200, 4, this);

    /// <summary>
    /// FloatProperty: FFCDelayAttackTimeAfterSuccessfulAttack
    /// </summary>
    public unsafe float FFCDelayAttackTimeAfterSuccessfulAttack_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }
    /// <summary>
    /// FloatProperty: FFCDelayAttackTimeAfterSuccessfulAttack
    /// </summary>
    public unsafe float FFCDelayAttackTimeAfterSuccessfulAttack_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }
    /// <summary>
    /// FloatProperty: FFCDelayAttackTimeAfterSuccessfulAttack
    /// </summary>
    public unsafe float FFCDelayAttackTimeAfterSuccessfulAttack_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// FloatProperty: FFCTargetMaxYaw
    /// </summary>
    public unsafe float FFCTargetMaxYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// FloatProperty: FFCFlashbangPPDuration
    /// </summary>
    public unsafe float FFCFlashbangPPDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// FloatProperty: FFCFuryDelayAfterFlashbang
    /// </summary>
    public unsafe float FFCFuryDelayAfterFlashbang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1220); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: FFCDodgeChanceOnStrike
    /// </summary>
    public InlineArray<float> FFCDodgeChanceOnStrike => new(3, Ptr + 1224, 4, this);

    /// <summary>
    /// FloatProperty: FFCDodgeChanceOnStrike
    /// </summary>
    public unsafe float FFCDodgeChanceOnStrike_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }
    /// <summary>
    /// FloatProperty: FFCDodgeChanceOnStrike
    /// </summary>
    public unsafe float FFCDodgeChanceOnStrike_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }
    /// <summary>
    /// FloatProperty: FFCDodgeChanceOnStrike
    /// </summary>
    public unsafe float FFCDodgeChanceOnStrike_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: FFCDodgeChanceOnStrikeInc
    /// </summary>
    public InlineArray<float> FFCDodgeChanceOnStrikeInc => new(3, Ptr + 1236, 4, this);

    /// <summary>
    /// FloatProperty: FFCDodgeChanceOnStrikeInc
    /// </summary>
    public unsafe float FFCDodgeChanceOnStrikeInc_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }
    /// <summary>
    /// FloatProperty: FFCDodgeChanceOnStrikeInc
    /// </summary>
    public unsafe float FFCDodgeChanceOnStrikeInc_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }
    /// <summary>
    /// FloatProperty: FFCDodgeChanceOnStrikeInc
    /// </summary>
    public unsafe float FFCDodgeChanceOnStrikeInc_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: FFCCounterStrikeOnDodge
    /// </summary>
    public InlineArray<float> FFCCounterStrikeOnDodge => new(3, Ptr + 1248, 4, this);

    /// <summary>
    /// FloatProperty: FFCCounterStrikeOnDodge
    /// </summary>
    public unsafe float FFCCounterStrikeOnDodge_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }
    /// <summary>
    /// FloatProperty: FFCCounterStrikeOnDodge
    /// </summary>
    public unsafe float FFCCounterStrikeOnDodge_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }
    /// <summary>
    /// FloatProperty: FFCCounterStrikeOnDodge
    /// </summary>
    public unsafe float FFCCounterStrikeOnDodge_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: FFCCounterStrikeOnDodgeInc
    /// </summary>
    public InlineArray<float> FFCCounterStrikeOnDodgeInc => new(3, Ptr + 1260, 4, this);

    /// <summary>
    /// FloatProperty: FFCCounterStrikeOnDodgeInc
    /// </summary>
    public unsafe float FFCCounterStrikeOnDodgeInc_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }
    /// <summary>
    /// FloatProperty: FFCCounterStrikeOnDodgeInc
    /// </summary>
    public unsafe float FFCCounterStrikeOnDodgeInc_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }
    /// <summary>
    /// FloatProperty: FFCCounterStrikeOnDodgeInc
    /// </summary>
    public unsafe float FFCCounterStrikeOnDodgeInc_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: FFCCounterMechanicSlowMoPhase1
    /// </summary>
    public InlineArray<float> FFCCounterMechanicSlowMoPhase1 => new(3, Ptr + 1272, 4, this);

    /// <summary>
    /// FloatProperty: FFCCounterMechanicSlowMoPhase1
    /// </summary>
    public unsafe float FFCCounterMechanicSlowMoPhase1_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }
    /// <summary>
    /// FloatProperty: FFCCounterMechanicSlowMoPhase1
    /// </summary>
    public unsafe float FFCCounterMechanicSlowMoPhase1_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1276); }
    }
    /// <summary>
    /// FloatProperty: FFCCounterMechanicSlowMoPhase1
    /// </summary>
    public unsafe float FFCCounterMechanicSlowMoPhase1_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: FFCCounterMechanicSlowMoPhase2
    /// </summary>
    public InlineArray<float> FFCCounterMechanicSlowMoPhase2 => new(3, Ptr + 1284, 4, this);

    /// <summary>
    /// FloatProperty: FFCCounterMechanicSlowMoPhase2
    /// </summary>
    public unsafe float FFCCounterMechanicSlowMoPhase2_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }
    /// <summary>
    /// FloatProperty: FFCCounterMechanicSlowMoPhase2
    /// </summary>
    public unsafe float FFCCounterMechanicSlowMoPhase2_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }
    /// <summary>
    /// FloatProperty: FFCCounterMechanicSlowMoPhase2
    /// </summary>
    public unsafe float FFCCounterMechanicSlowMoPhase2_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: FFCCounterMechanicSlowMoPhase3
    /// </summary>
    public InlineArray<float> FFCCounterMechanicSlowMoPhase3 => new(3, Ptr + 1296, 4, this);

    /// <summary>
    /// FloatProperty: FFCCounterMechanicSlowMoPhase3
    /// </summary>
    public unsafe float FFCCounterMechanicSlowMoPhase3_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }
    /// <summary>
    /// FloatProperty: FFCCounterMechanicSlowMoPhase3
    /// </summary>
    public unsafe float FFCCounterMechanicSlowMoPhase3_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }
    /// <summary>
    /// FloatProperty: FFCCounterMechanicSlowMoPhase3
    /// </summary>
    public unsafe float FFCCounterMechanicSlowMoPhase3_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }

    /// <summary>
    /// IntProperty: iCurrentSuccessiveCounterIdx
    /// </summary>
    public unsafe int iCurrentSuccessiveCounterIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: fCurrentCounterProbability
    /// </summary>
    public InlineArray<float> fCurrentCounterProbability => new(3, Ptr + 1312, 4, this);

    /// <summary>
    /// FloatProperty: fCurrentCounterProbability
    /// </summary>
    public unsafe float fCurrentCounterProbability_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }
    /// <summary>
    /// FloatProperty: fCurrentCounterProbability
    /// </summary>
    public unsafe float fCurrentCounterProbability_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }
    /// <summary>
    /// FloatProperty: fCurrentCounterProbability
    /// </summary>
    public unsafe float fCurrentCounterProbability_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// ObjectProperty: Batman
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer Batman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// ObjectProperty: BatmanPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController BatmanPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// ObjectProperty: Deathstroke
    /// </summary>
    public unsafe BmSDK.BmScript.MPawnVillainDeathStroke Deathstroke
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MPawnVillainDeathStroke>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }

    /// <summary>
    /// ObjectProperty: DS_RemoteClawPosition1_2
    /// </summary>
    public unsafe BmSDK.BmGame.RDummyTarget DS_RemoteClawPosition1_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDummyTarget>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }

    /// <summary>
    /// ObjectProperty: BM_RemoteClawPosition1_2
    /// </summary>
    public unsafe BmSDK.BmGame.RDummyTarget BM_RemoteClawPosition1_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDummyTarget>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// ObjectProperty: DS_RemoteClawPosition3
    /// </summary>
    public unsafe BmSDK.BmGame.RDummyTarget DS_RemoteClawPosition3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDummyTarget>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// ObjectProperty: BM_RemoteClawPosition3
    /// </summary>
    public unsafe BmSDK.BmGame.RDummyTarget BM_RemoteClawPosition3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDummyTarget>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// ObjectProperty: DS_BatclawEvadePosition1
    /// </summary>
    public unsafe BmSDK.BmGame.RDummyTarget DS_BatclawEvadePosition1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDummyTarget>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// ObjectProperty: DS_BatclawEvadePosition2
    /// </summary>
    public unsafe BmSDK.BmGame.RDummyTarget DS_BatclawEvadePosition2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDummyTarget>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// ObjectProperty: CenterOfRoomLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RDummyTarget CenterOfRoomLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDummyTarget>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// ObjectProperty: CenterOfRoomRight
    /// </summary>
    public unsafe BmSDK.BmGame.RDummyTarget CenterOfRoomRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDummyTarget>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// ObjectProperty: RemoteClawBox
    /// </summary>
    public unsafe BmSDK.Engine.Actor RemoteClawBox
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1368); }
    }

    /// <summary>
    /// ObjectProperty: PenguinActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor PenguinActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }

    /// <summary>
    /// ObjectProperty: DSDualClaw
    /// </summary>
    public unsafe BmSDK.BmScript.MBMWeaponDeathStrokeDualClaw DSDualClaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MBMWeaponDeathStrokeDualClaw>(Ptr + 1376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }
    }

    /// <summary>
    /// ArrayProperty: RemoteClawObjectPhase1
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.MBMBehaviour_DeathStroke.FRemoteClawObjectWave> RemoteClawObjectPhase1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.MBMBehaviour_DeathStroke.FRemoteClawObjectWave>>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }

    /// <summary>
    /// ArrayProperty: RemoteClawObjectPhase2
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.MBMBehaviour_DeathStroke.FRemoteClawObjectWave> RemoteClawObjectPhase2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.MBMBehaviour_DeathStroke.FRemoteClawObjectWave>>(Ptr + 1392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1392); }
    }

    /// <summary>
    /// ArrayProperty: RemoteClawObjectPhase3
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.MBMBehaviour_DeathStroke.FRemoteClawObjectWave> RemoteClawObjectPhase3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.MBMBehaviour_DeathStroke.FRemoteClawObjectWave>>(Ptr + 1404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1404); }
    }

    /// <summary>
    /// ObjectProperty: CurrentThrownObject
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatPoint CurrentThrownObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatPoint>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// FloatProperty: RemoteClaw_SlowMoFactor
    /// </summary>
    public unsafe float RemoteClaw_SlowMoFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// IntProperty: WaveCounter
    /// </summary>
    public unsafe int WaveCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// IntProperty: NumWaves
    /// </summary>
    public unsafe int NumWaves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1428); }
    }

    /// <summary>
    /// ObjectProperty: RopeHook1Phase2
    /// </summary>
    public unsafe BmSDK.BmGame.RHarpoonTriggerBase RopeHook1Phase2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHarpoonTriggerBase>(Ptr + 1432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }
    }

    /// <summary>
    /// ObjectProperty: RopeHook2Phase2
    /// </summary>
    public unsafe BmSDK.BmGame.RHarpoonTriggerBase RopeHook2Phase2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHarpoonTriggerBase>(Ptr + 1436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1436); }
    }

    /// <summary>
    /// ObjectProperty: RopeHook1Phase3
    /// </summary>
    public unsafe BmSDK.BmGame.RHarpoonTriggerBase RopeHook1Phase3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHarpoonTriggerBase>(Ptr + 1440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }
    }

    /// <summary>
    /// ObjectProperty: RopeHook2Phase3
    /// </summary>
    public unsafe BmSDK.BmGame.RHarpoonTriggerBase RopeHook2Phase3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHarpoonTriggerBase>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }

    /// <summary>
    /// ObjectProperty: RopeHook1
    /// </summary>
    public unsafe BmSDK.BmGame.RHarpoonTriggerBase RopeHook1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHarpoonTriggerBase>(Ptr + 1448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }
    }

    /// <summary>
    /// ObjectProperty: RopeHook2
    /// </summary>
    public unsafe BmSDK.BmGame.RHarpoonTriggerBase RopeHook2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHarpoonTriggerBase>(Ptr + 1452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1452); }
    }

    /// <summary>
    /// StructProperty: JumpToWireLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 JumpToWireLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1456);

    /// <summary>
    /// StructProperty: RetreatLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RetreatLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1468);

    /// <summary>
    /// InlineArray{FloatProperty}: DelayBeforeFirstShot
    /// </summary>
    public InlineArray<float> DelayBeforeFirstShot => new(3, Ptr + 1480, 4, this);

    /// <summary>
    /// FloatProperty: DelayBeforeFirstShot
    /// </summary>
    public unsafe float DelayBeforeFirstShot_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }
    /// <summary>
    /// FloatProperty: DelayBeforeFirstShot
    /// </summary>
    public unsafe float DelayBeforeFirstShot_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1484); }
    }
    /// <summary>
    /// FloatProperty: DelayBeforeFirstShot
    /// </summary>
    public unsafe float DelayBeforeFirstShot_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: DelayBeforeFirstShotFFC
    /// </summary>
    public InlineArray<float> DelayBeforeFirstShotFFC => new(3, Ptr + 1492, 4, this);

    /// <summary>
    /// FloatProperty: DelayBeforeFirstShotFFC
    /// </summary>
    public unsafe float DelayBeforeFirstShotFFC_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1492); }
    }
    /// <summary>
    /// FloatProperty: DelayBeforeFirstShotFFC
    /// </summary>
    public unsafe float DelayBeforeFirstShotFFC_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }
    /// <summary>
    /// FloatProperty: DelayBeforeFirstShotFFC
    /// </summary>
    public unsafe float DelayBeforeFirstShotFFC_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1500); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: DelayBetweenShotRounds
    /// </summary>
    public InlineArray<float> DelayBetweenShotRounds => new(3, Ptr + 1504, 4, this);

    /// <summary>
    /// FloatProperty: DelayBetweenShotRounds
    /// </summary>
    public unsafe float DelayBetweenShotRounds_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1504); }
    }
    /// <summary>
    /// FloatProperty: DelayBetweenShotRounds
    /// </summary>
    public unsafe float DelayBetweenShotRounds_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1508); }
    }
    /// <summary>
    /// FloatProperty: DelayBetweenShotRounds
    /// </summary>
    public unsafe float DelayBetweenShotRounds_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: DelayBetweenShots
    /// </summary>
    public InlineArray<float> DelayBetweenShots => new(3, Ptr + 1516, 4, this);

    /// <summary>
    /// FloatProperty: DelayBetweenShots
    /// </summary>
    public unsafe float DelayBetweenShots_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1516); }
    }
    /// <summary>
    /// FloatProperty: DelayBetweenShots
    /// </summary>
    public unsafe float DelayBetweenShots_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1520); }
    }
    /// <summary>
    /// FloatProperty: DelayBetweenShots
    /// </summary>
    public unsafe float DelayBetweenShots_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1524); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: DelayBetweenShotsMax
    /// </summary>
    public InlineArray<float> DelayBetweenShotsMax => new(3, Ptr + 1528, 4, this);

    /// <summary>
    /// FloatProperty: DelayBetweenShotsMax
    /// </summary>
    public unsafe float DelayBetweenShotsMax_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1528); }
    }
    /// <summary>
    /// FloatProperty: DelayBetweenShotsMax
    /// </summary>
    public unsafe float DelayBetweenShotsMax_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1532); }
    }
    /// <summary>
    /// FloatProperty: DelayBetweenShotsMax
    /// </summary>
    public unsafe float DelayBetweenShotsMax_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: DistanceToRepulseBatman
    /// </summary>
    public InlineArray<float> DistanceToRepulseBatman => new(3, Ptr + 1540, 4, this);

    /// <summary>
    /// FloatProperty: DistanceToRepulseBatman
    /// </summary>
    public unsafe float DistanceToRepulseBatman_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1540); }
    }
    /// <summary>
    /// FloatProperty: DistanceToRepulseBatman
    /// </summary>
    public unsafe float DistanceToRepulseBatman_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1544); }
    }
    /// <summary>
    /// FloatProperty: DistanceToRepulseBatman
    /// </summary>
    public unsafe float DistanceToRepulseBatman_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1548); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: DamagePerBulletPhase1
    /// </summary>
    public InlineArray<float> DamagePerBulletPhase1 => new(3, Ptr + 1552, 4, this);

    /// <summary>
    /// FloatProperty: DamagePerBulletPhase1
    /// </summary>
    public unsafe float DamagePerBulletPhase1_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1552); }
    }
    /// <summary>
    /// FloatProperty: DamagePerBulletPhase1
    /// </summary>
    public unsafe float DamagePerBulletPhase1_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1556); }
    }
    /// <summary>
    /// FloatProperty: DamagePerBulletPhase1
    /// </summary>
    public unsafe float DamagePerBulletPhase1_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: DamagePerBulletPhase2
    /// </summary>
    public InlineArray<float> DamagePerBulletPhase2 => new(3, Ptr + 1564, 4, this);

    /// <summary>
    /// FloatProperty: DamagePerBulletPhase2
    /// </summary>
    public unsafe float DamagePerBulletPhase2_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1564); }
    }
    /// <summary>
    /// FloatProperty: DamagePerBulletPhase2
    /// </summary>
    public unsafe float DamagePerBulletPhase2_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1568); }
    }
    /// <summary>
    /// FloatProperty: DamagePerBulletPhase2
    /// </summary>
    public unsafe float DamagePerBulletPhase2_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1572); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: DamagePerBulletPhase3
    /// </summary>
    public InlineArray<float> DamagePerBulletPhase3 => new(3, Ptr + 1576, 4, this);

    /// <summary>
    /// FloatProperty: DamagePerBulletPhase3
    /// </summary>
    public unsafe float DamagePerBulletPhase3_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1576); }
    }
    /// <summary>
    /// FloatProperty: DamagePerBulletPhase3
    /// </summary>
    public unsafe float DamagePerBulletPhase3_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1580); }
    }
    /// <summary>
    /// FloatProperty: DamagePerBulletPhase3
    /// </summary>
    public unsafe float DamagePerBulletPhase3_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1584); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: DamageWhenRepulsedPhase1
    /// </summary>
    public InlineArray<float> DamageWhenRepulsedPhase1 => new(3, Ptr + 1588, 4, this);

    /// <summary>
    /// FloatProperty: DamageWhenRepulsedPhase1
    /// </summary>
    public unsafe float DamageWhenRepulsedPhase1_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1588); }
    }
    /// <summary>
    /// FloatProperty: DamageWhenRepulsedPhase1
    /// </summary>
    public unsafe float DamageWhenRepulsedPhase1_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1592); }
    }
    /// <summary>
    /// FloatProperty: DamageWhenRepulsedPhase1
    /// </summary>
    public unsafe float DamageWhenRepulsedPhase1_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1596); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: DamageWhenRepulsedPhase2
    /// </summary>
    public InlineArray<float> DamageWhenRepulsedPhase2 => new(3, Ptr + 1600, 4, this);

    /// <summary>
    /// FloatProperty: DamageWhenRepulsedPhase2
    /// </summary>
    public unsafe float DamageWhenRepulsedPhase2_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1600); }
    }
    /// <summary>
    /// FloatProperty: DamageWhenRepulsedPhase2
    /// </summary>
    public unsafe float DamageWhenRepulsedPhase2_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1604); }
    }
    /// <summary>
    /// FloatProperty: DamageWhenRepulsedPhase2
    /// </summary>
    public unsafe float DamageWhenRepulsedPhase2_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1608); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: DamageWhenRepulsedPhase3
    /// </summary>
    public InlineArray<float> DamageWhenRepulsedPhase3 => new(3, Ptr + 1612, 4, this);

    /// <summary>
    /// FloatProperty: DamageWhenRepulsedPhase3
    /// </summary>
    public unsafe float DamageWhenRepulsedPhase3_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1612); }
    }
    /// <summary>
    /// FloatProperty: DamageWhenRepulsedPhase3
    /// </summary>
    public unsafe float DamageWhenRepulsedPhase3_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1616); }
    }
    /// <summary>
    /// FloatProperty: DamageWhenRepulsedPhase3
    /// </summary>
    public unsafe float DamageWhenRepulsedPhase3_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1620); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: BulletsPerRoundPhase1
    /// </summary>
    public InlineArray<float> BulletsPerRoundPhase1 => new(3, Ptr + 1624, 4, this);

    /// <summary>
    /// FloatProperty: BulletsPerRoundPhase1
    /// </summary>
    public unsafe float BulletsPerRoundPhase1_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1624); }
    }
    /// <summary>
    /// FloatProperty: BulletsPerRoundPhase1
    /// </summary>
    public unsafe float BulletsPerRoundPhase1_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1628); }
    }
    /// <summary>
    /// FloatProperty: BulletsPerRoundPhase1
    /// </summary>
    public unsafe float BulletsPerRoundPhase1_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1632); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: BulletsPerRoundPhase2
    /// </summary>
    public InlineArray<float> BulletsPerRoundPhase2 => new(3, Ptr + 1636, 4, this);

    /// <summary>
    /// FloatProperty: BulletsPerRoundPhase2
    /// </summary>
    public unsafe float BulletsPerRoundPhase2_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1636); }
    }
    /// <summary>
    /// FloatProperty: BulletsPerRoundPhase2
    /// </summary>
    public unsafe float BulletsPerRoundPhase2_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1640); }
    }
    /// <summary>
    /// FloatProperty: BulletsPerRoundPhase2
    /// </summary>
    public unsafe float BulletsPerRoundPhase2_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1644); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: BulletsPerRoundPhase3
    /// </summary>
    public InlineArray<float> BulletsPerRoundPhase3 => new(3, Ptr + 1648, 4, this);

    /// <summary>
    /// FloatProperty: BulletsPerRoundPhase3
    /// </summary>
    public unsafe float BulletsPerRoundPhase3_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1648); }
    }
    /// <summary>
    /// FloatProperty: BulletsPerRoundPhase3
    /// </summary>
    public unsafe float BulletsPerRoundPhase3_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1652); }
    }
    /// <summary>
    /// FloatProperty: BulletsPerRoundPhase3
    /// </summary>
    public unsafe float BulletsPerRoundPhase3_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1656); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: fAimingStartRadius
    /// </summary>
    public InlineArray<float> fAimingStartRadius => new(3, Ptr + 1660, 4, this);

    /// <summary>
    /// FloatProperty: fAimingStartRadius
    /// </summary>
    public unsafe float fAimingStartRadius_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1660); }
    }
    /// <summary>
    /// FloatProperty: fAimingStartRadius
    /// </summary>
    public unsafe float fAimingStartRadius_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1664); }
    }
    /// <summary>
    /// FloatProperty: fAimingStartRadius
    /// </summary>
    public unsafe float fAimingStartRadius_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1668); }
    }

    /// <summary>
    /// FloatProperty: fNumCircleBeforeShot
    /// </summary>
    public unsafe float fNumCircleBeforeShot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1672); }
    }

    /// <summary>
    /// FloatProperty: fAimingBullEyeDistance
    /// </summary>
    public unsafe float fAimingBullEyeDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1676); }
    }

    /// <summary>
    /// ObjectProperty: WarningGunLoad
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent WarningGunLoad
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1680); }
    }

    /// <summary>
    /// StructProperty: ReloadGunId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId ReloadGunId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 1684);

    /// <summary>
    /// FloatProperty: fTimeBeforeNextShot
    /// </summary>
    public unsafe float fTimeBeforeNextShot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1688); }
    }

    /// <summary>
    /// FloatProperty: fTimeBeforeNextRound
    /// </summary>
    public unsafe float fTimeBeforeNextRound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1692); }
    }

    /// <summary>
    /// FloatProperty: fAccumulatedPlayerDamage
    /// </summary>
    public unsafe float fAccumulatedPlayerDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1696); }
    }

    /// <summary>
    /// FloatProperty: fPendingDamage
    /// </summary>
    public unsafe float fPendingDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1700); }
    }

    /// <summary>
    /// IntProperty: iBulletLeftInCurrentRound
    /// </summary>
    public unsafe int iBulletLeftInCurrentRound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1704); }
    }

    /// <summary>
    /// FloatProperty: bBatClawedTimer
    /// </summary>
    public unsafe float bBatClawedTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1708); }
    }

    /// <summary>
    /// FloatProperty: fCurrentAimingRadius
    /// </summary>
    public unsafe float fCurrentAimingRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1712); }
    }

    /// <summary>
    /// FloatProperty: fInitialTimeBeforeNextShot
    /// </summary>
    public unsafe float fInitialTimeBeforeNextShot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }

    /// <summary>
    /// FloatProperty: fCurrentTimeBeforeNextShot
    /// </summary>
    public unsafe float fCurrentTimeBeforeNextShot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }
    }

    /// <summary>
    /// FloatProperty: fLastAimingSignChangeX
    /// </summary>
    public unsafe float fLastAimingSignChangeX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1724); }
    }

    /// <summary>
    /// FloatProperty: fLastAimingSignChangeY
    /// </summary>
    public unsafe float fLastAimingSignChangeY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1728); }
    }

    /// <summary>
    /// ArrayProperty: UsedCombatPoint
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatPoint> UsedCombatPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatPoint>>(Ptr + 1732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1732); }
    }

    /// <summary>
    /// FloatProperty: LastFlashbangTime
    /// </summary>
    public unsafe float LastFlashbangTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1744); }
    }

    /// <summary>
    /// FloatProperty: FlashbangTimer
    /// </summary>
    public unsafe float FlashbangTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1748); }
    }

    /// <summary>
    /// ObjectProperty: InterruptBehaviour
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBehaviour InterruptBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour>(Ptr + 1752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1752); }
    }

    /// <summary>
    /// FloatProperty: FuryTimer
    /// </summary>
    public unsafe float FuryTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1756); }
    }

    /// <summary>
    /// FloatProperty: BeeingAttackedTime
    /// </summary>
    public unsafe float BeeingAttackedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }
    }

    /// <summary>
    /// FloatProperty: CurrentFFCDodgeStrikeChance
    /// </summary>
    public unsafe float CurrentFFCDodgeStrikeChance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1764); }
    }

    /// <summary>
    /// FloatProperty: CurrentFFCDodgeCounterStrikeChance
    /// </summary>
    public unsafe float CurrentFFCDodgeCounterStrikeChance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1768); }
    }

    /// <summary>
    /// ObjectProperty: CurrentProj
    /// </summary>
    public unsafe BmSDK.BmGame.MDualClawClusterProjectile CurrentProj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MDualClawClusterProjectile>(Ptr + 1772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1772); }
    }

    /// <summary>
    /// StructProperty: JumpToWireID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId JumpToWireID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 1776);

    /// <summary>
    /// StructProperty: IdleOnWireLoop
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId IdleOnWireLoop
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 1780);

    /// <summary>
    /// StructProperty: TugOfWarID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId TugOfWarID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 1784);

    /// <summary>
    /// StructProperty: LostTugOfWarID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId LostTugOfWarID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 1788);

    /// <summary>
    /// StructProperty: WonTugOfWarID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId WonTugOfWarID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 1792);

    /// <summary>
    /// StructProperty: BraceWireID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId BraceWireID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 1796);

    /// <summary>
    /// InlineArray{IntProperty}: BeatdownHitRequired
    /// </summary>
    public InlineArray<int> BeatdownHitRequired => new(3, Ptr + 1800, 4, this);

    /// <summary>
    /// IntProperty: BeatdownHitRequired
    /// </summary>
    public unsafe int BeatdownHitRequired_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1800); }
    }
    /// <summary>
    /// IntProperty: BeatdownHitRequired
    /// </summary>
    public unsafe int BeatdownHitRequired_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1804); }
    }
    /// <summary>
    /// IntProperty: BeatdownHitRequired
    /// </summary>
    public unsafe int BeatdownHitRequired_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1808); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: BeatdownHitDamage
    /// </summary>
    public InlineArray<int> BeatdownHitDamage => new(3, Ptr + 1812, 4, this);

    /// <summary>
    /// IntProperty: BeatdownHitDamage
    /// </summary>
    public unsafe int BeatdownHitDamage_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1812); }
    }
    /// <summary>
    /// IntProperty: BeatdownHitDamage
    /// </summary>
    public unsafe int BeatdownHitDamage_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1816); }
    }
    /// <summary>
    /// IntProperty: BeatdownHitDamage
    /// </summary>
    public unsafe int BeatdownHitDamage_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1820); }
    }

    /// <summary>
    /// IntProperty: iNumBeatdownHitsLeft
    /// </summary>
    public unsafe int iNumBeatdownHitsLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1824); }
    }

    /// <summary>
    /// StructProperty: BeatdownStunLoop
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId BeatdownStunLoop
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 1828);

    /// <summary>
    /// FloatProperty: CameraCurrMaxYawOffset
    /// </summary>
    public unsafe float CameraCurrMaxYawOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1832); }
    }

    /// <summary>
    /// ObjectProperty: CurrentCameraTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor CurrentCameraTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1836); }
    }

    /// <summary>
    /// ObjectProperty: RemoteClawCam
    /// </summary>
    public unsafe BmSDK.Engine.DynamicCameraActor RemoteClawCam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DynamicCameraActor>(Ptr + 1840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1840); }
    }

    /// <summary>
    /// FloatProperty: RemoteClawCamSpeedTimer
    /// </summary>
    public unsafe float RemoteClawCamSpeedTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1844); }
    }

    /// <summary>
    /// FloatProperty: LastTimeSwitchSide
    /// </summary>
    public unsafe float LastTimeSwitchSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1848); }
    }

    /// <summary>
    /// ObjectProperty: BatmanIntroSM
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig BatmanIntroSM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// FloatProperty: fDisableTauntHit
    /// </summary>
    public unsafe float fDisableTauntHit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1856); }
    }

    /// <summary>
    /// StructProperty: FlashBangPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FlashBangPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1860);

    /// <summary>
    /// FloatProperty: TransitionTimeOld
    /// </summary>
    public unsafe float TransitionTimeOld
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1872); }
    }

    /// <summary>
    /// Struct: FRemoteClawObjectScore
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FRemoteClawObjectScore
    {
        /// <summary>
        /// FloatProperty: Dist
        /// </summary>
        public unsafe float Dist
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Height
        /// </summary>
        public unsafe float Height
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ObjectProperty: Obj
        /// </summary>
        public unsafe BmSDK.BmGame.RBMCombatPoint Obj
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatPoint>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FRemoteClawObjectWave
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FRemoteClawObjectWave
    {
        /// <summary>
        /// IntProperty: NumObjects
        /// </summary>
        public unsafe int NumObjects
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: DelayBeforeNextWave
        /// </summary>
        public unsafe float DelayBeforeNextWave
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: DamagePerObject
        /// </summary>
        public unsafe float DamagePerObject_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
        /// <summary>
        /// FloatProperty: DamagePerObject
        /// </summary>
        public unsafe float DamagePerObject_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
        /// <summary>
        /// FloatProperty: DamagePerObject
        /// </summary>
        public unsafe float DamagePerObject_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }
}
