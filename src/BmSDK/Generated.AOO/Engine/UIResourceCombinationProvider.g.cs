#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: UIResourceCombinationProvider<br/>
/// (size = 96)
/// (flags = 134251675)
/// </summary>
public partial class UIResourceCombinationProvider : BmSDK.Engine.UIDataProvider, BmSDK.Engine.UIListElementProvider, BmSDK.Engine.UIListElementCellProvider, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UIResourceCombinationProvider", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as UIResourceCombinationProvider.
    /// </summary>
    public static UIResourceCombinationProvider DefaultObject => (UIResourceCombinationProvider)StaticClass().DefaultObject;

    internal UIResourceCombinationProvider() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UIResourceCombinationProvider(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<UIResourceCombinationProvider>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIResourceCombinationProvider>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<UIResourceCombinationProvider>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIResourceCombinationProvider>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIResourceCombinationProvider>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIResourceCombinationProvider>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<UIResourceCombinationProvider>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIResourceCombinationProvider>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ReplaceProviderCollection;
    /// <summary>
    /// Function: ReplaceProviderCollection
    /// </summary>
    public unsafe virtual bool ReplaceProviderCollection(out BmSDK.TArray<BmSDK.Engine.UIDataProvider.FUIDataProviderField> out_Fields, BmSDK.FName TargetFieldTag, in BmSDK.TArray<BmSDK.Engine.UIDataProvider> ReplacementProviders)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplaceProviderCollection, "Engine.UIResourceCombinationProvider.ReplaceProviderCollection");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetFieldTag, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReplacementProviders, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_Fields = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.UIDataProvider.FUIDataProviderField>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_ReplaceProviderValue;
    /// <summary>
    /// Function: ReplaceProviderValue
    /// </summary>
    public unsafe virtual bool ReplaceProviderValue(out BmSDK.TArray<BmSDK.Engine.UIDataProvider.FUIDataProviderField> out_Fields, BmSDK.FName TargetFieldTag, BmSDK.Engine.UIDataProvider ReplacementProvider)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplaceProviderValue, "Engine.UIResourceCombinationProvider.ReplaceProviderValue");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetFieldTag, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReplacementProvider, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_Fields = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.UIDataProvider.FUIDataProviderField>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_ClearProviderReferences;
    /// <summary>
    /// Function: ClearProviderReferences
    /// </summary>
    public unsafe virtual void ClearProviderReferences()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearProviderReferences, "Engine.UIResourceCombinationProvider.ClearProviderReferences");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCellFieldValue;
    /// <summary>
    /// Function: GetCellFieldValue
    /// </summary>
    public unsafe virtual bool GetCellFieldValue(BmSDK.FName FieldName, BmSDK.FName CellTag, int ListIndex, out BmSDK.Engine.UIRoot.FUIProviderFieldValue out_FieldValue, int ArrayIndex = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCellFieldValue, "Engine.UIResourceCombinationProvider.GetCellFieldValue");
        byte* paramsPtr = stackalloc byte[136];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CellTag, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ListIndex, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArrayIndex, paramsPtr + 108);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_FieldValue = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.UIRoot.FUIProviderFieldValue>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 112);
    }

    private static BmSDK.Function __fn_GetCellFieldType;
    /// <summary>
    /// Function: GetCellFieldType
    /// </summary>
    public unsafe virtual bool GetCellFieldType(BmSDK.FName FieldName, BmSDK.FName CellTag, out BmSDK.Engine.UIRoot.EUIDataProviderFieldType FieldType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCellFieldType, "Engine.UIResourceCombinationProvider.GetCellFieldType");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CellTag, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldType);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldType, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        FieldType = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.UIRoot.EUIDataProviderFieldType>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetElementCellTags;
    /// <summary>
    /// Function: GetElementCellTags
    /// </summary>
    public unsafe virtual void GetElementCellTags(BmSDK.FName FieldName, out BmSDK.TArray<BmSDK.FName> CellFieldTags, out BmSDK.TArray<BmSDK.FString> ColumnHeaderDisplayText)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetElementCellTags, "Engine.UIResourceCombinationProvider.GetElementCellTags");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldName, paramsPtr + 0);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        CellFieldTags = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FName>>(paramsPtr + 8);
        ColumnHeaderDisplayText = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 20);
        return;
    }

    private static BmSDK.Function __fn_GetElementCellValueProvider;
    /// <summary>
    /// Function: GetElementCellValueProvider
    /// </summary>
    public unsafe virtual bool GetElementCellValueProvider(BmSDK.FName FieldName, int ListIndex, out BmSDK.Engine.UIListElementCellProvider out_ValueProvider)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetElementCellValueProvider, "Engine.UIResourceCombinationProvider.GetElementCellValueProvider");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ListIndex, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_ValueProvider);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_ValueProvider, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_ValueProvider = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.UIListElementCellProvider>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetElementCellSchemaProvider;
    /// <summary>
    /// Function: GetElementCellSchemaProvider
    /// </summary>
    public unsafe virtual bool GetElementCellSchemaProvider(BmSDK.FName FieldName, out BmSDK.Engine.UIListElementCellProvider out_SchemaProvider)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetElementCellSchemaProvider, "Engine.UIResourceCombinationProvider.GetElementCellSchemaProvider");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_SchemaProvider);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_SchemaProvider, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_SchemaProvider = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.UIListElementCellProvider>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_IsElementEnabled;
    /// <summary>
    /// Function: IsElementEnabled
    /// </summary>
    public unsafe virtual bool IsElementEnabled(BmSDK.FName FieldName, int CollectionIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsElementEnabled, "Engine.UIResourceCombinationProvider.IsElementEnabled");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollectionIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetListElements;
    /// <summary>
    /// Function: GetListElements
    /// </summary>
    public unsafe virtual bool GetListElements(BmSDK.FName FieldName, out BmSDK.TArray<int> out_Elements)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetListElements, "Engine.UIResourceCombinationProvider.GetListElements");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_Elements = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<int>>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetElementCount;
    /// <summary>
    /// Function: GetElementCount
    /// </summary>
    public unsafe virtual int GetElementCount(BmSDK.FName FieldName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetElementCount, "Engine.UIResourceCombinationProvider.GetElementCount");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetElementProviderTags;
    /// <summary>
    /// Function: GetElementProviderTags
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.FName> GetElementProviderTags()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetElementProviderTags, "Engine.UIResourceCombinationProvider.GetElementProviderTags");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FName>>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InitializeProvider;
    /// <summary>
    /// Function: InitializeProvider
    /// </summary>
    public unsafe virtual void InitializeProvider(bool bIsEditor, BmSDK.Engine.UIResourceDataProvider InStaticResourceProvider, BmSDK.Engine.UIDataProvider_OnlineProfileSettings InProfileProvider)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitializeProvider, "Engine.UIResourceCombinationProvider.InitializeProvider");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsEditor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InStaticResourceProvider, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InProfileProvider, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StructProperty: VfTable_IUIListElementProvider
    /// </summary>
    public unsafe System.IntPtr VfTable_IUIListElementProvider
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// StructProperty: VfTable_IUIListElementCellProvider
    /// </summary>
    public unsafe System.IntPtr VfTable_IUIListElementCellProvider
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: StaticDataProvider
    /// </summary>
    public unsafe BmSDK.Engine.UIResourceDataProvider StaticDataProvider
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIResourceDataProvider>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// ObjectProperty: ProfileProvider
    /// </summary>
    public unsafe BmSDK.Engine.UIDataProvider_OnlineProfileSettings ProfileProvider
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIDataProvider_OnlineProfileSettings>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }
}
