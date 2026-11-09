#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RChallengeManager<br/>
/// (size = 356)
/// (flags = 134217878)
/// </summary>
public partial class RChallengeManager : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RChallengeManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RChallengeManager.
    /// </summary>
    public static RChallengeManager DefaultObject => (RChallengeManager)StaticClass().DefaultObject;

    internal RChallengeManager() { }

    /// <summary>
    /// Constructs a new RChallengeManager
    /// </summary>
    public RChallengeManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RChallengeManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RChallengeManager(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RChallengeManager>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RChallengeManager>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RChallengeManager>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RChallengeManager>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RChallengeManager>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RChallengeManager>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RChallengeManager>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RChallengeManager>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_UpdateFriendsBeatenPredator;
    /// <summary>
    /// Function: UpdateFriendsBeatenPredator
    /// </summary>
    public unsafe virtual void UpdateFriendsBeatenPredator(int Score, int Medals)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateFriendsBeatenPredator, "BmGame.RChallengeManager.UpdateFriendsBeatenPredator");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Medals, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessSingleChallengeUnlockCondition;
    /// <summary>
    /// Function: ProcessSingleChallengeUnlockCondition
    /// </summary>
    public unsafe virtual void ProcessSingleChallengeUnlockCondition(BmSDK.BmGame.RGameInfo.FChallengeUnlockCondition cuc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessSingleChallengeUnlockCondition, "BmGame.RChallengeManager.ProcessSingleChallengeUnlockCondition");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(cuc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessChallengeUnlockConditions;
    /// <summary>
    /// Function: ProcessChallengeUnlockConditions
    /// </summary>
    public unsafe virtual void ProcessChallengeUnlockConditions(int activatedChallengeId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessChallengeUnlockConditions, "BmGame.RChallengeManager.ProcessChallengeUnlockConditions");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(activatedChallengeId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetUnlockedChallengeData;
    /// <summary>
    /// Function: GetUnlockedChallengeData
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPersistentOptions.FUnlockedChallengeData GetUnlockedChallengeData(int ChallengeID, int CharacterId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUnlockedChallengeData, "BmGame.RChallengeManager.GetUnlockedChallengeData");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPersistentOptions.FUnlockedChallengeData>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetNextTargetInfo;
    /// <summary>
    /// Function: GetNextTargetInfo
    /// </summary>
    public unsafe virtual bool GetNextTargetInfo(BmSDK.BmGame.RPersistentOptions.FUnlockedChallengeData ucd, out BmSDK.FString FriendName, out int FriendScore, out int FriendMedal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextTargetInfo, "BmGame.RChallengeManager.GetNextTargetInfo");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ucd, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out FriendScore);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendScore, paramsPtr + 36);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out FriendMedal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendMedal, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        FriendName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 24);
        FriendScore = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 36);
        FriendMedal = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 40);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_GetFriendLeaderInfo;
    /// <summary>
    /// Function: GetFriendLeaderInfo
    /// </summary>
    public unsafe virtual bool GetFriendLeaderInfo(BmSDK.BmGame.RPersistentOptions.FUnlockedChallengeData ucd, out BmSDK.FString FriendName, out int FriendScore, out int FriendMedal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFriendLeaderInfo, "BmGame.RChallengeManager.GetFriendLeaderInfo");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ucd, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out FriendScore);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendScore, paramsPtr + 36);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out FriendMedal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendMedal, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        FriendName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 24);
        FriendScore = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 36);
        FriendMedal = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 40);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_GetPredatorScore;
    /// <summary>
    /// Function: GetPredatorScore
    /// </summary>
    public unsafe virtual int GetPredatorScore(int Medals, int Score)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPredatorScore, "BmGame.RChallengeManager.GetPredatorScore");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Medals, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PopulateFriendChallengeInformation;
    /// <summary>
    /// Function: PopulateFriendChallengeInformation
    /// </summary>
    public unsafe virtual void PopulateFriendChallengeInformation(int ChallengeID, BmSDK.TArray<BmSDK.BmGame.RChallengeManager.FFriendChallengeScore> inFriendChallengeInformation, bool isRankedChallenge)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulateFriendChallengeInformation, "BmGame.RChallengeManager.PopulateFriendChallengeInformation");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inFriendChallengeInformation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(isRankedChallenge, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopulateMyBestScoreChallengeInformation;
    /// <summary>
    /// Function: PopulateMyBestScoreChallengeInformation
    /// </summary>
    public unsafe virtual void PopulateMyBestScoreChallengeInformation(int ChallengeID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulateMyBestScoreChallengeInformation, "BmGame.RChallengeManager.PopulateMyBestScoreChallengeInformation");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateFriendToBeat;
    /// <summary>
    /// Function: UpdateFriendToBeat
    /// </summary>
    public unsafe virtual void UpdateFriendToBeat(bool show = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateFriendToBeat, "BmGame.RChallengeManager.UpdateFriendToBeat");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(show, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EraseAllLeaderBoards;
    /// <summary>
    /// Function: EraseAllLeaderBoards
    /// </summary>
    public unsafe virtual void EraseAllLeaderBoards()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EraseAllLeaderBoards, "BmGame.RChallengeManager.EraseAllLeaderBoards");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FetchCombatTrainingGoalInfo;
    /// <summary>
    /// Function: FetchCombatTrainingGoalInfo
    /// </summary>
    public unsafe virtual int FetchCombatTrainingGoalInfo(int ChallengeID, out BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction_CombatTraining> Goals)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FetchCombatTrainingGoalInfo, "BmGame.RChallengeManager.FetchCombatTrainingGoalInfo");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Goals = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction_CombatTraining>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_FetchPredatorGoalInfo;
    /// <summary>
    /// Function: FetchPredatorGoalInfo
    /// </summary>
    public unsafe virtual int FetchPredatorGoalInfo(int ChallengeID, int CharacterId, out BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge> Goals)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FetchPredatorGoalInfo, "BmGame.RChallengeManager.FetchPredatorGoalInfo");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Goals = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_FetchCombatGoalInfo;
    /// <summary>
    /// Function: FetchCombatGoalInfo
    /// </summary>
    public unsafe virtual int FetchCombatGoalInfo(int ChallengeID, int CharacterId, out BmSDK.TArray<int> Goals)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FetchCombatGoalInfo, "BmGame.RChallengeManager.FetchCombatGoalInfo");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Goals = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<int>>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetChallengeLeaderboardId;
    /// <summary>
    /// Function: GetChallengeLeaderboardId
    /// </summary>
    public unsafe virtual int GetChallengeLeaderboardId(int ChallengeID, int CharacterId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChallengeLeaderboardId, "BmGame.RChallengeManager.GetChallengeLeaderboardId");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsTrainingRoundComplete;
    /// <summary>
    /// Function: IsTrainingRoundComplete
    /// </summary>
    public unsafe virtual bool IsTrainingRoundComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTrainingRoundComplete, "BmGame.RChallengeManager.IsTrainingRoundComplete");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DestroyCombatTrainingController;
    /// <summary>
    /// Function: DestroyCombatTrainingController
    /// </summary>
    public unsafe virtual void DestroyCombatTrainingController()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyCombatTrainingController, "BmGame.RChallengeManager.DestroyCombatTrainingController");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitCombatTrainingController;
    /// <summary>
    /// Function: InitCombatTrainingController
    /// </summary>
    public unsafe virtual void InitCombatTrainingController(BmSDK.BmGame.MCombatTrainingChallengeSettings CTSettings)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitCombatTrainingController, "BmGame.RChallengeManager.InitCombatTrainingController");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CTSettings, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyTrainingManager;
    /// <summary>
    /// Function: DestroyTrainingManager
    /// </summary>
    public unsafe virtual void DestroyTrainingManager()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyTrainingManager, "BmGame.RChallengeManager.DestroyTrainingManager");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateTrainingManager;
    /// <summary>
    /// Function: CreateTrainingManager
    /// </summary>
    public unsafe virtual void CreateTrainingManager()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateTrainingManager, "BmGame.RChallengeManager.CreateTrainingManager");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCurrentInfo;
    /// <summary>
    /// Function: GetCurrentInfo
    /// </summary>
    public unsafe virtual void GetCurrentInfo(out BmSDK.BmGame.RGameInfo.EPlayableCharacters outCharacter, out int outChallengeID, out byte bOutPredator)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentInfo, "BmGame.RChallengeManager.GetCurrentInfo");
        byte* paramsPtr = stackalloc byte[25];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out outCharacter);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(outCharacter, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out outChallengeID);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(outChallengeID, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bOutPredator);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOutPredator, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outCharacter = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.EPlayableCharacters>(paramsPtr + 0);
        outChallengeID = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        bOutPredator = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_ToTimeString;
    /// <summary>
    /// Function: ToTimeString
    /// </summary>
    public unsafe virtual BmSDK.FString ToTimeString(int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToTimeString, "BmGame.RChallengeManager.ToTimeString");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PlayableCharactersNameToEnum;
    /// <summary>
    /// Function: PlayableCharactersNameToEnum
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.EPlayableCharacters PlayableCharactersNameToEnum(BmSDK.FString CharName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayableCharactersNameToEnum, "BmGame.RChallengeManager.PlayableCharactersNameToEnum");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.EPlayableCharacters>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetCharacter;
    /// <summary>
    /// Function: GetCharacter
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.EPlayableCharacters GetCharacter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCharacter, "BmGame.RChallengeManager.GetCharacter");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.EPlayableCharacters>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetCharacter;
    /// <summary>
    /// Function: SetCharacter
    /// </summary>
    public unsafe virtual void SetCharacter(BmSDK.FString CharacterName, BmSDK.FString FullCharacterName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCharacter, "BmGame.RChallengeManager.SetCharacter");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FullCharacterName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Dump;
    /// <summary>
    /// Function: Dump
    /// </summary>
    public unsafe virtual void Dump()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Dump, "BmGame.RChallengeManager.Dump");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGoalTitles;
    /// <summary>
    /// Function: GetGoalTitles
    /// </summary>
    public unsafe virtual void GetGoalTitles(int Round, out BmSDK.TArray<BmSDK.FString> GoalTitles)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGoalTitles, "BmGame.RChallengeManager.GetGoalTitles");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Round, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        GoalTitles = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_DecrementRetries;
    /// <summary>
    /// Function: DecrementRetries
    /// </summary>
    public unsafe virtual void DecrementRetries()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DecrementRetries, "BmGame.RChallengeManager.DecrementRetries");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRetriesLeft;
    /// <summary>
    /// Function: GetRetriesLeft
    /// </summary>
    public unsafe virtual int GetRetriesLeft()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRetriesLeft, "BmGame.RChallengeManager.GetRetriesLeft");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCurrentURL;
    /// <summary>
    /// Function: GetCurrentURL
    /// </summary>
    public unsafe virtual BmSDK.FString GetCurrentURL()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentURL, "BmGame.RChallengeManager.GetCurrentURL");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsDLCMap;
    /// <summary>
    /// Function: IsDLCMap
    /// </summary>
    public unsafe virtual bool IsDLCMap()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDLCMap, "BmGame.RChallengeManager.IsDLCMap");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsRanked;
    /// <summary>
    /// Function: IsRanked
    /// </summary>
    public unsafe virtual bool IsRanked()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRanked, "BmGame.RChallengeManager.IsRanked");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsCampaign;
    /// <summary>
    /// Function: IsCampaign
    /// </summary>
    public unsafe virtual bool IsCampaign()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCampaign, "BmGame.RChallengeManager.IsCampaign");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsLastRound;
    /// <summary>
    /// Function: IsLastRound
    /// </summary>
    public unsafe virtual bool IsLastRound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLastRound, "BmGame.RChallengeManager.IsLastRound");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCurrentRound;
    /// <summary>
    /// Function: GetCurrentRound
    /// </summary>
    public unsafe virtual int GetCurrentRound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentRound, "BmGame.RChallengeManager.GetCurrentRound");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetNextRound;
    /// <summary>
    /// Function: SetNextRound
    /// </summary>
    public unsafe virtual void SetNextRound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNextRound, "BmGame.RChallengeManager.SetNextRound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsModifierActive;
    /// <summary>
    /// Function: IsModifierActive
    /// </summary>
    public unsafe virtual bool IsModifierActive(BmSDK.BmGame.RGameInfo.EChallengeModifiers new_modifier)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsModifierActive, "BmGame.RChallengeManager.IsModifierActive");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(new_modifier, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AddModifierForCurrentRound;
    /// <summary>
    /// Function: AddModifierForCurrentRound
    /// </summary>
    public unsafe virtual void AddModifierForCurrentRound(BmSDK.BmGame.RGameInfo.EChallengeModifiers new_modifier)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddModifierForCurrentRound, "BmGame.RChallengeManager.AddModifierForCurrentRound");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(new_modifier, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearCurrentRoundModifiers;
    /// <summary>
    /// Function: ClearCurrentRoundModifiers
    /// </summary>
    public unsafe virtual void ClearCurrentRoundModifiers()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearCurrentRoundModifiers, "BmGame.RChallengeManager.ClearCurrentRoundModifiers");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerUsesARetry;
    /// <summary>
    /// Function: PlayerUsesARetry
    /// </summary>
    public unsafe virtual void PlayerUsesARetry()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerUsesARetry, "BmGame.RChallengeManager.PlayerUsesARetry");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerAcceptsCurrentRoundResults;
    /// <summary>
    /// Function: PlayerAcceptsCurrentRoundResults
    /// </summary>
    public unsafe virtual void PlayerAcceptsCurrentRoundResults()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerAcceptsCurrentRoundResults, "BmGame.RChallengeManager.PlayerAcceptsCurrentRoundResults");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRoundMedalsEarned;
    /// <summary>
    /// Function: SetRoundMedalsEarned
    /// </summary>
    public unsafe virtual void SetRoundMedalsEarned(int Round, byte medals_earned)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRoundMedalsEarned, "BmGame.RChallengeManager.SetRoundMedalsEarned");
        byte* paramsPtr = stackalloc byte[21];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Round, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(medals_earned, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetActiveWave;
    /// <summary>
    /// Function: SetActiveWave
    /// </summary>
    public unsafe virtual void SetActiveWave()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetActiveWave, "BmGame.RChallengeManager.SetActiveWave");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetActiveRound;
    /// <summary>
    /// Function: SetActiveRound
    /// </summary>
    public unsafe virtual void SetActiveRound(int Round)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetActiveRound, "BmGame.RChallengeManager.SetActiveRound");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Round, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPredatorStat;
    /// <summary>
    /// Function: AddPredatorStat
    /// </summary>
    public unsafe virtual void AddPredatorStat(BmSDK.FString event_name, float event_time)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPredatorStat, "BmGame.RChallengeManager.AddPredatorStat");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(event_name, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(event_time, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPredatorMedalActionPred;
    /// <summary>
    /// Function: AddPredatorMedalActionPred
    /// </summary>
    public unsafe virtual void AddPredatorMedalActionPred(BmSDK.BmGame.RPlayerController RPC, BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge Action)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPredatorMedalActionPred, "BmGame.RChallengeManager.AddPredatorMedalActionPred");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPredatorActionPred;
    /// <summary>
    /// Function: AddPredatorActionPred
    /// </summary>
    public unsafe virtual void AddPredatorActionPred(BmSDK.BmGame.RPlayerController RPC, BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge Action)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPredatorActionPred, "BmGame.RChallengeManager.AddPredatorActionPred");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearPredatorStats;
    /// <summary>
    /// Function: ClearPredatorStats
    /// </summary>
    public unsafe virtual void ClearPredatorStats()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPredatorStats, "BmGame.RChallengeManager.ClearPredatorStats");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BuildChallengeList;
    /// <summary>
    /// Function: BuildChallengeList
    /// </summary>
    public unsafe virtual void BuildChallengeList(int selected, bool bInRanked)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuildChallengeList, "BmGame.RChallengeManager.BuildChallengeList");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(selected, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInRanked, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FilloutChallengeMatch;
    /// <summary>
    /// Function: FilloutChallengeMatch
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RChallengeManager.FChallengeMatch FilloutChallengeMatch(int inID, int CharacterId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FilloutChallengeMatch, "BmGame.RChallengeManager.FilloutChallengeMatch");
        byte* paramsPtr = stackalloc byte[144];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RChallengeManager.FChallengeMatch>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetDefaults;
    /// <summary>
    /// Function: SetDefaults
    /// </summary>
    public unsafe virtual void SetDefaults()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDefaults, "BmGame.RChallengeManager.SetDefaults");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPredatorMap;
    /// <summary>
    /// Function: IsPredatorMap
    /// </summary>
    public unsafe virtual bool IsPredatorMap(int Id, int CharacterId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPredatorMap, "BmGame.RChallengeManager.IsPredatorMap");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetFlagForModifier;
    /// <summary>
    /// Function: GetFlagForModifier
    /// </summary>
    public unsafe virtual BmSDK.FString GetFlagForModifier(int test_mod)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFlagForModifier, "BmGame.RChallengeManager.GetFlagForModifier");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(test_mod, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CheckModifierAvailability;
    /// <summary>
    /// Function: CheckModifierAvailability
    /// </summary>
    public unsafe virtual void CheckModifierAvailability()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckModifierAvailability, "BmGame.RChallengeManager.CheckModifierAvailability");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsModifierAvailableForCustom;
    /// <summary>
    /// Function: IsModifierAvailableForCustom
    /// </summary>
    public unsafe virtual bool IsModifierAvailableForCustom(int test_mod)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsModifierAvailableForCustom, "BmGame.RChallengeManager.IsModifierAvailableForCustom");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(test_mod, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetCampaignIDs;
    /// <summary>
    /// Function: GetCampaignIDs
    /// </summary>
    public unsafe virtual BmSDK.TArray<int> GetCampaignIDs(int Id, int CharacterId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCampaignIDs, "BmGame.RChallengeManager.GetCampaignIDs");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<int>>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetChallengeMapIndex;
    /// <summary>
    /// Function: GetChallengeMapIndex
    /// </summary>
    public unsafe virtual int GetChallengeMapIndex(int Id, int CharacterId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChallengeMapIndex, "BmGame.RChallengeManager.GetChallengeMapIndex");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetGRI;
    /// <summary>
    /// Function: GetGRI
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameRI GetGRI()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGRI, "BmGame.RChallengeManager.GetGRI");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameRI>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRGI;
    /// <summary>
    /// Function: GetRGI
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo GetRGI()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRGI, "BmGame.RChallengeManager.GetRGI");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo>(paramsPtr + 0);
    }

    /// <summary>
    /// Struct: FFriendChallengeScore
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FFriendChallengeScore
    {
        /// <summary>
        /// StrProperty: NickName
        /// </summary>
        public unsafe BmSDK.FString NickName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Score
        /// </summary>
        public unsafe int Score
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: Medal
        /// </summary>
        public unsafe int Medal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FChallengeStatText
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FChallengeStatText
    {
        /// <summary>
        /// ByteProperty: GameAction
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge GameAction
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: DBString
        /// </summary>
        public unsafe BmSDK.FString DBString
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FChallengeMatch
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial record struct FChallengeMatch
    {
        /// <summary>
        /// ByteProperty: Id
        /// </summary>
        public unsafe byte Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: PackId
        /// </summary>
        public unsafe byte PackId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1); }; }
        }

        /// <summary>
        /// IntProperty: ImageId
        /// </summary>
        public unsafe int ImageId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: CharacterId
        /// </summary>
        public unsafe int CharacterId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: LeaderboardId
        /// </summary>
        public unsafe int LeaderboardId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bPredator
        /// </summary>
        public unsafe bool bPredator
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }

        /// <summary>
        /// BoolProperty: bCombatTraining
        /// </summary>
        public unsafe bool bCombatTraining
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }

        /// <summary>
        /// ArrayProperty: ChallengeScores
        /// </summary>
        public unsafe BmSDK.TArray<int> ChallengeScores
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ArrayProperty: ChallengeActions
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge> ChallengeActions
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// ArrayProperty: TrainingActions
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction_CombatTraining> TrainingActions
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction_CombatTraining>>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }
    }

    /// <summary>
    /// Enum: MapMaskBits
    /// </summary>
    public enum MapMaskBits : byte
    {
        eMapMaskBit_Head2Head = 0,
        eMapMaskBit_1P_Only = 1,
        eMapMaskBit_2P_Only = 2,
        eMapMaskBit_Hidden_If_Locked = 3,
        eMapMaskBit_MAX = 4,
    }

    /// <summary>
    /// Struct: FCountsByCharacter
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial record struct FCountsByCharacter
    {
        /// <summary>
        /// IntProperty: Ranked
        /// </summary>
        public unsafe int Ranked
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: RankedTotal
        /// </summary>
        public unsafe int RankedTotal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: RankedDLC
        /// </summary>
        public unsafe int RankedDLC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: RankedDLCTotal
        /// </summary>
        public unsafe int RankedDLCTotal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: Custom
        /// </summary>
        public unsafe int Custom
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: CustomTotal
        /// </summary>
        public unsafe int CustomTotal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// IntProperty: CustomDLC
        /// </summary>
        public unsafe int CustomDLC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// IntProperty: CustomDLCTotal
        /// </summary>
        public unsafe int CustomDLCTotal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// IntProperty: Campaign
        /// </summary>
        public unsafe int Campaign
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// IntProperty: CampaignTotal
        /// </summary>
        public unsafe int CampaignTotal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// IntProperty: CampaignDLC
        /// </summary>
        public unsafe int CampaignDLC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// IntProperty: CampaignDLCTotal
        /// </summary>
        public unsafe int CampaignDLCTotal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }
    }

    /// <summary>
    /// Struct: FCombatTrainingGoals
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FCombatTrainingGoals
    {
        /// <summary>
        /// IntProperty: ChallengeID
        /// </summary>
        public unsafe int ChallengeID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: LeaderboardId
        /// </summary>
        public unsafe int LeaderboardId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ByteProperty: trainingActionRound1
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.EGameAction_CombatTraining trainingActionRound1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_CombatTraining>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ByteProperty: trainingActionRound2
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.EGameAction_CombatTraining trainingActionRound2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_CombatTraining>(Ptr + 9); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9); }; }
        }

        /// <summary>
        /// ByteProperty: trainingActionRound3
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.EGameAction_CombatTraining trainingActionRound3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_CombatTraining>(Ptr + 10); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10); }; }
        }

        /// <summary>
        /// ByteProperty: trainingActionRound4
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.EGameAction_CombatTraining trainingActionRound4
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_CombatTraining>(Ptr + 11); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11); }; }
        }
    }

    /// <summary>
    /// Struct: FPredatorChallengeGoals
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FPredatorChallengeGoals
    {
        /// <summary>
        /// IntProperty: ChallengeID
        /// </summary>
        public unsafe int ChallengeID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: CharacterId
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.EPlayableCharacters CharacterId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EPlayableCharacters>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: LeaderboardId
        /// </summary>
        public unsafe int LeaderboardId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ArrayProperty: PredatorChallengeActions
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge> PredatorChallengeActions
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// ArrayProperty: CombatChallengeDefinitions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RChallengeManager.FCombatChallengeGoals> CombatChallengeDefinitions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RChallengeManager.FCombatChallengeGoals>>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// ArrayProperty: PredatorChallengeDefinitions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RChallengeManager.FPredatorChallengeGoals> PredatorChallengeDefinitions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RChallengeManager.FPredatorChallengeGoals>>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// ArrayProperty: CombatTrainingDefinitions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RChallengeManager.FCombatTrainingGoals> CombatTrainingDefinitions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RChallengeManager.FCombatTrainingGoals>>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// ObjectProperty: CombatTrainingController
    /// </summary>
    public unsafe BmSDK.BmGame.MCombatTrainingChallengeController CombatTrainingController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MCombatTrainingChallengeController>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// ObjectProperty: CombatTrainingChallenges
    /// </summary>
    public unsafe BmSDK.BmGame.MCombatTrainingChallengeSettings CombatTrainingChallenges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MCombatTrainingChallengeSettings>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StrProperty: RefByName
    /// </summary>
    public unsafe BmSDK.FString RefByName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// BoolProperty: LoadingStarted
    /// </summary>
    public unsafe bool LoadingStarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: LoadingDone
    /// </summary>
    public unsafe bool LoadingDone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: FreeMedalIsActive
    /// </summary>
    public unsafe bool FreeMedalIsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bRanked
    /// </summary>
    public unsafe bool bRanked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bCurrentMapIsDLC
    /// </summary>
    public unsafe bool bCurrentMapIsDLC
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: hasBeatOwnBestScore
    /// </summary>
    public unsafe bool hasBeatOwnBestScore
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: CharScreenPkgRefs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> CharScreenPkgRefs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ArrayProperty: MapScreenBasePkgRefs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> MapScreenBasePkgRefs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ArrayProperty: MapScreenPkgRefs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> MapScreenPkgRefs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// ArrayProperty: ModifiersUnlockedForCustom
    /// </summary>
    public unsafe BmSDK.TArray<bool> ModifiersUnlockedForCustom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<bool>>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ArrayProperty: MasterModifierList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EChallengeModifiers> MasterModifierList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EChallengeModifiers>>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// ArrayProperty: CampaignModifiersUsed
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EChallengeModifiers> CampaignModifiersUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EChallengeModifiers>>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ArrayProperty: ModifiersCurrentlyActive
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EChallengeModifiers> ModifiersCurrentlyActive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EChallengeModifiers>>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// ArrayProperty: CampaignMedalsEarned
    /// </summary>
    public unsafe BmSDK.TArray<byte> CampaignMedalsEarned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ArrayProperty: Rounds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RChallengeManager.FChallengeMatch> Rounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RChallengeManager.FChallengeMatch>>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// StrProperty: CurrentFullCharacterName
    /// </summary>
    public unsafe BmSDK.FString CurrentFullCharacterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// StrProperty: CurrentCharacterName
    /// </summary>
    public unsafe BmSDK.FString CurrentCharacterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// ByteProperty: CurrentCharacter
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EPlayableCharacters CurrentCharacter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EPlayableCharacters>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// ByteProperty: CurrentChallengeMode
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.ChallengeMode CurrentChallengeMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.ChallengeMode>(Ptr + 237); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 237); }
    }

    /// <summary>
    /// ByteProperty: CampaignPackId
    /// </summary>
    public unsafe byte CampaignPackId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 238); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 238); }
    }

    /// <summary>
    /// IntProperty: CampaignId
    /// </summary>
    public unsafe int CampaignId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// IntProperty: CurrentChallengeId
    /// </summary>
    public unsafe int CurrentChallengeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// IntProperty: CurrentLeaderboardId
    /// </summary>
    public unsafe int CurrentLeaderboardId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// StrProperty: SelectedMapURL
    /// </summary>
    public unsafe BmSDK.FString SelectedMapURL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// IntProperty: CurrentRound
    /// </summary>
    public unsafe int CurrentRound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// IntProperty: CurrentRetrysLeft
    /// </summary>
    public unsafe int CurrentRetrysLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// IntProperty: CombatRound
    /// </summary>
    public unsafe int CombatRound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// IntProperty: DumpCount
    /// </summary>
    public unsafe int DumpCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// ArrayProperty: PredatorStatsEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PredatorStatsEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// ArrayProperty: PredatorStatsTimes
    /// </summary>
    public unsafe BmSDK.TArray<float> PredatorStatsTimes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// ArrayProperty: ChallengeStatActions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RChallengeManager.FChallengeStatText> ChallengeStatActions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RChallengeManager.FChallengeStatText>>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// ArrayProperty: FriendChallengeInformation
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RChallengeManager.FFriendChallengeScore> FriendChallengeInformation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RChallengeManager.FFriendChallengeScore>>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// IntProperty: friendIndexToCheck
    /// </summary>
    public unsafe int friendIndexToCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// IntProperty: myBestScore
    /// </summary>
    public unsafe int myBestScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// IntProperty: myBestMedals
    /// </summary>
    public unsafe int myBestMedals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// IntProperty: numFriendsBeat
    /// </summary>
    public unsafe int numFriendsBeat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// IntProperty: BeatOwnScoreBonusXP
    /// </summary>
    public unsafe int BeatOwnScoreBonusXP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }

    /// <summary>
    /// IntProperty: BeatFriendScoreBonusXP
    /// </summary>
    public unsafe int BeatFriendScoreBonusXP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// IntProperty: BestCachedRating
    /// </summary>
    public unsafe int BestCachedRating
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// Struct: FCombatChallengeGoals
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FCombatChallengeGoals
    {
        /// <summary>
        /// IntProperty: ChallengeID
        /// </summary>
        public unsafe int ChallengeID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: CharacterId
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.EPlayableCharacters CharacterId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EPlayableCharacters>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: LeaderboardId
        /// </summary>
        public unsafe int LeaderboardId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ArrayProperty: ChallengeScores
        /// </summary>
        public unsafe BmSDK.TArray<int> ChallengeScores
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }
}
