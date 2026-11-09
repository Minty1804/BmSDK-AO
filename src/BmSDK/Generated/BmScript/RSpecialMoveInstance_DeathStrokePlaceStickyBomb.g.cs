#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveInstance_DeathStrokePlaceStickyBomb<br/>
/// (size = 812)
/// (flags = 8388626)
/// </summary>
public partial class RSpecialMoveInstance_DeathStrokePlaceStickyBomb : BmSDK.BmScript.RSpecialMoveInstance_RobinPlaceStickyBomb, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveInstance_DeathStrokePlaceStickyBomb", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSpecialMoveInstance_DeathStrokePlaceStickyBomb.
    /// </summary>
    public static RSpecialMoveInstance_DeathStrokePlaceStickyBomb DefaultObject => (RSpecialMoveInstance_DeathStrokePlaceStickyBomb)StaticClass().DefaultObject;

    internal RSpecialMoveInstance_DeathStrokePlaceStickyBomb() { }

    /// <summary>
    /// Constructs a new RSpecialMoveInstance_DeathStrokePlaceStickyBomb
    /// </summary>
    public RSpecialMoveInstance_DeathStrokePlaceStickyBomb(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveInstance_DeathStrokePlaceStickyBomb(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_DeathStrokePlaceStickyBomb>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_DeathStrokePlaceStickyBomb>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_DeathStrokePlaceStickyBomb>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_DeathStrokePlaceStickyBomb>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_DeathStrokePlaceStickyBomb>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_DeathStrokePlaceStickyBomb>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_DeathStrokePlaceStickyBomb>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_DeathStrokePlaceStickyBomb>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_PlaceBomb;
    /// <summary>
    /// Function: PlaceBomb
    /// </summary>
    public unsafe override void PlaceBomb()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaceBomb, "BmScript.RSpecialMoveInstance_DeathStrokePlaceStickyBomb.PlaceBomb");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetStickyBombSocketInfo;
    /// <summary>
    /// Function: GetStickyBombSocketInfo
    /// </summary>
    public unsafe static void GetStickyBombSocketInfo(bool OnBack, BmSDK.BmGame.RPawnVillain Villain, out BmSDK.FName SocketOrBone, out int isBone, out System.Numerics.Vector3 pos, out BmSDK.Rotator Orientation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStickyBombSocketInfo, "BmScript.RSpecialMoveInstance_DeathStrokePlaceStickyBomb.GetStickyBombSocketInfo");
        byte* paramsPtr = stackalloc byte[188];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnBack, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SocketOrBone);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SocketOrBone, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out isBone);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(isBone, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out pos);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos, paramsPtr + 20);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Orientation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Orientation, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SocketOrBone = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
        isBone = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
        pos = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 20);
        Orientation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 32);
        return;
    }

    private static BmSDK.Function __fn_UpdateSpecialMove;
    /// <summary>
    /// Function: UpdateSpecialMove
    /// </summary>
    public unsafe override bool UpdateSpecialMove(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateSpecialMove, "BmScript.RSpecialMoveInstance_DeathStrokePlaceStickyBomb.UpdateSpecialMove");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TriggerSpecialMove;
    /// <summary>
    /// Function: TriggerSpecialMove
    /// </summary>
    public unsafe override void TriggerSpecialMove(BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator MoveLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSpecialMove, "BmScript.RSpecialMoveInstance_DeathStrokePlaceStickyBomb.TriggerSpecialMove");
        byte* paramsPtr = stackalloc byte[408];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCombatAnimName;
    /// <summary>
    /// Function: GetCombatAnimName
    /// </summary>
    public unsafe override BmSDK.FName GetCombatAnimName(out BmSDK.Engine.AnimSet OutAnimSet, out int rearAttack)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatAnimName, "BmScript.RSpecialMoveInstance_DeathStrokePlaceStickyBomb.GetCombatAnimName");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutAnimSet);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutAnimSet, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out rearAttack);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(rearAttack, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutAnimSet = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
        rearAttack = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
    }
}
