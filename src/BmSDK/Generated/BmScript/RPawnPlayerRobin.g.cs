#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPawnPlayerRobin<br/>
/// (size = 6520)
/// (flags = 10486326)
/// </summary>
public partial class RPawnPlayerRobin : BmSDK.BmGame.RPawnPlayerBmBase, BmSDK.BmGame.RXrayInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnPlayerRobin", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnPlayerRobin.
    /// </summary>
    public static RPawnPlayerRobin DefaultObject => (RPawnPlayerRobin)StaticClass().DefaultObject;

    internal RPawnPlayerRobin() { }

    /// <summary>
    /// Constructs a new RPawnPlayerRobin
    /// </summary>
    public RPawnPlayerRobin(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayerRobin(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerRobin>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerRobin>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerRobin>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerRobin>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerRobin>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerRobin>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerRobin>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerRobin>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_PlayHurtEmote;
    /// <summary>
    /// Function: PlayHurtEmote
    /// </summary>
    public unsafe override void PlayHurtEmote(float RandChance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHurtEmote, "BmScript.RPawnPlayerRobin.PlayHurtEmote");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RandChance, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ModifyDamageToThrownVillain;
    /// <summary>
    /// Function: ModifyDamageToThrownVillain
    /// </summary>
    public unsafe override void ModifyDamageToThrownVillain(BmSDK.BmGame.RPawnCombat Villain, out int InOut_DamageAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyDamageToThrownVillain, "BmScript.RPawnPlayerRobin.ModifyDamageToThrownVillain");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out InOut_DamageAmount);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InOut_DamageAmount, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        InOut_DamageAmount = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_GetFailedPairedAnimMoveAnimset;
    /// <summary>
    /// Function: GetFailedPairedAnimMoveAnimset
    /// </summary>
    public unsafe override void GetFailedPairedAnimMoveAnimset(out BmSDK.Engine.AnimSet MyAnimset, BmSDK.BmGame.RPawnCombat OtherPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFailedPairedAnimMoveAnimset, "BmScript.RPawnPlayerRobin.GetFailedPairedAnimMoveAnimset");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MyAnimset);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MyAnimset, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherPawn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        MyAnimset = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetUnlockedMeleeArmourLevel;
    /// <summary>
    /// Function: GetUnlockedMeleeArmourLevel
    /// </summary>
    public unsafe override int GetUnlockedMeleeArmourLevel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUnlockedMeleeArmourLevel, "BmScript.RPawnPlayerRobin.GetUnlockedMeleeArmourLevel");
        byte* paramsPtr = stackalloc byte[24];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUnlockedBallisticArmourLevel, "BmScript.RPawnPlayerRobin.GetUnlockedBallisticArmourLevel");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlaySound_Impact;
    /// <summary>
    /// Function: PlaySound_Impact
    /// </summary>
    public unsafe override void PlaySound_Impact(BmSDK.BmGame.RPawnCombat Villain, bool bIsStrike, bool bFinishingBlow, bool bIsHeadImpact, bool bIsPunch, bool bIsStrong, bool bIsBlocked, bool bCanEmote = default, bool bIsSuperStrike = default, bool bIsBeatDown = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySound_Impact, "BmScript.RPawnPlayerRobin.PlaySound_Impact");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsStrike, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFinishingBlow, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsHeadImpact, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsPunch, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsStrong, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsBlocked, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanEmote, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsSuperStrike, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsBeatDown, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Died;
    /// <summary>
    /// Function: Died
    /// </summary>
    public unsafe override bool Died(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Died, "BmScript.RPawnPlayerRobin.Died");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetAfterCombatAnimset;
    /// <summary>
    /// Function: GetAfterCombatAnimset
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetAfterCombatAnimset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAfterCombatAnimset, "BmScript.RPawnPlayerRobin.GetAfterCombatAnimset");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStrikeMovementStance;
    /// <summary>
    /// Function: GetStrikeMovementStance
    /// </summary>
    public unsafe override BmSDK.FName GetStrikeMovementStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStrikeMovementStance, "BmScript.RPawnPlayerRobin.GetStrikeMovementStance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCinematicModeMovementStance;
    /// <summary>
    /// Function: GetCinematicModeMovementStance
    /// </summary>
    public unsafe override BmSDK.FName GetCinematicModeMovementStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCinematicModeMovementStance, "BmScript.RPawnPlayerRobin.GetCinematicModeMovementStance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetWalkingModeMovementStance;
    /// <summary>
    /// Function: GetWalkingModeMovementStance
    /// </summary>
    public unsafe override BmSDK.FName GetWalkingModeMovementStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWalkingModeMovementStance, "BmScript.RPawnPlayerRobin.GetWalkingModeMovementStance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetProjectileCounterClass;
    /// <summary>
    /// Function: GetProjectileCounterClass
    /// </summary>
    public unsafe override BmSDK.Class GetProjectileCounterClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetProjectileCounterClass, "BmScript.RPawnPlayerRobin.GetProjectileCounterClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetKnockBackAnimInfo;
    /// <summary>
    /// Function: GetKnockBackAnimInfo
    /// </summary>
    public unsafe override bool GetKnockBackAnimInfo(BmSDK.BmGame.RBMPawnAI Villain, BmSDK.BmGame.RPawnCombat.CounterLimb Limb, out BmSDK.FName KnockBackAnimName, out BmSDK.Engine.AnimSet KnockBackAnimset)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetKnockBackAnimInfo, "BmScript.RPawnPlayerRobin.GetKnockBackAnimInfo");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Limb, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out KnockBackAnimName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KnockBackAnimName, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out KnockBackAnimset);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KnockBackAnimset, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        KnockBackAnimName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
        KnockBackAnimset = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_PlayStowStaffAnim;
    /// <summary>
    /// Function: PlayStowStaffAnim
    /// </summary>
    public unsafe virtual bool PlayStowStaffAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayStowStaffAnim, "BmScript.RPawnPlayerRobin.PlayStowStaffAnim");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OverrideChangeRunningModeStance;
    /// <summary>
    /// Function: OverrideChangeRunningModeStance
    /// </summary>
    public unsafe override bool OverrideChangeRunningModeStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideChangeRunningModeStance, "BmScript.RPawnPlayerRobin.OverrideChangeRunningModeStance");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OverrideChangeWalkingModeStance;
    /// <summary>
    /// Function: OverrideChangeWalkingModeStance
    /// </summary>
    public unsafe override bool OverrideChangeWalkingModeStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideChangeWalkingModeStance, "BmScript.RPawnPlayerRobin.OverrideChangeWalkingModeStance");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DeployShield;
    /// <summary>
    /// Function: DeployShield
    /// </summary>
    public unsafe virtual void DeployShield(BmSDK.BmScript.RRobinStaffShield Shield)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeployShield, "BmScript.RPawnPlayerRobin.DeployShield");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Shield, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideShield;
    /// <summary>
    /// Function: HideShield
    /// </summary>
    public unsafe virtual void HideShield()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideShield, "BmScript.RPawnPlayerRobin.HideShield");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideStaff;
    /// <summary>
    /// Function: HideStaff
    /// </summary>
    public unsafe virtual void HideStaff()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideStaff, "BmScript.RPawnPlayerRobin.HideStaff");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideStaffWithFlourish;
    /// <summary>
    /// Function: HideStaffWithFlourish
    /// </summary>
    public unsafe virtual void HideStaffWithFlourish()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideStaffWithFlourish, "BmScript.RPawnPlayerRobin.HideStaffWithFlourish");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowStaffLeft;
    /// <summary>
    /// Function: ShowStaffLeft
    /// </summary>
    public unsafe virtual void ShowStaffLeft()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowStaffLeft, "BmScript.RPawnPlayerRobin.ShowStaffLeft");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowStaffRight;
    /// <summary>
    /// Function: ShowStaffRight
    /// </summary>
    public unsafe virtual void ShowStaffRight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowStaffRight, "BmScript.RPawnPlayerRobin.ShowStaffRight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateStaffVisibility;
    /// <summary>
    /// Function: UpdateStaffVisibility
    /// </summary>
    public unsafe virtual void UpdateStaffVisibility()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateStaffVisibility, "BmScript.RPawnPlayerRobin.UpdateStaffVisibility");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeInitAttackMoveWeaponsWithDelay;
    /// <summary>
    /// Function: DeInitAttackMoveWeaponsWithDelay
    /// </summary>
    public unsafe virtual void DeInitAttackMoveWeaponsWithDelay(float Delay)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeInitAttackMoveWeaponsWithDelay, "BmScript.RPawnPlayerRobin.DeInitAttackMoveWeaponsWithDelay");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeInitAttackMoveWeaponsFromCancelSpecialMove;
    /// <summary>
    /// Function: DeInitAttackMoveWeaponsFromCancelSpecialMove
    /// </summary>
    public unsafe override void DeInitAttackMoveWeaponsFromCancelSpecialMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeInitAttackMoveWeaponsFromCancelSpecialMove, "BmScript.RPawnPlayerRobin.DeInitAttackMoveWeaponsFromCancelSpecialMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeInitAttackMoveWeaponsFromFinishSpecialMove;
    /// <summary>
    /// Function: DeInitAttackMoveWeaponsFromFinishSpecialMove
    /// </summary>
    public unsafe override void DeInitAttackMoveWeaponsFromFinishSpecialMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeInitAttackMoveWeaponsFromFinishSpecialMove, "BmScript.RPawnPlayerRobin.DeInitAttackMoveWeaponsFromFinishSpecialMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeInitAttackMoveWeapons;
    /// <summary>
    /// Function: DeInitAttackMoveWeapons
    /// </summary>
    public unsafe override void DeInitAttackMoveWeapons()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeInitAttackMoveWeapons, "BmScript.RPawnPlayerRobin.DeInitAttackMoveWeapons");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitAttackMoveWeapons;
    /// <summary>
    /// Function: InitAttackMoveWeapons
    /// </summary>
    public unsafe override void InitAttackMoveWeapons(bool bMirrored)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitAttackMoveWeapons, "BmScript.RPawnPlayerRobin.InitAttackMoveWeapons");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMirrored, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatMoveInitialised;
    /// <summary>
    /// Function: CombatMoveInitialised
    /// </summary>
    public unsafe override void CombatMoveInitialised(BmSDK.BmGame.RCombatMove NewMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatMoveInitialised, "BmScript.RPawnPlayerRobin.CombatMoveInitialised");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMove, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetContactCharacterName, "BmScript.RPawnPlayerRobin.GetContactCharacterName");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindContactName, "BmScript.RPawnPlayerRobin.FindContactName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Foot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Contact, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_DamagedBy;
    /// <summary>
    /// Function: DamagedBy
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult DamagedBy(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamagedBy, "BmScript.RPawnPlayerRobin.DamagedBy");
        byte* paramsPtr = stackalloc byte[273];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 256);
    }

    private static BmSDK.Function __fn_ShotBy;
    /// <summary>
    /// Function: ShotBy
    /// </summary>
    public unsafe override void ShotBy(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo, System.Numerics.Vector3 HitLocation = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShotBy, "BmScript.RPawnPlayerRobin.ShotBy");
        byte* paramsPtr = stackalloc byte[284];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 256);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDefaultInventory, "BmScript.RPawnPlayerRobin.AddDefaultInventory");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddBatarangMovesToWeaponConfig, "BmScript.RPawnPlayerRobin.AddBatarangMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[3532];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCapeMovesToWeaponConfig, "BmScript.RPawnPlayerRobin.AddCapeMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[2312];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddSmokeBombMovesToWeaponConfig, "BmScript.RPawnPlayerRobin.AddSmokeBombMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[3260];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddExplosiveGelAndDetonatorMovesToWeaponConfig, "BmScript.RPawnPlayerRobin.AddExplosiveGelAndDetonatorMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[2020];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddStickyBombMovesToWeaponConfig;
    /// <summary>
    /// Function: AddStickyBombMovesToWeaponConfig
    /// </summary>
    public unsafe virtual void AddStickyBombMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddStickyBombMovesToWeaponConfig, "BmScript.RPawnPlayerRobin.AddStickyBombMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[3124];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddStaffShieldMovesToWeaponConfig;
    /// <summary>
    /// Function: AddStaffShieldMovesToWeaponConfig
    /// </summary>
    public unsafe virtual void AddStaffShieldMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddStaffShieldMovesToWeaponConfig, "BmScript.RPawnPlayerRobin.AddStaffShieldMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[1404];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddZipKickMovesToWeaponConfig;
    /// <summary>
    /// Function: AddZipKickMovesToWeaponConfig
    /// </summary>
    public unsafe virtual void AddZipKickMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddZipKickMovesToWeaponConfig, "BmScript.RPawnPlayerRobin.AddZipKickMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[2580];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddGrappleMovesToWeaponConfig, "BmScript.RPawnPlayerRobin.AddGrappleMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[2100];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupWirePoses, "BmScript.RPawnPlayerRobin.SetupWirePoses");
        byte* paramsPtr = stackalloc byte[716];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PoseConfig, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddBatmanMovesToWeaponConfig, "BmScript.RPawnPlayerRobin.AddBatmanMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[1824];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyExistingPoses, "BmScript.RPawnPlayerRobin.ModifyExistingPoses");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddMovementMovesToWeaponConfig, "BmScript.RPawnPlayerRobin.AddMovementMovesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddCombatAnimSetOverridesToWeaponConfig;
    /// <summary>
    /// Function: AddCombatAnimSetOverridesToWeaponConfig
    /// </summary>
    public unsafe override void AddCombatAnimSetOverridesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCombatAnimSetOverridesToWeaponConfig, "BmScript.RPawnPlayerRobin.AddCombatAnimSetOverridesToWeaponConfig");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForExplodingThings;
    /// <summary>
    /// Function: CheckForExplodingThings
    /// </summary>
    public unsafe virtual void CheckForExplodingThings()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForExplodingThings, "BmScript.RPawnPlayerRobin.CheckForExplodingThings");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddOrRefreshExplodingThing;
    /// <summary>
    /// Function: AddOrRefreshExplodingThing
    /// </summary>
    public unsafe virtual void AddOrRefreshExplodingThing(BmSDK.Engine.Actor ThingActor, BmSDK.BmScript.RPawnPlayerRobin.ETypesOfExplodingThing ThingType, int BombIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddOrRefreshExplodingThing, "BmScript.RPawnPlayerRobin.AddOrRefreshExplodingThing");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThingActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThingType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BombIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetStickyBombActor;
    /// <summary>
    /// Function: GetStickyBombActor
    /// </summary>
    public unsafe virtual BmSDK.BmScript.RRobinStickyBomb GetStickyBombActor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStickyBombActor, "BmScript.RPawnPlayerRobin.GetStickyBombActor");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmScript.RRobinStickyBomb>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetExplosionRadius;
    /// <summary>
    /// Function: GetExplosionRadius
    /// </summary>
    public unsafe virtual float GetExplosionRadius(BmSDK.Engine.Actor test_actor, BmSDK.BmScript.RPawnPlayerRobin.ETypesOfExplodingThing thing_type)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetExplosionRadius, "BmScript.RPawnPlayerRobin.GetExplosionRadius");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(test_actor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(thing_type, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_TickExplodingThings;
    /// <summary>
    /// Function: TickExplodingThings
    /// </summary>
    public unsafe virtual void TickExplodingThings(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickExplodingThings, "BmScript.RPawnPlayerRobin.TickExplodingThings");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyForensicsUpdateRequired;
    /// <summary>
    /// Function: NotifyForensicsUpdateRequired
    /// </summary>
    public unsafe override void NotifyForensicsUpdateRequired()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyForensicsUpdateRequired, "BmScript.RPawnPlayerRobin.NotifyForensicsUpdateRequired");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearEffects;
    /// <summary>
    /// Function: ClearEffects
    /// </summary>
    public unsafe virtual void ClearEffects(int ThingIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearEffects, "BmScript.RPawnPlayerRobin.ClearEffects");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThingIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnEffectsOnThing;
    /// <summary>
    /// Function: SpawnEffectsOnThing
    /// </summary>
    public unsafe virtual void SpawnEffectsOnThing(int ThingIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnEffectsOnThing, "BmScript.RPawnPlayerRobin.SpawnEffectsOnThing");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThingIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetThingLocation;
    /// <summary>
    /// Function: GetThingLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetThingLocation(int ThingIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThingLocation, "BmScript.RPawnPlayerRobin.GetThingLocation");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThingIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_DrawHUD;
    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe override void DrawHUD(BmSDK.Engine.HUD H)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawHUD, "BmScript.RPawnPlayerRobin.DrawHUD");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmScript.RPawnPlayerRobin.Tick");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnPossessed;
    /// <summary>
    /// Function: UnPossessed
    /// </summary>
    public unsafe override void UnPossessed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnPossessed, "BmScript.RPawnPlayerRobin.UnPossessed");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PossessedBy, "BmScript.RPawnPlayerRobin.PossessedBy");
        byte* paramsPtr = stackalloc byte[24];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThoughts, "BmScript.RPawnPlayerRobin.GetThoughts");
        byte* paramsPtr = stackalloc byte[28];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInXrayMode, "BmScript.RPawnPlayerRobin.SetInXrayMode");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeFallingDamage, "BmScript.RPawnPlayerRobin.TakeFallingDamage");
        byte* paramsPtr = stackalloc byte[16];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOwnerNoSee, "BmScript.RPawnPlayerRobin.SetOwnerNoSee");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHidden, "BmScript.RPawnPlayerRobin.SetHidden");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPlayerHasBeenMoved, "BmScript.RPawnPlayerRobin.OnPlayerHasBeenMoved");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetOpenGrateOutsideMove;
    /// <summary>
    /// Function: GetOpenGrateOutsideMove
    /// </summary>
    public unsafe override BmSDK.BmGame.RSpecialMoveConfig GetOpenGrateOutsideMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOpenGrateOutsideMove, "BmScript.RPawnPlayerRobin.GetOpenGrateOutsideMove");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOpenGrateInsideMove, "BmScript.RPawnPlayerRobin.GetOpenGrateInsideMove");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHarpoonOpenGrateMove, "BmScript.RPawnPlayerRobin.GetHarpoonOpenGrateMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmScript.RPawnPlayerRobin.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FExplodingThingInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FExplodingThingInfo
    {
        /// <summary>
        /// ObjectProperty: TheExplodingThing
        /// </summary>
        public unsafe BmSDK.Engine.Actor TheExplodingThing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: ExplosionRadius
        /// </summary>
        public unsafe float ExplosionRadius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ByteProperty: ThingType
        /// </summary>
        public unsafe BmSDK.BmScript.RPawnPlayerRobin.ETypesOfExplodingThing ThingType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RPawnPlayerRobin.ETypesOfExplodingThing>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: NeedsToBeCleanedUp
        /// </summary>
        public unsafe bool NeedsToBeCleanedUp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// ObjectProperty: BlastRadiusEffect
        /// </summary>
        public unsafe BmSDK.BmGame.REmitter BlastRadiusEffect
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REmitter>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ObjectProperty: AttachedVillain
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnVillain AttachedVillain
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// IntProperty: StickyBombIndex
        /// </summary>
        public unsafe int StickyBombIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Enum: ETypesOfExplodingThing
    /// </summary>
    public enum ETypesOfExplodingThing : byte
    {
        TET_StickyBomb = 0,
        TET_Grenade = 1,
        TET_Mine = 2,
        TET_GargoyleMine = 3,
        TET_ThingThatDoesntExplode = 4,
        TET_MAX = 5,
    }

    /// <summary>
    /// Enum: ERobinGadgetList
    /// </summary>
    public enum ERobinGadgetList : byte
    {
        RGL_Batarang = 0,
        RGL_Staff = 1,
        RGL_StaffShield = 2,
        RGL_StickyBomb = 3,
        RGL_BatClaw = 4,
        RGL_MAX = 5,
    }

    /// <summary>
    /// ObjectProperty: DeployedShield
    /// </summary>
    public unsafe BmSDK.BmScript.RRobinStaffShield DeployedShield
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RRobinStaffShield>(Ptr + 6440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6440); }
    }

    /// <summary>
    /// BoolProperty: DoingShieldSlam
    /// </summary>
    public unsafe bool DoingShieldSlam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6444) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6444); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6444); }
    }

    /// <summary>
    /// BoolProperty: UsePostCombatStance
    /// </summary>
    public unsafe bool UsePostCombatStance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6444) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6444); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6444); }
    }

    /// <summary>
    /// BoolProperty: UseStrikeMirrored
    /// </summary>
    public unsafe bool UseStrikeMirrored
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6444) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6444); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6444); }
    }

    /// <summary>
    /// BoolProperty: CurrentStrikeMirrored
    /// </summary>
    public unsafe bool CurrentStrikeMirrored
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6444) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6444); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6444); }
    }

    /// <summary>
    /// StructProperty: PutAwayStaffId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId PutAwayStaffId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 6448);

    /// <summary>
    /// ComponentProperty: LeftWeapon
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent LeftWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 6452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6452); }
    }

    /// <summary>
    /// ComponentProperty: RightWeapon
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent RightWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 6456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6456); }
    }

    /// <summary>
    /// ComponentProperty: LeftShield
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent LeftShield
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 6460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6460); }
    }

    /// <summary>
    /// ComponentProperty: RightShield
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent RightShield
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 6464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6464); }
    }

    /// <summary>
    /// IntProperty: NextPutAwaySticksFromCombat
    /// </summary>
    public unsafe int NextPutAwaySticksFromCombat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6468); }
    }

    /// <summary>
    /// IntProperty: StaffHand
    /// </summary>
    public unsafe int StaffHand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6472); }
    }

    /// <summary>
    /// ObjectProperty: PlacedBombOnDownedEnemy
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain PlacedBombOnDownedEnemy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 6476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6476); }
    }

    /// <summary>
    /// ObjectProperty: JustShieldBlockedShotFrom
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat JustShieldBlockedShotFrom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 6480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6480); }
    }

    /// <summary>
    /// ArrayProperty: ExplodingThings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RPawnPlayerRobin.FExplodingThingInfo> ExplodingThings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RPawnPlayerRobin.FExplodingThingInfo>>(Ptr + 6484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6484); }
    }

    /// <summary>
    /// FloatProperty: CheckForExplodingThingsCountdown
    /// </summary>
    public unsafe float CheckForExplodingThingsCountdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6496); }
    }

    /// <summary>
    /// FloatProperty: CheckForExplodingThingsPeriod
    /// </summary>
    public unsafe float CheckForExplodingThingsPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6500); }
    }

    /// <summary>
    /// ObjectProperty: StickyBombActorCached
    /// </summary>
    public unsafe BmSDK.BmScript.RRobinStickyBomb StickyBombActorCached
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RRobinStickyBomb>(Ptr + 6504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6504); }
    }

    /// <summary>
    /// ObjectProperty: BlastRadiusFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem BlastRadiusFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 6508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6508); }
    }

    /// <summary>
    /// IntProperty: StickyBombThingIndex
    /// </summary>
    public unsafe int StickyBombThingIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6512); }
    }

    /// <summary>
    /// ObjectProperty: CapeXrayMatInstConst
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant CapeXrayMatInstConst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 6516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6516); }
    }
}
