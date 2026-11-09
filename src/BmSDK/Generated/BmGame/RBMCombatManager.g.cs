#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMCombatManager<br/>
/// (size = 1224)
/// (flags = 142606482)
/// </summary>
public partial class RBMCombatManager : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMCombatManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMCombatManager.
    /// </summary>
    public static RBMCombatManager DefaultObject => (RBMCombatManager)StaticClass().DefaultObject;

    internal RBMCombatManager() { }

    /// <summary>
    /// Constructs a new RBMCombatManager
    /// </summary>
    public RBMCombatManager(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMCombatManager(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatManager>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatManager>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatManager>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatManager>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatManager>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatManager>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatManager>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatManager>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    private static BmSDK.Function __fn_UnRegisterDroneSearchLightMesh;
    /// <summary>
    /// Function: UnRegisterDroneSearchLightMesh
    /// </summary>
    public unsafe virtual void UnRegisterDroneSearchLightMesh()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnRegisterDroneSearchLightMesh, "BmGame.RBMCombatManager.UnRegisterDroneSearchLightMesh");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterDroneSearchLightMesh;
    /// <summary>
    /// Function: RegisterDroneSearchLightMesh
    /// </summary>
    public unsafe virtual void RegisterDroneSearchLightMesh(BmSDK.Engine.StaticMesh NewDroneSearchLightMesh)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterDroneSearchLightMesh, "BmGame.RBMCombatManager.RegisterDroneSearchLightMesh");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDroneSearchLightMesh, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetDroneSearchLightMesh;
    /// <summary>
    /// Function: GetDroneSearchLightMesh
    /// </summary>
    public unsafe virtual BmSDK.Engine.StaticMesh GetDroneSearchLightMesh()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDroneSearchLightMesh, "BmGame.RBMCombatManager.GetDroneSearchLightMesh");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Engine.StaticMesh>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UnRegisterCheerMove;
    /// <summary>
    /// Function: UnRegisterCheerMove
    /// </summary>
    public unsafe virtual void UnRegisterCheerMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnRegisterCheerMove, "BmGame.RBMCombatManager.UnRegisterCheerMove");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterCheerMove;
    /// <summary>
    /// Function: RegisterCheerMove
    /// </summary>
    public unsafe virtual void RegisterCheerMove(BmSDK.Class NewCheerMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterCheerMove, "BmGame.RBMCombatManager.RegisterCheerMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCheerMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCheerMove;
    /// <summary>
    /// Function: GetCheerMove
    /// </summary>
    public unsafe virtual BmSDK.Class GetCheerMove()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCheerMove, "BmGame.RBMCombatManager.GetCheerMove");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.Class>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ResetDDA;
    /// <summary>
    /// Function: ResetDDA
    /// </summary>
    public unsafe virtual void ResetDDA()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetDDA, "BmGame.RBMCombatManager.ResetDDA");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SimulateCombatChapterDDA;
    /// <summary>
    /// Function: SimulateCombatChapterDDA
    /// </summary>
    public unsafe virtual void SimulateCombatChapterDDA(int Type)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SimulateCombatChapterDDA, "BmGame.RBMCombatManager.SimulateCombatChapterDDA");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SimulateCombatDDAWin;
    /// <summary>
    /// Function: SimulateCombatDDAWin
    /// </summary>
    public unsafe virtual void SimulateCombatDDAWin()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SimulateCombatDDAWin, "BmGame.RBMCombatManager.SimulateCombatDDAWin");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SimulateCombatDDALose;
    /// <summary>
    /// Function: SimulateCombatDDALose
    /// </summary>
    public unsafe virtual void SimulateCombatDDALose()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SimulateCombatDDALose, "BmGame.RBMCombatManager.SimulateCombatDDALose");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DumpDPD;
    /// <summary>
    /// Function: DumpDPD
    /// </summary>
    public unsafe virtual float DumpDPD(float CurrChapter, BmSDK.BmGame.RBMCombatManager.FDifficultyProgressionDefine DPD)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpDPD, "BmGame.RBMCombatManager.DumpDPD");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrChapter, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DPD, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 28);
    }

    private static BmSDK.Function __fn_GetDPDName;
    /// <summary>
    /// Function: GetDPDName
    /// </summary>
    public unsafe virtual BmSDK.FString GetDPDName(int I)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDPDName, "BmGame.RBMCombatManager.GetDPDName");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(I, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_DumpCombatDifficultyDefines;
    /// <summary>
    /// Function: DumpCombatDifficultyDefines
    /// </summary>
    public unsafe virtual void DumpCombatDifficultyDefines()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DumpCombatDifficultyDefines, "BmGame.RBMCombatManager.DumpCombatDifficultyDefines");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AllCombatantsAreSock;
    /// <summary>
    /// Function: AllCombatantsAreSock
    /// </summary>
    public unsafe virtual bool AllCombatantsAreSock()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AllCombatantsAreSock, "BmGame.RBMCombatManager.AllCombatantsAreSock");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ExitedNarrowCombatZone;
    /// <summary>
    /// Function: ExitedNarrowCombatZone
    /// </summary>
    public unsafe virtual void ExitedNarrowCombatZone()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ExitedNarrowCombatZone, "BmGame.RBMCombatManager.ExitedNarrowCombatZone");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnteredNarrowCombatZone;
    /// <summary>
    /// Function: EnteredNarrowCombatZone
    /// </summary>
    public unsafe virtual void EnteredNarrowCombatZone(BmSDK.BmGame.RPawnCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnteredNarrowCombatZone, "BmGame.RBMCombatManager.EnteredNarrowCombatZone");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_NinjaDodged;
    /// <summary>
    /// Function: NinjaDodged
    /// </summary>
    public unsafe virtual void NinjaDodged()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_NinjaDodged, "BmGame.RBMCombatManager.NinjaDodged");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetPawnHealthMultiplier;
    /// <summary>
    /// Function: GetPawnHealthMultiplier
    /// </summary>
    public unsafe virtual float GetPawnHealthMultiplier()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPawnHealthMultiplier, "BmGame.RBMCombatManager.GetPawnHealthMultiplier");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ResetPawnHealthMultiplier;
    /// <summary>
    /// Function: ResetPawnHealthMultiplier
    /// </summary>
    public unsafe virtual void ResetPawnHealthMultiplier()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetPawnHealthMultiplier, "BmGame.RBMCombatManager.ResetPawnHealthMultiplier");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetPawnHealthMultiplier;
    /// <summary>
    /// Function: SetPawnHealthMultiplier
    /// </summary>
    public unsafe virtual void SetPawnHealthMultiplier(float NewValue, bool bForceInNewGamePlus = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetPawnHealthMultiplier, "BmGame.RBMCombatManager.SetPawnHealthMultiplier");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewValue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceInNewGamePlus, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsToughThugActive;
    /// <summary>
    /// Function: IsToughThugActive
    /// </summary>
    public unsafe virtual bool IsToughThugActive()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsToughThugActive, "BmGame.RBMCombatManager.IsToughThugActive");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNumActiveCombatThugs;
    /// <summary>
    /// Function: GetNumActiveCombatThugs
    /// </summary>
    public unsafe virtual int GetNumActiveCombatThugs()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumActiveCombatThugs, "BmGame.RBMCombatManager.GetNumActiveCombatThugs");
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

    private static BmSDK.Function __fn_GetNumJoiningCombatantsForInterrogation;
    /// <summary>
    /// Function: GetNumJoiningCombatantsForInterrogation
    /// </summary>
    public unsafe virtual int GetNumJoiningCombatantsForInterrogation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumJoiningCombatantsForInterrogation, "BmGame.RBMCombatManager.GetNumJoiningCombatantsForInterrogation");
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

    private static BmSDK.Function __fn_GetNumJoiningCombatants;
    /// <summary>
    /// Function: GetNumJoiningCombatants
    /// </summary>
    public unsafe virtual int GetNumJoiningCombatants()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumJoiningCombatants, "BmGame.RBMCombatManager.GetNumJoiningCombatants");
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

    private static BmSDK.Function __fn_RemoveJoiningCombatant;
    /// <summary>
    /// Function: RemoveJoiningCombatant
    /// </summary>
    public unsafe virtual void RemoveJoiningCombatant(BmSDK.BmGame.RPawnVillain OldCombatant)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveJoiningCombatant, "BmGame.RBMCombatManager.RemoveJoiningCombatant");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldCombatant, paramsPtr + 0);
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

    private static BmSDK.Function __fn_AddJoiningCombatant;
    /// <summary>
    /// Function: AddJoiningCombatant
    /// </summary>
    public unsafe virtual void AddJoiningCombatant(BmSDK.BmGame.RPawnVillain NewCombatant)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddJoiningCombatant, "BmGame.RBMCombatManager.AddJoiningCombatant");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCombatant, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetTeleportPoint;
    /// <summary>
    /// Function: GetTeleportPoint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RCombatTeleport GetTeleportPoint()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetTeleportPoint, "BmGame.RBMCombatManager.GetTeleportPoint");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCombatTeleport>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ListWeaponConfigRefs;
    /// <summary>
    /// Function: ListWeaponConfigRefs
    /// </summary>
    public unsafe virtual void ListWeaponConfigRefs()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ListWeaponConfigRefs, "BmGame.RBMCombatManager.ListWeaponConfigRefs");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearWeaponConfigRef;
    /// <summary>
    /// Function: ClearWeaponConfigRef
    /// </summary>
    public unsafe virtual void ClearWeaponConfigRef(BmSDK.BmGame.RBMCombatManager.EWeaponConfigType ConfigType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearWeaponConfigRef, "BmGame.RBMCombatManager.ClearWeaponConfigRef");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConfigType, paramsPtr + 0);
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

    private static BmSDK.Function __fn_SetWeaponConfig;
    /// <summary>
    /// Function: SetWeaponConfig
    /// </summary>
    public unsafe virtual void SetWeaponConfig(BmSDK.BmGame.RBMCombatManager.EWeaponConfigType ConfigType, BmSDK.BmGame.RWeaponConfig NewConfig)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetWeaponConfig, "BmGame.RBMCombatManager.SetWeaponConfig");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConfigType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewConfig, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetWeaponConfigAndAddRef;
    /// <summary>
    /// Function: GetWeaponConfigAndAddRef
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig GetWeaponConfigAndAddRef(BmSDK.BmGame.RBMCombatManager.EWeaponConfigType ConfigType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetWeaponConfigAndAddRef, "BmGame.RBMCombatManager.GetWeaponConfigAndAddRef");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConfigType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_HasWeaponConfigFor;
    /// <summary>
    /// Function: HasWeaponConfigFor
    /// </summary>
    public unsafe virtual bool HasWeaponConfigFor(BmSDK.BmGame.RBMCombatManager.EWeaponConfigType ConfigType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasWeaponConfigFor, "BmGame.RBMCombatManager.HasWeaponConfigFor");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConfigType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_BrickThrown;
    /// <summary>
    /// Function: BrickThrown
    /// </summary>
    public unsafe virtual void BrickThrown()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BrickThrown, "BmGame.RBMCombatManager.BrickThrown");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanThrowBrick;
    /// <summary>
    /// Function: CanThrowBrick
    /// </summary>
    public unsafe virtual bool CanThrowBrick(BmSDK.BmGame.RPawnVillain Thrower)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanThrowBrick, "BmGame.RBMCombatManager.CanThrowBrick");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thrower, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_GetMaxSimCounterers;
    /// <summary>
    /// Function: GetMaxSimCounterers
    /// </summary>
    public unsafe virtual int GetMaxSimCounterers()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetMaxSimCounterers, "BmGame.RBMCombatManager.GetMaxSimCounterers");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_SetSimultaneousAttackTimer;
    /// <summary>
    /// Function: SetSimultaneousAttackTimer
    /// </summary>
    public unsafe virtual void SetSimultaneousAttackTimer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetSimultaneousAttackTimer, "BmGame.RBMCombatManager.SetSimultaneousAttackTimer");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetVenomDDAValue;
    /// <summary>
    /// Function: GetVenomDDAValue
    /// </summary>
    public unsafe virtual float GetVenomDDAValue(BmSDK.BmGame.RBMCombatManager.EVenomDifficultyType EVDT, BmSDK.BmGame.RPawnBossVenomBase Venom)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVenomDDAValue, "BmGame.RBMCombatManager.GetVenomDDAValue");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EVDT, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Venom, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetVenomDifficultyValue;
    /// <summary>
    /// Function: GetVenomDifficultyValue
    /// </summary>
    public unsafe virtual float GetVenomDifficultyValue(BmSDK.BmGame.RBMCombatManager.EVenomDifficultyType EVDT, BmSDK.BmGame.RPawnBossVenomBase Venom)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetVenomDifficultyValue, "BmGame.RBMCombatManager.GetVenomDifficultyValue");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EVDT, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Venom, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetDifficultyValue;
    /// <summary>
    /// Function: GetDifficultyValue
    /// </summary>
    public unsafe virtual float GetDifficultyValue(BmSDK.BmGame.RBMCombatManager.EDifficultyType EDT, BmSDK.BmGame.RBMPawnAI TestPawn = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDifficultyValue, "BmGame.RBMCombatManager.GetDifficultyValue");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EDT, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetDDAValueForBoss;
    /// <summary>
    /// Function: GetDDAValueForBoss
    /// </summary>
    public unsafe virtual float GetDDAValueForBoss(float ddaValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDDAValueForBoss, "BmGame.RBMCombatManager.GetDDAValueForBoss");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ddaValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetDDAValue;
    /// <summary>
    /// Function: GetDDAValue
    /// </summary>
    public unsafe virtual float GetDDAValue(float ddaValue)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetDDAValue, "BmGame.RBMCombatManager.GetDDAValue");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ddaValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_SetAttackingVenomHenchman;
    /// <summary>
    /// Function: SetAttackingVenomHenchman
    /// </summary>
    public unsafe virtual void SetAttackingVenomHenchman()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetAttackingVenomHenchman, "BmGame.RBMCombatManager.SetAttackingVenomHenchman");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_WasVenomAttackRecentlyUsed;
    /// <summary>
    /// Function: WasVenomAttackRecentlyUsed
    /// </summary>
    public unsafe virtual bool WasVenomAttackRecentlyUsed(BmSDK.Class CombatMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_WasVenomAttackRecentlyUsed, "BmGame.RBMCombatManager.WasVenomAttackRecentlyUsed");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_RegisterVenomAttack;
    /// <summary>
    /// Function: RegisterVenomAttack
    /// </summary>
    public unsafe virtual void RegisterVenomAttack(BmSDK.Class CombatMove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterVenomAttack, "BmGame.RBMCombatManager.RegisterVenomAttack");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TriggerCombatCowerEvent;
    /// <summary>
    /// Function: TriggerCombatCowerEvent
    /// </summary>
    public unsafe virtual int TriggerCombatCowerEvent(BmSDK.BmGame.RPawnCombat EventInstigator, System.Numerics.Vector3 EventLocation, float LOSRadius = default, float NoLOSRadius = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCombatCowerEvent, "BmGame.RBMCombatManager.TriggerCombatCowerEvent");
        byte* paramsPtr = stackalloc byte[316];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventInstigator, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LOSRadius, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NoLOSRadius, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 24);
    }

    private static BmSDK.Function __fn_TriggerCombatEvent;
    /// <summary>
    /// Function: TriggerCombatEvent
    /// </summary>
    public unsafe virtual void TriggerCombatEvent(BmSDK.BmGame.RPawnCombat EventInstigator, System.Numerics.Vector3 EventLocation, System.Numerics.Vector3 SightingLocation, float LOSRadius = default, float NoLOSRadius = default, bool bCanAlertInOtherPylons = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TriggerCombatEvent, "BmGame.RBMCombatManager.TriggerCombatEvent");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventInstigator, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SightingLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LOSRadius, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NoLOSRadius, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanAlertInOtherPylons, paramsPtr + 36);
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

    private static BmSDK.Function __fn_KillAllEnemies;
    /// <summary>
    /// Function: KillAllEnemies
    /// </summary>
    public unsafe virtual bool KillAllEnemies(BmSDK.Engine.Controller PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillAllEnemies, "BmGame.RBMCombatManager.KillAllEnemies");
        byte* paramsPtr = stackalloc byte[300];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_InputRightStick;
    /// <summary>
    /// Function: InputRightStick
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 InputRightStick(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_InputRightStick, "BmGame.RBMCombatManager.InputRightStick");
        byte* paramsPtr = stackalloc byte[44];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PlayCombatCueOnPawn;
    /// <summary>
    /// Function: PlayCombatCueOnPawn
    /// </summary>
    public unsafe virtual void PlayCombatCueOnPawn(BmSDK.Engine.RDialogueLine DialogueLine, BmSDK.BmGame.RPawnCombat AvoidPawn = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCombatCueOnPawn, "BmGame.RBMCombatManager.PlayCombatCueOnPawn");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DialogueLine, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvoidPawn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayCombatBarkOnPawn;
    /// <summary>
    /// Function: PlayCombatBarkOnPawn
    /// </summary>
    public unsafe virtual void PlayCombatBarkOnPawn(BmSDK.FString EventName, BmSDK.BmGame.RPawnCombat CalleePawn = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayCombatBarkOnPawn, "BmGame.RBMCombatManager.PlayCombatBarkOnPawn");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CalleePawn, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldPlayBarkTaunt;
    /// <summary>
    /// Function: ShouldPlayBarkTaunt
    /// </summary>
    public unsafe virtual bool ShouldPlayBarkTaunt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldPlayBarkTaunt, "BmGame.RBMCombatManager.ShouldPlayBarkTaunt");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PlayBarkGroupTaunt;
    /// <summary>
    /// Function: PlayBarkGroupTaunt
    /// </summary>
    public unsafe virtual void PlayBarkGroupTaunt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayBarkGroupTaunt, "BmGame.RBMCombatManager.PlayBarkGroupTaunt");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetLastPickup;
    /// <summary>
    /// Function: SetLastPickup
    /// </summary>
    public unsafe virtual void SetLastPickup(BmSDK.BmGame.RBMWeapon Weapon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLastPickup, "BmGame.RBMCombatManager.SetLastPickup");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Weapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetTimeBetweenBarkMultiplier;
    /// <summary>
    /// Function: SetTimeBetweenBarkMultiplier
    /// </summary>
    public unsafe virtual void SetTimeBetweenBarkMultiplier(float NewTimeBetweenBarkMultiplier)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetTimeBetweenBarkMultiplier, "BmGame.RBMCombatManager.SetTimeBetweenBarkMultiplier");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTimeBetweenBarkMultiplier, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanPlayBarkForPickup;
    /// <summary>
    /// Function: CanPlayBarkForPickup
    /// </summary>
    public unsafe virtual bool CanPlayBarkForPickup(BmSDK.BmGame.RBMWeapon NewWeapon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayBarkForPickup, "BmGame.RBMCombatManager.CanPlayBarkForPickup");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_JoinCombatBarkPlayed;
    /// <summary>
    /// Function: JoinCombatBarkPlayed
    /// </summary>
    public unsafe virtual void JoinCombatBarkPlayed(System.Numerics.Vector3 PawnPos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_JoinCombatBarkPlayed, "BmGame.RBMCombatManager.JoinCombatBarkPlayed");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BarkPlayed;
    /// <summary>
    /// Function: BarkPlayed
    /// </summary>
    public unsafe virtual void BarkPlayed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BarkPlayed, "BmGame.RBMCombatManager.BarkPlayed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetEnterCombatBark;
    /// <summary>
    /// Function: GetEnterCombatBark
    /// </summary>
    public unsafe virtual BmSDK.FString GetEnterCombatBark(BmSDK.BmGame.RPawnVillain Villain)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetEnterCombatBark, "BmGame.RBMCombatManager.GetEnterCombatBark");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.FString>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_CanPlayJoinCombatBark;
    /// <summary>
    /// Function: CanPlayJoinCombatBark
    /// </summary>
    public unsafe virtual bool CanPlayJoinCombatBark(System.Numerics.Vector3 PawnPos)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlayJoinCombatBark, "BmGame.RBMCombatManager.CanPlayJoinCombatBark");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_ResetCanPlaySeeCombatBark;
    /// <summary>
    /// Function: ResetCanPlaySeeCombatBark
    /// </summary>
    public unsafe virtual void ResetCanPlaySeeCombatBark()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetCanPlaySeeCombatBark, "BmGame.RBMCombatManager.ResetCanPlaySeeCombatBark");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayedSeeCombatBark;
    /// <summary>
    /// Function: PlayedSeeCombatBark
    /// </summary>
    public unsafe virtual void PlayedSeeCombatBark()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayedSeeCombatBark, "BmGame.RBMCombatManager.PlayedSeeCombatBark");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanPlaySeeCombatBark;
    /// <summary>
    /// Function: CanPlaySeeCombatBark
    /// </summary>
    public unsafe virtual bool CanPlaySeeCombatBark()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPlaySeeCombatBark, "BmGame.RBMCombatManager.CanPlaySeeCombatBark");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanBark;
    /// <summary>
    /// Function: CanBark
    /// </summary>
    public unsafe virtual bool CanBark(bool bHighPriorityBark = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanBark, "BmGame.RBMCombatManager.CanBark");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHighPriorityBark, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsInBossFightPreventingBark;
    /// <summary>
    /// Function: IsInBossFightPreventingBark
    /// </summary>
    public unsafe virtual bool IsInBossFightPreventingBark(BmSDK.BmGame.RPlayerController PC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInBossFightPreventingBark, "BmGame.RBMCombatManager.IsInBossFightPreventingBark");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
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

    private static BmSDK.Function __fn_TauntPerformed;
    /// <summary>
    /// Function: TauntPerformed
    /// </summary>
    public unsafe virtual void TauntPerformed(int TauntID)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TauntPerformed, "BmGame.RBMCombatManager.TauntPerformed");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TauntID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetLastTauntID;
    /// <summary>
    /// Function: GetLastTauntID
    /// </summary>
    public unsafe virtual int GetLastTauntID()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetLastTauntID, "BmGame.RBMCombatManager.GetLastTauntID");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanTaunt;
    /// <summary>
    /// Function: CanTaunt
    /// </summary>
    public unsafe virtual bool CanTaunt()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanTaunt, "BmGame.RBMCombatManager.CanTaunt");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_ShouldSuppressFinalBlow;
    /// <summary>
    /// Function: ShouldSuppressFinalBlow
    /// </summary>
    public unsafe virtual bool ShouldSuppressFinalBlow()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldSuppressFinalBlow, "BmGame.RBMCombatManager.ShouldSuppressFinalBlow");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_UnsuppressFinalBlow;
    /// <summary>
    /// Function: UnsuppressFinalBlow
    /// </summary>
    public unsafe virtual void UnsuppressFinalBlow()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnsuppressFinalBlow, "BmGame.RBMCombatManager.UnsuppressFinalBlow");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SuppressFinalBlow;
    /// <summary>
    /// Function: SuppressFinalBlow
    /// </summary>
    public unsafe virtual void SuppressFinalBlow()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuppressFinalBlow, "BmGame.RBMCombatManager.SuppressFinalBlow");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetBaseMoveScore;
    /// <summary>
    /// Function: GetBaseMoveScore
    /// </summary>
    public unsafe virtual int GetBaseMoveScore(BmSDK.BmGame.RGameInfo.EComboMoveType MoveType)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetBaseMoveScore, "BmGame.RBMCombatManager.GetBaseMoveScore");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_BatmanBlocked;
    /// <summary>
    /// Function: BatmanBlocked
    /// </summary>
    public unsafe virtual void BatmanBlocked(BmSDK.BmGame.RPawnCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatmanBlocked, "BmGame.RBMCombatManager.BatmanBlocked");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DelayNextAttack;
    /// <summary>
    /// Function: DelayNextAttack
    /// </summary>
    public unsafe virtual void DelayNextAttack(float DelayAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DelayNextAttack, "BmGame.RBMCombatManager.DelayNextAttack");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DelayAmount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BatmanHit;
    /// <summary>
    /// Function: BatmanHit
    /// </summary>
    public unsafe virtual void BatmanHit(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn, BmSDK.BmGame.RPawnCombat Attacker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatmanHit, "BmGame.RBMCombatManager.BatmanHit");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SuccessfulRedirect;
    /// <summary>
    /// Function: SuccessfulRedirect
    /// </summary>
    public unsafe virtual void SuccessfulRedirect(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuccessfulRedirect, "BmGame.RBMCombatManager.SuccessfulRedirect");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SuccessfulEvade;
    /// <summary>
    /// Function: SuccessfulEvade
    /// </summary>
    public unsafe virtual void SuccessfulEvade(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuccessfulEvade, "BmGame.RBMCombatManager.SuccessfulEvade");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SuccessfulCounter;
    /// <summary>
    /// Function: SuccessfulCounter
    /// </summary>
    public unsafe virtual void SuccessfulCounter(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn, BmSDK.BmGame.RPawnCombat HitPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuccessfulCounter, "BmGame.RBMCombatManager.SuccessfulCounter");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPawn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SuccessfulStun;
    /// <summary>
    /// Function: SuccessfulStun
    /// </summary>
    public unsafe virtual void SuccessfulStun(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SuccessfulStun, "BmGame.RBMCombatManager.SuccessfulStun");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ComboStrikeHit;
    /// <summary>
    /// Function: ComboStrikeHit
    /// </summary>
    public unsafe virtual void ComboStrikeHit(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ComboStrikeHit, "BmGame.RBMCombatManager.ComboStrikeHit");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HeavyStrikeHit;
    /// <summary>
    /// Function: HeavyStrikeHit
    /// </summary>
    public unsafe virtual void HeavyStrikeHit(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn, BmSDK.BmGame.RPawnCombat HitPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HeavyStrikeHit, "BmGame.RBMCombatManager.HeavyStrikeHit");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPawn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QuickStrikeHit;
    /// <summary>
    /// Function: QuickStrikeHit
    /// </summary>
    public unsafe virtual void QuickStrikeHit(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn, BmSDK.BmGame.RPawnCombat HitPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QuickStrikeHit, "BmGame.RBMCombatManager.QuickStrikeHit");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPawn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HeavyStrikeKO;
    /// <summary>
    /// Function: HeavyStrikeKO
    /// </summary>
    public unsafe virtual void HeavyStrikeKO(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn, BmSDK.BmGame.RPawnCharacter TakedownTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HeavyStrikeKO, "BmGame.RBMCombatManager.HeavyStrikeKO");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TakedownTarget, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_QuickStrikeKO;
    /// <summary>
    /// Function: QuickStrikeKO
    /// </summary>
    public unsafe virtual void QuickStrikeKO(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn, BmSDK.BmGame.RPawnCharacter TakedownTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_QuickStrikeKO, "BmGame.RBMCombatManager.QuickStrikeKO");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TakedownTarget, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CheckCameraTarget;
    /// <summary>
    /// Function: CheckCameraTarget
    /// </summary>
    public unsafe virtual void CheckCameraTarget(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn, BmSDK.Engine.Actor CheckCameraTargetActor, BmSDK.BmGame.RGameInfo.CameraLookAtSpeed CheckCameraLookAtSpeed, System.Numerics.Vector3 CheckCameraTargetOffset)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckCameraTarget, "BmGame.RBMCombatManager.CheckCameraTarget");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckCameraTargetActor, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckCameraLookAtSpeed, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckCameraTargetOffset, paramsPtr + 12);
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

    private static BmSDK.Function __fn_GetCombatCameraScoreForPawn;
    /// <summary>
    /// Function: GetCombatCameraScoreForPawn
    /// </summary>
    public unsafe virtual float GetCombatCameraScoreForPawn(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn, BmSDK.BmGame.RPawnVillain TestPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatCameraScoreForPawn, "BmGame.RBMCombatManager.GetCombatCameraScoreForPawn");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_SetOverrideChapter;
    /// <summary>
    /// Function: SetOverrideChapter
    /// </summary>
    public unsafe virtual void SetOverrideChapter(float NewOverrideChapter)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetOverrideChapter, "BmGame.RBMCombatManager.SetOverrideChapter");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOverrideChapter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetCombatChapter;
    /// <summary>
    /// Function: GetCombatChapter
    /// </summary>
    public unsafe virtual float GetCombatChapter(int ActualChapter = default, BmSDK.BmGame.RBMPawnAI TestPawn = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatChapter, "BmGame.RBMCombatManager.GetCombatChapter");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActualChapter, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_OtherPawnsAreInPawnsRangeForFinalBlow;
    /// <summary>
    /// Function: OtherPawnsAreInPawnsRangeForFinalBlow
    /// </summary>
    public unsafe virtual bool OtherPawnsAreInPawnsRangeForFinalBlow(BmSDK.BmGame.RPawnCombat TestPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_OtherPawnsAreInPawnsRangeForFinalBlow, "BmGame.RBMCombatManager.OtherPawnsAreInPawnsRangeForFinalBlow");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_ShouldDoFinalBlowCam;
    /// <summary>
    /// Function: ShouldDoFinalBlowCam
    /// </summary>
    public unsafe virtual bool ShouldDoFinalBlowCam(BmSDK.BmGame.RPawnCombat Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldDoFinalBlowCam, "BmGame.RBMCombatManager.ShouldDoFinalBlowCam");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_TitanReadyForBeatup;
    /// <summary>
    /// Function: TitanReadyForBeatup
    /// </summary>
    public unsafe virtual bool TitanReadyForBeatup()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TitanReadyForBeatup, "BmGame.RBMCombatManager.TitanReadyForBeatup");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetNumVenomCombatants;
    /// <summary>
    /// Function: GetNumVenomCombatants
    /// </summary>
    public unsafe virtual int GetNumVenomCombatants()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumVenomCombatants, "BmGame.RBMCombatManager.GetNumVenomCombatants");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<int>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsAnyoneAttackingWithNonGun;
    /// <summary>
    /// Function: IsAnyoneAttackingWithNonGun
    /// </summary>
    public unsafe virtual bool IsAnyoneAttackingWithNonGun(BmSDK.BmGame.RPawnCombat Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAnyoneAttackingWithNonGun, "BmGame.RBMCombatManager.IsAnyoneAttackingWithNonGun");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_KillAllThugs;
    /// <summary>
    /// Function: KillAllThugs
    /// </summary>
    public unsafe virtual void KillAllThugs(BmSDK.BmGame.RPawnCombat Killer)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_KillAllThugs, "BmGame.RBMCombatManager.KillAllThugs");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CancelAllAttacks;
    /// <summary>
    /// Function: CancelAllAttacks
    /// </summary>
    public unsafe virtual void CancelAllAttacks(BmSDK.BmGame.RPawnCombat Target, float DelayAmount)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CancelAllAttacks, "BmGame.RBMCombatManager.CancelAllAttacks");
        byte* paramsPtr = stackalloc byte[32];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DelayAmount, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnlockPlayer;
    /// <summary>
    /// Function: UnlockPlayer
    /// </summary>
    public unsafe virtual void UnlockPlayer(BmSDK.BmGame.RPawnCombat Villain)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnlockPlayer, "BmGame.RBMCombatManager.UnlockPlayer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TryLockPlayer;
    /// <summary>
    /// Function: TryLockPlayer
    /// </summary>
    public unsafe virtual bool TryLockPlayer(BmSDK.BmGame.RPawnCombat Villain)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TryLockPlayer, "BmGame.RBMCombatManager.TryLockPlayer");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_IsAnyoneHaveLockThePlayer;
    /// <summary>
    /// Function: IsAnyoneHaveLockThePlayer
    /// </summary>
    public unsafe virtual bool IsAnyoneHaveLockThePlayer()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAnyoneHaveLockThePlayer, "BmGame.RBMCombatManager.IsAnyoneHaveLockThePlayer");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsBaneBossFight;
    /// <summary>
    /// Function: IsBaneBossFight
    /// </summary>
    public unsafe virtual bool IsBaneBossFight(BmSDK.BmGame.RPlayerController RPC)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsBaneBossFight, "BmGame.RBMCombatManager.IsBaneBossFight");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_PawnDied;
    /// <summary>
    /// Function: PawnDied
    /// </summary>
    public unsafe virtual void PawnDied(BmSDK.BmGame.RPawnCombat DeadPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PawnDied, "BmGame.RBMCombatManager.PawnDied");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeadPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishedCombatMoreThan1Second;
    /// <summary>
    /// Function: FinishedCombatMoreThan1Second
    /// </summary>
    public unsafe virtual void FinishedCombatMoreThan1Second()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishedCombatMoreThan1Second, "BmGame.RBMCombatManager.FinishedCombatMoreThan1Second");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FinishedCombat;
    /// <summary>
    /// Function: FinishedCombat
    /// </summary>
    public unsafe virtual void FinishedCombat()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FinishedCombat, "BmGame.RBMCombatManager.FinishedCombat");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ResetPerFightStats;
    /// <summary>
    /// Function: ResetPerFightStats
    /// </summary>
    public unsafe virtual void ResetPerFightStats()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ResetPerFightStats, "BmGame.RBMCombatManager.ResetPerFightStats");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CombatSuccessTriggered;
    /// <summary>
    /// Function: CombatSuccessTriggered
    /// </summary>
    public unsafe virtual void CombatSuccessTriggered()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CombatSuccessTriggered, "BmGame.RBMCombatManager.CombatSuccessTriggered");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_DisableDDATracking;
    /// <summary>
    /// Function: DisableDDATracking
    /// </summary>
    public unsafe virtual void DisableDDATracking()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DisableDDATracking, "BmGame.RBMCombatManager.DisableDDATracking");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_EnableDDATracking;
    /// <summary>
    /// Function: EnableDDATracking
    /// </summary>
    public unsafe virtual void EnableDDATracking()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_EnableDDATracking, "BmGame.RBMCombatManager.EnableDDATracking");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemovePawnFromList;
    /// <summary>
    /// Function: RemovePawnFromList
    /// </summary>
    public unsafe virtual void RemovePawnFromList(BmSDK.BmGame.RPawnCombat ToRemove, bool bRemovedDueToKO = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemovePawnFromList, "BmGame.RBMCombatManager.RemovePawnFromList");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToRemove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRemovedDueToKO, paramsPtr + 4);
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

    private static BmSDK.Function __fn_DebugCombatAreas;
    /// <summary>
    /// Function: DebugCombatAreas
    /// </summary>
    public unsafe virtual void DebugCombatAreas()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_DebugCombatAreas, "BmGame.RBMCombatManager.DebugCombatAreas");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UpdateMaxCombatPawns;
    /// <summary>
    /// Function: UpdateMaxCombatPawns
    /// </summary>
    public unsafe virtual void UpdateMaxCombatPawns(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateMaxCombatPawns, "BmGame.RBMCombatManager.UpdateMaxCombatPawns");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetMaxCombatPawns;
    /// <summary>
    /// Function: SetMaxCombatPawns
    /// </summary>
    public unsafe virtual void SetMaxCombatPawns(int NewMaxPawns)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetMaxCombatPawns, "BmGame.RBMCombatManager.SetMaxCombatPawns");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMaxPawns, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_FindBestTarget;
    /// <summary>
    /// Function: FindBestTarget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat FindBestTarget(BmSDK.BmGame.RPawnCombat ForPawnVillain)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_FindBestTarget, "BmGame.RBMCombatManager.FindBestTarget");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForPawnVillain, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_SetLastSeenLocation;
    /// <summary>
    /// Function: SetLastSeenLocation
    /// </summary>
    public unsafe virtual void SetLastSeenLocation(System.Numerics.Vector3 NewLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetLastSeenLocation, "BmGame.RBMCombatManager.SetLastSeenLocation");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_PlayerSeen;
    /// <summary>
    /// Function: PlayerSeen
    /// </summary>
    public unsafe virtual void PlayerSeen(System.Numerics.Vector3 NewLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PlayerSeen, "BmGame.RBMCombatManager.PlayerSeen");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsAllPlayersDead;
    /// <summary>
    /// Function: IsAllPlayersDead
    /// </summary>
    public unsafe virtual bool IsAllPlayersDead()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAllPlayersDead, "BmGame.RBMCombatManager.IsAllPlayersDead");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GetPDD;
    /// <summary>
    /// Function: GetPDD
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPersistentDebugData GetPDD()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetPDD, "BmGame.RBMCombatManager.GetPDD");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPersistentDebugData>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsInCombatChallenge;
    /// <summary>
    /// Function: IsInCombatChallenge
    /// </summary>
    public unsafe virtual bool IsInCombatChallenge()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsInCombatChallenge, "BmGame.RBMCombatManager.IsInCombatChallenge");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_PunishingAttackPerformed;
    /// <summary>
    /// Function: PunishingAttackPerformed
    /// </summary>
    public unsafe virtual void PunishingAttackPerformed()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PunishingAttackPerformed, "BmGame.RBMCombatManager.PunishingAttackPerformed");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_CanPerformPunishingAttack;
    /// <summary>
    /// Function: CanPerformPunishingAttack
    /// </summary>
    public unsafe virtual bool CanPerformPunishingAttack()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanPerformPunishingAttack, "BmGame.RBMCombatManager.CanPerformPunishingAttack");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_LeavingCombat;
    /// <summary>
    /// Function: LeavingCombat
    /// </summary>
    public unsafe virtual void LeavingCombat(BmSDK.BmGame.RPawnCombat Leaver)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LeavingCombat, "BmGame.RBMCombatManager.LeavingCombat");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Leaver, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TellPlayerControllerCombatFinished;
    /// <summary>
    /// Function: TellPlayerControllerCombatFinished
    /// </summary>
    public unsafe virtual void TellPlayerControllerCombatFinished(bool bBatmanVictorious)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TellPlayerControllerCombatFinished, "BmGame.RBMCombatManager.TellPlayerControllerCombatFinished");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBatmanVictorious, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_TellPlayerControllerCombatStarted;
    /// <summary>
    /// Function: TellPlayerControllerCombatStarted
    /// </summary>
    public unsafe virtual void TellPlayerControllerCombatStarted()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_TellPlayerControllerCombatStarted, "BmGame.RBMCombatManager.TellPlayerControllerCombatStarted");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_UnRegisterBossAnims;
    /// <summary>
    /// Function: UnRegisterBossAnims
    /// </summary>
    public unsafe virtual void UnRegisterBossAnims()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UnRegisterBossAnims, "BmGame.RBMCombatManager.UnRegisterBossAnims");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterBossAnims;
    /// <summary>
    /// Function: RegisterBossAnims
    /// </summary>
    public unsafe virtual void RegisterBossAnims(BmSDK.BmGame.RPawnVillain Boss)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterBossAnims, "BmGame.RBMCombatManager.RegisterBossAnims");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Boss, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterPawn;
    /// <summary>
    /// Function: RegisterPawn
    /// </summary>
    public unsafe virtual void RegisterPawn(BmSDK.BmGame.RPawnCombat NewPawn)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterPawn, "BmGame.RBMCombatManager.RegisterPawn");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsNearVillainBlocker;
    /// <summary>
    /// Function: IsNearVillainBlocker
    /// </summary>
    public unsafe virtual bool IsNearVillainBlocker(System.Numerics.Vector3 TestLocation)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsNearVillainBlocker, "BmGame.RBMCombatManager.IsNearVillainBlocker");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_RemoveVillainDoorBlocker;
    /// <summary>
    /// Function: RemoveVillainDoorBlocker
    /// </summary>
    public unsafe virtual void RemoveVillainDoorBlocker(BmSDK.BmGame.RBunkerDoorVillainBlocker Old)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveVillainDoorBlocker, "BmGame.RBMCombatManager.RemoveVillainDoorBlocker");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Old, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterVillainDoorBlocker;
    /// <summary>
    /// Function: RegisterVillainDoorBlocker
    /// </summary>
    public unsafe virtual void RegisterVillainDoorBlocker(BmSDK.BmGame.RBunkerDoorVillainBlocker NewDoorBlocker)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterVillainDoorBlocker, "BmGame.RBMCombatManager.RegisterVillainDoorBlocker");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDoorBlocker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLunaticMusicManager;
    /// <summary>
    /// Function: ClearLunaticMusicManager
    /// </summary>
    public unsafe virtual void ClearLunaticMusicManager(BmSDK.BmGame.RSeqAct_LunaticMusicManager OldManager)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLunaticMusicManager, "BmGame.RBMCombatManager.ClearLunaticMusicManager");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldManager, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterLunaticMusicManager;
    /// <summary>
    /// Function: RegisterLunaticMusicManager
    /// </summary>
    public unsafe virtual void RegisterLunaticMusicManager(BmSDK.BmGame.RSeqAct_LunaticMusicManager NewManager)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterLunaticMusicManager, "BmGame.RBMCombatManager.RegisterLunaticMusicManager");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewManager, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ClearLastTargetStates;
    /// <summary>
    /// Function: ClearLastTargetStates
    /// </summary>
    public unsafe virtual void ClearLastTargetStates()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ClearLastTargetStates, "BmGame.RBMCombatManager.ClearLastTargetStates");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ActivateCombatEvent;
    /// <summary>
    /// Function: ActivateCombatEvent
    /// </summary>
    public unsafe virtual void ActivateCombatEvent(BmSDK.Class EventClass, BmSDK.Engine.Actor NewInstigator)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ActivateCombatEvent, "BmGame.RBMCombatManager.ActivateCombatEvent");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewInstigator, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RegisterCombatEvent;
    /// <summary>
    /// Function: RegisterCombatEvent
    /// </summary>
    public unsafe virtual void RegisterCombatEvent(BmSDK.BmGame.RCombatEvent NewEvent)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RegisterCombatEvent, "BmGame.RBMCombatManager.RegisterCombatEvent");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewEvent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_GetGuardPointForPawn;
    /// <summary>
    /// Function: GetGuardPointForPawn
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RCombatArea_GuardPoint GetGuardPointForPawn(BmSDK.BmGame.RBMPawnAI Guard)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetGuardPointForPawn, "BmGame.RBMCombatManager.GetGuardPointForPawn");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Guard, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCombatArea_GuardPoint>(paramsPtr + 4);
    }

    private static BmSDK.Function __fn_RemoveGuardPoint;
    /// <summary>
    /// Function: RemoveGuardPoint
    /// </summary>
    public unsafe virtual void RemoveGuardPoint(BmSDK.BmGame.RCombatArea_GuardPoint ToRemove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveGuardPoint, "BmGame.RBMCombatManager.RemoveGuardPoint");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToRemove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddGuardPoint;
    /// <summary>
    /// Function: AddGuardPoint
    /// </summary>
    public unsafe virtual void AddGuardPoint(BmSDK.BmGame.RCombatArea_GuardPoint ToAdd)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddGuardPoint, "BmGame.RBMCombatManager.AddGuardPoint");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToAdd, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_BatmanLeftCombatArea;
    /// <summary>
    /// Function: BatmanLeftCombatArea
    /// </summary>
    public unsafe virtual void BatmanLeftCombatArea(BmSDK.BmGame.RCombatArea CombatArea)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_BatmanLeftCombatArea, "BmGame.RBMCombatManager.BatmanLeftCombatArea");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatArea, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_HasCombatAreas;
    /// <summary>
    /// Function: HasCombatAreas
    /// </summary>
    public unsafe virtual bool HasCombatAreas()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasCombatAreas, "BmGame.RBMCombatManager.HasCombatAreas");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_GatherCombatAreaForces;
    /// <summary>
    /// Function: GatherCombatAreaForces
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GatherCombatAreaForces(BmSDK.BmGame.RPawnCombat Pawn, float MaxForce)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GatherCombatAreaForces, "BmGame.RBMCombatManager.GatherCombatAreaForces");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxForce, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_GetCombatAreaForce;
    /// <summary>
    /// Function: GetCombatAreaForce
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetCombatAreaForce(BmSDK.BmGame.RCombatArea Area, BmSDK.BmGame.RPawnCombat Pawn, float MaxForce)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatAreaForce, "BmGame.RBMCombatManager.GetCombatAreaForce");
        byte* paramsPtr = stackalloc byte[64];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Area, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxForce, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<System.Numerics.Vector3>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetCombatArea;
    /// <summary>
    /// Function: GetCombatArea
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RCombatArea GetCombatArea(System.Numerics.Vector3 CheckLoc = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatArea, "BmGame.RBMCombatManager.GetCombatArea");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckLoc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCombatArea>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_RemoveCombatArea;
    /// <summary>
    /// Function: RemoveCombatArea
    /// </summary>
    public unsafe virtual void RemoveCombatArea(BmSDK.BmGame.RCombatArea ToRemove)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveCombatArea, "BmGame.RBMCombatManager.RemoveCombatArea");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToRemove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddCombatArea;
    /// <summary>
    /// Function: AddCombatArea
    /// </summary>
    public unsafe virtual void AddCombatArea(BmSDK.BmGame.RCombatArea ToAdd)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCombatArea, "BmGame.RBMCombatManager.AddCombatArea");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToAdd, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_ShouldTurnOverForCheapAttack;
    /// <summary>
    /// Function: ShouldTurnOverForCheapAttack
    /// </summary>
    public unsafe virtual bool ShouldTurnOverForCheapAttack(BmSDK.BmGame.RPawnCombat Villain, BmSDK.BmGame.RPawnCombat Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldTurnOverForCheapAttack, "BmGame.RBMCombatManager.ShouldTurnOverForCheapAttack");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_CheckThugToThrowForBane;
    /// <summary>
    /// Function: CheckThugToThrowForBane
    /// </summary>
    public unsafe virtual bool CheckThugToThrowForBane(BmSDK.BmGame.RPawnCombat NewUser, BmSDK.BmGame.RPawnCombat NewTarget, out BmSDK.BmGame.RPawnVillain thugToTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckThugToThrowForBane, "BmGame.RBMCombatManager.CheckThugToThrowForBane");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewUser, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out thugToTarget);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(thugToTarget, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        thugToTarget = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnVillain>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CheckEnvironmentWeaponForBane;
    /// <summary>
    /// Function: CheckEnvironmentWeaponForBane
    /// </summary>
    public unsafe virtual bool CheckEnvironmentWeaponForBane(BmSDK.BmGame.RPawnCombat NewUser, BmSDK.BmGame.RPawnCombat NewTarget, out BmSDK.BmGame.RBMCombatPoint_EnvironmentWeapon weaponToTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CheckEnvironmentWeaponForBane, "BmGame.RBMCombatManager.CheckEnvironmentWeaponForBane");
        byte* paramsPtr = stackalloc byte[48];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewUser, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 4);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out weaponToTarget);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(weaponToTarget, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        weaponToTarget = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMCombatPoint_EnvironmentWeapon>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_GetCombatPointForPawn;
    /// <summary>
    /// Function: GetCombatPointForPawn
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatPoint GetCombatPointForPawn(BmSDK.BmGame.RPawnCombat NewUser, BmSDK.BmGame.RPawnCombat NewTarget, bool bTaunting)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetCombatPointForPawn, "BmGame.RBMCombatManager.GetCombatPointForPawn");
        byte* paramsPtr = stackalloc byte[56];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewUser, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTaunting, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RBMCombatPoint>(paramsPtr + 12);
    }

    private static BmSDK.Function __fn_CanMoveToPointToUseObject;
    /// <summary>
    /// Function: CanMoveToPointToUseObject
    /// </summary>
    public unsafe virtual bool CanMoveToPointToUseObject(BmSDK.BmGame.RPawnCombat TestPawn, System.Numerics.Vector3 TestPoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanMoveToPointToUseObject, "BmGame.RBMCombatManager.CanMoveToPointToUseObject");
        byte* paramsPtr = stackalloc byte[60];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPoint, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 16);
    }

    private static BmSDK.Function __fn_HasGunLocker;
    /// <summary>
    /// Function: HasGunLocker
    /// </summary>
    public unsafe virtual bool HasGunLocker()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_HasGunLocker, "BmGame.RBMCombatManager.HasGunLocker");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_RemoveThrowTarget;
    /// <summary>
    /// Function: RemoveThrowTarget
    /// </summary>
    public unsafe virtual void RemoveThrowTarget(BmSDK.BmGame.RThrowTarget RemoveTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveThrowTarget, "BmGame.RBMCombatManager.RemoveThrowTarget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemoveTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddThrowTarget;
    /// <summary>
    /// Function: AddThrowTarget
    /// </summary>
    public unsafe virtual void AddThrowTarget(BmSDK.BmGame.RThrowTarget NewTarget)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddThrowTarget, "BmGame.RBMCombatManager.AddThrowTarget");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_RemoveCombatPoint;
    /// <summary>
    /// Function: RemoveCombatPoint
    /// </summary>
    public unsafe virtual void RemoveCombatPoint(BmSDK.BmGame.RBMCombatPoint _RemoveCombatPoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_RemoveCombatPoint, "BmGame.RBMCombatManager.RemoveCombatPoint");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RemoveCombatPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_AddCombatPoint;
    /// <summary>
    /// Function: AddCombatPoint
    /// </summary>
    public unsafe virtual void AddCombatPoint(BmSDK.BmGame.RBMCombatPoint NewCombatPoint)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_AddCombatPoint, "BmGame.RBMCombatManager.AddCombatPoint");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCombatPoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_SetNewGamePlus;
    /// <summary>
    /// Function: SetNewGamePlus
    /// </summary>
    public unsafe virtual void SetNewGamePlus()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_SetNewGamePlus, "BmGame.RBMCombatManager.SetNewGamePlus");
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
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_PostBeginPlay, "BmGame.RBMCombatManager.PostBeginPlay");
        byte* paramsPtr = stackalloc byte[16];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    private static BmSDK.Function __fn_IsAnyoneAttacking;
    /// <summary>
    /// Function: IsAnyoneAttacking
    /// </summary>
    public unsafe virtual bool IsAnyoneAttacking(BmSDK.BmGame.RPawnCombat Target)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAnyoneAttacking, "BmGame.RBMCombatManager.IsAnyoneAttacking");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetNumSnipers;
    /// <summary>
    /// Function: GetNumSnipers
    /// </summary>
    public unsafe virtual int GetNumSnipers()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumSnipers, "BmGame.RBMCombatManager.GetNumSnipers");
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

    private static BmSDK.Function __fn_IsCombatActiveInPylon;
    /// <summary>
    /// Function: IsCombatActiveInPylon
    /// </summary>
    public unsafe virtual bool IsCombatActiveInPylon(BmSDK.Engine.Pylon CheckPylon)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCombatActiveInPylon, "BmGame.RBMCombatManager.IsCombatActiveInPylon");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckPylon, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetInterrogationTarget;
    /// <summary>
    /// Function: GetInterrogationTarget
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain GetInterrogationTarget()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetInterrogationTarget, "BmGame.RBMCombatManager.GetInterrogationTarget");
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
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnVillain>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_CanUseInterrogation;
    /// <summary>
    /// Function: CanUseInterrogation
    /// </summary>
    public unsafe virtual bool CanUseInterrogation(System.Numerics.Vector3 CheckLocation, bool bIgnoreNumCheck = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUseInterrogation, "BmGame.RBMCombatManager.CanUseInterrogation");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreNumCheck, paramsPtr + 12);
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

    private static BmSDK.Function __fn_IsOnscreen;
    /// <summary>
    /// Function: IsOnscreen
    /// </summary>
    public unsafe virtual bool IsOnscreen(System.Numerics.Vector3 CheckLocation, BmSDK.BmGame.RPawnCombat PlayerPawn, System.Numerics.Vector3 CameraPositionOffset = default, float MaxCosMulti = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsOnscreen, "BmGame.RBMCombatManager.IsOnscreen");
        byte* paramsPtr = stackalloc byte[52];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraPositionOffset, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxCosMulti, paramsPtr + 28);
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

    private static BmSDK.Function __fn_GetAngleFromPawnToPawn;
    /// <summary>
    /// Function: GetAngleFromPawnToPawn
    /// </summary>
    public unsafe virtual float GetAngleFromPawnToPawn(BmSDK.BmGame.RPawnCombat Pawn1, BmSDK.BmGame.RPawnCombat Pawn2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetAngleFromPawnToPawn, "BmGame.RBMCombatManager.GetAngleFromPawnToPawn");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn2, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<float>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_LOSFromPawnToPawn;
    /// <summary>
    /// Function: LOSFromPawnToPawn
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat LOSFromPawnToPawn(BmSDK.BmGame.RPawnCombat Pawn1, BmSDK.BmGame.RPawnCombat Pawn2)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_LOSFromPawnToPawn, "BmGame.RBMCombatManager.LOSFromPawnToPawn");
        byte* paramsPtr = stackalloc byte[28];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn2, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RPawnCombat>(paramsPtr + 8);
    }

    private static BmSDK.Function __fn_IsDeepInCombat;
    /// <summary>
    /// Function: IsDeepInCombat
    /// </summary>
    public unsafe virtual bool IsDeepInCombat()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsDeepInCombat, "BmGame.RBMCombatManager.IsDeepInCombat");
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

    private static BmSDK.Function __fn_UpdateAttackersForTargetPlayer;
    /// <summary>
    /// Function: UpdateAttackersForTargetPlayer
    /// </summary>
    public unsafe virtual void UpdateAttackersForTargetPlayer(BmSDK.BmGame.RPawnCombat TargetPawn, float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateAttackersForTargetPlayer, "BmGame.RBMCombatManager.UpdateAttackersForTargetPlayer");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UpdateAttackersForTargetAIPawn;
    /// <summary>
    /// Function: UpdateAttackersForTargetAIPawn
    /// </summary>
    public unsafe virtual void UpdateAttackersForTargetAIPawn(BmSDK.BmGame.RBMPawnAI TargetPawn, float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateAttackersForTargetAIPawn, "BmGame.RBMCombatManager.UpdateAttackersForTargetAIPawn");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
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

    private static BmSDK.Function __fn_UpdateAttackers;
    /// <summary>
    /// Function: UpdateAttackers
    /// </summary>
    public unsafe virtual void UpdateAttackers(float DeltaTime)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_UpdateAttackers, "BmGame.RBMCombatManager.UpdateAttackers");
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

    private static BmSDK.Function __fn_CanUseCombatPoint;
    /// <summary>
    /// Function: CanUseCombatPoint
    /// </summary>
    public unsafe virtual bool CanUseCombatPoint(bool bIgnoreProportion = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CanUseCombatPoint, "BmGame.RBMCombatManager.CanUseCombatPoint");
        byte* paramsPtr = stackalloc byte[24];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreProportion, paramsPtr + 0);
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

    private static BmSDK.Function __fn_GetNumCombatantsForInterrogation;
    /// <summary>
    /// Function: GetNumCombatantsForInterrogation
    /// </summary>
    public unsafe virtual int GetNumCombatantsForInterrogation()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumCombatantsForInterrogation, "BmGame.RBMCombatManager.GetNumCombatantsForInterrogation");
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

    private static BmSDK.Function __fn_GetNumCombatants;
    /// <summary>
    /// Function: GetNumCombatants
    /// </summary>
    public unsafe virtual int GetNumCombatants()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_GetNumCombatants, "BmGame.RBMCombatManager.GetNumCombatants");
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

    private static BmSDK.Function __fn_CacheNumCombatants;
    /// <summary>
    /// Function: CacheNumCombatants
    /// </summary>
    public unsafe virtual void CacheNumCombatants(bool bRemovedDueToKO = default)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_CacheNumCombatants, "BmGame.RBMCombatManager.CacheNumCombatants");
        byte* paramsPtr = stackalloc byte[20];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bRemovedDueToKO, paramsPtr + 0);
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

    private static BmSDK.Function __fn_ShouldForceCombatCamera;
    /// <summary>
    /// Function: ShouldForceCombatCamera
    /// </summary>
    public unsafe virtual bool ShouldForceCombatCamera()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldForceCombatCamera, "BmGame.RBMCombatManager.ShouldForceCombatCamera");
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

    private static BmSDK.Function __fn_ShouldLockDoors;
    /// <summary>
    /// Function: ShouldLockDoors
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RGameInfo.ECombatLockType ShouldLockDoors()
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_ShouldLockDoors, "BmGame.RBMCombatManager.ShouldLockDoors");
        byte* paramsPtr = stackalloc byte[17];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RGameInfo.ECombatLockType>(paramsPtr + 0);
    }

    private static BmSDK.Function __fn_IsAnyVillainNearLocation;
    /// <summary>
    /// Function: IsAnyVillainNearLocation
    /// </summary>
    public unsafe virtual bool IsAnyVillainNearLocation(System.Numerics.Vector3 TestLocation, float TestRadius)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsAnyVillainNearLocation, "BmGame.RBMCombatManager.IsAnyVillainNearLocation");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestRadius, paramsPtr + 12);
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

    private static BmSDK.Function __fn_IsCombatantNearLocation;
    /// <summary>
    /// Function: IsCombatantNearLocation
    /// </summary>
    public unsafe virtual bool IsCombatantNearLocation(System.Numerics.Vector3 TestLocation, float TestRadius)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsCombatantNearLocation, "BmGame.RBMCombatManager.IsCombatantNearLocation");
        byte* paramsPtr = stackalloc byte[36];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestRadius, paramsPtr + 12);
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

    private static BmSDK.Function __fn_IsLocationInCombatArea;
    /// <summary>
    /// Function: IsLocationInCombatArea
    /// </summary>
    public unsafe virtual bool IsLocationInCombatArea(System.Numerics.Vector3 TestLocation, bool useOuterRadius, out BmSDK.BmGame.RCombatArea CombatArea)
    {
        BmSDK.Framework.Guard.NotDestroyed(this);
        var funcManaged = BmSDK.Framework.FunctionCache.Get(ref __fn_IsLocationInCombatArea, "BmGame.RBMCombatManager.IsLocationInCombatArea");
        byte* paramsPtr = stackalloc byte[40];
        paramsPtr = (byte*)(((nint)paramsPtr + 15) & ~(nint)15);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(useOuterRadius, paramsPtr + 12);
        System.Runtime.CompilerServices.Unsafe.SkipInit(out CombatArea);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatArea, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        CombatArea = BmSDK.Framework.MarshalUtil.ToManagedParam<BmSDK.BmGame.RCombatArea>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManagedParam<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// Struct: FVenomDifficultyDefine
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FVenomDifficultyDefine
    {
        /// <summary>
        /// FloatProperty: EasyValue
        /// </summary>
        public unsafe float EasyValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: NormalValue
        /// </summary>
        public unsafe float NormalValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: HardValue
        /// </summary>
        public unsafe float HardValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: EVenomDifficultyType
    /// </summary>
    public enum EVenomDifficultyType : byte
    {
        EVDT_Health = 0,
        EVDT_TakeDamageBatarangLight = 1,
        EVDT_TakeDamageBatarangHeavy = 2,
        EVDT_TakeDamageQuickBatmanStrike = 3,
        EVDT_TakeDamageHeavyBatmanStrike = 4,
        EVDT_TakeDamageWallSlam = 5,
        EVDT_TakeDamageBatmanUppercutAttack = 6,
        EVDT_TakeDamageBatmanUppercutExhaustedAttack = 7,
        EVDT_TakeDamageVenomAttack = 8,
        EVDT_TakeDamageRide = 9,
        EVDT_TakeDamageExplosiveGel = 10,
        EVDT_TakeDamageBeatUp = 11,
        EVDT_TakeDamageBeatUpEnd = 12,
        EVDT_GiveDamageThrow = 13,
        EVDT_GiveDamageCharge = 14,
        EVDT_GiveDamageBerserk = 15,
        EVDT_GiveDamageBerserkBatman = 16,
        EVDT_GiveDamagePunch = 17,
        EVDT_GiveDamageRide = 18,
        EVDT_GiveDamageRetaliationPunch = 19,
        EVDT_ChargeHomingValue = 20,
        EVDT_RechargeAt3Bars = 21,
        EVDT_RechargeAt2Bars = 22,
        EVDT_RechargeAt1Bar = 23,
        EVDT_AttacksAt3Bars = 24,
        EVDT_AttacksAt2Bars = 25,
        EVDT_AttacksAt1Bar = 26,
        EVDT_MAX = 27,
    }

    /// <summary>
    /// Struct: FDifficultyProgressionDefine
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FDifficultyProgressionDefine
    {
        /// <summary>
        /// FloatProperty: MinChapter
        /// </summary>
        public unsafe float MinChapter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: MaxChapter
        /// </summary>
        public unsafe float MaxChapter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: EasyValue
        /// </summary>
        public unsafe float EasyValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: HardValue
        /// </summary>
        public unsafe float HardValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: DebugMenuIncrement
        /// </summary>
        public unsafe float DebugMenuIncrement
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// BoolProperty: bOpenInDebugMenu
        /// </summary>
        public unsafe bool bOpenInDebugMenu
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Enum: EDifficultyType
    /// </summary>
    public enum EDifficultyType : byte
    {
        EDT_DamageUnarmed = 0,
        EDT_DamagePipe = 1,
        EDT_DamageBox = 2,
        EDT_DamageStunStickRepel = 3,
        EDT_DamageStunStickAttack = 4,
        EDT_DamageKnife = 5,
        EDT_DamageCombatGun = 6,
        EDT_DamageNinja = 7,
        EDT_EnemyHealth = 8,
        EDT_StrikeDurationScale = 9,
        EDT_BladeDurationScale = 10,
        EDT_TimeBeforeNextStrike = 11,
        EDT_LieutenantJumpSpeedScale = 12,
        EDT_LieutenantDamage = 13,
        EDT_MAX = 14,
    }

    /// <summary>
    /// Struct: FWeaponConfigRef
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FWeaponConfigRef
    {
        /// <summary>
        /// ObjectProperty: WeaponConfig
        /// </summary>
        public unsafe BmSDK.BmGame.RWeaponConfig WeaponConfig
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: RefCount
        /// </summary>
        public unsafe int RefCount
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Enum: EWeaponConfigType
    /// </summary>
    public enum EWeaponConfigType : byte
    {
        WEAPONCONFIG_None = 0,
        WEAPONCONFIG_Unarmed = 1,
        WEAPONCONFIG_Knife = 2,
        WEAPONCONFIG_Pipe = 3,
        WEAPONCONFIG_Shield = 4,
        WEAPONCONFIG_StunStick = 5,
        WEAPONCONFIG_HeavyObject = 6,
        WEAPONCONFIG_Ninja = 7,
        WEAPONCONFIG_NinjaSword = 8,
        WEAPONCONFIG_CopperheadBoss = 9,
        WEAPONCONFIG_Outcast = 10,
        WEAPONCONFIG_CrowdOutcast = 11,
        WEAPONCONFIG_Hobo = 12,
        WEAPONCONFIG_PredatorUnarmed = 13,
        WEAPONCONFIG_PredatorRifle = 14,
        WEAPONCONFIG_PredatorShotgun = 15,
        WEAPONCONFIG_LitePredatorRifle = 16,
        WEAPONCONFIG_CrowdCourtB1_1 = 17,
        WEAPONCONFIG_CrowdCourtB1_2 = 18,
        WEAPONCONFIG_CrowdCourtB1_3 = 19,
        WEAPONCONFIG_CrowdCourtB1_4 = 20,
        WEAPONCONFIG_CrowdCourtB1_5 = 21,
        WEAPONCONFIG_MAX = 22,
    }

    /// <summary>
    /// ArrayProperty: CombatPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatPoint> CombatPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatPoint>>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// ArrayProperty: CombatAreas
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCombatArea> CombatAreas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCombatArea>>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// ArrayProperty: GuardPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCombatArea_GuardPoint> GuardPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCombatArea_GuardPoint>>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// ArrayProperty: ThrowTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RThrowTarget> ThrowTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RThrowTarget>>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// ArrayProperty: CombatEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCombatEvent> CombatEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCombatEvent>>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// IntProperty: CombatStepperIndex
    /// </summary>
    public unsafe int CombatStepperIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// ObjectProperty: CombatStepper
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat CombatStepper
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// FloatProperty: LastTauntTime
    /// </summary>
    public unsafe float LastTauntTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// IntProperty: LastTauntID
    /// </summary>
    public unsafe int LastTauntID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// FloatProperty: GlobalTimeSinceAttack
    /// </summary>
    public unsafe float GlobalTimeSinceAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// StructProperty: GlobalLastLocationAttack
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GlobalLastLocationAttack
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 532);

    /// <summary>
    /// BoolProperty: bSuppressFinalBlow
    /// </summary>
    public unsafe bool bSuppressFinalBlow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bCanAttack
    /// </summary>
    public unsafe bool bCanAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bDisableNinjaCounter
    /// </summary>
    public unsafe bool bDisableNinjaCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bDisableNinjaDespawn
    /// </summary>
    public unsafe bool bDisableNinjaDespawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bDisableCombatLock
    /// </summary>
    public unsafe bool bDisableCombatLock
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bShowKnifeThugTutorial
    /// </summary>
    public unsafe bool bShowKnifeThugTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bShowShieldThugTutorial
    /// </summary>
    public unsafe bool bShowShieldThugTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bShowStunStickThugTutorial
    /// </summary>
    public unsafe bool bShowStunStickThugTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bShowTitanThugTutorial
    /// </summary>
    public unsafe bool bShowTitanThugTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bShowRasHint
    /// </summary>
    public unsafe bool bShowRasHint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bExitCombatIfFarFromThugs
    /// </summary>
    public unsafe bool bExitCombatIfFarFromThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bShowMartialArtistTutorialDoubleAttack
    /// </summary>
    public unsafe bool bShowMartialArtistTutorialDoubleAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bShowMartialArtistTutorialComboAttack
    /// </summary>
    public unsafe bool bShowMartialArtistTutorialComboAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bBatmanGrabbedByVenomThug
    /// </summary>
    public unsafe bool bBatmanGrabbedByVenomThug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bBatmanGrabbedByVenomThugAndBeatDown
    /// </summary>
    public unsafe bool bBatmanGrabbedByVenomThugAndBeatDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bThugsShouldCheer
    /// </summary>
    public unsafe bool bThugsShouldCheer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bThugsShouldBoo
    /// </summary>
    public unsafe bool bThugsShouldBoo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bDisplayDifficultyDebug
    /// </summary>
    public unsafe bool bDisplayDifficultyDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bMoreThanOneCombatantHasBeenActive
    /// </summary>
    public unsafe bool bMoreThanOneCombatantHasBeenActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: ImpactRampIn
    /// </summary>
    public unsafe bool ImpactRampIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: ImpactRampOut
    /// </summary>
    public unsafe bool ImpactRampOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bPlayedSeeCombatBark
    /// </summary>
    public unsafe bool bPlayedSeeCombatBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bDisableKeepInViewOnHit
    /// </summary>
    public unsafe bool bDisableKeepInViewOnHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bDisableDDATracking
    /// </summary>
    public unsafe bool bDisableDDATracking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bMultiVenom
    /// </summary>
    public unsafe bool bMultiVenom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bSuspendCachingNumCombatants
    /// </summary>
    public unsafe bool bSuspendCachingNumCombatants
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bTriedToCacheNumCombatantsWhileSuspended
    /// </summary>
    public unsafe bool bTriedToCacheNumCombatantsWhileSuspended
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bPairedAnimLoadStartedThisFrame
    /// </summary>
    public unsafe bool bPairedAnimLoadStartedThisFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bHaveTeleportPoint
    /// </summary>
    public unsafe bool bHaveTeleportPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bNinjaDodgedLastStrike
    /// </summary>
    public unsafe bool bNinjaDodgedLastStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bNewGamePlus
    /// </summary>
    public unsafe bool bNewGamePlus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bNoCameraAssistance
    /// </summary>
    public unsafe bool bNoCameraAssistance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// ObjectProperty: LunaticMusic
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_LunaticMusicManager LunaticMusic
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_LunaticMusicManager>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// FloatProperty: TimeUntilNextMaxPawnsUpdate
    /// </summary>
    public unsafe float TimeUntilNextMaxPawnsUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// IntProperty: MaxCombatPawns
    /// </summary>
    public unsafe int MaxCombatPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// FloatProperty: OverrideChapter
    /// </summary>
    public unsafe float OverrideChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_StartCombatChallengeBase ChallengeAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_StartCombatChallengeBase>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// FloatProperty: LastBMSightingTime
    /// </summary>
    public unsafe float LastBMSightingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// StructProperty: LastSightingLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastSightingLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 572);

    /// <summary>
    /// ArrayProperty: VillainBlockerList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBunkerDoorVillainBlocker> VillainBlockerList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBunkerDoorVillainBlocker>>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// FloatProperty: PawnHealthMultiplier
    /// </summary>
    public unsafe float PawnHealthMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// FloatProperty: SimultaneousAttackTimer
    /// </summary>
    public unsafe float SimultaneousAttackTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// IntProperty: NumSimultaneousAttackers
    /// </summary>
    public unsafe int NumSimultaneousAttackers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsWithKnives
    /// </summary>
    public unsafe int NumCombatantsWithKnives
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsWithShields
    /// </summary>
    public unsafe int NumCombatantsWithShields
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// FloatProperty: ShowArmouredThugTutorialTimer
    /// </summary>
    public unsafe float ShowArmouredThugTutorialTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsWithStunSticks
    /// </summary>
    public unsafe int NumCombatantsWithStunSticks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsWithGuns
    /// </summary>
    public unsafe int NumCombatantsWithGuns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsWithWeapons
    /// </summary>
    public unsafe int NumCombatantsWithWeapons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsWithBatPipeSledge
    /// </summary>
    public unsafe int NumCombatantsWithBatPipeSledge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsWithHeavyObjects
    /// </summary>
    public unsafe int NumCombatantsWithHeavyObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsWithExplosives
    /// </summary>
    public unsafe int NumCombatantsWithExplosives
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsAIvsAI
    /// </summary>
    public unsafe int NumCombatantsAIvsAI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsMartialArtist
    /// </summary>
    public unsafe int NumCombatantsMartialArtist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsLunatics
    /// </summary>
    public unsafe int NumCombatantsLunatics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// FloatProperty: LastCombatRollTime
    /// </summary>
    public unsafe float LastCombatRollTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// ArrayProperty: CombatPylons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Pylon> CombatPylons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Pylon>>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// ArrayProperty: CombatantsJoining
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain> CombatantsJoining
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// FloatProperty: LastExplosivePickedUpTime
    /// </summary>
    public unsafe float LastExplosivePickedUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// FloatProperty: LastThrownObjectPickedUpTime
    /// </summary>
    public unsafe float LastThrownObjectPickedUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// ObjectProperty: SpecialCombatEventReceiver
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain SpecialCombatEventReceiver
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// FloatProperty: ShowArmouredLieutenantTutorialTimer
    /// </summary>
    public unsafe float ShowArmouredLieutenantTutorialTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ClassProperty: CheerMove
    /// </summary>
    public unsafe BmSDK.Class CheerMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// IntProperty: CheerMoveCounter
    /// </summary>
    public unsafe int CheerMoveCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ObjectProperty: PlayerIsLockByVillain
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat PlayerIsLockByVillain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ObjectProperty: DroneSearchLightMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMesh DroneSearchLightMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMesh>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// IntProperty: DroneSearchLightMeshCounter
    /// </summary>
    public unsafe int DroneSearchLightMeshCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// FloatProperty: IdealBMRangeOffset
    /// </summary>
    public unsafe float IdealBMRangeOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// FloatProperty: LastBarkPlayedTime
    /// </summary>
    public unsafe float LastBarkPlayedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: WeaponConfigs
    /// </summary>
    public InlineArray<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef> WeaponConfigs => new(21, Ptr + 728, 8, this);

    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 728);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 736);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 744);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 752);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 760);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 768);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 776);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 784);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 792);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_9
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 800);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_10
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 808);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_11
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 816);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_12
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 824);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_13
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 832);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_14
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 840);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_15
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 848);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_16
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 856);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_17
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 864);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_18
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 872);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_19
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 880);
    /// <summary>
    /// StructProperty: WeaponConfigs
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef WeaponConfigs_20
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMCombatManager.FWeaponConfigRef>(Ptr + 888);

    /// <summary>
    /// ArrayProperty: DifficultyProgressionDefines_Easy
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FDifficultyProgressionDefine> DifficultyProgressionDefines_Easy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FDifficultyProgressionDefine>>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// ArrayProperty: DifficultyProgressionDefines_Normal
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FDifficultyProgressionDefine> DifficultyProgressionDefines_Normal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FDifficultyProgressionDefine>>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// ArrayProperty: DifficultyProgressionDefines_Hard
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FDifficultyProgressionDefine> DifficultyProgressionDefines_Hard
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FDifficultyProgressionDefine>>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// ArrayProperty: MoveTypeScores
    /// </summary>
    public unsafe BmSDK.TArray<int> MoveTypeScores
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ArrayProperty: VenomDifficultyDefines
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FVenomDifficultyDefine> VenomDifficultyDefines
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FVenomDifficultyDefine>>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// ArrayProperty: VenomedThugList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCombat> VenomedThugList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCombat>>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// IntProperty: NumTimesRideCharge
    /// </summary>
    public unsafe int NumTimesRideCharge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// IntProperty: NumTimesRideShockwave
    /// </summary>
    public unsafe int NumTimesRideShockwave
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceLunaticAttack
    /// </summary>
    public unsafe float TimeSinceLunaticAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// IntProperty: NumCombatants
    /// </summary>
    public unsafe int NumCombatants
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// IntProperty: MaxCombatantsThisFight
    /// </summary>
    public unsafe int MaxCombatantsThisFight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// IntProperty: CombatKOsThisFight
    /// </summary>
    public unsafe int CombatKOsThisFight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// FloatProperty: TotalCombatHealth
    /// </summary>
    public unsafe float TotalCombatHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// IntProperty: CurrActiveCombatThugs
    /// </summary>
    public unsafe int CurrActiveCombatThugs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// FloatProperty: ActiveCombatTime
    /// </summary>
    public unsafe float ActiveCombatTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// FloatProperty: InActiveCombatTime
    /// </summary>
    public unsafe float InActiveCombatTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// FloatProperty: ImpactMinSpeed
    /// </summary>
    public unsafe float ImpactMinSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// FloatProperty: ImpactPreTime
    /// </summary>
    public unsafe float ImpactPreTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// FloatProperty: ImpactPostTime
    /// </summary>
    public unsafe float ImpactPostTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// FloatProperty: ImpactRampInEnd
    /// </summary>
    public unsafe float ImpactRampInEnd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// FloatProperty: ImpactRampOutStart
    /// </summary>
    public unsafe float ImpactRampOutStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// FloatProperty: LastPunishingAttackTime
    /// </summary>
    public unsafe float LastPunishingAttackTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// FloatProperty: LastBarkTime
    /// </summary>
    public unsafe float LastBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// FloatProperty: LastJoinCombatBarkTime
    /// </summary>
    public unsafe float LastJoinCombatBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// StructProperty: LastJoinCombatBarkPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastJoinCombatBarkPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1040);

    /// <summary>
    /// FloatProperty: TimeBetweenBarkMultiplier
    /// </summary>
    public unsafe float TimeBetweenBarkMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// FloatProperty: CanAttackTime
    /// </summary>
    public unsafe float CanAttackTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// FloatProperty: MinCombatFOV
    /// </summary>
    public unsafe float MinCombatFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// IntProperty: MinCombatFOVNum
    /// </summary>
    public unsafe int MinCombatFOVNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// FloatProperty: MaxCombatFOV
    /// </summary>
    public unsafe float MaxCombatFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// IntProperty: MaxCombatFOVNum
    /// </summary>
    public unsafe int MaxCombatFOVNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// IntProperty: OverrideNumCombatants
    /// </summary>
    public unsafe int OverrideNumCombatants
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// NameProperty: FinishedCombatName
    /// </summary>
    public unsafe BmSDK.FName FinishedCombatName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ObjectProperty: PawnToKeepInView
    /// </summary>
    public unsafe BmSDK.Engine.Actor PawnToKeepInView
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// FloatProperty: MaxYawOffsetRad
    /// </summary>
    public unsafe float MaxYawOffsetRad
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// FloatProperty: MaxPitchOffsetRad
    /// </summary>
    public unsafe float MaxPitchOffsetRad
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// FloatProperty: CurrMaxYawOffset
    /// </summary>
    public unsafe float CurrMaxYawOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// NameProperty: LastPickupClassName
    /// </summary>
    public unsafe BmSDK.FName LastPickupClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// FloatProperty: PickupBarkTime
    /// </summary>
    public unsafe float PickupBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// InlineArray{ClassProperty}: VenomAttackHistory
    /// </summary>
    public InlineArray<BmSDK.Class> VenomAttackHistory => new(2, Ptr + 1116, 4, this);

    /// <summary>
    /// ClassProperty: VenomAttackHistory
    /// </summary>
    public unsafe BmSDK.Class VenomAttackHistory_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }
    /// <summary>
    /// ClassProperty: VenomAttackHistory
    /// </summary>
    public unsafe BmSDK.Class VenomAttackHistory_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// FloatProperty: MaxOnscreenCosAngleZ
    /// </summary>
    public unsafe float MaxOnscreenCosAngleZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// FloatProperty: MaxOnscreenCosAngleXY
    /// </summary>
    public unsafe float MaxOnscreenCosAngleXY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// IntProperty: ProtectionStatus
    /// </summary>
    public unsafe int ProtectionStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// ObjectProperty: GameRepInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI GameRepInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// FloatProperty: LastThrowBrickTime
    /// </summary>
    public unsafe float LastThrowBrickTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// ObjectProperty: TeleportPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RCombatTeleport TeleportPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCombatTeleport>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// IntProperty: Counter1
    /// </summary>
    public unsafe int Counter1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// IntProperty: Counter2
    /// </summary>
    public unsafe int Counter2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// IntProperty: Counter3
    /// </summary>
    public unsafe int Counter3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// IntProperty: NumberStrikesAgainstNinjas
    /// </summary>
    public unsafe int NumberStrikesAgainstNinjas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// IntProperty: NumberNinjaDodges
    /// </summary>
    public unsafe int NumberNinjaDodges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// FloatProperty: LastNinjaDodgeTime
    /// </summary>
    public unsafe float LastNinjaDodgeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// IntProperty: NumberNinjaCounters
    /// </summary>
    public unsafe int NumberNinjaCounters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }

    /// <summary>
    /// ObjectProperty: mCurrentFreeFlowCombatConfig
    /// </summary>
    public unsafe BmSDK.BmGame.MFreeFlowCombatConfig mCurrentFreeFlowCombatConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MFreeFlowCombatConfig>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// FloatProperty: mPickupGunTime
    /// </summary>
    public unsafe float mPickupGunTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// FloatProperty: mPickupKnifeTime
    /// </summary>
    public unsafe float mPickupKnifeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// FloatProperty: mPickupBatPipeSledgeTime
    /// </summary>
    public unsafe float mPickupBatPipeSledgeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// FloatProperty: mPickupShieldTime
    /// </summary>
    public unsafe float mPickupShieldTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// FloatProperty: mPickupStunStickTime
    /// </summary>
    public unsafe float mPickupStunStickTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// FloatProperty: mPickupHeavyObjectTime
    /// </summary>
    public unsafe float mPickupHeavyObjectTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// FloatProperty: mPickupExplosiveTime
    /// </summary>
    public unsafe float mPickupExplosiveTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }

    /// <summary>
    /// ObjectProperty: mDefaultFreeFlowCombatConfig
    /// </summary>
    public unsafe BmSDK.BmGame.MFreeFlowCombatConfig mDefaultFreeFlowCombatConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MFreeFlowCombatConfig>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// IntProperty: MaxSimCounterersOverride
    /// </summary>
    public unsafe int MaxSimCounterersOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsForInterrogation
    /// </summary>
    public unsafe int NumCombatantsForInterrogation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// IntProperty: NumCombatantsJoiningForInterrogation
    /// </summary>
    public unsafe int NumCombatantsJoiningForInterrogation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1220); }
    }
}
