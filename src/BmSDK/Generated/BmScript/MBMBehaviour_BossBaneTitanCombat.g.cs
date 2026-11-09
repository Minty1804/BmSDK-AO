#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MBMBehaviour_BossBaneTitanCombat<br/>
/// (size = 1080)
/// (flags = 8210)
/// </summary>
public partial class MBMBehaviour_BossBaneTitanCombat : BmSDK.BmScript.MBMBehaviour_BossBaneTitanBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MBMBehaviour_BossBaneTitanCombat", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MBMBehaviour_BossBaneTitanCombat.
    /// </summary>
    public static MBMBehaviour_BossBaneTitanCombat DefaultObject => (MBMBehaviour_BossBaneTitanCombat)StaticClass().DefaultObject;

    internal MBMBehaviour_BossBaneTitanCombat() { }

    /// <summary>
    /// Constructs a new MBMBehaviour_BossBaneTitanCombat
    /// </summary>
    public MBMBehaviour_BossBaneTitanCombat(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MBMBehaviour_BossBaneTitanCombat Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MBMBehaviour_BossBaneTitanCombat(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_BossBaneTitanCombat>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_BossBaneTitanCombat>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_BossBaneTitanCombat>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_BossBaneTitanCombat>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_BossBaneTitanCombat>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_BossBaneTitanCombat>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_BossBaneTitanCombat>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_BossBaneTitanCombat>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetObjClassVersion;
    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetObjClassVersion, "BmScript.MBMBehaviour_BossBaneTitanCombat.GetObjClassVersion");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldUseEnvironment;
    /// <summary>
    /// Function: ShouldUseEnvironment
    /// </summary>
    public unsafe override bool ShouldUseEnvironment(float DeltaTime, bool bForceCheck)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldUseEnvironment, "BmScript.MBMBehaviour_BossBaneTitanCombat.ShouldUseEnvironment");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceCheck, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetPossibleMoves;
    /// <summary>
    /// Function: GetPossibleMoves
    /// </summary>
    public unsafe override void GetPossibleMoves(out BmSDK.TArray<BmSDK.Class> PossibleMoves)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPossibleMoves, "BmScript.MBMBehaviour_BossBaneTitanCombat.GetPossibleMoves");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PossibleMoves = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Class>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_AttackTargetPawn;
    /// <summary>
    /// Function: AttackTargetPawn
    /// </summary>
    public unsafe override bool AttackTargetPawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttackTargetPawn, "BmScript.MBMBehaviour_BossBaneTitanCombat.AttackTargetPawn");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsPlayerAboveBane;
    /// <summary>
    /// Function: IsPlayerAboveBane
    /// </summary>
    public unsafe virtual bool IsPlayerAboveBane()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPlayerAboveBane, "BmScript.MBMBehaviour_BossBaneTitanCombat.IsPlayerAboveBane");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanGargoyleAttack;
    /// <summary>
    /// Function: CanGargoyleAttack
    /// </summary>
    public unsafe virtual bool CanGargoyleAttack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanGargoyleAttack, "BmScript.MBMBehaviour_BossBaneTitanCombat.CanGargoyleAttack");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayStepInDirection;
    /// <summary>
    /// Function: PlayStepInDirection
    /// </summary>
    public unsafe override void PlayStepInDirection(System.Numerics.Vector3 MoveDir, System.Numerics.Vector3 FrontDir, float MoveSize, float ForceSize, float MoveAmnt)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayStepInDirection, "BmScript.MBMBehaviour_BossBaneTitanCombat.PlayStepInDirection");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveDir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FrontDir, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveSize, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceSize, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveAmnt, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PathToCombatNotFound;
    /// <summary>
    /// Function: PathToCombatNotFound
    /// </summary>
    public unsafe override void PathToCombatNotFound(BmSDK.BmGame.RNavigationHandle Nav)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PathToCombatNotFound, "BmScript.MBMBehaviour_BossBaneTitanCombat.PathToCombatNotFound");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Nav, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldTryAndPathToCombat;
    /// <summary>
    /// Function: ShouldTryAndPathToCombat
    /// </summary>
    public unsafe override bool ShouldTryAndPathToCombat(BmSDK.BmGame.RPawnCombat CombatTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldTryAndPathToCombat, "BmScript.MBMBehaviour_BossBaneTitanCombat.ShouldTryAndPathToCombat");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_MoveToCombatRepath;
    /// <summary>
    /// Function: MoveToCombatRepath
    /// </summary>
    public unsafe override void MoveToCombatRepath()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveToCombatRepath, "BmScript.MBMBehaviour_BossBaneTitanCombat.MoveToCombatRepath");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartMoveToCombatPathSearch;
    /// <summary>
    /// Function: StartMoveToCombatPathSearch
    /// </summary>
    public unsafe override void StartMoveToCombatPathSearch()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartMoveToCombatPathSearch, "BmScript.MBMBehaviour_BossBaneTitanCombat.StartMoveToCombatPathSearch");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessTargetPawnInDanger;
    /// <summary>
    /// Function: ProcessTargetPawnInDanger
    /// </summary>
    public unsafe override void ProcessTargetPawnInDanger()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessTargetPawnInDanger, "BmScript.MBMBehaviour_BossBaneTitanCombat.ProcessTargetPawnInDanger");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasClearPathToCombat;
    /// <summary>
    /// Function: HasClearPathToCombat
    /// </summary>
    public unsafe override bool HasClearPathToCombat(bool bForceCheck = default, bool bDefaultValue = default, bool bForceCheckOnActualPosition = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasClearPathToCombat, "BmScript.MBMBehaviour_BossBaneTitanCombat.HasClearPathToCombat");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceCheck, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDefaultValue, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceCheckOnActualPosition, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetAttackPriority;
    /// <summary>
    /// Function: GetAttackPriority
    /// </summary>
    public unsafe override int GetAttackPriority(bool bForceAttack)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAttackPriority, "BmScript.MBMBehaviour_BossBaneTitanCombat.GetAttackPriority");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceAttack, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetCameraTargetMaxYaw;
    /// <summary>
    /// Function: GetCameraTargetMaxYaw
    /// </summary>
    public unsafe virtual float GetCameraTargetMaxYaw()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCameraTargetMaxYaw, "BmScript.MBMBehaviour_BossBaneTitanCombat.GetCameraTargetMaxYaw");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsValidForStrike;
    /// <summary>
    /// Function: IsValidForStrike
    /// </summary>
    public unsafe virtual bool IsValidForStrike(BmSDK.BmGame.RPawnPlayerCombat thePlayer, BmSDK.BmGame.RPawnCombat TestPawn, BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidForStrike, "BmScript.MBMBehaviour_BossBaneTitanCombat.IsValidForStrike");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(thePlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_IsReadyForStun;
    /// <summary>
    /// Function: IsReadyForStun
    /// </summary>
    public unsafe virtual bool IsReadyForStun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsReadyForStun, "BmScript.MBMBehaviour_BossBaneTitanCombat.IsReadyForStun");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsBatarangDamage;
    /// <summary>
    /// Function: IsBatarangDamage
    /// </summary>
    public unsafe virtual bool IsBatarangDamage(BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBatarangDamage, "BmScript.MBMBehaviour_BossBaneTitanCombat.IsBatarangDamage");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsVulnerableToPawn;
    /// <summary>
    /// Function: IsVulnerableToPawn
    /// </summary>
    public unsafe virtual bool IsVulnerableToPawn(BmSDK.BmGame.RPawnCombat Attacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsVulnerableToPawn, "BmScript.MBMBehaviour_BossBaneTitanCombat.IsVulnerableToPawn");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsVulnerableToBossStrike;
    /// <summary>
    /// Function: IsVulnerableToBossStrike
    /// </summary>
    public unsafe virtual bool IsVulnerableToBossStrike()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsVulnerableToBossStrike, "BmScript.MBMBehaviour_BossBaneTitanCombat.IsVulnerableToBossStrike");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RefreshVisualContact;
    /// <summary>
    /// Function: RefreshVisualContact
    /// </summary>
    public unsafe virtual void RefreshVisualContact()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RefreshVisualContact, "BmScript.MBMBehaviour_BossBaneTitanCombat.RefreshVisualContact");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BossTickInternal;
    /// <summary>
    /// Function: BossTickInternal
    /// </summary>
    public unsafe override void BossTickInternal(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BossTickInternal, "BmScript.MBMBehaviour_BossBaneTitanCombat.BossTickInternal");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmScript.MBMBehaviour_BossBaneTitanCombat.Tick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnBeginInterrupt;
    /// <summary>
    /// Function: OnBeginInterrupt
    /// </summary>
    public unsafe override void OnBeginInterrupt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBeginInterrupt, "BmScript.MBMBehaviour_BossBaneTitanCombat.OnBeginInterrupt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnEndInterrupt;
    /// <summary>
    /// Function: OnEndInterrupt
    /// </summary>
    public unsafe override void OnEndInterrupt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnEndInterrupt, "BmScript.MBMBehaviour_BossBaneTitanCombat.OnEndInterrupt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnDeactivate;
    /// <summary>
    /// Function: OnDeactivate
    /// </summary>
    public unsafe override void OnDeactivate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDeactivate, "BmScript.MBMBehaviour_BossBaneTitanCombat.OnDeactivate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnActivate;
    /// <summary>
    /// Function: OnActivate
    /// </summary>
    public unsafe override void OnActivate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnActivate, "BmScript.MBMBehaviour_BossBaneTitanCombat.OnActivate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// FloatProperty: LastAttackTimestamp
    /// </summary>
    public unsafe float LastAttackTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// FloatProperty: CameraCurrMaxYawOffset
    /// </summary>
    public unsafe float CameraCurrMaxYawOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// ObjectProperty: CurrentCameraTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor CurrentCameraTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// ByteProperty: CurrentCameraSpeed
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.CameraLookAtSpeed CurrentCameraSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.CameraLookAtSpeed>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: SawPlayerEscaping
    /// </summary>
    public unsafe bool SawPlayerEscaping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: bVentOrGrateAttackTriggered
    /// </summary>
    public unsafe bool bVentOrGrateAttackTriggered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1060); }
    }

    /// <summary>
    /// StructProperty: CurrWallForce
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrWallForce
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1064);

    /// <summary>
    /// IntProperty: WallSideCount
    /// </summary>
    public unsafe int WallSideCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }
}
