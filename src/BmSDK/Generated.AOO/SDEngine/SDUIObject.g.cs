#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.SDEngine;

/// <summary>
/// Class: SDUIObject<br/>
/// (size = 108)
/// (flags = 32786)
/// </summary>
public partial class SDUIObject : BmSDK.GFxUI.GFxObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "SDEngine.SDUIObject", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as SDUIObject.
    /// </summary>
    public static SDUIObject DefaultObject => (SDUIObject)StaticClass().DefaultObject;

    internal SDUIObject() { }

    /// <summary>
    /// Constructs a new SDUIObject
    /// </summary>
    public SDUIObject(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SDUIObject Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SDUIObject(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDUIObject>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDUIObject>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDUIObject>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDUIObject>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDUIObject>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDUIObject>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDUIObject>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDUIObject>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_FormatTimeHHMMSS;
    /// <summary>
    /// Function: FormatTimeHHMMSS
    /// </summary>
    public unsafe static BmSDK.FString FormatTimeHHMMSS(int inTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FormatTimeHHMMSS, "SDEngine.SDUIObject.FormatTimeHHMMSS");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_FormatTimeMMSS;
    /// <summary>
    /// Function: FormatTimeMMSS
    /// </summary>
    public unsafe static BmSDK.FString FormatTimeMMSS(int inTime)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FormatTimeMMSS, "SDEngine.SDUIObject.FormatTimeMMSS");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetXScaleDisplayInfo;
    /// <summary>
    /// Function: SetXScaleDisplayInfo
    /// </summary>
    public unsafe static void SetXScaleDisplayInfo(out BmSDK.GFxUI.GFxObject.FASDisplayInfo DispInfo, float XScaleValue)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetXScaleDisplayInfo, "SDEngine.SDUIObject.SetXScaleDisplayInfo");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DispInfo);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DispInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XScaleValue, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DispInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject.FASDisplayInfo>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_PopulateColorTransformWithColor;
    /// <summary>
    /// Function: PopulateColorTransformWithColor
    /// </summary>
    public unsafe static void PopulateColorTransformWithColor(out BmSDK.GFxUI.GFxObject.FASColorTransform ColourTrans, BmSDK.GameObject.FColor ColourData)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulateColorTransformWithColor, "SDEngine.SDUIObject.PopulateColorTransformWithColor");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ColourTrans);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ColourTrans, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ColourData, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ColourTrans = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject.FASColorTransform>(paramsPtr + 0);
        return;
    }
}
