#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MEnigmaDataManager<br/>
/// (size = 160)
/// (flags = 134217878)
/// </summary>
public partial class MEnigmaDataManager : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MEnigmaDataManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MEnigmaDataManager.
    /// </summary>
    public static MEnigmaDataManager DefaultObject => (MEnigmaDataManager)StaticClass().DefaultObject;

    internal MEnigmaDataManager() { }

    /// <summary>
    /// Constructs a new MEnigmaDataManager
    /// </summary>
    public MEnigmaDataManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MEnigmaDataManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MEnigmaDataManager(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MEnigmaDataManager>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MEnigmaDataManager>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MEnigmaDataManager>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MEnigmaDataManager>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MEnigmaDataManager>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MEnigmaDataManager>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MEnigmaDataManager>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MEnigmaDataManager>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: GetRiddlerLocationFromDistrictName
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPersistentData.ERiddlerLocationName GetRiddlerLocationFromDistrictName(BmSDK.FString DistrictName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.GetRiddlerLocationFromDistrictName", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DistrictName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.ERiddlerLocationName>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetDistrictProgressInfoByName
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MGenericProgressInfo.FGenericProgressData GetDistrictProgressInfoByName(BmSDK.FString DistrictName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.GetDistrictProgressInfoByName", true);
        byte* paramsPtr = stackalloc byte[37];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DistrictName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGenericProgressInfo.FGenericProgressData>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetDistrictProgressInfoByIndex
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MGenericProgressInfo.FGenericProgressData GetDistrictProgressInfoByIndex(int Index)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.GetDistrictProgressInfoByIndex", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGenericProgressInfo.FGenericProgressData>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetTotalBlackmailSetsProgressInfo
    /// </summary>
    public unsafe virtual void GetTotalBlackmailSetsProgressInfo(out BmSDK.BmGame.MGenericProgressInfo.FGenericProgressData Info)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.GetTotalBlackmailSetsProgressInfo", true);
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Info = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGenericProgressInfo.FGenericProgressData>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: GetBlackmailDataProgressInfoBySetId
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MGenericProgressInfo.FGenericProgressData GetBlackmailDataProgressInfoBySetId(int SetId, BmSDK.FString DistrictName = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.GetBlackmailDataProgressInfoBySetId", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DistrictName, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGenericProgressInfo.FGenericProgressData>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: AddTotalBlackmailDataProgressInfo
    /// </summary>
    public unsafe virtual void AddTotalBlackmailDataProgressInfo(out BmSDK.BmGame.MGenericProgressInfo.FGenericProgressData totalData)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.AddTotalBlackmailDataProgressInfo", true);
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        totalData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGenericProgressInfo.FGenericProgressData>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: AddBlackmailDataProgressInfoByDistrict
    /// </summary>
    public unsafe virtual void AddBlackmailDataProgressInfoByDistrict(BmSDK.BmGame.RPersistentData.ERiddlerLocationName District, out BmSDK.BmGame.MGenericProgressInfo.FGenericProgressData Data)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.AddBlackmailDataProgressInfoByDistrict", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(District, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Data = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGenericProgressInfo.FGenericProgressData>(paramsPtr + 4);
        return;
    }

    /// <summary>
    /// Function: AddBlackmailDataProgressInfoByRoom
    /// </summary>
    public unsafe virtual void AddBlackmailDataProgressInfoByRoom(BmSDK.BmGame.RPersistentData.ERiddlerLocationName District, out BmSDK.BmGame.MGenericProgressInfo.FGenericProgressData Data)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.AddBlackmailDataProgressInfoByRoom", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(District, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Data = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGenericProgressInfo.FGenericProgressData>(paramsPtr + 4);
        return;
    }

    /// <summary>
    /// Function: GetTotalNetworkProgressInfo
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MGenericProgressInfo.FGenericProgressData GetTotalNetworkProgressInfo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.GetTotalNetworkProgressInfo", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGenericProgressInfo.FGenericProgressData>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: AddTotalNetworkNodesProgressInfo
    /// </summary>
    public unsafe virtual void AddTotalNetworkNodesProgressInfo(out BmSDK.BmGame.MGenericProgressInfo.FGenericProgressData totalData)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.AddTotalNetworkNodesProgressInfo", true);
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        totalData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGenericProgressInfo.FGenericProgressData>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: AddNetworkNodeProgressInfoByDistrict
    /// </summary>
    public unsafe virtual void AddNetworkNodeProgressInfoByDistrict(BmSDK.BmGame.RPersistentData.ERiddlerLocationName District, out BmSDK.BmGame.MGenericProgressInfo.FGenericProgressData Info)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.AddNetworkNodeProgressInfoByDistrict", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(District, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Info = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGenericProgressInfo.FGenericProgressData>(paramsPtr + 4);
        return;
    }

    /// <summary>
    /// Function: GetNetworkNodeProgressInfoByTowerIndex
    /// </summary>
    public unsafe virtual void GetNetworkNodeProgressInfoByTowerIndex(int TowerIndex, out BmSDK.BmGame.MGenericProgressInfo.FGenericProgressData Info)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.GetNetworkNodeProgressInfoByTowerIndex", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TowerIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Info = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGenericProgressInfo.FGenericProgressData>(paramsPtr + 4);
        return;
    }

    /// <summary>
    /// Function: GetPSharedBlackmailDataByDistrict
    /// </summary>
    public unsafe virtual bool GetPSharedBlackmailDataByDistrict(BmSDK.BmGame.RPersistentData.ERiddlerLocationName DistrictName, out BmSDK.TArray<int> ptr)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.GetPSharedBlackmailDataByDistrict", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DistrictName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ptr = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetPSharedNetworkDataByDistrict
    /// </summary>
    public unsafe virtual bool GetPSharedNetworkDataByDistrict(BmSDK.BmGame.RPersistentData.ERiddlerLocationName District, out BmSDK.TArray<int> networkData)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.GetPSharedNetworkDataByDistrict", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(District, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        networkData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetBlackmailDataStatusByName
    /// </summary>
    public unsafe virtual int GetBlackmailDataStatusByName(BmSDK.FString packName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.GetBlackmailDataStatusByName", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(packName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetStateForIcon
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MEnigmaDataManager.E_NodesAndPacksStates GetStateForIcon(BmSDK.FString iconType, BmSDK.FString IconName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.GetStateForIcon", true);
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iconType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MEnigmaDataManager.E_NodesAndPacksStates>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: CountTotalBlackmailData
    /// </summary>
    public unsafe virtual int CountTotalBlackmailData()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.CountTotalBlackmailData", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsTowerInDistrictLocked
    /// </summary>
    public unsafe virtual bool IsTowerInDistrictLocked(BmSDK.BmGame.RPersistentData.ERiddlerLocationName District)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.IsTowerInDistrictLocked", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(District, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsDistrictLocked
    /// </summary>
    public unsafe virtual bool IsDistrictLocked(BmSDK.BmGame.RPersistentData.ERiddlerLocationName District)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.IsDistrictLocked", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(District, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetActiveNodeLinesByDistrict
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.FString> GetActiveNodeLinesByDistrict(BmSDK.FString DistrictName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.GetActiveNodeLinesByDistrict", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DistrictName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetTowerNamesByDistrict
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.FString> GetTowerNamesByDistrict(BmSDK.FString DistrictName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.GetTowerNamesByDistrict", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DistrictName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetHandlersByTowerId
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.FString> GetHandlersByTowerId(int TowerId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.GetHandlersByTowerId", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TowerId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetDestinationsByTowerId
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.FString> GetDestinationsByTowerId(int TowerId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.GetDestinationsByTowerId", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TowerId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetDataSetIndexByFragment
    /// </summary>
    public unsafe virtual int GetDataSetIndexByFragment(BmSDK.FString FragmentName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.GetDataSetIndexByFragment", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FragmentName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetDataSetByIndex
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.FString> GetDataSetByIndex(int Index)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.GetDataSetByIndex", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: TryMarkDistrictCompleteEnigma
    /// </summary>
    public unsafe virtual void TryMarkDistrictCompleteEnigma()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.TryMarkDistrictCompleteEnigma", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetTowerProgress
    /// </summary>
    public unsafe virtual int GetTowerProgress()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.GetTowerProgress", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CompleteAllDataSets
    /// </summary>
    public unsafe virtual void CompleteAllDataSets(int SetId, bool allButOne = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.CompleteAllDataSets", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(allButOne, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UnlockAllDataSets
    /// </summary>
    public unsafe virtual void UnlockAllDataSets(int SetId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.UnlockAllDataSets", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SetId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CompleteAllSpyNodes
    /// </summary>
    public unsafe virtual void CompleteAllSpyNodes(int TowerIndex, bool allButOne = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.CompleteAllSpyNodes", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TowerIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(allButOne, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UnlockAllSpyNodes
    /// </summary>
    public unsafe virtual void UnlockAllSpyNodes(int TowerIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.UnlockAllSpyNodes", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TowerIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetTotalEnigmaProgressInfo
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MGenericProgressInfo.FGenericProgressData GetTotalEnigmaProgressInfo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.GetTotalEnigmaProgressInfo", true);
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MGenericProgressInfo.FGenericProgressData>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: BuildEnigmaData
    /// </summary>
    public unsafe virtual void BuildEnigmaData()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.BuildEnigmaData", true);
        byte* paramsPtr = stackalloc byte[0];
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
    /// Function: Init
    /// </summary>
    public unsafe virtual void Init(BmSDK.BmGame.RGameInfo pRGI)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MEnigmaDataManager.Init", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pRGI, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: mGameInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo mGameInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// ArrayProperty: TowerData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MEnigmaDataManager.FTowers> TowerData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MEnigmaDataManager.FTowers>>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// ArrayProperty: SpyNetworkData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MEnigmaDataManager.FSpyNetworks> SpyNetworkData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MEnigmaDataManager.FSpyNetworks>>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// ArrayProperty: DestinationData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MEnigmaDataManager.FDestinationInfo> DestinationData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MEnigmaDataManager.FDestinationInfo>>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }

    /// <summary>
    /// ArrayProperty: DataSetsDef
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MEnigmaDataManager.FDataSetInfo> DataSetsDef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MEnigmaDataManager.FDataSetInfo>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: DistrictInfoDef
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MEnigmaDataManager.FDistrictInfo> DistrictInfoDef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MEnigmaDataManager.FDistrictInfo>>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ArrayProperty: DataSetConceptArtUnlock
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentData.EConceptArt> DataSetConceptArtUnlock
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentData.EConceptArt>>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaIconTypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> EnigmaIconTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// ArrayProperty: DistrictNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> DistrictNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ArrayProperty: DataSetOwner
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentData.ETapeCharacter> DataSetOwner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentData.ETapeCharacter>>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// IntProperty: TotalInformants
    /// </summary>
    public unsafe int TotalInformants
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// Struct: FDistrictInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FDistrictInfo
    {
        /// <summary>
        /// StrProperty: DistrictName
        /// </summary>
        public unsafe BmSDK.FString DistrictName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: DataSets
        /// </summary>
        public unsafe BmSDK.TArray<int> DataSets
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FDataSetInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FDataSetInfo
    {
        /// <summary>
        /// StrProperty: FragmentName
        /// </summary>
        public unsafe BmSDK.FString FragmentName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: SetId
        /// </summary>
        public unsafe int SetId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ByteProperty: District
        /// </summary>
        public unsafe BmSDK.BmGame.RPersistentData.ERiddlerLocationName District
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.ERiddlerLocationName>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: ArrayIndex
        /// </summary>
        public unsafe int ArrayIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FDestinationInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FDestinationInfo
    {
        /// <summary>
        /// ByteProperty: TowerId
        /// </summary>
        public unsafe BmSDK.BmGame.MEnigmaTower.E_TowerIDs TowerId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MEnigmaTower.E_TowerIDs>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: Destinations
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> Destinations
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FSpyNetworks
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 37)]
    public partial record struct FSpyNetworks
    {
        /// <summary>
        /// StrProperty: DistrictName
        /// </summary>
        public unsafe BmSDK.FString DistrictName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: SpyNodes
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> SpyNodes
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ArrayProperty: NodeLines
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> NodeLines
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ByteProperty: District
        /// </summary>
        public unsafe BmSDK.BmGame.RPersistentData.ERiddlerLocationName District
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.ERiddlerLocationName>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }
    }

    /// <summary>
    /// Struct: FTowers
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 26)]
    public partial record struct FTowers
    {
        /// <summary>
        /// StrProperty: DistrictName
        /// </summary>
        public unsafe BmSDK.FString DistrictName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: TowerNames
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> TowerNames
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ByteProperty: TowerState
        /// </summary>
        public unsafe BmSDK.BmGame.MEnigmaDataManager.E_TowerStates TowerState
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MEnigmaDataManager.E_TowerStates>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ByteProperty: District
        /// </summary>
        public unsafe BmSDK.BmGame.RPersistentData.ERiddlerLocationName District
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.ERiddlerLocationName>(Ptr + 25); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 25); }; }
        }
    }

    /// <summary>
    /// Enum: E_NodesAndPacksStates
    /// </summary>
    public enum E_NodesAndPacksStates : byte
    {
        NPS_Hidden = 0,
        NPS_Revealed = 1,
        NPS_Marked = 2,
        NPS_Complete = 3,
        NPS_MAX = 4,
    }

    /// <summary>
    /// Enum: E_TowerStates
    /// </summary>
    public enum E_TowerStates : byte
    {
        S_Locked = 0,
        S_Unlocked = 1,
        S_Hacked = 2,
        S_MAX = 3,
    }

    /// <summary>
    /// Enum: E_EnigmaDataTypes
    /// </summary>
    public enum E_EnigmaDataTypes : byte
    {
        ED_Network = 0,
        ED_Blackmail = 1,
        ED_Cypher = 2,
        ED_MAX = 3,
    }

    /// <summary>
    /// Enum: E_IconTypes
    /// </summary>
    public enum E_IconTypes : byte
    {
        T_Pickup = 0,
        T_CCTV = 1,
        T_Tower = 2,
        T_MAX = 3,
    }
}
