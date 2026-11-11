#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: GDGFxMovieUI_LobbyBase<br/>
/// (size = 2228)
/// (flags = 32790)
/// </summary>
public partial class GDGFxMovieUI_LobbyBase : BmSDK.BmGame.GDGFxMovieUI_LobbyBaseGame, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.GDGFxMovieUI_LobbyBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDGFxMovieUI_LobbyBase.
    /// </summary>
    public static GDGFxMovieUI_LobbyBase DefaultObject => (GDGFxMovieUI_LobbyBase)StaticClass().DefaultObject;

    internal GDGFxMovieUI_LobbyBase() { }

    /// <summary>
    /// Constructs a new GDGFxMovieUI_LobbyBase
    /// </summary>
    public GDGFxMovieUI_LobbyBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDGFxMovieUI_LobbyBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDGFxMovieUI_LobbyBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_LobbyBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_LobbyBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_LobbyBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_LobbyBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_LobbyBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_LobbyBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_LobbyBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_LobbyBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_OnDisconnection;
    /// <summary>
    /// Function: OnDisconnection
    /// </summary>
    public unsafe override void OnDisconnection()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDisconnection, "BmScript.GDGFxMovieUI_LobbyBase.OnDisconnection");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetLobbyTableLoadoutListActive;
    /// <summary>
    /// Function: asSetLobbyTableLoadoutListActive
    /// </summary>
    public unsafe virtual void asSetLobbyTableLoadoutListActive()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetLobbyTableLoadoutListActive, "BmScript.GDGFxMovieUI_LobbyBase.asSetLobbyTableLoadoutListActive");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetLobbyTableMapVoteListActive;
    /// <summary>
    /// Function: asSetLobbyTableMapVoteListActive
    /// </summary>
    public unsafe virtual void asSetLobbyTableMapVoteListActive()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetLobbyTableMapVoteListActive, "BmScript.GDGFxMovieUI_LobbyBase.asSetLobbyTableMapVoteListActive");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetLobbyTableConsumablesListActive;
    /// <summary>
    /// Function: asSetLobbyTableConsumablesListActive
    /// </summary>
    public unsafe virtual void asSetLobbyTableConsumablesListActive()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetLobbyTableConsumablesListActive, "BmScript.GDGFxMovieUI_LobbyBase.asSetLobbyTableConsumablesListActive");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetLobbyTablePlayerListActive;
    /// <summary>
    /// Function: asSetLobbyTablePlayerListActive
    /// </summary>
    public unsafe virtual void asSetLobbyTablePlayerListActive()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetLobbyTablePlayerListActive, "BmScript.GDGFxMovieUI_LobbyBase.asSetLobbyTablePlayerListActive");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetLobbyTabIconsDisabled;
    /// <summary>
    /// Function: asSetLobbyTabIconsDisabled
    /// </summary>
    public unsafe virtual void asSetLobbyTabIconsDisabled(bool bDisabled)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetLobbyTabIconsDisabled, "BmScript.GDGFxMovieUI_LobbyBase.asSetLobbyTabIconsDisabled");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDisabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetLobbyLoadoutTabIconActive;
    /// <summary>
    /// Function: asSetLobbyLoadoutTabIconActive
    /// </summary>
    public unsafe virtual void asSetLobbyLoadoutTabIconActive(BmSDK.FString TabName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetLobbyLoadoutTabIconActive, "BmScript.GDGFxMovieUI_LobbyBase.asSetLobbyLoadoutTabIconActive");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TabName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetLobbyMapTabIconActive;
    /// <summary>
    /// Function: asSetLobbyMapTabIconActive
    /// </summary>
    public unsafe virtual void asSetLobbyMapTabIconActive(BmSDK.FString TabName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetLobbyMapTabIconActive, "BmScript.GDGFxMovieUI_LobbyBase.asSetLobbyMapTabIconActive");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TabName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetLobbyConsumablesTabIconActive;
    /// <summary>
    /// Function: asSetLobbyConsumablesTabIconActive
    /// </summary>
    public unsafe virtual void asSetLobbyConsumablesTabIconActive(BmSDK.FString TabName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetLobbyConsumablesTabIconActive, "BmScript.GDGFxMovieUI_LobbyBase.asSetLobbyConsumablesTabIconActive");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TabName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetLobbyPlayerTabIconActive;
    /// <summary>
    /// Function: asSetLobbyPlayerTabIconActive
    /// </summary>
    public unsafe virtual void asSetLobbyPlayerTabIconActive(BmSDK.FString TabName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetLobbyPlayerTabIconActive, "BmScript.GDGFxMovieUI_LobbyBase.asSetLobbyPlayerTabIconActive");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TabName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetLobbyTabPlatformMode;
    /// <summary>
    /// Function: asSetLobbyTabPlatformMode
    /// </summary>
    public unsafe virtual void asSetLobbyTabPlatformMode(BmSDK.FString PlatformName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetLobbyTabPlatformMode, "BmScript.GDGFxMovieUI_LobbyBase.asSetLobbyTabPlatformMode");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlatformName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetPlayerInfoLoadout;
    /// <summary>
    /// Function: asSetPlayerInfoLoadout
    /// </summary>
    public unsafe virtual void asSetPlayerInfoLoadout(bool bJoker, BmSDK.FString WeaponLvl, BmSDK.FString WeaponPkgName, BmSDK.FString WeaponIconName, BmSDK.FString AbilityPkgName, BmSDK.FString LeftAbilityName, BmSDK.FString RightAbilityName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetPlayerInfoLoadout, "BmScript.GDGFxMovieUI_LobbyBase.asSetPlayerInfoLoadout");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bJoker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponLvl, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponPkgName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponIconName, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AbilityPkgName, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeftAbilityName, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RightAbilityName, paramsPtr + 64);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetPlayerNameText;
    /// <summary>
    /// Function: asSetPlayerNameText
    /// </summary>
    public unsafe virtual void asSetPlayerNameText(BmSDK.FString PlayerName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetPlayerNameText, "BmScript.GDGFxMovieUI_LobbyBase.asSetPlayerNameText");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetPlayerLoadout;
    /// <summary>
    /// Function: asSetPlayerLoadout
    /// </summary>
    public unsafe virtual void asSetPlayerLoadout(bool bJoker, BmSDK.FString WeaponLvl, BmSDK.FString WeaponPkgName, BmSDK.FString WeaponIconName, BmSDK.FString AbilityPkgName, BmSDK.FString LeftAbilityName, BmSDK.FString RightAbilityName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetPlayerLoadout, "BmScript.GDGFxMovieUI_LobbyBase.asSetPlayerLoadout");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bJoker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponLvl, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponPkgName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponIconName, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AbilityPkgName, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeftAbilityName, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RightAbilityName, paramsPtr + 64);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetLoadoutPlayerNameText;
    /// <summary>
    /// Function: asSetLoadoutPlayerNameText
    /// </summary>
    public unsafe virtual void asSetLoadoutPlayerNameText(BmSDK.FString PlayerName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetLoadoutPlayerNameText, "BmScript.GDGFxMovieUI_LobbyBase.asSetLoadoutPlayerNameText");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetConsumableInfo;
    /// <summary>
    /// Function: asSetConsumableInfo
    /// </summary>
    public unsafe virtual void asSetConsumableInfo(BmSDK.FString ConsumableName, BmSDK.FString ConsumableDescription)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetConsumableInfo, "BmScript.GDGFxMovieUI_LobbyBase.asSetConsumableInfo");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConsumableName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConsumableDescription, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetMapInfo;
    /// <summary>
    /// Function: asSetMapInfo
    /// </summary>
    public unsafe virtual void asSetMapInfo(BmSDK.FString MapDescription)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetMapInfo, "BmScript.GDGFxMovieUI_LobbyBase.asSetMapInfo");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapDescription, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetMapVoteNextMapData;
    /// <summary>
    /// Function: asSetMapVoteNextMapData
    /// </summary>
    public unsafe virtual void asSetMapVoteNextMapData(BmSDK.FString MapThumbPkgName, BmSDK.FString MapThumbName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetMapVoteNextMapData, "BmScript.GDGFxMovieUI_LobbyBase.asSetMapVoteNextMapData");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapThumbPkgName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapThumbName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetMapVoteNameText;
    /// <summary>
    /// Function: asSetMapVoteNameText
    /// </summary>
    public unsafe virtual void asSetMapVoteNameText(BmSDK.FString MapName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetMapVoteNameText, "BmScript.GDGFxMovieUI_LobbyBase.asSetMapVoteNameText");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetLobbyModeText;
    /// <summary>
    /// Function: asSetLobbyModeText
    /// </summary>
    public unsafe virtual void asSetLobbyModeText(BmSDK.FString LobbyMode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetLobbyModeText, "BmScript.GDGFxMovieUI_LobbyBase.asSetLobbyModeText");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetLobbyStatusTimerColour;
    /// <summary>
    /// Function: asSetLobbyStatusTimerColour
    /// </summary>
    public unsafe virtual void asSetLobbyStatusTimerColour(int Colour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetLobbyStatusTimerColour, "BmScript.GDGFxMovieUI_LobbyBase.asSetLobbyStatusTimerColour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Colour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetLobbyStatusTimer;
    /// <summary>
    /// Function: asSetLobbyStatusTimer
    /// </summary>
    public unsafe virtual void asSetLobbyStatusTimer(BmSDK.FString FormattedTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetLobbyStatusTimer, "BmScript.GDGFxMovieUI_LobbyBase.asSetLobbyStatusTimer");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FormattedTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetPlayersText;
    /// <summary>
    /// Function: asSetPlayersText
    /// </summary>
    public unsafe virtual void asSetPlayersText(BmSDK.FString PlayerNum)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetPlayersText, "BmScript.GDGFxMovieUI_LobbyBase.asSetPlayersText");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetLobbyGameModeText;
    /// <summary>
    /// Function: asSetLobbyGameModeText
    /// </summary>
    public unsafe virtual void asSetLobbyGameModeText(BmSDK.FString GameMode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetLobbyGameModeText, "BmScript.GDGFxMovieUI_LobbyBase.asSetLobbyGameModeText");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GameMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asGetLobbyListTableObjName;
    /// <summary>
    /// Function: asGetLobbyListTableObjName
    /// </summary>
    public unsafe virtual BmSDK.FString asGetLobbyListTableObjName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetLobbyListTableObjName, "BmScript.GDGFxMovieUI_LobbyBase.asGetLobbyListTableObjName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_asGetLobbyTabInfoObjName;
    /// <summary>
    /// Function: asGetLobbyTabInfoObjName
    /// </summary>
    public unsafe virtual BmSDK.FString asGetLobbyTabInfoObjName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetLobbyTabInfoObjName, "BmScript.GDGFxMovieUI_LobbyBase.asGetLobbyTabInfoObjName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_asGetLoadoutInfoObjName;
    /// <summary>
    /// Function: asGetLoadoutInfoObjName
    /// </summary>
    public unsafe virtual BmSDK.FString asGetLoadoutInfoObjName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetLoadoutInfoObjName, "BmScript.GDGFxMovieUI_LobbyBase.asGetLoadoutInfoObjName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_asGetPlayerInfoInfoObjName;
    /// <summary>
    /// Function: asGetPlayerInfoInfoObjName
    /// </summary>
    public unsafe virtual BmSDK.FString asGetPlayerInfoInfoObjName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetPlayerInfoInfoObjName, "BmScript.GDGFxMovieUI_LobbyBase.asGetPlayerInfoInfoObjName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_asGetConsumableInfoObjName;
    /// <summary>
    /// Function: asGetConsumableInfoObjName
    /// </summary>
    public unsafe virtual BmSDK.FString asGetConsumableInfoObjName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetConsumableInfoObjName, "BmScript.GDGFxMovieUI_LobbyBase.asGetConsumableInfoObjName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_asGetMapVoteInfoObjName;
    /// <summary>
    /// Function: asGetMapVoteInfoObjName
    /// </summary>
    public unsafe virtual BmSDK.FString asGetMapVoteInfoObjName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetMapVoteInfoObjName, "BmScript.GDGFxMovieUI_LobbyBase.asGetMapVoteInfoObjName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_asGetMapInfoObjName;
    /// <summary>
    /// Function: asGetMapInfoObjName
    /// </summary>
    public unsafe virtual BmSDK.FString asGetMapInfoObjName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetMapInfoObjName, "BmScript.GDGFxMovieUI_LobbyBase.asGetMapInfoObjName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_asGetLobbyStatusObjName;
    /// <summary>
    /// Function: asGetLobbyStatusObjName
    /// </summary>
    public unsafe virtual BmSDK.FString asGetLobbyStatusObjName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetLobbyStatusObjName, "BmScript.GDGFxMovieUI_LobbyBase.asGetLobbyStatusObjName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_asCountdownTimerUpdate;
    /// <summary>
    /// Function: asCountdownTimerUpdate
    /// </summary>
    public unsafe override void asCountdownTimerUpdate(int SecondsRemaining)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asCountdownTimerUpdate, "BmScript.GDGFxMovieUI_LobbyBase.asCountdownTimerUpdate");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SecondsRemaining, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndOfLobbyFullCountdownTimer;
    /// <summary>
    /// Function: EndOfLobbyFullCountdownTimer
    /// </summary>
    public unsafe virtual void EndOfLobbyFullCountdownTimer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndOfLobbyFullCountdownTimer, "BmScript.GDGFxMovieUI_LobbyBase.EndOfLobbyFullCountdownTimer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateFullLobbyCountdownTimer;
    /// <summary>
    /// Function: UpdateFullLobbyCountdownTimer
    /// </summary>
    public unsafe virtual void UpdateFullLobbyCountdownTimer(int SecondsRemaing)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateFullLobbyCountdownTimer, "BmScript.GDGFxMovieUI_LobbyBase.UpdateFullLobbyCountdownTimer");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SecondsRemaing, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopLobbyFullCountdownTimer;
    /// <summary>
    /// Function: StopLobbyFullCountdownTimer
    /// </summary>
    public unsafe virtual void StopLobbyFullCountdownTimer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopLobbyFullCountdownTimer, "BmScript.GDGFxMovieUI_LobbyBase.StopLobbyFullCountdownTimer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartLobbyFullCountdownTimer;
    /// <summary>
    /// Function: StartLobbyFullCountdownTimer
    /// </summary>
    public unsafe virtual void StartLobbyFullCountdownTimer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartLobbyFullCountdownTimer, "BmScript.GDGFxMovieUI_LobbyBase.StartLobbyFullCountdownTimer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnFadeCompleted_Callback;
    /// <summary>
    /// Function: OnFadeCompleted_Callback
    /// </summary>
    public unsafe override bool OnFadeCompleted_Callback()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFadeCompleted_Callback, "BmScript.GDGFxMovieUI_LobbyBase.OnFadeCompleted_Callback");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateMatchmakingData;
    /// <summary>
    /// Function: UpdateMatchmakingData
    /// </summary>
    public unsafe virtual void UpdateMatchmakingData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateMatchmakingData, "BmScript.GDGFxMovieUI_LobbyBase.UpdateMatchmakingData");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FadeTrigger;
    /// <summary>
    /// Function: FadeTrigger
    /// </summary>
    public unsafe virtual void FadeTrigger(BmSDK.BmScript.GDGFxMovieUI_LobbyBase.LobbyFadeTriggerMode FadeMode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FadeTrigger, "BmScript.GDGFxMovieUI_LobbyBase.FadeTrigger");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FadeMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateLobbyStatusBox;
    /// <summary>
    /// Function: UpdateLobbyStatusBox
    /// </summary>
    public unsafe virtual void UpdateLobbyStatusBox(int NumPlayers, int MaxNumPlayers)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateLobbyStatusBox, "BmScript.GDGFxMovieUI_LobbyBase.UpdateLobbyStatusBox");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumPlayers, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxNumPlayers, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartGameStartTimerCountdown;
    /// <summary>
    /// Function: StartGameStartTimerCountdown
    /// </summary>
    public unsafe virtual void StartGameStartTimerCountdown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartGameStartTimerCountdown, "BmScript.GDGFxMovieUI_LobbyBase.StartGameStartTimerCountdown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnGameStarted;
    /// <summary>
    /// Function: OnGameStarted
    /// </summary>
    public unsafe virtual void OnGameStarted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnGameStarted, "BmScript.GDGFxMovieUI_LobbyBase.OnGameStarted");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLobbyLists;
    /// <summary>
    /// Function: ClearLobbyLists
    /// </summary>
    public unsafe virtual void ClearLobbyLists()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLobbyLists, "BmScript.GDGFxMovieUI_LobbyBase.ClearLobbyLists");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddCachedLoadoutData;
    /// <summary>
    /// Function: AddCachedLoadoutData
    /// </summary>
    public unsafe virtual void AddCachedLoadoutData(BmSDK.FString LoadoutId, int Count, int LoadoutIdx, BmSDK.BmGame.RGameInfo.ELoadoutTeamId TeamID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCachedLoadoutData, "BmScript.GDGFxMovieUI_LobbyBase.AddCachedLoadoutData");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadoutId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Count, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoadoutIdx, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamID, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddCachedConsumableData;
    /// <summary>
    /// Function: AddCachedConsumableData
    /// </summary>
    public unsafe virtual void AddCachedConsumableData(BmSDK.FString ConsumableId, int Count, int ButtonId, BmSDK.FString ConsumableN, BmSDK.FString ConsumableDesc, bool bUsed)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCachedConsumableData, "BmScript.GDGFxMovieUI_LobbyBase.AddCachedConsumableData");
        byte* paramsPtr = stackalloc byte[112];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConsumableId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Count, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConsumableN, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConsumableDesc, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUsed, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetLocalPlayerNetID;
    /// <summary>
    /// Function: GetLocalPlayerNetID
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineSubsystem.FUniqueNetId GetLocalPlayerNetID()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocalPlayerNetID, "BmScript.GDGFxMovieUI_LobbyBase.GetLocalPlayerNetID");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetIsLobbyPlayerLocal;
    /// <summary>
    /// Function: GetIsLobbyPlayerLocal
    /// </summary>
    public unsafe virtual bool GetIsLobbyPlayerLocal(BmSDK.SDEngine.SDLobbySystem.FSDLobbyMember LobbyEntry)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIsLobbyPlayerLocal, "BmScript.GDGFxMovieUI_LobbyBase.GetIsLobbyPlayerLocal");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyEntry, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 68);
    }

    private static BmSDK.Function __fn_OnHostCreated;
    /// <summary>
    /// Function: OnHostCreated
    /// </summary>
    public unsafe virtual void OnHostCreated()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnHostCreated, "BmScript.GDGFxMovieUI_LobbyBase.OnHostCreated");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CountdownTimerStarted;
    /// <summary>
    /// Function: CountdownTimerStarted
    /// </summary>
    public unsafe override void CountdownTimerStarted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CountdownTimerStarted, "BmScript.GDGFxMovieUI_LobbyBase.CountdownTimerStarted");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadLobbyMapInfoForMapName;
    /// <summary>
    /// Function: LoadLobbyMapInfoForMapName
    /// </summary>
    public unsafe virtual void LoadLobbyMapInfoForMapName(BmSDK.FString MapName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadLobbyMapInfoForMapName, "BmScript.GDGFxMovieUI_LobbyBase.LoadLobbyMapInfoForMapName");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateLobbyMapVoteInfo;
    /// <summary>
    /// Function: UpdateLobbyMapVoteInfo
    /// </summary>
    public unsafe virtual void UpdateLobbyMapVoteInfo(BmSDK.FString MapName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateLobbyMapVoteInfo, "BmScript.GDGFxMovieUI_LobbyBase.UpdateLobbyMapVoteInfo");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateGameModeText;
    /// <summary>
    /// Function: UpdateGameModeText
    /// </summary>
    public unsafe virtual void UpdateGameModeText()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateGameModeText, "BmScript.GDGFxMovieUI_LobbyBase.UpdateGameModeText");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateLobbyMapInfo;
    /// <summary>
    /// Function: UpdateLobbyMapInfo
    /// </summary>
    public unsafe virtual void UpdateLobbyMapInfo(BmSDK.FString MapName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateLobbyMapInfo, "BmScript.GDGFxMovieUI_LobbyBase.UpdateLobbyMapInfo");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetWinningVoteIdx;
    /// <summary>
    /// Function: GetWinningVoteIdx
    /// </summary>
    public unsafe virtual bool GetWinningVoteIdx(out int WinningIdx, out int HighestVote)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWinningVoteIdx, "BmScript.GDGFxMovieUI_LobbyBase.GetWinningVoteIdx");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out WinningIdx);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WinningIdx, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HighestVote);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HighestVote, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        WinningIdx = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        HighestVote = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_EndOfMapVote;
    /// <summary>
    /// Function: EndOfMapVote
    /// </summary>
    public unsafe virtual void EndOfMapVote()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndOfMapVote, "BmScript.GDGFxMovieUI_LobbyBase.EndOfMapVote");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNextMapToBePlayed;
    /// <summary>
    /// Function: GetNextMapToBePlayed
    /// </summary>
    public unsafe BmSDK.FString GetNextMapToBePlayed(out int NextMapIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNextMapToBePlayed, "BmScript.GDGFxMovieUI_LobbyBase.GetNextMapToBePlayed");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NextMapIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextMapIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        NextMapIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_UpdateMapVote;
    /// <summary>
    /// Function: UpdateMapVote
    /// </summary>
    public unsafe virtual void UpdateMapVote()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateMapVote, "BmScript.GDGFxMovieUI_LobbyBase.UpdateMapVote");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartLobbyMapVote;
    /// <summary>
    /// Function: StartLobbyMapVote
    /// </summary>
    public unsafe virtual void StartLobbyMapVote()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartLobbyMapVote, "BmScript.GDGFxMovieUI_LobbyBase.StartLobbyMapVote");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNumVotesForButtonIndex;
    /// <summary>
    /// Function: GetNumVotesForButtonIndex
    /// </summary>
    public unsafe virtual int GetNumVotesForButtonIndex(int Idx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumVotesForButtonIndex, "BmScript.GDGFxMovieUI_LobbyBase.GetNumVotesForButtonIndex");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Idx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_MapVoteStarted;
    /// <summary>
    /// Function: MapVoteStarted
    /// </summary>
    public unsafe virtual void MapVoteStarted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MapVoteStarted, "BmScript.GDGFxMovieUI_LobbyBase.MapVoteStarted");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLobbyDelegates;
    /// <summary>
    /// Function: ClearLobbyDelegates
    /// </summary>
    public unsafe override void ClearLobbyDelegates()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLobbyDelegates, "BmScript.GDGFxMovieUI_LobbyBase.ClearLobbyDelegates");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddLobbyDelegates;
    /// <summary>
    /// Function: AddLobbyDelegates
    /// </summary>
    public unsafe override void AddLobbyDelegates()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddLobbyDelegates, "BmScript.GDGFxMovieUI_LobbyBase.AddLobbyDelegates");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetNumPlayersRequiredForGame;
    /// <summary>
    /// Function: GetNumPlayersRequiredForGame
    /// </summary>
    public unsafe virtual int GetNumPlayersRequiredForGame()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumPlayersRequiredForGame, "BmScript.GDGFxMovieUI_LobbyBase.GetNumPlayersRequiredForGame");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HasPlayerUnlockedWeapons;
    /// <summary>
    /// Function: HasPlayerUnlockedWeapons
    /// </summary>
    public unsafe virtual bool HasPlayerUnlockedWeapons()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasPlayerUnlockedWeapons, "BmScript.GDGFxMovieUI_LobbyBase.HasPlayerUnlockedWeapons");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPlayerHasConsumables;
    /// <summary>
    /// Function: GetPlayerHasConsumables
    /// </summary>
    public unsafe virtual bool GetPlayerHasConsumables()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerHasConsumables, "BmScript.GDGFxMovieUI_LobbyBase.GetPlayerHasConsumables");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetLobbyPlayerLoadout;
    /// <summary>
    /// Function: GetLobbyPlayerLoadout
    /// </summary>
    public unsafe virtual int GetLobbyPlayerLoadout(BmSDK.BmGame.GDLobbySystemSteam LobbySys, int ButtonId)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLobbyPlayerLoadout, "BmScript.GDGFxMovieUI_LobbyBase.GetLobbyPlayerLoadout");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbySys, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_OnBack;
    /// <summary>
    /// Function: OnBack
    /// </summary>
    public unsafe override void OnBack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBack, "BmScript.GDGFxMovieUI_LobbyBase.OnBack");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnClosed;
    /// <summary>
    /// Function: OnClosed
    /// </summary>
    public unsafe override void OnClosed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnClosed, "BmScript.GDGFxMovieUI_LobbyBase.OnClosed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CacheLinkedLobbyInfoObjects;
    /// <summary>
    /// Function: CacheLinkedLobbyInfoObjects
    /// </summary>
    public unsafe void CacheLinkedLobbyInfoObjects()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CacheLinkedLobbyInfoObjects, "BmScript.GDGFxMovieUI_LobbyBase.CacheLinkedLobbyInfoObjects");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RequestButtonListData;
    /// <summary>
    /// Function: RequestButtonListData
    /// </summary>
    public unsafe override void RequestButtonListData(BmSDK.FString ButtonListID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RequestButtonListData, "BmScript.GDGFxMovieUI_LobbyBase.RequestButtonListData");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonListID, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmScript.GDGFxMovieUI_LobbyBase.Init");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FLocalLoadoutData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FLocalLoadoutData
    {
        /// <summary>
        /// StrProperty: LoadoutId
        /// </summary>
        public unsafe BmSDK.FString LoadoutId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: ButtonIndex
        /// </summary>
        public unsafe int ButtonIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: LoadoutIndex
        /// </summary>
        public unsafe int LoadoutIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ByteProperty: TeamLoadoutID
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.ELoadoutTeamId TeamLoadoutID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.ELoadoutTeamId>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FLocalConsumableData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial record struct FLocalConsumableData
    {
        /// <summary>
        /// StrProperty: ConsumableId
        /// </summary>
        public unsafe BmSDK.FString ConsumableId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: ConsumableCount
        /// </summary>
        public unsafe int ConsumableCount
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: ButtonIndex
        /// </summary>
        public unsafe int ButtonIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StrProperty: ConsumableName
        /// </summary>
        public unsafe BmSDK.FString ConsumableName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// StrProperty: ConsumableDescription
        /// </summary>
        public unsafe BmSDK.FString ConsumableDescription
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: bConsumableUsed
        /// </summary>
        public unsafe bool bConsumableUsed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }; }
        }
    }

    /// <summary>
    /// Enum: EUILobbyPlayerInfoType
    /// </summary>
    public enum EUILobbyPlayerInfoType : byte
    {
        UIL_PlayerInfoLevel = 0,
        UIL_PlayerInfoVOIP = 1,
        UIL_PlayerInfoAR = 2,
        UIL_PlayerInfoFaction = 3,
        UIL_MAX = 4,
    }

    /// <summary>
    /// ByteProperty: LobbyFadeMode
    /// </summary>
    public unsafe BmSDK.BmScript.GDGFxMovieUI_LobbyBase.LobbyFadeTriggerMode LobbyFadeMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.GDGFxMovieUI_LobbyBase.LobbyFadeTriggerMode>(Ptr + 2048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2048); }
    }

    /// <summary>
    /// IntProperty: GameStartTimerValue
    /// </summary>
    public unsafe int GameStartTimerValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2052); }
    }

    /// <summary>
    /// BoolProperty: GameTimerCountdownActive
    /// </summary>
    public unsafe bool GameTimerCountdownActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bIsLobbyHost
    /// </summary>
    public unsafe bool bIsLobbyHost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bFullLobbyCountdownActive
    /// </summary>
    public unsafe bool bFullLobbyCountdownActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bLobbyOpenedFromFrontEnd
    /// </summary>
    public unsafe bool bLobbyOpenedFromFrontEnd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bAllowMapVote
    /// </summary>
    public unsafe bool bAllowMapVote
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bKickIdlers
    /// </summary>
    public unsafe bool bKickIdlers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// ObjectProperty: LobbyMapInfo
    /// </summary>
    public unsafe BmSDK.BmGame.GDLobbyMapInfo LobbyMapInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDLobbyMapInfo>(Ptr + 2060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2060); }
    }

    /// <summary>
    /// FloatProperty: LobbyCountdownTime
    /// </summary>
    public unsafe float LobbyCountdownTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2064); }
    }

    /// <summary>
    /// FloatProperty: FullLobbyCountdownPlayAudioTime
    /// </summary>
    public unsafe float FullLobbyCountdownPlayAudioTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2068); }
    }

    /// <summary>
    /// ObjectProperty: FullLobbyCountdownTimer
    /// </summary>
    public unsafe BmSDK.SDEngine.SDTimer FullLobbyCountdownTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.SDEngine.SDTimer>(Ptr + 2072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }
    }

    /// <summary>
    /// StrProperty: PrevMapName
    /// </summary>
    public unsafe BmSDK.FString PrevMapName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2076); }
    }

    /// <summary>
    /// StrProperty: LobbyWeaponIconPkgName
    /// </summary>
    public unsafe BmSDK.FString LobbyWeaponIconPkgName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2088); }
    }

    /// <summary>
    /// StrProperty: LobbyAbilityIconPkgName
    /// </summary>
    public unsafe BmSDK.FString LobbyAbilityIconPkgName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2100); }
    }

    /// <summary>
    /// StrProperty: LobbyConsumablePkgName
    /// </summary>
    public unsafe BmSDK.FString LobbyConsumablePkgName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2112); }
    }

    /// <summary>
    /// StrProperty: LobbyMapIconPkgName
    /// </summary>
    public unsafe BmSDK.FString LobbyMapIconPkgName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2124); }
    }

    /// <summary>
    /// StrProperty: LobbyMapThumbPkgName
    /// </summary>
    public unsafe BmSDK.FString LobbyMapThumbPkgName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2136); }
    }

    /// <summary>
    /// ObjectProperty: LobbyStatusInfoBox
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject LobbyStatusInfoBox
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 2148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2148); }
    }

    /// <summary>
    /// ObjectProperty: MapVoteInfoBox
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject MapVoteInfoBox
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 2152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2152); }
    }

    /// <summary>
    /// ObjectProperty: MapInfoBox
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject MapInfoBox
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 2156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2156); }
    }

    /// <summary>
    /// ObjectProperty: LoadoutInfoBox
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject LoadoutInfoBox
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }

    /// <summary>
    /// ObjectProperty: PlayerInfoBox
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject PlayerInfoBox
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 2164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2164); }
    }

    /// <summary>
    /// ObjectProperty: ConsumableInfoBox
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject ConsumableInfoBox
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 2168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2168); }
    }

    /// <summary>
    /// ObjectProperty: LobbyTabInfoBox
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject LobbyTabInfoBox
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 2172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2172); }
    }

    /// <summary>
    /// ObjectProperty: LobbyListTableBox
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject LobbyListTableBox
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 2176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }
    }

    /// <summary>
    /// IntProperty: LobbyStatusWaitingColour
    /// </summary>
    public unsafe int LobbyStatusWaitingColour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2180); }
    }

    /// <summary>
    /// IntProperty: LobbyStatusMapVoteColour
    /// </summary>
    public unsafe int LobbyStatusMapVoteColour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2184); }
    }

    /// <summary>
    /// IntProperty: LobbyStatusGameStartColour
    /// </summary>
    public unsafe int LobbyStatusGameStartColour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2188); }
    }

    /// <summary>
    /// ArrayProperty: CachedLobbyPlayers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.SDEngine.SDLobbySystem.FSDLobbyMember> CachedLobbyPlayers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.SDEngine.SDLobbySystem.FSDLobbyMember>>(Ptr + 2192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2192); }
    }

    /// <summary>
    /// ArrayProperty: CachedConsumableLobbyData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.GDGFxMovieUI_LobbyBase.FLocalConsumableData> CachedConsumableLobbyData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.GDGFxMovieUI_LobbyBase.FLocalConsumableData>>(Ptr + 2204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2204); }
    }

    /// <summary>
    /// ArrayProperty: CachedLoadoutLobbyData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.GDGFxMovieUI_LobbyBase.FLocalLoadoutData> CachedLoadoutLobbyData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.GDGFxMovieUI_LobbyBase.FLocalLoadoutData>>(Ptr + 2216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2216); }
    }

    /// <summary>
    /// Enum: LobbyFadeTriggerMode
    /// </summary>
    public enum LobbyFadeTriggerMode : byte
    {
        LFTM_ExitLobbyFade = 0,
        LFTM_StartGameFade = 1,
        LFTM_MAX = 2,
    }
}
