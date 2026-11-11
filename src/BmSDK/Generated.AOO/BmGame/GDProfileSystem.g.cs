#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDProfileSystem<br/>
/// (size = 460)
/// (flags = 134250642)
/// </summary>
public partial class GDProfileSystem : BmSDK.SDEngine.SDProfileSystem, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDProfileSystem", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDProfileSystem.
    /// </summary>
    public static GDProfileSystem DefaultObject => (GDProfileSystem)StaticClass().DefaultObject;

    internal GDProfileSystem() { }

    /// <summary>
    /// Constructs a new GDProfileSystem
    /// </summary>
    public GDProfileSystem(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDProfileSystem Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDProfileSystem(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDProfileSystem>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDProfileSystem>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDProfileSystem>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDProfileSystem>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDProfileSystem>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDProfileSystem>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDProfileSystem>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDProfileSystem>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_SetSharedSetting;
    /// <summary>
    /// Function: SetSharedSetting
    /// </summary>
    public unsafe virtual void SetSharedSetting(BmSDK.BmGame.RPersistentOptions.EPlayerOptions SharedSetting, bool bEnabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSharedSetting, "BmGame.GDProfileSystem.SetSharedSetting");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SharedSetting, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSharedSetting;
    /// <summary>
    /// Function: GetSharedSetting
    /// </summary>
    public unsafe virtual bool GetSharedSetting(BmSDK.BmGame.RPersistentOptions.EPlayerOptions SharedSetting)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSharedSetting, "BmGame.GDProfileSystem.GetSharedSetting");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SharedSetting, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetTriggerFlip;
    /// <summary>
    /// Function: SetTriggerFlip
    /// </summary>
    public unsafe virtual void SetTriggerFlip(bool bEnabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTriggerFlip, "BmGame.GDProfileSystem.SetTriggerFlip");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTriggerFlip;
    /// <summary>
    /// Function: GetTriggerFlip
    /// </summary>
    public unsafe virtual bool GetTriggerFlip()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTriggerFlip, "BmGame.GDProfileSystem.GetTriggerFlip");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetSpTrophyRobin;
    /// <summary>
    /// Function: SetSpTrophyRobin
    /// </summary>
    public unsafe virtual void SetSpTrophyRobin()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSpTrophyRobin, "BmGame.GDProfileSystem.SetSpTrophyRobin");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLeftyFlip;
    /// <summary>
    /// Function: SetLeftyFlip
    /// </summary>
    public unsafe virtual void SetLeftyFlip(bool bEnabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLeftyFlip, "BmGame.GDProfileSystem.SetLeftyFlip");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetLeftyFlip;
    /// <summary>
    /// Function: GetLeftyFlip
    /// </summary>
    public unsafe virtual bool GetLeftyFlip()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLeftyFlip, "BmGame.GDProfileSystem.GetLeftyFlip");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IncrementEliteKillsOnHeroes;
    /// <summary>
    /// Function: IncrementEliteKillsOnHeroes
    /// </summary>
    public unsafe virtual void IncrementEliteKillsOnHeroes(int ByAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncrementEliteKillsOnHeroes, "BmGame.GDProfileSystem.IncrementEliteKillsOnHeroes");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ByAmount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetEliteKillsOnHeroes;
    /// <summary>
    /// Function: GetEliteKillsOnHeroes
    /// </summary>
    public unsafe virtual int GetEliteKillsOnHeroes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEliteKillsOnHeroes, "BmGame.GDProfileSystem.GetEliteKillsOnHeroes");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IncrementHeroKillsOnElites;
    /// <summary>
    /// Function: IncrementHeroKillsOnElites
    /// </summary>
    public unsafe virtual void IncrementHeroKillsOnElites(int ByAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncrementHeroKillsOnElites, "BmGame.GDProfileSystem.IncrementHeroKillsOnElites");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ByAmount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHeroKillsOnElites;
    /// <summary>
    /// Function: GetHeroKillsOnElites
    /// </summary>
    public unsafe virtual int GetHeroKillsOnElites()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeroKillsOnElites, "BmGame.GDProfileSystem.GetHeroKillsOnElites");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetMapRoundWin;
    /// <summary>
    /// Function: SetMapRoundWin
    /// </summary>
    public unsafe virtual void SetMapRoundWin(BmSDK.FString MapName, BmSDK.FString TeamName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMapRoundWin, "BmGame.GDProfileSystem.SetMapRoundWin");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetMapRoundWin;
    /// <summary>
    /// Function: GetMapRoundWin
    /// </summary>
    public unsafe virtual bool GetMapRoundWin(BmSDK.FString MapName, BmSDK.FString TeamName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMapRoundWin, "BmGame.GDProfileSystem.GetMapRoundWin");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_GetHeroOptOut;
    /// <summary>
    /// Function: GetHeroOptOut
    /// </summary>
    public unsafe virtual bool GetHeroOptOut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeroOptOut, "BmGame.GDProfileSystem.GetHeroOptOut");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetHeroOptOut;
    /// <summary>
    /// Function: SetHeroOptOut
    /// </summary>
    public unsafe virtual void SetHeroOptOut(bool bOptOut)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHeroOptOut, "BmGame.GDProfileSystem.SetHeroOptOut");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOptOut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRoundsSinceHero;
    /// <summary>
    /// Function: GetRoundsSinceHero
    /// </summary>
    public unsafe virtual int GetRoundsSinceHero()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRoundsSinceHero, "BmGame.GDProfileSystem.GetRoundsSinceHero");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetRoundsSinceHero;
    /// <summary>
    /// Function: SetRoundsSinceHero
    /// </summary>
    public unsafe virtual void SetRoundsSinceHero(int NumRounds)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRoundsSinceHero, "BmGame.GDProfileSystem.SetRoundsSinceHero");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumRounds, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetShouldWeaponAutoSwitch;
    /// <summary>
    /// Function: GetShouldWeaponAutoSwitch
    /// </summary>
    public unsafe virtual bool GetShouldWeaponAutoSwitch()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetShouldWeaponAutoSwitch, "BmGame.GDProfileSystem.GetShouldWeaponAutoSwitch");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPreferredFaction;
    /// <summary>
    /// Function: GetPreferredFaction
    /// </summary>
    public unsafe virtual int GetPreferredFaction()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPreferredFaction, "BmGame.GDProfileSystem.GetPreferredFaction");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetPreferredFaction;
    /// <summary>
    /// Function: SetPreferredFaction
    /// </summary>
    public unsafe virtual void SetPreferredFaction(int Faction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPreferredFaction, "BmGame.GDProfileSystem.SetPreferredFaction");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Faction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetFactionXPLevel;
    /// <summary>
    /// Function: GetFactionXPLevel
    /// </summary>
    public unsafe virtual int GetFactionXPLevel(BmSDK.FString FactionShortName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFactionXPLevel, "BmGame.GDProfileSystem.GetFactionXPLevel");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FactionShortName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetFactionXPForNextUpgrade;
    /// <summary>
    /// Function: GetFactionXPForNextUpgrade
    /// </summary>
    public unsafe virtual int GetFactionXPForNextUpgrade(BmSDK.FString FactionShortName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFactionXPForNextUpgrade, "BmGame.GDProfileSystem.GetFactionXPForNextUpgrade");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FactionShortName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetFactionXPForPrevUpgrade;
    /// <summary>
    /// Function: GetFactionXPForPrevUpgrade
    /// </summary>
    public unsafe virtual int GetFactionXPForPrevUpgrade(BmSDK.FString FactionShortName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFactionXPForPrevUpgrade, "BmGame.GDProfileSystem.GetFactionXPForPrevUpgrade");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FactionShortName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetFactionXP;
    /// <summary>
    /// Function: GetFactionXP
    /// </summary>
    public unsafe virtual int GetFactionXP(BmSDK.FString FactionShortName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFactionXP, "BmGame.GDProfileSystem.GetFactionXP");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FactionShortName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetFactionXPLevel;
    /// <summary>
    /// Function: SetFactionXPLevel
    /// </summary>
    public unsafe virtual void SetFactionXPLevel(int Value, BmSDK.FString FactionShortName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFactionXPLevel, "BmGame.GDProfileSystem.SetFactionXPLevel");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FactionShortName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetFactionXPForNextUpgrade;
    /// <summary>
    /// Function: SetFactionXPForNextUpgrade
    /// </summary>
    public unsafe virtual void SetFactionXPForNextUpgrade(int Value, BmSDK.FString FactionShortName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFactionXPForNextUpgrade, "BmGame.GDProfileSystem.SetFactionXPForNextUpgrade");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FactionShortName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetFactionXPForPrevUpgrade;
    /// <summary>
    /// Function: SetFactionXPForPrevUpgrade
    /// </summary>
    public unsafe virtual void SetFactionXPForPrevUpgrade(int Value, BmSDK.FString FactionShortName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFactionXPForPrevUpgrade, "BmGame.GDProfileSystem.SetFactionXPForPrevUpgrade");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FactionShortName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetFactionXP;
    /// <summary>
    /// Function: SetFactionXP
    /// </summary>
    public unsafe virtual void SetFactionXP(int Value, BmSDK.FString FactionShortName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFactionXP, "BmGame.GDProfileSystem.SetFactionXP");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FactionShortName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAccountXPLevel;
    /// <summary>
    /// Function: GetAccountXPLevel
    /// </summary>
    public unsafe virtual int GetAccountXPLevel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAccountXPLevel, "BmGame.GDProfileSystem.GetAccountXPLevel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAccountXPForNextUpgrade;
    /// <summary>
    /// Function: GetAccountXPForNextUpgrade
    /// </summary>
    public unsafe virtual int GetAccountXPForNextUpgrade()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAccountXPForNextUpgrade, "BmGame.GDProfileSystem.GetAccountXPForNextUpgrade");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAccountXPForPrevUpgrade;
    /// <summary>
    /// Function: GetAccountXPForPrevUpgrade
    /// </summary>
    public unsafe virtual int GetAccountXPForPrevUpgrade()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAccountXPForPrevUpgrade, "BmGame.GDProfileSystem.GetAccountXPForPrevUpgrade");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAccountXP;
    /// <summary>
    /// Function: GetAccountXP
    /// </summary>
    public unsafe virtual int GetAccountXP()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAccountXP, "BmGame.GDProfileSystem.GetAccountXP");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetAccountXPLevel;
    /// <summary>
    /// Function: SetAccountXPLevel
    /// </summary>
    public unsafe virtual void SetAccountXPLevel(int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAccountXPLevel, "BmGame.GDProfileSystem.SetAccountXPLevel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAccountXPForNextUpgrade;
    /// <summary>
    /// Function: SetAccountXPForNextUpgrade
    /// </summary>
    public unsafe virtual void SetAccountXPForNextUpgrade(int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAccountXPForNextUpgrade, "BmGame.GDProfileSystem.SetAccountXPForNextUpgrade");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAccountXPForPrevUpgrade;
    /// <summary>
    /// Function: SetAccountXPForPrevUpgrade
    /// </summary>
    public unsafe virtual void SetAccountXPForPrevUpgrade(int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAccountXPForPrevUpgrade, "BmGame.GDProfileSystem.SetAccountXPForPrevUpgrade");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAccountXP;
    /// <summary>
    /// Function: SetAccountXP
    /// </summary>
    public unsafe virtual void SetAccountXP(int Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAccountXP, "BmGame.GDProfileSystem.SetAccountXP");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearWeaponScores;
    /// <summary>
    /// Function: ClearWeaponScores
    /// </summary>
    public unsafe virtual void ClearWeaponScores(bool bClearLifetimeScores = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearWeaponScores, "BmGame.GDProfileSystem.ClearWeaponScores");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bClearLifetimeScores, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetWeaponScoreForUpgradeLevel;
    /// <summary>
    /// Function: GetWeaponScoreForUpgradeLevel
    /// </summary>
    public unsafe virtual int GetWeaponScoreForUpgradeLevel(int Level)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWeaponScoreForUpgradeLevel, "BmGame.GDProfileSystem.GetWeaponScoreForUpgradeLevel");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Level, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetWeaponUpgradeLevelForScore;
    /// <summary>
    /// Function: GetWeaponUpgradeLevelForScore
    /// </summary>
    public unsafe virtual int GetWeaponUpgradeLevelForScore(int Score)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWeaponUpgradeLevelForScore, "BmGame.GDProfileSystem.GetWeaponUpgradeLevelForScore");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SaveWeaponScoresToProfile;
    /// <summary>
    /// Function: SaveWeaponScoresToProfile
    /// </summary>
    public unsafe virtual void SaveWeaponScoresToProfile()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SaveWeaponScoresToProfile, "BmGame.GDProfileSystem.SaveWeaponScoresToProfile");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetWeaponScore;
    /// <summary>
    /// Function: SetWeaponScore
    /// </summary>
    public unsafe virtual void SetWeaponScore(BmSDK.BmGame.RGameInfo.WeaponId Weapon, int Score)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWeaponScore, "BmGame.GDProfileSystem.SetWeaponScore");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Weapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetWeaponScore;
    /// <summary>
    /// Function: GetWeaponScore
    /// </summary>
    public unsafe virtual int GetWeaponScore(BmSDK.BmGame.RGameInfo.WeaponId Weapon, bool bGetLifetimeScore = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWeaponScore, "BmGame.GDProfileSystem.GetWeaponScore");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Weapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGetLifetimeScore, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CheckWeaponScoreInitialised;
    /// <summary>
    /// Function: CheckWeaponScoreInitialised
    /// </summary>
    public unsafe virtual void CheckWeaponScoreInitialised()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckWeaponScoreInitialised, "BmGame.GDProfileSystem.CheckWeaponScoreInitialised");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CommitRecentlyUnlockedItemsToProfile;
    /// <summary>
    /// Function: CommitRecentlyUnlockedItemsToProfile
    /// </summary>
    public unsafe virtual void CommitRecentlyUnlockedItemsToProfile()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CommitRecentlyUnlockedItemsToProfile, "BmGame.GDProfileSystem.CommitRecentlyUnlockedItemsToProfile");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetVideoWatched;
    /// <summary>
    /// Function: SetVideoWatched
    /// </summary>
    public unsafe virtual void SetVideoWatched(BmSDK.FString VideoFilename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetVideoWatched, "BmGame.GDProfileSystem.SetVideoWatched");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VideoFilename, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsVideoWatched;
    /// <summary>
    /// Function: IsVideoWatched
    /// </summary>
    public unsafe virtual bool IsVideoWatched(BmSDK.FString VideoFilename)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsVideoWatched, "BmGame.GDProfileSystem.IsVideoWatched");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VideoFilename, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_AnyUnwatchedVideos;
    /// <summary>
    /// Function: AnyUnwatchedVideos
    /// </summary>
    public unsafe virtual bool AnyUnwatchedVideos()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnyUnwatchedVideos, "BmGame.GDProfileSystem.AnyUnwatchedVideos");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AnythingNew;
    /// <summary>
    /// Function: AnythingNew
    /// </summary>
    public unsafe virtual bool AnythingNew(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnythingNew, "BmGame.GDProfileSystem.AnythingNew");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AnyNewWeapons;
    /// <summary>
    /// Function: AnyNewWeapons
    /// </summary>
    public unsafe virtual bool AnyNewWeapons(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnyNewWeapons, "BmGame.GDProfileSystem.AnyNewWeapons");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AnyNewGadgets;
    /// <summary>
    /// Function: AnyNewGadgets
    /// </summary>
    public unsafe virtual bool AnyNewGadgets(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnyNewGadgets, "BmGame.GDProfileSystem.AnyNewGadgets");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AnyNewAppearances;
    /// <summary>
    /// Function: AnyNewAppearances
    /// </summary>
    public unsafe virtual bool AnyNewAppearances(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnyNewAppearances, "BmGame.GDProfileSystem.AnyNewAppearances");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AnyNewCustType;
    /// <summary>
    /// Function: AnyNewCustType
    /// </summary>
    public unsafe virtual bool AnyNewCustType(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType Type)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnyNewCustType, "BmGame.GDProfileSystem.AnyNewCustType");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AnyNewHeroSkins;
    /// <summary>
    /// Function: AnyNewHeroSkins
    /// </summary>
    public unsafe virtual bool AnyNewHeroSkins(BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter Character)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnyNewHeroSkins, "BmGame.GDProfileSystem.AnyNewHeroSkins");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Character, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ClearRecentlyUnlockedHeroSkin;
    /// <summary>
    /// Function: ClearRecentlyUnlockedHeroSkin
    /// </summary>
    public unsafe virtual void ClearRecentlyUnlockedHeroSkin(BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter Character, int SkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRecentlyUnlockedHeroSkin, "BmGame.GDProfileSystem.ClearRecentlyUnlockedHeroSkin");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Character, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkinIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsHeroSkinRecentlyUnlocked;
    /// <summary>
    /// Function: IsHeroSkinRecentlyUnlocked
    /// </summary>
    public unsafe virtual bool IsHeroSkinRecentlyUnlocked(BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter Character, int SkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsHeroSkinRecentlyUnlocked, "BmGame.GDProfileSystem.IsHeroSkinRecentlyUnlocked");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Character, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkinIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_RecentlyUnlockedHeroSkin;
    /// <summary>
    /// Function: RecentlyUnlockedHeroSkin
    /// </summary>
    public unsafe virtual void RecentlyUnlockedHeroSkin(BmSDK.BmGame.GDCharCustomizationManager.eAltMeshCharacter Character, int SkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecentlyUnlockedHeroSkin, "BmGame.GDProfileSystem.RecentlyUnlockedHeroSkin");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Character, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkinIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearrAllRecentlyUnlockedCustParts;
    /// <summary>
    /// Function: ClearrAllRecentlyUnlockedCustParts
    /// </summary>
    public unsafe virtual void ClearrAllRecentlyUnlockedCustParts(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType Type)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearrAllRecentlyUnlockedCustParts, "BmGame.GDProfileSystem.ClearrAllRecentlyUnlockedCustParts");
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearRecentlyUnlockedCustPart;
    /// <summary>
    /// Function: ClearRecentlyUnlockedCustPart
    /// </summary>
    public unsafe virtual void ClearRecentlyUnlockedCustPart(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType Type, BmSDK.FName ResourceID, int SkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRecentlyUnlockedCustPart, "BmGame.GDProfileSystem.ClearRecentlyUnlockedCustPart");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResourceID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkinIndex, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsCustPartRecentlyUnlocked;
    /// <summary>
    /// Function: IsCustPartRecentlyUnlocked
    /// </summary>
    public unsafe virtual bool IsCustPartRecentlyUnlocked(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType Type, BmSDK.FName ResourceID, int SkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCustPartRecentlyUnlocked, "BmGame.GDProfileSystem.IsCustPartRecentlyUnlocked");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResourceID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkinIndex, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_RecentlyUnlockedCustomizationPart;
    /// <summary>
    /// Function: RecentlyUnlockedCustomizationPart
    /// </summary>
    public unsafe virtual void RecentlyUnlockedCustomizationPart(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team, BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationPartType Type, BmSDK.FName ResourceID, int SkinIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecentlyUnlockedCustomizationPart, "BmGame.GDProfileSystem.RecentlyUnlockedCustomizationPart");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResourceID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkinIndex, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearRecentlyUnlockedWeaponSkin;
    /// <summary>
    /// Function: ClearRecentlyUnlockedWeaponSkin
    /// </summary>
    public unsafe virtual void ClearRecentlyUnlockedWeaponSkin(BmSDK.FName WeaponSkin)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRecentlyUnlockedWeaponSkin, "BmGame.GDProfileSystem.ClearRecentlyUnlockedWeaponSkin");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponSkin, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsWeaponSkinRecentlyUnlocked;
    /// <summary>
    /// Function: IsWeaponSkinRecentlyUnlocked
    /// </summary>
    public unsafe virtual bool IsWeaponSkinRecentlyUnlocked(BmSDK.FName WeaponSkin)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsWeaponSkinRecentlyUnlocked, "BmGame.GDProfileSystem.IsWeaponSkinRecentlyUnlocked");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponSkin, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_RecentlyUnlockedWeaponSkin;
    /// <summary>
    /// Function: RecentlyUnlockedWeaponSkin
    /// </summary>
    public unsafe virtual void RecentlyUnlockedWeaponSkin(BmSDK.FName WeaponSkin)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecentlyUnlockedWeaponSkin, "BmGame.GDProfileSystem.RecentlyUnlockedWeaponSkin");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponSkin, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearRecentlyUnlockedGadget;
    /// <summary>
    /// Function: ClearRecentlyUnlockedGadget
    /// </summary>
    public unsafe virtual void ClearRecentlyUnlockedGadget(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team, BmSDK.FName GadgetName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRecentlyUnlockedGadget, "BmGame.GDProfileSystem.ClearRecentlyUnlockedGadget");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsGadgetRecentlyUnlocked;
    /// <summary>
    /// Function: IsGadgetRecentlyUnlocked
    /// </summary>
    public unsafe virtual bool IsGadgetRecentlyUnlocked(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team, BmSDK.FName GadgetName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsGadgetRecentlyUnlocked, "BmGame.GDProfileSystem.IsGadgetRecentlyUnlocked");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_RecentlyUnlockedGadget;
    /// <summary>
    /// Function: RecentlyUnlockedGadget
    /// </summary>
    public unsafe virtual void RecentlyUnlockedGadget(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team, BmSDK.FName GadgetName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecentlyUnlockedGadget, "BmGame.GDProfileSystem.RecentlyUnlockedGadget");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearRecentlyUnlockedWeapon;
    /// <summary>
    /// Function: ClearRecentlyUnlockedWeapon
    /// </summary>
    public unsafe virtual void ClearRecentlyUnlockedWeapon(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team, BmSDK.FName WeaponName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearRecentlyUnlockedWeapon, "BmGame.GDProfileSystem.ClearRecentlyUnlockedWeapon");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsWeaponRecentlyUnlocked;
    /// <summary>
    /// Function: IsWeaponRecentlyUnlocked
    /// </summary>
    public unsafe virtual bool IsWeaponRecentlyUnlocked(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team, BmSDK.FName WeaponName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsWeaponRecentlyUnlocked, "BmGame.GDProfileSystem.IsWeaponRecentlyUnlocked");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_RecentlyUnlockedWeapon;
    /// <summary>
    /// Function: RecentlyUnlockedWeapon
    /// </summary>
    public unsafe virtual void RecentlyUnlockedWeapon(BmSDK.BmGame.GDCharCustomizationManager.eCharacterCustomizationTeamData Team, BmSDK.FName WeaponName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecentlyUnlockedWeapon, "BmGame.GDProfileSystem.RecentlyUnlockedWeapon");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckRecentlyUnlockedItemsInitialized;
    /// <summary>
    /// Function: CheckRecentlyUnlockedItemsInitialized
    /// </summary>
    public unsafe void CheckRecentlyUnlockedItemsInitialized()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckRecentlyUnlockedItemsInitialized, "BmGame.GDProfileSystem.CheckRecentlyUnlockedItemsInitialized");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PrintAllRecentItems;
    /// <summary>
    /// Function: PrintAllRecentItems
    /// </summary>
    public unsafe virtual void PrintAllRecentItems()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PrintAllRecentItems, "BmGame.GDProfileSystem.PrintAllRecentItems");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetArkhamOnlineRating;
    /// <summary>
    /// Function: GetArkhamOnlineRating
    /// </summary>
    public unsafe virtual int GetArkhamOnlineRating()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetArkhamOnlineRating, "BmGame.GDProfileSystem.GetArkhamOnlineRating");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPrestigeLevel;
    /// <summary>
    /// Function: GetPrestigeLevel
    /// </summary>
    public unsafe virtual int GetPrestigeLevel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPrestigeLevel, "BmGame.GDProfileSystem.GetPrestigeLevel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetPrestigeLevel;
    /// <summary>
    /// Function: SetPrestigeLevel
    /// </summary>
    public unsafe void SetPrestigeLevel(int Level)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPrestigeLevel, "BmGame.GDProfileSystem.SetPrestigeLevel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Level, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetArkhamOnlineRatingFromPrestigeLevel;
    /// <summary>
    /// Function: GetArkhamOnlineRatingFromPrestigeLevel
    /// </summary>
    public unsafe virtual int GetArkhamOnlineRatingFromPrestigeLevel(int PrestigeLevel, int JokerFactionLevel, int BaneFactionLevel, int AccountLevel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetArkhamOnlineRatingFromPrestigeLevel, "BmGame.GDProfileSystem.GetArkhamOnlineRatingFromPrestigeLevel");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PrestigeLevel, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JokerFactionLevel, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BaneFactionLevel, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AccountLevel, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_ClearPrestigeLevel;
    /// <summary>
    /// Function: ClearPrestigeLevel
    /// </summary>
    public unsafe virtual void ClearPrestigeLevel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearPrestigeLevel, "BmGame.GDProfileSystem.ClearPrestigeLevel");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddRecentlyUnlockedPrestigeAwards;
    /// <summary>
    /// Function: AddRecentlyUnlockedPrestigeAwards
    /// </summary>
    public unsafe virtual void AddRecentlyUnlockedPrestigeAwards()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddRecentlyUnlockedPrestigeAwards, "BmGame.GDProfileSystem.AddRecentlyUnlockedPrestigeAwards");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryTriggerPrestige;
    /// <summary>
    /// Function: TryTriggerPrestige
    /// </summary>
    public unsafe virtual bool TryTriggerPrestige()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryTriggerPrestige, "BmGame.GDProfileSystem.TryTriggerPrestige");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsFirstGamePlayed;
    /// <summary>
    /// Function: IsFirstGamePlayed
    /// </summary>
    public unsafe virtual bool IsFirstGamePlayed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFirstGamePlayed, "BmGame.GDProfileSystem.IsFirstGamePlayed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMaxWeaponScoreLevel;
    /// <summary>
    /// Function: GetMaxWeaponScoreLevel
    /// </summary>
    public unsafe virtual int GetMaxWeaponScoreLevel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxWeaponScoreLevel, "BmGame.GDProfileSystem.GetMaxWeaponScoreLevel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsMaxWeaponScoreLevel;
    /// <summary>
    /// Function: IsMaxWeaponScoreLevel
    /// </summary>
    public unsafe virtual bool IsMaxWeaponScoreLevel(BmSDK.BmGame.RGameInfo.WeaponId Weapon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsMaxWeaponScoreLevel, "BmGame.GDProfileSystem.IsMaxWeaponScoreLevel");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Weapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsAllFactionsMaxLevel;
    /// <summary>
    /// Function: IsAllFactionsMaxLevel
    /// </summary>
    public unsafe virtual bool IsAllFactionsMaxLevel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAllFactionsMaxLevel, "BmGame.GDProfileSystem.IsAllFactionsMaxLevel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMaxFactionLevel;
    /// <summary>
    /// Function: GetMaxFactionLevel
    /// </summary>
    public unsafe virtual int GetMaxFactionLevel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxFactionLevel, "BmGame.GDProfileSystem.GetMaxFactionLevel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsMaxLevelFaction;
    /// <summary>
    /// Function: IsMaxLevelFaction
    /// </summary>
    public unsafe virtual bool IsMaxLevelFaction(BmSDK.FString FactionShortName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsMaxLevelFaction, "BmGame.GDProfileSystem.IsMaxLevelFaction");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FactionShortName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetMaxAccountLevel;
    /// <summary>
    /// Function: GetMaxAccountLevel
    /// </summary>
    public unsafe virtual int GetMaxAccountLevel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxAccountLevel, "BmGame.GDProfileSystem.GetMaxAccountLevel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsMaxLevelAccount;
    /// <summary>
    /// Function: IsMaxLevelAccount
    /// </summary>
    public unsafe virtual bool IsMaxLevelAccount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsMaxLevelAccount, "BmGame.GDProfileSystem.IsMaxLevelAccount");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanPrestige;
    /// <summary>
    /// Function: CanPrestige
    /// </summary>
    public unsafe virtual bool CanPrestige()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPrestige, "BmGame.GDProfileSystem.CanPrestige");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AwardCustomisationAchievement;
    /// <summary>
    /// Function: AwardCustomisationAchievement
    /// </summary>
    public unsafe virtual void AwardCustomisationAchievement()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AwardCustomisationAchievement, "BmGame.GDProfileSystem.AwardCustomisationAchievement");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCurrentLoadoutBankData;
    /// <summary>
    /// Function: GetCurrentLoadoutBankData
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.FGDPlayerLoadout GetCurrentLoadoutBankData(BmSDK.BmGame.RGameInfo.ELoadoutTeamId LoadoutTeam, bool bIgnoreFactionLeader = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentLoadoutBankData, "BmGame.GDProfileSystem.GetCurrentLoadoutBankData");
        byte* paramsPtr = stackalloc byte[276];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadoutTeam, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreFactionLeader, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.FGDPlayerLoadout>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetLoadoutBankData;
    /// <summary>
    /// Function: GetLoadoutBankData
    /// </summary>
    public unsafe virtual void GetLoadoutBankData(BmSDK.BmGame.RGameInfo.ELoadoutTeamId LoadoutTeam, int LoadoutBankIndex, out BmSDK.BmGame.RGameInfo.FGDPlayerLoadout PlayerLoadout)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLoadoutBankData, "BmGame.GDProfileSystem.GetLoadoutBankData");
        byte* paramsPtr = stackalloc byte[136];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadoutTeam, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadoutBankIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PlayerLoadout = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.FGDPlayerLoadout>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_SetLoadoutBankData;
    /// <summary>
    /// Function: SetLoadoutBankData
    /// </summary>
    public unsafe virtual void SetLoadoutBankData(BmSDK.BmGame.RGameInfo.ELoadoutTeamId LoadoutTeam, int LoadoutBankIndex, in BmSDK.BmGame.RGameInfo.FGDPlayerLoadout PlayerLoadout)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLoadoutBankData, "BmGame.GDProfileSystem.SetLoadoutBankData");
        byte* paramsPtr = stackalloc byte[136];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadoutTeam, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadoutBankIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLoadout, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCurrentLoadoutBankData;
    /// <summary>
    /// Function: SetCurrentLoadoutBankData
    /// </summary>
    public unsafe virtual void SetCurrentLoadoutBankData(BmSDK.BmGame.RGameInfo.ELoadoutTeamId LoadoutTeam, in BmSDK.BmGame.RGameInfo.FGDPlayerLoadout PlayerLoadout)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentLoadoutBankData, "BmGame.GDProfileSystem.SetCurrentLoadoutBankData");
        byte* paramsPtr = stackalloc byte[133];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadoutTeam, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLoadout, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNumLoadouts;
    /// <summary>
    /// Function: GetNumLoadouts
    /// </summary>
    public unsafe virtual int GetNumLoadouts(BmSDK.BmGame.RGameInfo.ELoadoutTeamId LoadoutTeam)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumLoadouts, "BmGame.GDProfileSystem.GetNumLoadouts");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadoutTeam, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_LoadLocalLoadoutData;
    /// <summary>
    /// Function: LoadLocalLoadoutData
    /// </summary>
    public unsafe virtual bool LoadLocalLoadoutData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadLocalLoadoutData, "BmGame.GDProfileSystem.LoadLocalLoadoutData");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SaveLocalLoadoutData;
    /// <summary>
    /// Function: SaveLocalLoadoutData
    /// </summary>
    public unsafe virtual void SaveLocalLoadoutData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SaveLocalLoadoutData, "BmGame.GDProfileSystem.SaveLocalLoadoutData");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_GetCustomizableLoadoutTeamFromLoadoutTeamId;
    /// <summary>
    /// Function: GetCustomizableLoadoutTeamFromLoadoutTeamId
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDProfileSystem.eCustomizableLoadoutTeam GetCustomizableLoadoutTeamFromLoadoutTeamId(BmSDK.BmGame.RGameInfo.ELoadoutTeamId LoadoutTeam)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCustomizableLoadoutTeamFromLoadoutTeamId, "BmGame.GDProfileSystem.GetCustomizableLoadoutTeamFromLoadoutTeamId");
        byte* paramsPtr = stackalloc byte[19];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadoutTeam, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDProfileSystem.eCustomizableLoadoutTeam>(paramsPtr + 1);
    }

    private static BmSDK.Function __fn_GetCurrentLoadoutBankIndex;
    /// <summary>
    /// Function: GetCurrentLoadoutBankIndex
    /// </summary>
    public unsafe virtual int GetCurrentLoadoutBankIndex(BmSDK.BmGame.RGameInfo.ELoadoutTeamId LoadoutTeam)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentLoadoutBankIndex, "BmGame.GDProfileSystem.GetCurrentLoadoutBankIndex");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadoutTeam, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetCurrentLoadoutBankIndex;
    /// <summary>
    /// Function: SetCurrentLoadoutBankIndex
    /// </summary>
    public unsafe virtual void SetCurrentLoadoutBankIndex(BmSDK.BmGame.RGameInfo.ELoadoutTeamId LoadoutTeam, int LoadoutBankIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentLoadoutBankIndex, "BmGame.GDProfileSystem.SetCurrentLoadoutBankIndex");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadoutTeam, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadoutBankIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitLoadoutBanks;
    /// <summary>
    /// Function: InitLoadoutBanks
    /// </summary>
    public unsafe virtual void InitLoadoutBanks()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitLoadoutBanks, "BmGame.GDProfileSystem.InitLoadoutBanks");
        byte* paramsPtr = stackalloc byte[252];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetSkillSearchParams;
    /// <summary>
    /// Function: GetSkillSearchParams
    /// </summary>
    public unsafe virtual void GetSkillSearchParams(out float SkillSpeed, out float SkillSpeedMax, out float SkillAccel, out float SkillMin, out float SkillMax, out int NumTriesSameSkill, out float TimeoutSearch, out float TimeoutJoin, out float SearchRequestThrottleTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSkillSearchParams, "BmGame.GDProfileSystem.GetSkillSearchParams");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SkillSpeed);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkillSpeed, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SkillSpeedMax);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkillSpeedMax, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SkillAccel);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkillAccel, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SkillMin);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkillMin, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SkillMax);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkillMax, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NumTriesSameSkill);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumTriesSameSkill, paramsPtr + 20);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TimeoutSearch);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeoutSearch, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out TimeoutJoin);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeoutJoin, paramsPtr + 28);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out SearchRequestThrottleTime);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchRequestThrottleTime, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SkillSpeed = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        SkillSpeedMax = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        SkillAccel = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        SkillMin = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
        SkillMax = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 16);
        NumTriesSameSkill = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
        TimeoutSearch = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 24);
        TimeoutJoin = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 28);
        SearchRequestThrottleTime = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 32);
        return;
    }

    private static BmSDK.Function __fn_DumpMatchmakingData;
    /// <summary>
    /// Function: DumpMatchmakingData
    /// </summary>
    public unsafe virtual void DumpMatchmakingData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpMatchmakingData, "BmGame.GDProfileSystem.DumpMatchmakingData");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCurrentSkill;
    /// <summary>
    /// Function: GetCurrentSkill
    /// </summary>
    public unsafe virtual int GetCurrentSkill()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentSkill, "BmGame.GDProfileSystem.GetCurrentSkill");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_MatchFinished;
    /// <summary>
    /// Function: MatchFinished
    /// </summary>
    public unsafe virtual void MatchFinished(bool WonMatch)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MatchFinished, "BmGame.GDProfileSystem.MatchFinished");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WonMatch, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MatchStarted;
    /// <summary>
    /// Function: MatchStarted
    /// </summary>
    public unsafe virtual void MatchStarted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MatchStarted, "BmGame.GDProfileSystem.MatchStarted");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckProgressionSharedSettingsUnlocks;
    /// <summary>
    /// Function: CheckProgressionSharedSettingsUnlocks
    /// </summary>
    public unsafe virtual void CheckProgressionSharedSettingsUnlocks()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckProgressionSharedSettingsUnlocks, "BmGame.GDProfileSystem.CheckProgressionSharedSettingsUnlocks");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadLocalMatchmakingData;
    /// <summary>
    /// Function: LoadLocalMatchmakingData
    /// </summary>
    public unsafe virtual bool LoadLocalMatchmakingData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadLocalMatchmakingData, "BmGame.GDProfileSystem.LoadLocalMatchmakingData");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SaveLocalMatchmakingData;
    /// <summary>
    /// Function: SaveLocalMatchmakingData
    /// </summary>
    public unsafe virtual void SaveLocalMatchmakingData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SaveLocalMatchmakingData, "BmGame.GDProfileSystem.SaveLocalMatchmakingData");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_CreateSaveGameDescription;
    /// <summary>
    /// Function: CreateSaveGameDescription
    /// </summary>
    public unsafe override void CreateSaveGameDescription()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateSaveGameDescription, "BmGame.GDProfileSystem.CreateSaveGameDescription");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateSaveGameDetails;
    /// <summary>
    /// Function: CreateSaveGameDetails
    /// </summary>
    public unsafe virtual void CreateSaveGameDetails(int ArkhamRating)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateSaveGameDetails, "BmGame.GDProfileSystem.CreateSaveGameDetails");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArkhamRating, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetMatchmakingServerAvgUpBandwidth;
    /// <summary>
    /// Function: GetMatchmakingServerAvgUpBandwidth
    /// </summary>
    public unsafe override int GetMatchmakingServerAvgUpBandwidth()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMatchmakingServerAvgUpBandwidth, "BmGame.GDProfileSystem.GetMatchmakingServerAvgUpBandwidth");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InternalAddMatchmakingServerQosData;
    /// <summary>
    /// Function: InternalAddMatchmakingServerQosData
    /// </summary>
    public unsafe override void InternalAddMatchmakingServerQosData(int UpBandwidth, int DownBandwidth)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InternalAddMatchmakingServerQosData, "BmGame.GDProfileSystem.InternalAddMatchmakingServerQosData");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpBandwidth, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DownBandwidth, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SaveProfile;
    /// <summary>
    /// Function: SaveProfile
    /// </summary>
    public unsafe virtual void SaveProfile()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SaveProfile, "BmGame.GDProfileSystem.SaveProfile");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SaveCustomData;
    /// <summary>
    /// Function: SaveCustomData
    /// </summary>
    public unsafe override void SaveCustomData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SaveCustomData, "BmGame.GDProfileSystem.SaveCustomData");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProfileLoaded;
    /// <summary>
    /// Function: ProfileLoaded
    /// </summary>
    public unsafe virtual void ProfileLoaded(int LocalPlayerNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProfileLoaded, "BmGame.GDProfileSystem.ProfileLoaded");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalPlayerNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitCachedWeaponScores;
    /// <summary>
    /// Function: InitCachedWeaponScores
    /// </summary>
    public unsafe virtual void InitCachedWeaponScores()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitCachedWeaponScores, "BmGame.GDProfileSystem.InitCachedWeaponScores");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Cleanup;
    /// <summary>
    /// Function: Cleanup
    /// </summary>
    public unsafe override void Cleanup()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Cleanup, "BmGame.GDProfileSystem.Cleanup");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Initialise;
    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe override void Initialise()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Initialise, "BmGame.GDProfileSystem.Initialise");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// IntProperty: CachedPlayerNum
    /// </summary>
    public unsafe int CachedPlayerNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ObjectProperty: CachedWeaponScores
    /// </summary>
    public unsafe BmSDK.BmGame.GDWeaponScoreProfileStorage CachedWeaponScores
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDWeaponScoreProfileStorage>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// BoolProperty: CachedWeaponScoresInitialised
    /// </summary>
    public unsafe bool CachedWeaponScoresInitialised
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: CachedRecentlyUnlockedItemsInitialized
    /// </summary>
    public unsafe bool CachedRecentlyUnlockedItemsInitialized
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// ObjectProperty: CachedRecentlyUnlockedItems
    /// </summary>
    public unsafe BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage CachedRecentlyUnlockedItems
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDRecentlyUnlockedItemsProfileStorage>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// ObjectProperty: LoadoutData
    /// </summary>
    public unsafe BmSDK.BmGame.GDProfileSystemLoadoutData LoadoutData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDProfileSystemLoadoutData>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ObjectProperty: MatchmakingData
    /// </summary>
    public unsafe BmSDK.BmGame.GDProfileSystemMatchmakingData MatchmakingData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDProfileSystemMatchmakingData>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// NameProperty: Key_Suffix_Team
    /// </summary>
    public unsafe BmSDK.FName Key_Suffix_Team
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// NameProperty: Key_Suffix_Weapon
    /// </summary>
    public unsafe BmSDK.FName Key_Suffix_Weapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// NameProperty: Key_Suffix_DpadL
    /// </summary>
    public unsafe BmSDK.FName Key_Suffix_DpadL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// NameProperty: Key_Suffix_DpadR
    /// </summary>
    public unsafe BmSDK.FName Key_Suffix_DpadR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// NameProperty: Key_Suffix_DpadLUpgradeIdx
    /// </summary>
    public unsafe BmSDK.FName Key_Suffix_DpadLUpgradeIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// NameProperty: Key_Suffix_DpadRUpgradeIdx
    /// </summary>
    public unsafe BmSDK.FName Key_Suffix_DpadRUpgradeIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// NameProperty: Key_Suffix_CharId
    /// </summary>
    public unsafe BmSDK.FName Key_Suffix_CharId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// NameProperty: Key_RecentlyUnlocked
    /// </summary>
    public unsafe BmSDK.FName Key_RecentlyUnlocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// NameProperty: Key_XPAccount
    /// </summary>
    public unsafe BmSDK.FName Key_XPAccount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// NameProperty: Key_XPAccountLevel
    /// </summary>
    public unsafe BmSDK.FName Key_XPAccountLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// NameProperty: Key_XPAccountPrevUpgrade
    /// </summary>
    public unsafe BmSDK.FName Key_XPAccountPrevUpgrade
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// NameProperty: Key_XPAccountNextUpgrade
    /// </summary>
    public unsafe BmSDK.FName Key_XPAccountNextUpgrade
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// NameProperty: Key_Suffix_XPAccount
    /// </summary>
    public unsafe BmSDK.FName Key_Suffix_XPAccount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// NameProperty: Key_Suffix_XPAccountLevel
    /// </summary>
    public unsafe BmSDK.FName Key_Suffix_XPAccountLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// NameProperty: Key_Suffix_XPAccountPrevUpgrade
    /// </summary>
    public unsafe BmSDK.FName Key_Suffix_XPAccountPrevUpgrade
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// NameProperty: Key_Suffix_XPAccountNextUpgrade
    /// </summary>
    public unsafe BmSDK.FName Key_Suffix_XPAccountNextUpgrade
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// NameProperty: Key_PrestigeLevel
    /// </summary>
    public unsafe BmSDK.FName Key_PrestigeLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// NameProperty: Key_WeaponScores
    /// </summary>
    public unsafe BmSDK.FName Key_WeaponScores
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// NameProperty: Key_PreferredFaction
    /// </summary>
    public unsafe BmSDK.FName Key_PreferredFaction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// NameProperty: Key_WeaponAutoSwitch
    /// </summary>
    public unsafe BmSDK.FName Key_WeaponAutoSwitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// NameProperty: Key_RoundsSinceHero
    /// </summary>
    public unsafe BmSDK.FName Key_RoundsSinceHero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// NameProperty: Key_HeroOptOut
    /// </summary>
    public unsafe BmSDK.FName Key_HeroOptOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// NameProperty: Key_MapRoundWin
    /// </summary>
    public unsafe BmSDK.FName Key_MapRoundWin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// NameProperty: Key_HeroKillsOnElites
    /// </summary>
    public unsafe BmSDK.FName Key_HeroKillsOnElites
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// NameProperty: Key_EliteKillsOnHeroes
    /// </summary>
    public unsafe BmSDK.FName Key_EliteKillsOnHeroes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// NameProperty: Key_TriggerFlip
    /// </summary>
    public unsafe BmSDK.FName Key_TriggerFlip
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// NameProperty: Key_LeftyFlip
    /// </summary>
    public unsafe BmSDK.FName Key_LeftyFlip
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// NameProperty: Key_SpTrophyRobin
    /// </summary>
    public unsafe BmSDK.FName Key_SpTrophyRobin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// ArrayProperty: AccountXPCurve
    /// </summary>
    public unsafe BmSDK.TArray<float> AccountXPCurve
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// ArrayProperty: JokerXPCurve
    /// </summary>
    public unsafe BmSDK.TArray<float> JokerXPCurve
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// ArrayProperty: BaneXPCurve
    /// </summary>
    public unsafe BmSDK.TArray<float> BaneXPCurve
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// ArrayProperty: WeaponUpgradeScoreCurve
    /// </summary>
    public unsafe BmSDK.TArray<float> WeaponUpgradeScoreCurve
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// ArrayProperty: MapNamesForAchievement
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> MapNamesForAchievement
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// ArrayProperty: TeamsForAchievement
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDGIBase.ETeamType> TeamsForAchievement
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDGIBase.ETeamType>>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// Enum: eCustomizableLoadoutTeam
    /// </summary>
    public enum eCustomizableLoadoutTeam : byte
    {
        eCustomizableLoadoutTeam_Joker = 0,
        eCustomizableLoadoutTeam_Bane = 1,
        eCustomizableLoadoutTeam_MAX = 2,
    }
}
