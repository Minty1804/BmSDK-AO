#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MPawnVillainShivaMartialArtist<br/>
/// (size = 4260)
/// (flags = 10485814)
/// </summary>
public partial class MPawnVillainShivaMartialArtist : BmSDK.BmScript.MPawnVillainMartialArtist, BmSDK.BmScript.MShivaBossInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MPawnVillainShivaMartialArtist", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MPawnVillainShivaMartialArtist.
    /// </summary>
    public static MPawnVillainShivaMartialArtist DefaultObject => (MPawnVillainShivaMartialArtist)StaticClass().DefaultObject;

    internal MPawnVillainShivaMartialArtist() { }

    /// <summary>
    /// Constructs a new MPawnVillainShivaMartialArtist
    /// </summary>
    public MPawnVillainShivaMartialArtist(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MPawnVillainShivaMartialArtist(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillainShivaMartialArtist>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainShivaMartialArtist>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillainShivaMartialArtist>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainShivaMartialArtist>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainShivaMartialArtist>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainShivaMartialArtist>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillainShivaMartialArtist>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillainShivaMartialArtist>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GoToNextPhase;
    /// <summary>
    /// Function: GoToNextPhase
    /// </summary>
    public unsafe virtual void GoToNextPhase()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GoToNextPhase, "BmScript.MPawnVillainShivaMartialArtist.GoToNextPhase");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PrepareNextPhase;
    /// <summary>
    /// Function: PrepareNextPhase
    /// </summary>
    public unsafe virtual void PrepareNextPhase()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrepareNextPhase, "BmScript.MPawnVillainShivaMartialArtist.PrepareNextPhase");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateShivaNinja;
    /// <summary>
    /// Function: ActivateShivaNinja
    /// </summary>
    public unsafe virtual void ActivateShivaNinja()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateShivaNinja, "BmScript.MPawnVillainShivaMartialArtist.ActivateShivaNinja");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnVillainAttack;
    /// <summary>
    /// Function: SpawnVillainAttack
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RCombatMove_VillainAttack SpawnVillainAttack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnVillainAttack, "BmScript.MPawnVillainShivaMartialArtist.SpawnVillainAttack");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCombatMove_VillainAttack>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayMultiAttackDialogue;
    /// <summary>
    /// Function: PlayMultiAttackDialogue
    /// </summary>
    public unsafe override void PlayMultiAttackDialogue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayMultiAttackDialogue, "BmScript.MPawnVillainShivaMartialArtist.PlayMultiAttackDialogue");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Died, "BmScript.MPawnVillainShivaMartialArtist.Died");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_ModifyDamageAmount;
    /// <summary>
    /// Function: ModifyDamageAmount
    /// </summary>
    public unsafe override void ModifyDamageAmount(BmSDK.Class dmgType, out float DmgAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ModifyDamageAmount, "BmScript.MPawnVillainShivaMartialArtist.ModifyDamageAmount");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DmgAmount);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgAmount, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DmgAmount = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_ShivaInit;
    /// <summary>
    /// Function: ShivaInit
    /// </summary>
    public unsafe virtual void ShivaInit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShivaInit, "BmScript.MPawnVillainShivaMartialArtist.ShivaInit");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayShivaEvadeBossBark;
    /// <summary>
    /// Function: PlayShivaEvadeBossBark
    /// </summary>
    public unsafe override void PlayShivaEvadeBossBark()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayShivaEvadeBossBark, "BmScript.MPawnVillainShivaMartialArtist.PlayShivaEvadeBossBark");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamagedBy, "BmScript.MPawnVillainShivaMartialArtist.DamagedBy");
        byte* paramsPtr = stackalloc byte[296];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 256);
    }

    private static BmSDK.Function __fn_UpdateHealthBar;
    /// <summary>
    /// Function: UpdateHealthBar
    /// </summary>
    public unsafe virtual void UpdateHealthBar()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateHealthBar, "BmScript.MPawnVillainShivaMartialArtist.UpdateHealthBar");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CloseHUD;
    /// <summary>
    /// Function: CloseHUD
    /// </summary>
    public unsafe virtual void CloseHUD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CloseHUD, "BmScript.MPawnVillainShivaMartialArtist.CloseHUD");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitHUD;
    /// <summary>
    /// Function: InitHUD
    /// </summary>
    public unsafe virtual void InitHUD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitHUD, "BmScript.MPawnVillainShivaMartialArtist.InitHUD");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmScript.MPawnVillainShivaMartialArtist.Tick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBlockDamageType;
    /// <summary>
    /// Function: CanBlockDamageType
    /// </summary>
    public unsafe override bool CanBlockDamageType(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBlockDamageType, "BmScript.MPawnVillainShivaMartialArtist.CanBlockDamageType");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanBlock;
    /// <summary>
    /// Function: CanBlock
    /// </summary>
    public unsafe override bool CanBlock()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBlock, "BmScript.MPawnVillainShivaMartialArtist.CanBlock");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetUpAfterHitFloorDelay;
    /// <summary>
    /// Function: GetUpAfterHitFloorDelay
    /// </summary>
    public unsafe override float GetUpAfterHitFloorDelay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUpAfterHitFloorDelay, "BmScript.MPawnVillainShivaMartialArtist.GetUpAfterHitFloorDelay");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldGetUpWhenHitFloor;
    /// <summary>
    /// Function: ShouldGetUpWhenHitFloor
    /// </summary>
    public unsafe override bool ShouldGetUpWhenHitFloor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldGetUpWhenHitFloor, "BmScript.MPawnVillainShivaMartialArtist.ShouldGetUpWhenHitFloor");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetShivaAttackPriorityOffset;
    /// <summary>
    /// Function: GetShivaAttackPriorityOffset
    /// </summary>
    public unsafe virtual int GetShivaAttackPriorityOffset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetShivaAttackPriorityOffset, "BmScript.MPawnVillainShivaMartialArtist.GetShivaAttackPriorityOffset");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanBecomeInactive;
    /// <summary>
    /// Function: CanBecomeInactive
    /// </summary>
    public unsafe virtual bool CanBecomeInactive()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBecomeInactive, "BmScript.MPawnVillainShivaMartialArtist.CanBecomeInactive");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsBossActive;
    /// <summary>
    /// Function: IsBossActive
    /// </summary>
    public unsafe virtual bool IsBossActive()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBossActive, "BmScript.MPawnVillainShivaMartialArtist.IsBossActive");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SpawnSpecialAttack;
    /// <summary>
    /// Function: SpawnSpecialAttack
    /// </summary>
    public unsafe override bool SpawnSpecialAttack(BmSDK.BmGame.RPawnCombat PlayerPawn, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnSpecialAttack, "BmScript.MPawnVillainShivaMartialArtist.SpawnSpecialAttack");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetHealth;
    /// <summary>
    /// Function: SetHealth
    /// </summary>
    public unsafe override void SetHealth()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHealth, "BmScript.MPawnVillainShivaMartialArtist.SetHealth");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwapOut;
    /// <summary>
    /// Function: SwapOut
    /// </summary>
    public unsafe virtual void SwapOut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwapOut, "BmScript.MPawnVillainShivaMartialArtist.SwapOut");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwapIn;
    /// <summary>
    /// Function: SwapIn
    /// </summary>
    public unsafe virtual void SwapIn(BmSDK.BmGame.RPawnVillain otherShiva)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwapIn, "BmScript.MPawnVillainShivaMartialArtist.SwapIn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(otherShiva, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInactive;
    /// <summary>
    /// Function: SetInactive
    /// </summary>
    public unsafe virtual void SetInactive()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInactive, "BmScript.MPawnVillainShivaMartialArtist.SetInactive");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Initialize;
    /// <summary>
    /// Function: Initialize
    /// </summary>
    public unsafe virtual void Initialize(bool SetActive, BmSDK.BmScript.MSeqAct_HandleShiva Control)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialize, "BmScript.MPawnVillainShivaMartialArtist.Initialize");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SetActive, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Control, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: mShivaNinja
    /// </summary>
    public unsafe BmSDK.BmScript.MPawnVillainShivaNinja mShivaNinja
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MPawnVillainShivaNinja>(Ptr + 4216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4216); }
    }

    /// <summary>
    /// FloatProperty: CharSwitchHealthRatio
    /// </summary>
    public unsafe float CharSwitchHealthRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4220); }
    }

    /// <summary>
    /// IntProperty: ShivaAttackPriorityOffset
    /// </summary>
    public unsafe int ShivaAttackPriorityOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4224); }
    }

    /// <summary>
    /// ObjectProperty: ShivaBossBark_MultiAttack
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine ShivaBossBark_MultiAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4228); }
    }

    /// <summary>
    /// BoolProperty: bIsActive
    /// </summary>
    public unsafe bool bIsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4232) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4232); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4232); }
    }

    /// <summary>
    /// BoolProperty: bCanBecomeInactive
    /// </summary>
    public unsafe bool bCanBecomeInactive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4232) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4232); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4232); }
    }

    /// <summary>
    /// StructProperty: HidingLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HidingLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4236);

    /// <summary>
    /// ObjectProperty: ShivasControlNode
    /// </summary>
    public unsafe BmSDK.BmScript.MSeqAct_HandleShiva ShivasControlNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MSeqAct_HandleShiva>(Ptr + 4248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4248); }
    }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 4252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4252); }
    }

    /// <summary>
    /// FloatProperty: ShivaTauntTime
    /// </summary>
    public unsafe float ShivaTauntTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4256); }
    }
}
