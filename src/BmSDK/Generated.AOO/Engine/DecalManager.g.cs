#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DecalManager<br/>
/// (size = 512)
/// (flags = 142639254)
/// </summary>
public partial class DecalManager : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DecalManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as DecalManager.
    /// </summary>
    public static DecalManager DefaultObject => (DecalManager)StaticClass().DefaultObject;

    internal DecalManager() { }

    /// <summary>
    /// Constructs a new DecalManager
    /// </summary>
    public DecalManager(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DecalManager(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<DecalManager>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<DecalManager>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<DecalManager>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<DecalManager>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<DecalManager>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<DecalManager>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<DecalManager>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<DecalManager>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SpawnDecal;
    /// <summary>
    /// Function: SpawnDecal
    /// </summary>
    public unsafe virtual BmSDK.Engine.DecalComponent SpawnDecal(BmSDK.Engine.MaterialInterface DecalMaterial, System.Numerics.Vector3 DecalLocation, BmSDK.Rotator DecalOrientation, float Width, float Height, float Thickness, bool bNoClip, float DecalRotation = default, BmSDK.Engine.PrimitiveComponent HitComponent = default, bool bProjectOnTerrain = default, bool bProjectOnSkeletalMeshes = default, BmSDK.FName HitBone = default, int HitNodeIndex = default, int HitLevelIndex = default, float InDecalLifeSpan = default, int InFracturedStaticMeshComponentIndex = default, float InDepthBias = default, System.Numerics.Vector2 InBlendRange = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnDecal, "Engine.DecalManager.SpawnDecal");
        byte* paramsPtr = stackalloc byte[132];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalMaterial, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalOrientation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Width, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Height, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thickness, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoClip, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalRotation, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitComponent, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bProjectOnTerrain, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bProjectOnSkeletalMeshes, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitBone, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNodeIndex, paramsPtr + 68);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLevelIndex, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InDecalLifeSpan, paramsPtr + 76);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InFracturedStaticMeshComponentIndex, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InDepthBias, paramsPtr + 84);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InBlendRange, paramsPtr + 88);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.DecalComponent>(paramsPtr + 96);
    }

    private static BmSDK.Function __fn_GetPooledComponent;
    /// <summary>
    /// Function: GetPooledComponent
    /// </summary>
    public unsafe virtual BmSDK.Engine.DecalComponent GetPooledComponent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPooledComponent, "Engine.DecalManager.GetPooledComponent");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.DecalComponent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetDecalParameters;
    /// <summary>
    /// Function: SetDecalParameters
    /// </summary>
    public unsafe static void SetDecalParameters(BmSDK.Engine.DecalComponent TheDecal, BmSDK.Engine.MaterialInterface DecalMaterial, System.Numerics.Vector3 DecalLocation, BmSDK.Rotator DecalOrientation, float Width, float Height, float Thickness, bool bNoClip, float DecalRotation, BmSDK.Engine.PrimitiveComponent HitComponent, bool bProjectOnTerrain, bool bProjectOnSkeletalMeshes, BmSDK.FName HitBone, int HitNodeIndex, int HitLevelIndex, int InFracturedStaticMeshComponentIndex, float DepthBias, System.Numerics.Vector2 BlendRange)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDecalParameters, "Engine.DecalManager.SetDecalParameters");
        byte* paramsPtr = stackalloc byte[112];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheDecal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalMaterial, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalOrientation, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Width, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Height, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thickness, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoClip, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalRotation, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitComponent, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bProjectOnTerrain, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bProjectOnSkeletalMeshes, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitBone, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNodeIndex, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLevelIndex, paramsPtr + 76);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InFracturedStaticMeshComponentIndex, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DepthBias, paramsPtr + 84);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendRange, paramsPtr + 88);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_DecalFinished;
    /// <summary>
    /// Function: DecalFinished
    /// </summary>
    public unsafe virtual void DecalFinished(BmSDK.Engine.DecalComponent Decal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DecalFinished, "Engine.DecalManager.DecalFinished");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Decal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AreDynamicDecalsEnabled;
    /// <summary>
    /// Function: AreDynamicDecalsEnabled
    /// </summary>
    public unsafe static bool AreDynamicDecalsEnabled()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreDynamicDecalsEnabled, "Engine.DecalManager.AreDynamicDecalsEnabled");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Struct: FActiveDecalInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FActiveDecalInfo
    {
        /// <summary>
        /// ComponentProperty: Decal
        /// </summary>
        public unsafe BmSDK.Engine.DecalComponent Decal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DecalComponent>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: LifetimeRemaining
        /// </summary>
        public unsafe float LifetimeRemaining
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: Attached
        /// </summary>
        public unsafe bool Attached
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// ComponentProperty: DecalTemplate
    /// </summary>
    public unsafe BmSDK.Engine.DecalComponent DecalTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DecalComponent>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// ArrayProperty: PoolDecals
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.DecalComponent> PoolDecals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.DecalComponent>>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// IntProperty: MaxActiveDecals
    /// </summary>
    public unsafe int MaxActiveDecals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// FloatProperty: DecalLifeSpan
    /// </summary>
    public unsafe float DecalLifeSpan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// FloatProperty: DecalDepthBias
    /// </summary>
    public unsafe float DecalDepthBias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// StructProperty: DecalBlendRange
    /// </summary>
    public unsafe ref System.Numerics.Vector2 DecalBlendRange
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector2>(Ptr + 492);

    /// <summary>
    /// ArrayProperty: ActiveDecals
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.DecalManager.FActiveDecalInfo> ActiveDecals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.DecalManager.FActiveDecalInfo>>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }
}

/// <summary>
/// The static native functions of DecalManager, callable on an instance. A static native may read the object it runs on, and the static form runs it on the class default object, which has no world.
/// </summary>
public static class DecalManagerStatics
{
    private static BmSDK.Function __fn_SetDecalParameters;
    /// <summary>
    /// Function: SetDecalParameters, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void SetDecalParameters(this BmSDK.Engine.DecalManager self, BmSDK.Engine.DecalComponent TheDecal, BmSDK.Engine.MaterialInterface DecalMaterial, System.Numerics.Vector3 DecalLocation, BmSDK.Rotator DecalOrientation, float Width, float Height, float Thickness, bool bNoClip, float DecalRotation, BmSDK.Engine.PrimitiveComponent HitComponent, bool bProjectOnTerrain, bool bProjectOnSkeletalMeshes, BmSDK.FName HitBone, int HitNodeIndex, int HitLevelIndex, int InFracturedStaticMeshComponentIndex, float DepthBias, System.Numerics.Vector2 BlendRange)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDecalParameters, "Engine.DecalManager.SetDecalParameters");
        byte* paramsPtr = stackalloc byte[112];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheDecal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalMaterial, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalOrientation, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Width, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Height, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thickness, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoClip, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalRotation, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitComponent, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bProjectOnTerrain, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bProjectOnSkeletalMeshes, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitBone, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNodeIndex, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLevelIndex, paramsPtr + 76);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InFracturedStaticMeshComponentIndex, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DepthBias, paramsPtr + 84);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendRange, paramsPtr + 88);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    private static BmSDK.Function __fn_AreDynamicDecalsEnabled;
    /// <summary>
    /// Function: AreDynamicDecalsEnabled, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static bool AreDynamicDecalsEnabled(this BmSDK.Engine.DecalManager self)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AreDynamicDecalsEnabled, "Engine.DecalManager.AreDynamicDecalsEnabled");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }
}
