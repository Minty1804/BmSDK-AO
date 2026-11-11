#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_StorePurchase<br/>
/// (size = 2220)
/// (flags = 32790)
/// </summary>
public partial class RGFxMovieUI_StorePurchase : BmSDK.BmGame.GDGFxMovieUI_ButtonListBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_StorePurchase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGFxMovieUI_StorePurchase.
    /// </summary>
    public static RGFxMovieUI_StorePurchase DefaultObject => (RGFxMovieUI_StorePurchase)StaticClass().DefaultObject;

    internal RGFxMovieUI_StorePurchase() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_StorePurchase
    /// </summary>
    public RGFxMovieUI_StorePurchase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_StorePurchase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_StorePurchase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_StorePurchase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_StorePurchase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_StorePurchase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_StorePurchase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_StorePurchase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_StorePurchase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_StorePurchase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_StorePurchase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetCustomisationItemIconName;
    /// <summary>
    /// Function: GetCustomisationItemIconName
    /// </summary>
    public unsafe virtual BmSDK.FString GetCustomisationItemIconName(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData TeamType, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType PartType, bool bIsGearPlus)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCustomisationItemIconName, "BmScript.RGFxMovieUI_StorePurchase.GetCustomisationItemIconName");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PartType, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsGearPlus, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetItemData;
    /// <summary>
    /// Function: SetItemData
    /// </summary>
    public unsafe virtual void SetItemData(BmSDK.FString ItemName, BmSDK.FString ItemDescription, BmSDK.FString ItemIconPackageName, BmSDK.FString IconName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetItemData, "BmScript.RGFxMovieUI_StorePurchase.SetItemData");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemDescription, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemIconPackageName, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconName, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetButtonListToolTip;
    /// <summary>
    /// Function: SetButtonListToolTip
    /// </summary>
    public unsafe override void SetButtonListToolTip(BmSDK.FString VariableName = default, BmSDK.FString StateName = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetButtonListToolTip, "BmScript.RGFxMovieUI_StorePurchase.SetButtonListToolTip");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateName, paramsPtr + 12);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_OnButtonFocus;
    /// <summary>
    /// Function: OnButtonFocus
    /// </summary>
    public unsafe override void OnButtonFocus(int Id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnButtonFocus, "BmScript.RGFxMovieUI_StorePurchase.OnButtonFocus");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerButtonPress;
    /// <summary>
    /// Function: TriggerButtonPress
    /// </summary>
    public unsafe override void TriggerButtonPress(BmSDK.FString VariableName, int ButtonIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerButtonPress, "BmScript.RGFxMovieUI_StorePurchase.TriggerButtonPress");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnBack;
    /// <summary>
    /// Function: OnBack
    /// </summary>
    public unsafe override void OnBack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBack, "BmScript.RGFxMovieUI_StorePurchase.OnBack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DelayedInviteAccepted;
    /// <summary>
    /// Function: DelayedInviteAccepted
    /// </summary>
    public unsafe virtual void DelayedInviteAccepted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DelayedInviteAccepted, "BmScript.RGFxMovieUI_StorePurchase.DelayedInviteAccepted");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddUScriptDeclaredButtonData;
    /// <summary>
    /// Function: AddUScriptDeclaredButtonData
    /// </summary>
    public unsafe override void AddUScriptDeclaredButtonData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddUScriptDeclaredButtonData, "BmScript.RGFxMovieUI_StorePurchase.AddUScriptDeclaredButtonData");
        byte* paramsPtr = stackalloc byte[208];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDescriptionFromPartInfo;
    /// <summary>
    /// Function: GetDescriptionFromPartInfo
    /// </summary>
    public unsafe virtual BmSDK.FString GetDescriptionFromPartInfo(in BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationPartInfo partInfo, int SkinIndex, BmSDK.FString GearPlusUUID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDescriptionFromPartInfo, "BmScript.RGFxMovieUI_StorePurchase.GetDescriptionFromPartInfo");
        byte* paramsPtr = stackalloc byte[140];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(partInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkinIndex, paramsPtr + 92);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GearPlusUUID, paramsPtr + 96);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 108);
    }

    private static BmSDK.Function __fn_ClearStoreListData;
    /// <summary>
    /// Function: ClearStoreListData
    /// </summary>
    public unsafe void ClearStoreListData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearStoreListData, "BmScript.RGFxMovieUI_StorePurchase.ClearStoreListData");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetStorePurchaseItemList;
    /// <summary>
    /// Function: ResetStorePurchaseItemList
    /// </summary>
    public unsafe void ResetStorePurchaseItemList()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetStorePurchaseItemList, "BmScript.RGFxMovieUI_StorePurchase.ResetStorePurchaseItemList");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPrimaryButtonListLabelMarkupSource;
    /// <summary>
    /// Function: SetPrimaryButtonListLabelMarkupSource
    /// </summary>
    public unsafe override void SetPrimaryButtonListLabelMarkupSource()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPrimaryButtonListLabelMarkupSource, "BmScript.RGFxMovieUI_StorePurchase.SetPrimaryButtonListLabelMarkupSource");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RequestButtonListData;
    /// <summary>
    /// Function: RequestButtonListData
    /// </summary>
    public unsafe override void RequestButtonListData(BmSDK.FString ButtonListID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestButtonListData, "BmScript.RGFxMovieUI_StorePurchase.RequestButtonListData");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonListID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnInviteAccepted;
    /// <summary>
    /// Function: OnInviteAccepted
    /// </summary>
    public unsafe override void OnInviteAccepted(int ControllerId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnInviteAccepted, "BmScript.RGFxMovieUI_StorePurchase.OnInviteAccepted");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmScript.RGFxMovieUI_StorePurchase.Init");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ArrayProperty: CachedItemData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RGFxMovieUI_StorePurchase.FLocalStoreNewItemData> CachedItemData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RGFxMovieUI_StorePurchase.FLocalStoreNewItemData>>(Ptr + 2036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2036); }
    }

    /// <summary>
    /// StrProperty: StoreIconsPackageName
    /// </summary>
    public unsafe BmSDK.FString StoreIconsPackageName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2048); }
    }

    /// <summary>
    /// IntProperty: BackIdx
    /// </summary>
    public unsafe int BackIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2060); }
    }

    /// <summary>
    /// InlineArray{StrProperty}: ConsumableIconNames
    /// </summary>
    public InlineArray<BmSDK.FString> ConsumableIconNames => new(13, Ptr + 2064, 12, this);

    /// <summary>
    /// StrProperty: ConsumableIconNames
    /// </summary>
    public unsafe BmSDK.FString ConsumableIconNames_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2064); }
    }
    /// <summary>
    /// StrProperty: ConsumableIconNames
    /// </summary>
    public unsafe BmSDK.FString ConsumableIconNames_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2076); }
    }
    /// <summary>
    /// StrProperty: ConsumableIconNames
    /// </summary>
    public unsafe BmSDK.FString ConsumableIconNames_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2088); }
    }
    /// <summary>
    /// StrProperty: ConsumableIconNames
    /// </summary>
    public unsafe BmSDK.FString ConsumableIconNames_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2100); }
    }
    /// <summary>
    /// StrProperty: ConsumableIconNames
    /// </summary>
    public unsafe BmSDK.FString ConsumableIconNames_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2112); }
    }
    /// <summary>
    /// StrProperty: ConsumableIconNames
    /// </summary>
    public unsafe BmSDK.FString ConsumableIconNames_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2124); }
    }
    /// <summary>
    /// StrProperty: ConsumableIconNames
    /// </summary>
    public unsafe BmSDK.FString ConsumableIconNames_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2136); }
    }
    /// <summary>
    /// StrProperty: ConsumableIconNames
    /// </summary>
    public unsafe BmSDK.FString ConsumableIconNames_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2148); }
    }
    /// <summary>
    /// StrProperty: ConsumableIconNames
    /// </summary>
    public unsafe BmSDK.FString ConsumableIconNames_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }
    /// <summary>
    /// StrProperty: ConsumableIconNames
    /// </summary>
    public unsafe BmSDK.FString ConsumableIconNames_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2172); }
    }
    /// <summary>
    /// StrProperty: ConsumableIconNames
    /// </summary>
    public unsafe BmSDK.FString ConsumableIconNames_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2184); }
    }
    /// <summary>
    /// StrProperty: ConsumableIconNames
    /// </summary>
    public unsafe BmSDK.FString ConsumableIconNames_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2196); }
    }
    /// <summary>
    /// StrProperty: ConsumableIconNames
    /// </summary>
    public unsafe BmSDK.FString ConsumableIconNames_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2208); }
    }

    /// <summary>
    /// Struct: FLocalStoreNewItemData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial record struct FLocalStoreNewItemData
    {
        /// <summary>
        /// StrProperty: IconName
        /// </summary>
        public unsafe BmSDK.FString IconName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: ItemNameStrID
        /// </summary>
        public unsafe BmSDK.FString ItemNameStrID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StrProperty: ItemDescriptionStrID
        /// </summary>
        public unsafe BmSDK.FString ItemDescriptionStrID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// IntProperty: ItemCount
        /// </summary>
        public unsafe int ItemCount
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// IntProperty: ButtonIndex
        /// </summary>
        public unsafe int ButtonIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }
}
