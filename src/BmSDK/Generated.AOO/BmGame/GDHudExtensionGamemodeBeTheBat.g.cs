#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDHudExtensionGamemodeBeTheBat<br/>
/// (size = 172)
/// (flags = 32786)
/// </summary>
public partial class GDHudExtensionGamemodeBeTheBat : BmSDK.BmGame.GDHudExtensionGamemodeBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDHudExtensionGamemodeBeTheBat", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDHudExtensionGamemodeBeTheBat.
    /// </summary>
    public static GDHudExtensionGamemodeBeTheBat DefaultObject => (GDHudExtensionGamemodeBeTheBat)StaticClass().DefaultObject;

    internal GDHudExtensionGamemodeBeTheBat() { }

    /// <summary>
    /// Constructs a new GDHudExtensionGamemodeBeTheBat
    /// </summary>
    public GDHudExtensionGamemodeBeTheBat(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDHudExtensionGamemodeBeTheBat Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDHudExtensionGamemodeBeTheBat(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeBeTheBat>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeBeTheBat>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeBeTheBat>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeBeTheBat>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeBeTheBat>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeBeTheBat>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeBeTheBat>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeBeTheBat>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_UpdateThugRespawnBar;
    /// <summary>
    /// Function: UpdateThugRespawnBar
    /// </summary>
    public unsafe virtual void UpdateThugRespawnBar(int _thug, float _respawnFactor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateThugRespawnBar, "BmGame.GDHudExtensionGamemodeBeTheBat.UpdateThugRespawnBar");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_thug, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_respawnFactor, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AThugDied;
    /// <summary>
    /// Function: AThugDied
    /// </summary>
    public unsafe virtual void AThugDied(int _thug, BmSDK.FString _damage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AThugDied, "BmGame.GDHudExtensionGamemodeBeTheBat.AThugDied");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_thug, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_damage, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateTimer;
    /// <summary>
    /// Function: UpdateTimer
    /// </summary>
    public unsafe virtual void UpdateTimer(int _min, int _second)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateTimer, "BmGame.GDHudExtensionGamemodeBeTheBat.UpdateTimer");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_min, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_second, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNotificationMessage;
    /// <summary>
    /// Function: SetNotificationMessage
    /// </summary>
    public unsafe virtual void SetNotificationMessage(BmSDK.FString _message)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNotificationMessage, "BmGame.GDHudExtensionGamemodeBeTheBat.SetNotificationMessage");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_message, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeTheBatman;
    /// <summary>
    /// Function: BeTheBatman
    /// </summary>
    public unsafe virtual void BeTheBatman(int _idx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeTheBatman, "BmGame.GDHudExtensionGamemodeBeTheBat.BeTheBatman");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_idx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateThugScore;
    /// <summary>
    /// Function: UpdateThugScore
    /// </summary>
    public unsafe virtual void UpdateThugScore(int _idx, int _score)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateThugScore, "BmGame.GDHudExtensionGamemodeBeTheBat.UpdateThugScore");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_idx, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_score, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetThugDetails;
    /// <summary>
    /// Function: SetThugDetails
    /// </summary>
    public unsafe virtual void SetThugDetails(int _idx, BmSDK.FString _pic, int _score)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetThugDetails, "BmGame.GDHudExtensionGamemodeBeTheBat.SetThugDetails");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_idx, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_pic, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_score, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BlinkTimer;
    /// <summary>
    /// Function: BlinkTimer
    /// </summary>
    public unsafe virtual void BlinkTimer(int _num)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlinkTimer, "BmGame.GDHudExtensionGamemodeBeTheBat.BlinkTimer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_num, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MovieIsReady;
    /// <summary>
    /// Function: MovieIsReady
    /// </summary>
    public unsafe override void MovieIsReady(BmSDK.FString _path)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MovieIsReady, "BmGame.GDHudExtensionGamemodeBeTheBat.MovieIsReady");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_path, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushTickValues;
    /// <summary>
    /// Function: PushTickValues
    /// </summary>
    public unsafe override void PushTickValues()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushTickValues, "BmGame.GDHudExtensionGamemodeBeTheBat.PushTickValues");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushScoreValues;
    /// <summary>
    /// Function: PushScoreValues
    /// </summary>
    public unsafe virtual void PushScoreValues()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushScoreValues, "BmGame.GDHudExtensionGamemodeBeTheBat.PushScoreValues");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwitchBatmen;
    /// <summary>
    /// Function: SwitchBatmen
    /// </summary>
    public unsafe virtual void SwitchBatmen(BmSDK.Engine.OnlineSubsystem.FUniqueNetId _netId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchBatmen, "BmGame.GDHudExtensionGamemodeBeTheBat.SwitchBatmen");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_netId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugDied;
    /// <summary>
    /// Function: ThugDied
    /// </summary>
    public unsafe override void ThugDied(BmSDK.BmGame.RPawnPlayer _pawn, BmSDK.BmGame.RPawnPlayer _killer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugDied, "BmGame.GDHudExtensionGamemodeBeTheBat.ThugDied");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_pawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_killer, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugSpawned;
    /// <summary>
    /// Function: ThugSpawned
    /// </summary>
    public unsafe override void ThugSpawned(BmSDK.BmGame.RPawnPlayer _pawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugSpawned, "BmGame.GDHudExtensionGamemodeBeTheBat.ThugSpawned");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_pawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushTimerValue;
    /// <summary>
    /// Function: PushTimerValue
    /// </summary>
    public unsafe override void PushTimerValue()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushTimerValue, "BmGame.GDHudExtensionGamemodeBeTheBat.PushTimerValue");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushRespawnValues;
    /// <summary>
    /// Function: PushRespawnValues
    /// </summary>
    public unsafe override void PushRespawnValues()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushRespawnValues, "BmGame.GDHudExtensionGamemodeBeTheBat.PushRespawnValues");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushPlayerData;
    /// <summary>
    /// Function: PushPlayerData
    /// </summary>
    public unsafe virtual void PushPlayerData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushPlayerData, "BmGame.GDHudExtensionGamemodeBeTheBat.PushPlayerData");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// IntProperty: CachedBatmanIndex
    /// </summary>
    public unsafe int CachedBatmanIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }
}
