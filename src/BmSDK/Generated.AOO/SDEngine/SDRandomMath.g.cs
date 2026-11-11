#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.SDEngine;

/// <summary>
/// Class: SDRandomMath<br/>
/// (size = 48)
/// (flags = 134250650)
/// </summary>
public partial class SDRandomMath : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "SDEngine.SDRandomMath", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as SDRandomMath.
    /// </summary>
    public static SDRandomMath DefaultObject => (SDRandomMath)StaticClass().DefaultObject;

    internal SDRandomMath() { }

    /// <summary>
    /// Constructs a new SDRandomMath
    /// </summary>
    public SDRandomMath(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SDRandomMath Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SDRandomMath(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDRandomMath>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDRandomMath>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDRandomMath>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDRandomMath>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDRandomMath>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDRandomMath>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDRandomMath>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDRandomMath>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_RandomVectorInConeFromSeed;
    /// <summary>
    /// Function: RandomVectorInConeFromSeed
    /// </summary>
    public unsafe static System.Numerics.Vector3 RandomVectorInConeFromSeed(out BmSDK.SDEngine.SDRandomMath.FSDRandom Random, out System.Numerics.Vector3 Dir, float ConeHalfAngleRad)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RandomVectorInConeFromSeed, "SDEngine.SDRandomMath.RandomVectorInConeFromSeed");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Random);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Random, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Dir);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dir, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConeHalfAngleRad, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Random = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.SDEngine.SDRandomMath.FSDRandom>(paramsPtr + 0);
        Dir = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_SetSeed;
    /// <summary>
    /// Function: SetSeed
    /// </summary>
    public unsafe static void SetSeed(out BmSDK.SDEngine.SDRandomMath.FSDRandom Random, out int Seed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSeed, "SDEngine.SDRandomMath.SetSeed");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Random);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Random, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Seed);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Seed, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Random = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.SDEngine.SDRandomMath.FSDRandom>(paramsPtr + 0);
        Seed = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_InPlaceShuffle;
    /// <summary>
    /// Function: InPlaceShuffle
    /// </summary>
    public unsafe static void InPlaceShuffle(out BmSDK.TArray<int> Array, out int Seed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InPlaceShuffle, "SDEngine.SDRandomMath.InPlaceShuffle");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Seed);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Seed, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Array = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<int>>(paramsPtr + 0);
        Seed = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_RandomIntFromSeed;
    /// <summary>
    /// Function: RandomIntFromSeed
    /// </summary>
    public unsafe static int RandomIntFromSeed(out int Seed, int MaxValueNonInclusive)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RandomIntFromSeed, "SDEngine.SDRandomMath.RandomIntFromSeed");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Seed);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Seed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxValueNonInclusive, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Seed = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_RandomFloatFromSeed;
    /// <summary>
    /// Function: RandomFloatFromSeed
    /// </summary>
    public unsafe static float RandomFloatFromSeed(out int Seed)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RandomFloatFromSeed, "SDEngine.SDRandomMath.RandomFloatFromSeed");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Seed);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Seed, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Seed = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_RandomInt;
    /// <summary>
    /// Function: RandomInt
    /// </summary>
    public unsafe static int RandomInt(BmSDK.SDEngine.SDRandomMath.FSDRandom Random, int MaxValueNonInclusive)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RandomInt, "SDEngine.SDRandomMath.RandomInt");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Random, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxValueNonInclusive, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_RandomFloat;
    /// <summary>
    /// Function: RandomFloat
    /// </summary>
    public unsafe static float RandomFloat(BmSDK.SDEngine.SDRandomMath.FSDRandom Random)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RandomFloat, "SDEngine.SDRandomMath.RandomFloat");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Random, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    /// <summary>
    /// Struct: FSDRandom
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial record struct FSDRandom
    {
        /// <summary>
        /// IntProperty: m_Seed
        /// </summary>
        public unsafe int m_Seed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }
}

/// <summary>
/// The static native functions of SDRandomMath, callable on an instance. A static native may read the object it runs on, and the static form runs it on the class default object, which has no world.
/// </summary>
public static class SDRandomMathStatics
{
    private static BmSDK.Function __fn_RandomVectorInConeFromSeed;
    /// <summary>
    /// Function: RandomVectorInConeFromSeed, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static System.Numerics.Vector3 RandomVectorInConeFromSeed(this BmSDK.SDEngine.SDRandomMath self, out BmSDK.SDEngine.SDRandomMath.FSDRandom Random, out System.Numerics.Vector3 Dir, float ConeHalfAngleRad)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RandomVectorInConeFromSeed, "SDEngine.SDRandomMath.RandomVectorInConeFromSeed");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Random);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Random, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Dir);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dir, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConeHalfAngleRad, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Random = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.SDEngine.SDRandomMath.FSDRandom>(paramsPtr + 0);
        Dir = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_SetSeed;
    /// <summary>
    /// Function: SetSeed, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void SetSeed(this BmSDK.SDEngine.SDRandomMath self, out BmSDK.SDEngine.SDRandomMath.FSDRandom Random, out int Seed)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSeed, "SDEngine.SDRandomMath.SetSeed");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Random);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Random, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Seed);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Seed, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Random = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.SDEngine.SDRandomMath.FSDRandom>(paramsPtr + 0);
        Seed = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_InPlaceShuffle;
    /// <summary>
    /// Function: InPlaceShuffle, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static void InPlaceShuffle(this BmSDK.SDEngine.SDRandomMath self, out BmSDK.TArray<int> Array, out int Seed)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InPlaceShuffle, "SDEngine.SDRandomMath.InPlaceShuffle");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Seed);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Seed, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Array = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<int>>(paramsPtr + 0);
        Seed = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_RandomIntFromSeed;
    /// <summary>
    /// Function: RandomIntFromSeed, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static int RandomIntFromSeed(this BmSDK.SDEngine.SDRandomMath self, out int Seed, int MaxValueNonInclusive)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RandomIntFromSeed, "SDEngine.SDRandomMath.RandomIntFromSeed");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Seed);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Seed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxValueNonInclusive, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Seed = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_RandomFloatFromSeed;
    /// <summary>
    /// Function: RandomFloatFromSeed, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static float RandomFloatFromSeed(this BmSDK.SDEngine.SDRandomMath self, out int Seed)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RandomFloatFromSeed, "SDEngine.SDRandomMath.RandomFloatFromSeed");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Seed);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Seed, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Seed = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_RandomInt;
    /// <summary>
    /// Function: RandomInt, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static int RandomInt(this BmSDK.SDEngine.SDRandomMath self, BmSDK.SDEngine.SDRandomMath.FSDRandom Random, int MaxValueNonInclusive)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RandomInt, "SDEngine.SDRandomMath.RandomInt");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Random, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxValueNonInclusive, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_RandomFloat;
    /// <summary>
    /// Function: RandomFloat, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static float RandomFloat(this BmSDK.SDEngine.SDRandomMath self, BmSDK.SDEngine.SDRandomMath.FSDRandom Random)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RandomFloat, "SDEngine.SDRandomMath.RandomFloat");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Random, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }
}
