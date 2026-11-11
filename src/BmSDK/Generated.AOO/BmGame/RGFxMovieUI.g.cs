#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieUI<br/>
/// (size = 1708)
/// (flags = 134250642)
/// </summary>
public partial class RGFxMovieUI : BmSDK.BmGame.RGFxMovie, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieUI", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieUI.
    /// </summary>
    public static RGFxMovieUI DefaultObject => (RGFxMovieUI)StaticClass().DefaultObject;

    internal RGFxMovieUI() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI
    /// </summary>
    public RGFxMovieUI(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_MarkCrateAsPurchased;
    /// <summary>
    /// Function: MarkCrateAsPurchased
    /// </summary>
    public unsafe virtual void MarkCrateAsPurchased(BmSDK.BmGame.RGFxMovieUI.eUIFreeCrateVoucher CrateID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MarkCrateAsPurchased, "BmGame.RGFxMovieUI.MarkCrateAsPurchased");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CrateID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetFreeCrateUUID;
    /// <summary>
    /// Function: GetFreeCrateUUID
    /// </summary>
    public unsafe virtual BmSDK.FString GetFreeCrateUUID()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFreeCrateUUID, "BmGame.RGFxMovieUI.GetFreeCrateUUID");
        byte* paramsPtr = stackalloc byte[29];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFreeCrateVoucherID;
    /// <summary>
    /// Function: GetFreeCrateVoucherID
    /// </summary>
    public unsafe virtual BmSDK.FString GetFreeCrateVoucherID()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFreeCrateVoucherID, "BmGame.RGFxMovieUI.GetFreeCrateVoucherID");
        byte* paramsPtr = stackalloc byte[29];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFreeCrateIconName;
    /// <summary>
    /// Function: GetFreeCrateIconName
    /// </summary>
    public unsafe virtual BmSDK.FString GetFreeCrateIconName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFreeCrateIconName, "BmGame.RGFxMovieUI.GetFreeCrateIconName");
        byte* paramsPtr = stackalloc byte[29];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFreeCrateEnumID;
    /// <summary>
    /// Function: GetFreeCrateEnumID
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGFxMovieUI.eUIFreeCrateVoucher GetFreeCrateEnumID()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFreeCrateEnumID, "BmGame.RGFxMovieUI.GetFreeCrateEnumID");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGFxMovieUI.eUIFreeCrateVoucher>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPlayerHasFreeCrate;
    /// <summary>
    /// Function: GetPlayerHasFreeCrate
    /// </summary>
    public unsafe virtual bool GetPlayerHasFreeCrate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerHasFreeCrate, "BmGame.RGFxMovieUI.GetPlayerHasFreeCrate");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPlayerHasUnlock;
    /// <summary>
    /// Function: GetPlayerHasUnlock
    /// </summary>
    public unsafe virtual bool GetPlayerHasUnlock(BmSDK.BmGame.RGFxMovieUI.eUIFreeCrateVoucher Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerHasUnlock, "BmGame.RGFxMovieUI.GetPlayerHasUnlock");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OnInviteAccepted;
    /// <summary>
    /// Function: OnInviteAccepted
    /// </summary>
    public unsafe virtual void OnInviteAccepted(int ControllerId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnInviteAccepted, "BmGame.RGFxMovieUI.OnInviteAccepted");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSystemInterface;
    /// <summary>
    /// Function: GetSystemInterface
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSystemInterface GetSystemInterface()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSystemInterface, "BmGame.RGFxMovieUI.GetSystemInterface");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSystemInterface>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetUIBackgroundUpdatePath;
    /// <summary>
    /// Function: GetUIBackgroundUpdatePath
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGFxMovieUI.eUIBackgroundUpdatePath GetUIBackgroundUpdatePath()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUIBackgroundUpdatePath, "BmGame.RGFxMovieUI.GetUIBackgroundUpdatePath");
        byte* paramsPtr = stackalloc byte[19];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGFxMovieUI.eUIBackgroundUpdatePath>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PopupRequester_Callback;
    /// <summary>
    /// Function: PopupRequester_Callback
    /// </summary>
    public unsafe override void PopupRequester_Callback(BmSDK.BmGame.RGFxMoviePopupRequester ThePopUpMsg, int ButtonId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopupRequester_Callback, "BmGame.RGFxMovieUI.PopupRequester_Callback");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThePopUpMsg, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SortTeamPRI;
    /// <summary>
    /// Function: SortTeamPRI
    /// </summary>
    public unsafe void SortTeamPRI(out BmSDK.TArray<int> Sorted, int TeamIndex, bool bUseNext)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SortTeamPRI, "BmGame.RGFxMovieUI.SortTeamPRI");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamIndex, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseNext, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Sorted = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<int>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_BestScoreSort;
    /// <summary>
    /// Function: BestScoreSort
    /// </summary>
    public unsafe virtual int BestScoreSort(int A, int B)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BestScoreSort, "BmGame.RGFxMovieUI.BestScoreSort");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetUIIndexForTier;
    /// <summary>
    /// Function: GetUIIndexForTier
    /// </summary>
    public unsafe virtual int GetUIIndexForTier(int PRIIndex, int TeamTier, int TeamIndex, int NextRoundTeam, int NextRoundTeamTier, bool bUseNext)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUIIndexForTier, "BmGame.RGFxMovieUI.GetUIIndexForTier");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PRIIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamTier, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextRoundTeam, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextRoundTeamTier, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseNext, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetPositionWithinTier;
    /// <summary>
    /// Function: GetPositionWithinTier
    /// </summary>
    public unsafe virtual int GetPositionWithinTier(int PRIIndex, int TeamIndex, int TeamTier, int NextRoundTeam, int NextRoundTeamTier, bool bUseNext)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPositionWithinTier, "BmGame.RGFxMovieUI.GetPositionWithinTier");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PRIIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamTier, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextRoundTeam, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextRoundTeamTier, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseNext, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetPRIIndex;
    /// <summary>
    /// Function: GetPRIIndex
    /// </summary>
    public unsafe virtual int GetPRIIndex(BmSDK.BmGame.RPlayerRI _pri)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPRIIndex, "BmGame.RGFxMovieUI.GetPRIIndex");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_pri, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetXPBarScaleForLevel;
    /// <summary>
    /// Function: GetXPBarScaleForLevel
    /// </summary>
    public unsafe virtual float GetXPBarScaleForLevel(int Idx, bool GetAccountXP, float AdditionalXP = default, bool GetCurrentXP = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetXPBarScaleForLevel, "BmGame.RGFxMovieUI.GetXPBarScaleForLevel");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Idx, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GetAccountXP, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AdditionalXP, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GetCurrentXP, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetXPReadableProgress;
    /// <summary>
    /// Function: GetXPReadableProgress
    /// </summary>
    public unsafe virtual BmSDK.FString GetXPReadableProgress(int Idx, bool GetAccountXP, int AdditionalXP = default, bool GetCurrentXP = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetXPReadableProgress, "BmGame.RGFxMovieUI.GetXPReadableProgress");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Idx, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GetAccountXP, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AdditionalXP, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GetCurrentXP, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_MakeLevelIfMissing;
    /// <summary>
    /// Function: MakeLevelIfMissing
    /// </summary>
    public unsafe virtual void MakeLevelIfMissing(BmSDK.FString LevelName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakeLevelIfMissing, "BmGame.RGFxMovieUI.MakeLevelIfMissing");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LevelName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnFadeCompleted_Callback;
    /// <summary>
    /// Function: OnFadeCompleted_Callback
    /// </summary>
    public unsafe override bool OnFadeCompleted_Callback()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFadeCompleted_Callback, "BmGame.RGFxMovieUI.OnFadeCompleted_Callback");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FadeTriggerIntoLobby;
    /// <summary>
    /// Function: FadeTriggerIntoLobby
    /// </summary>
    public unsafe virtual void FadeTriggerIntoLobby()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FadeTriggerIntoLobby, "BmGame.RGFxMovieUI.FadeTriggerIntoLobby");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLobbyJoined;
    /// <summary>
    /// Function: OnLobbyJoined
    /// </summary>
    public unsafe virtual void OnLobbyJoined()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLobbyJoined, "BmGame.RGFxMovieUI.OnLobbyJoined");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateLobby;
    /// <summary>
    /// Function: CreateLobby
    /// </summary>
    public unsafe virtual void CreateLobby(BmSDK.BmGame.RGameInfo.EGameModes GameMode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateLobby, "BmGame.RGFxMovieUI.CreateLobby");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GameMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLobbySearchComplete;
    /// <summary>
    /// Function: OnLobbySearchComplete
    /// </summary>
    public unsafe virtual void OnLobbySearchComplete(int NumResults)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLobbySearchComplete, "BmGame.RGFxMovieUI.OnLobbySearchComplete");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumResults, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanPlayOnline;
    /// <summary>
    /// Function: CanPlayOnline
    /// </summary>
    public unsafe virtual bool CanPlayOnline()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayOnline, "BmGame.RGFxMovieUI.CanPlayOnline");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetLobby;
    /// <summary>
    /// Function: GetLobby
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDLobbySystemSteam GetLobby()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLobby, "BmGame.RGFxMovieUI.GetLobby");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDLobbySystemSteam>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetWeaponIconNameFromEnum;
    /// <summary>
    /// Function: GetWeaponIconNameFromEnum
    /// </summary>
    public unsafe virtual BmSDK.FString GetWeaponIconNameFromEnum(BmSDK.BmGame.RGameInfo.WeaponId Weapon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWeaponIconNameFromEnum, "BmGame.RGFxMovieUI.GetWeaponIconNameFromEnum");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Weapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetAbilityIconNameFromEnum;
    /// <summary>
    /// Function: GetAbilityIconNameFromEnum
    /// </summary>
    public unsafe virtual BmSDK.FString GetAbilityIconNameFromEnum(BmSDK.BmGame.RGameInfo.PlayerGadgetId Ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAbilityIconNameFromEnum, "BmGame.RGFxMovieUI.GetAbilityIconNameFromEnum");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Ability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetWeaponLevel;
    /// <summary>
    /// Function: GetWeaponLevel
    /// </summary>
    public unsafe virtual int GetWeaponLevel(BmSDK.BmGame.RGameInfo.WeaponId ForWeapon = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWeaponLevel, "BmGame.RGFxMovieUI.GetWeaponLevel");
        byte* paramsPtr = stackalloc byte[140];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetWeaponIconName;
    /// <summary>
    /// Function: GetWeaponIconName
    /// </summary>
    public unsafe virtual BmSDK.FString GetWeaponIconName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWeaponIconName, "BmGame.RGFxMovieUI.GetWeaponIconName");
        byte* paramsPtr = stackalloc byte[140];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPlayerLoadout;
    /// <summary>
    /// Function: GetPlayerLoadout
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.FGDPlayerLoadout GetPlayerLoadout()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerLoadout, "BmGame.RGFxMovieUI.GetPlayerLoadout");
        byte* paramsPtr = stackalloc byte[130];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.FGDPlayerLoadout>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetProfileSystem;
    /// <summary>
    /// Function: GetProfileSystem
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDProfileSystem GetProfileSystem()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProfileSystem, "BmGame.RGFxMovieUI.GetProfileSystem");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDProfileSystem>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCustomisationFactionTeamData;
    /// <summary>
    /// Function: GetCustomisationFactionTeamData
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData GetCustomisationFactionTeamData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCustomisationFactionTeamData, "BmGame.RGFxMovieUI.GetCustomisationFactionTeamData");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CreateNewBlankGame;
    /// <summary>
    /// Function: CreateNewBlankGame
    /// </summary>
    public unsafe virtual void CreateNewBlankGame()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateNewBlankGame, "BmGame.RGFxMovieUI.CreateNewBlankGame");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DLC_IsScanActive;
    /// <summary>
    /// Function: DLC_IsScanActive
    /// </summary>
    public unsafe virtual bool DLC_IsScanActive()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DLC_IsScanActive, "BmGame.RGFxMovieUI.DLC_IsScanActive");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DLC_RemoveScanNotifyComplete;
    /// <summary>
    /// Function: DLC_RemoveScanNotifyComplete
    /// </summary>
    public unsafe virtual void DLC_RemoveScanNotifyComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DLC_RemoveScanNotifyComplete, "BmGame.RGFxMovieUI.DLC_RemoveScanNotifyComplete");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DLC_AddScanNotifyComplete;
    /// <summary>
    /// Function: DLC_AddScanNotifyComplete
    /// </summary>
    public unsafe virtual void DLC_AddScanNotifyComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DLC_AddScanNotifyComplete, "BmGame.RGFxMovieUI.DLC_AddScanNotifyComplete");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RefreshDLCEnumComplete;
    /// <summary>
    /// Function: RefreshDLCEnumComplete
    /// </summary>
    public unsafe virtual void RefreshDLCEnumComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RefreshDLCEnumComplete, "BmGame.RGFxMovieUI.RefreshDLCEnumComplete");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPlayerChosenSkinName;
    /// <summary>
    /// Function: SetPlayerChosenSkinName
    /// </summary>
    public unsafe virtual void SetPlayerChosenSkinName(BmSDK.FString ChosenSkinName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPlayerChosenSkinName, "BmGame.RGFxMovieUI.SetPlayerChosenSkinName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChosenSkinName, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SendLeaderBoardToFlash;
    /// <summary>
    /// Function: SendLeaderBoardToFlash
    /// </summary>
    public unsafe virtual void SendLeaderBoardToFlash(int Total, BmSDK.TArray<int> FriendIndex, BmSDK.TArray<int> Ranks, BmSDK.TArray<BmSDK.FString> NickNames, BmSDK.TArray<int> Stars, BmSDK.TArray<float> Scores)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendLeaderBoardToFlash, "BmGame.RGFxMovieUI.SendLeaderBoardToFlash");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Total, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Ranks, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NickNames, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stars, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scores, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDeviceName;
    /// <summary>
    /// Function: SetDeviceName
    /// </summary>
    public unsafe virtual void SetDeviceName(BmSDK.FString DeviceName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDeviceName, "BmGame.RGFxMovieUI.SetDeviceName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetControlType;
    /// <summary>
    /// Function: SetControlType
    /// </summary>
    public unsafe virtual void SetControlType(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetControlType, "BmGame.RGFxMovieUI.SetControlType");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetIntensity3D;
    /// <summary>
    /// Function: SetIntensity3D
    /// </summary>
    public unsafe virtual void SetIntensity3D(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIntensity3D, "BmGame.RGFxMovieUI.SetIntensity3D");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetEyeInversion3D;
    /// <summary>
    /// Function: SetEyeInversion3D
    /// </summary>
    public unsafe virtual void SetEyeInversion3D(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEyeInversion3D, "BmGame.RGFxMovieUI.SetEyeInversion3D");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRender3D;
    /// <summary>
    /// Function: SetRender3D
    /// </summary>
    public unsafe virtual void SetRender3D(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRender3D, "BmGame.RGFxMovieUI.SetRender3D");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPCControlsPage;
    /// <summary>
    /// Function: SetPCControlsPage
    /// </summary>
    public unsafe virtual void SetPCControlsPage(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPCControlsPage, "BmGame.RGFxMovieUI.SetPCControlsPage");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetControlType;
    /// <summary>
    /// Function: GetControlType
    /// </summary>
    public unsafe virtual int GetControlType(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetControlType, "BmGame.RGFxMovieUI.GetControlType");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetIntensity3D;
    /// <summary>
    /// Function: GetIntensity3D
    /// </summary>
    public unsafe virtual int GetIntensity3D(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIntensity3D, "BmGame.RGFxMovieUI.GetIntensity3D");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetEyeInversion3D;
    /// <summary>
    /// Function: GetEyeInversion3D
    /// </summary>
    public unsafe virtual int GetEyeInversion3D(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEyeInversion3D, "BmGame.RGFxMovieUI.GetEyeInversion3D");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetRender3D;
    /// <summary>
    /// Function: GetRender3D
    /// </summary>
    public unsafe virtual int GetRender3D(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRender3D, "BmGame.RGFxMovieUI.GetRender3D");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetPCControlsPage;
    /// <summary>
    /// Function: GetPCControlsPage
    /// </summary>
    public unsafe virtual int GetPCControlsPage(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPCControlsPage, "BmGame.RGFxMovieUI.GetPCControlsPage");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultControlType;
    /// <summary>
    /// Function: GetDefaultControlType
    /// </summary>
    public unsafe virtual int GetDefaultControlType(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultControlType, "BmGame.RGFxMovieUI.GetDefaultControlType");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultIntensity3D;
    /// <summary>
    /// Function: GetDefaultIntensity3D
    /// </summary>
    public unsafe virtual int GetDefaultIntensity3D(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultIntensity3D, "BmGame.RGFxMovieUI.GetDefaultIntensity3D");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultEyeInversion3D;
    /// <summary>
    /// Function: GetDefaultEyeInversion3D
    /// </summary>
    public unsafe virtual int GetDefaultEyeInversion3D(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultEyeInversion3D, "BmGame.RGFxMovieUI.GetDefaultEyeInversion3D");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultRender3D;
    /// <summary>
    /// Function: GetDefaultRender3D
    /// </summary>
    public unsafe virtual int GetDefaultRender3D(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultRender3D, "BmGame.RGFxMovieUI.GetDefaultRender3D");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultPCControlsPage;
    /// <summary>
    /// Function: GetDefaultPCControlsPage
    /// </summary>
    public unsafe virtual int GetDefaultPCControlsPage(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultPCControlsPage, "BmGame.RGFxMovieUI.GetDefaultPCControlsPage");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetSaveGameInfoArray;
    /// <summary>
    /// Function: GetSaveGameInfoArray
    /// </summary>
    public unsafe virtual void GetSaveGameInfoArray(int Id, out BmSDK.TArray<BmSDK.FString> OutSaveInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSaveGameInfoArray, "BmGame.RGFxMovieUI.GetSaveGameInfoArray");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutSaveInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_SetPrompts;
    /// <summary>
    /// Function: SetPrompts
    /// </summary>
    public unsafe virtual void SetPrompts(BmSDK.BmGame.RGFxMovie.UIPromptType PromptType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPrompts, "BmGame.RGFxMovieUI.SetPrompts");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PromptType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetStoreOfferManager;
    /// <summary>
    /// Function: GetStoreOfferManager
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDOfferManager GetStoreOfferManager()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStoreOfferManager, "BmGame.RGFxMovieUI.GetStoreOfferManager");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDOfferManager>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPlatformStr;
    /// <summary>
    /// Function: GetPlatformStr
    /// </summary>
    public unsafe virtual BmSDK.FString GetPlatformStr()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlatformStr, "BmGame.RGFxMovieUI.GetPlatformStr");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetupScreenPrompts;
    /// <summary>
    /// Function: SetupScreenPrompts
    /// </summary>
    public unsafe virtual void SetupScreenPrompts()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupScreenPrompts, "BmGame.RGFxMovieUI.SetupScreenPrompts");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnEvent;
    /// <summary>
    /// Function: OnEvent
    /// </summary>
    public unsafe virtual void OnEvent(BmSDK.BmGame.RGFxMovieUI.UIEVENT_ActionType ActionType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnEvent, "BmGame.RGFxMovieUI.OnEvent");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActionType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLoginLost;
    /// <summary>
    /// Function: OnLoginLost
    /// </summary>
    public unsafe virtual void OnLoginLost()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLoginLost, "BmGame.RGFxMovieUI.OnLoginLost");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnAltF4;
    /// <summary>
    /// Function: OnAltF4
    /// </summary>
    public unsafe virtual void OnAltF4()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAltF4, "BmGame.RGFxMovieUI.OnAltF4");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnBackCustom;
    /// <summary>
    /// Function: OnBackCustom
    /// </summary>
    public unsafe virtual void OnBackCustom()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBackCustom, "BmGame.RGFxMovieUI.OnBackCustom");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMovieName;
    /// <summary>
    /// Function: SetMovieName
    /// </summary>
    public unsafe virtual void SetMovieName(BmSDK.FString NewName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMovieName, "BmGame.RGFxMovieUI.SetMovieName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckResolution;
    /// <summary>
    /// Function: CheckResolution
    /// </summary>
    public unsafe virtual void CheckResolution()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckResolution, "BmGame.RGFxMovieUI.CheckResolution");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoExit;
    /// <summary>
    /// Function: DoExit
    /// </summary>
    public unsafe virtual void DoExit(bool ApplyChanges)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoExit, "BmGame.RGFxMovieUI.DoExit");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ApplyChanges, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnApply;
    /// <summary>
    /// Function: OnApply
    /// </summary>
    public unsafe virtual void OnApply()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnApply, "BmGame.RGFxMovieUI.OnApply");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnBack;
    /// <summary>
    /// Function: OnBack
    /// </summary>
    public unsafe virtual void OnBack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBack, "BmGame.RGFxMovieUI.OnBack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLostFocus;
    /// <summary>
    /// Function: OnLostFocus
    /// </summary>
    public unsafe virtual void OnLostFocus(int Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLostFocus, "BmGame.RGFxMovieUI.OnLostFocus");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnFocus;
    /// <summary>
    /// Function: OnFocus
    /// </summary>
    public unsafe virtual void OnFocus(int Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFocus, "BmGame.RGFxMovieUI.OnFocus");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnButtonFocus;
    /// <summary>
    /// Function: OnButtonFocus
    /// </summary>
    public unsafe virtual void OnButtonFocus(int Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnButtonFocus, "BmGame.RGFxMovieUI.OnButtonFocus");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnClosed;
    /// <summary>
    /// Function: OnClosed
    /// </summary>
    public unsafe virtual void OnClosed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnClosed, "BmGame.RGFxMovieUI.OnClosed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnClicked;
    /// <summary>
    /// Function: OnClicked
    /// </summary>
    public unsafe virtual void OnClicked(int Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnClicked, "BmGame.RGFxMovieUI.OnClicked");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnTick;
    /// <summary>
    /// Function: OnTick
    /// </summary>
    public unsafe virtual void OnTick()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnTick, "BmGame.RGFxMovieUI.OnTick");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLobbyDelegates;
    /// <summary>
    /// Function: ClearLobbyDelegates
    /// </summary>
    public unsafe virtual void ClearLobbyDelegates()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLobbyDelegates, "BmGame.RGFxMovieUI.ClearLobbyDelegates");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddLobbyDelegates;
    /// <summary>
    /// Function: AddLobbyDelegates
    /// </summary>
    public unsafe virtual void AddLobbyDelegates()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLobbyDelegates, "BmGame.RGFxMovieUI.AddLobbyDelegates");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TransitionForwards;
    /// <summary>
    /// Function: TransitionForwards
    /// </summary>
    public unsafe virtual void TransitionForwards(BmSDK.FString EventName, bool bClose)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TransitionForwards, "BmGame.RGFxMovieUI.TransitionForwards");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bClose, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TransitionBack;
    /// <summary>
    /// Function: TransitionBack
    /// </summary>
    public unsafe virtual void TransitionBack(BmSDK.FString EventName, bool bSilent = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TransitionBack, "BmGame.RGFxMovieUI.TransitionBack");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSilent, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTeamFromName;
    /// <summary>
    /// Function: GetTeamFromName
    /// </summary>
    public unsafe virtual int GetTeamFromName(BmSDK.FString _name)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTeamFromName, "BmGame.RGFxMovieUI.GetTeamFromName");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_name, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_asFlushFlashInputMask;
    /// <summary>
    /// Function: asFlushFlashInputMask
    /// </summary>
    public unsafe virtual void asFlushFlashInputMask()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asFlushFlashInputMask, "BmGame.RGFxMovieUI.asFlushFlashInputMask");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseScreenImmediate;
    /// <summary>
    /// Function: CloseScreenImmediate
    /// </summary>
    public unsafe virtual void CloseScreenImmediate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseScreenImmediate, "BmGame.RGFxMovieUI.CloseScreenImmediate");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseScreen, "BmGame.RGFxMovieUI.CloseScreen");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsInputBlocked;
    /// <summary>
    /// Function: IsInputBlocked
    /// </summary>
    public unsafe virtual bool IsInputBlocked()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInputBlocked, "BmGame.RGFxMovieUI.IsInputBlocked");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_BlockInput;
    /// <summary>
    /// Function: BlockInput
    /// </summary>
    public unsafe virtual void BlockInput(bool bBlocked)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlockInput, "BmGame.RGFxMovieUI.BlockInput");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBlocked, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnErrorBox;
    /// <summary>
    /// Function: OnErrorBox
    /// </summary>
    public unsafe virtual void OnErrorBox()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnErrorBox, "BmGame.RGFxMovieUI.OnErrorBox");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnDisconnection;
    /// <summary>
    /// Function: OnDisconnection
    /// </summary>
    public unsafe virtual void OnDisconnection()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDisconnection, "BmGame.RGFxMovieUI.OnDisconnection");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnKicked;
    /// <summary>
    /// Function: OnKicked
    /// </summary>
    public unsafe virtual void OnKicked()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnKicked, "BmGame.RGFxMovieUI.OnKicked");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceClosePopup;
    /// <summary>
    /// Function: ForceClosePopup
    /// </summary>
    public unsafe virtual void ForceClosePopup()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceClosePopup, "BmGame.RGFxMovieUI.ForceClosePopup");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnAcceptInvite;
    /// <summary>
    /// Function: OnAcceptInvite
    /// </summary>
    public unsafe virtual void OnAcceptInvite()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAcceptInvite, "BmGame.RGFxMovieUI.OnAcceptInvite");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateCursorCheck;
    /// <summary>
    /// Function: UpdateCursorCheck
    /// </summary>
    public unsafe virtual void UpdateCursorCheck()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCursorCheck, "BmGame.RGFxMovieUI.UpdateCursorCheck");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopCursorVisPollUpdate;
    /// <summary>
    /// Function: StopCursorVisPollUpdate
    /// </summary>
    public unsafe void StopCursorVisPollUpdate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopCursorVisPollUpdate, "BmGame.RGFxMovieUI.StopCursorVisPollUpdate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartCursorVisPollUpdate;
    /// <summary>
    /// Function: StartCursorVisPollUpdate
    /// </summary>
    public unsafe void StartCursorVisPollUpdate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartCursorVisPollUpdate, "BmGame.RGFxMovieUI.StartCursorVisPollUpdate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RGFxMovieUI.Init");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpecialInit;
    /// <summary>
    /// Function: SpecialInit
    /// </summary>
    public unsafe virtual bool SpecialInit(BmSDK.BmGame.RPlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpecialInit, "BmGame.RGFxMovieUI.SpecialInit");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ResetActiveButtonIDAndOffset;
    /// <summary>
    /// Function: ResetActiveButtonIDAndOffset
    /// </summary>
    public unsafe virtual void ResetActiveButtonIDAndOffset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetActiveButtonIDAndOffset, "BmGame.RGFxMovieUI.ResetActiveButtonIDAndOffset");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SaveCurrentMenu;
    /// <summary>
    /// Function: SaveCurrentMenu
    /// </summary>
    public unsafe virtual void SaveCurrentMenu(BmSDK.FString MenuName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SaveCurrentMenu, "BmGame.RGFxMovieUI.SaveCurrentMenu");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MenuName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StoreListIdxData;
    /// <summary>
    /// Function: StoreListIdxData
    /// </summary>
    public unsafe virtual void StoreListIdxData(int CurrentIdx, int ListOffetIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StoreListIdxData, "BmGame.RGFxMovieUI.StoreListIdxData");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentIdx, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ListOffetIdx, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RequestListOffsetIndexData;
    /// <summary>
    /// Function: RequestListOffsetIndexData
    /// </summary>
    public unsafe virtual int RequestListOffsetIndexData(BmSDK.FString TargetBasePath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestListOffsetIndexData, "BmGame.RGFxMovieUI.RequestListOffsetIndexData");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBasePath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_RequestListIndexData;
    /// <summary>
    /// Function: RequestListIndexData
    /// </summary>
    public unsafe virtual int RequestListIndexData(BmSDK.FString TargetBasePath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestListIndexData, "BmGame.RGFxMovieUI.RequestListIndexData");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBasePath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CountCharacters;
    /// <summary>
    /// Function: CountCharacters
    /// </summary>
    public unsafe virtual int CountCharacters(BmSDK.FString CharacterWanted)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CountCharacters, "BmGame.RGFxMovieUI.CountCharacters");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterWanted, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_StoreButtonId;
    /// <summary>
    /// Function: StoreButtonId
    /// </summary>
    public unsafe virtual void StoreButtonId(int ButtonId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StoreButtonId, "BmGame.RGFxMovieUI.StoreButtonId");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMouseCursorEnabled;
    /// <summary>
    /// Function: SetMouseCursorEnabled
    /// </summary>
    public unsafe virtual void SetMouseCursorEnabled(bool is_enabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMouseCursorEnabled, "BmGame.RGFxMovieUI.SetMouseCursorEnabled");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_enabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RefreshCursorVisibility;
    /// <summary>
    /// Function: RefreshCursorVisibility
    /// </summary>
    public unsafe virtual void RefreshCursorVisibility()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RefreshCursorVisibility, "BmGame.RGFxMovieUI.RefreshCursorVisibility");
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

    private static BmSDK.Function __fn_SetSecondaryKeyBinds;
    /// <summary>
    /// Function: SetSecondaryKeyBinds
    /// </summary>
    public unsafe virtual void SetSecondaryKeyBinds(int AbilityId, int Key)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSecondaryKeyBinds, "BmGame.RGFxMovieUI.SetSecondaryKeyBinds");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AbilityId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SetPrimaryKeyBinds;
    /// <summary>
    /// Function: SetPrimaryKeyBinds
    /// </summary>
    public unsafe virtual void SetPrimaryKeyBinds(int AbilityId, int Key)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPrimaryKeyBinds, "BmGame.RGFxMovieUI.SetPrimaryKeyBinds");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AbilityId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SetCurrentFullscreen;
    /// <summary>
    /// Function: SetCurrentFullscreen
    /// </summary>
    public unsafe virtual void SetCurrentFullscreen(int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentFullscreen, "BmGame.RGFxMovieUI.SetCurrentFullscreen");
        byte* paramsPtr = stackalloc byte[20];
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
        return;
    }

    private static BmSDK.Function __fn_SetCurrentResolutionY;
    /// <summary>
    /// Function: SetCurrentResolutionY
    /// </summary>
    public unsafe virtual void SetCurrentResolutionY(int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentResolutionY, "BmGame.RGFxMovieUI.SetCurrentResolutionY");
        byte* paramsPtr = stackalloc byte[20];
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
        return;
    }

    private static BmSDK.Function __fn_SetCurrentResolutionX;
    /// <summary>
    /// Function: SetCurrentResolutionX
    /// </summary>
    public unsafe virtual void SetCurrentResolutionX(int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentResolutionX, "BmGame.RGFxMovieUI.SetCurrentResolutionX");
        byte* paramsPtr = stackalloc byte[20];
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
        return;
    }

    private static BmSDK.Function __fn_GetCurrentFullscreen;
    /// <summary>
    /// Function: GetCurrentFullscreen
    /// </summary>
    public unsafe virtual int GetCurrentFullscreen()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentFullscreen, "BmGame.RGFxMovieUI.GetCurrentFullscreen");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCurrentResolutionY;
    /// <summary>
    /// Function: GetCurrentResolutionY
    /// </summary>
    public unsafe virtual int GetCurrentResolutionY()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentResolutionY, "BmGame.RGFxMovieUI.GetCurrentResolutionY");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCurrentResolutionX;
    /// <summary>
    /// Function: GetCurrentResolutionX
    /// </summary>
    public unsafe virtual int GetCurrentResolutionX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentResolutionX, "BmGame.RGFxMovieUI.GetCurrentResolutionX");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCurrentResolution;
    /// <summary>
    /// Function: GetCurrentResolution
    /// </summary>
    public unsafe virtual int GetCurrentResolution()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentResolution, "BmGame.RGFxMovieUI.GetCurrentResolution");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClearMenuState;
    /// <summary>
    /// Function: ClearMenuState
    /// </summary>
    public unsafe virtual void ClearMenuState(BmSDK.FString StorageName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearMenuState, "BmGame.RGFxMovieUI.ClearMenuState");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StorageName, paramsPtr + 0);
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

    private static BmSDK.Function __fn_RestoreMenuState;
    /// <summary>
    /// Function: RestoreMenuState
    /// </summary>
    public unsafe virtual void RestoreMenuState(BmSDK.FString StorageName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestoreMenuState, "BmGame.RGFxMovieUI.RestoreMenuState");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StorageName, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SaveMenuState;
    /// <summary>
    /// Function: SaveMenuState
    /// </summary>
    public unsafe virtual void SaveMenuState(BmSDK.FString StorageName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SaveMenuState, "BmGame.RGFxMovieUI.SaveMenuState");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StorageName, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ClearAllMenuStates;
    /// <summary>
    /// Function: ClearAllMenuStates
    /// </summary>
    public unsafe virtual void ClearAllMenuStates()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearAllMenuStates, "BmGame.RGFxMovieUI.ClearAllMenuStates");
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

    private static BmSDK.Function __fn_CancelLoadControllerImagePackageSF;
    /// <summary>
    /// Function: CancelLoadControllerImagePackageSF
    /// </summary>
    public unsafe virtual void CancelLoadControllerImagePackageSF()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelLoadControllerImagePackageSF, "BmGame.RGFxMovieUI.CancelLoadControllerImagePackageSF");
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

    private static BmSDK.Function __fn_LoadControllerImagePackageSF;
    /// <summary>
    /// Function: LoadControllerImagePackageSF
    /// </summary>
    public unsafe virtual void LoadControllerImagePackageSF()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadControllerImagePackageSF, "BmGame.RGFxMovieUI.LoadControllerImagePackageSF");
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

    private static BmSDK.Function __fn_ControllerImageLoaded_CB;
    /// <summary>
    /// Function: ControllerImageLoaded_CB
    /// </summary>
    public unsafe virtual void ControllerImageLoaded_CB()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ControllerImageLoaded_CB, "BmGame.RGFxMovieUI.ControllerImageLoaded_CB");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowWBIDOnMainMenu;
    /// <summary>
    /// Function: ShowWBIDOnMainMenu
    /// </summary>
    public unsafe virtual bool ShowWBIDOnMainMenu()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowWBIDOnMainMenu, "BmGame.RGFxMovieUI.ShowWBIDOnMainMenu");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SimpleLoadPackage;
    /// <summary>
    /// Function: SimpleLoadPackage
    /// </summary>
    public unsafe virtual void SimpleLoadPackage(BmSDK.FString SwfRef)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SimpleLoadPackage, "BmGame.RGFxMovieUI.SimpleLoadPackage");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SwfRef, paramsPtr + 0);
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
    /// Struct: FResolutionOption
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FResolutionOption
    {
        /// <summary>
        /// IntProperty: ResX
        /// </summary>
        public unsafe int ResX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: ResY
        /// </summary>
        public unsafe int ResY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// StructProperty: MenuIndex
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGFxMovieUI.FMenuState MenuIndex
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGFxMovieUI.FMenuState>(Ptr + 496);

    /// <summary>
    /// IntProperty: SavedButtonId
    /// </summary>
    public unsafe int SavedButtonId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// IntProperty: SavedListButtonId
    /// </summary>
    public unsafe int SavedListButtonId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// IntProperty: SavedListButtonOffset
    /// </summary>
    public unsafe int SavedListButtonOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// StrProperty: MovieName
    /// </summary>
    public unsafe BmSDK.FString MovieName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// StrProperty: OnBackCmd
    /// </summary>
    public unsafe BmSDK.FString OnBackCmd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bInputBlocked
    /// </summary>
    public unsafe bool bInputBlocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 556); }
    }

    /// <summary>
    /// BoolProperty: bNoMenuSave
    /// </summary>
    public unsafe bool bNoMenuSave
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 556); }
    }

    /// <summary>
    /// BoolProperty: bInTransition
    /// </summary>
    public unsafe bool bInTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 556); }
    }

    /// <summary>
    /// BoolProperty: bForceHideMouseCursor
    /// </summary>
    public unsafe bool bForceHideMouseCursor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 556); }
    }

    /// <summary>
    /// BoolProperty: bPrevCursorVisState
    /// </summary>
    public unsafe bool bPrevCursorVisState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 556); }
    }

    /// <summary>
    /// BoolProperty: bShouldDoApplyCheck
    /// </summary>
    public unsafe bool bShouldDoApplyCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 556); }
    }

    /// <summary>
    /// BoolProperty: bShouldCancelChanges
    /// </summary>
    public unsafe bool bShouldCancelChanges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 556); }
    }

    /// <summary>
    /// BoolProperty: bDoingApply
    /// </summary>
    public unsafe bool bDoingApply
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 556); }
    }

    /// <summary>
    /// BoolProperty: bScreenHasApplyCheck
    /// </summary>
    public unsafe bool bScreenHasApplyCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 556); }
    }

    /// <summary>
    /// BoolProperty: bAddLobbyDelegates
    /// </summary>
    public unsafe bool bAddLobbyDelegates
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 556); }
    }

    /// <summary>
    /// BoolProperty: bCheckForInviteOnTransition
    /// </summary>
    public unsafe bool bCheckForInviteOnTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 556); }
    }

    /// <summary>
    /// BoolProperty: bLobbyTransition
    /// </summary>
    public unsafe bool bLobbyTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 556); }
    }

    /// <summary>
    /// StrProperty: BackAudioMarkup
    /// </summary>
    public unsafe BmSDK.FString BackAudioMarkup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// ObjectProperty: CursorCheckPollTimer
    /// </summary>
    public unsafe BmSDK.SDEngine.SDTimer CursorCheckPollTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.SDEngine.SDTimer>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// ObjectProperty: ApplyChangesPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ApplyChangesPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// ObjectProperty: ControllerImageRef
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie ControllerImageRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// ArrayProperty: SwfRefs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GFxUI.SwfMovie> SwfRefs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GFxUI.SwfMovie>>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// ByteProperty: CurrentScreenState
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieUI.ScreenState CurrentScreenState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieUI.ScreenState>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// ByteProperty: PopupType
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieUI.MMPopTypes PopupType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieUI.MMPopTypes>(Ptr + 597); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 597); }
    }

    /// <summary>
    /// ByteProperty: DefaultPromptType
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovie.UIPromptType DefaultPromptType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovie.UIPromptType>(Ptr + 598); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 598); }
    }

    /// <summary>
    /// ObjectProperty: ActivePopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ActivePopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// ObjectProperty: InGlobalAudioState
    /// </summary>
    public unsafe BmSDK.Engine.AkStateName InGlobalAudioState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkStateName>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// ObjectProperty: OutGlobalAudioState
    /// </summary>
    public unsafe BmSDK.Engine.AkStateName OutGlobalAudioState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkStateName>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: FreeCrateVoucherData
    /// </summary>
    public InlineArray<BmSDK.BmGame.RGFxMovieUI.FFreeCrateData> FreeCrateVoucherData => new(22, Ptr + 612, 48, this);

    /// <summary>
    /// StructProperty: FreeCrateVoucherData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGFxMovieUI.FFreeCrateData FreeCrateVoucherData_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGFxMovieUI.FFreeCrateData>(Ptr + 612);
    /// <summary>
    /// StructProperty: FreeCrateVoucherData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGFxMovieUI.FFreeCrateData FreeCrateVoucherData_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGFxMovieUI.FFreeCrateData>(Ptr + 660);
    /// <summary>
    /// StructProperty: FreeCrateVoucherData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGFxMovieUI.FFreeCrateData FreeCrateVoucherData_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGFxMovieUI.FFreeCrateData>(Ptr + 708);
    /// <summary>
    /// StructProperty: FreeCrateVoucherData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGFxMovieUI.FFreeCrateData FreeCrateVoucherData_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGFxMovieUI.FFreeCrateData>(Ptr + 756);
    /// <summary>
    /// StructProperty: FreeCrateVoucherData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGFxMovieUI.FFreeCrateData FreeCrateVoucherData_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGFxMovieUI.FFreeCrateData>(Ptr + 804);
    /// <summary>
    /// StructProperty: FreeCrateVoucherData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGFxMovieUI.FFreeCrateData FreeCrateVoucherData_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGFxMovieUI.FFreeCrateData>(Ptr + 852);
    /// <summary>
    /// StructProperty: FreeCrateVoucherData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGFxMovieUI.FFreeCrateData FreeCrateVoucherData_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGFxMovieUI.FFreeCrateData>(Ptr + 900);
    /// <summary>
    /// StructProperty: FreeCrateVoucherData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGFxMovieUI.FFreeCrateData FreeCrateVoucherData_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGFxMovieUI.FFreeCrateData>(Ptr + 948);
    /// <summary>
    /// StructProperty: FreeCrateVoucherData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGFxMovieUI.FFreeCrateData FreeCrateVoucherData_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGFxMovieUI.FFreeCrateData>(Ptr + 996);
    /// <summary>
    /// StructProperty: FreeCrateVoucherData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGFxMovieUI.FFreeCrateData FreeCrateVoucherData_9
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGFxMovieUI.FFreeCrateData>(Ptr + 1044);
    /// <summary>
    /// StructProperty: FreeCrateVoucherData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGFxMovieUI.FFreeCrateData FreeCrateVoucherData_10
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGFxMovieUI.FFreeCrateData>(Ptr + 1092);
    /// <summary>
    /// StructProperty: FreeCrateVoucherData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGFxMovieUI.FFreeCrateData FreeCrateVoucherData_11
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGFxMovieUI.FFreeCrateData>(Ptr + 1140);
    /// <summary>
    /// StructProperty: FreeCrateVoucherData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGFxMovieUI.FFreeCrateData FreeCrateVoucherData_12
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGFxMovieUI.FFreeCrateData>(Ptr + 1188);
    /// <summary>
    /// StructProperty: FreeCrateVoucherData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGFxMovieUI.FFreeCrateData FreeCrateVoucherData_13
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGFxMovieUI.FFreeCrateData>(Ptr + 1236);
    /// <summary>
    /// StructProperty: FreeCrateVoucherData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGFxMovieUI.FFreeCrateData FreeCrateVoucherData_14
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGFxMovieUI.FFreeCrateData>(Ptr + 1284);
    /// <summary>
    /// StructProperty: FreeCrateVoucherData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGFxMovieUI.FFreeCrateData FreeCrateVoucherData_15
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGFxMovieUI.FFreeCrateData>(Ptr + 1332);
    /// <summary>
    /// StructProperty: FreeCrateVoucherData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGFxMovieUI.FFreeCrateData FreeCrateVoucherData_16
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGFxMovieUI.FFreeCrateData>(Ptr + 1380);
    /// <summary>
    /// StructProperty: FreeCrateVoucherData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGFxMovieUI.FFreeCrateData FreeCrateVoucherData_17
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGFxMovieUI.FFreeCrateData>(Ptr + 1428);
    /// <summary>
    /// StructProperty: FreeCrateVoucherData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGFxMovieUI.FFreeCrateData FreeCrateVoucherData_18
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGFxMovieUI.FFreeCrateData>(Ptr + 1476);
    /// <summary>
    /// StructProperty: FreeCrateVoucherData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGFxMovieUI.FFreeCrateData FreeCrateVoucherData_19
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGFxMovieUI.FFreeCrateData>(Ptr + 1524);
    /// <summary>
    /// StructProperty: FreeCrateVoucherData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGFxMovieUI.FFreeCrateData FreeCrateVoucherData_20
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGFxMovieUI.FFreeCrateData>(Ptr + 1572);
    /// <summary>
    /// StructProperty: FreeCrateVoucherData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGFxMovieUI.FFreeCrateData FreeCrateVoucherData_21
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGFxMovieUI.FFreeCrateData>(Ptr + 1620);

    /// <summary>
    /// FloatProperty: ForceCloseJoiningPopupTimer
    /// </summary>
    public unsafe float ForceCloseJoiningPopupTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1668); }
    }

    /// <summary>
    /// StrProperty: FrontendBackground
    /// </summary>
    public unsafe BmSDK.FString FrontendBackground
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1672); }
    }

    /// <summary>
    /// StrProperty: StoreBackground
    /// </summary>
    public unsafe BmSDK.FString StoreBackground
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1684); }
    }

    /// <summary>
    /// StrProperty: LobbyBackground
    /// </summary>
    public unsafe BmSDK.FString LobbyBackground
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1696); }
    }

    /// <summary>
    /// Struct: FMenuState
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FMenuState
    {
        /// <summary>
        /// IntProperty: ActiveColumn
        /// </summary>
        public unsafe int ActiveColumn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: ActiveListID
        /// </summary>
        public unsafe int ActiveListID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: ActiveListOffsetID
        /// </summary>
        public unsafe int ActiveListOffsetID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ArrayProperty: ActiveColumnIndexs
        /// </summary>
        public unsafe BmSDK.TArray<int> ActiveColumnIndexs
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Enum: eUIBackgroundUpdatePath
    /// </summary>
    public enum eUIBackgroundUpdatePath : byte
    {
        eUIBackgroundUpdatePath_Generic = 0,
        eUIBackgroundUpdatePath_Joker = 1,
        eUIBackgroundUpdatePath_Bane = 2,
        eUIBackgroundUpdatePath_MAX = 3,
    }

    /// <summary>
    /// Enum: MMPopTypes
    /// </summary>
    public enum MMPopTypes : byte
    {
        MMPopType_None = 0,
        MMPopType_Exit = 1,
        MMPopType_BackFromMain = 2,
        MMPopType_GoToStore = 3,
        MMPopType_GoOnlineForStore = 4,
        MMPopType_PS3SignIn = 5,
        MMPopType_Restart = 6,
        MMPopType_RtnSinglePlayer = 7,
        MMPopType_FirstBootTutorialAsk = 8,
        MMPopType_FirstBootTutorialSkip = 9,
        MMPopType_NotConnected = 10,
        MMPopType_Quickmatch = 11,
        MMPopType_QuickmatchCancel = 12,
        MMPopType_CreatingLobby = 13,
        MMPopType_JoiningLobby = 14,
        MMPopType_LobbyExit = 15,
        MMPopType_LobbyMigrated = 16,
        MMPopType_FreeSpace = 17,
        MMPopType_Delete = 18,
        MMPopType_Corrupt = 19,
        MMPopType_Corrupt2Pre = 20,
        MMPopType_Corrupt2 = 21,
        MMPopType_NotOwner = 22,
        MMPopupType_NotEnoughMoney = 23,
        MMPopupType_PurchaseConfirm = 24,
        MMPopupType_PS3FirstParty = 25,
        MMPopupType_FirstPartyStore = 26,
        MMPopupType_FirstPartyPurchaseDescription = 27,
        MMPopupType_RedeemFreeCrate = 28,
        MMPopupType_SlotClash = 29,
        MMPopupType_TypeInUse = 30,
        MMPopupType_Prestige = 31,
        MMPopTypes_MAX = 32,
    }

    /// <summary>
    /// Enum: UIEVENT_ActionType
    /// </summary>
    public enum UIEVENT_ActionType : byte
    {
        UIEVENT_AT_Forward = 0,
        UIEVENT_AT_Back = 1,
        UIEVENT_AT_MAX = 2,
    }

    /// <summary>
    /// Enum: CLIMenuItem
    /// </summary>
    public enum CLIMenuItem : byte
    {
        CLIDpadUp = 0,
        CLIDpadDown = 1,
        CLIDpadLeft = 2,
        CLIDpadRight = 3,
        CLIMenuItem_MAX = 4,
    }

    /// <summary>
    /// Struct: FFreeCrateData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial record struct FFreeCrateData
    {
        /// <summary>
        /// StrProperty: FlagName
        /// </summary>
        public unsafe BmSDK.FString FlagName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: IconName
        /// </summary>
        public unsafe BmSDK.FString IconName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StrProperty: VoucherId
        /// </summary>
        public unsafe BmSDK.FString VoucherId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StrProperty: UUID
        /// </summary>
        public unsafe BmSDK.FString UUID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }
    }

    /// <summary>
    /// Enum: eUIFreeCrateVoucher
    /// </summary>
    public enum eUIFreeCrateVoucher : byte
    {
        eUIFreeCrateVoucher_Satchel1 = 0,
        eUIFreeCrateVoucher_Case1 = 1,
        eUIFreeCrateVoucher_Case2 = 2,
        eUIFreeCrateVoucher_Crate1 = 3,
        eUIFreeCrateVoucher_Crate2 = 4,
        eUIFreeCrateVoucher_Container1 = 5,
        eUIFreeCrateVoucher_Tier0n1 = 6,
        eUIFreeCrateVoucher_Tier0n2 = 7,
        eUIFreeCrateVoucher_Tier0n3 = 8,
        eUIFreeCrateVoucher_Tier0n4 = 9,
        eUIFreeCrateVoucher_Tier0n5 = 10,
        eUIFreeCrateVoucher_Tier0n6 = 11,
        eUIFreeCrateVoucher_Tier0n7 = 12,
        eUIFreeCrateVoucher_Tier1n1 = 13,
        eUIFreeCrateVoucher_Tier1n2 = 14,
        eUIFreeCrateVoucher_Tier1n3 = 15,
        eUIFreeCrateVoucher_Tier2n1 = 16,
        eUIFreeCrateVoucher_Tier2n2 = 17,
        eUIFreeCrateVoucher_Tier2n3 = 18,
        eUIFreeCrateVoucher_Tier3n1 = 19,
        eUIFreeCrateVoucher_Tier4n1 = 20,
        eUIFreeCrateVoucher_Invalid = 21,
        eUIFreeCrateVoucher_MAX = 22,
    }

    /// <summary>
    /// Enum: eUICustomisationFaction
    /// </summary>
    public enum eUICustomisationFaction : byte
    {
        eUICustomisationFaction_Bane = 0,
        eUICustomisationFaction_Joker = 1,
        eUICustomisationFaction_MAX = 2,
    }

    /// <summary>
    /// Enum: ScreenState
    /// </summary>
    public enum ScreenState : byte
    {
        RSS_Initial = 0,
        RSS_Updating = 1,
        RSS_Finished = 2,
        RSS_MAX = 3,
    }
}
