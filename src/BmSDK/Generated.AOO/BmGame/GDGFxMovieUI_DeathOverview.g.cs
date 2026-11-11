#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDGFxMovieUI_DeathOverview<br/>
/// (size = 1976)
/// (flags = 32786)
/// </summary>
public partial class GDGFxMovieUI_DeathOverview : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDGFxMovieUI_DeathOverview", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDGFxMovieUI_DeathOverview.
    /// </summary>
    public static GDGFxMovieUI_DeathOverview DefaultObject => (GDGFxMovieUI_DeathOverview)StaticClass().DefaultObject;

    internal GDGFxMovieUI_DeathOverview() { }

    /// <summary>
    /// Constructs a new GDGFxMovieUI_DeathOverview
    /// </summary>
    public GDGFxMovieUI_DeathOverview(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDGFxMovieUI_DeathOverview Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDGFxMovieUI_DeathOverview(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_DeathOverview>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_DeathOverview>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_DeathOverview>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_DeathOverview>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_DeathOverview>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_DeathOverview>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_DeathOverview>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_DeathOverview>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_UpdateRespawnTimer;
    /// <summary>
    /// Function: UpdateRespawnTimer
    /// </summary>
    public unsafe virtual void UpdateRespawnTimer(float _fraction, int _second)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateRespawnTimer, "BmGame.GDGFxMovieUI_DeathOverview.UpdateRespawnTimer");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_fraction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_second, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleCannotRespawnMessage;
    /// <summary>
    /// Function: ToggleCannotRespawnMessage
    /// </summary>
    public unsafe virtual void ToggleCannotRespawnMessage(bool _vis)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleCannotRespawnMessage, "BmGame.GDGFxMovieUI_DeathOverview.ToggleCannotRespawnMessage");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_vis, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ToggleNoTicketsMessage;
    /// <summary>
    /// Function: ToggleNoTicketsMessage
    /// </summary>
    public unsafe virtual void ToggleNoTicketsMessage(bool _vis)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ToggleNoTicketsMessage, "BmGame.GDGFxMovieUI_DeathOverview.ToggleNoTicketsMessage");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_vis, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetToolTipText;
    /// <summary>
    /// Function: SetToolTipText
    /// </summary>
    public unsafe void SetToolTipText(BmSDK.FString _toolTip)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetToolTipText, "BmGame.GDGFxMovieUI_DeathOverview.SetToolTipText");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_toolTip, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPageTitle;
    /// <summary>
    /// Function: SetPageTitle
    /// </summary>
    public unsafe virtual void SetPageTitle(BmSDK.FString _title)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPageTitle, "BmGame.GDGFxMovieUI_DeathOverview.SetPageTitle");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_title, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetToTakedownMovie;
    /// <summary>
    /// Function: SetToTakedownMovie
    /// </summary>
    public unsafe virtual void SetToTakedownMovie(int _team)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetToTakedownMovie, "BmGame.GDGFxMovieUI_DeathOverview.SetToTakedownMovie");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_team, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetKillerAbility;
    /// <summary>
    /// Function: SetKillerAbility
    /// </summary>
    public unsafe virtual void SetKillerAbility(int _item, BmSDK.FString _abilityIconPackage, BmSDK.FString _ability, int _version)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetKillerAbility, "BmGame.GDGFxMovieUI_DeathOverview.SetKillerAbility");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_item, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_abilityIconPackage, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ability, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_version, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetKillerHealthAndWeapon;
    /// <summary>
    /// Function: SetKillerHealthAndWeapon
    /// </summary>
    public unsafe virtual void SetKillerHealthAndWeapon(int _health, BmSDK.FString _weapon, BmSDK.FString _ammo, BmSDK.FString _weaponPackageName, BmSDK.FString _weaponName, BmSDK.FString _weaponLevel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetKillerHealthAndWeapon, "BmGame.GDGFxMovieUI_DeathOverview.SetKillerHealthAndWeapon");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_health, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_weapon, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ammo, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_weaponPackageName, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_weaponName, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_weaponLevel, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetConsumableUsed;
    /// <summary>
    /// Function: SetConsumableUsed
    /// </summary>
    public unsafe virtual void SetConsumableUsed(BmSDK.FString consumableIconPackage, BmSDK.FString consumableIcon, BmSDK.FString ConsumableTitle, BmSDK.FString consumableText)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetConsumableUsed, "BmGame.GDGFxMovieUI_DeathOverview.SetConsumableUsed");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(consumableIconPackage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(consumableIcon, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConsumableTitle, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(consumableText, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetKillerLevels;
    /// <summary>
    /// Function: SetKillerLevels
    /// </summary>
    public unsafe virtual void SetKillerLevels(int _account, BmSDK.FString _accountName, int _gang, BmSDK.FString _gangName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetKillerLevels, "BmGame.GDGFxMovieUI_DeathOverview.SetKillerLevels");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_account, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_accountName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_gang, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_gangName, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetKillerAOR;
    /// <summary>
    /// Function: SetKillerAOR
    /// </summary>
    public unsafe virtual void SetKillerAOR(int _AOR)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetKillerAOR, "BmGame.GDGFxMovieUI_DeathOverview.SetKillerAOR");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_AOR, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetKillerName;
    /// <summary>
    /// Function: SetKillerName
    /// </summary>
    public unsafe virtual void SetKillerName(BmSDK.FString _nick)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetKillerName, "BmGame.GDGFxMovieUI_DeathOverview.SetKillerName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_nick, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateLimbPosition;
    /// <summary>
    /// Function: UpdateLimbPosition
    /// </summary>
    public unsafe virtual void UpdateLimbPosition(BmSDK.FString _limb, int _newX, int _newY)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateLimbPosition, "BmGame.GDGFxMovieUI_DeathOverview.UpdateLimbPosition");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_limb, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_newX, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_newY, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLimbDamage;
    /// <summary>
    /// Function: SetLimbDamage
    /// </summary>
    public unsafe virtual void SetLimbDamage(BmSDK.FString _limb, int _percent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLimbDamage, "BmGame.GDGFxMovieUI_DeathOverview.SetLimbDamage");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_limb, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_percent, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetKillerTeam;
    /// <summary>
    /// Function: SetKillerTeam
    /// </summary>
    public unsafe virtual void SetKillerTeam(int _team, BmSDK.FString KillerIconFrameName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetKillerTeam, "BmGame.GDGFxMovieUI_DeathOverview.SetKillerTeam");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KillerIconFrameName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMyTeam;
    /// <summary>
    /// Function: SetMyTeam
    /// </summary>
    public unsafe virtual void SetMyTeam(int _team)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMyTeam, "BmGame.GDGFxMovieUI_DeathOverview.SetMyTeam");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_team, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoSpectateCameraHud;
    /// <summary>
    /// Function: GotoSpectateCameraHud
    /// </summary>
    public unsafe virtual void GotoSpectateCameraHud()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoSpectateCameraHud, "BmGame.GDGFxMovieUI_DeathOverview.GotoSpectateCameraHud");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoSpectatorHud;
    /// <summary>
    /// Function: GotoSpectatorHud
    /// </summary>
    public unsafe virtual void GotoSpectatorHud(BmSDK.FString PlayerName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoSpectatorHud, "BmGame.GDGFxMovieUI_DeathOverview.GotoSpectatorHud");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowMessage;
    /// <summary>
    /// Function: ShowMessage
    /// </summary>
    public unsafe virtual void ShowMessage(BmSDK.FString Message, BmSDK.FString secondLineMessageText, bool gotoNextScreen)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowMessage, "BmGame.GDGFxMovieUI_DeathOverview.ShowMessage");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(secondLineMessageText, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(gotoNextScreen, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowDeathOverview;
    /// <summary>
    /// Function: ShowDeathOverview
    /// </summary>
    public unsafe virtual void ShowDeathOverview()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowDeathOverview, "BmGame.GDGFxMovieUI_DeathOverview.ShowDeathOverview");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RequestTickData;
    /// <summary>
    /// Function: RequestTickData
    /// </summary>
    public unsafe virtual void RequestTickData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestTickData, "BmGame.GDGFxMovieUI_DeathOverview.RequestTickData");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RequestKillerData;
    /// <summary>
    /// Function: RequestKillerData
    /// </summary>
    public unsafe virtual void RequestKillerData(BmSDK.FString TargetPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestKillerData, "BmGame.GDGFxMovieUI_DeathOverview.RequestKillerData");
        byte* paramsPtr = stackalloc byte[144];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MovieInitialized;
    /// <summary>
    /// Function: MovieInitialized
    /// </summary>
    public unsafe virtual void MovieInitialized(BmSDK.FString TargetPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MovieInitialized, "BmGame.GDGFxMovieUI_DeathOverview.MovieInitialized");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RequestSpectatorData;
    /// <summary>
    /// Function: RequestSpectatorData
    /// </summary>
    public unsafe virtual void RequestSpectatorData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestSpectatorData, "BmGame.GDGFxMovieUI_DeathOverview.RequestSpectatorData");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DeathOverviewButtonPress;
    /// <summary>
    /// Function: DeathOverviewButtonPress
    /// </summary>
    public unsafe virtual void DeathOverviewButtonPress(BmSDK.FString ButtonId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DeathOverviewButtonPress, "BmGame.GDGFxMovieUI_DeathOverview.DeathOverviewButtonPress");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RequestCloseDeathOverview;
    /// <summary>
    /// Function: RequestCloseDeathOverview
    /// </summary>
    public unsafe virtual void RequestCloseDeathOverview()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestCloseDeathOverview, "BmGame.GDGFxMovieUI_DeathOverview.RequestCloseDeathOverview");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawHUD;
    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe virtual void DrawHUD(BmSDK.Engine.HUD H)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawHUD, "BmGame.GDGFxMovieUI_DeathOverview.DrawHUD");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAvatarFromName;
    /// <summary>
    /// Function: GetAvatarFromName
    /// </summary>
    public unsafe virtual BmSDK.FString GetAvatarFromName(BmSDK.FString _name)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAvatarFromName, "BmGame.GDGFxMovieUI_DeathOverview.GetAvatarFromName");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_name, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CalculateLimbDamage;
    /// <summary>
    /// Function: CalculateLimbDamage
    /// </summary>
    public unsafe virtual void CalculateLimbDamage(BmSDK.BmGame.RPlayerController MyPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateLimbDamage, "BmGame.GDGFxMovieUI_DeathOverview.CalculateLimbDamage");
        byte* paramsPtr = stackalloc byte[208];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MyPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBodyPart;
    /// <summary>
    /// Function: GetBodyPart
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDGFxMovieUI_DeathOverview.DeathOverviewBodyParts GetBodyPart(BmSDK.BmGame.RGameInfo.RecordedShotLocations _location)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBodyPart, "BmGame.GDGFxMovieUI_DeathOverview.GetBodyPart");
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_location, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDGFxMovieUI_DeathOverview.DeathOverviewBodyParts>(paramsPtr + 1);
    }

    private static BmSDK.Function __fn_SetupScreenPrompts;
    /// <summary>
    /// Function: SetupScreenPrompts
    /// </summary>
    public unsafe override void SetupScreenPrompts()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupScreenPrompts, "BmGame.GDGFxMovieUI_DeathOverview.SetupScreenPrompts");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowSpectatorHud;
    /// <summary>
    /// Function: ShowSpectatorHud
    /// </summary>
    public unsafe virtual void ShowSpectatorHud()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowSpectatorHud, "BmGame.GDGFxMovieUI_DeathOverview.ShowSpectatorHud");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideOverview;
    /// <summary>
    /// Function: HideOverview
    /// </summary>
    public unsafe virtual void HideOverview()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideOverview, "BmGame.GDGFxMovieUI_DeathOverview.HideOverview");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowOverview;
    /// <summary>
    /// Function: ShowOverview
    /// </summary>
    public unsafe virtual void ShowOverview()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowOverview, "BmGame.GDGFxMovieUI_DeathOverview.ShowOverview");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.GDGFxMovieUI_DeathOverview.Init");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// InlineArray{ByteProperty}: BodyPartMappings
    /// </summary>
    public InlineArray<BmSDK.BmGame.GDGFxMovieUI_DeathOverview.DeathOverviewBodyParts> BodyPartMappings => new(11, Ptr + 1708, 1, this);

    /// <summary>
    /// ByteProperty: BodyPartMappings
    /// </summary>
    public unsafe BmSDK.BmGame.GDGFxMovieUI_DeathOverview.DeathOverviewBodyParts BodyPartMappings_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGFxMovieUI_DeathOverview.DeathOverviewBodyParts>(Ptr + 1708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1708); }
    }
    /// <summary>
    /// ByteProperty: BodyPartMappings
    /// </summary>
    public unsafe BmSDK.BmGame.GDGFxMovieUI_DeathOverview.DeathOverviewBodyParts BodyPartMappings_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGFxMovieUI_DeathOverview.DeathOverviewBodyParts>(Ptr + 1709); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1709); }
    }
    /// <summary>
    /// ByteProperty: BodyPartMappings
    /// </summary>
    public unsafe BmSDK.BmGame.GDGFxMovieUI_DeathOverview.DeathOverviewBodyParts BodyPartMappings_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGFxMovieUI_DeathOverview.DeathOverviewBodyParts>(Ptr + 1710); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1710); }
    }
    /// <summary>
    /// ByteProperty: BodyPartMappings
    /// </summary>
    public unsafe BmSDK.BmGame.GDGFxMovieUI_DeathOverview.DeathOverviewBodyParts BodyPartMappings_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGFxMovieUI_DeathOverview.DeathOverviewBodyParts>(Ptr + 1711); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1711); }
    }
    /// <summary>
    /// ByteProperty: BodyPartMappings
    /// </summary>
    public unsafe BmSDK.BmGame.GDGFxMovieUI_DeathOverview.DeathOverviewBodyParts BodyPartMappings_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGFxMovieUI_DeathOverview.DeathOverviewBodyParts>(Ptr + 1712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1712); }
    }
    /// <summary>
    /// ByteProperty: BodyPartMappings
    /// </summary>
    public unsafe BmSDK.BmGame.GDGFxMovieUI_DeathOverview.DeathOverviewBodyParts BodyPartMappings_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGFxMovieUI_DeathOverview.DeathOverviewBodyParts>(Ptr + 1713); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1713); }
    }
    /// <summary>
    /// ByteProperty: BodyPartMappings
    /// </summary>
    public unsafe BmSDK.BmGame.GDGFxMovieUI_DeathOverview.DeathOverviewBodyParts BodyPartMappings_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGFxMovieUI_DeathOverview.DeathOverviewBodyParts>(Ptr + 1714); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1714); }
    }
    /// <summary>
    /// ByteProperty: BodyPartMappings
    /// </summary>
    public unsafe BmSDK.BmGame.GDGFxMovieUI_DeathOverview.DeathOverviewBodyParts BodyPartMappings_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGFxMovieUI_DeathOverview.DeathOverviewBodyParts>(Ptr + 1715); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1715); }
    }
    /// <summary>
    /// ByteProperty: BodyPartMappings
    /// </summary>
    public unsafe BmSDK.BmGame.GDGFxMovieUI_DeathOverview.DeathOverviewBodyParts BodyPartMappings_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGFxMovieUI_DeathOverview.DeathOverviewBodyParts>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }
    /// <summary>
    /// ByteProperty: BodyPartMappings
    /// </summary>
    public unsafe BmSDK.BmGame.GDGFxMovieUI_DeathOverview.DeathOverviewBodyParts BodyPartMappings_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGFxMovieUI_DeathOverview.DeathOverviewBodyParts>(Ptr + 1717); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1717); }
    }
    /// <summary>
    /// ByteProperty: BodyPartMappings
    /// </summary>
    public unsafe BmSDK.BmGame.GDGFxMovieUI_DeathOverview.DeathOverviewBodyParts BodyPartMappings_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGFxMovieUI_DeathOverview.DeathOverviewBodyParts>(Ptr + 1718); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1718); }
    }

    /// <summary>
    /// StrProperty: MovieTargetPath
    /// </summary>
    public unsafe BmSDK.FString MovieTargetPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }
    }

    /// <summary>
    /// InlineArray{StrProperty}: LimbNames
    /// </summary>
    public InlineArray<BmSDK.FString> LimbNames => new(6, Ptr + 1732, 12, this);

    /// <summary>
    /// StrProperty: LimbNames
    /// </summary>
    public unsafe BmSDK.FString LimbNames_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1732); }
    }
    /// <summary>
    /// StrProperty: LimbNames
    /// </summary>
    public unsafe BmSDK.FString LimbNames_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1744); }
    }
    /// <summary>
    /// StrProperty: LimbNames
    /// </summary>
    public unsafe BmSDK.FString LimbNames_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1756); }
    }
    /// <summary>
    /// StrProperty: LimbNames
    /// </summary>
    public unsafe BmSDK.FString LimbNames_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1768); }
    }
    /// <summary>
    /// StrProperty: LimbNames
    /// </summary>
    public unsafe BmSDK.FString LimbNames_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1780); }
    }
    /// <summary>
    /// StrProperty: LimbNames
    /// </summary>
    public unsafe BmSDK.FString LimbNames_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1792); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: BoneNames
    /// </summary>
    public InlineArray<BmSDK.FName> BoneNames => new(6, Ptr + 1804, 8, this);

    /// <summary>
    /// NameProperty: BoneNames
    /// </summary>
    public unsafe BmSDK.FName BoneNames_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1804); }
    }
    /// <summary>
    /// NameProperty: BoneNames
    /// </summary>
    public unsafe BmSDK.FName BoneNames_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1812); }
    }
    /// <summary>
    /// NameProperty: BoneNames
    /// </summary>
    public unsafe BmSDK.FName BoneNames_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1820); }
    }
    /// <summary>
    /// NameProperty: BoneNames
    /// </summary>
    public unsafe BmSDK.FName BoneNames_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1828); }
    }
    /// <summary>
    /// NameProperty: BoneNames
    /// </summary>
    public unsafe BmSDK.FName BoneNames_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1836); }
    }
    /// <summary>
    /// NameProperty: BoneNames
    /// </summary>
    public unsafe BmSDK.FName BoneNames_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1844); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: ScreenPositions
    /// </summary>
    public InlineArray<System.Numerics.Vector3> ScreenPositions => new(6, Ptr + 1852, 12, this);

    /// <summary>
    /// StructProperty: ScreenPositions
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ScreenPositions_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1852);
    /// <summary>
    /// StructProperty: ScreenPositions
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ScreenPositions_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1864);
    /// <summary>
    /// StructProperty: ScreenPositions
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ScreenPositions_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1876);
    /// <summary>
    /// StructProperty: ScreenPositions
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ScreenPositions_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1888);
    /// <summary>
    /// StructProperty: ScreenPositions
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ScreenPositions_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1900);
    /// <summary>
    /// StructProperty: ScreenPositions
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ScreenPositions_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1912);

    /// <summary>
    /// ArrayProperty: Limbs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_DeathOverview.FLimbDamage> Limbs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_DeathOverview.FLimbDamage>>(Ptr + 1924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1924); }
    }

    /// <summary>
    /// BoolProperty: IsVisible
    /// </summary>
    public unsafe bool IsVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1936) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1936); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1936); }
    }

    /// <summary>
    /// BoolProperty: IsSpectatorHud
    /// </summary>
    public unsafe bool IsSpectatorHud
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1936) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1936); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1936); }
    }

    /// <summary>
    /// BoolProperty: LastGotoNextScreen
    /// </summary>
    public unsafe bool LastGotoNextScreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1936) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1936); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1936); }
    }

    /// <summary>
    /// ObjectProperty: PlayerPawn
    /// </summary>
    public unsafe BmSDK.Engine.Pawn PlayerPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 1940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1940); }
    }

    /// <summary>
    /// IntProperty: MaxDamageCausers
    /// </summary>
    public unsafe int MaxDamageCausers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1944); }
    }

    /// <summary>
    /// IntProperty: CachedRespawnTime
    /// </summary>
    public unsafe int CachedRespawnTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1948); }
    }

    /// <summary>
    /// StrProperty: LastMessageToShow
    /// </summary>
    public unsafe BmSDK.FString LastMessageToShow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1952); }
    }

    /// <summary>
    /// StrProperty: LastSecondLineMessageText
    /// </summary>
    public unsafe BmSDK.FString LastSecondLineMessageText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1964); }
    }

    /// <summary>
    /// Struct: FLimbDamage
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 108)]
    public partial record struct FLimbDamage
    {
        /// <summary>
        /// ByteProperty: HitLoc
        /// </summary>
        public unsafe BmSDK.BmGame.GDGFxMovieUI_DeathOverview.DeathOverviewBodyParts HitLoc
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGFxMovieUI_DeathOverview.DeathOverviewBodyParts>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Count
        /// </summary>
        public unsafe int Count
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: Damage
        /// </summary>
        public unsafe int Damage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: DamageCausers
        /// </summary>
        public unsafe BmSDK.BmGame.GDGFxMovieUI_DeathOverview.FNameShotsDamage DamageCausers_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGFxMovieUI_DeathOverview.FNameShotsDamage>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
        /// <summary>
        /// StructProperty: DamageCausers
        /// </summary>
        public unsafe BmSDK.BmGame.GDGFxMovieUI_DeathOverview.FNameShotsDamage DamageCausers_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGFxMovieUI_DeathOverview.FNameShotsDamage>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }
        /// <summary>
        /// StructProperty: DamageCausers
        /// </summary>
        public unsafe BmSDK.BmGame.GDGFxMovieUI_DeathOverview.FNameShotsDamage DamageCausers_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGFxMovieUI_DeathOverview.FNameShotsDamage>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }
    }

    /// <summary>
    /// Enum: DeathOverviewBodyParts
    /// </summary>
    public enum DeathOverviewBodyParts : byte
    {
        DOBP_Head = 0,
        DOBP_Chest = 1,
        DOBP_RightArm = 2,
        DOBP_RightLeg = 3,
        DOBP_LeftArm = 4,
        DOBP_LeftLeg = 5,
        DOBP_MAX = 6,
    }

    /// <summary>
    /// Struct: FNameShotsDamage
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FNameShotsDamage
    {
        /// <summary>
        /// StrProperty: MyName
        /// </summary>
        public unsafe BmSDK.FString MyName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: MyShotCount
        /// </summary>
        public unsafe int MyShotCount
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: MyDamage
        /// </summary>
        public unsafe int MyDamage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StrProperty: dmgType
        /// </summary>
        public unsafe BmSDK.FString dmgType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }
}
