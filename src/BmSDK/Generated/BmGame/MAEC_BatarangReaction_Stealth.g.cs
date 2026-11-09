#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MAEC_BatarangReaction_Stealth<br/>
/// (size = 600)
/// (flags = 8388626)
/// </summary>
public partial class MAEC_BatarangReaction_Stealth : BmSDK.BmGame.MAEC_BatarangReaction_Base, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MAEC_BatarangReaction_Stealth", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MAEC_BatarangReaction_Stealth.
    /// </summary>
    public static MAEC_BatarangReaction_Stealth DefaultObject => (MAEC_BatarangReaction_Stealth)StaticClass().DefaultObject;

    internal MAEC_BatarangReaction_Stealth() { }

    /// <summary>
    /// Constructs a new MAEC_BatarangReaction_Stealth
    /// </summary>
    public MAEC_BatarangReaction_Stealth(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MAEC_BatarangReaction_Stealth(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MAEC_BatarangReaction_Stealth>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MAEC_BatarangReaction_Stealth>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MAEC_BatarangReaction_Stealth>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MAEC_BatarangReaction_Stealth>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MAEC_BatarangReaction_Stealth>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MAEC_BatarangReaction_Stealth>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MAEC_BatarangReaction_Stealth>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MAEC_BatarangReaction_Stealth>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ClearTestRequests;
    /// <summary>
    /// Function: ClearTestRequests
    /// </summary>
    public unsafe virtual void ClearTestRequests()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearTestRequests, "BmGame.MAEC_BatarangReaction_Stealth.ClearTestRequests");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetRandomThugToSpeakIfNobodyIsRECed;
    /// <summary>
    /// Function: GetRandomThugToSpeakIfNobodyIsRECed
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMAIController GetRandomThugToSpeakIfNobodyIsRECed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRandomThugToSpeakIfNobodyIsRECed, "BmGame.MAEC_BatarangReaction_Stealth.GetRandomThugToSpeakIfNobodyIsRECed");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMAIController>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRandomThugToSpeak;
    /// <summary>
    /// Function: GetRandomThugToSpeak
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMAIController GetRandomThugToSpeak()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRandomThugToSpeak, "BmGame.MAEC_BatarangReaction_Stealth.GetRandomThugToSpeak");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMAIController>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ProcessThugSearch;
    /// <summary>
    /// Function: ProcessThugSearch
    /// </summary>
    public unsafe virtual bool ProcessThugSearch(BmSDK.TArray<BmSDK.BmGame.RMultiNavHandleWrapper> TargetThugSearch, bool bUncappedDist)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ProcessThugSearch, "BmGame.MAEC_BatarangReaction_Stealth.ProcessThugSearch");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetThugSearch, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUncappedDist, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_PawnCanSeeLastPoint;
    /// <summary>
    /// Function: PawnCanSeeLastPoint
    /// </summary>
    public unsafe virtual bool PawnCanSeeLastPoint(BmSDK.BmGame.RBMPawnAI TestPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnCanSeeLastPoint, "BmGame.MAEC_BatarangReaction_Stealth.PawnCanSeeLastPoint");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_InitThugSearch;
    /// <summary>
    /// Function: InitThugSearch
    /// </summary>
    public unsafe override void InitThugSearch()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitThugSearch, "BmGame.MAEC_BatarangReaction_Stealth.InitThugSearch");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartResponderSearch;
    /// <summary>
    /// Function: StartResponderSearch
    /// </summary>
    public unsafe virtual void StartResponderSearch()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartResponderSearch, "BmGame.MAEC_BatarangReaction_Stealth.StartResponderSearch");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AlarmRoom;
    /// <summary>
    /// Function: AlarmRoom
    /// </summary>
    public unsafe virtual void AlarmRoom()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AlarmRoom, "BmGame.MAEC_BatarangReaction_Stealth.AlarmRoom");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoJumpReaction;
    /// <summary>
    /// Function: DoJumpReaction
    /// </summary>
    public unsafe override void DoJumpReaction(System.Numerics.Vector3 HitLoc, System.Numerics.Vector3 ThrownFromPos, bool bThrownFromGarg, float JumpRange, int NewBRangID = default, bool bDueToBodyDrop = default, BmSDK.BmGame.RBMAIController BodyDodger = default, bool bTerrorShootStartle = default, bool bAwardRECScareMedal = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoJumpReaction, "BmGame.MAEC_BatarangReaction_Stealth.DoJumpReaction");
        byte* paramsPtr = stackalloc byte[124];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bThrownFromGarg, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JumpRange, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBRangID, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDueToBodyDrop, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BodyDodger, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTerrorShootStartle, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAwardRECScareMedal, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NoiseInspectionDone;
    /// <summary>
    /// Function: NoiseInspectionDone
    /// </summary>
    public unsafe override void NoiseInspectionDone()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NoiseInspectionDone, "BmGame.MAEC_BatarangReaction_Stealth.NoiseInspectionDone");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EstimateAimAtLocation;
    /// <summary>
    /// Function: EstimateAimAtLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 EstimateAimAtLocation(System.Numerics.Vector3 HitLoc, System.Numerics.Vector3 ThrownFromPos, bool FromGarg)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EstimateAimAtLocation, "BmGame.MAEC_BatarangReaction_Stealth.EstimateAimAtLocation");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FromGarg, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_HasThugsReacting;
    /// <summary>
    /// Function: HasThugsReacting
    /// </summary>
    public unsafe virtual bool HasThugsReacting()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasThugsReacting, "BmGame.MAEC_BatarangReaction_Stealth.HasThugsReacting");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ExitIntoAttack;
    /// <summary>
    /// Function: ExitIntoAttack
    /// </summary>
    public unsafe virtual void ExitIntoAttack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitIntoAttack, "BmGame.MAEC_BatarangReaction_Stealth.ExitIntoAttack");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugGotUpFromBatarang;
    /// <summary>
    /// Function: ThugGotUpFromBatarang
    /// </summary>
    public unsafe override void ThugGotUpFromBatarang(BmSDK.BmGame.RPawnVillain TestThug)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugGotUpFromBatarang, "BmGame.MAEC_BatarangReaction_Stealth.ThugGotUpFromBatarang");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestThug, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ManDownBodyDodge;
    /// <summary>
    /// Function: ManDownBodyDodge
    /// </summary>
    public unsafe override void ManDownBodyDodge(BmSDK.BmGame.RBMAIController Dodger, System.Numerics.Vector3 HitLoc, System.Numerics.Vector3 ThrownFromPos, bool bThrownFromGarg, int LaunchID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ManDownBodyDodge, "BmGame.MAEC_BatarangReaction_Stealth.ManDownBodyDodge");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dodger, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLoc, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bThrownFromGarg, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaunchID, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugHit;
    /// <summary>
    /// Function: ThugHit
    /// </summary>
    public unsafe override void ThugHit(BmSDK.BmGame.RBMPawnAI NewVictim, System.Numerics.Vector3 HitLoc, System.Numerics.Vector3 ThrownFromPos, bool bThrownFromGarg, BmSDK.BmGame.RBMAIController.BRAECReactionType Type, int NewLaunchID, bool bAwardRECScareMedal = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugHit, "BmGame.MAEC_BatarangReaction_Stealth.ThugHit");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewVictim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLoc, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bThrownFromGarg, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLaunchID, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAwardRECScareMedal, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MakeRicochetNoise;
    /// <summary>
    /// Function: MakeRicochetNoise
    /// </summary>
    public unsafe override void MakeRicochetNoise(System.Numerics.Vector3 HitLoc, System.Numerics.Vector3 ThrownFromPos, bool bThrownFromGarg, BmSDK.BmGame.RBMAIController.BRAECReactionType Type, int LaunchID, bool bTerrorShootStartle = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakeRicochetNoise, "BmGame.MAEC_BatarangReaction_Stealth.MakeRicochetNoise");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bThrownFromGarg, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaunchID, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTerrorShootStartle, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForThrowReaction;
    /// <summary>
    /// Function: CheckForThrowReaction
    /// </summary>
    public unsafe override void CheckForThrowReaction(System.Numerics.Vector3 ThrownFromPos, BmSDK.BmGame.RBMAIController.BRAECReactionType Type, int LaunchID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForThrowReaction, "BmGame.MAEC_BatarangReaction_Stealth.CheckForThrowReaction");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaunchID, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HandleHostageTakerReaction;
    /// <summary>
    /// Function: HandleHostageTakerReaction
    /// </summary>
    public unsafe virtual void HandleHostageTakerReaction(System.Numerics.Vector3 HitLoc, float JumpRange)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleHostageTakerReaction, "BmGame.MAEC_BatarangReaction_Stealth.HandleHostageTakerReaction");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JumpRange, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetParamsFromReactionType;
    /// <summary>
    /// Function: GetParamsFromReactionType
    /// </summary>
    public unsafe virtual bool GetParamsFromReactionType(BmSDK.BmGame.RBMAIController.BRAECReactionType TestType, out float JumpRange)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetParamsFromReactionType, "BmGame.MAEC_BatarangReaction_Stealth.GetParamsFromReactionType");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestType, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out JumpRange);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JumpRange, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        JumpRange = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ThugSawThrow;
    /// <summary>
    /// Function: ThugSawThrow
    /// </summary>
    public unsafe override bool ThugSawThrow(System.Numerics.Vector3 ThrownFromPos, int NewLaunchID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugSawThrow, "BmGame.MAEC_BatarangReaction_Stealth.ThugSawThrow");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLaunchID, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_UnregisterGuardAEC;
    /// <summary>
    /// Function: UnregisterGuardAEC
    /// </summary>
    public unsafe override void UnregisterGuardAEC(BmSDK.BmGame.RAEC_Search_Sub_Guard ExGuardAEC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnregisterGuardAEC, "BmGame.MAEC_BatarangReaction_Stealth.UnregisterGuardAEC");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExGuardAEC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterGuardAEC;
    /// <summary>
    /// Function: RegisterGuardAEC
    /// </summary>
    public unsafe override void RegisterGuardAEC(BmSDK.BmGame.RAEC_Search_Sub_Guard NewGuardAEC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterGuardAEC, "BmGame.MAEC_BatarangReaction_Stealth.RegisterGuardAEC");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGuardAEC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetThoughts;
    /// <summary>
    /// Function: GetThoughts
    /// </summary>
    public unsafe override void GetThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThoughts, "BmGame.MAEC_BatarangReaction_Stealth.GetThoughts");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.MAEC_BatarangReaction_Stealth.Tick");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PreStreamOut;
    /// <summary>
    /// Function: PreStreamOut
    /// </summary>
    public unsafe override void PreStreamOut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmGame.MAEC_BatarangReaction_Stealth.PreStreamOut");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PostBeginPlay;
    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.MAEC_BatarangReaction_Stealth.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// FloatProperty: BatarangReactPriority
    /// </summary>
    public unsafe float BatarangReactPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// FloatProperty: BatarangJumpRange
    /// </summary>
    public unsafe float BatarangJumpRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// FloatProperty: BrokenGlassJumpRange
    /// </summary>
    public unsafe float BrokenGlassJumpRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// FloatProperty: WatchRadius
    /// </summary>
    public unsafe float WatchRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// FloatProperty: BatarangSightDist
    /// </summary>
    public unsafe float BatarangSightDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// StructProperty: LastImpactPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastImpactPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 500);

    /// <summary>
    /// StructProperty: LastLaunchPointActual
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastLaunchPointActual
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 512);

    /// <summary>
    /// StructProperty: LastLaunchPointAiming
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastLaunchPointAiming
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 524);

    /// <summary>
    /// IntProperty: CurrentBRangID
    /// </summary>
    public unsafe int CurrentBRangID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// BoolProperty: bShockBatarang
    /// </summary>
    public unsafe bool bShockBatarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 540); }
    }

    /// <summary>
    /// BoolProperty: bPlayedWhereFromBark
    /// </summary>
    public unsafe bool bPlayedWhereFromBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 540); }
    }

    /// <summary>
    /// BoolProperty: bUrgentlyNeedMoreWatchers
    /// </summary>
    public unsafe bool bUrgentlyNeedMoreWatchers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 540); }
    }

    /// <summary>
    /// BoolProperty: mInitiateAPS
    /// </summary>
    public unsafe bool mInitiateAPS
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 540); }
    }

    /// <summary>
    /// BoolProperty: mPropagateAlarmOnHit
    /// </summary>
    public unsafe bool mPropagateAlarmOnHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 540); }
    }

    /// <summary>
    /// BoolProperty: mNoAttackAllow
    /// </summary>
    public unsafe bool mNoAttackAllow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 540); }
    }

    /// <summary>
    /// FloatProperty: DisperseTimer
    /// </summary>
    public unsafe float DisperseTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// FloatProperty: PostGetupTimer
    /// </summary>
    public unsafe float PostGetupTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// ObjectProperty: Victim
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI Victim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// FloatProperty: ReleaseTimer
    /// </summary>
    public unsafe float ReleaseTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// ObjectProperty: APS
    /// </summary>
    public unsafe BmSDK.BmGame.RAttackPointSearch APS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAttackPointSearch>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// ArrayProperty: ThugSearch
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RMultiNavHandleWrapper> ThugSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RMultiNavHandleWrapper>>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// ArrayProperty: ReserveThugSearch
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RMultiNavHandleWrapper> ReserveThugSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RMultiNavHandleWrapper>>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// ArrayProperty: ActiveGuards
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAEC_Search_Sub_Guard> ActiveGuards
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAEC_Search_Sub_Guard>>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }
}
