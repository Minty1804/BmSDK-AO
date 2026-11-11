#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.SDEngine;

/// <summary>
/// Class: SDUIHUDMessageLog<br/>
/// (size = 236)
/// (flags = 32786)
/// </summary>
public partial class SDUIHUDMessageLog : BmSDK.SDEngine.SDUIHUDComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "SDEngine.SDUIHUDMessageLog", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as SDUIHUDMessageLog.
    /// </summary>
    public static SDUIHUDMessageLog DefaultObject => (SDUIHUDMessageLog)StaticClass().DefaultObject;

    internal SDUIHUDMessageLog() { }

    /// <summary>
    /// Constructs a new SDUIHUDMessageLog
    /// </summary>
    public SDUIHUDMessageLog(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SDUIHUDMessageLog Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SDUIHUDMessageLog(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDUIHUDMessageLog>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDUIHUDMessageLog>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDUIHUDMessageLog>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDUIHUDMessageLog>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDUIHUDMessageLog>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDUIHUDMessageLog>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDUIHUDMessageLog>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDUIHUDMessageLog>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetHTMLColourFromColor;
    /// <summary>
    /// Function: GetHTMLColourFromColor
    /// </summary>
    public unsafe virtual BmSDK.FString GetHTMLColourFromColor(BmSDK.GameObject.FColor InColour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHTMLColourFromColor, "SDEngine.SDUIHUDMessageLog.GetHTMLColourFromColor");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InColour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_MessageHUDParentHideAnimFinished;
    /// <summary>
    /// Function: MessageHUDParentHideAnimFinished
    /// </summary>
    public unsafe virtual void MessageHUDParentHideAnimFinished()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MessageHUDParentHideAnimFinished, "SDEngine.SDUIHUDMessageLog.MessageHUDParentHideAnimFinished");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MessageHUDParentShowAnimFinished;
    /// <summary>
    /// Function: MessageHUDParentShowAnimFinished
    /// </summary>
    public unsafe virtual void MessageHUDParentShowAnimFinished()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MessageHUDParentShowAnimFinished, "SDEngine.SDUIHUDMessageLog.MessageHUDParentShowAnimFinished");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerMessageParentExpireAnim;
    /// <summary>
    /// Function: TriggerMessageParentExpireAnim
    /// </summary>
    public unsafe virtual void TriggerMessageParentExpireAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerMessageParentExpireAnim, "SDEngine.SDUIHUDMessageLog.TriggerMessageParentExpireAnim");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerMessageParentShowAnim;
    /// <summary>
    /// Function: TriggerMessageParentShowAnim
    /// </summary>
    public unsafe virtual void TriggerMessageParentShowAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerMessageParentShowAnim, "SDEngine.SDUIHUDMessageLog.TriggerMessageParentShowAnim");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerAnimationOnActiveMessageText;
    /// <summary>
    /// Function: TriggerAnimationOnActiveMessageText
    /// </summary>
    public unsafe virtual void TriggerAnimationOnActiveMessageText(int Idx, BmSDK.FString AnimName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerAnimationOnActiveMessageText, "SDEngine.SDUIHUDMessageLog.TriggerAnimationOnActiveMessageText");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Idx, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateHUDComponent;
    /// <summary>
    /// Function: UpdateHUDComponent
    /// </summary>
    public unsafe override void UpdateHUDComponent(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateHUDComponent, "SDEngine.SDUIHUDMessageLog.UpdateHUDComponent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateHUDMessageLog;
    /// <summary>
    /// Function: UpdateHUDMessageLog
    /// </summary>
    public unsafe virtual void UpdateHUDMessageLog(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateHUDMessageLog, "SDEngine.SDUIHUDMessageLog.UpdateHUDMessageLog");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddNewHUDMessageToLog;
    /// <summary>
    /// Function: AddNewHUDMessageToLog
    /// </summary>
    public unsafe virtual void AddNewHUDMessageToLog(BmSDK.FString NewMsg, BmSDK.FString MsgType, int ExtIndex = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddNewHUDMessageToLog, "SDEngine.SDUIHUDMessageLog.AddNewHUDMessageToLog");
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMsg, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MsgType, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtIndex, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveHUDMessageOnAnimationEnd;
    /// <summary>
    /// Function: RemoveHUDMessageOnAnimationEnd
    /// </summary>
    public unsafe virtual int RemoveHUDMessageOnAnimationEnd(out int RemovedExtIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveHUDMessageOnAnimationEnd, "SDEngine.SDUIHUDMessageLog.RemoveHUDMessageOnAnimationEnd");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out RemovedExtIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemovedExtIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        RemovedExtIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_RemoveMessage;
    /// <summary>
    /// Function: RemoveMessage
    /// </summary>
    public unsafe virtual void RemoveMessage(int Idx, bool PlayHideAnim)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveMessage, "SDEngine.SDUIHUDMessageLog.RemoveMessage");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Idx, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayHideAnim, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateNewMessageRow;
    /// <summary>
    /// Function: CreateNewMessageRow
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject CreateNewMessageRow(int Idx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateNewMessageRow, "SDEngine.SDUIHUDMessageLog.CreateNewMessageRow");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Idx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AddNewMessageRow;
    /// <summary>
    /// Function: AddNewMessageRow
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject AddNewMessageRow(int Idx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddNewMessageRow, "SDEngine.SDUIHUDMessageLog.AddNewMessageRow");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Idx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_InitialiseMessageHUD;
    /// <summary>
    /// Function: InitialiseMessageHUD
    /// </summary>
    public unsafe virtual void InitialiseMessageHUD(BmSDK.GFxUI.GFxObject LogParentMC, BmSDK.SDEngine.SDUIHUDPlayer ParentHUD, BmSDK.FString LogMessageMovieName, int MaxMessages, float MaxMessageLife, float YBuffer, bool playExpireAnims, BmSDK.SDEngine.SDUIHUDMessageLog.EHUDMsgShiftDir SDirection, bool AnimateParent = default, float MessageParentTimeout = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialiseMessageHUD, "SDEngine.SDUIHUDMessageLog.InitialiseMessageHUD");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LogParentMC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParentHUD, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LogMessageMovieName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxMessages, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxMessageLife, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(YBuffer, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(playExpireAnims, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SDirection, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimateParent, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MessageParentTimeout, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ArrayProperty: ActiveMessages
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.SDEngine.SDUIHUDMessageLog.FSDUIHUDMessageRow> ActiveMessages
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.SDEngine.SDUIHUDMessageLog.FSDUIHUDMessageRow>>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ArrayProperty: FreeMessages
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.SDEngine.SDUIHUDMessageLog.FSDUIHUDMessageRow> FreeMessages
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.SDEngine.SDUIHUDMessageLog.FSDUIHUDMessageRow>>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// FloatProperty: MessageHeight
    /// </summary>
    public unsafe float MessageHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// FloatProperty: MessageYBuffer
    /// </summary>
    public unsafe float MessageYBuffer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// FloatProperty: MessageLife
    /// </summary>
    public unsafe float MessageLife
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// StrProperty: MessageMCName
    /// </summary>
    public unsafe BmSDK.FString MessageMCName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// BoolProperty: PlayMsgExpireAnim
    /// </summary>
    public unsafe bool PlayMsgExpireAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 212); }
    }

    /// <summary>
    /// BoolProperty: KeepOldMessages
    /// </summary>
    public unsafe bool KeepOldMessages
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 212); }
    }

    /// <summary>
    /// ByteProperty: ScrollDir
    /// </summary>
    public unsafe BmSDK.SDEngine.SDUIHUDMessageLog.EHUDMsgShiftDir ScrollDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.SDEngine.SDUIHUDMessageLog.EHUDMsgShiftDir>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// IntProperty: MaxNumMessages
    /// </summary>
    public unsafe int MaxNumMessages
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// StructProperty: MessageHUDParentAnimData
    /// </summary>
    public unsafe ref BmSDK.SDEngine.SDUIHUDMessageLog.FSDUIHUDMessageParentLifeData MessageHUDParentAnimData
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.SDEngine.SDUIHUDMessageLog.FSDUIHUDMessageParentLifeData>(Ptr + 224);

    /// <summary>
    /// Enum: EHUDMsgShiftDir
    /// </summary>
    public enum EHUDMsgShiftDir : byte
    {
        HUDMsgShiftUp = 0,
        HUDMsgShiftDown = 1,
        EHUDMsgShiftDir_MAX = 2,
    }

    /// <summary>
    /// Struct: FSDUIHUDMessageParentLifeData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FSDUIHUDMessageParentLifeData
    {
        /// <summary>
        /// FloatProperty: MaxMessageParentLife
        /// </summary>
        public unsafe float MaxMessageParentLife
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: CurrMessageParentLife
        /// </summary>
        public unsafe float CurrMessageParentLife
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: ParentHasTransitonAnimations
        /// </summary>
        public unsafe bool ParentHasTransitonAnimations
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: MessageParentVisible
        /// </summary>
        public unsafe bool MessageParentVisible
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: MessageParentFadeAnimActive
        /// </summary>
        public unsafe bool MessageParentFadeAnimActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: MessageParentShowAnimActive
        /// </summary>
        public unsafe bool MessageParentShowAnimActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FSDUIHUDMessageRow
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FSDUIHUDMessageRow
    {
        /// <summary>
        /// ObjectProperty: MessageRowMC
        /// </summary>
        public unsafe BmSDK.GFxUI.GFxObject MessageRowMC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: MessageRowTextField
        /// </summary>
        public unsafe BmSDK.GFxUI.GFxObject MessageRowTextField
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: MessageRowY
        /// </summary>
        public unsafe int MessageRowY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StrProperty: MessageStrType
        /// </summary>
        public unsafe BmSDK.FString MessageStrType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: CurrMessageLife
        /// </summary>
        public unsafe float CurrMessageLife
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// BoolProperty: ExpireAnimActive
        /// </summary>
        public unsafe bool ExpireAnimActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// IntProperty: ExternalIndex
        /// </summary>
        public unsafe int ExternalIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
    }
}
