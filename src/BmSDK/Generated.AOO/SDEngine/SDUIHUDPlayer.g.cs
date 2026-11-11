#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.SDEngine;

/// <summary>
/// Class: SDUIHUDPlayer<br/>
/// (size = 512)
/// (flags = 32786)
/// </summary>
public partial class SDUIHUDPlayer : BmSDK.GFxUI.GFxMoviePlayer, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "SDEngine.SDUIHUDPlayer", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as SDUIHUDPlayer.
    /// </summary>
    public static SDUIHUDPlayer DefaultObject => (SDUIHUDPlayer)StaticClass().DefaultObject;

    internal SDUIHUDPlayer() { }

    /// <summary>
    /// Constructs a new SDUIHUDPlayer
    /// </summary>
    public SDUIHUDPlayer(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SDUIHUDPlayer Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SDUIHUDPlayer(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDUIHUDPlayer>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDUIHUDPlayer>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDUIHUDPlayer>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDUIHUDPlayer>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDUIHUDPlayer>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDUIHUDPlayer>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDUIHUDPlayer>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDUIHUDPlayer>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_DrawDebugHUDData;
    /// <summary>
    /// Function: DrawDebugHUDData
    /// </summary>
    public unsafe virtual void DrawDebugHUDData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugHUDData, "SDEngine.SDUIHUDPlayer.DrawDebugHUDData");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FormatTimeHHMM;
    /// <summary>
    /// Function: FormatTimeHHMM
    /// </summary>
    public unsafe virtual BmSDK.FString FormatTimeHHMM(int inTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FormatTimeHHMM, "SDEngine.SDUIHUDPlayer.FormatTimeHHMM");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HUDSwitchedToSinglePlayer;
    /// <summary>
    /// Function: HUDSwitchedToSinglePlayer
    /// </summary>
    public unsafe virtual void HUDSwitchedToSinglePlayer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HUDSwitchedToSinglePlayer, "SDEngine.SDUIHUDPlayer.HUDSwitchedToSinglePlayer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HUDSwitchedToSplitScreen;
    /// <summary>
    /// Function: HUDSwitchedToSplitScreen
    /// </summary>
    public unsafe virtual void HUDSwitchedToSplitScreen(int NumLocalPlayers)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HUDSwitchedToSplitScreen, "SDEngine.SDUIHUDPlayer.HUDSwitchedToSplitScreen");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumLocalPlayers, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdatePlayerHUDViewport;
    /// <summary>
    /// Function: UpdatePlayerHUDViewport
    /// </summary>
    public unsafe virtual void UpdatePlayerHUDViewport(int PlayerIdx, float ViewportOriginX, float ViewportOriginY, float ViewportSizeX, float ViewportSizeY)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePlayerHUDViewport, "SDEngine.SDUIHUDPlayer.UpdatePlayerHUDViewport");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIdx, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewportOriginX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewportOriginY, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewportSizeX, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewportSizeY, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateHUDViewports;
    /// <summary>
    /// Function: UpdateHUDViewports
    /// </summary>
    public unsafe virtual void UpdateHUDViewports()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateHUDViewports, "SDEngine.SDUIHUDPlayer.UpdateHUDViewports");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ScaleHUDSafeFrameVal;
    /// <summary>
    /// Function: ScaleHUDSafeFrameVal
    /// </summary>
    public unsafe void ScaleHUDSafeFrameVal(out System.Numerics.Vector2 SFVal, System.Numerics.Vector2 CanvasSize)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScaleHUDSafeFrameVal, "SDEngine.SDUIHUDPlayer.ScaleHUDSafeFrameVal");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SFVal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SFVal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CanvasSize, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SFVal = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector2>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_DetermineSafeFrameSizeToUse;
    /// <summary>
    /// Function: DetermineSafeFrameSizeToUse
    /// </summary>
    public unsafe virtual void DetermineSafeFrameSizeToUse(out System.Numerics.Vector2 MinVector, out System.Numerics.Vector2 MaxVector)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetermineSafeFrameSizeToUse, "SDEngine.SDUIHUDPlayer.DetermineSafeFrameSizeToUse");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MinVector);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinVector, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MaxVector);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxVector, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        MinVector = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector2>(paramsPtr + 0);
        MaxVector = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector2>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_PositionHUDElementsInSafeFrame;
    /// <summary>
    /// Function: PositionHUDElementsInSafeFrame
    /// </summary>
    public unsafe virtual void PositionHUDElementsInSafeFrame(BmSDK.Engine.PlayerController PC = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PositionHUDElementsInSafeFrame, "SDEngine.SDUIHUDPlayer.PositionHUDElementsInSafeFrame");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopHUDAnimation;
    /// <summary>
    /// Function: StopHUDAnimation
    /// </summary>
    public unsafe virtual void StopHUDAnimation(BmSDK.SDEngine.SDUIHUDPlayer.FHUDAnimData HUDAnimToStop)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopHUDAnimation, "SDEngine.SDUIHUDPlayer.StopHUDAnimation");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HUDAnimToStop, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartHUDAnimation;
    /// <summary>
    /// Function: StartHUDAnimation
    /// </summary>
    public unsafe virtual void StartHUDAnimation(BmSDK.SDEngine.SDUIHUDPlayer.FHUDAnimData HUDAnimToStart)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartHUDAnimation, "SDEngine.SDUIHUDPlayer.StartHUDAnimation");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HUDAnimToStart, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateHud;
    /// <summary>
    /// Function: UpdateHud
    /// </summary>
    public unsafe virtual void UpdateHud(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateHud, "SDEngine.SDUIHUDPlayer.UpdateHud");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MarkHUDViewportForUpdate;
    /// <summary>
    /// Function: MarkHUDViewportForUpdate
    /// </summary>
    public unsafe virtual void MarkHUDViewportForUpdate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MarkHUDViewportForUpdate, "SDEngine.SDUIHUDPlayer.MarkHUDViewportForUpdate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MarkHUDSafeFrameForUpdate;
    /// <summary>
    /// Function: MarkHUDSafeFrameForUpdate
    /// </summary>
    public unsafe virtual void MarkHUDSafeFrameForUpdate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MarkHUDSafeFrameForUpdate, "SDEngine.SDUIHUDPlayer.MarkHUDSafeFrameForUpdate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetVisible;
    /// <summary>
    /// Function: SetVisible
    /// </summary>
    public unsafe virtual void SetVisible(bool VisibleSetting)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVisible, "SDEngine.SDUIHUDPlayer.SetVisible");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VisibleSetting, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer Player = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "SDEngine.SDUIHUDPlayer.Init");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FHUDSafeFrameData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FHUDSafeFrameData
    {
        /// <summary>
        /// StructProperty: SFMin
        /// </summary>
        public unsafe System.Numerics.Vector2 SFMin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: SFMax
        /// </summary>
        public unsafe System.Numerics.Vector2 SFMax
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: SFRecMin
        /// </summary>
        public unsafe System.Numerics.Vector2 SFRecMin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: SFRecMax
        /// </summary>
        public unsafe System.Numerics.Vector2 SFRecMax
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FHUDAnimData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FHUDAnimData
    {
        /// <summary>
        /// ObjectProperty: HUDAnim
        /// </summary>
        public unsafe BmSDK.GFxUI.GFxObject HUDAnim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: AnimPlaying
        /// </summary>
        public unsafe bool AnimPlaying
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: CachedLocalSDPlayer
    /// </summary>
    public unsafe BmSDK.SDEngine.SDLocalPlayer CachedLocalSDPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.SDEngine.SDLocalPlayer>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// StructProperty: HUDSafeFrame
    /// </summary>
    public unsafe ref BmSDK.SDEngine.SDUIHUDPlayer.FHUDSafeFrameData HUDSafeFrame
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.SDEngine.SDUIHUDPlayer.FHUDSafeFrameData>(Ptr + 448);

    /// <summary>
    /// StructProperty: HUDSafeFrameScale
    /// </summary>
    public unsafe ref System.Numerics.Vector2 HUDSafeFrameScale
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector2>(Ptr + 480);

    /// <summary>
    /// BoolProperty: RefreshHUDSafeFrame
    /// </summary>
    public unsafe bool RefreshHUDSafeFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 488); }
    }

    /// <summary>
    /// BoolProperty: RefreshHUDViewport
    /// </summary>
    public unsafe bool RefreshHUDViewport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 488); }
    }

    /// <summary>
    /// BoolProperty: DisableInSplitScreen
    /// </summary>
    public unsafe bool DisableInSplitScreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 488); }
    }

    /// <summary>
    /// IntProperty: PrevNumLocalPlayers
    /// </summary>
    public unsafe int PrevNumLocalPlayers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// IntProperty: SplitScreenPlayerIdx
    /// </summary>
    public unsafe int SplitScreenPlayerIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// ArrayProperty: HUDComponents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.SDEngine.SDUIHUDComponent> HUDComponents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.SDEngine.SDUIHUDComponent>>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }
}
