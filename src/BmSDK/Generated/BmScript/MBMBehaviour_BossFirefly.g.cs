#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MBMBehaviour_BossFirefly<br/>
/// (size = 2400)
/// (flags = 8210)
/// </summary>
public partial class MBMBehaviour_BossFirefly : BmSDK.BmGame.RBMBehaviour_Combat, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MBMBehaviour_BossFirefly", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MBMBehaviour_BossFirefly.
    /// </summary>
    public static MBMBehaviour_BossFirefly DefaultObject => (MBMBehaviour_BossFirefly)StaticClass().DefaultObject;

    internal MBMBehaviour_BossFirefly() { }

    /// <summary>
    /// Constructs a new MBMBehaviour_BossFirefly
    /// </summary>
    public MBMBehaviour_BossFirefly(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MBMBehaviour_BossFirefly Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MBMBehaviour_BossFirefly(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_BossFirefly>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_BossFirefly>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_BossFirefly>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_BossFirefly>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_BossFirefly>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_BossFirefly>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_BossFirefly>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_BossFirefly>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CheckDodgeProjectile
    /// </summary>
    public unsafe virtual bool CheckDodgeProjectile(BmSDK.BmGame.RPawn Thrower, BmSDK.FName TargetBone, System.Numerics.Vector3 ProjPos, int BatarangID, bool bForceDodge = default, bool bSteerableProj = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.CheckDodgeProjectile", true);
        byte* paramsPtr = stackalloc byte[52];
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
    /// Function: FallingCarHit
    /// </summary>
    public unsafe virtual void FallingCarHit(BmSDK.Engine.Actor car)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.FallingCarHit", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(car, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetFallingCars
    /// </summary>
    public unsafe virtual void GetFallingCars(out BmSDK.Engine.Actor car1, out BmSDK.Engine.Actor car2, out BmSDK.Engine.Actor car3, out BmSDK.Engine.Actor car4, out BmSDK.Engine.Actor car5)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.GetFallingCars", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        car1 = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 0);
        car2 = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 4);
        car3 = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 8);
        car4 = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 12);
        car5 = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 16);
        return;
    }

    /// <summary>
    /// Function: Update
    /// </summary>
    public unsafe override bool Update(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.Update", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: TriggerEndCinematique
    /// </summary>
    public unsafe virtual void TriggerEndCinematique()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.TriggerEndCinematique", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FindFlameWallTarget
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 FindFlameWallTarget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.FindFlameWallTarget", true);
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: MoveToNextAnchor
    /// </summary>
    public unsafe virtual void MoveToNextAnchor()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.MoveToNextAnchor", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetCurrentAnchorsList
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MFireflyAnchorPoint GetCurrentAnchorsList()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.GetCurrentAnchorsList", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MFireflyAnchorPoint>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetClosestAnchorToPlayer
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MFireflyAnchorPoint GetClosestAnchorToPlayer(BmSDK.BmGame.MFireflyAnchorPoint NotThatOne = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.GetClosestAnchorToPlayer", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NotThatOne, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MFireflyAnchorPoint>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetNearestAnchorLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetNearestAnchorLocation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.GetNearestAnchorLocation", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: UpdatePlayerVisibility
    /// </summary>
    public unsafe virtual void UpdatePlayerVisibility()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.UpdatePlayerVisibility", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckForSmoke
    /// </summary>
    public unsafe virtual bool CheckForSmoke()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.CheckForSmoke", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: StartTugOfWar
    /// </summary>
    public unsafe virtual void StartTugOfWar()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.StartTugOfWar", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetClosestTugOfWarLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetClosestTugOfWarLocation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.GetClosestTugOfWarLocation", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetPreviousPlayerPos
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetPreviousPlayerPos(float BackTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.GetPreviousPlayerPos", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BackTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: CheckForPhaseBAttacks
    /// </summary>
    public unsafe virtual bool CheckForPhaseBAttacks()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.CheckForPhaseBAttacks", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CheckForPhaseAAttacks
    /// </summary>
    public unsafe virtual bool CheckForPhaseAAttacks()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.CheckForPhaseAAttacks", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GrenadeAttackOnPlayer
    /// </summary>
    public unsafe virtual void GrenadeAttackOnPlayer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.GrenadeAttackOnPlayer", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartPhaseB
    /// </summary>
    public unsafe virtual void StartPhaseB()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.StartPhaseB", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartPhaseC
    /// </summary>
    public unsafe virtual void StartPhaseC()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.StartPhaseC", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartNavigationChallenge
    /// </summary>
    public unsafe virtual void StartNavigationChallenge()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.StartNavigationChallenge", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FireAt
    /// </summary>
    public unsafe virtual void FireAt(System.Numerics.Vector3 TargetPos, bool DoFireballs, float FireBallSpeed = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.FireAt", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DoFireballs, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireBallSpeed, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FireAtPlayer
    /// </summary>
    public unsafe virtual void FireAtPlayer(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.FireAtPlayer", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopFiringAttack
    /// </summary>
    public unsafe virtual void StopFiringAttack()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.StopFiringAttack", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BossTickInternal
    /// </summary>
    public unsafe virtual void BossTickInternal(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.BossTickInternal", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetPossibleMoves
    /// </summary>
    public unsafe override void GetPossibleMoves(out BmSDK.TArray<BmSDK.Class> PossibleMoves)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.GetPossibleMoves", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PossibleMoves = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: BurnSecondHalfGround
    /// </summary>
    public unsafe virtual void BurnSecondHalfGround()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.BurnSecondHalfGround", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BurnFirstHalfGround
    /// </summary>
    public unsafe virtual void BurnFirstHalfGround()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.BurnFirstHalfGround", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ThrowGrenadeNotify
    /// </summary>
    public unsafe virtual void ThrowGrenadeNotify()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.ThrowGrenadeNotify", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GotoNextState
    /// </summary>
    public unsafe virtual void GotoNextState()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.GotoNextState", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlaySharedSpeech
    /// </summary>
    public unsafe virtual void PlaySharedSpeech(BmSDK.Engine.RDialogueLine FireflyLine, BmSDK.Engine.RDialogueLine BatLine, BmSDK.BmGame.RGameInfo.VocalPriority Priority = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.PlaySharedSpeech", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireflyLine, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatLine, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsFiringAttack
    /// </summary>
    public unsafe virtual bool IsFiringAttack(bool IsDeploying = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.IsFiringAttack", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsDeploying, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: OnDeactivate
    /// </summary>
    public unsafe override void OnDeactivate()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.OnDeactivate", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnEndInterrupt
    /// </summary>
    public unsafe override void OnEndInterrupt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.OnEndInterrupt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnBeginInterrupt
    /// </summary>
    public unsafe override void OnBeginInterrupt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.OnBeginInterrupt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnActivate
    /// </summary>
    public unsafe override void OnActivate()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.OnActivate", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerIncendiaryGrenadeAttack
    /// </summary>
    public unsafe virtual void TriggerIncendiaryGrenadeAttack()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.TriggerIncendiaryGrenadeAttack", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetLandingGrenadeLocs
    /// </summary>
    public unsafe virtual BmSDK.TArray<System.Numerics.Vector3> GetLandingGrenadeLocs()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.GetLandingGrenadeLocs", true);
        byte* paramsPtr = stackalloc byte[116];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: TriggerAction
    /// </summary>
    public unsafe virtual void TriggerAction(BmSDK.BmScript.MBMBehaviour_BossFirefly.FActionModel Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.TriggerAction", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerNextAction
    /// </summary>
    public unsafe virtual void TriggerNextAction()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.TriggerNextAction", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetCurrentActionIndex
    /// </summary>
    public unsafe virtual void ResetCurrentActionIndex()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.ResetCurrentActionIndex", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateCurrentPaternIndex
    /// </summary>
    public unsafe virtual void UpdateCurrentPaternIndex()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBMBehaviour_BossFirefly.UpdateCurrentPaternIndex", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FActionPatern
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FActionPatern
    {
        /// <summary>
        /// IntProperty: MinHP
        /// </summary>
        public unsafe int MinHP
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: MaxHP
        /// </summary>
        public unsafe int MaxHP
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ArrayProperty: Actions
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmScript.MBMBehaviour_BossFirefly.FActionModel> Actions
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.MBMBehaviour_BossFirefly.FActionModel>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FActionModel
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FActionModel
    {
        /// <summary>
        /// ByteProperty: ActionType
        /// </summary>
        public unsafe BmSDK.BmScript.MBMBehaviour_BossFirefly.FireflyActionType ActionType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MBMBehaviour_BossFirefly.FireflyActionType>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: NumberAction
        /// </summary>
        public unsafe int NumberAction
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Enum: FireflyActionType
    /// </summary>
    public enum FireflyActionType : byte
    {
        FFAT_None = 0,
        FFAT_Talk = 1,
        FFAT_FireBall = 2,
        FFAT_FireWall = 3,
        FFAT_FireLaneCharge = 4,
        FFAT_IncendiaryGrenade = 5,
        FFAT_OverHeat = 6,
        FFAT_BurnGround = 7,
        FFAT_PhaseCSeq = 8,
        FFAT_MAX = 9,
    }

    /// <summary>
    /// ObjectProperty: PhaseA_AttackNodes
    /// </summary>
    public unsafe BmSDK.BmGame.MFireflyAnchorPoint PhaseA_AttackNodes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MFireflyAnchorPoint>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// ArrayProperty: LaneA_GrenadePoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDummyTarget> LaneA_GrenadePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDummyTarget>>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// ArrayProperty: LaneB_GrenadePoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDummyTarget> LaneB_GrenadePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDummyTarget>>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// ObjectProperty: PhaseB_AttackNodes
    /// </summary>
    public unsafe BmSDK.BmGame.MFireflyAnchorPoint PhaseB_AttackNodes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MFireflyAnchorPoint>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// ObjectProperty: BurnGroundAnchor
    /// </summary>
    public unsafe BmSDK.BmGame.MFireflyAnchorPoint BurnGroundAnchor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MFireflyAnchorPoint>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// ArrayProperty: PhaseB_ListNodes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MFireflyAnchorPoint> PhaseB_ListNodes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MFireflyAnchorPoint>>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// ObjectProperty: NavigationPhaseNodes
    /// </summary>
    public unsafe BmSDK.BmGame.MFireflyAnchorPoint NavigationPhaseNodes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MFireflyAnchorPoint>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// ObjectProperty: PhaseC_AttackNodes
    /// </summary>
    public unsafe BmSDK.BmGame.MFireflyAnchorPoint PhaseC_AttackNodes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MFireflyAnchorPoint>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// ObjectProperty: FallingCar1
    /// </summary>
    public unsafe BmSDK.Engine.Actor FallingCar1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// ObjectProperty: FallingCar2
    /// </summary>
    public unsafe BmSDK.Engine.Actor FallingCar2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// ObjectProperty: FallingCar3
    /// </summary>
    public unsafe BmSDK.Engine.Actor FallingCar3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// ObjectProperty: FallingCar4
    /// </summary>
    public unsafe BmSDK.Engine.Actor FallingCar4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// ObjectProperty: FallingCar5
    /// </summary>
    public unsafe BmSDK.Engine.Actor FallingCar5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// ObjectProperty: ForceAnchorPoint
    /// </summary>
    public unsafe BmSDK.BmGame.MFireflyAnchorPoint ForceAnchorPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MFireflyAnchorPoint>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// ObjectProperty: ForceTargetActor
    /// </summary>
    public unsafe BmSDK.GameObject ForceTargetActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// FloatProperty: TgtPrevPlyPosTime
    /// </summary>
    public unsafe float TgtPrevPlyPosTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// ObjectProperty: SFXFlamethrower_Empty
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SFXFlamethrower_Empty
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// ObjectProperty: SFXFireBall_ChargeUp
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SFXFireBall_ChargeUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// StructProperty: SFXFireBall_Fire_Handle
    /// </summary>
    public unsafe ref BmSDK.Engine.AkWwise.FAkSoundHandle SFXFireBall_Fire_Handle
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 616);

    /// <summary>
    /// ObjectProperty: Firefly
    /// </summary>
    public unsafe BmSDK.BmScript.MPawnVillainFirefly Firefly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MPawnVillainFirefly>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// ObjectProperty: PlayerPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer PlayerPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// FloatProperty: StateTime
    /// </summary>
    public unsafe float StateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// ObjectProperty: CurrentAnchor
    /// </summary>
    public unsafe BmSDK.BmGame.MFireflyAnchorPoint CurrentAnchor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MFireflyAnchorPoint>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// ObjectProperty: NextAnchor
    /// </summary>
    public unsafe BmSDK.BmGame.MFireflyAnchorPoint NextAnchor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MFireflyAnchorPoint>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// FloatProperty: UpdatePlayerVisibilityTimer
    /// </summary>
    public unsafe float UpdatePlayerVisibilityTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// ByteProperty: CurrentPlayerVisibility
    /// </summary>
    public unsafe BmSDK.BmScript.MBMBehaviour_BossFirefly.PlayerVisibility CurrentPlayerVisibility
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MBMBehaviour_BossFirefly.PlayerVisibility>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// ByteProperty: CurrentThrowGrenadeType
    /// </summary>
    public unsafe BmSDK.BmGame.MFireflyAnchorPoint.GrenadeType CurrentThrowGrenadeType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MFireflyAnchorPoint.GrenadeType>(Ptr + 653); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 653); }
    }

    /// <summary>
    /// ByteProperty: LastAction
    /// </summary>
    public unsafe BmSDK.BmScript.MBMBehaviour_BossFirefly.FireflyActionType LastAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MBMBehaviour_BossFirefly.FireflyActionType>(Ptr + 654); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 654); }
    }

    /// <summary>
    /// IntProperty: CurrentFlamethrowerSalve
    /// </summary>
    public unsafe int CurrentFlamethrowerSalve
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// FloatProperty: TimeBeforeNextFlamethrowerProj
    /// </summary>
    public unsafe float TimeBeforeNextFlamethrowerProj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// FloatProperty: LastFlameBurstTimestamp
    /// </summary>
    public unsafe float LastFlameBurstTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// FloatProperty: LastGrenadeThrownTimestamp
    /// </summary>
    public unsafe float LastGrenadeThrownTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// FloatProperty: PlayerEnteredCoverTimestamp
    /// </summary>
    public unsafe float PlayerEnteredCoverTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// StructProperty: JumpAnimID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId JumpAnimID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 676);

    /// <summary>
    /// StructProperty: LiftUpAnimId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId LiftUpAnimId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 680);

    /// <summary>
    /// StructProperty: RecoverAnimId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId RecoverAnimId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 684);

    /// <summary>
    /// StructProperty: LandDownAnimId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId LandDownAnimId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 688);

    /// <summary>
    /// StructProperty: LaneChargeAnimId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId LaneChargeAnimId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 692);

    /// <summary>
    /// StructProperty: RemoteClawedIntroAnimId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId RemoteClawedIntroAnimId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 696);

    /// <summary>
    /// StructProperty: RemoteClawedOutroAnimId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId RemoteClawedOutroAnimId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 700);

    /// <summary>
    /// StructProperty: CurrentTransitionId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId CurrentTransitionId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 704);

    /// <summary>
    /// StructProperty: TOWIntroTransitionId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId TOWIntroTransitionId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 708);

    /// <summary>
    /// StructProperty: FlyingFiringInId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId FlyingFiringInId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 712);

    /// <summary>
    /// StructProperty: FlyingFiringOutId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId FlyingFiringOutId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 716);

    /// <summary>
    /// StructProperty: FlyingTransitionId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId FlyingTransitionId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 720);

    /// <summary>
    /// StructProperty: SpecialStunRecoverId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId SpecialStunRecoverId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 724);

    /// <summary>
    /// BoolProperty: IsTalking
    /// </summary>
    public unsafe bool IsTalking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: bVulnerableToGadget
    /// </summary>
    public unsafe bool bVulnerableToGadget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: AnchorGrenadeOverridesCompleted
    /// </summary>
    public unsafe bool AnchorGrenadeOverridesCompleted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: AnchorFlamethrowerOverridesCompleted
    /// </summary>
    public unsafe bool AnchorFlamethrowerOverridesCompleted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: HasEmptiedGasTankWithRollingFlames
    /// </summary>
    public unsafe bool HasEmptiedGasTankWithRollingFlames
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: MoveBeforeLaneCharge
    /// </summary>
    public unsafe bool MoveBeforeLaneCharge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: FireWallOn
    /// </summary>
    public unsafe bool FireWallOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: GrapplingToRollCoaster
    /// </summary>
    public unsafe bool GrapplingToRollCoaster
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: FlamewallDone
    /// </summary>
    public unsafe bool FlamewallDone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: OverHeatFirstTime
    /// </summary>
    public unsafe bool OverHeatFirstTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: IsGroundBurnt
    /// </summary>
    public unsafe bool IsGroundBurnt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: DoMoveToNextAnchor
    /// </summary>
    public unsafe bool DoMoveToNextAnchor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: FireWallWait
    /// </summary>
    public unsafe bool FireWallWait
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: DoneFirstFireWallCam
    /// </summary>
    public unsafe bool DoneFirstFireWallCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: DisplayFireWallPromt
    /// </summary>
    public unsafe bool DisplayFireWallPromt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: FireWallKismetOutPut
    /// </summary>
    public unsafe bool FireWallKismetOutPut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: bThrowGrenadeNotify
    /// </summary>
    public unsafe bool bThrowGrenadeNotify
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: bPlayerInSafeGround
    /// </summary>
    public unsafe bool bPlayerInSafeGround
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: IsFiring
    /// </summary>
    public unsafe bool IsFiring
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: JustStartFight
    /// </summary>
    public unsafe bool JustStartFight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: bActionNoTalking
    /// </summary>
    public unsafe bool bActionNoTalking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: bActionNoOverHeat
    /// </summary>
    public unsafe bool bActionNoOverHeat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: bActionNoWindowOfOpportunity
    /// </summary>
    public unsafe bool bActionNoWindowOfOpportunity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 728); }
    }

    /// <summary>
    /// FloatProperty: ReloadTimeLeft
    /// </summary>
    public unsafe float ReloadTimeLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ObjectProperty: DCP
    /// </summary>
    public unsafe BmSDK.BmGame.MDualClawProjectile DCP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MDualClawProjectile>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// ObjectProperty: CurrentCustomAnchor
    /// </summary>
    public unsafe BmSDK.BmGame.MFireflyAnchorPoint CurrentCustomAnchor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MFireflyAnchorPoint>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// StructProperty: CurrentForceTargetLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentForceTargetLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 744);

    /// <summary>
    /// IntProperty: NumBurstsToDo
    /// </summary>
    public unsafe int NumBurstsToDo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// FloatProperty: DelayBetweenBurstsToDo
    /// </summary>
    public unsafe float DelayBetweenBurstsToDo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// FloatProperty: BurstSpeedToDo
    /// </summary>
    public unsafe float BurstSpeedToDo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// StructProperty: TargetOffsetToDo
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TargetOffsetToDo
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 768);

    /// <summary>
    /// InlineArray{StructProperty}: PreviousPlayerPos
    /// </summary>
    public InlineArray<System.Numerics.Vector3> PreviousPlayerPos => new(100, Ptr + 780, 12, this);

    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 780);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 792);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 804);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 816);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 828);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 840);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 852);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 864);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 876);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_9
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 888);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_10
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 900);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_11
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 912);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_12
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 924);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_13
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 936);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_14
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 948);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_15
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 960);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_16
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 972);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_17
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 984);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_18
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 996);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_19
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1008);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_20
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1020);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_21
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1032);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_22
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1044);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_23
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1056);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_24
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1068);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_25
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1080);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_26
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1092);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_27
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1104);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_28
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1116);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_29
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1128);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_30
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1140);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_31
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1152);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_32
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1164);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_33
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1176);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_34
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1188);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_35
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1200);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_36
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1212);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_37
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1224);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_38
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1236);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_39
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1248);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_40
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1260);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_41
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1272);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_42
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1284);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_43
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1296);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_44
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1308);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_45
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1320);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_46
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1332);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_47
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1344);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_48
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1356);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_49
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1368);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_50
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1380);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_51
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1392);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_52
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1404);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_53
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1416);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_54
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1428);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_55
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1440);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_56
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1452);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_57
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1464);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_58
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1476);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_59
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1488);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_60
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1500);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_61
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1512);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_62
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1524);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_63
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1536);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_64
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1548);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_65
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1560);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_66
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1572);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_67
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1584);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_68
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1596);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_69
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1608);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_70
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1620);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_71
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1632);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_72
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1644);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_73
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1656);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_74
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1668);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_75
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1680);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_76
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1692);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_77
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1704);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_78
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1716);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_79
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1728);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_80
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1740);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_81
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1752);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_82
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1764);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_83
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1776);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_84
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1788);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_85
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1800);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_86
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1812);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_87
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1824);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_88
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1836);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_89
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1848);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_90
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1860);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_91
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1872);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_92
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1884);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_93
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1896);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_94
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1908);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_95
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1920);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_96
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1932);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_97
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1944);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_98
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1956);
    /// <summary>
    /// StructProperty: PreviousPlayerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreviousPlayerPos_99
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1968);

    /// <summary>
    /// IntProperty: PreviousPosIdx
    /// </summary>
    public unsafe int PreviousPosIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1980); }
    }

    /// <summary>
    /// FloatProperty: LastPlayerPosRecordTime
    /// </summary>
    public unsafe float LastPlayerPosRecordTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1984); }
    }

    /// <summary>
    /// IntProperty: NumFireBall
    /// </summary>
    public unsafe int NumFireBall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1988); }
    }

    /// <summary>
    /// IntProperty: NumFireWall
    /// </summary>
    public unsafe int NumFireWall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1992); }
    }

    /// <summary>
    /// IntProperty: NumLaneCharge
    /// </summary>
    public unsafe int NumLaneCharge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1996); }
    }

    /// <summary>
    /// StructProperty: NodeDirection
    /// </summary>
    public unsafe ref System.Numerics.Vector3 NodeDirection
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2000);

    /// <summary>
    /// FloatProperty: NodeSpeed
    /// </summary>
    public unsafe float NodeSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2012); }
    }

    /// <summary>
    /// IntProperty: OverheatAnimCnt
    /// </summary>
    public unsafe int OverheatAnimCnt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2016); }
    }

    /// <summary>
    /// IntProperty: screenShakeID
    /// </summary>
    public unsafe int screenShakeID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2020); }
    }

    /// <summary>
    /// StructProperty: ScreenShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 2024);

    /// <summary>
    /// StructProperty: GrapplingMovingUpCameraConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig GrapplingMovingUpCameraConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 2168);

    /// <summary>
    /// ArrayProperty: TugOfWarDummies
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDummyTarget> TugOfWarDummies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDummyTarget>>(Ptr + 2304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }
    }

    /// <summary>
    /// ObjectProperty: LaneEndAnchor
    /// </summary>
    public unsafe BmSDK.BmGame.MFireflyAnchorPoint LaneEndAnchor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MFireflyAnchorPoint>(Ptr + 2316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2316); }
    }

    /// <summary>
    /// StructProperty: FlameWallTrailDirection
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FlameWallTrailDirection
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2320);

    /// <summary>
    /// IntProperty: FlameWallTrailNumber
    /// </summary>
    public unsafe int FlameWallTrailNumber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2332); }
    }

    /// <summary>
    /// IntProperty: FlameWallTrailIndex
    /// </summary>
    public unsafe int FlameWallTrailIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2336); }
    }

    /// <summary>
    /// FloatProperty: FlamewallFiringTimer
    /// </summary>
    public unsafe float FlamewallFiringTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2340); }
    }

    /// <summary>
    /// IntProperty: CurrentAnchorIndex
    /// </summary>
    public unsafe int CurrentAnchorIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2344); }
    }

    /// <summary>
    /// IntProperty: BurnGroundAttack
    /// </summary>
    public unsafe int BurnGroundAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2348); }
    }

    /// <summary>
    /// ArrayProperty: CurrentThrowGrenadeTarget
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> CurrentThrowGrenadeTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 2352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2352); }
    }

    /// <summary>
    /// IntProperty: NumFireWallBurst
    /// </summary>
    public unsafe int NumFireWallBurst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2364); }
    }

    /// <summary>
    /// IntProperty: NumFireWallToDo
    /// </summary>
    public unsafe int NumFireWallToDo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2368); }
    }

    /// <summary>
    /// IntProperty: NumIncGrenadeToDo
    /// </summary>
    public unsafe int NumIncGrenadeToDo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2372); }
    }

    /// <summary>
    /// FloatProperty: VelocityTimer
    /// </summary>
    public unsafe float VelocityTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2376); }
    }

    /// <summary>
    /// ArrayProperty: ActionPaterns
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.MBMBehaviour_BossFirefly.FActionPatern> ActionPaterns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.MBMBehaviour_BossFirefly.FActionPatern>>(Ptr + 2380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2380); }
    }

    /// <summary>
    /// IntProperty: CurrentPaternIndex
    /// </summary>
    public unsafe int CurrentPaternIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2392); }
    }

    /// <summary>
    /// IntProperty: CurrentActionIndex
    /// </summary>
    public unsafe int CurrentActionIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2396); }
    }

    /// <summary>
    /// Enum: PlayerVisibility
    /// </summary>
    public enum PlayerVisibility : byte
    {
        PV_Visible = 0,
        PV_PartiallyVisible = 1,
        PV_Hidden = 2,
        PV_InCover = 3,
        PV_Num = 4,
        PV_MAX = 5,
    }
}
