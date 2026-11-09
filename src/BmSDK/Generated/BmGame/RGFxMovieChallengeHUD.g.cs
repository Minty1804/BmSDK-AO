#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieChallengeHUD<br/>
/// (size = 832)
/// (flags = 22)
/// </summary>
public partial class RGFxMovieChallengeHUD : BmSDK.BmGame.RGFxMovie, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieChallengeHUD", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieChallengeHUD.
    /// </summary>
    public static RGFxMovieChallengeHUD DefaultObject => (RGFxMovieChallengeHUD)StaticClass().DefaultObject;

    internal RGFxMovieChallengeHUD() { }

    /// <summary>
    /// Constructs a new RGFxMovieChallengeHUD
    /// </summary>
    public RGFxMovieChallengeHUD(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieChallengeHUD Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieChallengeHUD(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieChallengeHUD>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieChallengeHUD>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieChallengeHUD>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieChallengeHUD>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieChallengeHUD>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieChallengeHUD>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieChallengeHUD>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieChallengeHUD>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_WidgetUnloaded;
    /// <summary>
    /// Function: WidgetUnloaded
    /// </summary>
    public unsafe override bool WidgetUnloaded(BmSDK.FName WidgetName, BmSDK.FName WidgetPath, BmSDK.GFxUI.GFxObject Widget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WidgetUnloaded, "BmGame.RGFxMovieChallengeHUD.WidgetUnloaded");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetPath, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Widget, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_UpdatePersonalAndFriendsScore;
    /// <summary>
    /// Function: UpdatePersonalAndFriendsScore
    /// </summary>
    public unsafe virtual void UpdatePersonalAndFriendsScore(int Score)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePersonalAndFriendsScore, "BmGame.RGFxMovieChallengeHUD.UpdatePersonalAndFriendsScore");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WidgetInitialized;
    /// <summary>
    /// Function: WidgetInitialized
    /// </summary>
    public unsafe override bool WidgetInitialized(BmSDK.FName WidgetName, BmSDK.FName WidgetPath, BmSDK.GFxUI.GFxObject Widget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WidgetInitialized, "BmGame.RGFxMovieChallengeHUD.WidgetInitialized");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetPath, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Widget, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_SetTrainingGoalsMode;
    /// <summary>
    /// Function: SetTrainingGoalsMode
    /// </summary>
    public unsafe virtual void SetTrainingGoalsMode(int CombatTrainingId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTrainingGoalsMode, "BmGame.RGFxMovieChallengeHUD.SetTrainingGoalsMode");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatTrainingId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetFinalRoundInfo;
    /// <summary>
    /// Function: SetFinalRoundInfo
    /// </summary>
    public unsafe virtual void SetFinalRoundInfo(BmSDK.FString bronzeText, BmSDK.FString silverText, BmSDK.FString goldText)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFinalRoundInfo, "BmGame.RGFxMovieChallengeHUD.SetFinalRoundInfo");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bronzeText, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(silverText, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(goldText, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateMedalStatus;
    /// <summary>
    /// Function: UpdateMedalStatus
    /// </summary>
    public unsafe virtual void UpdateMedalStatus(int medalCount, int medalStatus)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateMedalStatus, "BmGame.RGFxMovieChallengeHUD.UpdateMedalStatus");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(medalCount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(medalStatus, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CompleteRegularRoundGoal;
    /// <summary>
    /// Function: CompleteRegularRoundGoal
    /// </summary>
    public unsafe virtual void CompleteRegularRoundGoal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CompleteRegularRoundGoal, "BmGame.RGFxMovieChallengeHUD.CompleteRegularRoundGoal");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRegularRoundInfo;
    /// <summary>
    /// Function: SetRegularRoundInfo
    /// </summary>
    public unsafe virtual void SetRegularRoundInfo(BmSDK.FString Text)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRegularRoundInfo, "BmGame.RGFxMovieChallengeHUD.SetRegularRoundInfo");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendCombatTraininigGoals;
    /// <summary>
    /// Function: SendCombatTraininigGoals
    /// </summary>
    public unsafe virtual void SendCombatTraininigGoals()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendCombatTraininigGoals, "BmGame.RGFxMovieChallengeHUD.SendCombatTraininigGoals");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateCombatTrainingHUDGoals;
    /// <summary>
    /// Function: UpdateCombatTrainingHUDGoals
    /// </summary>
    public unsafe virtual void UpdateCombatTrainingHUDGoals()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCombatTrainingHUDGoals, "BmGame.RGFxMovieChallengeHUD.UpdateCombatTrainingHUDGoals");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateCombatTrainingPanel;
    /// <summary>
    /// Function: UpdateCombatTrainingPanel
    /// </summary>
    public unsafe virtual void UpdateCombatTrainingPanel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCombatTrainingPanel, "BmGame.RGFxMovieChallengeHUD.UpdateCombatTrainingPanel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RequestCombatTrainingData;
    /// <summary>
    /// Function: RequestCombatTrainingData
    /// </summary>
    public unsafe virtual void RequestCombatTrainingData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestCombatTrainingData, "BmGame.RGFxMovieChallengeHUD.RequestCombatTrainingData");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatTrainingWinDone;
    /// <summary>
    /// Function: CombatTrainingWinDone
    /// </summary>
    public unsafe virtual void CombatTrainingWinDone()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatTrainingWinDone, "BmGame.RGFxMovieChallengeHUD.CombatTrainingWinDone");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowCombatTrainingWon;
    /// <summary>
    /// Function: ShowCombatTrainingWon
    /// </summary>
    public unsafe virtual void ShowCombatTrainingWon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowCombatTrainingWon, "BmGame.RGFxMovieChallengeHUD.ShowCombatTrainingWon");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RequestH2HCombatData;
    /// <summary>
    /// Function: RequestH2HCombatData
    /// </summary>
    public unsafe virtual void RequestH2HCombatData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestH2HCombatData, "BmGame.RGFxMovieChallengeHUD.RequestH2HCombatData");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowH2HCombatComplete;
    /// <summary>
    /// Function: ShowH2HCombatComplete
    /// </summary>
    public unsafe virtual void ShowH2HCombatComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowH2HCombatComplete, "BmGame.RGFxMovieChallengeHUD.ShowH2HCombatComplete");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StatsContinueNoWait;
    /// <summary>
    /// Function: StatsContinueNoWait
    /// </summary>
    public unsafe virtual void StatsContinueNoWait()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StatsContinueNoWait, "BmGame.RGFxMovieChallengeHUD.StatsContinueNoWait");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StatsWaitFurther;
    /// <summary>
    /// Function: StatsWaitFurther
    /// </summary>
    public unsafe virtual void StatsWaitFurther()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StatsWaitFurther, "BmGame.RGFxMovieChallengeHUD.StatsWaitFurther");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Error_StatsTimeOut;
    /// <summary>
    /// Function: Error_StatsTimeOut
    /// </summary>
    public unsafe virtual void Error_StatsTimeOut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Error_StatsTimeOut, "BmGame.RGFxMovieChallengeHUD.Error_StatsTimeOut");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerSave;
    /// <summary>
    /// Function: TriggerSave
    /// </summary>
    public unsafe virtual void TriggerSave(bool bToMemoryOnly)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSave, "BmGame.RGFxMovieChallengeHUD.TriggerSave");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bToMemoryOnly, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsWritingStats;
    /// <summary>
    /// Function: IsWritingStats
    /// </summary>
    public unsafe virtual bool IsWritingStats()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsWritingStats, "BmGame.RGFxMovieChallengeHUD.IsWritingStats");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ChallengeYRetry;
    /// <summary>
    /// Function: ChallengeYRetry
    /// </summary>
    public unsafe virtual void ChallengeYRetry()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChallengeYRetry, "BmGame.RGFxMovieChallengeHUD.ChallengeYRetry");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RequestEnduranceScore;
    /// <summary>
    /// Function: RequestEnduranceScore
    /// </summary>
    public unsafe virtual void RequestEnduranceScore()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestEnduranceScore, "BmGame.RGFxMovieChallengeHUD.RequestEnduranceScore");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnduranceDone;
    /// <summary>
    /// Function: EnduranceDone
    /// </summary>
    public unsafe virtual void EnduranceDone()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnduranceDone, "BmGame.RGFxMovieChallengeHUD.EnduranceDone");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnduranceDoneCallback;
    /// <summary>
    /// Function: EnduranceDoneCallback
    /// </summary>
    public unsafe virtual void EnduranceDoneCallback()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnduranceDoneCallback, "BmGame.RGFxMovieChallengeHUD.EnduranceDoneCallback");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowEnduranceComplete;
    /// <summary>
    /// Function: ShowEnduranceComplete
    /// </summary>
    public unsafe virtual void ShowEnduranceComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowEnduranceComplete, "BmGame.RGFxMovieChallengeHUD.ShowEnduranceComplete");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Flash_HandleStatsWrite;
    /// <summary>
    /// Function: Flash_HandleStatsWrite
    /// </summary>
    public unsafe virtual void Flash_HandleStatsWrite()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Flash_HandleStatsWrite, "BmGame.RGFxMovieChallengeHUD.Flash_HandleStatsWrite");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StoreCampaignProgress;
    /// <summary>
    /// Function: StoreCampaignProgress
    /// </summary>
    public unsafe virtual void StoreCampaignProgress()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StoreCampaignProgress, "BmGame.RGFxMovieChallengeHUD.StoreCampaignProgress");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PredatorGoalsClosed;
    /// <summary>
    /// Function: PredatorGoalsClosed
    /// </summary>
    public unsafe virtual void PredatorGoalsClosed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PredatorGoalsClosed, "BmGame.RGFxMovieChallengeHUD.PredatorGoalsClosed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClosePredatorChallenge;
    /// <summary>
    /// Function: ClosePredatorChallenge
    /// </summary>
    public unsafe virtual void ClosePredatorChallenge(bool bAltF4)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClosePredatorChallenge, "BmGame.RGFxMovieChallengeHUD.ClosePredatorChallenge");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAltF4, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PredatorWinDone;
    /// <summary>
    /// Function: PredatorWinDone
    /// </summary>
    public unsafe virtual void PredatorWinDone()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PredatorWinDone, "BmGame.RGFxMovieChallengeHUD.PredatorWinDone");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PredatorWinDoneCallback;
    /// <summary>
    /// Function: PredatorWinDoneCallback
    /// </summary>
    public unsafe virtual void PredatorWinDoneCallback()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PredatorWinDoneCallback, "BmGame.RGFxMovieChallengeHUD.PredatorWinDoneCallback");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RequestPredatorData;
    /// <summary>
    /// Function: RequestPredatorData
    /// </summary>
    public unsafe virtual void RequestPredatorData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestPredatorData, "BmGame.RGFxMovieChallengeHUD.RequestPredatorData");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowPredatorWon;
    /// <summary>
    /// Function: ShowPredatorWon
    /// </summary>
    public unsafe virtual void ShowPredatorWon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowPredatorWon, "BmGame.RGFxMovieChallengeHUD.ShowPredatorWon");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendPredatorGoals;
    /// <summary>
    /// Function: SendPredatorGoals
    /// </summary>
    public unsafe virtual void SendPredatorGoals(bool bTickOff)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendPredatorGoals, "BmGame.RGFxMovieChallengeHUD.SendPredatorGoals");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTickOff, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdatePredatorHUDGoals;
    /// <summary>
    /// Function: UpdatePredatorHUDGoals
    /// </summary>
    public unsafe virtual void UpdatePredatorHUDGoals()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePredatorHUDGoals, "BmGame.RGFxMovieChallengeHUD.UpdatePredatorHUDGoals");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableClientsideClock;
    /// <summary>
    /// Function: EnableClientsideClock
    /// </summary>
    public unsafe virtual void EnableClientsideClock()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableClientsideClock, "BmGame.RGFxMovieChallengeHUD.EnableClientsideClock");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPredatorTimer;
    /// <summary>
    /// Function: SetPredatorTimer
    /// </summary>
    public unsafe virtual void SetPredatorTimer(float NewValue, bool ShowOnHud = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPredatorTimer, "BmGame.RGFxMovieChallengeHUD.SetPredatorTimer");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewValue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShowOnHud, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AchievedGoal;
    /// <summary>
    /// Function: AchievedGoal
    /// </summary>
    public unsafe virtual bool AchievedGoal(int GoalIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AchievedGoal, "BmGame.RGFxMovieChallengeHUD.AchievedGoal");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GoalIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetGoalGAs;
    /// <summary>
    /// Function: SetGoalGAs
    /// </summary>
    public unsafe virtual void SetGoalGAs(BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge GoalGA1, BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge GoalGA2, BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge GoalGA3)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGoalGAs, "BmGame.RGFxMovieChallengeHUD.SetGoalGAs");
        byte* paramsPtr = stackalloc byte[19];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GoalGA1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GoalGA2, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GoalGA3, paramsPtr + 2);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGoalIDFromGA;
    /// <summary>
    /// Function: GetGoalIDFromGA
    /// </summary>
    public unsafe virtual int GetGoalIDFromGA(BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge GA)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGoalIDFromGA, "BmGame.RGFxMovieChallengeHUD.GetGoalIDFromGA");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GA, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_WaveCompletedDone;
    /// <summary>
    /// Function: WaveCompletedDone
    /// </summary>
    public unsafe virtual void WaveCompletedDone()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WaveCompletedDone, "BmGame.RGFxMovieChallengeHUD.WaveCompletedDone");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WaveCompleteDoneCallback;
    /// <summary>
    /// Function: WaveCompleteDoneCallback
    /// </summary>
    public unsafe virtual void WaveCompleteDoneCallback()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WaveCompleteDoneCallback, "BmGame.RGFxMovieChallengeHUD.WaveCompleteDoneCallback");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RequestWaveData;
    /// <summary>
    /// Function: RequestWaveData
    /// </summary>
    public unsafe virtual void RequestWaveData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestWaveData, "BmGame.RGFxMovieChallengeHUD.RequestWaveData");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendWaveDataP2;
    /// <summary>
    /// Function: SendWaveDataP2
    /// </summary>
    public unsafe virtual void SendWaveDataP2(int WaveNumber, int Score, int Variation, int inVariationBonus, int WaveBonus, int EndlessBonus, int ChallengeBonus, int Medal, int GadgetVariation, int GadgetVariationBonus)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendWaveDataP2, "BmGame.RGFxMovieChallengeHUD.SendWaveDataP2");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WaveNumber, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Variation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inVariationBonus, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WaveBonus, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndlessBonus, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeBonus, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Medal, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetVariation, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetVariationBonus, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendWaveData;
    /// <summary>
    /// Function: SendWaveData
    /// </summary>
    public unsafe virtual void SendWaveData(int WaveNumber, int Score, int Variation, int inVariationBonus, int WaveBonus, int EndlessBonus, int ChallengeBonus, int Medal, int GadgetVariation, int GadgetVariationBonus)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendWaveData, "BmGame.RGFxMovieChallengeHUD.SendWaveData");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WaveNumber, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Variation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inVariationBonus, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WaveBonus, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndlessBonus, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeBonus, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Medal, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetVariation, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetVariationBonus, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetKeyListener;
    /// <summary>
    /// Function: ResetKeyListener
    /// </summary>
    public unsafe virtual void ResetKeyListener()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetKeyListener, "BmGame.RGFxMovieChallengeHUD.ResetKeyListener");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCurrentRoundMedalCount;
    /// <summary>
    /// Function: SetCurrentRoundMedalCount
    /// </summary>
    public unsafe virtual void SetCurrentRoundMedalCount(int num_medals)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentRoundMedalCount, "BmGame.RGFxMovieChallengeHUD.SetCurrentRoundMedalCount");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(num_medals, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BankPlusMedals;
    /// <summary>
    /// Function: BankPlusMedals
    /// </summary>
    public unsafe virtual void BankPlusMedals()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BankPlusMedals, "BmGame.RGFxMovieChallengeHUD.BankPlusMedals");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldWaitForCampaignResults;
    /// <summary>
    /// Function: ShouldWaitForCampaignResults
    /// </summary>
    public unsafe virtual bool ShouldWaitForCampaignResults()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldWaitForCampaignResults, "BmGame.RGFxMovieChallengeHUD.ShouldWaitForCampaignResults");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CallCampaignRestartFunction;
    /// <summary>
    /// Function: CallCampaignRestartFunction
    /// </summary>
    public unsafe virtual void CallCampaignRestartFunction()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CallCampaignRestartFunction, "BmGame.RGFxMovieChallengeHUD.CallCampaignRestartFunction");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopupRequester_Callback;
    /// <summary>
    /// Function: PopupRequester_Callback
    /// </summary>
    public unsafe override void PopupRequester_Callback(BmSDK.BmGame.RGFxMoviePopupRequester ThePopUpMsg, int ButtonId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopupRequester_Callback, "BmGame.RGFxMovieChallengeHUD.PopupRequester_Callback");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThePopUpMsg, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowRestartPopup;
    /// <summary>
    /// Function: ShowRestartPopup
    /// </summary>
    public unsafe virtual void ShowRestartPopup(BmSDK.FString ASCallbackFunction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowRestartPopup, "BmGame.RGFxMovieChallengeHUD.ShowRestartPopup");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ASCallbackFunction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetFreeMedalActive;
    /// <summary>
    /// Function: SetFreeMedalActive
    /// </summary>
    public unsafe virtual void SetFreeMedalActive()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFreeMedalActive, "BmGame.RGFxMovieChallengeHUD.SetFreeMedalActive");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerFinalWavePrompt;
    /// <summary>
    /// Function: TriggerFinalWavePrompt
    /// </summary>
    public unsafe virtual void TriggerFinalWavePrompt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerFinalWavePrompt, "BmGame.RGFxMovieChallengeHUD.TriggerFinalWavePrompt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowWaveCompleteMulti;
    /// <summary>
    /// Function: ShowWaveCompleteMulti
    /// </summary>
    public unsafe virtual void ShowWaveCompleteMulti()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowWaveCompleteMulti, "BmGame.RGFxMovieChallengeHUD.ShowWaveCompleteMulti");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowWaveCompleteMultiTrigger;
    /// <summary>
    /// Function: ShowWaveCompleteMultiTrigger
    /// </summary>
    public unsafe virtual void ShowWaveCompleteMultiTrigger()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowWaveCompleteMultiTrigger, "BmGame.RGFxMovieChallengeHUD.ShowWaveCompleteMultiTrigger");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowWaveComplete;
    /// <summary>
    /// Function: ShowWaveComplete
    /// </summary>
    public unsafe virtual void ShowWaveComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowWaveComplete, "BmGame.RGFxMovieChallengeHUD.ShowWaveComplete");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowWaveCompleteTrigger;
    /// <summary>
    /// Function: ShowWaveCompleteTrigger
    /// </summary>
    public unsafe virtual void ShowWaveCompleteTrigger()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowWaveCompleteTrigger, "BmGame.RGFxMovieChallengeHUD.ShowWaveCompleteTrigger");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideCombatGoals;
    /// <summary>
    /// Function: HideCombatGoals
    /// </summary>
    public unsafe virtual void HideCombatGoals()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideCombatGoals, "BmGame.RGFxMovieChallengeHUD.HideCombatGoals");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCombatGoalsMode;
    /// <summary>
    /// Function: SetCombatGoalsMode
    /// </summary>
    public unsafe virtual void SetCombatGoalsMode(bool is_game)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCombatGoalsMode, "BmGame.RGFxMovieChallengeHUD.SetCombatGoalsMode");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_game, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowPersonalBestPrivate;
    /// <summary>
    /// Function: ShowPersonalBestPrivate
    /// </summary>
    public unsafe virtual void ShowPersonalBestPrivate(bool TypeIsPersonalBest)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowPersonalBestPrivate, "BmGame.RGFxMovieChallengeHUD.ShowPersonalBestPrivate");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TypeIsPersonalBest, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowPersonalBest;
    /// <summary>
    /// Function: ShowPersonalBest
    /// </summary>
    public unsafe virtual void ShowPersonalBest(bool bLeaderboard)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowPersonalBest, "BmGame.RGFxMovieChallengeHUD.ShowPersonalBest");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLeaderboard, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearPrompts;
    /// <summary>
    /// Function: ClearPrompts
    /// </summary>
    public unsafe virtual void ClearPrompts()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPrompts, "BmGame.RGFxMovieChallengeHUD.ClearPrompts");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPrompt;
    /// <summary>
    /// Function: SetPrompt
    /// </summary>
    public unsafe virtual void SetPrompt(int Id, BmSDK.FString Label)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPrompt, "BmGame.RGFxMovieChallengeHUD.SetPrompt");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChallengeRetryUI;
    /// <summary>
    /// Function: ChallengeRetryUI
    /// </summary>
    public unsafe virtual void ChallengeRetryUI()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChallengeRetryUI, "BmGame.RGFxMovieChallengeHUD.ChallengeRetryUI");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowLost;
    /// <summary>
    /// Function: ShowLost
    /// </summary>
    public unsafe virtual void ShowLost()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowLost, "BmGame.RGFxMovieChallengeHUD.ShowLost");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetChallengeStatsColumns;
    /// <summary>
    /// Function: SetChallengeStatsColumns
    /// </summary>
    public unsafe virtual void SetChallengeStatsColumns(BmSDK.FString Title1, BmSDK.FString Title2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetChallengeStatsColumns, "BmGame.RGFxMovieChallengeHUD.SetChallengeStatsColumns");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title2, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendChallengeStat;
    /// <summary>
    /// Function: SendChallengeStat
    /// </summary>
    public unsafe virtual void SendChallengeStat(int player_index, int stat_index, BmSDK.FString stat_name, BmSDK.FString stat_value, int stat_param)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendChallengeStat, "BmGame.RGFxMovieChallengeHUD.SendChallengeStat");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(player_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(stat_index, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(stat_name, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(stat_value, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(stat_param, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNumChallengeStats;
    /// <summary>
    /// Function: SetNumChallengeStats
    /// </summary>
    public unsafe virtual void SetNumChallengeStats(int num_stats)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNumChallengeStats, "BmGame.RGFxMovieChallengeHUD.SetNumChallengeStats");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(num_stats, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetChallengeStatsTypeIsCombat;
    /// <summary>
    /// Function: SetChallengeStatsTypeIsCombat
    /// </summary>
    public unsafe virtual void SetChallengeStatsTypeIsCombat(bool is_combat)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetChallengeStatsTypeIsCombat, "BmGame.RGFxMovieChallengeHUD.SetChallengeStatsTypeIsCombat");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_combat, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RequestChallengeStats;
    /// <summary>
    /// Function: RequestChallengeStats
    /// </summary>
    public unsafe virtual void RequestChallengeStats()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestChallengeStats, "BmGame.RGFxMovieChallengeHUD.RequestChallengeStats");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTimeString;
    /// <summary>
    /// Function: GetTimeString
    /// </summary>
    public unsafe virtual BmSDK.FString GetTimeString(int TimeNumber)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTimeString, "BmGame.RGFxMovieChallengeHUD.GetTimeString");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeNumber, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PublishChallengeStats;
    /// <summary>
    /// Function: PublishChallengeStats
    /// </summary>
    public unsafe virtual void PublishChallengeStats()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PublishChallengeStats, "BmGame.RGFxMovieChallengeHUD.PublishChallengeStats");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowSplitscreenLine;
    /// <summary>
    /// Function: ShowSplitscreenLine
    /// </summary>
    public unsafe virtual void ShowSplitscreenLine(bool bShow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowSplitscreenLine, "BmGame.RGFxMovieChallengeHUD.ShowSplitscreenLine");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IntroDone;
    /// <summary>
    /// Function: IntroDone
    /// </summary>
    public unsafe virtual void IntroDone()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IntroDone, "BmGame.RGFxMovieChallengeHUD.IntroDone");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IntroDoneCallback;
    /// <summary>
    /// Function: IntroDoneCallback
    /// </summary>
    public unsafe virtual void IntroDoneCallback()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IntroDoneCallback, "BmGame.RGFxMovieChallengeHUD.IntroDoneCallback");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetIntroText;
    /// <summary>
    /// Function: SetIntroText
    /// </summary>
    public unsafe virtual void SetIntroText(BmSDK.FString Text)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIntroText, "BmGame.RGFxMovieChallengeHUD.SetIntroText");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowIntro;
    /// <summary>
    /// Function: ShowIntro
    /// </summary>
    public unsafe virtual void ShowIntro()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowIntro, "BmGame.RGFxMovieChallengeHUD.ShowIntro");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndWaveOrWinDisplay;
    /// <summary>
    /// Function: EndWaveOrWinDisplay
    /// </summary>
    public unsafe virtual void EndWaveOrWinDisplay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndWaveOrWinDisplay, "BmGame.RGFxMovieChallengeHUD.EndWaveOrWinDisplay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickPredatorItem;
    /// <summary>
    /// Function: TickPredatorItem
    /// </summary>
    public unsafe virtual void TickPredatorItem(int Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickPredatorItem, "BmGame.RGFxMovieChallengeHUD.TickPredatorItem");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPredatorItem;
    /// <summary>
    /// Function: AddPredatorItem
    /// </summary>
    public unsafe virtual void AddPredatorItem(int Id, BmSDK.FString Description)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPredatorItem, "BmGame.RGFxMovieChallengeHUD.AddPredatorItem");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGadgetsDisabled;
    /// <summary>
    /// Function: SetGadgetsDisabled
    /// </summary>
    public unsafe virtual void SetGadgetsDisabled(bool are_disabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGadgetsDisabled, "BmGame.RGFxMovieChallengeHUD.SetGadgetsDisabled");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(are_disabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowGoals;
    /// <summary>
    /// Function: ShowGoals
    /// </summary>
    public unsafe virtual void ShowGoals(bool bShow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowGoals, "BmGame.RGFxMovieChallengeHUD.ShowGoals");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTime;
    /// <summary>
    /// Function: SetTime
    /// </summary>
    public unsafe virtual void SetTime(float inTimeSecs)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTime, "BmGame.RGFxMovieChallengeHUD.SetTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inTimeSecs, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCombinedCombo;
    /// <summary>
    /// Function: SetCombinedCombo
    /// </summary>
    public unsafe virtual void SetCombinedCombo(int Value, bool bPowerUp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCombinedCombo, "BmGame.RGFxMovieChallengeHUD.SetCombinedCombo");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPowerUp, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCombo;
    /// <summary>
    /// Function: SetCombo
    /// </summary>
    public unsafe virtual void SetCombo(int ColourID, int ComboNumber, int ComboValue, BmSDK.FString movename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCombo, "BmGame.RGFxMovieChallengeHUD.SetCombo");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ColourID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboNumber, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboValue, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(movename, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetScore;
    /// <summary>
    /// Function: SetScore
    /// </summary>
    public unsafe virtual void SetScore(int Score)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetScore, "BmGame.RGFxMovieChallengeHUD.SetScore");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCampaignProgressVisible;
    /// <summary>
    /// Function: SetCampaignProgressVisible
    /// </summary>
    public unsafe virtual void SetCampaignProgressVisible(bool is_visible)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCampaignProgressVisible, "BmGame.RGFxMovieChallengeHUD.SetCampaignProgressVisible");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_visible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCloseHUD;
    /// <summary>
    /// Function: OnCloseHUD
    /// </summary>
    public unsafe virtual void OnCloseHUD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCloseHUD, "BmGame.RGFxMovieChallengeHUD.OnCloseHUD");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseScreen;
    /// <summary>
    /// Function: CloseScreen
    /// </summary>
    public unsafe virtual void CloseScreen()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseScreen, "BmGame.RGFxMovieChallengeHUD.CloseScreen");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Hide;
    /// <summary>
    /// Function: Hide
    /// </summary>
    public unsafe virtual void Hide()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Hide, "BmGame.RGFxMovieChallengeHUD.Hide");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_show;
    /// <summary>
    /// Function: show
    /// </summary>
    public unsafe virtual void show(int Mode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_show, "BmGame.RGFxMovieChallengeHUD.show");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideItem;
    /// <summary>
    /// Function: HideItem
    /// </summary>
    public unsafe virtual void HideItem(BmSDK.FString ItemName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideItem, "BmGame.RGFxMovieChallengeHUD.HideItem");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowItem;
    /// <summary>
    /// Function: ShowItem
    /// </summary>
    public unsafe virtual void ShowItem(BmSDK.FString ItemName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowItem, "BmGame.RGFxMovieChallengeHUD.ShowItem");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KismetControlsInOut;
    /// <summary>
    /// Function: KismetControlsInOut
    /// </summary>
    public unsafe virtual void KismetControlsInOut(bool bTrue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KismetControlsInOut, "BmGame.RGFxMovieChallengeHUD.KismetControlsInOut");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTrue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTickRealTime;
    /// <summary>
    /// Function: SetTickRealTime
    /// </summary>
    public unsafe virtual void SetTickRealTime(bool bRealTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTickRealTime, "BmGame.RGFxMovieChallengeHUD.SetTickRealTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRealTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RGFxMovieChallengeHUD.Init");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceFocus;
    /// <summary>
    /// Function: ForceFocus
    /// </summary>
    public unsafe virtual void ForceFocus(bool GiveFocus)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceFocus, "BmGame.RGFxMovieChallengeHUD.ForceFocus");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GiveFocus, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNumStarsSinglePlayer;
    /// <summary>
    /// Function: SetNumStarsSinglePlayer
    /// </summary>
    public unsafe virtual void SetNumStarsSinglePlayer(int num_stars, bool Snap)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNumStarsSinglePlayer, "BmGame.RGFxMovieChallengeHUD.SetNumStarsSinglePlayer");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(num_stars, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Snap, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPlayerControllerTimerVisible;
    /// <summary>
    /// Function: SetPlayerControllerTimerVisible
    /// </summary>
    public unsafe virtual void SetPlayerControllerTimerVisible(bool bVis)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPlayerControllerTimerVisible, "BmGame.RGFxMovieChallengeHUD.SetPlayerControllerTimerVisible");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVis, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideScore;
    /// <summary>
    /// Function: HideScore
    /// </summary>
    public unsafe virtual void HideScore()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideScore, "BmGame.RGFxMovieChallengeHUD.HideScore");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowScore;
    /// <summary>
    /// Function: ShowScore
    /// </summary>
    public unsafe virtual void ShowScore()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowScore, "BmGame.RGFxMovieChallengeHUD.ShowScore");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsFinalWave;
    /// <summary>
    /// Function: IsFinalWave
    /// </summary>
    public unsafe virtual bool IsFinalWave()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFinalWave, "BmGame.RGFxMovieChallengeHUD.IsFinalWave");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetMedalScores;
    /// <summary>
    /// Function: SetMedalScores
    /// </summary>
    public unsafe virtual void SetMedalScores(int NewBronzeScore, int NewSilverScore, int NewGoldScore)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMedalScores, "BmGame.RGFxMovieChallengeHUD.SetMedalScores");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBronzeScore, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSilverScore, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGoldScore, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendMedalScores;
    /// <summary>
    /// Function: SendMedalScores
    /// </summary>
    public unsafe virtual void SendMedalScores(int NewBronzeScore, int NewSilverScore, int NewGoldScore)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendMedalScores, "BmGame.RGFxMovieChallengeHUD.SendMedalScores");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBronzeScore, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSilverScore, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGoldScore, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddWaveInfo;
    /// <summary>
    /// Function: AddWaveInfo
    /// </summary>
    public unsafe virtual void AddWaveInfo(int Player, int WaveScore, int VariationScore, int VariationCount, int GadgetVariationScore, int GadgetVariationCount, int NoHitBonus, int EndlessComboBonus, int NeverHitBonus)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddWaveInfo, "BmGame.RGFxMovieChallengeHUD.AddWaveInfo");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WaveScore, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariationScore, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariationCount, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetVariationScore, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetVariationCount, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NoHitBonus, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndlessComboBonus, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NeverHitBonus, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNumberOfWaves;
    /// <summary>
    /// Function: SetNumberOfWaves
    /// </summary>
    public unsafe virtual void SetNumberOfWaves(int NewNumberOfWaves)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNumberOfWaves, "BmGame.RGFxMovieChallengeHUD.SetNumberOfWaves");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewNumberOfWaves, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSubtitlesSuppressed;
    /// <summary>
    /// Function: SetSubtitlesSuppressed
    /// </summary>
    public unsafe virtual void SetSubtitlesSuppressed(bool Suppress)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSubtitlesSuppressed, "BmGame.RGFxMovieChallengeHUD.SetSubtitlesSuppressed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Suppress, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: ChallengeModeEnum
    /// </summary>
    public enum ChallengeModeEnum : byte
    {
        ChM_Unspecified = 0,
        ChM_Predator = 1,
        ChM_Combat = 2,
        ChM_CombatTraining = 3,
        ChM_PushYourLuckCombat = 4,
        ChM_MAX = 5,
    }

    /// <summary>
    /// IntProperty: NumberOfWaves
    /// </summary>
    public unsafe int NumberOfWaves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// IntProperty: TotalScore
    /// </summary>
    public unsafe int TotalScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// ArrayProperty: LastWaveNumber
    /// </summary>
    public unsafe BmSDK.TArray<int> LastWaveNumber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// ArrayProperty: LastWaveScore
    /// </summary>
    public unsafe BmSDK.TArray<int> LastWaveScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// ArrayProperty: LastVariationCount
    /// </summary>
    public unsafe BmSDK.TArray<int> LastVariationCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// ArrayProperty: LastVariationScore
    /// </summary>
    public unsafe BmSDK.TArray<int> LastVariationScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// ArrayProperty: LastGadgetVariationCount
    /// </summary>
    public unsafe BmSDK.TArray<int> LastGadgetVariationCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// ArrayProperty: LastGadgetVariationScore
    /// </summary>
    public unsafe BmSDK.TArray<int> LastGadgetVariationScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// ArrayProperty: LastWaveBonus
    /// </summary>
    public unsafe BmSDK.TArray<int> LastWaveBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ArrayProperty: LastChallengeBonus
    /// </summary>
    public unsafe BmSDK.TArray<int> LastChallengeBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// ArrayProperty: LastEndlessComboBonus
    /// </summary>
    public unsafe BmSDK.TArray<int> LastEndlessComboBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// IntProperty: LastMedal
    /// </summary>
    public unsafe int LastMedal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// IntProperty: BronzeScore
    /// </summary>
    public unsafe int BronzeScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// IntProperty: SilverScore
    /// </summary>
    public unsafe int SilverScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// IntProperty: GoldScore
    /// </summary>
    public unsafe int GoldScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ArrayProperty: CombatTrainingGoalStatus
    /// </summary>
    public unsafe BmSDK.TArray<int> CombatTrainingGoalStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ArrayProperty: GoalIDs
    /// </summary>
    public unsafe BmSDK.TArray<int> GoalIDs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ArrayProperty: GoalStatus
    /// </summary>
    public unsafe BmSDK.TArray<int> GoalStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// FloatProperty: PredatorTime
    /// </summary>
    public unsafe float PredatorTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// BoolProperty: bNoPause
    /// </summary>
    public unsafe bool bNoPause
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: SubtitlesWereOriginallyOn
    /// </summary>
    public unsafe bool SubtitlesWereOriginallyOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// StrProperty: CampaignRestartFunction
    /// </summary>
    public unsafe BmSDK.FString CampaignRestartFunction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeInfoPanel
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject ChallengeInfoPanel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// ByteProperty: CurrentChallengeMode
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieChallengeHUD.ChallengeModeEnum CurrentChallengeMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieChallengeHUD.ChallengeModeEnum>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// DelegateProperty: __IntroDoneCallback__Delegate
    /// </summary>
    public unsafe System.IntPtr __IntroDoneCallback__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// DelegateProperty: __WaveCompleteDoneCallback__Delegate
    /// </summary>
    public unsafe System.IntPtr __WaveCompleteDoneCallback__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// DelegateProperty: __PredatorWinDoneCallback__Delegate
    /// </summary>
    public unsafe System.IntPtr __PredatorWinDoneCallback__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// DelegateProperty: __EnduranceDoneCallback__Delegate
    /// </summary>
    public unsafe System.IntPtr __EnduranceDoneCallback__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }
}
