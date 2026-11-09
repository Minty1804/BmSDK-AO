#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_PlaySpeechCombined<br/>
/// (size = 524)
/// (flags = 134226066)
/// </summary>
public partial class RSeqAct_PlaySpeechCombined : BmSDK.BmGame.RSeqAct_PlaySpeechBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_PlaySpeechCombined", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSeqAct_PlaySpeechCombined.
    /// </summary>
    public static RSeqAct_PlaySpeechCombined DefaultObject => (RSeqAct_PlaySpeechCombined)StaticClass().DefaultObject;

    internal RSeqAct_PlaySpeechCombined() { }

    /// <summary>
    /// Constructs a new RSeqAct_PlaySpeechCombined
    /// </summary>
    public RSeqAct_PlaySpeechCombined(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_PlaySpeechCombined Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_PlaySpeechCombined(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_PlaySpeechCombined>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_PlaySpeechCombined>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_PlaySpeechCombined>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_PlaySpeechCombined>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_PlaySpeechCombined>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_PlaySpeechCombined>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_PlaySpeechCombined>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_PlaySpeechCombined>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetObjClassVersion;
    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetObjClassVersion, "BmGame.RSeqAct_PlaySpeechCombined.GetObjClassVersion");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UnlockPlayerInCinematic;
    /// <summary>
    /// Function: UnlockPlayerInCinematic
    /// </summary>
    public unsafe virtual void UnlockPlayerInCinematic()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockPlayerInCinematic, "BmGame.RSeqAct_PlaySpeechCombined.UnlockPlayerInCinematic");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeactivateCutsceneMix;
    /// <summary>
    /// Function: DeactivateCutsceneMix
    /// </summary>
    public unsafe virtual void DeactivateCutsceneMix()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeactivateCutsceneMix, "BmGame.RSeqAct_PlaySpeechCombined.DeactivateCutsceneMix");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateCutsceneMix;
    /// <summary>
    /// Function: ActivateCutsceneMix
    /// </summary>
    public unsafe virtual void ActivateCutsceneMix()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateCutsceneMix, "BmGame.RSeqAct_PlaySpeechCombined.ActivateCutsceneMix");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivatedRadio;
    /// <summary>
    /// Function: ActivatedRadio
    /// </summary>
    public unsafe virtual void ActivatedRadio()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivatedRadio, "BmGame.RSeqAct_PlaySpeechCombined.ActivatedRadio");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeactivatedRadio;
    /// <summary>
    /// Function: DeactivatedRadio
    /// </summary>
    public unsafe virtual void DeactivatedRadio()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeactivatedRadio, "BmGame.RSeqAct_PlaySpeechCombined.DeactivatedRadio");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CueFinishedRadio;
    /// <summary>
    /// Function: CueFinishedRadio
    /// </summary>
    public unsafe virtual void CueFinishedRadio()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CueFinishedRadio, "BmGame.RSeqAct_PlaySpeechCombined.CueFinishedRadio");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CueAbortedRadio;
    /// <summary>
    /// Function: CueAbortedRadio
    /// </summary>
    public unsafe virtual void CueAbortedRadio()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CueAbortedRadio, "BmGame.RSeqAct_PlaySpeechCombined.CueAbortedRadio");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySpeechRadio;
    /// <summary>
    /// Function: PlaySpeechRadio
    /// </summary>
    public unsafe virtual void PlaySpeechRadio(BmSDK.BmGame.RPawn Speaker, BmSDK.Engine.RDialogueLine DialogueLine, bool ChangeCamera, bool LastLine, BmSDK.FName AnimationToPlay = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySpeechRadio, "BmGame.RSeqAct_PlaySpeechCombined.PlaySpeechRadio");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speaker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueLine, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChangeCamera, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LastLine, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimationToPlay, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForNewLineRadio;
    /// <summary>
    /// Function: CheckForNewLineRadio
    /// </summary>
    public unsafe virtual void CheckForNewLineRadio()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForNewLineRadio, "BmGame.RSeqAct_PlaySpeechCombined.CheckForNewLineRadio");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateRadio;
    /// <summary>
    /// Function: UpdateRadio
    /// </summary>
    public unsafe virtual void UpdateRadio(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateRadio, "BmGame.RSeqAct_PlaySpeechCombined.UpdateRadio");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryToBeginRadio;
    /// <summary>
    /// Function: TryToBeginRadio
    /// </summary>
    public unsafe virtual void TryToBeginRadio()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToBeginRadio, "BmGame.RSeqAct_PlaySpeechCombined.TryToBeginRadio");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetIsFalling;
    /// <summary>
    /// Function: SetIsFalling
    /// </summary>
    public unsafe virtual void SetIsFalling()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIsFalling, "BmGame.RSeqAct_PlaySpeechCombined.SetIsFalling");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CueFinishedCutscene;
    /// <summary>
    /// Function: CueFinishedCutscene
    /// </summary>
    public unsafe virtual bool CueFinishedCutscene()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CueFinishedCutscene, "BmGame.RSeqAct_PlaySpeechCombined.CueFinishedCutscene");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CueAbortedCutscene;
    /// <summary>
    /// Function: CueAbortedCutscene
    /// </summary>
    public unsafe virtual void CueAbortedCutscene()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CueAbortedCutscene, "BmGame.RSeqAct_PlaySpeechCombined.CueAbortedCutscene");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitSpeechCutscene;
    /// <summary>
    /// Function: ExitSpeechCutscene
    /// </summary>
    public unsafe virtual void ExitSpeechCutscene()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitSpeechCutscene, "BmGame.RSeqAct_PlaySpeechCombined.ExitSpeechCutscene");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsBatmanToStart;
    /// <summary>
    /// Function: IsBatmanToStart
    /// </summary>
    public unsafe virtual bool IsBatmanToStart()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBatmanToStart, "BmGame.RSeqAct_PlaySpeechCombined.IsBatmanToStart");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DeactivatedCutscene;
    /// <summary>
    /// Function: DeactivatedCutscene
    /// </summary>
    public unsafe virtual void DeactivatedCutscene()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeactivatedCutscene, "BmGame.RSeqAct_PlaySpeechCombined.DeactivatedCutscene");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateCutscene;
    /// <summary>
    /// Function: UpdateCutscene
    /// </summary>
    public unsafe virtual void UpdateCutscene(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCutscene, "BmGame.RSeqAct_PlaySpeechCombined.UpdateCutscene");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryToBeginCutscene;
    /// <summary>
    /// Function: TryToBeginCutscene
    /// </summary>
    public unsafe virtual void TryToBeginCutscene()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToBeginCutscene, "BmGame.RSeqAct_PlaySpeechCombined.TryToBeginCutscene");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivatedCutscene;
    /// <summary>
    /// Function: ActivatedCutscene
    /// </summary>
    public unsafe virtual void ActivatedCutscene()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivatedCutscene, "BmGame.RSeqAct_PlaySpeechCombined.ActivatedCutscene");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSingleSpeaker;
    /// <summary>
    /// Function: GetSingleSpeaker
    /// </summary>
    public unsafe virtual void GetSingleSpeaker()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSingleSpeaker, "BmGame.RSeqAct_PlaySpeechCombined.GetSingleSpeaker");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySpeechLineCutscene;
    /// <summary>
    /// Function: PlaySpeechLineCutscene
    /// </summary>
    public unsafe virtual void PlaySpeechLineCutscene()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySpeechLineCutscene, "BmGame.RSeqAct_PlaySpeechCombined.PlaySpeechLineCutscene");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySpeechCutscene;
    /// <summary>
    /// Function: PlaySpeechCutscene
    /// </summary>
    public unsafe virtual void PlaySpeechCutscene(BmSDK.BmGame.RPawn Speaker, BmSDK.Engine.RDialogueLine DialogueLine, bool ChangeCamera, bool LastLine, BmSDK.FName AnimationToPlay = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySpeechCutscene, "BmGame.RSeqAct_PlaySpeechCombined.PlaySpeechCutscene");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speaker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueLine, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChangeCamera, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LastLine, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimationToPlay, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateCamera;
    /// <summary>
    /// Function: UpdateCamera
    /// </summary>
    public unsafe virtual void UpdateCamera(BmSDK.BmGame.RPawn Speaker, bool ChangeCamera, bool newTalker, BmSDK.Engine.RDialogueLine DialogueLine)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCamera, "BmGame.RSeqAct_PlaySpeechCombined.UpdateCamera");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speaker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChangeCamera, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(newTalker, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueLine, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CameraTagOnLine;
    /// <summary>
    /// Function: CameraTagOnLine
    /// </summary>
    public unsafe virtual bool CameraTagOnLine(BmSDK.BmGame.RPawn Speaker, BmSDK.Engine.RDialogueLine DialogueLine)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CameraTagOnLine, "BmGame.RSeqAct_PlaySpeechCombined.CameraTagOnLine");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speaker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueLine, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_MakePawnsFaceTalkerCutscene;
    /// <summary>
    /// Function: MakePawnsFaceTalkerCutscene
    /// </summary>
    public unsafe virtual void MakePawnsFaceTalkerCutscene(BmSDK.Engine.RDialogueLine DialogueLine)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakePawnsFaceTalkerCutscene, "BmGame.RSeqAct_PlaySpeechCombined.MakePawnsFaceTalkerCutscene");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueLine, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TaggedLookAt;
    /// <summary>
    /// Function: TaggedLookAt
    /// </summary>
    public unsafe virtual void TaggedLookAt(BmSDK.BmGame.RPawnCharacter Looker, BmSDK.BmGame.RPawnCharacter LookerAt)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TaggedLookAt, "BmGame.RSeqAct_PlaySpeechCombined.TaggedLookAt");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Looker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookerAt, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AnimationTriggerCallbackCutscene;
    /// <summary>
    /// Function: AnimationTriggerCallbackCutscene
    /// </summary>
    public unsafe virtual void AnimationTriggerCallbackCutscene(BmSDK.FName TagName, BmSDK.TArray<BmSDK.FString> Params, BmSDK.Engine.AnimSet TagAnimSet, float Time)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnimationTriggerCallbackCutscene, "BmGame.RSeqAct_PlaySpeechCombined.AnimationTriggerCallbackCutscene");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TagName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Params, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TagAnimSet, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForNewLineCutscene;
    /// <summary>
    /// Function: CheckForNewLineCutscene
    /// </summary>
    public unsafe virtual void CheckForNewLineCutscene()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForNewLineCutscene, "BmGame.RSeqAct_PlaySpeechCombined.CheckForNewLineCutscene");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSpeakingTo;
    /// <summary>
    /// Function: GetSpeakingTo
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCharacter GetSpeakingTo(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSpeakingTo, "BmGame.RSeqAct_PlaySpeechCombined.GetSpeakingTo");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCharacter>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetSpeakerFromString;
    /// <summary>
    /// Function: GetSpeakerFromString
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCharacter GetSpeakerFromString(BmSDK.FString ScriptName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSpeakerFromString, "BmGame.RSeqAct_PlaySpeechCombined.GetSpeakerFromString");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScriptName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCharacter>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetSpeakerFromName;
    /// <summary>
    /// Function: GetSpeakerFromName
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCharacter GetSpeakerFromName(BmSDK.FName ScriptName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSpeakerFromName, "BmGame.RSeqAct_PlaySpeechCombined.GetSpeakerFromName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScriptName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCharacter>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_LookAtTagOnLine;
    /// <summary>
    /// Function: LookAtTagOnLine
    /// </summary>
    public unsafe virtual bool LookAtTagOnLine(BmSDK.BmGame.RPawnCharacter Looker, BmSDK.FName CharName, BmSDK.Engine.RDialogueLine SpeechToPlay)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LookAtTagOnLine, "BmGame.RSeqAct_PlaySpeechCombined.LookAtTagOnLine");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Looker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpeechToPlay, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CheckName;
    /// <summary>
    /// Function: CheckName
    /// </summary>
    public unsafe virtual bool CheckName(BmSDK.FString NameCheck)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckName, "BmGame.RSeqAct_PlaySpeechCombined.CheckName");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NameCheck, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UpdateNormalConversation;
    /// <summary>
    /// Function: UpdateNormalConversation
    /// </summary>
    public unsafe virtual void UpdateNormalConversation(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateNormalConversation, "BmGame.RSeqAct_PlaySpeechCombined.UpdateNormalConversation");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitSpeechNormalConversation;
    /// <summary>
    /// Function: ExitSpeechNormalConversation
    /// </summary>
    public unsafe virtual void ExitSpeechNormalConversation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitSpeechNormalConversation, "BmGame.RSeqAct_PlaySpeechCombined.ExitSpeechNormalConversation");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CueFinishedNormalConversation;
    /// <summary>
    /// Function: CueFinishedNormalConversation
    /// </summary>
    public unsafe virtual bool CueFinishedNormalConversation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CueFinishedNormalConversation, "BmGame.RSeqAct_PlaySpeechCombined.CueFinishedNormalConversation");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CueAbortedNormalConversation;
    /// <summary>
    /// Function: CueAbortedNormalConversation
    /// </summary>
    public unsafe virtual bool CueAbortedNormalConversation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CueAbortedNormalConversation, "BmGame.RSeqAct_PlaySpeechCombined.CueAbortedNormalConversation");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ActivatedNormalConversation;
    /// <summary>
    /// Function: ActivatedNormalConversation
    /// </summary>
    public unsafe virtual void ActivatedNormalConversation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivatedNormalConversation, "BmGame.RSeqAct_PlaySpeechCombined.ActivatedNormalConversation");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySpeechLineNormalConversation;
    /// <summary>
    /// Function: PlaySpeechLineNormalConversation
    /// </summary>
    public unsafe virtual void PlaySpeechLineNormalConversation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySpeechLineNormalConversation, "BmGame.RSeqAct_PlaySpeechCombined.PlaySpeechLineNormalConversation");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopNormalConversationLookAts;
    /// <summary>
    /// Function: StopNormalConversationLookAts
    /// </summary>
    public unsafe virtual void StopNormalConversationLookAts()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopNormalConversationLookAts, "BmGame.RSeqAct_PlaySpeechCombined.StopNormalConversationLookAts");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MakePawnsFaceTalkerNormalConversation;
    /// <summary>
    /// Function: MakePawnsFaceTalkerNormalConversation
    /// </summary>
    public unsafe virtual void MakePawnsFaceTalkerNormalConversation(BmSDK.Engine.RDialogueLine DialogueLine)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakePawnsFaceTalkerNormalConversation, "BmGame.RSeqAct_PlaySpeechCombined.MakePawnsFaceTalkerNormalConversation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueLine, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInConversation;
    /// <summary>
    /// Function: SetInConversation
    /// </summary>
    public unsafe virtual void SetInConversation(bool InConversation, BmSDK.TArray<BmSDK.BmGame.RPawn> Pawns)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInConversation, "BmGame.RSeqAct_PlaySpeechCombined.SetInConversation");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InConversation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawns, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSpeakerList;
    /// <summary>
    /// Function: GetSpeakerList
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RSeqAct_PlaySpeechCombined.FBM2CharList GetSpeakerList(BmSDK.FName ScriptName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSpeakerList, "BmGame.RSeqAct_PlaySpeechCombined.GetSpeakerList");
        byte* paramsPtr = stackalloc byte[132];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScriptName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSeqAct_PlaySpeechCombined.FBM2CharList>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AnimationTriggerCallbackNormalConversation;
    /// <summary>
    /// Function: AnimationTriggerCallbackNormalConversation
    /// </summary>
    public unsafe virtual void AnimationTriggerCallbackNormalConversation(BmSDK.FName TagName, BmSDK.TArray<BmSDK.FString> Params, BmSDK.Engine.AnimSet TagAnimSet, float Time)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnimationTriggerCallbackNormalConversation, "BmGame.RSeqAct_PlaySpeechCombined.AnimationTriggerCallbackNormalConversation");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TagName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Params, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TagAnimSet, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForNewLineNormalConversation;
    /// <summary>
    /// Function: CheckForNewLineNormalConversation
    /// </summary>
    public unsafe virtual void CheckForNewLineNormalConversation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForNewLineNormalConversation, "BmGame.RSeqAct_PlaySpeechCombined.CheckForNewLineNormalConversation");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSpeakerNormalSingleLine;
    /// <summary>
    /// Function: GetSpeakerNormalSingleLine
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCharacter GetSpeakerNormalSingleLine(BmSDK.FName SpeakersName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSpeakerNormalSingleLine, "BmGame.RSeqAct_PlaySpeechCombined.GetSpeakerNormalSingleLine");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpeakersName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCharacter>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CueAbortedNormalSingleLine;
    /// <summary>
    /// Function: CueAbortedNormalSingleLine
    /// </summary>
    public unsafe virtual void CueAbortedNormalSingleLine()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CueAbortedNormalSingleLine, "BmGame.RSeqAct_PlaySpeechCombined.CueAbortedNormalSingleLine");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeactivatedNormalSingleLine;
    /// <summary>
    /// Function: DeactivatedNormalSingleLine
    /// </summary>
    public unsafe virtual void DeactivatedNormalSingleLine()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeactivatedNormalSingleLine, "BmGame.RSeqAct_PlaySpeechCombined.DeactivatedNormalSingleLine");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivatedNormalSingleLine;
    /// <summary>
    /// Function: ActivatedNormalSingleLine
    /// </summary>
    public unsafe virtual void ActivatedNormalSingleLine()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivatedNormalSingleLine, "BmGame.RSeqAct_PlaySpeechCombined.ActivatedNormalSingleLine");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateNormalSingleLine;
    /// <summary>
    /// Function: UpdateNormalSingleLine
    /// </summary>
    public unsafe virtual void UpdateNormalSingleLine(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateNormalSingleLine, "BmGame.RSeqAct_PlaySpeechCombined.UpdateNormalSingleLine");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetVariableLinkType;
    /// <summary>
    /// Function: SetVariableLinkType
    /// </summary>
    public unsafe virtual void SetVariableLinkType(int I)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVariableLinkType, "BmGame.RSeqAct_PlaySpeechCombined.SetVariableLinkType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(I, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySpeech;
    /// <summary>
    /// Function: PlaySpeech
    /// </summary>
    public unsafe virtual void PlaySpeech(BmSDK.BmGame.RPawn Speaker, BmSDK.Engine.RDialogueLine DialogueLine, bool ChangeCamera, bool LastLine, BmSDK.FName AnimationToPlay = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySpeech, "BmGame.RSeqAct_PlaySpeechCombined.PlaySpeech");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speaker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueLine, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChangeCamera, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LastLine, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimationToPlay, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitSpeech;
    /// <summary>
    /// Function: ExitSpeech
    /// </summary>
    public unsafe override void ExitSpeech()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitSpeech, "BmGame.RSeqAct_PlaySpeechCombined.ExitSpeech");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MakePawnsFaceTalker;
    /// <summary>
    /// Function: MakePawnsFaceTalker
    /// </summary>
    public unsafe virtual void MakePawnsFaceTalker(BmSDK.Engine.RDialogueLine DialogueLine)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakePawnsFaceTalker, "BmGame.RSeqAct_PlaySpeechCombined.MakePawnsFaceTalker");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueLine, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySpeechLine;
    /// <summary>
    /// Function: PlaySpeechLine
    /// </summary>
    public unsafe virtual void PlaySpeechLine()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySpeechLine, "BmGame.RSeqAct_PlaySpeechCombined.PlaySpeechLine");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AnimationTriggerCallback;
    /// <summary>
    /// Function: AnimationTriggerCallback
    /// </summary>
    public unsafe override void AnimationTriggerCallback(BmSDK.FName TagName, BmSDK.TArray<BmSDK.FString> Params, BmSDK.Engine.AnimSet TagAnimSet, float Time)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnimationTriggerCallback, "BmGame.RSeqAct_PlaySpeechCombined.AnimationTriggerCallback");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TagName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Params, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TagAnimSet, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForNewLine;
    /// <summary>
    /// Function: CheckForNewLine
    /// </summary>
    public unsafe virtual void CheckForNewLine()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForNewLine, "BmGame.RSeqAct_PlaySpeechCombined.CheckForNewLine");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryToBegin;
    /// <summary>
    /// Function: TryToBegin
    /// </summary>
    public unsafe virtual void TryToBegin()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToBegin, "BmGame.RSeqAct_PlaySpeechCombined.TryToBegin");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSpeaker;
    /// <summary>
    /// Function: GetSpeaker
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCharacter GetSpeaker(BmSDK.FName SpeakersName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSpeaker, "BmGame.RSeqAct_PlaySpeechCombined.GetSpeaker");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpeakersName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCharacter>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CueFinished;
    /// <summary>
    /// Function: CueFinished
    /// </summary>
    public unsafe override void CueFinished()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CueFinished, "BmGame.RSeqAct_PlaySpeechCombined.CueFinished");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CueAborted;
    /// <summary>
    /// Function: CueAborted
    /// </summary>
    public unsafe override void CueAborted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CueAborted, "BmGame.RSeqAct_PlaySpeechCombined.CueAborted");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Deactivated;
    /// <summary>
    /// Function: Deactivated
    /// </summary>
    public unsafe override void Deactivated()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Deactivated, "BmGame.RSeqAct_PlaySpeechCombined.Deactivated");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Activated;
    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe override void Activated()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Activated, "BmGame.RSeqAct_PlaySpeechCombined.Activated");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivatedFromDialogueManager;
    /// <summary>
    /// Function: ActivatedFromDialogueManager
    /// </summary>
    public unsafe override void ActivatedFromDialogueManager()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivatedFromDialogueManager, "BmGame.RSeqAct_PlaySpeechCombined.ActivatedFromDialogueManager");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SuspendStasis;
    /// <summary>
    /// Function: SuspendStasis
    /// </summary>
    public unsafe virtual void SuspendStasis(bool bSuspendStasis)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuspendStasis, "BmGame.RSeqAct_PlaySpeechCombined.SuspendStasis");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSuspendStasis, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPlayerInDialogue;
    /// <summary>
    /// Function: SetPlayerInDialogue
    /// </summary>
    public unsafe virtual void SetPlayerInDialogue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPlayerInDialogue, "BmGame.RSeqAct_PlaySpeechCombined.SetPlayerInDialogue");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPlayerOutOfDialogue;
    /// <summary>
    /// Function: SetPlayerOutOfDialogue
    /// </summary>
    public unsafe virtual void SetPlayerOutOfDialogue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPlayerOutOfDialogue, "BmGame.RSeqAct_PlaySpeechCombined.SetPlayerOutOfDialogue");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Update;
    /// <summary>
    /// Function: Update
    /// </summary>
    public unsafe override bool Update(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Update, "BmGame.RSeqAct_PlaySpeechCombined.Update");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsDialogueSkippable;
    /// <summary>
    /// Function: IsDialogueSkippable
    /// </summary>
    public unsafe virtual bool IsDialogueSkippable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDialogueSkippable, "BmGame.RSeqAct_PlaySpeechCombined.IsDialogueSkippable");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NoSkipTagOnLine;
    /// <summary>
    /// Function: NoSkipTagOnLine
    /// </summary>
    public unsafe virtual bool NoSkipTagOnLine()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NoSkipTagOnLine, "BmGame.RSeqAct_PlaySpeechCombined.NoSkipTagOnLine");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsRadioOrThought;
    /// <summary>
    /// Function: IsRadioOrThought
    /// </summary>
    public unsafe virtual bool IsRadioOrThought()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRadioOrThought, "BmGame.RSeqAct_PlaySpeechCombined.IsRadioOrThought");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayEarcon;
    /// <summary>
    /// Function: PlayEarcon
    /// </summary>
    public unsafe virtual void PlayEarcon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayEarcon, "BmGame.RSeqAct_PlaySpeechCombined.PlayEarcon");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsThisGoingToPlay;
    /// <summary>
    /// Function: IsThisGoingToPlay
    /// </summary>
    public unsafe virtual bool IsThisGoingToPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsThisGoingToPlay, "BmGame.RSeqAct_PlaySpeechCombined.IsThisGoingToPlay");
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

    private static BmSDK.Function __fn_RegisterSpeechWithDialogueManager;
    /// <summary>
    /// Function: RegisterSpeechWithDialogueManager
    /// </summary>
    public unsafe virtual void RegisterSpeechWithDialogueManager(BmSDK.TArray<BmSDK.BmGame.RPawn> Pawns)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterSpeechWithDialogueManager, "BmGame.RSeqAct_PlaySpeechCombined.RegisterSpeechWithDialogueManager");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawns, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UnregisterSpeechWithDialogueManager;
    /// <summary>
    /// Function: UnregisterSpeechWithDialogueManager
    /// </summary>
    public unsafe virtual void UnregisterSpeechWithDialogueManager(bool bDestroy)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnregisterSpeechWithDialogueManager, "BmGame.RSeqAct_PlaySpeechCombined.UnregisterSpeechWithDialogueManager");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDestroy, paramsPtr + 0);
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

    private static BmSDK.Function __fn_CPPActivatedFromDialogue;
    /// <summary>
    /// Function: CPPActivatedFromDialogue
    /// </summary>
    public unsafe virtual void CPPActivatedFromDialogue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CPPActivatedFromDialogue, "BmGame.RSeqAct_PlaySpeechCombined.CPPActivatedFromDialogue");
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

    private static BmSDK.Function __fn_MarkDirty;
    /// <summary>
    /// Function: MarkDirty
    /// </summary>
    public unsafe virtual void MarkDirty()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MarkDirty, "BmGame.RSeqAct_PlaySpeechCombined.MarkDirty");
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

    private static BmSDK.Function __fn_ReBuildScriptNames;
    /// <summary>
    /// Function: ReBuildScriptNames
    /// </summary>
    public unsafe virtual void ReBuildScriptNames()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReBuildScriptNames, "BmGame.RSeqAct_PlaySpeechCombined.ReBuildScriptNames");
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

    /// <summary>
    /// Struct: FThoughtParams
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FThoughtParams
    {
        /// <summary>
        /// ByteProperty: MinimumHelpLevel
        /// </summary>
        public unsafe BmSDK.BmGame.RPersistentOptions.HelpTextLevel MinimumHelpLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.HelpTextLevel>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: HelpTextExit
        /// </summary>
        public unsafe bool HelpTextExit
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: Padding
        /// </summary>
        public unsafe int Padding
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FRadioParams
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FRadioParams
    {
        /// <summary>
        /// BoolProperty: bLastLineIsIncedental
        /// </summary>
        public unsafe bool bLastLineIsIncedental
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bBatmanFreeToMoveAbout
        /// </summary>
        public unsafe bool bBatmanFreeToMoveAbout
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: BroadcastRadioName
        /// </summary>
        public unsafe BmSDK.FString BroadcastRadioName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bAllowPersistentLevelChange
        /// </summary>
        public unsafe bool bAllowPersistentLevelChange
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FCutsceneParams
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial record struct FCutsceneParams
    {
        /// <summary>
        /// ObjectProperty: BatsFirstPosition
        /// </summary>
        public unsafe BmSDK.Engine.Actor BatsFirstPosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bBatsPosIsAbsolute
        /// </summary>
        public unsafe bool bBatsPosIsAbsolute
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// ArrayProperty: NPCFirstPosition
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.Actor> NPCFirstPosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: BatsFirstCamera
        /// </summary>
        public unsafe BmSDK.BmGame.RCinematicCameraActor BatsFirstCamera
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCinematicCameraActor>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: BatsDistance
        /// </summary>
        public unsafe float BatsDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// BoolProperty: bCopyCamerasFromClipboard
        /// </summary>
        public unsafe bool bCopyCamerasFromClipboard
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: HoldCameraTime
        /// </summary>
        public unsafe float HoldCameraTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: bForceBlendBackFinalCam
        /// </summary>
        public unsafe bool bForceBlendBackFinalCam
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: bLeavePlayerLockedOnExit
        /// </summary>
        public unsafe bool bLeavePlayerLockedOnExit
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }

        /// <summary>
        /// ObjectProperty: NPCAnimSet
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet NPCAnimSet
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// ObjectProperty: BMAnimSet
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet BMAnimSet
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// BoolProperty: bForceCameraResetAfterCutscene
        /// </summary>
        public unsafe bool bForceCameraResetAfterCutscene
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: CutsceneFOV
        /// </summary>
        public unsafe float CutsceneFOV
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }
    }

    /// <summary>
    /// Struct: FBM2CharList
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial record struct FBM2CharList
    {
        /// <summary>
        /// ArrayProperty: PawnCharacter
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.Actor> PawnCharacter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: CharacterActive
        /// </summary>
        public unsafe BmSDK.TArray<bool> CharacterActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<bool>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ArrayProperty: DistanceToPlayer
        /// </summary>
        public unsafe BmSDK.TArray<float> DistanceToPlayer
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ArrayProperty: Closest
        /// </summary>
        public unsafe BmSDK.TArray<bool> Closest
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<bool>>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }
    }

    /// <summary>
    /// Struct: FNormalConversationParams
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial record struct FNormalConversationParams
    {
        /// <summary>
        /// BoolProperty: bUseAiming
        /// </summary>
        public unsafe bool bUseAiming
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FNormalParams
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial record struct FNormalParams
    {
        /// <summary>
        /// BoolProperty: bInterruptCurrentSpeech
        /// </summary>
        public unsafe bool bInterruptCurrentSpeech
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bBatmanShouldFace
        /// </summary>
        public unsafe bool bBatmanShouldFace
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FOverrideLineData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FOverrideLineData
    {
        /// <summary>
        /// IntProperty: LineToInterrupt
        /// </summary>
        public unsafe int LineToInterrupt
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: Line
        /// </summary>
        public unsafe BmSDK.Engine.RDialogueLine Line
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: SingleDialogueLine
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine SingleDialogueLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ObjectProperty: Conversation
    /// </summary>
    public unsafe BmSDK.BmGame.RScriptConversation Conversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RScriptConversation>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// ArrayProperty: ScriptName_Clients
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> ScriptName_Clients
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// IntProperty: CurrentSpeechIndex
    /// </summary>
    public unsafe int CurrentSpeechIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: bLineWaiting
    /// </summary>
    public unsafe bool bLineWaiting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }

    /// <summary>
    /// BoolProperty: bCutRequested
    /// </summary>
    public unsafe bool bCutRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }

    /// <summary>
    /// BoolProperty: bHasSilentNPCLink
    /// </summary>
    public unsafe bool bHasSilentNPCLink
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }

    /// <summary>
    /// BoolProperty: bInvolvesBatman
    /// </summary>
    public unsafe bool bInvolvesBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }

    /// <summary>
    /// BoolProperty: FindClosestInArray
    /// </summary>
    public unsafe bool FindClosestInArray
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }

    /// <summary>
    /// BoolProperty: DialogueTriggersOnce
    /// </summary>
    public unsafe bool DialogueTriggersOnce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }

    /// <summary>
    /// BoolProperty: DoNotRepeat
    /// </summary>
    public unsafe bool DoNotRepeat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }

    /// <summary>
    /// BoolProperty: DoNotPlayRadioStartBlip
    /// </summary>
    public unsafe bool DoNotPlayRadioStartBlip
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }

    /// <summary>
    /// BoolProperty: DoNotPlayRadioEndBlip
    /// </summary>
    public unsafe bool DoNotPlayRadioEndBlip
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }

    /// <summary>
    /// BoolProperty: UseExternalPackageForLine
    /// </summary>
    public unsafe bool UseExternalPackageForLine
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }

    /// <summary>
    /// BoolProperty: bPlayEarcon
    /// </summary>
    public unsafe bool bPlayEarcon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }

    /// <summary>
    /// BoolProperty: bRegisteredConversation
    /// </summary>
    public unsafe bool bRegisteredConversation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }

    /// <summary>
    /// BoolProperty: bAborting
    /// </summary>
    public unsafe bool bAborting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreFinish
    /// </summary>
    public unsafe bool bIgnoreFinish
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }

    /// <summary>
    /// BoolProperty: bSingleLineIsBatman
    /// </summary>
    public unsafe bool bSingleLineIsBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }

    /// <summary>
    /// BoolProperty: DontLockInput
    /// </summary>
    public unsafe bool DontLockInput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }

    /// <summary>
    /// BoolProperty: bIsInIncedentalLine
    /// </summary>
    public unsafe bool bIsInIncedentalLine
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }

    /// <summary>
    /// BoolProperty: bIsThought
    /// </summary>
    public unsafe bool bIsThought
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }

    /// <summary>
    /// BoolProperty: bPlayerDamaged
    /// </summary>
    public unsafe bool bPlayerDamaged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }

    /// <summary>
    /// BoolProperty: bInKillZone
    /// </summary>
    public unsafe bool bInKillZone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }

    /// <summary>
    /// BoolProperty: bDied
    /// </summary>
    public unsafe bool bDied
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }

    /// <summary>
    /// BoolProperty: bSpeechAborting
    /// </summary>
    public unsafe bool bSpeechAborting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }

    /// <summary>
    /// BoolProperty: bRadioStarted
    /// </summary>
    public unsafe bool bRadioStarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }

    /// <summary>
    /// BoolProperty: LockedPlayerInCinematic
    /// </summary>
    public unsafe bool LockedPlayerInCinematic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }

    /// <summary>
    /// BoolProperty: DoNotOutputLogWarnings
    /// </summary>
    public unsafe bool DoNotOutputLogWarnings
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }

    /// <summary>
    /// FloatProperty: DelayTimer
    /// </summary>
    public unsafe float DelayTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// StrProperty: InterrogationSpeakerOverride
    /// </summary>
    public unsafe BmSDK.FString InterrogationSpeakerOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// FloatProperty: CutTimer
    /// </summary>
    public unsafe float CutTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// ObjectProperty: PC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController PC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// ArrayProperty: SilentNPCs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> SilentNPCs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// ArrayProperty: Cameras
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSeqAct_PlaySpeechCombined.FCameraLocation> Cameras
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSeqAct_PlaySpeechCombined.FCameraLocation>>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// ArrayProperty: TagCameras
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSeqAct_PlaySpeechCombined.FCameraLocation> TagCameras
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSeqAct_PlaySpeechCombined.FCameraLocation>>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// StrProperty: ConversationTriggeredFlagName
    /// </summary>
    public unsafe BmSDK.FString ConversationTriggeredFlagName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// ArrayProperty: OverrideLines
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSeqAct_PlaySpeechCombined.FOverrideLineData> OverrideLines
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSeqAct_PlaySpeechCombined.FOverrideLineData>>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// StructProperty: NormalParameters
    /// </summary>
    public unsafe ref BmSDK.BmGame.RSeqAct_PlaySpeechCombined.FNormalParams NormalParameters
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RSeqAct_PlaySpeechCombined.FNormalParams>(Ptr + 372);

    /// <summary>
    /// ArrayProperty: Talk_To_Pawns
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSeqAct_PlaySpeechCombined.FBM2CharList> Talk_To_Pawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSeqAct_PlaySpeechCombined.FBM2CharList>>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// StructProperty: NormalConversationParameters
    /// </summary>
    public unsafe ref BmSDK.BmGame.RSeqAct_PlaySpeechCombined.FNormalConversationParams NormalConversationParameters
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RSeqAct_PlaySpeechCombined.FNormalConversationParams>(Ptr + 388);

    /// <summary>
    /// IntProperty: IgnoreAborts
    /// </summary>
    public unsafe int IgnoreAborts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// ObjectProperty: TalkingPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat TalkingPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// IntProperty: AdditionalVariableLinks
    /// </summary>
    public unsafe int AdditionalVariableLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// FloatProperty: TimeElapsedInConv
    /// </summary>
    public unsafe float TimeElapsedInConv
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// StructProperty: CutsceneParameters
    /// </summary>
    public unsafe ref BmSDK.BmGame.RSeqAct_PlaySpeechCombined.FCutsceneParams CutsceneParameters
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RSeqAct_PlaySpeechCombined.FCutsceneParams>(Ptr + 408);

    /// <summary>
    /// IntProperty: WaitForBeginFrames
    /// </summary>
    public unsafe int WaitForBeginFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// IntProperty: CurrentTagOutputLink
    /// </summary>
    public unsafe int CurrentTagOutputLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// ArrayProperty: NPCSpeechBehaviour
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMBehaviour_Conversation> NPCSpeechBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMBehaviour_Conversation>>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// ObjectProperty: SingleSpeakerTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor SingleSpeakerTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// ObjectProperty: InterrogationTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor InterrogationTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// StructProperty: RadioParameters
    /// </summary>
    public unsafe ref BmSDK.BmGame.RSeqAct_PlaySpeechCombined.FRadioParams RadioParameters
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RSeqAct_PlaySpeechCombined.FRadioParams>(Ptr + 492);

    /// <summary>
    /// StructProperty: ThoughtParameters
    /// </summary>
    public unsafe ref BmSDK.BmGame.RSeqAct_PlaySpeechCombined.FThoughtParams ThoughtParameters
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RSeqAct_PlaySpeechCombined.FThoughtParams>(Ptr + 512);

    /// <summary>
    /// Struct: FCameraLocation
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FCameraLocation
    {
        /// <summary>
        /// StructProperty: Location
        /// </summary>
        public unsafe System.Numerics.Vector3 Location
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Rotation
        /// </summary>
        public unsafe BmSDK.Rotator Rotation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: FOV
        /// </summary>
        public unsafe int FOV
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// BoolProperty: bActive
        /// </summary>
        public unsafe bool bActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: bNewSystem
        /// </summary>
        public unsafe bool bNewSystem
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: bDisableDoF
        /// </summary>
        public unsafe bool bDisableDoF
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }
    }
}
