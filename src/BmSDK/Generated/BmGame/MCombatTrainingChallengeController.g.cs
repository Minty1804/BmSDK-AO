#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MCombatTrainingChallengeController<br/>
/// (size = 56)
/// (flags = 134217874)
/// </summary>
public partial class MCombatTrainingChallengeController : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MCombatTrainingChallengeController", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MCombatTrainingChallengeController.
    /// </summary>
    public static MCombatTrainingChallengeController DefaultObject => (MCombatTrainingChallengeController)StaticClass().DefaultObject;

    internal MCombatTrainingChallengeController() { }

    /// <summary>
    /// Constructs a new MCombatTrainingChallengeController
    /// </summary>
    public MCombatTrainingChallengeController(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MCombatTrainingChallengeController Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MCombatTrainingChallengeController(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MCombatTrainingChallengeController>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatTrainingChallengeController>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MCombatTrainingChallengeController>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatTrainingChallengeController>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatTrainingChallengeController>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatTrainingChallengeController>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MCombatTrainingChallengeController>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatTrainingChallengeController>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_IsChallengeComplete;
    /// <summary>
    /// Function: IsChallengeComplete
    /// </summary>
    public unsafe virtual bool IsChallengeComplete(int challengeIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsChallengeComplete, "BmGame.MCombatTrainingChallengeController.IsChallengeComplete");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(challengeIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetMedalCount;
    /// <summary>
    /// Function: GetMedalCount
    /// </summary>
    public unsafe virtual int GetMedalCount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMedalCount, "BmGame.MCombatTrainingChallengeController.GetMedalCount");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateFinalRoundGoals;
    /// <summary>
    /// Function: UpdateFinalRoundGoals
    /// </summary>
    public unsafe virtual void UpdateFinalRoundGoals()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateFinalRoundGoals, "BmGame.MCombatTrainingChallengeController.UpdateFinalRoundGoals");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CollectObservers;
    /// <summary>
    /// Function: CollectObservers
    /// </summary>
    public unsafe virtual void CollectObservers(out BmSDK.TArray<BmSDK.BmGame.MBatmanChallenge.FChallengeObservers> ChallengeObservers)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CollectObservers, "BmGame.MCombatTrainingChallengeController.CollectObservers");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ChallengeObservers = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.MBatmanChallenge.FChallengeObservers>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_CollectChallengeObservers;
    /// <summary>
    /// Function: CollectChallengeObservers
    /// </summary>
    public unsafe virtual void CollectChallengeObservers(out BmSDK.TArray<BmSDK.BmGame.MBatmanChallenge.FChallengeObservers> ChallengeObservers, BmSDK.BmGame.MBatmanChallenge Challenge)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CollectChallengeObservers, "BmGame.MCombatTrainingChallengeController.CollectChallengeObservers");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Challenge, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ChallengeObservers = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.MBatmanChallenge.FChallengeObservers>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_ResetCurrentChallenge;
    /// <summary>
    /// Function: ResetCurrentChallenge
    /// </summary>
    public unsafe virtual void ResetCurrentChallenge()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetCurrentChallenge, "BmGame.MCombatTrainingChallengeController.ResetCurrentChallenge");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartCombatTraining;
    /// <summary>
    /// Function: StartCombatTraining
    /// </summary>
    public unsafe virtual void StartCombatTraining(int ChallengeID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartCombatTraining, "BmGame.MCombatTrainingChallengeController.StartCombatTraining");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroy;
    /// <summary>
    /// Function: Destroy
    /// </summary>
    public unsafe virtual void Destroy()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroy, "BmGame.MCombatTrainingChallengeController.Destroy");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DetachReferences;
    /// <summary>
    /// Function: DetachReferences
    /// </summary>
    public unsafe virtual void DetachReferences()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetachReferences, "BmGame.MCombatTrainingChallengeController.DetachReferences");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe virtual void Init(BmSDK.BmGame.MCombatTrainingChallengeSettings CTSettings)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.MCombatTrainingChallengeController.Init");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CTSettings, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRGI;
    /// <summary>
    /// Function: GetRGI
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo GetRGI()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRGI, "BmGame.MCombatTrainingChallengeController.GetRGI");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGRI;
    /// <summary>
    /// Function: GetGRI
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameRI GetGRI()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGRI, "BmGame.MCombatTrainingChallengeController.GetGRI");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameRI>(paramsPtr + 0);
    }

    /// <summary>
    /// ObjectProperty: Settings
    /// </summary>
    public unsafe BmSDK.BmGame.MCombatTrainingChallengeSettings Settings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MCombatTrainingChallengeSettings>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// IntProperty: ActiveChallengeId
    /// </summary>
    public unsafe int ActiveChallengeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// IntProperty: lastMedalCount
    /// </summary>
    public unsafe int lastMedalCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }
}
