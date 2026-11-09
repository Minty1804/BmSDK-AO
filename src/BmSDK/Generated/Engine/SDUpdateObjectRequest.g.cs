#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SDUpdateObjectRequest<br/>
/// (size = 232)
/// (flags = 18)
/// </summary>
public partial class SDUpdateObjectRequest : BmSDK.Engine.SDProfileRequest, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SDUpdateObjectRequest", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as SDUpdateObjectRequest.
    /// </summary>
    public static SDUpdateObjectRequest DefaultObject => (SDUpdateObjectRequest)StaticClass().DefaultObject;

    internal SDUpdateObjectRequest() { }

    /// <summary>
    /// Constructs a new SDUpdateObjectRequest
    /// </summary>
    public SDUpdateObjectRequest(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SDUpdateObjectRequest Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SDUpdateObjectRequest(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDUpdateObjectRequest>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDUpdateObjectRequest>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDUpdateObjectRequest>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDUpdateObjectRequest>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDUpdateObjectRequest>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDUpdateObjectRequest>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDUpdateObjectRequest>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDUpdateObjectRequest>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetPatchObject;
    /// <summary>
    /// Function: GetPatchObject
    /// </summary>
    public unsafe virtual BmSDK.Engine.SDJsonObject GetPatchObject(BmSDK.Engine.SDJsonObject Fields)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPatchObject, "Engine.SDUpdateObjectRequest.GetPatchObject");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Fields, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.SDJsonObject>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OnObjectUpdated;
    /// <summary>
    /// Function: OnObjectUpdated
    /// </summary>
    public unsafe virtual void OnObjectUpdated(BmSDK.Engine.SDHttpRequest Request, BmSDK.FString Data)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnObjectUpdated, "Engine.SDUpdateObjectRequest.OnObjectUpdated");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Request, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetExternalUserParameters;
    /// <summary>
    /// Function: SetExternalUserParameters
    /// </summary>
    public unsafe virtual void SetExternalUserParameters(BmSDK.FString FireteamId, BmSDK.FString NewObjectType, BmSDK.Engine.SDFireteamObject Data, bool bExtended = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetExternalUserParameters, "Engine.SDUpdateObjectRequest.SetExternalUserParameters");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireteamId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewObjectType, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bExtended, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetUserParameters;
    /// <summary>
    /// Function: SetUserParameters
    /// </summary>
    public unsafe virtual void SetUserParameters(int LocalUserNum, BmSDK.FString NewObjectType, BmSDK.Engine.SDFireteamObject Data, bool bExtended = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetUserParameters, "Engine.SDUpdateObjectRequest.SetUserParameters");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewObjectType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bExtended, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetParameters;
    /// <summary>
    /// Function: SetParameters
    /// </summary>
    public unsafe virtual void SetParameters(BmSDK.FString NewObjectType, BmSDK.FString ObjectId, BmSDK.Engine.SDFireteamObject Data)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetParameters, "Engine.SDUpdateObjectRequest.SetParameters");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewObjectType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectId, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Initialise;
    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe override void Initialise()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialise, "Engine.SDUpdateObjectRequest.Initialise");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ObjectUpdatedDelegate;
    /// <summary>
    /// Function: ObjectUpdatedDelegate
    /// </summary>
    public unsafe virtual void ObjectUpdatedDelegate(BmSDK.FString NewObjectType, BmSDK.Engine.SDFireteamObject ObjectReplaced, bool bSucceeded)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ObjectUpdatedDelegate, "Engine.SDUpdateObjectRequest.ObjectUpdatedDelegate");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewObjectType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectReplaced, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSucceeded, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: Prototype
    /// </summary>
    public unsafe BmSDK.Engine.SDFireteamObject Prototype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SDFireteamObject>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// StrProperty: ObjectType
    /// </summary>
    public unsafe BmSDK.FString ObjectType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// DelegateProperty: __ObjectUpdatedDelegate__Delegate
    /// </summary>
    public unsafe System.IntPtr __ObjectUpdatedDelegate__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }
}
