#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MEnigmaTower<br/>
/// (size = 453)
/// (flags = 142606994)
/// </summary>
public partial class MEnigmaTower : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MEnigmaTower", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MEnigmaTower.
    /// </summary>
    public static MEnigmaTower DefaultObject => (MEnigmaTower)StaticClass().DefaultObject;

    internal MEnigmaTower() { }

    /// <summary>
    /// Constructs a new MEnigmaTower
    /// </summary>
    public MEnigmaTower(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MEnigmaTower(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MEnigmaTower>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MEnigmaTower>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MEnigmaTower>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MEnigmaTower>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MEnigmaTower>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MEnigmaTower>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MEnigmaTower>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MEnigmaTower>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_UnlockAllSpyNodes;
    /// <summary>
    /// Function: UnlockAllSpyNodes
    /// </summary>
    public unsafe virtual void UnlockAllSpyNodes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockAllSpyNodes, "BmGame.MEnigmaTower.UnlockAllSpyNodes");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTowerName;
    /// <summary>
    /// Function: GetTowerName
    /// </summary>
    public unsafe virtual BmSDK.FString GetTowerName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTowerName, "BmGame.MEnigmaTower.GetTowerName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HackTower;
    /// <summary>
    /// Function: HackTower
    /// </summary>
    public unsafe virtual void HackTower()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HackTower, "BmGame.MEnigmaTower.HackTower");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanHackTower;
    /// <summary>
    /// Function: CanHackTower
    /// </summary>
    public unsafe virtual bool CanHackTower()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanHackTower, "BmGame.MEnigmaTower.CanHackTower");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetTowerActive;
    /// <summary>
    /// Function: SetTowerActive
    /// </summary>
    public unsafe virtual void SetTowerActive(bool IsActive)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTowerActive, "BmGame.MEnigmaTower.SetTowerActive");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsActive, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ByteProperty: TowerIndex
    /// </summary>
    public unsafe BmSDK.BmGame.MEnigmaTower.E_TowerIDs TowerIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MEnigmaTower.E_TowerIDs>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// Enum: E_TowerIDs
    /// </summary>
    public enum E_TowerIDs : byte
    {
        Tower1 = 0,
        Tower2 = 1,
        Tower3 = 2,
        Tower4 = 3,
        Tower5 = 4,
        Tower6 = 5,
        Tower7 = 6,
        TowerNone = 7,
        E_TowerIDs_MAX = 8,
    }
}
