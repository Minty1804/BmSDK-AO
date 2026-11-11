#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: GDBaseGunGadget<br/>
/// (size = 2388)
/// (flags = 144736439)
/// </summary>
public partial class GDBaseGunGadget : BmSDK.BmGame.RInventoryGadget, BmSDK.BmGame.GDXRayInterface, BmSDK.BmGame.GDGunInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDBaseGunGadget", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDBaseGunGadget.
    /// </summary>
    public static GDBaseGunGadget DefaultObject => (GDBaseGunGadget)StaticClass().DefaultObject;

    internal GDBaseGunGadget() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDBaseGunGadget(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDBaseGunGadget>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDBaseGunGadget>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDBaseGunGadget>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDBaseGunGadget>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDBaseGunGadget>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDBaseGunGadget>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDBaseGunGadget>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDBaseGunGadget>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GenerateDebugSpreadValues;
    /// <summary>
    /// Function: GenerateDebugSpreadValues
    /// </summary>
    public unsafe virtual void GenerateDebugSpreadValues(int Start = default, int End = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GenerateDebugSpreadValues, "BmGame.GDBaseGunGadget.GenerateDebugSpreadValues");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetXRayOpacitySkillBased;
    /// <summary>
    /// Function: SetXRayOpacitySkillBased
    /// </summary>
    public unsafe virtual void SetXRayOpacitySkillBased(bool bEnable)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetXRayOpacitySkillBased, "BmGame.GDBaseGunGadget.SetXRayOpacitySkillBased");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnable, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitXRayMode;
    /// <summary>
    /// Function: ExitXRayMode
    /// </summary>
    public unsafe virtual void ExitXRayMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitXRayMode, "BmGame.GDBaseGunGadget.ExitXRayMode");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyXRayParameters;
    /// <summary>
    /// Function: ApplyXRayParameters
    /// </summary>
    public unsafe virtual void ApplyXRayParameters(BmSDK.BmGame.GDXRayParameters Params)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyXRayParameters, "BmGame.GDBaseGunGadget.ApplyXRayParameters");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Params, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetOwningPawn;
    /// <summary>
    /// Function: GetOwningPawn
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnPlayer GetOwningPawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOwningPawn, "BmGame.GDBaseGunGadget.GetOwningPawn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayer>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetMetal;
    /// <summary>
    /// Function: SetMetal
    /// </summary>
    public unsafe virtual void SetMetal(bool bNewMetal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMetal, "BmGame.GDBaseGunGadget.SetMetal");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewMetal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAimingScopeMinMaxSpreadDist;
    /// <summary>
    /// Function: SetAimingScopeMinMaxSpreadDist
    /// </summary>
    public unsafe virtual void SetAimingScopeMinMaxSpreadDist(float MaxSpreadDist, float MinSpreadDist)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAimingScopeMinMaxSpreadDist, "BmGame.GDBaseGunGadget.SetAimingScopeMinMaxSpreadDist");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxSpreadDist, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinSpreadDist, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAimingScopeSpreadProportion;
    /// <summary>
    /// Function: SetAimingScopeSpreadProportion
    /// </summary>
    public unsafe virtual void SetAimingScopeSpreadProportion(float fSpreadProportion)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAimingScopeSpreadProportion, "BmGame.GDBaseGunGadget.SetAimingScopeSpreadProportion");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fSpreadProportion, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawTargets;
    /// <summary>
    /// Function: DrawTargets
    /// </summary>
    public unsafe virtual void DrawTargets(BmSDK.Engine.HUD H)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawTargets, "BmGame.GDBaseGunGadget.DrawTargets");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckCrosshairTargetCursor;
    /// <summary>
    /// Function: CheckCrosshairTargetCursor
    /// </summary>
    public unsafe virtual void CheckCrosshairTargetCursor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckCrosshairTargetCursor, "BmGame.GDBaseGunGadget.CheckCrosshairTargetCursor");
        byte* paramsPtr = stackalloc byte[49];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowLowAlphaTargetCursor;
    /// <summary>
    /// Function: ShowLowAlphaTargetCursor
    /// </summary>
    public unsafe virtual bool ShowLowAlphaTargetCursor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowLowAlphaTargetCursor, "BmGame.GDBaseGunGadget.ShowLowAlphaTargetCursor");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DrawHUD;
    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe override void DrawHUD(BmSDK.Engine.HUD H)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawHUD, "BmGame.GDBaseGunGadget.DrawHUD");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Equipped;
    /// <summary>
    /// Function: Equipped
    /// </summary>
    public unsafe virtual void Equipped()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Equipped, "BmGame.GDBaseGunGadget.Equipped");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientShowEquippedWeapon;
    /// <summary>
    /// Function: ClientShowEquippedWeapon
    /// </summary>
    public unsafe virtual void ClientShowEquippedWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientShowEquippedWeapon, "BmGame.GDBaseGunGadget.ClientShowEquippedWeapon");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideEquippedWeapon;
    /// <summary>
    /// Function: HideEquippedWeapon
    /// </summary>
    public unsafe virtual void HideEquippedWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideEquippedWeapon, "BmGame.GDBaseGunGadget.HideEquippedWeapon");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowEquippedWeapon;
    /// <summary>
    /// Function: ShowEquippedWeapon
    /// </summary>
    public unsafe virtual void ShowEquippedWeapon()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowEquippedWeapon, "BmGame.GDBaseGunGadget.ShowEquippedWeapon");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Unequipped;
    /// <summary>
    /// Function: Unequipped
    /// </summary>
    public unsafe virtual void Unequipped()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Unequipped, "BmGame.GDBaseGunGadget.Unequipped");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerUnequip;
    /// <summary>
    /// Function: ServerUnequip
    /// </summary>
    public unsafe virtual void ServerUnequip()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerUnequip, "BmGame.GDBaseGunGadget.ServerUnequip");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GunReloaded;
    /// <summary>
    /// Function: GunReloaded
    /// </summary>
    public unsafe virtual void GunReloaded()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GunReloaded, "BmGame.GDBaseGunGadget.GunReloaded");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsEquipAnimationActive;
    /// <summary>
    /// Function: IsEquipAnimationActive
    /// </summary>
    public unsafe virtual bool IsEquipAnimationActive()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsEquipAnimationActive, "BmGame.GDBaseGunGadget.IsEquipAnimationActive");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsReloadAnimationActive;
    /// <summary>
    /// Function: IsReloadAnimationActive
    /// </summary>
    public unsafe virtual bool IsReloadAnimationActive()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsReloadAnimationActive, "BmGame.GDBaseGunGadget.IsReloadAnimationActive");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ResetHandIKs;
    /// <summary>
    /// Function: ResetHandIKs
    /// </summary>
    public unsafe override void ResetHandIKs()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetHandIKs, "BmGame.GDBaseGunGadget.ResetHandIKs");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientResetHandIKs;
    /// <summary>
    /// Function: ClientResetHandIKs
    /// </summary>
    public unsafe virtual void ClientResetHandIKs(BmSDK.BmGame.RPawnPlayer GunOwner)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientResetHandIKs, "BmGame.GDBaseGunGadget.ClientResetHandIKs");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GunOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientGunSelectedOnSpawn;
    /// <summary>
    /// Function: ClientGunSelectedOnSpawn
    /// </summary>
    public unsafe virtual void ClientGunSelectedOnSpawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientGunSelectedOnSpawn, "BmGame.GDBaseGunGadget.ClientGunSelectedOnSpawn");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Internal_Reload;
    /// <summary>
    /// Function: Internal_Reload
    /// </summary>
    public unsafe virtual void Internal_Reload()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Internal_Reload, "BmGame.GDBaseGunGadget.Internal_Reload");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerSilentReload;
    /// <summary>
    /// Function: ServerSilentReload
    /// </summary>
    public unsafe virtual void ServerSilentReload()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerSilentReload, "BmGame.GDBaseGunGadget.ServerSilentReload");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanGiveClip;
    /// <summary>
    /// Function: CanGiveClip
    /// </summary>
    public unsafe virtual bool CanGiveClip()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanGiveClip, "BmGame.GDBaseGunGadget.CanGiveClip");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GiveClip;
    /// <summary>
    /// Function: GiveClip
    /// </summary>
    public unsafe virtual void GiveClip(int iAmmoStage = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveClip, "BmGame.GDBaseGunGadget.GiveClip");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iAmmoStage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RefillAmmo;
    /// <summary>
    /// Function: RefillAmmo
    /// </summary>
    public unsafe virtual void RefillAmmo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RefillAmmo, "BmGame.GDBaseGunGadget.RefillAmmo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SilentReload;
    /// <summary>
    /// Function: SilentReload
    /// </summary>
    public unsafe override void SilentReload()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SilentReload, "BmGame.GDBaseGunGadget.SilentReload");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetReloadFraction;
    /// <summary>
    /// Function: GetReloadFraction
    /// </summary>
    public unsafe virtual float GetReloadFraction()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetReloadFraction, "BmGame.GDBaseGunGadget.GetReloadFraction");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ForceHolsteredState;
    /// <summary>
    /// Function: ForceHolsteredState
    /// </summary>
    public unsafe virtual void ForceHolsteredState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceHolsteredState, "BmGame.GDBaseGunGadget.ForceHolsteredState");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwitchHandIkEffectorCheck;
    /// <summary>
    /// Function: SwitchHandIkEffectorCheck
    /// </summary>
    public unsafe virtual void SwitchHandIkEffectorCheck()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchHandIkEffectorCheck, "BmGame.GDBaseGunGadget.SwitchHandIkEffectorCheck");
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

    private static BmSDK.Function __fn_SwitchHandIkEffector;
    /// <summary>
    /// Function: SwitchHandIkEffector
    /// </summary>
    public unsafe virtual void SwitchHandIkEffector()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchHandIkEffector, "BmGame.GDBaseGunGadget.SwitchHandIkEffector");
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

    private static BmSDK.Function __fn_EndStatTracking;
    /// <summary>
    /// Function: EndStatTracking
    /// </summary>
    public unsafe override void EndStatTracking()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndStatTracking, "BmGame.GDBaseGunGadget.EndStatTracking");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerSwitchHandIkEffector;
    /// <summary>
    /// Function: ServerSwitchHandIkEffector
    /// </summary>
    public unsafe virtual void ServerSwitchHandIkEffector()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerSwitchHandIkEffector, "BmGame.GDBaseGunGadget.ServerSwitchHandIkEffector");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanFire;
    /// <summary>
    /// Function: CanFire
    /// </summary>
    public unsafe virtual bool CanFire()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanFire, "BmGame.GDBaseGunGadget.CanFire");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TryToFire;
    /// <summary>
    /// Function: TryToFire
    /// </summary>
    public unsafe virtual void TryToFire()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryToFire, "BmGame.GDBaseGunGadget.TryToFire");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TracerFromMesh;
    /// <summary>
    /// Function: TracerFromMesh
    /// </summary>
    public unsafe virtual void TracerFromMesh(BmSDK.Engine.SkeletalMeshComponent MeshComp, System.Numerics.Vector3 HitLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TracerFromMesh, "BmGame.GDBaseGunGadget.TracerFromMesh");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeshComp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnTracer;
    /// <summary>
    /// Function: SpawnTracer
    /// </summary>
    public unsafe virtual void SpawnTracer(System.Numerics.Vector3 vBegin, System.Numerics.Vector3 vEnd)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnTracer, "BmGame.GDBaseGunGadget.SpawnTracer");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vBegin, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vEnd, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableLights;
    /// <summary>
    /// Function: DisableLights
    /// </summary>
    public unsafe virtual void DisableLights()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableLights, "BmGame.GDBaseGunGadget.DisableLights");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableLights;
    /// <summary>
    /// Function: EnableLights
    /// </summary>
    public unsafe virtual void EnableLights()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableLights, "BmGame.GDBaseGunGadget.EnableLights");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CauseMuzzleFlashOnMesh;
    /// <summary>
    /// Function: CauseMuzzleFlashOnMesh
    /// </summary>
    public unsafe virtual void CauseMuzzleFlashOnMesh(BmSDK.Engine.SkeletalMeshComponent MeshComp, out BmSDK.Engine.Emitter FlashEmitter)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CauseMuzzleFlashOnMesh, "BmGame.GDBaseGunGadget.CauseMuzzleFlashOnMesh");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeshComp, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out FlashEmitter);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlashEmitter, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        FlashEmitter = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Emitter>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_CauseMuzzleFlash;
    /// <summary>
    /// Function: CauseMuzzleFlash
    /// </summary>
    public unsafe virtual void CauseMuzzleFlash()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CauseMuzzleFlash, "BmGame.GDBaseGunGadget.CauseMuzzleFlash");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopIFFFireEffect;
    /// <summary>
    /// Function: StopIFFFireEffect
    /// </summary>
    public unsafe virtual void StopIFFFireEffect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopIFFFireEffect, "BmGame.GDBaseGunGadget.StopIFFFireEffect");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetMuzzleLocRot;
    /// <summary>
    /// Function: GetMuzzleLocRot
    /// </summary>
    public unsafe virtual void GetMuzzleLocRot(out System.Numerics.Vector3 MuzzleLoc, out BmSDK.Rotator MuzzleRot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMuzzleLocRot, "BmGame.GDBaseGunGadget.GetMuzzleLocRot");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MuzzleLoc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MuzzleLoc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MuzzleRot);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MuzzleRot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        MuzzleLoc = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        MuzzleRot = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetMuzzleLoc;
    /// <summary>
    /// Function: GetMuzzleLoc
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetMuzzleLoc()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMuzzleLoc, "BmGame.GDBaseGunGadget.GetMuzzleLoc");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopDryFiringSound;
    /// <summary>
    /// Function: StopDryFiringSound
    /// </summary>
    public unsafe virtual void StopDryFiringSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopDryFiringSound, "BmGame.GDBaseGunGadget.StopDryFiringSound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopDryFire;
    /// <summary>
    /// Function: StopDryFire
    /// </summary>
    public unsafe virtual void StopDryFire()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopDryFire, "BmGame.GDBaseGunGadget.StopDryFire");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerStopDryFire;
    /// <summary>
    /// Function: ServerStopDryFire
    /// </summary>
    public unsafe virtual void ServerStopDryFire()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerStopDryFire, "BmGame.GDBaseGunGadget.ServerStopDryFire");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopLoopingFireFX;
    /// <summary>
    /// Function: StopLoopingFireFX
    /// </summary>
    public unsafe virtual void StopLoopingFireFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopLoopingFireFX, "BmGame.GDBaseGunGadget.StopLoopingFireFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopFiringSound;
    /// <summary>
    /// Function: StopFiringSound
    /// </summary>
    public unsafe virtual void StopFiringSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopFiringSound, "BmGame.GDBaseGunGadget.StopFiringSound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopFiringEffects;
    /// <summary>
    /// Function: StopFiringEffects
    /// </summary>
    public unsafe override void StopFiringEffects()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopFiringEffects, "BmGame.GDBaseGunGadget.StopFiringEffects");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckBulletWhip;
    /// <summary>
    /// Function: CheckBulletWhip
    /// </summary>
    public unsafe virtual void CheckBulletWhip(System.Numerics.Vector3 FireLoc, System.Numerics.Vector3 FireDir, System.Numerics.Vector3 HitLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckBulletWhip, "BmGame.GDBaseGunGadget.CheckBulletWhip");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireDir, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckUnderFire;
    /// <summary>
    /// Function: CheckUnderFire
    /// </summary>
    public unsafe virtual void CheckUnderFire(System.Numerics.Vector3 FireLoc, System.Numerics.Vector3 HitLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckUnderFire, "BmGame.GDBaseGunGadget.CheckUnderFire");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnDecalForImpactEffectInfo;
    /// <summary>
    /// Function: SpawnDecalForImpactEffectInfo
    /// </summary>
    public unsafe virtual void SpawnDecalForImpactEffectInfo(BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo Info, System.Numerics.Vector3 ImpactLocation, System.Numerics.Vector3 TraceLocation, System.Numerics.Vector3 TraceNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnDecalForImpactEffectInfo, "BmGame.GDBaseGunGadget.SpawnDecalForImpactEffectInfo");
        byte* paramsPtr = stackalloc byte[112];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Info, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactLocation, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceLocation, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceNormal, paramsPtr + 72);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayImpactEffectForSurface;
    /// <summary>
    /// Function: PlayImpactEffectForSurface
    /// </summary>
    public unsafe virtual void PlayImpactEffectForSurface(BmSDK.BmGame.RPhysicalMaterialProperty Surf, System.Numerics.Vector3 ImpactLocation, System.Numerics.Vector3 TraceLocation, System.Numerics.Vector3 TraceNormal, bool bUseAltImpactBulletEffects, bool bShouldPlayImpactEffects, bool bShouldPlayImpactAudio, BmSDK.BmGame.RPawnPlayer HitPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayImpactEffectForSurface, "BmGame.GDBaseGunGadget.PlayImpactEffectForSurface");
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Surf, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceNormal, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseAltImpactBulletEffects, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldPlayImpactEffects, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldPlayImpactAudio, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPlayer, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayImpactEffects;
    /// <summary>
    /// Function: PlayImpactEffects
    /// </summary>
    public unsafe virtual void PlayImpactEffects(System.Numerics.Vector3 ImpactLocation, System.Numerics.Vector3 ImpactNormal, out BmSDK.FString ImpactPhysMat, BmSDK.BmGame.RPawnPlayer ReplicatedHitPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayImpactEffects, "BmGame.GDBaseGunGadget.PlayImpactEffects");
        byte* paramsPtr = stackalloc byte[400];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReplicatedHitPlayer, paramsPtr + 36);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        ImpactPhysMat = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 24);
        return;
    }

    private static BmSDK.Function __fn_DryFireAutoSwitch;
    /// <summary>
    /// Function: DryFireAutoSwitch
    /// </summary>
    public unsafe virtual void DryFireAutoSwitch()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DryFireAutoSwitch, "BmGame.GDBaseGunGadget.DryFireAutoSwitch");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartDryFireSound;
    /// <summary>
    /// Function: StartDryFireSound
    /// </summary>
    public unsafe virtual void StartDryFireSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartDryFireSound, "BmGame.GDBaseGunGadget.StartDryFireSound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartDryFire;
    /// <summary>
    /// Function: StartDryFire
    /// </summary>
    public unsafe virtual void StartDryFire()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartDryFire, "BmGame.GDBaseGunGadget.StartDryFire");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerStartDryFire;
    /// <summary>
    /// Function: ServerStartDryFire
    /// </summary>
    public unsafe virtual void ServerStartDryFire()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerStartDryFire, "BmGame.GDBaseGunGadget.ServerStartDryFire");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckDryFire;
    /// <summary>
    /// Function: CheckDryFire
    /// </summary>
    public unsafe virtual void CheckDryFire(bool fromButtonPress)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckDryFire, "BmGame.GDBaseGunGadget.CheckDryFire");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fromButtonPress, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartFireSound;
    /// <summary>
    /// Function: StartFireSound
    /// </summary>
    public unsafe virtual void StartFireSound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartFireSound, "BmGame.GDBaseGunGadget.StartFireSound");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartFireEffects;
    /// <summary>
    /// Function: StartFireEffects
    /// </summary>
    public unsafe virtual void StartFireEffects()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartFireEffects, "BmGame.GDBaseGunGadget.StartFireEffects");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySingleEffectForHit;
    /// <summary>
    /// Function: PlaySingleEffectForHit
    /// </summary>
    public unsafe virtual void PlaySingleEffectForHit(System.Numerics.Vector3 FireLocation, System.Numerics.Vector3 HitLocation, bool bTraceFromMuzzle, out BmSDK.FString ImpactPhysMat, BmSDK.BmGame.RPawnPlayer HitPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySingleEffectForHit, "BmGame.GDBaseGunGadget.PlaySingleEffectForHit");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTraceFromMuzzle, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPlayer, paramsPtr + 40);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        ImpactPhysMat = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 28);
        return;
    }

    private static BmSDK.Function __fn_PlayFiringEffect;
    /// <summary>
    /// Function: PlayFiringEffect
    /// </summary>
    public unsafe override void PlayFiringEffect(System.Numerics.Vector3 FireLocation, System.Numerics.Vector3 HitLocation, out BmSDK.FString ImpactPhysMat, BmSDK.BmGame.RPawnPlayer HitPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFiringEffect, "BmGame.GDBaseGunGadget.PlayFiringEffect");
        byte* paramsPtr = stackalloc byte[228];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPlayer, paramsPtr + 36);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        ImpactPhysMat = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 24);
        return;
    }

    private static BmSDK.Function __fn_PlayFiringEffectsFromArray;
    /// <summary>
    /// Function: PlayFiringEffectsFromArray
    /// </summary>
    public unsafe virtual void PlayFiringEffectsFromArray(System.Numerics.Vector3 FireLocation, BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.FTracerShotHitData> HitLocations)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFiringEffectsFromArray, "BmGame.GDBaseGunGadget.PlayFiringEffectsFromArray");
        byte* paramsPtr = stackalloc byte[268];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocations, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GenerateHitLocations;
    /// <summary>
    /// Function: GenerateHitLocations
    /// </summary>
    public unsafe override void GenerateHitLocations(BmSDK.BmGame.RPawnPlayer.FGadgetFiringData FiringData, float MaxTraceLength = default, bool bFakeFinalHit = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GenerateHitLocations, "BmGame.GDBaseGunGadget.GenerateHitLocations");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FiringData, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxTraceLength, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFakeFinalHit, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddSpread;
    /// <summary>
    /// Function: AddSpread
    /// </summary>
    public unsafe virtual BmSDK.Rotator AddSpread(BmSDK.Rotator BaseAim, float SpreadToAdd, out BmSDK.SDEngine.SDRandomMath.FSDRandom RandomGen)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddSpread, "BmGame.GDBaseGunGadget.AddSpread");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BaseAim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpreadToAdd, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out RandomGen);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RandomGen, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        RandomGen = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.SDEngine.SDRandomMath.FSDRandom>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetSpreadPenalty;
    /// <summary>
    /// Function: GetSpreadPenalty
    /// </summary>
    public unsafe virtual float GetSpreadPenalty()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSpreadPenalty, "BmGame.GDBaseGunGadget.GetSpreadPenalty");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IncreaseSpread;
    /// <summary>
    /// Function: IncreaseSpread
    /// </summary>
    public unsafe virtual void IncreaseSpread(float SpreadToAdd)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncreaseSpread, "BmGame.GDBaseGunGadget.IncreaseSpread");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpreadToAdd, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateSpread;
    /// <summary>
    /// Function: UpdateSpread
    /// </summary>
    public unsafe virtual void UpdateSpread(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateSpread, "BmGame.GDBaseGunGadget.UpdateSpread");
        byte* paramsPtr = stackalloc byte[77];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IncreaseRecoil;
    /// <summary>
    /// Function: IncreaseRecoil
    /// </summary>
    public unsafe virtual void IncreaseRecoil()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncreaseRecoil, "BmGame.GDBaseGunGadget.IncreaseRecoil");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayEquipAnim;
    /// <summary>
    /// Function: PlayEquipAnim
    /// </summary>
    public unsafe virtual void PlayEquipAnim(BmSDK.FName AnimToUse, bool bEquipping, bool bUseLastFrameAsAdditiveBase = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayEquipAnim, "BmGame.GDBaseGunGadget.PlayEquipAnim");
        byte* paramsPtr = stackalloc byte[124];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimToUse, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEquipping, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseLastFrameAsAdditiveBase, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetUnequipAnimName;
    /// <summary>
    /// Function: GetUnequipAnimName
    /// </summary>
    public unsafe virtual BmSDK.FName GetUnequipAnimName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUnequipAnimName, "BmGame.GDBaseGunGadget.GetUnequipAnimName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetEquipAnimName;
    /// <summary>
    /// Function: GetEquipAnimName
    /// </summary>
    public unsafe virtual BmSDK.FName GetEquipAnimName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEquipAnimName, "BmGame.GDBaseGunGadget.GetEquipAnimName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClientPlayEquipAnim;
    /// <summary>
    /// Function: ClientPlayEquipAnim
    /// </summary>
    public unsafe virtual void ClientPlayEquipAnim(BmSDK.FName AnimToUse, bool bEquipping, bool bUseLastFrameAsAdditiveBase = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientPlayEquipAnim, "BmGame.GDBaseGunGadget.ClientPlayEquipAnim");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimToUse, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEquipping, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseLastFrameAsAdditiveBase, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientReloadFinished;
    /// <summary>
    /// Function: ClientReloadFinished
    /// </summary>
    public unsafe virtual void ClientReloadFinished()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientReloadFinished, "BmGame.GDBaseGunGadget.ClientReloadFinished");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientStopReloadAnim;
    /// <summary>
    /// Function: ClientStopReloadAnim
    /// </summary>
    public unsafe virtual void ClientStopReloadAnim(bool bForceInstant = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientStopReloadAnim, "BmGame.GDBaseGunGadget.ClientStopReloadAnim");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceInstant, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopReloadAnim;
    /// <summary>
    /// Function: StopReloadAnim
    /// </summary>
    public unsafe virtual void StopReloadAnim(bool bForceInstant = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopReloadAnim, "BmGame.GDBaseGunGadget.StopReloadAnim");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceInstant, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayReloadAnim;
    /// <summary>
    /// Function: PlayReloadAnim
    /// </summary>
    public unsafe virtual void PlayReloadAnim(BmSDK.BmGame.GDBaseGunGadget.EReloadTypes ReloadAnimType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayReloadAnim, "BmGame.GDBaseGunGadget.PlayReloadAnim");
        byte* paramsPtr = stackalloc byte[132];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReloadAnimType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetReloadType;
    /// <summary>
    /// Function: GetReloadType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDBaseGunGadget.EReloadTypes GetReloadType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetReloadType, "BmGame.GDBaseGunGadget.GetReloadType");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDBaseGunGadget.EReloadTypes>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ClientPlayReloadAnim;
    /// <summary>
    /// Function: ClientPlayReloadAnim
    /// </summary>
    public unsafe virtual void ClientPlayReloadAnim(BmSDK.BmGame.GDBaseGunGadget.EReloadTypes ReloadAnimType, int iAmmoLeft)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientPlayReloadAnim, "BmGame.GDBaseGunGadget.ClientPlayReloadAnim");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReloadAnimType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iAmmoLeft, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerReload;
    /// <summary>
    /// Function: ServerReload
    /// </summary>
    public unsafe virtual void ServerReload()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerReload, "BmGame.GDBaseGunGadget.ServerReload");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ManualReload;
    /// <summary>
    /// Function: ManualReload
    /// </summary>
    public unsafe virtual void ManualReload()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ManualReload, "BmGame.GDBaseGunGadget.ManualReload");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NoAmmoLeft;
    /// <summary>
    /// Function: NoAmmoLeft
    /// </summary>
    public unsafe virtual bool NoAmmoLeft()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NoAmmoLeft, "BmGame.GDBaseGunGadget.NoAmmoLeft");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DelayedSwitchToReload;
    /// <summary>
    /// Function: DelayedSwitchToReload
    /// </summary>
    public unsafe virtual void DelayedSwitchToReload()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DelayedSwitchToReload, "BmGame.GDBaseGunGadget.DelayedSwitchToReload");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckReloadRequired;
    /// <summary>
    /// Function: CheckReloadRequired
    /// </summary>
    public unsafe virtual bool CheckReloadRequired()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckReloadRequired, "BmGame.GDBaseGunGadget.CheckReloadRequired");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ReduceAmmo;
    /// <summary>
    /// Function: ReduceAmmo
    /// </summary>
    public unsafe virtual void ReduceAmmo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReduceAmmo, "BmGame.GDBaseGunGadget.ReduceAmmo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnServerFireShot;
    /// <summary>
    /// Function: OnServerFireShot
    /// </summary>
    public unsafe virtual void OnServerFireShot(int NewAmmo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnServerFireShot, "BmGame.GDBaseGunGadget.OnServerFireShot");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAmmo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerFireShot;
    /// <summary>
    /// Function: ServerFireShot
    /// </summary>
    public unsafe virtual void ServerFireShot(BmSDK.BmGame.RPawnPlayer.FGadgetFiringData FiringData, int NewAmmo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerFireShot, "BmGame.GDBaseGunGadget.ServerFireShot");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FiringData, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAmmo, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerFireShotSimple;
    /// <summary>
    /// Function: ServerFireShotSimple
    /// </summary>
    public unsafe virtual void ServerFireShotSimple(System.Numerics.Vector3 FireLocation, System.Numerics.Vector3 HitLocation, int NewAmmo, BmSDK.FString ImpactPhysMat, BmSDK.BmGame.RPawnPlayer HitPawn = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerFireShotSimple, "BmGame.GDBaseGunGadget.ServerFireShotSimple");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAmmo, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactPhysMat, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPawn, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CalculateFalloffDamage;
    /// <summary>
    /// Function: CalculateFalloffDamage
    /// </summary>
    public unsafe virtual float CalculateFalloffDamage(float Distance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateFalloffDamage, "BmGame.GDBaseGunGadget.CalculateFalloffDamage");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Distance, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AdjustDamageForDualWield;
    /// <summary>
    /// Function: AdjustDamageForDualWield
    /// </summary>
    public unsafe virtual void AdjustDamageForDualWield(out float Damage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdjustDamageForDualWield, "BmGame.GDBaseGunGadget.AdjustDamageForDualWield");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Damage);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Damage = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_ServerTraceShot;
    /// <summary>
    /// Function: ServerTraceShot
    /// </summary>
    public unsafe virtual void ServerTraceShot(BmSDK.BmGame.RInventoryGadget.FShotHitData ShotData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerTraceShot, "BmGame.GDBaseGunGadget.ServerTraceShot");
        byte* paramsPtr = stackalloc byte[328];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ShotData, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TraceSingleShotDist;
    /// <summary>
    /// Function: TraceSingleShotDist
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RInventoryGadget.FShotHitData TraceSingleShotDist(System.Numerics.Vector3 StartPoint, System.Numerics.Vector3 EndPoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TraceSingleShotDist, "BmGame.GDBaseGunGadget.TraceSingleShotDist");
        byte* paramsPtr = stackalloc byte[120];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndPoint, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RInventoryGadget.FShotHitData>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_TraceSingleShot;
    /// <summary>
    /// Function: TraceSingleShot
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RInventoryGadget.FShotHitData TraceSingleShot(System.Numerics.Vector3 CamLoc, BmSDK.Rotator CamRot, float TraceLength = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TraceSingleShot, "BmGame.GDBaseGunGadget.TraceSingleShot");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CamLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CamRot, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceLength, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RInventoryGadget.FShotHitData>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_GetHitData;
    /// <summary>
    /// Function: GetHitData
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.FTracerShotHitData> GetHitData(BmSDK.BmGame.RPawnPlayer.FGadgetFiringData FiringData, out float fTraceLength, float MaxTraceLength = default, bool bFakeFinalHit = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHitData, "BmGame.GDBaseGunGadget.GetHitData");
        byte* paramsPtr = stackalloc byte[104];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FiringData, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out fTraceLength);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fTraceLength, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxTraceLength, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFakeFinalHit, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        fTraceLength = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.FTracerShotHitData>>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_TraceSingleBullet;
    /// <summary>
    /// Function: TraceSingleBullet
    /// </summary>
    public unsafe virtual void TraceSingleBullet(System.Numerics.Vector3 vStart, BmSDK.Rotator rDirection, bool bAdjustForObstructions, out BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.FTracerShotHitData> HitLocations, int Ricochets, out float fTraceLength, float MaxTraceLength = default, bool bFakeFinalHit = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TraceSingleBullet, "BmGame.GDBaseGunGadget.TraceSingleBullet");
        byte* paramsPtr = stackalloc byte[204];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vStart, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(rDirection, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAdjustForObstructions, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Ricochets, paramsPtr + 40);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out fTraceLength);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fTraceLength, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxTraceLength, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFakeFinalHit, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        HitLocations = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.FTracerShotHitData>>(paramsPtr + 28);
        fTraceLength = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 44);
        return;
    }

    private static BmSDK.Function __fn_AdjustHitLocation;
    /// <summary>
    /// Function: AdjustHitLocation
    /// </summary>
    public unsafe virtual void AdjustHitLocation(BmSDK.BmGame.RInventoryGadget.FShotHitData HitData, out BmSDK.BmGame.RInventoryGadget.FShotHitData NewHitData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdjustHitLocation, "BmGame.GDBaseGunGadget.AdjustHitLocation");
        byte* paramsPtr = stackalloc byte[132];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitData, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NewHitData);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewHitData, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        NewHitData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RInventoryGadget.FShotHitData>(paramsPtr + 40);
        return;
    }

    private static BmSDK.Function __fn_TurnOffExplosionLight;
    /// <summary>
    /// Function: TurnOffExplosionLight
    /// </summary>
    public unsafe virtual void TurnOffExplosionLight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffExplosionLight, "BmGame.GDBaseGunGadget.TurnOffExplosionLight");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireShot;
    /// <summary>
    /// Function: FireShot
    /// </summary>
    public unsafe virtual void FireShot()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireShot, "BmGame.GDBaseGunGadget.FireShot");
        byte* paramsPtr = stackalloc byte[188];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwayOff;
    /// <summary>
    /// Function: SwayOff
    /// </summary>
    public unsafe virtual void SwayOff()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwayOff, "BmGame.GDBaseGunGadget.SwayOff");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwayOn;
    /// <summary>
    /// Function: SwayOn
    /// </summary>
    public unsafe virtual void SwayOn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwayOn, "BmGame.GDBaseGunGadget.SwayOn");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawDebugSpread;
    /// <summary>
    /// Function: DrawDebugSpread
    /// </summary>
    public unsafe virtual void DrawDebugSpread(bool Permadraw = default, bool Override = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugSpread, "BmGame.GDBaseGunGadget.DrawDebugSpread");
        byte* paramsPtr = stackalloc byte[184];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Permadraw, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Override, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawDebugTraces;
    /// <summary>
    /// Function: DrawDebugTraces
    /// </summary>
    public unsafe virtual void DrawDebugTraces()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugTraces, "BmGame.GDBaseGunGadget.DrawDebugTraces");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowActorDamage;
    /// <summary>
    /// Function: AllowActorDamage
    /// </summary>
    public unsafe virtual bool AllowActorDamage(System.Numerics.Vector3 MuzzlePos, System.Numerics.Vector3 CameraPos, System.Numerics.Vector3 HitPoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowActorDamage, "BmGame.GDBaseGunGadget.AllowActorDamage");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MuzzlePos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPoint, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_AnimNotify_FireExtraShot;
    /// <summary>
    /// Function: AnimNotify_FireExtraShot
    /// </summary>
    public unsafe virtual void AnimNotify_FireExtraShot()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnimNotify_FireExtraShot, "BmGame.GDBaseGunGadget.AnimNotify_FireExtraShot");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishFiring;
    /// <summary>
    /// Function: FinishFiring
    /// </summary>
    public unsafe virtual void FinishFiring()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishFiring, "BmGame.GDBaseGunGadget.FinishFiring");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndFiring;
    /// <summary>
    /// Function: EndFiring
    /// </summary>
    public unsafe virtual void EndFiring()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndFiring, "BmGame.GDBaseGunGadget.EndFiring");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerEndFiring;
    /// <summary>
    /// Function: ServerEndFiring
    /// </summary>
    public unsafe virtual void ServerEndFiring()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerEndFiring, "BmGame.GDBaseGunGadget.ServerEndFiring");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ButtonReleased;
    /// <summary>
    /// Function: ButtonReleased
    /// </summary>
    public unsafe override void ButtonReleased()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ButtonReleased, "BmGame.GDBaseGunGadget.ButtonReleased");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendToFiringState;
    /// <summary>
    /// Function: SendToFiringState
    /// </summary>
    public unsafe virtual void SendToFiringState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendToFiringState, "BmGame.GDBaseGunGadget.SendToFiringState");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartFiring;
    /// <summary>
    /// Function: StartFiring
    /// </summary>
    public unsafe virtual void StartFiring()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartFiring, "BmGame.GDBaseGunGadget.StartFiring");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerStartFiring;
    /// <summary>
    /// Function: ServerStartFiring
    /// </summary>
    public unsafe virtual void ServerStartFiring()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerStartFiring, "BmGame.GDBaseGunGadget.ServerStartFiring");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ButtonPressed;
    /// <summary>
    /// Function: ButtonPressed
    /// </summary>
    public unsafe override void ButtonPressed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ButtonPressed, "BmGame.GDBaseGunGadget.ButtonPressed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAmmoForGadgetUI;
    /// <summary>
    /// Function: GetAmmoForGadgetUI
    /// </summary>
    public unsafe override int GetAmmoForGadgetUI()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAmmoForGadgetUI, "BmGame.GDBaseGunGadget.GetAmmoForGadgetUI");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPrimedPose;
    /// <summary>
    /// Function: GetPrimedPose
    /// </summary>
    public unsafe override BmSDK.FName GetPrimedPose(out BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch StanceIsCrouched, out BmSDK.BmGame.RAnimUtil.EMirrorChoice MirroredNess, bool InSoftCover, BmSDK.BmGame.RInventoryGadget.CoverCornerType CornerType, out BmSDK.FName OutCapeState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPrimedPose, "BmGame.GDBaseGunGadget.GetPrimedPose");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StanceIsCrouched);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StanceIsCrouched, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MirroredNess);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MirroredNess, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSoftCover, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerType, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutCapeState);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutCapeState, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        StanceIsCrouched = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch>(paramsPtr + 0);
        MirroredNess = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.EMirrorChoice>(paramsPtr + 1);
        OutCapeState = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.GDBaseGunGadget.Destroyed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PickupGadget;
    /// <summary>
    /// Function: PickupGadget
    /// </summary>
    public unsafe override void PickupGadget(BmSDK.BmGame.RPawnCombat PawnOwner)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PickupGadget, "BmGame.GDBaseGunGadget.PickupGadget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReallyDropGadget;
    /// <summary>
    /// Function: ReallyDropGadget
    /// </summary>
    public unsafe virtual void ReallyDropGadget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReallyDropGadget, "BmGame.GDBaseGunGadget.ReallyDropGadget");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DropFrom;
    /// <summary>
    /// Function: DropFrom
    /// </summary>
    public unsafe override void DropFrom(System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 StartVelocity)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DropFrom, "BmGame.GDBaseGunGadget.DropFrom");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartVelocity, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DropGadget;
    /// <summary>
    /// Function: DropGadget
    /// </summary>
    public unsafe override void DropGadget(BmSDK.BmGame.RPawnCombat PawnOwner)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DropGadget, "BmGame.GDBaseGunGadget.DropGadget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanPlayerMove;
    /// <summary>
    /// Function: CanPlayerMove
    /// </summary>
    public unsafe override bool CanPlayerMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayerMove, "BmGame.GDBaseGunGadget.CanPlayerMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ServerEndDualWield;
    /// <summary>
    /// Function: ServerEndDualWield
    /// </summary>
    public unsafe virtual void ServerEndDualWield(bool bForced)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerEndDualWield, "BmGame.GDBaseGunGadget.ServerEndDualWield");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForced, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndDualWield;
    /// <summary>
    /// Function: EndDualWield
    /// </summary>
    public unsafe override void EndDualWield(bool bForced)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndDualWield, "BmGame.GDBaseGunGadget.EndDualWield");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForced, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerDualWield;
    /// <summary>
    /// Function: ServerDualWield
    /// </summary>
    public unsafe virtual void ServerDualWield(BmSDK.BmGame.GDDualWieldGadget WieldGadget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerDualWield, "BmGame.GDBaseGunGadget.ServerDualWield");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WieldGadget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DualWield;
    /// <summary>
    /// Function: DualWield
    /// </summary>
    public unsafe override void DualWield(BmSDK.BmGame.GDDualWieldGadget WieldGadget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DualWield, "BmGame.GDBaseGunGadget.DualWield");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WieldGadget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupDualWield;
    /// <summary>
    /// Function: SetupDualWield
    /// </summary>
    public unsafe virtual void SetupDualWield()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupDualWield, "BmGame.GDBaseGunGadget.SetupDualWield");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanDualWield;
    /// <summary>
    /// Function: CanDualWield
    /// </summary>
    public unsafe override bool CanDualWield()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDualWield, "BmGame.GDBaseGunGadget.CanDualWield");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AttachToHand;
    /// <summary>
    /// Function: AttachToHand
    /// </summary>
    public unsafe override void AttachToHand(BmSDK.FName CustomBone = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachToHand, "BmGame.GDBaseGunGadget.AttachToHand");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomBone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InterruptedByQuickFire;
    /// <summary>
    /// Function: InterruptedByQuickFire
    /// </summary>
    public unsafe override void InterruptedByQuickFire(BmSDK.BmGame.RInventoryGadget QuickGadget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InterruptedByQuickFire, "BmGame.GDBaseGunGadget.InterruptedByQuickFire");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QuickGadget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachToBelt;
    /// <summary>
    /// Function: AttachToBelt
    /// </summary>
    public unsafe override void AttachToBelt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachToBelt, "BmGame.GDBaseGunGadget.AttachToBelt");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UseDelayedEquips;
    /// <summary>
    /// Function: UseDelayedEquips
    /// </summary>
    public unsafe override bool UseDelayedEquips()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UseDelayedEquips, "BmGame.GDBaseGunGadget.UseDelayedEquips");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UnequipSelf;
    /// <summary>
    /// Function: UnequipSelf
    /// </summary>
    public unsafe override bool UnequipSelf()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnequipSelf, "BmGame.GDBaseGunGadget.UnequipSelf");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RemoteClientEquip;
    /// <summary>
    /// Function: RemoteClientEquip
    /// </summary>
    public unsafe override void RemoteClientEquip()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoteClientEquip, "BmGame.GDBaseGunGadget.RemoteClientEquip");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAimAssistanceValues;
    /// <summary>
    /// Function: GetAimAssistanceValues
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDBaseGunGadget.FAimAssitanceValues GetAimAssistanceValues()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAimAssistanceValues, "BmGame.GDBaseGunGadget.GetAimAssistanceValues");
        byte* paramsPtr = stackalloc byte[192];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDBaseGunGadget.FAimAssitanceValues>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ResumeAfterInterruption;
    /// <summary>
    /// Function: ResumeAfterInterruption
    /// </summary>
    public unsafe override void ResumeAfterInterruption()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResumeAfterInterruption, "BmGame.GDBaseGunGadget.ResumeAfterInterruption");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetWeaponId;
    /// <summary>
    /// Function: GetWeaponId
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.WeaponId GetWeaponId()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWeaponId, "BmGame.GDBaseGunGadget.GetWeaponId");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.WeaponId>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HideScope;
    /// <summary>
    /// Function: HideScope
    /// </summary>
    public unsafe virtual void HideScope()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideScope, "BmGame.GDBaseGunGadget.HideScope");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExtendedHideScope;
    /// <summary>
    /// Function: ExtendedHideScope
    /// </summary>
    public unsafe virtual void ExtendedHideScope(BmSDK.BmGame.RPlayerController PC, BmSDK.BmGame.GDPawnPlayerThugBase Thug)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExtendedHideScope, "BmGame.GDBaseGunGadget.ExtendedHideScope");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thug, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExtendedShowScope;
    /// <summary>
    /// Function: ExtendedShowScope
    /// </summary>
    public unsafe virtual void ExtendedShowScope(BmSDK.BmGame.RPlayerController PC, BmSDK.BmGame.GDPawnPlayerThugBase Thug)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExtendedShowScope, "BmGame.GDBaseGunGadget.ExtendedShowScope");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thug, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowScope;
    /// <summary>
    /// Function: ShowScope
    /// </summary>
    public unsafe virtual void ShowScope()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowScope, "BmGame.GDBaseGunGadget.ShowScope");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DualWieldForcedUnequip;
    /// <summary>
    /// Function: DualWieldForcedUnequip
    /// </summary>
    public unsafe virtual void DualWieldForcedUnequip()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DualWieldForcedUnequip, "BmGame.GDBaseGunGadget.DualWieldForcedUnequip");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InterruptCurrentAction;
    /// <summary>
    /// Function: InterruptCurrentAction
    /// </summary>
    public unsafe override void InterruptCurrentAction()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InterruptCurrentAction, "BmGame.GDBaseGunGadget.InterruptCurrentAction");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGadgetClassNameForHUD;
    /// <summary>
    /// Function: GetGadgetClassNameForHUD
    /// </summary>
    public unsafe override BmSDK.FName GetGadgetClassNameForHUD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetClassNameForHUD, "BmGame.GDBaseGunGadget.GetGadgetClassNameForHUD");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AimGadget;
    /// <summary>
    /// Function: AimGadget
    /// </summary>
    public unsafe override bool AimGadget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AimGadget, "BmGame.GDBaseGunGadget.AimGadget");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Deselected;
    /// <summary>
    /// Function: Deselected
    /// </summary>
    public unsafe override void Deselected()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Deselected, "BmGame.GDBaseGunGadget.Deselected");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FullyEquipped;
    /// <summary>
    /// Function: FullyEquipped
    /// </summary>
    public unsafe virtual void FullyEquipped()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FullyEquipped, "BmGame.GDBaseGunGadget.FullyEquipped");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_selected;
    /// <summary>
    /// Function: selected
    /// </summary>
    public unsafe override void selected()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_selected, "BmGame.GDBaseGunGadget.selected");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FalloffSort;
    /// <summary>
    /// Function: FalloffSort
    /// </summary>
    public unsafe virtual int FalloffSort(BmSDK.BmGame.GDBaseGunGadget.FFalloffPoint A, BmSDK.BmGame.GDBaseGunGadget.FFalloffPoint B)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FalloffSort, "BmGame.GDBaseGunGadget.FalloffSort");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_ApplyWeaponSkin;
    /// <summary>
    /// Function: ApplyWeaponSkin
    /// </summary>
    public unsafe virtual void ApplyWeaponSkin(BmSDK.BmGame.GDWeaponSkin Skin)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyWeaponSkin, "BmGame.GDBaseGunGadget.ApplyWeaponSkin");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Skin, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateExtremeSpreadValues;
    /// <summary>
    /// Function: UpdateExtremeSpreadValues
    /// </summary>
    public unsafe virtual void UpdateExtremeSpreadValues()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateExtremeSpreadValues, "BmGame.GDBaseGunGadget.UpdateExtremeSpreadValues");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetWeaponSkinForOwner;
    /// <summary>
    /// Function: GetWeaponSkinForOwner
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDWeaponSkin GetWeaponSkinForOwner(BmSDK.BmGame.RPawnPlayer PawnOwner)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWeaponSkinForOwner, "BmGame.GDBaseGunGadget.GetWeaponSkinForOwner");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDWeaponSkin>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UpdateWeaponSkinFromOwner;
    /// <summary>
    /// Function: UpdateWeaponSkinFromOwner
    /// </summary>
    public unsafe virtual void UpdateWeaponSkinFromOwner(BmSDK.BmGame.RPawnPlayer PawnOwner)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateWeaponSkinFromOwner, "BmGame.GDBaseGunGadget.UpdateWeaponSkinFromOwner");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReplicatedEvent;
    /// <summary>
    /// Function: ReplicatedEvent
    /// </summary>
    public unsafe override void ReplicatedEvent(BmSDK.FName VarName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplicatedEvent, "BmGame.GDBaseGunGadget.ReplicatedEvent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.GDBaseGunGadget.PostBeginPlay");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreBeginPlay, "BmGame.GDBaseGunGadget.PreBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanDisableTick;
    /// <summary>
    /// Function: CanDisableTick
    /// </summary>
    public unsafe override bool CanDisableTick()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDisableTick, "BmGame.GDBaseGunGadget.CanDisableTick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldTickNonLocalGadgets;
    /// <summary>
    /// Function: ShouldTickNonLocalGadgets
    /// </summary>
    public unsafe override bool ShouldTickNonLocalGadgets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldTickNonLocalGadgets, "BmGame.GDBaseGunGadget.ShouldTickNonLocalGadgets");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CalcSwayMultiplier;
    /// <summary>
    /// Function: CalcSwayMultiplier
    /// </summary>
    public unsafe virtual float CalcSwayMultiplier(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalcSwayMultiplier, "BmGame.GDBaseGunGadget.CalcSwayMultiplier");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AddSway;
    /// <summary>
    /// Function: AddSway
    /// </summary>
    public unsafe virtual void AddSway(out BmSDK.Rotator Sway, float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddSway, "BmGame.GDBaseGunGadget.AddSway");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Sway);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Sway, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Sway = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_RegenerateSwaySigns;
    /// <summary>
    /// Function: RegenerateSwaySigns
    /// </summary>
    public unsafe virtual void RegenerateSwaySigns()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegenerateSwaySigns, "BmGame.GDBaseGunGadget.RegenerateSwaySigns");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SightDown;
    /// <summary>
    /// Function: SightDown
    /// </summary>
    public unsafe virtual void SightDown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SightDown, "BmGame.GDBaseGunGadget.SightDown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SightUp;
    /// <summary>
    /// Function: SightUp
    /// </summary>
    public unsafe virtual void SightUp()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SightUp, "BmGame.GDBaseGunGadget.SightUp");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAmmoPercentage;
    /// <summary>
    /// Function: GetAmmoPercentage
    /// </summary>
    public unsafe virtual float GetAmmoPercentage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAmmoPercentage, "BmGame.GDBaseGunGadget.GetAmmoPercentage");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_EffectorHandSwitchTimerFunc;
    /// <summary>
    /// Function: EffectorHandSwitchTimerFunc
    /// </summary>
    public unsafe virtual void EffectorHandSwitchTimerFunc()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EffectorHandSwitchTimerFunc, "BmGame.GDBaseGunGadget.EffectorHandSwitchTimerFunc");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRelevantWeaponId;
    /// <summary>
    /// Function: GetRelevantWeaponId
    /// </summary>
    public unsafe override BmSDK.BmGame.RGameInfo.WeaponId GetRelevantWeaponId()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRelevantWeaponId, "BmGame.GDBaseGunGadget.GetRelevantWeaponId");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.WeaponId>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDamageType;
    /// <summary>
    /// Function: GetDamageType
    /// </summary>
    public unsafe override BmSDK.Class GetDamageType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamageType, "BmGame.GDBaseGunGadget.GetDamageType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldPlayImpactEffects;
    /// <summary>
    /// Function: ShouldPlayImpactEffects
    /// </summary>
    public unsafe virtual bool ShouldPlayImpactEffects(System.Numerics.Vector3 ImpactLocation, System.Numerics.Vector3 ImpactNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldPlayImpactEffects, "BmGame.GDBaseGunGadget.ShouldPlayImpactEffects");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactNormal, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_ShouldPlayImpactAudio;
    /// <summary>
    /// Function: ShouldPlayImpactAudio
    /// </summary>
    public unsafe virtual bool ShouldPlayImpactAudio(System.Numerics.Vector3 ImpactLocation, System.Numerics.Vector3 ImpactNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldPlayImpactAudio, "BmGame.GDBaseGunGadget.ShouldPlayImpactAudio");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactNormal, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetPhysMaterial;
    /// <summary>
    /// Function: GetPhysMaterial
    /// </summary>
    public unsafe virtual BmSDK.Engine.PhysicalMaterial GetPhysMaterial(in BmSDK.FString MaterialName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPhysMaterial, "BmGame.GDBaseGunGadget.GetPhysMaterial");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaterialName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.PhysicalMaterial>(paramsPtr + 12);
    }

    /// <summary>
    /// Enum: EReloadStatus
    /// </summary>
    public enum EReloadStatus : byte
    {
        ReloadFull = 0,
        ReloadStart = 1,
        ReloadLoop = 2,
        ReloadEnd = 3,
        EReloadStatus_MAX = 4,
    }

    /// <summary>
    /// Enum: EReloadTypes
    /// </summary>
    public enum EReloadTypes : byte
    {
        Reload_Standard = 0,
        Reload_Half_Cover = 1,
        Reload_Full_Cover = 2,
        Reload_Standard_Mirrored = 3,
        Reload_Half_Cover_Mirrored = 4,
        Reload_Full_Cover_Mirrored = 5,
        Reload_MAX = 6,
    }

    /// <summary>
    /// Struct: FBaseGunAudio
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial record struct FBaseGunAudio
    {
        /// <summary>
        /// ObjectProperty: StartFireAudio
        /// </summary>
        public unsafe BmSDK.Engine.AkEvent StartFireAudio
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: EndFireAudio
        /// </summary>
        public unsafe BmSDK.Engine.AkEvent EndFireAudio
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ObjectProperty: StartDryFireAudio
        /// </summary>
        public unsafe BmSDK.Engine.AkEvent StartDryFireAudio
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: EndDryFireAudio
        /// </summary>
        public unsafe BmSDK.Engine.AkEvent EndDryFireAudio
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ObjectProperty: BulletWhip
        /// </summary>
        public unsafe BmSDK.Engine.AkEvent BulletWhip
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ObjectProperty: MeleeHeadHit
        /// </summary>
        public unsafe BmSDK.Engine.AkEvent MeleeHeadHit
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ObjectProperty: MeleeHit
        /// </summary>
        public unsafe BmSDK.Engine.AkEvent MeleeHit
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ObjectProperty: HitBeep
        /// </summary>
        public unsafe BmSDK.Engine.AkEvent HitBeep
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// ObjectProperty: HitBeepHeadshot
        /// </summary>
        public unsafe BmSDK.Engine.AkEvent HitBeepHeadshot
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// ObjectProperty: LocalClipGettingLow
        /// </summary>
        public unsafe BmSDK.Engine.AkEvent LocalClipGettingLow
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// ObjectProperty: LocalAmmoEmpty
        /// </summary>
        public unsafe BmSDK.Engine.AkEvent LocalAmmoEmpty
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FFalloffPoint
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FFalloffPoint
    {
        /// <summary>
        /// FloatProperty: Distance
        /// </summary>
        public unsafe float Distance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Damage
        /// </summary>
        public unsafe int Damage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ByteProperty: FromPrevPoint
        /// </summary>
        public unsafe BmSDK.BmGame.GDBaseGunGadget.EFalloffPath FromPrevPoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBaseGunGadget.EFalloffPath>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: EFalloffPath
    /// </summary>
    public enum EFalloffPath : byte
    {
        Falloff_Step = 0,
        Falloff_Linear = 1,
        Falloff_MAX = 2,
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
    /// Enum: ESpreadMode
    /// </summary>
    public enum ESpreadMode : byte
    {
        Spread_HipFire = 0,
        Spread_Aim = 1,
        Spread_Cover = 2,
        Spread_CoverAim = 3,
        Spread_MAX = 4,
    }

    /// <summary>
    /// Struct: FAimAssitanceValues
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 176)]
    public partial record struct FAimAssitanceValues
    {
        /// <summary>
        /// FloatProperty: Target_ProximityToReticle_HipFire
        /// </summary>
        public unsafe float Target_ProximityToReticle_HipFire
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Target_ProximityToReticle_AimMode
        /// </summary>
        public unsafe float Target_ProximityToReticle_AimMode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: Target_DistanceFromPlayer_HipFire
        /// </summary>
        public unsafe float Target_DistanceFromPlayer_HipFire
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: Target_DistanceFromPlayer_AimMode
        /// </summary>
        public unsafe float Target_DistanceFromPlayer_AimMode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: Target_TimeOnScreen_HipFire
        /// </summary>
        public unsafe float Target_TimeOnScreen_HipFire
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: Target_TimeOnScreen_AimMode
        /// </summary>
        public unsafe float Target_TimeOnScreen_AimMode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: Heat_IncreaseRate_HipFire
        /// </summary>
        public unsafe float Heat_IncreaseRate_HipFire
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: Heat_IncreaseRate_AimMode
        /// </summary>
        public unsafe float Heat_IncreaseRate_AimMode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: Heat_DecreaseRate_HipFire
        /// </summary>
        public unsafe float Heat_DecreaseRate_HipFire
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: Heat_DecreaseRate_AimMode
        /// </summary>
        public unsafe float Heat_DecreaseRate_AimMode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: GravityWell_InnerRadius_HipFire
        /// </summary>
        public unsafe float GravityWell_InnerRadius_HipFire
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// FloatProperty: GravityWell_InnerRadius_AimMode
        /// </summary>
        public unsafe float GravityWell_InnerRadius_AimMode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// FloatProperty: GravityWell_OuterRadius_HipFire
        /// </summary>
        public unsafe float GravityWell_OuterRadius_HipFire
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: GravityWell_OuterRadius_AimMode
        /// </summary>
        public unsafe float GravityWell_OuterRadius_AimMode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// FloatProperty: GravityWell_CentralForce_HipFire
        /// </summary>
        public unsafe float GravityWell_CentralForce_HipFire
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// FloatProperty: GravityWell_CentralForce_AimMode
        /// </summary>
        public unsafe float GravityWell_CentralForce_AimMode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// FloatProperty: GravityWell_EdgeForce_HipFire
        /// </summary>
        public unsafe float GravityWell_EdgeForce_HipFire
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// FloatProperty: GravityWell_EdgeForce_AimMode
        /// </summary>
        public unsafe float GravityWell_EdgeForce_AimMode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// FloatProperty: Dampening_HipFire
        /// </summary>
        public unsafe float Dampening_HipFire
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// FloatProperty: Dampening_AimMode
        /// </summary>
        public unsafe float Dampening_AimMode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// FloatProperty: Stickiness_Central_HipFire
        /// </summary>
        public unsafe float Stickiness_Central_HipFire
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// FloatProperty: Stickiness_Central_AimMode
        /// </summary>
        public unsafe float Stickiness_Central_AimMode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// FloatProperty: Stickiness_Edge_HipFire
        /// </summary>
        public unsafe float Stickiness_Edge_HipFire
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }

        /// <summary>
        /// FloatProperty: Stickiness_Edge_AimMode
        /// </summary>
        public unsafe float Stickiness_Edge_AimMode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }; }
        }

        /// <summary>
        /// FloatProperty: Stickiness_Minimum_HipFire
        /// </summary>
        public unsafe float Stickiness_Minimum_HipFire
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }

        /// <summary>
        /// FloatProperty: Stickiness_Minimum_AimMode
        /// </summary>
        public unsafe float Stickiness_Minimum_AimMode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }; }
        }

        /// <summary>
        /// FloatProperty: Stickiness_TargetMoveTypeDamp
        /// </summary>
        public unsafe float Stickiness_TargetMoveTypeDamp_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 104); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }; }
        }
        /// <summary>
        /// FloatProperty: Stickiness_TargetMoveTypeDamp
        /// </summary>
        public unsafe float Stickiness_TargetMoveTypeDamp_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 108); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }; }
        }
        /// <summary>
        /// FloatProperty: Stickiness_TargetMoveTypeDamp
        /// </summary>
        public unsafe float Stickiness_TargetMoveTypeDamp_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }; }
        }
        /// <summary>
        /// FloatProperty: Stickiness_TargetMoveTypeDamp
        /// </summary>
        public unsafe float Stickiness_TargetMoveTypeDamp_3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 116); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }; }
        }
        /// <summary>
        /// FloatProperty: Stickiness_TargetMoveTypeDamp
        /// </summary>
        public unsafe float Stickiness_TargetMoveTypeDamp_4
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 120); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }; }
        }
        /// <summary>
        /// FloatProperty: Stickiness_TargetMoveTypeDamp
        /// </summary>
        public unsafe float Stickiness_TargetMoveTypeDamp_5
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 124); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }; }
        }
        /// <summary>
        /// FloatProperty: Stickiness_TargetMoveTypeDamp
        /// </summary>
        public unsafe float Stickiness_TargetMoveTypeDamp_6
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 128); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }; }
        }
        /// <summary>
        /// FloatProperty: Stickiness_TargetMoveTypeDamp
        /// </summary>
        public unsafe float Stickiness_TargetMoveTypeDamp_7
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 132); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }; }
        }
        /// <summary>
        /// FloatProperty: Stickiness_TargetMoveTypeDamp
        /// </summary>
        public unsafe float Stickiness_TargetMoveTypeDamp_8
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 136); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }; }
        }
        /// <summary>
        /// FloatProperty: Stickiness_TargetMoveTypeDamp
        /// </summary>
        public unsafe float Stickiness_TargetMoveTypeDamp_9
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 140); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }; }
        }

        /// <summary>
        /// FloatProperty: Stickiness_Target_MinDistanceToDamp_HipFire
        /// </summary>
        public unsafe float Stickiness_Target_MinDistanceToDamp_HipFire
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 144); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }; }
        }

        /// <summary>
        /// FloatProperty: Stickiness_Target_MaxDistanceToDamp_HipFire
        /// </summary>
        public unsafe float Stickiness_Target_MaxDistanceToDamp_HipFire
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 148); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }; }
        }

        /// <summary>
        /// FloatProperty: Stickiness_Target_MinDistanceDampValue_HipFire
        /// </summary>
        public unsafe float Stickiness_Target_MinDistanceDampValue_HipFire
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 152); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }; }
        }

        /// <summary>
        /// FloatProperty: Stickiness_Target_MaxDistanceDampValue_HipFire
        /// </summary>
        public unsafe float Stickiness_Target_MaxDistanceDampValue_HipFire
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 156); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }; }
        }

        /// <summary>
        /// FloatProperty: Stickiness_Target_MinDistanceToDamp_AimMode
        /// </summary>
        public unsafe float Stickiness_Target_MinDistanceToDamp_AimMode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 160); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }; }
        }

        /// <summary>
        /// FloatProperty: Stickiness_Target_MaxDistanceToDamp_AimMode
        /// </summary>
        public unsafe float Stickiness_Target_MaxDistanceToDamp_AimMode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 164); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }; }
        }

        /// <summary>
        /// FloatProperty: Stickiness_Target_MinDistanceDampValue_AimMode
        /// </summary>
        public unsafe float Stickiness_Target_MinDistanceDampValue_AimMode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 168); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }; }
        }

        /// <summary>
        /// FloatProperty: Stickiness_Target_MaxDistanceDampValue_AimMode
        /// </summary>
        public unsafe float Stickiness_Target_MaxDistanceDampValue_AimMode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 172); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }; }
        }
    }

    /// <summary>
    /// Struct: FSpreadValue
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FSpreadValue
    {
        /// <summary>
        /// FloatProperty: MinSpread
        /// </summary>
        public unsafe float MinSpread
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: MaxSpread
        /// </summary>
        public unsafe float MaxSpread
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: SpreadIncrease
        /// </summary>
        public unsafe float SpreadIncrease
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: SpreadRecovery
        /// </summary>
        public unsafe float SpreadRecovery
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// StructProperty: VfTable_IGDXRayInterface
    /// </summary>
    public unsafe System.IntPtr VfTable_IGDXRayInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// FloatProperty: RefireTime
    /// </summary>
    public unsafe float RefireTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// FloatProperty: FireTime
    /// </summary>
    public unsafe float FireTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// BoolProperty: bIsFullAuto
    /// </summary>
    public unsafe bool bIsFullAuto
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: bUsePenetration
    /// </summary>
    public unsafe bool bUsePenetration
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: bUseExplosiveBullets
    /// </summary>
    public unsafe bool bUseExplosiveBullets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: bUnzoomForReload
    /// </summary>
    public unsafe bool bUnzoomForReload
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: bCanFireWhileReloading
    /// </summary>
    public unsafe bool bCanFireWhileReloading
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: bIndividualBulletReload
    /// </summary>
    public unsafe bool bIndividualBulletReload
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreAnimToStopFiring
    /// </summary>
    public unsafe bool bIgnoreAnimToStopFiring
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: bUseAnimTriggeredExtraTraces
    /// </summary>
    public unsafe bool bUseAnimTriggeredExtraTraces
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: bUseSpreadGenerators
    /// </summary>
    public unsafe bool bUseSpreadGenerators
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: bIkResetSucceeded
    /// </summary>
    public unsafe bool bIkResetSucceeded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: StopAdditiveInstant
    /// </summary>
    public unsafe bool StopAdditiveInstant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: ReloadInterrupted
    /// </summary>
    public unsafe bool ReloadInterrupted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: bNotValidForGunExecution
    /// </summary>
    public unsafe bool bNotValidForGunExecution
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: LoopFireAudio
    /// </summary>
    public unsafe bool LoopFireAudio
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: LoopDryFireAudio
    /// </summary>
    public unsafe bool LoopDryFireAudio
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: ClipLowAlertTriggered
    /// </summary>
    public unsafe bool ClipLowAlertTriggered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: bFiring
    /// </summary>
    public unsafe bool bFiring
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: bDryFiring
    /// </summary>
    public unsafe bool bDryFiring
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: bPlayingFireSound
    /// </summary>
    public unsafe bool bPlayingFireSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: bPlayingDryFireSound
    /// </summary>
    public unsafe bool bPlayingDryFireSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: bBulletHeavy
    /// </summary>
    public unsafe bool bBulletHeavy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: bUseLoopingFX
    /// </summary>
    public unsafe bool bUseLoopingFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: PlayFireAnimOnGun
    /// </summary>
    public unsafe bool PlayFireAnimOnGun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: StopFireAnimOnGunIfInterrupted
    /// </summary>
    public unsafe bool StopFireAnimOnGunIfInterrupted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: PlayReloadAnimForEachBullet
    /// </summary>
    public unsafe bool PlayReloadAnimForEachBullet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: PlayReloadAnimOnGun
    /// </summary>
    public unsafe bool PlayReloadAnimOnGun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: bUseEquipUnequipAsAdditive
    /// </summary>
    public unsafe bool bUseEquipUnequipAsAdditive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: bEnableIk
    /// </summary>
    public unsafe bool bEnableIk
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: bIsUsedMirrored
    /// </summary>
    public unsafe bool bIsUsedMirrored
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: bEffectorHandSwitchRequest
    /// </summary>
    public unsafe bool bEffectorHandSwitchRequest
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: bEquipCompleted
    /// </summary>
    public unsafe bool bEquipCompleted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: bOverrideAimFOV
    /// </summary>
    public unsafe bool bOverrideAimFOV
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1148); }
    }

    /// <summary>
    /// BoolProperty: bOverrideAimSensitivity
    /// </summary>
    public unsafe bool bOverrideAimSensitivity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bOverrideAimFOVSpeed
    /// </summary>
    public unsafe bool bOverrideAimFOVSpeed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bOverrideAimOutFOVSpeed
    /// </summary>
    public unsafe bool bOverrideAimOutFOVSpeed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bOverrideAimAnimationTime
    /// </summary>
    public unsafe bool bOverrideAimAnimationTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bOverrideAimOutAnimationTime
    /// </summary>
    public unsafe bool bOverrideAimOutAnimationTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: UseClips
    /// </summary>
    public unsafe bool UseClips
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bOverrideAmmoCrateAwards
    /// </summary>
    public unsafe bool bOverrideAmmoCrateAwards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bDualWield
    /// </summary>
    public unsafe bool bDualWield
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bFireRequested
    /// </summary>
    public unsafe bool bFireRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bPlayingFireEffects
    /// </summary>
    public unsafe bool bPlayingFireEffects
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bDebugTraces
    /// </summary>
    public unsafe bool bDebugTraces
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bDebugDamage
    /// </summary>
    public unsafe bool bDebugDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bDebugSpread
    /// </summary>
    public unsafe bool bDebugSpread
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bUseRecoil
    /// </summary>
    public unsafe bool bUseRecoil
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bDebugTrajectory
    /// </summary>
    public unsafe bool bDebugTrajectory
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bDebugHitPos
    /// </summary>
    public unsafe bool bDebugHitPos
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bTryToFire
    /// </summary>
    public unsafe bool bTryToFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bReloading
    /// </summary>
    public unsafe bool bReloading
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bForceWaitToFire
    /// </summary>
    public unsafe bool bForceWaitToFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bQueuedUnequip
    /// </summary>
    public unsafe bool bQueuedUnequip
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bQueuedReload
    /// </summary>
    public unsafe bool bQueuedReload
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bQueuedFire
    /// </summary>
    public unsafe bool bQueuedFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bForcedNotDelayedUnequip
    /// </summary>
    public unsafe bool bForcedNotDelayedUnequip
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: DroppedGadget
    /// </summary>
    public unsafe bool DroppedGadget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bDestroyOnDrop
    /// </summary>
    public unsafe bool bDestroyOnDrop
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bShowingLowAlphaTargetCursor
    /// </summary>
    public unsafe bool bShowingLowAlphaTargetCursor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bShowingInvulnerableTargetCursor
    /// </summary>
    public unsafe bool bShowingInvulnerableTargetCursor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bShowingFriendlyTargetCursor
    /// </summary>
    public unsafe bool bShowingFriendlyTargetCursor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bShowingDotCursor
    /// </summary>
    public unsafe bool bShowingDotCursor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: InitMaxMinSpread
    /// </summary>
    public unsafe bool InitMaxMinSpread
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: ShouldSwayWhenAiming
    /// </summary>
    public unsafe bool ShouldSwayWhenAiming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: CentreOnSteady
    /// </summary>
    public unsafe bool CentreOnSteady
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bCanHoldBreath
    /// </summary>
    public unsafe bool bCanHoldBreath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1156) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1156); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1156); }
    }

    /// <summary>
    /// BoolProperty: RecoveringFromOutOfBreath
    /// </summary>
    public unsafe bool RecoveringFromOutOfBreath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1156) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1156); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1156); }
    }

    /// <summary>
    /// BoolProperty: BreathWasHeld
    /// </summary>
    public unsafe bool BreathWasHeld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1156) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1156); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1156); }
    }

    /// <summary>
    /// BoolProperty: m_bSightUp
    /// </summary>
    public unsafe bool m_bSightUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1156) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1156); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1156); }
    }

    /// <summary>
    /// BoolProperty: bSetSkin
    /// </summary>
    public unsafe bool bSetSkin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1156) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1156); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1156); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreWeaponSkins
    /// </summary>
    public unsafe bool bIgnoreWeaponSkins
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1156) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1156); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1156); }
    }

    /// <summary>
    /// IntProperty: BulletsPerShot
    /// </summary>
    public unsafe int BulletsPerShot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// FloatProperty: ChanceToSpawnDecal
    /// </summary>
    public unsafe float ChanceToSpawnDecal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// IntProperty: NumRicochets
    /// </summary>
    public unsafe int NumRicochets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// FloatProperty: FireStartLocationOffset
    /// </summary>
    public unsafe float FireStartLocationOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }

    /// <summary>
    /// FloatProperty: DryFireAutoSwitchTime
    /// </summary>
    public unsafe float DryFireAutoSwitchTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// ObjectProperty: Explosion
    /// </summary>
    public unsafe BmSDK.BmGame.GDExplosionHelper Explosion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDExplosionHelper>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: SpreadValues
    /// </summary>
    public InlineArray<BmSDK.BmGame.GDBaseGunGadget.FSpreadValue> SpreadValues => new(4, Ptr + 1184, 16, this);

    /// <summary>
    /// StructProperty: SpreadValues
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDBaseGunGadget.FSpreadValue SpreadValues_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDBaseGunGadget.FSpreadValue>(Ptr + 1184);
    /// <summary>
    /// StructProperty: SpreadValues
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDBaseGunGadget.FSpreadValue SpreadValues_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDBaseGunGadget.FSpreadValue>(Ptr + 1200);
    /// <summary>
    /// StructProperty: SpreadValues
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDBaseGunGadget.FSpreadValue SpreadValues_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDBaseGunGadget.FSpreadValue>(Ptr + 1216);
    /// <summary>
    /// StructProperty: SpreadValues
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDBaseGunGadget.FSpreadValue SpreadValues_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDBaseGunGadget.FSpreadValue>(Ptr + 1232);

    /// <summary>
    /// FloatProperty: WalkPenalty
    /// </summary>
    public unsafe float WalkPenalty
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// FloatProperty: JogPenalty
    /// </summary>
    public unsafe float JogPenalty
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// FloatProperty: SmokePenalty
    /// </summary>
    public unsafe float SmokePenalty
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// FloatProperty: ReloadPenalty
    /// </summary>
    public unsafe float ReloadPenalty
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }

    /// <summary>
    /// ArrayProperty: SpreadGenerators
    /// </summary>
    public unsafe BmSDK.TArray<int> SpreadGenerators
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// IntProperty: SpreadGeneratorIdx
    /// </summary>
    public unsafe int SpreadGeneratorIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1276); }
    }

    /// <summary>
    /// IntProperty: LastSpreadSeed
    /// </summary>
    public unsafe int LastSpreadSeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// FloatProperty: fInternalSpread
    /// </summary>
    public unsafe float fInternalSpread
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// FloatProperty: fCurrentSpread
    /// </summary>
    public unsafe float fCurrentSpread
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// ByteProperty: SpreadMode
    /// </summary>
    public unsafe BmSDK.BmGame.GDBaseGunGadget.ESpreadMode SpreadMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBaseGunGadget.ESpreadMode>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }

    /// <summary>
    /// ByteProperty: SelectedReloadType
    /// </summary>
    public unsafe BmSDK.BmGame.GDBaseGunGadget.EReloadTypes SelectedReloadType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBaseGunGadget.EReloadTypes>(Ptr + 1293); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1293); }
    }

    /// <summary>
    /// ByteProperty: CurrentReloadStatus
    /// </summary>
    public unsafe BmSDK.BmGame.GDBaseGunGadget.EReloadStatus CurrentReloadStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBaseGunGadget.EReloadStatus>(Ptr + 1294); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1294); }
    }

    /// <summary>
    /// ByteProperty: HudWeaponType
    /// </summary>
    public unsafe BmSDK.BmGame.GDBaseGunGadget.EHudWeaponType HudWeaponType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBaseGunGadget.EHudWeaponType>(Ptr + 1295); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1295); }
    }

    /// <summary>
    /// StructProperty: ExtremeSpread
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDBaseGunGadget.FSpreadValue ExtremeSpread
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDBaseGunGadget.FSpreadValue>(Ptr + 1296);

    /// <summary>
    /// ArrayProperty: Falloff
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDBaseGunGadget.FFalloffPoint> Falloff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDBaseGunGadget.FFalloffPoint>>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }

    /// <summary>
    /// IntProperty: FinalDamage
    /// </summary>
    public unsafe int FinalDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// ClassProperty: DamageType
    /// </summary>
    public unsafe BmSDK.Class DamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// StructProperty: CurrentAudio
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDBaseGunGadget.FBaseGunAudio CurrentAudio
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDBaseGunGadget.FBaseGunAudio>(Ptr + 1332);

    /// <summary>
    /// StructProperty: DefaultAudio
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDBaseGunGadget.FBaseGunAudio DefaultAudio
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDBaseGunGadget.FBaseGunAudio>(Ptr + 1376);

    /// <summary>
    /// IntProperty: ClipLowAmmoCount
    /// </summary>
    public unsafe int ClipLowAmmoCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventOnAmmoLow
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventOnAmmoLow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// ObjectProperty: BarkEventOnAmmoOut
    /// </summary>
    public unsafe BmSDK.BmGame.GDBarkEvent BarkEventOnAmmoOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDBarkEvent>(Ptr + 1428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1428); }
    }

    /// <summary>
    /// ObjectProperty: MuzzleFlash
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem MuzzleFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 1432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }
    }

    /// <summary>
    /// ObjectProperty: TracerBeam
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem TracerBeam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 1436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1436); }
    }

    /// <summary>
    /// ComponentProperty: CheapLightComponent
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent CheapLightComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 1440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }
    }

    /// <summary>
    /// ComponentProperty: DualWieldSecondLight
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent DualWieldSecondLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }

    /// <summary>
    /// ObjectProperty: MuzzleFlashEmitter
    /// </summary>
    public unsafe BmSDK.Engine.Emitter MuzzleFlashEmitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Emitter>(Ptr + 1448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }
    }

    /// <summary>
    /// ObjectProperty: DualWieldMuzzleFlashEmitter
    /// </summary>
    public unsafe BmSDK.Engine.Emitter DualWieldMuzzleFlashEmitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Emitter>(Ptr + 1452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1452); }
    }

    /// <summary>
    /// FloatProperty: LightFlashTime
    /// </summary>
    public unsafe float LightFlashTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1456); }
    }

    /// <summary>
    /// ObjectProperty: LoopingMuzzleFlashPS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem LoopingMuzzleFlashPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 1460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1460); }
    }

    /// <summary>
    /// ObjectProperty: LoopingTracerPS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem LoopingTracerPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 1464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }
    }

    /// <summary>
    /// ComponentProperty: LoopingMuzzleFlash
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent LoopingMuzzleFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1468); }
    }

    /// <summary>
    /// ComponentProperty: DualWieldLoopingMuzzleFlash
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent DualWieldLoopingMuzzleFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }
    }

    /// <summary>
    /// ComponentProperty: LoopingTracer
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent LoopingTracer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }

    /// <summary>
    /// ComponentProperty: DualWieldLoopingTracer
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent DualWieldLoopingTracer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }

    /// <summary>
    /// IntProperty: AmmoDropPerShot
    /// </summary>
    public unsafe int AmmoDropPerShot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1484); }
    }

    /// <summary>
    /// NameProperty: FireAnimName
    /// </summary>
    public unsafe BmSDK.FName FireAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }
    }

    /// <summary>
    /// NameProperty: MirroredFireAnimName
    /// </summary>
    public unsafe BmSDK.FName MirroredFireAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }

    /// <summary>
    /// NameProperty: FireLastBulletAnimName
    /// </summary>
    public unsafe BmSDK.FName FireLastBulletAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1504); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: ReloadStartAnimName
    /// </summary>
    public InlineArray<BmSDK.FName> ReloadStartAnimName => new(6, Ptr + 1512, 8, this);

    /// <summary>
    /// NameProperty: ReloadStartAnimName
    /// </summary>
    public unsafe BmSDK.FName ReloadStartAnimName_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }
    /// <summary>
    /// NameProperty: ReloadStartAnimName
    /// </summary>
    public unsafe BmSDK.FName ReloadStartAnimName_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1520); }
    }
    /// <summary>
    /// NameProperty: ReloadStartAnimName
    /// </summary>
    public unsafe BmSDK.FName ReloadStartAnimName_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1528); }
    }
    /// <summary>
    /// NameProperty: ReloadStartAnimName
    /// </summary>
    public unsafe BmSDK.FName ReloadStartAnimName_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }
    }
    /// <summary>
    /// NameProperty: ReloadStartAnimName
    /// </summary>
    public unsafe BmSDK.FName ReloadStartAnimName_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1544); }
    }
    /// <summary>
    /// NameProperty: ReloadStartAnimName
    /// </summary>
    public unsafe BmSDK.FName ReloadStartAnimName_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1552); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: ReloadAnimName
    /// </summary>
    public InlineArray<BmSDK.FName> ReloadAnimName => new(6, Ptr + 1560, 8, this);

    /// <summary>
    /// NameProperty: ReloadAnimName
    /// </summary>
    public unsafe BmSDK.FName ReloadAnimName_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }
    }
    /// <summary>
    /// NameProperty: ReloadAnimName
    /// </summary>
    public unsafe BmSDK.FName ReloadAnimName_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1568); }
    }
    /// <summary>
    /// NameProperty: ReloadAnimName
    /// </summary>
    public unsafe BmSDK.FName ReloadAnimName_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1576); }
    }
    /// <summary>
    /// NameProperty: ReloadAnimName
    /// </summary>
    public unsafe BmSDK.FName ReloadAnimName_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1584); }
    }
    /// <summary>
    /// NameProperty: ReloadAnimName
    /// </summary>
    public unsafe BmSDK.FName ReloadAnimName_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1592); }
    }
    /// <summary>
    /// NameProperty: ReloadAnimName
    /// </summary>
    public unsafe BmSDK.FName ReloadAnimName_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1600); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: ReloadEndAnimName
    /// </summary>
    public InlineArray<BmSDK.FName> ReloadEndAnimName => new(6, Ptr + 1608, 8, this);

    /// <summary>
    /// NameProperty: ReloadEndAnimName
    /// </summary>
    public unsafe BmSDK.FName ReloadEndAnimName_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1608); }
    }
    /// <summary>
    /// NameProperty: ReloadEndAnimName
    /// </summary>
    public unsafe BmSDK.FName ReloadEndAnimName_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1616); }
    }
    /// <summary>
    /// NameProperty: ReloadEndAnimName
    /// </summary>
    public unsafe BmSDK.FName ReloadEndAnimName_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1624); }
    }
    /// <summary>
    /// NameProperty: ReloadEndAnimName
    /// </summary>
    public unsafe BmSDK.FName ReloadEndAnimName_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1632); }
    }
    /// <summary>
    /// NameProperty: ReloadEndAnimName
    /// </summary>
    public unsafe BmSDK.FName ReloadEndAnimName_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1640); }
    }
    /// <summary>
    /// NameProperty: ReloadEndAnimName
    /// </summary>
    public unsafe BmSDK.FName ReloadEndAnimName_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1648); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: ReloadEndAlternativeAnimName
    /// </summary>
    public InlineArray<BmSDK.FName> ReloadEndAlternativeAnimName => new(6, Ptr + 1656, 8, this);

    /// <summary>
    /// NameProperty: ReloadEndAlternativeAnimName
    /// </summary>
    public unsafe BmSDK.FName ReloadEndAlternativeAnimName_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1656); }
    }
    /// <summary>
    /// NameProperty: ReloadEndAlternativeAnimName
    /// </summary>
    public unsafe BmSDK.FName ReloadEndAlternativeAnimName_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1664); }
    }
    /// <summary>
    /// NameProperty: ReloadEndAlternativeAnimName
    /// </summary>
    public unsafe BmSDK.FName ReloadEndAlternativeAnimName_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1672); }
    }
    /// <summary>
    /// NameProperty: ReloadEndAlternativeAnimName
    /// </summary>
    public unsafe BmSDK.FName ReloadEndAlternativeAnimName_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1680); }
    }
    /// <summary>
    /// NameProperty: ReloadEndAlternativeAnimName
    /// </summary>
    public unsafe BmSDK.FName ReloadEndAlternativeAnimName_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1688); }
    }
    /// <summary>
    /// NameProperty: ReloadEndAlternativeAnimName
    /// </summary>
    public unsafe BmSDK.FName ReloadEndAlternativeAnimName_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1696); }
    }

    /// <summary>
    /// NameProperty: GunIdleAnimName
    /// </summary>
    public unsafe BmSDK.FName GunIdleAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1704); }
    }

    /// <summary>
    /// IntProperty: ReloadLoopsToPlay
    /// </summary>
    public unsafe int ReloadLoopsToPlay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1712); }
    }

    /// <summary>
    /// ObjectProperty: FiringSpecialMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSimpleSpecialMoveConfig FiringSpecialMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSimpleSpecialMoveConfig>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }

    /// <summary>
    /// ArrayProperty: AnimSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> AnimSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 1720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }
    }

    /// <summary>
    /// NameProperty: EquipAnim
    /// </summary>
    public unsafe BmSDK.FName EquipAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1732); }
    }

    /// <summary>
    /// NameProperty: EquipFullCoverAnim
    /// </summary>
    public unsafe BmSDK.FName EquipFullCoverAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1740); }
    }

    /// <summary>
    /// NameProperty: EquipHalfCoverAnim
    /// </summary>
    public unsafe BmSDK.FName EquipHalfCoverAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1748); }
    }

    /// <summary>
    /// NameProperty: UnequipAnim
    /// </summary>
    public unsafe BmSDK.FName UnequipAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1756); }
    }

    /// <summary>
    /// NameProperty: UnequipFullCoverAnim
    /// </summary>
    public unsafe BmSDK.FName UnequipFullCoverAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1764); }
    }

    /// <summary>
    /// NameProperty: UnequipHalfCoverAnim
    /// </summary>
    public unsafe BmSDK.FName UnequipHalfCoverAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1772); }
    }

    /// <summary>
    /// FloatProperty: EquipTime
    /// </summary>
    public unsafe float EquipTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1780); }
    }

    /// <summary>
    /// FloatProperty: UnequipTime
    /// </summary>
    public unsafe float UnequipTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1784); }
    }

    /// <summary>
    /// StructProperty: LeftHandIkEffectorLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LeftHandIkEffectorLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1788);

    /// <summary>
    /// StructProperty: RightHandIkEffectorLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RightHandIkEffectorLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1800);

    /// <summary>
    /// FloatProperty: AimingFOV
    /// </summary>
    public unsafe float AimingFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1812); }
    }

    /// <summary>
    /// FloatProperty: AimingSensScale
    /// </summary>
    public unsafe float AimingSensScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1816); }
    }

    /// <summary>
    /// FloatProperty: AimingFOVSpeed
    /// </summary>
    public unsafe float AimingFOVSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1820); }
    }

    /// <summary>
    /// FloatProperty: AimingOutFOVSpeed
    /// </summary>
    public unsafe float AimingOutFOVSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1824); }
    }

    /// <summary>
    /// FloatProperty: AimingAnimationTime
    /// </summary>
    public unsafe float AimingAnimationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1828); }
    }

    /// <summary>
    /// FloatProperty: AimingOutAnimationTime
    /// </summary>
    public unsafe float AimingOutAnimationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1832); }
    }

    /// <summary>
    /// StructProperty: AimingAssistanceValues
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDBaseGunGadget.FAimAssitanceValues AimingAssistanceValues
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDBaseGunGadget.FAimAssitanceValues>(Ptr + 1836);

    /// <summary>
    /// ObjectProperty: AimingScopeMovie
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie AimingScopeMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 2012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2012); }
    }

    /// <summary>
    /// ObjectProperty: ScopeMoviePlayer
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxMoviePlayer ScopeMoviePlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxMoviePlayer>(Ptr + 2016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2016); }
    }

    /// <summary>
    /// FloatProperty: RecoilAngle
    /// </summary>
    public unsafe float RecoilAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2020); }
    }

    /// <summary>
    /// FloatProperty: AimModeRecoilAngle
    /// </summary>
    public unsafe float AimModeRecoilAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2024); }
    }

    /// <summary>
    /// FloatProperty: RecoilRate
    /// </summary>
    public unsafe float RecoilRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2028); }
    }

    /// <summary>
    /// FloatProperty: AimModeRecoilRate
    /// </summary>
    public unsafe float AimModeRecoilRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2032); }
    }

    /// <summary>
    /// FloatProperty: RecoilRecovery
    /// </summary>
    public unsafe float RecoilRecovery
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2036); }
    }

    /// <summary>
    /// FloatProperty: AimModeRecoilRecovery
    /// </summary>
    public unsafe float AimModeRecoilRecovery
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2040); }
    }

    /// <summary>
    /// FloatProperty: ReloadTime
    /// </summary>
    public unsafe float ReloadTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2044); }
    }

    /// <summary>
    /// IntProperty: NumberOfClips
    /// </summary>
    public unsafe int NumberOfClips
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2048); }
    }

    /// <summary>
    /// IntProperty: StartingAmmoAmmo
    /// </summary>
    public unsafe int StartingAmmoAmmo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2052); }
    }

    /// <summary>
    /// ArrayProperty: AmmoCrateStageBullets
    /// </summary>
    public unsafe BmSDK.TArray<int> AmmoCrateStageBullets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2056); }
    }

    /// <summary>
    /// IntProperty: CurrentTotalAmmo
    /// </summary>
    public unsafe int CurrentTotalAmmo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2068); }
    }

    /// <summary>
    /// FloatProperty: CurrentReloadTime
    /// </summary>
    public unsafe float CurrentReloadTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }
    }

    /// <summary>
    /// IntProperty: LocalAmmo
    /// </summary>
    public unsafe int LocalAmmo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2076); }
    }

    /// <summary>
    /// ComponentProperty: DualWieldSecondMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent DualWieldSecondMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 2080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2080); }
    }

    /// <summary>
    /// ObjectProperty: DualWieldGadget
    /// </summary>
    public unsafe BmSDK.BmGame.GDDualWieldGadget DualWieldGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDDualWieldGadget>(Ptr + 2084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2084); }
    }

    /// <summary>
    /// FloatProperty: DualWieldEndTime
    /// </summary>
    public unsafe float DualWieldEndTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2088); }
    }

    /// <summary>
    /// StructProperty: ReloadOverlayId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId ReloadOverlayId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(Ptr + 2092);

    /// <summary>
    /// StructProperty: FireOverlayId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId FireOverlayId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(Ptr + 2100);

    /// <summary>
    /// StructProperty: EquipOverlayId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId EquipOverlayId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(Ptr + 2108);

    /// <summary>
    /// StructProperty: EquipTransitionId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId EquipTransitionId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 2116);

    /// <summary>
    /// FloatProperty: m_TraceRange
    /// </summary>
    public unsafe float m_TraceRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }
    }

    /// <summary>
    /// ObjectProperty: DestroyedObjectPhysicsAsset
    /// </summary>
    public unsafe BmSDK.Engine.PhysicsAsset DestroyedObjectPhysicsAsset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicsAsset>(Ptr + 2124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2124); }
    }

    /// <summary>
    /// ObjectProperty: PawnForDropWeapon
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat PawnForDropWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 2128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2128); }
    }

    /// <summary>
    /// ObjectProperty: ControllerForDropWeapon
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController ControllerForDropWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 2132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2132); }
    }

    /// <summary>
    /// ObjectProperty: DestroyedObject
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatThrownObject DestroyedObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatThrownObject>(Ptr + 2136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2136); }
    }

    /// <summary>
    /// StrProperty: WeaponReticuleName
    /// </summary>
    public unsafe BmSDK.FString WeaponReticuleName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2140); }
    }

    /// <summary>
    /// FloatProperty: HUDMaxSpreadDist
    /// </summary>
    public unsafe float HUDMaxSpreadDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2152); }
    }

    /// <summary>
    /// FloatProperty: HUDMinSpreadDist
    /// </summary>
    public unsafe float HUDMinSpreadDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2156); }
    }

    /// <summary>
    /// FloatProperty: HUDAimingMaxSpreadDist
    /// </summary>
    public unsafe float HUDAimingMaxSpreadDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }

    /// <summary>
    /// FloatProperty: HUDAimingMinSpreadDist
    /// </summary>
    public unsafe float HUDAimingMinSpreadDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2164); }
    }

    /// <summary>
    /// FloatProperty: MaxAimRotationOffsetAllowed
    /// </summary>
    public unsafe float MaxAimRotationOffsetAllowed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2168); }
    }

    /// <summary>
    /// FloatProperty: NextCrosshairTargetTraceCheck
    /// </summary>
    public unsafe float NextCrosshairTargetTraceCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2172); }
    }

    /// <summary>
    /// FloatProperty: CrosshairTargetTraceCheckDelay
    /// </summary>
    public unsafe float CrosshairTargetTraceCheckDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }
    }

    /// <summary>
    /// ObjectProperty: XRayHelper
    /// </summary>
    public unsafe BmSDK.BmGame.GDXRayModeHelper XRayHelper
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDXRayModeHelper>(Ptr + 2180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2180); }
    }

    /// <summary>
    /// ObjectProperty: XRayMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XRayMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2184); }
    }

    /// <summary>
    /// ObjectProperty: XRayMetalMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XRayMetalMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2188); }
    }

    /// <summary>
    /// ObjectProperty: ThermalMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface ThermalMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2192); }
    }

    /// <summary>
    /// NameProperty: GadgetClassNameForHUD
    /// </summary>
    public unsafe BmSDK.FName GadgetClassNameForHUD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2196); }
    }

    /// <summary>
    /// IntProperty: MyUpgradeIdx
    /// </summary>
    public unsafe int MyUpgradeIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2204); }
    }

    /// <summary>
    /// ArrayProperty: m_Primes
    /// </summary>
    public unsafe BmSDK.TArray<int> m_Primes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2208); }
    }

    /// <summary>
    /// ArrayProperty: m_ShuffledPrimes
    /// </summary>
    public unsafe BmSDK.TArray<int> m_ShuffledPrimes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2220); }
    }

    /// <summary>
    /// FloatProperty: VerticalSwayAngle
    /// </summary>
    public unsafe float VerticalSwayAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2232); }
    }

    /// <summary>
    /// FloatProperty: HorizontalSwayAngle
    /// </summary>
    public unsafe float HorizontalSwayAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2236); }
    }

    /// <summary>
    /// FloatProperty: SwaySpeedMultiplier
    /// </summary>
    public unsafe float SwaySpeedMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2240); }
    }

    /// <summary>
    /// FloatProperty: BreathHeldSwayMultiplier
    /// </summary>
    public unsafe float BreathHeldSwayMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2244); }
    }

    /// <summary>
    /// FloatProperty: SwayTotalModifier
    /// </summary>
    public unsafe float SwayTotalModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2248); }
    }

    /// <summary>
    /// FloatProperty: MaxTimeToHoldBreath
    /// </summary>
    public unsafe float MaxTimeToHoldBreath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2252); }
    }

    /// <summary>
    /// FloatProperty: OutOfBreathMultiplier
    /// </summary>
    public unsafe float OutOfBreathMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }
    }

    /// <summary>
    /// FloatProperty: MinSwayMultiplierStanding
    /// </summary>
    public unsafe float MinSwayMultiplierStanding
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2260); }
    }

    /// <summary>
    /// FloatProperty: MinSwayMultiplierInCover
    /// </summary>
    public unsafe float MinSwayMultiplierInCover
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2264); }
    }

    /// <summary>
    /// FloatProperty: MaxSwayMultiplierAfterScopeUp
    /// </summary>
    public unsafe float MaxSwayMultiplierAfterScopeUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2268); }
    }

    /// <summary>
    /// FloatProperty: MaxSwayMultiplierAfterMoving
    /// </summary>
    public unsafe float MaxSwayMultiplierAfterMoving
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2272); }
    }

    /// <summary>
    /// FloatProperty: MaxSwayMultiplierAfterFiring
    /// </summary>
    public unsafe float MaxSwayMultiplierAfterFiring
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2276); }
    }

    /// <summary>
    /// FloatProperty: MaxSwayMultiplierAfterFiringAndMoving
    /// </summary>
    public unsafe float MaxSwayMultiplierAfterFiringAndMoving
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }
    }

    /// <summary>
    /// FloatProperty: MaxSwayMultiplierAfterAimAdjust
    /// </summary>
    public unsafe float MaxSwayMultiplierAfterAimAdjust
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2284); }
    }

    /// <summary>
    /// FloatProperty: MaxRecoveryPerSecAfterScopeUp
    /// </summary>
    public unsafe float MaxRecoveryPerSecAfterScopeUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2288); }
    }

    /// <summary>
    /// FloatProperty: MaxRecoveryPerSecAfterMoving
    /// </summary>
    public unsafe float MaxRecoveryPerSecAfterMoving
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2292); }
    }

    /// <summary>
    /// FloatProperty: MaxRecoveryPerSecAfterFiring
    /// </summary>
    public unsafe float MaxRecoveryPerSecAfterFiring
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2296); }
    }

    /// <summary>
    /// FloatProperty: MaxRecoveryPerSecAfterFiringAndMoving
    /// </summary>
    public unsafe float MaxRecoveryPerSecAfterFiringAndMoving
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2300); }
    }

    /// <summary>
    /// FloatProperty: MaxRecoveryPerSecAfterAimAdjust
    /// </summary>
    public unsafe float MaxRecoveryPerSecAfterAimAdjust
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }
    }

    /// <summary>
    /// FloatProperty: MaxAimAdjustDiffBeforeSway
    /// </summary>
    public unsafe float MaxAimAdjustDiffBeforeSway
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2308); }
    }

    /// <summary>
    /// FloatProperty: MinScopeUpAimOffsetAngle
    /// </summary>
    public unsafe float MinScopeUpAimOffsetAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2312); }
    }

    /// <summary>
    /// FloatProperty: MaxScopeUpAimOffsetAngle
    /// </summary>
    public unsafe float MaxScopeUpAimOffsetAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2316); }
    }

    /// <summary>
    /// FloatProperty: CurrentHeldBreathTime
    /// </summary>
    public unsafe float CurrentHeldBreathTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2320); }
    }

    /// <summary>
    /// FloatProperty: SwayRecoveryPerSec
    /// </summary>
    public unsafe float SwayRecoveryPerSec
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2324); }
    }

    /// <summary>
    /// FloatProperty: m_fSwayTimer
    /// </summary>
    public unsafe float m_fSwayTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2328); }
    }

    /// <summary>
    /// FloatProperty: m_fHorizontalSwaySign
    /// </summary>
    public unsafe float m_fHorizontalSwaySign
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2332); }
    }

    /// <summary>
    /// FloatProperty: m_fVerticalSwaySign
    /// </summary>
    public unsafe float m_fVerticalSwaySign
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2336); }
    }

    /// <summary>
    /// FloatProperty: m_CurrentSwayMultiplier
    /// </summary>
    public unsafe float m_CurrentSwayMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2340); }
    }

    /// <summary>
    /// FloatProperty: m_TargetSwayMultiplier
    /// </summary>
    public unsafe float m_TargetSwayMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2344); }
    }

    /// <summary>
    /// StructProperty: m_OldSway
    /// </summary>
    public unsafe ref BmSDK.Rotator m_OldSway
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2348);

    /// <summary>
    /// IntProperty: ScopeSeed
    /// </summary>
    public unsafe int ScopeSeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2360); }
    }

    /// <summary>
    /// StructProperty: ScopeUpAimOffset
    /// </summary>
    public unsafe ref BmSDK.Rotator ScopeUpAimOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2364);

    /// <summary>
    /// IntProperty: StartTimeAvailable
    /// </summary>
    public unsafe int StartTimeAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2376); }
    }

    /// <summary>
    /// IntProperty: StartTimeEquip
    /// </summary>
    public unsafe int StartTimeEquip
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2380); }
    }

    /// <summary>
    /// IntProperty: StartTimeEmpty
    /// </summary>
    public unsafe int StartTimeEmpty
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2384); }
    }
}
