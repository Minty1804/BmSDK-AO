#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawn<br/>
/// (size = 1340)
/// (flags = 142606518)
/// </summary>
public partial class RPawn : BmSDK.Engine.Pawn, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawn", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawn.
    /// </summary>
    public static RPawn DefaultObject => (RPawn)StaticClass().DefaultObject;

    internal RPawn() { }

    /// <summary>
    /// Constructs a new RPawn
    /// </summary>
    public RPawn(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawn(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawn>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawn>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawn>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawn>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawn>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawn>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawn>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawn>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetInterceptHudLocation;
    /// <summary>
    /// Function: GetInterceptHudLocation
    /// </summary>
    public unsafe virtual bool GetInterceptHudLocation(out System.Numerics.Vector3 HudLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInterceptHudLocation, "BmGame.RPawn.GetInterceptHudLocation");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HudLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HudLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        HudLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_StopAllDialogue;
    /// <summary>
    /// Function: StopAllDialogue
    /// </summary>
    public unsafe virtual void StopAllDialogue(bool Destroyed = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAllDialogue, "BmGame.RPawn.StopAllDialogue");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Destroyed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAudioEnvironment;
    /// <summary>
    /// Function: SetAudioEnvironment
    /// </summary>
    public unsafe override bool SetAudioEnvironment(BmSDK.TArray<BmSDK.Engine.AkWwise.FAkEnvironmentSettings> Environments, bool EnableEnvironments, float OcclusionMultiplier = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAudioEnvironment, "BmGame.RPawn.SetAudioEnvironment");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Environments, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnableEnvironments, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OcclusionMultiplier, paramsPtr + 16);
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

    private static BmSDK.Function __fn_OverrideAkComponentDefaults;
    /// <summary>
    /// Function: OverrideAkComponentDefaults
    /// </summary>
    public unsafe override void OverrideAkComponentDefaults(BmSDK.Engine.AkComponent akComp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideAkComponentDefaults, "BmGame.RPawn.OverrideAkComponentDefaults");
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

    private static BmSDK.Function __fn_ShouldContinueSurveillance;
    /// <summary>
    /// Function: ShouldContinueSurveillance
    /// </summary>
    public unsafe override bool ShouldContinueSurveillance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldContinueSurveillance, "BmGame.RPawn.ShouldContinueSurveillance");
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

    private static BmSDK.Function __fn_AkOnVocalFinished_NoSpeech;
    /// <summary>
    /// Function: AkOnVocalFinished_NoSpeech
    /// </summary>
    public unsafe virtual void AkOnVocalFinished_NoSpeech()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AkOnVocalFinished_NoSpeech, "BmGame.RPawn.AkOnVocalFinished_NoSpeech");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDry;
    /// <summary>
    /// Function: SetDry
    /// </summary>
    public unsafe virtual void SetDry()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDry, "BmGame.RPawn.SetDry");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetWet;
    /// <summary>
    /// Function: SetWet
    /// </summary>
    public unsafe virtual void SetWet(BmSDK.BmGame.RWaterVolumeBase Water)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWet, "BmGame.RPawn.SetWet");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Water, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetWetShallow;
    /// <summary>
    /// Function: SetWetShallow
    /// </summary>
    public unsafe virtual void SetWetShallow(float Amount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWetShallow, "BmGame.RPawn.SetWetShallow");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Amount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGlass;
    /// <summary>
    /// Function: SetGlass
    /// </summary>
    public unsafe virtual void SetGlass(bool bTouch)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGlass, "BmGame.RPawn.SetGlass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTouch, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPDD;
    /// <summary>
    /// Function: GetPDD
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPersistentDebugData GetPDD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPDD, "BmGame.RPawn.GetPDD");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPersistentDebugData>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DrawDebugGraphics;
    /// <summary>
    /// Function: DrawDebugGraphics
    /// </summary>
    public unsafe virtual void DrawDebugGraphics()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugGraphics, "BmGame.RPawn.DrawDebugGraphics");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetColourForType;
    /// <summary>
    /// Function: SetColourForType
    /// </summary>
    public unsafe virtual void SetColourForType(BmSDK.BmGame.RPawn.PawnHistoryType T, out byte R, out byte G, out byte B)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetColourForType, "BmGame.RPawn.SetColourForType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out R);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 1);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out G);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 2);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out B);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 3);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        R = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 1);
        G = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 2);
        B = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 3);
        return;
    }

    private static BmSDK.Function __fn_BuildHistoryStringFor;
    /// <summary>
    /// Function: BuildHistoryStringFor
    /// </summary>
    public unsafe virtual BmSDK.FString BuildHistoryStringFor(BmSDK.BmGame.RPawn.FHistoryInfo HI)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuildHistoryStringFor, "BmGame.RPawn.BuildHistoryStringFor");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HI, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ShouldDisplayType;
    /// <summary>
    /// Function: ShouldDisplayType
    /// </summary>
    public unsafe virtual bool ShouldDisplayType(BmSDK.BmGame.RPawn.PawnHistoryType T)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldDisplayType, "BmGame.RPawn.ShouldDisplayType");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OutputThoughtHistory;
    /// <summary>
    /// Function: OutputThoughtHistory
    /// </summary>
    public unsafe virtual void OutputThoughtHistory()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OutputThoughtHistory, "BmGame.RPawn.OutputThoughtHistory");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddToThoughtHistory;
    /// <summary>
    /// Function: AddToThoughtHistory
    /// </summary>
    public unsafe virtual void AddToThoughtHistory(BmSDK.FString BehaviourInfoString, BmSDK.BmGame.RPawn.PawnHistoryType T = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddToThoughtHistory, "BmGame.RPawn.AddToThoughtHistory");
        byte* paramsPtr = stackalloc byte[29];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BehaviourInfoString, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 12);
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

    private static BmSDK.Function __fn_GetThoughts;
    /// <summary>
    /// Function: GetThoughts
    /// </summary>
    public unsafe virtual void GetThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThoughts, "BmGame.RPawn.GetThoughts");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_KillEmotes;
    /// <summary>
    /// Function: KillEmotes
    /// </summary>
    public unsafe virtual void KillEmotes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillEmotes, "BmGame.RPawn.KillEmotes");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TeleportPhysics;
    /// <summary>
    /// Function: TeleportPhysics
    /// </summary>
    public unsafe virtual void TeleportPhysics()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TeleportPhysics, "BmGame.RPawn.TeleportPhysics");
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

    private static BmSDK.Function __fn_OnSetFaceFXRegister;
    /// <summary>
    /// Function: OnSetFaceFXRegister
    /// </summary>
    public unsafe virtual void OnSetFaceFXRegister(BmSDK.BmGame.RSeqAct_SetFaceFXRegister SeqAct)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSetFaceFXRegister, "BmGame.RPawn.OnSetFaceFXRegister");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SeqAct, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnimationTriggerCallback, "BmGame.RPawn.AnimationTriggerCallback");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TagName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Params, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TagAnimSet, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSpeechAction;
    /// <summary>
    /// Function: GetSpeechAction
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RSeqAct_PlaySpeechBase GetSpeechAction()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSpeechAction, "BmGame.RPawn.GetSpeechAction");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSeqAct_PlaySpeechBase>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CrushedBy;
    /// <summary>
    /// Function: CrushedBy
    /// </summary>
    public unsafe override void CrushedBy(BmSDK.Engine.Pawn OtherPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CrushedBy, "BmGame.RPawn.CrushedBy");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsValidSpeaker;
    /// <summary>
    /// Function: IsValidSpeaker
    /// </summary>
    public unsafe virtual bool IsValidSpeaker()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidSpeaker, "BmGame.RPawn.IsValidSpeaker");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnFootstepNotify;
    /// <summary>
    /// Function: OnFootstepNotify
    /// </summary>
    public unsafe virtual void OnFootstepNotify(BmSDK.BmGame.RAnimNotify_Footstep.EFoot Foot, BmSDK.BmGame.RAnimNotify_Footstep.EContactType Contact, BmSDK.BmGame.RAnimNotify_Footstep.EFootstepSurfaceFinder SurfaceFinder, System.Numerics.Vector3 FootLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFootstepNotify, "BmGame.RPawn.OnFootstepNotify");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Foot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Contact, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SurfaceFinder, paramsPtr + 2);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FootLocation, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CalcFootstepDistanceFromCamera;
    /// <summary>
    /// Function: CalcFootstepDistanceFromCamera
    /// </summary>
    public unsafe virtual float CalcFootstepDistanceFromCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalcFootstepDistanceFromCamera, "BmGame.RPawn.CalcFootstepDistanceFromCamera");
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

    private static BmSDK.Function __fn_FindFootstepSurface;
    /// <summary>
    /// Function: FindFootstepSurface
    /// </summary>
    public unsafe virtual bool FindFootstepSurface(BmSDK.BmGame.RAnimNotify_Footstep.EFootstepSurfaceFinder Type, BmSDK.BmGame.RAnimNotify_Footstep.EFoot Foot, BmSDK.BmGame.RAnimNotify_Footstep.EContactType Contact, out System.Numerics.Vector3 InOut_FootLocation, out BmSDK.Engine.PhysicalMaterial Out_Material)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindFootstepSurface, "BmGame.RPawn.FindFootstepSurface");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Foot, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Contact, paramsPtr + 2);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out InOut_FootLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InOut_FootLocation, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Out_Material);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Out_Material, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        InOut_FootLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
        Out_Material = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PhysicalMaterial>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_SpawnFootstepParticles;
    /// <summary>
    /// Function: SpawnFootstepParticles
    /// </summary>
    public unsafe virtual void SpawnFootstepParticles(BmSDK.BmGame.RAnimNotify_Footstep.EFoot Foot, BmSDK.BmGame.RAnimNotify_Footstep.EContactType Contact, System.Numerics.Vector3 FootLocation, BmSDK.BmGame.RPhysicalMaterialProperty Property)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnFootstepParticles, "BmGame.RPawn.SpawnFootstepParticles");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Foot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Contact, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FootLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Property, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetContactCharacterName;
    /// <summary>
    /// Function: GetContactCharacterName
    /// </summary>
    public unsafe virtual BmSDK.FString GetContactCharacterName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetContactCharacterName, "BmGame.RPawn.GetContactCharacterName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FindContactName;
    /// <summary>
    /// Function: FindContactName
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent FindContactName(BmSDK.BmGame.RAnimNotify_Footstep.EFoot Foot, BmSDK.BmGame.RAnimNotify_Footstep.EContactType Contact)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindContactName, "BmGame.RPawn.FindContactName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Foot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Contact, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OnSetRotation;
    /// <summary>
    /// Function: OnSetRotation
    /// </summary>
    public unsafe virtual void OnSetRotation(BmSDK.BmGame.RSeqAct_SetRotation Action)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSetRotation, "BmGame.RPawn.OnSetRotation");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanPlayBark;
    /// <summary>
    /// Function: CanPlayBark
    /// </summary>
    public unsafe virtual bool CanPlayBark()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayBark, "BmGame.RPawn.CanPlayBark");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayBark;
    /// <summary>
    /// Function: PlayBark
    /// </summary>
    public unsafe virtual void PlayBark(BmSDK.Engine.RDialogueLine DialogueLine, BmSDK.BmGame.RGameInfo.VocalPriority Priority = default, bool bSubtitles = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayBark, "BmGame.RPawn.PlayBark");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueLine, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSubtitles, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayEmote;
    /// <summary>
    /// Function: PlayEmote
    /// </summary>
    public unsafe virtual void PlayEmote(BmSDK.Engine.RDialogueLine DialogueLine, BmSDK.BmGame.RGameInfo.VocalPriority Priority = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayEmote, "BmGame.RPawn.PlayEmote");
        byte* paramsPtr = stackalloc byte[21];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueLine, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanPlaySpeech;
    /// <summary>
    /// Function: CanPlaySpeech
    /// </summary>
    public unsafe virtual bool CanPlaySpeech()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlaySpeech, "BmGame.RPawn.CanPlaySpeech");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayBossBark;
    /// <summary>
    /// Function: PlayBossBark
    /// </summary>
    public unsafe virtual void PlayBossBark(BmSDK.Engine.RDialogueLine DialogueLine, BmSDK.BmGame.RGameInfo.VocalPriority Priority = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayBossBark, "BmGame.RPawn.PlayBossBark");
        byte* paramsPtr = stackalloc byte[21];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueLine, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySpeechInternal;
    /// <summary>
    /// Function: PlaySpeechInternal
    /// </summary>
    public unsafe virtual void PlaySpeechInternal(BmSDK.Engine.RDialogueLine DialogueLine, BmSDK.BmGame.RGameInfo.VocalPriority Priority = default, BmSDK.Engine.SequenceAction PlaySpeechAction = default, bool bPlayEarcon = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySpeechInternal, "BmGame.RPawn.PlaySpeechInternal");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueLine, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlaySpeechAction, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayEarcon, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsEmoting;
    /// <summary>
    /// Function: IsEmoting
    /// </summary>
    public unsafe override bool IsEmoting()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsEmoting, "BmGame.RPawn.IsEmoting");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsSpeaking;
    /// <summary>
    /// Function: IsSpeaking
    /// </summary>
    public unsafe override bool IsSpeaking()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSpeaking, "BmGame.RPawn.IsSpeaking");
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

    private static BmSDK.Function __fn_FaceFXAudioStoppedCallback;
    /// <summary>
    /// Function: FaceFXAudioStoppedCallback
    /// </summary>
    public unsafe override void FaceFXAudioStoppedCallback()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FaceFXAudioStoppedCallback, "BmGame.RPawn.FaceFXAudioStoppedCallback");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FaceFXAudioStartedCallback;
    /// <summary>
    /// Function: FaceFXAudioStartedCallback
    /// </summary>
    public unsafe override void FaceFXAudioStartedCallback(BmSDK.Engine.RDialogueEvent DialogueEvent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FaceFXAudioStartedCallback, "BmGame.RPawn.FaceFXAudioStartedCallback");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueEvent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_gibbedBy;
    /// <summary>
    /// Function: gibbedBy
    /// </summary>
    public unsafe override void gibbedBy(BmSDK.Engine.Actor Other)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_gibbedBy, "BmGame.RPawn.gibbedBy");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TakeDamage;
    /// <summary>
    /// Function: TakeDamage
    /// </summary>
    public unsafe override void TakeDamage(int Damage, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeDamage, "BmGame.RPawn.TakeDamage");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 72);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBodyPartFromBoneName;
    /// <summary>
    /// Function: GetBodyPartFromBoneName
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawn.StunnedHitType GetBodyPartFromBoneName(BmSDK.FName BoneName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBodyPartFromBoneName, "BmGame.RPawn.GetBodyPartFromBoneName");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawn.StunnedHitType>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RPawn.Destroyed");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RPawn.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopFaceFXAudio;
    /// <summary>
    /// Function: StopFaceFXAudio
    /// </summary>
    public unsafe override void StopFaceFXAudio()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopFaceFXAudio, "BmGame.RPawn.StopFaceFXAudio");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmGame.RPawn.PreStreamOut");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsIncapacitated;
    /// <summary>
    /// Function: IsIncapacitated
    /// </summary>
    public unsafe virtual bool IsIncapacitated()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsIncapacitated, "BmGame.RPawn.IsIncapacitated");
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

    private static BmSDK.Function __fn_GetNearestReachable;
    /// <summary>
    /// Function: GetNearestReachable
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetNearestReachable(System.Numerics.Vector3 StartPoint, System.Numerics.Vector3 TargetPoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNearestReachable, "BmGame.RPawn.GetNearestReachable");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPoint, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetSafePoint;
    /// <summary>
    /// Function: GetSafePoint
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor GetSafePoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSafePoint, "BmGame.RPawn.GetSafePoint");
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

    private static BmSDK.Function __fn_IsSafe;
    /// <summary>
    /// Function: IsSafe
    /// </summary>
    public unsafe virtual bool IsSafe()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSafe, "BmGame.RPawn.IsSafe");
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

    private static BmSDK.Function __fn_IsActorSafe;
    /// <summary>
    /// Function: IsActorSafe
    /// </summary>
    public unsafe virtual bool IsActorSafe(BmSDK.Engine.Actor A)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsActorSafe, "BmGame.RPawn.IsActorSafe");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TransientWeightByAngle;
    /// <summary>
    /// Function: TransientWeightByAngle
    /// </summary>
    public unsafe virtual void TransientWeightByAngle(System.Numerics.Vector3 CentrePoint, float MaxDist, BmSDK.Rotator ArcCentre, float AngleDegrees, float MaxWeight, float MinWeight)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TransientWeightByAngle, "BmGame.RPawn.TransientWeightByAngle");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CentrePoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxDist, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArcCentre, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AngleDegrees, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxWeight, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinWeight, paramsPtr + 36);
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

    private static BmSDK.Function __fn_TransientWeightByDist;
    /// <summary>
    /// Function: TransientWeightByDist
    /// </summary>
    public unsafe virtual void TransientWeightByDist(BmSDK.Engine.NavigationPoint StartNode, float TestDist, int CostToAdd)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TransientWeightByDist, "BmGame.RPawn.TransientWeightByDist");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartNode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestDist, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CostToAdd, paramsPtr + 8);
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

    private static BmSDK.Function __fn_GetRunAwayPoints;
    /// <summary>
    /// Function: GetRunAwayPoints
    /// </summary>
    public unsafe virtual void GetRunAwayPoints(System.Numerics.Vector3 CentrePoint, BmSDK.Engine.Actor BlockingActor = default, bool bClearNavs = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRunAwayPoints, "BmGame.RPawn.GetRunAwayPoints");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CentrePoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlockingActor, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bClearNavs, paramsPtr + 16);
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

    private static BmSDK.Function __fn_IsInConversation;
    /// <summary>
    /// Function: IsInConversation
    /// </summary>
    public unsafe override bool IsInConversation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInConversation, "BmGame.RPawn.IsInConversation");
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

    private static BmSDK.Function __fn_SetLocationIgnoringCollision;
    /// <summary>
    /// Function: SetLocationIgnoringCollision
    /// </summary>
    public unsafe virtual void SetLocationIgnoringCollision(System.Numerics.Vector3 NewLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLocationIgnoringCollision, "BmGame.RPawn.SetLocationIgnoringCollision");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLocation, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetHeadMesh;
    /// <summary>
    /// Function: GetHeadMesh
    /// </summary>
    public unsafe virtual BmSDK.Engine.SkeletalMeshComponent GetHeadMesh()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeadMesh, "BmGame.RPawn.GetHeadMesh");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.SkeletalMeshComponent>(paramsPtr + 0);
    }

    /// <summary>
    /// Struct: FHistoryInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FHistoryInfo
    {
        /// <summary>
        /// StrProperty: Text
        /// </summary>
        public unsafe BmSDK.FString Text
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
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

        /// <summary>
        /// ByteProperty: Type
        /// </summary>
        public unsafe BmSDK.BmGame.RPawn.PawnHistoryType Type
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawn.PawnHistoryType>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Enum: PawnHistoryType
    /// </summary>
    public enum PawnHistoryType : byte
    {
        PHT_General = 0,
        PHT_Behaviour = 1,
        PHT_BehaviourState = 2,
        PHT_ActionQueue = 3,
        PHT_MAX = 4,
    }

    /// <summary>
    /// Struct: FBodyPartMadObj
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FBodyPartMadObj
    {
        /// <summary>
        /// NameProperty: BoneName
        /// </summary>
        public unsafe BmSDK.FName BoneName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: BodyPart
        /// </summary>
        public unsafe BmSDK.BmGame.RPawn.StunnedHitType BodyPart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawn.StunnedHitType>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: StunnedHitType
    /// </summary>
    public enum StunnedHitType : byte
    {
        HT_None = 0,
        HT_Head = 1,
        HT_Body = 2,
        HT_LeftLeg = 3,
        HT_RightLeg = 4,
        HT_LeftArm = 5,
        HT_RightArm = 6,
        HT_LeftShoulder = 7,
        HT_RightShoulder = 8,
        HT_Chest = 9,
        HT_HeadUppercut = 10,
        HT_HeadSpinLeft = 11,
        HT_HeadSpinRight = 12,
        HT_MAX = 13,
    }

    /// <summary>
    /// NameProperty: NameFromScriptDatabase
    /// </summary>
    public unsafe BmSDK.FName NameFromScriptDatabase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// ComponentProperty: SpeechComponent
    /// </summary>
    public unsafe BmSDK.BmGame.RBMSpeechManager SpeechComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMSpeechManager>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// FloatProperty: TimeUntilCanBark
    /// </summary>
    public unsafe float TimeUntilCanBark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// ComponentProperty: LightEnvironment
    /// </summary>
    public unsafe BmSDK.Engine.DynamicLightEnvironmentComponent LightEnvironment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DynamicLightEnvironmentComponent>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// ComponentProperty: SecondaryMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent SecondaryMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// ComponentProperty: TertiaryMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent TertiaryMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// ComponentProperty: FourthMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent FourthMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// ArrayProperty: LOSCheckBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> LOSCheckBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: EnableFootsteps
    /// </summary>
    public unsafe bool EnableFootsteps
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1160); }
    }

    /// <summary>
    /// BoolProperty: BareFoot
    /// </summary>
    public unsafe bool BareFoot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1160); }
    }

    /// <summary>
    /// BoolProperty: bPotentialToJamDetectiveMode
    /// </summary>
    public unsafe bool bPotentialToJamDetectiveMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1160); }
    }

    /// <summary>
    /// BoolProperty: bJammerHasBeenRegistered
    /// </summary>
    public unsafe bool bJammerHasBeenRegistered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1160); }
    }

    /// <summary>
    /// BoolProperty: bInterruptSurveillance
    /// </summary>
    public unsafe bool bInterruptSurveillance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1160); }
    }

    /// <summary>
    /// BoolProperty: DisallowCameraHiding
    /// </summary>
    public unsafe bool DisallowCameraHiding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1160); }
    }

    /// <summary>
    /// BoolProperty: bDumpDebugSpheres
    /// </summary>
    public unsafe bool bDumpDebugSpheres
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1160); }
    }

    /// <summary>
    /// BoolProperty: bThoughtsDisplayed
    /// </summary>
    public unsafe bool bThoughtsDisplayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1160); }
    }

    /// <summary>
    /// BoolProperty: bSurveillanceEffectDisabled
    /// </summary>
    public unsafe bool bSurveillanceEffectDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1160); }
    }

    /// <summary>
    /// ArrayProperty: RunAwayPointList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPathNode> RunAwayPointList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPathNode>>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// IntProperty: NumPointsTested
    /// </summary>
    public unsafe int NumPointsTested
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// IntProperty: SweepDist
    /// </summary>
    public unsafe int SweepDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// ObjectProperty: LockedDynamicNode
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPathNode_SpecialMove LockedDynamicNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPathNode_SpecialMove>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// FloatProperty: WetFootStepAmount
    /// </summary>
    public unsafe float WetFootStepAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// IntProperty: InPuddle
    /// </summary>
    public unsafe int InPuddle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// IntProperty: OnGlass
    /// </summary>
    public unsafe int OnGlass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// ArrayProperty: BodyPartMap
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawn.FBodyPartMadObj> BodyPartMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawn.FBodyPartMadObj>>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// ObjectProperty: PawnSpecificAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PawnSpecificAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// ObjectProperty: AdditionalAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet AdditionalAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// ObjectProperty: BMCounterAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BMCounterAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1220); }
    }

    /// <summary>
    /// ObjectProperty: BMTakedownAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BMTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// ObjectProperty: BMThrowAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BMThrowAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }

    /// <summary>
    /// ObjectProperty: BMAerialAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BMAerialAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// ObjectProperty: CounterAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CounterAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }

    /// <summary>
    /// ObjectProperty: TakedownAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet TakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// ObjectProperty: ThrowAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet ThrowAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }

    /// <summary>
    /// ObjectProperty: AerialAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet AerialAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// ObjectProperty: HitReactionAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet HitReactionAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// ObjectProperty: EstimateStartAnchor
    /// </summary>
    public unsafe BmSDK.Engine.NavigationPoint EstimateStartAnchor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NavigationPoint>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// StructProperty: LastReferencePosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastReferencePosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1260);

    /// <summary>
    /// StructProperty: LastReferenceRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator LastReferenceRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1272);

    /// <summary>
    /// IntProperty: IsInConversationCount
    /// </summary>
    public unsafe int IsInConversationCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// ObjectProperty: LandedPhysMat
    /// </summary>
    public unsafe BmSDK.Engine.PhysicalMaterial LandedPhysMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicalMaterial>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// ComponentProperty: SurveillanceParticleEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent SurveillanceParticleEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }

    /// <summary>
    /// IntProperty: DS_R
    /// </summary>
    public unsafe int DS_R
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// IntProperty: DS_G
    /// </summary>
    public unsafe int DS_G
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// IntProperty: DS_B
    /// </summary>
    public unsafe int DS_B
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }

    /// <summary>
    /// FloatProperty: DS_Size
    /// </summary>
    public unsafe float DS_Size
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// ArrayProperty: ThoughtHistory
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawn.FHistoryInfo> ThoughtHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawn.FHistoryInfo>>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }

    /// <summary>
    /// FloatProperty: MaxFootstepNotifyDistanceSq
    /// </summary>
    public unsafe float MaxFootstepNotifyDistanceSq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// DelegateProperty: __IsActorSafe__Delegate
    /// </summary>
    public unsafe System.IntPtr __IsActorSafe__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }
}
