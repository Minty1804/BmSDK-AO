#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDCheatManager<br/>
/// (size = 96)
/// (flags = 32822)
/// </summary>
public partial class GDCheatManager : BmSDK.BmGame.RCheatManager, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDCheatManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDCheatManager.
    /// </summary>
    public static GDCheatManager DefaultObject => (GDCheatManager)StaticClass().DefaultObject;

    internal GDCheatManager() { }

    /// <summary>
    /// Constructs a new GDCheatManager
    /// </summary>
    public GDCheatManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDCheatManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDCheatManager(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDCheatManager>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDCheatManager>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDCheatManager>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDCheatManager>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDCheatManager>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDCheatManager>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDCheatManager>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDCheatManager>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ResumeCape;
    /// <summary>
    /// Function: ResumeCape
    /// </summary>
    public unsafe virtual void ResumeCape()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResumeCape, "BmGame.GDCheatManager.ResumeCape");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PauseCape;
    /// <summary>
    /// Function: PauseCape
    /// </summary>
    public unsafe virtual void PauseCape()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PauseCape, "BmGame.GDCheatManager.PauseCape");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChangeRCRechargeTimer;
    /// <summary>
    /// Function: ChangeRCRechargeTimer
    /// </summary>
    public unsafe virtual void ChangeRCRechargeTimer(float NewTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeRCRechargeTimer, "BmGame.GDCheatManager.ChangeRCRechargeTimer");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChangeRCDetonateTimer;
    /// <summary>
    /// Function: ChangeRCDetonateTimer
    /// </summary>
    public unsafe virtual void ChangeRCDetonateTimer(float NewTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeRCDetonateTimer, "BmGame.GDCheatManager.ChangeRCDetonateTimer");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GiveDualWield;
    /// <summary>
    /// Function: GiveDualWield
    /// </summary>
    public unsafe virtual void GiveDualWield()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveDualWield, "BmGame.GDCheatManager.GiveDualWield");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSubtitleDebug;
    /// <summary>
    /// Function: SetSubtitleDebug
    /// </summary>
    public unsafe virtual void SetSubtitleDebug(bool Enabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSubtitleDebug, "BmGame.GDCheatManager.SetSubtitleDebug");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Enabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableTTS;
    /// <summary>
    /// Function: EnableTTS
    /// </summary>
    public unsafe virtual void EnableTTS(bool Enabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableTTS, "BmGame.GDCheatManager.EnableTTS");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Enabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableBarks;
    /// <summary>
    /// Function: EnableBarks
    /// </summary>
    public unsafe virtual void EnableBarks(bool Enabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableBarks, "BmGame.GDCheatManager.EnableBarks");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Enabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleSpreadDebug;
    /// <summary>
    /// Function: ToggleSpreadDebug
    /// </summary>
    public unsafe virtual void ToggleSpreadDebug(bool bEnable, bool bSpread = default, bool bTrajectory = default, bool bHitPos = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleSpreadDebug, "BmGame.GDCheatManager.ToggleSpreadDebug");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnable, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpread, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTrajectory, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHitPos, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateDebugSpreadValues;
    /// <summary>
    /// Function: CreateDebugSpreadValues
    /// </summary>
    public unsafe virtual void CreateDebugSpreadValues()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateDebugSpreadValues, "BmGame.GDCheatManager.CreateDebugSpreadValues");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableRecoil;
    /// <summary>
    /// Function: DisableRecoil
    /// </summary>
    public unsafe virtual void DisableRecoil()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableRecoil, "BmGame.GDCheatManager.DisableRecoil");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EquipGadget;
    /// <summary>
    /// Function: EquipGadget
    /// </summary>
    public unsafe virtual void EquipGadget(BmSDK.FString _name, int UppgradeIndex = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EquipGadget, "BmGame.GDCheatManager.EquipGadget");
        byte* paramsPtr = stackalloc byte[33];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_name, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UppgradeIndex, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EquipGadgetById;
    /// <summary>
    /// Function: EquipGadgetById
    /// </summary>
    public unsafe virtual void EquipGadgetById(BmSDK.BmGame.RGameInfo.PlayerGadgetId _id, int UppgradeIndex = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EquipGadgetById, "BmGame.GDCheatManager.EquipGadgetById");
        byte* paramsPtr = stackalloc byte[160];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UppgradeIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCurrentWeaponSkin;
    /// <summary>
    /// Function: SetCurrentWeaponSkin
    /// </summary>
    public unsafe virtual void SetCurrentWeaponSkin(int SkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentWeaponSkin, "BmGame.GDCheatManager.SetCurrentWeaponSkin");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkinIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetWeaponUpgradeLevel;
    /// <summary>
    /// Function: SetWeaponUpgradeLevel
    /// </summary>
    public unsafe virtual void SetWeaponUpgradeLevel(BmSDK.BmGame.RGameInfo.WeaponId Weapon, int Level)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWeaponUpgradeLevel, "BmGame.GDCheatManager.SetWeaponUpgradeLevel");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Weapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Level, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCurrentWeaponUpgradeLevel;
    /// <summary>
    /// Function: SetCurrentWeaponUpgradeLevel
    /// </summary>
    public unsafe virtual void SetCurrentWeaponUpgradeLevel(int Level)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentWeaponUpgradeLevel, "BmGame.GDCheatManager.SetCurrentWeaponUpgradeLevel");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Level, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAccountLevel;
    /// <summary>
    /// Function: SetAccountLevel
    /// </summary>
    public unsafe virtual void SetAccountLevel(int _lvl)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAccountLevel, "BmGame.GDCheatManager.SetAccountLevel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_lvl, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetJokerGangLevel;
    /// <summary>
    /// Function: SetJokerGangLevel
    /// </summary>
    public unsafe virtual void SetJokerGangLevel(int _lvl)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetJokerGangLevel, "BmGame.GDCheatManager.SetJokerGangLevel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_lvl, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetBaneGangLevel;
    /// <summary>
    /// Function: SetBaneGangLevel
    /// </summary>
    public unsafe virtual void SetBaneGangLevel(int _lvl)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBaneGangLevel, "BmGame.GDCheatManager.SetBaneGangLevel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_lvl, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLevel;
    /// <summary>
    /// Function: SetLevel
    /// </summary>
    public unsafe void SetLevel(int _lvl, BmSDK.FString _on)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLevel, "BmGame.GDCheatManager.SetLevel");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_lvl, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_on, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPlayerName;
    /// <summary>
    /// Function: SetPlayerName
    /// </summary>
    public unsafe virtual void SetPlayerName(BmSDK.FString _name)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPlayerName, "BmGame.GDCheatManager.SetPlayerName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_name, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceLoadProfile;
    /// <summary>
    /// Function: ForceLoadProfile
    /// </summary>
    public unsafe virtual void ForceLoadProfile(int _player = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceLoadProfile, "BmGame.GDCheatManager.ForceLoadProfile");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceSaveProfile;
    /// <summary>
    /// Function: ForceSaveProfile
    /// </summary>
    public unsafe virtual void ForceSaveProfile()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceSaveProfile, "BmGame.GDCheatManager.ForceSaveProfile");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddXPForFactionLevel;
    /// <summary>
    /// Function: AddXPForFactionLevel
    /// </summary>
    public unsafe virtual void AddXPForFactionLevel(int RequiredLevel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddXPForFactionLevel, "BmGame.GDCheatManager.AddXPForFactionLevel");
        byte* paramsPtr = stackalloc byte[29];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequiredLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddXPForAccountLevel;
    /// <summary>
    /// Function: AddXPForAccountLevel
    /// </summary>
    public unsafe virtual void AddXPForAccountLevel(int RequiredLevel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddXPForAccountLevel, "BmGame.GDCheatManager.AddXPForAccountLevel");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RequiredLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetProgression;
    /// <summary>
    /// Function: ResetProgression
    /// </summary>
    public unsafe virtual void ResetProgression()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetProgression, "BmGame.GDCheatManager.ResetProgression");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerPrestige;
    /// <summary>
    /// Function: TriggerPrestige
    /// </summary>
    public unsafe virtual void TriggerPrestige()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerPrestige, "BmGame.GDCheatManager.TriggerPrestige");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockEverything;
    /// <summary>
    /// Function: UnlockEverything
    /// </summary>
    public unsafe virtual void UnlockEverything()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockEverything, "BmGame.GDCheatManager.UnlockEverything");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ListAllRecentUnlocks;
    /// <summary>
    /// Function: ListAllRecentUnlocks
    /// </summary>
    public unsafe virtual void ListAllRecentUnlocks()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListAllRecentUnlocks, "BmGame.GDCheatManager.ListAllRecentUnlocks");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceQuickMatchCreateGame;
    /// <summary>
    /// Function: ForceQuickMatchCreateGame
    /// </summary>
    public unsafe virtual void ForceQuickMatchCreateGame(bool Force)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceQuickMatchCreateGame, "BmGame.GDCheatManager.ForceQuickMatchCreateGame");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Force, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpLobbyMembers;
    /// <summary>
    /// Function: DumpLobbyMembers
    /// </summary>
    public unsafe virtual void DumpLobbyMembers()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpLobbyMembers, "BmGame.GDCheatManager.DumpLobbyMembers");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerAllSurprisePackages;
    /// <summary>
    /// Function: TriggerAllSurprisePackages
    /// </summary>
    public unsafe virtual void TriggerAllSurprisePackages()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerAllSurprisePackages, "BmGame.GDCheatManager.TriggerAllSurprisePackages");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceAimAssistanceOff;
    /// <summary>
    /// Function: ForceAimAssistanceOff
    /// </summary>
    public unsafe virtual void ForceAimAssistanceOff()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceAimAssistanceOff, "BmGame.GDCheatManager.ForceAimAssistanceOff");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceAimAssistanceOn;
    /// <summary>
    /// Function: ForceAimAssistanceOn
    /// </summary>
    public unsafe virtual void ForceAimAssistanceOn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceAimAssistanceOn, "BmGame.GDCheatManager.ForceAimAssistanceOn");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceShowAllAltSkins;
    /// <summary>
    /// Function: ForceShowAllAltSkins
    /// </summary>
    public unsafe virtual void ForceShowAllAltSkins(bool bShow = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceShowAllAltSkins, "BmGame.GDCheatManager.ForceShowAllAltSkins");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientLocalTeamCommanderSpeak;
    /// <summary>
    /// Function: ClientLocalTeamCommanderSpeak
    /// </summary>
    public unsafe virtual void ClientLocalTeamCommanderSpeak(BmSDK.FString EventName, bool SecondaryCommander, bool MapSpecific = default, BmSDK.FString ArgumentValue = default, BmSDK.FString Argument2Value = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientLocalTeamCommanderSpeak, "BmGame.GDCheatManager.ClientLocalTeamCommanderSpeak");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SecondaryCommander, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapSpecific, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArgumentValue, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Argument2Value, paramsPtr + 32);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_ClientCharacterSpeak;
    /// <summary>
    /// Function: ClientCharacterSpeak
    /// </summary>
    public unsafe virtual void ClientCharacterSpeak(BmSDK.FString SpeakerName, BmSDK.FString EventName, bool MapSpecific = default, BmSDK.FString ArgumentValue = default, BmSDK.FString Argument2Value = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientCharacterSpeak, "BmGame.GDCheatManager.ClientCharacterSpeak");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpeakerName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapSpecific, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArgumentValue, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Argument2Value, paramsPtr + 40);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }

    private static BmSDK.Function __fn_ClientLocalCharacterSpeak;
    /// <summary>
    /// Function: ClientLocalCharacterSpeak
    /// </summary>
    public unsafe virtual void ClientLocalCharacterSpeak(BmSDK.FString EventName, bool MapSpecific = default, BmSDK.FString ArgumentValue = default, BmSDK.FString Argument2Value = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientLocalCharacterSpeak, "BmGame.GDCheatManager.ClientLocalCharacterSpeak");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapSpecific, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArgumentValue, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Argument2Value, paramsPtr + 28);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return;
    }
}
