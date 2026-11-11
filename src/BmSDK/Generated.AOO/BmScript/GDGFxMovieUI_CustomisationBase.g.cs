#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: GDGFxMovieUI_CustomisationBase<br/>
/// (size = 2132)
/// (flags = 32790)
/// </summary>
public partial class GDGFxMovieUI_CustomisationBase : BmSDK.BmGame.GDGFxMovieUI_ButtonListBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.GDGFxMovieUI_CustomisationBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDGFxMovieUI_CustomisationBase.
    /// </summary>
    public static GDGFxMovieUI_CustomisationBase DefaultObject => (GDGFxMovieUI_CustomisationBase)StaticClass().DefaultObject;

    internal GDGFxMovieUI_CustomisationBase() { }

    /// <summary>
    /// Constructs a new GDGFxMovieUI_CustomisationBase
    /// </summary>
    public GDGFxMovieUI_CustomisationBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDGFxMovieUI_CustomisationBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDGFxMovieUI_CustomisationBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_CustomisationBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_CustomisationBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_CustomisationBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_CustomisationBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_CustomisationBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_CustomisationBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_CustomisationBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_CustomisationBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_asSetActiveProfileID;
    /// <summary>
    /// Function: asSetActiveProfileID
    /// </summary>
    public unsafe virtual void asSetActiveProfileID(int ActiveID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetActiveProfileID, "BmScript.GDGFxMovieUI_CustomisationBase.asSetActiveProfileID");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActiveID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asInitialiseProfileSlots;
    /// <summary>
    /// Function: asInitialiseProfileSlots
    /// </summary>
    public unsafe virtual void asInitialiseProfileSlots(bool bJoker, int NumActiveSlots)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asInitialiseProfileSlots, "BmScript.GDGFxMovieUI_CustomisationBase.asInitialiseProfileSlots");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bJoker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumActiveSlots, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetProfileSlotsPlatform;
    /// <summary>
    /// Function: asSetProfileSlotsPlatform
    /// </summary>
    public unsafe virtual void asSetProfileSlotsPlatform(BmSDK.FString PlatformName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetProfileSlotsPlatform, "BmScript.GDGFxMovieUI_CustomisationBase.asSetProfileSlotsPlatform");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetItemDetails;
    /// <summary>
    /// Function: asSetItemDetails
    /// </summary>
    public unsafe virtual void asSetItemDetails(BmSDK.FString detailsStr)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetItemDetails, "BmScript.GDGFxMovieUI_CustomisationBase.asSetItemDetails");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(detailsStr, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetScreenSubTitle;
    /// <summary>
    /// Function: asSetScreenSubTitle
    /// </summary>
    public unsafe virtual void asSetScreenSubTitle(BmSDK.FString Subtitle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetScreenSubTitle, "BmScript.GDGFxMovieUI_CustomisationBase.asSetScreenSubTitle");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Subtitle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetScreenTitle;
    /// <summary>
    /// Function: asSetScreenTitle
    /// </summary>
    public unsafe virtual void asSetScreenTitle(BmSDK.FString Title)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetScreenTitle, "BmScript.GDGFxMovieUI_CustomisationBase.asSetScreenTitle");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetWeaponName;
    /// <summary>
    /// Function: asSetWeaponName
    /// </summary>
    public unsafe virtual void asSetWeaponName(BmSDK.FString WeaponName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetWeaponName, "BmScript.GDGFxMovieUI_CustomisationBase.asSetWeaponName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetWeaponIcons;
    /// <summary>
    /// Function: asSetWeaponIcons
    /// </summary>
    public unsafe virtual void asSetWeaponIcons(BmSDK.FString PackageName, BmSDK.FString PrimaryWeaponIcon, BmSDK.FString WeaponLevel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetWeaponIcons, "BmScript.GDGFxMovieUI_CustomisationBase.asSetWeaponIcons");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PrimaryWeaponIcon, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponLevel, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetAbilityIcons;
    /// <summary>
    /// Function: asSetAbilityIcons
    /// </summary>
    public unsafe virtual void asSetAbilityIcons(BmSDK.FString PackageName, BmSDK.FString LeftIcon, BmSDK.FString RightIcon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetAbilityIcons, "BmScript.GDGFxMovieUI_CustomisationBase.asSetAbilityIcons");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PackageName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeftIcon, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RightIcon, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHighlightedEquippedItemOnButtonDataCompletion;
    /// <summary>
    /// Function: SetHighlightedEquippedItemOnButtonDataCompletion
    /// </summary>
    public unsafe virtual void SetHighlightedEquippedItemOnButtonDataCompletion(int EquippedItemIdx, int ListLen)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHighlightedEquippedItemOnButtonDataCompletion, "BmScript.GDGFxMovieUI_CustomisationBase.SetHighlightedEquippedItemOnButtonDataCompletion");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EquippedItemIdx, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ListLen, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetEquippedWeaponName;
    /// <summary>
    /// Function: GetEquippedWeaponName
    /// </summary>
    public unsafe virtual BmSDK.FString GetEquippedWeaponName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEquippedWeaponName, "BmScript.GDGFxMovieUI_CustomisationBase.GetEquippedWeaponName");
        byte* paramsPtr = stackalloc byte[168];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateCustomisationFlags;
    /// <summary>
    /// Function: UpdateCustomisationFlags
    /// </summary>
    public unsafe virtual void UpdateCustomisationFlags(int ButtonIdx, bool bLocked, bool bNew, bool bUsedS1, bool bUsedS2, bool bEquipped, bool bIsUsedType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCustomisationFlags, "BmScript.GDGFxMovieUI_CustomisationBase.UpdateCustomisationFlags");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonIdx, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLocked, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNew, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUsedS1, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUsedS2, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEquipped, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsUsedType, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPlayerIconInfo;
    /// <summary>
    /// Function: SetPlayerIconInfo
    /// </summary>
    public unsafe virtual void SetPlayerIconInfo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPlayerIconInfo, "BmScript.GDGFxMovieUI_CustomisationBase.SetPlayerIconInfo");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAbilityIconName;
    /// <summary>
    /// Function: GetAbilityIconName
    /// </summary>
    public unsafe virtual BmSDK.FString GetAbilityIconName(BmSDK.BmGame.RGameInfo.eGadgetSlot SlotID, bool CheckUnlockLevels, out BmSDK.BmGame.RGameInfo.PlayerGadgetId AbilityGadgetID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAbilityIconName, "BmScript.GDGFxMovieUI_CustomisationBase.GetAbilityIconName");
        byte* paramsPtr = stackalloc byte[168];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlotID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckUnlockLevels, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AbilityGadgetID);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AbilityGadgetID, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AbilityGadgetID = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.PlayerGadgetId>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetButtonStateValue;
    /// <summary>
    /// Function: GetButtonStateValue
    /// </summary>
    public unsafe virtual int GetButtonStateValue(bool bIsLocked, bool bIsNew, bool bIsUsedS1, bool bIsUsedS2, bool bIsEquipped, bool bIsUsedType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetButtonStateValue, "BmScript.GDGFxMovieUI_CustomisationBase.GetButtonStateValue");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsLocked, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsNew, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsUsedS1, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsUsedS2, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsEquipped, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsUsedType, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_SetButtonListToolTip;
    /// <summary>
    /// Function: SetButtonListToolTip
    /// </summary>
    public unsafe override void SetButtonListToolTip(BmSDK.FString VariableName = default, BmSDK.FString StateName = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetButtonListToolTip, "BmScript.GDGFxMovieUI_CustomisationBase.SetButtonListToolTip");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariableName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateName, paramsPtr + 12);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_GetLocalisesdFactionAndSlot;
    /// <summary>
    /// Function: GetLocalisesdFactionAndSlot
    /// </summary>
    public unsafe virtual BmSDK.FString GetLocalisesdFactionAndSlot()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocalisesdFactionAndSlot, "BmScript.GDGFxMovieUI_CustomisationBase.GetLocalisesdFactionAndSlot");
        byte* paramsPtr = stackalloc byte[41];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RemoveLayerFromScreenSubtitle;
    /// <summary>
    /// Function: RemoveLayerFromScreenSubtitle
    /// </summary>
    public unsafe virtual void RemoveLayerFromScreenSubtitle()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveLayerFromScreenSubtitle, "BmScript.GDGFxMovieUI_CustomisationBase.RemoveLayerFromScreenSubtitle");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddNewLayerToScreenSubtitle;
    /// <summary>
    /// Function: AddNewLayerToScreenSubtitle
    /// </summary>
    public unsafe virtual void AddNewLayerToScreenSubtitle(BmSDK.FString LocalisedLayerName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddNewLayerToScreenSubtitle, "BmScript.GDGFxMovieUI_CustomisationBase.AddNewLayerToScreenSubtitle");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalisedLayerName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseCustomisationScreen;
    /// <summary>
    /// Function: CloseCustomisationScreen
    /// </summary>
    public unsafe virtual void CloseCustomisationScreen(bool bSelectItem)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseCustomisationScreen, "BmScript.GDGFxMovieUI_CustomisationBase.CloseCustomisationScreen");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSelectItem, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseScreen;
    /// <summary>
    /// Function: CloseScreen
    /// </summary>
    public unsafe override void CloseScreen()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseScreen, "BmScript.GDGFxMovieUI_CustomisationBase.CloseScreen");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmScript.GDGFxMovieUI_CustomisationBase.Init");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FBasicLoadoutButtonData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FBasicLoadoutButtonData
    {
        /// <summary>
        /// StrProperty: ButtonName
        /// </summary>
        public unsafe BmSDK.FString ButtonName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bNew
        /// </summary>
        public unsafe bool bNew
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bLocked
        /// </summary>
        public unsafe bool bLocked
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// StrProperty: BreadcrumbLocSectionName
    /// </summary>
    public unsafe BmSDK.FString BreadcrumbLocSectionName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2036); }
    }

    /// <summary>
    /// StrProperty: MainUILocFileName
    /// </summary>
    public unsafe BmSDK.FString MainUILocFileName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2048); }
    }

    /// <summary>
    /// StrProperty: AbilityIconPackageName
    /// </summary>
    public unsafe BmSDK.FString AbilityIconPackageName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2060); }
    }

    /// <summary>
    /// StrProperty: WeaponIconPackageName
    /// </summary>
    public unsafe BmSDK.FString WeaponIconPackageName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }
    }

    /// <summary>
    /// StrProperty: BatmanSkinVarName
    /// </summary>
    public unsafe BmSDK.FString BatmanSkinVarName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2084); }
    }

    /// <summary>
    /// StrProperty: RobinSkinVarName
    /// </summary>
    public unsafe BmSDK.FString RobinSkinVarName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2096); }
    }

    /// <summary>
    /// StrProperty: NameLocMarkup
    /// </summary>
    public unsafe BmSDK.FString NameLocMarkup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2108); }
    }

    /// <summary>
    /// IntProperty: ListInitEquippedItemIdx
    /// </summary>
    public unsafe int ListInitEquippedItemIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }
    }

    /// <summary>
    /// ObjectProperty: CustomisationManager
    /// </summary>
    public unsafe BmSDK.BmGame.GDCharCustomizationManager CustomisationManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDCharCustomizationManager>(Ptr + 2124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bCustomisationSelectionMade
    /// </summary>
    public unsafe bool bCustomisationSelectionMade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }
}
