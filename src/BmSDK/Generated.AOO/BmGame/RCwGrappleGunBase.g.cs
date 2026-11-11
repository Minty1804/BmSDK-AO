#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCwGrappleGunBase<br/>
/// (size = 5084)
/// (flags = 144736434)
/// </summary>
public partial class RCwGrappleGunBase : BmSDK.BmGame.RGrappleGun, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCwGrappleGunBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCwGrappleGunBase.
    /// </summary>
    public static RCwGrappleGunBase DefaultObject => (RCwGrappleGunBase)StaticClass().DefaultObject;

    internal RCwGrappleGunBase() { }

    /// <summary>
    /// Constructs a new RCwGrappleGunBase
    /// </summary>
    public RCwGrappleGunBase(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCwGrappleGunBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGunBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGunBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGunBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGunBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGunBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGunBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGunBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGunBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_PointAndLineCheck;
    /// <summary>
    /// Function: PointAndLineCheck
    /// </summary>
    public unsafe virtual bool PointAndLineCheck(out System.Numerics.Vector3 HitLocation, out System.Numerics.Vector3 HitNormal, System.Numerics.Vector3 End, System.Numerics.Vector3 Start, System.Numerics.Vector3 Extent, int ExtraTraceFlags = default, bool bIgnoreRailings = default, bool bDebugDraw = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PointAndLineCheck, "BmGame.RCwGrappleGunBase.PointAndLineCheck");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraTraceFlags, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreRailings, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 68);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HitLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        HitNormal = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 72);
    }

    private static BmSDK.Function __fn_GetChainStartLocator;
    /// <summary>
    /// Function: GetChainStartLocator
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RClimbLocator GetChainStartLocator(System.Numerics.Vector3 PlayerLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetChainStartLocator, "BmGame.RCwGrappleGunBase.GetChainStartLocator");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLocation, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RClimbLocator>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetLocatorChainLocation;
    /// <summary>
    /// Function: GetLocatorChainLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetLocatorChainLocation(BmSDK.BmGame.RClimbLocator LowestChainLocator, System.Numerics.Vector3 InLocation, System.Numerics.Vector3 TargetLocation, bool bAlignLowerPoints = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLocatorChainLocation, "BmGame.RCwGrappleGunBase.GetLocatorChainLocation");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LowestChainLocator, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAlignLowerPoints, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_HandleGlobalPounceTargeting;
    /// <summary>
    /// Function: HandleGlobalPounceTargeting
    /// </summary>
    public unsafe virtual void HandleGlobalPounceTargeting()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandleGlobalPounceTargeting, "BmGame.RCwGrappleGunBase.HandleGlobalPounceTargeting");
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

    private static BmSDK.Function __fn_PickNextLowerSwingHeight;
    /// <summary>
    /// Function: PickNextLowerSwingHeight
    /// </summary>
    public unsafe virtual bool PickNextLowerSwingHeight(out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo ClimbInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PickNextLowerSwingHeight, "BmGame.RCwGrappleGunBase.PickNextLowerSwingHeight");
        byte* paramsPtr = stackalloc byte[1004];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ClimbInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 984);
    }

    private static BmSDK.Function __fn_CheckForCeilingTarget;
    /// <summary>
    /// Function: CheckForCeilingTarget
    /// </summary>
    public unsafe virtual bool CheckForCeilingTarget(out System.Numerics.Vector3 CeilingTargetLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForCeilingTarget, "BmGame.RCwGrappleGunBase.CheckForCeilingTarget");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CeilingTargetLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CeilingTargetLocation, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        CeilingTargetLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CheckThisGrapple;
    /// <summary>
    /// Function: CheckThisGrapple
    /// </summary>
    public unsafe virtual bool CheckThisGrapple(BmSDK.BmGame.RGrapplePoint ThisGrapplePoint = default, BmSDK.BmGame.RHidePoint ThisHidePoint = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckThisGrapple, "BmGame.RCwGrappleGunBase.CheckThisGrapple");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThisGrapplePoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThisHidePoint, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetInBoundVector;
    /// <summary>
    /// Function: GetInBoundVector
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetInBoundVector(System.Numerics.Vector3 StartVelocity, System.Numerics.Vector3 EndVelocity)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInBoundVector, "BmGame.RCwGrappleGunBase.GetInBoundVector");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartVelocity, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndVelocity, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_StoreCurrentClimbInfo;
    /// <summary>
    /// Function: StoreCurrentClimbInfo
    /// </summary>
    public unsafe virtual void StoreCurrentClimbInfo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StoreCurrentClimbInfo, "BmGame.RCwGrappleGunBase.StoreCurrentClimbInfo");
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

    private static BmSDK.Function __fn_DrawPounceBlockingVolumes;
    /// <summary>
    /// Function: DrawPounceBlockingVolumes
    /// </summary>
    public unsafe virtual bool DrawPounceBlockingVolumes(out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo Info, bool bDrawPersistent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawPounceBlockingVolumes, "BmGame.RCwGrappleGunBase.DrawPounceBlockingVolumes");
        byte* paramsPtr = stackalloc byte[1008];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawPersistent, paramsPtr + 984);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Info = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 988);
    }

    private static BmSDK.Function __fn_CheckWallPounce;
    /// <summary>
    /// Function: CheckWallPounce
    /// </summary>
    public unsafe virtual bool CheckWallPounce(out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo Info, out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath NewPath, int FromPoint, bool bOptimisePass, bool bTweakFinalPounce = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckWallPounce, "BmGame.RCwGrappleGunBase.CheckWallPounce");
        byte* paramsPtr = stackalloc byte[1196];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FromPoint, paramsPtr + 1164);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOptimisePass, paramsPtr + 1168);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTweakFinalPounce, paramsPtr + 1172);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Info = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(paramsPtr + 0);
        NewPath = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath>(paramsPtr + 984);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 1176);
    }

    private static BmSDK.Function __fn_OptimisePath;
    /// <summary>
    /// Function: OptimisePath
    /// </summary>
    public unsafe virtual void OptimisePath(out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo Info, bool bIgnoreDangleEdges)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OptimisePath, "BmGame.RCwGrappleGunBase.OptimisePath");
        byte* paramsPtr = stackalloc byte[1004];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreDangleEdges, paramsPtr + 984);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Info = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetClosestLandEdge;
    /// <summary>
    /// Function: GetClosestLandEdge
    /// </summary>
    public unsafe virtual bool GetClosestLandEdge(System.Numerics.Vector3 OriginalLocation, System.Numerics.Vector3 OriginalNormal, out BmSDK.TArray<BmSDK.BmGame.RCwGrappleGunBase.FClimbLedges> Ledges, float HTolerance, float VToleranceUp, float VExtraDangleToleranceUp, float VToleranceDown, bool bIgnoreLimits, bool bIgnoreDangle)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetClosestLandEdge, "BmGame.RCwGrappleGunBase.GetClosestLandEdge");
        byte* paramsPtr = stackalloc byte[80];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OriginalLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OriginalNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HTolerance, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VToleranceUp, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VExtraDangleToleranceUp, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VToleranceDown, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreLimits, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreDangle, paramsPtr + 56);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Ledges = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.BmGame.RCwGrappleGunBase.FClimbLedges>>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 60);
    }

    private static BmSDK.Function __fn_DrawClimbRoute;
    /// <summary>
    /// Function: DrawClimbRoute
    /// </summary>
    public unsafe virtual void DrawClimbRoute(bool bPersistent = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawClimbRoute, "BmGame.RCwGrappleGunBase.DrawClimbRoute");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsWallClimbMove;
    /// <summary>
    /// Function: IsWallClimbMove
    /// </summary>
    public unsafe virtual bool IsWallClimbMove(BmSDK.BmGame.RSpecialMoveConfig Config)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsWallClimbMove, "BmGame.RCwGrappleGunBase.IsWallClimbMove");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_StartWallClimbCamera;
    /// <summary>
    /// Function: StartWallClimbCamera
    /// </summary>
    public unsafe virtual void StartWallClimbCamera(System.Numerics.Vector3 CurrentLandLocation, int FirstClimbPointIndex = default, bool bEstimatedLandPoint = default, bool bFromSwing = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartWallClimbCamera, "BmGame.RCwGrappleGunBase.StartWallClimbCamera");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentLandLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FirstClimbPointIndex, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEstimatedLandPoint, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFromSwing, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanClimbToHidePoint;
    /// <summary>
    /// Function: CanClimbToHidePoint
    /// </summary>
    public unsafe virtual bool CanClimbToHidePoint(System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 GrappleLocation, System.Numerics.Vector3 WallNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanClimbToHidePoint, "BmGame.RCwGrappleGunBase.CanClimbToHidePoint");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrappleLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallNormal, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_CanClimbToGrapplePoint;
    /// <summary>
    /// Function: CanClimbToGrapplePoint
    /// </summary>
    public unsafe virtual bool CanClimbToGrapplePoint(System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 GrappleLocation, System.Numerics.Vector3 WallNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanClimbToGrapplePoint, "BmGame.RCwGrappleGunBase.CanClimbToGrapplePoint");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrappleLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallNormal, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_ClampToLineSegment;
    /// <summary>
    /// Function: ClampToLineSegment
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 ClampToLineSegment(System.Numerics.Vector3 P, System.Numerics.Vector3 A, System.Numerics.Vector3 B)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClampToLineSegment, "BmGame.RCwGrappleGunBase.ClampToLineSegment");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 36);
    }

    private static BmSDK.Function __fn_InitialWallCheck;
    /// <summary>
    /// Function: InitialWallCheck
    /// </summary>
    public unsafe virtual bool InitialWallCheck(System.Numerics.Vector3 WallLocation, System.Numerics.Vector3 WallNormal, System.Numerics.Vector3 Right, float OutTolerance, float InTolerance, System.Numerics.Vector3 TargetLocation, System.Numerics.Vector3 TargetWallLocation, in BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath NewPath, BmSDK.BmGame.RCwGrappleGunBase.EStartPoints StartCheck, bool bForcePounceCheck, out System.Numerics.Vector3 NewWallLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialWallCheck, "BmGame.RCwGrappleGunBase.InitialWallCheck");
        byte* paramsPtr = stackalloc byte[288];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Right, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutTolerance, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTolerance, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetWallLocation, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPath, paramsPtr + 68);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartCheck, paramsPtr + 248);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForcePounceCheck, paramsPtr + 252);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NewWallLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWallLocation, paramsPtr + 256);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        NewWallLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 256);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 268);
    }

    private static BmSDK.Function __fn_CreateClimbRoute;
    /// <summary>
    /// Function: CreateClimbRoute
    /// </summary>
    public unsafe virtual bool CreateClimbRoute(out BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc, bool bPersistent = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateClimbRoute, "BmGame.RCwGrappleGunBase.CreateClimbRoute");
        byte* paramsPtr = stackalloc byte[136];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistent, paramsPtr + 112);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 116);
    }

    private static BmSDK.Function __fn_CheckPounceToGrapple;
    /// <summary>
    /// Function: CheckPounceToGrapple
    /// </summary>
    public unsafe virtual bool CheckPounceToGrapple(System.Numerics.Vector3 TargetLoc, System.Numerics.Vector3 WallNormal, System.Numerics.Vector3 PlayerLoc, bool bDrawDebug = default, bool bDrawPersistent = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckPounceToGrapple, "BmGame.RCwGrappleGunBase.CheckPounceToGrapple");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLoc, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawDebug, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawPersistent, paramsPtr + 40);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 44);
    }

    private static BmSDK.Function __fn_InitialPathCheck;
    /// <summary>
    /// Function: InitialPathCheck
    /// </summary>
    public unsafe virtual bool InitialPathCheck(in BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath NewPath, System.Numerics.Vector3 TargetLocation, System.Numerics.Vector3 TargetWallLocation, System.Numerics.Vector3 WallLocation, System.Numerics.Vector3 WallNormal, System.Numerics.Vector3 CheckExtent, bool bLimitCheckToPlane)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialPathCheck, "BmGame.RCwGrappleGunBase.InitialPathCheck");
        byte* paramsPtr = stackalloc byte[264];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPath, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 180);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetWallLocation, paramsPtr + 192);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLocation, paramsPtr + 204);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallNormal, paramsPtr + 216);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckExtent, paramsPtr + 228);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLimitCheckToPlane, paramsPtr + 240);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 244);
    }

    private static BmSDK.Function __fn_CheckPounceToWall;
    /// <summary>
    /// Function: CheckPounceToWall
    /// </summary>
    public unsafe virtual bool CheckPounceToWall(System.Numerics.Vector3 WallLoc, System.Numerics.Vector3 WallNormal, System.Numerics.Vector3 PlayerLoc, bool bLimitCheckToPlane, bool bDrawDebug = default, bool bDrawPersistent = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckPounceToWall, "BmGame.RCwGrappleGunBase.CheckPounceToWall");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLoc, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLimitCheckToPlane, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawDebug, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawPersistent, paramsPtr + 44);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_GetBestWallClimbIndex;
    /// <summary>
    /// Function: GetBestWallClimbIndex
    /// </summary>
    public unsafe virtual int GetBestWallClimbIndex(System.Numerics.Vector3 EndLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBestWallClimbIndex, "BmGame.RCwGrappleGunBase.GetBestWallClimbIndex");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLocation, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetAerialSwingGrappleTarget;
    /// <summary>
    /// Function: GetAerialSwingGrappleTarget
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAerialSwingGrappleTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAerialSwingGrappleTarget, "BmGame.RCwGrappleGunBase.GetAerialSwingGrappleTarget");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetAerialSwingTargetNormal;
    /// <summary>
    /// Function: GetAerialSwingTargetNormal
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAerialSwingTargetNormal(BmSDK.BmGame.RGrapplePoint NewGrapplePoint = default, System.Numerics.Vector3 TargetLocation = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAerialSwingTargetNormal, "BmGame.RCwGrappleGunBase.GetAerialSwingTargetNormal");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGrapplePoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetAerialSwingTargetLocation;
    /// <summary>
    /// Function: GetAerialSwingTargetLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAerialSwingTargetLocation(bool bOnlyEstimate = default, bool bOnWall = default, bool bDebugDraw = default, bool bDrawPersistent = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAerialSwingTargetLocation, "BmGame.RCwGrappleGunBase.GetAerialSwingTargetLocation");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyEstimate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnWall, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawPersistent, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetAerialSwingEstimatedTarget;
    /// <summary>
    /// Function: GetAerialSwingEstimatedTarget
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAerialSwingEstimatedTarget(BmSDK.BmGame.RGrapplePoint NewGrapplePoint = default, System.Numerics.Vector3 TargetLocation = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAerialSwingEstimatedTarget, "BmGame.RCwGrappleGunBase.GetAerialSwingEstimatedTarget");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGrapplePoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetIdealSwingParameters;
    /// <summary>
    /// Function: GetIdealSwingParameters
    /// </summary>
    public unsafe virtual void GetIdealSwingParameters(System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 EndLocation, System.Numerics.Vector3 WallLocation, out float IdealSwingTime, out float IdealSwingLength)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetIdealSwingParameters, "BmGame.RCwGrappleGunBase.GetIdealSwingParameters");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLocation, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out IdealSwingTime);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IdealSwingTime, paramsPtr + 36);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out IdealSwingLength);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IdealSwingLength, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        IdealSwingTime = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 36);
        IdealSwingLength = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 40);
        return;
    }

    private static BmSDK.Function __fn_GetAerialSwingWallEndParams;
    /// <summary>
    /// Function: GetAerialSwingWallEndParams
    /// </summary>
    public unsafe virtual bool GetAerialSwingWallEndParams(out System.Numerics.Vector3 PlayerLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAerialSwingWallEndParams, "BmGame.RCwGrappleGunBase.GetAerialSwingWallEndParams");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PlayerLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLocation, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PlayerLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetAerialSwingEndParams;
    /// <summary>
    /// Function: GetAerialSwingEndParams
    /// </summary>
    public unsafe virtual void GetAerialSwingEndParams(out System.Numerics.Vector3 PlayerLocation, bool bOnlyEstimate = default, bool bDebugDraw = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAerialSwingEndParams, "BmGame.RCwGrappleGunBase.GetAerialSwingEndParams");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PlayerLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyEstimate, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PlayerLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetAerialSwingStartParams;
    /// <summary>
    /// Function: GetAerialSwingStartParams
    /// </summary>
    public unsafe virtual bool GetAerialSwingStartParams(out System.Numerics.Vector3 Origin, out System.Numerics.Vector3 StartVelocity, out float StartTime, bool bDrawDebug)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAerialSwingStartParams, "BmGame.RCwGrappleGunBase.GetAerialSwingStartParams");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Origin);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Origin, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StartVelocity);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartVelocity, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StartTime);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartTime, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawDebug, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Origin = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        StartVelocity = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        StartTime = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_IsValidClimbStartPoint;
    /// <summary>
    /// Function: IsValidClimbStartPoint
    /// </summary>
    public unsafe virtual bool IsValidClimbStartPoint(in BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath CheckPath, bool bNewPath = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidClimbStartPoint, "BmGame.RCwGrappleGunBase.IsValidClimbStartPoint");
        byte* paramsPtr = stackalloc byte[204];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckPath, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewPath, paramsPtr + 180);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 184);
    }

    private static BmSDK.Function __fn_GetEdgeSwingGrappleTarget;
    /// <summary>
    /// Function: GetEdgeSwingGrappleTarget
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetEdgeSwingGrappleTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEdgeSwingGrappleTarget, "BmGame.RCwGrappleGunBase.GetEdgeSwingGrappleTarget");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetEdgeSwingGrappleTargetingParams;
    /// <summary>
    /// Function: GetEdgeSwingGrappleTargetingParams
    /// </summary>
    public unsafe virtual void GetEdgeSwingGrappleTargetingParams(out System.Numerics.Vector3 Origin, out BmSDK.Rotator AimDirection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEdgeSwingGrappleTargetingParams, "BmGame.RCwGrappleGunBase.GetEdgeSwingGrappleTargetingParams");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Origin);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Origin, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out AimDirection);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimDirection, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Origin = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        AimDirection = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetEdgeSwingWallLocation;
    /// <summary>
    /// Function: GetEdgeSwingWallLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetEdgeSwingWallLocation(out System.Numerics.Vector3 WallNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEdgeSwingWallLocation, "BmGame.RCwGrappleGunBase.GetEdgeSwingWallLocation");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out WallNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallNormal, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        WallNormal = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetEdgeSwingWallEndParams;
    /// <summary>
    /// Function: GetEdgeSwingWallEndParams
    /// </summary>
    public unsafe virtual void GetEdgeSwingWallEndParams(out System.Numerics.Vector3 PlayerLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEdgeSwingWallEndParams, "BmGame.RCwGrappleGunBase.GetEdgeSwingWallEndParams");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PlayerLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLocation, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PlayerLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetEdgeSwingEndParams;
    /// <summary>
    /// Function: GetEdgeSwingEndParams
    /// </summary>
    public unsafe virtual void GetEdgeSwingEndParams(out System.Numerics.Vector3 PlayerLocation, bool bOnlyEstimate = default, bool bDebugDraw = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEdgeSwingEndParams, "BmGame.RCwGrappleGunBase.GetEdgeSwingEndParams");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PlayerLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyEstimate, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PlayerLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetEdgeSwingTargetNormal;
    /// <summary>
    /// Function: GetEdgeSwingTargetNormal
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetEdgeSwingTargetNormal(BmSDK.BmGame.RGrapplePoint NewGrapplePoint = default, System.Numerics.Vector3 TargetLocation = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEdgeSwingTargetNormal, "BmGame.RCwGrappleGunBase.GetEdgeSwingTargetNormal");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGrapplePoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetEdgeSwingTargetLocation;
    /// <summary>
    /// Function: GetEdgeSwingTargetLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetEdgeSwingTargetLocation(bool bOnlyEstimate = default, bool bOnWall = default, bool bDebugDraw = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEdgeSwingTargetLocation, "BmGame.RCwGrappleGunBase.GetEdgeSwingTargetLocation");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyEstimate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnWall, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetEdgeSwingEstimatedTarget;
    /// <summary>
    /// Function: GetEdgeSwingEstimatedTarget
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetEdgeSwingEstimatedTarget(BmSDK.BmGame.RGrapplePoint NewGrapplePoint = default, System.Numerics.Vector3 TargetLocation = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEdgeSwingEstimatedTarget, "BmGame.RCwGrappleGunBase.GetEdgeSwingEstimatedTarget");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGrapplePoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_GetEdgeSwingStartParams;
    /// <summary>
    /// Function: GetEdgeSwingStartParams
    /// </summary>
    public unsafe virtual bool GetEdgeSwingStartParams(out System.Numerics.Vector3 Origin, out System.Numerics.Vector3 StartVelocity, out float StartTime, bool bDrawDebug)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEdgeSwingStartParams, "BmGame.RCwGrappleGunBase.GetEdgeSwingStartParams");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Origin);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Origin, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StartVelocity);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartVelocity, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out StartTime);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartTime, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawDebug, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Origin = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        StartVelocity = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        StartTime = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_IsWallClimbStartInDirectPounceRange;
    /// <summary>
    /// Function: IsWallClimbStartInDirectPounceRange
    /// </summary>
    public unsafe virtual bool IsWallClimbStartInDirectPounceRange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsWallClimbStartInDirectPounceRange, "BmGame.RCwGrappleGunBase.IsWallClimbStartInDirectPounceRange");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsHidePointInClimbDistance;
    /// <summary>
    /// Function: IsHidePointInClimbDistance
    /// </summary>
    public unsafe virtual bool IsHidePointInClimbDistance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsHidePointInClimbDistance, "BmGame.RCwGrappleGunBase.IsHidePointInClimbDistance");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsHidePointInPounceDistance;
    /// <summary>
    /// Function: IsHidePointInPounceDistance
    /// </summary>
    public unsafe virtual bool IsHidePointInPounceDistance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsHidePointInPounceDistance, "BmGame.RCwGrappleGunBase.IsHidePointInPounceDistance");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsGrapplePointInClimbDistance;
    /// <summary>
    /// Function: IsGrapplePointInClimbDistance
    /// </summary>
    public unsafe virtual bool IsGrapplePointInClimbDistance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsGrapplePointInClimbDistance, "BmGame.RCwGrappleGunBase.IsGrapplePointInClimbDistance");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsGrapplePointInPounceDistance;
    /// <summary>
    /// Function: IsGrapplePointInPounceDistance
    /// </summary>
    public unsafe virtual bool IsGrapplePointInPounceDistance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsGrapplePointInPounceDistance, "BmGame.RCwGrappleGunBase.IsGrapplePointInPounceDistance");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TraceGroundPath;
    /// <summary>
    /// Function: TraceGroundPath
    /// </summary>
    public unsafe virtual bool TraceGroundPath(System.Numerics.Vector3 Start, System.Numerics.Vector3 End, System.Numerics.Vector3 DirXY, int Steps, float HeightTolerance, bool bDebugExtraPounce = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TraceGroundPath, "BmGame.RCwGrappleGunBase.TraceGroundPath");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DirXY, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Steps, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HeightTolerance, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugExtraPounce, paramsPtr + 44);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_TraceGround;
    /// <summary>
    /// Function: TraceGround
    /// </summary>
    public unsafe virtual bool TraceGround(out System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Direction, in BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc, bool bDebugExtraPounce)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TraceGround, "BmGame.RCwGrappleGunBase.TraceGround");
        byte* paramsPtr = stackalloc byte[160];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugExtraPounce, paramsPtr + 136);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HitLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 140);
    }

    private static BmSDK.Function __fn_CanLongPounce;
    /// <summary>
    /// Function: CanLongPounce
    /// </summary>
    public unsafe virtual bool CanLongPounce(out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo Info, bool bHideOrGrapplePoint, System.Numerics.Vector3 WallLocation, out BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc, bool bDebugLongPounce = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanLongPounce, "BmGame.RCwGrappleGunBase.CanLongPounce");
        byte* paramsPtr = stackalloc byte[1136];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHideOrGrapplePoint, paramsPtr + 984);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLocation, paramsPtr + 988);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 1000);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugLongPounce, paramsPtr + 1112);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Info = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(paramsPtr + 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(paramsPtr + 1000);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 1116);
    }

    private static BmSDK.Function __fn_CheckLongPounceFloor;
    /// <summary>
    /// Function: CheckLongPounceFloor
    /// </summary>
    public unsafe virtual bool CheckLongPounceFloor(out BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc, System.Numerics.Vector3 WallLocation, System.Numerics.Vector3 WallNormal, bool bDebugDraw = default, bool bDebugLongPounce = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckLongPounceFloor, "BmGame.RCwGrappleGunBase.CheckLongPounceFloor");
        byte* paramsPtr = stackalloc byte[164];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLocation, paramsPtr + 112);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallNormal, paramsPtr + 124);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 136);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugLongPounce, paramsPtr + 140);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 144);
    }

    private static BmSDK.Function __fn_IsLongPounceDist;
    /// <summary>
    /// Function: IsLongPounceDist
    /// </summary>
    public unsafe virtual bool IsLongPounceDist(System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 WallLocation, bool bDirectPounceCheck = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLongPounceDist, "BmGame.RCwGrappleGunBase.IsLongPounceDist");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDirectPounceCheck, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_CheckAerialSwing;
    /// <summary>
    /// Function: CheckAerialSwing
    /// </summary>
    public unsafe virtual bool CheckAerialSwing()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckAerialSwing, "BmGame.RCwGrappleGunBase.CheckAerialSwing");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckAerialSwingCollision;
    /// <summary>
    /// Function: CheckAerialSwingCollision
    /// </summary>
    public unsafe virtual bool CheckAerialSwingCollision(out System.Numerics.Vector3 FirstHitLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckAerialSwingCollision, "BmGame.RCwGrappleGunBase.CheckAerialSwingCollision");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out FirstHitLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FirstHitLocation, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        FirstHitLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CheckEdgeSwingCollision;
    /// <summary>
    /// Function: CheckEdgeSwingCollision
    /// </summary>
    public unsafe virtual bool CheckEdgeSwingCollision(out System.Numerics.Vector3 FirstHitLocation, bool bTryShortJump = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckEdgeSwingCollision, "BmGame.RCwGrappleGunBase.CheckEdgeSwingCollision");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out FirstHitLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FirstHitLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTryShortJump, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        FirstHitLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_UpdateInitialLocator;
    /// <summary>
    /// Function: UpdateInitialLocator
    /// </summary>
    public unsafe virtual bool UpdateInitialLocator(out BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc, out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath CheckPath, bool bNewPath = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateInitialLocator, "BmGame.RCwGrappleGunBase.UpdateInitialLocator");
        byte* paramsPtr = stackalloc byte[316];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewPath, paramsPtr + 292);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(paramsPtr + 0);
        CheckPath = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath>(paramsPtr + 112);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 296);
    }

    private static BmSDK.Function __fn_CheckSwingFromEdge;
    /// <summary>
    /// Function: CheckSwingFromEdge
    /// </summary>
    public unsafe virtual bool CheckSwingFromEdge()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckSwingFromEdge, "BmGame.RCwGrappleGunBase.CheckSwingFromEdge");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GotSwingTargetPoint;
    /// <summary>
    /// Function: GotSwingTargetPoint
    /// </summary>
    public unsafe virtual bool GotSwingTargetPoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotSwingTargetPoint, "BmGame.RCwGrappleGunBase.GotSwingTargetPoint");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GotEdgeSwingTargetPoint;
    /// <summary>
    /// Function: GotEdgeSwingTargetPoint
    /// </summary>
    public unsafe virtual bool GotEdgeSwingTargetPoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GotEdgeSwingTargetPoint, "BmGame.RCwGrappleGunBase.GotEdgeSwingTargetPoint");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsAutoSwingToGargoyle;
    /// <summary>
    /// Function: IsAutoSwingToGargoyle
    /// </summary>
    public unsafe virtual bool IsAutoSwingToGargoyle()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAutoSwingToGargoyle, "BmGame.RCwGrappleGunBase.IsAutoSwingToGargoyle");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsAutoSwing;
    /// <summary>
    /// Function: IsAutoSwing
    /// </summary>
    public unsafe virtual bool IsAutoSwing()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAutoSwing, "BmGame.RCwGrappleGunBase.IsAutoSwing");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CheckDelayedSwing;
    /// <summary>
    /// Function: CheckDelayedSwing
    /// </summary>
    public unsafe virtual bool CheckDelayedSwing()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckDelayedSwing, "BmGame.RCwGrappleGunBase.CheckDelayedSwing");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HandlePounceTargeting;
    /// <summary>
    /// Function: HandlePounceTargeting
    /// </summary>
    public unsafe virtual void HandlePounceTargeting(bool bGrappleCheck = default, int Iteration = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HandlePounceTargeting, "BmGame.RCwGrappleGunBase.HandlePounceTargeting");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGrappleCheck, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Iteration, paramsPtr + 4);
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

    private static BmSDK.Function __fn_UpdateSwingPaths;
    /// <summary>
    /// Function: UpdateSwingPaths
    /// </summary>
    public unsafe virtual bool UpdateSwingPaths()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateSwingPaths, "BmGame.RCwGrappleGunBase.UpdateSwingPaths");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SwingLineCheck;
    /// <summary>
    /// Function: SwingLineCheck
    /// </summary>
    public unsafe virtual bool SwingLineCheck(out System.Numerics.Vector3 HitLocation, out System.Numerics.Vector3 HitNormal, System.Numerics.Vector3 EndLocation, System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 CheckExtent, bool bStartWithPointCheck, bool bDrawDebug = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SwingLineCheck, "BmGame.RCwGrappleGunBase.SwingLineCheck");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLocation, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckExtent, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStartWithPointCheck, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawDebug, paramsPtr + 64);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HitLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        HitNormal = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 68);
    }

    private static BmSDK.Function __fn_GetJumpVelocity;
    /// <summary>
    /// Function: GetJumpVelocity
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetJumpVelocity(System.Numerics.Vector3 Direction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetJumpVelocity, "BmGame.RCwGrappleGunBase.GetJumpVelocity");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_UpdateFlightPath;
    /// <summary>
    /// Function: UpdateFlightPath
    /// </summary>
    public unsafe virtual void UpdateFlightPath(float DeltaTime, bool bModifyTranitionTime, bool bFirstFrame)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateFlightPath, "BmGame.RCwGrappleGunBase.UpdateFlightPath");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bModifyTranitionTime, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFirstFrame, paramsPtr + 8);
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

    private static BmSDK.Function __fn_GetFlightPathDeltaTangent;
    /// <summary>
    /// Function: GetFlightPathDeltaTangent
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetFlightPathDeltaTangent(out BmSDK.BmGame.RCwGrappleGunBase.FSwingParameters sp, float Proportion)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFlightPathDeltaTangent, "BmGame.RCwGrappleGunBase.GetFlightPathDeltaTangent");
        byte* paramsPtr = stackalloc byte[124];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out sp);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proportion, paramsPtr + 92);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        sp = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCwGrappleGunBase.FSwingParameters>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 96);
    }

    private static BmSDK.Function __fn_GetFlightPathTangent;
    /// <summary>
    /// Function: GetFlightPathTangent
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetFlightPathTangent(out BmSDK.BmGame.RCwGrappleGunBase.FSwingParameters sp, float Proportion)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFlightPathTangent, "BmGame.RCwGrappleGunBase.GetFlightPathTangent");
        byte* paramsPtr = stackalloc byte[124];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out sp);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proportion, paramsPtr + 92);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        sp = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCwGrappleGunBase.FSwingParameters>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 96);
    }

    private static BmSDK.Function __fn_GetFlightPathPosition;
    /// <summary>
    /// Function: GetFlightPathPosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetFlightPathPosition(out BmSDK.BmGame.RCwGrappleGunBase.FSwingParameters sp, float Proportion)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFlightPathPosition, "BmGame.RCwGrappleGunBase.GetFlightPathPosition");
        byte* paramsPtr = stackalloc byte[124];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out sp);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proportion, paramsPtr + 92);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        sp = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCwGrappleGunBase.FSwingParameters>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 96);
    }

    private static BmSDK.Function __fn_DrawSwingPath;
    /// <summary>
    /// Function: DrawSwingPath
    /// </summary>
    public unsafe virtual void DrawSwingPath(out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo ClimbInfo, bool bPersistent = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawSwingPath, "BmGame.RCwGrappleGunBase.DrawSwingPath");
        byte* paramsPtr = stackalloc byte[1004];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistent, paramsPtr + 984);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ClimbInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_CalculateSwingPath;
    /// <summary>
    /// Function: CalculateSwingPath
    /// </summary>
    public unsafe virtual bool CalculateSwingPath(out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo ClimbInfo, System.Numerics.Vector3 DesiredStartLocation, System.Numerics.Vector3 TargetLocation, System.Numerics.Vector3 StartVelocity, System.Numerics.Vector3 EndVelocity, float IdealSwingTime, float IdealSwingLength, float CheckSizeMod, out System.Numerics.Vector3 FirstHitLocation, bool bDebugDraw, bool bDrawPersistent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CalculateSwingPath, "BmGame.RCwGrappleGunBase.CalculateSwingPath");
        byte* paramsPtr = stackalloc byte[1084];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredStartLocation, paramsPtr + 984);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 996);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartVelocity, paramsPtr + 1008);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndVelocity, paramsPtr + 1020);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IdealSwingTime, paramsPtr + 1032);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IdealSwingLength, paramsPtr + 1036);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckSizeMod, paramsPtr + 1040);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out FirstHitLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FirstHitLocation, paramsPtr + 1044);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 1056);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawPersistent, paramsPtr + 1060);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ClimbInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(paramsPtr + 0);
        FirstHitLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 1044);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 1064);
    }

    /// <summary>
    /// Struct: FClimbLedges
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FClimbLedges
    {
        /// <summary>
        /// StructProperty: Location
        /// </summary>
        public unsafe System.Numerics.Vector3 Location
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Normal
        /// </summary>
        public unsafe System.Numerics.Vector3 Normal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bDangleLedge
        /// </summary>
        public unsafe bool bDangleLedge
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Enum: EClawClimbStartMode
    /// </summary>
    public enum EClawClimbStartMode : byte
    {
        CCSM_FromGround = 0,
        CCSM_FromWallStick = 1,
        CCSM_FromSwing = 2,
        CCSM_FromShortSwing = 3,
        CCSM_MAX = 4,
    }

    /// <summary>
    /// Struct: FWallClimbInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 984)]
    public partial record struct FWallClimbInfo
    {
        /// <summary>
        /// StructProperty: ClimbPath
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath ClimbPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bGotValidPath
        /// </summary>
        public unsafe bool bGotValidPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }; }
        }

        /// <summary>
        /// BoolProperty: bEdgeSwingCheckNewPath
        /// </summary>
        public unsafe bool bEdgeSwingCheckNewPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }; }
        }

        /// <summary>
        /// BoolProperty: bUsingFallbackPath
        /// </summary>
        public unsafe bool bUsingFallbackPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }; }
        }

        /// <summary>
        /// BoolProperty: bFromWallStick
        /// </summary>
        public unsafe bool bFromWallStick
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }; }
        }

        /// <summary>
        /// ByteProperty: LastFailedPreferedClimbPath
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection LastFailedPreferedClimbPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection>(Ptr + 184); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }; }
        }

        /// <summary>
        /// ByteProperty: LastFailedEdgeSwingPreferedClimbPath
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection LastFailedEdgeSwingPreferedClimbPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection>(Ptr + 185); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 185); }; }
        }

        /// <summary>
        /// ByteProperty: LastFailedAerialSwingPreferedClimbPath
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection LastFailedAerialSwingPreferedClimbPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection>(Ptr + 186); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 186); }; }
        }

        /// <summary>
        /// BoolProperty: bLastFailedDueToPounceDistance
        /// </summary>
        public unsafe bool bLastFailedDueToPounceDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 188); }; }
        }

        /// <summary>
        /// ByteProperty: LastFailReason
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.ClimbPathFailReason LastFailReason
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.ClimbPathFailReason>(Ptr + 192); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }; }
        }

        /// <summary>
        /// ByteProperty: LastSuccessfulPreferedClimbPath
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection LastSuccessfulPreferedClimbPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection>(Ptr + 193); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 193); }; }
        }

        /// <summary>
        /// ByteProperty: LastFailedStartPoint
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.EStartPoints LastFailedStartPoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.EStartPoints>(Ptr + 194); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 194); }; }
        }

        /// <summary>
        /// StructProperty: LastCheckedAerialSwingStart
        /// </summary>
        public unsafe System.Numerics.Vector3 LastCheckedAerialSwingStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 196); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }; }
        }

        /// <summary>
        /// StructProperty: InitialLocator
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator InitialLocator
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(Ptr + 208); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }; }
        }

        /// <summary>
        /// ObjectProperty: LastValidGrapplePoint
        /// </summary>
        public unsafe BmSDK.BmGame.RGrapplePoint LastValidGrapplePoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 320); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }; }
        }

        /// <summary>
        /// ObjectProperty: LastValidHidePoint
        /// </summary>
        public unsafe BmSDK.BmGame.RHidePoint LastValidHidePoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 324); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }; }
        }

        /// <summary>
        /// BoolProperty: bLastValidIsCeilingTarget
        /// </summary>
        public unsafe bool bLastValidIsCeilingTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 328); }; }
        }

        /// <summary>
        /// StructProperty: LastValidCeilingLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 LastValidCeilingLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 332); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }; }
        }

        /// <summary>
        /// StructProperty: WallNormal
        /// </summary>
        public unsafe System.Numerics.Vector3 WallNormal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 344); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }; }
        }

        /// <summary>
        /// StructProperty: LastTargetLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 LastTargetLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 356); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }; }
        }

        /// <summary>
        /// StructProperty: LastTargetWallLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 LastTargetWallLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 368); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }; }
        }

        /// <summary>
        /// StructProperty: LastMaxRight
        /// </summary>
        public unsafe System.Numerics.Vector3 LastMaxRight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 380); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }; }
        }

        /// <summary>
        /// StructProperty: LastMaxLeft
        /// </summary>
        public unsafe System.Numerics.Vector3 LastMaxLeft
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 392); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }; }
        }

        /// <summary>
        /// StructProperty: LastGrappleRight
        /// </summary>
        public unsafe System.Numerics.Vector3 LastGrappleRight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 404); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }; }
        }

        /// <summary>
        /// StructProperty: LastGrappleLeft
        /// </summary>
        public unsafe System.Numerics.Vector3 LastGrappleLeft
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 416); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }; }
        }

        /// <summary>
        /// BoolProperty: bLastExtremeRight
        /// </summary>
        public unsafe bool bLastExtremeRight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }; }
        }

        /// <summary>
        /// BoolProperty: bLastExtremeLeft
        /// </summary>
        public unsafe bool bLastExtremeLeft
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }; }
        }

        /// <summary>
        /// StructProperty: EdgeSwingLaunchLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 EdgeSwingLaunchLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 432); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }; }
        }

        /// <summary>
        /// BoolProperty: bEdgeSwingPointCheckFailed
        /// </summary>
        public unsafe bool bEdgeSwingPointCheckFailed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }; }
        }

        /// <summary>
        /// BoolProperty: bValidEdgeSwingTarget
        /// </summary>
        public unsafe bool bValidEdgeSwingTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }; }
        }

        /// <summary>
        /// BoolProperty: bAerialSwingPointCheckFailed
        /// </summary>
        public unsafe bool bAerialSwingPointCheckFailed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }; }
        }

        /// <summary>
        /// BoolProperty: bValidAerialSwingTarget
        /// </summary>
        public unsafe bool bValidAerialSwingTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }; }
        }

        /// <summary>
        /// BoolProperty: bValidDirectPounceTarget
        /// </summary>
        public unsafe bool bValidDirectPounceTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }; }
        }

        /// <summary>
        /// BoolProperty: bValidWallClimbTarget
        /// </summary>
        public unsafe bool bValidWallClimbTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }; }
        }

        /// <summary>
        /// BoolProperty: bValidCeilingTarget
        /// </summary>
        public unsafe bool bValidCeilingTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 64) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }; }
        }

        /// <summary>
        /// BoolProperty: bValidVantageSwingTarget
        /// </summary>
        public unsafe bool bValidVantageSwingTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 128) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }; }
        }

        /// <summary>
        /// StructProperty: AssociatedGrapplePoint
        /// </summary>
        public unsafe System.IntPtr AssociatedGrapplePoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 448); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }; }
        }

        /// <summary>
        /// FloatProperty: AssociatedBonusScore
        /// </summary>
        public unsafe float AssociatedBonusScore
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 452); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }; }
        }

        /// <summary>
        /// StructProperty: LockedExtendedEdgeSwingStart
        /// </summary>
        public unsafe System.Numerics.Vector3 LockedExtendedEdgeSwingStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 456); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }; }
        }

        /// <summary>
        /// StructProperty: LockedExtendedEdgeSwingWallLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 LockedExtendedEdgeSwingWallLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 468); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }; }
        }

        /// <summary>
        /// StructProperty: LockedExtendedAerialSwingStart
        /// </summary>
        public unsafe System.Numerics.Vector3 LockedExtendedAerialSwingStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 480); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }; }
        }

        /// <summary>
        /// StructProperty: PlayerStartLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 PlayerStartLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 492); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }; }
        }

        /// <summary>
        /// FloatProperty: SwingHeightOffset
        /// </summary>
        public unsafe float SwingHeightOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 504); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }; }
        }

        /// <summary>
        /// BoolProperty: bDebugNewPath
        /// </summary>
        public unsafe bool bDebugNewPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 508); }; }
        }

        /// <summary>
        /// StructProperty: InitialWallLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 InitialWallLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 512); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }; }
        }

        /// <summary>
        /// StructProperty: InitialLandLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 InitialLandLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 524); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }; }
        }

        /// <summary>
        /// StructProperty: SwingParams
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.FSwingParameters SwingParams
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FSwingParameters>(Ptr + 536); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }; }
        }

        /// <summary>
        /// StructProperty: LastFailedSwingLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 LastFailedSwingLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 628); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }; }
        }

        /// <summary>
        /// BoolProperty: bCheckedLPounceWall
        /// </summary>
        public unsafe bool bCheckedLPounceWall
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 640) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 640); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 640); }; }
        }

        /// <summary>
        /// BoolProperty: bFoundLPounceWall
        /// </summary>
        public unsafe bool bFoundLPounceWall
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 640) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 640); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 640); }; }
        }

        /// <summary>
        /// StructProperty: LPounceWallLocation
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator LPounceWallLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(Ptr + 644); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }; }
        }

        /// <summary>
        /// StructProperty: LastLPounceWallCheckPlayerLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 LastLPounceWallCheckPlayerLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 756); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }; }
        }

        /// <summary>
        /// BoolProperty: bFoundLPounceToTarget
        /// </summary>
        public unsafe bool bFoundLPounceToTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }; }
        }

        /// <summary>
        /// BoolProperty: bCheckedLPounceToTarget
        /// </summary>
        public unsafe bool bCheckedLPounceToTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }; }
        }

        /// <summary>
        /// StructProperty: LPounceToTargetLocation
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator LPounceToTargetLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(Ptr + 772); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }; }
        }

        /// <summary>
        /// StructProperty: LastLPounceTargetCheckPlayerLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 LastLPounceTargetCheckPlayerLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 884); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }; }
        }

        /// <summary>
        /// NameProperty: LastLPounceTargetCheckState
        /// </summary>
        public unsafe BmSDK.FName LastLPounceTargetCheckState
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 896); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }; }
        }

        /// <summary>
        /// IntProperty: ArrayIndex
        /// </summary>
        public unsafe int ArrayIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }; }
        }

        /// <summary>
        /// ObjectProperty: GrapplePoint
        /// </summary>
        public unsafe BmSDK.BmGame.RGrapplePoint GrapplePoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 908); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }; }
        }

        /// <summary>
        /// ObjectProperty: HidePoint
        /// </summary>
        public unsafe BmSDK.BmGame.RHidePoint HidePoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 912); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }; }
        }

        /// <summary>
        /// BoolProperty: bEdgeSwingPointNeedsCheck
        /// </summary>
        public unsafe bool bEdgeSwingPointNeedsCheck
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 916); }; }
        }

        /// <summary>
        /// BoolProperty: bEdgeSwingUseShortPounceOff
        /// </summary>
        public unsafe bool bEdgeSwingUseShortPounceOff
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 916); }; }
        }

        /// <summary>
        /// BoolProperty: bAerialSwingPointNeedsCheck
        /// </summary>
        public unsafe bool bAerialSwingPointNeedsCheck
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 916); }; }
        }

        /// <summary>
        /// BoolProperty: bLastSwingCheckWasShortSwing
        /// </summary>
        public unsafe bool bLastSwingCheckWasShortSwing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 916); }; }
        }

        /// <summary>
        /// StructProperty: DebugLastSwingStartLoc
        /// </summary>
        public unsafe System.Numerics.Vector3 DebugLastSwingStartLoc
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 920); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }; }
        }

        /// <summary>
        /// StructProperty: DebugLastSwingStartVel
        /// </summary>
        public unsafe System.Numerics.Vector3 DebugLastSwingStartVel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 932); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }; }
        }

        /// <summary>
        /// FloatProperty: SwingStartTime
        /// </summary>
        public unsafe float SwingStartTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 944); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }; }
        }

        /// <summary>
        /// IntProperty: PathRetries
        /// </summary>
        public unsafe int PathRetries
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }; }
        }

        /// <summary>
        /// IntProperty: PathRecalcs
        /// </summary>
        public unsafe int PathRecalcs
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }; }
        }

        /// <summary>
        /// StructProperty: ToGrappleLine
        /// </summary>
        public unsafe System.Numerics.Vector3 ToGrappleLine
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 956); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }; }
        }

        /// <summary>
        /// StructProperty: ToRight
        /// </summary>
        public unsafe System.Numerics.Vector3 ToRight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 968); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }; }
        }

        /// <summary>
        /// ObjectProperty: ClimbLocator
        /// </summary>
        public unsafe BmSDK.BmGame.RClimbLocator ClimbLocator
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RClimbLocator>(Ptr + 980); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }; }
        }
    }

    /// <summary>
    /// Struct: FSwingParameters
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 92)]
    public partial record struct FSwingParameters
    {
        /// <summary>
        /// StructProperty: SwingStartLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 SwingStartLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: SwingStartTangent
        /// </summary>
        public unsafe System.Numerics.Vector3 SwingStartTangent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: SwingEndLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 SwingEndLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: SwingEndTangent
        /// </summary>
        public unsafe System.Numerics.Vector3 SwingEndTangent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// StructProperty: SwingWallLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 SwingWallLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: SwingTime
        /// </summary>
        public unsafe float SwingTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// FloatProperty: OneOverSwingTime
        /// </summary>
        public unsafe float OneOverSwingTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// FloatProperty: ProportionAlongPath
        /// </summary>
        public unsafe float ProportionAlongPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// FloatProperty: ProportionAtAnimationStart
        /// </summary>
        public unsafe float ProportionAtAnimationStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// FloatProperty: IdealEndYaw
        /// </summary>
        public unsafe float IdealEndYaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// FloatProperty: IdealStartPitch
        /// </summary>
        public unsafe float IdealStartPitch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// FloatProperty: IdealEndPitch
        /// </summary>
        public unsafe float IdealEndPitch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// BoolProperty: bUsed
        /// </summary>
        public unsafe bool bUsed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 88); }; }
        }

        /// <summary>
        /// BoolProperty: bValid
        /// </summary>
        public unsafe bool bValid
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 88); }; }
        }
    }

    /// <summary>
    /// Enum: ClimbPathFailReason
    /// </summary>
    public enum ClimbPathFailReason : byte
    {
        CPFR_None = 0,
        CPFR_NoStartPoint = 1,
        CPFR_PouncesTooFar = 2,
        CPFR_ExceedingHorizontalPounce = 3,
        CPFR_MAX = 4,
    }

    /// <summary>
    /// Struct: FWallClimbPath
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 180)]
    public partial record struct FWallClimbPath
    {
        /// <summary>
        /// BoolProperty: bSearchedEdges
        /// </summary>
        public unsafe bool bSearchedEdges
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: ClimbPoints
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RCwGrappleGunBase.FWallLandPoint> ClimbPoints
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCwGrappleGunBase.FWallLandPoint>>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bClimbToVantagePoint
        /// </summary>
        public unsafe bool bClimbToVantagePoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }

        /// <summary>
        /// ObjectProperty: VantagePointActor
        /// </summary>
        public unsafe BmSDK.Engine.Actor VantagePointActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// BoolProperty: bClimbToCeiling
        /// </summary>
        public unsafe bool bClimbToCeiling
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: TargetLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 TargetLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// StructProperty: TargetNormal
        /// </summary>
        public unsafe System.Numerics.Vector3 TargetNormal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// StructProperty: OriginalPlayerLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 OriginalPlayerLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// StructProperty: TargetFeature
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator TargetFeature
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// FloatProperty: NumClimbSteps
        /// </summary>
        public unsafe float NumClimbSteps
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 176); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }; }
        }
    }

    /// <summary>
    /// Struct: FWallLandPoint
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 292)]
    public partial record struct FWallLandPoint
    {
        /// <summary>
        /// BoolProperty: bFoundEdge
        /// </summary>
        public unsafe bool bFoundEdge
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bDangleEdge
        /// </summary>
        public unsafe bool bDangleEdge
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Location
        /// </summary>
        public unsafe System.Numerics.Vector3 Location
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: OriginalLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 OriginalLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: OriginalNormal
        /// </summary>
        public unsafe System.Numerics.Vector3 OriginalNormal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// StructProperty: NextHoldLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 NextHoldLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// StructProperty: NextHoldNormal
        /// </summary>
        public unsafe System.Numerics.Vector3 NextHoldNormal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// BoolProperty: bGotAnyEdge
        /// </summary>
        public unsafe bool bGotAnyEdge
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }

        /// <summary>
        /// StructProperty: Normal
        /// </summary>
        public unsafe System.Numerics.Vector3 Normal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// ByteProperty: InDir
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection InDir
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// ByteProperty: OutDir
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection OutDir
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection>(Ptr + 81); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 81); }; }
        }

        /// <summary>
        /// StructProperty: CheckRefLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 CheckRefLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// StructProperty: CheckStart
        /// </summary>
        public unsafe System.Numerics.Vector3 CheckStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }

        /// <summary>
        /// StructProperty: CheckEnd
        /// </summary>
        public unsafe System.Numerics.Vector3 CheckEnd
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 108); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }; }
        }

        /// <summary>
        /// StructProperty: CheckExtent
        /// </summary>
        public unsafe System.Numerics.Vector3 CheckExtent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 120); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }; }
        }

        /// <summary>
        /// StructProperty: HitLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 HitLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 132); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }; }
        }

        /// <summary>
        /// StructProperty: FootCheckStart
        /// </summary>
        public unsafe System.Numerics.Vector3 FootCheckStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 144); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }; }
        }

        /// <summary>
        /// StructProperty: FootCheckEnd
        /// </summary>
        public unsafe System.Numerics.Vector3 FootCheckEnd
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 156); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }; }
        }

        /// <summary>
        /// StructProperty: FootCheckExtent
        /// </summary>
        public unsafe System.Numerics.Vector3 FootCheckExtent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 168); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }; }
        }

        /// <summary>
        /// StructProperty: FootHitLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 FootHitLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 180); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }; }
        }

        /// <summary>
        /// BoolProperty: FootCheckDone
        /// </summary>
        public unsafe bool FootCheckDone
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 192); }; }
        }

        /// <summary>
        /// BoolProperty: FootCheckFailed
        /// </summary>
        public unsafe bool FootCheckFailed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 192); }; }
        }

        /// <summary>
        /// StructProperty: SpotCheck
        /// </summary>
        public unsafe System.Numerics.Vector3 SpotCheck
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 196); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }; }
        }

        /// <summary>
        /// StructProperty: ToNextExtent
        /// </summary>
        public unsafe System.Numerics.Vector3 ToNextExtent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 208); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }; }
        }

        /// <summary>
        /// StructProperty: ToNextStart
        /// </summary>
        public unsafe System.Numerics.Vector3 ToNextStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 220); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }; }
        }

        /// <summary>
        /// StructProperty: ToNextEnd
        /// </summary>
        public unsafe System.Numerics.Vector3 ToNextEnd
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 232); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }; }
        }

        /// <summary>
        /// StructProperty: Spot2Check
        /// </summary>
        public unsafe System.Numerics.Vector3 Spot2Check
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 244); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }; }
        }

        /// <summary>
        /// StructProperty: ToNext2Extent
        /// </summary>
        public unsafe System.Numerics.Vector3 ToNext2Extent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 256); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }; }
        }

        /// <summary>
        /// StructProperty: ToNext2Start
        /// </summary>
        public unsafe System.Numerics.Vector3 ToNext2Start
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 268); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }; }
        }

        /// <summary>
        /// StructProperty: ToNext2End
        /// </summary>
        public unsafe System.Numerics.Vector3 ToNext2End
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 280); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }; }
        }
    }

    /// <summary>
    /// Enum: EStartPoints
    /// </summary>
    public enum EStartPoints : byte
    {
        START_NextToPlayer = 0,
        START_BelowTarget = 1,
        START_FarLeft = 2,
        START_FarRight = 3,
        START_Left = 4,
        START_Right = 5,
        START_VantageLeft = 6,
        START_VantageRight = 7,
        START_ClimbLocator = 8,
        START_ExtraPounceCheck = 9,
        START_Failed = 10,
        START_MAX = 11,
    }

    /// <summary>
    /// Enum: EClawClimbDirection
    /// </summary>
    public enum EClawClimbDirection : byte
    {
        CCD_Random = 0,
        CCD_Left = 1,
        CCD_Center = 2,
        CCD_Right = 3,
        CCD_None = 4,
        CCD_MAX = 5,
    }

    /// <summary>
    /// ObjectProperty: PounceToLedgeHangMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PounceToLedgeHangMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1896); }
    }

    /// <summary>
    /// ObjectProperty: PounceToLedgeDangleMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PounceToLedgeDangleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1900); }
    }

    /// <summary>
    /// ObjectProperty: PounceOntoRailingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PounceOntoRailingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1904); }
    }

    /// <summary>
    /// ObjectProperty: PounceToVantagePointMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PounceToVantagePointMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1908); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbStartMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbStartMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1912); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallLand
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallLand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1916); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallJumpOff
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallJumpOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1920); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallEndLedgeHang
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallEndLedgeHang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1924); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallEndLedgeDangle
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallEndLedgeDangle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1928); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallEndOverLedgeStand
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallEndOverLedgeStand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1932); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallEndOverLedgeRun
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallEndOverLedgeRun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1936); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallEndOverRailingStand
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallEndOverRailingStand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1940); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallEndOverRailingRun
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallEndOverRailingRun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1944); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallEndOnRailing
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallEndOnRailing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1948); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallEndVantagePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallEndVantagePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1952); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallEndCeiling
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallEndCeiling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1956); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounce
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig AerialWhipPounce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1960); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceFar
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig AerialWhipPounceFar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1964); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceClose
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig AerialWhipPounceClose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1968); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedClose
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedClose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 1972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1972); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedCloseSq
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedCloseSq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 1976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1976); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargeted
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargeted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 1980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1980); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedSq
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedSq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 1984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1984); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedFar
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedFar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 1988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1988); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedFarSq
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedFarSq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 1992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1992); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedCloseWallStick
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedCloseWallStick
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 1996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1996); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedCloseWallStickDangle
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedCloseWallStickDangle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 2000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2000); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 2004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2004); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 2008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2008); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedLeftFar
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedLeftFar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 2012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2012); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedRightFar
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedRightFar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 2016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2016); }
    }

    /// <summary>
    /// ObjectProperty: EdgeSwingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EdgeSwingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2020); }
    }

    /// <summary>
    /// ObjectProperty: EdgeSwingShortMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EdgeSwingShortMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2024); }
    }

    /// <summary>
    /// ObjectProperty: EdgeSwingShortFromStealthMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EdgeSwingShortFromStealthMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2028); }
    }

    /// <summary>
    /// ObjectProperty: EdgeSwingMoveWithAlignment
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EdgeSwingMoveWithAlignment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2032); }
    }

    /// <summary>
    /// ObjectProperty: EdgeSwingShortMoveWithAlignment
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EdgeSwingShortMoveWithAlignment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2036); }
    }

    /// <summary>
    /// ObjectProperty: EdgeSwingShortMoveWith180LAlignment
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EdgeSwingShortMoveWith180LAlignment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2040); }
    }

    /// <summary>
    /// ObjectProperty: EdgeSwingShortMoveWith180RAlignment
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EdgeSwingShortMoveWith180RAlignment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2044); }
    }

    /// <summary>
    /// FloatProperty: CamSwitchTime
    /// </summary>
    public unsafe float CamSwitchTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2048); }
    }

    /// <summary>
    /// FloatProperty: MaxWhipBoost2dRange
    /// </summary>
    public unsafe float MaxWhipBoost2dRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2052); }
    }

    /// <summary>
    /// BoolProperty: bDebugTargetModes
    /// </summary>
    public unsafe bool bDebugTargetModes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugSwingPath
    /// </summary>
    public unsafe bool bDebugSwingPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugWallClimb
    /// </summary>
    public unsafe bool bDebugWallClimb
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugWallClimbPersistent
    /// </summary>
    public unsafe bool bDebugWallClimbPersistent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawPath
    /// </summary>
    public unsafe bool bDebugDrawPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawPathPersistent
    /// </summary>
    public unsafe bool bDebugDrawPathPersistent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawPathPounces
    /// </summary>
    public unsafe bool bDebugDrawPathPounces
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawPathWallChecks
    /// </summary>
    public unsafe bool bDebugDrawPathWallChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawInitialTestPersistent
    /// </summary>
    public unsafe bool bDebugDrawInitialTestPersistent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawCeilingChecks
    /// </summary>
    public unsafe bool bDebugDrawCeilingChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugForcePathRecalculation
    /// </summary>
    public unsafe bool bDebugForcePathRecalculation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugForceFallbackPath
    /// </summary>
    public unsafe bool bDebugForceFallbackPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugEdgeSwing
    /// </summary>
    public unsafe bool bDebugEdgeSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugEdgeSwingLaunch
    /// </summary>
    public unsafe bool bDebugEdgeSwingLaunch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugEdgeSwingStartCheck
    /// </summary>
    public unsafe bool bDebugEdgeSwingStartCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugEdgeSwingSkipFinalPounceCheck
    /// </summary>
    public unsafe bool bDebugEdgeSwingSkipFinalPounceCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugSkipInitialSwingHitCheck
    /// </summary>
    public unsafe bool bDebugSkipInitialSwingHitCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugShortEdgeSwing
    /// </summary>
    public unsafe bool bDebugShortEdgeSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugAerialSwing
    /// </summary>
    public unsafe bool bDebugAerialSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugLongPounceIn
    /// </summary>
    public unsafe bool bDebugLongPounceIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugLongPounceInDirectPounce
    /// </summary>
    public unsafe bool bDebugLongPounceInDirectPounce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugLongPounceDraw
    /// </summary>
    public unsafe bool bDebugLongPounceDraw
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugInitialPounceToWall
    /// </summary>
    public unsafe bool bDebugInitialPounceToWall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugCheckWallStick
    /// </summary>
    public unsafe bool bDebugCheckWallStick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugSkipInitialPathTest
    /// </summary>
    public unsafe bool bDebugSkipInitialPathTest
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugSuppressGrapplePoints
    /// </summary>
    public unsafe bool bDebugSuppressGrapplePoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugDelayedSwing
    /// </summary>
    public unsafe bool bDebugDelayedSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugSwingStart
    /// </summary>
    public unsafe bool bDebugSwingStart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawLinkedHidePoints
    /// </summary>
    public unsafe bool bDebugDrawLinkedHidePoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugClimbLocators
    /// </summary>
    public unsafe bool bDebugClimbLocators
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugPounceTargetingIterations
    /// </summary>
    public unsafe bool bDebugPounceTargetingIterations
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bDebugLocatorChainAlignment
    /// </summary>
    public unsafe bool bDebugLocatorChainAlignment
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2056); }
    }

    /// <summary>
    /// BoolProperty: bEnableEdgeSwing
    /// </summary>
    public unsafe bool bEnableEdgeSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2060); }
    }

    /// <summary>
    /// BoolProperty: bEnableDelayedSwing
    /// </summary>
    public unsafe bool bEnableDelayedSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2060); }
    }

    /// <summary>
    /// BoolProperty: bAutoClimbFromWallStick
    /// </summary>
    public unsafe bool bAutoClimbFromWallStick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2060); }
    }

    /// <summary>
    /// BoolProperty: bClimbUseLookAt
    /// </summary>
    public unsafe bool bClimbUseLookAt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2060); }
    }

    /// <summary>
    /// BoolProperty: bClimbCamOverlay
    /// </summary>
    public unsafe bool bClimbCamOverlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2060); }
    }

    /// <summary>
    /// BoolProperty: bPawnAtSwingEdge
    /// </summary>
    public unsafe bool bPawnAtSwingEdge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2060); }
    }

    /// <summary>
    /// BoolProperty: bScaleLR
    /// </summary>
    public unsafe bool bScaleLR
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2060); }
    }

    /// <summary>
    /// BoolProperty: bScaleLRClampMin
    /// </summary>
    public unsafe bool bScaleLRClampMin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2060); }
    }

    /// <summary>
    /// BoolProperty: bScaleLRClampMax
    /// </summary>
    public unsafe bool bScaleLRClampMax
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2060); }
    }

    /// <summary>
    /// BoolProperty: bScaleUp
    /// </summary>
    public unsafe bool bScaleUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2060); }
    }

    /// <summary>
    /// BoolProperty: bClipLR
    /// </summary>
    public unsafe bool bClipLR
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2060); }
    }

    /// <summary>
    /// BoolProperty: bClipUp
    /// </summary>
    public unsafe bool bClipUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2060); }
    }

    /// <summary>
    /// BoolProperty: bFinalScaleLR
    /// </summary>
    public unsafe bool bFinalScaleLR
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2060); }
    }

    /// <summary>
    /// BoolProperty: bFinalScaleUp
    /// </summary>
    public unsafe bool bFinalScaleUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2060); }
    }

    /// <summary>
    /// BoolProperty: bFinalClipLR
    /// </summary>
    public unsafe bool bFinalClipLR
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2060); }
    }

    /// <summary>
    /// BoolProperty: bFinalClipUp
    /// </summary>
    public unsafe bool bFinalClipUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2060); }
    }

    /// <summary>
    /// BoolProperty: bOptimisePaths
    /// </summary>
    public unsafe bool bOptimisePaths
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2060); }
    }

    /// <summary>
    /// BoolProperty: bDebugVantageTrace
    /// </summary>
    public unsafe bool bDebugVantageTrace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2060); }
    }

    /// <summary>
    /// BoolProperty: bUseNewVantagePath
    /// </summary>
    public unsafe bool bUseNewVantagePath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2060); }
    }

    /// <summary>
    /// BoolProperty: bDebugForceHoldOntoLedge
    /// </summary>
    public unsafe bool bDebugForceHoldOntoLedge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2060); }
    }

    /// <summary>
    /// BoolProperty: bLastCeilingCheckResult
    /// </summary>
    public unsafe bool bLastCeilingCheckResult
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2060); }
    }

    /// <summary>
    /// BoolProperty: bTriggeredWhipImpactFX
    /// </summary>
    public unsafe bool bTriggeredWhipImpactFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2060); }
    }

    /// <summary>
    /// BoolProperty: bExtraPounceTargetIteration
    /// </summary>
    public unsafe bool bExtraPounceTargetIteration
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2060); }
    }

    /// <summary>
    /// BoolProperty: bEnableSwingParamsCaching
    /// </summary>
    public unsafe bool bEnableSwingParamsCaching
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2060); }
    }

    /// <summary>
    /// BoolProperty: bGASSPLastResult
    /// </summary>
    public unsafe bool bGASSPLastResult
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2060); }
    }

    /// <summary>
    /// FloatProperty: MinimumSwingTime
    /// </summary>
    public unsafe float MinimumSwingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2064); }
    }

    /// <summary>
    /// IntProperty: CurrentLandPointIndex
    /// </summary>
    public unsafe int CurrentLandPointIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2068); }
    }

    /// <summary>
    /// StructProperty: CurrentClimbInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo CurrentClimbInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(Ptr + 2072);

    /// <summary>
    /// StructProperty: LastClimbInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo LastClimbInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(Ptr + 3056);

    /// <summary>
    /// FloatProperty: LastClimbInfoTime
    /// </summary>
    public unsafe float LastClimbInfoTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4040); }
    }

    /// <summary>
    /// FloatProperty: LastClimbInfoDelay
    /// </summary>
    public unsafe float LastClimbInfoDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4044); }
    }

    /// <summary>
    /// ArrayProperty: WallClimbs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo> WallClimbs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>>(Ptr + 4048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4048); }
    }

    /// <summary>
    /// StructProperty: LastClimbLandLocator
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator LastClimbLandLocator
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(Ptr + 4060);

    /// <summary>
    /// StructProperty: LastWallLandLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastWallLandLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4172);

    /// <summary>
    /// FloatProperty: MaxDistanceToWall
    /// </summary>
    public unsafe float MaxDistanceToWall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4184); }
    }

    /// <summary>
    /// FloatProperty: MaxDistanceToWallDirectPounce
    /// </summary>
    public unsafe float MaxDistanceToWallDirectPounce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4188); }
    }

    /// <summary>
    /// FloatProperty: MaxDirectPounceDistance
    /// </summary>
    public unsafe float MaxDirectPounceDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4192); }
    }

    /// <summary>
    /// FloatProperty: MaxHDistanceToPouncePoints
    /// </summary>
    public unsafe float MaxHDistanceToPouncePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4196); }
    }

    /// <summary>
    /// FloatProperty: MaxPounceHeightToVantagePoints
    /// </summary>
    public unsafe float MaxPounceHeightToVantagePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4200); }
    }

    /// <summary>
    /// FloatProperty: MaxPounceHeightToVantagePointsHPH
    /// </summary>
    public unsafe float MaxPounceHeightToVantagePointsHPH
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4204); }
    }

    /// <summary>
    /// FloatProperty: MaxPounceHeightToLedges
    /// </summary>
    public unsafe float MaxPounceHeightToLedges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4208); }
    }

    /// <summary>
    /// FloatProperty: MinPounceHeightToLedges
    /// </summary>
    public unsafe float MinPounceHeightToLedges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4212); }
    }

    /// <summary>
    /// FloatProperty: MaxDistanceToWallDirectPounceHPH
    /// </summary>
    public unsafe float MaxDistanceToWallDirectPounceHPH
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4216); }
    }

    /// <summary>
    /// FloatProperty: MaxDirectPounceDistanceHPH
    /// </summary>
    public unsafe float MaxDirectPounceDistanceHPH
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4220); }
    }

    /// <summary>
    /// FloatProperty: MaxWallClimbCosRightAngle
    /// </summary>
    public unsafe float MaxWallClimbCosRightAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4224); }
    }

    /// <summary>
    /// FloatProperty: MinWallClimbMargin
    /// </summary>
    public unsafe float MinWallClimbMargin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4228); }
    }

    /// <summary>
    /// FloatProperty: MaxWallClimbWidth
    /// </summary>
    public unsafe float MaxWallClimbWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4232); }
    }

    /// <summary>
    /// FloatProperty: MaxHorizontalWallPounce
    /// </summary>
    public unsafe float MaxHorizontalWallPounce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4236); }
    }

    /// <summary>
    /// FloatProperty: GrappleTargetEdgeMaxCos
    /// </summary>
    public unsafe float GrappleTargetEdgeMaxCos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4240); }
    }

    /// <summary>
    /// FloatProperty: GrappleTargetNormalMaxCos
    /// </summary>
    public unsafe float GrappleTargetNormalMaxCos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4244); }
    }

    /// <summary>
    /// FloatProperty: VantagePathWidth
    /// </summary>
    public unsafe float VantagePathWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4248); }
    }

    /// <summary>
    /// FloatProperty: VantagePathWidthNew
    /// </summary>
    public unsafe float VantagePathWidthNew
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4252); }
    }

    /// <summary>
    /// FloatProperty: MaxEdgeToAerialDelayTime
    /// </summary>
    public unsafe float MaxEdgeToAerialDelayTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4256); }
    }

    /// <summary>
    /// FloatProperty: MaxAerialToAerialDelayTime
    /// </summary>
    public unsafe float MaxAerialToAerialDelayTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4260); }
    }

    /// <summary>
    /// ObjectProperty: OriginalGrapplePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint OriginalGrapplePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 4264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4264); }
    }

    /// <summary>
    /// ByteProperty: ClawClimbStartMode
    /// </summary>
    public unsafe BmSDK.BmGame.RCwGrappleGunBase.EClawClimbStartMode ClawClimbStartMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.EClawClimbStartMode>(Ptr + 4268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4268); }
    }

    /// <summary>
    /// FloatProperty: CamOverlayStrength
    /// </summary>
    public unsafe float CamOverlayStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4272); }
    }

    /// <summary>
    /// ObjectProperty: LockedEdgeSwingGrapplePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint LockedEdgeSwingGrapplePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 4276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4276); }
    }

    /// <summary>
    /// StructProperty: LockedEdgeSwingGrappleTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LockedEdgeSwingGrappleTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4280);

    /// <summary>
    /// ObjectProperty: LockedEdgeSwingHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint LockedEdgeSwingHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 4292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4292); }
    }

    /// <summary>
    /// StructProperty: EdgeSwingLaunchLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EdgeSwingLaunchLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4296);

    /// <summary>
    /// StructProperty: EdgeSwingStartLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EdgeSwingStartLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4308);

    /// <summary>
    /// StructProperty: EdgeSwingEndLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EdgeSwingEndLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4320);

    /// <summary>
    /// StructProperty: EdgeSwingWallLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EdgeSwingWallLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4332);

    /// <summary>
    /// StructProperty: EdgeSwingWallNormal
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EdgeSwingWallNormal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4344);

    /// <summary>
    /// ObjectProperty: EdgeSwingGrapplePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint EdgeSwingGrapplePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 4356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4356); }
    }

    /// <summary>
    /// StructProperty: EdgeSwingGrappleTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EdgeSwingGrappleTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4360);

    /// <summary>
    /// StructProperty: SwingLaunchVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SwingLaunchVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4372);

    /// <summary>
    /// StructProperty: SwingLaunchShortVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SwingLaunchShortVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4384);

    /// <summary>
    /// StructProperty: SwingLaunchOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SwingLaunchOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4396);

    /// <summary>
    /// StructProperty: SwingLaunchShortOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SwingLaunchShortOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4408);

    /// <summary>
    /// StructProperty: EdgeSwingLaunchCheckExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EdgeSwingLaunchCheckExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4420);

    /// <summary>
    /// FloatProperty: EdgeSwingLaunchCheckShift
    /// </summary>
    public unsafe float EdgeSwingLaunchCheckShift
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4432); }
    }

    /// <summary>
    /// FloatProperty: SwingStartIdealZTolerance
    /// </summary>
    public unsafe float SwingStartIdealZTolerance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4436); }
    }

    /// <summary>
    /// FloatProperty: SwingStartMaxZAbovePlayerTolerance
    /// </summary>
    public unsafe float SwingStartMaxZAbovePlayerTolerance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4440); }
    }

    /// <summary>
    /// FloatProperty: EdgeSwingGrappleTargetPitch
    /// </summary>
    public unsafe float EdgeSwingGrappleTargetPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4444); }
    }

    /// <summary>
    /// FloatProperty: EdgeSwingExtraFallFactor
    /// </summary>
    public unsafe float EdgeSwingExtraFallFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4448); }
    }

    /// <summary>
    /// FloatProperty: MinEdgeSwingDistance
    /// </summary>
    public unsafe float MinEdgeSwingDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4452); }
    }

    /// <summary>
    /// FloatProperty: MaxEdgeSwingTan
    /// </summary>
    public unsafe float MaxEdgeSwingTan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4456); }
    }

    /// <summary>
    /// FloatProperty: CloseSwingDistance
    /// </summary>
    public unsafe float CloseSwingDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4460); }
    }

    /// <summary>
    /// FloatProperty: MaxDistanceForAimedEdgeSwingGrapple
    /// </summary>
    public unsafe float MaxDistanceForAimedEdgeSwingGrapple
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4464); }
    }

    /// <summary>
    /// FloatProperty: MinSwingWallLandToGrappleDistance
    /// </summary>
    public unsafe float MinSwingWallLandToGrappleDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4468); }
    }

    /// <summary>
    /// FloatProperty: MinEdgeShortSwingHeight
    /// </summary>
    public unsafe float MinEdgeShortSwingHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4472); }
    }

    /// <summary>
    /// FloatProperty: EdgeShortSwingHDistThreshold
    /// </summary>
    public unsafe float EdgeShortSwingHDistThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4476); }
    }

    /// <summary>
    /// FloatProperty: ForceShortPounceOffHThreshold
    /// </summary>
    public unsafe float ForceShortPounceOffHThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4480); }
    }

    /// <summary>
    /// FloatProperty: ForceShortPounceOffZThreshold
    /// </summary>
    public unsafe float ForceShortPounceOffZThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4484); }
    }

    /// <summary>
    /// FloatProperty: MinAerialSwingDistance
    /// </summary>
    public unsafe float MinAerialSwingDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4488); }
    }

    /// <summary>
    /// FloatProperty: AerialSwingTargetCloseRange
    /// </summary>
    public unsafe float AerialSwingTargetCloseRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4492); }
    }

    /// <summary>
    /// FloatProperty: AerialSwingTargetMaxExtraDrop
    /// </summary>
    public unsafe float AerialSwingTargetMaxExtraDrop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4496); }
    }

    /// <summary>
    /// FloatProperty: AerialSwingTargetDropPerMs
    /// </summary>
    public unsafe float AerialSwingTargetDropPerMs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4500); }
    }

    /// <summary>
    /// FloatProperty: MaxSwingWallTargetHeight
    /// </summary>
    public unsafe float MaxSwingWallTargetHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4504); }
    }

    /// <summary>
    /// FloatProperty: MaxSwingHeightOffset
    /// </summary>
    public unsafe float MaxSwingHeightOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4508); }
    }

    /// <summary>
    /// FloatProperty: MinSwingHeightOffset
    /// </summary>
    public unsafe float MinSwingHeightOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4512); }
    }

    /// <summary>
    /// FloatProperty: ClimbStartPointExtraDistance
    /// </summary>
    public unsafe float ClimbStartPointExtraDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4516); }
    }

    /// <summary>
    /// StructProperty: SecondLastPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SecondLastPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4520);

    /// <summary>
    /// StructProperty: LastPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4532);

    /// <summary>
    /// FloatProperty: WallCheckOut
    /// </summary>
    public unsafe float WallCheckOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4544); }
    }

    /// <summary>
    /// FloatProperty: WallCheckIn
    /// </summary>
    public unsafe float WallCheckIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4548); }
    }

    /// <summary>
    /// FloatProperty: WallCheckInVantage
    /// </summary>
    public unsafe float WallCheckInVantage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4552); }
    }

    /// <summary>
    /// FloatProperty: MaxWallOut
    /// </summary>
    public unsafe float MaxWallOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4556); }
    }

    /// <summary>
    /// StructProperty: PlayerCheckExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PlayerCheckExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4560);

    /// <summary>
    /// StructProperty: WallCheckExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WallCheckExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4572);

    /// <summary>
    /// StructProperty: WallCheckShift
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WallCheckShift
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4584);

    /// <summary>
    /// StructProperty: WallFootCheckExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WallFootCheckExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4596);

    /// <summary>
    /// StructProperty: WallFootCheckShift
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WallFootCheckShift
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4608);

    /// <summary>
    /// FloatProperty: WallHandToFootCheckZDiff
    /// </summary>
    public unsafe float WallHandToFootCheckZDiff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4620); }
    }

    /// <summary>
    /// FloatProperty: WallHandsToFeetInTolerance
    /// </summary>
    public unsafe float WallHandsToFeetInTolerance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4624); }
    }

    /// <summary>
    /// FloatProperty: AlongWallCheckDistance
    /// </summary>
    public unsafe float AlongWallCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4628); }
    }

    /// <summary>
    /// FloatProperty: AlongWallExtraEndOutOfWallDist
    /// </summary>
    public unsafe float AlongWallExtraEndOutOfWallDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4632); }
    }

    /// <summary>
    /// FloatProperty: AlongWallExtraStartOutOfWallDist
    /// </summary>
    public unsafe float AlongWallExtraStartOutOfWallDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4636); }
    }

    /// <summary>
    /// FloatProperty: AlongWallExtraEndIntoWallDist
    /// </summary>
    public unsafe float AlongWallExtraEndIntoWallDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4640); }
    }

    /// <summary>
    /// FloatProperty: AlongWallExtraStartIntoWallDist
    /// </summary>
    public unsafe float AlongWallExtraStartIntoWallDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4644); }
    }

    /// <summary>
    /// FloatProperty: EdgeLocationCheckDistance
    /// </summary>
    public unsafe float EdgeLocationCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4648); }
    }

    /// <summary>
    /// FloatProperty: GrappleCheckOut
    /// </summary>
    public unsafe float GrappleCheckOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4652); }
    }

    /// <summary>
    /// StructProperty: PounceToGrappleCheckExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PounceToGrappleCheckExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4656);

    /// <summary>
    /// FloatProperty: MaxWallStickHidePointInDiff
    /// </summary>
    public unsafe float MaxWallStickHidePointInDiff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4668); }
    }

    /// <summary>
    /// FloatProperty: MaxWallStickHidePointOutDiff
    /// </summary>
    public unsafe float MaxWallStickHidePointOutDiff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4672); }
    }

    /// <summary>
    /// FloatProperty: MaxRunningEdgeSwingCheckRange
    /// </summary>
    public unsafe float MaxRunningEdgeSwingCheckRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4676); }
    }

    /// <summary>
    /// FloatProperty: MinRunningEdgeSwingCheckRange
    /// </summary>
    public unsafe float MinRunningEdgeSwingCheckRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4680); }
    }

    /// <summary>
    /// FloatProperty: MaxStandingEdgeSwingCheckRange
    /// </summary>
    public unsafe float MaxStandingEdgeSwingCheckRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4684); }
    }

    /// <summary>
    /// FloatProperty: MinStandingEdgeSwingCheckRange
    /// </summary>
    public unsafe float MinStandingEdgeSwingCheckRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4688); }
    }

    /// <summary>
    /// FloatProperty: EdgeSwingCheckRangeSteps
    /// </summary>
    public unsafe float EdgeSwingCheckRangeSteps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4692); }
    }

    /// <summary>
    /// ObjectProperty: WallClimbCamera
    /// </summary>
    public unsafe BmSDK.BmGame.RWallClimbCamera WallClimbCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWallClimbCamera>(Ptr + 4696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4696); }
    }

    /// <summary>
    /// FloatProperty: SwingJumpToWallPitch
    /// </summary>
    public unsafe float SwingJumpToWallPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4700); }
    }

    /// <summary>
    /// FloatProperty: SwingJumpToWallSpeed
    /// </summary>
    public unsafe float SwingJumpToWallSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4704); }
    }

    /// <summary>
    /// FloatProperty: FirstClimbStepToCeiling
    /// </summary>
    public unsafe float FirstClimbStepToCeiling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4708); }
    }

    /// <summary>
    /// StructProperty: CeilingSpaceCheckExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CeilingSpaceCheckExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4712);

    /// <summary>
    /// FloatProperty: CeilingTraceHeight
    /// </summary>
    public unsafe float CeilingTraceHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4724); }
    }

    /// <summary>
    /// FloatProperty: MinLRDist
    /// </summary>
    public unsafe float MinLRDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4728); }
    }

    /// <summary>
    /// FloatProperty: MaxLRDist
    /// </summary>
    public unsafe float MaxLRDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4732); }
    }

    /// <summary>
    /// FloatProperty: MinLRScale
    /// </summary>
    public unsafe float MinLRScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4736); }
    }

    /// <summary>
    /// FloatProperty: MaxLRScale
    /// </summary>
    public unsafe float MaxLRScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4740); }
    }

    /// <summary>
    /// FloatProperty: LRScale
    /// </summary>
    public unsafe float LRScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4744); }
    }

    /// <summary>
    /// FloatProperty: MinUpDist
    /// </summary>
    public unsafe float MinUpDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4748); }
    }

    /// <summary>
    /// FloatProperty: MaxUpDist
    /// </summary>
    public unsafe float MaxUpDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4752); }
    }

    /// <summary>
    /// FloatProperty: MinUpScale
    /// </summary>
    public unsafe float MinUpScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4756); }
    }

    /// <summary>
    /// FloatProperty: MaxUpScale
    /// </summary>
    public unsafe float MaxUpScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4760); }
    }

    /// <summary>
    /// FloatProperty: UpScale
    /// </summary>
    public unsafe float UpScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4764); }
    }

    /// <summary>
    /// FloatProperty: ClipLRIdealDist
    /// </summary>
    public unsafe float ClipLRIdealDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4768); }
    }

    /// <summary>
    /// FloatProperty: ClipLRPer100
    /// </summary>
    public unsafe float ClipLRPer100
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4772); }
    }

    /// <summary>
    /// FloatProperty: ClipLRMaxTime
    /// </summary>
    public unsafe float ClipLRMaxTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4776); }
    }

    /// <summary>
    /// FloatProperty: ClipUpIdealDist
    /// </summary>
    public unsafe float ClipUpIdealDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4780); }
    }

    /// <summary>
    /// FloatProperty: ClipUpPer100
    /// </summary>
    public unsafe float ClipUpPer100
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4784); }
    }

    /// <summary>
    /// FloatProperty: ClipUpMaxTime
    /// </summary>
    public unsafe float ClipUpMaxTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4788); }
    }

    /// <summary>
    /// FloatProperty: FinalMinLRDist
    /// </summary>
    public unsafe float FinalMinLRDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4792); }
    }

    /// <summary>
    /// FloatProperty: FinalMaxLRDist
    /// </summary>
    public unsafe float FinalMaxLRDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4796); }
    }

    /// <summary>
    /// FloatProperty: FinalMinLRScale
    /// </summary>
    public unsafe float FinalMinLRScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4800); }
    }

    /// <summary>
    /// FloatProperty: FinalMaxLRScale
    /// </summary>
    public unsafe float FinalMaxLRScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4804); }
    }

    /// <summary>
    /// FloatProperty: FinalLRScale
    /// </summary>
    public unsafe float FinalLRScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4808); }
    }

    /// <summary>
    /// FloatProperty: FinalMinUpDist
    /// </summary>
    public unsafe float FinalMinUpDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4812); }
    }

    /// <summary>
    /// FloatProperty: FinalMaxUpDist
    /// </summary>
    public unsafe float FinalMaxUpDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4816); }
    }

    /// <summary>
    /// FloatProperty: FinalMinUpScale
    /// </summary>
    public unsafe float FinalMinUpScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4820); }
    }

    /// <summary>
    /// FloatProperty: FinalMaxUpScale
    /// </summary>
    public unsafe float FinalMaxUpScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4824); }
    }

    /// <summary>
    /// FloatProperty: FinalUpScale
    /// </summary>
    public unsafe float FinalUpScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4828); }
    }

    /// <summary>
    /// FloatProperty: FinalClipLRIdealDist
    /// </summary>
    public unsafe float FinalClipLRIdealDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4832); }
    }

    /// <summary>
    /// FloatProperty: FinalClipLRPer100
    /// </summary>
    public unsafe float FinalClipLRPer100
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4836); }
    }

    /// <summary>
    /// FloatProperty: FinalClipLRMaxTime
    /// </summary>
    public unsafe float FinalClipLRMaxTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4840); }
    }

    /// <summary>
    /// FloatProperty: FinalClipUpIdealDist
    /// </summary>
    public unsafe float FinalClipUpIdealDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4844); }
    }

    /// <summary>
    /// FloatProperty: FinalClipUpPer100
    /// </summary>
    public unsafe float FinalClipUpPer100
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4848); }
    }

    /// <summary>
    /// FloatProperty: FinalClipUpMaxTime
    /// </summary>
    public unsafe float FinalClipUpMaxTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4852); }
    }

    /// <summary>
    /// FloatProperty: PounceDelay
    /// </summary>
    public unsafe float PounceDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4856); }
    }

    /// <summary>
    /// FloatProperty: EdgeVUpTolerancePercentage
    /// </summary>
    public unsafe float EdgeVUpTolerancePercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4860); }
    }

    /// <summary>
    /// FloatProperty: EdgeVDownTolerancePercentage
    /// </summary>
    public unsafe float EdgeVDownTolerancePercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4864); }
    }

    /// <summary>
    /// FloatProperty: MinEdgeVDistance
    /// </summary>
    public unsafe float MinEdgeVDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4868); }
    }

    /// <summary>
    /// FloatProperty: MaxAerialTargetingAngle
    /// </summary>
    public unsafe float MaxAerialTargetingAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4872); }
    }

    /// <summary>
    /// FloatProperty: VantageWallTraceSide
    /// </summary>
    public unsafe float VantageWallTraceSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4876); }
    }

    /// <summary>
    /// FloatProperty: VantageWallTraceDown
    /// </summary>
    public unsafe float VantageWallTraceDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4880); }
    }

    /// <summary>
    /// FloatProperty: VantageWallTraceOut
    /// </summary>
    public unsafe float VantageWallTraceOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4884); }
    }

    /// <summary>
    /// FloatProperty: VantageWallTraceIn
    /// </summary>
    public unsafe float VantageWallTraceIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4888); }
    }

    /// <summary>
    /// FloatProperty: VantagePathMinDistance
    /// </summary>
    public unsafe float VantagePathMinDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4892); }
    }

    /// <summary>
    /// StructProperty: LastCeilingCheckLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastCeilingCheckLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4896);

    /// <summary>
    /// ObjectProperty: LastCeilingClimbVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RCeilingClimbVolume LastCeilingClimbVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCeilingClimbVolume>(Ptr + 4908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4908); }
    }

    /// <summary>
    /// StructProperty: LastCeilingCheckTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastCeilingCheckTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4912);

    /// <summary>
    /// FloatProperty: LastCeilingCheckFrame
    /// </summary>
    public unsafe float LastCeilingCheckFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4924); }
    }

    /// <summary>
    /// StructProperty: InitialPounceToWallCheckExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 InitialPounceToWallCheckExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4928);

    /// <summary>
    /// IntProperty: NumPounceItersPerUpdate
    /// </summary>
    public unsafe int NumPounceItersPerUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4940); }
    }

    /// <summary>
    /// IntProperty: MaxPounceSingleLineChecks
    /// </summary>
    public unsafe int MaxPounceSingleLineChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4944); }
    }

    /// <summary>
    /// IntProperty: MaxPounceSingleLineChecksCoherency
    /// </summary>
    public unsafe int MaxPounceSingleLineChecksCoherency
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4948); }
    }

    /// <summary>
    /// IntProperty: MaxPounceSingleLineChecksLowPrio
    /// </summary>
    public unsafe int MaxPounceSingleLineChecksLowPrio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4952); }
    }

    /// <summary>
    /// IntProperty: MaxFullPounceIters
    /// </summary>
    public unsafe int MaxFullPounceIters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4956); }
    }

    /// <summary>
    /// IntProperty: PounceSingleLineChecks
    /// </summary>
    public unsafe int PounceSingleLineChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4960); }
    }

    /// <summary>
    /// IntProperty: PounceSingleLineChecksTotal
    /// </summary>
    public unsafe int PounceSingleLineChecksTotal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4964); }
    }

    /// <summary>
    /// FloatProperty: LastPounceSingleLineCheck
    /// </summary>
    public unsafe float LastPounceSingleLineCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4968); }
    }

    /// <summary>
    /// FloatProperty: SwingStartCheckTime
    /// </summary>
    public unsafe float SwingStartCheckTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4972); }
    }

    /// <summary>
    /// IntProperty: SwingStartCheckIterations
    /// </summary>
    public unsafe int SwingStartCheckIterations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4976); }
    }

    /// <summary>
    /// IntProperty: MaxSwingPathChecks
    /// </summary>
    public unsafe int MaxSwingPathChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4980); }
    }

    /// <summary>
    /// IntProperty: MinSwingPathChecks
    /// </summary>
    public unsafe int MinSwingPathChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4984); }
    }

    /// <summary>
    /// FloatProperty: SwingPathCheckUnits
    /// </summary>
    public unsafe float SwingPathCheckUnits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4988); }
    }

    /// <summary>
    /// IntProperty: SwingLineChecks
    /// </summary>
    public unsafe int SwingLineChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4992); }
    }

    /// <summary>
    /// IntProperty: SwingLineChecksTotal
    /// </summary>
    public unsafe int SwingLineChecksTotal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4996); }
    }

    /// <summary>
    /// FloatProperty: LastSwingLineCheck
    /// </summary>
    public unsafe float LastSwingLineCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5000); }
    }

    /// <summary>
    /// IntProperty: MaxSwingLineChecks
    /// </summary>
    public unsafe int MaxSwingLineChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5004); }
    }

    /// <summary>
    /// IntProperty: MaxSwingLineChecksCoherency
    /// </summary>
    public unsafe int MaxSwingLineChecksCoherency
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5008); }
    }

    /// <summary>
    /// IntProperty: MaxSwingLineChecksLowPrio
    /// </summary>
    public unsafe int MaxSwingLineChecksLowPrio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5012); }
    }

    /// <summary>
    /// ObjectProperty: LastPickedGrapplePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint LastPickedGrapplePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 5016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5016); }
    }

    /// <summary>
    /// ObjectProperty: LastPickedHidePoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor LastPickedHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 5020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5020); }
    }

    /// <summary>
    /// ObjectProperty: GASSPLastGrapplePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint GASSPLastGrapplePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 5024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5024); }
    }

    /// <summary>
    /// ObjectProperty: GASSPLastHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint GASSPLastHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 5028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5028); }
    }

    /// <summary>
    /// StructProperty: GASSPLastPlayerLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GASSPLastPlayerLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5032);

    /// <summary>
    /// StructProperty: GASSPLastPlayerVel
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GASSPLastPlayerVel
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5044);

    /// <summary>
    /// FloatProperty: GASSPLastSwingStartTime
    /// </summary>
    public unsafe float GASSPLastSwingStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5056); }
    }

    /// <summary>
    /// StructProperty: GASSPLastOrigin
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GASSPLastOrigin
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5060);

    /// <summary>
    /// StructProperty: GASSPLastStartVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GASSPLastStartVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5072);
}
