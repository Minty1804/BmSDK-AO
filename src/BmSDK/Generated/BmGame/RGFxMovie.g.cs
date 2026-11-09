#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovie<br/>
/// (size = 588)
/// (flags = 134217878)
/// </summary>
public partial class RGFxMovie : BmSDK.GFxUI.GFxMoviePlayer, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovie", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovie.
    /// </summary>
    public static RGFxMovie DefaultObject => (RGFxMovie)StaticClass().DefaultObject;

    internal RGFxMovie() { }

    /// <summary>
    /// Constructs a new RGFxMovie
    /// </summary>
    public RGFxMovie(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovie Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovie(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovie>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovie>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovie>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovie>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovie>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovie>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovie>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovie>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_StopRiddle;
    /// <summary>
    /// Function: StopRiddle
    /// </summary>
    public unsafe virtual void StopRiddle(bool DefSet = default, bool ForceStop = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopRiddle, "BmGame.RGFxMovie.StopRiddle");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DefSet, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceStop, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopTape;
    /// <summary>
    /// Function: StopTape
    /// </summary>
    public unsafe virtual void StopTape()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopTape, "BmGame.RGFxMovie.StopTape");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayStreamedSound;
    /// <summary>
    /// Function: PlayStreamedSound
    /// </summary>
    public unsafe virtual void PlayStreamedSound(BmSDK.FString SFX)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayStreamedSound, "BmGame.RGFxMovie.PlayStreamedSound");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SFX, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayTelephoneConversation;
    /// <summary>
    /// Function: PlayTelephoneConversation
    /// </summary>
    public unsafe virtual void PlayTelephoneConversation(BmSDK.FString ConversationRef)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayTelephoneConversation, "BmGame.RGFxMovie.PlayTelephoneConversation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConversationRef, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayConversation;
    /// <summary>
    /// Function: PlayConversation
    /// </summary>
    public unsafe virtual void PlayConversation(BmSDK.FString ConversationRef)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayConversation, "BmGame.RGFxMovie.PlayConversation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConversationRef, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayTape;
    /// <summary>
    /// Function: PlayTape
    /// </summary>
    public unsafe virtual void PlayTape(BmSDK.FString CharacterName, int TapeID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayTape, "BmGame.RGFxMovie.PlayTape");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TapeID, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayTapeFinishedCallback;
    /// <summary>
    /// Function: PlayTapeFinishedCallback
    /// </summary>
    public unsafe virtual void PlayTapeFinishedCallback()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayTapeFinishedCallback, "BmGame.RGFxMovie.PlayTapeFinishedCallback");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSubtitle;
    /// <summary>
    /// Function: SetSubtitle
    /// </summary>
    public unsafe virtual bool SetSubtitle(BmSDK.FString TheText)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSubtitle, "BmGame.RGFxMovie.SetSubtitle");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheText, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetDialogueManager;
    /// <summary>
    /// Function: GetDialogueManager
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RDialogueManager GetDialogueManager()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDialogueManager, "BmGame.RGFxMovie.GetDialogueManager");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RDialogueManager>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RemoveSubtitle;
    /// <summary>
    /// Function: RemoveSubtitle
    /// </summary>
    public unsafe virtual void RemoveSubtitle()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveSubtitle, "BmGame.RGFxMovie.RemoveSubtitle");
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

    private static BmSDK.Function __fn_AddSubtitle;
    /// <summary>
    /// Function: AddSubtitle
    /// </summary>
    public unsafe virtual void AddSubtitle(int SubtitlePriority, float SubtitleDuration, BmSDK.FString SubtitleText, bool bBackScreen, bool bMovie)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddSubtitle, "BmGame.RGFxMovie.AddSubtitle");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubtitlePriority, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubtitleDuration, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubtitleText, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBackScreen, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMovie, paramsPtr + 24);
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

    private static BmSDK.Function __fn_GetSubAudioTrackID;
    /// <summary>
    /// Function: GetSubAudioTrackID
    /// </summary>
    public unsafe virtual void GetSubAudioTrackID(out int SubAudioTrackId, out int SubtitleTrackId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSubAudioTrackID, "BmGame.RGFxMovie.GetSubAudioTrackID");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SubAudioTrackId);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubAudioTrackId, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SubtitleTrackId);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubtitleTrackId, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        SubAudioTrackId = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        SubtitleTrackId = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_Live_IsSignedInOnline;
    /// <summary>
    /// Function: Live_IsSignedInOnline
    /// </summary>
    public unsafe virtual bool Live_IsSignedInOnline()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Live_IsSignedInOnline, "BmGame.RGFxMovie.Live_IsSignedInOnline");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GameMovieSetPauseState;
    /// <summary>
    /// Function: GameMovieSetPauseState
    /// </summary>
    public unsafe virtual void GameMovieSetPauseState(bool bPause)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GameMovieSetPauseState, "BmGame.RGFxMovie.GameMovieSetPauseState");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPause, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasGameMovieContent;
    /// <summary>
    /// Function: HasGameMovieContent
    /// </summary>
    public unsafe virtual bool HasGameMovieContent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasGameMovieContent, "BmGame.RGFxMovie.HasGameMovieContent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RemoveAudioAssetPack;
    /// <summary>
    /// Function: RemoveAudioAssetPack
    /// </summary>
    public unsafe virtual void RemoveAudioAssetPack(BmSDK.Engine.AkAssetPack asset_pack)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveAudioAssetPack, "BmGame.RGFxMovie.RemoveAudioAssetPack");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(asset_pack, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushAudioAssetPack;
    /// <summary>
    /// Function: PushAudioAssetPack
    /// </summary>
    public unsafe virtual void PushAudioAssetPack(BmSDK.Engine.AkAssetPack asset_pack)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushAudioAssetPack, "BmGame.RGFxMovie.PushAudioAssetPack");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(asset_pack, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAssetPackIndex;
    /// <summary>
    /// Function: GetAssetPackIndex
    /// </summary>
    public unsafe virtual int GetAssetPackIndex(BmSDK.Engine.AkAssetPack asset_pack)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAssetPackIndex, "BmGame.RGFxMovie.GetAssetPackIndex");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(asset_pack, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetToolTip;
    /// <summary>
    /// Function: SetToolTip
    /// </summary>
    public unsafe virtual void SetToolTip(BmSDK.FString Text = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetToolTip, "BmGame.RGFxMovie.SetToolTip");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 0);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_FrontMost_LayoutPrompts;
    /// <summary>
    /// Function: FrontMost_LayoutPrompts
    /// </summary>
    public unsafe virtual void FrontMost_LayoutPrompts()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FrontMost_LayoutPrompts, "BmGame.RGFxMovie.FrontMost_LayoutPrompts");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FrontMost_SetPrompt;
    /// <summary>
    /// Function: FrontMost_SetPrompt
    /// </summary>
    public unsafe virtual void FrontMost_SetPrompt(int PromptId, BmSDK.FString PromptTag, int Brightness)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FrontMost_SetPrompt, "BmGame.RGFxMovie.FrontMost_SetPrompt");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PromptId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PromptTag, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Brightness, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FrontMost_ClearPrompts;
    /// <summary>
    /// Function: FrontMost_ClearPrompts
    /// </summary>
    public unsafe virtual void FrontMost_ClearPrompts()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FrontMost_ClearPrompts, "BmGame.RGFxMovie.FrontMost_ClearPrompts");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsCircleToAccept;
    /// <summary>
    /// Function: IsCircleToAccept
    /// </summary>
    public unsafe virtual bool IsCircleToAccept()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCircleToAccept, "BmGame.RGFxMovie.IsCircleToAccept");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_xGetGlobalFlag;
    /// <summary>
    /// Function: xGetGlobalFlag
    /// </summary>
    public unsafe virtual int xGetGlobalFlag(BmSDK.FString FlagName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_xGetGlobalFlag, "BmGame.RGFxMovie.xGetGlobalFlag");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlagName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_xSetGlobalFlag;
    /// <summary>
    /// Function: xSetGlobalFlag
    /// </summary>
    public unsafe virtual void xSetGlobalFlag(BmSDK.FString FlagName, bool bValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_xSetGlobalFlag, "BmGame.RGFxMovie.xSetGlobalFlag");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlagName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bValue, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPS3_480i;
    /// <summary>
    /// Function: IsPS3_480i
    /// </summary>
    public unsafe virtual bool IsPS3_480i()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPS3_480i, "BmGame.RGFxMovie.IsPS3_480i");
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

    private static BmSDK.Function __fn_IsPS3_4x3;
    /// <summary>
    /// Function: IsPS3_4x3
    /// </summary>
    public unsafe virtual bool IsPS3_4x3()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPS3_4x3, "BmGame.RGFxMovie.IsPS3_4x3");
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

    private static BmSDK.Function __fn_SetAudioSuppressed;
    /// <summary>
    /// Function: SetAudioSuppressed
    /// </summary>
    public unsafe virtual void SetAudioSuppressed(bool should_suppress)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAudioSuppressed, "BmGame.RGFxMovie.SetAudioSuppressed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(should_suppress, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetLanguageExt;
    /// <summary>
    /// Function: GetLanguageExt
    /// </summary>
    public unsafe virtual BmSDK.FString GetLanguageExt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLanguageExt, "BmGame.RGFxMovie.GetLanguageExt");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsPointerValid;
    /// <summary>
    /// Function: IsPointerValid
    /// </summary>
    public unsafe virtual bool IsPointerValid()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPointerValid, "BmGame.RGFxMovie.IsPointerValid");
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

    private static BmSDK.Function __fn_SetAudioState;
    /// <summary>
    /// Function: SetAudioState
    /// </summary>
    public unsafe virtual void SetAudioState(BmSDK.FString StateName, BmSDK.FString StateValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAudioState, "BmGame.RGFxMovie.SetAudioState");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateValue, paramsPtr + 12);
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

    private static BmSDK.Function __fn_SetAudioParameter;
    /// <summary>
    /// Function: SetAudioParameter
    /// </summary>
    public unsafe virtual void SetAudioParameter(BmSDK.FString ParamName, float ParamValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAudioParameter, "BmGame.RGFxMovie.SetAudioParameter");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParamName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParamValue, paramsPtr + 12);
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

    private static BmSDK.Function __fn_KillEventInstance;
    /// <summary>
    /// Function: KillEventInstance
    /// </summary>
    public unsafe virtual void KillEventInstance(int InstanceID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillEventInstance, "BmGame.RGFxMovie.KillEventInstance");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstanceID, paramsPtr + 0);
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

    private static BmSDK.Function __fn_PostAudioEvent;
    /// <summary>
    /// Function: PostAudioEvent
    /// </summary>
    public unsafe virtual int PostAudioEvent(int ChannelID, BmSDK.FString EventName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostAudioEvent, "BmGame.RGFxMovie.PostAudioEvent");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChannelID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_SetGlobalAudioState;
    /// <summary>
    /// Function: SetGlobalAudioState
    /// </summary>
    public unsafe virtual void SetGlobalAudioState(BmSDK.FString StateName, BmSDK.FString StateValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGlobalAudioState, "BmGame.RGFxMovie.SetGlobalAudioState");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateValue, paramsPtr + 12);
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

    private static BmSDK.Function __fn_SetGlobalAudioParameter;
    /// <summary>
    /// Function: SetGlobalAudioParameter
    /// </summary>
    public unsafe virtual void SetGlobalAudioParameter(BmSDK.FString RtpcName, float RtpcValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGlobalAudioParameter, "BmGame.RGFxMovie.SetGlobalAudioParameter");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RtpcName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RtpcValue, paramsPtr + 12);
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

    private static BmSDK.Function __fn_StopFlashAudioEventUI;
    /// <summary>
    /// Function: StopFlashAudioEventUI
    /// </summary>
    public unsafe virtual void StopFlashAudioEventUI(int InstanceID, BmSDK.FString EventName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopFlashAudioEventUI, "BmGame.RGFxMovie.StopFlashAudioEventUI");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstanceID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 4);
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

    private static BmSDK.Function __fn_StartFlashAudioEventUI;
    /// <summary>
    /// Function: StartFlashAudioEventUI
    /// </summary>
    public unsafe virtual int StartFlashAudioEventUI(BmSDK.FString EventName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartFlashAudioEventUI, "BmGame.RGFxMovie.StartFlashAudioEventUI");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_StopFlashAudioEvent;
    /// <summary>
    /// Function: StopFlashAudioEvent
    /// </summary>
    public unsafe virtual void StopFlashAudioEvent(int InstanceID, BmSDK.FString EventName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopFlashAudioEvent, "BmGame.RGFxMovie.StopFlashAudioEvent");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstanceID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 4);
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

    private static BmSDK.Function __fn_StartFlashAudioEvent;
    /// <summary>
    /// Function: StartFlashAudioEvent
    /// </summary>
    public unsafe virtual int StartFlashAudioEvent(BmSDK.FString EventName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartFlashAudioEvent, "BmGame.RGFxMovie.StartFlashAudioEvent");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_StopSound;
    /// <summary>
    /// Function: StopSound
    /// </summary>
    public unsafe virtual bool StopSound(BmSDK.FString SFX)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopSound, "BmGame.RGFxMovie.StopSound");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SFX, paramsPtr + 0);
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

    private static BmSDK.Function __fn_StartSound;
    /// <summary>
    /// Function: StartSound
    /// </summary>
    public unsafe virtual bool StartSound(BmSDK.FString SFX)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSound, "BmGame.RGFxMovie.StartSound");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SFX, paramsPtr + 0);
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

    private static BmSDK.Function __fn_PlaySound;
    /// <summary>
    /// Function: PlaySound
    /// </summary>
    public unsafe virtual bool PlaySound(BmSDK.FString SFX)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySound, "BmGame.RGFxMovie.PlaySound");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SFX, paramsPtr + 0);
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

    private static BmSDK.Function __fn_Localise;
    /// <summary>
    /// Function: Localise
    /// </summary>
    public unsafe virtual BmSDK.FString Localise(BmSDK.FString Str)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Localise, "BmGame.RGFxMovie.Localise");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Str, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_TriggerPromptClicked;
    /// <summary>
    /// Function: TriggerPromptClicked
    /// </summary>
    public unsafe virtual void TriggerPromptClicked(int PromptId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerPromptClicked, "BmGame.RGFxMovie.TriggerPromptClicked");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PromptId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReplaceInString;
    /// <summary>
    /// Function: ReplaceInString
    /// </summary>
    public unsafe virtual BmSDK.FString ReplaceInString(BmSDK.FString OriginalString, BmSDK.FString SearchText, BmSDK.FString ReplacementText)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplaceInString, "BmGame.RGFxMovie.ReplaceInString");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OriginalString, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchText, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReplacementText, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_GetPCStringWithPrompts;
    /// <summary>
    /// Function: GetPCStringWithPrompts
    /// </summary>
    public unsafe virtual BmSDK.FString GetPCStringWithPrompts(BmSDK.FString originalStringId, bool bUsingDPad)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPCStringWithPrompts, "BmGame.RGFxMovie.GetPCStringWithPrompts");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(originalStringId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUsingDPad, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_RequestPromptMappingFor;
    /// <summary>
    /// Function: RequestPromptMappingFor
    /// </summary>
    public unsafe virtual BmSDK.FString RequestPromptMappingFor(int PlayerID, int PromptId, bool bUsingPad)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestPromptMappingFor, "BmGame.RGFxMovie.RequestPromptMappingFor");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PromptId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUsingPad, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_RequestPromptMapping;
    /// <summary>
    /// Function: RequestPromptMapping
    /// </summary>
    public unsafe virtual void RequestPromptMapping(int PlayerID, BmSDK.FString IconMappingArray, BmSDK.FString KeyMappingArray, BmSDK.FString KeyMapping2Array)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestPromptMapping, "BmGame.RGFxMovie.RequestPromptMapping");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconMappingArray, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyMappingArray, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyMapping2Array, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateHudVisibility;
    /// <summary>
    /// Function: UpdateHudVisibility
    /// </summary>
    public unsafe virtual void UpdateHudVisibility(bool bVisible)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateHudVisibility, "BmGame.RGFxMovie.UpdateHudVisibility");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsGenericErrorOpen;
    /// <summary>
    /// Function: IsGenericErrorOpen
    /// </summary>
    public unsafe virtual bool IsGenericErrorOpen()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsGenericErrorOpen, "BmGame.RGFxMovie.IsGenericErrorOpen");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnFadeCompleted_Callback;
    /// <summary>
    /// Function: OnFadeCompleted_Callback
    /// </summary>
    public unsafe virtual void OnFadeCompleted_Callback()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFadeCompleted_Callback, "BmGame.RGFxMovie.OnFadeCompleted_Callback");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopupRequester_Callback;
    /// <summary>
    /// Function: PopupRequester_Callback
    /// </summary>
    public unsafe virtual void PopupRequester_Callback(BmSDK.BmGame.RGFxMoviePopupRequester ThePopUpMsg, int ButtonId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopupRequester_Callback, "BmGame.RGFxMovie.PopupRequester_Callback");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThePopUpMsg, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OpenPopupMessage2;
    /// <summary>
    /// Function: OpenPopupMessage2
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGFxMoviePopupRequester OpenPopupMessage2(BmSDK.FString Prompt1, BmSDK.FString Prompt2, BmSDK.FString Message)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenPopupMessage2, "BmGame.RGFxMovie.OpenPopupMessage2");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Prompt1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Prompt2, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGFxMoviePopupRequester>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_OpenPopupMessage1;
    /// <summary>
    /// Function: OpenPopupMessage1
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGFxMoviePopupRequester OpenPopupMessage1(BmSDK.FString Prompt1, BmSDK.FString Message)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OpenPopupMessage1, "BmGame.RGFxMovie.OpenPopupMessage1");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Prompt1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGFxMoviePopupRequester>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_KismetEvent;
    /// <summary>
    /// Function: KismetEvent
    /// </summary>
    public unsafe virtual void KismetEvent(BmSDK.FString EventName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KismetEvent, "BmGame.RGFxMovie.KismetEvent");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGameStatus;
    /// <summary>
    /// Function: GetGameStatus
    /// </summary>
    public unsafe virtual int GetGameStatus()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGameStatus, "BmGame.RGFxMovie.GetGameStatus");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsInputBlocked;
    /// <summary>
    /// Function: IsInputBlocked
    /// </summary>
    public unsafe virtual bool IsInputBlocked()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInputBlocked, "BmGame.RGFxMovie.IsInputBlocked");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlockInput, "BmGame.RGFxMovie.BlockInput");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBlocked, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGameStatus;
    /// <summary>
    /// Function: SetGameStatus
    /// </summary>
    public unsafe virtual void SetGameStatus(BmSDK.BmGame.RGameRI.EGameStatus Status)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGameStatus, "BmGame.RGFxMovie.SetGameStatus");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Status, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGRI;
    /// <summary>
    /// Function: GetGRI
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameRI GetGRI()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGRI, "BmGame.RGFxMovie.GetGRI");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRGI, "BmGame.RGFxMovie.GetRGI");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetWI;
    /// <summary>
    /// Function: GetWI
    /// </summary>
    public unsafe virtual BmSDK.Engine.WorldInfo GetWI()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWI, "BmGame.RGFxMovie.GetWI");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.WorldInfo>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnClose;
    /// <summary>
    /// Function: OnClose
    /// </summary>
    public unsafe override void OnClose()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnClose, "BmGame.RGFxMovie.OnClose");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RGFxMovie.Init");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReleaseAllStreamedPackageReference;
    /// <summary>
    /// Function: ReleaseAllStreamedPackageReference
    /// </summary>
    public unsafe virtual void ReleaseAllStreamedPackageReference()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseAllStreamedPackageReference, "BmGame.RGFxMovie.ReleaseAllStreamedPackageReference");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReleaseStreamedPackageReference;
    /// <summary>
    /// Function: ReleaseStreamedPackageReference
    /// </summary>
    public unsafe virtual void ReleaseStreamedPackageReference(BmSDK.FString PackageName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseStreamedPackageReference, "BmGame.RGFxMovie.ReleaseStreamedPackageReference");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PackageStreamFailed;
    /// <summary>
    /// Function: PackageStreamFailed
    /// </summary>
    public unsafe virtual void PackageStreamFailed(BmSDK.FString Package)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PackageStreamFailed, "BmGame.RGFxMovie.PackageStreamFailed");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Package, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PackageStreamSucceeded;
    /// <summary>
    /// Function: PackageStreamSucceeded
    /// </summary>
    public unsafe virtual void PackageStreamSucceeded(BmSDK.FString PackageName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PackageStreamSucceeded, "BmGame.RGFxMovie.PackageStreamSucceeded");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddReferencesToObjectsInPackage;
    /// <summary>
    /// Function: AddReferencesToObjectsInPackage
    /// </summary>
    public unsafe virtual void AddReferencesToObjectsInPackage(BmSDK.Package StreamedPackage, int streamedPackagesIndex, bool isPreload)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddReferencesToObjectsInPackage, "BmGame.RGFxMovie.AddReferencesToObjectsInPackage");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StreamedPackage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(streamedPackagesIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(isPreload, paramsPtr + 8);
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

    private static BmSDK.Function __fn_PackageStreamed;
    /// <summary>
    /// Function: PackageStreamed
    /// </summary>
    public unsafe virtual void PackageStreamed(BmSDK.Engine.MObjectStreaming.EStreamingResult Result, BmSDK.Package StreamedPackage, BmSDK.Engine.MObjectStreaming.FObjectStreamingId Id, BmSDK.FString PackageName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PackageStreamed, "BmGame.RGFxMovie.PackageStreamed");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Result, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StreamedPackage, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StreamPackage;
    /// <summary>
    /// Function: StreamPackage
    /// </summary>
    public unsafe virtual void StreamPackage(BmSDK.FString PackageName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StreamPackage, "BmGame.RGFxMovie.StreamPackage");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReleaseAllStreamedObjectReference;
    /// <summary>
    /// Function: ReleaseAllStreamedObjectReference
    /// </summary>
    public unsafe virtual void ReleaseAllStreamedObjectReference()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseAllStreamedObjectReference, "BmGame.RGFxMovie.ReleaseAllStreamedObjectReference");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReleaseStreamedObjectReference;
    /// <summary>
    /// Function: ReleaseStreamedObjectReference
    /// </summary>
    public unsafe virtual void ReleaseStreamedObjectReference(BmSDK.FString ObjectName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseStreamedObjectReference, "BmGame.RGFxMovie.ReleaseStreamedObjectReference");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ObjectStreamFailed;
    /// <summary>
    /// Function: ObjectStreamFailed
    /// </summary>
    public unsafe virtual void ObjectStreamFailed(BmSDK.FString ObjectName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ObjectStreamFailed, "BmGame.RGFxMovie.ObjectStreamFailed");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ObjectStreamSucceeded;
    /// <summary>
    /// Function: ObjectStreamSucceeded
    /// </summary>
    public unsafe virtual void ObjectStreamSucceeded(BmSDK.FString ObjectName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ObjectStreamSucceeded, "BmGame.RGFxMovie.ObjectStreamSucceeded");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ObjectStreamed;
    /// <summary>
    /// Function: ObjectStreamed
    /// </summary>
    public unsafe virtual void ObjectStreamed(BmSDK.Engine.MObjectStreaming.EStreamingResult Result, BmSDK.GameObject StreamedObject, BmSDK.Engine.MObjectStreaming.FObjectStreamingId Id, BmSDK.FString PackageName, BmSDK.FString ObjectName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ObjectStreamed, "BmGame.RGFxMovie.ObjectStreamed");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Result, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StreamedObject, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectName, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StreamObject;
    /// <summary>
    /// Function: StreamObject
    /// </summary>
    public unsafe virtual void StreamObject(BmSDK.FString ObjectName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StreamObject, "BmGame.RGFxMovie.StreamObject");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReleaseAllPreloadedPackageReference;
    /// <summary>
    /// Function: ReleaseAllPreloadedPackageReference
    /// </summary>
    public unsafe virtual void ReleaseAllPreloadedPackageReference()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseAllPreloadedPackageReference, "BmGame.RGFxMovie.ReleaseAllPreloadedPackageReference");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReleasePreloadedPackageReference;
    /// <summary>
    /// Function: ReleasePreloadedPackageReference
    /// </summary>
    public unsafe virtual void ReleasePreloadedPackageReference(BmSDK.FString PackageName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleasePreloadedPackageReference, "BmGame.RGFxMovie.ReleasePreloadedPackageReference");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PackagePreloadCompletionDelegate;
    /// <summary>
    /// Function: PackagePreloadCompletionDelegate
    /// </summary>
    public unsafe virtual void PackagePreloadCompletionDelegate(BmSDK.Engine.MObjectStreaming.EStreamingResult Result, BmSDK.Package StreamedPackage, BmSDK.Engine.MObjectStreaming.FObjectStreamingId Id, BmSDK.FString PackageName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PackagePreloadCompletionDelegate, "BmGame.RGFxMovie.PackagePreloadCompletionDelegate");
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Result, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StreamedPackage, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPreloadPackage;
    /// <summary>
    /// Function: AddPreloadPackage
    /// </summary>
    public unsafe virtual void AddPreloadPackage(BmSDK.FString PackageName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPreloadPackage, "BmGame.RGFxMovie.AddPreloadPackage");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReleaseAllPreloadedObjectReference;
    /// <summary>
    /// Function: ReleaseAllPreloadedObjectReference
    /// </summary>
    public unsafe virtual void ReleaseAllPreloadedObjectReference()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseAllPreloadedObjectReference, "BmGame.RGFxMovie.ReleaseAllPreloadedObjectReference");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReleasePreloadedObjectReference;
    /// <summary>
    /// Function: ReleasePreloadedObjectReference
    /// </summary>
    public unsafe virtual void ReleasePreloadedObjectReference(BmSDK.FString ObjectName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleasePreloadedObjectReference, "BmGame.RGFxMovie.ReleasePreloadedObjectReference");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ObjectPreloadCompletionDelegate;
    /// <summary>
    /// Function: ObjectPreloadCompletionDelegate
    /// </summary>
    public unsafe virtual void ObjectPreloadCompletionDelegate(BmSDK.Engine.MObjectStreaming.EStreamingResult Result, BmSDK.GameObject StreamedObject, BmSDK.Engine.MObjectStreaming.FObjectStreamingId Id, BmSDK.FString PackageName, BmSDK.FString ObjectName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ObjectPreloadCompletionDelegate, "BmGame.RGFxMovie.ObjectPreloadCompletionDelegate");
        byte* paramsPtr = stackalloc byte[112];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Result, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StreamedObject, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectName, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPreloadObject;
    /// <summary>
    /// Function: AddPreloadObject
    /// </summary>
    public unsafe virtual void AddPreloadObject(BmSDK.FString ObjectName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPreloadObject, "BmGame.RGFxMovie.AddPreloadObject");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreLoadAssetsAndInit;
    /// <summary>
    /// Function: PreLoadAssetsAndInit
    /// </summary>
    public unsafe virtual void PreLoadAssetsAndInit(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreLoadAssetsAndInit, "BmGame.RGFxMovie.PreLoadAssetsAndInit");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPC;
    /// <summary>
    /// Function: GetPC
    /// </summary>
    public unsafe override BmSDK.Engine.PlayerController GetPC()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPC, "BmGame.RGFxMovie.GetPC");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PlayerController>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetLP;
    /// <summary>
    /// Function: GetLP
    /// </summary>
    public unsafe override BmSDK.Engine.LocalPlayer GetLP()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLP, "BmGame.RGFxMovie.GetLP");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.LocalPlayer>(paramsPtr + 0);
    }

    /// <summary>
    /// Struct: FMovieStreamedPackageInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FMovieStreamedPackageInfo
    {
        /// <summary>
        /// StructProperty: StreamingId
        /// </summary>
        public unsafe BmSDK.Engine.MObjectStreaming.FObjectStreamingId StreamingId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MObjectStreaming.FObjectStreamingId>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: StreamedPackage
        /// </summary>
        public unsafe BmSDK.Package StreamedPackage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Package>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ArrayProperty: StreamedPackageObjects
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.GameObject> StreamedPackageObjects
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StrProperty: PackageName
        /// </summary>
        public unsafe BmSDK.FString PackageName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FMovieStreamedObjectInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FMovieStreamedObjectInfo
    {
        /// <summary>
        /// StructProperty: StreamingId
        /// </summary>
        public unsafe BmSDK.Engine.MObjectStreaming.FObjectStreamingId StreamingId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MObjectStreaming.FObjectStreamingId>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: StreamedObject
        /// </summary>
        public unsafe BmSDK.GameObject StreamedObject
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StrProperty: ObjectName
        /// </summary>
        public unsafe BmSDK.FString ObjectName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// ArrayProperty: WwiseAssets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkAssetPack> WwiseAssets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkAssetPack>>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// StrProperty: CurrentPackageBaseName
    /// </summary>
    public unsafe BmSDK.FString CurrentPackageBaseName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// StrProperty: CurrentStreamedName
    /// </summary>
    public unsafe BmSDK.FString CurrentStreamedName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// ObjectProperty: CurrentStreamedPicture
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D CurrentStreamedPicture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// IntProperty: iSplitscreenIndex
    /// </summary>
    public unsafe int iSplitscreenIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bHUDVisibleLast
    /// </summary>
    public unsafe bool bHUDVisibleLast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 532); }
    }

    /// <summary>
    /// BoolProperty: bVisibleFirstSet
    /// </summary>
    public unsafe bool bVisibleFirstSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 532); }
    }

    /// <summary>
    /// BoolProperty: bInputBlocked
    /// </summary>
    public unsafe bool bInputBlocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 532); }
    }

    /// <summary>
    /// BoolProperty: bMovieAudioSuppressed
    /// </summary>
    public unsafe bool bMovieAudioSuppressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 532); }
    }

    /// <summary>
    /// BoolProperty: bStorageErrorSuppressed
    /// </summary>
    public unsafe bool bStorageErrorSuppressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 532); }
    }

    /// <summary>
    /// ArrayProperty: PreloadedObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGFxMovie.FMovieStreamedObjectInfo> PreloadedObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGFxMovie.FMovieStreamedObjectInfo>>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// ArrayProperty: StreamedObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGFxMovie.FMovieStreamedObjectInfo> StreamedObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGFxMovie.FMovieStreamedObjectInfo>>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// ArrayProperty: PreloadedPackages
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGFxMovie.FMovieStreamedPackageInfo> PreloadedPackages
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGFxMovie.FMovieStreamedPackageInfo>>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// ArrayProperty: StreamedPackages
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGFxMovie.FMovieStreamedPackageInfo> StreamedPackages
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGFxMovie.FMovieStreamedPackageInfo>>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// ObjectProperty: mLocalPlayer
    /// </summary>
    public unsafe BmSDK.Engine.LocalPlayer mLocalPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LocalPlayer>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// Enum: FlashAudioChannel
    /// </summary>
    public enum FlashAudioChannel : byte
    {
        FLASH_AUDIO_CHANNEL_UI = 0,
        FLASH_AUDIO_CHANNEL_HUD = 1,
        FLASH_AUDIO_CHANNEL_MAX = 2,
    }

    /// <summary>
    /// Enum: KeyMapping
    /// </summary>
    public enum KeyMapping : byte
    {
        KeyMapping_None = 0,
        KeyMapping_START = 1,
        KeyMapping_BACK = 2,
        KeyMapping_A = 3,
        KeyMapping_B = 4,
        KeyMapping_X = 5,
        KeyMapping_Y = 6,
        KeyMapping_LB = 7,
        KeyMapping_LT = 8,
        KeyMapping_LTHUMB = 9,
        KeyMapping_RB = 10,
        KeyMapping_RT = 11,
        KeyMapping_RTHUMB = 12,
        KeyMapping_LEFT = 13,
        KeyMapping_RIGHT = 14,
        KeyMapping_UP = 15,
        KeyMapping_DOWN = 16,
        KeyMapping_L_LEFT = 17,
        KeyMapping_L_RIGHT = 18,
        KeyMapping_L_UP = 19,
        KeyMapping_L_DOWN = 20,
        KeyMapping_R_LEFT = 21,
        KeyMapping_R_RIGHT = 22,
        KeyMapping_R_UP = 23,
        KeyMapping_R_DOWN = 24,
        KeyMapping_MAX = 25,
    }
}
