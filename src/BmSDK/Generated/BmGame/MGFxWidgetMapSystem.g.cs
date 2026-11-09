#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MGFxWidgetMapSystem<br/>
/// (size = 804)
/// (flags = 134217878)
/// </summary>
public partial class MGFxWidgetMapSystem : BmSDK.BmGame.MGFxWidget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MGFxWidgetMapSystem", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MGFxWidgetMapSystem.
    /// </summary>
    public static MGFxWidgetMapSystem DefaultObject => (MGFxWidgetMapSystem)StaticClass().DefaultObject;

    internal MGFxWidgetMapSystem() { }

    /// <summary>
    /// Constructs a new MGFxWidgetMapSystem
    /// </summary>
    public MGFxWidgetMapSystem(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MGFxWidgetMapSystem Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MGFxWidgetMapSystem(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetMapSystem>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetMapSystem>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetMapSystem>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetMapSystem>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetMapSystem>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetMapSystem>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetMapSystem>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MGFxWidgetMapSystem>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_Terminate;
    /// <summary>
    /// Function: Terminate
    /// </summary>
    public unsafe virtual void Terminate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Terminate, "BmGame.MGFxWidgetMapSystem.Terminate");
        byte* paramsPtr = stackalloc byte[33];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BuildRoomVisibiltyFlag;
    /// <summary>
    /// Function: BuildRoomVisibiltyFlag
    /// </summary>
    public unsafe virtual BmSDK.FString BuildRoomVisibiltyFlag(BmSDK.FString roomVisibilityName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuildRoomVisibiltyFlag, "BmGame.MGFxWidgetMapSystem.BuildRoomVisibiltyFlag");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(roomVisibilityName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ShowYouAreHereIcon;
    /// <summary>
    /// Function: ShowYouAreHereIcon
    /// </summary>
    public unsafe virtual void ShowYouAreHereIcon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowYouAreHereIcon, "BmGame.MGFxWidgetMapSystem.ShowYouAreHereIcon");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGlobalFlag;
    /// <summary>
    /// Function: GetGlobalFlag
    /// </summary>
    public unsafe virtual bool GetGlobalFlag(BmSDK.FString checkGlobalFlagName, BmSDK.FString iconType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGlobalFlag, "BmGame.MGFxWidgetMapSystem.GetGlobalFlag");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(checkGlobalFlagName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iconType, paramsPtr + 12);
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

    private static BmSDK.Function __fn_PlaceSingleIcon;
    /// <summary>
    /// Function: PlaceSingleIcon
    /// </summary>
    public unsafe virtual void PlaceSingleIcon(int IconDataIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaceSingleIcon, "BmGame.MGFxWidgetMapSystem.PlaceSingleIcon");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconDataIndex, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ShowPacksForAllRooms;
    /// <summary>
    /// Function: ShowPacksForAllRooms
    /// </summary>
    public unsafe virtual void ShowPacksForAllRooms()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowPacksForAllRooms, "BmGame.MGFxWidgetMapSystem.ShowPacksForAllRooms");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowPacksForRoom;
    /// <summary>
    /// Function: ShowPacksForRoom
    /// </summary>
    public unsafe virtual void ShowPacksForRoom(BmSDK.FString nameOfRoom, int dataSetId = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowPacksForRoom, "BmGame.MGFxWidgetMapSystem.ShowPacksForRoom");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nameOfRoom, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dataSetId, paramsPtr + 12);
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

    private static BmSDK.Function __fn_ApplyEnigmaOverviewFilter;
    /// <summary>
    /// Function: ApplyEnigmaOverviewFilter
    /// </summary>
    public unsafe virtual void ApplyEnigmaOverviewFilter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyEnigmaOverviewFilter, "BmGame.MGFxWidgetMapSystem.ApplyEnigmaOverviewFilter");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTitleVisible;
    /// <summary>
    /// Function: SetTitleVisible
    /// </summary>
    public unsafe virtual void SetTitleVisible(bool Visible)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTitleVisible, "BmGame.MGFxWidgetMapSystem.SetTitleVisible");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Visible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnloadMostWanted;
    /// <summary>
    /// Function: UnloadMostWanted
    /// </summary>
    public unsafe virtual void UnloadMostWanted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnloadMostWanted, "BmGame.MGFxWidgetMapSystem.UnloadMostWanted");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadMostWanted;
    /// <summary>
    /// Function: LoadMostWanted
    /// </summary>
    public unsafe virtual void LoadMostWanted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadMostWanted, "BmGame.MGFxWidgetMapSystem.LoadMostWanted");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetMapIcons;
    /// <summary>
    /// Function: ResetMapIcons
    /// </summary>
    public unsafe virtual void ResetMapIcons()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetMapIcons, "BmGame.MGFxWidgetMapSystem.ResetMapIcons");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearMapIcons;
    /// <summary>
    /// Function: ClearMapIcons
    /// </summary>
    public unsafe virtual void ClearMapIcons()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearMapIcons, "BmGame.MGFxWidgetMapSystem.ClearMapIcons");
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

    private static BmSDK.Function __fn_ParseIconList;
    /// <summary>
    /// Function: ParseIconList
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MGFxWidgetMapSystem.FIconDataStruct ParseIconList(BmSDK.FString searchValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ParseIconList, "BmGame.MGFxWidgetMapSystem.ParseIconList");
        byte* paramsPtr = stackalloc byte[152];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(searchValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MGFxWidgetMapSystem.FIconDataStruct>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetCameraRotation;
    /// <summary>
    /// Function: GetCameraRotation
    /// </summary>
    public unsafe virtual float GetCameraRotation(int Axis)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCameraRotation, "BmGame.MGFxWidgetMapSystem.GetCameraRotation");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Axis, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetPlayerRotation;
    /// <summary>
    /// Function: GetPlayerRotation
    /// </summary>
    public unsafe virtual float GetPlayerRotation(int Axis)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerRotation, "BmGame.MGFxWidgetMapSystem.GetPlayerRotation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Axis, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetupASDelegateUpdateStickSound;
    /// <summary>
    /// Function: SetupASDelegateUpdateStickSound
    /// </summary>
    public unsafe virtual void SetupASDelegateUpdateStickSound(System.IntPtr D)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupASDelegateUpdateStickSound, "BmGame.MGFxWidgetMapSystem.SetupASDelegateUpdateStickSound");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(D, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupASDelegateDistrictChanged;
    /// <summary>
    /// Function: SetupASDelegateDistrictChanged
    /// </summary>
    public unsafe virtual void SetupASDelegateDistrictChanged(System.IntPtr D)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupASDelegateDistrictChanged, "BmGame.MGFxWidgetMapSystem.SetupASDelegateDistrictChanged");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(D, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupASDelegate;
    /// <summary>
    /// Function: SetupASDelegate
    /// </summary>
    public unsafe virtual void SetupASDelegate(System.IntPtr D)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupASDelegate, "BmGame.MGFxWidgetMapSystem.SetupASDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(D, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupMapFloors;
    /// <summary>
    /// Function: SetupMapFloors
    /// </summary>
    public unsafe virtual void SetupMapFloors()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupMapFloors, "BmGame.MGFxWidgetMapSystem.SetupMapFloors");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetFloorForRoom;
    /// <summary>
    /// Function: GetFloorForRoom
    /// </summary>
    public unsafe virtual int GetFloorForRoom(BmSDK.FString mapRoomName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFloorForRoom, "BmGame.MGFxWidgetMapSystem.GetFloorForRoom");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(mapRoomName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_IsMapIconOnCurrentFloor;
    /// <summary>
    /// Function: IsMapIconOnCurrentFloor
    /// </summary>
    public unsafe virtual bool IsMapIconOnCurrentFloor(BmSDK.FString testMapName, BmSDK.FString objectiveRoomName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsMapIconOnCurrentFloor, "BmGame.MGFxWidgetMapSystem.IsMapIconOnCurrentFloor");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(testMapName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(objectiveRoomName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_DisplayFloorMenuRoomName;
    /// <summary>
    /// Function: DisplayFloorMenuRoomName
    /// </summary>
    public unsafe virtual void DisplayFloorMenuRoomName(BmSDK.FString displayRoomName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayFloorMenuRoomName, "BmGame.MGFxWidgetMapSystem.DisplayFloorMenuRoomName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(displayRoomName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateFloorIndex;
    /// <summary>
    /// Function: UpdateFloorIndex
    /// </summary>
    public unsafe virtual void UpdateFloorIndex(int floorIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateFloorIndex, "BmGame.MGFxWidgetMapSystem.UpdateFloorIndex");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(floorIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GoToPlayerMap;
    /// <summary>
    /// Function: GoToPlayerMap
    /// </summary>
    public unsafe virtual void GoToPlayerMap()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GoToPlayerMap, "BmGame.MGFxWidgetMapSystem.GoToPlayerMap");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AS_CheckIconHit;
    /// <summary>
    /// Function: AS_CheckIconHit
    /// </summary>
    public unsafe virtual void AS_CheckIconHit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AS_CheckIconHit, "BmGame.MGFxWidgetMapSystem.AS_CheckIconHit");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AS_UserChangeFloor;
    /// <summary>
    /// Function: AS_UserChangeFloor
    /// </summary>
    public unsafe virtual void AS_UserChangeFloor(int newFloorIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AS_UserChangeFloor, "BmGame.MGFxWidgetMapSystem.AS_UserChangeFloor");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(newFloorIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AS_ResetSelectableMapItems;
    /// <summary>
    /// Function: AS_ResetSelectableMapItems
    /// </summary>
    public unsafe virtual void AS_ResetSelectableMapItems()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AS_ResetSelectableMapItems, "BmGame.MGFxWidgetMapSystem.AS_ResetSelectableMapItems");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UserChangeFloor;
    /// <summary>
    /// Function: UserChangeFloor
    /// </summary>
    public unsafe virtual void UserChangeFloor(int newFloorIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UserChangeFloor, "BmGame.MGFxWidgetMapSystem.UserChangeFloor");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(newFloorIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChangeFloor;
    /// <summary>
    /// Function: ChangeFloor
    /// </summary>
    public unsafe virtual void ChangeFloor(int Direction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeFloor, "BmGame.MGFxWidgetMapSystem.ChangeFloor");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChangeMap;
    /// <summary>
    /// Function: ChangeMap
    /// </summary>
    public unsafe virtual void ChangeMap(BmSDK.FString changeMapName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeMap, "BmGame.MGFxWidgetMapSystem.ChangeMap");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(changeMapName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadMapCall;
    /// <summary>
    /// Function: LoadMapCall
    /// </summary>
    public unsafe virtual void LoadMapCall(BmSDK.FString mapFilePath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadMapCall, "BmGame.MGFxWidgetMapSystem.LoadMapCall");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(mapFilePath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopulateActiveObjectivesInMap;
    /// <summary>
    /// Function: PopulateActiveObjectivesInMap
    /// </summary>
    public unsafe virtual void PopulateActiveObjectivesInMap(BmSDK.FString viewMapName, out BmSDK.TArray<BmSDK.FString> ActiveObjectives)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulateActiveObjectivesInMap, "BmGame.MGFxWidgetMapSystem.PopulateActiveObjectivesInMap");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(viewMapName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ActiveObjectives = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_IsMapFloorObjectiveAvailable;
    /// <summary>
    /// Function: IsMapFloorObjectiveAvailable
    /// </summary>
    public unsafe virtual int IsMapFloorObjectiveAvailable(int floorIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsMapFloorObjectiveAvailable, "BmGame.MGFxWidgetMapSystem.IsMapFloorObjectiveAvailable");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(floorIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsMapFloorAvailable;
    /// <summary>
    /// Function: IsMapFloorAvailable
    /// </summary>
    public unsafe virtual int IsMapFloorAvailable(int floorIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsMapFloorAvailable, "BmGame.MGFxWidgetMapSystem.IsMapFloorAvailable");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(floorIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_LoadMap;
    /// <summary>
    /// Function: LoadMap
    /// </summary>
    public unsafe virtual void LoadMap(BmSDK.FString loadMapName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadMap, "BmGame.MGFxWidgetMapSystem.LoadMap");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(loadMapName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsViewingOpenWorldMap;
    /// <summary>
    /// Function: IsViewingOpenWorldMap
    /// </summary>
    public unsafe virtual bool IsViewingOpenWorldMap()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsViewingOpenWorldMap, "BmGame.MGFxWidgetMapSystem.IsViewingOpenWorldMap");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CorrectRoomName;
    /// <summary>
    /// Function: CorrectRoomName
    /// </summary>
    public unsafe virtual void CorrectRoomName(out BmSDK.FString nameToFix)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CorrectRoomName, "BmGame.MGFxWidgetMapSystem.CorrectRoomName");
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
        nameToFix = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_PanToRoom;
    /// <summary>
    /// Function: PanToRoom
    /// </summary>
    public unsafe virtual void PanToRoom(BmSDK.FString locName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PanToRoom, "BmGame.MGFxWidgetMapSystem.PanToRoom");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(locName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PanToAnchor;
    /// <summary>
    /// Function: PanToAnchor
    /// </summary>
    public unsafe virtual void PanToAnchor(BmSDK.FString DistrictName, bool bOnBatman = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PanToAnchor, "BmGame.MGFxWidgetMapSystem.PanToAnchor");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DistrictName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnBatman, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PanToIcons;
    /// <summary>
    /// Function: PanToIcons
    /// </summary>
    public unsafe virtual void PanToIcons(BmSDK.TArray<BmSDK.GFxUI.GFxObject> icons, bool finalPan)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PanToIcons, "BmGame.MGFxWidgetMapSystem.PanToIcons");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(icons, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(finalPan, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PanToSingleIcon;
    /// <summary>
    /// Function: PanToSingleIcon
    /// </summary>
    public unsafe virtual void PanToSingleIcon(BmSDK.GFxUI.GFxObject Icon, bool bDelay = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PanToSingleIcon, "BmGame.MGFxWidgetMapSystem.PanToSingleIcon");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Icon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDelay, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsWaypointSet;
    /// <summary>
    /// Function: IsWaypointSet
    /// </summary>
    public unsafe virtual bool IsWaypointSet()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsWaypointSet, "BmGame.MGFxWidgetMapSystem.IsWaypointSet");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanSetWayPoint;
    /// <summary>
    /// Function: CanSetWayPoint
    /// </summary>
    public unsafe virtual bool CanSetWayPoint(System.Numerics.Vector3 WayVec)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSetWayPoint, "BmGame.MGFxWidgetMapSystem.CanSetWayPoint");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WayVec, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ClearWaypoint;
    /// <summary>
    /// Function: ClearWaypoint
    /// </summary>
    public unsafe virtual void ClearWaypoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearWaypoint, "BmGame.MGFxWidgetMapSystem.ClearWaypoint");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetWaypoint;
    /// <summary>
    /// Function: SetWaypoint
    /// </summary>
    public unsafe virtual void SetWaypoint(BmSDK.GFxUI.GFxObject CustomWaypoint, BmSDK.FString onIcon, bool bEnabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWaypoint, "BmGame.MGFxWidgetMapSystem.SetWaypoint");
        byte* paramsPtr = stackalloc byte[116];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomWaypoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(onIcon, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnIconOff;
    /// <summary>
    /// Function: OnIconOff
    /// </summary>
    public unsafe virtual void OnIconOff()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnIconOff, "BmGame.MGFxWidgetMapSystem.OnIconOff");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnIconHit;
    /// <summary>
    /// Function: OnIconHit
    /// </summary>
    public unsafe virtual void OnIconHit(BmSDK.GFxUI.GFxObject hitIcon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnIconHit, "BmGame.MGFxWidgetMapSystem.OnIconHit");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(hitIcon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnY;
    /// <summary>
    /// Function: OnY
    /// </summary>
    public unsafe virtual void OnY()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnY, "BmGame.MGFxWidgetMapSystem.OnY");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_onUp;
    /// <summary>
    /// Function: onUp
    /// </summary>
    public unsafe virtual bool onUp(bool bKeyDown)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_onUp, "BmGame.MGFxWidgetMapSystem.onUp");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKeyDown, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_onRight;
    /// <summary>
    /// Function: onRight
    /// </summary>
    public unsafe virtual bool onRight(bool bKeyDown)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_onRight, "BmGame.MGFxWidgetMapSystem.onRight");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKeyDown, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_onLeft;
    /// <summary>
    /// Function: onLeft
    /// </summary>
    public unsafe virtual bool onLeft(bool bKeyDown)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_onLeft, "BmGame.MGFxWidgetMapSystem.onLeft");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKeyDown, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_onDown;
    /// <summary>
    /// Function: onDown
    /// </summary>
    public unsafe virtual bool onDown(bool bKeyDown)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_onDown, "BmGame.MGFxWidgetMapSystem.onDown");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKeyDown, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_OnFadeCompleted_Callback;
    /// <summary>
    /// Function: OnFadeCompleted_Callback
    /// </summary>
    public unsafe virtual void OnFadeCompleted_Callback()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFadeCompleted_Callback, "BmGame.MGFxWidgetMapSystem.OnFadeCompleted_Callback");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ItemSelectedCallback;
    /// <summary>
    /// Function: ItemSelectedCallback
    /// </summary>
    public unsafe virtual bool ItemSelectedCallback(BmSDK.FString clipName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ItemSelectedCallback, "BmGame.MGFxWidgetMapSystem.ItemSelectedCallback");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(clipName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_IsTowerOrDestinationLocked;
    /// <summary>
    /// Function: IsTowerOrDestinationLocked
    /// </summary>
    public unsafe virtual bool IsTowerOrDestinationLocked(int IconDataIndex, BmSDK.BmGame.MGFxWidgetMapSystem.FIconDataStruct opIconData = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTowerOrDestinationLocked, "BmGame.MGFxWidgetMapSystem.IsTowerOrDestinationLocked");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconDataIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(opIconData, paramsPtr + 4);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 64);
    }

    private static BmSDK.Function __fn_CheckGlobalFlags;
    /// <summary>
    /// Function: CheckGlobalFlags
    /// </summary>
    public unsafe virtual bool CheckGlobalFlags(BmSDK.BmGame.MGFxWidgetMapSystem.FIconDataStruct Icon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckGlobalFlags, "BmGame.MGFxWidgetMapSystem.CheckGlobalFlags");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Icon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 60);
    }

    private static BmSDK.Function __fn_GetVisible;
    /// <summary>
    /// Function: GetVisible
    /// </summary>
    public unsafe virtual bool GetVisible(BmSDK.BmGame.MGFxWidgetMapSystem.FIconDataStruct Icon, int mapFloorIndex, int roomFloorIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVisible, "BmGame.MGFxWidgetMapSystem.GetVisible");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Icon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(mapFloorIndex, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(roomFloorIndex, paramsPtr + 64);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 68);
    }

    private static BmSDK.Function __fn_TriggerPans;
    /// <summary>
    /// Function: TriggerPans
    /// </summary>
    public unsafe virtual void TriggerPans()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerPans, "BmGame.MGFxWidgetMapSystem.TriggerPans");
        byte* paramsPtr = stackalloc byte[152];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowTempObjectiveInfo;
    /// <summary>
    /// Function: ShowTempObjectiveInfo
    /// </summary>
    public unsafe virtual void ShowTempObjectiveInfo(BmSDK.BmGame.MGFxWidgetMapSystem.FIconDataStruct iconInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowTempObjectiveInfo, "BmGame.MGFxWidgetMapSystem.ShowTempObjectiveInfo");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iconInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RequestObjectiveData;
    /// <summary>
    /// Function: RequestObjectiveData
    /// </summary>
    public unsafe virtual void RequestObjectiveData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestObjectiveData, "BmGame.MGFxWidgetMapSystem.RequestObjectiveData");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessDistrictHit;
    /// <summary>
    /// Function: ProcessDistrictHit
    /// </summary>
    public unsafe virtual void ProcessDistrictHit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessDistrictHit, "BmGame.MGFxWidgetMapSystem.ProcessDistrictHit");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CenterMapOnIcon;
    /// <summary>
    /// Function: CenterMapOnIcon
    /// </summary>
    public unsafe virtual void CenterMapOnIcon(BmSDK.GFxUI.GFxObject Icon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CenterMapOnIcon, "BmGame.MGFxWidgetMapSystem.CenterMapOnIcon");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Icon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CenterMap;
    /// <summary>
    /// Function: CenterMap
    /// </summary>
    public unsafe virtual void CenterMap()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CenterMap, "BmGame.MGFxWidgetMapSystem.CenterMap");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CenterMapOnSubRoom;
    /// <summary>
    /// Function: CenterMapOnSubRoom
    /// </summary>
    public unsafe virtual void CenterMapOnSubRoom(BmSDK.FString SubRoomName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CenterMapOnSubRoom, "BmGame.MGFxWidgetMapSystem.CenterMapOnSubRoom");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubRoomName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindIconDataByName;
    /// <summary>
    /// Function: FindIconDataByName
    /// </summary>
    public unsafe virtual bool FindIconDataByName(BmSDK.FString clipName, out BmSDK.BmGame.MGFxWidgetMapSystem.FIconDataStruct outIconData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindIconDataByName, "BmGame.MGFxWidgetMapSystem.FindIconDataByName");
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(clipName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outIconData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MGFxWidgetMapSystem.FIconDataStruct>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 72);
    }

    private static BmSDK.Function __fn_GetInstanceNameForIcon;
    /// <summary>
    /// Function: GetInstanceNameForIcon
    /// </summary>
    public unsafe virtual bool GetInstanceNameForIcon(BmSDK.BmGame.MGFxWidgetMapSystem.FIconDataStruct iconValue, out BmSDK.FString instancename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInstanceNameForIcon, "BmGame.MGFxWidgetMapSystem.GetInstanceNameForIcon");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iconValue, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        instancename = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 60);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 72);
    }

    private static BmSDK.Function __fn_RotateForGothamBridgeMap;
    /// <summary>
    /// Function: RotateForGothamBridgeMap
    /// </summary>
    public unsafe virtual void RotateForGothamBridgeMap(out float X, out float Y)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RotateForGothamBridgeMap, "BmGame.MGFxWidgetMapSystem.RotateForGothamBridgeMap");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out X);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Y);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        X = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        Y = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_PlaceIcons;
    /// <summary>
    /// Function: PlaceIcons
    /// </summary>
    public unsafe virtual void PlaceIcons(bool centerTheMap = default, bool ShowAllIcons = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaceIcons, "BmGame.MGFxWidgetMapSystem.PlaceIcons");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(centerTheMap, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShowAllIcons, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetCurrentMapScale;
    /// <summary>
    /// Function: GetCurrentMapScale
    /// </summary>
    public unsafe virtual float GetCurrentMapScale()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentMapScale, "BmGame.MGFxWidgetMapSystem.GetCurrentMapScale");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetFloorMenuMapFloors;
    /// <summary>
    /// Function: SetFloorMenuMapFloors
    /// </summary>
    public unsafe virtual void SetFloorMenuMapFloors(BmSDK.TArray<int> mapFloorsArray, int CurrentIndex, int PlayerIndex, BmSDK.TArray<int> mapObjectivesArray)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFloorMenuMapFloors, "BmGame.MGFxWidgetMapSystem.SetFloorMenuMapFloors");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(mapFloorsArray, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentIndex, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(mapObjectivesArray, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMapFloors;
    /// <summary>
    /// Function: SetMapFloors
    /// </summary>
    public unsafe virtual void SetMapFloors(BmSDK.TArray<BmSDK.FString> mapNamesArray, int CurrentIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMapFloors, "BmGame.MGFxWidgetMapSystem.SetMapFloors");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(mapNamesArray, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentIndex, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetActiveFloor;
    /// <summary>
    /// Function: SetActiveFloor
    /// </summary>
    public unsafe virtual void SetActiveFloor(int activeFloorIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetActiveFloor, "BmGame.MGFxWidgetMapSystem.SetActiveFloor");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(activeFloorIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushMapIconArray;
    /// <summary>
    /// Function: PushMapIconArray
    /// </summary>
    public unsafe virtual void PushMapIconArray(BmSDK.TArray<BmSDK.GFxUI.GFxObject> icons)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushMapIconArray, "BmGame.MGFxWidgetMapSystem.PushMapIconArray");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(icons, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushStickData;
    /// <summary>
    /// Function: PushStickData
    /// </summary>
    public unsafe virtual void PushStickData(BmSDK.TArray<float> StickData, BmSDK.TArray<float> StickDataRight)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushStickData, "BmGame.MGFxWidgetMapSystem.PushStickData");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StickData, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StickDataRight, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushMapObjectives;
    /// <summary>
    /// Function: PushMapObjectives
    /// </summary>
    public unsafe virtual void PushMapObjectives(BmSDK.TArray<BmSDK.FString> Objectives, bool isMain)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushMapObjectives, "BmGame.MGFxWidgetMapSystem.PushMapObjectives");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Objectives, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(isMain, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateMapData;
    /// <summary>
    /// Function: UpdateMapData
    /// </summary>
    public unsafe virtual void UpdateMapData(BmSDK.FString viewMapName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateMapData, "BmGame.MGFxWidgetMapSystem.UpdateMapData");
        byte* paramsPtr = stackalloc byte[120];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(viewMapName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateCollectableFeedback;
    /// <summary>
    /// Function: UpdateCollectableFeedback
    /// </summary>
    public unsafe virtual void UpdateCollectableFeedback(BmSDK.FString areaName, BmSDK.TArray<BmSDK.FString> counts)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCollectableFeedback, "BmGame.MGFxWidgetMapSystem.UpdateCollectableFeedback");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(areaName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(counts, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemapLocationsToMatchBlackmailData;
    /// <summary>
    /// Function: RemapLocationsToMatchBlackmailData
    /// </summary>
    public unsafe virtual BmSDK.FString RemapLocationsToMatchBlackmailData(BmSDK.FString mapNameToTest)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemapLocationsToMatchBlackmailData, "BmGame.MGFxWidgetMapSystem.RemapLocationsToMatchBlackmailData");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(mapNameToTest, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_UpdateCollectableFeedbackForInterior;
    /// <summary>
    /// Function: UpdateCollectableFeedbackForInterior
    /// </summary>
    public unsafe virtual void UpdateCollectableFeedbackForInterior()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCollectableFeedbackForInterior, "BmGame.MGFxWidgetMapSystem.UpdateCollectableFeedbackForInterior");
        byte* paramsPtr = stackalloc byte[41];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCollectableFeedbackByDistrict;
    /// <summary>
    /// Function: GetCollectableFeedbackByDistrict
    /// </summary>
    public unsafe virtual void GetCollectableFeedbackByDistrict(BmSDK.FString DistrictName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCollectableFeedbackByDistrict, "BmGame.MGFxWidgetMapSystem.GetCollectableFeedbackByDistrict");
        byte* paramsPtr = stackalloc byte[73];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DistrictName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopAllStickSounds;
    /// <summary>
    /// Function: StopAllStickSounds
    /// </summary>
    public unsafe virtual void StopAllStickSounds()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAllStickSounds, "BmGame.MGFxWidgetMapSystem.StopAllStickSounds");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateStickSound;
    /// <summary>
    /// Function: UpdateStickSound
    /// </summary>
    public unsafe virtual void UpdateStickSound(int stickId, bool bStop, bool bZoomUp = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateStickSound, "BmGame.MGFxWidgetMapSystem.UpdateStickSound");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(stickId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStop, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bZoomUp, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DistrictChanged;
    /// <summary>
    /// Function: DistrictChanged
    /// </summary>
    public unsafe virtual void DistrictChanged(BmSDK.FString districtId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DistrictChanged, "BmGame.MGFxWidgetMapSystem.DistrictChanged");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(districtId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetStickAngMag;
    /// <summary>
    /// Function: GetStickAngMag
    /// </summary>
    public unsafe virtual void GetStickAngMag()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStickAngMag, "BmGame.MGFxWidgetMapSystem.GetStickAngMag");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateStickSoundDelegate;
    /// <summary>
    /// Function: UpdateStickSoundDelegate
    /// </summary>
    public unsafe virtual void UpdateStickSoundDelegate(int stickId, bool bStop, bool bZoomUp = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateStickSoundDelegate, "BmGame.MGFxWidgetMapSystem.UpdateStickSoundDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(stickId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStop, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bZoomUp, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DistrictChangedDelegate;
    /// <summary>
    /// Function: DistrictChangedDelegate
    /// </summary>
    public unsafe virtual void DistrictChangedDelegate(BmSDK.FString districtId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DistrictChangedDelegate, "BmGame.MGFxWidgetMapSystem.DistrictChangedDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(districtId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetStickAngMagDelegate;
    /// <summary>
    /// Function: GetStickAngMagDelegate
    /// </summary>
    public unsafe virtual void GetStickAngMagDelegate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStickAngMagDelegate, "BmGame.MGFxWidgetMapSystem.GetStickAngMagDelegate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCurrentAreaName;
    /// <summary>
    /// Function: GetCurrentAreaName
    /// </summary>
    public unsafe virtual BmSDK.FString GetCurrentAreaName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentAreaName, "BmGame.MGFxWidgetMapSystem.GetCurrentAreaName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsRoomOnActiveFloor;
    /// <summary>
    /// Function: IsRoomOnActiveFloor
    /// </summary>
    public unsafe virtual bool IsRoomOnActiveFloor(BmSDK.FString MapRoom)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRoomOnActiveFloor, "BmGame.MGFxWidgetMapSystem.IsRoomOnActiveFloor");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapRoom, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetRoomVisibilityFlag;
    /// <summary>
    /// Function: GetRoomVisibilityFlag
    /// </summary>
    public unsafe virtual bool GetRoomVisibilityFlag(BmSDK.FString MapRoom)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRoomVisibilityFlag, "BmGame.MGFxWidgetMapSystem.GetRoomVisibilityFlag");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapRoom, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ClearRevealNodes;
    /// <summary>
    /// Function: ClearRevealNodes
    /// </summary>
    public unsafe virtual void ClearRevealNodes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRevealNodes, "BmGame.MGFxWidgetMapSystem.ClearRevealNodes");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleRevealNodes;
    /// <summary>
    /// Function: ToggleRevealNodes
    /// </summary>
    public unsafe virtual void ToggleRevealNodes(bool isVisible)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleRevealNodes, "BmGame.MGFxWidgetMapSystem.ToggleRevealNodes");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(isVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MostWantedShowActiveLines;
    /// <summary>
    /// Function: MostWantedShowActiveLines
    /// </summary>
    public unsafe virtual void MostWantedShowActiveLines(BmSDK.TArray<BmSDK.FString> Lines)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MostWantedShowActiveLines, "BmGame.MGFxWidgetMapSystem.MostWantedShowActiveLines");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Lines, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MostWantedPlayRevealAnimation;
    /// <summary>
    /// Function: MostWantedPlayRevealAnimation
    /// </summary>
    public unsafe virtual void MostWantedPlayRevealAnimation(BmSDK.FString DistrictName, int TowerId, BmSDK.TArray<BmSDK.FString> Destinations, BmSDK.TArray<BmSDK.FString> Lines, BmSDK.TArray<BmSDK.FString> handlers)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MostWantedPlayRevealAnimation, "BmGame.MGFxWidgetMapSystem.MostWantedPlayRevealAnimation");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DistrictName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TowerId, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Destinations, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Lines, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(handlers, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushDistrictState;
    /// <summary>
    /// Function: PushDistrictState
    /// </summary>
    public unsafe virtual void PushDistrictState(BmSDK.FString DistrictName, bool IsLocked)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushDistrictState, "BmGame.MGFxWidgetMapSystem.PushDistrictState");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DistrictName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsLocked, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearDistrictStates;
    /// <summary>
    /// Function: ClearDistrictStates
    /// </summary>
    public unsafe virtual void ClearDistrictStates()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearDistrictStates, "BmGame.MGFxWidgetMapSystem.ClearDistrictStates");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RefreshDistrictStates;
    /// <summary>
    /// Function: RefreshDistrictStates
    /// </summary>
    public unsafe virtual void RefreshDistrictStates()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RefreshDistrictStates, "BmGame.MGFxWidgetMapSystem.RefreshDistrictStates");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDistrictStates;
    /// <summary>
    /// Function: SetDistrictStates
    /// </summary>
    public unsafe virtual void SetDistrictStates()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDistrictStates, "BmGame.MGFxWidgetMapSystem.SetDistrictStates");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleNetworkLines;
    /// <summary>
    /// Function: ToggleNetworkLines
    /// </summary>
    public unsafe virtual void ToggleNetworkLines(bool bLinesVisible)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleNetworkLines, "BmGame.MGFxWidgetMapSystem.ToggleNetworkLines");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLinesVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawLinesToActiveNodes;
    /// <summary>
    /// Function: DrawLinesToActiveNodes
    /// </summary>
    public unsafe virtual void DrawLinesToActiveNodes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawLinesToActiveNodes, "BmGame.MGFxWidgetMapSystem.DrawLinesToActiveNodes");
        byte* paramsPtr = stackalloc byte[253];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushDistrict;
    /// <summary>
    /// Function: PushDistrict
    /// </summary>
    public unsafe virtual void PushDistrict(BmSDK.GFxUI.GFxObject O)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushDistrict, "BmGame.MGFxWidgetMapSystem.PushDistrict");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(O, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushMapRoom;
    /// <summary>
    /// Function: PushMapRoom
    /// </summary>
    public unsafe virtual void PushMapRoom(BmSDK.GFxUI.GFxObject O)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushMapRoom, "BmGame.MGFxWidgetMapSystem.PushMapRoom");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(O, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushExit;
    /// <summary>
    /// Function: PushExit
    /// </summary>
    public unsafe virtual void PushExit(BmSDK.GFxUI.GFxObject O)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushExit, "BmGame.MGFxWidgetMapSystem.PushExit");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(O, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsMapAvailable;
    /// <summary>
    /// Function: IsMapAvailable
    /// </summary>
    public unsafe virtual bool IsMapAvailable(BmSDK.FString Map, BmSDK.FString room)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsMapAvailable, "BmGame.MGFxWidgetMapSystem.IsMapAvailable");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Map, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(room, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_SetMapNotAvailable;
    /// <summary>
    /// Function: SetMapNotAvailable
    /// </summary>
    public unsafe virtual void SetMapNotAvailable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMapNotAvailable, "BmGame.MGFxWidgetMapSystem.SetMapNotAvailable");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsMapSupported;
    /// <summary>
    /// Function: IsMapSupported
    /// </summary>
    public unsafe virtual bool IsMapSupported(BmSDK.FString testMapName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsMapSupported, "BmGame.MGFxWidgetMapSystem.IsMapSupported");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(testMapName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.BmGame.RGameInfo pRGI, BmSDK.BmGame.MGFxMovieControllerBCScreen parentMovieController)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.MGFxWidgetMapSystem.Init");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pRGI, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(parentMovieController, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPrompts;
    /// <summary>
    /// Function: SetPrompts
    /// </summary>
    public unsafe virtual void SetPrompts(BmSDK.BmGame.MGFxWidgetMapSystem.ButtonState_Y buttonState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPrompts, "BmGame.MGFxWidgetMapSystem.SetPrompts");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(buttonState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsCurrentIconMainObjective;
    /// <summary>
    /// Function: IsCurrentIconMainObjective
    /// </summary>
    public unsafe virtual bool IsCurrentIconMainObjective()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCurrentIconMainObjective, "BmGame.MGFxWidgetMapSystem.IsCurrentIconMainObjective");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsHittingPlayerIcon;
    /// <summary>
    /// Function: IsHittingPlayerIcon
    /// </summary>
    public unsafe virtual int IsHittingPlayerIcon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsHittingPlayerIcon, "BmGame.MGFxWidgetMapSystem.IsHittingPlayerIcon");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetMapPromptManagerRef;
    /// <summary>
    /// Function: SetMapPromptManagerRef
    /// </summary>
    public unsafe virtual void SetMapPromptManagerRef(BmSDK.BmGame.MGFxWidgetPromptManager mapPromptRef)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMapPromptManagerRef, "BmGame.MGFxWidgetMapSystem.SetMapPromptManagerRef");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(mapPromptRef, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPromptManagerRef;
    /// <summary>
    /// Function: SetPromptManagerRef
    /// </summary>
    public unsafe virtual void SetPromptManagerRef(BmSDK.BmGame.MGFxWidgetPromptManager promptRef)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPromptManagerRef, "BmGame.MGFxWidgetMapSystem.SetPromptManagerRef");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(promptRef, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WidgetUnloaded;
    /// <summary>
    /// Function: WidgetUnloaded
    /// </summary>
    public unsafe override bool WidgetUnloaded(BmSDK.FName WidgetName, BmSDK.FName WidgetPath, BmSDK.GFxUI.GFxObject Widget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WidgetUnloaded, "BmGame.MGFxWidgetMapSystem.WidgetUnloaded");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetPath, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Widget, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_WidgetInitialized;
    /// <summary>
    /// Function: WidgetInitialized
    /// </summary>
    public unsafe override bool WidgetInitialized(BmSDK.FName WidgetName, BmSDK.FName WidgetPath, BmSDK.GFxUI.GFxObject Widget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WidgetInitialized, "BmGame.MGFxWidgetMapSystem.WidgetInitialized");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WidgetPath, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Widget, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// Enum: E_DigitalInputState
    /// </summary>
    public enum E_DigitalInputState : byte
    {
        EDIS_None = 0,
        EDIS_Down = 1,
        EDIS_Left = 2,
        EDIS_Right = 3,
        EDIS_Up = 4,
        EDIS_MAX = 5,
    }

    /// <summary>
    /// Enum: ButtonState_Y
    /// </summary>
    public enum ButtonState_Y : byte
    {
        BSY_SetWaypoint = 0,
        BSY_RemoveWaypoint = 1,
        BSY_SetAsCurrentObjective = 2,
        BSY_MAX = 3,
    }

    /// <summary>
    /// Enum: ObjIcon
    /// </summary>
    public enum ObjIcon : byte
    {
        OI_Arrow = 0,
        OI_Ticked = 1,
        OI_Unlocked = 2,
        OI_SideStory = 3,
        OI_SideStoryTick = 4,
        OI_PointOfInterest = 5,
        OI_ARTraining = 6,
        OI_Waypoint = 7,
        OI_Switchpoint = 8,
        OI_Tower = 9,
        OI_DarkKnight = 10,
        OI_WayneTech = 11,
        OI_ChallengeMode = 12,
        OI_Anarky = 13,
        OI_CyrusPinkney = 14,
        OI_Failure = 15,
        OI_PenguinCache = 16,
        OI_Bird = 17,
        OI_BlackgatePrisoners = 18,
        OI_MadHatter = 19,
        OI_DeadShot = 20,
        OI_EnigmaNode = 21,
        OI_EnigmaPack = 22,
        OI_Shiva = 23,
        OI_BlackMask = 24,
        OI_Destination = 25,
        OI_Enigma = 26,
        OI_CrimeScene = 27,
        OI_Informant = 28,
        OI_MAX = 29,
    }

    /// <summary>
    /// ArrayProperty: MapDefaultFoorOverrides
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MGFxWidgetMapSystem.FMapDefaultFoorOverride> MapDefaultFoorOverrides
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MGFxWidgetMapSystem.FMapDefaultFoorOverride>>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// ArrayProperty: MapRoomFloors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MGFxWidgetMapSystem.FMapRoomFloor> MapRoomFloors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MGFxWidgetMapSystem.FMapRoomFloor>>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// ArrayProperty: MapNotAvailableLocations
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MGFxWidgetMapSystem.FMapNotAvailableLocation> MapNotAvailableLocations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MGFxWidgetMapSystem.FMapNotAvailableLocation>>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ArrayProperty: Interiors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MGFxWidgetMapInternal> Interiors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MGFxWidgetMapInternal>>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// ArrayProperty: MapIcons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GFxUI.GFxObject> MapIcons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GFxUI.GFxObject>>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// ArrayProperty: NodeLines
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GFxUI.GFxObject> NodeLines
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GFxUI.GFxObject>>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// ArrayProperty: ObjectivesMapObj
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ObjectivesMapObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// ArrayProperty: ObjectivesNewMapObj
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ObjectivesNewMapObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// ArrayProperty: RoomInDistrict
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RoomInDistrict
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// StructProperty: MapTransOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector2 MapTransOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector2>(Ptr + 344);

    /// <summary>
    /// StrProperty: MapName
    /// </summary>
    public unsafe BmSDK.FString MapName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// StrProperty: roomName
    /// </summary>
    public unsafe BmSDK.FString roomName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// StrProperty: currentMapName
    /// </summary>
    public unsafe BmSDK.FString currentMapName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bInPlayerMap
    /// </summary>
    public unsafe bool bInPlayerMap
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 388); }
    }

    /// <summary>
    /// BoolProperty: bMovedUserMarker
    /// </summary>
    public unsafe bool bMovedUserMarker
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 388); }
    }

    /// <summary>
    /// BoolProperty: bAutoPanToObjectives
    /// </summary>
    public unsafe bool bAutoPanToObjectives
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 388); }
    }

    /// <summary>
    /// BoolProperty: bAutoPanToWaypoint
    /// </summary>
    public unsafe bool bAutoPanToWaypoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 388); }
    }

    /// <summary>
    /// BoolProperty: bAutoPanToFastTravelTutorialLocation
    /// </summary>
    public unsafe bool bAutoPanToFastTravelTutorialLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 388); }
    }

    /// <summary>
    /// BoolProperty: bShowingTempObjectiveInfo
    /// </summary>
    public unsafe bool bShowingTempObjectiveInfo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 388); }
    }

    /// <summary>
    /// BoolProperty: bMostWanted
    /// </summary>
    public unsafe bool bMostWanted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 388); }
    }

    /// <summary>
    /// BoolProperty: bForceOpenWorld
    /// </summary>
    public unsafe bool bForceOpenWorld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 388); }
    }

    /// <summary>
    /// BoolProperty: bPanToCurrentObjective
    /// </summary>
    public unsafe bool bPanToCurrentObjective
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 388); }
    }

    /// <summary>
    /// BoolProperty: bMapNotAvailable
    /// </summary>
    public unsafe bool bMapNotAvailable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 388); }
    }

    /// <summary>
    /// BoolProperty: bIsFirstShivaIcon
    /// </summary>
    public unsafe bool bIsFirstShivaIcon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 388); }
    }

    /// <summary>
    /// BoolProperty: bFastTravelPrompt
    /// </summary>
    public unsafe bool bFastTravelPrompt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 388); }
    }

    /// <summary>
    /// BoolProperty: bSubMapPrompt
    /// </summary>
    public unsafe bool bSubMapPrompt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 388); }
    }

    /// <summary>
    /// BoolProperty: bWaitingFadeCompletedCallback
    /// </summary>
    public unsafe bool bWaitingFadeCompletedCallback
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 388); }
    }

    /// <summary>
    /// BoolProperty: bIsOnDistrict
    /// </summary>
    public unsafe bool bIsOnDistrict
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 388); }
    }

    /// <summary>
    /// BoolProperty: bDigitalZoomOut
    /// </summary>
    public unsafe bool bDigitalZoomOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 388); }
    }

    /// <summary>
    /// BoolProperty: bDigitalZoomIn
    /// </summary>
    public unsafe bool bDigitalZoomIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 388); }
    }

    /// <summary>
    /// IntProperty: ASMapIconLength
    /// </summary>
    public unsafe int ASMapIconLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// StrProperty: AutoPanParams
    /// </summary>
    public unsafe BmSDK.FString AutoPanParams
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// ObjectProperty: PlayerLocationIcon
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject PlayerLocationIcon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// ObjectProperty: CustomWaypointIcon
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject CustomWaypointIcon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// ObjectProperty: RoomWidget
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject RoomWidget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// StructProperty: CurrentHitIcon
    /// </summary>
    public unsafe ref BmSDK.BmGame.MGFxWidgetMapSystem.FIconDataStruct CurrentHitIcon
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.MGFxWidgetMapSystem.FIconDataStruct>(Ptr + 420);

    /// <summary>
    /// ByteProperty: ButtonYState
    /// </summary>
    public unsafe BmSDK.BmGame.MGFxWidgetMapSystem.ButtonState_Y ButtonYState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGFxWidgetMapSystem.ButtonState_Y>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// ArrayProperty: IconData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MGFxWidgetMapSystem.FIconDataStruct> IconData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MGFxWidgetMapSystem.FIconDataStruct>>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// ArrayProperty: CurrentRevealNodes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GFxUI.GFxObject> CurrentRevealNodes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GFxUI.GFxObject>>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// ArrayProperty: TutorialIconsToPan
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GFxUI.GFxObject> TutorialIconsToPan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GFxUI.GFxObject>>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// ArrayProperty: WaypointIconsToPan
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GFxUI.GFxObject> WaypointIconsToPan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GFxUI.GFxObject>>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// ArrayProperty: ObjectiveIconsToPan
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GFxUI.GFxObject> ObjectiveIconsToPan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GFxUI.GFxObject>>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// ArrayProperty: MapFlags
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> MapFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// ArrayProperty: MapObjFlags
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> MapObjFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaNodeFlags
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> EnigmaNodeFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaBlackmailFlags
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> EnigmaBlackmailFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// ArrayProperty: RoomsWithPacks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RoomsWithPacks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// ArrayProperty: MapFloors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MGFxWidgetMapSystem.FMapFloorData> MapFloors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MGFxWidgetMapSystem.FMapFloorData>>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// ArrayProperty: mapFloorNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> mapFloorNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// ArrayProperty: mapFloorsAvailable
    /// </summary>
    public unsafe BmSDK.TArray<int> mapFloorsAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// IntProperty: currentMapFloorIndex
    /// </summary>
    public unsafe int currentMapFloorIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// IntProperty: playerMapFloorIndex
    /// </summary>
    public unsafe int playerMapFloorIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// ArrayProperty: mapFloorObjectives
    /// </summary>
    public unsafe BmSDK.TArray<int> mapFloorObjectives
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// StructProperty: CurrentLStickSound
    /// </summary>
    public unsafe ref BmSDK.Engine.AkWwise.FAkSoundHandle CurrentLStickSound
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 660);

    /// <summary>
    /// StructProperty: CurrentRStickSound
    /// </summary>
    public unsafe ref BmSDK.Engine.AkWwise.FAkSoundHandle CurrentRStickSound
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 672);

    /// <summary>
    /// ObjectProperty: SoundEvent_Waypoint
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SoundEvent_Waypoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ObjectProperty: SoundEvent_UnsetWaypoint
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SoundEvent_UnsetWaypoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// ObjectProperty: SoundEvent_ToggleFloors
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SoundEvent_ToggleFloors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ObjectProperty: SoundEvent_SwitchMap
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SoundEvent_SwitchMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ObjectProperty: FloorMenu
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject FloorMenu
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ObjectProperty: MapNotAvailableWidget
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject MapNotAvailableWidget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ObjectProperty: AnchorOldGotham
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject AnchorOldGotham
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ObjectProperty: AnchorNewGotham
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject AnchorNewGotham
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// ObjectProperty: PromptManagerRef
    /// </summary>
    public unsafe BmSDK.BmGame.MGFxWidgetPromptManager PromptManagerRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGFxWidgetPromptManager>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ObjectProperty: MapPromptManagerRef
    /// </summary>
    public unsafe BmSDK.BmGame.MGFxWidgetPromptManager MapPromptManagerRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGFxWidgetPromptManager>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// FloatProperty: mapOffsetX
    /// </summary>
    public unsafe float mapOffsetX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// FloatProperty: mapOffsetY
    /// </summary>
    public unsafe float mapOffsetY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// StrProperty: sBatwingClipName
    /// </summary>
    public unsafe BmSDK.FString sBatwingClipName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// IntProperty: iBatwingIndex
    /// </summary>
    public unsafe int iBatwingIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// FloatProperty: StickLMag
    /// </summary>
    public unsafe float StickLMag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// FloatProperty: StickRMag
    /// </summary>
    public unsafe float StickRMag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// ArrayProperty: CurrentDigitalInputStates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MGFxWidgetMapSystem.E_DigitalInputState> CurrentDigitalInputStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MGFxWidgetMapSystem.E_DigitalInputState>>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// DelegateProperty: __GetStickAngMagDelegate__Delegate
    /// </summary>
    public unsafe System.IntPtr __GetStickAngMagDelegate__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// DelegateProperty: __DistrictChangedDelegate__Delegate
    /// </summary>
    public unsafe System.IntPtr __DistrictChangedDelegate__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// DelegateProperty: __UpdateStickSoundDelegate__Delegate
    /// </summary>
    public unsafe System.IntPtr __UpdateStickSoundDelegate__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// Struct: FMapDefaultFoorOverride
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FMapDefaultFoorOverride
    {
        /// <summary>
        /// StrProperty: Map
        /// </summary>
        public unsafe BmSDK.FString Map
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Floor
        /// </summary>
        public unsafe BmSDK.FString Floor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FMapNotAvailableLocation
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FMapNotAvailableLocation
    {
        /// <summary>
        /// StrProperty: Map
        /// </summary>
        public unsafe BmSDK.FString Map
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: room
        /// </summary>
        public unsafe BmSDK.FString room
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FMapFloorData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FMapFloorData
    {
        /// <summary>
        /// StrProperty: mapFloor
        /// </summary>
        public unsafe BmSDK.FString mapFloor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: rooms
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> rooms
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FMapRoomFloor
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FMapRoomFloor
    {
        /// <summary>
        /// StrProperty: Map
        /// </summary>
        public unsafe BmSDK.FString Map
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: room
        /// </summary>
        public unsafe BmSDK.FString room
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StrProperty: Floor
        /// </summary>
        public unsafe BmSDK.FString Floor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FIconDataStruct
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public partial record struct FIconDataStruct
    {
        /// <summary>
        /// StrProperty: Type
        /// </summary>
        public unsafe BmSDK.FString Type
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: subType
        /// </summary>
        public unsafe BmSDK.FString subType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StrProperty: IconName
        /// </summary>
        public unsafe BmSDK.FString IconName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: iconPos
        /// </summary>
        public unsafe System.Numerics.Vector3 iconPos
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// ObjectProperty: Icon
        /// </summary>
        public unsafe BmSDK.GFxUI.GFxObject Icon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// BoolProperty: bIsFlagSet
        /// </summary>
        public unsafe bool bIsFlagSet
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }; }
        }

        /// <summary>
        /// ByteProperty: npState
        /// </summary>
        public unsafe BmSDK.BmGame.MEnigmaDataManager.E_NodesAndPacksStates npState
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MEnigmaDataManager.E_NodesAndPacksStates>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }
    }
}
