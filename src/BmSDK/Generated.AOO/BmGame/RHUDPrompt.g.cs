#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHUDPrompt<br/>
/// (size = 216)
/// (flags = 134250642)
/// </summary>
public partial class RHUDPrompt : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHUDPrompt", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RHUDPrompt.
    /// </summary>
    public static RHUDPrompt DefaultObject => (RHUDPrompt)StaticClass().DefaultObject;

    internal RHUDPrompt() { }

    /// <summary>
    /// Constructs a new RHUDPrompt
    /// </summary>
    public RHUDPrompt(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHUDPrompt Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHUDPrompt(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHUDPrompt>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHUDPrompt>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHUDPrompt>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHUDPrompt>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHUDPrompt>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHUDPrompt>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHUDPrompt>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHUDPrompt>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ControlSchemeKeyToControlIcon;
    /// <summary>
    /// Function: ControlSchemeKeyToControlIcon
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHUDPrompt.EControlIcon ControlSchemeKeyToControlIcon(BmSDK.BmGame.GDControlSchemes.EControlSchemeKey Key)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ControlSchemeKeyToControlIcon, "BmGame.RHUDPrompt.ControlSchemeKeyToControlIcon");
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHUDPrompt.EControlIcon>(paramsPtr + 1);
    }

    private static BmSDK.Function __fn_SetHighPriorityInstructions;
    /// <summary>
    /// Function: SetHighPriorityInstructions
    /// </summary>
    public unsafe virtual void SetHighPriorityInstructions(BmSDK.FString NewInstructions)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHighPriorityInstructions, "BmGame.RHUDPrompt.SetHighPriorityInstructions");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewInstructions, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInstructions;
    /// <summary>
    /// Function: SetInstructions
    /// </summary>
    public unsafe virtual bool SetInstructions(BmSDK.FString NewInstructions, bool CanOverrideEmptyKismet = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInstructions, "BmGame.RHUDPrompt.SetInstructions");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewInstructions, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CanOverrideEmptyKismet, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetLines;
    /// <summary>
    /// Function: GetLines
    /// </summary>
    public unsafe virtual void GetLines()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLines, "BmGame.RHUDPrompt.GetLines");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetOverridePrompt;
    /// <summary>
    /// Function: SetOverridePrompt
    /// </summary>
    public unsafe virtual void SetOverridePrompt(BmSDK.FString Text, BmSDK.BmGame.RHUDPrompt.EControlIcon Icon = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOverridePrompt, "BmGame.RHUDPrompt.SetOverridePrompt");
        byte* paramsPtr = stackalloc byte[29];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Icon, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawHUD;
    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe virtual void DrawHUD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawHUD, "BmGame.RHUDPrompt.DrawHUD");
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

    private static BmSDK.Function __fn_ResetLines;
    /// <summary>
    /// Function: ResetLines
    /// </summary>
    public unsafe virtual void ResetLines()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetLines, "BmGame.RHUDPrompt.ResetLines");
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

    private static BmSDK.Function __fn_AddLine;
    /// <summary>
    /// Function: AddLine
    /// </summary>
    public unsafe virtual void AddLine(BmSDK.FString Text, BmSDK.BmGame.RHUDPrompt.EControlIcon Icon = default, bool Main = default, bool bHammerButton = default, bool bAddHighlight = default, BmSDK.FString ImageName = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLine, "BmGame.RHUDPrompt.AddLine");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Icon, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Main, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHammerButton, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAddHighlight, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImageName, paramsPtr + 28);
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

    private static BmSDK.Function __fn_HelpLinesMatch;
    /// <summary>
    /// Function: HelpLinesMatch
    /// </summary>
    public unsafe virtual bool HelpLinesMatch(out BmSDK.BmGame.RHUDPrompt.FHelpLine HL1, out BmSDK.BmGame.RHUDPrompt.FHelpLine HL2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HelpLinesMatch, "BmGame.RHUDPrompt.HelpLinesMatch");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HL1 = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHUDPrompt.FHelpLine>(paramsPtr + 0);
        HL2 = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RHUDPrompt.FHelpLine>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 64);
    }

    private static BmSDK.Function __fn_AddLocLineWithImage;
    /// <summary>
    /// Function: AddLocLineWithImage
    /// </summary>
    public unsafe virtual void AddLocLineWithImage(BmSDK.FString Text, BmSDK.FString ImageName, BmSDK.BmGame.RHUDPrompt.EControlIcon Icon = default, bool Main = default, bool bHammerButton = default, bool bAddHighlight = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLocLineWithImage, "BmGame.RHUDPrompt.AddLocLineWithImage");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImageName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Icon, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Main, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHammerButton, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAddHighlight, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddLineWithImage;
    /// <summary>
    /// Function: AddLineWithImage
    /// </summary>
    public unsafe virtual void AddLineWithImage(BmSDK.FString Text, BmSDK.FString ImageName, BmSDK.BmGame.RHUDPrompt.EControlIcon Icon = default, bool Main = default, bool bHammerButton = default, bool bAddHighlight = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLineWithImage, "BmGame.RHUDPrompt.AddLineWithImage");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImageName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Icon, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Main, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHammerButton, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAddHighlight, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddTutorialLineLoc;
    /// <summary>
    /// Function: AddTutorialLineLoc
    /// </summary>
    public unsafe virtual void AddTutorialLineLoc(BmSDK.FString Text, BmSDK.BmGame.RHUDPrompt.EControlIcon Icon = default, bool Main = default, bool bHammerButton = default, bool bAddHighlight = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddTutorialLineLoc, "BmGame.RHUDPrompt.AddTutorialLineLoc");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Icon, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Main, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHammerButton, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAddHighlight, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddGadgetLineLoc;
    /// <summary>
    /// Function: AddGadgetLineLoc
    /// </summary>
    public unsafe virtual void AddGadgetLineLoc(BmSDK.FString Text, BmSDK.BmGame.RHUDPrompt.EControlIcon Icon = default, bool Main = default, bool bHammerButton = default, bool bAddHighlight = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddGadgetLineLoc, "BmGame.RHUDPrompt.AddGadgetLineLoc");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Icon, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Main, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHammerButton, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAddHighlight, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddLineLoc;
    /// <summary>
    /// Function: AddLineLoc
    /// </summary>
    public unsafe virtual void AddLineLoc(BmSDK.FString Text, BmSDK.BmGame.RHUDPrompt.EControlIcon Icon = default, bool Main = default, bool bHammerButton = default, bool bAddHighlight = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLineLoc, "BmGame.RHUDPrompt.AddLineLoc");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Text, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Icon, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Main, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHammerButton, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAddHighlight, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: PC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController PC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bOverridePromptIsActive
    /// </summary>
    public unsafe bool bOverridePromptIsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bOverridePromptShouldBeActive
    /// </summary>
    public unsafe bool bOverridePromptShouldBeActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// StructProperty: OverridePrompt
    /// </summary>
    public unsafe ref BmSDK.BmGame.RHUDPrompt.FHelpLine OverridePrompt
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RHUDPrompt.FHelpLine>(Ptr + 56);

    /// <summary>
    /// StructProperty: MainLine
    /// </summary>
    public unsafe ref BmSDK.BmGame.RHUDPrompt.FHelpLine MainLine
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RHUDPrompt.FHelpLine>(Ptr + 88);

    /// <summary>
    /// StructProperty: MainLineLast
    /// </summary>
    public unsafe ref BmSDK.BmGame.RHUDPrompt.FHelpLine MainLineLast
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RHUDPrompt.FHelpLine>(Ptr + 120);

    /// <summary>
    /// ArrayProperty: Lines
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHUDPrompt.FHelpLine> Lines
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHUDPrompt.FHelpLine>>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// ArrayProperty: LinesLast
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHUDPrompt.FHelpLine> LinesLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHUDPrompt.FHelpLine>>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// StrProperty: Instructions
    /// </summary>
    public unsafe BmSDK.FString Instructions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// StrProperty: InstructionsLast
    /// </summary>
    public unsafe BmSDK.FString InstructionsLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// StrProperty: HighPriorityInstructions
    /// </summary>
    public unsafe BmSDK.FString HighPriorityInstructions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// ObjectProperty: FromKismet
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_HelpText FromKismet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_HelpText>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// Struct: FHelpLine
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FHelpLine
    {
        /// <summary>
        /// StrProperty: Line
        /// </summary>
        public unsafe BmSDK.FString Line
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: Icon
        /// </summary>
        public unsafe BmSDK.BmGame.RHUDPrompt.EControlIcon Icon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHUDPrompt.EControlIcon>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: Alpha
        /// </summary>
        public unsafe int Alpha
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StrProperty: ImageName
        /// </summary>
        public unsafe BmSDK.FString ImageName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Enum: EControlIcon
    /// </summary>
    public enum EControlIcon : byte
    {
        CI_None = 0,
        CI_UI_Start = 1,
        CI_UI_Select = 2,
        CI_UI_A = 3,
        CI_UI_B = 4,
        CI_UI_X = 5,
        CI_UI_Y = 6,
        CI_UI_L1 = 7,
        CI_UI_L2 = 8,
        CI_UI_L3 = 9,
        CI_UI_R1 = 10,
        CI_UI_R2 = 11,
        CI_UI_R3 = 12,
        CI_UI_Move = 13,
        CI_UI_MoveLR = 14,
        CI_UI_MoveUD = 15,
        CI_UI_Mouse = 16,
        CI_UI_MouseLR = 17,
        CI_UI_MouseUD = 18,
        CI_UI_MouseLMB = 19,
        CI_UI_MapCenter = 20,
        CI_UI_MapZoom = 21,
        CI_Interact = 22,
        CI_VisionModes = 23,
        CI_AimGadget = 24,
        CI_UseGadget = 25,
        CI_UseGrapple = 26,
        CI_UseScanner = 27,
        CI_Map = 28,
        CI_DPad = 29,
        CI_LeftStick = 30,
        CI_LeftStickUp = 31,
        CI_LeftStickDown = 32,
        CI_LeftStickUpAndDown = 33,
        CI_LeftStickLeftAndRight = 34,
        CI_RightStick = 35,
        CI_CrouchInteract = 36,
        CI_CrouchInteractHold = 37,
        CI_LeftAndRightStick = 38,
        CI_Crouch = 39,
        CI_DPadU = 40,
        CI_DPadD = 41,
        CI_DPadL = 42,
        CI_DPadR = 43,
        CI_RightStickIn = 44,
        CI_LTorRT = 45,
        CI_LBorRB = 46,
        CI_PageLeft = 47,
        CI_PageRight = 48,
        CI_CrouchGrab = 49,
        CI_SilentTakeDown = 50,
        CI_Strike = 51,
        CI_SecondaryFire = 52,
        CI_CapeStun = 53,
        CI_Throw = 54,
        CI_CombatTakeDown = 55,
        CI_Cancel = 56,
        CI_RunGlide = 57,
        CI_SelectBatarang = 58,
        CI_SelectExplosiveGel = 59,
        CI_SelectHarpoonGun = 60,
        CI_SelectResonatorTuner = 61,
        CI_SelectLineLauncher = 62,
        CI_SelectControllableBatarang = 63,
        CI_SelectSonicBatarang = 64,
        CI_SelectSmokeBomb = 65,
        CI_SelectREC = 66,
        CI_SelectFreezeBlast = 67,
        CI_SelectFreezeCluster = 68,
        CI_SelectJammer = 69,
        CI_Camera = 70,
        CI_LeftHat = 71,
        CI_Zoom = 72,
        CI_DetonateCharge = 73,
        CI_QuickBatarang = 74,
        CI_QuickBatClaw = 75,
        CI_QuickGel = 76,
        CI_QuickFreeze = 77,
        CI_QuickMagBlast = 78,
        CI_QuickCurrentGadget = 79,
        CI_HangFromVantagePoint = 80,
        CI_Movement = 81,
        CI_Gadgets = 82,
        CI_CryptoTune = 83,
        CI_SixAxisShake1 = 84,
        CI_SixAxisShake2 = 85,
        CI_UseMagBlast = 86,
        CI_SwingAttack = 87,
        CI_KnifeCounter = 88,
        CI_BeatDown = 89,
        CI_AerialAttack = 90,
        CI_DirectedAerialAttack = 91,
        CI_Jump = 92,
        CI_SmokeAndEscape = 93,
        CI_SuperStun = 94,
        CI_CombatSpecialLeft = 95,
        CI_CombatSpecialTop = 96,
        CI_CombatSpecialBottom = 97,
        CI_Evade = 98,
        CI_HoldRunGlide = 99,
        CI_ToggleDetectiveMode = 100,
        CI_TriggerScan = 101,
        CI_GrappleBoost = 102,
        CI_RecUp = 103,
        CI_RecDown = 104,
        CI_SelectGadget1 = 105,
        CI_SelectGadget2 = 106,
        CI_SelectGadget3 = 107,
        CI_SelectGadget4 = 108,
        CI_SelectGadget5 = 109,
        CI_SelectGadget6 = 110,
        CI_SelectGadget7 = 111,
        CI_SelectGadget8 = 112,
        CI_SelectGadget9 = 113,
        CI_SelectGadget10 = 114,
        CI_SelectGadget11 = 115,
        CI_SelectGadget12 = 116,
        CI_GrappleToHang = 117,
        CI_GrappleToClimb = 118,
        CI_StunStick = 119,
        CI_TitanBeatdown = 120,
        CI_LockOnSecondaryGadget = 121,
        CI_ThrowSecondaryGadget = 122,
        CI_Slide = 123,
        CI_ReadyGadgetButton = 124,
        CI_UseGadgetShort = 125,
        CI_SecondaryGadgetShort = 126,
        CI_BatclawSlam = 127,
        CI_UseGadgetHoldShort = 128,
        CI_SecondaryGadgetHoldShort = 129,
        CI_UseGadgetHold = 130,
        CI_BladeCounter = 131,
        CI_CannotTakedown = 132,
        CI_MAX = 133,
    }
}
