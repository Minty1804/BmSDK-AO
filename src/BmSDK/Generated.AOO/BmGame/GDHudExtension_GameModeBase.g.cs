#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: GDHudExtension_GameModeBase<br/>
/// (size = 388)
/// (flags = 134250643)
/// </summary>
public partial class GDHudExtension_GameModeBase : BmSDK.BmGame.RHudExtension, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDHudExtension_GameModeBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDHudExtension_GameModeBase.
    /// </summary>
    public static GDHudExtension_GameModeBase DefaultObject => (GDHudExtension_GameModeBase)StaticClass().DefaultObject;

    internal GDHudExtension_GameModeBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDHudExtension_GameModeBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDHudExtension_GameModeBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtension_GameModeBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDHudExtension_GameModeBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtension_GameModeBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtension_GameModeBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtension_GameModeBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDHudExtension_GameModeBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDHudExtension_GameModeBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_asHideTimer;
    /// <summary>
    /// Function: asHideTimer
    /// </summary>
    public unsafe virtual void asHideTimer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asHideTimer, "BmGame.GDHudExtension_GameModeBase.asHideTimer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asGetPlayerMovie;
    /// <summary>
    /// Function: asGetPlayerMovie
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject asGetPlayerMovie(int PlayerIndex, bool bLefthandSide)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetPlayerMovie, "BmGame.GDHudExtension_GameModeBase.asGetPlayerMovie");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLefthandSide, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_asGetPlayerIconMovie;
    /// <summary>
    /// Function: asGetPlayerIconMovie
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject asGetPlayerIconMovie(int PlayerIndex, bool bLefthandSide)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetPlayerIconMovie, "BmGame.GDHudExtension_GameModeBase.asGetPlayerIconMovie");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLefthandSide, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_asGetPlayerIconFillMovie;
    /// <summary>
    /// Function: asGetPlayerIconFillMovie
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject asGetPlayerIconFillMovie(int PlayerIndex, bool bLefthandSide)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetPlayerIconFillMovie, "BmGame.GDHudExtension_GameModeBase.asGetPlayerIconFillMovie");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLefthandSide, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_asGetTimer;
    /// <summary>
    /// Function: asGetTimer
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject asGetTimer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetTimer, "BmGame.GDHudExtension_GameModeBase.asGetTimer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_asGetHeroPlayerIconMovie;
    /// <summary>
    /// Function: asGetHeroPlayerIconMovie
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject asGetHeroPlayerIconMovie(bool bIsBatman)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetHeroPlayerIconMovie, "BmGame.GDHudExtension_GameModeBase.asGetHeroPlayerIconMovie");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsBatman, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_asGetHeroPlayerIconFillMovie;
    /// <summary>
    /// Function: asGetHeroPlayerIconFillMovie
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject asGetHeroPlayerIconFillMovie(bool bIsBatman)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetHeroPlayerIconFillMovie, "BmGame.GDHudExtension_GameModeBase.asGetHeroPlayerIconFillMovie");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsBatman, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_asGetHeroPlayerMovie;
    /// <summary>
    /// Function: asGetHeroPlayerMovie
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject asGetHeroPlayerMovie(bool bIsBatman)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetHeroPlayerMovie, "BmGame.GDHudExtension_GameModeBase.asGetHeroPlayerMovie");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsBatman, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_asGetHeroYouAnimationMovie;
    /// <summary>
    /// Function: asGetHeroYouAnimationMovie
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject asGetHeroYouAnimationMovie(bool bIsBatman)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetHeroYouAnimationMovie, "BmGame.GDHudExtension_GameModeBase.asGetHeroYouAnimationMovie");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsBatman, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_asGetYouAnimationMovie;
    /// <summary>
    /// Function: asGetYouAnimationMovie
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject asGetYouAnimationMovie()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetYouAnimationMovie, "BmGame.GDHudExtension_GameModeBase.asGetYouAnimationMovie");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_asGetControlPointPulseMovie;
    /// <summary>
    /// Function: asGetControlPointPulseMovie
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject asGetControlPointPulseMovie(int CPIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetControlPointPulseMovie, "BmGame.GDHudExtension_GameModeBase.asGetControlPointPulseMovie");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CPIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_asGetControlPointMovie;
    /// <summary>
    /// Function: asGetControlPointMovie
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject asGetControlPointMovie(int CPIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetControlPointMovie, "BmGame.GDHudExtension_GameModeBase.asGetControlPointMovie");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CPIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_asSetCPIcon;
    /// <summary>
    /// Function: asSetCPIcon
    /// </summary>
    public unsafe virtual void asSetCPIcon(int CPIndex, BmSDK.FString CPString)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetCPIcon, "BmGame.GDHudExtension_GameModeBase.asSetCPIcon");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CPIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CPString, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetGangColours;
    /// <summary>
    /// Function: asSetGangColours
    /// </summary>
    public unsafe virtual void asSetGangColours(int LeftColour, int RightCOlour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetGangColours, "BmGame.GDHudExtension_GameModeBase.asSetGangColours");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeftColour, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RightCOlour, paramsPtr + 4);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MovieIsReady, "BmGame.GDHudExtension_GameModeBase.MovieIsReady");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_path, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetObjectColour;
    /// <summary>
    /// Function: asSetObjectColour
    /// </summary>
    public unsafe virtual void asSetObjectColour(BmSDK.GFxUI.GFxObject Obj, int Colour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetObjectColour, "BmGame.GDHudExtension_GameModeBase.asSetObjectColour");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Obj, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Colour, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetObjectColour;
    /// <summary>
    /// Function: SetObjectColour
    /// </summary>
    public unsafe virtual void SetObjectColour(BmSDK.GFxUI.GFxObject Obj, int Colour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetObjectColour, "BmGame.GDHudExtension_GameModeBase.SetObjectColour");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Obj, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Colour, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetLeftSideTeam;
    /// <summary>
    /// Function: GetLeftSideTeam
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDGIBase.ETeamType GetLeftSideTeam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLeftSideTeam, "BmGame.GDHudExtension_GameModeBase.GetLeftSideTeam");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDGIBase.ETeamType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetCPIcons;
    /// <summary>
    /// Function: SetCPIcons
    /// </summary>
    public unsafe void SetCPIcons()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCPIcons, "BmGame.GDHudExtension_GameModeBase.SetCPIcons");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGangColours;
    /// <summary>
    /// Function: SetGangColours
    /// </summary>
    public unsafe void SetGangColours()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGangColours, "BmGame.GDHudExtension_GameModeBase.SetGangColours");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInitialData;
    /// <summary>
    /// Function: SetInitialData
    /// </summary>
    public unsafe virtual void SetInitialData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInitialData, "BmGame.GDHudExtension_GameModeBase.SetInitialData");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTimeRemaining;
    /// <summary>
    /// Function: GetTimeRemaining
    /// </summary>
    public unsafe void GetTimeRemaining(out BmSDK.BmGame.GDHudExtension_GameModeBase.FSGenericGameModeState GenericState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTimeRemaining, "BmGame.GDHudExtension_GameModeBase.GetTimeRemaining");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        GenericState = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDHudExtension_GameModeBase.FSGenericGameModeState>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetControlPointState;
    /// <summary>
    /// Function: GetControlPointState
    /// </summary>
    public unsafe void GetControlPointState(out BmSDK.BmGame.GDHudExtension_GameModeBase.FSGenericGameModeState GenericState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetControlPointState, "BmGame.GDHudExtension_GameModeBase.GetControlPointState");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        GenericState = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDHudExtension_GameModeBase.FSGenericGameModeState>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_RPRIToParticipant;
    /// <summary>
    /// Function: RPRIToParticipant
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDHudExtension_GameModeBase.FSGameModeParticipant RPRIToParticipant(BmSDK.BmGame.RPlayerRI InPRI)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RPRIToParticipant, "BmGame.GDHudExtension_GameModeBase.RPRIToParticipant");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPRI, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDHudExtension_GameModeBase.FSGameModeParticipant>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TeamArrayToParticipantsArray;
    /// <summary>
    /// Function: TeamArrayToParticipantsArray
    /// </summary>
    public unsafe virtual void TeamArrayToParticipantsArray(BmSDK.TArray<BmSDK.BmGame.RPlayerRI> TeamArray, out BmSDK.TArray<BmSDK.BmGame.GDHudExtension_GameModeBase.FSGameModeParticipant> ParticipantsArray)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TeamArrayToParticipantsArray, "BmGame.GDHudExtension_GameModeBase.TeamArrayToParticipantsArray");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeamArray, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ParticipantsArray = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDHudExtension_GameModeBase.FSGameModeParticipant>>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_CanPlayerRespawn;
    /// <summary>
    /// Function: CanPlayerRespawn
    /// </summary>
    public unsafe virtual bool CanPlayerRespawn(BmSDK.BmGame.RPlayerRI RPRI)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayerRespawn, "BmGame.GDHudExtension_GameModeBase.CanPlayerRespawn");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPRI, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetParticipantsState;
    /// <summary>
    /// Function: GetParticipantsState
    /// </summary>
    public unsafe void GetParticipantsState(out BmSDK.BmGame.GDHudExtension_GameModeBase.FSGenericGameModeState GenericState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetParticipantsState, "BmGame.GDHudExtension_GameModeBase.GetParticipantsState");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        GenericState = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDHudExtension_GameModeBase.FSGenericGameModeState>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_SortTeamByHUDIndex;
    /// <summary>
    /// Function: SortTeamByHUDIndex
    /// </summary>
    public unsafe virtual int SortTeamByHUDIndex(BmSDK.BmGame.RPlayerRI A, BmSDK.BmGame.RPlayerRI B)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SortTeamByHUDIndex, "BmGame.GDHudExtension_GameModeBase.SortTeamByHUDIndex");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_BuildGenericGameModeState;
    /// <summary>
    /// Function: BuildGenericGameModeState
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDHudExtension_GameModeBase.FSGenericGameModeState BuildGenericGameModeState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BuildGenericGameModeState, "BmGame.GDHudExtension_GameModeBase.BuildGenericGameModeState");
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDHudExtension_GameModeBase.FSGenericGameModeState>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PushTimeRemainingStateChange;
    /// <summary>
    /// Function: PushTimeRemainingStateChange
    /// </summary>
    public unsafe void PushTimeRemainingStateChange(BmSDK.BmGame.GDHudExtension_GameModeBase.FSGenericGameModeState NewState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushTimeRemainingStateChange, "BmGame.GDHudExtension_GameModeBase.PushTimeRemainingStateChange");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCPStateChangeStateAndColour;
    /// <summary>
    /// Function: GetCPStateChangeStateAndColour
    /// </summary>
    public unsafe virtual bool GetCPStateChangeStateAndColour(int CPIndex, BmSDK.BmGame.GDHudExtension_GameModeBase.FSGenericGameModeState NewState, out BmSDK.BmGame.GDHudExtension_GameModeBase.EControlPointUIStateChange StateChange, out int ColourChange)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCPStateChangeStateAndColour, "BmGame.GDHudExtension_GameModeBase.GetCPStateChangeStateAndColour");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CPIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewState, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StateChange);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateChange, paramsPtr + 44);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ColourChange);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ColourChange, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        StateChange = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDHudExtension_GameModeBase.EControlPointUIStateChange>(paramsPtr + 44);
        ColourChange = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 48);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 52);
    }

    private static BmSDK.Function __fn_PushControlPointStateChanges;
    /// <summary>
    /// Function: PushControlPointStateChanges
    /// </summary>
    public unsafe virtual void PushControlPointStateChanges(BmSDK.BmGame.GDHudExtension_GameModeBase.FSGenericGameModeState NewState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushControlPointStateChanges, "BmGame.GDHudExtension_GameModeBase.PushControlPointStateChanges");
        byte* paramsPtr = stackalloc byte[65];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushParticipantStateChanges;
    /// <summary>
    /// Function: PushParticipantStateChanges
    /// </summary>
    public unsafe void PushParticipantStateChanges(BmSDK.BmGame.GDHudExtension_GameModeBase.FSGenericGameModeState NewState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushParticipantStateChanges, "BmGame.GDHudExtension_GameModeBase.PushParticipantStateChanges");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PushGenericStateChanges;
    /// <summary>
    /// Function: PushGenericStateChanges
    /// </summary>
    public unsafe virtual void PushGenericStateChanges(BmSDK.BmGame.GDHudExtension_GameModeBase.FSGenericGameModeState NewState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PushGenericStateChanges, "BmGame.GDHudExtension_GameModeBase.PushGenericStateChanges");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoStateUpdate;
    /// <summary>
    /// Function: DoStateUpdate
    /// </summary>
    public unsafe virtual void DoStateUpdate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoStateUpdate, "BmGame.GDHudExtension_GameModeBase.DoStateUpdate");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe virtual void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.GDHudExtension_GameModeBase.Tick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Close;
    /// <summary>
    /// Function: Close
    /// </summary>
    public unsafe override void Close()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Close, "BmGame.GDHudExtension_GameModeBase.Close");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopulateMovieObjects;
    /// <summary>
    /// Function: PopulateMovieObjects
    /// </summary>
    public unsafe virtual void PopulateMovieObjects()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulateMovieObjects, "BmGame.GDHudExtension_GameModeBase.PopulateMovieObjects");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Hide;
    /// <summary>
    /// Function: Hide
    /// </summary>
    public unsafe override void Hide()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Hide, "BmGame.GDHudExtension_GameModeBase.Hide");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_show;
    /// <summary>
    /// Function: show
    /// </summary>
    public unsafe override void show()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_show, "BmGame.GDHudExtension_GameModeBase.show");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override bool Init(BmSDK.BmGame.RPlayerController _RPC, BmSDK.FString _ExtensionName, BmSDK.FString _ExtensionPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.GDHudExtension_GameModeBase.Init");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionPath, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_SetGenericPlayerRespawnProgress;
    /// <summary>
    /// Function: SetGenericPlayerRespawnProgress
    /// </summary>
    public unsafe virtual void SetGenericPlayerRespawnProgress(BmSDK.GFxUI.GFxObject PlayerIcon, int RespawnProgress)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGenericPlayerRespawnProgress, "BmGame.GDHudExtension_GameModeBase.SetGenericPlayerRespawnProgress");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIcon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RespawnProgress, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SetGenericPlayerIcon;
    /// <summary>
    /// Function: SetGenericPlayerIcon
    /// </summary>
    public unsafe virtual void SetGenericPlayerIcon(BmSDK.GFxUI.GFxObject Player, BmSDK.GFxUI.GFxObject PlayerIcon, BmSDK.GFxUI.GFxObject YouIconObj, BmSDK.BmGame.GDHudExtension_GameModeBase.EPlayerIconState IconState, BmSDK.FString LocalFrameName, BmSDK.FString PlayerFrameName, bool bLocalPlayer = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGenericPlayerIcon, "BmGame.GDHudExtension_GameModeBase.SetGenericPlayerIcon");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIcon, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(YouIconObj, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconState, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalFrameName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerFrameName, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLocalPlayer, paramsPtr + 40);
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

    private static BmSDK.Function __fn_PlayGenericYouAnimation;
    /// <summary>
    /// Function: PlayGenericYouAnimation
    /// </summary>
    public unsafe virtual void PlayGenericYouAnimation(BmSDK.GFxUI.GFxObject AnimObj)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayGenericYouAnimation, "BmGame.GDHudExtension_GameModeBase.PlayGenericYouAnimation");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimObj, paramsPtr + 0);
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

    private static BmSDK.Function __fn_PlayYouAnimation;
    /// <summary>
    /// Function: PlayYouAnimation
    /// </summary>
    public unsafe virtual void PlayYouAnimation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayYouAnimation, "BmGame.GDHudExtension_GameModeBase.PlayYouAnimation");
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

    private static BmSDK.Function __fn_SetTimer;
    /// <summary>
    /// Function: SetTimer
    /// </summary>
    public unsafe void SetTimer(BmSDK.FString TimerString)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTimer, "BmGame.GDHudExtension_GameModeBase.SetTimer");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimerString, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetControlPointState;
    /// <summary>
    /// Function: SetControlPointState
    /// </summary>
    public unsafe void SetControlPointState(int CPIndex, BmSDK.BmGame.GDHudExtension_GameModeBase.EControlPointUIStateChange StateChange, int Colour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetControlPointState, "BmGame.GDHudExtension_GameModeBase.SetControlPointState");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CPIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateChange, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Colour, paramsPtr + 8);
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

    private static BmSDK.Function __fn_SetPlayerRespawnProgress;
    /// <summary>
    /// Function: SetPlayerRespawnProgress
    /// </summary>
    public unsafe void SetPlayerRespawnProgress(int PlayerIndex, bool bLefthandSide, int RespawnProgress)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPlayerRespawnProgress, "BmGame.GDHudExtension_GameModeBase.SetPlayerRespawnProgress");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLefthandSide, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RespawnProgress, paramsPtr + 8);
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

    private static BmSDK.Function __fn_SetPlayerIcon;
    /// <summary>
    /// Function: SetPlayerIcon
    /// </summary>
    public unsafe void SetPlayerIcon(int PlayerIndex, bool bLefthandSide, BmSDK.BmGame.GDHudExtension_GameModeBase.EPlayerIconState IconState, bool bLocalPlayer = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPlayerIcon, "BmGame.GDHudExtension_GameModeBase.SetPlayerIcon");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLefthandSide, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconState, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLocalPlayer, paramsPtr + 12);
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

    private static BmSDK.Function __fn_SetNumPlayers;
    /// <summary>
    /// Function: SetNumPlayers
    /// </summary>
    public unsafe void SetNumPlayers(int NumPlayers, bool bLefthandSide)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNumPlayers, "BmGame.GDHudExtension_GameModeBase.SetNumPlayers");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumPlayers, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLefthandSide, paramsPtr + 4);
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

    /// <summary>
    /// StructProperty: CurrentState
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDHudExtension_GameModeBase.FSGenericGameModeState CurrentState
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDHudExtension_GameModeBase.FSGenericGameModeState>(Ptr + 136);

    /// <summary>
    /// ObjectProperty: CPGRI
    /// </summary>
    public unsafe BmSDK.BmGame.GDGameReplicationInfo_ControlPoints CPGRI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGameReplicationInfo_ControlPoints>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// ByteProperty: LocalPlayerTeam
    /// </summary>
    public unsafe BmSDK.BmGame.GDGIBase.ETeamType LocalPlayerTeam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGIBase.ETeamType>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// FloatProperty: TimeRemaining
    /// </summary>
    public unsafe float TimeRemaining
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// BoolProperty: bPushStateUpdates
    /// </summary>
    public unsafe bool bPushStateUpdates
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 188); }
    }

    /// <summary>
    /// BoolProperty: bCPsHidden
    /// </summary>
    public unsafe bool bCPsHidden
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 188); }
    }

    /// <summary>
    /// BoolProperty: bTimerIsHidden
    /// </summary>
    public unsafe bool bTimerIsHidden
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 188); }
    }

    /// <summary>
    /// ObjectProperty: GameModeHUDObj
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject GameModeHUDObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// ObjectProperty: YouAnimObj
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject YouAnimObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// ObjectProperty: TimerObj
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject TimerObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// ArrayProperty: ControlPointObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDHudExtension_GameModeBase.FSControlPointMovie> ControlPointObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDHudExtension_GameModeBase.FSControlPointMovie>>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// StructProperty: LeftSidePlayers
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDHudExtension_GameModeBase.FSGangSideMovies LeftSidePlayers
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDHudExtension_GameModeBase.FSGangSideMovies>(Ptr + 216);

    /// <summary>
    /// StructProperty: RightSidePlayers
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDHudExtension_GameModeBase.FSGangSideMovies RightSidePlayers
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDHudExtension_GameModeBase.FSGangSideMovies>(Ptr + 228);

    /// <summary>
    /// InlineArray{StrProperty}: ControlPointFrameNames
    /// </summary>
    public InlineArray<BmSDK.FString> ControlPointFrameNames => new(4, Ptr + 240, 12, this);

    /// <summary>
    /// StrProperty: ControlPointFrameNames
    /// </summary>
    public unsafe BmSDK.FString ControlPointFrameNames_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }
    /// <summary>
    /// StrProperty: ControlPointFrameNames
    /// </summary>
    public unsafe BmSDK.FString ControlPointFrameNames_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }
    /// <summary>
    /// StrProperty: ControlPointFrameNames
    /// </summary>
    public unsafe BmSDK.FString ControlPointFrameNames_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }
    /// <summary>
    /// StrProperty: ControlPointFrameNames
    /// </summary>
    public unsafe BmSDK.FString ControlPointFrameNames_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// InlineArray{StrProperty}: PlayerIconFrameNames
    /// </summary>
    public InlineArray<BmSDK.FString> PlayerIconFrameNames => new(5, Ptr + 288, 12, this);

    /// <summary>
    /// StrProperty: PlayerIconFrameNames
    /// </summary>
    public unsafe BmSDK.FString PlayerIconFrameNames_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }
    /// <summary>
    /// StrProperty: PlayerIconFrameNames
    /// </summary>
    public unsafe BmSDK.FString PlayerIconFrameNames_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }
    /// <summary>
    /// StrProperty: PlayerIconFrameNames
    /// </summary>
    public unsafe BmSDK.FString PlayerIconFrameNames_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }
    /// <summary>
    /// StrProperty: PlayerIconFrameNames
    /// </summary>
    public unsafe BmSDK.FString PlayerIconFrameNames_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }
    /// <summary>
    /// StrProperty: PlayerIconFrameNames
    /// </summary>
    public unsafe BmSDK.FString PlayerIconFrameNames_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// StrProperty: LocalPlayerFrameName
    /// </summary>
    public unsafe BmSDK.FString LocalPlayerFrameName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// StrProperty: OtherPlayerFrameName
    /// </summary>
    public unsafe BmSDK.FString OtherPlayerFrameName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// StructProperty: NeutralCPColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor NeutralCPColor
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 372);

    /// <summary>
    /// DelegateProperty: __SortTeamByHUDIndex__Delegate
    /// </summary>
    public unsafe System.IntPtr __SortTeamByHUDIndex__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// Struct: FSGangSideMovies
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FSGangSideMovies
    {
        /// <summary>
        /// ArrayProperty: PlayerIconObjects
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDHudExtension_GameModeBase.FSPlayerIconMovies> PlayerIconObjects
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDHudExtension_GameModeBase.FSPlayerIconMovies>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FSControlPointMovie
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FSControlPointMovie
    {
        /// <summary>
        /// ObjectProperty: ControlPointObj
        /// </summary>
        public unsafe BmSDK.GFxUI.GFxObject ControlPointObj
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: ControlPointPulseObj
        /// </summary>
        public unsafe BmSDK.GFxUI.GFxObject ControlPointPulseObj
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FSPlayerIconMovies
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FSPlayerIconMovies
    {
        /// <summary>
        /// ObjectProperty: PlayerObj
        /// </summary>
        public unsafe BmSDK.GFxUI.GFxObject PlayerObj
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: PlayerIconObj
        /// </summary>
        public unsafe BmSDK.GFxUI.GFxObject PlayerIconObj
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ObjectProperty: PlayerFillObj
        /// </summary>
        public unsafe BmSDK.GFxUI.GFxObject PlayerFillObj
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FSGenericGameModeState
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial record struct FSGenericGameModeState
    {
        /// <summary>
        /// ArrayProperty: LeftSideParticipants
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDHudExtension_GameModeBase.FSGameModeParticipant> LeftSideParticipants
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDHudExtension_GameModeBase.FSGameModeParticipant>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: RightSideParticipants
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDHudExtension_GameModeBase.FSGameModeParticipant> RightSideParticipants
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDHudExtension_GameModeBase.FSGameModeParticipant>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ByteProperty: ControlPointState
        /// </summary>
        public unsafe BmSDK.BmGame.GDGameReplicationInfo_ControlPoints.EControlPointState ControlPointState_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGameReplicationInfo_ControlPoints.EControlPointState>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
        /// <summary>
        /// ByteProperty: ControlPointState
        /// </summary>
        public unsafe BmSDK.BmGame.GDGameReplicationInfo_ControlPoints.EControlPointState ControlPointState_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGameReplicationInfo_ControlPoints.EControlPointState>(Ptr + 25); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 25); }; }
        }
        /// <summary>
        /// ByteProperty: ControlPointState
        /// </summary>
        public unsafe BmSDK.BmGame.GDGameReplicationInfo_ControlPoints.EControlPointState ControlPointState_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGameReplicationInfo_ControlPoints.EControlPointState>(Ptr + 26); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 26); }; }
        }

        /// <summary>
        /// StrProperty: TimeRemaining
        /// </summary>
        public unsafe BmSDK.FString TimeRemaining
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
    }

    /// <summary>
    /// Struct: FSGameModeParticipant
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FSGameModeParticipant
    {
        /// <summary>
        /// ByteProperty: PlayerIconState
        /// </summary>
        public unsafe BmSDK.BmGame.GDHudExtension_GameModeBase.EPlayerIconState PlayerIconState
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDHudExtension_GameModeBase.EPlayerIconState>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: RespawnProgress
        /// </summary>
        public unsafe int RespawnProgress
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Enum: EControlPointUIStateChange
    /// </summary>
    public enum EControlPointUIStateChange : byte
    {
        EControlPointUIStateChange_Invalid = 0,
        EControlPointUIStateChange_Neutral = 1,
        EControlPointUIStateChange_NeutralToOccupied = 2,
        EControlPointUIStateChange_OccupiedToNeutral = 3,
        EControlPointUIStateChange_MAX = 4,
    }

    /// <summary>
    /// Enum: EPlayerIconState
    /// </summary>
    public enum EPlayerIconState : byte
    {
        EPlayerIconState_Invalid = 0,
        EPlayerIconState_Alive = 1,
        EPlayerIconState_DeadNoRespawn = 2,
        EPlayerIconState_DeadRespawn = 3,
        EPlayerIconState_KO = 4,
        EPlayerIconState_MAX = 5,
    }
}
