#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDLoadoutManager<br/>
/// (size = 832)
/// (flags = 32786)
/// </summary>
public partial class GDLoadoutManager : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDLoadoutManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDLoadoutManager.
    /// </summary>
    public static GDLoadoutManager DefaultObject => (GDLoadoutManager)StaticClass().DefaultObject;

    internal GDLoadoutManager() { }

    /// <summary>
    /// Constructs a new GDLoadoutManager
    /// </summary>
    public GDLoadoutManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDLoadoutManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDLoadoutManager(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDLoadoutManager>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDLoadoutManager>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDLoadoutManager>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDLoadoutManager>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDLoadoutManager>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDLoadoutManager>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDLoadoutManager>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDLoadoutManager>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetPlayerLoadoutByCharId;
    /// <summary>
    /// Function: SetPlayerLoadoutByCharId
    /// </summary>
    public unsafe virtual void SetPlayerLoadoutByCharId(BmSDK.BmGame.RGameInfo.LoadoutCharacterID _id, BmSDK.BmGame.RGameInfo.FGDPlayerLoadout _loadout)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPlayerLoadoutByCharId, "BmGame.GDLoadoutManager.SetPlayerLoadoutByCharId");
        byte* paramsPtr = stackalloc byte[136];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_loadout, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPlayerLoadoutByCharId;
    /// <summary>
    /// Function: GetPlayerLoadoutByCharId
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.FGDPlayerLoadout GetPlayerLoadoutByCharId(BmSDK.BmGame.RGameInfo.LoadoutCharacterID _id)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerLoadoutByCharId, "BmGame.GDLoadoutManager.GetPlayerLoadoutByCharId");
        byte* paramsPtr = stackalloc byte[136];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.FGDPlayerLoadout>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetInstance;
    /// <summary>
    /// Function: GetInstance
    /// </summary>
    public unsafe static BmSDK.BmGame.GDLoadoutManager GetInstance()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInstance, "BmGame.GDLoadoutManager.GetInstance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDLoadoutManager>(paramsPtr + 0);
    }

    /// <summary>
    /// InlineArray{StructProperty}: PossibleLoadouts
    /// </summary>
    public InlineArray<BmSDK.BmGame.RGameInfo.FGDPlayerLoadout> PossibleLoadouts => new(7, Ptr + 48, 112, this);

    /// <summary>
    /// StructProperty: PossibleLoadouts
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGameInfo.FGDPlayerLoadout PossibleLoadouts_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGameInfo.FGDPlayerLoadout>(Ptr + 48);
    /// <summary>
    /// StructProperty: PossibleLoadouts
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGameInfo.FGDPlayerLoadout PossibleLoadouts_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGameInfo.FGDPlayerLoadout>(Ptr + 160);
    /// <summary>
    /// StructProperty: PossibleLoadouts
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGameInfo.FGDPlayerLoadout PossibleLoadouts_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGameInfo.FGDPlayerLoadout>(Ptr + 272);
    /// <summary>
    /// StructProperty: PossibleLoadouts
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGameInfo.FGDPlayerLoadout PossibleLoadouts_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGameInfo.FGDPlayerLoadout>(Ptr + 384);
    /// <summary>
    /// StructProperty: PossibleLoadouts
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGameInfo.FGDPlayerLoadout PossibleLoadouts_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGameInfo.FGDPlayerLoadout>(Ptr + 496);
    /// <summary>
    /// StructProperty: PossibleLoadouts
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGameInfo.FGDPlayerLoadout PossibleLoadouts_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGameInfo.FGDPlayerLoadout>(Ptr + 608);
    /// <summary>
    /// StructProperty: PossibleLoadouts
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGameInfo.FGDPlayerLoadout PossibleLoadouts_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGameInfo.FGDPlayerLoadout>(Ptr + 720);
}
