#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MDatabaseProgressionManager<br/>
/// (size = 72)
/// (flags = 18)
/// </summary>
public partial class MDatabaseProgressionManager : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MDatabaseProgressionManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MDatabaseProgressionManager.
    /// </summary>
    public static MDatabaseProgressionManager DefaultObject => (MDatabaseProgressionManager)StaticClass().DefaultObject;

    internal MDatabaseProgressionManager() { }

    /// <summary>
    /// Constructs a new MDatabaseProgressionManager
    /// </summary>
    public MDatabaseProgressionManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MDatabaseProgressionManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MDatabaseProgressionManager(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MDatabaseProgressionManager>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MDatabaseProgressionManager>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MDatabaseProgressionManager>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MDatabaseProgressionManager>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MDatabaseProgressionManager>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MDatabaseProgressionManager>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MDatabaseProgressionManager>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MDatabaseProgressionManager>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetOngoingInvestigationNumItemsTotal;
    /// <summary>
    /// Function: GetOngoingInvestigationNumItemsTotal
    /// </summary>
    public unsafe virtual int GetOngoingInvestigationNumItemsTotal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOngoingInvestigationNumItemsTotal, "BmGame.MDatabaseProgressionManager.GetOngoingInvestigationNumItemsTotal");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetOngoingInvestigationNumItemsUnlocked;
    /// <summary>
    /// Function: GetOngoingInvestigationNumItemsUnlocked
    /// </summary>
    public unsafe virtual int GetOngoingInvestigationNumItemsUnlocked()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOngoingInvestigationNumItemsUnlocked, "BmGame.MDatabaseProgressionManager.GetOngoingInvestigationNumItemsUnlocked");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetOngoingInvestigationProgressPercentage;
    /// <summary>
    /// Function: GetOngoingInvestigationProgressPercentage
    /// </summary>
    public unsafe virtual int GetOngoingInvestigationProgressPercentage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOngoingInvestigationProgressPercentage, "BmGame.MDatabaseProgressionManager.GetOngoingInvestigationProgressPercentage");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAnarkyNumItemsTotal;
    /// <summary>
    /// Function: GetAnarkyNumItemsTotal
    /// </summary>
    public unsafe virtual int GetAnarkyNumItemsTotal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnarkyNumItemsTotal, "BmGame.MDatabaseProgressionManager.GetAnarkyNumItemsTotal");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAnarkyNumItemsCompleted;
    /// <summary>
    /// Function: GetAnarkyNumItemsCompleted
    /// </summary>
    public unsafe virtual int GetAnarkyNumItemsCompleted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAnarkyNumItemsCompleted, "BmGame.MDatabaseProgressionManager.GetAnarkyNumItemsCompleted");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPinkneyNumItemsTotal;
    /// <summary>
    /// Function: GetPinkneyNumItemsTotal
    /// </summary>
    public unsafe virtual int GetPinkneyNumItemsTotal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPinkneyNumItemsTotal, "BmGame.MDatabaseProgressionManager.GetPinkneyNumItemsTotal");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPinkneyNumItemsCompleted;
    /// <summary>
    /// Function: GetPinkneyNumItemsCompleted
    /// </summary>
    public unsafe virtual int GetPinkneyNumItemsCompleted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPinkneyNumItemsCompleted, "BmGame.MDatabaseProgressionManager.GetPinkneyNumItemsCompleted");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGothamIntelligenceNumItemsTotal;
    /// <summary>
    /// Function: GetGothamIntelligenceNumItemsTotal
    /// </summary>
    public unsafe virtual int GetGothamIntelligenceNumItemsTotal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGothamIntelligenceNumItemsTotal, "BmGame.MDatabaseProgressionManager.GetGothamIntelligenceNumItemsTotal");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGothamIntelligenceNumItemsUnlocked;
    /// <summary>
    /// Function: GetGothamIntelligenceNumItemsUnlocked
    /// </summary>
    public unsafe virtual int GetGothamIntelligenceNumItemsUnlocked()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGothamIntelligenceNumItemsUnlocked, "BmGame.MDatabaseProgressionManager.GetGothamIntelligenceNumItemsUnlocked");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGothamIntelligenceProgressPercentage;
    /// <summary>
    /// Function: GetGothamIntelligenceProgressPercentage
    /// </summary>
    public unsafe virtual int GetGothamIntelligenceProgressPercentage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGothamIntelligenceProgressPercentage, "BmGame.MDatabaseProgressionManager.GetGothamIntelligenceProgressPercentage");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetProfilesNumTapesTotal;
    /// <summary>
    /// Function: GetProfilesNumTapesTotal
    /// </summary>
    public unsafe virtual int GetProfilesNumTapesTotal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProfilesNumTapesTotal, "BmGame.MDatabaseProgressionManager.GetProfilesNumTapesTotal");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetProfilesNumTapesCollected;
    /// <summary>
    /// Function: GetProfilesNumTapesCollected
    /// </summary>
    public unsafe virtual int GetProfilesNumTapesCollected()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProfilesNumTapesCollected, "BmGame.MDatabaseProgressionManager.GetProfilesNumTapesCollected");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetProfilesNumBiosTotal;
    /// <summary>
    /// Function: GetProfilesNumBiosTotal
    /// </summary>
    public unsafe virtual int GetProfilesNumBiosTotal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProfilesNumBiosTotal, "BmGame.MDatabaseProgressionManager.GetProfilesNumBiosTotal");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetProfilesNumBiosCollected;
    /// <summary>
    /// Function: GetProfilesNumBiosCollected
    /// </summary>
    public unsafe virtual int GetProfilesNumBiosCollected()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProfilesNumBiosCollected, "BmGame.MDatabaseProgressionManager.GetProfilesNumBiosCollected");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetProfilesProgressPercentage;
    /// <summary>
    /// Function: GetProfilesProgressPercentage
    /// </summary>
    public unsafe virtual int GetProfilesProgressPercentage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProfilesProgressPercentage, "BmGame.MDatabaseProgressionManager.GetProfilesProgressPercentage");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCrimeReportNumItemsTotal;
    /// <summary>
    /// Function: GetCrimeReportNumItemsTotal
    /// </summary>
    public unsafe virtual int GetCrimeReportNumItemsTotal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCrimeReportNumItemsTotal, "BmGame.MDatabaseProgressionManager.GetCrimeReportNumItemsTotal");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCrimeReportNumItemsCompleted;
    /// <summary>
    /// Function: GetCrimeReportNumItemsCompleted
    /// </summary>
    public unsafe virtual int GetCrimeReportNumItemsCompleted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCrimeReportNumItemsCompleted, "BmGame.MDatabaseProgressionManager.GetCrimeReportNumItemsCompleted");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCrimeReportNumItemsUnlocked;
    /// <summary>
    /// Function: GetCrimeReportNumItemsUnlocked
    /// </summary>
    public unsafe virtual int GetCrimeReportNumItemsUnlocked()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCrimeReportNumItemsUnlocked, "BmGame.MDatabaseProgressionManager.GetCrimeReportNumItemsUnlocked");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsCrimeReportUnlocked;
    /// <summary>
    /// Function: IsCrimeReportUnlocked
    /// </summary>
    public unsafe virtual bool IsCrimeReportUnlocked(BmSDK.FString VolumeName, out BmSDK.FString CrimeSceneName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCrimeReportUnlocked, "BmGame.MDatabaseProgressionManager.IsCrimeReportUnlocked");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VolumeName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CrimeSceneName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetCrimeReportProgressPercentage;
    /// <summary>
    /// Function: GetCrimeReportProgressPercentage
    /// </summary>
    public unsafe virtual int GetCrimeReportProgressPercentage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCrimeReportProgressPercentage, "BmGame.MDatabaseProgressionManager.GetCrimeReportProgressPercentage");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDatabaseProgressPercentage;
    /// <summary>
    /// Function: GetDatabaseProgressPercentage
    /// </summary>
    public unsafe virtual int GetDatabaseProgressPercentage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDatabaseProgressPercentage, "BmGame.MDatabaseProgressionManager.GetDatabaseProgressPercentage");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetPlayerController;
    /// <summary>
    /// Function: SetPlayerController
    /// </summary>
    public unsafe virtual void SetPlayerController(BmSDK.BmGame.RPlayerController RPC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPlayerController, "BmGame.MDatabaseProgressionManager.SetPlayerController");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe virtual void Init()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.MDatabaseProgressionManager.Init");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
    /// ObjectProperty: mGameRepInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI mGameRepInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// ObjectProperty: mPlayerController
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController mPlayerController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// IntProperty: PinkneyScanBegin
    /// </summary>
    public unsafe int PinkneyScanBegin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// IntProperty: PinkneyScanEnd
    /// </summary>
    public unsafe int PinkneyScanEnd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// IntProperty: AnarkyScanBegin
    /// </summary>
    public unsafe int AnarkyScanBegin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// IntProperty: AnarkyScanEnd
    /// </summary>
    public unsafe int AnarkyScanEnd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }
}
