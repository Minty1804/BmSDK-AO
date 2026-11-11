#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: GDPawnPlayerJoker<br/>
/// (size = 7736)
/// (flags = 10518582)
/// </summary>
public partial class GDPawnPlayerJoker : BmSDK.BmScript.GDPawnPlayerThug, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.GDPawnPlayerJoker", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDPawnPlayerJoker.
    /// </summary>
    public static GDPawnPlayerJoker DefaultObject => (GDPawnPlayerJoker)StaticClass().DefaultObject;

    internal GDPawnPlayerJoker() { }

    /// <summary>
    /// Constructs a new GDPawnPlayerJoker
    /// </summary>
    public GDPawnPlayerJoker(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDPawnPlayerJoker(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerJoker>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerJoker>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerJoker>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerJoker>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerJoker>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerJoker>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerJoker>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerJoker>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CreateCombatWeaponConfig;
    /// <summary>
    /// Function: CreateCombatWeaponConfig
    /// </summary>
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateCombatWeaponConfig()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateCombatWeaponConfig, "BmScript.GDPawnPlayerJoker.CreateCombatWeaponConfig");
        byte* paramsPtr = stackalloc byte[1252];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FindAndPlayOverrideDeathAnim;
    /// <summary>
    /// Function: FindAndPlayOverrideDeathAnim
    /// </summary>
    public unsafe override bool FindAndPlayOverrideDeathAnim(BmSDK.Class DamageType, bool IsHeadshot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindAndPlayOverrideDeathAnim, "BmScript.GDPawnPlayerJoker.FindAndPlayOverrideDeathAnim");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsHeadshot, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ShouldGoRagdoll;
    /// <summary>
    /// Function: ShouldGoRagdoll
    /// </summary>
    public unsafe override bool ShouldGoRagdoll(BmSDK.Class dmgType, float DamageAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldGoRagdoll, "BmScript.GDPawnPlayerJoker.ShouldGoRagdoll");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsValidTakedown;
    /// <summary>
    /// Function: IsValidTakedown
    /// </summary>
    public unsafe override bool IsValidTakedown(BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidTakedown, "BmScript.GDPawnPlayerJoker.IsValidTakedown");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsAwareOfPlayer;
    /// <summary>
    /// Function: IsAwareOfPlayer
    /// </summary>
    public unsafe override bool IsAwareOfPlayer(BmSDK.BmGame.RPawnPlayer PlayerPawn, BmSDK.Class dmgType = default, bool PostCheck = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAwareOfPlayer, "BmScript.GDPawnPlayerJoker.IsAwareOfPlayer");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PostCheck, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_HACK_OnlyUseFirstTakedown;
    /// <summary>
    /// Function: HACK_OnlyUseFirstTakedown
    /// </summary>
    public unsafe override bool HACK_OnlyUseFirstTakedown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HACK_OnlyUseFirstTakedown, "BmScript.GDPawnPlayerJoker.HACK_OnlyUseFirstTakedown");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanBeDoubleTakeDownVictim;
    /// <summary>
    /// Function: CanBeDoubleTakeDownVictim
    /// </summary>
    public unsafe override bool CanBeDoubleTakeDownVictim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeDoubleTakeDownVictim, "BmScript.GDPawnPlayerJoker.CanBeDoubleTakeDownVictim");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanBeTakeDownVictim;
    /// <summary>
    /// Function: CanBeTakeDownVictim
    /// </summary>
    public unsafe override bool CanBeTakeDownVictim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeTakeDownVictim, "BmScript.GDPawnPlayerJoker.CanBeTakeDownVictim");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ReduceTakedownLives;
    /// <summary>
    /// Function: ReduceTakedownLives
    /// </summary>
    public unsafe override void ReduceTakedownLives()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReduceTakedownLives, "BmScript.GDPawnPlayerJoker.ReduceTakedownLives");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AreTakedownsFatal;
    /// <summary>
    /// Function: AreTakedownsFatal
    /// </summary>
    public unsafe override bool AreTakedownsFatal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreTakedownsFatal, "BmScript.GDPawnPlayerJoker.AreTakedownsFatal");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNonFatalTakedownDamage;
    /// <summary>
    /// Function: GetNonFatalTakedownDamage
    /// </summary>
    public unsafe override float GetNonFatalTakedownDamage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNonFatalTakedownDamage, "BmScript.GDPawnPlayerJoker.GetNonFatalTakedownDamage");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DisableJoyBuzzerLight;
    /// <summary>
    /// Function: DisableJoyBuzzerLight
    /// </summary>
    public unsafe virtual void DisableJoyBuzzerLight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableJoyBuzzerLight, "BmScript.GDPawnPlayerJoker.DisableJoyBuzzerLight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableJoyBuzzerLight;
    /// <summary>
    /// Function: EnableJoyBuzzerLight
    /// </summary>
    public unsafe virtual void EnableJoyBuzzerLight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableJoyBuzzerLight, "BmScript.GDPawnPlayerJoker.EnableJoyBuzzerLight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindContactName;
    /// <summary>
    /// Function: FindContactName
    /// </summary>
    public unsafe override BmSDK.Engine.AkEvent FindContactName(BmSDK.BmGame.RAnimNotify_Footstep.EFoot Foot, BmSDK.BmGame.RAnimNotify_Footstep.EContactType Contact)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindContactName, "BmScript.GDPawnPlayerJoker.FindContactName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Foot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Contact, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetSupervillainSpawnStunEffectVars;
    /// <summary>
    /// Function: GetSupervillainSpawnStunEffectVars
    /// </summary>
    public unsafe override void GetSupervillainSpawnStunEffectVars(out BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo Effect, out BmSDK.FName SocketName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSupervillainSpawnStunEffectVars, "BmScript.GDPawnPlayerJoker.GetSupervillainSpawnStunEffectVars");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SocketName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SocketName, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Effect = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo>(paramsPtr + 0);
        SocketName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 48);
        return;
    }

    private static BmSDK.Function __fn_GetSupervillainGetUpStunRadius;
    /// <summary>
    /// Function: GetSupervillainGetUpStunRadius
    /// </summary>
    public unsafe override void GetSupervillainGetUpStunRadius(out float StunRadius, out float StunRadiusMaxZ)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSupervillainGetUpStunRadius, "BmScript.GDPawnPlayerJoker.GetSupervillainGetUpStunRadius");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StunRadius);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StunRadius, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StunRadiusMaxZ);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StunRadiusMaxZ, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        StunRadius = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        StunRadiusMaxZ = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_GetSupervillainGetUpStunVars;
    /// <summary>
    /// Function: GetSupervillainGetUpStunVars
    /// </summary>
    public unsafe override void GetSupervillainGetUpStunVars(out float StunDuration, out float StunMomentumTransfer, out float StunDmg, out byte StunFriendlies)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSupervillainGetUpStunVars, "BmScript.GDPawnPlayerJoker.GetSupervillainGetUpStunVars");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StunDuration);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StunDuration, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StunMomentumTransfer);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StunMomentumTransfer, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StunDmg);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StunDmg, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StunFriendlies);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StunFriendlies, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        StunDuration = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        StunMomentumTransfer = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        StunDmg = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        StunFriendlies = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetSupervillainStunRadius;
    /// <summary>
    /// Function: GetSupervillainStunRadius
    /// </summary>
    public unsafe override void GetSupervillainStunRadius(out float StunRadius, out float StunRadiusMaxZ)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSupervillainStunRadius, "BmScript.GDPawnPlayerJoker.GetSupervillainStunRadius");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StunRadius);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StunRadius, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StunRadiusMaxZ);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StunRadiusMaxZ, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        StunRadius = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        StunRadiusMaxZ = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_GetSupervillainStunVars;
    /// <summary>
    /// Function: GetSupervillainStunVars
    /// </summary>
    public unsafe override void GetSupervillainStunVars(out float StunDuration, out float StunMomentumTransfer, out float StunDmg, out byte StunFriendlies)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSupervillainStunVars, "BmScript.GDPawnPlayerJoker.GetSupervillainStunVars");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StunDuration);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StunDuration, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StunMomentumTransfer);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StunMomentumTransfer, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StunDmg);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StunDmg, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StunFriendlies);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StunFriendlies, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        StunDuration = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        StunMomentumTransfer = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        StunDmg = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        StunFriendlies = BmSDK.Framework.MarshalUtil.ToManagedParam<byte>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetIntroAnimationNamesAndSets;
    /// <summary>
    /// Function: GetIntroAnimationNamesAndSets
    /// </summary>
    public unsafe override void GetIntroAnimationNamesAndSets(out BmSDK.Engine.AnimSet SupervillainIntroAnimSet, out BmSDK.Engine.AnimSet ThugIntroAnimSet, out BmSDK.Engine.AnimSet CameraIntroAnimSet, out BmSDK.FName SupervillainIntroAnimName, out BmSDK.FName ThugIntroAnimName, out BmSDK.FName CameraIntroAnimName, out float CameraIntroBlendTime, out float CameraIntroFOV, out int CameraIntroHardCut)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIntroAnimationNamesAndSets, "BmScript.GDPawnPlayerJoker.GetIntroAnimationNamesAndSets");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SupervillainIntroAnimSet);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SupervillainIntroAnimSet, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ThugIntroAnimSet);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugIntroAnimSet, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CameraIntroAnimSet);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraIntroAnimSet, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SupervillainIntroAnimName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SupervillainIntroAnimName, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ThugIntroAnimName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugIntroAnimName, paramsPtr + 20);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CameraIntroAnimName);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraIntroAnimName, paramsPtr + 28);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CameraIntroBlendTime);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraIntroBlendTime, paramsPtr + 36);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CameraIntroFOV);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraIntroFOV, paramsPtr + 40);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CameraIntroHardCut);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraIntroHardCut, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SupervillainIntroAnimSet = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
        ThugIntroAnimSet = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 4);
        CameraIntroAnimSet = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 8);
        SupervillainIntroAnimName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 12);
        ThugIntroAnimName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 20);
        CameraIntroAnimName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 28);
        CameraIntroBlendTime = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 36);
        CameraIntroFOV = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 40);
        CameraIntroHardCut = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 44);
        return;
    }

    private static BmSDK.Function __fn_TurnOnHandsIk;
    /// <summary>
    /// Function: TurnOnHandsIk
    /// </summary>
    public unsafe override bool TurnOnHandsIk(float fStrengthValue, float fEaseInTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOnHandsIk, "BmScript.GDPawnPlayerJoker.TurnOnHandsIk");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fStrengthValue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fEaseInTime, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FinishedGetUp;
    /// <summary>
    /// Function: FinishedGetUp
    /// </summary>
    public unsafe override void FinishedGetUp()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishedGetUp, "BmScript.GDPawnPlayerJoker.FinishedGetUp");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoRagdoll;
    /// <summary>
    /// Function: GotoRagdoll
    /// </summary>
    public unsafe override void GotoRagdoll(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo, bool bKill)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoRagdoll, "BmScript.GDPawnPlayerJoker.GotoRagdoll");
        byte* paramsPtr = stackalloc byte[264];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKill, paramsPtr + 244);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DamagedBy;
    /// <summary>
    /// Function: DamagedBy
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult DamagedBy(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamagedBy, "BmScript.GDPawnPlayerJoker.DamagedBy");
        byte* paramsPtr = stackalloc byte[261];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 244);
    }

    private static BmSDK.Function __fn_GetTimeToClearQuickStrikeCount;
    /// <summary>
    /// Function: GetTimeToClearQuickStrikeCount
    /// </summary>
    public unsafe override float GetTimeToClearQuickStrikeCount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTimeToClearQuickStrikeCount, "BmScript.GDPawnPlayerJoker.GetTimeToClearQuickStrikeCount");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNumQuickStrikeToRagdoll;
    /// <summary>
    /// Function: GetNumQuickStrikeToRagdoll
    /// </summary>
    public unsafe override int GetNumQuickStrikeToRagdoll()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumQuickStrikeToRagdoll, "BmScript.GDPawnPlayerJoker.GetNumQuickStrikeToRagdoll");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsOkToPlayTakedownVictimAnim;
    /// <summary>
    /// Function: IsOkToPlayTakedownVictimAnim
    /// </summary>
    public unsafe override bool IsOkToPlayTakedownVictimAnim(BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsOkToPlayTakedownVictimAnim, "BmScript.GDPawnPlayerJoker.IsOkToPlayTakedownVictimAnim");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetHeldGadgetByGadgetID;
    /// <summary>
    /// Function: GetHeldGadgetByGadgetID
    /// </summary>
    public unsafe override BmSDK.BmGame.RInventoryGadget GetHeldGadgetByGadgetID(BmSDK.BmGame.RGameInfo.PlayerGadgetId _gadget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeldGadgetByGadgetID, "BmScript.GDPawnPlayerJoker.GetHeldGadgetByGadgetID");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_gadget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RInventoryGadget>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IncreaseHealthRegenModifier;
    /// <summary>
    /// Function: IncreaseHealthRegenModifier
    /// </summary>
    public unsafe override void IncreaseHealthRegenModifier(float fModifier)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncreaseHealthRegenModifier, "BmScript.GDPawnPlayerJoker.IncreaseHealthRegenModifier");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fModifier, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IncreaseDashModifier;
    /// <summary>
    /// Function: IncreaseDashModifier
    /// </summary>
    public unsafe override void IncreaseDashModifier(float fModifier)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncreaseDashModifier, "BmScript.GDPawnPlayerJoker.IncreaseDashModifier");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fModifier, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayExplosionDeathPrimer;
    /// <summary>
    /// Function: PlayExplosionDeathPrimer
    /// </summary>
    public unsafe override bool PlayExplosionDeathPrimer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayExplosionDeathPrimer, "BmScript.GDPawnPlayerJoker.PlayExplosionDeathPrimer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPlayerAvatarString;
    /// <summary>
    /// Function: GetPlayerAvatarString
    /// </summary>
    public unsafe override BmSDK.FString GetPlayerAvatarString()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerAvatarString, "BmScript.GDPawnPlayerJoker.GetPlayerAvatarString");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetContactCharacterName;
    /// <summary>
    /// Function: GetContactCharacterName
    /// </summary>
    public unsafe override BmSDK.FString GetContactCharacterName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetContactCharacterName, "BmScript.GDPawnPlayerJoker.GetContactCharacterName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RemoveSpawnProtection;
    /// <summary>
    /// Function: RemoveSpawnProtection
    /// </summary>
    public unsafe override void RemoveSpawnProtection()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveSpawnProtection, "BmScript.GDPawnPlayerJoker.RemoveSpawnProtection");
        byte* paramsPtr = stackalloc byte[20];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmScript.GDPawnPlayerJoker.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// IntProperty: TakedownLives
    /// </summary>
    public unsafe int TakedownLives
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7728); }
    }

    /// <summary>
    /// ComponentProperty: JoyBuzzerCheapLightInstance
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent JoyBuzzerCheapLightInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 7732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7732); }
    }
}
