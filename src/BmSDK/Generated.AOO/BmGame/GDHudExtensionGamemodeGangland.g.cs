#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDHudExtensionGamemodeGangland<br/>
/// (size = 780)
/// (flags = 134250646)
/// </summary>
public partial class GDHudExtensionGamemodeGangland : BmSDK.BmGame.GDHudExtension_GameModeBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDHudExtensionGamemodeGangland", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDHudExtensionGamemodeGangland.
    /// </summary>
    public static GDHudExtensionGamemodeGangland DefaultObject => (GDHudExtensionGamemodeGangland)StaticClass().DefaultObject;

    internal GDHudExtensionGamemodeGangland() { }

    /// <summary>
    /// Constructs a new GDHudExtensionGamemodeGangland
    /// </summary>
    public GDHudExtensionGamemodeGangland(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDHudExtensionGamemodeGangland Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDHudExtensionGamemodeGangland(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeGangland>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeGangland>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeGangland>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeGangland>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeGangland>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeGangland>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeGangland>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeGangland>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_asOnIntimidationLoss;
    /// <summary>
    /// Function: asOnIntimidationLoss
    /// </summary>
    public unsafe virtual void asOnIntimidationLoss()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asOnIntimidationLoss, "BmGame.GDHudExtensionGamemodeGangland.asOnIntimidationLoss");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asOnIntimidationGain;
    /// <summary>
    /// Function: asOnIntimidationGain
    /// </summary>
    public unsafe virtual void asOnIntimidationGain()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asOnIntimidationGain, "BmGame.GDHudExtensionGamemodeGangland.asOnIntimidationGain");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asOnIntimidationPulse;
    /// <summary>
    /// Function: asOnIntimidationPulse
    /// </summary>
    public unsafe virtual void asOnIntimidationPulse()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asOnIntimidationPulse, "BmGame.GDHudExtensionGamemodeGangland.asOnIntimidationPulse");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asShowTakedownMessage;
    /// <summary>
    /// Function: asShowTakedownMessage
    /// </summary>
    public unsafe virtual void asShowTakedownMessage(BmSDK.TArray<BmSDK.FString> Texts, BmSDK.TArray<int> Scores, bool bIsBatman)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asShowTakedownMessage, "BmGame.GDHudExtensionGamemodeGangland.asShowTakedownMessage");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Texts, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scores, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsBatman, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetTeamScoreText;
    /// <summary>
    /// Function: asSetTeamScoreText
    /// </summary>
    public unsafe virtual void asSetTeamScoreText(bool bLeft, BmSDK.FString Score, BmSDK.FString AnimState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetTeamScoreText, "BmGame.GDHudExtensionGamemodeGangland.asSetTeamScoreText");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLeft, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimState, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetHeroScoreText;
    /// <summary>
    /// Function: asSetHeroScoreText
    /// </summary>
    public unsafe virtual void asSetHeroScoreText(BmSDK.FString Score, BmSDK.FString AnimState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetHeroScoreText, "BmGame.GDHudExtensionGamemodeGangland.asSetHeroScoreText");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimState, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asGetTicketTextMovie;
    /// <summary>
    /// Function: asGetTicketTextMovie
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject asGetTicketTextMovie(bool bLefthandSide)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetTicketTextMovie, "BmGame.GDHudExtensionGamemodeGangland.asGetTicketTextMovie");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLefthandSide, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_asGetIndividualPipMovie;
    /// <summary>
    /// Function: asGetIndividualPipMovie
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject asGetIndividualPipMovie(int PipIndex, bool bLefthandSide)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetIndividualPipMovie, "BmGame.GDHudExtensionGamemodeGangland.asGetIndividualPipMovie");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PipIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLefthandSide, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_asGetTicketPipBarMovie;
    /// <summary>
    /// Function: asGetTicketPipBarMovie
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject asGetTicketPipBarMovie(bool bLefthandSide)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetTicketPipBarMovie, "BmGame.GDHudExtensionGamemodeGangland.asGetTicketPipBarMovie");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLefthandSide, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_asGetTicketMovie;
    /// <summary>
    /// Function: asGetTicketMovie
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject asGetTicketMovie(bool bLefthandSide)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetTicketMovie, "BmGame.GDHudExtensionGamemodeGangland.asGetTicketMovie");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLefthandSide, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_asGetTakedownNotificationMovie;
    /// <summary>
    /// Function: asGetTakedownNotificationMovie
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject asGetTakedownNotificationMovie()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetTakedownNotificationMovie, "BmGame.GDHudExtensionGamemodeGangland.asGetTakedownNotificationMovie");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_asGetHeroKillMovie;
    /// <summary>
    /// Function: asGetHeroKillMovie
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject asGetHeroKillMovie(bool bLefthandSide)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetHeroKillMovie, "BmGame.GDHudExtensionGamemodeGangland.asGetHeroKillMovie");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLefthandSide, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_asGetHeroIntimidationMovie;
    /// <summary>
    /// Function: asGetHeroIntimidationMovie
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject asGetHeroIntimidationMovie()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetHeroIntimidationMovie, "BmGame.GDHudExtensionGamemodeGangland.asGetHeroIntimidationMovie");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_asHideCPs;
    /// <summary>
    /// Function: asHideCPs
    /// </summary>
    public unsafe virtual void asHideCPs()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asHideCPs, "BmGame.GDHudExtensionGamemodeGangland.asHideCPs");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushIntimidationEvent;
    /// <summary>
    /// Function: PushIntimidationEvent
    /// </summary>
    public unsafe virtual void PushIntimidationEvent(in BmSDK.BmGame.GDGIBase.FSIntimidationEvent Event, bool bIsBatman, int PreviousComboAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushIntimidationEvent, "BmGame.GDHudExtensionGamemodeGangland.PushIntimidationEvent");
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Event, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsBatman, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousComboAmount, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInitialData;
    /// <summary>
    /// Function: SetInitialData
    /// </summary>
    public unsafe override void SetInitialData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInitialData, "BmGame.GDHudExtensionGamemodeGangland.SetInitialData");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetIntimidationState;
    /// <summary>
    /// Function: GetIntimidationState
    /// </summary>
    public unsafe void GetIntimidationState(out BmSDK.BmGame.GDHudExtensionGamemodeGangland.FSGanglandState GanglandState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIntimidationState, "BmGame.GDHudExtensionGamemodeGangland.GetIntimidationState");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out GanglandState);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GanglandState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        GanglandState = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDHudExtensionGamemodeGangland.FSGanglandState>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetTicketState;
    /// <summary>
    /// Function: GetTicketState
    /// </summary>
    public unsafe void GetTicketState(out BmSDK.BmGame.GDHudExtensionGamemodeGangland.FSGanglandState GanglandState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTicketState, "BmGame.GDHudExtensionGamemodeGangland.GetTicketState");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out GanglandState);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GanglandState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        GanglandState = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDHudExtensionGamemodeGangland.FSGanglandState>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_BuildGanglandState;
    /// <summary>
    /// Function: BuildGanglandState
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDHudExtensionGamemodeGangland.FSGanglandState BuildGanglandState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuildGanglandState, "BmGame.GDHudExtensionGamemodeGangland.BuildGanglandState");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDHudExtensionGamemodeGangland.FSGanglandState>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PushIntimidationStateChanges;
    /// <summary>
    /// Function: PushIntimidationStateChanges
    /// </summary>
    public unsafe void PushIntimidationStateChanges(BmSDK.BmGame.GDHudExtensionGamemodeGangland.FSGanglandState NewState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushIntimidationStateChanges, "BmGame.GDHudExtensionGamemodeGangland.PushIntimidationStateChanges");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushTicketStateChanges;
    /// <summary>
    /// Function: PushTicketStateChanges
    /// </summary>
    public unsafe void PushTicketStateChanges(BmSDK.BmGame.GDHudExtensionGamemodeGangland.FSGanglandState NewState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushTicketStateChanges, "BmGame.GDHudExtensionGamemodeGangland.PushTicketStateChanges");
        byte* paramsPtr = stackalloc byte[49];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushGanglandStateChanges;
    /// <summary>
    /// Function: PushGanglandStateChanges
    /// </summary>
    public unsafe virtual void PushGanglandStateChanges(BmSDK.BmGame.GDHudExtensionGamemodeGangland.FSGanglandState NewState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushGanglandStateChanges, "BmGame.GDHudExtensionGamemodeGangland.PushGanglandStateChanges");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushHeroParticipantStateChanges;
    /// <summary>
    /// Function: PushHeroParticipantStateChanges
    /// </summary>
    public unsafe virtual void PushHeroParticipantStateChanges(BmSDK.BmGame.GDHudExtensionGamemodeGangland.FSHeroParticipantsState NewState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushHeroParticipantStateChanges, "BmGame.GDHudExtensionGamemodeGangland.PushHeroParticipantStateChanges");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BuildHeroParticipantState;
    /// <summary>
    /// Function: BuildHeroParticipantState
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDHudExtensionGamemodeGangland.FSHeroParticipantsState BuildHeroParticipantState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuildHeroParticipantState, "BmGame.GDHudExtensionGamemodeGangland.BuildHeroParticipantState");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDHudExtensionGamemodeGangland.FSHeroParticipantsState>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DoStateUpdate;
    /// <summary>
    /// Function: DoStateUpdate
    /// </summary>
    public unsafe override void DoStateUpdate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoStateUpdate, "BmGame.GDHudExtensionGamemodeGangland.DoStateUpdate");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanPlayerRespawn;
    /// <summary>
    /// Function: CanPlayerRespawn
    /// </summary>
    public unsafe override bool CanPlayerRespawn(BmSDK.BmGame.RPlayerRI RPRI)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayerRespawn, "BmGame.GDHudExtensionGamemodeGangland.CanPlayerRespawn");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPRI, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HeroDeathTriggeredRespawn;
    /// <summary>
    /// Function: HeroDeathTriggeredRespawn
    /// </summary>
    public unsafe virtual void HeroDeathTriggeredRespawn(BmSDK.BmGame.GDGIBase.ETeamType KillingTeam)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HeroDeathTriggeredRespawn, "BmGame.GDHudExtensionGamemodeGangland.HeroDeathTriggeredRespawn");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KillingTeam, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckLowTicketPulse;
    /// <summary>
    /// Function: CheckLowTicketPulse
    /// </summary>
    public unsafe virtual void CheckLowTicketPulse(BmSDK.BmGame.GDGIBase.ETeamType ForTeam)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckLowTicketPulse, "BmGame.GDHudExtensionGamemodeGangland.CheckLowTicketPulse");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForTeam, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckIntimidationPulse;
    /// <summary>
    /// Function: CheckIntimidationPulse
    /// </summary>
    public unsafe virtual void CheckIntimidationPulse()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckIntimidationPulse, "BmGame.GDHudExtensionGamemodeGangland.CheckIntimidationPulse");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckControlPointPulse;
    /// <summary>
    /// Function: CheckControlPointPulse
    /// </summary>
    public unsafe virtual void CheckControlPointPulse()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckControlPointPulse, "BmGame.GDHudExtensionGamemodeGangland.CheckControlPointPulse");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckAnims;
    /// <summary>
    /// Function: CheckAnims
    /// </summary>
    public unsafe virtual void CheckAnims()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckAnims, "BmGame.GDHudExtensionGamemodeGangland.CheckAnims");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNextCPPulseTime;
    /// <summary>
    /// Function: GetNextCPPulseTime
    /// </summary>
    public unsafe float GetNextCPPulseTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextCPPulseTime, "BmGame.GDHudExtensionGamemodeGangland.GetNextCPPulseTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_NewIntimidationEvent;
    /// <summary>
    /// Function: NewIntimidationEvent
    /// </summary>
    public unsafe virtual void NewIntimidationEvent(BmSDK.BmGame.GDGIBase.FSIntimidationEvent Event, bool bBatman, int PreviousComboAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NewIntimidationEvent, "BmGame.GDHudExtensionGamemodeGangland.NewIntimidationEvent");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Event, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBatman, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousComboAmount, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Close;
    /// <summary>
    /// Function: Close
    /// </summary>
    public unsafe override void Close()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Close, "BmGame.GDHudExtensionGamemodeGangland.Close");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopulateMovieObjects;
    /// <summary>
    /// Function: PopulateMovieObjects
    /// </summary>
    public unsafe override void PopulateMovieObjects()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulateMovieObjects, "BmGame.GDHudExtensionGamemodeGangland.PopulateMovieObjects");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override bool Init(BmSDK.BmGame.RPlayerController _RPC, BmSDK.FString _ExtensionName, BmSDK.FString _ExtensionPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.GDHudExtensionGamemodeGangland.Init");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionPath, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_PlayLowTicketPulseAnim;
    /// <summary>
    /// Function: PlayLowTicketPulseAnim
    /// </summary>
    public unsafe void PlayLowTicketPulseAnim(bool bLefthandSide)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayLowTicketPulseAnim, "BmGame.GDHudExtensionGamemodeGangland.PlayLowTicketPulseAnim");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLefthandSide, paramsPtr + 0);
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

    private static BmSDK.Function __fn_PlayHeroKillAnim;
    /// <summary>
    /// Function: PlayHeroKillAnim
    /// </summary>
    public unsafe void PlayHeroKillAnim(bool bLefthandSide)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHeroKillAnim, "BmGame.GDHudExtensionGamemodeGangland.PlayHeroKillAnim");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLefthandSide, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetIntimidationProgress;
    /// <summary>
    /// Function: SetIntimidationProgress
    /// </summary>
    public unsafe void SetIntimidationProgress(int IntimidationProgress)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIntimidationProgress, "BmGame.GDHudExtensionGamemodeGangland.SetIntimidationProgress");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IntimidationProgress, paramsPtr + 0);
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

    private static BmSDK.Function __fn_PulseControlPoints;
    /// <summary>
    /// Function: PulseControlPoints
    /// </summary>
    public unsafe void PulseControlPoints(bool bLargePulse)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PulseControlPoints, "BmGame.GDHudExtensionGamemodeGangland.PulseControlPoints");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLargePulse, paramsPtr + 0);
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

    private static BmSDK.Function __fn_DoTicketChangeAnim;
    /// <summary>
    /// Function: DoTicketChangeAnim
    /// </summary>
    public unsafe void DoTicketChangeAnim(int OldTickets, int NewTickets, bool bLefthandSide, BmSDK.BmGame.GDGameReplicationInfo_Gangland.ETicketModReason Reason)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoTicketChangeAnim, "BmGame.GDHudExtensionGamemodeGangland.DoTicketChangeAnim");
        byte* paramsPtr = stackalloc byte[29];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldTickets, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTickets, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLefthandSide, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Reason, paramsPtr + 12);
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

    private static BmSDK.Function __fn_SetTicketString;
    /// <summary>
    /// Function: SetTicketString
    /// </summary>
    public unsafe void SetTicketString(BmSDK.FString TicketString, bool bLefthandSide)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTicketString, "BmGame.GDHudExtensionGamemodeGangland.SetTicketString");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TicketString, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLefthandSide, paramsPtr + 12);
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

    private static BmSDK.Function __fn_SetTicketCount;
    /// <summary>
    /// Function: SetTicketCount
    /// </summary>
    public unsafe void SetTicketCount(int TicketCount, bool bLefthandSide)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTicketCount, "BmGame.GDHudExtensionGamemodeGangland.SetTicketCount");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TicketCount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLefthandSide, paramsPtr + 4);
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
    /// StructProperty: CurrentGanglandState
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDHudExtensionGamemodeGangland.FSGanglandState CurrentGanglandState
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDHudExtensionGamemodeGangland.FSGanglandState>(Ptr + 388);

    /// <summary>
    /// StructProperty: CurrentHeroParticipantsState
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDHudExtensionGamemodeGangland.FSHeroParticipantsState CurrentHeroParticipantsState
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDHudExtensionGamemodeGangland.FSHeroParticipantsState>(Ptr + 400);

    /// <summary>
    /// ObjectProperty: GanglandGRI
    /// </summary>
    public unsafe BmSDK.BmGame.GDGameReplicationInfo_Gangland GanglandGRI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGameReplicationInfo_Gangland>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bMajorityPulseAnimActive
    /// </summary>
    public unsafe bool bMajorityPulseAnimActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 424); }
    }

    /// <summary>
    /// BoolProperty: bMajorityPulseLeftSidePips
    /// </summary>
    public unsafe bool bMajorityPulseLeftSidePips
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 424); }
    }

    /// <summary>
    /// BoolProperty: bSetInitialTicketCounts
    /// </summary>
    public unsafe bool bSetInitialTicketCounts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 424); }
    }

    /// <summary>
    /// BoolProperty: bDoneFirstStateUpdate
    /// </summary>
    public unsafe bool bDoneFirstStateUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 424); }
    }

    /// <summary>
    /// IntProperty: MajorityPulseStartPips
    /// </summary>
    public unsafe int MajorityPulseStartPips
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// IntProperty: MajorityPulseEndPips
    /// </summary>
    public unsafe int MajorityPulseEndPips
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// IntProperty: MajorityPulseTotalPips
    /// </summary>
    public unsafe int MajorityPulseTotalPips
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// FloatProperty: ScoreDisplayTime
    /// </summary>
    public unsafe float ScoreDisplayTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// FloatProperty: HideHeroScoreTime
    /// </summary>
    public unsafe float HideHeroScoreTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// ObjectProperty: HeroIntimidationObj
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject HeroIntimidationObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// ObjectProperty: TakedownNotificationObj
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject TakedownNotificationObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// ObjectProperty: BatmanObj
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject BatmanObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ObjectProperty: BatmanIconObj
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject BatmanIconObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// ObjectProperty: BatmanFillObj
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject BatmanFillObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// ObjectProperty: RobinObj
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject RobinObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// ObjectProperty: RobinIconObj
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject RobinIconObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// ObjectProperty: RobinFillObj
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject RobinFillObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// StructProperty: LeftSideObjects
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDHudExtensionGamemodeGangland.FSGanglandGangSideMovies LeftSideObjects
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDHudExtensionGamemodeGangland.FSGanglandGangSideMovies>(Ptr + 480);

    /// <summary>
    /// StructProperty: RightSideObjects
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDHudExtensionGamemodeGangland.FSGanglandGangSideMovies RightSideObjects
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDHudExtensionGamemodeGangland.FSGanglandGangSideMovies>(Ptr + 508);

    /// <summary>
    /// InlineArray{StrProperty}: TicketAnimFrameNames
    /// </summary>
    public InlineArray<BmSDK.FString> TicketAnimFrameNames => new(4, Ptr + 536, 12, this);

    /// <summary>
    /// StrProperty: TicketAnimFrameNames
    /// </summary>
    public unsafe BmSDK.FString TicketAnimFrameNames_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }
    /// <summary>
    /// StrProperty: TicketAnimFrameNames
    /// </summary>
    public unsafe BmSDK.FString TicketAnimFrameNames_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }
    /// <summary>
    /// StrProperty: TicketAnimFrameNames
    /// </summary>
    public unsafe BmSDK.FString TicketAnimFrameNames_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }
    /// <summary>
    /// StrProperty: TicketAnimFrameNames
    /// </summary>
    public unsafe BmSDK.FString TicketAnimFrameNames_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// InlineArray{StrProperty}: PipAnimFrameNames
    /// </summary>
    public InlineArray<BmSDK.FString> PipAnimFrameNames => new(4, Ptr + 584, 12, this);

    /// <summary>
    /// StrProperty: PipAnimFrameNames
    /// </summary>
    public unsafe BmSDK.FString PipAnimFrameNames_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }
    /// <summary>
    /// StrProperty: PipAnimFrameNames
    /// </summary>
    public unsafe BmSDK.FString PipAnimFrameNames_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }
    /// <summary>
    /// StrProperty: PipAnimFrameNames
    /// </summary>
    public unsafe BmSDK.FString PipAnimFrameNames_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }
    /// <summary>
    /// StrProperty: PipAnimFrameNames
    /// </summary>
    public unsafe BmSDK.FString PipAnimFrameNames_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// StrProperty: LowTicketPulseAnimFrameName
    /// </summary>
    public unsafe BmSDK.FString LowTicketPulseAnimFrameName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// StrProperty: ControlPointPulseAnim
    /// </summary>
    public unsafe BmSDK.FString ControlPointPulseAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// StrProperty: HeroKillFrameName
    /// </summary>
    public unsafe BmSDK.FString HeroKillFrameName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// StrProperty: LocalBatmanPlayerFrameName
    /// </summary>
    public unsafe BmSDK.FString LocalBatmanPlayerFrameName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// StrProperty: OtherBatmanPlayerFrameName
    /// </summary>
    public unsafe BmSDK.FString OtherBatmanPlayerFrameName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// StrProperty: LocalRobinPlayerFrameName
    /// </summary>
    public unsafe BmSDK.FString LocalRobinPlayerFrameName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// StrProperty: OtherRobinPlayerFrameName
    /// </summary>
    public unsafe BmSDK.FString OtherRobinPlayerFrameName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ObjectProperty: TicketLossLeft
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent TicketLossLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ObjectProperty: TicketLossRight
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent TicketLossRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// FloatProperty: CapturedCPPulseAlpha
    /// </summary>
    public unsafe float CapturedCPPulseAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// FloatProperty: NeutralCPPulseAlpha
    /// </summary>
    public unsafe float NeutralCPPulseAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// FloatProperty: MaxDelayBetweenCPPulses
    /// </summary>
    public unsafe float MaxDelayBetweenCPPulses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// FloatProperty: MinDelayBetweenCPPulses
    /// </summary>
    public unsafe float MinDelayBetweenCPPulses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// FloatProperty: NextCPPulseTime
    /// </summary>
    public unsafe float NextCPPulseTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// FloatProperty: StartPulseIntimidationAmount
    /// </summary>
    public unsafe float StartPulseIntimidationAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// FloatProperty: MaxDelayBetweenIntimidationPulses
    /// </summary>
    public unsafe float MaxDelayBetweenIntimidationPulses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// FloatProperty: MinDelayBetweenIntimidationPulses
    /// </summary>
    public unsafe float MinDelayBetweenIntimidationPulses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// FloatProperty: NextIntimidationPulseTime
    /// </summary>
    public unsafe float NextIntimidationPulseTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// FloatProperty: StartPulseLowTicketAmount
    /// </summary>
    public unsafe float StartPulseLowTicketAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// FloatProperty: MaxDelayBetweenLowTicketPulses
    /// </summary>
    public unsafe float MaxDelayBetweenLowTicketPulses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// FloatProperty: MinDelayBetweenLowTicketPulses
    /// </summary>
    public unsafe float MinDelayBetweenLowTicketPulses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// FloatProperty: NextLowTicketPulseTimeJoker
    /// </summary>
    public unsafe float NextLowTicketPulseTimeJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// FloatProperty: NextLowTicketPulseTimeBane
    /// </summary>
    public unsafe float NextLowTicketPulseTimeBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// Struct: FSGanglandGangSideMovies
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FSGanglandGangSideMovies
    {
        /// <summary>
        /// ObjectProperty: HeroKillObj
        /// </summary>
        public unsafe BmSDK.GFxUI.GFxObject HeroKillObj
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: TicketObjects
        /// </summary>
        public unsafe BmSDK.BmGame.GDHudExtensionGamemodeGangland.FSTicketBarMovies TicketObjects
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDHudExtensionGamemodeGangland.FSTicketBarMovies>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FSTicketBarMovies
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FSTicketBarMovies
    {
        /// <summary>
        /// ObjectProperty: TicketObj
        /// </summary>
        public unsafe BmSDK.GFxUI.GFxObject TicketObj
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: TicketTextObj
        /// </summary>
        public unsafe BmSDK.GFxUI.GFxObject TicketTextObj
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ObjectProperty: TicketPipBarObj
        /// </summary>
        public unsafe BmSDK.GFxUI.GFxObject TicketPipBarObj
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ArrayProperty: IndividualPips
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.GFxUI.GFxObject> IndividualPips
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GFxUI.GFxObject>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FSHeroParticipantsState
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FSHeroParticipantsState
    {
        /// <summary>
        /// StructProperty: Batman
        /// </summary>
        public unsafe BmSDK.BmGame.GDHudExtension_GameModeBase.FSGameModeParticipant Batman
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDHudExtension_GameModeBase.FSGameModeParticipant>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Robin
        /// </summary>
        public unsafe BmSDK.BmGame.GDHudExtension_GameModeBase.FSGameModeParticipant Robin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDHudExtension_GameModeBase.FSGameModeParticipant>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bHasBatman
        /// </summary>
        public unsafe bool bHasBatman
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }

        /// <summary>
        /// BoolProperty: bHasRobin
        /// </summary>
        public unsafe bool bHasRobin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }

        /// <summary>
        /// BoolProperty: BatmanIsLocalPlayer
        /// </summary>
        public unsafe bool BatmanIsLocalPlayer
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }

        /// <summary>
        /// BoolProperty: RobinIsLocalPlayer
        /// </summary>
        public unsafe bool RobinIsLocalPlayer
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FSGanglandState
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FSGanglandState
    {
        /// <summary>
        /// IntProperty: JokerTicketCount
        /// </summary>
        public unsafe int JokerTicketCount
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: BaneTicketCount
        /// </summary>
        public unsafe int BaneTicketCount
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: IntimidationProgress
        /// </summary>
        public unsafe int IntimidationProgress
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }
}
