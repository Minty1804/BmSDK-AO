#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MAEC_VulnerableCondition_Sub_RictusInfected<br/>
/// (size = 524)
/// (flags = 8388626)
/// </summary>
public partial class MAEC_VulnerableCondition_Sub_RictusInfected : BmSDK.BmGame.MAEC_VulnerableCondition_Base, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MAEC_VulnerableCondition_Sub_RictusInfected", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MAEC_VulnerableCondition_Sub_RictusInfected.
    /// </summary>
    public static MAEC_VulnerableCondition_Sub_RictusInfected DefaultObject => (MAEC_VulnerableCondition_Sub_RictusInfected)StaticClass().DefaultObject;

    internal MAEC_VulnerableCondition_Sub_RictusInfected() { }

    /// <summary>
    /// Constructs a new MAEC_VulnerableCondition_Sub_RictusInfected
    /// </summary>
    public MAEC_VulnerableCondition_Sub_RictusInfected(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MAEC_VulnerableCondition_Sub_RictusInfected(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MAEC_VulnerableCondition_Sub_RictusInfected>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MAEC_VulnerableCondition_Sub_RictusInfected>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MAEC_VulnerableCondition_Sub_RictusInfected>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MAEC_VulnerableCondition_Sub_RictusInfected>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MAEC_VulnerableCondition_Sub_RictusInfected>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MAEC_VulnerableCondition_Sub_RictusInfected>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MAEC_VulnerableCondition_Sub_RictusInfected>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MAEC_VulnerableCondition_Sub_RictusInfected>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_VillainStolen;
    /// <summary>
    /// Function: VillainStolen
    /// </summary>
    public unsafe override void VillainStolen(BmSDK.BmGame.RBMAIController Stolen)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VillainStolen, "BmGame.MAEC_VulnerableCondition_Sub_RictusInfected.VillainStolen");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stolen, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitCoordinator;
    /// <summary>
    /// Function: InitCoordinator
    /// </summary>
    public unsafe override void InitCoordinator(BmSDK.BmGame.RBMAIController AIController)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitCoordinator, "BmGame.MAEC_VulnerableCondition_Sub_RictusInfected.InitCoordinator");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AIController, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleSecondryInfectedTarget;
    /// <summary>
    /// Function: HandleSecondryInfectedTarget
    /// </summary>
    public unsafe virtual bool HandleSecondryInfectedTarget(BmSDK.BmGame.RBMPawnAI Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleSecondryInfectedTarget, "BmGame.MAEC_VulnerableCondition_Sub_RictusInfected.HandleSecondryInfectedTarget");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HandlePrimaryInfectedTarget;
    /// <summary>
    /// Function: HandlePrimaryInfectedTarget
    /// </summary>
    public unsafe virtual bool HandlePrimaryInfectedTarget(BmSDK.BmGame.RBMPawnAI Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandlePrimaryInfectedTarget, "BmGame.MAEC_VulnerableCondition_Sub_RictusInfected.HandlePrimaryInfectedTarget");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HandleInfectedTarget;
    /// <summary>
    /// Function: HandleInfectedTarget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MAEC_VulnerableCondition_Sub_ReactToStrangeBehaviour HandleInfectedTarget(BmSDK.BmGame.RBMPawnAI Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleInfectedTarget, "BmGame.MAEC_VulnerableCondition_Sub_RictusInfected.HandleInfectedTarget");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MAEC_VulnerableCondition_Sub_ReactToStrangeBehaviour>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_StartFlee;
    /// <summary>
    /// Function: StartFlee
    /// </summary>
    public unsafe virtual bool StartFlee(out BmSDK.BmGame.MAEC_VulnerableCondition_Base coordinator)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartFlee, "BmGame.MAEC_VulnerableCondition_Sub_RictusInfected.StartFlee");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out coordinator);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(coordinator, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        coordinator = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MAEC_VulnerableCondition_Base>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_StartCringe;
    /// <summary>
    /// Function: StartCringe
    /// </summary>
    public unsafe virtual bool StartCringe()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartCringe, "BmGame.MAEC_VulnerableCondition_Sub_RictusInfected.StartCringe");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RictusEffectFinished;
    /// <summary>
    /// Function: RictusEffectFinished
    /// </summary>
    public unsafe virtual void RictusEffectFinished()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RictusEffectFinished, "BmGame.MAEC_VulnerableCondition_Sub_RictusInfected.RictusEffectFinished");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleTargetRemoved;
    /// <summary>
    /// Function: HandleTargetRemoved
    /// </summary>
    public unsafe virtual void HandleTargetRemoved(BmSDK.BmGame.RBMPawnAI Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleTargetRemoved, "BmGame.MAEC_VulnerableCondition_Sub_RictusInfected.HandleTargetRemoved");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InfectedHostStartsShooting;
    /// <summary>
    /// Function: InfectedHostStartsShooting
    /// </summary>
    public unsafe virtual void InfectedHostStartsShooting()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InfectedHostStartsShooting, "BmGame.MAEC_VulnerableCondition_Sub_RictusInfected.InfectedHostStartsShooting");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckIfCanBeClaimed;
    /// <summary>
    /// Function: CheckIfCanBeClaimed
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MAEC_VulnerableCondition_Sub_ReactToStrangeBehaviour CheckIfCanBeClaimed(float Priority, BmSDK.Class SpawnClass, BmSDK.BmGame.RBMAIController CurrContoller)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckIfCanBeClaimed, "BmGame.MAEC_VulnerableCondition_Sub_RictusInfected.CheckIfCanBeClaimed");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnClass, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrContoller, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MAEC_VulnerableCondition_Sub_ReactToStrangeBehaviour>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.MAEC_VulnerableCondition_Sub_RictusInfected.Tick");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyFinished;
    /// <summary>
    /// Function: NotifyFinished
    /// </summary>
    public unsafe override void NotifyFinished(BmSDK.BmGame.RBMAIController FinishedCon, BmSDK.BmGame.RBMAIAction FinishedAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyFinished, "BmGame.MAEC_VulnerableCondition_Sub_RictusInfected.NotifyFinished");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedCon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedAction, paramsPtr + 4);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.MAEC_VulnerableCondition_Sub_RictusInfected.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// FloatProperty: ReactToStrangeBehaviourPriority
    /// </summary>
    public unsafe float ReactToStrangeBehaviourPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// FloatProperty: FleeToStrangeBehaviourPriority
    /// </summary>
    public unsafe float FleeToStrangeBehaviourPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// FloatProperty: CringeToStrangeBehaviourPriority
    /// </summary>
    public unsafe float CringeToStrangeBehaviourPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// ArrayProperty: SecondaryTargetCoordinatorList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MAEC_VulnerableCondition_Sub_RictusInfected.FTargets> SecondaryTargetCoordinatorList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MAEC_VulnerableCondition_Sub_RictusInfected.FTargets>>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// StructProperty: PrimaryRictusTargetCoordinator
    /// </summary>
    public unsafe ref BmSDK.BmGame.MAEC_VulnerableCondition_Sub_RictusInfected.FTargets PrimaryRictusTargetCoordinator
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.MAEC_VulnerableCondition_Sub_RictusInfected.FTargets>(Ptr + 508);

    /// <summary>
    /// ObjectProperty: InfectedPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI InfectedPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// Struct: FTargets
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FTargets
    {
        /// <summary>
        /// ObjectProperty: TargetCoordinator
        /// </summary>
        public unsafe BmSDK.BmGame.MAEC_VulnerableCondition_Base TargetCoordinator
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MAEC_VulnerableCondition_Base>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: TargetAction
        /// </summary>
        public unsafe BmSDK.BmGame.MAEC_VulnerableCondition_Sub_RictusInfected.MAEC_Actions TargetAction
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MAEC_VulnerableCondition_Sub_RictusInfected.MAEC_Actions>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ObjectProperty: PawnTarget
        /// </summary>
        public unsafe BmSDK.BmGame.RBMPawnAI PawnTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: MAEC_Actions
    /// </summary>
    public enum MAEC_Actions : byte
    {
        NO_ACTION = 0,
        Flee = 1,
        REACT_TO_STRANGE = 2,
        CRINGE = 3,
        MAEC_Actions_MAX = 4,
    }
}
