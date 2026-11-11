#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDRecentlyUnlockedItemsProfileStorage<br/>
/// (size = 364)
/// (flags = 32786)
/// </summary>
public partial class GDRecentlyUnlockedItemsProfileStorage : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDRecentlyUnlockedItemsProfileStorage", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDRecentlyUnlockedItemsProfileStorage.
    /// </summary>
    public static GDRecentlyUnlockedItemsProfileStorage DefaultObject => (GDRecentlyUnlockedItemsProfileStorage)StaticClass().DefaultObject;

    internal GDRecentlyUnlockedItemsProfileStorage() { }

    /// <summary>
    /// Constructs a new GDRecentlyUnlockedItemsProfileStorage
    /// </summary>
    public GDRecentlyUnlockedItemsProfileStorage(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDRecentlyUnlockedItemsProfileStorage Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDRecentlyUnlockedItemsProfileStorage(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDRecentlyUnlockedItemsProfileStorage>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDRecentlyUnlockedItemsProfileStorage>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDRecentlyUnlockedItemsProfileStorage>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDRecentlyUnlockedItemsProfileStorage>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDRecentlyUnlockedItemsProfileStorage>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDRecentlyUnlockedItemsProfileStorage>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDRecentlyUnlockedItemsProfileStorage>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDRecentlyUnlockedItemsProfileStorage>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetVideoWatched;
    /// <summary>
    /// Function: SetVideoWatched
    /// </summary>
    public unsafe virtual void SetVideoWatched(BmSDK.FString VideoFilename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVideoWatched, "BmGame.GDRecentlyUnlockedItemsProfileStorage.SetVideoWatched");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VideoFilename, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsVideoWatched;
    /// <summary>
    /// Function: IsVideoWatched
    /// </summary>
    public unsafe virtual bool IsVideoWatched(BmSDK.FString VideoFilename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsVideoWatched, "BmGame.GDRecentlyUnlockedItemsProfileStorage.IsVideoWatched");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VideoFilename, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_AnyUnwatchedVideos;
    /// <summary>
    /// Function: AnyUnwatchedVideos
    /// </summary>
    public unsafe virtual bool AnyUnwatchedVideos()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnyUnwatchedVideos, "BmGame.GDRecentlyUnlockedItemsProfileStorage.AnyUnwatchedVideos");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCustArrayForTypeAndTeam;
    /// <summary>
    /// Function: GetCustArrayForTypeAndTeam
    /// </summary>
    public unsafe void GetCustArrayForTypeAndTeam(out BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSThugTeamRecentUnlocks TeamUnlocks, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType Type, out BmSDK.TArray<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSAppearanceRecentUnlockWithSkin> AppearanceArray)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCustArrayForTypeAndTeam, "BmGame.GDRecentlyUnlockedItemsProfileStorage.GetCustArrayForTypeAndTeam");
        byte* paramsPtr = stackalloc byte[164];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 132);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TeamUnlocks = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSThugTeamRecentUnlocks>(paramsPtr + 0);
        AppearanceArray = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSAppearanceRecentUnlockWithSkin>>(paramsPtr + 136);
        return;
    }

    private static BmSDK.Function __fn_AddRecentlyUnlockedCustPartToTeam;
    /// <summary>
    /// Function: AddRecentlyUnlockedCustPartToTeam
    /// </summary>
    public unsafe void AddRecentlyUnlockedCustPartToTeam(out BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSThugTeamRecentUnlocks TeamUnlocks, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType Type, BmSDK.FName ResourceID, int SkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddRecentlyUnlockedCustPartToTeam, "BmGame.GDRecentlyUnlockedItemsProfileStorage.AddRecentlyUnlockedCustPartToTeam");
        byte* paramsPtr = stackalloc byte[180];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 132);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResourceID, paramsPtr + 136);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkinIndex, paramsPtr + 144);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TeamUnlocks = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSThugTeamRecentUnlocks>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_FindAppearanceUnlockInList;
    /// <summary>
    /// Function: FindAppearanceUnlockInList
    /// </summary>
    public unsafe int FindAppearanceUnlockInList(in BmSDK.TArray<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSAppearanceRecentUnlockWithSkin> AppearanceArray, BmSDK.FName ResourceID, int SkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindAppearanceUnlockInList, "BmGame.GDRecentlyUnlockedItemsProfileStorage.FindAppearanceUnlockInList");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AppearanceArray, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResourceID, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkinIndex, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_RecentlyUnlockedCustomizationPart;
    /// <summary>
    /// Function: RecentlyUnlockedCustomizationPart
    /// </summary>
    public unsafe virtual void RecentlyUnlockedCustomizationPart(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType Type, BmSDK.FName ResourceID, int SkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecentlyUnlockedCustomizationPart, "BmGame.GDRecentlyUnlockedItemsProfileStorage.RecentlyUnlockedCustomizationPart");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResourceID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkinIndex, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearRecentlyUnlockedCustPartInTeam;
    /// <summary>
    /// Function: ClearRecentlyUnlockedCustPartInTeam
    /// </summary>
    public unsafe void ClearRecentlyUnlockedCustPartInTeam(out BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSThugTeamRecentUnlocks TeamUnlocks, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType Type, BmSDK.FName ResourceID, int SkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRecentlyUnlockedCustPartInTeam, "BmGame.GDRecentlyUnlockedItemsProfileStorage.ClearRecentlyUnlockedCustPartInTeam");
        byte* paramsPtr = stackalloc byte[168];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 132);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResourceID, paramsPtr + 136);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkinIndex, paramsPtr + 144);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TeamUnlocks = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSThugTeamRecentUnlocks>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_ClearRecentlyUnlockedCustPart;
    /// <summary>
    /// Function: ClearRecentlyUnlockedCustPart
    /// </summary>
    public unsafe virtual void ClearRecentlyUnlockedCustPart(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType Type, BmSDK.FName ResourceID, int SkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRecentlyUnlockedCustPart, "BmGame.GDRecentlyUnlockedItemsProfileStorage.ClearRecentlyUnlockedCustPart");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResourceID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkinIndex, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearRecentlyUnlockedCustParts;
    /// <summary>
    /// Function: ClearRecentlyUnlockedCustParts
    /// </summary>
    public unsafe virtual void ClearRecentlyUnlockedCustParts(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType Type)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRecentlyUnlockedCustParts, "BmGame.GDRecentlyUnlockedItemsProfileStorage.ClearRecentlyUnlockedCustParts");
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsCustPartRecentlyUnlocked;
    /// <summary>
    /// Function: IsCustPartRecentlyUnlocked
    /// </summary>
    public unsafe virtual bool IsCustPartRecentlyUnlocked(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType Type, BmSDK.FName ResourceID, int SkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCustPartRecentlyUnlocked, "BmGame.GDRecentlyUnlockedItemsProfileStorage.IsCustPartRecentlyUnlocked");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResourceID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkinIndex, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_RecentlyUnlockedWeaponSkin;
    /// <summary>
    /// Function: RecentlyUnlockedWeaponSkin
    /// </summary>
    public unsafe virtual void RecentlyUnlockedWeaponSkin(BmSDK.FName WeaponSkin)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecentlyUnlockedWeaponSkin, "BmGame.GDRecentlyUnlockedItemsProfileStorage.RecentlyUnlockedWeaponSkin");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponSkin, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearRecentlyUnlockedWeaponSkin;
    /// <summary>
    /// Function: ClearRecentlyUnlockedWeaponSkin
    /// </summary>
    public unsafe virtual void ClearRecentlyUnlockedWeaponSkin(BmSDK.FName WeaponSkin)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRecentlyUnlockedWeaponSkin, "BmGame.GDRecentlyUnlockedItemsProfileStorage.ClearRecentlyUnlockedWeaponSkin");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponSkin, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsWeaponSkinRecentlyUnlocked;
    /// <summary>
    /// Function: IsWeaponSkinRecentlyUnlocked
    /// </summary>
    public unsafe virtual bool IsWeaponSkinRecentlyUnlocked(BmSDK.FName WeaponSkin)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsWeaponSkinRecentlyUnlocked, "BmGame.GDRecentlyUnlockedItemsProfileStorage.IsWeaponSkinRecentlyUnlocked");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponSkin, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AddRecentlyUnlockedHeroSkinToArray;
    /// <summary>
    /// Function: AddRecentlyUnlockedHeroSkinToArray
    /// </summary>
    public unsafe void AddRecentlyUnlockedHeroSkinToArray(out BmSDK.TArray<int> HeroSkinUnlocks, int SkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddRecentlyUnlockedHeroSkinToArray, "BmGame.GDRecentlyUnlockedItemsProfileStorage.AddRecentlyUnlockedHeroSkinToArray");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkinIndex, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        HeroSkinUnlocks = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<int>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_RecentlyUnlockedHeroSkin;
    /// <summary>
    /// Function: RecentlyUnlockedHeroSkin
    /// </summary>
    public unsafe virtual void RecentlyUnlockedHeroSkin(BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter Character, int SkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecentlyUnlockedHeroSkin, "BmGame.GDRecentlyUnlockedItemsProfileStorage.RecentlyUnlockedHeroSkin");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Character, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkinIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearRecentlyUnlockedHeroSkinInArray;
    /// <summary>
    /// Function: ClearRecentlyUnlockedHeroSkinInArray
    /// </summary>
    public unsafe void ClearRecentlyUnlockedHeroSkinInArray(out BmSDK.TArray<int> HeroSkinUnlocks, int SkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRecentlyUnlockedHeroSkinInArray, "BmGame.GDRecentlyUnlockedItemsProfileStorage.ClearRecentlyUnlockedHeroSkinInArray");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkinIndex, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        HeroSkinUnlocks = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<int>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_ClearRecentlyUnlockedHeroSkin;
    /// <summary>
    /// Function: ClearRecentlyUnlockedHeroSkin
    /// </summary>
    public unsafe virtual void ClearRecentlyUnlockedHeroSkin(BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter Character, int SkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRecentlyUnlockedHeroSkin, "BmGame.GDRecentlyUnlockedItemsProfileStorage.ClearRecentlyUnlockedHeroSkin");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Character, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkinIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsHeroSkinRecentlyUnlocked;
    /// <summary>
    /// Function: IsHeroSkinRecentlyUnlocked
    /// </summary>
    public unsafe virtual bool IsHeroSkinRecentlyUnlocked(BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter Character, int SkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsHeroSkinRecentlyUnlocked, "BmGame.GDRecentlyUnlockedItemsProfileStorage.IsHeroSkinRecentlyUnlocked");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Character, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkinIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AddRecentlyUnlockedGadgetToTeam;
    /// <summary>
    /// Function: AddRecentlyUnlockedGadgetToTeam
    /// </summary>
    public unsafe void AddRecentlyUnlockedGadgetToTeam(out BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSThugTeamRecentUnlocks TeamUnlocks, BmSDK.FName GadgetName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddRecentlyUnlockedGadgetToTeam, "BmGame.GDRecentlyUnlockedItemsProfileStorage.AddRecentlyUnlockedGadgetToTeam");
        byte* paramsPtr = stackalloc byte[160];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetName, paramsPtr + 132);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TeamUnlocks = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSThugTeamRecentUnlocks>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_RecentlyUnlockedGadget;
    /// <summary>
    /// Function: RecentlyUnlockedGadget
    /// </summary>
    public unsafe virtual void RecentlyUnlockedGadget(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team, BmSDK.FName GadgetName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecentlyUnlockedGadget, "BmGame.GDRecentlyUnlockedItemsProfileStorage.RecentlyUnlockedGadget");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearRecentlyUnlockedGadgetInTeam;
    /// <summary>
    /// Function: ClearRecentlyUnlockedGadgetInTeam
    /// </summary>
    public unsafe void ClearRecentlyUnlockedGadgetInTeam(out BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSThugTeamRecentUnlocks TeamUnlocks, BmSDK.FName GadgetName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRecentlyUnlockedGadgetInTeam, "BmGame.GDRecentlyUnlockedItemsProfileStorage.ClearRecentlyUnlockedGadgetInTeam");
        byte* paramsPtr = stackalloc byte[160];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetName, paramsPtr + 132);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TeamUnlocks = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSThugTeamRecentUnlocks>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_ClearRecentlyUnlockedGadget;
    /// <summary>
    /// Function: ClearRecentlyUnlockedGadget
    /// </summary>
    public unsafe virtual void ClearRecentlyUnlockedGadget(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team, BmSDK.FName GadgetName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRecentlyUnlockedGadget, "BmGame.GDRecentlyUnlockedItemsProfileStorage.ClearRecentlyUnlockedGadget");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsGadgetRecentlyUnlocked;
    /// <summary>
    /// Function: IsGadgetRecentlyUnlocked
    /// </summary>
    public unsafe virtual bool IsGadgetRecentlyUnlocked(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team, BmSDK.FName GadgetName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsGadgetRecentlyUnlocked, "BmGame.GDRecentlyUnlockedItemsProfileStorage.IsGadgetRecentlyUnlocked");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_AddRecentlyUnlockedWeaponToTeam;
    /// <summary>
    /// Function: AddRecentlyUnlockedWeaponToTeam
    /// </summary>
    public unsafe void AddRecentlyUnlockedWeaponToTeam(out BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSThugTeamRecentUnlocks TeamUnlocks, BmSDK.FName WeaponName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddRecentlyUnlockedWeaponToTeam, "BmGame.GDRecentlyUnlockedItemsProfileStorage.AddRecentlyUnlockedWeaponToTeam");
        byte* paramsPtr = stackalloc byte[160];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponName, paramsPtr + 132);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TeamUnlocks = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSThugTeamRecentUnlocks>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_RecentlyUnlockedWeapon;
    /// <summary>
    /// Function: RecentlyUnlockedWeapon
    /// </summary>
    public unsafe virtual void RecentlyUnlockedWeapon(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team, BmSDK.FName WeaponName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecentlyUnlockedWeapon, "BmGame.GDRecentlyUnlockedItemsProfileStorage.RecentlyUnlockedWeapon");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearRecentlyUnlockedWeaponInTeam;
    /// <summary>
    /// Function: ClearRecentlyUnlockedWeaponInTeam
    /// </summary>
    public unsafe void ClearRecentlyUnlockedWeaponInTeam(out BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSThugTeamRecentUnlocks TeamUnlocks, BmSDK.FName WeaponName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRecentlyUnlockedWeaponInTeam, "BmGame.GDRecentlyUnlockedItemsProfileStorage.ClearRecentlyUnlockedWeaponInTeam");
        byte* paramsPtr = stackalloc byte[160];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponName, paramsPtr + 132);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TeamUnlocks = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSThugTeamRecentUnlocks>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_ClearRecentlyUnlockedWeapon;
    /// <summary>
    /// Function: ClearRecentlyUnlockedWeapon
    /// </summary>
    public unsafe virtual void ClearRecentlyUnlockedWeapon(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team, BmSDK.FName WeaponName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRecentlyUnlockedWeapon, "BmGame.GDRecentlyUnlockedItemsProfileStorage.ClearRecentlyUnlockedWeapon");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsWeaponRecentlyUnlocked;
    /// <summary>
    /// Function: IsWeaponRecentlyUnlocked
    /// </summary>
    public unsafe virtual bool IsWeaponRecentlyUnlocked(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team, BmSDK.FName WeaponName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsWeaponRecentlyUnlocked, "BmGame.GDRecentlyUnlockedItemsProfileStorage.IsWeaponRecentlyUnlocked");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_AnyNewHeroSkins;
    /// <summary>
    /// Function: AnyNewHeroSkins
    /// </summary>
    public unsafe virtual bool AnyNewHeroSkins(BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter Character)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnyNewHeroSkins, "BmGame.GDRecentlyUnlockedItemsProfileStorage.AnyNewHeroSkins");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Character, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AnythingNew;
    /// <summary>
    /// Function: AnythingNew
    /// </summary>
    public unsafe virtual bool AnythingNew(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnythingNew, "BmGame.GDRecentlyUnlockedItemsProfileStorage.AnythingNew");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AnyNewWeaponSkins;
    /// <summary>
    /// Function: AnyNewWeaponSkins
    /// </summary>
    public unsafe virtual bool AnyNewWeaponSkins()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnyNewWeaponSkins, "BmGame.GDRecentlyUnlockedItemsProfileStorage.AnyNewWeaponSkins");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AnyNewWeapons;
    /// <summary>
    /// Function: AnyNewWeapons
    /// </summary>
    public unsafe virtual bool AnyNewWeapons(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnyNewWeapons, "BmGame.GDRecentlyUnlockedItemsProfileStorage.AnyNewWeapons");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AnyNewGadgets;
    /// <summary>
    /// Function: AnyNewGadgets
    /// </summary>
    public unsafe virtual bool AnyNewGadgets(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnyNewGadgets, "BmGame.GDRecentlyUnlockedItemsProfileStorage.AnyNewGadgets");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AnyNewCustType;
    /// <summary>
    /// Function: AnyNewCustType
    /// </summary>
    public unsafe virtual bool AnyNewCustType(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType Type)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnyNewCustType, "BmGame.GDRecentlyUnlockedItemsProfileStorage.AnyNewCustType");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AnyNewAppearances;
    /// <summary>
    /// Function: AnyNewAppearances
    /// </summary>
    public unsafe virtual bool AnyNewAppearances(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnyNewAppearances, "BmGame.GDRecentlyUnlockedItemsProfileStorage.AnyNewAppearances");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PrintAllRecentItems;
    /// <summary>
    /// Function: PrintAllRecentItems
    /// </summary>
    public unsafe virtual void PrintAllRecentItems()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrintAllRecentItems, "BmGame.GDRecentlyUnlockedItemsProfileStorage.PrintAllRecentItems");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StructProperty: BaneTeamRecentUnlocks
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSThugTeamRecentUnlocks BaneTeamRecentUnlocks
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSThugTeamRecentUnlocks>(Ptr + 48);

    /// <summary>
    /// StructProperty: JokerTeamRecentUnlocks
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSThugTeamRecentUnlocks JokerTeamRecentUnlocks
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSThugTeamRecentUnlocks>(Ptr + 180);

    /// <summary>
    /// ArrayProperty: WeaponSkinRecentUnlocks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> WeaponSkinRecentUnlocks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// ArrayProperty: BatmanSkinRecentUnlocks
    /// </summary>
    public unsafe BmSDK.TArray<int> BatmanSkinRecentUnlocks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// ArrayProperty: RobinSkinRecentUnlocks
    /// </summary>
    public unsafe BmSDK.TArray<int> RobinSkinRecentUnlocks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// ArrayProperty: WatchedVideoList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> WatchedVideoList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// IntProperty: NumVideos
    /// </summary>
    public unsafe int NumVideos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// Struct: FSThugTeamRecentUnlocks
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 132)]
    public partial record struct FSThugTeamRecentUnlocks
    {
        /// <summary>
        /// ArrayProperty: WeaponRecentUnlocks
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> WeaponRecentUnlocks
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: GadgetRecentUnlocks
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> GadgetRecentUnlocks
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: AppearanceRecentUnlocks
        /// </summary>
        public unsafe BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSAppearanceRecentUnlocks AppearanceRecentUnlocks
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSAppearanceRecentUnlocks>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FSAppearanceRecentUnlocks
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 108)]
    public partial record struct FSAppearanceRecentUnlocks
    {
        /// <summary>
        /// ArrayProperty: ArchetypeRecentUnlocks
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSAppearanceRecentUnlockWithSkin> ArchetypeRecentUnlocks
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSAppearanceRecentUnlockWithSkin>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: UndershirtRecentUnlocks
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSAppearanceRecentUnlockWithSkin> UndershirtRecentUnlocks
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSAppearanceRecentUnlockWithSkin>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ArrayProperty: TattooRecentUnlocks
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSAppearanceRecentUnlockWithSkin> TattooRecentUnlocks
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSAppearanceRecentUnlockWithSkin>>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ArrayProperty: FacePaintRecentUnlocks
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSAppearanceRecentUnlockWithSkin> FacePaintRecentUnlocks
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSAppearanceRecentUnlockWithSkin>>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// ArrayProperty: LowerRecentUnlocks
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSAppearanceRecentUnlockWithSkin> LowerRecentUnlocks
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSAppearanceRecentUnlockWithSkin>>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// ArrayProperty: UpperRecentUnlocks
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSAppearanceRecentUnlockWithSkin> UpperRecentUnlocks
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSAppearanceRecentUnlockWithSkin>>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// ArrayProperty: FaceGearRecentUnlocks
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSAppearanceRecentUnlockWithSkin> FaceGearRecentUnlocks
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSAppearanceRecentUnlockWithSkin>>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// ArrayProperty: HairRecentUnlocks
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSAppearanceRecentUnlockWithSkin> HairRecentUnlocks
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSAppearanceRecentUnlockWithSkin>>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// ArrayProperty: FacialHairRecentUnlocks
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSAppearanceRecentUnlockWithSkin> FacialHairRecentUnlocks
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage.FSAppearanceRecentUnlockWithSkin>>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }
    }

    /// <summary>
    /// Struct: FSAppearanceRecentUnlockWithSkin
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FSAppearanceRecentUnlockWithSkin
    {
        /// <summary>
        /// NameProperty: RecentUnlock
        /// </summary>
        public unsafe BmSDK.FName RecentUnlock
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: SkinIndex
        /// </summary>
        public unsafe int SkinIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }
}
