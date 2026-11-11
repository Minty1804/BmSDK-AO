#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDSpeechManager<br/>
/// (size = 636)
/// (flags = 142639254)
/// </summary>
public partial class GDSpeechManager : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDSpeechManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDSpeechManager.
    /// </summary>
    public static GDSpeechManager DefaultObject => (GDSpeechManager)StaticClass().DefaultObject;

    internal GDSpeechManager() { }

    /// <summary>
    /// Constructs a new GDSpeechManager
    /// </summary>
    public GDSpeechManager(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDSpeechManager(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDSpeechManager>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDSpeechManager>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDSpeechManager>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDSpeechManager>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDSpeechManager>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDSpeechManager>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDSpeechManager>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDSpeechManager>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.GDSpeechManager.Tick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableTTSCore;
    /// <summary>
    /// Function: EnableTTSCore
    /// </summary>
    public unsafe virtual void EnableTTSCore(bool Enabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableTTSCore, "BmGame.GDSpeechManager.EnableTTSCore");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Enabled, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetSubtitleDebug;
    /// <summary>
    /// Function: SetSubtitleDebug
    /// </summary>
    public unsafe virtual void SetSubtitleDebug(bool Enabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSubtitleDebug, "BmGame.GDSpeechManager.SetSubtitleDebug");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Enabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableTTS;
    /// <summary>
    /// Function: EnableTTS
    /// </summary>
    public unsafe virtual void EnableTTS(bool Enabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableTTS, "BmGame.GDSpeechManager.EnableTTS");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Enabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableBarks;
    /// <summary>
    /// Function: EnableBarks
    /// </summary>
    public unsafe virtual void EnableBarks(bool Enabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableBarks, "BmGame.GDSpeechManager.EnableBarks");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Enabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PauseBarks;
    /// <summary>
    /// Function: PauseBarks
    /// </summary>
    public unsafe virtual void PauseBarks(bool Enabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PauseBarks, "BmGame.GDSpeechManager.PauseBarks");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Enabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientLocalTeamCommanderBarkEvent;
    /// <summary>
    /// Function: ClientLocalTeamCommanderBarkEvent
    /// </summary>
    public unsafe virtual void ClientLocalTeamCommanderBarkEvent(BmSDK.BmGame.GDBarkEvent BarkEvent, BmSDK.FName ArgumentValue = default, BmSDK.FName Argument2Value = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientLocalTeamCommanderBarkEvent, "BmGame.GDSpeechManager.ClientLocalTeamCommanderBarkEvent");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkEvent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArgumentValue, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Argument2Value, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientLocalPawnBarkEvent;
    /// <summary>
    /// Function: ClientLocalPawnBarkEvent
    /// </summary>
    public unsafe virtual void ClientLocalPawnBarkEvent(BmSDK.BmGame.GDBarkEvent BarkEvent, BmSDK.FName ArgumentValue = default, BmSDK.FName Argument2Value = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientLocalPawnBarkEvent, "BmGame.GDSpeechManager.ClientLocalPawnBarkEvent");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkEvent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArgumentValue, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Argument2Value, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BroadcastBarkEventCore;
    /// <summary>
    /// Function: BroadcastBarkEventCore
    /// </summary>
    public unsafe virtual void BroadcastBarkEventCore(BmSDK.BmGame.GDSpeakerInterface Speaker, BmSDK.BmGame.GDTeamInfo SpeakerTeam, BmSDK.BmGame.GDBarkEvent BarkEvent, BmSDK.FName ArgumentValue = default, BmSDK.FName Argument2Value = default, bool IgnoreSpeaker = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BroadcastBarkEventCore, "BmGame.GDSpeechManager.BroadcastBarkEventCore");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speaker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpeakerTeam, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkEvent, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArgumentValue, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Argument2Value, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IgnoreSpeaker, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BroadcastBarkEvent;
    /// <summary>
    /// Function: BroadcastBarkEvent
    /// </summary>
    public unsafe virtual void BroadcastBarkEvent(BmSDK.BmGame.RPawn Speaker, BmSDK.BmGame.GDBarkEvent BarkEvent, BmSDK.FName ArgumentValue = default, BmSDK.FName Argument2Value = default, bool IgnoreSpeaker = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BroadcastBarkEvent, "BmGame.GDSpeechManager.BroadcastBarkEvent");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speaker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkEvent, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArgumentValue, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Argument2Value, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IgnoreSpeaker, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BroadcastBarkEventNeutralizeItem;
    /// <summary>
    /// Function: BroadcastBarkEventNeutralizeItem
    /// </summary>
    public unsafe virtual void BroadcastBarkEventNeutralizeItem(BmSDK.BmGame.RPawn Speaker, bool IsTrick, BmSDK.BmGame.RPawn ItemOwner = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BroadcastBarkEventNeutralizeItem, "BmGame.GDSpeechManager.BroadcastBarkEventNeutralizeItem");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speaker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsTrick, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemOwner, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BroadcastBarkEventAllCommandersWithMusicSting;
    /// <summary>
    /// Function: BroadcastBarkEventAllCommandersWithMusicSting
    /// </summary>
    public unsafe virtual void BroadcastBarkEventAllCommandersWithMusicSting(BmSDK.BmGame.GDBarkEvent BarkEvent, BmSDK.Engine.AkEvent MusicSting, BmSDK.FName ArgumentValue = default, BmSDK.FName Argument2Value = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BroadcastBarkEventAllCommandersWithMusicSting, "BmGame.GDSpeechManager.BroadcastBarkEventAllCommandersWithMusicSting");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkEvent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MusicSting, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArgumentValue, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Argument2Value, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BroadcastBarkEventAllCommanders;
    /// <summary>
    /// Function: BroadcastBarkEventAllCommanders
    /// </summary>
    public unsafe virtual void BroadcastBarkEventAllCommanders(BmSDK.BmGame.GDBarkEvent BarkEvent, BmSDK.FName ArgumentValue = default, BmSDK.FName Argument2Value = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BroadcastBarkEventAllCommanders, "BmGame.GDSpeechManager.BroadcastBarkEventAllCommanders");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkEvent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArgumentValue, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Argument2Value, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QueueBarkEventCore;
    /// <summary>
    /// Function: QueueBarkEventCore
    /// </summary>
    public unsafe virtual void QueueBarkEventCore(BmSDK.BmGame.GDSpeakerInterface Speaker, bool bFriendly, BmSDK.BmGame.GDTeamInfo Team, BmSDK.BmGame.GDBarkEvent BarkEvent, BmSDK.FName ArgumentValue = default, BmSDK.FName Argument2Value = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueueBarkEventCore, "BmGame.GDSpeechManager.QueueBarkEventCore");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speaker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFriendly, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkEvent, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArgumentValue, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Argument2Value, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QueueCommanderBarkEvent;
    /// <summary>
    /// Function: QueueCommanderBarkEvent
    /// </summary>
    public unsafe virtual void QueueCommanderBarkEvent(BmSDK.BmGame.GDSpeakerInterface Speaker, BmSDK.BmGame.GDBarkEvent BarkEvent, BmSDK.FName ArgumentValue = default, BmSDK.FName Argument2Value = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueueCommanderBarkEvent, "BmGame.GDSpeechManager.QueueCommanderBarkEvent");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speaker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkEvent, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArgumentValue, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Argument2Value, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QueueBarkEventVoice;
    /// <summary>
    /// Function: QueueBarkEventVoice
    /// </summary>
    public unsafe virtual void QueueBarkEventVoice(BmSDK.BmGame.GDSpeakerInterface Speaker, BmSDK.BmGame.GDBarkEvent BarkEvent, BmSDK.FName ArgumentValue = default, BmSDK.FName Argument2Value = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueueBarkEventVoice, "BmGame.GDSpeechManager.QueueBarkEventVoice");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speaker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkEvent, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArgumentValue, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Argument2Value, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QueueBarkEvent;
    /// <summary>
    /// Function: QueueBarkEvent
    /// </summary>
    public unsafe virtual void QueueBarkEvent(BmSDK.BmGame.GDSpeakerInterface Speaker, BmSDK.BmGame.GDBarkEvent BarkEvent, BmSDK.FName ArgumentValue = default, BmSDK.FName Argument2Value = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueueBarkEvent, "BmGame.GDSpeechManager.QueueBarkEvent");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speaker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkEvent, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArgumentValue, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Argument2Value, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QueueBarkEventTeam;
    /// <summary>
    /// Function: QueueBarkEventTeam
    /// </summary>
    public unsafe virtual void QueueBarkEventTeam(BmSDK.BmGame.GDSpeakerInterface Speaker, BmSDK.BmGame.GDTeamInfo SpeakerTeam, BmSDK.BmGame.GDBarkEvent BarkEvent, BmSDK.FName ArgumentValue = default, BmSDK.FName Argument2Value = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueueBarkEventTeam, "BmGame.GDSpeechManager.QueueBarkEventTeam");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speaker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpeakerTeam, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkEvent, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArgumentValue, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Argument2Value, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsFriendly;
    /// <summary>
    /// Function: IsFriendly
    /// </summary>
    public unsafe virtual bool IsFriendly(BmSDK.BmGame.GDTeamInfo TeamOne, BmSDK.BmGame.GDTeamInfo TeamTwo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFriendly, "BmGame.GDSpeechManager.IsFriendly");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamOne, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamTwo, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetLocalTeamInfo;
    /// <summary>
    /// Function: GetLocalTeamInfo
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDTeamInfo GetLocalTeamInfo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocalTeamInfo, "BmGame.GDSpeechManager.GetLocalTeamInfo");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDTeamInfo>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetLocalPlayerController;
    /// <summary>
    /// Function: GetLocalPlayerController
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPlayerController GetLocalPlayerController()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocalPlayerController, "BmGame.GDSpeechManager.GetLocalPlayerController");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPlayerController>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetActorSpeechComponent;
    /// <summary>
    /// Function: GetActorSpeechComponent
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDSpeechComponent GetActorSpeechComponent(BmSDK.Engine.Actor Speaker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActorSpeechComponent, "BmGame.GDSpeechManager.GetActorSpeechComponent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speaker, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDSpeechComponent>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ClientCharacterSpeakCore;
    /// <summary>
    /// Function: ClientCharacterSpeakCore
    /// </summary>
    public unsafe virtual void ClientCharacterSpeakCore(BmSDK.Engine.Actor Speaker, BmSDK.FString EventName, BmSDK.TArray<BmSDK.FString> ArgumentValues, bool UseLoudness = default, bool ShowSubtitle = default, System.IntPtr SpeakFinishedDelegate = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientCharacterSpeakCore, "BmGame.GDSpeechManager.ClientCharacterSpeakCore");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speaker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArgumentValues, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UseLoudness, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShowSubtitle, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpeakFinishedDelegate, paramsPtr + 36);
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

    private static BmSDK.Function __fn_ClientLocalTeamCommanderSpeak;
    /// <summary>
    /// Function: ClientLocalTeamCommanderSpeak
    /// </summary>
    public unsafe virtual void ClientLocalTeamCommanderSpeak(BmSDK.FString EventName, bool SecondaryCommander, bool MapSpecific = default, BmSDK.FString ArgumentValue = default, BmSDK.FString Argument2Value = default, bool UseLoudness = default, System.IntPtr SpeakFinishedDelegate = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientLocalTeamCommanderSpeak, "BmGame.GDSpeechManager.ClientLocalTeamCommanderSpeak");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SecondaryCommander, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapSpecific, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArgumentValue, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Argument2Value, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UseLoudness, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpeakFinishedDelegate, paramsPtr + 48);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_ClientCharacterSpeak;
    /// <summary>
    /// Function: ClientCharacterSpeak
    /// </summary>
    public unsafe virtual void ClientCharacterSpeak(BmSDK.BmGame.GDSpeakerInterface Speaker, BmSDK.FString SpeakerName, BmSDK.FString EventName, bool MapSpecific = default, BmSDK.FString ArgumentValue = default, BmSDK.FString Argument2Value = default, bool UseLoudness = default, bool ShowSubtitle = default, System.IntPtr SpeakFinishedDelegate = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientCharacterSpeak, "BmGame.GDSpeechManager.ClientCharacterSpeak");
        byte* paramsPtr = stackalloc byte[112];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speaker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpeakerName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapSpecific, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArgumentValue, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Argument2Value, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UseLoudness, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShowSubtitle, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpeakFinishedDelegate, paramsPtr + 68);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_ClientLocalCharacterSpeak;
    /// <summary>
    /// Function: ClientLocalCharacterSpeak
    /// </summary>
    public unsafe virtual void ClientLocalCharacterSpeak(BmSDK.FString EventName, bool MapSpecific = default, BmSDK.FString ArgumentValue = default, BmSDK.FString Argument2Value = default, bool UseLoudness = default, System.IntPtr SpeakFinishedDelegate = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientLocalCharacterSpeak, "BmGame.GDSpeechManager.ClientLocalCharacterSpeak");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapSpecific, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArgumentValue, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Argument2Value, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UseLoudness, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpeakFinishedDelegate, paramsPtr + 44);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_UseNonEnglishVoiceName;
    /// <summary>
    /// Function: UseNonEnglishVoiceName
    /// </summary>
    public unsafe static bool UseNonEnglishVoiceName()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UseNonEnglishVoiceName, "BmGame.GDSpeechManager.UseNonEnglishVoiceName");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMemberDisplayNameForTeamType;
    /// <summary>
    /// Function: GetMemberDisplayNameForTeamType
    /// </summary>
    public unsafe static BmSDK.FName GetMemberDisplayNameForTeamType(BmSDK.BmGame.GDGIBase.ETeamType Team)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMemberDisplayNameForTeamType, "BmGame.GDSpeechManager.GetMemberDisplayNameForTeamType");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetCommanderVoiceNameForLoadoutTeamId;
    /// <summary>
    /// Function: GetCommanderVoiceNameForLoadoutTeamId
    /// </summary>
    public unsafe static BmSDK.FName GetCommanderVoiceNameForLoadoutTeamId(BmSDK.BmGame.GDGIBase.ETeamType TeamType, bool SecondaryCommander)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCommanderVoiceNameForLoadoutTeamId, "BmGame.GDSpeechManager.GetCommanderVoiceNameForLoadoutTeamId");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SecondaryCommander, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetCommanderVoiceNameForTeamType;
    /// <summary>
    /// Function: GetCommanderVoiceNameForTeamType
    /// </summary>
    public unsafe static BmSDK.FName GetCommanderVoiceNameForTeamType(BmSDK.BmGame.GDGIBase.ETeamType Team, bool SecondaryCommander)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCommanderVoiceNameForTeamType, "BmGame.GDSpeechManager.GetCommanderVoiceNameForTeamType");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SecondaryCommander, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ShouldBarkUseSecondaryCommander;
    /// <summary>
    /// Function: ShouldBarkUseSecondaryCommander
    /// </summary>
    public unsafe virtual bool ShouldBarkUseSecondaryCommander(BmSDK.BmGame.GDBarkEvent BarkEvent, BmSDK.BmGame.GDGIBase.ETeamType TeamType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldBarkUseSecondaryCommander, "BmGame.GDSpeechManager.ShouldBarkUseSecondaryCommander");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkEvent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_LoadSpeechBankCore;
    /// <summary>
    /// Function: LoadSpeechBankCore
    /// </summary>
    public unsafe int LoadSpeechBankCore(BmSDK.FString NewBankName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadSpeechBankCore, "BmGame.GDSpeechManager.LoadSpeechBankCore");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBankName, paramsPtr + 0);
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

    private static BmSDK.Function __fn_LoadSpeechBankCharacterMap;
    /// <summary>
    /// Function: LoadSpeechBankCharacterMap
    /// </summary>
    public unsafe virtual void LoadSpeechBankCharacterMap(BmSDK.FString CharacterName, BmSDK.FString MapName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadSpeechBankCharacterMap, "BmGame.GDSpeechManager.LoadSpeechBankCharacterMap");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadSpeechBankMap;
    /// <summary>
    /// Function: LoadSpeechBankMap
    /// </summary>
    public unsafe virtual void LoadSpeechBankMap(BmSDK.FString MapName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadSpeechBankMap, "BmGame.GDSpeechManager.LoadSpeechBankMap");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadSpeechBankCharacter;
    /// <summary>
    /// Function: LoadSpeechBankCharacter
    /// </summary>
    public unsafe virtual void LoadSpeechBankCharacter(BmSDK.FString CharacterName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadSpeechBankCharacter, "BmGame.GDSpeechManager.LoadSpeechBankCharacter");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterName, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.GDSpeechManager.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetBarkEvents;
    /// <summary>
    /// Function: ResetBarkEvents
    /// </summary>
    public unsafe virtual void ResetBarkEvents()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetBarkEvents, "BmGame.GDSpeechManager.ResetBarkEvents");
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

    private static BmSDK.Function __fn_PreBeginPlay;
    /// <summary>
    /// Function: PreBeginPlay
    /// </summary>
    public unsafe override void PreBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreBeginPlay, "BmGame.GDSpeechManager.PreBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnSpeakFinished;
    /// <summary>
    /// Function: OnSpeakFinished
    /// </summary>
    public unsafe virtual void OnSpeakFinished()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSpeakFinished, "BmGame.GDSpeechManager.OnSpeakFinished");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateBarkLoudness;
    /// <summary>
    /// Function: UpdateBarkLoudness
    /// </summary>
    public unsafe virtual void UpdateBarkLoudness()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateBarkLoudness, "BmGame.GDSpeechManager.UpdateBarkLoudness");
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

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe virtual void Init()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.GDSpeechManager.Init");
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
    /// ObjectProperty: BarkLoudnessParameterName
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName BarkLoudnessParameterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// StrProperty: BarkLoudnessStateGroup
    /// </summary>
    public unsafe BmSDK.FString BarkLoudnessStateGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// StrProperty: BarkLoudnessStateLoud
    /// </summary>
    public unsafe BmSDK.FString BarkLoudnessStateLoud
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// StrProperty: BarkLoudnessStateQuiet
    /// </summary>
    public unsafe BmSDK.FString BarkLoudnessStateQuiet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// FloatProperty: BarkLoudnessChangeoverValue
    /// </summary>
    public unsafe float BarkLoudnessChangeoverValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// NameProperty: AlfredVoiceName
    /// </summary>
    public unsafe BmSDK.FName AlfredVoiceName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// NameProperty: BaneVoiceName
    /// </summary>
    public unsafe BmSDK.FName BaneVoiceName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// NameProperty: BirdVoiceName
    /// </summary>
    public unsafe BmSDK.FName BirdVoiceName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// NameProperty: JokerVoiceName
    /// </summary>
    public unsafe BmSDK.FName JokerVoiceName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// NameProperty: HarleyVoiceName
    /// </summary>
    public unsafe BmSDK.FName HarleyVoiceName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// NameProperty: BaneThugDisplayName
    /// </summary>
    public unsafe BmSDK.FName BaneThugDisplayName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// NameProperty: JokerThugDisplayName
    /// </summary>
    public unsafe BmSDK.FName JokerThugDisplayName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventOnNeutalizedItemGeneric
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventOnNeutalizedItemGeneric
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventOnNeutalizedItemTrick
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventOnNeutalizedItemTrick
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventOnNeutalizedItemHero
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventOnNeutalizedItemHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventOnNeutalizedItemVillain
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventOnNeutalizedItemVillain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// FloatProperty: BarkEventOnNeutalizedItemTrickChance
    /// </summary>
    public unsafe float BarkEventOnNeutalizedItemTrickChance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// FloatProperty: BarkEventOnNeutalizedItemOwnerChance
    /// </summary>
    public unsafe float BarkEventOnNeutalizedItemOwnerChance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// BoolProperty: BarksEnabled
    /// </summary>
    public unsafe bool BarksEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 588); }
    }

    /// <summary>
    /// BoolProperty: BarksPaused
    /// </summary>
    public unsafe bool BarksPaused
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 588); }
    }

    /// <summary>
    /// BoolProperty: TTSEnabled
    /// </summary>
    public unsafe bool TTSEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 588); }
    }

    /// <summary>
    /// BoolProperty: SubtitleDebug
    /// </summary>
    public unsafe bool SubtitleDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 588); }
    }

    /// <summary>
    /// BoolProperty: BarkIsLoud
    /// </summary>
    public unsafe bool BarkIsLoud
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 588); }
    }

    /// <summary>
    /// ArrayProperty: LoadedBankHashes
    /// </summary>
    public unsafe BmSDK.TArray<int> LoadedBankHashes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// IntProperty: GlobalGameObjectID
    /// </summary>
    public unsafe int GlobalGameObjectID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// IntProperty: GlobalSequenceID
    /// </summary>
    public unsafe int GlobalSequenceID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// ArrayProperty: NonEnglishVoiceMappings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDSpeechManager.FSNonEnglishVoiceMapping> NonEnglishVoiceMappings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDSpeechManager.FSNonEnglishVoiceMapping>>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// DelegateProperty: __OnSpeakFinished__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnSpeakFinished__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// Struct: FSNonEnglishVoiceMapping
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FSNonEnglishVoiceMapping
    {
        /// <summary>
        /// StrProperty: LanguageExtension
        /// </summary>
        public unsafe BmSDK.FString LanguageExtension
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bUseNonEnglishVoice
        /// </summary>
        public unsafe bool bUseNonEnglishVoice
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }
    }
}

/// <summary>
/// The static native functions of GDSpeechManager, callable on an instance. A static native may read the object it runs on, and the static form runs it on the class default object, which has no world.
/// </summary>
public static class GDSpeechManagerStatics
{
    private static BmSDK.Function __fn_UseNonEnglishVoiceName;
    /// <summary>
    /// Function: UseNonEnglishVoiceName, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static bool UseNonEnglishVoiceName(this BmSDK.BmGame.GDSpeechManager self)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UseNonEnglishVoiceName, "BmGame.GDSpeechManager.UseNonEnglishVoiceName");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }
}
