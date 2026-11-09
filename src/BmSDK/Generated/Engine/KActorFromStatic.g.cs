#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: KActorFromStatic<br/>
/// (size = 736)
/// (flags = 142606490)
/// </summary>
public partial class KActorFromStatic : BmSDK.Engine.KActor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.KActorFromStatic", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as KActorFromStatic.
    /// </summary>
    public static KActorFromStatic DefaultObject => (KActorFromStatic)StaticClass().DefaultObject;

    internal KActorFromStatic() { }

    /// <summary>
    /// Constructs a new KActorFromStatic
    /// </summary>
    public KActorFromStatic(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected KActorFromStatic(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<KActorFromStatic>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<KActorFromStatic>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<KActorFromStatic>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<KActorFromStatic>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<KActorFromStatic>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<KActorFromStatic>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<KActorFromStatic>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<KActorFromStatic>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_TakeRadiusDamage;
    /// <summary>
    /// Function: TakeRadiusDamage
    /// </summary>
    public unsafe override void TakeRadiusDamage(BmSDK.Engine.Controller InstigatedBy, float BaseDamage, float DamageRadius, BmSDK.Class DamageType, float Momentum, System.Numerics.Vector3 HurtOrigin, bool bFullDamage, BmSDK.Engine.Actor DamageCauser, float DamageFalloffExponent = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeRadiusDamage, "Engine.KActorFromStatic.TakeRadiusDamage");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BaseDamage, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageRadius, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HurtOrigin, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFullDamage, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageFalloffExponent, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Touch;
    /// <summary>
    /// Function: Touch
    /// </summary>
    public unsafe override void Touch(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Touch, "Engine.KActorFromStatic.Touch");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Bump;
    /// <summary>
    /// Function: Bump
    /// </summary>
    public unsafe override void Bump(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Bump, "Engine.KActorFromStatic.Bump");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReceiveImpulse;
    /// <summary>
    /// Function: ReceiveImpulse
    /// </summary>
    public unsafe virtual void ReceiveImpulse(BmSDK.Engine.Pawn Other, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReceiveImpulse, "Engine.KActorFromStatic.ReceiveImpulse");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyImpulse;
    /// <summary>
    /// Function: ApplyImpulse
    /// </summary>
    public unsafe override void ApplyImpulse(System.Numerics.Vector3 ImpulseDir, float ImpulseMag, System.Numerics.Vector3 HitLocation, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Class DamageType = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyImpulse, "Engine.KActorFromStatic.ApplyImpulse");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpulseDir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpulseMag, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 64);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MakeDynamic;
    /// <summary>
    /// Function: MakeDynamic
    /// </summary>
    public unsafe static BmSDK.Engine.KActorFromStatic MakeDynamic(BmSDK.Engine.StaticMeshComponent MovableMesh)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakeDynamic, "Engine.KActorFromStatic.MakeDynamic");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovableMesh, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.KActorFromStatic>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_MakeStatic;
    /// <summary>
    /// Function: MakeStatic
    /// </summary>
    public unsafe static void MakeStatic()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakeStatic, "Engine.KActorFromStatic.MakeStatic");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_BecomeStatic;
    /// <summary>
    /// Function: BecomeStatic
    /// </summary>
    public unsafe virtual void BecomeStatic()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BecomeStatic, "Engine.KActorFromStatic.BecomeStatic");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnWakeRBPhysics;
    /// <summary>
    /// Function: OnWakeRBPhysics
    /// </summary>
    public unsafe override void OnWakeRBPhysics()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnWakeRBPhysics, "Engine.KActorFromStatic.OnWakeRBPhysics");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnSleepRBPhysics;
    /// <summary>
    /// Function: OnSleepRBPhysics
    /// </summary>
    public unsafe override void OnSleepRBPhysics()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnSleepRBPhysics, "Engine.KActorFromStatic.OnSleepRBPhysics");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisablePrecomputedLighting;
    /// <summary>
    /// Function: DisablePrecomputedLighting
    /// </summary>
    public unsafe virtual void DisablePrecomputedLighting()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisablePrecomputedLighting, "Engine.KActorFromStatic.DisablePrecomputedLighting");
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

    /// <summary>
    /// ObjectProperty: MyStaticMeshActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor MyStaticMeshActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// FloatProperty: MaxImpulseSpeed
    /// </summary>
    public unsafe float MaxImpulseSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }
}

/// <summary>
/// The static native functions of KActorFromStatic, callable on an instance. A static native may read the object it runs on, and the static form runs it on the class default object, which has no world.
/// </summary>
public static class KActorFromStaticStatics
{
    private static BmSDK.Function __fn_MakeDynamic;
    /// <summary>
    /// Function: MakeDynamic, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static BmSDK.Engine.KActorFromStatic MakeDynamic(this BmSDK.Engine.KActorFromStatic self, BmSDK.Engine.StaticMeshComponent MovableMesh)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakeDynamic, "Engine.KActorFromStatic.MakeDynamic");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovableMesh, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.KActorFromStatic>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_MakeStatic;
    /// <summary>
    /// Function: MakeStatic, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void MakeStatic(this BmSDK.Engine.KActorFromStatic self)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakeStatic, "Engine.KActorFromStatic.MakeStatic");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
}
