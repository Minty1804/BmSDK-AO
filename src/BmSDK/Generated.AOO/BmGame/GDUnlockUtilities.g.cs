#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDUnlockUtilities<br/>
/// (size = 624)
/// (flags = 32786)
/// </summary>
public partial class GDUnlockUtilities : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDUnlockUtilities", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDUnlockUtilities.
    /// </summary>
    public static GDUnlockUtilities DefaultObject => (GDUnlockUtilities)StaticClass().DefaultObject;

    internal GDUnlockUtilities() { }

    /// <summary>
    /// Constructs a new GDUnlockUtilities
    /// </summary>
    public GDUnlockUtilities(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDUnlockUtilities Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDUnlockUtilities(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDUnlockUtilities>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDUnlockUtilities>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDUnlockUtilities>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDUnlockUtilities>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDUnlockUtilities>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDUnlockUtilities>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDUnlockUtilities>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDUnlockUtilities>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetLocalisedStringForCustomisationUnlock;
    /// <summary>
    /// Function: GetLocalisedStringForCustomisationUnlock
    /// </summary>
    public unsafe static BmSDK.FString GetLocalisedStringForCustomisationUnlock(BmSDK.BmGame.GDUnlockUtilities.EUIUnlockType Type, BmSDK.FString UnlockName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocalisedStringForCustomisationUnlock, "BmGame.GDUnlockUtilities.GetLocalisedStringForCustomisationUnlock");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetUnlockDisplayStrings;
    /// <summary>
    /// Function: GetUnlockDisplayStrings
    /// </summary>
    public unsafe static void GetUnlockDisplayStrings(out BmSDK.BmGame.GDUnlockUtilities.FSUnlockData Unlock, BmSDK.FString LocalisedItemName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUnlockDisplayStrings, "BmGame.GDUnlockUtilities.GetUnlockDisplayStrings");
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalisedItemName, paramsPtr + 60);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Unlock = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_PopulateWeaponSkinUnlocks;
    /// <summary>
    /// Function: PopulateWeaponSkinUnlocks
    /// </summary>
    public unsafe static void PopulateWeaponSkinUnlocks(BmSDK.BmGame.RPlayerController RPC, BmSDK.BmGame.GDUnlockableItemComponent.EUnlockMethod UnlockMethod, int StartLevel, int EndLevel, BmSDK.BmGame.GDUnlockUtilities.EUIUnlockType UnlockType, out BmSDK.TArray<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData> Unlocks, BmSDK.BmGame.RGameInfo.WeaponId EquippedWeapon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulateWeaponSkinUnlocks, "BmGame.GDUnlockUtilities.PopulateWeaponSkinUnlocks");
        byte* paramsPtr = stackalloc byte[144];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockMethod, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLevel, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLevel, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EquippedWeapon, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Unlocks = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData>>(paramsPtr + 20);
        return;
    }

    private static BmSDK.Function __fn_PopulateHeroSkinUnlocks;
    /// <summary>
    /// Function: PopulateHeroSkinUnlocks
    /// </summary>
    public unsafe static void PopulateHeroSkinUnlocks(BmSDK.BmGame.RPlayerController RPC, BmSDK.BmGame.GDUnlockableItemComponent.EUnlockMethod UnlockMethod, int StartLevel, int EndLevel, BmSDK.BmGame.GDUnlockUtilities.EUIUnlockType UnlockType, out BmSDK.TArray<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData> Unlocks)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulateHeroSkinUnlocks, "BmGame.GDUnlockUtilities.PopulateHeroSkinUnlocks");
        byte* paramsPtr = stackalloc byte[192];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockMethod, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLevel, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLevel, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockType, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Unlocks = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData>>(paramsPtr + 20);
        return;
    }

    private static BmSDK.Function __fn_PopulateCustomisationUnlocks;
    /// <summary>
    /// Function: PopulateCustomisationUnlocks
    /// </summary>
    public unsafe static void PopulateCustomisationUnlocks(BmSDK.BmGame.RPlayerController RPC, BmSDK.BmGame.GDPawnConfig OnConfig, BmSDK.BmGame.GDUnlockableItemComponent.EUnlockMethod UnlockMethod, int StartLevel, int EndLevel, BmSDK.BmGame.GDUnlockUtilities.EUIUnlockType UnlockType, out BmSDK.TArray<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData> Unlocks)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulateCustomisationUnlocks, "BmGame.GDUnlockUtilities.PopulateCustomisationUnlocks");
        byte* paramsPtr = stackalloc byte[152];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnConfig, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockMethod, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLevel, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLevel, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockType, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Unlocks = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData>>(paramsPtr + 24);
        return;
    }

    private static BmSDK.Function __fn_UnlockTypeToCustomisationPart;
    /// <summary>
    /// Function: UnlockTypeToCustomisationPart
    /// </summary>
    public unsafe static BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType UnlockTypeToCustomisationPart(BmSDK.BmGame.GDUnlockUtilities.EUIUnlockType UnlockType)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockTypeToCustomisationPart, "BmGame.GDUnlockUtilities.UnlockTypeToCustomisationPart");
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType>(paramsPtr + 1);
    }

    private static BmSDK.Function __fn_PopulateDashUpgradeUnlocks;
    /// <summary>
    /// Function: PopulateDashUpgradeUnlocks
    /// </summary>
    public unsafe static void PopulateDashUpgradeUnlocks(BmSDK.BmGame.RPlayerController RPC, BmSDK.BmGame.GDPawnConfig OnConfig, BmSDK.BmGame.GDUnlockableItemComponent.EUnlockMethod UnlockMethod, int StartLevel, int EndLevel, out BmSDK.TArray<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData> Unlocks)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulateDashUpgradeUnlocks, "BmGame.GDUnlockUtilities.PopulateDashUpgradeUnlocks");
        byte* paramsPtr = stackalloc byte[120];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnConfig, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockMethod, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLevel, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLevel, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Unlocks = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData>>(paramsPtr + 20);
        return;
    }

    private static BmSDK.Function __fn_PopulateLoadoutSlotUnlocks;
    /// <summary>
    /// Function: PopulateLoadoutSlotUnlocks
    /// </summary>
    public unsafe static void PopulateLoadoutSlotUnlocks(BmSDK.BmGame.RPlayerController RPC, BmSDK.BmGame.GDPawnConfig OnConfig, BmSDK.BmGame.GDUnlockableItemComponent.EUnlockMethod UnlockMethod, int StartLevel, int EndLevel, out BmSDK.TArray<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData> Unlocks)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulateLoadoutSlotUnlocks, "BmGame.GDUnlockUtilities.PopulateLoadoutSlotUnlocks");
        byte* paramsPtr = stackalloc byte[120];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnConfig, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockMethod, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLevel, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLevel, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Unlocks = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData>>(paramsPtr + 20);
        return;
    }

    private static BmSDK.Function __fn_GetUnlockIconForHeroGadget;
    /// <summary>
    /// Function: GetUnlockIconForHeroGadget
    /// </summary>
    public unsafe static BmSDK.FString GetUnlockIconForHeroGadget(BmSDK.BmGame.RGameInfo.PlayerGadgetId GadgetID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUnlockIconForHeroGadget, "BmGame.GDUnlockUtilities.GetUnlockIconForHeroGadget");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PopulateItemUnlocks;
    /// <summary>
    /// Function: PopulateItemUnlocks
    /// </summary>
    public unsafe static void PopulateItemUnlocks(BmSDK.BmGame.RPlayerController RPC, BmSDK.BmGame.GDPawnConfig OnConfig, BmSDK.BmGame.GDUnlockableItemComponent.EUnlockMethod UnlockMethod, int StartLevel, int EndLevel, out BmSDK.TArray<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData> Unlocks)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulateItemUnlocks, "BmGame.GDUnlockUtilities.PopulateItemUnlocks");
        byte* paramsPtr = stackalloc byte[140];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnConfig, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockMethod, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLevel, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLevel, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Unlocks = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData>>(paramsPtr + 20);
        return;
    }

    private static BmSDK.Function __fn_PopulateWeaponUpgrades;
    /// <summary>
    /// Function: PopulateWeaponUpgrades
    /// </summary>
    public unsafe static void PopulateWeaponUpgrades(BmSDK.BmGame.RPlayerController RPC, BmSDK.BmGame.GDUnlockableItemComponent.EUnlockMethod UnlockMethod, int StartLevel, int EndLevel, out BmSDK.TArray<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData> Unlocks, BmSDK.BmGame.RGameInfo.WeaponId EquippedWeapon)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulateWeaponUpgrades, "BmGame.GDUnlockUtilities.PopulateWeaponUpgrades");
        byte* paramsPtr = stackalloc byte[152];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockMethod, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLevel, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLevel, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EquippedWeapon, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Unlocks = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData>>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_PopulateWeaponUnlocks;
    /// <summary>
    /// Function: PopulateWeaponUnlocks
    /// </summary>
    public unsafe static void PopulateWeaponUnlocks(BmSDK.BmGame.RPlayerController RPC, BmSDK.BmGame.GDUnlockableItemComponent.EUnlockMethod UnlockMethod, int StartLevel, int EndLevel, out BmSDK.TArray<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData> Unlocks)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulateWeaponUnlocks, "BmGame.GDUnlockUtilities.PopulateWeaponUnlocks");
        byte* paramsPtr = stackalloc byte[140];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockMethod, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLevel, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLevel, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Unlocks = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData>>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_GetNewUnlocksForUnlockMethod;
    /// <summary>
    /// Function: GetNewUnlocksForUnlockMethod
    /// </summary>
    public unsafe static void GetNewUnlocksForUnlockMethod(BmSDK.BmGame.RPlayerController RPC, BmSDK.BmGame.GDUnlockUtilities.FSPawnConfigs Configs, int StartingValue, int EndingValue, BmSDK.BmGame.GDUnlockableItemComponent.EUnlockMethod UnlockMethod, out BmSDK.TArray<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData> Unlocks, BmSDK.BmGame.RGameInfo.WeaponId EquippedWeapon = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNewUnlocksForUnlockMethod, "BmGame.GDUnlockUtilities.GetNewUnlocksForUnlockMethod");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Configs, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartingValue, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndingValue, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockMethod, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EquippedWeapon, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Unlocks = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData>>(paramsPtr + 32);
        return;
    }

    /// <summary>
    /// InlineArray{StrProperty}: IconPackageNames
    /// </summary>
    public InlineArray<BmSDK.FString> IconPackageNames => new(22, Ptr + 48, 12, this);

    /// <summary>
    /// StrProperty: IconPackageNames
    /// </summary>
    public unsafe BmSDK.FString IconPackageNames_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }
    /// <summary>
    /// StrProperty: IconPackageNames
    /// </summary>
    public unsafe BmSDK.FString IconPackageNames_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }
    /// <summary>
    /// StrProperty: IconPackageNames
    /// </summary>
    public unsafe BmSDK.FString IconPackageNames_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }
    /// <summary>
    /// StrProperty: IconPackageNames
    /// </summary>
    public unsafe BmSDK.FString IconPackageNames_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
    /// <summary>
    /// StrProperty: IconPackageNames
    /// </summary>
    public unsafe BmSDK.FString IconPackageNames_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
    /// <summary>
    /// StrProperty: IconPackageNames
    /// </summary>
    public unsafe BmSDK.FString IconPackageNames_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }
    /// <summary>
    /// StrProperty: IconPackageNames
    /// </summary>
    public unsafe BmSDK.FString IconPackageNames_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }
    /// <summary>
    /// StrProperty: IconPackageNames
    /// </summary>
    public unsafe BmSDK.FString IconPackageNames_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }
    /// <summary>
    /// StrProperty: IconPackageNames
    /// </summary>
    public unsafe BmSDK.FString IconPackageNames_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }
    /// <summary>
    /// StrProperty: IconPackageNames
    /// </summary>
    public unsafe BmSDK.FString IconPackageNames_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }
    /// <summary>
    /// StrProperty: IconPackageNames
    /// </summary>
    public unsafe BmSDK.FString IconPackageNames_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }
    /// <summary>
    /// StrProperty: IconPackageNames
    /// </summary>
    public unsafe BmSDK.FString IconPackageNames_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }
    /// <summary>
    /// StrProperty: IconPackageNames
    /// </summary>
    public unsafe BmSDK.FString IconPackageNames_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }
    /// <summary>
    /// StrProperty: IconPackageNames
    /// </summary>
    public unsafe BmSDK.FString IconPackageNames_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }
    /// <summary>
    /// StrProperty: IconPackageNames
    /// </summary>
    public unsafe BmSDK.FString IconPackageNames_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }
    /// <summary>
    /// StrProperty: IconPackageNames
    /// </summary>
    public unsafe BmSDK.FString IconPackageNames_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }
    /// <summary>
    /// StrProperty: IconPackageNames
    /// </summary>
    public unsafe BmSDK.FString IconPackageNames_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }
    /// <summary>
    /// StrProperty: IconPackageNames
    /// </summary>
    public unsafe BmSDK.FString IconPackageNames_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }
    /// <summary>
    /// StrProperty: IconPackageNames
    /// </summary>
    public unsafe BmSDK.FString IconPackageNames_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }
    /// <summary>
    /// StrProperty: IconPackageNames
    /// </summary>
    public unsafe BmSDK.FString IconPackageNames_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }
    /// <summary>
    /// StrProperty: IconPackageNames
    /// </summary>
    public unsafe BmSDK.FString IconPackageNames_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }
    /// <summary>
    /// StrProperty: IconPackageNames
    /// </summary>
    public unsafe BmSDK.FString IconPackageNames_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// InlineArray{StrProperty}: IconNames
    /// </summary>
    public InlineArray<BmSDK.FString> IconNames => new(22, Ptr + 312, 12, this);

    /// <summary>
    /// StrProperty: IconNames
    /// </summary>
    public unsafe BmSDK.FString IconNames_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }
    /// <summary>
    /// StrProperty: IconNames
    /// </summary>
    public unsafe BmSDK.FString IconNames_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }
    /// <summary>
    /// StrProperty: IconNames
    /// </summary>
    public unsafe BmSDK.FString IconNames_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }
    /// <summary>
    /// StrProperty: IconNames
    /// </summary>
    public unsafe BmSDK.FString IconNames_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }
    /// <summary>
    /// StrProperty: IconNames
    /// </summary>
    public unsafe BmSDK.FString IconNames_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }
    /// <summary>
    /// StrProperty: IconNames
    /// </summary>
    public unsafe BmSDK.FString IconNames_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }
    /// <summary>
    /// StrProperty: IconNames
    /// </summary>
    public unsafe BmSDK.FString IconNames_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }
    /// <summary>
    /// StrProperty: IconNames
    /// </summary>
    public unsafe BmSDK.FString IconNames_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }
    /// <summary>
    /// StrProperty: IconNames
    /// </summary>
    public unsafe BmSDK.FString IconNames_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }
    /// <summary>
    /// StrProperty: IconNames
    /// </summary>
    public unsafe BmSDK.FString IconNames_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }
    /// <summary>
    /// StrProperty: IconNames
    /// </summary>
    public unsafe BmSDK.FString IconNames_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }
    /// <summary>
    /// StrProperty: IconNames
    /// </summary>
    public unsafe BmSDK.FString IconNames_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }
    /// <summary>
    /// StrProperty: IconNames
    /// </summary>
    public unsafe BmSDK.FString IconNames_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }
    /// <summary>
    /// StrProperty: IconNames
    /// </summary>
    public unsafe BmSDK.FString IconNames_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }
    /// <summary>
    /// StrProperty: IconNames
    /// </summary>
    public unsafe BmSDK.FString IconNames_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }
    /// <summary>
    /// StrProperty: IconNames
    /// </summary>
    public unsafe BmSDK.FString IconNames_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }
    /// <summary>
    /// StrProperty: IconNames
    /// </summary>
    public unsafe BmSDK.FString IconNames_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }
    /// <summary>
    /// StrProperty: IconNames
    /// </summary>
    public unsafe BmSDK.FString IconNames_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }
    /// <summary>
    /// StrProperty: IconNames
    /// </summary>
    public unsafe BmSDK.FString IconNames_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }
    /// <summary>
    /// StrProperty: IconNames
    /// </summary>
    public unsafe BmSDK.FString IconNames_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }
    /// <summary>
    /// StrProperty: IconNames
    /// </summary>
    public unsafe BmSDK.FString IconNames_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }
    /// <summary>
    /// StrProperty: IconNames
    /// </summary>
    public unsafe BmSDK.FString IconNames_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// StrProperty: BatmanIconName
    /// </summary>
    public unsafe BmSDK.FString BatmanIconName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// StrProperty: RobinIconName
    /// </summary>
    public unsafe BmSDK.FString RobinIconName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// StrProperty: BatmanSkinVarName
    /// </summary>
    public unsafe BmSDK.FString BatmanSkinVarName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// StrProperty: RobinSkinVarName
    /// </summary>
    public unsafe BmSDK.FString RobinSkinVarName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// Struct: FSPawnConfigs
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FSPawnConfigs
    {
        /// <summary>
        /// ObjectProperty: BatmanConfig
        /// </summary>
        public unsafe BmSDK.BmGame.GDPawnConfig BatmanConfig
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDPawnConfig>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: RobinConfig
        /// </summary>
        public unsafe BmSDK.BmGame.GDPawnConfig RobinConfig
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDPawnConfig>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ObjectProperty: JokerThugConfig
        /// </summary>
        public unsafe BmSDK.BmGame.GDPawnConfig JokerThugConfig
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDPawnConfig>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: BaneThugConfig
        /// </summary>
        public unsafe BmSDK.BmGame.GDPawnConfig BaneThugConfig
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDPawnConfig>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FSUnlockData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public partial record struct FSUnlockData
    {
        /// <summary>
        /// ByteProperty: UnlockType
        /// </summary>
        public unsafe BmSDK.BmGame.GDUnlockUtilities.EUIUnlockType UnlockType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDUnlockUtilities.EUIUnlockType>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: UnlockAtValue
        /// </summary>
        public unsafe int UnlockAtValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StrProperty: UnlockIcon
        /// </summary>
        public unsafe BmSDK.FString UnlockIcon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StrProperty: UnlockIconPackage
        /// </summary>
        public unsafe BmSDK.FString UnlockIconPackage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// StrProperty: ItemHeader
        /// </summary>
        public unsafe BmSDK.FString ItemHeader
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StrProperty: ItemName
        /// </summary>
        public unsafe BmSDK.FString ItemName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// IntProperty: CrateCost
        /// </summary>
        public unsafe int CrateCost
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }
    }

    /// <summary>
    /// Enum: EUIUnlockType
    /// </summary>
    public enum EUIUnlockType : byte
    {
        EUIUnlockType_Invalid = 0,
        EUIUnlockType_Weapon = 1,
        EUIUnlockType_WeaponUpgrade = 2,
        EUIUnlockType_HeroGadget = 3,
        EUIUnlockType_ThugItem = 4,
        EUIUnlockType_EnhancedVisionUpgrade = 5,
        EUIUnlockType_LoadoutSlot = 6,
        EUIUnlockType_DashUpgrade = 7,
        EUIUnlockType_CustomisationArchetype = 8,
        EUIUnlockType_CustomisationUndershirt = 9,
        EUIUnlockType_CustomisationTattoo = 10,
        EUIUnlockType_CustomisationFacePaint = 11,
        EUIUnlockType_CustomisationLower = 12,
        EUIUnlockType_CustomisationUpper = 13,
        EUIUnlockType_CustomisationFaceGear = 14,
        EUIUnlockType_CustomisationHair = 15,
        EUIUnlockType_CustomisationFacialHair = 16,
        EUIUnlockType_AffordableCrate = 17,
        EUIUnlockType_UnaffordableCrate = 18,
        EUIUnlockType_WeaponSkin = 19,
        EUIUnlockType_BatmanSkin = 20,
        EUIUnlockType_RobinSkin = 21,
        EUIUnlockType_MAX = 22,
    }
}
