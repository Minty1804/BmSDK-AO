#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MPawnVillain_FundamentalFreezeGadget<br/>
/// (size = 132)
/// (flags = 8388626)
/// </summary>
public partial class MPawnVillain_FundamentalFreezeGadget : BmSDK.BmGame.MPawnVillain_FundamentalGrenadeGadget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MPawnVillain_FundamentalFreezeGadget", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MPawnVillain_FundamentalFreezeGadget.
    /// </summary>
    public static MPawnVillain_FundamentalFreezeGadget DefaultObject => (MPawnVillain_FundamentalFreezeGadget)StaticClass().DefaultObject;

    internal MPawnVillain_FundamentalFreezeGadget() { }

    /// <summary>
    /// Constructs a new MPawnVillain_FundamentalFreezeGadget
    /// </summary>
    public MPawnVillain_FundamentalFreezeGadget(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MPawnVillain_FundamentalFreezeGadget Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MPawnVillain_FundamentalFreezeGadget(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillain_FundamentalFreezeGadget>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillain_FundamentalFreezeGadget>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillain_FundamentalFreezeGadget>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillain_FundamentalFreezeGadget>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillain_FundamentalFreezeGadget>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillain_FundamentalFreezeGadget>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnVillain_FundamentalFreezeGadget>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnVillain_FundamentalFreezeGadget>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_StopTorsoEffect;
    /// <summary>
    /// Function: StopTorsoEffect
    /// </summary>
    public unsafe override void StopTorsoEffect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopTorsoEffect, "BmGame.MPawnVillain_FundamentalFreezeGadget.StopTorsoEffect");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartTorsoEffect;
    /// <summary>
    /// Function: StartTorsoEffect
    /// </summary>
    public unsafe override void StartTorsoEffect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartTorsoEffect, "BmGame.MPawnVillain_FundamentalFreezeGadget.StartTorsoEffect");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopLegEffect;
    /// <summary>
    /// Function: StopLegEffect
    /// </summary>
    public unsafe override void StopLegEffect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopLegEffect, "BmGame.MPawnVillain_FundamentalFreezeGadget.StopLegEffect");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopRightLegEffectInternal;
    /// <summary>
    /// Function: StopRightLegEffectInternal
    /// </summary>
    public unsafe void StopRightLegEffectInternal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopRightLegEffectInternal, "BmGame.MPawnVillain_FundamentalFreezeGadget.StopRightLegEffectInternal");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopLeftLegEffectInternal;
    /// <summary>
    /// Function: StopLeftLegEffectInternal
    /// </summary>
    public unsafe void StopLeftLegEffectInternal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopLeftLegEffectInternal, "BmGame.MPawnVillain_FundamentalFreezeGadget.StopLeftLegEffectInternal");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopEffectInternal_Helper;
    /// <summary>
    /// Function: StopEffectInternal_Helper
    /// </summary>
    public unsafe bool StopEffectInternal_Helper(BmSDK.FName BoneName, bool bPlayedBreakout, BmSDK.Engine.ParticleSystemComponent ParticleComponent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopEffectInternal_Helper, "BmGame.MPawnVillain_FundamentalFreezeGadget.StopEffectInternal_Helper");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayedBreakout, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParticleComponent, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_StopLeftLegEffect;
    /// <summary>
    /// Function: StopLeftLegEffect
    /// </summary>
    public unsafe override void StopLeftLegEffect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopLeftLegEffect, "BmGame.MPawnVillain_FundamentalFreezeGadget.StopLeftLegEffect");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopRightLegEffect;
    /// <summary>
    /// Function: StopRightLegEffect
    /// </summary>
    public unsafe override void StopRightLegEffect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopRightLegEffect, "BmGame.MPawnVillain_FundamentalFreezeGadget.StopRightLegEffect");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartLegEffect;
    /// <summary>
    /// Function: StartLegEffect
    /// </summary>
    public unsafe override void StartLegEffect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartLegEffect, "BmGame.MPawnVillain_FundamentalFreezeGadget.StartLegEffect");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeactivateEffects;
    /// <summary>
    /// Function: DeactivateEffects
    /// </summary>
    public unsafe override void DeactivateEffects(bool bDeactivateTorsoEffects)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeactivateEffects, "BmGame.MPawnVillain_FundamentalFreezeGadget.DeactivateEffects");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDeactivateTorsoEffects, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateHitReactionWeaponConfig;
    /// <summary>
    /// Function: CreateHitReactionWeaponConfig
    /// </summary>
    public unsafe override void CreateHitReactionWeaponConfig(BmSDK.BmGame.RPoseConfig PoseConfig, BmSDK.GameObject NewOwner, BmSDK.FName CombatMovementStance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateHitReactionWeaponConfig, "BmGame.MPawnVillain_FundamentalFreezeGadget.CreateHitReactionWeaponConfig");
        byte* paramsPtr = stackalloc byte[848];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PoseConfig, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatMovementStance, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// NameProperty: TorsoBoneName
    /// </summary>
    public unsafe BmSDK.FName TorsoBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// ObjectProperty: TorseParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem TorseParticleSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ObjectProperty: LegParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem LegParticleSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ObjectProperty: ExplodeEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ExplodeEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ComponentProperty: TorsoParticle
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent TorsoParticle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ComponentProperty: LeftLegParticle
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent LeftLegParticle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// ComponentProperty: RightLegParticle
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent RightLegParticle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// NameProperty: UsedTorsoBoneName
    /// </summary>
    public unsafe BmSDK.FName UsedTorsoBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// ObjectProperty: Sphere
    /// </summary>
    public unsafe BmSDK.Engine.Actor Sphere
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }
}
