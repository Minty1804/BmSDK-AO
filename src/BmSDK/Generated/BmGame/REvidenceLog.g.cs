#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: REvidenceLog<br/>
/// (size = 88)
/// (flags = 134217874)
/// </summary>
public partial class REvidenceLog : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.REvidenceLog", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as REvidenceLog.
    /// </summary>
    public static REvidenceLog DefaultObject => (REvidenceLog)StaticClass().DefaultObject;

    internal REvidenceLog() { }

    /// <summary>
    /// Constructs a new REvidenceLog
    /// </summary>
    public REvidenceLog(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, REvidenceLog Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected REvidenceLog(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<REvidenceLog>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<REvidenceLog>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<REvidenceLog>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<REvidenceLog>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<REvidenceLog>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<REvidenceLog>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<REvidenceLog>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<REvidenceLog>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetEvidenceScanned;
    /// <summary>
    /// Function: SetEvidenceScanned
    /// </summary>
    public unsafe virtual bool SetEvidenceScanned(BmSDK.BmGame.REvidenceInterface evidence)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetEvidenceScanned, "BmGame.REvidenceLog.SetEvidenceScanned");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(evidence, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ResetEvidenceScanned;
    /// <summary>
    /// Function: ResetEvidenceScanned
    /// </summary>
    public unsafe virtual void ResetEvidenceScanned(BmSDK.BmGame.RForensicDnaSplatStatic DNASplat, BmSDK.BmGame.RCrimeSceneBase CrimeVolume)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetEvidenceScanned, "BmGame.REvidenceLog.ResetEvidenceScanned");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DNASplat, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CrimeVolume, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsRoomUnlocked;
    /// <summary>
    /// Function: IsRoomUnlocked
    /// </summary>
    public unsafe virtual bool IsRoomUnlocked(BmSDK.FString roomName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRoomUnlocked, "BmGame.REvidenceLog.IsRoomUnlocked");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(roomName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetRoomUnlocked;
    /// <summary>
    /// Function: SetRoomUnlocked
    /// </summary>
    public unsafe virtual void SetRoomUnlocked(BmSDK.BmGame.RCrimeSceneBase CrimeSceneVolume, bool bUnlock, BmSDK.BmGame.RPlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRoomUnlocked, "BmGame.REvidenceLog.SetRoomUnlocked");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CrimeSceneVolume, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUnlock, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasEvidenceBeenScanned;
    /// <summary>
    /// Function: HasEvidenceBeenScanned
    /// </summary>
    public unsafe virtual bool HasEvidenceBeenScanned(BmSDK.BmGame.RForensicDnaSplatStatic DNASplat, BmSDK.BmGame.RCrimeSceneBase OverrideVolume = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasEvidenceBeenScanned, "BmGame.REvidenceLog.HasEvidenceBeenScanned");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DNASplat, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideVolume, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetGlobalFlagName;
    /// <summary>
    /// Function: GetGlobalFlagName
    /// </summary>
    public unsafe virtual BmSDK.FString GetGlobalFlagName(BmSDK.BmGame.RForensicDnaSplatStatic DNASplat, BmSDK.BmGame.RCrimeSceneBase OverrideVolume = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGlobalFlagName, "BmGame.REvidenceLog.GetGlobalFlagName");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DNASplat, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideVolume, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetFilterName;
    /// <summary>
    /// Function: GetFilterName
    /// </summary>
    public unsafe virtual BmSDK.FString GetFilterName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFilterName, "BmGame.REvidenceLog.GetFilterName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DeleteFilterAndAwardXp;
    /// <summary>
    /// Function: DeleteFilterAndAwardXp
    /// </summary>
    public unsafe virtual void DeleteFilterAndAwardXp()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeleteFilterAndAwardXp, "BmGame.REvidenceLog.DeleteFilterAndAwardXp");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetOwner;
    /// <summary>
    /// Function: SetOwner
    /// </summary>
    public unsafe virtual void SetOwner(BmSDK.BmGame.RPlayerController Owner)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOwner, "BmGame.REvidenceLog.SetOwner");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Owner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: Controller
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController Controller
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// ArrayProperty: EvidenceItems
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.REvidence> EvidenceItems
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.REvidence>>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// ArrayProperty: RoomNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> RoomNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// StrProperty: LastEvidence
    /// </summary>
    public unsafe BmSDK.FString LastEvidence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }

    /// <summary>
    /// FloatProperty: TimeToDisplayEvidenceFound
    /// </summary>
    public unsafe float TimeToDisplayEvidenceFound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
