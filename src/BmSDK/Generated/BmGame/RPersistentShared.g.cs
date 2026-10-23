#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPersistentShared<br/>
/// (size = 1208)
/// (flags = 134217874)
/// </summary>
public partial class RPersistentShared : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPersistentShared", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPersistentShared.
    /// </summary>
    public static RPersistentShared DefaultObject => (RPersistentShared)StaticClass().DefaultObject;

    internal RPersistentShared() { }

    /// <summary>
    /// Constructs a new RPersistentShared
    /// </summary>
    public RPersistentShared(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPersistentShared Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPersistentShared(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPersistentShared>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPersistentShared>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPersistentShared>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPersistentShared>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPersistentShared>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPersistentShared>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPersistentShared>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPersistentShared>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: GetNetworkDataByDistrict
    /// </summary>
    public unsafe virtual bool GetNetworkDataByDistrict(BmSDK.BmGame.RPersistentData.ERiddlerLocationName District, out BmSDK.TArray<int> ptr)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.GetNetworkDataByDistrict", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(District, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ptr = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetBlackmailDataByDistrict
    /// </summary>
    public unsafe virtual bool GetBlackmailDataByDistrict(BmSDK.BmGame.RPersistentData.ERiddlerLocationName DistrictName, out BmSDK.TArray<int> ptr)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.GetBlackmailDataByDistrict", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DistrictName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ptr = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetPinkneyPageIndex
    /// </summary>
    public unsafe virtual int GetPinkneyPageIndex(int tapeIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.GetPinkneyPageIndex", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(tapeIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: UnlockSkin
    /// </summary>
    public unsafe virtual void UnlockSkin(BmSDK.BmGame.RPersistentShared.EUnlockableSkin skin)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.UnlockSkin", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(skin, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsSkinUnlocked
    /// </summary>
    public unsafe virtual bool IsSkinUnlocked(BmSDK.BmGame.RPersistentShared.EUnlockableSkin skin)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.IsSkinUnlocked", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(skin, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: AllCamerasBroken
    /// </summary>
    public unsafe virtual bool AllCamerasBroken()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.AllCamerasBroken", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetCameraBroken
    /// </summary>
    public unsafe virtual int SetCameraBroken(BmSDK.BmGame.RPersistentData.ERiddlerLocationName Zone)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.SetCameraBroken", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Zone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IncreasePenguinBrokenCount
    /// </summary>
    public unsafe virtual int IncreasePenguinBrokenCount(BmSDK.BmGame.RPersistentData.ERiddlerLocationName Zone)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.IncreasePenguinBrokenCount", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Zone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IncreaseJokerBalloonPoppedCount
    /// </summary>
    public unsafe virtual int IncreaseJokerBalloonPoppedCount(BmSDK.BmGame.RPersistentData.ERiddlerLocationName Zone)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.IncreaseJokerBalloonPoppedCount", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Zone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IncreaseJokerTeethCount
    /// </summary>
    public unsafe virtual int IncreaseJokerTeethCount(BmSDK.BmGame.RPersistentData.ERiddlerLocationName Zone)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.IncreaseJokerTeethCount", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Zone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IncreaseRiddleCount
    /// </summary>
    public unsafe virtual int IncreaseRiddleCount(BmSDK.BmGame.RPersistentData.ERiddlerLocationName Zone)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.IncreaseRiddleCount", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Zone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: CWJewelleryTotal
    /// </summary>
    public unsafe virtual int CWJewelleryTotal()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.CWJewelleryTotal", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CWTotalPossiblePickupsAndChallenges
    /// </summary>
    public unsafe virtual int CWTotalPossiblePickupsAndChallenges()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.CWTotalPossiblePickupsAndChallenges", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CWPickupsAndChallengesCompleteCount
    /// </summary>
    public unsafe virtual int CWPickupsAndChallengesCompleteCount()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.CWPickupsAndChallengesCompleteCount", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CWPickupsAndChallengesComplete
    /// </summary>
    public unsafe virtual bool CWPickupsAndChallengesComplete()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.CWPickupsAndChallengesComplete", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetCWPickupsTotalCollected
    /// </summary>
    public unsafe virtual int GetCWPickupsTotalCollected()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.GetCWPickupsTotalCollected", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IncreaseCWPickupCount
    /// </summary>
    public unsafe virtual int IncreaseCWPickupCount(BmSDK.BmGame.RPersistentData.ERiddlerLocationName Zone)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.IncreaseCWPickupCount", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Zone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IncreasePickupCount
    /// </summary>
    public unsafe virtual int IncreasePickupCount(BmSDK.BmGame.RPersistentData.ERiddlerLocationName Zone)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.IncreasePickupCount", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Zone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IncreaseBrokenDemonSealCount
    /// </summary>
    public unsafe virtual int IncreaseBrokenDemonSealCount()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.IncreaseBrokenDemonSealCount", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IncreaseBrokenHarleyHeadCount
    /// </summary>
    public unsafe virtual int IncreaseBrokenHarleyHeadCount()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.IncreaseBrokenHarleyHeadCount", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetRiddlerLocationDataValue
    /// </summary>
    public unsafe virtual int GetRiddlerLocationDataValue(int LocIndex, int Index)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.GetRiddlerLocationDataValue", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: SetRiddlerLocationData
    /// </summary>
    public unsafe virtual void SetRiddlerLocationData(int LocIndex, int Index, int Value, BmSDK.BmGame.MEnigmaDataManager.E_EnigmaDataTypes ItemType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.SetRiddlerLocationData", true);
        byte* paramsPtr = stackalloc byte[13];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemType, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetRiddlerLocationData
    /// </summary>
    public unsafe virtual BmSDK.TArray<int> GetRiddlerLocationData(int LocIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.GetRiddlerLocationData", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsRiddlerAreaUnlocked
    /// </summary>
    public unsafe virtual bool IsRiddlerAreaUnlocked(int LocIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.IsRiddlerAreaUnlocked", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: UnlockRiddlerArea
    /// </summary>
    public unsafe virtual void UnlockRiddlerArea(int LocIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.UnlockRiddlerArea", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearRiddlerAreaNew
    /// </summary>
    public unsafe virtual void ClearRiddlerAreaNew(int LocIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.ClearRiddlerAreaNew", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetRiddlerTotalCount
    /// </summary>
    public unsafe virtual int GetRiddlerTotalCount()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.GetRiddlerTotalCount", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Set_GameStat
    /// </summary>
    public unsafe virtual void Set_GameStat(bool bPlus, BmSDK.BmGame.RPersistentShared.EPercentData Item, float Numerator, float Divisor)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.Set_GameStat", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlus, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Item, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Numerator, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Divisor, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Get_GameStat
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPersistentShared.FGameStat Get_GameStat(bool bPlus, BmSDK.BmGame.RPersistentShared.EPercentData Item)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.Get_GameStat", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlus, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Item, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentShared.FGameStat>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: Get_GameStatPercent
    /// </summary>
    public unsafe virtual float Get_GameStatPercent(bool bPlus, BmSDK.BmGame.RPersistentShared.EPercentData Item)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.Get_GameStatPercent", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlus, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Item, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: ClearStoryNew
    /// </summary>
    public unsafe virtual void ClearStoryNew(int Uid)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.ClearStoryNew", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Uid, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsStoryNew
    /// </summary>
    public unsafe virtual bool IsStoryNew(int Uid)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.IsStoryNew", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Uid, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: CountCityStoryNew
    /// </summary>
    public unsafe virtual int CountCityStoryNew(int StartAt, int Count)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.CountCityStoryNew", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartAt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Count, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: MarkOffCityStory
    /// </summary>
    public unsafe virtual void MarkOffCityStory(int CityStoryId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.MarkOffCityStory", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CityStoryId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CountBiosNew
    /// </summary>
    public unsafe virtual int CountBiosNew()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.CountBiosNew", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsBioUnlocked
    /// </summary>
    public unsafe virtual bool IsBioUnlocked(BmSDK.BmGame.RPersistentData.EBioCharacter inBio)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.IsBioUnlocked", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inBio, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: Dump
    /// </summary>
    public unsafe virtual void Dump()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.Dump", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DumpStats
    /// </summary>
    public unsafe virtual void DumpStats()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.DumpStats", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PadStr
    /// </summary>
    public unsafe virtual BmSDK.FString PadStr(BmSDK.FString InStr, int DesiredLen)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.PadStr", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InStr, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredLen, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: FloatArrayToString
    /// </summary>
    public unsafe virtual BmSDK.FString FloatArrayToString(BmSDK.TArray<float> Values)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.FloatArrayToString", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Values, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: IntArrayToString
    /// </summary>
    public unsafe virtual BmSDK.FString IntArrayToString(BmSDK.TArray<int> Values)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.IntArrayToString", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Values, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: ByteArrayToString
    /// </summary>
    public unsafe virtual BmSDK.FString ByteArrayToString(BmSDK.TArray<byte> Values)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.ByteArrayToString", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Values, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe virtual void Init()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.Init", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsSharedFlagSet
    /// </summary>
    public unsafe virtual bool IsSharedFlagSet(BmSDK.FString FlagName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.IsSharedFlagSet", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlagName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: SetSharedFlag
    /// </summary>
    public unsafe virtual void SetSharedFlag(BmSDK.FString FlagName, bool bTrue)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentShared.SetSharedFlag", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlagName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTrue, paramsPtr + 12);
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
    /// IntProperty: Version
    /// </summary>
    public unsafe int Version
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// StrProperty: Description
    /// </summary>
    public unsafe BmSDK.FString Description
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// ArrayProperty: SharedFlags
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> SharedFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// ArrayProperty: Upgrades
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> Upgrades
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }

    /// <summary>
    /// IntProperty: NumUpgrades
    /// </summary>
    public unsafe int NumUpgrades
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: CatwomanEpisodes_New
    /// </summary>
    public unsafe BmSDK.TArray<byte> CatwomanEpisodes_New
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// ArrayProperty: CatwomanEpisodes_Unlocked
    /// </summary>
    public unsafe BmSDK.TArray<byte> CatwomanEpisodes_Unlocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: CharacterBios_New
    /// </summary>
    public unsafe BmSDK.TArray<byte> CharacterBios_New
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// ArrayProperty: CharacterBios_SubId
    /// </summary>
    public unsafe BmSDK.TArray<byte> CharacterBios_SubId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ArrayProperty: CharacterBios_Unlocked
    /// </summary>
    public unsafe BmSDK.TArray<byte> CharacterBios_Unlocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// ArrayProperty: CharacterBios_State
    /// </summary>
    public unsafe BmSDK.TArray<byte> CharacterBios_State
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ArrayProperty: CharacterViewer_New
    /// </summary>
    public unsafe BmSDK.TArray<byte> CharacterViewer_New
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// ArrayProperty: CharacterViewer_Unlocked
    /// </summary>
    public unsafe BmSDK.TArray<byte> CharacterViewer_Unlocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// IntProperty: CharacterViewer_Total
    /// </summary>
    public unsafe int CharacterViewer_Total
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// ArrayProperty: CharacterSkins_Unlocked
    /// </summary>
    public unsafe BmSDK.TArray<byte> CharacterSkins_Unlocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ArrayProperty: GalleryUnlocks_New
    /// </summary>
    public unsafe BmSDK.TArray<byte> GalleryUnlocks_New
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// ArrayProperty: GalleryUnlocks
    /// </summary>
    public unsafe BmSDK.TArray<byte> GalleryUnlocks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// ArrayProperty: Upgrades_States
    /// </summary>
    public unsafe BmSDK.TArray<int> Upgrades_States
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// ArrayProperty: Upgrades_New
    /// </summary>
    public unsafe BmSDK.TArray<byte> Upgrades_New
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// ArrayProperty: DLCStory_New
    /// </summary>
    public unsafe BmSDK.TArray<byte> DLCStory_New
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// ArrayProperty: DLCStory_Status
    /// </summary>
    public unsafe BmSDK.TArray<byte> DLCStory_Status
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ArrayProperty: CityStories
    /// </summary>
    public unsafe BmSDK.TArray<int> CityStories
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// ArrayProperty: LinkedCityStories
    /// </summary>
    public unsafe BmSDK.TArray<int> LinkedCityStories
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// ArrayProperty: GameplayStats
    /// </summary>
    public unsafe BmSDK.TArray<float> GameplayStats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// ArrayProperty: GameStats
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentShared.FGameStat> GameStats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentShared.FGameStat>>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// ArrayProperty: GameStats_Plus
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentShared.FGameStat> GameStats_Plus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentShared.FGameStat>>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// FloatProperty: Player_RangeBonus
    /// </summary>
    public unsafe float Player_RangeBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_AreaTotals
    /// </summary>
    public unsafe BmSDK.TArray<byte> RiddlerData_AreaTotals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_Rows
    /// </summary>
    public unsafe BmSDK.TArray<byte> RiddlerData_Rows
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_AreasNew
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_AreasNew
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_AreasLocked
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_AreasLocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_OverworldA
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_OverworldA
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_OverworldB
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_OverworldB
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_OverworldC
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_OverworldC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_OverworldD
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_OverworldD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_OverworldE
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_OverworldE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_Steel
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_Steel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_Museum
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_Museum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_Underworld
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_Underworld
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_Batman
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_Batman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_DistrictNew
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_DistrictNew
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_DistrictLocked
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_DistrictLocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// ByteProperty: EnigmaData_DistrictNetworkTotals
    /// </summary>
    public unsafe byte EnigmaData_DistrictNetworkTotals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// ByteProperty: EnigmaData_Blackmail_SetsTotals
    /// </summary>
    public unsafe byte EnigmaData_Blackmail_SetsTotals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 517); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 517); }
    }

    /// <summary>
    /// ByteProperty: EnigmaData_CypherTotals
    /// </summary>
    public unsafe byte EnigmaData_CypherTotals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 518); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 518); }
    }

    /// <summary>
    /// ByteProperty: bStoryGadgetLockedByNewGamePlus
    /// </summary>
    public unsafe byte bStoryGadgetLockedByNewGamePlus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 519); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 519); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Network_Coventry
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Network_Coventry
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Network_Bowery
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Network_Bowery
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Network_ParkRow
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Network_ParkRow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Network_Industrial
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Network_Industrial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Network_Burnley
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Network_Burnley
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Network_Diamond
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Network_Diamond
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Network_Amusement
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Network_Amusement
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_DistrictBlackmailTotals
    /// </summary>
    public unsafe BmSDK.TArray<byte> EnigmaData_DistrictBlackmailTotals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Blackmail_Coventry
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Blackmail_Coventry
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Blackmail_Bowery
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Blackmail_Bowery
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Blackmail_ParkRow
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Blackmail_ParkRow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Blackmail_Industrial
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Blackmail_Industrial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Blackmail_Burnley
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Blackmail_Burnley
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Blackmail_Diamond
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Blackmail_Diamond
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Blackmail_Amusement
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Blackmail_Amusement
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Blackmail_SheldonPark
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Blackmail_SheldonPark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Blackmail_Bridge
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Blackmail_Bridge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Blackmail_BridgeInterior
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Blackmail_BridgeInterior
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Blackmail_Courthouse
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Blackmail_Courthouse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Blackmail_Church
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Blackmail_Church
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Blackmail_HatShop
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Blackmail_HatShop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Blackmail_Bank
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Blackmail_Bank
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Blackmail_BaneHQ
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Blackmail_BaneHQ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Blackmail_FinalOffer
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Blackmail_FinalOffer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Blackmail_Steel
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Blackmail_Steel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Blackmail_Hotel
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Blackmail_Hotel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Blackmail_GCPD
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Blackmail_GCPD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Blackmail_Sewer
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Blackmail_Sewer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Blackmail_MyAlibi
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Blackmail_MyAlibi
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Blackmail_LaceyTower
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Blackmail_LaceyTower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Blackmail_EnigmaHQ
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Blackmail_EnigmaHQ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Blackmail_SetsCompleted
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Blackmail_SetsCompleted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Cyphers_OldGotham
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Cyphers_OldGotham
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// ArrayProperty: EnigmaData_Cyphers_NewGotham
    /// </summary>
    public unsafe BmSDK.TArray<int> EnigmaData_Cyphers_NewGotham
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// ArrayProperty: PickupTallys
    /// </summary>
    public unsafe BmSDK.TArray<int> PickupTallys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// ArrayProperty: CWPickupTallys
    /// </summary>
    public unsafe BmSDK.TArray<int> CWPickupTallys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// ArrayProperty: JokerTeethPickupTallys
    /// </summary>
    public unsafe BmSDK.TArray<int> JokerTeethPickupTallys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// ArrayProperty: CharacterTapesCollected
    /// </summary>
    public unsafe BmSDK.TArray<int> CharacterTapesCollected
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// ArrayProperty: CharacterTapesMax
    /// </summary>
    public unsafe BmSDK.TArray<int> CharacterTapesMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// ArrayProperty: TapesCollected
    /// </summary>
    public unsafe BmSDK.TArray<int> TapesCollected
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// ArrayProperty: JokerBalloonTallys
    /// </summary>
    public unsafe BmSDK.TArray<int> JokerBalloonTallys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// ArrayProperty: BrokenPenguinTallys
    /// </summary>
    public unsafe BmSDK.TArray<int> BrokenPenguinTallys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// ArrayProperty: BrokenCameraTallys
    /// </summary>
    public unsafe BmSDK.TArray<int> BrokenCameraTallys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// ArrayProperty: RiddleTallys
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddleTallys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// IntProperty: BrokenHarleyHeadTally
    /// </summary>
    public unsafe int BrokenHarleyHeadTally
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// IntProperty: BrokenDemonSealTally
    /// </summary>
    public unsafe int BrokenDemonSealTally
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// IntProperty: BrokenGrundyHeadTally
    /// </summary>
    public unsafe int BrokenGrundyHeadTally
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// IntProperty: PickupCount
    /// </summary>
    public unsafe int PickupCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// IntProperty: PickupRevealsLeft
    /// </summary>
    public unsafe int PickupRevealsLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// IntProperty: InterrogatesLeft
    /// </summary>
    public unsafe int InterrogatesLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// IntProperty: NumCamerasBroken
    /// </summary>
    public unsafe int NumCamerasBroken
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// IntProperty: InterrogatesPerformed
    /// </summary>
    public unsafe int InterrogatesPerformed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// IntProperty: InterrogatesWithTutorialPerformed
    /// </summary>
    public unsafe int InterrogatesWithTutorialPerformed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// IntProperty: mPlayerXPLevel
    /// </summary>
    public unsafe int mPlayerXPLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// IntProperty: mPlayerXPTotal
    /// </summary>
    public unsafe int mPlayerXPTotal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// IntProperty: mPlayerTPLevel
    /// </summary>
    public unsafe int mPlayerTPLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// FloatProperty: mPlayerTPTotal
    /// </summary>
    public unsafe float mPlayerTPTotal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// FloatProperty: mBankedXP
    /// </summary>
    public unsafe float mBankedXP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// IntProperty: UpgradesBought
    /// </summary>
    public unsafe int UpgradesBought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// IntProperty: CW_UpgradesBought
    /// </summary>
    public unsafe int CW_UpgradesBought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// IntProperty: UpgradePoints
    /// </summary>
    public unsafe int UpgradePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// IntProperty: ShowLevelUpFlag
    /// </summary>
    public unsafe int ShowLevelUpFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// IntProperty: DarkKnightChallengesEnabled
    /// </summary>
    public unsafe int DarkKnightChallengesEnabled
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// IntProperty: EnigmaEncryptionKeys
    /// </summary>
    public unsafe int EnigmaEncryptionKeys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// IntProperty: EnigmaPacksForKeys
    /// </summary>
    public unsafe int EnigmaPacksForKeys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// IntProperty: EnigmaDatasetsRecovered
    /// </summary>
    public unsafe int EnigmaDatasetsRecovered
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// IntProperty: EnigmaInformantsInterrogated
    /// </summary>
    public unsafe int EnigmaInformantsInterrogated
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// IntProperty: AnarkyGraffitisScanned
    /// </summary>
    public unsafe int AnarkyGraffitisScanned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// FloatProperty: TotalTimePlayed
    /// </summary>
    public unsafe float TotalTimePlayed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// ArrayProperty: DarkKnightChallenges
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MBatmanChallenge.FChallengeSaveData> DarkKnightChallenges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MBatmanChallenge.FChallengeSaveData>>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// ArrayProperty: AchievementChallenges
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MBatmanChallenge.FChallengeSaveData> AchievementChallenges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MBatmanChallenge.FChallengeSaveData>>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// IntProperty: WeaponCache_Satchel
    /// </summary>
    public unsafe int WeaponCache_Satchel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }

    /// <summary>
    /// IntProperty: WeaponCache_Case
    /// </summary>
    public unsafe int WeaponCache_Case
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// IntProperty: WeaponCache_Crate
    /// </summary>
    public unsafe int WeaponCache_Crate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// IntProperty: WeaponCache_Container
    /// </summary>
    public unsafe int WeaponCache_Container
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// IntProperty: WeaponCache_Case2
    /// </summary>
    public unsafe int WeaponCache_Case2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// IntProperty: WeaponCache_Crate2
    /// </summary>
    public unsafe int WeaponCache_Crate2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// IntProperty: UnlockedEACID_Clean_Streets
    /// </summary>
    public unsafe int UnlockedEACID_Clean_Streets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// IntProperty: UnlockedEACID_One_Down_Serveral_To_Go
    /// </summary>
    public unsafe int UnlockedEACID_One_Down_Serveral_To_Go
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// IntProperty: UnlockedEACID_Fully_Loaded
    /// </summary>
    public unsafe int UnlockedEACID_Fully_Loaded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }

    /// <summary>
    /// Struct: FGameStat
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FGameStat
    {
        /// <summary>
        /// FloatProperty: Numerator
        /// </summary>
        public unsafe float Numerator
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Divisor
        /// </summary>
        public unsafe float Divisor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Enum: EPercentData
    /// </summary>
    public enum EPercentData : byte
    {
        EPercentData_Grand = 0,
        EPercentData_Story = 1,
        EPercentData_MostWanted_Enigma = 2,
        EPercentData_MostWanted_Anarky = 3,
        EPercentData_MostWanted_Penguin = 4,
        EPercentData_MostWanted_BlackMask = 5,
        EPercentData_MostWanted_Shiva = 6,
        EPercentData_MostWanted_MadHatter = 7,
        EPercentData_MostWanted_DeadShot = 8,
        EPercentData_MostWanted_Bird = 9,
        EPercentData_MostWanted_BlackgatePrisoners = 10,
        EPercentData_DarkKnight_ShadowVigilante = 11,
        EPercentData_DarkKnight_GothamProtector = 12,
        EPercentData_DarkKnight_WorstNightmare = 13,
        EPercentData_DarkKnight_WorldsGreatestDetective = 14,
        EPercentData_DarkKnight_Overall = 15,
        EPercentData_Collectibles_WayneTechUpgrades = 16,
        EPercentData_Collectibles_CharacterBios = 17,
        EPercentData_Collectibles_Towers = 18,
        EPercentData_Collectibles_EnigmaInformants = 19,
        EPercentData_Collectibles_DataPacks = 20,
        EPercentData_Collectibles_SpyNodes = 21,
        EPercentData_Collectibles_AnarkyGraffitis = 22,
        EPercentData_Collectibles_CyrusPinkneySites = 23,
        EPercentData_Collectibles_CrimeScenes = 24,
        EPercentData_Collectibles_CharacterTrophies = 25,
        EPercentData_Collectibles_ConceptArt = 26,
        EPercentData_Collectibles_CharacterSkins = 27,
        EPercentData_Collectibles_Overall = 28,
        EPercentData_Challenges_TrainingMapMedals = 29,
        EPercentData_Challenges_CustomMapMedals = 30,
        EPercentData_Challenges_RankedMapMedals = 31,
        EPercentData_Challenges_CampaingMapMedals = 32,
        EPercentData_Challenges_Overall = 33,
        EPercentData_MAX = 34,
    }

    /// <summary>
    /// Enum: EUnlockableSkin
    /// </summary>
    public enum EUnlockableSkin : byte
    {
        ESkin_None = 0,
        ESkin_Batman = 1,
        ESkin_BrightestDay = 2,
        ESkin_BlackestNight = 3,
        ESkin_New52Graphic = 4,
        ESkin_New52Metallic = 5,
        ESkin_Thrillkiller = 6,
        ESkin_1stAppearance = 7,
        ESkin_LongHalloween = 8,
        ESkin_1Million = 9,
        ESkin_EarthTwo = 10,
        ESkin_GothamByGaslight = 11,
        ESkin_Knightfall = 12,
        ESkin_BatmanClassicTV = 13,
        ESkin_DarkKnightOfTheRoundTable = 14,
        ESkin_RedSon = 15,
        ESkin_Noel = 16,
        ESkin_DarkKnight = 17,
        ESkin_WorstNightmare = 18,
        ESkin_Injustice = 19,
        ESkin_EarthTwoAlt = 20,
        ESkin_Vigilante = 21,
        ESkin_Training = 22,
        ESkin_RobinAlt = 23,
        ESkin_TimDrake1990s = 24,
        ESkin_TimDrake2000s = 25,
        ESkin_Deathstroke = 26,
        ESkin_DS_Injustice = 27,
        ESkin_DS_Judas = 28,
        ESkin_NinjaBruce = 29,
        ESkin_NB_Tengu = 30,
        ESkin_NB_Vigilante = 31,
        ESkin_Extra4 = 32,
        ESkin_Extra5 = 33,
        ESkin_Extra6 = 34,
        ESkin_Extra7 = 35,
        ESkin_Extra8 = 36,
        ESkin_Extra9 = 37,
        ESkin_Extra10 = 38,
        ESkin_MAX = 39,
    }

    /// <summary>
    /// Enum: EGameplayStats
    /// </summary>
    public enum EGameplayStats : byte
    {
        EGameplayStats_Gadget_Grapple = 0,
        EGameplayStats_Gadget_Batarang = 1,
        EGameplayStats_Gadget_ExplosiveGel = 2,
        EGameplayStats_Gadget_Batclaw = 3,
        EGameplayStats_Gadget_CryptoSequencer = 4,
        EGameplayStats_Gadget_RemoteElecCharge = 5,
        EGameplayStats_Gadget_FreezeBlast = 6,
        EGameplayStats_Gadget_GlueGrenade = 7,
        EGameplayStats_Gadget_SmokeBomb = 8,
        EGameplayStats_Gadget_Jammer = 9,
        EGameplayStats_Gadget_LineLauncher = 10,
        EGameplayStats_Gadget_Bullwhip = 11,
        EGameplayStats_Gadget_Staff = 12,
        EGameplayStats_Gadget_ShieldBash = 13,
        EGameplayStats_Gadget_SticksAreaStun = 14,
        EGameplayStats_Gadget_SticksRicochet = 15,
        EGameplayStats_Gadget_WristDart = 16,
        EGameplayStats_Gadget_StickyBomb = 17,
        EGameplayStats_Gadget_ZipKick = 18,
        EGameplayStats_Takedown = 19,
        EGameplayStats_KO_Thug = 20,
        EGameplayStats_KO_Knife = 21,
        EGameplayStats_KO_Pipe = 22,
        EGameplayStats_KO_StunStick = 23,
        EGameplayStats_KO_CombatGun = 24,
        EGameplayStats_KO_PredatorGun = 25,
        EGameplayStats_KO_Sniper = 26,
        EGameplayStats_KO_Lunatic = 27,
        EGameplayStats_KO_Venom = 28,
        EGameplayStats_TimesDied = 29,
        EGameplayStats_AirTravel = 30,
        EGameplayStats_BestGlide = 31,
        EGameplayStats_GroundTravel = 32,
        EGameplayStats_BestCombo = 33,
        EGameplayStats_None = 34,
        EGameplayStats_MAX = 35,
    }

    /// <summary>
    /// Enum: PSharedVersion
    /// </summary>
    public enum PSharedVersion : byte
    {
        PSharedVer_Initial = 0,
        PSharedVer_AddedNEWs = 1,
        PSharedVer_Upgrades = 2,
        PSharedVer_MovedStuff1 = 3,
        PSharedVer_GameplayStats = 4,
        PSharedVer_DLCStory = 5,
        PSharedVer_PercentData = 6,
        PSharedVer_BestSurvivalTime = 7,
        PSharedVer_CityStories = 8,
        PSharedVer_BioSubId = 9,
        PSharedVer_ConceptArt = 10,
        PSharedVer_BestSurvivalTimeRemoved = 11,
        PSharedVer_PlayerRangeBonus = 12,
        PSharedVer_NewGamePlusCombine = 13,
        PSharedVer_NewGamePlusCombine2 = 14,
        PSharedVer_UpgradesMoved = 15,
        PSharedVer_Description = 16,
        PSharedVer_RememberBatmanLevel = 17,
        PSharedVer_RiddlerGridEnabled = 18,
        PSharedVer_BatmanPrequel = 19,
        PSharedVer_DarkKnightChallenges = 20,
        PSharedVer_TrainingExperience = 21,
        PSharedVer_BankedExperience = 22,
        PSharedVer_NewExperience = 23,
        PSharedVer_EnigmaDatasetsRecovered = 24,
        PSharedVer_UpgradesStates = 25,
        PSharedVer_RiddlerDataRemoved = 26,
        PSharedVer_DarkKnightChallenges2 = 27,
        PSharedVer_TotalTimePlayed = 28,
        PSharedVer_AchievementChallenges = 29,
        PSharedVer_GameStats = 30,
        PSharedVer_WeaponCache = 31,
        PSharedVer_CharacterSkins = 32,
        PSharedVer_CharacterBioState = 33,
        PSharedVer_WeaponCache2 = 34,
        PSharedVer_AddedEnigmaHQRiddlerLoc = 35,
        PSharedVer_StoryGadgetLockedByNewGamePlus = 36,
        PSharedVer_AnarkyGraffitisScanned = 37,
        PSharedVer_EnigmaInformantsInterrogated = 38,
        PSharedVer_MovingTowersToPersistentData = 39,
        PSharedVer_TrophyBugBOA53655 = 40,
        PSharedVer_MovedKeyBindsToShared = 41,
        PSharedVer_MAX = 42,
    }
}
