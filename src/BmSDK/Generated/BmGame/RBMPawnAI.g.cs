#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RBMPawnAI<br/>
/// (size = 3320)
/// (flags = 144703671)
/// </summary>
public partial class RBMPawnAI : BmSDK.BmGame.RBMPawnAIAnim, BmSDK.Engine.Interface_NavigationHandle, BmSDK.BmGame.MGlitchesInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMPawnAI", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMPawnAI.
    /// </summary>
    public static RBMPawnAI DefaultObject => (RBMPawnAI)StaticClass().DefaultObject;

    internal RBMPawnAI() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMPawnAI(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_NavigationCanDoHighJump;
    /// <summary>
    /// Function: NavigationCanDoHighJump
    /// </summary>
    public unsafe virtual bool NavigationCanDoHighJump()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NavigationCanDoHighJump, "BmGame.RBMPawnAI.NavigationCanDoHighJump");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NavigationCanDoTraversal;
    /// <summary>
    /// Function: NavigationCanDoTraversal
    /// </summary>
    public unsafe virtual bool NavigationCanDoTraversal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NavigationCanDoTraversal, "BmGame.RBMPawnAI.NavigationCanDoTraversal");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopBreathFX;
    /// <summary>
    /// Function: StopBreathFX
    /// </summary>
    public unsafe virtual void StopBreathFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopBreathFX, "BmGame.RBMPawnAI.StopBreathFX");
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

    private static BmSDK.Function __fn_StartBreathFX;
    /// <summary>
    /// Function: StartBreathFX
    /// </summary>
    public unsafe virtual void StartBreathFX(BmSDK.Engine.ParticleSystem Template, BmSDK.FName Socket)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartBreathFX, "BmGame.RBMPawnAI.StartBreathFX");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Template, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Socket, paramsPtr + 4);
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

    private static BmSDK.Function __fn_PawnSawPlayer;
    /// <summary>
    /// Function: PawnSawPlayer
    /// </summary>
    public unsafe virtual void PawnSawPlayer(BmSDK.BmGame.AlertInstance.VisibilityCategory Visibility)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnSawPlayer, "BmGame.RBMPawnAI.PawnSawPlayer");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Visibility, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RBMPawnAI.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayAkEvent;
    /// <summary>
    /// Function: PlayAkEvent
    /// </summary>
    public unsafe virtual void PlayAkEvent(BmSDK.Engine.AkEvent SoundEvent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayAkEvent, "BmGame.RBMPawnAI.PlayAkEvent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundEvent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddBasicAnimSets;
    /// <summary>
    /// Function: AddBasicAnimSets
    /// </summary>
    public unsafe virtual void AddBasicAnimSets(out BmSDK.TArray<BmSDK.Engine.AnimSet> AnimSets)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddBasicAnimSets, "BmGame.RBMPawnAI.AddBasicAnimSets");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AnimSets = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.AnimSet>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_CanSeeTargetCombatPawn;
    /// <summary>
    /// Function: CanSeeTargetCombatPawn
    /// </summary>
    public unsafe virtual bool CanSeeTargetCombatPawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSeeTargetCombatPawn, "BmGame.RBMPawnAI.CanSeeTargetCombatPawn");
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

    private static BmSDK.Function __fn_CheckForAllSecretsFoundOrPlayerChange;
    /// <summary>
    /// Function: CheckForAllSecretsFoundOrPlayerChange
    /// </summary>
    public unsafe virtual void CheckForAllSecretsFoundOrPlayerChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForAllSecretsFoundOrPlayerChange, "BmGame.RBMPawnAI.CheckForAllSecretsFoundOrPlayerChange");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForAutoInformantScan;
    /// <summary>
    /// Function: CheckForAutoInformantScan
    /// </summary>
    public unsafe virtual void CheckForAutoInformantScan()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForAutoInformantScan, "BmGame.RBMPawnAI.CheckForAutoInformantScan");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetInterrogationTrack;
    /// <summary>
    /// Function: GetInterrogationTrack
    /// </summary>
    public unsafe virtual int GetInterrogationTrack(BmSDK.FString InterrogationTrackName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInterrogationTrack, "BmGame.RBMPawnAI.GetInterrogationTrack");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterrogationTrackName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_InitialiseInterrogation;
    /// <summary>
    /// Function: InitialiseInterrogation
    /// </summary>
    public unsafe virtual bool InitialiseInterrogation(BmSDK.BmGame.RSeqEvent_StartInterrogation InterrogEvent, BmSDK.BmGame.RSeqAct_PlaySpeechCombined SpeechAction, BmSDK.FString InterrogationName, BmSDK.FString InterrogationNameNoneLeft, bool _bCanInterrogateFromFront)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialiseInterrogation, "BmGame.RBMPawnAI.InitialiseInterrogation");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterrogEvent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpeechAction, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterrogationName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterrogationNameNoneLeft, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_bCanInterrogateFromFront, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_IsInterrogationUnlocked;
    /// <summary>
    /// Function: IsInterrogationUnlocked
    /// </summary>
    public unsafe virtual bool IsInterrogationUnlocked()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInterrogationUnlocked, "BmGame.RBMPawnAI.IsInterrogationUnlocked");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetInterrogatable;
    /// <summary>
    /// Function: SetInterrogatable
    /// </summary>
    public unsafe virtual void SetInterrogatable(bool bNewValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInterrogatable, "BmGame.RBMPawnAI.SetInterrogatable");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPotentiallyInterrogatable;
    /// <summary>
    /// Function: IsPotentiallyInterrogatable
    /// </summary>
    public unsafe virtual bool IsPotentiallyInterrogatable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPotentiallyInterrogatable, "BmGame.RBMPawnAI.IsPotentiallyInterrogatable");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_MarkInterrogatable;
    /// <summary>
    /// Function: MarkInterrogatable
    /// </summary>
    public unsafe virtual void MarkInterrogatable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MarkInterrogatable, "BmGame.RBMPawnAI.MarkInterrogatable");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDefaultHighlight;
    /// <summary>
    /// Function: SetDefaultHighlight
    /// </summary>
    public unsafe virtual void SetDefaultHighlight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDefaultHighlight, "BmGame.RBMPawnAI.SetDefaultHighlight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCharacterHighlightText;
    /// <summary>
    /// Function: GetCharacterHighlightText
    /// </summary>
    public unsafe virtual BmSDK.FString GetCharacterHighlightText(BmSDK.BmGame.RBMPawnAI.ECharacterHighlightType Highlight)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCharacterHighlightText, "BmGame.RBMPawnAI.GetCharacterHighlightText");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Highlight, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_RemoveAuraColor;
    /// <summary>
    /// Function: RemoveAuraColor
    /// </summary>
    public unsafe virtual void RemoveAuraColor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveAuraColor, "BmGame.RBMPawnAI.RemoveAuraColor");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyAuraColor;
    /// <summary>
    /// Function: ApplyAuraColor
    /// </summary>
    public unsafe virtual void ApplyAuraColor(BmSDK.GameObject.FLinearColor AuraCol)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyAuraColor, "BmGame.RBMPawnAI.ApplyAuraColor");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AuraCol, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateAuraColor;
    /// <summary>
    /// Function: ActivateAuraColor
    /// </summary>
    public unsafe virtual void ActivateAuraColor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateAuraColor, "BmGame.RBMPawnAI.ActivateAuraColor");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveMultiplayerAura;
    /// <summary>
    /// Function: RemoveMultiplayerAura
    /// </summary>
    public unsafe override void RemoveMultiplayerAura()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveMultiplayerAura, "BmGame.RBMPawnAI.RemoveMultiplayerAura");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateMultiplayerAura;
    /// <summary>
    /// Function: ActivateMultiplayerAura
    /// </summary>
    public unsafe override void ActivateMultiplayerAura(BmSDK.Engine.MaterialInterface AuraMat)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateMultiplayerAura, "BmGame.RBMPawnAI.ActivateMultiplayerAura");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AuraMat, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCharacterHighlightColor;
    /// <summary>
    /// Function: GetCharacterHighlightColor
    /// </summary>
    public unsafe virtual BmSDK.GameObject.FLinearColor GetCharacterHighlightColor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCharacterHighlightColor, "BmGame.RBMPawnAI.GetCharacterHighlightColor");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FLinearColor>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCharacterHighlightMaterial;
    /// <summary>
    /// Function: GetCharacterHighlightMaterial
    /// </summary>
    public unsafe virtual BmSDK.Engine.MaterialInstanceConstant GetCharacterHighlightMaterial(BmSDK.BmGame.RBMPawnAI.ECharacterHighlightType Highlight)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCharacterHighlightMaterial, "BmGame.RBMPawnAI.GetCharacterHighlightMaterial");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Highlight, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.MaterialInstanceConstant>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_FindLineByName;
    /// <summary>
    /// Function: FindLineByName
    /// </summary>
    public unsafe virtual BmSDK.Engine.RDialogueLine FindLineByName(BmSDK.FName SearchName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindLineByName, "BmGame.RBMPawnAI.FindLineByName");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.RDialogueLine>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_RemotePlayBark;
    /// <summary>
    /// Function: RemotePlayBark
    /// </summary>
    public unsafe virtual void RemotePlayBark(BmSDK.FName BarkName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemotePlayBark, "BmGame.RBMPawnAI.RemotePlayBark");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NetPlayBark;
    /// <summary>
    /// Function: NetPlayBark
    /// </summary>
    public unsafe virtual bool NetPlayBark(BmSDK.Engine.RDialogueLine DialogueLine)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NetPlayBark, "BmGame.RBMPawnAI.NetPlayBark");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueLine, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_StopBleep;
    /// <summary>
    /// Function: StopBleep
    /// </summary>
    public unsafe virtual void StopBleep()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopBleep, "BmGame.RBMPawnAI.StopBleep");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartBleep;
    /// <summary>
    /// Function: StartBleep
    /// </summary>
    public unsafe virtual void StartBleep()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartBleep, "BmGame.RBMPawnAI.StartBleep");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopKicking;
    /// <summary>
    /// Function: StopKicking
    /// </summary>
    public unsafe virtual void StopKicking()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopKicking, "BmGame.RBMPawnAI.StopKicking");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsRagdollAtRest;
    /// <summary>
    /// Function: IsRagdollAtRest
    /// </summary>
    public unsafe virtual bool IsRagdollAtRest()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRagdollAtRest, "BmGame.RBMPawnAI.IsRagdollAtRest");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ReadyForCombat;
    /// <summary>
    /// Function: ReadyForCombat
    /// </summary>
    public unsafe virtual bool ReadyForCombat()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReadyForCombat, "BmGame.RBMPawnAI.ReadyForCombat");
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

    private static BmSDK.Function __fn_OnFinishGettingUpFromRagdoll;
    /// <summary>
    /// Function: OnFinishGettingUpFromRagdoll
    /// </summary>
    public unsafe virtual void OnFinishGettingUpFromRagdoll()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFinishGettingUpFromRagdoll, "BmGame.RBMPawnAI.OnFinishGettingUpFromRagdoll");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldTriggerPredAlerts;
    /// <summary>
    /// Function: ShouldTriggerPredAlerts
    /// </summary>
    public unsafe virtual bool ShouldTriggerPredAlerts()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldTriggerPredAlerts, "BmGame.RBMPawnAI.ShouldTriggerPredAlerts");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HitWall;
    /// <summary>
    /// Function: HitWall
    /// </summary>
    public unsafe override void HitWall(System.Numerics.Vector3 HitNormal, BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent WallComp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitWall, "BmGame.RBMPawnAI.HitWall");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallComp, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCombatIdleStance;
    /// <summary>
    /// Function: SetCombatIdleStance
    /// </summary>
    public unsafe virtual void SetCombatIdleStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCombatIdleStance, "BmGame.RBMPawnAI.SetCombatIdleStance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCombatIdleStance;
    /// <summary>
    /// Function: GetCombatIdleStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetCombatIdleStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatIdleStance, "BmGame.RBMPawnAI.GetCombatIdleStance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNonFatalTakedownStunTime;
    /// <summary>
    /// Function: GetNonFatalTakedownStunTime
    /// </summary>
    public unsafe virtual float GetNonFatalTakedownStunTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNonFatalTakedownStunTime, "BmGame.RBMPawnAI.GetNonFatalTakedownStunTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNonFatalTakedownDamage;
    /// <summary>
    /// Function: GetNonFatalTakedownDamage
    /// </summary>
    public unsafe virtual float GetNonFatalTakedownDamage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNonFatalTakedownDamage, "BmGame.RBMPawnAI.GetNonFatalTakedownDamage");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AreTakedownsFatal;
    /// <summary>
    /// Function: AreTakedownsFatal
    /// </summary>
    public unsafe virtual bool AreTakedownsFatal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreTakedownsFatal, "BmGame.RBMPawnAI.AreTakedownsFatal");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AttemptTeleportToSafeLocation;
    /// <summary>
    /// Function: AttemptTeleportToSafeLocation
    /// </summary>
    public unsafe override void AttemptTeleportToSafeLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttemptTeleportToSafeLocation, "BmGame.RBMPawnAI.AttemptTeleportToSafeLocation");
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

    private static BmSDK.Function __fn_InternalSetPhysWalkingType;
    /// <summary>
    /// Function: InternalSetPhysWalkingType
    /// </summary>
    public unsafe void InternalSetPhysWalkingType(BmSDK.BmGame.RGameRI.EPhysWalkingType NewType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InternalSetPhysWalkingType, "BmGame.RBMPawnAI.InternalSetPhysWalkingType");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RevertTempPhysWalking;
    /// <summary>
    /// Function: RevertTempPhysWalking
    /// </summary>
    public unsafe virtual void RevertTempPhysWalking()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RevertTempPhysWalking, "BmGame.RBMPawnAI.RevertTempPhysWalking");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTempPhysWalking;
    /// <summary>
    /// Function: SetTempPhysWalking
    /// </summary>
    public unsafe virtual void SetTempPhysWalking(BmSDK.BmGame.RGameRI.EPhysWalkingType NewPhysWalkType, bool bNewDisableRagdollVsNavMeshConstraint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTempPhysWalking, "BmGame.RBMPawnAI.SetTempPhysWalking");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPhysWalkType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewDisableRagdollVsNavMeshConstraint, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPhysWalkingTypeAndRagdoll;
    /// <summary>
    /// Function: SetPhysWalkingTypeAndRagdoll
    /// </summary>
    public unsafe virtual void SetPhysWalkingTypeAndRagdoll(BmSDK.BmGame.RGameRI.EPhysWalkingType NewPhysWalkType, bool bNewDisableRagdollVsNavMeshConstraint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPhysWalkingTypeAndRagdoll, "BmGame.RBMPawnAI.SetPhysWalkingTypeAndRagdoll");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPhysWalkType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewDisableRagdollVsNavMeshConstraint, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPhysWalkingType;
    /// <summary>
    /// Function: SetPhysWalkingType
    /// </summary>
    public unsafe virtual void SetPhysWalkingType(BmSDK.BmGame.RGameRI.EPhysWalkingType NewPhysWalkType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPhysWalkingType, "BmGame.RBMPawnAI.SetPhysWalkingType");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPhysWalkType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnModifyHealth;
    /// <summary>
    /// Function: OnModifyHealth
    /// </summary>
    public unsafe override void OnModifyHealth(BmSDK.Engine.SeqAct_ModifyHealth Action)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnModifyHealth, "BmGame.RBMPawnAI.OnModifyHealth");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ConversationInterrupted;
    /// <summary>
    /// Function: ConversationInterrupted
    /// </summary>
    public unsafe virtual void ConversationInterrupted(BmSDK.BmGame.RBMPawnAI InterruptedSpeaker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConversationInterrupted, "BmGame.RBMPawnAI.ConversationInterrupted");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterruptedSpeaker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TauntNotify;
    /// <summary>
    /// Function: TauntNotify
    /// </summary>
    public unsafe virtual void TauntNotify(BmSDK.BmGame.RGameRI.ETauntNotifyType Type)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TauntNotify, "BmGame.RBMPawnAI.TauntNotify");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHostile;
    /// <summary>
    /// Function: SetHostile
    /// </summary>
    public unsafe virtual void SetHostile(bool bNewValue, BmSDK.FName NewNotHostileReason = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHostile, "BmGame.RBMPawnAI.SetHostile");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewNotHostileReason, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsHostile;
    /// <summary>
    /// Function: IsHostile
    /// </summary>
    public unsafe virtual bool IsHostile()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsHostile, "BmGame.RBMPawnAI.IsHostile");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_MulticastDamagedBy;
    /// <summary>
    /// Function: MulticastDamagedBy
    /// </summary>
    public unsafe virtual void MulticastDamagedBy(BmSDK.BmGame.RPawnCombat.FDamageInfo Info)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MulticastDamagedBy, "BmGame.RBMPawnAI.MulticastDamagedBy");
        byte* paramsPtr = stackalloc byte[272];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Info, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NewActionActive;
    /// <summary>
    /// Function: NewActionActive
    /// </summary>
    public unsafe virtual void NewActionActive(BmSDK.BmGame.RBMAIAction NewAction, System.Numerics.Vector3 SnapLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NewActionActive, "BmGame.RBMPawnAI.NewActionActive");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SnapLoc, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EarlyWarningOfBatarang;
    /// <summary>
    /// Function: EarlyWarningOfBatarang
    /// </summary>
    public unsafe virtual void EarlyWarningOfBatarang()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EarlyWarningOfBatarang, "BmGame.RBMPawnAI.EarlyWarningOfBatarang");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBeGlideKicked;
    /// <summary>
    /// Function: CanBeGlideKicked
    /// </summary>
    public unsafe virtual bool CanBeGlideKicked()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeGlideKicked, "BmGame.RBMPawnAI.CanBeGlideKicked");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGlideKickEffectLocation;
    /// <summary>
    /// Function: GetGlideKickEffectLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetGlideKickEffectLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGlideKickEffectLocation, "BmGame.RBMPawnAI.GetGlideKickEffectLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AdjustGlideKickZ;
    /// <summary>
    /// Function: AdjustGlideKickZ
    /// </summary>
    public unsafe virtual float AdjustGlideKickZ()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdjustGlideKickZ, "BmGame.RBMPawnAI.AdjustGlideKickZ");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopGlideKickFX;
    /// <summary>
    /// Function: StopGlideKickFX
    /// </summary>
    public unsafe virtual void StopGlideKickFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopGlideKickFX, "BmGame.RBMPawnAI.StopGlideKickFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartGlideKickFX;
    /// <summary>
    /// Function: StartGlideKickFX
    /// </summary>
    public unsafe virtual void StartGlideKickFX(BmSDK.Engine.ParticleSystem OverrideFX, BmSDK.BmGame.RPlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartGlideKickFX, "BmGame.RBMPawnAI.StartGlideKickFX");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideFX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRandomCreationVars;
    /// <summary>
    /// Function: SetRandomCreationVars
    /// </summary>
    public unsafe virtual void SetRandomCreationVars()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRandomCreationVars, "BmGame.RBMPawnAI.SetRandomCreationVars");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LockRandomCreationVars;
    /// <summary>
    /// Function: LockRandomCreationVars
    /// </summary>
    public unsafe virtual void LockRandomCreationVars(float varOne, float varTwo, float varThree, float varFour, float varFive)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LockRandomCreationVars, "BmGame.RBMPawnAI.LockRandomCreationVars");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(varOne, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(varTwo, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(varThree, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(varFour, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(varFive, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsDoingSomethingLatent;
    /// <summary>
    /// Function: IsDoingSomethingLatent
    /// </summary>
    public unsafe virtual bool IsDoingSomethingLatent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDoingSomethingLatent, "BmGame.RBMPawnAI.IsDoingSomethingLatent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GlanceHandledByCurrentAction;
    /// <summary>
    /// Function: GlanceHandledByCurrentAction
    /// </summary>
    public unsafe virtual bool GlanceHandledByCurrentAction()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GlanceHandledByCurrentAction, "BmGame.RBMPawnAI.GlanceHandledByCurrentAction");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_EndCurrentAction;
    /// <summary>
    /// Function: EndCurrentAction
    /// </summary>
    public unsafe virtual void EndCurrentAction()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndCurrentAction, "BmGame.RBMPawnAI.EndCurrentAction");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddInterrupt;
    /// <summary>
    /// Function: AddInterrupt
    /// </summary>
    public unsafe virtual void AddInterrupt(BmSDK.BmGame.RBMAIAction NewAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddInterrupt, "BmGame.RBMPawnAI.AddInterrupt");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCurrentAction;
    /// <summary>
    /// Function: GetCurrentAction
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMAIAction GetCurrentAction()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentAction, "BmGame.RBMPawnAI.GetCurrentAction");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMAIAction>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ServerTickActionQueue;
    /// <summary>
    /// Function: ServerTickActionQueue
    /// </summary>
    public unsafe virtual void ServerTickActionQueue(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerTickActionQueue, "BmGame.RBMPawnAI.ServerTickActionQueue");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsTerrifiedFXNeeded;
    /// <summary>
    /// Function: IsTerrifiedFXNeeded
    /// </summary>
    public unsafe virtual bool IsTerrifiedFXNeeded()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTerrifiedFXNeeded, "BmGame.RBMPawnAI.IsTerrifiedFXNeeded");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopTerrifiedFX;
    /// <summary>
    /// Function: StopTerrifiedFX
    /// </summary>
    public unsafe virtual void StopTerrifiedFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopTerrifiedFX, "BmGame.RBMPawnAI.StopTerrifiedFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartTerrifiedFX;
    /// <summary>
    /// Function: StartTerrifiedFX
    /// </summary>
    public unsafe virtual void StartTerrifiedFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartTerrifiedFX, "BmGame.RBMPawnAI.StartTerrifiedFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTempTerrified;
    /// <summary>
    /// Function: SetTempTerrified
    /// </summary>
    public unsafe virtual void SetTempTerrified(bool isTerrified)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTempTerrified, "BmGame.RBMPawnAI.SetTempTerrified");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(isTerrified, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KillQueue;
    /// <summary>
    /// Function: KillQueue
    /// </summary>
    public unsafe virtual void KillQueue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillQueue, "BmGame.RBMPawnAI.KillQueue");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReactivateQueue;
    /// <summary>
    /// Function: ReactivateQueue
    /// </summary>
    public unsafe virtual void ReactivateQueue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReactivateQueue, "BmGame.RBMPawnAI.ReactivateQueue");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InterruptQueue;
    /// <summary>
    /// Function: InterruptQueue
    /// </summary>
    public unsafe virtual void InterruptQueue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InterruptQueue, "BmGame.RBMPawnAI.InterruptQueue");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddToQueue;
    /// <summary>
    /// Function: AddToQueue
    /// </summary>
    public unsafe virtual void AddToQueue(BmSDK.BmGame.RBMAIAction NewAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddToQueue, "BmGame.RBMPawnAI.AddToQueue");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartNewQueue;
    /// <summary>
    /// Function: StartNewQueue
    /// </summary>
    public unsafe virtual void StartNewQueue(BmSDK.BmGame.RBMAIAction NewAction, BmSDK.BmGame.RBMAIAction.ActionExitLevel Urgency = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartNewQueue, "BmGame.RBMPawnAI.StartNewQueue");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Urgency, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RefreshActionAnimInfo;
    /// <summary>
    /// Function: RefreshActionAnimInfo
    /// </summary>
    public unsafe virtual void RefreshActionAnimInfo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RefreshActionAnimInfo, "BmGame.RBMPawnAI.RefreshActionAnimInfo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateAction;
    /// <summary>
    /// Function: ActivateAction
    /// </summary>
    public unsafe virtual void ActivateAction()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateAction, "BmGame.RBMPawnAI.ActivateAction");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResolveMovementMetaPose;
    /// <summary>
    /// Function: ResolveMovementMetaPose
    /// </summary>
    public unsafe virtual BmSDK.FName ResolveMovementMetaPose(BmSDK.FName InPose)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResolveMovementMetaPose, "BmGame.RBMPawnAI.ResolveMovementMetaPose");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPose, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ResolveWeaponMetaPose;
    /// <summary>
    /// Function: ResolveWeaponMetaPose
    /// </summary>
    public unsafe virtual BmSDK.FName ResolveWeaponMetaPose(BmSDK.FName InPose)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResolveWeaponMetaPose, "BmGame.RBMPawnAI.ResolveWeaponMetaPose");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPose, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ActionStanceUpdated;
    /// <summary>
    /// Function: ActionStanceUpdated
    /// </summary>
    public unsafe virtual void ActionStanceUpdated()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActionStanceUpdated, "BmGame.RBMPawnAI.ActionStanceUpdated");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayFenceJumpAnim;
    /// <summary>
    /// Function: PlayFenceJumpAnim
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FTransitionId PlayFenceJumpAnim(System.Numerics.Vector3 JumpLocation, float JumpYaw, BmSDK.FName JumpType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFenceJumpAnim, "BmGame.RBMPawnAI.PlayFenceJumpAnim");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JumpLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JumpYaw, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JumpType, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_PlayJumpDownLadderAnim;
    /// <summary>
    /// Function: PlayJumpDownLadderAnim
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FTransitionId PlayJumpDownLadderAnim(BmSDK.BmGame.RLadder TargetLadder)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayJumpDownLadderAnim, "BmGame.RBMPawnAI.PlayJumpDownLadderAnim");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLadder, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PlayClimbLadderAnim;
    /// <summary>
    /// Function: PlayClimbLadderAnim
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FTransitionId PlayClimbLadderAnim(BmSDK.BmGame.RLadder TargetLadder)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayClimbLadderAnim, "BmGame.RBMPawnAI.PlayClimbLadderAnim");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLadder, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetCombatWeaponStance;
    /// <summary>
    /// Function: GetCombatWeaponStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetCombatWeaponStance(bool bWeaponWillBeDropped)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatWeaponStance, "BmGame.RBMPawnAI.GetCombatWeaponStance");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWeaponWillBeDropped, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetTauntStance;
    /// <summary>
    /// Function: GetTauntStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetTauntStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTauntStance, "BmGame.RBMPawnAI.GetTauntStance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSimultaneousAttackMoveStance;
    /// <summary>
    /// Function: GetSimultaneousAttackMoveStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetSimultaneousAttackMoveStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSimultaneousAttackMoveStance, "BmGame.RBMPawnAI.GetSimultaneousAttackMoveStance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCloseAttackMoveStance;
    /// <summary>
    /// Function: GetCloseAttackMoveStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetCloseAttackMoveStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCloseAttackMoveStance, "BmGame.RBMPawnAI.GetCloseAttackMoveStance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetJoinCombatDestMoveStance;
    /// <summary>
    /// Function: GetJoinCombatDestMoveStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetJoinCombatDestMoveStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetJoinCombatDestMoveStance, "BmGame.RBMPawnAI.GetJoinCombatDestMoveStance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDisarmStance;
    /// <summary>
    /// Function: GetDisarmStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetDisarmStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisarmStance, "BmGame.RBMPawnAI.GetDisarmStance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCombatStance;
    /// <summary>
    /// Function: GetCombatStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetCombatStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatStance, "BmGame.RBMPawnAI.GetCombatStance");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCameraLookAtPriority;
    /// <summary>
    /// Function: GetCameraLookAtPriority
    /// </summary>
    public unsafe override float GetCameraLookAtPriority()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCameraLookAtPriority, "BmGame.RBMPawnAI.GetCameraLookAtPriority");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PickupGun;
    /// <summary>
    /// Function: PickupGun
    /// </summary>
    public unsafe virtual void PickupGun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PickupGun, "BmGame.RBMPawnAI.PickupGun");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DropGun;
    /// <summary>
    /// Function: DropGun
    /// </summary>
    public unsafe virtual void DropGun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DropGun, "BmGame.RBMPawnAI.DropGun");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnSetGunFiring;
    /// <summary>
    /// Function: OnSetGunFiring
    /// </summary>
    public unsafe virtual void OnSetGunFiring(BmSDK.BmGame.RSeqAct_SetGunFiring GunFireAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSetGunFiring, "BmGame.RBMPawnAI.OnSetGunFiring");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GunFireAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RealiseGunIsJammed;
    /// <summary>
    /// Function: RealiseGunIsJammed
    /// </summary>
    public unsafe virtual void RealiseGunIsJammed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RealiseGunIsJammed, "BmGame.RBMPawnAI.RealiseGunIsJammed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreventEnterCombat;
    /// <summary>
    /// Function: PreventEnterCombat
    /// </summary>
    public unsafe virtual bool PreventEnterCombat()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreventEnterCombat, "BmGame.RBMPawnAI.PreventEnterCombat");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_WeaponStopOnBurstEnd;
    /// <summary>
    /// Function: WeaponStopOnBurstEnd
    /// </summary>
    public unsafe virtual void WeaponStopOnBurstEnd()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponStopOnBurstEnd, "BmGame.RBMPawnAI.WeaponStopOnBurstEnd");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WeaponStop;
    /// <summary>
    /// Function: WeaponStop
    /// </summary>
    public unsafe virtual void WeaponStop()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponStop, "BmGame.RBMPawnAI.WeaponStop");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WeaponFire;
    /// <summary>
    /// Function: WeaponFire
    /// </summary>
    public unsafe virtual void WeaponFire(bool bBurst = default, bool bFireOnce = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponFire, "BmGame.RBMPawnAI.WeaponFire");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBurst, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFireOnce, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Anim_WeaponStop;
    /// <summary>
    /// Function: Anim_WeaponStop
    /// </summary>
    public unsafe virtual void Anim_WeaponStop()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Anim_WeaponStop, "BmGame.RBMPawnAI.Anim_WeaponStop");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Anim_WeaponFireFullAuto;
    /// <summary>
    /// Function: Anim_WeaponFireFullAuto
    /// </summary>
    public unsafe virtual void Anim_WeaponFireFullAuto()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Anim_WeaponFireFullAuto, "BmGame.RBMPawnAI.Anim_WeaponFireFullAuto");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Anim_WeaponFireOneShot;
    /// <summary>
    /// Function: Anim_WeaponFireOneShot
    /// </summary>
    public unsafe virtual void Anim_WeaponFireOneShot()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Anim_WeaponFireOneShot, "BmGame.RBMPawnAI.Anim_WeaponFireOneShot");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Anim_WeaponFire;
    /// <summary>
    /// Function: Anim_WeaponFire
    /// </summary>
    public unsafe virtual void Anim_WeaponFire()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Anim_WeaponFire, "BmGame.RBMPawnAI.Anim_WeaponFire");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopFire;
    /// <summary>
    /// Function: StopFire
    /// </summary>
    public unsafe override void StopFire(byte FireModeNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopFire, "BmGame.RBMPawnAI.StopFire");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireModeNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartFire;
    /// <summary>
    /// Function: StartFire
    /// </summary>
    public unsafe override void StartFire(byte FireModeNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartFire, "BmGame.RBMPawnAI.StartFire");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireModeNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoFiringRecoil;
    /// <summary>
    /// Function: DoFiringRecoil
    /// </summary>
    public unsafe virtual void DoFiringRecoil(BmSDK.FName RecoilAnimName, BmSDK.Engine.AnimSet Set)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoFiringRecoil, "BmGame.RBMPawnAI.DoFiringRecoil");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RecoilAnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Set, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReloadGun;
    /// <summary>
    /// Function: ReloadGun
    /// </summary>
    public unsafe virtual void ReloadGun(bool bMagicReload = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReloadGun, "BmGame.RBMPawnAI.ReloadGun");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMagicReload, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Anim_ReloadGun;
    /// <summary>
    /// Function: Anim_ReloadGun
    /// </summary>
    public unsafe virtual void Anim_ReloadGun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Anim_ReloadGun, "BmGame.RBMPawnAI.Anim_ReloadGun");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickGunFire;
    /// <summary>
    /// Function: TickGunFire
    /// </summary>
    public unsafe virtual void TickGunFire(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickGunFire, "BmGame.RBMPawnAI.TickGunFire");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldMiss;
    /// <summary>
    /// Function: ShouldMiss
    /// </summary>
    public unsafe virtual bool ShouldMiss(float TestDistSq)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldMiss, "BmGame.RBMPawnAI.ShouldMiss");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestDistSq, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetThoughts;
    /// <summary>
    /// Function: GetThoughts
    /// </summary>
    public unsafe override void GetThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThoughts, "BmGame.RBMPawnAI.GetThoughts");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetNavHandle_PathBetweenChasePoints;
    /// <summary>
    /// Function: GetNavHandle_PathBetweenChasePoints
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RNavigationHandle GetNavHandle_PathBetweenChasePoints(BmSDK.BmGame.RChasePoint StartPoint, BmSDK.BmGame.RChasePoint EndPoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNavHandle_PathBetweenChasePoints, "BmGame.RBMPawnAI.GetNavHandle_PathBetweenChasePoints");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndPoint, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RNavigationHandle>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_RemoveNavHandles;
    /// <summary>
    /// Function: RemoveNavHandles
    /// </summary>
    public unsafe virtual void RemoveNavHandles()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveNavHandles, "BmGame.RBMPawnAI.RemoveNavHandles");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopMoveToAtCurrentLocation;
    /// <summary>
    /// Function: StopMoveToAtCurrentLocation
    /// </summary>
    public unsafe virtual void StopMoveToAtCurrentLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopMoveToAtCurrentLocation, "BmGame.RBMPawnAI.StopMoveToAtCurrentLocation");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FollowNavHandle;
    /// <summary>
    /// Function: FollowNavHandle
    /// </summary>
    public unsafe virtual void FollowNavHandle(BmSDK.BmGame.RNavigationHandle NavHandle, BmSDK.BmGame.RBMAIAction_BaseMove NavAction = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FollowNavHandle, "BmGame.RBMPawnAI.FollowNavHandle");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NavHandle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NavAction, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNavHandle_PathToActor;
    /// <summary>
    /// Function: GetNavHandle_PathToActor
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RNavigationHandle GetNavHandle_PathToActor(BmSDK.Engine.Actor destActor, BmSDK.FName ClaimName, int Priority = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNavHandle_PathToActor, "BmGame.RBMPawnAI.GetNavHandle_PathToActor");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(destActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClaimName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RNavigationHandle>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetNavHandle_PathToPoint;
    /// <summary>
    /// Function: GetNavHandle_PathToPoint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RNavigationHandle GetNavHandle_PathToPoint(System.Numerics.Vector3 DestPos, BmSDK.FName ClaimName, int Priority = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNavHandle_PathToPoint, "BmGame.RBMPawnAI.GetNavHandle_PathToPoint");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DestPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClaimName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RNavigationHandle>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetNavHandle;
    /// <summary>
    /// Function: GetNavHandle
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RNavigationHandle GetNavHandle(BmSDK.FName ClaimName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNavHandle, "BmGame.RBMPawnAI.GetNavHandle");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClaimName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RNavigationHandle>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CreateBasicWeaponConfig;
    /// <summary>
    /// Function: CreateBasicWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateBasicWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.TArray<BmSDK.Engine.AnimSet> AnimSets, BmSDK.Engine.AnimSet TurnAnimSet = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateBasicWeaponConfig, "BmGame.RBMPawnAI.CreateBasicWeaponConfig");
        byte* paramsPtr = stackalloc byte[748];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSets, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TurnAnimSet, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetEntryAnim;
    /// <summary>
    /// Function: GetEntryAnim
    /// </summary>
    public unsafe virtual BmSDK.FName GetEntryAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEntryAnim, "BmGame.RBMPawnAI.GetEntryAnim");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetEntryAnimSet;
    /// <summary>
    /// Function: GetEntryAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetEntryAnimSet()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEntryAnimSet, "BmGame.RBMPawnAI.GetEntryAnimSet");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RemovePropSkeletal;
    /// <summary>
    /// Function: RemovePropSkeletal
    /// </summary>
    public unsafe override void RemovePropSkeletal(System.Numerics.Vector3 PropForce, bool PawnDied = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemovePropSkeletal, "BmGame.RBMPawnAI.RemovePropSkeletal");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropForce, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnDied, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanHitLaserGrid;
    /// <summary>
    /// Function: CanHitLaserGrid
    /// </summary>
    public unsafe override bool CanHitLaserGrid()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanHitLaserGrid, "BmGame.RBMPawnAI.CanHitLaserGrid");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanRepel;
    /// <summary>
    /// Function: CanRepel
    /// </summary>
    public unsafe override bool CanRepel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanRepel, "BmGame.RBMPawnAI.CanRepel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlaySound_ImpactAI;
    /// <summary>
    /// Function: PlaySound_ImpactAI
    /// </summary>
    public unsafe override void PlaySound_ImpactAI(bool bIsStrike, bool bFinishingBlow, bool bIsHeadImpact, bool bIsPunch, bool bIsStrong, bool bIsBlocked, bool bCanEmote = default, bool bIsSuperStrike = default, bool bIsBeatDown = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySound_ImpactAI, "BmGame.RBMPawnAI.PlaySound_ImpactAI");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsStrike, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFinishingBlow, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsHeadImpact, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsPunch, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsStrong, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsBlocked, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanEmote, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsSuperStrike, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsBeatDown, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCounterBlockImpactOverrideEvent;
    /// <summary>
    /// Function: GetCounterBlockImpactOverrideEvent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetCounterBlockImpactOverrideEvent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCounterBlockImpactOverrideEvent, "BmGame.RBMPawnAI.GetCounterBlockImpactOverrideEvent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFinishingBlowImpactOverrideEvent;
    /// <summary>
    /// Function: GetFinishingBlowImpactOverrideEvent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetFinishingBlowImpactOverrideEvent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFinishingBlowImpactOverrideEvent, "BmGame.RBMPawnAI.GetFinishingBlowImpactOverrideEvent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBeatdownImpactOverrideEvent;
    /// <summary>
    /// Function: GetBeatdownImpactOverrideEvent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetBeatdownImpactOverrideEvent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBeatdownImpactOverrideEvent, "BmGame.RBMPawnAI.GetBeatdownImpactOverrideEvent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBodyImpactOverrideEvent;
    /// <summary>
    /// Function: GetBodyImpactOverrideEvent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetBodyImpactOverrideEvent(bool bIsPunch)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBodyImpactOverrideEvent, "BmGame.RBMPawnAI.GetBodyImpactOverrideEvent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsPunch, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetHeadImpactOverrideEvent;
    /// <summary>
    /// Function: GetHeadImpactOverrideEvent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetHeadImpactOverrideEvent(bool bIsPunch)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeadImpactOverrideEvent, "BmGame.RBMPawnAI.GetHeadImpactOverrideEvent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsPunch, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_RigidBodyCollision;
    /// <summary>
    /// Function: RigidBodyCollision
    /// </summary>
    public unsafe override void RigidBodyCollision(BmSDK.Engine.PrimitiveComponent HitComponent, BmSDK.Engine.PrimitiveComponent OtherComponent, in BmSDK.Engine.Actor.FCollisionImpactData RigidCollisionData, int ContactIndex, float Speed, int Index0, int Index1)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RigidBodyCollision, "BmGame.RBMPawnAI.RigidBodyCollision");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitComponent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComponent, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RigidCollisionData, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContactIndex, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index0, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index1, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FadeOutAfterDeath;
    /// <summary>
    /// Function: FadeOutAfterDeath
    /// </summary>
    public unsafe virtual void FadeOutAfterDeath(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FadeOutAfterDeath, "BmGame.RBMPawnAI.FadeOutAfterDeath");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatMoveInitialised;
    /// <summary>
    /// Function: CombatMoveInitialised
    /// </summary>
    public unsafe override void CombatMoveInitialised(BmSDK.BmGame.RCombatMove NewMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatMoveInitialised, "BmGame.RBMPawnAI.CombatMoveInitialised");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetJammedAttackMoveClass;
    /// <summary>
    /// Function: GetJammedAttackMoveClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetJammedAttackMoveClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetJammedAttackMoveClass, "BmGame.RBMPawnAI.GetJammedAttackMoveClass");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAttackMoveClass;
    /// <summary>
    /// Function: GetAttackMoveClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetAttackMoveClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAttackMoveClass, "BmGame.RBMPawnAI.GetAttackMoveClass");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CurrentBehaviourChanged;
    /// <summary>
    /// Function: CurrentBehaviourChanged
    /// </summary>
    public unsafe virtual void CurrentBehaviourChanged(BmSDK.BmGame.RBMBehaviour NewBehaviour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CurrentBehaviourChanged, "BmGame.RBMPawnAI.CurrentBehaviourChanged");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBehaviour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishedGetUp;
    /// <summary>
    /// Function: FinishedGetUp
    /// </summary>
    public unsafe override void FinishedGetUp()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishedGetUp, "BmGame.RBMPawnAI.FinishedGetUp");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowWeaponRight;
    /// <summary>
    /// Function: ShowWeaponRight
    /// </summary>
    public unsafe virtual void ShowWeaponRight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowWeaponRight, "BmGame.RBMPawnAI.ShowWeaponRight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowWeaponLeft;
    /// <summary>
    /// Function: ShowWeaponLeft
    /// </summary>
    public unsafe virtual void ShowWeaponLeft()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowWeaponLeft, "BmGame.RBMPawnAI.ShowWeaponLeft");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowWeapon;
    /// <summary>
    /// Function: ShowWeapon
    /// </summary>
    public unsafe virtual void ShowWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowWeapon, "BmGame.RBMPawnAI.ShowWeapon");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideWeapon;
    /// <summary>
    /// Function: HideWeapon
    /// </summary>
    public unsafe virtual void HideWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideWeapon, "BmGame.RBMPawnAI.HideWeapon");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Drop;
    /// <summary>
    /// Function: Drop
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatThrownObject Drop()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Drop, "BmGame.RBMPawnAI.Drop");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMCombatThrownObject>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ThrowWeaponVelocity;
    /// <summary>
    /// Function: ThrowWeaponVelocity
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatThrownObject ThrowWeaponVelocity(System.Numerics.Vector3 NewVel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThrowWeaponVelocity, "BmGame.RBMPawnAI.ThrowWeaponVelocity");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewVel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMCombatThrownObject>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ThrowWeapon;
    /// <summary>
    /// Function: ThrowWeapon
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatThrownObject ThrowWeapon(System.Numerics.Vector3 TargetPos = default, float TimeMultiplier = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThrowWeapon, "BmGame.RBMPawnAI.ThrowWeapon");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeMultiplier, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMCombatThrownObject>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_HandleWeaponUnJammed;
    /// <summary>
    /// Function: HandleWeaponUnJammed
    /// </summary>
    public unsafe virtual void HandleWeaponUnJammed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleWeaponUnJammed, "BmGame.RBMPawnAI.HandleWeaponUnJammed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleWeaponJammed;
    /// <summary>
    /// Function: HandleWeaponJammed
    /// </summary>
    public unsafe virtual void HandleWeaponJammed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleWeaponJammed, "BmGame.RBMPawnAI.HandleWeaponJammed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandlePredThugDisarm;
    /// <summary>
    /// Function: HandlePredThugDisarm
    /// </summary>
    public unsafe virtual void HandlePredThugDisarm()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandlePredThugDisarm, "BmGame.RBMPawnAI.HandlePredThugDisarm");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleThugDisarmGunFX;
    /// <summary>
    /// Function: HandleThugDisarmGunFX
    /// </summary>
    public unsafe virtual void HandleThugDisarmGunFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleThugDisarmGunFX, "BmGame.RBMPawnAI.HandleThugDisarmGunFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WeaponSwitchCallback;
    /// <summary>
    /// Function: WeaponSwitchCallback
    /// </summary>
    public unsafe override void WeaponSwitchCallback(BmSDK.Engine.Inventory NewWeapon, BmSDK.Engine.Inventory PreviousWeapon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponSwitchCallback, "BmGame.RBMPawnAI.WeaponSwitchCallback");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousWeapon, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NewWeaponAttached;
    /// <summary>
    /// Function: NewWeaponAttached
    /// </summary>
    public unsafe virtual void NewWeaponAttached(BmSDK.BmGame.RBMWeapon NewWeapon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NewWeaponAttached, "BmGame.RBMPawnAI.NewWeaponAttached");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WeaponChanged;
    /// <summary>
    /// Function: WeaponChanged
    /// </summary>
    public unsafe virtual void WeaponChanged(BmSDK.BmGame.RBMWeapon NewWeapon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponChanged, "BmGame.RBMPawnAI.WeaponChanged");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DodgedMagneticBlastDisarm;
    /// <summary>
    /// Function: DodgedMagneticBlastDisarm
    /// </summary>
    public unsafe virtual void DodgedMagneticBlastDisarm()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DodgedMagneticBlastDisarm, "BmGame.RBMPawnAI.DodgedMagneticBlastDisarm");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryDisarmByMagneticBlast;
    /// <summary>
    /// Function: TryDisarmByMagneticBlast
    /// </summary>
    public unsafe virtual void TryDisarmByMagneticBlast(System.Numerics.Vector3 Impulse, BmSDK.BmGame.RPawnCombat Attacker, BmSDK.BmGame.RMagneticBlastReceiver Receiver, bool bSuccessfulDisarm)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryDisarmByMagneticBlast, "BmGame.RBMPawnAI.TryDisarmByMagneticBlast");
        byte* paramsPtr = stackalloc byte[300];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Impulse, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Receiver, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSuccessfulDisarm, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceDisarm;
    /// <summary>
    /// Function: ForceDisarm
    /// </summary>
    public unsafe virtual void ForceDisarm()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceDisarm, "BmGame.RBMPawnAI.ForceDisarm");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DropWeapon;
    /// <summary>
    /// Function: DropWeapon
    /// </summary>
    public unsafe virtual void DropWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DropWeapon, "BmGame.RBMPawnAI.DropWeapon");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Disarm;
    /// <summary>
    /// Function: Disarm
    /// </summary>
    public unsafe virtual void Disarm()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Disarm, "BmGame.RBMPawnAI.Disarm");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerBumped;
    /// <summary>
    /// Function: PlayerBumped
    /// </summary>
    public unsafe virtual void PlayerBumped(BmSDK.BmGame.RPawnPlayer Player)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerBumped, "BmGame.RBMPawnAI.PlayerBumped");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Bump;
    /// <summary>
    /// Function: Bump
    /// </summary>
    public unsafe override void Bump(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Bump, "BmGame.RBMPawnAI.Bump");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckDodgeProjectile;
    /// <summary>
    /// Function: CheckDodgeProjectile
    /// </summary>
    public unsafe virtual bool CheckDodgeProjectile(BmSDK.BmGame.RPawn Thrower, BmSDK.FName TargetBone, System.Numerics.Vector3 ProjPos, int BatarangID, bool bForceDodge = default, bool bSteerableProj = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckDodgeProjectile, "BmGame.RBMPawnAI.CheckDodgeProjectile");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thrower, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBone, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProjPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatarangID, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceDodge, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSteerableProj, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_CollisionWith;
    /// <summary>
    /// Function: CollisionWith
    /// </summary>
    public unsafe override void CollisionWith(BmSDK.BmGame.RPawnCombat OtherPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CollisionWith, "BmGame.RBMPawnAI.CollisionWith");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IdleConfigNotify;
    /// <summary>
    /// Function: IdleConfigNotify
    /// </summary>
    public unsafe virtual void IdleConfigNotify(BmSDK.BmGame.RAnimNotify_IdleConfigOutput Notify)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IdleConfigNotify, "BmGame.RBMPawnAI.IdleConfigNotify");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Notify, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckBigGuyDamage;
    /// <summary>
    /// Function: CheckBigGuyDamage
    /// </summary>
    public unsafe virtual void CheckBigGuyDamage(BmSDK.BmGame.RPawnCombat NewAttacker, BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckBigGuyDamage, "BmGame.RBMPawnAI.CheckBigGuyDamage");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCombatBehaviourClass;
    /// <summary>
    /// Function: GetCombatBehaviourClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetCombatBehaviourClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatBehaviourClass, "BmGame.RBMPawnAI.GetCombatBehaviourClass");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HasWeapon;
    /// <summary>
    /// Function: HasWeapon
    /// </summary>
    public unsafe virtual bool HasWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasWeapon, "BmGame.RBMPawnAI.HasWeapon");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpawnWeapon;
    /// <summary>
    /// Function: SpawnWeapon
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMWeapon SpawnWeapon(BmSDK.Class WeaponClass, bool bForce = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnWeapon, "BmGame.RBMPawnAI.SpawnWeapon");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForce, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMWeapon>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CreateWeapon;
    /// <summary>
    /// Function: CreateWeapon
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMWeapon CreateWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateWeapon, "BmGame.RBMPawnAI.CreateWeapon");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMWeapon>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetupCustomPhysics;
    /// <summary>
    /// Function: SetupCustomPhysics
    /// </summary>
    public unsafe override void SetupCustomPhysics()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupCustomPhysics, "BmGame.RBMPawnAI.SetupCustomPhysics");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPropsInXray;
    /// <summary>
    /// Function: SetPropsInXray
    /// </summary>
    public unsafe override void SetPropsInXray(bool bActivate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPropsInXray, "BmGame.RBMPawnAI.SetPropsInXray");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActivate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPropsInThermal;
    /// <summary>
    /// Function: SetPropsInThermal
    /// </summary>
    public unsafe override void SetPropsInThermal(bool bActivate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPropsInThermal, "BmGame.RBMPawnAI.SetPropsInThermal");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActivate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetIndividualStaticPropInVM;
    /// <summary>
    /// Function: SetIndividualStaticPropInVM
    /// </summary>
    public unsafe virtual void SetIndividualStaticPropInVM(bool bActivate, bool bThermal, int MeshToChangeIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIndividualStaticPropInVM, "BmGame.RBMPawnAI.SetIndividualStaticPropInVM");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActivate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bThermal, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeshToChangeIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetIndividualSkeletalPropInVM;
    /// <summary>
    /// Function: SetIndividualSkeletalPropInVM
    /// </summary>
    public unsafe virtual void SetIndividualSkeletalPropInVM(bool bActivate, bool bThermal, int MeshToChangeIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIndividualSkeletalPropInVM, "BmGame.RBMPawnAI.SetIndividualSkeletalPropInVM");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActivate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bThermal, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeshToChangeIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachSkeletalProps;
    /// <summary>
    /// Function: AttachSkeletalProps
    /// </summary>
    public unsafe virtual void AttachSkeletalProps()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachSkeletalProps, "BmGame.RBMPawnAI.AttachSkeletalProps");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetStaticPropIndexByMesh;
    /// <summary>
    /// Function: GetStaticPropIndexByMesh
    /// </summary>
    public unsafe virtual int GetStaticPropIndexByMesh(BmSDK.Engine.StaticMesh SM)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStaticPropIndexByMesh, "BmGame.RBMPawnAI.GetStaticPropIndexByMesh");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SM, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OverrideStaticPropMaterial;
    /// <summary>
    /// Function: OverrideStaticPropMaterial
    /// </summary>
    public unsafe virtual void OverrideStaticPropMaterial(int Index, BmSDK.Engine.Material Mat)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideStaticPropMaterial, "BmGame.RBMPawnAI.OverrideStaticPropMaterial");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mat, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetStaticPropHidden;
    /// <summary>
    /// Function: SetStaticPropHidden
    /// </summary>
    public unsafe virtual void SetStaticPropHidden(int Index, bool bHide)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetStaticPropHidden, "BmGame.RBMPawnAI.SetStaticPropHidden");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHide, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitPropStatic;
    /// <summary>
    /// Function: InitPropStatic
    /// </summary>
    public unsafe virtual void InitPropStatic(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitPropStatic, "BmGame.RBMPawnAI.InitPropStatic");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachStaticProps;
    /// <summary>
    /// Function: AttachStaticProps
    /// </summary>
    public unsafe virtual void AttachStaticProps()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachStaticProps, "BmGame.RBMPawnAI.AttachStaticProps");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachProps;
    /// <summary>
    /// Function: AttachProps
    /// </summary>
    public unsafe virtual void AttachProps()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachProps, "BmGame.RBMPawnAI.AttachProps");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPawnProps;
    /// <summary>
    /// Function: AddPawnProps
    /// </summary>
    public unsafe virtual void AddPawnProps()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPawnProps, "BmGame.RBMPawnAI.AddPawnProps");
        byte* paramsPtr = stackalloc byte[220];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShrinkAttachmentArrays;
    /// <summary>
    /// Function: ShrinkAttachmentArrays
    /// </summary>
    public unsafe virtual void ShrinkAttachmentArrays()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShrinkAttachmentArrays, "BmGame.RBMPawnAI.ShrinkAttachmentArrays");
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

    private static BmSDK.Function __fn_PostLoadXrayCheck;
    /// <summary>
    /// Function: PostLoadXrayCheck
    /// </summary>
    public unsafe virtual void PostLoadXrayCheck()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostLoadXrayCheck, "BmGame.RBMPawnAI.PostLoadXrayCheck");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPawnName;
    /// <summary>
    /// Function: GetPawnName
    /// </summary>
    public unsafe virtual void GetPawnName(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPawnName, "BmGame.RBMPawnAI.GetPawnName");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_ReplicatedEvent;
    /// <summary>
    /// Function: ReplicatedEvent
    /// </summary>
    public unsafe override void ReplicatedEvent(BmSDK.FName VarName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplicatedEvent, "BmGame.RBMPawnAI.ReplicatedEvent");
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Died;
    /// <summary>
    /// Function: Died
    /// </summary>
    public unsafe override bool Died(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Died, "BmGame.RBMPawnAI.Died");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RBMPawnAI.Destroyed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreStreamOut;
    /// <summary>
    /// Function: PreStreamOut
    /// </summary>
    public unsafe override void PreStreamOut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmGame.RBMPawnAI.PreStreamOut");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyPawn;
    /// <summary>
    /// Function: DestroyPawn
    /// </summary>
    public unsafe virtual void DestroyPawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyPawn, "BmGame.RBMPawnAI.DestroyPawn");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInXrayMode;
    /// <summary>
    /// Function: SetInXrayMode
    /// </summary>
    public unsafe override void SetInXrayMode(bool show, bool bForceOff)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInXrayMode, "BmGame.RBMPawnAI.SetInXrayMode");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(show, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetFleeRunPose;
    /// <summary>
    /// Function: SetFleeRunPose
    /// </summary>
    public unsafe virtual void SetFleeRunPose()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFleeRunPose, "BmGame.RBMPawnAI.SetFleeRunPose");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetExtendedSightRange;
    /// <summary>
    /// Function: SetExtendedSightRange
    /// </summary>
    public unsafe virtual void SetExtendedSightRange(float NewRange)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetExtendedSightRange, "BmGame.RBMPawnAI.SetExtendedSightRange");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRange, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetFocusedVisionRadius;
    /// <summary>
    /// Function: SetFocusedVisionRadius
    /// </summary>
    public unsafe virtual void SetFocusedVisionRadius(float NewRadius)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFocusedVisionRadius, "BmGame.RBMPawnAI.SetFocusedVisionRadius");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRadius, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetFocusedSightRange;
    /// <summary>
    /// Function: SetFocusedSightRange
    /// </summary>
    public unsafe virtual void SetFocusedSightRange(float NewRange)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFocusedSightRange, "BmGame.RBMPawnAI.SetFocusedSightRange");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRange, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPeripheralSightRange;
    /// <summary>
    /// Function: SetPeripheralSightRange
    /// </summary>
    public unsafe virtual void SetPeripheralSightRange(float NewRange)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPeripheralSightRange, "BmGame.RBMPawnAI.SetPeripheralSightRange");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRange, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCheckSightRange;
    /// <summary>
    /// Function: GetCheckSightRange
    /// </summary>
    public unsafe virtual float GetCheckSightRange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCheckSightRange, "BmGame.RBMPawnAI.GetCheckSightRange");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanMoveToPoint;
    /// <summary>
    /// Function: CanMoveToPoint
    /// </summary>
    public unsafe virtual bool CanMoveToPoint(System.Numerics.Vector3 MoveToPoint, out float HitTime, out BmSDK.Engine.Actor HitActor, bool bSlopeCheck = default, System.Numerics.Vector3 TestLocation = default, bool bForceExtentCheck = default, bool bDoGroundCheck = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanMoveToPoint, "BmGame.RBMPawnAI.CanMoveToPoint");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveToPoint, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitTime);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitTime, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitActor);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitActor, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSlopeCheck, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLocation, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceExtentCheck, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoGroundCheck, paramsPtr + 40);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HitTime = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
        HitActor = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_CreateLuresWeaponConfig;
    /// <summary>
    /// Function: CreateLuresWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateLuresWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.Engine.AnimSet AnimSet1)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateLuresWeaponConfig, "BmGame.RBMPawnAI.CreateLuresWeaponConfig");
        byte* paramsPtr = stackalloc byte[3076];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CreateLadderWeaponConfig;
    /// <summary>
    /// Function: CreateLadderWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateLadderWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.Engine.AnimSet AnimSet1, BmSDK.Engine.AnimSet AnimSet2 = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateLadderWeaponConfig, "BmGame.RBMPawnAI.CreateLadderWeaponConfig");
        byte* paramsPtr = stackalloc byte[1536];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet2, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CreateWeaponConfigUnarmed;
    /// <summary>
    /// Function: CreateWeaponConfigUnarmed
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateWeaponConfigUnarmed(BmSDK.GameObject NewOwner)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateWeaponConfigUnarmed, "BmGame.RBMPawnAI.CreateWeaponConfigUnarmed");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsStrungUp;
    /// <summary>
    /// Function: IsStrungUp
    /// </summary>
    public unsafe override bool IsStrungUp()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsStrungUp, "BmGame.RBMPawnAI.IsStrungUp");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DeregisterWeaponConfig;
    /// <summary>
    /// Function: DeregisterWeaponConfig
    /// </summary>
    public unsafe virtual void DeregisterWeaponConfig()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeregisterWeaponConfig, "BmGame.RBMPawnAI.DeregisterWeaponConfig");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateWeaponConfig;
    /// <summary>
    /// Function: CreateWeaponConfig
    /// </summary>
    public unsafe virtual void CreateWeaponConfig()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateWeaponConfig, "BmGame.RBMPawnAI.CreateWeaponConfig");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostInitCharacter;
    /// <summary>
    /// Function: PostInitCharacter
    /// </summary>
    public unsafe override void PostInitCharacter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostInitCharacter, "BmGame.RBMPawnAI.PostInitCharacter");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTargetPlayer;
    /// <summary>
    /// Function: GetTargetPlayer
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat GetTargetPlayer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargetPlayer, "BmGame.RBMPawnAI.GetTargetPlayer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTargetPawn;
    /// <summary>
    /// Function: GetTargetPawn
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat GetTargetPawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargetPawn, "BmGame.RBMPawnAI.GetTargetPawn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanReceiveAttackFromAIPawn;
    /// <summary>
    /// Function: CanReceiveAttackFromAIPawn
    /// </summary>
    public unsafe virtual bool CanReceiveAttackFromAIPawn(BmSDK.BmGame.RBMPawnAI AIAttacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanReceiveAttackFromAIPawn, "BmGame.RBMPawnAI.CanReceiveAttackFromAIPawn");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AIAttacker, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetSpeechThoughts;
    /// <summary>
    /// Function: GetSpeechThoughts
    /// </summary>
    public unsafe virtual void GetSpeechThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList, BmSDK.FString Emote)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSpeechThoughts, "BmGame.RBMPawnAI.GetSpeechThoughts");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Emote, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_ForceTickIndividualComponent;
    /// <summary>
    /// Function: ForceTickIndividualComponent
    /// </summary>
    public unsafe virtual void ForceTickIndividualComponent(BmSDK.Engine.ActorComponent CompToTick, float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceTickIndividualComponent, "BmGame.RBMPawnAI.ForceTickIndividualComponent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CompToTick, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 4);
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

    private static BmSDK.Function __fn_UpdatePropsVisibility;
    /// <summary>
    /// Function: UpdatePropsVisibility
    /// </summary>
    public unsafe override void UpdatePropsVisibility(float AlphaVal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePropsVisibility, "BmGame.RBMPawnAI.UpdatePropsVisibility");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AlphaVal, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetTickIsDisabled;
    /// <summary>
    /// Function: SetTickIsDisabled
    /// </summary>
    public unsafe override void SetTickIsDisabled(bool bInDisabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTickIsDisabled, "BmGame.RBMPawnAI.SetTickIsDisabled");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInDisabled, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetLastValidNavMeshPoly;
    /// <summary>
    /// Function: SetLastValidNavMeshPoly
    /// </summary>
    public unsafe virtual void SetLastValidNavMeshPoly(BmSDK.Engine.Pylon ValidPylon, int ValidPolyID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLastValidNavMeshPoly, "BmGame.RBMPawnAI.SetLastValidNavMeshPoly");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ValidPylon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ValidPolyID, paramsPtr + 4);
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

    private static BmSDK.Function __fn_LogPopCorrectionInAnimLog;
    /// <summary>
    /// Function: LogPopCorrectionInAnimLog
    /// </summary>
    public unsafe virtual void LogPopCorrectionInAnimLog()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogPopCorrectionInAnimLog, "BmGame.RBMPawnAI.LogPopCorrectionInAnimLog");
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

    private static BmSDK.Function __fn_UpdateVertVisibility;
    /// <summary>
    /// Function: UpdateVertVisibility
    /// </summary>
    public unsafe virtual void UpdateVertVisibility()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateVertVisibility, "BmGame.RBMPawnAI.UpdateVertVisibility");
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

    private static BmSDK.Function __fn_GetMaxSightRange;
    /// <summary>
    /// Function: GetMaxSightRange
    /// </summary>
    public unsafe virtual float GetMaxSightRange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxSightRange, "BmGame.RBMPawnAI.GetMaxSightRange");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanSeeActorFromPos;
    /// <summary>
    /// Function: CanSeeActorFromPos
    /// </summary>
    public unsafe virtual float CanSeeActorFromPos(BmSDK.Engine.Actor TestActor, System.Numerics.Vector3 TestPos, bool bEarlyOut = default, bool bIgnoreSmoke = default, bool bSkipTestedBones = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSeeActorFromPos, "BmGame.RBMPawnAI.CanSeeActorFromPos");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPos, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEarlyOut, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreSmoke, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSkipTestedBones, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_CanSeeActor;
    /// <summary>
    /// Function: CanSeeActor
    /// </summary>
    public unsafe virtual float CanSeeActor(BmSDK.Engine.Actor TestActor, bool bEarlyOut = default, bool bIgnoreSmoke = default, bool bSkipTestedBones = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSeeActor, "BmGame.RBMPawnAI.CanSeeActor");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEarlyOut, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreSmoke, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSkipTestedBones, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CanSeePos;
    /// <summary>
    /// Function: CanSeePos
    /// </summary>
    public unsafe virtual bool CanSeePos(System.Numerics.Vector3 TestPos, bool bIgnoreSmoke = default, bool bStartWithPointCheck = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSeePos, "BmGame.RBMPawnAI.CanSeePos");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreSmoke, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStartWithPointCheck, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetPawnVisionCheckEyeLoc;
    /// <summary>
    /// Function: GetPawnVisionCheckEyeLoc
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetPawnVisionCheckEyeLoc()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPawnVisionCheckEyeLoc, "BmGame.RBMPawnAI.GetPawnVisionCheckEyeLoc");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CreateActionOfClass;
    /// <summary>
    /// Function: CreateActionOfClass
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMAIAction CreateActionOfClass(BmSDK.Class NewClass, BmSDK.FString NewId = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateActionOfClass, "BmGame.RBMPawnAI.CreateActionOfClass");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewId, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMAIAction>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_InitCharacter;
    /// <summary>
    /// Function: InitCharacter
    /// </summary>
    public unsafe virtual void InitCharacter(BmSDK.BmGame.RBMPawnAI.FInitCharacterDescription Description)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitCharacter, "BmGame.RBMPawnAI.InitCharacter");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 0);
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

    private static BmSDK.Function __fn_OnAudioSourceCreate;
    /// <summary>
    /// Function: OnAudioSourceCreate
    /// </summary>
    public unsafe override void OnAudioSourceCreate(BmSDK.Engine.AkComponent akComp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAudioSourceCreate, "BmGame.RBMPawnAI.OnAudioSourceCreate");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(akComp, paramsPtr + 0);
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

    private static BmSDK.Function __fn_NotifyPathChanged;
    /// <summary>
    /// Function: NotifyPathChanged
    /// </summary>
    public unsafe virtual void NotifyPathChanged()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyPathChanged, "BmGame.RBMPawnAI.NotifyPathChanged");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateGlitchesMaterial;
    /// <summary>
    /// Function: ActivateGlitchesMaterial
    /// </summary>
    public unsafe virtual void ActivateGlitchesMaterial(bool ActivateMat)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateGlitchesMaterial, "BmGame.RBMPawnAI.ActivateGlitchesMaterial");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActivateMat, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StasisStateChanged;
    /// <summary>
    /// Function: StasisStateChanged
    /// </summary>
    public unsafe virtual void StasisStateChanged(bool bIsInStasis)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StasisStateChanged, "BmGame.RBMPawnAI.StasisStateChanged");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsInStasis, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanPickup;
    /// <summary>
    /// Function: CanPickup
    /// </summary>
    public unsafe virtual bool CanPickup(BmSDK.BmGame.RBMCombatThrownObject Object)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPickup, "BmGame.RBMPawnAI.CanPickup");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Object, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HasCurrentTimeSlice;
    /// <summary>
    /// Function: HasCurrentTimeSlice
    /// </summary>
    public unsafe virtual bool HasCurrentTimeSlice()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasCurrentTimeSlice, "BmGame.RBMPawnAI.HasCurrentTimeSlice");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckForNextGlitchTransit;
    /// <summary>
    /// Function: CheckForNextGlitchTransit
    /// </summary>
    public unsafe virtual void CheckForNextGlitchTransit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForNextGlitchTransit, "BmGame.RBMPawnAI.CheckForNextGlitchTransit");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Toggle;
    /// <summary>
    /// Function: Toggle
    /// </summary>
    public unsafe virtual bool Toggle(bool bActivate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Toggle, "BmGame.RBMPawnAI.Toggle");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActivate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ResetChainAndToggleTop;
    /// <summary>
    /// Function: ResetChainAndToggleTop
    /// </summary>
    public unsafe virtual void ResetChainAndToggleTop(bool Activate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetChainAndToggleTop, "BmGame.RBMPawnAI.ResetChainAndToggleTop");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Activate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsChainCurrentlyActivated;
    /// <summary>
    /// Function: IsChainCurrentlyActivated
    /// </summary>
    public unsafe virtual bool IsChainCurrentlyActivated()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsChainCurrentlyActivated, "BmGame.RBMPawnAI.IsChainCurrentlyActivated");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ResetChainActivity;
    /// <summary>
    /// Function: ResetChainActivity
    /// </summary>
    public unsafe virtual void ResetChainActivity(bool currentActivity)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetChainActivity, "BmGame.RBMPawnAI.ResetChainActivity");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(currentActivity, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopChain;
    /// <summary>
    /// Function: StopChain
    /// </summary>
    public unsafe virtual void StopChain()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopChain, "BmGame.RBMPawnAI.StopChain");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableChain;
    /// <summary>
    /// Function: EnableChain
    /// </summary>
    public unsafe virtual void EnableChain(bool bEnabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableChain, "BmGame.RBMPawnAI.EnableChain");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsParent;
    /// <summary>
    /// Function: IsParent
    /// </summary>
    public unsafe virtual bool IsParent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsParent, "BmGame.RBMPawnAI.IsParent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetCurrentlyActive;
    /// <summary>
    /// Function: SetCurrentlyActive
    /// </summary>
    public unsafe virtual void SetCurrentlyActive(bool Activate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentlyActive, "BmGame.RBMPawnAI.SetCurrentlyActive");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Activate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTop;
    /// <summary>
    /// Function: GetTop
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MGlitchesInterface GetTop()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTop, "BmGame.RBMPawnAI.GetTop");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MGlitchesInterface>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPrev;
    /// <summary>
    /// Function: GetPrev
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MGlitchesInterface GetPrev()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPrev, "BmGame.RBMPawnAI.GetPrev");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MGlitchesInterface>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNext;
    /// <summary>
    /// Function: GetNext
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MGlitchesInterface GetNext()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNext, "BmGame.RBMPawnAI.GetNext");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MGlitchesInterface>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UnRegisterGlitch;
    /// <summary>
    /// Function: UnRegisterGlitch
    /// </summary>
    public unsafe virtual bool UnRegisterGlitch()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnRegisterGlitch, "BmGame.RBMPawnAI.UnRegisterGlitch");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RegisterGlitch;
    /// <summary>
    /// Function: RegisterGlitch
    /// </summary>
    public unsafe virtual bool RegisterGlitch()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterGlitch, "BmGame.RBMPawnAI.RegisterGlitch");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGlitchLocation;
    /// <summary>
    /// Function: GetGlitchLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetGlitchLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGlitchLocation, "BmGame.RBMPawnAI.GetGlitchLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetIsParticleEnabled;
    /// <summary>
    /// Function: SetIsParticleEnabled
    /// </summary>
    public unsafe virtual void SetIsParticleEnabled(bool IsParticleEnabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIsParticleEnabled, "BmGame.RBMPawnAI.SetIsParticleEnabled");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsParticleEnabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetIsParticleEnabled;
    /// <summary>
    /// Function: GetIsParticleEnabled
    /// </summary>
    public unsafe virtual bool GetIsParticleEnabled()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIsParticleEnabled, "BmGame.RBMPawnAI.GetIsParticleEnabled");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetIsMaterialEnabled;
    /// <summary>
    /// Function: SetIsMaterialEnabled
    /// </summary>
    public unsafe virtual void SetIsMaterialEnabled(bool IsMaterialEnabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIsMaterialEnabled, "BmGame.RBMPawnAI.SetIsMaterialEnabled");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsMaterialEnabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetIsMaterialEnabled;
    /// <summary>
    /// Function: GetIsMaterialEnabled
    /// </summary>
    public unsafe virtual bool GetIsMaterialEnabled()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIsMaterialEnabled, "BmGame.RBMPawnAI.GetIsMaterialEnabled");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetIsEnabled;
    /// <summary>
    /// Function: SetIsEnabled
    /// </summary>
    public unsafe virtual void SetIsEnabled(bool IsEnabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIsEnabled, "BmGame.RBMPawnAI.SetIsEnabled");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsEnabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetIsEnabled;
    /// <summary>
    /// Function: GetIsEnabled
    /// </summary>
    public unsafe virtual bool GetIsEnabled()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIsEnabled, "BmGame.RBMPawnAI.GetIsEnabled");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDisplayName;
    /// <summary>
    /// Function: GetDisplayName
    /// </summary>
    public unsafe virtual BmSDK.FName GetDisplayName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisplayName, "BmGame.RBMPawnAI.GetDisplayName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetGlitchesController;
    /// <summary>
    /// Function: SetGlitchesController
    /// </summary>
    public unsafe virtual void SetGlitchesController(BmSDK.BmGame.MGlitchesController cont)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGlitchesController, "BmGame.RBMPawnAI.SetGlitchesController");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(cont, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsCurrentlyActive;
    /// <summary>
    /// Function: IsCurrentlyActive
    /// </summary>
    public unsafe virtual bool IsCurrentlyActive()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCurrentlyActive, "BmGame.RBMPawnAI.IsCurrentlyActive");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Struct: FBeatdownInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FBeatdownInfo
    {
        /// <summary>
        /// IntProperty: CurrStrike
        /// </summary>
        public unsafe int CurrStrike
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: TotalHitsToKOTarget
        /// </summary>
        public unsafe int TotalHitsToKOTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: TimesCountered
        /// </summary>
        public unsafe int TimesCountered
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bStartedBeatdown
        /// </summary>
        public unsafe bool bStartedBeatdown
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bShockglovesHit
        /// </summary>
        public unsafe bool bShockglovesHit
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FPairedAnimsetPackageDef
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public partial record struct FPairedAnimsetPackageDef
    {
        /// <summary>
        /// NameProperty: PlayerName
        /// </summary>
        public unsafe BmSDK.FName PlayerName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: PackageName
        /// </summary>
        public unsafe BmSDK.FString PackageName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ArrayProperty: VillainAnimsetNames
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> VillainAnimsetNames
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ArrayProperty: PlayerAnimsetNames
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> PlayerAnimsetNames
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// ArrayProperty: DynamicallyLoadedAnimsets
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FDynamicallyLoadedAnimsetDef> DynamicallyLoadedAnimsets
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FDynamicallyLoadedAnimsetDef>>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// BoolProperty: bAssumeAlreadyLoaded
        /// </summary>
        public unsafe bool bAssumeAlreadyLoaded
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }; }
        }

        /// <summary>
        /// BoolProperty: bNonOWOnly
        /// </summary>
        public unsafe bool bNonOWOnly
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }; }
        }
    }

    /// <summary>
    /// Struct: FDynamicallyLoadedAnimsetDef
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FDynamicallyLoadedAnimsetDef
    {
        /// <summary>
        /// NameProperty: PropertyName
        /// </summary>
        public unsafe BmSDK.FName PropertyName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: AnimsetString
        /// </summary>
        public unsafe BmSDK.FString AnimsetString
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ByteProperty: ArrayOp
        /// </summary>
        public unsafe BmSDK.Engine.MObjectStreaming.EArrayPropertyType ArrayOp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MObjectStreaming.EArrayPropertyType>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Enum: StuckRagdollSolutionType
    /// </summary>
    public enum StuckRagdollSolutionType : byte
    {
        SRST_LeaveStuck = 0,
        SRST_Freeze = 1,
        SRST_RemoveWhenOffScreen = 2,
        SRST_FreezeAndRemoveWhenOffScreen = 3,
        SRST_RemoveImmediately = 4,
        SRST_MAX = 5,
    }

    /// <summary>
    /// Enum: CombatReadinessState
    /// </summary>
    public enum CombatReadinessState : byte
    {
        CRS_None = 0,
        CRS_LoadingAnims = 1,
        CRS_AnimLoadFailed = 2,
        CRS_Ready = 3,
        CRS_MAX = 4,
    }

    /// <summary>
    /// Struct: FEnemyPosition
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FEnemyPosition
    {
        /// <summary>
        /// StructProperty: Position
        /// </summary>
        public unsafe System.Numerics.Vector3 Position
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Time
        /// </summary>
        public unsafe float Time
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FAlwaysOnParticles
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FAlwaysOnParticles
    {
        /// <summary>
        /// ComponentProperty: Part
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystemComponent Part
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: AttachBone
        /// </summary>
        public unsafe BmSDK.FName AttachBone
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FValidNavMeshPoly
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FValidNavMeshPoly
    {
        /// <summary>
        /// StructProperty: Position
        /// </summary>
        public unsafe System.Numerics.Vector3 Position
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: Pylon
        /// </summary>
        public unsafe BmSDK.Engine.Pylon Pylon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pylon>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: PolyId
        /// </summary>
        public unsafe int PolyId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Enum: GunTargetBoneState
    /// </summary>
    public enum GunTargetBoneState : byte
    {
        GTBS_Untested = 0,
        GTBS_Obscured = 1,
        GTBS_Visible = 2,
        GTBS_MAX = 3,
    }

    /// <summary>
    /// Struct: FInitCharacterDescription
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial record struct FInitCharacterDescription
    {
        /// <summary>
        /// ClassProperty: Character
        /// </summary>
        public unsafe BmSDK.Class Character
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: OverrideCharacter
        /// </summary>
        public unsafe BmSDK.BmGame.RCharacter OverrideCharacter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCharacter>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ClassProperty: WeaponType
        /// </summary>
        public unsafe BmSDK.Class WeaponType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: AlternateAnimAndWeapon
        /// </summary>
        public unsafe BmSDK.BmGame.RAlternateAnimationAndWeaponConfig AlternateAnimAndWeapon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAlternateAnimationAndWeaponConfig>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// NameProperty: InitialMovementStance
        /// </summary>
        public unsafe BmSDK.FName InitialMovementStance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// NameProperty: InitialWeaponStance
        /// </summary>
        public unsafe BmSDK.FName InitialWeaponStance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// BoolProperty: bCastShadow
        /// </summary>
        public unsafe bool bCastShadow
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: bForceFlappyBitsOff
        /// </summary>
        public unsafe bool bForceFlappyBitsOff
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: bForceAlwaysUsePhysicsOn
        /// </summary>
        public unsafe bool bForceAlwaysUsePhysicsOn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: bCanBeXrayed
        /// </summary>
        public unsafe bool bCanBeXrayed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: bSilentRagdoll
        /// </summary>
        public unsafe bool bSilentRagdoll
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: bUsedInCutsceneDialogue
        /// </summary>
        public unsafe bool bUsedInCutsceneDialogue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: OverridePhysWalkingType
        /// </summary>
        public unsafe bool OverridePhysWalkingType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 64) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }

        /// <summary>
        /// ByteProperty: PhysWalkingType
        /// </summary>
        public unsafe BmSDK.BmGame.RGameRI.EPhysWalkingType PhysWalkingType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.EPhysWalkingType>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: bFallBackToNavMeshFloor
        /// </summary>
        public unsafe bool bFallBackToNavMeshFloor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// ByteProperty: RagdollVsNavMeshSolution
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnCharacter.ERagdollVsNavMesh RagdollVsNavMeshSolution
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCharacter.ERagdollVsNavMesh>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// BoolProperty: bReduceBlinksAndEyeMovements
        /// </summary>
        public unsafe bool bReduceBlinksAndEyeMovements
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }; }
        }

        /// <summary>
        /// BoolProperty: bForceDisableFloorCorrection
        /// </summary>
        public unsafe bool bForceDisableFloorCorrection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }; }
        }

        /// <summary>
        /// BoolProperty: bUseSkeletalMeshAggressiveLODScale
        /// </summary>
        public unsafe bool bUseSkeletalMeshAggressiveLODScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: SkeletalMeshAggressiveLODMultiplier
        /// </summary>
        public unsafe float SkeletalMeshAggressiveLODMultiplier
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// BoolProperty: bAlwaysHasTimeSlice
        /// </summary>
        public unsafe bool bAlwaysHasTimeSlice
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }; }
        }

        /// <summary>
        /// ByteProperty: ThugBarkType
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.EThugBarkType ThugBarkType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EThugBarkType>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// ByteProperty: OverideRand
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.OverrideRandom OverideRand
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.OverrideRandom>(Ptr + 61); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 61); }; }
        }

        /// <summary>
        /// BoolProperty: bCanUseGunLightInPredatorRooms
        /// </summary>
        public unsafe bool bCanUseGunLightInPredatorRooms
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }

        /// <summary>
        /// ByteProperty: HighlightType
        /// </summary>
        public unsafe BmSDK.BmGame.RBMPawnAI.ECharacterHighlightType HighlightType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI.ECharacterHighlightType>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }
    }

    /// <summary>
    /// Enum: ECharacterHighlightType
    /// </summary>
    public enum ECharacterHighlightType : byte
    {
        ECHT_None = 0,
        ECHT_EnigmaDataHandler = 1,
        ECHT_CrimeSceneSuspect = 2,
        ECHT_EscapedPrisoner = 3,
        ECHT_CrimeInProgressCriminal = 4,
        ECHT_AnarkyMessenger = 5,
        ECHT_MAX = 6,
    }

    /// <summary>
    /// Struct: FCharacterStaticProps
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial record struct FCharacterStaticProps
    {
        /// <summary>
        /// ObjectProperty: Prop
        /// </summary>
        public unsafe BmSDK.Engine.StaticMesh Prop
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMesh>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ComponentProperty: PropComp
        /// </summary>
        public unsafe BmSDK.Engine.StaticMeshComponent PropComp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// NameProperty: PropGlobalFlagCheck
        /// </summary>
        public unsafe BmSDK.FName PropGlobalFlagCheck
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// NameProperty: SocketToAttachPropTo
        /// </summary>
        public unsafe BmSDK.FName SocketToAttachPropTo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// NameProperty: BoneToAttachPropTo
        /// </summary>
        public unsafe BmSDK.FName BoneToAttachPropTo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ObjectProperty: SpecialXrayMat
        /// </summary>
        public unsafe BmSDK.Engine.MaterialInstance SpecialXrayMat
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstance>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// ObjectProperty: SpecialXrayMatIC
        /// </summary>
        public unsafe BmSDK.Engine.MaterialInstanceConstant SpecialXrayMatIC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// ObjectProperty: SpecialThermalMat
        /// </summary>
        public unsafe BmSDK.Engine.MaterialInstance SpecialThermalMat
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstance>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// ObjectProperty: SpecialThermalMatIC
        /// </summary>
        public unsafe BmSDK.Engine.MaterialInstanceConstant SpecialThermalMatIC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// ArrayProperty: SavedXrayMats
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInterface> SavedXrayMats
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInterface>>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// ArrayProperty: SavedThermalMats
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInterface> SavedThermalMats
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInterface>>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }
    }

    /// <summary>
    /// Struct: FCharacterSkeletalProps
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 124)]
    public partial record struct FCharacterSkeletalProps
    {
        /// <summary>
        /// ObjectProperty: Prop
        /// </summary>
        public unsafe BmSDK.Engine.SkeletalMesh Prop
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: MultiProps
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FMultiProp> MultiProps
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FMultiProp>>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: MultiPropChance
        /// </summary>
        public unsafe float MultiPropChance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ComponentProperty: PropComp
        /// </summary>
        public unsafe BmSDK.Engine.SkeletalMeshComponent PropComp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ObjectProperty: SpecialXrayMat
        /// </summary>
        public unsafe BmSDK.Engine.MaterialInstance SpecialXrayMat
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstance>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ObjectProperty: SpecialXrayMatIC
        /// </summary>
        public unsafe BmSDK.Engine.MaterialInstanceConstant SpecialXrayMatIC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// ObjectProperty: SpecialThermalMat
        /// </summary>
        public unsafe BmSDK.Engine.MaterialInstance SpecialThermalMat
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstance>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// ObjectProperty: SpecialThermalMatIC
        /// </summary>
        public unsafe BmSDK.Engine.MaterialInstanceConstant SpecialThermalMatIC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: bDontAllowColorChange
        /// </summary>
        public unsafe bool bDontAllowColorChange
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// ObjectProperty: PropPhys
        /// </summary>
        public unsafe BmSDK.Engine.PhysicsAsset PropPhys
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicsAsset>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// NameProperty: SocketToAttachPropTo
        /// </summary>
        public unsafe BmSDK.FName SocketToAttachPropTo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// NameProperty: BoneToAttachPropTo
        /// </summary>
        public unsafe BmSDK.FName BoneToAttachPropTo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// NameProperty: PropGlobalFlagCheck
        /// </summary>
        public unsafe BmSDK.FName PropGlobalFlagCheck
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// BoolProperty: bRemovePropOnStrike
        /// </summary>
        public unsafe bool bRemovePropOnStrike
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }; }
        }

        /// <summary>
        /// BoolProperty: bRemovePropOnDeath
        /// </summary>
        public unsafe bool bRemovePropOnDeath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }; }
        }

        /// <summary>
        /// BoolProperty: bRemovedProp
        /// </summary>
        public unsafe bool bRemovedProp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }; }
        }

        /// <summary>
        /// BoolProperty: bUsesParentAnim
        /// </summary>
        public unsafe bool bUsesParentAnim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }; }
        }

        /// <summary>
        /// BoolProperty: bActivatePhysics
        /// </summary>
        public unsafe bool bActivatePhysics
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }; }
        }

        /// <summary>
        /// ByteProperty: ParentAnimComponentMode
        /// </summary>
        public unsafe BmSDK.Engine.RSkeletalMeshComponent_Export.EParentAnimComponentMode ParentAnimComponentMode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshComponent_Export.EParentAnimComponentMode>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// ObjectProperty: AnimTree
        /// </summary>
        public unsafe BmSDK.Engine.AnimTree AnimTree
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimTree>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// ArrayProperty: AnimSets
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> AnimSets
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// ClassProperty: RemovedPropClass
        /// </summary>
        public unsafe BmSDK.Class RemovedPropClass
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }

        /// <summary>
        /// ArrayProperty: SavedXrayMats
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInterface> SavedXrayMats
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInterface>>(Ptr + 100); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }; }
        }

        /// <summary>
        /// ArrayProperty: SavedThermalMats
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInterface> SavedThermalMats
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInterface>>(Ptr + 112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }; }
        }
    }

    /// <summary>
    /// Struct: FMultiProp
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FMultiProp
    {
        /// <summary>
        /// ObjectProperty: MultiProp
        /// </summary>
        public unsafe BmSDK.Engine.SkeletalMesh _MultiProp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ClassProperty: MultiPropRemovedPropClass
        /// </summary>
        public unsafe BmSDK.Class MultiPropRemovedPropClass
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ObjectProperty: SpecificMatToUse
        /// </summary>
        public unsafe BmSDK.Engine.MaterialInterface SpecificMatToUse
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// StructProperty: VfTable_IInterface_NavigationHandle
    /// </summary>
    public unsafe System.IntPtr VfTable_IInterface_NavigationHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2300); }
    }

    /// <summary>
    /// StructProperty: VfTable_IMGlitchesInterface
    /// </summary>
    public unsafe System.IntPtr VfTable_IMGlitchesInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }
    }

    /// <summary>
    /// ByteProperty: PhysWalkingType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.EPhysWalkingType PhysWalkingType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.EPhysWalkingType>(Ptr + 2308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2308); }
    }

    /// <summary>
    /// ByteProperty: TempPhysWalkingType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.EPhysWalkingType TempPhysWalkingType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.EPhysWalkingType>(Ptr + 2309); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2309); }
    }

    /// <summary>
    /// ByteProperty: Faction
    /// </summary>
    public unsafe BmSDK.BmGame.RChapterLineSet.EFaction Faction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RChapterLineSet.EFaction>(Ptr + 2310); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2310); }
    }

    /// <summary>
    /// ByteProperty: KOGameAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction KOGameAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 2311); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2311); }
    }

    /// <summary>
    /// ByteProperty: KOGameActionPred
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge KOGameActionPred
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge>(Ptr + 2312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2312); }
    }

    /// <summary>
    /// ByteProperty: DefaultHighlight
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI.ECharacterHighlightType DefaultHighlight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI.ECharacterHighlightType>(Ptr + 2313); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2313); }
    }

    /// <summary>
    /// ByteProperty: WeaponConfigType
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.EWeaponConfigType WeaponConfigType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.EWeaponConfigType>(Ptr + 2314); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2314); }
    }

    /// <summary>
    /// ByteProperty: StuckRagdollSolution
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI.StuckRagdollSolutionType StuckRagdollSolution
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI.StuckRagdollSolutionType>(Ptr + 2315); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2315); }
    }

    /// <summary>
    /// ByteProperty: CombatReadiness
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI.CombatReadinessState CombatReadiness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI.CombatReadinessState>(Ptr + 2316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2316); }
    }

    /// <summary>
    /// ByteProperty: ThugBarkType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EThugBarkType ThugBarkType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EThugBarkType>(Ptr + 2317); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2317); }
    }

    /// <summary>
    /// BoolProperty: bFallBackToNavMeshFloor
    /// </summary>
    public unsafe bool bFallBackToNavMeshFloor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bBlockOtherPawns
    /// </summary>
    public unsafe bool bBlockOtherPawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bFriendly
    /// </summary>
    public unsafe bool bFriendly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bCrowd
    /// </summary>
    public unsafe bool bCrowd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bKeepWeapon
    /// </summary>
    public unsafe bool bKeepWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: mIsPredatorPawn
    /// </summary>
    public unsafe bool mIsPredatorPawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: CanProcessSpottableAlerts
    /// </summary>
    public unsafe bool CanProcessSpottableAlerts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bBeingInterrogated
    /// </summary>
    public unsafe bool bBeingInterrogated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bIsTempTerrified
    /// </summary>
    public unsafe bool bIsTempTerrified
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bWasSilentTakedownTarget
    /// </summary>
    public unsafe bool bWasSilentTakedownTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bHasTerrifiedAura
    /// </summary>
    public unsafe bool bHasTerrifiedAura
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bRestrictedSpottableAlert
    /// </summary>
    public unsafe bool bRestrictedSpottableAlert
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bForceCheckVillains
    /// </summary>
    public unsafe bool bForceCheckVillains
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bCanSeeBatmanOnGargoyle
    /// </summary>
    public unsafe bool bCanSeeBatmanOnGargoyle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bIsLitePred
    /// </summary>
    public unsafe bool bIsLitePred
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bTriggerPredAlerts
    /// </summary>
    public unsafe bool bTriggerPredAlerts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bDoPredatorVision
    /// </summary>
    public unsafe bool bDoPredatorVision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bSniper
    /// </summary>
    public unsafe bool bSniper
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bCanPickupSniperRifleSniper
    /// </summary>
    public unsafe bool bCanPickupSniperRifleSniper
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bCombatMirrored
    /// </summary>
    public unsafe bool bCombatMirrored
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bCanBeDisarmedByMagBlast
    /// </summary>
    public unsafe bool bCanBeDisarmedByMagBlast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bMagneticBlastClingToWeapon
    /// </summary>
    public unsafe bool bMagneticBlastClingToWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bDodgedMagneticBlastDisarm
    /// </summary>
    public unsafe bool bDodgedMagneticBlastDisarm
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bInstantEnterCombatOnMagBlast
    /// </summary>
    public unsafe bool bInstantEnterCombatOnMagBlast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bApplySoftPawnCollision
    /// </summary>
    public unsafe bool bApplySoftPawnCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bReceiveSoftPawnCollision
    /// </summary>
    public unsafe bool bReceiveSoftPawnCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bDoPlayerCollision
    /// </summary>
    public unsafe bool bDoPlayerCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bApplyRouterPawnAvoidance
    /// </summary>
    public unsafe bool bApplyRouterPawnAvoidance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bTickGunFire
    /// </summary>
    public unsafe bool bTickGunFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bFireOnceOnly
    /// </summary>
    public unsafe bool bFireOnceOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bForceBehaviourTickEveryFrame
    /// </summary>
    public unsafe bool bForceBehaviourTickEveryFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bWeaponCanBePickedUp
    /// </summary>
    public unsafe bool bWeaponCanBePickedUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2320); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2320); }
    }

    /// <summary>
    /// BoolProperty: bWeaponCanBePickedUpOnlyBySelf
    /// </summary>
    public unsafe bool bWeaponCanBePickedUpOnlyBySelf
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bWeaponWasJammed
    /// </summary>
    public unsafe bool bWeaponWasJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bDisableCornerSliding
    /// </summary>
    public unsafe bool bDisableCornerSliding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bAttackASAP
    /// </summary>
    public unsafe bool bAttackASAP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bHostile
    /// </summary>
    public unsafe bool bHostile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bForceConstantGroundChecks
    /// </summary>
    public unsafe bool bForceConstantGroundChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bFleeASAP
    /// </summary>
    public unsafe bool bFleeASAP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bPostFleeIdleASAP
    /// </summary>
    public unsafe bool bPostFleeIdleASAP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bWanderingAI
    /// </summary>
    public unsafe bool bWanderingAI
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bDontShowPredatorEscapeInstructions
    /// </summary>
    public unsafe bool bDontShowPredatorEscapeInstructions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bTriggerBatarangCamera
    /// </summary>
    public unsafe bool bTriggerBatarangCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bDisallowQuickTakedowns
    /// </summary>
    public unsafe bool bDisallowQuickTakedowns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bFadeOutAfterDeath
    /// </summary>
    public unsafe bool bFadeOutAfterDeath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bStreamWeapon
    /// </summary>
    public unsafe bool bStreamWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bIsHostage
    /// </summary>
    public unsafe bool bIsHostage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bHasTimeSlice
    /// </summary>
    public unsafe bool bHasTimeSlice
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysHasTimeSlice
    /// </summary>
    public unsafe bool bAlwaysHasTimeSlice
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bHasInformantBeenScanned
    /// </summary>
    public unsafe bool bHasInformantBeenScanned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bCanBeXrayed
    /// </summary>
    public unsafe bool bCanBeXrayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bCanUseGunLightInPredatorRooms
    /// </summary>
    public unsafe bool bCanUseGunLightInPredatorRooms
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bBatarangCanKill
    /// </summary>
    public unsafe bool bBatarangCanKill
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bBatarangCantTarget
    /// </summary>
    public unsafe bool bBatarangCantTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bDontReactToBatarang
    /// </summary>
    public unsafe bool bDontReactToBatarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysDodgeBatarang
    /// </summary>
    public unsafe bool bAlwaysDodgeBatarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bForceBatarangMirror
    /// </summary>
    public unsafe bool bForceBatarangMirror
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bHarpoonCantTarget
    /// </summary>
    public unsafe bool bHarpoonCantTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bDontReactToHarpoon
    /// </summary>
    public unsafe bool bDontReactToHarpoon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bRemoteClawCantTarget
    /// </summary>
    public unsafe bool bRemoteClawCantTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bReallyDead
    /// </summary>
    public unsafe bool bReallyDead
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bUseRealNameForInvestigate
    /// </summary>
    public unsafe bool bUseRealNameForInvestigate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: bIsCaucassian
    /// </summary>
    public unsafe bool bIsCaucassian
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: IsAIvsAICombatant
    /// </summary>
    public unsafe bool IsAIvsAICombatant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2324); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2324); }
    }

    /// <summary>
    /// BoolProperty: IsAIvsAIKilled
    /// </summary>
    public unsafe bool IsAIvsAIKilled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: IsAIvsAICanIgnoreBatman
    /// </summary>
    public unsafe bool IsAIvsAICanIgnoreBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: mShouldIgnoreHitReaction
    /// </summary>
    public unsafe bool mShouldIgnoreHitReaction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bFiring
    /// </summary>
    public unsafe bool bFiring
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bFiringBurst
    /// </summary>
    public unsafe bool bFiringBurst
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bStopAfterBurst
    /// </summary>
    public unsafe bool bStopAfterBurst
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bHasBuiltInGun
    /// </summary>
    public unsafe bool bHasBuiltInGun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bInDialogue
    /// </summary>
    public unsafe bool bInDialogue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bICSuspendStasis
    /// </summary>
    public unsafe bool bICSuspendStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bICForceStasis
    /// </summary>
    public unsafe bool bICForceStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bAllowActionTick
    /// </summary>
    public unsafe bool bAllowActionTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bActionTickActive
    /// </summary>
    public unsafe bool bActionTickActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bActionCustomEyeLocation
    /// </summary>
    public unsafe bool bActionCustomEyeLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bIsRescueTarget
    /// </summary>
    public unsafe bool bIsRescueTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bShowRouterBlockedInfo
    /// </summary>
    public unsafe bool bShowRouterBlockedInfo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bStrungUp
    /// </summary>
    public unsafe bool bStrungUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bRemoteClawed
    /// </summary>
    public unsafe bool bRemoteClawed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bDoPostCutNotify
    /// </summary>
    public unsafe bool bDoPostCutNotify
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bHasContributedToFearLevel
    /// </summary>
    public unsafe bool bHasContributedToFearLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bStrungUpBark
    /// </summary>
    public unsafe bool bStrungUpBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bInterrogateable
    /// </summary>
    public unsafe bool bInterrogateable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bDontTriggerDynamicTutorial
    /// </summary>
    public unsafe bool bDontTriggerDynamicTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bCanInterrogateFromFront
    /// </summary>
    public unsafe bool bCanInterrogateFromFront
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bShownInterrogationTutorial
    /// </summary>
    public unsafe bool bShownInterrogationTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bCreatedInterrogateSpriteMat
    /// </summary>
    public unsafe bool bCreatedInterrogateSpriteMat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bIsPickPocketTarget
    /// </summary>
    public unsafe bool bIsPickPocketTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bIsNearThugMine
    /// </summary>
    public unsafe bool bIsNearThugMine
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bLoadingPreferredBarkset
    /// </summary>
    public unsafe bool bLoadingPreferredBarkset
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bSuspendCombatStasis
    /// </summary>
    public unsafe bool bSuspendCombatStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bForceCombatTaunt
    /// </summary>
    public unsafe bool bForceCombatTaunt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: JustClimbedLadder
    /// </summary>
    public unsafe bool JustClimbedLadder
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bArmoured
    /// </summary>
    public unsafe bool bArmoured
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2328); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2328); }
    }

    /// <summary>
    /// BoolProperty: bCanCombatBark
    /// </summary>
    public unsafe bool bCanCombatBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2332) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2332); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2332); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysBlockDuringHitReaction
    /// </summary>
    public unsafe bool bAlwaysBlockDuringHitReaction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2332) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2332); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2332); }
    }

    /// <summary>
    /// BoolProperty: bLaughing
    /// </summary>
    public unsafe bool bLaughing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2332) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2332); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2332); }
    }

    /// <summary>
    /// BoolProperty: bBlinded
    /// </summary>
    public unsafe bool bBlinded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2332) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2332); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2332); }
    }

    /// <summary>
    /// BoolProperty: bCrouching
    /// </summary>
    public unsafe bool bCrouching
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2332) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2332); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2332); }
    }

    /// <summary>
    /// BoolProperty: IsGrabbed
    /// </summary>
    public unsafe bool IsGrabbed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2332) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2332); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2332); }
    }

    /// <summary>
    /// BoolProperty: mIsEnabled
    /// </summary>
    public unsafe bool mIsEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2332) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2332); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2332); }
    }

    /// <summary>
    /// BoolProperty: mIsMaterialEnabled
    /// </summary>
    public unsafe bool mIsMaterialEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2332) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2332); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2332); }
    }

    /// <summary>
    /// BoolProperty: mIsParticleEnabled
    /// </summary>
    public unsafe bool mIsParticleEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2332) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2332); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2332); }
    }

    /// <summary>
    /// BoolProperty: mCurrentlyActivated
    /// </summary>
    public unsafe bool mCurrentlyActivated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2332) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2332); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2332); }
    }

    /// <summary>
    /// StructProperty: SearchExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SearchExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2336);

    /// <summary>
    /// StructProperty: TerrifiedSearchExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TerrifiedSearchExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2348);

    /// <summary>
    /// ArrayProperty: NavHandleList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RNavigationHandle> NavHandleList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RNavigationHandle>>(Ptr + 2360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2360); }
    }

    /// <summary>
    /// ObjectProperty: CurrNavHandle
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle CurrNavHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 2372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2372); }
    }

    /// <summary>
    /// ObjectProperty: Spawner
    /// </summary>
    public unsafe BmSDK.GameObject Spawner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 2376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2376); }
    }

    /// <summary>
    /// ComponentProperty: RoomState
    /// </summary>
    public unsafe BmSDK.BmGame.RBMRoomAIState RoomState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMRoomAIState>(Ptr + 2380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2380); }
    }

    /// <summary>
    /// FloatProperty: TempTerrifedTimeout
    /// </summary>
    public unsafe float TempTerrifedTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2384); }
    }

    /// <summary>
    /// ObjectProperty: LastMagBlastReceiver
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticBlastReceiver LastMagBlastReceiver
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticBlastReceiver>(Ptr + 2388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2388); }
    }

    /// <summary>
    /// StructProperty: SoftPawnCollisionVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SoftPawnCollisionVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2392);

    /// <summary>
    /// NameProperty: NotHostileReason
    /// </summary>
    public unsafe BmSDK.FName NotHostileReason
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2404); }
    }

    /// <summary>
    /// IntProperty: ForceGroundChecks
    /// </summary>
    public unsafe int ForceGroundChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2412); }
    }

    /// <summary>
    /// FloatProperty: InstantSightRange
    /// </summary>
    public unsafe float InstantSightRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2416); }
    }

    /// <summary>
    /// FloatProperty: FocusedSightRange
    /// </summary>
    public unsafe float FocusedSightRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2420); }
    }

    /// <summary>
    /// FloatProperty: FocusedVisionRadius
    /// </summary>
    public unsafe float FocusedVisionRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2424); }
    }

    /// <summary>
    /// FloatProperty: PeripheralSightRange
    /// </summary>
    public unsafe float PeripheralSightRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2428); }
    }

    /// <summary>
    /// FloatProperty: ExtendedSightRange
    /// </summary>
    public unsafe float ExtendedSightRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2432); }
    }

    /// <summary>
    /// StructProperty: PrevFloorNormal
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PrevFloorNormal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2436);

    /// <summary>
    /// StrProperty: ForceDeathTip
    /// </summary>
    public unsafe BmSDK.FString ForceDeathTip
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2448); }
    }

    /// <summary>
    /// ClassProperty: WeaponType
    /// </summary>
    public unsafe BmSDK.Class WeaponType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 2460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2460); }
    }

    /// <summary>
    /// ObjectProperty: AlternateAnimAndWeap
    /// </summary>
    public unsafe BmSDK.BmGame.RAlternateAnimationAndWeaponConfig AlternateAnimAndWeap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAlternateAnimationAndWeaponConfig>(Ptr + 2464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2464); }
    }

    /// <summary>
    /// ObjectProperty: CurrWeapon
    /// </summary>
    public unsafe BmSDK.BmGame.RBMWeapon CurrWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMWeapon>(Ptr + 2468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2468); }
    }

    /// <summary>
    /// ObjectProperty: CurrDroppedWeapon
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatThrownObject CurrDroppedWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatThrownObject>(Ptr + 2472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2472); }
    }

    /// <summary>
    /// StructProperty: HitReactionWeaponSwitchThrowImpulse
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HitReactionWeaponSwitchThrowImpulse
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2476);

    /// <summary>
    /// ObjectProperty: CharactersType
    /// </summary>
    public unsafe BmSDK.BmGame.RCharacter CharactersType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCharacter>(Ptr + 2488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2488); }
    }

    /// <summary>
    /// FloatProperty: DeathTimer
    /// </summary>
    public unsafe float DeathTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2492); }
    }

    /// <summary>
    /// ArrayProperty: DeathMat
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> DeathMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 2496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2496); }
    }

    /// <summary>
    /// FloatProperty: DeathFadePause
    /// </summary>
    public unsafe float DeathFadePause
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2508); }
    }

    /// <summary>
    /// FloatProperty: DeathFadeDuration
    /// </summary>
    public unsafe float DeathFadeDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2512); }
    }

    /// <summary>
    /// StructProperty: CachedCylinderExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CachedCylinderExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2516);

    /// <summary>
    /// ObjectProperty: StreamedWeaponRefHolder
    /// </summary>
    public unsafe BmSDK.BmGame.RCharacterBioCue StreamedWeaponRefHolder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCharacterBioCue>(Ptr + 2528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2528); }
    }

    /// <summary>
    /// StrProperty: WeaponPackageToLoadBeforeSpawn
    /// </summary>
    public unsafe BmSDK.FString WeaponPackageToLoadBeforeSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2532); }
    }

    /// <summary>
    /// FloatProperty: MaxBumpedTimer
    /// </summary>
    public unsafe float MaxBumpedTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2544); }
    }

    /// <summary>
    /// ComponentProperty: BreathFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent BreathFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 2548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2548); }
    }

    /// <summary>
    /// ObjectProperty: EmitterVFXInstance
    /// </summary>
    public unsafe BmSDK.Engine.Emitter EmitterVFXInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Emitter>(Ptr + 2552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2552); }
    }

    /// <summary>
    /// NameProperty: CowerStance
    /// </summary>
    public unsafe BmSDK.FName CowerStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2556); }
    }

    /// <summary>
    /// FloatProperty: AtGoalDistanceError
    /// </summary>
    public unsafe float AtGoalDistanceError
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2564); }
    }

    /// <summary>
    /// ArrayProperty: PropStatics
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FCharacterStaticProps> PropStatics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FCharacterStaticProps>>(Ptr + 2568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2568); }
    }

    /// <summary>
    /// ArrayProperty: PropSkeletals
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FCharacterSkeletalProps> PropSkeletals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FCharacterSkeletalProps>>(Ptr + 2580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2580); }
    }

    /// <summary>
    /// StructProperty: PropLightingChannels
    /// </summary>
    public unsafe ref BmSDK.Engine.LightComponent.FLightingChannelContainer PropLightingChannels
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.LightComponent.FLightingChannelContainer>(Ptr + 2592);

    /// <summary>
    /// IntProperty: OverrideKOXP
    /// </summary>
    public unsafe int OverrideKOXP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2596); }
    }

    /// <summary>
    /// ClassProperty: CombatBehaviourClass
    /// </summary>
    public unsafe BmSDK.Class CombatBehaviourClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 2600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }
    }

    /// <summary>
    /// ObjectProperty: PredTakedownAttackedAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PredTakedownAttackedAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 2604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2604); }
    }

    /// <summary>
    /// ObjectProperty: PredTakedownAttackerAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PredTakedownAttackerAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 2608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }
    }

    /// <summary>
    /// ArrayProperty: BatarangTargetBodyParts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BatarangTargetBodyParts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 2612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2612); }
    }

    /// <summary>
    /// ArrayProperty: WhipTargetBodyParts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> WhipTargetBodyParts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }

    /// <summary>
    /// IntProperty: HeartBeatType
    /// </summary>
    public unsafe int HeartBeatType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2636); }
    }

    /// <summary>
    /// IntProperty: OverrideHeartBeatType
    /// </summary>
    public unsafe int OverrideHeartBeatType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2640); }
    }

    /// <summary>
    /// StrProperty: RealNameForInvestigate
    /// </summary>
    public unsafe BmSDK.FString RealNameForInvestigate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2644); }
    }

    /// <summary>
    /// NameProperty: SpineName
    /// </summary>
    public unsafe BmSDK.FName SpineName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2656); }
    }

    /// <summary>
    /// ObjectProperty: EntryAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet EntryAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 2664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2664); }
    }

    /// <summary>
    /// NameProperty: EntryAnim
    /// </summary>
    public unsafe BmSDK.FName EntryAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2668); }
    }

    /// <summary>
    /// ObjectProperty: LastFloorPanel
    /// </summary>
    public unsafe BmSDK.BmGame.RElectrifiedFloorPanel LastFloorPanel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RElectrifiedFloorPanel>(Ptr + 2676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2676); }
    }

    /// <summary>
    /// FloatProperty: LastFireTime
    /// </summary>
    public unsafe float LastFireTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2680); }
    }

    /// <summary>
    /// FloatProperty: fireTimer
    /// </summary>
    public unsafe float fireTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2684); }
    }

    /// <summary>
    /// ObjectProperty: CurrentGun
    /// </summary>
    public unsafe BmSDK.BmGame.RBMWeaponRanged CurrentGun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMWeaponRanged>(Ptr + 2688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2688); }
    }

    /// <summary>
    /// IntProperty: BurstCount
    /// </summary>
    public unsafe int BurstCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2692); }
    }

    /// <summary>
    /// IntProperty: ClipCount
    /// </summary>
    public unsafe int ClipCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2696); }
    }

    /// <summary>
    /// FloatProperty: GunMomentumTime
    /// </summary>
    public unsafe float GunMomentumTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2700); }
    }

    /// <summary>
    /// StructProperty: GunMomentumDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GunMomentumDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2704);

    /// <summary>
    /// ArrayProperty: GunTargetBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.GunTargetBoneState> GunTargetBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.GunTargetBoneState>>(Ptr + 2716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2716); }
    }

    /// <summary>
    /// ObjectProperty: GlanceTarget
    /// </summary>
    public unsafe BmSDK.BmGame.AlertInstance GlanceTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.AlertInstance>(Ptr + 2728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2728); }
    }

    /// <summary>
    /// FloatProperty: BeenStartledTimer
    /// </summary>
    public unsafe float BeenStartledTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2732); }
    }

    /// <summary>
    /// ObjectProperty: StasisLinkPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI StasisLinkPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 2736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2736); }
    }

    /// <summary>
    /// FloatProperty: OverrideStasisDist
    /// </summary>
    public unsafe float OverrideStasisDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2740); }
    }

    /// <summary>
    /// ObjectProperty: GrappleGun
    /// </summary>
    public unsafe BmSDK.BmGame.RGrappleGun GrappleGun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrappleGun>(Ptr + 2744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2744); }
    }

    /// <summary>
    /// ArrayProperty: Queue
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMAIAction> Queue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMAIAction>>(Ptr + 2748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2748); }
    }

    /// <summary>
    /// ObjectProperty: ClientAction
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIAction ClientAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIAction>(Ptr + 2760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2760); }
    }

    /// <summary>
    /// ArrayProperty: MoveToTargetList
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> MoveToTargetList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 2764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2764); }
    }

    /// <summary>
    /// StructProperty: MoveToTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MoveToTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2776);

    /// <summary>
    /// IntProperty: CreationRand1
    /// </summary>
    public unsafe int CreationRand1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2788); }
    }

    /// <summary>
    /// IntProperty: CreationRand2
    /// </summary>
    public unsafe int CreationRand2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2792); }
    }

    /// <summary>
    /// IntProperty: CreationRand3
    /// </summary>
    public unsafe int CreationRand3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2796); }
    }

    /// <summary>
    /// IntProperty: CreationRand4
    /// </summary>
    public unsafe int CreationRand4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2800); }
    }

    /// <summary>
    /// IntProperty: CreationRand5
    /// </summary>
    public unsafe int CreationRand5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2804); }
    }

    /// <summary>
    /// StructProperty: LastValidNavMeshPoly
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMPawnAI.FValidNavMeshPoly LastValidNavMeshPoly
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMPawnAI.FValidNavMeshPoly>(Ptr + 2808);

    /// <summary>
    /// ObjectProperty: ArmouredThugMagnetisedAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet ArmouredThugMagnetisedAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 2828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2828); }
    }

    /// <summary>
    /// StructProperty: RouterBlockedPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RouterBlockedPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2832);

    /// <summary>
    /// StructProperty: RouterBlockedNewPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RouterBlockedNewPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2844);

    /// <summary>
    /// StructProperty: RouterBlockedDestination
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RouterBlockedDestination
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2856);

    /// <summary>
    /// StructProperty: RouterBlockedSnappedDestination
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RouterBlockedSnappedDestination
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2868);

    /// <summary>
    /// StructProperty: RouterBlockedExtents
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RouterBlockedExtents
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2880);

    /// <summary>
    /// ArrayProperty: AlwaysOnPS
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FAlwaysOnParticles> AlwaysOnPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FAlwaysOnParticles>>(Ptr + 2892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2892); }
    }

    /// <summary>
    /// FloatProperty: CurrDestZ
    /// </summary>
    public unsafe float CurrDestZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2904); }
    }

    /// <summary>
    /// FloatProperty: ZBlendSpeed
    /// </summary>
    public unsafe float ZBlendSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2908); }
    }

    /// <summary>
    /// ArrayProperty: CombatIdleStances
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CombatIdleStances
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 2912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2912); }
    }

    /// <summary>
    /// IntProperty: CombatIdleStanceID
    /// </summary>
    public unsafe int CombatIdleStanceID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2924); }
    }

    /// <summary>
    /// StructProperty: HangGrabLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HangGrabLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2928);

    /// <summary>
    /// NameProperty: RagdollRestTestBone
    /// </summary>
    public unsafe BmSDK.FName RagdollRestTestBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2940); }
    }

    /// <summary>
    /// StructProperty: HangRopeEndLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HangRopeEndLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2948);

    /// <summary>
    /// ObjectProperty: RelatedHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint RelatedHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 2960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2960); }
    }

    /// <summary>
    /// ArrayProperty: BarkSet
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBarkSet> BarkSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkSet>>(Ptr + 2964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2964); }
    }

    /// <summary>
    /// FloatProperty: LinearRestThreshold
    /// </summary>
    public unsafe float LinearRestThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2976); }
    }

    /// <summary>
    /// FloatProperty: AngularRestThreshold
    /// </summary>
    public unsafe float AngularRestThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2980); }
    }

    /// <summary>
    /// FloatProperty: StoredCasPosTime
    /// </summary>
    public unsafe float StoredCasPosTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2984); }
    }

    /// <summary>
    /// StructProperty: StoredCasPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StoredCasPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2988);

    /// <summary>
    /// IntProperty: InterrogationTrack
    /// </summary>
    public unsafe int InterrogationTrack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3000); }
    }

    /// <summary>
    /// ObjectProperty: InterrogationAura
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstance InterrogationAura
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstance>(Ptr + 3004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3004); }
    }

    /// <summary>
    /// ObjectProperty: InterrogationEvent
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqEvent_StartInterrogation InterrogationEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqEvent_StartInterrogation>(Ptr + 3008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3008); }
    }

    /// <summary>
    /// ObjectProperty: InterrogationAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_PlaySpeechCombined InterrogationAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_PlaySpeechCombined>(Ptr + 3012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3012); }
    }

    /// <summary>
    /// StrProperty: InterrogationPackageName
    /// </summary>
    public unsafe BmSDK.FString InterrogationPackageName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3016); }
    }

    /// <summary>
    /// StrProperty: InterrogationPackageNameNoneLeft
    /// </summary>
    public unsafe BmSDK.FString InterrogationPackageNameNoneLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3028); }
    }

    /// <summary>
    /// IntProperty: InterrogationTrackNoneLeft
    /// </summary>
    public unsafe int InterrogationTrackNoneLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3040); }
    }

    /// <summary>
    /// FloatProperty: InterrogateTutorialTime
    /// </summary>
    public unsafe float InterrogateTutorialTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3044); }
    }

    /// <summary>
    /// NameProperty: AerialAttackAnimName
    /// </summary>
    public unsafe BmSDK.FName AerialAttackAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 3048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3048); }
    }

    /// <summary>
    /// FloatProperty: MaxHealth
    /// </summary>
    public unsafe float MaxHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3056); }
    }

    /// <summary>
    /// StructProperty: LastBeatdownInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMPawnAI.FBeatdownInfo LastBeatdownInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMPawnAI.FBeatdownInfo>(Ptr + 3060);

    /// <summary>
    /// ArrayProperty: PreferredBarkSet
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBarkSet> PreferredBarkSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkSet>>(Ptr + 3076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3076); }
    }

    /// <summary>
    /// ArrayProperty: LoadBarkSetString
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> LoadBarkSetString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 3088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3088); }
    }

    /// <summary>
    /// StrProperty: LoadingBarkSetPackage
    /// </summary>
    public unsafe BmSDK.FString LoadingBarkSetPackage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3100); }
    }

    /// <summary>
    /// StructProperty: AvoidanceLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AvoidanceLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3112);

    /// <summary>
    /// ObjectProperty: MyLevelVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RLevelVolume MyLevelVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLevelVolume>(Ptr + 3124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3124); }
    }

    /// <summary>
    /// ObjectProperty: OverrideTargetPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat OverrideTargetPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 3128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3128); }
    }

    /// <summary>
    /// ObjectProperty: TargetPlayer
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat TargetPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 3132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3132); }
    }

    /// <summary>
    /// IntProperty: mnNextEvadeTicks
    /// </summary>
    public unsafe int mnNextEvadeTicks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3136); }
    }

    /// <summary>
    /// StructProperty: mvDangerOrigin
    /// </summary>
    public unsafe ref System.Numerics.Vector3 mvDangerOrigin
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3140);

    /// <summary>
    /// StructProperty: mvDangerDirection
    /// </summary>
    public unsafe ref System.Numerics.Vector3 mvDangerDirection
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3152);

    /// <summary>
    /// IntProperty: CurrentThugId
    /// </summary>
    public unsafe int CurrentThugId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3164); }
    }

    /// <summary>
    /// InterfaceProperty: mPrevGlitches
    /// </summary>
    public unsafe BmSDK.BmGame.MGlitchesInterface mPrevGlitches
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGlitchesInterface>(Ptr + 3168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3168); }
    }

    /// <summary>
    /// InterfaceProperty: mNextGlitches
    /// </summary>
    public unsafe BmSDK.BmGame.MGlitchesInterface mNextGlitches
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGlitchesInterface>(Ptr + 3176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3176); }
    }

    /// <summary>
    /// FloatProperty: mTimeToSwitch
    /// </summary>
    public unsafe float mTimeToSwitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3184); }
    }

    /// <summary>
    /// ObjectProperty: mSpecificMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface mSpecificMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 3188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3188); }
    }

    /// <summary>
    /// ObjectProperty: mSpecificGlitchSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent mSpecificGlitchSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 3192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3192); }
    }

    /// <summary>
    /// ObjectProperty: mSpecificTransitSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent mSpecificTransitSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 3196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3196); }
    }

    /// <summary>
    /// ObjectProperty: mOverrideParticle
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem mOverrideParticle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3200); }
    }

    /// <summary>
    /// ObjectProperty: mEmitterVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem mEmitterVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3204); }
    }

    /// <summary>
    /// FloatProperty: mTransitionSpeed
    /// </summary>
    public unsafe float mTransitionSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3208); }
    }

    /// <summary>
    /// IntProperty: mMaxLoopCount
    /// </summary>
    public unsafe int mMaxLoopCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3212); }
    }

    /// <summary>
    /// StructProperty: mGlitchOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 mGlitchOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3216);

    /// <summary>
    /// ObjectProperty: mGlitchCont
    /// </summary>
    public unsafe BmSDK.BmGame.MGlitchesController mGlitchCont
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGlitchesController>(Ptr + 3228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3228); }
    }

    /// <summary>
    /// FloatProperty: mCurrentTimeToSwitch
    /// </summary>
    public unsafe float mCurrentTimeToSwitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3232); }
    }

    /// <summary>
    /// IntProperty: mLoopCount
    /// </summary>
    public unsafe int mLoopCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3236); }
    }

    /// <summary>
    /// ArrayProperty: mRefMaterial
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInterface> mRefMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInterface>>(Ptr + 3240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3240); }
    }

    /// <summary>
    /// StructProperty: mGlitchSnd
    /// </summary>
    public unsafe ref BmSDK.Engine.AkWwise.FAkSoundHandle mGlitchSnd
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 3252);

    /// <summary>
    /// StructProperty: mTransitSnd
    /// </summary>
    public unsafe ref BmSDK.Engine.AkWwise.FAkSoundHandle mTransitSnd
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 3264);

    /// <summary>
    /// ComponentProperty: mTransitionParticle
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent mTransitionParticle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3276); }
    }

    /// <summary>
    /// StructProperty: mStartPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 mStartPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3280);

    /// <summary>
    /// StructProperty: mEndPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 mEndPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3292);

    /// <summary>
    /// StructProperty: mBeamDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 mBeamDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3304);

    /// <summary>
    /// FloatProperty: mBeamCurrentLength
    /// </summary>
    public unsafe float mBeamCurrentLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3316); }
    }
}
