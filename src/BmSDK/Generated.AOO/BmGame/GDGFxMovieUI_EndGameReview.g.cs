#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDGFxMovieUI_EndGameReview<br/>
/// (size = 2304)
/// (flags = 32790)
/// </summary>
public partial class GDGFxMovieUI_EndGameReview : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDGFxMovieUI_EndGameReview", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDGFxMovieUI_EndGameReview.
    /// </summary>
    public static GDGFxMovieUI_EndGameReview DefaultObject => (GDGFxMovieUI_EndGameReview)StaticClass().DefaultObject;

    internal GDGFxMovieUI_EndGameReview() { }

    /// <summary>
    /// Constructs a new GDGFxMovieUI_EndGameReview
    /// </summary>
    public GDGFxMovieUI_EndGameReview(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDGFxMovieUI_EndGameReview Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDGFxMovieUI_EndGameReview(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_EndGameReview>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_EndGameReview>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_EndGameReview>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_EndGameReview>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_EndGameReview>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_EndGameReview>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_EndGameReview>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDGFxMovieUI_EndGameReview>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_asSetBonusCreditsEarned;
    /// <summary>
    /// Function: asSetBonusCreditsEarned
    /// </summary>
    public unsafe virtual void asSetBonusCreditsEarned(int BonusCredits)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetBonusCreditsEarned, "BmGame.GDGFxMovieUI_EndGameReview.asSetBonusCreditsEarned");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BonusCredits, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetCreditsEarned;
    /// <summary>
    /// Function: asSetCreditsEarned
    /// </summary>
    public unsafe virtual void asSetCreditsEarned(int CreditsEarned)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetCreditsEarned, "BmGame.GDGFxMovieUI_EndGameReview.asSetCreditsEarned");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CreditsEarned, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetEquippedWeaponName;
    /// <summary>
    /// Function: asSetEquippedWeaponName
    /// </summary>
    public unsafe virtual void asSetEquippedWeaponName(BmSDK.FString WeaponName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetEquippedWeaponName, "BmGame.GDGFxMovieUI_EndGameReview.asSetEquippedWeaponName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetFactionName;
    /// <summary>
    /// Function: asSetFactionName
    /// </summary>
    public unsafe virtual void asSetFactionName(BmSDK.FString FactionName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetFactionName, "BmGame.GDGFxMovieUI_EndGameReview.asSetFactionName");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FactionName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetReviewSectionState;
    /// <summary>
    /// Function: asSetReviewSectionState
    /// </summary>
    public unsafe virtual void asSetReviewSectionState(BmSDK.FString SectionName, BmSDK.FString State)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetReviewSectionState, "BmGame.GDGFxMovieUI_EndGameReview.asSetReviewSectionState");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SectionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(State, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetWeaponLevel;
    /// <summary>
    /// Function: asSetWeaponLevel
    /// </summary>
    public unsafe virtual void asSetWeaponLevel(int WeaponLevel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetWeaponLevel, "BmGame.GDGFxMovieUI_EndGameReview.asSetWeaponLevel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetEquippedWeaponIcon;
    /// <summary>
    /// Function: asSetEquippedWeaponIcon
    /// </summary>
    public unsafe virtual void asSetEquippedWeaponIcon(BmSDK.FString IconName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetEquippedWeaponIcon, "BmGame.GDGFxMovieUI_EndGameReview.asSetEquippedWeaponIcon");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetWeaponScore;
    /// <summary>
    /// Function: asSetWeaponScore
    /// </summary>
    public unsafe virtual void asSetWeaponScore(int Score)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetWeaponScore, "BmGame.GDGFxMovieUI_EndGameReview.asSetWeaponScore");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asTriggerLevelDingAnimation;
    /// <summary>
    /// Function: asTriggerLevelDingAnimation
    /// </summary>
    public unsafe virtual void asTriggerLevelDingAnimation(int State)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asTriggerLevelDingAnimation, "BmGame.GDGFxMovieUI_EndGameReview.asTriggerLevelDingAnimation");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(State, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asShowNextUnlock;
    /// <summary>
    /// Function: asShowNextUnlock
    /// </summary>
    public unsafe virtual void asShowNextUnlock()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asShowNextUnlock, "BmGame.GDGFxMovieUI_EndGameReview.asShowNextUnlock");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asAddUnlockItem;
    /// <summary>
    /// Function: asAddUnlockItem
    /// </summary>
    public unsafe virtual void asAddUnlockItem(BmSDK.FString ItemCategory, BmSDK.FString ItemName, BmSDK.FString IconName, BmSDK.FString IconPackage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asAddUnlockItem, "BmGame.GDGFxMovieUI_EndGameReview.asAddUnlockItem");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemCategory, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconName, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconPackage, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetCreditsConsumableIcon;
    /// <summary>
    /// Function: asSetCreditsConsumableIcon
    /// </summary>
    public unsafe virtual void asSetCreditsConsumableIcon(BmSDK.FString IconString)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetCreditsConsumableIcon, "BmGame.GDGFxMovieUI_EndGameReview.asSetCreditsConsumableIcon");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconString, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetWeaponConsumableIcon;
    /// <summary>
    /// Function: asSetWeaponConsumableIcon
    /// </summary>
    public unsafe virtual void asSetWeaponConsumableIcon(BmSDK.FString IconString)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetWeaponConsumableIcon, "BmGame.GDGFxMovieUI_EndGameReview.asSetWeaponConsumableIcon");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconString, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetXPConsumableIcon;
    /// <summary>
    /// Function: asSetXPConsumableIcon
    /// </summary>
    public unsafe virtual void asSetXPConsumableIcon(BmSDK.FString IconString)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetXPConsumableIcon, "BmGame.GDGFxMovieUI_EndGameReview.asSetXPConsumableIcon");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconString, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetFactionLevel;
    /// <summary>
    /// Function: asSetFactionLevel
    /// </summary>
    public unsafe virtual void asSetFactionLevel(int FactionLevel, int FactionType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetFactionLevel, "BmGame.GDGFxMovieUI_EndGameReview.asSetFactionLevel");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FactionLevel, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FactionType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetAccountLevel;
    /// <summary>
    /// Function: asSetAccountLevel
    /// </summary>
    public unsafe virtual void asSetAccountLevel(int AccountLevel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetAccountLevel, "BmGame.GDGFxMovieUI_EndGameReview.asSetAccountLevel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AccountLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetPrestigeLevel;
    /// <summary>
    /// Function: asSetPrestigeLevel
    /// </summary>
    public unsafe virtual void asSetPrestigeLevel(int PrestigeLevel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetPrestigeLevel, "BmGame.GDGFxMovieUI_EndGameReview.asSetPrestigeLevel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PrestigeLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetBonusXP;
    /// <summary>
    /// Function: asSetBonusXP
    /// </summary>
    public unsafe virtual void asSetBonusXP(int BonusXP)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetBonusXP, "BmGame.GDGFxMovieUI_EndGameReview.asSetBonusXP");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BonusXP, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetMatchXP;
    /// <summary>
    /// Function: asSetMatchXP
    /// </summary>
    public unsafe virtual void asSetMatchXP(int MatchXP)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetMatchXP, "BmGame.GDGFxMovieUI_EndGameReview.asSetMatchXP");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MatchXP, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asFinishedAccountLevelUp;
    /// <summary>
    /// Function: asFinishedAccountLevelUp
    /// </summary>
    public unsafe virtual void asFinishedAccountLevelUp()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asFinishedAccountLevelUp, "BmGame.GDGFxMovieUI_EndGameReview.asFinishedAccountLevelUp");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asFinishedFactionLevelUp;
    /// <summary>
    /// Function: asFinishedFactionLevelUp
    /// </summary>
    public unsafe virtual void asFinishedFactionLevelUp()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asFinishedFactionLevelUp, "BmGame.GDGFxMovieUI_EndGameReview.asFinishedFactionLevelUp");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asFinishedWeaponLevelUp;
    /// <summary>
    /// Function: asFinishedWeaponLevelUp
    /// </summary>
    public unsafe virtual void asFinishedWeaponLevelUp()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asFinishedWeaponLevelUp, "BmGame.GDGFxMovieUI_EndGameReview.asFinishedWeaponLevelUp");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asFinishedCredits;
    /// <summary>
    /// Function: asFinishedCredits
    /// </summary>
    public unsafe virtual void asFinishedCredits()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asFinishedCredits, "BmGame.GDGFxMovieUI_EndGameReview.asFinishedCredits");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asSetProgressBarPercentage;
    /// <summary>
    /// Function: asSetProgressBarPercentage
    /// </summary>
    public unsafe virtual void asSetProgressBarPercentage(BmSDK.BmGame.GDGFxMovieUI_EndGameReview.EndGameReviewStates State, float Percentage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetProgressBarPercentage, "BmGame.GDGFxMovieUI_EndGameReview.asSetProgressBarPercentage");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(State, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Percentage, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_asGetCreditsText;
    /// <summary>
    /// Function: asGetCreditsText
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxObject asGetCreditsText()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asGetCreditsText, "BmGame.GDGFxMovieUI_EndGameReview.asGetCreditsText");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GFxUI.GFxObject>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_asSetTimerText;
    /// <summary>
    /// Function: asSetTimerText
    /// </summary>
    public unsafe virtual void asSetTimerText(BmSDK.FString TimerString)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_asSetTimerText, "BmGame.GDGFxMovieUI_EndGameReview.asSetTimerText");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimerString, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LevelUpAnimFinished;
    /// <summary>
    /// Function: LevelUpAnimFinished
    /// </summary>
    public unsafe virtual void LevelUpAnimFinished()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LevelUpAnimFinished, "BmGame.GDGFxMovieUI_EndGameReview.LevelUpAnimFinished");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishedIntro;
    /// <summary>
    /// Function: FinishedIntro
    /// </summary>
    public unsafe virtual void FinishedIntro()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishedIntro, "BmGame.GDGFxMovieUI_EndGameReview.FinishedIntro");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FlashMovieReadyForData, "BmGame.GDGFxMovieUI_EndGameReview.FlashMovieReadyForData");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndState_Credits;
    /// <summary>
    /// Function: EndState_Credits
    /// </summary>
    public unsafe virtual void EndState_Credits(BmSDK.BmGame.GDGFxMovieUI_EndGameReview.EndGameReviewStates NextState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndState_Credits, "BmGame.GDGFxMovieUI_EndGameReview.EndState_Credits");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickState_Credits;
    /// <summary>
    /// Function: TickState_Credits
    /// </summary>
    public unsafe virtual void TickState_Credits()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickState_Credits, "BmGame.GDGFxMovieUI_EndGameReview.TickState_Credits");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeginState_Credits;
    /// <summary>
    /// Function: BeginState_Credits
    /// </summary>
    public unsafe virtual void BeginState_Credits(BmSDK.BmGame.GDGFxMovieUI_EndGameReview.EndGameReviewStates PrevState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginState_Credits, "BmGame.GDGFxMovieUI_EndGameReview.BeginState_Credits");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PrevState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndState_Weapons;
    /// <summary>
    /// Function: EndState_Weapons
    /// </summary>
    public unsafe virtual void EndState_Weapons(BmSDK.BmGame.GDGFxMovieUI_EndGameReview.EndGameReviewStates NextState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndState_Weapons, "BmGame.GDGFxMovieUI_EndGameReview.EndState_Weapons");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickState_Weapons;
    /// <summary>
    /// Function: TickState_Weapons
    /// </summary>
    public unsafe virtual void TickState_Weapons()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickState_Weapons, "BmGame.GDGFxMovieUI_EndGameReview.TickState_Weapons");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeginState_Weapons;
    /// <summary>
    /// Function: BeginState_Weapons
    /// </summary>
    public unsafe virtual void BeginState_Weapons(BmSDK.BmGame.GDGFxMovieUI_EndGameReview.EndGameReviewStates PrevState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginState_Weapons, "BmGame.GDGFxMovieUI_EndGameReview.BeginState_Weapons");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PrevState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndState_FactionLevelUp;
    /// <summary>
    /// Function: EndState_FactionLevelUp
    /// </summary>
    public unsafe virtual void EndState_FactionLevelUp(BmSDK.BmGame.GDGFxMovieUI_EndGameReview.EndGameReviewStates NextState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndState_FactionLevelUp, "BmGame.GDGFxMovieUI_EndGameReview.EndState_FactionLevelUp");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickState_FactionLevelUp;
    /// <summary>
    /// Function: TickState_FactionLevelUp
    /// </summary>
    public unsafe virtual void TickState_FactionLevelUp()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickState_FactionLevelUp, "BmGame.GDGFxMovieUI_EndGameReview.TickState_FactionLevelUp");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeginState_FactionLevelUp;
    /// <summary>
    /// Function: BeginState_FactionLevelUp
    /// </summary>
    public unsafe virtual void BeginState_FactionLevelUp(BmSDK.BmGame.GDGFxMovieUI_EndGameReview.EndGameReviewStates PrevState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginState_FactionLevelUp, "BmGame.GDGFxMovieUI_EndGameReview.BeginState_FactionLevelUp");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PrevState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndState_AccountLevelUp;
    /// <summary>
    /// Function: EndState_AccountLevelUp
    /// </summary>
    public unsafe virtual void EndState_AccountLevelUp(BmSDK.BmGame.GDGFxMovieUI_EndGameReview.EndGameReviewStates NextState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndState_AccountLevelUp, "BmGame.GDGFxMovieUI_EndGameReview.EndState_AccountLevelUp");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickState_AccountLevelUp;
    /// <summary>
    /// Function: TickState_AccountLevelUp
    /// </summary>
    public unsafe virtual void TickState_AccountLevelUp()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickState_AccountLevelUp, "BmGame.GDGFxMovieUI_EndGameReview.TickState_AccountLevelUp");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeginState_AccountLevelUp;
    /// <summary>
    /// Function: BeginState_AccountLevelUp
    /// </summary>
    public unsafe virtual void BeginState_AccountLevelUp(BmSDK.BmGame.GDGFxMovieUI_EndGameReview.EndGameReviewStates PrevState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginState_AccountLevelUp, "BmGame.GDGFxMovieUI_EndGameReview.BeginState_AccountLevelUp");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PrevState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckUnlockQueue;
    /// <summary>
    /// Function: CheckUnlockQueue
    /// </summary>
    public unsafe virtual void CheckUnlockQueue(bool bAlwaysForceShow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckUnlockQueue, "BmGame.GDGFxMovieUI_EndGameReview.CheckUnlockQueue");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAlwaysForceShow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QueueUnlock;
    /// <summary>
    /// Function: QueueUnlock
    /// </summary>
    public unsafe virtual void QueueUnlock(BmSDK.BmGame.GDUnlockUtilities.FSUnlockData UnlockData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QueueUnlock, "BmGame.GDGFxMovieUI_EndGameReview.QueueUnlock");
        byte* paramsPtr = stackalloc byte[144];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockData, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTotalBarIncreaseForState;
    /// <summary>
    /// Function: GetTotalBarIncreaseForState
    /// </summary>
    public unsafe virtual float GetTotalBarIncreaseForState(BmSDK.BmGame.GDGFxMovieUI_EndGameReview.EndGameReviewStates State)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTotalBarIncreaseForState, "BmGame.GDGFxMovieUI_EndGameReview.GetTotalBarIncreaseForState");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(State, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetNumberOfUnlocksForState;
    /// <summary>
    /// Function: GetNumberOfUnlocksForState
    /// </summary>
    public unsafe virtual int GetNumberOfUnlocksForState(BmSDK.BmGame.GDGFxMovieUI_EndGameReview.EndGameReviewStates State)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumberOfUnlocksForState, "BmGame.GDGFxMovieUI_EndGameReview.GetNumberOfUnlocksForState");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(State, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CalculateStateTimings;
    /// <summary>
    /// Function: CalculateStateTimings
    /// </summary>
    public unsafe virtual void CalculateStateTimings()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateStateTimings, "BmGame.GDGFxMovieUI_EndGameReview.CalculateStateTimings");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetStatesToShowForTeam;
    /// <summary>
    /// Function: GetStatesToShowForTeam
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_EndGameReview.EndGameReviewStates> GetStatesToShowForTeam(BmSDK.BmGame.GDGIBase.ETeamType Team)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStatesToShowForTeam, "BmGame.GDGFxMovieUI_EndGameReview.GetStatesToShowForTeam");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_EndGameReview.EndGameReviewStates>>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PlayCreditsAudio;
    /// <summary>
    /// Function: PlayCreditsAudio
    /// </summary>
    public unsafe virtual void PlayCreditsAudio(bool bPlay)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCreditsAudio, "BmGame.GDGFxMovieUI_EndGameReview.PlayCreditsAudio");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayProgressBarAudio;
    /// <summary>
    /// Function: PlayProgressBarAudio
    /// </summary>
    public unsafe virtual void PlayProgressBarAudio(bool bPlay)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayProgressBarAudio, "BmGame.GDGFxMovieUI_EndGameReview.PlayProgressBarAudio");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopulateStaticData;
    /// <summary>
    /// Function: PopulateStaticData
    /// </summary>
    public unsafe virtual void PopulateStaticData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulateStaticData, "BmGame.GDGFxMovieUI_EndGameReview.PopulateStaticData");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PopulateGFxObjects;
    /// <summary>
    /// Function: PopulateGFxObjects
    /// </summary>
    public unsafe virtual void PopulateGFxObjects()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PopulateGFxObjects, "BmGame.GDGFxMovieUI_EndGameReview.PopulateGFxObjects");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayLevelUpAudioEvent;
    /// <summary>
    /// Function: PlayLevelUpAudioEvent
    /// </summary>
    public unsafe virtual void PlayLevelUpAudioEvent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayLevelUpAudioEvent, "BmGame.GDGFxMovieUI_EndGameReview.PlayLevelUpAudioEvent");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetCredits;
    /// <summary>
    /// Function: SetCredits
    /// </summary>
    public unsafe virtual void SetCredits(int Credits)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCredits, "BmGame.GDGFxMovieUI_EndGameReview.SetCredits");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Credits, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickCreditsIncrease;
    /// <summary>
    /// Function: TickCreditsIncrease
    /// </summary>
    public unsafe virtual int TickCreditsIncrease()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickCreditsIncrease, "BmGame.GDGFxMovieUI_EndGameReview.TickCreditsIncrease");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TickCurrentProgressBar;
    /// <summary>
    /// Function: TickCurrentProgressBar
    /// </summary>
    public unsafe virtual bool TickCurrentProgressBar()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickCurrentProgressBar, "BmGame.GDGFxMovieUI_EndGameReview.TickCurrentProgressBar");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SortByUnlockLevel;
    /// <summary>
    /// Function: SortByUnlockLevel
    /// </summary>
    public unsafe virtual int SortByUnlockLevel(BmSDK.BmGame.GDUnlockUtilities.FSUnlockData A, BmSDK.BmGame.GDUnlockUtilities.FSUnlockData B)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SortByUnlockLevel, "BmGame.GDGFxMovieUI_EndGameReview.SortByUnlockLevel");
        byte* paramsPtr = stackalloc byte[140];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 60);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 120);
    }

    private static BmSDK.Function __fn_SortByCost;
    /// <summary>
    /// Function: SortByCost
    /// </summary>
    public unsafe virtual int SortByCost(BmSDK.BmGame.GDOfferManager.FGDOffer A, BmSDK.BmGame.GDOfferManager.FGDOffer B)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SortByCost, "BmGame.GDGFxMovieUI_EndGameReview.SortByCost");
        byte* paramsPtr = stackalloc byte[132];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 112);
    }

    private static BmSDK.Function __fn_GetPawnConfigForTeam;
    /// <summary>
    /// Function: GetPawnConfigForTeam
    /// </summary>
    public unsafe virtual BmSDK.BmGame.GDPawnConfig GetPawnConfigForTeam(BmSDK.BmGame.GDGIBase.ETeamType Team, BmSDK.BmGame.RChallengeManager.EPlayableCharacters ForChar = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPawnConfigForTeam, "BmGame.GDGFxMovieUI_EndGameReview.GetPawnConfigForTeam");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForChar, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDPawnConfig>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GenerateReviewData;
    /// <summary>
    /// Function: GenerateReviewData
    /// </summary>
    public unsafe virtual void GenerateReviewData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GenerateReviewData, "BmGame.GDGFxMovieUI_EndGameReview.GenerateReviewData");
        byte* paramsPtr = stackalloc byte[140];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateTimerText;
    /// <summary>
    /// Function: UpdateTimerText
    /// </summary>
    public unsafe virtual void UpdateTimerText(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateTimerText, "BmGame.GDGFxMovieUI_EndGameReview.UpdateTimerText");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.GDGFxMovieUI_EndGameReview.Tick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessEndDelegate;
    /// <summary>
    /// Function: ProcessEndDelegate
    /// </summary>
    public unsafe virtual void ProcessEndDelegate(System.IntPtr _del, BmSDK.BmGame.GDGFxMovieUI_EndGameReview.EndGameReviewStates _next)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessEndDelegate, "BmGame.GDGFxMovieUI_EndGameReview.ProcessEndDelegate");
        byte* paramsPtr = stackalloc byte[29];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_del, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_next, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessTickDelegate;
    /// <summary>
    /// Function: ProcessTickDelegate
    /// </summary>
    public unsafe virtual void ProcessTickDelegate(System.IntPtr _del)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessTickDelegate, "BmGame.GDGFxMovieUI_EndGameReview.ProcessTickDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_del, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ProcessBeginDelegate;
    /// <summary>
    /// Function: ProcessBeginDelegate
    /// </summary>
    public unsafe virtual void ProcessBeginDelegate(System.IntPtr _del, BmSDK.BmGame.GDGFxMovieUI_EndGameReview.EndGameReviewStates _prev)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessBeginDelegate, "BmGame.GDGFxMovieUI_EndGameReview.ProcessBeginDelegate");
        byte* paramsPtr = stackalloc byte[29];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_del, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_prev, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SwitchState;
    /// <summary>
    /// Function: SwitchState
    /// </summary>
    public unsafe virtual void SwitchState(BmSDK.BmGame.GDGFxMovieUI_EndGameReview.EndGameReviewStates _newState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwitchState, "BmGame.GDGFxMovieUI_EndGameReview.SwitchState");
        byte* paramsPtr = stackalloc byte[18];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_newState, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocString, "BmGame.GDGFxMovieUI_EndGameReview.GetLocString");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetToolTip, "BmGame.GDGFxMovieUI_EndGameReview.GetToolTip");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HideReview;
    /// <summary>
    /// Function: HideReview
    /// </summary>
    public unsafe virtual void HideReview()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideReview, "BmGame.GDGFxMovieUI_EndGameReview.HideReview");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowReview;
    /// <summary>
    /// Function: ShowReview
    /// </summary>
    public unsafe virtual void ShowReview()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowReview, "BmGame.GDGFxMovieUI_EndGameReview.ShowReview");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyStateDelegates;
    /// <summary>
    /// Function: DestroyStateDelegates
    /// </summary>
    public unsafe virtual void DestroyStateDelegates()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyStateDelegates, "BmGame.GDGFxMovieUI_EndGameReview.DestroyStateDelegates");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupStateDelegates;
    /// <summary>
    /// Function: SetupStateDelegates
    /// </summary>
    public unsafe virtual void SetupStateDelegates()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupStateDelegates, "BmGame.GDGFxMovieUI_EndGameReview.SetupStateDelegates");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnClosed, "BmGame.GDGFxMovieUI_EndGameReview.OnClosed");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.GDGFxMovieUI_EndGameReview.Init");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndEGRState;
    /// <summary>
    /// Function: EndEGRState
    /// </summary>
    public unsafe virtual void EndEGRState(BmSDK.BmGame.GDGFxMovieUI_EndGameReview.EndGameReviewStates NextState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndEGRState, "BmGame.GDGFxMovieUI_EndGameReview.EndEGRState");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickEGRState;
    /// <summary>
    /// Function: TickEGRState
    /// </summary>
    public unsafe virtual void TickEGRState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickEGRState, "BmGame.GDGFxMovieUI_EndGameReview.TickEGRState");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ButtonPressedEGRState;
    /// <summary>
    /// Function: ButtonPressedEGRState
    /// </summary>
    public unsafe virtual void ButtonPressedEGRState(int _button)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ButtonPressedEGRState, "BmGame.GDGFxMovieUI_EndGameReview.ButtonPressedEGRState");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_button, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeginEGRState;
    /// <summary>
    /// Function: BeginEGRState
    /// </summary>
    public unsafe virtual void BeginEGRState(BmSDK.BmGame.GDGFxMovieUI_EndGameReview.EndGameReviewStates PrevState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginEGRState, "BmGame.GDGFxMovieUI_EndGameReview.BeginEGRState");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PrevState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// FloatProperty: DelayBetweenStates
    /// </summary>
    public unsafe float DelayBetweenStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1708); }
    }

    /// <summary>
    /// FloatProperty: EndDelay
    /// </summary>
    public unsafe float EndDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1712); }
    }

    /// <summary>
    /// FloatProperty: MinUnlockShowTime
    /// </summary>
    public unsafe float MinUnlockShowTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }

    /// <summary>
    /// ByteProperty: CurrentState
    /// </summary>
    public unsafe BmSDK.BmGame.GDGFxMovieUI_EndGameReview.EndGameReviewStates CurrentState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGFxMovieUI_EndGameReview.EndGameReviewStates>(Ptr + 1720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }
    }

    /// <summary>
    /// ByteProperty: ActiveConsumable
    /// </summary>
    public unsafe BmSDK.BmGame.GDConsumableGameplayEffectorBase.GameplayEffectorType ActiveConsumable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDConsumableGameplayEffectorBase.GameplayEffectorType>(Ptr + 1721); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1721); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: StateDelegates
    /// </summary>
    public InlineArray<BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FEGRS_Delegates> StateDelegates => new(6, Ptr + 1724, 36, this);

    /// <summary>
    /// StructProperty: StateDelegates
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FEGRS_Delegates StateDelegates_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FEGRS_Delegates>(Ptr + 1724);
    /// <summary>
    /// StructProperty: StateDelegates
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FEGRS_Delegates StateDelegates_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FEGRS_Delegates>(Ptr + 1760);
    /// <summary>
    /// StructProperty: StateDelegates
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FEGRS_Delegates StateDelegates_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FEGRS_Delegates>(Ptr + 1796);
    /// <summary>
    /// StructProperty: StateDelegates
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FEGRS_Delegates StateDelegates_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FEGRS_Delegates>(Ptr + 1832);
    /// <summary>
    /// StructProperty: StateDelegates
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FEGRS_Delegates StateDelegates_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FEGRS_Delegates>(Ptr + 1868);
    /// <summary>
    /// StructProperty: StateDelegates
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FEGRS_Delegates StateDelegates_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FEGRS_Delegates>(Ptr + 1904);

    /// <summary>
    /// StrProperty: MovieTargetPath
    /// </summary>
    public unsafe BmSDK.FString MovieTargetPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1940); }
    }

    /// <summary>
    /// ObjectProperty: StartProgressBarAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent StartProgressBarAudioEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1952); }
    }

    /// <summary>
    /// ObjectProperty: EndProgressBarAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent EndProgressBarAudioEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1956); }
    }

    /// <summary>
    /// ObjectProperty: StartCreditsAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent StartCreditsAudioEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1960); }
    }

    /// <summary>
    /// ObjectProperty: EndCreditsAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent EndCreditsAudioEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1964); }
    }

    /// <summary>
    /// ObjectProperty: DingAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent DingAudioEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1968); }
    }

    /// <summary>
    /// BoolProperty: bPlayingProgressAudio
    /// </summary>
    public unsafe bool bPlayingProgressAudio
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bVisible
    /// </summary>
    public unsafe bool bVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bHeroMode
    /// </summary>
    public unsafe bool bHeroMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bShowNextUnlockAfterLevelUpAnim
    /// </summary>
    public unsafe bool bShowNextUnlockAfterLevelUpAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// BoolProperty: bShowNextUnlockNextTick
    /// </summary>
    public unsafe bool bShowNextUnlockNextTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1972); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: StateTimings
    /// </summary>
    public InlineArray<BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FSStateTimings> StateTimings => new(6, Ptr + 1976, 8, this);

    /// <summary>
    /// StructProperty: StateTimings
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FSStateTimings StateTimings_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FSStateTimings>(Ptr + 1976);
    /// <summary>
    /// StructProperty: StateTimings
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FSStateTimings StateTimings_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FSStateTimings>(Ptr + 1984);
    /// <summary>
    /// StructProperty: StateTimings
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FSStateTimings StateTimings_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FSStateTimings>(Ptr + 1992);
    /// <summary>
    /// StructProperty: StateTimings
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FSStateTimings StateTimings_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FSStateTimings>(Ptr + 2000);
    /// <summary>
    /// StructProperty: StateTimings
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FSStateTimings StateTimings_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FSStateTimings>(Ptr + 2008);
    /// <summary>
    /// StructProperty: StateTimings
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FSStateTimings StateTimings_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FSStateTimings>(Ptr + 2016);

    /// <summary>
    /// IntProperty: StateLevelUpCount
    /// </summary>
    public unsafe int StateLevelUpCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2024); }
    }

    /// <summary>
    /// FloatProperty: TargetBarPercentage
    /// </summary>
    public unsafe float TargetBarPercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2028); }
    }

    /// <summary>
    /// FloatProperty: TotalBarPercentage
    /// </summary>
    public unsafe float TotalBarPercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2032); }
    }

    /// <summary>
    /// FloatProperty: OldTotalBarPercentage
    /// </summary>
    public unsafe float OldTotalBarPercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2036); }
    }

    /// <summary>
    /// FloatProperty: DisplayBarPercentage
    /// </summary>
    public unsafe float DisplayBarPercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2040); }
    }

    /// <summary>
    /// FloatProperty: OldDisplayBarPercentage
    /// </summary>
    public unsafe float OldDisplayBarPercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2044); }
    }

    /// <summary>
    /// FloatProperty: BarUpdateRate
    /// </summary>
    public unsafe float BarUpdateRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2048); }
    }

    /// <summary>
    /// IntProperty: CurrentCreditsAmount
    /// </summary>
    public unsafe int CurrentCreditsAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2052); }
    }

    /// <summary>
    /// IntProperty: CreditsUpdateRate
    /// </summary>
    public unsafe int CreditsUpdateRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2056); }
    }

    /// <summary>
    /// FloatProperty: TimerUpdateCount
    /// </summary>
    public unsafe float TimerUpdateCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2060); }
    }

    /// <summary>
    /// StructProperty: XPEarnedStateData
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FSXPEarnedStateData XPEarnedStateData
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FSXPEarnedStateData>(Ptr + 2064);

    /// <summary>
    /// StructProperty: WeaponScoreStateData
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FSWeaponScoreStateData WeaponScoreStateData
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FSWeaponScoreStateData>(Ptr + 2140);

    /// <summary>
    /// StructProperty: CreditsStateData
    /// </summary>
    public unsafe ref BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FSCreditsStateData CreditsStateData
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FSCreditsStateData>(Ptr + 2184);

    /// <summary>
    /// ObjectProperty: CreditsTextObj
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject CreditsTextObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 2212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2212); }
    }

    /// <summary>
    /// ObjectProperty: EndGameReviewObj
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject EndGameReviewObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 2216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2216); }
    }

    /// <summary>
    /// ArrayProperty: UnlockQueue
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FSUnlockTiming> UnlockQueue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDGFxMovieUI_EndGameReview.FSUnlockTiming>>(Ptr + 2220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2220); }
    }

    /// <summary>
    /// DelegateProperty: __BeginEGRState__Delegate
    /// </summary>
    public unsafe System.IntPtr __BeginEGRState__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2232); }
    }

    /// <summary>
    /// DelegateProperty: __ButtonPressedEGRState__Delegate
    /// </summary>
    public unsafe System.IntPtr __ButtonPressedEGRState__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2244); }
    }

    /// <summary>
    /// DelegateProperty: __TickEGRState__Delegate
    /// </summary>
    public unsafe System.IntPtr __TickEGRState__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }
    }

    /// <summary>
    /// DelegateProperty: __EndEGRState__Delegate
    /// </summary>
    public unsafe System.IntPtr __EndEGRState__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2268); }
    }

    /// <summary>
    /// DelegateProperty: __SortByCost__Delegate
    /// </summary>
    public unsafe System.IntPtr __SortByCost__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }
    }

    /// <summary>
    /// DelegateProperty: __SortByUnlockLevel__Delegate
    /// </summary>
    public unsafe System.IntPtr __SortByUnlockLevel__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2292); }
    }

    /// <summary>
    /// Struct: FSUnlockTiming
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public partial record struct FSUnlockTiming
    {
        /// <summary>
        /// StructProperty: Unlock
        /// </summary>
        public unsafe BmSDK.BmGame.GDUnlockUtilities.FSUnlockData Unlock
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: UnlockTime
        /// </summary>
        public unsafe float UnlockTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// BoolProperty: bForceShow
        /// </summary>
        public unsafe bool bForceShow
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }
    }

    /// <summary>
    /// Struct: FSStateTimings
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FSStateTimings
    {
        /// <summary>
        /// FloatProperty: StateStartTime
        /// </summary>
        public unsafe float StateStartTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: StateEndTime
        /// </summary>
        public unsafe float StateEndTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FSCreditsStateData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FSCreditsStateData
    {
        /// <summary>
        /// IntProperty: CreditsEarned
        /// </summary>
        public unsafe int CreditsEarned
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: BonusCreditsEarned
        /// </summary>
        public unsafe int BonusCreditsEarned
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: StartTotalCredits
        /// </summary>
        public unsafe int StartTotalCredits
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: EndTotalCredits
        /// </summary>
        public unsafe int EndTotalCredits
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ArrayProperty: Crates
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData> Crates
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FSWeaponScoreStateData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial record struct FSWeaponScoreStateData
    {
        /// <summary>
        /// ByteProperty: EquippedWeapon
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.WeaponId EquippedWeapon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.WeaponId>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Score
        /// </summary>
        public unsafe int Score
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: BonusScoreEarned
        /// </summary>
        public unsafe int BonusScoreEarned
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: StartWeaponLevel
        /// </summary>
        public unsafe int StartWeaponLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: EndWeaponLevel
        /// </summary>
        public unsafe int EndWeaponLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: StartUpgradeLevelPercentage
        /// </summary>
        public unsafe float StartUpgradeLevelPercentage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: EndUpgradeLevelPercentage
        /// </summary>
        public unsafe float EndUpgradeLevelPercentage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ArrayProperty: WeaponUnlocks
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData> WeaponUnlocks
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData>>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: bFullUpgradeAchievement
        /// </summary>
        public unsafe bool bFullUpgradeAchievement
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FSXPEarnedStateData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 76)]
    public partial record struct FSXPEarnedStateData
    {
        /// <summary>
        /// ByteProperty: PlayerFaction
        /// </summary>
        public unsafe BmSDK.BmGame.GDGIBase.ETeamType PlayerFaction
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDGIBase.ETeamType>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: XPEarned
        /// </summary>
        public unsafe int XPEarned
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: BonusXPEarned
        /// </summary>
        public unsafe int BonusXPEarned
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: StartAccountLevel
        /// </summary>
        public unsafe int StartAccountLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: EndAccountLevel
        /// </summary>
        public unsafe int EndAccountLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: StartAccountLevelPercentage
        /// </summary>
        public unsafe float StartAccountLevelPercentage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: EndAccountLevelPercentage
        /// </summary>
        public unsafe float EndAccountLevelPercentage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// IntProperty: StartFactionLevel
        /// </summary>
        public unsafe int StartFactionLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// IntProperty: EndFactionLevel
        /// </summary>
        public unsafe int EndFactionLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: StartFactionLevelPercentage
        /// </summary>
        public unsafe float StartFactionLevelPercentage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: EndFactionLevelPercentage
        /// </summary>
        public unsafe float EndFactionLevelPercentage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// IntProperty: PrestigeLevel
        /// </summary>
        public unsafe int PrestigeLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// ArrayProperty: AccountUnlocks
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData> AccountUnlocks
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData>>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// ArrayProperty: FactionUnlocks
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData> FactionUnlocks
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.GDUnlockUtilities.FSUnlockData>>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// BoolProperty: bFullAccountAchievement
        /// </summary>
        public unsafe bool bFullAccountAchievement
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }; }
        }

        /// <summary>
        /// BoolProperty: bFullFactionAchievement
        /// </summary>
        public unsafe bool bFullFactionAchievement
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }; }
        }

        /// <summary>
        /// BoolProperty: bXPInMatchAchievement
        /// </summary>
        public unsafe bool bXPInMatchAchievement
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }; }
        }
    }

    /// <summary>
    /// Struct: FEGRS_Delegates
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FEGRS_Delegates
    {
        /// <summary>
        /// DelegateProperty: BeginStateDelegate
        /// </summary>
        public unsafe System.IntPtr BeginStateDelegate
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// DelegateProperty: TickStateDelegate
        /// </summary>
        public unsafe System.IntPtr TickStateDelegate
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// DelegateProperty: EndStateDelegate
        /// </summary>
        public unsafe System.IntPtr EndStateDelegate
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Enum: EndGameReviewStates
    /// </summary>
    public enum EndGameReviewStates : byte
    {
        EGRS_Inactive = 0,
        EGRS_AccountLevelUp = 1,
        EGRS_FactionLevelUp = 2,
        EGRS_WeaponsXP = 3,
        EGRS_Credits = 4,
        EGRS_End = 5,
        EGRS_MAX = 6,
    }
}
