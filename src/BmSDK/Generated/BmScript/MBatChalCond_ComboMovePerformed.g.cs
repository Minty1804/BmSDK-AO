#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MBatChalCond_ComboMovePerformed<br/>
/// (size = 60)
/// (flags = 4114)
/// </summary>
public partial class MBatChalCond_ComboMovePerformed : BmSDK.BmGame.MBatmanChallenge_Condition, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MBatChalCond_ComboMovePerformed", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MBatChalCond_ComboMovePerformed.
    /// </summary>
    public static MBatChalCond_ComboMovePerformed DefaultObject => (MBatChalCond_ComboMovePerformed)StaticClass().DefaultObject;

    internal MBatChalCond_ComboMovePerformed() { }

    /// <summary>
    /// Constructs a new MBatChalCond_ComboMovePerformed
    /// </summary>
    public MBatChalCond_ComboMovePerformed(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MBatChalCond_ComboMovePerformed Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MBatChalCond_ComboMovePerformed(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBatChalCond_ComboMovePerformed>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBatChalCond_ComboMovePerformed>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBatChalCond_ComboMovePerformed>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBatChalCond_ComboMovePerformed>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBatChalCond_ComboMovePerformed>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBatChalCond_ComboMovePerformed>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBatChalCond_ComboMovePerformed>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBatChalCond_ComboMovePerformed>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: CollectObservedEvents
    /// </summary>
    public unsafe override void CollectObservedEvents(out BmSDK.TArray<BmSDK.BmGame.MBatmanChallenge.FChallengeAction> Actions)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBatChalCond_ComboMovePerformed.CollectObservedEvents", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Actions = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MBatmanChallenge.FChallengeAction>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: RegisterAction
    /// </summary>
    public unsafe override bool RegisterAction(out BmSDK.BmGame.MBatmanChallenge.FChallengeAction ca)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MBatChalCond_ComboMovePerformed.RegisterAction", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ca = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MBatmanChallenge.FChallengeAction>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    /// <summary>
    /// ByteProperty: ComboMove
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EComboMoveType ComboMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EComboMoveType>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// ByteProperty: PawnType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.ECombatPawnType PawnType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.ECombatPawnType>(Ptr + 49); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 49); }
    }

    /// <summary>
    /// ByteProperty: FFCModifierType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.FreeFlowCombatModifierType FFCModifierType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FreeFlowCombatModifierType>(Ptr + 50); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 50); }
    }

    /// <summary>
    /// BoolProperty: MustBeGlued
    /// </summary>
    public unsafe bool MustBeGlued
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// IntProperty: minNumberOfTargets
    /// </summary>
    public unsafe int minNumberOfTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }
}
