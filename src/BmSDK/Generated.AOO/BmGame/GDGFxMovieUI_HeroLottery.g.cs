#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDGFxMovieUI_HeroLottery<br/>
/// (size = 2144)
/// (flags = 134250646)
/// </summary>
public partial class GDGFxMovieUI_HeroLottery : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDGFxMovieUI_HeroLottery", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDGFxMovieUI_HeroLottery.
    /// </summary>
    public static GDGFxMovieUI_HeroLottery DefaultObject => (GDGFxMovieUI_HeroLottery)StaticClass().DefaultObject;

    internal GDGFxMovieUI_HeroLottery() { }

    /// <summary>
    /// Constructs a new GDGFxMovieUI_HeroLottery
    /// </summary>
    public GDGFxMovieUI_HeroLottery(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDGFxMovieUI_HeroLottery Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDGFxMovieUI_HeroLottery(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_HeroLottery>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_HeroLottery>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_HeroLottery>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_HeroLottery>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_HeroLottery>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_HeroLottery>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_HeroLottery>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_HeroLottery>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_asGetPlayerNamesObject;
    /// <summary>
    /// Function: asGetPlayerNamesObject
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject asGetPlayerNamesObject()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetPlayerNamesObject, "BmGame.GDGFxMovieUI_HeroLottery.asGetPlayerNamesObject");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_asGetLotteryParticipantMovieForIndex;
    /// <summary>
    /// Function: asGetLotteryParticipantMovieForIndex
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject asGetLotteryParticipantMovieForIndex(int PlayerIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetLotteryParticipantMovieForIndex, "BmGame.GDGFxMovieUI_HeroLottery.asGetLotteryParticipantMovieForIndex");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_asGetLotteryParticipantAvatarMovieForIndex;
    /// <summary>
    /// Function: asGetLotteryParticipantAvatarMovieForIndex
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject asGetLotteryParticipantAvatarMovieForIndex(int PlayerIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetLotteryParticipantAvatarMovieForIndex, "BmGame.GDGFxMovieUI_HeroLottery.asGetLotteryParticipantAvatarMovieForIndex");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_asSetAvatarColour;
    /// <summary>
    /// Function: asSetAvatarColour
    /// </summary>
    public unsafe virtual void asSetAvatarColour(BmSDK.GFxUI.GFxObject AvatarMovie, int AvatarColour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetAvatarColour, "BmGame.GDGFxMovieUI_HeroLottery.asSetAvatarColour");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvatarMovie, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvatarColour, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asGetLotteryWheelAvatarFrameIndex;
    /// <summary>
    /// Function: asGetLotteryWheelAvatarFrameIndex
    /// </summary>
    public unsafe virtual int asGetLotteryWheelAvatarFrameIndex(BmSDK.FString ForAvatar)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetLotteryWheelAvatarFrameIndex, "BmGame.GDGFxMovieUI_HeroLottery.asGetLotteryWheelAvatarFrameIndex");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForAvatar, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_asGetLotteryWheelHighlightFrameIndex;
    /// <summary>
    /// Function: asGetLotteryWheelHighlightFrameIndex
    /// </summary>
    public unsafe virtual int asGetLotteryWheelHighlightFrameIndex(int SegmentIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetLotteryWheelHighlightFrameIndex, "BmGame.GDGFxMovieUI_HeroLottery.asGetLotteryWheelHighlightFrameIndex");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SegmentIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_asGetLotteryWheelAvatarObjectForIndex;
    /// <summary>
    /// Function: asGetLotteryWheelAvatarObjectForIndex
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject asGetLotteryWheelAvatarObjectForIndex(int PlayerIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetLotteryWheelAvatarObjectForIndex, "BmGame.GDGFxMovieUI_HeroLottery.asGetLotteryWheelAvatarObjectForIndex");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_asGetLotteryWheelHighlightObjectForIndex;
    /// <summary>
    /// Function: asGetLotteryWheelHighlightObjectForIndex
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject asGetLotteryWheelHighlightObjectForIndex(int PlayerIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetLotteryWheelHighlightObjectForIndex, "BmGame.GDGFxMovieUI_HeroLottery.asGetLotteryWheelHighlightObjectForIndex");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_asSetPlayerAvatarIcon;
    /// <summary>
    /// Function: asSetPlayerAvatarIcon
    /// </summary>
    public unsafe virtual void asSetPlayerAvatarIcon(int PlayerIndex, BmSDK.FString AvatarString, bool bHighlight)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetPlayerAvatarIcon, "BmGame.GDGFxMovieUI_HeroLottery.asSetPlayerAvatarIcon");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvatarString, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHighlight, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetShowHeroArrowType;
    /// <summary>
    /// Function: asSetShowHeroArrowType
    /// </summary>
    public unsafe virtual void asSetShowHeroArrowType(bool bShowRobin)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetShowHeroArrowType, "BmGame.GDGFxMovieUI_HeroLottery.asSetShowHeroArrowType");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowRobin, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asShowHeroesStayOn;
    /// <summary>
    /// Function: asShowHeroesStayOn
    /// </summary>
    public unsafe virtual void asShowHeroesStayOn(bool bShowRobin)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asShowHeroesStayOn, "BmGame.GDGFxMovieUI_HeroLottery.asShowHeroesStayOn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowRobin, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asFinishedSendingLotteryData;
    /// <summary>
    /// Function: asFinishedSendingLotteryData
    /// </summary>
    public unsafe virtual void asFinishedSendingLotteryData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asFinishedSendingLotteryData, "BmGame.GDGFxMovieUI_HeroLottery.asFinishedSendingLotteryData");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetLotteryOptOputPlayerListEntry;
    /// <summary>
    /// Function: asSetLotteryOptOputPlayerListEntry
    /// </summary>
    public unsafe virtual void asSetLotteryOptOputPlayerListEntry(int ElementIndex, BmSDK.FString PlayerName, BmSDK.FString PlayerAvatar, bool bLocalPlayer, int Colour, bool bSetLeft)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetLotteryOptOputPlayerListEntry, "BmGame.GDGFxMovieUI_HeroLottery.asSetLotteryOptOputPlayerListEntry");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ElementIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerAvatar, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLocalPlayer, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Colour, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSetLeft, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asResetLotteryOptOutPlayerLists;
    /// <summary>
    /// Function: asResetLotteryOptOutPlayerLists
    /// </summary>
    public unsafe virtual void asResetLotteryOptOutPlayerLists()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asResetLotteryOptOutPlayerLists, "BmGame.GDGFxMovieUI_HeroLottery.asResetLotteryOptOutPlayerLists");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetPlayerOptOutState;
    /// <summary>
    /// Function: asSetPlayerOptOutState
    /// </summary>
    public unsafe virtual void asSetPlayerOptOutState(BmSDK.FString PlayerName, BmSDK.FString PlayerAvatar, bool bOptedOut, int OptOutColour, bool OptOutPlayerIsHero)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetPlayerOptOutState, "BmGame.GDGFxMovieUI_HeroLottery.asSetPlayerOptOutState");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerAvatar, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOptedOut, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OptOutColour, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OptOutPlayerIsHero, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetWheelInSpinMode;
    /// <summary>
    /// Function: asSetWheelInSpinMode
    /// </summary>
    public unsafe virtual void asSetWheelInSpinMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetWheelInSpinMode, "BmGame.GDGFxMovieUI_HeroLottery.asSetWheelInSpinMode");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetShowHeroOptOut;
    /// <summary>
    /// Function: asSetShowHeroOptOut
    /// </summary>
    public unsafe virtual void asSetShowHeroOptOut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetShowHeroOptOut, "BmGame.GDGFxMovieUI_HeroLottery.asSetShowHeroOptOut");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asUpdateOptOutTimer;
    /// <summary>
    /// Function: asUpdateOptOutTimer
    /// </summary>
    public unsafe virtual int asUpdateOptOutTimer(BmSDK.FString TimerString, float TimerProgress)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asUpdateOptOutTimer, "BmGame.GDGFxMovieUI_HeroLottery.asUpdateOptOutTimer");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimerString, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimerProgress, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_asInitailisePlayerOptOutData;
    /// <summary>
    /// Function: asInitailisePlayerOptOutData
    /// </summary>
    public unsafe virtual void asInitailisePlayerOptOutData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asInitailisePlayerOptOutData, "BmGame.GDGFxMovieUI_HeroLottery.asInitailisePlayerOptOutData");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asInitailisePlayerLotteryData;
    /// <summary>
    /// Function: asInitailisePlayerLotteryData
    /// </summary>
    public unsafe virtual void asInitailisePlayerLotteryData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asInitailisePlayerLotteryData, "BmGame.GDGFxMovieUI_HeroLottery.asInitailisePlayerLotteryData");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetNumCircleSegments;
    /// <summary>
    /// Function: asSetNumCircleSegments
    /// </summary>
    public unsafe virtual void asSetNumCircleSegments(int NumRightSegments, int NumLeftSegments, bool bSetSpinSegments)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetNumCircleSegments, "BmGame.GDGFxMovieUI_HeroLottery.asSetNumCircleSegments");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumRightSegments, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumLeftSegments, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSetSpinSegments, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetShowThreeSegmentCircle;
    /// <summary>
    /// Function: asSetShowThreeSegmentCircle
    /// </summary>
    public unsafe virtual void asSetShowThreeSegmentCircle(bool bSetSpinSegments)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetShowThreeSegmentCircle, "BmGame.GDGFxMovieUI_HeroLottery.asSetShowThreeSegmentCircle");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSetSpinSegments, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asGetLotteryWheelSpinnerEndFrameNum;
    /// <summary>
    /// Function: asGetLotteryWheelSpinnerEndFrameNum
    /// </summary>
    public unsafe virtual int asGetLotteryWheelSpinnerEndFrameNum()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetLotteryWheelSpinnerEndFrameNum, "BmGame.GDGFxMovieUI_HeroLottery.asGetLotteryWheelSpinnerEndFrameNum");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_asGetLotteryWheelSpinnerStartFrameNum;
    /// <summary>
    /// Function: asGetLotteryWheelSpinnerStartFrameNum
    /// </summary>
    public unsafe virtual int asGetLotteryWheelSpinnerStartFrameNum()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetLotteryWheelSpinnerStartFrameNum, "BmGame.GDGFxMovieUI_HeroLottery.asGetLotteryWheelSpinnerStartFrameNum");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_asGetLotteryWheelReverseSpinObject;
    /// <summary>
    /// Function: asGetLotteryWheelReverseSpinObject
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject asGetLotteryWheelReverseSpinObject()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetLotteryWheelReverseSpinObject, "BmGame.GDGFxMovieUI_HeroLottery.asGetLotteryWheelReverseSpinObject");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_asGetLotteryWheelForwardSpinObject;
    /// <summary>
    /// Function: asGetLotteryWheelForwardSpinObject
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject asGetLotteryWheelForwardSpinObject()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetLotteryWheelForwardSpinObject, "BmGame.GDGFxMovieUI_HeroLottery.asGetLotteryWheelForwardSpinObject");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_asGetAvatarFrameNumberForState;
    /// <summary>
    /// Function: asGetAvatarFrameNumberForState
    /// </summary>
    public unsafe virtual int asGetAvatarFrameNumberForState(int State)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetAvatarFrameNumberForState, "BmGame.GDGFxMovieUI_HeroLottery.asGetAvatarFrameNumberForState");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(State, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_asGetHighlightFrameNumberForState;
    /// <summary>
    /// Function: asGetHighlightFrameNumberForState
    /// </summary>
    public unsafe virtual int asGetHighlightFrameNumberForState(int State)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetHighlightFrameNumberForState, "BmGame.GDGFxMovieUI_HeroLottery.asGetHighlightFrameNumberForState");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(State, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TogglePlayerHeroLottery;
    /// <summary>
    /// Function: TogglePlayerHeroLottery
    /// </summary>
    public unsafe virtual void TogglePlayerHeroLottery()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TogglePlayerHeroLottery, "BmGame.GDGFxMovieUI_HeroLottery.TogglePlayerHeroLottery");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInitialObjectStates;
    /// <summary>
    /// Function: SetInitialObjectStates
    /// </summary>
    public unsafe virtual void SetInitialObjectStates()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInitialObjectStates, "BmGame.GDGFxMovieUI_HeroLottery.SetInitialObjectStates");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetFrameIndices;
    /// <summary>
    /// Function: GetFrameIndices
    /// </summary>
    public unsafe virtual void GetFrameIndices()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFrameIndices, "BmGame.GDGFxMovieUI_HeroLottery.GetFrameIndices");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetMovieObjects;
    /// <summary>
    /// Function: GetMovieObjects
    /// </summary>
    public unsafe virtual void GetMovieObjects()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMovieObjects, "BmGame.GDGFxMovieUI_HeroLottery.GetMovieObjects");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartSpinningWheel;
    /// <summary>
    /// Function: StartSpinningWheel
    /// </summary>
    public unsafe virtual void StartSpinningWheel(BmSDK.FString WheelMoviePath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartSpinningWheel, "BmGame.GDGFxMovieUI_HeroLottery.StartSpinningWheel");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WheelMoviePath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RespondToButtonPress;
    /// <summary>
    /// Function: RespondToButtonPress
    /// </summary>
    public unsafe virtual void RespondToButtonPress(int _button)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RespondToButtonPress, "BmGame.GDGFxMovieUI_HeroLottery.RespondToButtonPress");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_button, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FlashMovieReadyForData;
    /// <summary>
    /// Function: FlashMovieReadyForData
    /// </summary>
    public unsafe virtual void FlashMovieReadyForData(BmSDK.FString TargetPath)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlashMovieReadyForData, "BmGame.GDGFxMovieUI_HeroLottery.FlashMovieReadyForData");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAvatarColour;
    /// <summary>
    /// Function: SetAvatarColour
    /// </summary>
    public unsafe virtual void SetAvatarColour(int SegmentIndex, int AvatarColour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAvatarColour, "BmGame.GDGFxMovieUI_HeroLottery.SetAvatarColour");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SegmentIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvatarColour, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishedSpinningWheel;
    /// <summary>
    /// Function: FinishedSpinningWheel
    /// </summary>
    public unsafe virtual void FinishedSpinningWheel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishedSpinningWheel, "BmGame.GDGFxMovieUI_HeroLottery.FinishedSpinningWheel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDefaultHighlightState;
    /// <summary>
    /// Function: GetDefaultHighlightState
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDGFxMovieUI_HeroLottery.EHeroLotteryHighlightState GetDefaultHighlightState(BmSDK.BmGame.GDGFxMovieUI_HeroLottery.FSHeroLotteryPlayerData Player)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultHighlightState, "BmGame.GDGFxMovieUI_HeroLottery.GetDefaultHighlightState");
        byte* paramsPtr = stackalloc byte[49];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDGFxMovieUI_HeroLottery.EHeroLotteryHighlightState>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_GetDefaultAvatarState;
    /// <summary>
    /// Function: GetDefaultAvatarState
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDGFxMovieUI_HeroLottery.EHeroLotteryAvatarState GetDefaultAvatarState(BmSDK.BmGame.GDGFxMovieUI_HeroLottery.FSHeroLotteryPlayerData Player)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDefaultAvatarState, "BmGame.GDGFxMovieUI_HeroLottery.GetDefaultAvatarState");
        byte* paramsPtr = stackalloc byte[49];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDGFxMovieUI_HeroLottery.EHeroLotteryAvatarState>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_SendLotteryWheelData;
    /// <summary>
    /// Function: SendLotteryWheelData
    /// </summary>
    public unsafe virtual void SendLotteryWheelData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendLotteryWheelData, "BmGame.GDGFxMovieUI_HeroLottery.SendLotteryWheelData");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CalculateTotalRotationDegrees;
    /// <summary>
    /// Function: CalculateTotalRotationDegrees
    /// </summary>
    public unsafe virtual void CalculateTotalRotationDegrees()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateTotalRotationDegrees, "BmGame.GDGFxMovieUI_HeroLottery.CalculateTotalRotationDegrees");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CalculateRequiredRobinSlotIndex;
    /// <summary>
    /// Function: CalculateRequiredRobinSlotIndex
    /// </summary>
    public unsafe virtual int CalculateRequiredRobinSlotIndex(BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_HeroLottery.FSHeroLotteryPlayerData> OnSide)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateRequiredRobinSlotIndex, "BmGame.GDGFxMovieUI_HeroLottery.CalculateRequiredRobinSlotIndex");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnSide, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SwapPlayers;
    /// <summary>
    /// Function: SwapPlayers
    /// </summary>
    public unsafe virtual void SwapPlayers(int FromIndex, int ToIndex, out BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_HeroLottery.FSHeroLotteryPlayerData> FromArray, out BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_HeroLottery.FSHeroLotteryPlayerData> ToArray)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwapPlayers, "BmGame.GDGFxMovieUI_HeroLottery.SwapPlayers");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FromIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        FromArray = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_HeroLottery.FSHeroLotteryPlayerData>>(paramsPtr + 8);
        ToArray = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_HeroLottery.FSHeroLotteryPlayerData>>(paramsPtr + 20);
        return;
    }

    private static BmSDK.Function __fn_ShuffleParticipantsIntoPosition;
    /// <summary>
    /// Function: ShuffleParticipantsIntoPosition
    /// </summary>
    public unsafe virtual void ShuffleParticipantsIntoPosition()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShuffleParticipantsIntoPosition, "BmGame.GDGFxMovieUI_HeroLottery.ShuffleParticipantsIntoPosition");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSegmentAngleData;
    /// <summary>
    /// Function: SetSegmentAngleData
    /// </summary>
    public unsafe virtual void SetSegmentAngleData(float MaxAngle, int SegmentNumber, int MaxSegments, out BmSDK.BmGame.GDGFxMovieUI_HeroLottery.FSHeroLotteryPlayerData ParticipantData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSegmentAngleData, "BmGame.GDGFxMovieUI_HeroLottery.SetSegmentAngleData");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxAngle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SegmentNumber, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxSegments, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ParticipantData);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParticipantData, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ParticipantData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDGFxMovieUI_HeroLottery.FSHeroLotteryPlayerData>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_ConstructTwoTeamParticipantArray;
    /// <summary>
    /// Function: ConstructTwoTeamParticipantArray
    /// </summary>
    public unsafe virtual void ConstructTwoTeamParticipantArray(BmSDK.TArray<BmSDK.BmGame.RPlayerRI> RightParticipants, BmSDK.TArray<BmSDK.BmGame.RPlayerRI> LeftParticipants)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConstructTwoTeamParticipantArray, "BmGame.GDGFxMovieUI_HeroLottery.ConstructTwoTeamParticipantArray");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RightParticipants, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeftParticipants, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ConstructOneTeamParticipantArray;
    /// <summary>
    /// Function: ConstructOneTeamParticipantArray
    /// </summary>
    public unsafe virtual void ConstructOneTeamParticipantArray(BmSDK.TArray<BmSDK.BmGame.RPlayerRI> Participants)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConstructOneTeamParticipantArray, "BmGame.GDGFxMovieUI_HeroLottery.ConstructOneTeamParticipantArray");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Participants, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ConstructLotteryWheelData;
    /// <summary>
    /// Function: ConstructLotteryWheelData
    /// </summary>
    public unsafe virtual void ConstructLotteryWheelData(BmSDK.TArray<BmSDK.Engine.PlayerReplicationInfo> PRIArray)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ConstructLotteryWheelData, "BmGame.GDGFxMovieUI_HeroLottery.ConstructLotteryWheelData");
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PRIArray, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendNonParticipantPlayerData;
    /// <summary>
    /// Function: SendNonParticipantPlayerData
    /// </summary>
    public unsafe virtual void SendNonParticipantPlayerData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendNonParticipantPlayerData, "BmGame.GDGFxMovieUI_HeroLottery.SendNonParticipantPlayerData");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetFakePRIArray;
    /// <summary>
    /// Function: GetFakePRIArray
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.BmGame.RPlayerRI> GetFakePRIArray(int NumJoker, int NumBane, int NumHero)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFakePRIArray, "BmGame.GDGFxMovieUI_HeroLottery.GetFakePRIArray");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumJoker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumBane, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumHero, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RPlayerRI>>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SendFakeSpinScreenData;
    /// <summary>
    /// Function: SendFakeSpinScreenData
    /// </summary>
    public unsafe virtual void SendFakeSpinScreenData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendFakeSpinScreenData, "BmGame.GDGFxMovieUI_HeroLottery.SendFakeSpinScreenData");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendSpinScreenData;
    /// <summary>
    /// Function: SendSpinScreenData
    /// </summary>
    public unsafe virtual void SendSpinScreenData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendSpinScreenData, "BmGame.GDGFxMovieUI_HeroLottery.SendSpinScreenData");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerOptOutStatusChanged;
    /// <summary>
    /// Function: PlayerOptOutStatusChanged
    /// </summary>
    public unsafe virtual void PlayerOptOutStatusChanged(BmSDK.BmGame.RPlayerRI Player)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerOptOutStatusChanged, "BmGame.GDGFxMovieUI_HeroLottery.PlayerOptOutStatusChanged");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateOptOutTimer;
    /// <summary>
    /// Function: UpdateOptOutTimer
    /// </summary>
    public unsafe virtual void UpdateOptOutTimer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateOptOutTimer, "BmGame.GDGFxMovieUI_HeroLottery.UpdateOptOutTimer");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetOptOutStatus;
    /// <summary>
    /// Function: SetOptOutStatus
    /// </summary>
    public unsafe virtual void SetOptOutStatus(bool bOptOut, bool bApplyCooldown = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOptOutStatus, "BmGame.GDGFxMovieUI_HeroLottery.SetOptOutStatus");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOptOut, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bApplyCooldown, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessOptOutButtonPress;
    /// <summary>
    /// Function: ProcessOptOutButtonPress
    /// </summary>
    public unsafe virtual void ProcessOptOutButtonPress(bool bOptOut)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessOptOutButtonPress, "BmGame.GDGFxMovieUI_HeroLottery.ProcessOptOutButtonPress");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOptOut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SortPlayerList;
    /// <summary>
    /// Function: SortPlayerList
    /// </summary>
    public unsafe virtual int SortPlayerList(BmSDK.BmGame.RPlayerRI A, BmSDK.BmGame.RPlayerRI B)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SortPlayerList, "BmGame.GDGFxMovieUI_HeroLottery.SortPlayerList");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SendOptOutScreenData;
    /// <summary>
    /// Function: SendOptOutScreenData
    /// </summary>
    public unsafe virtual void SendOptOutScreenData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendOptOutScreenData, "BmGame.GDGFxMovieUI_HeroLottery.SendOptOutScreenData");
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugLog;
    /// <summary>
    /// Function: DebugLog
    /// </summary>
    public unsafe virtual void DebugLog(BmSDK.FString LogString)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugLog, "BmGame.GDGFxMovieUI_HeroLottery.DebugLog");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LogString, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ScreenReadyForData;
    /// <summary>
    /// Function: ScreenReadyForData
    /// </summary>
    public unsafe virtual void ScreenReadyForData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScreenReadyForData, "BmGame.GDGFxMovieUI_HeroLottery.ScreenReadyForData");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoState;
    /// <summary>
    /// Function: GotoState
    /// </summary>
    public unsafe virtual void GotoState(BmSDK.BmGame.GDGFxMovieUI_HeroLottery.EHeroLotteryState NextState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoState, "BmGame.GDGFxMovieUI_HeroLottery.GotoState");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsTeamAllowedToOptOut;
    /// <summary>
    /// Function: IsTeamAllowedToOptOut
    /// </summary>
    public unsafe virtual bool IsTeamAllowedToOptOut(BmSDK.BmGame.GDGIBase.ETeamType Team)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsTeamAllowedToOptOut, "BmGame.GDGFxMovieUI_HeroLottery.IsTeamAllowedToOptOut");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CanChangeOptStatus;
    /// <summary>
    /// Function: CanChangeOptStatus
    /// </summary>
    public unsafe virtual bool CanChangeOptStatus()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanChangeOptStatus, "BmGame.GDGFxMovieUI_HeroLottery.CanChangeOptStatus");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe virtual void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.GDGFxMovieUI_HeroLottery.Tick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetLocString;
    /// <summary>
    /// Function: GetLocString
    /// </summary>
    public unsafe virtual BmSDK.FString GetLocString(BmSDK.FString _key)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocString, "BmGame.GDGFxMovieUI_HeroLottery.GetLocString");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_key, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetToolTip;
    /// <summary>
    /// Function: GetToolTip
    /// </summary>
    public unsafe virtual BmSDK.FString GetToolTip()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetToolTip, "BmGame.GDGFxMovieUI_HeroLottery.GetToolTip");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HideHeroLottery;
    /// <summary>
    /// Function: HideHeroLottery
    /// </summary>
    public unsafe virtual void HideHeroLottery()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideHeroLottery, "BmGame.GDGFxMovieUI_HeroLottery.HideHeroLottery");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowHeroLottery;
    /// <summary>
    /// Function: ShowHeroLottery
    /// </summary>
    public unsafe virtual void ShowHeroLottery()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowHeroLottery, "BmGame.GDGFxMovieUI_HeroLottery.ShowHeroLottery");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.GDGFxMovieUI_HeroLottery.Init");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoPlayerNameFade;
    /// <summary>
    /// Function: DoPlayerNameFade
    /// </summary>
    public unsafe void DoPlayerNameFade(float SpinPercentage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoPlayerNameFade, "BmGame.GDGFxMovieUI_HeroLottery.DoPlayerNameFade");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpinPercentage, paramsPtr + 0);
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

    private static BmSDK.Function __fn_DoPseudoSpinAnimation;
    /// <summary>
    /// Function: DoPseudoSpinAnimation
    /// </summary>
    public unsafe void DoPseudoSpinAnimation(float SpinPercentage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoPseudoSpinAnimation, "BmGame.GDGFxMovieUI_HeroLottery.DoPseudoSpinAnimation");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpinPercentage, paramsPtr + 0);
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

    private static BmSDK.Function __fn_RotationDegreesToSegmentIndex;
    /// <summary>
    /// Function: RotationDegreesToSegmentIndex
    /// </summary>
    public unsafe int RotationDegreesToSegmentIndex(int Rotation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RotationDegreesToSegmentIndex, "BmGame.GDGFxMovieUI_HeroLottery.RotationDegreesToSegmentIndex");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rotation, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SegmentIndexToPlayerData;
    /// <summary>
    /// Function: SegmentIndexToPlayerData
    /// </summary>
    public unsafe BmSDK.BmGame.GDGFxMovieUI_HeroLottery.FSHeroLotteryPlayerData SegmentIndexToPlayerData(int SegmentIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SegmentIndexToPlayerData, "BmGame.GDGFxMovieUI_HeroLottery.SegmentIndexToPlayerData");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SegmentIndex, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDGFxMovieUI_HeroLottery.FSHeroLotteryPlayerData>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetAvatarFrameNumberForState;
    /// <summary>
    /// Function: GetAvatarFrameNumberForState
    /// </summary>
    public unsafe int GetAvatarFrameNumberForState(BmSDK.BmGame.GDGFxMovieUI_HeroLottery.EHeroLotteryAvatarState State)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAvatarFrameNumberForState, "BmGame.GDGFxMovieUI_HeroLottery.GetAvatarFrameNumberForState");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(State, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetHighlightFrameNumberForState;
    /// <summary>
    /// Function: GetHighlightFrameNumberForState
    /// </summary>
    public unsafe int GetHighlightFrameNumberForState(BmSDK.BmGame.GDGFxMovieUI_HeroLottery.EHeroLotteryHighlightState State)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHighlightFrameNumberForState, "BmGame.GDGFxMovieUI_HeroLottery.GetHighlightFrameNumberForState");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(State, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetPlayerHighlight;
    /// <summary>
    /// Function: SetPlayerHighlight
    /// </summary>
    public unsafe virtual void SetPlayerHighlight(int SegmentIndex, BmSDK.BmGame.GDGFxMovieUI_HeroLottery.EHeroLotteryHighlightState HighlightState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPlayerHighlight, "BmGame.GDGFxMovieUI_HeroLottery.SetPlayerHighlight");
        byte* paramsPtr = stackalloc byte[21];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SegmentIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HighlightState, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SetPlayerAvatar;
    /// <summary>
    /// Function: SetPlayerAvatar
    /// </summary>
    public unsafe virtual void SetPlayerAvatar(int SegmentIndex, BmSDK.BmGame.GDGFxMovieUI_HeroLottery.EHeroLotteryAvatarState AvatarState, int WithColour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPlayerAvatar, "BmGame.GDGFxMovieUI_HeroLottery.SetPlayerAvatar");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SegmentIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvatarState, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WithColour, paramsPtr + 8);
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

    private static BmSDK.Function __fn_HighlightLotteryPlayer;
    /// <summary>
    /// Function: HighlightLotteryPlayer
    /// </summary>
    public unsafe virtual void HighlightLotteryPlayer(int SegmentIndex, bool bHighlight)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HighlightLotteryPlayer, "BmGame.GDGFxMovieUI_HeroLottery.HighlightLotteryPlayer");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SegmentIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHighlight, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SetHighlightedHeroPlayers;
    /// <summary>
    /// Function: SetHighlightedHeroPlayers
    /// </summary>
    public unsafe virtual void SetHighlightedHeroPlayers(int ForceBatmanIndex = default, int ForceRobinIndex = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHighlightedHeroPlayers, "BmGame.GDGFxMovieUI_HeroLottery.SetHighlightedHeroPlayers");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceBatmanIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceRobinIndex, paramsPtr + 4);
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

    private static BmSDK.Function __fn_TickWheelSpin;
    /// <summary>
    /// Function: TickWheelSpin
    /// </summary>
    public unsafe virtual void TickWheelSpin(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickWheelSpin, "BmGame.GDGFxMovieUI_HeroLottery.TickWheelSpin");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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
    /// ByteProperty: CurrentState
    /// </summary>
    public unsafe BmSDK.BmGame.GDGFxMovieUI_HeroLottery.EHeroLotteryState CurrentState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGFxMovieUI_HeroLottery.EHeroLotteryState>(Ptr + 1708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1708); }
    }

    /// <summary>
    /// BoolProperty: bOptOutEnabled
    /// </summary>
    public unsafe bool bOptOutEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bThreeSegmentLotteryWheel
    /// </summary>
    public unsafe bool bThreeSegmentLotteryWheel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bSkipSpinning
    /// </summary>
    public unsafe bool bSkipSpinning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bIsVisible
    /// </summary>
    public unsafe bool bIsVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bSpinWheelMovie
    /// </summary>
    public unsafe bool bSpinWheelMovie
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// FloatProperty: OptOutCooldown
    /// </summary>
    public unsafe float OptOutCooldown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }

    /// <summary>
    /// FloatProperty: OptOutPhaseEndTime
    /// </summary>
    public unsafe float OptOutPhaseEndTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }
    }

    /// <summary>
    /// IntProperty: PreviousProgressFrame
    /// </summary>
    public unsafe int PreviousProgressFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1724); }
    }

    /// <summary>
    /// ArrayProperty: OptOutPlayers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPlayerRI> OptOutPlayers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPlayerRI>>(Ptr + 1728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1728); }
    }

    /// <summary>
    /// ArrayProperty: LotteryWheelDataRight
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_HeroLottery.FSHeroLotteryPlayerData> LotteryWheelDataRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_HeroLottery.FSHeroLotteryPlayerData>>(Ptr + 1740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1740); }
    }

    /// <summary>
    /// ArrayProperty: LotteryWheelDataLeft
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_HeroLottery.FSHeroLotteryPlayerData> LotteryWheelDataLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_HeroLottery.FSHeroLotteryPlayerData>>(Ptr + 1752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1752); }
    }

    /// <summary>
    /// StructProperty: BatmanData
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGFxMovieUI_HeroLottery.FSHeroLotteryPlayerData BatmanData
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGFxMovieUI_HeroLottery.FSHeroLotteryPlayerData>(Ptr + 1764);

    /// <summary>
    /// StructProperty: RobinData
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGFxMovieUI_HeroLottery.FSHeroLotteryPlayerData RobinData
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGFxMovieUI_HeroLottery.FSHeroLotteryPlayerData>(Ptr + 1796);

    /// <summary>
    /// ArrayProperty: LotteryWheelHighlightObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GFxUI.GFxObject> LotteryWheelHighlightObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GFxUI.GFxObject>>(Ptr + 1828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1828); }
    }

    /// <summary>
    /// ArrayProperty: LotteryWheelAvatarObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GFxUI.GFxObject> LotteryWheelAvatarObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GFxUI.GFxObject>>(Ptr + 1840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1840); }
    }

    /// <summary>
    /// ArrayProperty: LotteryParticipantsAvatarLayer
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GFxUI.GFxObject> LotteryParticipantsAvatarLayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GFxUI.GFxObject>>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// ArrayProperty: LotteryParticipantsHighlightLayer
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GFxUI.GFxObject> LotteryParticipantsHighlightLayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GFxUI.GFxObject>>(Ptr + 1864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1864); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: AvatarFrameNumbers
    /// </summary>
    public InlineArray<int> AvatarFrameNumbers => new(6, Ptr + 1876, 4, this);

    /// <summary>
    /// IntProperty: AvatarFrameNumbers
    /// </summary>
    public unsafe int AvatarFrameNumbers_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1876); }
    }
    /// <summary>
    /// IntProperty: AvatarFrameNumbers
    /// </summary>
    public unsafe int AvatarFrameNumbers_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1880); }
    }
    /// <summary>
    /// IntProperty: AvatarFrameNumbers
    /// </summary>
    public unsafe int AvatarFrameNumbers_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1884); }
    }
    /// <summary>
    /// IntProperty: AvatarFrameNumbers
    /// </summary>
    public unsafe int AvatarFrameNumbers_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1888); }
    }
    /// <summary>
    /// IntProperty: AvatarFrameNumbers
    /// </summary>
    public unsafe int AvatarFrameNumbers_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1892); }
    }
    /// <summary>
    /// IntProperty: AvatarFrameNumbers
    /// </summary>
    public unsafe int AvatarFrameNumbers_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1896); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: HighlightFrameNumbers
    /// </summary>
    public InlineArray<int> HighlightFrameNumbers => new(3, Ptr + 1900, 4, this);

    /// <summary>
    /// IntProperty: HighlightFrameNumbers
    /// </summary>
    public unsafe int HighlightFrameNumbers_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1900); }
    }
    /// <summary>
    /// IntProperty: HighlightFrameNumbers
    /// </summary>
    public unsafe int HighlightFrameNumbers_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1904); }
    }
    /// <summary>
    /// IntProperty: HighlightFrameNumbers
    /// </summary>
    public unsafe int HighlightFrameNumbers_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1908); }
    }

    /// <summary>
    /// IntProperty: TargetRotationDegrees
    /// </summary>
    public unsafe int TargetRotationDegrees
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1912); }
    }

    /// <summary>
    /// FloatProperty: EndRotationDegree
    /// </summary>
    public unsafe float EndRotationDegree
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1916); }
    }

    /// <summary>
    /// FloatProperty: EndDiffDegree
    /// </summary>
    public unsafe float EndDiffDegree
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1920); }
    }

    /// <summary>
    /// FloatProperty: FullSpeedVelocity
    /// </summary>
    public unsafe float FullSpeedVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1924); }
    }

    /// <summary>
    /// FloatProperty: StartAcceleration
    /// </summary>
    public unsafe float StartAcceleration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1928); }
    }

    /// <summary>
    /// FloatProperty: StopAcceleration
    /// </summary>
    public unsafe float StopAcceleration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1932); }
    }

    /// <summary>
    /// FloatProperty: TotalRotationTime
    /// </summary>
    public unsafe float TotalRotationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1936); }
    }

    /// <summary>
    /// FloatProperty: StartRotationTime
    /// </summary>
    public unsafe float StartRotationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1940); }
    }

    /// <summary>
    /// FloatProperty: NormalRotationDegrees
    /// </summary>
    public unsafe float NormalRotationDegrees
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1944); }
    }

    /// <summary>
    /// FloatProperty: NormalRotationTime
    /// </summary>
    public unsafe float NormalRotationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1948); }
    }

    /// <summary>
    /// FloatProperty: AccelerationTime
    /// </summary>
    public unsafe float AccelerationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1952); }
    }

    /// <summary>
    /// FloatProperty: DecelerationTime
    /// </summary>
    public unsafe float DecelerationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1956); }
    }

    /// <summary>
    /// FloatProperty: GoToReviewTime
    /// </summary>
    public unsafe float GoToReviewTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1960); }
    }

    /// <summary>
    /// FloatProperty: PostSpinWaitTime
    /// </summary>
    public unsafe float PostSpinWaitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1964); }
    }

    /// <summary>
    /// ObjectProperty: HeroLotteryObj
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject HeroLotteryObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 1968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1968); }
    }

    /// <summary>
    /// ObjectProperty: LotteryWheelObj
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject LotteryWheelObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 1972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1972); }
    }

    /// <summary>
    /// StructProperty: LotteryWheelDisplayInfo
    /// </summary>
    public unsafe ref BmSDK.GFxUI.GFxObject.FASDisplayInfo LotteryWheelDisplayInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GFxUI.GFxObject.FASDisplayInfo>(Ptr + 1976);

    /// <summary>
    /// IntProperty: FinalBatmanSegment
    /// </summary>
    public unsafe int FinalBatmanSegment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2020); }
    }

    /// <summary>
    /// IntProperty: FinalRobinSegment
    /// </summary>
    public unsafe int FinalRobinSegment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2024); }
    }

    /// <summary>
    /// IntProperty: PrevHighlightedBatmanSegment
    /// </summary>
    public unsafe int PrevHighlightedBatmanSegment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2028); }
    }

    /// <summary>
    /// IntProperty: PrevHighlightedRobinSegment
    /// </summary>
    public unsafe int PrevHighlightedRobinSegment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2032); }
    }

    /// <summary>
    /// IntProperty: TotalParticipants
    /// </summary>
    public unsafe int TotalParticipants
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2036); }
    }

    /// <summary>
    /// IntProperty: HeroAvatarColour
    /// </summary>
    public unsafe int HeroAvatarColour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2040); }
    }

    /// <summary>
    /// ObjectProperty: TimerAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent TimerAudioEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2044); }
    }

    /// <summary>
    /// ObjectProperty: OptInAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent OptInAudioEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2048); }
    }

    /// <summary>
    /// ObjectProperty: OptOutAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent OptOutAudioEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2052); }
    }

    /// <summary>
    /// ObjectProperty: LotteryWheelForwardSpinner
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject LotteryWheelForwardSpinner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 2056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2056); }
    }

    /// <summary>
    /// ObjectProperty: LotteryWheelReverseSpinner
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject LotteryWheelReverseSpinner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 2060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2060); }
    }

    /// <summary>
    /// IntProperty: SpinnerStartFrameNum
    /// </summary>
    public unsafe int SpinnerStartFrameNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2064); }
    }

    /// <summary>
    /// IntProperty: SpinnerEndFrameNum
    /// </summary>
    public unsafe int SpinnerEndFrameNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2068); }
    }

    /// <summary>
    /// ObjectProperty: PlayerNamesObj
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject PlayerNamesObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 2072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }
    }

    /// <summary>
    /// StructProperty: PlayerNamesDisplayInfo
    /// </summary>
    public unsafe ref BmSDK.GFxUI.GFxObject.FASDisplayInfo PlayerNamesDisplayInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GFxUI.GFxObject.FASDisplayInfo>(Ptr + 2076);

    /// <summary>
    /// FloatProperty: MinPlayerNamesAlpha
    /// </summary>
    public unsafe float MinPlayerNamesAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }
    }

    /// <summary>
    /// FloatProperty: StartFadeInSpinPercentage
    /// </summary>
    public unsafe float StartFadeInSpinPercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2124); }
    }

    /// <summary>
    /// FloatProperty: EndFadeOutSpinPercentage
    /// </summary>
    public unsafe float EndFadeOutSpinPercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2128); }
    }

    /// <summary>
    /// DelegateProperty: __SortPlayerList__Delegate
    /// </summary>
    public unsafe System.IntPtr __SortPlayerList__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2132); }
    }

    /// <summary>
    /// Struct: FSHeroLotteryPlayerData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FSHeroLotteryPlayerData
    {
        /// <summary>
        /// ObjectProperty: PRI
        /// </summary>
        public unsafe BmSDK.BmGame.RPlayerRI PRI
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerRI>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: MinWheelAngle
        /// </summary>
        public unsafe int MinWheelAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: MaxWheelAngle
        /// </summary>
        public unsafe int MaxWheelAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: SegmentSizeDegrees
        /// </summary>
        public unsafe int SegmentSizeDegrees
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ByteProperty: WheelSide
        /// </summary>
        public unsafe BmSDK.BmGame.GDGFxMovieUI_HeroLottery.EHeroLotterySide WheelSide
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGFxMovieUI_HeroLottery.EHeroLotterySide>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: AvatarColor
        /// </summary>
        public unsafe int AvatarColor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ByteProperty: DefaultAvatarState
        /// </summary>
        public unsafe BmSDK.BmGame.GDGFxMovieUI_HeroLottery.EHeroLotteryAvatarState DefaultAvatarState
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGFxMovieUI_HeroLottery.EHeroLotteryAvatarState>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ByteProperty: DefaultHighlightState
        /// </summary>
        public unsafe BmSDK.BmGame.GDGFxMovieUI_HeroLottery.EHeroLotteryHighlightState DefaultHighlightState
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGFxMovieUI_HeroLottery.EHeroLotteryHighlightState>(Ptr + 25); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 25); }; }
        }

        /// <summary>
        /// BoolProperty: bLocalPlayer
        /// </summary>
        public unsafe bool bLocalPlayer
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }
    }

    /// <summary>
    /// Enum: EHeroLotteryHighlightState
    /// </summary>
    public enum EHeroLotteryHighlightState : byte
    {
        EHeroLotteryHighlightState_LocalPlayer = 0,
        EHeroLotteryHighlightState_Normal = 1,
        EHeroLotteryHighlightState_Highlighted = 2,
        EHeroLotteryHighlightState_MAX = 3,
    }

    /// <summary>
    /// Enum: EHeroLotteryAvatarState
    /// </summary>
    public enum EHeroLotteryAvatarState : byte
    {
        EHeroLotteryAvatarState_LocalPlayer = 0,
        EHeroLotteryAvatarState_NormalPlayer = 1,
        EHeroLotteryAvatarState_Batman = 2,
        EHeroLotteryAvatarState_LocalBatman = 3,
        EHeroLotteryAvatarState_Robin = 4,
        EHeroLotteryAvatarState_LocalRobin = 5,
        EHeroLotteryAvatarState_MAX = 6,
    }

    /// <summary>
    /// Enum: EHeroLotterySide
    /// </summary>
    public enum EHeroLotterySide : byte
    {
        EHeroLotterySide_Left = 0,
        EHeroLotterySide_Right = 1,
        EHeroLotterySide_MAX = 2,
    }

    /// <summary>
    /// Enum: EHeroLotteryState
    /// </summary>
    public enum EHeroLotteryState : byte
    {
        EHeroLotteryState_Unknown = 0,
        EHeroLotteryState_OptOut = 1,
        EHeroLotteryState_Spin = 2,
        EHeroLotteryState_MAX = 3,
    }
}
