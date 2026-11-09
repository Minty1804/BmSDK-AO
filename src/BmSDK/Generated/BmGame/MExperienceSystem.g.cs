#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MExperienceSystem<br/>
/// (size = 1140)
/// (flags = 142606482)
/// </summary>
public partial class MExperienceSystem : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MExperienceSystem", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MExperienceSystem.
    /// </summary>
    public static MExperienceSystem DefaultObject => (MExperienceSystem)StaticClass().DefaultObject;

    internal MExperienceSystem() { }

    /// <summary>
    /// Constructs a new MExperienceSystem
    /// </summary>
    public MExperienceSystem(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MExperienceSystem Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MExperienceSystem(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MExperienceSystem>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MExperienceSystem>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MExperienceSystem>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MExperienceSystem>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MExperienceSystem>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MExperienceSystem>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MExperienceSystem>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MExperienceSystem>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_DoAlfredWisdomBonus;
    /// <summary>
    /// Function: DoAlfredWisdomBonus
    /// </summary>
    public unsafe virtual bool DoAlfredWisdomBonus()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoAlfredWisdomBonus, "BmGame.MExperienceSystem.DoAlfredWisdomBonus");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RegisterCombatKO;
    /// <summary>
    /// Function: RegisterCombatKO
    /// </summary>
    public unsafe virtual void RegisterCombatKO(BmSDK.BmGame.RGameInfo.EGameAction Type, BmSDK.Engine.Actor XPTarget, int XPAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterCombatKO, "BmGame.MExperienceSystem.RegisterCombatKO");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPTarget, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPAmount, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterRepeatedAction;
    /// <summary>
    /// Function: RegisterRepeatedAction
    /// </summary>
    public unsafe virtual void RegisterRepeatedAction(BmSDK.BmGame.RGameInfo.EGameAction Type, BmSDK.Engine.Actor XPTarget, int XPAmount = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterRepeatedAction, "BmGame.MExperienceSystem.RegisterRepeatedAction");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPTarget, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPAmount, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnXPSequence;
    /// <summary>
    /// Function: SpawnXPSequence
    /// </summary>
    public unsafe virtual void SpawnXPSequence(int XPAwarded, BmSDK.Engine.Actor XPTarget, BmSDK.BmGame.RGameInfo.EGameAction Type, float BatMultiplier = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnXPSequence, "BmGame.MExperienceSystem.SpawnXPSequence");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPAwarded, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPTarget, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatMultiplier, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnXPSequenceFromConfig;
    /// <summary>
    /// Function: SpawnXPSequenceFromConfig
    /// </summary>
    public unsafe virtual void SpawnXPSequenceFromConfig(BmSDK.FString MiscellaneousXPTag, BmSDK.Engine.Actor XPTarget, BmSDK.BmGame.RGameInfo.EGameAction Type, float BatMultiplier = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnXPSequenceFromConfig, "BmGame.MExperienceSystem.SpawnXPSequenceFromConfig");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MiscellaneousXPTag, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPTarget, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatMultiplier, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AwardBankedXP;
    /// <summary>
    /// Function: AwardBankedXP
    /// </summary>
    public unsafe virtual void AwardBankedXP()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AwardBankedXP, "BmGame.MExperienceSystem.AwardBankedXP");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasBankedExperience;
    /// <summary>
    /// Function: HasBankedExperience
    /// </summary>
    public unsafe virtual bool HasBankedExperience()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasBankedExperience, "BmGame.MExperienceSystem.HasBankedExperience");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_BankExperience;
    /// <summary>
    /// Function: BankExperience
    /// </summary>
    public unsafe virtual void BankExperience(float experiencePoints)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BankExperience, "BmGame.MExperienceSystem.BankExperience");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(experiencePoints, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsFullLevelUp;
    /// <summary>
    /// Function: IsFullLevelUp
    /// </summary>
    public unsafe virtual bool IsFullLevelUp()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFullLevelUp, "BmGame.MExperienceSystem.IsFullLevelUp");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_LevelNeededXP;
    /// <summary>
    /// Function: LevelNeededXP
    /// </summary>
    public unsafe virtual int LevelNeededXP()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LevelNeededXP, "BmGame.MExperienceSystem.LevelNeededXP");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_LastLevelNeededXP;
    /// <summary>
    /// Function: LastLevelNeededXP
    /// </summary>
    public unsafe virtual int LastLevelNeededXP()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LastLevelNeededXP, "BmGame.MExperienceSystem.LastLevelNeededXP");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNeededXP;
    /// <summary>
    /// Function: GetNeededXP
    /// </summary>
    public unsafe virtual int GetNeededXP()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNeededXP, "BmGame.MExperienceSystem.GetNeededXP");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCurrentXP;
    /// <summary>
    /// Function: GetCurrentXP
    /// </summary>
    public unsafe virtual int GetCurrentXP()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentXP, "BmGame.MExperienceSystem.GetCurrentXP");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_InitXPBarForLevel;
    /// <summary>
    /// Function: InitXPBarForLevel
    /// </summary>
    public unsafe virtual void InitXPBarForLevel(int Level)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitXPBarForLevel, "BmGame.MExperienceSystem.InitXPBarForLevel");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Level, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitXPBarForCurrentLevel;
    /// <summary>
    /// Function: InitXPBarForCurrentLevel
    /// </summary>
    public unsafe virtual void InitXPBarForCurrentLevel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitXPBarForCurrentLevel, "BmGame.MExperienceSystem.InitXPBarForCurrentLevel");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideXPBar;
    /// <summary>
    /// Function: HideXPBar
    /// </summary>
    public unsafe virtual void HideXPBar()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideXPBar, "BmGame.MExperienceSystem.HideXPBar");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowXPBar;
    /// <summary>
    /// Function: ShowXPBar
    /// </summary>
    public unsafe virtual void ShowXPBar()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowXPBar, "BmGame.MExperienceSystem.ShowXPBar");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetXPBar;
    /// <summary>
    /// Function: SetXPBar
    /// </summary>
    public unsafe virtual void SetXPBar(int NewValue, int MinVal, int MaxVal, int Duration = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetXPBar, "BmGame.MExperienceSystem.SetXPBar");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewValue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinVal, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxVal, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLevelXPBar;
    /// <summary>
    /// Function: SetLevelXPBar
    /// </summary>
    public unsafe virtual void SetLevelXPBar(int NewValue, int Level, int Duration = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLevelXPBar, "BmGame.MExperienceSystem.SetLevelXPBar");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewValue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Level, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetActualXPBar;
    /// <summary>
    /// Function: SetActualXPBar
    /// </summary>
    public unsafe virtual void SetActualXPBar(int NewValue, int Duration = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetActualXPBar, "BmGame.MExperienceSystem.SetActualXPBar");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewValue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddPredatorXP;
    /// <summary>
    /// Function: AddPredatorXP
    /// </summary>
    public unsafe virtual void AddPredatorXP(BmSDK.BmGame.RGameInfo.ECombatPawnType ThugType, BmSDK.Class DamageType, bool IsDoubleTakedown, bool IsQuickTakedown)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddPredatorXP, "BmGame.MExperienceSystem.AddPredatorXP");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsDoubleTakedown, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsQuickTakedown, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetPredatorValues;
    /// <summary>
    /// Function: ResetPredatorValues
    /// </summary>
    public unsafe virtual void ResetPredatorValues()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetPredatorValues, "BmGame.MExperienceSystem.ResetPredatorValues");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnPlayerDied;
    /// <summary>
    /// Function: OnPlayerDied
    /// </summary>
    public unsafe virtual void OnPlayerDied()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPlayerDied, "BmGame.MExperienceSystem.OnPlayerDied");
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetAwardChallengeXP;
    /// <summary>
    /// Function: GetAwardChallengeXP
    /// </summary>
    public unsafe int GetAwardChallengeXP(out BmSDK.BmGame.MExperienceSystem.FSChallengeBeatNotification notif, BmSDK.GFxUI.GFxObject XPDataChallenges, out int DataIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAwardChallengeXP, "BmGame.MExperienceSystem.GetAwardChallengeXP");
        byte* paramsPtr = stackalloc byte[124];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPDataChallenges, paramsPtr + 92);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DataIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DataIndex, paramsPtr + 96);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        notif = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.MExperienceSystem.FSChallengeBeatNotification>(paramsPtr + 0);
        DataIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 96);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 100);
    }

    private static BmSDK.Function __fn_AwardChallengeXP;
    /// <summary>
    /// Function: AwardChallengeXP
    /// </summary>
    public unsafe virtual void AwardChallengeXP()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AwardChallengeXP, "BmGame.MExperienceSystem.AwardChallengeXP");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AppendAwardChallengeDarkKnightComplete;
    /// <summary>
    /// Function: AppendAwardChallengeDarkKnightComplete
    /// </summary>
    public unsafe virtual void AppendAwardChallengeDarkKnightComplete(BmSDK.BmGame.MDarkKnightChallengesSettings Settings)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AppendAwardChallengeDarkKnightComplete, "BmGame.MExperienceSystem.AppendAwardChallengeDarkKnightComplete");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Settings, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AppendAwardChallengePathComplete;
    /// <summary>
    /// Function: AppendAwardChallengePathComplete
    /// </summary>
    public unsafe virtual void AppendAwardChallengePathComplete(BmSDK.BmGame.MDarkKnightChallengesSettings.FDKPathSettings PathSettings)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AppendAwardChallengePathComplete, "BmGame.MExperienceSystem.AppendAwardChallengePathComplete");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PathSettings, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AppendAwardChallengePathLevelBeat;
    /// <summary>
    /// Function: AppendAwardChallengePathLevelBeat
    /// </summary>
    public unsafe virtual void AppendAwardChallengePathLevelBeat(int Level, BmSDK.BmGame.MDarkKnightChallengesSettings.FDKPathSettings PathSettings, bool PathComplete)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AppendAwardChallengePathLevelBeat, "BmGame.MExperienceSystem.AppendAwardChallengePathLevelBeat");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Level, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PathSettings, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PathComplete, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeginAwardChallengeBeat;
    /// <summary>
    /// Function: BeginAwardChallengeBeat
    /// </summary>
    public unsafe virtual void BeginAwardChallengeBeat(BmSDK.BmGame.MDarkKnightChallenge Challenge, bool AwardXPNow)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginAwardChallengeBeat, "BmGame.MExperienceSystem.BeginAwardChallengeBeat");
        byte* paramsPtr = stackalloc byte[124];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Challenge, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AwardXPNow, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AwardXP;
    /// <summary>
    /// Function: AwardXP
    /// </summary>
    public unsafe virtual void AwardXP(BmSDK.BmGame.MExperienceSystem.XPType TypeOfXP)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AwardXP, "BmGame.MExperienceSystem.AwardXP");
        byte* paramsPtr = stackalloc byte[144];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TypeOfXP, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPointsForPredator;
    /// <summary>
    /// Function: GetPointsForPredator
    /// </summary>
    public unsafe virtual int GetPointsForPredator(BmSDK.GFxUI.GFxObject XPDataGrade, out int ThreatXP)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPointsForPredator, "BmGame.MExperienceSystem.GetPointsForPredator");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPDataGrade, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ThreatXP);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThreatXP, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThreatXP = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetPointsForFFC;
    /// <summary>
    /// Function: GetPointsForFFC
    /// </summary>
    public unsafe virtual int GetPointsForFFC(BmSDK.GFxUI.GFxObject XPDataGrade, out int ThreatXP)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPointsForFFC, "BmGame.MExperienceSystem.GetPointsForFFC");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPDataGrade, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ThreatXP);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThreatXP, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThreatXP = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetLevels;
    /// <summary>
    /// Function: GetLevels
    /// </summary>
    public unsafe virtual void GetLevels(BmSDK.GFxUI.GFxObject XPDataCategory, int xp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLevels, "BmGame.MExperienceSystem.GetLevels");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPDataCategory, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(xp, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGrade;
    /// <summary>
    /// Function: GetGrade
    /// </summary>
    public unsafe virtual int GetGrade(BmSDK.GFxUI.GFxObject XPData, BmSDK.BmGame.MExperienceSystem.XPType TypeOfXP, out int ThreatXP)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGrade, "BmGame.MExperienceSystem.GetGrade");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPData, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TypeOfXP, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ThreatXP);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThreatXP, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThreatXP = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_NotifyCombatIsOver;
    /// <summary>
    /// Function: NotifyCombatIsOver
    /// </summary>
    public unsafe virtual void NotifyCombatIsOver(int hitCount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyCombatIsOver, "BmGame.MExperienceSystem.NotifyCombatIsOver");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(hitCount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyPredatorIsOver;
    /// <summary>
    /// Function: NotifyPredatorIsOver
    /// </summary>
    public unsafe virtual void NotifyPredatorIsOver(int PlayerSeenCount, int hitCount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyPredatorIsOver, "BmGame.MExperienceSystem.NotifyPredatorIsOver");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerSeenCount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(hitCount, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyPredatorRooftopUntouch;
    /// <summary>
    /// Function: NotifyPredatorRooftopUntouch
    /// </summary>
    public unsafe virtual void NotifyPredatorRooftopUntouch(BmSDK.BmGame.RBMRoomAIState PredatorRooftop, int hitCount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyPredatorRooftopUntouch, "BmGame.MExperienceSystem.NotifyPredatorRooftopUntouch");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PredatorRooftop, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(hitCount, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyPredatorRooftopTouch;
    /// <summary>
    /// Function: NotifyPredatorRooftopTouch
    /// </summary>
    public unsafe virtual void NotifyPredatorRooftopTouch(BmSDK.BmGame.RBMRoomAIState PredatorRooftop)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyPredatorRooftopTouch, "BmGame.MExperienceSystem.NotifyPredatorRooftopTouch");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PredatorRooftop, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyEnemyKO;
    /// <summary>
    /// Function: NotifyEnemyKO
    /// </summary>
    public unsafe virtual void NotifyEnemyKO(BmSDK.BmGame.RBMPawnAI EnemyPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyEnemyKO, "BmGame.MExperienceSystem.NotifyEnemyKO");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnemyPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyEnemyRemoved;
    /// <summary>
    /// Function: NotifyEnemyRemoved
    /// </summary>
    public unsafe virtual void NotifyEnemyRemoved(BmSDK.BmGame.RBMPawnAI EnemyPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyEnemyRemoved, "BmGame.MExperienceSystem.NotifyEnemyRemoved");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnemyPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyEnemyAsCombatant;
    /// <summary>
    /// Function: NotifyEnemyAsCombatant
    /// </summary>
    public unsafe virtual void NotifyEnemyAsCombatant(BmSDK.BmGame.RBMPawnAI EnemyPawn, bool PlayerSeen)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyEnemyAsCombatant, "BmGame.MExperienceSystem.NotifyEnemyAsCombatant");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnemyPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerSeen, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AwardMiscXP;
    /// <summary>
    /// Function: AwardMiscXP
    /// </summary>
    public unsafe virtual void AwardMiscXP(int miscXP, BmSDK.FString MiscName, bool showXPSequence = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AwardMiscXP, "BmGame.MExperienceSystem.AwardMiscXP");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(miscXP, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MiscName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(showXPSequence, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AwardXPImmediately;
    /// <summary>
    /// Function: AwardXPImmediately
    /// </summary>
    public unsafe virtual void AwardXPImmediately()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AwardXPImmediately, "BmGame.MExperienceSystem.AwardXPImmediately");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LevelUpActions;
    /// <summary>
    /// Function: LevelUpActions
    /// </summary>
    public unsafe virtual void LevelUpActions(int Level)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LevelUpActions, "BmGame.MExperienceSystem.LevelUpActions");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Level, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.MExperienceSystem.Tick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsXPAwardQueued;
    /// <summary>
    /// Function: IsXPAwardQueued
    /// </summary>
    public unsafe virtual bool IsXPAwardQueued()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsXPAwardQueued, "BmGame.MExperienceSystem.IsXPAwardQueued");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TurnOffXP;
    /// <summary>
    /// Function: TurnOffXP
    /// </summary>
    public unsafe virtual void TurnOffXP()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffXP, "BmGame.MExperienceSystem.TurnOffXP");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TurnOnXP;
    /// <summary>
    /// Function: TurnOnXP
    /// </summary>
    public unsafe virtual void TurnOnXP()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOnXP, "BmGame.MExperienceSystem.TurnOnXP");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBankedXP;
    /// <summary>
    /// Function: GetBankedXP
    /// </summary>
    public unsafe int GetBankedXP(BmSDK.GFxUI.GFxObject XPData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBankedXP, "BmGame.MExperienceSystem.GetBankedXP");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPData, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetMiscXP;
    /// <summary>
    /// Function: GetMiscXP
    /// </summary>
    public unsafe int GetMiscXP(BmSDK.GFxUI.GFxObject XPData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMiscXP, "BmGame.MExperienceSystem.GetMiscXP");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPData, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ShowDebugThreatLevel;
    /// <summary>
    /// Function: ShowDebugThreatLevel
    /// </summary>
    public unsafe virtual void ShowDebugThreatLevel(BmSDK.Engine.Canvas C)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowDebugThreatLevel, "BmGame.MExperienceSystem.ShowDebugThreatLevel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPredThreatLocalisedString;
    /// <summary>
    /// Function: GetPredThreatLocalisedString
    /// </summary>
    public unsafe virtual BmSDK.FString GetPredThreatLocalisedString(int ThreatLevel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPredThreatLocalisedString, "BmGame.MExperienceSystem.GetPredThreatLocalisedString");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThreatLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetThreatLevelInternal;
    /// <summary>
    /// Function: GetThreatLevelInternal
    /// </summary>
    public unsafe virtual int GetThreatLevelInternal(BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FThreatLevelRange> ThreatLevels, int xp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThreatLevelInternal, "BmGame.MExperienceSystem.GetThreatLevelInternal");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThreatLevels, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(xp, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetThreatLocalisedString;
    /// <summary>
    /// Function: GetThreatLocalisedString
    /// </summary>
    public unsafe virtual BmSDK.FString GetThreatLocalisedString(BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FThreatLevelRange> ThreatLevels, int xp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThreatLocalisedString, "BmGame.MExperienceSystem.GetThreatLocalisedString");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThreatLevels, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(xp, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetThreatString;
    /// <summary>
    /// Function: GetThreatString
    /// </summary>
    public unsafe virtual BmSDK.FString GetThreatString(BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FThreatLevelRange> ThreatLevels, int ThreatLevel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThreatString, "BmGame.MExperienceSystem.GetThreatString");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThreatLevels, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThreatLevel, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetThreatColor;
    /// <summary>
    /// Function: GetThreatColor
    /// </summary>
    public unsafe virtual BmSDK.GameObject.FColor GetThreatColor(bool isFFC, int ThreatLevel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThreatColor, "BmGame.MExperienceSystem.GetThreatColor");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(isFFC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThreatLevel, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FColor>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetThreatThug;
    /// <summary>
    /// Function: GetThreatThug
    /// </summary>
    public unsafe virtual int GetThreatThug(BmSDK.GFxUI.GFxObject XPDataThreat, BmSDK.BmGame.MExperienceSystem.XPType TypeOfXP)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThreatThug, "BmGame.MExperienceSystem.GetThreatThug");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPDataThreat, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TypeOfXP, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetThreatXP;
    /// <summary>
    /// Function: GetThreatXP
    /// </summary>
    public unsafe int GetThreatXP(BmSDK.GFxUI.GFxObject XPData, BmSDK.BmGame.MExperienceSystem.XPType TypeOfXP)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThreatXP, "BmGame.MExperienceSystem.GetThreatXP");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPData, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TypeOfXP, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_AddCountData;
    /// <summary>
    /// Function: AddCountData
    /// </summary>
    public unsafe virtual int AddCountData(BmSDK.GFxUI.GFxObject XPDataArray, float Count, BmSDK.FString Loc, out int DataIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCountData, "BmGame.MExperienceSystem.AddCountData");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPDataArray, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Count, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DataIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DataIndex, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DataIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_AddStringData;
    /// <summary>
    /// Function: AddStringData
    /// </summary>
    public unsafe virtual void AddStringData(BmSDK.GFxUI.GFxObject XPDataArray, BmSDK.FString Loc, out int DataIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddStringData, "BmGame.MExperienceSystem.AddStringData");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPDataArray, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DataIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DataIndex, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DataIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
        return;
    }

    private static BmSDK.Function __fn_AddScoreData;
    /// <summary>
    /// Function: AddScoreData
    /// </summary>
    public unsafe virtual int AddScoreData(BmSDK.GFxUI.GFxObject XPDataArray, float Count, float xp, BmSDK.FString Loc, out int DataIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddScoreData, "BmGame.MExperienceSystem.AddScoreData");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPDataArray, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Count, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(xp, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DataIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DataIndex, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DataIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_AddRewardData;
    /// <summary>
    /// Function: AddRewardData
    /// </summary>
    public unsafe virtual int AddRewardData(BmSDK.GFxUI.GFxObject XPDataArray, float xp, BmSDK.FString Loc, out int DataIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddRewardData, "BmGame.MExperienceSystem.AddRewardData");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPDataArray, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(xp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DataIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DataIndex, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DataIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_AddThugScore;
    /// <summary>
    /// Function: AddThugScore
    /// </summary>
    public unsafe virtual int AddThugScore(BmSDK.GFxUI.GFxObject XPDataArray, BmSDK.FString enemyTypeString, BmSDK.BmGame.RGameInfo.ECombatPawnType PawnType, BmSDK.FString LocString, out int DataIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddThugScore, "BmGame.MExperienceSystem.AddThugScore");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPDataArray, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(enemyTypeString, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocString, paramsPtr + 20);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DataIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DataIndex, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DataIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_GetPredatorThreatModifier;
    /// <summary>
    /// Function: GetPredatorThreatModifier
    /// </summary>
    public unsafe virtual int GetPredatorThreatModifier(BmSDK.GFxUI.GFxObject XPDataThreat)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPredatorThreatModifier, "BmGame.MExperienceSystem.GetPredatorThreatModifier");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPDataThreat, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetFFCThreatModifier;
    /// <summary>
    /// Function: GetFFCThreatModifier
    /// </summary>
    public unsafe virtual int GetFFCThreatModifier(BmSDK.GFxUI.GFxObject XPDataThreat)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFFCThreatModifier, "BmGame.MExperienceSystem.GetFFCThreatModifier");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPDataThreat, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetCombatGrade;
    /// <summary>
    /// Function: GetCombatGrade
    /// </summary>
    public unsafe virtual void GetCombatGrade(out BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FCombatGradeRange> CombatGrades, int GradePoints, out BmSDK.FString GradeLevel, out BmSDK.FString GradeName, out float XPBonus)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatGrade, "BmGame.MExperienceSystem.GetCombatGrade");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GradePoints, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out XPBonus);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPBonus, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CombatGrades = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FCombatGradeRange>>(paramsPtr + 0);
        GradeLevel = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 16);
        GradeName = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 28);
        XPBonus = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 40);
        return;
    }

    private static BmSDK.Function __fn_GetPredatorBonusPoints;
    /// <summary>
    /// Function: GetPredatorBonusPoints
    /// </summary>
    public unsafe virtual int GetPredatorBonusPoints(BmSDK.GFxUI.GFxObject XPDataGrade, BmSDK.GFxUI.GFxObject XPDataGradeStats, out int DataIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPredatorBonusPoints, "BmGame.MExperienceSystem.GetPredatorBonusPoints");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPDataGrade, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPDataGradeStats, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DataIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DataIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DataIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_AddTakedownScore;
    /// <summary>
    /// Function: AddTakedownScore
    /// </summary>
    public unsafe virtual void AddTakedownScore(BmSDK.GFxUI.GFxObject XPDataArray, BmSDK.BmGame.RGameInfo.EPredTakedownType TakedownType, out int DataIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddTakedownScore, "BmGame.MExperienceSystem.AddTakedownScore");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPDataArray, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TakedownType, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DataIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DataIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DataIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_GetFurtivityPoints;
    /// <summary>
    /// Function: GetFurtivityPoints
    /// </summary>
    public unsafe virtual int GetFurtivityPoints(BmSDK.GFxUI.GFxObject XPDataGradeStats, out int DataIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFurtivityPoints, "BmGame.MExperienceSystem.GetFurtivityPoints");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPDataGradeStats, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DataIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DataIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DataIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetCombatVariationPoints;
    /// <summary>
    /// Function: GetCombatVariationPoints
    /// </summary>
    public unsafe virtual int GetCombatVariationPoints(BmSDK.GFxUI.GFxObject XPDataGradeStats, out int DataIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatVariationPoints, "BmGame.MExperienceSystem.GetCombatVariationPoints");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPDataGradeStats, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DataIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DataIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DataIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetComboVariationScore;
    /// <summary>
    /// Function: GetComboVariationScore
    /// </summary>
    public unsafe virtual int GetComboVariationScore()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetComboVariationScore, "BmGame.MExperienceSystem.GetComboVariationScore");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCombatEfficiencyPoints;
    /// <summary>
    /// Function: GetCombatEfficiencyPoints
    /// </summary>
    public unsafe virtual int GetCombatEfficiencyPoints(BmSDK.GFxUI.GFxObject XPDataGradeStats, out int DataIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatEfficiencyPoints, "BmGame.MExperienceSystem.GetCombatEfficiencyPoints");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPDataGradeStats, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DataIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DataIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DataIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetCombatPerformancePoints;
    /// <summary>
    /// Function: GetCombatPerformancePoints
    /// </summary>
    public unsafe virtual int GetCombatPerformancePoints(BmSDK.GFxUI.GFxObject XPDataGradeStats, out int DataIndex)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatPerformancePoints, "BmGame.MExperienceSystem.GetCombatPerformancePoints");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPDataGradeStats, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out DataIndex);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DataIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DataIndex = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetGradePointsFrom;
    /// <summary>
    /// Function: GetGradePointsFrom
    /// </summary>
    public unsafe virtual int GetGradePointsFrom(in BmSDK.TArray<BmSDK.BmGame.MExperienceSystemConfig.FCombatEfficiencyRange> Table, float Value)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGradePointsFrom, "BmGame.MExperienceSystem.GetGradePointsFrom");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Table, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetArkhamCityGameActionXPValue;
    /// <summary>
    /// Function: GetArkhamCityGameActionXPValue
    /// </summary>
    public unsafe virtual int GetArkhamCityGameActionXPValue(BmSDK.BmGame.RGameInfo.EGameAction GameAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetArkhamCityGameActionXPValue, "BmGame.MExperienceSystem.GetArkhamCityGameActionXPValue");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GameAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetArkhamCityCombatXPConfigValues;
    /// <summary>
    /// Function: GetArkhamCityCombatXPConfigValues
    /// </summary>
    public unsafe virtual void GetArkhamCityCombatXPConfigValues(int MaxCombo, int MaxVariation, int MaxGadgetVariation, int IntimidationTakedowns, int PredatorVariation, out int MaxComboBonus, out int MaxVariationBonus, out int MaxGadgetVariationBonus, out int IntimidationTakedownBonus, out int PredatorVariationBonus)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetArkhamCityCombatXPConfigValues, "BmGame.MExperienceSystem.GetArkhamCityCombatXPConfigValues");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxCombo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxVariation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxGadgetVariation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IntimidationTakedowns, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PredatorVariation, paramsPtr + 16);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MaxComboBonus);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxComboBonus, paramsPtr + 20);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MaxVariationBonus);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxVariationBonus, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MaxGadgetVariationBonus);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxGadgetVariationBonus, paramsPtr + 28);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out IntimidationTakedownBonus);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IntimidationTakedownBonus, paramsPtr + 32);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PredatorVariationBonus);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PredatorVariationBonus, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        MaxComboBonus = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 20);
        MaxVariationBonus = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 24);
        MaxGadgetVariationBonus = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 28);
        IntimidationTakedownBonus = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 32);
        PredatorVariationBonus = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 36);
        return;
    }

    private static BmSDK.Function __fn_UnblockDoubleTakedown;
    /// <summary>
    /// Function: UnblockDoubleTakedown
    /// </summary>
    public unsafe virtual void UnblockDoubleTakedown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnblockDoubleTakedown, "BmGame.MExperienceSystem.UnblockDoubleTakedown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPlayerController;
    /// <summary>
    /// Function: SetPlayerController
    /// </summary>
    public unsafe virtual void SetPlayerController(BmSDK.BmGame.RPlayerController RPC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPlayerController, "BmGame.MExperienceSystem.SetPlayerController");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.MExperienceSystem.Init");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_KillUISound;
    /// <summary>
    /// Function: KillUISound
    /// </summary>
    public unsafe virtual void KillUISound()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillUISound, "BmGame.MExperienceSystem.KillUISound");
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

    private static BmSDK.Function __fn_CalculateFFCWeaponCount;
    /// <summary>
    /// Function: CalculateFFCWeaponCount
    /// </summary>
    public unsafe virtual void CalculateFFCWeaponCount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateFFCWeaponCount, "BmGame.MExperienceSystem.CalculateFFCWeaponCount");
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

    private static BmSDK.Function __fn_CalculatePredThreatLevel;
    /// <summary>
    /// Function: CalculatePredThreatLevel
    /// </summary>
    public unsafe virtual void CalculatePredThreatLevel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculatePredThreatLevel, "BmGame.MExperienceSystem.CalculatePredThreatLevel");
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

    private static BmSDK.Function __fn_CalculateFFCThreatLevel;
    /// <summary>
    /// Function: CalculateFFCThreatLevel
    /// </summary>
    public unsafe virtual void CalculateFFCThreatLevel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateFFCThreatLevel, "BmGame.MExperienceSystem.CalculateFFCThreatLevel");
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

    private static BmSDK.Function __fn_VillainsAreNearby;
    /// <summary>
    /// Function: VillainsAreNearby
    /// </summary>
    public unsafe virtual bool VillainsAreNearby(float MaxHorizontalDistance, float MaxVerticalDistance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_VillainsAreNearby, "BmGame.MExperienceSystem.VillainsAreNearby");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxHorizontalDistance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxVerticalDistance, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetMiscellaneousXPValueByType;
    /// <summary>
    /// Function: GetMiscellaneousXPValueByType
    /// </summary>
    public unsafe virtual int GetMiscellaneousXPValueByType(BmSDK.BmGame.RGameInfo.EGameAction Type)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMiscellaneousXPValueByType, "BmGame.MExperienceSystem.GetMiscellaneousXPValueByType");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetMiscellaneousXPValue;
    /// <summary>
    /// Function: GetMiscellaneousXPValue
    /// </summary>
    public unsafe virtual int GetMiscellaneousXPValue(BmSDK.FString MiscellaneousXPTag)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMiscellaneousXPValue, "BmGame.MExperienceSystem.GetMiscellaneousXPValue");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MiscellaneousXPTag, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetPawnTypeXPValue;
    /// <summary>
    /// Function: GetPawnTypeXPValue
    /// </summary>
    public unsafe virtual int GetPawnTypeXPValue(BmSDK.BmGame.RPawnVillain Villain)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPawnTypeXPValue, "BmGame.MExperienceSystem.GetPawnTypeXPValue");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetPawnCombatModifierXPValue;
    /// <summary>
    /// Function: GetPawnCombatModifierXPValue
    /// </summary>
    public unsafe virtual int GetPawnCombatModifierXPValue(BmSDK.BmGame.RBMPawnAI Villain)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPawnCombatModifierXPValue, "BmGame.MExperienceSystem.GetPawnCombatModifierXPValue");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ResetFreeFlowCombatValues;
    /// <summary>
    /// Function: ResetFreeFlowCombatValues
    /// </summary>
    public unsafe virtual void ResetFreeFlowCombatValues()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetFreeFlowCombatValues, "BmGame.MExperienceSystem.ResetFreeFlowCombatValues");
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

    /// <summary>
    /// Struct: FThreatLevelPred
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FThreatLevelPred
    {
        /// <summary>
        /// ObjectProperty: mPredVolume
        /// </summary>
        public unsafe BmSDK.BmGame.RPredatorVolume mPredVolume
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPredatorVolume>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: mThreatLevel
        /// </summary>
        public unsafe int mThreatLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: mGroupCenter
        /// </summary>
        public unsafe System.Numerics.Vector3 mGroupCenter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: mGroupColor
        /// </summary>
        public unsafe BmSDK.GameObject.FColor mGroupColor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FThreatLevelFFC
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FThreatLevelFFC
    {
        /// <summary>
        /// ObjectProperty: mPylon
        /// </summary>
        public unsafe BmSDK.Engine.Pylon mPylon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pylon>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: mThreatLevel
        /// </summary>
        public unsafe int mThreatLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ArrayProperty: mGroupMember
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain> mGroupMember
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: mGroupCenter
        /// </summary>
        public unsafe System.Numerics.Vector3 mGroupCenter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// StructProperty: mGroupColor
        /// </summary>
        public unsafe BmSDK.GameObject.FColor mGroupColor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
    }

    /// <summary>
    /// ArrayProperty: ChallengesBeat
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MExperienceSystem.FSChallengeBeatNotification> ChallengesBeat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MExperienceSystem.FSChallengeBeatNotification>>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// ArrayProperty: ProcessedChallengesBeat
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MExperienceSystem.FSChallengeBeatNotification> ProcessedChallengesBeat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MExperienceSystem.FSChallengeBeatNotification>>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// ObjectProperty: mXPConfig
    /// </summary>
    public unsafe BmSDK.BmGame.MExperienceSystemConfig mXPConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MExperienceSystemConfig>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// IntProperty: mAwardedFreeFlowCombatXP
    /// </summary>
    public unsafe int mAwardedFreeFlowCombatXP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }

    /// <summary>
    /// IntProperty: mAwardedPredatorXP
    /// </summary>
    public unsafe int mAwardedPredatorXP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }

    /// <summary>
    /// IntProperty: mAwardedMiscXP
    /// </summary>
    public unsafe int mAwardedMiscXP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// IntProperty: mPendingMiscXP
    /// </summary>
    public unsafe int mPendingMiscXP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StrProperty: mPendingMiscXPName
    /// </summary>
    public unsafe BmSDK.FString mPendingMiscXPName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// ObjectProperty: mGameInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo mGameInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ObjectProperty: WorldInfo
    /// </summary>
    public unsafe BmSDK.Engine.WorldInfo WorldInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.WorldInfo>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ObjectProperty: mGameRepInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI mGameRepInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: XpCountingON
    /// </summary>
    public unsafe bool XpCountingON
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: SaveAfterAwardingXP
    /// </summary>
    public unsafe bool SaveAfterAwardingXP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: NeedAwardChallengeXP
    /// </summary>
    public unsafe bool NeedAwardChallengeXP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: mIsInPredator
    /// </summary>
    public unsafe bool mIsInPredator
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: mHaveInterrogation
    /// </summary>
    public unsafe bool mHaveInterrogation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: mGiveAwardedXP
    /// </summary>
    public unsafe bool mGiveAwardedXP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: mHasInitXPBarForLevel
    /// </summary>
    public unsafe bool mHasInitXPBarForLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: BlockDoubleTakedown
    /// </summary>
    public unsafe bool BlockDoubleTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: PerfectFreeFlowCombat
    /// </summary>
    public unsafe bool PerfectFreeFlowCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: bPauseXPHud
    /// </summary>
    public unsafe bool bPauseXPHud
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: HasPausedXPMovie
    /// </summary>
    public unsafe bool HasPausedXPMovie
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: CombatVariationCount
    /// </summary>
    public InlineArray<int> CombatVariationCount => new(72, Ptr + 116, 4, this);

    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_41
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_42
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_43
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_44
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_45
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_46
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_47
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_48
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_49
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_50
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_51
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_52
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_53
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_54
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_55
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_56
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_57
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_58
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_59
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_60
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_61
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_62
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_63
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_64
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_65
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_66
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_67
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_68
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_69
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_70
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }
    /// <summary>
    /// IntProperty: CombatVariationCount
    /// </summary>
    public unsafe int CombatVariationCount_71
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: mKOCount
    /// </summary>
    public InlineArray<int> mKOCount => new(41, Ptr + 404, 4, this);

    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }
    /// <summary>
    /// IntProperty: mKOCount
    /// </summary>
    public unsafe int mKOCount_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: mEnemyTypeCount
    /// </summary>
    public InlineArray<int> mEnemyTypeCount => new(41, Ptr + 568, 4, this);

    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }
    /// <summary>
    /// IntProperty: mEnemyTypeCount
    /// </summary>
    public unsafe int mEnemyTypeCount_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: mFFCWeaponCount
    /// </summary>
    public InlineArray<int> mFFCWeaponCount => new(23, Ptr + 732, 4, this);

    /// <summary>
    /// IntProperty: mFFCWeaponCount
    /// </summary>
    public unsafe int mFFCWeaponCount_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponCount
    /// </summary>
    public unsafe int mFFCWeaponCount_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponCount
    /// </summary>
    public unsafe int mFFCWeaponCount_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponCount
    /// </summary>
    public unsafe int mFFCWeaponCount_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponCount
    /// </summary>
    public unsafe int mFFCWeaponCount_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponCount
    /// </summary>
    public unsafe int mFFCWeaponCount_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponCount
    /// </summary>
    public unsafe int mFFCWeaponCount_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponCount
    /// </summary>
    public unsafe int mFFCWeaponCount_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponCount
    /// </summary>
    public unsafe int mFFCWeaponCount_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponCount
    /// </summary>
    public unsafe int mFFCWeaponCount_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponCount
    /// </summary>
    public unsafe int mFFCWeaponCount_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponCount
    /// </summary>
    public unsafe int mFFCWeaponCount_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponCount
    /// </summary>
    public unsafe int mFFCWeaponCount_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponCount
    /// </summary>
    public unsafe int mFFCWeaponCount_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponCount
    /// </summary>
    public unsafe int mFFCWeaponCount_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponCount
    /// </summary>
    public unsafe int mFFCWeaponCount_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponCount
    /// </summary>
    public unsafe int mFFCWeaponCount_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponCount
    /// </summary>
    public unsafe int mFFCWeaponCount_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponCount
    /// </summary>
    public unsafe int mFFCWeaponCount_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponCount
    /// </summary>
    public unsafe int mFFCWeaponCount_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponCount
    /// </summary>
    public unsafe int mFFCWeaponCount_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponCount
    /// </summary>
    public unsafe int mFFCWeaponCount_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponCount
    /// </summary>
    public unsafe int mFFCWeaponCount_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: mFFCWeaponEquipCount
    /// </summary>
    public InlineArray<int> mFFCWeaponEquipCount => new(23, Ptr + 824, 4, this);

    /// <summary>
    /// IntProperty: mFFCWeaponEquipCount
    /// </summary>
    public unsafe int mFFCWeaponEquipCount_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponEquipCount
    /// </summary>
    public unsafe int mFFCWeaponEquipCount_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponEquipCount
    /// </summary>
    public unsafe int mFFCWeaponEquipCount_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponEquipCount
    /// </summary>
    public unsafe int mFFCWeaponEquipCount_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponEquipCount
    /// </summary>
    public unsafe int mFFCWeaponEquipCount_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponEquipCount
    /// </summary>
    public unsafe int mFFCWeaponEquipCount_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponEquipCount
    /// </summary>
    public unsafe int mFFCWeaponEquipCount_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponEquipCount
    /// </summary>
    public unsafe int mFFCWeaponEquipCount_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponEquipCount
    /// </summary>
    public unsafe int mFFCWeaponEquipCount_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponEquipCount
    /// </summary>
    public unsafe int mFFCWeaponEquipCount_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponEquipCount
    /// </summary>
    public unsafe int mFFCWeaponEquipCount_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponEquipCount
    /// </summary>
    public unsafe int mFFCWeaponEquipCount_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponEquipCount
    /// </summary>
    public unsafe int mFFCWeaponEquipCount_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponEquipCount
    /// </summary>
    public unsafe int mFFCWeaponEquipCount_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponEquipCount
    /// </summary>
    public unsafe int mFFCWeaponEquipCount_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponEquipCount
    /// </summary>
    public unsafe int mFFCWeaponEquipCount_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponEquipCount
    /// </summary>
    public unsafe int mFFCWeaponEquipCount_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponEquipCount
    /// </summary>
    public unsafe int mFFCWeaponEquipCount_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponEquipCount
    /// </summary>
    public unsafe int mFFCWeaponEquipCount_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponEquipCount
    /// </summary>
    public unsafe int mFFCWeaponEquipCount_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponEquipCount
    /// </summary>
    public unsafe int mFFCWeaponEquipCount_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponEquipCount
    /// </summary>
    public unsafe int mFFCWeaponEquipCount_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponEquipCount
    /// </summary>
    public unsafe int mFFCWeaponEquipCount_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: mFFCWeaponDestroyCount
    /// </summary>
    public InlineArray<int> mFFCWeaponDestroyCount => new(23, Ptr + 916, 4, this);

    /// <summary>
    /// IntProperty: mFFCWeaponDestroyCount
    /// </summary>
    public unsafe int mFFCWeaponDestroyCount_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponDestroyCount
    /// </summary>
    public unsafe int mFFCWeaponDestroyCount_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponDestroyCount
    /// </summary>
    public unsafe int mFFCWeaponDestroyCount_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponDestroyCount
    /// </summary>
    public unsafe int mFFCWeaponDestroyCount_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponDestroyCount
    /// </summary>
    public unsafe int mFFCWeaponDestroyCount_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponDestroyCount
    /// </summary>
    public unsafe int mFFCWeaponDestroyCount_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponDestroyCount
    /// </summary>
    public unsafe int mFFCWeaponDestroyCount_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponDestroyCount
    /// </summary>
    public unsafe int mFFCWeaponDestroyCount_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponDestroyCount
    /// </summary>
    public unsafe int mFFCWeaponDestroyCount_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponDestroyCount
    /// </summary>
    public unsafe int mFFCWeaponDestroyCount_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponDestroyCount
    /// </summary>
    public unsafe int mFFCWeaponDestroyCount_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponDestroyCount
    /// </summary>
    public unsafe int mFFCWeaponDestroyCount_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponDestroyCount
    /// </summary>
    public unsafe int mFFCWeaponDestroyCount_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponDestroyCount
    /// </summary>
    public unsafe int mFFCWeaponDestroyCount_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponDestroyCount
    /// </summary>
    public unsafe int mFFCWeaponDestroyCount_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponDestroyCount
    /// </summary>
    public unsafe int mFFCWeaponDestroyCount_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponDestroyCount
    /// </summary>
    public unsafe int mFFCWeaponDestroyCount_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponDestroyCount
    /// </summary>
    public unsafe int mFFCWeaponDestroyCount_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponDestroyCount
    /// </summary>
    public unsafe int mFFCWeaponDestroyCount_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponDestroyCount
    /// </summary>
    public unsafe int mFFCWeaponDestroyCount_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponDestroyCount
    /// </summary>
    public unsafe int mFFCWeaponDestroyCount_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponDestroyCount
    /// </summary>
    public unsafe int mFFCWeaponDestroyCount_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }
    /// <summary>
    /// IntProperty: mFFCWeaponDestroyCount
    /// </summary>
    public unsafe int mFFCWeaponDestroyCount_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// ArrayProperty: mKOLocation
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> mKOLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// IntProperty: mBestKOCount
    /// </summary>
    public unsafe int mBestKOCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// IntProperty: mBestComboCount
    /// </summary>
    public unsafe int mBestComboCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// IntProperty: mBestCriticalCount
    /// </summary>
    public unsafe int mBestCriticalCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// IntProperty: mBestTakedownCount
    /// </summary>
    public unsafe int mBestTakedownCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// IntProperty: mTotalEnemyCount
    /// </summary>
    public unsafe int mTotalEnemyCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// ArrayProperty: mCurrentCombatants
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI> mCurrentCombatants
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI>>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// FloatProperty: mAwardXPAfterDelay
    /// </summary>
    public unsafe float mAwardXPAfterDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// ObjectProperty: mPlayerController
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController mPlayerController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// ArrayProperty: PredTakedownType
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MExperienceSystem.FPredatorTakedownInfo> PredTakedownType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MExperienceSystem.FPredatorTakedownInfo>>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// IntProperty: PredatorPlayerSeenCount
    /// </summary>
    public unsafe int PredatorPlayerSeenCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// IntProperty: CombatPlayerSeenCount
    /// </summary>
    public unsafe int CombatPlayerSeenCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// IntProperty: HitCountDuringCombat
    /// </summary>
    public unsafe int HitCountDuringCombat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// FloatProperty: AwardCombatXPTimer
    /// </summary>
    public unsafe float AwardCombatXPTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// FloatProperty: AwardPredXPTimer
    /// </summary>
    public unsafe float AwardPredXPTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// FloatProperty: mAwardChallengeXPTimer
    /// </summary>
    public unsafe float mAwardChallengeXPTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// ObjectProperty: MiscXPObject
    /// </summary>
    public unsafe BmSDK.BmGame.MMiscellaneousXP MiscXPObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MMiscellaneousXP>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ComponentProperty: LastPredatorRoom
    /// </summary>
    public unsafe BmSDK.BmGame.RBMRoomAIState LastPredatorRoom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMRoomAIState>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// IntProperty: mLastCombatPawnCount
    /// </summary>
    public unsafe int mLastCombatPawnCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ArrayProperty: mThreatLevelFFC
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MExperienceSystem.FThreatLevelFFC> mThreatLevelFFC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MExperienceSystem.FThreatLevelFFC>>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// IntProperty: mLastPredVolumeCount
    /// </summary>
    public unsafe int mLastPredVolumeCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// ArrayProperty: mThreatLevelPred
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MExperienceSystem.FThreatLevelPred> mThreatLevelPred
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MExperienceSystem.FThreatLevelPred>>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// FloatProperty: ReplenishRate
    /// </summary>
    public unsafe float ReplenishRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// Struct: FSChallengeBeatNotification
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 92)]
    public partial record struct FSChallengeBeatNotification
    {
        /// <summary>
        /// IntProperty: mAwardedChallengeXP
        /// </summary>
        public unsafe int mAwardedChallengeXP
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: mBeatChallenge
        /// </summary>
        public unsafe BmSDK.BmGame.MDarkKnightChallenge mBeatChallenge
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MDarkKnightChallenge>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: mNewBeatPathLevel
        /// </summary>
        public unsafe bool mNewBeatPathLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: mBeatChallengeLevel
        /// </summary>
        public unsafe int mBeatChallengeLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: mBeatChallengeLevelSettings
        /// </summary>
        public unsafe BmSDK.BmGame.MDarkKnightChallengesSettings.FDKPathSettings mBeatChallengeLevelSettings
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MDarkKnightChallengesSettings.FDKPathSettings>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// BoolProperty: mNewBeatPath
        /// </summary>
        public unsafe bool mNewBeatPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }; }
        }

        /// <summary>
        /// StructProperty: mBeatChallengePathSettings
        /// </summary>
        public unsafe BmSDK.BmGame.MDarkKnightChallengesSettings.FDKPathSettings mBeatChallengePathSettings
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MDarkKnightChallengesSettings.FDKPathSettings>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// BoolProperty: mNewBeatDarkKnight
        /// </summary>
        public unsafe bool mNewBeatDarkKnight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }; }
        }

        /// <summary>
        /// ObjectProperty: mBeatDarkKnightSettings
        /// </summary>
        public unsafe BmSDK.BmGame.MDarkKnightChallengesSettings mBeatDarkKnightSettings
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MDarkKnightChallengesSettings>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }
    }

    /// <summary>
    /// Struct: FPredatorTakedownInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FPredatorTakedownInfo
    {
        /// <summary>
        /// IntProperty: Count
        /// </summary>
        public unsafe int Count
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: msg
        /// </summary>
        public unsafe BmSDK.FString msg
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StrProperty: ASvar
        /// </summary>
        public unsafe BmSDK.FString ASvar
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Enum: XPType
    /// </summary>
    public enum XPType : byte
    {
        XP_FFC = 0,
        XP_Predator = 1,
        XP_Challenges = 2,
        XP_Misc = 3,
        XP_Banked = 4,
        XP_MAX = 5,
    }
}
