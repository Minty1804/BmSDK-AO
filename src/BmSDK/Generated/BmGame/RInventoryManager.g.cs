#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RInventoryManager<br/>
/// (size = 632)
/// (flags = 142606482)
/// </summary>
public partial class RInventoryManager : BmSDK.Engine.InventoryManager, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RInventoryManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RInventoryManager.
    /// </summary>
    public static RInventoryManager DefaultObject => (RInventoryManager)StaticClass().DefaultObject;

    internal RInventoryManager() { }

    /// <summary>
    /// Constructs a new RInventoryManager
    /// </summary>
    public RInventoryManager(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RInventoryManager(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RInventoryManager>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RInventoryManager>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RInventoryManager>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RInventoryManager>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RInventoryManager>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RInventoryManager>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RInventoryManager>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RInventoryManager>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RInventoryManager.Destroyed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RInventoryManager.Tick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnLevelChange;
    /// <summary>
    /// Function: OnLevelChange
    /// </summary>
    public unsafe virtual void OnLevelChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLevelChange, "BmGame.RInventoryManager.OnLevelChange");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnRoomChange;
    /// <summary>
    /// Function: OnRoomChange
    /// </summary>
    public unsafe virtual void OnRoomChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRoomChange, "BmGame.RInventoryManager.OnRoomChange");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnequipAllGadgets;
    /// <summary>
    /// Function: UnequipAllGadgets
    /// </summary>
    public unsafe virtual void UnequipAllGadgets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnequipAllGadgets, "BmGame.RInventoryManager.UnequipAllGadgets");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryToSelectBatarang;
    /// <summary>
    /// Function: TryToSelectBatarang
    /// </summary>
    public unsafe virtual void TryToSelectBatarang()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToSelectBatarang, "BmGame.RInventoryManager.TryToSelectBatarang");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GadgetCancelled;
    /// <summary>
    /// Function: GadgetCancelled
    /// </summary>
    public unsafe virtual void GadgetCancelled(bool ResetGadget = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GadgetCancelled, "BmGame.RInventoryManager.GadgetCancelled");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResetGadget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugUpgradeEquipment;
    /// <summary>
    /// Function: DebugUpgradeEquipment
    /// </summary>
    public unsafe virtual void DebugUpgradeEquipment()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugUpgradeEquipment, "BmGame.RInventoryManager.DebugUpgradeEquipment");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RestockAmmo;
    /// <summary>
    /// Function: RestockAmmo
    /// </summary>
    public unsafe virtual void RestockAmmo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestockAmmo, "BmGame.RInventoryManager.RestockAmmo");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCurrentGadgetByName;
    /// <summary>
    /// Function: SetCurrentGadgetByName
    /// </summary>
    public unsafe virtual bool SetCurrentGadgetByName(BmSDK.FName SelectedGadgetClass, bool NotifyController = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentGadgetByName, "BmGame.RInventoryManager.SetCurrentGadgetByName");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SelectedGadgetClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NotifyController, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetForQuickGadget;
    /// <summary>
    /// Function: SetForQuickGadget
    /// </summary>
    public unsafe virtual bool SetForQuickGadget(BmSDK.BmGame.RInventoryGadget QuickGadget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetForQuickGadget, "BmGame.RInventoryManager.SetForQuickGadget");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QuickGadget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetGadgetByName;
    /// <summary>
    /// Function: GetGadgetByName
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RInventoryGadget GetGadgetByName(BmSDK.FName SelectedGadgetClass, bool AllowSubClasses = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetByName, "BmGame.RInventoryManager.GetGadgetByName");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SelectedGadgetClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AllowSubClasses, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RInventoryGadget>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetCurrentGadget;
    /// <summary>
    /// Function: SetCurrentGadget
    /// </summary>
    public unsafe virtual bool SetCurrentGadget(BmSDK.BmGame.RInventoryGadget Gadget, bool NotifyController = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentGadget, "BmGame.RInventoryManager.SetCurrentGadget");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Gadget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NotifyController, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetGadgetName;
    /// <summary>
    /// Function: GetGadgetName
    /// </summary>
    public unsafe virtual BmSDK.FName GetGadgetName(int gadget_index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetName, "BmGame.RInventoryManager.GetGadgetName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(gadget_index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AddInventory;
    /// <summary>
    /// Function: AddInventory
    /// </summary>
    public unsafe override bool AddInventory(BmSDK.Engine.Inventory NewItem, bool bDoNotActivate = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddInventory, "BmGame.RInventoryManager.AddInventory");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewItem, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoNotActivate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RInventoryManager.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FGadgetDirection
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FGadgetDirection
    {
        /// <summary>
        /// ArrayProperty: SelectableGadgets
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> SelectableGadgets
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Enum: GadgetSelectionDirection
    /// </summary>
    public enum GadgetSelectionDirection : byte
    {
        GSD_Up = 0,
        GSD_Down = 1,
        GSD_Left = 2,
        GSD_Right = 3,
        GSD_NoGadgetSelected = 4,
        GSD_MAX = 5,
    }

    /// <summary>
    /// ObjectProperty: CurrentGadget
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget CurrentGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// ObjectProperty: PrevGadget
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget PrevGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// IntProperty: DeviceRequestedIndex
    /// </summary>
    public unsafe int DeviceRequestedIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// IntProperty: SelectableGadgetCount
    /// </summary>
    public unsafe int SelectableGadgetCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// ObjectProperty: DisplayedGadget
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget DisplayedGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// ObjectProperty: SockGadgetManager
    /// </summary>
    public unsafe BmSDK.BmGame.MSockGadgetManager SockGadgetManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MSockGadgetManager>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: AvailableGadgets
    /// </summary>
    public InlineArray<BmSDK.BmGame.RInventoryManager.FGadgetDirection> AvailableGadgets => new(4, Ptr + 504, 12, this);

    /// <summary>
    /// StructProperty: AvailableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.RInventoryManager.FGadgetDirection AvailableGadgets_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RInventoryManager.FGadgetDirection>(Ptr + 504);
    /// <summary>
    /// StructProperty: AvailableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.RInventoryManager.FGadgetDirection AvailableGadgets_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RInventoryManager.FGadgetDirection>(Ptr + 516);
    /// <summary>
    /// StructProperty: AvailableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.RInventoryManager.FGadgetDirection AvailableGadgets_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RInventoryManager.FGadgetDirection>(Ptr + 528);
    /// <summary>
    /// StructProperty: AvailableGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.RInventoryManager.FGadgetDirection AvailableGadgets_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RInventoryManager.FGadgetDirection>(Ptr + 540);

    /// <summary>
    /// InlineArray{StructProperty}: BatarangGadgets
    /// </summary>
    public InlineArray<BmSDK.BmGame.RInventoryManager.FGadgetDirection> BatarangGadgets => new(4, Ptr + 552, 12, this);

    /// <summary>
    /// StructProperty: BatarangGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.RInventoryManager.FGadgetDirection BatarangGadgets_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RInventoryManager.FGadgetDirection>(Ptr + 552);
    /// <summary>
    /// StructProperty: BatarangGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.RInventoryManager.FGadgetDirection BatarangGadgets_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RInventoryManager.FGadgetDirection>(Ptr + 564);
    /// <summary>
    /// StructProperty: BatarangGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.RInventoryManager.FGadgetDirection BatarangGadgets_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RInventoryManager.FGadgetDirection>(Ptr + 576);
    /// <summary>
    /// StructProperty: BatarangGadgets
    /// </summary>
    public unsafe ref BmSDK.BmGame.RInventoryManager.FGadgetDirection BatarangGadgets_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RInventoryManager.FGadgetDirection>(Ptr + 588);

    /// <summary>
    /// ByteProperty: CurrentGadgetDir
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryManager.GadgetSelectionDirection CurrentGadgetDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryManager.GadgetSelectionDirection>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// ByteProperty: GadgetSelectSkin
    /// </summary>
    public unsafe byte GadgetSelectSkin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 601); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 601); }
    }

    /// <summary>
    /// IntProperty: CurrentGadgetIndex
    /// </summary>
    public unsafe int CurrentGadgetIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// ArrayProperty: BM2SelectableGadgets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BM2SelectableGadgets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// ArrayProperty: PCSelectableGadgets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> PCSelectableGadgets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }
}
