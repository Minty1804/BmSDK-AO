#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.SDEngine;

/// <summary>
/// ABSTRACT Class: SDFuncTestEvent_Button<br/>
/// (size = 96)
/// (flags = 134250643)
/// </summary>
public partial class SDFuncTestEvent_Button : BmSDK.SDEngine.SDFunctionalTestEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "SDEngine.SDFuncTestEvent_Button", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as SDFuncTestEvent_Button.
    /// </summary>
    public static SDFuncTestEvent_Button DefaultObject => (SDFuncTestEvent_Button)StaticClass().DefaultObject;

    internal SDFuncTestEvent_Button() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SDFuncTestEvent_Button(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDFuncTestEvent_Button>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDFuncTestEvent_Button>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDFuncTestEvent_Button>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDFuncTestEvent_Button>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDFuncTestEvent_Button>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDFuncTestEvent_Button>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDFuncTestEvent_Button>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDFuncTestEvent_Button>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetTriggerFlip;
    /// <summary>
    /// Function: GetTriggerFlip
    /// </summary>
    public unsafe virtual bool GetTriggerFlip(BmSDK.SDEngine.SDPlayerController PlayerOwner)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTriggerFlip, "SDEngine.SDFuncTestEvent_Button.GetTriggerFlip");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_Execute;
    /// <summary>
    /// Function: Execute
    /// </summary>
    public unsafe override void Execute()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Execute, "SDEngine.SDFuncTestEvent_Button.Execute");
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

    private static BmSDK.Function __fn_GetPlayerInput;
    /// <summary>
    /// Function: GetPlayerInput
    /// </summary>
    public unsafe virtual void GetPlayerInput()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerInput, "SDEngine.SDFuncTestEvent_Button.GetPlayerInput");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPlayerInputDelegate;
    /// <summary>
    /// Function: GetPlayerInputDelegate
    /// </summary>
    public unsafe virtual BmSDK.Engine.PlayerInput GetPlayerInputDelegate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerInputDelegate, "SDEngine.SDFuncTestEvent_Button.GetPlayerInputDelegate");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PlayerInput>(paramsPtr + 0);
    }

    /// <summary>
    /// ObjectProperty: PlayerInput
    /// </summary>
    public unsafe BmSDK.Engine.PlayerInput PlayerInput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerInput>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// ByteProperty: InputButton
    /// </summary>
    public unsafe BmSDK.SDEngine.SDFuncTestEvent_Button.EInputButton InputButton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.SDEngine.SDFuncTestEvent_Button.EInputButton>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// ByteProperty: InputEvent
    /// </summary>
    public unsafe BmSDK.GameObject.EInputEvent InputEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.EInputEvent>(Ptr + 65); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 65); }
    }

    /// <summary>
    /// DelegateProperty: GetInputFunc
    /// </summary>
    public unsafe System.IntPtr GetInputFunc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: bFixedPS3Triggers
    /// </summary>
    public unsafe bool bFixedPS3Triggers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 80); }
    }

    /// <summary>
    /// DelegateProperty: __GetPlayerInputDelegate__Delegate
    /// </summary>
    public unsafe System.IntPtr __GetPlayerInputDelegate__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// Enum: EInputButton
    /// </summary>
    public enum EInputButton : byte
    {
        INPUT_ButtonA = 0,
        INPUT_ButtonX = 1,
        INPUT_ButtonY = 2,
        INPUT_ButtonB = 3,
        INPUT_LeftShoulder = 4,
        INPUT_RightShoulder = 5,
        INPUT_LeftTrigger = 6,
        INPUT_RightTrigger = 7,
        INPUT_DPad_Up = 8,
        INPUT_DPad_Down = 9,
        INPUT_DPad_Left = 10,
        INPUT_DPad_Right = 11,
        INPUT_Back = 12,
        INPUT_Start = 13,
        INPUT_ClickLeftStick = 14,
        INPUT_ClickRightStick = 15,
        INPUT_LMB = 16,
        INPUT_RMB = 17,
        INPUT_MMB = 18,
        INPUT_W = 19,
        INPUT_A = 20,
        INPUT_S = 21,
        INPUT_D = 22,
        INPUT_LShift = 23,
        INPUT_RShift = 24,
        INPUT_Space = 25,
        INPUT_LCtrl = 26,
        INPUT_RCtrl = 27,
        INPUT_C = 28,
        INPUT_0 = 29,
        INPUT_1 = 30,
        INPUT_2 = 31,
        INPUT_3 = 32,
        INPUT_4 = 33,
        INPUT_5 = 34,
        INPUT_6 = 35,
        INPUT_7 = 36,
        INPUT_8 = 37,
        INPUT_9 = 38,
        INPUT_F = 39,
        INPUT_K = 40,
        INPUT_F1 = 41,
        INPUT_F2 = 42,
        INPUT_F3 = 43,
        INPUT_F4 = 44,
        INPUT_F5 = 45,
        INPUT_MAX = 46,
    }
}
