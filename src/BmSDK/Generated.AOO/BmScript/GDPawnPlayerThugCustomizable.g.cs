#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: GDPawnPlayerThugCustomizable<br/>
/// (size = 7760)
/// (flags = 10518582)
/// </summary>
public partial class GDPawnPlayerThugCustomizable : BmSDK.BmScript.GDPawnPlayerThug, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.GDPawnPlayerThugCustomizable", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDPawnPlayerThugCustomizable.
    /// </summary>
    public static GDPawnPlayerThugCustomizable DefaultObject => (GDPawnPlayerThugCustomizable)StaticClass().DefaultObject;

    internal GDPawnPlayerThugCustomizable() { }

    /// <summary>
    /// Constructs a new GDPawnPlayerThugCustomizable
    /// </summary>
    public GDPawnPlayerThugCustomizable(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDPawnPlayerThugCustomizable(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerThugCustomizable>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerThugCustomizable>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerThugCustomizable>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerThugCustomizable>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerThugCustomizable>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerThugCustomizable>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerThugCustomizable>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDPawnPlayerThugCustomizable>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ExitXRayMode;
    /// <summary>
    /// Function: ExitXRayMode
    /// </summary>
    public unsafe override void ExitXRayMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitXRayMode, "BmScript.GDPawnPlayerThugCustomizable.ExitXRayMode");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RestoreDefaultXRayMICToMeshes;
    /// <summary>
    /// Function: RestoreDefaultXRayMICToMeshes
    /// </summary>
    public unsafe override void RestoreDefaultXRayMICToMeshes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestoreDefaultXRayMICToMeshes, "BmScript.GDPawnPlayerThugCustomizable.RestoreDefaultXRayMICToMeshes");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyXRayMICToMeshes;
    /// <summary>
    /// Function: ApplyXRayMICToMeshes
    /// </summary>
    public unsafe override void ApplyXRayMICToMeshes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyXRayMICToMeshes, "BmScript.GDPawnPlayerThugCustomizable.ApplyXRayMICToMeshes");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyXRayParameters;
    /// <summary>
    /// Function: ApplyXRayParameters
    /// </summary>
    public unsafe override void ApplyXRayParameters(BmSDK.BmGame.GDXRayParameters Params)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyXRayParameters, "BmScript.GDPawnPlayerThugCustomizable.ApplyXRayParameters");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Params, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResumeExpensivePhysicsThings;
    /// <summary>
    /// Function: ResumeExpensivePhysicsThings
    /// </summary>
    public unsafe override void ResumeExpensivePhysicsThings()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResumeExpensivePhysicsThings, "BmScript.GDPawnPlayerThugCustomizable.ResumeExpensivePhysicsThings");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PauseExpensivePhysicsThings;
    /// <summary>
    /// Function: PauseExpensivePhysicsThings
    /// </summary>
    public unsafe override void PauseExpensivePhysicsThings()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PauseExpensivePhysicsThings, "BmScript.GDPawnPlayerThugCustomizable.PauseExpensivePhysicsThings");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyUndershirt;
    /// <summary>
    /// Function: ApplyUndershirt
    /// </summary>
    public unsafe virtual void ApplyUndershirt(in BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection LoadedSelection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyUndershirt, "BmScript.GDPawnPlayerThugCustomizable.ApplyUndershirt");
        byte* paramsPtr = stackalloc byte[224];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelection, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyTattoo;
    /// <summary>
    /// Function: ApplyTattoo
    /// </summary>
    public unsafe virtual void ApplyTattoo(in BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection LoadedSelection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyTattoo, "BmScript.GDPawnPlayerThugCustomizable.ApplyTattoo");
        byte* paramsPtr = stackalloc byte[224];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelection, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyFacepaint;
    /// <summary>
    /// Function: ApplyFacepaint
    /// </summary>
    public unsafe virtual void ApplyFacepaint(in BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection LoadedSelection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyFacepaint, "BmScript.GDPawnPlayerThugCustomizable.ApplyFacepaint");
        byte* paramsPtr = stackalloc byte[224];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelection, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyHair;
    /// <summary>
    /// Function: ApplyHair
    /// </summary>
    public unsafe virtual void ApplyHair(in BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection LoadedSelection, bool EnablePhysicsAssets)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyHair, "BmScript.GDPawnPlayerThugCustomizable.ApplyHair");
        byte* paramsPtr = stackalloc byte[228];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnablePhysicsAssets, paramsPtr + 208);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyFacialHair;
    /// <summary>
    /// Function: ApplyFacialHair
    /// </summary>
    public unsafe virtual void ApplyFacialHair(in BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection LoadedSelection, bool EnablePhysicsAssets)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyFacialHair, "BmScript.GDPawnPlayerThugCustomizable.ApplyFacialHair");
        byte* paramsPtr = stackalloc byte[228];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnablePhysicsAssets, paramsPtr + 208);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyFaceGear;
    /// <summary>
    /// Function: ApplyFaceGear
    /// </summary>
    public unsafe virtual void ApplyFaceGear(in BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection LoadedSelection, bool EnablePhysicsAssets)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyFaceGear, "BmScript.GDPawnPlayerThugCustomizable.ApplyFaceGear");
        byte* paramsPtr = stackalloc byte[228];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnablePhysicsAssets, paramsPtr + 208);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyUpper;
    /// <summary>
    /// Function: ApplyUpper
    /// </summary>
    public unsafe virtual void ApplyUpper(in BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection LoadedSelection, bool EnablePhysicsAssets)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyUpper, "BmScript.GDPawnPlayerThugCustomizable.ApplyUpper");
        byte* paramsPtr = stackalloc byte[228];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnablePhysicsAssets, paramsPtr + 208);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyLower;
    /// <summary>
    /// Function: ApplyLower
    /// </summary>
    public unsafe virtual void ApplyLower(in BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection LoadedSelection, bool EnablePhysicsAssets)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyLower, "BmScript.GDPawnPlayerThugCustomizable.ApplyLower");
        byte* paramsPtr = stackalloc byte[228];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnablePhysicsAssets, paramsPtr + 208);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyArchetype;
    /// <summary>
    /// Function: ApplyArchetype
    /// </summary>
    public unsafe virtual void ApplyArchetype(in BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection LoadedSelection, bool EnablePhysicsAssets)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyArchetype, "BmScript.GDPawnPlayerThugCustomizable.ApplyArchetype");
        byte* paramsPtr = stackalloc byte[228];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnablePhysicsAssets, paramsPtr + 208);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyCustomization;
    /// <summary>
    /// Function: ApplyCustomization
    /// </summary>
    public unsafe virtual void ApplyCustomization(in BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection LoadedSelection, bool InPlay, BmSDK.BmGame.GDCharCustomizationManager CustomizationManager)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyCustomization, "BmScript.GDPawnPlayerThugCustomizable.ApplyCustomization");
        byte* paramsPtr = stackalloc byte[280];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPlay, paramsPtr + 208);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomizationManager, paramsPtr + 212);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyCustomizedMeshData;
    /// <summary>
    /// Function: ApplyCustomizedMeshData
    /// </summary>
    public unsafe virtual bool ApplyCustomizedMeshData(int customizationSelectionID, bool InPlay)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyCustomizedMeshData, "BmScript.GDPawnPlayerThugCustomizable.ApplyCustomizedMeshData");
        byte* paramsPtr = stackalloc byte[240];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(customizationSelectionID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPlay, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetupDebugPlayerMesh;
    /// <summary>
    /// Function: SetupDebugPlayerMesh
    /// </summary>
    public unsafe virtual bool SetupDebugPlayerMesh(bool InPlay, int CustomTeamIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupDebugPlayerMesh, "BmScript.GDPawnPlayerThugCustomizable.SetupDebugPlayerMesh");
        byte* paramsPtr = stackalloc byte[136];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPlay, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTeamIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_InternalSetupPlayerMesh;
    /// <summary>
    /// Function: InternalSetupPlayerMesh
    /// </summary>
    public unsafe virtual bool InternalSetupPlayerMesh(BmSDK.BmGame.RPlayerRI RPlayerRI, out BmSDK.BmGame.RAddContentPlayerCharacter PlayerData, out BmSDK.BmGame.RAddContentPlayerCharacterMesh MeshData, bool InPlay)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InternalSetupPlayerMesh, "BmScript.GDPawnPlayerThugCustomizable.InternalSetupPlayerMesh");
        byte* paramsPtr = stackalloc byte[140];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPlayerRI, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PlayerData);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerData, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MeshData);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeshData, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPlay, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PlayerData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAddContentPlayerCharacter>(paramsPtr + 4);
        MeshData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAddContentPlayerCharacterMesh>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_SetupPlayerMesh;
    /// <summary>
    /// Function: SetupPlayerMesh
    /// </summary>
    public unsafe override bool SetupPlayerMesh(bool InPlay)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupPlayerMesh, "BmScript.GDPawnPlayerThugCustomizable.SetupPlayerMesh");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_Died;
    /// <summary>
    /// Function: Died
    /// </summary>
    public unsafe override bool Died(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Died, "BmScript.GDPawnPlayerThugCustomizable.Died");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmScript.GDPawnPlayerThugCustomizable.Destroyed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ComponentProperty: HairMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent HairMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7728); }
    }

    /// <summary>
    /// ComponentProperty: FaceGearMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent FaceGearMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7732); }
    }

    /// <summary>
    /// ComponentProperty: FacialHairMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent FacialHairMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 7736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7736); }
    }

    /// <summary>
    /// IntProperty: LoadedCustomizationSelectionID
    /// </summary>
    public unsafe int LoadedCustomizationSelectionID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7740); }
    }

    /// <summary>
    /// BoolProperty: m_CustomPartsOwner
    /// </summary>
    public unsafe bool m_CustomPartsOwner
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7744) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7744); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7744); }
    }

    /// <summary>
    /// ArrayProperty: FlappySkelComps
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent> FlappySkelComps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent>>(Ptr + 7748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7748); }
    }
}
