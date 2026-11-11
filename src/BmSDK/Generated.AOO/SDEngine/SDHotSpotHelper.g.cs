#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.SDEngine;

/// <summary>
/// Class: SDHotSpotHelper<br/>
/// (size = 120)
/// (flags = 32786)
/// </summary>
public partial class SDHotSpotHelper : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "SDEngine.SDHotSpotHelper", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as SDHotSpotHelper.
    /// </summary>
    public static SDHotSpotHelper DefaultObject => (SDHotSpotHelper)StaticClass().DefaultObject;

    internal SDHotSpotHelper() { }

    /// <summary>
    /// Constructs a new SDHotSpotHelper
    /// </summary>
    public SDHotSpotHelper(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SDHotSpotHelper Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SDHotSpotHelper(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDHotSpotHelper>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDHotSpotHelper>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDHotSpotHelper>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDHotSpotHelper>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDHotSpotHelper>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDHotSpotHelper>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDHotSpotHelper>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDHotSpotHelper>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CreateRotationDocument;
    /// <summary>
    /// Function: CreateRotationDocument
    /// </summary>
    public unsafe static BmSDK.SDEngine.SDJsonObject CreateRotationDocument(BmSDK.Rotator Rotation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateRotationDocument, "SDEngine.SDHotSpotHelper.CreateRotationDocument");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rotation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.SDEngine.SDJsonObject>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetRotation;
    /// <summary>
    /// Function: GetRotation
    /// </summary>
    public unsafe static BmSDK.Rotator GetRotation(BmSDK.SDEngine.SDJsonObject Obj)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRotation, "SDEngine.SDHotSpotHelper.GetRotation");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Obj, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CreateLocationDocument;
    /// <summary>
    /// Function: CreateLocationDocument
    /// </summary>
    public unsafe static BmSDK.SDEngine.SDJsonObject CreateLocationDocument(System.Numerics.Vector3 Location)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateLocationDocument, "SDEngine.SDHotSpotHelper.CreateLocationDocument");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Location, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.SDEngine.SDJsonObject>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetLocation;
    /// <summary>
    /// Function: GetLocation
    /// </summary>
    public unsafe static System.Numerics.Vector3 GetLocation(BmSDK.SDEngine.SDJsonObject Obj)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocation, "SDEngine.SDHotSpotHelper.GetLocation");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Obj, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HotSpotUpdated;
    /// <summary>
    /// Function: HotSpotUpdated
    /// </summary>
    public unsafe void HotSpotUpdated(BmSDK.SDEngine.SDHttpRequest Request, BmSDK.FString Result)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HotSpotUpdated, "SDEngine.SDHotSpotHelper.HotSpotUpdated");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Request, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Result, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeleteHotSpot;
    /// <summary>
    /// Function: DeleteHotSpot
    /// </summary>
    public unsafe virtual bool DeleteHotSpot(BmSDK.SDEngine.SDJsonObject IDObject, BmSDK.FString GameName, System.IntPtr Callback)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeleteHotSpot, "SDEngine.SDHotSpotHelper.DeleteHotSpot");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IDObject, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GameName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Callback, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_UpdateHotspot;
    /// <summary>
    /// Function: UpdateHotspot
    /// </summary>
    public unsafe virtual bool UpdateHotspot(BmSDK.SDEngine.SDJsonObject IDObject, BmSDK.FString GameName, System.Numerics.Vector3 Location, BmSDK.Rotator Rotation, System.IntPtr Callback)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateHotspot, "SDEngine.SDHotSpotHelper.UpdateHotspot");
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IDObject, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GameName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Location, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rotation, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Callback, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 52);
    }

    private static BmSDK.Function __fn_HotSpotAdded;
    /// <summary>
    /// Function: HotSpotAdded
    /// </summary>
    public unsafe void HotSpotAdded(BmSDK.SDEngine.SDHttpRequest Request, BmSDK.FString Result)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HotSpotAdded, "SDEngine.SDHotSpotHelper.HotSpotAdded");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Request, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Result, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddHotSpot;
    /// <summary>
    /// Function: AddHotSpot
    /// </summary>
    public unsafe virtual bool AddHotSpot(BmSDK.FString MapNameString, BmSDK.FString GameName, BmSDK.FString UserName, System.Numerics.Vector3 Location, BmSDK.Rotator Rotation, System.IntPtr Callback, bool Ghosting, BmSDK.FString CharName = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddHotSpot, "SDEngine.SDHotSpotHelper.AddHotSpot");
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapNameString, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GameName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserName, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Location, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rotation, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Callback, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Ghosting, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharName, paramsPtr + 76);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 88);
    }

    private static BmSDK.Function __fn_CreateHotSpotDocument;
    /// <summary>
    /// Function: CreateHotSpotDocument
    /// </summary>
    public unsafe static BmSDK.SDEngine.SDJsonObject CreateHotSpotDocument(BmSDK.FString MapNameString, BmSDK.FString UserName, System.Numerics.Vector3 Location, BmSDK.Rotator Rotation, bool Ghosting, BmSDK.FString CharName = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateHotSpotDocument, "SDEngine.SDHotSpotHelper.CreateHotSpotDocument");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapNameString, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Location, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rotation, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Ghosting, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharName, paramsPtr + 52);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.SDEngine.SDJsonObject>(paramsPtr + 64);
    }

    private static BmSDK.Function __fn_TravelPointsFound;
    /// <summary>
    /// Function: TravelPointsFound
    /// </summary>
    public unsafe void TravelPointsFound(BmSDK.SDEngine.SDHttpRequest Request, BmSDK.FString Result)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TravelPointsFound, "SDEngine.SDHotSpotHelper.TravelPointsFound");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Request, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Result, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHotSpots;
    /// <summary>
    /// Function: GetHotSpots
    /// </summary>
    public unsafe virtual bool GetHotSpots(BmSDK.FString MapNameString, BmSDK.FString GameName, System.IntPtr Callback)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHotSpots, "SDEngine.SDHotSpotHelper.GetHotSpots");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapNameString, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GameName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Callback, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_SetField;
    /// <summary>
    /// Function: SetField
    /// </summary>
    public unsafe void SetField(BmSDK.FString Field, BmSDK.SDEngine.SDJsonObject Amount, BmSDK.SDEngine.SDJsonObject UpdateDocument)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetField, "SDEngine.SDHotSpotHelper.SetField");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Field, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Amount, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdateDocument, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IncrementField;
    /// <summary>
    /// Function: IncrementField
    /// </summary>
    public unsafe void IncrementField(BmSDK.FString Field, int Amount, BmSDK.SDEngine.SDJsonObject UpdateDocument)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncrementField, "SDEngine.SDHotSpotHelper.IncrementField");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Field, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Amount, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdateDocument, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckFieldExists;
    /// <summary>
    /// Function: CheckFieldExists
    /// </summary>
    public unsafe void CheckFieldExists(BmSDK.FString Field, BmSDK.SDEngine.SDJsonObject QueryDocument)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckFieldExists, "SDEngine.SDHotSpotHelper.CheckFieldExists");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Field, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QueryDocument, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotRunID;
    /// <summary>
    /// Function: GotRunID
    /// </summary>
    public unsafe void GotRunID(BmSDK.SDEngine.SDHttpRequest Request, BmSDK.FString Result)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotRunID, "SDEngine.SDHotSpotHelper.GotRunID");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Request, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Result, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsGettingRunId;
    /// <summary>
    /// Function: IsGettingRunId
    /// </summary>
    public unsafe virtual bool IsGettingRunId()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsGettingRunId, "SDEngine.SDHotSpotHelper.IsGettingRunId");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAndIncrementRunID;
    /// <summary>
    /// Function: GetAndIncrementRunID
    /// </summary>
    public unsafe virtual bool GetAndIncrementRunID(System.IntPtr Callback)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAndIncrementRunID, "SDEngine.SDHotSpotHelper.GetAndIncrementRunID");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Callback, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_AddHotSpotCompleteDelegate;
    /// <summary>
    /// Function: AddHotSpotCompleteDelegate
    /// </summary>
    public unsafe virtual void AddHotSpotCompleteDelegate(BmSDK.SDEngine.SDJsonObject AddedHotSpot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddHotSpotCompleteDelegate, "SDEngine.SDHotSpotHelper.AddHotSpotCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AddedHotSpot, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHotSpotsCompleteDelegate;
    /// <summary>
    /// Function: GetHotSpotsCompleteDelegate
    /// </summary>
    public unsafe virtual void GetHotSpotsCompleteDelegate(BmSDK.SDEngine.SDJsonArray HotSpots)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHotSpotsCompleteDelegate, "SDEngine.SDHotSpotHelper.GetHotSpotsCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HotSpots, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRunIDCompleteDelegate;
    /// <summary>
    /// Function: GetRunIDCompleteDelegate
    /// </summary>
    public unsafe virtual void GetRunIDCompleteDelegate(int RunID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRunIDCompleteDelegate, "SDEngine.SDHotSpotHelper.GetRunIDCompleteDelegate");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RunID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// DelegateProperty: RunIDCallback
    /// </summary>
    public unsafe System.IntPtr RunIDCallback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// DelegateProperty: HotSpotsCallback
    /// </summary>
    public unsafe System.IntPtr HotSpotsCallback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// DelegateProperty: AddHotSpotCallback
    /// </summary>
    public unsafe System.IntPtr AddHotSpotCallback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }

    /// <summary>
    /// DelegateProperty: __GetRunIDCompleteDelegate__Delegate
    /// </summary>
    public unsafe System.IntPtr __GetRunIDCompleteDelegate__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// DelegateProperty: __GetHotSpotsCompleteDelegate__Delegate
    /// </summary>
    public unsafe System.IntPtr __GetHotSpotsCompleteDelegate__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// DelegateProperty: __AddHotSpotCompleteDelegate__Delegate
    /// </summary>
    public unsafe System.IntPtr __AddHotSpotCompleteDelegate__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }
}
