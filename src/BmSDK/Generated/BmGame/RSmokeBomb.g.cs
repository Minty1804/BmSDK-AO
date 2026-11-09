#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RSmokeBomb<br/>
/// (size = 1380)
/// (flags = 8388659)
/// </summary>
public partial class RSmokeBomb : BmSDK.BmGame.RProjectileGadgetBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSmokeBomb", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSmokeBomb.
    /// </summary>
    public static RSmokeBomb DefaultObject => (RSmokeBomb)StaticClass().DefaultObject;

    internal RSmokeBomb() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSmokeBomb(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSmokeBomb>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSmokeBomb>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSmokeBomb>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSmokeBomb>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSmokeBomb>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSmokeBomb>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSmokeBomb>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSmokeBomb>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_RestockAmmo;
    /// <summary>
    /// Function: RestockAmmo
    /// </summary>
    public unsafe override void RestockAmmo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestockAmmo, "BmGame.RSmokeBomb.RestockAmmo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RecentlyThrown;
    /// <summary>
    /// Function: RecentlyThrown
    /// </summary>
    public unsafe virtual void RecentlyThrown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RecentlyThrown, "BmGame.RSmokeBomb.RecentlyThrown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WaitForDetectiveMode;
    /// <summary>
    /// Function: WaitForDetectiveMode
    /// </summary>
    public unsafe virtual void WaitForDetectiveMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WaitForDetectiveMode, "BmGame.RSmokeBomb.WaitForDetectiveMode");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireGadgetCombat;
    /// <summary>
    /// Function: FireGadgetCombat
    /// </summary>
    public unsafe override bool FireGadgetCombat()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireGadgetCombat, "BmGame.RSmokeBomb.FireGadgetCombat");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RSmokeBomb.Tick");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateAllowRecharge;
    /// <summary>
    /// Function: UpdateAllowRecharge
    /// </summary>
    public unsafe virtual void UpdateAllowRecharge()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateAllowRecharge, "BmGame.RSmokeBomb.UpdateAllowRecharge");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanThrowGadget;
    /// <summary>
    /// Function: CanThrowGadget
    /// </summary>
    public unsafe override bool CanThrowGadget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanThrowGadget, "BmGame.RSmokeBomb.CanThrowGadget");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnRoomChange;
    /// <summary>
    /// Function: OnRoomChange
    /// </summary>
    public unsafe override void OnRoomChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRoomChange, "BmGame.RSmokeBomb.OnRoomChange");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHelpPrompt;
    /// <summary>
    /// Function: GetHelpPrompt
    /// </summary>
    public unsafe override void GetHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHelpPrompt, "BmGame.RSmokeBomb.GetHelpPrompt");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GadgetNoiseEvent;
    /// <summary>
    /// Function: GadgetNoiseEvent
    /// </summary>
    public unsafe virtual void GadgetNoiseEvent(System.Numerics.Vector3 SmokeBombLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GadgetNoiseEvent, "BmGame.RSmokeBomb.GadgetNoiseEvent");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SmokeBombLoc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DetonateSmokeBomb;
    /// <summary>
    /// Function: DetonateSmokeBomb
    /// </summary>
    public unsafe virtual void DetonateSmokeBomb(System.Numerics.Vector3 SmokeBombLoc, System.Numerics.Vector3 HitNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetonateSmokeBomb, "BmGame.RSmokeBomb.DetonateSmokeBomb");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SmokeBombLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerSmokeBombFloor;
    /// <summary>
    /// Function: TriggerSmokeBombFloor
    /// </summary>
    public unsafe virtual void TriggerSmokeBombFloor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSmokeBombFloor, "BmGame.RSmokeBomb.TriggerSmokeBombFloor");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DropSmokeBomb;
    /// <summary>
    /// Function: DropSmokeBomb
    /// </summary>
    public unsafe virtual void DropSmokeBomb()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DropSmokeBomb, "BmGame.RSmokeBomb.DropSmokeBomb");
        byte* paramsPtr = stackalloc byte[132];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetSmokeTimers;
    /// <summary>
    /// Function: SetSmokeTimers
    /// </summary>
    public unsafe virtual void SetSmokeTimers(float SmokeFadeTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSmokeTimers, "BmGame.RSmokeBomb.SetSmokeTimers");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SmokeFadeTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GadgetUsed;
    /// <summary>
    /// Function: GadgetUsed
    /// </summary>
    public unsafe override void GadgetUsed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GadgetUsed, "BmGame.RSmokeBomb.GadgetUsed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireSmokeBombGrapple;
    /// <summary>
    /// Function: FireSmokeBombGrapple
    /// </summary>
    public unsafe virtual bool FireSmokeBombGrapple()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireSmokeBombGrapple, "BmGame.RSmokeBomb.FireSmokeBombGrapple");
        byte* paramsPtr = stackalloc byte[144];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPrimedPose;
    /// <summary>
    /// Function: GetPrimedPose
    /// </summary>
    public unsafe override BmSDK.FName GetPrimedPose(out BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch StanceIsCrouched, out BmSDK.BmGame.RAnimUtil.EMirrorChoice MirroredNess, bool InSoftCover, BmSDK.BmGame.RInventoryGadget.CoverCornerType CornerType, out BmSDK.FName OutCapeState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPrimedPose, "BmGame.RSmokeBomb.GetPrimedPose");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StanceIsCrouched);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StanceIsCrouched, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MirroredNess);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MirroredNess, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSoftCover, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerType, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OutCapeState);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutCapeState, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        StanceIsCrouched = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch>(paramsPtr + 0);
        MirroredNess = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.EMirrorChoice>(paramsPtr + 1);
        OutCapeState = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 20);
    }

    /// <summary>
    /// ObjectProperty: SmokeBombGrappleMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SmokeBombGrappleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// ObjectProperty: SmokeBombStandingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SmokeBombStandingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1368); }
    }

    /// <summary>
    /// ClassProperty: SmokeScreenClass
    /// </summary>
    public unsafe BmSDK.Class SmokeScreenClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }

    /// <summary>
    /// BoolProperty: bCanToggleDetectiveMode
    /// </summary>
    public unsafe bool bCanToggleDetectiveMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1376) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1376); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1376); }
    }

    /// <summary>
    /// BoolProperty: bHasTurnedOnDetectiveMode
    /// </summary>
    public unsafe bool bHasTurnedOnDetectiveMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1376) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1376); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1376); }
    }
}
