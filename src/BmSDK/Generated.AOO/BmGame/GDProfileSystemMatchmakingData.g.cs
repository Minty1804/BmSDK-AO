#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: GDProfileSystemMatchmakingData<br/>
/// (size = 132)
/// (flags = 134250642)
/// </summary>
public partial class GDProfileSystemMatchmakingData : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.GDProfileSystemMatchmakingData", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GDProfileSystemMatchmakingData.
    /// </summary>
    public static GDProfileSystemMatchmakingData DefaultObject => (GDProfileSystemMatchmakingData)StaticClass().DefaultObject;

    internal GDProfileSystemMatchmakingData() { }

    /// <summary>
    /// Constructs a new GDProfileSystemMatchmakingData
    /// </summary>
    public GDProfileSystemMatchmakingData(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GDProfileSystemMatchmakingData Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GDProfileSystemMatchmakingData(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDProfileSystemMatchmakingData>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDProfileSystemMatchmakingData>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDProfileSystemMatchmakingData>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDProfileSystemMatchmakingData>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDProfileSystemMatchmakingData>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDProfileSystemMatchmakingData>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GDProfileSystemMatchmakingData>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GDProfileSystemMatchmakingData>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_OnNetvarsApplied;
    /// <summary>
    /// Function: OnNetvarsApplied
    /// </summary>
    public unsafe virtual void OnNetvarsApplied()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnNetvarsApplied, "BmGame.GDProfileSystemMatchmakingData.OnNetvarsApplied");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugDumpHistoricalWinValues;
    /// <summary>
    /// Function: DebugDumpHistoricalWinValues
    /// </summary>
    public unsafe virtual void DebugDumpHistoricalWinValues()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugDumpHistoricalWinValues, "BmGame.GDProfileSystemMatchmakingData.DebugDumpHistoricalWinValues");
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

    private static BmSDK.Function __fn_DebugResetMatchmakingData;
    /// <summary>
    /// Function: DebugResetMatchmakingData
    /// </summary>
    public unsafe virtual void DebugResetMatchmakingData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugResetMatchmakingData, "BmGame.GDProfileSystemMatchmakingData.DebugResetMatchmakingData");
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

    private static BmSDK.Function __fn_DebugAddMatchmakingMatch;
    /// <summary>
    /// Function: DebugAddMatchmakingMatch
    /// </summary>
    public unsafe virtual void DebugAddMatchmakingMatch(bool Finished, bool Won)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugAddMatchmakingMatch, "BmGame.GDProfileSystemMatchmakingData.DebugAddMatchmakingMatch");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Finished, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Won, paramsPtr + 4);
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

    private static BmSDK.Function __fn_DebugGenerateHistorical;
    /// <summary>
    /// Function: DebugGenerateHistorical
    /// </summary>
    public unsafe virtual void DebugGenerateHistorical(float NumMatches, float FinishedPercent, float WonPercent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugGenerateHistorical, "BmGame.GDProfileSystemMatchmakingData.DebugGenerateHistorical");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumMatches, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedPercent, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WonPercent, paramsPtr + 8);
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

    private static BmSDK.Function __fn_DumpMatchmakingData;
    /// <summary>
    /// Function: DumpMatchmakingData
    /// </summary>
    public unsafe virtual void DumpMatchmakingData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpMatchmakingData, "BmGame.GDProfileSystemMatchmakingData.DumpMatchmakingData");
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

    private static BmSDK.Function __fn_ValidateMatchmakingData;
    /// <summary>
    /// Function: ValidateMatchmakingData
    /// </summary>
    public unsafe virtual void ValidateMatchmakingData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ValidateMatchmakingData, "BmGame.GDProfileSystemMatchmakingData.ValidateMatchmakingData");
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

    private static BmSDK.Function __fn_RecalculateData;
    /// <summary>
    /// Function: RecalculateData
    /// </summary>
    public unsafe virtual void RecalculateData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecalculateData, "BmGame.GDProfileSystemMatchmakingData.RecalculateData");
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

    private static BmSDK.Function __fn_CalculateSkillWithQuitRatioCheck;
    /// <summary>
    /// Function: CalculateSkillWithQuitRatioCheck
    /// </summary>
    public unsafe virtual float CalculateSkillWithQuitRatioCheck(float Skill)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateSkillWithQuitRatioCheck, "BmGame.GDProfileSystemMatchmakingData.CalculateSkillWithQuitRatioCheck");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Skill, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CalculateModifiedSkill;
    /// <summary>
    /// Function: CalculateModifiedSkill
    /// </summary>
    public unsafe virtual float CalculateModifiedSkill(float Skill)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateModifiedSkill, "BmGame.GDProfileSystemMatchmakingData.CalculateModifiedSkill");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Skill, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CalculateSkillFromHistorical;
    /// <summary>
    /// Function: CalculateSkillFromHistorical
    /// </summary>
    public unsafe virtual float CalculateSkillFromHistorical()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateSkillFromHistorical, "BmGame.GDProfileSystemMatchmakingData.CalculateSkillFromHistorical");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CalculateSkill;
    /// <summary>
    /// Function: CalculateSkill
    /// </summary>
    public unsafe virtual float CalculateSkill()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateSkill, "BmGame.GDProfileSystemMatchmakingData.CalculateSkill");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAvgDownBandwidthToMatchmakingServers;
    /// <summary>
    /// Function: GetAvgDownBandwidthToMatchmakingServers
    /// </summary>
    public unsafe virtual float GetAvgDownBandwidthToMatchmakingServers()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAvgDownBandwidthToMatchmakingServers, "BmGame.GDProfileSystemMatchmakingData.GetAvgDownBandwidthToMatchmakingServers");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAvgUpBandwidthToMatchmakingServers;
    /// <summary>
    /// Function: GetAvgUpBandwidthToMatchmakingServers
    /// </summary>
    public unsafe virtual float GetAvgUpBandwidthToMatchmakingServers()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAvgUpBandwidthToMatchmakingServers, "BmGame.GDProfileSystemMatchmakingData.GetAvgUpBandwidthToMatchmakingServers");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AddMatchmakingServerQosData;
    /// <summary>
    /// Function: AddMatchmakingServerQosData
    /// </summary>
    public unsafe virtual void AddMatchmakingServerQosData(int UpBandwidth, int DownBandwidth)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddMatchmakingServerQosData, "BmGame.GDProfileSystemMatchmakingData.AddMatchmakingServerQosData");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpBandwidth, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DownBandwidth, paramsPtr + 4);
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSkillSearchParams, "BmGame.GDProfileSystemMatchmakingData.GetSkillSearchParams");
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
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
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

    private static BmSDK.Function __fn_GetCurrentSkill;
    /// <summary>
    /// Function: GetCurrentSkill
    /// </summary>
    public unsafe virtual int GetCurrentSkill()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentSkill, "BmGame.GDProfileSystemMatchmakingData.GetCurrentSkill");
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

    private static BmSDK.Function __fn_MatchFinished;
    /// <summary>
    /// Function: MatchFinished
    /// </summary>
    public unsafe virtual void MatchFinished(bool WonMatch)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MatchFinished, "BmGame.GDProfileSystemMatchmakingData.MatchFinished");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WonMatch, paramsPtr + 0);
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

    private static BmSDK.Function __fn_MatchStarted;
    /// <summary>
    /// Function: MatchStarted
    /// </summary>
    public unsafe virtual void MatchStarted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MatchStarted, "BmGame.GDProfileSystemMatchmakingData.MatchStarted");
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

    private static BmSDK.Function __fn_PostLoad;
    /// <summary>
    /// Function: PostLoad
    /// </summary>
    public unsafe virtual void PostLoad()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostLoad, "BmGame.GDProfileSystemMatchmakingData.PostLoad");
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

    private static BmSDK.Function __fn_Save;
    /// <summary>
    /// Function: Save
    /// </summary>
    public unsafe virtual void Save(BmSDK.SDEngine.SDProfile Profile)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Save, "BmGame.GDProfileSystemMatchmakingData.Save");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Profile, paramsPtr + 0);
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

    private static BmSDK.Function __fn_Load;
    /// <summary>
    /// Function: Load
    /// </summary>
    public unsafe virtual bool Load(BmSDK.SDEngine.SDProfile Profile)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Load, "BmGame.GDProfileSystemMatchmakingData.Load");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Profile, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_NativeInit;
    /// <summary>
    /// Function: NativeInit
    /// </summary>
    public unsafe virtual void NativeInit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NativeInit, "BmGame.GDProfileSystemMatchmakingData.NativeInit");
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

    private static BmSDK.Function __fn_Init;
    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe virtual void Init()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Init, "BmGame.GDProfileSystemMatchmakingData.Init");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// IntProperty: Cfg_INT_MaxHistoricalMatches
    /// </summary>
    public unsafe int Cfg_INT_MaxHistoricalMatches
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// FloatProperty: Cfg_FLOAT_CurveStartedModifier
    /// </summary>
    public unsafe float Cfg_FLOAT_CurveStartedModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// FloatProperty: Cfg_FLOAT_CurveWonModifier
    /// </summary>
    public unsafe float Cfg_FLOAT_CurveWonModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// FloatProperty: Cfg_FLOAT_NumberOfSkills
    /// </summary>
    public unsafe float Cfg_FLOAT_NumberOfSkills
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// FloatProperty: Cfg_FLOAT_MinValidSkill
    /// </summary>
    public unsafe float Cfg_FLOAT_MinValidSkill
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// FloatProperty: Cfg_FLOAT_NumMatchesUsingRandomSpread
    /// </summary>
    public unsafe float Cfg_FLOAT_NumMatchesUsingRandomSpread
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// FloatProperty: Cfg_FLOAT_InitialRandomSkillSpread
    /// </summary>
    public unsafe float Cfg_FLOAT_InitialRandomSkillSpread
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }

    /// <summary>
    /// FloatProperty: Cfg_FLOAT_MinMatchesForFinishRatioCheck
    /// </summary>
    public unsafe float Cfg_FLOAT_MinMatchesForFinishRatioCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }

    /// <summary>
    /// FloatProperty: Cfg_FLOAT_MinFinishRatio
    /// </summary>
    public unsafe float Cfg_FLOAT_MinFinishRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// FloatProperty: Cfg_FLOAT_MatchmakingSkillCalcCurveDelta
    /// </summary>
    public unsafe float Cfg_FLOAT_MatchmakingSkillCalcCurveDelta
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// FloatProperty: Cfg_FLOAT_MatchmakingSearchSkillIncreaseSpeed
    /// </summary>
    public unsafe float Cfg_FLOAT_MatchmakingSearchSkillIncreaseSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// FloatProperty: Cfg_FLOAT_MatchmakingSearchSkillIncreaseSpeedMax
    /// </summary>
    public unsafe float Cfg_FLOAT_MatchmakingSearchSkillIncreaseSpeedMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// FloatProperty: Cfg_FLOAT_MatchmakingSearchSkillIncreaseAccel
    /// </summary>
    public unsafe float Cfg_FLOAT_MatchmakingSearchSkillIncreaseAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// IntProperty: Cfg_INT_MatchmakingSearchNumTriesSameSkill
    /// </summary>
    public unsafe int Cfg_INT_MatchmakingSearchNumTriesSameSkill
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// FloatProperty: Cfg_FLOAT_MatchmakingSearchTimeoutSearch
    /// </summary>
    public unsafe float Cfg_FLOAT_MatchmakingSearchTimeoutSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// FloatProperty: Cfg_FLOAT_MatchmakingSearchTimeoutJoin
    /// </summary>
    public unsafe float Cfg_FLOAT_MatchmakingSearchTimeoutJoin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// FloatProperty: Cfg_FLOAT_MatchmakingSearchRequestThrottleTime
    /// </summary>
    public unsafe float Cfg_FLOAT_MatchmakingSearchRequestThrottleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// ObjectProperty: m_HistoricalData
    /// </summary>
    public unsafe BmSDK.BmGame.GDProfileSystemMatchmakingHistoricalData m_HistoricalData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDProfileSystemMatchmakingHistoricalData>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// FloatProperty: m_NumMatchesStarted
    /// </summary>
    public unsafe float m_NumMatchesStarted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// FloatProperty: m_NumMatchesFinished
    /// </summary>
    public unsafe float m_NumMatchesFinished
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// FloatProperty: m_NumMatchesWon
    /// </summary>
    public unsafe float m_NumMatchesWon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }
}
