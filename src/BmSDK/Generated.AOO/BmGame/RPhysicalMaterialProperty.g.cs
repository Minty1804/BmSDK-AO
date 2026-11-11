#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPhysicalMaterialProperty<br/>
/// (size = 416)
/// (flags = 134262930)
/// </summary>
public partial class RPhysicalMaterialProperty : BmSDK.Engine.PhysicalMaterialPropertyBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPhysicalMaterialProperty", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPhysicalMaterialProperty.
    /// </summary>
    public static RPhysicalMaterialProperty DefaultObject => (RPhysicalMaterialProperty)StaticClass().DefaultObject;

    internal RPhysicalMaterialProperty() { }

    /// <summary>
    /// Constructs a new RPhysicalMaterialProperty
    /// </summary>
    public RPhysicalMaterialProperty(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPhysicalMaterialProperty Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPhysicalMaterialProperty(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPhysicalMaterialProperty>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPhysicalMaterialProperty>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPhysicalMaterialProperty>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPhysicalMaterialProperty>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPhysicalMaterialProperty>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPhysicalMaterialProperty>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPhysicalMaterialProperty>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPhysicalMaterialProperty>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SpawnActualHitEffect;
    /// <summary>
    /// Function: SpawnActualHitEffect
    /// </summary>
    public unsafe static void SpawnActualHitEffect(BmSDK.Engine.Actor.FImpactInfo Impact, BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo PhysImpactInfo, bool bPlaySound = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnActualHitEffect, "BmGame.RPhysicalMaterialProperty.SpawnActualHitEffect");
        byte* paramsPtr = stackalloc byte[164];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Impact, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PhysImpactInfo, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlaySound, paramsPtr + 136);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnHitEffect;
    /// <summary>
    /// Function: SpawnHitEffect
    /// </summary>
    public unsafe virtual void SpawnHitEffect(BmSDK.Engine.Actor.FImpactInfo Impact, BmSDK.FName ImpactType, bool bPlaySound = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnHitEffect, "BmGame.RPhysicalMaterialProperty.SpawnHitEffect");
        byte* paramsPtr = stackalloc byte[116];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Impact, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactType, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlaySound, paramsPtr + 96);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnHitDefaultEffect;
    /// <summary>
    /// Function: SpawnHitDefaultEffect
    /// </summary>
    public unsafe static void SpawnHitDefaultEffect(BmSDK.Engine.Actor.FImpactInfo Impact, BmSDK.FName ImpactType, bool bPlaySound = default)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnHitDefaultEffect, "BmGame.RPhysicalMaterialProperty.SpawnHitDefaultEffect");
        byte* paramsPtr = stackalloc byte[116];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Impact, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactType, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlaySound, paramsPtr + 96);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FImpactEffectInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial record struct FImpactEffectInfo
    {
        /// <summary>
        /// FloatProperty: AlertAINoise
        /// </summary>
        public unsafe float AlertAINoise
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: SoundEvent
        /// </summary>
        public unsafe BmSDK.Engine.AkEvent SoundEvent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ObjectProperty: ParticleEffect
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystem ParticleEffect
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: PawnParticleEffect
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystem PawnParticleEffect
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ArrayProperty: DecalMaterials
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInterface> DecalMaterials
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInterface>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: DurationOfDecal
        /// </summary>
        public unsafe float DurationOfDecal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// NameProperty: DecalDissolveParamName
        /// </summary>
        public unsafe BmSDK.FName DecalDissolveParamName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: DecalWidth
        /// </summary>
        public unsafe float DecalWidth
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// FloatProperty: DecalHeight
        /// </summary>
        public unsafe float DecalHeight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }
    }

    /// <summary>
    /// StructProperty: FootstepInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPhysicalMaterialProperty.FMaterialFootstepInfo FootstepInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPhysicalMaterialProperty.FMaterialFootstepInfo>(Ptr + 48);

    /// <summary>
    /// StructProperty: BatarangImpactInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo BatarangImpactInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo>(Ptr + 68);

    /// <summary>
    /// StructProperty: BulletImpactInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo BulletImpactInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo>(Ptr + 116);

    /// <summary>
    /// StructProperty: BulletHeavyImpactInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo BulletHeavyImpactInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo>(Ptr + 164);

    /// <summary>
    /// StructProperty: BulletNailGunImpactInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo BulletNailGunImpactInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo>(Ptr + 212);

    /// <summary>
    /// StructProperty: ExplosionImpactInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo ExplosionImpactInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo>(Ptr + 260);

    /// <summary>
    /// StructProperty: InvulnerablePlayerImpactInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo InvulnerablePlayerImpactInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo>(Ptr + 308);

    /// <summary>
    /// StructProperty: GrappleImpactInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo GrappleImpactInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPhysicalMaterialProperty.FImpactEffectInfo>(Ptr + 356);

    /// <summary>
    /// BoolProperty: IsSurfaceWet
    /// </summary>
    public unsafe bool IsSurfaceWet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 404) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 404); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 404); }
    }

    /// <summary>
    /// ObjectProperty: SurfaceTypePrimary
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName SurfaceTypePrimary
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// ObjectProperty: SurfaceTypeSecondary
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName SurfaceTypeSecondary
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// Struct: FMaterialFootstepInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FMaterialFootstepInfo
    {
        /// <summary>
        /// BoolProperty: bPlayParticleWhenWalking
        /// </summary>
        public unsafe bool bPlayParticleWhenWalking
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: ParticleEffect
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystem ParticleEffect
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ObjectProperty: HandStepParticleEffect
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystem HandStepParticleEffect
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: SlideParticleEffect
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystem SlideParticleEffect
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ObjectProperty: CrouchedParticleEffect
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystem CrouchedParticleEffect
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }
}
