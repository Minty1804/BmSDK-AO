#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: LocalPlayer<br/>
/// (size = 1104)
/// (flags = 134217886)
/// </summary>
public partial class LocalPlayer : BmSDK.Engine.Player, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.LocalPlayer", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as LocalPlayer.
    /// </summary>
    public static LocalPlayer DefaultObject => (LocalPlayer)StaticClass().DefaultObject;

    internal LocalPlayer() { }

    /// <summary>
    /// Constructs a new LocalPlayer
    /// </summary>
    public LocalPlayer(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, LocalPlayer Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected LocalPlayer(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<LocalPlayer>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<LocalPlayer>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<LocalPlayer>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<LocalPlayer>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<LocalPlayer>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<LocalPlayer>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<LocalPlayer>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<LocalPlayer>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetNickname;
    /// <summary>
    /// Function: GetNickname
    /// </summary>
    public unsafe virtual BmSDK.FString GetNickname()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNickname, "Engine.LocalPlayer.GetNickname");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetUniqueNetId;
    /// <summary>
    /// Function: GetUniqueNetId
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.FUniqueNetId GetUniqueNetId()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUniqueNetId, "Engine.LocalPlayer.GetUniqueNetId");
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ProjectStaticMeshBounds;
    /// <summary>
    /// Function: ProjectStaticMeshBounds
    /// </summary>
    public unsafe virtual bool ProjectStaticMeshBounds(BmSDK.Engine.StaticMeshComponent MeshComponent, out System.Numerics.Vector2 Min, out System.Numerics.Vector2 Max)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProjectStaticMeshBounds, "Engine.LocalPlayer.ProjectStaticMeshBounds");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeshComponent, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Min);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Min, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Max);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Max, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Min = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector2>(paramsPtr + 4);
        Max = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector2>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_DeProject;
    /// <summary>
    /// Function: DeProject
    /// </summary>
    public unsafe virtual void DeProject(System.Numerics.Vector2 RelativeScreenPos, out System.Numerics.Vector3 WorldOrigin, out System.Numerics.Vector3 WorldDirection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeProject, "Engine.LocalPlayer.DeProject");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RelativeScreenPos, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out WorldOrigin);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WorldOrigin, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out WorldDirection);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WorldDirection, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        WorldOrigin = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
        WorldDirection = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 20);
        return;
    }

    private static BmSDK.Function __fn_TouchPlayerPostProcessChain;
    /// <summary>
    /// Function: TouchPlayerPostProcessChain
    /// </summary>
    public unsafe virtual void TouchPlayerPostProcessChain()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TouchPlayerPostProcessChain, "Engine.LocalPlayer.TouchPlayerPostProcessChain");
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

    private static BmSDK.Function __fn_GetPostProcessChain;
    /// <summary>
    /// Function: GetPostProcessChain
    /// </summary>
    public unsafe virtual BmSDK.Engine.PostProcessChain GetPostProcessChain(int InIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPostProcessChain, "Engine.LocalPlayer.GetPostProcessChain");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PostProcessChain>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_RemoveAllPostProcessingChains;
    /// <summary>
    /// Function: RemoveAllPostProcessingChains
    /// </summary>
    public unsafe virtual bool RemoveAllPostProcessingChains()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveAllPostProcessingChains, "Engine.LocalPlayer.RemoveAllPostProcessingChains");
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

    private static BmSDK.Function __fn_RemovePostProcessingChain;
    /// <summary>
    /// Function: RemovePostProcessingChain
    /// </summary>
    public unsafe virtual bool RemovePostProcessingChain(int InIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemovePostProcessingChain, "Engine.LocalPlayer.RemovePostProcessingChain");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_InsertPostProcessingChain;
    /// <summary>
    /// Function: InsertPostProcessingChain
    /// </summary>
    public unsafe virtual bool InsertPostProcessingChain(BmSDK.Engine.PostProcessChain InChain, int InIndex, bool bInClone)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InsertPostProcessingChain, "Engine.LocalPlayer.InsertPostProcessingChain");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InChain, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInClone, paramsPtr + 8);
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

    private static BmSDK.Function __fn_GetTranslationContext;
    /// <summary>
    /// Function: GetTranslationContext
    /// </summary>
    public unsafe virtual BmSDK.Engine.TranslationContext GetTranslationContext()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTranslationContext, "Engine.LocalPlayer.GetTranslationContext");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.TranslationContext>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetControllerId;
    /// <summary>
    /// Function: SetControllerId
    /// </summary>
    public unsafe virtual void SetControllerId(int NewControllerId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetControllerId, "Engine.LocalPlayer.SetControllerId");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewControllerId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearPostProcessSettingsOverride;
    /// <summary>
    /// Function: ClearPostProcessSettingsOverride
    /// </summary>
    public unsafe virtual void ClearPostProcessSettingsOverride(float BlendOutTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPostProcessSettingsOverride, "Engine.LocalPlayer.ClearPostProcessSettingsOverride");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendOutTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_OverridePostProcessSettings;
    /// <summary>
    /// Function: OverridePostProcessSettings
    /// </summary>
    public unsafe virtual void OverridePostProcessSettings(BmSDK.Engine.PostProcessVolume.FPostProcessSettings OverrideSettings, float BlendInTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverridePostProcessSettings, "Engine.LocalPlayer.OverridePostProcessSettings");
        byte* paramsPtr = stackalloc byte[440];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideSettings, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendInTime, paramsPtr + 420);
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

    private static BmSDK.Function __fn_GetActorVisibility;
    /// <summary>
    /// Function: GetActorVisibility
    /// </summary>
    public unsafe virtual bool GetActorVisibility(BmSDK.Engine.Actor TestActor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActorVisibility, "Engine.LocalPlayer.GetActorVisibility");
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

    private static BmSDK.Function __fn_SendSplitJoin;
    /// <summary>
    /// Function: SendSplitJoin
    /// </summary>
    public unsafe virtual void SendSplitJoin()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendSplitJoin, "Engine.LocalPlayer.SendSplitJoin");
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

    private static BmSDK.Function __fn_SpawnPlayActor;
    /// <summary>
    /// Function: SpawnPlayActor
    /// </summary>
    public unsafe virtual bool SpawnPlayActor(BmSDK.FString URL, out BmSDK.FString OutError)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnPlayActor, "Engine.LocalPlayer.SpawnPlayActor");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(URL, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutError = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    /// <summary>
    /// Struct: FPostProcessSettingsOverride
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 444)]
    public partial record struct FPostProcessSettingsOverride
    {
        /// <summary>
        /// StructProperty: Settings
        /// </summary>
        public unsafe BmSDK.Engine.PostProcessVolume.FPostProcessSettings Settings
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PostProcessVolume.FPostProcessSettings>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bBlendingIn
        /// </summary>
        public unsafe bool bBlendingIn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }; }
        }

        /// <summary>
        /// BoolProperty: bBlendingOut
        /// </summary>
        public unsafe bool bBlendingOut
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }; }
        }

        /// <summary>
        /// FloatProperty: CurrentBlendInTime
        /// </summary>
        public unsafe float CurrentBlendInTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 424); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }; }
        }

        /// <summary>
        /// FloatProperty: CurrentBlendOutTime
        /// </summary>
        public unsafe float CurrentBlendOutTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 428); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }; }
        }

        /// <summary>
        /// FloatProperty: BlendInDuration
        /// </summary>
        public unsafe float BlendInDuration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 432); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }; }
        }

        /// <summary>
        /// FloatProperty: BlendOutDuration
        /// </summary>
        public unsafe float BlendOutDuration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 436); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }; }
        }

        /// <summary>
        /// FloatProperty: BlendStartTime
        /// </summary>
        public unsafe float BlendStartTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 440); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }; }
        }
    }

    /// <summary>
    /// Struct: FCurrentPostProcessVolumeInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 432)]
    public partial record struct FCurrentPostProcessVolumeInfo
    {
        /// <summary>
        /// StructProperty: LastSettings
        /// </summary>
        public unsafe BmSDK.Engine.PostProcessVolume.FPostProcessSettings LastSettings
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PostProcessVolume.FPostProcessSettings>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: LastVolumeUsed
        /// </summary>
        public unsafe BmSDK.Engine.PostProcessVolume LastVolumeUsed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PostProcessVolume>(Ptr + 420); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }; }
        }

        /// <summary>
        /// FloatProperty: BlendStartTime
        /// </summary>
        public unsafe float BlendStartTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 424); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }; }
        }

        /// <summary>
        /// FloatProperty: LastBlendTime
        /// </summary>
        public unsafe float LastBlendTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 428); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }; }
        }
    }

    /// <summary>
    /// Struct: FSynchronizedActorVisibilityHistory
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FSynchronizedActorVisibilityHistory
    {
        /// <summary>
        /// StructProperty: State
        /// </summary>
        public unsafe System.IntPtr State
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: CriticalSection
        /// </summary>
        public unsafe System.IntPtr CriticalSection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// IntProperty: ControllerId
    /// </summary>
    public unsafe int ControllerId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// ObjectProperty: ViewportClient
    /// </summary>
    public unsafe BmSDK.Engine.GameViewportClient ViewportClient
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameViewportClient>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StructProperty: Origin
    /// </summary>
    public unsafe ref System.Numerics.Vector2 Origin
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector2>(Ptr + 88);

    /// <summary>
    /// StructProperty: Size
    /// </summary>
    public unsafe ref System.Numerics.Vector2 Size
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector2>(Ptr + 96);

    /// <summary>
    /// BoolProperty: IsXrayEnabled
    /// </summary>
    public unsafe bool IsXrayEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: IsScanModeEnabled
    /// </summary>
    public unsafe bool IsScanModeEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: IsThermalEnabled
    /// </summary>
    public unsafe bool IsThermalEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: IsInsignificantForLODs
    /// </summary>
    public unsafe bool IsInsignificantForLODs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bWantToResetToMapDefaultPP
    /// </summary>
    public unsafe bool bWantToResetToMapDefaultPP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bSentSplitJoin
    /// </summary>
    public unsafe bool bSentSplitJoin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bInstantlySwitchPostProcessVolume
    /// </summary>
    public unsafe bool bInstantlySwitchPostProcessVolume
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// ObjectProperty: PlayerPostProcess
    /// </summary>
    public unsafe BmSDK.Engine.PostProcessChain PlayerPostProcess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PostProcessChain>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ArrayProperty: PlayerPostProcessChains
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.PostProcessChain> PlayerPostProcessChains
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.PostProcessChain>>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// StructProperty: ViewState
    /// </summary>
    public unsafe System.IntPtr ViewState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// StructProperty: ActorVisibilityHistory
    /// </summary>
    public unsafe ref BmSDK.Engine.LocalPlayer.FSynchronizedActorVisibilityHistory ActorVisibilityHistory
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.LocalPlayer.FSynchronizedActorVisibilityHistory>(Ptr + 128);

    /// <summary>
    /// StructProperty: LastViewMatrix
    /// </summary>
    public unsafe ref BmSDK.GameObject.FMatrix LastViewMatrix
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FMatrix>(Ptr + 144);

    /// <summary>
    /// StructProperty: CurrentPPInfo
    /// </summary>
    public unsafe ref BmSDK.Engine.LocalPlayer.FCurrentPostProcessVolumeInfo CurrentPPInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.LocalPlayer.FCurrentPostProcessVolumeInfo>(Ptr + 208);

    /// <summary>
    /// StructProperty: LevelPPInfo
    /// </summary>
    public unsafe ref BmSDK.Engine.LocalPlayer.FCurrentPostProcessVolumeInfo LevelPPInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.LocalPlayer.FCurrentPostProcessVolumeInfo>(Ptr + 640);

    /// <summary>
    /// ArrayProperty: ActivePPOverrides
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.LocalPlayer.FPostProcessSettingsOverride> ActivePPOverrides
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.LocalPlayer.FPostProcessSettingsOverride>>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ByteProperty: AspectRatioAxisConstraint
    /// </summary>
    public unsafe BmSDK.GameObject.EAspectRatioAxisConstraint AspectRatioAxisConstraint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.EAspectRatioAxisConstraint>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// StrProperty: LastMap
    /// </summary>
    public unsafe BmSDK.FString LastMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// ObjectProperty: TagContext
    /// </summary>
    public unsafe BmSDK.Engine.TranslationContext TagContext
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.TranslationContext>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }
}
