#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MAEC_BatarangReaction_Base<br/>
/// (size = 480)
/// (flags = 8388626)
/// </summary>
public partial class MAEC_BatarangReaction_Base : BmSDK.BmGame.RAlertEventCoordinatorBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MAEC_BatarangReaction_Base", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MAEC_BatarangReaction_Base.
    /// </summary>
    public static MAEC_BatarangReaction_Base DefaultObject => (MAEC_BatarangReaction_Base)StaticClass().DefaultObject;

    internal MAEC_BatarangReaction_Base() { }

    /// <summary>
    /// Constructs a new MAEC_BatarangReaction_Base
    /// </summary>
    public MAEC_BatarangReaction_Base(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MAEC_BatarangReaction_Base(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MAEC_BatarangReaction_Base>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MAEC_BatarangReaction_Base>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MAEC_BatarangReaction_Base>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MAEC_BatarangReaction_Base>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MAEC_BatarangReaction_Base>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MAEC_BatarangReaction_Base>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MAEC_BatarangReaction_Base>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MAEC_BatarangReaction_Base>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ThugGotBatarangedOutOfFrozen;
    /// <summary>
    /// Function: ThugGotBatarangedOutOfFrozen
    /// </summary>
    public unsafe virtual void ThugGotBatarangedOutOfFrozen(BmSDK.BmGame.RBMAIController NewCon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugGotBatarangedOutOfFrozen, "BmGame.MAEC_BatarangReaction_Base.ThugGotBatarangedOutOfFrozen");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NoiseInspectionDone;
    /// <summary>
    /// Function: NoiseInspectionDone
    /// </summary>
    public unsafe virtual void NoiseInspectionDone()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NoiseInspectionDone, "BmGame.MAEC_BatarangReaction_Base.NoiseInspectionDone");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitThugSearch;
    /// <summary>
    /// Function: InitThugSearch
    /// </summary>
    public unsafe virtual void InitThugSearch()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitThugSearch, "BmGame.MAEC_BatarangReaction_Base.InitThugSearch");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoJumpReaction;
    /// <summary>
    /// Function: DoJumpReaction
    /// </summary>
    public unsafe virtual void DoJumpReaction(System.Numerics.Vector3 HitLoc, System.Numerics.Vector3 ThrownFromPos, bool bThrownFromGarg, float JumpRange, int NewBRangID = default, bool bDueToBodyDrop = default, BmSDK.BmGame.RBMAIController BodyDodger = default, bool bTerrorShootStartle = default, bool bAwardRECScareMedal = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoJumpReaction, "BmGame.MAEC_BatarangReaction_Base.DoJumpReaction");
        byte* paramsPtr = stackalloc byte[68];
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

    private static BmSDK.Function __fn_ThugGotUpFromBatarang;
    /// <summary>
    /// Function: ThugGotUpFromBatarang
    /// </summary>
    public unsafe virtual void ThugGotUpFromBatarang(BmSDK.BmGame.RPawnVillain TestThug)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugGotUpFromBatarang, "BmGame.MAEC_BatarangReaction_Base.ThugGotUpFromBatarang");
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
    public unsafe virtual void ManDownBodyDodge(BmSDK.BmGame.RBMAIController Dodger, System.Numerics.Vector3 HitLoc, System.Numerics.Vector3 ThrownFromPos, bool bThrownFromGarg, int LaunchID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ManDownBodyDodge, "BmGame.MAEC_BatarangReaction_Base.ManDownBodyDodge");
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
    public unsafe virtual void ThugHit(BmSDK.BmGame.RBMPawnAI NewVictim, System.Numerics.Vector3 HitLoc, System.Numerics.Vector3 ThrownFromPos, bool bThrownFromGarg, BmSDK.BmGame.RBMAIController.BRAECReactionType Type, int NewLaunchID, bool bAwardRECScareMedal = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugHit, "BmGame.MAEC_BatarangReaction_Base.ThugHit");
        byte* paramsPtr = stackalloc byte[60];
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
    public unsafe virtual void MakeRicochetNoise(System.Numerics.Vector3 HitLoc, System.Numerics.Vector3 ThrownFromPos, bool bThrownFromGarg, BmSDK.BmGame.RBMAIController.BRAECReactionType Type, int LaunchID, bool bTerrorShootStartle = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MakeRicochetNoise, "BmGame.MAEC_BatarangReaction_Base.MakeRicochetNoise");
        byte* paramsPtr = stackalloc byte[56];
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
    public unsafe virtual void CheckForThrowReaction(System.Numerics.Vector3 ThrownFromPos, BmSDK.BmGame.RBMAIController.BRAECReactionType Type, int LaunchID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForThrowReaction, "BmGame.MAEC_BatarangReaction_Base.CheckForThrowReaction");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaunchID, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThugSawThrow;
    /// <summary>
    /// Function: ThugSawThrow
    /// </summary>
    public unsafe virtual bool ThugSawThrow(System.Numerics.Vector3 ThrownFromPos, int NewLaunchID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThugSawThrow, "BmGame.MAEC_BatarangReaction_Base.ThugSawThrow");
        byte* paramsPtr = stackalloc byte[36];
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
    public unsafe virtual void UnregisterGuardAEC(BmSDK.BmGame.RAEC_Search_Sub_Guard ExGuardAEC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnregisterGuardAEC, "BmGame.MAEC_BatarangReaction_Base.UnregisterGuardAEC");
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
    public unsafe virtual void RegisterGuardAEC(BmSDK.BmGame.RAEC_Search_Sub_Guard NewGuardAEC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterGuardAEC, "BmGame.MAEC_BatarangReaction_Base.RegisterGuardAEC");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThoughts, "BmGame.MAEC_BatarangReaction_Base.GetThoughts");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_PreStreamOut;
    /// <summary>
    /// Function: PreStreamOut
    /// </summary>
    public unsafe override void PreStreamOut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreStreamOut, "BmGame.MAEC_BatarangReaction_Base.PreStreamOut");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
