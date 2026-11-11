#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: GDCharCustomizationPreviewBase<br/>
/// (size = 52)
/// (flags = 32795)
/// </summary>
public partial class GDCharCustomizationPreviewBase : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDCharCustomizationPreviewBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDCharCustomizationPreviewBase.
    /// </summary>
    public static GDCharCustomizationPreviewBase DefaultObject => (GDCharCustomizationPreviewBase)StaticClass().DefaultObject;

    internal GDCharCustomizationPreviewBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDCharCustomizationPreviewBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDCharCustomizationPreviewBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDCharCustomizationPreviewBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDCharCustomizationPreviewBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDCharCustomizationPreviewBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDCharCustomizationPreviewBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDCharCustomizationPreviewBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDCharCustomizationPreviewBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDCharCustomizationPreviewBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetPreviewSkinData;
    /// <summary>
    /// Function: GetPreviewSkinData
    /// </summary>
    public unsafe virtual void GetPreviewSkinData(out BmSDK.BmGame.RGameInfo.WeaponId Weapon, out int SkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPreviewSkinData, "BmGame.GDCharCustomizationPreviewBase.GetPreviewSkinData");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Weapon);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Weapon, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SkinIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkinIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Weapon = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.WeaponId>(paramsPtr + 0);
        SkinIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_UpdateWeaponPreview;
    /// <summary>
    /// Function: UpdateWeaponPreview
    /// </summary>
    public unsafe virtual void UpdateWeaponPreview(BmSDK.Engine.SkeletalMeshComponent Mesh, int TeamIndex, int WeaponIndex, int WeaponSkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateWeaponPreview, "BmGame.GDCharCustomizationPreviewBase.UpdateWeaponPreview");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mesh, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponSkinIndex, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPawnConfig;
    /// <summary>
    /// Function: GetPawnConfig
    /// </summary>
    public unsafe virtual BmSDK.GameObject GetPawnConfig()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPawnConfig, "BmGame.GDCharCustomizationPreviewBase.GetPawnConfig");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdatePreviewAfterBankChange;
    /// <summary>
    /// Function: UpdatePreviewAfterBankChange
    /// </summary>
    public unsafe virtual void UpdatePreviewAfterBankChange(int CustomizationTeamIndex, int BankIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePreviewAfterBankChange, "BmGame.GDCharCustomizationPreviewBase.UpdatePreviewAfterBankChange");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BankIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetPreviewPawn;
    /// <summary>
    /// Function: ResetPreviewPawn
    /// </summary>
    public unsafe virtual void ResetPreviewPawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetPreviewPawn, "BmGame.GDCharCustomizationPreviewBase.ResetPreviewPawn");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdatePreviewPawn;
    /// <summary>
    /// Function: UpdatePreviewPawn
    /// </summary>
    public unsafe virtual bool UpdatePreviewPawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePreviewPawn, "BmGame.GDCharCustomizationPreviewBase.UpdatePreviewPawn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCurrentPreviewPartColor;
    /// <summary>
    /// Function: GetCurrentPreviewPartColor
    /// </summary>
    public unsafe virtual BmSDK.GameObject.FColor GetCurrentPreviewPartColor(int CustomizationTeamIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentPreviewPartColor, "BmGame.GDCharCustomizationPreviewBase.GetCurrentPreviewPartColor");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FColor>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetCurrentPreviewPartColor;
    /// <summary>
    /// Function: SetCurrentPreviewPartColor
    /// </summary>
    public unsafe virtual void SetCurrentPreviewPartColor(int CustomizationTeamIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, in BmSDK.GameObject.FColor ColorValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentPreviewPartColor, "BmGame.GDCharCustomizationPreviewBase.SetCurrentPreviewPartColor");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ColorValue, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCurrentPreviewPartSkinIndex;
    /// <summary>
    /// Function: SetCurrentPreviewPartSkinIndex
    /// </summary>
    public unsafe virtual void SetCurrentPreviewPartSkinIndex(int CustomizationTeamIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, int VariantIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentPreviewPartSkinIndex, "BmGame.GDCharCustomizationPreviewBase.SetCurrentPreviewPartSkinIndex");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VariantIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCurrentPreviewPart;
    /// <summary>
    /// Function: SetCurrentPreviewPart
    /// </summary>
    public unsafe virtual void SetCurrentPreviewPart(int CustomizationTeamIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, int CustomPartIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentPreviewPart, "BmGame.GDCharCustomizationPreviewBase.SetCurrentPreviewPart");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomPartIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCustomPartInfo;
    /// <summary>
    /// Function: GetCustomPartInfo
    /// </summary>
    public unsafe virtual bool GetCustomPartInfo(int CustomizationTeamIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, int CustomPartIndex, bool bEntitledOnly, out BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationPartInfo outCharacterCustomizationPartInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCustomPartInfo, "BmGame.GDCharCustomizationPreviewBase.GetCustomPartInfo");
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomPartIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEntitledOnly, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outCharacterCustomizationPartInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationPartInfo>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 108);
    }

    private static BmSDK.Function __fn_GetCustomPartInfoList;
    /// <summary>
    /// Function: GetCustomPartInfoList
    /// </summary>
    public unsafe virtual int GetCustomPartInfoList(int CustomizationTeamIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, bool bEntitledOnly, out BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationPartInfo> outCharacterCustomizationPartInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCustomPartInfoList, "BmGame.GDCharCustomizationPreviewBase.GetCustomPartInfoList");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEntitledOnly, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outCharacterCustomizationPartInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationPartInfo>>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetNumCustomParts;
    /// <summary>
    /// Function: GetNumCustomParts
    /// </summary>
    public unsafe virtual int GetNumCustomParts(int CustomizationTeamIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, bool bEntitledOnly)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumCustomParts, "BmGame.GDCharCustomizationPreviewBase.GetNumCustomParts");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEntitledOnly, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetPreviewTeamData;
    /// <summary>
    /// Function: SetPreviewTeamData
    /// </summary>
    public unsafe virtual void SetPreviewTeamData(int CustomizationTeamIndex, in BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection previewSelection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPreviewTeamData, "BmGame.GDCharCustomizationPreviewBase.SetPreviewTeamData");
        byte* paramsPtr = stackalloc byte[116];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(previewSelection, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPreviewTeam;
    /// <summary>
    /// Function: SetPreviewTeam
    /// </summary>
    public unsafe virtual void SetPreviewTeam(int CustomizationTeamIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPreviewTeam, "BmGame.GDCharCustomizationPreviewBase.SetPreviewTeam");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPreviewPawn;
    /// <summary>
    /// Function: SetPreviewPawn
    /// </summary>
    public unsafe virtual void SetPreviewPawn(int CustomizationTeamIndex, BmSDK.BmGame.GDCinematicCustomizationActor PreviewPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPreviewPawn, "BmGame.GDCharCustomizationPreviewBase.SetPreviewPawn");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviewPawn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShutDown;
    /// <summary>
    /// Function: ShutDown
    /// </summary>
    public unsafe virtual void ShutDown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShutDown, "BmGame.GDCharCustomizationPreviewBase.ShutDown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Initialize;
    /// <summary>
    /// Function: Initialize
    /// </summary>
    public unsafe virtual void Initialize(BmSDK.BmGame.GDCharCustomizationManager CustomizationManager, int NumTeams)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialize, "BmGame.GDCharCustomizationPreviewBase.Initialize");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationManager, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumTeams, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: m_IsInitialized
    /// </summary>
    public unsafe bool m_IsInitialized
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }
}
