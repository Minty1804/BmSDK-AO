#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: PlayerController<br/>
/// (size = 1452)
/// (flags = 142608534)
/// </summary>
public partial class PlayerController : BmSDK.Engine.Controller, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.PlayerController", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as PlayerController.
    /// </summary>
    public static PlayerController DefaultObject => (PlayerController)StaticClass().DefaultObject;

    internal PlayerController() { }

    /// <summary>
    /// Constructs a new PlayerController
    /// </summary>
    public PlayerController(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected PlayerController(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<PlayerController>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<PlayerController>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<PlayerController>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<PlayerController>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<PlayerController>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<PlayerController>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<PlayerController>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<PlayerController>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ReceivedGameClass;
    /// <summary>
    /// Function: ReceivedGameClass
    /// </summary>
    public unsafe virtual void ReceivedGameClass(BmSDK.Class GameClass)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReceivedGameClass, "Engine.PlayerController.ReceivedGameClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GameClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LogOutBugItAIGoToLogFile;
    /// <summary>
    /// Function: LogOutBugItAIGoToLogFile
    /// </summary>
    public unsafe void LogOutBugItAIGoToLogFile(BmSDK.FString InScreenShotDesc, BmSDK.FString InGoString, BmSDK.FString InLocString)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogOutBugItAIGoToLogFile, "Engine.PlayerController.LogOutBugItAIGoToLogFile");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InScreenShotDesc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InGoString, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InLocString, paramsPtr + 24);
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

    private static BmSDK.Function __fn_LogOutBugItGoToLogFile;
    /// <summary>
    /// Function: LogOutBugItGoToLogFile
    /// </summary>
    public unsafe void LogOutBugItGoToLogFile(BmSDK.FString InScreenShotDesc, BmSDK.FString InGoString, BmSDK.FString InLocString)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogOutBugItGoToLogFile, "Engine.PlayerController.LogOutBugItGoToLogFile");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InScreenShotDesc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InGoString, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InLocString, paramsPtr + 24);
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

    private static BmSDK.Function __fn_DisableDebugAI;
    /// <summary>
    /// Function: DisableDebugAI
    /// </summary>
    public unsafe virtual void DisableDebugAI()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableDebugAI, "Engine.PlayerController.DisableDebugAI");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpPeers;
    /// <summary>
    /// Function: DumpPeers
    /// </summary>
    public unsafe virtual void DumpPeers()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpPeers, "Engine.PlayerController.DumpPeers");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpVoiceMutingState;
    /// <summary>
    /// Function: DumpVoiceMutingState
    /// </summary>
    public unsafe virtual void DumpVoiceMutingState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpVoiceMutingState, "Engine.PlayerController.DumpVoiceMutingState");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpOnlineSessionState;
    /// <summary>
    /// Function: DumpOnlineSessionState
    /// </summary>
    public unsafe virtual void DumpOnlineSessionState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpOnlineSessionState, "Engine.PlayerController.DumpOnlineSessionState");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugLogPRIs;
    /// <summary>
    /// Function: DebugLogPRIs
    /// </summary>
    public unsafe virtual void DebugLogPRIs()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugLogPRIs, "Engine.PlayerController.DebugLogPRIs");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnEngineInitialTick;
    /// <summary>
    /// Function: OnEngineInitialTick
    /// </summary>
    public unsafe virtual void OnEngineInitialTick()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnEngineInitialTick, "Engine.PlayerController.OnEngineInitialTick");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BugItStringCreator;
    /// <summary>
    /// Function: BugItStringCreator
    /// </summary>
    public unsafe virtual void BugItStringCreator(in System.Numerics.Vector3 ViewLocation, in BmSDK.Rotator ViewRotation, out BmSDK.FString GoString, out BmSDK.FString LocString)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BugItStringCreator, "Engine.PlayerController.BugItStringCreator");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewRotation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        GoString = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 24);
        LocString = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 36);
        return;
    }

    private static BmSDK.Function __fn_BugItAI;
    /// <summary>
    /// Function: BugItAI
    /// </summary>
    public unsafe virtual void BugItAI(BmSDK.FString ScreenShotDescription = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BugItAI, "Engine.PlayerController.BugItAI");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScreenShotDescription, paramsPtr + 0);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_LogLoc;
    /// <summary>
    /// Function: LogLoc
    /// </summary>
    public unsafe virtual void LogLoc()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogLoc, "Engine.PlayerController.LogLoc");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DirectAutoBugIt;
    /// <summary>
    /// Function: DirectAutoBugIt
    /// </summary>
    public unsafe virtual void DirectAutoBugIt(BmSDK.FString ScreenShotDescription = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DirectAutoBugIt, "Engine.PlayerController.DirectAutoBugIt");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScreenShotDescription, paramsPtr + 0);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_AutoBugIt;
    /// <summary>
    /// Function: AutoBugIt
    /// </summary>
    public unsafe virtual void AutoBugIt(BmSDK.FString ScreenShotDescription = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AutoBugIt, "Engine.PlayerController.AutoBugIt");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScreenShotDescription, paramsPtr + 0);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_BugIt;
    /// <summary>
    /// Function: BugIt
    /// </summary>
    public unsafe virtual void BugIt(BmSDK.FString ScreenShotDescription = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BugIt, "Engine.PlayerController.BugIt");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScreenShotDescription, paramsPtr + 0);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_BugItWorker;
    /// <summary>
    /// Function: BugItWorker
    /// </summary>
    public unsafe virtual void BugItWorker(System.Numerics.Vector3 TheLocation, BmSDK.Rotator TheRotation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BugItWorker, "Engine.PlayerController.BugItWorker");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheRotation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BugItGo;
    /// <summary>
    /// Function: BugItGo
    /// </summary>
    public unsafe virtual void BugItGo(float X, float Y, float Z, int Pitch, int Yaw, int Roll)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BugItGo, "Engine.PlayerController.BugItGo");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Z, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pitch, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Yaw, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Roll, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasPeerConnection;
    /// <summary>
    /// Function: HasPeerConnection
    /// </summary>
    public unsafe virtual bool HasPeerConnection(in BmSDK.Engine.OnlineSubsystem.FUniqueNetId PeerNetId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasPeerConnection, "Engine.PlayerController.HasPeerConnection");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PeerNetId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_ClientSpawnCameraLensEffect;
    /// <summary>
    /// Function: ClientSpawnCameraLensEffect
    /// </summary>
    public unsafe virtual void ClientSpawnCameraLensEffect(BmSDK.Class LensEffectEmitterClass)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientSpawnCameraLensEffect, "Engine.PlayerController.ClientSpawnCameraLensEffect");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LensEffectEmitterClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugCameraAnims;
    /// <summary>
    /// Function: DebugCameraAnims
    /// </summary>
    public unsafe virtual void DebugCameraAnims()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugCameraAnims, "Engine.PlayerController.DebugCameraAnims");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientStopCameraAnim;
    /// <summary>
    /// Function: ClientStopCameraAnim
    /// </summary>
    public unsafe virtual void ClientStopCameraAnim(BmSDK.Engine.CameraAnim AnimToStop)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientStopCameraAnim, "Engine.PlayerController.ClientStopCameraAnim");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimToStop, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientPlayCameraAnim;
    /// <summary>
    /// Function: ClientPlayCameraAnim
    /// </summary>
    public unsafe virtual void ClientPlayCameraAnim(BmSDK.Engine.CameraAnim AnimToPlay, float Scale = default, float Rate = default, float BlendInTime = default, float BlendOutTime = default, bool bLoop = default, bool bRandomStartTime = default, BmSDK.Engine.Camera.ECameraAnimPlaySpace Space = default, BmSDK.Rotator CustomPlaySpace = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientPlayCameraAnim, "Engine.PlayerController.ClientPlayCameraAnim");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimToPlay, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scale, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rate, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendInTime, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendOutTime, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLoop, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRandomStartTime, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Space, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomPlaySpace, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnCameraShake;
    /// <summary>
    /// Function: OnCameraShake
    /// </summary>
    public unsafe virtual void OnCameraShake(BmSDK.Engine.SeqAct_CameraShake inAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCameraShake, "Engine.PlayerController.OnCameraShake");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientStopCameraShake;
    /// <summary>
    /// Function: ClientStopCameraShake
    /// </summary>
    public unsafe virtual void ClientStopCameraShake(BmSDK.Engine.CameraShake Shake)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientStopCameraShake, "Engine.PlayerController.ClientStopCameraShake");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Shake, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientPlayCameraShake;
    /// <summary>
    /// Function: ClientPlayCameraShake
    /// </summary>
    public unsafe virtual void ClientPlayCameraShake(BmSDK.Engine.CameraShake Shake, float Scale = default, bool bTryForceFeedback = default, BmSDK.Engine.Camera.ECameraAnimPlaySpace PlaySpace = default, BmSDK.Rotator UserPlaySpaceRot = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientPlayCameraShake, "Engine.PlayerController.ClientPlayCameraShake");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Shake, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scale, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTryForceFeedback, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlaySpace, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserPlaySpaceRot, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoForceFeedbackForScreenShake;
    /// <summary>
    /// Function: DoForceFeedbackForScreenShake
    /// </summary>
    public unsafe virtual void DoForceFeedbackForScreenShake(BmSDK.Engine.CameraShake ShakeData, float ShakeScale)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoForceFeedbackForScreenShake, "Engine.PlayerController.DoForceFeedbackForScreenShake");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShakeData, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShakeScale, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InputMatchDelegate;
    /// <summary>
    /// Function: InputMatchDelegate
    /// </summary>
    public unsafe virtual void InputMatchDelegate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InputMatchDelegate, "Engine.PlayerController.InputMatchDelegate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientPrestreamTextures;
    /// <summary>
    /// Function: ClientPrestreamTextures
    /// </summary>
    public unsafe virtual void ClientPrestreamTextures(BmSDK.Engine.Actor ForcedActor, float ForceDuration, bool bEnableStreaming, int CinematicTextureGroups = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientPrestreamTextures, "Engine.PlayerController.ClientPrestreamTextures");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForcedActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceDuration, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableStreaming, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CinematicTextureGroups, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientSetForceMipLevelsToBeResident;
    /// <summary>
    /// Function: ClientSetForceMipLevelsToBeResident
    /// </summary>
    public unsafe virtual void ClientSetForceMipLevelsToBeResident(BmSDK.Engine.MaterialInterface Material, float ForceDuration, int CinematicTextureGroups = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientSetForceMipLevelsToBeResident, "Engine.PlayerController.ClientSetForceMipLevelsToBeResident");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Material, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceDuration, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CinematicTextureGroups, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientControlMovieTexture;
    /// <summary>
    /// Function: ClientControlMovieTexture
    /// </summary>
    public unsafe virtual void ClientControlMovieTexture(BmSDK.Engine.TextureMovie MovieTexture, BmSDK.Engine.SeqAct_ControlMovieTexture.EMovieControlType Mode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientControlMovieTexture, "Engine.PlayerController.ClientControlMovieTexture");
        byte* paramsPtr = stackalloc byte[21];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovieTexture, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mode, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSplitscreenPlayerByIndex;
    /// <summary>
    /// Function: GetSplitscreenPlayerByIndex
    /// </summary>
    public unsafe virtual BmSDK.Engine.PlayerReplicationInfo GetSplitscreenPlayerByIndex(int PlayerIndex = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSplitscreenPlayerByIndex, "Engine.PlayerController.GetSplitscreenPlayerByIndex");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PlayerReplicationInfo>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsSplitscreenPlayer;
    /// <summary>
    /// Function: IsSplitscreenPlayer
    /// </summary>
    public unsafe virtual bool IsSplitscreenPlayer(out int out_SplitscreenPlayerIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSplitscreenPlayer, "Engine.PlayerController.IsSplitscreenPlayer");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_SplitscreenPlayerIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_SplitscreenPlayerIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_SplitscreenPlayerIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsPrimaryPlayer;
    /// <summary>
    /// Function: IsPrimaryPlayer
    /// </summary>
    public unsafe virtual bool IsPrimaryPlayer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPrimaryPlayer, "Engine.PlayerController.IsPrimaryPlayer");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PathClear;
    /// <summary>
    /// Function: PathClear
    /// </summary>
    public unsafe virtual void PathClear()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PathClear, "Engine.PlayerController.PathClear");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PathChild;
    /// <summary>
    /// Function: PathChild
    /// </summary>
    public unsafe virtual void PathChild(int Cnt = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PathChild, "Engine.PlayerController.PathChild");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Cnt, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PathStep;
    /// <summary>
    /// Function: PathStep
    /// </summary>
    public unsafe virtual void PathStep(int Cnt = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PathStep, "Engine.PlayerController.PathStep");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Cnt, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPlayerHasBeenMoved;
    /// <summary>
    /// Function: OnPlayerHasBeenMoved
    /// </summary>
    public unsafe virtual void OnPlayerHasBeenMoved()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPlayerHasBeenMoved, "Engine.PlayerController.OnPlayerHasBeenMoved");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SoakPause;
    /// <summary>
    /// Function: SoakPause
    /// </summary>
    public unsafe virtual void SoakPause(BmSDK.Engine.Pawn P)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SoakPause, "Engine.PlayerController.SoakPause");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IncrementNumberOfMatchesPlayed;
    /// <summary>
    /// Function: IncrementNumberOfMatchesPlayed
    /// </summary>
    public unsafe virtual void IncrementNumberOfMatchesPlayed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncrementNumberOfMatchesPlayed, "Engine.PlayerController.IncrementNumberOfMatchesPlayed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientEndOnlineGame;
    /// <summary>
    /// Function: ClientEndOnlineGame
    /// </summary>
    public unsafe virtual void ClientEndOnlineGame()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientEndOnlineGame, "Engine.PlayerController.ClientEndOnlineGame");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientStartOnlineGame;
    /// <summary>
    /// Function: ClientStartOnlineGame
    /// </summary>
    public unsafe virtual void ClientStartOnlineGame()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientStartOnlineGame, "Engine.PlayerController.ClientStartOnlineGame");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerRegisterClientStatGuid;
    /// <summary>
    /// Function: ServerRegisterClientStatGuid
    /// </summary>
    public unsafe virtual void ServerRegisterClientStatGuid(BmSDK.FString StatGuid)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerRegisterClientStatGuid, "Engine.PlayerController.ServerRegisterClientStatGuid");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatGuid, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnRegisterHostStatGuidComplete;
    /// <summary>
    /// Function: OnRegisterHostStatGuidComplete
    /// </summary>
    public unsafe virtual void OnRegisterHostStatGuidComplete(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRegisterHostStatGuidComplete, "Engine.PlayerController.OnRegisterHostStatGuidComplete");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientRegisterHostStatGuid;
    /// <summary>
    /// Function: ClientRegisterHostStatGuid
    /// </summary>
    public unsafe virtual void ClientRegisterHostStatGuid(BmSDK.FString StatGuid)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientRegisterHostStatGuid, "Engine.PlayerController.ClientRegisterHostStatGuid");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatGuid, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveAllDebugStrings;
    /// <summary>
    /// Function: RemoveAllDebugStrings
    /// </summary>
    public unsafe virtual void RemoveAllDebugStrings()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveAllDebugStrings, "Engine.PlayerController.RemoveAllDebugStrings");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveDebugText;
    /// <summary>
    /// Function: RemoveDebugText
    /// </summary>
    public unsafe virtual void RemoveDebugText(BmSDK.Engine.Actor SrcActor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveDebugText, "Engine.PlayerController.RemoveDebugText");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SrcActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddDebugText;
    /// <summary>
    /// Function: AddDebugText
    /// </summary>
    public unsafe virtual void AddDebugText(BmSDK.FString DebugText, BmSDK.Engine.Actor SrcActor = default, float Duration = default, System.Numerics.Vector3 Offset = default, System.Numerics.Vector3 DesiredOffset = default, BmSDK.GameObject.FColor TextColor = default, bool bSkipOverwriteCheck = default, bool bAbsoluteLocation = default, bool bKeepAttachedToActor = default, BmSDK.Engine.Font InFont = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDebugText, "Engine.PlayerController.AddDebugText");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DebugText, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SrcActor, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Offset, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredOffset, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TextColor, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSkipOverwriteCheck, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAbsoluteLocation, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKeepAttachedToActor, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InFont, paramsPtr + 60);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawDebugTextList;
    /// <summary>
    /// Function: DrawDebugTextList
    /// </summary>
    public unsafe virtual void DrawDebugTextList(BmSDK.Engine.Canvas Canvas, float RenderDelta)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugTextList, "Engine.PlayerController.DrawDebugTextList");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RenderDelta, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendToConsole;
    /// <summary>
    /// Function: SendToConsole
    /// </summary>
    public unsafe virtual void SendToConsole(BmSDK.FString Command)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendToConsole, "Engine.PlayerController.SendToConsole");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Command, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ConsoleKey;
    /// <summary>
    /// Function: ConsoleKey
    /// </summary>
    public unsafe virtual void ConsoleKey(BmSDK.FName Key)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConsoleKey, "Engine.PlayerController.ConsoleKey");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnDestroy;
    /// <summary>
    /// Function: OnDestroy
    /// </summary>
    public unsafe override void OnDestroy(BmSDK.Engine.SeqAct_Destroy Action)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDestroy, "Engine.PlayerController.OnDestroy");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientStartNetworkedVoice;
    /// <summary>
    /// Function: ClientStartNetworkedVoice
    /// </summary>
    public unsafe virtual void ClientStartNetworkedVoice()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientStartNetworkedVoice, "Engine.PlayerController.ClientStartNetworkedVoice");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientStopNetworkedVoice;
    /// <summary>
    /// Function: ClientStopNetworkedVoice
    /// </summary>
    public unsafe virtual void ClientStopNetworkedVoice()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientStopNetworkedVoice, "Engine.PlayerController.ClientStopNetworkedVoice");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientSetHostUniqueId;
    /// <summary>
    /// Function: ClientSetHostUniqueId
    /// </summary>
    public unsafe virtual void ClientSetHostUniqueId(BmSDK.Engine.OnlineSubsystem.FUniqueNetId InHostId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientSetHostUniqueId, "Engine.PlayerController.ClientSetHostUniqueId");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InHostId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientWriteLeaderboardStats;
    /// <summary>
    /// Function: ClientWriteLeaderboardStats
    /// </summary>
    public unsafe virtual void ClientWriteLeaderboardStats(BmSDK.Class OnlineStatsWriteClass)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientWriteLeaderboardStats, "Engine.PlayerController.ClientWriteLeaderboardStats");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnlineStatsWriteClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientWriteOnlinePlayerScores;
    /// <summary>
    /// Function: ClientWriteOnlinePlayerScores
    /// </summary>
    public unsafe virtual void ClientWriteOnlinePlayerScores(int LeaderboardId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientWriteOnlinePlayerScores, "Engine.PlayerController.ClientWriteOnlinePlayerScores");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeaderboardId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientArbitratedMatchEnded;
    /// <summary>
    /// Function: ClientArbitratedMatchEnded
    /// </summary>
    public unsafe virtual void ClientArbitratedMatchEnded()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientArbitratedMatchEnded, "Engine.PlayerController.ClientArbitratedMatchEnded");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyNotEnoughSpaceInInvite;
    /// <summary>
    /// Function: NotifyNotEnoughSpaceInInvite
    /// </summary>
    public unsafe virtual void NotifyNotEnoughSpaceInInvite()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyNotEnoughSpaceInInvite, "Engine.PlayerController.NotifyNotEnoughSpaceInInvite");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyNotAllPlayersCanJoinInvite;
    /// <summary>
    /// Function: NotifyNotAllPlayersCanJoinInvite
    /// </summary>
    public unsafe virtual void NotifyNotAllPlayersCanJoinInvite()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyNotAllPlayersCanJoinInvite, "Engine.PlayerController.NotifyNotAllPlayersCanJoinInvite");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyInviteFailed;
    /// <summary>
    /// Function: NotifyInviteFailed
    /// </summary>
    public unsafe virtual void NotifyInviteFailed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyInviteFailed, "Engine.PlayerController.NotifyInviteFailed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnInviteJoinComplete;
    /// <summary>
    /// Function: OnInviteJoinComplete
    /// </summary>
    public unsafe virtual void OnInviteJoinComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnInviteJoinComplete, "Engine.PlayerController.OnInviteJoinComplete");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ModifyClientURL;
    /// <summary>
    /// Function: ModifyClientURL
    /// </summary>
    public unsafe virtual BmSDK.FString ModifyClientURL(BmSDK.FString URL)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyClientURL, "Engine.PlayerController.ModifyClientURL");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(URL, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_OnDestroyForInviteComplete;
    /// <summary>
    /// Function: OnDestroyForInviteComplete
    /// </summary>
    public unsafe virtual void OnDestroyForInviteComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDestroyForInviteComplete, "Engine.PlayerController.OnDestroyForInviteComplete");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnEndForInviteComplete;
    /// <summary>
    /// Function: OnEndForInviteComplete
    /// </summary>
    public unsafe virtual void OnEndForInviteComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnEndForInviteComplete, "Engine.PlayerController.OnEndForInviteComplete");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearInviteDelegates;
    /// <summary>
    /// Function: ClearInviteDelegates
    /// </summary>
    public unsafe virtual void ClearInviteDelegates()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearInviteDelegates, "Engine.PlayerController.ClearInviteDelegates");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanAllPlayersPlayOnline;
    /// <summary>
    /// Function: CanAllPlayersPlayOnline
    /// </summary>
    public unsafe virtual bool CanAllPlayersPlayOnline()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanAllPlayersPlayOnline, "Engine.PlayerController.CanAllPlayersPlayOnline");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InviteHasEnoughSpace;
    /// <summary>
    /// Function: InviteHasEnoughSpace
    /// </summary>
    public unsafe virtual bool InviteHasEnoughSpace(BmSDK.Engine.OnlineGameSettings InviteSettings)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InviteHasEnoughSpace, "Engine.PlayerController.InviteHasEnoughSpace");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InviteSettings, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OnGameInviteAccepted;
    /// <summary>
    /// Function: OnGameInviteAccepted
    /// </summary>
    public unsafe virtual void OnGameInviteAccepted(in BmSDK.Engine.OnlineGameSearch.FOnlineGameSearchResult InviteResult)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnGameInviteAccepted, "Engine.PlayerController.OnGameInviteAccepted");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InviteResult, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerRegisteredForArbitration;
    /// <summary>
    /// Function: ServerRegisteredForArbitration
    /// </summary>
    public unsafe virtual void ServerRegisteredForArbitration(bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerRegisteredForArbitration, "Engine.PlayerController.ServerRegisteredForArbitration");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnArbitrationRegisterComplete;
    /// <summary>
    /// Function: OnArbitrationRegisterComplete
    /// </summary>
    public unsafe virtual void OnArbitrationRegisterComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnArbitrationRegisterComplete, "Engine.PlayerController.OnArbitrationRegisterComplete");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientRegisterForArbitration;
    /// <summary>
    /// Function: ClientRegisterForArbitration
    /// </summary>
    public unsafe virtual void ClientRegisterForArbitration()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientRegisterForArbitration, "Engine.PlayerController.ClientRegisterForArbitration");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientWasKicked;
    /// <summary>
    /// Function: ClientWasKicked
    /// </summary>
    public unsafe virtual void ClientWasKicked()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientWasKicked, "Engine.PlayerController.ClientWasKicked");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsShowingSubtitles;
    /// <summary>
    /// Function: IsShowingSubtitles
    /// </summary>
    public unsafe virtual bool IsShowingSubtitles()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsShowingSubtitles, "Engine.PlayerController.IsShowingSubtitles");
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

    private static BmSDK.Function __fn_SetShowSubtitles;
    /// <summary>
    /// Function: SetShowSubtitles
    /// </summary>
    public unsafe virtual void SetShowSubtitles(bool bValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetShowSubtitles, "Engine.PlayerController.SetShowSubtitles");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bValue, paramsPtr + 0);
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

    private static BmSDK.Function __fn_NotifyDirectorControl;
    /// <summary>
    /// Function: NotifyDirectorControl
    /// </summary>
    public unsafe virtual void NotifyDirectorControl(bool bNowControlling)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyDirectorControl, "Engine.PlayerController.NotifyDirectorControl");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNowControlling, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientVoiceHandshakeComplete;
    /// <summary>
    /// Function: ClientVoiceHandshakeComplete
    /// </summary>
    public unsafe virtual void ClientVoiceHandshakeComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientVoiceHandshakeComplete, "Engine.PlayerController.ClientVoiceHandshakeComplete");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPlayerControllerFromNetId;
    /// <summary>
    /// Function: GetPlayerControllerFromNetId
    /// </summary>
    public unsafe static BmSDK.Engine.PlayerController GetPlayerControllerFromNetId(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerNetId)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerControllerFromNetId, "Engine.PlayerController.GetPlayerControllerFromNetId");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNetId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PlayerController>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_ClientSetOnlineStatus;
    /// <summary>
    /// Function: ClientSetOnlineStatus
    /// </summary>
    public unsafe virtual void ClientSetOnlineStatus()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientSetOnlineStatus, "Engine.PlayerController.ClientSetOnlineStatus");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SeamlessTravelFrom;
    /// <summary>
    /// Function: SeamlessTravelFrom
    /// </summary>
    public unsafe virtual void SeamlessTravelFrom(BmSDK.Engine.PlayerController OldPC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SeamlessTravelFrom, "Engine.PlayerController.SeamlessTravelFrom");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SeamlessTravelTo;
    /// <summary>
    /// Function: SeamlessTravelTo
    /// </summary>
    public unsafe virtual void SeamlessTravelTo(BmSDK.Engine.PlayerController NewPC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SeamlessTravelTo, "Engine.PlayerController.SeamlessTravelTo");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSeamlessTravelActorList;
    /// <summary>
    /// Function: GetSeamlessTravelActorList
    /// </summary>
    public unsafe virtual void GetSeamlessTravelActorList(bool bToEntry, out BmSDK.TArray<BmSDK.Engine.Actor> ActorList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSeamlessTravelActorList, "Engine.PlayerController.GetSeamlessTravelActorList");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bToEntry, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ActorList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor>>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_IsPlayerMuted;
    /// <summary>
    /// Function: IsPlayerMuted
    /// </summary>
    public unsafe virtual bool IsPlayerMuted(in BmSDK.Engine.OnlineSubsystem.FUniqueNetId Sender)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPlayerMuted, "Engine.PlayerController.IsPlayerMuted");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Sender, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_GetUIController;
    /// <summary>
    /// Function: GetUIController
    /// </summary>
    public unsafe virtual BmSDK.Engine.UIInteraction GetUIController()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUIController, "Engine.PlayerController.GetUIController");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.UIInteraction>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SaveActorConfig;
    /// <summary>
    /// Function: SaveActorConfig
    /// </summary>
    public unsafe virtual void SaveActorConfig(BmSDK.FName actorName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SaveActorConfig, "Engine.PlayerController.SaveActorConfig");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(actorName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SaveClassConfig;
    /// <summary>
    /// Function: SaveClassConfig
    /// </summary>
    public unsafe virtual void SaveClassConfig(BmSDK.FString ClassName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SaveClassConfig, "Engine.PlayerController.SaveClassConfig");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClassName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientSetBlockOnAsyncLoading;
    /// <summary>
    /// Function: ClientSetBlockOnAsyncLoading
    /// </summary>
    public unsafe virtual void ClientSetBlockOnAsyncLoading()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientSetBlockOnAsyncLoading, "Engine.PlayerController.ClientSetBlockOnAsyncLoading");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientFlushLevelStreaming;
    /// <summary>
    /// Function: ClientFlushLevelStreaming
    /// </summary>
    public unsafe virtual void ClientFlushLevelStreaming()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientFlushLevelStreaming, "Engine.PlayerController.ClientFlushLevelStreaming");
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

    private static BmSDK.Function __fn_ClientCancelPendingMapChange;
    /// <summary>
    /// Function: ClientCancelPendingMapChange
    /// </summary>
    public unsafe virtual void ClientCancelPendingMapChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientCancelPendingMapChange, "Engine.PlayerController.ClientCancelPendingMapChange");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientCommitMapChange;
    /// <summary>
    /// Function: ClientCommitMapChange
    /// </summary>
    public unsafe virtual void ClientCommitMapChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientCommitMapChange, "Engine.PlayerController.ClientCommitMapChange");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DelayedPrepareMapChange;
    /// <summary>
    /// Function: DelayedPrepareMapChange
    /// </summary>
    public unsafe virtual void DelayedPrepareMapChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DelayedPrepareMapChange, "Engine.PlayerController.DelayedPrepareMapChange");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientPrepareMapChange;
    /// <summary>
    /// Function: ClientPrepareMapChange
    /// </summary>
    public unsafe virtual void ClientPrepareMapChange(BmSDK.FName LevelName, bool bFirst, bool bLast)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientPrepareMapChange, "Engine.PlayerController.ClientPrepareMapChange");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LevelName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFirst, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLast, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerUpdateLevelVisibility;
    /// <summary>
    /// Function: ServerUpdateLevelVisibility
    /// </summary>
    public unsafe virtual void ServerUpdateLevelVisibility(BmSDK.FName PackageName, bool bIsVisible)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerUpdateLevelVisibility, "Engine.PlayerController.ServerUpdateLevelVisibility");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsVisible, paramsPtr + 8);
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

    private static BmSDK.Function __fn_ClientUpdateLevelStreamingStatus;
    /// <summary>
    /// Function: ClientUpdateLevelStreamingStatus
    /// </summary>
    public unsafe virtual void ClientUpdateLevelStreamingStatus(BmSDK.FName PackageName, bool bNewShouldBeLoaded, bool bNewShouldBeVisible, bool bNewShouldBlockOnLoad)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientUpdateLevelStreamingStatus, "Engine.PlayerController.ClientUpdateLevelStreamingStatus");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewShouldBeLoaded, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewShouldBeVisible, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewShouldBlockOnLoad, paramsPtr + 16);
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

    private static BmSDK.Function __fn_LevelStreamingStatusChanged;
    /// <summary>
    /// Function: LevelStreamingStatusChanged
    /// </summary>
    public unsafe virtual void LevelStreamingStatusChanged(BmSDK.Engine.LevelStreaming LevelObject, bool bNewShouldBeLoaded, bool bNewShouldBeVisible, bool bNewShouldBlockOnLoad)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LevelStreamingStatusChanged, "Engine.PlayerController.LevelStreamingStatusChanged");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LevelObject, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewShouldBeLoaded, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewShouldBeVisible, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewShouldBlockOnLoad, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientForceGarbageCollection;
    /// <summary>
    /// Function: ClientForceGarbageCollection
    /// </summary>
    public unsafe virtual void ClientForceGarbageCollection()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientForceGarbageCollection, "Engine.PlayerController.ClientForceGarbageCollection");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnConsoleCommand;
    /// <summary>
    /// Function: OnConsoleCommand
    /// </summary>
    public unsafe virtual void OnConsoleCommand(BmSDK.Engine.SeqAct_ConsoleCommand inAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnConsoleCommand, "Engine.PlayerController.OnConsoleCommand");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetPlayerMovementInput;
    /// <summary>
    /// Function: ResetPlayerMovementInput
    /// </summary>
    public unsafe virtual void ResetPlayerMovementInput()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetPlayerMovementInput, "Engine.PlayerController.ResetPlayerMovementInput");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsLookInputIgnored;
    /// <summary>
    /// Function: IsLookInputIgnored
    /// </summary>
    public unsafe virtual bool IsLookInputIgnored()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLookInputIgnored, "Engine.PlayerController.IsLookInputIgnored");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IgnoreLookInput;
    /// <summary>
    /// Function: IgnoreLookInput
    /// </summary>
    public unsafe virtual void IgnoreLookInput(bool bNewLookInput)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IgnoreLookInput, "Engine.PlayerController.IgnoreLookInput");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewLookInput, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsMoveInputIgnored;
    /// <summary>
    /// Function: IsMoveInputIgnored
    /// </summary>
    public unsafe virtual bool IsMoveInputIgnored()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsMoveInputIgnored, "Engine.PlayerController.IsMoveInputIgnored");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IgnoreMoveInput;
    /// <summary>
    /// Function: IgnoreMoveInput
    /// </summary>
    public unsafe virtual void IgnoreMoveInput(bool bNewMoveInput)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IgnoreMoveInput, "Engine.PlayerController.IgnoreMoveInput");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewMoveInput, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientSetCinematicMode;
    /// <summary>
    /// Function: ClientSetCinematicMode
    /// </summary>
    public unsafe virtual void ClientSetCinematicMode(bool bInCinematicMode, bool bAffectsMovement, bool bAffectsTurning, bool bAffectsHUD)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientSetCinematicMode, "Engine.PlayerController.ClientSetCinematicMode");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInCinematicMode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAffectsMovement, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAffectsTurning, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAffectsHUD, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCinematicMode;
    /// <summary>
    /// Function: SetCinematicMode
    /// </summary>
    public unsafe virtual void SetCinematicMode(bool bInCinematicMode, bool bHidePlayer, bool bAffectsHUD, bool bAffectsMovement, bool bAffectsTurning, bool bAffectsButtons, bool bCheckMovieFinishedForPause)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCinematicMode, "Engine.PlayerController.SetCinematicMode");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInCinematicMode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHidePlayer, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAffectsHUD, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAffectsMovement, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAffectsTurning, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAffectsButtons, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheckMovieFinishedForPause, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnToggleCinematicMode;
    /// <summary>
    /// Function: OnToggleCinematicMode
    /// </summary>
    public unsafe virtual void OnToggleCinematicMode(BmSDK.Engine.SeqAct_ToggleCinematicMode Action)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnToggleCinematicMode, "Engine.PlayerController.OnToggleCinematicMode");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsForceFeedbackAllowed;
    /// <summary>
    /// Function: IsForceFeedbackAllowed
    /// </summary>
    public unsafe virtual bool IsForceFeedbackAllowed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsForceFeedbackAllowed, "Engine.PlayerController.IsForceFeedbackAllowed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClientStopForceFeedbackWaveform;
    /// <summary>
    /// Function: ClientStopForceFeedbackWaveform
    /// </summary>
    public unsafe virtual void ClientStopForceFeedbackWaveform(BmSDK.Engine.ForceFeedbackWaveform FFWaveform = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientStopForceFeedbackWaveform, "Engine.PlayerController.ClientStopForceFeedbackWaveform");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FFWaveform, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientPlayForceFeedbackWaveform;
    /// <summary>
    /// Function: ClientPlayForceFeedbackWaveform
    /// </summary>
    public unsafe virtual void ClientPlayForceFeedbackWaveform(BmSDK.Engine.ForceFeedbackWaveform FFWaveform, BmSDK.Engine.Actor FFWaveformInstigator = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientPlayForceFeedbackWaveform, "Engine.PlayerController.ClientPlayForceFeedbackWaveform");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FFWaveform, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FFWaveformInstigator, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayRumble;
    /// <summary>
    /// Function: PlayRumble
    /// </summary>
    public unsafe virtual void PlayRumble(BmSDK.Engine.AnimNotify_Rumble TheAnimNotify)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayRumble, "Engine.PlayerController.PlayRumble");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheAnimNotify, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnForceFeedback;
    /// <summary>
    /// Function: OnForceFeedback
    /// </summary>
    public unsafe virtual void OnForceFeedback(BmSDK.Engine.SeqAct_ForceFeedback Action)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnForceFeedback, "Engine.PlayerController.OnForceFeedback");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyTakeHit;
    /// <summary>
    /// Function: NotifyTakeHit
    /// </summary>
    public unsafe override void NotifyTakeHit(BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, int Damage, BmSDK.Class DamageType, System.Numerics.Vector3 Momentum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyTakeHit, "Engine.PlayerController.NotifyTakeHit");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowGameState;
    /// <summary>
    /// Function: ShowGameState
    /// </summary>
    public unsafe virtual void ShowGameState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowGameState, "Engine.PlayerController.ShowGameState");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowPlayerState;
    /// <summary>
    /// Function: ShowPlayerState
    /// </summary>
    public unsafe virtual void ShowPlayerState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowPlayerState, "Engine.PlayerController.ShowPlayerState");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerRemoteEvent;
    /// <summary>
    /// Function: ServerRemoteEvent
    /// </summary>
    public unsafe virtual void ServerRemoteEvent(BmSDK.FName EventName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerRemoteEvent, "Engine.PlayerController.ServerRemoteEvent");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RE;
    /// <summary>
    /// Function: RE
    /// </summary>
    public unsafe virtual void RE(BmSDK.FName EventName = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RE, "Engine.PlayerController.RE");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoteEvent;
    /// <summary>
    /// Function: RemoteEvent
    /// </summary>
    public unsafe virtual void RemoteEvent(BmSDK.FName EventName = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoteEvent, "Engine.PlayerController.RemoteEvent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ListCE;
    /// <summary>
    /// Function: ListCE
    /// </summary>
    public unsafe virtual void ListCE()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListCE, "Engine.PlayerController.ListCE");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ListConsoleEvents;
    /// <summary>
    /// Function: ListConsoleEvents
    /// </summary>
    public unsafe virtual void ListConsoleEvents()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListConsoleEvents, "Engine.PlayerController.ListConsoleEvents");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerCauseEvent;
    /// <summary>
    /// Function: ServerCauseEvent
    /// </summary>
    public unsafe virtual void ServerCauseEvent(BmSDK.FName EventName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerCauseEvent, "Engine.PlayerController.ServerCauseEvent");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnToggleHUD;
    /// <summary>
    /// Function: OnToggleHUD
    /// </summary>
    public unsafe virtual void OnToggleHUD(BmSDK.Engine.SeqAct_ToggleHUD inAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnToggleHUD, "Engine.PlayerController.OnToggleHUD");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnSetCameraTarget;
    /// <summary>
    /// Function: OnSetCameraTarget
    /// </summary>
    public unsafe virtual void OnSetCameraTarget(BmSDK.Engine.SeqAct_SetCameraTarget inAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSetCameraTarget, "Engine.PlayerController.OnSetCameraTarget");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientClearKismetText;
    /// <summary>
    /// Function: ClientClearKismetText
    /// </summary>
    public unsafe virtual void ClientClearKismetText(System.Numerics.Vector2 MessageOffset)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientClearKismetText, "Engine.PlayerController.ClientClearKismetText");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MessageOffset, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientDrawKismetText;
    /// <summary>
    /// Function: ClientDrawKismetText
    /// </summary>
    public unsafe virtual void ClientDrawKismetText(BmSDK.Engine.HUD.FKismetDrawTextInfo DrawTextInfo, float DisplayTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientDrawKismetText, "Engine.PlayerController.ClientDrawKismetText");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DrawTextInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DisplayTime, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnDrawText;
    /// <summary>
    /// Function: OnDrawText
    /// </summary>
    public unsafe virtual void OnDrawText(BmSDK.Engine.SeqAct_DrawText inAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDrawText, "Engine.PlayerController.OnDrawText");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisplayDebug;
    /// <summary>
    /// Function: DisplayDebug
    /// </summary>
    public unsafe override void DisplayDebug(BmSDK.Engine.HUD HUD, out float out_YL, out float out_YPos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayDebug, "Engine.PlayerController.DisplayDebug");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HUD, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_YL);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_YL, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_YPos);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_YPos, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_YL = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        out_YPos = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_ClientIgnoreLookInput;
    /// <summary>
    /// Function: ClientIgnoreLookInput
    /// </summary>
    public unsafe virtual void ClientIgnoreLookInput(bool bIgnore)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientIgnoreLookInput, "Engine.PlayerController.ClientIgnoreLookInput");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnore, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientIgnoreMoveInput;
    /// <summary>
    /// Function: ClientIgnoreMoveInput
    /// </summary>
    public unsafe virtual void ClientIgnoreMoveInput(bool bIgnore)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientIgnoreMoveInput, "Engine.PlayerController.ClientIgnoreMoveInput");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnore, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnToggleInput;
    /// <summary>
    /// Function: OnToggleInput
    /// </summary>
    public unsafe virtual void OnToggleInput(BmSDK.Engine.SeqAct_ToggleInput inAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnToggleInput, "Engine.PlayerController.OnToggleInput");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawHUD;
    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe virtual void DrawHUD(BmSDK.Engine.HUD H)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawHUD, "Engine.PlayerController.DrawHUD");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanRestartPlayer;
    /// <summary>
    /// Function: CanRestartPlayer
    /// </summary>
    public unsafe virtual bool CanRestartPlayer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanRestartPlayer, "Engine.PlayerController.CanRestartPlayer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ViewAPlayer;
    /// <summary>
    /// Function: ViewAPlayer
    /// </summary>
    public unsafe virtual void ViewAPlayer(int Dir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ViewAPlayer, "Engine.PlayerController.ViewAPlayer");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dir, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerViewPrevPlayer;
    /// <summary>
    /// Function: ServerViewPrevPlayer
    /// </summary>
    public unsafe virtual void ServerViewPrevPlayer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerViewPrevPlayer, "Engine.PlayerController.ServerViewPrevPlayer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerViewNextPlayer;
    /// <summary>
    /// Function: ServerViewNextPlayer
    /// </summary>
    public unsafe virtual void ServerViewNextPlayer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerViewNextPlayer, "Engine.PlayerController.ServerViewNextPlayer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsSpectating;
    /// <summary>
    /// Function: IsSpectating
    /// </summary>
    public unsafe override bool IsSpectating()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSpectating, "Engine.PlayerController.IsSpectating");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckJumpOrDuck;
    /// <summary>
    /// Function: CheckJumpOrDuck
    /// </summary>
    public unsafe virtual void CheckJumpOrDuck()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckJumpOrDuck, "Engine.PlayerController.CheckJumpOrDuck");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LimitViewRotation;
    /// <summary>
    /// Function: LimitViewRotation
    /// </summary>
    public unsafe virtual BmSDK.Rotator LimitViewRotation(BmSDK.Rotator ViewRotation, float ViewPitchMin, float ViewPitchMax)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LimitViewRotation, "Engine.PlayerController.LimitViewRotation");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewRotation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewPitchMin, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewPitchMax, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ProcessViewRotation;
    /// <summary>
    /// Function: ProcessViewRotation
    /// </summary>
    public unsafe virtual void ProcessViewRotation(float DeltaTime, out BmSDK.Rotator out_ViewRotation, BmSDK.Rotator DeltaRot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessViewRotation, "Engine.PlayerController.ProcessViewRotation");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_ViewRotation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_ViewRotation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaRot, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_ViewRotation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_UpdateRotation;
    /// <summary>
    /// Function: UpdateRotation
    /// </summary>
    public unsafe virtual void UpdateRotation(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateRotation, "Engine.PlayerController.UpdateRotation");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ViewShake;
    /// <summary>
    /// Function: ViewShake
    /// </summary>
    public unsafe virtual void ViewShake(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ViewShake, "Engine.PlayerController.ViewShake");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPlayerViewPoint;
    /// <summary>
    /// Function: GetPlayerViewPoint
    /// </summary>
    public unsafe override void GetPlayerViewPoint(out System.Numerics.Vector3 out_Location, out BmSDK.Rotator out_Rotation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerViewPoint, "Engine.PlayerController.GetPlayerViewPoint");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_Location);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_Location, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_Rotation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_Rotation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_Location = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        out_Rotation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_SpawnPlayerCamera;
    /// <summary>
    /// Function: SpawnPlayerCamera
    /// </summary>
    public unsafe virtual void SpawnPlayerCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnPlayerCamera, "Engine.PlayerController.SpawnPlayerCamera");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerVerifyViewTarget;
    /// <summary>
    /// Function: ServerVerifyViewTarget
    /// </summary>
    public unsafe virtual void ServerVerifyViewTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerVerifyViewTarget, "Engine.PlayerController.ServerVerifyViewTarget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetViewTarget;
    /// <summary>
    /// Function: GetViewTarget
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor GetViewTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetViewTarget, "Engine.PlayerController.GetViewTarget");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClientSetViewTarget;
    /// <summary>
    /// Function: ClientSetViewTarget
    /// </summary>
    public unsafe virtual void ClientSetViewTarget(BmSDK.Engine.Actor A, BmSDK.Engine.Camera.FViewTargetTransitionParams TransitionParams = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientSetViewTarget, "Engine.PlayerController.ClientSetViewTarget");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionParams, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetViewTarget;
    /// <summary>
    /// Function: SetViewTarget
    /// </summary>
    public unsafe virtual void SetViewTarget(BmSDK.Engine.Actor NewViewTarget, BmSDK.Engine.Camera.FViewTargetTransitionParams TransitionParams = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetViewTarget, "Engine.PlayerController.SetViewTarget");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewViewTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionParams, paramsPtr + 4);
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

    private static BmSDK.Function __fn_IsLocalPlayerController;
    /// <summary>
    /// Function: IsLocalPlayerController
    /// </summary>
    public unsafe override bool IsLocalPlayerController()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLocalPlayerController, "Engine.PlayerController.IsLocalPlayerController");
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

    private static BmSDK.Function __fn_GetFOVAngle;
    /// <summary>
    /// Function: GetFOVAngle
    /// </summary>
    public unsafe virtual float GetFOVAngle()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFOVAngle, "Engine.PlayerController.GetFOVAngle");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AdjustFOV;
    /// <summary>
    /// Function: AdjustFOV
    /// </summary>
    public unsafe virtual void AdjustFOV(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdjustFOV, "Engine.PlayerController.AdjustFOV");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyLanded;
    /// <summary>
    /// Function: NotifyLanded
    /// </summary>
    public unsafe override bool NotifyLanded(System.Numerics.Vector3 HitNormal, BmSDK.Engine.Actor FloorActor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyLanded, "Engine.PlayerController.NotifyLanded");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FloorActor, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_AimHelpDot;
    /// <summary>
    /// Function: AimHelpDot
    /// </summary>
    public unsafe virtual float AimHelpDot(bool bInstantHit)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AimHelpDot, "Engine.PlayerController.AimHelpDot");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInstantHit, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetAdjustedAimFor;
    /// <summary>
    /// Function: GetAdjustedAimFor
    /// </summary>
    public unsafe override BmSDK.Rotator GetAdjustedAimFor(BmSDK.Engine.Weapon W, System.Numerics.Vector3 StartFireLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAdjustedAimFor, "Engine.PlayerController.GetAdjustedAimFor");
        byte* paramsPtr = stackalloc byte[164];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(W, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartFireLoc, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_AimingHelp;
    /// <summary>
    /// Function: AimingHelp
    /// </summary>
    public unsafe virtual bool AimingHelp(bool bInstantHit)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AimingHelp, "Engine.PlayerController.AimingHelp");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInstantHit, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PlayerMove;
    /// <summary>
    /// Function: PlayerMove
    /// </summary>
    public unsafe virtual void PlayerMove(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerMove, "Engine.PlayerController.PlayerMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerTick;
    /// <summary>
    /// Function: PlayerTick
    /// </summary>
    public unsafe virtual void PlayerTick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerTick, "Engine.PlayerController.PlayerTick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyChangedWeapon;
    /// <summary>
    /// Function: NotifyChangedWeapon
    /// </summary>
    public unsafe override void NotifyChangedWeapon(BmSDK.Engine.Weapon PreviousWeapon, BmSDK.Engine.Weapon NewWeapon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyChangedWeapon, "Engine.PlayerController.NotifyChangedWeapon");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientGameEnded;
    /// <summary>
    /// Function: ClientGameEnded
    /// </summary>
    public unsafe virtual void ClientGameEnded(BmSDK.Engine.Actor EndGameFocus, bool bIsWinner)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientGameEnded, "Engine.PlayerController.ClientGameEnded");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndGameFocus, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsWinner, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GameHasEnded;
    /// <summary>
    /// Function: GameHasEnded
    /// </summary>
    public unsafe override void GameHasEnded(BmSDK.Engine.Actor EndGameFocus = default, bool bIsWinner = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GameHasEnded, "Engine.PlayerController.GameHasEnded");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndGameFocus, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsWinner, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientRestart;
    /// <summary>
    /// Function: ClientRestart
    /// </summary>
    public unsafe virtual void ClientRestart(BmSDK.Engine.Pawn NewPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientRestart, "Engine.PlayerController.ClientRestart");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnterStartState;
    /// <summary>
    /// Function: EnterStartState
    /// </summary>
    public unsafe virtual void EnterStartState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnterStartState, "Engine.PlayerController.EnterStartState");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceSingleNetUpdateFor;
    /// <summary>
    /// Function: ForceSingleNetUpdateFor
    /// </summary>
    public unsafe virtual void ForceSingleNetUpdateFor(BmSDK.Engine.Actor Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceSingleNetUpdateFor, "Engine.PlayerController.ForceSingleNetUpdateFor");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
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

    private static BmSDK.Function __fn_HasClientLoadedCurrentWorld;
    /// <summary>
    /// Function: HasClientLoadedCurrentWorld
    /// </summary>
    public unsafe virtual bool HasClientLoadedCurrentWorld()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasClientLoadedCurrentWorld, "Engine.PlayerController.HasClientLoadedCurrentWorld");
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

    private static BmSDK.Function __fn_NotifyLoadedWorld;
    /// <summary>
    /// Function: NotifyLoadedWorld
    /// </summary>
    public unsafe virtual void NotifyLoadedWorld(BmSDK.FName WorldPackageName, bool bFinalDest)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyLoadedWorld, "Engine.PlayerController.NotifyLoadedWorld");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WorldPackageName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFinalDest, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerNotifyLoadedWorld;
    /// <summary>
    /// Function: ServerNotifyLoadedWorld
    /// </summary>
    public unsafe virtual void ServerNotifyLoadedWorld(BmSDK.FName WorldPackageName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerNotifyLoadedWorld, "Engine.PlayerController.ServerNotifyLoadedWorld");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WorldPackageName, paramsPtr + 0);
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

    private static BmSDK.Function __fn_Restart;
    /// <summary>
    /// Function: Restart
    /// </summary>
    public unsafe override void Restart(bool bVehicleTransition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Restart, "Engine.PlayerController.Restart");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVehicleTransition, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientSetProgressMessage;
    /// <summary>
    /// Function: ClientSetProgressMessage
    /// </summary>
    public unsafe virtual void ClientSetProgressMessage(BmSDK.Engine.PlayerController.EProgressMessageType MessageType, BmSDK.FString Message, BmSDK.FString Title = default, bool bIgnoreFutureNetworkMessages = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientSetProgressMessage, "Engine.PlayerController.ClientSetProgressMessage");
        byte* paramsPtr = stackalloc byte[48];
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

    private static BmSDK.Function __fn_SwitchLevel;
    /// <summary>
    /// Function: SwitchLevel
    /// </summary>
    public unsafe virtual void SwitchLevel(BmSDK.FString URL)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchLevel, "Engine.PlayerController.SwitchLevel");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(URL, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerChangeTeam;
    /// <summary>
    /// Function: ServerChangeTeam
    /// </summary>
    public unsafe virtual void ServerChangeTeam(int N)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerChangeTeam, "Engine.PlayerController.ServerChangeTeam");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(N, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChangeTeam;
    /// <summary>
    /// Function: ChangeTeam
    /// </summary>
    public unsafe virtual void ChangeTeam(BmSDK.FString TeamName = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeTeam, "Engine.PlayerController.ChangeTeam");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamName, paramsPtr + 0);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_SwitchTeam;
    /// <summary>
    /// Function: SwitchTeam
    /// </summary>
    public unsafe virtual void SwitchTeam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchTeam, "Engine.PlayerController.SwitchTeam");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerChangeName;
    /// <summary>
    /// Function: ServerChangeName
    /// </summary>
    public unsafe virtual void ServerChangeName(BmSDK.FString S)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerChangeName, "Engine.PlayerController.ServerChangeName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(S, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetName;
    /// <summary>
    /// Function: SetName
    /// </summary>
    public unsafe virtual void SetName(BmSDK.FString S)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetName, "Engine.PlayerController.SetName");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(S, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerSuicide;
    /// <summary>
    /// Function: ServerSuicide
    /// </summary>
    public unsafe virtual void ServerSuicide()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerSuicide, "Engine.PlayerController.ServerSuicide");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Suicide;
    /// <summary>
    /// Function: Suicide
    /// </summary>
    public unsafe virtual void Suicide()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Suicide, "Engine.PlayerController.Suicide");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerInteracted;
    /// <summary>
    /// Function: TriggerInteracted
    /// </summary>
    public unsafe virtual bool TriggerInteracted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerInteracted, "Engine.PlayerController.TriggerInteracted");
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PerformedUseAction;
    /// <summary>
    /// Function: PerformedUseAction
    /// </summary>
    public unsafe virtual bool PerformedUseAction()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PerformedUseAction, "Engine.PlayerController.PerformedUseAction");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ServerUse;
    /// <summary>
    /// Function: ServerUse
    /// </summary>
    public unsafe virtual void ServerUse()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerUse, "Engine.PlayerController.ServerUse");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Use;
    /// <summary>
    /// Function: Use
    /// </summary>
    public unsafe virtual void Use()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Use, "Engine.PlayerController.Use");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTriggerUseList;
    /// <summary>
    /// Function: GetTriggerUseList
    /// </summary>
    public unsafe virtual void GetTriggerUseList(float interactDistanceToCheck, float crosshairDist, float minDot, bool bUsuableOnly, out BmSDK.TArray<BmSDK.Engine.Trigger> out_useList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTriggerUseList, "Engine.PlayerController.GetTriggerUseList");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(interactDistanceToCheck, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(crosshairDist, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(minDot, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUsuableOnly, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_useList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Trigger>>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_StopAltFire;
    /// <summary>
    /// Function: StopAltFire
    /// </summary>
    public unsafe virtual void StopAltFire(byte FireModeNum = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAltFire, "Engine.PlayerController.StopAltFire");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireModeNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartAltFire;
    /// <summary>
    /// Function: StartAltFire
    /// </summary>
    public unsafe virtual void StartAltFire(byte FireModeNum = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAltFire, "Engine.PlayerController.StartAltFire");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireModeNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopFire;
    /// <summary>
    /// Function: StopFire
    /// </summary>
    public unsafe virtual void StopFire(byte FireModeNum = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopFire, "Engine.PlayerController.StopFire");
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
    public unsafe virtual void StartFire(byte FireModeNum = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartFire, "Engine.PlayerController.StartFire");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireModeNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NextWeapon;
    /// <summary>
    /// Function: NextWeapon
    /// </summary>
    public unsafe virtual void NextWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NextWeapon, "Engine.PlayerController.NextWeapon");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PrevWeapon;
    /// <summary>
    /// Function: PrevWeapon
    /// </summary>
    public unsafe virtual void PrevWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrevWeapon, "Engine.PlayerController.PrevWeapon");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerThrowWeapon;
    /// <summary>
    /// Function: ServerThrowWeapon
    /// </summary>
    public unsafe virtual void ServerThrowWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerThrowWeapon, "Engine.PlayerController.ServerThrowWeapon");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThrowWeapon;
    /// <summary>
    /// Function: ThrowWeapon
    /// </summary>
    public unsafe virtual void ThrowWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThrowWeapon, "Engine.PlayerController.ThrowWeapon");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UTrace;
    /// <summary>
    /// Function: UTrace
    /// </summary>
    public unsafe virtual void UTrace()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UTrace, "Engine.PlayerController.UTrace");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerUTrace;
    /// <summary>
    /// Function: ServerUTrace
    /// </summary>
    public unsafe virtual void ServerUTrace()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerUTrace, "Engine.PlayerController.ServerUTrace");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ConditionalPause;
    /// <summary>
    /// Function: ConditionalPause
    /// </summary>
    public unsafe virtual void ConditionalPause(bool bDesiredPauseState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConditionalPause, "Engine.PlayerController.ConditionalPause");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDesiredPauseState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerPause;
    /// <summary>
    /// Function: ServerPause
    /// </summary>
    public unsafe virtual void ServerPause()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerPause, "Engine.PlayerController.ServerPause");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Pause;
    /// <summary>
    /// Function: Pause
    /// </summary>
    public unsafe virtual void Pause()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Pause, "Engine.PlayerController.Pause");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPaused;
    /// <summary>
    /// Function: IsPaused
    /// </summary>
    public unsafe virtual bool IsPaused()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPaused, "Engine.PlayerController.IsPaused");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetPause;
    /// <summary>
    /// Function: SetPause
    /// </summary>
    public unsafe virtual bool SetPause(bool bPause, System.IntPtr CanUnpauseDelegate = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPause, "Engine.PlayerController.SetPause");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPause, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CanUnpauseDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CanUnpause;
    /// <summary>
    /// Function: CanUnpause
    /// </summary>
    public unsafe virtual bool CanUnpause()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUnpause, "Engine.PlayerController.CanUnpause");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PauseRumbleForAllPlayers;
    /// <summary>
    /// Function: PauseRumbleForAllPlayers
    /// </summary>
    public unsafe virtual void PauseRumbleForAllPlayers(bool bShouldPauseRumble = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PauseRumbleForAllPlayers, "Engine.PlayerController.PauseRumbleForAllPlayers");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldPauseRumble, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LocalTravel;
    /// <summary>
    /// Function: LocalTravel
    /// </summary>
    public unsafe virtual void LocalTravel(BmSDK.FString URL)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LocalTravel, "Engine.PlayerController.LocalTravel");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(URL, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RestartLevel;
    /// <summary>
    /// Function: RestartLevel
    /// </summary>
    public unsafe virtual void RestartLevel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestartLevel, "Engine.PlayerController.RestartLevel");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerSpeech;
    /// <summary>
    /// Function: ServerSpeech
    /// </summary>
    public unsafe virtual void ServerSpeech(BmSDK.FName Type, int Index, BmSDK.FString Callsign)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerSpeech, "Engine.PlayerController.ServerSpeech");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Callsign, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Speech;
    /// <summary>
    /// Function: Speech
    /// </summary>
    public unsafe virtual void Speech(BmSDK.FName Type, int Index, BmSDK.FString Callsign)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Speech, "Engine.PlayerController.Speech");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Callsign, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerRestartGame;
    /// <summary>
    /// Function: ServerRestartGame
    /// </summary>
    public unsafe virtual void ServerRestartGame()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerRestartGame, "Engine.PlayerController.ServerRestartGame");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleWalking;
    /// <summary>
    /// Function: HandleWalking
    /// </summary>
    public unsafe virtual void HandleWalking()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleWalking, "Engine.PlayerController.HandleWalking");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearAckedMoves;
    /// <summary>
    /// Function: ClearAckedMoves
    /// </summary>
    public unsafe virtual void ClearAckedMoves()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearAckedMoves, "Engine.PlayerController.ClearAckedMoves");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientCapBandwidth;
    /// <summary>
    /// Function: ClientCapBandwidth
    /// </summary>
    public unsafe virtual void ClientCapBandwidth(int Cap)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientCapBandwidth, "Engine.PlayerController.ClientCapBandwidth");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Cap, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MoveAutonomous;
    /// <summary>
    /// Function: MoveAutonomous
    /// </summary>
    public unsafe virtual void MoveAutonomous(float DeltaTime, byte CompressedFlags, System.Numerics.Vector3 newAccel, BmSDK.Rotator DeltaRot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveAutonomous, "Engine.PlayerController.MoveAutonomous");
        byte* paramsPtr = stackalloc byte[49];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CompressedFlags, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(newAccel, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaRot, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessMove;
    /// <summary>
    /// Function: ProcessMove
    /// </summary>
    public unsafe virtual void ProcessMove(float DeltaTime, System.Numerics.Vector3 newAccel, BmSDK.Engine.Actor.EDoubleClickDir DoubleClickMove, BmSDK.Rotator DeltaRot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessMove, "Engine.PlayerController.ProcessMove");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(newAccel, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DoubleClickMove, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaRot, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceDeathUpdate;
    /// <summary>
    /// Function: ForceDeathUpdate
    /// </summary>
    public unsafe virtual void ForceDeathUpdate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceDeathUpdate, "Engine.PlayerController.ForceDeathUpdate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientSetCameraFade;
    /// <summary>
    /// Function: ClientSetCameraFade
    /// </summary>
    public unsafe virtual void ClientSetCameraFade(bool bEnableFading, BmSDK.GameObject.FColor FadeColor = default, System.Numerics.Vector2 FadeAlpha = default, float FadeTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientSetCameraFade, "Engine.PlayerController.ClientSetCameraFade");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableFading, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FadeColor, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FadeAlpha, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FadeTime, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetCameraMode;
    /// <summary>
    /// Function: ResetCameraMode
    /// </summary>
    public unsafe virtual void ResetCameraMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetCameraMode, "Engine.PlayerController.ResetCameraMode");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCameraMode;
    /// <summary>
    /// Function: SetCameraMode
    /// </summary>
    public unsafe virtual void SetCameraMode(BmSDK.FName NewCamMode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCameraMode, "Engine.PlayerController.SetCameraMode");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCamMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientSetCameraMode;
    /// <summary>
    /// Function: ClientSetCameraMode
    /// </summary>
    public unsafe virtual void ClientSetCameraMode(BmSDK.FName NewCamMode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientSetCameraMode, "Engine.PlayerController.ClientSetCameraMode");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCamMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerCamera;
    /// <summary>
    /// Function: ServerCamera
    /// </summary>
    public unsafe virtual void ServerCamera(BmSDK.FName NewMode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerCamera, "Engine.PlayerController.ServerCamera");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Camera;
    /// <summary>
    /// Function: Camera
    /// </summary>
    public unsafe virtual void Camera(BmSDK.FName NewMode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Camera, "Engine.PlayerController.Camera");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreClientTravel;
    /// <summary>
    /// Function: PreClientTravel
    /// </summary>
    public unsafe virtual void PreClientTravel(BmSDK.FString PendingURL, BmSDK.Engine.Actor.ETravelType TravelType, bool bIsSeamlessTravel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreClientTravel, "Engine.PlayerController.PreClientTravel");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PendingURL, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TravelType, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsSeamlessTravel, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerMutate;
    /// <summary>
    /// Function: ServerMutate
    /// </summary>
    public unsafe virtual void ServerMutate(BmSDK.FString MutateString)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerMutate, "Engine.PlayerController.ServerMutate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MutateString, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Mutate;
    /// <summary>
    /// Function: Mutate
    /// </summary>
    public unsafe virtual void Mutate(BmSDK.FString MutateString)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Mutate, "Engine.PlayerController.Mutate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MutateString, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FOV;
    /// <summary>
    /// Function: FOV
    /// </summary>
    public unsafe virtual void FOV(float F)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FOV, "Engine.PlayerController.FOV");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(F, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetFOV;
    /// <summary>
    /// Function: ResetFOV
    /// </summary>
    public unsafe virtual void ResetFOV()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetFOV, "Engine.PlayerController.ResetFOV");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetFOV;
    /// <summary>
    /// Function: SetFOV
    /// </summary>
    public unsafe virtual void SetFOV(float NewFOV)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFOV, "Engine.PlayerController.SetFOV");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFOV, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FixFOV;
    /// <summary>
    /// Function: FixFOV
    /// </summary>
    public unsafe virtual void FixFOV()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FixFOV, "Engine.PlayerController.FixFOV");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "Engine.PlayerController.Destroyed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CleanupPawn;
    /// <summary>
    /// Function: CleanupPawn
    /// </summary>
    public unsafe virtual void CleanupPawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CleanupPawn, "Engine.PlayerController.CleanupPawn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearOnlineDelegates;
    /// <summary>
    /// Function: ClearOnlineDelegates
    /// </summary>
    public unsafe virtual void ClearOnlineDelegates()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearOnlineDelegates, "Engine.PlayerController.ClearOnlineDelegates");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPartyMembersInfoChanged;
    /// <summary>
    /// Function: OnPartyMembersInfoChanged
    /// </summary>
    public unsafe virtual void OnPartyMembersInfoChanged(BmSDK.FString PlayerName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, int CustomData1, int CustomData2, int CustomData3, int CustomData4)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPartyMembersInfoChanged, "Engine.PlayerController.OnPartyMembersInfoChanged");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomData1, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomData2, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomData3, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomData4, paramsPtr + 68);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPartyMemberListChanged;
    /// <summary>
    /// Function: OnPartyMemberListChanged
    /// </summary>
    public unsafe virtual void OnPartyMemberListChanged(bool bJoinedOrLeft, BmSDK.FString PlayerName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPartyMemberListChanged, "Engine.PlayerController.OnPartyMemberListChanged");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bJoinedOrLeft, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterOnlineDelegates;
    /// <summary>
    /// Function: RegisterOnlineDelegates
    /// </summary>
    public unsafe virtual void RegisterOnlineDelegates()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterOnlineDelegates, "Engine.PlayerController.RegisterOnlineDelegates");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayBeepSound;
    /// <summary>
    /// Function: PlayBeepSound
    /// </summary>
    public unsafe virtual void PlayBeepSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayBeepSound, "Engine.PlayerController.PlayBeepSound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TeamMessage;
    /// <summary>
    /// Function: TeamMessage
    /// </summary>
    public unsafe virtual void TeamMessage(BmSDK.Engine.PlayerReplicationInfo PRI, BmSDK.FString S, BmSDK.FName Type, float MsgLifeTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TeamMessage, "Engine.PlayerController.TeamMessage");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PRI, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(S, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MsgLifeTime, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayUICue;
    /// <summary>
    /// Function: PlayUICue
    /// </summary>
    public unsafe virtual BmSDK.Engine.AudioComponent PlayUICue(BmSDK.Engine.SoundCue Cue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayUICue, "Engine.PlayerController.PlayUICue");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Cue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AudioComponent>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CreateTTSSoundCue;
    /// <summary>
    /// Function: CreateTTSSoundCue
    /// </summary>
    public unsafe BmSDK.Engine.SoundCue CreateTTSSoundCue(BmSDK.FString StrToSpeak, BmSDK.Engine.PlayerReplicationInfo PRI)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateTTSSoundCue, "Engine.PlayerController.CreateTTSSoundCue");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrToSpeak, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PRI, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.SoundCue>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CanCommunicate;
    /// <summary>
    /// Function: CanCommunicate
    /// </summary>
    public unsafe bool CanCommunicate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanCommunicate, "Engine.PlayerController.CanCommunicate");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClientMessage;
    /// <summary>
    /// Function: ClientMessage
    /// </summary>
    public unsafe virtual void ClientMessage(BmSDK.FString S, BmSDK.FName Type = default, float MsgLifeTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientMessage, "Engine.PlayerController.ClientMessage");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(S, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MsgLifeTime, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientPlayActorFaceFXAnim;
    /// <summary>
    /// Function: ClientPlayActorFaceFXAnim
    /// </summary>
    public unsafe virtual void ClientPlayActorFaceFXAnim(BmSDK.Engine.Actor SourceActor, BmSDK.Engine.FaceFXAnimSet AnimSet, BmSDK.FString GroupName, BmSDK.FString SeqName, BmSDK.Engine.RDialogueEvent DialogueEvent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientPlayActorFaceFXAnim, "Engine.PlayerController.ClientPlayActorFaceFXAnim");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SourceActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GroupName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SeqName, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueEvent, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Kismet_ClientStopSound;
    /// <summary>
    /// Function: Kismet_ClientStopSound
    /// </summary>
    public unsafe virtual void Kismet_ClientStopSound(BmSDK.Engine.SoundCue ASound, BmSDK.Engine.Actor SourceActor, float FadeOutTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Kismet_ClientStopSound, "Engine.PlayerController.Kismet_ClientStopSound");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ASound, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SourceActor, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FadeOutTime, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Kismet_ClientKeyOffSound;
    /// <summary>
    /// Function: Kismet_ClientKeyOffSound
    /// </summary>
    public unsafe virtual void Kismet_ClientKeyOffSound(BmSDK.Engine.SoundCue ASound, BmSDK.Engine.Actor SourceActor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Kismet_ClientKeyOffSound, "Engine.PlayerController.Kismet_ClientKeyOffSound");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ASound, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SourceActor, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Kismet_ClientPlaySound;
    /// <summary>
    /// Function: Kismet_ClientPlaySound
    /// </summary>
    public unsafe virtual void Kismet_ClientPlaySound(BmSDK.Engine.SoundCue ASound, BmSDK.Engine.Actor SourceActor, float VolumeMultiplier, float PitchMultiplier, float FadeInTime, bool bSuppressSubtitles, bool bSuppressSpatialization)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Kismet_ClientPlaySound, "Engine.PlayerController.Kismet_ClientPlaySound");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ASound, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SourceActor, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VolumeMultiplier, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PitchMultiplier, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FadeInTime, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSuppressSubtitles, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSuppressSpatialization, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPooledAudioComponent;
    /// <summary>
    /// Function: GetPooledAudioComponent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AudioComponent GetPooledAudioComponent(BmSDK.Engine.SoundCue ASound, BmSDK.Engine.Actor SourceActor, bool bStopWhenOwnerDestroyed, bool bUseLocation = default, System.Numerics.Vector3 SourceLocation = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPooledAudioComponent, "Engine.PlayerController.GetPooledAudioComponent");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ASound, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SourceActor, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStopWhenOwnerDestroyed, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SourceLocation, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AudioComponent>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_ReceiveLocalizedMessage;
    /// <summary>
    /// Function: ReceiveLocalizedMessage
    /// </summary>
    public unsafe virtual void ReceiveLocalizedMessage(BmSDK.Class Message, int Switch = default, BmSDK.Engine.PlayerReplicationInfo RelatedPRI_1 = default, BmSDK.Engine.PlayerReplicationInfo RelatedPRI_2 = default, BmSDK.GameObject OptionalObject = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReceiveLocalizedMessage, "Engine.PlayerController.ReceiveLocalizedMessage");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Switch, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RelatedPRI_1, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RelatedPRI_2, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OptionalObject, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CleanupPRI;
    /// <summary>
    /// Function: CleanupPRI
    /// </summary>
    public unsafe override void CleanupPRI()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CleanupPRI, "Engine.PlayerController.CleanupPRI");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandlePickup;
    /// <summary>
    /// Function: HandlePickup
    /// </summary>
    public unsafe override void HandlePickup(BmSDK.Engine.Inventory Inv)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandlePickup, "Engine.PlayerController.HandlePickup");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Inv, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientSetHUD;
    /// <summary>
    /// Function: ClientSetHUD
    /// </summary>
    public unsafe virtual void ClientSetHUD(BmSDK.Class newHUDType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientSetHUD, "Engine.PlayerController.ClientSetHUD");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(newHUDType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PawnDied;
    /// <summary>
    /// Function: PawnDied
    /// </summary>
    public unsafe override void PawnDied(BmSDK.Engine.Pawn P)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnDied, "Engine.PlayerController.PawnDied");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnPossess;
    /// <summary>
    /// Function: UnPossess
    /// </summary>
    public unsafe override void UnPossess()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnPossess, "Engine.PlayerController.UnPossess");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerAcknowledgePossession;
    /// <summary>
    /// Function: ServerAcknowledgePossession
    /// </summary>
    public unsafe virtual void ServerAcknowledgePossession(BmSDK.Engine.Pawn P)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerAcknowledgePossession, "Engine.PlayerController.ServerAcknowledgePossession");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AcknowledgePossession;
    /// <summary>
    /// Function: AcknowledgePossession
    /// </summary>
    public unsafe virtual void AcknowledgePossession(BmSDK.Engine.Pawn P)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AcknowledgePossession, "Engine.PlayerController.AcknowledgePossession");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Possess;
    /// <summary>
    /// Function: Possess
    /// </summary>
    public unsafe override void Possess(BmSDK.Engine.Pawn aPawn, bool bVehicleTransition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Possess, "Engine.PlayerController.Possess");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVehicleTransition, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GivePawn;
    /// <summary>
    /// Function: GivePawn
    /// </summary>
    public unsafe virtual void GivePawn(BmSDK.Engine.Pawn NewPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GivePawn, "Engine.PlayerController.GivePawn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AskForPawn;
    /// <summary>
    /// Function: AskForPawn
    /// </summary>
    public unsafe virtual void AskForPawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AskForPawn, "Engine.PlayerController.AskForPawn");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientGotoState;
    /// <summary>
    /// Function: ClientGotoState
    /// </summary>
    public unsafe virtual void ClientGotoState(BmSDK.FName NewState, BmSDK.FName NewLabel = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientGotoState, "Engine.PlayerController.ClientGotoState");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewState, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLabel, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsMouseAvailable;
    /// <summary>
    /// Function: IsMouseAvailable
    /// </summary>
    public unsafe virtual bool IsMouseAvailable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsMouseAvailable, "Engine.PlayerController.IsMouseAvailable");
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

    private static BmSDK.Function __fn_IsKeyboardAvailable;
    /// <summary>
    /// Function: IsKeyboardAvailable
    /// </summary>
    public unsafe virtual bool IsKeyboardAvailable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsKeyboardAvailable, "Engine.PlayerController.IsKeyboardAvailable");
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

    private static BmSDK.Function __fn_SetUseTiltForwardAndBack;
    /// <summary>
    /// Function: SetUseTiltForwardAndBack
    /// </summary>
    public unsafe virtual void SetUseTiltForwardAndBack(bool bActive)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetUseTiltForwardAndBack, "Engine.PlayerController.SetUseTiltForwardAndBack");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActive, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetOnlyUseControllerTiltInput;
    /// <summary>
    /// Function: SetOnlyUseControllerTiltInput
    /// </summary>
    public unsafe virtual void SetOnlyUseControllerTiltInput(bool bActive)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOnlyUseControllerTiltInput, "Engine.PlayerController.SetOnlyUseControllerTiltInput");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActive, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetControllerTiltActive;
    /// <summary>
    /// Function: SetControllerTiltActive
    /// </summary>
    public unsafe virtual void SetControllerTiltActive(bool bActive)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetControllerTiltActive, "Engine.PlayerController.SetControllerTiltActive");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActive, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetControllerTiltDesiredIfAvailable;
    /// <summary>
    /// Function: SetControllerTiltDesiredIfAvailable
    /// </summary>
    public unsafe virtual void SetControllerTiltDesiredIfAvailable(bool bActive)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetControllerTiltDesiredIfAvailable, "Engine.PlayerController.SetControllerTiltDesiredIfAvailable");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActive, paramsPtr + 0);
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

    private static BmSDK.Function __fn_IsControllerTiltActive;
    /// <summary>
    /// Function: IsControllerTiltActive
    /// </summary>
    public unsafe virtual bool IsControllerTiltActive()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsControllerTiltActive, "Engine.PlayerController.IsControllerTiltActive");
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

    private static BmSDK.Function __fn_ReloadProfileSettings;
    /// <summary>
    /// Function: ReloadProfileSettings
    /// </summary>
    public unsafe virtual void ReloadProfileSettings()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReloadProfileSettings, "Engine.PlayerController.ReloadProfileSettings");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnregisterStandardPlayerDataStores;
    /// <summary>
    /// Function: UnregisterStandardPlayerDataStores
    /// </summary>
    public unsafe virtual void UnregisterStandardPlayerDataStores()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnregisterStandardPlayerDataStores, "Engine.PlayerController.UnregisterStandardPlayerDataStores");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnregisterPlayerDataStores;
    /// <summary>
    /// Function: UnregisterPlayerDataStores
    /// </summary>
    public unsafe virtual void UnregisterPlayerDataStores()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnregisterPlayerDataStores, "Engine.PlayerController.UnregisterPlayerDataStores");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterStandardPlayerDataStores;
    /// <summary>
    /// Function: RegisterStandardPlayerDataStores
    /// </summary>
    public unsafe virtual void RegisterStandardPlayerDataStores()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterStandardPlayerDataStores, "Engine.PlayerController.RegisterStandardPlayerDataStores");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterCustomPlayerDataStores;
    /// <summary>
    /// Function: RegisterCustomPlayerDataStores
    /// </summary>
    public unsafe virtual void RegisterCustomPlayerDataStores()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterCustomPlayerDataStores, "Engine.PlayerController.RegisterCustomPlayerDataStores");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterPlayerDataStores;
    /// <summary>
    /// Function: RegisterPlayerDataStores
    /// </summary>
    public unsafe virtual void RegisterPlayerDataStores()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterPlayerDataStores, "Engine.PlayerController.RegisterPlayerDataStores");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientInitializeDataStores;
    /// <summary>
    /// Function: ClientInitializeDataStores
    /// </summary>
    public unsafe virtual void ClientInitializeDataStores()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientInitializeDataStores, "Engine.PlayerController.ClientInitializeDataStores");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitInputSystem;
    /// <summary>
    /// Function: InitInputSystem
    /// </summary>
    public unsafe virtual void InitInputSystem()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitInputSystem, "Engine.PlayerController.InitInputSystem");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostControllerIdChange;
    /// <summary>
    /// Function: PostControllerIdChange
    /// </summary>
    public unsafe virtual void PostControllerIdChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostControllerIdChange, "Engine.PlayerController.PostControllerIdChange");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreControllerIdChange;
    /// <summary>
    /// Function: PreControllerIdChange
    /// </summary>
    public unsafe virtual void PreControllerIdChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreControllerIdChange, "Engine.PlayerController.PreControllerIdChange");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CleanOutSavedMoves;
    /// <summary>
    /// Function: CleanOutSavedMoves
    /// </summary>
    public unsafe virtual void CleanOutSavedMoves()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CleanOutSavedMoves, "Engine.PlayerController.CleanOutSavedMoves");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientReset;
    /// <summary>
    /// Function: ClientReset
    /// </summary>
    public unsafe virtual void ClientReset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientReset, "Engine.PlayerController.ClientReset");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Reset;
    /// <summary>
    /// Function: Reset
    /// </summary>
    public unsafe override void Reset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Reset, "Engine.PlayerController.Reset");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CleanupGameViewport;
    /// <summary>
    /// Function: CleanupGameViewport
    /// </summary>
    public unsafe virtual void CleanupGameViewport()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CleanupGameViewport, "Engine.PlayerController.CleanupGameViewport");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnDefaultHUD;
    /// <summary>
    /// Function: SpawnDefaultHUD
    /// </summary>
    public unsafe virtual void SpawnDefaultHUD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnDefaultHUD, "Engine.PlayerController.SpawnDefaultHUD");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableCheats;
    /// <summary>
    /// Function: EnableCheats
    /// </summary>
    public unsafe virtual void EnableCheats()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableCheats, "Engine.PlayerController.EnableCheats");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddCheats;
    /// <summary>
    /// Function: AddCheats
    /// </summary>
    public unsafe virtual void AddCheats(bool bForce = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCheats, "Engine.PlayerController.AddCheats");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForce, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KickWarning;
    /// <summary>
    /// Function: KickWarning
    /// </summary>
    public unsafe virtual void KickWarning()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KickWarning, "Engine.PlayerController.KickWarning");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerGivePawn;
    /// <summary>
    /// Function: ServerGivePawn
    /// </summary>
    public unsafe override void ServerGivePawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerGivePawn, "Engine.PlayerController.ServerGivePawn");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerShortTimeout;
    /// <summary>
    /// Function: ServerShortTimeout
    /// </summary>
    public unsafe virtual void ServerShortTimeout()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerShortTimeout, "Engine.PlayerController.ServerShortTimeout");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetTimeMargin;
    /// <summary>
    /// Function: ResetTimeMargin
    /// </summary>
    public unsafe virtual void ResetTimeMargin()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetTimeMargin, "Engine.PlayerController.ResetTimeMargin");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreRender;
    /// <summary>
    /// Function: PreRender
    /// </summary>
    public unsafe virtual void PreRender(BmSDK.Engine.Canvas Canvas)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreRender, "Engine.PlayerController.PreRender");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TellPeerToTravelToSession;
    /// <summary>
    /// Function: TellPeerToTravelToSession
    /// </summary>
    public unsafe virtual void TellPeerToTravelToSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ToPeerNetId, BmSDK.FName SessionName, BmSDK.Class SearchClass, byte PlatformSpecificInfo, int PlatformSpecificInfoSize)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TellPeerToTravelToSession, "Engine.PlayerController.TellPeerToTravelToSession");
        byte* paramsPtr = stackalloc byte[156];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToPeerNetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchClass, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformSpecificInfo, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformSpecificInfoSize, paramsPtr + 136);
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

    private static BmSDK.Function __fn_TellPeerToTravel;
    /// <summary>
    /// Function: TellPeerToTravel
    /// </summary>
    public unsafe virtual void TellPeerToTravel(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ToPeerNetId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TellPeerToTravel, "Engine.PlayerController.TellPeerToTravel");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToPeerNetId, paramsPtr + 0);
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

    private static BmSDK.Function __fn_PeerTravelAsHost;
    /// <summary>
    /// Function: PeerTravelAsHost
    /// </summary>
    public unsafe virtual void PeerTravelAsHost(float TravelCountdownTimer, BmSDK.FString URL)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PeerTravelAsHost, "Engine.PlayerController.PeerTravelAsHost");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TravelCountdownTimer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(URL, paramsPtr + 4);
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

    private static BmSDK.Function __fn_ReceivedPlayer;
    /// <summary>
    /// Function: ReceivedPlayer
    /// </summary>
    public unsafe virtual void ReceivedPlayer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReceivedPlayer, "Engine.PlayerController.ReceivedPlayer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "Engine.PlayerController.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsBackscreenLoaded;
    /// <summary>
    /// Function: IsBackscreenLoaded
    /// </summary>
    public unsafe virtual bool IsBackscreenLoaded()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBackscreenLoaded, "Engine.PlayerController.IsBackscreenLoaded");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckForDelayedPause;
    /// <summary>
    /// Function: CheckForDelayedPause
    /// </summary>
    public unsafe virtual bool CheckForDelayedPause()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForDelayedPause, "Engine.PlayerController.CheckForDelayedPause");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnControllerChanged;
    /// <summary>
    /// Function: OnControllerChanged
    /// </summary>
    public unsafe virtual void OnControllerChanged(int ControllerId, bool bIsConnected)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnControllerChanged, "Engine.PlayerController.OnControllerChanged");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsConnected, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanUnpauseExternalUI;
    /// <summary>
    /// Function: CanUnpauseExternalUI
    /// </summary>
    public unsafe virtual bool CanUnpauseExternalUI()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUnpauseExternalUI, "Engine.PlayerController.CanUnpauseExternalUI");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnExternalUIChanged;
    /// <summary>
    /// Function: OnExternalUIChanged
    /// </summary>
    public unsafe virtual void OnExternalUIChanged(bool bIsOpening)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnExternalUIChanged, "Engine.PlayerController.OnExternalUIChanged");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsOpening, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayForceFeedbackWaveform_Simple;
    /// <summary>
    /// Function: PlayForceFeedbackWaveform_Simple
    /// </summary>
    public unsafe virtual void PlayForceFeedbackWaveform_Simple(float Duration, int leftStrength, int rightStrength, int rumbleFunction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayForceFeedbackWaveform_Simple, "Engine.PlayerController.PlayForceFeedbackWaveform_Simple");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(leftStrength, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(rightStrength, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(rumbleFunction, paramsPtr + 12);
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

    private static BmSDK.Function __fn_ForceClearUnpauseDelegates;
    /// <summary>
    /// Function: ForceClearUnpauseDelegates
    /// </summary>
    public unsafe virtual void ForceClearUnpauseDelegates()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceClearUnpauseDelegates, "Engine.PlayerController.ForceClearUnpauseDelegates");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FellOutOfWorld;
    /// <summary>
    /// Function: FellOutOfWorld
    /// </summary>
    public unsafe override void FellOutOfWorld(BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FellOutOfWorld, "Engine.PlayerController.FellOutOfWorld");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CleanUpAudioComponents;
    /// <summary>
    /// Function: CleanUpAudioComponents
    /// </summary>
    public unsafe virtual void CleanUpAudioComponents()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CleanUpAudioComponents, "Engine.PlayerController.CleanUpAudioComponents");
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

    private static BmSDK.Function __fn_FindStairRotation;
    /// <summary>
    /// Function: FindStairRotation
    /// </summary>
    public unsafe virtual int FindStairRotation(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindStairRotation, "Engine.PlayerController.FindStairRotation");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CheckSpeedHack;
    /// <summary>
    /// Function: CheckSpeedHack
    /// </summary>
    public unsafe virtual bool CheckSpeedHack(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckSpeedHack, "Engine.PlayerController.CheckSpeedHack");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ServerProcessConvolve;
    /// <summary>
    /// Function: ServerProcessConvolve
    /// </summary>
    public unsafe void ServerProcessConvolve(BmSDK.FString C, int H)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerProcessConvolve, "Engine.PlayerController.ServerProcessConvolve");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 12);
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

    private static BmSDK.Function __fn_ClientConvolve;
    /// <summary>
    /// Function: ClientConvolve
    /// </summary>
    public unsafe void ClientConvolve(BmSDK.FString C, int H)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientConvolve, "Engine.PlayerController.ClientConvolve");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 12);
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

    private static BmSDK.Function __fn_SetAllowMatureLanguage;
    /// <summary>
    /// Function: SetAllowMatureLanguage
    /// </summary>
    public unsafe virtual void SetAllowMatureLanguage(bool bAllowMatureLanguge)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAllowMatureLanguage, "Engine.PlayerController.SetAllowMatureLanguage");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowMatureLanguge, paramsPtr + 0);
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

    private static BmSDK.Function __fn_PasteFromClipboard;
    /// <summary>
    /// Function: PasteFromClipboard
    /// </summary>
    public unsafe virtual BmSDK.FString PasteFromClipboard()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PasteFromClipboard, "Engine.PlayerController.PasteFromClipboard");
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

    private static BmSDK.Function __fn_CopyToClipboard;
    /// <summary>
    /// Function: CopyToClipboard
    /// </summary>
    public unsafe virtual void CopyToClipboard(BmSDK.FString Text)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CopyToClipboard, "Engine.PlayerController.CopyToClipboard");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetDefaultURL;
    /// <summary>
    /// Function: GetDefaultURL
    /// </summary>
    public unsafe virtual BmSDK.FString GetDefaultURL(BmSDK.FString Option)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultURL, "Engine.PlayerController.GetDefaultURL");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Option, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UpdateURL;
    /// <summary>
    /// Function: UpdateURL
    /// </summary>
    public unsafe virtual void UpdateURL(BmSDK.FString NewOption, BmSDK.FString NewValue, bool bSave1Default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateURL, "Engine.PlayerController.UpdateURL");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOption, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewValue, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSave1Default, paramsPtr + 24);
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

    private static BmSDK.Function __fn_ClientTravel;
    /// <summary>
    /// Function: ClientTravel
    /// </summary>
    public unsafe virtual void ClientTravel(BmSDK.FString URL, BmSDK.Engine.Actor.ETravelType TravelType, bool bSeamless = default, BmSDK.GameObject.FGuid MapPackageGuid = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientTravel, "Engine.PlayerController.ClientTravel");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(URL, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TravelType, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSeamless, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapPackageGuid, paramsPtr + 20);
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

    private static BmSDK.Function __fn_ConsoleCommand;
    /// <summary>
    /// Function: ConsoleCommand
    /// </summary>
    public unsafe override BmSDK.FString ConsoleCommand(BmSDK.FString Command, bool bWriteToLog = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConsoleCommand, "Engine.PlayerController.ConsoleCommand");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Command, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWriteToLog, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetServerNetworkAddress;
    /// <summary>
    /// Function: GetServerNetworkAddress
    /// </summary>
    public unsafe virtual BmSDK.FString GetServerNetworkAddress()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetServerNetworkAddress, "Engine.PlayerController.GetServerNetworkAddress");
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

    private static BmSDK.Function __fn_GetPlayerNetworkAddress;
    /// <summary>
    /// Function: GetPlayerNetworkAddress
    /// </summary>
    public unsafe virtual BmSDK.FString GetPlayerNetworkAddress()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerNetworkAddress, "Engine.PlayerController.GetPlayerNetworkAddress");
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

    private static BmSDK.Function __fn_SetNetSpeed;
    /// <summary>
    /// Function: SetNetSpeed
    /// </summary>
    public unsafe virtual void SetNetSpeed(int NewSpeed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNetSpeed, "Engine.PlayerController.SetNetSpeed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSpeed, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AllowConsole;
    /// <summary>
    /// Function: AllowConsole
    /// </summary>
    public unsafe virtual bool AllowConsole()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowConsole, "Engine.PlayerController.AllowConsole");
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

    /// <summary>
    /// Struct: FAmbientSoundStruct
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FAmbientSoundStruct
    {
        /// <summary>
        /// IntProperty: AmbientSound_ReferenceNumber
        /// </summary>
        public unsafe int AmbientSound_ReferenceNumber
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: AmbientSound_Cue
        /// </summary>
        public unsafe BmSDK.Engine.SoundCue AmbientSound_Cue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SoundCue>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: AmbientSound_Priority
        /// </summary>
        public unsafe int AmbientSound_Priority
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: AmbientSound_Time
        /// </summary>
        public unsafe float AmbientSound_Time
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Enum: EProgressMessageType
    /// </summary>
    public enum EProgressMessageType : byte
    {
        PMT_Clear = 0,
        PMT_Information = 1,
        PMT_AdminMessage = 2,
        PMT_DownloadProgress = 3,
        PMT_ConnectionFailure = 4,
        PMT_PeerConnectionFailure = 5,
        PMT_PeerHostMigrationFailure = 6,
        PMT_SocketFailure = 7,
        PMT_MAX = 8,
    }

    /// <summary>
    /// Struct: FDebugTextInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial record struct FDebugTextInfo
    {
        /// <summary>
        /// ObjectProperty: SrcActor
        /// </summary>
        public unsafe BmSDK.Engine.Actor SrcActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: SrcActorOffset
        /// </summary>
        public unsafe System.Numerics.Vector3 SrcActorOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: SrcActorDesiredOffset
        /// </summary>
        public unsafe System.Numerics.Vector3 SrcActorDesiredOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StrProperty: DebugText
        /// </summary>
        public unsafe BmSDK.FString DebugText
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: TimeRemaining
        /// </summary>
        public unsafe float TimeRemaining
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// FloatProperty: Duration
        /// </summary>
        public unsafe float Duration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// StructProperty: TextColor
        /// </summary>
        public unsafe BmSDK.GameObject.FColor TextColor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// BoolProperty: bAbsoluteLocation
        /// </summary>
        public unsafe bool bAbsoluteLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }; }
        }

        /// <summary>
        /// BoolProperty: bKeepAttachedToActor
        /// </summary>
        public unsafe bool bKeepAttachedToActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }; }
        }

        /// <summary>
        /// StructProperty: OrigActorLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 OrigActorLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// ObjectProperty: Font
        /// </summary>
        public unsafe BmSDK.Engine.Font Font
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Font>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }
    }

    /// <summary>
    /// Struct: FInputMatchRequest
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public partial record struct FInputMatchRequest
    {
        /// <summary>
        /// ArrayProperty: Inputs
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.PlayerController.FInputEntry> Inputs
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.PlayerController.FInputEntry>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: MatchActor
        /// </summary>
        public unsafe BmSDK.Engine.Actor MatchActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// NameProperty: MatchFuncName
        /// </summary>
        public unsafe BmSDK.FName MatchFuncName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// DelegateProperty: MatchDelegate
        /// </summary>
        public unsafe System.IntPtr MatchDelegate
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// NameProperty: FailedFuncName
        /// </summary>
        public unsafe BmSDK.FName FailedFuncName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// NameProperty: RequestName
        /// </summary>
        public unsafe BmSDK.FName RequestName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// IntProperty: MatchIdx
        /// </summary>
        public unsafe int MatchIdx
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// FloatProperty: LastMatchTime
        /// </summary>
        public unsafe float LastMatchTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }
    }

    /// <summary>
    /// Struct: FInputEntry
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FInputEntry
    {
        /// <summary>
        /// ByteProperty: Type
        /// </summary>
        public unsafe BmSDK.Engine.PlayerController.EInputTypes Type
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerController.EInputTypes>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Value
        /// </summary>
        public unsafe float Value
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: TimeDelta
        /// </summary>
        public unsafe float TimeDelta
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ByteProperty: Action
        /// </summary>
        public unsafe BmSDK.Engine.PlayerController.EInputMatchAction Action
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerController.EInputMatchAction>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Enum: EInputMatchAction
    /// </summary>
    public enum EInputMatchAction : byte
    {
        IMA_GreaterThan = 0,
        IMA_LessThan = 1,
        IMA_MAX = 2,
    }

    /// <summary>
    /// Enum: EInputTypes
    /// </summary>
    public enum EInputTypes : byte
    {
        IT_XAxis = 0,
        IT_YAxis = 1,
        IT_MAX = 2,
    }

    /// <summary>
    /// Struct: FConnectedPeerInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public partial record struct FConnectedPeerInfo
    {
        /// <summary>
        /// StructProperty: PlayerID
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: NatType
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.ENATType NatType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.ENATType>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// BoolProperty: bLostConnectionToHost
        /// </summary>
        public unsafe bool bLostConnectionToHost
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }; }
        }
    }

    /// <summary>
    /// Struct: FClientAdjustment
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public partial record struct FClientAdjustment
    {
        /// <summary>
        /// FloatProperty: TimeStamp
        /// </summary>
        public unsafe float TimeStamp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: newPhysics
        /// </summary>
        public unsafe BmSDK.Engine.Actor.EPhysics newPhysics
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.EPhysics>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: NewLoc
        /// </summary>
        public unsafe System.Numerics.Vector3 NewLoc
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: NewVel
        /// </summary>
        public unsafe System.Numerics.Vector3 NewVel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ObjectProperty: NewBase
        /// </summary>
        public unsafe BmSDK.Engine.Actor NewBase
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StructProperty: NewFloor
        /// </summary>
        public unsafe System.Numerics.Vector3 NewFloor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// ByteProperty: bAckGoodMove
        /// </summary>
        public unsafe byte bAckGoodMove
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: Player
    /// </summary>
    public unsafe BmSDK.Engine.Player Player
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Player>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ObjectProperty: PlayerCamera
    /// </summary>
    public unsafe BmSDK.Engine.Camera PlayerCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Camera>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// ClassProperty: CameraClass
    /// </summary>
    public unsafe BmSDK.Class CameraClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ObjectProperty: simpleFFWaveform
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform simpleFFWaveform
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// BoolProperty: bFrozen
    /// </summary>
    public unsafe bool bFrozen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bPressedJump
    /// </summary>
    public unsafe bool bPressedJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bDoubleJump
    /// </summary>
    public unsafe bool bDoubleJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bUpdatePosition
    /// </summary>
    public unsafe bool bUpdatePosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bUpdating
    /// </summary>
    public unsafe bool bUpdating
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bNeverSwitchOnPickup
    /// </summary>
    public unsafe bool bNeverSwitchOnPickup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bCheatFlying
    /// </summary>
    public unsafe bool bCheatFlying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bCameraPositionLocked
    /// </summary>
    public unsafe bool bCameraPositionLocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bShortConnectTimeOut
    /// </summary>
    public unsafe bool bShortConnectTimeOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bPendingDestroy
    /// </summary>
    public unsafe bool bPendingDestroy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bWasSpeedHack
    /// </summary>
    public unsafe bool bWasSpeedHack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bWasSaturated
    /// </summary>
    public unsafe bool bWasSaturated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bAimingHelp
    /// </summary>
    public unsafe bool bAimingHelp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bClientSimulatingViewTarget
    /// </summary>
    public unsafe bool bClientSimulatingViewTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bHasVoiceHandshakeCompleted
    /// </summary>
    public unsafe bool bHasVoiceHandshakeCompleted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bCinematicMode
    /// </summary>
    public unsafe bool bCinematicMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bCinemaDisableInputMove
    /// </summary>
    public unsafe bool bCinemaDisableInputMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bCinemaDisableInputLook
    /// </summary>
    public unsafe bool bCinemaDisableInputLook
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreNetworkMessages
    /// </summary>
    public unsafe bool bIgnoreNetworkMessages
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bReplicateAllPawns
    /// </summary>
    public unsafe bool bReplicateAllPawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bIsUsingStreamingVolumes
    /// </summary>
    public unsafe bool bIsUsingStreamingVolumes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bIsExternalUIOpen
    /// </summary>
    public unsafe bool bIsExternalUIOpen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bIsControllerConnected
    /// </summary>
    public unsafe bool bIsControllerConnected
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bCheckSoundOcclusion
    /// </summary>
    public unsafe bool bCheckSoundOcclusion
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bDebugCameraAnims
    /// </summary>
    public unsafe bool bDebugCameraAnims
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bBlockCameraAnimsFromOverridingPostProcess
    /// </summary>
    public unsafe bool bBlockCameraAnimsFromOverridingPostProcess
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bLogHearSoundOverflow
    /// </summary>
    public unsafe bool bLogHearSoundOverflow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bCheckRelevancyThroughPortals
    /// </summary>
    public unsafe bool bCheckRelevancyThroughPortals
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bControllerWasDisconnected
    /// </summary>
    public unsafe bool bControllerWasDisconnected
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bDidLoseFocusDeferPause
    /// </summary>
    public unsafe bool bDidLoseFocusDeferPause
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// BoolProperty: bDebugClientAdjustPosition
    /// </summary>
    public unsafe bool bDebugClientAdjustPosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }

    /// <summary>
    /// FloatProperty: MaxResponseTime
    /// </summary>
    public unsafe float MaxResponseTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// FloatProperty: WaitDelay
    /// </summary>
    public unsafe float WaitDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// ObjectProperty: AcknowledgedPawn
    /// </summary>
    public unsafe BmSDK.Engine.Pawn AcknowledgedPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// ByteProperty: DoubleClickDir
    /// </summary>
    public unsafe BmSDK.Engine.Actor.EDoubleClickDir DoubleClickDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.EDoubleClickDir>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// ByteProperty: bIgnoreMoveInput
    /// </summary>
    public unsafe byte bIgnoreMoveInput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 909); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 909); }
    }

    /// <summary>
    /// ByteProperty: bIgnoreLookInput
    /// </summary>
    public unsafe byte bIgnoreLookInput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 910); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 910); }
    }

    /// <summary>
    /// ByteProperty: bRun
    /// </summary>
    public unsafe byte bRun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 911); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 911); }
    }

    /// <summary>
    /// ByteProperty: bDuck
    /// </summary>
    public unsafe byte bDuck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// ByteProperty: NetPlayerIndex
    /// </summary>
    public unsafe byte NetPlayerIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 913); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 913); }
    }

    /// <summary>
    /// ObjectProperty: ViewTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor ViewTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// ObjectProperty: RealViewTarget
    /// </summary>
    public unsafe BmSDK.Engine.PlayerReplicationInfo RealViewTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerReplicationInfo>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// ObjectProperty: ControllingDirTrackInst
    /// </summary>
    public unsafe BmSDK.Engine.InterpTrackInstDirector ControllingDirTrackInst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.InterpTrackInstDirector>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// FloatProperty: FOVAngle
    /// </summary>
    public unsafe float FOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// FloatProperty: DesiredFOV
    /// </summary>
    public unsafe float DesiredFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// FloatProperty: DefaultFOV
    /// </summary>
    public unsafe float DefaultFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// FloatProperty: LODDistanceFactor
    /// </summary>
    public unsafe float LODDistanceFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// StructProperty: TargetViewRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator TargetViewRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 944);

    /// <summary>
    /// FloatProperty: TargetEyeHeight
    /// </summary>
    public unsafe float TargetEyeHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// StructProperty: BlendedTargetViewRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator BlendedTargetViewRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 960);

    /// <summary>
    /// ObjectProperty: myHUD
    /// </summary>
    public unsafe BmSDK.Engine.HUD myHUD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.HUD>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// ClassProperty: SavedMoveClass
    /// </summary>
    public unsafe BmSDK.Class SavedMoveClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// ObjectProperty: SavedMoves
    /// </summary>
    public unsafe BmSDK.Engine.SavedMove SavedMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SavedMove>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// ObjectProperty: FreeMoves
    /// </summary>
    public unsafe BmSDK.Engine.SavedMove FreeMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SavedMove>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// ObjectProperty: PendingMove
    /// </summary>
    public unsafe BmSDK.Engine.SavedMove PendingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SavedMove>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// StructProperty: LastAckedAccel
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastAckedAccel
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 992);

    /// <summary>
    /// FloatProperty: CurrentTimeStamp
    /// </summary>
    public unsafe float CurrentTimeStamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// FloatProperty: LastUpdateTime
    /// </summary>
    public unsafe float LastUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// FloatProperty: ServerTimeStamp
    /// </summary>
    public unsafe float ServerTimeStamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// FloatProperty: TimeMargin
    /// </summary>
    public unsafe float TimeMargin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// FloatProperty: ClientUpdateTime
    /// </summary>
    public unsafe float ClientUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// FloatProperty: MaxTimeMargin
    /// </summary>
    public unsafe float MaxTimeMargin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// FloatProperty: LastActiveTime
    /// </summary>
    public unsafe float LastActiveTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// IntProperty: ClientCap
    /// </summary>
    public unsafe int ClientCap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// FloatProperty: DynamicPingThreshold
    /// </summary>
    public unsafe float DynamicPingThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// FloatProperty: LastPingUpdate
    /// </summary>
    public unsafe float LastPingUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// FloatProperty: LastSpeedHackLog
    /// </summary>
    public unsafe float LastSpeedHackLog
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// StructProperty: PendingAdjustment
    /// </summary>
    public unsafe ref BmSDK.Engine.PlayerController.FClientAdjustment PendingAdjustment
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.PlayerController.FClientAdjustment>(Ptr + 1048);

    /// <summary>
    /// IntProperty: GroundPitch
    /// </summary>
    public unsafe int GroundPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// ObjectProperty: CheatManager
    /// </summary>
    public unsafe BmSDK.Engine.CheatManager CheatManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CheatManager>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ClassProperty: CheatClass
    /// </summary>
    public unsafe BmSDK.Class CheatClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// ObjectProperty: PlayerInput
    /// </summary>
    public unsafe BmSDK.Engine.PlayerInput PlayerInput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerInput>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// ClassProperty: InputClass
    /// </summary>
    public unsafe BmSDK.Class InputClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// StructProperty: FailedPathStart
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FailedPathStart
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1120);

    /// <summary>
    /// ComponentProperty: CylinderComponent
    /// </summary>
    public unsafe BmSDK.Engine.CylinderComponent CylinderComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CylinderComponent>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// StrProperty: ForceFeedbackManagerClassName
    /// </summary>
    public unsafe BmSDK.FString ForceFeedbackManagerClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// ObjectProperty: ForceFeedbackManager
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackManager ForceFeedbackManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackManager>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// ArrayProperty: Interactions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Interaction> Interactions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Interaction>>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// ArrayProperty: VoiceMuteList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> VoiceMuteList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// ArrayProperty: GameplayVoiceMuteList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> GameplayVoiceMuteList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// ArrayProperty: VoicePacketFilter
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> VoicePacketFilter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// ArrayProperty: ConnectedPeers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.PlayerController.FConnectedPeerInfo> ConnectedPeers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.PlayerController.FConnectedPeerInfo>>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// ArrayProperty: BestNextHostPeers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> BestNextHostPeers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// ObjectProperty: MigratedSearchToJoin
    /// </summary>
    public unsafe BmSDK.Engine.OnlineGameSearch MigratedSearchToJoin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineGameSearch>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// ObjectProperty: OnlineSub
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem OnlineSub
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }

    /// <summary>
    /// InterfaceProperty: VoiceInterface
    /// </summary>
    public unsafe BmSDK.Engine.OnlineVoiceInterface VoiceInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineVoiceInterface>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// ObjectProperty: OnlinePlayerData
    /// </summary>
    public unsafe BmSDK.Engine.UIDataStore_OnlinePlayerData OnlinePlayerData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIDataStore_OnlinePlayerData>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// FloatProperty: InteractDistance
    /// </summary>
    public unsafe float InteractDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }

    /// <summary>
    /// NameProperty: DelayedJoinSessionName
    /// </summary>
    public unsafe BmSDK.FName DelayedJoinSessionName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// ArrayProperty: InputRequests
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.PlayerController.FInputMatchRequest> InputRequests
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.PlayerController.FInputMatchRequest>>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// FloatProperty: LastBroadcastTime
    /// </summary>
    public unsafe float LastBroadcastTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// InlineArray{StrProperty}: LastBroadcastString
    /// </summary>
    public InlineArray<BmSDK.FString> LastBroadcastString => new(4, Ptr + 1272, 12, this);

    /// <summary>
    /// StrProperty: LastBroadcastString
    /// </summary>
    public unsafe BmSDK.FString LastBroadcastString_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }
    /// <summary>
    /// StrProperty: LastBroadcastString
    /// </summary>
    public unsafe BmSDK.FString LastBroadcastString_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }
    /// <summary>
    /// StrProperty: LastBroadcastString
    /// </summary>
    public unsafe BmSDK.FString LastBroadcastString_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }
    /// <summary>
    /// StrProperty: LastBroadcastString
    /// </summary>
    public unsafe BmSDK.FString LastBroadcastString_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// ArrayProperty: PendingMapChangeLevelNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> PendingMapChangeLevelNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// ArrayProperty: DebugTextList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.PlayerController.FDebugTextInfo> DebugTextList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.PlayerController.FDebugTextInfo>>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }

    /// <summary>
    /// FloatProperty: SpectatorCameraSpeed
    /// </summary>
    public unsafe float SpectatorCameraSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// ObjectProperty: PendingSwapConnection
    /// </summary>
    public unsafe BmSDK.Engine.NetConnection PendingSwapConnection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NetConnection>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// FloatProperty: MinRespawnDelay
    /// </summary>
    public unsafe float MinRespawnDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// IntProperty: MaxConcurrentHearSounds
    /// </summary>
    public unsafe int MaxConcurrentHearSounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// ArrayProperty: HearSoundActiveComponents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AudioComponent> HearSoundActiveComponents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AudioComponent>>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// ArrayProperty: HearSoundPoolComponents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AudioComponent> HearSoundPoolComponents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AudioComponent>>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }

    /// <summary>
    /// ArrayProperty: HiddenActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> HiddenActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }
    }

    /// <summary>
    /// ArrayProperty: AmbientSoundStack
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.PlayerController.FAmbientSoundStruct> AmbientSoundStack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.PlayerController.FAmbientSoundStruct>>(Ptr + 1396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1396); }
    }

    /// <summary>
    /// ComponentProperty: AmbCurrentSoundPtr
    /// </summary>
    public unsafe BmSDK.Engine.AudioComponent AmbCurrentSoundPtr
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AudioComponent>(Ptr + 1408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }
    }

    /// <summary>
    /// ComponentProperty: AmbOtherSoundPtr
    /// </summary>
    public unsafe BmSDK.Engine.AudioComponent AmbOtherSoundPtr
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AudioComponent>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// FloatProperty: LastSpectatorStateSynchTime
    /// </summary>
    public unsafe float LastSpectatorStateSynchTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// ObjectProperty: ActiveDialogueOptions
    /// </summary>
    public unsafe BmSDK.Engine.SeqAct_Latent ActiveDialogueOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SeqAct_Latent>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// FloatProperty: mCaseFileCameraBlendTime
    /// </summary>
    public unsafe float mCaseFileCameraBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// DelegateProperty: __CanUnpause__Delegate
    /// </summary>
    public unsafe System.IntPtr __CanUnpause__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1428); }
    }

    /// <summary>
    /// DelegateProperty: __InputMatchDelegate__Delegate
    /// </summary>
    public unsafe System.IntPtr __InputMatchDelegate__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }
    }
}

/// <summary>
/// The static native functions of PlayerController, callable on an instance. A static native may read the object it runs on, and the static form runs it on the class default object, which has no world.
/// </summary>
public static class PlayerControllerStatics
{
    private static BmSDK.Function __fn_GetPlayerControllerFromNetId;
    /// <summary>
    /// Function: GetPlayerControllerFromNetId, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static BmSDK.Engine.PlayerController GetPlayerControllerFromNetId(this BmSDK.Engine.PlayerController self, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerNetId)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerControllerFromNetId, "Engine.PlayerController.GetPlayerControllerFromNetId");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNetId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PlayerController>(paramsPtr + 44);
    }
}
