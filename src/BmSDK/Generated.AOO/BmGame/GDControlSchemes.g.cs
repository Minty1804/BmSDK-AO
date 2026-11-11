#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDControlSchemes<br/>
/// (size = 72)
/// (flags = 32786)
/// </summary>
public partial class GDControlSchemes : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDControlSchemes", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDControlSchemes.
    /// </summary>
    public static GDControlSchemes DefaultObject => (GDControlSchemes)StaticClass().DefaultObject;

    internal GDControlSchemes() { }

    /// <summary>
    /// Constructs a new GDControlSchemes
    /// </summary>
    public GDControlSchemes(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDControlSchemes Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDControlSchemes(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDControlSchemes>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDControlSchemes>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDControlSchemes>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDControlSchemes>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDControlSchemes>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDControlSchemes>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDControlSchemes>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDControlSchemes>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetControlSchemeAtIndex;
    /// <summary>
    /// Function: GetControlSchemeAtIndex
    /// </summary>
    public unsafe bool GetControlSchemeAtIndex(out BmSDK.BmGame.GDControlSchemes.FSControlScheme FoundControlScheme, int ControlSchemeIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetControlSchemeAtIndex, "BmGame.GDControlSchemes.GetControlSchemeAtIndex");
        byte* paramsPtr = stackalloc byte[216];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControlSchemeIndex, paramsPtr + 192);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        FoundControlScheme = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDControlSchemes.FSControlScheme>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 196);
    }

    private static BmSDK.Function __fn_CheckForProfileButtonAdjustments;
    /// <summary>
    /// Function: CheckForProfileButtonAdjustments
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDControlSchemes.EControlSchemeKey CheckForProfileButtonAdjustments(BmSDK.BmGame.GDControlSchemes.EControlSchemeKey InputKey, BmSDK.BmGame.RPlayerController RPC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForProfileButtonAdjustments, "BmGame.GDControlSchemes.CheckForProfileButtonAdjustments");
        byte* paramsPtr = stackalloc byte[25];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InputKey, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDControlSchemes.EControlSchemeKey>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetDisplayStringForKey;
    /// <summary>
    /// Function: GetDisplayStringForKey
    /// </summary>
    public unsafe virtual BmSDK.FString GetDisplayStringForKey(BmSDK.BmGame.GDControlSchemes.EControlSchemeKey Key, int ControlSchemeIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDisplayStringForKey, "BmGame.GDControlSchemes.GetDisplayStringForKey");
        byte* paramsPtr = stackalloc byte[245];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControlSchemeIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetKeyForUsage;
    /// <summary>
    /// Function: GetKeyForUsage
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDControlSchemes.EControlSchemeKey GetKeyForUsage(BmSDK.BmGame.GDControlSchemes.EControlSchemeKeyUsage Usage, int ControlSchemeIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetKeyForUsage, "BmGame.GDControlSchemes.GetKeyForUsage");
        byte* paramsPtr = stackalloc byte[228];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Usage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControlSchemeIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDControlSchemes.EControlSchemeKey>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetLocalisationKeyForScheme;
    /// <summary>
    /// Function: GetLocalisationKeyForScheme
    /// </summary>
    public unsafe virtual BmSDK.FString GetLocalisationKeyForScheme(int ControlSchemeIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocalisationKeyForScheme, "BmGame.GDControlSchemes.GetLocalisationKeyForScheme");
        byte* paramsPtr = stackalloc byte[224];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControlSchemeIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    /// <summary>
    /// StrProperty: StringSeparator
    /// </summary>
    public unsafe BmSDK.FString StringSeparator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// ArrayProperty: ControlSchemes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDControlSchemes.FSControlScheme> ControlSchemes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDControlSchemes.FSControlScheme>>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// Struct: FSControlScheme
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 192)]
    public partial record struct FSControlScheme
    {
        /// <summary>
        /// StrProperty: ControlSetDisplayName
        /// </summary>
        public unsafe BmSDK.FString ControlSetDisplayName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: ControlSetKeyUsages
        /// </summary>
        public unsafe BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages ControlSetKeyUsages_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
        /// <summary>
        /// StructProperty: ControlSetKeyUsages
        /// </summary>
        public unsafe BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages ControlSetKeyUsages_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
        /// <summary>
        /// StructProperty: ControlSetKeyUsages
        /// </summary>
        public unsafe BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages ControlSetKeyUsages_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }
        /// <summary>
        /// StructProperty: ControlSetKeyUsages
        /// </summary>
        public unsafe BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages ControlSetKeyUsages_3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }
        /// <summary>
        /// StructProperty: ControlSetKeyUsages
        /// </summary>
        public unsafe BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages ControlSetKeyUsages_4
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }
        /// <summary>
        /// StructProperty: ControlSetKeyUsages
        /// </summary>
        public unsafe BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages ControlSetKeyUsages_5
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }
        /// <summary>
        /// StructProperty: ControlSetKeyUsages
        /// </summary>
        public unsafe BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages ControlSetKeyUsages_6
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }
        /// <summary>
        /// StructProperty: ControlSetKeyUsages
        /// </summary>
        public unsafe BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages ControlSetKeyUsages_7
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }
        /// <summary>
        /// StructProperty: ControlSetKeyUsages
        /// </summary>
        public unsafe BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages ControlSetKeyUsages_8
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages>(Ptr + 108); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }; }
        }
        /// <summary>
        /// StructProperty: ControlSetKeyUsages
        /// </summary>
        public unsafe BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages ControlSetKeyUsages_9
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages>(Ptr + 120); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }; }
        }
        /// <summary>
        /// StructProperty: ControlSetKeyUsages
        /// </summary>
        public unsafe BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages ControlSetKeyUsages_10
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages>(Ptr + 132); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }; }
        }
        /// <summary>
        /// StructProperty: ControlSetKeyUsages
        /// </summary>
        public unsafe BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages ControlSetKeyUsages_11
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages>(Ptr + 144); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }; }
        }
        /// <summary>
        /// StructProperty: ControlSetKeyUsages
        /// </summary>
        public unsafe BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages ControlSetKeyUsages_12
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages>(Ptr + 156); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }; }
        }
        /// <summary>
        /// StructProperty: ControlSetKeyUsages
        /// </summary>
        public unsafe BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages ControlSetKeyUsages_13
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages>(Ptr + 168); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }; }
        }
        /// <summary>
        /// StructProperty: ControlSetKeyUsages
        /// </summary>
        public unsafe BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages ControlSetKeyUsages_14
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDControlSchemes.FSControlSchemeKeyUsages>(Ptr + 180); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }; }
        }
    }

    /// <summary>
    /// Struct: FSControlSchemeKeyUsages
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FSControlSchemeKeyUsages
    {
        /// <summary>
        /// ArrayProperty: KeyUsage
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDControlSchemes.EControlSchemeKeyUsage> KeyUsage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDControlSchemes.EControlSchemeKeyUsage>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Enum: EControlSchemeKeyUsage
    /// </summary>
    public enum EControlSchemeKeyUsage : byte
    {
        ECSKU_Invalid = 0,
        ECSKU_Look = 1,
        ECSKU_Move = 2,
        ECSKU_Aim = 3,
        ECSKU_Fire = 4,
        ECSKU_Scoreboard = 5,
        ECSKU_PauseMenu = 6,
        ECSKU_ItemLeft = 7,
        ECSKU_ItemRight = 8,
        ECSKU_Grenade = 9,
        ECSKU_Reload = 10,
        ECSKU_Melee = 11,
        ECSKU_ChangeWeapon = 12,
        ECSKU_Evade = 13,
        ECSKU_Interact = 14,
        ECSKU_Sprint = 15,
        ECSKU_Cover = 16,
        ECSKU_EnhancedVision = 17,
        ECSKU_RCDeviceBoost = 18,
        ECSKU_RCDeviceBrake = 19,
        ECSKU_RCDeviceActivate = 20,
        ECSKU_MAX = 21,
    }

    /// <summary>
    /// Enum: EControlSchemeKey
    /// </summary>
    public enum EControlSchemeKey : byte
    {
        ECSK_ButtonA = 0,
        ECSK_ButtonB = 1,
        ECSK_ButtonY = 2,
        ECSK_ButtonX = 3,
        ECSK_ButtonStart = 4,
        ECSK_ButtonBack = 5,
        ECSK_Dpad = 6,
        ECSK_LeftStick = 7,
        ECSK_LeftStickClick = 8,
        ECSK_RightStick = 9,
        ECSK_RightStickClick = 10,
        ECSK_LeftTrigger = 11,
        ECSK_LeftBumper = 12,
        ECSK_RightTrigger = 13,
        ECSK_RightBumper = 14,
        ECSK_MAX = 15,
    }
}
