#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDHudExtensionGamemodeBeTheVillain<br/>
/// (size = 200)
/// (flags = 32786)
/// </summary>
public partial class GDHudExtensionGamemodeBeTheVillain : BmSDK.BmGame.GDHudExtensionGamemodeBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDHudExtensionGamemodeBeTheVillain", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDHudExtensionGamemodeBeTheVillain.
    /// </summary>
    public static GDHudExtensionGamemodeBeTheVillain DefaultObject => (GDHudExtensionGamemodeBeTheVillain)StaticClass().DefaultObject;

    internal GDHudExtensionGamemodeBeTheVillain() { }

    /// <summary>
    /// Constructs a new GDHudExtensionGamemodeBeTheVillain
    /// </summary>
    public GDHudExtensionGamemodeBeTheVillain(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDHudExtensionGamemodeBeTheVillain Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDHudExtensionGamemodeBeTheVillain(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeBeTheVillain>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeBeTheVillain>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeBeTheVillain>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeBeTheVillain>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeBeTheVillain>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeBeTheVillain>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeBeTheVillain>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtensionGamemodeBeTheVillain>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_UpdateTimer;
    /// <summary>
    /// Function: UpdateTimer
    /// </summary>
    public unsafe virtual void UpdateTimer(int _min, int _second)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateTimer, "BmGame.GDHudExtensionGamemodeBeTheVillain.UpdateTimer");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_min, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_second, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateThugRespawnBar;
    /// <summary>
    /// Function: UpdateThugRespawnBar
    /// </summary>
    public unsafe virtual void UpdateThugRespawnBar(BmSDK.FString _side, int _thug, float _respawnFactor)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateThugRespawnBar, "BmGame.GDHudExtensionGamemodeBeTheVillain.UpdateThugRespawnBar");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_side, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_thug, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_respawnFactor, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetThugTargetScore;
    /// <summary>
    /// Function: SetThugTargetScore
    /// </summary>
    public unsafe virtual void SetThugTargetScore(BmSDK.FString _side, int _targetScore)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetThugTargetScore, "BmGame.GDHudExtensionGamemodeBeTheVillain.SetThugTargetScore");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_side, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_targetScore, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetThugScore;
    /// <summary>
    /// Function: SetThugScore
    /// </summary>
    public unsafe virtual void SetThugScore(BmSDK.FString _side, int _score)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetThugScore, "BmGame.GDHudExtensionGamemodeBeTheVillain.SetThugScore");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_side, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_score, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetThugDamageType;
    /// <summary>
    /// Function: SetThugDamageType
    /// </summary>
    public unsafe virtual void SetThugDamageType(BmSDK.FString _side, int _thug, BmSDK.FString _damage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetThugDamageType, "BmGame.GDHudExtensionGamemodeBeTheVillain.SetThugDamageType");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_side, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_thug, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_damage, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGangInfo;
    /// <summary>
    /// Function: SetGangInfo
    /// </summary>
    public unsafe virtual void SetGangInfo(BmSDK.FString _side, BmSDK.FString _gangName, BmSDK.FString _thug1Pic, BmSDK.FString _thug2Pic, BmSDK.FString _thug3Pic, BmSDK.FString _thug4Pic, BmSDK.FString _picPackage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGangInfo, "BmGame.GDHudExtensionGamemodeBeTheVillain.SetGangInfo");
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_side, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_gangName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_thug1Pic, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_thug2Pic, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_thug3Pic, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_thug4Pic, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_picPackage, paramsPtr + 72);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGangInfoColour;
    /// <summary>
    /// Function: SetGangInfoColour
    /// </summary>
    public unsafe virtual void SetGangInfoColour(BmSDK.FString _side, BmSDK.FString _colour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGangInfoColour, "BmGame.GDHudExtensionGamemodeBeTheVillain.SetGangInfoColour");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_side, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_colour, paramsPtr + 12);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlinkTimer, "BmGame.GDHudExtensionGamemodeBeTheVillain.BlinkTimer");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MovieIsReady, "BmGame.GDHudExtensionGamemodeBeTheVillain.MovieIsReady");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_path, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushTimerValue, "BmGame.GDHudExtensionGamemodeBeTheVillain.PushTimerValue");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugDied, "BmGame.GDHudExtensionGamemodeBeTheVillain.ThugDied");
        byte* paramsPtr = stackalloc byte[36];
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugSpawned, "BmGame.GDHudExtensionGamemodeBeTheVillain.ThugSpawned");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_pawn, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushRespawnValues, "BmGame.GDHudExtensionGamemodeBeTheVillain.PushRespawnValues");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupTargetScores;
    /// <summary>
    /// Function: SetupTargetScores
    /// </summary>
    public unsafe virtual void SetupTargetScores()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupTargetScores, "BmGame.GDHudExtensionGamemodeBeTheVillain.SetupTargetScores");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupGangHudSides;
    /// <summary>
    /// Function: SetupGangHudSides
    /// </summary>
    public unsafe virtual void SetupGangHudSides()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupGangHudSides, "BmGame.GDHudExtensionGamemodeBeTheVillain.SetupGangHudSides");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushPlayerInfo;
    /// <summary>
    /// Function: PushPlayerInfo
    /// </summary>
    public unsafe virtual void PushPlayerInfo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushPlayerInfo, "BmGame.GDHudExtensionGamemodeBeTheVillain.PushPlayerInfo");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushScores;
    /// <summary>
    /// Function: PushScores
    /// </summary>
    public unsafe virtual void PushScores()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushScores, "BmGame.GDHudExtensionGamemodeBeTheVillain.PushScores");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPlayerHudSide;
    /// <summary>
    /// Function: GetPlayerHudSide
    /// </summary>
    public unsafe virtual BmSDK.FString GetPlayerHudSide(int _idx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerHudSide, "BmGame.GDHudExtensionGamemodeBeTheVillain.GetPlayerHudSide");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_idx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_Close;
    /// <summary>
    /// Function: Close
    /// </summary>
    public unsafe override void Close()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Close, "BmGame.GDHudExtensionGamemodeBeTheVillain.Close");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StrProperty: BaneGangSide
    /// </summary>
    public unsafe BmSDK.FString BaneGangSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// StrProperty: JokerGangSide
    /// </summary>
    public unsafe BmSDK.FString JokerGangSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// IntProperty: CachedJokerScore
    /// </summary>
    public unsafe int CachedJokerScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// IntProperty: CachedBaneScore
    /// </summary>
    public unsafe int CachedBaneScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }
}
