#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDInventorySystem<br/>
/// (size = 208)
/// (flags = 134250646)
/// </summary>
public partial class GDInventorySystem : BmSDK.SDEngine.SDInventorySystem, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDInventorySystem", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDInventorySystem.
    /// </summary>
    public static GDInventorySystem DefaultObject => (GDInventorySystem)StaticClass().DefaultObject;

    internal GDInventorySystem() { }

    /// <summary>
    /// Constructs a new GDInventorySystem
    /// </summary>
    public GDInventorySystem(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDInventorySystem Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDInventorySystem(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDInventorySystem>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDInventorySystem>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDInventorySystem>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDInventorySystem>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDInventorySystem>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDInventorySystem>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDInventorySystem>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDInventorySystem>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetCachedCratePurchaseContents;
    /// <summary>
    /// Function: GetCachedCratePurchaseContents
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.SDEngine.SDInventorySystem.FSDInventoryItemCount> GetCachedCratePurchaseContents()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCachedCratePurchaseContents, "BmGame.GDInventorySystem.GetCachedCratePurchaseContents");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.SDEngine.SDInventorySystem.FSDInventoryItemCount>>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CacheCratePurchaseContents;
    /// <summary>
    /// Function: CacheCratePurchaseContents
    /// </summary>
    public unsafe virtual void CacheCratePurchaseContents(BmSDK.TArray<BmSDK.SDEngine.SDInventorySystem.FSDInventoryItemCount> Contents)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CacheCratePurchaseContents, "BmGame.GDInventorySystem.CacheCratePurchaseContents");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Contents, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetConsumables;
    /// <summary>
    /// Function: ResetConsumables
    /// </summary>
    public unsafe virtual void ResetConsumables()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetConsumables, "BmGame.GDInventorySystem.ResetConsumables");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnConsumeArbitrationComplete;
    /// <summary>
    /// Function: OnConsumeArbitrationComplete
    /// </summary>
    public unsafe virtual void OnConsumeArbitrationComplete(BmSDK.SDEngine.SDArbitrationResult Results, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnConsumeArbitrationComplete, "BmGame.GDInventorySystem.OnConsumeArbitrationComplete");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Results, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnItemCheckArbitrationComplete;
    /// <summary>
    /// Function: OnItemCheckArbitrationComplete
    /// </summary>
    public unsafe virtual void OnItemCheckArbitrationComplete(BmSDK.SDEngine.SDArbitrationResult Results, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnItemCheckArbitrationComplete, "BmGame.GDInventorySystem.OnItemCheckArbitrationComplete");
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Results, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ArbitrateConsumables;
    /// <summary>
    /// Function: ArbitrateConsumables
    /// </summary>
    public unsafe virtual void ArbitrateConsumables(BmSDK.BmGame.GDInventorySystem.GDConsumableArbitrationStep ArbitrationStep)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ArbitrateConsumables, "BmGame.GDInventorySystem.ArbitrateConsumables");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArbitrationStep, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetArbitrationActionForStep;
    /// <summary>
    /// Function: GetArbitrationActionForStep
    /// </summary>
    public unsafe virtual BmSDK.Class GetArbitrationActionForStep(BmSDK.BmGame.GDInventorySystem.GDConsumableArbitrationStep ArbitrationStep)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetArbitrationActionForStep, "BmGame.GDInventorySystem.GetArbitrationActionForStep");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArbitrationStep, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SortConsumablesList;
    /// <summary>
    /// Function: SortConsumablesList
    /// </summary>
    public unsafe virtual int SortConsumablesList(BmSDK.BmGame.GDInventorySystem.FGDConsumableUse A, BmSDK.BmGame.GDInventorySystem.FGDConsumableUse B)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SortConsumablesList, "BmGame.GDInventorySystem.SortConsumablesList");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_SortConsumablesListScript;
    /// <summary>
    /// Function: SortConsumablesListScript
    /// </summary>
    public unsafe virtual int SortConsumablesListScript(BmSDK.BmGame.GDInventorySystem.FGDConsumableUse A, BmSDK.BmGame.GDInventorySystem.FGDConsumableUse B)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SortConsumablesListScript, "BmGame.GDInventorySystem.SortConsumablesListScript");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 40);
    }

    private static BmSDK.Function __fn_AddConsumableArbitrationActions;
    /// <summary>
    /// Function: AddConsumableArbitrationActions
    /// </summary>
    public unsafe virtual void AddConsumableArbitrationActions(BmSDK.BmGame.GDInventorySystem.GDConsumableArbitrationStep ArbitrationStep)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddConsumableArbitrationActions, "BmGame.GDInventorySystem.AddConsumableArbitrationActions");
        byte* paramsPtr = stackalloc byte[132];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArbitrationStep, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetConsumableCategoryID;
    /// <summary>
    /// Function: GetConsumableCategoryID
    /// </summary>
    public unsafe static BmSDK.FString GetConsumableCategoryID(BmSDK.BmGame.GDInventorySystem.GDConsumableType Type)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetConsumableCategoryID, "BmGame.GDInventorySystem.GetConsumableCategoryID");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_StartConsumableArbitration;
    /// <summary>
    /// Function: StartConsumableArbitration
    /// </summary>
    public unsafe virtual void StartConsumableArbitration(BmSDK.BmGame.GDInventorySystem.GDConsumableArbitrationStep ArbitrationStep)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartConsumableArbitration, "BmGame.GDInventorySystem.StartConsumableArbitration");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArbitrationStep, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyConsumables;
    /// <summary>
    /// Function: ApplyConsumables
    /// </summary>
    public unsafe virtual void ApplyConsumables()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyConsumables, "BmGame.GDInventorySystem.ApplyConsumables");
        byte* paramsPtr = stackalloc byte[132];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetConsumableUsageforNetId;
    /// <summary>
    /// Function: GetConsumableUsageforNetId
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDInventorySystem.FSConsumableUsageDetails GetConsumableUsageforNetId(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetConsumableUsageforNetId, "BmGame.GDInventorySystem.GetConsumableUsageforNetId");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDInventorySystem.FSConsumableUsageDetails>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_OnMatchEnd;
    /// <summary>
    /// Function: OnMatchEnd
    /// </summary>
    public unsafe virtual void OnMatchEnd()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnMatchEnd, "BmGame.GDInventorySystem.OnMatchEnd");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnMatchStart;
    /// <summary>
    /// Function: OnMatchStart
    /// </summary>
    public unsafe virtual void OnMatchStart()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnMatchStart, "BmGame.GDInventorySystem.OnMatchStart");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsConsumableValidForNextRound;
    /// <summary>
    /// Function: IsConsumableValidForNextRound
    /// </summary>
    public unsafe virtual bool IsConsumableValidForNextRound(BmSDK.FString FireteamItemId, BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsConsumableValidForNextRound, "BmGame.GDInventorySystem.IsConsumableValidForNextRound");
        byte* paramsPtr = stackalloc byte[132];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireteamItemId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetId, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_RemoveConsumable;
    /// <summary>
    /// Function: RemoveConsumable
    /// </summary>
    public unsafe virtual void RemoveConsumable(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId, BmSDK.FString FireteamItemId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveConsumable, "BmGame.GDInventorySystem.RemoveConsumable");
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireteamItemId, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddConsumable;
    /// <summary>
    /// Function: AddConsumable
    /// </summary>
    public unsafe virtual void AddConsumable(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId, BmSDK.FString FireteamItemId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddConsumable, "BmGame.GDInventorySystem.AddConsumable");
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireteamItemId, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveConsumableFromLocalList;
    /// <summary>
    /// Function: RemoveConsumableFromLocalList
    /// </summary>
    public unsafe virtual bool RemoveConsumableFromLocalList(BmSDK.FString FireteamItemId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveConsumableFromLocalList, "BmGame.GDInventorySystem.RemoveConsumableFromLocalList");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireteamItemId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_AddConsumableToLocalList;
    /// <summary>
    /// Function: AddConsumableToLocalList
    /// </summary>
    public unsafe virtual bool AddConsumableToLocalList(BmSDK.FString FireteamItemId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddConsumableToLocalList, "BmGame.GDInventorySystem.AddConsumableToLocalList");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireteamItemId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetLocalActiveConsumableList;
    /// <summary>
    /// Function: GetLocalActiveConsumableList
    /// </summary>
    public unsafe virtual bool GetLocalActiveConsumableList(out BmSDK.TArray<BmSDK.FString> outFireteamIds)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocalActiveConsumableList, "BmGame.GDInventorySystem.GetLocalActiveConsumableList");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outFireteamIds = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_DeactivateConsumable;
    /// <summary>
    /// Function: DeactivateConsumable
    /// </summary>
    public unsafe virtual void DeactivateConsumable(BmSDK.FString FireteamItemId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeactivateConsumable, "BmGame.GDInventorySystem.DeactivateConsumable");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireteamItemId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateConsumable;
    /// <summary>
    /// Function: ActivateConsumable
    /// </summary>
    public unsafe virtual void ActivateConsumable(BmSDK.FString FireteamItemId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateConsumable, "BmGame.GDInventorySystem.ActivateConsumable");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireteamItemId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSkinOwned;
    /// <summary>
    /// Function: GetSkinOwned
    /// </summary>
    public unsafe virtual bool GetSkinOwned(int UserIndex, in BmSDK.BmGame.GDCharCustomizationManager.FSSkinInfo SkinInfo, out int IsGearPlus)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSkinOwned, "BmGame.GDInventorySystem.GetSkinOwned");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkinInfo, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out IsGearPlus);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsGearPlus, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        IsGearPlus = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 44);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_GetCustomisationItemOwned;
    /// <summary>
    /// Function: GetCustomisationItemOwned
    /// </summary>
    public unsafe virtual bool GetCustomisationItemOwned(int UserIndex, in BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationPartInfo CustomPartInfo, out int IsGearPlus)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCustomisationItemOwned, "BmGame.GDInventorySystem.GetCustomisationItemOwned");
        byte* paramsPtr = stackalloc byte[136];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomPartInfo, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out IsGearPlus);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsGearPlus, paramsPtr + 96);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        IsGearPlus = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 96);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 100);
    }

    private static BmSDK.Function __fn_GetConsumablesAvailable;
    /// <summary>
    /// Function: GetConsumablesAvailable
    /// </summary>
    public unsafe virtual void GetConsumablesAvailable(int UserIndex, out BmSDK.TArray<BmSDK.BmGame.GDInventorySystem.FGDInventoryItem> outConsumableList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetConsumablesAvailable, "BmGame.GDInventorySystem.GetConsumablesAvailable");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UserIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outConsumableList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDInventorySystem.FGDInventoryItem>>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_LogItem;
    /// <summary>
    /// Function: LogItem
    /// </summary>
    public unsafe virtual void LogItem(BmSDK.SDEngine.SDInventoryItem Item, bool bWasSuccessful)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogItem, "BmGame.GDInventorySystem.LogItem");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Item, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 4);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialise, "BmGame.GDInventorySystem.Initialise");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ArrayProperty: ConsumableUseList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDInventorySystem.FGDConsumableUse> ConsumableUseList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDInventorySystem.FGDConsumableUse>>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// ArrayProperty: LocalConsumableUseList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> LocalConsumableUseList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// IntProperty: NumArbitrationResponses
    /// </summary>
    public unsafe int NumArbitrationResponses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: bEnabled
    /// </summary>
    public unsafe bool bEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }
    }

    /// <summary>
    /// ArrayProperty: CachedCrateContentsArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.SDEngine.SDInventorySystem.FSDInventoryItemCount> CachedCrateContentsArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.SDEngine.SDInventorySystem.FSDInventoryItemCount>>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// ArrayProperty: UsageDetails
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDInventorySystem.FSConsumableUsageDetails> UsageDetails
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDInventorySystem.FSConsumableUsageDetails>>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// Enum: GDConsumableArbitrationStep
    /// </summary>
    public enum GDConsumableArbitrationStep : byte
    {
        GDConsumableArbitrationStep_Validate = 0,
        GDConsumableArbitrationStep_Consume = 1,
        GDConsumableArbitrationStep_MAX = 2,
    }

    /// <summary>
    /// Enum: GDConsumableType
    /// </summary>
    public enum GDConsumableType : byte
    {
        ConsumableType_Gameplay = 0,
        ConsumableType_Account = 1,
        ConsumableType_MAX = 2,
    }

    /// <summary>
    /// Struct: FGDConsumableUse
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FGDConsumableUse
    {
        /// <summary>
        /// StructProperty: NetId
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: Consumables
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> Consumables
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FSConsumableUsageDetails
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FSConsumableUsageDetails
    {
        /// <summary>
        /// StructProperty: NetId
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bConsume
        /// </summary>
        public unsafe bool bConsume
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bApply
        /// </summary>
        public unsafe bool bApply
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FGDInventoryItem
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FGDInventoryItem
    {
        /// <summary>
        /// ObjectProperty: Item
        /// </summary>
        public unsafe BmSDK.SDEngine.SDInventoryItem Item
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.SDEngine.SDInventoryItem>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: ItemData
        /// </summary>
        public unsafe BmSDK.BmGame.GDInventoryDataObject ItemData
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDInventoryDataObject>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: Count
        /// </summary>
        public unsafe int Count
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }
}
