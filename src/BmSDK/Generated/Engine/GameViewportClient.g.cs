#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: GameViewportClient<br/>
/// (size = 288)
/// (flags = 134217918)
/// </summary>
public partial class GameViewportClient : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.GameViewportClient", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GameViewportClient.
    /// </summary>
    public static GameViewportClient DefaultObject => (GameViewportClient)StaticClass().DefaultObject;

    internal GameViewportClient() { }

    /// <summary>
    /// Constructs a new GameViewportClient
    /// </summary>
    public GameViewportClient(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GameViewportClient Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GameViewportClient(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GameViewportClient>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameViewportClient>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GameViewportClient>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameViewportClient>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameViewportClient>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameViewportClient>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GameViewportClient>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameViewportClient>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_DebugSetUISystemEnabled;
    /// <summary>
    /// Function: DebugSetUISystemEnabled
    /// </summary>
    public unsafe virtual void DebugSetUISystemEnabled(bool bOldUISystemActive, bool bGFxUISystemActive)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugSetUISystemEnabled, "Engine.GameViewportClient.DebugSetUISystemEnabled");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOldUISystemActive, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGFxUISystemActive, paramsPtr + 4);
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

    private static BmSDK.Function __fn_FixupOwnerReferences;
    /// <summary>
    /// Function: FixupOwnerReferences
    /// </summary>
    public unsafe virtual void FixupOwnerReferences()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FixupOwnerReferences, "Engine.GameViewportClient.FixupOwnerReferences");
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

    private static BmSDK.Function __fn_GetPlayerOwner;
    /// <summary>
    /// Function: GetPlayerOwner
    /// </summary>
    public unsafe virtual BmSDK.Engine.LocalPlayer GetPlayerOwner(int PlayerIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerOwner, "Engine.GameViewportClient.GetPlayerOwner");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.LocalPlayer>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetDynamicShadows;
    /// <summary>
    /// Function: SetDynamicShadows
    /// </summary>
    public unsafe virtual void SetDynamicShadows(bool OnOrOff)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDynamicShadows, "Engine.GameViewportClient.SetDynamicShadows");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnOrOff, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ClearProgressMessages;
    /// <summary>
    /// Function: ClearProgressMessages
    /// </summary>
    public unsafe virtual void ClearProgressMessages()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearProgressMessages, "Engine.GameViewportClient.ClearProgressMessages");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetProgressTime;
    /// <summary>
    /// Function: SetProgressTime
    /// </summary>
    public unsafe virtual void SetProgressTime(float T)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetProgressTime, "Engine.GameViewportClient.SetProgressTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyConnectionError;
    /// <summary>
    /// Function: NotifyConnectionError
    /// </summary>
    public unsafe virtual void NotifyConnectionError(BmSDK.FString Message = default, BmSDK.FString Title = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyConnectionError, "Engine.GameViewportClient.NotifyConnectionError");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 12);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_SetProgressMessage;
    /// <summary>
    /// Function: SetProgressMessage
    /// </summary>
    public unsafe virtual void SetProgressMessage(BmSDK.Engine.PlayerController.EProgressMessageType MessageType, BmSDK.FString Message, BmSDK.FString Title = default, bool bIgnoreFutureNetworkMessages = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetProgressMessage, "Engine.GameViewportClient.SetProgressMessage");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MessageType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreFutureNetworkMessages, paramsPtr + 28);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_RemoveLocalPlayer;
    /// <summary>
    /// Function: RemoveLocalPlayer
    /// </summary>
    public unsafe int RemoveLocalPlayer(BmSDK.Engine.LocalPlayer ExistingPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveLocalPlayer, "Engine.GameViewportClient.RemoveLocalPlayer");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExistingPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AddLocalPlayer;
    /// <summary>
    /// Function: AddLocalPlayer
    /// </summary>
    public unsafe int AddLocalPlayer(BmSDK.Engine.LocalPlayer NewPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLocalPlayer, "Engine.GameViewportClient.AddLocalPlayer");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_NotifyPlayerRemoved;
    /// <summary>
    /// Function: NotifyPlayerRemoved
    /// </summary>
    public unsafe virtual void NotifyPlayerRemoved(int PlayerIndex, BmSDK.Engine.LocalPlayer RemovedPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyPlayerRemoved, "Engine.GameViewportClient.NotifyPlayerRemoved");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemovedPlayer, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyPlayerAdded;
    /// <summary>
    /// Function: NotifyPlayerAdded
    /// </summary>
    public unsafe virtual void NotifyPlayerAdded(int PlayerIndex, BmSDK.Engine.LocalPlayer AddedPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyPlayerAdded, "Engine.GameViewportClient.NotifyPlayerAdded");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AddedPlayer, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawTransitionMessage;
    /// <summary>
    /// Function: DrawTransitionMessage
    /// </summary>
    public unsafe virtual void DrawTransitionMessage(BmSDK.Engine.Canvas Canvas, BmSDK.FString Message)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawTransitionMessage, "Engine.GameViewportClient.DrawTransitionMessage");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawTransition;
    /// <summary>
    /// Function: DrawTransition
    /// </summary>
    public unsafe virtual void DrawTransition(BmSDK.Engine.Canvas Canvas)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawTransition, "Engine.GameViewportClient.DrawTransition");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostRender;
    /// <summary>
    /// Function: PostRender
    /// </summary>
    public unsafe virtual void PostRender(BmSDK.Engine.Canvas Canvas)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostRender, "Engine.GameViewportClient.PostRender");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawTitleSafeArea;
    /// <summary>
    /// Function: DrawTitleSafeArea
    /// </summary>
    public unsafe virtual void DrawTitleSafeArea(BmSDK.Engine.Canvas Canvas)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawTitleSafeArea, "Engine.GameViewportClient.DrawTitleSafeArea");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe virtual void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "Engine.GameViewportClient.Tick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSubtitleRegion;
    /// <summary>
    /// Function: GetSubtitleRegion
    /// </summary>
    public unsafe virtual void GetSubtitleRegion(out System.Numerics.Vector2 MinPos, out System.Numerics.Vector2 MaxPos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSubtitleRegion, "Engine.GameViewportClient.GetSubtitleRegion");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MinPos);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinPos, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MaxPos);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxPos, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        MinPos = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector2>(paramsPtr + 0);
        MaxPos = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector2>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_LayoutPlayers;
    /// <summary>
    /// Function: LayoutPlayers
    /// </summary>
    public unsafe virtual void LayoutPlayers()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LayoutPlayers, "Engine.GameViewportClient.LayoutPlayers");
        byte* paramsPtr = stackalloc byte[21];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateActiveSplitscreenType;
    /// <summary>
    /// Function: UpdateActiveSplitscreenType
    /// </summary>
    public unsafe virtual void UpdateActiveSplitscreenType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateActiveSplitscreenType, "Engine.GameViewportClient.UpdateActiveSplitscreenType");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSplitscreenConfiguration;
    /// <summary>
    /// Function: GetSplitscreenConfiguration
    /// </summary>
    public unsafe virtual BmSDK.Engine.GameViewportClient.ESplitScreenType GetSplitscreenConfiguration()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSplitscreenConfiguration, "Engine.GameViewportClient.GetSplitscreenConfiguration");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.GameViewportClient.ESplitScreenType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetSplitscreenConfiguration;
    /// <summary>
    /// Function: SetSplitscreenConfiguration
    /// </summary>
    public unsafe virtual void SetSplitscreenConfiguration(BmSDK.Engine.GameViewportClient.ESplitScreenType SplitType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSplitscreenConfiguration, "Engine.GameViewportClient.SetSplitscreenConfiguration");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SplitType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GameSessionEnded;
    /// <summary>
    /// Function: GameSessionEnded
    /// </summary>
    public unsafe virtual void GameSessionEnded()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GameSessionEnded, "Engine.GameViewportClient.GameSessionEnded");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InsertInteraction;
    /// <summary>
    /// Function: InsertInteraction
    /// </summary>
    public unsafe virtual int InsertInteraction(BmSDK.Engine.Interaction NewInteraction, int InIndex = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InsertInteraction, "Engine.GameViewportClient.InsertInteraction");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewInteraction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CreateInitialPlayer;
    /// <summary>
    /// Function: CreateInitialPlayer
    /// </summary>
    public unsafe virtual bool CreateInitialPlayer(out BmSDK.FString OutError)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateInitialPlayer, "Engine.GameViewportClient.CreateInitialPlayer");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutError = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe virtual bool Init(out BmSDK.FString OutError)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "Engine.GameViewportClient.Init");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutError = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_FindPlayerByControllerId;
    /// <summary>
    /// Function: FindPlayerByControllerId
    /// </summary>
    public unsafe virtual BmSDK.Engine.LocalPlayer FindPlayerByControllerId(int ControllerId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPlayerByControllerId, "Engine.GameViewportClient.FindPlayerByControllerId");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.LocalPlayer>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_RemovePlayer;
    /// <summary>
    /// Function: RemovePlayer
    /// </summary>
    public unsafe virtual bool RemovePlayer(BmSDK.Engine.LocalPlayer ExPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemovePlayer, "Engine.GameViewportClient.RemovePlayer");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CreatePlayer;
    /// <summary>
    /// Function: CreatePlayer
    /// </summary>
    public unsafe virtual BmSDK.Engine.LocalPlayer CreatePlayer(int ControllerId, out BmSDK.FString OutError, bool bSpawnActor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreatePlayer, "Engine.GameViewportClient.CreatePlayer");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpawnActor, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutError = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.LocalPlayer>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_SetCustomInteractionObject;
    /// <summary>
    /// Function: SetCustomInteractionObject
    /// </summary>
    public unsafe virtual void SetCustomInteractionObject(BmSDK.Engine.Interaction InInteraction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCustomInteractionObject, "Engine.GameViewportClient.SetCustomInteractionObject");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInteraction, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetCustomInteractionClass;
    /// <summary>
    /// Function: GetCustomInteractionClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetCustomInteractionClass(int InIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCustomInteractionClass, "Engine.GameViewportClient.GetCustomInteractionClass");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InIndex, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetNumCustomInteractions;
    /// <summary>
    /// Function: GetNumCustomInteractions
    /// </summary>
    public unsafe virtual int GetNumCustomInteractions()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumCustomInteractions, "Engine.GameViewportClient.GetNumCustomInteractions");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldForceFullscreenViewport;
    /// <summary>
    /// Function: ShouldForceFullscreenViewport
    /// </summary>
    public unsafe virtual bool ShouldForceFullscreenViewport()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldForceFullscreenViewport, "Engine.GameViewportClient.ShouldForceFullscreenViewport");
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

    private static BmSDK.Function __fn_Is4x3;
    /// <summary>
    /// Function: Is4x3
    /// </summary>
    public unsafe virtual bool Is4x3()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Is4x3, "Engine.GameViewportClient.Is4x3");
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

    private static BmSDK.Function __fn_Is16x9;
    /// <summary>
    /// Function: Is16x9
    /// </summary>
    public unsafe virtual bool Is16x9()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Is16x9, "Engine.GameViewportClient.Is16x9");
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

    private static BmSDK.Function __fn_IsFullScreenViewport;
    /// <summary>
    /// Function: IsFullScreenViewport
    /// </summary>
    public unsafe virtual bool IsFullScreenViewport()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFullScreenViewport, "Engine.GameViewportClient.IsFullScreenViewport");
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

    private static BmSDK.Function __fn_GetViewportSize;
    /// <summary>
    /// Function: GetViewportSize
    /// </summary>
    public unsafe virtual void GetViewportSize(out System.Numerics.Vector2 out_ViewportSize)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetViewportSize, "Engine.GameViewportClient.GetViewportSize");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_ViewportSize);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_ViewportSize, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_ViewportSize = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector2>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_ConsoleCommand;
    /// <summary>
    /// Function: ConsoleCommand
    /// </summary>
    public unsafe virtual BmSDK.FString ConsoleCommand(BmSDK.FString Command)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConsoleCommand, "Engine.GameViewportClient.ConsoleCommand");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Command, paramsPtr + 0);
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

    private static BmSDK.Function __fn_HandleInputChar;
    /// <summary>
    /// Function: HandleInputChar
    /// </summary>
    public unsafe virtual bool HandleInputChar(int ControllerId, BmSDK.FString Unicode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleInputChar, "Engine.GameViewportClient.HandleInputChar");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Unicode, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_HandleInputAxis;
    /// <summary>
    /// Function: HandleInputAxis
    /// </summary>
    public unsafe virtual bool HandleInputAxis(int ControllerId, BmSDK.FName Key, float Delta, float DeltaTime, bool bGamepad)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleInputAxis, "Engine.GameViewportClient.HandleInputAxis");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delta, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGamepad, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_HandleInputKey;
    /// <summary>
    /// Function: HandleInputKey
    /// </summary>
    public unsafe virtual bool HandleInputKey(int ControllerId, BmSDK.FName Key, BmSDK.GameObject.EInputEvent EventType, float AmountDepressed, bool bGamepad = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleInputKey, "Engine.GameViewportClient.HandleInputKey");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventType, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AmountDepressed, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGamepad, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    /// <summary>
    /// Struct: FDebugDisplayProperty
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FDebugDisplayProperty
    {
        /// <summary>
        /// ObjectProperty: Obj
        /// </summary>
        public unsafe BmSDK.GameObject Obj
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: PropertyName
        /// </summary>
        public unsafe BmSDK.FName PropertyName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bSpecialProperty
        /// </summary>
        public unsafe bool bSpecialProperty
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FSplitscreenData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FSplitscreenData
    {
        /// <summary>
        /// ArrayProperty: PlayerData
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.GameViewportClient.FPerPlayerSplitscreenData> PlayerData
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameViewportClient.FPerPlayerSplitscreenData>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FPerPlayerSplitscreenData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FPerPlayerSplitscreenData
    {
        /// <summary>
        /// FloatProperty: SizeX
        /// </summary>
        public unsafe float SizeX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: SizeY
        /// </summary>
        public unsafe float SizeY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: OriginX
        /// </summary>
        public unsafe float OriginX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: OriginY
        /// </summary>
        public unsafe float OriginY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Enum: ESafeZoneType
    /// </summary>
    public enum ESafeZoneType : byte
    {
        eSZ_TOP = 0,
        eSZ_BOTTOM = 1,
        eSZ_LEFT = 2,
        eSZ_RIGHT = 3,
        eSZ_MAX = 4,
    }

    /// <summary>
    /// Enum: ESplitScreenType
    /// </summary>
    public enum ESplitScreenType : byte
    {
        eSST_NONE = 0,
        eSST_2P_HORIZONTAL = 1,
        eSST_2P_VERTICAL = 2,
        eSST_3P_FAVOR_TOP = 3,
        eSST_3P_FAVOR_BOTTOM = 4,
        eSST_4P = 5,
        eSST_MAX = 6,
    }

    /// <summary>
    /// Struct: FTitleSafeZoneArea
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FTitleSafeZoneArea
    {
        /// <summary>
        /// FloatProperty: MaxPercentX
        /// </summary>
        public unsafe float MaxPercentX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: MaxPercentY
        /// </summary>
        public unsafe float MaxPercentY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: RecommendedPercentX
        /// </summary>
        public unsafe float RecommendedPercentX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: RecommendedPercentY
        /// </summary>
        public unsafe float RecommendedPercentY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// StructProperty: VfTable_FViewportClient
    /// </summary>
    public unsafe System.IntPtr VfTable_FViewportClient
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// StructProperty: VfTable_FExec
    /// </summary>
    public unsafe System.IntPtr VfTable_FExec
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// StructProperty: Viewport
    /// </summary>
    public unsafe System.IntPtr Viewport
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// StructProperty: ViewportFrame
    /// </summary>
    public unsafe System.IntPtr ViewportFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// ArrayProperty: GlobalInteractions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Interaction> GlobalInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Interaction>>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// ClassProperty: UIControllerClass
    /// </summary>
    public unsafe BmSDK.Class UIControllerClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }

    /// <summary>
    /// ObjectProperty: UIController
    /// </summary>
    public unsafe BmSDK.Engine.UIInteraction UIController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIInteraction>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }

    /// <summary>
    /// ObjectProperty: ViewportConsole
    /// </summary>
    public unsafe BmSDK.Engine._Console ViewportConsole
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine._Console>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// StructProperty: ShowFlags
    /// </summary>
    public unsafe ulong ShowFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<ulong>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StructProperty: MtlShowFlags
    /// </summary>
    public unsafe ulong MtlShowFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<ulong>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// StrProperty: LoadingMessage
    /// </summary>
    public unsafe BmSDK.FString LoadingMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StrProperty: SavingMessage
    /// </summary>
    public unsafe BmSDK.FString SavingMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// StrProperty: ConnectingMessage
    /// </summary>
    public unsafe BmSDK.FString ConnectingMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// StrProperty: PausedMessage
    /// </summary>
    public unsafe BmSDK.FString PausedMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// StrProperty: PrecachingMessage
    /// </summary>
    public unsafe BmSDK.FString PrecachingMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: bShowTitleSafeZone
    /// </summary>
    public unsafe bool bShowTitleSafeZone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bDisplayingUIMouseCursor
    /// </summary>
    public unsafe bool bDisplayingUIMouseCursor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bUIMouseCaptureOverride
    /// </summary>
    public unsafe bool bUIMouseCaptureOverride
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bOverrideDiffuseAndEmissive
    /// </summary>
    public unsafe bool bOverrideDiffuseAndEmissive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bOverrideDiffuseAndSpecular
    /// </summary>
    public unsafe bool bOverrideDiffuseAndSpecular
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bIsPlayInEditorViewport
    /// </summary>
    public unsafe bool bIsPlayInEditorViewport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bShowSystemMouseCursor
    /// </summary>
    public unsafe bool bShowSystemMouseCursor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bCollisionLight
    /// </summary>
    public unsafe bool bCollisionLight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bDisableWorldRendering
    /// </summary>
    public unsafe bool bDisableWorldRendering
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bDebugNoGFxUI
    /// </summary>
    public unsafe bool bDebugNoGFxUI
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bUseHardwareCursorWhenWindowed
    /// </summary>
    public unsafe bool bUseHardwareCursorWhenWindowed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// StructProperty: TitleSafeZone
    /// </summary>
    public unsafe ref BmSDK.Engine.GameViewportClient.FTitleSafeZoneArea TitleSafeZone
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.GameViewportClient.FTitleSafeZoneArea>(Ptr + 164);

    /// <summary>
    /// StructProperty: CollisionLightSavedShowFlags
    /// </summary>
    public unsafe ulong CollisionLightSavedShowFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<ulong>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ArrayProperty: SplitscreenInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.GameViewportClient.FSplitscreenData> SplitscreenInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameViewportClient.FSplitscreenData>>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ByteProperty: DesiredSplitscreenType
    /// </summary>
    public unsafe BmSDK.Engine.GameViewportClient.ESplitScreenType DesiredSplitscreenType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameViewportClient.ESplitScreenType>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// ByteProperty: ActiveSplitscreenType
    /// </summary>
    public unsafe BmSDK.Engine.GameViewportClient.ESplitScreenType ActiveSplitscreenType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameViewportClient.ESplitScreenType>(Ptr + 201); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 201); }
    }

    /// <summary>
    /// ByteProperty: Default2PSplitType
    /// </summary>
    public unsafe BmSDK.Engine.GameViewportClient.ESplitScreenType Default2PSplitType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameViewportClient.ESplitScreenType>(Ptr + 202); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 202); }
    }

    /// <summary>
    /// ByteProperty: Default3PSplitType
    /// </summary>
    public unsafe BmSDK.Engine.GameViewportClient.ESplitScreenType Default3PSplitType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameViewportClient.ESplitScreenType>(Ptr + 203); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 203); }
    }

    /// <summary>
    /// InlineArray{StrProperty}: ProgressMessage
    /// </summary>
    public InlineArray<BmSDK.FString> ProgressMessage => new(2, Ptr + 204, 12, this);

    /// <summary>
    /// StrProperty: ProgressMessage
    /// </summary>
    public unsafe BmSDK.FString ProgressMessage_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }
    /// <summary>
    /// StrProperty: ProgressMessage
    /// </summary>
    public unsafe BmSDK.FString ProgressMessage_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// FloatProperty: ProgressTimeOut
    /// </summary>
    public unsafe float ProgressTimeOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// FloatProperty: ProgressFadeTime
    /// </summary>
    public unsafe float ProgressFadeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// ArrayProperty: DebugProperties
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.GameViewportClient.FDebugDisplayProperty> DebugProperties
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameViewportClient.FDebugDisplayProperty>>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// StructProperty: ScaleformInteraction
    /// </summary>
    public unsafe System.IntPtr ScaleformInteraction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// DelegateProperty: __HandleInputKey__Delegate
    /// </summary>
    public unsafe System.IntPtr __HandleInputKey__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// DelegateProperty: __HandleInputAxis__Delegate
    /// </summary>
    public unsafe System.IntPtr __HandleInputAxis__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// DelegateProperty: __HandleInputChar__Delegate
    /// </summary>
    public unsafe System.IntPtr __HandleInputChar__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }
}
