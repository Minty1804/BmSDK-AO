#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDCharCustomizationManager<br/>
/// (size = 320)
/// (flags = 134250650)
/// </summary>
public partial class GDCharCustomizationManager : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDCharCustomizationManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDCharCustomizationManager.
    /// </summary>
    public static GDCharCustomizationManager DefaultObject => (GDCharCustomizationManager)StaticClass().DefaultObject;

    internal GDCharCustomizationManager() { }

    /// <summary>
    /// Constructs a new GDCharCustomizationManager
    /// </summary>
    public GDCharCustomizationManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDCharCustomizationManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDCharCustomizationManager(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDCharCustomizationManager>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDCharCustomizationManager>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDCharCustomizationManager>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDCharCustomizationManager>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDCharCustomizationManager>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDCharCustomizationManager>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDCharCustomizationManager>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDCharCustomizationManager>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetAppearanceListIconName;
    /// <summary>
    /// Function: GetAppearanceListIconName
    /// </summary>
    public unsafe virtual BmSDK.FString GetAppearanceListIconName(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType ForType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAppearanceListIconName, "BmGame.GDCharCustomizationManager.GetAppearanceListIconName");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetRandomCustomization;
    /// <summary>
    /// Function: GetRandomCustomization
    /// </summary>
    public unsafe virtual void GetRandomCustomization(int CustomizationTeamIndex, out BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection outCustomSelection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRandomCustomization, "BmGame.GDCharCustomizationManager.GetRandomCustomization");
        byte* paramsPtr = stackalloc byte[340];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out outCustomSelection);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(outCustomSelection, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outCustomSelection = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_GetRandomHairColor;
    /// <summary>
    /// Function: GetRandomHairColor
    /// </summary>
    public unsafe virtual BmSDK.GameObject.FColor GetRandomHairColor(int CustomizationTeamIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRandomHairColor, "BmGame.GDCharCustomizationManager.GetRandomHairColor");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FColor>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetRandomPartIndex;
    /// <summary>
    /// Function: GetRandomPartIndex
    /// </summary>
    public unsafe virtual int GetRandomPartIndex(int CustomizationTeamIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, bool AllowNone)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRandomPartIndex, "BmGame.GDCharCustomizationManager.GetRandomPartIndex");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AllowNone, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ListPlayerPreloadedSets;
    /// <summary>
    /// Function: ListPlayerPreloadedSets
    /// </summary>
    public unsafe virtual void ListPlayerPreloadedSets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListPlayerPreloadedSets, "BmGame.GDCharCustomizationManager.ListPlayerPreloadedSets");
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

    private static BmSDK.Function __fn_ListPreloadedSkins;
    /// <summary>
    /// Function: ListPreloadedSkins
    /// </summary>
    public unsafe virtual void ListPreloadedSkins()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListPreloadedSkins, "BmGame.GDCharCustomizationManager.ListPreloadedSkins");
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

    private static BmSDK.Function __fn_LogFreeMemory;
    /// <summary>
    /// Function: LogFreeMemory
    /// </summary>
    public unsafe virtual void LogFreeMemory()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogFreeMemory, "BmGame.GDCharCustomizationManager.LogFreeMemory");
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

    private static BmSDK.Function __fn_ListLoadedCustomSelection;
    /// <summary>
    /// Function: ListLoadedCustomSelection
    /// </summary>
    public unsafe static void ListLoadedCustomSelection(in BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection LoadedSelection)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListLoadedCustomSelection, "BmGame.GDCharCustomizationManager.ListLoadedCustomSelection");
        byte* paramsPtr = stackalloc byte[224];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelection, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_ListCustomSelection;
    /// <summary>
    /// Function: ListCustomSelection
    /// </summary>
    public unsafe static void ListCustomSelection(in BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection Selection)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListCustomSelection, "BmGame.GDCharCustomizationManager.ListCustomSelection");
        byte* paramsPtr = stackalloc byte[112];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Selection, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_ListLoadedSets;
    /// <summary>
    /// Function: ListLoadedSets
    /// </summary>
    public unsafe virtual void ListLoadedSets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListLoadedSets, "BmGame.GDCharCustomizationManager.ListLoadedSets");
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

    private static BmSDK.Function __fn_ListLoadedResources;
    /// <summary>
    /// Function: ListLoadedResources
    /// </summary>
    public unsafe virtual void ListLoadedResources()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListLoadedResources, "BmGame.GDCharCustomizationManager.ListLoadedResources");
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

    private static BmSDK.Function __fn_ConvertSelectionFromIndexes;
    /// <summary>
    /// Function: ConvertSelectionFromIndexes
    /// </summary>
    public unsafe virtual void ConvertSelectionFromIndexes(BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelectionIndexed IndexedSelection, out BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection outCustomSelection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConvertSelectionFromIndexes, "BmGame.GDCharCustomizationManager.ConvertSelectionFromIndexes");
        byte* paramsPtr = stackalloc byte[180];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IndexedSelection, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out outCustomSelection);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(outCustomSelection, paramsPtr + 64);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outCustomSelection = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection>(paramsPtr + 64);
        return;
    }

    private static BmSDK.Function __fn_ConvertSelectionToIndexes;
    /// <summary>
    /// Function: ConvertSelectionToIndexes
    /// </summary>
    public unsafe virtual void ConvertSelectionToIndexes(BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection customSelection, out BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelectionIndexed IndexedSelection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConvertSelectionToIndexes, "BmGame.GDCharCustomizationManager.ConvertSelectionToIndexes");
        byte* paramsPtr = stackalloc byte[184];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(customSelection, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out IndexedSelection);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IndexedSelection, paramsPtr + 96);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        IndexedSelection = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelectionIndexed>(paramsPtr + 96);
        return;
    }

    private static BmSDK.Function __fn_ResetIndexedSelection;
    /// <summary>
    /// Function: ResetIndexedSelection
    /// </summary>
    public unsafe virtual void ResetIndexedSelection(out BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelectionIndexed IndexedSelection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetIndexedSelection, "BmGame.GDCharCustomizationManager.ResetIndexedSelection");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out IndexedSelection);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IndexedSelection, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        IndexedSelection = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelectionIndexed>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SwitchAltMeshes;
    /// <summary>
    /// Function: SwitchAltMeshes
    /// </summary>
    public unsafe virtual void SwitchAltMeshes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchAltMeshes, "BmGame.GDCharCustomizationManager.SwitchAltMeshes");
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

    private static BmSDK.Function __fn_UpdateCharAltMeshIndex;
    /// <summary>
    /// Function: UpdateCharAltMeshIndex
    /// </summary>
    public unsafe virtual void UpdateCharAltMeshIndex(BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter AltMeshChar, int CharAltMeshIndex, bool ForceReloadPlayableMeshes)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCharAltMeshIndex, "BmGame.GDCharCustomizationManager.UpdateCharAltMeshIndex");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AltMeshChar, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharAltMeshIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceReloadPlayableMeshes, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SyncLocalPlayerActiveCharacterAltMesh;
    /// <summary>
    /// Function: SyncLocalPlayerActiveCharacterAltMesh
    /// </summary>
    public unsafe virtual void SyncLocalPlayerActiveCharacterAltMesh(BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter AltMeshChar)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SyncLocalPlayerActiveCharacterAltMesh, "BmGame.GDCharCustomizationManager.SyncLocalPlayerActiveCharacterAltMesh");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AltMeshChar, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SyncPlayerCharacterAltMesh;
    /// <summary>
    /// Function: SyncPlayerCharacterAltMesh
    /// </summary>
    public unsafe virtual void SyncPlayerCharacterAltMesh(BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter AltMeshChar, int SkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SyncPlayerCharacterAltMesh, "BmGame.GDCharCustomizationManager.SyncPlayerCharacterAltMesh");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AltMeshChar, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkinIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPreloadedAltSkinPlayerMesh;
    /// <summary>
    /// Function: GetPreloadedAltSkinPlayerMesh
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAddContentPlayerCharacterMesh GetPreloadedAltSkinPlayerMesh(int CharacterIndex, int AlternateSkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPreloadedAltSkinPlayerMesh, "BmGame.GDCharCustomizationManager.GetPreloadedAltSkinPlayerMesh");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AlternateSkinIndex, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAddContentPlayerCharacterMesh>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetMeshPackageNameFromAltSkinIndex;
    /// <summary>
    /// Function: GetMeshPackageNameFromAltSkinIndex
    /// </summary>
    public unsafe virtual void GetMeshPackageNameFromAltSkinIndex(int CharacterIndex, int AlternateSkinIndex, out BmSDK.FString OutName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMeshPackageNameFromAltSkinIndex, "BmGame.GDCharCustomizationManager.GetMeshPackageNameFromAltSkinIndex");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AlternateSkinIndex, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_IsAltSkinPreloaded;
    /// <summary>
    /// Function: IsAltSkinPreloaded
    /// </summary>
    public unsafe virtual bool IsAltSkinPreloaded(int CharacterIndex, int AlternateSkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAltSkinPreloaded, "BmGame.GDCharCustomizationManager.IsAltSkinPreloaded");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AlternateSkinIndex, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_UpdatePrevAltSkin;
    /// <summary>
    /// Function: UpdatePrevAltSkin
    /// </summary>
    public unsafe virtual void UpdatePrevAltSkin(int CharacterIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePrevAltSkin, "BmGame.GDCharCustomizationManager.UpdatePrevAltSkin");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterIndex, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetPreviousCharacterAltSkin;
    /// <summary>
    /// Function: GetPreviousCharacterAltSkin
    /// </summary>
    public unsafe virtual int GetPreviousCharacterAltSkin(int CharacterIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPreviousCharacterAltSkin, "BmGame.GDCharCustomizationManager.GetPreviousCharacterAltSkin");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterIndex, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetCurrentCharacterAltSkin;
    /// <summary>
    /// Function: GetCurrentCharacterAltSkin
    /// </summary>
    public unsafe virtual int GetCurrentCharacterAltSkin(int CharacterIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentCharacterAltSkin, "BmGame.GDCharCustomizationManager.GetCurrentCharacterAltSkin");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterIndex, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetNumAvailableAltMeshes;
    /// <summary>
    /// Function: GetNumAvailableAltMeshes
    /// </summary>
    public unsafe virtual int GetNumAvailableAltMeshes(int CharacterIndex, bool bEntitledOnly)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumAvailableAltMeshes, "BmGame.GDCharCustomizationManager.GetNumAvailableAltMeshes");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEntitledOnly, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetAltMeshCharacterIndex;
    /// <summary>
    /// Function: GetAltMeshCharacterIndex
    /// </summary>
    public unsafe virtual int GetAltMeshCharacterIndex(BmSDK.FName CharacterNameID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAltMeshCharacterIndex, "BmGame.GDCharCustomizationManager.GetAltMeshCharacterIndex");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterNameID, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetActiveBatmanAltMeshIndex;
    /// <summary>
    /// Function: GetActiveBatmanAltMeshIndex
    /// </summary>
    public unsafe virtual int GetActiveBatmanAltMeshIndex(BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter AltMeshChar)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetActiveBatmanAltMeshIndex, "BmGame.GDCharCustomizationManager.GetActiveBatmanAltMeshIndex");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AltMeshChar, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetActiveCharAltMeshIndex;
    /// <summary>
    /// Function: SetActiveCharAltMeshIndex
    /// </summary>
    public unsafe virtual void SetActiveCharAltMeshIndex(BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter AltMeshChar, int CurrentAltMeshIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetActiveCharAltMeshIndex, "BmGame.GDCharCustomizationManager.SetActiveCharAltMeshIndex");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AltMeshChar, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentAltMeshIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetLocalCharAltMeshIndex;
    /// <summary>
    /// Function: GetLocalCharAltMeshIndex
    /// </summary>
    public unsafe virtual int GetLocalCharAltMeshIndex(BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter AltMeshChar)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocalCharAltMeshIndex, "BmGame.GDCharCustomizationManager.GetLocalCharAltMeshIndex");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AltMeshChar, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetLocalCharAltMeshIndex;
    /// <summary>
    /// Function: SetLocalCharAltMeshIndex
    /// </summary>
    public unsafe virtual void SetLocalCharAltMeshIndex(BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter AltMeshChar, int CurrentAltMeshIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLocalCharAltMeshIndex, "BmGame.GDCharCustomizationManager.SetLocalCharAltMeshIndex");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AltMeshChar, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentAltMeshIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateActiveAltSkin;
    /// <summary>
    /// Function: UpdateActiveAltSkin
    /// </summary>
    public unsafe virtual void UpdateActiveAltSkin()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateActiveAltSkin, "BmGame.GDCharCustomizationManager.UpdateActiveAltSkin");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReleaseAltSkinRef;
    /// <summary>
    /// Function: ReleaseAltSkinRef
    /// </summary>
    public unsafe virtual void ReleaseAltSkinRef(BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter AltMeshChar, int CharAltMeshIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseAltSkinRef, "BmGame.GDCharCustomizationManager.ReleaseAltSkinRef");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AltMeshChar, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharAltMeshIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddAltSkinRef;
    /// <summary>
    /// Function: AddAltSkinRef
    /// </summary>
    public unsafe virtual void AddAltSkinRef(BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter AltMeshChar, int CharAltMeshIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddAltSkinRef, "BmGame.GDCharCustomizationManager.AddAltSkinRef");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AltMeshChar, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharAltMeshIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPreloadedAltSkin;
    /// <summary>
    /// Function: AddPreloadedAltSkin
    /// </summary>
    public unsafe virtual void AddPreloadedAltSkin(BmSDK.Engine.OnlineSubsystem.FUniqueNetId MemberNetId, BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter AltMeshChar, int CharAltMeshIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPreloadedAltSkin, "BmGame.GDCharCustomizationManager.AddPreloadedAltSkin");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MemberNetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AltMeshChar, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharAltMeshIndex, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdatePreloadedAltSkin;
    /// <summary>
    /// Function: UpdatePreloadedAltSkin
    /// </summary>
    public unsafe virtual void UpdatePreloadedAltSkin(int PreloadedAltSkinDataIndex, BmSDK.Engine.OnlineSubsystem.FUniqueNetId MemberNetId, BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter AltMeshChar, int CharAltMeshIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePreloadedAltSkin, "BmGame.GDCharCustomizationManager.UpdatePreloadedAltSkin");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreloadedAltSkinDataIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MemberNetId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AltMeshChar, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharAltMeshIndex, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindPreloadedAltSkinData;
    /// <summary>
    /// Function: FindPreloadedAltSkinData
    /// </summary>
    public unsafe virtual int FindPreloadedAltSkinData(BmSDK.Engine.OnlineSubsystem.FUniqueNetId MemberNetId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPreloadedAltSkinData, "BmGame.GDCharCustomizationManager.FindPreloadedAltSkinData");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MemberNetId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetPlayerSelectedSkin;
    /// <summary>
    /// Function: GetPlayerSelectedSkin
    /// </summary>
    public unsafe virtual int GetPlayerSelectedSkin(BmSDK.Engine.OnlineSubsystem.FUniqueNetId UniqueId, BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter AltMeshChar)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerSelectedSkin, "BmGame.GDCharCustomizationManager.GetPlayerSelectedSkin");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UniqueId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AltMeshChar, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ReleasePreloadedAltSkins;
    /// <summary>
    /// Function: ReleasePreloadedAltSkins
    /// </summary>
    public unsafe virtual void ReleasePreloadedAltSkins()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleasePreloadedAltSkins, "BmGame.GDCharCustomizationManager.ReleasePreloadedAltSkins");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreloadAltSkin;
    /// <summary>
    /// Function: PreloadAltSkin
    /// </summary>
    public unsafe virtual void PreloadAltSkin(BmSDK.Engine.OnlineSubsystem.FUniqueNetId MemberNetId, BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter AltMeshChar, int CharAltMeshIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreloadAltSkin, "BmGame.GDCharCustomizationManager.PreloadAltSkin");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MemberNetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AltMeshChar, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharAltMeshIndex, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendLocalBatmanSkinSelection;
    /// <summary>
    /// Function: SendLocalBatmanSkinSelection
    /// </summary>
    public unsafe virtual void SendLocalBatmanSkinSelection()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendLocalBatmanSkinSelection, "BmGame.GDCharCustomizationManager.SendLocalBatmanSkinSelection");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckAllPreloadAssetsAreLoaded;
    /// <summary>
    /// Function: CheckAllPreloadAssetsAreLoaded
    /// </summary>
    public unsafe virtual bool CheckAllPreloadAssetsAreLoaded()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckAllPreloadAssetsAreLoaded, "BmGame.GDCharCustomizationManager.CheckAllPreloadAssetsAreLoaded");
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

    private static BmSDK.Function __fn_GetCustomizationTeamIndexForPlayer;
    /// <summary>
    /// Function: GetCustomizationTeamIndexForPlayer
    /// </summary>
    public unsafe virtual int GetCustomizationTeamIndexForPlayer(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCustomizationTeamIndexForPlayer, "BmGame.GDCharCustomizationManager.GetCustomizationTeamIndexForPlayer");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetThugPlayerPreloadedCustomizationId;
    /// <summary>
    /// Function: GetThugPlayerPreloadedCustomizationId
    /// </summary>
    public unsafe virtual int GetThugPlayerPreloadedCustomizationId(BmSDK.Engine.OnlineSubsystem.FUniqueNetId UniqueId, int TeamID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThugPlayerPreloadedCustomizationId, "BmGame.GDCharCustomizationManager.GetThugPlayerPreloadedCustomizationId");
        byte* paramsPtr = stackalloc byte[120];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UniqueId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamID, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_AddPreloadedPlayerData;
    /// <summary>
    /// Function: AddPreloadedPlayerData
    /// </summary>
    public unsafe virtual int AddPreloadedPlayerData(BmSDK.Engine.OnlineSubsystem.FUniqueNetId MemberNetId, BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection> currentCustomizationSets)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPreloadedPlayerData, "BmGame.GDCharCustomizationManager.AddPreloadedPlayerData");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MemberNetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(currentCustomizationSets, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_FindPreloadedPlayerDataIndex;
    /// <summary>
    /// Function: FindPreloadedPlayerDataIndex
    /// </summary>
    public unsafe virtual int FindPreloadedPlayerDataIndex(BmSDK.Engine.OnlineSubsystem.FUniqueNetId MemberNetId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPreloadedPlayerDataIndex, "BmGame.GDCharCustomizationManager.FindPreloadedPlayerDataIndex");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MemberNetId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PreloadPlayerCustomSet;
    /// <summary>
    /// Function: PreloadPlayerCustomSet
    /// </summary>
    public unsafe virtual void PreloadPlayerCustomSet(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, out BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationPlayerPreloadData playerPreloadData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreloadPlayerCustomSet, "BmGame.GDCharCustomizationManager.PreloadPlayerCustomSet");
        byte* paramsPtr = stackalloc byte[160];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        playerPreloadData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationPlayerPreloadData>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_PreloadCustomSets;
    /// <summary>
    /// Function: PreloadCustomSets
    /// </summary>
    public unsafe virtual void PreloadCustomSets(BmSDK.TArray<BmSDK.SDEngine.SDLobbySystem.FSDLobbyMember> LobbyMemberList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreloadCustomSets, "BmGame.GDCharCustomizationManager.PreloadCustomSets");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyMemberList, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MemberListUpdatedDelegate;
    /// <summary>
    /// Function: MemberListUpdatedDelegate
    /// </summary>
    public unsafe virtual void MemberListUpdatedDelegate(BmSDK.TArray<BmSDK.SDEngine.SDLobbySystem.FSDLobbyMember> NewMemberList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MemberListUpdatedDelegate, "BmGame.GDCharCustomizationManager.MemberListUpdatedDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMemberList, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CleanPreloadedData;
    /// <summary>
    /// Function: CleanPreloadedData
    /// </summary>
    public unsafe virtual void CleanPreloadedData(BmSDK.TArray<BmSDK.SDEngine.SDLobbySystem.FSDLobbyMember> NewMemberList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CleanPreloadedData, "BmGame.GDCharCustomizationManager.CleanPreloadedData");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMemberList, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessLobbyCustomizationMessage;
    /// <summary>
    /// Function: ProcessLobbyCustomizationMessage
    /// </summary>
    public unsafe virtual void ProcessLobbyCustomizationMessage(BmSDK.Engine.OnlineSubsystem.FUniqueNetId MemberNetId, BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelectionIndexed> CurrentCustomizationSetsIndexed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessLobbyCustomizationMessage, "BmGame.GDCharCustomizationManager.ProcessLobbyCustomizationMessage");
        byte* paramsPtr = stackalloc byte[160];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MemberNetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentCustomizationSetsIndexed, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessLobbyCustomizationMessages;
    /// <summary>
    /// Function: ProcessLobbyCustomizationMessages
    /// </summary>
    public unsafe virtual void ProcessLobbyCustomizationMessages()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessLobbyCustomizationMessages, "BmGame.GDCharCustomizationManager.ProcessLobbyCustomizationMessages");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateMemberCustomizationMessage;
    /// <summary>
    /// Function: UpdateMemberCustomizationMessage
    /// </summary>
    public unsafe virtual void UpdateMemberCustomizationMessage(BmSDK.Engine.OnlineSubsystem.FUniqueNetId MemberNetId, BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelectionIndexed> CurrentCustomizationSetsIndexed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateMemberCustomizationMessage, "BmGame.GDCharCustomizationManager.UpdateMemberCustomizationMessage");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MemberNetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentCustomizationSetsIndexed, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreloadPlayerAssets;
    /// <summary>
    /// Function: PreloadPlayerAssets
    /// </summary>
    public unsafe virtual void PreloadPlayerAssets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreloadPlayerAssets, "BmGame.GDCharCustomizationManager.PreloadPlayerAssets");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GameModeRequiresHeroesAssetPreload;
    /// <summary>
    /// Function: GameModeRequiresHeroesAssetPreload
    /// </summary>
    public unsafe virtual bool GameModeRequiresHeroesAssetPreload()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GameModeRequiresHeroesAssetPreload, "BmGame.GDCharCustomizationManager.GameModeRequiresHeroesAssetPreload");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateLobbyCustomizationData;
    /// <summary>
    /// Function: UpdateLobbyCustomizationData
    /// </summary>
    public unsafe virtual void UpdateLobbyCustomizationData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateLobbyCustomizationData, "BmGame.GDCharCustomizationManager.UpdateLobbyCustomizationData");
        byte* paramsPtr = stackalloc byte[104];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CleanUpPreloadSupport;
    /// <summary>
    /// Function: CleanUpPreloadSupport
    /// </summary>
    public unsafe virtual void CleanUpPreloadSupport()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CleanUpPreloadSupport, "BmGame.GDCharCustomizationManager.CleanUpPreloadSupport");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitializePreloadSupport;
    /// <summary>
    /// Function: InitializePreloadSupport
    /// </summary>
    public unsafe virtual void InitializePreloadSupport()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitializePreloadSupport, "BmGame.GDCharCustomizationManager.InitializePreloadSupport");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyColor;
    /// <summary>
    /// Function: ApplyColor
    /// </summary>
    public unsafe static void ApplyColor(BmSDK.Engine.SkeletalMeshComponent TargetSkeletalMesh, in BmSDK.GameObject.FColor ColorRGBA, int MaterialIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyColor, "BmGame.GDCharCustomizationManager.ApplyColor");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetSkeletalMesh, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ColorRGBA, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaterialIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ConvertColor2LinearColor;
    /// <summary>
    /// Function: ConvertColor2LinearColor
    /// </summary>
    public unsafe static BmSDK.GameObject.FLinearColor ConvertColor2LinearColor(in BmSDK.GameObject.FColor RGBA)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConvertColor2LinearColor, "BmGame.GDCharCustomizationManager.ConvertColor2LinearColor");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RGBA, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FLinearColor>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ApplySkin;
    /// <summary>
    /// Function: ApplySkin
    /// </summary>
    public unsafe static void ApplySkin(BmSDK.Engine.SkeletalMeshComponent TargetSkeletalMesh, int SkinIndex, in BmSDK.TArray<BmSDK.BmGame.GDCharCustomAsset_Base.FCustomizationPurchasableMaterial> SkinList, int MaterialIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplySkin, "BmGame.GDCharCustomizationManager.ApplySkin");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetSkeletalMesh, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkinIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkinList, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaterialIndex, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyMorphs;
    /// <summary>
    /// Function: ApplyMorphs
    /// </summary>
    public unsafe static void ApplyMorphs(BmSDK.Engine.SkeletalMeshComponent TargetSkeletalMesh, BmSDK.SDEngine.SDAsyncResource MasterMorphSetResource, BmSDK.TArray<BmSDK.FName> MorphNames, BmSDK.FName ResourceID)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyMorphs, "BmGame.GDCharCustomizationManager.ApplyMorphs");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetSkeletalMesh, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MasterMorphSetResource, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MorphNames, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResourceID, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSkeletalMesh;
    /// <summary>
    /// Function: SetSkeletalMesh
    /// </summary>
    public unsafe static void SetSkeletalMesh(BmSDK.Engine.SkeletalMeshComponent TargetSkeletalMesh, BmSDK.Engine.SkeletalMesh Asset)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSkeletalMesh, "BmGame.GDCharCustomizationManager.SetSkeletalMesh");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetSkeletalMesh, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Asset, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSkeletalMeshResource;
    /// <summary>
    /// Function: SetSkeletalMeshResource
    /// </summary>
    public unsafe static void SetSkeletalMeshResource(BmSDK.Engine.SkeletalMeshComponent TargetSkeletalMesh, BmSDK.SDEngine.SDAsyncResource Resource)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSkeletalMeshResource, "BmGame.GDCharCustomizationManager.SetSkeletalMeshResource");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetSkeletalMesh, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Resource, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPhysicsAsset;
    /// <summary>
    /// Function: SetPhysicsAsset
    /// </summary>
    public unsafe static void SetPhysicsAsset(BmSDK.Engine.SkeletalMeshComponent TargetSkeletalMesh, BmSDK.Engine.PhysicsAsset Asset, bool EnablePhysicsAssets)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPhysicsAsset, "BmGame.GDCharCustomizationManager.SetPhysicsAsset");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetSkeletalMesh, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Asset, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnablePhysicsAssets, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPhysicsAssetResource;
    /// <summary>
    /// Function: SetPhysicsAssetResource
    /// </summary>
    public unsafe static void SetPhysicsAssetResource(BmSDK.Engine.SkeletalMeshComponent TargetSkeletalMesh, BmSDK.SDEngine.SDAsyncResource Resource, bool EnablePhysicsAssets)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPhysicsAssetResource, "BmGame.GDCharCustomizationManager.SetPhysicsAssetResource");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetSkeletalMesh, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Resource, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnablePhysicsAssets, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyUndershirt;
    /// <summary>
    /// Function: ApplyUndershirt
    /// </summary>
    public unsafe static void ApplyUndershirt(in BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection LoadedSelection, BmSDK.Engine.SkeletalMeshComponent TargetSkeletalMesh)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyUndershirt, "BmGame.GDCharCustomizationManager.ApplyUndershirt");
        byte* paramsPtr = stackalloc byte[268];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetSkeletalMesh, paramsPtr + 208);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyTattoo;
    /// <summary>
    /// Function: ApplyTattoo
    /// </summary>
    public unsafe static void ApplyTattoo(in BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection LoadedSelection, BmSDK.Engine.SkeletalMeshComponent TargetSkeletalMesh)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyTattoo, "BmGame.GDCharCustomizationManager.ApplyTattoo");
        byte* paramsPtr = stackalloc byte[256];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetSkeletalMesh, paramsPtr + 208);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyFacepaint;
    /// <summary>
    /// Function: ApplyFacepaint
    /// </summary>
    public unsafe static void ApplyFacepaint(in BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection LoadedSelection, BmSDK.Engine.SkeletalMeshComponent TargetSkeletalMesh)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyFacepaint, "BmGame.GDCharCustomizationManager.ApplyFacepaint");
        byte* paramsPtr = stackalloc byte[264];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetSkeletalMesh, paramsPtr + 208);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyHair;
    /// <summary>
    /// Function: ApplyHair
    /// </summary>
    public unsafe static void ApplyHair(in BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection LoadedSelection, BmSDK.Engine.SkeletalMeshComponent TargetSkeletalMesh, bool EnablePhysicsAssets)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyHair, "BmGame.GDCharCustomizationManager.ApplyHair");
        byte* paramsPtr = stackalloc byte[244];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetSkeletalMesh, paramsPtr + 208);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnablePhysicsAssets, paramsPtr + 212);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyFacialHair;
    /// <summary>
    /// Function: ApplyFacialHair
    /// </summary>
    public unsafe static void ApplyFacialHair(in BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection LoadedSelection, BmSDK.Engine.SkeletalMeshComponent TargetSkeletalMesh, bool EnablePhysicsAssets)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyFacialHair, "BmGame.GDCharCustomizationManager.ApplyFacialHair");
        byte* paramsPtr = stackalloc byte[244];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetSkeletalMesh, paramsPtr + 208);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnablePhysicsAssets, paramsPtr + 212);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyFaceGear;
    /// <summary>
    /// Function: ApplyFaceGear
    /// </summary>
    public unsafe static void ApplyFaceGear(in BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection LoadedSelection, BmSDK.Engine.SkeletalMeshComponent TargetSkeletalMesh, bool EnablePhysicsAssets)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyFaceGear, "BmGame.GDCharCustomizationManager.ApplyFaceGear");
        byte* paramsPtr = stackalloc byte[244];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetSkeletalMesh, paramsPtr + 208);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnablePhysicsAssets, paramsPtr + 212);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyUpper;
    /// <summary>
    /// Function: ApplyUpper
    /// </summary>
    public unsafe static void ApplyUpper(in BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection LoadedSelection, BmSDK.Engine.SkeletalMeshComponent TargetSkeletalMesh, bool EnablePhysicsAssets)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyUpper, "BmGame.GDCharCustomizationManager.ApplyUpper");
        byte* paramsPtr = stackalloc byte[244];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetSkeletalMesh, paramsPtr + 208);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnablePhysicsAssets, paramsPtr + 212);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyLower;
    /// <summary>
    /// Function: ApplyLower
    /// </summary>
    public unsafe static void ApplyLower(in BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection LoadedSelection, BmSDK.Engine.SkeletalMeshComponent TargetSkeletalMesh, bool EnablePhysicsAssets)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyLower, "BmGame.GDCharCustomizationManager.ApplyLower");
        byte* paramsPtr = stackalloc byte[244];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetSkeletalMesh, paramsPtr + 208);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnablePhysicsAssets, paramsPtr + 212);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyArchetype;
    /// <summary>
    /// Function: ApplyArchetype
    /// </summary>
    public unsafe static void ApplyArchetype(in BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection LoadedSelection, BmSDK.Engine.SkeletalMeshComponent TargetSkeletalMesh, bool EnablePhysicsAssets)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyArchetype, "BmGame.GDCharCustomizationManager.ApplyArchetype");
        byte* paramsPtr = stackalloc byte[232];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetSkeletalMesh, paramsPtr + 208);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnablePhysicsAssets, paramsPtr + 212);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyPlayerCustomizationToCinematicActor;
    /// <summary>
    /// Function: ApplyPlayerCustomizationToCinematicActor
    /// </summary>
    public unsafe virtual void ApplyPlayerCustomizationToCinematicActor(BmSDK.BmGame.GDCinematicCustomizationActor PreviewPawn, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerNetId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyPlayerCustomizationToCinematicActor, "BmGame.GDCharCustomizationManager.ApplyPlayerCustomizationToCinematicActor");
        byte* paramsPtr = stackalloc byte[264];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviewPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNetId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSkeletalMeshUseSecondaryPhysicsWeight;
    /// <summary>
    /// Function: SetSkeletalMeshUseSecondaryPhysicsWeight
    /// </summary>
    public unsafe static void SetSkeletalMeshUseSecondaryPhysicsWeight(BmSDK.Engine.SkeletalMeshComponent SkelComponent, bool UseSecondaryPhysicsWeight)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSkeletalMeshUseSecondaryPhysicsWeight, "BmGame.GDCharCustomizationManager.SetSkeletalMeshUseSecondaryPhysicsWeight");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelComponent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UseSecondaryPhysicsWeight, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_WasSelectionLoadedByUI;
    /// <summary>
    /// Function: WasSelectionLoadedByUI
    /// </summary>
    public unsafe virtual bool WasSelectionLoadedByUI(in BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection Selection, out int LoadedSelectionID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WasSelectionLoadedByUI, "BmGame.GDCharCustomizationManager.WasSelectionLoadedByUI");
        byte* paramsPtr = stackalloc byte[120];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Selection, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out LoadedSelectionID);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelectionID, paramsPtr + 96);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        LoadedSelectionID = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 96);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 100);
    }

    private static BmSDK.Function __fn_WasSelectionIDLoadedByUI;
    /// <summary>
    /// Function: WasSelectionIDLoadedByUI
    /// </summary>
    public unsafe virtual bool WasSelectionIDLoadedByUI(int LoadedSetId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WasSelectionIDLoadedByUI, "BmGame.GDCharCustomizationManager.WasSelectionIDLoadedByUI");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSetId, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ReleaseUILoadedSets;
    /// <summary>
    /// Function: ReleaseUILoadedSets
    /// </summary>
    public unsafe virtual void ReleaseUILoadedSets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseUILoadedSets, "BmGame.GDCharCustomizationManager.ReleaseUILoadedSets");
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

    private static BmSDK.Function __fn_ReleaseUILoadedSet;
    /// <summary>
    /// Function: ReleaseUILoadedSet
    /// </summary>
    public unsafe virtual void ReleaseUILoadedSet(int LoadedSetId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseUILoadedSet, "BmGame.GDCharCustomizationManager.ReleaseUILoadedSet");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSetId, paramsPtr + 0);
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

    private static BmSDK.Function __fn_LoadSetForUI;
    /// <summary>
    /// Function: LoadSetForUI
    /// </summary>
    public unsafe virtual int LoadSetForUI(out BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection Selection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadSetForUI, "BmGame.GDCharCustomizationManager.LoadSetForUI");
        byte* paramsPtr = stackalloc byte[120];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Selection);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Selection, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Selection = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 96);
    }

    private static BmSDK.Function __fn_SetGameWinnerNetId;
    /// <summary>
    /// Function: SetGameWinnerNetId
    /// </summary>
    public unsafe virtual void SetGameWinnerNetId(BmSDK.Engine.OnlineSubsystem.FUniqueNetId GameWinnerNetId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGameWinnerNetId, "BmGame.GDCharCustomizationManager.SetGameWinnerNetId");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GameWinnerNetId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGameWinnerNetId;
    /// <summary>
    /// Function: GetGameWinnerNetId
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.FUniqueNetId GetGameWinnerNetId()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGameWinnerNetId, "BmGame.GDCharCustomizationManager.GetGameWinnerNetId");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetLocalMemberNetId;
    /// <summary>
    /// Function: GetLocalMemberNetId
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.FUniqueNetId GetLocalMemberNetId()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocalMemberNetId, "BmGame.GDCharCustomizationManager.GetLocalMemberNetId");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ApplyResourcesToCinematicActors;
    /// <summary>
    /// Function: ApplyResourcesToCinematicActors
    /// </summary>
    public unsafe virtual void ApplyResourcesToCinematicActors()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyResourcesToCinematicActors, "BmGame.GDCharCustomizationManager.ApplyResourcesToCinematicActors");
        byte* paramsPtr = stackalloc byte[280];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddCinematicActor;
    /// <summary>
    /// Function: AddCinematicActor
    /// </summary>
    public unsafe virtual void AddCinematicActor(int CustomizationTeamIndex, BmSDK.BmGame.GDCinematicCustomizationActor PreviewPawn, BmSDK.Engine.Actor AssignedWeapon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCinematicActor, "BmGame.GDCharCustomizationManager.AddCinematicActor");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviewPawn, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AssignedWeapon, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AtachSkelMeshComponent;
    /// <summary>
    /// Function: AtachSkelMeshComponent
    /// </summary>
    public unsafe virtual void AtachSkelMeshComponent(BmSDK.Engine.Actor Target, BmSDK.Engine.SkeletalMeshComponent SkeletalMesh)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AtachSkelMeshComponent, "BmGame.GDCharCustomizationManager.AtachSkelMeshComponent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkeletalMesh, paramsPtr + 4);
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

    private static BmSDK.Function __fn_DetachSkelMeshComponent;
    /// <summary>
    /// Function: DetachSkelMeshComponent
    /// </summary>
    public unsafe virtual void DetachSkelMeshComponent(BmSDK.Engine.Actor Target, BmSDK.Engine.SkeletalMeshComponent SkeletalMesh)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetachSkelMeshComponent, "BmGame.GDCharCustomizationManager.DetachSkelMeshComponent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkeletalMesh, paramsPtr + 4);
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

    private static BmSDK.Function __fn_WeaponHasSkins;
    /// <summary>
    /// Function: WeaponHasSkins
    /// </summary>
    public unsafe virtual bool WeaponHasSkins(BmSDK.BmGame.RGameInfo.WeaponId Weapon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponHasSkins, "BmGame.GDCharCustomizationManager.WeaponHasSkins");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Weapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetAllWeaponSkinsForWeapon;
    /// <summary>
    /// Function: GetAllWeaponSkinsForWeapon
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.BmGame.GDWeaponSkin> GetAllWeaponSkinsForWeapon(BmSDK.BmGame.RGameInfo.WeaponId Weapon, bool bEntitledOnly)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAllWeaponSkinsForWeapon, "BmGame.GDCharCustomizationManager.GetAllWeaponSkinsForWeapon");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Weapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEntitledOnly, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDWeaponSkin>>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetWeaponSkinForWeapon;
    /// <summary>
    /// Function: GetWeaponSkinForWeapon
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDWeaponSkin GetWeaponSkinForWeapon(BmSDK.BmGame.RGameInfo.WeaponId Weapon, int SkinIndex, bool bEntitledOnly)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWeaponSkinForWeapon, "BmGame.GDCharCustomizationManager.GetWeaponSkinForWeapon");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Weapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkinIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEntitledOnly, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDWeaponSkin>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetSkinsList;
    /// <summary>
    /// Function: GetSkinsList
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDAvailableSkinsList GetSkinsList(bool bEntitledOnly)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSkinsList, "BmGame.GDCharCustomizationManager.GetSkinsList");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEntitledOnly, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDAvailableSkinsList>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetLocalPlayerLoadoutWeaponData;
    /// <summary>
    /// Function: GetLocalPlayerLoadoutWeaponData
    /// </summary>
    public unsafe virtual bool GetLocalPlayerLoadoutWeaponData(int TeamIndex, out int outWeaponIndex, out int outWeaponSkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocalPlayerLoadoutWeaponData, "BmGame.GDCharCustomizationManager.GetLocalPlayerLoadoutWeaponData");
        byte* paramsPtr = stackalloc byte[148];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamIndex, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out outWeaponIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(outWeaponIndex, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out outWeaponSkinIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(outWeaponSkinIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outWeaponIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        outWeaponSkinIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_UpdatePreviewWeaponSkin;
    /// <summary>
    /// Function: UpdatePreviewWeaponSkin
    /// </summary>
    public unsafe virtual void UpdatePreviewWeaponSkin(BmSDK.Engine.SkeletalMeshComponent Mesh)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePreviewWeaponSkin, "BmGame.GDCharCustomizationManager.UpdatePreviewWeaponSkin");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mesh, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateWeaponPreview;
    /// <summary>
    /// Function: UpdateWeaponPreview
    /// </summary>
    public unsafe virtual void UpdateWeaponPreview(BmSDK.Engine.Actor Target, BmSDK.Engine.SkeletalMeshComponent Mesh, int TeamIndex, int WeaponIndex, int WeaponSkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateWeaponPreview, "BmGame.GDCharCustomizationManager.UpdateWeaponPreview");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mesh, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponIndex, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponSkinIndex, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPawnConfig;
    /// <summary>
    /// Function: GetPawnConfig
    /// </summary>
    public unsafe virtual BmSDK.GameObject GetPawnConfig()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPawnConfig, "BmGame.GDCharCustomizationManager.GetPawnConfig");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CustomizationBankChanged;
    /// <summary>
    /// Function: CustomizationBankChanged
    /// </summary>
    public unsafe virtual void CustomizationBankChanged(int CustomizationTeamIndex, int BankIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CustomizationBankChanged, "BmGame.GDCharCustomizationManager.CustomizationBankChanged");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BankIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindPreviewAsset;
    /// <summary>
    /// Function: FindPreviewAsset
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDCharCustomAsset_Base FindPreviewAsset(int CustomizationTeamIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, int CustomPartIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPreviewAsset, "BmGame.GDCharCustomizationManager.FindPreviewAsset");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomPartIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDCharCustomAsset_Base>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_FlagUpdatePreview;
    /// <summary>
    /// Function: FlagUpdatePreview
    /// </summary>
    public unsafe virtual void FlagUpdatePreview()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlagUpdatePreview, "BmGame.GDCharCustomizationManager.FlagUpdatePreview");
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

    private static BmSDK.Function __fn_FlagUpdate;
    /// <summary>
    /// Function: FlagUpdate
    /// </summary>
    public unsafe virtual void FlagUpdate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlagUpdate, "BmGame.GDCharCustomizationManager.FlagUpdate");
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

    private static BmSDK.Function __fn_GetNumPreloadedPartsPerType;
    /// <summary>
    /// Function: GetNumPreloadedPartsPerType
    /// </summary>
    public unsafe virtual int GetNumPreloadedPartsPerType(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumPreloadedPartsPerType, "BmGame.GDCharCustomizationManager.GetNumPreloadedPartsPerType");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UnloadPreloadedAssetsOutOfCacheRange;
    /// <summary>
    /// Function: UnloadPreloadedAssetsOutOfCacheRange
    /// </summary>
    public unsafe virtual void UnloadPreloadedAssetsOutOfCacheRange(int CustomizationTeamIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, int CustomPartIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnloadPreloadedAssetsOutOfCacheRange, "BmGame.GDCharCustomizationManager.UnloadPreloadedAssetsOutOfCacheRange");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomPartIndex, paramsPtr + 8);
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

    private static BmSDK.Function __fn_UnloadPreloadedAssets;
    /// <summary>
    /// Function: UnloadPreloadedAssets
    /// </summary>
    public unsafe virtual void UnloadPreloadedAssets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnloadPreloadedAssets, "BmGame.GDCharCustomizationManager.UnloadPreloadedAssets");
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

    private static BmSDK.Function __fn_IsPreloaded;
    /// <summary>
    /// Function: IsPreloaded
    /// </summary>
    public unsafe virtual bool IsPreloaded(BmSDK.SDEngine.SDAsyncResource AsyncResource, bool CheckIsLoaded)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPreloaded, "BmGame.GDCharCustomizationManager.IsPreloaded");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AsyncResource, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckIsLoaded, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PreloadResource;
    /// <summary>
    /// Function: PreloadResource
    /// </summary>
    public unsafe virtual bool PreloadResource(BmSDK.SDEngine.SDAsyncResource AsyncResource, int CustomizationTeamIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, int CustomPartIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreloadResource, "BmGame.GDCharCustomizationManager.PreloadResource");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AsyncResource, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomPartIndex, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_PreloadAsset;
    /// <summary>
    /// Function: PreloadAsset
    /// </summary>
    public unsafe virtual bool PreloadAsset(int CustomizationTeamIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, int CustomPartIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreloadAsset, "BmGame.GDCharCustomizationManager.PreloadAsset");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomPartIndex, paramsPtr + 8);
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

    private static BmSDK.Function __fn_PreloadAssets;
    /// <summary>
    /// Function: PreloadAssets
    /// </summary>
    public unsafe virtual bool PreloadAssets(int CustomizationTeamIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, int CustomPartIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreloadAssets, "BmGame.GDCharCustomizationManager.PreloadAssets");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomPartIndex, paramsPtr + 8);
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

    private static BmSDK.Function __fn_FindAltArchetypeIndex;
    /// <summary>
    /// Function: FindAltArchetypeIndex
    /// </summary>
    public unsafe static int FindAltArchetypeIndex(BmSDK.BmGame.GDCharCustomAsset_Archetype Archetype, BmSDK.FName AltArchetypeName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindAltArchetypeIndex, "BmGame.GDCharCustomizationManager.FindAltArchetypeIndex");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Archetype, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AltArchetypeName, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_FindAssetIndex;
    /// <summary>
    /// Function: FindAssetIndex
    /// </summary>
    public unsafe virtual bool FindAssetIndex(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, BmSDK.FName AssetId, out int outAssetIndex, out int outTeamIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindAssetIndex, "BmGame.GDCharCustomizationManager.FindAssetIndex");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AssetId, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out outAssetIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(outAssetIndex, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out outTeamIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(outTeamIndex, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        outAssetIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
        outTeamIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetCustomPartIndex;
    /// <summary>
    /// Function: GetCustomPartIndex
    /// </summary>
    public unsafe virtual int GetCustomPartIndex(int CustomizationTeamIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, BmSDK.FName PartResourceID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCustomPartIndex, "BmGame.GDCharCustomizationManager.GetCustomPartIndex");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PartResourceID, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_PreloadPreviewAssets;
    /// <summary>
    /// Function: PreloadPreviewAssets
    /// </summary>
    public unsafe virtual void PreloadPreviewAssets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreloadPreviewAssets, "BmGame.GDCharCustomizationManager.PreloadPreviewAssets");
        byte* paramsPtr = stackalloc byte[116];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetPreviewPawn;
    /// <summary>
    /// Function: ResetPreviewPawn
    /// </summary>
    public unsafe virtual void ResetPreviewPawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetPreviewPawn, "BmGame.GDCharCustomizationManager.ResetPreviewPawn");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdatePreviewPawn;
    /// <summary>
    /// Function: UpdatePreviewPawn
    /// </summary>
    public unsafe virtual bool UpdatePreviewPawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePreviewPawn, "BmGame.GDCharCustomizationManager.UpdatePreviewPawn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PreloadSelectionBank;
    /// <summary>
    /// Function: PreloadSelectionBank
    /// </summary>
    public unsafe virtual void PreloadSelectionBank(int CustomizationTeamIndex, int BankIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreloadSelectionBank, "BmGame.GDCharCustomizationManager.PreloadSelectionBank");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BankIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCustomSelectionBankPartColor;
    /// <summary>
    /// Function: SetCustomSelectionBankPartColor
    /// </summary>
    public unsafe virtual bool SetCustomSelectionBankPartColor(int CustomizationTeamIndex, int BankIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, in BmSDK.GameObject.FColor ColorValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCustomSelectionBankPartColor, "BmGame.GDCharCustomizationManager.SetCustomSelectionBankPartColor");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BankIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ColorValue, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetCustomSelectionBankPartSkinIndex;
    /// <summary>
    /// Function: GetCustomSelectionBankPartSkinIndex
    /// </summary>
    public unsafe virtual int GetCustomSelectionBankPartSkinIndex(int CustomizationTeamIndex, int BankIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCustomSelectionBankPartSkinIndex, "BmGame.GDCharCustomizationManager.GetCustomSelectionBankPartSkinIndex");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BankIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetCustomSelectionBankPartSkinIndex;
    /// <summary>
    /// Function: SetCustomSelectionBankPartSkinIndex
    /// </summary>
    public unsafe virtual bool SetCustomSelectionBankPartSkinIndex(int CustomizationTeamIndex, int BankIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, int PartSkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCustomSelectionBankPartSkinIndex, "BmGame.GDCharCustomizationManager.SetCustomSelectionBankPartSkinIndex");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BankIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PartSkinIndex, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetCustomSelectionBankPartIsEquipped;
    /// <summary>
    /// Function: GetCustomSelectionBankPartIsEquipped
    /// </summary>
    public unsafe virtual bool GetCustomSelectionBankPartIsEquipped(int CustomizationTeamIndex, int BankIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, BmSDK.FName PartResourceID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCustomSelectionBankPartIsEquipped, "BmGame.GDCharCustomizationManager.GetCustomSelectionBankPartIsEquipped");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BankIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PartResourceID, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_SetCustomSelectionBankPartData;
    /// <summary>
    /// Function: SetCustomSelectionBankPartData
    /// </summary>
    public unsafe virtual bool SetCustomSelectionBankPartData(int CustomizationTeamIndex, int BankIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, BmSDK.FName PartResourceID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCustomSelectionBankPartData, "BmGame.GDCharCustomizationManager.SetCustomSelectionBankPartData");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BankIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PartResourceID, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_SetPreviewPawn;
    /// <summary>
    /// Function: SetPreviewPawn
    /// </summary>
    public unsafe virtual void SetPreviewPawn(int CustomizationTeamIndex, BmSDK.BmGame.GDCinematicCustomizationActor PreviewPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPreviewPawn, "BmGame.GDCharCustomizationManager.SetPreviewPawn");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviewPawn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCustomizationPreview;
    /// <summary>
    /// Function: GetCustomizationPreview
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDCharCustomizationPreviewBase GetCustomizationPreview()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCustomizationPreview, "BmGame.GDCharCustomizationManager.GetCustomizationPreview");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDCharCustomizationPreviewBase>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShutdownCustomizationPreview;
    /// <summary>
    /// Function: ShutdownCustomizationPreview
    /// </summary>
    public unsafe virtual void ShutdownCustomizationPreview()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShutdownCustomizationPreview, "BmGame.GDCharCustomizationManager.ShutdownCustomizationPreview");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitializeCustomizationPreview;
    /// <summary>
    /// Function: InitializeCustomizationPreview
    /// </summary>
    public unsafe virtual void InitializeCustomizationPreview(BmSDK.Class InPreviewClass)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitializeCustomizationPreview, "BmGame.GDCharCustomizationManager.InitializeCustomizationPreview");
        byte* paramsPtr = stackalloc byte[120];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPreviewClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPreviewTeam;
    /// <summary>
    /// Function: SetPreviewTeam
    /// </summary>
    public unsafe virtual void SetPreviewTeam(int CustomizationTeamIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPreviewTeam, "BmGame.GDCharCustomizationManager.SetPreviewTeam");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AreCustomSelectionsEqual;
    /// <summary>
    /// Function: AreCustomSelectionsEqual
    /// </summary>
    public unsafe virtual bool AreCustomSelectionsEqual(in BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection Selection1, in BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection Selection2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreCustomSelectionsEqual, "BmGame.GDCharCustomizationManager.AreCustomSelectionsEqual");
        byte* paramsPtr = stackalloc byte[212];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Selection1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Selection2, paramsPtr + 96);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 192);
    }

    private static BmSDK.Function __fn_CleanupCustomizationLoadedSets;
    /// <summary>
    /// Function: CleanupCustomizationLoadedSets
    /// </summary>
    public unsafe virtual void CleanupCustomizationLoadedSets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CleanupCustomizationLoadedSets, "BmGame.GDCharCustomizationManager.CleanupCustomizationLoadedSets");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHairColors;
    /// <summary>
    /// Function: GetHairColors
    /// </summary>
    public unsafe virtual void GetHairColors(int CustomizationTeamIndex, out BmSDK.TArray<BmSDK.GameObject.FColor> outColorArray)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHairColors, "BmGame.GDCharCustomizationManager.GetHairColors");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outColorArray = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.GameObject.FColor>>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_GetHairColorByIndex;
    /// <summary>
    /// Function: GetHairColorByIndex
    /// </summary>
    public unsafe virtual BmSDK.GameObject.FColor GetHairColorByIndex(int CustomizationTeamIndex, int HairColorIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHairColorByIndex, "BmGame.GDCharCustomizationManager.GetHairColorByIndex");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HairColorIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FColor>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetNumHairColors;
    /// <summary>
    /// Function: GetNumHairColors
    /// </summary>
    public unsafe virtual int GetNumHairColors(int CustomizationTeamIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumHairColors, "BmGame.GDCharCustomizationManager.GetNumHairColors");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HasLoadedPreviewAssets;
    /// <summary>
    /// Function: HasLoadedPreviewAssets
    /// </summary>
    public unsafe virtual bool HasLoadedPreviewAssets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasLoadedPreviewAssets, "BmGame.GDCharCustomizationManager.HasLoadedPreviewAssets");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_LoadCustomizationFromProfileInternal;
    /// <summary>
    /// Function: LoadCustomizationFromProfileInternal
    /// </summary>
    public unsafe virtual void LoadCustomizationFromProfileInternal(BmSDK.SDEngine.SDProfile Profile)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadCustomizationFromProfileInternal, "BmGame.GDCharCustomizationManager.LoadCustomizationFromProfileInternal");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Profile, paramsPtr + 0);
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

    private static BmSDK.Function __fn_StoreCustomizationInProfileInternal;
    /// <summary>
    /// Function: StoreCustomizationInProfileInternal
    /// </summary>
    public unsafe virtual void StoreCustomizationInProfileInternal(BmSDK.SDEngine.SDProfile Profile)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StoreCustomizationInProfileInternal, "BmGame.GDCharCustomizationManager.StoreCustomizationInProfileInternal");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Profile, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetGearPlusDescription;
    /// <summary>
    /// Function: GetGearPlusDescription
    /// </summary>
    public unsafe virtual BmSDK.FString GetGearPlusDescription(in BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationPartInfo Part)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGearPlusDescription, "BmGame.GDCharCustomizationManager.GetGearPlusDescription");
        byte* paramsPtr = stackalloc byte[120];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Part, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 92);
    }

    private static BmSDK.Function __fn_GetGearPlusDescriptionLocalized;
    /// <summary>
    /// Function: GetGearPlusDescriptionLocalized
    /// </summary>
    public unsafe virtual BmSDK.FString GetGearPlusDescriptionLocalized(in BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationPartInfo Part)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGearPlusDescriptionLocalized, "BmGame.GDCharCustomizationManager.GetGearPlusDescriptionLocalized");
        byte* paramsPtr = stackalloc byte[120];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Part, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 92);
    }

    private static BmSDK.Function __fn_OnInventoryChanged;
    /// <summary>
    /// Function: OnInventoryChanged
    /// </summary>
    public unsafe virtual void OnInventoryChanged(int UserIndex, BmSDK.TArray<BmSDK.SDEngine.SDInventorySystem.FSDInventoryItemCount> NewItems, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnInventoryChanged, "BmGame.GDCharCustomizationManager.OnInventoryChanged");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewItems, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VerifyGearPlusParts;
    /// <summary>
    /// Function: VerifyGearPlusParts
    /// </summary>
    public unsafe void VerifyGearPlusParts(int UserIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VerifyGearPlusParts, "BmGame.GDCharCustomizationManager.VerifyGearPlusParts");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserIndex, paramsPtr + 0);
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

    private static BmSDK.Function __fn_CustomizationProfileLoaded;
    /// <summary>
    /// Function: CustomizationProfileLoaded
    /// </summary>
    public unsafe virtual void CustomizationProfileLoaded(BmSDK.BmGame.RPlayerController RPC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CustomizationProfileLoaded, "BmGame.GDCharCustomizationManager.CustomizationProfileLoaded");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadCustomizationFromProfile;
    /// <summary>
    /// Function: LoadCustomizationFromProfile
    /// </summary>
    public unsafe virtual void LoadCustomizationFromProfile(BmSDK.BmGame.RPlayerController RPC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadCustomizationFromProfile, "BmGame.GDCharCustomizationManager.LoadCustomizationFromProfile");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StoreCustomizationInProfile;
    /// <summary>
    /// Function: StoreCustomizationInProfile
    /// </summary>
    public unsafe virtual void StoreCustomizationInProfile(BmSDK.BmGame.RPlayerController RPC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StoreCustomizationInProfile, "BmGame.GDCharCustomizationManager.StoreCustomizationInProfile");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GenerateMorphList;
    /// <summary>
    /// Function: GenerateMorphList
    /// </summary>
    public unsafe static int GenerateMorphList(in BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection LoadedSelection, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, out BmSDK.TArray<BmSDK.FName> outMorphList, bool bUseUIMorphTarget = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GenerateMorphList, "BmGame.GDCharCustomizationManager.GenerateMorphList");
        byte* paramsPtr = stackalloc byte[248];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 208);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseUIMorphTarget, paramsPtr + 224);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        outMorphList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FName>>(paramsPtr + 212);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 228);
    }

    private static BmSDK.Function __fn_GetUIMorphName;
    /// <summary>
    /// Function: GetUIMorphName
    /// </summary>
    public unsafe static void GetUIMorphName(BmSDK.SDEngine.SDAsyncResource MasterMorphSet, in BmSDK.FName ArchetypeMorphName, out BmSDK.FName outMorphName)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUIMorphName, "BmGame.GDCharCustomizationManager.GetUIMorphName");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MasterMorphSet, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArchetypeMorphName, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out outMorphName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(outMorphName, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        outMorphName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetArchetypeMeshForSelection;
    /// <summary>
    /// Function: GetArchetypeMeshForSelection
    /// </summary>
    public unsafe static BmSDK.SDEngine.SDAsyncResource GetArchetypeMeshForSelection(in BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection LoadedSelection)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetArchetypeMeshForSelection, "BmGame.GDCharCustomizationManager.GetArchetypeMeshForSelection");
        byte* paramsPtr = stackalloc byte[228];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelection, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.SDEngine.SDAsyncResource>(paramsPtr + 208);
    }

    private static BmSDK.Function __fn_CheckAllResourcesLoaded;
    /// <summary>
    /// Function: CheckAllResourcesLoaded
    /// </summary>
    public unsafe virtual bool CheckAllResourcesLoaded(int NumExpectedPlayers = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckAllResourcesLoaded, "BmGame.GDCharCustomizationManager.CheckAllResourcesLoaded");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumExpectedPlayers, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetNumCustomBanks;
    /// <summary>
    /// Function: GetNumCustomBanks
    /// </summary>
    public unsafe virtual int GetNumCustomBanks()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumCustomBanks, "BmGame.GDCharCustomizationManager.GetNumCustomBanks");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCurrentSelectionBank;
    /// <summary>
    /// Function: GetCurrentSelectionBank
    /// </summary>
    public unsafe virtual int GetCurrentSelectionBank(int CustomizationTeamIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentSelectionBank, "BmGame.GDCharCustomizationManager.GetCurrentSelectionBank");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetCurrentSelectionBank;
    /// <summary>
    /// Function: SetCurrentSelectionBank
    /// </summary>
    public unsafe virtual void SetCurrentSelectionBank(int CustomizationTeamIndex, int BankIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentSelectionBank, "BmGame.GDCharCustomizationManager.SetCurrentSelectionBank");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BankIndex, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetCustomSelectionBankData;
    /// <summary>
    /// Function: GetCustomSelectionBankData
    /// </summary>
    public unsafe virtual bool GetCustomSelectionBankData(int CustomizationTeamIndex, int BankIndex, out BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection outSelection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCustomSelectionBankData, "BmGame.GDCharCustomizationManager.GetCustomSelectionBankData");
        byte* paramsPtr = stackalloc byte[124];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BankIndex, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out outSelection);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(outSelection, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        outSelection = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 104);
    }

    private static BmSDK.Function __fn_SetCustomSelectionBankData;
    /// <summary>
    /// Function: SetCustomSelectionBankData
    /// </summary>
    public unsafe virtual bool SetCustomSelectionBankData(int CustomizationTeamIndex, int BankIndex, in BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection Selection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCustomSelectionBankData, "BmGame.GDCharCustomizationManager.SetCustomSelectionBankData");
        byte* paramsPtr = stackalloc byte[124];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BankIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Selection, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 104);
    }

    private static BmSDK.Function __fn_GetSelectionByID;
    /// <summary>
    /// Function: GetSelectionByID
    /// </summary>
    public unsafe virtual bool GetSelectionByID(int LoadedSelectionID, out BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection outSelectionData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSelectionByID, "BmGame.GDCharCustomizationManager.GetSelectionByID");
        byte* paramsPtr = stackalloc byte[232];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelectionID, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out outSelectionData);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(outSelectionData, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        outSelectionData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 212);
    }

    private static BmSDK.Function __fn_HasCustomSelectionChanged;
    /// <summary>
    /// Function: HasCustomSelectionChanged
    /// </summary>
    public unsafe virtual bool HasCustomSelectionChanged(int LoadedSelectionID, in BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection Selection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasCustomSelectionChanged, "BmGame.GDCharCustomizationManager.HasCustomSelectionChanged");
        byte* paramsPtr = stackalloc byte[120];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelectionID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Selection, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 100);
    }

    private static BmSDK.Function __fn_IsCustomSelectionLoaded;
    /// <summary>
    /// Function: IsCustomSelectionLoaded
    /// </summary>
    public unsafe virtual bool IsCustomSelectionLoaded(int LoadedSelectionID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCustomSelectionLoaded, "BmGame.GDCharCustomizationManager.IsCustomSelectionLoaded");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelectionID, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ReleaseAllCustomUILoadedSelections;
    /// <summary>
    /// Function: ReleaseAllCustomUILoadedSelections
    /// </summary>
    public unsafe virtual void ReleaseAllCustomUILoadedSelections()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseAllCustomUILoadedSelections, "BmGame.GDCharCustomizationManager.ReleaseAllCustomUILoadedSelections");
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

    private static BmSDK.Function __fn_ReleaseAllCustomSelections;
    /// <summary>
    /// Function: ReleaseAllCustomSelections
    /// </summary>
    public unsafe virtual void ReleaseAllCustomSelections(bool IgnoreUILoadedSets)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseAllCustomSelections, "BmGame.GDCharCustomizationManager.ReleaseAllCustomSelections");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IgnoreUILoadedSets, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ReleaseCustomSelection;
    /// <summary>
    /// Function: ReleaseCustomSelection
    /// </summary>
    public unsafe virtual void ReleaseCustomSelection(int LoadedSelectionID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReleaseCustomSelection, "BmGame.GDCharCustomizationManager.ReleaseCustomSelection");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelectionID, paramsPtr + 0);
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

    private static BmSDK.Function __fn_LoadCustomSelection;
    /// <summary>
    /// Function: LoadCustomSelection
    /// </summary>
    public unsafe virtual int LoadCustomSelection(out BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection Selection, bool ForUIOnly)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadCustomSelection, "BmGame.GDCharCustomizationManager.LoadCustomSelection");
        byte* paramsPtr = stackalloc byte[120];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Selection);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Selection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForUIOnly, paramsPtr + 96);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Selection = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 100);
    }

    private static BmSDK.Function __fn_GetCustomPartFromInvItem;
    /// <summary>
    /// Function: GetCustomPartFromInvItem
    /// </summary>
    public unsafe virtual bool GetCustomPartFromInvItem(BmSDK.SDEngine.SDInventoryItem InvItem, out BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationPartInfo outPart, out int outSkinIndex, out int outTeamIndex, out int CharCustomPartType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCustomPartFromInvItem, "BmGame.GDCharCustomizationManager.GetCustomPartFromInvItem");
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InvItem, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out outSkinIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(outSkinIndex, paramsPtr + 96);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out outTeamIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(outTeamIndex, paramsPtr + 100);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CharCustomPartType);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 104);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        outPart = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationPartInfo>(paramsPtr + 4);
        outSkinIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 96);
        outTeamIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 100);
        CharCustomPartType = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 104);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 108);
    }

    private static BmSDK.Function __fn_GetCustomPartLocalizationString;
    /// <summary>
    /// Function: GetCustomPartLocalizationString
    /// </summary>
    public unsafe virtual BmSDK.FString GetCustomPartLocalizationString(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, BmSDK.FString AssetName = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCustomPartLocalizationString, "BmGame.GDCharCustomizationManager.GetCustomPartLocalizationString");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AssetName, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetCustomPartInfo;
    /// <summary>
    /// Function: GetCustomPartInfo
    /// </summary>
    public unsafe virtual bool GetCustomPartInfo(int CustomizationTeamIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, int CustomPartIndex, bool bEntitledOnly, out BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationPartInfo outCharacterCustomizationPartInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCustomPartInfo, "BmGame.GDCharCustomizationManager.GetCustomPartInfo");
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomPartIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEntitledOnly, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        outCharacterCustomizationPartInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationPartInfo>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 108);
    }

    private static BmSDK.Function __fn_GetCustomPartInfoList;
    /// <summary>
    /// Function: GetCustomPartInfoList
    /// </summary>
    public unsafe virtual int GetCustomPartInfoList(int CustomizationTeamIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, bool bEntitledOnly, out BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationPartInfo> outCharacterCustomizationPartInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCustomPartInfoList, "BmGame.GDCharCustomizationManager.GetCustomPartInfoList");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEntitledOnly, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        outCharacterCustomizationPartInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationPartInfo>>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetNumCustomParts;
    /// <summary>
    /// Function: GetNumCustomParts
    /// </summary>
    public unsafe virtual int GetNumCustomParts(int CustomizationTeamIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, bool bEntitledOnly)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumCustomParts, "BmGame.GDCharCustomizationManager.GetNumCustomParts");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEntitledOnly, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetBaneTeamIndex;
    /// <summary>
    /// Function: GetBaneTeamIndex
    /// </summary>
    public unsafe virtual int GetBaneTeamIndex()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBaneTeamIndex, "BmGame.GDCharCustomizationManager.GetBaneTeamIndex");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetJokerTeamIndex;
    /// <summary>
    /// Function: GetJokerTeamIndex
    /// </summary>
    public unsafe virtual int GetJokerTeamIndex()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetJokerTeamIndex, "BmGame.GDCharCustomizationManager.GetJokerTeamIndex");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNumTeams;
    /// <summary>
    /// Function: GetNumTeams
    /// </summary>
    public unsafe virtual int GetNumTeams()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumTeams, "BmGame.GDCharCustomizationManager.GetNumTeams");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetDisablePhysicsAssetsOnNonLocalPlayers;
    /// <summary>
    /// Function: SetDisablePhysicsAssetsOnNonLocalPlayers
    /// </summary>
    public unsafe virtual void SetDisablePhysicsAssetsOnNonLocalPlayers(bool Enable)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDisablePhysicsAssetsOnNonLocalPlayers, "BmGame.GDCharCustomizationManager.SetDisablePhysicsAssetsOnNonLocalPlayers");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Enable, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDisableExtraPhysicsAssetsMerge;
    /// <summary>
    /// Function: SetDisableExtraPhysicsAssetsMerge
    /// </summary>
    public unsafe virtual void SetDisableExtraPhysicsAssetsMerge(bool Enable)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDisableExtraPhysicsAssetsMerge, "BmGame.GDCharCustomizationManager.SetDisableExtraPhysicsAssetsMerge");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Enable, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetInstance;
    /// <summary>
    /// Function: GetInstance
    /// </summary>
    public unsafe static BmSDK.BmGame.GDCharCustomizationManager GetInstance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInstance, "BmGame.GDCharCustomizationManager.GetInstance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDCharCustomizationManager>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ResetGameDependantVars;
    /// <summary>
    /// Function: ResetGameDependantVars
    /// </summary>
    public unsafe virtual void ResetGameDependantVars()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetGameDependantVars, "BmGame.GDCharCustomizationManager.ResetGameDependantVars");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDefaultSetup;
    /// <summary>
    /// Function: GetDefaultSetup
    /// </summary>
    public unsafe virtual void GetDefaultSetup(int CustomizationTeamIndex, out BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection outCustomSelection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultSetup, "BmGame.GDCharCustomizationManager.GetDefaultSetup");
        byte* paramsPtr = stackalloc byte[120];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out outCustomSelection);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(outCustomSelection, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outCustomSelection = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_CustomisationChangedFromDefault;
    /// <summary>
    /// Function: CustomisationChangedFromDefault
    /// </summary>
    public unsafe virtual bool CustomisationChangedFromDefault(int CustomizationTeamIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CustomisationChangedFromDefault, "BmGame.GDCharCustomizationManager.CustomisationChangedFromDefault");
        byte* paramsPtr = stackalloc byte[224];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_InitializeCustomBanks;
    /// <summary>
    /// Function: InitializeCustomBanks
    /// </summary>
    public unsafe virtual void InitializeCustomBanks()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitializeCustomBanks, "BmGame.GDCharCustomizationManager.InitializeCustomBanks");
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCustomConfigListForTeam;
    /// <summary>
    /// Function: GetCustomConfigListForTeam
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDCharCustomConfig GetCustomConfigListForTeam(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team, bool bEntitledOnly)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCustomConfigListForTeam, "BmGame.GDCharCustomizationManager.GetCustomConfigListForTeam");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEntitledOnly, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDCharCustomConfig>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CleanUpManager;
    /// <summary>
    /// Function: CleanUpManager
    /// </summary>
    public unsafe virtual void CleanUpManager()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CleanUpManager, "BmGame.GDCharCustomizationManager.CleanUpManager");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitializeManager;
    /// <summary>
    /// Function: InitializeManager
    /// </summary>
    public unsafe virtual void InitializeManager()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitializeManager, "BmGame.GDCharCustomizationManager.InitializeManager");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: m_CustomizationDefaultsPackage
    /// </summary>
    public unsafe BmSDK.Package m_CustomizationDefaultsPackage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Package>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: CharCustomization_Enabled
    /// </summary>
    public unsafe bool CharCustomization_Enabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: m_SkipExtraPhysicsAssetsMerge
    /// </summary>
    public unsafe bool m_SkipExtraPhysicsAssetsMerge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: m_DisablePhysicsAssetsOnNonLocalPlayers
    /// </summary>
    public unsafe bool m_DisablePhysicsAssetsOnNonLocalPlayers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: m_UpdateNeeded
    /// </summary>
    public unsafe bool m_UpdateNeeded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: m_UpdatePreviewNeeded
    /// </summary>
    public unsafe bool m_UpdatePreviewNeeded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// IntProperty: m_LoadedSeletionCounter
    /// </summary>
    public unsafe int m_LoadedSeletionCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// IntProperty: m_LoadedMorphedMeshCounter
    /// </summary>
    public unsafe int m_LoadedMorphedMeshCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// ArrayProperty: m_LoadedSelecionArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection> m_LoadedSelecionArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection>>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// ArrayProperty: m_LoadedResources
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomization_LoadedResource> m_LoadedResources
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomization_LoadedResource>>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }

    /// <summary>
    /// ArrayProperty: m_PreLoadedResources
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomization_PreLoadedResource> m_PreLoadedResources
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomization_PreLoadedResource>>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// ArrayProperty: m_CustomConfigBanks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationBank> m_CustomConfigBanks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationBank>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: m_CurrentSelectedCustomizationBank
    /// </summary>
    public unsafe BmSDK.TArray<int> m_CurrentSelectedCustomizationBank
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// ObjectProperty: m_CustomizationDefaults
    /// </summary>
    public unsafe BmSDK.BmGame.GDCharCustomizationManager_DefaultConfig m_CustomizationDefaults
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDCharCustomizationManager_DefaultConfig>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ObjectProperty: m_CustomizationPreview
    /// </summary>
    public unsafe BmSDK.BmGame.GDCharCustomizationPreviewBase m_CustomizationPreview
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDCharCustomizationPreviewBase>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// ArrayProperty: m_CinematicActorArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationCinematicActorData> m_CinematicActorArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationCinematicActorData>>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ArrayProperty: m_UILoadedSetArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationUILoadedSet> m_UILoadedSetArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationUILoadedSet>>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// ArrayProperty: m_PlayerPreloadDataArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationPlayerPreloadData> m_PlayerPreloadDataArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationPlayerPreloadData>>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ArrayProperty: m_PreloadedAltMeshes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationPreloadedAltMesh> m_PreloadedAltMeshes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationPreloadedAltMesh>>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// ArrayProperty: m_LobbyCustomizationMessages
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager.FSLobbyCustomizationMessage> m_LobbyCustomizationMessages
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager.FSLobbyCustomizationMessage>>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ArrayProperty: m_MorphedMeshes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDCustomizationMorphedMeshData> m_MorphedMeshes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDCustomizationMorphedMeshData>>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// StructProperty: m_MorphedMeshesHashMap
    /// </summary>
    public unsafe ref BmSDK.GameObject.FMap_Mirror m_MorphedMeshesHashMap
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FMap_Mirror>(Ptr + 204);

    /// <summary>
    /// ArrayProperty: m_MergedMeshes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager.FSCustomizationMergedMeshData> m_MergedMeshes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager.FSCustomizationMergedMeshData>>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// ArrayProperty: m_LocalCharAltMeshIndex
    /// </summary>
    public unsafe BmSDK.TArray<int> m_LocalCharAltMeshIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// ArrayProperty: m_ActiveCharAltMeshIndex
    /// </summary>
    public unsafe BmSDK.TArray<int> m_ActiveCharAltMeshIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// ArrayProperty: m_PrevCharActiveAltMeshSkinIndex
    /// </summary>
    public unsafe BmSDK.TArray<int> m_PrevCharActiveAltMeshSkinIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// StructProperty: m_GameWinnerNetId
    /// </summary>
    public unsafe ref BmSDK.Engine.OnlineSubsystem.FUniqueNetId m_GameWinnerNetId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 312);

    /// <summary>
    /// Struct: FSCustomizationMergedMeshData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FSCustomizationMergedMeshData
    {
        /// <summary>
        /// NameProperty: Id
        /// </summary>
        public unsafe BmSDK.FName Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: RefCount
        /// </summary>
        public unsafe int RefCount
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: Mesh
        /// </summary>
        public unsafe BmSDK.Engine.SkeletalMesh Mesh
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FSCharacterCustomizationMorphSourceData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FSCharacterCustomizationMorphSourceData
    {
        /// <summary>
        /// NameProperty: ResourceID
        /// </summary>
        public unsafe BmSDK.FName ResourceID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: Mesh
        /// </summary>
        public unsafe BmSDK.Engine.SkeletalMesh Mesh
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: MorphSet
        /// </summary>
        public unsafe BmSDK.Engine.MorphTargetSet MorphSet
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MorphTargetSet>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ArrayProperty: MorphList
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> MorphList
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FSLobbyCustomizationMessage
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FSLobbyCustomizationMessage
    {
        /// <summary>
        /// StructProperty: MemberNetId
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId MemberNetId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: CurrentCustomizationSetsIndexed
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelectionIndexed> CurrentCustomizationSetsIndexed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelectionIndexed>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FSCharacterCustomizationPreloadedAltMesh
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FSCharacterCustomizationPreloadedAltMesh
    {
        /// <summary>
        /// StructProperty: MemberNetId
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId MemberNetId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: AltMeshChar
        /// </summary>
        public unsafe BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter AltMeshChar
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: AltMeshIndex
        /// </summary>
        public unsafe int AltMeshIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FSCharacterCustomizationPlayerPreloadData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FSCharacterCustomizationPlayerPreloadData
    {
        /// <summary>
        /// StructProperty: MemberNetId
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId MemberNetId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: PreloadedSetID
        /// </summary>
        public unsafe int PreloadedSetID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ArrayProperty: CustomizationSets
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection> CustomizationSets
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: IsValid
        /// </summary>
        public unsafe bool IsValid
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FSCharacterCustomizationUILoadedSet
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial record struct FSCharacterCustomizationUILoadedSet
    {
        /// <summary>
        /// IntProperty: LoadedSetId
        /// </summary>
        public unsafe int LoadedSetId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FSCharacterCustomizationCinematicActorData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FSCharacterCustomizationCinematicActorData
    {
        /// <summary>
        /// IntProperty: TeamIndex
        /// </summary>
        public unsafe int TeamIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: CinematicActor
        /// </summary>
        public unsafe BmSDK.BmGame.GDCinematicCustomizationActor CinematicActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDCinematicCustomizationActor>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ObjectProperty: AssignedWeapon
        /// </summary>
        public unsafe BmSDK.Engine.Actor AssignedWeapon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FSCharacterCustomizationBank
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FSCharacterCustomizationBank
    {
        /// <summary>
        /// ArrayProperty: m_CustomSelection
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection> m_CustomSelection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FSCharacterCustomization_PreLoadedResource
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FSCharacterCustomization_PreLoadedResource
    {
        /// <summary>
        /// IntProperty: RefCount
        /// </summary>
        public unsafe int RefCount
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: ResourceIndex
        /// </summary>
        public unsafe int ResourceIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: TeamIndex
        /// </summary>
        public unsafe int TeamIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ByteProperty: ResourceType
        /// </summary>
        public unsafe BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType ResourceType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ObjectProperty: Resource
        /// </summary>
        public unsafe BmSDK.SDEngine.SDAsyncResource Resource
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.SDEngine.SDAsyncResource>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FSCharacterCustomization_LoadedResource
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FSCharacterCustomization_LoadedResource
    {
        /// <summary>
        /// ObjectProperty: AsyncResource
        /// </summary>
        public unsafe BmSDK.SDEngine.SDAsyncResource AsyncResource
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.SDEngine.SDAsyncResource>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: RefCount
        /// </summary>
        public unsafe int RefCount
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FSCharCustomization_LoadedSelection
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 208)]
    public partial record struct FSCharCustomization_LoadedSelection
    {
        /// <summary>
        /// IntProperty: Id
        /// </summary>
        public unsafe int Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: TeamIndex
        /// </summary>
        public unsafe int TeamIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: RefCount
        /// </summary>
        public unsafe int RefCount
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: Selection
        /// </summary>
        public unsafe BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection Selection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ObjectProperty: Archetype
        /// </summary>
        public unsafe BmSDK.BmGame.GDCharCustomAsset_Archetype Archetype
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDCharCustomAsset_Archetype>(Ptr + 108); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }; }
        }

        /// <summary>
        /// ObjectProperty: FaceGear
        /// </summary>
        public unsafe BmSDK.BmGame.GDCharCustomAsset_FaceGear FaceGear
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDCharCustomAsset_FaceGear>(Ptr + 112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }; }
        }

        /// <summary>
        /// ObjectProperty: FacePaint
        /// </summary>
        public unsafe BmSDK.BmGame.GDCharCustomAsset_FacePaint FacePaint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDCharCustomAsset_FacePaint>(Ptr + 116); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }; }
        }

        /// <summary>
        /// ObjectProperty: FacialHair
        /// </summary>
        public unsafe BmSDK.BmGame.GDCharCustomAsset_FacialHair FacialHair
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDCharCustomAsset_FacialHair>(Ptr + 120); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }; }
        }

        /// <summary>
        /// ObjectProperty: Hair
        /// </summary>
        public unsafe BmSDK.BmGame.GDCharCustomAsset_Hair Hair
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDCharCustomAsset_Hair>(Ptr + 124); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }; }
        }

        /// <summary>
        /// ObjectProperty: Lower
        /// </summary>
        public unsafe BmSDK.BmGame.GDCharCustomAsset_Lower Lower
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDCharCustomAsset_Lower>(Ptr + 128); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }; }
        }

        /// <summary>
        /// ObjectProperty: Tattoo
        /// </summary>
        public unsafe BmSDK.BmGame.GDCharCustomAsset_Tattoo Tattoo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDCharCustomAsset_Tattoo>(Ptr + 132); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }; }
        }

        /// <summary>
        /// ObjectProperty: Undershirt
        /// </summary>
        public unsafe BmSDK.BmGame.GDCharCustomAsset_Undershirt Undershirt
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDCharCustomAsset_Undershirt>(Ptr + 136); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }; }
        }

        /// <summary>
        /// ObjectProperty: Upper
        /// </summary>
        public unsafe BmSDK.BmGame.GDCharCustomAsset_Upper Upper
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDCharCustomAsset_Upper>(Ptr + 140); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }; }
        }

        /// <summary>
        /// IntProperty: MorphedArchetypeMeshID
        /// </summary>
        public unsafe int MorphedArchetypeMeshID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }; }
        }

        /// <summary>
        /// IntProperty: MorphedLowerMeshID
        /// </summary>
        public unsafe int MorphedLowerMeshID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }; }
        }

        /// <summary>
        /// IntProperty: MorphedUpperMeshID
        /// </summary>
        public unsafe int MorphedUpperMeshID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }; }
        }

        /// <summary>
        /// IntProperty: MorphedFaceGearMeshID
        /// </summary>
        public unsafe int MorphedFaceGearMeshID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }; }
        }

        /// <summary>
        /// IntProperty: MorphedHairMeshID
        /// </summary>
        public unsafe int MorphedHairMeshID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }; }
        }

        /// <summary>
        /// IntProperty: MorphedFacialHairMeshID
        /// </summary>
        public unsafe int MorphedFacialHairMeshID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }; }
        }

        /// <summary>
        /// ObjectProperty: MorphedArchetypeMesh
        /// </summary>
        public unsafe BmSDK.Engine.SkeletalMesh MorphedArchetypeMesh
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 168); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }; }
        }

        /// <summary>
        /// ObjectProperty: MorphedLowerMesh
        /// </summary>
        public unsafe BmSDK.Engine.SkeletalMesh MorphedLowerMesh
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 172); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }; }
        }

        /// <summary>
        /// ObjectProperty: MorphedUpperMesh
        /// </summary>
        public unsafe BmSDK.Engine.SkeletalMesh MorphedUpperMesh
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 176); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }; }
        }

        /// <summary>
        /// ObjectProperty: MorphedFaceGearMesh
        /// </summary>
        public unsafe BmSDK.Engine.SkeletalMesh MorphedFaceGearMesh
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 180); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }; }
        }

        /// <summary>
        /// ObjectProperty: MorphedHairMesh
        /// </summary>
        public unsafe BmSDK.Engine.SkeletalMesh MorphedHairMesh
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 184); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }; }
        }

        /// <summary>
        /// ObjectProperty: MorphedFacialHairMesh
        /// </summary>
        public unsafe BmSDK.Engine.SkeletalMesh MorphedFacialHairMesh
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 188); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }; }
        }

        /// <summary>
        /// ObjectProperty: MergedPhysicsAsset
        /// </summary>
        public unsafe BmSDK.Engine.PhysicsAsset MergedPhysicsAsset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicsAsset>(Ptr + 192); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }; }
        }

        /// <summary>
        /// ByteProperty: MergedArchetypeMaterialIndex
        /// </summary>
        public unsafe byte MergedArchetypeMaterialIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 196); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }; }
        }

        /// <summary>
        /// ByteProperty: MergedLowerMaterialIndex
        /// </summary>
        public unsafe byte MergedLowerMaterialIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 197); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 197); }; }
        }

        /// <summary>
        /// ByteProperty: MergedUpperMaterialIndex
        /// </summary>
        public unsafe byte MergedUpperMaterialIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 198); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 198); }; }
        }

        /// <summary>
        /// ByteProperty: MergedFaceGearMaterialIndex
        /// </summary>
        public unsafe byte MergedFaceGearMaterialIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 199); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 199); }; }
        }

        /// <summary>
        /// ByteProperty: MergedHairMaterialIndex
        /// </summary>
        public unsafe byte MergedHairMaterialIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 200); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }; }
        }

        /// <summary>
        /// ByteProperty: MergedFacialHairMaterialIndex
        /// </summary>
        public unsafe byte MergedFacialHairMaterialIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 201); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 201); }; }
        }

        /// <summary>
        /// BoolProperty: bIsLoading
        /// </summary>
        public unsafe bool bIsLoading
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 204); }; }
        }

        /// <summary>
        /// BoolProperty: bUseStaticMorphs
        /// </summary>
        public unsafe bool bUseStaticMorphs
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 204); }; }
        }

        /// <summary>
        /// BoolProperty: bMergedMeshAndPhysics
        /// </summary>
        public unsafe bool bMergedMeshAndPhysics
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 204); }; }
        }
    }

    /// <summary>
    /// Struct: FSCharacterCustomizationPartInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 92)]
    public partial record struct FSCharacterCustomizationPartInfo
    {
        /// <summary>
        /// NameProperty: ResourceID
        /// </summary>
        public unsafe BmSDK.FName ResourceID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Name
        /// </summary>
        public unsafe BmSDK.FString Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StrProperty: Description
        /// </summary>
        public unsafe BmSDK.FString Description
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// IntProperty: MinLevel
        /// </summary>
        public unsafe int MinLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// IntProperty: NumSkins
        /// </summary>
        public unsafe int NumSkins
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: HasSkins
        /// </summary>
        public unsafe bool HasSkins
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: HasColor
        /// </summary>
        public unsafe bool HasColor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: StorePurchaseRequired
        /// </summary>
        public unsafe bool StorePurchaseRequired
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// StrProperty: NormalUUID
        /// </summary>
        public unsafe BmSDK.FString NormalUUID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// StrProperty: GearPlusUUID
        /// </summary>
        public unsafe BmSDK.FString GearPlusUUID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// BoolProperty: bUseGameplayEffector
        /// </summary>
        public unsafe bool bUseGameplayEffector
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }; }
        }

        /// <summary>
        /// ByteProperty: GameplayEffectorType
        /// </summary>
        public unsafe BmSDK.BmGame.GDConsumableGameplayEffectorBase.GameplayEffectorType GameplayEffectorType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDConsumableGameplayEffectorBase.GameplayEffectorType>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// FloatProperty: GameplayEffectorModifier
        /// </summary>
        public unsafe float GameplayEffectorModifier
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// ArrayProperty: SkinInfo
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager.FSSkinInfo> SkinInfo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager.FSSkinInfo>>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }
    }

    /// <summary>
    /// Struct: FSSkinInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial record struct FSSkinInfo
    {
        /// <summary>
        /// BoolProperty: StorePurchaseRequired
        /// </summary>
        public unsafe bool StorePurchaseRequired
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: NormalUUID
        /// </summary>
        public unsafe BmSDK.FString NormalUUID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StrProperty: GearPlusUUID
        /// </summary>
        public unsafe BmSDK.FString GearPlusUUID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// BoolProperty: bUseGameplayEffector
        /// </summary>
        public unsafe bool bUseGameplayEffector
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// ByteProperty: GameplayEffectorType
        /// </summary>
        public unsafe BmSDK.BmGame.GDConsumableGameplayEffectorBase.GameplayEffectorType GameplayEffectorType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDConsumableGameplayEffectorBase.GameplayEffectorType>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: GameplayEffectorModifier
        /// </summary>
        public unsafe float GameplayEffectorModifier
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }
    }

    /// <summary>
    /// Enum: eCharacterCustomizationPartType
    /// </summary>
    public enum eCharacterCustomizationPartType : byte
    {
        eCharacterCustomizationPartType_Archetype = 0,
        eCharacterCustomizationPartType_Undershirt = 1,
        eCharacterCustomizationPartType_Tattoo = 2,
        eCharacterCustomizationPartType_FacePaint = 3,
        eCharacterCustomizationPartType_Lower = 4,
        eCharacterCustomizationPartType_Upper = 5,
        eCharacterCustomizationPartType_FaceGear = 6,
        eCharacterCustomizationPartType_Hair = 7,
        eCharacterCustomizationPartType_FacialHair = 8,
        eCharacterCustomizationPartType_MAX = 9,
    }

    /// <summary>
    /// Enum: eAltMeshCharacter
    /// </summary>
    public enum eAltMeshCharacter : byte
    {
        eAltMeshCharacter_Batman = 0,
        eAltMeshCharacter_Robin = 1,
        eAltMeshCharacter_MAX = 2,
    }

    /// <summary>
    /// Enum: eCharacterCustomizationTeamData
    /// </summary>
    public enum eCharacterCustomizationTeamData : byte
    {
        eCharacterCustomizationTeamData_Joker = 0,
        eCharacterCustomizationTeamData_Bane = 1,
        eCharacterCustomizationTeamData_MAX = 2,
    }
}

/// <summary>
/// The static native functions of GDCharCustomizationManager, callable on an instance. A static native may read the object it runs on, and the static form runs it on the class default object, which has no world.
/// </summary>
public static class GDCharCustomizationManagerStatics
{
    private static BmSDK.Function __fn_ListLoadedCustomSelection;
    /// <summary>
    /// Function: ListLoadedCustomSelection, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void ListLoadedCustomSelection(this BmSDK.BmGame.GDCharCustomizationManager self, in BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection LoadedSelection)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListLoadedCustomSelection, "BmGame.GDCharCustomizationManager.ListLoadedCustomSelection");
        byte* paramsPtr = stackalloc byte[224];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelection, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_ListCustomSelection;
    /// <summary>
    /// Function: ListCustomSelection, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void ListCustomSelection(this BmSDK.BmGame.GDCharCustomizationManager self, in BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection Selection)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListCustomSelection, "BmGame.GDCharCustomizationManager.ListCustomSelection");
        byte* paramsPtr = stackalloc byte[112];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Selection, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_ConvertColor2LinearColor;
    /// <summary>
    /// Function: ConvertColor2LinearColor, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static BmSDK.GameObject.FLinearColor ConvertColor2LinearColor(this BmSDK.BmGame.GDCharCustomizationManager self, in BmSDK.GameObject.FColor RGBA)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConvertColor2LinearColor, "BmGame.GDCharCustomizationManager.ConvertColor2LinearColor");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RGBA, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FLinearColor>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetSkeletalMeshUseSecondaryPhysicsWeight;
    /// <summary>
    /// Function: SetSkeletalMeshUseSecondaryPhysicsWeight, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void SetSkeletalMeshUseSecondaryPhysicsWeight(this BmSDK.BmGame.GDCharCustomizationManager self, BmSDK.Engine.SkeletalMeshComponent SkelComponent, bool UseSecondaryPhysicsWeight)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSkeletalMeshUseSecondaryPhysicsWeight, "BmGame.GDCharCustomizationManager.SetSkeletalMeshUseSecondaryPhysicsWeight");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelComponent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UseSecondaryPhysicsWeight, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_FindAltArchetypeIndex;
    /// <summary>
    /// Function: FindAltArchetypeIndex, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static int FindAltArchetypeIndex(this BmSDK.BmGame.GDCharCustomizationManager self, BmSDK.BmGame.GDCharCustomAsset_Archetype Archetype, BmSDK.FName AltArchetypeName)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindAltArchetypeIndex, "BmGame.GDCharCustomizationManager.FindAltArchetypeIndex");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Archetype, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AltArchetypeName, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GenerateMorphList;
    /// <summary>
    /// Function: GenerateMorphList, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static int GenerateMorphList(this BmSDK.BmGame.GDCharCustomizationManager self, in BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection LoadedSelection, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, out BmSDK.TArray<BmSDK.FName> outMorphList, bool bUseUIMorphTarget = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GenerateMorphList, "BmGame.GDCharCustomizationManager.GenerateMorphList");
        byte* paramsPtr = stackalloc byte[248];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 208);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseUIMorphTarget, paramsPtr + 224);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        outMorphList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FName>>(paramsPtr + 212);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 228);
    }

    private static BmSDK.Function __fn_GetUIMorphName;
    /// <summary>
    /// Function: GetUIMorphName, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void GetUIMorphName(this BmSDK.BmGame.GDCharCustomizationManager self, BmSDK.SDEngine.SDAsyncResource MasterMorphSet, in BmSDK.FName ArchetypeMorphName, out BmSDK.FName outMorphName)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUIMorphName, "BmGame.GDCharCustomizationManager.GetUIMorphName");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MasterMorphSet, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArchetypeMorphName, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out outMorphName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(outMorphName, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        outMorphName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetArchetypeMeshForSelection;
    /// <summary>
    /// Function: GetArchetypeMeshForSelection, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static BmSDK.SDEngine.SDAsyncResource GetArchetypeMeshForSelection(this BmSDK.BmGame.GDCharCustomizationManager self, in BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection LoadedSelection)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetArchetypeMeshForSelection, "BmGame.GDCharCustomizationManager.GetArchetypeMeshForSelection");
        byte* paramsPtr = stackalloc byte[228];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelection, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.SDEngine.SDAsyncResource>(paramsPtr + 208);
    }
}
