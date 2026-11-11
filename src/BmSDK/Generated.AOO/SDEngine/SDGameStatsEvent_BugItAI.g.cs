#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.SDEngine;

/// <summary>
/// Class: SDGameStatsEvent_BugItAI<br/>
/// (size = 68)
/// (flags = 32786)
/// </summary>
public partial class SDGameStatsEvent_BugItAI : BmSDK.SDEngine.SDGameStatsEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "SDEngine.SDGameStatsEvent_BugItAI", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as SDGameStatsEvent_BugItAI.
    /// </summary>
    public static SDGameStatsEvent_BugItAI DefaultObject => (SDGameStatsEvent_BugItAI)StaticClass().DefaultObject;

    internal SDGameStatsEvent_BugItAI() { }

    /// <summary>
    /// Constructs a new SDGameStatsEvent_BugItAI
    /// </summary>
    public SDGameStatsEvent_BugItAI(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SDGameStatsEvent_BugItAI Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SDGameStatsEvent_BugItAI(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDGameStatsEvent_BugItAI>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDGameStatsEvent_BugItAI>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDGameStatsEvent_BugItAI>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDGameStatsEvent_BugItAI>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDGameStatsEvent_BugItAI>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDGameStatsEvent_BugItAI>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SDGameStatsEvent_BugItAI>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SDGameStatsEvent_BugItAI>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_Visualize_BugItAI;
    /// <summary>
    /// Function: Visualize_BugItAI
    /// </summary>
    public unsafe static void Visualize_BugItAI(BmSDK.SDEngine.SDGameStatsContext Ctx, BmSDK.FString Player, System.Numerics.Vector3 Position, int Yaw, int Roll, int Pitch, BmSDK.FString Description)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Visualize_BugItAI, "SDEngine.SDGameStatsEvent_BugItAI.Visualize_BugItAI");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Ctx, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Yaw, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Roll, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pitch, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Log;
    /// <summary>
    /// Function: Log
    /// </summary>
    public unsafe virtual void Log(BmSDK.FString PlayerName, BmSDK.FString Description, System.Numerics.Vector3 Position, BmSDK.Rotator Orientation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Log, "SDEngine.SDGameStatsEvent_BugItAI.Log");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Orientation, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe virtual void Init()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "SDEngine.SDGameStatsEvent_BugItAI.Init");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: SpriteTexture
    /// </summary>
    public unsafe BmSDK.Engine.Texture SpriteTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// StructProperty: Red
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor Red
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 64);
}
