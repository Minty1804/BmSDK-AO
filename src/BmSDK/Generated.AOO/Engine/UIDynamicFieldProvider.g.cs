#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: UIDynamicFieldProvider<br/>
/// (size = 224)
/// (flags = 134251670)
/// </summary>
public partial class UIDynamicFieldProvider : BmSDK.Engine.UIDataProvider, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UIDynamicFieldProvider", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as UIDynamicFieldProvider.
    /// </summary>
    public static UIDynamicFieldProvider DefaultObject => (UIDynamicFieldProvider)StaticClass().DefaultObject;

    internal UIDynamicFieldProvider() { }

    /// <summary>
    /// Constructs a new UIDynamicFieldProvider
    /// </summary>
    public UIDynamicFieldProvider(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, UIDynamicFieldProvider Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UIDynamicFieldProvider(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<UIDynamicFieldProvider>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIDynamicFieldProvider>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<UIDynamicFieldProvider>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIDynamicFieldProvider>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIDynamicFieldProvider>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIDynamicFieldProvider>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<UIDynamicFieldProvider>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIDynamicFieldProvider>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_FindCollectionValueIndex;
    /// <summary>
    /// Function: FindCollectionValueIndex
    /// </summary>
    public unsafe virtual int FindCollectionValueIndex(BmSDK.FName FieldName, in BmSDK.FString ValueToFind, bool bPersistent = default, BmSDK.FName CellTag = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindCollectionValueIndex, "Engine.UIDynamicFieldProvider.FindCollectionValueIndex");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ValueToFind, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistent, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CellTag, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GetCollectionValue;
    /// <summary>
    /// Function: GetCollectionValue
    /// </summary>
    public unsafe virtual bool GetCollectionValue(BmSDK.FName FieldName, int ValueIndex, out BmSDK.FString out_Value, bool bPersistent = default, BmSDK.FName CellTag = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCollectionValue, "Engine.UIDynamicFieldProvider.GetCollectionValue");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ValueIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistent, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CellTag, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_Value = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_ClearCollectionValueArray;
    /// <summary>
    /// Function: ClearCollectionValueArray
    /// </summary>
    public unsafe virtual bool ClearCollectionValueArray(BmSDK.FName FieldName, bool bPersistent = default, BmSDK.FName CellTag = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearCollectionValueArray, "Engine.UIDynamicFieldProvider.ClearCollectionValueArray");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistent, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CellTag, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ReplaceCollectionValueByIndex;
    /// <summary>
    /// Function: ReplaceCollectionValueByIndex
    /// </summary>
    public unsafe virtual bool ReplaceCollectionValueByIndex(BmSDK.FName FieldName, int ValueIndex, in BmSDK.FString NewValue, bool bPersistent = default, BmSDK.FName CellTag = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplaceCollectionValueByIndex, "Engine.UIDynamicFieldProvider.ReplaceCollectionValueByIndex");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ValueIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewValue, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistent, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CellTag, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_ReplaceCollectionValue;
    /// <summary>
    /// Function: ReplaceCollectionValue
    /// </summary>
    public unsafe virtual bool ReplaceCollectionValue(BmSDK.FName FieldName, in BmSDK.FString CurrentValue, in BmSDK.FString NewValue, bool bPersistent = default, BmSDK.FName CellTag = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplaceCollectionValue, "Engine.UIDynamicFieldProvider.ReplaceCollectionValue");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentValue, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewValue, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistent, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CellTag, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_RemoveCollectionValueByIndex;
    /// <summary>
    /// Function: RemoveCollectionValueByIndex
    /// </summary>
    public unsafe virtual bool RemoveCollectionValueByIndex(BmSDK.FName FieldName, int ValueIndex, bool bPersistent = default, BmSDK.FName CellTag = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveCollectionValueByIndex, "Engine.UIDynamicFieldProvider.RemoveCollectionValueByIndex");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ValueIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistent, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CellTag, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_RemoveCollectionValue;
    /// <summary>
    /// Function: RemoveCollectionValue
    /// </summary>
    public unsafe virtual bool RemoveCollectionValue(BmSDK.FName FieldName, in BmSDK.FString ValueToRemove, bool bPersistent = default, BmSDK.FName CellTag = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveCollectionValue, "Engine.UIDynamicFieldProvider.RemoveCollectionValue");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ValueToRemove, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistent, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CellTag, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_InsertCollectionValue;
    /// <summary>
    /// Function: InsertCollectionValue
    /// </summary>
    public unsafe virtual bool InsertCollectionValue(BmSDK.FName FieldName, in BmSDK.FString NewValue, int InsertIndex = default, bool bPersistent = default, bool bAllowDuplicateValues = default, BmSDK.FName CellTag = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InsertCollectionValue, "Engine.UIDynamicFieldProvider.InsertCollectionValue");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewValue, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InsertIndex, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistent, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowDuplicateValues, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CellTag, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_SetCollectionValueArray;
    /// <summary>
    /// Function: SetCollectionValueArray
    /// </summary>
    public unsafe virtual bool SetCollectionValueArray(BmSDK.FName FieldName, in BmSDK.TArray<BmSDK.FString> CollectionValues, bool bClearExisting = default, int InsertIndex = default, bool bPersistent = default, BmSDK.FName CellTag = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCollectionValueArray, "Engine.UIDynamicFieldProvider.SetCollectionValueArray");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollectionValues, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bClearExisting, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InsertIndex, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistent, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CellTag, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_GetCollectionValueArray;
    /// <summary>
    /// Function: GetCollectionValueArray
    /// </summary>
    public unsafe virtual bool GetCollectionValueArray(BmSDK.FName FieldName, out BmSDK.TArray<BmSDK.FString> out_DataValueArray, bool bPersistent = default, BmSDK.FName CellTag = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCollectionValueArray, "Engine.UIDynamicFieldProvider.GetCollectionValueArray");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistent, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CellTag, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_DataValueArray = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GetCollectionValueSchema;
    /// <summary>
    /// Function: GetCollectionValueSchema
    /// </summary>
    public unsafe virtual bool GetCollectionValueSchema(BmSDK.FName FieldName, out BmSDK.TArray<BmSDK.FName> out_CellTagArray, bool bPersistent = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCollectionValueSchema, "Engine.UIDynamicFieldProvider.GetCollectionValueSchema");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistent, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_CellTagArray = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FName>>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_SavePersistentProviderData;
    /// <summary>
    /// Function: SavePersistentProviderData
    /// </summary>
    public unsafe virtual void SavePersistentProviderData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SavePersistentProviderData, "Engine.UIDynamicFieldProvider.SavePersistentProviderData");
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

    private static BmSDK.Function __fn_SetField;
    /// <summary>
    /// Function: SetField
    /// </summary>
    public unsafe virtual bool SetField(BmSDK.FName FieldName, in BmSDK.Engine.UIRoot.FUIProviderScriptFieldValue FieldValue, bool bChangeExistingOnly = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetField, "Engine.UIDynamicFieldProvider.SetField");
        byte* paramsPtr = stackalloc byte[116];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldValue, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bChangeExistingOnly, paramsPtr + 92);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 96);
    }

    private static BmSDK.Function __fn_GetField;
    /// <summary>
    /// Function: GetField
    /// </summary>
    public unsafe virtual bool GetField(BmSDK.FName FieldName, out BmSDK.Engine.UIRoot.FUIProviderScriptFieldValue out_Field)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetField, "Engine.UIDynamicFieldProvider.GetField");
        byte* paramsPtr = stackalloc byte[112];
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
        out_Field = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.UIRoot.FUIProviderScriptFieldValue>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 92);
    }

    private static BmSDK.Function __fn_ClearFields;
    /// <summary>
    /// Function: ClearFields
    /// </summary>
    public unsafe virtual bool ClearFields(bool bReinitializeRuntimeFields = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearFields, "Engine.UIDynamicFieldProvider.ClearFields");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bReinitializeRuntimeFields, paramsPtr + 0);
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

    private static BmSDK.Function __fn_FindFieldIndex;
    /// <summary>
    /// Function: FindFieldIndex
    /// </summary>
    public unsafe virtual int FindFieldIndex(BmSDK.FName FieldName, bool bSearchPersistentFields = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindFieldIndex, "Engine.UIDynamicFieldProvider.FindFieldIndex");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSearchPersistentFields, paramsPtr + 8);
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

    private static BmSDK.Function __fn_RemoveField;
    /// <summary>
    /// Function: RemoveField
    /// </summary>
    public unsafe virtual bool RemoveField(BmSDK.FName FieldName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveField, "Engine.UIDynamicFieldProvider.RemoveField");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AddField;
    /// <summary>
    /// Function: AddField
    /// </summary>
    public unsafe virtual bool AddField(BmSDK.FName FieldName, BmSDK.Engine.UIRoot.EUIDataProviderFieldType FieldType, bool bPersistent, out int out_InsertPosition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddField, "Engine.UIDynamicFieldProvider.AddField");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistent, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_InsertPosition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_InsertPosition, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_InsertPosition = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_InitializeRuntimeFields;
    /// <summary>
    /// Function: InitializeRuntimeFields
    /// </summary>
    public unsafe virtual void InitializeRuntimeFields()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitializeRuntimeFields, "Engine.UIDynamicFieldProvider.InitializeRuntimeFields");
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

    /// <summary>
    /// ArrayProperty: PersistentDataFields
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.UIRoot.FUIProviderScriptFieldValue> PersistentDataFields
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.UIRoot.FUIProviderScriptFieldValue>>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// ArrayProperty: RuntimeDataFields
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.UIRoot.FUIProviderScriptFieldValue> RuntimeDataFields
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.UIRoot.FUIProviderScriptFieldValue>>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// StructProperty: PersistentCollectionData
    /// </summary>
    public unsafe ref BmSDK.GameObject.FMap_Mirror PersistentCollectionData
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FMap_Mirror>(Ptr + 104);

    /// <summary>
    /// StructProperty: RuntimeCollectionData
    /// </summary>
    public unsafe ref BmSDK.GameObject.FMap_Mirror RuntimeCollectionData
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FMap_Mirror>(Ptr + 164);
}
