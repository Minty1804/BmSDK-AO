#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: Actor<br/>
/// (size = 452)
/// (flags = 142608531)
/// </summary>
public partial class Actor : BmSDK.StateObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Actor", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as Actor.
    /// </summary>
    public static Actor DefaultObject => (Actor)StaticClass().DefaultObject;

    internal Actor() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Actor(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Actor>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Actor>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Actor>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Actor>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Actor>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Actor>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Actor>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Actor>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CASHDLC_Event;
    /// <summary>
    /// Function: CASHDLC_Event
    /// </summary>
    public unsafe virtual int CASHDLC_Event(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CASHDLC_Event, "Engine.Actor.CASHDLC_Event");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CASHDLC_SetString;
    /// <summary>
    /// Function: CASHDLC_SetString
    /// </summary>
    public unsafe virtual void CASHDLC_SetString(int Index, BmSDK.FString Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CASHDLC_SetString, "Engine.Actor.CASHDLC_SetString");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CASHDLC_GetString;
    /// <summary>
    /// Function: CASHDLC_GetString
    /// </summary>
    public unsafe virtual BmSDK.FString CASHDLC_GetString(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CASHDLC_GetString, "Engine.Actor.CASHDLC_GetString");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CASHDLC_SetFloat;
    /// <summary>
    /// Function: CASHDLC_SetFloat
    /// </summary>
    public unsafe virtual void CASHDLC_SetFloat(int Index, float Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CASHDLC_SetFloat, "Engine.Actor.CASHDLC_SetFloat");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CASHDLC_GetFloat;
    /// <summary>
    /// Function: CASHDLC_GetFloat
    /// </summary>
    public unsafe virtual float CASHDLC_GetFloat(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CASHDLC_GetFloat, "Engine.Actor.CASHDLC_GetFloat");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CASHDLC_SetInt;
    /// <summary>
    /// Function: CASHDLC_SetInt
    /// </summary>
    public unsafe virtual void CASHDLC_SetInt(int Index, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CASHDLC_SetInt, "Engine.Actor.CASHDLC_SetInt");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CASHDLC_GetInt;
    /// <summary>
    /// Function: CASHDLC_GetInt
    /// </summary>
    public unsafe virtual int CASHDLC_GetInt(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CASHDLC_GetInt, "Engine.Actor.CASHDLC_GetInt");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CASHDLC_SetBool;
    /// <summary>
    /// Function: CASHDLC_SetBool
    /// </summary>
    public unsafe virtual void CASHDLC_SetBool(int Index, bool Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CASHDLC_SetBool, "Engine.Actor.CASHDLC_SetBool");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CASHDLC_GetBool;
    /// <summary>
    /// Function: CASHDLC_GetBool
    /// </summary>
    public unsafe virtual bool CASHDLC_GetBool(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CASHDLC_GetBool, "Engine.Actor.CASHDLC_GetBool");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetOverrideActualEventActor;
    /// <summary>
    /// Function: GetOverrideActualEventActor
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor GetOverrideActualEventActor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOverrideActualEventActor, "Engine.Actor.GetOverrideActualEventActor");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IssueStartAudioEventCallback;
    /// <summary>
    /// Function: IssueStartAudioEventCallback
    /// </summary>
    public unsafe virtual void IssueStartAudioEventCallback(BmSDK.Engine.AkEvent AudioEvent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IssueStartAudioEventCallback, "Engine.Actor.IssueStartAudioEventCallback");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AudioEvent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBasePawn;
    /// <summary>
    /// Function: CanBasePawn
    /// </summary>
    public unsafe virtual bool CanBasePawn(BmSDK.Engine.Pawn P)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBasePawn, "Engine.Actor.CanBasePawn");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CASHDLC_Native;
    /// <summary>
    /// Function: CASHDLC_Native
    /// </summary>
    public unsafe virtual int CASHDLC_Native(int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CASHDLC_Native, "Engine.Actor.CASHDLC_Native");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
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

    private static BmSDK.Function __fn_CancelAudioCallbacks;
    /// <summary>
    /// Function: CancelAudioCallbacks
    /// </summary>
    public unsafe static void CancelAudioCallbacks()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelAudioCallbacks, "Engine.Actor.CancelAudioCallbacks");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_SetGlobalAudioState;
    /// <summary>
    /// Function: SetGlobalAudioState
    /// </summary>
    public unsafe static void SetGlobalAudioState(BmSDK.Engine.AkStateName StateName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGlobalAudioState, "Engine.Actor.SetGlobalAudioState");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGlobalAudioParameter;
    /// <summary>
    /// Function: SetGlobalAudioParameter
    /// </summary>
    public unsafe static void SetGlobalAudioParameter(BmSDK.Engine.AkParameterName ParamName, float ParamValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGlobalAudioParameter, "Engine.Actor.SetGlobalAudioParameter");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParamName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParamValue, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartGlobalAudioEvent;
    /// <summary>
    /// Function: StartGlobalAudioEvent
    /// </summary>
    public unsafe static BmSDK.Engine.AkWwise.FAkSoundHandle StartGlobalAudioEvent(BmSDK.Engine.AkEvent AudioEvent, BmSDK.Engine.AkWwise.EGlobalAudioSourceID GlobalSource, System.IntPtr SoundCallbackDelegate = default, int SoundCallbackFlags = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartGlobalAudioEvent, "Engine.Actor.StartGlobalAudioEvent");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AudioEvent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GlobalSource, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundCallbackDelegate, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundCallbackFlags, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkWwise.FAkSoundHandle>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetAudioThoughts;
    /// <summary>
    /// Function: GetAudioThoughts
    /// </summary>
    public unsafe virtual bool GetAudioThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList, out System.Numerics.Vector3 ThoughtLocation, BmSDK.Engine.AkComponent akComp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAudioThoughts, "Engine.Actor.GetAudioThoughts");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ThoughtLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThoughtLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(akComp, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        ThoughtLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_EvaluateAudioActivation;
    /// <summary>
    /// Function: EvaluateAudioActivation
    /// </summary>
    public unsafe virtual float EvaluateAudioActivation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EvaluateAudioActivation, "Engine.Actor.EvaluateAudioActivation");
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

    private static BmSDK.Function __fn_GetAudioSpatial;
    /// <summary>
    /// Function: GetAudioSpatial
    /// </summary>
    public unsafe virtual void GetAudioSpatial(BmSDK.Engine.AkComponent akComp, out System.Numerics.Vector3 SoundPosition, out BmSDK.Rotator SoundOrientation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAudioSpatial, "Engine.Actor.GetAudioSpatial");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(akComp, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SoundPosition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundPosition, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SoundOrientation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundOrientation, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        SoundPosition = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
        SoundOrientation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_OnAudioDebugRender;
    /// <summary>
    /// Function: OnAudioDebugRender
    /// </summary>
    public unsafe virtual void OnAudioDebugRender(BmSDK.Engine.AkComponent akComp, bool DebugCulled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAudioDebugRender, "Engine.Actor.OnAudioDebugRender");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(akComp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DebugCulled, paramsPtr + 4);
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

    private static BmSDK.Function __fn_OnAudioTick;
    /// <summary>
    /// Function: OnAudioTick
    /// </summary>
    public unsafe virtual void OnAudioTick(BmSDK.Engine.AkComponent akComp, float TimeDelta)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAudioTick, "Engine.Actor.OnAudioTick");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(akComp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeDelta, paramsPtr + 4);
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

    private static BmSDK.Function __fn_OnAudioSourceDestroy;
    /// <summary>
    /// Function: OnAudioSourceDestroy
    /// </summary>
    public unsafe virtual void OnAudioSourceDestroy(BmSDK.Engine.AkComponent akComp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAudioSourceDestroy, "Engine.Actor.OnAudioSourceDestroy");
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

    private static BmSDK.Function __fn_OnAudioSourceCreate;
    /// <summary>
    /// Function: OnAudioSourceCreate
    /// </summary>
    public unsafe virtual void OnAudioSourceCreate(BmSDK.Engine.AkComponent akComp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAudioSourceCreate, "Engine.Actor.OnAudioSourceCreate");
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

    private static BmSDK.Function __fn_SetAudioEnvironment;
    /// <summary>
    /// Function: SetAudioEnvironment
    /// </summary>
    public unsafe virtual bool SetAudioEnvironment(BmSDK.TArray<BmSDK.Engine.AkWwise.FAkEnvironmentSettings> Environments, bool EnableEnvironments, float OcclusionMultiplier = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAudioEnvironment, "Engine.Actor.SetAudioEnvironment");
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

    private static BmSDK.Function __fn_SetAudioSwitch;
    /// <summary>
    /// Function: SetAudioSwitch
    /// </summary>
    public unsafe virtual void SetAudioSwitch(BmSDK.Engine.AkSwitchName SwitchName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAudioSwitch, "Engine.Actor.SetAudioSwitch");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SwitchName, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetStickyAudioParameterEx;
    /// <summary>
    /// Function: SetStickyAudioParameterEx
    /// </summary>
    public unsafe virtual void SetStickyAudioParameterEx(BmSDK.Engine.AkParameterName ParamName, float ParamValue, float NewReleaseValue, float NewReleaseTime, float NewSustainTime, float NewAttackTime, bool AllowPause)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetStickyAudioParameterEx, "Engine.Actor.SetStickyAudioParameterEx");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParamName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParamValue, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewReleaseValue, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewReleaseTime, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSustainTime, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttackTime, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AllowPause, paramsPtr + 24);
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

    private static BmSDK.Function __fn_SetStickyAudioParameter;
    /// <summary>
    /// Function: SetStickyAudioParameter
    /// </summary>
    public unsafe virtual void SetStickyAudioParameter(BmSDK.Engine.AkParameterName ParamName, float ParamValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetStickyAudioParameter, "Engine.Actor.SetStickyAudioParameter");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParamName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParamValue, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SetAudioParameter;
    /// <summary>
    /// Function: SetAudioParameter
    /// </summary>
    public unsafe virtual void SetAudioParameter(BmSDK.Engine.AkParameterName ParamName, float ParamValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAudioParameter, "Engine.Actor.SetAudioParameter");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParamName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParamValue, paramsPtr + 4);
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

    private static BmSDK.Function __fn_StopLoopingEvent;
    /// <summary>
    /// Function: StopLoopingEvent
    /// </summary>
    public unsafe virtual void StopLoopingEvent(out BmSDK.Engine.AkWwise.FAkSoundLoop SoundLoop, bool QuickStop = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopLoopingEvent, "Engine.Actor.StopLoopingEvent");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SoundLoop);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundLoop, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QuickStop, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        SoundLoop = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkWwise.FAkSoundLoop>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_StartLoopingEvent;
    /// <summary>
    /// Function: StartLoopingEvent
    /// </summary>
    public unsafe virtual bool StartLoopingEvent(out BmSDK.Engine.AkWwise.FAkSoundLoop SoundLoop, System.IntPtr SoundCallbackDelegate = default, int SoundCallbackFlags = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartLoopingEvent, "Engine.Actor.StartLoopingEvent");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SoundLoop);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundLoop, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundCallbackDelegate, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundCallbackFlags, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        SoundLoop = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkWwise.FAkSoundLoop>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_IsSoundHandleValid;
    /// <summary>
    /// Function: IsSoundHandleValid
    /// </summary>
    public unsafe virtual bool IsSoundHandleValid(out BmSDK.Engine.AkWwise.FAkSoundHandle SoundHandleToTest)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSoundHandleValid, "Engine.Actor.IsSoundHandleValid");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SoundHandleToTest);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundHandleToTest, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        SoundHandleToTest = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkWwise.FAkSoundHandle>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_StopAudioEvent;
    /// <summary>
    /// Function: StopAudioEvent
    /// </summary>
    public unsafe virtual void StopAudioEvent(out BmSDK.Engine.AkWwise.FAkSoundHandle SoundHandle, bool QuickStop = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAudioEvent, "Engine.Actor.StopAudioEvent");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SoundHandle);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundHandle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QuickStop, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        SoundHandle = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkWwise.FAkSoundHandle>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_StartAuxAudioEvent;
    /// <summary>
    /// Function: StartAuxAudioEvent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkWwise.FAkSoundHandle StartAuxAudioEvent(BmSDK.Engine.AkEvent AudioEvent, System.Numerics.Vector3 Position, System.IntPtr SoundCallbackDelegate = default, int SoundCallbackFlags = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAuxAudioEvent, "Engine.Actor.StartAuxAudioEvent");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AudioEvent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundCallbackDelegate, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundCallbackFlags, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkWwise.FAkSoundHandle>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_StartAudioEvent;
    /// <summary>
    /// Function: StartAudioEvent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkWwise.FAkSoundHandle StartAudioEvent(BmSDK.Engine.AkEvent AudioEvent, System.IntPtr SoundCallbackDelegate = default, int SoundCallbackFlags = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartAudioEvent, "Engine.Actor.StartAudioEvent");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AudioEvent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundCallbackDelegate, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundCallbackFlags, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkWwise.FAkSoundHandle>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_OverrideAkComponentDefaults;
    /// <summary>
    /// Function: OverrideAkComponentDefaults
    /// </summary>
    public unsafe virtual void OverrideAkComponentDefaults(BmSDK.Engine.AkComponent akComp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideAkComponentDefaults, "Engine.Actor.OverrideAkComponentDefaults");
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

    private static BmSDK.Function __fn_AttachNewAkComponent;
    /// <summary>
    /// Function: AttachNewAkComponent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkComponent AttachNewAkComponent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachNewAkComponent, "Engine.Actor.AttachNewAkComponent");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkComponent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAllAkComponents;
    /// <summary>
    /// Function: GetAllAkComponents
    /// </summary>
    public unsafe virtual void GetAllAkComponents(out BmSDK.TArray<BmSDK.Engine.AkComponent> akComps)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAllAkComponents, "Engine.Actor.GetAllAkComponents");
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
        akComps = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.AkComponent>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetAkComponent;
    /// <summary>
    /// Function: GetAkComponent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkComponent GetAkComponent(bool AllowCreate = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAkComponent, "Engine.Actor.GetAkComponent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AllowCreate, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkComponent>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ShouldContinueSurveillance;
    /// <summary>
    /// Function: ShouldContinueSurveillance
    /// </summary>
    public unsafe virtual bool ShouldContinueSurveillance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldContinueSurveillance, "Engine.Actor.ShouldContinueSurveillance");
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

    private static BmSDK.Function __fn_ShouldBeHiddenBySHOW_NavigationNodes;
    /// <summary>
    /// Function: ShouldBeHiddenBySHOW_NavigationNodes
    /// </summary>
    public unsafe virtual bool ShouldBeHiddenBySHOW_NavigationNodes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldBeHiddenBySHOW_NavigationNodes, "Engine.Actor.ShouldBeHiddenBySHOW_NavigationNodes");
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

    private static BmSDK.Function __fn_WillOverlap;
    /// <summary>
    /// Function: WillOverlap
    /// </summary>
    public unsafe virtual bool WillOverlap(System.Numerics.Vector3 PosA, System.Numerics.Vector3 VelA, System.Numerics.Vector3 PosB, System.Numerics.Vector3 VelB, float StepSize, float Radius, out float Time)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WillOverlap, "Engine.Actor.WillOverlap");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PosA, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VelA, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PosB, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VelB, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StepSize, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 52);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Time);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 56);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Time = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 56);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 60);
    }

    private static BmSDK.Function __fn_GetAvoidanceVector;
    /// <summary>
    /// Function: GetAvoidanceVector
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAvoidanceVector(in BmSDK.TArray<BmSDK.Engine.Actor> Obstacles, System.Numerics.Vector3 GoalLocation, float CollisionRadius, float MaxSpeed, int NumSamples = default, float VelocityStepRate = default, float MaxTimeTilOverlap = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAvoidanceVector, "Engine.Actor.GetAvoidanceVector");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Obstacles, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GoalLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionRadius, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxSpeed, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumSamples, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VelocityStepRate, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxTimeTilOverlap, paramsPtr + 40);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_IsClient;
    /// <summary>
    /// Function: IsClient
    /// </summary>
    public unsafe virtual bool IsClient()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsClient, "Engine.Actor.IsClient");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsServer;
    /// <summary>
    /// Function: IsServer
    /// </summary>
    public unsafe virtual bool IsServer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsServer, "Engine.Actor.IsServer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsOwningClient;
    /// <summary>
    /// Function: IsOwningClient
    /// </summary>
    public unsafe virtual bool IsOwningClient()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsOwningClient, "Engine.Actor.IsOwningClient");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ReplicationEnded;
    /// <summary>
    /// Function: ReplicationEnded
    /// </summary>
    public unsafe virtual void ReplicationEnded()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplicationEnded, "Engine.Actor.ReplicationEnded");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInvestigateHighlighted;
    /// <summary>
    /// Function: SetInvestigateHighlighted
    /// </summary>
    public unsafe virtual void SetInvestigateHighlighted(BmSDK.Engine.MaterialInstanceConstant highMat, bool On)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInvestigateHighlighted, "Engine.Actor.SetInvestigateHighlighted");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(highMat, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostDemoRewind;
    /// <summary>
    /// Function: PostDemoRewind
    /// </summary>
    public unsafe virtual void PostDemoRewind()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostDemoRewind, "Engine.Actor.PostDemoRewind");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AnimTreeUpdated;
    /// <summary>
    /// Function: AnimTreeUpdated
    /// </summary>
    public unsafe virtual void AnimTreeUpdated(BmSDK.Engine.SkeletalMeshComponent SkelMesh)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnimTreeUpdated, "Engine.Actor.AnimTreeUpdated");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelMesh, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SupportsKismetModification;
    /// <summary>
    /// Function: SupportsKismetModification
    /// </summary>
    public unsafe virtual bool SupportsKismetModification(BmSDK.Engine.SequenceOp AskingOp, out BmSDK.FString Reason)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SupportsKismetModification, "Engine.Actor.SupportsKismetModification");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AskingOp, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Reason = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CreateForceField;
    /// <summary>
    /// Function: CreateForceField
    /// </summary>
    public unsafe virtual bool CreateForceField(BmSDK.Engine.AnimNotify_ForceField AnimNotifyData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateForceField, "Engine.Actor.CreateForceField");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimNotifyData, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PlayParticleEffect;
    /// <summary>
    /// Function: PlayParticleEffect
    /// </summary>
    public unsafe virtual bool PlayParticleEffect(BmSDK.Engine.AnimNotify_PlayParticleEffect AnimNotifyData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayParticleEffect, "Engine.Actor.PlayParticleEffect");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimNotifyData, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsInPersistentLevel;
    /// <summary>
    /// Function: IsInPersistentLevel
    /// </summary>
    public unsafe virtual bool IsInPersistentLevel(bool bIncludeLevelStreamingPersistent = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInPersistentLevel, "Engine.Actor.IsInPersistentLevel");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIncludeLevelStreamingPersistent, paramsPtr + 0);
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

    private static BmSDK.Function __fn_OnRigidBodySpringOverextension;
    /// <summary>
    /// Function: OnRigidBodySpringOverextension
    /// </summary>
    public unsafe virtual void OnRigidBodySpringOverextension(BmSDK.Engine.RB_BodyInstance BodyInstance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRigidBodySpringOverextension, "Engine.Actor.OnRigidBodySpringOverextension");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BodyInstance, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPackageGuid;
    /// <summary>
    /// Function: GetPackageGuid
    /// </summary>
    public unsafe static BmSDK.GameObject.FGuid GetPackageGuid(BmSDK.FName PackageName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPackageGuid, "Engine.Actor.GetPackageGuid");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FGuid>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PostEditChangeScript;
    /// <summary>
    /// Function: PostEditChangeScript
    /// </summary>
    public unsafe virtual void PostEditChangeScript()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostEditChangeScript, "Engine.Actor.PostEditChangeScript");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlinkToActor;
    /// <summary>
    /// Function: UnlinkToActor
    /// </summary>
    public unsafe virtual bool UnlinkToActor(BmSDK.Engine.Actor LinkTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlinkToActor, "Engine.Actor.UnlinkToActor");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_LinkToActor;
    /// <summary>
    /// Function: LinkToActor
    /// </summary>
    public unsafe virtual bool LinkToActor(BmSDK.Engine.Actor LinkTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LinkToActor, "Engine.Actor.LinkToActor");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PreStreamOut;
    /// <summary>
    /// Function: PreStreamOut
    /// </summary>
    public unsafe virtual void PreStreamOut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "Engine.Actor.PreStreamOut");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostInitAnimTree;
    /// <summary>
    /// Function: PostInitAnimTree
    /// </summary>
    public unsafe virtual void PostInitAnimTree(BmSDK.Engine.SkeletalMeshComponent SkelComp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostInitAnimTree, "Engine.Actor.PostInitAnimTree");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelComp, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RootMotionExtracted;
    /// <summary>
    /// Function: RootMotionExtracted
    /// </summary>
    public unsafe virtual void RootMotionExtracted(BmSDK.Engine.SkeletalMeshComponent SkelComp, out BmSDK.GameObject.FBoneAtom ExtractedRootMotionDelta)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RootMotionExtracted, "Engine.Actor.RootMotionExtracted");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelComp, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ExtractedRootMotionDelta);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtractedRootMotionDelta, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ExtractedRootMotionDelta = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FBoneAtom>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_RootMotionModeChanged;
    /// <summary>
    /// Function: RootMotionModeChanged
    /// </summary>
    public unsafe virtual void RootMotionModeChanged(BmSDK.Engine.SkeletalMeshComponent SkelComp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RootMotionModeChanged, "Engine.Actor.RootMotionModeChanged");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelComp, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostRenderFor;
    /// <summary>
    /// Function: PostRenderFor
    /// </summary>
    public unsafe virtual void PostRenderFor(BmSDK.Engine.PlayerController PC, BmSDK.Engine.Canvas Canvas, System.Numerics.Vector3 CameraPosition, System.Numerics.Vector3 CameraDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostRenderFor, "Engine.Actor.PostRenderFor");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraPosition, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraDir, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NativePostRenderFor;
    /// <summary>
    /// Function: NativePostRenderFor
    /// </summary>
    public unsafe virtual void NativePostRenderFor(BmSDK.Engine.PlayerController PC, BmSDK.Engine.Canvas Canvas, System.Numerics.Vector3 CameraPosition, System.Numerics.Vector3 CameraDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NativePostRenderFor, "Engine.Actor.NativePostRenderFor");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraPosition, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraDir, paramsPtr + 20);
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

    private static BmSDK.Function __fn_SetHUDLocation;
    /// <summary>
    /// Function: SetHUDLocation
    /// </summary>
    public unsafe virtual void SetHUDLocation(System.Numerics.Vector3 NewHUDLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHUDLocation, "Engine.Actor.SetHUDLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewHUDLocation, paramsPtr + 0);
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

    private static BmSDK.Function __fn_RigidBodyCollision;
    /// <summary>
    /// Function: RigidBodyCollision
    /// </summary>
    public unsafe virtual void RigidBodyCollision(BmSDK.Engine.PrimitiveComponent HitComponent, BmSDK.Engine.PrimitiveComponent OtherComponent, in BmSDK.Engine.Actor.FCollisionImpactData RigidCollisionData, int ContactIndex, float Speed, int Index0, int Index1)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RigidBodyCollision, "Engine.Actor.RigidBodyCollision");
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

    private static BmSDK.Function __fn_InterpolationChanged;
    /// <summary>
    /// Function: InterpolationChanged
    /// </summary>
    public unsafe virtual void InterpolationChanged(BmSDK.Engine.SeqAct_Interp InterpAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InterpolationChanged, "Engine.Actor.InterpolationChanged");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterpAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InterpolationFinished;
    /// <summary>
    /// Function: InterpolationFinished
    /// </summary>
    public unsafe virtual void InterpolationFinished(BmSDK.Engine.SeqAct_Interp InterpAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InterpolationFinished, "Engine.Actor.InterpolationFinished");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterpAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InterpolationStarted;
    /// <summary>
    /// Function: InterpolationStarted
    /// </summary>
    public unsafe virtual void InterpolationStarted(BmSDK.Engine.SeqAct_Interp InterpAction, BmSDK.Engine.InterpGroupInst GroupInst)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InterpolationStarted, "Engine.Actor.InterpolationStarted");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterpAction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GroupInst, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnedByKismet;
    /// <summary>
    /// Function: SpawnedByKismet
    /// </summary>
    public unsafe virtual void SpawnedByKismet()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnedByKismet, "Engine.Actor.SpawnedByKismet");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetFOVCheckLocation;
    /// <summary>
    /// Function: GetFOVCheckLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetFOVCheckLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFOVCheckLocation, "Engine.Actor.GetFOVCheckLocation");
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

    private static BmSDK.Function __fn_GetTargetLocation;
    /// <summary>
    /// Function: GetTargetLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetTargetLocation(BmSDK.Engine.Actor RequestedBy = default, bool bRequestAlternateLoc = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTargetLocation, "Engine.Actor.GetTargetLocation");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequestedBy, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRequestAlternateLoc, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FindGoodEndView;
    /// <summary>
    /// Function: FindGoodEndView
    /// </summary>
    public unsafe virtual void FindGoodEndView(BmSDK.Engine.PlayerController PC, out BmSDK.Rotator GoodRotation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindGoodEndView, "Engine.Actor.FindGoodEndView");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out GoodRotation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GoodRotation, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        GoodRotation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_NotifyLocalPlayerTeamReceived;
    /// <summary>
    /// Function: NotifyLocalPlayerTeamReceived
    /// </summary>
    public unsafe virtual void NotifyLocalPlayerTeamReceived()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyLocalPlayerTeamReceived, "Engine.Actor.NotifyLocalPlayerTeamReceived");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ScriptGetTeamNum;
    /// <summary>
    /// Function: ScriptGetTeamNum
    /// </summary>
    public unsafe virtual byte ScriptGetTeamNum()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScriptGetTeamNum, "Engine.Actor.ScriptGetTeamNum");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTeamNum;
    /// <summary>
    /// Function: GetTeamNum
    /// </summary>
    public unsafe virtual byte GetTeamNum()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTeamNum, "Engine.Actor.GetTeamNum");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PawnBaseDied;
    /// <summary>
    /// Function: PawnBaseDied
    /// </summary>
    public unsafe virtual void PawnBaseDied()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnBaseDied, "Engine.Actor.PawnBaseDied");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPlayerOwned;
    /// <summary>
    /// Function: IsPlayerOwned
    /// </summary>
    public unsafe virtual bool IsPlayerOwned()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPlayerOwned, "Engine.Actor.IsPlayerOwned");
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

    private static BmSDK.Function __fn_GetActorEyesViewPoint;
    /// <summary>
    /// Function: GetActorEyesViewPoint
    /// </summary>
    public unsafe virtual void GetActorEyesViewPoint(out System.Numerics.Vector3 out_Location, out BmSDK.Rotator out_Rotation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActorEyesViewPoint, "Engine.Actor.GetActorEyesViewPoint");
        byte* paramsPtr = stackalloc byte[40];
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

    private static BmSDK.Function __fn_GetActorFaceFXAsset;
    /// <summary>
    /// Function: GetActorFaceFXAsset
    /// </summary>
    public unsafe virtual BmSDK.Engine.FaceFXAsset GetActorFaceFXAsset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActorFaceFXAsset, "Engine.Actor.GetActorFaceFXAsset");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.FaceFXAsset>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanActorPlayFaceFXAnim;
    /// <summary>
    /// Function: CanActorPlayFaceFXAnim
    /// </summary>
    public unsafe virtual bool CanActorPlayFaceFXAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanActorPlayFaceFXAnim, "Engine.Actor.CanActorPlayFaceFXAnim");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsActorPlayingFaceFXAnim;
    /// <summary>
    /// Function: IsActorPlayingFaceFXAnim
    /// </summary>
    public unsafe virtual bool IsActorPlayingFaceFXAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsActorPlayingFaceFXAnim, "Engine.Actor.IsActorPlayingFaceFXAnim");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetSkelControlScale;
    /// <summary>
    /// Function: SetSkelControlScale
    /// </summary>
    public unsafe virtual void SetSkelControlScale(BmSDK.FName SkelControlName, float Scale)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSkelControlScale, "Engine.Actor.SetSkelControlScale");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelControlName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scale, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMorphWeight;
    /// <summary>
    /// Function: SetMorphWeight
    /// </summary>
    public unsafe virtual void SetMorphWeight(BmSDK.FName MorphNodeName, float MorphWeight)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMorphWeight, "Engine.Actor.SetMorphWeight");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MorphNodeName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MorphWeight, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MatineeSetFaceFXRegister;
    /// <summary>
    /// Function: MatineeSetFaceFXRegister
    /// </summary>
    public unsafe virtual void MatineeSetFaceFXRegister(BmSDK.FString RegisterName, float Value, BmSDK.Engine.RSkeletalMeshComponent_Export.EFaceFXRegisterOwner RegisterOwner)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MatineeSetFaceFXRegister, "Engine.Actor.MatineeSetFaceFXRegister");
        byte* paramsPtr = stackalloc byte[33];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RegisterName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RegisterOwner, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopActorFaceFXAnim;
    /// <summary>
    /// Function: StopActorFaceFXAnim
    /// </summary>
    public unsafe virtual void StopActorFaceFXAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopActorFaceFXAnim, "Engine.Actor.StopActorFaceFXAnim");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayActorFaceFXAnim;
    /// <summary>
    /// Function: PlayActorFaceFXAnim
    /// </summary>
    public unsafe virtual bool PlayActorFaceFXAnim(BmSDK.Engine.FaceFXAnimSet AnimSet, BmSDK.FString GroupName, BmSDK.FString SeqName, BmSDK.Engine.RDialogueEvent DialogueEvent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayActorFaceFXAnim, "Engine.Actor.PlayActorFaceFXAnim");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GroupName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SeqName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueEvent, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_EndMatineeControl;
    /// <summary>
    /// Function: EndMatineeControl
    /// </summary>
    public unsafe virtual void EndMatineeControl(BmSDK.Engine.InterpGroup InInterpGroup)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndMatineeControl, "Engine.Actor.EndMatineeControl");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeginMatineeControl;
    /// <summary>
    /// Function: BeginMatineeControl
    /// </summary>
    public unsafe virtual void BeginMatineeControl(BmSDK.Engine.InterpGroup InInterpGroup)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginMatineeControl, "Engine.Actor.BeginMatineeControl");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishAnimControl;
    /// <summary>
    /// Function: FinishAnimControl
    /// </summary>
    public unsafe virtual void FinishAnimControl(BmSDK.Engine.InterpGroup InInterpGroup)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishAnimControl, "Engine.Actor.FinishAnimControl");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BlendOutAnimControl;
    /// <summary>
    /// Function: BlendOutAnimControl
    /// </summary>
    public unsafe virtual void BlendOutAnimControl(BmSDK.Engine.InterpGroup InInterpGroup)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlendOutAnimControl, "Engine.Actor.BlendOutAnimControl");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MatineeAnimTeleport;
    /// <summary>
    /// Function: MatineeAnimTeleport
    /// </summary>
    public unsafe virtual void MatineeAnimTeleport()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MatineeAnimTeleport, "Engine.Actor.MatineeAnimTeleport");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAnimPosition;
    /// <summary>
    /// Function: SetAnimPosition
    /// </summary>
    public unsafe virtual void SetAnimPosition(BmSDK.FName SlotName, int ChannelIndex, BmSDK.FName InAnimSeqName, float InPosition, bool bFireNotifies, bool bLooping, bool bEnableRootMotion)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAnimPosition, "Engine.Actor.SetAnimPosition");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChannelIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InAnimSeqName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPosition, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFireNotifies, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLooping, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableRootMotion, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeginAnimControl;
    /// <summary>
    /// Function: BeginAnimControl
    /// </summary>
    public unsafe virtual void BeginAnimControl(BmSDK.Engine.InterpGroup InInterpGroup)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginAnimControl, "Engine.Actor.BeginAnimControl");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnAnimPlay;
    /// <summary>
    /// Function: OnAnimPlay
    /// </summary>
    public unsafe virtual void OnAnimPlay(BmSDK.Engine.AnimNodeSequence SeqNode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAnimPlay, "Engine.Actor.OnAnimPlay");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SeqNode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnAnimEnd;
    /// <summary>
    /// Function: OnAnimEnd
    /// </summary>
    public unsafe virtual void OnAnimEnd(BmSDK.Engine.AnimNodeSequence SeqNode, float PlayedTime, float ExcessTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAnimEnd, "Engine.Actor.OnAnimEnd");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SeqNode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayedTime, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExcessTime, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoKismetAttachment;
    /// <summary>
    /// Function: DoKismetAttachment
    /// </summary>
    public unsafe virtual void DoKismetAttachment(BmSDK.Engine.Actor Attachment, BmSDK.Engine.SeqAct_AttachToActor Action)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoKismetAttachment, "Engine.Actor.DoKismetAttachment");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attachment, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnAttachToActor;
    /// <summary>
    /// Function: OnAttachToActor
    /// </summary>
    public unsafe virtual void OnAttachToActor(BmSDK.Engine.SeqAct_AttachToActor Action)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnAttachToActor, "Engine.Actor.OnAttachToActor");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnToggleHidden;
    /// <summary>
    /// Function: OnToggleHidden
    /// </summary>
    public unsafe virtual void OnToggleHidden(BmSDK.Engine.SeqAct_ToggleHidden Action)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnToggleHidden, "Engine.Actor.OnToggleHidden");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnChangeCollision;
    /// <summary>
    /// Function: OnChangeCollision
    /// </summary>
    public unsafe virtual void OnChangeCollision(BmSDK.Engine.SeqAct_ChangeCollision Action)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnChangeCollision, "Engine.Actor.OnChangeCollision");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnSetPhysics;
    /// <summary>
    /// Function: OnSetPhysics
    /// </summary>
    public unsafe virtual void OnSetPhysics(BmSDK.Engine.SeqAct_SetPhysics Action)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSetPhysics, "Engine.Actor.OnSetPhysics");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnSetBlockRigidBody;
    /// <summary>
    /// Function: OnSetBlockRigidBody
    /// </summary>
    public unsafe virtual void OnSetBlockRigidBody(BmSDK.Engine.SeqAct_SetBlockRigidBody Action)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSetBlockRigidBody, "Engine.Actor.OnSetBlockRigidBody");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnSetVelocity;
    /// <summary>
    /// Function: OnSetVelocity
    /// </summary>
    public unsafe virtual void OnSetVelocity(BmSDK.Engine.SeqAct_SetVelocity Action)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSetVelocity, "Engine.Actor.OnSetVelocity");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnTeleport;
    /// <summary>
    /// Function: OnTeleport
    /// </summary>
    public unsafe virtual void OnTeleport(BmSDK.Engine.SeqAct_Teleport Action)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnTeleport, "Engine.Actor.OnTeleport");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnModifyHealth;
    /// <summary>
    /// Function: OnModifyHealth
    /// </summary>
    public unsafe virtual void OnModifyHealth(BmSDK.Engine.SeqAct_ModifyHealth Action)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnModifyHealth, "Engine.Actor.OnModifyHealth");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PrestreamTextures;
    /// <summary>
    /// Function: PrestreamTextures
    /// </summary>
    public unsafe virtual void PrestreamTextures(float Seconds, bool bEnableStreaming, int CinematicTextureGroups = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrestreamTextures, "Engine.Actor.PrestreamTextures");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Seconds, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableStreaming, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CinematicTextureGroups, paramsPtr + 8);
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

    private static BmSDK.Function __fn_ShutDown;
    /// <summary>
    /// Function: ShutDown
    /// </summary>
    public unsafe virtual void ShutDown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShutDown, "Engine.Actor.ShutDown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNetUpdateTime;
    /// <summary>
    /// Function: SetNetUpdateTime
    /// </summary>
    public unsafe virtual void SetNetUpdateTime(float NewUpdateTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNetUpdateTime, "Engine.Actor.SetNetUpdateTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewUpdateTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ForceNetRelevant;
    /// <summary>
    /// Function: ForceNetRelevant
    /// </summary>
    public unsafe virtual void ForceNetRelevant()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceNetRelevant, "Engine.Actor.ForceNetRelevant");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnDestroy;
    /// <summary>
    /// Function: OnDestroy
    /// </summary>
    public unsafe virtual void OnDestroy(BmSDK.Engine.SeqAct_Destroy Action)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDestroy, "Engine.Actor.OnDestroy");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindEventsOfClass;
    /// <summary>
    /// Function: FindEventsOfClass
    /// </summary>
    public unsafe virtual bool FindEventsOfClass(BmSDK.Class EventClass, out BmSDK.TArray<BmSDK.Engine.SequenceEvent> out_EventList, bool bIncludeDisabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindEventsOfClass, "Engine.Actor.FindEventsOfClass");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIncludeDisabled, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_EventList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.SequenceEvent>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ActivateEventClass;
    /// <summary>
    /// Function: ActivateEventClass
    /// </summary>
    public unsafe virtual bool ActivateEventClass(BmSDK.Class InClass, BmSDK.Engine.Actor InInstigator, in BmSDK.TArray<BmSDK.Engine.SequenceEvent> EventList, in BmSDK.TArray<int> ActivateIndices, bool bTest, out BmSDK.TArray<BmSDK.Engine.SequenceEvent> ActivatedEvents)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateEventClass, "Engine.Actor.ActivateEventClass");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInstigator, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventList, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActivateIndices, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTest, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ActivatedEvents = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.SequenceEvent>>(paramsPtr + 36);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_TriggerGlobalEventClass;
    /// <summary>
    /// Function: TriggerGlobalEventClass
    /// </summary>
    public unsafe virtual bool TriggerGlobalEventClass(BmSDK.Class InEventClass, BmSDK.Engine.Actor InInstigator, int ActivateIndex = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerGlobalEventClass, "Engine.Actor.TriggerGlobalEventClass");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InEventClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInstigator, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActivateIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ReceivedNewEvent;
    /// <summary>
    /// Function: ReceivedNewEvent
    /// </summary>
    public unsafe virtual void ReceivedNewEvent(BmSDK.Engine.SequenceEvent Evt)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReceivedNewEvent, "Engine.Actor.ReceivedNewEvent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Evt, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerEventClass;
    /// <summary>
    /// Function: TriggerEventClass
    /// </summary>
    public unsafe virtual bool TriggerEventClass(BmSDK.Class InEventClass, BmSDK.Engine.Actor InInstigator, int ActivateIndex, bool bTest, out BmSDK.TArray<BmSDK.Engine.SequenceEvent> ActivatedEvents)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerEventClass, "Engine.Actor.TriggerEventClass");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InEventClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInstigator, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActivateIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTest, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ActivatedEvents = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.SequenceEvent>>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_ApplyFluidSurfaceImpact;
    /// <summary>
    /// Function: ApplyFluidSurfaceImpact
    /// </summary>
    public unsafe virtual void ApplyFluidSurfaceImpact(BmSDK.Engine.FluidSurfaceActor Fluid, System.Numerics.Vector3 HitLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyFluidSurfaceImpact, "Engine.Actor.ApplyFluidSurfaceImpact");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fluid, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanSplash;
    /// <summary>
    /// Function: CanSplash
    /// </summary>
    public unsafe virtual bool CanSplash()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSplash, "Engine.Actor.CanSplash");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayTeleportEffect;
    /// <summary>
    /// Function: PlayTeleportEffect
    /// </summary>
    public unsafe virtual void PlayTeleportEffect(bool bOut, bool bSound)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayTeleportEffect, "Engine.Actor.PlayTeleportEffect");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOut, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSound, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsInVolume;
    /// <summary>
    /// Function: IsInVolume
    /// </summary>
    public unsafe virtual bool IsInVolume(BmSDK.Engine.Volume aVolume)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInVolume, "Engine.Actor.IsInVolume");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aVolume, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_Reset;
    /// <summary>
    /// Function: Reset
    /// </summary>
    public unsafe virtual void Reset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Reset, "Engine.Actor.Reset");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ModifyHearSoundComponent;
    /// <summary>
    /// Function: ModifyHearSoundComponent
    /// </summary>
    public unsafe virtual void ModifyHearSoundComponent(BmSDK.Engine.AudioComponent AC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyHearSoundComponent, "Engine.Actor.ModifyHearSoundComponent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPhysicsName;
    /// <summary>
    /// Function: GetPhysicsName
    /// </summary>
    public unsafe virtual BmSDK.FString GetPhysicsName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPhysicsName, "Engine.Actor.GetPhysicsName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetActorThoughts;
    /// <summary>
    /// Function: GetActorThoughts
    /// </summary>
    public unsafe virtual void GetActorThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList, out System.Numerics.Vector3 ThoughtLocationOverride, BmSDK.FString IndentString = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActorThoughts, "Engine.Actor.GetActorThoughts");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ThoughtLocationOverride);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThoughtLocationOverride, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IndentString, paramsPtr + 24);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        ThoughtLocationOverride = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_DisplayDebug;
    /// <summary>
    /// Function: DisplayDebug
    /// </summary>
    public unsafe virtual void DisplayDebug(BmSDK.Engine.HUD HUD, out float out_YL, out float out_YPos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayDebug, "Engine.Actor.DisplayDebug");
        byte* paramsPtr = stackalloc byte[56];
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

    private static BmSDK.Function __fn_GetDebugName;
    /// <summary>
    /// Function: GetDebugName
    /// </summary>
    public unsafe virtual BmSDK.FString GetDebugName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDebugName, "Engine.Actor.GetDebugName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_MatchStarting;
    /// <summary>
    /// Function: MatchStarting
    /// </summary>
    public unsafe virtual void MatchStarting()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MatchStarting, "Engine.Actor.MatchStarting");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetLocalString;
    /// <summary>
    /// Function: GetLocalString
    /// </summary>
    public unsafe static BmSDK.FString GetLocalString(int Switch = default, BmSDK.Engine.PlayerReplicationInfo RelatedPRI_1 = default, BmSDK.Engine.PlayerReplicationInfo RelatedPRI_2 = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocalString, "Engine.Actor.GetLocalString");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Switch, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RelatedPRI_1, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RelatedPRI_2, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetHumanReadableName;
    /// <summary>
    /// Function: GetHumanReadableName
    /// </summary>
    public unsafe virtual BmSDK.FString GetHumanReadableName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHumanReadableName, "Engine.Actor.GetHumanReadableName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetItemName;
    /// <summary>
    /// Function: GetItemName
    /// </summary>
    public unsafe virtual BmSDK.FString GetItemName(BmSDK.FString FullName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetItemName, "Engine.Actor.GetItemName");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FullName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CalcCamera;
    /// <summary>
    /// Function: CalcCamera
    /// </summary>
    public unsafe virtual bool CalcCamera(float fDeltaTime, out System.Numerics.Vector3 out_CamLoc, out BmSDK.Rotator out_CamRot, out float out_FOV)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalcCamera, "Engine.Actor.CalcCamera");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDeltaTime, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_CamLoc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_CamLoc, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_CamRot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_CamRot, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_FOV);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_FOV, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_CamLoc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
        out_CamRot = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 16);
        out_FOV = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_EndViewTarget;
    /// <summary>
    /// Function: EndViewTarget
    /// </summary>
    public unsafe virtual void EndViewTarget(BmSDK.Engine.PlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndViewTarget, "Engine.Actor.EndViewTarget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BecomeViewTarget;
    /// <summary>
    /// Function: BecomeViewTarget
    /// </summary>
    public unsafe virtual void BecomeViewTarget(BmSDK.Engine.PlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BecomeViewTarget, "Engine.Actor.BecomeViewTarget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForErrors;
    /// <summary>
    /// Function: CheckForErrors
    /// </summary>
    public unsafe virtual bool CheckForErrors()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForErrors, "Engine.Actor.CheckForErrors");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DebugFreezeGame;
    /// <summary>
    /// Function: DebugFreezeGame
    /// </summary>
    public unsafe virtual void DebugFreezeGame(BmSDK.Engine.Actor ActorToLookAt = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugFreezeGame, "Engine.Actor.DebugFreezeGame");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorToLookAt, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGravityZ;
    /// <summary>
    /// Function: GetGravityZ
    /// </summary>
    public unsafe virtual float GetGravityZ()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGravityZ, "Engine.Actor.GetGravityZ");
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

    private static BmSDK.Function __fn_CheckHitInfo;
    /// <summary>
    /// Function: CheckHitInfo
    /// </summary>
    public unsafe virtual void CheckHitInfo(out BmSDK.Engine.Actor.FTraceHitInfo HitInfo, BmSDK.Engine.PrimitiveComponent FallBackComponent, System.Numerics.Vector3 Dir, out System.Numerics.Vector3 out_HitLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckHitInfo, "Engine.Actor.CheckHitInfo");
        byte* paramsPtr = stackalloc byte[164];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitInfo);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FallBackComponent, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dir, paramsPtr + 40);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_HitLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_HitLocation, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        HitInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FTraceHitInfo>(paramsPtr + 0);
        out_HitLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 52);
        return;
    }

    private static BmSDK.Function __fn_TakeRadiusDamage;
    /// <summary>
    /// Function: TakeRadiusDamage
    /// </summary>
    public unsafe virtual void TakeRadiusDamage(BmSDK.Engine.Controller InstigatedBy, float BaseDamage, float DamageRadius, BmSDK.Class DamageType, float Momentum, System.Numerics.Vector3 HurtOrigin, bool bFullDamage, BmSDK.Engine.Actor DamageCauser, float DamageFalloffExponent = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeRadiusDamage, "Engine.Actor.TakeRadiusDamage");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BaseDamage, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageRadius, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HurtOrigin, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFullDamage, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageFalloffExponent, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HealDamage;
    /// <summary>
    /// Function: HealDamage
    /// </summary>
    public unsafe virtual bool HealDamage(int Amount, BmSDK.Engine.Controller Healer, BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HealDamage, "Engine.Actor.HealDamage");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Amount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Healer, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_TakeDamage;
    /// <summary>
    /// Function: TakeDamage
    /// </summary>
    public unsafe virtual void TakeDamage(int DamageAmount, BmSDK.Engine.Controller EventInstigator, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeDamage, "Engine.Actor.TakeDamage");
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventInstigator, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 72);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KilledBy;
    /// <summary>
    /// Function: KilledBy
    /// </summary>
    public unsafe virtual void KilledBy(BmSDK.Engine.Pawn EventInstigator)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KilledBy, "Engine.Actor.KilledBy");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventInstigator, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HurtRadius;
    /// <summary>
    /// Function: HurtRadius
    /// </summary>
    public unsafe virtual bool HurtRadius(float BaseDamage, float DamageRadius, BmSDK.Class DamageType, float Momentum, System.Numerics.Vector3 HurtOrigin, BmSDK.Engine.Actor IgnoredActor = default, BmSDK.Engine.Controller InstigatedByController = default, bool bDoFullDamage = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HurtRadius, "Engine.Actor.HurtRadius");
        byte* paramsPtr = stackalloc byte[112];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BaseDamage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageRadius, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HurtOrigin, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IgnoredActor, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedByController, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoFullDamage, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_StopsProjectile;
    /// <summary>
    /// Function: StopsProjectile
    /// </summary>
    public unsafe virtual bool StopsProjectile(BmSDK.Engine.Projectile P)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopsProjectile, "Engine.Actor.StopsProjectile");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_NotifySkelControlBeyondLimit;
    /// <summary>
    /// Function: NotifySkelControlBeyondLimit
    /// </summary>
    public unsafe virtual void NotifySkelControlBeyondLimit(BmSDK.Engine.SkelControlLookAt LookAt)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifySkelControlBeyondLimit, "Engine.Actor.NotifySkelControlBeyondLimit");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookAt, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ConstraintBrokenNotify;
    /// <summary>
    /// Function: ConstraintBrokenNotify
    /// </summary>
    public unsafe virtual void ConstraintBrokenNotify(BmSDK.Engine.Actor ConOwner, BmSDK.Engine.RB_ConstraintSetup ConSetup, BmSDK.Engine.RB_ConstraintInstance ConInstance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConstraintBrokenNotify, "Engine.Actor.ConstraintBrokenNotify");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConSetup, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConInstance, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetInitialState;
    /// <summary>
    /// Function: GetInitialState
    /// </summary>
    public unsafe virtual BmSDK.FName GetInitialState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInitialState, "Engine.Actor.GetInitialState");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetInitialState;
    /// <summary>
    /// Function: SetInitialState
    /// </summary>
    public unsafe virtual void SetInitialState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInitialState, "Engine.Actor.SetInitialState");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe virtual void PostBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "Engine.Actor.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreBeginPlay;
    /// <summary>
    /// Function: PreBeginPlay
    /// </summary>
    public unsafe virtual void PreBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreBeginPlay, "Engine.Actor.PreBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetALocalPlayerController;
    /// <summary>
    /// Function: GetALocalPlayerController
    /// </summary>
    public unsafe virtual BmSDK.Engine.PlayerController GetALocalPlayerController()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetALocalPlayerController, "Engine.Actor.GetALocalPlayerController");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PlayerController>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetURLMap;
    /// <summary>
    /// Function: GetURLMap
    /// </summary>
    public unsafe virtual BmSDK.FString GetURLMap()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetURLMap, "Engine.Actor.GetURLMap");
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

    private static BmSDK.Function __fn_GetDestination;
    /// <summary>
    /// Function: GetDestination
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetDestination(BmSDK.Engine.Controller C)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDestination, "Engine.Actor.GetDestination");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CalculateMinSpeedTrajectory;
    /// <summary>
    /// Function: CalculateMinSpeedTrajectory
    /// </summary>
    public unsafe virtual bool CalculateMinSpeedTrajectory(out System.Numerics.Vector3 out_Velocity, System.Numerics.Vector3 End, System.Numerics.Vector3 Start, float MaxTossSpeed, float MinTossSpeed, System.Numerics.Vector3 CollisionSize = default, float TerminalVelocity = default, float GravityZ = default, bool bOnlyTraceUp = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateMinSpeedTrajectory, "Engine.Actor.CalculateMinSpeedTrajectory");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_Velocity);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_Velocity, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxTossSpeed, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinTossSpeed, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionSize, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TerminalVelocity, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GravityZ, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyTraceUp, paramsPtr + 64);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_Velocity = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 68);
    }

    private static BmSDK.Function __fn_SuggestTossVelocity;
    /// <summary>
    /// Function: SuggestTossVelocity
    /// </summary>
    public unsafe virtual bool SuggestTossVelocity(out System.Numerics.Vector3 TossVelocity, System.Numerics.Vector3 Destination, System.Numerics.Vector3 Start, float TossSpeed, float BaseTossZ = default, float DesiredZPct = default, System.Numerics.Vector3 CollisionSize = default, float TerminalVelocity = default, float OverrideGravityZ = default, bool bOnlyTraceUp = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuggestTossVelocity, "Engine.Actor.SuggestTossVelocity");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TossVelocity);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TossVelocity, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Destination, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TossSpeed, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BaseTossZ, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredZPct, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionSize, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TerminalVelocity, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideGravityZ, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyTraceUp, paramsPtr + 68);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        TossVelocity = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 72);
    }

    private static BmSDK.Function __fn_PlayerCanSeeMe;
    /// <summary>
    /// Function: PlayerCanSeeMe
    /// </summary>
    public unsafe virtual bool PlayerCanSeeMe(bool bForceLOSCheck = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerCanSeeMe, "Engine.Actor.PlayerCanSeeMe");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceLOSCheck, paramsPtr + 0);
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

    private static BmSDK.Function __fn_MakeNoise;
    /// <summary>
    /// Function: MakeNoise
    /// </summary>
    public unsafe virtual void MakeNoise(float Loudness, BmSDK.FName NoiseType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakeNoise, "Engine.Actor.MakeNoise");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loudness, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NoiseType, paramsPtr + 4);
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

    private static BmSDK.Function __fn_PlaySound;
    /// <summary>
    /// Function: PlaySound
    /// </summary>
    public unsafe virtual void PlaySound(BmSDK.Engine.SoundCue InSoundCue, bool bNotReplicated = default, bool bNoRepToOwner = default, bool bStopWhenOwnerDestroyed = default, System.Numerics.Vector3 SoundLocation = default, bool bNoRepToRelevant = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySound, "Engine.Actor.PlaySound");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSoundCue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNotReplicated, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoRepToOwner, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStopWhenOwnerDestroyed, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoRepToRelevant, paramsPtr + 28);
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

    private static BmSDK.Function __fn_CreateAudioComponent;
    /// <summary>
    /// Function: CreateAudioComponent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AudioComponent CreateAudioComponent(BmSDK.Engine.SoundCue InSoundCue, bool bPlay = default, bool bStopWhenOwnerDestroyed = default, bool bUseLocation = default, System.Numerics.Vector3 SourceLocation = default, bool bAttachToSelf = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateAudioComponent, "Engine.Actor.CreateAudioComponent");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSoundCue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlay, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStopWhenOwnerDestroyed, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SourceLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAttachToSelf, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AudioComponent>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_ResetTimerTimeDilation;
    /// <summary>
    /// Function: ResetTimerTimeDilation
    /// </summary>
    public unsafe virtual void ResetTimerTimeDilation(BmSDK.FName TimerName, BmSDK.GameObject inObj = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetTimerTimeDilation, "Engine.Actor.ResetTimerTimeDilation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimerName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inObj, paramsPtr + 8);
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

    private static BmSDK.Function __fn_ModifyTimerTimeDilation;
    /// <summary>
    /// Function: ModifyTimerTimeDilation
    /// </summary>
    public unsafe virtual void ModifyTimerTimeDilation(BmSDK.FName TimerName, float InTimerTimeDilation, BmSDK.GameObject inObj = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyTimerTimeDilation, "Engine.Actor.ModifyTimerTimeDilation");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimerName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTimerTimeDilation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inObj, paramsPtr + 12);
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

    private static BmSDK.Function __fn_GetTimerRate;
    /// <summary>
    /// Function: GetTimerRate
    /// </summary>
    public unsafe virtual float GetTimerRate(BmSDK.FName TimerFuncName = default, BmSDK.GameObject inObj = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTimerRate, "Engine.Actor.GetTimerRate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimerFuncName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inObj, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetTimerCount;
    /// <summary>
    /// Function: GetTimerCount
    /// </summary>
    public unsafe virtual float GetTimerCount(BmSDK.FName inTimerFunc = default, BmSDK.GameObject inObj = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTimerCount, "Engine.Actor.GetTimerCount");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inTimerFunc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inObj, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_IsTimerActive;
    /// <summary>
    /// Function: IsTimerActive
    /// </summary>
    public unsafe virtual bool IsTimerActive(BmSDK.FName inTimerFunc = default, BmSDK.GameObject inObj = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTimerActive, "Engine.Actor.IsTimerActive");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inTimerFunc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inObj, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_PauseTimer;
    /// <summary>
    /// Function: PauseTimer
    /// </summary>
    public unsafe virtual void PauseTimer(bool bPause, BmSDK.FName inTimerFunc = default, BmSDK.GameObject inObj = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PauseTimer, "Engine.Actor.PauseTimer");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPause, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inTimerFunc, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inObj, paramsPtr + 12);
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

    private static BmSDK.Function __fn_ClearAllTimers;
    /// <summary>
    /// Function: ClearAllTimers
    /// </summary>
    public unsafe virtual void ClearAllTimers(BmSDK.GameObject inObj = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearAllTimers, "Engine.Actor.ClearAllTimers");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inObj, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ClearTimer;
    /// <summary>
    /// Function: ClearTimer
    /// </summary>
    public unsafe virtual void ClearTimer(BmSDK.FName inTimerFunc = default, BmSDK.GameObject inObj = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearTimer, "Engine.Actor.ClearTimer");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inTimerFunc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inObj, paramsPtr + 8);
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

    private static BmSDK.Function __fn_SetTimer;
    /// <summary>
    /// Function: SetTimer
    /// </summary>
    public unsafe virtual void SetTimer(float InRate, bool inbLoop = default, BmSDK.FName inTimerFunc = default, BmSDK.GameObject inObj = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTimer, "Engine.Actor.SetTimer");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InRate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inbLoop, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inTimerFunc, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inObj, paramsPtr + 16);
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

    private static BmSDK.Function __fn_TornOff;
    /// <summary>
    /// Function: TornOff
    /// </summary>
    public unsafe virtual void TornOff()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TornOff, "Engine.Actor.TornOff");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroy;
    /// <summary>
    /// Function: Destroy
    /// </summary>
    public unsafe virtual bool Destroy()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroy, "Engine.Actor.Destroy");
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

    private static BmSDK.Function __fn_Spawn;
    /// <summary>
    /// Function: Spawn
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor Spawn(BmSDK.Class SpawnClass, BmSDK.Engine.Actor SpawnOwner = default, BmSDK.FName SpawnTag = default, System.Numerics.Vector3 SpawnLocation = default, BmSDK.Rotator SpawnRotation = default, BmSDK.Engine.Actor ActorTemplate = default, bool bNoCollisionFail = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Spawn, "Engine.Actor.Spawn");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnOwner, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnTag, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRotation, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorTemplate, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoCollisionFail, paramsPtr + 44);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_IsBlockedBy;
    /// <summary>
    /// Function: IsBlockedBy
    /// </summary>
    public unsafe virtual bool IsBlockedBy(BmSDK.Engine.Actor Other)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBlockedBy, "Engine.Actor.IsBlockedBy");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetBoundingCylinder;
    /// <summary>
    /// Function: GetBoundingCylinder
    /// </summary>
    public unsafe virtual void GetBoundingCylinder(out float CollisionRadius, out float CollisionHeight)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBoundingCylinder, "Engine.Actor.GetBoundingCylinder");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CollisionRadius);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionRadius, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CollisionHeight);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionHeight, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        CollisionRadius = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        CollisionHeight = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_GetComponentsBoundingBox;
    /// <summary>
    /// Function: GetComponentsBoundingBox
    /// </summary>
    public unsafe virtual void GetComponentsBoundingBox(out BmSDK.GameObject.FBox ActorBox)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetComponentsBoundingBox, "Engine.Actor.GetComponentsBoundingBox");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ActorBox);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorBox, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ActorBox = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FBox>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_IsOverlapping;
    /// <summary>
    /// Function: IsOverlapping
    /// </summary>
    public unsafe virtual bool IsOverlapping(BmSDK.Engine.Actor A)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsOverlapping, "Engine.Actor.IsOverlapping");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ContainsPoint;
    /// <summary>
    /// Function: ContainsPoint
    /// </summary>
    public unsafe virtual bool ContainsPoint(System.Numerics.Vector3 Spot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ContainsPoint, "Engine.Actor.ContainsPoint");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Spot, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_FindSpot;
    /// <summary>
    /// Function: FindSpot
    /// </summary>
    public unsafe virtual bool FindSpot(System.Numerics.Vector3 BoxExtent, out System.Numerics.Vector3 SpotLocation, bool DontEaryOut = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindSpot, "Engine.Actor.FindSpot");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoxExtent, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SpotLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpotLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DontEaryOut, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        SpotLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_TraceAllPhysicsAssetInteractions;
    /// <summary>
    /// Function: TraceAllPhysicsAssetInteractions
    /// </summary>
    public unsafe virtual bool TraceAllPhysicsAssetInteractions(BmSDK.Engine.SkeletalMeshComponent SkelMeshComp, System.Numerics.Vector3 EndTrace, System.Numerics.Vector3 StartTrace, out BmSDK.TArray<BmSDK.Engine.Actor.FImpactInfo> out_Hits, System.Numerics.Vector3 Extent = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TraceAllPhysicsAssetInteractions, "Engine.Actor.TraceAllPhysicsAssetInteractions");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelMeshComp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndTrace, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartTrace, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 40);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_Hits = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FImpactInfo>>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 52);
    }

    private static BmSDK.Function __fn_FastTrace;
    /// <summary>
    /// Function: FastTrace
    /// </summary>
    public unsafe virtual bool FastTrace(System.Numerics.Vector3 TraceEnd, System.Numerics.Vector3 TraceStart = default, System.Numerics.Vector3 BoxExtent = default, bool bTraceBullet = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FastTrace, "Engine.Actor.FastTrace");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceEnd, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceStart, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoxExtent, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTraceBullet, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_PointCheckComponent;
    /// <summary>
    /// Function: PointCheckComponent
    /// </summary>
    public unsafe virtual bool PointCheckComponent(BmSDK.Engine.PrimitiveComponent InComponent, System.Numerics.Vector3 PointLocation, System.Numerics.Vector3 PointExtent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PointCheckComponent, "Engine.Actor.PointCheckComponent");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InComponent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointExtent, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_TraceComponent;
    /// <summary>
    /// Function: TraceComponent
    /// </summary>
    public unsafe virtual bool TraceComponent(out System.Numerics.Vector3 HitLocation, out System.Numerics.Vector3 HitNormal, BmSDK.Engine.PrimitiveComponent InComponent, System.Numerics.Vector3 TraceEnd, System.Numerics.Vector3 TraceStart, System.Numerics.Vector3 Extent, out BmSDK.Engine.Actor.FTraceHitInfo HitInfo, bool bComplexCollision)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TraceComponent, "Engine.Actor.TraceComponent");
        byte* paramsPtr = stackalloc byte[124];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InComponent, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceEnd, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceStart, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 52);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitInfo);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bComplexCollision, paramsPtr + 100);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HitLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        HitNormal = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        HitInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FTraceHitInfo>(paramsPtr + 64);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 104);
    }

    private static BmSDK.Function __fn_Trace;
    /// <summary>
    /// Function: Trace
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor Trace(out System.Numerics.Vector3 HitLocation, out System.Numerics.Vector3 HitNormal, System.Numerics.Vector3 TraceEnd, System.Numerics.Vector3 TraceStart, bool bTraceActors, System.Numerics.Vector3 Extent, out BmSDK.Engine.Actor.FTraceHitInfo HitInfo, int ExtraTraceFlags)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Trace, "Engine.Actor.Trace");
        byte* paramsPtr = stackalloc byte[124];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceEnd, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceStart, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTraceActors, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 52);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitInfo);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraTraceFlags, paramsPtr + 100);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HitLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        HitNormal = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        HitInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FTraceHitInfo>(paramsPtr + 64);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 104);
    }

    private static BmSDK.Function __fn_VolumeBasedDestroy;
    /// <summary>
    /// Function: VolumeBasedDestroy
    /// </summary>
    public unsafe virtual void VolumeBasedDestroy(BmSDK.Engine.PhysicsVolume PV)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VolumeBasedDestroy, "Engine.Actor.VolumeBasedDestroy");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PV, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OutsideWorldBounds;
    /// <summary>
    /// Function: OutsideWorldBounds
    /// </summary>
    public unsafe virtual void OutsideWorldBounds()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OutsideWorldBounds, "Engine.Actor.OutsideWorldBounds");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FellOutOfWorld;
    /// <summary>
    /// Function: FellOutOfWorld
    /// </summary>
    public unsafe virtual void FellOutOfWorld(BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FellOutOfWorld, "Engine.Actor.FellOutOfWorld");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UsedBy;
    /// <summary>
    /// Function: UsedBy
    /// </summary>
    public unsafe virtual bool UsedBy(BmSDK.Engine.Pawn User)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UsedBy, "Engine.Actor.UsedBy");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(User, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OverRotated;
    /// <summary>
    /// Function: OverRotated
    /// </summary>
    public unsafe virtual bool OverRotated(out BmSDK.Rotator out_Desired, out BmSDK.Rotator out_Actual)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverRotated, "Engine.Actor.OverRotated");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_Desired);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_Desired, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_Actual);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_Actual, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_Desired = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 0);
        out_Actual = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_ClampRotation;
    /// <summary>
    /// Function: ClampRotation
    /// </summary>
    public unsafe virtual bool ClampRotation(out BmSDK.Rotator out_Rot, BmSDK.Rotator rBase, BmSDK.Rotator rUpperLimits, BmSDK.Rotator rLowerLimits)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClampRotation, "Engine.Actor.ClampRotation");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_Rot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_Rot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(rBase, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(rUpperLimits, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(rLowerLimits, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_Rot = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_OnSleepRBPhysics;
    /// <summary>
    /// Function: OnSleepRBPhysics
    /// </summary>
    public unsafe virtual void OnSleepRBPhysics()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSleepRBPhysics, "Engine.Actor.OnSleepRBPhysics");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnWakeRBPhysics;
    /// <summary>
    /// Function: OnWakeRBPhysics
    /// </summary>
    public unsafe virtual void OnWakeRBPhysics()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnWakeRBPhysics, "Engine.Actor.OnWakeRBPhysics");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopFaceFXAudio;
    /// <summary>
    /// Function: StopFaceFXAudio
    /// </summary>
    public unsafe virtual void StopFaceFXAudio()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopFaceFXAudio, "Engine.Actor.StopFaceFXAudio");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FaceFXAudioStoppedCallback;
    /// <summary>
    /// Function: FaceFXAudioStoppedCallback
    /// </summary>
    public unsafe virtual void FaceFXAudioStoppedCallback()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FaceFXAudioStoppedCallback, "Engine.Actor.FaceFXAudioStoppedCallback");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DMAudioCallback;
    /// <summary>
    /// Function: DMAudioCallback
    /// </summary>
    public unsafe virtual void DMAudioCallback(int CallbackFlags, BmSDK.Engine.AkWwise.FAkSoundHandle SoundHandle, int MarkerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DMAudioCallback, "Engine.Actor.DMAudioCallback");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CallbackFlags, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundHandle, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MarkerID, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FaceFXAudioStartedCallback;
    /// <summary>
    /// Function: FaceFXAudioStartedCallback
    /// </summary>
    public unsafe virtual void FaceFXAudioStartedCallback(BmSDK.Engine.RDialogueEvent DialogueEvent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FaceFXAudioStartedCallback, "Engine.Actor.FaceFXAudioStartedCallback");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueEvent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AnimationTriggerCallback;
    /// <summary>
    /// Function: AnimationTriggerCallback
    /// </summary>
    public unsafe virtual void AnimationTriggerCallback(BmSDK.FName TagName, BmSDK.TArray<BmSDK.FString> Params, BmSDK.Engine.AnimSet TagAnimSet, float Time)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnimationTriggerCallback, "Engine.Actor.AnimationTriggerCallback");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TagName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Params, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TagAnimSet, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RanInto;
    /// <summary>
    /// Function: RanInto
    /// </summary>
    public unsafe virtual void RanInto(BmSDK.Engine.Actor Other)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RanInto, "Engine.Actor.RanInto");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EncroachedBy;
    /// <summary>
    /// Function: EncroachedBy
    /// </summary>
    public unsafe virtual void EncroachedBy(BmSDK.Engine.Actor Other)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EncroachedBy, "Engine.Actor.EncroachedBy");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EncroachingOn;
    /// <summary>
    /// Function: EncroachingOn
    /// </summary>
    public unsafe virtual bool EncroachingOn(BmSDK.Engine.Actor Other)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EncroachingOn, "Engine.Actor.EncroachingOn");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CollisionChanged;
    /// <summary>
    /// Function: CollisionChanged
    /// </summary>
    public unsafe virtual void CollisionChanged()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CollisionChanged, "Engine.Actor.CollisionChanged");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpecialHandling;
    /// <summary>
    /// Function: SpecialHandling
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor SpecialHandling(BmSDK.Engine.Pawn Other)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpecialHandling, "Engine.Actor.SpecialHandling");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_Detach;
    /// <summary>
    /// Function: Detach
    /// </summary>
    public unsafe virtual void Detach(BmSDK.Engine.Actor Other)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Detach, "Engine.Actor.Detach");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Attach;
    /// <summary>
    /// Function: Attach
    /// </summary>
    public unsafe virtual void Attach(BmSDK.Engine.Actor Other)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Attach, "Engine.Actor.Attach");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BaseChange;
    /// <summary>
    /// Function: BaseChange
    /// </summary>
    public unsafe virtual void BaseChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BaseChange, "Engine.Actor.BaseChange");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Bump;
    /// <summary>
    /// Function: Bump
    /// </summary>
    public unsafe virtual void Bump(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Bump, "Engine.Actor.Bump");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnTouch;
    /// <summary>
    /// Function: UnTouch
    /// </summary>
    public unsafe virtual void UnTouch(BmSDK.Engine.Actor Other)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnTouch, "Engine.Actor.UnTouch");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Touch;
    /// <summary>
    /// Function: Touch
    /// </summary>
    public unsafe virtual void Touch(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Touch, "Engine.Actor.Touch");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PhysicsVolumeChange;
    /// <summary>
    /// Function: PhysicsVolumeChange
    /// </summary>
    public unsafe virtual void PhysicsVolumeChange(BmSDK.Engine.PhysicsVolume NewVolume)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PhysicsVolumeChange, "Engine.Actor.PhysicsVolumeChange");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewVolume, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Landed;
    /// <summary>
    /// Function: Landed
    /// </summary>
    public unsafe virtual void Landed(System.Numerics.Vector3 HitNormal, BmSDK.Engine.Actor FloorActor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Landed, "Engine.Actor.Landed");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FloorActor, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Falling;
    /// <summary>
    /// Function: Falling
    /// </summary>
    public unsafe virtual void Falling()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Falling, "Engine.Actor.Falling");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HitWall;
    /// <summary>
    /// Function: HitWall
    /// </summary>
    public unsafe virtual void HitWall(System.Numerics.Vector3 HitNormal, BmSDK.Engine.Actor Wall, BmSDK.Engine.PrimitiveComponent WallComp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitWall, "Engine.Actor.HitWall");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Wall, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallComp, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Timer;
    /// <summary>
    /// Function: Timer
    /// </summary>
    public unsafe virtual void Timer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Timer, "Engine.Actor.Timer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "Engine.Actor.Tick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LostChild;
    /// <summary>
    /// Function: LostChild
    /// </summary>
    public unsafe virtual void LostChild(BmSDK.Engine.Actor Other)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LostChild, "Engine.Actor.LostChild");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GainedChild;
    /// <summary>
    /// Function: GainedChild
    /// </summary>
    public unsafe virtual void GainedChild(BmSDK.Engine.Actor Other)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GainedChild, "Engine.Actor.GainedChild");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe virtual void Destroyed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "Engine.Actor.Destroyed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopSpeakingDM;
    /// <summary>
    /// Function: StopSpeakingDM
    /// </summary>
    public unsafe virtual void StopSpeakingDM(BmSDK.Engine.AkWwise.FAkSoundHandle SoundHandle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopSpeakingDM, "Engine.Actor.StopSpeakingDM");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundHandle, paramsPtr + 0);
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

    private static BmSDK.Function __fn_StartSpeakingDM;
    /// <summary>
    /// Function: StartSpeakingDM
    /// </summary>
    public unsafe virtual void StartSpeakingDM(BmSDK.Engine.RDialogueEvent DialogueEvent, System.IntPtr SoundCallBack = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSpeakingDM, "Engine.Actor.StartSpeakingDM");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueEvent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundCallBack, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SetStasis;
    /// <summary>
    /// Function: SetStasis
    /// </summary>
    public unsafe virtual void SetStasis(bool bInStasis)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetStasis, "Engine.Actor.SetStasis");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInStasis, paramsPtr + 0);
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
    public unsafe virtual void SetTickIsDisabled(bool bInDisabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTickIsDisabled, "Engine.Actor.SetTickIsDisabled");
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

    private static BmSDK.Function __fn_SetTickGroup;
    /// <summary>
    /// Function: SetTickGroup
    /// </summary>
    public unsafe virtual void SetTickGroup(BmSDK.GameObject.ETickingGroup NewTickGroup)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTickGroup, "Engine.Actor.SetTickGroup");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTickGroup, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ReattachComponent;
    /// <summary>
    /// Function: ReattachComponent
    /// </summary>
    public unsafe virtual void ReattachComponent(BmSDK.Engine.ActorComponent ComponentToReattach)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReattachComponent, "Engine.Actor.ReattachComponent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComponentToReattach, paramsPtr + 0);
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

    private static BmSDK.Function __fn_DetachComponent;
    /// <summary>
    /// Function: DetachComponent
    /// </summary>
    public unsafe virtual void DetachComponent(BmSDK.Engine.ActorComponent ExComponent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetachComponent, "Engine.Actor.DetachComponent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExComponent, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AttachComponent;
    /// <summary>
    /// Function: AttachComponent
    /// </summary>
    public unsafe virtual void AttachComponent(BmSDK.Engine.ActorComponent NewComponent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachComponent, "Engine.Actor.AttachComponent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewComponent, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UnClock;
    /// <summary>
    /// Function: UnClock
    /// </summary>
    public unsafe virtual void UnClock(out float Time)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnClock, "Engine.Actor.UnClock");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Time);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Time = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_Clock;
    /// <summary>
    /// Function: Clock
    /// </summary>
    public unsafe virtual void Clock(out float Time)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Clock, "Engine.Actor.Clock");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Time);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Time = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetPhysics;
    /// <summary>
    /// Function: SetPhysics
    /// </summary>
    public unsafe virtual void SetPhysics(BmSDK.Engine.Actor.EPhysics newPhysics, bool WakePhysics = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPhysics, "Engine.Actor.SetPhysics");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(newPhysics, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WakePhysics, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SetOnlyOwnerSee;
    /// <summary>
    /// Function: SetOnlyOwnerSee
    /// </summary>
    public unsafe virtual void SetOnlyOwnerSee(bool bNewOnlyOwnerSee)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOnlyOwnerSee, "Engine.Actor.SetOnlyOwnerSee");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewOnlyOwnerSee, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetHidden;
    /// <summary>
    /// Function: SetHidden
    /// </summary>
    public unsafe virtual void SetHidden(bool bNewHidden)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHidden, "Engine.Actor.SetHidden");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewHidden, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ChartData;
    /// <summary>
    /// Function: ChartData
    /// </summary>
    public unsafe virtual void ChartData(BmSDK.FString DataName, float DataValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChartData, "Engine.Actor.ChartData");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DataName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DataValue, paramsPtr + 12);
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

    private static BmSDK.Function __fn_FlushDebugStrings;
    /// <summary>
    /// Function: FlushDebugStrings
    /// </summary>
    public unsafe static void FlushDebugStrings()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlushDebugStrings, "Engine.Actor.FlushDebugStrings");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawDebugFrustrum;
    /// <summary>
    /// Function: DrawDebugFrustrum
    /// </summary>
    public unsafe static void DrawDebugFrustrum(in BmSDK.GameObject.FMatrix FrustumToWorld, byte R, byte G, byte B, bool bPersistentLines = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugFrustrum, "Engine.Actor.DrawDebugFrustrum");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FrustumToWorld, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 65);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 66);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 68);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawDebugString;
    /// <summary>
    /// Function: DrawDebugString
    /// </summary>
    public unsafe static void DrawDebugString(System.Numerics.Vector3 TextLocation, BmSDK.FString Text, BmSDK.Engine.Actor TestBaseActor = default, BmSDK.GameObject.FColor TextColor = default, float Duration = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugString, "Engine.Actor.DrawDebugString");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TextLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestBaseActor, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TextColor, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawDebugCone;
    /// <summary>
    /// Function: DrawDebugCone
    /// </summary>
    public unsafe static void DrawDebugCone(System.Numerics.Vector3 Origin, System.Numerics.Vector3 Direction, float Length, float AngleWidth, float AngleHeight, int NumSides, BmSDK.GameObject.FColor DrawColor, bool bPersistentLines = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugCone, "Engine.Actor.DrawDebugCone");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Origin, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Length, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AngleWidth, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AngleHeight, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumSides, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DrawColor, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 44);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawDebugCylinder;
    /// <summary>
    /// Function: DrawDebugCylinder
    /// </summary>
    public unsafe static void DrawDebugCylinder(System.Numerics.Vector3 Start, System.Numerics.Vector3 End, float Radius, int Segments, byte R, byte G, byte B, bool bPersistentLines = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugCylinder, "Engine.Actor.DrawDebugCylinder");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Segments, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 33);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 34);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawDebugSphere;
    /// <summary>
    /// Function: DrawDebugSphere
    /// </summary>
    public unsafe static void DrawDebugSphere(System.Numerics.Vector3 Center, float Radius, int Segments, byte R, byte G, byte B, bool bPersistentLines = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugSphere, "Engine.Actor.DrawDebugSphere");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Center, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Segments, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 21);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 22);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawDebugCoordinateSystem;
    /// <summary>
    /// Function: DrawDebugCoordinateSystem
    /// </summary>
    public unsafe static void DrawDebugCoordinateSystem(System.Numerics.Vector3 AxisLoc, BmSDK.Rotator AxisRot, float Scale, bool bPersistentLines = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugCoordinateSystem, "Engine.Actor.DrawDebugCoordinateSystem");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AxisLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AxisRot, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scale, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawDebugStar;
    /// <summary>
    /// Function: DrawDebugStar
    /// </summary>
    public unsafe static void DrawDebugStar(System.Numerics.Vector3 Position, float Size, byte R, byte G, byte B, bool bPersistentLines = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugStar, "Engine.Actor.DrawDebugStar");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Size, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 17);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 18);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawDebugBounds;
    /// <summary>
    /// Function: DrawDebugBounds
    /// </summary>
    public unsafe static void DrawDebugBounds(System.Numerics.Vector3 AxisLoc, BmSDK.Rotator AxisRot, BmSDK.GameObject.FBox Bounds, byte R, byte G, byte B, bool bPersistentLines = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugBounds, "Engine.Actor.DrawDebugBounds");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AxisLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AxisRot, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Bounds, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 53);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 54);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 56);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawDebugBox;
    /// <summary>
    /// Function: DrawDebugBox
    /// </summary>
    public unsafe static void DrawDebugBox(System.Numerics.Vector3 Center, System.Numerics.Vector3 Extent, byte R, byte G, byte B, bool bPersistentLines = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugBox, "Engine.Actor.DrawDebugBox");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Center, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 25);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 26);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawDebugPoint;
    /// <summary>
    /// Function: DrawDebugPoint
    /// </summary>
    public unsafe static void DrawDebugPoint(System.Numerics.Vector3 Position, float Size, BmSDK.GameObject.FLinearColor PointColor, bool bPersistentLines = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugPoint, "Engine.Actor.DrawDebugPoint");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Size, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointColor, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawDebugWall;
    /// <summary>
    /// Function: DrawDebugWall
    /// </summary>
    public unsafe static void DrawDebugWall(System.Numerics.Vector3 LineStart, System.Numerics.Vector3 LineEnd, byte R, byte G, byte B, bool bPersistentLines = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugWall, "Engine.Actor.DrawDebugWall");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineStart, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineEnd, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 25);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 26);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawDebugLine;
    /// <summary>
    /// Function: DrawDebugLine
    /// </summary>
    public unsafe static void DrawDebugLine(System.Numerics.Vector3 LineStart, System.Numerics.Vector3 LineEnd, byte R, byte G, byte B, bool bPersistentLines = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugLine, "Engine.Actor.DrawDebugLine");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineStart, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineEnd, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 25);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 26);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_FlushPersistentDebugLines;
    /// <summary>
    /// Function: FlushPersistentDebugLines
    /// </summary>
    public unsafe static void FlushPersistentDebugLines()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlushPersistentDebugLines, "Engine.Actor.FlushPersistentDebugLines");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_GetBasedPosition;
    /// <summary>
    /// Function: GetBasedPosition
    /// </summary>
    public unsafe static System.Numerics.Vector3 GetBasedPosition(BmSDK.Engine.Actor.FBasedPosition BP)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBasedPosition, "Engine.Actor.GetBasedPosition");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BP, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 52);
    }

    private static BmSDK.Function __fn_SetBasedPosition;
    /// <summary>
    /// Function: SetBasedPosition
    /// </summary>
    public unsafe static void SetBasedPosition(out BmSDK.Engine.Actor.FBasedPosition BP, System.Numerics.Vector3 pos, BmSDK.Engine.Actor ForcedBase = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBasedPosition, "Engine.Actor.SetBasedPosition");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BP);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BP, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForcedBase, paramsPtr + 64);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BP = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FBasedPosition>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_BP2Vect;
    /// <summary>
    /// Function: BP2Vect
    /// </summary>
    public unsafe static System.Numerics.Vector3 BP2Vect(BmSDK.Engine.Actor.FBasedPosition BP)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BP2Vect, "Engine.Actor.BP2Vect");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BP, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 52);
    }

    private static BmSDK.Function __fn_Vect2BP;
    /// <summary>
    /// Function: Vect2BP
    /// </summary>
    public unsafe static void Vect2BP(out BmSDK.Engine.Actor.FBasedPosition BP, System.Numerics.Vector3 pos, BmSDK.Engine.Actor ForcedBase = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Vect2BP, "Engine.Actor.Vect2BP");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BP);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BP, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForcedBase, paramsPtr + 64);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BP = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FBasedPosition>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetForcedInitialReplicatedProperty;
    /// <summary>
    /// Function: SetForcedInitialReplicatedProperty
    /// </summary>
    public unsafe virtual void SetForcedInitialReplicatedProperty(BmSDK.Property PropToReplicate, bool bAdd)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetForcedInitialReplicatedProperty, "Engine.Actor.SetForcedInitialReplicatedProperty");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropToReplicate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAdd, paramsPtr + 4);
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

    private static BmSDK.Function __fn_ReplicatedEvent;
    /// <summary>
    /// Function: ReplicatedEvent
    /// </summary>
    public unsafe virtual void ReplicatedEvent(BmSDK.FName VarName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplicatedEvent, "Engine.Actor.ReplicatedEvent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAggregateBaseVelocity;
    /// <summary>
    /// Function: GetAggregateBaseVelocity
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAggregateBaseVelocity(BmSDK.Engine.Actor TestBase = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAggregateBaseVelocity, "Engine.Actor.GetAggregateBaseVelocity");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestBase, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsOwnedBy;
    /// <summary>
    /// Function: IsOwnedBy
    /// </summary>
    public unsafe virtual bool IsOwnedBy(BmSDK.Engine.Actor TestActor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsOwnedBy, "Engine.Actor.IsOwnedBy");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestActor, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetBaseMost;
    /// <summary>
    /// Function: GetBaseMost
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor GetBaseMost()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBaseMost, "Engine.Actor.GetBaseMost");
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

    private static BmSDK.Function __fn_IsBasedOn;
    /// <summary>
    /// Function: IsBasedOn
    /// </summary>
    public unsafe virtual bool IsBasedOn(BmSDK.Engine.Actor TestActor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBasedOn, "Engine.Actor.IsBasedOn");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestActor, paramsPtr + 0);
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

    private static BmSDK.Function __fn_FindBase;
    /// <summary>
    /// Function: FindBase
    /// </summary>
    public unsafe virtual void FindBase()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindBase, "Engine.Actor.FindBase");
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

    private static BmSDK.Function __fn_SetOwner;
    /// <summary>
    /// Function: SetOwner
    /// </summary>
    public unsafe virtual void SetOwner(BmSDK.Engine.Actor NewOwner)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOwner, "Engine.Actor.SetOwner");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetBase;
    /// <summary>
    /// Function: SetBase
    /// </summary>
    public unsafe virtual void SetBase(BmSDK.Engine.Actor NewBase, System.Numerics.Vector3 NewFloor = default, BmSDK.Engine.SkeletalMeshComponent SkelComp = default, BmSDK.FName AttachName = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBase, "Engine.Actor.SetBase");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBase, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFloor, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelComp, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttachName, paramsPtr + 20);
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

    private static BmSDK.Function __fn_GetTerminalVelocity;
    /// <summary>
    /// Function: GetTerminalVelocity
    /// </summary>
    public unsafe virtual float GetTerminalVelocity()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTerminalVelocity, "Engine.Actor.GetTerminalVelocity");
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

    private static BmSDK.Function __fn_AutonomousPhysics;
    /// <summary>
    /// Function: AutonomousPhysics
    /// </summary>
    public unsafe virtual void AutonomousPhysics(float DeltaSeconds)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AutonomousPhysics, "Engine.Actor.AutonomousPhysics");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaSeconds, paramsPtr + 0);
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

    private static BmSDK.Function __fn_MoveSmooth;
    /// <summary>
    /// Function: MoveSmooth
    /// </summary>
    public unsafe virtual bool MoveSmooth(System.Numerics.Vector3 Delta)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveSmooth, "Engine.Actor.MoveSmooth");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delta, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_fixedTurn;
    /// <summary>
    /// Function: fixedTurn
    /// </summary>
    public unsafe virtual int fixedTurn(int Current, int Desired, int DeltaRate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_fixedTurn, "Engine.Actor.fixedTurn");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Current, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Desired, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaRate, paramsPtr + 8);
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

    private static BmSDK.Function __fn_SetHardAttach;
    /// <summary>
    /// Function: SetHardAttach
    /// </summary>
    public unsafe virtual void SetHardAttach(bool bNewHardAttach = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHardAttach, "Engine.Actor.SetHardAttach");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewHardAttach, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetRelativeLocation;
    /// <summary>
    /// Function: SetRelativeLocation
    /// </summary>
    public unsafe virtual bool SetRelativeLocation(System.Numerics.Vector3 NewLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRelativeLocation, "Engine.Actor.SetRelativeLocation");
        byte* paramsPtr = stackalloc byte[32];
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetRelativeRotation;
    /// <summary>
    /// Function: SetRelativeRotation
    /// </summary>
    public unsafe virtual bool SetRelativeRotation(BmSDK.Rotator NewRotation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRelativeRotation, "Engine.Actor.SetRelativeRotation");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRotation, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetZone;
    /// <summary>
    /// Function: SetZone
    /// </summary>
    public unsafe virtual void SetZone(bool bForceRefresh)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetZone, "Engine.Actor.SetZone");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceRefresh, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetLocationForTest;
    /// <summary>
    /// Function: SetLocationForTest
    /// </summary>
    public unsafe virtual bool SetLocationForTest(System.Numerics.Vector3 NewLocation, bool bNoCheck)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLocationForTest, "Engine.Actor.SetLocationForTest");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoCheck, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_MovingWhichWay;
    /// <summary>
    /// Function: MovingWhichWay
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor.EMoveDir MovingWhichWay(out float Amount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MovingWhichWay, "Engine.Actor.MovingWhichWay");
        byte* paramsPtr = stackalloc byte[21];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Amount);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Amount, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Amount = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.EMoveDir>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetRotation;
    /// <summary>
    /// Function: SetRotation
    /// </summary>
    public unsafe virtual bool SetRotation(BmSDK.Rotator NewRotation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRotation, "Engine.Actor.SetRotation");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRotation, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetLocation;
    /// <summary>
    /// Function: SetLocation
    /// </summary>
    public unsafe virtual bool SetLocation(System.Numerics.Vector3 NewLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLocation, "Engine.Actor.SetLocation");
        byte* paramsPtr = stackalloc byte[32];
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_Move;
    /// <summary>
    /// Function: Move
    /// </summary>
    public unsafe virtual bool Move(System.Numerics.Vector3 Delta)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Move, "Engine.Actor.Move");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delta, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetDrawScale3D;
    /// <summary>
    /// Function: SetDrawScale3D
    /// </summary>
    public unsafe virtual void SetDrawScale3D(System.Numerics.Vector3 NewScale3D)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDrawScale3D, "Engine.Actor.SetDrawScale3D");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewScale3D, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetDrawScale;
    /// <summary>
    /// Function: SetDrawScale
    /// </summary>
    public unsafe virtual void SetDrawScale(float NewScale)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDrawScale, "Engine.Actor.SetDrawScale");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewScale, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetCollisionType;
    /// <summary>
    /// Function: SetCollisionType
    /// </summary>
    public unsafe virtual void SetCollisionType(BmSDK.Engine.Actor.ECollisionType NewCollisionType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCollisionType, "Engine.Actor.SetCollisionType");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCollisionType, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetCollisionSize;
    /// <summary>
    /// Function: SetCollisionSize
    /// </summary>
    public unsafe virtual void SetCollisionSize(float NewRadius, float NewHeight)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCollisionSize, "Engine.Actor.SetCollisionSize");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRadius, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewHeight, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SetCollision;
    /// <summary>
    /// Function: SetCollision
    /// </summary>
    public unsafe virtual void SetCollision(bool bNewColActors = default, bool bNewBlockActors = default, bool bNewIgnoreEncroachers = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCollision, "Engine.Actor.SetCollision");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewColActors, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewBlockActors, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewIgnoreEncroachers, paramsPtr + 8);
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

    private static BmSDK.Function __fn_FinishAnim;
    /// <summary>
    /// Function: FinishAnim
    /// </summary>
    public unsafe virtual void FinishAnim(BmSDK.Engine.AnimNodeSequence SeqNode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishAnim, "Engine.Actor.FinishAnim");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SeqNode, paramsPtr + 0);
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

    private static BmSDK.Function __fn_Sleep;
    /// <summary>
    /// Function: Sleep
    /// </summary>
    public unsafe virtual void Sleep(float Seconds)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Sleep, "Engine.Actor.Sleep");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Seconds, paramsPtr + 0);
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
    public unsafe virtual BmSDK.FString ConsoleCommand(BmSDK.FString Command, bool bWriteToLog = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConsoleCommand, "Engine.Actor.ConsoleCommand");
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

    private static BmSDK.Function __fn_ForceUpdateComponents;
    /// <summary>
    /// Function: ForceUpdateComponents
    /// </summary>
    public unsafe virtual void ForceUpdateComponents(bool bCollisionUpdate = default, bool bTransformOnly = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceUpdateComponents, "Engine.Actor.ForceUpdateComponents");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCollisionUpdate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTransformOnly, paramsPtr + 4);
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
    /// Struct: FBasedPosition
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public partial record struct FBasedPosition
    {
        /// <summary>
        /// ObjectProperty: Base
        /// </summary>
        public unsafe BmSDK.Engine.Actor Base
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Position
        /// </summary>
        public unsafe System.Numerics.Vector3 Position
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: CachedBaseLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 CachedBaseLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: CachedBaseRotation
        /// </summary>
        public unsafe BmSDK.Rotator CachedBaseRotation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// StructProperty: CachedTransPosition
        /// </summary>
        public unsafe System.Numerics.Vector3 CachedTransPosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FNavReference
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FNavReference
    {
        /// <summary>
        /// ObjectProperty: Nav
        /// </summary>
        public unsafe BmSDK.Engine.NavigationPoint Nav
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NavigationPoint>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Guid
        /// </summary>
        public unsafe BmSDK.GameObject.FGuid Guid
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FGuid>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FActorReference
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FActorReference
    {
        /// <summary>
        /// ObjectProperty: Actor
        /// </summary>
        public unsafe BmSDK.Engine.Actor Actor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Guid
        /// </summary>
        public unsafe BmSDK.GameObject.FGuid Guid
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FGuid>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Enum: EDoubleClickDir
    /// </summary>
    public enum EDoubleClickDir : byte
    {
        DCLICK_None = 0,
        DCLICK_Left = 1,
        DCLICK_Right = 2,
        DCLICK_Forward = 3,
        DCLICK_Back = 4,
        DCLICK_Active = 5,
        DCLICK_Done = 6,
        DCLICK_MAX = 7,
    }

    /// <summary>
    /// Enum: ETravelType
    /// </summary>
    public enum ETravelType : byte
    {
        TRAVEL_Absolute = 0,
        TRAVEL_Partial = 1,
        TRAVEL_Relative = 2,
        TRAVEL_MAX = 3,
    }

    /// <summary>
    /// Struct: FPhysEffectInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FPhysEffectInfo
    {
        /// <summary>
        /// FloatProperty: MinEffectSpeed
        /// </summary>
        public unsafe float MinEffectSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: MaxEffectSpeed
        /// </summary>
        public unsafe float MaxEffectSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: ReFireDelay
        /// </summary>
        public unsafe float ReFireDelay
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: Effect
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystem Effect
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ObjectProperty: Sound
        /// </summary>
        public unsafe BmSDK.Engine.AkEvent Sound
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ComponentProperty: Force
        /// </summary>
        public unsafe BmSDK.Engine.RB_ForceComponent Force
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RB_ForceComponent>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FCollisionImpactData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FCollisionImpactData
    {
        /// <summary>
        /// ArrayProperty: ContactInfos
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.Actor.FRigidBodyContactInfo> ContactInfos
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor.FRigidBodyContactInfo>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: TotalNormalForceVector
        /// </summary>
        public unsafe System.Numerics.Vector3 TotalNormalForceVector
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: TotalFrictionForceVector
        /// </summary>
        public unsafe System.Numerics.Vector3 TotalFrictionForceVector
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FRigidBodyContactInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public partial record struct FRigidBodyContactInfo
    {
        /// <summary>
        /// StructProperty: ContactPosition
        /// </summary>
        public unsafe System.Numerics.Vector3 ContactPosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: ContactNormal
        /// </summary>
        public unsafe System.Numerics.Vector3 ContactNormal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: ContactPenetration
        /// </summary>
        public unsafe float ContactPenetration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: ContactVelocity
        /// </summary>
        public unsafe System.Numerics.Vector3 ContactVelocity_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
        /// <summary>
        /// StructProperty: ContactVelocity
        /// </summary>
        public unsafe System.Numerics.Vector3 ContactVelocity_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// ObjectProperty: PhysMaterial
        /// </summary>
        public unsafe BmSDK.Engine.PhysicalMaterial PhysMaterial_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicalMaterial>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }
        /// <summary>
        /// ObjectProperty: PhysMaterial
        /// </summary>
        public unsafe BmSDK.Engine.PhysicalMaterial PhysMaterial_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicalMaterial>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }
    }

    /// <summary>
    /// Struct: FRigidBodyState
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public partial record struct FRigidBodyState
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
        /// StructProperty: Quaternion
        /// </summary>
        public unsafe BmSDK.GameObject.FQuat Quaternion
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FQuat>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: LinVel
        /// </summary>
        public unsafe System.Numerics.Vector3 LinVel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StructProperty: AngVel
        /// </summary>
        public unsafe System.Numerics.Vector3 AngVel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// ByteProperty: bNewData
        /// </summary>
        public unsafe byte bNewData
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }
    }

    /// <summary>
    /// Struct: FPhysContactModificationData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FPhysContactModificationData
    {
        /// <summary>
        /// IntProperty: ChangeFlags
        /// </summary>
        public unsafe int ChangeFlags
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: PhysShape0
        /// </summary>
        public unsafe System.IntPtr PhysShape0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: PhysShape1
        /// </summary>
        public unsafe System.IntPtr PhysShape1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: Actor0
        /// </summary>
        public unsafe BmSDK.Engine.Actor Actor0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ObjectProperty: Actor1
        /// </summary>
        public unsafe BmSDK.Engine.Actor Actor1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: PhysFeatureIndex0
        /// </summary>
        public unsafe int PhysFeatureIndex0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// IntProperty: physFeatureIndex1
        /// </summary>
        public unsafe int physFeatureIndex1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: PhysData
        /// </summary>
        public unsafe System.IntPtr PhysData
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
    }

    /// <summary>
    /// Enum: ECollisionType
    /// </summary>
    public enum ECollisionType : byte
    {
        COLLIDE_CustomDefault = 0,
        COLLIDE_NoCollision = 1,
        COLLIDE_BlockAll = 2,
        COLLIDE_BlockWeapons = 3,
        COLLIDE_TouchAll = 4,
        COLLIDE_TouchWeapons = 5,
        COLLIDE_BlockAllButWeapons = 6,
        COLLIDE_TouchAllButWeapons = 7,
        COLLIDE_BlockWeaponsKickable = 8,
        COLLIDE_MAX = 9,
    }

    /// <summary>
    /// Struct: FAnimSlotDesc
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FAnimSlotDesc
    {
        /// <summary>
        /// NameProperty: SlotName
        /// </summary>
        public unsafe BmSDK.FName SlotName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: NumChannels
        /// </summary>
        public unsafe int NumChannels
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FAnimSlotInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FAnimSlotInfo
    {
        /// <summary>
        /// NameProperty: SlotName
        /// </summary>
        public unsafe BmSDK.FName SlotName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: ChannelWeights
        /// </summary>
        public unsafe BmSDK.TArray<float> ChannelWeights
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FImpactInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial record struct FImpactInfo
    {
        /// <summary>
        /// ObjectProperty: HitActor
        /// </summary>
        public unsafe BmSDK.Engine.Actor HitActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: HitLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 HitLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: HitNormal
        /// </summary>
        public unsafe System.Numerics.Vector3 HitNormal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: RayDir
        /// </summary>
        public unsafe System.Numerics.Vector3 RayDir
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// StructProperty: StartTrace
        /// </summary>
        public unsafe System.Numerics.Vector3 StartTrace
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// StructProperty: HitInfo
        /// </summary>
        public unsafe BmSDK.Engine.Actor.FTraceHitInfo HitInfo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.FTraceHitInfo>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }
    }

    /// <summary>
    /// Struct: FTraceHitInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FTraceHitInfo
    {
        /// <summary>
        /// ObjectProperty: Material
        /// </summary>
        public unsafe BmSDK.Engine.Material Material
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: PhysMaterial
        /// </summary>
        public unsafe BmSDK.Engine.PhysicalMaterial PhysMaterial
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicalMaterial>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: Item
        /// </summary>
        public unsafe int Item
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: LevelIndex
        /// </summary>
        public unsafe int LevelIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// NameProperty: BoneName
        /// </summary>
        public unsafe BmSDK.FName BoneName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ComponentProperty: HitComponent
        /// </summary>
        public unsafe BmSDK.Engine.PrimitiveComponent HitComponent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: PhysMaterialUV
        /// </summary>
        public unsafe System.Numerics.Vector2 PhysMaterialUV
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
    }

    /// <summary>
    /// Enum: ENetRole
    /// </summary>
    public enum ENetRole : byte
    {
        ROLE_None = 0,
        ROLE_SimulatedProxy = 1,
        ROLE_AutonomousProxy = 2,
        ROLE_Authority = 3,
        ROLE_MAX = 4,
    }

    /// <summary>
    /// Struct: FTimerData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FTimerData
    {
        /// <summary>
        /// BoolProperty: bLoop
        /// </summary>
        public unsafe bool bLoop
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bPaused
        /// </summary>
        public unsafe bool bPaused
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: FuncName
        /// </summary>
        public unsafe BmSDK.FName FuncName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: Rate
        /// </summary>
        public unsafe float Rate
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: Count
        /// </summary>
        public unsafe float Count
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: TimerTimeDilation
        /// </summary>
        public unsafe float TimerTimeDilation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ObjectProperty: TimerObj
        /// </summary>
        public unsafe BmSDK.GameObject TimerObj
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Enum: AttackCounterTypes
    /// </summary>
    public enum AttackCounterTypes : byte
    {
        ACT_Counter = 0,
        ACT_Evade = 1,
        ACT_Stun = 2,
        ACT_Continuous = 3,
        ACT_MAX = 4,
    }

    /// <summary>
    /// Enum: EMoveDir
    /// </summary>
    public enum EMoveDir : byte
    {
        MD_Stationary = 0,
        MD_Forward = 1,
        MD_Backward = 2,
        MD_Left = 3,
        MD_Right = 4,
        MD_Up = 5,
        MD_Down = 6,
        MD_MAX = 7,
    }

    /// <summary>
    /// Enum: EPhysics
    /// </summary>
    public enum EPhysics : byte
    {
        PHYS_None = 0,
        PHYS_Walking = 1,
        PHYS_Falling = 2,
        PHYS_Swimming = 3,
        PHYS_Flying = 4,
        PHYS_Rotating = 5,
        PHYS_Projectile = 6,
        PHYS_Projectile_Custom = 7,
        PHYS_AirBorne = 8,
        PHYS_Interpolating = 9,
        PHYS_Spider = 10,
        PHYS_Ladder = 11,
        PHYS_RigidBody = 12,
        PHYS_SoftBody = 13,
        PHYS_NavMeshWalking = 14,
        PHYS_Floating = 15,
        PHYS_Ceiling = 16,
        PHYS_Unused = 17,
        PHYS_Custom = 18,
        PHYS_MAX = 19,
    }

    /// <summary>
    /// ArrayProperty: Components
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ActorComponent> Components
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ActorComponent>>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// ArrayProperty: AllComponents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ActorComponent> AllComponents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ActorComponent>>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// StructProperty: Location
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Location
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 72);

    /// <summary>
    /// StructProperty: Rotation
    /// </summary>
    public unsafe ref BmSDK.Rotator Rotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 84);

    /// <summary>
    /// FloatProperty: DrawScale
    /// </summary>
    public unsafe float DrawScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// StructProperty: DrawScale3D
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DrawScale3D
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 100);

    /// <summary>
    /// StructProperty: PrePivot
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PrePivot
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 112);

    /// <summary>
    /// StructProperty: EditorIconColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor EditorIconColor
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 124);

    /// <summary>
    /// StructProperty: DetachFence
    /// </summary>
    public unsafe ref BmSDK.GameObject.FRenderCommandFence DetachFence
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FRenderCommandFence>(Ptr + 128);

    /// <summary>
    /// ByteProperty: Physics
    /// </summary>
    public unsafe BmSDK.Engine.Actor.EPhysics Physics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.EPhysics>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ByteProperty: RemoteRole
    /// </summary>
    public unsafe BmSDK.Engine.Actor.ENetRole RemoteRole
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.ENetRole>(Ptr + 133); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 133); }
    }

    /// <summary>
    /// ByteProperty: Role
    /// </summary>
    public unsafe BmSDK.Engine.Actor.ENetRole Role
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.ENetRole>(Ptr + 134); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 134); }
    }

    /// <summary>
    /// ByteProperty: CollisionType
    /// </summary>
    public unsafe BmSDK.Engine.Actor.ECollisionType CollisionType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.ECollisionType>(Ptr + 135); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 135); }
    }

    /// <summary>
    /// ByteProperty: ReplicatedCollisionType
    /// </summary>
    public unsafe BmSDK.Engine.Actor.ECollisionType ReplicatedCollisionType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.ECollisionType>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// ByteProperty: TickGroup
    /// </summary>
    public unsafe BmSDK.GameObject.ETickingGroup TickGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.ETickingGroup>(Ptr + 137); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 137); }
    }

    /// <summary>
    /// ByteProperty: FramesTillInvestigateSightCheck
    /// </summary>
    public unsafe byte FramesTillInvestigateSightCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 138); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 138); }
    }

    /// <summary>
    /// ObjectProperty: Owner
    /// </summary>
    public unsafe BmSDK.Engine.Actor Owner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ObjectProperty: Base
    /// </summary>
    public unsafe BmSDK.Engine.Actor Base
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// ArrayProperty: Timers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor.FTimerData> Timers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor.FTimerData>>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: bStatic
    /// </summary>
    public unsafe bool bStatic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bHidden
    /// </summary>
    public unsafe bool bHidden
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bNoDelete
    /// </summary>
    public unsafe bool bNoDelete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bDeleteMe
    /// </summary>
    public unsafe bool bDeleteMe
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bTicked
    /// </summary>
    public unsafe bool bTicked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bOnlyOwnerSee
    /// </summary>
    public unsafe bool bOnlyOwnerSee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bTickIsDisabled
    /// </summary>
    public unsafe bool bTickIsDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bStasis
    /// </summary>
    public unsafe bool bStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bWorldGeometry
    /// </summary>
    public unsafe bool bWorldGeometry
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreRigidBodyPawns
    /// </summary>
    public unsafe bool bIgnoreRigidBodyPawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bOrientOnSlope
    /// </summary>
    public unsafe bool bOrientOnSlope
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreEncroachers
    /// </summary>
    public unsafe bool bIgnoreEncroachers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bPushedByEncroachers
    /// </summary>
    public unsafe bool bPushedByEncroachers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bDestroyedByInterpActor
    /// </summary>
    public unsafe bool bDestroyedByInterpActor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bRouteBeginPlayEvenIfStatic
    /// </summary>
    public unsafe bool bRouteBeginPlayEvenIfStatic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bIsMoving
    /// </summary>
    public unsafe bool bIsMoving
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysEncroachCheck
    /// </summary>
    public unsafe bool bAlwaysEncroachCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bHasAlternateTargetLocation
    /// </summary>
    public unsafe bool bHasAlternateTargetLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bCanStepUpOn
    /// </summary>
    public unsafe bool bCanStepUpOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bAICanStepUpOn
    /// </summary>
    public unsafe bool bAICanStepUpOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bNetTemporary
    /// </summary>
    public unsafe bool bNetTemporary
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bOnlyRelevantToOwner
    /// </summary>
    public unsafe bool bOnlyRelevantToOwner
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bNetDirty
    /// </summary>
    public unsafe bool bNetDirty
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysRelevant
    /// </summary>
    public unsafe bool bAlwaysRelevant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bReplicateInstigator
    /// </summary>
    public unsafe bool bReplicateInstigator
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bReplicateMovement
    /// </summary>
    public unsafe bool bReplicateMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bSkipActorPropertyReplication
    /// </summary>
    public unsafe bool bSkipActorPropertyReplication
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bUpdateSimulatedPosition
    /// </summary>
    public unsafe bool bUpdateSimulatedPosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bTearOff
    /// </summary>
    public unsafe bool bTearOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bOnlyDirtyReplication
    /// </summary>
    public unsafe bool bOnlyDirtyReplication
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bAllowFluidSurfaceInteraction
    /// </summary>
    public unsafe bool bAllowFluidSurfaceInteraction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bDemoRecording
    /// </summary>
    public unsafe bool bDemoRecording
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bDemoOwner
    /// </summary>
    public unsafe bool bDemoOwner
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bForceDemoRelevant
    /// </summary>
    public unsafe bool bForceDemoRelevant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bNetInitialRotation
    /// </summary>
    public unsafe bool bNetInitialRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bReplicateRigidBodyLocation
    /// </summary>
    public unsafe bool bReplicateRigidBodyLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bKillDuringLevelTransition
    /// </summary>
    public unsafe bool bKillDuringLevelTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bExchangedRoles
    /// </summary>
    public unsafe bool bExchangedRoles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bConsiderAllStaticMeshComponentsForStreaming
    /// </summary>
    public unsafe bool bConsiderAllStaticMeshComponentsForStreaming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bDebug
    /// </summary>
    public unsafe bool bDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bPostRenderIfNotVisible
    /// </summary>
    public unsafe bool bPostRenderIfNotVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bAllowActorThoughts
    /// </summary>
    public unsafe bool bAllowActorThoughts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bAllowTwoWayEncroach
    /// </summary>
    public unsafe bool bAllowTwoWayEncroach
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bForceNetUpdate
    /// </summary>
    public unsafe bool bForceNetUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bManualPerformPhysics
    /// </summary>
    public unsafe bool bManualPerformPhysics
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bHardAttach
    /// </summary>
    public unsafe bool bHardAttach
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bSnapAttach
    /// </summary>
    public unsafe bool bSnapAttach
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreBaseRotation
    /// </summary>
    public unsafe bool bIgnoreBaseRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bBasedActorsNoMove
    /// </summary>
    public unsafe bool bBasedActorsNoMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bShadowParented
    /// </summary>
    public unsafe bool bShadowParented
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bCanBeAdheredTo
    /// </summary>
    public unsafe bool bCanBeAdheredTo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bCanBeFrictionedTo
    /// </summary>
    public unsafe bool bCanBeFrictionedTo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bHurtEntry
    /// </summary>
    public unsafe bool bHurtEntry
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bGameRelevant
    /// </summary>
    public unsafe bool bGameRelevant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bMovable
    /// </summary>
    public unsafe bool bMovable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bDestroyInPainVolume
    /// </summary>
    public unsafe bool bDestroyInPainVolume
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bCanBeDamaged
    /// </summary>
    public unsafe bool bCanBeDamaged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bShouldBaseAtStartup
    /// </summary>
    public unsafe bool bShouldBaseAtStartup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bPendingDelete
    /// </summary>
    public unsafe bool bPendingDelete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bCanTeleport
    /// </summary>
    public unsafe bool bCanTeleport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysTick
    /// </summary>
    public unsafe bool bAlwaysTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bBlocksNavigation
    /// </summary>
    public unsafe bool bBlocksNavigation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: BlockRigidBody
    /// </summary>
    public unsafe bool BlockRigidBody
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bCollideWhenPlacing
    /// </summary>
    public unsafe bool bCollideWhenPlacing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bCollideActors
    /// </summary>
    public unsafe bool bCollideActors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bCollideWorld
    /// </summary>
    public unsafe bool bCollideWorld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bCollideComplex
    /// </summary>
    public unsafe bool bCollideComplex
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bBlockActors
    /// </summary>
    public unsafe bool bBlockActors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bProjTarget
    /// </summary>
    public unsafe bool bProjTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bBlocksTeleport
    /// </summary>
    public unsafe bool bBlocksTeleport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bForceZeroExtentCollision
    /// </summary>
    public unsafe bool bForceZeroExtentCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bPlayerMovementCheck
    /// </summary>
    public unsafe bool bPlayerMovementCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bMoveIgnoresDestruction
    /// </summary>
    public unsafe bool bMoveIgnoresDestruction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bForceNoVolumeTrace
    /// </summary>
    public unsafe bool bForceNoVolumeTrace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bNoEncroachCheck
    /// </summary>
    public unsafe bool bNoEncroachCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bCollideAsEncroacher
    /// </summary>
    public unsafe bool bCollideAsEncroacher
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bPhysRigidBodyOutOfWorldCheck
    /// </summary>
    public unsafe bool bPhysRigidBodyOutOfWorldCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bComponentOutsideWorld
    /// </summary>
    public unsafe bool bComponentOutsideWorld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bForceOctreeSNFilter
    /// </summary>
    public unsafe bool bForceOctreeSNFilter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bRigidBodyWasAwake
    /// </summary>
    public unsafe bool bRigidBodyWasAwake
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bCallRigidBodyWakeEvents
    /// </summary>
    public unsafe bool bCallRigidBodyWakeEvents
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bBounce
    /// </summary>
    public unsafe bool bBounce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bJustTeleported
    /// </summary>
    public unsafe bool bJustTeleported
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bNetInitial
    /// </summary>
    public unsafe bool bNetInitial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bNetOwner
    /// </summary>
    public unsafe bool bNetOwner
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bOwnerAlwaysReplicated
    /// </summary>
    public unsafe bool bOwnerAlwaysReplicated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bHiddenEd
    /// </summary>
    public unsafe bool bHiddenEd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bEditable
    /// </summary>
    public unsafe bool bEditable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bHiddenEdGroup
    /// </summary>
    public unsafe bool bHiddenEdGroup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bHiddenEdCustom
    /// </summary>
    public unsafe bool bHiddenEdCustom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bHiddenEdTemporary
    /// </summary>
    public unsafe bool bHiddenEdTemporary
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bHiddenEdLevel
    /// </summary>
    public unsafe bool bHiddenEdLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bHiddenEdScene
    /// </summary>
    public unsafe bool bHiddenEdScene
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bEdShouldSnap
    /// </summary>
    public unsafe bool bEdShouldSnap
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bTempEditor
    /// </summary>
    public unsafe bool bTempEditor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bPathColliding
    /// </summary>
    public unsafe bool bPathColliding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreStaticForPathBuilding
    /// </summary>
    public unsafe bool bIgnoreStaticForPathBuilding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bPathTemp
    /// </summary>
    public unsafe bool bPathTemp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bScriptInitialized
    /// </summary>
    public unsafe bool bScriptInitialized
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bLockLocation
    /// </summary>
    public unsafe bool bLockLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bForceAllowKismetModification
    /// </summary>
    public unsafe bool bForceAllowKismetModification
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bStripThisActorWhenCooking
    /// </summary>
    public unsafe bool bStripThisActorWhenCooking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bDonePostBeginPlay
    /// </summary>
    public unsafe bool bDonePostBeginPlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bBatmanCanClimb
    /// </summary>
    public unsafe bool bBatmanCanClimb
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bAllowSlopedEdges
    /// </summary>
    public unsafe bool bAllowSlopedEdges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bAllowCrevice
    /// </summary>
    public unsafe bool bAllowCrevice
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bGrappleToSlopedRoof
    /// </summary>
    public unsafe bool bGrappleToSlopedRoof
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: CanAlwaysLinkEdges
    /// </summary>
    public unsafe bool CanAlwaysLinkEdges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bDisallowShimmy
    /// </summary>
    public unsafe bool bDisallowShimmy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bValidLineLauncherTarget
    /// </summary>
    public unsafe bool bValidLineLauncherTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bValidGelTarget
    /// </summary>
    public unsafe bool bValidGelTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bForceHiddenInXray
    /// </summary>
    public unsafe bool bForceHiddenInXray
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bCurrentInvestigateHightlighted
    /// </summary>
    public unsafe bool bCurrentInvestigateHightlighted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: CachedInvestigateSightCheck
    /// </summary>
    public unsafe bool CachedInvestigateSightCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bDebugEffectIsRelevant
    /// </summary>
    public unsafe bool bDebugEffectIsRelevant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bLoadIfPhysXLevel0
    /// </summary>
    public unsafe bool bLoadIfPhysXLevel0
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bLoadIfPhysXLevel1
    /// </summary>
    public unsafe bool bLoadIfPhysXLevel1
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bLoadIfPhysXLevel2
    /// </summary>
    public unsafe bool bLoadIfPhysXLevel2
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// StrProperty: LastEdit
    /// </summary>
    public unsafe BmSDK.FString LastEdit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// ObjectProperty: Instigator
    /// </summary>
    public unsafe BmSDK.Engine.Pawn Instigator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ObjectProperty: WorldInfo
    /// </summary>
    public unsafe BmSDK.Engine.WorldInfo WorldInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.WorldInfo>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// FloatProperty: LifeSpan
    /// </summary>
    public unsafe float LifeSpan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// StructProperty: CanTraceActorBlockedTypes
    /// </summary>
    public unsafe ref BmSDK.Engine.Actor.FBlockingVolumeTypesContainer CanTraceActorBlockedTypes
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.Actor.FBlockingVolumeTypesContainer>(Ptr + 200);

    /// <summary>
    /// FloatProperty: LastRenderTime
    /// </summary>
    public unsafe float LastRenderTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// NameProperty: Tag
    /// </summary>
    public unsafe BmSDK.FName Tag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// NameProperty: Group
    /// </summary>
    public unsafe BmSDK.FName Group
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// StructProperty: HiddenEditorViews
    /// </summary>
    public unsafe ulong HiddenEditorViews
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<ulong>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// ArrayProperty: Touching
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> Touching
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// ArrayProperty: Children
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> Children
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// FloatProperty: LatentFloat
    /// </summary>
    public unsafe float LatentFloat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// ObjectProperty: LatentSeqNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence LatentSeqNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ObjectProperty: PhysicsVolume
    /// </summary>
    public unsafe BmSDK.Engine.PhysicsVolume PhysicsVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicsVolume>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// StructProperty: Velocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Velocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 268);

    /// <summary>
    /// StructProperty: Acceleration
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Acceleration
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 280);

    /// <summary>
    /// StructProperty: AngularVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AngularVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 292);

    /// <summary>
    /// ComponentProperty: BaseSkelComponent
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent BaseSkelComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// NameProperty: BaseBoneName
    /// </summary>
    public unsafe BmSDK.FName BaseBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// ArrayProperty: Attached
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> Attached
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// StructProperty: RelativeLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RelativeLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 328);

    /// <summary>
    /// StructProperty: RelativeRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator RelativeRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 340);

    /// <summary>
    /// ComponentProperty: CollisionComponent
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent CollisionComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// IntProperty: OverlapTag
    /// </summary>
    public unsafe int OverlapTag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// StructProperty: RotationRate
    /// </summary>
    public unsafe ref BmSDK.Rotator RotationRate
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 360);

    /// <summary>
    /// ArrayProperty: SupportedEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> SupportedEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// ArrayProperty: GeneratedEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SequenceEvent> GeneratedEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SequenceEvent>>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ArrayProperty: LatentActions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SeqAct_Latent> LatentActions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SeqAct_Latent>>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// FloatProperty: InvestigationMaxDistance
    /// </summary>
    public unsafe float InvestigationMaxDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// FloatProperty: InvestigationPriorityOverride
    /// </summary>
    public unsafe float InvestigationPriorityOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// StructProperty: InvestigateOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 InvestigateOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 416);

    /// <summary>
    /// StrProperty: InvestigationInfoTitle
    /// </summary>
    public unsafe BmSDK.FString InvestigationInfoTitle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// StrProperty: InvestigationInfo
    /// </summary>
    public unsafe BmSDK.FString InvestigationInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// Struct: FBlockingVolumeTypesContainer
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial record struct FBlockingVolumeTypesContainer
    {
        /// <summary>
        /// BoolProperty: AllActors
        /// </summary>
        public unsafe bool AllActors
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Player
        /// </summary>
        public unsafe bool Player
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Enemies
        /// </summary>
        public unsafe bool Enemies
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Friendlies
        /// </summary>
        public unsafe bool Friendlies
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Physics
        /// </summary>
        public unsafe bool Physics
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Batarang
        /// </summary>
        public unsafe bool Batarang
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: BatClaw
        /// </summary>
        public unsafe bool BatClaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 64) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: LineLauncher
        /// </summary>
        public unsafe bool LineLauncher
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 128) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: GrappleGun
        /// </summary>
        public unsafe bool GrappleGun
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 256) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Camera
        /// </summary>
        public unsafe bool Camera
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 512) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: WeaponsOrLOS
        /// </summary>
        public unsafe bool WeaponsOrLOS
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1024) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: MagneticObjects
        /// </summary>
        public unsafe bool MagneticObjects
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2048) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: ClimbOnly
        /// </summary>
        public unsafe bool ClimbOnly
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 4096) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: IgnoreWallPounces
        /// </summary>
        public unsafe bool IgnoreWallPounces
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 8192) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: FreezeGrenades
        /// </summary>
        public unsafe bool FreezeGrenades
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 16384) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: SmokeBomb
        /// </summary>
        public unsafe bool SmokeBomb
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 32768) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: REC
        /// </summary>
        public unsafe bool REC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 65536) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: GlueGrenades
        /// </summary>
        public unsafe bool GlueGrenades
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 131072) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: RemoteClaw
        /// </summary>
        public unsafe bool RemoteClaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 262144) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FThought
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FThought
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
        /// ByteProperty: Red
        /// </summary>
        public unsafe byte Red
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ByteProperty: Green
        /// </summary>
        public unsafe byte Green
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 13); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13); }; }
        }

        /// <summary>
        /// ByteProperty: Blue
        /// </summary>
        public unsafe byte Blue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 14); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 14); }; }
        }

        /// <summary>
        /// ByteProperty: Alpha
        /// </summary>
        public unsafe byte Alpha
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 15); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 15); }; }
        }
    }
}

/// <summary>
/// The static native functions of Actor, callable on an instance. A static native may read the object it runs on, and the static form runs it on the class default object, which has no world.
/// </summary>
public static class ActorStatics
{
    private static BmSDK.Function __fn_CancelAudioCallbacks;
    /// <summary>
    /// Function: CancelAudioCallbacks, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void CancelAudioCallbacks(this BmSDK.Engine.Actor self)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelAudioCallbacks, "Engine.Actor.CancelAudioCallbacks");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_GetPackageGuid;
    /// <summary>
    /// Function: GetPackageGuid, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static BmSDK.GameObject.FGuid GetPackageGuid(this BmSDK.Engine.Actor self, BmSDK.FName PackageName)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPackageGuid, "Engine.Actor.GetPackageGuid");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FGuid>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FlushDebugStrings;
    /// <summary>
    /// Function: FlushDebugStrings, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void FlushDebugStrings(this BmSDK.Engine.Actor self)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlushDebugStrings, "Engine.Actor.FlushDebugStrings");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawDebugFrustrum;
    /// <summary>
    /// Function: DrawDebugFrustrum, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void DrawDebugFrustrum(this BmSDK.Engine.Actor self, in BmSDK.GameObject.FMatrix FrustumToWorld, byte R, byte G, byte B, bool bPersistentLines = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugFrustrum, "Engine.Actor.DrawDebugFrustrum");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FrustumToWorld, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 65);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 66);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 68);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawDebugString;
    /// <summary>
    /// Function: DrawDebugString, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void DrawDebugString(this BmSDK.Engine.Actor self, System.Numerics.Vector3 TextLocation, BmSDK.FString Text, BmSDK.Engine.Actor TestBaseActor = default, BmSDK.GameObject.FColor TextColor = default, float Duration = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugString, "Engine.Actor.DrawDebugString");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TextLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestBaseActor, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TextColor, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawDebugCone;
    /// <summary>
    /// Function: DrawDebugCone, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void DrawDebugCone(this BmSDK.Engine.Actor self, System.Numerics.Vector3 Origin, System.Numerics.Vector3 Direction, float Length, float AngleWidth, float AngleHeight, int NumSides, BmSDK.GameObject.FColor DrawColor, bool bPersistentLines = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugCone, "Engine.Actor.DrawDebugCone");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Origin, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Length, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AngleWidth, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AngleHeight, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumSides, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DrawColor, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 44);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawDebugCylinder;
    /// <summary>
    /// Function: DrawDebugCylinder, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void DrawDebugCylinder(this BmSDK.Engine.Actor self, System.Numerics.Vector3 Start, System.Numerics.Vector3 End, float Radius, int Segments, byte R, byte G, byte B, bool bPersistentLines = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugCylinder, "Engine.Actor.DrawDebugCylinder");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Segments, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 33);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 34);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawDebugSphere;
    /// <summary>
    /// Function: DrawDebugSphere, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void DrawDebugSphere(this BmSDK.Engine.Actor self, System.Numerics.Vector3 Center, float Radius, int Segments, byte R, byte G, byte B, bool bPersistentLines = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugSphere, "Engine.Actor.DrawDebugSphere");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Center, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Segments, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 21);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 22);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawDebugCoordinateSystem;
    /// <summary>
    /// Function: DrawDebugCoordinateSystem, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void DrawDebugCoordinateSystem(this BmSDK.Engine.Actor self, System.Numerics.Vector3 AxisLoc, BmSDK.Rotator AxisRot, float Scale, bool bPersistentLines = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugCoordinateSystem, "Engine.Actor.DrawDebugCoordinateSystem");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AxisLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AxisRot, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scale, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawDebugStar;
    /// <summary>
    /// Function: DrawDebugStar, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void DrawDebugStar(this BmSDK.Engine.Actor self, System.Numerics.Vector3 Position, float Size, byte R, byte G, byte B, bool bPersistentLines = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugStar, "Engine.Actor.DrawDebugStar");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Size, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 17);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 18);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawDebugBounds;
    /// <summary>
    /// Function: DrawDebugBounds, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void DrawDebugBounds(this BmSDK.Engine.Actor self, System.Numerics.Vector3 AxisLoc, BmSDK.Rotator AxisRot, BmSDK.GameObject.FBox Bounds, byte R, byte G, byte B, bool bPersistentLines = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugBounds, "Engine.Actor.DrawDebugBounds");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AxisLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AxisRot, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Bounds, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 53);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 54);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 56);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawDebugBox;
    /// <summary>
    /// Function: DrawDebugBox, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void DrawDebugBox(this BmSDK.Engine.Actor self, System.Numerics.Vector3 Center, System.Numerics.Vector3 Extent, byte R, byte G, byte B, bool bPersistentLines = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugBox, "Engine.Actor.DrawDebugBox");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Center, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 25);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 26);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawDebugPoint;
    /// <summary>
    /// Function: DrawDebugPoint, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void DrawDebugPoint(this BmSDK.Engine.Actor self, System.Numerics.Vector3 Position, float Size, BmSDK.GameObject.FLinearColor PointColor, bool bPersistentLines = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugPoint, "Engine.Actor.DrawDebugPoint");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Size, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointColor, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawDebugWall;
    /// <summary>
    /// Function: DrawDebugWall, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void DrawDebugWall(this BmSDK.Engine.Actor self, System.Numerics.Vector3 LineStart, System.Numerics.Vector3 LineEnd, byte R, byte G, byte B, bool bPersistentLines = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugWall, "Engine.Actor.DrawDebugWall");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineStart, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineEnd, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 25);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 26);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DrawDebugLine;
    /// <summary>
    /// Function: DrawDebugLine, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void DrawDebugLine(this BmSDK.Engine.Actor self, System.Numerics.Vector3 LineStart, System.Numerics.Vector3 LineEnd, byte R, byte G, byte B, bool bPersistentLines = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugLine, "Engine.Actor.DrawDebugLine");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineStart, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineEnd, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 25);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 26);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistentLines, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_FlushPersistentDebugLines;
    /// <summary>
    /// Function: FlushPersistentDebugLines, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void FlushPersistentDebugLines(this BmSDK.Engine.Actor self)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlushPersistentDebugLines, "Engine.Actor.FlushPersistentDebugLines");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_GetBasedPosition;
    /// <summary>
    /// Function: GetBasedPosition, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static System.Numerics.Vector3 GetBasedPosition(this BmSDK.Engine.Actor self, BmSDK.Engine.Actor.FBasedPosition BP)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBasedPosition, "Engine.Actor.GetBasedPosition");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BP, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 52);
    }

    private static BmSDK.Function __fn_SetBasedPosition;
    /// <summary>
    /// Function: SetBasedPosition, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void SetBasedPosition(this BmSDK.Engine.Actor self, out BmSDK.Engine.Actor.FBasedPosition BP, System.Numerics.Vector3 pos, BmSDK.Engine.Actor ForcedBase = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBasedPosition, "Engine.Actor.SetBasedPosition");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BP);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BP, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForcedBase, paramsPtr + 64);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BP = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FBasedPosition>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_BP2Vect;
    /// <summary>
    /// Function: BP2Vect, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static System.Numerics.Vector3 BP2Vect(this BmSDK.Engine.Actor self, BmSDK.Engine.Actor.FBasedPosition BP)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BP2Vect, "Engine.Actor.BP2Vect");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BP, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 52);
    }

    private static BmSDK.Function __fn_Vect2BP;
    /// <summary>
    /// Function: Vect2BP, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void Vect2BP(this BmSDK.Engine.Actor self, out BmSDK.Engine.Actor.FBasedPosition BP, System.Numerics.Vector3 pos, BmSDK.Engine.Actor ForcedBase = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Vect2BP, "Engine.Actor.Vect2BP");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out BP);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BP, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForcedBase, paramsPtr + 64);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        BP = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor.FBasedPosition>(paramsPtr + 0);
        return;
    }
}
