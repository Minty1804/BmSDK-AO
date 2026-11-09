#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieHudExtendable<br/>
/// (size = 724)
/// (flags = 134217878)
/// </summary>
public partial class RGFxMovieHudExtendable : BmSDK.BmGame.RGFxMovie, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieHudExtendable", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieHudExtendable.
    /// </summary>
    public static RGFxMovieHudExtendable DefaultObject => (RGFxMovieHudExtendable)StaticClass().DefaultObject;

    internal RGFxMovieHudExtendable() { }

    /// <summary>
    /// Constructs a new RGFxMovieHudExtendable
    /// </summary>
    public RGFxMovieHudExtendable(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieHudExtendable Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieHudExtendable(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieHudExtendable>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieHudExtendable>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieHudExtendable>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieHudExtendable>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieHudExtendable>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieHudExtendable>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieHudExtendable>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieHudExtendable>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SummaryXPDone;
    /// <summary>
    /// Function: SummaryXPDone
    /// </summary>
    public unsafe virtual void SummaryXPDone()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SummaryXPDone, "BmGame.RGFxMovieHudExtendable.SummaryXPDone");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LevelUp;
    /// <summary>
    /// Function: LevelUp
    /// </summary>
    public unsafe virtual void LevelUp(int Current, int Level, int Duration)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LevelUp, "BmGame.RGFxMovieHudExtendable.LevelUp");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Current, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Level, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CashInXPDone;
    /// <summary>
    /// Function: CashInXPDone
    /// </summary>
    public unsafe virtual void CashInXPDone(int Amount, int Duration)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CashInXPDone, "BmGame.RGFxMovieHudExtendable.CashInXPDone");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Amount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CashInXP;
    /// <summary>
    /// Function: CashInXP
    /// </summary>
    public unsafe virtual void CashInXP(int Current, int Level, int Duration)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CashInXP, "BmGame.RGFxMovieHudExtendable.CashInXP");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Current, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Level, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInfoText;
    /// <summary>
    /// Function: SetInfoText
    /// </summary>
    public unsafe virtual void SetInfoText(BmSDK.FString Label, BmSDK.BmGame.RGFxMovieHudExtendable.JustifyText Justification, int TextColour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInfoText, "BmGame.RGFxMovieHudExtendable.SetInfoText");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Justification, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TextColour, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetClockTimer;
    /// <summary>
    /// Function: SetClockTimer
    /// </summary>
    public unsafe virtual void SetClockTimer(BmSDK.FString Text, bool bVisible, bool bWarning)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetClockTimer, "BmGame.RGFxMovieHudExtendable.SetClockTimer");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWarning, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReFetchAndBuildPrompts;
    /// <summary>
    /// Function: ReFetchAndBuildPrompts
    /// </summary>
    public unsafe virtual void ReFetchAndBuildPrompts()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReFetchAndBuildPrompts, "BmGame.RGFxMovieHudExtendable.ReFetchAndBuildPrompts");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RebuildPrompts;
    /// <summary>
    /// Function: RebuildPrompts
    /// </summary>
    public unsafe virtual void RebuildPrompts()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RebuildPrompts, "BmGame.RGFxMovieHudExtendable.RebuildPrompts");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMainPrompt;
    /// <summary>
    /// Function: SetMainPrompt
    /// </summary>
    public unsafe virtual void SetMainPrompt(int Id, BmSDK.FString Label, float Alpha, float TextAlpha, bool Hammering = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMainPrompt, "BmGame.RGFxMovieHudExtendable.SetMainPrompt");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Alpha, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TextAlpha, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Hammering, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPrompt;
    /// <summary>
    /// Function: SetPrompt
    /// </summary>
    public unsafe virtual void SetPrompt(int Id, BmSDK.FString Label, float Alpha, float TextAlpha, bool Hammering = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPrompt, "BmGame.RGFxMovieHudExtendable.SetPrompt");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Label, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Alpha, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TextAlpha, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Hammering, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReLayoutPrompts;
    /// <summary>
    /// Function: ReLayoutPrompts
    /// </summary>
    public unsafe virtual void ReLayoutPrompts()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReLayoutPrompts, "BmGame.RGFxMovieHudExtendable.ReLayoutPrompts");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPrompts, "BmGame.RGFxMovieHudExtendable.ClearPrompts");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DefaultCursorDepth;
    /// <summary>
    /// Function: DefaultCursorDepth
    /// </summary>
    public unsafe static float DefaultCursorDepth()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DefaultCursorDepth, "BmGame.RGFxMovieHudExtendable.DefaultCursorDepth");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AdvanceState;
    /// <summary>
    /// Function: AdvanceState
    /// </summary>
    public unsafe virtual void AdvanceState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdvanceState, "BmGame.RGFxMovieHudExtendable.AdvanceState");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCloseDeathstrokeHUD;
    /// <summary>
    /// Function: OnCloseDeathstrokeHUD
    /// </summary>
    public unsafe virtual void OnCloseDeathstrokeHUD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCloseDeathstrokeHUD, "BmGame.RGFxMovieHudExtendable.OnCloseDeathstrokeHUD");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCloseShockGlovesEnergy;
    /// <summary>
    /// Function: OnCloseShockGlovesEnergy
    /// </summary>
    public unsafe virtual void OnCloseShockGlovesEnergy()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCloseShockGlovesEnergy, "BmGame.RGFxMovieHudExtendable.OnCloseShockGlovesEnergy");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCloseDownloadingCodes;
    /// <summary>
    /// Function: OnCloseDownloadingCodes
    /// </summary>
    public unsafe virtual void OnCloseDownloadingCodes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCloseDownloadingCodes, "BmGame.RGFxMovieHudExtendable.OnCloseDownloadingCodes");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCloseExtraHUD;
    /// <summary>
    /// Function: OnCloseExtraHUD
    /// </summary>
    public unsafe virtual void OnCloseExtraHUD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCloseExtraHUD, "BmGame.RGFxMovieHudExtendable.OnCloseExtraHUD");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceShowMap;
    /// <summary>
    /// Function: ForceShowMap
    /// </summary>
    public unsafe virtual void ForceShowMap(BmSDK.FString ObjectParam)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceShowMap, "BmGame.RGFxMovieHudExtendable.ForceShowMap");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectParam, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ObjectivesPromptCallback;
    /// <summary>
    /// Function: ObjectivesPromptCallback
    /// </summary>
    public unsafe virtual BmSDK.FString ObjectivesPromptCallback(BmSDK.FString KeyType, float Duration)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ObjectivesPromptCallback, "BmGame.RGFxMovieHudExtendable.ObjectivesPromptCallback");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ObjectivesCallback_PulseCompassIndicator;
    /// <summary>
    /// Function: ObjectivesCallback_PulseCompassIndicator
    /// </summary>
    public unsafe virtual void ObjectivesCallback_PulseCompassIndicator()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ObjectivesCallback_PulseCompassIndicator, "BmGame.RGFxMovieHudExtendable.ObjectivesCallback_PulseCompassIndicator");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EvidenceItemIdentified;
    /// <summary>
    /// Function: EvidenceItemIdentified
    /// </summary>
    public unsafe virtual void EvidenceItemIdentified()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EvidenceItemIdentified, "BmGame.RGFxMovieHudExtendable.EvidenceItemIdentified");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EvidenceScanClose;
    /// <summary>
    /// Function: EvidenceScanClose
    /// </summary>
    public unsafe virtual void EvidenceScanClose()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EvidenceScanClose, "BmGame.RGFxMovieHudExtendable.EvidenceScanClose");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMovieFocus;
    /// <summary>
    /// Function: SetMovieFocus
    /// </summary>
    public unsafe virtual void SetMovieFocus(bool State)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMovieFocus, "BmGame.RGFxMovieHudExtendable.SetMovieFocus");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(State, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EvidenceScanned;
    /// <summary>
    /// Function: EvidenceScanned
    /// </summary>
    public unsafe virtual void EvidenceScanned()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EvidenceScanned, "BmGame.RGFxMovieHudExtendable.EvidenceScanned");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EvidenceScannedCompleted;
    /// <summary>
    /// Function: EvidenceScannedCompleted
    /// </summary>
    public unsafe virtual void EvidenceScannedCompleted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EvidenceScannedCompleted, "BmGame.RGFxMovieHudExtendable.EvidenceScannedCompleted");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ScannerPercentageUpdate;
    /// <summary>
    /// Function: ScannerPercentageUpdate
    /// </summary>
    public unsafe virtual void ScannerPercentageUpdate(int NewCompletionPercentage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScannerPercentageUpdate, "BmGame.RGFxMovieHudExtendable.ScannerPercentageUpdate");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCompletionPercentage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ScannerScanComplete;
    /// <summary>
    /// Function: ScannerScanComplete
    /// </summary>
    public unsafe virtual void ScannerScanComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScannerScanComplete, "BmGame.RGFxMovieHudExtendable.ScannerScanComplete");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ContentsTicked;
    /// <summary>
    /// Function: ContentsTicked
    /// </summary>
    public unsafe virtual void ContentsTicked()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ContentsTicked, "BmGame.RGFxMovieHudExtendable.ContentsTicked");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetScannerVisible;
    /// <summary>
    /// Function: SetScannerVisible
    /// </summary>
    public unsafe virtual void SetScannerVisible(bool bVisible)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetScannerVisible, "BmGame.RGFxMovieHudExtendable.SetScannerVisible");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetContentsType;
    /// <summary>
    /// Function: SetContentsType
    /// </summary>
    public unsafe virtual void SetContentsType(BmSDK.FString contents_type)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetContentsType, "BmGame.RGFxMovieHudExtendable.SetContentsType");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(contents_type, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetScannerPrompt;
    /// <summary>
    /// Function: SetScannerPrompt
    /// </summary>
    public unsafe virtual void SetScannerPrompt(BmSDK.BmGame.RHudExtensionInvestigate.ScannerPrompt ScanID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetScannerPrompt, "BmGame.RGFxMovieHudExtendable.SetScannerPrompt");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScanID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCloseInvestigate;
    /// <summary>
    /// Function: OnCloseInvestigate
    /// </summary>
    public unsafe virtual void OnCloseInvestigate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCloseInvestigate, "BmGame.RGFxMovieHudExtendable.OnCloseInvestigate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInfoCursor;
    /// <summary>
    /// Function: SetInfoCursor
    /// </summary>
    public unsafe virtual void SetInfoCursor(float X, float Y, float ViewDepth, BmSDK.FString actorName, BmSDK.FString Title, BmSDK.FString Message, bool bWarningColour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInfoCursor, "BmGame.RGFxMovieHudExtendable.SetInfoCursor");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewDepth, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(actorName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWarningColour, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNPCCountString;
    /// <summary>
    /// Function: GetNPCCountString
    /// </summary>
    public unsafe virtual BmSDK.FString GetNPCCountString(int Armed, int UnArmed, int Drone)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNPCCountString, "BmGame.RGFxMovieHudExtendable.GetNPCCountString");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Armed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnArmed, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Drone, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CloseGenericObjectiveHud;
    /// <summary>
    /// Function: CloseGenericObjectiveHud
    /// </summary>
    public unsafe virtual void CloseGenericObjectiveHud()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseGenericObjectiveHud, "BmGame.RGFxMovieHudExtendable.CloseGenericObjectiveHud");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NewObjectivesMovie;
    /// <summary>
    /// Function: NewObjectivesMovie
    /// </summary>
    public unsafe virtual void NewObjectivesMovie()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NewObjectivesMovie, "BmGame.RGFxMovieHudExtendable.NewObjectivesMovie");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseInterceptHud;
    /// <summary>
    /// Function: CloseInterceptHud
    /// </summary>
    public unsafe virtual void CloseInterceptHud()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseInterceptHud, "BmGame.RGFxMovieHudExtendable.CloseInterceptHud");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseRobotScanMovie;
    /// <summary>
    /// Function: CloseRobotScanMovie
    /// </summary>
    public unsafe virtual void CloseRobotScanMovie()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseRobotScanMovie, "BmGame.RGFxMovieHudExtendable.CloseRobotScanMovie");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPinkeyLetterScannedString;
    /// <summary>
    /// Function: GetPinkeyLetterScannedString
    /// </summary>
    public unsafe virtual BmSDK.FString GetPinkeyLetterScannedString(int pinkneyScanIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPinkeyLetterScannedString, "BmGame.RGFxMovieHudExtendable.GetPinkeyLetterScannedString");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pinkneyScanIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PickupSuccessfullyScanned;
    /// <summary>
    /// Function: PickupSuccessfullyScanned
    /// </summary>
    public unsafe virtual void PickupSuccessfullyScanned()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PickupSuccessfullyScanned, "BmGame.RGFxMovieHudExtendable.PickupSuccessfullyScanned");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseInformantMovie;
    /// <summary>
    /// Function: CloseInformantMovie
    /// </summary>
    public unsafe virtual void CloseInformantMovie()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseInformantMovie, "BmGame.RGFxMovieHudExtendable.CloseInformantMovie");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOnInformantHighlight;
    /// <summary>
    /// Function: TurnOnInformantHighlight
    /// </summary>
    public unsafe virtual void TurnOnInformantHighlight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOnInformantHighlight, "BmGame.RGFxMovieHudExtendable.TurnOnInformantHighlight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOffReticle;
    /// <summary>
    /// Function: TurnOffReticle
    /// </summary>
    public unsafe virtual void TurnOffReticle(int subject_index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffReticle, "BmGame.RGFxMovieHudExtendable.TurnOffReticle");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(subject_index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseObjectivesMovie;
    /// <summary>
    /// Function: CloseObjectivesMovie
    /// </summary>
    public unsafe virtual void CloseObjectivesMovie()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseObjectivesMovie, "BmGame.RGFxMovieHudExtendable.CloseObjectivesMovie");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseBossHud;
    /// <summary>
    /// Function: CloseBossHud
    /// </summary>
    public unsafe virtual void CloseBossHud()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseBossHud, "BmGame.RGFxMovieHudExtendable.CloseBossHud");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseRoomMovie;
    /// <summary>
    /// Function: CloseRoomMovie
    /// </summary>
    public unsafe virtual void CloseRoomMovie()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseRoomMovie, "BmGame.RGFxMovieHudExtendable.CloseRoomMovie");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CleanUpForCutscene;
    /// <summary>
    /// Function: CleanUpForCutscene
    /// </summary>
    public unsafe virtual void CleanUpForCutscene()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CleanUpForCutscene, "BmGame.RGFxMovieHudExtendable.CleanUpForCutscene");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGameTime;
    /// <summary>
    /// Function: GetGameTime
    /// </summary>
    public unsafe virtual float GetGameTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGameTime, "BmGame.RGFxMovieHudExtendable.GetGameTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetSwfMovieFullName;
    /// <summary>
    /// Function: GetSwfMovieFullName
    /// </summary>
    public unsafe virtual BmSDK.FString GetSwfMovieFullName(BmSDK.GFxUI.SwfMovie TestMovie)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSwfMovieFullName, "BmGame.RGFxMovieHudExtendable.GetSwfMovieFullName");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestMovie, paramsPtr + 0);
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

    private static BmSDK.Function __fn_IsModuleReady;
    /// <summary>
    /// Function: IsModuleReady
    /// </summary>
    public unsafe virtual int IsModuleReady(BmSDK.FString _ExtensionName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsModuleReady, "BmGame.RGFxMovieHudExtendable.IsModuleReady");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetModuleFlagString;
    /// <summary>
    /// Function: SetModuleFlagString
    /// </summary>
    public unsafe virtual void SetModuleFlagString(BmSDK.FString _ExtensionName, BmSDK.FString _FlagName, BmSDK.FString _FlagValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetModuleFlagString, "BmGame.RGFxMovieHudExtendable.SetModuleFlagString");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_FlagName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_FlagValue, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetModuleFlagInt;
    /// <summary>
    /// Function: SetModuleFlagInt
    /// </summary>
    public unsafe virtual void SetModuleFlagInt(BmSDK.FString _ExtensionName, BmSDK.FString _FlagName, int _FlagValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetModuleFlagInt, "BmGame.RGFxMovieHudExtendable.SetModuleFlagInt");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_FlagName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_FlagValue, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetModuleFlagBoolean;
    /// <summary>
    /// Function: SetModuleFlagBoolean
    /// </summary>
    public unsafe virtual void SetModuleFlagBoolean(BmSDK.FString _ExtensionName, BmSDK.FString _FlagName, bool _FlagValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetModuleFlagBoolean, "BmGame.RGFxMovieHudExtendable.SetModuleFlagBoolean");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_FlagName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_FlagValue, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AutoAdjustExtension;
    /// <summary>
    /// Function: AutoAdjustExtension
    /// </summary>
    public unsafe virtual void AutoAdjustExtension(BmSDK.FString _ExtensionName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AutoAdjustExtension, "BmGame.RGFxMovieHudExtendable.AutoAdjustExtension");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeleteHudExtension;
    /// <summary>
    /// Function: DeleteHudExtension
    /// </summary>
    public unsafe virtual void DeleteHudExtension(BmSDK.FString _ExtensionName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeleteHudExtension, "BmGame.RGFxMovieHudExtendable.DeleteHudExtension");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateHudExtension;
    /// <summary>
    /// Function: CreateHudExtension
    /// </summary>
    public unsafe virtual void CreateHudExtension(BmSDK.FString _ExtensionName, BmSDK.FString _ExtensionPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateHudExtension, "BmGame.RGFxMovieHudExtendable.CreateHudExtension");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionPath, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateHudExtensionFromSwfMovie;
    /// <summary>
    /// Function: CreateHudExtensionFromSwfMovie
    /// </summary>
    public unsafe virtual void CreateHudExtensionFromSwfMovie(BmSDK.FString _ExtensionName, BmSDK.GFxUI.SwfMovie _ExtensionPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateHudExtensionFromSwfMovie, "BmGame.RGFxMovieHudExtendable.CreateHudExtensionFromSwfMovie");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionPath, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpHudExtensions;
    /// <summary>
    /// Function: DumpHudExtensions
    /// </summary>
    public unsafe virtual void DumpHudExtensions()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpHudExtensions, "BmGame.RGFxMovieHudExtendable.DumpHudExtensions");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSelectiveVisibilityModule;
    /// <summary>
    /// Function: SetSelectiveVisibilityModule
    /// </summary>
    public unsafe virtual void SetSelectiveVisibilityModule(BmSDK.FString module_name)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSelectiveVisibilityModule, "BmGame.RGFxMovieHudExtendable.SetSelectiveVisibilityModule");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(module_name, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendVisibilityToFlash;
    /// <summary>
    /// Function: SendVisibilityToFlash
    /// </summary>
    public unsafe virtual void SendVisibilityToFlash(bool bVisible)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendVisibilityToFlash, "BmGame.RGFxMovieHudExtendable.SendVisibilityToFlash");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetVisibilityAuto;
    /// <summary>
    /// Function: SetVisibilityAuto
    /// </summary>
    public unsafe virtual void SetVisibilityAuto()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVisibilityAuto, "BmGame.RGFxMovieHudExtendable.SetVisibilityAuto");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateHudVisibility;
    /// <summary>
    /// Function: UpdateHudVisibility
    /// </summary>
    public unsafe override void UpdateHudVisibility(bool bVisible)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateHudVisibility, "BmGame.RGFxMovieHudExtendable.UpdateHudVisibility");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ManuallySetHudVisibility;
    /// <summary>
    /// Function: ManuallySetHudVisibility
    /// </summary>
    public unsafe virtual void ManuallySetHudVisibility(bool bVisible)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ManuallySetHudVisibility, "BmGame.RGFxMovieHudExtendable.ManuallySetHudVisibility");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInvestigateModeAuto;
    /// <summary>
    /// Function: SetInvestigateModeAuto
    /// </summary>
    public unsafe virtual void SetInvestigateModeAuto()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInvestigateModeAuto, "BmGame.RGFxMovieHudExtendable.SetInvestigateModeAuto");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnClose;
    /// <summary>
    /// Function: OnClose
    /// </summary>
    public unsafe override void OnClose()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnClose, "BmGame.RGFxMovieHudExtendable.OnClose");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RGFxMovieHudExtendable.Init");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadCompleteRoomName;
    /// <summary>
    /// Function: LoadCompleteRoomName
    /// </summary>
    public unsafe virtual void LoadCompleteRoomName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadCompleteRoomName, "BmGame.RGFxMovieHudExtendable.LoadCompleteRoomName");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WidgetUnloaded;
    /// <summary>
    /// Function: WidgetUnloaded
    /// </summary>
    public unsafe override bool WidgetUnloaded(BmSDK.FName WidgetName, BmSDK.FName WidgetPath, BmSDK.GFxUI.GFxObject Widget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WidgetUnloaded, "BmGame.RGFxMovieHudExtendable.WidgetUnloaded");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetPath, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Widget, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_WidgetInitialized;
    /// <summary>
    /// Function: WidgetInitialized
    /// </summary>
    public unsafe override bool WidgetInitialized(BmSDK.FName WidgetName, BmSDK.FName WidgetPath, BmSDK.GFxUI.GFxObject Widget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WidgetInitialized, "BmGame.RGFxMovieHudExtendable.WidgetInitialized");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetPath, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Widget, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// Enum: JustifyText
    /// </summary>
    public enum JustifyText : byte
    {
        JT_Left = 0,
        JT_Center = 1,
        JT_Right = 2,
        JT_Align = 3,
        JT_MAX = 4,
    }

    /// <summary>
    /// ArrayProperty: HealthBars
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHudExtensionHealth> HealthBars
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHudExtensionHealth>>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// ArrayProperty: GadgetSelects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHudExtensionGadgets> GadgetSelects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHudExtensionGadgets>>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// ArrayProperty: HudTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHudExtensionTargets> HudTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHudExtensionTargets>>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// ObjectProperty: Bespoke
    /// </summary>
    public unsafe BmSDK.BmGame.RHudExtensionChallengeBespoke Bespoke
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudExtensionChallengeBespoke>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// ObjectProperty: AlertsMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RHudExtensionAlerts AlertsMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudExtensionAlerts>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// ObjectProperty: CrimeSceneMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RHudExtensionCrimeSceneInfo CrimeSceneMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudExtensionCrimeSceneInfo>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// ObjectProperty: RoomNameMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RHudExtensionRoomName RoomNameMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudExtensionRoomName>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// ObjectProperty: ObjectivesMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RHudExtensionObjectives ObjectivesMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudExtensionObjectives>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// ObjectProperty: InformantsMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RHudExtensionInformants InformantsMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudExtensionInformants>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// ObjectProperty: RobotScanMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RHudExtensionRobotScan RobotScanMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudExtensionRobotScan>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// ObjectProperty: ObjectiveTrackingMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RHudExtensionObjectiveTracking ObjectiveTrackingMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudExtensionObjectiveTracking>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// ObjectProperty: BossHudMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RHudExtensionBossHud BossHudMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudExtensionBossHud>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// ObjectProperty: InvestigateMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RHudExtensionInvestigate InvestigateMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudExtensionInvestigate>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// ObjectProperty: ScannerMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RHudExtensionScanner ScannerMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudExtensionScanner>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// ObjectProperty: ContentsMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RHudExtensionContents ContentsMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudExtensionContents>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: GeneralMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RHudExtensionGeneral GeneralMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudExtensionGeneral>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// ObjectProperty: ExtraMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RHudExtensionExtra ExtraMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudExtensionExtra>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ObjectProperty: DownloadingCodesMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RHudExtensionDownloadingCodes DownloadingCodesMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudExtensionDownloadingCodes>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// ObjectProperty: ShockGlovesEnergyMovie
    /// </summary>
    public unsafe BmSDK.BmGame.MHudExtensionShockGlovesEnergy ShockGlovesEnergyMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHudExtensionShockGlovesEnergy>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ObjectProperty: DeathstrokeHudMovie
    /// </summary>
    public unsafe BmSDK.BmGame.MHudExtensionDeathstroke DeathstrokeHudMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHudExtensionDeathstroke>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// ObjectProperty: BaneHudMovie
    /// </summary>
    public unsafe BmSDK.BmGame.MHudExtensionBane BaneHudMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHudExtensionBane>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ObjectProperty: FireflyHudMovie
    /// </summary>
    public unsafe BmSDK.BmGame.MHudExtensionFirefly FireflyHudMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHudExtensionFirefly>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bHudVisibilityGame
    /// </summary>
    public unsafe bool bHudVisibilityGame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bHudVisibilityManual
    /// </summary>
    public unsafe bool bHudVisibilityManual
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bSnowAlertDisabled
    /// </summary>
    public unsafe bool bSnowAlertDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bCallAdvanceOnNextTick
    /// </summary>
    public unsafe bool bCallAdvanceOnNextTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bCommonElementsInitialised
    /// </summary>
    public unsafe bool bCommonElementsInitialised
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// ArrayProperty: CharacterAcronyms
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> CharacterAcronyms
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// IntProperty: iInitialiseDelayCountdown
    /// </summary>
    public unsafe int iInitialiseDelayCountdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ObjectProperty: LargeBillboardImageLoader
    /// </summary>
    public unsafe BmSDK.BmGame.MGFxWidgetImage LargeBillboardImageLoader
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGFxWidgetImage>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }
}
