#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: Settings<br/>
/// (size = 92)
/// (flags = 134217907)
/// </summary>
public partial class Settings : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Settings", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as Settings.
    /// </summary>
    public static Settings DefaultObject => (Settings)StaticClass().DefaultObject;

    internal Settings() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Settings(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Settings>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Settings>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Settings>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Settings>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Settings>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Settings>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Settings>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Settings>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_UpdateFromURL;
    /// <summary>
    /// Function: UpdateFromURL
    /// </summary>
    public unsafe virtual void UpdateFromURL(in BmSDK.FString URL, BmSDK.Engine.GameInfo Game)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateFromURL, "Engine.Settings.UpdateFromURL");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(URL, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Game, paramsPtr + 12);
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

    private static BmSDK.Function __fn_BuildURL;
    /// <summary>
    /// Function: BuildURL
    /// </summary>
    public unsafe virtual void BuildURL(out BmSDK.FString URL)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuildURL, "Engine.Settings.BuildURL");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        URL = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_AppendContextsToURL;
    /// <summary>
    /// Function: AppendContextsToURL
    /// </summary>
    public unsafe virtual void AppendContextsToURL(out BmSDK.FString URL)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AppendContextsToURL, "Engine.Settings.AppendContextsToURL");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        URL = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_AppendPropertiesToURL;
    /// <summary>
    /// Function: AppendPropertiesToURL
    /// </summary>
    public unsafe virtual void AppendPropertiesToURL(out BmSDK.FString URL)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AppendPropertiesToURL, "Engine.Settings.AppendPropertiesToURL");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        URL = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_AppendDataBindingsToURL;
    /// <summary>
    /// Function: AppendDataBindingsToURL
    /// </summary>
    public unsafe virtual void AppendDataBindingsToURL(out BmSDK.FString URL)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AppendDataBindingsToURL, "Engine.Settings.AppendDataBindingsToURL");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        URL = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetQoSAdvertisedStringSettings;
    /// <summary>
    /// Function: GetQoSAdvertisedStringSettings
    /// </summary>
    public unsafe virtual void GetQoSAdvertisedStringSettings(out BmSDK.TArray<BmSDK.Engine.Settings.FLocalizedStringSetting> QoSSettings)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetQoSAdvertisedStringSettings, "Engine.Settings.GetQoSAdvertisedStringSettings");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        QoSSettings = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Settings.FLocalizedStringSetting>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetQoSAdvertisedProperties;
    /// <summary>
    /// Function: GetQoSAdvertisedProperties
    /// </summary>
    public unsafe virtual void GetQoSAdvertisedProperties(out BmSDK.TArray<BmSDK.Engine.Settings.FSettingsProperty> QoSProps)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetQoSAdvertisedProperties, "Engine.Settings.GetQoSAdvertisedProperties");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        QoSProps = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Settings.FSettingsProperty>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetRangedPropertyValue;
    /// <summary>
    /// Function: GetRangedPropertyValue
    /// </summary>
    public unsafe virtual bool GetRangedPropertyValue(int PropertyId, out float OutValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRangedPropertyValue, "Engine.Settings.GetRangedPropertyValue");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropertyId, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutValue);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutValue, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutValue = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetRangedPropertyValue;
    /// <summary>
    /// Function: SetRangedPropertyValue
    /// </summary>
    public unsafe virtual bool SetRangedPropertyValue(int PropertyId, float NewValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRangedPropertyValue, "Engine.Settings.SetRangedPropertyValue");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropertyId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewValue, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetPropertyRange;
    /// <summary>
    /// Function: GetPropertyRange
    /// </summary>
    public unsafe virtual bool GetPropertyRange(int PropertyId, out float OutMinValue, out float OutMaxValue, out float RangeIncrement, out byte bFormatAsInt)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPropertyRange, "Engine.Settings.GetPropertyRange");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropertyId, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutMinValue);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutMinValue, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutMaxValue);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutMaxValue, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out RangeIncrement);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RangeIncrement, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out bFormatAsInt);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFormatAsInt, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutMinValue = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        OutMaxValue = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        RangeIncrement = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
        bFormatAsInt = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetPropertyMappingType;
    /// <summary>
    /// Function: GetPropertyMappingType
    /// </summary>
    public unsafe virtual bool GetPropertyMappingType(int PropertyId, out BmSDK.Engine.Settings.EPropertyValueMappingType OutType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPropertyMappingType, "Engine.Settings.GetPropertyMappingType");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropertyId, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutType);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutType, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutType = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Settings.EPropertyValueMappingType>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_HasStringSetting;
    /// <summary>
    /// Function: HasStringSetting
    /// </summary>
    public unsafe virtual bool HasStringSetting(int SettingId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasStringSetting, "Engine.Settings.HasStringSetting");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SettingId, paramsPtr + 0);
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

    private static BmSDK.Function __fn_HasProperty;
    /// <summary>
    /// Function: HasProperty
    /// </summary>
    public unsafe virtual bool HasProperty(int PropertyId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasProperty, "Engine.Settings.HasProperty");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropertyId, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UpdateProperties;
    /// <summary>
    /// Function: UpdateProperties
    /// </summary>
    public unsafe virtual void UpdateProperties(in BmSDK.TArray<BmSDK.Engine.Settings.FSettingsProperty> Props, bool bShouldAddIfMissing = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateProperties, "Engine.Settings.UpdateProperties");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Props, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldAddIfMissing, paramsPtr + 12);
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

    private static BmSDK.Function __fn_UpdateStringSettings;
    /// <summary>
    /// Function: UpdateStringSettings
    /// </summary>
    public unsafe virtual void UpdateStringSettings(in BmSDK.TArray<BmSDK.Engine.Settings.FLocalizedStringSetting> Settings, bool bShouldAddIfMissing = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateStringSettings, "Engine.Settings.UpdateStringSettings");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Settings, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldAddIfMissing, paramsPtr + 12);
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

    private static BmSDK.Function __fn_GetPropertyType;
    /// <summary>
    /// Function: GetPropertyType
    /// </summary>
    public unsafe virtual BmSDK.Engine.Settings.ESettingsDataType GetPropertyType(int PropertyId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPropertyType, "Engine.Settings.GetPropertyType");
        byte* paramsPtr = stackalloc byte[21];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropertyId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Settings.ESettingsDataType>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetPropertyValueId;
    /// <summary>
    /// Function: GetPropertyValueId
    /// </summary>
    public unsafe virtual bool GetPropertyValueId(int PropertyId, out int ValueId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPropertyValueId, "Engine.Settings.GetPropertyValueId");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropertyId, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ValueId);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ValueId, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ValueId = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetPropertyValueId;
    /// <summary>
    /// Function: SetPropertyValueId
    /// </summary>
    public unsafe virtual bool SetPropertyValueId(int PropertyId, int ValueId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPropertyValueId, "Engine.Settings.SetPropertyValueId");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropertyId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ValueId, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetStringProperty;
    /// <summary>
    /// Function: GetStringProperty
    /// </summary>
    public unsafe virtual bool GetStringProperty(int PropertyId, out BmSDK.FString Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStringProperty, "Engine.Settings.GetStringProperty");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropertyId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Value = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_SetStringProperty;
    /// <summary>
    /// Function: SetStringProperty
    /// </summary>
    public unsafe virtual void SetStringProperty(int PropertyId, BmSDK.FString Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetStringProperty, "Engine.Settings.SetStringProperty");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropertyId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetIntProperty;
    /// <summary>
    /// Function: GetIntProperty
    /// </summary>
    public unsafe virtual bool GetIntProperty(int PropertyId, out int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIntProperty, "Engine.Settings.GetIntProperty");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropertyId, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Value);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Value = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetIntProperty;
    /// <summary>
    /// Function: SetIntProperty
    /// </summary>
    public unsafe virtual void SetIntProperty(int PropertyId, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetIntProperty, "Engine.Settings.SetIntProperty");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropertyId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetFloatProperty;
    /// <summary>
    /// Function: GetFloatProperty
    /// </summary>
    public unsafe virtual bool GetFloatProperty(int PropertyId, out float Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFloatProperty, "Engine.Settings.GetFloatProperty");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropertyId, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Value);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Value = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetFloatProperty;
    /// <summary>
    /// Function: SetFloatProperty
    /// </summary>
    public unsafe virtual void SetFloatProperty(int PropertyId, float Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFloatProperty, "Engine.Settings.SetFloatProperty");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropertyId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SetPropertyFromStringByName;
    /// <summary>
    /// Function: SetPropertyFromStringByName
    /// </summary>
    public unsafe virtual bool SetPropertyFromStringByName(BmSDK.FName PropertyName, in BmSDK.FString NewValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPropertyFromStringByName, "Engine.Settings.SetPropertyFromStringByName");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropertyName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewValue, paramsPtr + 8);
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

    private static BmSDK.Function __fn_GetPropertyAsStringByName;
    /// <summary>
    /// Function: GetPropertyAsStringByName
    /// </summary>
    public unsafe virtual BmSDK.FString GetPropertyAsStringByName(BmSDK.FName PropertyName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPropertyAsStringByName, "Engine.Settings.GetPropertyAsStringByName");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropertyName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetPropertyAsString;
    /// <summary>
    /// Function: GetPropertyAsString
    /// </summary>
    public unsafe virtual BmSDK.FString GetPropertyAsString(int PropertyId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPropertyAsString, "Engine.Settings.GetPropertyAsString");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropertyId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetPropertyColumnHeader;
    /// <summary>
    /// Function: GetPropertyColumnHeader
    /// </summary>
    public unsafe virtual BmSDK.FString GetPropertyColumnHeader(int PropertyId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPropertyColumnHeader, "Engine.Settings.GetPropertyColumnHeader");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropertyId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetPropertyName;
    /// <summary>
    /// Function: GetPropertyName
    /// </summary>
    public unsafe virtual BmSDK.FName GetPropertyName(int PropertyId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPropertyName, "Engine.Settings.GetPropertyName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropertyId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetPropertyId;
    /// <summary>
    /// Function: GetPropertyId
    /// </summary>
    public unsafe virtual bool GetPropertyId(BmSDK.FName PropertyName, out int PropertyId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPropertyId, "Engine.Settings.GetPropertyId");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropertyName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyId);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropertyId, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PropertyId = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetStringSettingValueFromStringByName;
    /// <summary>
    /// Function: SetStringSettingValueFromStringByName
    /// </summary>
    public unsafe virtual bool SetStringSettingValueFromStringByName(BmSDK.FName StringSettingName, in BmSDK.FString NewValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetStringSettingValueFromStringByName, "Engine.Settings.SetStringSettingValueFromStringByName");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StringSettingName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewValue, paramsPtr + 8);
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

    private static BmSDK.Function __fn_GetStringSettingValueNameByName;
    /// <summary>
    /// Function: GetStringSettingValueNameByName
    /// </summary>
    public unsafe virtual BmSDK.FName GetStringSettingValueNameByName(BmSDK.FName StringSettingName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStringSettingValueNameByName, "Engine.Settings.GetStringSettingValueNameByName");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StringSettingName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetStringSettingValueName;
    /// <summary>
    /// Function: GetStringSettingValueName
    /// </summary>
    public unsafe virtual BmSDK.FName GetStringSettingValueName(int StringSettingId, int ValueIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStringSettingValueName, "Engine.Settings.GetStringSettingValueName");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StringSettingId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ValueIndex, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsWildcardStringSetting;
    /// <summary>
    /// Function: IsWildcardStringSetting
    /// </summary>
    public unsafe virtual bool IsWildcardStringSetting(int StringSettingId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsWildcardStringSetting, "Engine.Settings.IsWildcardStringSetting");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StringSettingId, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetStringSettingColumnHeader;
    /// <summary>
    /// Function: GetStringSettingColumnHeader
    /// </summary>
    public unsafe virtual BmSDK.FString GetStringSettingColumnHeader(int StringSettingId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStringSettingColumnHeader, "Engine.Settings.GetStringSettingColumnHeader");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StringSettingId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetStringSettingName;
    /// <summary>
    /// Function: GetStringSettingName
    /// </summary>
    public unsafe virtual BmSDK.FName GetStringSettingName(int StringSettingId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStringSettingName, "Engine.Settings.GetStringSettingName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StringSettingId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetStringSettingId;
    /// <summary>
    /// Function: GetStringSettingId
    /// </summary>
    public unsafe virtual bool GetStringSettingId(BmSDK.FName StringSettingName, out int StringSettingId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStringSettingId, "Engine.Settings.GetStringSettingId");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StringSettingName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StringSettingId);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StringSettingId, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        StringSettingId = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetStringSettingValueByName;
    /// <summary>
    /// Function: GetStringSettingValueByName
    /// </summary>
    public unsafe virtual bool GetStringSettingValueByName(BmSDK.FName StringSettingName, out int ValueIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStringSettingValueByName, "Engine.Settings.GetStringSettingValueByName");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StringSettingName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ValueIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ValueIndex, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ValueIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetStringSettingValueByName;
    /// <summary>
    /// Function: SetStringSettingValueByName
    /// </summary>
    public unsafe virtual void SetStringSettingValueByName(BmSDK.FName StringSettingName, int ValueIndex, bool bShouldAutoAdd)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetStringSettingValueByName, "Engine.Settings.SetStringSettingValueByName");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StringSettingName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ValueIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldAutoAdd, paramsPtr + 12);
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

    private static BmSDK.Function __fn_GetStringSettingValueNames;
    /// <summary>
    /// Function: GetStringSettingValueNames
    /// </summary>
    public unsafe virtual bool GetStringSettingValueNames(int StringSettingId, out BmSDK.TArray<BmSDK.Engine.Settings.FIdToStringMapping> Values)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStringSettingValueNames, "Engine.Settings.GetStringSettingValueNames");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StringSettingId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Values = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Settings.FIdToStringMapping>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_IncrementStringSettingValue;
    /// <summary>
    /// Function: IncrementStringSettingValue
    /// </summary>
    public unsafe virtual bool IncrementStringSettingValue(int StringSettingId, int Direction, bool bShouldWrap)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncrementStringSettingValue, "Engine.Settings.IncrementStringSettingValue");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StringSettingId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldWrap, paramsPtr + 8);
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

    private static BmSDK.Function __fn_GetStringSettingValue;
    /// <summary>
    /// Function: GetStringSettingValue
    /// </summary>
    public unsafe virtual bool GetStringSettingValue(int StringSettingId, out int ValueIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStringSettingValue, "Engine.Settings.GetStringSettingValue");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StringSettingId, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ValueIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ValueIndex, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ValueIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetStringSettingValue;
    /// <summary>
    /// Function: SetStringSettingValue
    /// </summary>
    public unsafe virtual void SetStringSettingValue(int StringSettingId, int ValueIndex, bool bShouldAutoAdd = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetStringSettingValue, "Engine.Settings.SetStringSettingValue");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StringSettingId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ValueIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldAutoAdd, paramsPtr + 8);
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

    private static BmSDK.Function __fn_GetSettingsDataDateTime;
    /// <summary>
    /// Function: GetSettingsDataDateTime
    /// </summary>
    public unsafe static void GetSettingsDataDateTime(out BmSDK.Engine.Settings.FSettingsData Data, out int OutInt1, out int OutInt2)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSettingsDataDateTime, "Engine.Settings.GetSettingsDataDateTime");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Data);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutInt1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutInt1, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutInt2);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutInt2, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Data = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Settings.FSettingsData>(paramsPtr + 0);
        OutInt1 = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
        OutInt2 = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_GetSettingsDataBlob;
    /// <summary>
    /// Function: GetSettingsDataBlob
    /// </summary>
    public unsafe static void GetSettingsDataBlob(out BmSDK.Engine.Settings.FSettingsData Data, out BmSDK.TArray<byte> OutBlob)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSettingsDataBlob, "Engine.Settings.GetSettingsDataBlob");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Data);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Data = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Settings.FSettingsData>(paramsPtr + 0);
        OutBlob = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetSettingsDataInt;
    /// <summary>
    /// Function: GetSettingsDataInt
    /// </summary>
    public unsafe static int GetSettingsDataInt(out BmSDK.Engine.Settings.FSettingsData Data)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSettingsDataInt, "Engine.Settings.GetSettingsDataInt");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Data);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Data = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Settings.FSettingsData>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetSettingsDataFloat;
    /// <summary>
    /// Function: GetSettingsDataFloat
    /// </summary>
    public unsafe static float GetSettingsDataFloat(out BmSDK.Engine.Settings.FSettingsData Data)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSettingsDataFloat, "Engine.Settings.GetSettingsDataFloat");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Data);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Data = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Settings.FSettingsData>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetSettingsDataString;
    /// <summary>
    /// Function: GetSettingsDataString
    /// </summary>
    public unsafe static BmSDK.FString GetSettingsDataString(out BmSDK.Engine.Settings.FSettingsData Data)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSettingsDataString, "Engine.Settings.GetSettingsDataString");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Data);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Data = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Settings.FSettingsData>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_EmptySettingsData;
    /// <summary>
    /// Function: EmptySettingsData
    /// </summary>
    public unsafe static void EmptySettingsData(out BmSDK.Engine.Settings.FSettingsData Data)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EmptySettingsData, "Engine.Settings.EmptySettingsData");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Data);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Data = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Settings.FSettingsData>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetSettingsData;
    /// <summary>
    /// Function: SetSettingsData
    /// </summary>
    public unsafe static void SetSettingsData(out BmSDK.Engine.Settings.FSettingsData Data, out BmSDK.Engine.Settings.FSettingsData Data2Copy)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSettingsData, "Engine.Settings.SetSettingsData");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Data);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Data2Copy);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data2Copy, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Data = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Settings.FSettingsData>(paramsPtr + 0);
        Data2Copy = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Settings.FSettingsData>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_SetSettingsDataBlob;
    /// <summary>
    /// Function: SetSettingsDataBlob
    /// </summary>
    public unsafe static void SetSettingsDataBlob(out BmSDK.Engine.Settings.FSettingsData Data, out BmSDK.TArray<byte> InBlob)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSettingsDataBlob, "Engine.Settings.SetSettingsDataBlob");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Data);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Data = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Settings.FSettingsData>(paramsPtr + 0);
        InBlob = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_SetSettingsDataDateTime;
    /// <summary>
    /// Function: SetSettingsDataDateTime
    /// </summary>
    public unsafe static void SetSettingsDataDateTime(out BmSDK.Engine.Settings.FSettingsData Data, int InInt1, int InInt2)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSettingsDataDateTime, "Engine.Settings.SetSettingsDataDateTime");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Data);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInt1, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInt2, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Data = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Settings.FSettingsData>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetSettingsDataInt;
    /// <summary>
    /// Function: SetSettingsDataInt
    /// </summary>
    public unsafe static void SetSettingsDataInt(out BmSDK.Engine.Settings.FSettingsData Data, int InInt)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSettingsDataInt, "Engine.Settings.SetSettingsDataInt");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Data);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInt, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Data = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Settings.FSettingsData>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetSettingsDataFloat;
    /// <summary>
    /// Function: SetSettingsDataFloat
    /// </summary>
    public unsafe static void SetSettingsDataFloat(out BmSDK.Engine.Settings.FSettingsData Data, float InFloat)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSettingsDataFloat, "Engine.Settings.SetSettingsDataFloat");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Data);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InFloat, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Data = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Settings.FSettingsData>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetSettingsDataString;
    /// <summary>
    /// Function: SetSettingsDataString
    /// </summary>
    public unsafe static void SetSettingsDataString(out BmSDK.Engine.Settings.FSettingsData Data, BmSDK.FString InString)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSettingsDataString, "Engine.Settings.SetSettingsDataString");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Data);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InString, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Data = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Settings.FSettingsData>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// ArrayProperty: LocalizedSettings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Settings.FLocalizedStringSetting> LocalizedSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Settings.FLocalizedStringSetting>>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// ArrayProperty: Properties
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Settings.FSettingsProperty> Properties
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Settings.FSettingsProperty>>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// ArrayProperty: LocalizedSettingsMappings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Settings.FLocalizedStringSettingMetaData> LocalizedSettingsMappings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Settings.FLocalizedStringSettingMetaData>>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// ArrayProperty: PropertyMappings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Settings.FSettingsPropertyPropertyMetaData> PropertyMappings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Settings.FSettingsPropertyPropertyMetaData>>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// Struct: FSettingsPropertyPropertyMetaData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial record struct FSettingsPropertyPropertyMetaData
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
        /// NameProperty: Name
        /// </summary>
        public unsafe BmSDK.FName Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StrProperty: ColumnHeaderText
        /// </summary>
        public unsafe BmSDK.FString ColumnHeaderText
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ByteProperty: MappingType
        /// </summary>
        public unsafe BmSDK.Engine.Settings.EPropertyValueMappingType MappingType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Settings.EPropertyValueMappingType>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ArrayProperty: ValueMappings
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.Settings.FIdToStringMapping> ValueMappings
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Settings.FIdToStringMapping>>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// ArrayProperty: PredefinedValues
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.Settings.FSettingsData> PredefinedValues
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Settings.FSettingsData>>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// FloatProperty: MinVal
        /// </summary>
        public unsafe float MinVal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// FloatProperty: MaxVal
        /// </summary>
        public unsafe float MaxVal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// FloatProperty: RangeIncrement
        /// </summary>
        public unsafe float RangeIncrement
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }
    }

    /// <summary>
    /// Enum: EPropertyValueMappingType
    /// </summary>
    public enum EPropertyValueMappingType : byte
    {
        PVMT_RawValue = 0,
        PVMT_PredefinedValues = 1,
        PVMT_Ranged = 2,
        PVMT_IdMapped = 3,
        PVMT_MAX = 4,
    }

    /// <summary>
    /// Struct: FIdToStringMapping
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FIdToStringMapping
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
        /// NameProperty: Name
        /// </summary>
        public unsafe BmSDK.FName Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FLocalizedStringSettingMetaData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FLocalizedStringSettingMetaData
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
        /// NameProperty: Name
        /// </summary>
        public unsafe BmSDK.FName Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StrProperty: ColumnHeaderText
        /// </summary>
        public unsafe BmSDK.FString ColumnHeaderText
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ArrayProperty: ValueMappings
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.Settings.FStringIdToStringMapping> ValueMappings
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Settings.FStringIdToStringMapping>>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FStringIdToStringMapping
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FStringIdToStringMapping
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
        /// NameProperty: Name
        /// </summary>
        public unsafe BmSDK.FName Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bIsWildcard
        /// </summary>
        public unsafe bool bIsWildcard
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FSettingsProperty
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FSettingsProperty
    {
        /// <summary>
        /// IntProperty: PropertyId
        /// </summary>
        public unsafe int PropertyId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.Engine.Settings.FSettingsData Data
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Settings.FSettingsData>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ByteProperty: AdvertisementType
        /// </summary>
        public unsafe BmSDK.Engine.Settings.EOnlineDataAdvertisementType AdvertisementType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Settings.EOnlineDataAdvertisementType>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FSettingsData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FSettingsData
    {
        /// <summary>
        /// ByteProperty: Type
        /// </summary>
        public unsafe BmSDK.Engine.Settings.ESettingsDataType Type
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Settings.ESettingsDataType>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Value1
        /// </summary>
        public unsafe int Value1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: Value2
        /// </summary>
        public unsafe System.IntPtr Value2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: ESettingsDataType
    /// </summary>
    public enum ESettingsDataType : byte
    {
        SDT_Empty = 0,
        SDT_Int32 = 1,
        SDT_Int64 = 2,
        SDT_Double = 3,
        SDT_String = 4,
        SDT_Float = 5,
        SDT_Blob = 6,
        SDT_DateTime = 7,
        SDT_MAX = 8,
    }

    /// <summary>
    /// Struct: FLocalizedStringSetting
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FLocalizedStringSetting
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
        /// IntProperty: ValueIndex
        /// </summary>
        public unsafe int ValueIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ByteProperty: AdvertisementType
        /// </summary>
        public unsafe BmSDK.Engine.Settings.EOnlineDataAdvertisementType AdvertisementType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Settings.EOnlineDataAdvertisementType>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: EOnlineDataAdvertisementType
    /// </summary>
    public enum EOnlineDataAdvertisementType : byte
    {
        ODAT_DontAdvertise = 0,
        ODAT_OnlineService = 1,
        ODAT_QoS = 2,
        ODAT_OnlineServiceAndQoS = 3,
        ODAT_MAX = 4,
    }
}

/// <summary>
/// The static native functions of Settings, callable on an instance. A static native may read the object it runs on, and the static form runs it on the class default object, which has no world.
/// </summary>
public static class SettingsStatics
{
    private static BmSDK.Function __fn_GetSettingsDataDateTime;
    /// <summary>
    /// Function: GetSettingsDataDateTime, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void GetSettingsDataDateTime(this BmSDK.Engine.Settings self, out BmSDK.Engine.Settings.FSettingsData Data, out int OutInt1, out int OutInt2)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSettingsDataDateTime, "Engine.Settings.GetSettingsDataDateTime");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Data);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutInt1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutInt1, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutInt2);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutInt2, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Data = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Settings.FSettingsData>(paramsPtr + 0);
        OutInt1 = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
        OutInt2 = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_GetSettingsDataBlob;
    /// <summary>
    /// Function: GetSettingsDataBlob, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void GetSettingsDataBlob(this BmSDK.Engine.Settings self, out BmSDK.Engine.Settings.FSettingsData Data, out BmSDK.TArray<byte> OutBlob)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSettingsDataBlob, "Engine.Settings.GetSettingsDataBlob");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Data);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Data = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Settings.FSettingsData>(paramsPtr + 0);
        OutBlob = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetSettingsDataInt;
    /// <summary>
    /// Function: GetSettingsDataInt, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static int GetSettingsDataInt(this BmSDK.Engine.Settings self, out BmSDK.Engine.Settings.FSettingsData Data)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSettingsDataInt, "Engine.Settings.GetSettingsDataInt");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Data);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Data = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Settings.FSettingsData>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetSettingsDataFloat;
    /// <summary>
    /// Function: GetSettingsDataFloat, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static float GetSettingsDataFloat(this BmSDK.Engine.Settings self, out BmSDK.Engine.Settings.FSettingsData Data)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSettingsDataFloat, "Engine.Settings.GetSettingsDataFloat");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Data);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Data = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Settings.FSettingsData>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetSettingsDataString;
    /// <summary>
    /// Function: GetSettingsDataString, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static BmSDK.FString GetSettingsDataString(this BmSDK.Engine.Settings self, out BmSDK.Engine.Settings.FSettingsData Data)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSettingsDataString, "Engine.Settings.GetSettingsDataString");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Data);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Data = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Settings.FSettingsData>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_EmptySettingsData;
    /// <summary>
    /// Function: EmptySettingsData, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void EmptySettingsData(this BmSDK.Engine.Settings self, out BmSDK.Engine.Settings.FSettingsData Data)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EmptySettingsData, "Engine.Settings.EmptySettingsData");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Data);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Data = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Settings.FSettingsData>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetSettingsData;
    /// <summary>
    /// Function: SetSettingsData, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void SetSettingsData(this BmSDK.Engine.Settings self, out BmSDK.Engine.Settings.FSettingsData Data, out BmSDK.Engine.Settings.FSettingsData Data2Copy)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSettingsData, "Engine.Settings.SetSettingsData");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Data);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Data2Copy);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data2Copy, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Data = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Settings.FSettingsData>(paramsPtr + 0);
        Data2Copy = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Settings.FSettingsData>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_SetSettingsDataBlob;
    /// <summary>
    /// Function: SetSettingsDataBlob, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void SetSettingsDataBlob(this BmSDK.Engine.Settings self, out BmSDK.Engine.Settings.FSettingsData Data, out BmSDK.TArray<byte> InBlob)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSettingsDataBlob, "Engine.Settings.SetSettingsDataBlob");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Data);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Data = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Settings.FSettingsData>(paramsPtr + 0);
        InBlob = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<byte>>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_SetSettingsDataDateTime;
    /// <summary>
    /// Function: SetSettingsDataDateTime, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void SetSettingsDataDateTime(this BmSDK.Engine.Settings self, out BmSDK.Engine.Settings.FSettingsData Data, int InInt1, int InInt2)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSettingsDataDateTime, "Engine.Settings.SetSettingsDataDateTime");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Data);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInt1, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInt2, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Data = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Settings.FSettingsData>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetSettingsDataInt;
    /// <summary>
    /// Function: SetSettingsDataInt, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void SetSettingsDataInt(this BmSDK.Engine.Settings self, out BmSDK.Engine.Settings.FSettingsData Data, int InInt)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSettingsDataInt, "Engine.Settings.SetSettingsDataInt");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Data);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInt, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Data = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Settings.FSettingsData>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetSettingsDataFloat;
    /// <summary>
    /// Function: SetSettingsDataFloat, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void SetSettingsDataFloat(this BmSDK.Engine.Settings self, out BmSDK.Engine.Settings.FSettingsData Data, float InFloat)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSettingsDataFloat, "Engine.Settings.SetSettingsDataFloat");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Data);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InFloat, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Data = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Settings.FSettingsData>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetSettingsDataString;
    /// <summary>
    /// Function: SetSettingsDataString, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void SetSettingsDataString(this BmSDK.Engine.Settings self, out BmSDK.Engine.Settings.FSettingsData Data, BmSDK.FString InString)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSettingsDataString, "Engine.Settings.SetSettingsDataString");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Data);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InString, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Data = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Settings.FSettingsData>(paramsPtr + 0);
        return;
    }
}
