#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: UIDataStore_OnlinePlaylists<br/>
/// (size = 156)
/// (flags = 134250654)
/// </summary>
public partial class UIDataStore_OnlinePlaylists : BmSDK.Engine.UIDataStore, BmSDK.Engine.UIListElementProvider, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UIDataStore_OnlinePlaylists", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as UIDataStore_OnlinePlaylists.
    /// </summary>
    public static UIDataStore_OnlinePlaylists DefaultObject => (UIDataStore_OnlinePlaylists)StaticClass().DefaultObject;

    internal UIDataStore_OnlinePlaylists() { }

    /// <summary>
    /// Constructs a new UIDataStore_OnlinePlaylists
    /// </summary>
    public UIDataStore_OnlinePlaylists(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, UIDataStore_OnlinePlaylists Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UIDataStore_OnlinePlaylists(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<UIDataStore_OnlinePlaylists>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIDataStore_OnlinePlaylists>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<UIDataStore_OnlinePlaylists>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIDataStore_OnlinePlaylists>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIDataStore_OnlinePlaylists>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIDataStore_OnlinePlaylists>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<UIDataStore_OnlinePlaylists>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIDataStore_OnlinePlaylists>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetOnlinePlaylistProvider;
    /// <summary>
    /// Function: GetOnlinePlaylistProvider
    /// </summary>
    public unsafe static BmSDK.Engine.OnlinePlaylistProvider GetOnlinePlaylistProvider(BmSDK.FName ProviderTag, int PlaylistId, out int ProviderIndex)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOnlinePlaylistProvider, "Engine.UIDataStore_OnlinePlaylists.GetOnlinePlaylistProvider");
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProviderTag, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlaylistId, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ProviderIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProviderIndex, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ProviderIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlinePlaylistProvider>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetPlaylistProvider;
    /// <summary>
    /// Function: GetPlaylistProvider
    /// </summary>
    public unsafe virtual bool GetPlaylistProvider(BmSDK.FName ProviderTag, int ProviderIndex, out BmSDK.Engine.UIResourceDataProvider out_Provider)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlaylistProvider, "Engine.UIDataStore_OnlinePlaylists.GetPlaylistProvider");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProviderTag, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProviderIndex, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_Provider);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_Provider, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_Provider = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.UIResourceDataProvider>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_FindProviderIndexByFieldValue;
    /// <summary>
    /// Function: FindProviderIndexByFieldValue
    /// </summary>
    public unsafe virtual int FindProviderIndexByFieldValue(BmSDK.FName ProviderTag, BmSDK.FName SearchField, in BmSDK.Engine.UIRoot.FUIProviderScriptFieldValue ValueToSearchFor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindProviderIndexByFieldValue, "Engine.UIDataStore_OnlinePlaylists.FindProviderIndexByFieldValue");
        byte* paramsPtr = stackalloc byte[120];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProviderTag, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchField, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ValueToSearchFor, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 100);
    }

    private static BmSDK.Function __fn_GetProviderFieldValue;
    /// <summary>
    /// Function: GetProviderFieldValue
    /// </summary>
    public unsafe virtual bool GetProviderFieldValue(BmSDK.FName ProviderTag, BmSDK.FName SearchField, int ProviderIndex, out BmSDK.Engine.UIRoot.FUIProviderScriptFieldValue out_FieldValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProviderFieldValue, "Engine.UIDataStore_OnlinePlaylists.GetProviderFieldValue");
        byte* paramsPtr = stackalloc byte[124];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProviderTag, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchField, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProviderIndex, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_FieldValue = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.UIRoot.FUIProviderScriptFieldValue>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 104);
    }

    private static BmSDK.Function __fn_GetResourceProviderFields;
    /// <summary>
    /// Function: GetResourceProviderFields
    /// </summary>
    public unsafe virtual bool GetResourceProviderFields(BmSDK.FName ProviderTag, out BmSDK.TArray<BmSDK.FName> ProviderFieldTags)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetResourceProviderFields, "Engine.UIDataStore_OnlinePlaylists.GetResourceProviderFields");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProviderTag, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ProviderFieldTags = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FName>>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetResourceProviders;
    /// <summary>
    /// Function: GetResourceProviders
    /// </summary>
    public unsafe virtual bool GetResourceProviders(BmSDK.FName ProviderTag, out BmSDK.TArray<BmSDK.Engine.UIResourceDataProvider> out_Providers)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetResourceProviders, "Engine.UIDataStore_OnlinePlaylists.GetResourceProviders");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProviderTag, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_Providers = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.UIResourceDataProvider>>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetProviderCount;
    /// <summary>
    /// Function: GetProviderCount
    /// </summary>
    public unsafe virtual int GetProviderCount(BmSDK.FName ProviderTag)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProviderCount, "Engine.UIDataStore_OnlinePlaylists.GetProviderCount");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProviderTag, paramsPtr + 0);
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
    /// StructProperty: VfTable_IUIListElementProvider
    /// </summary>
    public unsafe System.IntPtr VfTable_IUIListElementProvider
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// StrProperty: ProviderClassName
    /// </summary>
    public unsafe BmSDK.FString ProviderClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ClassProperty: ProviderClass
    /// </summary>
    public unsafe BmSDK.Class ProviderClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// ArrayProperty: RankedDataProviders
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.UIResourceDataProvider> RankedDataProviders
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.UIResourceDataProvider>>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ArrayProperty: UnRankedDataProviders
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.UIResourceDataProvider> UnRankedDataProviders
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.UIResourceDataProvider>>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }
}
