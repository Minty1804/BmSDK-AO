#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RBMWeapon<br/>
/// (size = 976)
/// (flags = 142606515)
/// </summary>
public partial class RBMWeapon : BmSDK.Engine.Inventory, BmSDK.BmGame.RXrayInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMWeapon", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMWeapon.
    /// </summary>
    public static RBMWeapon DefaultObject => (RBMWeapon)StaticClass().DefaultObject;

    internal RBMWeapon() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMWeapon(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMWeapon>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeapon>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMWeapon>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeapon>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeapon>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeapon>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMWeapon>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeapon>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetWeaponLight;
    /// <summary>
    /// Function: SetWeaponLight
    /// </summary>
    public unsafe virtual void SetWeaponLight(bool bOn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWeaponLight, "BmGame.RBMWeapon.SetWeaponLight");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCombatIdleStance;
    /// <summary>
    /// Function: GetCombatIdleStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetCombatIdleStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatIdleStance, "BmGame.RBMWeapon.GetCombatIdleStance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnWeaponDestroy;
    /// <summary>
    /// Function: OnWeaponDestroy
    /// </summary>
    public unsafe virtual void OnWeaponDestroy(System.Numerics.Vector3 SmashVel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnWeaponDestroy, "BmGame.RBMWeapon.OnWeaponDestroy");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SmashVel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAerialAttackPriorityOverride;
    /// <summary>
    /// Function: GetAerialAttackPriorityOverride
    /// </summary>
    public unsafe virtual int GetAerialAttackPriorityOverride()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAerialAttackPriorityOverride, "BmGame.RBMWeapon.GetAerialAttackPriorityOverride");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRECPriority;
    /// <summary>
    /// Function: GetRECPriority
    /// </summary>
    public unsafe virtual float GetRECPriority()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRECPriority, "BmGame.RBMWeapon.GetRECPriority");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRECFlailDamageType;
    /// <summary>
    /// Function: GetRECFlailDamageType
    /// </summary>
    public unsafe virtual BmSDK.Class GetRECFlailDamageType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRECFlailDamageType, "BmGame.RBMWeapon.GetRECFlailDamageType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRECHitReactionAnimName;
    /// <summary>
    /// Function: GetRECHitReactionAnimName
    /// </summary>
    public unsafe virtual BmSDK.FName GetRECHitReactionAnimName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRECHitReactionAnimName, "BmGame.RBMWeapon.GetRECHitReactionAnimName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRECHitReactionAnimset;
    /// <summary>
    /// Function: GetRECHitReactionAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetRECHitReactionAnimset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRECHitReactionAnimset, "BmGame.RBMWeapon.GetRECHitReactionAnimset");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMultiAttackAnimNames;
    /// <summary>
    /// Function: GetMultiAttackAnimNames
    /// </summary>
    public unsafe virtual void GetMultiAttackAnimNames(out BmSDK.FName IntroName, out BmSDK.FName AttackName, out BmSDK.FName FailName, out BmSDK.FName CounterName, BmSDK.BmGame.RPawnCombat Player)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMultiAttackAnimNames, "BmGame.RBMWeapon.GetMultiAttackAnimNames");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out IntroName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IntroName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AttackName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackName, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out FailName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FailName, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CounterName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CounterName, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        IntroName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
        AttackName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
        FailName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 16);
        CounterName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 24);
        return;
    }

    private static BmSDK.Function __fn_GetBatClawPriority;
    /// <summary>
    /// Function: GetBatClawPriority
    /// </summary>
    public unsafe virtual float GetBatClawPriority()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatClawPriority, "BmGame.RBMWeapon.GetBatClawPriority");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PairedAnimsLoadFailed;
    /// <summary>
    /// Function: PairedAnimsLoadFailed
    /// </summary>
    public unsafe virtual void PairedAnimsLoadFailed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PairedAnimsLoadFailed, "BmGame.RBMWeapon.PairedAnimsLoadFailed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PairedAnimsSuccessfullyLoaded;
    /// <summary>
    /// Function: PairedAnimsSuccessfullyLoaded
    /// </summary>
    public unsafe virtual void PairedAnimsSuccessfullyLoaded()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PairedAnimsSuccessfullyLoaded, "BmGame.RBMWeapon.PairedAnimsSuccessfullyLoaded");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeRegisterPairedAnimsets;
    /// <summary>
    /// Function: DeRegisterPairedAnimsets
    /// </summary>
    public unsafe virtual void DeRegisterPairedAnimsets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeRegisterPairedAnimsets, "BmGame.RBMWeapon.DeRegisterPairedAnimsets");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterPairedAnimsets;
    /// <summary>
    /// Function: RegisterPairedAnimsets
    /// </summary>
    public unsafe virtual void RegisterPairedAnimsets(BmSDK.Engine.AnimSet PlayerAnimset, BmSDK.Engine.AnimSet VillainAnimSet)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterPairedAnimsets, "BmGame.RBMWeapon.RegisterPairedAnimsets");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerAnimset, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VillainAnimSet, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetDropOnDisarm;
    /// <summary>
    /// Function: SetDropOnDisarm
    /// </summary>
    public unsafe virtual void SetDropOnDisarm(bool bNewValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDropOnDisarm, "BmGame.RBMWeapon.SetDropOnDisarm");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetWeaponNameForBarks;
    /// <summary>
    /// Function: GetWeaponNameForBarks
    /// </summary>
    public unsafe virtual BmSDK.FString GetWeaponNameForBarks()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWeaponNameForBarks, "BmGame.RBMWeapon.GetWeaponNameForBarks");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetOverlayAnim;
    /// <summary>
    /// Function: GetOverlayAnim
    /// </summary>
    public unsafe virtual BmSDK.FName GetOverlayAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOverlayAnim, "BmGame.RBMWeapon.GetOverlayAnim");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTauntAnim;
    /// <summary>
    /// Function: GetTauntAnim
    /// </summary>
    public unsafe virtual int GetTauntAnim(out BmSDK.FName AnimName, out BmSDK.Engine.AnimSet AnimSet, int LastTauntID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTauntAnim, "BmGame.RBMWeapon.GetTauntAnim");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AnimName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AnimSet);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LastTauntID, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AnimName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
        AnimSet = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ShowWeaponRight;
    /// <summary>
    /// Function: ShowWeaponRight
    /// </summary>
    public unsafe virtual void ShowWeaponRight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowWeaponRight, "BmGame.RBMWeapon.ShowWeaponRight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowWeaponLeft;
    /// <summary>
    /// Function: ShowWeaponLeft
    /// </summary>
    public unsafe virtual void ShowWeaponLeft()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowWeaponLeft, "BmGame.RBMWeapon.ShowWeaponLeft");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsWeaponHidden;
    /// <summary>
    /// Function: IsWeaponHidden
    /// </summary>
    public unsafe virtual bool IsWeaponHidden()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsWeaponHidden, "BmGame.RBMWeapon.IsWeaponHidden");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShowWeapon;
    /// <summary>
    /// Function: ShowWeapon
    /// </summary>
    public unsafe virtual void ShowWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowWeapon, "BmGame.RBMWeapon.ShowWeapon");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideWeapon;
    /// <summary>
    /// Function: HideWeapon
    /// </summary>
    public unsafe virtual void HideWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideWeapon, "BmGame.RBMWeapon.HideWeapon");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBeSeenByBatsForXray;
    /// <summary>
    /// Function: CanBeSeenByBatsForXray
    /// </summary>
    public unsafe virtual bool CanBeSeenByBatsForXray()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeSeenByBatsForXray, "BmGame.RBMWeapon.CanBeSeenByBatsForXray");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetInXrayMode;
    /// <summary>
    /// Function: SetInXrayMode
    /// </summary>
    public unsafe virtual void SetInXrayMode(bool On, bool bForceOff)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInXrayMode, "BmGame.RBMWeapon.SetInXrayMode");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetOffhand;
    /// <summary>
    /// Function: SetOffhand
    /// </summary>
    public unsafe virtual void SetOffhand(bool bIsOffhand)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOffhand, "BmGame.RBMWeapon.SetOffhand");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsOffhand, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBeUsedByFriendly;
    /// <summary>
    /// Function: CanBeUsedByFriendly
    /// </summary>
    public unsafe static bool CanBeUsedByFriendly()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeUsedByFriendly, "BmGame.RBMWeapon.CanBeUsedByFriendly");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CreateDestroyedWeapon;
    /// <summary>
    /// Function: CreateDestroyedWeapon
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatThrownObject CreateDestroyedWeapon(bool bDropOnSpawn = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateDestroyedWeapon, "BmGame.RBMWeapon.CreateDestroyedWeapon");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDropOnSpawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMCombatThrownObject>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CreateDroppedWeapon;
    /// <summary>
    /// Function: CreateDroppedWeapon
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatThrownObject CreateDroppedWeapon(bool bDropOnSpawn = default, System.Numerics.Vector3 DropVelocity = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateDroppedWeapon, "BmGame.RBMWeapon.CreateDroppedWeapon");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDropOnSpawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DropVelocity, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMCombatThrownObject>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_SpawnAndThrowWeaponVelocity;
    /// <summary>
    /// Function: SpawnAndThrowWeaponVelocity
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatThrownObject SpawnAndThrowWeaponVelocity(System.Numerics.Vector3 NewVelocity)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnAndThrowWeaponVelocity, "BmGame.RBMWeapon.SpawnAndThrowWeaponVelocity");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewVelocity, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMCombatThrownObject>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SpawnAndThrowWeapon;
    /// <summary>
    /// Function: SpawnAndThrowWeapon
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatThrownObject SpawnAndThrowWeapon(System.Numerics.Vector3 TargetPos = default, float TimeMultiplier = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnAndThrowWeapon, "BmGame.RBMWeapon.SpawnAndThrowWeapon");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeMultiplier, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMCombatThrownObject>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_CreateAndInitThrownObject;
    /// <summary>
    /// Function: CreateAndInitThrownObject
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatThrownObject CreateAndInitThrownObject()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateAndInitThrownObject, "BmGame.RBMWeapon.CreateAndInitThrownObject");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMCombatThrownObject>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Drop;
    /// <summary>
    /// Function: Drop
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatThrownObject Drop()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Drop, "BmGame.RBMWeapon.Drop");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMCombatThrownObject>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ThrowWeaponVelocity;
    /// <summary>
    /// Function: ThrowWeaponVelocity
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatThrownObject ThrowWeaponVelocity(System.Numerics.Vector3 NewVel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThrowWeaponVelocity, "BmGame.RBMWeapon.ThrowWeaponVelocity");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewVel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMCombatThrownObject>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ThrowWeapon;
    /// <summary>
    /// Function: ThrowWeapon
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatThrownObject ThrowWeapon(System.Numerics.Vector3 TargetPos = default, float TimeMultiplier = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThrowWeapon, "BmGame.RBMWeapon.ThrowWeapon");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeMultiplier, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMCombatThrownObject>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_DropFrom;
    /// <summary>
    /// Function: DropFrom
    /// </summary>
    public unsafe override void DropFrom(System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 StartVelocity)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DropFrom, "BmGame.RBMWeapon.DropFrom");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartVelocity, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetWeaponUpAimingConfig;
    /// <summary>
    /// Function: GetWeaponUpAimingConfig
    /// </summary>
    public unsafe static BmSDK.BmGame.RAimingConfig GetWeaponUpAimingConfig()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWeaponUpAimingConfig, "BmGame.RBMWeapon.GetWeaponUpAimingConfig");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAimingConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Disarm;
    /// <summary>
    /// Function: Disarm
    /// </summary>
    public unsafe virtual void Disarm(System.Numerics.Vector3 StartVelocity = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Disarm, "BmGame.RBMWeapon.Disarm");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartVelocity, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ItemRemovedFromInvManager;
    /// <summary>
    /// Function: ItemRemovedFromInvManager
    /// </summary>
    public unsafe override void ItemRemovedFromInvManager()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ItemRemovedFromInvManager, "BmGame.RBMWeapon.ItemRemovedFromInvManager");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCombatBehaviourClass;
    /// <summary>
    /// Function: GetCombatBehaviourClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetCombatBehaviourClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatBehaviourClass, "BmGame.RBMWeapon.GetCombatBehaviourClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CreateWeaponConfig;
    /// <summary>
    /// Function: CreateWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateWeaponConfig(BmSDK.GameObject NewOwner)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateWeaponConfig, "BmGame.RBMWeapon.CreateWeaponConfig");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetLocationAndRotation;
    /// <summary>
    /// Function: GetLocationAndRotation
    /// </summary>
    public unsafe virtual void GetLocationAndRotation(out System.Numerics.Vector3 WeaponLocation, out BmSDK.Rotator WeaponRotation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocationAndRotation, "BmGame.RBMWeapon.GetLocationAndRotation");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out WeaponLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponLocation, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out WeaponRotation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponRotation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        WeaponLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        WeaponRotation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_ReAttach;
    /// <summary>
    /// Function: ReAttach
    /// </summary>
    public unsafe virtual void ReAttach()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReAttach, "BmGame.RBMWeapon.ReAttach");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DetachWeapon;
    /// <summary>
    /// Function: DetachWeapon
    /// </summary>
    public unsafe virtual void DetachWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetachWeapon, "BmGame.RBMWeapon.DetachWeapon");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachWeapon;
    /// <summary>
    /// Function: AttachWeapon
    /// </summary>
    public unsafe virtual void AttachWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachWeapon, "BmGame.RBMWeapon.AttachWeapon");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HitByGel;
    /// <summary>
    /// Function: HitByGel
    /// </summary>
    public unsafe virtual void HitByGel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitByGel, "BmGame.RBMWeapon.HitByGel");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmGame.RBMWeapon.PreStreamOut");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RBMWeapon.Destroyed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeregisterWeaponConfig;
    /// <summary>
    /// Function: DeregisterWeaponConfig
    /// </summary>
    public unsafe virtual void DeregisterWeaponConfig()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeregisterWeaponConfig, "BmGame.RBMWeapon.DeregisterWeaponConfig");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetWeaponConfig;
    /// <summary>
    /// Function: SetWeaponConfig
    /// </summary>
    public unsafe virtual void SetWeaponConfig()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWeaponConfig, "BmGame.RBMWeapon.SetWeaponConfig");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RBMWeapon.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetJammedAttackMoveClass;
    /// <summary>
    /// Function: GetJammedAttackMoveClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetJammedAttackMoveClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetJammedAttackMoveClass, "BmGame.RBMWeapon.GetJammedAttackMoveClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAttackMoveClass;
    /// <summary>
    /// Function: GetAttackMoveClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetAttackMoveClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAttackMoveClass, "BmGame.RBMWeapon.GetAttackMoveClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetMetal;
    /// <summary>
    /// Function: SetMetal
    /// </summary>
    public unsafe virtual void SetMetal(bool bNewMetal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMetal, "BmGame.RBMWeapon.SetMetal");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewMetal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceUpdateXrayVisibility;
    /// <summary>
    /// Function: ForceUpdateXrayVisibility
    /// </summary>
    public unsafe virtual void ForceUpdateXrayVisibility()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceUpdateXrayVisibility, "BmGame.RBMWeapon.ForceUpdateXrayVisibility");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_GetHitSurface;
    /// <summary>
    /// Function: GetHitSurface
    /// </summary>
    public unsafe static bool GetHitSurface(BmSDK.Engine.Actor Actor, out BmSDK.Engine.PhysicalMaterial PhysMaterial)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHitSurface, "BmGame.RBMWeapon.GetHitSurface");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Actor, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PhysMaterial);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PhysMaterial, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PhysMaterial = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PhysicalMaterial>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CancelPairedAnimsetLoading;
    /// <summary>
    /// Function: CancelPairedAnimsetLoading
    /// </summary>
    public unsafe virtual void CancelPairedAnimsetLoading()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelPairedAnimsetLoading, "BmGame.RBMWeapon.CancelPairedAnimsetLoading");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_LoadPairedAnimsetForPlayer;
    /// <summary>
    /// Function: LoadPairedAnimsetForPlayer
    /// </summary>
    public unsafe virtual bool LoadPairedAnimsetForPlayer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadPairedAnimsetForPlayer, "BmGame.RBMWeapon.LoadPairedAnimsetForPlayer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Enum: EHudWeaponType
    /// </summary>
    public enum EHudWeaponType : byte
    {
        HWT_None = 0,
        HWT_Knives = 1,
        HWT_Rifle = 2,
        HWT_Pipe = 3,
        HWT_StunStick = 4,
        HWT_Shotgun = 5,
        HWT_Bat = 6,
        HWT_Bottle = 7,
        HWT_Machete = 8,
        HWT_Sword = 9,
        HWT_Shield = 10,
        HWT_Sledgehammer = 11,
        HWT_Truncheon = 12,
        HWT_GiantHammer = 13,
        HWT_GiantSickle = 14,
        HWT_SniperRifle = 15,
        HWT_DeadshotPistol = 16,
        HWT_TwoFacePistol = 17,
        HWT_FreezeGun = 18,
        HWT_RocketLauncher = 19,
        HWT_JammedRifle = 20,
        HWT_JammedShotgun = 21,
        HWT_JammedSniperRifle = 22,
        HWT_MAX = 23,
    }

    /// <summary>
    /// BoolProperty: bAttached
    /// </summary>
    public unsafe bool bAttached
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bCanBeHitHoldingWeapon
    /// </summary>
    public unsafe bool bCanBeHitHoldingWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bCanBlockHoldingWeapon
    /// </summary>
    public unsafe bool bCanBlockHoldingWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bCanBlockBatarang
    /// </summary>
    public unsafe bool bCanBlockBatarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bCanRepelHoldingWeapon
    /// </summary>
    public unsafe bool bCanRepelHoldingWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bCanTraverseHoldingWeapon
    /// </summary>
    public unsafe bool bCanTraverseHoldingWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bBatclawDisarmsOnHit
    /// </summary>
    public unsafe bool bBatclawDisarmsOnHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bDropOnDisarm
    /// </summary>
    public unsafe bool bDropOnDisarm
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bDisplayDeathTip
    /// </summary>
    public unsafe bool bDisplayDeathTip
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bSmashable
    /// </summary>
    public unsafe bool bSmashable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bOnlySmashableIfThrown
    /// </summary>
    public unsafe bool bOnlySmashableIfThrown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bIsKnife
    /// </summary>
    public unsafe bool bIsKnife
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bIsPipe
    /// </summary>
    public unsafe bool bIsPipe
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bIsHeavyObject
    /// </summary>
    public unsafe bool bIsHeavyObject
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bExplodesOnBatarang
    /// </summary>
    public unsafe bool bExplodesOnBatarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bIsSniper
    /// </summary>
    public unsafe bool bIsSniper
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bReactsToMagneticBlast
    /// </summary>
    public unsafe bool bReactsToMagneticBlast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysDisarmedByMagneticBlast
    /// </summary>
    public unsafe bool bAlwaysDisarmedByMagneticBlast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bBlocksDirectMagBlastHit
    /// </summary>
    public unsafe bool bBlocksDirectMagBlastHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bCanAerialRedirect
    /// </summary>
    public unsafe bool bCanAerialRedirect
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bCanBeUsedByArmoured
    /// </summary>
    public unsafe bool bCanBeUsedByArmoured
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bIsRanged
    /// </summary>
    public unsafe bool bIsRanged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: DropOnFirstHit
    /// </summary>
    public unsafe bool DropOnFirstHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: DropOnBeatdown
    /// </summary>
    public unsafe bool DropOnBeatdown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bWeaponHidden
    /// </summary>
    public unsafe bool bWeaponHidden
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bHasDoneGeneralXrayChecks
    /// </summary>
    public unsafe bool bHasDoneGeneralXrayChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bUseForceXrayCheckResult
    /// </summary>
    public unsafe bool bUseForceXrayCheckResult
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bForcedXrayCheckResult
    /// </summary>
    public unsafe bool bForcedXrayCheckResult
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bIsOverWorld
    /// </summary>
    public unsafe bool bIsOverWorld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: mUseProxyLocAndRot
    /// </summary>
    public unsafe bool mUseProxyLocAndRot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: XRaySet
    /// </summary>
    public unsafe bool XRaySet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: IsMetal
    /// </summary>
    public unsafe bool IsMetal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: AllowMirroring
    /// </summary>
    public unsafe bool AllowMirroring
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 532); }
    }

    /// <summary>
    /// BoolProperty: bXrayPostbeginInit
    /// </summary>
    public unsafe bool bXrayPostbeginInit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 532); }
    }

    /// <summary>
    /// BoolProperty: bCanBatClawAttach
    /// </summary>
    public unsafe bool bCanBatClawAttach
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 532); }
    }

    /// <summary>
    /// BoolProperty: bLoadedPairedAnimsets
    /// </summary>
    public unsafe bool bLoadedPairedAnimsets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 532); }
    }

    /// <summary>
    /// BoolProperty: bWeaponJammed
    /// </summary>
    public unsafe bool bWeaponJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 532); }
    }

    /// <summary>
    /// BoolProperty: bJamDiscovered
    /// </summary>
    public unsafe bool bJamDiscovered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 532); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreWeaponSwitchCallback
    /// </summary>
    public unsafe bool bIgnoreWeaponSwitchCallback
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 532); }
    }

    /// <summary>
    /// NameProperty: CurrentAttachBone
    /// </summary>
    public unsafe BmSDK.FName CurrentAttachBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// NameProperty: PrimaryAttachBone
    /// </summary>
    public unsafe BmSDK.FName PrimaryAttachBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// NameProperty: OffhandAttachBone
    /// </summary>
    public unsafe BmSDK.FName OffhandAttachBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// ComponentProperty: Mesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent Mesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// ObjectProperty: WeaponConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RWeaponConfig WeaponConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// ObjectProperty: DisarmSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent DisarmSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// ObjectProperty: BlockSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent BlockSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// ObjectProperty: HitSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent HitSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// ObjectProperty: HitNPCSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent HitNPCSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// ObjectProperty: SwingSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SwingSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// ObjectProperty: MagBlastReactionAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet MagBlastReactionAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// FloatProperty: VillainThrowDistanceMulti
    /// </summary>
    public unsafe float VillainThrowDistanceMulti
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// ClassProperty: ThrownObjectClass
    /// </summary>
    public unsafe BmSDK.Class ThrownObjectClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// ClassProperty: DestroyedObjectClass
    /// </summary>
    public unsafe BmSDK.Class DestroyedObjectClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// ClassProperty: CombatBehaviourClass
    /// </summary>
    public unsafe BmSDK.Class CombatBehaviourClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// ClassProperty: AttackMoveClass
    /// </summary>
    public unsafe BmSDK.Class AttackMoveClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// ClassProperty: JammedAttackMoveClass
    /// </summary>
    public unsafe BmSDK.Class JammedAttackMoveClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// ClassProperty: SmokeBombReactionClass
    /// </summary>
    public unsafe BmSDK.Class SmokeBombReactionClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// ObjectProperty: LegsGlueSkeletalMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh LegsGlueSkeletalMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// ObjectProperty: LegsGlueSkeletalMeshMirrored
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh LegsGlueSkeletalMeshMirrored
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// ArrayProperty: CameraAnimsets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> CameraAnimsets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// NameProperty: CombatMoveStance
    /// </summary>
    public unsafe BmSDK.FName CombatMoveStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// NameProperty: TauntMoveStance
    /// </summary>
    public unsafe BmSDK.FName TauntMoveStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// ObjectProperty: TauntAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet TauntAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// ArrayProperty: TauntAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> TauntAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// ArrayProperty: OverlayAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> OverlayAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// ArrayProperty: CombatIdleStances
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CombatIdleStances
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ClassProperty: DamageType
    /// </summary>
    public unsafe BmSDK.Class DamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ObjectProperty: OwnerPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCharacter OwnerPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCharacter>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ObjectProperty: AttachedToPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawn AttachedToPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawn>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ByteProperty: TakedownType
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCombat.ETakedownType TakedownType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.ETakedownType>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ByteProperty: WeaponDestroyType
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCombat.EWeaponDestroyType WeaponDestroyType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.EWeaponDestroyType>(Ptr + 709); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 709); }
    }

    /// <summary>
    /// ByteProperty: StrikeTargetType
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCombat.StrikeTargetType StrikeTargetType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.StrikeTargetType>(Ptr + 710); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 710); }
    }

    /// <summary>
    /// ByteProperty: KOGameAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction KOGameAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 711); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 711); }
    }

    /// <summary>
    /// ByteProperty: mFFCModifierType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.FreeFlowCombatModifierType mFFCModifierType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FreeFlowCombatModifierType>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// ByteProperty: HudWeaponType
    /// </summary>
    public unsafe BmSDK.BmGame.RBMWeapon.EHudWeaponType HudWeaponType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMWeapon.EHudWeaponType>(Ptr + 713); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 713); }
    }

    /// <summary>
    /// ByteProperty: HudWeaponTypeWhenJammed
    /// </summary>
    public unsafe BmSDK.BmGame.RBMWeapon.EHudWeaponType HudWeaponTypeWhenJammed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMWeapon.EHudWeaponType>(Ptr + 714); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 714); }
    }

    /// <summary>
    /// ByteProperty: MultiAttackCounterLimb
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat.CounterLimb MultiAttackCounterLimb
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.CounterLimb>(Ptr + 715); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 715); }
    }

    /// <summary>
    /// ByteProperty: WeaponConfigType
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.EWeaponConfigType WeaponConfigType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.EWeaponConfigType>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ByteProperty: CombatReadiness
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI.CombatReadinessState CombatReadiness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI.CombatReadinessState>(Ptr + 717); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 717); }
    }

    /// <summary>
    /// ObjectProperty: BMCounterAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BMCounterAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ObjectProperty: BMTakedownAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BMTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ObjectProperty: CounterAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CounterAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// ObjectProperty: TakedownAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet TakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// NameProperty: SkeletonGetUpAnim
    /// </summary>
    public unsafe BmSDK.FName SkeletonGetUpAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// ObjectProperty: StartledAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet StartledAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// ObjectProperty: ExtraWalksAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet ExtraWalksAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ObjectProperty: WeaponAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet WeaponAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// ObjectProperty: ForceTargetPlayer
    /// </summary>
    public unsafe BmSDK.Engine.PlayerController ForceTargetPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerController>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// FloatProperty: SavedXrayAlpha
    /// </summary>
    public unsafe float SavedXrayAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// FloatProperty: XrayFadeDist
    /// </summary>
    public unsafe float XrayFadeDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// StructProperty: mProxyLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 mProxyLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 768);

    /// <summary>
    /// StructProperty: mProxyRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator mProxyRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 780);

    /// <summary>
    /// ObjectProperty: XRayMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XRayMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// ObjectProperty: XRayMetalMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XRayMetalMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ObjectProperty: ThermalMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface ThermalMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// ObjectProperty: XRayMaterialMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant XRayMaterialMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ObjectProperty: XRayMetalMaterialMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant XRayMetalMaterialMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// ObjectProperty: ThermalMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant ThermalMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// FloatProperty: XRayVisibilityTimer
    /// </summary>
    public unsafe float XRayVisibilityTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// FloatProperty: XRayVisibilityFadeInStartTime
    /// </summary>
    public unsafe float XRayVisibilityFadeInStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// FloatProperty: XRayVisibilityFadeInDuration
    /// </summary>
    public unsafe float XRayVisibilityFadeInDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// StrProperty: FriendlyName
    /// </summary>
    public unsafe BmSDK.FString FriendlyName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ObjectProperty: AdditiveIdleAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet AdditiveIdleAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// NameProperty: AdditiveIdleAnimName
    /// </summary>
    public unsafe BmSDK.FName AdditiveIdleAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// StrProperty: WeaponNameForBarks
    /// </summary>
    public unsafe BmSDK.FString WeaponNameForBarks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// NameProperty: OverworldName
    /// </summary>
    public unsafe BmSDK.FName OverworldName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// ObjectProperty: MyLevelForXray
    /// </summary>
    public unsafe BmSDK.Engine.LevelStreaming MyLevelForXray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LevelStreaming>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// NameProperty: PickupTransitionName
    /// </summary>
    public unsafe BmSDK.FName PickupTransitionName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ObjectProperty: BlockAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BlockAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ArrayProperty: PlayerPairedAnimsetPackageDefs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FPairedAnimsetPackageDef> PlayerPairedAnimsetPackageDefs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FPairedAnimsetPackageDef>>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// IntProperty: CurrPairedAnimsetIndex
    /// </summary>
    public unsafe int CurrPairedAnimsetIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// ArrayProperty: RegisteredPairedAnimsets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> RegisteredPairedAnimsets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// StrProperty: LoadingPairedAnimsetPackage
    /// </summary>
    public unsafe BmSDK.FString LoadingPairedAnimsetPackage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// ArrayProperty: CombatAnimsetRefHolders
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCharacterBioCue> CombatAnimsetRefHolders
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCharacterBioCue>>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// ObjectProperty: HitReactionAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet HitReactionAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// ObjectProperty: BeatdownHitReactionAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BeatdownHitReactionAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// ObjectProperty: VillainAerialAttackAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainAerialAttackAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// ObjectProperty: PlayerAerialAttackAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerAerialAttackAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// ObjectProperty: VillainFloorTakedownAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainFloorTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// ObjectProperty: PlayerFloorTakedownAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerFloorTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ObjectProperty: VillainPushStrikeAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainPushStrikeAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// ObjectProperty: PlayerPushStrikeAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerPushStrikeAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// ObjectProperty: WeaponAudioSwitchName
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName WeaponAudioSwitchName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }
}

/// <summary>
/// The static native functions of RBMWeapon, callable on an instance. A static native may read the object it runs on, and the static form runs it on the class default object, which has no world.
/// </summary>
public static class RBMWeaponStatics
{
    private static BmSDK.Function __fn_GetHitSurface;
    /// <summary>
    /// Function: GetHitSurface, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static bool GetHitSurface(this BmSDK.BmGame.RBMWeapon self, BmSDK.Engine.Actor Actor, out BmSDK.Engine.PhysicalMaterial PhysMaterial)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHitSurface, "BmGame.RBMWeapon.GetHitSurface");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Actor, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PhysMaterial);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PhysMaterial, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PhysMaterial = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PhysicalMaterial>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }
}
