#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MDarkKnightChallengeController<br/>
/// (size = 76)
/// (flags = 134217874)
/// </summary>
public partial class MDarkKnightChallengeController : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MDarkKnightChallengeController", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MDarkKnightChallengeController.
    /// </summary>
    public static MDarkKnightChallengeController DefaultObject => (MDarkKnightChallengeController)StaticClass().DefaultObject;

    internal MDarkKnightChallengeController() { }

    /// <summary>
    /// Constructs a new MDarkKnightChallengeController
    /// </summary>
    public MDarkKnightChallengeController(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MDarkKnightChallengeController Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MDarkKnightChallengeController(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MDarkKnightChallengeController>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MDarkKnightChallengeController>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MDarkKnightChallengeController>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MDarkKnightChallengeController>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MDarkKnightChallengeController>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MDarkKnightChallengeController>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MDarkKnightChallengeController>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MDarkKnightChallengeController>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_OnLevelChange;
    /// <summary>
    /// Function: OnLevelChange
    /// </summary>
    public unsafe virtual void OnLevelChange(out int refreshCache)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLevelChange, "BmGame.MDarkKnightChallengeController.OnLevelChange");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out refreshCache);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(refreshCache, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        refreshCache = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetCategoryEnum;
    /// <summary>
    /// Function: GetCategoryEnum
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MDarkKnightChallengesSettings.EDarkKnightPath GetCategoryEnum(BmSDK.FName Key)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCategoryEnum, "BmGame.MDarkKnightChallengeController.GetCategoryEnum");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MDarkKnightChallengesSettings.EDarkKnightPath>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ShouldAwardChallengeXPNow;
    /// <summary>
    /// Function: ShouldAwardChallengeXPNow
    /// </summary>
    public unsafe virtual bool ShouldAwardChallengeXPNow()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldAwardChallengeXPNow, "BmGame.MDarkKnightChallengeController.ShouldAwardChallengeXPNow");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RestoreFromSavedGame;
    /// <summary>
    /// Function: RestoreFromSavedGame
    /// </summary>
    public unsafe void RestoreFromSavedGame(BmSDK.BmGame.RPersistentShared pShared)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestoreFromSavedGame, "BmGame.MDarkKnightChallengeController.RestoreFromSavedGame");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pShared, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Load;
    /// <summary>
    /// Function: Load
    /// </summary>
    public unsafe virtual void Load(BmSDK.BmGame.RPersistentShared pShared)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Load, "BmGame.MDarkKnightChallengeController.Load");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pShared, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryToResendARTrainingAquiredConsoleEvents;
    /// <summary>
    /// Function: TryToResendARTrainingAquiredConsoleEvents
    /// </summary>
    public unsafe virtual void TryToResendARTrainingAquiredConsoleEvents()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToResendARTrainingAquiredConsoleEvents, "BmGame.MDarkKnightChallengeController.TryToResendARTrainingAquiredConsoleEvents");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryToResendARTrainingEvents;
    /// <summary>
    /// Function: TryToResendARTrainingEvents
    /// </summary>
    public unsafe virtual void TryToResendARTrainingEvents(BmSDK.FString Key)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToResendARTrainingEvents, "BmGame.MDarkKnightChallengeController.TryToResendARTrainingEvents");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostSave;
    /// <summary>
    /// Function: PostSave
    /// </summary>
    public unsafe virtual void PostSave(BmSDK.BmGame.RPersistentShared pShared)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostSave, "BmGame.MDarkKnightChallengeController.PostSave");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pShared, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Save;
    /// <summary>
    /// Function: Save
    /// </summary>
    public unsafe virtual void Save(BmSDK.BmGame.RPersistentShared pShared)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Save, "BmGame.MDarkKnightChallengeController.Save");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pShared, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetChallengeByKey;
    /// <summary>
    /// Function: GetChallengeByKey
    /// </summary>
    public unsafe virtual bool GetChallengeByKey(BmSDK.FString Key, out BmSDK.BmGame.MBatmanChallenge Challenge)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChallengeByKey, "BmGame.MDarkKnightChallengeController.GetChallengeByKey");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Challenge);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Challenge, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Challenge = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MBatmanChallenge>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ChallengeCompleteNotification;
    /// <summary>
    /// Function: ChallengeCompleteNotification
    /// </summary>
    public unsafe virtual void ChallengeCompleteNotification(BmSDK.BmGame.MBatmanChallenge BeatChallenge)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChallengeCompleteNotification, "BmGame.MDarkKnightChallengeController.ChallengeCompleteNotification");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BeatChallenge, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPathMaxLevel;
    /// <summary>
    /// Function: GetPathMaxLevel
    /// </summary>
    public unsafe virtual int GetPathMaxLevel(BmSDK.BmGame.MDarkKnightChallengesSettings.EDarkKnightPath Path)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPathMaxLevel, "BmGame.MDarkKnightChallengeController.GetPathMaxLevel");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Path, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetCurrentPathLevel;
    /// <summary>
    /// Function: GetCurrentPathLevel
    /// </summary>
    public unsafe virtual int GetCurrentPathLevel(BmSDK.BmGame.MDarkKnightChallengesSettings.EDarkKnightPath Path)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentPathLevel, "BmGame.MDarkKnightChallengeController.GetCurrentPathLevel");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Path, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetChallengeProgress;
    /// <summary>
    /// Function: GetChallengeProgress
    /// </summary>
    public unsafe virtual int GetChallengeProgress()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChallengeProgress, "BmGame.MDarkKnightChallengeController.GetChallengeProgress");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetChallengeProgressTotal;
    /// <summary>
    /// Function: GetChallengeProgressTotal
    /// </summary>
    public unsafe virtual int GetChallengeProgressTotal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChallengeProgressTotal, "BmGame.MDarkKnightChallengeController.GetChallengeProgressTotal");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetChallengeProgressByType;
    /// <summary>
    /// Function: GetChallengeProgressByType
    /// </summary>
    public unsafe virtual int GetChallengeProgressByType(BmSDK.BmGame.MDarkKnightChallengesSettings.EDarkKnightPath Path)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChallengeProgressByType, "BmGame.MDarkKnightChallengeController.GetChallengeProgressByType");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Path, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetTotalNumChallenges;
    /// <summary>
    /// Function: GetTotalNumChallenges
    /// </summary>
    public unsafe virtual int GetTotalNumChallenges()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTotalNumChallenges, "BmGame.MDarkKnightChallengeController.GetTotalNumChallenges");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNumChallenges;
    /// <summary>
    /// Function: GetNumChallenges
    /// </summary>
    public unsafe virtual int GetNumChallenges(BmSDK.BmGame.MDarkKnightChallengesSettings.EDarkKnightPath Path)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumChallenges, "BmGame.MDarkKnightChallengeController.GetNumChallenges");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Path, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetChallenge;
    /// <summary>
    /// Function: GetChallenge
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MBatmanChallenge GetChallenge(BmSDK.BmGame.MDarkKnightChallengesSettings.EDarkKnightPath Path, int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChallenge, "BmGame.MDarkKnightChallengeController.GetChallenge");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Path, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MBatmanChallenge>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ResetChallenges;
    /// <summary>
    /// Function: ResetChallenges
    /// </summary>
    public unsafe virtual void ResetChallenges(bool ResetScore)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetChallenges, "BmGame.MDarkKnightChallengeController.ResetChallenges");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResetScore, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DetachReferences;
    /// <summary>
    /// Function: DetachReferences
    /// </summary>
    public unsafe virtual void DetachReferences(bool ResetScore)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetachReferences, "BmGame.MDarkKnightChallengeController.DetachReferences");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResetScore, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CollectObservers, "BmGame.MDarkKnightChallengeController.CollectObservers");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ChallengeObservers = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.MBatmanChallenge.FChallengeObservers>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe virtual void Init(BmSDK.BmGame.MDarkKnightChallengesSettings SettingsResource)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.MDarkKnightChallengeController.Init");
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SettingsResource, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOffChallenges;
    /// <summary>
    /// Function: TurnOffChallenges
    /// </summary>
    public unsafe virtual void TurnOffChallenges()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffChallenges, "BmGame.MDarkKnightChallengeController.TurnOffChallenges");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOnChallenges;
    /// <summary>
    /// Function: TurnOnChallenges
    /// </summary>
    public unsafe virtual void TurnOnChallenges()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOnChallenges, "BmGame.MDarkKnightChallengeController.TurnOnChallenges");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNextReward;
    /// <summary>
    /// Function: GetNextReward
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility GetNextReward(BmSDK.BmGame.MDarkKnightChallengesSettings.EDarkKnightPath Path)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextReward, "BmGame.MDarkKnightChallengeController.GetNextReward");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Path, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility>(paramsPtr + 1);
    }

    private static BmSDK.Function __fn_GetNextChallengeToBeat;
    /// <summary>
    /// Function: GetNextChallengeToBeat
    /// </summary>
    public unsafe virtual bool GetNextChallengeToBeat(BmSDK.BmGame.MDarkKnightChallengesSettings.EDarkKnightPath Path, out BmSDK.BmGame.MBatmanChallenge Challenge)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextChallengeToBeat, "BmGame.MDarkKnightChallengeController.GetNextChallengeToBeat");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Path, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Challenge);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Challenge, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Challenge = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MBatmanChallenge>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetRGI;
    /// <summary>
    /// Function: GetRGI
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo GetRGI()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRGI, "BmGame.MDarkKnightChallengeController.GetRGI");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGRI, "BmGame.MDarkKnightChallengeController.GetGRI");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameRI>(paramsPtr + 0);
    }

    /// <summary>
    /// ObjectProperty: Settings
    /// </summary>
    public unsafe BmSDK.BmGame.MDarkKnightChallengesSettings Settings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MDarkKnightChallengesSettings>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// ArrayProperty: Paths
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MDarkKnightChallengeController.FSPathChallenges> Paths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MDarkKnightChallengeController.FSPathChallenges>>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bInAvoidedLevel
    /// </summary>
    public unsafe bool bInAvoidedLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// DelegateProperty: __ChallengeCompleteNotification__Delegate
    /// </summary>
    public unsafe System.IntPtr __ChallengeCompleteNotification__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// Struct: FSPathChallenges
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FSPathChallenges
    {
        /// <summary>
        /// IntProperty: MaxLevel
        /// </summary>
        public unsafe int MaxLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Level
        /// </summary>
        public unsafe int Level
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ArrayProperty: Challenges
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.MBatmanChallenge> Challenges
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MBatmanChallenge>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }
}
