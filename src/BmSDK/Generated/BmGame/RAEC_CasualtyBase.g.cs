#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RAEC_CasualtyBase<br/>
/// (size = 489)
/// (flags = 8388627)
/// </summary>
public partial class RAEC_CasualtyBase : BmSDK.BmGame.RAlertEventCoordinatorBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAEC_CasualtyBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAEC_CasualtyBase.
    /// </summary>
    public static RAEC_CasualtyBase DefaultObject => (RAEC_CasualtyBase)StaticClass().DefaultObject;

    internal RAEC_CasualtyBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAEC_CasualtyBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_CasualtyBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_CasualtyBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_CasualtyBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_CasualtyBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_CasualtyBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_CasualtyBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_CasualtyBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_CasualtyBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ScreamNoReaction;
    /// <summary>
    /// Function: ScreamNoReaction
    /// </summary>
    public unsafe virtual void ScreamNoReaction(BmSDK.BmGame.RBMAIController.CasualtyScreamReason ScreamReason)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScreamNoReaction, "BmGame.RAEC_CasualtyBase.ScreamNoReaction");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScreamReason, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTagForForewarning;
    /// <summary>
    /// Function: GetTagForForewarning
    /// </summary>
    public unsafe virtual BmSDK.FString GetTagForForewarning()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTagForForewarning, "BmGame.RAEC_CasualtyBase.GetTagForForewarning");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SonicBatarangTakedown;
    /// <summary>
    /// Function: SonicBatarangTakedown
    /// </summary>
    public unsafe virtual void SonicBatarangTakedown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SonicBatarangTakedown, "BmGame.RAEC_CasualtyBase.SonicBatarangTakedown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostCutNotify;
    /// <summary>
    /// Function: PostCutNotify
    /// </summary>
    public unsafe virtual void PostCutNotify(System.Numerics.Vector3 ImpactLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostCutNotify, "BmGame.RAEC_CasualtyBase.PostCutNotify");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactLoc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PawnTakenDown;
    /// <summary>
    /// Function: PawnTakenDown
    /// </summary>
    public unsafe virtual void PawnTakenDown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnTakenDown, "BmGame.RAEC_CasualtyBase.PawnTakenDown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyRopeCut;
    /// <summary>
    /// Function: NotifyRopeCut
    /// </summary>
    public unsafe virtual void NotifyRopeCut(BmSDK.BmGame.RBatarangProjectile Brang)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyRopeCut, "BmGame.RAEC_CasualtyBase.NotifyRopeCut");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Brang, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_VillainScreamed;
    /// <summary>
    /// Function: VillainScreamed
    /// </summary>
    public unsafe virtual void VillainScreamed(BmSDK.BmGame.RBMAIController.CasualtyScreamReason ScreamReason)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VillainScreamed, "BmGame.RAEC_CasualtyBase.VillainScreamed");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScreamReason, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CasFound;
    /// <summary>
    /// Function: CasFound
    /// </summary>
    public unsafe virtual void CasFound(BmSDK.BmGame.RBMAIController Spotter)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CasFound, "BmGame.RAEC_CasualtyBase.CasFound");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Spotter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: Casualty
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI Casualty
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bPlayedManDown
    /// </summary>
    public unsafe bool bPlayedManDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: bDiscoverForewarned
    /// </summary>
    public unsafe bool bDiscoverForewarned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// ByteProperty: ForewarningType
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIController.CasualtyScreamReason ForewarningType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIController.CasualtyScreamReason>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }
}
