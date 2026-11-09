#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnPlayer<br/>
/// (size = 6332)
/// (flags = 144703670)
/// </summary>
public partial class RPawnPlayer : BmSDK.BmGame.RPawnPlayerCombat, BmSDK.BmGame.RBatarangableInterface, BmSDK.BmGame.RSpotableInterface, BmSDK.IGameObject
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

    private static BmSDK.Function __fn_GetFakeMultiTargetBatarangGadget;
    /// <summary>
    /// Function: GetFakeMultiTargetBatarangGadget
    /// </summary>
    public unsafe virtual void GetFakeMultiTargetBatarangGadget(BmSDK.Class GadgetClass)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetFakeMultiTargetBatarangGadget, "BmGame.RPawnPlayer.GetFakeMultiTargetBatarangGadget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DestroyFakeMultiTargetBatarangGadget;
    /// <summary>
    /// Function: DestroyFakeMultiTargetBatarangGadget
    /// </summary>
    public unsafe virtual void DestroyFakeMultiTargetBatarangGadget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DestroyFakeMultiTargetBatarangGadget, "BmGame.RPawnPlayer.DestroyFakeMultiTargetBatarangGadget");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NotifyStartRound;
    /// <summary>
    /// Function: NotifyStartRound
    /// </summary>
    public unsafe virtual void NotifyStartRound(int Round)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyStartRound, "BmGame.RPawnPlayer.NotifyStartRound");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Round, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetSpeechThoughts;
    /// <summary>
    /// Function: GetSpeechThoughts
    /// </summary>
    public unsafe virtual void GetSpeechThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetSpeechThoughts, "BmGame.RPawnPlayer.GetSpeechThoughts");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
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

    private static BmSDK.Function __fn_CheckForExistingCreatedRafts;
    /// <summary>
    /// Function: CheckForExistingCreatedRafts
    /// </summary>
    public unsafe virtual bool CheckForExistingCreatedRafts()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForExistingCreatedRafts, "BmGame.RPawnPlayer.CheckForExistingCreatedRafts");
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

    private static BmSDK.Function __fn_OnRoomChange;
    /// <summary>
    /// Function: OnRoomChange
    /// </summary>
    public unsafe virtual void OnRoomChange()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OnRoomChange, "BmGame.RPawnPlayer.OnRoomChange");
        byte* paramsPtr = stackalloc byte[32];
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

    private static BmSDK.Function __fn_SpawnStartle;
    /// <summary>
    /// Function: SpawnStartle
    /// </summary>
    public unsafe virtual void SpawnStartle(BmSDK.BmGame.RPawnVillain TargetPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnStartle, "BmGame.RPawnPlayer.SpawnStartle");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerPredatorTerrifiedInterrogationMove;
    /// <summary>
    /// Function: TriggerPredatorTerrifiedInterrogationMove
    /// </summary>
    public unsafe virtual void TriggerPredatorTerrifiedInterrogationMove(BmSDK.BmGame.RPawnVillain Target, BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerPredatorTerrifiedInterrogationMove, "BmGame.RPawnPlayer.TriggerPredatorTerrifiedInterrogationMove");
        byte* paramsPtr = stackalloc byte[292];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerInterrogationMove;
    /// <summary>
    /// Function: TriggerInterrogationMove
    /// </summary>
    public unsafe virtual void TriggerInterrogationMove(BmSDK.BmGame.RPawnVillain Target, BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerInterrogationMove, "BmGame.RPawnPlayer.TriggerInterrogationMove");
        byte* paramsPtr = stackalloc byte[300];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckSpaceForFloorInterrogation;
    /// <summary>
    /// Function: CheckSpaceForFloorInterrogation
    /// </summary>
    public unsafe virtual bool CheckSpaceForFloorInterrogation(BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc, BmSDK.BmGame.RPawnVillain Target, bool bDebugDraw = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckSpaceForFloorInterrogation, "BmGame.RPawnPlayer.CheckSpaceForFloorInterrogation");
        byte* paramsPtr = stackalloc byte[140];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 112);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 116);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 120);
    }

    private static BmSDK.Function __fn_CheckForRagdolls;
    /// <summary>
    /// Function: CheckForRagdolls
    /// </summary>
    public unsafe virtual bool CheckForRagdolls(System.Numerics.Vector3 CheckStart, System.Numerics.Vector3 CheckEnd, float Radius, BmSDK.BmGame.RPawnVillain Target, bool bDebugDraw = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckForRagdolls, "BmGame.RPawnPlayer.CheckForRagdolls");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckStart, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckEnd, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 32);
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

    private static BmSDK.Function __fn_SetupPlayerMesh;
    /// <summary>
    /// Function: SetupPlayerMesh
    /// </summary>
    public unsafe virtual void SetupPlayerMesh(bool InPlay)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetupPlayerMesh, "BmGame.RPawnPlayer.SetupPlayerMesh");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
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
    public unsafe virtual void ApplyMeshData(BmSDK.BmGame.RAddContentPlayerCharacterMesh MeshData, bool InPlay)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ApplyMeshData, "BmGame.RPawnPlayer.ApplyMeshData");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeshData, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPlay, paramsPtr + 4);
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
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out MeshData);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeshData, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
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

    private static BmSDK.Function __fn_AllowInteractableItem;
    /// <summary>
    /// Function: AllowInteractableItem
    /// </summary>
    public unsafe virtual bool AllowInteractableItem(BmSDK.BmGame.RInteractableItem InteractableItem)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllowInteractableItem, "BmGame.RPawnPlayer.AllowInteractableItem");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InteractableItem, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
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

    private static BmSDK.Function __fn_UpdateExtraAmmoUpgrade;
    /// <summary>
    /// Function: UpdateExtraAmmoUpgrade
    /// </summary>
    public unsafe virtual void UpdateExtraAmmoUpgrade()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateExtraAmmoUpgrade, "BmGame.RPawnPlayer.UpdateExtraAmmoUpgrade");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayFirstNetworkNode;
    /// <summary>
    /// Function: PlayFirstNetworkNode
    /// </summary>
    public unsafe virtual void PlayFirstNetworkNode()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFirstNetworkNode, "BmGame.RPawnPlayer.PlayFirstNetworkNode");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayFirstDatapack;
    /// <summary>
    /// Function: PlayFirstDatapack
    /// </summary>
    public unsafe virtual void PlayFirstDatapack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayFirstDatapack, "BmGame.RPawnPlayer.PlayFirstDatapack");
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
    public unsafe virtual void GiveUnlockableGadget(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility UnlockName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GiveUnlockableGadget, "BmGame.RPawnPlayer.GiveUnlockableGadget");
        byte* paramsPtr = stackalloc byte[17];
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
    public unsafe virtual void NotifyGadgetEquip(bool equip)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NotifyGadgetEquip, "BmGame.RPawnPlayer.NotifyGadgetEquip");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(equip, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ThrowFatalBatarang;
    /// <summary>
    /// Function: ThrowFatalBatarang
    /// </summary>
    public unsafe virtual void ThrowFatalBatarang(BmSDK.BmGame.RPawnVillain Victim, System.Numerics.Vector3 TargetLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ThrowFatalBatarang, "BmGame.RPawnPlayer.ThrowFatalBatarang");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 4);
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
        byte* paramsPtr = stackalloc byte[28];
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

    private static BmSDK.Function __fn_PounceOnThug;
    /// <summary>
    /// Function: PounceOnThug
    /// </summary>
    public unsafe virtual void PounceOnThug(BmSDK.BmGame.RPawnVillain Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PounceOnThug, "BmGame.RPawnPlayer.PounceOnThug");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
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

    private static BmSDK.Function __fn_TriggerPickPocketing;
    /// <summary>
    /// Function: TriggerPickPocketing
    /// </summary>
    public unsafe virtual void TriggerPickPocketing(BmSDK.BmGame.RPawnVillain Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerPickPocketing, "BmGame.RPawnPlayer.TriggerPickPocketing");
        byte* paramsPtr = stackalloc byte[144];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StopZipLineHandle;
    /// <summary>
    /// Function: StopZipLineHandle
    /// </summary>
    public unsafe virtual void StopZipLineHandle()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StopZipLineHandle, "BmGame.RPawnPlayer.StopZipLineHandle");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_StartZipLineHandle;
    /// <summary>
    /// Function: StartZipLineHandle
    /// </summary>
    public unsafe virtual void StartZipLineHandle()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_StartZipLineHandle, "BmGame.RPawnPlayer.StartZipLineHandle");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnequipZipLineHandle;
    /// <summary>
    /// Function: UnequipZipLineHandle
    /// </summary>
    public unsafe virtual void UnequipZipLineHandle()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnequipZipLineHandle, "BmGame.RPawnPlayer.UnequipZipLineHandle");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EquipZipLineHandle;
    /// <summary>
    /// Function: EquipZipLineHandle
    /// </summary>
    public unsafe virtual void EquipZipLineHandle()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EquipZipLineHandle, "BmGame.RPawnPlayer.EquipZipLineHandle");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EquipZipLineHook;
    /// <summary>
    /// Function: EquipZipLineHook
    /// </summary>
    public unsafe virtual void EquipZipLineHook()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EquipZipLineHook, "BmGame.RPawnPlayer.EquipZipLineHook");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnequipZipLineHook;
    /// <summary>
    /// Function: UnequipZipLineHook
    /// </summary>
    public unsafe virtual void UnequipZipLineHook()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnequipZipLineHook, "BmGame.RPawnPlayer.UnequipZipLineHook");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
    public unsafe virtual void ServerTriggerSpecialMoveFromClient(BmSDK.BmGame.RSpecialMoveConfig SpecMove, BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerTriggerSpecialMoveFromClient, "BmGame.RPawnPlayer.ServerTriggerSpecialMoveFromClient");
        byte* paramsPtr = stackalloc byte[132];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClientTriggerSpecialMoveFromServer;
    /// <summary>
    /// Function: ClientTriggerSpecialMoveFromServer
    /// </summary>
    public unsafe virtual void ClientTriggerSpecialMoveFromServer(BmSDK.BmGame.RSpecialMoveConfig SpecMove, BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc, bool ForceOnClient)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClientTriggerSpecialMoveFromServer, "BmGame.RPawnPlayer.ClientTriggerSpecialMoveFromServer");
        byte* paramsPtr = stackalloc byte[136];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceOnClient, paramsPtr + 116);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
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

    private static BmSDK.Function __fn_DrawDebugBarrier;
    /// <summary>
    /// Function: DrawDebugBarrier
    /// </summary>
    public unsafe virtual void DrawDebugBarrier()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugBarrier, "BmGame.RPawnPlayer.DrawDebugBarrier");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawDebugBarrierHelper;
    /// <summary>
    /// Function: DrawDebugBarrierHelper
    /// </summary>
    public unsafe virtual void DrawDebugBarrierHelper(BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Barrier, BmSDK.FString OutputName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawDebugBarrierHelper, "BmGame.RPawnPlayer.DrawDebugBarrierHelper");
        byte* paramsPtr = stackalloc byte[140];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Barrier, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutputName, paramsPtr + 112);
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

    private static BmSDK.Function __fn_V2PredTriggerSpotted;
    /// <summary>
    /// Function: V2PredTriggerSpotted
    /// </summary>
    public unsafe virtual void V2PredTriggerSpotted(BmSDK.BmGame.RBMAIController Spotter)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_V2PredTriggerSpotted, "BmGame.RPawnPlayer.V2PredTriggerSpotted");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Spotter, paramsPtr + 0);
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
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FTransitionId PlayReplicatedRelativeTransitionEx(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, System.Numerics.Vector3 TransitionTargetPosition, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default, bool bReplicateToServer = default)
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 144);
    }

    private static BmSDK.Function __fn_PlayReplicatedRelativeTransition;
    /// <summary>
    /// Function: PlayReplicatedRelativeTransition
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FTransitionId PlayReplicatedRelativeTransition(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, System.Numerics.Vector3 TransitionTargetPosition, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default, bool bReplicateToServer = default)
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 144);
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
    public unsafe virtual BmSDK.BmGame.RAnimUtil.FTransitionId PlayReplicatedRelativeTransitionRotationOnly(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default, bool bReplicateToServer = default)
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RAnimUtil.FTransitionId>(paramsPtr + 132);
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

    private static BmSDK.Function __fn_GetThoughtsNative;
    /// <summary>
    /// Function: GetThoughtsNative
    /// </summary>
    public unsafe virtual void GetThoughtsNative(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetThoughtsNative, "BmGame.RPawnPlayer.GetThoughtsNative");
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
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    private static BmSDK.Function __fn_AddThought;
    /// <summary>
    /// Function: AddThought
    /// </summary>
    public unsafe virtual void AddThought(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList, BmSDK.FString ThoughtText, int R = default, int G = default, int B = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddThought, "BmGame.RPawnPlayer.AddThought");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThoughtText, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(R, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(G, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
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

    private static BmSDK.Function __fn_TakeDamage;
    /// <summary>
    /// Function: TakeDamage
    /// </summary>
    public unsafe override void TakeDamage(int Damage, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TakeDamage, "BmGame.RPawnPlayer.TakeDamage");
        byte* paramsPtr = stackalloc byte[128];
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
        byte* paramsPtr = stackalloc byte[280];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RangedDmgType, paramsPtr + 256);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 260);
    }

    private static BmSDK.Function __fn_ShotBy;
    /// <summary>
    /// Function: ShotBy
    /// </summary>
    public unsafe virtual void ShotBy(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo, System.Numerics.Vector3 HitLocation = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShotBy, "BmGame.RPawnPlayer.ShotBy");
        byte* paramsPtr = stackalloc byte[300];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 256);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
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

    private static BmSDK.Function __fn_ExperienceAwarded;
    /// <summary>
    /// Function: ExperienceAwarded
    /// </summary>
    public unsafe virtual void ExperienceAwarded(int XPAwarded)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExperienceAwarded, "BmGame.RPawnPlayer.ExperienceAwarded");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPAwarded, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetXpSequenceAkEventClass;
    /// <summary>
    /// Function: GetXpSequenceAkEventClass
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetXpSequenceAkEventClass()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetXpSequenceAkEventClass, "BmGame.RPawnPlayer.GetXpSequenceAkEventClass");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetXpSequenceClass;
    /// <summary>
    /// Function: GetXpSequenceClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetXpSequenceClass(int XPAwarded, BmSDK.Engine.Actor XPTarget, BmSDK.BmGame.RGameInfo.EGameAction Type)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetXpSequenceClass, "BmGame.RPawnPlayer.GetXpSequenceClass");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPAwarded, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPTarget, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 12);
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

    private static BmSDK.Function __fn_DebugGiveSonicBatarang;
    /// <summary>
    /// Function: DebugGiveSonicBatarang
    /// </summary>
    public unsafe virtual void DebugGiveSonicBatarang()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugGiveSonicBatarang, "BmGame.RPawnPlayer.DebugGiveSonicBatarang");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugGiveSmokeBomb;
    /// <summary>
    /// Function: DebugGiveSmokeBomb
    /// </summary>
    public unsafe virtual void DebugGiveSmokeBomb()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugGiveSmokeBomb, "BmGame.RPawnPlayer.DebugGiveSmokeBomb");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugGiveShockGloves;
    /// <summary>
    /// Function: DebugGiveShockGloves
    /// </summary>
    public unsafe virtual void DebugGiveShockGloves()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugGiveShockGloves, "BmGame.RPawnPlayer.DebugGiveShockGloves");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugGiveWeaponDisruptor;
    /// <summary>
    /// Function: DebugGiveWeaponDisruptor
    /// </summary>
    public unsafe virtual void DebugGiveWeaponDisruptor()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugGiveWeaponDisruptor, "BmGame.RPawnPlayer.DebugGiveWeaponDisruptor");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugGiveStunGrenade;
    /// <summary>
    /// Function: DebugGiveStunGrenade
    /// </summary>
    public unsafe virtual void DebugGiveStunGrenade()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugGiveStunGrenade, "BmGame.RPawnPlayer.DebugGiveStunGrenade");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugGiveGlueGrenade;
    /// <summary>
    /// Function: DebugGiveGlueGrenade
    /// </summary>
    public unsafe virtual void DebugGiveGlueGrenade()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugGiveGlueGrenade, "BmGame.RPawnPlayer.DebugGiveGlueGrenade");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugUpgradeDualClaw;
    /// <summary>
    /// Function: DebugUpgradeDualClaw
    /// </summary>
    public unsafe virtual void DebugUpgradeDualClaw(int NewUpgradeLevel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugUpgradeDualClaw, "BmGame.RPawnPlayer.DebugUpgradeDualClaw");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewUpgradeLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugGiveMultiTargetBatarang;
    /// <summary>
    /// Function: DebugGiveMultiTargetBatarang
    /// </summary>
    public unsafe virtual void DebugGiveMultiTargetBatarang()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugGiveMultiTargetBatarang, "BmGame.RPawnPlayer.DebugGiveMultiTargetBatarang");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DebugGiveDualClaw;
    /// <summary>
    /// Function: DebugGiveDualClaw
    /// </summary>
    public unsafe virtual void DebugGiveDualClaw()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugGiveDualClaw, "BmGame.RPawnPlayer.DebugGiveDualClaw");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
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

    private static BmSDK.Function __fn_ReplaceGadget;
    /// <summary>
    /// Function: ReplaceGadget
    /// </summary>
    public unsafe virtual void ReplaceGadget(BmSDK.FName current_gadget, BmSDK.FName new_gadget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplaceGadget, "BmGame.RPawnPlayer.ReplaceGadget");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(current_gadget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(new_gadget, paramsPtr + 8);
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
        byte* paramsPtr = stackalloc byte[92];
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
        byte* paramsPtr = stackalloc byte[80];
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

    private static BmSDK.Function __fn_IndirectAwareness_UpdateData;
    /// <summary>
    /// Function: IndirectAwareness_UpdateData
    /// </summary>
    public unsafe virtual void IndirectAwareness_UpdateData(System.Numerics.Vector3 AlertLoc, float BackDateTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IndirectAwareness_UpdateData, "BmGame.RPawnPlayer.IndirectAwareness_UpdateData");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AlertLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BackDateTime, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DrawLastSeenDebugVis;
    /// <summary>
    /// Function: DrawLastSeenDebugVis
    /// </summary>
    public unsafe virtual void DrawLastSeenDebugVis()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawLastSeenDebugVis, "BmGame.RPawnPlayer.DrawLastSeenDebugVis");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasBeenSeen_UpdateData;
    /// <summary>
    /// Function: HasBeenSeen_UpdateData
    /// </summary>
    public unsafe virtual void HasBeenSeen_UpdateData()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasBeenSeen_UpdateData, "BmGame.RPawnPlayer.HasBeenSeen_UpdateData");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
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
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
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

    private static BmSDK.Function __fn_ScriptCheckVisibility;
    /// <summary>
    /// Function: ScriptCheckVisibility
    /// </summary>
    public unsafe virtual bool ScriptCheckVisibility(BmSDK.BmGame.RBMAIController TestController)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ScriptCheckVisibility, "BmGame.RPawnPlayer.ScriptCheckVisibility");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestController, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetOpenTowerDoorOutsideMove;
    /// <summary>
    /// Function: GetOpenTowerDoorOutsideMove
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RSpecialMoveConfig GetOpenTowerDoorOutsideMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOpenTowerDoorOutsideMove, "BmGame.RPawnPlayer.GetOpenTowerDoorOutsideMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetOpenGrateOutsideMove;
    /// <summary>
    /// Function: GetOpenGrateOutsideMove
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RSpecialMoveConfig GetOpenGrateOutsideMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOpenGrateOutsideMove, "BmGame.RPawnPlayer.GetOpenGrateOutsideMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetOpenGrateInsideMove;
    /// <summary>
    /// Function: GetOpenGrateInsideMove
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RSpecialMoveConfig GetOpenGrateInsideMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetOpenGrateInsideMove, "BmGame.RPawnPlayer.GetOpenGrateInsideMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 0);
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
    public unsafe virtual void CheckSurroundingEnvironment(float CollisionHeight, float CollisionRadius, float DeltaTime, BmSDK.Engine.PrimitiveComponent HintPrimitive = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckSurroundingEnvironment, "BmGame.RPawnPlayer.CheckSurroundingEnvironment");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionHeight, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionRadius, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HintPrimitive, paramsPtr + 12);
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

    private static BmSDK.Function __fn_ServerChangeAttachedGadget;
    /// <summary>
    /// Function: ServerChangeAttachedGadget
    /// </summary>
    public unsafe virtual void ServerChangeAttachedGadget(BmSDK.Class NewAttachedGadget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ServerChangeAttachedGadget, "BmGame.RPawnPlayer.ServerChangeAttachedGadget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttachedGadget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NetworkTick;
    /// <summary>
    /// Function: NetworkTick
    /// </summary>
    public unsafe virtual void NetworkTick(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NetworkTick, "BmGame.RPawnPlayer.NetworkTick");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ChangeIdlePose;
    /// <summary>
    /// Function: ChangeIdlePose
    /// </summary>
    public unsafe virtual void ChangeIdlePose(BmSDK.BmGame.RPawnPlayer.EBatmanPoseType nextIdlePose)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ChangeIdlePose, "BmGame.RPawnPlayer.ChangeIdlePose");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nextIdlePose, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetRandomCombatIdleAnim;
    /// <summary>
    /// Function: SetRandomCombatIdleAnim
    /// </summary>
    public unsafe virtual void SetRandomCombatIdleAnim()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetRandomCombatIdleAnim, "BmGame.RPawnPlayer.SetRandomCombatIdleAnim");
        byte* paramsPtr = stackalloc byte[408];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsInCombatIdle;
    /// <summary>
    /// Function: IsInCombatIdle
    /// </summary>
    public unsafe virtual bool IsInCombatIdle()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInCombatIdle, "BmGame.RPawnPlayer.IsInCombatIdle");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UpdateIdleStance;
    /// <summary>
    /// Function: UpdateIdleStance
    /// </summary>
    public unsafe virtual void UpdateIdleStance()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateIdleStance, "BmGame.RPawnPlayer.UpdateIdleStance");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatMoveInitialised;
    /// <summary>
    /// Function: CombatMoveInitialised
    /// </summary>
    public unsafe override void CombatMoveInitialised(BmSDK.BmGame.RCombatMove NewMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatMoveInitialised, "BmGame.RPawnPlayer.CombatMoveInitialised");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldUseCombatIdle;
    /// <summary>
    /// Function: ShouldUseCombatIdle
    /// </summary>
    public unsafe virtual bool ShouldUseCombatIdle()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldUseCombatIdle, "BmGame.RPawnPlayer.ShouldUseCombatIdle");
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
        byte* paramsPtr = stackalloc byte[24];
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

    private static BmSDK.Function __fn_DrawHUD;
    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe override void DrawHUD(BmSDK.Engine.HUD H)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DrawHUD, "BmGame.RPawnPlayer.DrawHUD");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
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
        byte* paramsPtr = stackalloc byte[92];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    private static BmSDK.Function __fn_SelectDeathTip;
    /// <summary>
    /// Function: SelectDeathTip
    /// </summary>
    public unsafe virtual void SelectDeathTip(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation, bool bKilledInCombat)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SelectDeathTip, "BmGame.RPawnPlayer.SelectDeathTip");
        byte* paramsPtr = stackalloc byte[100];
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
        byte* paramsPtr = stackalloc byte[48];
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
    public unsafe virtual bool FindAndPlayOverrideDeathAnim(BmSDK.Class DamageType, BmSDK.Engine.Controller Killer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindAndPlayOverrideDeathAnim, "BmGame.RPawnPlayer.FindAndPlayOverrideDeathAnim");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_ReplicateDied;
    /// <summary>
    /// Function: ReplicateDied
    /// </summary>
    public unsafe virtual void ReplicateDied(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation, BmSDK.Engine.Actor DmgCauser, System.Numerics.Vector3 DmgImpulse, BmSDK.FName DmgBoneName)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReplicateDied, "BmGame.RPawnPlayer.ReplicateDied");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgCauser, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgImpulse, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgBoneName, paramsPtr + 36);
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
    public unsafe virtual bool HasUpgrade(BmSDK.BmGame.MWayneTechUpgradeSystem.ECharacterAbility ability)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasUpgrade, "BmGame.RPawnPlayer.HasUpgrade");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ability, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
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
        byte* paramsPtr = stackalloc byte[76];
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
    public unsafe override bool MoveInDirection(System.Numerics.Vector3 Direction)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_MoveInDirection, "BmGame.RPawnPlayer.MoveInDirection");
        byte* paramsPtr = stackalloc byte[32];
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
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

    private static BmSDK.Function __fn_FindEmote;
    /// <summary>
    /// Function: FindEmote
    /// </summary>
    public unsafe virtual BmSDK.Engine.RDialogueLine FindEmote(BmSDK.BmGame.RAnimNotify_Emote.EEmoteType EmoteType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindEmote, "BmGame.RPawnPlayer.FindEmote");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EmoteType, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.RDialogueLine>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_LoadPlayerEmotes;
    /// <summary>
    /// Function: LoadPlayerEmotes
    /// </summary>
    public unsafe virtual void LoadPlayerEmotes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LoadPlayerEmotes, "BmGame.RPawnPlayer.LoadPlayerEmotes");
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

    private static BmSDK.Function __fn_InitPlayerEmotes;
    /// <summary>
    /// Function: InitPlayerEmotes
    /// </summary>
    public unsafe virtual void InitPlayerEmotes()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InitPlayerEmotes, "BmGame.RPawnPlayer.InitPlayerEmotes");
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

    private static BmSDK.Function __fn_PlayLandingFX;
    /// <summary>
    /// Function: PlayLandingFX
    /// </summary>
    public unsafe virtual void PlayLandingFX()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayLandingFX, "BmGame.RPawnPlayer.PlayLandingFX");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisplayDebug;
    /// <summary>
    /// Function: DisplayDebug
    /// </summary>
    public unsafe override void DisplayDebug(BmSDK.Engine.HUD HUD, out float out_YL, out float out_YPos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisplayDebug, "BmGame.RPawnPlayer.DisplayDebug");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HUD, paramsPtr + 0);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_YL);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_YL, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out out_YPos);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_YPos, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_YL = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 4);
        out_YPos = BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
        return;
    }

    private static BmSDK.Function __fn_CanDoWeaponDestroyWithoutUpgrade;
    /// <summary>
    /// Function: CanDoWeaponDestroyWithoutUpgrade
    /// </summary>
    public unsafe virtual bool CanDoWeaponDestroyWithoutUpgrade()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoWeaponDestroyWithoutUpgrade, "BmGame.RPawnPlayer.CanDoWeaponDestroyWithoutUpgrade");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_BeginTakeDown;
    /// <summary>
    /// Function: BeginTakeDown
    /// </summary>
    public unsafe virtual void BeginTakeDown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BeginTakeDown, "BmGame.RPawnPlayer.BeginTakeDown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ExitSuperCombo;
    /// <summary>
    /// Function: ExitSuperCombo
    /// </summary>
    public unsafe virtual void ExitSuperCombo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitSuperCombo, "BmGame.RPawnPlayer.ExitSuperCombo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnterSuperCombo;
    /// <summary>
    /// Function: EnterSuperCombo
    /// </summary>
    public unsafe virtual void EnterSuperCombo()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnterSuperCombo, "BmGame.RPawnPlayer.EnterSuperCombo");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SpawnTakedownAgainst;
    /// <summary>
    /// Function: SpawnTakedownAgainst
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RStealthTakeDownStage SpawnTakedownAgainst(BmSDK.BmGame.RPlayerController PC, BmSDK.BmGame.MStealthTakeDownStagePlayerConfig.EStealthTakeDownStages takedown, BmSDK.BmGame.RPawnVillain Victim)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SpawnTakedownAgainst, "BmGame.RPawnPlayer.SpawnTakedownAgainst");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takedown, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RStealthTakeDownStage>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_IsPlayerUnderTarget;
    /// <summary>
    /// Function: IsPlayerUnderTarget
    /// </summary>
    public unsafe virtual bool IsPlayerUnderTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsPlayerUnderTarget, "BmGame.RPawnPlayer.IsPlayerUnderTarget");
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

    private static BmSDK.Function __fn_CanDoAirBorneTakeDown;
    /// <summary>
    /// Function: CanDoAirBorneTakeDown
    /// </summary>
    public unsafe virtual bool CanDoAirBorneTakeDown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanDoAirBorneTakeDown, "BmGame.RPawnPlayer.CanDoAirBorneTakeDown");
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

    private static BmSDK.Function __fn_TriggerShadowStrike;
    /// <summary>
    /// Function: TriggerShadowStrike
    /// </summary>
    public unsafe virtual void TriggerShadowStrike()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerShadowStrike, "BmGame.RPawnPlayer.TriggerShadowStrike");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: EQuickGadgetType
    /// </summary>
    public enum EQuickGadgetType : byte
    {
        QGT_GadgetLT = 0,
        QGT_GadgetRT = 1,
        QGT_GadgetB = 2,
        QGT_GadgetX = 3,
        QGT_GadgetY = 4,
        QGT_GadgetA = 5,
        QGT_QuickGadgetTypeMAX = 6,
        QGT_MAX = 7,
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
        ORCT_ZipLineHook = 4,
        ORCT_GrapplePoint = 5,
        ORCT_MAX = 6,
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
    /// Enum: EBatmanPoseType
    /// </summary>
    public enum EBatmanPoseType : byte
    {
        EBPT_Standard = 0,
        EBPT_Combat = 1,
        EBPT_Max = 2,
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
        EFS_NoFeelers = 9,
        EFS_MAX = 10,
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
        ESMT_RailingEnd128 = 42,
        ESMT_Actor = 43,
        ESMT_GlassBehindActor = 44,
        ESMT_MAX = 45,
    }

    /// <summary>
    /// StructProperty: VfTable_IRSpotableInterface
    /// </summary>
    public unsafe System.IntPtr VfTable_IRSpotableInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2640); }
    }

    /// <summary>
    /// ClassProperty: DefaultAttackCoordinator
    /// </summary>
    public unsafe BmSDK.Class DefaultAttackCoordinator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 2644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2644); }
    }

    /// <summary>
    /// ClassProperty: DefaultSearchCoordinator
    /// </summary>
    public unsafe BmSDK.Class DefaultSearchCoordinator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 2648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2648); }
    }

    /// <summary>
    /// ObjectProperty: V2AttackCoord
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Attack_Base V2AttackCoord
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Attack_Base>(Ptr + 2652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2652); }
    }

    /// <summary>
    /// ObjectProperty: MostRecentThugToSeePlayer
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIController MostRecentThugToSeePlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIController>(Ptr + 2656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2656); }
    }

    /// <summary>
    /// StructProperty: LastSeenPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastSeenPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2660);

    /// <summary>
    /// FloatProperty: LastSeenTime
    /// </summary>
    public unsafe float LastSeenTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2672); }
    }

    /// <summary>
    /// BoolProperty: bWasOnRailing
    /// </summary>
    public unsafe bool bWasOnRailing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: bWasUsingVantage
    /// </summary>
    public unsafe bool bWasUsingVantage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: bWasVantageInverted
    /// </summary>
    public unsafe bool bWasVantageInverted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: bWasDoingSpecialMovePredictable
    /// </summary>
    public unsafe bool bWasDoingSpecialMovePredictable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: bWasInAir
    /// </summary>
    public unsafe bool bWasInAir
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: bWasDangling
    /// </summary>
    public unsafe bool bWasDangling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: bCheatTrackBMInVent
    /// </summary>
    public unsafe bool bCheatTrackBMInVent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: bWasOnCeiling
    /// </summary>
    public unsafe bool bWasOnCeiling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreNavMeshForAvoidance
    /// </summary>
    public unsafe bool bIgnoreNavMeshForAvoidance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: bWalkingOnWire
    /// </summary>
    public unsafe bool bWalkingOnWire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: bCanInterrogate
    /// </summary>
    public unsafe bool bCanInterrogate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: bForcePlayNextHitReaction
    /// </summary>
    public unsafe bool bForcePlayNextHitReaction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: DisableTaunts
    /// </summary>
    public unsafe bool DisableTaunts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: VelocityStateIdle
    /// </summary>
    public unsafe bool VelocityStateIdle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: CanUseSuperComboGadgets
    /// </summary>
    public unsafe bool CanUseSuperComboGadgets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: CanUseSuperComboMove
    /// </summary>
    public unsafe bool CanUseSuperComboMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: bReplenishHealth
    /// </summary>
    public unsafe bool bReplenishHealth
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: DeferedVelocitySet
    /// </summary>
    public unsafe bool DeferedVelocitySet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: IsGrappling
    /// </summary>
    public unsafe bool IsGrappling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: bGliding
    /// </summary>
    public unsafe bool bGliding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: IsLineLaunching
    /// </summary>
    public unsafe bool IsLineLaunching
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: CanPerchOnVantagePoints
    /// </summary>
    public unsafe bool CanPerchOnVantagePoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: IsSlidingUnderVolume
    /// </summary>
    public unsafe bool IsSlidingUnderVolume
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: bCapeGlideDisabledByIce
    /// </summary>
    public unsafe bool bCapeGlideDisabledByIce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: bDisableDoubleTakedownOnInformants
    /// </summary>
    public unsafe bool bDisableDoubleTakedownOnInformants
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: bSimulateLastThugIsInformant
    /// </summary>
    public unsafe bool bSimulateLastThugIsInformant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: bExitStealthOnGlide
    /// </summary>
    public unsafe bool bExitStealthOnGlide
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: bThugsHaveCommentedOnGrapple
    /// </summary>
    public unsafe bool bThugsHaveCommentedOnGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: StandingOffEdge
    /// </summary>
    public unsafe bool StandingOffEdge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: GoingToHangFromVantagePoint
    /// </summary>
    public unsafe bool GoingToHangFromVantagePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: ClimbingBackToVantagePoint
    /// </summary>
    public unsafe bool ClimbingBackToVantagePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: CheckingToDiveThroughWindows
    /// </summary>
    public unsafe bool CheckingToDiveThroughWindows
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2676); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2676); }
    }

    /// <summary>
    /// BoolProperty: CheckingSwingFloor
    /// </summary>
    public unsafe bool CheckingSwingFloor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysTrackForDamage
    /// </summary>
    public unsafe bool bAlwaysTrackForDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: RenderShockGloves
    /// </summary>
    public unsafe bool RenderShockGloves
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: GrapplingToVantagePoint
    /// </summary>
    public unsafe bool GrapplingToVantagePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: bAllowZoom
    /// </summary>
    public unsafe bool bAllowZoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: bEnableGrateExcluders
    /// </summary>
    public unsafe bool bEnableGrateExcluders
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: bGB3HostagesKilled
    /// </summary>
    public unsafe bool bGB3HostagesKilled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: bDoingAutonmousMovement
    /// </summary>
    public unsafe bool bDoingAutonmousMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: ShouldCrouchForReplication
    /// </summary>
    public unsafe bool ShouldCrouchForReplication
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: bHasJustMovedOntoGargoyle
    /// </summary>
    public unsafe bool bHasJustMovedOntoGargoyle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: bCanAvoidMines
    /// </summary>
    public unsafe bool bCanAvoidMines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: DoingUnderBarrierCheck
    /// </summary>
    public unsafe bool DoingUnderBarrierCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: bCheckNonBlockingCombatPawns
    /// </summary>
    public unsafe bool bCheckNonBlockingCombatPawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: bPawnCanGrateCrawl
    /// </summary>
    public unsafe bool bPawnCanGrateCrawl
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: bCanClimbToCeilingLedge
    /// </summary>
    public unsafe bool bCanClimbToCeilingLedge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: bCanClimbToCeilingFar
    /// </summary>
    public unsafe bool bCanClimbToCeilingFar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: bCanClimbToCatwalkFar
    /// </summary>
    public unsafe bool bCanClimbToCatwalkFar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: bCanPounceToCeiling
    /// </summary>
    public unsafe bool bCanPounceToCeiling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: bJumpedThisFrame
    /// </summary>
    public unsafe bool bJumpedThisFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: CanBeSpottedByAI
    /// </summary>
    public unsafe bool CanBeSpottedByAI
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: bPlayerIconPSActive
    /// </summary>
    public unsafe bool bPlayerIconPSActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: bDebugObstacleAvoidance
    /// </summary>
    public unsafe bool bDebugObstacleAvoidance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: bDebugNewCeilingMoves
    /// </summary>
    public unsafe bool bDebugNewCeilingMoves
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: bDebugGrateMoves
    /// </summary>
    public unsafe bool bDebugGrateMoves
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: bJumpFromWhipSwing
    /// </summary>
    public unsafe bool bJumpFromWhipSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: bAddedDefaultInventoryAfterInit
    /// </summary>
    public unsafe bool bAddedDefaultInventoryAfterInit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: bDebugForceCriticalLand
    /// </summary>
    public unsafe bool bDebugForceCriticalLand
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: bDebugShowLandRollCheck
    /// </summary>
    public unsafe bool bDebugShowLandRollCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: bSilentRunning
    /// </summary>
    public unsafe bool bSilentRunning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: bGrappleWake
    /// </summary>
    public unsafe bool bGrappleWake
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: bGrappleWakeEmitter
    /// </summary>
    public unsafe bool bGrappleWakeEmitter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: DelayUnderWaterCheck
    /// </summary>
    public unsafe bool DelayUnderWaterCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2680); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: bDebugInterrogationDetection
    /// </summary>
    public unsafe bool bDebugInterrogationDetection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2684) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2684); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2684); }
    }

    /// <summary>
    /// BoolProperty: bInterrogationIgnoreIsSafeCheck
    /// </summary>
    public unsafe bool bInterrogationIgnoreIsSafeCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2684) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2684); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2684); }
    }

    /// <summary>
    /// BoolProperty: bDrawRelativeAnimRefPoint
    /// </summary>
    public unsafe bool bDrawRelativeAnimRefPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2684) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2684); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2684); }
    }

    /// <summary>
    /// BoolProperty: bSimulateInterrogationMovesNotLoaded
    /// </summary>
    public unsafe bool bSimulateInterrogationMovesNotLoaded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2684) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2684); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2684); }
    }

    /// <summary>
    /// BoolProperty: bHealthModifierActive
    /// </summary>
    public unsafe bool bHealthModifierActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2684) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2684); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2684); }
    }

    /// <summary>
    /// BoolProperty: bDisableHostageTakingBarks
    /// </summary>
    public unsafe bool bDisableHostageTakingBarks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2684) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2684); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2684); }
    }

    /// <summary>
    /// BoolProperty: WasDamageProxyActive
    /// </summary>
    public unsafe bool WasDamageProxyActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2684) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2684); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2684); }
    }

    /// <summary>
    /// BoolProperty: WasUnderTarget
    /// </summary>
    public unsafe bool WasUnderTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2684) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2684); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2684); }
    }

    /// <summary>
    /// BoolProperty: IsFlashInvisible
    /// </summary>
    public unsafe bool IsFlashInvisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2684) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2684); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2684); }
    }

    /// <summary>
    /// StructProperty: WasOnRailingPointA
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WasOnRailingPointA
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2688);

    /// <summary>
    /// StructProperty: WasOnRailingPointB
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WasOnRailingPointB
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2700);

    /// <summary>
    /// ObjectProperty: LastSeenVantage
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint LastSeenVantage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 2712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2712); }
    }

    /// <summary>
    /// StructProperty: CachedLedgeRefPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CachedLedgeRefPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2716);

    /// <summary>
    /// StructProperty: CachedLedgeRefDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CachedLedgeRefDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2728);

    /// <summary>
    /// StructProperty: AggressiveLandLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AggressiveLandLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2740);

    /// <summary>
    /// ByteProperty: BarkAvailable
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIController.BarkType BarkAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIController.BarkType>(Ptr + 2752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2752); }
    }

    /// <summary>
    /// ByteProperty: FeelerState
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.EnvironmentFeelerState FeelerState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.EnvironmentFeelerState>(Ptr + 2753); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2753); }
    }

    /// <summary>
    /// ByteProperty: MovementSpeed
    /// </summary>
    public unsafe BmSDK.BmGame.RPoseConfig.EMovementSpeed MovementSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig.EMovementSpeed>(Ptr + 2754); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2754); }
    }

    /// <summary>
    /// ByteProperty: CurrentIdlePoseType
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.EBatmanPoseType CurrentIdlePoseType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.EBatmanPoseType>(Ptr + 2755); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2755); }
    }

    /// <summary>
    /// ByteProperty: NextIdlePoseType
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.EBatmanPoseType NextIdlePoseType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.EBatmanPoseType>(Ptr + 2756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2756); }
    }

    /// <summary>
    /// InlineArray{ByteProperty}: UpAllowSubClasses
    /// </summary>
    public InlineArray<byte> UpAllowSubClasses => new(8, Ptr + 2757, 1, this);

    /// <summary>
    /// ByteProperty: UpAllowSubClasses
    /// </summary>
    public unsafe byte UpAllowSubClasses_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2757); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2757); }
    }
    /// <summary>
    /// ByteProperty: UpAllowSubClasses
    /// </summary>
    public unsafe byte UpAllowSubClasses_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2758); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2758); }
    }
    /// <summary>
    /// ByteProperty: UpAllowSubClasses
    /// </summary>
    public unsafe byte UpAllowSubClasses_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2759); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2759); }
    }
    /// <summary>
    /// ByteProperty: UpAllowSubClasses
    /// </summary>
    public unsafe byte UpAllowSubClasses_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2760); }
    }
    /// <summary>
    /// ByteProperty: UpAllowSubClasses
    /// </summary>
    public unsafe byte UpAllowSubClasses_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2761); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2761); }
    }
    /// <summary>
    /// ByteProperty: UpAllowSubClasses
    /// </summary>
    public unsafe byte UpAllowSubClasses_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2762); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2762); }
    }
    /// <summary>
    /// ByteProperty: UpAllowSubClasses
    /// </summary>
    public unsafe byte UpAllowSubClasses_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2763); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2763); }
    }
    /// <summary>
    /// ByteProperty: UpAllowSubClasses
    /// </summary>
    public unsafe byte UpAllowSubClasses_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2764); }
    }

    /// <summary>
    /// InlineArray{ByteProperty}: DownAllowSubClasses
    /// </summary>
    public InlineArray<byte> DownAllowSubClasses => new(5, Ptr + 2765, 1, this);

    /// <summary>
    /// ByteProperty: DownAllowSubClasses
    /// </summary>
    public unsafe byte DownAllowSubClasses_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2765); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2765); }
    }
    /// <summary>
    /// ByteProperty: DownAllowSubClasses
    /// </summary>
    public unsafe byte DownAllowSubClasses_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2766); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2766); }
    }
    /// <summary>
    /// ByteProperty: DownAllowSubClasses
    /// </summary>
    public unsafe byte DownAllowSubClasses_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2767); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2767); }
    }
    /// <summary>
    /// ByteProperty: DownAllowSubClasses
    /// </summary>
    public unsafe byte DownAllowSubClasses_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2768); }
    }
    /// <summary>
    /// ByteProperty: DownAllowSubClasses
    /// </summary>
    public unsafe byte DownAllowSubClasses_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2769); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2769); }
    }

    /// <summary>
    /// ByteProperty: CurrentPerchDir
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.PerchDirection CurrentPerchDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.PerchDirection>(Ptr + 2770); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2770); }
    }

    /// <summary>
    /// FloatProperty: mCheatTrackBMInVentTimer
    /// </summary>
    public unsafe float mCheatTrackBMInVentTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2772); }
    }

    /// <summary>
    /// ObjectProperty: FakeMultiTargetBatarangForFreeFlowPowerGadgetUpgrade
    /// </summary>
    public unsafe BmSDK.BmGame.RBatarang FakeMultiTargetBatarangForFreeFlowPowerGadgetUpgrade
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatarang>(Ptr + 2776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2776); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideGravity
    /// </summary>
    public unsafe float CapeGlideGravity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2780); }
    }

    /// <summary>
    /// ObjectProperty: XrayMaskMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XrayMaskMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2784); }
    }

    /// <summary>
    /// ObjectProperty: XrayMaskMaterialCape
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XrayMaskMaterialCape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2788); }
    }

    /// <summary>
    /// ComponentProperty: XrayMaskBodyMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent XrayMaskBodyMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 2792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2792); }
    }

    /// <summary>
    /// ComponentProperty: XrayMaskHeadMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent XrayMaskHeadMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 2796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2796); }
    }

    /// <summary>
    /// ComponentProperty: XrayMaskCapeMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent XrayMaskCapeMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 2800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2800); }
    }

    /// <summary>
    /// ArrayProperty: SnowMaterials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> SnowMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 2804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2804); }
    }

    /// <summary>
    /// NameProperty: SnowParameterName
    /// </summary>
    public unsafe BmSDK.FName SnowParameterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2816); }
    }

    /// <summary>
    /// StructProperty: GrappleLoopSoundHandle
    /// </summary>
    public unsafe ref BmSDK.Engine.AkWwise.FAkSoundHandle GrappleLoopSoundHandle
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 2824);

    /// <summary>
    /// FloatProperty: VelocityTimeAtZero
    /// </summary>
    public unsafe float VelocityTimeAtZero
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2836); }
    }

    /// <summary>
    /// FloatProperty: PlayerWalkSpeed
    /// </summary>
    public unsafe float PlayerWalkSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2840); }
    }

    /// <summary>
    /// FloatProperty: PlayerRunSpeed
    /// </summary>
    public unsafe float PlayerRunSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2844); }
    }

    /// <summary>
    /// FloatProperty: PlayerStealthSpeed
    /// </summary>
    public unsafe float PlayerStealthSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2848); }
    }

    /// <summary>
    /// FloatProperty: PlayerGlideSpeed
    /// </summary>
    public unsafe float PlayerGlideSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2852); }
    }

    /// <summary>
    /// FloatProperty: PlayerChargeStrikeSpeedModifier
    /// </summary>
    public unsafe float PlayerChargeStrikeSpeedModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2856); }
    }

    /// <summary>
    /// ObjectProperty: GrappleGun
    /// </summary>
    public unsafe BmSDK.BmGame.RGrappleGun GrappleGun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrappleGun>(Ptr + 2860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2860); }
    }

    /// <summary>
    /// ObjectProperty: HarpoonGun
    /// </summary>
    public unsafe BmSDK.BmGame.RHarpoonGun HarpoonGun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHarpoonGun>(Ptr + 2864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2864); }
    }

    /// <summary>
    /// ObjectProperty: ResonatorTuner
    /// </summary>
    public unsafe BmSDK.BmGame.RResonatorTuner ResonatorTuner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RResonatorTuner>(Ptr + 2868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2868); }
    }

    /// <summary>
    /// ObjectProperty: LineLauncher
    /// </summary>
    public unsafe BmSDK.BmGame.RLineLauncher LineLauncher
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLineLauncher>(Ptr + 2872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2872); }
    }

    /// <summary>
    /// ObjectProperty: Batarang
    /// </summary>
    public unsafe BmSDK.BmGame.RBatarang Batarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatarang>(Ptr + 2876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2876); }
    }

    /// <summary>
    /// ObjectProperty: GooSpray
    /// </summary>
    public unsafe BmSDK.BmGame.RGooSpray GooSpray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGooSpray>(Ptr + 2880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2880); }
    }

    /// <summary>
    /// ObjectProperty: MagneticBlast
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticBlast MagneticBlast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticBlast>(Ptr + 2884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2884); }
    }

    /// <summary>
    /// ObjectProperty: GlueGrenade
    /// </summary>
    public unsafe BmSDK.BmGame.MSockGrenadeGadgetBase GlueGrenade
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MSockGrenadeGadgetBase>(Ptr + 2888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2888); }
    }

    /// <summary>
    /// ObjectProperty: DualClawGadget
    /// </summary>
    public unsafe BmSDK.BmGame.MDualClawBase DualClawGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MDualClawBase>(Ptr + 2892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2892); }
    }

    /// <summary>
    /// ObjectProperty: JammerGadget
    /// </summary>
    public unsafe BmSDK.BmGame.RJammerGadget JammerGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJammerGadget>(Ptr + 2896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2896); }
    }

    /// <summary>
    /// ObjectProperty: Caltrops
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectileGadgetBase Caltrops
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectileGadgetBase>(Ptr + 2900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2900); }
    }

    /// <summary>
    /// ObjectProperty: Staff
    /// </summary>
    public unsafe BmSDK.BmGame.RStaffBase Staff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStaffBase>(Ptr + 2904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2904); }
    }

    /// <summary>
    /// ObjectProperty: Sticks
    /// </summary>
    public unsafe BmSDK.BmGame.RSticksGadgetBase Sticks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSticksGadgetBase>(Ptr + 2908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2908); }
    }

    /// <summary>
    /// ObjectProperty: BlowDart
    /// </summary>
    public unsafe BmSDK.BmGame.RBlowDartBase BlowDart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBlowDartBase>(Ptr + 2912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2912); }
    }

    /// <summary>
    /// ObjectProperty: RCBatarang
    /// </summary>
    public unsafe BmSDK.BmGame.RBatarang RCBatarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatarang>(Ptr + 2916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2916); }
    }

    /// <summary>
    /// ObjectProperty: SonicBatarang
    /// </summary>
    public unsafe BmSDK.BmGame.RBatarang SonicBatarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatarang>(Ptr + 2920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2920); }
    }

    /// <summary>
    /// ObjectProperty: ShockGloves
    /// </summary>
    public unsafe BmSDK.BmGame.MShockGlovesBase ShockGloves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MShockGlovesBase>(Ptr + 2924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2924); }
    }

    /// <summary>
    /// ArrayProperty: IceRafts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RFloatingRaft> IceRafts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RFloatingRaft>>(Ptr + 2928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2928); }
    }

    /// <summary>
    /// FloatProperty: MaxIceRafts
    /// </summary>
    public unsafe float MaxIceRafts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2940); }
    }

    /// <summary>
    /// FloatProperty: GrappleSpeed
    /// </summary>
    public unsafe float GrappleSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2944); }
    }

    /// <summary>
    /// FloatProperty: MaxGrappleSpeed
    /// </summary>
    public unsafe float MaxGrappleSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2948); }
    }

    /// <summary>
    /// FloatProperty: MinGrappleSpeed
    /// </summary>
    public unsafe float MinGrappleSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2952); }
    }

    /// <summary>
    /// FloatProperty: MinGrappleSpeedDist
    /// </summary>
    public unsafe float MinGrappleSpeedDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2956); }
    }

    /// <summary>
    /// FloatProperty: MaxGrappleSpeedDist
    /// </summary>
    public unsafe float MaxGrappleSpeedDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2960); }
    }

    /// <summary>
    /// FloatProperty: GrappleDampingCoeff
    /// </summary>
    public unsafe float GrappleDampingCoeff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2964); }
    }

    /// <summary>
    /// FloatProperty: GrappleBoostFactor
    /// </summary>
    public unsafe float GrappleBoostFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2968); }
    }

    /// <summary>
    /// ArrayProperty: HealthUpgrades
    /// </summary>
    public unsafe BmSDK.TArray<int> HealthUpgrades
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2972); }
    }

    /// <summary>
    /// ArrayProperty: MeleeArmourUpgrades
    /// </summary>
    public unsafe BmSDK.TArray<int> MeleeArmourUpgrades
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2984); }
    }

    /// <summary>
    /// ArrayProperty: BallisticArmourUpgrades
    /// </summary>
    public unsafe BmSDK.TArray<int> BallisticArmourUpgrades
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2996); }
    }

    /// <summary>
    /// ArrayProperty: CurrentArmourLevels
    /// </summary>
    public unsafe BmSDK.TArray<int> CurrentArmourLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 3008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3008); }
    }

    /// <summary>
    /// ArrayProperty: CurrentArmourMaxima
    /// </summary>
    public unsafe BmSDK.TArray<int> CurrentArmourMaxima
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 3020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3020); }
    }

    /// <summary>
    /// FloatProperty: ReplenishRate
    /// </summary>
    public unsafe float ReplenishRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3032); }
    }

    /// <summary>
    /// FloatProperty: TimeBeforeReplenish
    /// </summary>
    public unsafe float TimeBeforeReplenish
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3036); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceDamage
    /// </summary>
    public unsafe float TimeSinceDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3040); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceReplenish
    /// </summary>
    public unsafe float TimeSinceReplenish
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3044); }
    }

    /// <summary>
    /// StructProperty: FrontBarrier
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator FrontBarrier
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(Ptr + 3048);

    /// <summary>
    /// StructProperty: UnderBarrier
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator UnderBarrier
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(Ptr + 3160);

    /// <summary>
    /// StructProperty: UpperBarrier
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator UpperBarrier
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(Ptr + 3272);

    /// <summary>
    /// StructProperty: LeftFeature
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator LeftFeature
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(Ptr + 3384);

    /// <summary>
    /// StructProperty: RightFeature
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator RightFeature
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(Ptr + 3496);

    /// <summary>
    /// StructProperty: UnderEdgeColl
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FPlayerEdgeColl UnderEdgeColl
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FPlayerEdgeColl>(Ptr + 3608);

    /// <summary>
    /// StructProperty: ShimmyEdgeColl
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FPlayerEdgeColl ShimmyEdgeColl
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FPlayerEdgeColl>(Ptr + 3620);

    /// <summary>
    /// StructProperty: CurrentRailing
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FRailingInfo CurrentRailing
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FRailingInfo>(Ptr + 3632);

    /// <summary>
    /// StructProperty: SecondRailing
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FRailingInfo SecondRailing
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FRailingInfo>(Ptr + 3656);

    /// <summary>
    /// InlineArray{ObjectProperty}: LandMoves
    /// </summary>
    public InlineArray<BmSDK.BmGame.RSpecialMoveConfig> LandMoves => new(6, Ptr + 3680, 4, this);

    /// <summary>
    /// ObjectProperty: LandMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LandMoves_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3680); }
    }
    /// <summary>
    /// ObjectProperty: LandMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LandMoves_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3684); }
    }
    /// <summary>
    /// ObjectProperty: LandMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LandMoves_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3688); }
    }
    /// <summary>
    /// ObjectProperty: LandMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LandMoves_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3692); }
    }
    /// <summary>
    /// ObjectProperty: LandMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LandMoves_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3696); }
    }
    /// <summary>
    /// ObjectProperty: LandMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LandMoves_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3700); }
    }

    /// <summary>
    /// ObjectProperty: RailingLandMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RailingLandMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3704); }
    }

    /// <summary>
    /// ObjectProperty: RailingLandWalkMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RailingLandWalkMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3708); }
    }

    /// <summary>
    /// ObjectProperty: DeepFallLandSuccess
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DeepFallLandSuccess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3712); }
    }

    /// <summary>
    /// ObjectProperty: DeepFallLandRunSuccess
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DeepFallLandRunSuccess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3716); }
    }

    /// <summary>
    /// ObjectProperty: DeepFallRailingLandSuccess
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DeepFallRailingLandSuccess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3720); }
    }

    /// <summary>
    /// ObjectProperty: DeepFallRailingWalkLandSuccess
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DeepFallRailingWalkLandSuccess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3724); }
    }

    /// <summary>
    /// ObjectProperty: CornerSlipMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CornerSlipMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3728); }
    }

    /// <summary>
    /// ObjectProperty: CornerSlipCrouchMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CornerSlipCrouchMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3732); }
    }

    /// <summary>
    /// FloatProperty: CriticalFallHeight
    /// </summary>
    public unsafe float CriticalFallHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3736); }
    }

    /// <summary>
    /// FloatProperty: CriticalFallHeightWarnTime
    /// </summary>
    public unsafe float CriticalFallHeightWarnTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3740); }
    }

    /// <summary>
    /// FloatProperty: MinCriticalFallSpeed
    /// </summary>
    public unsafe float MinCriticalFallSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3744); }
    }

    /// <summary>
    /// FloatProperty: MaxCriticalFallSpeed
    /// </summary>
    public unsafe float MaxCriticalFallSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3748); }
    }

    /// <summary>
    /// FloatProperty: MinCriticalFallDamage
    /// </summary>
    public unsafe float MinCriticalFallDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3752); }
    }

    /// <summary>
    /// FloatProperty: MaxCriticalFallDamage
    /// </summary>
    public unsafe float MaxCriticalFallDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3756); }
    }

    /// <summary>
    /// StructProperty: CriticalFallImpactLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CriticalFallImpactLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3760);

    /// <summary>
    /// ObjectProperty: SwingKickMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SwingKickMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3772); }
    }

    /// <summary>
    /// ObjectProperty: OverrideVantageSwingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig OverrideVantageSwingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3776); }
    }

    /// <summary>
    /// ObjectProperty: OverrideVantageLandMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig OverrideVantageLandMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3780); }
    }

    /// <summary>
    /// ObjectProperty: OverrideLampSwingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig OverrideLampSwingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3784); }
    }

    /// <summary>
    /// ObjectProperty: mPickPocketMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig mPickPocketMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3788); }
    }

    /// <summary>
    /// StructProperty: CoverDescription
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FCoverDescriptor CoverDescription
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FCoverDescriptor>(Ptr + 3792);

    /// <summary>
    /// StructProperty: StandMeshOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StandMeshOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3856);

    /// <summary>
    /// StructProperty: CrouchMeshOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CrouchMeshOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3868);

    /// <summary>
    /// ObjectProperty: PhotoScanner
    /// </summary>
    public unsafe BmSDK.BmGame.RPhotoScanner PhotoScanner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPhotoScanner>(Ptr + 3880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3880); }
    }

    /// <summary>
    /// ObjectProperty: PhysicsGrabber
    /// </summary>
    public unsafe BmSDK.BmGame.RPhysicsGrabber PhysicsGrabber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPhysicsGrabber>(Ptr + 3884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3884); }
    }

    /// <summary>
    /// ObjectProperty: MagicSmasher
    /// </summary>
    public unsafe BmSDK.BmGame.RMagicSmasher MagicSmasher
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagicSmasher>(Ptr + 3888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3888); }
    }

    /// <summary>
    /// ObjectProperty: MagicGunStartle
    /// </summary>
    public unsafe BmSDK.BmGame.RMagicGunStartle MagicGunStartle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagicGunStartle>(Ptr + 3892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3892); }
    }

    /// <summary>
    /// FloatProperty: MaxTurnDegreesPerSecond
    /// </summary>
    public unsafe float MaxTurnDegreesPerSecond
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3896); }
    }

    /// <summary>
    /// FloatProperty: GlideTurnDegreesPerSecond
    /// </summary>
    public unsafe float GlideTurnDegreesPerSecond
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3900); }
    }

    /// <summary>
    /// FloatProperty: WalkTurnDegreesPerSecond
    /// </summary>
    public unsafe float WalkTurnDegreesPerSecond
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3904); }
    }

    /// <summary>
    /// ObjectProperty: EvidenceLog
    /// </summary>
    public unsafe BmSDK.BmGame.REvidenceLog EvidenceLog
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REvidenceLog>(Ptr + 3908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3908); }
    }

    /// <summary>
    /// FloatProperty: OverrideTime
    /// </summary>
    public unsafe float OverrideTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3912); }
    }

    /// <summary>
    /// ObjectProperty: ExplosionEffect
    /// </summary>
    public unsafe BmSDK.BmGame.RExplosionPostProcess ExplosionEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RExplosionPostProcess>(Ptr + 3916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3916); }
    }

    /// <summary>
    /// StructProperty: OverridableTransition
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId OverridableTransition
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 3920);

    /// <summary>
    /// StructProperty: MovementDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MovementDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3924);

    /// <summary>
    /// StructProperty: PreCorrectionVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PreCorrectionVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3936);

    /// <summary>
    /// StructProperty: GadgetTransition
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId GadgetTransition
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 3948);

    /// <summary>
    /// FloatProperty: LastDeltaTime
    /// </summary>
    public unsafe float LastDeltaTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3952); }
    }

    /// <summary>
    /// StructProperty: DeferedVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DeferedVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3956);

    /// <summary>
    /// ArrayProperty: LOSCapeChecks
    /// </summary>
    public unsafe BmSDK.TArray<int> LOSCapeChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 3968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3968); }
    }

    /// <summary>
    /// ArrayProperty: CoverRightLOSCheckBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CoverRightLOSCheckBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 3980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3980); }
    }

    /// <summary>
    /// ArrayProperty: CoverLeftLOSCheckBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CoverLeftLOSCheckBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 3992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3992); }
    }

    /// <summary>
    /// ArrayProperty: HangingLOSCheckBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> HangingLOSCheckBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4004); }
    }

    /// <summary>
    /// ArrayProperty: BracedLOSCheckBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BracedLOSCheckBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4016); }
    }

    /// <summary>
    /// ArrayProperty: HangingLOSCapeChecks
    /// </summary>
    public unsafe BmSDK.TArray<int> HangingLOSCapeChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 4028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4028); }
    }

    /// <summary>
    /// FloatProperty: WallStopCosAngle
    /// </summary>
    public unsafe float WallStopCosAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4040); }
    }

    /// <summary>
    /// FloatProperty: WallStopCheckRadius
    /// </summary>
    public unsafe float WallStopCheckRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4044); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: ControllerHistory
    /// </summary>
    public InlineArray<BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory> ControllerHistory => new(10, Ptr + 4048, 20, this);

    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory ControllerHistory_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory>(Ptr + 4048);
    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory ControllerHistory_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory>(Ptr + 4068);
    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory ControllerHistory_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory>(Ptr + 4088);
    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory ControllerHistory_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory>(Ptr + 4108);
    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory ControllerHistory_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory>(Ptr + 4128);
    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory ControllerHistory_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory>(Ptr + 4148);
    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory ControllerHistory_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory>(Ptr + 4168);
    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory ControllerHistory_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory>(Ptr + 4188);
    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory ControllerHistory_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory>(Ptr + 4208);
    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory ControllerHistory_9
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory>(Ptr + 4228);

    /// <summary>
    /// IntProperty: ControllerHistoryPosition
    /// </summary>
    public unsafe int ControllerHistoryPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4248); }
    }

    /// <summary>
    /// IntProperty: ControllerHistoryMax
    /// </summary>
    public unsafe int ControllerHistoryMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4252); }
    }

    /// <summary>
    /// InterfaceProperty: PassThroughAdjustMovementDirection
    /// </summary>
    public unsafe BmSDK.BmGame.RPassThroughAdjustMovementDirectionInterface PassThroughAdjustMovementDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPassThroughAdjustMovementDirectionInterface>(Ptr + 4256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4256); }
    }

    /// <summary>
    /// FloatProperty: MinCapeGlideTanAngle
    /// </summary>
    public unsafe float MinCapeGlideTanAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4264); }
    }

    /// <summary>
    /// FloatProperty: MaxCapeGlideTanAngle
    /// </summary>
    public unsafe float MaxCapeGlideTanAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4268); }
    }

    /// <summary>
    /// FloatProperty: MaxPounceAttackTanAngle
    /// </summary>
    public unsafe float MaxPounceAttackTanAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4272); }
    }

    /// <summary>
    /// FloatProperty: GlideAttackRange
    /// </summary>
    public unsafe float GlideAttackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4276); }
    }

    /// <summary>
    /// FloatProperty: PounceAttackRange
    /// </summary>
    public unsafe float PounceAttackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4280); }
    }

    /// <summary>
    /// ArrayProperty: HealthRecoverRate
    /// </summary>
    public unsafe BmSDK.TArray<float> HealthRecoverRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 4284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4284); }
    }

    /// <summary>
    /// IntProperty: MaxHealth
    /// </summary>
    public unsafe int MaxHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4296); }
    }

    /// <summary>
    /// IntProperty: DeathCount
    /// </summary>
    public unsafe int DeathCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4300); }
    }

    /// <summary>
    /// ArrayProperty: FrontDamageOverlays
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> FrontDamageOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4304); }
    }

    /// <summary>
    /// ArrayProperty: FireDamageOverlays
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> FireDamageOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4316); }
    }

    /// <summary>
    /// ArrayProperty: BackDamageOverlays
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BackDamageOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4328); }
    }

    /// <summary>
    /// ArrayProperty: ElectricityDamageOverlays
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> ElectricityDamageOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4340); }
    }

    /// <summary>
    /// StructProperty: DamageOverlay
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId DamageOverlay
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(Ptr + 4352);

    /// <summary>
    /// FloatProperty: DesiredMovementScale
    /// </summary>
    public unsafe float DesiredMovementScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4360); }
    }

    /// <summary>
    /// FloatProperty: ActualMovementScale
    /// </summary>
    public unsafe float ActualMovementScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4364); }
    }

    /// <summary>
    /// FloatProperty: MovementScaleChangeSpeed
    /// </summary>
    public unsafe float MovementScaleChangeSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4368); }
    }

    /// <summary>
    /// FloatProperty: TunnelSpeedScale
    /// </summary>
    public unsafe float TunnelSpeedScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4372); }
    }

    /// <summary>
    /// FloatProperty: FirstPersonSpeedScale
    /// </summary>
    public unsafe float FirstPersonSpeedScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4376); }
    }

    /// <summary>
    /// StructProperty: StandingOffEdgeDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StandingOffEdgeDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4380);

    /// <summary>
    /// FloatProperty: ActualMovementSpeed
    /// </summary>
    public unsafe float ActualMovementSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4392); }
    }

    /// <summary>
    /// StructProperty: NetworkMoveVector
    /// </summary>
    public unsafe ref System.Numerics.Vector3 NetworkMoveVector
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4396);

    /// <summary>
    /// ObjectProperty: LastGadget
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget LastGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 4408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4408); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: PoseIdleStances
    /// </summary>
    public InlineArray<BmSDK.FName> PoseIdleStances => new(2, Ptr + 4412, 8, this);

    /// <summary>
    /// NameProperty: PoseIdleStances
    /// </summary>
    public unsafe BmSDK.FName PoseIdleStances_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4412); }
    }
    /// <summary>
    /// NameProperty: PoseIdleStances
    /// </summary>
    public unsafe BmSDK.FName PoseIdleStances_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4420); }
    }

    /// <summary>
    /// ClassProperty: AttachedGadget
    /// </summary>
    public unsafe BmSDK.Class AttachedGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4428); }
    }

    /// <summary>
    /// ObjectProperty: TakedownStageConfig
    /// </summary>
    public unsafe BmSDK.BmGame.MStealthTakeDownStagePlayerConfig TakedownStageConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MStealthTakeDownStagePlayerConfig>(Ptr + 4432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4432); }
    }

    /// <summary>
    /// InlineArray{ClassProperty}: TakeDowns
    /// </summary>
    public InlineArray<BmSDK.Class> TakeDowns => new(40, Ptr + 4436, 4, this);

    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4436); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4440); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4444); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4448); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4452); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4456); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4460); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4464); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4468); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4472); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4476); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4480); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4484); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4488); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4492); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4496); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4500); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4504); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4508); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4512); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4516); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4520); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4524); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4528); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4532); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4536); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4540); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4544); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4548); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4552); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4556); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4560); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4564); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4568); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4572); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4576); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4580); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4584); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4588); }
    }
    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4592); }
    }

    /// <summary>
    /// IntProperty: ProjectileLaunchId
    /// </summary>
    public unsafe int ProjectileLaunchId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4596); }
    }

    /// <summary>
    /// ObjectProperty: ActiveTunnelFunnel
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelFunnel ActiveTunnelFunnel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelFunnel>(Ptr + 4600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4600); }
    }

    /// <summary>
    /// ObjectProperty: NearestTunnelFunnel
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelFunnel NearestTunnelFunnel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelFunnel>(Ptr + 4604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4604); }
    }

    /// <summary>
    /// IntProperty: LastTakedownId
    /// </summary>
    public unsafe int LastTakedownId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4608); }
    }

    /// <summary>
    /// IntProperty: LastTakedownStageAnimId
    /// </summary>
    public unsafe int LastTakedownStageAnimId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4612); }
    }

    /// <summary>
    /// IntProperty: DamageResistance
    /// </summary>
    public unsafe int DamageResistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4616); }
    }

    /// <summary>
    /// IntProperty: DamageRemainder
    /// </summary>
    public unsafe int DamageRemainder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4620); }
    }

    /// <summary>
    /// ObjectProperty: PlayerDeathEmote
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine PlayerDeathEmote
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4624); }
    }

    /// <summary>
    /// StrProperty: EmotePackageString
    /// </summary>
    public unsafe BmSDK.FString EmotePackageString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4628); }
    }

    /// <summary>
    /// StrProperty: EmoteUGroupString
    /// </summary>
    public unsafe BmSDK.FString EmoteUGroupString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4640); }
    }

    /// <summary>
    /// ObjectProperty: GrateExcluder
    /// </summary>
    public unsafe BmSDK.Engine.RB_BodyInstance GrateExcluder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RB_BodyInstance>(Ptr + 4652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4652); }
    }

    /// <summary>
    /// ObjectProperty: LegGrateExcluder
    /// </summary>
    public unsafe BmSDK.Engine.RB_BodyInstance LegGrateExcluder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RB_BodyInstance>(Ptr + 4656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4656); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: SpawnedProjectiles
    /// </summary>
    public InlineArray<BmSDK.BmGame.RProjectile> SpawnedProjectiles => new(6, Ptr + 4660, 4, this);

    /// <summary>
    /// ObjectProperty: SpawnedProjectiles
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile SpawnedProjectiles_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 4660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4660); }
    }
    /// <summary>
    /// ObjectProperty: SpawnedProjectiles
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile SpawnedProjectiles_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 4664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4664); }
    }
    /// <summary>
    /// ObjectProperty: SpawnedProjectiles
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile SpawnedProjectiles_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 4668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4668); }
    }
    /// <summary>
    /// ObjectProperty: SpawnedProjectiles
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile SpawnedProjectiles_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 4672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4672); }
    }
    /// <summary>
    /// ObjectProperty: SpawnedProjectiles
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile SpawnedProjectiles_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 4676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4676); }
    }
    /// <summary>
    /// ObjectProperty: SpawnedProjectiles
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile SpawnedProjectiles_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 4680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4680); }
    }

    /// <summary>
    /// FloatProperty: DryPct
    /// </summary>
    public unsafe float DryPct
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4684); }
    }

    /// <summary>
    /// NameProperty: DesiredPoseForReplication
    /// </summary>
    public unsafe BmSDK.FName DesiredPoseForReplication
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4688); }
    }

    /// <summary>
    /// StructProperty: AimDirectionForReplication
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AimDirectionForReplication
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4696);

    /// <summary>
    /// IntProperty: PlayerIndex
    /// </summary>
    public unsafe int PlayerIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4708); }
    }

    /// <summary>
    /// StructProperty: FallingTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FallingTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4712);

    /// <summary>
    /// ObjectProperty: FallingTargetActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor FallingTargetActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 4724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4724); }
    }

    /// <summary>
    /// FloatProperty: BoostSpeed
    /// </summary>
    public unsafe float BoostSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4728); }
    }

    /// <summary>
    /// FloatProperty: BoostTime
    /// </summary>
    public unsafe float BoostTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4732); }
    }

    /// <summary>
    /// FloatProperty: DefaultBoostSpeed
    /// </summary>
    public unsafe float DefaultBoostSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4736); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: UpGadgets
    /// </summary>
    public InlineArray<BmSDK.FName> UpGadgets => new(8, Ptr + 4740, 8, this);

    /// <summary>
    /// NameProperty: UpGadgets
    /// </summary>
    public unsafe BmSDK.FName UpGadgets_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4740); }
    }
    /// <summary>
    /// NameProperty: UpGadgets
    /// </summary>
    public unsafe BmSDK.FName UpGadgets_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4748); }
    }
    /// <summary>
    /// NameProperty: UpGadgets
    /// </summary>
    public unsafe BmSDK.FName UpGadgets_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4756); }
    }
    /// <summary>
    /// NameProperty: UpGadgets
    /// </summary>
    public unsafe BmSDK.FName UpGadgets_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4764); }
    }
    /// <summary>
    /// NameProperty: UpGadgets
    /// </summary>
    public unsafe BmSDK.FName UpGadgets_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4772); }
    }
    /// <summary>
    /// NameProperty: UpGadgets
    /// </summary>
    public unsafe BmSDK.FName UpGadgets_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4780); }
    }
    /// <summary>
    /// NameProperty: UpGadgets
    /// </summary>
    public unsafe BmSDK.FName UpGadgets_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4788); }
    }
    /// <summary>
    /// NameProperty: UpGadgets
    /// </summary>
    public unsafe BmSDK.FName UpGadgets_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4796); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: DoubleUpGadgets
    /// </summary>
    public InlineArray<BmSDK.FName> DoubleUpGadgets => new(8, Ptr + 4804, 8, this);

    /// <summary>
    /// NameProperty: DoubleUpGadgets
    /// </summary>
    public unsafe BmSDK.FName DoubleUpGadgets_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4804); }
    }
    /// <summary>
    /// NameProperty: DoubleUpGadgets
    /// </summary>
    public unsafe BmSDK.FName DoubleUpGadgets_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4812); }
    }
    /// <summary>
    /// NameProperty: DoubleUpGadgets
    /// </summary>
    public unsafe BmSDK.FName DoubleUpGadgets_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4820); }
    }
    /// <summary>
    /// NameProperty: DoubleUpGadgets
    /// </summary>
    public unsafe BmSDK.FName DoubleUpGadgets_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4828); }
    }
    /// <summary>
    /// NameProperty: DoubleUpGadgets
    /// </summary>
    public unsafe BmSDK.FName DoubleUpGadgets_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4836); }
    }
    /// <summary>
    /// NameProperty: DoubleUpGadgets
    /// </summary>
    public unsafe BmSDK.FName DoubleUpGadgets_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4844); }
    }
    /// <summary>
    /// NameProperty: DoubleUpGadgets
    /// </summary>
    public unsafe BmSDK.FName DoubleUpGadgets_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4852); }
    }
    /// <summary>
    /// NameProperty: DoubleUpGadgets
    /// </summary>
    public unsafe BmSDK.FName DoubleUpGadgets_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4860); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: DownGadgets
    /// </summary>
    public InlineArray<BmSDK.FName> DownGadgets => new(5, Ptr + 4868, 8, this);

    /// <summary>
    /// NameProperty: DownGadgets
    /// </summary>
    public unsafe BmSDK.FName DownGadgets_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4868); }
    }
    /// <summary>
    /// NameProperty: DownGadgets
    /// </summary>
    public unsafe BmSDK.FName DownGadgets_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4876); }
    }
    /// <summary>
    /// NameProperty: DownGadgets
    /// </summary>
    public unsafe BmSDK.FName DownGadgets_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4884); }
    }
    /// <summary>
    /// NameProperty: DownGadgets
    /// </summary>
    public unsafe BmSDK.FName DownGadgets_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4892); }
    }
    /// <summary>
    /// NameProperty: DownGadgets
    /// </summary>
    public unsafe BmSDK.FName DownGadgets_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4900); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: ExtraCollision
    /// </summary>
    public InlineArray<BmSDK.BmGame.RPawnPlayer.FFakeWall> ExtraCollision => new(3, Ptr + 4908, 16, this);

    /// <summary>
    /// StructProperty: ExtraCollision
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FFakeWall ExtraCollision_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FFakeWall>(Ptr + 4908);
    /// <summary>
    /// StructProperty: ExtraCollision
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FFakeWall ExtraCollision_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FFakeWall>(Ptr + 4924);
    /// <summary>
    /// StructProperty: ExtraCollision
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FFakeWall ExtraCollision_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FFakeWall>(Ptr + 4940);

    /// <summary>
    /// ComponentProperty: OverrideUnderColl
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent OverrideUnderColl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent>(Ptr + 4956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4956); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: OverheadRopeControlPoint
    /// </summary>
    public InlineArray<BmSDK.BmGame.RRope2SimplePhysicsControlPoint> OverheadRopeControlPoint => new(6, Ptr + 4960, 4, this);

    /// <summary>
    /// ObjectProperty: OverheadRopeControlPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2SimplePhysicsControlPoint OverheadRopeControlPoint_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2SimplePhysicsControlPoint>(Ptr + 4960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4960); }
    }
    /// <summary>
    /// ObjectProperty: OverheadRopeControlPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2SimplePhysicsControlPoint OverheadRopeControlPoint_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2SimplePhysicsControlPoint>(Ptr + 4964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4964); }
    }
    /// <summary>
    /// ObjectProperty: OverheadRopeControlPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2SimplePhysicsControlPoint OverheadRopeControlPoint_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2SimplePhysicsControlPoint>(Ptr + 4968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4968); }
    }
    /// <summary>
    /// ObjectProperty: OverheadRopeControlPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2SimplePhysicsControlPoint OverheadRopeControlPoint_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2SimplePhysicsControlPoint>(Ptr + 4972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4972); }
    }
    /// <summary>
    /// ObjectProperty: OverheadRopeControlPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2SimplePhysicsControlPoint OverheadRopeControlPoint_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2SimplePhysicsControlPoint>(Ptr + 4976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4976); }
    }
    /// <summary>
    /// ObjectProperty: OverheadRopeControlPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2SimplePhysicsControlPoint OverheadRopeControlPoint_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2SimplePhysicsControlPoint>(Ptr + 4980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4980); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: OverheadRopeControlPointRopePosition
    /// </summary>
    public InlineArray<float> OverheadRopeControlPointRopePosition => new(6, Ptr + 4984, 4, this);

    /// <summary>
    /// FloatProperty: OverheadRopeControlPointRopePosition
    /// </summary>
    public unsafe float OverheadRopeControlPointRopePosition_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4984); }
    }
    /// <summary>
    /// FloatProperty: OverheadRopeControlPointRopePosition
    /// </summary>
    public unsafe float OverheadRopeControlPointRopePosition_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4988); }
    }
    /// <summary>
    /// FloatProperty: OverheadRopeControlPointRopePosition
    /// </summary>
    public unsafe float OverheadRopeControlPointRopePosition_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4992); }
    }
    /// <summary>
    /// FloatProperty: OverheadRopeControlPointRopePosition
    /// </summary>
    public unsafe float OverheadRopeControlPointRopePosition_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4996); }
    }
    /// <summary>
    /// FloatProperty: OverheadRopeControlPointRopePosition
    /// </summary>
    public unsafe float OverheadRopeControlPointRopePosition_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5000); }
    }
    /// <summary>
    /// FloatProperty: OverheadRopeControlPointRopePosition
    /// </summary>
    public unsafe float OverheadRopeControlPointRopePosition_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5004); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: OverheadRopeControlPointSocketNames
    /// </summary>
    public InlineArray<BmSDK.FName> OverheadRopeControlPointSocketNames => new(6, Ptr + 5008, 8, this);

    /// <summary>
    /// NameProperty: OverheadRopeControlPointSocketNames
    /// </summary>
    public unsafe BmSDK.FName OverheadRopeControlPointSocketNames_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5008); }
    }
    /// <summary>
    /// NameProperty: OverheadRopeControlPointSocketNames
    /// </summary>
    public unsafe BmSDK.FName OverheadRopeControlPointSocketNames_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5016); }
    }
    /// <summary>
    /// NameProperty: OverheadRopeControlPointSocketNames
    /// </summary>
    public unsafe BmSDK.FName OverheadRopeControlPointSocketNames_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5024); }
    }
    /// <summary>
    /// NameProperty: OverheadRopeControlPointSocketNames
    /// </summary>
    public unsafe BmSDK.FName OverheadRopeControlPointSocketNames_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5032); }
    }
    /// <summary>
    /// NameProperty: OverheadRopeControlPointSocketNames
    /// </summary>
    public unsafe BmSDK.FName OverheadRopeControlPointSocketNames_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5040); }
    }
    /// <summary>
    /// NameProperty: OverheadRopeControlPointSocketNames
    /// </summary>
    public unsafe BmSDK.FName OverheadRopeControlPointSocketNames_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5048); }
    }

    /// <summary>
    /// ObjectProperty: LastWirePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint_RopeBase LastWirePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint_RopeBase>(Ptr + 5056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5056); }
    }

    /// <summary>
    /// ObjectProperty: CurrentSpecialMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveInstance CurrentSpecialMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveInstance>(Ptr + 5060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5060); }
    }

    /// <summary>
    /// StructProperty: ClimbToCeilingClimbPoint
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FCeilingClimbPoint ClimbToCeilingClimbPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FCeilingClimbPoint>(Ptr + 5064);

    /// <summary>
    /// StructProperty: ClimbToCatwalkClimbPoint
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FCeilingClimbPoint ClimbToCatwalkClimbPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FCeilingClimbPoint>(Ptr + 5176);

    /// <summary>
    /// ObjectProperty: CurrentCeilingVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RCeilingClimbVolume CurrentCeilingVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCeilingClimbVolume>(Ptr + 5288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5288); }
    }

    /// <summary>
    /// ObjectProperty: GrateToCeiling
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelGrateBase GrateToCeiling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateBase>(Ptr + 5292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5292); }
    }

    /// <summary>
    /// ObjectProperty: GrateFromCeiling
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelGrateBase GrateFromCeiling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateBase>(Ptr + 5296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5296); }
    }

    /// <summary>
    /// ObjectProperty: ActiveGrate
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelGrateBase ActiveGrate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateBase>(Ptr + 5300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5300); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: GadgetList
    /// </summary>
    public InlineArray<BmSDK.BmGame.RInventoryGadget> GadgetList => new(32, Ptr + 5304, 4, this);

    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5304); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5308); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5312); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5316); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5320); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5324); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5328); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5332); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5336); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5340); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5344); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5348); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5352); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5356); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5360); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5364); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5368); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5372); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5376); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5380); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5384); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5388); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5392); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5396); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5400); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5404); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5408); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5412); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5416); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5420); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5424); }
    }
    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5428); }
    }

    /// <summary>
    /// StructProperty: LastJumpVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastJumpVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5432);

    /// <summary>
    /// ObjectProperty: GlideKickOverridePS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem GlideKickOverridePS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5444); }
    }

    /// <summary>
    /// ObjectProperty: SuperGlideAttackFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem SuperGlideAttackFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5448); }
    }

    /// <summary>
    /// ObjectProperty: SuperGlideAttackEmitter
    /// </summary>
    public unsafe BmSDK.Engine.Emitter SuperGlideAttackEmitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Emitter>(Ptr + 5452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5452); }
    }

    /// <summary>
    /// ObjectProperty: SuperGlideAttackMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant SuperGlideAttackMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 5456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5456); }
    }

    /// <summary>
    /// ObjectProperty: SnowCapeStunAttack
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem SnowCapeStunAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5460); }
    }

    /// <summary>
    /// ObjectProperty: LandingOnSnowFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem LandingOnSnowFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5464); }
    }

    /// <summary>
    /// ObjectProperty: LandingOnDustFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem LandingOnDustFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5468); }
    }

    /// <summary>
    /// ObjectProperty: TrophyHologramUnlockedFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem TrophyHologramUnlockedFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5472); }
    }

    /// <summary>
    /// ObjectProperty: TrophyHologramLockedFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem TrophyHologramLockedFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5476); }
    }

    /// <summary>
    /// ClassProperty: ForensicsType
    /// </summary>
    public unsafe BmSDK.Class ForensicsType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 5480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5480); }
    }

    /// <summary>
    /// ObjectProperty: AirBorneAttackOverridePS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem AirBorneAttackOverridePS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5484); }
    }

    /// <summary>
    /// ClassProperty: GlitchesType
    /// </summary>
    public unsafe BmSDK.Class GlitchesType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 5488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5488); }
    }

    /// <summary>
    /// ObjectProperty: TraversalMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController TraversalMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5492); }
    }

    /// <summary>
    /// ObjectProperty: StealthMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController StealthMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5496); }
    }

    /// <summary>
    /// ObjectProperty: RunTraversalMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController RunTraversalMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5500); }
    }

    /// <summary>
    /// ObjectProperty: StealthTraversalMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController StealthTraversalMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5504); }
    }

    /// <summary>
    /// ObjectProperty: WalkingMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController WalkingMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5508); }
    }

    /// <summary>
    /// ObjectProperty: FallingSpecialMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController FallingSpecialMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5512); }
    }

    /// <summary>
    /// ObjectProperty: FallingClimbSpecialMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController FallingClimbSpecialMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5516); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideSpecialMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController CapeGlideSpecialMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5520); }
    }

    /// <summary>
    /// ObjectProperty: HardCapeGlideSpecialMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController HardCapeGlideSpecialMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5524); }
    }

    /// <summary>
    /// ObjectProperty: ClimbFromLedgeMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController ClimbFromLedgeMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5528); }
    }

    /// <summary>
    /// ObjectProperty: ClimbFromDangleMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController ClimbFromDangleMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5532); }
    }

    /// <summary>
    /// ObjectProperty: ClimbFromLadderMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController ClimbFromLadderMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5536); }
    }

    /// <summary>
    /// ObjectProperty: LedgeMovesLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController LedgeMovesLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5540); }
    }

    /// <summary>
    /// ObjectProperty: LedgeMovesRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController LedgeMovesRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5544); }
    }

    /// <summary>
    /// ObjectProperty: DangleMovesLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController DangleMovesLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5548); }
    }

    /// <summary>
    /// ObjectProperty: DangleMovesRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController DangleMovesRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5552); }
    }

    /// <summary>
    /// ObjectProperty: JumpStraightOffRailingMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController JumpStraightOffRailingMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5556); }
    }

    /// <summary>
    /// IntProperty: ClimbIndex
    /// </summary>
    public unsafe int ClimbIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5560); }
    }

    /// <summary>
    /// ObjectProperty: CustomisableFallingGrabLedgeMove
    /// </summary>
    public unsafe BmSDK.BmGame.REnvironmentSpecialMoveWrapperFalling CustomisableFallingGrabLedgeMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentSpecialMoveWrapperFalling>(Ptr + 5564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5564); }
    }

    /// <summary>
    /// ObjectProperty: HopOffRailangMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HopOffRailangMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5568); }
    }

    /// <summary>
    /// ObjectProperty: HopOffRailangMoveToHang
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HopOffRailangMoveToHang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5572); }
    }

    /// <summary>
    /// ObjectProperty: HopOffRailangMoveToHang128
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HopOffRailangMoveToHang128
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5576); }
    }

    /// <summary>
    /// ObjectProperty: HopOffRailangMoveToHang128Dangle
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HopOffRailangMoveToHang128Dangle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5580); }
    }

    /// <summary>
    /// ObjectProperty: StepOffRailing128Move
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig StepOffRailing128Move
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5584); }
    }

    /// <summary>
    /// ObjectProperty: DropOffWireMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DropOffWireMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5588); }
    }

    /// <summary>
    /// ObjectProperty: GlideKickMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GlideKickMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5592); }
    }

    /// <summary>
    /// ObjectProperty: BoostGlideKickMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig BoostGlideKickMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5596); }
    }

    /// <summary>
    /// ObjectProperty: DiveOffBuildingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DiveOffBuildingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5600); }
    }

    /// <summary>
    /// ObjectProperty: GlideFromVantagePointMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GlideFromVantagePointMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5604); }
    }

    /// <summary>
    /// ObjectProperty: ZipLineMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ZipLineMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5608); }
    }

    /// <summary>
    /// ObjectProperty: LastChanceJumpMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LastChanceJumpMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5612); }
    }

    /// <summary>
    /// ObjectProperty: LowGlideKickMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LowGlideKickMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5616); }
    }

    /// <summary>
    /// ObjectProperty: ExitCoverLeftMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ExitCoverLeftMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5620); }
    }

    /// <summary>
    /// ObjectProperty: ExitCoverRightMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ExitCoverRightMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5624); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideLandHardMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CapeGlideLandHardMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5628); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideLandSkidMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CapeGlideLandSkidMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5632); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideLandToRunMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CapeGlideLandToRunMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5636); }
    }

    /// <summary>
    /// ObjectProperty: FastGlideSkidLandMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig FastGlideSkidLandMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5640); }
    }

    /// <summary>
    /// ObjectProperty: BoostGlideLandMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig BoostGlideLandMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5644); }
    }

    /// <summary>
    /// ObjectProperty: BoostGlideLandHardMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig BoostGlideLandHardMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5648); }
    }

    /// <summary>
    /// ObjectProperty: ShockwaveUpgradeLandMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ShockwaveUpgradeLandMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5652); }
    }

    /// <summary>
    /// ObjectProperty: ShockwaveBatwingLandMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ShockwaveBatwingLandMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5656); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideWallHitMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CapeGlideWallHitMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5660); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideWallHitHardMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CapeGlideWallHitHardMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5664); }
    }

    /// <summary>
    /// ObjectProperty: SlideMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SlideMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5668); }
    }

    /// <summary>
    /// ObjectProperty: DiveOverRailingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DiveOverRailingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5672); }
    }

    /// <summary>
    /// ObjectProperty: DiveOverRailingToFallMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DiveOverRailingToFallMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5676); }
    }

    /// <summary>
    /// ObjectProperty: RailingToLedgeHangMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RailingToLedgeHangMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5680); }
    }

    /// <summary>
    /// ObjectProperty: RailingToLEdgeHang128Move
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RailingToLEdgeHang128Move
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5684); }
    }

    /// <summary>
    /// ObjectProperty: RunStepDown128Move
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RunStepDown128Move
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5688); }
    }

    /// <summary>
    /// ObjectProperty: WalkStepDown128Move
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig WalkStepDown128Move
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5692); }
    }

    /// <summary>
    /// ObjectProperty: StealthStepDown128Move
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig StealthStepDown128Move
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5696); }
    }

    /// <summary>
    /// StructProperty: WireBouncer
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FWireBounceUpdater WireBouncer
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FWireBounceUpdater>(Ptr + 5700);

    /// <summary>
    /// ComponentProperty: PlayerIconPSC
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent PlayerIconPSC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5768); }
    }

    /// <summary>
    /// ObjectProperty: SlideStopAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SlideStopAudioEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5772); }
    }

    /// <summary>
    /// ObjectProperty: LevelUpSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent LevelUpSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5776); }
    }

    /// <summary>
    /// ObjectProperty: ComboFlowLostAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ComboFlowLostAudioEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5780); }
    }

    /// <summary>
    /// ObjectProperty: ComboFlowStartAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ComboFlowStartAudioEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5784); }
    }

    /// <summary>
    /// StructProperty: CurrentCollisionSmoothingForce
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentCollisionSmoothingForce
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5788);

    /// <summary>
    /// StructProperty: DesiredCollisionSmoothingForce
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DesiredCollisionSmoothingForce
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 5800);

    /// <summary>
    /// FloatProperty: CollisionSmoothingStrength
    /// </summary>
    public unsafe float CollisionSmoothingStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5812); }
    }

    /// <summary>
    /// FloatProperty: CollisionSmoothingOffStrength
    /// </summary>
    public unsafe float CollisionSmoothingOffStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5816); }
    }

    /// <summary>
    /// FloatProperty: CurrentAvoidAnimStrength
    /// </summary>
    public unsafe float CurrentAvoidAnimStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5820); }
    }

    /// <summary>
    /// FloatProperty: MaxAvoidAnimSpeed
    /// </summary>
    public unsafe float MaxAvoidAnimSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5824); }
    }

    /// <summary>
    /// FloatProperty: AvoidAnimOnStrength
    /// </summary>
    public unsafe float AvoidAnimOnStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5828); }
    }

    /// <summary>
    /// FloatProperty: AvoidAnimOffStrength
    /// </summary>
    public unsafe float AvoidAnimOffStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5832); }
    }

    /// <summary>
    /// ObjectProperty: GlideBoostSoundEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GlideBoostSoundEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5836); }
    }

    /// <summary>
    /// ObjectProperty: GlideBoostStopSoundEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GlideBoostStopSoundEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5840); }
    }

    /// <summary>
    /// ObjectProperty: GlideBoostSoundParam
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName GlideBoostSoundParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 5844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5844); }
    }

    /// <summary>
    /// ObjectProperty: CapeOpenSoundParam
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName CapeOpenSoundParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 5848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5848); }
    }

    /// <summary>
    /// StructProperty: CriticalLandScreenShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct CriticalLandScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 5852);

    /// <summary>
    /// InlineArray{IntProperty}: QuickGadgets
    /// </summary>
    public InlineArray<int> QuickGadgets => new(6, Ptr + 5996, 4, this);

    /// <summary>
    /// IntProperty: QuickGadgets
    /// </summary>
    public unsafe int QuickGadgets_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5996); }
    }
    /// <summary>
    /// IntProperty: QuickGadgets
    /// </summary>
    public unsafe int QuickGadgets_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6000); }
    }
    /// <summary>
    /// IntProperty: QuickGadgets
    /// </summary>
    public unsafe int QuickGadgets_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6004); }
    }
    /// <summary>
    /// IntProperty: QuickGadgets
    /// </summary>
    public unsafe int QuickGadgets_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6008); }
    }
    /// <summary>
    /// IntProperty: QuickGadgets
    /// </summary>
    public unsafe int QuickGadgets_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6012); }
    }
    /// <summary>
    /// IntProperty: QuickGadgets
    /// </summary>
    public unsafe int QuickGadgets_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6016); }
    }

    /// <summary>
    /// FloatProperty: SpecialMoveLeftFootCycleStartTime
    /// </summary>
    public unsafe float SpecialMoveLeftFootCycleStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6020); }
    }

    /// <summary>
    /// FloatProperty: SpecialMoveRightPassingCycleStartTime
    /// </summary>
    public unsafe float SpecialMoveRightPassingCycleStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6024); }
    }

    /// <summary>
    /// FloatProperty: OverrideFallingGravity
    /// </summary>
    public unsafe float OverrideFallingGravity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6028); }
    }

    /// <summary>
    /// FloatProperty: MaxJumpStrengthToJumpLand
    /// </summary>
    public unsafe float MaxJumpStrengthToJumpLand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6032); }
    }

    /// <summary>
    /// FloatProperty: GrappleForceFieldSize
    /// </summary>
    public unsafe float GrappleForceFieldSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6036); }
    }

    /// <summary>
    /// FloatProperty: GrappleForceFieldWidth
    /// </summary>
    public unsafe float GrappleForceFieldWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6040); }
    }

    /// <summary>
    /// FloatProperty: GrappleForceFieldStrength
    /// </summary>
    public unsafe float GrappleForceFieldStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6044); }
    }

    /// <summary>
    /// FloatProperty: GrappleForceFieldStrengthPower
    /// </summary>
    public unsafe float GrappleForceFieldStrengthPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6048); }
    }

    /// <summary>
    /// FloatProperty: GrappleAnimForceFieldFactor
    /// </summary>
    public unsafe float GrappleAnimForceFieldFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6052); }
    }

    /// <summary>
    /// StructProperty: CantRunInDirection
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CantRunInDirection
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6056);

    /// <summary>
    /// StructProperty: QuickFireFailedTransitionId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FTransitionId QuickFireFailedTransitionId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTransitionId>(Ptr + 6068);

    /// <summary>
    /// StructProperty: ShotOnVantageShaker
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ShotOnVantageShaker
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 6072);

    /// <summary>
    /// ObjectProperty: UnderWaterVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RWaterRescueVolumeBase UnderWaterVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWaterRescueVolumeBase>(Ptr + 6216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6216); }
    }

    /// <summary>
    /// StructProperty: UnderWaterVolumeLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 UnderWaterVolumeLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6220);

    /// <summary>
    /// ObjectProperty: UnderWaterEmitter
    /// </summary>
    public unsafe BmSDK.BmGame.REmitter UnderWaterEmitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REmitter>(Ptr + 6232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6232); }
    }

    /// <summary>
    /// ObjectProperty: SlippedCorner
    /// </summary>
    public unsafe BmSDK.Engine.Actor SlippedCorner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 6236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6236); }
    }

    /// <summary>
    /// FloatProperty: JumpStrength
    /// </summary>
    public unsafe float JumpStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6240); }
    }

    /// <summary>
    /// FloatProperty: JumpFallOffRate
    /// </summary>
    public unsafe float JumpFallOffRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6244); }
    }

    /// <summary>
    /// FloatProperty: FallAnimRate
    /// </summary>
    public unsafe float FallAnimRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6248); }
    }

    /// <summary>
    /// FloatProperty: JumpAnimRate
    /// </summary>
    public unsafe float JumpAnimRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6252); }
    }

    /// <summary>
    /// ObjectProperty: FallSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FallSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 6256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6256); }
    }

    /// <summary>
    /// ObjectProperty: FallStopSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FallStopSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 6260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6260); }
    }

    /// <summary>
    /// ComponentProperty: HangFromVantageRope
    /// </summary>
    public unsafe BmSDK.BmGame.RSimpleRopeComponent HangFromVantageRope
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSimpleRopeComponent>(Ptr + 6264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6264); }
    }

    /// <summary>
    /// StructProperty: LastRootMotionVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastRootMotionVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6268);

    /// <summary>
    /// StructProperty: EnvironemntEdgeTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveTypesContainer EnvironemntEdgeTypes
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveTypesContainer>(Ptr + 6280);

    /// <summary>
    /// StructProperty: DamageProxyLastActivePos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DamageProxyLastActivePos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6288);

    /// <summary>
    /// StructProperty: InterrogWallSpaceCheckExtents
    /// </summary>
    public unsafe ref System.Numerics.Vector3 InterrogWallSpaceCheckExtents
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6300);

    /// <summary>
    /// FloatProperty: InterrogWallSpaceCheckHeight
    /// </summary>
    public unsafe float InterrogWallSpaceCheckHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6312); }
    }

    /// <summary>
    /// ArrayProperty: PlayerEmotePack
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RDialogueLine> PlayerEmotePack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RDialogueLine>>(Ptr + 6316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6316); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceLastUnderTargetChange
    /// </summary>
    public unsafe float TimeSinceLastUnderTargetChange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6328); }
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
