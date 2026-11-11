#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AITree_DMC_Base<br/>
/// (size = 48)
/// (flags = 134250642)
/// </summary>
public partial class AITree_DMC_Base : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AITree_DMC_Base", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as AITree_DMC_Base.
    /// </summary>
    public static AITree_DMC_Base DefaultObject => (AITree_DMC_Base)StaticClass().DefaultObject;

    internal AITree_DMC_Base() { }

    /// <summary>
    /// Constructs a new AITree_DMC_Base
    /// </summary>
    public AITree_DMC_Base(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AITree_DMC_Base Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AITree_DMC_Base(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AITree_DMC_Base>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AITree_DMC_Base>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AITree_DMC_Base>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AITree_DMC_Base>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AITree_DMC_Base>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AITree_DMC_Base>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AITree_DMC_Base>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AITree_DMC_Base>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CalculateUtilityRating;
    /// <summary>
    /// Function: CalculateUtilityRating
    /// </summary>
    public unsafe virtual void CalculateUtilityRating(BmSDK.Engine.AICommandNodeBase CommandNode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateUtilityRating, "Engine.AITree_DMC_Base.CalculateUtilityRating");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CommandNode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BreakRot;
    /// <summary>
    /// Function: BreakRot
    /// </summary>
    public unsafe static void BreakRot(BmSDK.Rotator InRot, out float Pitch, out float Yaw, out float Roll)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BreakRot, "Engine.AITree_DMC_Base.BreakRot");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InRot, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Pitch);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pitch, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Yaw);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Yaw, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Roll);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Roll, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Pitch = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
        Yaw = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
        Roll = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 20);
        return;
    }

    private static BmSDK.Function __fn_MakeRot;
    /// <summary>
    /// Function: MakeRot
    /// </summary>
    public unsafe static BmSDK.Rotator MakeRot(float Pitch, float Yaw, float Roll)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakeRot, "Engine.AITree_DMC_Base.MakeRot");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pitch, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Yaw, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Roll, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_BreakVector;
    /// <summary>
    /// Function: BreakVector
    /// </summary>
    public unsafe static void BreakVector(System.Numerics.Vector3 InVec, out float X, out float Y, out float Z)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BreakVector, "Engine.AITree_DMC_Base.BreakVector");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InVec, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out X);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Y);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Z);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Z, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        X = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
        Y = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
        Z = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 20);
        return;
    }

    private static BmSDK.Function __fn_MakeVector;
    /// <summary>
    /// Function: MakeVector
    /// </summary>
    public unsafe static System.Numerics.Vector3 MakeVector(float X, float Y, float Z)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakeVector, "Engine.AITree_DMC_Base.MakeVector");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Z, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_Conv_RotatorToString;
    /// <summary>
    /// Function: Conv_RotatorToString
    /// </summary>
    public unsafe static BmSDK.FString Conv_RotatorToString(BmSDK.Rotator InRot)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Conv_RotatorToString, "Engine.AITree_DMC_Base.Conv_RotatorToString");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InRot, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_Conv_VectorToString;
    /// <summary>
    /// Function: Conv_VectorToString
    /// </summary>
    public unsafe static BmSDK.FString Conv_VectorToString(System.Numerics.Vector3 InVec)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Conv_VectorToString, "Engine.AITree_DMC_Base.Conv_VectorToString");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InVec, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_Conv_BoolToString;
    /// <summary>
    /// Function: Conv_BoolToString
    /// </summary>
    public unsafe static BmSDK.FString Conv_BoolToString(bool InBool)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Conv_BoolToString, "Engine.AITree_DMC_Base.Conv_BoolToString");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InBool, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_Conv_IntToString;
    /// <summary>
    /// Function: Conv_IntToString
    /// </summary>
    public unsafe static BmSDK.FString Conv_IntToString(int InInt)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Conv_IntToString, "Engine.AITree_DMC_Base.Conv_IntToString");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInt, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_Conv_FloatToString;
    /// <summary>
    /// Function: Conv_FloatToString
    /// </summary>
    public unsafe static BmSDK.FString Conv_FloatToString(float InFloat)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Conv_FloatToString, "Engine.AITree_DMC_Base.Conv_FloatToString");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InFloat, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_Conv_IntToFloat;
    /// <summary>
    /// Function: Conv_IntToFloat
    /// </summary>
    public unsafe static float Conv_IntToFloat(int InInt)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Conv_IntToFloat, "Engine.AITree_DMC_Base.Conv_IntToFloat");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInt, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetWorldTime;
    /// <summary>
    /// Function: GetWorldTime
    /// </summary>
    public unsafe virtual float GetWorldTime(BmSDK.Engine.Actor inActor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWorldTime, "Engine.AITree_DMC_Base.GetWorldTime");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PrintString;
    /// <summary>
    /// Function: PrintString
    /// </summary>
    public unsafe virtual void PrintString(BmSDK.FString InString)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrintString, "Engine.AITree_DMC_Base.PrintString");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InString, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
