#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RPawnVillainGunPredBase<br/>
/// (size = 4080)
/// (flags = 144703671)
/// </summary>
public partial class RPawnVillainGunPredBase : BmSDK.BmGame.RPawnVillainGunBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnVillainGunPredBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnVillainGunPredBase.
    /// </summary>
    public static RPawnVillainGunPredBase DefaultObject => (RPawnVillainGunPredBase)StaticClass().DefaultObject;

    internal RPawnVillainGunPredBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainGunPredBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CreateCorePanicWeaponConfig;
    /// <summary>
    /// Function: CreateCorePanicWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateCorePanicWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.Engine.AnimSet AnimSet1, BmSDK.Engine.AnimSet AnimSet2, BmSDK.Engine.AnimSet AnimSet3, BmSDK.Engine.AnimSet TurnAnimSet2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateCorePanicWeaponConfig, "BmGame.RPawnVillainGunPredBase.CreateCorePanicWeaponConfig");
        byte* paramsPtr = stackalloc byte[4372];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet2, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet3, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TurnAnimSet2, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_CreateHitReactionWeaponConfigForGun;
    /// <summary>
    /// Function: CreateHitReactionWeaponConfigForGun
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateHitReactionWeaponConfigForGun(BmSDK.GameObject NewOwner, BmSDK.FName CombatMovementStance, BmSDK.Engine.AnimSet AnimSet1, BmSDK.Engine.AnimSet AnimSet2 = default, BmSDK.Engine.AnimSet AnimSet3 = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateHitReactionWeaponConfigForGun, "BmGame.RPawnVillainGunPredBase.CreateHitReactionWeaponConfigForGun");
        byte* paramsPtr = stackalloc byte[1020];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatMovementStance, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet2, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet3, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_AddGrenadeProps;
    /// <summary>
    /// Function: AddGrenadeProps
    /// </summary>
    public unsafe virtual void AddGrenadeProps()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddGrenadeProps, "BmGame.RPawnVillainGunPredBase.AddGrenadeProps");
        byte* paramsPtr = stackalloc byte[168];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WeaponSwitchCallback;
    /// <summary>
    /// Function: WeaponSwitchCallback
    /// </summary>
    public unsafe override void WeaponSwitchCallback(BmSDK.Engine.Inventory NewWeapon, BmSDK.Engine.Inventory PreviousWeapon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WeaponSwitchCallback, "BmGame.RPawnVillainGunPredBase.WeaponSwitchCallback");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousWeapon, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInXrayMode;
    /// <summary>
    /// Function: SetInXrayMode
    /// </summary>
    public unsafe override void SetInXrayMode(bool show, bool bForceOff)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInXrayMode, "BmGame.RPawnVillainGunPredBase.SetInXrayMode");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(show, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGrenadeHidden;
    /// <summary>
    /// Function: SetGrenadeHidden
    /// </summary>
    public unsafe override void SetGrenadeHidden(BmSDK.BmGame.RPawnVillainGunBase.LeftRight GrenadeHand, bool bNewVal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGrenadeHidden, "BmGame.RPawnVillainGunPredBase.SetGrenadeHidden");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrenadeHand, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewVal, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CurrentGrenadeFuseTime;
    /// <summary>
    /// Function: CurrentGrenadeFuseTime
    /// </summary>
    public unsafe override float CurrentGrenadeFuseTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CurrentGrenadeFuseTime, "BmGame.RPawnVillainGunPredBase.CurrentGrenadeFuseTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DoGrenadeLaunch;
    /// <summary>
    /// Function: DoGrenadeLaunch
    /// </summary>
    public unsafe override bool DoGrenadeLaunch(System.Numerics.Vector3 ThrowVel, System.Numerics.Vector3 TargetLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoGrenadeLaunch, "BmGame.RPawnVillainGunPredBase.DoGrenadeLaunch");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowVel, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLoc, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetGrenadeSpawnOffset;
    /// <summary>
    /// Function: GetGrenadeSpawnOffset
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetGrenadeSpawnOffset(BmSDK.Rotator PawnLaunchRot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGrenadeSpawnOffset, "BmGame.RPawnVillainGunPredBase.GetGrenadeSpawnOffset");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnLaunchRot, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_PlaySound_Splash;
    /// <summary>
    /// Function: PlaySound_Splash
    /// </summary>
    public unsafe override void PlaySound_Splash()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySound_Splash, "BmGame.RPawnVillainGunPredBase.PlaySound_Splash");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateMiniCombatWeaponConfig;
    /// <summary>
    /// Function: CreateMiniCombatWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateMiniCombatWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.Engine.AnimSet AnimSet1, BmSDK.Engine.AnimSet AnimSet2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateMiniCombatWeaponConfig, "BmGame.RPawnVillainGunPredBase.CreateMiniCombatWeaponConfig");
        byte* paramsPtr = stackalloc byte[1840];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet2, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CreateWeaponConfigUnarmed;
    /// <summary>
    /// Function: CreateWeaponConfigUnarmed
    /// </summary>
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateWeaponConfigUnarmed(BmSDK.GameObject NewOwner)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateWeaponConfigUnarmed, "BmGame.RPawnVillainGunPredBase.CreateWeaponConfigUnarmed");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PostInitCharacter;
    /// <summary>
    /// Function: PostInitCharacter
    /// </summary>
    public unsafe override void PostInitCharacter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostInitCharacter, "BmGame.RPawnVillainGunPredBase.PostInitCharacter");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsAwareOfPlayer;
    /// <summary>
    /// Function: IsAwareOfPlayer
    /// </summary>
    public unsafe override bool IsAwareOfPlayer(BmSDK.BmGame.RPawnPlayer PlayerPawn, BmSDK.Class dmgType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAwareOfPlayer, "BmGame.RPawnVillainGunPredBase.IsAwareOfPlayer");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// IntProperty: GrenadeLeftIndex
    /// </summary>
    public unsafe int GrenadeLeftIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4072); }
    }

    /// <summary>
    /// IntProperty: GrenadeRightIndex
    /// </summary>
    public unsafe int GrenadeRightIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4076); }
    }
}
