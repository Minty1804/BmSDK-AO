#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MPawnVillainCopperhead<br/>
/// (size = 4324)
/// (flags = 10485814)
/// </summary>
public partial class MPawnVillainCopperhead : BmSDK.BmScript.RPawnVillainNinja, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MPawnVillainCopperhead", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MPawnVillainCopperhead.
    /// </summary>
    public static MPawnVillainCopperhead DefaultObject => (MPawnVillainCopperhead)StaticClass().DefaultObject;

    internal MPawnVillainCopperhead() { }

    /// <summary>
    /// Constructs a new MPawnVillainCopperhead
    /// </summary>
    public MPawnVillainCopperhead(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MPawnVillainCopperhead(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillainCopperhead>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainCopperhead>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillainCopperhead>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainCopperhead>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainCopperhead>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainCopperhead>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillainCopperhead>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainCopperhead>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_TestFellOutOfCombatArea;
    /// <summary>
    /// Function: TestFellOutOfCombatArea
    /// </summary>
    public unsafe virtual bool TestFellOutOfCombatArea()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestFellOutOfCombatArea, "BmScript.MPawnVillainCopperhead.TestFellOutOfCombatArea");
        byte* paramsPtr = stackalloc byte[112];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayMultiAttackDialogue;
    /// <summary>
    /// Function: PlayMultiAttackDialogue
    /// </summary>
    public unsafe override void PlayMultiAttackDialogue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayMultiAttackDialogue, "BmScript.MPawnVillainCopperhead.PlayMultiAttackDialogue");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckDodgeProjectile;
    /// <summary>
    /// Function: CheckDodgeProjectile
    /// </summary>
    public unsafe override bool CheckDodgeProjectile(BmSDK.BmGame.RPawn Thrower, BmSDK.FName TargetBone, System.Numerics.Vector3 ProjPos, int BatarangID, bool bForceDodge = default, bool bSteerableProj = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckDodgeProjectile, "BmScript.MPawnVillainCopperhead.CheckDodgeProjectile");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thrower, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBone, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProjPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatarangID, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceDodge, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSteerableProj, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_SpawnSpecialAttack;
    /// <summary>
    /// Function: SpawnSpecialAttack
    /// </summary>
    public unsafe override bool SpawnSpecialAttack(BmSDK.BmGame.RPawnCombat PlayerPawn, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnSpecialAttack, "BmScript.MPawnVillainCopperhead.SpawnSpecialAttack");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_InitializeDodgeOverMove;
    /// <summary>
    /// Function: InitializeDodgeOverMove
    /// </summary>
    public unsafe virtual void InitializeDodgeOverMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitializeDodgeOverMove, "BmScript.MPawnVillainCopperhead.InitializeDodgeOverMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForDodge;
    /// <summary>
    /// Function: CheckForDodge
    /// </summary>
    public unsafe virtual bool CheckForDodge()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForDodge, "BmScript.MPawnVillainCopperhead.CheckForDodge");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DodgeStrike;
    /// <summary>
    /// Function: DodgeStrike
    /// </summary>
    public unsafe override void DodgeStrike(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class dmgType, bool bFar)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DodgeStrike, "BmScript.MPawnVillainCopperhead.DodgeStrike");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFar, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnNinjaDodge;
    /// <summary>
    /// Function: SpawnNinjaDodge
    /// </summary>
    public unsafe virtual void SpawnNinjaDodge()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnNinjaDodge, "BmScript.MPawnVillainCopperhead.SpawnNinjaDodge");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanDodgeAttack;
    /// <summary>
    /// Function: CanDodgeAttack
    /// </summary>
    public unsafe override bool CanDodgeAttack(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class dmgType, bool bFar)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDodgeAttack, "BmScript.MPawnVillainCopperhead.CanDodgeAttack");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFar, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CreateWeaponConfigUnarmed;
    /// <summary>
    /// Function: CreateWeaponConfigUnarmed
    /// </summary>
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateWeaponConfigUnarmed(BmSDK.GameObject NewOwner)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateWeaponConfigUnarmed, "BmScript.MPawnVillainCopperhead.CreateWeaponConfigUnarmed");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AddBasicAnimSets;
    /// <summary>
    /// Function: AddBasicAnimSets
    /// </summary>
    public unsafe override void AddBasicAnimSets(out BmSDK.TArray<BmSDK.Engine.AnimSet> AnimSets)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddBasicAnimSets, "BmScript.MPawnVillainCopperhead.AddBasicAnimSets");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AnimSets = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.AnimSet>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_IsTargetatble;
    /// <summary>
    /// Function: IsTargetatble
    /// </summary>
    public unsafe virtual bool IsTargetatble()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTargetatble, "BmScript.MPawnVillainCopperhead.IsTargetatble");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsBatarangable;
    /// <summary>
    /// Function: IsBatarangable
    /// </summary>
    public unsafe override bool IsBatarangable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBatarangable, "BmScript.MPawnVillainCopperhead.IsBatarangable");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ModifyDamageAmount;
    /// <summary>
    /// Function: ModifyDamageAmount
    /// </summary>
    public unsafe override void ModifyDamageAmount(BmSDK.Class dmgType, out float DmgAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyDamageAmount, "BmScript.MPawnVillainCopperhead.ModifyDamageAmount");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DmgAmount);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgAmount, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DmgAmount = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_CreateWeapon;
    /// <summary>
    /// Function: CreateWeapon
    /// </summary>
    public unsafe override BmSDK.BmGame.RBMWeapon CreateWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateWeapon, "BmScript.MPawnVillainCopperhead.CreateWeapon");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMWeapon>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PostInitCharacter;
    /// <summary>
    /// Function: PostInitCharacter
    /// </summary>
    public unsafe override void PostInitCharacter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostInitCharacter, "BmScript.MPawnVillainCopperhead.PostInitCharacter");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGooSprayDamageAmount;
    /// <summary>
    /// Function: GetGooSprayDamageAmount
    /// </summary>
    public unsafe override float GetGooSprayDamageAmount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGooSprayDamageAmount, "BmScript.MPawnVillainCopperhead.GetGooSprayDamageAmount");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetHealth;
    /// <summary>
    /// Function: SetHealth
    /// </summary>
    public unsafe override void SetHealth()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHealth, "BmScript.MPawnVillainCopperhead.SetHealth");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDestroyPending;
    /// <summary>
    /// Function: SetDestroyPending
    /// </summary>
    public unsafe virtual void SetDestroyPending()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDestroyPending, "BmScript.MPawnVillainCopperhead.SetDestroyPending");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyPawn;
    /// <summary>
    /// Function: DestroyPawn
    /// </summary>
    public unsafe override void DestroyPawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyPawn, "BmScript.MPawnVillainCopperhead.DestroyPawn");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldGetUpWhenHitFloor;
    /// <summary>
    /// Function: ShouldGetUpWhenHitFloor
    /// </summary>
    public unsafe override bool ShouldGetUpWhenHitFloor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldGetUpWhenHitFloor, "BmScript.MPawnVillainCopperhead.ShouldGetUpWhenHitFloor");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Shimmer;
    /// <summary>
    /// Function: Shimmer
    /// </summary>
    public unsafe virtual void Shimmer(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Shimmer, "BmScript.MPawnVillainCopperhead.Shimmer");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmScript.MPawnVillainCopperhead.Tick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnHideSandMesh;
    /// <summary>
    /// Function: UnHideSandMesh
    /// </summary>
    public unsafe virtual void UnHideSandMesh()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnHideSandMesh, "BmScript.MPawnVillainCopperhead.UnHideSandMesh");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideSandMesh;
    /// <summary>
    /// Function: HideSandMesh
    /// </summary>
    public unsafe virtual void HideSandMesh()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideSandMesh, "BmScript.MPawnVillainCopperhead.HideSandMesh");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSandCloneVisibilityFx;
    /// <summary>
    /// Function: SetSandCloneVisibilityFx
    /// </summary>
    public unsafe virtual void SetSandCloneVisibilityFx(float Param)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSandCloneVisibilityFx, "BmScript.MPawnVillainCopperhead.SetSandCloneVisibilityFx");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Param, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateDesintegrate;
    /// <summary>
    /// Function: UpdateDesintegrate
    /// </summary>
    public unsafe virtual bool UpdateDesintegrate(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateDesintegrate, "BmScript.MPawnVillainCopperhead.UpdateDesintegrate");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SpawnDesintegrateParticles;
    /// <summary>
    /// Function: SpawnDesintegrateParticles
    /// </summary>
    public unsafe virtual void SpawnDesintegrateParticles(bool bPlaySfx = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnDesintegrateParticles, "BmScript.MPawnVillainCopperhead.SpawnDesintegrateParticles");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlaySfx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySpawnSpeech;
    /// <summary>
    /// Function: PlaySpawnSpeech
    /// </summary>
    public unsafe virtual void PlaySpawnSpeech()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySpawnSpeech, "BmScript.MPawnVillainCopperhead.PlaySpawnSpeech");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBoss;
    /// <summary>
    /// Function: GetBoss
    /// </summary>
    public unsafe virtual BmSDK.BmScript.MPawnVillainCopperheadBoss GetBoss()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBoss, "BmScript.MPawnVillainCopperhead.GetBoss");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmScript.MPawnVillainCopperheadBoss>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayTaunt;
    /// <summary>
    /// Function: PlayTaunt
    /// </summary>
    public unsafe virtual void PlayTaunt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayTaunt, "BmScript.MPawnVillainCopperhead.PlayTaunt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayRagdoll;
    /// <summary>
    /// Function: PlayRagdoll
    /// </summary>
    public unsafe override void PlayRagdoll(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo, BmSDK.BmGame.RGameInfo.RagdollStunType NewStunType = default, bool bKill = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayRagdoll, "BmScript.MPawnVillainCopperhead.PlayRagdoll");
        byte* paramsPtr = stackalloc byte[284];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewStunType, paramsPtr + 256);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKill, paramsPtr + 260);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGoodAsDead;
    /// <summary>
    /// Function: SetGoodAsDead
    /// </summary>
    public unsafe override void SetGoodAsDead()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGoodAsDead, "BmScript.MPawnVillainCopperhead.SetGoodAsDead");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldGoRagdoll;
    /// <summary>
    /// Function: ShouldGoRagdoll
    /// </summary>
    public unsafe override bool ShouldGoRagdoll(BmSDK.Class dmgType, float DamageAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldGoRagdoll, "BmScript.MPawnVillainCopperhead.ShouldGoRagdoll");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_Died;
    /// <summary>
    /// Function: Died
    /// </summary>
    public unsafe override bool Died(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Died, "BmScript.MPawnVillainCopperhead.Died");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_RemoveSpawnFX;
    /// <summary>
    /// Function: RemoveSpawnFX
    /// </summary>
    public unsafe virtual void RemoveSpawnFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveSpawnFX, "BmScript.MPawnVillainCopperhead.RemoveSpawnFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowSpawnFX;
    /// <summary>
    /// Function: ShowSpawnFX
    /// </summary>
    public unsafe virtual void ShowSpawnFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowSpawnFX, "BmScript.MPawnVillainCopperhead.ShowSpawnFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDisintegrateParticleSystem;
    /// <summary>
    /// Function: SetDisintegrateParticleSystem
    /// </summary>
    public unsafe virtual void SetDisintegrateParticleSystem()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDisintegrateParticleSystem, "BmScript.MPawnVillainCopperhead.SetDisintegrateParticleSystem");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: StartingWeapon
    /// </summary>
    public unsafe BmSDK.BmGame.RBMWeapon StartingWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMWeapon>(Ptr + 4068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4068); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: StartingHealth
    /// </summary>
    public InlineArray<float> StartingHealth => new(3, Ptr + 4072, 4, this);

    /// <summary>
    /// FloatProperty: StartingHealth
    /// </summary>
    public unsafe float StartingHealth_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4072); }
    }
    /// <summary>
    /// FloatProperty: StartingHealth
    /// </summary>
    public unsafe float StartingHealth_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4076); }
    }
    /// <summary>
    /// FloatProperty: StartingHealth
    /// </summary>
    public unsafe float StartingHealth_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4080); }
    }

    /// <summary>
    /// ArrayProperty: SingleAttackAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> SingleAttackAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4084); }
    }

    /// <summary>
    /// IntProperty: SingleAttackPriority
    /// </summary>
    public unsafe int SingleAttackPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4096); }
    }

    /// <summary>
    /// IntProperty: MultiStrikePriority
    /// </summary>
    public unsafe int MultiStrikePriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4100); }
    }

    /// <summary>
    /// IntProperty: GrabAttackPriority
    /// </summary>
    public unsafe int GrabAttackPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4104); }
    }

    /// <summary>
    /// IntProperty: PriorityIncrementor
    /// </summary>
    public unsafe int PriorityIncrementor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4108); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: SingleAttackDamageGiven
    /// </summary>
    public InlineArray<float> SingleAttackDamageGiven => new(3, Ptr + 4112, 4, this);

    /// <summary>
    /// FloatProperty: SingleAttackDamageGiven
    /// </summary>
    public unsafe float SingleAttackDamageGiven_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4112); }
    }
    /// <summary>
    /// FloatProperty: SingleAttackDamageGiven
    /// </summary>
    public unsafe float SingleAttackDamageGiven_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4116); }
    }
    /// <summary>
    /// FloatProperty: SingleAttackDamageGiven
    /// </summary>
    public unsafe float SingleAttackDamageGiven_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4120); }
    }

    /// <summary>
    /// ObjectProperty: CopperHeadBark_CH_CloneDeathGadget
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine CopperHeadBark_CH_CloneDeathGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4124); }
    }

    /// <summary>
    /// ObjectProperty: CopperHeadBark_CH_CloneDeathNoGadget
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine CopperHeadBark_CH_CloneDeathNoGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4128); }
    }

    /// <summary>
    /// ObjectProperty: CopperHeadBark_CH_FinalSnakeDash
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine CopperHeadBark_CH_FinalSnakeDash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4132); }
    }

    /// <summary>
    /// ObjectProperty: CopperHeadBark_CH_FirstCloneSpawn
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine CopperHeadBark_CH_FirstCloneSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4136); }
    }

    /// <summary>
    /// ObjectProperty: CopperHeadBark_CH_Grab
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine CopperHeadBark_CH_Grab
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4140); }
    }

    /// <summary>
    /// ObjectProperty: CopperHeadBark_CH_Retreat
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine CopperHeadBark_CH_Retreat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4144); }
    }

    /// <summary>
    /// ObjectProperty: CopperHeadBark_CH_SecondCloneSpawn
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine CopperHeadBark_CH_SecondCloneSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4148); }
    }

    /// <summary>
    /// ObjectProperty: CopperHeadBark_CH_SnakeDash
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine CopperHeadBark_CH_SnakeDash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4152); }
    }

    /// <summary>
    /// ObjectProperty: CopperHeadBark_CH_Taunt
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine CopperHeadBark_CH_Taunt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4156); }
    }

    /// <summary>
    /// IntProperty: DifficultyLevel
    /// </summary>
    public unsafe int DifficultyLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4160); }
    }

    /// <summary>
    /// FloatProperty: ExplosivelDamageVal
    /// </summary>
    public unsafe float ExplosivelDamageVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4164); }
    }

    /// <summary>
    /// ArrayProperty: SandTrail
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ParticleSystemComponent> SandTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ParticleSystemComponent>>(Ptr + 4168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4168); }
    }

    /// <summary>
    /// ArrayProperty: SandTrailBone
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> SandTrailBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4180); }
    }

    /// <summary>
    /// BoolProperty: bDestroyPending
    /// </summary>
    public unsafe bool bDestroyPending
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4192) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4192); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4192); }
    }

    /// <summary>
    /// BoolProperty: bSpawningIn
    /// </summary>
    public unsafe bool bSpawningIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4192) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4192); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4192); }
    }

    /// <summary>
    /// BoolProperty: bDisintegrated
    /// </summary>
    public unsafe bool bDisintegrated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4192) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4192); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4192); }
    }

    /// <summary>
    /// BoolProperty: CanDoSpawnFX
    /// </summary>
    public unsafe bool CanDoSpawnFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4192) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4192); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4192); }
    }

    /// <summary>
    /// BoolProperty: bDontShowDieFX
    /// </summary>
    public unsafe bool bDontShowDieFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4192) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4192); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4192); }
    }

    /// <summary>
    /// BoolProperty: bIsFinalAttack
    /// </summary>
    public unsafe bool bIsFinalAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4192) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4192); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4192); }
    }

    /// <summary>
    /// BoolProperty: bShimmering
    /// </summary>
    public unsafe bool bShimmering
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4192) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4192); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4192); }
    }

    /// <summary>
    /// BoolProperty: bOverrideDodgeDirection
    /// </summary>
    public unsafe bool bOverrideDodgeDirection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4192) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4192); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4192); }
    }

    /// <summary>
    /// BoolProperty: bDodgeLeftDirection
    /// </summary>
    public unsafe bool bDodgeLeftDirection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4192) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4192); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4192); }
    }

    /// <summary>
    /// BoolProperty: bForceIntoRagdoll
    /// </summary>
    public unsafe bool bForceIntoRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4192) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4192); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4192); }
    }

    /// <summary>
    /// ObjectProperty: DestroyedFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem DestroyedFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4196); }
    }

    /// <summary>
    /// ObjectProperty: SandMaterialHead
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant SandMaterialHead
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4200); }
    }

    /// <summary>
    /// ObjectProperty: SandMaterialChest
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant SandMaterialChest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4204); }
    }

    /// <summary>
    /// ObjectProperty: SandMaterialEyes
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant SandMaterialEyes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4208); }
    }

    /// <summary>
    /// ObjectProperty: SandMaterialHair
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant SandMaterialHair
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4212); }
    }

    /// <summary>
    /// ObjectProperty: SandMaterialArms
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant SandMaterialArms
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4216); }
    }

    /// <summary>
    /// ObjectProperty: SandMaterialLegs
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant SandMaterialLegs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4220); }
    }

    /// <summary>
    /// ComponentProperty: SandMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent SandMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 4224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4224); }
    }

    /// <summary>
    /// FloatProperty: DesintegrateVal
    /// </summary>
    public unsafe float DesintegrateVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4228); }
    }

    /// <summary>
    /// FloatProperty: SpawningVal
    /// </summary>
    public unsafe float SpawningVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4232); }
    }

    /// <summary>
    /// ComponentProperty: ShimmerFXComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ShimmerFXComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4236); }
    }

    /// <summary>
    /// ComponentProperty: DuplicateFXComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent DuplicateFXComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4240); }
    }

    /// <summary>
    /// ObjectProperty: ShimmerFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ShimmerFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4244); }
    }

    /// <summary>
    /// FloatProperty: Angle
    /// </summary>
    public unsafe float Angle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4248); }
    }

    /// <summary>
    /// FloatProperty: Steps
    /// </summary>
    public unsafe float Steps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4252); }
    }

    /// <summary>
    /// IntProperty: NoOfIntervals
    /// </summary>
    public unsafe int NoOfIntervals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4256); }
    }

    /// <summary>
    /// FloatProperty: MaxCap
    /// </summary>
    public unsafe float MaxCap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4260); }
    }

    /// <summary>
    /// FloatProperty: MinCap
    /// </summary>
    public unsafe float MinCap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4264); }
    }

    /// <summary>
    /// FloatProperty: ConstantTimeBeforeShimmer
    /// </summary>
    public unsafe float ConstantTimeBeforeShimmer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4268); }
    }

    /// <summary>
    /// ObjectProperty: CopHB
    /// </summary>
    public unsafe BmSDK.BmScript.MPawnVillainCopperheadBoss CopHB
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MPawnVillainCopperheadBoss>(Ptr + 4272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4272); }
    }

    /// <summary>
    /// FloatProperty: DesintegrateVel
    /// </summary>
    public unsafe float DesintegrateVel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4276); }
    }

    /// <summary>
    /// FloatProperty: DesintegrateStartingVal
    /// </summary>
    public unsafe float DesintegrateStartingVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4280); }
    }

    /// <summary>
    /// FloatProperty: GrabCounterDamageVal
    /// </summary>
    public unsafe float GrabCounterDamageVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4284); }
    }

    /// <summary>
    /// ArrayProperty: TauntAnimNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> TauntAnimNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4288); }
    }

    /// <summary>
    /// FloatProperty: PlayTauntMinTime
    /// </summary>
    public unsafe float PlayTauntMinTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4300); }
    }

    /// <summary>
    /// FloatProperty: PlayTauntMaxTime
    /// </summary>
    public unsafe float PlayTauntMaxTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4304); }
    }

    /// <summary>
    /// FloatProperty: fDelayBetweenReverseCorner
    /// </summary>
    public unsafe float fDelayBetweenReverseCorner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4308); }
    }

    /// <summary>
    /// FloatProperty: fLastEvadeCornerTime
    /// </summary>
    public unsafe float fLastEvadeCornerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4312); }
    }

    /// <summary>
    /// ObjectProperty: BatmanPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer BatmanPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 4316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4316); }
    }

    /// <summary>
    /// ObjectProperty: CopHBoss
    /// </summary>
    public unsafe BmSDK.BmScript.MPawnVillainCopperheadBoss CopHBoss
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MPawnVillainCopperheadBoss>(Ptr + 4320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4320); }
    }
}
