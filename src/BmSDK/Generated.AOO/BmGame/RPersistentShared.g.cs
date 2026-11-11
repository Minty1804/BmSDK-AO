#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPersistentShared<br/>
/// (size = 680)
/// (flags = 134250642)
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

    private static BmSDK.Function __fn_GetRiddlerProgressionProportion;
    /// <summary>
    /// Function: GetRiddlerProgressionProportion
    /// </summary>
    public unsafe virtual float GetRiddlerProgressionProportion()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRiddlerProgressionProportion, "BmGame.RPersistentShared.GetRiddlerProgressionProportion");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRiddlerProgressionAbsolute;
    /// <summary>
    /// Function: GetRiddlerProgressionAbsolute
    /// </summary>
    public unsafe virtual int GetRiddlerProgressionAbsolute()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRiddlerProgressionAbsolute, "BmGame.RPersistentShared.GetRiddlerProgressionAbsolute");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AllCamerasBroken;
    /// <summary>
    /// Function: AllCamerasBroken
    /// </summary>
    public unsafe virtual bool AllCamerasBroken()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllCamerasBroken, "BmGame.RPersistentShared.AllCamerasBroken");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetCameraBroken;
    /// <summary>
    /// Function: SetCameraBroken
    /// </summary>
    public unsafe virtual int SetCameraBroken(BmSDK.BmGame.RPersistentData.ERiddlerLocationName Zone)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCameraBroken, "BmGame.RPersistentShared.SetCameraBroken");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Zone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IncreasePenguinBrokenCount;
    /// <summary>
    /// Function: IncreasePenguinBrokenCount
    /// </summary>
    public unsafe virtual int IncreasePenguinBrokenCount(BmSDK.BmGame.RPersistentData.ERiddlerLocationName Zone)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncreasePenguinBrokenCount, "BmGame.RPersistentShared.IncreasePenguinBrokenCount");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Zone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IncreaseJokerBalloonPoppedCount;
    /// <summary>
    /// Function: IncreaseJokerBalloonPoppedCount
    /// </summary>
    public unsafe virtual int IncreaseJokerBalloonPoppedCount(BmSDK.BmGame.RPersistentData.ERiddlerLocationName Zone)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncreaseJokerBalloonPoppedCount, "BmGame.RPersistentShared.IncreaseJokerBalloonPoppedCount");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Zone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IncreaseJokerTeethCount;
    /// <summary>
    /// Function: IncreaseJokerTeethCount
    /// </summary>
    public unsafe virtual int IncreaseJokerTeethCount(BmSDK.BmGame.RPersistentData.ERiddlerLocationName Zone)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncreaseJokerTeethCount, "BmGame.RPersistentShared.IncreaseJokerTeethCount");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Zone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IncreaseRiddleCount;
    /// <summary>
    /// Function: IncreaseRiddleCount
    /// </summary>
    public unsafe virtual int IncreaseRiddleCount(BmSDK.BmGame.RPersistentData.ERiddlerLocationName Zone)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncreaseRiddleCount, "BmGame.RPersistentShared.IncreaseRiddleCount");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Zone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CWJewelleryTotal;
    /// <summary>
    /// Function: CWJewelleryTotal
    /// </summary>
    public unsafe virtual int CWJewelleryTotal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CWJewelleryTotal, "BmGame.RPersistentShared.CWJewelleryTotal");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CWTotalPossiblePickupsAndChallenges;
    /// <summary>
    /// Function: CWTotalPossiblePickupsAndChallenges
    /// </summary>
    public unsafe virtual int CWTotalPossiblePickupsAndChallenges()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CWTotalPossiblePickupsAndChallenges, "BmGame.RPersistentShared.CWTotalPossiblePickupsAndChallenges");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CWPickupsAndChallengesCompleteCount;
    /// <summary>
    /// Function: CWPickupsAndChallengesCompleteCount
    /// </summary>
    public unsafe virtual int CWPickupsAndChallengesCompleteCount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CWPickupsAndChallengesCompleteCount, "BmGame.RPersistentShared.CWPickupsAndChallengesCompleteCount");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CWPickupsAndChallengesComplete;
    /// <summary>
    /// Function: CWPickupsAndChallengesComplete
    /// </summary>
    public unsafe virtual bool CWPickupsAndChallengesComplete()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CWPickupsAndChallengesComplete, "BmGame.RPersistentShared.CWPickupsAndChallengesComplete");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCWPickupsTotalCollected;
    /// <summary>
    /// Function: GetCWPickupsTotalCollected
    /// </summary>
    public unsafe virtual int GetCWPickupsTotalCollected()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCWPickupsTotalCollected, "BmGame.RPersistentShared.GetCWPickupsTotalCollected");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IncreaseCWPickupCount;
    /// <summary>
    /// Function: IncreaseCWPickupCount
    /// </summary>
    public unsafe virtual int IncreaseCWPickupCount(BmSDK.BmGame.RPersistentData.ERiddlerLocationName Zone)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncreaseCWPickupCount, "BmGame.RPersistentShared.IncreaseCWPickupCount");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Zone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IncreasePickupCount;
    /// <summary>
    /// Function: IncreasePickupCount
    /// </summary>
    public unsafe virtual int IncreasePickupCount(BmSDK.BmGame.RPersistentData.ERiddlerLocationName Zone)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncreasePickupCount, "BmGame.RPersistentShared.IncreasePickupCount");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Zone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IncreaseBrokenDemonSealCount;
    /// <summary>
    /// Function: IncreaseBrokenDemonSealCount
    /// </summary>
    public unsafe virtual int IncreaseBrokenDemonSealCount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncreaseBrokenDemonSealCount, "BmGame.RPersistentShared.IncreaseBrokenDemonSealCount");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IncreaseBrokenHarleyHeadCount;
    /// <summary>
    /// Function: IncreaseBrokenHarleyHeadCount
    /// </summary>
    public unsafe virtual int IncreaseBrokenHarleyHeadCount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncreaseBrokenHarleyHeadCount, "BmGame.RPersistentShared.IncreaseBrokenHarleyHeadCount");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateBatChallenge;
    /// <summary>
    /// Function: UpdateBatChallenge
    /// </summary>
    public unsafe virtual void UpdateBatChallenge(BmSDK.BmGame.RPersistentData.EBatmanChallenge Entry, float inValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateBatChallenge, "BmGame.RPersistentShared.UpdateBatChallenge");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Entry, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inValue, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsBatChallengeAsBeaten;
    /// <summary>
    /// Function: IsBatChallengeAsBeaten
    /// </summary>
    public unsafe virtual bool IsBatChallengeAsBeaten(BmSDK.BmGame.RPersistentData.EBatmanChallenge Entry)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBatChallengeAsBeaten, "BmGame.RPersistentShared.IsBatChallengeAsBeaten");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Entry, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetBatChallengeAsBeaten;
    /// <summary>
    /// Function: SetBatChallengeAsBeaten
    /// </summary>
    public unsafe virtual void SetBatChallengeAsBeaten(BmSDK.BmGame.RPersistentData.EBatmanChallenge Entry)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBatChallengeAsBeaten, "BmGame.RPersistentShared.SetBatChallengeAsBeaten");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Entry, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBatChallengeValueNeeded;
    /// <summary>
    /// Function: GetBatChallengeValueNeeded
    /// </summary>
    public unsafe virtual float GetBatChallengeValueNeeded(BmSDK.BmGame.RPersistentData.EBatmanChallenge Entry)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatChallengeValueNeeded, "BmGame.RPersistentShared.GetBatChallengeValueNeeded");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Entry, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetBatChallengeValueBest;
    /// <summary>
    /// Function: GetBatChallengeValueBest
    /// </summary>
    public unsafe virtual float GetBatChallengeValueBest(BmSDK.BmGame.RPersistentData.EBatmanChallenge Entry)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatChallengeValueBest, "BmGame.RPersistentShared.GetBatChallengeValueBest");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Entry, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetBatChallengeValueCurrent;
    /// <summary>
    /// Function: GetBatChallengeValueCurrent
    /// </summary>
    public unsafe virtual float GetBatChallengeValueCurrent(BmSDK.BmGame.RPersistentData.EBatmanChallenge Entry)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatChallengeValueCurrent, "BmGame.RPersistentShared.GetBatChallengeValueCurrent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Entry, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetRiddlerLocationDataValue;
    /// <summary>
    /// Function: GetRiddlerLocationDataValue
    /// </summary>
    public unsafe virtual int GetRiddlerLocationDataValue(int LocIndex, int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRiddlerLocationDataValue, "BmGame.RPersistentShared.GetRiddlerLocationDataValue");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetRiddlerLocationData;
    /// <summary>
    /// Function: SetRiddlerLocationData
    /// </summary>
    public unsafe virtual void SetRiddlerLocationData(int LocIndex, int Index, int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRiddlerLocationData, "BmGame.RPersistentShared.SetRiddlerLocationData");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRiddlerLocationData;
    /// <summary>
    /// Function: GetRiddlerLocationData
    /// </summary>
    public unsafe virtual BmSDK.TArray<int> GetRiddlerLocationData(int LocIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRiddlerLocationData, "BmGame.RPersistentShared.GetRiddlerLocationData");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<int>>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsRiddlerAreaUnlocked;
    /// <summary>
    /// Function: IsRiddlerAreaUnlocked
    /// </summary>
    public unsafe virtual bool IsRiddlerAreaUnlocked(int LocIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRiddlerAreaUnlocked, "BmGame.RPersistentShared.IsRiddlerAreaUnlocked");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UnlockRiddlerArea;
    /// <summary>
    /// Function: UnlockRiddlerArea
    /// </summary>
    public unsafe virtual void UnlockRiddlerArea(int LocIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockRiddlerArea, "BmGame.RPersistentShared.UnlockRiddlerArea");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearRiddlerAreaNew;
    /// <summary>
    /// Function: ClearRiddlerAreaNew
    /// </summary>
    public unsafe virtual void ClearRiddlerAreaNew(int LocIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRiddlerAreaNew, "BmGame.RPersistentShared.ClearRiddlerAreaNew");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRiddlerTotalCount;
    /// <summary>
    /// Function: GetRiddlerTotalCount
    /// </summary>
    public unsafe virtual int GetRiddlerTotalCount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRiddlerTotalCount, "BmGame.RPersistentShared.GetRiddlerTotalCount");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRiddlerAreaTotalCount;
    /// <summary>
    /// Function: GetRiddlerAreaTotalCount
    /// </summary>
    public unsafe virtual int GetRiddlerAreaTotalCount(int LocIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRiddlerAreaTotalCount, "BmGame.RPersistentShared.GetRiddlerAreaTotalCount");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_Set_PercentEntry;
    /// <summary>
    /// Function: Set_PercentEntry
    /// </summary>
    public unsafe virtual void Set_PercentEntry(bool bPlus, BmSDK.BmGame.RPersistentShared.EPercentData Item, float Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Set_PercentEntry, "BmGame.RPersistentShared.Set_PercentEntry");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlus, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Item, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Get_PercentEntry;
    /// <summary>
    /// Function: Get_PercentEntry
    /// </summary>
    public unsafe virtual float Get_PercentEntry(bool bPlus, BmSDK.BmGame.RPersistentShared.EPercentData Item)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Get_PercentEntry, "BmGame.RPersistentShared.Get_PercentEntry");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlus, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Item, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ClearStoryNew;
    /// <summary>
    /// Function: ClearStoryNew
    /// </summary>
    public unsafe virtual void ClearStoryNew(int Uid)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearStoryNew, "BmGame.RPersistentShared.ClearStoryNew");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Uid, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsStoryNew;
    /// <summary>
    /// Function: IsStoryNew
    /// </summary>
    public unsafe virtual bool IsStoryNew(int Uid)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsStoryNew, "BmGame.RPersistentShared.IsStoryNew");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Uid, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CountCityStoryNew;
    /// <summary>
    /// Function: CountCityStoryNew
    /// </summary>
    public unsafe virtual int CountCityStoryNew(int StartAt, int Count)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CountCityStoryNew, "BmGame.RPersistentShared.CountCityStoryNew");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartAt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Count, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_MarkOffCityStory;
    /// <summary>
    /// Function: MarkOffCityStory
    /// </summary>
    public unsafe virtual void MarkOffCityStory(int CityStoryId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MarkOffCityStory, "BmGame.RPersistentShared.MarkOffCityStory");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CityStoryId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CountBiosNew;
    /// <summary>
    /// Function: CountBiosNew
    /// </summary>
    public unsafe virtual int CountBiosNew()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CountBiosNew, "BmGame.RPersistentShared.CountBiosNew");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CountOfBiosUnlocked;
    /// <summary>
    /// Function: CountOfBiosUnlocked
    /// </summary>
    public unsafe virtual int CountOfBiosUnlocked()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CountOfBiosUnlocked, "BmGame.RPersistentShared.CountOfBiosUnlocked");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsBioUnlocked;
    /// <summary>
    /// Function: IsBioUnlocked
    /// </summary>
    public unsafe virtual bool IsBioUnlocked(BmSDK.BmGame.RPersistentData.EBioCharacter inBio)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBioUnlocked, "BmGame.RPersistentShared.IsBioUnlocked");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inBio, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_Dump;
    /// <summary>
    /// Function: Dump
    /// </summary>
    public unsafe virtual void Dump()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Dump, "BmGame.RPersistentShared.Dump");
        byte* paramsPtr = stackalloc byte[53];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpStats;
    /// <summary>
    /// Function: DumpStats
    /// </summary>
    public unsafe virtual void DumpStats()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpStats, "BmGame.RPersistentShared.DumpStats");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PadStr;
    /// <summary>
    /// Function: PadStr
    /// </summary>
    public unsafe virtual BmSDK.FString PadStr(BmSDK.FString InStr, int DesiredLen)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PadStr, "BmGame.RPersistentShared.PadStr");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InStr, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredLen, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_FloatArrayToString;
    /// <summary>
    /// Function: FloatArrayToString
    /// </summary>
    public unsafe virtual BmSDK.FString FloatArrayToString(BmSDK.TArray<float> Values)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FloatArrayToString, "BmGame.RPersistentShared.FloatArrayToString");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Values, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_IntArrayToString;
    /// <summary>
    /// Function: IntArrayToString
    /// </summary>
    public unsafe virtual BmSDK.FString IntArrayToString(BmSDK.TArray<int> Values)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IntArrayToString, "BmGame.RPersistentShared.IntArrayToString");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Values, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ByteArrayToString;
    /// <summary>
    /// Function: ByteArrayToString
    /// </summary>
    public unsafe virtual BmSDK.FString ByteArrayToString(BmSDK.TArray<byte> Values)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ByteArrayToString, "BmGame.RPersistentShared.ByteArrayToString");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Values, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_IsSharedFlagSet;
    /// <summary>
    /// Function: IsSharedFlagSet
    /// </summary>
    public unsafe virtual bool IsSharedFlagSet(BmSDK.FString FlagName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSharedFlagSet, "BmGame.RPersistentShared.IsSharedFlagSet");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlagName, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetSharedFlag;
    /// <summary>
    /// Function: SetSharedFlag
    /// </summary>
    public unsafe virtual void SetSharedFlag(BmSDK.FString FlagName, bool bTrue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSharedFlag, "BmGame.RPersistentShared.SetSharedFlag");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// StrProperty: Description
    /// </summary>
    public unsafe BmSDK.FString Description
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// ArrayProperty: SharedFlags
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> SharedFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// ArrayProperty: Upgrades
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> Upgrades
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }

    /// <summary>
    /// IntProperty: NumUpgrades
    /// </summary>
    public unsafe int NumUpgrades
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// ArrayProperty: CatwomanEpisodes_New
    /// </summary>
    public unsafe BmSDK.TArray<byte> CatwomanEpisodes_New
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ArrayProperty: CatwomanEpisodes_Unlocked
    /// </summary>
    public unsafe BmSDK.TArray<byte> CatwomanEpisodes_Unlocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ArrayProperty: CharacterBios_New
    /// </summary>
    public unsafe BmSDK.TArray<byte> CharacterBios_New
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ArrayProperty: CharacterBios_SubId
    /// </summary>
    public unsafe BmSDK.TArray<byte> CharacterBios_SubId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// ArrayProperty: CharacterBios_Unlocked
    /// </summary>
    public unsafe BmSDK.TArray<byte> CharacterBios_Unlocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ArrayProperty: CharacterViewer_New
    /// </summary>
    public unsafe BmSDK.TArray<byte> CharacterViewer_New
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// ArrayProperty: CharacterViewer_Unlocked
    /// </summary>
    public unsafe BmSDK.TArray<byte> CharacterViewer_Unlocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ArrayProperty: GalleryUnlocks_New
    /// </summary>
    public unsafe BmSDK.TArray<byte> GalleryUnlocks_New
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// ArrayProperty: GalleryUnlocks
    /// </summary>
    public unsafe BmSDK.TArray<byte> GalleryUnlocks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ArrayProperty: Upgrades_New
    /// </summary>
    public unsafe BmSDK.TArray<byte> Upgrades_New
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// ArrayProperty: DLCStory_New
    /// </summary>
    public unsafe BmSDK.TArray<byte> DLCStory_New
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// ArrayProperty: DLCStory_Status
    /// </summary>
    public unsafe BmSDK.TArray<byte> DLCStory_Status
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// ArrayProperty: CityStories
    /// </summary>
    public unsafe BmSDK.TArray<int> CityStories
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// ArrayProperty: LinkedCityStories
    /// </summary>
    public unsafe BmSDK.TArray<int> LinkedCityStories
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// ArrayProperty: GameplayStats
    /// </summary>
    public unsafe BmSDK.TArray<float> GameplayStats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ArrayProperty: PercentStats_Game
    /// </summary>
    public unsafe BmSDK.TArray<float> PercentStats_Game
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// ArrayProperty: PercentStats_GamePlus
    /// </summary>
    public unsafe BmSDK.TArray<float> PercentStats_GamePlus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// FloatProperty: Player_RangeBonus
    /// </summary>
    public unsafe float Player_RangeBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_AreaTotals
    /// </summary>
    public unsafe BmSDK.TArray<byte> RiddlerData_AreaTotals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_Rows
    /// </summary>
    public unsafe BmSDK.TArray<byte> RiddlerData_Rows
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_AreasNew
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_AreasNew
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_AreasLocked
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_AreasLocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_OverworldA
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_OverworldA
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_OverworldB
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_OverworldB
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_OverworldC
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_OverworldC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_OverworldD
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_OverworldD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_OverworldE
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_OverworldE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_Steel
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_Steel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_Museum
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_Museum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_Underworld
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_Underworld
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerData_Batman
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerData_Batman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// ArrayProperty: PickupTallys
    /// </summary>
    public unsafe BmSDK.TArray<int> PickupTallys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ArrayProperty: CWPickupTallys
    /// </summary>
    public unsafe BmSDK.TArray<int> CWPickupTallys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// ArrayProperty: JokerTeethPickupTallys
    /// </summary>
    public unsafe BmSDK.TArray<int> JokerTeethPickupTallys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// ArrayProperty: CharacterTapesCollected
    /// </summary>
    public unsafe BmSDK.TArray<int> CharacterTapesCollected
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// ArrayProperty: CharacterTapesMax
    /// </summary>
    public unsafe BmSDK.TArray<int> CharacterTapesMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// ArrayProperty: TapesCollected
    /// </summary>
    public unsafe BmSDK.TArray<int> TapesCollected
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// ArrayProperty: JokerBalloonTallys
    /// </summary>
    public unsafe BmSDK.TArray<int> JokerBalloonTallys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// ArrayProperty: BrokenPenguinTallys
    /// </summary>
    public unsafe BmSDK.TArray<int> BrokenPenguinTallys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// ArrayProperty: BrokenCameraTallys
    /// </summary>
    public unsafe BmSDK.TArray<int> BrokenCameraTallys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// ArrayProperty: RiddleTallys
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddleTallys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// IntProperty: BrokenHarleyHeadTally
    /// </summary>
    public unsafe int BrokenHarleyHeadTally
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// IntProperty: BrokenDemonSealTally
    /// </summary>
    public unsafe int BrokenDemonSealTally
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// IntProperty: BrokenGrundyHeadTally
    /// </summary>
    public unsafe int BrokenGrundyHeadTally
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// IntProperty: PickupCount
    /// </summary>
    public unsafe int PickupCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// IntProperty: PickupRevealsLeft
    /// </summary>
    public unsafe int PickupRevealsLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// IntProperty: InterrogatesLeft
    /// </summary>
    public unsafe int InterrogatesLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// IntProperty: NumCamerasBroken
    /// </summary>
    public unsafe int NumCamerasBroken
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// IntProperty: InterrogatesPerformed
    /// </summary>
    public unsafe int InterrogatesPerformed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// IntProperty: InterrogatesWithTutorialPerformed
    /// </summary>
    public unsafe int InterrogatesWithTutorialPerformed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// ArrayProperty: BatChallengeCurrent
    /// </summary>
    public unsafe BmSDK.TArray<float> BatChallengeCurrent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// ArrayProperty: BatChallengeBest
    /// </summary>
    public unsafe BmSDK.TArray<float> BatChallengeBest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// ArrayProperty: BatChallengeNeeded
    /// </summary>
    public unsafe BmSDK.TArray<float> BatChallengeNeeded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// ArrayProperty: BatChallengeBeaten
    /// </summary>
    public unsafe BmSDK.TArray<int> BatChallengeBeaten
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// IntProperty: UpgradesBought
    /// </summary>
    public unsafe int UpgradesBought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// IntProperty: CW_UpgradesBought
    /// </summary>
    public unsafe int CW_UpgradesBought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// IntProperty: UnlockablesToSpend
    /// </summary>
    public unsafe int UnlockablesToSpend
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// IntProperty: ShowLevelUpFlag
    /// </summary>
    public unsafe int ShowLevelUpFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// IntProperty: RiddlerGridEnabled
    /// </summary>
    public unsafe int RiddlerGridEnabled
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// Enum: EPercentData
    /// </summary>
    public enum EPercentData : byte
    {
        EPercentData_Grand = 0,
        EPercentData_Story = 1,
        EPercentData_Azrael = 2,
        EPercentData_Bane = 3,
        EPercentData_DeadShot = 4,
        EPercentData_Hush = 5,
        EPercentData_Mad_Hatter = 6,
        EPercentData_Nora = 7,
        EPercentData_Riddler = 8,
        EPercentData_Zsasz = 9,
        EPercentData_Bullies = 10,
        EPercentData_ARTraining = 11,
        EPercentData_IceBergCops = 12,
        EPercentData_FreezeCluster = 13,
        EPercentData_SideTotal = 14,
        EPercentData_Riddles = 15,
        EPercentData_Upgrades = 16,
        EPercentData_Bios = 17,
        EPercentData_Trophies = 18,
        EPercentData_Arts = 19,
        EPercentData_Collect_Total = 20,
        EPercentData_CW_Trophies = 21,
        EPercentData_CW_Upgrades = 22,
        EPercentData_CW_Loot = 23,
        EPercentData_CW_Total = 24,
        EPercentData_Riddler_Medals = 25,
        EPercentData_Riddler_MedalsOf = 26,
        EPercentData_Riddler_Camp_Medals = 27,
        EPercentData_Riddler_Camp_MedalsOf = 28,
        EPercentData_Riddler_Total = 29,
        EPercentData_RiddlerDLC_Batman_Medals = 30,
        EPercentData_RiddlerDLC_Batman_MedalsOf = 31,
        EPercentData_RiddlerDLC_Batman_Camp_Medals = 32,
        EPercentData_RiddlerDLC_Batman_Camp_MedalsOf = 33,
        EPercentData_RiddlerDLC_Catwoman_Medals = 34,
        EPercentData_RiddlerDLC_Catwoman_MedalsOf = 35,
        EPercentData_RiddlerDLC_Catwoman_Camp_Medals = 36,
        EPercentData_RiddlerDLC_Catwoman_Camp_MedalsOf = 37,
        EPercentData_RiddlerDLC_Robin_Medals = 38,
        EPercentData_RiddlerDLC_Robin_MedalsOf = 39,
        EPercentData_RiddlerDLC_Robin_Camp_Medals = 40,
        EPercentData_RiddlerDLC_Robin_Camp_MedalsOf = 41,
        EPercentData_RiddlerDLC_NightWing_Medals = 42,
        EPercentData_RiddlerDLC_NightWing_MedalsOf = 43,
        EPercentData_RiddlerDLC_NightWing_Camp_Medals = 44,
        EPercentData_RiddlerDLC_NightWing_Camp_MedalsOf = 45,
        EPercentData_RiddlerDLC_Total = 46,
        EPercentData_Episode1_Trophies = 47,
        EPercentData_Episode1_TrophiesOf = 48,
        EPercentData_Episode1_Story = 49,
        EPercentData_Episode1_Total = 50,
        EPercentData_MAX = 51,
    }

    /// <summary>
    /// Enum: EGameplayStats
    /// </summary>
    public enum EGameplayStats : byte
    {
        EGameplayStats_DistanceFlown = 0,
        EGameplayStats_MAX = 1,
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
        PSharedVer_MAX = 19,
    }
}
