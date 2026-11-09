#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MPawnPlayerJoker<br/>
/// (size = 6336)
/// (flags = 10485814)
/// </summary>
public partial class MPawnPlayerJoker : BmSDK.BmGame.RPawnPlayer, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MPawnPlayerJoker", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MPawnPlayerJoker.
    /// </summary>
    public static MPawnPlayerJoker DefaultObject => (MPawnPlayerJoker)StaticClass().DefaultObject;

    internal MPawnPlayerJoker() { }

    /// <summary>
    /// Constructs a new MPawnPlayerJoker
    /// </summary>
    public MPawnPlayerJoker(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MPawnPlayerJoker(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerJoker>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerJoker>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerJoker>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerJoker>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerJoker>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerJoker>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerJoker>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerJoker>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetUnlockedMeleeArmourLevel;
    /// <summary>
    /// Function: GetUnlockedMeleeArmourLevel
    /// </summary>
    public unsafe override int GetUnlockedMeleeArmourLevel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUnlockedMeleeArmourLevel, "BmScript.MPawnPlayerJoker.GetUnlockedMeleeArmourLevel");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetUnlockedBallisticArmourLevel;
    /// <summary>
    /// Function: GetUnlockedBallisticArmourLevel
    /// </summary>
    public unsafe override int GetUnlockedBallisticArmourLevel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUnlockedBallisticArmourLevel, "BmScript.MPawnPlayerJoker.GetUnlockedBallisticArmourLevel");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetPersistentMeleeArmour;
    /// <summary>
    /// Function: SetPersistentMeleeArmour
    /// </summary>
    public unsafe override void SetPersistentMeleeArmour(int armour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPersistentMeleeArmour, "BmScript.MPawnPlayerJoker.SetPersistentMeleeArmour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(armour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPersistentBallisticArmour;
    /// <summary>
    /// Function: SetPersistentBallisticArmour
    /// </summary>
    public unsafe override void SetPersistentBallisticArmour(int armour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPersistentBallisticArmour, "BmScript.MPawnPlayerJoker.SetPersistentBallisticArmour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(armour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPersistentMeleeArmour;
    /// <summary>
    /// Function: GetPersistentMeleeArmour
    /// </summary>
    public unsafe override int GetPersistentMeleeArmour()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPersistentMeleeArmour, "BmScript.MPawnPlayerJoker.GetPersistentMeleeArmour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPersistentBallisticArmour;
    /// <summary>
    /// Function: GetPersistentBallisticArmour
    /// </summary>
    public unsafe override int GetPersistentBallisticArmour()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPersistentBallisticArmour, "BmScript.MPawnPlayerJoker.GetPersistentBallisticArmour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DebugGiveAllGadgets;
    /// <summary>
    /// Function: DebugGiveAllGadgets
    /// </summary>
    public unsafe override void DebugGiveAllGadgets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugGiveAllGadgets, "BmScript.MPawnPlayerJoker.DebugGiveAllGadgets");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddDefaultInventory;
    /// <summary>
    /// Function: AddDefaultInventory
    /// </summary>
    public unsafe override void AddDefaultInventory()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDefaultInventory, "BmScript.MPawnPlayerJoker.AddDefaultInventory");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FakeUnarmedCombatThugRef;
    /// <summary>
    /// Function: FakeUnarmedCombatThugRef
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet FakeUnarmedCombatThugRef()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FakeUnarmedCombatThugRef, "BmScript.MPawnPlayerJoker.FakeUnarmedCombatThugRef");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FakeUnarmedCombatThugRefHolder;
    /// <summary>
    /// Function: FakeUnarmedCombatThugRefHolder
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RCharacterBioCue FakeUnarmedCombatThugRefHolder()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FakeUnarmedCombatThugRefHolder, "BmScript.MPawnPlayerJoker.FakeUnarmedCombatThugRefHolder");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCharacterBioCue>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AddJokerCardMovesToWeaponConfig;
    /// <summary>
    /// Function: AddJokerCardMovesToWeaponConfig
    /// </summary>
    public unsafe virtual void AddJokerCardMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddJokerCardMovesToWeaponConfig, "BmScript.MPawnPlayerJoker.AddJokerCardMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[2700];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddMovementMovesToWeaponConfig;
    /// <summary>
    /// Function: AddMovementMovesToWeaponConfig
    /// </summary>
    public unsafe override void AddMovementMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddMovementMovesToWeaponConfig, "BmScript.MPawnPlayerJoker.AddMovementMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[368];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ModifyExistingPoses;
    /// <summary>
    /// Function: ModifyExistingPoses
    /// </summary>
    public unsafe virtual void ModifyExistingPoses(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyExistingPoses, "BmScript.MPawnPlayerJoker.ModifyExistingPoses");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAfterCombatAnimset;
    /// <summary>
    /// Function: GetAfterCombatAnimset
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetAfterCombatAnimset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAfterCombatAnimset, "BmScript.MPawnPlayerJoker.GetAfterCombatAnimset");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FindContactName;
    /// <summary>
    /// Function: FindContactName
    /// </summary>
    public unsafe override BmSDK.Engine.AkEvent FindContactName(BmSDK.BmGame.RAnimNotify_Footstep.EFoot Foot, BmSDK.BmGame.RAnimNotify_Footstep.EContactType Contact)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindContactName, "BmScript.MPawnPlayerJoker.FindContactName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Foot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Contact, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetXpSequenceAkEventClass;
    /// <summary>
    /// Function: GetXpSequenceAkEventClass
    /// </summary>
    public unsafe override BmSDK.Engine.AkEvent GetXpSequenceAkEventClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetXpSequenceAkEventClass, "BmScript.MPawnPlayerJoker.GetXpSequenceAkEventClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetXpSequenceClass;
    /// <summary>
    /// Function: GetXpSequenceClass
    /// </summary>
    public unsafe override BmSDK.Class GetXpSequenceClass(int XPAwarded, BmSDK.Engine.Actor XPTarget, BmSDK.BmGame.RGameInfo.EGameAction Type)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetXpSequenceClass, "BmScript.MPawnPlayerJoker.GetXpSequenceClass");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPAwarded, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPTarget, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetupCustomPhysics;
    /// <summary>
    /// Function: SetupCustomPhysics
    /// </summary>
    public unsafe override void SetupCustomPhysics()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupCustomPhysics, "BmScript.MPawnPlayerJoker.SetupCustomPhysics");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetStunMove;
    /// <summary>
    /// Function: GetStunMove
    /// </summary>
    public unsafe override BmSDK.Class GetStunMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStunMove, "BmScript.MPawnPlayerJoker.GetStunMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRedirectStumbleBehaviour;
    /// <summary>
    /// Function: GetRedirectStumbleBehaviour
    /// </summary>
    public unsafe override BmSDK.Class GetRedirectStumbleBehaviour()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRedirectStumbleBehaviour, "BmScript.MPawnPlayerJoker.GetRedirectStumbleBehaviour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetFloorTakedownType;
    /// <summary>
    /// Function: GetFloorTakedownType
    /// </summary>
    public unsafe override BmSDK.Class GetFloorTakedownType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFloorTakedownType, "BmScript.MPawnPlayerJoker.GetFloorTakedownType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetQuickStrikeType;
    /// <summary>
    /// Function: GetQuickStrikeType
    /// </summary>
    public unsafe override BmSDK.Class GetQuickStrikeType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetQuickStrikeType, "BmScript.MPawnPlayerJoker.GetQuickStrikeType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHeavyStrikeType;
    /// <summary>
    /// Function: GetHeavyStrikeType
    /// </summary>
    public unsafe override BmSDK.Class GetHeavyStrikeType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeavyStrikeType, "BmScript.MPawnPlayerJoker.GetHeavyStrikeType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CounterClass;
    /// <summary>
    /// Function: CounterClass
    /// </summary>
    public unsafe override BmSDK.Class CounterClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CounterClass, "BmScript.MPawnPlayerJoker.CounterClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    /// <summary>
    /// Enum: EJokerGadgetList
    /// </summary>
    public enum EJokerGadgetList : byte
    {
        JKGL_RazorCard = 0,
        JKGL_RictusGrinCards = 1,
        JKGL_RazorCard_MultiTarget = 2,
        JKGL_StunCards = 3,
        JKGL_ReservedByClaw = 4,
        JKGL_ChatteringTeeth = 5,
        JKGL_JackInABox = 6,
        JKGL_Gun = 7,
        JKGL_Flower = 8,
        JKGL_JoyBuzzer = 9,
        JKGL_SmokeBomb = 10,
        JKGL_RemoteBomb = 11,
        JKGL_MAX = 12,
    }

    /// <summary>
    /// ObjectProperty: CurrentEnvironmentTakedown
    /// </summary>
    public unsafe BmSDK.Engine.Actor CurrentEnvironmentTakedown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 6332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6332); }
    }
}
