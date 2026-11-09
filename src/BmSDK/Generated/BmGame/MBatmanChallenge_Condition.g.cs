#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: MBatmanChallenge_Condition<br/>
/// (size = 48)
/// (flags = 4115)
/// </summary>
public partial class MBatmanChallenge_Condition : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MBatmanChallenge_Condition", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MBatmanChallenge_Condition.
    /// </summary>
    public static MBatmanChallenge_Condition DefaultObject => (MBatmanChallenge_Condition)StaticClass().DefaultObject;

    internal MBatmanChallenge_Condition() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MBatmanChallenge_Condition(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBatmanChallenge_Condition>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBatmanChallenge_Condition>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBatmanChallenge_Condition>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBatmanChallenge_Condition>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBatmanChallenge_Condition>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBatmanChallenge_Condition>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBatmanChallenge_Condition>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBatmanChallenge_Condition>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_CollectObservedEvents;
    /// <summary>
    /// Function: CollectObservedEvents
    /// </summary>
    public unsafe virtual void CollectObservedEvents(out BmSDK.TArray<BmSDK.BmGame.MBatmanChallenge.FChallengeAction> Actions)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CollectObservedEvents, "BmGame.MBatmanChallenge_Condition.CollectObservedEvents");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Actions = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.MBatmanChallenge.FChallengeAction>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterAction;
    /// <summary>
    /// Function: RegisterAction
    /// </summary>
    public unsafe virtual bool RegisterAction(in BmSDK.BmGame.MBatmanChallenge.FChallengeAction ca)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterAction, "BmGame.MBatmanChallenge_Condition.RegisterAction");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ca, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_Reset;
    /// <summary>
    /// Function: Reset
    /// </summary>
    public unsafe virtual void Reset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Reset, "BmGame.MBatmanChallenge_Condition.Reset");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetChallengeController;
    /// <summary>
    /// Function: GetChallengeController
    /// </summary>
    public unsafe virtual BmSDK.BmGame.MBatmanChallengeController GetChallengeController()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChallengeController, "BmGame.MBatmanChallenge_Condition.GetChallengeController");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MBatmanChallengeController>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe virtual void Init(BmSDK.BmGame.MBatmanChallenge inChallenge)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.MBatmanChallenge_Condition.Init");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inChallenge, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TestGeneric;
    /// <summary>
    /// Function: TestGeneric
    /// </summary>
    public unsafe virtual bool TestGeneric(in BmSDK.BmGame.MBatmanChallenge.FChallengeAction ca, BmSDK.FString _TestGeneric)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestGeneric, "BmGame.MBatmanChallenge_Condition.TestGeneric");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ca, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_TestGeneric, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_TestChallenge;
    /// <summary>
    /// Function: TestChallenge
    /// </summary>
    public unsafe virtual bool TestChallenge(in BmSDK.BmGame.MBatmanChallenge.FChallengeAction ca, BmSDK.BmGame.RPersistentData.EBatmanChallenge _TestChallenge)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestChallenge, "BmGame.MBatmanChallenge_Condition.TestChallenge");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ca, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_TestChallenge, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_TestGA;
    /// <summary>
    /// Function: TestGA
    /// </summary>
    public unsafe virtual bool TestGA(in BmSDK.BmGame.MBatmanChallenge.FChallengeAction ca, BmSDK.BmGame.RGameInfo.EGameAction _TestGA)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestGA, "BmGame.MBatmanChallenge_Condition.TestGA");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ca, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_TestGA, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_TestPredGA;
    /// <summary>
    /// Function: TestPredGA
    /// </summary>
    public unsafe virtual bool TestPredGA(in BmSDK.BmGame.MBatmanChallenge.FChallengeAction ca, BmSDK.BmGame.RGameInfo.EGameAction_PredatorChallenge _TestPredGA)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TestPredGA, "BmGame.MBatmanChallenge_Condition.TestPredGA");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ca, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_TestPredGA, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_dbgActionName;
    /// <summary>
    /// Function: dbgActionName
    /// </summary>
    public unsafe virtual BmSDK.FString dbgActionName(in BmSDK.BmGame.MBatmanChallenge.FChallengeAction ca)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_dbgActionName, "BmGame.MBatmanChallenge_Condition.dbgActionName");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ca, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GetPC;
    /// <summary>
    /// Function: GetPC
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPlayerController GetPC()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPC, "BmGame.MBatmanChallenge_Condition.GetPC");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPlayerController>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetGRI;
    /// <summary>
    /// Function: GetGRI
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameRI GetGRI()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGRI, "BmGame.MBatmanChallenge_Condition.GetGRI");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameRI>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRGI;
    /// <summary>
    /// Function: GetRGI
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo GetRGI()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRGI, "BmGame.MBatmanChallenge_Condition.GetRGI");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo>(paramsPtr + 0);
    }

    /// <summary>
    /// ObjectProperty: Challenge
    /// </summary>
    public unsafe BmSDK.BmGame.MBatmanChallenge Challenge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MBatmanChallenge>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }
}
