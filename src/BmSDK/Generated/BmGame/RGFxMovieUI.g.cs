#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieUI<br/>
/// (size = 816)
/// (flags = 134217878)
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

    private static BmSDK.Function __fn_OnEnumerateMarketplaceOffersComplete;
    /// <summary>
    /// Function: OnEnumerateMarketplaceOffersComplete
    /// </summary>
    public unsafe virtual void OnEnumerateMarketplaceOffersComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnEnumerateMarketplaceOffersComplete, "BmGame.RGFxMovieUI.OnEnumerateMarketplaceOffersComplete");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForNewSeasonPassItems;
    /// <summary>
    /// Function: CheckForNewSeasonPassItems
    /// </summary>
    public unsafe virtual void CheckForNewSeasonPassItems()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForNewSeasonPassItems, "BmGame.RGFxMovieUI.CheckForNewSeasonPassItems");
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

    private static BmSDK.Function __fn_EnumerateMarketplaceOffers;
    /// <summary>
    /// Function: EnumerateMarketplaceOffers
    /// </summary>
    public unsafe virtual bool EnumerateMarketplaceOffers(BmSDK.TArray<byte> FileContents, System.IntPtr callback)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnumerateMarketplaceOffers, "BmGame.RGFxMovieUI.EnumerateMarketplaceOffers");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FileContents, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(callback, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_OnEnumerateMarketplaceOffersCompleteDelegate;
    /// <summary>
    /// Function: OnEnumerateMarketplaceOffersCompleteDelegate
    /// </summary>
    public unsafe virtual void OnEnumerateMarketplaceOffersCompleteDelegate(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnEnumerateMarketplaceOffersCompleteDelegate, "BmGame.RGFxMovieUI.OnEnumerateMarketplaceOffersCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnReadLiveOfferFromStorageComplete;
    /// <summary>
    /// Function: OnReadLiveOfferFromStorageComplete
    /// </summary>
    public unsafe virtual void OnReadLiveOfferFromStorageComplete(bool bWasSuccessful, BmSDK.FString Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadLiveOfferFromStorageComplete, "BmGame.RGFxMovieUI.OnReadLiveOfferFromStorageComplete");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReadLiveOfferFromStorage;
    /// <summary>
    /// Function: ReadLiveOfferFromStorage
    /// </summary>
    public unsafe virtual bool ReadLiveOfferFromStorage(System.IntPtr callback)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadLiveOfferFromStorage, "BmGame.RGFxMovieUI.ReadLiveOfferFromStorage");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(callback, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_OnReadLiveOfferFromStorageCompleteDelegate;
    /// <summary>
    /// Function: OnReadLiveOfferFromStorageCompleteDelegate
    /// </summary>
    public unsafe virtual void OnReadLiveOfferFromStorageCompleteDelegate(bool bWasSuccessful, BmSDK.FString Filename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnReadLiveOfferFromStorageCompleteDelegate, "BmGame.RGFxMovieUI.OnReadLiveOfferFromStorageCompleteDelegate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateSeasonsPass;
    /// <summary>
    /// Function: UpdateSeasonsPass
    /// </summary>
    public unsafe virtual void UpdateSeasonsPass(System.IntPtr callback)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateSeasonsPass, "BmGame.RGFxMovieUI.UpdateSeasonsPass");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(callback, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnUpdateSeasonsPassCompleteDelegate;
    /// <summary>
    /// Function: OnUpdateSeasonsPassCompleteDelegate
    /// </summary>
    public unsafe virtual void OnUpdateSeasonsPassCompleteDelegate(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnUpdateSeasonsPassCompleteDelegate, "BmGame.RGFxMovieUI.OnUpdateSeasonsPassCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UserHasNPAccount;
    /// <summary>
    /// Function: UserHasNPAccount
    /// </summary>
    public unsafe virtual bool UserHasNPAccount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UserHasNPAccount, "BmGame.RGFxMovieUI.UserHasNPAccount");
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

    private static BmSDK.Function __fn_CheckAgeRestriction;
    /// <summary>
    /// Function: CheckAgeRestriction
    /// </summary>
    public unsafe virtual bool CheckAgeRestriction()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckAgeRestriction, "BmGame.RGFxMovieUI.CheckAgeRestriction");
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

    private static BmSDK.Function __fn_IsStoryActive;
    /// <summary>
    /// Function: IsStoryActive
    /// </summary>
    public unsafe virtual bool IsStoryActive()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsStoryActive, "BmGame.RGFxMovieUI.IsStoryActive");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateCharacterViewerDLCState;
    /// <summary>
    /// Function: UpdateCharacterViewerDLCState
    /// </summary>
    public unsafe virtual void UpdateCharacterViewerDLCState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCharacterViewerDLCState, "BmGame.RGFxMovieUI.UpdateCharacterViewerDLCState");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
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

    private static BmSDK.Function __fn_Game_Replay1stCatwoman;
    /// <summary>
    /// Function: Game_Replay1stCatwoman
    /// </summary>
    public unsafe virtual void Game_Replay1stCatwoman(BmSDK.FString CharacterName = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Game_Replay1stCatwoman, "BmGame.RGFxMovieUI.Game_Replay1stCatwoman");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterName, paramsPtr + 0);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_CheckCatwomanOffer;
    /// <summary>
    /// Function: CheckCatwomanOffer
    /// </summary>
    public unsafe virtual bool CheckCatwomanOffer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckCatwomanOffer, "BmGame.RGFxMovieUI.CheckCatwomanOffer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetRetriesLeft;
    /// <summary>
    /// Function: GetRetriesLeft
    /// </summary>
    public unsafe virtual int GetRetriesLeft()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRetriesLeft, "BmGame.RGFxMovieUI.GetRetriesLeft");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsCampaign;
    /// <summary>
    /// Function: IsCampaign
    /// </summary>
    public unsafe virtual bool IsCampaign()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCampaign, "BmGame.RGFxMovieUI.IsCampaign");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SendLeaderBoardToFlash;
    /// <summary>
    /// Function: SendLeaderBoardToFlash
    /// </summary>
    public unsafe virtual void SendLeaderBoardToFlash(int Total, BmSDK.TArray<int> FriendIndex, BmSDK.TArray<int> Ranks, BmSDK.TArray<BmSDK.FString> NickNames, BmSDK.TArray<int> Stars, BmSDK.TArray<float> Scores, bool isPoollingFriendData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendLeaderBoardToFlash, "BmGame.RGFxMovieUI.SendLeaderBoardToFlash");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Total, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Ranks, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NickNames, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stars, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scores, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(isPoollingFriendData, paramsPtr + 64);
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

    private static BmSDK.Function __fn_SetSixAxis;
    /// <summary>
    /// Function: SetSixAxis
    /// </summary>
    public unsafe virtual void SetSixAxis(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSixAxis, "BmGame.RGFxMovieUI.SetSixAxis");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCameraAssist;
    /// <summary>
    /// Function: SetCameraAssist
    /// </summary>
    public unsafe virtual void SetCameraAssist(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCameraAssist, "BmGame.RGFxMovieUI.SetCameraAssist");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetVibration;
    /// <summary>
    /// Function: SetVibration
    /// </summary>
    public unsafe virtual void SetVibration(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVibration, "BmGame.RGFxMovieUI.SetVibration");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInvertBatarang;
    /// <summary>
    /// Function: SetInvertBatarang
    /// </summary>
    public unsafe virtual void SetInvertBatarang(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInvertBatarang, "BmGame.RGFxMovieUI.SetInvertBatarang");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInvertGlide;
    /// <summary>
    /// Function: SetInvertGlide
    /// </summary>
    public unsafe virtual void SetInvertGlide(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInvertGlide, "BmGame.RGFxMovieUI.SetInvertGlide");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInvertRotation;
    /// <summary>
    /// Function: SetInvertRotation
    /// </summary>
    public unsafe virtual void SetInvertRotation(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInvertRotation, "BmGame.RGFxMovieUI.SetInvertRotation");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInvertLook;
    /// <summary>
    /// Function: SetInvertLook
    /// </summary>
    public unsafe virtual void SetInvertLook(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInvertLook, "BmGame.RGFxMovieUI.SetInvertLook");
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

    private static BmSDK.Function __fn_SetVolumeDialogue;
    /// <summary>
    /// Function: SetVolumeDialogue
    /// </summary>
    public unsafe virtual void SetVolumeDialogue(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVolumeDialogue, "BmGame.RGFxMovieUI.SetVolumeDialogue");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetVolumeMusic;
    /// <summary>
    /// Function: SetVolumeMusic
    /// </summary>
    public unsafe virtual void SetVolumeMusic(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVolumeMusic, "BmGame.RGFxMovieUI.SetVolumeMusic");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetVolumeSFX;
    /// <summary>
    /// Function: SetVolumeSFX
    /// </summary>
    public unsafe virtual void SetVolumeSFX(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVolumeSFX, "BmGame.RGFxMovieUI.SetVolumeSFX");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGamma;
    /// <summary>
    /// Function: SetGamma
    /// </summary>
    public unsafe virtual void SetGamma(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGamma, "BmGame.RGFxMovieUI.SetGamma");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDynamicRange;
    /// <summary>
    /// Function: SetDynamicRange
    /// </summary>
    public unsafe virtual void SetDynamicRange(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDynamicRange, "BmGame.RGFxMovieUI.SetDynamicRange");
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

    private static BmSDK.Function __fn_SetHints;
    /// <summary>
    /// Function: SetHints
    /// </summary>
    public unsafe virtual void SetHints(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHints, "BmGame.RGFxMovieUI.SetHints");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTutorial;
    /// <summary>
    /// Function: SetTutorial
    /// </summary>
    public unsafe virtual void SetTutorial(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTutorial, "BmGame.RGFxMovieUI.SetTutorial");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSubtitles;
    /// <summary>
    /// Function: SetSubtitles
    /// </summary>
    public unsafe virtual void SetSubtitles(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSubtitles, "BmGame.RGFxMovieUI.SetSubtitles");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDifficulty;
    /// <summary>
    /// Function: SetDifficulty
    /// </summary>
    public unsafe virtual void SetDifficulty(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDifficulty, "BmGame.RGFxMovieUI.SetDifficulty");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHardwarePhysX;
    /// <summary>
    /// Function: SetHardwarePhysX
    /// </summary>
    public unsafe virtual void SetHardwarePhysX(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHardwarePhysX, "BmGame.RGFxMovieUI.SetHardwarePhysX");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetHardwarePhysX;
    /// <summary>
    /// Function: GetHardwarePhysX
    /// </summary>
    public unsafe virtual int GetHardwarePhysX(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHardwarePhysX, "BmGame.RGFxMovieUI.GetHardwarePhysX");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultHardwarePhysX;
    /// <summary>
    /// Function: GetDefaultHardwarePhysX
    /// </summary>
    public unsafe virtual int GetDefaultHardwarePhysX(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultHardwarePhysX, "BmGame.RGFxMovieUI.GetDefaultHardwarePhysX");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetAmbientOcclusion;
    /// <summary>
    /// Function: SetAmbientOcclusion
    /// </summary>
    public unsafe virtual void SetAmbientOcclusion(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAmbientOcclusion, "BmGame.RGFxMovieUI.SetAmbientOcclusion");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetAmbientOcclusion;
    /// <summary>
    /// Function: GetAmbientOcclusion
    /// </summary>
    public unsafe virtual int GetAmbientOcclusion(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAmbientOcclusion, "BmGame.RGFxMovieUI.GetAmbientOcclusion");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultAmbientOcclusion;
    /// <summary>
    /// Function: GetDefaultAmbientOcclusion
    /// </summary>
    public unsafe virtual int GetDefaultAmbientOcclusion(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultAmbientOcclusion, "BmGame.RGFxMovieUI.GetDefaultAmbientOcclusion");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetReflections;
    /// <summary>
    /// Function: SetReflections
    /// </summary>
    public unsafe virtual void SetReflections(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetReflections, "BmGame.RGFxMovieUI.SetReflections");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetReflections;
    /// <summary>
    /// Function: GetReflections
    /// </summary>
    public unsafe virtual int GetReflections(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetReflections, "BmGame.RGFxMovieUI.GetReflections");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultReflections;
    /// <summary>
    /// Function: GetDefaultReflections
    /// </summary>
    public unsafe virtual int GetDefaultReflections(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultReflections, "BmGame.RGFxMovieUI.GetDefaultReflections");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetLightShafts;
    /// <summary>
    /// Function: SetLightShafts
    /// </summary>
    public unsafe virtual void SetLightShafts(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLightShafts, "BmGame.RGFxMovieUI.SetLightShafts");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetLightShafts;
    /// <summary>
    /// Function: GetLightShafts
    /// </summary>
    public unsafe virtual int GetLightShafts(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLightShafts, "BmGame.RGFxMovieUI.GetLightShafts");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultLightShafts;
    /// <summary>
    /// Function: GetDefaultLightShafts
    /// </summary>
    public unsafe virtual int GetDefaultLightShafts(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultLightShafts, "BmGame.RGFxMovieUI.GetDefaultLightShafts");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetLensFlares;
    /// <summary>
    /// Function: SetLensFlares
    /// </summary>
    public unsafe virtual void SetLensFlares(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLensFlares, "BmGame.RGFxMovieUI.SetLensFlares");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetLensFlares;
    /// <summary>
    /// Function: GetLensFlares
    /// </summary>
    public unsafe virtual int GetLensFlares(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLensFlares, "BmGame.RGFxMovieUI.GetLensFlares");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultLensFlares;
    /// <summary>
    /// Function: GetDefaultLensFlares
    /// </summary>
    public unsafe virtual int GetDefaultLensFlares(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultLensFlares, "BmGame.RGFxMovieUI.GetDefaultLensFlares");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetDistortion;
    /// <summary>
    /// Function: SetDistortion
    /// </summary>
    public unsafe virtual void SetDistortion(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDistortion, "BmGame.RGFxMovieUI.SetDistortion");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetDistortion;
    /// <summary>
    /// Function: GetDistortion
    /// </summary>
    public unsafe virtual int GetDistortion(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDistortion, "BmGame.RGFxMovieUI.GetDistortion");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultDistortion;
    /// <summary>
    /// Function: GetDefaultDistortion
    /// </summary>
    public unsafe virtual int GetDefaultDistortion(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultDistortion, "BmGame.RGFxMovieUI.GetDefaultDistortion");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetDepthOfField;
    /// <summary>
    /// Function: SetDepthOfField
    /// </summary>
    public unsafe virtual void SetDepthOfField(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDepthOfField, "BmGame.RGFxMovieUI.SetDepthOfField");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetDepthOfField;
    /// <summary>
    /// Function: GetDepthOfField
    /// </summary>
    public unsafe virtual int GetDepthOfField(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDepthOfField, "BmGame.RGFxMovieUI.GetDepthOfField");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultDepthOfField;
    /// <summary>
    /// Function: GetDefaultDepthOfField
    /// </summary>
    public unsafe virtual int GetDefaultDepthOfField(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultDepthOfField, "BmGame.RGFxMovieUI.GetDefaultDepthOfField");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetMotionBlur;
    /// <summary>
    /// Function: SetMotionBlur
    /// </summary>
    public unsafe virtual void SetMotionBlur(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMotionBlur, "BmGame.RGFxMovieUI.SetMotionBlur");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetMotionBlur;
    /// <summary>
    /// Function: GetMotionBlur
    /// </summary>
    public unsafe virtual int GetMotionBlur(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMotionBlur, "BmGame.RGFxMovieUI.GetMotionBlur");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultMotionBlur;
    /// <summary>
    /// Function: GetDefaultMotionBlur
    /// </summary>
    public unsafe virtual int GetDefaultMotionBlur(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultMotionBlur, "BmGame.RGFxMovieUI.GetDefaultMotionBlur");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetDynamicShadows;
    /// <summary>
    /// Function: SetDynamicShadows
    /// </summary>
    public unsafe virtual void SetDynamicShadows(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDynamicShadows, "BmGame.RGFxMovieUI.SetDynamicShadows");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetDynamicShadows;
    /// <summary>
    /// Function: GetDynamicShadows
    /// </summary>
    public unsafe virtual int GetDynamicShadows(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDynamicShadows, "BmGame.RGFxMovieUI.GetDynamicShadows");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultDynamicShadows;
    /// <summary>
    /// Function: GetDefaultDynamicShadows
    /// </summary>
    public unsafe virtual int GetDefaultDynamicShadows(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultDynamicShadows, "BmGame.RGFxMovieUI.GetDefaultDynamicShadows");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetGeometryDetail;
    /// <summary>
    /// Function: SetGeometryDetail
    /// </summary>
    public unsafe virtual void SetGeometryDetail(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGeometryDetail, "BmGame.RGFxMovieUI.SetGeometryDetail");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetGeometryDetail;
    /// <summary>
    /// Function: GetGeometryDetail
    /// </summary>
    public unsafe virtual int GetGeometryDetail(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGeometryDetail, "BmGame.RGFxMovieUI.GetGeometryDetail");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultGeometryDetail;
    /// <summary>
    /// Function: GetDefaultGeometryDetail
    /// </summary>
    public unsafe virtual int GetDefaultGeometryDetail(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultGeometryDetail, "BmGame.RGFxMovieUI.GetDefaultGeometryDetail");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetAntiAliasing;
    /// <summary>
    /// Function: SetAntiAliasing
    /// </summary>
    public unsafe virtual void SetAntiAliasing(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAntiAliasing, "BmGame.RGFxMovieUI.SetAntiAliasing");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetAntiAliasing;
    /// <summary>
    /// Function: GetAntiAliasing
    /// </summary>
    public unsafe virtual int GetAntiAliasing(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAntiAliasing, "BmGame.RGFxMovieUI.GetAntiAliasing");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultAntiAliasing;
    /// <summary>
    /// Function: GetDefaultAntiAliasing
    /// </summary>
    public unsafe virtual int GetDefaultAntiAliasing(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultAntiAliasing, "BmGame.RGFxMovieUI.GetDefaultAntiAliasing");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetVSync;
    /// <summary>
    /// Function: SetVSync
    /// </summary>
    public unsafe virtual void SetVSync(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVSync, "BmGame.RGFxMovieUI.SetVSync");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetVSync;
    /// <summary>
    /// Function: GetVSync
    /// </summary>
    public unsafe virtual int GetVSync(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVSync, "BmGame.RGFxMovieUI.GetVSync");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultVSync;
    /// <summary>
    /// Function: GetDefaultVSync
    /// </summary>
    public unsafe virtual int GetDefaultVSync(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultVSync, "BmGame.RGFxMovieUI.GetDefaultVSync");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetResolution;
    /// <summary>
    /// Function: SetResolution
    /// </summary>
    public unsafe virtual void SetResolution(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetResolution, "BmGame.RGFxMovieUI.SetResolution");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetResolution;
    /// <summary>
    /// Function: GetResolution
    /// </summary>
    public unsafe virtual int GetResolution(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetResolution, "BmGame.RGFxMovieUI.GetResolution");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultResolution;
    /// <summary>
    /// Function: GetDefaultResolution
    /// </summary>
    public unsafe virtual int GetDefaultResolution(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultResolution, "BmGame.RGFxMovieUI.GetDefaultResolution");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetFullscreen;
    /// <summary>
    /// Function: SetFullscreen
    /// </summary>
    public unsafe virtual void SetFullscreen(bool bPlayer2, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFullscreen, "BmGame.RGFxMovieUI.SetFullscreen");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetFullscreen;
    /// <summary>
    /// Function: GetFullscreen
    /// </summary>
    public unsafe virtual int GetFullscreen(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFullscreen, "BmGame.RGFxMovieUI.GetFullscreen");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultFullscreen;
    /// <summary>
    /// Function: GetDefaultFullscreen
    /// </summary>
    public unsafe virtual int GetDefaultFullscreen(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultFullscreen, "BmGame.RGFxMovieUI.GetDefaultFullscreen");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetSixAxis;
    /// <summary>
    /// Function: GetSixAxis
    /// </summary>
    public unsafe virtual int GetSixAxis(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSixAxis, "BmGame.RGFxMovieUI.GetSixAxis");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetCameraAssist;
    /// <summary>
    /// Function: GetCameraAssist
    /// </summary>
    public unsafe virtual int GetCameraAssist(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCameraAssist, "BmGame.RGFxMovieUI.GetCameraAssist");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetVibration;
    /// <summary>
    /// Function: GetVibration
    /// </summary>
    public unsafe virtual int GetVibration(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVibration, "BmGame.RGFxMovieUI.GetVibration");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetInvertBatarang;
    /// <summary>
    /// Function: GetInvertBatarang
    /// </summary>
    public unsafe virtual int GetInvertBatarang(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInvertBatarang, "BmGame.RGFxMovieUI.GetInvertBatarang");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetInvertGlide;
    /// <summary>
    /// Function: GetInvertGlide
    /// </summary>
    public unsafe virtual int GetInvertGlide(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInvertGlide, "BmGame.RGFxMovieUI.GetInvertGlide");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetInvertRotation;
    /// <summary>
    /// Function: GetInvertRotation
    /// </summary>
    public unsafe virtual int GetInvertRotation(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInvertRotation, "BmGame.RGFxMovieUI.GetInvertRotation");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetInvertLook;
    /// <summary>
    /// Function: GetInvertLook
    /// </summary>
    public unsafe virtual int GetInvertLook(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInvertLook, "BmGame.RGFxMovieUI.GetInvertLook");
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

    private static BmSDK.Function __fn_GetVolumeDialogue;
    /// <summary>
    /// Function: GetVolumeDialogue
    /// </summary>
    public unsafe virtual int GetVolumeDialogue(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVolumeDialogue, "BmGame.RGFxMovieUI.GetVolumeDialogue");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetVolumeMusic;
    /// <summary>
    /// Function: GetVolumeMusic
    /// </summary>
    public unsafe virtual int GetVolumeMusic(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVolumeMusic, "BmGame.RGFxMovieUI.GetVolumeMusic");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetVolumeSFX;
    /// <summary>
    /// Function: GetVolumeSFX
    /// </summary>
    public unsafe virtual int GetVolumeSFX(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVolumeSFX, "BmGame.RGFxMovieUI.GetVolumeSFX");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetGamma;
    /// <summary>
    /// Function: GetGamma
    /// </summary>
    public unsafe virtual int GetGamma(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGamma, "BmGame.RGFxMovieUI.GetGamma");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDynamicRange;
    /// <summary>
    /// Function: GetDynamicRange
    /// </summary>
    public unsafe virtual int GetDynamicRange(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDynamicRange, "BmGame.RGFxMovieUI.GetDynamicRange");
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

    private static BmSDK.Function __fn_GetHints;
    /// <summary>
    /// Function: GetHints
    /// </summary>
    public unsafe virtual int GetHints(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHints, "BmGame.RGFxMovieUI.GetHints");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetTutorial;
    /// <summary>
    /// Function: GetTutorial
    /// </summary>
    public unsafe virtual int GetTutorial(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTutorial, "BmGame.RGFxMovieUI.GetTutorial");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetSubtitles;
    /// <summary>
    /// Function: GetSubtitles
    /// </summary>
    public unsafe virtual int GetSubtitles(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSubtitles, "BmGame.RGFxMovieUI.GetSubtitles");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDifficulty;
    /// <summary>
    /// Function: GetDifficulty
    /// </summary>
    public unsafe virtual int GetDifficulty(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDifficulty, "BmGame.RGFxMovieUI.GetDifficulty");
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

    private static BmSDK.Function __fn_GetDefaultSixAxis;
    /// <summary>
    /// Function: GetDefaultSixAxis
    /// </summary>
    public unsafe virtual int GetDefaultSixAxis(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultSixAxis, "BmGame.RGFxMovieUI.GetDefaultSixAxis");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultCameraAssist;
    /// <summary>
    /// Function: GetDefaultCameraAssist
    /// </summary>
    public unsafe virtual int GetDefaultCameraAssist(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultCameraAssist, "BmGame.RGFxMovieUI.GetDefaultCameraAssist");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultVibration;
    /// <summary>
    /// Function: GetDefaultVibration
    /// </summary>
    public unsafe virtual int GetDefaultVibration(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultVibration, "BmGame.RGFxMovieUI.GetDefaultVibration");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultInvertBatarang;
    /// <summary>
    /// Function: GetDefaultInvertBatarang
    /// </summary>
    public unsafe virtual int GetDefaultInvertBatarang(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultInvertBatarang, "BmGame.RGFxMovieUI.GetDefaultInvertBatarang");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultInvertGlide;
    /// <summary>
    /// Function: GetDefaultInvertGlide
    /// </summary>
    public unsafe virtual int GetDefaultInvertGlide(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultInvertGlide, "BmGame.RGFxMovieUI.GetDefaultInvertGlide");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultInvertRotation;
    /// <summary>
    /// Function: GetDefaultInvertRotation
    /// </summary>
    public unsafe virtual int GetDefaultInvertRotation(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultInvertRotation, "BmGame.RGFxMovieUI.GetDefaultInvertRotation");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultInvertLook;
    /// <summary>
    /// Function: GetDefaultInvertLook
    /// </summary>
    public unsafe virtual int GetDefaultInvertLook(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultInvertLook, "BmGame.RGFxMovieUI.GetDefaultInvertLook");
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

    private static BmSDK.Function __fn_GetDefaultVolumeDialogue;
    /// <summary>
    /// Function: GetDefaultVolumeDialogue
    /// </summary>
    public unsafe virtual int GetDefaultVolumeDialogue(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultVolumeDialogue, "BmGame.RGFxMovieUI.GetDefaultVolumeDialogue");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultVolumeMusic;
    /// <summary>
    /// Function: GetDefaultVolumeMusic
    /// </summary>
    public unsafe virtual int GetDefaultVolumeMusic(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultVolumeMusic, "BmGame.RGFxMovieUI.GetDefaultVolumeMusic");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultVolumeSFX;
    /// <summary>
    /// Function: GetDefaultVolumeSFX
    /// </summary>
    public unsafe virtual int GetDefaultVolumeSFX(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultVolumeSFX, "BmGame.RGFxMovieUI.GetDefaultVolumeSFX");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultGamma;
    /// <summary>
    /// Function: GetDefaultGamma
    /// </summary>
    public unsafe virtual int GetDefaultGamma(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultGamma, "BmGame.RGFxMovieUI.GetDefaultGamma");
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

    private static BmSDK.Function __fn_GetDefaultHints;
    /// <summary>
    /// Function: GetDefaultHints
    /// </summary>
    public unsafe virtual int GetDefaultHints(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultHints, "BmGame.RGFxMovieUI.GetDefaultHints");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultTutorial;
    /// <summary>
    /// Function: GetDefaultTutorial
    /// </summary>
    public unsafe virtual int GetDefaultTutorial(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultTutorial, "BmGame.RGFxMovieUI.GetDefaultTutorial");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultDynamicRange;
    /// <summary>
    /// Function: GetDefaultDynamicRange
    /// </summary>
    public unsafe virtual int GetDefaultDynamicRange(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultDynamicRange, "BmGame.RGFxMovieUI.GetDefaultDynamicRange");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultSubtitles;
    /// <summary>
    /// Function: GetDefaultSubtitles
    /// </summary>
    public unsafe virtual int GetDefaultSubtitles(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultSubtitles, "BmGame.RGFxMovieUI.GetDefaultSubtitles");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayer2, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetDefaultDifficulty;
    /// <summary>
    /// Function: GetDefaultDifficulty
    /// </summary>
    public unsafe virtual int GetDefaultDifficulty(bool bPlayer2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultDifficulty, "BmGame.RGFxMovieUI.GetDefaultDifficulty");
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
    public unsafe virtual void SetPrompts(BmSDK.BmGame.RGFxMovieUI.UIPromptType PromptType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPrompts, "BmGame.RGFxMovieUI.SetPrompts");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PromptType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
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

    private static BmSDK.Function __fn_SetFocusOn;
    /// <summary>
    /// Function: SetFocusOn
    /// </summary>
    public unsafe virtual void SetFocusOn(BmSDK.GFxUI.GFxObject focusObject, int val = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFocusOn, "BmGame.RGFxMovieUI.SetFocusOn");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(focusObject, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(val, paramsPtr + 4);
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

    private static BmSDK.Function __fn_RequestMenuData;
    /// <summary>
    /// Function: RequestMenuData
    /// </summary>
    public unsafe virtual int RequestMenuData(BmSDK.FString TargetBasePath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestMenuData, "BmGame.RGFxMovieUI.RequestMenuData");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBasePath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetGridButtonContext;
    /// <summary>
    /// Function: GetGridButtonContext
    /// </summary>
    public unsafe virtual BmSDK.FString GetGridButtonContext(int ButtonId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGridButtonContext, "BmGame.RGFxMovieUI.GetGridButtonContext");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsCatwomanAvailable;
    /// <summary>
    /// Function: IsCatwomanAvailable
    /// </summary>
    public unsafe virtual bool IsCatwomanAvailable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCatwomanAvailable, "BmGame.RGFxMovieUI.IsCatwomanAvailable");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsNewGamePlusIABStarted;
    /// <summary>
    /// Function: IsNewGamePlusIABStarted
    /// </summary>
    public unsafe virtual bool IsNewGamePlusIABStarted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsNewGamePlusIABStarted, "BmGame.RGFxMovieUI.IsNewGamePlusIABStarted");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsNewGamePlusIABUnlocked;
    /// <summary>
    /// Function: IsNewGamePlusIABUnlocked
    /// </summary>
    public unsafe virtual bool IsNewGamePlusIABUnlocked()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsNewGamePlusIABUnlocked, "BmGame.RGFxMovieUI.IsNewGamePlusIABUnlocked");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsNewGamePlusStarted;
    /// <summary>
    /// Function: IsNewGamePlusStarted
    /// </summary>
    public unsafe virtual bool IsNewGamePlusStarted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsNewGamePlusStarted, "BmGame.RGFxMovieUI.IsNewGamePlusStarted");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsNewGamePlusUnlocked;
    /// <summary>
    /// Function: IsNewGamePlusUnlocked
    /// </summary>
    public unsafe virtual bool IsNewGamePlusUnlocked()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsNewGamePlusUnlocked, "BmGame.RGFxMovieUI.IsNewGamePlusUnlocked");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsSuitSelectorEnabled;
    /// <summary>
    /// Function: IsSuitSelectorEnabled
    /// </summary>
    public unsafe virtual bool IsSuitSelectorEnabled()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSuitSelectorEnabled, "BmGame.RGFxMovieUI.IsSuitSelectorEnabled");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
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

    private static BmSDK.Function __fn_EndRow;
    /// <summary>
    /// Function: EndRow
    /// </summary>
    public unsafe virtual void EndRow()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndRow, "BmGame.RGFxMovieUI.EndRow");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddGridItem;
    /// <summary>
    /// Function: AddGridItem
    /// </summary>
    public unsafe virtual void AddGridItem(int inID, BmSDK.FString inItemName, BmSDK.FString inPackageName, BmSDK.FString inDisplayNameRef, bool inPlatformSpecific, bool inLocked, bool inNew = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddGridItem, "BmGame.RGFxMovieUI.AddGridItem");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inItemName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inPackageName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inDisplayNameRef, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inPlatformSpecific, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inLocked, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inNew, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
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

    private static BmSDK.Function __fn_StopLoadingAudioLoop;
    /// <summary>
    /// Function: StopLoadingAudioLoop
    /// </summary>
    public unsafe virtual void StopLoadingAudioLoop()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopLoadingAudioLoop, "BmGame.RGFxMovieUI.StopLoadingAudioLoop");
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
    /// StructProperty: MenuIndex
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGFxMovieUI.FMenuState MenuIndex
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGFxMovieUI.FMenuState>(Ptr + 588);

    /// <summary>
    /// StrProperty: TitleStorageFileToRead
    /// </summary>
    public unsafe BmSDK.FString TitleStorageFileToRead
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// DelegateProperty: OnUpdateSeasonsPassCompleteCallback
    /// </summary>
    public unsafe System.IntPtr OnUpdateSeasonsPassCompleteCallback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// StrProperty: IconSetPackage
    /// </summary>
    public unsafe BmSDK.FString IconSetPackage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// StrProperty: NameBaseRef
    /// </summary>
    public unsafe BmSDK.FString NameBaseRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// IntProperty: SavedButtonId
    /// </summary>
    public unsafe int SavedButtonId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// IntProperty: rowCounter
    /// </summary>
    public unsafe int rowCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// IntProperty: rowsUsed
    /// </summary>
    public unsafe int rowsUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// IntProperty: ButtonsX
    /// </summary>
    public unsafe int ButtonsX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// IntProperty: ButtonsY
    /// </summary>
    public unsafe int ButtonsY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ArrayProperty: ButtonIds
    /// </summary>
    public unsafe BmSDK.TArray<int> ButtonIds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// ArrayProperty: ButtonStates
    /// </summary>
    public unsafe BmSDK.TArray<int> ButtonStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ArrayProperty: ButtonIconNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ButtonIconNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ArrayProperty: ButtonIconPkgNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ButtonIconPkgNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ArrayProperty: ButtonStringRefs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ButtonStringRefs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// StrProperty: MovieName
    /// </summary>
    public unsafe BmSDK.FString MovieName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// StrProperty: OnBackCmd
    /// </summary>
    public unsafe BmSDK.FString OnBackCmd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bNoMenuSave
    /// </summary>
    public unsafe bool bNoMenuSave
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 756); }
    }

    /// <summary>
    /// BoolProperty: bInTransition
    /// </summary>
    public unsafe bool bInTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 756); }
    }

    /// <summary>
    /// BoolProperty: bShouldDoApplyCheck
    /// </summary>
    public unsafe bool bShouldDoApplyCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 756); }
    }

    /// <summary>
    /// BoolProperty: bShouldCancelChanges
    /// </summary>
    public unsafe bool bShouldCancelChanges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 756); }
    }

    /// <summary>
    /// BoolProperty: bDoingApply
    /// </summary>
    public unsafe bool bDoingApply
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 756); }
    }

    /// <summary>
    /// ObjectProperty: ApplyChangesPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ApplyChangesPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// ObjectProperty: ControllerImageRef
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie ControllerImageRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ArrayProperty: SwfRefs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GFxUI.SwfMovie> SwfRefs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GFxUI.SwfMovie>>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// DelegateProperty: __OnUpdateSeasonsPassCompleteDelegate__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnUpdateSeasonsPassCompleteDelegate__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// DelegateProperty: __OnReadLiveOfferFromStorageCompleteDelegate__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReadLiveOfferFromStorageCompleteDelegate__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// DelegateProperty: __OnEnumerateMarketplaceOffersCompleteDelegate__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnEnumerateMarketplaceOffersCompleteDelegate__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// Struct: FMenuState
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
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
        /// ArrayProperty: ActiveColumnIndexs
        /// </summary>
        public unsafe BmSDK.TArray<int> ActiveColumnIndexs
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
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
    /// Enum: UIPromptType
    /// </summary>
    public enum UIPromptType : byte
    {
        UIPT_None = 0,
        UIPT_MenuA = 1,
        UIPT_MenuB = 2,
        UIPT_MenuAB = 3,
        UIPT_MenuABY = 4,
        UIPT_MainABY = 5,
        UIPT_MainAY = 6,
        UIPT_MenuB_UD = 7,
        UIPT_OptionABY = 8,
        UIPT_OptionBY = 9,
        UIPT_OptionAB = 10,
        UIPT_SlotsABDel = 11,
        UIPT_LobbyMapLocal = 12,
        UIPT_LobbyMap = 13,
        UIPT_MapInterrogate = 14,
        UIPT_LobbyCharacterLocal = 15,
        UIPT_LobbyCharacter = 16,
        UIPT_LobbyLeaderboard = 17,
        UIPT_MapSelectRanked = 18,
        UIPT_MapSelectCustom = 19,
        UIPT_MapSelectCampaign = 20,
        UIPT_MapSelectTraining = 21,
        UIPT_MapCampaignInfo = 22,
        UIPT_MapLeaderboard = 23,
        UIPT_MapLeaderboard_NoY = 24,
        UIPT_StoreA = 25,
        UIPT_StoreABY = 26,
        UIPT_StorePurchasedABY = 27,
        UIPT_OptionABYApply = 28,
        UIPT_MAX = 29,
    }
}
