#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnPlayer<br/>
/// (size = 7056)
/// (flags = 144736438)
/// </summary>
public partial class RPawnPlayer : BmSDK.BmGame.RPawnPlayerCombat, BmSDK.BmGame.RBatarangableInterface, BmSDK.BmGame.RSpotableInterface, BmSDK.BmGame.GDXRayInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnPlayer", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnPlayer.
    /// </summary>
    public static RPawnPlayer DefaultObject => (RPawnPlayer)StaticClass().DefaultObject;

    internal RPawnPlayer() { }

    /// <summary>
    /// Constructs a new RPawnPlayer
    /// </summary>
    public RPawnPlayer(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayer(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayer>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayer>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayer>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayer>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayer>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayer>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayer>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayer>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_GetTeam;
    /// <summary>
    /// Function: GetTeam
    /// </summary>
    public unsafe override BmSDK.Engine.TeamInfo GetTeam()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTeam, "BmGame.RPawnPlayer.GetTeam");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.TeamInfo>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_BeingLocallySpectated;
    /// <summary>
    /// Function: BeingLocallySpectated
    /// </summary>
    public unsafe virtual bool BeingLocallySpectated()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeingLocallySpectated, "BmGame.RPawnPlayer.BeingLocallySpectated");
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

    private static BmSDK.Function __fn_StartGetUp;
    /// <summary>
    /// Function: StartGetUp
    /// </summary>
    public unsafe override void StartGetUp()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartGetUp, "BmGame.RPawnPlayer.StartGetUp");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetUpFromRagdoll;
    /// <summary>
    /// Function: GetUpFromRagdoll
    /// </summary>
    public unsafe override void GetUpFromRagdoll(BmSDK.FName TargetMovementStance, BmSDK.FName TargetWeaponStance, bool ForceGetup = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUpFromRagdoll, "BmGame.RPawnPlayer.GetUpFromRagdoll");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetMovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetWeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceGetup, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckGrabbed;
    /// <summary>
    /// Function: CheckGrabbed
    /// </summary>
    public unsafe virtual void CheckGrabbed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckGrabbed, "BmGame.RPawnPlayer.CheckGrabbed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LogStatsCharacterUsage;
    /// <summary>
    /// Function: LogStatsCharacterUsage
    /// </summary>
    public unsafe virtual void LogStatsCharacterUsage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogStatsCharacterUsage, "BmGame.RPawnPlayer.LogStatsCharacterUsage");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LogBeginCharacterUsage;
    /// <summary>
    /// Function: LogBeginCharacterUsage
    /// </summary>
    public unsafe virtual void LogBeginCharacterUsage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogBeginCharacterUsage, "BmGame.RPawnPlayer.LogBeginCharacterUsage");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LogStatsPlayerSpawn;
    /// <summary>
    /// Function: LogStatsPlayerSpawn
    /// </summary>
    public unsafe virtual void LogStatsPlayerSpawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogStatsPlayerSpawn, "BmGame.RPawnPlayer.LogStatsPlayerSpawn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LogDied;
    /// <summary>
    /// Function: LogDied
    /// </summary>
    public unsafe virtual void LogDied(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation, BmSDK.BmGame.RInventoryGadget EquippedGadget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogDied, "BmGame.RPawnPlayer.LogDied");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EquippedGadget, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LogStatsPlayerMove;
    /// <summary>
    /// Function: LogStatsPlayerMove
    /// </summary>
    public unsafe virtual void LogStatsPlayerMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LogStatsPlayerMove, "BmGame.RPawnPlayer.LogStatsPlayerMove");
        byte* paramsPtr = stackalloc byte[25];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_JustJumped;
    /// <summary>
    /// Function: JustJumped
    /// </summary>
    public unsafe virtual void JustJumped()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_JustJumped, "BmGame.RPawnPlayer.JustJumped");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckForFractureWall;
    /// <summary>
    /// Function: CheckForFractureWall
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RFractureWallBase CheckForFractureWall(System.Numerics.Vector3 CheckPos, System.Numerics.Vector3 CheckExtent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForFractureWall, "BmGame.RPawnPlayer.CheckForFractureWall");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckExtent, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RFractureWallBase>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_UpdatePunchFractureWalls;
    /// <summary>
    /// Function: UpdatePunchFractureWalls
    /// </summary>
    public unsafe virtual void UpdatePunchFractureWalls()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePunchFractureWalls, "BmGame.RPawnPlayer.UpdatePunchFractureWalls");
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RefreshClothingMaterials;
    /// <summary>
    /// Function: RefreshClothingMaterials
    /// </summary>
    public unsafe virtual void RefreshClothingMaterials()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RefreshClothingMaterials, "BmGame.RPawnPlayer.RefreshClothingMaterials");
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

    private static BmSDK.Function __fn_CanBeSeenByBatsForXray;
    /// <summary>
    /// Function: CanBeSeenByBatsForXray
    /// </summary>
    public unsafe virtual bool CanBeSeenByBatsForXray()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeSeenByBatsForXray, "BmGame.RPawnPlayer.CanBeSeenByBatsForXray");
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

    private static BmSDK.Function __fn_UpdateXrayVisibility;
    /// <summary>
    /// Function: UpdateXrayVisibility
    /// </summary>
    public unsafe virtual void UpdateXrayVisibility(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateXrayVisibility, "BmGame.RPawnPlayer.UpdateXrayVisibility");
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

    private static BmSDK.Function __fn_UpdatePropsVisibility;
    /// <summary>
    /// Function: UpdatePropsVisibility
    /// </summary>
    public unsafe virtual void UpdatePropsVisibility(float AlphaVal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePropsVisibility, "BmGame.RPawnPlayer.UpdatePropsVisibility");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AlphaVal, paramsPtr + 0);
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

    private static BmSDK.Function __fn_CreateTransparentSkeletalMesh;
    /// <summary>
    /// Function: CreateTransparentSkeletalMesh
    /// </summary>
    public unsafe virtual BmSDK.Engine.SkeletalMeshComponent CreateTransparentSkeletalMesh(BmSDK.Engine.SkeletalMesh SkeletalMesh, BmSDK.Engine.SkeletalMeshComponent ParentAnimComponent, BmSDK.Engine.MaterialInterface OverrideMaterial = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateTransparentSkeletalMesh, "BmGame.RPawnPlayer.CreateTransparentSkeletalMesh");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkeletalMesh, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParentAnimComponent, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideMaterial, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.SkeletalMeshComponent>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetXRayOpacitySkillBased;
    /// <summary>
    /// Function: SetXRayOpacitySkillBased
    /// </summary>
    public unsafe virtual void SetXRayOpacitySkillBased(bool bEnable)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetXRayOpacitySkillBased, "BmGame.RPawnPlayer.SetXRayOpacitySkillBased");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnable, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachXrayTransparentSkeletalMesh;
    /// <summary>
    /// Function: AttachXrayTransparentSkeletalMesh
    /// </summary>
    public unsafe virtual BmSDK.Engine.SkeletalMeshComponent AttachXrayTransparentSkeletalMesh(BmSDK.Engine.SkeletalMesh SkeletalMesh, BmSDK.Engine.SkeletalMeshComponent ParentAnimComponent, BmSDK.Engine.MaterialInterface OverrideMaterial = default, bool AllowOcclusion = default, System.Numerics.Vector3 NewScale = default, float translucencyPri = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachXrayTransparentSkeletalMesh, "BmGame.RPawnPlayer.AttachXrayTransparentSkeletalMesh");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkeletalMesh, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParentAnimComponent, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideMaterial, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AllowOcclusion, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewScale, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(translucencyPri, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.SkeletalMeshComponent>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_FrontBarrierIsEdge;
    /// <summary>
    /// Function: FrontBarrierIsEdge
    /// </summary>
    public unsafe virtual bool FrontBarrierIsEdge()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FrontBarrierIsEdge, "BmGame.RPawnPlayer.FrontBarrierIsEdge");
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

    private static BmSDK.Function __fn_HitByBatarang;
    /// <summary>
    /// Function: HitByBatarang
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat.DamageResult HitByBatarang(int Damage, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default, BmSDK.BmGame.RPawnCombat DamagePawn = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitByBatarang, "BmGame.RPawnPlayer.HitByBatarang");
        byte* paramsPtr = stackalloc byte[97];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamagePawn, paramsPtr + 76);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 80);
    }

    private static BmSDK.Function __fn_Destroyed;
    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Destroyed, "BmGame.RPawnPlayer.Destroyed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearIngoreCollision;
    /// <summary>
    /// Function: ClearIngoreCollision
    /// </summary>
    public unsafe virtual void ClearIngoreCollision()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearIngoreCollision, "BmGame.RPawnPlayer.ClearIngoreCollision");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetWantsToCrouch;
    /// <summary>
    /// Function: SetWantsToCrouch
    /// </summary>
    public unsafe virtual void SetWantsToCrouch(bool NewWantsToCrouch)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWantsToCrouch, "BmGame.RPawnPlayer.SetWantsToCrouch");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWantsToCrouch, paramsPtr + 0);
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

    private static BmSDK.Function __fn_OnBeginStateSpecialMove;
    /// <summary>
    /// Function: OnBeginStateSpecialMove
    /// </summary>
    public unsafe virtual void OnBeginStateSpecialMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnBeginStateSpecialMove, "BmGame.RPawnPlayer.OnBeginStateSpecialMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsInSpecialMove;
    /// <summary>
    /// Function: IsInSpecialMove
    /// </summary>
    public unsafe virtual bool IsInSpecialMove(BmSDK.BmGame.RSpecialMoveConfig Test)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInSpecialMove, "BmGame.RPawnPlayer.IsInSpecialMove");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Test, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetPostLadderPose;
    /// <summary>
    /// Function: GetPostLadderPose
    /// </summary>
    public unsafe virtual BmSDK.FName GetPostLadderPose()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPostLadderPose, "BmGame.RPawnPlayer.GetPostLadderPose");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPostLandPose;
    /// <summary>
    /// Function: GetPostLandPose
    /// </summary>
    public unsafe virtual BmSDK.FName GetPostLandPose()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPostLandPose, "BmGame.RPawnPlayer.GetPostLandPose");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCinematicModeMovementStance;
    /// <summary>
    /// Function: GetCinematicModeMovementStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetCinematicModeMovementStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCinematicModeMovementStance, "BmGame.RPawnPlayer.GetCinematicModeMovementStance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetWalkingModeMovementStance;
    /// <summary>
    /// Function: GetWalkingModeMovementStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetWalkingModeMovementStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWalkingModeMovementStance, "BmGame.RPawnPlayer.GetWalkingModeMovementStance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetStaticMeshBounds;
    /// <summary>
    /// Function: GetStaticMeshBounds
    /// </summary>
    public unsafe virtual BmSDK.GameObject.FBoxSphereBounds GetStaticMeshBounds(BmSDK.Engine.StaticMesh M)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetStaticMeshBounds, "BmGame.RPawnPlayer.GetStaticMeshBounds");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(M, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.GameObject.FBoxSphereBounds>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ResetSlippedCorner;
    /// <summary>
    /// Function: ResetSlippedCorner
    /// </summary>
    public unsafe virtual void ResetSlippedCorner()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetSlippedCorner, "BmGame.RPawnPlayer.ResetSlippedCorner");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanSpawnIceRaft;
    /// <summary>
    /// Function: CanSpawnIceRaft
    /// </summary>
    public unsafe virtual bool CanSpawnIceRaft(out System.Numerics.Vector3 NewLocation, System.Numerics.Vector3 RaftExtent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSpawnIceRaft, "BmGame.RPawnPlayer.CanSpawnIceRaft");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NewLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RaftExtent, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        NewLocation = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_CheckForExistingIceRafts;
    /// <summary>
    /// Function: CheckForExistingIceRafts
    /// </summary>
    public unsafe virtual bool CheckForExistingIceRafts()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForExistingIceRafts, "BmGame.RPawnPlayer.CheckForExistingIceRafts");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RemoveIceRaft;
    /// <summary>
    /// Function: RemoveIceRaft
    /// </summary>
    public unsafe virtual void RemoveIceRaft(BmSDK.BmGame.RFloatingRaft raft)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveIceRaft, "BmGame.RPawnPlayer.RemoveIceRaft");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(raft, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddIceRaft;
    /// <summary>
    /// Function: AddIceRaft
    /// </summary>
    public unsafe virtual void AddIceRaft(BmSDK.BmGame.RFloatingRaft raft)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddIceRaft, "BmGame.RPawnPlayer.AddIceRaft");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(raft, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_JumpOffPawn;
    /// <summary>
    /// Function: JumpOffPawn
    /// </summary>
    public unsafe override void JumpOffPawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_JumpOffPawn, "BmGame.RPawnPlayer.JumpOffPawn");
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

    private static BmSDK.Function __fn_OnLevelChange;
    /// <summary>
    /// Function: OnLevelChange
    /// </summary>
    public unsafe virtual void OnLevelChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnLevelChange, "BmGame.RPawnPlayer.OnLevelChange");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InformCurrentRoomTwoThugsLeft;
    /// <summary>
    /// Function: InformCurrentRoomTwoThugsLeft
    /// </summary>
    public unsafe virtual void InformCurrentRoomTwoThugsLeft()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InformCurrentRoomTwoThugsLeft, "BmGame.RPawnPlayer.InformCurrentRoomTwoThugsLeft");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CantPullOffGrateLine;
    /// <summary>
    /// Function: CantPullOffGrateLine
    /// </summary>
    public unsafe virtual void CantPullOffGrateLine()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CantPullOffGrateLine, "BmGame.RPawnPlayer.CantPullOffGrateLine");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsRunning;
    /// <summary>
    /// Function: IsRunning
    /// </summary>
    public unsafe virtual bool IsRunning()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRunning, "BmGame.RPawnPlayer.IsRunning");
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

    private static BmSDK.Function __fn_OverrideAkComponentDefaults;
    /// <summary>
    /// Function: OverrideAkComponentDefaults
    /// </summary>
    public unsafe override void OverrideAkComponentDefaults(BmSDK.Engine.AkComponent akComp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideAkComponentDefaults, "BmGame.RPawnPlayer.OverrideAkComponentDefaults");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(akComp, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetTransitionFootStepPhaseAndTime;
    /// <summary>
    /// Function: GetTransitionFootStepPhaseAndTime
    /// </summary>
    public unsafe virtual bool GetTransitionFootStepPhaseAndTime(out BmSDK.BmGame.RAnimUtil.EFootSyncPoint CurrentFootStage, out float FootStageTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTransitionFootStepPhaseAndTime, "BmGame.RPawnPlayer.GetTransitionFootStepPhaseAndTime");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CurrentFootStage);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentFootStage, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out FootStageTime);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FootStageTime, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        CurrentFootStage = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.EFootSyncPoint>(paramsPtr + 0);
        FootStageTime = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetAimAssistTargetMoveType;
    /// <summary>
    /// Function: GetAimAssistTargetMoveType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnPlayer.EAimAssitanceTargetMove GetAimAssistTargetMoveType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAimAssistTargetMoveType, "BmGame.RPawnPlayer.GetAimAssistTargetMoveType");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayer.EAimAssitanceTargetMove>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PreBeginPlay;
    /// <summary>
    /// Function: PreBeginPlay
    /// </summary>
    public unsafe override void PreBeginPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PreBeginPlay, "BmGame.RPawnPlayer.PreBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyPawnGadgetsModifier;
    /// <summary>
    /// Function: ApplyPawnGadgetsModifier
    /// </summary>
    public unsafe virtual void ApplyPawnGadgetsModifier()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyPawnGadgetsModifier, "BmGame.RPawnPlayer.ApplyPawnGadgetsModifier");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDashRecoveryTimeInCover;
    /// <summary>
    /// Function: GetDashRecoveryTimeInCover
    /// </summary>
    public unsafe virtual float GetDashRecoveryTimeInCover()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDashRecoveryTimeInCover, "BmGame.RPawnPlayer.GetDashRecoveryTimeInCover");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetDashRecoveryTime;
    /// <summary>
    /// Function: GetDashRecoveryTime
    /// </summary>
    public unsafe virtual float GetDashRecoveryTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDashRecoveryTime, "BmGame.RPawnPlayer.GetDashRecoveryTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IncreaseHealthRegenModifier;
    /// <summary>
    /// Function: IncreaseHealthRegenModifier
    /// </summary>
    public unsafe virtual void IncreaseHealthRegenModifier(float fModifier)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncreaseHealthRegenModifier, "BmGame.RPawnPlayer.IncreaseHealthRegenModifier");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fModifier, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IncreaseDashModifier;
    /// <summary>
    /// Function: IncreaseDashModifier
    /// </summary>
    public unsafe virtual void IncreaseDashModifier(float fModifier)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncreaseDashModifier, "BmGame.RPawnPlayer.IncreaseDashModifier");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fModifier, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyPawnConfigModifier;
    /// <summary>
    /// Function: ApplyPawnConfigModifier
    /// </summary>
    public unsafe virtual void ApplyPawnConfigModifier()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyPawnConfigModifier, "BmGame.RPawnPlayer.ApplyPawnConfigModifier");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyPawnConfig;
    /// <summary>
    /// Function: ApplyPawnConfig
    /// </summary>
    public unsafe override void ApplyPawnConfig(BmSDK.BmGame.GDPawnConfig inPawnConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyPawnConfig, "BmGame.RPawnPlayer.ApplyPawnConfig");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inPawnConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetupPlayerMesh;
    /// <summary>
    /// Function: SetupPlayerMesh
    /// </summary>
    public unsafe virtual bool SetupPlayerMesh(bool InPlay)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupPlayerMesh, "BmGame.RPawnPlayer.SetupPlayerMesh");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_DynamicCreateNearbyRigidBodies;
    /// <summary>
    /// Function: DynamicCreateNearbyRigidBodies
    /// </summary>
    public unsafe virtual void DynamicCreateNearbyRigidBodies()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DynamicCreateNearbyRigidBodies, "BmGame.RPawnPlayer.DynamicCreateNearbyRigidBodies");
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

    private static BmSDK.Function __fn_ApplyMeshData;
    /// <summary>
    /// Function: ApplyMeshData
    /// </summary>
    public unsafe virtual void ApplyMeshData(BmSDK.BmGame.RAddContentPlayerCharacterMesh MeshData, bool InPlay, int Tier = default, int TierSubIndex = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyMeshData, "BmGame.RPawnPlayer.ApplyMeshData");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeshData, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPlay, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Tier, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TierSubIndex, paramsPtr + 12);
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

    private static BmSDK.Function __fn_GetPlayerConfig;
    /// <summary>
    /// Function: GetPlayerConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAddContentPlayerCharacter GetPlayerConfig(out BmSDK.BmGame.RAddContentPlayerCharacterMesh MeshData)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerConfig, "BmGame.RPawnPlayer.GetPlayerConfig");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MeshData);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeshData, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        MeshData = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAddContentPlayerCharacterMesh>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAddContentPlayerCharacter>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_InvestigateModeEyes;
    /// <summary>
    /// Function: InvestigateModeEyes
    /// </summary>
    public unsafe virtual void InvestigateModeEyes(bool bOnOrOff)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InvestigateModeEyes, "BmGame.RPawnPlayer.InvestigateModeEyes");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnOrOff, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBeSeenByHelicopter;
    /// <summary>
    /// Function: CanBeSeenByHelicopter
    /// </summary>
    public unsafe virtual bool CanBeSeenByHelicopter()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeSeenByHelicopter, "BmGame.RPawnPlayer.CanBeSeenByHelicopter");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetupSnowMaterials;
    /// <summary>
    /// Function: SetupSnowMaterials
    /// </summary>
    public unsafe virtual void SetupSnowMaterials()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupSnowMaterials, "BmGame.RPawnPlayer.SetupSnowMaterials");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetInferredTransitionReference;
    /// <summary>
    /// Function: GetInferredTransitionReference
    /// </summary>
    public unsafe static bool GetInferredTransitionReference(BmSDK.BmGame.RPawnCharacter Pawn, BmSDK.Engine.SkeletalMeshComponent SkelComp, out System.Numerics.Vector3 InferredReferencePointPosition, out BmSDK.Rotator InferredReferencePointRotation)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInferredTransitionReference, "BmGame.RPawnPlayer.GetInferredTransitionReference");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelComp, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out InferredReferencePointPosition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InferredReferencePointPosition, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out InferredReferencePointRotation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InferredReferencePointRotation, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        InferredReferencePointPosition = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
        InferredReferencePointRotation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_ClampLineSegmentToRange;
    /// <summary>
    /// Function: ClampLineSegmentToRange
    /// </summary>
    public unsafe virtual bool ClampLineSegmentToRange(System.Numerics.Vector3 PointA, System.Numerics.Vector3 PointB, System.Numerics.Vector3 CheckLocation, float Radius, out System.Numerics.Vector3 NewA, out System.Numerics.Vector3 NewB, bool bDebugClamp = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClampLineSegmentToRange, "BmGame.RPawnPlayer.ClampLineSegmentToRange");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointA, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointB, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckLocation, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 36);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NewA);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewA, paramsPtr + 40);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out NewB);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewB, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugClamp, paramsPtr + 64);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        NewA = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 40);
        NewB = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 52);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 68);
    }

    private static BmSDK.Function __fn_ClientConfirmInteractableItem;
    /// <summary>
    /// Function: ClientConfirmInteractableItem
    /// </summary>
    public unsafe virtual void ClientConfirmInteractableItem(BmSDK.Engine.Actor Item)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientConfirmInteractableItem, "BmGame.RPawnPlayer.ClientConfirmInteractableItem");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Item, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllowInteractableItem;
    /// <summary>
    /// Function: AllowInteractableItem
    /// </summary>
    public unsafe virtual bool AllowInteractableItem(BmSDK.BmGame.RInteractInterface InteractIface)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowInteractableItem, "BmGame.RPawnPlayer.AllowInteractableItem");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InteractIface, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_DieThisFrame;
    /// <summary>
    /// Function: DieThisFrame
    /// </summary>
    public unsafe virtual void DieThisFrame()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DieThisFrame, "BmGame.RPawnPlayer.DieThisFrame");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CantRunInDirectionTimeout;
    /// <summary>
    /// Function: CantRunInDirectionTimeout
    /// </summary>
    public unsafe virtual void CantRunInDirectionTimeout()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CantRunInDirectionTimeout, "BmGame.RPawnPlayer.CantRunInDirectionTimeout");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopRunInDirection;
    /// <summary>
    /// Function: StopRunInDirection
    /// </summary>
    public unsafe virtual void StopRunInDirection(System.Numerics.Vector3 Direction, float Time)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopRunInDirection, "BmGame.RPawnPlayer.StopRunInDirection");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddDefaultInventoryAfterInit;
    /// <summary>
    /// Function: AddDefaultInventoryAfterInit
    /// </summary>
    public unsafe virtual void AddDefaultInventoryAfterInit()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDefaultInventoryAfterInit, "BmGame.RPawnPlayer.AddDefaultInventoryAfterInit");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateGadgetVars;
    /// <summary>
    /// Function: UpdateGadgetVars
    /// </summary>
    public unsafe virtual void UpdateGadgetVars()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateGadgetVars, "BmGame.RPawnPlayer.UpdateGadgetVars");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateGadgetVar;
    /// <summary>
    /// Function: UpdateGadgetVar
    /// </summary>
    public unsafe virtual void UpdateGadgetVar(BmSDK.BmGame.RInventoryGadget NewGadget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateGadgetVar, "BmGame.RPawnPlayer.UpdateGadgetVar");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGadget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearInventory;
    /// <summary>
    /// Function: ClearInventory
    /// </summary>
    public unsafe virtual void ClearInventory()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearInventory, "BmGame.RPawnPlayer.ClearInventory");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddDefaultInventory;
    /// <summary>
    /// Function: AddDefaultInventory
    /// </summary>
    public unsafe override void AddDefaultInventory()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddDefaultInventory, "BmGame.RPawnPlayer.AddDefaultInventory");
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PointAndLineCheck;
    /// <summary>
    /// Function: PointAndLineCheck
    /// </summary>
    public unsafe virtual bool PointAndLineCheck(out System.Numerics.Vector3 HitLocation, out System.Numerics.Vector3 HitNormal, System.Numerics.Vector3 End, System.Numerics.Vector3 Start, System.Numerics.Vector3 Extent, int ExtraTraceFlags = default, bool bDebugDraw = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PointAndLineCheck, "BmGame.RPawnPlayer.PointAndLineCheck");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitLocation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraTraceFlags, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 64);
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

    private static BmSDK.Function __fn_GetFreeRotation;
    /// <summary>
    /// Function: GetFreeRotation
    /// </summary>
    public unsafe virtual BmSDK.Rotator GetFreeRotation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFreeRotation, "BmGame.RPawnPlayer.GetFreeRotation");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayGenericScreenShake;
    /// <summary>
    /// Function: PlayGenericScreenShake
    /// </summary>
    public unsafe virtual void PlayGenericScreenShake()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayGenericScreenShake, "BmGame.RPawnPlayer.PlayGenericScreenShake");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerHeatConcealEffect;
    /// <summary>
    /// Function: TriggerHeatConcealEffect
    /// </summary>
    public unsafe virtual void TriggerHeatConcealEffect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerHeatConcealEffect, "BmGame.RPawnPlayer.TriggerHeatConcealEffect");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearGargoyleMoveFlag;
    /// <summary>
    /// Function: ClearGargoyleMoveFlag
    /// </summary>
    public unsafe virtual void ClearGargoyleMoveFlag()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearGargoyleMoveFlag, "BmGame.RPawnPlayer.ClearGargoyleMoveFlag");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OverrideChangeRunningModeStance;
    /// <summary>
    /// Function: OverrideChangeRunningModeStance
    /// </summary>
    public unsafe virtual bool OverrideChangeRunningModeStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideChangeRunningModeStance, "BmGame.RPawnPlayer.OverrideChangeRunningModeStance");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OverrideChangeWalkingModeStance;
    /// <summary>
    /// Function: OverrideChangeWalkingModeStance
    /// </summary>
    public unsafe virtual bool OverrideChangeWalkingModeStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideChangeWalkingModeStance, "BmGame.RPawnPlayer.OverrideChangeWalkingModeStance");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_QuickThrowFailed;
    /// <summary>
    /// Function: QuickThrowFailed
    /// </summary>
    public unsafe virtual bool QuickThrowFailed(BmSDK.BmGame.RInventoryGadget Gadget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QuickThrowFailed, "BmGame.RPawnPlayer.QuickThrowFailed");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Gadget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AttackPressedInFallingState;
    /// <summary>
    /// Function: AttackPressedInFallingState
    /// </summary>
    public unsafe virtual void AttackPressedInFallingState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttackPressedInFallingState, "BmGame.RPawnPlayer.AttackPressedInFallingState");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriedToUseGadgetOnHostageTaker;
    /// <summary>
    /// Function: TriedToUseGadgetOnHostageTaker
    /// </summary>
    public unsafe virtual void TriedToUseGadgetOnHostageTaker()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriedToUseGadgetOnHostageTaker, "BmGame.RPawnPlayer.TriedToUseGadgetOnHostageTaker");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GiveUnlockableGadget;
    /// <summary>
    /// Function: GiveUnlockableGadget
    /// </summary>
    public unsafe virtual void GiveUnlockableGadget(BmSDK.FName UnlockName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveUnlockableGadget, "BmGame.RPawnPlayer.GiveUnlockableGadget");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnPossessed;
    /// <summary>
    /// Function: UnPossessed
    /// </summary>
    public unsafe override void UnPossessed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnPossessed, "BmGame.RPawnPlayer.UnPossessed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAudioEnvironment;
    /// <summary>
    /// Function: SetAudioEnvironment
    /// </summary>
    public unsafe override bool SetAudioEnvironment(BmSDK.TArray<BmSDK.Engine.AkWwise.FAkEnvironmentSettings> Environments, bool EnableEnvironments, float OcclusionMultiplier = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAudioEnvironment, "BmGame.RPawnPlayer.SetAudioEnvironment");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Environments, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnableEnvironments, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OcclusionMultiplier, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetFuturePosition;
    /// <summary>
    /// Function: GetFuturePosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetFuturePosition(System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 StartSpeed, float LookAheadTime, int NumIncrements, int IgnoreFirstNChecks, float minZ, out float FlightTimeToHit, out int IterationsToHit, out System.Numerics.Vector3 HitNormal, out System.Numerics.Vector3 EndVelocity, bool bDebugDraw)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFuturePosition, "BmGame.RPawnPlayer.GetFuturePosition");
        byte* paramsPtr = stackalloc byte[104];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartSpeed, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookAheadTime, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumIncrements, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IgnoreFirstNChecks, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(minZ, paramsPtr + 36);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out FlightTimeToHit);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlightTimeToHit, paramsPtr + 40);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out IterationsToHit);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IterationsToHit, paramsPtr + 44);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 48);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out EndVelocity);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndVelocity, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 72);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        FlightTimeToHit = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 40);
        IterationsToHit = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 44);
        HitNormal = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 48);
        EndVelocity = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 60);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 76);
    }

    private static BmSDK.Function __fn_GetFutureFallPosition;
    /// <summary>
    /// Function: GetFutureFallPosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetFutureFallPosition(float LookAheadTime, int NumIncrements, out System.Numerics.Vector3 HitNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFutureFallPosition, "BmGame.RPawnPlayer.GetFutureFallPosition");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookAheadTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumIncrements, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out HitNormal);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HitNormal = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_GetFlightPathPosition;
    /// <summary>
    /// Function: GetFlightPathPosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetFlightPathPosition(System.Numerics.Vector3 StartPoint, System.Numerics.Vector3 EndPoint, System.Numerics.Vector3 StartVelocity, System.Numerics.Vector3 EndVelocity, float T, float FlightTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFlightPathPosition, "BmGame.RPawnPlayer.GetFlightPathPosition");
        byte* paramsPtr = stackalloc byte[84];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndPoint, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartVelocity, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndVelocity, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlightTime, paramsPtr + 52);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 56);
    }

    private static BmSDK.Function __fn_UpdateFallingTarget;
    /// <summary>
    /// Function: UpdateFallingTarget
    /// </summary>
    public unsafe virtual void UpdateFallingTarget(System.Numerics.Vector3 TestLocation, System.Numerics.Vector3 TestVelocity, float LookForward = default, bool HighPriorityOnly = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateFallingTarget, "BmGame.RPawnPlayer.UpdateFallingTarget");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestVelocity, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookForward, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HighPriorityOnly, paramsPtr + 28);
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

    private static BmSDK.Function __fn_NofifyBeginStateBatarangPrimed;
    /// <summary>
    /// Function: NofifyBeginStateBatarangPrimed
    /// </summary>
    public unsafe virtual void NofifyBeginStateBatarangPrimed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NofifyBeginStateBatarangPrimed, "BmGame.RPawnPlayer.NofifyBeginStateBatarangPrimed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyGadgetEquip;
    /// <summary>
    /// Function: NotifyGadgetEquip
    /// </summary>
    public unsafe virtual void NotifyGadgetEquip(bool Equip)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyGadgetEquip, "BmGame.RPawnPlayer.NotifyGadgetEquip");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Equip, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PossessedBy;
    /// <summary>
    /// Function: PossessedBy
    /// </summary>
    public unsafe override void PossessedBy(BmSDK.Engine.Controller C, bool bVehicleTransition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PossessedBy, "BmGame.RPawnPlayer.PossessedBy");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVehicleTransition, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanClimbToCatwalk;
    /// <summary>
    /// Function: CanClimbToCatwalk
    /// </summary>
    public unsafe virtual bool CanClimbToCatwalk(BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanClimbToCatwalk, "BmGame.RPawnPlayer.CanClimbToCatwalk");
        byte* paramsPtr = stackalloc byte[136];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 112);
    }

    private static BmSDK.Function __fn_CanClimbToCeiling;
    /// <summary>
    /// Function: CanClimbToCeiling
    /// </summary>
    public unsafe virtual bool CanClimbToCeiling(BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanClimbToCeiling, "BmGame.RPawnPlayer.CanClimbToCeiling");
        byte* paramsPtr = stackalloc byte[196];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 112);
    }

    private static BmSDK.Function __fn_IsValidCeilingLocator;
    /// <summary>
    /// Function: IsValidCeilingLocator
    /// </summary>
    public unsafe virtual bool IsValidCeilingLocator(BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsValidCeilingLocator, "BmGame.RPawnPlayer.IsValidCeilingLocator");
        byte* paramsPtr = stackalloc byte[148];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 112);
    }

    private static BmSDK.Function __fn_GetCeilingLocator;
    /// <summary>
    /// Function: GetCeilingLocator
    /// </summary>
    public unsafe virtual bool GetCeilingLocator(BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc, out BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCeilingLocator, "BmGame.RPawnPlayer.GetCeilingLocator");
        byte* paramsPtr = stackalloc byte[268];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc2);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc2, paramsPtr + 112);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc2 = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(paramsPtr + 112);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 224);
    }

    private static BmSDK.Function __fn_SetClimbPointFeatureType;
    /// <summary>
    /// Function: SetClimbPointFeatureType
    /// </summary>
    public unsafe virtual void SetClimbPointFeatureType(out BmSDK.BmGame.RPawnPlayer.FCeilingClimbPoint ClimbPoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetClimbPointFeatureType, "BmGame.RPawnPlayer.SetClimbPointFeatureType");
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out ClimbPoint);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClimbPoint, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ClimbPoint = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayer.FCeilingClimbPoint>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerGrateFromCeilingMove;
    /// <summary>
    /// Function: TriggerGrateFromCeilingMove
    /// </summary>
    public unsafe virtual void TriggerGrateFromCeilingMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerGrateFromCeilingMove, "BmGame.RPawnPlayer.TriggerGrateFromCeilingMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerGrateToCeilingMove;
    /// <summary>
    /// Function: TriggerGrateToCeilingMove
    /// </summary>
    public unsafe virtual void TriggerGrateToCeilingMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerGrateToCeilingMove, "BmGame.RPawnPlayer.TriggerGrateToCeilingMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerCeilingToCatwalkFarMove;
    /// <summary>
    /// Function: TriggerCeilingToCatwalkFarMove
    /// </summary>
    public unsafe virtual void TriggerCeilingToCatwalkFarMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCeilingToCatwalkFarMove, "BmGame.RPawnPlayer.TriggerCeilingToCatwalkFarMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerCeilingToCatwalkCloseMove;
    /// <summary>
    /// Function: TriggerCeilingToCatwalkCloseMove
    /// </summary>
    public unsafe virtual void TriggerCeilingToCatwalkCloseMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCeilingToCatwalkCloseMove, "BmGame.RPawnPlayer.TriggerCeilingToCatwalkCloseMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerCatwalkToCeilingFarMove;
    /// <summary>
    /// Function: TriggerCatwalkToCeilingFarMove
    /// </summary>
    public unsafe virtual void TriggerCatwalkToCeilingFarMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCatwalkToCeilingFarMove, "BmGame.RPawnPlayer.TriggerCatwalkToCeilingFarMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerCatwalkToCeilingCloseMove;
    /// <summary>
    /// Function: TriggerCatwalkToCeilingCloseMove
    /// </summary>
    public unsafe virtual void TriggerCatwalkToCeilingCloseMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCatwalkToCeilingCloseMove, "BmGame.RPawnPlayer.TriggerCatwalkToCeilingCloseMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerDangleToCeilingMove;
    /// <summary>
    /// Function: TriggerDangleToCeilingMove
    /// </summary>
    public unsafe virtual void TriggerDangleToCeilingMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerDangleToCeilingMove, "BmGame.RPawnPlayer.TriggerDangleToCeilingMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerCeilingToDangleMove;
    /// <summary>
    /// Function: TriggerCeilingToDangleMove
    /// </summary>
    public unsafe virtual void TriggerCeilingToDangleMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCeilingToDangleMove, "BmGame.RPawnPlayer.TriggerCeilingToDangleMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerDropFromCeilingMove;
    /// <summary>
    /// Function: TriggerDropFromCeilingMove
    /// </summary>
    public unsafe virtual void TriggerDropFromCeilingMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerDropFromCeilingMove, "BmGame.RPawnPlayer.TriggerDropFromCeilingMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerPounceToCeilingMove;
    /// <summary>
    /// Function: TriggerPounceToCeilingMove
    /// </summary>
    public unsafe virtual void TriggerPounceToCeilingMove(System.Numerics.Vector3 Position)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerPounceToCeilingMove, "BmGame.RPawnPlayer.TriggerPounceToCeilingMove");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnequipLineLauncher;
    /// <summary>
    /// Function: UnequipLineLauncher
    /// </summary>
    public unsafe virtual void UnequipLineLauncher()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnequipLineLauncher, "BmGame.RPawnPlayer.UnequipLineLauncher");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EquipLineLauncher;
    /// <summary>
    /// Function: EquipLineLauncher
    /// </summary>
    public unsafe virtual void EquipLineLauncher()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EquipLineLauncher, "BmGame.RPawnPlayer.EquipLineLauncher");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetReflectionNoSee;
    /// <summary>
    /// Function: SetReflectionNoSee
    /// </summary>
    public unsafe virtual void SetReflectionNoSee(bool bNoSee)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetReflectionNoSee, "BmGame.RPawnPlayer.SetReflectionNoSee");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoSee, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateXrayMaskMesh;
    /// <summary>
    /// Function: CreateXrayMaskMesh
    /// </summary>
    public unsafe virtual BmSDK.Engine.SkeletalMeshComponent CreateXrayMaskMesh(BmSDK.Engine.SkeletalMeshComponent Template, BmSDK.Engine.SkeletalMeshComponent ParentAnimComponent, BmSDK.Engine.MaterialInterface Material)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateXrayMaskMesh, "BmGame.RPawnPlayer.CreateXrayMaskMesh");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Template, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParentAnimComponent, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Material, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.SkeletalMeshComponent>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_DetachXrayMaskMesh;
    /// <summary>
    /// Function: DetachXrayMaskMesh
    /// </summary>
    public unsafe virtual void DetachXrayMaskMesh(BmSDK.Engine.SkeletalMeshComponent InMesh)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetachXrayMaskMesh, "BmGame.RPawnPlayer.DetachXrayMaskMesh");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InMesh, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishAnimControl;
    /// <summary>
    /// Function: FinishAnimControl
    /// </summary>
    public unsafe override void FinishAnimControl(BmSDK.Engine.InterpGroup InInterpGroup)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishAnimControl, "BmGame.RPawnPlayer.FinishAnimControl");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BlendOutAnimControl;
    /// <summary>
    /// Function: BlendOutAnimControl
    /// </summary>
    public unsafe override void BlendOutAnimControl(BmSDK.Engine.InterpGroup InInterpGroup)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BlendOutAnimControl, "BmGame.RPawnPlayer.BlendOutAnimControl");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BeginAnimControl;
    /// <summary>
    /// Function: BeginAnimControl
    /// </summary>
    public unsafe override void BeginAnimControl(BmSDK.Engine.InterpGroup InInterpGroup)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginAnimControl, "BmGame.RPawnPlayer.BeginAnimControl");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NonLocalGadgetIndexChanged;
    /// <summary>
    /// Function: NonLocalGadgetIndexChanged
    /// </summary>
    public unsafe virtual void NonLocalGadgetIndexChanged()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NonLocalGadgetIndexChanged, "BmGame.RPawnPlayer.NonLocalGadgetIndexChanged");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReplicatedEvent;
    /// <summary>
    /// Function: ReplicatedEvent
    /// </summary>
    public unsafe override void ReplicatedEvent(BmSDK.FName VarName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplicatedEvent, "BmGame.RPawnPlayer.ReplicatedEvent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnInvManagerReceived;
    /// <summary>
    /// Function: OnInvManagerReceived
    /// </summary>
    public unsafe virtual void OnInvManagerReceived()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnInvManagerReceived, "BmGame.RPawnPlayer.OnInvManagerReceived");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddInvManagerReceivedDelegate;
    /// <summary>
    /// Function: AddInvManagerReceivedDelegate
    /// </summary>
    public unsafe virtual void AddInvManagerReceivedDelegate(System.IntPtr Callback)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddInvManagerReceivedDelegate, "BmGame.RPawnPlayer.AddInvManagerReceivedDelegate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Callback, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGravityZ;
    /// <summary>
    /// Function: GetGravityZ
    /// </summary>
    public unsafe override float GetGravityZ()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGravityZ, "BmGame.RPawnPlayer.GetGravityZ");
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

    private static BmSDK.Function __fn_IncrementWireBounce;
    /// <summary>
    /// Function: IncrementWireBounce
    /// </summary>
    public unsafe virtual void IncrementWireBounce(float Speed, float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IncrementWireBounce, "BmGame.RPawnPlayer.IncrementWireBounce");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 4);
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

    private static BmSDK.Function __fn_TurnOffWireBounce;
    /// <summary>
    /// Function: TurnOffWireBounce
    /// </summary>
    public unsafe virtual void TurnOffWireBounce()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOffWireBounce, "BmGame.RPawnPlayer.TurnOffWireBounce");
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

    private static BmSDK.Function __fn_InitialiseWireBounce;
    /// <summary>
    /// Function: InitialiseWireBounce
    /// </summary>
    public unsafe virtual void InitialiseWireBounce(float InitialBounce)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitialiseWireBounce, "BmGame.RPawnPlayer.InitialiseWireBounce");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InitialBounce, paramsPtr + 0);
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

    private static BmSDK.Function __fn_CheckForSmallDropOffRailing;
    /// <summary>
    /// Function: CheckForSmallDropOffRailing
    /// </summary>
    public unsafe virtual bool CheckForSmallDropOffRailing(System.Numerics.Vector3 Direction, out BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Locator)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForSmallDropOffRailing, "BmGame.RPawnPlayer.CheckForSmallDropOffRailing");
        byte* paramsPtr = stackalloc byte[144];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Locator);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Locator, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Locator = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 124);
    }

    private static BmSDK.Function __fn_CorrectFallingVelocity;
    /// <summary>
    /// Function: CorrectFallingVelocity
    /// </summary>
    public unsafe virtual void CorrectFallingVelocity(in System.Numerics.Vector3 DesiredPosition, float Max2DAccel, float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CorrectFallingVelocity, "BmGame.RPawnPlayer.CorrectFallingVelocity");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Max2DAccel, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 16);
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

    private static BmSDK.Function __fn_GetGrappleEndLocation;
    /// <summary>
    /// Function: GetGrappleEndLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetGrappleEndLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGrappleEndLocation, "BmGame.RPawnPlayer.GetGrappleEndLocation");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ServerTriggerSpecialMoveFromClient;
    /// <summary>
    /// Function: ServerTriggerSpecialMoveFromClient
    /// </summary>
    public unsafe virtual void ServerTriggerSpecialMoveFromClient(BmSDK.BmGame.RSpecialMoveConfig SpecMove, BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc, int InitialYaw)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerTriggerSpecialMoveFromClient, "BmGame.RPawnPlayer.ServerTriggerSpecialMoveFromClient");
        byte* paramsPtr = stackalloc byte[148];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InitialYaw, paramsPtr + 116);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientTriggerSpecialMoveFromServer;
    /// <summary>
    /// Function: ClientTriggerSpecialMoveFromServer
    /// </summary>
    public unsafe virtual void ClientTriggerSpecialMoveFromServer(BmSDK.BmGame.RSpecialMoveConfig SpecMove, BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc, bool ForceOnClient, int InitialYaw)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientTriggerSpecialMoveFromServer, "BmGame.RPawnPlayer.ClientTriggerSpecialMoveFromServer");
        byte* paramsPtr = stackalloc byte[152];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceOnClient, paramsPtr + 116);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InitialYaw, paramsPtr + 120);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateFallAnim;
    /// <summary>
    /// Function: UpdateFallAnim
    /// </summary>
    public unsafe virtual void UpdateFallAnim(float DeltaTime, float FallScale = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateFallAnim, "BmGame.RPawnPlayer.UpdateFallAnim");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FallScale, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SpecialMoveFinished;
    /// <summary>
    /// Function: SpecialMoveFinished
    /// </summary>
    public unsafe virtual void SpecialMoveFinished(BmSDK.BmGame.RSpecialMoveInstance FinishedMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpecialMoveFinished, "BmGame.RPawnPlayer.SpecialMoveFinished");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedMove, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetCurrentSpecialMove;
    /// <summary>
    /// Function: SetCurrentSpecialMove
    /// </summary>
    public unsafe virtual void SetCurrentSpecialMove(BmSDK.BmGame.RSpecialMoveInstance NewMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetCurrentSpecialMove, "BmGame.RPawnPlayer.SetCurrentSpecialMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMove, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetLastSpecialMove;
    /// <summary>
    /// Function: GetLastSpecialMove
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnPlayer.FLastSpecialMoveData GetLastSpecialMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLastSpecialMove, "BmGame.RPawnPlayer.GetLastSpecialMove");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayer.FLastSpecialMoveData>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FinishedLastSpecialMoveTransition;
    /// <summary>
    /// Function: FinishedLastSpecialMoveTransition
    /// </summary>
    public unsafe virtual bool FinishedLastSpecialMoveTransition()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishedLastSpecialMoveTransition, "BmGame.RPawnPlayer.FinishedLastSpecialMoveTransition");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_TriggerSpecialMove;
    /// <summary>
    /// Function: TriggerSpecialMove
    /// </summary>
    public unsafe virtual void TriggerSpecialMove(BmSDK.BmGame.RSpecialMoveConfig SpecMove, BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc, bool ForceReplicateToClient)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSpecialMove, "BmGame.RPawnPlayer.TriggerSpecialMove");
        byte* paramsPtr = stackalloc byte[144];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceReplicateToClient, paramsPtr + 116);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerTriggerSpecialMoveFromClientOnPawn;
    /// <summary>
    /// Function: ServerTriggerSpecialMoveFromClientOnPawn
    /// </summary>
    public unsafe virtual void ServerTriggerSpecialMoveFromClientOnPawn(BmSDK.BmGame.RPawnPlayer PawnToTriggerOn, BmSDK.BmGame.RSpecialMoveConfig SpecMove, BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerTriggerSpecialMoveFromClientOnPawn, "BmGame.RPawnPlayer.ServerTriggerSpecialMoveFromClientOnPawn");
        byte* paramsPtr = stackalloc byte[148];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnToTriggerOn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecMove, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerSpecialMoveOnPawn;
    /// <summary>
    /// Function: TriggerSpecialMoveOnPawn
    /// </summary>
    public unsafe virtual void TriggerSpecialMoveOnPawn(BmSDK.BmGame.RPawnPlayer PawnToTriggerOn, BmSDK.BmGame.RSpecialMoveConfig SpecMove, BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc, bool ForceReplicateToClient)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerSpecialMoveOnPawn, "BmGame.RPawnPlayer.TriggerSpecialMoveOnPawn");
        byte* paramsPtr = stackalloc byte[140];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnToTriggerOn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecMove, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceReplicateToClient, paramsPtr + 120);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearEnvironmentFeatures;
    /// <summary>
    /// Function: ClearEnvironmentFeatures
    /// </summary>
    public unsafe virtual void ClearEnvironmentFeatures()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearEnvironmentFeatures, "BmGame.RPawnPlayer.ClearEnvironmentFeatures");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PersistentMapChanged;
    /// <summary>
    /// Function: PersistentMapChanged
    /// </summary>
    public unsafe virtual void PersistentMapChanged()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PersistentMapChanged, "BmGame.RPawnPlayer.PersistentMapChanged");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HopOffVantagePoint;
    /// <summary>
    /// Function: HopOffVantagePoint
    /// </summary>
    public unsafe virtual void HopOffVantagePoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HopOffVantagePoint, "BmGame.RPawnPlayer.HopOffVantagePoint");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnreliableClientRemoteSpecialMoveEvent;
    /// <summary>
    /// Function: UnreliableClientRemoteSpecialMoveEvent
    /// </summary>
    public unsafe virtual void UnreliableClientRemoteSpecialMoveEvent(BmSDK.BmGame.RSpecialMoveConfig Move, BmSDK.FName MoveEvent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnreliableClientRemoteSpecialMoveEvent, "BmGame.RPawnPlayer.UnreliableClientRemoteSpecialMoveEvent");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Move, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveEvent, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnreliableServerRemoteSpecialMoveEvent;
    /// <summary>
    /// Function: UnreliableServerRemoteSpecialMoveEvent
    /// </summary>
    public unsafe virtual void UnreliableServerRemoteSpecialMoveEvent(BmSDK.BmGame.RSpecialMoveConfig Move, BmSDK.FName MoveEvent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnreliableServerRemoteSpecialMoveEvent, "BmGame.RPawnPlayer.UnreliableServerRemoteSpecialMoveEvent");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Move, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveEvent, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnreliableRemoteSpecialMoveEvent;
    /// <summary>
    /// Function: UnreliableRemoteSpecialMoveEvent
    /// </summary>
    public unsafe virtual void UnreliableRemoteSpecialMoveEvent(BmSDK.BmGame.RSpecialMoveConfig Move, BmSDK.FName MoveEvent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnreliableRemoteSpecialMoveEvent, "BmGame.RPawnPlayer.UnreliableRemoteSpecialMoveEvent");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Move, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveEvent, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientRemoteSpecialMoveEvent;
    /// <summary>
    /// Function: ClientRemoteSpecialMoveEvent
    /// </summary>
    public unsafe virtual void ClientRemoteSpecialMoveEvent(BmSDK.BmGame.RSpecialMoveConfig Move, BmSDK.FName MoveEvent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientRemoteSpecialMoveEvent, "BmGame.RPawnPlayer.ClientRemoteSpecialMoveEvent");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Move, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveEvent, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerRemoteSpecialMoveEvent;
    /// <summary>
    /// Function: ServerRemoteSpecialMoveEvent
    /// </summary>
    public unsafe virtual void ServerRemoteSpecialMoveEvent(BmSDK.BmGame.RSpecialMoveConfig Move, BmSDK.FName MoveEvent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerRemoteSpecialMoveEvent, "BmGame.RPawnPlayer.ServerRemoteSpecialMoveEvent");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Move, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveEvent, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoteSpecialMoveEvent;
    /// <summary>
    /// Function: RemoteSpecialMoveEvent
    /// </summary>
    public unsafe virtual void RemoteSpecialMoveEvent(BmSDK.BmGame.RSpecialMoveConfig Move, BmSDK.FName MoveEvent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoteSpecialMoveEvent, "BmGame.RPawnPlayer.RemoteSpecialMoveEvent");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Move, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveEvent, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsHangingFromGarg;
    /// <summary>
    /// Function: IsHangingFromGarg
    /// </summary>
    public unsafe virtual bool IsHangingFromGarg()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsHangingFromGarg, "BmGame.RPawnPlayer.IsHangingFromGarg");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsOnRailing;
    /// <summary>
    /// Function: IsOnRailing
    /// </summary>
    public unsafe virtual bool IsOnRailing()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsOnRailing, "BmGame.RPawnPlayer.IsOnRailing");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsInVantage;
    /// <summary>
    /// Function: IsInVantage
    /// </summary>
    public unsafe virtual bool IsInVantage()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInVantage, "BmGame.RPawnPlayer.IsInVantage");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AgilityBoost;
    /// <summary>
    /// Function: AgilityBoost
    /// </summary>
    public unsafe virtual void AgilityBoost()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AgilityBoost, "BmGame.RPawnPlayer.AgilityBoost");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerSetWireWalking;
    /// <summary>
    /// Function: ServerSetWireWalking
    /// </summary>
    public unsafe virtual void ServerSetWireWalking(bool OnOrOff, BmSDK.BmGame.RHidePoint_RopeBase NewWire)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerSetWireWalking, "BmGame.RPawnPlayer.ServerSetWireWalking");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnOrOff, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWire, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AuthoritySetWireWalking;
    /// <summary>
    /// Function: AuthoritySetWireWalking
    /// </summary>
    public unsafe virtual void AuthoritySetWireWalking(bool OnOrOff, BmSDK.BmGame.RHidePoint_RopeBase NewWire)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AuthoritySetWireWalking, "BmGame.RPawnPlayer.AuthoritySetWireWalking");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnOrOff, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWire, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetWireWalking;
    /// <summary>
    /// Function: SetWireWalking
    /// </summary>
    public unsafe virtual void SetWireWalking(bool OnOrOff, BmSDK.BmGame.RHidePoint_RopeBase NewWire)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWireWalking, "BmGame.RPawnPlayer.SetWireWalking");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnOrOff, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWire, paramsPtr + 4);
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

    private static BmSDK.Function __fn_FindRailing;
    /// <summary>
    /// Function: FindRailing
    /// </summary>
    public unsafe virtual bool FindRailing(System.Numerics.Vector3 Direction, out BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator RailingLoc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindRailing, "BmGame.RPawnPlayer.FindRailing");
        byte* paramsPtr = stackalloc byte[144];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out RailingLoc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RailingLoc, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        RailingLoc = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 124);
    }

    private static BmSDK.Function __fn_ClearGrapplePointControlPoint;
    /// <summary>
    /// Function: ClearGrapplePointControlPoint
    /// </summary>
    public unsafe virtual void ClearGrapplePointControlPoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearGrapplePointControlPoint, "BmGame.RPawnPlayer.ClearGrapplePointControlPoint");
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

    private static BmSDK.Function __fn_CreateGrappleWireControlPoint;
    /// <summary>
    /// Function: CreateGrappleWireControlPoint
    /// </summary>
    public unsafe virtual void CreateGrappleWireControlPoint(BmSDK.BmGame.RHidePoint_RopeBase Wire, System.Numerics.Vector3 ApproxPosition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateGrappleWireControlPoint, "BmGame.RPawnPlayer.CreateGrappleWireControlPoint");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Wire, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ApproxPosition, paramsPtr + 4);
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

    private static BmSDK.Function __fn_SetLastWirePoint;
    /// <summary>
    /// Function: SetLastWirePoint
    /// </summary>
    public unsafe virtual void SetLastWirePoint(BmSDK.BmGame.RHidePoint_RopeBase NewWire)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLastWirePoint, "BmGame.RPawnPlayer.SetLastWirePoint");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWire, paramsPtr + 0);
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

    private static BmSDK.Function __fn_WireLimbAllOff;
    /// <summary>
    /// Function: WireLimbAllOff
    /// </summary>
    public unsafe virtual void WireLimbAllOff()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WireLimbAllOff, "BmGame.RPawnPlayer.WireLimbAllOff");
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

    private static BmSDK.Function __fn_WireLimbOnOrOff;
    /// <summary>
    /// Function: WireLimbOnOrOff
    /// </summary>
    public unsafe virtual void WireLimbOnOrOff(BmSDK.BmGame.RPawnPlayer.OverheadRopeControlPointType LimbType, bool bOnOrOff)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WireLimbOnOrOff, "BmGame.RPawnPlayer.WireLimbOnOrOff");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LimbType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnOrOff, paramsPtr + 4);
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

    private static BmSDK.Function __fn_OverrideUnderEdgeCollection;
    /// <summary>
    /// Function: OverrideUnderEdgeCollection
    /// </summary>
    public unsafe virtual void OverrideUnderEdgeCollection(BmSDK.Engine.PrimitiveComponent Comp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideUnderEdgeCollection, "BmGame.RPawnPlayer.OverrideUnderEdgeCollection");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Comp, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddFakeCollisionNormal;
    /// <summary>
    /// Function: AddFakeCollisionNormal
    /// </summary>
    public unsafe virtual void AddFakeCollisionNormal(in System.Numerics.Vector3 CollisionNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddFakeCollisionNormal, "BmGame.RPawnPlayer.AddFakeCollisionNormal");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionNormal, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetRailingJumpDirection;
    /// <summary>
    /// Function: GetRailingJumpDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetRailingJumpDirection()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRailingJumpDirection, "BmGame.RPawnPlayer.GetRailingJumpDirection");
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

    private static BmSDK.Function __fn_GetSecondRailingTop;
    /// <summary>
    /// Function: GetSecondRailingTop
    /// </summary>
    public unsafe virtual void GetSecondRailingTop(out System.Numerics.Vector3 PointA, out System.Numerics.Vector3 PointB)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSecondRailingTop, "BmGame.RPawnPlayer.GetSecondRailingTop");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PointA);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointA, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PointB);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointB, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PointA = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        PointB = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetRailingTop;
    /// <summary>
    /// Function: GetRailingTop
    /// </summary>
    public unsafe virtual void GetRailingTop(out System.Numerics.Vector3 PointA, out System.Numerics.Vector3 PointB)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRailingTop, "BmGame.RPawnPlayer.GetRailingTop");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PointA);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointA, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out PointB);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointB, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PointA = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
        PointB = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    private static BmSDK.Function __fn_GetRailingInfo;
    /// <summary>
    /// Function: GetRailingInfo
    /// </summary>
    public unsafe virtual bool GetRailingInfo(System.Numerics.Vector3 MoveDirection = default, bool bActuallyLanding = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRailingInfo, "BmGame.RPawnPlayer.GetRailingInfo");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveDirection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActuallyLanding, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_IsBeingTakenDown;
    /// <summary>
    /// Function: IsBeingTakenDown
    /// </summary>
    public unsafe virtual void IsBeingTakenDown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBeingTakenDown, "BmGame.RPawnPlayer.IsBeingTakenDown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerPlayRelativeTransition;
    /// <summary>
    /// Function: ServerPlayRelativeTransition
    /// </summary>
    public unsafe virtual void ServerPlayRelativeTransition(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, System.Numerics.Vector3 TransitionTargetPosition, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerPlayRelativeTransition, "BmGame.RPawnPlayer.ServerPlayRelativeTransition");
        byte* paramsPtr = stackalloc byte[156];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetPosition, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 128);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 132);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionStartTime, paramsPtr + 136);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ForceClientPlayRelativeTransition;
    /// <summary>
    /// Function: ForceClientPlayRelativeTransition
    /// </summary>
    public unsafe virtual void ForceClientPlayRelativeTransition(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, System.Numerics.Vector3 TransitionTargetPosition, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceClientPlayRelativeTransition, "BmGame.RPawnPlayer.ForceClientPlayRelativeTransition");
        byte* paramsPtr = stackalloc byte[156];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetPosition, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 128);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 132);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionStartTime, paramsPtr + 136);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientPlayRelativeTransition;
    /// <summary>
    /// Function: ClientPlayRelativeTransition
    /// </summary>
    public unsafe virtual void ClientPlayRelativeTransition(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, System.Numerics.Vector3 TransitionTargetPosition, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientPlayRelativeTransition, "BmGame.RPawnPlayer.ClientPlayRelativeTransition");
        byte* paramsPtr = stackalloc byte[156];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetPosition, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 128);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 132);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionStartTime, paramsPtr + 136);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayReplicatedRelativeTransitionEx;
    /// <summary>
    /// Function: PlayReplicatedRelativeTransitionEx
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId PlayReplicatedRelativeTransitionEx(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, System.Numerics.Vector3 TransitionTargetPosition, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default, bool bReplicateToServer = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayReplicatedRelativeTransitionEx, "BmGame.RPawnPlayer.PlayReplicatedRelativeTransitionEx");
        byte* paramsPtr = stackalloc byte[168];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetPosition, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 128);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 132);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionStartTime, paramsPtr + 136);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bReplicateToServer, paramsPtr + 140);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 144);
    }

    private static BmSDK.Function __fn_CTDD_MeetingTime;
    /// <summary>
    /// Function: CTDD_MeetingTime
    /// </summary>
    public unsafe virtual float CTDD_MeetingTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CTDD_MeetingTime, "BmGame.RPawnPlayer.CTDD_MeetingTime");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CTDD_TimeSync;
    /// <summary>
    /// Function: CTDD_TimeSync
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.ESlavedTransitionTimeSync CTDD_TimeSync()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CTDD_TimeSync, "BmGame.RPawnPlayer.CTDD_TimeSync");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil_PosePlayer.ESlavedTransitionTimeSync>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CTDD_DoubleCustomTransition;
    /// <summary>
    /// Function: CTDD_DoubleCustomTransition
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimConfig.FCustomAnimConfig CTDD_DoubleCustomTransition(BmSDK.BmGame.RPawnCombat ThugVictim, int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CTDD_DoubleCustomTransition, "BmGame.RPawnPlayer.CTDD_DoubleCustomTransition");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugVictim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimConfig.FCustomAnimConfig>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CTDD_CustomTransition;
    /// <summary>
    /// Function: CTDD_CustomTransition
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimConfig.FCustomAnimConfig CTDD_CustomTransition(BmSDK.BmGame.RPawnCombat ThugVictim)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CTDD_CustomTransition, "BmGame.RPawnPlayer.CTDD_CustomTransition");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugVictim, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimConfig.FCustomAnimConfig>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CTDD_GetVictimAnimsets;
    /// <summary>
    /// Function: CTDD_GetVictimAnimsets
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.Engine.AnimSet> CTDD_GetVictimAnimsets(BmSDK.BmGame.RPawnCombat ThugVictim = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CTDD_GetVictimAnimsets, "BmGame.RPawnPlayer.CTDD_GetVictimAnimsets");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugVictim, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.AnimSet>>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CTDD_GetPlayerAnimset;
    /// <summary>
    /// Function: CTDD_GetPlayerAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet CTDD_GetPlayerAnimset()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CTDD_GetPlayerAnimset, "BmGame.RPawnPlayer.CTDD_GetPlayerAnimset");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CTDD_CustomAttackerTransition;
    /// <summary>
    /// Function: CTDD_CustomAttackerTransition
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CTDD_CustomAttackerTransition(BmSDK.BmGame.RPawnCombat OtherPawn = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CTDD_CustomAttackerTransition, "BmGame.RPawnPlayer.CTDD_CustomAttackerTransition");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CTDD_VictimMovmentStance;
    /// <summary>
    /// Function: CTDD_VictimMovmentStance
    /// </summary>
    public unsafe virtual BmSDK.FName CTDD_VictimMovmentStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CTDD_VictimMovmentStance, "BmGame.RPawnPlayer.CTDD_VictimMovmentStance");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CTDD_AttackerMovementStance;
    /// <summary>
    /// Function: CTDD_AttackerMovementStance
    /// </summary>
    public unsafe virtual BmSDK.FName CTDD_AttackerMovementStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CTDD_AttackerMovementStance, "BmGame.RPawnPlayer.CTDD_AttackerMovementStance");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CTDD_EndsInMirrored;
    /// <summary>
    /// Function: CTDD_EndsInMirrored
    /// </summary>
    public unsafe virtual bool CTDD_EndsInMirrored()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CTDD_EndsInMirrored, "BmGame.RPawnPlayer.CTDD_EndsInMirrored");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CTDD_Mirrored;
    /// <summary>
    /// Function: CTDD_Mirrored
    /// </summary>
    public unsafe virtual bool CTDD_Mirrored()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CTDD_Mirrored, "BmGame.RPawnPlayer.CTDD_Mirrored");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CTDD_CustomCamera;
    /// <summary>
    /// Function: CTDD_CustomCamera
    /// </summary>
    public unsafe virtual bool CTDD_CustomCamera(out BmSDK.FName CameraAnim)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CTDD_CustomCamera, "BmGame.RPawnPlayer.CTDD_CustomCamera");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CameraAnim);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraAnim, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CameraAnim = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CTDD_WithCamera;
    /// <summary>
    /// Function: CTDD_WithCamera
    /// </summary>
    public unsafe virtual bool CTDD_WithCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CTDD_WithCamera, "BmGame.RPawnPlayer.CTDD_WithCamera");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayDoubleTakedownVictimAnim;
    /// <summary>
    /// Function: PlayDoubleTakedownVictimAnim
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId PlayDoubleTakedownVictimAnim(float OverrideStartTime, int Index)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayDoubleTakedownVictimAnim, "BmGame.RPawnPlayer.PlayDoubleTakedownVictimAnim");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideStartTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_PlayTakedownVictimAnim;
    /// <summary>
    /// Function: PlayTakedownVictimAnim
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId PlayTakedownVictimAnim(float OverrideStartTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayTakedownVictimAnim, "BmGame.RPawnPlayer.PlayTakedownVictimAnim");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideStartTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SkipStealthOverridesTakedownAgainst;
    /// <summary>
    /// Function: SkipStealthOverridesTakedownAgainst
    /// </summary>
    public unsafe virtual bool SkipStealthOverridesTakedownAgainst(BmSDK.BmGame.RPawnPlayer.EStealthTakeDownStages takedown, BmSDK.BmGame.RPawnCombat Victim)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SkipStealthOverridesTakedownAgainst, "BmGame.RPawnPlayer.SkipStealthOverridesTakedownAgainst");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takedown, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SplitGrapple;
    /// <summary>
    /// Function: SplitGrapple
    /// </summary>
    public unsafe virtual void SplitGrapple()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SplitGrapple, "BmGame.RPawnPlayer.SplitGrapple");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopGrapple;
    /// <summary>
    /// Function: StopGrapple
    /// </summary>
    public unsafe virtual void StopGrapple()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopGrapple, "BmGame.RPawnPlayer.StopGrapple");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayTakedownAttackerAnim;
    /// <summary>
    /// Function: PlayTakedownAttackerAnim
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId PlayTakedownAttackerAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayTakedownAttackerAnim, "BmGame.RPawnPlayer.PlayTakedownAttackerAnim");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetVictimCameraReferencePosition;
    /// <summary>
    /// Function: GetVictimCameraReferencePosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetVictimCameraReferencePosition()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVictimCameraReferencePosition, "BmGame.RPawnPlayer.GetVictimCameraReferencePosition");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayClientTakedownAttackerAnim;
    /// <summary>
    /// Function: PlayClientTakedownAttackerAnim
    /// </summary>
    public unsafe virtual void PlayClientTakedownAttackerAnim(BmSDK.BmGame.RPawnPlayer.FNetworkedAnimPair Data, bool WithDelay)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayClientTakedownAttackerAnim, "BmGame.RPawnPlayer.PlayClientTakedownAttackerAnim");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Data, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WithDelay, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerVictimCameraBlendOut;
    /// <summary>
    /// Function: TriggerVictimCameraBlendOut
    /// </summary>
    public unsafe virtual void TriggerVictimCameraBlendOut()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerVictimCameraBlendOut, "BmGame.RPawnPlayer.TriggerVictimCameraBlendOut");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerVictimNotFrozen;
    /// <summary>
    /// Function: TriggerVictimNotFrozen
    /// </summary>
    public unsafe virtual void TriggerVictimNotFrozen()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerVictimNotFrozen, "BmGame.RPawnPlayer.TriggerVictimNotFrozen");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerVictim2;
    /// <summary>
    /// Function: TriggerVictim2
    /// </summary>
    public unsafe virtual void TriggerVictim2()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerVictim2, "BmGame.RPawnPlayer.TriggerVictim2");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerVictim;
    /// <summary>
    /// Function: TriggerVictim
    /// </summary>
    public unsafe virtual void TriggerVictim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerVictim, "BmGame.RPawnPlayer.TriggerVictim");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThrowThug;
    /// <summary>
    /// Function: ThrowThug
    /// </summary>
    public unsafe virtual void ThrowThug()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThrowThug, "BmGame.RPawnPlayer.ThrowThug");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerNextCamera;
    /// <summary>
    /// Function: TriggerNextCamera
    /// </summary>
    public unsafe virtual void TriggerNextCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerNextCamera, "BmGame.RPawnPlayer.TriggerNextCamera");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TickProceduralRefPointInterpolation;
    /// <summary>
    /// Function: TickProceduralRefPointInterpolation
    /// </summary>
    public unsafe virtual void TickProceduralRefPointInterpolation(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TickProceduralRefPointInterpolation, "BmGame.RPawnPlayer.TickProceduralRefPointInterpolation");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerRefPointInterpolation;
    /// <summary>
    /// Function: TriggerRefPointInterpolation
    /// </summary>
    public unsafe virtual void TriggerRefPointInterpolation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerRefPointInterpolation, "BmGame.RPawnPlayer.TriggerRefPointInterpolation");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DetachHangRope;
    /// <summary>
    /// Function: DetachHangRope
    /// </summary>
    public unsafe virtual void DetachHangRope()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DetachHangRope, "BmGame.RPawnPlayer.DetachHangRope");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachHangRope;
    /// <summary>
    /// Function: AttachHangRope
    /// </summary>
    public unsafe virtual void AttachHangRope(BmSDK.BmGame.RHidePoint HangPoint, BmSDK.FName BoneToAttachTo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachHangRope, "BmGame.RPawnPlayer.AttachHangRope");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HangPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneToAttachTo, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AttachRope;
    /// <summary>
    /// Function: AttachRope
    /// </summary>
    public unsafe virtual void AttachRope(BmSDK.FName BoneToAttachTo, System.Numerics.Vector3 TargetPosition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AttachRope, "BmGame.RPawnPlayer.AttachRope");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneToAttachTo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPosition, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CreateBatmanRope;
    /// <summary>
    /// Function: CreateBatmanRope
    /// </summary>
    public unsafe virtual void CreateBatmanRope()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CreateBatmanRope, "BmGame.RPawnPlayer.CreateBatmanRope");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SyncTakedownDataAndPlayAttackerAnim;
    /// <summary>
    /// Function: SyncTakedownDataAndPlayAttackerAnim
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId SyncTakedownDataAndPlayAttackerAnim(bool WithDelay)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SyncTakedownDataAndPlayAttackerAnim, "BmGame.RPawnPlayer.SyncTakedownDataAndPlayAttackerAnim");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WithDelay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ClientCancelTakedownAnim;
    /// <summary>
    /// Function: ClientCancelTakedownAnim
    /// </summary>
    public unsafe virtual void ClientCancelTakedownAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientCancelTakedownAnim, "BmGame.RPawnPlayer.ClientCancelTakedownAnim");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerCancelTakedownAnim;
    /// <summary>
    /// Function: ServerCancelTakedownAnim
    /// </summary>
    public unsafe virtual void ServerCancelTakedownAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerCancelTakedownAnim, "BmGame.RPawnPlayer.ServerCancelTakedownAnim");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlaySimpleThugTakedownCamera;
    /// <summary>
    /// Function: PlaySimpleThugTakedownCamera
    /// </summary>
    public unsafe virtual void PlaySimpleThugTakedownCamera(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId CurrentTransition, BmSDK.BmGame.RPawnPlayer Attacker, bool TakedownCameraFollowsAttackerRotation, BmSDK.FName VictimCameraState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlaySimpleThugTakedownCamera, "BmGame.RPawnPlayer.PlaySimpleThugTakedownCamera");
        byte* paramsPtr = stackalloc byte[212];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentTransition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TakedownCameraFollowsAttackerRotation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VictimCameraState, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitThugTakedownCamera;
    /// <summary>
    /// Function: InitThugTakedownCamera
    /// </summary>
    public unsafe virtual void InitThugTakedownCamera(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId CurrentTransition, BmSDK.BmGame.RPawnPlayer Attacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitThugTakedownCamera, "BmGame.RPawnPlayer.InitThugTakedownCamera");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentTransition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayReplicatedRelativeTransition;
    /// <summary>
    /// Function: PlayReplicatedRelativeTransition
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId PlayReplicatedRelativeTransition(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, System.Numerics.Vector3 TransitionTargetPosition, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default, bool bReplicateToServer = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayReplicatedRelativeTransition, "BmGame.RPawnPlayer.PlayReplicatedRelativeTransition");
        byte* paramsPtr = stackalloc byte[168];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetPosition, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 128);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 132);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionStartTime, paramsPtr + 136);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bReplicateToServer, paramsPtr + 140);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 144);
    }

    private static BmSDK.Function __fn_ServerPlayRelativeTransitionRotationOnly;
    /// <summary>
    /// Function: ServerPlayRelativeTransitionRotationOnly
    /// </summary>
    public unsafe virtual void ServerPlayRelativeTransitionRotationOnly(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerPlayRelativeTransitionRotationOnly, "BmGame.RPawnPlayer.ServerPlayRelativeTransitionRotationOnly");
        byte* paramsPtr = stackalloc byte[144];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 76);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 116);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 120);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionStartTime, paramsPtr + 124);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientPlayRelativeTransitionRotationOnly;
    /// <summary>
    /// Function: ClientPlayRelativeTransitionRotationOnly
    /// </summary>
    public unsafe virtual void ClientPlayRelativeTransitionRotationOnly(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientPlayRelativeTransitionRotationOnly, "BmGame.RPawnPlayer.ClientPlayRelativeTransitionRotationOnly");
        byte* paramsPtr = stackalloc byte[144];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 76);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 116);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 120);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionStartTime, paramsPtr + 124);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayReplicatedRelativeTransitionRotationOnly;
    /// <summary>
    /// Function: PlayReplicatedRelativeTransitionRotationOnly
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId PlayReplicatedRelativeTransitionRotationOnly(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default, bool bReplicateToServer = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayReplicatedRelativeTransitionRotationOnly, "BmGame.RPawnPlayer.PlayReplicatedRelativeTransitionRotationOnly");
        byte* paramsPtr = stackalloc byte[156];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 76);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 116);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 120);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionStartTime, paramsPtr + 124);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bReplicateToServer, paramsPtr + 128);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 132);
    }

    private static BmSDK.Function __fn_StopAimAt;
    /// <summary>
    /// Function: StopAimAt
    /// </summary>
    public unsafe override void StopAimAt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopAimAt, "BmGame.RPawnPlayer.StopAimAt");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AimInDirection;
    /// <summary>
    /// Function: AimInDirection
    /// </summary>
    public unsafe override void AimInDirection(System.Numerics.Vector3 Direction, BmSDK.FName Description = default, BmSDK.BmGame.RAnimConfig.EYesNoDefault AllowTurningToAim = default, float LimitScale = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AimInDirection, "BmGame.RPawnPlayer.AimInDirection");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AllowTurningToAim, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LimitScale, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyAllProjectiles;
    /// <summary>
    /// Function: DestroyAllProjectiles
    /// </summary>
    public unsafe virtual void DestroyAllProjectiles()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyAllProjectiles, "BmGame.RPawnPlayer.DestroyAllProjectiles");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsPawnTakingdown;
    /// <summary>
    /// Function: IsPawnTakingdown
    /// </summary>
    public unsafe virtual bool IsPawnTakingdown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPawnTakingdown, "BmGame.RPawnPlayer.IsPawnTakingdown");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsPawnBeingTakendown;
    /// <summary>
    /// Function: IsPawnBeingTakendown
    /// </summary>
    public unsafe override bool IsPawnBeingTakendown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPawnBeingTakendown, "BmGame.RPawnPlayer.IsPawnBeingTakendown");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UnHideHead;
    /// <summary>
    /// Function: UnHideHead
    /// </summary>
    public unsafe virtual void UnHideHead()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnHideHead, "BmGame.RPawnPlayer.UnHideHead");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HideHead;
    /// <summary>
    /// Function: HideHead
    /// </summary>
    public unsafe virtual void HideHead()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideHead, "BmGame.RPawnPlayer.HideHead");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsRidingVenomHenchman;
    /// <summary>
    /// Function: IsRidingVenomHenchman
    /// </summary>
    public unsafe virtual bool IsRidingVenomHenchman()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsRidingVenomHenchman, "BmGame.RPawnPlayer.IsRidingVenomHenchman");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetQuickGadget;
    /// <summary>
    /// Function: GetQuickGadget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RInventoryGadget GetQuickGadget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetQuickGadget, "BmGame.RPawnPlayer.GetQuickGadget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RInventoryGadget>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OnPlayerHasBeenMoved;
    /// <summary>
    /// Function: OnPlayerHasBeenMoved
    /// </summary>
    public unsafe virtual void OnPlayerHasBeenMoved()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnPlayerHasBeenMoved, "BmGame.RPawnPlayer.OnPlayerHasBeenMoved");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDesiredPoseType;
    /// <summary>
    /// Function: GetDesiredPoseType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnPlayer.EBatmanPoseType GetDesiredPoseType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDesiredPoseType, "BmGame.RPawnPlayer.GetDesiredPoseType");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayer.EBatmanPoseType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ResetRagdollLinearDamping;
    /// <summary>
    /// Function: ResetRagdollLinearDamping
    /// </summary>
    public unsafe virtual void ResetRagdollLinearDamping()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetRagdollLinearDamping, "BmGame.RPawnPlayer.ResetRagdollLinearDamping");
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

    private static BmSDK.Function __fn_SetRagdollLinearDampingForGrappleDeath;
    /// <summary>
    /// Function: SetRagdollLinearDampingForGrappleDeath
    /// </summary>
    public unsafe virtual void SetRagdollLinearDampingForGrappleDeath()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRagdollLinearDampingForGrappleDeath, "BmGame.RPawnPlayer.SetRagdollLinearDampingForGrappleDeath");
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

    private static BmSDK.Function __fn_ResetRagdollDamping;
    /// <summary>
    /// Function: ResetRagdollDamping
    /// </summary>
    public unsafe virtual void ResetRagdollDamping()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetRagdollDamping, "BmGame.RPawnPlayer.ResetRagdollDamping");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SlowDownRagdollDeath;
    /// <summary>
    /// Function: SlowDownRagdollDeath
    /// </summary>
    public unsafe virtual void SlowDownRagdollDeath()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SlowDownRagdollDeath, "BmGame.RPawnPlayer.SlowDownRagdollDeath");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBeTracked;
    /// <summary>
    /// Function: CanBeTracked
    /// </summary>
    public unsafe override bool CanBeTracked()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeTracked, "BmGame.RPawnPlayer.CanBeTracked");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetCameraStateName;
    /// <summary>
    /// Function: GetCameraStateName
    /// </summary>
    public unsafe virtual BmSDK.FName GetCameraStateName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCameraStateName, "BmGame.RPawnPlayer.GetCameraStateName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPCStateName;
    /// <summary>
    /// Function: GetPCStateName
    /// </summary>
    public unsafe virtual BmSDK.FName GetPCStateName()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPCStateName, "BmGame.RPawnPlayer.GetPCStateName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetThoughts;
    /// <summary>
    /// Function: GetThoughts
    /// </summary>
    public unsafe override void GetThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThoughts, "BmGame.RPawnPlayer.GetThoughts");
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
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_GetDamageResistance;
    /// <summary>
    /// Function: GetDamageResistance
    /// </summary>
    public unsafe virtual int GetDamageResistance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDamageResistance, "BmGame.RPawnPlayer.GetDamageResistance");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetRangedDamageResistance;
    /// <summary>
    /// Function: GetRangedDamageResistance
    /// </summary>
    public unsafe virtual int GetRangedDamageResistance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRangedDamageResistance, "BmGame.RPawnPlayer.GetRangedDamageResistance");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AllowIdleOverlaysAgain;
    /// <summary>
    /// Function: AllowIdleOverlaysAgain
    /// </summary>
    public unsafe virtual void AllowIdleOverlaysAgain()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowIdleOverlaysAgain, "BmGame.RPawnPlayer.AllowIdleOverlaysAgain");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TempStopIdleOverlays;
    /// <summary>
    /// Function: TempStopIdleOverlays
    /// </summary>
    public unsafe virtual void TempStopIdleOverlays(float T = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TempStopIdleOverlays, "BmGame.RPawnPlayer.TempStopIdleOverlays");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientPlayHitReaction;
    /// <summary>
    /// Function: ClientPlayHitReaction
    /// </summary>
    public unsafe virtual void ClientPlayHitReaction(BmSDK.Class DamageType, BmSDK.BmGame.RPawnPlayer.HitDamageDirection ReactionDirection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientPlayHitReaction, "BmGame.RPawnPlayer.ClientPlayHitReaction");
        byte* paramsPtr = stackalloc byte[21];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReactionDirection, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayHitReaction;
    /// <summary>
    /// Function: PlayHitReaction
    /// </summary>
    public unsafe virtual void PlayHitReaction(BmSDK.Class DamageType, BmSDK.BmGame.RPawnPlayer.HitDamageDirection ReactionDirection)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayHitReaction, "BmGame.RPawnPlayer.PlayHitReaction");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReactionDirection, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TrackDamageTakenStats;
    /// <summary>
    /// Function: TrackDamageTakenStats
    /// </summary>
    public unsafe virtual void TrackDamageTakenStats(BmSDK.Engine.Controller Damager, int DamageAmount, BmSDK.Class dmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TrackDamageTakenStats, "BmGame.RPawnPlayer.TrackDamageTakenStats");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damager, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TakeDamage;
    /// <summary>
    /// Function: TakeDamage
    /// </summary>
    public unsafe override void TakeDamage(int Damage, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeDamage, "BmGame.RPawnPlayer.TakeDamage");
        byte* paramsPtr = stackalloc byte[180];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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

    private static BmSDK.Function __fn_ShouldTrackDamageForIntimidation;
    /// <summary>
    /// Function: ShouldTrackDamageForIntimidation
    /// </summary>
    public unsafe virtual bool ShouldTrackDamageForIntimidation(BmSDK.Engine.Controller InstigatedBy, int DamageAmount, BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldTrackDamageForIntimidation, "BmGame.RPawnPlayer.ShouldTrackDamageForIntimidation");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_AdjustDamage;
    /// <summary>
    /// Function: AdjustDamage
    /// </summary>
    public unsafe override void AdjustDamage(out int InDamage, out System.Numerics.Vector3 Momentum, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo, BmSDK.Engine.Actor DamageCauser)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdjustDamage, "BmGame.RPawnPlayer.AdjustDamage");
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out InDamage);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InDamage, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Momentum);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 72);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        InDamage = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        Momentum = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_DamagedBy;
    /// <summary>
    /// Function: DamagedBy
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult DamagedBy(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DamagedBy, "BmGame.RPawnPlayer.DamagedBy");
        byte* paramsPtr = stackalloc byte[261];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 244);
    }

    private static BmSDK.Function __fn_BeginDeathOverview;
    /// <summary>
    /// Function: BeginDeathOverview
    /// </summary>
    public unsafe virtual void BeginDeathOverview()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginDeathOverview, "BmGame.RPawnPlayer.BeginDeathOverview");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TakeDamageFrom;
    /// <summary>
    /// Function: TakeDamageFrom
    /// </summary>
    public unsafe virtual bool TakeDamageFrom(BmSDK.Engine.Controller InstigatedBy)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeDamageFrom, "BmGame.RPawnPlayer.TakeDamageFrom");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_StruckEnemy;
    /// <summary>
    /// Function: StruckEnemy
    /// </summary>
    public unsafe virtual void StruckEnemy(BmSDK.BmGame.RPawnCombat TheEnemy)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StruckEnemy, "BmGame.RPawnPlayer.StruckEnemy");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheEnemy, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsFullArmour;
    /// <summary>
    /// Function: IsFullArmour
    /// </summary>
    public unsafe virtual bool IsFullArmour()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFullArmour, "BmGame.RPawnPlayer.IsFullArmour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ApplyArmour;
    /// <summary>
    /// Function: ApplyArmour
    /// </summary>
    public unsafe virtual void ApplyArmour(out int Damage, BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyArmour, "BmGame.RPawnPlayer.ApplyArmour");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Damage);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Damage = BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_RestoreArmour;
    /// <summary>
    /// Function: RestoreArmour
    /// </summary>
    public unsafe virtual void RestoreArmour(int ExtraHealth)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestoreArmour, "BmGame.RPawnPlayer.RestoreArmour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraHealth, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugRemoveArmour;
    /// <summary>
    /// Function: DebugRemoveArmour
    /// </summary>
    public unsafe virtual void DebugRemoveArmour()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugRemoveArmour, "BmGame.RPawnPlayer.DebugRemoveArmour");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugGiveArmour;
    /// <summary>
    /// Function: DebugGiveArmour
    /// </summary>
    public unsafe virtual void DebugGiveArmour()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugGiveArmour, "BmGame.RPawnPlayer.DebugGiveArmour");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldPlayHitReaction;
    /// <summary>
    /// Function: ShouldPlayHitReaction
    /// </summary>
    public unsafe virtual bool ShouldPlayHitReaction(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo, BmSDK.Class RangedDmgType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldPlayHitReaction, "BmGame.RPawnPlayer.ShouldPlayHitReaction");
        byte* paramsPtr = stackalloc byte[268];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RangedDmgType, paramsPtr + 244);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 248);
    }

    private static BmSDK.Function __fn_AdjustForLocationalDamage;
    /// <summary>
    /// Function: AdjustForLocationalDamage
    /// </summary>
    public unsafe virtual void AdjustForLocationalDamage(out float Damage, System.Numerics.Vector3 HitLocation, BmSDK.BmGame.RPlayerController KillerController)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdjustForLocationalDamage, "BmGame.RPawnPlayer.AdjustForLocationalDamage");
        byte* paramsPtr = stackalloc byte[41];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Damage);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KillerController, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Damage = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_IsInAimingMode;
    /// <summary>
    /// Function: IsInAimingMode
    /// </summary>
    public unsafe virtual bool IsInAimingMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInAimingMode, "BmGame.RPawnPlayer.IsInAimingMode");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AdjustDamageForConsumables;
    /// <summary>
    /// Function: AdjustDamageForConsumables
    /// </summary>
    public unsafe virtual void AdjustDamageForConsumables(BmSDK.Class dmgType, BmSDK.Engine.OnlineSubsystem.FUniqueNetId VictimNetId, BmSDK.Engine.OnlineSubsystem.FUniqueNetId AttackerNetId, bool Headshot, bool IsEvading, out float Damage)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdjustDamageForConsumables, "BmGame.RPawnPlayer.AdjustDamageForConsumables");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VictimNetId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackerNetId, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Headshot, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsEvading, paramsPtr + 24);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Damage);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Damage = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 28);
        return;
    }

    private static BmSDK.Function __fn_GetShotLocation;
    /// <summary>
    /// Function: GetShotLocation
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.RecordedShotLocations GetShotLocation(System.Numerics.Vector3 HitLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetShotLocation, "BmGame.RPawnPlayer.GetShotLocation");
        byte* paramsPtr = stackalloc byte[57];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.RecordedShotLocations>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_IsHeadshot;
    /// <summary>
    /// Function: IsHeadshot
    /// </summary>
    public unsafe virtual bool IsHeadshot(System.Numerics.Vector3 HitLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsHeadshot, "BmGame.RPawnPlayer.IsHeadshot");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ShotBy;
    /// <summary>
    /// Function: ShotBy
    /// </summary>
    public unsafe virtual void ShotBy(out BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo, System.Numerics.Vector3 HitLocation = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShotBy, "BmGame.RPawnPlayer.ShotBy");
        byte* paramsPtr = stackalloc byte[288];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 244);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DmgInfo = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat.FDamageInfo>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_HealDamage;
    /// <summary>
    /// Function: HealDamage
    /// </summary>
    public unsafe override bool HealDamage(int Amount, BmSDK.Engine.Controller Healer, BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HealDamage, "BmGame.RPawnPlayer.HealDamage");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Amount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Healer, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_RestoreHealthAndArmour;
    /// <summary>
    /// Function: RestoreHealthAndArmour
    /// </summary>
    public unsafe virtual void RestoreHealthAndArmour(int HealthToRecover)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestoreHealthAndArmour, "BmGame.RPawnPlayer.RestoreHealthAndArmour");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HealthToRecover, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayDeathAnim;
    /// <summary>
    /// Function: PlayDeathAnim
    /// </summary>
    public unsafe virtual void PlayDeathAnim(BmSDK.FName DeathAnim, BmSDK.Engine.AnimSet AnimSet, System.Numerics.Vector3 HitDir = default, bool bDelayTransitionForRagDoll = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayDeathAnim, "BmGame.RPawnPlayer.PlayDeathAnim");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeathAnim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitDir, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDelayTransitionForRagDoll, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayDeathAnimAndCape;
    /// <summary>
    /// Function: PlayDeathAnimAndCape
    /// </summary>
    public unsafe virtual void PlayDeathAnimAndCape(BmSDK.FName DeathAnim, BmSDK.Engine.AnimSet AnimSet, System.Numerics.Vector3 HitDir = default, bool bDelayTransitionForRagDoll = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayDeathAnimAndCape, "BmGame.RPawnPlayer.PlayDeathAnimAndCape");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeathAnim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitDir, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDelayTransitionForRagDoll, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WillFlightPathHit;
    /// <summary>
    /// Function: WillFlightPathHit
    /// </summary>
    public unsafe virtual bool WillFlightPathHit(float FlightTime, out System.Numerics.Vector3 OverrideStartPos, bool bDrawDebug)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WillFlightPathHit, "BmGame.RPawnPlayer.WillFlightPathHit");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlightTime, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out OverrideStartPos);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideStartPos, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawDebug, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OverrideStartPos = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_SetupLocatorFromCornerPoint;
    /// <summary>
    /// Function: SetupLocatorFromCornerPoint
    /// </summary>
    public unsafe virtual void SetupLocatorFromCornerPoint(BmSDK.BmGame.RCornerWallMarkerBase Corner, out BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupLocatorFromCornerPoint, "BmGame.RPawnPlayer.SetupLocatorFromCornerPoint");
        byte* paramsPtr = stackalloc byte[132];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Corner, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Loc);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Loc = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_GetRailingTopAndNormal;
    /// <summary>
    /// Function: GetRailingTopAndNormal
    /// </summary>
    public unsafe virtual void GetRailingTopAndNormal(BmSDK.Engine.StaticMeshActorBase Railing, out BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator out_Locator)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetRailingTopAndNormal, "BmGame.RPawnPlayer.GetRailingTopAndNormal");
        byte* paramsPtr = stackalloc byte[132];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Railing, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_Locator);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_Locator, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_Locator = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(paramsPtr + 4);
        return;
    }

    private static BmSDK.Function __fn_SetDeferredVelocity;
    /// <summary>
    /// Function: SetDeferredVelocity
    /// </summary>
    public unsafe virtual void SetDeferredVelocity(System.Numerics.Vector3 NewVelocity)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDeferredVelocity, "BmGame.RPawnPlayer.SetDeferredVelocity");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewVelocity, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ShouldIFallOffEdge;
    /// <summary>
    /// Function: ShouldIFallOffEdge
    /// </summary>
    public unsafe virtual bool ShouldIFallOffEdge(bool bCheckForLand = default, bool bForceCheck = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldIFallOffEdge, "BmGame.RPawnPlayer.ShouldIFallOffEdge");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheckForLand, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceCheck, paramsPtr + 4);
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

    private static BmSDK.Function __fn_GetCharacterType;
    /// <summary>
    /// Function: GetCharacterType
    /// </summary>
    public unsafe override BmSDK.FName GetCharacterType()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCharacterType, "BmGame.RPawnPlayer.GetCharacterType");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_FindContactName;
    /// <summary>
    /// Function: FindContactName
    /// </summary>
    public unsafe override BmSDK.Engine.AkEvent FindContactName(BmSDK.BmGame.RAnimNotify_Footstep.EFoot Foot, BmSDK.BmGame.RAnimNotify_Footstep.EContactType Contact)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindContactName, "BmGame.RPawnPlayer.FindContactName");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Foot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Contact, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetOwnerNoSee;
    /// <summary>
    /// Function: SetOwnerNoSee
    /// </summary>
    public unsafe virtual void SetOwnerNoSee(bool bNewOwnerNoSee)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOwnerNoSee, "BmGame.RPawnPlayer.SetOwnerNoSee");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewOwnerNoSee, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckSpaceForGrappleRoll;
    /// <summary>
    /// Function: CheckSpaceForGrappleRoll
    /// </summary>
    public unsafe virtual bool CheckSpaceForGrappleRoll(BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckSpaceForGrappleRoll, "BmGame.RPawnPlayer.CheckSpaceForGrappleRoll");
        byte* paramsPtr = stackalloc byte[132];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 112);
    }

    private static BmSDK.Function __fn_CanPerformLandRoll;
    /// <summary>
    /// Function: CanPerformLandRoll
    /// </summary>
    public unsafe virtual bool CanPerformLandRoll(System.Numerics.Vector3 LandLocation, System.Numerics.Vector3 Direction, float Distance, bool bCheckDropAtEnd = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformLandRoll, "BmGame.RPawnPlayer.CanPerformLandRoll");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LandLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Distance, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheckDropAtEnd, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_IsLedgeATunnelLedge;
    /// <summary>
    /// Function: IsLedgeATunnelLedge
    /// </summary>
    public unsafe virtual bool IsLedgeATunnelLedge(BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLedgeATunnelLedge, "BmGame.RPawnPlayer.IsLedgeATunnelLedge");
        byte* paramsPtr = stackalloc byte[132];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 112);
    }

    private static BmSDK.Function __fn_IsLedgeADangleLedge;
    /// <summary>
    /// Function: IsLedgeADangleLedge
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnPlayer.EHangLedgeType IsLedgeADangleLedge(BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLedgeADangleLedge, "BmGame.RPawnPlayer.IsLedgeADangleLedge");
        byte* paramsPtr = stackalloc byte[129];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayer.EHangLedgeType>(paramsPtr + 112);
    }

    private static BmSDK.Function __fn_OnDestroyPhysicsAssetInstance;
    /// <summary>
    /// Function: OnDestroyPhysicsAssetInstance
    /// </summary>
    public unsafe virtual void OnDestroyPhysicsAssetInstance(BmSDK.Engine.SkeletalMeshComponent AffectedComponent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnDestroyPhysicsAssetInstance, "BmGame.RPawnPlayer.OnDestroyPhysicsAssetInstance");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AffectedComponent, paramsPtr + 0);
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

    private static BmSDK.Function __fn_OnCreatePhysicsAssetInstance;
    /// <summary>
    /// Function: OnCreatePhysicsAssetInstance
    /// </summary>
    public unsafe virtual void OnCreatePhysicsAssetInstance(BmSDK.Engine.SkeletalMeshComponent AffectedComponent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnCreatePhysicsAssetInstance, "BmGame.RPawnPlayer.OnCreatePhysicsAssetInstance");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AffectedComponent, paramsPtr + 0);
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

    private static BmSDK.Function __fn_EndGelSpray;
    /// <summary>
    /// Function: EndGelSpray
    /// </summary>
    public unsafe virtual void EndGelSpray()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndGelSpray, "BmGame.RPawnPlayer.EndGelSpray");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartGelSpray;
    /// <summary>
    /// Function: StartGelSpray
    /// </summary>
    public unsafe virtual void StartGelSpray()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartGelSpray, "BmGame.RPawnPlayer.StartGelSpray");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FireLineLauncher;
    /// <summary>
    /// Function: FireLineLauncher
    /// </summary>
    public unsafe virtual void FireLineLauncher()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FireLineLauncher, "BmGame.RPawnPlayer.FireLineLauncher");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReplicateWeaponStop;
    /// <summary>
    /// Function: ReplicateWeaponStop
    /// </summary>
    public unsafe virtual void ReplicateWeaponStop()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplicateWeaponStop, "BmGame.RPawnPlayer.ReplicateWeaponStop");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReplicateWeaponFireSimple;
    /// <summary>
    /// Function: ReplicateWeaponFireSimple
    /// </summary>
    public unsafe virtual void ReplicateWeaponFireSimple(System.Numerics.Vector3 LastHitLocation, in BmSDK.FString PhysMat, BmSDK.BmGame.RPawnPlayer HitPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplicateWeaponFireSimple, "BmGame.RPawnPlayer.ReplicateWeaponFireSimple");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LastHitLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PhysMat, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPlayer, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReplicateWeaponFire;
    /// <summary>
    /// Function: ReplicateWeaponFire
    /// </summary>
    public unsafe virtual void ReplicateWeaponFire(System.Numerics.Vector3 LastHitLocation, BmSDK.BmGame.RPawnPlayer.FGadgetFiringData FiringData, float fTraceLength)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplicateWeaponFire, "BmGame.RPawnPlayer.ReplicateWeaponFire");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LastHitLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FiringData, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fTraceLength, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateWeaponFiring;
    /// <summary>
    /// Function: UpdateWeaponFiring
    /// </summary>
    public unsafe virtual void UpdateWeaponFiring()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateWeaponFiring, "BmGame.RPawnPlayer.UpdateWeaponFiring");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CleanupForRestart;
    /// <summary>
    /// Function: CleanupForRestart
    /// </summary>
    public unsafe virtual void CleanupForRestart()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CleanupForRestart, "BmGame.RPawnPlayer.CleanupForRestart");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugInfiniteAmmo;
    /// <summary>
    /// Function: DebugInfiniteAmmo
    /// </summary>
    public unsafe virtual void DebugInfiniteAmmo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugInfiniteAmmo, "BmGame.RPawnPlayer.DebugInfiniteAmmo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RestoreAmmo;
    /// <summary>
    /// Function: RestoreAmmo
    /// </summary>
    public unsafe virtual void RestoreAmmo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestoreAmmo, "BmGame.RPawnPlayer.RestoreAmmo");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGlideKickEffectLocation;
    /// <summary>
    /// Function: GetGlideKickEffectLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetGlideKickEffectLocation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGlideKickEffectLocation, "BmGame.RPawnPlayer.GetGlideKickEffectLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_DebugGiveAllGadgets;
    /// <summary>
    /// Function: DebugGiveAllGadgets
    /// </summary>
    public unsafe virtual void DebugGiveAllGadgets()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugGiveAllGadgets, "BmGame.RPawnPlayer.DebugGiveAllGadgets");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetFirstGadgetOfClass;
    /// <summary>
    /// Function: GetFirstGadgetOfClass
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RInventoryGadget GetFirstGadgetOfClass(BmSDK.Class GadgetClass)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFirstGadgetOfClass, "BmGame.RPawnPlayer.GetFirstGadgetOfClass");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RInventoryGadget>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetGadgetIdxFromTemplate;
    /// <summary>
    /// Function: GetGadgetIdxFromTemplate
    /// </summary>
    public unsafe virtual int GetGadgetIdxFromTemplate(BmSDK.BmGame.RInventoryGadget GadgetTemplate)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetIdxFromTemplate, "BmGame.RPawnPlayer.GetGadgetIdxFromTemplate");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetTemplate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetGadgetIdx;
    /// <summary>
    /// Function: GetGadgetIdx
    /// </summary>
    public unsafe virtual int GetGadgetIdx(BmSDK.BmGame.RInventoryGadget Gadget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGadgetIdx, "BmGame.RPawnPlayer.GetGadgetIdx");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Gadget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GiveLoadout;
    /// <summary>
    /// Function: GiveLoadout
    /// </summary>
    public unsafe virtual void GiveLoadout(BmSDK.BmGame.RGameInfo.FGDPlayerLoadout Loadout)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveLoadout, "BmGame.RPawnPlayer.GiveLoadout");
        byte* paramsPtr = stackalloc byte[284];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loadout, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHeldGadgetByGadgetID;
    /// <summary>
    /// Function: GetHeldGadgetByGadgetID
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RInventoryGadget GetHeldGadgetByGadgetID(BmSDK.BmGame.RGameInfo.PlayerGadgetId _gadget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeldGadgetByGadgetID, "BmGame.RPawnPlayer.GetHeldGadgetByGadgetID");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_gadget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RInventoryGadget>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_AddGadget;
    /// <summary>
    /// Function: AddGadget
    /// </summary>
    public unsafe virtual void AddGadget(BmSDK.BmGame.RInventoryGadget NewGadget, bool UpdateHud = default, bool bDuringSetup = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddGadget, "BmGame.RPawnPlayer.AddGadget");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGadget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdateHud, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDuringSetup, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GiveGadget;
    /// <summary>
    /// Function: GiveGadget
    /// </summary>
    public unsafe virtual void GiveGadget(BmSDK.Class GadgetClass, bool UpdateHud = default, bool bDuringSetup = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveGadget, "BmGame.RPawnPlayer.GiveGadget");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdateHud, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDuringSetup, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnGiveInventory;
    /// <summary>
    /// Function: OnGiveInventory
    /// </summary>
    public unsafe override void OnGiveInventory(BmSDK.Engine.SeqAct_GiveInventory inAction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnGiveInventory, "BmGame.RPawnPlayer.OnGiveInventory");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GainedChild;
    /// <summary>
    /// Function: GainedChild
    /// </summary>
    public unsafe override void GainedChild(BmSDK.Engine.Actor Other)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GainedChild, "BmGame.RPawnPlayer.GainedChild");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayCrowStartledLine;
    /// <summary>
    /// Function: PlayCrowStartledLine
    /// </summary>
    public unsafe virtual void PlayCrowStartledLine()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCrowStartledLine, "BmGame.RPawnPlayer.PlayCrowStartledLine");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayWouldBreakNewGamePlusLine;
    /// <summary>
    /// Function: PlayWouldBreakNewGamePlusLine
    /// </summary>
    public unsafe virtual void PlayWouldBreakNewGamePlusLine()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayWouldBreakNewGamePlusLine, "BmGame.RPawnPlayer.PlayWouldBreakNewGamePlusLine");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateInvClass;
    /// <summary>
    /// Function: UpdateInvClass
    /// </summary>
    public unsafe virtual BmSDK.Class UpdateInvClass(BmSDK.Class InvClass)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateInvClass, "BmGame.RPawnPlayer.UpdateInvClass");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InvClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PostOverridableTransition;
    /// <summary>
    /// Function: PostOverridableTransition
    /// </summary>
    public unsafe virtual void PostOverridableTransition(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId OverriddenTranstion, float TimeIntoTransition)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostOverridableTransition, "BmGame.RPawnPlayer.PostOverridableTransition");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverriddenTranstion, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeIntoTransition, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearOverridableTransition;
    /// <summary>
    /// Function: ClearOverridableTransition
    /// </summary>
    public unsafe virtual void ClearOverridableTransition()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearOverridableTransition, "BmGame.RPawnPlayer.ClearOverridableTransition");
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

    private static BmSDK.Function __fn_Set1stPerson;
    /// <summary>
    /// Function: Set1stPerson
    /// </summary>
    public unsafe virtual void Set1stPerson(bool bHideMeshes)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Set1stPerson, "BmGame.RPawnPlayer.Set1stPerson");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHideMeshes, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AnimationTriggerCallback;
    /// <summary>
    /// Function: AnimationTriggerCallback
    /// </summary>
    public unsafe override void AnimationTriggerCallback(BmSDK.FName TagName, BmSDK.TArray<BmSDK.FString> Params, BmSDK.Engine.AnimSet TagAnimSet, float Time)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AnimationTriggerCallback, "BmGame.RPawnPlayer.AnimationTriggerCallback");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TagName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Params, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TagAnimSet, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EncroachedBy;
    /// <summary>
    /// Function: EncroachedBy
    /// </summary>
    public unsafe override void EncroachedBy(BmSDK.Engine.Actor Other)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EncroachedBy, "BmGame.RPawnPlayer.EncroachedBy");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Touch;
    /// <summary>
    /// Function: Touch
    /// </summary>
    public unsafe override void Touch(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Touch, "BmGame.RPawnPlayer.Touch");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HitWall;
    /// <summary>
    /// Function: HitWall
    /// </summary>
    public unsafe override void HitWall(System.Numerics.Vector3 HitNormal, BmSDK.Engine.Actor Wall, BmSDK.Engine.PrimitiveComponent WallComp)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HitWall, "BmGame.RPawnPlayer.HitWall");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Wall, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallComp, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Bump;
    /// <summary>
    /// Function: Bump
    /// </summary>
    public unsafe override void Bump(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitNormal)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Bump, "BmGame.RPawnPlayer.Bump");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetGroundFriction;
    /// <summary>
    /// Function: ResetGroundFriction
    /// </summary>
    public unsafe virtual void ResetGroundFriction()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetGroundFriction, "BmGame.RPawnPlayer.ResetGroundFriction");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EndCrouch;
    /// <summary>
    /// Function: EndCrouch
    /// </summary>
    public unsafe override void EndCrouch(float HeightAdjust)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EndCrouch, "BmGame.RPawnPlayer.EndCrouch");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HeightAdjust, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartCrouch;
    /// <summary>
    /// Function: StartCrouch
    /// </summary>
    public unsafe override void StartCrouch(float HeightAdjust)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartCrouch, "BmGame.RPawnPlayer.StartCrouch");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HeightAdjust, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_gibbedBy;
    /// <summary>
    /// Function: gibbedBy
    /// </summary>
    public unsafe override void gibbedBy(BmSDK.Engine.Actor Other)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_gibbedBy, "BmGame.RPawnPlayer.gibbedBy");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ImmuneToBatarang;
    /// <summary>
    /// Function: ImmuneToBatarang
    /// </summary>
    public unsafe virtual bool ImmuneToBatarang(bool ActualHit, BmSDK.BmGame.RPawnPlayer Thrower)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ImmuneToBatarang, "BmGame.RPawnPlayer.ImmuneToBatarang");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActualHit, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thrower, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_DoCustomVisCheck;
    /// <summary>
    /// Function: DoCustomVisCheck
    /// </summary>
    public unsafe virtual bool DoCustomVisCheck()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoCustomVisCheck, "BmGame.RPawnPlayer.DoCustomVisCheck");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBatarangSpeedBoost;
    /// <summary>
    /// Function: GetBatarangSpeedBoost
    /// </summary>
    public unsafe virtual float GetBatarangSpeedBoost()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatarangSpeedBoost, "BmGame.RPawnPlayer.GetBatarangSpeedBoost");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ForceHitAtEndOfFlight;
    /// <summary>
    /// Function: ForceHitAtEndOfFlight
    /// </summary>
    public unsafe virtual bool ForceHitAtEndOfFlight()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceHitAtEndOfFlight, "BmGame.RPawnPlayer.ForceHitAtEndOfFlight");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBatarangPriority;
    /// <summary>
    /// Function: GetBatarangPriority
    /// </summary>
    public unsafe virtual float GetBatarangPriority()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatarangPriority, "BmGame.RPawnPlayer.GetBatarangPriority");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBatarangTargetPosition;
    /// <summary>
    /// Function: GetBatarangTargetPosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetBatarangTargetPosition(System.Numerics.Vector3 AimLocation, System.Numerics.Vector3 AimDirection, bool bDuringTargetPhase = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatarangTargetPosition, "BmGame.RPawnPlayer.GetBatarangTargetPosition");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimDirection, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDuringTargetPhase, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_HideStaff;
    /// <summary>
    /// Function: HideStaff
    /// </summary>
    public unsafe virtual void HideStaff()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HideStaff, "BmGame.RPawnPlayer.HideStaff");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetHarpoonOpenGrateMove;
    /// <summary>
    /// Function: GetHarpoonOpenGrateMove
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RSpecialMoveConfig GetHarpoonOpenGrateMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHarpoonOpenGrateMove, "BmGame.RPawnPlayer.GetHarpoonOpenGrateMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateGrateExcluder;
    /// <summary>
    /// Function: UpdateGrateExcluder
    /// </summary>
    public unsafe virtual void UpdateGrateExcluder()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateGrateExcluder, "BmGame.RPawnPlayer.UpdateGrateExcluder");
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

    private static BmSDK.Function __fn_FindNearbyLedge;
    /// <summary>
    /// Function: FindNearbyLedge
    /// </summary>
    public unsafe virtual bool FindNearbyLedge(System.Numerics.Vector3 PlayerLocation, out BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Locator, float MinimalDrop = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindNearbyLedge, "BmGame.RPawnPlayer.FindNearbyLedge");
        byte* paramsPtr = stackalloc byte[148];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLocation, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out Locator);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Locator, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinimalDrop, paramsPtr + 124);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Locator = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 128);
    }

    private static BmSDK.Function __fn_ForceUnCrouch;
    /// <summary>
    /// Function: ForceUnCrouch
    /// </summary>
    public unsafe virtual void ForceUnCrouch()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ForceUnCrouch, "BmGame.RPawnPlayer.ForceUnCrouch");
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

    private static BmSDK.Function __fn_UpdateShimmyEnv;
    /// <summary>
    /// Function: UpdateShimmyEnv
    /// </summary>
    public unsafe virtual void UpdateShimmyEnv(float CollisionHeight, float CollisionRadius, float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateShimmyEnv, "BmGame.RPawnPlayer.UpdateShimmyEnv");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionHeight, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionRadius, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 8);
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

    private static BmSDK.Function __fn_CheckSurroundingEnvironment;
    /// <summary>
    /// Function: CheckSurroundingEnvironment
    /// </summary>
    public unsafe virtual void CheckSurroundingEnvironment(float CollisionHeight, float CollisionRadius, float DeltaTime, BmSDK.Engine.PrimitiveComponent HintPrimitive = default, bool forceForNonLocalController = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckSurroundingEnvironment, "BmGame.RPawnPlayer.CheckSurroundingEnvironment");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionHeight, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionRadius, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HintPrimitive, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(forceForNonLocalController, paramsPtr + 16);
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

    private static BmSDK.Function __fn_CheckForInterrogationEnvironment;
    /// <summary>
    /// Function: CheckForInterrogationEnvironment
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator CheckForInterrogationEnvironment(BmSDK.BmGame.RPawnCombat CheckPawn, float FeatureCheckDistance = default, BmSDK.BmGame.RBM2IdleConfig.EInterrogationPose InterrogationPose = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForInterrogationEnvironment, "BmGame.RPawnPlayer.CheckForInterrogationEnvironment");
        byte* paramsPtr = stackalloc byte[140];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FeatureCheckDistance, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterrogationPose, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ClientSetGrapplePoint;
    /// <summary>
    /// Function: ClientSetGrapplePoint
    /// </summary>
    public unsafe virtual void ClientSetGrapplePoint(System.Numerics.Vector3 CurrentTarget, BmSDK.BmGame.RGrapplePoint GrapplePoint, BmSDK.Engine.Actor CurrentHidePoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientSetGrapplePoint, "BmGame.RPawnPlayer.ClientSetGrapplePoint");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrapplePoint, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentHidePoint, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerSetGrapplePoint;
    /// <summary>
    /// Function: ServerSetGrapplePoint
    /// </summary>
    public unsafe virtual void ServerSetGrapplePoint(System.Numerics.Vector3 CurrentTarget, BmSDK.BmGame.RGrapplePoint GrapplePoint, BmSDK.Engine.Actor CurrentHidePoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerSetGrapplePoint, "BmGame.RPawnPlayer.ServerSetGrapplePoint");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrapplePoint, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentHidePoint, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerChangeGadgetIdx;
    /// <summary>
    /// Function: ServerChangeGadgetIdx
    /// </summary>
    public unsafe virtual void ServerChangeGadgetIdx(int NewGadgetIdx)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerChangeGadgetIdx, "BmGame.RPawnPlayer.ServerChangeGadgetIdx");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGadgetIdx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SyncSuccessfullDisruption;
    /// <summary>
    /// Function: SyncSuccessfullDisruption
    /// </summary>
    public unsafe virtual void SyncSuccessfullDisruption(BmSDK.Engine.Actor Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SyncSuccessfullDisruption, "BmGame.RPawnPlayer.SyncSuccessfullDisruption");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HealthChanged;
    /// <summary>
    /// Function: HealthChanged
    /// </summary>
    public unsafe virtual void HealthChanged(int OldH, int NewH)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HealthChanged, "BmGame.RPawnPlayer.HealthChanged");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldH, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewH, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggeredSpecialMoveEndsIn;
    /// <summary>
    /// Function: TriggeredSpecialMoveEndsIn
    /// </summary>
    public unsafe virtual void TriggeredSpecialMoveEndsIn(BmSDK.FName FinalMovementStance)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggeredSpecialMoveEndsIn, "BmGame.RPawnPlayer.TriggeredSpecialMoveEndsIn");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinalMovementStance, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LocalGadgetTick;
    /// <summary>
    /// Function: LocalGadgetTick
    /// </summary>
    public unsafe virtual void LocalGadgetTick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LocalGadgetTick, "BmGame.RPawnPlayer.LocalGadgetTick");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTransitionSequenceName;
    /// <summary>
    /// Function: GetTransitionSequenceName
    /// </summary>
    public unsafe virtual BmSDK.FName GetTransitionSequenceName(BmSDK.FName NewPose)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTransitionSequenceName, "BmGame.RPawnPlayer.GetTransitionSequenceName");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPose, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FName>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_NetworkTick;
    /// <summary>
    /// Function: NetworkTick
    /// </summary>
    public unsafe virtual void NetworkTick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NetworkTick, "BmGame.RPawnPlayer.NetworkTick");
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

    private static BmSDK.Function __fn_DoPoseSpecificMovement;
    /// <summary>
    /// Function: DoPoseSpecificMovement
    /// </summary>
    public unsafe virtual void DoPoseSpecificMovement(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DoPoseSpecificMovement, "BmGame.RPawnPlayer.DoPoseSpecificMovement");
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

    private static BmSDK.Function __fn_NonLocalNetworkTick;
    /// <summary>
    /// Function: NonLocalNetworkTick
    /// </summary>
    public unsafe virtual void NonLocalNetworkTick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NonLocalNetworkTick, "BmGame.RPawnPlayer.NonLocalNetworkTick");
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

    private static BmSDK.Function __fn_CorrectServerPos;
    /// <summary>
    /// Function: CorrectServerPos
    /// </summary>
    public unsafe virtual void CorrectServerPos(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CorrectServerPos, "BmGame.RPawnPlayer.CorrectServerPos");
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

    private static BmSDK.Function __fn_PoseChanged;
    /// <summary>
    /// Function: PoseChanged
    /// </summary>
    public unsafe override void PoseChanged(BmSDK.FName OldPose, BmSDK.FName NewPose, BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId TransID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PoseChanged, "BmGame.RPawnPlayer.PoseChanged");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldPose, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPose, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransID, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SimulatedInitNewPose;
    /// <summary>
    /// Function: SimulatedInitNewPose
    /// </summary>
    public unsafe virtual void SimulatedInitNewPose(BmSDK.FName NewPose, bool NewPoseMirrored, BmSDK.FName OldPose, bool OldPoseMirrored)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SimulatedInitNewPose, "BmGame.RPawnPlayer.SimulatedInitNewPose");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPose, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPoseMirrored, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldPose, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldPoseMirrored, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SimulatedProcessRailingTurns;
    /// <summary>
    /// Function: SimulatedProcessRailingTurns
    /// </summary>
    public unsafe virtual void SimulatedProcessRailingTurns()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SimulatedProcessRailingTurns, "BmGame.RPawnPlayer.SimulatedProcessRailingTurns");
        byte* paramsPtr = stackalloc byte[108];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateReplenishingHealth;
    /// <summary>
    /// Function: UpdateReplenishingHealth
    /// </summary>
    public unsafe virtual void UpdateReplenishingHealth(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateReplenishingHealth, "BmGame.RPawnPlayer.UpdateReplenishingHealth");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateLockedState;
    /// <summary>
    /// Function: UpdateLockedState
    /// </summary>
    public unsafe virtual void UpdateLockedState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateLockedState, "BmGame.RPawnPlayer.UpdateLockedState");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdatePoisonEffect;
    /// <summary>
    /// Function: UpdatePoisonEffect
    /// </summary>
    public unsafe virtual void UpdatePoisonEffect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdatePoisonEffect, "BmGame.RPawnPlayer.UpdatePoisonEffect");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateHealthRegenEffect;
    /// <summary>
    /// Function: UpdateHealthRegenEffect
    /// </summary>
    public unsafe virtual void UpdateHealthRegenEffect()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateHealthRegenEffect, "BmGame.RPawnPlayer.UpdateHealthRegenEffect");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateGlideWake;
    /// <summary>
    /// Function: UpdateGlideWake
    /// </summary>
    public unsafe virtual void UpdateGlideWake()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateGlideWake, "BmGame.RPawnPlayer.UpdateGlideWake");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateHealthAudioEffects;
    /// <summary>
    /// Function: UpdateHealthAudioEffects
    /// </summary>
    public unsafe virtual void UpdateHealthAudioEffects()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateHealthAudioEffects, "BmGame.RPawnPlayer.UpdateHealthAudioEffects");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Defrost;
    /// <summary>
    /// Function: Defrost
    /// </summary>
    public unsafe virtual void Defrost()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Defrost, "BmGame.RPawnPlayer.Defrost");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Frozen;
    /// <summary>
    /// Function: Frozen
    /// </summary>
    public unsafe virtual void Frozen(float FreezeTime, bool bViaReplication = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Frozen, "BmGame.RPawnPlayer.Frozen");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FreezeTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bViaReplication, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsFrozen;
    /// <summary>
    /// Function: IsFrozen
    /// </summary>
    public unsafe override bool IsFrozen()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsFrozen, "BmGame.RPawnPlayer.IsFrozen");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Tick, "BmGame.RPawnPlayer.Tick");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnFootstepNotify;
    /// <summary>
    /// Function: OnFootstepNotify
    /// </summary>
    public unsafe override void OnFootstepNotify(BmSDK.BmGame.RAnimNotify_Footstep.EFoot Foot, BmSDK.BmGame.RAnimNotify_Footstep.EContactType Contact, BmSDK.BmGame.RAnimNotify_Footstep.EFootstepSurfaceFinder SurfaceFinder, System.Numerics.Vector3 FootLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnFootstepNotify, "BmGame.RPawnPlayer.OnFootstepNotify");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Foot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Contact, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SurfaceFinder, paramsPtr + 2);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FootLocation, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayExplosionDeathPrimer;
    /// <summary>
    /// Function: PlayExplosionDeathPrimer
    /// </summary>
    public unsafe virtual bool PlayExplosionDeathPrimer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayExplosionDeathPrimer, "BmGame.RPawnPlayer.PlayExplosionDeathPrimer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_OverrideFrontBarrier;
    /// <summary>
    /// Function: OverrideFrontBarrier
    /// </summary>
    public unsafe virtual void OverrideFrontBarrier(BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator LocatorOverride)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OverrideFrontBarrier, "BmGame.RPawnPlayer.OverrideFrontBarrier");
        byte* paramsPtr = stackalloc byte[128];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocatorOverride, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyDistributedForceToRagdoll;
    /// <summary>
    /// Function: ApplyDistributedForceToRagdoll
    /// </summary>
    public unsafe virtual void ApplyDistributedForceToRagdoll()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyDistributedForceToRagdoll, "BmGame.RPawnPlayer.ApplyDistributedForceToRagdoll");
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

    private static BmSDK.Function __fn_Died;
    /// <summary>
    /// Function: Died
    /// </summary>
    public unsafe override bool Died(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Died, "BmGame.RPawnPlayer.Died");
        byte* paramsPtr = stackalloc byte[100];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_TakedownVictimAnimationReadyToPlay;
    /// <summary>
    /// Function: TakedownVictimAnimationReadyToPlay
    /// </summary>
    public unsafe override void TakedownVictimAnimationReadyToPlay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakedownVictimAnimationReadyToPlay, "BmGame.RPawnPlayer.TakedownVictimAnimationReadyToPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateLocalPlayerMusicState;
    /// <summary>
    /// Function: UpdateLocalPlayerMusicState
    /// </summary>
    public unsafe virtual void UpdateLocalPlayerMusicState()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateLocalPlayerMusicState, "BmGame.RPawnPlayer.UpdateLocalPlayerMusicState");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldDisplayDeathOverview;
    /// <summary>
    /// Function: ShouldDisplayDeathOverview
    /// </summary>
    public unsafe virtual bool ShouldDisplayDeathOverview(BmSDK.Class DamageType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldDisplayDeathOverview, "BmGame.RPawnPlayer.ShouldDisplayDeathOverview");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SelectDeathTip;
    /// <summary>
    /// Function: SelectDeathTip
    /// </summary>
    public unsafe virtual void SelectDeathTip(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation, bool bKilledInCombat)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SelectDeathTip, "BmGame.RPawnPlayer.SelectDeathTip");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKilledInCombat, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SelectDeathMovie;
    /// <summary>
    /// Function: SelectDeathMovie
    /// </summary>
    public unsafe virtual void SelectDeathMovie(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SelectDeathMovie, "BmGame.RPawnPlayer.SelectDeathMovie");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindAndPlayOverrideDeathAnim;
    /// <summary>
    /// Function: FindAndPlayOverrideDeathAnim
    /// </summary>
    public unsafe virtual bool FindAndPlayOverrideDeathAnim(BmSDK.Class DamageType, bool IsHeadshot)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindAndPlayOverrideDeathAnim, "BmGame.RPawnPlayer.FindAndPlayOverrideDeathAnim");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsHeadshot, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetHeartbeatOverride;
    /// <summary>
    /// Function: SetHeartbeatOverride
    /// </summary>
    public unsafe virtual void SetHeartbeatOverride(BmSDK.BmGame.RHudExtensionInvestigate.EHeartBeatType newHeartbeat)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetHeartbeatOverride, "BmGame.RPawnPlayer.SetHeartbeatOverride");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(newHeartbeat, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReplicateDied;
    /// <summary>
    /// Function: ReplicateDied
    /// </summary>
    public unsafe virtual void ReplicateDied(BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation, BmSDK.Engine.Actor DmgCauser, System.Numerics.Vector3 DmgImpulse, BmSDK.FName DmgBoneName, BmSDK.BmGame.RPawnPlayer.FExtraDeathInfo EDI)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplicateDied, "BmGame.RPawnPlayer.ReplicateDied");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgCauser, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgImpulse, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgBoneName, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EDI, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerIFFDeathAnim;
    /// <summary>
    /// Function: TriggerIFFDeathAnim
    /// </summary>
    public unsafe virtual void TriggerIFFDeathAnim(BmSDK.Engine.Actor DmgCauser)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerIFFDeathAnim, "BmGame.RPawnPlayer.TriggerIFFDeathAnim");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgCauser, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IFFDeathTimer;
    /// <summary>
    /// Function: IFFDeathTimer
    /// </summary>
    public unsafe virtual void IFFDeathTimer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IFFDeathTimer, "BmGame.RPawnPlayer.IFFDeathTimer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GoRagdoll;
    /// <summary>
    /// Function: GoRagdoll
    /// </summary>
    public unsafe virtual void GoRagdoll()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GoRagdoll, "BmGame.RPawnPlayer.GoRagdoll");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShowHealthAndArmour;
    /// <summary>
    /// Function: ShowHealthAndArmour
    /// </summary>
    public unsafe virtual void ShowHealthAndArmour()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShowHealthAndArmour, "BmGame.RPawnPlayer.ShowHealthAndArmour");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasUpgrade;
    /// <summary>
    /// Function: HasUpgrade
    /// </summary>
    public unsafe virtual bool HasUpgrade(BmSDK.FString UpgradeFlag)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasUpgrade, "BmGame.RPawnPlayer.HasUpgrade");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpgradeFlag, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_RestoreArmourProportional;
    /// <summary>
    /// Function: RestoreArmourProportional
    /// </summary>
    public unsafe virtual void RestoreArmourProportional(float RestoreProportion)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestoreArmourProportional, "BmGame.RPawnPlayer.RestoreArmourProportional");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RestoreProportion, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetArmourCurrent;
    /// <summary>
    /// Function: SetArmourCurrent
    /// </summary>
    public unsafe virtual void SetArmourCurrent(BmSDK.BmGame.RPawnPlayer.EArmourType armour_type, int current_armour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetArmourCurrent, "BmGame.RPawnPlayer.SetArmourCurrent");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(armour_type, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(current_armour, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetArmourMaximum;
    /// <summary>
    /// Function: GetArmourMaximum
    /// </summary>
    public unsafe virtual int GetArmourMaximum(BmSDK.BmGame.RPawnPlayer.EArmourType armour_type)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetArmourMaximum, "BmGame.RPawnPlayer.GetArmourMaximum");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(armour_type, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetArmourMaximum;
    /// <summary>
    /// Function: SetArmourMaximum
    /// </summary>
    public unsafe virtual void SetArmourMaximum(BmSDK.BmGame.RPawnPlayer.EArmourType armour_type, int max_armour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetArmourMaximum, "BmGame.RPawnPlayer.SetArmourMaximum");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(armour_type, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(max_armour, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateMaximumHealthAndArmour;
    /// <summary>
    /// Function: UpdateMaximumHealthAndArmour
    /// </summary>
    public unsafe virtual void UpdateMaximumHealthAndArmour(bool bReplenishArmour = default, bool bInitialUpdate = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateMaximumHealthAndArmour, "BmGame.RPawnPlayer.UpdateMaximumHealthAndArmour");
        byte* paramsPtr = stackalloc byte[72];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bReplenishArmour, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInitialUpdate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetUnlockedMeleeArmourLevel;
    /// <summary>
    /// Function: GetUnlockedMeleeArmourLevel
    /// </summary>
    public unsafe virtual int GetUnlockedMeleeArmourLevel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUnlockedMeleeArmourLevel, "BmGame.RPawnPlayer.GetUnlockedMeleeArmourLevel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetUnlockedBallisticArmourLevel;
    /// <summary>
    /// Function: GetUnlockedBallisticArmourLevel
    /// </summary>
    public unsafe virtual int GetUnlockedBallisticArmourLevel()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetUnlockedBallisticArmourLevel, "BmGame.RPawnPlayer.GetUnlockedBallisticArmourLevel");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetPersistentMeleeArmour;
    /// <summary>
    /// Function: SetPersistentMeleeArmour
    /// </summary>
    public unsafe virtual void SetPersistentMeleeArmour(int armour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPersistentMeleeArmour, "BmGame.RPawnPlayer.SetPersistentMeleeArmour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(armour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPersistentBallisticArmour;
    /// <summary>
    /// Function: SetPersistentBallisticArmour
    /// </summary>
    public unsafe virtual void SetPersistentBallisticArmour(int armour)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPersistentBallisticArmour, "BmGame.RPawnPlayer.SetPersistentBallisticArmour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(armour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPersistentMeleeArmour;
    /// <summary>
    /// Function: GetPersistentMeleeArmour
    /// </summary>
    public unsafe virtual int GetPersistentMeleeArmour()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPersistentMeleeArmour, "BmGame.RPawnPlayer.GetPersistentMeleeArmour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPersistentBallisticArmour;
    /// <summary>
    /// Function: GetPersistentBallisticArmour
    /// </summary>
    public unsafe virtual int GetPersistentBallisticArmour()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPersistentBallisticArmour, "BmGame.RPawnPlayer.GetPersistentBallisticArmour");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_HealthUpdated;
    /// <summary>
    /// Function: HealthUpdated
    /// </summary>
    public unsafe virtual void HealthUpdated()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HealthUpdated, "BmGame.RPawnPlayer.HealthUpdated");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnModifyHealth;
    /// <summary>
    /// Function: OnModifyHealth
    /// </summary>
    public unsafe override void OnModifyHealth(BmSDK.Engine.SeqAct_ModifyHealth Action)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnModifyHealth, "BmGame.RPawnPlayer.OnModifyHealth");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_LoadHealth;
    /// <summary>
    /// Function: LoadHealth
    /// </summary>
    public unsafe virtual void LoadHealth()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadHealth, "BmGame.RPawnPlayer.LoadHealth");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HealthRegen;
    /// <summary>
    /// Function: HealthRegen
    /// </summary>
    public unsafe virtual void HealthRegen()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HealthRegen, "BmGame.RPawnPlayer.HealthRegen");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitXRayMode;
    /// <summary>
    /// Function: ExitXRayMode
    /// </summary>
    public unsafe virtual void ExitXRayMode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitXRayMode, "BmGame.RPawnPlayer.ExitXRayMode");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RestoreDefaultXRayMICToMeshes;
    /// <summary>
    /// Function: RestoreDefaultXRayMICToMeshes
    /// </summary>
    public unsafe virtual void RestoreDefaultXRayMICToMeshes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestoreDefaultXRayMICToMeshes, "BmGame.RPawnPlayer.RestoreDefaultXRayMICToMeshes");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyXRayMICToMeshes;
    /// <summary>
    /// Function: ApplyXRayMICToMeshes
    /// </summary>
    public unsafe virtual void ApplyXRayMICToMeshes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyXRayMICToMeshes, "BmGame.RPawnPlayer.ApplyXRayMICToMeshes");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ApplyXRayParameters;
    /// <summary>
    /// Function: ApplyXRayParameters
    /// </summary>
    public unsafe virtual void ApplyXRayParameters(BmSDK.BmGame.GDXRayParameters Params)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyXRayParameters, "BmGame.RPawnPlayer.ApplyXRayParameters");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Params, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopGlideKickFX;
    /// <summary>
    /// Function: StopGlideKickFX
    /// </summary>
    public unsafe virtual void StopGlideKickFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopGlideKickFX, "BmGame.RPawnPlayer.StopGlideKickFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartGlideKickFX;
    /// <summary>
    /// Function: StartGlideKickFX
    /// </summary>
    public unsafe virtual void StartGlideKickFX(BmSDK.Engine.ParticleSystem OverrideFX, BmSDK.BmGame.RPlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartGlideKickFX, "BmGame.RPawnPlayer.StartGlideKickFX");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideFX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetOwningPawn;
    /// <summary>
    /// Function: GetOwningPawn
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnPlayer GetOwningPawn()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOwningPawn, "BmGame.RPawnPlayer.GetOwningPawn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayer>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RefreshCurrentXRay;
    /// <summary>
    /// Function: RefreshCurrentXRay
    /// </summary>
    public unsafe virtual void RefreshCurrentXRay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RefreshCurrentXRay, "BmGame.RPawnPlayer.RefreshCurrentXRay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetXRayMaterials;
    /// <summary>
    /// Function: ResetXRayMaterials
    /// </summary>
    public unsafe virtual void ResetXRayMaterials()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetXRayMaterials, "BmGame.RPawnPlayer.ResetXRayMaterials");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckDrawOutline;
    /// <summary>
    /// Function: CheckDrawOutline
    /// </summary>
    public unsafe virtual void CheckDrawOutline()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckDrawOutline, "BmGame.RPawnPlayer.CheckDrawOutline");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetFinishedLoadingAnims;
    /// <summary>
    /// Function: SetFinishedLoadingAnims
    /// </summary>
    public unsafe virtual void SetFinishedLoadingAnims(bool bFinished)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetFinishedLoadingAnims, "BmGame.RPawnPlayer.SetFinishedLoadingAnims");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFinished, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TrySetFinishedLoadingAnims;
    /// <summary>
    /// Function: TrySetFinishedLoadingAnims
    /// </summary>
    public unsafe virtual void TrySetFinishedLoadingAnims()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TrySetFinishedLoadingAnims, "BmGame.RPawnPlayer.TrySetFinishedLoadingAnims");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyTeamChanged;
    /// <summary>
    /// Function: NotifyTeamChanged
    /// </summary>
    public unsafe override void NotifyTeamChanged()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyTeamChanged, "BmGame.RPawnPlayer.NotifyTeamChanged");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RPawnPlayer.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_InitAnimNode;
    /// <summary>
    /// Function: InitAnimNode
    /// </summary>
    public unsafe override void InitAnimNode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitAnimNode, "BmGame.RPawnPlayer.InitAnimNode");
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

    private static BmSDK.Function __fn_StopMoveTo;
    /// <summary>
    /// Function: StopMoveTo
    /// </summary>
    public unsafe override void StopMoveTo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopMoveTo, "BmGame.RPawnPlayer.StopMoveTo");
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

    private static BmSDK.Function __fn_MoveInDirection;
    /// <summary>
    /// Function: MoveInDirection
    /// </summary>
    public unsafe override void MoveInDirection(System.Numerics.Vector3 Direction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveInDirection, "BmGame.RPawnPlayer.MoveInDirection");
        byte* paramsPtr = stackalloc byte[28];
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
        return;
    }

    private static BmSDK.Function __fn_SetChargeStrikeSpeed;
    /// <summary>
    /// Function: SetChargeStrikeSpeed
    /// </summary>
    public unsafe virtual void SetChargeStrikeSpeed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetChargeStrikeSpeed, "BmGame.RPawnPlayer.SetChargeStrikeSpeed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetStealthSpeed;
    /// <summary>
    /// Function: SetStealthSpeed
    /// </summary>
    public unsafe virtual void SetStealthSpeed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetStealthSpeed, "BmGame.RPawnPlayer.SetStealthSpeed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAimSpeed;
    /// <summary>
    /// Function: SetAimSpeed
    /// </summary>
    public unsafe virtual void SetAimSpeed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAimSpeed, "BmGame.RPawnPlayer.SetAimSpeed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetGlideSpeed;
    /// <summary>
    /// Function: SetGlideSpeed
    /// </summary>
    public unsafe virtual void SetGlideSpeed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetGlideSpeed, "BmGame.RPawnPlayer.SetGlideSpeed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetBatarangWalkSpeed;
    /// <summary>
    /// Function: SetBatarangWalkSpeed
    /// </summary>
    public unsafe virtual void SetBatarangWalkSpeed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetBatarangWalkSpeed, "BmGame.RPawnPlayer.SetBatarangWalkSpeed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetWalkSpeed;
    /// <summary>
    /// Function: SetWalkSpeed
    /// </summary>
    public unsafe virtual void SetWalkSpeed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWalkSpeed, "BmGame.RPawnPlayer.SetWalkSpeed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetAimBlendTime;
    /// <summary>
    /// Function: ResetAimBlendTime
    /// </summary>
    public unsafe virtual void ResetAimBlendTime()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetAimBlendTime, "BmGame.RPawnPlayer.ResetAimBlendTime");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetAimBlendTime;
    /// <summary>
    /// Function: SetAimBlendTime
    /// </summary>
    public unsafe virtual void SetAimBlendTime(float fNewAimBlendTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAimBlendTime, "BmGame.RPawnPlayer.SetAimBlendTime");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fNewAimBlendTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRunSpeed;
    /// <summary>
    /// Function: SetRunSpeed
    /// </summary>
    public unsafe virtual void SetRunSpeed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRunSpeed, "BmGame.RPawnPlayer.SetRunSpeed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AdjustMovementDirection;
    /// <summary>
    /// Function: AdjustMovementDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 AdjustMovementDirection(System.Numerics.Vector3 MovDir)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdjustMovementDirection, "BmGame.RPawnPlayer.AdjustMovementDirection");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovDir, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_TurnOnHandsIk;
    /// <summary>
    /// Function: TurnOnHandsIk
    /// </summary>
    public unsafe virtual bool TurnOnHandsIk(float fStrengthValue, float fEaseInTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TurnOnHandsIk, "BmGame.RPawnPlayer.TurnOnHandsIk");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fStrengthValue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fEaseInTime, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ResetNumQuickStrikeToRagdoll;
    /// <summary>
    /// Function: ResetNumQuickStrikeToRagdoll
    /// </summary>
    public unsafe virtual void ResetNumQuickStrikeToRagdoll()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetNumQuickStrikeToRagdoll, "BmGame.RPawnPlayer.ResetNumQuickStrikeToRagdoll");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetTimeToClearQuickStrikeCount;
    /// <summary>
    /// Function: GetTimeToClearQuickStrikeCount
    /// </summary>
    public unsafe virtual float GetTimeToClearQuickStrikeCount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTimeToClearQuickStrikeCount, "BmGame.RPawnPlayer.GetTimeToClearQuickStrikeCount");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNumQuickStrikeToRagdoll;
    /// <summary>
    /// Function: GetNumQuickStrikeToRagdoll
    /// </summary>
    public unsafe virtual int GetNumQuickStrikeToRagdoll()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumQuickStrikeToRagdoll, "BmGame.RPawnPlayer.GetNumQuickStrikeToRagdoll");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanReceiveAttackFromPawn;
    /// <summary>
    /// Function: CanReceiveAttackFromPawn
    /// </summary>
    public unsafe override bool CanReceiveAttackFromPawn(BmSDK.BmGame.RPawnCombat NewAttacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanReceiveAttackFromPawn, "BmGame.RPawnPlayer.CanReceiveAttackFromPawn");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetHealthRegenDelay;
    /// <summary>
    /// Function: GetHealthRegenDelay
    /// </summary>
    public unsafe virtual float GetHealthRegenDelay()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHealthRegenDelay, "BmGame.RPawnPlayer.GetHealthRegenDelay");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsGettingHealthRegenBoost;
    /// <summary>
    /// Function: IsGettingHealthRegenBoost
    /// </summary>
    public unsafe virtual bool IsGettingHealthRegenBoost()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsGettingHealthRegenBoost, "BmGame.RPawnPlayer.IsGettingHealthRegenBoost");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPoisonedAmount;
    /// <summary>
    /// Function: GetPoisonedAmount
    /// </summary>
    public unsafe virtual float GetPoisonedAmount()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPoisonedAmount, "BmGame.RPawnPlayer.GetPoisonedAmount");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetTimeTillPoisonDeath;
    /// <summary>
    /// Function: GetTimeTillPoisonDeath
    /// </summary>
    public unsafe virtual float GetTimeTillPoisonDeath()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTimeTillPoisonDeath, "BmGame.RPawnPlayer.GetTimeTillPoisonDeath");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsPoisoned;
    /// <summary>
    /// Function: IsPoisoned
    /// </summary>
    public unsafe virtual bool IsPoisoned()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPoisoned, "BmGame.RPawnPlayer.IsPoisoned");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ServerPawnToxinRelease;
    /// <summary>
    /// Function: ServerPawnToxinRelease
    /// </summary>
    public unsafe virtual void ServerPawnToxinRelease()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerPawnToxinRelease, "BmGame.RPawnPlayer.ServerPawnToxinRelease");
        byte* paramsPtr = stackalloc byte[260];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerStartDeathTimer;
    /// <summary>
    /// Function: ServerStartDeathTimer
    /// </summary>
    public unsafe virtual void ServerStartDeathTimer(float PoisonDuration, BmSDK.BmGame.RPlayerController PoisonedByPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerStartDeathTimer, "BmGame.RPawnPlayer.ServerStartDeathTimer");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PoisonDuration, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PoisonedByPlayer, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsBeingLocked;
    /// <summary>
    /// Function: IsBeingLocked
    /// </summary>
    public unsafe virtual bool IsBeingLocked()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBeingLocked, "BmGame.RPawnPlayer.IsBeingLocked");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ServerStopLockOn;
    /// <summary>
    /// Function: ServerStopLockOn
    /// </summary>
    public unsafe virtual void ServerStopLockOn(BmSDK.BmGame.RPawnPlayer LaunchingPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerStopLockOn, "BmGame.RPawnPlayer.ServerStopLockOn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaunchingPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ServerStartLockOn;
    /// <summary>
    /// Function: ServerStartLockOn
    /// </summary>
    public unsafe virtual void ServerStartLockOn(float LockTime, BmSDK.BmGame.RPawnPlayer LaunchingPlayer, float OtherTargetsRange)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerStartLockOn, "BmGame.RPawnPlayer.ServerStartLockOn");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LockTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaunchingPlayer, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherTargetsRange, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartPawnExplosionParticleFX;
    /// <summary>
    /// Function: StartPawnExplosionParticleFX
    /// </summary>
    public unsafe virtual void StartPawnExplosionParticleFX(BmSDK.Engine.ParticleSystem NewParticleSystem)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartPawnExplosionParticleFX, "BmGame.RPawnPlayer.StartPawnExplosionParticleFX");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewParticleSystem, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientStartPawnExplosionParticleFX;
    /// <summary>
    /// Function: ClientStartPawnExplosionParticleFX
    /// </summary>
    public unsafe virtual void ClientStartPawnExplosionParticleFX(BmSDK.Engine.ParticleSystem NewParticleSystem)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientStartPawnExplosionParticleFX, "BmGame.RPawnPlayer.ClientStartPawnExplosionParticleFX");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewParticleSystem, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartPawnTaggedFX;
    /// <summary>
    /// Function: StartPawnTaggedFX
    /// </summary>
    public unsafe virtual void StartPawnTaggedFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartPawnTaggedFX, "BmGame.RPawnPlayer.StartPawnTaggedFX");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartPlayerIconFX;
    /// <summary>
    /// Function: StartPlayerIconFX
    /// </summary>
    public unsafe virtual void StartPlayerIconFX(BmSDK.Engine.ParticleSystem OverrideFX, bool bInNetworkedShowOnlyOtherPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartPlayerIconFX, "BmGame.RPawnPlayer.StartPlayerIconFX");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideFX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInNetworkedShowOnlyOtherPlayer, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Internal_ClientGotoRagdoll;
    /// <summary>
    /// Function: Internal_ClientGotoRagdoll
    /// </summary>
    public unsafe virtual void Internal_ClientGotoRagdoll(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo, bool bKill)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Internal_ClientGotoRagdoll, "BmGame.RPawnPlayer.Internal_ClientGotoRagdoll");
        byte* paramsPtr = stackalloc byte[264];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKill, paramsPtr + 244);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsDamageValidToStagger;
    /// <summary>
    /// Function: IsDamageValidToStagger
    /// </summary>
    public unsafe virtual bool IsDamageValidToStagger(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo, float fTimeFromLastStaggerMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDamageValidToStagger, "BmGame.RPawnPlayer.IsDamageValidToStagger");
        byte* paramsPtr = stackalloc byte[300];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fTimeFromLastStaggerMove, paramsPtr + 244);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 248);
    }

    private static BmSDK.Function __fn_Internal_SpawnHit;
    /// <summary>
    /// Function: Internal_SpawnHit
    /// </summary>
    public unsafe virtual void Internal_SpawnHit(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo, bool IgnoreHitReaction, bool IgnoreStagger)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Internal_SpawnHit, "BmGame.RPawnPlayer.Internal_SpawnHit");
        byte* paramsPtr = stackalloc byte[268];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IgnoreHitReaction, paramsPtr + 244);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IgnoreStagger, paramsPtr + 248);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsShimmying;
    /// <summary>
    /// Function: IsShimmying
    /// </summary>
    public unsafe virtual bool IsShimmying()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsShimmying, "BmGame.RPawnPlayer.IsShimmying");
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

    private static BmSDK.Function __fn_PointInTriangle2D;
    /// <summary>
    /// Function: PointInTriangle2D
    /// </summary>
    public unsafe static bool PointInTriangle2D(System.Numerics.Vector3 Point, System.Numerics.Vector3 Vert0, System.Numerics.Vector3 Vert1, System.Numerics.Vector3 Vert2)
    {
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PointInTriangle2D, "BmGame.RPawnPlayer.PointInTriangle2D");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Point, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Vert0, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Vert1, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Vert2, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }

    private static BmSDK.Function __fn_SetDamageLevel;
    /// <summary>
    /// Function: SetDamageLevel
    /// </summary>
    public unsafe virtual void SetDamageLevel(BmSDK.FName PlayerCharacterName, int NewDamageLevel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetDamageLevel, "BmGame.RPawnPlayer.SetDamageLevel");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerCharacterName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDamageLevel, paramsPtr + 8);
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

    private static BmSDK.Function __fn_AdjustGlideKickZ;
    /// <summary>
    /// Function: AdjustGlideKickZ
    /// </summary>
    public unsafe virtual float AdjustGlideKickZ()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdjustGlideKickZ, "BmGame.RPawnPlayer.AdjustGlideKickZ");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_AdjustGargoyleDist;
    /// <summary>
    /// Function: AdjustGargoyleDist
    /// </summary>
    public unsafe virtual float AdjustGargoyleDist()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AdjustGargoyleDist, "BmGame.RPawnPlayer.AdjustGargoyleDist");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetBatClawPriority;
    /// <summary>
    /// Function: GetBatClawPriority
    /// </summary>
    public unsafe virtual float GetBatClawPriority()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBatClawPriority, "BmGame.RPawnPlayer.GetBatClawPriority");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetHeldPlayer;
    /// <summary>
    /// Function: GetHeldPlayer
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnPlayer GetHeldPlayer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetHeldPlayer, "BmGame.RPawnPlayer.GetHeldPlayer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnPlayer>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StartDefferedHold;
    /// <summary>
    /// Function: StartDefferedHold
    /// </summary>
    public unsafe virtual void StartDefferedHold(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId HoldAnimId, BmSDK.BmGame.RPawnPlayer HoldPlayer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartDefferedHold, "BmGame.RPawnPlayer.StartDefferedHold");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HoldAnimId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HoldPlayer, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopPhysicsGrab;
    /// <summary>
    /// Function: StopPhysicsGrab
    /// </summary>
    public unsafe virtual void StopPhysicsGrab()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopPhysicsGrab, "BmGame.RPawnPlayer.StopPhysicsGrab");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartPhysicsGrab;
    /// <summary>
    /// Function: StartPhysicsGrab
    /// </summary>
    public unsafe virtual void StartPhysicsGrab(BmSDK.BmGame.RPawnPlayer PlayerToGrab, BmSDK.FName BoneName, BmSDK.FName HoldingBoneName = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartPhysicsGrab, "BmGame.RPawnPlayer.StartPhysicsGrab");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerToGrab, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HoldingBoneName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResumePhysics;
    /// <summary>
    /// Function: ResumePhysics
    /// </summary>
    public unsafe virtual void ResumePhysics(out BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent> FlappyThingsArray)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResumePhysics, "BmGame.RPawnPlayer.ResumePhysics");
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
        FlappyThingsArray = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_PausePhysics;
    /// <summary>
    /// Function: PausePhysics
    /// </summary>
    public unsafe virtual void PausePhysics(out BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent> FlappyThingsArray)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PausePhysics, "BmGame.RPawnPlayer.PausePhysics");
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
        FlappyThingsArray = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_ResumeExpensivePhysicsThings;
    /// <summary>
    /// Function: ResumeExpensivePhysicsThings
    /// </summary>
    public unsafe virtual void ResumeExpensivePhysicsThings()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResumeExpensivePhysicsThings, "BmGame.RPawnPlayer.ResumeExpensivePhysicsThings");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PauseExpensivePhysicsThings;
    /// <summary>
    /// Function: PauseExpensivePhysicsThings
    /// </summary>
    public unsafe virtual void PauseExpensivePhysicsThings()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PauseExpensivePhysicsThings, "BmGame.RPawnPlayer.PauseExpensivePhysicsThings");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckExpensivePhysicsThings;
    /// <summary>
    /// Function: CheckExpensivePhysicsThings
    /// </summary>
    public unsafe virtual void CheckExpensivePhysicsThings(float LoopTime = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckExpensivePhysicsThings, "BmGame.RPawnPlayer.CheckExpensivePhysicsThings");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LoopTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetPlayerAllegiance;
    /// <summary>
    /// Function: GetPlayerAllegiance
    /// </summary>
    public unsafe override BmSDK.BmGame.GDGIBase.EPlayerAllegiance GetPlayerAllegiance(BmSDK.Engine.PlayerReplicationInfo OtherPRI)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPlayerAllegiance, "BmGame.RPawnPlayer.GetPlayerAllegiance");
        byte* paramsPtr = stackalloc byte[21];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherPRI, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.GDGIBase.EPlayerAllegiance>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CanCapeGlide;
    /// <summary>
    /// Function: CanCapeGlide
    /// </summary>
    public unsafe virtual bool CanCapeGlide(bool ActuallyTryingToTriggerGlide)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanCapeGlide, "BmGame.RPawnPlayer.CanCapeGlide");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActuallyTryingToTriggerGlide, paramsPtr + 0);
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

    private static BmSDK.Function __fn_IsSoundPerspectiveLocal;
    /// <summary>
    /// Function: IsSoundPerspectiveLocal
    /// </summary>
    public unsafe virtual bool IsSoundPerspectiveLocal()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsSoundPerspectiveLocal, "BmGame.RPawnPlayer.IsSoundPerspectiveLocal");
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

    private static BmSDK.Function __fn_RemoveSpawnProtection;
    /// <summary>
    /// Function: RemoveSpawnProtection
    /// </summary>
    public unsafe virtual void RemoveSpawnProtection()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveSpawnProtection, "BmGame.RPawnPlayer.RemoveSpawnProtection");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GiveSpawnProtection;
    /// <summary>
    /// Function: GiveSpawnProtection
    /// </summary>
    public unsafe virtual void GiveSpawnProtection()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveSpawnProtection, "BmGame.RPawnPlayer.GiveSpawnProtection");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanBeTakeDownVictim;
    /// <summary>
    /// Function: CanBeTakeDownVictim
    /// </summary>
    public unsafe override bool CanBeTakeDownVictim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBeTakeDownVictim, "BmGame.RPawnPlayer.CanBeTakeDownVictim");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_Zapped;
    /// <summary>
    /// Function: Zapped
    /// </summary>
    public unsafe override void Zapped(float ZapTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Zapped, "BmGame.RPawnPlayer.Zapped");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ZapTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Stunned;
    /// <summary>
    /// Function: Stunned
    /// </summary>
    public unsafe override void Stunned(float StunTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Stunned, "BmGame.RPawnPlayer.Stunned");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StunTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TakeGrenadeDamage;
    /// <summary>
    /// Function: TakeGrenadeDamage
    /// </summary>
    public unsafe virtual void TakeGrenadeDamage(int Damage, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, float StunTime = default, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeGrenadeDamage, "BmGame.RPawnPlayer.TakeGrenadeDamage");
        byte* paramsPtr = stackalloc byte[340];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StunTime, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 76);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGlanceScore;
    /// <summary>
    /// Function: GetGlanceScore
    /// </summary>
    public unsafe virtual int GetGlanceScore()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGlanceScore, "BmGame.RPawnPlayer.GetGlanceScore");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsBatarangable;
    /// <summary>
    /// Function: IsBatarangable
    /// </summary>
    public unsafe virtual bool IsBatarangable()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBatarangable, "BmGame.RPawnPlayer.IsBatarangable");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_StopRecentlyEvaded;
    /// <summary>
    /// Function: StopRecentlyEvaded
    /// </summary>
    public unsafe virtual void StopRecentlyEvaded()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopRecentlyEvaded, "BmGame.RPawnPlayer.StopRecentlyEvaded");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EvadeTriggered;
    /// <summary>
    /// Function: EvadeTriggered
    /// </summary>
    public unsafe virtual void EvadeTriggered()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EvadeTriggered, "BmGame.RPawnPlayer.EvadeTriggered");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetInVisionMode;
    /// <summary>
    /// Function: SetInVisionMode
    /// </summary>
    public unsafe virtual void SetInVisionMode(bool InVisionMode)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetInVisionMode, "BmGame.RPawnPlayer.SetInVisionMode");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InVisionMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_OnInvManagerReceivedDelegate;
    /// <summary>
    /// Function: OnInvManagerReceivedDelegate
    /// </summary>
    public unsafe virtual void OnInvManagerReceivedDelegate()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnInvManagerReceivedDelegate, "BmGame.RPawnPlayer.OnInvManagerReceivedDelegate");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FSLauncherLockOn
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FSLauncherLockOn
    {
        /// <summary>
        /// FloatProperty: LockDuration
        /// </summary>
        public unsafe float LockDuration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: LockEndTime
        /// </summary>
        public unsafe float LockEndTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: LockOnValue
        /// </summary>
        public unsafe float LockOnValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: LockedOnBy
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayer LockedOnBy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: OtherTargetsRange
        /// </summary>
        public unsafe float OtherTargetsRange
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FSPoisoned
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FSPoisoned
    {
        /// <summary>
        /// FloatProperty: TimeOfDeath
        /// </summary>
        public unsafe float TimeOfDeath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: PoisonDuration
        /// </summary>
        public unsafe float PoisonDuration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ObjectProperty: PoisonedBy
        /// </summary>
        public unsafe BmSDK.BmGame.RPlayerController PoisonedBy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FLastSpecialMoveData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FLastSpecialMoveData
    {
        /// <summary>
        /// StructProperty: LastSpecialMoveTransitionId
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId LastSpecialMoveTransitionId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: LastSpecialMoveConfigName
        /// </summary>
        public unsafe BmSDK.FName LastSpecialMoveConfigName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bFinishedTransition
        /// </summary>
        public unsafe bool bFinishedTransition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FGadgetFiringData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FGadgetFiringData
    {
        /// <summary>
        /// StructProperty: FireLoc
        /// </summary>
        public unsafe System.Numerics.Vector3 FireLoc
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: AimRot
        /// </summary>
        public unsafe BmSDK.Rotator AimRot
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: SpreadSeed
        /// </summary>
        public unsafe int SpreadSeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: SpreadAngle
        /// </summary>
        public unsafe float SpreadAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
    }

    /// <summary>
    /// Struct: FWireBounceUpdater
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public partial record struct FWireBounceUpdater
    {
        /// <summary>
        /// FloatProperty: CurrentCorrection
        /// </summary>
        public unsafe float CurrentCorrection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: CurrentAmplitude
        /// </summary>
        public unsafe float CurrentAmplitude
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: CurrentTimer
        /// </summary>
        public unsafe float CurrentTimer
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: CurrentPeriod
        /// </summary>
        public unsafe float CurrentPeriod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: IncrementedSpeed
        /// </summary>
        public unsafe bool IncrementedSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: MinPeriod
        /// </summary>
        public unsafe float MinPeriod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: MaxPeriod
        /// </summary>
        public unsafe float MaxPeriod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: MaxCorrection
        /// </summary>
        public unsafe float MaxCorrection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: MinCorrection
        /// </summary>
        public unsafe float MinCorrection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: MovementCorrection
        /// </summary>
        public unsafe float MovementCorrection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: MovementPeriod
        /// </summary>
        public unsafe float MovementPeriod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// FloatProperty: BlendInStrength
        /// </summary>
        public unsafe float BlendInStrength
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// FloatProperty: DecayStrength
        /// </summary>
        public unsafe float DecayStrength
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: BuildUpStrength
        /// </summary>
        public unsafe float BuildUpStrength
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// FloatProperty: MinBounceDist
        /// </summary>
        public unsafe float MinBounceDist
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// FloatProperty: MaxBounceDist
        /// </summary>
        public unsafe float MaxBounceDist
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// BoolProperty: bActive
        /// </summary>
        public unsafe bool bActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }
    }

    /// <summary>
    /// Enum: PerchDirection
    /// </summary>
    public enum PerchDirection : byte
    {
        PD_Forward = 0,
        PD_Backward = 1,
        PD_MAX = 2,
    }

    /// <summary>
    /// Enum: OverheadRopeControlPointType
    /// </summary>
    public enum OverheadRopeControlPointType : byte
    {
        ORCT_LeftHand = 0,
        ORCT_RightHand = 1,
        ORCT_LeftFoot = 2,
        ORCT_RightFoot = 3,
        ORCT_GrapplePoint = 4,
        ORCT_MAX = 5,
    }

    /// <summary>
    /// Struct: FFakeWall
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FFakeWall
    {
        /// <summary>
        /// StructProperty: FakeCollisionNormal
        /// </summary>
        public unsafe System.Numerics.Vector3 FakeCollisionNormal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: FakeCollisionNormalActive
        /// </summary>
        public unsafe bool FakeCollisionNormalActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FPoseForReplicationStruct
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FPoseForReplicationStruct
    {
        /// <summary>
        /// NameProperty: PoseForReplication
        /// </summary>
        public unsafe BmSDK.FName PoseForReplication
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: PoseForReplicationMirrored
        /// </summary>
        public unsafe bool PoseForReplicationMirrored
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: EStealthTakeDownStages
    /// </summary>
    public enum EStealthTakeDownStages : byte
    {
        ESTDS_CornerGrab = 0,
        ESTDS_FallingTakeDown = 1,
        ESTDS_GlassAttack = 2,
        ESTDS_GrabFromCrouch = 3,
        ESTDS_GrabFromCrouch2 = 4,
        ESTDS_GrabFromCrouchAware = 5,
        ESTDS_GrabFromHang = 6,
        ESTDS_GrabOnFloor = 7,
        ESTDS_LedgeAttack = 8,
        ESTDS_DoubleLedgeAttack = 9,
        ESTDS_RailingAttack = 10,
        ESTDS_SneakyCombatTakeDown = 11,
        ESTDS_ReverseChokeAttack = 12,
        ESTDS_DoubleHead = 13,
        ESTDS_FromAbove = 14,
        ESTDS_LineLauncherTakeDown = 15,
        ESTDS_CwInvertedFromCeilingGrab = 16,
        ESTDS_CwInvertedFromCeilingEnd = 17,
        ESTDS_CwInvertedFromCeilingSuccess = 18,
        ESTDS_FractureWallTakeDown = 19,
        ESTDS_CwPullFromCatwalk = 20,
        ESTDS_TunnelGrateGrab = 21,
        ESTDS_VentAttack = 22,
        ESTDS_BoostGlideTackle = 23,
        ESTDS_SuperGlideTakedown = 24,
        ESTDS_GrappleBoostTakedown = 25,
        ESTDS_LineLauncherAttack = 26,
        ESTDS_LongRangeLedgeTakedown = 27,
        ESTDS_LongRangeRailingTakedown = 28,
        ESTDS_StandingQuickTakedown = 29,
        ESTDS_HangingFearFinish = 30,
        ESTDS_GlassTakedownFinish = 31,
        ESTDS_ReverseChokeFinish = 32,
        ESTDS_TunnelGrateEnd = 33,
        ESTDS_ThugExecutingHero = 34,
        ESTDS_ThugExecutingThug = 35,
        ESTDS_ThugBlockReactingToHero = 36,
        ESTDS_WallSmash = 37,
        ESTDS_GrabThugSmash = 38,
        ESTDS_StealthTakeDownStageMAX = 39,
        ESTDS_MAX = 40,
    }

    /// <summary>
    /// Enum: EBatmanPoseType
    /// </summary>
    public enum EBatmanPoseType : byte
    {
        EBPT_Standard = 0,
        EBPT_Combat = 1,
        EBPT_SilentPredator = 2,
        EBPT_DontCare = 3,
        EBPT_MAX = 4,
    }

    /// <summary>
    /// Enum: HitDamageDirection
    /// </summary>
    public enum HitDamageDirection : byte
    {
        HDD_Forward = 0,
        HDD_Backward = 1,
        HDD_Left = 2,
        HDD_Right = 3,
        HDD_MAX = 4,
    }

    /// <summary>
    /// Struct: FCoverDescriptor
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial record struct FCoverDescriptor
    {
        /// <summary>
        /// FloatProperty: LeftCoverDistance
        /// </summary>
        public unsafe float LeftCoverDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: LeftCoverNormal
        /// </summary>
        public unsafe System.Numerics.Vector3 LeftCoverNormal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: RightCoverDistance
        /// </summary>
        public unsafe float RightCoverDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: RightCoverNormal
        /// </summary>
        public unsafe System.Numerics.Vector3 RightCoverNormal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// BoolProperty: bCoveredLeft
        /// </summary>
        public unsafe bool bCoveredLeft
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: bCoveredRight
        /// </summary>
        public unsafe bool bCoveredRight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: bInCover
        /// </summary>
        public unsafe bool bInCover
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }

        /// <summary>
        /// StructProperty: CoverRotator
        /// </summary>
        public unsafe BmSDK.Rotator CoverRotator
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// StructProperty: DesiredCoverPosition
        /// </summary>
        public unsafe System.Numerics.Vector3 DesiredCoverPosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: LROffset
        /// </summary>
        public unsafe float LROffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }
    }

    /// <summary>
    /// Struct: FNetworkedAnimPair
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial record struct FNetworkedAnimPair
    {
        /// <summary>
        /// StructProperty: AttackerTransitionTargetPosition
        /// </summary>
        public unsafe System.Numerics.Vector3 AttackerTransitionTargetPosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: AttackerTransitionTargetYaw
        /// </summary>
        public unsafe int AttackerTransitionTargetYaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ObjectProperty: Victim
        /// </summary>
        public unsafe BmSDK.Engine.Actor Victim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ObjectProperty: Victim2
        /// </summary>
        public unsafe BmSDK.Engine.Actor Victim2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ObjectProperty: OriginTemplate
        /// </summary>
        public unsafe BmSDK.BmGame.RStealthTakeDownStage OriginTemplate
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// IntProperty: ChosenAnim
        /// </summary>
        public unsafe int ChosenAnim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// IntProperty: StageAnimId
        /// </summary>
        public unsafe int StageAnimId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// ObjectProperty: ExtraActor
        /// </summary>
        public unsafe BmSDK.Engine.Actor ExtraActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }
    }

    /// <summary>
    /// Struct: FRailingInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FRailingInfo
    {
        /// <summary>
        /// StructProperty: EdgeColl
        /// </summary>
        public unsafe System.IntPtr EdgeColl
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: RailingIndex
        /// </summary>
        public unsafe int RailingIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: PointOnRailing
        /// </summary>
        public unsafe System.Numerics.Vector3 PointOnRailing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ByteProperty: RailingType
        /// </summary>
        public unsafe byte RailingType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FPlayerEdgeColl
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FPlayerEdgeColl
    {
        /// <summary>
        /// StructProperty: LevelCollection
        /// </summary>
        public unsafe System.IntPtr LevelCollection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: CollectionIndex
        /// </summary>
        public unsafe int CollectionIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ObjectProperty: Level
        /// </summary>
        public unsafe BmSDK.GameObject Level
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: EArmourType
    /// </summary>
    public enum EArmourType : byte
    {
        EA_ArmourMelee = 0,
        EA_ArmourBallistic = 1,
        EA_MAX = 2,
    }

    /// <summary>
    /// Struct: FCeilingClimbPoint
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public partial record struct FCeilingClimbPoint
    {
        /// <summary>
        /// StructProperty: FeatureLocator
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator FeatureLocator
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FEnvironmentSpecialMoveLocator
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public partial record struct FEnvironmentSpecialMoveLocator
    {
        /// <summary>
        /// ByteProperty: Type
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayer.EnvironmentSpecialMoveTypes Type
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.EnvironmentSpecialMoveTypes>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: OverrideChosenAnim
        /// </summary>
        public unsafe byte OverrideChosenAnim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1); }; }
        }

        /// <summary>
        /// ByteProperty: EdgeType
        /// </summary>
        public unsafe byte EdgeType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2); }; }
        }

        /// <summary>
        /// ByteProperty: AnimDir
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayer.EnvironmentAnimationDirection AnimDir
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.EnvironmentAnimationDirection>(Ptr + 3); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3); }; }
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
        /// StructProperty: Normal
        /// </summary>
        public unsafe System.Numerics.Vector3 Normal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: Distance
        /// </summary>
        public unsafe float Distance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: AnimTimeOverride
        /// </summary>
        public unsafe float AnimTimeOverride
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: TransitionDurationScale
        /// </summary>
        public unsafe float TransitionDurationScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// ObjectProperty: ActorInstance
        /// </summary>
        public unsafe BmSDK.Engine.Actor ActorInstance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: bCantOverrideDirection
        /// </summary>
        public unsafe bool bCantOverrideDirection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }; }
        }

        /// <summary>
        /// BoolProperty: bForceMirror
        /// </summary>
        public unsafe bool bForceMirror
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }; }
        }

        /// <summary>
        /// BoolProperty: bForceMirrorChoice
        /// </summary>
        public unsafe bool bForceMirrorChoice
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }; }
        }

        /// <summary>
        /// StructProperty: ExtraVectorInfo
        /// </summary>
        public unsafe System.Numerics.Vector3 ExtraVectorInfo_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }
        /// <summary>
        /// StructProperty: ExtraVectorInfo
        /// </summary>
        public unsafe System.Numerics.Vector3 ExtraVectorInfo_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }
        /// <summary>
        /// StructProperty: ExtraVectorInfo
        /// </summary>
        public unsafe System.Numerics.Vector3 ExtraVectorInfo_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }
        /// <summary>
        /// StructProperty: ExtraVectorInfo
        /// </summary>
        public unsafe System.Numerics.Vector3 ExtraVectorInfo_3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// FloatProperty: ExtraFloatInfo
        /// </summary>
        public unsafe float ExtraFloatInfo_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }
        /// <summary>
        /// FloatProperty: ExtraFloatInfo
        /// </summary>
        public unsafe float ExtraFloatInfo_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }; }
        }
        /// <summary>
        /// FloatProperty: ExtraFloatInfo
        /// </summary>
        public unsafe float ExtraFloatInfo_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 104); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }; }
        }
        /// <summary>
        /// FloatProperty: ExtraFloatInfo
        /// </summary>
        public unsafe float ExtraFloatInfo_3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 108); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }; }
        }
    }

    /// <summary>
    /// Enum: EPlayerLandMoves
    /// </summary>
    public enum EPlayerLandMoves : byte
    {
        PLM_StraightLand = 0,
        PLM_JumpLandToRun = 1,
        PLM_JumpLandToStand = 2,
        PLM_StraightLandToRun = 3,
        PLM_JumpLandOnSpot = 4,
        PLM_VeryFastFallLand = 5,
        PLM_PlayerLandMovesMAX = 6,
        PLM_MAX = 7,
    }

    /// <summary>
    /// Enum: EBatmanGadgetList
    /// </summary>
    public enum EBatmanGadgetList : byte
    {
        BGL_Batarang = 0,
        BGL_RCBatarang = 1,
        BGL_MultiBatarang = 2,
        BGL_SonicBatarang = 3,
        BGL_BatClaw = 4,
        BGL_ExplosiveGel = 5,
        BGL_LineLauncher = 6,
        BGL_Resonator = 7,
        BGL_MagneticBlast = 8,
        BGL_FreezeBlast = 9,
        BGL_SmokeBomb = 10,
        BGL_FreezeGunJammer = 11,
        BGL_JammerGadget = 12,
        BGL_FreezeClusterGrenade = 13,
        BGL_MAX = 14,
    }

    /// <summary>
    /// Enum: EnvironmentAnimationDirection
    /// </summary>
    public enum EnvironmentAnimationDirection : byte
    {
        EAD_DoesntMatter = 0,
        EAD_Left = 1,
        EAD_Right = 2,
        EAD_MAX = 3,
    }

    /// <summary>
    /// Enum: EnvironmentFeelerState
    /// </summary>
    public enum EnvironmentFeelerState : byte
    {
        EFS_Walking = 0,
        EFS_InCover = 1,
        EFS_Gliding = 2,
        EFS_Shimmy = 3,
        EFS_ShimmyClimbOnly = 4,
        EFS_Falling = 5,
        EFS_CombatFeelers = 6,
        EFS_CinematicMode = 7,
        EFS_RailingClimbDown = 8,
        EFS_ThugMove = 9,
        EFS_ThugCover = 10,
        EFS_NoFeelers = 11,
        EFS_MAX = 12,
    }

    /// <summary>
    /// Struct: FMovementControllerHistory
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FMovementControllerHistory
    {
        /// <summary>
        /// StructProperty: Direction
        /// </summary>
        public unsafe System.Numerics.Vector3 Direction
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: InputSpeed
        /// </summary>
        public unsafe float InputSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: Time
        /// </summary>
        public unsafe float Time
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FEnvironmentSpecialMoveTypesContainer
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FEnvironmentSpecialMoveTypesContainer
    {
        /// <summary>
        /// BoolProperty: ReservedNone
        /// </summary>
        public unsafe bool ReservedNone
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: LowBarrier
        /// </summary>
        public unsafe bool LowBarrier
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: MediumBarrier
        /// </summary>
        public unsafe bool MediumBarrier
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: HighBarrier
        /// </summary>
        public unsafe bool HighBarrier
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: LowWall
        /// </summary>
        public unsafe bool LowWall
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: MediumWall
        /// </summary>
        public unsafe bool MediumWall
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: HighWall
        /// </summary>
        public unsafe bool HighWall
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 64) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: UnscalableWall
        /// </summary>
        public unsafe bool UnscalableWall
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 128) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Floor
        /// </summary>
        public unsafe bool Floor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 256) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: JumpGap512
        /// </summary>
        public unsafe bool JumpGap512
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 512) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Edge
        /// </summary>
        public unsafe bool Edge
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1024) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: JumpGap256
        /// </summary>
        public unsafe bool JumpGap256
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2048) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: JumpGap384
        /// </summary>
        public unsafe bool JumpGap384
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 4096) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: GapNoHeadRoom
        /// </summary>
        public unsafe bool GapNoHeadRoom
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 8192) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: ShimmyLedge
        /// </summary>
        public unsafe bool ShimmyLedge
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 16384) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: DangleLedge
        /// </summary>
        public unsafe bool DangleLedge
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 32768) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: DangleLedgeWithRailing
        /// </summary>
        public unsafe bool DangleLedgeWithRailing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 65536) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: CoverCorner
        /// </summary>
        public unsafe bool CoverCorner
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 131072) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: ShimmyLedgeWithRailing
        /// </summary>
        public unsafe bool ShimmyLedgeWithRailing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 262144) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: LowWallWithRailing
        /// </summary>
        public unsafe bool LowWallWithRailing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 524288) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: MediumWallWithRailing
        /// </summary>
        public unsafe bool MediumWallWithRailing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1048576) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: HighWallWithRailing
        /// </summary>
        public unsafe bool HighWallWithRailing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2097152) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: LowBarrierWithDrop
        /// </summary>
        public unsafe bool LowBarrierWithDrop
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 4194304) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: MediumBarrierWithDrop
        /// </summary>
        public unsafe bool MediumBarrierWithDrop
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 8388608) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: HighBarrierWithDrop
        /// </summary>
        public unsafe bool HighBarrierWithDrop
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 16777216) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: LowRailingWithDrop
        /// </summary>
        public unsafe bool LowRailingWithDrop
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 33554432) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: ShimmyCrevice
        /// </summary>
        public unsafe bool ShimmyCrevice
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 67108864) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: DangleCrevice
        /// </summary>
        public unsafe bool DangleCrevice
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 134217728) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: CoverCornerLeft
        /// </summary>
        public unsafe bool CoverCornerLeft
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 268435456) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: JumpGap512NoShimmy
        /// </summary>
        public unsafe bool JumpGap512NoShimmy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 536870912) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: EdgeNoShimmy
        /// </summary>
        public unsafe bool EdgeNoShimmy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1073741824) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: JumpGap256NoShimmy
        /// </summary>
        public unsafe bool JumpGap256NoShimmy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & -2147483648) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: JumpGap384NoShimmy
        /// </summary>
        public unsafe bool JumpGap384NoShimmy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: JumpGap256ToRailing
        /// </summary>
        public unsafe bool JumpGap256ToRailing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: JumpGap256ToRailingNoShimmy
        /// </summary>
        public unsafe bool JumpGap256ToRailingNoShimmy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: ShimmyHangRailing
        /// </summary>
        public unsafe bool ShimmyHangRailing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: ShimmyDangleRailing
        /// </summary>
        public unsafe bool ShimmyDangleRailing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: MediumWallWithRailingNoShimmy
        /// </summary>
        public unsafe bool MediumWallWithRailingNoShimmy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: LowBarrierNoVault
        /// </summary>
        public unsafe bool LowBarrierNoVault
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 64) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: MediumBarrierNoVault
        /// </summary>
        public unsafe bool MediumBarrierNoVault
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 128) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: HighBarrierNoVault
        /// </summary>
        public unsafe bool HighBarrierNoVault
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 256) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: ScrambleToShimmy
        /// </summary>
        public unsafe bool ScrambleToShimmy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 512) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: CoverNodeFull
        /// </summary>
        public unsafe bool CoverNodeFull
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 1024) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: CoverNodeHalf
        /// </summary>
        public unsafe bool CoverNodeHalf
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 2048) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: CoverJokerVault
        /// </summary>
        public unsafe bool CoverJokerVault
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 4096) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: CoverJokerMantle
        /// </summary>
        public unsafe bool CoverJokerMantle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 8192) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FExtraDeathInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FExtraDeathInfo
    {
        /// <summary>
        /// BoolProperty: bGoodAsDead
        /// </summary>
        public unsafe bool bGoodAsDead
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: KillerAmmo
        /// </summary>
        public unsafe int KillerAmmo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Enum: EHangLedgeType
    /// </summary>
    public enum EHangLedgeType : byte
    {
        HLT_Braced = 0,
        HLT_Dangle = 1,
        HLT_DangleNoRoomToSwing = 2,
        HLT_MAX = 3,
    }

    /// <summary>
    /// Enum: EAimAssitanceTargetMove
    /// </summary>
    public enum EAimAssitanceTargetMove : byte
    {
        AATM_NormalMove = 0,
        AATM_Run = 1,
        AATM_Glide = 2,
        AATM_Evade = 3,
        AATM_DiveBomb = 4,
        AATM_Grapple = 5,
        AATM_SwingBetweenVantage = 6,
        AATM_CoverSlip = 7,
        AATM_Vault = 8,
        AATM_SwatTurn = 9,
        AATM_MAX = 10,
    }

    /// <summary>
    /// Enum: EnvironmentSpecialMoveTypes
    /// </summary>
    public enum EnvironmentSpecialMoveTypes : byte
    {
        ESMT_None = 0,
        ESMT_LowBarrier = 1,
        ESMT_MediumBarrier = 2,
        ESMT_HighBarrier = 3,
        ESMT_LowWall = 4,
        ESMT_MediumWall = 5,
        ESMT_HighWall = 6,
        ESMT_UnscalableWall = 7,
        ESMT_Floor = 8,
        ESMT_JumpGap512 = 9,
        ESMT_Edge = 10,
        ESMT_JumpGap256 = 11,
        ESMT_JumpGap384 = 12,
        ESMT_GapNoHeadRoom = 13,
        ESMT_ShimmyLedge = 14,
        ESMT_DangleLedge = 15,
        ESMT_DangleLedgeWithRailing = 16,
        ESMT_CoverCorner = 17,
        ESMT_ShimmyLedgeWithRailing = 18,
        ESMT_LowWallWithRailing = 19,
        ESMT_MediumWallWithRailing = 20,
        ESMT_HighWallWithRailing = 21,
        ESMT_LowBarrierWithDrop = 22,
        ESMT_MediumBarrierWithDrop = 23,
        ESMT_HighBarrierWithDrop = 24,
        ESMT_LowRailingWithDrop = 25,
        ESMT_ShimmyCrevice = 26,
        ESMT_DangleCrevice = 27,
        ESMT_CoverCornerLeft = 28,
        ESMT_JumpGap512NoShimmy = 29,
        ESMT_EdgeNoShimmy = 30,
        ESMT_JumpGap256NoShimmy = 31,
        ESMT_JumpGap384NoShimmy = 32,
        ESMT_JumpGap256ToRailing = 33,
        ESMT_JumpGap256ToRailingNoShimmy = 34,
        ESMT_ShimmyHangRailing = 35,
        ESMT_ShimmyDangleRailing = 36,
        ESMT_MediumWallWithRailingNoShimmy = 37,
        ESMT_LowBarrierNoVault = 38,
        ESMT_MediumBarrierNoVault = 39,
        ESMT_HighBarrierNoVault = 40,
        ESMT_ScrambleToShimmy = 41,
        ESMT_CoverThugFull = 42,
        ESMT_CoverThugHalf = 43,
        ESMT_CoverJokerVault = 44,
        ESMT_CoverJokerMantle = 45,
        ESMT_RailingEnd128 = 46,
        ESMT_Actor = 47,
        ESMT_MAX = 48,
    }

    /// <summary>
    /// StructProperty: VfTable_IRSpotableInterface
    /// </summary>
    public unsafe System.IntPtr VfTable_IRSpotableInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2576); }
    }

    /// <summary>
    /// StructProperty: VfTable_IGDXRayInterface
    /// </summary>
    public unsafe System.IntPtr VfTable_IGDXRayInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2580); }
    }

    /// <summary>
    /// BoolProperty: bIsGrabbed
    /// </summary>
    public unsafe bool bIsGrabbed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: bIsDefferedGrabbed
    /// </summary>
    public unsafe bool bIsDefferedGrabbed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: bUseAltImpactBulletEffects
    /// </summary>
    public unsafe bool bUseAltImpactBulletEffects
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreNavMeshForAvoidance
    /// </summary>
    public unsafe bool bIgnoreNavMeshForAvoidance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: LastVisibilityCheckResult
    /// </summary>
    public unsafe bool LastVisibilityCheckResult
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: bWalkingOnWire
    /// </summary>
    public unsafe bool bWalkingOnWire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: bCanUseRailings
    /// </summary>
    public unsafe bool bCanUseRailings
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: bCanUseSwingKick
    /// </summary>
    public unsafe bool bCanUseSwingKick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: bCanUseVantageGrappling
    /// </summary>
    public unsafe bool bCanUseVantageGrappling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: bCanDoAbove384Takedowns
    /// </summary>
    public unsafe bool bCanDoAbove384Takedowns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: bCanDoDoubleStealthAttacks
    /// </summary>
    public unsafe bool bCanDoDoubleStealthAttacks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: bCanHangFromVantagePoint
    /// </summary>
    public unsafe bool bCanHangFromVantagePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: bCanInterrogate
    /// </summary>
    public unsafe bool bCanInterrogate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: bAllowBackScreen
    /// </summary>
    public unsafe bool bAllowBackScreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: bCanRemoveGrates
    /// </summary>
    public unsafe bool bCanRemoveGrates
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: bUseStrafeMovement
    /// </summary>
    public unsafe bool bUseStrafeMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: bDisableBatarangHitReaction
    /// </summary>
    public unsafe bool bDisableBatarangHitReaction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: bGroundTakeDownDisabled
    /// </summary>
    public unsafe bool bGroundTakeDownDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: bCanHangOrShimmy
    /// </summary>
    public unsafe bool bCanHangOrShimmy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: bIsSpawnProtected
    /// </summary>
    public unsafe bool bIsSpawnProtected
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: XRaySet
    /// </summary>
    public unsafe bool XRaySet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: DisableTaunts
    /// </summary>
    public unsafe bool DisableTaunts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: CanUseSuperComboGadgets
    /// </summary>
    public unsafe bool CanUseSuperComboGadgets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: bReplenishHealth
    /// </summary>
    public unsafe bool bReplenishHealth
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: DeferedVelocitySet
    /// </summary>
    public unsafe bool DeferedVelocitySet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: IsGrappling
    /// </summary>
    public unsafe bool IsGrappling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: bGliding
    /// </summary>
    public unsafe bool bGliding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: IsLineLaunching
    /// </summary>
    public unsafe bool IsLineLaunching
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: CanPerchOnVantagePoints
    /// </summary>
    public unsafe bool CanPerchOnVantagePoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: IsSlidingUnderVolume
    /// </summary>
    public unsafe bool IsSlidingUnderVolume
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: bCanClimb
    /// </summary>
    public unsafe bool bCanClimb
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: bCanCapeGlide
    /// </summary>
    public unsafe bool bCanCapeGlide
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2584); }
    }

    /// <summary>
    /// BoolProperty: bCanGrappleBoost
    /// </summary>
    public unsafe bool bCanGrappleBoost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: bCapeGlideDisabledByIce
    /// </summary>
    public unsafe bool bCapeGlideDisabledByIce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: bCanDiveBoost
    /// </summary>
    public unsafe bool bCanDiveBoost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: bCantDropOffLedges
    /// </summary>
    public unsafe bool bCantDropOffLedges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: bDisableAllTakedowns
    /// </summary>
    public unsafe bool bDisableAllTakedowns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: bDisableDoubleTakedownOnInformants
    /// </summary>
    public unsafe bool bDisableDoubleTakedownOnInformants
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: bSimulateLastThugIsInformant
    /// </summary>
    public unsafe bool bSimulateLastThugIsInformant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: bCanPounceOnThugs
    /// </summary>
    public unsafe bool bCanPounceOnThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: bCanPickPocket
    /// </summary>
    public unsafe bool bCanPickPocket
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: bExitStealthOnGlide
    /// </summary>
    public unsafe bool bExitStealthOnGlide
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: bThugsHaveCommentedOnGrapple
    /// </summary>
    public unsafe bool bThugsHaveCommentedOnGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: StandingOffEdge
    /// </summary>
    public unsafe bool StandingOffEdge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: GoingToHangFromVantagePoint
    /// </summary>
    public unsafe bool GoingToHangFromVantagePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: ClimbingBackToVantagePoint
    /// </summary>
    public unsafe bool ClimbingBackToVantagePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: CheckingToDiveThroughWindows
    /// </summary>
    public unsafe bool CheckingToDiveThroughWindows
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: CheckingSwingFloor
    /// </summary>
    public unsafe bool CheckingSwingFloor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysTrackForDamage
    /// </summary>
    public unsafe bool bAlwaysTrackForDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: GrapplingToVantagePoint
    /// </summary>
    public unsafe bool GrapplingToVantagePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: bAllowZoom
    /// </summary>
    public unsafe bool bAllowZoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: bCanUseSurv
    /// </summary>
    public unsafe bool bCanUseSurv
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: bEnableGrateExcluders
    /// </summary>
    public unsafe bool bEnableGrateExcluders
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: bGB3HostagesKilled
    /// </summary>
    public unsafe bool bGB3HostagesKilled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: bDoingAutonmousMovement
    /// </summary>
    public unsafe bool bDoingAutonmousMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: ShouldCrouchForReplication
    /// </summary>
    public unsafe bool ShouldCrouchForReplication
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: bIsBeingTakendown
    /// </summary>
    public unsafe bool bIsBeingTakendown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: bHasJustMovedOntoGargoyle
    /// </summary>
    public unsafe bool bHasJustMovedOntoGargoyle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: bCanAvoidMines
    /// </summary>
    public unsafe bool bCanAvoidMines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: DoingUnderBarrierCheck
    /// </summary>
    public unsafe bool DoingUnderBarrierCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: bThoughtsShowAnimNames
    /// </summary>
    public unsafe bool bThoughtsShowAnimNames
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: bThoughtsShowBlendedAnimDetails
    /// </summary>
    public unsafe bool bThoughtsShowBlendedAnimDetails
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: bCheckNonBlockingCombatPawns
    /// </summary>
    public unsafe bool bCheckNonBlockingCombatPawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: bPawnCanGrateCrawl
    /// </summary>
    public unsafe bool bPawnCanGrateCrawl
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2588); }
    }

    /// <summary>
    /// BoolProperty: bCanClimbToCeilingLedge
    /// </summary>
    public unsafe bool bCanClimbToCeilingLedge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bCanClimbToCeilingFar
    /// </summary>
    public unsafe bool bCanClimbToCeilingFar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bCanClimbToCatwalkFar
    /// </summary>
    public unsafe bool bCanClimbToCatwalkFar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bCanPounceToCeiling
    /// </summary>
    public unsafe bool bCanPounceToCeiling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bJumpedThisFrame
    /// </summary>
    public unsafe bool bJumpedThisFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bPlayerIconPSActive
    /// </summary>
    public unsafe bool bPlayerIconPSActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bDebugObstacleAvoidance
    /// </summary>
    public unsafe bool bDebugObstacleAvoidance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bDoAvoidanceAnims
    /// </summary>
    public unsafe bool bDoAvoidanceAnims
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bDebugNewCeilingMoves
    /// </summary>
    public unsafe bool bDebugNewCeilingMoves
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bDebugGrateMoves
    /// </summary>
    public unsafe bool bDebugGrateMoves
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bJumpFromWhipSwing
    /// </summary>
    public unsafe bool bJumpFromWhipSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bAddedDefaultInventoryAfterInit
    /// </summary>
    public unsafe bool bAddedDefaultInventoryAfterInit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bDebugForceCriticalLand
    /// </summary>
    public unsafe bool bDebugForceCriticalLand
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bDebugShowLandRollCheck
    /// </summary>
    public unsafe bool bDebugShowLandRollCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bSilentRunning
    /// </summary>
    public unsafe bool bSilentRunning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bGrappleWake
    /// </summary>
    public unsafe bool bGrappleWake
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bGrappleWakeEmitter
    /// </summary>
    public unsafe bool bGrappleWakeEmitter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: DelayUnderWaterCheck
    /// </summary>
    public unsafe bool DelayUnderWaterCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bDebugInterrogationDetection
    /// </summary>
    public unsafe bool bDebugInterrogationDetection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bInterrogationIgnoreIsSafeCheck
    /// </summary>
    public unsafe bool bInterrogationIgnoreIsSafeCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bDrawRelativeAnimRefPoint
    /// </summary>
    public unsafe bool bDrawRelativeAnimRefPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bSimulateInterrogationMovesNotLoaded
    /// </summary>
    public unsafe bool bSimulateInterrogationMovesNotLoaded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bHealthModifierActive
    /// </summary>
    public unsafe bool bHealthModifierActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: WasDamageProxyActive
    /// </summary>
    public unsafe bool WasDamageProxyActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bOnlyUseStealthOverrides
    /// </summary>
    public unsafe bool bOnlyUseStealthOverrides
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bGoodAsDead
    /// </summary>
    public unsafe bool bGoodAsDead
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bFrozen
    /// </summary>
    public unsafe bool bFrozen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bExpensivePhysicsThingsOn
    /// </summary>
    public unsafe bool bExpensivePhysicsThingsOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bDisableExpensivePhysicsThings
    /// </summary>
    public unsafe bool bDisableExpensivePhysicsThings
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bWasPoisoned
    /// </summary>
    public unsafe bool bWasPoisoned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bVisionModeEnabled
    /// </summary>
    public unsafe bool bVisionModeEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bFinishedLoadingAnims
    /// </summary>
    public unsafe bool bFinishedLoadingAnims
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2592); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2592); }
    }

    /// <summary>
    /// BoolProperty: bTaggedToEnemies
    /// </summary>
    public unsafe bool bTaggedToEnemies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2596) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2596); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2596); }
    }

    /// <summary>
    /// BoolProperty: bWasTaggedToEnemies
    /// </summary>
    public unsafe bool bWasTaggedToEnemies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2596) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2596); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2596); }
    }

    /// <summary>
    /// BoolProperty: bWasLocallyControlledOnDeath
    /// </summary>
    public unsafe bool bWasLocallyControlledOnDeath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2596) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2596); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2596); }
    }

    /// <summary>
    /// BoolProperty: ThermalSet
    /// </summary>
    public unsafe bool ThermalSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2596) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2596); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2596); }
    }

    /// <summary>
    /// BoolProperty: bDisallowXraySkinDistanceFading
    /// </summary>
    public unsafe bool bDisallowXraySkinDistanceFading
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2596) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2596); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2596); }
    }

    /// <summary>
    /// BoolProperty: bFadeOutXrayForDelete
    /// </summary>
    public unsafe bool bFadeOutXrayForDelete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2596) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2596); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2596); }
    }

    /// <summary>
    /// BoolProperty: bXRayOpacitySkillBased
    /// </summary>
    public unsafe bool bXRayOpacitySkillBased
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2596) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2596); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2596); }
    }

    /// <summary>
    /// StructProperty: LastEquipOverlayId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId LastEquipOverlayId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(Ptr + 2600);

    /// <summary>
    /// FloatProperty: LastVisibilityCheckTime
    /// </summary>
    public unsafe float LastVisibilityCheckTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }
    }

    /// <summary>
    /// FloatProperty: BatarangHitTime
    /// </summary>
    public unsafe float BatarangHitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2612); }
    }

    /// <summary>
    /// FloatProperty: BatarangHitTimeout
    /// </summary>
    public unsafe float BatarangHitTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2616); }
    }

    /// <summary>
    /// FloatProperty: BatarangAwareHitTimeout
    /// </summary>
    public unsafe float BatarangAwareHitTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2620); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideGravity
    /// </summary>
    public unsafe float CapeGlideGravity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }

    /// <summary>
    /// FloatProperty: FallingTime
    /// </summary>
    public unsafe float FallingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2628); }
    }

    /// <summary>
    /// StructProperty: FallingPose
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId FallingPose
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 2632);

    /// <summary>
    /// ObjectProperty: XRayMaterialMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant XRayMaterialMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 2636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2636); }
    }

    /// <summary>
    /// ObjectProperty: CurrentXRayParams
    /// </summary>
    public unsafe BmSDK.BmGame.GDXRayParameters CurrentXRayParams
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDXRayParameters>(Ptr + 2640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2640); }
    }

    /// <summary>
    /// ObjectProperty: XrayMaskMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XrayMaskMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2644); }
    }

    /// <summary>
    /// ObjectProperty: XrayMaskMaterialCape
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XrayMaskMaterialCape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2648); }
    }

    /// <summary>
    /// ComponentProperty: XrayMaskBodyMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent XrayMaskBodyMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 2652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2652); }
    }

    /// <summary>
    /// ComponentProperty: XrayMaskHeadMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent XrayMaskHeadMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 2656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2656); }
    }

    /// <summary>
    /// ComponentProperty: XrayMaskCapeMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent XrayMaskCapeMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 2660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2660); }
    }

    /// <summary>
    /// ArrayProperty: SnowMaterials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> SnowMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 2664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2664); }
    }

    /// <summary>
    /// NameProperty: SnowParameterName
    /// </summary>
    public unsafe BmSDK.FName SnowParameterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2676); }
    }

    /// <summary>
    /// StructProperty: GrappleLoopSoundHandle
    /// </summary>
    public unsafe ref BmSDK.Engine.AkWwise.FAkSoundHandle GrappleLoopSoundHandle
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 2684);

    /// <summary>
    /// FloatProperty: ForwardEnvironmentCheckDistance
    /// </summary>
    public unsafe float ForwardEnvironmentCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2696); }
    }

    /// <summary>
    /// FloatProperty: LeftRightEnvironmentCheckDistance
    /// </summary>
    public unsafe float LeftRightEnvironmentCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2700); }
    }

    /// <summary>
    /// IntProperty: NumQuickStrikeToRagdoll
    /// </summary>
    public unsafe int NumQuickStrikeToRagdoll
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2704); }
    }

    /// <summary>
    /// FloatProperty: DashTimeMod
    /// </summary>
    public unsafe float DashTimeMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2708); }
    }

    /// <summary>
    /// FloatProperty: HealthRegenModifier
    /// </summary>
    public unsafe float HealthRegenModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2712); }
    }

    /// <summary>
    /// IntProperty: KillerAmmo
    /// </summary>
    public unsafe int KillerAmmo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2716); }
    }

    /// <summary>
    /// FloatProperty: PlayerWalkSpeed
    /// </summary>
    public unsafe float PlayerWalkSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2720); }
    }

    /// <summary>
    /// FloatProperty: PlayerRunSpeed
    /// </summary>
    public unsafe float PlayerRunSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2724); }
    }

    /// <summary>
    /// FloatProperty: PlayerStealthSpeed
    /// </summary>
    public unsafe float PlayerStealthSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2728); }
    }

    /// <summary>
    /// FloatProperty: PlayerGlideSpeed
    /// </summary>
    public unsafe float PlayerGlideSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2732); }
    }

    /// <summary>
    /// FloatProperty: PlayerChargeStrikeSpeedModifier
    /// </summary>
    public unsafe float PlayerChargeStrikeSpeedModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2736); }
    }

    /// <summary>
    /// ObjectProperty: GrappleGun
    /// </summary>
    public unsafe BmSDK.BmGame.RGrappleGun GrappleGun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrappleGun>(Ptr + 2740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2740); }
    }

    /// <summary>
    /// ObjectProperty: HarpoonGun
    /// </summary>
    public unsafe BmSDK.BmGame.RHarpoonGun HarpoonGun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHarpoonGun>(Ptr + 2744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2744); }
    }

    /// <summary>
    /// ObjectProperty: ResonatorTuner
    /// </summary>
    public unsafe BmSDK.BmGame.RResonatorTuner ResonatorTuner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RResonatorTuner>(Ptr + 2748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2748); }
    }

    /// <summary>
    /// ObjectProperty: LineLauncher
    /// </summary>
    public unsafe BmSDK.BmGame.RLineLauncher LineLauncher
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLineLauncher>(Ptr + 2752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2752); }
    }

    /// <summary>
    /// ObjectProperty: Batarang
    /// </summary>
    public unsafe BmSDK.BmGame.RBatarang Batarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatarang>(Ptr + 2756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2756); }
    }

    /// <summary>
    /// ObjectProperty: GooSpray
    /// </summary>
    public unsafe BmSDK.BmGame.RGooSpray GooSpray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGooSpray>(Ptr + 2760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2760); }
    }

    /// <summary>
    /// ObjectProperty: MagneticBlast
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticBlast MagneticBlast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticBlast>(Ptr + 2764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2764); }
    }

    /// <summary>
    /// ObjectProperty: FreezeJammer
    /// </summary>
    public unsafe BmSDK.BmGame.RFreezeGunJammer FreezeJammer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RFreezeGunJammer>(Ptr + 2768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2768); }
    }

    /// <summary>
    /// ObjectProperty: JammerGadget
    /// </summary>
    public unsafe BmSDK.BmGame.RJammerGadget JammerGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJammerGadget>(Ptr + 2772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2772); }
    }

    /// <summary>
    /// ObjectProperty: Caltrops
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectileGadgetBase Caltrops
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectileGadgetBase>(Ptr + 2776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2776); }
    }

    /// <summary>
    /// ObjectProperty: Whip
    /// </summary>
    public unsafe BmSDK.BmGame.RWhipBase Whip
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWhipBase>(Ptr + 2780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2780); }
    }

    /// <summary>
    /// ObjectProperty: Staff
    /// </summary>
    public unsafe BmSDK.BmGame.RStaffBase Staff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStaffBase>(Ptr + 2784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2784); }
    }

    /// <summary>
    /// ObjectProperty: Sticks
    /// </summary>
    public unsafe BmSDK.BmGame.RSticksGadgetBase Sticks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSticksGadgetBase>(Ptr + 2788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2788); }
    }

    /// <summary>
    /// ObjectProperty: BlowDart
    /// </summary>
    public unsafe BmSDK.BmGame.RBlowDartBase BlowDart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBlowDartBase>(Ptr + 2792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2792); }
    }

    /// <summary>
    /// ObjectProperty: RCBatarang
    /// </summary>
    public unsafe BmSDK.BmGame.RBatarang RCBatarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatarang>(Ptr + 2796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2796); }
    }

    /// <summary>
    /// ObjectProperty: SonicBatarang
    /// </summary>
    public unsafe BmSDK.BmGame.RBatarang SonicBatarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatarang>(Ptr + 2800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2800); }
    }

    /// <summary>
    /// ObjectProperty: MultiBatarang
    /// </summary>
    public unsafe BmSDK.BmGame.RBatarang MultiBatarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatarang>(Ptr + 2804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2804); }
    }

    /// <summary>
    /// ObjectProperty: SmokeBomb
    /// </summary>
    public unsafe BmSDK.BmGame.RSmokeBomb SmokeBomb
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSmokeBomb>(Ptr + 2808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2808); }
    }

    /// <summary>
    /// ObjectProperty: TeamInfoGadget
    /// </summary>
    public unsafe BmSDK.BmGame.GDTeamObjectiveInfoGadget TeamInfoGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDTeamObjectiveInfoGadget>(Ptr + 2812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2812); }
    }

    /// <summary>
    /// ObjectProperty: ThugGrenadeGadget
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectileGadgetBase ThugGrenadeGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectileGadgetBase>(Ptr + 2816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2816); }
    }

    /// <summary>
    /// ObjectProperty: ScramblerGadget
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget ScramblerGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 2820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2820); }
    }

    /// <summary>
    /// ArrayProperty: IceRafts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RFloatingRaft> IceRafts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RFloatingRaft>>(Ptr + 2824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2824); }
    }

    /// <summary>
    /// FloatProperty: MaxIceRafts
    /// </summary>
    public unsafe float MaxIceRafts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2836); }
    }

    /// <summary>
    /// FloatProperty: GrappleSpeed
    /// </summary>
    public unsafe float GrappleSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2840); }
    }

    /// <summary>
    /// FloatProperty: MaxGrappleSpeed
    /// </summary>
    public unsafe float MaxGrappleSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2844); }
    }

    /// <summary>
    /// FloatProperty: MinGrappleSpeed
    /// </summary>
    public unsafe float MinGrappleSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2848); }
    }

    /// <summary>
    /// FloatProperty: MinGrappleSpeedDist
    /// </summary>
    public unsafe float MinGrappleSpeedDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2852); }
    }

    /// <summary>
    /// FloatProperty: MaxGrappleSpeedDist
    /// </summary>
    public unsafe float MaxGrappleSpeedDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2856); }
    }

    /// <summary>
    /// FloatProperty: GrappleDampingCoeff
    /// </summary>
    public unsafe float GrappleDampingCoeff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2860); }
    }

    /// <summary>
    /// FloatProperty: GrappleBoostFactor
    /// </summary>
    public unsafe float GrappleBoostFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2864); }
    }

    /// <summary>
    /// ArrayProperty: HealthUpgrades
    /// </summary>
    public unsafe BmSDK.TArray<int> HealthUpgrades
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2868); }
    }

    /// <summary>
    /// ArrayProperty: MeleeArmourUpgrades
    /// </summary>
    public unsafe BmSDK.TArray<int> MeleeArmourUpgrades
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2880); }
    }

    /// <summary>
    /// ArrayProperty: BallisticArmourUpgrades
    /// </summary>
    public unsafe BmSDK.TArray<int> BallisticArmourUpgrades
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2892); }
    }

    /// <summary>
    /// ArrayProperty: CurrentArmourLevels
    /// </summary>
    public unsafe BmSDK.TArray<int> CurrentArmourLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2904); }
    }

    /// <summary>
    /// ArrayProperty: CurrentArmourMaxima
    /// </summary>
    public unsafe BmSDK.TArray<int> CurrentArmourMaxima
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2916); }
    }

    /// <summary>
    /// FloatProperty: ReplenishRate
    /// </summary>
    public unsafe float ReplenishRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2928); }
    }

    /// <summary>
    /// FloatProperty: TimeBeforeReplenish
    /// </summary>
    public unsafe float TimeBeforeReplenish
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2932); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceDamage
    /// </summary>
    public unsafe float TimeSinceDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2936); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceReplenish
    /// </summary>
    public unsafe float TimeSinceReplenish
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2940); }
    }

    /// <summary>
    /// StructProperty: FrontBarrier
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator FrontBarrier
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(Ptr + 2944);

    /// <summary>
    /// StructProperty: UnderBarrier
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator UnderBarrier
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(Ptr + 3056);

    /// <summary>
    /// StructProperty: UpperBarrier
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator UpperBarrier
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(Ptr + 3168);

    /// <summary>
    /// StructProperty: LeftFeature
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator LeftFeature
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(Ptr + 3280);

    /// <summary>
    /// StructProperty: RightFeature
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator RightFeature
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(Ptr + 3392);

    /// <summary>
    /// StructProperty: UnderEdgeColl
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FPlayerEdgeColl UnderEdgeColl
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FPlayerEdgeColl>(Ptr + 3504);

    /// <summary>
    /// StructProperty: ShimmyEdgeColl
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FPlayerEdgeColl ShimmyEdgeColl
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FPlayerEdgeColl>(Ptr + 3516);

    /// <summary>
    /// StructProperty: CurrentRailing
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FRailingInfo CurrentRailing
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FRailingInfo>(Ptr + 3528);

    /// <summary>
    /// StructProperty: SecondRailing
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FRailingInfo SecondRailing
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FRailingInfo>(Ptr + 3552);

    /// <summary>
    /// ByteProperty: FeelerState
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.EnvironmentFeelerState FeelerState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.EnvironmentFeelerState>(Ptr + 3576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3576); }
    }

    /// <summary>
    /// ByteProperty: MovementSpeed
    /// </summary>
    public unsafe BmSDK.BmGame.RPoseConfig.EMovementSpeed MovementSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig.EMovementSpeed>(Ptr + 3577); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3577); }
    }

    /// <summary>
    /// ByteProperty: CurrentPoseType
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.EBatmanPoseType CurrentPoseType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.EBatmanPoseType>(Ptr + 3578); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3578); }
    }

    /// <summary>
    /// ByteProperty: ClientPhysics
    /// </summary>
    public unsafe BmSDK.Engine.Actor.EPhysics ClientPhysics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.EPhysics>(Ptr + 3579); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3579); }
    }

    /// <summary>
    /// InlineArray{ByteProperty}: UpAllowSubClasses
    /// </summary>
    public InlineArray<byte> UpAllowSubClasses => new(8, Ptr + 3580, 1, this);

    /// <summary>
    /// ByteProperty: UpAllowSubClasses
    /// </summary>
    public unsafe byte UpAllowSubClasses_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3580); }
    }
    /// <summary>
    /// ByteProperty: UpAllowSubClasses
    /// </summary>
    public unsafe byte UpAllowSubClasses_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3581); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3581); }
    }
    /// <summary>
    /// ByteProperty: UpAllowSubClasses
    /// </summary>
    public unsafe byte UpAllowSubClasses_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3582); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3582); }
    }
    /// <summary>
    /// ByteProperty: UpAllowSubClasses
    /// </summary>
    public unsafe byte UpAllowSubClasses_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3583); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3583); }
    }
    /// <summary>
    /// ByteProperty: UpAllowSubClasses
    /// </summary>
    public unsafe byte UpAllowSubClasses_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3584); }
    }
    /// <summary>
    /// ByteProperty: UpAllowSubClasses
    /// </summary>
    public unsafe byte UpAllowSubClasses_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3585); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3585); }
    }
    /// <summary>
    /// ByteProperty: UpAllowSubClasses
    /// </summary>
    public unsafe byte UpAllowSubClasses_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3586); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3586); }
    }
    /// <summary>
    /// ByteProperty: UpAllowSubClasses
    /// </summary>
    public unsafe byte UpAllowSubClasses_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3587); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3587); }
    }

    /// <summary>
    /// InlineArray{ByteProperty}: DownAllowSubClasses
    /// </summary>
    public InlineArray<byte> DownAllowSubClasses => new(5, Ptr + 3588, 1, this);

    /// <summary>
    /// ByteProperty: DownAllowSubClasses
    /// </summary>
    public unsafe byte DownAllowSubClasses_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3588); }
    }
    /// <summary>
    /// ByteProperty: DownAllowSubClasses
    /// </summary>
    public unsafe byte DownAllowSubClasses_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3589); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3589); }
    }
    /// <summary>
    /// ByteProperty: DownAllowSubClasses
    /// </summary>
    public unsafe byte DownAllowSubClasses_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3590); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3590); }
    }
    /// <summary>
    /// ByteProperty: DownAllowSubClasses
    /// </summary>
    public unsafe byte DownAllowSubClasses_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3591); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3591); }
    }
    /// <summary>
    /// ByteProperty: DownAllowSubClasses
    /// </summary>
    public unsafe byte DownAllowSubClasses_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3592); }
    }

    /// <summary>
    /// ByteProperty: CurrentPerchDir
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.PerchDirection CurrentPerchDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.PerchDirection>(Ptr + 3593); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3593); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: LandMoves
    /// </summary>
    public InlineArray<BmSDK.BmGame.RSpecialMoveConfig> LandMoves => new(6, Ptr + 3596, 4, this);

    /// <summary>
    /// ObjectProperty: LandMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LandMoves_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3596); }
    }
    /// <summary>
    /// ObjectProperty: LandMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LandMoves_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3600); }
    }
    /// <summary>
    /// ObjectProperty: LandMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LandMoves_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3604); }
    }
    /// <summary>
    /// ObjectProperty: LandMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LandMoves_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3608); }
    }
    /// <summary>
    /// ObjectProperty: LandMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LandMoves_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3612); }
    }
    /// <summary>
    /// ObjectProperty: LandMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LandMoves_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3616); }
    }

    /// <summary>
    /// ObjectProperty: RailingLandMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RailingLandMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3620); }
    }

    /// <summary>
    /// ObjectProperty: RailingLandWalkMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RailingLandWalkMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3624); }
    }

    /// <summary>
    /// ObjectProperty: DeepFallLandSuccess
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DeepFallLandSuccess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3628); }
    }

    /// <summary>
    /// ObjectProperty: DeepFallLandRunSuccess
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DeepFallLandRunSuccess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3632); }
    }

    /// <summary>
    /// ObjectProperty: DeepFallRailingLandSuccess
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DeepFallRailingLandSuccess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3636); }
    }

    /// <summary>
    /// ObjectProperty: DeepFallRailingWalkLandSuccess
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DeepFallRailingWalkLandSuccess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3640); }
    }

    /// <summary>
    /// ObjectProperty: CornerSlipMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CornerSlipMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3644); }
    }

    /// <summary>
    /// ObjectProperty: CornerSlipCrouchMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CornerSlipCrouchMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3648); }
    }

    /// <summary>
    /// FloatProperty: CriticalFallHeight
    /// </summary>
    public unsafe float CriticalFallHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3652); }
    }

    /// <summary>
    /// FloatProperty: CriticalFallHeightWarnTime
    /// </summary>
    public unsafe float CriticalFallHeightWarnTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3656); }
    }

    /// <summary>
    /// FloatProperty: MinCriticalFallSpeed
    /// </summary>
    public unsafe float MinCriticalFallSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3660); }
    }

    /// <summary>
    /// FloatProperty: MaxCriticalFallSpeed
    /// </summary>
    public unsafe float MaxCriticalFallSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3664); }
    }

    /// <summary>
    /// FloatProperty: MinCriticalFallDamage
    /// </summary>
    public unsafe float MinCriticalFallDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3668); }
    }

    /// <summary>
    /// FloatProperty: MaxCriticalFallDamage
    /// </summary>
    public unsafe float MaxCriticalFallDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3672); }
    }

    /// <summary>
    /// StructProperty: CriticalFallImpactLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CriticalFallImpactLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3676);

    /// <summary>
    /// ObjectProperty: SwingKickMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SwingKickMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3688); }
    }

    /// <summary>
    /// ObjectProperty: OverrideVantageSwingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig OverrideVantageSwingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3692); }
    }

    /// <summary>
    /// ObjectProperty: OverrideVantageLandMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig OverrideVantageLandMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3696); }
    }

    /// <summary>
    /// ObjectProperty: OverrideLampSwingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig OverrideLampSwingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3700); }
    }

    /// <summary>
    /// StructProperty: CurrentTakeDownData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FNetworkedAnimPair CurrentTakeDownData
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FNetworkedAnimPair>(Ptr + 3704);

    /// <summary>
    /// StructProperty: CurrentAttackerTransition
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId CurrentAttackerTransition
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 3744);

    /// <summary>
    /// StructProperty: CurrentVictimTransition
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId CurrentVictimTransition
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 3748);

    /// <summary>
    /// ObjectProperty: CurrentTakedownVictim
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer CurrentTakedownVictim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 3752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3752); }
    }

    /// <summary>
    /// StructProperty: EndRefPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EndRefPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3756);

    /// <summary>
    /// StructProperty: StartRefPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StartRefPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3768);

    /// <summary>
    /// StructProperty: CurrentRefPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentRefPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3780);

    /// <summary>
    /// StructProperty: EndRefRot
    /// </summary>
    public unsafe ref BmSDK.Rotator EndRefRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 3792);

    /// <summary>
    /// StructProperty: StartRefRot
    /// </summary>
    public unsafe ref BmSDK.Rotator StartRefRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 3804);

    /// <summary>
    /// StructProperty: CurrentRefRot
    /// </summary>
    public unsafe ref BmSDK.Rotator CurrentRefRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 3816);

    /// <summary>
    /// FloatProperty: RefPosInterpFrac
    /// </summary>
    public unsafe float RefPosInterpFrac
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3828); }
    }

    /// <summary>
    /// FloatProperty: InterpStartTime
    /// </summary>
    public unsafe float InterpStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3832); }
    }

    /// <summary>
    /// FloatProperty: InterpExp
    /// </summary>
    public unsafe float InterpExp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3836); }
    }

    /// <summary>
    /// FloatProperty: InterpLength
    /// </summary>
    public unsafe float InterpLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3840); }
    }

    /// <summary>
    /// FloatProperty: CachedVisionOpacity
    /// </summary>
    public unsafe float CachedVisionOpacity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3844); }
    }

    /// <summary>
    /// StructProperty: CoverDescription
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FCoverDescriptor CoverDescription
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FCoverDescriptor>(Ptr + 3848);

    /// <summary>
    /// StructProperty: StandMeshOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StandMeshOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3912);

    /// <summary>
    /// StructProperty: CrouchMeshOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CrouchMeshOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3924);

    /// <summary>
    /// ObjectProperty: PhotoScanner
    /// </summary>
    public unsafe BmSDK.BmGame.RPhotoScanner PhotoScanner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPhotoScanner>(Ptr + 3936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3936); }
    }

    /// <summary>
    /// ObjectProperty: PhysicsGrabber
    /// </summary>
    public unsafe BmSDK.BmGame.RPhysicsGrabber PhysicsGrabber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPhysicsGrabber>(Ptr + 3940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3940); }
    }

    /// <summary>
    /// ObjectProperty: MagicSmasher
    /// </summary>
    public unsafe BmSDK.BmGame.RMagicSmasher MagicSmasher
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagicSmasher>(Ptr + 3944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3944); }
    }

    /// <summary>
    /// ObjectProperty: MagicGunStartle
    /// </summary>
    public unsafe BmSDK.BmGame.RMagicGunStartle MagicGunStartle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagicGunStartle>(Ptr + 3948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3948); }
    }

    /// <summary>
    /// FloatProperty: MaxTurnDegreesPerSecond
    /// </summary>
    public unsafe float MaxTurnDegreesPerSecond
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3952); }
    }

    /// <summary>
    /// FloatProperty: GlideTurnDegreesPerSecond
    /// </summary>
    public unsafe float GlideTurnDegreesPerSecond
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3956); }
    }

    /// <summary>
    /// FloatProperty: WalkTurnDegreesPerSecond
    /// </summary>
    public unsafe float WalkTurnDegreesPerSecond
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3960); }
    }

    /// <summary>
    /// ObjectProperty: EvidenceLog
    /// </summary>
    public unsafe BmSDK.BmGame.REvidenceLog EvidenceLog
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REvidenceLog>(Ptr + 3964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3964); }
    }

    /// <summary>
    /// FloatProperty: OverrideTime
    /// </summary>
    public unsafe float OverrideTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3968); }
    }

    /// <summary>
    /// StructProperty: OverridableTransition
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId OverridableTransition
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 3972);

    /// <summary>
    /// StructProperty: MovementDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MovementDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3976);

    /// <summary>
    /// StructProperty: PreCorrectionVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreCorrectionVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3988);

    /// <summary>
    /// StructProperty: GadgetTransition
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId GadgetTransition
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 4000);

    /// <summary>
    /// FloatProperty: LastDeltaTime
    /// </summary>
    public unsafe float LastDeltaTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4004); }
    }

    /// <summary>
    /// StructProperty: DeferedVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DeferedVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4008);

    /// <summary>
    /// ArrayProperty: LOSCapeChecks
    /// </summary>
    public unsafe BmSDK.TArray<int> LOSCapeChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 4020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4020); }
    }

    /// <summary>
    /// ArrayProperty: CoverRightLOSCheckBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CoverRightLOSCheckBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4032); }
    }

    /// <summary>
    /// ArrayProperty: CoverLeftLOSCheckBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CoverLeftLOSCheckBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4044); }
    }

    /// <summary>
    /// ArrayProperty: HangingLOSCheckBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> HangingLOSCheckBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4056); }
    }

    /// <summary>
    /// ArrayProperty: BracedLOSCheckBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BracedLOSCheckBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4068); }
    }

    /// <summary>
    /// ArrayProperty: HangingLOSCapeChecks
    /// </summary>
    public unsafe BmSDK.TArray<int> HangingLOSCapeChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 4080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4080); }
    }

    /// <summary>
    /// FloatProperty: WallStopCosAngle
    /// </summary>
    public unsafe float WallStopCosAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4092); }
    }

    /// <summary>
    /// FloatProperty: WallStopCheckRadius
    /// </summary>
    public unsafe float WallStopCheckRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4096); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: ControllerHistory
    /// </summary>
    public InlineArray<BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory> ControllerHistory => new(10, Ptr + 4100, 20, this);

    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory ControllerHistory_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory>(Ptr + 4100);
    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory ControllerHistory_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory>(Ptr + 4120);
    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory ControllerHistory_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory>(Ptr + 4140);
    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory ControllerHistory_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory>(Ptr + 4160);
    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory ControllerHistory_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory>(Ptr + 4180);
    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory ControllerHistory_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory>(Ptr + 4200);
    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory ControllerHistory_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory>(Ptr + 4220);
    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory ControllerHistory_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory>(Ptr + 4240);
    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory ControllerHistory_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory>(Ptr + 4260);
    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory ControllerHistory_9
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory>(Ptr + 4280);

    /// <summary>
    /// IntProperty: ControllerHistoryPosition
    /// </summary>
    public unsafe int ControllerHistoryPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4300); }
    }

    /// <summary>
    /// IntProperty: ControllerHistoryMax
    /// </summary>
    public unsafe int ControllerHistoryMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4304); }
    }

    /// <summary>
    /// InterfaceProperty: PassThroughAdjustMovementDirection
    /// </summary>
    public unsafe BmSDK.BmGame.RPassThroughAdjustMovementDirectionInterface PassThroughAdjustMovementDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPassThroughAdjustMovementDirectionInterface>(Ptr + 4308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4308); }
    }

    /// <summary>
    /// FloatProperty: MinCapeGlideTanAngle
    /// </summary>
    public unsafe float MinCapeGlideTanAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4316); }
    }

    /// <summary>
    /// FloatProperty: MaxCapeGlideTanAngle
    /// </summary>
    public unsafe float MaxCapeGlideTanAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4320); }
    }

    /// <summary>
    /// FloatProperty: MaxPounceAttackTanAngle
    /// </summary>
    public unsafe float MaxPounceAttackTanAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4324); }
    }

    /// <summary>
    /// FloatProperty: GlideAttackRange
    /// </summary>
    public unsafe float GlideAttackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4328); }
    }

    /// <summary>
    /// FloatProperty: PounceAttackRange
    /// </summary>
    public unsafe float PounceAttackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4332); }
    }

    /// <summary>
    /// ArrayProperty: HealthRecoverRate
    /// </summary>
    public unsafe BmSDK.TArray<float> HealthRecoverRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 4336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4336); }
    }

    /// <summary>
    /// IntProperty: MaxHealth
    /// </summary>
    public unsafe int MaxHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4348); }
    }

    /// <summary>
    /// IntProperty: OldHealth
    /// </summary>
    public unsafe int OldHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4352); }
    }

    /// <summary>
    /// ArrayProperty: FrontDamageOverlays
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> FrontDamageOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4356); }
    }

    /// <summary>
    /// ArrayProperty: LeftDamageOverlays
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> LeftDamageOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4368); }
    }

    /// <summary>
    /// ArrayProperty: RightDamageOverlays
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> RightDamageOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4380); }
    }

    /// <summary>
    /// ArrayProperty: BackDamageOverlays
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BackDamageOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4392); }
    }

    /// <summary>
    /// ArrayProperty: ElectricityDamageOverlays
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> ElectricityDamageOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4404); }
    }

    /// <summary>
    /// StructProperty: DamageOverlay
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId DamageOverlay
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(Ptr + 4416);

    /// <summary>
    /// FloatProperty: DesiredMovementScale
    /// </summary>
    public unsafe float DesiredMovementScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4424); }
    }

    /// <summary>
    /// FloatProperty: ActualMovementScale
    /// </summary>
    public unsafe float ActualMovementScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4428); }
    }

    /// <summary>
    /// FloatProperty: MovementScaleChangeSpeed
    /// </summary>
    public unsafe float MovementScaleChangeSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4432); }
    }

    /// <summary>
    /// FloatProperty: TunnelSpeedScale
    /// </summary>
    public unsafe float TunnelSpeedScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4436); }
    }

    /// <summary>
    /// FloatProperty: FirstPersonSpeedScale
    /// </summary>
    public unsafe float FirstPersonSpeedScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4440); }
    }

    /// <summary>
    /// StructProperty: StandingOffEdgeDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StandingOffEdgeDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4444);

    /// <summary>
    /// FloatProperty: ActualMovementSpeed
    /// </summary>
    public unsafe float ActualMovementSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4456); }
    }

    /// <summary>
    /// StructProperty: NetworkMoveVector
    /// </summary>
    public unsafe ref System.Numerics.Vector3 NetworkMoveVector
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4460);

    /// <summary>
    /// ArrayProperty: PoseIdleStances
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> PoseIdleStances
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4472); }
    }

    /// <summary>
    /// InlineArray{ClassProperty}: TakeDowns
    /// </summary>
    public InlineArray<BmSDK.Class> TakeDowns => new(39, Ptr + 4484, 4, this);

    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4484); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4488); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4492); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4496); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4500); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4504); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4508); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4512); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4516); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4520); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4524); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4528); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4532); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4536); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4540); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4544); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4548); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4552); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4556); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4560); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4564); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4568); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4572); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4576); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4580); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4584); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4588); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4592); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4596); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4600); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4604); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4608); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4612); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4616); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4620); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4624); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4628); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4632); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4636); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: TakeDownTemplates
    /// </summary>
    public InlineArray<BmSDK.BmGame.RStealthTakeDownStage> TakeDownTemplates => new(39, Ptr + 4640, 4, this);

    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4640); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4644); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4648); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4652); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4656); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4660); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4664); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4668); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4672); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4676); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4680); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4684); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4688); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4692); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4696); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4700); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4704); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4708); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4712); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4716); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4720); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4724); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4728); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4732); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4736); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4740); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4744); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4748); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4752); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4756); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4760); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4764); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4768); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4772); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4776); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4780); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4784); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4788); }
    }
    /// <summary>
    /// ObjectProperty: TakeDownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage TakeDownTemplates_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 4792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4792); }
    }

    /// <summary>
    /// IntProperty: ProjectileLaunchId
    /// </summary>
    public unsafe int ProjectileLaunchId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4796); }
    }

    /// <summary>
    /// ObjectProperty: ActiveTunnelFunnel
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelFunnel ActiveTunnelFunnel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelFunnel>(Ptr + 4800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4800); }
    }

    /// <summary>
    /// ObjectProperty: NearestTunnelFunnel
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelFunnel NearestTunnelFunnel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelFunnel>(Ptr + 4804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4804); }
    }

    /// <summary>
    /// IntProperty: LastTakedownId
    /// </summary>
    public unsafe int LastTakedownId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4808); }
    }

    /// <summary>
    /// IntProperty: LastTakedownStageAnimId
    /// </summary>
    public unsafe int LastTakedownStageAnimId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4812); }
    }

    /// <summary>
    /// FloatProperty: LastStaggerTime
    /// </summary>
    public unsafe float LastStaggerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4816); }
    }

    /// <summary>
    /// FloatProperty: MinShotStaggerTime
    /// </summary>
    public unsafe float MinShotStaggerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4820); }
    }

    /// <summary>
    /// IntProperty: DamageResistance
    /// </summary>
    public unsafe int DamageResistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4824); }
    }

    /// <summary>
    /// IntProperty: DamageRemainder
    /// </summary>
    public unsafe int DamageRemainder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4828); }
    }

    /// <summary>
    /// ObjectProperty: PlayerDeathEmote
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine PlayerDeathEmote
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4832); }
    }

    /// <summary>
    /// ObjectProperty: GrateExcluder
    /// </summary>
    public unsafe BmSDK.Engine.RB_BodyInstance GrateExcluder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RB_BodyInstance>(Ptr + 4836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4836); }
    }

    /// <summary>
    /// ObjectProperty: LegGrateExcluder
    /// </summary>
    public unsafe BmSDK.Engine.RB_BodyInstance LegGrateExcluder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RB_BodyInstance>(Ptr + 4840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4840); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: SpawnedProjectiles
    /// </summary>
    public InlineArray<BmSDK.BmGame.RProjectile> SpawnedProjectiles => new(6, Ptr + 4844, 4, this);

    /// <summary>
    /// ObjectProperty: SpawnedProjectiles
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile SpawnedProjectiles_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 4844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4844); }
    }
    /// <summary>
    /// ObjectProperty: SpawnedProjectiles
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile SpawnedProjectiles_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 4848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4848); }
    }
    /// <summary>
    /// ObjectProperty: SpawnedProjectiles
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile SpawnedProjectiles_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 4852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4852); }
    }
    /// <summary>
    /// ObjectProperty: SpawnedProjectiles
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile SpawnedProjectiles_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 4856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4856); }
    }
    /// <summary>
    /// ObjectProperty: SpawnedProjectiles
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile SpawnedProjectiles_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 4860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4860); }
    }
    /// <summary>
    /// ObjectProperty: SpawnedProjectiles
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile SpawnedProjectiles_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 4864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4864); }
    }

    /// <summary>
    /// FloatProperty: DryPct
    /// </summary>
    public unsafe float DryPct
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4868); }
    }

    /// <summary>
    /// StructProperty: DesiredPoseForReplication
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FPoseForReplicationStruct DesiredPoseForReplication
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FPoseForReplicationStruct>(Ptr + 4872);

    /// <summary>
    /// StructProperty: OldDesiredPoseForReplication
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FPoseForReplicationStruct OldDesiredPoseForReplication
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FPoseForReplicationStruct>(Ptr + 4884);

    /// <summary>
    /// StructProperty: AimDirectionForReplication
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AimDirectionForReplication
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4896);

    /// <summary>
    /// StructProperty: VectorDataForReplication
    /// </summary>
    public unsafe ref System.Numerics.Vector3 VectorDataForReplication
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4908);

    /// <summary>
    /// ObjectProperty: ActorForReplication
    /// </summary>
    public unsafe BmSDK.Engine.Actor ActorForReplication
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 4920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4920); }
    }

    /// <summary>
    /// NameProperty: CapeStateNameForReplication
    /// </summary>
    public unsafe BmSDK.FName CapeStateNameForReplication
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4924); }
    }

    /// <summary>
    /// NameProperty: CurrentRunningAnimNotifyCapeStateName
    /// </summary>
    public unsafe BmSDK.FName CurrentRunningAnimNotifyCapeStateName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4932); }
    }

    /// <summary>
    /// StructProperty: LastClientLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastClientLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4940);

    /// <summary>
    /// FloatProperty: SimulatedTimeInCurrentPose
    /// </summary>
    public unsafe float SimulatedTimeInCurrentPose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4952); }
    }

    /// <summary>
    /// FloatProperty: StealthValue
    /// </summary>
    public unsafe float StealthValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4956); }
    }

    /// <summary>
    /// FloatProperty: StealthValueDelta
    /// </summary>
    public unsafe float StealthValueDelta
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4960); }
    }

    /// <summary>
    /// IntProperty: PlayerIndex
    /// </summary>
    public unsafe int PlayerIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4964); }
    }

    /// <summary>
    /// StructProperty: FallingTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FallingTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4968);

    /// <summary>
    /// ObjectProperty: FallingTargetActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor FallingTargetActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 4980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4980); }
    }

    /// <summary>
    /// FloatProperty: BoostSpeed
    /// </summary>
    public unsafe float BoostSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4984); }
    }

    /// <summary>
    /// FloatProperty: BoostTime
    /// </summary>
    public unsafe float BoostTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4988); }
    }

    /// <summary>
    /// FloatProperty: DefaultBoostSpeed
    /// </summary>
    public unsafe float DefaultBoostSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4992); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: UpGadgets
    /// </summary>
    public InlineArray<BmSDK.FName> UpGadgets => new(8, Ptr + 4996, 8, this);

    /// <summary>
    /// NameProperty: UpGadgets
    /// </summary>
    public unsafe BmSDK.FName UpGadgets_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4996); }
    }
    /// <summary>
    /// NameProperty: UpGadgets
    /// </summary>
    public unsafe BmSDK.FName UpGadgets_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5004); }
    }
    /// <summary>
    /// NameProperty: UpGadgets
    /// </summary>
    public unsafe BmSDK.FName UpGadgets_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5012); }
    }
    /// <summary>
    /// NameProperty: UpGadgets
    /// </summary>
    public unsafe BmSDK.FName UpGadgets_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5020); }
    }
    /// <summary>
    /// NameProperty: UpGadgets
    /// </summary>
    public unsafe BmSDK.FName UpGadgets_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5028); }
    }
    /// <summary>
    /// NameProperty: UpGadgets
    /// </summary>
    public unsafe BmSDK.FName UpGadgets_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5036); }
    }
    /// <summary>
    /// NameProperty: UpGadgets
    /// </summary>
    public unsafe BmSDK.FName UpGadgets_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5044); }
    }
    /// <summary>
    /// NameProperty: UpGadgets
    /// </summary>
    public unsafe BmSDK.FName UpGadgets_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5052); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: DoubleUpGadgets
    /// </summary>
    public InlineArray<BmSDK.FName> DoubleUpGadgets => new(8, Ptr + 5060, 8, this);

    /// <summary>
    /// NameProperty: DoubleUpGadgets
    /// </summary>
    public unsafe BmSDK.FName DoubleUpGadgets_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5060); }
    }
    /// <summary>
    /// NameProperty: DoubleUpGadgets
    /// </summary>
    public unsafe BmSDK.FName DoubleUpGadgets_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5068); }
    }
    /// <summary>
    /// NameProperty: DoubleUpGadgets
    /// </summary>
    public unsafe BmSDK.FName DoubleUpGadgets_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5076); }
    }
    /// <summary>
    /// NameProperty: DoubleUpGadgets
    /// </summary>
    public unsafe BmSDK.FName DoubleUpGadgets_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5084); }
    }
    /// <summary>
    /// NameProperty: DoubleUpGadgets
    /// </summary>
    public unsafe BmSDK.FName DoubleUpGadgets_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5092); }
    }
    /// <summary>
    /// NameProperty: DoubleUpGadgets
    /// </summary>
    public unsafe BmSDK.FName DoubleUpGadgets_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5100); }
    }
    /// <summary>
    /// NameProperty: DoubleUpGadgets
    /// </summary>
    public unsafe BmSDK.FName DoubleUpGadgets_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5108); }
    }
    /// <summary>
    /// NameProperty: DoubleUpGadgets
    /// </summary>
    public unsafe BmSDK.FName DoubleUpGadgets_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5116); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: DownGadgets
    /// </summary>
    public InlineArray<BmSDK.FName> DownGadgets => new(5, Ptr + 5124, 8, this);

    /// <summary>
    /// NameProperty: DownGadgets
    /// </summary>
    public unsafe BmSDK.FName DownGadgets_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5124); }
    }
    /// <summary>
    /// NameProperty: DownGadgets
    /// </summary>
    public unsafe BmSDK.FName DownGadgets_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5132); }
    }
    /// <summary>
    /// NameProperty: DownGadgets
    /// </summary>
    public unsafe BmSDK.FName DownGadgets_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5140); }
    }
    /// <summary>
    /// NameProperty: DownGadgets
    /// </summary>
    public unsafe BmSDK.FName DownGadgets_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5148); }
    }
    /// <summary>
    /// NameProperty: DownGadgets
    /// </summary>
    public unsafe BmSDK.FName DownGadgets_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5156); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: ExtraCollision
    /// </summary>
    public InlineArray<BmSDK.BmGame.RPawnPlayer.FFakeWall> ExtraCollision => new(3, Ptr + 5164, 16, this);

    /// <summary>
    /// StructProperty: ExtraCollision
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FFakeWall ExtraCollision_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FFakeWall>(Ptr + 5164);
    /// <summary>
    /// StructProperty: ExtraCollision
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FFakeWall ExtraCollision_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FFakeWall>(Ptr + 5180);
    /// <summary>
    /// StructProperty: ExtraCollision
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FFakeWall ExtraCollision_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FFakeWall>(Ptr + 5196);

    /// <summary>
    /// ComponentProperty: OverrideUnderColl
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent OverrideUnderColl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent>(Ptr + 5212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5212); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: OverheadRopeControlPoint
    /// </summary>
    public InlineArray<BmSDK.BmGame.RRope2SimplePhysicsControlPoint> OverheadRopeControlPoint => new(5, Ptr + 5216, 4, this);

    /// <summary>
    /// ObjectProperty: OverheadRopeControlPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2SimplePhysicsControlPoint OverheadRopeControlPoint_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2SimplePhysicsControlPoint>(Ptr + 5216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5216); }
    }
    /// <summary>
    /// ObjectProperty: OverheadRopeControlPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2SimplePhysicsControlPoint OverheadRopeControlPoint_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2SimplePhysicsControlPoint>(Ptr + 5220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5220); }
    }
    /// <summary>
    /// ObjectProperty: OverheadRopeControlPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2SimplePhysicsControlPoint OverheadRopeControlPoint_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2SimplePhysicsControlPoint>(Ptr + 5224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5224); }
    }
    /// <summary>
    /// ObjectProperty: OverheadRopeControlPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2SimplePhysicsControlPoint OverheadRopeControlPoint_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2SimplePhysicsControlPoint>(Ptr + 5228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5228); }
    }
    /// <summary>
    /// ObjectProperty: OverheadRopeControlPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2SimplePhysicsControlPoint OverheadRopeControlPoint_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2SimplePhysicsControlPoint>(Ptr + 5232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5232); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: OverheadRopeControlPointRopePosition
    /// </summary>
    public InlineArray<float> OverheadRopeControlPointRopePosition => new(5, Ptr + 5236, 4, this);

    /// <summary>
    /// FloatProperty: OverheadRopeControlPointRopePosition
    /// </summary>
    public unsafe float OverheadRopeControlPointRopePosition_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5236); }
    }
    /// <summary>
    /// FloatProperty: OverheadRopeControlPointRopePosition
    /// </summary>
    public unsafe float OverheadRopeControlPointRopePosition_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5240); }
    }
    /// <summary>
    /// FloatProperty: OverheadRopeControlPointRopePosition
    /// </summary>
    public unsafe float OverheadRopeControlPointRopePosition_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5244); }
    }
    /// <summary>
    /// FloatProperty: OverheadRopeControlPointRopePosition
    /// </summary>
    public unsafe float OverheadRopeControlPointRopePosition_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5248); }
    }
    /// <summary>
    /// FloatProperty: OverheadRopeControlPointRopePosition
    /// </summary>
    public unsafe float OverheadRopeControlPointRopePosition_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5252); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: OverheadRopeControlPointSocketNames
    /// </summary>
    public InlineArray<BmSDK.FName> OverheadRopeControlPointSocketNames => new(5, Ptr + 5256, 8, this);

    /// <summary>
    /// NameProperty: OverheadRopeControlPointSocketNames
    /// </summary>
    public unsafe BmSDK.FName OverheadRopeControlPointSocketNames_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5256); }
    }
    /// <summary>
    /// NameProperty: OverheadRopeControlPointSocketNames
    /// </summary>
    public unsafe BmSDK.FName OverheadRopeControlPointSocketNames_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5264); }
    }
    /// <summary>
    /// NameProperty: OverheadRopeControlPointSocketNames
    /// </summary>
    public unsafe BmSDK.FName OverheadRopeControlPointSocketNames_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5272); }
    }
    /// <summary>
    /// NameProperty: OverheadRopeControlPointSocketNames
    /// </summary>
    public unsafe BmSDK.FName OverheadRopeControlPointSocketNames_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5280); }
    }
    /// <summary>
    /// NameProperty: OverheadRopeControlPointSocketNames
    /// </summary>
    public unsafe BmSDK.FName OverheadRopeControlPointSocketNames_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5288); }
    }

    /// <summary>
    /// ArrayProperty: BatclawSocketTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BatclawSocketTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 5296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5296); }
    }

    /// <summary>
    /// ObjectProperty: LastWirePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint_RopeBase LastWirePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint_RopeBase>(Ptr + 5308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5308); }
    }

    /// <summary>
    /// ObjectProperty: CurrentSpecialMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveInstance CurrentSpecialMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveInstance>(Ptr + 5312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5312); }
    }

    /// <summary>
    /// StructProperty: ClimbToCeilingClimbPoint
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FCeilingClimbPoint ClimbToCeilingClimbPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FCeilingClimbPoint>(Ptr + 5316);

    /// <summary>
    /// StructProperty: ClimbToCatwalkClimbPoint
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FCeilingClimbPoint ClimbToCatwalkClimbPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FCeilingClimbPoint>(Ptr + 5428);

    /// <summary>
    /// ObjectProperty: CurrentCeilingVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RCeilingClimbVolume CurrentCeilingVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCeilingClimbVolume>(Ptr + 5540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5540); }
    }

    /// <summary>
    /// ObjectProperty: GrateToCeiling
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelGrateBase GrateToCeiling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateBase>(Ptr + 5544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5544); }
    }

    /// <summary>
    /// ObjectProperty: GrateFromCeiling
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelGrateBase GrateFromCeiling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateBase>(Ptr + 5548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5548); }
    }

    /// <summary>
    /// ObjectProperty: ActiveGrate
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelGrateBase ActiveGrate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateBase>(Ptr + 5552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5552); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: GadgetList
    /// </summary>
    public InlineArray<BmSDK.BmGame.RInventoryGadget> GadgetList => new(32, Ptr + 5556, 4, this);

    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5556); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5560); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5564); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5568); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5572); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5576); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5580); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5584); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5588); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5592); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5596); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5600); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5604); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5608); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5612); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5616); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5620); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5624); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5628); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5632); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5636); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5640); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5644); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5648); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5652); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5656); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5660); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5664); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5668); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5672); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5676); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5680); }
    }

    /// <summary>
    /// IntProperty: LoadoutStartIdx
    /// </summary>
    public unsafe int LoadoutStartIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5684); }
    }

    /// <summary>
    /// IntProperty: FreeGadgetIdx
    /// </summary>
    public unsafe int FreeGadgetIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5688); }
    }

    /// <summary>
    /// IntProperty: AttachedGadgetIdx
    /// </summary>
    public unsafe int AttachedGadgetIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5692); }
    }

    /// <summary>
    /// IntProperty: SelectedGadgetIdx
    /// </summary>
    public unsafe int SelectedGadgetIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5696); }
    }

    /// <summary>
    /// ObjectProperty: AttachedGadget
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget AttachedGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5700); }
    }

    /// <summary>
    /// StructProperty: LastJumpVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastJumpVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5704);

    /// <summary>
    /// ObjectProperty: GlideKickOverridePS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem GlideKickOverridePS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5716); }
    }

    /// <summary>
    /// ObjectProperty: SuperGlideAttackFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem SuperGlideAttackFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5720); }
    }

    /// <summary>
    /// ObjectProperty: SuperGlideAttackMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant SuperGlideAttackMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 5724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5724); }
    }

    /// <summary>
    /// ClassProperty: ForensicsType
    /// </summary>
    public unsafe BmSDK.Class ForensicsType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 5728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5728); }
    }

    /// <summary>
    /// ObjectProperty: TraversalMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController TraversalMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5732); }
    }

    /// <summary>
    /// ObjectProperty: StealthMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController StealthMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5736); }
    }

    /// <summary>
    /// ObjectProperty: RunTraversalMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController RunTraversalMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5740); }
    }

    /// <summary>
    /// ObjectProperty: StealthTraversalMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController StealthTraversalMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5744); }
    }

    /// <summary>
    /// ObjectProperty: WalkingMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController WalkingMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5748); }
    }

    /// <summary>
    /// ObjectProperty: FallingSpecialMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController FallingSpecialMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5752); }
    }

    /// <summary>
    /// ObjectProperty: FallingClimbSpecialMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController FallingClimbSpecialMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5756); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideSpecialMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController CapeGlideSpecialMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5760); }
    }

    /// <summary>
    /// ObjectProperty: HardCapeGlideSpecialMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController HardCapeGlideSpecialMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5764); }
    }

    /// <summary>
    /// ObjectProperty: ClimbFromLedgeMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController ClimbFromLedgeMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5768); }
    }

    /// <summary>
    /// ObjectProperty: ClimbFromDangleMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController ClimbFromDangleMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5772); }
    }

    /// <summary>
    /// ObjectProperty: ClimbFromLadderMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController ClimbFromLadderMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5776); }
    }

    /// <summary>
    /// ObjectProperty: LedgeMovesLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController LedgeMovesLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5780); }
    }

    /// <summary>
    /// ObjectProperty: LedgeMovesRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController LedgeMovesRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5784); }
    }

    /// <summary>
    /// ObjectProperty: DangleMovesLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController DangleMovesLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5788); }
    }

    /// <summary>
    /// ObjectProperty: DangleMovesRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController DangleMovesRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5792); }
    }

    /// <summary>
    /// ObjectProperty: JumpStraightOffRailingMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController JumpStraightOffRailingMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5796); }
    }

    /// <summary>
    /// IntProperty: ClimbIndex
    /// </summary>
    public unsafe int ClimbIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5800); }
    }

    /// <summary>
    /// ObjectProperty: CustomisableFallingGrabLedgeMove
    /// </summary>
    public unsafe BmSDK.BmGame.REnvironmentSpecialMoveWrapperFalling CustomisableFallingGrabLedgeMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentSpecialMoveWrapperFalling>(Ptr + 5804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5804); }
    }

    /// <summary>
    /// ObjectProperty: HopOffRailangMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HopOffRailangMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5808); }
    }

    /// <summary>
    /// ObjectProperty: HopOffRailangMoveToHang
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HopOffRailangMoveToHang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5812); }
    }

    /// <summary>
    /// ObjectProperty: HopOffRailangMoveToHang128
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HopOffRailangMoveToHang128
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5816); }
    }

    /// <summary>
    /// ObjectProperty: HopOffRailangMoveToHang128Dangle
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HopOffRailangMoveToHang128Dangle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5820); }
    }

    /// <summary>
    /// ObjectProperty: StepOffRailing128Move
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig StepOffRailing128Move
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5824); }
    }

    /// <summary>
    /// ObjectProperty: DropOffWireMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DropOffWireMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5828); }
    }

    /// <summary>
    /// ObjectProperty: GlideKickMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GlideKickMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5832); }
    }

    /// <summary>
    /// ObjectProperty: BoostGlideKickMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig BoostGlideKickMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5836); }
    }

    /// <summary>
    /// ObjectProperty: DiveOffBuildingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DiveOffBuildingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5840); }
    }

    /// <summary>
    /// ObjectProperty: GlideFromVantagePointMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GlideFromVantagePointMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5844); }
    }

    /// <summary>
    /// ObjectProperty: LastChanceJumpMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LastChanceJumpMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5848); }
    }

    /// <summary>
    /// ObjectProperty: LowGlideKickMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LowGlideKickMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5852); }
    }

    /// <summary>
    /// ObjectProperty: ExitCoverLeftMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ExitCoverLeftMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5856); }
    }

    /// <summary>
    /// ObjectProperty: ExitCoverRightMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ExitCoverRightMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5860); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideLandHardMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CapeGlideLandHardMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5864); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideLandSkidMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CapeGlideLandSkidMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5868); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideLandToRunMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CapeGlideLandToRunMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5872); }
    }

    /// <summary>
    /// ObjectProperty: FastGlideSkidLandMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig FastGlideSkidLandMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5876); }
    }

    /// <summary>
    /// ObjectProperty: BoostGlideLandMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig BoostGlideLandMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5880); }
    }

    /// <summary>
    /// ObjectProperty: BoostGlideLandHardMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig BoostGlideLandHardMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5884); }
    }

    /// <summary>
    /// ObjectProperty: ShockwaveUpgradeLandMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ShockwaveUpgradeLandMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5888); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideWallHitMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CapeGlideWallHitMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5892); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideWallHitHardMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CapeGlideWallHitHardMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5896); }
    }

    /// <summary>
    /// ObjectProperty: SlideMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SlideMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5900); }
    }

    /// <summary>
    /// ObjectProperty: DiveOverRailingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DiveOverRailingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5904); }
    }

    /// <summary>
    /// ObjectProperty: DiveOverRailingToFallMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DiveOverRailingToFallMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5908); }
    }

    /// <summary>
    /// ObjectProperty: RailingToLedgeHangMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RailingToLedgeHangMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5912); }
    }

    /// <summary>
    /// ObjectProperty: RailingToLEdgeHang128Move
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RailingToLEdgeHang128Move
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5916); }
    }

    /// <summary>
    /// ObjectProperty: RunStepDown128Move
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RunStepDown128Move
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5920); }
    }

    /// <summary>
    /// ObjectProperty: WalkStepDown128Move
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig WalkStepDown128Move
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5924); }
    }

    /// <summary>
    /// ObjectProperty: StealthStepDown128Move
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig StealthStepDown128Move
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5928); }
    }

    /// <summary>
    /// StructProperty: WireBouncer
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FWireBounceUpdater WireBouncer
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FWireBounceUpdater>(Ptr + 5932);

    /// <summary>
    /// ComponentProperty: PlayerIconPSC
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent PlayerIconPSC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6000); }
    }

    /// <summary>
    /// ObjectProperty: SlideStopAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SlideStopAudioEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 6004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6004); }
    }

    /// <summary>
    /// StructProperty: CurrentCollisionSmoothingForce
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentCollisionSmoothingForce
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6008);

    /// <summary>
    /// StructProperty: DesiredCollisionSmoothingForce
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DesiredCollisionSmoothingForce
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6020);

    /// <summary>
    /// FloatProperty: CollisionSmoothingStrength
    /// </summary>
    public unsafe float CollisionSmoothingStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6032); }
    }

    /// <summary>
    /// FloatProperty: CollisionSmoothingOffStrength
    /// </summary>
    public unsafe float CollisionSmoothingOffStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6036); }
    }

    /// <summary>
    /// FloatProperty: CurrentAvoidAnimStrength
    /// </summary>
    public unsafe float CurrentAvoidAnimStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6040); }
    }

    /// <summary>
    /// FloatProperty: MaxAvoidAnimSpeed
    /// </summary>
    public unsafe float MaxAvoidAnimSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6044); }
    }

    /// <summary>
    /// FloatProperty: AvoidAnimOnStrength
    /// </summary>
    public unsafe float AvoidAnimOnStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6048); }
    }

    /// <summary>
    /// FloatProperty: AvoidAnimOffStrength
    /// </summary>
    public unsafe float AvoidAnimOffStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6052); }
    }

    /// <summary>
    /// ObjectProperty: GlideBoostSoundEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GlideBoostSoundEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 6056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6056); }
    }

    /// <summary>
    /// ObjectProperty: GlideBoostStopSoundEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GlideBoostStopSoundEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 6060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6060); }
    }

    /// <summary>
    /// ObjectProperty: GlideBoostSoundParam
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName GlideBoostSoundParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 6064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6064); }
    }

    /// <summary>
    /// ObjectProperty: CapeOpenSoundParam
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName CapeOpenSoundParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 6068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6068); }
    }

    /// <summary>
    /// StructProperty: CriticalLandScreenShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct CriticalLandScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 6072);

    /// <summary>
    /// InlineArray{IntProperty}: QuickGadgets
    /// </summary>
    public InlineArray<int> QuickGadgets => new(7, Ptr + 6216, 4, this);

    /// <summary>
    /// IntProperty: QuickGadgets
    /// </summary>
    public unsafe int QuickGadgets_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6216); }
    }
    /// <summary>
    /// IntProperty: QuickGadgets
    /// </summary>
    public unsafe int QuickGadgets_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6220); }
    }
    /// <summary>
    /// IntProperty: QuickGadgets
    /// </summary>
    public unsafe int QuickGadgets_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6224); }
    }
    /// <summary>
    /// IntProperty: QuickGadgets
    /// </summary>
    public unsafe int QuickGadgets_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6228); }
    }
    /// <summary>
    /// IntProperty: QuickGadgets
    /// </summary>
    public unsafe int QuickGadgets_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6232); }
    }
    /// <summary>
    /// IntProperty: QuickGadgets
    /// </summary>
    public unsafe int QuickGadgets_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6236); }
    }
    /// <summary>
    /// IntProperty: QuickGadgets
    /// </summary>
    public unsafe int QuickGadgets_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6240); }
    }

    /// <summary>
    /// FloatProperty: SpecialMoveLeftFootCycleStartTime
    /// </summary>
    public unsafe float SpecialMoveLeftFootCycleStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6244); }
    }

    /// <summary>
    /// FloatProperty: SpecialMoveRightPassingCycleStartTime
    /// </summary>
    public unsafe float SpecialMoveRightPassingCycleStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6248); }
    }

    /// <summary>
    /// FloatProperty: OverrideFallingGravity
    /// </summary>
    public unsafe float OverrideFallingGravity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6252); }
    }

    /// <summary>
    /// FloatProperty: MaxJumpStrengthToJumpLand
    /// </summary>
    public unsafe float MaxJumpStrengthToJumpLand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6256); }
    }

    /// <summary>
    /// FloatProperty: GrappleForceFieldSize
    /// </summary>
    public unsafe float GrappleForceFieldSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6260); }
    }

    /// <summary>
    /// FloatProperty: GrappleForceFieldWidth
    /// </summary>
    public unsafe float GrappleForceFieldWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6264); }
    }

    /// <summary>
    /// FloatProperty: GrappleForceFieldStrength
    /// </summary>
    public unsafe float GrappleForceFieldStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6268); }
    }

    /// <summary>
    /// FloatProperty: GrappleForceFieldStrengthPower
    /// </summary>
    public unsafe float GrappleForceFieldStrengthPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6272); }
    }

    /// <summary>
    /// FloatProperty: GrappleAnimForceFieldFactor
    /// </summary>
    public unsafe float GrappleAnimForceFieldFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6276); }
    }

    /// <summary>
    /// StructProperty: CantRunInDirection
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CantRunInDirection
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6280);

    /// <summary>
    /// StructProperty: QuickFireFailedTransitionId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId QuickFireFailedTransitionId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 6292);

    /// <summary>
    /// StructProperty: ShotOnVantageShaker
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ShotOnVantageShaker
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 6296);

    /// <summary>
    /// ObjectProperty: UnderWaterVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RWaterRescueVolumeBase UnderWaterVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWaterRescueVolumeBase>(Ptr + 6440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6440); }
    }

    /// <summary>
    /// StructProperty: UnderWaterVolumeLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 UnderWaterVolumeLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6444);

    /// <summary>
    /// ObjectProperty: UnderWaterEmitter
    /// </summary>
    public unsafe BmSDK.BmGame.REmitter UnderWaterEmitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REmitter>(Ptr + 6456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6456); }
    }

    /// <summary>
    /// ObjectProperty: SlippedCorner
    /// </summary>
    public unsafe BmSDK.Engine.Actor SlippedCorner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 6460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6460); }
    }

    /// <summary>
    /// FloatProperty: JumpStrength
    /// </summary>
    public unsafe float JumpStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6464); }
    }

    /// <summary>
    /// FloatProperty: JumpFallOffRate
    /// </summary>
    public unsafe float JumpFallOffRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6468); }
    }

    /// <summary>
    /// FloatProperty: FallAnimRate
    /// </summary>
    public unsafe float FallAnimRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6472); }
    }

    /// <summary>
    /// FloatProperty: JumpAnimRate
    /// </summary>
    public unsafe float JumpAnimRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6476); }
    }

    /// <summary>
    /// ObjectProperty: FallSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FallSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 6480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6480); }
    }

    /// <summary>
    /// ObjectProperty: FallStopSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FallStopSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 6484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6484); }
    }

    /// <summary>
    /// ComponentProperty: HangFromVantageRope
    /// </summary>
    public unsafe BmSDK.BmGame.RSimpleRopeComponent HangFromVantageRope
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSimpleRopeComponent>(Ptr + 6488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6488); }
    }

    /// <summary>
    /// StructProperty: LastRootMotionVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastRootMotionVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6492);

    /// <summary>
    /// StructProperty: EnvironemntEdgeTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveTypesContainer EnvironemntEdgeTypes
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveTypesContainer>(Ptr + 6504);

    /// <summary>
    /// StructProperty: DamageProxyLastActivePos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DamageProxyLastActivePos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6512);

    /// <summary>
    /// StructProperty: InterrogWallSpaceCheckExtents
    /// </summary>
    public unsafe ref System.Numerics.Vector3 InterrogWallSpaceCheckExtents
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6524);

    /// <summary>
    /// FloatProperty: InterrogWallSpaceCheckHeight
    /// </summary>
    public unsafe float InterrogWallSpaceCheckHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6536); }
    }

    /// <summary>
    /// ArrayProperty: BatarangTargetBodyParts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BatarangTargetBodyParts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 6540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6540); }
    }

    /// <summary>
    /// FloatProperty: CharacterUsageTime
    /// </summary>
    public unsafe float CharacterUsageTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6552); }
    }

    /// <summary>
    /// ArrayProperty: OverrideStealthTakedown
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> OverrideStealthTakedown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 6556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6556); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: OverrideStealthTakedownTemplates
    /// </summary>
    public InlineArray<BmSDK.BmGame.RStealthTakeDownStage> OverrideStealthTakedownTemplates => new(39, Ptr + 6568, 4, this);

    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6568); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6572); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6576); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6580); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6584); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6588); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6592); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6596); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6600); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6604); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6608); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6612); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6616); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6620); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6624); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6628); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6632); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6636); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6640); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6644); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6648); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6652); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6656); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6660); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6664); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6668); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6672); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6676); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6680); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6684); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6688); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6692); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6696); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6700); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6704); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6708); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6712); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6716); }
    }
    /// <summary>
    /// ObjectProperty: OverrideStealthTakedownTemplates
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage OverrideStealthTakedownTemplates_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage>(Ptr + 6720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6720); }
    }

    /// <summary>
    /// FloatProperty: DefrostTimer
    /// </summary>
    public unsafe float DefrostTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6724); }
    }

    /// <summary>
    /// FloatProperty: DefrostTime
    /// </summary>
    public unsafe float DefrostTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6728); }
    }

    /// <summary>
    /// ComponentProperty: IceSphere
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent IceSphere
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6732); }
    }

    /// <summary>
    /// ObjectProperty: FrozenPSTemplate
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem FrozenPSTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 6736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6736); }
    }

    /// <summary>
    /// StructProperty: LastFiringData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FGadgetFiringData LastFiringData
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FGadgetFiringData>(Ptr + 6740);

    /// <summary>
    /// FloatProperty: FireTraceLength
    /// </summary>
    public unsafe float FireTraceLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6772); }
    }

    /// <summary>
    /// StrProperty: ImpactPhysMat
    /// </summary>
    public unsafe BmSDK.FString ImpactPhysMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6776); }
    }

    /// <summary>
    /// ObjectProperty: LastHitPlayer
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer LastHitPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 6788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6788); }
    }

    /// <summary>
    /// StructProperty: LastSpecialMove
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FLastSpecialMoveData LastSpecialMove
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FLastSpecialMoveData>(Ptr + 6792);

    /// <summary>
    /// FloatProperty: HealthRegenBoostReciprocal
    /// </summary>
    public unsafe float HealthRegenBoostReciprocal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6808); }
    }

    /// <summary>
    /// ComponentProperty: HealthRegenEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent HealthRegenEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6812); }
    }

    /// <summary>
    /// ComponentProperty: PoisonEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent PoisonEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6816); }
    }

    /// <summary>
    /// ComponentProperty: PawnTaggedFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent PawnTaggedFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6820); }
    }

    /// <summary>
    /// ComponentProperty: ExplosionParticleFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ExplosionParticleFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6824); }
    }

    /// <summary>
    /// FloatProperty: AimAssistanceHeatValue
    /// </summary>
    public unsafe float AimAssistanceHeatValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6828); }
    }

    /// <summary>
    /// FloatProperty: AimAssistanceTimeOnScreen
    /// </summary>
    public unsafe float AimAssistanceTimeOnScreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6832); }
    }

    /// <summary>
    /// StructProperty: AimAssistanceBonePosScreenPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AimAssistanceBonePosScreenPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6836);

    /// <summary>
    /// StructProperty: AimAssistanceLastWorldPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AimAssistanceLastWorldPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6848);

    /// <summary>
    /// StructProperty: AimAssistanceWorldPosScreenPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AimAssistanceWorldPosScreenPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6860);

    /// <summary>
    /// StructProperty: AimAssistanceLastWorldPosScreenPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AimAssistanceLastWorldPosScreenPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6872);

    /// <summary>
    /// StructProperty: PawnPoisonState
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FSPoisoned PawnPoisonState
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FSPoisoned>(Ptr + 6884);

    /// <summary>
    /// StructProperty: PawnLockedOnState
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FSLauncherLockOn PawnLockedOnState
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FSLauncherLockOn>(Ptr + 6896);

    /// <summary>
    /// StructProperty: LockedOnHandle
    /// </summary>
    public unsafe ref BmSDK.Engine.AkWwise.FAkSoundHandle LockedOnHandle
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 6916);

    /// <summary>
    /// StructProperty: StartLockHandle
    /// </summary>
    public unsafe ref BmSDK.Engine.AkWwise.FAkSoundHandle StartLockHandle
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 6928);

    /// <summary>
    /// FloatProperty: LockedAudioEndTime
    /// </summary>
    public unsafe float LockedAudioEndTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6940); }
    }

    /// <summary>
    /// FloatProperty: PreviousLockValue
    /// </summary>
    public unsafe float PreviousLockValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6944); }
    }

    /// <summary>
    /// ArrayProperty: AssistingPlayers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPlayerRI> AssistingPlayers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPlayerRI>>(Ptr + 6948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6948); }
    }

    /// <summary>
    /// FloatProperty: TaggedToEnemiesEndTime
    /// </summary>
    public unsafe float TaggedToEnemiesEndTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6960); }
    }

    /// <summary>
    /// FloatProperty: LastDmgTime
    /// </summary>
    public unsafe float LastDmgTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6964); }
    }

    /// <summary>
    /// ObjectProperty: XRayBoneMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XRayBoneMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 6968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6968); }
    }

    /// <summary>
    /// ObjectProperty: XRayDangerBoneMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XRayDangerBoneMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 6972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6972); }
    }

    /// <summary>
    /// ObjectProperty: ThermalMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface ThermalMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 6976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6976); }
    }

    /// <summary>
    /// ObjectProperty: XRayBoneMaterialMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant XRayBoneMaterialMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 6980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6980); }
    }

    /// <summary>
    /// ObjectProperty: ThermalMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant ThermalMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 6984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6984); }
    }

    /// <summary>
    /// ObjectProperty: ActiveThermalMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant ActiveThermalMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 6988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6988); }
    }

    /// <summary>
    /// ComponentProperty: SkeletonMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent SkeletonMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 6992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6992); }
    }

    /// <summary>
    /// ObjectProperty: XraySkeleton
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh XraySkeleton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 6996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6996); }
    }

    /// <summary>
    /// FloatProperty: XRayVisibilityTimer
    /// </summary>
    public unsafe float XRayVisibilityTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7000); }
    }

    /// <summary>
    /// FloatProperty: XRayVisibilityFadeInStartTime
    /// </summary>
    public unsafe float XRayVisibilityFadeInStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7004); }
    }

    /// <summary>
    /// FloatProperty: XRayVisibilityFadeInDuration
    /// </summary>
    public unsafe float XRayVisibilityFadeInDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7008); }
    }

    /// <summary>
    /// FloatProperty: SavedXrayAlpha
    /// </summary>
    public unsafe float SavedXrayAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7012); }
    }

    /// <summary>
    /// FloatProperty: XRayAlphaSpeed
    /// </summary>
    public unsafe float XRayAlphaSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7016); }
    }

    /// <summary>
    /// ObjectProperty: OpacityHelper
    /// </summary>
    public unsafe BmSDK.BmGame.GDSkillToOpacityHelper OpacityHelper
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDSkillToOpacityHelper>(Ptr + 7020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7020); }
    }

    /// <summary>
    /// FloatProperty: XRayAlphaMinValue
    /// </summary>
    public unsafe float XRayAlphaMinValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7024); }
    }

    /// <summary>
    /// ObjectProperty: CachedTeam
    /// </summary>
    public unsafe BmSDK.BmGame.GDTeamInfo CachedTeam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.GDTeamInfo>(Ptr + 7028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7028); }
    }

    /// <summary>
    /// ArrayProperty: OnInvManagerReceivedDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> OnInvManagerReceivedDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 7032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7032); }
    }

    /// <summary>
    /// DelegateProperty: __OnInvManagerReceivedDelegate__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnInvManagerReceivedDelegate__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 7044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7044); }
    }
}

/// <summary>
/// The static native functions of RPawnPlayer, callable on an instance. A static native may read the object it runs on, and the static form runs it on the class default object, which has no world.
/// </summary>
public static class RPawnPlayerStatics
{
    private static BmSDK.Function __fn_GetInferredTransitionReference;
    /// <summary>
    /// Function: GetInferredTransitionReference, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static bool GetInferredTransitionReference(this BmSDK.BmGame.RPawnPlayer self, BmSDK.BmGame.RPawnCharacter Pawn, BmSDK.Engine.SkeletalMeshComponent SkelComp, out System.Numerics.Vector3 InferredReferencePointPosition, out BmSDK.Rotator InferredReferencePointRotation)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInferredTransitionReference, "BmGame.RPawnPlayer.GetInferredTransitionReference");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelComp, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out InferredReferencePointPosition);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InferredReferencePointPosition, paramsPtr + 8);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out InferredReferencePointRotation);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InferredReferencePointRotation, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        InferredReferencePointPosition = BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
        InferredReferencePointRotation = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Rotator>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 32);
    }

    private static BmSDK.Function __fn_PointInTriangle2D;
    /// <summary>
    /// Function: PointInTriangle2D, run on <paramref name="self"/> rather than the class default object
    /// </summary>
    public unsafe static bool PointInTriangle2D(this BmSDK.BmGame.RPawnPlayer self, System.Numerics.Vector3 Point, System.Numerics.Vector3 Vert0, System.Numerics.Vector3 Vert1, System.Numerics.Vector3 Vert2)
    {
        BmSDK.Framework.Guard.NotDestroyed(self);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PointInTriangle2D, "BmGame.RPawnPlayer.PointInTriangle2D");
        byte* paramsPtr = stackalloc byte[68];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Point, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Vert0, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Vert1, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Vert2, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(self.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 48);
    }
}
