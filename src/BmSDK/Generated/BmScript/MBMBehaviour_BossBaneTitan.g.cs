#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MBMBehaviour_BossBaneTitan<br/>
/// (size = 1408)
/// (flags = 8210)
/// </summary>
public partial class MBMBehaviour_BossBaneTitan : BmSDK.BmScript.MBMBehaviour_BossBaneTitanBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MBMBehaviour_BossBaneTitan", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MBMBehaviour_BossBaneTitan.
    /// </summary>
    public static MBMBehaviour_BossBaneTitan DefaultObject => (MBMBehaviour_BossBaneTitan)StaticClass().DefaultObject;

    internal MBMBehaviour_BossBaneTitan() { }

    /// <summary>
    /// Constructs a new MBMBehaviour_BossBaneTitan
    /// </summary>
    public MBMBehaviour_BossBaneTitan(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MBMBehaviour_BossBaneTitan Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MBMBehaviour_BossBaneTitan(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_BossBaneTitan>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_BossBaneTitan>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_BossBaneTitan>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_BossBaneTitan>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_BossBaneTitan>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_BossBaneTitan>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_BossBaneTitan>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMBehaviour_BossBaneTitan>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetObjClassVersion;
    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetObjClassVersion, "BmScript.MBMBehaviour_BossBaneTitan.GetObjClassVersion");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GotoClosestPOI;
    /// <summary>
    /// Function: GotoClosestPOI
    /// </summary>
    public unsafe virtual bool GotoClosestPOI()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoClosestPOI, "BmScript.MBMBehaviour_BossBaneTitan.GotoClosestPOI");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetClosestPOI;
    /// <summary>
    /// Function: GetClosestPOI
    /// </summary>
    public unsafe virtual BmSDK.BmScript.MBanePointOfInterest GetClosestPOI(float DistLimitSq = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClosestPOI, "BmScript.MBMBehaviour_BossBaneTitan.GetClosestPOI");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DistLimitSq, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmScript.MBanePointOfInterest>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetPoIAssociatedWithVent;
    /// <summary>
    /// Function: GetPoIAssociatedWithVent
    /// </summary>
    public unsafe virtual BmSDK.BmScript.MBanePointOfInterest GetPoIAssociatedWithVent(BmSDK.BmGame.RRemoveableGrate Vent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPoIAssociatedWithVent, "BmScript.MBMBehaviour_BossBaneTitan.GetPoIAssociatedWithVent");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Vent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmScript.MBanePointOfInterest>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ShouldIgnoreDamage;
    /// <summary>
    /// Function: ShouldIgnoreDamage
    /// </summary>
    public unsafe virtual bool ShouldIgnoreDamage(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldIgnoreDamage, "BmScript.MBMBehaviour_BossBaneTitan.ShouldIgnoreDamage");
        byte* paramsPtr = stackalloc byte[276];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 256);
    }

    private static BmSDK.Function __fn_NotifyShowdownEnded;
    /// <summary>
    /// Function: NotifyShowdownEnded
    /// </summary>
    public unsafe virtual void NotifyShowdownEnded()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyShowdownEnded, "BmScript.MBMBehaviour_BossBaneTitan.NotifyShowdownEnded");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyShowdownBegan;
    /// <summary>
    /// Function: NotifyShowdownBegan
    /// </summary>
    public unsafe virtual void NotifyShowdownBegan()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyShowdownBegan, "BmScript.MBMBehaviour_BossBaneTitan.NotifyShowdownBegan");
        byte* paramsPtr = stackalloc byte[156];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyShowdownWallNotify;
    /// <summary>
    /// Function: NotifyShowdownWallNotify
    /// </summary>
    public unsafe virtual void NotifyShowdownWallNotify()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyShowdownWallNotify, "BmScript.MBMBehaviour_BossBaneTitan.NotifyShowdownWallNotify");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyShowdownBreakWall;
    /// <summary>
    /// Function: NotifyShowdownBreakWall
    /// </summary>
    public unsafe virtual void NotifyShowdownBreakWall()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyShowdownBreakWall, "BmScript.MBMBehaviour_BossBaneTitan.NotifyShowdownBreakWall");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyShowdownVoiceOver;
    /// <summary>
    /// Function: NotifyShowdownVoiceOver
    /// </summary>
    public unsafe virtual void NotifyShowdownVoiceOver()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyShowdownVoiceOver, "BmScript.MBMBehaviour_BossBaneTitan.NotifyShowdownVoiceOver");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyShowdownFakeDeath;
    /// <summary>
    /// Function: NotifyShowdownFakeDeath
    /// </summary>
    public unsafe virtual void NotifyShowdownFakeDeath()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyShowdownFakeDeath, "BmScript.MBMBehaviour_BossBaneTitan.NotifyShowdownFakeDeath");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CrankCinematicTriggered;
    /// <summary>
    /// Function: CrankCinematicTriggered
    /// </summary>
    public unsafe virtual void CrankCinematicTriggered()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CrankCinematicTriggered, "BmScript.MBMBehaviour_BossBaneTitan.CrankCinematicTriggered");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GotoCombatState;
    /// <summary>
    /// Function: GotoCombatState
    /// </summary>
    public unsafe override void GotoCombatState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotoCombatState, "BmScript.MBMBehaviour_BossBaneTitan.GotoCombatState");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldUseEnvironment;
    /// <summary>
    /// Function: ShouldUseEnvironment
    /// </summary>
    public unsafe override bool ShouldUseEnvironment(float DeltaTime, bool bForceCheck)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldUseEnvironment, "BmScript.MBMBehaviour_BossBaneTitan.ShouldUseEnvironment");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceCheck, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CanExitBehaviour;
    /// <summary>
    /// Function: CanExitBehaviour
    /// </summary>
    public unsafe virtual bool CanExitBehaviour()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanExitBehaviour, "BmScript.MBMBehaviour_BossBaneTitan.CanExitBehaviour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_WantsToEnterCombat;
    /// <summary>
    /// Function: WantsToEnterCombat
    /// </summary>
    public unsafe override void WantsToEnterCombat()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WantsToEnterCombat, "BmScript.MBMBehaviour_BossBaneTitan.WantsToEnterCombat");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNavigationStrategyPaused;
    /// <summary>
    /// Function: SetNavigationStrategyPaused
    /// </summary>
    public unsafe virtual void SetNavigationStrategyPaused(bool Paused)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNavigationStrategyPaused, "BmScript.MBMBehaviour_BossBaneTitan.SetNavigationStrategyPaused");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Paused, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetClosestGargoyleAttackLoc;
    /// <summary>
    /// Function: GetClosestGargoyleAttackLoc
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetClosestGargoyleAttackLoc(System.Numerics.Vector3 GargoyleLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClosestGargoyleAttackLoc, "BmScript.MBMBehaviour_BossBaneTitan.GetClosestGargoyleAttackLoc");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GargoyleLoc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_UpdateOpScript;
    /// <summary>
    /// Function: UpdateOpScript
    /// </summary>
    public unsafe override void UpdateOpScript(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateOpScript, "BmScript.MBMBehaviour_BossBaneTitan.UpdateOpScript");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBestPOI;
    /// <summary>
    /// Function: GetBestPOI
    /// </summary>
    public unsafe virtual BmSDK.BmScript.MBanePointOfInterest GetBestPOI(BmSDK.BmScript.MBanePointOfInterest.PointOfInterestType ThisType = default, BmSDK.BmScript.MBanePointOfInterest NotThisOne = default, BmSDK.BmScript.MBanePointOfInterest AndNotThisOne = default, int iIterationCount = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBestPOI, "BmScript.MBMBehaviour_BossBaneTitan.GetBestPOI");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThisType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NotThisOne, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AndNotThisOne, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iIterationCount, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmScript.MBanePointOfInterest>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_UpdateCheckCorner;
    /// <summary>
    /// Function: UpdateCheckCorner
    /// </summary>
    public unsafe virtual void UpdateCheckCorner(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateCheckCorner, "BmScript.MBMBehaviour_BossBaneTitan.UpdateCheckCorner");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DoneQuickInvestigation;
    /// <summary>
    /// Function: DoneQuickInvestigation
    /// </summary>
    public unsafe virtual bool DoneQuickInvestigation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoneQuickInvestigation, "BmScript.MBMBehaviour_BossBaneTitan.DoneQuickInvestigation");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAxisAlignedOrientation;
    /// <summary>
    /// Function: GetAxisAlignedOrientation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAxisAlignedOrientation(System.Numerics.Vector3 CurrentOrientation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAxisAlignedOrientation, "BmScript.MBMBehaviour_BossBaneTitan.GetAxisAlignedOrientation");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentOrientation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ShouldDestroyGrate;
    /// <summary>
    /// Function: ShouldDestroyGrate
    /// </summary>
    public unsafe virtual bool ShouldDestroyGrate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldDestroyGrate, "BmScript.MBMBehaviour_BossBaneTitan.ShouldDestroyGrate");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsGrateSearchAllowed;
    /// <summary>
    /// Function: IsGrateSearchAllowed
    /// </summary>
    public unsafe virtual bool IsGrateSearchAllowed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsGrateSearchAllowed, "BmScript.MBMBehaviour_BossBaneTitan.IsGrateSearchAllowed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldDestroyVent;
    /// <summary>
    /// Function: ShouldDestroyVent
    /// </summary>
    public unsafe virtual bool ShouldDestroyVent()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldDestroyVent, "BmScript.MBMBehaviour_BossBaneTitan.ShouldDestroyVent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsVentSearchAllowed;
    /// <summary>
    /// Function: IsVentSearchAllowed
    /// </summary>
    public unsafe virtual bool IsVentSearchAllowed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsVentSearchAllowed, "BmScript.MBMBehaviour_BossBaneTitan.IsVentSearchAllowed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetMeleeDamage;
    /// <summary>
    /// Function: GetMeleeDamage
    /// </summary>
    public unsafe virtual int GetMeleeDamage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMeleeDamage, "BmScript.MBMBehaviour_BossBaneTitan.GetMeleeDamage");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTaunt;
    /// <summary>
    /// Function: GetTaunt
    /// </summary>
    public unsafe virtual BmSDK.FName GetTaunt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTaunt, "BmScript.MBMBehaviour_BossBaneTitan.GetTaunt");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AdvancePatrolPoint;
    /// <summary>
    /// Function: AdvancePatrolPoint
    /// </summary>
    public unsafe virtual void AdvancePatrolPoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdvancePatrolPoint, "BmScript.MBMBehaviour_BossBaneTitan.AdvancePatrolPoint");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AlertToBrokenGlassSound;
    /// <summary>
    /// Function: AlertToBrokenGlassSound
    /// </summary>
    public unsafe virtual void AlertToBrokenGlassSound(System.Numerics.Vector3 BreakageLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AlertToBrokenGlassSound, "BmScript.MBMBehaviour_BossBaneTitan.AlertToBrokenGlassSound");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BreakageLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsClosestPatrolPointTo;
    /// <summary>
    /// Function: IsClosestPatrolPointTo
    /// </summary>
    public unsafe virtual bool IsClosestPatrolPointTo(BmSDK.BmGame.RPatrolPoint aPP, System.Numerics.Vector3 aPosition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsClosestPatrolPointTo, "BmScript.MBMBehaviour_BossBaneTitan.IsClosestPatrolPointTo");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aPP, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aPosition, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_TickNavigationStrategy;
    /// <summary>
    /// Function: TickNavigationStrategy
    /// </summary>
    public unsafe virtual void TickNavigationStrategy(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickNavigationStrategy, "BmScript.MBMBehaviour_BossBaneTitan.TickNavigationStrategy");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldRerouteToFootPrint;
    /// <summary>
    /// Function: ShouldRerouteToFootPrint
    /// </summary>
    public unsafe virtual bool ShouldRerouteToFootPrint(out int youngest_footprint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldRerouteToFootPrint, "BmScript.MBMBehaviour_BossBaneTitan.ShouldRerouteToFootPrint");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out youngest_footprint);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(youngest_footprint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        youngest_footprint = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsFacingTarget;
    /// <summary>
    /// Function: IsFacingTarget
    /// </summary>
    public unsafe virtual bool IsFacingTarget(System.Numerics.Vector3 the_target_position)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFacingTarget, "BmScript.MBMBehaviour_BossBaneTitan.IsFacingTarget");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_target_position, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetClosestPatrolPoint;
    /// <summary>
    /// Function: GetClosestPatrolPoint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPatrolPoint GetClosestPatrolPoint(BmSDK.BmGame.RPatrolPoint FirstPatrolPoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClosestPatrolPoint, "BmScript.MBMBehaviour_BossBaneTitan.GetClosestPatrolPoint");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FirstPatrolPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPatrolPoint>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_StartPatrol;
    /// <summary>
    /// Function: StartPatrol
    /// </summary>
    public unsafe virtual void StartPatrol(BmSDK.BmGame.RPatrolPoint StartPt)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartPatrol, "BmScript.MBMBehaviour_BossBaneTitan.StartPatrol");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPt, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetClosestSteamSource;
    /// <summary>
    /// Function: GetClosestSteamSource
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor GetClosestSteamSource()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClosestSteamSource, "BmScript.MBMBehaviour_BossBaneTitan.GetClosestSteamSource");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetNavigationStrategy;
    /// <summary>
    /// Function: SetNavigationStrategy
    /// </summary>
    public unsafe virtual void SetNavigationStrategy(BmSDK.BmScript.MBMBehaviour_BossBaneTitan.BaneNavigationStrategy NewStrategy)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNavigationStrategy, "BmScript.MBMBehaviour_BossBaneTitan.SetNavigationStrategy");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewStrategy, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMoveSpeed;
    /// <summary>
    /// Function: SetMoveSpeed
    /// </summary>
    public unsafe virtual void SetMoveSpeed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMoveSpeed, "BmScript.MBMBehaviour_BossBaneTitan.SetMoveSpeed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsBatmanWithinVerticalRange;
    /// <summary>
    /// Function: IsBatmanWithinVerticalRange
    /// </summary>
    public unsafe virtual bool IsBatmanWithinVerticalRange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBatmanWithinVerticalRange, "BmScript.MBMBehaviour_BossBaneTitan.IsBatmanWithinVerticalRange");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RefreshVisualContact;
    /// <summary>
    /// Function: RefreshVisualContact
    /// </summary>
    public unsafe virtual bool RefreshVisualContact(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RefreshVisualContact, "BmScript.MBMBehaviour_BossBaneTitan.RefreshVisualContact");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SawPlayerLeadToCombat;
    /// <summary>
    /// Function: SawPlayerLeadToCombat
    /// </summary>
    public unsafe virtual void SawPlayerLeadToCombat()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SawPlayerLeadToCombat, "BmScript.MBMBehaviour_BossBaneTitan.SawPlayerLeadToCombat");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldIgnoreViewWedges;
    /// <summary>
    /// Function: ShouldIgnoreViewWedges
    /// </summary>
    public unsafe virtual bool ShouldIgnoreViewWedges()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldIgnoreViewWedges, "BmScript.MBMBehaviour_BossBaneTitan.ShouldIgnoreViewWedges");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AlertToBatmansPosition;
    /// <summary>
    /// Function: AlertToBatmansPosition
    /// </summary>
    public unsafe virtual void AlertToBatmansPosition()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AlertToBatmansPosition, "BmScript.MBMBehaviour_BossBaneTitan.AlertToBatmansPosition");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AlertToGadgetNoise;
    /// <summary>
    /// Function: AlertToGadgetNoise
    /// </summary>
    public unsafe virtual void AlertToGadgetNoise()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AlertToGadgetNoise, "BmScript.MBMBehaviour_BossBaneTitan.AlertToGadgetNoise");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetClosestPointOnNavMesh;
    /// <summary>
    /// Function: GetClosestPointOnNavMesh
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetClosestPointOnNavMesh(System.Numerics.Vector3 OutOfNavMeshLoc, System.Numerics.Vector3 vOffset = default, float fDist = default, int iIterationCount = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClosestPointOnNavMesh, "BmScript.MBMBehaviour_BossBaneTitan.GetClosestPointOnNavMesh");
        byte* paramsPtr = stackalloc byte[96];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutOfNavMeshLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vOffset, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDist, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iIterationCount, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_KismetGadgetNoise;
    /// <summary>
    /// Function: KismetGadgetNoise
    /// </summary>
    public unsafe virtual void KismetGadgetNoise()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KismetGadgetNoise, "BmScript.MBMBehaviour_BossBaneTitan.KismetGadgetNoise");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsBatmanMakingNoise;
    /// <summary>
    /// Function: IsBatmanMakingNoise
    /// </summary>
    public unsafe virtual bool IsBatmanMakingNoise()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBatmanMakingNoise, "BmScript.MBMBehaviour_BossBaneTitan.IsBatmanMakingNoise");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SearchFailed;
    /// <summary>
    /// Function: SearchFailed
    /// </summary>
    public unsafe virtual void SearchFailed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SearchFailed, "BmScript.MBMBehaviour_BossBaneTitan.SearchFailed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TargetSearchCompleted;
    /// <summary>
    /// Function: TargetSearchCompleted
    /// </summary>
    public unsafe virtual void TargetSearchCompleted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TargetSearchCompleted, "BmScript.MBMBehaviour_BossBaneTitan.TargetSearchCompleted");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SearchForNearLocation;
    /// <summary>
    /// Function: SearchForNearLocation
    /// </summary>
    public unsafe virtual void SearchForNearLocation(int ZeroToThree)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SearchForNearLocation, "BmScript.MBMBehaviour_BossBaneTitan.SearchForNearLocation");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ZeroToThree, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MoveNearToTargetLocation;
    /// <summary>
    /// Function: MoveNearToTargetLocation
    /// </summary>
    public unsafe virtual void MoveNearToTargetLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveNearToTargetLocation, "BmScript.MBMBehaviour_BossBaneTitan.MoveNearToTargetLocation");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MoveToCommon;
    /// <summary>
    /// Function: MoveToCommon
    /// </summary>
    public unsafe virtual void MoveToCommon(System.Numerics.Vector3 Destination)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveToCommon, "BmScript.MBMBehaviour_BossBaneTitan.MoveToCommon");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Destination, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckFloor;
    /// <summary>
    /// Function: CheckFloor
    /// </summary>
    public unsafe virtual bool CheckFloor(System.Numerics.Vector3 CheckPos, System.Numerics.Vector3 Offset, out System.Numerics.Vector3 GroundPos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckFloor, "BmScript.MBMBehaviour_BossBaneTitan.CheckFloor");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Offset, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out GroundPos);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GroundPos, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        GroundPos = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_MoveToTargetLocation;
    /// <summary>
    /// Function: MoveToTargetLocation
    /// </summary>
    public unsafe virtual void MoveToTargetLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveToTargetLocation, "BmScript.MBMBehaviour_BossBaneTitan.MoveToTargetLocation");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MoveToAttackBatman;
    /// <summary>
    /// Function: MoveToAttackBatman
    /// </summary>
    public unsafe virtual void MoveToAttackBatman()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveToAttackBatman, "BmScript.MBMBehaviour_BossBaneTitan.MoveToAttackBatman");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MoveToLastKnownPosition;
    /// <summary>
    /// Function: MoveToLastKnownPosition
    /// </summary>
    public unsafe virtual void MoveToLastKnownPosition()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveToLastKnownPosition, "BmScript.MBMBehaviour_BossBaneTitan.MoveToLastKnownPosition");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_MoveToFootprint;
    /// <summary>
    /// Function: MoveToFootprint
    /// </summary>
    public unsafe virtual void MoveToFootprint(int footprint_index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveToFootprint, "BmScript.MBMBehaviour_BossBaneTitan.MoveToFootprint");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(footprint_index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBeKnockedDown;
    /// <summary>
    /// Function: CanBeKnockedDown
    /// </summary>
    public unsafe virtual bool CanBeKnockedDown(BmSDK.FString takedown = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeKnockedDown, "BmScript.MBMBehaviour_BossBaneTitan.CanBeKnockedDown");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takedown, paramsPtr + 0);
        var __optional = BmSDK.Framework.OptionalParms.Suspend(funcManaged);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BmSDK.Framework.OptionalParms.Resume(funcManaged, __optional);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_TickSuspendedBehaviour;
    /// <summary>
    /// Function: TickSuspendedBehaviour
    /// </summary>
    public unsafe virtual void TickSuspendedBehaviour(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickSuspendedBehaviour, "BmScript.MBMBehaviour_BossBaneTitan.TickSuspendedBehaviour");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SuspendBehaviour;
    /// <summary>
    /// Function: SuspendBehaviour
    /// </summary>
    public unsafe virtual void SuspendBehaviour(bool OnlyIfNoVisualContact)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuspendBehaviour, "BmScript.MBMBehaviour_BossBaneTitan.SuspendBehaviour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnlyIfNoVisualContact, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ChangeToVulnerableState;
    /// <summary>
    /// Function: ChangeToVulnerableState
    /// </summary>
    public unsafe virtual void ChangeToVulnerableState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeToVulnerableState, "BmScript.MBMBehaviour_BossBaneTitan.ChangeToVulnerableState");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsValidForStrike;
    /// <summary>
    /// Function: IsValidForStrike
    /// </summary>
    public unsafe virtual bool IsValidForStrike(BmSDK.BmGame.RPawnPlayerCombat thePlayer, BmSDK.BmGame.RPawnCombat TestPawn, BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidForStrike, "BmScript.MBMBehaviour_BossBaneTitan.IsValidForStrike");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(thePlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_IsReadyForStun;
    /// <summary>
    /// Function: IsReadyForStun
    /// </summary>
    public unsafe virtual bool IsReadyForStun()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsReadyForStun, "BmScript.MBMBehaviour_BossBaneTitan.IsReadyForStun");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsBatarangDamage;
    /// <summary>
    /// Function: IsBatarangDamage
    /// </summary>
    public unsafe virtual bool IsBatarangDamage(BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBatarangDamage, "BmScript.MBMBehaviour_BossBaneTitan.IsBatarangDamage");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsVulnerableToPawn;
    /// <summary>
    /// Function: IsVulnerableToPawn
    /// </summary>
    public unsafe virtual bool IsVulnerableToPawn(BmSDK.BmGame.RPawnCombat Attacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsVulnerableToPawn, "BmScript.MBMBehaviour_BossBaneTitan.IsVulnerableToPawn");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsVulnerableToBossStrike;
    /// <summary>
    /// Function: IsVulnerableToBossStrike
    /// </summary>
    public unsafe virtual bool IsVulnerableToBossStrike()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsVulnerableToBossStrike, "BmScript.MBMBehaviour_BossBaneTitan.IsVulnerableToBossStrike");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCurrentRailDirection;
    /// <summary>
    /// Function: GetCurrentRailDirection
    /// </summary>
    public unsafe virtual BmSDK.Rotator GetCurrentRailDirection(System.Numerics.Vector3 movement_direction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrentRailDirection, "BmScript.MBMBehaviour_BossBaneTitan.GetCurrentRailDirection");
        byte* paramsPtr = stackalloc byte[76];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(movement_direction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_BossTickInternal;
    /// <summary>
    /// Function: BossTickInternal
    /// </summary>
    public unsafe override void BossTickInternal(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BossTickInternal, "BmScript.MBMBehaviour_BossBaneTitan.BossTickInternal");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AlertIfPlayerStandsBehindBane;
    /// <summary>
    /// Function: AlertIfPlayerStandsBehindBane
    /// </summary>
    public unsafe virtual void AlertIfPlayerStandsBehindBane(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AlertIfPlayerStandsBehindBane, "BmScript.MBMBehaviour_BossBaneTitan.AlertIfPlayerStandsBehindBane");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AlertIfPlayerIsRunningBehindBane;
    /// <summary>
    /// Function: AlertIfPlayerIsRunningBehindBane
    /// </summary>
    public unsafe virtual void AlertIfPlayerIsRunningBehindBane(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AlertIfPlayerIsRunningBehindBane, "BmScript.MBMBehaviour_BossBaneTitan.AlertIfPlayerIsRunningBehindBane");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldBaneTurnAroundBetween2PoIs;
    /// <summary>
    /// Function: ShouldBaneTurnAroundBetween2PoIs
    /// </summary>
    public unsafe virtual bool ShouldBaneTurnAroundBetween2PoIs()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldBaneTurnAroundBetween2PoIs, "BmScript.MBMBehaviour_BossBaneTitan.ShouldBaneTurnAroundBetween2PoIs");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IncCountAndCheckIfShouldTurnARoundAfterPoI;
    /// <summary>
    /// Function: IncCountAndCheckIfShouldTurnARoundAfterPoI
    /// </summary>
    public unsafe virtual bool IncCountAndCheckIfShouldTurnARoundAfterPoI()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncCountAndCheckIfShouldTurnARoundAfterPoI, "BmScript.MBMBehaviour_BossBaneTitan.IncCountAndCheckIfShouldTurnARoundAfterPoI");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCurrEscalationStage;
    /// <summary>
    /// Function: GetCurrEscalationStage
    /// </summary>
    public unsafe virtual BmSDK.BmScript.MPawnBossBaneTitan.BaneEscalationStage GetCurrEscalationStage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCurrEscalationStage, "BmScript.MBMBehaviour_BossBaneTitan.GetCurrEscalationStage");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmScript.MPawnBossBaneTitan.BaneEscalationStage>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetThoughts;
    /// <summary>
    /// Function: GetThoughts
    /// </summary>
    public unsafe override void GetThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThoughts, "BmScript.MBMBehaviour_BossBaneTitan.GetThoughts");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_DrawDebugGraphics;
    /// <summary>
    /// Function: DrawDebugGraphics
    /// </summary>
    public unsafe virtual void DrawDebugGraphics()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugGraphics, "BmScript.MBMBehaviour_BossBaneTitan.DrawDebugGraphics");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Tick;
    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmScript.MBMBehaviour_BossBaneTitan.Tick");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnBeginInterrupt;
    /// <summary>
    /// Function: OnBeginInterrupt
    /// </summary>
    public unsafe override void OnBeginInterrupt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBeginInterrupt, "BmScript.MBMBehaviour_BossBaneTitan.OnBeginInterrupt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnEndInterrupt;
    /// <summary>
    /// Function: OnEndInterrupt
    /// </summary>
    public unsafe override void OnEndInterrupt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnEndInterrupt, "BmScript.MBMBehaviour_BossBaneTitan.OnEndInterrupt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnDeactivate;
    /// <summary>
    /// Function: OnDeactivate
    /// </summary>
    public unsafe override void OnDeactivate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDeactivate, "BmScript.MBMBehaviour_BossBaneTitan.OnDeactivate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnActivate;
    /// <summary>
    /// Function: OnActivate
    /// </summary>
    public unsafe override void OnActivate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnActivate, "BmScript.MBMBehaviour_BossBaneTitan.OnActivate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: AttackPointSearchStates
    /// </summary>
    public enum AttackPointSearchStates : byte
    {
        AP_Idle = 0,
        AP_FindPoints = 1,
        AP_FindPaths = 2,
        AP_Finished = 3,
        AP_MAX = 4,
    }

    /// <summary>
    /// Enum: EnvNeutStrategy
    /// </summary>
    public enum EnvNeutStrategy : byte
    {
        ENS_SilentTakedown = 0,
        ENS_RailsLedges = 1,
        ENS_Skylights = 2,
        ENS_GlideKick = 3,
        ENS_LineLauncher = 4,
        ENS_MagBlast = 5,
        ENS_WeakWall = 6,
        ENS_ElectricFloor = 7,
        ENS_ThroughWindow = 8,
        ENS_FloorGrate = 9,
        ENS_HighBox = 10,
        ENS_MAX = 11,
    }

    /// <summary>
    /// Enum: NavigationApproach
    /// </summary>
    public enum NavigationApproach : byte
    {
        NA_MoveToPosition = 0,
        NA_MoveNearToPosition = 1,
        NA_MAX = 2,
    }

    /// <summary>
    /// Enum: BaneNavigationStrategy
    /// </summary>
    public enum BaneNavigationStrategy : byte
    {
        NS_None = 0,
        NS_MoveToBatmansPosition = 1,
        NS_MoveToLastKnownPosition = 2,
        NS_TrackBatPrints = 3,
        NS_PatrolAround = 4,
        NS_InvestigateAround = 5,
        NS_MAX = 6,
    }

    /// <summary>
    /// Enum: DiffLevel
    /// </summary>
    public enum DiffLevel : byte
    {
        DL_EASY = 0,
        DL_NORMAL = 1,
        DL_HARD = 2,
        DL_NEWGAMEPLUS = 3,
        DL_MAX = 4,
    }

    /// <summary>
    /// StructProperty: CurrentWaypointDirection
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentWaypointDirection
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1044);

    /// <summary>
    /// BoolProperty: bBehaviourSuspended
    /// </summary>
    public unsafe bool bBehaviourSuspended
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: bBatmanBecameVisibleWhileBehaviourSuspended
    /// </summary>
    public unsafe bool bBatmanBecameVisibleWhileBehaviourSuspended
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: SuspendBehaviourBatmanHasBase
    /// </summary>
    public unsafe bool SuspendBehaviourBatmanHasBase
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: bSearchActive
    /// </summary>
    public unsafe bool bSearchActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: bExtendedSearchAlternatePlusMinus
    /// </summary>
    public unsafe bool bExtendedSearchAlternatePlusMinus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: WalkingPatrolBackward
    /// </summary>
    public unsafe bool WalkingPatrolBackward
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: bArrivedAtFirstPatrolPoint
    /// </summary>
    public unsafe bool bArrivedAtFirstPatrolPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: bNavStratPaused
    /// </summary>
    public unsafe bool bNavStratPaused
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: bJustLostPlayerTrail
    /// </summary>
    public unsafe bool bJustLostPlayerTrail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: bPlayedGroundShakingCam
    /// </summary>
    public unsafe bool bPlayedGroundShakingCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: bBaneInPlaceSent
    /// </summary>
    public unsafe bool bBaneInPlaceSent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreViewWedges
    /// </summary>
    public unsafe bool bIgnoreViewWedges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: WasCrouched
    /// </summary>
    public unsafe bool WasCrouched
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: FirstPOI
    /// </summary>
    public unsafe bool FirstPOI
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: bPlayerDidVentTakedown
    /// </summary>
    public unsafe bool bPlayerDidVentTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: bPlayerDidGrateTakedown
    /// </summary>
    public unsafe bool bPlayerDidGrateTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: bPlayerDidSilentTakedown
    /// </summary>
    public unsafe bool bPlayerDidSilentTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: bPlayerDidSilentTakedownInSmoke
    /// </summary>
    public unsafe bool bPlayerDidSilentTakedownInSmoke
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: bBaneSawPlayerUsedGrate
    /// </summary>
    public unsafe bool bBaneSawPlayerUsedGrate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: bBaneSawPlayerUsedVent
    /// </summary>
    public unsafe bool bBaneSawPlayerUsedVent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: bCurrentPOIInvestigated
    /// </summary>
    public unsafe bool bCurrentPOIInvestigated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: bTrapTauntQueued
    /// </summary>
    public unsafe bool bTrapTauntQueued
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: bForceRepickPOI
    /// </summary>
    public unsafe bool bForceRepickPOI
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: WasChargingPOI
    /// </summary>
    public unsafe bool WasChargingPOI
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// FloatProperty: SuspendBehaviourProximitySquared
    /// </summary>
    public unsafe float SuspendBehaviourProximitySquared
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// FloatProperty: StunMinimumTimer
    /// </summary>
    public unsafe float StunMinimumTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// IntProperty: DifficultyLevel
    /// </summary>
    public unsafe int DifficultyLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// ArrayProperty: DamageDifficultyMultiplier
    /// </summary>
    public unsafe BmSDK.TArray<float> DamageDifficultyMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ArrayProperty: BatmanVelocityLockonPeriod
    /// </summary>
    public unsafe BmSDK.TArray<float> BatmanVelocityLockonPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// ArrayProperty: TakedownRequired
    /// </summary>
    public unsafe BmSDK.TArray<int> TakedownRequired
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// NameProperty: PreviousState
    /// </summary>
    public unsafe BmSDK.FName PreviousState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// FloatProperty: MinDistanceToTrackPrints
    /// </summary>
    public unsafe float MinDistanceToTrackPrints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// ByteProperty: CurrStrategy
    /// </summary>
    public unsafe BmSDK.BmScript.MBMBehaviour_BossBaneTitan.BaneNavigationStrategy CurrStrategy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MBMBehaviour_BossBaneTitan.BaneNavigationStrategy>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// ByteProperty: CurrentNavApproach
    /// </summary>
    public unsafe BmSDK.BmScript.MBMBehaviour_BossBaneTitan.NavigationApproach CurrentNavApproach
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MBMBehaviour_BossBaneTitan.NavigationApproach>(Ptr + 1121); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1121); }
    }

    /// <summary>
    /// ByteProperty: APS_State
    /// </summary>
    public unsafe BmSDK.BmScript.MBMBehaviour_BossBaneTitan.AttackPointSearchStates APS_State
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MBMBehaviour_BossBaneTitan.AttackPointSearchStates>(Ptr + 1122); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1122); }
    }

    /// <summary>
    /// FloatProperty: fTimeInCurrentStrategy
    /// </summary>
    public unsafe float fTimeInCurrentStrategy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// StructProperty: vMoveNearInitialPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 vMoveNearInitialPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1128);

    /// <summary>
    /// ArrayProperty: abEnvNeutStrategies
    /// </summary>
    public unsafe BmSDK.TArray<bool> abEnvNeutStrategies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<bool>>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// ArrayProperty: abEnvNeutTauntsPlayed
    /// </summary>
    public unsafe BmSDK.TArray<bool> abEnvNeutTauntsPlayed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<bool>>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// FloatProperty: fBatmansMostRecentBaseElevation
    /// </summary>
    public unsafe float fBatmansMostRecentBaseElevation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// FloatProperty: fPostBeatdownNeutraliserBinge
    /// </summary>
    public unsafe float fPostBeatdownNeutraliserBinge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// StructProperty: vCurrentTargetPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 vCurrentTargetPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1172);

    /// <summary>
    /// ObjectProperty: APS
    /// </summary>
    public unsafe BmSDK.BmGame.RAttackPointSearch APS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAttackPointSearch>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// ObjectProperty: APS_Results
    /// </summary>
    public unsafe BmSDK.BmGame.RMultiNavHandleWrapper APS_Results
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMultiNavHandleWrapper>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// StructProperty: fExtendedSearchFocalPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 fExtendedSearchFocalPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1192);

    /// <summary>
    /// FloatProperty: fExtendedSearchStartingRadius
    /// </summary>
    public unsafe float fExtendedSearchStartingRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }

    /// <summary>
    /// FloatProperty: fExtendedSearchRadiusRange
    /// </summary>
    public unsafe float fExtendedSearchRadiusRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// IntProperty: iExtendedSearchNumIncrements
    /// </summary>
    public unsafe int iExtendedSearchNumIncrements
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// IntProperty: iExtendedSearchCurrentIncrement
    /// </summary>
    public unsafe int iExtendedSearchCurrentIncrement
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// FloatProperty: fCurrentSearchRadius
    /// </summary>
    public unsafe float fCurrentSearchRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1220); }
    }

    /// <summary>
    /// FloatProperty: fHearingRangeForRunningSound
    /// </summary>
    public unsafe float fHearingRangeForRunningSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// FloatProperty: fRandomTauntValue
    /// </summary>
    public unsafe float fRandomTauntValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }

    /// <summary>
    /// FloatProperty: StateTimer
    /// </summary>
    public unsafe float StateTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// ArrayProperty: TrapPatrolPoints1
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPatrolPoint> TrapPatrolPoints1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPatrolPoint>>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }

    /// <summary>
    /// ObjectProperty: TrapPatrolPoints2
    /// </summary>
    public unsafe BmSDK.BmGame.RPatrolPoint TrapPatrolPoints2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPatrolPoint>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// ObjectProperty: TrapPatrolPoints3
    /// </summary>
    public unsafe BmSDK.BmGame.RPatrolPoint TrapPatrolPoints3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPatrolPoint>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// ObjectProperty: TrapPatrolPoints4
    /// </summary>
    public unsafe BmSDK.BmGame.RPatrolPoint TrapPatrolPoints4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPatrolPoint>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// ObjectProperty: TrapPatrolPoints5
    /// </summary>
    public unsafe BmSDK.BmGame.RPatrolPoint TrapPatrolPoints5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPatrolPoint>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }

    /// <summary>
    /// ArrayProperty: GargoyleAttackLoc
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> GargoyleAttackLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// ObjectProperty: RoomPatrolPoints
    /// </summary>
    public unsafe BmSDK.BmGame.RPatrolPoint RoomPatrolPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPatrolPoint>(Ptr + 1276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1276); }
    }

    /// <summary>
    /// ObjectProperty: CurrentPatrolPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RPatrolPoint CurrentPatrolPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPatrolPoint>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// ObjectProperty: StartPatrolPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RPatrolPoint StartPatrolPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPatrolPoint>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// StructProperty: PatrolTauntAnimId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId PatrolTauntAnimId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 1288);

    /// <summary>
    /// StructProperty: LookAroundAnimId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId LookAroundAnimId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 1292);

    /// <summary>
    /// StructProperty: TurnAnimId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId TurnAnimId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 1296);

    /// <summary>
    /// FloatProperty: CurrentMaxPatrolTime
    /// </summary>
    public unsafe float CurrentMaxPatrolTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// IntProperty: TauntIdx
    /// </summary>
    public unsafe int TauntIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }

    /// <summary>
    /// StructProperty: GadgetNoiseLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GadgetNoiseLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1308);

    /// <summary>
    /// ArrayProperty: ListOfPOI
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.MBanePointOfInterest> ListOfPOI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.MBanePointOfInterest>>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// ObjectProperty: PreviousPOI
    /// </summary>
    public unsafe BmSDK.BmScript.MBanePointOfInterest PreviousPOI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MBanePointOfInterest>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }

    /// <summary>
    /// ObjectProperty: CurrentPOI
    /// </summary>
    public unsafe BmSDK.BmScript.MBanePointOfInterest CurrentPOI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MBanePointOfInterest>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }

    /// <summary>
    /// FloatProperty: InvestigateTimer
    /// </summary>
    public unsafe float InvestigateTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// ObjectProperty: InterruptBehaviour
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBehaviour InterruptBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// IntProperty: iNumPOISearched
    /// </summary>
    public unsafe int iNumPOISearched
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// FloatProperty: PlayerIsBehindTimestamp
    /// </summary>
    public unsafe float PlayerIsBehindTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// StructProperty: PatrolOrientation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PatrolOrientation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1356);

    /// <summary>
    /// StructProperty: PrevPatrolOrientation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PrevPatrolOrientation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1368);

    /// <summary>
    /// ObjectProperty: ClosestSteamSource
    /// </summary>
    public unsafe BmSDK.Engine.Actor ClosestSteamSource
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }

    /// <summary>
    /// IntProperty: SteamSourceIdx
    /// </summary>
    public unsafe int SteamSourceIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }
    }

    /// <summary>
    /// IntProperty: TurnBackPoICount
    /// </summary>
    public unsafe int TurnBackPoICount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1388); }
    }

    /// <summary>
    /// StructProperty: vInititalTurnOrientation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 vInititalTurnOrientation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1392);

    /// <summary>
    /// FloatProperty: fLookLeftIdleTime
    /// </summary>
    public unsafe float fLookLeftIdleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1404); }
    }
}
