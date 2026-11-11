#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDGameReplicationInfo_Gangland<br/>
/// (size = 2796)
/// (flags = 142639254)
/// </summary>
public partial class GDGameReplicationInfo_Gangland : BmSDK.BmGame.GDGameReplicationInfo_ControlPoints, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDGameReplicationInfo_Gangland", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDGameReplicationInfo_Gangland.
    /// </summary>
    public static GDGameReplicationInfo_Gangland DefaultObject => (GDGameReplicationInfo_Gangland)StaticClass().DefaultObject;

    internal GDGameReplicationInfo_Gangland() { }

    /// <summary>
    /// Constructs a new GDGameReplicationInfo_Gangland
    /// </summary>
    public GDGameReplicationInfo_Gangland(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDGameReplicationInfo_Gangland(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo_Gangland>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo_Gangland>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo_Gangland>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo_Gangland>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo_Gangland>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo_Gangland>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo_Gangland>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGameReplicationInfo_Gangland>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_OnGameOutro;
    /// <summary>
    /// Function: OnGameOutro
    /// </summary>
    public unsafe override void OnGameOutro()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnGameOutro, "BmGame.GDGameReplicationInfo_Gangland.OnGameOutro");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPercentageOfTicketCycleRemaining;
    /// <summary>
    /// Function: GetPercentageOfTicketCycleRemaining
    /// </summary>
    public unsafe virtual float GetPercentageOfTicketCycleRemaining()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPercentageOfTicketCycleRemaining, "BmGame.GDGameReplicationInfo_Gangland.GetPercentageOfTicketCycleRemaining");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SupervillainFinishedSpawning;
    /// <summary>
    /// Function: SupervillainFinishedSpawning
    /// </summary>
    public unsafe virtual void SupervillainFinishedSpawning()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SupervillainFinishedSpawning, "BmGame.GDGameReplicationInfo_Gangland.SupervillainFinishedSpawning");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSpawnedSupervillainTeam;
    /// <summary>
    /// Function: SetSpawnedSupervillainTeam
    /// </summary>
    public unsafe virtual void SetSpawnedSupervillainTeam(BmSDK.BmGame.GDGIBase.ETeamType SpawnedTeam)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSpawnedSupervillainTeam, "BmGame.GDGameReplicationInfo_Gangland.SetSpawnedSupervillainTeam");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnedTeam, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLastManStandingPRI;
    /// <summary>
    /// Function: SetLastManStandingPRI
    /// </summary>
    public unsafe virtual void SetLastManStandingPRI(BmSDK.BmGame.GDGIBase.ETeamType ForTeam, BmSDK.BmGame.RPlayerRI PRI)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLastManStandingPRI, "BmGame.GDGameReplicationInfo_Gangland.SetLastManStandingPRI");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForTeam, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PRI, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowObjectiveMessageString;
    /// <summary>
    /// Function: ShowObjectiveMessageString
    /// </summary>
    public unsafe virtual void ShowObjectiveMessageString(BmSDK.FString MessageString)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowObjectiveMessageString, "BmGame.GDGameReplicationInfo_Gangland.ShowObjectiveMessageString");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MessageString, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HeroDeathTriggeredRespawn;
    /// <summary>
    /// Function: HeroDeathTriggeredRespawn
    /// </summary>
    public unsafe virtual void HeroDeathTriggeredRespawn(BmSDK.BmGame.GDGIBase.ETeamType KillingTeam)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HeroDeathTriggeredRespawn, "BmGame.GDGameReplicationInfo_Gangland.HeroDeathTriggeredRespawn");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KillingTeam, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldBarkUseSecondaryCommander;
    /// <summary>
    /// Function: ShouldBarkUseSecondaryCommander
    /// </summary>
    public unsafe override bool ShouldBarkUseSecondaryCommander(BmSDK.BmGame.GDBarkEvent BarkEvent, BmSDK.BmGame.GDGIBase.ETeamType TeamType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldBarkUseSecondaryCommander, "BmGame.GDGameReplicationInfo_Gangland.ShouldBarkUseSecondaryCommander");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkEvent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetTeamTicketsInPlay;
    /// <summary>
    /// Function: GetTeamTicketsInPlay
    /// </summary>
    public unsafe virtual int GetTeamTicketsInPlay(BmSDK.BmGame.GDGIBase.ETeamType Team)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTeamTicketsInPlay, "BmGame.GDGameReplicationInfo_Gangland.GetTeamTicketsInPlay");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ShowZeroTicketsMessage;
    /// <summary>
    /// Function: ShowZeroTicketsMessage
    /// </summary>
    public unsafe virtual void ShowZeroTicketsMessage(BmSDK.BmGame.GDGIBase.ETeamType ZeroTicketTeam)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowZeroTicketsMessage, "BmGame.GDGameReplicationInfo_Gangland.ShowZeroTicketsMessage");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ZeroTicketTeam, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnZeroTickets;
    /// <summary>
    /// Function: OnZeroTickets
    /// </summary>
    public unsafe virtual void OnZeroTickets(BmSDK.BmGame.GDGIBase.ETeamType ZeroTicketTeam)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnZeroTickets, "BmGame.GDGameReplicationInfo_Gangland.OnZeroTickets");
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ZeroTicketTeam, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ModifyTeamTicketCount;
    /// <summary>
    /// Function: ModifyTeamTicketCount
    /// </summary>
    public unsafe virtual void ModifyTeamTicketCount(BmSDK.BmGame.GDGIBase.ETeamType Team, int TicketMod, BmSDK.BmGame.GDGameReplicationInfo_Gangland.ETicketModReason Reason)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyTeamTicketCount, "BmGame.GDGameReplicationInfo_Gangland.ModifyTeamTicketCount");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TicketMod, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Reason, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRemainingTicketRatio;
    /// <summary>
    /// Function: GetRemainingTicketRatio
    /// </summary>
    public unsafe virtual float GetRemainingTicketRatio(BmSDK.BmGame.GDGIBase.ETeamType ForTeam, bool bIncludeInPlayTickets = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRemainingTicketRatio, "BmGame.GDGameReplicationInfo_Gangland.GetRemainingTicketRatio");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForTeam, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIncludeInPlayTickets, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetRemainingTicketCount;
    /// <summary>
    /// Function: GetRemainingTicketCount
    /// </summary>
    public unsafe virtual int GetRemainingTicketCount(BmSDK.BmGame.GDGIBase.ETeamType ForTeam)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRemainingTicketCount, "BmGame.GDGameReplicationInfo_Gangland.GetRemainingTicketCount");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForTeam, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_BarkOnSupervillainEntered;
    /// <summary>
    /// Function: BarkOnSupervillainEntered
    /// </summary>
    public unsafe virtual void BarkOnSupervillainEntered()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BarkOnSupervillainEntered, "BmGame.GDGameReplicationInfo_Gangland.BarkOnSupervillainEntered");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BarkOnComeback;
    /// <summary>
    /// Function: BarkOnComeback
    /// </summary>
    public unsafe virtual void BarkOnComeback(bool IsHeroTeam, bool IsComebackTeam, bool IsComebackKiller)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BarkOnComeback, "BmGame.GDGameReplicationInfo_Gangland.BarkOnComeback");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsHeroTeam, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsComebackTeam, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsComebackKiller, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BarkOnCaptainFail;
    /// <summary>
    /// Function: BarkOnCaptainFail
    /// </summary>
    public unsafe virtual void BarkOnCaptainFail(bool CaptainWasYou)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BarkOnCaptainFail, "BmGame.GDGameReplicationInfo_Gangland.BarkOnCaptainFail");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CaptainWasYou, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BarkOnChain;
    /// <summary>
    /// Function: BarkOnChain
    /// </summary>
    public unsafe virtual void BarkOnChain()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BarkOnChain, "BmGame.GDGameReplicationInfo_Gangland.BarkOnChain");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BarkOnBoring;
    /// <summary>
    /// Function: BarkOnBoring
    /// </summary>
    public unsafe virtual void BarkOnBoring()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BarkOnBoring, "BmGame.GDGameReplicationInfo_Gangland.BarkOnBoring");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BarkOnLastGangMemberAlive;
    /// <summary>
    /// Function: BarkOnLastGangMemberAlive
    /// </summary>
    public unsafe virtual void BarkOnLastGangMemberAlive()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BarkOnLastGangMemberAlive, "BmGame.GDGameReplicationInfo_Gangland.BarkOnLastGangMemberAlive");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BarkOnSuperVillainNear;
    /// <summary>
    /// Function: BarkOnSuperVillainNear
    /// </summary>
    public unsafe virtual void BarkOnSuperVillainNear()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BarkOnSuperVillainNear, "BmGame.GDGameReplicationInfo_Gangland.BarkOnSuperVillainNear");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BarkOnSuperVillainDoorUsed;
    /// <summary>
    /// Function: BarkOnSuperVillainDoorUsed
    /// </summary>
    public unsafe virtual void BarkOnSuperVillainDoorUsed(bool bLocalPlayerTeamUsed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BarkOnSuperVillainDoorUsed, "BmGame.GDGameReplicationInfo_Gangland.BarkOnSuperVillainDoorUsed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLocalPlayerTeamUsed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BarkOnSuperVillainDoorActive;
    /// <summary>
    /// Function: BarkOnSuperVillainDoorActive
    /// </summary>
    public unsafe virtual void BarkOnSuperVillainDoorActive()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BarkOnSuperVillainDoorActive, "BmGame.GDGameReplicationInfo_Gangland.BarkOnSuperVillainDoorActive");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BarkOnSupervilllainAdvancedWarning;
    /// <summary>
    /// Function: BarkOnSupervilllainAdvancedWarning
    /// </summary>
    public unsafe virtual void BarkOnSupervilllainAdvancedWarning()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BarkOnSupervilllainAdvancedWarning, "BmGame.GDGameReplicationInfo_Gangland.BarkOnSupervilllainAdvancedWarning");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BarkOnGangReachedZeroTickets;
    /// <summary>
    /// Function: BarkOnGangReachedZeroTickets
    /// </summary>
    public unsafe virtual void BarkOnGangReachedZeroTickets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BarkOnGangReachedZeroTickets, "BmGame.GDGameReplicationInfo_Gangland.BarkOnGangReachedZeroTickets");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BarkOnMajorityControlTeamChanged;
    /// <summary>
    /// Function: BarkOnMajorityControlTeamChanged
    /// </summary>
    public unsafe virtual void BarkOnMajorityControlTeamChanged()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BarkOnMajorityControlTeamChanged, "BmGame.GDGameReplicationInfo_Gangland.BarkOnMajorityControlTeamChanged");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdatePointMajority;
    /// <summary>
    /// Function: UpdatePointMajority
    /// </summary>
    public unsafe virtual void UpdatePointMajority()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePointMajority, "BmGame.GDGameReplicationInfo_Gangland.UpdatePointMajority");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ControlPointCountUpdated;
    /// <summary>
    /// Function: ControlPointCountUpdated
    /// </summary>
    public unsafe virtual void ControlPointCountUpdated()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ControlPointCountUpdated, "BmGame.GDGameReplicationInfo_Gangland.ControlPointCountUpdated");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetControlPointState;
    /// <summary>
    /// Function: SetControlPointState
    /// </summary>
    public unsafe override void SetControlPointState(int Index, BmSDK.BmGame.GDGameReplicationInfo_ControlPoints.EControlPointState CPState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetControlPointState, "BmGame.GDGameReplicationInfo_Gangland.SetControlPointState");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CPState, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnTicketCountChanged;
    /// <summary>
    /// Function: OnTicketCountChanged
    /// </summary>
    public unsafe virtual void OnTicketCountChanged(BmSDK.BmGame.GDGIBase.ETeamType TeamType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnTicketCountChanged, "BmGame.GDGameReplicationInfo_Gangland.OnTicketCountChanged");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayGetHeroBark;
    /// <summary>
    /// Function: PlayGetHeroBark
    /// </summary>
    public unsafe virtual void PlayGetHeroBark()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayGetHeroBark, "BmGame.GDGameReplicationInfo_Gangland.PlayGetHeroBark");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayLastFearBark;
    /// <summary>
    /// Function: PlayLastFearBark
    /// </summary>
    public unsafe virtual void PlayLastFearBark()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayLastFearBark, "BmGame.GDGameReplicationInfo_Gangland.PlayLastFearBark");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckHeroScore;
    /// <summary>
    /// Function: CheckHeroScore
    /// </summary>
    public unsafe override void CheckHeroScore(int OldScore, int NewScore, int TeamGoalScore, BmSDK.FName TeamName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckHeroScore, "BmGame.GDGameReplicationInfo_Gangland.CheckHeroScore");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldScore, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewScore, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamGoalScore, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.GDGameReplicationInfo_Gangland.Tick");
        byte* paramsPtr = stackalloc byte[37];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReplicatedEvent;
    /// <summary>
    /// Function: ReplicatedEvent
    /// </summary>
    public unsafe override void ReplicatedEvent(BmSDK.FName VarName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplicatedEvent, "BmGame.GDGameReplicationInfo_Gangland.ReplicatedEvent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderMajority
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderMajority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2512); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderZeroTickets
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderZeroTickets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2516); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderLastGangMemberAlive
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderLastGangMemberAlive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2520); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderEscape
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderEscape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2524); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderEscapeTime
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderEscapeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2528); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderOnBoring
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderOnBoring
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2532); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderOnCaptainFail
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderOnCaptainFail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2536); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderOnCaptainKilled
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderOnCaptainKilled
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2540); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderOnComeback
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderOnComeback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2544); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderOnYouComeback
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderOnYouComeback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2548); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderOnYouRespawn
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderOnYouRespawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2552); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderOnTheyComeback
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderOnTheyComeback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2556); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderOnVillainNear
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderOnVillainNear
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2560); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderOnVillainSpawn
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderOnVillainSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2564); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventHeroOnVillainSpawnComment
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventHeroOnVillainSpawnComment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2568); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderGetHero
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderGetHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2572); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderOnVillainSpawnNotification
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderOnVillainSpawnNotification
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2576); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventHeroOnVillainSpawnNotification
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventHeroOnVillainSpawnNotification
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2580); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderFearHigh
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderFearHigh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2584); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderFearHighLastFirstTime
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderFearHighLastFirstTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2588); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventCommanderFearHighLast
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventCommanderFearHighLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2592); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventSupervillainAdvancedNotification
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventSupervillainAdvancedNotification
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2596); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventSupervillainDoorActive
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventSupervillainDoorActive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventSupervillainDoorUsedFriendly
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventSupervillainDoorUsedFriendly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2604); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventSupervillainDoorUsedEnemy
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventSupervillainDoorUsedEnemy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventVillainSpawnComment
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventVillainSpawnComment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 2612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2612); }
    }

    /// <summary>
    /// ObjectProperty: MusicEventYourThugTeamKillsHero
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent MusicEventYourThugTeamKillsHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2616); }
    }

    /// <summary>
    /// IntProperty: MaxTickets
    /// </summary>
    public unsafe int MaxTickets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2620); }
    }

    /// <summary>
    /// IntProperty: JokerGangTicketCount
    /// </summary>
    public unsafe int JokerGangTicketCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }

    /// <summary>
    /// IntProperty: BaneGangTicketCount
    /// </summary>
    public unsafe int BaneGangTicketCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2628); }
    }

    /// <summary>
    /// IntProperty: ClientJokerGangOldTicketCount
    /// </summary>
    public unsafe int ClientJokerGangOldTicketCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2632); }
    }

    /// <summary>
    /// IntProperty: ClientBaneGangOldTicketCount
    /// </summary>
    public unsafe int ClientBaneGangOldTicketCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2636); }
    }

    /// <summary>
    /// ByteProperty: MajorityControlTeam
    /// </summary>
    public unsafe BmSDK.BmGame.GDGIBase.ETeamType MajorityControlTeam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGIBase.ETeamType>(Ptr + 2640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2640); }
    }

    /// <summary>
    /// ByteProperty: SpawnedSupervillainTeam
    /// </summary>
    public unsafe BmSDK.BmGame.GDGIBase.ETeamType SpawnedSupervillainTeam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGIBase.ETeamType>(Ptr + 2641); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2641); }
    }

    /// <summary>
    /// InlineArray{ByteProperty}: CapturingControlPointBarkPlayed
    /// </summary>
    public InlineArray<byte> CapturingControlPointBarkPlayed => new(5, Ptr + 2642, 1, this);

    /// <summary>
    /// ByteProperty: CapturingControlPointBarkPlayed
    /// </summary>
    public unsafe byte CapturingControlPointBarkPlayed_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2642); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2642); }
    }
    /// <summary>
    /// ByteProperty: CapturingControlPointBarkPlayed
    /// </summary>
    public unsafe byte CapturingControlPointBarkPlayed_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2643); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2643); }
    }
    /// <summary>
    /// ByteProperty: CapturingControlPointBarkPlayed
    /// </summary>
    public unsafe byte CapturingControlPointBarkPlayed_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2644); }
    }
    /// <summary>
    /// ByteProperty: CapturingControlPointBarkPlayed
    /// </summary>
    public unsafe byte CapturingControlPointBarkPlayed_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2645); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2645); }
    }
    /// <summary>
    /// ByteProperty: CapturingControlPointBarkPlayed
    /// </summary>
    public unsafe byte CapturingControlPointBarkPlayed_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2646); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2646); }
    }

    /// <summary>
    /// ByteProperty: LastTicketLossCause
    /// </summary>
    public unsafe BmSDK.BmGame.GDGameReplicationInfo_Gangland.ETicketModReason LastTicketLossCause
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGameReplicationInfo_Gangland.ETicketModReason>(Ptr + 2647); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2647); }
    }

    /// <summary>
    /// IntProperty: JokerGangControlPointCount
    /// </summary>
    public unsafe int JokerGangControlPointCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2648); }
    }

    /// <summary>
    /// IntProperty: BaneGangControlPointCount
    /// </summary>
    public unsafe int BaneGangControlPointCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2652); }
    }

    /// <summary>
    /// IntProperty: MajorityDiff
    /// </summary>
    public unsafe int MajorityDiff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2656); }
    }

    /// <summary>
    /// IntProperty: BaneHeroDeathRespawnCount
    /// </summary>
    public unsafe int BaneHeroDeathRespawnCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2660); }
    }

    /// <summary>
    /// IntProperty: JokerHeroDeathRespawnCount
    /// </summary>
    public unsafe int JokerHeroDeathRespawnCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2664); }
    }

    /// <summary>
    /// IntProperty: CurrentMajorityTicketLoss
    /// </summary>
    public unsafe int CurrentMajorityTicketLoss
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2668); }
    }

    /// <summary>
    /// StructProperty: FinaleObjective
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGameReplicationInfo_Gangland.FSFinaleObjective FinaleObjective
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGameReplicationInfo_Gangland.FSFinaleObjective>(Ptr + 2672);

    /// <summary>
    /// ObjectProperty: SupervillainSpawnDoor
    /// </summary>
    public unsafe BmSDK.BmGame.GDExitDoorObjectBase SupervillainSpawnDoor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDExitDoorObjectBase>(Ptr + 2716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2716); }
    }

    /// <summary>
    /// FloatProperty: SupervillainDoorActivateTime
    /// </summary>
    public unsafe float SupervillainDoorActivateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2720); }
    }

    /// <summary>
    /// FloatProperty: SupervillainDoorActivateDelay
    /// </summary>
    public unsafe float SupervillainDoorActivateDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2724); }
    }

    /// <summary>
    /// BoolProperty: bSupervillainIsAlive
    /// </summary>
    public unsafe bool bSupervillainIsAlive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2728) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2728); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2728); }
    }

    /// <summary>
    /// BoolProperty: bSupervillainWasAlive
    /// </summary>
    public unsafe bool bSupervillainWasAlive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2728) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2728); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2728); }
    }

    /// <summary>
    /// BoolProperty: bSupervillainFinishedSpawning
    /// </summary>
    public unsafe bool bSupervillainFinishedSpawning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2728) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2728); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2728); }
    }

    /// <summary>
    /// BoolProperty: bWasSupervillainSpawnDoorActive
    /// </summary>
    public unsafe bool bWasSupervillainSpawnDoorActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2728) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2728); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2728); }
    }

    /// <summary>
    /// BoolProperty: WasSupervillainSpawnDoorShown
    /// </summary>
    public unsafe bool WasSupervillainSpawnDoorShown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2728) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2728); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2728); }
    }

    /// <summary>
    /// BoolProperty: EscapeMusicTriggered
    /// </summary>
    public unsafe bool EscapeMusicTriggered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2728) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2728); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2728); }
    }

    /// <summary>
    /// BoolProperty: AproachingEndStingPlayed
    /// </summary>
    public unsafe bool AproachingEndStingPlayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2728) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2728); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2728); }
    }

    /// <summary>
    /// BoolProperty: RoundEndingStingPlayed
    /// </summary>
    public unsafe bool RoundEndingStingPlayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2728) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2728); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2728); }
    }

    /// <summary>
    /// BoolProperty: bPlayingGetHeroBark
    /// </summary>
    public unsafe bool bPlayingGetHeroBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2728) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2728); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2728); }
    }

    /// <summary>
    /// BoolProperty: bPlayingLastFearBark
    /// </summary>
    public unsafe bool bPlayingLastFearBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2728) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2728); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2728); }
    }

    /// <summary>
    /// BoolProperty: bHasDoneFirstHighFearWarning
    /// </summary>
    public unsafe bool bHasDoneFirstHighFearWarning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2728) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2728); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2728); }
    }

    /// <summary>
    /// BoolProperty: bJokerEligibleForCleanSheet
    /// </summary>
    public unsafe bool bJokerEligibleForCleanSheet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2728) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2728); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2728); }
    }

    /// <summary>
    /// BoolProperty: bBaneEligibleForCleanSheet
    /// </summary>
    public unsafe bool bBaneEligibleForCleanSheet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2728) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2728); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2728); }
    }

    /// <summary>
    /// ObjectProperty: LastManStandingPRIJoker
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerRI LastManStandingPRIJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerRI>(Ptr + 2732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2732); }
    }

    /// <summary>
    /// ObjectProperty: LastManStandingPRIBane
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerRI LastManStandingPRIBane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerRI>(Ptr + 2736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2736); }
    }

    /// <summary>
    /// ArrayProperty: ZeroTicketTeams
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDGIBase.ETeamType> ZeroTicketTeams
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDGIBase.ETeamType>>(Ptr + 2740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2740); }
    }

    /// <summary>
    /// FloatProperty: AproachingEndStingPercentageTrigger
    /// </summary>
    public unsafe float AproachingEndStingPercentageTrigger
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2752); }
    }

    /// <summary>
    /// FloatProperty: RoundEndingStingPercentageTrigger
    /// </summary>
    public unsafe float RoundEndingStingPercentageTrigger
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2756); }
    }

    /// <summary>
    /// IntProperty: TimeleftToTriggerEscapeMusicState
    /// </summary>
    public unsafe int TimeleftToTriggerEscapeMusicState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2760); }
    }

    /// <summary>
    /// IntProperty: OldJokerGangControlPointCount
    /// </summary>
    public unsafe int OldJokerGangControlPointCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2764); }
    }

    /// <summary>
    /// IntProperty: OldBaneGangControlPointCount
    /// </summary>
    public unsafe int OldBaneGangControlPointCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2768); }
    }

    /// <summary>
    /// FloatProperty: TicketCycleInterval
    /// </summary>
    public unsafe float TicketCycleInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2772); }
    }

    /// <summary>
    /// FloatProperty: NextTicketCycleTime
    /// </summary>
    public unsafe float NextTicketCycleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2776); }
    }

    /// <summary>
    /// FloatProperty: DeputyDoorActiveBarkDelay
    /// </summary>
    public unsafe float DeputyDoorActiveBarkDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2780); }
    }

    /// <summary>
    /// IntProperty: BoringCount
    /// </summary>
    public unsafe int BoringCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2784); }
    }

    /// <summary>
    /// IntProperty: PlayBoringAtCount
    /// </summary>
    public unsafe int PlayBoringAtCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2788); }
    }

    /// <summary>
    /// IntProperty: BoringRepeatCount
    /// </summary>
    public unsafe int BoringRepeatCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2792); }
    }

    /// <summary>
    /// Enum: ETicketModReason
    /// </summary>
    public enum ETicketModReason : byte
    {
        ETicketModReason_Invalid = 0,
        ETicketModReason_PlayerDeath = 1,
        ETicketModReason_ControlPointCaptured = 2,
        ETicketModReason_ControlPointPulse = 3,
        ETicketModReason_MAX = 4,
    }

    /// <summary>
    /// Struct: FSFinaleObjective
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial record struct FSFinaleObjective
    {
        /// <summary>
        /// BoolProperty: bActive
        /// </summary>
        public unsafe bool bActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bFinished
        /// </summary>
        public unsafe bool bFinished
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Location
        /// </summary>
        public unsafe System.Numerics.Vector3 Location
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: Rotation
        /// </summary>
        public unsafe BmSDK.Rotator Rotation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// BoolProperty: bOpen
        /// </summary>
        public unsafe bool bOpen
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// StructProperty: MarkerLocationOffset
        /// </summary>
        public unsafe System.Numerics.Vector3 MarkerLocationOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
    }
}
