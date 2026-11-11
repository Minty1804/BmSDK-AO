#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDGITugOfWar<br/>
/// (size = 1873)
/// (flags = 10518582)
/// </summary>
public partial class GDGITugOfWar : BmSDK.BmGame.GDGIHeroTeamGame, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDGITugOfWar", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDGITugOfWar.
    /// </summary>
    public static GDGITugOfWar DefaultObject => (GDGITugOfWar)StaticClass().DefaultObject;

    internal GDGITugOfWar() { }

    /// <summary>
    /// Constructs a new GDGITugOfWar
    /// </summary>
    public GDGITugOfWar(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDGITugOfWar(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGITugOfWar>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGITugOfWar>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGITugOfWar>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGITugOfWar>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGITugOfWar>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGITugOfWar>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGITugOfWar>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGITugOfWar>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_DrawDebugHUD;
    /// <summary>
    /// Function: DrawDebugHUD
    /// </summary>
    public unsafe override int DrawDebugHUD(BmSDK.SDEngine.SDWorldInfo SDWI, int X, int Y)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugHUD, "BmGame.GDGITugOfWar.DrawDebugHUD");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SDWI, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_KismetTriggerEventNewRoundBegins;
    /// <summary>
    /// Function: KismetTriggerEventNewRoundBegins
    /// </summary>
    public unsafe virtual void KismetTriggerEventNewRoundBegins()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KismetTriggerEventNewRoundBegins, "BmGame.GDGITugOfWar.KismetTriggerEventNewRoundBegins");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KismetTriggerEventBaneWonRound;
    /// <summary>
    /// Function: KismetTriggerEventBaneWonRound
    /// </summary>
    public unsafe virtual void KismetTriggerEventBaneWonRound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KismetTriggerEventBaneWonRound, "BmGame.GDGITugOfWar.KismetTriggerEventBaneWonRound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KismetTriggerEventJokerWonRound;
    /// <summary>
    /// Function: KismetTriggerEventJokerWonRound
    /// </summary>
    public unsafe virtual void KismetTriggerEventJokerWonRound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KismetTriggerEventJokerWonRound, "BmGame.GDGITugOfWar.KismetTriggerEventJokerWonRound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KismetTriggerEventHeroWonRound;
    /// <summary>
    /// Function: KismetTriggerEventHeroWonRound
    /// </summary>
    public unsafe virtual void KismetTriggerEventHeroWonRound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KismetTriggerEventHeroWonRound, "BmGame.GDGITugOfWar.KismetTriggerEventHeroWonRound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivatePayload;
    /// <summary>
    /// Function: ActivatePayload
    /// </summary>
    public unsafe virtual void ActivatePayload()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivatePayload, "BmGame.GDGITugOfWar.ActivatePayload");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LevelReadyForNextRound;
    /// <summary>
    /// Function: LevelReadyForNextRound
    /// </summary>
    public unsafe virtual void LevelReadyForNextRound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LevelReadyForNextRound, "BmGame.GDGITugOfWar.LevelReadyForNextRound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TeamCompletedPayloadObjective;
    /// <summary>
    /// Function: TeamCompletedPayloadObjective
    /// </summary>
    public unsafe virtual void TeamCompletedPayloadObjective(bool bHeroHack = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TeamCompletedPayloadObjective, "BmGame.GDGITugOfWar.TeamCompletedPayloadObjective");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHeroHack, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterObjectiveMatinee;
    /// <summary>
    /// Function: RegisterObjectiveMatinee
    /// </summary>
    public unsafe override void RegisterObjectiveMatinee(BmSDK.BmGame.GDSeqAct_ObjectiveInterp ObjectiveMatinee, BmSDK.BmGame.GDObjective NewObjective)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterObjectiveMatinee, "BmGame.GDGITugOfWar.RegisterObjectiveMatinee");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectiveMatinee, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewObjective, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: Payload
    /// </summary>
    public unsafe BmSDK.BmGame.GDTugOfWarObjectivePayload Payload
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDTugOfWarObjectivePayload>(Ptr + 1868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1868); }
    }

    /// <summary>
    /// ByteProperty: LastCompletingTeam
    /// </summary>
    public unsafe BmSDK.BmGame.GDGIBase.ETeamType LastCompletingTeam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGIBase.ETeamType>(Ptr + 1872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1872); }
    }
}
