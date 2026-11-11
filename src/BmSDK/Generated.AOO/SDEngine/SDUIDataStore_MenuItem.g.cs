#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.SDEngine;

/// <summary>
/// Class: SDUIDataStore_MenuItem<br/>
/// (size = 220)
/// (flags = 134250654)
/// </summary>
public partial class SDUIDataStore_MenuItem : BmSDK.Engine.UIDataStore_GameResource, BmSDK.Engine.UIListElementCellProvider, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "SDEngine.SDUIDataStore_MenuItem", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as SDUIDataStore_MenuItem.
    /// </summary>
    public static SDUIDataStore_MenuItem DefaultObject => (SDUIDataStore_MenuItem)StaticClass().DefaultObject;

    internal SDUIDataStore_MenuItem() { }

    /// <summary>
    /// Constructs a new SDUIDataStore_MenuItem
    /// </summary>
    public SDUIDataStore_MenuItem(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SDUIDataStore_MenuItem Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SDUIDataStore_MenuItem(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDUIDataStore_MenuItem>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDUIDataStore_MenuItem>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDUIDataStore_MenuItem>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDUIDataStore_MenuItem>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDUIDataStore_MenuItem>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDUIDataStore_MenuItem>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDUIDataStore_MenuItem>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDUIDataStore_MenuItem>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CreateFriendlyMapName;
    /// <summary>
    /// Function: CreateFriendlyMapName
    /// </summary>
    public unsafe virtual BmSDK.FString CreateFriendlyMapName(BmSDK.FString MapFileName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateFriendlyMapName, "SDEngine.SDUIDataStore_MenuItem.CreateFriendlyMapName");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapFileName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_IgnoreMapFilename;
    /// <summary>
    /// Function: IgnoreMapFilename
    /// </summary>
    public unsafe virtual bool IgnoreMapFilename(BmSDK.FString MapnameToIgnore)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IgnoreMapFilename, "SDEngine.SDUIDataStore_MenuItem.IgnoreMapFilename");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapnameToIgnore, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetMapFilenameExtension;
    /// <summary>
    /// Function: GetMapFilenameExtension
    /// </summary>
    public unsafe virtual BmSDK.FString GetMapFilenameExtension()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMapFilenameExtension, "SDEngine.SDUIDataStore_MenuItem.GetMapFilenameExtension");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AddListElementProvidersKey;
    /// <summary>
    /// Function: AddListElementProvidersKey
    /// </summary>
    public unsafe virtual void AddListElementProvidersKey(BmSDK.FName KeyName, BmSDK.SDEngine.SDUIDataProvider_Resource Provider)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddListElementProvidersKey, "SDEngine.SDUIDataStore_MenuItem.AddListElementProvidersKey");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Provider, paramsPtr + 8);
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

    private static BmSDK.Function __fn_RemoveListElementProvidersKey;
    /// <summary>
    /// Function: RemoveListElementProvidersKey
    /// </summary>
    public unsafe virtual void RemoveListElementProvidersKey(BmSDK.FName KeyName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveListElementProvidersKey, "SDEngine.SDUIDataStore_MenuItem.RemoveListElementProvidersKey");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyName, paramsPtr + 0);
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

    private static BmSDK.Function __fn_InitializeListElementProviders;
    /// <summary>
    /// Function: InitializeListElementProviders
    /// </summary>
    public unsafe virtual void InitializeListElementProviders()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitializeListElementProviders, "SDEngine.SDUIDataStore_MenuItem.InitializeListElementProviders");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetProviderSet;
    /// <summary>
    /// Function: GetProviderSet
    /// </summary>
    public unsafe virtual bool GetProviderSet(BmSDK.FName ProviderFieldName, out BmSDK.TArray<BmSDK.SDEngine.SDUIDataProvider_Resource> OutProviders)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProviderSet, "SDEngine.SDUIDataStore_MenuItem.GetProviderSet");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProviderFieldName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutProviders = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.SDEngine.SDUIDataProvider_Resource>>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetValueFromProviderSet;
    /// <summary>
    /// Function: GetValueFromProviderSet
    /// </summary>
    public unsafe virtual bool GetValueFromProviderSet(BmSDK.FName ProviderFieldName, BmSDK.FName SearchTag, int ListIndex, out BmSDK.FString OutValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetValueFromProviderSet, "SDEngine.SDUIDataStore_MenuItem.GetValueFromProviderSet");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProviderFieldName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchTag, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ListIndex, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutValue = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_FindValueInProviderSet;
    /// <summary>
    /// Function: FindValueInProviderSet
    /// </summary>
    public unsafe virtual int FindValueInProviderSet(BmSDK.FName ProviderFieldName, BmSDK.FName SearchTag, BmSDK.FString SearchValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindValueInProviderSet, "SDEngine.SDUIDataStore_MenuItem.FindValueInProviderSet");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProviderFieldName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchTag, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchValue, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_GetAllResourceDataProviders;
    /// <summary>
    /// Function: GetAllResourceDataProviders
    /// </summary>
    public unsafe static void GetAllResourceDataProviders(BmSDK.Class ProviderClass, out BmSDK.TArray<BmSDK.SDEngine.SDUIDataProvider_Resource> Providers)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAllResourceDataProviders, "SDEngine.SDUIDataStore_MenuItem.GetAllResourceDataProviders");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProviderClass, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Providers = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.SDEngine.SDUIDataProvider_Resource>>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_IsProviderFiltered;
    /// <summary>
    /// Function: IsProviderFiltered
    /// </summary>
    public unsafe virtual bool IsProviderFiltered(BmSDK.FName FieldName, int ProviderIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsProviderFiltered, "SDEngine.SDUIDataStore_MenuItem.IsProviderFiltered");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProviderIdx, paramsPtr + 8);
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

    private static BmSDK.Function __fn_GetProviderCount;
    /// <summary>
    /// Function: GetProviderCount
    /// </summary>
    public unsafe override int GetProviderCount(BmSDK.FName FieldName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProviderCount, "SDEngine.SDUIDataStore_MenuItem.GetProviderCount");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldName, paramsPtr + 0);
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

    /// <summary>
    /// StructProperty: VfTable_IUIListElementCellProvider
    /// </summary>
    public unsafe System.IntPtr VfTable_IUIListElementCellProvider
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// StrProperty: MapFilenameExtentsion
    /// </summary>
    public unsafe BmSDK.FString MapFilenameExtentsion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// ArrayProperty: MapFilenameIgnoreList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> MapFilenameIgnoreList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// ClassProperty: MapInfoDataProviderClass
    /// </summary>
    public unsafe BmSDK.Class MapInfoDataProviderClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }
}

/// <summary>
/// The static native functions of SDUIDataStore_MenuItem, callable on an instance. A static native may read the object it runs on, and the static form runs it on the class default object, which has no world.
/// </summary>
public static class SDUIDataStore_MenuItemStatics
{
    private static BmSDK.Function __fn_GetAllResourceDataProviders;
    /// <summary>
    /// Function: GetAllResourceDataProviders, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void GetAllResourceDataProviders(this BmSDK.SDEngine.SDUIDataStore_MenuItem self, BmSDK.Class ProviderClass, out BmSDK.TArray<BmSDK.SDEngine.SDUIDataProvider_Resource> Providers)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAllResourceDataProviders, "SDEngine.SDUIDataStore_MenuItem.GetAllResourceDataProviders");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProviderClass, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Providers = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.SDEngine.SDUIDataProvider_Resource>>(paramsPtr + 4);
        return;
    }
}
