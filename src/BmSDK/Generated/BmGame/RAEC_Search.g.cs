#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAEC_Search<br/>
/// (size = 480)
/// (flags = 8388626)
/// </summary>
public partial class RAEC_Search : BmSDK.BmGame.RAEC_SearchBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAEC_Search", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAEC_Search.
    /// </summary>
    public static RAEC_Search DefaultObject => (RAEC_Search)StaticClass().DefaultObject;

    internal RAEC_Search() { }

    /// <summary>
    /// Constructs a new RAEC_Search
    /// </summary>
    public RAEC_Search(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAEC_Search(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Search>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Search>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Search>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_ReassignToPredatorPoint;
    /// <summary>
    /// Function: ReassignToPredatorPoint
    /// </summary>
    public unsafe virtual void ReassignToPredatorPoint(BmSDK.BmGame.RAEC_Search_Sub PointLeader, BmSDK.BmGame.RPredatorSpecialMovePointBase PredatorPoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReassignToPredatorPoint, "BmGame.RAEC_Search.ReassignToPredatorPoint");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointLeader, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PredatorPoint, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReassignToCornerTerrified;
    /// <summary>
    /// Function: ReassignToCornerTerrified
    /// </summary>
    public unsafe virtual void ReassignToCornerTerrified(BmSDK.BmGame.RAEC_Search_Sub_Terrified CornerLeader, BmSDK.BmGame.RCornerWallMarker StartCorner, BmSDK.BmGame.RCornerWallMarker EndCorner)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReassignToCornerTerrified, "BmGame.RAEC_Search.ReassignToCornerTerrified");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerLeader, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartCorner, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndCorner, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReassignToRailPeek;
    /// <summary>
    /// Function: ReassignToRailPeek
    /// </summary>
    public unsafe virtual void ReassignToRailPeek(BmSDK.BmGame.RAEC_Search_Sub PeekLeader, BmSDK.BmGame.RBMPathNode_FenceJump FenceNode, System.Numerics.Vector3 StartPoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReassignToRailPeek, "BmGame.RAEC_Search.ReassignToRailPeek");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PeekLeader, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FenceNode, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ReassignToCorner;
    /// <summary>
    /// Function: ReassignToCorner
    /// </summary>
    public unsafe virtual void ReassignToCorner(BmSDK.BmGame.RAEC_Search_Sub CornerLeader, BmSDK.BmGame.RCornerWallMarker StartCorner, BmSDK.BmGame.RCornerWallMarker EndCorner)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ReassignToCorner, "BmGame.RAEC_Search.ReassignToCorner");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerLeader, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartCorner, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndCorner, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AssignFromTerrorCorner;
    /// <summary>
    /// Function: AssignFromTerrorCorner
    /// </summary>
    public unsafe virtual void AssignFromTerrorCorner(BmSDK.BmGame.RBMAIController NewMember, BmSDK.BmGame.RAEC_Search_Sub.FRestoreSearchState OldState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignFromTerrorCorner, "BmGame.RAEC_Search.AssignFromTerrorCorner");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldState, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AssignFromFollow;
    /// <summary>
    /// Function: AssignFromFollow
    /// </summary>
    public unsafe override void AssignFromFollow(BmSDK.BmGame.RBMAIController NewMember, BmSDK.BmGame.RAEC_Search_Sub.FRestoreSearchState OldState)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignFromFollow, "BmGame.RAEC_Search.AssignFromFollow");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldState, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AssignToSniperPoint;
    /// <summary>
    /// Function: AssignToSniperPoint
    /// </summary>
    public unsafe virtual void AssignToSniperPoint(BmSDK.BmGame.RBMAIController NewMember)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignToSniperPoint, "BmGame.RAEC_Search.AssignToSniperPoint");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AssignToRestoreTannoyBox;
    /// <summary>
    /// Function: AssignToRestoreTannoyBox
    /// </summary>
    public unsafe virtual void AssignToRestoreTannoyBox(BmSDK.BmGame.RBMAIController NewMember, BmSDK.Engine.Actor TannoyBox)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignToRestoreTannoyBox, "BmGame.RAEC_Search.AssignToRestoreTannoyBox");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TannoyBox, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RestoreTannoyBox;
    /// <summary>
    /// Function: RestoreTannoyBox
    /// </summary>
    public unsafe virtual void RestoreTannoyBox(BmSDK.Engine.Actor TannoyBox)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RestoreTannoyBox, "BmGame.RAEC_Search.RestoreTannoyBox");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TannoyBox, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AssignToRestoreDevice;
    /// <summary>
    /// Function: AssignToRestoreDevice
    /// </summary>
    public unsafe virtual void AssignToRestoreDevice(BmSDK.BmGame.RBMAIController NewMember, BmSDK.Engine.Actor Device)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignToRestoreDevice, "BmGame.RAEC_Search.AssignToRestoreDevice");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Device, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AssignToSmashGenerators;
    /// <summary>
    /// Function: AssignToSmashGenerators
    /// </summary>
    public unsafe virtual void AssignToSmashGenerators(BmSDK.BmGame.RBMAIController NewMember)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignToSmashGenerators, "BmGame.RAEC_Search.AssignToSmashGenerators");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AssignToSmashGargoyles;
    /// <summary>
    /// Function: AssignToSmashGargoyles
    /// </summary>
    public unsafe virtual void AssignToSmashGargoyles(BmSDK.BmGame.RBMAIController NewMember)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignToSmashGargoyles, "BmGame.RAEC_Search.AssignToSmashGargoyles");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AssignFromThermalFail;
    /// <summary>
    /// Function: AssignFromThermalFail
    /// </summary>
    public unsafe virtual void AssignFromThermalFail(BmSDK.BmGame.RBMAIController NewMember)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignFromThermalFail, "BmGame.RAEC_Search.AssignFromThermalFail");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_Assign;
    /// <summary>
    /// Function: Assign
    /// </summary>
    public unsafe override void Assign(BmSDK.BmGame.RBMAIController NewMember, bool bFirstAttempt = default, bool bHasHintLoc = default, System.Numerics.Vector3 HintLoc = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_Assign, "BmGame.RAEC_Search.Assign");
        byte* paramsPtr = stackalloc byte[88];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFirstAttempt, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHasHintLoc, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HintLoc, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AssignToImmiediateSmash;
    /// <summary>
    /// Function: AssignToImmiediateSmash
    /// </summary>
    public unsafe virtual void AssignToImmiediateSmash(BmSDK.BmGame.RBMAIController NewMember)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignToImmiediateSmash, "BmGame.RAEC_Search.AssignToImmiediateSmash");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AssignToGuard;
    /// <summary>
    /// Function: AssignToGuard
    /// </summary>
    public unsafe virtual void AssignToGuard(BmSDK.BmGame.RBMAIController NewMember)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AssignToGuard, "BmGame.RAEC_Search.AssignToGuard");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SendToGuardPoint;
    /// <summary>
    /// Function: SendToGuardPoint
    /// </summary>
    public unsafe virtual void SendToGuardPoint(BmSDK.BmGame.RBMAIController NewGuardCon, BmSDK.BmGame.RGuardPoint GuardPoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SendToGuardPoint, "BmGame.RAEC_Search.SendToGuardPoint");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGuardCon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GuardPoint, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanSnipe;
    /// <summary>
    /// Function: CanSnipe
    /// </summary>
    public unsafe override bool CanSnipe(BmSDK.BmGame.RBMAIController Member)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanSnipe, "BmGame.RAEC_Search.CanSnipe");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Member, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetNewFearLevel;
    /// <summary>
    /// Function: SetNewFearLevel
    /// </summary>
    public unsafe override void SetNewFearLevel(BmSDK.BmGame.RBMRoomAIState.VillainFearLevel FearLevel)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNewFearLevel, "BmGame.RAEC_Search.SetNewFearLevel");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FearLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
