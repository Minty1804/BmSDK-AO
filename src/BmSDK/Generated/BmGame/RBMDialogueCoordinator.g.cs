#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMDialogueCoordinator<br/>
/// (size = 608)
/// (flags = 142606482)
/// </summary>
public partial class RBMDialogueCoordinator : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMDialogueCoordinator", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMDialogueCoordinator.
    /// </summary>
    public static RBMDialogueCoordinator DefaultObject => (RBMDialogueCoordinator)StaticClass().DefaultObject;

    internal RBMDialogueCoordinator() { }

    /// <summary>
    /// Constructs a new RBMDialogueCoordinator
    /// </summary>
    public RBMDialogueCoordinator(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMDialogueCoordinator(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMDialogueCoordinator>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMDialogueCoordinator>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMDialogueCoordinator>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMDialogueCoordinator>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMDialogueCoordinator>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMDialogueCoordinator>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMDialogueCoordinator>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMDialogueCoordinator>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe virtual void Init()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.RBMDialogueCoordinator.Init");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DecreaseDialogueFrequency;
    /// <summary>
    /// Function: DecreaseDialogueFrequency
    /// </summary>
    public unsafe virtual void DecreaseDialogueFrequency()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DecreaseDialogueFrequency, "BmGame.RBMDialogueCoordinator.DecreaseDialogueFrequency");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetRoomSpecificBias;
    /// <summary>
    /// Function: ResetRoomSpecificBias
    /// </summary>
    public unsafe virtual void ResetRoomSpecificBias()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetRoomSpecificBias, "BmGame.RBMDialogueCoordinator.ResetRoomSpecificBias");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDeadGuyBark;
    /// <summary>
    /// Function: GetDeadGuyBark
    /// </summary>
    public unsafe virtual BmSDK.Engine.RDialogueLine GetDeadGuyBark(BmSDK.BmGame.RPawnVillain DeadGuy)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDeadGuyBark, "BmGame.RBMDialogueCoordinator.GetDeadGuyBark");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeadGuy, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.RDialogueLine>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_InstigateRandomBark;
    /// <summary>
    /// Function: InstigateRandomBark
    /// </summary>
    public unsafe virtual void InstigateRandomBark()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InstigateRandomBark, "BmGame.RBMDialogueCoordinator.InstigateRandomBark");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FunctionalityTest;
    /// <summary>
    /// Function: FunctionalityTest
    /// </summary>
    public unsafe virtual void FunctionalityTest()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FunctionalityTest, "BmGame.RBMDialogueCoordinator.FunctionalityTest");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpQueueStateToLog;
    /// <summary>
    /// Function: DumpQueueStateToLog
    /// </summary>
    public unsafe virtual void DumpQueueStateToLog()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpQueueStateToLog, "BmGame.RBMDialogueCoordinator.DumpQueueStateToLog");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitialiseSpeakers;
    /// <summary>
    /// Function: InitialiseSpeakers
    /// </summary>
    public unsafe virtual void InitialiseSpeakers()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialiseSpeakers, "BmGame.RBMDialogueCoordinator.InitialiseSpeakers");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PawnDied;
    /// <summary>
    /// Function: PawnDied
    /// </summary>
    public unsafe virtual void PawnDied(BmSDK.BmGame.RBMPawnAI DeadPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnDied, "BmGame.RBMDialogueCoordinator.PawnDied");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeadPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetReplyBarkType;
    /// <summary>
    /// Function: GetReplyBarkType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBarkSet.EConvoBarkType GetReplyBarkType(BmSDK.BmGame.RBarkSet.EConvoBarkType CurrentState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetReplyBarkType, "BmGame.RBMDialogueCoordinator.GetReplyBarkType");
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBarkSet.EConvoBarkType>(paramsPtr + 1);
    }

    private static BmSDK.Function __fn_GetFollowOnBarkType;
    /// <summary>
    /// Function: GetFollowOnBarkType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBarkSet.EConvoBarkType GetFollowOnBarkType(BmSDK.BmGame.RBarkSet.EConvoBarkType CurrentState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFollowOnBarkType, "BmGame.RBMDialogueCoordinator.GetFollowOnBarkType");
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBarkSet.EConvoBarkType>(paramsPtr + 1);
    }

    private static BmSDK.Function __fn_ContinuePercentage;
    /// <summary>
    /// Function: ContinuePercentage
    /// </summary>
    public unsafe virtual float ContinuePercentage(BmSDK.BmGame.RBarkSet.EConvoBarkType CurrentState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ContinuePercentage, "BmGame.RBMDialogueCoordinator.ContinuePercentage");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ContinueConversation;
    /// <summary>
    /// Function: ContinueConversation
    /// </summary>
    public unsafe virtual bool ContinueConversation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ContinueConversation, "BmGame.RBMDialogueCoordinator.ContinueConversation");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FreeLock;
    /// <summary>
    /// Function: FreeLock
    /// </summary>
    public unsafe virtual void FreeLock(BmSDK.BmGame.RAlertEventCoordinatorBase ExLockee)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FreeLock, "BmGame.RBMDialogueCoordinator.FreeLock");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExLockee, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLock;
    /// <summary>
    /// Function: SetLock
    /// </summary>
    public unsafe virtual void SetLock(BmSDK.BmGame.RAlertEventCoordinatorBase NewLockee)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLock, "BmGame.RBMDialogueCoordinator.SetLock");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLockee, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DialogueLockedByEvent;
    /// <summary>
    /// Function: DialogueLockedByEvent
    /// </summary>
    public unsafe virtual bool DialogueLockedByEvent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DialogueLockedByEvent, "BmGame.RBMDialogueCoordinator.DialogueLockedByEvent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPlayBark;
    /// <summary>
    /// Function: CanPlayBark
    /// </summary>
    public unsafe virtual bool CanPlayBark()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayBark, "BmGame.RBMDialogueCoordinator.CanPlayBark");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopCurrentConversationIfPawnInvolved;
    /// <summary>
    /// Function: StopCurrentConversationIfPawnInvolved
    /// </summary>
    public unsafe virtual void StopCurrentConversationIfPawnInvolved(BmSDK.BmGame.RPawnVillain Pawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopCurrentConversationIfPawnInvolved, "BmGame.RBMDialogueCoordinator.StopCurrentConversationIfPawnInvolved");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopCurrentConversation;
    /// <summary>
    /// Function: StopCurrentConversation
    /// </summary>
    public unsafe virtual void StopCurrentConversation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopCurrentConversation, "BmGame.RBMDialogueCoordinator.StopCurrentConversation");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayCurrentLine;
    /// <summary>
    /// Function: PlayCurrentLine
    /// </summary>
    public unsafe virtual void PlayCurrentLine()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCurrentLine, "BmGame.RBMDialogueCoordinator.PlayCurrentLine");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddFollowOnConversation;
    /// <summary>
    /// Function: AddFollowOnConversation
    /// </summary>
    public unsafe virtual bool AddFollowOnConversation(BmSDK.BmGame.RPawnVillain Speaker, BmSDK.BmGame.RBarkFlagBase ContextFlags)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddFollowOnConversation, "BmGame.RBMDialogueCoordinator.AddFollowOnConversation");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speaker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContextFlags, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_QueueBarkConversation;
    /// <summary>
    /// Function: QueueBarkConversation
    /// </summary>
    public unsafe virtual bool QueueBarkConversation(BmSDK.BmGame.RBMPawnAI Speaker, int Priority, BmSDK.BmGame.RBarkFlagBase ContextFlags)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueueBarkConversation, "BmGame.RBMDialogueCoordinator.QueueBarkConversation");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speaker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContextFlags, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_PawnPlayBark;
    /// <summary>
    /// Function: PawnPlayBark
    /// </summary>
    public unsafe virtual void PawnPlayBark(BmSDK.BmGame.RBMPawnAI Speaker, BmSDK.BmGame.RBarkFlagBase ContextFlags)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnPlayBark, "BmGame.RBMDialogueCoordinator.PawnPlayBark");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speaker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContextFlags, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PawnIsCurrentSpeaker;
    /// <summary>
    /// Function: PawnIsCurrentSpeaker
    /// </summary>
    public unsafe virtual bool PawnIsCurrentSpeaker(BmSDK.BmGame.RBMPawnAI TestPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnIsCurrentSpeaker, "BmGame.RBMDialogueCoordinator.PawnIsCurrentSpeaker");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HasBarksToPlay;
    /// <summary>
    /// Function: HasBarksToPlay
    /// </summary>
    public unsafe virtual bool HasBarksToPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasBarksToPlay, "BmGame.RBMDialogueCoordinator.HasBarksToPlay");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ResetLastSpeechTime;
    /// <summary>
    /// Function: ResetLastSpeechTime
    /// </summary>
    public unsafe virtual void ResetLastSpeechTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetLastSpeechTime, "BmGame.RBMDialogueCoordinator.ResetLastSpeechTime");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GameInfoTick;
    /// <summary>
    /// Function: GameInfoTick
    /// </summary>
    public unsafe virtual void GameInfoTick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GameInfoTick, "BmGame.RBMDialogueCoordinator.GameInfoTick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddScriptedConversationBehaviour;
    /// <summary>
    /// Function: AddScriptedConversationBehaviour
    /// </summary>
    public unsafe virtual void AddScriptedConversationBehaviour(BmSDK.BmGame.RBMBehaviour_StartConversation Conversation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddScriptedConversationBehaviour, "BmGame.RBMDialogueCoordinator.AddScriptedConversationBehaviour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Conversation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveScriptedConversationBehaviour;
    /// <summary>
    /// Function: RemoveScriptedConversationBehaviour
    /// </summary>
    public unsafe virtual void RemoveScriptedConversationBehaviour(BmSDK.BmGame.RBMBehaviour_StartConversation Conversation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveScriptedConversationBehaviour, "BmGame.RBMDialogueCoordinator.RemoveScriptedConversationBehaviour");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Conversation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSpeakersScriptedConversation;
    /// <summary>
    /// Function: GetSpeakersScriptedConversation
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMBehaviour_StartConversation GetSpeakersScriptedConversation(BmSDK.Engine.Pawn Speaker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSpeakersScriptedConversation, "BmGame.RBMDialogueCoordinator.GetSpeakersScriptedConversation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speaker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMBehaviour_StartConversation>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsInBarkConversation;
    /// <summary>
    /// Function: IsInBarkConversation
    /// </summary>
    public unsafe virtual bool IsInBarkConversation(BmSDK.Engine.Pawn Speaker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInBarkConversation, "BmGame.RBMDialogueCoordinator.IsInBarkConversation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speaker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetBark;
    /// <summary>
    /// Function: GetBark
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBarkSet.FBarkDefinition GetBark(BmSDK.BmGame.RBMPawnAI Barker, BmSDK.BmGame.RBarkSet.EConvoBarkType BarkType, BmSDK.BmGame.RBarkFlagBase ContextFlags)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBark, "BmGame.RBMDialogueCoordinator.GetBark");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Barker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContextFlags, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBarkSet.FBarkDefinition>(paramsPtr + 12);
    }

    /// <summary>
    /// StructProperty: CurrentConversation
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMDialogueCoordinator.FDialogueInstance CurrentConversation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMDialogueCoordinator.FDialogueInstance>(Ptr + 452);

    /// <summary>
    /// StructProperty: FollowupConversation
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMDialogueCoordinator.FDialogueInstance FollowupConversation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMDialogueCoordinator.FDialogueInstance>(Ptr + 496);

    /// <summary>
    /// ArrayProperty: ScriptedConversationBehaviour
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMBehaviour_StartConversation> ScriptedConversationBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMBehaviour_StartConversation>>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// FloatProperty: TimeWithoutBark
    /// </summary>
    public unsafe float TimeWithoutBark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// BoolProperty: bBarksEnabled
    /// </summary>
    public unsafe bool bBarksEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 556); }
    }

    /// <summary>
    /// BoolProperty: bRandomBarksEnabled
    /// </summary>
    public unsafe bool bRandomBarksEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 556); }
    }

    /// <summary>
    /// BoolProperty: bReactiveBarksOnly
    /// </summary>
    public unsafe bool bReactiveBarksOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 556); }
    }

    /// <summary>
    /// BoolProperty: bPredIdleConfigSpeaking
    /// </summary>
    public unsafe bool bPredIdleConfigSpeaking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 556); }
    }

    /// <summary>
    /// FloatProperty: MinRandomBarkTimeCocky
    /// </summary>
    public unsafe float MinRandomBarkTimeCocky
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// FloatProperty: MinRandomBarkTimeNervous
    /// </summary>
    public unsafe float MinRandomBarkTimeNervous
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// FloatProperty: MinRandomBarkTimeTerrified
    /// </summary>
    public unsafe float MinRandomBarkTimeTerrified
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// FloatProperty: CurrRandomBarkTime
    /// </summary>
    public unsafe float CurrRandomBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// ObjectProperty: Tannoy
    /// </summary>
    public unsafe BmSDK.BmGame.RJokerTannoy Tannoy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJokerTannoy>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// FloatProperty: TimeWithoutTannoyBark
    /// </summary>
    public unsafe float TimeWithoutTannoyBark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// FloatProperty: MinTannoyTime
    /// </summary>
    public unsafe float MinTannoyTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// ArrayProperty: LockList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAlertEventCoordinatorBase> LockList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAlertEventCoordinatorBase>>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// IntProperty: RoomSpecificBias
    /// </summary>
    public unsafe int RoomSpecificBias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// IntProperty: SteelA1SpecialCaseCounter
    /// </summary>
    public unsafe int SteelA1SpecialCaseCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// Struct: FDialogueInstance
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial record struct FDialogueInstance
    {
        /// <summary>
        /// ArrayProperty: DialogueParticipant
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RBMDialogueCoordinator.FParticipantInfo> DialogueParticipant
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMDialogueCoordinator.FParticipantInfo>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: BarkToPlay
        /// </summary>
        public unsafe BmSDK.BmGame.RBarkSet.FBarkDefinition BarkToPlay
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkSet.FBarkDefinition>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: Priority
        /// </summary>
        public unsafe int Priority
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// ObjectProperty: ContextFlags
        /// </summary>
        public unsafe BmSDK.BmGame.RBarkFlagBase ContextFlags
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkFlagBase>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// IntProperty: CurrentSpeaker
        /// </summary>
        public unsafe int CurrentSpeaker
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FParticipantInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial record struct FParticipantInfo
    {
        /// <summary>
        /// ObjectProperty: TalkPawn
        /// </summary>
        public unsafe BmSDK.BmGame.RBMPawnAI TalkPawn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }
}
