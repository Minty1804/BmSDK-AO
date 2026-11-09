#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPawnPlayerBm<br/>
/// (size = 6964)
/// (flags = 10486326)
/// </summary>
public partial class RPawnPlayerBm : BmSDK.BmGame.RPawnPlayerBmBase, BmSDK.BmGame.RXrayInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnPlayerBm", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnPlayerBm.
    /// </summary>
    public static RPawnPlayerBm DefaultObject => (RPawnPlayerBm)StaticClass().DefaultObject;

    internal RPawnPlayerBm() { }

    /// <summary>
    /// Constructs a new RPawnPlayerBm
    /// </summary>
    public RPawnPlayerBm(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayerBm(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBm>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBm>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBm>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBm>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBm>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBm>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBm>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBm>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetXpSequenceClass;
    /// <summary>
    /// Function: GetXpSequenceClass
    /// </summary>
    public unsafe override BmSDK.Class GetXpSequenceClass(int XPAwarded, BmSDK.Engine.Actor XPTarget, BmSDK.BmGame.RGameInfo.EGameAction Type)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetXpSequenceClass, "BmScript.RPawnPlayerBm.GetXpSequenceClass");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPAwarded, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPTarget, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ReloadHUD;
    /// <summary>
    /// Function: ReloadHUD
    /// </summary>
    public unsafe virtual void ReloadHUD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReloadHUD, "BmScript.RPawnPlayerBm.ReloadHUD");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TogglePrototypeGadget;
    /// <summary>
    /// Function: TogglePrototypeGadget
    /// </summary>
    public unsafe override void TogglePrototypeGadget(bool useBM2Gadgets)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TogglePrototypeGadget, "BmScript.RPawnPlayerBm.TogglePrototypeGadget");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(useBM2Gadgets, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChangeQuickGadgets;
    /// <summary>
    /// Function: ChangeQuickGadgets
    /// </summary>
    public unsafe override void ChangeQuickGadgets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeQuickGadgets, "BmScript.RPawnPlayerBm.ChangeQuickGadgets");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCheatGadget;
    /// <summary>
    /// Function: GetCheatGadget
    /// </summary>
    public unsafe virtual int GetCheatGadget(int CheatIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCheatGadget, "BmScript.RPawnPlayerBm.GetCheatGadget");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheatIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PlayCapeSoftLandFX;
    /// <summary>
    /// Function: PlayCapeSoftLandFX
    /// </summary>
    public unsafe virtual void PlayCapeSoftLandFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCapeSoftLandFX, "BmScript.RPawnPlayerBm.PlayCapeSoftLandFX");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayCollapseEmote;
    /// <summary>
    /// Function: PlayCollapseEmote
    /// </summary>
    public unsafe virtual void PlayCollapseEmote()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCollapseEmote, "BmScript.RPawnPlayerBm.PlayCollapseEmote");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetFailedPairedAnimMoveAnimset;
    /// <summary>
    /// Function: GetFailedPairedAnimMoveAnimset
    /// </summary>
    public unsafe override void GetFailedPairedAnimMoveAnimset(out BmSDK.Engine.AnimSet MyAnimset, BmSDK.BmGame.RPawnCombat OtherPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFailedPairedAnimMoveAnimset, "BmScript.RPawnPlayerBm.GetFailedPairedAnimMoveAnimset");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MyAnimset);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MyAnimset, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherPawn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        MyAnimset = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_PlayHurtEmote;
    /// <summary>
    /// Function: PlayHurtEmote
    /// </summary>
    public unsafe override void PlayHurtEmote(float RandChance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHurtEmote, "BmScript.RPawnPlayerBm.PlayHurtEmote");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RandChance, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BreakNewGamePlusLine;
    /// <summary>
    /// Function: BreakNewGamePlusLine
    /// </summary>
    public unsafe virtual void BreakNewGamePlusLine()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BreakNewGamePlusLine, "BmScript.RPawnPlayerBm.BreakNewGamePlusLine");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayWouldBreakNewGamePlusLine;
    /// <summary>
    /// Function: PlayWouldBreakNewGamePlusLine
    /// </summary>
    public unsafe override void PlayWouldBreakNewGamePlusLine()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayWouldBreakNewGamePlusLine, "BmScript.RPawnPlayerBm.PlayWouldBreakNewGamePlusLine");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnBatclawSlam;
    /// <summary>
    /// Function: SpawnBatclawSlam
    /// </summary>
    public unsafe override void SpawnBatclawSlam(BmSDK.BmGame.RPawnCombat TargetPawn, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnBatclawSlam, "BmScript.RPawnPlayerBm.SpawnBatclawSlam");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayedHostageInDangerLine;
    /// <summary>
    /// Function: PlayedHostageInDangerLine
    /// </summary>
    public unsafe virtual void PlayedHostageInDangerLine()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayedHostageInDangerLine, "BmScript.RPawnPlayerBm.PlayedHostageInDangerLine");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayFirstNetworkNode;
    /// <summary>
    /// Function: PlayFirstNetworkNode
    /// </summary>
    public unsafe override void PlayFirstNetworkNode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFirstNetworkNode, "BmScript.RPawnPlayerBm.PlayFirstNetworkNode");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayFirstDatapack;
    /// <summary>
    /// Function: PlayFirstDatapack
    /// </summary>
    public unsafe override void PlayFirstDatapack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFirstDatapack, "BmScript.RPawnPlayerBm.PlayFirstDatapack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriedToUseGadgetOnHostageTaker;
    /// <summary>
    /// Function: TriedToUseGadgetOnHostageTaker
    /// </summary>
    public unsafe override void TriedToUseGadgetOnHostageTaker()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriedToUseGadgetOnHostageTaker, "BmScript.RPawnPlayerBm.TriedToUseGadgetOnHostageTaker");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetUnlockedMeleeArmourLevel;
    /// <summary>
    /// Function: GetUnlockedMeleeArmourLevel
    /// </summary>
    public unsafe override int GetUnlockedMeleeArmourLevel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUnlockedMeleeArmourLevel, "BmScript.RPawnPlayerBm.GetUnlockedMeleeArmourLevel");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUnlockedBallisticArmourLevel, "BmScript.RPawnPlayerBm.GetUnlockedBallisticArmourLevel");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPersistentMeleeArmour, "BmScript.RPawnPlayerBm.SetPersistentMeleeArmour");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPersistentBallisticArmour, "BmScript.RPawnPlayerBm.SetPersistentBallisticArmour");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPersistentMeleeArmour, "BmScript.RPawnPlayerBm.GetPersistentMeleeArmour");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPersistentBallisticArmour, "BmScript.RPawnPlayerBm.GetPersistentBallisticArmour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GiveUnlockableGadget;
    /// <summary>
    /// Function: GiveUnlockableGadget
    /// </summary>
    public unsafe override void GiveUnlockableGadget(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility UnlockName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveUnlockableGadget, "BmScript.RPawnPlayerBm.GiveUnlockableGadget");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockName, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FakeUnarmedCombatThugRef, "BmScript.RPawnPlayerBm.FakeUnarmedCombatThugRef");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FakeUnarmedCombatThugRefHolder, "BmScript.RPawnPlayerBm.FakeUnarmedCombatThugRefHolder");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCharacterBioCue>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ThrowFatalBatarang;
    /// <summary>
    /// Function: ThrowFatalBatarang
    /// </summary>
    public unsafe override void ThrowFatalBatarang(BmSDK.BmGame.RPawnVillain Victim, System.Numerics.Vector3 TargetLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThrowFatalBatarang, "BmScript.RPawnPlayerBm.ThrowFatalBatarang");
        byte* paramsPtr = stackalloc byte[104];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetContactCharacterName;
    /// <summary>
    /// Function: GetContactCharacterName
    /// </summary>
    public unsafe override BmSDK.FString GetContactCharacterName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetContactCharacterName, "BmScript.RPawnPlayerBm.GetContactCharacterName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FindContactName;
    /// <summary>
    /// Function: FindContactName
    /// </summary>
    public unsafe override BmSDK.Engine.AkEvent FindContactName(BmSDK.BmGame.RAnimNotify_Footstep.EFoot Foot, BmSDK.BmGame.RAnimNotify_Footstep.EContactType Contact)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindContactName, "BmScript.RPawnPlayerBm.FindContactName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Foot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Contact, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UpdateInvClass;
    /// <summary>
    /// Function: UpdateInvClass
    /// </summary>
    public unsafe override BmSDK.Class UpdateInvClass(BmSDK.Class InvClass)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateInvClass, "BmScript.RPawnPlayerBm.UpdateInvClass");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InvClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_InvestigateModeEyes;
    /// <summary>
    /// Function: InvestigateModeEyes
    /// </summary>
    public unsafe override void InvestigateModeEyes(bool bOnOrOff)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InvestigateModeEyes, "BmScript.RPawnPlayerBm.InvestigateModeEyes");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnOrOff, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EyeMaterialUpdated;
    /// <summary>
    /// Function: EyeMaterialUpdated
    /// </summary>
    public unsafe override void EyeMaterialUpdated()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EyeMaterialUpdated, "BmScript.RPawnPlayerBm.EyeMaterialUpdated");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddRemoteClawMovesToWeaponConfig;
    /// <summary>
    /// Function: AddRemoteClawMovesToWeaponConfig
    /// </summary>
    public unsafe virtual void AddRemoteClawMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddRemoteClawMovesToWeaponConfig, "BmScript.RPawnPlayerBm.AddRemoteClawMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[2848];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddSmokeBombMovesToWeaponConfig;
    /// <summary>
    /// Function: AddSmokeBombMovesToWeaponConfig
    /// </summary>
    public unsafe virtual void AddSmokeBombMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddSmokeBombMovesToWeaponConfig, "BmScript.RPawnPlayerBm.AddSmokeBombMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[3260];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddShockGlovesMovesToWeaponConfig;
    /// <summary>
    /// Function: AddShockGlovesMovesToWeaponConfig
    /// </summary>
    public unsafe virtual void AddShockGlovesMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddShockGlovesMovesToWeaponConfig, "BmScript.RPawnPlayerBm.AddShockGlovesMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[372];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddLineLauncherMovesToWeaponConfig;
    /// <summary>
    /// Function: AddLineLauncherMovesToWeaponConfig
    /// </summary>
    public unsafe virtual void AddLineLauncherMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLineLauncherMovesToWeaponConfig, "BmScript.RPawnPlayerBm.AddLineLauncherMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[1476];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddExplosiveGelAndDetonatorMovesToWeaponConfig;
    /// <summary>
    /// Function: AddExplosiveGelAndDetonatorMovesToWeaponConfig
    /// </summary>
    public unsafe virtual void AddExplosiveGelAndDetonatorMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddExplosiveGelAndDetonatorMovesToWeaponConfig, "BmScript.RPawnPlayerBm.AddExplosiveGelAndDetonatorMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[2020];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddFreezeClusterMovesToWeaponConfig;
    /// <summary>
    /// Function: AddFreezeClusterMovesToWeaponConfig
    /// </summary>
    public unsafe virtual void AddFreezeClusterMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddFreezeClusterMovesToWeaponConfig, "BmScript.RPawnPlayerBm.AddFreezeClusterMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[2988];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddFreezeBlastMovesToWeaponConfig;
    /// <summary>
    /// Function: AddFreezeBlastMovesToWeaponConfig
    /// </summary>
    public unsafe virtual void AddFreezeBlastMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddFreezeBlastMovesToWeaponConfig, "BmScript.RPawnPlayerBm.AddFreezeBlastMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[2988];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddMagneticBlastMovesToWeaponConfig;
    /// <summary>
    /// Function: AddMagneticBlastMovesToWeaponConfig
    /// </summary>
    public unsafe virtual void AddMagneticBlastMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddMagneticBlastMovesToWeaponConfig, "BmScript.RPawnPlayerBm.AddMagneticBlastMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[2848];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddJammerGadgetMovesToWeaponConfig;
    /// <summary>
    /// Function: AddJammerGadgetMovesToWeaponConfig
    /// </summary>
    public unsafe virtual void AddJammerGadgetMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddJammerGadgetMovesToWeaponConfig, "BmScript.RPawnPlayerBm.AddJammerGadgetMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[5136];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddResonatorMovesToWeaponConfig;
    /// <summary>
    /// Function: AddResonatorMovesToWeaponConfig
    /// </summary>
    public unsafe virtual void AddResonatorMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddResonatorMovesToWeaponConfig, "BmScript.RPawnPlayerBm.AddResonatorMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[992];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddCapeMovesToWeaponConfig;
    /// <summary>
    /// Function: AddCapeMovesToWeaponConfig
    /// </summary>
    public unsafe virtual void AddCapeMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCapeMovesToWeaponConfig, "BmScript.RPawnPlayerBm.AddCapeMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[2312];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddBatarangMovesToWeaponConfig;
    /// <summary>
    /// Function: AddBatarangMovesToWeaponConfig
    /// </summary>
    public unsafe virtual void AddBatarangMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddBatarangMovesToWeaponConfig, "BmScript.RPawnPlayerBm.AddBatarangMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[3668];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddHarpoonMovesToWeaponConfig;
    /// <summary>
    /// Function: AddHarpoonMovesToWeaponConfig
    /// </summary>
    public unsafe virtual void AddHarpoonMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddHarpoonMovesToWeaponConfig, "BmScript.RPawnPlayerBm.AddHarpoonMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[2368];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddGrappleMovesToWeaponConfig;
    /// <summary>
    /// Function: AddGrappleMovesToWeaponConfig
    /// </summary>
    public unsafe virtual void AddGrappleMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddGrappleMovesToWeaponConfig, "BmScript.RPawnPlayerBm.AddGrappleMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[2100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddBatmanMovesToWeaponConfig;
    /// <summary>
    /// Function: AddBatmanMovesToWeaponConfig
    /// </summary>
    public unsafe virtual void AddBatmanMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddBatmanMovesToWeaponConfig, "BmScript.RPawnPlayerBm.AddBatmanMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[1068];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupWirePoses;
    /// <summary>
    /// Function: SetupWirePoses
    /// </summary>
    public unsafe virtual void SetupWirePoses(BmSDK.BmGame.RPoseConfig PoseConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupWirePoses, "BmScript.RPawnPlayerBm.SetupWirePoses");
        byte* paramsPtr = stackalloc byte[716];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PoseConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChangeWalksToGadgetWalks;
    /// <summary>
    /// Function: ChangeWalksToGadgetWalks
    /// </summary>
    public unsafe virtual void ChangeWalksToGadgetWalks(out BmSDK.BmGame.RPoseConfig.FPose InOut)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeWalksToGadgetWalks, "BmScript.RPawnPlayerBm.ChangeWalksToGadgetWalks");
        byte* paramsPtr = stackalloc byte[368];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        InOut = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_UnPossessed;
    /// <summary>
    /// Function: UnPossessed
    /// </summary>
    public unsafe override void UnPossessed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnPossessed, "BmScript.RPawnPlayerBm.UnPossessed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PossessedBy;
    /// <summary>
    /// Function: PossessedBy
    /// </summary>
    public unsafe override void PossessedBy(BmSDK.Engine.Controller C, bool bVehicleTransition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PossessedBy, "BmScript.RPawnPlayerBm.PossessedBy");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVehicleTransition, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetThoughts;
    /// <summary>
    /// Function: GetThoughts
    /// </summary>
    public unsafe override void GetThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThoughts, "BmScript.RPawnPlayerBm.GetThoughts");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SetInXrayMode;
    /// <summary>
    /// Function: SetInXrayMode
    /// </summary>
    public unsafe virtual void SetInXrayMode(bool On, bool bForceOff)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInXrayMode, "BmScript.RPawnPlayerBm.SetInXrayMode");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TakeFallingDamage;
    /// <summary>
    /// Function: TakeFallingDamage
    /// </summary>
    public unsafe override void TakeFallingDamage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeFallingDamage, "BmScript.RPawnPlayerBm.TakeFallingDamage");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugGiveSmokeBomb;
    /// <summary>
    /// Function: DebugGiveSmokeBomb
    /// </summary>
    public unsafe override void DebugGiveSmokeBomb()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugGiveSmokeBomb, "BmScript.RPawnPlayerBm.DebugGiveSmokeBomb");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugGiveShockGloves;
    /// <summary>
    /// Function: DebugGiveShockGloves
    /// </summary>
    public unsafe override void DebugGiveShockGloves()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugGiveShockGloves, "BmScript.RPawnPlayerBm.DebugGiveShockGloves");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugGiveWeaponDisruptor;
    /// <summary>
    /// Function: DebugGiveWeaponDisruptor
    /// </summary>
    public unsafe override void DebugGiveWeaponDisruptor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugGiveWeaponDisruptor, "BmScript.RPawnPlayerBm.DebugGiveWeaponDisruptor");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugGiveStunGrenade;
    /// <summary>
    /// Function: DebugGiveStunGrenade
    /// </summary>
    public unsafe override void DebugGiveStunGrenade()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugGiveStunGrenade, "BmScript.RPawnPlayerBm.DebugGiveStunGrenade");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugGiveSonicBatarang;
    /// <summary>
    /// Function: DebugGiveSonicBatarang
    /// </summary>
    public unsafe override void DebugGiveSonicBatarang()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugGiveSonicBatarang, "BmScript.RPawnPlayerBm.DebugGiveSonicBatarang");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugGiveGlueGrenade;
    /// <summary>
    /// Function: DebugGiveGlueGrenade
    /// </summary>
    public unsafe override void DebugGiveGlueGrenade()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugGiveGlueGrenade, "BmScript.RPawnPlayerBm.DebugGiveGlueGrenade");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugUpgradeDualClaw;
    /// <summary>
    /// Function: DebugUpgradeDualClaw
    /// </summary>
    public unsafe override void DebugUpgradeDualClaw(int NewUpgradeLevel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugUpgradeDualClaw, "BmScript.RPawnPlayerBm.DebugUpgradeDualClaw");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewUpgradeLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugGiveMultiTargetBatarang;
    /// <summary>
    /// Function: DebugGiveMultiTargetBatarang
    /// </summary>
    public unsafe override void DebugGiveMultiTargetBatarang()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugGiveMultiTargetBatarang, "BmScript.RPawnPlayerBm.DebugGiveMultiTargetBatarang");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugGiveDualClaw;
    /// <summary>
    /// Function: DebugGiveDualClaw
    /// </summary>
    public unsafe override void DebugGiveDualClaw()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugGiveDualClaw, "BmScript.RPawnPlayerBm.DebugGiveDualClaw");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugGiveAllGadgets;
    /// <summary>
    /// Function: DebugGiveAllGadgets
    /// </summary>
    public unsafe override void DebugGiveAllGadgets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugGiveAllGadgets, "BmScript.RPawnPlayerBm.DebugGiveAllGadgets");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddDefaultInventoryAfterInit;
    /// <summary>
    /// Function: AddDefaultInventoryAfterInit
    /// </summary>
    public unsafe override void AddDefaultInventoryAfterInit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDefaultInventoryAfterInit, "BmScript.RPawnPlayerBm.AddDefaultInventoryAfterInit");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateExtraAmmoUpgrade;
    /// <summary>
    /// Function: UpdateExtraAmmoUpgrade
    /// </summary>
    public unsafe override void UpdateExtraAmmoUpgrade()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateExtraAmmoUpgrade, "BmScript.RPawnPlayerBm.UpdateExtraAmmoUpgrade");
        byte* paramsPtr = stackalloc byte[20];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDefaultInventory, "BmScript.RPawnPlayerBm.AddDefaultInventory");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetOwnerNoSee;
    /// <summary>
    /// Function: SetOwnerNoSee
    /// </summary>
    public unsafe override void SetOwnerNoSee(bool bNewOwnerNoSee)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOwnerNoSee, "BmScript.RPawnPlayerBm.SetOwnerNoSee");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewOwnerNoSee, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetHidden;
    /// <summary>
    /// Function: SetHidden
    /// </summary>
    public unsafe override void SetHidden(bool bNewHidden)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHidden, "BmScript.RPawnPlayerBm.SetHidden");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewHidden, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPlayerHasBeenMoved;
    /// <summary>
    /// Function: OnPlayerHasBeenMoved
    /// </summary>
    public unsafe override void OnPlayerHasBeenMoved()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPlayerHasBeenMoved, "BmScript.RPawnPlayerBm.OnPlayerHasBeenMoved");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachTransparentSkeletalMesh;
    /// <summary>
    /// Function: AttachTransparentSkeletalMesh
    /// </summary>
    public unsafe virtual BmSDK.Engine.SkeletalMeshComponent AttachTransparentSkeletalMesh(BmSDK.Engine.SkeletalMesh SkeletalMesh, BmSDK.Engine.SkeletalMeshComponent ParentAnimComponent, BmSDK.Engine.MaterialInterface OverrideMaterial = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachTransparentSkeletalMesh, "BmScript.RPawnPlayerBm.AttachTransparentSkeletalMesh");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkeletalMesh, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParentAnimComponent, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideMaterial, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.SkeletalMeshComponent>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_RemoveCloakingAura;
    /// <summary>
    /// Function: RemoveCloakingAura
    /// </summary>
    public unsafe virtual void RemoveCloakingAura()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveCloakingAura, "BmScript.RPawnPlayerBm.RemoveCloakingAura");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateCloakingAura;
    /// <summary>
    /// Function: ActivateCloakingAura
    /// </summary>
    public unsafe virtual void ActivateCloakingAura(BmSDK.Engine.MaterialInterface AuraMat)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateCloakingAura, "BmScript.RPawnPlayerBm.ActivateCloakingAura");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AuraMat, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerHeatConcealEffect;
    /// <summary>
    /// Function: TriggerHeatConcealEffect
    /// </summary>
    public unsafe override void TriggerHeatConcealEffect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerHeatConcealEffect, "BmScript.RPawnPlayerBm.TriggerHeatConcealEffect");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmScript.RPawnPlayerBm.Tick");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnFogSphere;
    /// <summary>
    /// Function: SpawnFogSphere
    /// </summary>
    public unsafe override BmSDK.Engine.FogVolumeSphericalDensityInfo SpawnFogSphere(BmSDK.Class RaftType, System.Numerics.Vector3 SpawnLocation, BmSDK.Rotator SpawnRotation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnFogSphere, "BmScript.RPawnPlayerBm.SpawnFogSphere");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RaftType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRotation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.FogVolumeSphericalDensityInfo>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_GetCameraGrappleSnowFx;
    /// <summary>
    /// Function: GetCameraGrappleSnowFx
    /// </summary>
    public unsafe override BmSDK.BmGame.RBMCameraEmitter GetCameraGrappleSnowFx()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCameraGrappleSnowFx, "BmScript.RPawnPlayerBm.GetCameraGrappleSnowFx");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMCameraEmitter>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmScript.RPawnPlayerBm.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmScript.RPawnPlayerBm.Destroyed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreStreamOut;
    /// <summary>
    /// Function: PreStreamOut
    /// </summary>
    public unsafe override void PreStreamOut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmScript.RPawnPlayerBm.PreStreamOut");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyExistingPoses, "BmScript.RPawnPlayerBm.ModifyExistingPoses");
        byte* paramsPtr = stackalloc byte[36];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddMovementMovesToWeaponConfig, "BmScript.RPawnPlayerBm.AddMovementMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[156];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Landed;
    /// <summary>
    /// Function: Landed
    /// </summary>
    public unsafe override void Landed(System.Numerics.Vector3 HitNormal, BmSDK.Engine.Actor FloorActor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Landed, "BmScript.RPawnPlayerBm.Landed");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FloorActor, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HitWall;
    /// <summary>
    /// Function: HitWall
    /// </summary>
    public unsafe override void HitWall(System.Numerics.Vector3 HitNormal, BmSDK.Engine.Actor Wall, BmSDK.Engine.PrimitiveComponent WallComp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitWall, "BmScript.RPawnPlayerBm.HitWall");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Wall, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallComp, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Bump;
    /// <summary>
    /// Function: Bump
    /// </summary>
    public unsafe override void Bump(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Bump, "BmScript.RPawnPlayerBm.Bump");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckDemonDeath;
    /// <summary>
    /// Function: CheckDemonDeath
    /// </summary>
    public unsafe virtual bool CheckDemonDeath(BmSDK.Engine.Actor HitObj)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckDemonDeath, "BmScript.RPawnPlayerBm.CheckDemonDeath");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitObj, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetRedirectStumbleBehaviour;
    /// <summary>
    /// Function: GetRedirectStumbleBehaviour
    /// </summary>
    public unsafe override BmSDK.Class GetRedirectStumbleBehaviour()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRedirectStumbleBehaviour, "BmScript.RPawnPlayerBm.GetRedirectStumbleBehaviour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetOpenTowerDoorOutsideMove;
    /// <summary>
    /// Function: GetOpenTowerDoorOutsideMove
    /// </summary>
    public unsafe override BmSDK.BmGame.RSpecialMoveConfig GetOpenTowerDoorOutsideMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOpenTowerDoorOutsideMove, "BmScript.RPawnPlayerBm.GetOpenTowerDoorOutsideMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetOpenGrateOutsideMove;
    /// <summary>
    /// Function: GetOpenGrateOutsideMove
    /// </summary>
    public unsafe override BmSDK.BmGame.RSpecialMoveConfig GetOpenGrateOutsideMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOpenGrateOutsideMove, "BmScript.RPawnPlayerBm.GetOpenGrateOutsideMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetOpenGrateInsideMove;
    /// <summary>
    /// Function: GetOpenGrateInsideMove
    /// </summary>
    public unsafe override BmSDK.BmGame.RSpecialMoveConfig GetOpenGrateInsideMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOpenGrateInsideMove, "BmScript.RPawnPlayerBm.GetOpenGrateInsideMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHarpoonOpenGrateMove;
    /// <summary>
    /// Function: GetHarpoonOpenGrateMove
    /// </summary>
    public unsafe override BmSDK.BmGame.RSpecialMoveConfig GetHarpoonOpenGrateMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHarpoonOpenGrateMove, "BmScript.RPawnPlayerBm.GetHarpoonOpenGrateMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DeactivateArmScreen;
    /// <summary>
    /// Function: DeactivateArmScreen
    /// </summary>
    public unsafe virtual void DeactivateArmScreen()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeactivateArmScreen, "BmScript.RPawnPlayerBm.DeactivateArmScreen");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateArmScreen;
    /// <summary>
    /// Function: ActivateArmScreen
    /// </summary>
    public unsafe virtual void ActivateArmScreen()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateArmScreen, "BmScript.RPawnPlayerBm.ActivateArmScreen");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreBeginPlay;
    /// <summary>
    /// Function: PreBeginPlay
    /// </summary>
    public unsafe override void PreBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreBeginPlay, "BmScript.RPawnPlayerBm.PreBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SideCamActive;
    /// <summary>
    /// Function: SideCamActive
    /// </summary>
    public unsafe virtual void SideCamActive()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SideCamActive, "BmScript.RPawnPlayerBm.SideCamActive");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: DarkKnightChallenges
    /// </summary>
    public unsafe BmSDK.BmGame.MDarkKnightChallengesSettings DarkKnightChallenges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MDarkKnightChallengesSettings>(Ptr + 6440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6440); }
    }

    /// <summary>
    /// ObjectProperty: AchievementChallenges
    /// </summary>
    public unsafe BmSDK.BmGame.MAchievementChallengesSettings AchievementChallenges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MAchievementChallengesSettings>(Ptr + 6444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6444); }
    }

    /// <summary>
    /// BoolProperty: bTempDebugReAddDefaultInventory
    /// </summary>
    public unsafe bool bTempDebugReAddDefaultInventory
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6448) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6448); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6448); }
    }

    /// <summary>
    /// FloatProperty: CloakingDuration
    /// </summary>
    public unsafe float CloakingDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6452); }
    }

    /// <summary>
    /// FloatProperty: CloakingBlend
    /// </summary>
    public unsafe float CloakingBlend
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6456); }
    }

    /// <summary>
    /// ObjectProperty: FaceMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant FaceMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 6460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6460); }
    }

    /// <summary>
    /// ObjectProperty: CloakingMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant CloakingMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 6464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6464); }
    }

    /// <summary>
    /// ClassProperty: IceSphereClass
    /// </summary>
    public unsafe BmSDK.Class IceSphereClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6468); }
    }

    /// <summary>
    /// ArrayProperty: IceSpheres
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RFreezeBlastIceSphere> IceSpheres
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RFreezeBlastIceSphere>>(Ptr + 6472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6472); }
    }

    /// <summary>
    /// IntProperty: MaxIceSpheres
    /// </summary>
    public unsafe int MaxIceSpheres
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6484); }
    }

    /// <summary>
    /// ComponentProperty: CloakingAuraMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent CloakingAuraMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 6488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6488); }
    }

    /// <summary>
    /// ComponentProperty: CloakingAuraSecondaryMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent CloakingAuraSecondaryMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 6492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6492); }
    }

    /// <summary>
    /// ComponentProperty: CloakingAuraCapeMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent CloakingAuraCapeMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 6496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6496); }
    }

    /// <summary>
    /// ComponentProperty: ArmScreenMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent ArmScreenMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 6500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6500); }
    }

    /// <summary>
    /// ObjectProperty: CapeXrayMatInstConst
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant CapeXrayMatInstConst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 6504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6504); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: GadgetsConsoleOld
    /// </summary>
    public InlineArray<BmSDK.FName> GadgetsConsoleOld => new(16, Ptr + 6508, 8, this);

    /// <summary>
    /// NameProperty: GadgetsConsoleOld
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOld_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6508); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOld
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOld_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6516); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOld
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOld_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6524); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOld
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOld_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6532); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOld
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOld_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6540); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOld
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOld_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6548); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOld
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOld_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6556); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOld
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOld_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6564); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOld
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOld_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6572); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOld
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOld_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6580); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOld
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOld_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6588); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOld
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOld_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6596); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOld
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOld_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6604); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOld
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOld_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6612); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOld
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOld_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6620); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOld
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOld_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6628); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: GadgetsConsoleNew
    /// </summary>
    public InlineArray<BmSDK.FName> GadgetsConsoleNew => new(16, Ptr + 6636, 8, this);

    /// <summary>
    /// NameProperty: GadgetsConsoleNew
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleNew_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6636); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleNew
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleNew_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6644); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleNew
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleNew_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6652); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleNew
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleNew_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6660); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleNew
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleNew_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6668); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleNew
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleNew_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6676); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleNew
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleNew_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6684); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleNew
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleNew_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6692); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleNew
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleNew_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6700); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleNew
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleNew_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6708); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleNew
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleNew_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6716); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleNew
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleNew_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6724); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleNew
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleNew_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6732); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleNew
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleNew_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6740); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleNew
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleNew_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6748); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleNew
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleNew_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6756); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: GadgetsPCNew
    /// </summary>
    public InlineArray<BmSDK.FName> GadgetsPCNew => new(12, Ptr + 6764, 8, this);

    /// <summary>
    /// NameProperty: GadgetsPCNew
    /// </summary>
    public unsafe BmSDK.FName GadgetsPCNew_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6764); }
    }
    /// <summary>
    /// NameProperty: GadgetsPCNew
    /// </summary>
    public unsafe BmSDK.FName GadgetsPCNew_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6772); }
    }
    /// <summary>
    /// NameProperty: GadgetsPCNew
    /// </summary>
    public unsafe BmSDK.FName GadgetsPCNew_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6780); }
    }
    /// <summary>
    /// NameProperty: GadgetsPCNew
    /// </summary>
    public unsafe BmSDK.FName GadgetsPCNew_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6788); }
    }
    /// <summary>
    /// NameProperty: GadgetsPCNew
    /// </summary>
    public unsafe BmSDK.FName GadgetsPCNew_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6796); }
    }
    /// <summary>
    /// NameProperty: GadgetsPCNew
    /// </summary>
    public unsafe BmSDK.FName GadgetsPCNew_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6804); }
    }
    /// <summary>
    /// NameProperty: GadgetsPCNew
    /// </summary>
    public unsafe BmSDK.FName GadgetsPCNew_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6812); }
    }
    /// <summary>
    /// NameProperty: GadgetsPCNew
    /// </summary>
    public unsafe BmSDK.FName GadgetsPCNew_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6820); }
    }
    /// <summary>
    /// NameProperty: GadgetsPCNew
    /// </summary>
    public unsafe BmSDK.FName GadgetsPCNew_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6828); }
    }
    /// <summary>
    /// NameProperty: GadgetsPCNew
    /// </summary>
    public unsafe BmSDK.FName GadgetsPCNew_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6836); }
    }
    /// <summary>
    /// NameProperty: GadgetsPCNew
    /// </summary>
    public unsafe BmSDK.FName GadgetsPCNew_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6844); }
    }
    /// <summary>
    /// NameProperty: GadgetsPCNew
    /// </summary>
    public unsafe BmSDK.FName GadgetsPCNew_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6852); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: GadgetsPCOld
    /// </summary>
    public InlineArray<BmSDK.FName> GadgetsPCOld => new(12, Ptr + 6860, 8, this);

    /// <summary>
    /// NameProperty: GadgetsPCOld
    /// </summary>
    public unsafe BmSDK.FName GadgetsPCOld_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6860); }
    }
    /// <summary>
    /// NameProperty: GadgetsPCOld
    /// </summary>
    public unsafe BmSDK.FName GadgetsPCOld_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6868); }
    }
    /// <summary>
    /// NameProperty: GadgetsPCOld
    /// </summary>
    public unsafe BmSDK.FName GadgetsPCOld_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6876); }
    }
    /// <summary>
    /// NameProperty: GadgetsPCOld
    /// </summary>
    public unsafe BmSDK.FName GadgetsPCOld_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6884); }
    }
    /// <summary>
    /// NameProperty: GadgetsPCOld
    /// </summary>
    public unsafe BmSDK.FName GadgetsPCOld_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6892); }
    }
    /// <summary>
    /// NameProperty: GadgetsPCOld
    /// </summary>
    public unsafe BmSDK.FName GadgetsPCOld_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6900); }
    }
    /// <summary>
    /// NameProperty: GadgetsPCOld
    /// </summary>
    public unsafe BmSDK.FName GadgetsPCOld_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6908); }
    }
    /// <summary>
    /// NameProperty: GadgetsPCOld
    /// </summary>
    public unsafe BmSDK.FName GadgetsPCOld_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6916); }
    }
    /// <summary>
    /// NameProperty: GadgetsPCOld
    /// </summary>
    public unsafe BmSDK.FName GadgetsPCOld_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6924); }
    }
    /// <summary>
    /// NameProperty: GadgetsPCOld
    /// </summary>
    public unsafe BmSDK.FName GadgetsPCOld_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6932); }
    }
    /// <summary>
    /// NameProperty: GadgetsPCOld
    /// </summary>
    public unsafe BmSDK.FName GadgetsPCOld_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6940); }
    }
    /// <summary>
    /// NameProperty: GadgetsPCOld
    /// </summary>
    public unsafe BmSDK.FName GadgetsPCOld_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6948); }
    }

    /// <summary>
    /// ClassProperty: GadgetGlovesClass
    /// </summary>
    public unsafe BmSDK.Class GadgetGlovesClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6956); }
    }

    /// <summary>
    /// ObjectProperty: SnowCapeLandSoft
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem SnowCapeLandSoft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 6960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6960); }
    }
}
