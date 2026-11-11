#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDStatPlayerNetworkEvent<br/>
/// (size = 60)
/// (flags = 134250642)
/// </summary>
public partial class GDStatPlayerNetworkEvent : BmSDK.SDEngine.SDGameStatsEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDStatPlayerNetworkEvent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDStatPlayerNetworkEvent.
    /// </summary>
    public static GDStatPlayerNetworkEvent DefaultObject => (GDStatPlayerNetworkEvent)StaticClass().DefaultObject;

    internal GDStatPlayerNetworkEvent() { }

    /// <summary>
    /// Constructs a new GDStatPlayerNetworkEvent
    /// </summary>
    public GDStatPlayerNetworkEvent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDStatPlayerNetworkEvent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDStatPlayerNetworkEvent(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDStatPlayerNetworkEvent>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDStatPlayerNetworkEvent>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDStatPlayerNetworkEvent>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDStatPlayerNetworkEvent>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDStatPlayerNetworkEvent>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDStatPlayerNetworkEvent>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDStatPlayerNetworkEvent>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDStatPlayerNetworkEvent>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_Log;
    /// <summary>
    /// Function: Log
    /// </summary>
    public unsafe virtual void Log(BmSDK.Engine.OnlineSubsystem.FUniqueNetId Id, int Ping, int StatAvgInBPS, int StatAvgOutBPS, int StatMaxInBPS, int StatMaxOutBPS, int StatPingMin, int StatPingMax, int StatPingTotals, int StatPKLMin, int StatPKLMax, int StatPKLTotal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Log, "BmGame.GDStatPlayerNetworkEvent.Log");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Ping, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatAvgInBPS, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatAvgOutBPS, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatMaxInBPS, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatMaxOutBPS, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatPingMin, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatPingMax, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatPingTotals, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatPKLMin, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatPKLMax, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatPKLTotal, paramsPtr + 48);
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
}
