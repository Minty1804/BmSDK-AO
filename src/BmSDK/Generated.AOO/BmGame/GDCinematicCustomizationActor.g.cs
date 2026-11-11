#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDCinematicCustomizationActor<br/>
/// (size = 628)
/// (flags = 142639762)
/// </summary>
public partial class GDCinematicCustomizationActor : BmSDK.BmGame.RCinematicActor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDCinematicCustomizationActor", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDCinematicCustomizationActor.
    /// </summary>
    public static GDCinematicCustomizationActor DefaultObject => (GDCinematicCustomizationActor)StaticClass().DefaultObject;

    internal GDCinematicCustomizationActor() { }

    /// <summary>
    /// Constructs a new GDCinematicCustomizationActor
    /// </summary>
    public GDCinematicCustomizationActor(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDCinematicCustomizationActor(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDCinematicCustomizationActor>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDCinematicCustomizationActor>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDCinematicCustomizationActor>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDCinematicCustomizationActor>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDCinematicCustomizationActor>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDCinematicCustomizationActor>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDCinematicCustomizationActor>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDCinematicCustomizationActor>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ApplyUndershirt;
    /// <summary>
    /// Function: ApplyUndershirt
    /// </summary>
    public unsafe virtual void ApplyUndershirt(in BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection LoadedSelection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyUndershirt, "BmGame.GDCinematicCustomizationActor.ApplyUndershirt");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyTattoo, "BmGame.GDCinematicCustomizationActor.ApplyTattoo");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyFacepaint, "BmGame.GDCinematicCustomizationActor.ApplyFacepaint");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyHair, "BmGame.GDCinematicCustomizationActor.ApplyHair");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyFacialHair, "BmGame.GDCinematicCustomizationActor.ApplyFacialHair");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyFaceGear, "BmGame.GDCinematicCustomizationActor.ApplyFaceGear");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyUpper, "BmGame.GDCinematicCustomizationActor.ApplyUpper");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyLower, "BmGame.GDCinematicCustomizationActor.ApplyLower");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyArchetype, "BmGame.GDCinematicCustomizationActor.ApplyArchetype");
        byte* paramsPtr = stackalloc byte[228];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnablePhysicsAssets, paramsPtr + 208);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetComponent;
    /// <summary>
    /// Function: ResetComponent
    /// </summary>
    public unsafe virtual void ResetComponent(BmSDK.Engine.SkeletalMeshComponent ComponentToReset)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetComponent, "BmGame.GDCinematicCustomizationActor.ResetComponent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComponentToReset, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyCustomization;
    /// <summary>
    /// Function: ApplyCustomization
    /// </summary>
    public unsafe virtual void ApplyCustomization(in BmSDK.BmGame.GDCharCustomizationManager.FSCharCustomization_LoadedSelection LoadedSelection, bool InPlay)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyCustomization, "BmGame.GDCinematicCustomizationActor.ApplyCustomization");
        byte* paramsPtr = stackalloc byte[228];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadedSelection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPlay, paramsPtr + 208);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceNetRelevant;
    /// <summary>
    /// Function: ForceNetRelevant
    /// </summary>
    public unsafe override void ForceNetRelevant()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceNetRelevant, "BmGame.GDCinematicCustomizationActor.ForceNetRelevant");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ComponentProperty: ExtraSkeletalMeshComponent3
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent ExtraSkeletalMeshComponent3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// ComponentProperty: ExtraSkeletalMeshComponent4
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent ExtraSkeletalMeshComponent4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// ComponentProperty: ExtraSkeletalMeshComponent5
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent ExtraSkeletalMeshComponent5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }
}
