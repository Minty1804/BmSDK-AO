#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: GDCharCustomizationPreview<br/>
/// (size = 100)
/// (flags = 32794)
/// </summary>
public partial class GDCharCustomizationPreview : BmSDK.BmGame.GDCharCustomizationPreviewBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.GDCharCustomizationPreview", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDCharCustomizationPreview.
    /// </summary>
    public static GDCharCustomizationPreview DefaultObject => (GDCharCustomizationPreview)StaticClass().DefaultObject;

    internal GDCharCustomizationPreview() { }

    /// <summary>
    /// Constructs a new GDCharCustomizationPreview
    /// </summary>
    public GDCharCustomizationPreview(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDCharCustomizationPreview Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDCharCustomizationPreview(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDCharCustomizationPreview>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDCharCustomizationPreview>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDCharCustomizationPreview>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDCharCustomizationPreview>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDCharCustomizationPreview>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDCharCustomizationPreview>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDCharCustomizationPreview>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDCharCustomizationPreview>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetPreviewSkinData;
    /// <summary>
    /// Function: GetPreviewSkinData
    /// </summary>
    public unsafe override void GetPreviewSkinData(out BmSDK.BmGame.RGameInfo.WeaponId Weapon, out int SkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPreviewSkinData, "BmScript.GDCharCustomizationPreview.GetPreviewSkinData");
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
    public unsafe override void UpdateWeaponPreview(BmSDK.Engine.SkeletalMeshComponent Mesh, int TeamIndex, int WeaponIndex, int WeaponSkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateWeaponPreview, "BmScript.GDCharCustomizationPreview.UpdateWeaponPreview");
        byte* paramsPtr = stackalloc byte[52];
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
    public unsafe override BmSDK.GameObject GetPawnConfig()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPawnConfig, "BmScript.GDCharCustomizationPreview.GetPawnConfig");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FindPreviewUpper;
    /// <summary>
    /// Function: FindPreviewUpper
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDCharCustomAsset_Upper FindPreviewUpper(int CustomizationTeamIndex, int CustomPartIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPreviewUpper, "BmScript.GDCharCustomizationPreview.FindPreviewUpper");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomPartIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDCharCustomAsset_Upper>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FindPreviewUndershirt;
    /// <summary>
    /// Function: FindPreviewUndershirt
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDCharCustomAsset_Undershirt FindPreviewUndershirt(int CustomizationTeamIndex, int CustomPartIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPreviewUndershirt, "BmScript.GDCharCustomizationPreview.FindPreviewUndershirt");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomPartIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDCharCustomAsset_Undershirt>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FindPreviewTattoo;
    /// <summary>
    /// Function: FindPreviewTattoo
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDCharCustomAsset_Tattoo FindPreviewTattoo(int CustomizationTeamIndex, int CustomPartIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPreviewTattoo, "BmScript.GDCharCustomizationPreview.FindPreviewTattoo");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomPartIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDCharCustomAsset_Tattoo>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FindPreviewLower;
    /// <summary>
    /// Function: FindPreviewLower
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDCharCustomAsset_Lower FindPreviewLower(int CustomizationTeamIndex, int CustomPartIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPreviewLower, "BmScript.GDCharCustomizationPreview.FindPreviewLower");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomPartIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDCharCustomAsset_Lower>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FindPreviewHair;
    /// <summary>
    /// Function: FindPreviewHair
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDCharCustomAsset_Hair FindPreviewHair(int CustomizationTeamIndex, int CustomPartIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPreviewHair, "BmScript.GDCharCustomizationPreview.FindPreviewHair");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomPartIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDCharCustomAsset_Hair>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FindPreviewFacialHair;
    /// <summary>
    /// Function: FindPreviewFacialHair
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDCharCustomAsset_FacialHair FindPreviewFacialHair(int CustomizationTeamIndex, int CustomPartIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPreviewFacialHair, "BmScript.GDCharCustomizationPreview.FindPreviewFacialHair");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomPartIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDCharCustomAsset_FacialHair>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FindPreviewFacePaint;
    /// <summary>
    /// Function: FindPreviewFacePaint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDCharCustomAsset_FacePaint FindPreviewFacePaint(int CustomizationTeamIndex, int CustomPartIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPreviewFacePaint, "BmScript.GDCharCustomizationPreview.FindPreviewFacePaint");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomPartIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDCharCustomAsset_FacePaint>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FindPreviewFaceGear;
    /// <summary>
    /// Function: FindPreviewFaceGear
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDCharCustomAsset_FaceGear FindPreviewFaceGear(int CustomizationTeamIndex, int CustomPartIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPreviewFaceGear, "BmScript.GDCharCustomizationPreview.FindPreviewFaceGear");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomPartIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDCharCustomAsset_FaceGear>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_FindPreviewArchetype;
    /// <summary>
    /// Function: FindPreviewArchetype
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDCharCustomAsset_Archetype FindPreviewArchetype(int CustomizationTeamIndex, int CustomPartIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindPreviewArchetype, "BmScript.GDCharCustomizationPreview.FindPreviewArchetype");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomPartIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDCharCustomAsset_Archetype>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_UpdatePreviewAfterBankChange;
    /// <summary>
    /// Function: UpdatePreviewAfterBankChange
    /// </summary>
    public unsafe override void UpdatePreviewAfterBankChange(int CustomizationTeamIndex, int BankIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePreviewAfterBankChange, "BmScript.GDCharCustomizationPreview.UpdatePreviewAfterBankChange");
        byte* paramsPtr = stackalloc byte[120];
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
    public unsafe override void ResetPreviewPawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetPreviewPawn, "BmScript.GDCharCustomizationPreview.ResetPreviewPawn");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdatePreviewPawn;
    /// <summary>
    /// Function: UpdatePreviewPawn
    /// </summary>
    public unsafe override bool UpdatePreviewPawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePreviewPawn, "BmScript.GDCharCustomizationPreview.UpdatePreviewPawn");
        byte* paramsPtr = stackalloc byte[232];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FlagUpdatePreview;
    /// <summary>
    /// Function: FlagUpdatePreview
    /// </summary>
    public unsafe virtual void FlagUpdatePreview(int CustomizationTeamIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlagUpdatePreview, "BmScript.GDCharCustomizationPreview.FlagUpdatePreview");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCurrentPreviewPartColor;
    /// <summary>
    /// Function: GetCurrentPreviewPartColor
    /// </summary>
    public unsafe override BmSDK.GameObject.FColor GetCurrentPreviewPartColor(int CustomizationTeamIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentPreviewPartColor, "BmScript.GDCharCustomizationPreview.GetCurrentPreviewPartColor");
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
    public unsafe override void SetCurrentPreviewPartColor(int CustomizationTeamIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, in BmSDK.GameObject.FColor ColorValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentPreviewPartColor, "BmScript.GDCharCustomizationPreview.SetCurrentPreviewPartColor");
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
    public unsafe override void SetCurrentPreviewPartSkinIndex(int CustomizationTeamIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, int VariantIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentPreviewPartSkinIndex, "BmScript.GDCharCustomizationPreview.SetCurrentPreviewPartSkinIndex");
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
    public unsafe override void SetCurrentPreviewPart(int CustomizationTeamIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, int CustomPartIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentPreviewPart, "BmScript.GDCharCustomizationPreview.SetCurrentPreviewPart");
        byte* paramsPtr = stackalloc byte[120];
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
    public unsafe override bool GetCustomPartInfo(int CustomizationTeamIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, int CustomPartIndex, bool bEntitledOnly, out BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationPartInfo outCharacterCustomizationPartInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCustomPartInfo, "BmScript.GDCharCustomizationPreview.GetCustomPartInfo");
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
    public unsafe override int GetCustomPartInfoList(int CustomizationTeamIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, bool bEntitledOnly, out BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationPartInfo> outCharacterCustomizationPartInfoList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCustomPartInfoList, "BmScript.GDCharCustomizationPreview.GetCustomPartInfoList");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationTeamIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharCustomPartType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEntitledOnly, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        outCharacterCustomizationPartInfoList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDCharCustomizationManager.FSCharacterCustomizationPartInfo>>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetNumCustomParts;
    /// <summary>
    /// Function: GetNumCustomParts
    /// </summary>
    public unsafe override int GetNumCustomParts(int CustomizationTeamIndex, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType CharCustomPartType, bool bEntitledOnly)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumCustomParts, "BmScript.GDCharCustomizationPreview.GetNumCustomParts");
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
    public unsafe override void SetPreviewTeamData(int CustomizationTeamIndex, in BmSDK.BmGame.GDCharCustomizationManager_Selection.FGDCharCustomizationSelection previewSelection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPreviewTeamData, "BmScript.GDCharCustomizationPreview.SetPreviewTeamData");
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
    public unsafe override void SetPreviewTeam(int CustomizationTeamIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPreviewTeam, "BmScript.GDCharCustomizationPreview.SetPreviewTeam");
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
    public unsafe override void SetPreviewPawn(int CustomizationTeamIndex, BmSDK.BmGame.GDCinematicCustomizationActor PreviewPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPreviewPawn, "BmScript.GDCharCustomizationPreview.SetPreviewPawn");
        byte* paramsPtr = stackalloc byte[28];
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
    public unsafe override void ShutDown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShutDown, "BmScript.GDCharCustomizationPreview.ShutDown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Initialize;
    /// <summary>
    /// Function: Initialize
    /// </summary>
    public unsafe override void Initialize(BmSDK.BmGame.GDCharCustomizationManager CustomizationManager, int NumTeams)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialize, "BmScript.GDCharCustomizationPreview.Initialize");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationManager, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumTeams, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: m_CustomizationManager
    /// </summary>
    public unsafe BmSDK.BmGame.GDCharCustomizationManager m_CustomizationManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDCharCustomizationManager>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// IntProperty: m_NumTeams
    /// </summary>
    public unsafe int m_NumTeams
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// ArrayProperty: m_PreviewPawns
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDCinematicCustomizationActor> m_PreviewPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDCinematicCustomizationActor>>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// IntProperty: m_CurrentPreviewTeam
    /// </summary>
    public unsafe int m_CurrentPreviewTeam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }

    /// <summary>
    /// ArrayProperty: m_PreviewSelectedParts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.GDCharCustomizationPreview.FSCustomizationPreviewTeamData> m_PreviewSelectedParts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.GDCharCustomizationPreview.FSCustomizationPreviewTeamData>>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }

    /// <summary>
    /// ObjectProperty: PawnConfig
    /// </summary>
    public unsafe BmSDK.BmScript.GDPawnConfigInterface PawnConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.GDPawnConfigInterface>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// ByteProperty: PreviewWeaponSkinWeapon
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.WeaponId PreviewWeaponSkinWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.WeaponId>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// IntProperty: PreviewWeaponSkinIndex
    /// </summary>
    public unsafe int PreviewWeaponSkinIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// Struct: FSCustomizationPreviewTeamData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FSCustomizationPreviewTeamData
    {
        /// <summary>
        /// ArrayProperty: PartData
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmScript.GDCharCustomizationPreview.FSCustomizationPreviewTeamDataItem> PartData
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.GDCharCustomizationPreview.FSCustomizationPreviewTeamDataItem>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FSCustomizationPreviewTeamDataItem
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FSCustomizationPreviewTeamDataItem
    {
        /// <summary>
        /// IntProperty: PreviewPartIdx
        /// </summary>
        public unsafe int PreviewPartIdx
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: PreviewPartID
        /// </summary>
        public unsafe BmSDK.FName PreviewPartID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: PreviewPartSkinIndex
        /// </summary>
        public unsafe int PreviewPartSkinIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: PreviewPartColor
        /// </summary>
        public unsafe BmSDK.GameObject.FColor PreviewPartColor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }
}
