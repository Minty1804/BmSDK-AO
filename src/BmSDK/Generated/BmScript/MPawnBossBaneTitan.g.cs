#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MPawnBossBaneTitan<br/>
/// (size = 5408)
/// (flags = 10485814)
/// </summary>
public partial class MPawnBossBaneTitan : BmSDK.BmGame.MPawnBossBaneTitanBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MPawnBossBaneTitan", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MPawnBossBaneTitan.
    /// </summary>
    public static MPawnBossBaneTitan DefaultObject => (MPawnBossBaneTitan)StaticClass().DefaultObject;

    internal MPawnBossBaneTitan() { }

    /// <summary>
    /// Constructs a new MPawnBossBaneTitan
    /// </summary>
    public MPawnBossBaneTitan(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MPawnBossBaneTitan(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnBossBaneTitan>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnBossBaneTitan>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnBossBaneTitan>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnBossBaneTitan>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnBossBaneTitan>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnBossBaneTitan>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnBossBaneTitan>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnBossBaneTitan>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: NotifyBreakWallBark
    /// </summary>
    public unsafe virtual void NotifyBreakWallBark()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.NotifyBreakWallBark", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyFightEndBark
    /// </summary>
    public unsafe virtual void NotifyFightEndBark()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.NotifyFightEndBark", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyFakeDeathBark
    /// </summary>
    public unsafe virtual void NotifyFakeDeathBark()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.NotifyFakeDeathBark", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyFinaleFailBark
    /// </summary>
    public unsafe virtual void NotifyFinaleFailBark()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.NotifyFinaleFailBark", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyFinaleSuccessBark
    /// </summary>
    public unsafe virtual void NotifyFinaleSuccessBark()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.NotifyFinaleSuccessBark", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyTaunt04Bark
    /// </summary>
    public unsafe virtual void NotifyTaunt04Bark()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.NotifyTaunt04Bark", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyTaunt03Bark
    /// </summary>
    public unsafe virtual void NotifyTaunt03Bark()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.NotifyTaunt03Bark", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyTaunt02Bark
    /// </summary>
    public unsafe virtual void NotifyTaunt02Bark()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.NotifyTaunt02Bark", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifySprintTauntBark
    /// </summary>
    public unsafe virtual void NotifySprintTauntBark()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.NotifySprintTauntBark", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyLoseSightBersekBark
    /// </summary>
    public unsafe virtual void NotifyLoseSightBersekBark()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.NotifyLoseSightBersekBark", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyEnvTauntBark
    /// </summary>
    public unsafe virtual void NotifyEnvTauntBark()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.NotifyEnvTauntBark", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyElectrocutedBark
    /// </summary>
    public unsafe virtual void NotifyElectrocutedBark()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.NotifyElectrocutedBark", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyBeatdownEndBark
    /// </summary>
    public unsafe virtual void NotifyBeatdownEndBark()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.NotifyBeatdownEndBark", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyBmRideBnBark
    /// </summary>
    public unsafe virtual void NotifyBmRideBnBark()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.NotifyBmRideBnBark", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ApplyWallForce
    /// </summary>
    public unsafe override bool ApplyWallForce()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.ApplyWallForce", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: PlaySearchGrateBark
    /// </summary>
    public unsafe virtual void PlaySearchGrateBark()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.PlaySearchGrateBark", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateTitanFX
    /// </summary>
    public unsafe virtual void UpdateTitanFX()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.UpdateTitanFX", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayPrisonnerSpeech
    /// </summary>
    public unsafe virtual void PlayPrisonnerSpeech(BmSDK.BmScript.MPawnBossBaneTitan.ePrisonerDiagLine DiagLine)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.PlayPrisonnerSpeech", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DiagLine, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ToggleOffInvestigateModeWhenOutOfSmoke
    /// </summary>
    public unsafe virtual void ToggleOffInvestigateModeWhenOutOfSmoke()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.ToggleOffInvestigateModeWhenOutOfSmoke", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IgnoreDetectiveModeCamChange
    /// </summary>
    public unsafe override bool IgnoreDetectiveModeCamChange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.IgnoreDetectiveModeCamChange", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: DebugDrawVentRadius
    /// </summary>
    public unsafe override void DebugDrawVentRadius()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.DebugDrawVentRadius", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShouldTakedownPrompt
    /// </summary>
    public unsafe override bool ShouldTakedownPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.ShouldTakedownPrompt", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CheckNearTrap
    /// </summary>
    public unsafe virtual void CheckNearTrap()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.CheckNearTrap", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetCurrentTrapRotator
    /// </summary>
    public unsafe virtual BmSDK.Rotator GetCurrentTrapRotator(bool OppToTrap = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.GetCurrentTrapRotator", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OppToTrap, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetCurrentTrapLocator
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetCurrentTrapLocator()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.GetCurrentTrapLocator", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CheckBaneStuck
    /// </summary>
    public unsafe virtual void CheckBaneStuck(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.CheckBaneStuck", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyPlayerEnterVent
    /// </summary>
    public unsafe override void NotifyPlayerEnterVent(System.Numerics.Vector3 Position)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.NotifyPlayerEnterVent", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GroundImpact
    /// </summary>
    public unsafe virtual void GroundImpact()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.GroundImpact", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SafeHeightTrace
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor SafeHeightTrace(out System.Numerics.Vector3 HitLocation, out System.Numerics.Vector3 HitNormal, System.Numerics.Vector3 TraceEnd, System.Numerics.Vector3 TraceStart, bool bTraceActors, System.Numerics.Vector3 Extent, out BmSDK.Engine.Actor.FTraceHitInfo HitInfo, int ExtraTraceFlags)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.SafeHeightTrace", true);
        byte* paramsPtr = stackalloc byte[108];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceEnd, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceStart, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTraceActors, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraTraceFlags, paramsPtr + 100);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        HitLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        HitNormal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        HitInfo = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.FTraceHitInfo>(paramsPtr + 64);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 104);
    }

    /// <summary>
    /// Function: EnvironmentImpact
    /// </summary>
    public unsafe virtual void EnvironmentImpact()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.EnvironmentImpact", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetMeleeDamage
    /// </summary>
    public unsafe override int GetMeleeDamage()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.GetMeleeDamage", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: MaybeDoTransitionToShowdown
    /// </summary>
    public unsafe virtual void MaybeDoTransitionToShowdown()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.MaybeDoTransitionToShowdown", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CutToFakeDeath
    /// </summary>
    public unsafe virtual void CutToFakeDeath()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.CutToFakeDeath", true);
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ReturnNavSafePosition
    /// </summary>
    public unsafe override System.Numerics.Vector3 ReturnNavSafePosition(System.Numerics.Vector3 uncheckedPos, float SafeDist = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.ReturnNavSafePosition", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(uncheckedPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SafeDist, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetPOI
    /// </summary>
    public unsafe virtual BmSDK.BmScript.MBanePointOfInterest GetPOI(System.Numerics.Vector3 StartLocation, BmSDK.BmScript.MBanePointOfInterest.PointOfInterestType POIType, float fMaxDist = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.GetPOI", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(POIType, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fMaxDist, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MBanePointOfInterest>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: FindCorridorMiddle
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 FindCorridorMiddle(System.Numerics.Vector3 CorridorHeading, System.Numerics.Vector3 StartLocation = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.FindCorridorMiddle", true);
        byte* paramsPtr = stackalloc byte[116];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CorridorHeading, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: FindAndPlayOverridePlayerDeathAnim
    /// </summary>
    public unsafe override bool FindAndPlayOverridePlayerDeathAnim(BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.FindAndPlayOverridePlayerDeathAnim", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: FindFacingEndCorridor
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 FindFacingEndCorridor(out BmSDK.Engine.Actor BestEndCorridor, System.Numerics.Vector3 StartRotation, System.Numerics.Vector3 StartLocation, float fDiscardEndUnderDist, System.Numerics.Vector3 ClosestToPoint)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.FindFacingEndCorridor", true);
        byte* paramsPtr = stackalloc byte[152];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartRotation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDiscardEndUnderDist, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClosestToPoint, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BestEndCorridor = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 44);
    }

    /// <summary>
    /// Function: FindBestHeading
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 FindBestHeading(out BmSDK.Engine.Actor BestEndCorridor, System.Numerics.Vector3 StartLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.FindBestHeading", true);
        byte* paramsPtr = stackalloc byte[96];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BestEndCorridor = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: PairedAnimsSuccessfullyLoaded
    /// </summary>
    public unsafe override void PairedAnimsSuccessfullyLoaded()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.PairedAnimsSuccessfullyLoaded", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TurnAround
    /// </summary>
    public unsafe virtual void TurnAround()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.TurnAround", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetClampedTargetDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetClampedTargetDirection(System.Numerics.Vector3 Heading, System.Numerics.Vector3 TargetPos, float MaxYawDelta)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.GetClampedTargetDirection", true);
        byte* paramsPtr = stackalloc byte[80];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Heading, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxYawDelta, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: WallImpact
    /// </summary>
    public unsafe virtual void WallImpact()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.WallImpact", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopCamera
    /// </summary>
    public unsafe virtual void StopCamera(float BlendOutTime = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.StopCamera", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendOutTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InterruptCamera
    /// </summary>
    public unsafe virtual void InterruptCamera()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.InterruptCamera", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayCamera
    /// </summary>
    public unsafe virtual void PlayCamera(BmSDK.FName CamAnimName, System.Numerics.Vector3 CamLocation, BmSDK.Rotator camRotation, float CanCutAfterCameraTime = default, float BlendInTime = default, float FOV = default, float fStartTime = default, bool bMirrored = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.PlayCamera", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CamAnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CamLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(camRotation, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CanCutAfterCameraTime, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendInTime, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FOV, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fStartTime, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMirrored, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoesCameraMaintainLos
    /// </summary>
    public unsafe virtual bool DoesCameraMaintainLos(BmSDK.BmGame.RInGameCinematicCam CinematicCamera, out float CameraTimeNormalised)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.DoesCameraMaintainLos", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CinematicCamera, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CameraTimeNormalised = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetCameraTarget
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetCameraTarget(BmSDK.BmGame.RPawn Pawn, bool CheckEyes)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.GetCameraTarget", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckEyes, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: CanCameraSeePoint
    /// </summary>
    public unsafe virtual bool CanCameraSeePoint(BmSDK.BmGame.RInGameCinematicCam CinematicCamera, float CameraTimeNormalised, System.Numerics.Vector3 CameraCheckTarget, BmSDK.Engine.Actor IgnoreThisActor, BmSDK.Engine.Actor IgnoreThisActorToo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.CanCameraSeePoint", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CinematicCamera, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraTimeNormalised, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraCheckTarget, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IgnoreThisActor, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IgnoreThisActorToo, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: TriggerShowdownBreakWall
    /// </summary>
    public unsafe override void TriggerShowdownBreakWall()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.TriggerShowdownBreakWall", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerShowdownThrow
    /// </summary>
    public unsafe override void TriggerShowdownThrow()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.TriggerShowdownThrow", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerShowdownVoiceOver
    /// </summary>
    public unsafe override void TriggerShowdownVoiceOver()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.TriggerShowdownVoiceOver", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerShowdownStart
    /// </summary>
    public unsafe override void TriggerShowdownStart()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.TriggerShowdownStart", true);
        byte* paramsPtr = stackalloc byte[112];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopLookLeftToRightQueued
    /// </summary>
    public unsafe virtual void StopLookLeftToRightQueued(BmSDK.BmGame.RAnimUtil.FTransitionId tID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.StopLookLeftToRightQueued", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(tID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: LookBothSides
    /// </summary>
    public unsafe virtual void LookBothSides()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.LookBothSides", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopLookRight
    /// </summary>
    public unsafe virtual void StopLookRight(BmSDK.BmGame.RAnimUtil.FTransitionId tID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.StopLookRight", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(tID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: LookRight
    /// </summary>
    public unsafe virtual void LookRight(bool bForce = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.LookRight", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForce, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopLookLeft
    /// </summary>
    public unsafe virtual void StopLookLeft(BmSDK.BmGame.RAnimUtil.FTransitionId tID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.StopLookLeft", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(tID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: LookLeft
    /// </summary>
    public unsafe virtual void LookLeft(bool bForce = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.LookLeft", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForce, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateAwareness
    /// </summary>
    public unsafe override void UpdateAwareness()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.UpdateAwareness", true);
        byte* paramsPtr = stackalloc byte[41];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TurnOffFallingDust
    /// </summary>
    public unsafe virtual void TurnOffFallingDust()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.TurnOffFallingDust", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayTaunt
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FTransitionId PlayTaunt(BmSDK.FName TauntName, System.Numerics.Vector3 Heading = default, BmSDK.FName CustomIdleName = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.PlayTaunt", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TauntName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Heading, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdleName, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: PlayBatmanHideHintBark
    /// </summary>
    public unsafe virtual void PlayBatmanHideHintBark()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.PlayBatmanHideHintBark", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayRandomTaunt
    /// </summary>
    public unsafe virtual void PlayRandomTaunt(System.Numerics.Vector3 Heading = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.PlayRandomTaunt", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Heading, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayRandomLookAnim
    /// </summary>
    public unsafe virtual void PlayRandomLookAnim()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.PlayRandomLookAnim", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AlertToBrokenGlassSound
    /// </summary>
    public unsafe override void AlertToBrokenGlassSound(System.Numerics.Vector3 BreakageLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.AlertToBrokenGlassSound", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BreakageLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnSpecialAttack
    /// </summary>
    public unsafe override bool SpawnSpecialAttack(BmSDK.BmGame.RPawnCombat thePlayer, BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.SpawnSpecialAttack", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(thePlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: BeginTakeDown
    /// </summary>
    public unsafe virtual void BeginTakeDown()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.BeginTakeDown", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BeginTrapTakedown
    /// </summary>
    public unsafe override void BeginTrapTakedown()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.BeginTrapTakedown", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsBoss
    /// </summary>
    public unsafe override bool IsBoss()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.IsBoss", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: DisableTrap
    /// </summary>
    public unsafe virtual void DisableTrap()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.DisableTrap", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayerHitByObject
    /// </summary>
    public unsafe override void PlayerHitByObject()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.PlayerHitByObject", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NavigationCanDoHighJump
    /// </summary>
    public unsafe override bool NavigationCanDoHighJump()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.NavigationCanDoHighJump", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: NavigationCanDoTraversal
    /// </summary>
    public unsafe override bool NavigationCanDoTraversal()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.NavigationCanDoTraversal", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsVulnerableToTakedown
    /// </summary>
    public unsafe override bool IsVulnerableToTakedown(BmSDK.FString takedown)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.IsVulnerableToTakedown", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takedown, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: ForceDisarm
    /// </summary>
    public unsafe override void ForceDisarm()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.ForceDisarm", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Disarm
    /// </summary>
    public unsafe override void Disarm()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.Disarm", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanBeHitInCombat
    /// </summary>
    public unsafe override bool CanBeHitInCombat(BmSDK.BmGame.RDamageType DamageType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.CanBeHitInCombat", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: CanBatmanGrab
    /// </summary>
    public unsafe override BmSDK.BmGame.RBMAIController.BatmanGrabType CanBatmanGrab()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.CanBatmanGrab", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIController.BatmanGrabType>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SuspendBehaviour
    /// </summary>
    public unsafe virtual void SuspendBehaviour(bool OnlyIfNoVisualContact = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.SuspendBehaviour", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnlyIfNoVisualContact, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AlertToGadgetNoise
    /// </summary>
    public unsafe override void AlertToGadgetNoise()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.AlertToGadgetNoise", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShortPauseThenAlertToGadgetNoise
    /// </summary>
    public unsafe override void ShortPauseThenAlertToGadgetNoise()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.ShortPauseThenAlertToGadgetNoise", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DamageCollisionWith
    /// </summary>
    public unsafe override void DamageCollisionWith(BmSDK.BmGame.RPawnCombat OtherPawn, System.Numerics.Vector3 DamageDir = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.DamageCollisionWith", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageDir, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopInvestigateTrap
    /// </summary>
    public unsafe virtual void StopInvestigateTrap()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.StopInvestigateTrap", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InvestigateTrap
    /// </summary>
    public unsafe virtual void InvestigateTrap()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.InvestigateTrap", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Bump
    /// </summary>
    public unsafe override void Bump(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.Bump", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanSeeBatman
    /// </summary>
    public unsafe override bool CanSeeBatman(float minimum_proportion, bool ignore_view_wedge = default, bool ignore_slow_spot_timer = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.CanSeeBatman", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(minimum_proportion, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ignore_view_wedge, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ignore_slow_spot_timer, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: LaunchVentAttack
    /// </summary>
    public unsafe virtual void LaunchVentAttack(bool bAgressiveAttack)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.LaunchVentAttack", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAgressiveAttack, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: LaunchGrateAttack
    /// </summary>
    public unsafe virtual void LaunchGrateAttack()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.LaunchGrateAttack", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayBossBark
    /// </summary>
    public unsafe override void PlayBossBark(BmSDK.Engine.RDialogueLine DialogueLine, BmSDK.BmGame.RGameInfo.VocalPriority Priority = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.PlayBossBark", true);
        byte* paramsPtr = stackalloc byte[5];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueLine, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlaySpeechInternal
    /// </summary>
    public unsafe override void PlaySpeechInternal(BmSDK.Engine.RDialogueLine DialogueLine, BmSDK.BmGame.RGameInfo.VocalPriority Priority = default, BmSDK.Engine.SequenceAction PlaySpeechAction = default, bool bPlayEarcon = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.PlaySpeechInternal", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueLine, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlaySpeechAction, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayEarcon, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RefreshLastKnownPosition
    /// </summary>
    public unsafe override void RefreshLastKnownPosition()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.RefreshLastKnownPosition", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetBehaviour
    /// </summary>
    public unsafe virtual BmSDK.BmScript.MBMBehaviour_BossBaneTitan GetBehaviour()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.GetBehaviour", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MBMBehaviour_BossBaneTitan>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: FootStep
    /// </summary>
    public unsafe virtual void FootStep()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.FootStep", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MaybePlayGrateDestroySoundWithFX
    /// </summary>
    public unsafe virtual void MaybePlayGrateDestroySoundWithFX()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.MaybePlayGrateDestroySoundWithFX", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MaybePlayGrateDestroySound
    /// </summary>
    public unsafe virtual void MaybePlayGrateDestroySound()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.MaybePlayGrateDestroySound", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EnableHeadCollision
    /// </summary>
    public unsafe virtual void EnableHeadCollision()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.EnableHeadCollision", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DestroyObject
    /// </summary>
    public unsafe virtual void DestroyObject()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.DestroyObject", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SmashObject
    /// </summary>
    public unsafe virtual void SmashObject()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.SmashObject", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartShockLight
    /// </summary>
    public unsafe virtual void StartShockLight()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.StartShockLight", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ElectricityMaterialStart
    /// </summary>
    public unsafe virtual void ElectricityMaterialStart()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.ElectricityMaterialStart", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ElectricityMaterialStop
    /// </summary>
    public unsafe virtual void ElectricityMaterialStop()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.ElectricityMaterialStop", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShouldBeInCombatStance
    /// </summary>
    public unsafe override bool ShouldBeInCombatStance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.ShouldBeInCombatStance", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: DestroyGrate
    /// </summary>
    public unsafe virtual void DestroyGrate()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.DestroyGrate", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DeactivateCollision
    /// </summary>
    public unsafe virtual void DeactivateCollision()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.DeactivateCollision", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ActivateCollisionRight
    /// </summary>
    public unsafe virtual void ActivateCollisionRight()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.ActivateCollisionRight", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ActivateCollisionLeft
    /// </summary>
    public unsafe virtual void ActivateCollisionLeft()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.ActivateCollisionLeft", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ActivateCollisionGeneric
    /// </summary>
    public unsafe virtual void ActivateCollisionGeneric(bool bRightHand, float fRadius = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.ActivateCollisionGeneric", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRightHand, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fRadius, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CreateBatmansBossWeaponConfig
    /// </summary>
    public unsafe override void CreateBatmansBossWeaponConfig(BmSDK.BmGame.RPawnPlayerCombat thePlayer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.CreateBatmansBossWeaponConfig", true);
        byte* paramsPtr = stackalloc byte[2944];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(thePlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CreateHitReactionWeaponConfig
    /// </summary>
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateHitReactionWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.FName CombatMovementStance, BmSDK.Engine.AnimSet AnimSet1, BmSDK.Engine.AnimSet AnimSet2 = default, BmSDK.Engine.AnimSet AnimSet3 = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.CreateHitReactionWeaponConfig", true);
        byte* paramsPtr = stackalloc byte[1260];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatMovementStance, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet2, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet3, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: CreateWeaponConfigUnarmed
    /// </summary>
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateWeaponConfigUnarmed(BmSDK.GameObject NewOwner)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.CreateWeaponConfigUnarmed", true);
        byte* paramsPtr = stackalloc byte[8436];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: KickedByBatman
    /// </summary>
    public unsafe override void KickedByBatman(System.Numerics.Vector3 batman_origin)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.KickedByBatman", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(batman_origin, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopFlashingAttackingFX
    /// </summary>
    public unsafe virtual void StopFlashingAttackingFX()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.StopFlashingAttackingFX", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartFlashingAttackingFX
    /// </summary>
    public unsafe virtual void StartFlashingAttackingFX()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.StartFlashingAttackingFX", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnMove
    /// </summary>
    public unsafe override void SpawnMove(BmSDK.Class MoveClass)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.SpawnMove", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShouldGoRagdoll
    /// </summary>
    public unsafe override bool ShouldGoRagdoll(BmSDK.Class dmgType, float DamageAmount)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.ShouldGoRagdoll", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetTauntStance
    /// </summary>
    public unsafe override BmSDK.FName GetTauntStance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.GetTauntStance", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetCombatWeaponStance
    /// </summary>
    public unsafe override BmSDK.FName GetCombatWeaponStance(bool bWeaponWillBeDropped)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.GetCombatWeaponStance", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWeaponWillBeDropped, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetCombatStance
    /// </summary>
    public unsafe override BmSDK.FName GetCombatStance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.GetCombatStance", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsVulnerableToPawn
    /// </summary>
    public unsafe override bool IsVulnerableToPawn(BmSDK.BmGame.RPawnCombat Attacker)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.IsVulnerableToPawn", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetTargetPriority
    /// </summary>
    public unsafe override float GetTargetPriority(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.GetTargetPriority", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: SpawnBatclawCounter
    /// </summary>
    public unsafe override void SpawnBatclawCounter()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.SpawnBatclawCounter", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckDodgeProjectile
    /// </summary>
    public unsafe override bool CheckDodgeProjectile(BmSDK.BmGame.RPawn Thrower, BmSDK.FName TargetBone, System.Numerics.Vector3 ProjPos, int BatarangID, bool bForceDodge = default, bool bSteerableProj = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.CheckDodgeProjectile", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thrower, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBone, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProjPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatarangID, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceDodge, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSteerableProj, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: NotifyHarpoonHit
    /// </summary>
    public unsafe override void NotifyHarpoonHit()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.NotifyHarpoonHit", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OverrideHarpoonHit
    /// </summary>
    public unsafe override bool OverrideHarpoonHit(BmSDK.BmGame.RPawnPlayer thePlayer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.OverrideHarpoonHit", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(thePlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetBlockGadgetAnim
    /// </summary>
    public unsafe virtual void GetBlockGadgetAnim(out BmSDK.FName AnimName, out BmSDK.Engine.AnimSet AnimPackage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.GetBlockGadgetAnim", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AnimName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
        AnimPackage = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 8);
        return;
    }

    /// <summary>
    /// Function: SpawnBlockAttack
    /// </summary>
    public unsafe virtual void SpawnBlockAttack(BmSDK.BmGame.RPawnCombat NewAttacker)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.SpawnBlockAttack", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyBlockProjectile
    /// </summary>
    public unsafe virtual void NotifyBlockProjectile(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class dmgType = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.NotifyBlockProjectile", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BlockAttack
    /// </summary>
    public unsafe override void BlockAttack(BmSDK.BmGame.RPawnCombat NewAttacker, BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.BlockAttack", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanBlockDamageType
    /// </summary>
    public unsafe override bool CanBlockDamageType(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.CanBlockDamageType", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: ShouldStartFinalBlowCam
    /// </summary>
    public unsafe override bool ShouldStartFinalBlowCam(float StrikeDamageAmount)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.ShouldStartFinalBlowCam", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeDamageAmount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: CanBlock
    /// </summary>
    public unsafe override bool CanBlock()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.CanBlock", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: TakeDamage
    /// </summary>
    public unsafe override void TakeDamage(int Damage, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.TakeDamage", true);
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 72);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DamagedBy
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult DamagedBy(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.DamagedBy", true);
        byte* paramsPtr = stackalloc byte[258];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 256);
    }

    /// <summary>
    /// Function: ShouldDrawHelpPrompt
    /// </summary>
    public unsafe override bool ShouldDrawHelpPrompt(out BmSDK.FString Text, out BmSDK.BmGame.RHUDPrompt.EControlIcon Icon)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.ShouldDrawHelpPrompt", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Text = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
        Icon = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHUDPrompt.EControlIcon>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: CanTakeSlideAttack
    /// </summary>
    public unsafe override bool CanTakeSlideAttack()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.CanTakeSlideAttack", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanBeTargettedByPlayer
    /// </summary>
    public unsafe override bool CanBeTargettedByPlayer(BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.CanBeTargettedByPlayer", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: LaunchSmokeAttack
    /// </summary>
    public unsafe virtual void LaunchSmokeAttack()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.LaunchSmokeAttack", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckInSmoke
    /// </summary>
    public unsafe virtual void CheckInSmoke()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.CheckInSmoke", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetOverrideGlideKick
    /// </summary>
    public unsafe override BmSDK.BmGame.RSpecialMoveConfig GetOverrideGlideKick(BmSDK.BmGame.RPawnPlayer ThePlayerPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.GetOverrideGlideKick", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThePlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: TriggerGlideKick
    /// </summary>
    public unsafe override void TriggerGlideKick(System.Numerics.Vector3 PlayerOrigin)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.TriggerGlideKick", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerOrigin, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnVisibleFootprint
    /// </summary>
    public unsafe override BmSDK.BmGame.MBaneTitanPlaceableFootprintBase SpawnVisibleFootprint(System.Numerics.Vector3 PrintLocation, BmSDK.Rotator PrintRotation, int creation_index)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.SpawnVisibleFootprint", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PrintLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PrintRotation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(creation_index, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MBaneTitanPlaceableFootprintBase>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.Destroyed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Died
    /// </summary>
    public unsafe override bool Died(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.Died", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: GetBeatdownPunches
    /// </summary>
    public unsafe virtual int GetBeatdownPunches()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.GetBeatdownPunches", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetBatarangPriority
    /// </summary>
    public unsafe override float GetBatarangPriority()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.GetBatarangPriority", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CloseHUD
    /// </summary>
    public unsafe virtual void CloseHUD()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.CloseHUD", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateHealthBar
    /// </summary>
    public unsafe override void UpdateHealthBar()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.UpdateHealthBar", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateWasOnScreen
    /// </summary>
    public unsafe virtual void UpdateWasOnScreen(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.UpdateWasOnScreen", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: LostVisualContact
    /// </summary>
    public unsafe override void LostVisualContact()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.LostVisualContact", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GainedVisualContact
    /// </summary>
    public unsafe override void GainedVisualContact()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.GainedVisualContact", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateBossBarks
    /// </summary>
    public unsafe virtual void UpdateBossBarks()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.UpdateBossBarks", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DebugMiddleLoc
    /// </summary>
    public unsafe virtual void DebugMiddleLoc()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.DebugMiddleLoc", true);
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.Tick", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShakeHealthBar
    /// </summary>
    public unsafe virtual void ShakeHealthBar()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.ShakeHealthBar", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InitHUD
    /// </summary>
    public unsafe virtual void InitHUD()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.InitHUD", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayerLookAtBane
    /// </summary>
    public unsafe virtual void PlayerLookAtBane()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.PlayerLookAtBane", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostInitCharacter
    /// </summary>
    public unsafe override void PostInitCharacter()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.PostInitCharacter", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DisableCombatAutoAimAt
    /// </summary>
    public unsafe virtual void DisableCombatAutoAimAt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.DisableCombatAutoAimAt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MPawnBossBaneTitan.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: eHelpPromptIcon
    /// </summary>
    public enum eHelpPromptIcon : byte
    {
        HelpPromptIcon_None = 0,
        HelpPromptIcon_Evade = 1,
        HelpPromptIcon_Max = 2,
    }

    /// <summary>
    /// Enum: BaneEscalationStage
    /// </summary>
    public enum BaneEscalationStage : byte
    {
        EscalationStage1 = 0,
        EscalationStage2 = 1,
        EscalationStage3 = 2,
        EscalationStage_MAX = 3,
        BaneEscalationStage_MAX = 4,
    }

    /// <summary>
    /// Enum: ePrisonerDiagLine
    /// </summary>
    public enum ePrisonerDiagLine : byte
    {
        ePrisonerDiagLine_BaneThrow = 0,
        ePrisonerDiagLine_BMHides = 1,
        ePrisonerDiagLine_Generic = 2,
        ePrisonerDiagLine_Max = 3,
    }

    /// <summary>
    /// Enum: BaneTrapID
    /// </summary>
    public enum BaneTrapID : byte
    {
        BaneTrapID_WaterTrap_1 = 0,
        BaneTrapID_ElectricityMachine_2 = 1,
        BaneTrapID_ElectricFence_3 = 2,
        BaneTrapID_ElectricArches_4 = 3,
        BaneTrapID_SpotLight_5 = 4,
        BaneTrapID_Num = 5,
        BaneTrapID_MAX = 6,
    }

    /// <summary>
    /// Enum: ObstacleAwareness
    /// </summary>
    public enum ObstacleAwareness : byte
    {
        ObstacleAwareness_None = 0,
        ObstacleAwareness_Left = 1,
        ObstacleAwareness_Right = 2,
        ObstacleAwareness_Both = 3,
        ObstacleAwareness_Down = 4,
        ObstacleAwareness_Up = 5,
        ObstacleAwareness_Num = 6,
        ObstacleAwareness_MAX = 7,
    }

    /// <summary>
    /// Enum: BaneAwareness
    /// </summary>
    public enum BaneAwareness : byte
    {
        BaneAwareness_None = 0,
        BaneAwareness_Left = 1,
        BaneAwareness_Right = 2,
        BaneAwareness_Up = 3,
        BaneAwareness_Down = 4,
        BaneAwareness_Num = 5,
        BaneAwareness_MAX = 6,
    }

    /// <summary>
    /// BoolProperty: bAttackingFXActive
    /// </summary>
    public unsafe bool bAttackingFXActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4620); }
    }

    /// <summary>
    /// BoolProperty: bBlockGadgetFirstTime
    /// </summary>
    public unsafe bool bBlockGadgetFirstTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4620); }
    }

    /// <summary>
    /// BoolProperty: bValidCamera
    /// </summary>
    public unsafe bool bValidCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4620); }
    }

    /// <summary>
    /// BoolProperty: bDisplayDebugCamera
    /// </summary>
    public unsafe bool bDisplayDebugCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4620); }
    }

    /// <summary>
    /// BoolProperty: bCanDoHighJump
    /// </summary>
    public unsafe bool bCanDoHighJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4620); }
    }

    /// <summary>
    /// BoolProperty: bChargeOvershoot
    /// </summary>
    public unsafe bool bChargeOvershoot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4620); }
    }

    /// <summary>
    /// BoolProperty: bCharging
    /// </summary>
    public unsafe bool bCharging
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4620); }
    }

    /// <summary>
    /// BoolProperty: bForceChargeAttack
    /// </summary>
    public unsafe bool bForceChargeAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4620); }
    }

    /// <summary>
    /// BoolProperty: SlowRideIn
    /// </summary>
    public unsafe bool SlowRideIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4620); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysSeePlayer
    /// </summary>
    public unsafe bool bAlwaysSeePlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4620); }
    }

    /// <summary>
    /// BoolProperty: bGlueBarkPlayed
    /// </summary>
    public unsafe bool bGlueBarkPlayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4620); }
    }

    /// <summary>
    /// BoolProperty: bTrapHintPlayed
    /// </summary>
    public unsafe bool bTrapHintPlayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4620); }
    }

    /// <summary>
    /// BoolProperty: bSeenBMEnterGratePlayed
    /// </summary>
    public unsafe bool bSeenBMEnterGratePlayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4620); }
    }

    /// <summary>
    /// BoolProperty: bSeenBMEnterVentPlayed
    /// </summary>
    public unsafe bool bSeenBMEnterVentPlayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4620); }
    }

    /// <summary>
    /// BoolProperty: bShowDownStarted
    /// </summary>
    public unsafe bool bShowDownStarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4620); }
    }

    /// <summary>
    /// BoolProperty: bNeedToChargeNoise
    /// </summary>
    public unsafe bool bNeedToChargeNoise
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4620); }
    }

    /// <summary>
    /// BoolProperty: bNeedToChargePOI
    /// </summary>
    public unsafe bool bNeedToChargePOI
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4620); }
    }

    /// <summary>
    /// BoolProperty: DoSmokeEscape
    /// </summary>
    public unsafe bool DoSmokeEscape
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4620); }
    }

    /// <summary>
    /// BoolProperty: bTriedToUnstuck
    /// </summary>
    public unsafe bool bTriedToUnstuck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4620); }
    }

    /// <summary>
    /// BoolProperty: bWasInCombatStance
    /// </summary>
    public unsafe bool bWasInCombatStance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4620); }
    }

    /// <summary>
    /// BoolProperty: bOneHitKill
    /// </summary>
    public unsafe bool bOneHitKill
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4620); }
    }

    /// <summary>
    /// ObjectProperty: PlayerPairedAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerPairedAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4624); }
    }

    /// <summary>
    /// ObjectProperty: BossPairedAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BossPairedAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4628); }
    }

    /// <summary>
    /// ObjectProperty: CameraPairedAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CameraPairedAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4632); }
    }

    /// <summary>
    /// ObjectProperty: PlayerRideAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerRideAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4636); }
    }

    /// <summary>
    /// ObjectProperty: BossRideAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BossRideAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4640); }
    }

    /// <summary>
    /// ObjectProperty: GlideKickElectricTakedown
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GlideKickElectricTakedown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 4644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4644); }
    }

    /// <summary>
    /// StructProperty: FootStepScreenShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct FootStepScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 4648);

    /// <summary>
    /// ObjectProperty: BMRidingAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BMRidingAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4792); }
    }

    /// <summary>
    /// ObjectProperty: RidingAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet RidingAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4796); }
    }

    /// <summary>
    /// ObjectProperty: CurrentTrap
    /// </summary>
    public unsafe BmSDK.BmScript.MBaneTitanSmashIntoObject CurrentTrap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MBaneTitanSmashIntoObject>(Ptr + 4800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4800); }
    }

    /// <summary>
    /// FloatProperty: LastTimeOnScreen
    /// </summary>
    public unsafe float LastTimeOnScreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4804); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Aldred_FightStartTN1Warn
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Aldred_FightStartTN1Warn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4808); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Aldred_Hint
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Aldred_Hint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4812); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Aldred_TimesRunningOut1
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Aldred_TimesRunningOut1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4816); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Aldred_TimesRunningOut2
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Aldred_TimesRunningOut2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4820); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Aldred_TimesRunningOut3
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Aldred_TimesRunningOut3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4824); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Aldred_TimesRunningOut4
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Aldred_TimesRunningOut4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4828); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Aldred_TimesRunningOut5
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Aldred_TimesRunningOut5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4832); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Aldred_TimesUp
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Aldred_TimesUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4836); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_B3_AfterBeatdown
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_B3_AfterBeatdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4840); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_B3_AttacksBM
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_B3_AttacksBM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4844); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_B3_BMHidden
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_B3_BMHidden
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4848); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_B3_BMRiding
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_B3_BMRiding
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4852); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_B3_FinalTaunt
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_B3_FinalTaunt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4856); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_B3_Glued
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_B3_Glued
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4860); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_B3_GrateBreak
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_B3_GrateBreak
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4864); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_B3_NoiseHeard
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_B3_NoiseHeard
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4868); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_B3_NoticeBehind
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_B3_NoticeBehind
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4872); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_B3_NoticeBehindNoBM
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_B3_NoticeBehindNoBM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4876); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_B3_NoticeBehindSeeBM
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_B3_NoticeBehindSeeBM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4880); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_B3_SearchGrate
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_B3_SearchGrate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4884); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_B3_SearchVent
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_B3_SearchVent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4888); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_B3_SeeBMEnterGrate
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_B3_SeeBMEnterGrate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4892); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_B3_SeeBMEnterVent
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_B3_SeeBMEnterVent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4896); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_B3_SmokeClear
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_B3_SmokeClear
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4900); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_B3_SpotBM
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_B3_SpotBM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4904); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_B3_VentBreak
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_B3_VentBreak
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4908); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_B3_VentGrabBM
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_B3_VentGrabBM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4912); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_B3_VentGrabBMFail
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_B3_VentGrabBMFail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4916); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Batman_AlfredHint
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Batman_AlfredHint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4920); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Batman_HideHint
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Batman_HideHint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4924); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Batman_Hint1
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Batman_Hint1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4928); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Batman_Hint2
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Batman_Hint2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4932); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Batman_Hint3
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Batman_Hint3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4936); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Batman_Hint4
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Batman_Hint4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4940); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Batman_JammerHint
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Batman_JammerHint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4944); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Batman_RideBaneHint
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Batman_RideBaneHint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4948); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: BossBarks_Bane3_Prisoner_BaneThrow
    /// </summary>
    public InlineArray<BmSDK.Engine.RDialogueLine> BossBarks_Bane3_Prisoner_BaneThrow => new(5, Ptr + 4952, 4, this);

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Prisoner_BaneThrow
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Prisoner_BaneThrow_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4952); }
    }
    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Prisoner_BaneThrow
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Prisoner_BaneThrow_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4956); }
    }
    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Prisoner_BaneThrow
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Prisoner_BaneThrow_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4960); }
    }
    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Prisoner_BaneThrow
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Prisoner_BaneThrow_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4964); }
    }
    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Prisoner_BaneThrow
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Prisoner_BaneThrow_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4968); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: BossBarks_Bane3_Prisoner_BMHides
    /// </summary>
    public InlineArray<BmSDK.Engine.RDialogueLine> BossBarks_Bane3_Prisoner_BMHides => new(5, Ptr + 4972, 4, this);

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Prisoner_BMHides
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Prisoner_BMHides_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4972); }
    }
    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Prisoner_BMHides
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Prisoner_BMHides_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4976); }
    }
    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Prisoner_BMHides
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Prisoner_BMHides_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4980); }
    }
    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Prisoner_BMHides
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Prisoner_BMHides_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4984); }
    }
    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Prisoner_BMHides
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Prisoner_BMHides_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4988); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: BossBarks_Bane3_Prisoner_GenericV1
    /// </summary>
    public InlineArray<BmSDK.Engine.RDialogueLine> BossBarks_Bane3_Prisoner_GenericV1 => new(5, Ptr + 4992, 4, this);

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Prisoner_GenericV1
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Prisoner_GenericV1_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4992); }
    }
    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Prisoner_GenericV1
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Prisoner_GenericV1_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4996); }
    }
    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Prisoner_GenericV1
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Prisoner_GenericV1_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 5000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5000); }
    }
    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Prisoner_GenericV1
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Prisoner_GenericV1_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 5004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5004); }
    }
    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Prisoner_GenericV1
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Prisoner_GenericV1_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 5008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5008); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: BossBarks_Bane3_Prisoner_GenericV2
    /// </summary>
    public InlineArray<BmSDK.Engine.RDialogueLine> BossBarks_Bane3_Prisoner_GenericV2 => new(5, Ptr + 5012, 4, this);

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Prisoner_GenericV2
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Prisoner_GenericV2_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 5012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5012); }
    }
    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Prisoner_GenericV2
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Prisoner_GenericV2_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 5016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5016); }
    }
    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Prisoner_GenericV2
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Prisoner_GenericV2_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 5020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5020); }
    }
    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Prisoner_GenericV2
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Prisoner_GenericV2_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 5024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5024); }
    }
    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Prisoner_GenericV2
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Prisoner_GenericV2_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 5028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5028); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: BossBarks_Bane3_Prisoner_GenericV3
    /// </summary>
    public InlineArray<BmSDK.Engine.RDialogueLine> BossBarks_Bane3_Prisoner_GenericV3 => new(5, Ptr + 5032, 4, this);

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Prisoner_GenericV3
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Prisoner_GenericV3_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 5032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5032); }
    }
    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Prisoner_GenericV3
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Prisoner_GenericV3_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 5036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5036); }
    }
    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Prisoner_GenericV3
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Prisoner_GenericV3_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 5040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5040); }
    }
    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Prisoner_GenericV3
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Prisoner_GenericV3_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 5044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5044); }
    }
    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Prisoner_GenericV3
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Prisoner_GenericV3_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 5048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5048); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_MountedbyBM
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_MountedbyBM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 5052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5052); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Beatdown_End
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Beatdown_End
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 5056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5056); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Electrocuted
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Electrocuted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 5060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5060); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Environmental_Taunt
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Environmental_Taunt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 5064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5064); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Lose_Sight_Berserk
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Lose_Sight_Berserk
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 5068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5068); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Sprint_Taunt
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Sprint_Taunt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 5072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5072); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Taunt_02
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Taunt_02
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 5076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5076); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Taunt_03
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Taunt_03
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 5080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5080); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_Taunt_04
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_Taunt_04
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 5084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5084); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_FightEnd2
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_FightEnd2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 5088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5088); }
    }

    /// <summary>
    /// ObjectProperty: BossBarks_Bane3_FightEnd1
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine BossBarks_Bane3_FightEnd1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 5092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5092); }
    }

    /// <summary>
    /// FloatProperty: LastCombatTime
    /// </summary>
    public unsafe float LastCombatTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5096); }
    }

    /// <summary>
    /// FloatProperty: LastPrisonerTauntTime
    /// </summary>
    public unsafe float LastPrisonerTauntTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5100); }
    }

    /// <summary>
    /// IntProperty: RandomLookAnimIdx
    /// </summary>
    public unsafe int RandomLookAnimIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5104); }
    }

    /// <summary>
    /// ArrayProperty: RandomLookAnim
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> RandomLookAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 5108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5108); }
    }

    /// <summary>
    /// IntProperty: RandomTauntsAnimIdx
    /// </summary>
    public unsafe int RandomTauntsAnimIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5120); }
    }

    /// <summary>
    /// ArrayProperty: RandomTaunts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> RandomTaunts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 5124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5124); }
    }

    /// <summary>
    /// ByteProperty: CurrentBaneAwareness
    /// </summary>
    public unsafe BmSDK.BmScript.MPawnBossBaneTitan.BaneAwareness CurrentBaneAwareness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MPawnBossBaneTitan.BaneAwareness>(Ptr + 5136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5136); }
    }

    /// <summary>
    /// ByteProperty: CurrentObstacleAwareness
    /// </summary>
    public unsafe BmSDK.BmScript.MPawnBossBaneTitan.ObstacleAwareness CurrentObstacleAwareness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MPawnBossBaneTitan.ObstacleAwareness>(Ptr + 5137); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5137); }
    }

    /// <summary>
    /// ByteProperty: CurrentHealthState
    /// </summary>
    public unsafe BmSDK.BmScript.MPawnBossBaneTitan.BaneEscalationStage CurrentHealthState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MPawnBossBaneTitan.BaneEscalationStage>(Ptr + 5138); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5138); }
    }

    /// <summary>
    /// ByteProperty: PreviousHealthState
    /// </summary>
    public unsafe BmSDK.BmScript.MPawnBossBaneTitan.BaneEscalationStage PreviousHealthState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MPawnBossBaneTitan.BaneEscalationStage>(Ptr + 5139); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5139); }
    }

    /// <summary>
    /// ByteProperty: HelpPromptIcon
    /// </summary>
    public unsafe BmSDK.BmScript.MPawnBossBaneTitan.eHelpPromptIcon HelpPromptIcon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MPawnBossBaneTitan.eHelpPromptIcon>(Ptr + 5140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5140); }
    }

    /// <summary>
    /// ArrayProperty: BaneListOfPOI
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.MBanePointOfInterest> BaneListOfPOI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.MBanePointOfInterest>>(Ptr + 5144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5144); }
    }

    /// <summary>
    /// ObjectProperty: POIVisualContact
    /// </summary>
    public unsafe BmSDK.BmScript.MBanePointOfInterest POIVisualContact
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MBanePointOfInterest>(Ptr + 5156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5156); }
    }

    /// <summary>
    /// ComponentProperty: FallingDebris
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FallingDebris
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5160); }
    }

    /// <summary>
    /// ComponentProperty: GrateBreakingFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent GrateBreakingFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5164); }
    }

    /// <summary>
    /// StructProperty: ImpactScreenShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ImpactScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 5168);

    /// <summary>
    /// StructProperty: ChargeNoiseLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ChargeNoiseLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5312);

    /// <summary>
    /// FloatProperty: ChargeCornerStopDistance
    /// </summary>
    public unsafe float ChargeCornerStopDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5324); }
    }

    /// <summary>
    /// StructProperty: LastStuckCheckLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastStuckCheckLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5328);

    /// <summary>
    /// FloatProperty: LastStuckCheckTime
    /// </summary>
    public unsafe float LastStuckCheckTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5340); }
    }

    /// <summary>
    /// ObjectProperty: LastEnteredActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor LastEnteredActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 5344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5344); }
    }

    /// <summary>
    /// FloatProperty: fTimeSinceLastTaunt
    /// </summary>
    public unsafe float fTimeSinceLastTaunt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5348); }
    }

    /// <summary>
    /// FloatProperty: BaneEyesMaterialOpacity
    /// </summary>
    public unsafe float BaneEyesMaterialOpacity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5352); }
    }

    /// <summary>
    /// ObjectProperty: BaneSfx_PlayVenomIdle
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent BaneSfx_PlayVenomIdle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5356); }
    }

    /// <summary>
    /// ObjectProperty: BaneSfx_StopVenomIdle
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent BaneSfx_StopVenomIdle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5360); }
    }

    /// <summary>
    /// FloatProperty: SawBatmanTimestamp
    /// </summary>
    public unsafe float SawBatmanTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5364); }
    }

    /// <summary>
    /// ComponentProperty: FrontGaugeLight
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent FrontGaugeLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 5368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5368); }
    }

    /// <summary>
    /// DelegateProperty: __StopLookLeft__Delegate
    /// </summary>
    public unsafe System.IntPtr __StopLookLeft__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 5372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5372); }
    }

    /// <summary>
    /// DelegateProperty: __StopLookRight__Delegate
    /// </summary>
    public unsafe System.IntPtr __StopLookRight__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 5384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5384); }
    }

    /// <summary>
    /// DelegateProperty: __StopLookLeftToRightQueued__Delegate
    /// </summary>
    public unsafe System.IntPtr __StopLookLeftToRightQueued__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 5396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5396); }
    }
}
